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

export class SendLiveActivityHeaders extends $tea.Model {
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

export class SendLiveActivityRequest extends $tea.Model {
  activityEventData?: SendLiveActivityRequestActivityEventData;
  activityEventOption?: SendLiveActivityRequestActivityEventOption;
  activityId?: string;
  static names(): { [key: string]: string } {
    return {
      activityEventData: 'activityEventData',
      activityEventOption: 'activityEventOption',
      activityId: 'activityId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityEventData: SendLiveActivityRequestActivityEventData,
      activityEventOption: SendLiveActivityRequestActivityEventOption,
      activityId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendLiveActivityResponseBody extends $tea.Model {
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

export class SendLiveActivityResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SendLiveActivityResponseBody;
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
      body: SendLiveActivityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendLiveActivityRequestActivityEventData extends $tea.Model {
  i18nContentState?: any;
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      i18nContentState: 'i18nContentState',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      i18nContentState: 'any',
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendLiveActivityRequestActivityEventOption extends $tea.Model {
  dismissalDate?: number;
  pushType?: string;
  sendDate?: number;
  staleDate?: number;
  static names(): { [key: string]: string } {
    return {
      dismissalDate: 'dismissalDate',
      pushType: 'pushType',
      sendDate: 'sendDate',
      staleDate: 'staleDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dismissalDate: 'number',
      pushType: 'string',
      sendDate: 'number',
      staleDate: 'number',
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


  async sendLiveActivityWithOptions(request: SendLiveActivityRequest, headers: SendLiveActivityHeaders, runtime: $Util.RuntimeOptions): Promise<SendLiveActivityResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.activityEventData)) {
      body["activityEventData"] = request.activityEventData;
    }

    if (!Util.isUnset(request.activityEventOption)) {
      body["activityEventOption"] = request.activityEventOption;
    }

    if (!Util.isUnset(request.activityId)) {
      body["activityId"] = request.activityId;
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
      action: "SendLiveActivity",
      version: "liveActivities_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/liveActivities/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendLiveActivityResponse>(await this.execute(params, req, runtime), new SendLiveActivityResponse({}));
  }

  async sendLiveActivity(request: SendLiveActivityRequest): Promise<SendLiveActivityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendLiveActivityHeaders({ });
    return await this.sendLiveActivityWithOptions(request, headers, runtime);
  }

}
