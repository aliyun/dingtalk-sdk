<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtre_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vtre_1_0\Models\CreateTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtre_1_0\Models\CreateTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vtre_1_0\Models\CreateTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vtre_1_0\Models\CreateTicketShrinkRequest;
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
        $gatewayClient = new Client();
        $this->_spi = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary TRE拉铃服务
     *  *
     * @param CreateTicketRequest $tmpReq  CreateTicketRequest
     * @param CreateTicketHeaders $headers CreateTicketHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTicketResponse CreateTicketResponse
     */
    public function createTicketWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new CreateTicketShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->reporters)) {
            $request->reportersShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->reporters, 'reporters', 'json');
        }
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->priority)) {
            $body['priority'] = $request->priority;
        }
        if (!Utils::isUnset($request->reportersShrink)) {
            $body['reporters'] = $request->reportersShrink;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateTicket',
            'version' => 'tre_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/tre/ticket',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary TRE拉铃服务
     *  *
     * @param CreateTicketRequest $request CreateTicketRequest
     *
     * @return CreateTicketResponse CreateTicketResponse
     */
    public function createTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTicketHeaders([]);

        return $this->createTicketWithOptions($request, $headers, $runtime);
    }
}
