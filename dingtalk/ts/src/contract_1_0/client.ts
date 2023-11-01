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

export class ContractBenefitConsumeHeaders extends $tea.Model {
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

export class ContractBenefitConsumeRequest extends $tea.Model {
  benefitPoint?: string;
  bizRequestId?: string;
  consumeQuota?: number;
  corpId?: string;
  extParams?: { [key: string]: string };
  isvCorpId?: string;
  optUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      benefitPoint: 'benefitPoint',
      bizRequestId: 'bizRequestId',
      consumeQuota: 'consumeQuota',
      corpId: 'corpId',
      extParams: 'extParams',
      isvCorpId: 'isvCorpId',
      optUnionId: 'optUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      benefitPoint: 'string',
      bizRequestId: 'string',
      consumeQuota: 'number',
      corpId: 'string',
      extParams: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      isvCorpId: 'string',
      optUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ContractBenefitConsumeResponseBody extends $tea.Model {
  result?: ContractBenefitConsumeResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ContractBenefitConsumeResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ContractBenefitConsumeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ContractBenefitConsumeResponseBody;
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
      body: ContractBenefitConsumeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignQueryGrantInfoHeaders extends $tea.Model {
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

export class EsignQueryGrantInfoRequest extends $tea.Model {
  corpId?: string;
  extension?: { [key: string]: string };
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      extension: 'extension',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignQueryGrantInfoResponseBody extends $tea.Model {
  result?: EsignQueryGrantInfoResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: EsignQueryGrantInfoResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignQueryGrantInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EsignQueryGrantInfoResponseBody;
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
      body: EsignQueryGrantInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignQueryIdentityByTicketHeaders extends $tea.Model {
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

export class EsignQueryIdentityByTicketRequest extends $tea.Model {
  corpId?: string;
  extension?: { [key: string]: string };
  ticket?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      extension: 'extension',
      ticket: 'ticket',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      ticket: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignQueryIdentityByTicketResponseBody extends $tea.Model {
  result?: EsignQueryIdentityByTicketResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: EsignQueryIdentityByTicketResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignQueryIdentityByTicketResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EsignQueryIdentityByTicketResponseBody;
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
      body: EsignQueryIdentityByTicketResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignSyncEventHeaders extends $tea.Model {
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

export class EsignSyncEventRequest extends $tea.Model {
  action?: string;
  corpId?: string;
  esignData?: string;
  extension?: { [key: string]: string };
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      corpId: 'corpId',
      esignData: 'esignData',
      extension: 'extension',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      corpId: 'string',
      esignData: 'string',
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignSyncEventResponseBody extends $tea.Model {
  result?: EsignSyncEventResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: EsignSyncEventResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignSyncEventResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: EsignSyncEventResponseBody;
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
      body: EsignSyncEventResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAdvancedContractVersionHeaders extends $tea.Model {
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

export class QueryAdvancedContractVersionRequest extends $tea.Model {
  corpId?: string;
  extension?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      extension: 'extension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAdvancedContractVersionResponseBody extends $tea.Model {
  result?: QueryAdvancedContractVersionResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryAdvancedContractVersionResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAdvancedContractVersionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryAdvancedContractVersionResponseBody;
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
      body: QueryAdvancedContractVersionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  statusCode: number;
  body: SendContractCardResponseBody;
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
      body: SendContractCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ContractBenefitConsumeResponseBodyResult extends $tea.Model {
  consumeResult?: boolean;
  static names(): { [key: string]: string } {
    return {
      consumeResult: 'consumeResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      consumeResult: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignQueryGrantInfoResponseBodyResult extends $tea.Model {
  legalPerson?: string;
  mobilePhoneNumber?: string;
  orgName?: string;
  stateCode?: string;
  unifiedSocialCredit?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      legalPerson: 'legalPerson',
      mobilePhoneNumber: 'mobilePhoneNumber',
      orgName: 'orgName',
      stateCode: 'stateCode',
      unifiedSocialCredit: 'unifiedSocialCredit',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      legalPerson: 'string',
      mobilePhoneNumber: 'string',
      orgName: 'string',
      stateCode: 'string',
      unifiedSocialCredit: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignQueryIdentityByTicketResponseBodyResult extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignSyncEventResponseBodyResult extends $tea.Model {
  message?: string;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAdvancedContractVersionResponseBodyResult extends $tea.Model {
  enableEsignAttachmentSign?: boolean;
  extension?: { [key: string]: string };
  version?: string;
  static names(): { [key: string]: string } {
    return {
      enableEsignAttachmentSign: 'enableEsignAttachmentSign',
      extension: 'extension',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enableEsignAttachmentSign: 'boolean',
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      version: 'string',
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


  async contractBenefitConsumeWithOptions(request: ContractBenefitConsumeRequest, headers: ContractBenefitConsumeHeaders, runtime: $Util.RuntimeOptions): Promise<ContractBenefitConsumeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.benefitPoint)) {
      body["benefitPoint"] = request.benefitPoint;
    }

    if (!Util.isUnset(request.bizRequestId)) {
      body["bizRequestId"] = request.bizRequestId;
    }

    if (!Util.isUnset(request.consumeQuota)) {
      body["consumeQuota"] = request.consumeQuota;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.extParams)) {
      body["extParams"] = request.extParams;
    }

    if (!Util.isUnset(request.isvCorpId)) {
      body["isvCorpId"] = request.isvCorpId;
    }

    if (!Util.isUnset(request.optUnionId)) {
      body["optUnionId"] = request.optUnionId;
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
      action: "ContractBenefitConsume",
      version: "contract_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contract/benefits/consume`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ContractBenefitConsumeResponse>(await this.execute(params, req, runtime), new ContractBenefitConsumeResponse({}));
  }

  async contractBenefitConsume(request: ContractBenefitConsumeRequest): Promise<ContractBenefitConsumeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ContractBenefitConsumeHeaders({ });
    return await this.contractBenefitConsumeWithOptions(request, headers, runtime);
  }

  async esignQueryGrantInfoWithOptions(request: EsignQueryGrantInfoRequest, headers: EsignQueryGrantInfoHeaders, runtime: $Util.RuntimeOptions): Promise<EsignQueryGrantInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.extension)) {
      body["extension"] = request.extension;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "EsignQueryGrantInfo",
      version: "contract_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contract/esign/anthInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EsignQueryGrantInfoResponse>(await this.execute(params, req, runtime), new EsignQueryGrantInfoResponse({}));
  }

  async esignQueryGrantInfo(request: EsignQueryGrantInfoRequest): Promise<EsignQueryGrantInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EsignQueryGrantInfoHeaders({ });
    return await this.esignQueryGrantInfoWithOptions(request, headers, runtime);
  }

  async esignQueryIdentityByTicketWithOptions(request: EsignQueryIdentityByTicketRequest, headers: EsignQueryIdentityByTicketHeaders, runtime: $Util.RuntimeOptions): Promise<EsignQueryIdentityByTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.extension)) {
      body["extension"] = request.extension;
    }

    if (!Util.isUnset(request.ticket)) {
      body["ticket"] = request.ticket;
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
      action: "EsignQueryIdentityByTicket",
      version: "contract_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contract/esign/tickets/identities/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EsignQueryIdentityByTicketResponse>(await this.execute(params, req, runtime), new EsignQueryIdentityByTicketResponse({}));
  }

  async esignQueryIdentityByTicket(request: EsignQueryIdentityByTicketRequest): Promise<EsignQueryIdentityByTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EsignQueryIdentityByTicketHeaders({ });
    return await this.esignQueryIdentityByTicketWithOptions(request, headers, runtime);
  }

  async esignSyncEventWithOptions(request: EsignSyncEventRequest, headers: EsignSyncEventHeaders, runtime: $Util.RuntimeOptions): Promise<EsignSyncEventResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.esignData)) {
      body["esignData"] = request.esignData;
    }

    if (!Util.isUnset(request.extension)) {
      body["extension"] = request.extension;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "EsignSyncEvent",
      version: "contract_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contract/esign/events/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EsignSyncEventResponse>(await this.execute(params, req, runtime), new EsignSyncEventResponse({}));
  }

  async esignSyncEvent(request: EsignSyncEventRequest): Promise<EsignSyncEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EsignSyncEventHeaders({ });
    return await this.esignSyncEventWithOptions(request, headers, runtime);
  }

  async queryAdvancedContractVersionWithOptions(request: QueryAdvancedContractVersionRequest, headers: QueryAdvancedContractVersionHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAdvancedContractVersionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.extension)) {
      body["extension"] = request.extension;
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
      action: "QueryAdvancedContractVersion",
      version: "contract_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contract/versions/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAdvancedContractVersionResponse>(await this.execute(params, req, runtime), new QueryAdvancedContractVersionResponse({}));
  }

  async queryAdvancedContractVersion(request: QueryAdvancedContractVersionRequest): Promise<QueryAdvancedContractVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAdvancedContractVersionHeaders({ });
    return await this.queryAdvancedContractVersionWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "SendContractCard",
      version: "contract_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contract/cards/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendContractCardResponse>(await this.execute(params, req, runtime), new SendContractCardResponse({}));
  }

  async sendContractCard(request: SendContractCardRequest): Promise<SendContractCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendContractCardHeaders({ });
    return await this.sendContractCardWithOptions(request, headers, runtime);
  }

}
