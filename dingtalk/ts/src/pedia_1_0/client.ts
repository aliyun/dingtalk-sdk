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
  userId?: string;
  wordAlias?: string[];
  wordName?: string;
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
  headers: { [key: string]: string };
  statusCode: number;
  body: PediaWordsAddResponseBody;
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
  approveReason?: string;
  approveStatus?: string;
  imHighLight?: boolean;
  simHighLight?: boolean;
  userId?: string;
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
  headers: { [key: string]: string };
  statusCode: number;
  body: PediaWordsApproveResponseBody;
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
  userId?: string;
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
  headers: { [key: string]: string };
  statusCode: number;
  body: PediaWordsDeleteResponseBody;
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
  userId?: string;
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
  headers: { [key: string]: string };
  statusCode: number;
  body: PediaWordsQueryResponseBody;
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
  pageNumber?: number;
  pageSize?: number;
  status?: string;
  userId?: string;
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
  headers: { [key: string]: string };
  statusCode: number;
  body: PediaWordsSearchResponseBody;
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
  userId?: string;
  uuid?: number;
  wordAlias?: string[];
  wordName?: string;
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
  headers: { [key: string]: string };
  statusCode: number;
  body: PediaWordsUpdateResponseBody;
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
  avatarMediaId?: string;
  nickName?: string;
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
  link?: string;
  name?: string;
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
  link?: string;
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
  appName?: string;
  iconLink?: string;
  pcLink?: string;
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
  avatarMediaId?: string;
  nickName?: string;
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
  link?: string;
  name?: string;
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
  link?: string;
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
  approveName?: string;
  contactList?: PediaWordsQueryResponseBodyDataContactList[];
  contacts?: string[];
  creatorName?: string;
  gmtCreate?: number;
  gmtModify?: number;
  highLightWordAlias?: string[];
  imHighLight?: boolean;
  parentUuid?: number;
  picList?: PediaWordsQueryResponseBodyDataPicList[];
  relatedDoc?: PediaWordsQueryResponseBodyDataRelatedDoc[];
  relatedLink?: PediaWordsQueryResponseBodyDataRelatedLink[];
  simHighLight?: boolean;
  simpleWordParaphrase?: string;
  tagsList?: string[];
  updaterName?: string;
  userId?: string;
  uuid?: number;
  wordAlias?: string[];
  wordName?: string;
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
  appName?: string;
  iconLink?: string;
  pcLink?: string;
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
  avatarMediaId?: string;
  nickName?: string;
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
  link?: string;
  name?: string;
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
  link?: string;
  name?: string;
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
  approveName?: string;
  contactList?: PediaWordsSearchResponseBodyDataContactList[];
  contacts?: string[];
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
  simpleWordParaphrase?: string;
  tagsList?: string[];
  updaterName?: string;
  userId?: string;
  uuid?: number;
  wordAlias?: string[];
  wordName?: string;
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
  appName?: string;
  iconLink?: string;
  pcLink?: string;
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
  avatarMediaId?: string;
  nickName?: string;
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
  link?: string;
  name?: string;
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
  link?: string;
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

  async pediaWordsAdd(request: PediaWordsAddRequest): Promise<PediaWordsAddResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PediaWordsAddHeaders({ });
    return await this.pediaWordsAddWithOptions(request, headers, runtime);
  }

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

  async pediaWordsApprove(request: PediaWordsApproveRequest): Promise<PediaWordsApproveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PediaWordsApproveHeaders({ });
    return await this.pediaWordsApproveWithOptions(request, headers, runtime);
  }

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

  async pediaWordsDelete(request: PediaWordsDeleteRequest): Promise<PediaWordsDeleteResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PediaWordsDeleteHeaders({ });
    return await this.pediaWordsDeleteWithOptions(request, headers, runtime);
  }

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

  async pediaWordsQuery(request: PediaWordsQueryRequest): Promise<PediaWordsQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PediaWordsQueryHeaders({ });
    return await this.pediaWordsQueryWithOptions(request, headers, runtime);
  }

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

  async pediaWordsSearch(request: PediaWordsSearchRequest): Promise<PediaWordsSearchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PediaWordsSearchHeaders({ });
    return await this.pediaWordsSearchWithOptions(request, headers, runtime);
  }

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

  async pediaWordsUpdate(request: PediaWordsUpdateRequest): Promise<PediaWordsUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PediaWordsUpdateHeaders({ });
    return await this.pediaWordsUpdateWithOptions(request, headers, runtime);
  }

}
