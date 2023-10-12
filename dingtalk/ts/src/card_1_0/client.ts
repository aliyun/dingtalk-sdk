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
  imRobotOpenSpaceModel?: AppendSpaceRequestImRobotOpenSpaceModel;
  outTrackId?: string;
  topOpenSpaceModel?: AppendSpaceRequestTopOpenSpaceModel;
  static names(): { [key: string]: string } {
    return {
      coFeedOpenSpaceModel: 'coFeedOpenSpaceModel',
      imGroupOpenSpaceModel: 'imGroupOpenSpaceModel',
      imRobotOpenSpaceModel: 'imRobotOpenSpaceModel',
      outTrackId: 'outTrackId',
      topOpenSpaceModel: 'topOpenSpaceModel',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coFeedOpenSpaceModel: AppendSpaceRequestCoFeedOpenSpaceModel,
      imGroupOpenSpaceModel: AppendSpaceRequestImGroupOpenSpaceModel,
      imRobotOpenSpaceModel: AppendSpaceRequestImRobotOpenSpaceModel,
      outTrackId: 'string',
      topOpenSpaceModel: AppendSpaceRequestTopOpenSpaceModel,
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
  statusCode: number;
  body: AppendSpaceResponseBody;
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
  callbackType?: string;
  cardData?: CreateAndDeliverRequestCardData;
  cardTemplateId?: string;
  coFeedOpenDeliverModel?: CreateAndDeliverRequestCoFeedOpenDeliverModel;
  coFeedOpenSpaceModel?: CreateAndDeliverRequestCoFeedOpenSpaceModel;
  docOpenDeliverModel?: CreateAndDeliverRequestDocOpenDeliverModel;
  imGroupOpenDeliverModel?: CreateAndDeliverRequestImGroupOpenDeliverModel;
  imGroupOpenSpaceModel?: CreateAndDeliverRequestImGroupOpenSpaceModel;
  imRobotOpenDeliverModel?: CreateAndDeliverRequestImRobotOpenDeliverModel;
  imRobotOpenSpaceModel?: CreateAndDeliverRequestImRobotOpenSpaceModel;
  openDynamicDataConfig?: CreateAndDeliverRequestOpenDynamicDataConfig;
  openSpaceId?: string;
  outTrackId?: string;
  privateData?: { [key: string]: PrivateDataValue };
  topOpenDeliverModel?: CreateAndDeliverRequestTopOpenDeliverModel;
  topOpenSpaceModel?: CreateAndDeliverRequestTopOpenSpaceModel;
  userId?: string;
  userIdType?: number;
  static names(): { [key: string]: string } {
    return {
      callbackRouteKey: 'callbackRouteKey',
      callbackType: 'callbackType',
      cardData: 'cardData',
      cardTemplateId: 'cardTemplateId',
      coFeedOpenDeliverModel: 'coFeedOpenDeliverModel',
      coFeedOpenSpaceModel: 'coFeedOpenSpaceModel',
      docOpenDeliverModel: 'docOpenDeliverModel',
      imGroupOpenDeliverModel: 'imGroupOpenDeliverModel',
      imGroupOpenSpaceModel: 'imGroupOpenSpaceModel',
      imRobotOpenDeliverModel: 'imRobotOpenDeliverModel',
      imRobotOpenSpaceModel: 'imRobotOpenSpaceModel',
      openDynamicDataConfig: 'openDynamicDataConfig',
      openSpaceId: 'openSpaceId',
      outTrackId: 'outTrackId',
      privateData: 'privateData',
      topOpenDeliverModel: 'topOpenDeliverModel',
      topOpenSpaceModel: 'topOpenSpaceModel',
      userId: 'userId',
      userIdType: 'userIdType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callbackRouteKey: 'string',
      callbackType: 'string',
      cardData: CreateAndDeliverRequestCardData,
      cardTemplateId: 'string',
      coFeedOpenDeliverModel: CreateAndDeliverRequestCoFeedOpenDeliverModel,
      coFeedOpenSpaceModel: CreateAndDeliverRequestCoFeedOpenSpaceModel,
      docOpenDeliverModel: CreateAndDeliverRequestDocOpenDeliverModel,
      imGroupOpenDeliverModel: CreateAndDeliverRequestImGroupOpenDeliverModel,
      imGroupOpenSpaceModel: CreateAndDeliverRequestImGroupOpenSpaceModel,
      imRobotOpenDeliverModel: CreateAndDeliverRequestImRobotOpenDeliverModel,
      imRobotOpenSpaceModel: CreateAndDeliverRequestImRobotOpenSpaceModel,
      openDynamicDataConfig: CreateAndDeliverRequestOpenDynamicDataConfig,
      openSpaceId: 'string',
      outTrackId: 'string',
      privateData: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateDataValue },
      topOpenDeliverModel: CreateAndDeliverRequestTopOpenDeliverModel,
      topOpenSpaceModel: CreateAndDeliverRequestTopOpenSpaceModel,
      userId: 'string',
      userIdType: 'number',
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
  statusCode: number;
  body: CreateAndDeliverResponseBody;
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
  callbackType?: string;
  cardData?: CreateCardRequestCardData;
  cardTemplateId?: string;
  coFeedOpenSpaceModel?: CreateCardRequestCoFeedOpenSpaceModel;
  imGroupOpenSpaceModel?: CreateCardRequestImGroupOpenSpaceModel;
  imRobotOpenSpaceModel?: CreateCardRequestImRobotOpenSpaceModel;
  openDynamicDataConfig?: CreateCardRequestOpenDynamicDataConfig;
  outTrackId?: string;
  privateData?: { [key: string]: PrivateDataValue };
  topOpenSpaceModel?: CreateCardRequestTopOpenSpaceModel;
  userId?: string;
  userIdType?: number;
  static names(): { [key: string]: string } {
    return {
      callbackRouteKey: 'callbackRouteKey',
      callbackType: 'callbackType',
      cardData: 'cardData',
      cardTemplateId: 'cardTemplateId',
      coFeedOpenSpaceModel: 'coFeedOpenSpaceModel',
      imGroupOpenSpaceModel: 'imGroupOpenSpaceModel',
      imRobotOpenSpaceModel: 'imRobotOpenSpaceModel',
      openDynamicDataConfig: 'openDynamicDataConfig',
      outTrackId: 'outTrackId',
      privateData: 'privateData',
      topOpenSpaceModel: 'topOpenSpaceModel',
      userId: 'userId',
      userIdType: 'userIdType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callbackRouteKey: 'string',
      callbackType: 'string',
      cardData: CreateCardRequestCardData,
      cardTemplateId: 'string',
      coFeedOpenSpaceModel: CreateCardRequestCoFeedOpenSpaceModel,
      imGroupOpenSpaceModel: CreateCardRequestImGroupOpenSpaceModel,
      imRobotOpenSpaceModel: CreateCardRequestImRobotOpenSpaceModel,
      openDynamicDataConfig: CreateCardRequestOpenDynamicDataConfig,
      outTrackId: 'string',
      privateData: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateDataValue },
      topOpenSpaceModel: CreateCardRequestTopOpenSpaceModel,
      userId: 'string',
      userIdType: 'number',
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
  statusCode: number;
  body: CreateCardResponseBody;
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
  docOpenDeliverModel?: DeliverCardRequestDocOpenDeliverModel;
  imGroupOpenDeliverModel?: DeliverCardRequestImGroupOpenDeliverModel;
  imRobotOpenDeliverModel?: DeliverCardRequestImRobotOpenDeliverModel;
  openSpaceId?: string;
  outTrackId?: string;
  topOpenDeliverModel?: DeliverCardRequestTopOpenDeliverModel;
  userIdType?: number;
  static names(): { [key: string]: string } {
    return {
      coFeedOpenDeliverModel: 'coFeedOpenDeliverModel',
      docOpenDeliverModel: 'docOpenDeliverModel',
      imGroupOpenDeliverModel: 'imGroupOpenDeliverModel',
      imRobotOpenDeliverModel: 'imRobotOpenDeliverModel',
      openSpaceId: 'openSpaceId',
      outTrackId: 'outTrackId',
      topOpenDeliverModel: 'topOpenDeliverModel',
      userIdType: 'userIdType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coFeedOpenDeliverModel: DeliverCardRequestCoFeedOpenDeliverModel,
      docOpenDeliverModel: DeliverCardRequestDocOpenDeliverModel,
      imGroupOpenDeliverModel: DeliverCardRequestImGroupOpenDeliverModel,
      imRobotOpenDeliverModel: DeliverCardRequestImRobotOpenDeliverModel,
      openSpaceId: 'string',
      outTrackId: 'string',
      topOpenDeliverModel: DeliverCardRequestTopOpenDeliverModel,
      userIdType: 'number',
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
  statusCode: number;
  body: DeliverCardResponseBody;
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
  statusCode: number;
  body: RegisterCallbackResponseBody;
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
      body: RegisterCallbackResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StreamingUpdateHeaders extends $tea.Model {
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

export class StreamingUpdateRequest extends $tea.Model {
  content?: string;
  guid?: string;
  isError?: boolean;
  isFinalize?: boolean;
  isFull?: boolean;
  key?: string;
  outTrackId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      guid: 'guid',
      isError: 'isError',
      isFinalize: 'isFinalize',
      isFull: 'isFull',
      key: 'key',
      outTrackId: 'outTrackId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      guid: 'string',
      isError: 'boolean',
      isFinalize: 'boolean',
      isFull: 'boolean',
      key: 'string',
      outTrackId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StreamingUpdateResponseBody extends $tea.Model {
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

export class StreamingUpdateResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: StreamingUpdateResponseBody;
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
      body: StreamingUpdateResponseBody,
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
  userIdType?: number;
  static names(): { [key: string]: string } {
    return {
      cardData: 'cardData',
      cardUpdateOptions: 'cardUpdateOptions',
      outTrackId: 'outTrackId',
      privateData: 'privateData',
      userIdType: 'userIdType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardData: UpdateCardRequestCardData,
      cardUpdateOptions: UpdateCardRequestCardUpdateOptions,
      outTrackId: 'string',
      privateData: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateDataValue },
      userIdType: 'number',
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
  statusCode: number;
  body: UpdateCardResponseBody;
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
      body: UpdateCardResponseBody,
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

export class AppendSpaceRequestImRobotOpenSpaceModelNotification extends $tea.Model {
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

export class AppendSpaceRequestImRobotOpenSpaceModelSearchSupport extends $tea.Model {
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

export class AppendSpaceRequestImRobotOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: AppendSpaceRequestImRobotOpenSpaceModelNotification;
  searchSupport?: AppendSpaceRequestImRobotOpenSpaceModelSearchSupport;
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
      notification: AppendSpaceRequestImRobotOpenSpaceModelNotification,
      searchSupport: AppendSpaceRequestImRobotOpenSpaceModelSearchSupport,
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
  coolAppCode?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      coolAppCode: 'coolAppCode',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coolAppCode: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestDocOpenDeliverModel extends $tea.Model {
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestImGroupOpenDeliverModel extends $tea.Model {
  atUserIds?: { [key: string]: string };
  extension?: { [key: string]: string };
  recipients?: string[];
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      atUserIds: 'atUserIds',
      extension: 'extension',
      recipients: 'recipients',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atUserIds: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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

export class CreateAndDeliverRequestImRobotOpenDeliverModel extends $tea.Model {
  extension?: { [key: string]: string };
  robotCode?: string;
  spaceType?: string;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      robotCode: 'robotCode',
      spaceType: 'spaceType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      robotCode: 'string',
      spaceType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverRequestImRobotOpenSpaceModelNotification extends $tea.Model {
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

export class CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport extends $tea.Model {
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

export class CreateAndDeliverRequestImRobotOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: CreateAndDeliverRequestImRobotOpenSpaceModelNotification;
  searchSupport?: CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport;
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
      notification: CreateAndDeliverRequestImRobotOpenSpaceModelNotification,
      searchSupport: CreateAndDeliverRequestImRobotOpenSpaceModelSearchSupport,
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
  dynamicDataSourceConfigs?: CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs[];
  static names(): { [key: string]: string } {
    return {
      dynamicDataSourceConfigs: 'dynamicDataSourceConfigs',
    };
  }

  static types(): { [key: string]: any } {
    return {
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

export class CreateAndDeliverResponseBodyResultDeliverResults extends $tea.Model {
  carrierId?: string;
  errorMsg?: string;
  spaceId?: string;
  spaceType?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      carrierId: 'carrierId',
      errorMsg: 'errorMsg',
      spaceId: 'spaceId',
      spaceType: 'spaceType',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      carrierId: 'string',
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

export class CreateCardRequestImRobotOpenSpaceModelNotification extends $tea.Model {
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

export class CreateCardRequestImRobotOpenSpaceModelSearchSupport extends $tea.Model {
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

export class CreateCardRequestImRobotOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: CreateCardRequestImRobotOpenSpaceModelNotification;
  searchSupport?: CreateCardRequestImRobotOpenSpaceModelSearchSupport;
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
      notification: CreateCardRequestImRobotOpenSpaceModelNotification,
      searchSupport: CreateCardRequestImRobotOpenSpaceModelSearchSupport,
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
  dynamicDataSourceConfigs?: CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs[];
  static names(): { [key: string]: string } {
    return {
      dynamicDataSourceConfigs: 'dynamicDataSourceConfigs',
    };
  }

  static types(): { [key: string]: any } {
    return {
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

export class DeliverCardRequestDocOpenDeliverModel extends $tea.Model {
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeliverCardRequestImGroupOpenDeliverModel extends $tea.Model {
  atUserIds?: { [key: string]: string };
  extension?: { [key: string]: string };
  recipients?: string[];
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      atUserIds: 'atUserIds',
      extension: 'extension',
      recipients: 'recipients',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atUserIds: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      recipients: { 'type': 'array', 'itemType': 'string' },
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeliverCardRequestImRobotOpenDeliverModel extends $tea.Model {
  extension?: { [key: string]: string };
  robotCode?: string;
  spaceType?: string;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      robotCode: 'robotCode',
      spaceType: 'spaceType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      robotCode: 'string',
      spaceType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeliverCardRequestTopOpenDeliverModel extends $tea.Model {
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

export class DeliverCardResponseBodyResult extends $tea.Model {
  carrierId?: string;
  errorMsg?: string;
  spaceId?: string;
  spaceType?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      carrierId: 'carrierId',
      errorMsg: 'errorMsg',
      spaceId: 'spaceId',
      spaceType: 'spaceType',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      carrierId: 'string',
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


  async appendSpaceWithOptions(request: AppendSpaceRequest, headers: AppendSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<AppendSpaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coFeedOpenSpaceModel)) {
      body["coFeedOpenSpaceModel"] = request.coFeedOpenSpaceModel;
    }

    if (!Util.isUnset(request.imGroupOpenSpaceModel)) {
      body["imGroupOpenSpaceModel"] = request.imGroupOpenSpaceModel;
    }

    if (!Util.isUnset(request.imRobotOpenSpaceModel)) {
      body["imRobotOpenSpaceModel"] = request.imRobotOpenSpaceModel;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.topOpenSpaceModel)) {
      body["topOpenSpaceModel"] = request.topOpenSpaceModel;
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
      action: "AppendSpace",
      version: "card_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/card/instances/spaces`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AppendSpaceResponse>(await this.execute(params, req, runtime), new AppendSpaceResponse({}));
  }

  async appendSpace(request: AppendSpaceRequest): Promise<AppendSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AppendSpaceHeaders({ });
    return await this.appendSpaceWithOptions(request, headers, runtime);
  }

  async createAndDeliverWithOptions(request: CreateAndDeliverRequest, headers: CreateAndDeliverHeaders, runtime: $Util.RuntimeOptions): Promise<CreateAndDeliverResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.callbackRouteKey)) {
      body["callbackRouteKey"] = request.callbackRouteKey;
    }

    if (!Util.isUnset(request.callbackType)) {
      body["callbackType"] = request.callbackType;
    }

    if (!Util.isUnset(request.cardData)) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.cardTemplateId)) {
      body["cardTemplateId"] = request.cardTemplateId;
    }

    if (!Util.isUnset(request.coFeedOpenDeliverModel)) {
      body["coFeedOpenDeliverModel"] = request.coFeedOpenDeliverModel;
    }

    if (!Util.isUnset(request.coFeedOpenSpaceModel)) {
      body["coFeedOpenSpaceModel"] = request.coFeedOpenSpaceModel;
    }

    if (!Util.isUnset(request.docOpenDeliverModel)) {
      body["docOpenDeliverModel"] = request.docOpenDeliverModel;
    }

    if (!Util.isUnset(request.imGroupOpenDeliverModel)) {
      body["imGroupOpenDeliverModel"] = request.imGroupOpenDeliverModel;
    }

    if (!Util.isUnset(request.imGroupOpenSpaceModel)) {
      body["imGroupOpenSpaceModel"] = request.imGroupOpenSpaceModel;
    }

    if (!Util.isUnset(request.imRobotOpenDeliverModel)) {
      body["imRobotOpenDeliverModel"] = request.imRobotOpenDeliverModel;
    }

    if (!Util.isUnset(request.imRobotOpenSpaceModel)) {
      body["imRobotOpenSpaceModel"] = request.imRobotOpenSpaceModel;
    }

    if (!Util.isUnset(request.openDynamicDataConfig)) {
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

    if (!Util.isUnset(request.topOpenDeliverModel)) {
      body["topOpenDeliverModel"] = request.topOpenDeliverModel;
    }

    if (!Util.isUnset(request.topOpenSpaceModel)) {
      body["topOpenSpaceModel"] = request.topOpenSpaceModel;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.userIdType)) {
      body["userIdType"] = request.userIdType;
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
      action: "CreateAndDeliver",
      version: "card_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/card/instances/createAndDeliver`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateAndDeliverResponse>(await this.execute(params, req, runtime), new CreateAndDeliverResponse({}));
  }

  async createAndDeliver(request: CreateAndDeliverRequest): Promise<CreateAndDeliverResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateAndDeliverHeaders({ });
    return await this.createAndDeliverWithOptions(request, headers, runtime);
  }

  async createCardWithOptions(request: CreateCardRequest, headers: CreateCardHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.callbackRouteKey)) {
      body["callbackRouteKey"] = request.callbackRouteKey;
    }

    if (!Util.isUnset(request.callbackType)) {
      body["callbackType"] = request.callbackType;
    }

    if (!Util.isUnset(request.cardData)) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.cardTemplateId)) {
      body["cardTemplateId"] = request.cardTemplateId;
    }

    if (!Util.isUnset(request.coFeedOpenSpaceModel)) {
      body["coFeedOpenSpaceModel"] = request.coFeedOpenSpaceModel;
    }

    if (!Util.isUnset(request.imGroupOpenSpaceModel)) {
      body["imGroupOpenSpaceModel"] = request.imGroupOpenSpaceModel;
    }

    if (!Util.isUnset(request.imRobotOpenSpaceModel)) {
      body["imRobotOpenSpaceModel"] = request.imRobotOpenSpaceModel;
    }

    if (!Util.isUnset(request.openDynamicDataConfig)) {
      body["openDynamicDataConfig"] = request.openDynamicDataConfig;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.privateData)) {
      body["privateData"] = request.privateData;
    }

    if (!Util.isUnset(request.topOpenSpaceModel)) {
      body["topOpenSpaceModel"] = request.topOpenSpaceModel;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.userIdType)) {
      body["userIdType"] = request.userIdType;
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
      action: "CreateCard",
      version: "card_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/card/instances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateCardResponse>(await this.execute(params, req, runtime), new CreateCardResponse({}));
  }

  async createCard(request: CreateCardRequest): Promise<CreateCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCardHeaders({ });
    return await this.createCardWithOptions(request, headers, runtime);
  }

  async deliverCardWithOptions(request: DeliverCardRequest, headers: DeliverCardHeaders, runtime: $Util.RuntimeOptions): Promise<DeliverCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coFeedOpenDeliverModel)) {
      body["coFeedOpenDeliverModel"] = request.coFeedOpenDeliverModel;
    }

    if (!Util.isUnset(request.docOpenDeliverModel)) {
      body["docOpenDeliverModel"] = request.docOpenDeliverModel;
    }

    if (!Util.isUnset(request.imGroupOpenDeliverModel)) {
      body["imGroupOpenDeliverModel"] = request.imGroupOpenDeliverModel;
    }

    if (!Util.isUnset(request.imRobotOpenDeliverModel)) {
      body["imRobotOpenDeliverModel"] = request.imRobotOpenDeliverModel;
    }

    if (!Util.isUnset(request.openSpaceId)) {
      body["openSpaceId"] = request.openSpaceId;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.topOpenDeliverModel)) {
      body["topOpenDeliverModel"] = request.topOpenDeliverModel;
    }

    if (!Util.isUnset(request.userIdType)) {
      body["userIdType"] = request.userIdType;
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
      action: "DeliverCard",
      version: "card_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/card/instances/deliver`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeliverCardResponse>(await this.execute(params, req, runtime), new DeliverCardResponse({}));
  }

  async deliverCard(request: DeliverCardRequest): Promise<DeliverCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeliverCardHeaders({ });
    return await this.deliverCardWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "RegisterCallback",
      version: "card_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/card/callbacks/register`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RegisterCallbackResponse>(await this.execute(params, req, runtime), new RegisterCallbackResponse({}));
  }

  async registerCallback(request: RegisterCallbackRequest): Promise<RegisterCallbackResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterCallbackHeaders({ });
    return await this.registerCallbackWithOptions(request, headers, runtime);
  }

  async streamingUpdateWithOptions(request: StreamingUpdateRequest, headers: StreamingUpdateHeaders, runtime: $Util.RuntimeOptions): Promise<StreamingUpdateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.guid)) {
      body["guid"] = request.guid;
    }

    if (!Util.isUnset(request.isError)) {
      body["isError"] = request.isError;
    }

    if (!Util.isUnset(request.isFinalize)) {
      body["isFinalize"] = request.isFinalize;
    }

    if (!Util.isUnset(request.isFull)) {
      body["isFull"] = request.isFull;
    }

    if (!Util.isUnset(request.key)) {
      body["key"] = request.key;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
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
      action: "StreamingUpdate",
      version: "card_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/card/streaming`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<StreamingUpdateResponse>(await this.execute(params, req, runtime), new StreamingUpdateResponse({}));
  }

  async streamingUpdate(request: StreamingUpdateRequest): Promise<StreamingUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StreamingUpdateHeaders({ });
    return await this.streamingUpdateWithOptions(request, headers, runtime);
  }

  async updateCardWithOptions(request: UpdateCardRequest, headers: UpdateCardHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cardData)) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.cardUpdateOptions)) {
      body["cardUpdateOptions"] = request.cardUpdateOptions;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.privateData)) {
      body["privateData"] = request.privateData;
    }

    if (!Util.isUnset(request.userIdType)) {
      body["userIdType"] = request.userIdType;
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
      action: "UpdateCard",
      version: "card_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/card/instances`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateCardResponse>(await this.execute(params, req, runtime), new UpdateCardResponse({}));
  }

  async updateCard(request: UpdateCardRequest): Promise<UpdateCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCardHeaders({ });
    return await this.updateCardWithOptions(request, headers, runtime);
  }

}
