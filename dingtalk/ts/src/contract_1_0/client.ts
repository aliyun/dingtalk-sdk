// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * esign
   */
  benefitPoint?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sjdaujii129w9qej2nqas
   */
  bizRequestId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  consumeQuota?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding1231ndu29923312
   */
  corpId?: string;
  extParams?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding12939912nduaejjwe
   */
  isvCorpId?: string;
  /**
   * @example
   * djauihjauiwnkndjknkjanaae
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ContractBenefitConsumeResponseBody;
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

export class EsignQueryApprovalInfoHeaders extends $tea.Model {
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

export class EsignQueryApprovalInfoRequest extends $tea.Model {
  /**
   * @example
   * dingd0c871e2dfc941a34ac5d6980864d335
   */
  corpId?: string;
  /**
   * @example
   * 5556ae0359c64c4b9491c0c3c339341f
   */
  esignFlowId?: string;
  /**
   * @example
   * PbnhW6rVXRg8u6T4NiiOwwQiEiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      esignFlowId: 'esignFlowId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      esignFlowId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignQueryApprovalInfoResponseBody extends $tea.Model {
  result?: EsignQueryApprovalInfoResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: EsignQueryApprovalInfoResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignQueryApprovalInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: EsignQueryApprovalInfoResponseBody;
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
      body: EsignQueryApprovalInfoResponseBody,
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
  /**
   * @example
   * dingd0c871e2dfc941a34ac5d6980864d335
   */
  corpId?: string;
  extension?: { [key: string]: string };
  /**
   * @example
   * PbnhW6rVXRg8u6T4NiiOwwQiEiE
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: EsignQueryGrantInfoResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingd0c871e2dfc941a34ac5d6980864d335
   */
  corpId?: string;
  extension?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * feb4b8e5-d6d9-4d22-a6b8-c8e26823a73a
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: EsignQueryIdentityByTicketResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * openEsign
   */
  action?: string;
  /**
   * @example
   * dingd0c871e2dfc941a34ac5d6980864d335
   */
  corpId?: string;
  /**
   * @example
   * {"name": "名字"}
   */
  esignData?: string;
  extension?: { [key: string]: string };
  /**
   * @example
   * PbnhW6rVXRg8u6T4NiiOwwQiEiE
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: EsignSyncEventResponseBody;
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

export class FinishReviewOrderHeaders extends $tea.Model {
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

export class FinishReviewOrderRequest extends $tea.Model {
  endFiles?: FinishReviewOrderRequestEndFiles[];
  /**
   * @example
   * {}
   */
  extension?: string;
  /**
   * @example
   * 12345678
   */
  orderId?: string;
  static names(): { [key: string]: string } {
    return {
      endFiles: 'endFiles',
      extension: 'extension',
      orderId: 'orderId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endFiles: { 'type': 'array', 'itemType': FinishReviewOrderRequestEndFiles },
      extension: 'string',
      orderId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinishReviewOrderResponseBody extends $tea.Model {
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

export class FinishReviewOrderResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: FinishReviewOrderResponseBody;
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
      body: FinishReviewOrderResponseBody,
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
  /**
   * @example
   * dingff048f704a8b6d8e4ac5d6980864d335
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryAdvancedContractVersionResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * signing
   */
  cardType?: string;
  contractInfo?: SendContractCardRequestContractInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding5f62ac8a3c24952ebc961a6cb783455b
   */
  corpId?: string;
  extension?: { [key: string]: string };
  /**
   * @example
   * PROC_Xxxxxxxx
   */
  processInstanceId?: string;
  receiveGroups?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  receivers?: SendContractCardRequestReceivers[];
  /**
   * @remarks
   * This parameter is required.
   */
  sender?: SendContractCardRequestSender;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendContractCardResponseBody;
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

export class EsignQueryApprovalInfoResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 202311081619000455501
   */
  bpmsProcessBusinessId?: string;
  /**
   * @example
   * O6wNhB4wTMajvNW8Dc_Rjg09301699431585
   */
  bpmsProcessInstanceId?: string;
  /**
   * @example
   * https://aflow.dingtalk.com/dingtalk/pc/query/pchomepage.htm?corpid=ding6c3948a9e37c439c35c2f4657eb6378f&swfrom=https://n.dingtalk.com/dingding/h5-contract/contractPC/index.html#/approval?procInstId=O6wNhB4wTMajvNW8Dc_Rjg09301699431585
   */
  bpmsProcessInstanceUrl?: string;
  static names(): { [key: string]: string } {
    return {
      bpmsProcessBusinessId: 'bpmsProcessBusinessId',
      bpmsProcessInstanceId: 'bpmsProcessInstanceId',
      bpmsProcessInstanceUrl: 'bpmsProcessInstanceUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bpmsProcessBusinessId: 'string',
      bpmsProcessInstanceId: 'string',
      bpmsProcessInstanceUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignQueryGrantInfoResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 何一兵
   */
  legalPerson?: string;
  /**
   * @example
   * 18667021101
   */
  mobilePhoneNumber?: string;
  /**
   * @example
   * 杭州天谷信息科技有限公司
   */
  orgName?: string;
  /**
   * @example
   * 86
   */
  stateCode?: string;
  /**
   * @example
   * 913301087458306077
   */
  unifiedSocialCredit?: string;
  /**
   * @example
   * 某人名
   */
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
  /**
   * @example
   * 外部服务异常
   */
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

export class FinishReviewOrderRequestEndFiles extends $tea.Model {
  /**
   * @example
   * 合同文件
   */
  fileName?: string;
  /**
   * @example
   * 12
   */
  fileSize?: string;
  /**
   * @example
   * word
   */
  fileType?: string;
  /**
   * @example
   * 0
   */
  fileVersion?: number;
  /**
   * @example
   * http://oss.com
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      fileSize: 'fileSize',
      fileType: 'fileType',
      fileVersion: 'fileVersion',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      fileSize: 'string',
      fileType: 'string',
      fileVersion: 'number',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAdvancedContractVersionResponseBodyResult extends $tea.Model {
  enableEsignAttachmentSign?: boolean;
  extension?: { [key: string]: string };
  /**
   * @example
   * advanced
   */
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
  /**
   * @example
   * HT_xxxxxxx
   */
  contractCode?: string;
  /**
   * @example
   * 合同
   */
  contractName?: string;
  /**
   * @example
   * 1242153453
   */
  createTime?: number;
  /**
   * @example
   * 张三
   */
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
  /**
   * @example
   * ding5f62ac8a3c24952ebc961a6cb783455b
   */
  corpId?: string;
  /**
   * @example
   * 1622265907855672
   */
  userId?: string;
  /**
   * @example
   * 可以为空
   */
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
  /**
   * @example
   * ding5f62ac8a3c24952ebc961a6cb783455b
   */
  corpId?: string;
  /**
   * @example
   * 1622265907855672
   */
  userId?: string;
  /**
   * @example
   * 可以为空
   */
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
    let gatewayClient = new GatewayClient();
    this._spi = gatewayClient;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * 合同权益核销
   * 
   * @param request - ContractBenefitConsumeRequest
   * @param headers - ContractBenefitConsumeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ContractBenefitConsumeResponse
   */
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

  /**
   * 合同权益核销
   * 
   * @param request - ContractBenefitConsumeRequest
   * @returns ContractBenefitConsumeResponse
   */
  async contractBenefitConsume(request: ContractBenefitConsumeRequest): Promise<ContractBenefitConsumeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ContractBenefitConsumeHeaders({ });
    return await this.contractBenefitConsumeWithOptions(request, headers, runtime);
  }

  /**
   * 天谷侧查询审批单
   * 
   * @param request - EsignQueryApprovalInfoRequest
   * @param headers - EsignQueryApprovalInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns EsignQueryApprovalInfoResponse
   */
  async esignQueryApprovalInfoWithOptions(request: EsignQueryApprovalInfoRequest, headers: EsignQueryApprovalInfoHeaders, runtime: $Util.RuntimeOptions): Promise<EsignQueryApprovalInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.esignFlowId)) {
      body["esignFlowId"] = request.esignFlowId;
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
      action: "EsignQueryApprovalInfo",
      version: "contract_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contract/esign/approvalInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EsignQueryApprovalInfoResponse>(await this.execute(params, req, runtime), new EsignQueryApprovalInfoResponse({}));
  }

  /**
   * 天谷侧查询审批单
   * 
   * @param request - EsignQueryApprovalInfoRequest
   * @returns EsignQueryApprovalInfoResponse
   */
  async esignQueryApprovalInfo(request: EsignQueryApprovalInfoRequest): Promise<EsignQueryApprovalInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EsignQueryApprovalInfoHeaders({ });
    return await this.esignQueryApprovalInfoWithOptions(request, headers, runtime);
  }

  /**
   * 天谷侧查询授权信息接口
   * 
   * @param request - EsignQueryGrantInfoRequest
   * @param headers - EsignQueryGrantInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns EsignQueryGrantInfoResponse
   */
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

  /**
   * 天谷侧查询授权信息接口
   * 
   * @param request - EsignQueryGrantInfoRequest
   * @returns EsignQueryGrantInfoResponse
   */
  async esignQueryGrantInfo(request: EsignQueryGrantInfoRequest): Promise<EsignQueryGrantInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EsignQueryGrantInfoHeaders({ });
    return await this.esignQueryGrantInfoWithOptions(request, headers, runtime);
  }

  /**
   * 天谷侧查询获取免登信息
   * 
   * @param request - EsignQueryIdentityByTicketRequest
   * @param headers - EsignQueryIdentityByTicketHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns EsignQueryIdentityByTicketResponse
   */
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

  /**
   * 天谷侧查询获取免登信息
   * 
   * @param request - EsignQueryIdentityByTicketRequest
   * @returns EsignQueryIdentityByTicketResponse
   */
  async esignQueryIdentityByTicket(request: EsignQueryIdentityByTicketRequest): Promise<EsignQueryIdentityByTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EsignQueryIdentityByTicketHeaders({ });
    return await this.esignQueryIdentityByTicketWithOptions(request, headers, runtime);
  }

  /**
   * e签宝电子签事件同步回传接口
   * 
   * @param request - EsignSyncEventRequest
   * @param headers - EsignSyncEventHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns EsignSyncEventResponse
   */
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

  /**
   * e签宝电子签事件同步回传接口
   * 
   * @param request - EsignSyncEventRequest
   * @returns EsignSyncEventResponse
   */
  async esignSyncEvent(request: EsignSyncEventRequest): Promise<EsignSyncEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EsignSyncEventHeaders({ });
    return await this.esignSyncEventWithOptions(request, headers, runtime);
  }

  /**
   * 完成工单审查接口
   * 
   * @param request - FinishReviewOrderRequest
   * @param headers - FinishReviewOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns FinishReviewOrderResponse
   */
  async finishReviewOrderWithOptions(request: FinishReviewOrderRequest, headers: FinishReviewOrderHeaders, runtime: $Util.RuntimeOptions): Promise<FinishReviewOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endFiles)) {
      body["endFiles"] = request.endFiles;
    }

    if (!Util.isUnset(request.extension)) {
      body["extension"] = request.extension;
    }

    if (!Util.isUnset(request.orderId)) {
      body["orderId"] = request.orderId;
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
      action: "FinishReviewOrder",
      version: "contract_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/contract/reviews/finish`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<FinishReviewOrderResponse>(await this.execute(params, req, runtime), new FinishReviewOrderResponse({}));
  }

  /**
   * 完成工单审查接口
   * 
   * @param request - FinishReviewOrderRequest
   * @returns FinishReviewOrderResponse
   */
  async finishReviewOrder(request: FinishReviewOrderRequest): Promise<FinishReviewOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FinishReviewOrderHeaders({ });
    return await this.finishReviewOrderWithOptions(request, headers, runtime);
  }

  /**
   * e签宝查询智能合同版本接口
   * 
   * @param request - QueryAdvancedContractVersionRequest
   * @param headers - QueryAdvancedContractVersionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryAdvancedContractVersionResponse
   */
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

  /**
   * e签宝查询智能合同版本接口
   * 
   * @param request - QueryAdvancedContractVersionRequest
   * @returns QueryAdvancedContractVersionResponse
   */
  async queryAdvancedContractVersion(request: QueryAdvancedContractVersionRequest): Promise<QueryAdvancedContractVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAdvancedContractVersionHeaders({ });
    return await this.queryAdvancedContractVersionWithOptions(request, headers, runtime);
  }

  /**
   * 发送合同相关卡片
   * 
   * @param request - SendContractCardRequest
   * @param headers - SendContractCardHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendContractCardResponse
   */
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

  /**
   * 发送合同相关卡片
   * 
   * @param request - SendContractCardRequest
   * @returns SendContractCardResponse
   */
  async sendContractCard(request: SendContractCardRequest): Promise<SendContractCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendContractCardHeaders({ });
    return await this.sendContractCardWithOptions(request, headers, runtime);
  }

}
