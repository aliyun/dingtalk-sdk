// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AppendSpaceHeaders extends $tea.Model {
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

export class AppendSpaceRequest extends $tea.Model {
  coFeedOpenSpaceModel?: AppendSpaceRequestCoFeedOpenSpaceModel;
  imGroupOpenSpaceModel?: AppendSpaceRequestImGroupOpenSpaceModel;
  imSingleOpenSpaceModel?: AppendSpaceRequestImSingleOpenSpaceModel;
  outTrackId?: string;
  topOpenSpaceModel?: AppendSpaceRequestTopOpenSpaceModel;
  workBenchOpenSpaceModel?: AppendSpaceRequestWorkBenchOpenSpaceModel;
  static names(): { [key: string]: string } {
    return {
      coFeedOpenSpaceModel: 'coFeedOpenSpaceModel',
      imGroupOpenSpaceModel: 'imGroupOpenSpaceModel',
      imSingleOpenSpaceModel: 'imSingleOpenSpaceModel',
      outTrackId: 'outTrackId',
      topOpenSpaceModel: 'topOpenSpaceModel',
      workBenchOpenSpaceModel: 'workBenchOpenSpaceModel',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coFeedOpenSpaceModel: AppendSpaceRequestCoFeedOpenSpaceModel,
      imGroupOpenSpaceModel: AppendSpaceRequestImGroupOpenSpaceModel,
      imSingleOpenSpaceModel: AppendSpaceRequestImSingleOpenSpaceModel,
      outTrackId: 'string',
      topOpenSpaceModel: AppendSpaceRequestTopOpenSpaceModel,
      workBenchOpenSpaceModel: AppendSpaceRequestWorkBenchOpenSpaceModel,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendSpaceResponseBody extends $tea.Model {
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendSpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AppendSpaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AppendSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverHeaders extends $tea.Model {
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

export class CreateAndDeliverRequest extends $tea.Model {
  callbackRouteKey?: string;
  cardData?: CreateAndDeliverRequestCardData;
  cardTemplateId?: string;
  coFeedOpenDeliverModel?: CreateAndDeliverRequestCoFeedOpenDeliverModel;
  coFeedOpenSpaceModel?: CreateAndDeliverRequestCoFeedOpenSpaceModel;
  imGroupOpenDeliverModel?: CreateAndDeliverRequestImGroupOpenDeliverModel;
  imGroupOpenSpaceModel?: CreateAndDeliverRequestImGroupOpenSpaceModel;
  imSingleOpenDeliverModel?: CreateAndDeliverRequestImSingleOpenDeliverModel;
  imSingleOpenSpaceModel?: CreateAndDeliverRequestImSingleOpenSpaceModel;
  openDynamicDataConfig?: CreateAndDeliverRequestOpenDynamicDataConfig;
  openSpaceId?: string;
  outTrackId?: string;
  privateData?: { [key: string]: PrivateDataValue };
  topOpenDeliverModel?: CreateAndDeliverRequestTopOpenDeliverModel;
  topOpenSpaceModel?: CreateAndDeliverRequestTopOpenSpaceModel;
  userId?: string;
  workBenchOpenDeliverModel?: CreateAndDeliverRequestWorkBenchOpenDeliverModel;
  workBenchOpenSpaceModel?: CreateAndDeliverRequestWorkBenchOpenSpaceModel;
  static names(): { [key: string]: string } {
    return {
      callbackRouteKey: 'callbackRouteKey',
      cardData: 'cardData',
      cardTemplateId: 'cardTemplateId',
      coFeedOpenDeliverModel: 'coFeedOpenDeliverModel',
      coFeedOpenSpaceModel: 'coFeedOpenSpaceModel',
      imGroupOpenDeliverModel: 'imGroupOpenDeliverModel',
      imGroupOpenSpaceModel: 'imGroupOpenSpaceModel',
      imSingleOpenDeliverModel: 'imSingleOpenDeliverModel',
      imSingleOpenSpaceModel: 'imSingleOpenSpaceModel',
      openDynamicDataConfig: 'openDynamicDataConfig',
      openSpaceId: 'openSpaceId',
      outTrackId: 'outTrackId',
      privateData: 'privateData',
      topOpenDeliverModel: 'topOpenDeliverModel',
      topOpenSpaceModel: 'topOpenSpaceModel',
      userId: 'userId',
      workBenchOpenDeliverModel: 'workBenchOpenDeliverModel',
      workBenchOpenSpaceModel: 'workBenchOpenSpaceModel',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callbackRouteKey: 'string',
      cardData: CreateAndDeliverRequestCardData,
      cardTemplateId: 'string',
      coFeedOpenDeliverModel: CreateAndDeliverRequestCoFeedOpenDeliverModel,
      coFeedOpenSpaceModel: CreateAndDeliverRequestCoFeedOpenSpaceModel,
      imGroupOpenDeliverModel: CreateAndDeliverRequestImGroupOpenDeliverModel,
      imGroupOpenSpaceModel: CreateAndDeliverRequestImGroupOpenSpaceModel,
      imSingleOpenDeliverModel: CreateAndDeliverRequestImSingleOpenDeliverModel,
      imSingleOpenSpaceModel: CreateAndDeliverRequestImSingleOpenSpaceModel,
      openDynamicDataConfig: CreateAndDeliverRequestOpenDynamicDataConfig,
      openSpaceId: 'string',
      outTrackId: 'string',
      privateData: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateDataValue },
      topOpenDeliverModel: CreateAndDeliverRequestTopOpenDeliverModel,
      topOpenSpaceModel: CreateAndDeliverRequestTopOpenSpaceModel,
      userId: 'string',
      workBenchOpenDeliverModel: CreateAndDeliverRequestWorkBenchOpenDeliverModel,
      workBenchOpenSpaceModel: CreateAndDeliverRequestWorkBenchOpenSpaceModel,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverResponseBody extends $tea.Model {
  result?: CreateAndDeliverResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateAndDeliverResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateAndDeliverResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateAndDeliverResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardHeaders extends $tea.Model {
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

export class CreateCardRequest extends $tea.Model {
  callbackRouteKey?: string;
  cardData?: CreateCardRequestCardData;
  cardTemplateId?: string;
  coFeedOpenSpaceModel?: CreateCardRequestCoFeedOpenSpaceModel;
  imGroupOpenSpaceModel?: CreateCardRequestImGroupOpenSpaceModel;
  imSingleOpenSpaceModel?: CreateCardRequestImSingleOpenSpaceModel;
  openDynamicDataConfig?: CreateCardRequestOpenDynamicDataConfig;
  outTrackId?: string;
  privateData?: { [key: string]: PrivateDataValue };
  topOpenSpaceModel?: CreateCardRequestTopOpenSpaceModel;
  userId?: string;
  workBenchOpenSpaceModel?: CreateCardRequestWorkBenchOpenSpaceModel;
  static names(): { [key: string]: string } {
    return {
      callbackRouteKey: 'callbackRouteKey',
      cardData: 'cardData',
      cardTemplateId: 'cardTemplateId',
      coFeedOpenSpaceModel: 'coFeedOpenSpaceModel',
      imGroupOpenSpaceModel: 'imGroupOpenSpaceModel',
      imSingleOpenSpaceModel: 'imSingleOpenSpaceModel',
      openDynamicDataConfig: 'openDynamicDataConfig',
      outTrackId: 'outTrackId',
      privateData: 'privateData',
      topOpenSpaceModel: 'topOpenSpaceModel',
      userId: 'userId',
      workBenchOpenSpaceModel: 'workBenchOpenSpaceModel',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callbackRouteKey: 'string',
      cardData: CreateCardRequestCardData,
      cardTemplateId: 'string',
      coFeedOpenSpaceModel: CreateCardRequestCoFeedOpenSpaceModel,
      imGroupOpenSpaceModel: CreateCardRequestImGroupOpenSpaceModel,
      imSingleOpenSpaceModel: CreateCardRequestImSingleOpenSpaceModel,
      openDynamicDataConfig: CreateCardRequestOpenDynamicDataConfig,
      outTrackId: 'string',
      privateData: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateDataValue },
      topOpenSpaceModel: CreateCardRequestTopOpenSpaceModel,
      userId: 'string',
      workBenchOpenSpaceModel: CreateCardRequestWorkBenchOpenSpaceModel,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateCardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeliverCardHeaders extends $tea.Model {
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

export class DeliverCardRequest extends $tea.Model {
  coFeedOpenDeliverModel?: DeliverCardRequestCoFeedOpenDeliverModel;
  imGroupOpenDeliverModel?: DeliverCardRequestImGroupOpenDeliverModel;
  imSingleOpenDeliverModel?: DeliverCardRequestImSingleOpenDeliverModel;
  openSpaceId?: string;
  outTrackId?: string;
  topOpenDeliverModel?: DeliverCardRequestTopOpenDeliverModel;
  workBenchOpenDeliverModel?: DeliverCardRequestWorkBenchOpenDeliverModel;
  static names(): { [key: string]: string } {
    return {
      coFeedOpenDeliverModel: 'coFeedOpenDeliverModel',
      imGroupOpenDeliverModel: 'imGroupOpenDeliverModel',
      imSingleOpenDeliverModel: 'imSingleOpenDeliverModel',
      openSpaceId: 'openSpaceId',
      outTrackId: 'outTrackId',
      topOpenDeliverModel: 'topOpenDeliverModel',
      workBenchOpenDeliverModel: 'workBenchOpenDeliverModel',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coFeedOpenDeliverModel: DeliverCardRequestCoFeedOpenDeliverModel,
      imGroupOpenDeliverModel: DeliverCardRequestImGroupOpenDeliverModel,
      imSingleOpenDeliverModel: DeliverCardRequestImSingleOpenDeliverModel,
      openSpaceId: 'string',
      outTrackId: 'string',
      topOpenDeliverModel: DeliverCardRequestTopOpenDeliverModel,
      workBenchOpenDeliverModel: DeliverCardRequestWorkBenchOpenDeliverModel,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeliverCardResponseBody extends $tea.Model {
  result?: DeliverCardResponseBodyResult[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': DeliverCardResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeliverCardResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeliverCardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeliverCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterCallbackHeaders extends $tea.Model {
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

export class RegisterCallbackRequest extends $tea.Model {
  apiSecret?: string;
  callbackRouteKey?: string;
  callbackUrl?: string;
  forceUpdate?: boolean;
  static names(): { [key: string]: string } {
    return {
      apiSecret: 'apiSecret',
      callbackRouteKey: 'callbackRouteKey',
      callbackUrl: 'callbackUrl',
      forceUpdate: 'forceUpdate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiSecret: 'string',
      callbackRouteKey: 'string',
      callbackUrl: 'string',
      forceUpdate: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterCallbackResponseBody extends $tea.Model {
  result?: RegisterCallbackResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: RegisterCallbackResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterCallbackResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RegisterCallbackResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RegisterCallbackResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCardHeaders extends $tea.Model {
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

export class UpdateCardRequest extends $tea.Model {
  cardData?: UpdateCardRequestCardData;
  cardUpdateOptions?: UpdateCardRequestCardUpdateOptions;
  outTrackId?: string;
  privateData?: { [key: string]: PrivateDataValue };
  static names(): { [key: string]: string } {
    return {
      cardData: 'cardData',
      cardUpdateOptions: 'cardUpdateOptions',
      outTrackId: 'outTrackId',
      privateData: 'privateData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardData: UpdateCardRequestCardData,
      cardUpdateOptions: UpdateCardRequestCardUpdateOptions,
      outTrackId: 'string',
      privateData: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateDataValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCardResponseBody extends $tea.Model {
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCardResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateCardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenDynamicDataConfigDynamicDataMappingValue extends $tea.Model {
  path?: string;
  dynamicDataValueType?: string;
  static names(): { [key: string]: string } {
    return {
      path: 'path',
      dynamicDataValueType: 'dynamicDataValueType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      path: 'string',
      dynamicDataValueType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PrivateDataValue extends $tea.Model {
  cardParamMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      cardParamMap: 'cardParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendSpaceRequestCoFeedOpenSpaceModel extends $tea.Model {
  title?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendSpaceRequestImGroupOpenSpaceModelNotification extends $tea.Model {
  alertContent?: string;
  notificationOff?: boolean;
  static names(): { [key: string]: string } {
    return {
      alertContent: 'alertContent',
      notificationOff: 'notificationOff',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alertContent: 'string',
      notificationOff: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendSpaceRequestImGroupOpenSpaceModelSearchSupport extends $tea.Model {
  searchDesc?: string;
  searchIcon?: string;
  searchTypeName?: string;
  static names(): { [key: string]: string } {
    return {
      searchDesc: 'searchDesc',
      searchIcon: 'searchIcon',
      searchTypeName: 'searchTypeName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      searchDesc: 'string',
      searchIcon: 'string',
      searchTypeName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendSpaceRequestImGroupOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: AppendSpaceRequestImGroupOpenSpaceModelNotification;
  searchSupport?: AppendSpaceRequestImGroupOpenSpaceModelSearchSupport;
  supportForward?: boolean;
  static names(): { [key: string]: string } {
    return {
      lastMessageI18n: 'lastMessageI18n',
      notification: 'notification',
      searchSupport: 'searchSupport',
      supportForward: 'supportForward',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lastMessageI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      notification: AppendSpaceRequestImGroupOpenSpaceModelNotification,
      searchSupport: AppendSpaceRequestImGroupOpenSpaceModelSearchSupport,
      supportForward: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendSpaceRequestImSingleOpenSpaceModelNotification extends $tea.Model {
  alertContent?: string;
  notificationOff?: boolean;
  static names(): { [key: string]: string } {
    return {
      alertContent: 'alertContent',
      notificationOff: 'notificationOff',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alertContent: 'string',
      notificationOff: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendSpaceRequestImSingleOpenSpaceModelSearchSupport extends $tea.Model {
  searchDesc?: string;
  searchIcon?: string;
  searchTypeName?: string;
  static names(): { [key: string]: string } {
    return {
      searchDesc: 'searchDesc',
      searchIcon: 'searchIcon',
      searchTypeName: 'searchTypeName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      searchDesc: 'string',
      searchIcon: 'string',
      searchTypeName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendSpaceRequestImSingleOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: AppendSpaceRequestImSingleOpenSpaceModelNotification;
  searchSupport?: AppendSpaceRequestImSingleOpenSpaceModelSearchSupport;
  supportForward?: boolean;
  static names(): { [key: string]: string } {
    return {
      lastMessageI18n: 'lastMessageI18n',
      notification: 'notification',
      searchSupport: 'searchSupport',
      supportForward: 'supportForward',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lastMessageI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      notification: AppendSpaceRequestImSingleOpenSpaceModelNotification,
      searchSupport: AppendSpaceRequestImSingleOpenSpaceModelSearchSupport,
      supportForward: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendSpaceRequestTopOpenSpaceModel extends $tea.Model {
  spaceType?: string;
  static names(): { [key: string]: string } {
    return {
      spaceType: 'spaceType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendSpaceRequestWorkBenchOpenSpaceModel extends $tea.Model {
  spaceType?: string;
  static names(): { [key: string]: string } {
    return {
      spaceType: 'spaceType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestCardData extends $tea.Model {
  cardParamMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      cardParamMap: 'cardParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestCoFeedOpenDeliverModel extends $tea.Model {
  bizTag?: string;
  gmtTimeLine?: number;
  static names(): { [key: string]: string } {
    return {
      bizTag: 'bizTag',
      gmtTimeLine: 'gmtTimeLine',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTag: 'string',
      gmtTimeLine: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestCoFeedOpenSpaceModel extends $tea.Model {
  title?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestImGroupOpenDeliverModel extends $tea.Model {
  atUserIds?: { [key: string]: string };
  recipients?: string[];
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      atUserIds: 'atUserIds',
      recipients: 'recipients',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atUserIds: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      recipients: { 'type': 'array', 'itemType': 'string' },
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestImGroupOpenSpaceModelNotification extends $tea.Model {
  alertContent?: string;
  notificationOff?: boolean;
  static names(): { [key: string]: string } {
    return {
      alertContent: 'alertContent',
      notificationOff: 'notificationOff',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alertContent: 'string',
      notificationOff: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport extends $tea.Model {
  searchDesc?: string;
  searchIcon?: string;
  searchTypeName?: string;
  static names(): { [key: string]: string } {
    return {
      searchDesc: 'searchDesc',
      searchIcon: 'searchIcon',
      searchTypeName: 'searchTypeName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      searchDesc: 'string',
      searchIcon: 'string',
      searchTypeName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestImGroupOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: CreateAndDeliverRequestImGroupOpenSpaceModelNotification;
  searchSupport?: CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport;
  supportForward?: boolean;
  static names(): { [key: string]: string } {
    return {
      lastMessageI18n: 'lastMessageI18n',
      notification: 'notification',
      searchSupport: 'searchSupport',
      supportForward: 'supportForward',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lastMessageI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      notification: CreateAndDeliverRequestImGroupOpenSpaceModelNotification,
      searchSupport: CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport,
      supportForward: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestImSingleOpenDeliverModel extends $tea.Model {
  atUserIds?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      atUserIds: 'atUserIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atUserIds: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestImSingleOpenSpaceModelNotification extends $tea.Model {
  alertContent?: string;
  notificationOff?: boolean;
  static names(): { [key: string]: string } {
    return {
      alertContent: 'alertContent',
      notificationOff: 'notificationOff',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alertContent: 'string',
      notificationOff: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport extends $tea.Model {
  searchDesc?: string;
  searchIcon?: string;
  searchTypeName?: string;
  static names(): { [key: string]: string } {
    return {
      searchDesc: 'searchDesc',
      searchIcon: 'searchIcon',
      searchTypeName: 'searchTypeName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      searchDesc: 'string',
      searchIcon: 'string',
      searchTypeName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestImSingleOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: CreateAndDeliverRequestImSingleOpenSpaceModelNotification;
  searchSupport?: CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport;
  supportForward?: boolean;
  static names(): { [key: string]: string } {
    return {
      lastMessageI18n: 'lastMessageI18n',
      notification: 'notification',
      searchSupport: 'searchSupport',
      supportForward: 'supportForward',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lastMessageI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      notification: CreateAndDeliverRequestImSingleOpenSpaceModelNotification,
      searchSupport: CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport,
      supportForward: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig extends $tea.Model {
  interval?: number;
  pullStrategy?: string;
  timeUnit?: string;
  static names(): { [key: string]: string } {
    return {
      interval: 'interval',
      pullStrategy: 'pullStrategy',
      timeUnit: 'timeUnit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      interval: 'number',
      pullStrategy: 'string',
      timeUnit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs extends $tea.Model {
  constParams?: { [key: string]: string };
  dynamicDataSourceId?: string;
  pullConfig?: CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig;
  static names(): { [key: string]: string } {
    return {
      constParams: 'constParams',
      dynamicDataSourceId: 'dynamicDataSourceId',
      pullConfig: 'pullConfig',
    };
  }

  static types(): { [key: string]: any } {
    return {
      constParams: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dynamicDataSourceId: 'string',
      pullConfig: CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestOpenDynamicDataConfig extends $tea.Model {
  dynamicDataMapping?: { [key: string]: OpenDynamicDataConfigDynamicDataMappingValue };
  dynamicDataMappingMethod?: string;
  dynamicDataSourceConfigs?: CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs[];
  static names(): { [key: string]: string } {
    return {
      dynamicDataMapping: 'dynamicDataMapping',
      dynamicDataMappingMethod: 'dynamicDataMappingMethod',
      dynamicDataSourceConfigs: 'dynamicDataSourceConfigs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dynamicDataMapping: { 'type': 'map', 'keyType': 'string', 'valueType': OpenDynamicDataConfigDynamicDataMappingValue },
      dynamicDataMappingMethod: 'string',
      dynamicDataSourceConfigs: { 'type': 'array', 'itemType': CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestTopOpenDeliverModel extends $tea.Model {
  expiredTimeMillis?: number;
  platforms?: string[];
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      expiredTimeMillis: 'expiredTimeMillis',
      platforms: 'platforms',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expiredTimeMillis: 'number',
      platforms: { 'type': 'array', 'itemType': 'string' },
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestTopOpenSpaceModel extends $tea.Model {
  spaceType?: string;
  static names(): { [key: string]: string } {
    return {
      spaceType: 'spaceType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestWorkBenchOpenDeliverModel extends $tea.Model {
  icon?: string;
  name?: string;
  pluginComponentName?: string;
  previewUrl?: string;
  projectName?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      name: 'name',
      pluginComponentName: 'pluginComponentName',
      previewUrl: 'previewUrl',
      projectName: 'projectName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      name: 'string',
      pluginComponentName: 'string',
      previewUrl: 'string',
      projectName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestWorkBenchOpenSpaceModel extends $tea.Model {
  spaceType?: string;
  static names(): { [key: string]: string } {
    return {
      spaceType: 'spaceType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverResponseBodyResultDeliverResults extends $tea.Model {
  errorMsg?: string;
  spaceId?: string;
  spaceType?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      errorMsg: 'errorMsg',
      spaceId: 'spaceId',
      spaceType: 'spaceType',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorMsg: 'string',
      spaceId: 'string',
      spaceType: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverResponseBodyResult extends $tea.Model {
  deliverResults?: CreateAndDeliverResponseBodyResultDeliverResults[];
  outTrackId?: string;
  static names(): { [key: string]: string } {
    return {
      deliverResults: 'deliverResults',
      outTrackId: 'outTrackId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deliverResults: { 'type': 'array', 'itemType': CreateAndDeliverResponseBodyResultDeliverResults },
      outTrackId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardRequestCardData extends $tea.Model {
  cardParamMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      cardParamMap: 'cardParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardRequestCoFeedOpenSpaceModel extends $tea.Model {
  title?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardRequestImGroupOpenSpaceModelNotification extends $tea.Model {
  alertContent?: string;
  notificationOff?: boolean;
  static names(): { [key: string]: string } {
    return {
      alertContent: 'alertContent',
      notificationOff: 'notificationOff',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alertContent: 'string',
      notificationOff: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardRequestImGroupOpenSpaceModelSearchSupport extends $tea.Model {
  searchDesc?: string;
  searchIcon?: string;
  searchTypeName?: string;
  static names(): { [key: string]: string } {
    return {
      searchDesc: 'searchDesc',
      searchIcon: 'searchIcon',
      searchTypeName: 'searchTypeName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      searchDesc: 'string',
      searchIcon: 'string',
      searchTypeName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardRequestImGroupOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: CreateCardRequestImGroupOpenSpaceModelNotification;
  searchSupport?: CreateCardRequestImGroupOpenSpaceModelSearchSupport;
  supportForward?: boolean;
  static names(): { [key: string]: string } {
    return {
      lastMessageI18n: 'lastMessageI18n',
      notification: 'notification',
      searchSupport: 'searchSupport',
      supportForward: 'supportForward',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lastMessageI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      notification: CreateCardRequestImGroupOpenSpaceModelNotification,
      searchSupport: CreateCardRequestImGroupOpenSpaceModelSearchSupport,
      supportForward: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardRequestImSingleOpenSpaceModelNotification extends $tea.Model {
  alertContent?: string;
  notificationOff?: boolean;
  static names(): { [key: string]: string } {
    return {
      alertContent: 'alertContent',
      notificationOff: 'notificationOff',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alertContent: 'string',
      notificationOff: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardRequestImSingleOpenSpaceModelSearchSupport extends $tea.Model {
  searchDesc?: string;
  searchIcon?: string;
  searchTypeName?: string;
  static names(): { [key: string]: string } {
    return {
      searchDesc: 'searchDesc',
      searchIcon: 'searchIcon',
      searchTypeName: 'searchTypeName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      searchDesc: 'string',
      searchIcon: 'string',
      searchTypeName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardRequestImSingleOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: CreateCardRequestImSingleOpenSpaceModelNotification;
  searchSupport?: CreateCardRequestImSingleOpenSpaceModelSearchSupport;
  supportForward?: boolean;
  static names(): { [key: string]: string } {
    return {
      lastMessageI18n: 'lastMessageI18n',
      notification: 'notification',
      searchSupport: 'searchSupport',
      supportForward: 'supportForward',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lastMessageI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      notification: CreateCardRequestImSingleOpenSpaceModelNotification,
      searchSupport: CreateCardRequestImSingleOpenSpaceModelSearchSupport,
      supportForward: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig extends $tea.Model {
  interval?: number;
  pullStrategy?: string;
  timeUnit?: string;
  static names(): { [key: string]: string } {
    return {
      interval: 'interval',
      pullStrategy: 'pullStrategy',
      timeUnit: 'timeUnit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      interval: 'number',
      pullStrategy: 'string',
      timeUnit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs extends $tea.Model {
  constParams?: { [key: string]: string };
  dynamicDataSourceId?: string;
  pullConfig?: CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig;
  static names(): { [key: string]: string } {
    return {
      constParams: 'constParams',
      dynamicDataSourceId: 'dynamicDataSourceId',
      pullConfig: 'pullConfig',
    };
  }

  static types(): { [key: string]: any } {
    return {
      constParams: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dynamicDataSourceId: 'string',
      pullConfig: CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardRequestOpenDynamicDataConfig extends $tea.Model {
  dynamicDataMapping?: { [key: string]: OpenDynamicDataConfigDynamicDataMappingValue };
  dynamicDataMappingMethod?: string;
  dynamicDataSourceConfigs?: CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs[];
  static names(): { [key: string]: string } {
    return {
      dynamicDataMapping: 'dynamicDataMapping',
      dynamicDataMappingMethod: 'dynamicDataMappingMethod',
      dynamicDataSourceConfigs: 'dynamicDataSourceConfigs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dynamicDataMapping: { 'type': 'map', 'keyType': 'string', 'valueType': OpenDynamicDataConfigDynamicDataMappingValue },
      dynamicDataMappingMethod: 'string',
      dynamicDataSourceConfigs: { 'type': 'array', 'itemType': CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardRequestTopOpenSpaceModel extends $tea.Model {
  spaceType?: string;
  static names(): { [key: string]: string } {
    return {
      spaceType: 'spaceType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardRequestWorkBenchOpenSpaceModel extends $tea.Model {
  spaceType?: string;
  static names(): { [key: string]: string } {
    return {
      spaceType: 'spaceType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeliverCardRequestCoFeedOpenDeliverModel extends $tea.Model {
  bizTag?: string;
  gmtTimeLine?: number;
  static names(): { [key: string]: string } {
    return {
      bizTag: 'bizTag',
      gmtTimeLine: 'gmtTimeLine',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTag: 'string',
      gmtTimeLine: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeliverCardRequestImGroupOpenDeliverModel extends $tea.Model {
  atUserIds?: { [key: string]: string };
  recipients?: string[];
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      atUserIds: 'atUserIds',
      recipients: 'recipients',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atUserIds: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      recipients: { 'type': 'array', 'itemType': 'string' },
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeliverCardRequestImSingleOpenDeliverModel extends $tea.Model {
  atUserIds?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      atUserIds: 'atUserIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atUserIds: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeliverCardRequestTopOpenDeliverModel extends $tea.Model {
  expiredTimeMills?: number;
  platforms?: string[];
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      expiredTimeMills: 'expiredTimeMills',
      platforms: 'platforms',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expiredTimeMills: 'number',
      platforms: { 'type': 'array', 'itemType': 'string' },
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeliverCardRequestWorkBenchOpenDeliverModel extends $tea.Model {
  icon?: string;
  name?: string;
  pluginComponentName?: string;
  previewUrl?: string;
  projectName?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      name: 'name',
      pluginComponentName: 'pluginComponentName',
      previewUrl: 'previewUrl',
      projectName: 'projectName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      name: 'string',
      pluginComponentName: 'string',
      previewUrl: 'string',
      projectName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeliverCardResponseBodyResult extends $tea.Model {
  spaceId?: string;
  spaceType?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
      spaceType: 'spaceType',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
      spaceType: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterCallbackResponseBodyResult extends $tea.Model {
  apiSecret?: string;
  callbackUrl?: string;
  static names(): { [key: string]: string } {
    return {
      apiSecret: 'apiSecret',
      callbackUrl: 'callbackUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiSecret: 'string',
      callbackUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCardRequestCardData extends $tea.Model {
  cardParamMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      cardParamMap: 'cardParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCardRequestCardUpdateOptions extends $tea.Model {
  updateCardDataByKey?: boolean;
  updatePrivateDataByKey?: boolean;
  static names(): { [key: string]: string } {
    return {
      updateCardDataByKey: 'updateCardDataByKey',
      updatePrivateDataByKey: 'updatePrivateDataByKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      updateCardDataByKey: 'boolean',
      updatePrivateDataByKey: 'boolean',
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


  async appendSpace(request: AppendSpaceRequest): Promise<AppendSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AppendSpaceHeaders({ });
    return await this.appendSpaceWithOptions(request, headers, runtime);
  }

  async appendSpaceWithOptions(request: AppendSpaceRequest, headers: AppendSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<AppendSpaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.coFeedOpenSpaceModel))) {
      body["coFeedOpenSpaceModel"] = request.coFeedOpenSpaceModel;
    }

    if (!Util.isUnset($tea.toMap(request.imGroupOpenSpaceModel))) {
      body["imGroupOpenSpaceModel"] = request.imGroupOpenSpaceModel;
    }

    if (!Util.isUnset($tea.toMap(request.imSingleOpenSpaceModel))) {
      body["imSingleOpenSpaceModel"] = request.imSingleOpenSpaceModel;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset($tea.toMap(request.topOpenSpaceModel))) {
      body["topOpenSpaceModel"] = request.topOpenSpaceModel;
    }

    if (!Util.isUnset($tea.toMap(request.workBenchOpenSpaceModel))) {
      body["workBenchOpenSpaceModel"] = request.workBenchOpenSpaceModel;
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
    return $tea.cast<AppendSpaceResponse>(await this.doROARequest("AppendSpace", "card_1.0", "HTTP", "PUT", "AK", `/v1.0/card/instances/spaces`, "json", req, runtime), new AppendSpaceResponse({}));
  }

  async createAndDeliver(request: CreateAndDeliverRequest): Promise<CreateAndDeliverResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateAndDeliverHeaders({ });
    return await this.createAndDeliverWithOptions(request, headers, runtime);
  }

  async createAndDeliverWithOptions(request: CreateAndDeliverRequest, headers: CreateAndDeliverHeaders, runtime: $Util.RuntimeOptions): Promise<CreateAndDeliverResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.callbackRouteKey)) {
      body["callbackRouteKey"] = request.callbackRouteKey;
    }

    if (!Util.isUnset($tea.toMap(request.cardData))) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.cardTemplateId)) {
      body["cardTemplateId"] = request.cardTemplateId;
    }

    if (!Util.isUnset($tea.toMap(request.coFeedOpenDeliverModel))) {
      body["coFeedOpenDeliverModel"] = request.coFeedOpenDeliverModel;
    }

    if (!Util.isUnset($tea.toMap(request.coFeedOpenSpaceModel))) {
      body["coFeedOpenSpaceModel"] = request.coFeedOpenSpaceModel;
    }

    if (!Util.isUnset($tea.toMap(request.imGroupOpenDeliverModel))) {
      body["imGroupOpenDeliverModel"] = request.imGroupOpenDeliverModel;
    }

    if (!Util.isUnset($tea.toMap(request.imGroupOpenSpaceModel))) {
      body["imGroupOpenSpaceModel"] = request.imGroupOpenSpaceModel;
    }

    if (!Util.isUnset($tea.toMap(request.imSingleOpenDeliverModel))) {
      body["imSingleOpenDeliverModel"] = request.imSingleOpenDeliverModel;
    }

    if (!Util.isUnset($tea.toMap(request.imSingleOpenSpaceModel))) {
      body["imSingleOpenSpaceModel"] = request.imSingleOpenSpaceModel;
    }

    if (!Util.isUnset($tea.toMap(request.openDynamicDataConfig))) {
      body["openDynamicDataConfig"] = request.openDynamicDataConfig;
    }

    if (!Util.isUnset(request.openSpaceId)) {
      body["openSpaceId"] = request.openSpaceId;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.privateData)) {
      body["privateData"] = request.privateData;
    }

    if (!Util.isUnset($tea.toMap(request.topOpenDeliverModel))) {
      body["topOpenDeliverModel"] = request.topOpenDeliverModel;
    }

    if (!Util.isUnset($tea.toMap(request.topOpenSpaceModel))) {
      body["topOpenSpaceModel"] = request.topOpenSpaceModel;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset($tea.toMap(request.workBenchOpenDeliverModel))) {
      body["workBenchOpenDeliverModel"] = request.workBenchOpenDeliverModel;
    }

    if (!Util.isUnset($tea.toMap(request.workBenchOpenSpaceModel))) {
      body["workBenchOpenSpaceModel"] = request.workBenchOpenSpaceModel;
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
    return $tea.cast<CreateAndDeliverResponse>(await this.doROARequest("CreateAndDeliver", "card_1.0", "HTTP", "POST", "AK", `/v1.0/card/instances/createAndDeliver`, "json", req, runtime), new CreateAndDeliverResponse({}));
  }

  async createCard(request: CreateCardRequest): Promise<CreateCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCardHeaders({ });
    return await this.createCardWithOptions(request, headers, runtime);
  }

  async createCardWithOptions(request: CreateCardRequest, headers: CreateCardHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.callbackRouteKey)) {
      body["callbackRouteKey"] = request.callbackRouteKey;
    }

    if (!Util.isUnset($tea.toMap(request.cardData))) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.cardTemplateId)) {
      body["cardTemplateId"] = request.cardTemplateId;
    }

    if (!Util.isUnset($tea.toMap(request.coFeedOpenSpaceModel))) {
      body["coFeedOpenSpaceModel"] = request.coFeedOpenSpaceModel;
    }

    if (!Util.isUnset($tea.toMap(request.imGroupOpenSpaceModel))) {
      body["imGroupOpenSpaceModel"] = request.imGroupOpenSpaceModel;
    }

    if (!Util.isUnset($tea.toMap(request.imSingleOpenSpaceModel))) {
      body["imSingleOpenSpaceModel"] = request.imSingleOpenSpaceModel;
    }

    if (!Util.isUnset($tea.toMap(request.openDynamicDataConfig))) {
      body["openDynamicDataConfig"] = request.openDynamicDataConfig;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.privateData)) {
      body["privateData"] = request.privateData;
    }

    if (!Util.isUnset($tea.toMap(request.topOpenSpaceModel))) {
      body["topOpenSpaceModel"] = request.topOpenSpaceModel;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset($tea.toMap(request.workBenchOpenSpaceModel))) {
      body["workBenchOpenSpaceModel"] = request.workBenchOpenSpaceModel;
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
    return $tea.cast<CreateCardResponse>(await this.doROARequest("CreateCard", "card_1.0", "HTTP", "POST", "AK", `/v1.0/card/instances`, "json", req, runtime), new CreateCardResponse({}));
  }

  async deliverCard(request: DeliverCardRequest): Promise<DeliverCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeliverCardHeaders({ });
    return await this.deliverCardWithOptions(request, headers, runtime);
  }

  async deliverCardWithOptions(request: DeliverCardRequest, headers: DeliverCardHeaders, runtime: $Util.RuntimeOptions): Promise<DeliverCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.coFeedOpenDeliverModel))) {
      body["coFeedOpenDeliverModel"] = request.coFeedOpenDeliverModel;
    }

    if (!Util.isUnset($tea.toMap(request.imGroupOpenDeliverModel))) {
      body["imGroupOpenDeliverModel"] = request.imGroupOpenDeliverModel;
    }

    if (!Util.isUnset($tea.toMap(request.imSingleOpenDeliverModel))) {
      body["imSingleOpenDeliverModel"] = request.imSingleOpenDeliverModel;
    }

    if (!Util.isUnset(request.openSpaceId)) {
      body["openSpaceId"] = request.openSpaceId;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset($tea.toMap(request.topOpenDeliverModel))) {
      body["topOpenDeliverModel"] = request.topOpenDeliverModel;
    }

    if (!Util.isUnset($tea.toMap(request.workBenchOpenDeliverModel))) {
      body["workBenchOpenDeliverModel"] = request.workBenchOpenDeliverModel;
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
    return $tea.cast<DeliverCardResponse>(await this.doROARequest("DeliverCard", "card_1.0", "HTTP", "POST", "AK", `/v1.0/card/instances/deliver`, "json", req, runtime), new DeliverCardResponse({}));
  }

  async registerCallback(request: RegisterCallbackRequest): Promise<RegisterCallbackResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterCallbackHeaders({ });
    return await this.registerCallbackWithOptions(request, headers, runtime);
  }

  async registerCallbackWithOptions(request: RegisterCallbackRequest, headers: RegisterCallbackHeaders, runtime: $Util.RuntimeOptions): Promise<RegisterCallbackResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.apiSecret)) {
      body["apiSecret"] = request.apiSecret;
    }

    if (!Util.isUnset(request.callbackRouteKey)) {
      body["callbackRouteKey"] = request.callbackRouteKey;
    }

    if (!Util.isUnset(request.callbackUrl)) {
      body["callbackUrl"] = request.callbackUrl;
    }

    if (!Util.isUnset(request.forceUpdate)) {
      body["forceUpdate"] = request.forceUpdate;
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
    return $tea.cast<RegisterCallbackResponse>(await this.doROARequest("RegisterCallback", "card_1.0", "HTTP", "POST", "AK", `/v1.0/card/callbacks/register`, "json", req, runtime), new RegisterCallbackResponse({}));
  }

  async updateCard(request: UpdateCardRequest): Promise<UpdateCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCardHeaders({ });
    return await this.updateCardWithOptions(request, headers, runtime);
  }

  async updateCardWithOptions(request: UpdateCardRequest, headers: UpdateCardHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.cardData))) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset($tea.toMap(request.cardUpdateOptions))) {
      body["cardUpdateOptions"] = request.cardUpdateOptions;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.privateData)) {
      body["privateData"] = request.privateData;
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
    return $tea.cast<UpdateCardResponse>(await this.doROARequest("UpdateCard", "card_1.0", "HTTP", "PUT", "AK", `/v1.0/card/instances`, "json", req, runtime), new UpdateCardResponse({}));
  }

}