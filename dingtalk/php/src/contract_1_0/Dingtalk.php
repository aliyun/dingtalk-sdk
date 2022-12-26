<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\SendContractCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\SendContractCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\SendContractCardResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
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
            @$body['cardType'] = $request->cardType;
        }
        if (!Utils::isUnset($request->contractInfo)) {
            @$body['contractInfo'] = $request->contractInfo;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extension)) {
            @$body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            @$body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->receiveGroups)) {
            @$body['receiveGroups'] = $request->receiveGroups;
        }
        if (!Utils::isUnset($request->receivers)) {
            @$body['receivers'] = $request->receivers;
        }
        if (!Utils::isUnset($request->sender)) {
            @$body['sender'] = $request->sender;
        }
        if (!Utils::isUnset($request->syncSingleChat)) {
            @$body['syncSingleChat'] = $request->syncSingleChat;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SendContractCardResponse::fromMap($this->doROARequest('SendContractCard', 'contract_1.0', 'HTTP', 'POST', 'AK', '/v1.0/contract/cards/send', 'json', $req, $runtime));
    }
}
