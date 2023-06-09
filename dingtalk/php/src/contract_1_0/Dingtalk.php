<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryGrantInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryGrantInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryGrantInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryIdentityByTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryIdentityByTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryIdentityByTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignSyncEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignSyncEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignSyncEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\SendContractCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\SendContractCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\SendContractCardResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client as DarabonbaGatewayDingTalkClient;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    protected $_client;

    public function __construct($config)
    {
        parent::__construct($config);
        $this->_client       = new DarabonbaGatewayDingTalkClient();
        $this->_spi          = $this->_client;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param EsignQueryGrantInfoRequest $request
     * @param EsignQueryGrantInfoHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return EsignQueryGrantInfoResponse
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
     * @param EsignQueryGrantInfoRequest $request
     *
     * @return EsignQueryGrantInfoResponse
     */
    public function esignQueryGrantInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EsignQueryGrantInfoHeaders([]);

        return $this->esignQueryGrantInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EsignQueryIdentityByTicketRequest $request
     * @param EsignQueryIdentityByTicketHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return EsignQueryIdentityByTicketResponse
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
     * @param EsignQueryIdentityByTicketRequest $request
     *
     * @return EsignQueryIdentityByTicketResponse
     */
    public function esignQueryIdentityByTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EsignQueryIdentityByTicketHeaders([]);

        return $this->esignQueryIdentityByTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EsignSyncEventRequest $request
     * @param EsignSyncEventHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return EsignSyncEventResponse
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
     * @param EsignSyncEventRequest $request
     *
     * @return EsignSyncEventResponse
     */
    public function esignSyncEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EsignSyncEventHeaders([]);

        return $this->esignSyncEventWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendContractCardRequest $request
     * @param SendContractCardHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return SendContractCardResponse
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
     * @param SendContractCardRequest $request
     *
     * @return SendContractCardResponse
     */
    public function sendContractCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendContractCardHeaders([]);

        return $this->sendContractCardWithOptions($request, $headers, $runtime);
    }
}
