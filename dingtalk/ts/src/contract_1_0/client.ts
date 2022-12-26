// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class SendContractCardHeaders extends $tea.Model {
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

export class SendContractCardRequest extends $tea.Model {
  cardType?: string;
  contractInfo?: SendContractCardRequestContractInfo;
  corpId?: string;
  extension?: { [key: string]: string };
  processInstanceId?: string;
  receiveGroups?: string[];
  receivers?: SendContractCardRequestReceivers[];
  sender?: SendContractCardRequestSender;
  syncSingleChat?: boolean;
  static names(): { [key: string]: string } {
    return {
      cardType: 'cardType',
      contractInfo: 'contractInfo',
      corpId: 'corpId',
      extension: 'extension',
      processInstanceId: 'processInstanceId',
      receiveGroups: 'receiveGroups',
      receivers: 'receivers',
      sender: 'sender',
      syncSingleChat: 'syncSingleChat',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardType: 'string',
      contractInfo: SendContractCardRequestContractInfo,
      corpId: 'string',
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      processInstanceId: 'string',
      receiveGroups: { 'type': 'array', 'itemType': 'string' },
      receivers: { 'type': 'array', 'itemType': SendContractCardRequestReceivers },
      sender: SendContractCardRequestSender,
      syncSingleChat: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendContractCardResponseBody extends $tea.Model {
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

export class SendContractCardResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SendContractCardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SendContractCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendContractCardRequestContractInfo extends $tea.Model {
  contractCode?: string;
  contractName?: string;
  createTime?: number;
  signUserName?: string;
  static names(): { [key: string]: string } {
    return {
      contractCode: 'contractCode',
      contractName: 'contractName',
      createTime: 'createTime',
      signUserName: 'signUserName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contractCode: 'string',
      contractName: 'string',
      createTime: 'number',
      signUserName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendContractCardRequestReceivers extends $tea.Model {
  corpId?: string;
  userId?: string;
  userType?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      userId: 'userId',
      userType: 'userType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      userId: 'string',
      userType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendContractCardRequestSender extends $tea.Model {
  corpId?: string;
  userId?: string;
  userType?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      userId: 'userId',
      userType: 'userType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      userId: 'string',
      userType: 'string',
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


  async sendContractCard(request: SendContractCardRequest): Promise<SendContractCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendContractCardHeaders({ });
    return await this.sendContractCardWithOptions(request, headers, runtime);
  }

  async sendContractCardWithOptions(request: SendContractCardRequest, headers: SendContractCardHeaders, runtime: $Util.RuntimeOptions): Promise<SendContractCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cardType)) {
      body["cardType"] = request.cardType;
    }

    if (!Util.isUnset(request.contractInfo)) {
      body["contractInfo"] = request.contractInfo;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.extension)) {
      body["extension"] = request.extension;
    }

    if (!Util.isUnset(request.processInstanceId)) {
      body["processInstanceId"] = request.processInstanceId;
    }

    if (!Util.isUnset(request.receiveGroups)) {
      body["receiveGroups"] = request.receiveGroups;
    }

    if (!Util.isUnset(request.receivers)) {
      body["receivers"] = request.receivers;
    }

    if (!Util.isUnset(request.sender)) {
      body["sender"] = request.sender;
    }

    if (!Util.isUnset(request.syncSingleChat)) {
      body["syncSingleChat"] = request.syncSingleChat;
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
    return $tea.cast<SendContractCardResponse>(await this.doROARequest("SendContractCard", "contract_1.0", "HTTP", "POST", "AK", `/v1.0/contract/cards/send`, "json", req, runtime), new SendContractCardResponse({}));
  }

}
