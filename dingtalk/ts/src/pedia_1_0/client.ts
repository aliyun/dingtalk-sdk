// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class PediaWordsAddHeaders extends $tea.Model {
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

export class PediaWordsAddRequest extends $tea.Model {
  contactList?: PediaWordsAddRequestContactList[];
  highLightWordAlias?: string[];
  picList?: PediaWordsAddRequestPicList[];
  relatedDoc?: PediaWordsAddRequestRelatedDoc[];
  relatedLink?: PediaWordsAddRequestRelatedLink[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 23231231123
   */
  userId?: string;
  wordAlias?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 词条名称
   */
  wordName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 释义
   */
  wordParaphrase?: string;
  static names(): { [key: string]: string } {
    return {
      contactList: 'contactList',
      highLightWordAlias: 'highLightWordAlias',
      picList: 'picList',
      relatedDoc: 'relatedDoc',
      relatedLink: 'relatedLink',
      userId: 'userId',
      wordAlias: 'wordAlias',
      wordName: 'wordName',
      wordParaphrase: 'wordParaphrase',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contactList: { 'type': 'array', 'itemType': PediaWordsAddRequestContactList },
      highLightWordAlias: { 'type': 'array', 'itemType': 'string' },
      picList: { 'type': 'array', 'itemType': PediaWordsAddRequestPicList },
      relatedDoc: { 'type': 'array', 'itemType': PediaWordsAddRequestRelatedDoc },
      relatedLink: { 'type': 'array', 'itemType': PediaWordsAddRequestRelatedLink },
      userId: 'string',
      wordAlias: { 'type': 'array', 'itemType': 'string' },
      wordName: 'string',
      wordParaphrase: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsAddResponseBody extends $tea.Model {
  success?: boolean;
  /**
   * @example
   * 232432
   */
  uuid?: number;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      uuid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsAddResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PediaWordsAddResponseBody;
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
      body: PediaWordsAddResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsApproveHeaders extends $tea.Model {
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

export class PediaWordsApproveRequest extends $tea.Model {
  /**
   * @example
   * 拒绝
   */
  approveReason?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  approveStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  imHighLight?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  simHighLight?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 232432
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1213132
   */
  uuid?: number;
  static names(): { [key: string]: string } {
    return {
      approveReason: 'approveReason',
      approveStatus: 'approveStatus',
      imHighLight: 'imHighLight',
      simHighLight: 'simHighLight',
      userId: 'userId',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approveReason: 'string',
      approveStatus: 'string',
      imHighLight: 'boolean',
      simHighLight: 'boolean',
      userId: 'string',
      uuid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsApproveResponseBody extends $tea.Model {
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

export class PediaWordsApproveResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PediaWordsApproveResponseBody;
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
      body: PediaWordsApproveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsDeleteHeaders extends $tea.Model {
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

export class PediaWordsDeleteRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2123132
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 212112
   */
  uuid?: number;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      uuid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsDeleteResponseBody extends $tea.Model {
  success?: boolean;
  /**
   * @example
   * 123456789
   */
  uuid?: number;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      uuid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsDeleteResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PediaWordsDeleteResponseBody;
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
      body: PediaWordsDeleteResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsQueryHeaders extends $tea.Model {
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

export class PediaWordsQueryRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 212121
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 211121
   */
  uuid?: number;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      uuid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsQueryResponseBody extends $tea.Model {
  data?: PediaWordsQueryResponseBodyData;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: PediaWordsQueryResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsQueryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PediaWordsQueryResponseBody;
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
      body: PediaWordsQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsSearchHeaders extends $tea.Model {
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

export class PediaWordsSearchRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  status?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 121213213
   */
  userId?: string;
  /**
   * @example
   * 企业百科
   * 
   * **if can be null:**
   * false
   */
  wordName?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      status: 'status',
      userId: 'userId',
      wordName: 'wordName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      status: 'string',
      userId: 'string',
      wordName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsSearchResponseBody extends $tea.Model {
  data?: PediaWordsSearchResponseBodyData[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': PediaWordsSearchResponseBodyData },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsSearchResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PediaWordsSearchResponseBody;
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
      body: PediaWordsSearchResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsUpdateHeaders extends $tea.Model {
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

export class PediaWordsUpdateRequest extends $tea.Model {
  appLink?: PediaWordsUpdateRequestAppLink[];
  contactList?: PediaWordsUpdateRequestContactList[];
  highLightWordAlias?: string[];
  picList?: PediaWordsUpdateRequestPicList[];
  relatedDoc?: PediaWordsUpdateRequestRelatedDoc[];
  relatedLink?: PediaWordsUpdateRequestRelatedLink[];
  /**
   * @example
   * 312123213
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2131321
   */
  uuid?: number;
  wordAlias?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 词条名称
   */
  wordName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 释义
   */
  wordParaphrase?: string;
  static names(): { [key: string]: string } {
    return {
      appLink: 'appLink',
      contactList: 'contactList',
      highLightWordAlias: 'highLightWordAlias',
      picList: 'picList',
      relatedDoc: 'relatedDoc',
      relatedLink: 'relatedLink',
      userId: 'userId',
      uuid: 'uuid',
      wordAlias: 'wordAlias',
      wordName: 'wordName',
      wordParaphrase: 'wordParaphrase',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appLink: { 'type': 'array', 'itemType': PediaWordsUpdateRequestAppLink },
      contactList: { 'type': 'array', 'itemType': PediaWordsUpdateRequestContactList },
      highLightWordAlias: { 'type': 'array', 'itemType': 'string' },
      picList: { 'type': 'array', 'itemType': PediaWordsUpdateRequestPicList },
      relatedDoc: { 'type': 'array', 'itemType': PediaWordsUpdateRequestRelatedDoc },
      relatedLink: { 'type': 'array', 'itemType': PediaWordsUpdateRequestRelatedLink },
      userId: 'string',
      uuid: 'number',
      wordAlias: { 'type': 'array', 'itemType': 'string' },
      wordName: 'string',
      wordParaphrase: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsUpdateResponseBody extends $tea.Model {
  success?: boolean;
  /**
   * @example
   * 3213213213
   */
  uuid?: number;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      uuid: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsUpdateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PediaWordsUpdateResponseBody;
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
      body: PediaWordsUpdateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsAddRequestContactList extends $tea.Model {
  /**
   * @example
   * @123243
   */
  avatarMediaId?: string;
  /**
   * @example
   * 名称
   */
  nickName?: string;
  /**
   * @example
   * 1231243213
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarMediaId: 'avatarMediaId',
      nickName: 'nickName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarMediaId: 'string',
      nickName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsAddRequestPicList extends $tea.Model {
  /**
   * @example
   * https://23987874.com
   */
  mediaIdUrl?: string;
  static names(): { [key: string]: string } {
    return {
      mediaIdUrl: 'mediaIdUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaIdUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsAddRequestRelatedDoc extends $tea.Model {
  /**
   * @example
   * https://123456.com
   */
  link?: string;
  /**
   * @example
   * 相关文档
   */
  name?: string;
  /**
   * @example
   * adoc
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      link: 'link',
      name: 'name',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      link: 'string',
      name: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsAddRequestRelatedLink extends $tea.Model {
  /**
   * @example
   * http://1233435.com
   */
  link?: string;
  /**
   * @example
   * 相关链接
   */
  name?: string;
  static names(): { [key: string]: string } {
    return {
      link: 'link',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      link: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsQueryResponseBodyDataAppLink extends $tea.Model {
  /**
   * @example
   * 相关应用
   */
  appName?: string;
  /**
   * @example
   * htttps://1234567
   */
  iconLink?: string;
  /**
   * @example
   * http://123344.com
   */
  pcLink?: string;
  /**
   * @example
   * https://12334.com
   */
  phoneLink?: string;
  static names(): { [key: string]: string } {
    return {
      appName: 'appName',
      iconLink: 'iconLink',
      pcLink: 'pcLink',
      phoneLink: 'phoneLink',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appName: 'string',
      iconLink: 'string',
      pcLink: 'string',
      phoneLink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsQueryResponseBodyDataContactList extends $tea.Model {
  /**
   * @example
   * @dasdasd
   */
  avatarMediaId?: string;
  /**
   * @example
   * 相关联系人
   */
  nickName?: string;
  /**
   * @example
   * 12321231
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarMediaId: 'avatarMediaId',
      nickName: 'nickName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarMediaId: 'string',
      nickName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsQueryResponseBodyDataPicList extends $tea.Model {
  /**
   * @example
   * http://123455.com
   */
  mediaIdUrl?: string;
  static names(): { [key: string]: string } {
    return {
      mediaIdUrl: 'mediaIdUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaIdUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsQueryResponseBodyDataRelatedDoc extends $tea.Model {
  /**
   * @example
   * http://123456.com
   */
  link?: string;
  /**
   * @example
   * 相关文档
   */
  name?: string;
  /**
   * @example
   * adoc
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      link: 'link',
      name: 'name',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      link: 'string',
      name: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsQueryResponseBodyDataRelatedLink extends $tea.Model {
  /**
   * @example
   * http://123343.com
   */
  link?: string;
  /**
   * @example
   * 相关链接
   */
  name?: string;
  static names(): { [key: string]: string } {
    return {
      link: 'link',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      link: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsQueryResponseBodyData extends $tea.Model {
  appLink?: PediaWordsQueryResponseBodyDataAppLink[];
  /**
   * @example
   * 审核者
   */
  approveName?: string;
  contactList?: PediaWordsQueryResponseBodyDataContactList[];
  contacts?: string[];
  /**
   * @example
   * 创建者
   */
  creatorName?: string;
  /**
   * @example
   * 31312312
   */
  gmtCreate?: number;
  /**
   * @example
   * 321312312
   */
  gmtModify?: number;
  highLightWordAlias?: string[];
  imHighLight?: boolean;
  /**
   * @example
   * 12345678
   */
  parentUuid?: number;
  picList?: PediaWordsQueryResponseBodyDataPicList[];
  relatedDoc?: PediaWordsQueryResponseBodyDataRelatedDoc[];
  relatedLink?: PediaWordsQueryResponseBodyDataRelatedLink[];
  simHighLight?: boolean;
  /**
   * @example
   * 剔除富文本释义
   */
  simpleWordParaphrase?: string;
  tagsList?: string[];
  /**
   * @example
   * 更新者
   */
  updaterName?: string;
  /**
   * @example
   * 213123123
   */
  userId?: string;
  /**
   * @example
   * 123123121
   */
  uuid?: number;
  wordAlias?: string[];
  /**
   * @example
   * 词条名称
   */
  wordName?: string;
  /**
   * @example
   * 释义
   */
  wordParaphrase?: string;
  static names(): { [key: string]: string } {
    return {
      appLink: 'appLink',
      approveName: 'approveName',
      contactList: 'contactList',
      contacts: 'contacts',
      creatorName: 'creatorName',
      gmtCreate: 'gmtCreate',
      gmtModify: 'gmtModify',
      highLightWordAlias: 'highLightWordAlias',
      imHighLight: 'imHighLight',
      parentUuid: 'parentUuid',
      picList: 'picList',
      relatedDoc: 'relatedDoc',
      relatedLink: 'relatedLink',
      simHighLight: 'simHighLight',
      simpleWordParaphrase: 'simpleWordParaphrase',
      tagsList: 'tagsList',
      updaterName: 'updaterName',
      userId: 'userId',
      uuid: 'uuid',
      wordAlias: 'wordAlias',
      wordName: 'wordName',
      wordParaphrase: 'wordParaphrase',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appLink: { 'type': 'array', 'itemType': PediaWordsQueryResponseBodyDataAppLink },
      approveName: 'string',
      contactList: { 'type': 'array', 'itemType': PediaWordsQueryResponseBodyDataContactList },
      contacts: { 'type': 'array', 'itemType': 'string' },
      creatorName: 'string',
      gmtCreate: 'number',
      gmtModify: 'number',
      highLightWordAlias: { 'type': 'array', 'itemType': 'string' },
      imHighLight: 'boolean',
      parentUuid: 'number',
      picList: { 'type': 'array', 'itemType': PediaWordsQueryResponseBodyDataPicList },
      relatedDoc: { 'type': 'array', 'itemType': PediaWordsQueryResponseBodyDataRelatedDoc },
      relatedLink: { 'type': 'array', 'itemType': PediaWordsQueryResponseBodyDataRelatedLink },
      simHighLight: 'boolean',
      simpleWordParaphrase: 'string',
      tagsList: { 'type': 'array', 'itemType': 'string' },
      updaterName: 'string',
      userId: 'string',
      uuid: 'number',
      wordAlias: { 'type': 'array', 'itemType': 'string' },
      wordName: 'string',
      wordParaphrase: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsSearchResponseBodyDataAppLink extends $tea.Model {
  /**
   * @example
   * 应用名
   */
  appName?: string;
  /**
   * @example
   * https://123434.com
   */
  iconLink?: string;
  /**
   * @example
   * http://123.com
   */
  pcLink?: string;
  /**
   * @example
   * http://1244.com
   */
  phoneLink?: string;
  static names(): { [key: string]: string } {
    return {
      appName: 'appName',
      iconLink: 'iconLink',
      pcLink: 'pcLink',
      phoneLink: 'phoneLink',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appName: 'string',
      iconLink: 'string',
      pcLink: 'string',
      phoneLink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsSearchResponseBodyDataContactList extends $tea.Model {
  /**
   * @example
   * @12321312ds
   */
  avatarMediaId?: string;
  /**
   * @example
   * 员工名称
   */
  nickName?: string;
  /**
   * @example
   * 1232343
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarMediaId: 'avatarMediaId',
      nickName: 'nickName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarMediaId: 'string',
      nickName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsSearchResponseBodyDataPicList extends $tea.Model {
  /**
   * @example
   * https://1234.com
   */
  mediaIdUrl?: string;
  static names(): { [key: string]: string } {
    return {
      mediaIdUrl: 'mediaIdUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaIdUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsSearchResponseBodyDataRelatedDoc extends $tea.Model {
  /**
   * @example
   * https://12324.com
   */
  link?: string;
  /**
   * @example
   * 文档名
   */
  name?: string;
  /**
   * @example
   * adoc
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      link: 'link',
      name: 'name',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      link: 'string',
      name: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsSearchResponseBodyDataRelatedLink extends $tea.Model {
  /**
   * @example
   * https://123112.com
   */
  link?: string;
  /**
   * @example
   * 文档名字
   */
  name?: string;
  /**
   * @example
   * 空值
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      link: 'link',
      name: 'name',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      link: 'string',
      name: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsSearchResponseBodyData extends $tea.Model {
  appLink?: PediaWordsSearchResponseBodyDataAppLink[];
  /**
   * @example
   * 审核人钉钉名称
   */
  approveName?: string;
  contactList?: PediaWordsSearchResponseBodyDataContactList[];
  contacts?: string[];
  /**
   * @example
   * 创建者
   */
  creatorName?: string;
  gmtCreate?: number;
  gmtModify?: number;
  highLightWordAlias?: string[];
  imHighLight?: boolean;
  parentUuid?: number;
  picList?: PediaWordsSearchResponseBodyDataPicList[];
  relatedDoc?: PediaWordsSearchResponseBodyDataRelatedDoc[];
  relatedLink?: PediaWordsSearchResponseBodyDataRelatedLink[];
  simHighLight?: boolean;
  /**
   * @example
   * 剔除了富文本格式后的释义信息
   */
  simpleWordParaphrase?: string;
  tagsList?: string[];
  /**
   * @example
   * 修改人钉钉名称
   */
  updaterName?: string;
  /**
   * @example
   * 312312312
   */
  userId?: string;
  uuid?: number;
  wordAlias?: string[];
  /**
   * @example
   * 测试词条
   */
  wordName?: string;
  /**
   * @example
   * 释义信息
   */
  wordParaphrase?: string;
  static names(): { [key: string]: string } {
    return {
      appLink: 'appLink',
      approveName: 'approveName',
      contactList: 'contactList',
      contacts: 'contacts',
      creatorName: 'creatorName',
      gmtCreate: 'gmtCreate',
      gmtModify: 'gmtModify',
      highLightWordAlias: 'highLightWordAlias',
      imHighLight: 'imHighLight',
      parentUuid: 'parentUuid',
      picList: 'picList',
      relatedDoc: 'relatedDoc',
      relatedLink: 'relatedLink',
      simHighLight: 'simHighLight',
      simpleWordParaphrase: 'simpleWordParaphrase',
      tagsList: 'tagsList',
      updaterName: 'updaterName',
      userId: 'userId',
      uuid: 'uuid',
      wordAlias: 'wordAlias',
      wordName: 'wordName',
      wordParaphrase: 'wordParaphrase',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appLink: { 'type': 'array', 'itemType': PediaWordsSearchResponseBodyDataAppLink },
      approveName: 'string',
      contactList: { 'type': 'array', 'itemType': PediaWordsSearchResponseBodyDataContactList },
      contacts: { 'type': 'array', 'itemType': 'string' },
      creatorName: 'string',
      gmtCreate: 'number',
      gmtModify: 'number',
      highLightWordAlias: { 'type': 'array', 'itemType': 'string' },
      imHighLight: 'boolean',
      parentUuid: 'number',
      picList: { 'type': 'array', 'itemType': PediaWordsSearchResponseBodyDataPicList },
      relatedDoc: { 'type': 'array', 'itemType': PediaWordsSearchResponseBodyDataRelatedDoc },
      relatedLink: { 'type': 'array', 'itemType': PediaWordsSearchResponseBodyDataRelatedLink },
      simHighLight: 'boolean',
      simpleWordParaphrase: 'string',
      tagsList: { 'type': 'array', 'itemType': 'string' },
      updaterName: 'string',
      userId: 'string',
      uuid: 'number',
      wordAlias: { 'type': 'array', 'itemType': 'string' },
      wordName: 'string',
      wordParaphrase: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsUpdateRequestAppLink extends $tea.Model {
  /**
   * @example
   * 应用名称
   */
  appName?: string;
  /**
   * @example
   * https://123243435.com
   */
  iconLink?: string;
  /**
   * @example
   * http://213435.com
   */
  pcLink?: string;
  /**
   * @example
   * htttps://12345.com
   */
  phoneLink?: string;
  static names(): { [key: string]: string } {
    return {
      appName: 'appName',
      iconLink: 'iconLink',
      pcLink: 'pcLink',
      phoneLink: 'phoneLink',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appName: 'string',
      iconLink: 'string',
      pcLink: 'string',
      phoneLink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsUpdateRequestContactList extends $tea.Model {
  /**
   * @example
   * @12312312
   */
  avatarMediaId?: string;
  /**
   * @example
   * 名称
   */
  nickName?: string;
  /**
   * @example
   * 12131312
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarMediaId: 'avatarMediaId',
      nickName: 'nickName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarMediaId: 'string',
      nickName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsUpdateRequestPicList extends $tea.Model {
  /**
   * @example
   * https://1234554.com
   */
  mediaIdUrl?: string;
  static names(): { [key: string]: string } {
    return {
      mediaIdUrl: 'mediaIdUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaIdUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsUpdateRequestRelatedDoc extends $tea.Model {
  /**
   * @example
   * https://213567.com
   */
  link?: string;
  /**
   * @example
   * 相关文档
   */
  name?: string;
  /**
   * @example
   * adoc
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      link: 'link',
      name: 'name',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      link: 'string',
      name: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PediaWordsUpdateRequestRelatedLink extends $tea.Model {
  /**
   * @example
   * https://123466.com
   */
  link?: string;
  /**
   * @example
   * 相关链接
   */
  name?: string;
  static names(): { [key: string]: string } {
    return {
      link: 'link',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      link: 'string',
      name: 'string',
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
   * 企业百科增加当前企业词条信息
   * 
   * @param request - PediaWordsAddRequest
   * @param headers - PediaWordsAddHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PediaWordsAddResponse
   */
  async pediaWordsAddWithOptions(request: PediaWordsAddRequest, headers: PediaWordsAddHeaders, runtime: $Util.RuntimeOptions): Promise<PediaWordsAddResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.contactList)) {
      body["contactList"] = request.contactList;
    }

    if (!Util.isUnset(request.highLightWordAlias)) {
      body["highLightWordAlias"] = request.highLightWordAlias;
    }

    if (!Util.isUnset(request.picList)) {
      body["picList"] = request.picList;
    }

    if (!Util.isUnset(request.relatedDoc)) {
      body["relatedDoc"] = request.relatedDoc;
    }

    if (!Util.isUnset(request.relatedLink)) {
      body["relatedLink"] = request.relatedLink;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.wordAlias)) {
      body["wordAlias"] = request.wordAlias;
    }

    if (!Util.isUnset(request.wordName)) {
      body["wordName"] = request.wordName;
    }

    if (!Util.isUnset(request.wordParaphrase)) {
      body["wordParaphrase"] = request.wordParaphrase;
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
      action: "PediaWordsAdd",
      version: "pedia_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/pedia/words`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PediaWordsAddResponse>(await this.execute(params, req, runtime), new PediaWordsAddResponse({}));
  }

  /**
   * 企业百科增加当前企业词条信息
   * 
   * @param request - PediaWordsAddRequest
   * @returns PediaWordsAddResponse
   */
  async pediaWordsAdd(request: PediaWordsAddRequest): Promise<PediaWordsAddResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PediaWordsAddHeaders({ });
    return await this.pediaWordsAddWithOptions(request, headers, runtime);
  }

  /**
   * 企业百科针对待审核词条进行审核
   * 
   * @param request - PediaWordsApproveRequest
   * @param headers - PediaWordsApproveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PediaWordsApproveResponse
   */
  async pediaWordsApproveWithOptions(request: PediaWordsApproveRequest, headers: PediaWordsApproveHeaders, runtime: $Util.RuntimeOptions): Promise<PediaWordsApproveResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.approveReason)) {
      body["approveReason"] = request.approveReason;
    }

    if (!Util.isUnset(request.approveStatus)) {
      body["approveStatus"] = request.approveStatus;
    }

    if (!Util.isUnset(request.imHighLight)) {
      body["imHighLight"] = request.imHighLight;
    }

    if (!Util.isUnset(request.simHighLight)) {
      body["simHighLight"] = request.simHighLight;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
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
      action: "PediaWordsApprove",
      version: "pedia_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/pedia/words/approve`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PediaWordsApproveResponse>(await this.execute(params, req, runtime), new PediaWordsApproveResponse({}));
  }

  /**
   * 企业百科针对待审核词条进行审核
   * 
   * @param request - PediaWordsApproveRequest
   * @returns PediaWordsApproveResponse
   */
  async pediaWordsApprove(request: PediaWordsApproveRequest): Promise<PediaWordsApproveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PediaWordsApproveHeaders({ });
    return await this.pediaWordsApproveWithOptions(request, headers, runtime);
  }

  /**
   * 企业百科针对uuid删除当前词条
   * 
   * @param request - PediaWordsDeleteRequest
   * @param headers - PediaWordsDeleteHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PediaWordsDeleteResponse
   */
  async pediaWordsDeleteWithOptions(request: PediaWordsDeleteRequest, headers: PediaWordsDeleteHeaders, runtime: $Util.RuntimeOptions): Promise<PediaWordsDeleteResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.uuid)) {
      query["uuid"] = request.uuid;
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
      action: "PediaWordsDelete",
      version: "pedia_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/pedia/words`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PediaWordsDeleteResponse>(await this.execute(params, req, runtime), new PediaWordsDeleteResponse({}));
  }

  /**
   * 企业百科针对uuid删除当前词条
   * 
   * @param request - PediaWordsDeleteRequest
   * @returns PediaWordsDeleteResponse
   */
  async pediaWordsDelete(request: PediaWordsDeleteRequest): Promise<PediaWordsDeleteResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PediaWordsDeleteHeaders({ });
    return await this.pediaWordsDeleteWithOptions(request, headers, runtime);
  }

  /**
   * 根据词条主键ID查询当前词条详情
   * 
   * @param request - PediaWordsQueryRequest
   * @param headers - PediaWordsQueryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PediaWordsQueryResponse
   */
  async pediaWordsQueryWithOptions(request: PediaWordsQueryRequest, headers: PediaWordsQueryHeaders, runtime: $Util.RuntimeOptions): Promise<PediaWordsQueryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.uuid)) {
      query["uuid"] = request.uuid;
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
      action: "PediaWordsQuery",
      version: "pedia_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/pedia/words/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PediaWordsQueryResponse>(await this.execute(params, req, runtime), new PediaWordsQueryResponse({}));
  }

  /**
   * 根据词条主键ID查询当前词条详情
   * 
   * @param request - PediaWordsQueryRequest
   * @returns PediaWordsQueryResponse
   */
  async pediaWordsQuery(request: PediaWordsQueryRequest): Promise<PediaWordsQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PediaWordsQueryHeaders({ });
    return await this.pediaWordsQueryWithOptions(request, headers, runtime);
  }

  /**
   * 分页获取企业词条信息
   * 
   * @param request - PediaWordsSearchRequest
   * @param headers - PediaWordsSearchHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PediaWordsSearchResponse
   */
  async pediaWordsSearchWithOptions(request: PediaWordsSearchRequest, headers: PediaWordsSearchHeaders, runtime: $Util.RuntimeOptions): Promise<PediaWordsSearchResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.wordName)) {
      body["wordName"] = request.wordName;
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
      action: "PediaWordsSearch",
      version: "pedia_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/pedia/words/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PediaWordsSearchResponse>(await this.execute(params, req, runtime), new PediaWordsSearchResponse({}));
  }

  /**
   * 分页获取企业词条信息
   * 
   * @param request - PediaWordsSearchRequest
   * @returns PediaWordsSearchResponse
   */
  async pediaWordsSearch(request: PediaWordsSearchRequest): Promise<PediaWordsSearchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PediaWordsSearchHeaders({ });
    return await this.pediaWordsSearchWithOptions(request, headers, runtime);
  }

  /**
   * 企业百科对当前已经生效词条进行编辑
   * 
   * @param request - PediaWordsUpdateRequest
   * @param headers - PediaWordsUpdateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PediaWordsUpdateResponse
   */
  async pediaWordsUpdateWithOptions(request: PediaWordsUpdateRequest, headers: PediaWordsUpdateHeaders, runtime: $Util.RuntimeOptions): Promise<PediaWordsUpdateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appLink)) {
      body["appLink"] = request.appLink;
    }

    if (!Util.isUnset(request.contactList)) {
      body["contactList"] = request.contactList;
    }

    if (!Util.isUnset(request.highLightWordAlias)) {
      body["highLightWordAlias"] = request.highLightWordAlias;
    }

    if (!Util.isUnset(request.picList)) {
      body["picList"] = request.picList;
    }

    if (!Util.isUnset(request.relatedDoc)) {
      body["relatedDoc"] = request.relatedDoc;
    }

    if (!Util.isUnset(request.relatedLink)) {
      body["relatedLink"] = request.relatedLink;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
    }

    if (!Util.isUnset(request.wordAlias)) {
      body["wordAlias"] = request.wordAlias;
    }

    if (!Util.isUnset(request.wordName)) {
      body["wordName"] = request.wordName;
    }

    if (!Util.isUnset(request.wordParaphrase)) {
      body["wordParaphrase"] = request.wordParaphrase;
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
      action: "PediaWordsUpdate",
      version: "pedia_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/pedia/words`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PediaWordsUpdateResponse>(await this.execute(params, req, runtime), new PediaWordsUpdateResponse({}));
  }

  /**
   * 企业百科对当前已经生效词条进行编辑
   * 
   * @param request - PediaWordsUpdateRequest
   * @returns PediaWordsUpdateResponse
   */
  async pediaWordsUpdate(request: PediaWordsUpdateRequest): Promise<PediaWordsUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PediaWordsUpdateHeaders({ });
    return await this.pediaWordsUpdateWithOptions(request, headers, runtime);
  }

}
