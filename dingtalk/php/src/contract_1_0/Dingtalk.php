<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\ContractBenefitConsumeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\ContractBenefitConsumeRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\ContractBenefitConsumeResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryApprovalInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryApprovalInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryApprovalInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryGrantInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryGrantInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryGrantInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryIdentityByTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryIdentityByTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryIdentityByTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignSyncEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignSyncEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignSyncEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\FinishReviewOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\FinishReviewOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\FinishReviewOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryAdvancedContractVersionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryAdvancedContractVersionRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryAdvancedContractVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\SendContractCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\SendContractCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\SendContractCardResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 合同权益核销
     *  *
     * @param ContractBenefitConsumeRequest $request ContractBenefitConsumeRequest
     * @param ContractBenefitConsumeHeaders $headers ContractBenefitConsumeHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return ContractBenefitConsumeResponse ContractBenefitConsumeResponse
     */
    public function contractBenefitConsumeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->benefitPoint)) {
            $body['benefitPoint'] = $request->benefitPoint;
        }
        if (!Utils::isUnset($request->bizRequestId)) {
            $body['bizRequestId'] = $request->bizRequestId;
        }
        if (!Utils::isUnset($request->consumeQuota)) {
            $body['consumeQuota'] = $request->consumeQuota;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extParams)) {
            $body['extParams'] = $request->extParams;
        }
        if (!Utils::isUnset($request->isvCorpId)) {
            $body['isvCorpId'] = $request->isvCorpId;
        }
        if (!Utils::isUnset($request->optUnionId)) {
            $body['optUnionId'] = $request->optUnionId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ContractBenefitConsume',
            'version'     => 'contract_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contract/benefits/consume',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ContractBenefitConsumeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 合同权益核销
     *  *
     * @param ContractBenefitConsumeRequest $request ContractBenefitConsumeRequest
     *
     * @return ContractBenefitConsumeResponse ContractBenefitConsumeResponse
     */
    public function contractBenefitConsume($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ContractBenefitConsumeHeaders([]);

        return $this->contractBenefitConsumeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 天谷侧查询审批单
     *  *
     * @param EsignQueryApprovalInfoRequest $request EsignQueryApprovalInfoRequest
     * @param EsignQueryApprovalInfoHeaders $headers EsignQueryApprovalInfoHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return EsignQueryApprovalInfoResponse EsignQueryApprovalInfoResponse
     */
    public function esignQueryApprovalInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->esignFlowId)) {
            $body['esignFlowId'] = $request->esignFlowId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'EsignQueryApprovalInfo',
            'version'     => 'contract_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contract/esign/approvalInfos/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EsignQueryApprovalInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 天谷侧查询审批单
     *  *
     * @param EsignQueryApprovalInfoRequest $request EsignQueryApprovalInfoRequest
     *
     * @return EsignQueryApprovalInfoResponse EsignQueryApprovalInfoResponse
     */
    public function esignQueryApprovalInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EsignQueryApprovalInfoHeaders([]);

        return $this->esignQueryApprovalInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 天谷侧查询授权信息接口
     *  *
     * @param EsignQueryGrantInfoRequest $request EsignQueryGrantInfoRequest
     * @param EsignQueryGrantInfoHeaders $headers EsignQueryGrantInfoHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return EsignQueryGrantInfoResponse EsignQueryGrantInfoResponse
     */
    public function esignQueryGrantInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'EsignQueryGrantInfo',
            'version'     => 'contract_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contract/esign/anthInfos/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EsignQueryGrantInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 天谷侧查询授权信息接口
     *  *
     * @param EsignQueryGrantInfoRequest $request EsignQueryGrantInfoRequest
     *
     * @return EsignQueryGrantInfoResponse EsignQueryGrantInfoResponse
     */
    public function esignQueryGrantInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EsignQueryGrantInfoHeaders([]);

        return $this->esignQueryGrantInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 天谷侧查询获取免登信息
     *  *
     * @param EsignQueryIdentityByTicketRequest $request EsignQueryIdentityByTicketRequest
     * @param EsignQueryIdentityByTicketHeaders $headers EsignQueryIdentityByTicketHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return EsignQueryIdentityByTicketResponse EsignQueryIdentityByTicketResponse
     */
    public function esignQueryIdentityByTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->ticket)) {
            $body['ticket'] = $request->ticket;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'EsignQueryIdentityByTicket',
            'version'     => 'contract_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contract/esign/tickets/identities/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EsignQueryIdentityByTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 天谷侧查询获取免登信息
     *  *
     * @param EsignQueryIdentityByTicketRequest $request EsignQueryIdentityByTicketRequest
     *
     * @return EsignQueryIdentityByTicketResponse EsignQueryIdentityByTicketResponse
     */
    public function esignQueryIdentityByTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EsignQueryIdentityByTicketHeaders([]);

        return $this->esignQueryIdentityByTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary e签宝电子签事件同步回传接口
     *  *
     * @param EsignSyncEventRequest $request EsignSyncEventRequest
     * @param EsignSyncEventHeaders $headers EsignSyncEventHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return EsignSyncEventResponse EsignSyncEventResponse
     */
    public function esignSyncEventWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->esignData)) {
            $body['esignData'] = $request->esignData;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'EsignSyncEvent',
            'version'     => 'contract_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contract/esign/events/sync',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EsignSyncEventResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary e签宝电子签事件同步回传接口
     *  *
     * @param EsignSyncEventRequest $request EsignSyncEventRequest
     *
     * @return EsignSyncEventResponse EsignSyncEventResponse
     */
    public function esignSyncEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EsignSyncEventHeaders([]);

        return $this->esignSyncEventWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 完成工单审查接口
     *  *
     * @param FinishReviewOrderRequest $request FinishReviewOrderRequest
     * @param FinishReviewOrderHeaders $headers FinishReviewOrderHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return FinishReviewOrderResponse FinishReviewOrderResponse
     */
    public function finishReviewOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->endFiles)) {
            $body['endFiles'] = $request->endFiles;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->orderId)) {
            $body['orderId'] = $request->orderId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'FinishReviewOrder',
            'version'     => 'contract_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contract/reviews/finish',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return FinishReviewOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 完成工单审查接口
     *  *
     * @param FinishReviewOrderRequest $request FinishReviewOrderRequest
     *
     * @return FinishReviewOrderResponse FinishReviewOrderResponse
     */
    public function finishReviewOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FinishReviewOrderHeaders([]);

        return $this->finishReviewOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary e签宝查询智能合同版本接口
     *  *
     * @param QueryAdvancedContractVersionRequest $request QueryAdvancedContractVersionRequest
     * @param QueryAdvancedContractVersionHeaders $headers QueryAdvancedContractVersionHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAdvancedContractVersionResponse QueryAdvancedContractVersionResponse
     */
    public function queryAdvancedContractVersionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'QueryAdvancedContractVersion',
            'version'     => 'contract_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contract/versions/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAdvancedContractVersionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary e签宝查询智能合同版本接口
     *  *
     * @param QueryAdvancedContractVersionRequest $request QueryAdvancedContractVersionRequest
     *
     * @return QueryAdvancedContractVersionResponse QueryAdvancedContractVersionResponse
     */
    public function queryAdvancedContractVersion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAdvancedContractVersionHeaders([]);

        return $this->queryAdvancedContractVersionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送合同相关卡片
     *  *
     * @param SendContractCardRequest $request SendContractCardRequest
     * @param SendContractCardHeaders $headers SendContractCardHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return SendContractCardResponse SendContractCardResponse
     */
    public function sendContractCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->cardType)) {
            $body['cardType'] = $request->cardType;
        }
        if (!Utils::isUnset($request->contractInfo)) {
            $body['contractInfo'] = $request->contractInfo;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->receiveGroups)) {
            $body['receiveGroups'] = $request->receiveGroups;
        }
        if (!Utils::isUnset($request->receivers)) {
            $body['receivers'] = $request->receivers;
        }
        if (!Utils::isUnset($request->sender)) {
            $body['sender'] = $request->sender;
        }
        if (!Utils::isUnset($request->syncSingleChat)) {
            $body['syncSingleChat'] = $request->syncSingleChat;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SendContractCard',
            'version'     => 'contract_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/contract/cards/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendContractCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送合同相关卡片
     *  *
     * @param SendContractCardRequest $request SendContractCardRequest
     *
     * @return SendContractCardResponse SendContractCardResponse
     */
    public function sendContractCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendContractCardHeaders([]);

        return $this->sendContractCardWithOptions($request, $headers, $runtime);
    }
}
