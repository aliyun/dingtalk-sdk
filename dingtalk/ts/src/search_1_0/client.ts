// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class BatchInsertSearchItemHeaders extends $tea.Model {
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

export class BatchInsertSearchItemRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  searchItemModels?: BatchInsertSearchItemRequestSearchItemModels[];
  static names(): { [key: string]: string } {
    return {
      searchItemModels: 'searchItemModels',
    };
  }

  static types(): { [key: string]: any } {
    return {
      searchItemModels: { 'type': 'array', 'itemType': BatchInsertSearchItemRequestSearchItemModels },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchInsertSearchItemResponse extends $tea.Model {
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

export class CreateSearchTabHeaders extends $tea.Model {
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

export class CreateSearchTabRequest extends $tea.Model {
  darkIcon?: string;
  /**
   * **if can be null:**
   * false
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 书籍
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  priority?: number;
  source?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  status?: number;
  static names(): { [key: string]: string } {
    return {
      darkIcon: 'darkIcon',
      icon: 'icon',
      name: 'name',
      priority: 'priority',
      source: 'source',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      darkIcon: 'string',
      icon: 'string',
      name: 'string',
      priority: 'number',
      source: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSearchTabResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3333
   */
  tabId?: number;
  static names(): { [key: string]: string } {
    return {
      tabId: 'tabId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tabId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSearchTabResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateSearchTabResponseBody;
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
      body: CreateSearchTabResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSearchItemHeaders extends $tea.Model {
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

export class DeleteSearchItemResponse extends $tea.Model {
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

export class DeleteSearchTabHeaders extends $tea.Model {
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

export class DeleteSearchTabResponse extends $tea.Model {
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

export class GetSearchItemHeaders extends $tea.Model {
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

export class GetSearchItemResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 四大名著
   */
  footer?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-09-17T19:43Z
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-09-17T19:43Z
   */
  gmtModified?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1111
   */
  itemId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * www.baidu.com
   */
  mobileUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * www.baidu.com
   */
  pcUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 中国古代章回体长篇小说
   */
  summary?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3333
   */
  tabId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 红楼梦
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * www.baidu.com
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      footer: 'footer',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      icon: 'icon',
      itemId: 'itemId',
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
      summary: 'summary',
      tabId: 'tabId',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      footer: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
      icon: 'string',
      itemId: 'string',
      mobileUrl: 'string',
      pcUrl: 'string',
      summary: 'string',
      tabId: 'number',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSearchItemResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSearchItemResponseBody;
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
      body: GetSearchItemResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSearchItemsByKeyWordHeaders extends $tea.Model {
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

export class GetSearchItemsByKeyWordRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 诺贝尔奖
   */
  keyWord?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      keyWord: 'keyWord',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      keyWord: 'string',
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSearchItemsByKeyWordResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  totalCount?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  value?: GetSearchItemsByKeyWordResponseBodyValue[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      totalCount: 'totalCount',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      totalCount: 'number',
      value: { 'type': 'array', 'itemType': GetSearchItemsByKeyWordResponseBodyValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSearchItemsByKeyWordResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSearchItemsByKeyWordResponseBody;
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
      body: GetSearchItemsByKeyWordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSearchTabHeaders extends $tea.Model {
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

export class GetSearchTabResponseBody extends $tea.Model {
  darkIcon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-09-17T19:43Z
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-09-17T19:43Z
   */
  gmtModified?: string;
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 专辑
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  priority?: number;
  source?: string;
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
   * 3333
   */
  tabId?: number;
  static names(): { [key: string]: string } {
    return {
      darkIcon: 'darkIcon',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      icon: 'icon',
      name: 'name',
      priority: 'priority',
      source: 'source',
      status: 'status',
      tabId: 'tabId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      darkIcon: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
      icon: 'string',
      name: 'string',
      priority: 'number',
      source: 'string',
      status: 'number',
      tabId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSearchTabResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSearchTabResponseBody;
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
      body: GetSearchTabResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSearchItemHeaders extends $tea.Model {
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

export class InsertSearchItemRequest extends $tea.Model {
  /**
   * @example
   * 四大名著
   */
  footer?: string;
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1111
   */
  itemId?: string;
  /**
   * @example
   * www.baidu.com
   */
  mobileUrl?: string;
  /**
   * @example
   * www.baidu.com
   */
  pcUrl?: string;
  /**
   * @example
   * 中国古代章回体长篇小说
   */
  summary?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 红楼梦
   */
  title?: string;
  /**
   * @example
   * www.baidu.com
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      footer: 'footer',
      icon: 'icon',
      itemId: 'itemId',
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
      summary: 'summary',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      footer: 'string',
      icon: 'string',
      itemId: 'string',
      mobileUrl: 'string',
      pcUrl: 'string',
      summary: 'string',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSearchItemResponse extends $tea.Model {
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

export class ListSearchTabsByOrgIdHeaders extends $tea.Model {
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

export class ListSearchTabsByOrgIdResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  searchTabResult?: ListSearchTabsByOrgIdResponseBodySearchTabResult[];
  static names(): { [key: string]: string } {
    return {
      searchTabResult: 'searchTabResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      searchTabResult: { 'type': 'array', 'itemType': ListSearchTabsByOrgIdResponseBodySearchTabResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSearchTabsByOrgIdResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListSearchTabsByOrgIdResponseBody;
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
      body: ListSearchTabsByOrgIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSearchTabHeaders extends $tea.Model {
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

export class UpdateSearchTabRequest extends $tea.Model {
  darkIcon?: string;
  /**
   * **if can be null:**
   * false
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 专辑
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  priority?: number;
  source?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  status?: number;
  static names(): { [key: string]: string } {
    return {
      darkIcon: 'darkIcon',
      icon: 'icon',
      name: 'name',
      priority: 'priority',
      source: 'source',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      darkIcon: 'string',
      icon: 'string',
      name: 'string',
      priority: 'number',
      source: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSearchTabResponse extends $tea.Model {
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

export class BatchInsertSearchItemRequestSearchItemModels extends $tea.Model {
  /**
   * @example
   * 四大名著
   */
  footer?: string;
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1111
   */
  itemId?: string;
  /**
   * @example
   * www.baidu.com
   */
  mobileUrl?: string;
  /**
   * @example
   * www.baidu.com
   */
  pcUrl?: string;
  /**
   * @example
   * 中国古代章回体长篇小说
   */
  summary?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 红楼梦
   */
  title?: string;
  /**
   * @example
   * www.baidu.com
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      footer: 'footer',
      icon: 'icon',
      itemId: 'itemId',
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
      summary: 'summary',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      footer: 'string',
      icon: 'string',
      itemId: 'string',
      mobileUrl: 'string',
      pcUrl: 'string',
      summary: 'string',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSearchItemsByKeyWordResponseBodyValue extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 四大名著
   */
  footer?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-09-17T19:43Z
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-09-17T19:43Z
   */
  gmtModified?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1111
   */
  itemId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * www.baidu.com
   */
  mobileUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * www.baidu.com
   */
  pcUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 中国古代章回体长篇小说
   */
  summary?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3333
   */
  tabId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 红楼梦
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * www.baidu.com
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      footer: 'footer',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      icon: 'icon',
      itemId: 'itemId',
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
      summary: 'summary',
      tabId: 'tabId',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      footer: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
      icon: 'string',
      itemId: 'string',
      mobileUrl: 'string',
      pcUrl: 'string',
      summary: 'string',
      tabId: 'number',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSearchTabsByOrgIdResponseBodySearchTabResult extends $tea.Model {
  darkIcon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-09-17T19:43Z
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-09-17T19:43Z
   */
  gmtModified?: string;
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 专辑
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  priority?: number;
  source?: string;
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
   * 3333
   */
  tabId?: number;
  static names(): { [key: string]: string } {
    return {
      darkIcon: 'darkIcon',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      icon: 'icon',
      name: 'name',
      priority: 'priority',
      source: 'source',
      status: 'status',
      tabId: 'tabId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      darkIcon: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
      icon: 'string',
      name: 'string',
      priority: 'number',
      source: 'string',
      status: 'number',
      tabId: 'number',
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
   * 为指定的数据源批量添加数据项
   * 
   * @param request - BatchInsertSearchItemRequest
   * @param headers - BatchInsertSearchItemHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchInsertSearchItemResponse
   */
  async batchInsertSearchItemWithOptions(tabId: string, request: BatchInsertSearchItemRequest, headers: BatchInsertSearchItemHeaders, runtime: $Util.RuntimeOptions): Promise<BatchInsertSearchItemResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.searchItemModels)) {
      body["searchItemModels"] = request.searchItemModels;
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
      action: "BatchInsertSearchItem",
      version: "search_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/search/tabs/${tabId}/items/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<BatchInsertSearchItemResponse>(await this.execute(params, req, runtime), new BatchInsertSearchItemResponse({}));
  }

  /**
   * 为指定的数据源批量添加数据项
   * 
   * @param request - BatchInsertSearchItemRequest
   * @returns BatchInsertSearchItemResponse
   */
  async batchInsertSearchItem(tabId: string, request: BatchInsertSearchItemRequest): Promise<BatchInsertSearchItemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchInsertSearchItemHeaders({ });
    return await this.batchInsertSearchItemWithOptions(tabId, request, headers, runtime);
  }

  /**
   * 创建搜索数据源
   * 
   * @param request - CreateSearchTabRequest
   * @param headers - CreateSearchTabHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateSearchTabResponse
   */
  async createSearchTabWithOptions(request: CreateSearchTabRequest, headers: CreateSearchTabHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSearchTabResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.darkIcon)) {
      body["darkIcon"] = request.darkIcon;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.priority)) {
      body["priority"] = request.priority;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateSearchTab",
      version: "search_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/search/tabs`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateSearchTabResponse>(await this.execute(params, req, runtime), new CreateSearchTabResponse({}));
  }

  /**
   * 创建搜索数据源
   * 
   * @param request - CreateSearchTabRequest
   * @returns CreateSearchTabResponse
   */
  async createSearchTab(request: CreateSearchTabRequest): Promise<CreateSearchTabResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSearchTabHeaders({ });
    return await this.createSearchTabWithOptions(request, headers, runtime);
  }

  /**
   * 从指定的数据源中删除一条数据项
   * 
   * @param headers - DeleteSearchItemHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteSearchItemResponse
   */
  async deleteSearchItemWithOptions(tabId: string, itemId: string, headers: DeleteSearchItemHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteSearchItemResponse> {
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
      action: "DeleteSearchItem",
      version: "search_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/search/tabs/${tabId}/items/${itemId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteSearchItemResponse>(await this.execute(params, req, runtime), new DeleteSearchItemResponse({}));
  }

  /**
   * 从指定的数据源中删除一条数据项
   * @returns DeleteSearchItemResponse
   */
  async deleteSearchItem(tabId: string, itemId: string): Promise<DeleteSearchItemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSearchItemHeaders({ });
    return await this.deleteSearchItemWithOptions(tabId, itemId, headers, runtime);
  }

  /**
   * 删除搜索数据源
   * 
   * @param headers - DeleteSearchTabHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteSearchTabResponse
   */
  async deleteSearchTabWithOptions(tabId: string, headers: DeleteSearchTabHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteSearchTabResponse> {
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
      action: "DeleteSearchTab",
      version: "search_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/search/tabs/${tabId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteSearchTabResponse>(await this.execute(params, req, runtime), new DeleteSearchTabResponse({}));
  }

  /**
   * 删除搜索数据源
   * @returns DeleteSearchTabResponse
   */
  async deleteSearchTab(tabId: string): Promise<DeleteSearchTabResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSearchTabHeaders({ });
    return await this.deleteSearchTabWithOptions(tabId, headers, runtime);
  }

  /**
   * 获取指定数据源中的一条数据项
   * 
   * @param headers - GetSearchItemHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSearchItemResponse
   */
  async getSearchItemWithOptions(tabId: string, itemId: string, headers: GetSearchItemHeaders, runtime: $Util.RuntimeOptions): Promise<GetSearchItemResponse> {
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
      action: "GetSearchItem",
      version: "search_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/search/tabs/${tabId}/items/${itemId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSearchItemResponse>(await this.execute(params, req, runtime), new GetSearchItemResponse({}));
  }

  /**
   * 获取指定数据源中的一条数据项
   * @returns GetSearchItemResponse
   */
  async getSearchItem(tabId: string, itemId: string): Promise<GetSearchItemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSearchItemHeaders({ });
    return await this.getSearchItemWithOptions(tabId, itemId, headers, runtime);
  }

  /**
   * 根据搜索关键词获取相关数据项
   * 
   * @param request - GetSearchItemsByKeyWordRequest
   * @param headers - GetSearchItemsByKeyWordHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSearchItemsByKeyWordResponse
   */
  async getSearchItemsByKeyWordWithOptions(tabId: string, request: GetSearchItemsByKeyWordRequest, headers: GetSearchItemsByKeyWordHeaders, runtime: $Util.RuntimeOptions): Promise<GetSearchItemsByKeyWordResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.keyWord)) {
      query["keyWord"] = request.keyWord;
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
    });
    let params = new $OpenApi.Params({
      action: "GetSearchItemsByKeyWord",
      version: "search_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/search/tabs/${tabId}/items`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSearchItemsByKeyWordResponse>(await this.execute(params, req, runtime), new GetSearchItemsByKeyWordResponse({}));
  }

  /**
   * 根据搜索关键词获取相关数据项
   * 
   * @param request - GetSearchItemsByKeyWordRequest
   * @returns GetSearchItemsByKeyWordResponse
   */
  async getSearchItemsByKeyWord(tabId: string, request: GetSearchItemsByKeyWordRequest): Promise<GetSearchItemsByKeyWordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSearchItemsByKeyWordHeaders({ });
    return await this.getSearchItemsByKeyWordWithOptions(tabId, request, headers, runtime);
  }

  /**
   * 获取搜索数据源
   * 
   * @param headers - GetSearchTabHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSearchTabResponse
   */
  async getSearchTabWithOptions(tabId: string, headers: GetSearchTabHeaders, runtime: $Util.RuntimeOptions): Promise<GetSearchTabResponse> {
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
      action: "GetSearchTab",
      version: "search_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/search/tabs/${tabId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSearchTabResponse>(await this.execute(params, req, runtime), new GetSearchTabResponse({}));
  }

  /**
   * 获取搜索数据源
   * @returns GetSearchTabResponse
   */
  async getSearchTab(tabId: string): Promise<GetSearchTabResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSearchTabHeaders({ });
    return await this.getSearchTabWithOptions(tabId, headers, runtime);
  }

  /**
   * 为指定的数据源添加一条数据项
   * 
   * @param request - InsertSearchItemRequest
   * @param headers - InsertSearchItemHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns InsertSearchItemResponse
   */
  async insertSearchItemWithOptions(tabId: string, request: InsertSearchItemRequest, headers: InsertSearchItemHeaders, runtime: $Util.RuntimeOptions): Promise<InsertSearchItemResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.footer)) {
      body["footer"] = request.footer;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.itemId)) {
      body["itemId"] = request.itemId;
    }

    if (!Util.isUnset(request.mobileUrl)) {
      body["mobileUrl"] = request.mobileUrl;
    }

    if (!Util.isUnset(request.pcUrl)) {
      body["pcUrl"] = request.pcUrl;
    }

    if (!Util.isUnset(request.summary)) {
      body["summary"] = request.summary;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.url)) {
      body["url"] = request.url;
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
      action: "InsertSearchItem",
      version: "search_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/search/tabs/${tabId}/items`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<InsertSearchItemResponse>(await this.execute(params, req, runtime), new InsertSearchItemResponse({}));
  }

  /**
   * 为指定的数据源添加一条数据项
   * 
   * @param request - InsertSearchItemRequest
   * @returns InsertSearchItemResponse
   */
  async insertSearchItem(tabId: string, request: InsertSearchItemRequest): Promise<InsertSearchItemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InsertSearchItemHeaders({ });
    return await this.insertSearchItemWithOptions(tabId, request, headers, runtime);
  }

  /**
   * 列出企业所有的搜索数据源
   * 
   * @param headers - ListSearchTabsByOrgIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListSearchTabsByOrgIdResponse
   */
  async listSearchTabsByOrgIdWithOptions(headers: ListSearchTabsByOrgIdHeaders, runtime: $Util.RuntimeOptions): Promise<ListSearchTabsByOrgIdResponse> {
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
      action: "ListSearchTabsByOrgId",
      version: "search_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/search/tabs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListSearchTabsByOrgIdResponse>(await this.execute(params, req, runtime), new ListSearchTabsByOrgIdResponse({}));
  }

  /**
   * 列出企业所有的搜索数据源
   * @returns ListSearchTabsByOrgIdResponse
   */
  async listSearchTabsByOrgId(): Promise<ListSearchTabsByOrgIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSearchTabsByOrgIdHeaders({ });
    return await this.listSearchTabsByOrgIdWithOptions(headers, runtime);
  }

  /**
   * 更新搜索数据源
   * 
   * @param request - UpdateSearchTabRequest
   * @param headers - UpdateSearchTabHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateSearchTabResponse
   */
  async updateSearchTabWithOptions(tabId: string, request: UpdateSearchTabRequest, headers: UpdateSearchTabHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateSearchTabResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.darkIcon)) {
      body["darkIcon"] = request.darkIcon;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.priority)) {
      body["priority"] = request.priority;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateSearchTab",
      version: "search_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/search/tabs/${tabId}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<UpdateSearchTabResponse>(await this.execute(params, req, runtime), new UpdateSearchTabResponse({}));
  }

  /**
   * 更新搜索数据源
   * 
   * @param request - UpdateSearchTabRequest
   * @returns UpdateSearchTabResponse
   */
  async updateSearchTab(tabId: string, request: UpdateSearchTabRequest): Promise<UpdateSearchTabResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateSearchTabHeaders({ });
    return await this.updateSearchTabWithOptions(tabId, request, headers, runtime);
  }

}
