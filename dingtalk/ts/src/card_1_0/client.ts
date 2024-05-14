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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AppendSpaceResponseBody;
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

export class AppendSpaceWithDelegateHeaders extends $tea.Model {
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

export class AppendSpaceWithDelegateRequest extends $tea.Model {
  coFeedOpenSpaceModel?: AppendSpaceWithDelegateRequestCoFeedOpenSpaceModel;
  imGroupOpenSpaceModel?: AppendSpaceWithDelegateRequestImGroupOpenSpaceModel;
  imRobotOpenSpaceModel?: AppendSpaceWithDelegateRequestImRobotOpenSpaceModel;
  outTrackId?: string;
  topOpenSpaceModel?: AppendSpaceWithDelegateRequestTopOpenSpaceModel;
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
      coFeedOpenSpaceModel: AppendSpaceWithDelegateRequestCoFeedOpenSpaceModel,
      imGroupOpenSpaceModel: AppendSpaceWithDelegateRequestImGroupOpenSpaceModel,
      imRobotOpenSpaceModel: AppendSpaceWithDelegateRequestImRobotOpenSpaceModel,
      outTrackId: 'string',
      topOpenSpaceModel: AppendSpaceWithDelegateRequestTopOpenSpaceModel,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendSpaceWithDelegateResponseBody extends $tea.Model {
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

export class AppendSpaceWithDelegateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AppendSpaceWithDelegateResponseBody;
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
      body: AppendSpaceWithDelegateResponseBody,
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
  imSingleOpenDeliverModel?: CreateAndDeliverRequestImSingleOpenDeliverModel;
  imSingleOpenSpaceModel?: CreateAndDeliverRequestImSingleOpenSpaceModel;
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
      imSingleOpenDeliverModel: 'imSingleOpenDeliverModel',
      imSingleOpenSpaceModel: 'imSingleOpenSpaceModel',
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
      imSingleOpenDeliverModel: CreateAndDeliverRequestImSingleOpenDeliverModel,
      imSingleOpenSpaceModel: CreateAndDeliverRequestImSingleOpenSpaceModel,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateAndDeliverResponseBody;
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

export class CreateAndDeliverWithDelegateHeaders extends $tea.Model {
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

export class CreateAndDeliverWithDelegateRequest extends $tea.Model {
  callbackRouteKey?: string;
  callbackType?: string;
  cardData?: CreateAndDeliverWithDelegateRequestCardData;
  cardTemplateId?: string;
  coFeedOpenDeliverModel?: CreateAndDeliverWithDelegateRequestCoFeedOpenDeliverModel;
  coFeedOpenSpaceModel?: CreateAndDeliverWithDelegateRequestCoFeedOpenSpaceModel;
  docOpenDeliverModel?: CreateAndDeliverWithDelegateRequestDocOpenDeliverModel;
  imGroupOpenDeliverModel?: CreateAndDeliverWithDelegateRequestImGroupOpenDeliverModel;
  imGroupOpenSpaceModel?: CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModel;
  imRobotOpenDeliverModel?: CreateAndDeliverWithDelegateRequestImRobotOpenDeliverModel;
  imRobotOpenSpaceModel?: CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModel;
  imSingleOpenDeliverModel?: CreateAndDeliverWithDelegateRequestImSingleOpenDeliverModel;
  imSingleOpenSpaceModel?: CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModel;
  openDynamicDataConfig?: CreateAndDeliverWithDelegateRequestOpenDynamicDataConfig;
  openSpaceId?: string;
  outTrackId?: string;
  privateData?: { [key: string]: PrivateDataValue };
  topOpenDeliverModel?: CreateAndDeliverWithDelegateRequestTopOpenDeliverModel;
  topOpenSpaceModel?: CreateAndDeliverWithDelegateRequestTopOpenSpaceModel;
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
      imSingleOpenDeliverModel: 'imSingleOpenDeliverModel',
      imSingleOpenSpaceModel: 'imSingleOpenSpaceModel',
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
      cardData: CreateAndDeliverWithDelegateRequestCardData,
      cardTemplateId: 'string',
      coFeedOpenDeliverModel: CreateAndDeliverWithDelegateRequestCoFeedOpenDeliverModel,
      coFeedOpenSpaceModel: CreateAndDeliverWithDelegateRequestCoFeedOpenSpaceModel,
      docOpenDeliverModel: CreateAndDeliverWithDelegateRequestDocOpenDeliverModel,
      imGroupOpenDeliverModel: CreateAndDeliverWithDelegateRequestImGroupOpenDeliverModel,
      imGroupOpenSpaceModel: CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModel,
      imRobotOpenDeliverModel: CreateAndDeliverWithDelegateRequestImRobotOpenDeliverModel,
      imRobotOpenSpaceModel: CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModel,
      imSingleOpenDeliverModel: CreateAndDeliverWithDelegateRequestImSingleOpenDeliverModel,
      imSingleOpenSpaceModel: CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModel,
      openDynamicDataConfig: CreateAndDeliverWithDelegateRequestOpenDynamicDataConfig,
      openSpaceId: 'string',
      outTrackId: 'string',
      privateData: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateDataValue },
      topOpenDeliverModel: CreateAndDeliverWithDelegateRequestTopOpenDeliverModel,
      topOpenSpaceModel: CreateAndDeliverWithDelegateRequestTopOpenSpaceModel,
      userId: 'string',
      userIdType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverWithDelegateResponseBody extends $tea.Model {
  result?: CreateAndDeliverWithDelegateResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateAndDeliverWithDelegateResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverWithDelegateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateAndDeliverWithDelegateResponseBody;
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
      body: CreateAndDeliverWithDelegateResponseBody,
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
  imSingleOpenSpaceModel?: CreateCardRequestImSingleOpenSpaceModel;
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
      imSingleOpenSpaceModel: 'imSingleOpenSpaceModel',
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
      imSingleOpenSpaceModel: CreateCardRequestImSingleOpenSpaceModel,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateCardResponseBody;
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

export class CreateCardWithDelegateHeaders extends $tea.Model {
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

export class CreateCardWithDelegateRequest extends $tea.Model {
  callbackRouteKey?: string;
  callbackType?: string;
  cardData?: CreateCardWithDelegateRequestCardData;
  cardTemplateId?: string;
  coFeedOpenSpaceModel?: CreateCardWithDelegateRequestCoFeedOpenSpaceModel;
  imGroupOpenSpaceModel?: CreateCardWithDelegateRequestImGroupOpenSpaceModel;
  imRobotOpenSpaceModel?: CreateCardWithDelegateRequestImRobotOpenSpaceModel;
  imSingleOpenSpaceModel?: CreateCardWithDelegateRequestImSingleOpenSpaceModel;
  openDynamicDataConfig?: CreateCardWithDelegateRequestOpenDynamicDataConfig;
  outTrackId?: string;
  privateData?: { [key: string]: PrivateDataValue };
  topOpenSpaceModel?: CreateCardWithDelegateRequestTopOpenSpaceModel;
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
      imSingleOpenSpaceModel: 'imSingleOpenSpaceModel',
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
      cardData: CreateCardWithDelegateRequestCardData,
      cardTemplateId: 'string',
      coFeedOpenSpaceModel: CreateCardWithDelegateRequestCoFeedOpenSpaceModel,
      imGroupOpenSpaceModel: CreateCardWithDelegateRequestImGroupOpenSpaceModel,
      imRobotOpenSpaceModel: CreateCardWithDelegateRequestImRobotOpenSpaceModel,
      imSingleOpenSpaceModel: CreateCardWithDelegateRequestImSingleOpenSpaceModel,
      openDynamicDataConfig: CreateCardWithDelegateRequestOpenDynamicDataConfig,
      outTrackId: 'string',
      privateData: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateDataValue },
      topOpenSpaceModel: CreateCardWithDelegateRequestTopOpenSpaceModel,
      userId: 'string',
      userIdType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardWithDelegateResponseBody extends $tea.Model {
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

export class CreateCardWithDelegateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateCardWithDelegateResponseBody;
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
      body: CreateCardWithDelegateResponseBody,
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
  imSingleOpenDeliverModel?: DeliverCardRequestImSingleOpenDeliverModel;
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
      imSingleOpenDeliverModel: 'imSingleOpenDeliverModel',
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
      imSingleOpenDeliverModel: DeliverCardRequestImSingleOpenDeliverModel,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeliverCardResponseBody;
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

export class DeliverCardWithDelegateHeaders extends $tea.Model {
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

export class DeliverCardWithDelegateRequest extends $tea.Model {
  coFeedOpenDeliverModel?: DeliverCardWithDelegateRequestCoFeedOpenDeliverModel;
  docOpenDeliverModel?: DeliverCardWithDelegateRequestDocOpenDeliverModel;
  imGroupOpenDeliverModel?: DeliverCardWithDelegateRequestImGroupOpenDeliverModel;
  imRobotOpenDeliverModel?: DeliverCardWithDelegateRequestImRobotOpenDeliverModel;
  imSingleOpenDeliverModel?: DeliverCardWithDelegateRequestImSingleOpenDeliverModel;
  openSpaceId?: string;
  outTrackId?: string;
  topOpenDeliverModel?: DeliverCardWithDelegateRequestTopOpenDeliverModel;
  userIdType?: number;
  static names(): { [key: string]: string } {
    return {
      coFeedOpenDeliverModel: 'coFeedOpenDeliverModel',
      docOpenDeliverModel: 'docOpenDeliverModel',
      imGroupOpenDeliverModel: 'imGroupOpenDeliverModel',
      imRobotOpenDeliverModel: 'imRobotOpenDeliverModel',
      imSingleOpenDeliverModel: 'imSingleOpenDeliverModel',
      openSpaceId: 'openSpaceId',
      outTrackId: 'outTrackId',
      topOpenDeliverModel: 'topOpenDeliverModel',
      userIdType: 'userIdType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coFeedOpenDeliverModel: DeliverCardWithDelegateRequestCoFeedOpenDeliverModel,
      docOpenDeliverModel: DeliverCardWithDelegateRequestDocOpenDeliverModel,
      imGroupOpenDeliverModel: DeliverCardWithDelegateRequestImGroupOpenDeliverModel,
      imRobotOpenDeliverModel: DeliverCardWithDelegateRequestImRobotOpenDeliverModel,
      imSingleOpenDeliverModel: DeliverCardWithDelegateRequestImSingleOpenDeliverModel,
      openSpaceId: 'string',
      outTrackId: 'string',
      topOpenDeliverModel: DeliverCardWithDelegateRequestTopOpenDeliverModel,
      userIdType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeliverCardWithDelegateResponseBody extends $tea.Model {
  result?: DeliverCardWithDelegateResponseBodyResult[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': DeliverCardWithDelegateResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeliverCardWithDelegateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeliverCardWithDelegateResponseBody;
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
      body: DeliverCardWithDelegateResponseBody,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RegisterCallbackResponseBody;
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

export class RegisterCallbackWithDelegateHeaders extends $tea.Model {
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

export class RegisterCallbackWithDelegateRequest extends $tea.Model {
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

export class RegisterCallbackWithDelegateResponseBody extends $tea.Model {
  result?: RegisterCallbackWithDelegateResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: RegisterCallbackWithDelegateResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterCallbackWithDelegateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RegisterCallbackWithDelegateResponseBody;
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
      body: RegisterCallbackWithDelegateResponseBody,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: StreamingUpdateResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateCardResponseBody;
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

export class UpdateCardWithDelegateHeaders extends $tea.Model {
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

export class UpdateCardWithDelegateRequest extends $tea.Model {
  cardData?: UpdateCardWithDelegateRequestCardData;
  cardUpdateOptions?: UpdateCardWithDelegateRequestCardUpdateOptions;
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
      cardData: UpdateCardWithDelegateRequestCardData,
      cardUpdateOptions: UpdateCardWithDelegateRequestCardUpdateOptions,
      outTrackId: 'string',
      privateData: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateDataValue },
      userIdType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateCardWithDelegateResponseBody extends $tea.Model {
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

export class UpdateCardWithDelegateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateCardWithDelegateResponseBody;
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
      body: UpdateCardWithDelegateResponseBody,
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

export class AppendSpaceWithDelegateRequestCoFeedOpenSpaceModel extends $tea.Model {
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

export class AppendSpaceWithDelegateRequestImGroupOpenSpaceModelNotification extends $tea.Model {
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

export class AppendSpaceWithDelegateRequestImGroupOpenSpaceModelSearchSupport extends $tea.Model {
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

export class AppendSpaceWithDelegateRequestImGroupOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: AppendSpaceWithDelegateRequestImGroupOpenSpaceModelNotification;
  searchSupport?: AppendSpaceWithDelegateRequestImGroupOpenSpaceModelSearchSupport;
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
      notification: AppendSpaceWithDelegateRequestImGroupOpenSpaceModelNotification,
      searchSupport: AppendSpaceWithDelegateRequestImGroupOpenSpaceModelSearchSupport,
      supportForward: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendSpaceWithDelegateRequestImRobotOpenSpaceModelNotification extends $tea.Model {
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

export class AppendSpaceWithDelegateRequestImRobotOpenSpaceModelSearchSupport extends $tea.Model {
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

export class AppendSpaceWithDelegateRequestImRobotOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: AppendSpaceWithDelegateRequestImRobotOpenSpaceModelNotification;
  searchSupport?: AppendSpaceWithDelegateRequestImRobotOpenSpaceModelSearchSupport;
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
      notification: AppendSpaceWithDelegateRequestImRobotOpenSpaceModelNotification,
      searchSupport: AppendSpaceWithDelegateRequestImRobotOpenSpaceModelSearchSupport,
      supportForward: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendSpaceWithDelegateRequestTopOpenSpaceModel extends $tea.Model {
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

export class CreateAndDeliverRequestImSingleOpenDeliverModel extends $tea.Model {
  atUserIds?: { [key: string]: string };
  extension?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      atUserIds: 'atUserIds',
      extension: 'extension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atUserIds: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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

export class CreateAndDeliverWithDelegateRequestCardData extends $tea.Model {
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

export class CreateAndDeliverWithDelegateRequestCoFeedOpenDeliverModel extends $tea.Model {
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

export class CreateAndDeliverWithDelegateRequestCoFeedOpenSpaceModel extends $tea.Model {
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

export class CreateAndDeliverWithDelegateRequestDocOpenDeliverModel extends $tea.Model {
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

export class CreateAndDeliverWithDelegateRequestImGroupOpenDeliverModel extends $tea.Model {
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

export class CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelNotification extends $tea.Model {
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

export class CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelSearchSupport extends $tea.Model {
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

export class CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelNotification;
  searchSupport?: CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelSearchSupport;
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
      notification: CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelNotification,
      searchSupport: CreateAndDeliverWithDelegateRequestImGroupOpenSpaceModelSearchSupport,
      supportForward: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverWithDelegateRequestImRobotOpenDeliverModel extends $tea.Model {
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

export class CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelNotification extends $tea.Model {
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

export class CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelSearchSupport extends $tea.Model {
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

export class CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelNotification;
  searchSupport?: CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelSearchSupport;
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
      notification: CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelNotification,
      searchSupport: CreateAndDeliverWithDelegateRequestImRobotOpenSpaceModelSearchSupport,
      supportForward: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverWithDelegateRequestImSingleOpenDeliverModel extends $tea.Model {
  atUserIds?: { [key: string]: string };
  extension?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      atUserIds: 'atUserIds',
      extension: 'extension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atUserIds: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelNotification extends $tea.Model {
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

export class CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelSearchSupport extends $tea.Model {
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

export class CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelNotification;
  searchSupport?: CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelSearchSupport;
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
      notification: CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelNotification,
      searchSupport: CreateAndDeliverWithDelegateRequestImSingleOpenSpaceModelSearchSupport,
      supportForward: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig extends $tea.Model {
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

export class CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs extends $tea.Model {
  constParams?: { [key: string]: string };
  dynamicDataSourceId?: string;
  pullConfig?: CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig;
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
      pullConfig: CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverWithDelegateRequestOpenDynamicDataConfig extends $tea.Model {
  dynamicDataSourceConfigs?: CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs[];
  static names(): { [key: string]: string } {
    return {
      dynamicDataSourceConfigs: 'dynamicDataSourceConfigs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dynamicDataSourceConfigs: { 'type': 'array', 'itemType': CreateAndDeliverWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAndDeliverWithDelegateRequestTopOpenDeliverModel extends $tea.Model {
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

export class CreateAndDeliverWithDelegateRequestTopOpenSpaceModel extends $tea.Model {
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

export class CreateAndDeliverWithDelegateResponseBodyResultDeliverResults extends $tea.Model {
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

export class CreateAndDeliverWithDelegateResponseBodyResult extends $tea.Model {
  deliverResults?: CreateAndDeliverWithDelegateResponseBodyResultDeliverResults[];
  outTrackId?: string;
  static names(): { [key: string]: string } {
    return {
      deliverResults: 'deliverResults',
      outTrackId: 'outTrackId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deliverResults: { 'type': 'array', 'itemType': CreateAndDeliverWithDelegateResponseBodyResultDeliverResults },
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

export class CreateCardWithDelegateRequestCardData extends $tea.Model {
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

export class CreateCardWithDelegateRequestCoFeedOpenSpaceModel extends $tea.Model {
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

export class CreateCardWithDelegateRequestImGroupOpenSpaceModelNotification extends $tea.Model {
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

export class CreateCardWithDelegateRequestImGroupOpenSpaceModelSearchSupport extends $tea.Model {
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

export class CreateCardWithDelegateRequestImGroupOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: CreateCardWithDelegateRequestImGroupOpenSpaceModelNotification;
  searchSupport?: CreateCardWithDelegateRequestImGroupOpenSpaceModelSearchSupport;
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
      notification: CreateCardWithDelegateRequestImGroupOpenSpaceModelNotification,
      searchSupport: CreateCardWithDelegateRequestImGroupOpenSpaceModelSearchSupport,
      supportForward: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardWithDelegateRequestImRobotOpenSpaceModelNotification extends $tea.Model {
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

export class CreateCardWithDelegateRequestImRobotOpenSpaceModelSearchSupport extends $tea.Model {
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

export class CreateCardWithDelegateRequestImRobotOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: CreateCardWithDelegateRequestImRobotOpenSpaceModelNotification;
  searchSupport?: CreateCardWithDelegateRequestImRobotOpenSpaceModelSearchSupport;
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
      notification: CreateCardWithDelegateRequestImRobotOpenSpaceModelNotification,
      searchSupport: CreateCardWithDelegateRequestImRobotOpenSpaceModelSearchSupport,
      supportForward: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardWithDelegateRequestImSingleOpenSpaceModelNotification extends $tea.Model {
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

export class CreateCardWithDelegateRequestImSingleOpenSpaceModelSearchSupport extends $tea.Model {
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

export class CreateCardWithDelegateRequestImSingleOpenSpaceModel extends $tea.Model {
  lastMessageI18n?: { [key: string]: string };
  notification?: CreateCardWithDelegateRequestImSingleOpenSpaceModelNotification;
  searchSupport?: CreateCardWithDelegateRequestImSingleOpenSpaceModelSearchSupport;
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
      notification: CreateCardWithDelegateRequestImSingleOpenSpaceModelNotification,
      searchSupport: CreateCardWithDelegateRequestImSingleOpenSpaceModelSearchSupport,
      supportForward: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig extends $tea.Model {
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

export class CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs extends $tea.Model {
  constParams?: { [key: string]: string };
  dynamicDataSourceId?: string;
  pullConfig?: CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig;
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
      pullConfig: CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardWithDelegateRequestOpenDynamicDataConfig extends $tea.Model {
  dynamicDataSourceConfigs?: CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs[];
  static names(): { [key: string]: string } {
    return {
      dynamicDataSourceConfigs: 'dynamicDataSourceConfigs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dynamicDataSourceConfigs: { 'type': 'array', 'itemType': CreateCardWithDelegateRequestOpenDynamicDataConfigDynamicDataSourceConfigs },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCardWithDelegateRequestTopOpenSpaceModel extends $tea.Model {
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

export class DeliverCardRequestImSingleOpenDeliverModel extends $tea.Model {
  atUserIds?: { [key: string]: string };
  extension?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      atUserIds: 'atUserIds',
      extension: 'extension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atUserIds: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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

export class DeliverCardWithDelegateRequestCoFeedOpenDeliverModel extends $tea.Model {
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

export class DeliverCardWithDelegateRequestDocOpenDeliverModel extends $tea.Model {
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

export class DeliverCardWithDelegateRequestImGroupOpenDeliverModel extends $tea.Model {
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

export class DeliverCardWithDelegateRequestImRobotOpenDeliverModel extends $tea.Model {
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

export class DeliverCardWithDelegateRequestImSingleOpenDeliverModel extends $tea.Model {
  atUserIds?: { [key: string]: string };
  extension?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      atUserIds: 'atUserIds',
      extension: 'extension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atUserIds: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeliverCardWithDelegateRequestTopOpenDeliverModel extends $tea.Model {
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

export class DeliverCardWithDelegateResponseBodyResult extends $tea.Model {
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

export class RegisterCallbackWithDelegateResponseBodyResult extends $tea.Model {
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

export class UpdateCardWithDelegateRequestCardData extends $tea.Model {
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

export class UpdateCardWithDelegateRequestCardUpdateOptions extends $tea.Model {
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


  /**
   * @summary 新增或更新卡片的场域信息
   *
   * @param request AppendSpaceRequest
   * @param headers AppendSpaceHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return AppendSpaceResponse
   */
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

  /**
   * @summary 新增或更新卡片的场域信息
   *
   * @param request AppendSpaceRequest
   * @return AppendSpaceResponse
   */
  async appendSpace(request: AppendSpaceRequest): Promise<AppendSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AppendSpaceHeaders({ });
    return await this.appendSpaceWithOptions(request, headers, runtime);
  }

  /**
   * @summary 新增或更新卡片的场域信息
   *
   * @param request AppendSpaceWithDelegateRequest
   * @param headers AppendSpaceWithDelegateHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return AppendSpaceWithDelegateResponse
   */
  async appendSpaceWithDelegateWithOptions(request: AppendSpaceWithDelegateRequest, headers: AppendSpaceWithDelegateHeaders, runtime: $Util.RuntimeOptions): Promise<AppendSpaceWithDelegateResponse> {
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
      action: "AppendSpaceWithDelegate",
      version: "card_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/card/me/instances/spaces`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AppendSpaceWithDelegateResponse>(await this.execute(params, req, runtime), new AppendSpaceWithDelegateResponse({}));
  }

  /**
   * @summary 新增或更新卡片的场域信息
   *
   * @param request AppendSpaceWithDelegateRequest
   * @return AppendSpaceWithDelegateResponse
   */
  async appendSpaceWithDelegate(request: AppendSpaceWithDelegateRequest): Promise<AppendSpaceWithDelegateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AppendSpaceWithDelegateHeaders({ });
    return await this.appendSpaceWithDelegateWithOptions(request, headers, runtime);
  }

  /**
   * @summary 创建并投放卡片
   *
   * @param request CreateAndDeliverRequest
   * @param headers CreateAndDeliverHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return CreateAndDeliverResponse
   */
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

    if (!Util.isUnset(request.imSingleOpenDeliverModel)) {
      body["imSingleOpenDeliverModel"] = request.imSingleOpenDeliverModel;
    }

    if (!Util.isUnset(request.imSingleOpenSpaceModel)) {
      body["imSingleOpenSpaceModel"] = request.imSingleOpenSpaceModel;
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

  /**
   * @summary 创建并投放卡片
   *
   * @param request CreateAndDeliverRequest
   * @return CreateAndDeliverResponse
   */
  async createAndDeliver(request: CreateAndDeliverRequest): Promise<CreateAndDeliverResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateAndDeliverHeaders({ });
    return await this.createAndDeliverWithOptions(request, headers, runtime);
  }

  /**
   * @summary 创建并投放卡片
   *
   * @param request CreateAndDeliverWithDelegateRequest
   * @param headers CreateAndDeliverWithDelegateHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return CreateAndDeliverWithDelegateResponse
   */
  async createAndDeliverWithDelegateWithOptions(request: CreateAndDeliverWithDelegateRequest, headers: CreateAndDeliverWithDelegateHeaders, runtime: $Util.RuntimeOptions): Promise<CreateAndDeliverWithDelegateResponse> {
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

    if (!Util.isUnset(request.imSingleOpenDeliverModel)) {
      body["imSingleOpenDeliverModel"] = request.imSingleOpenDeliverModel;
    }

    if (!Util.isUnset(request.imSingleOpenSpaceModel)) {
      body["imSingleOpenSpaceModel"] = request.imSingleOpenSpaceModel;
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
      action: "CreateAndDeliverWithDelegate",
      version: "card_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/card/me/instances/createAndDeliver`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateAndDeliverWithDelegateResponse>(await this.execute(params, req, runtime), new CreateAndDeliverWithDelegateResponse({}));
  }

  /**
   * @summary 创建并投放卡片
   *
   * @param request CreateAndDeliverWithDelegateRequest
   * @return CreateAndDeliverWithDelegateResponse
   */
  async createAndDeliverWithDelegate(request: CreateAndDeliverWithDelegateRequest): Promise<CreateAndDeliverWithDelegateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateAndDeliverWithDelegateHeaders({ });
    return await this.createAndDeliverWithDelegateWithOptions(request, headers, runtime);
  }

  /**
   * @summary 创建卡片
   *
   * @param request CreateCardRequest
   * @param headers CreateCardHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return CreateCardResponse
   */
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

    if (!Util.isUnset(request.imSingleOpenSpaceModel)) {
      body["imSingleOpenSpaceModel"] = request.imSingleOpenSpaceModel;
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

  /**
   * @summary 创建卡片
   *
   * @param request CreateCardRequest
   * @return CreateCardResponse
   */
  async createCard(request: CreateCardRequest): Promise<CreateCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCardHeaders({ });
    return await this.createCardWithOptions(request, headers, runtime);
  }

  /**
   * @summary 创建卡片
   *
   * @param request CreateCardWithDelegateRequest
   * @param headers CreateCardWithDelegateHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return CreateCardWithDelegateResponse
   */
  async createCardWithDelegateWithOptions(request: CreateCardWithDelegateRequest, headers: CreateCardWithDelegateHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCardWithDelegateResponse> {
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

    if (!Util.isUnset(request.imSingleOpenSpaceModel)) {
      body["imSingleOpenSpaceModel"] = request.imSingleOpenSpaceModel;
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
      action: "CreateCardWithDelegate",
      version: "card_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/card/me/instances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateCardWithDelegateResponse>(await this.execute(params, req, runtime), new CreateCardWithDelegateResponse({}));
  }

  /**
   * @summary 创建卡片
   *
   * @param request CreateCardWithDelegateRequest
   * @return CreateCardWithDelegateResponse
   */
  async createCardWithDelegate(request: CreateCardWithDelegateRequest): Promise<CreateCardWithDelegateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCardWithDelegateHeaders({ });
    return await this.createCardWithDelegateWithOptions(request, headers, runtime);
  }

  /**
   * @summary 投放卡片
   *
   * @param request DeliverCardRequest
   * @param headers DeliverCardHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return DeliverCardResponse
   */
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

    if (!Util.isUnset(request.imSingleOpenDeliverModel)) {
      body["imSingleOpenDeliverModel"] = request.imSingleOpenDeliverModel;
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

  /**
   * @summary 投放卡片
   *
   * @param request DeliverCardRequest
   * @return DeliverCardResponse
   */
  async deliverCard(request: DeliverCardRequest): Promise<DeliverCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeliverCardHeaders({ });
    return await this.deliverCardWithOptions(request, headers, runtime);
  }

  /**
   * @summary 投放卡片
   *
   * @param request DeliverCardWithDelegateRequest
   * @param headers DeliverCardWithDelegateHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return DeliverCardWithDelegateResponse
   */
  async deliverCardWithDelegateWithOptions(request: DeliverCardWithDelegateRequest, headers: DeliverCardWithDelegateHeaders, runtime: $Util.RuntimeOptions): Promise<DeliverCardWithDelegateResponse> {
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

    if (!Util.isUnset(request.imSingleOpenDeliverModel)) {
      body["imSingleOpenDeliverModel"] = request.imSingleOpenDeliverModel;
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
      action: "DeliverCardWithDelegate",
      version: "card_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/card/me/instances/deliver`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeliverCardWithDelegateResponse>(await this.execute(params, req, runtime), new DeliverCardWithDelegateResponse({}));
  }

  /**
   * @summary 投放卡片
   *
   * @param request DeliverCardWithDelegateRequest
   * @return DeliverCardWithDelegateResponse
   */
  async deliverCardWithDelegate(request: DeliverCardWithDelegateRequest): Promise<DeliverCardWithDelegateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeliverCardWithDelegateHeaders({ });
    return await this.deliverCardWithDelegateWithOptions(request, headers, runtime);
  }

  /**
   * @summary 注册卡片回调地址
   *
   * @param request RegisterCallbackRequest
   * @param headers RegisterCallbackHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return RegisterCallbackResponse
   */
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

  /**
   * @summary 注册卡片回调地址
   *
   * @param request RegisterCallbackRequest
   * @return RegisterCallbackResponse
   */
  async registerCallback(request: RegisterCallbackRequest): Promise<RegisterCallbackResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterCallbackHeaders({ });
    return await this.registerCallbackWithOptions(request, headers, runtime);
  }

  /**
   * @summary 注册卡片回调地址
   *
   * @param request RegisterCallbackWithDelegateRequest
   * @param headers RegisterCallbackWithDelegateHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return RegisterCallbackWithDelegateResponse
   */
  async registerCallbackWithDelegateWithOptions(request: RegisterCallbackWithDelegateRequest, headers: RegisterCallbackWithDelegateHeaders, runtime: $Util.RuntimeOptions): Promise<RegisterCallbackWithDelegateResponse> {
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
      action: "RegisterCallbackWithDelegate",
      version: "card_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/card/me/callbacks/register`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RegisterCallbackWithDelegateResponse>(await this.execute(params, req, runtime), new RegisterCallbackWithDelegateResponse({}));
  }

  /**
   * @summary 注册卡片回调地址
   *
   * @param request RegisterCallbackWithDelegateRequest
   * @return RegisterCallbackWithDelegateResponse
   */
  async registerCallbackWithDelegate(request: RegisterCallbackWithDelegateRequest): Promise<RegisterCallbackWithDelegateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterCallbackWithDelegateHeaders({ });
    return await this.registerCallbackWithDelegateWithOptions(request, headers, runtime);
  }

  /**
   * @summary AI互动卡片流式更新
   *
   * @param request StreamingUpdateRequest
   * @param headers StreamingUpdateHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return StreamingUpdateResponse
   */
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

  /**
   * @summary AI互动卡片流式更新
   *
   * @param request StreamingUpdateRequest
   * @return StreamingUpdateResponse
   */
  async streamingUpdate(request: StreamingUpdateRequest): Promise<StreamingUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StreamingUpdateHeaders({ });
    return await this.streamingUpdateWithOptions(request, headers, runtime);
  }

  /**
   * @summary 更新卡片
   *
   * @param request UpdateCardRequest
   * @param headers UpdateCardHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return UpdateCardResponse
   */
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

  /**
   * @summary 更新卡片
   *
   * @param request UpdateCardRequest
   * @return UpdateCardResponse
   */
  async updateCard(request: UpdateCardRequest): Promise<UpdateCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCardHeaders({ });
    return await this.updateCardWithOptions(request, headers, runtime);
  }

  /**
   * @summary 更新卡片
   *
   * @param request UpdateCardWithDelegateRequest
   * @param headers UpdateCardWithDelegateHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return UpdateCardWithDelegateResponse
   */
  async updateCardWithDelegateWithOptions(request: UpdateCardWithDelegateRequest, headers: UpdateCardWithDelegateHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateCardWithDelegateResponse> {
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
      action: "UpdateCardWithDelegate",
      version: "card_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/card/me/instances`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateCardWithDelegateResponse>(await this.execute(params, req, runtime), new UpdateCardWithDelegateResponse({}));
  }

  /**
   * @summary 更新卡片
   *
   * @param request UpdateCardWithDelegateRequest
   * @return UpdateCardWithDelegateResponse
   */
  async updateCardWithDelegate(request: UpdateCardWithDelegateRequest): Promise<UpdateCardWithDelegateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateCardWithDelegateHeaders({ });
    return await this.updateCardWithDelegateWithOptions(request, headers, runtime);
  }

}
