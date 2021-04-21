<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\CreateTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\CreateTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\CreateTicketResponse;
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
     * @param CreateTicketRequest $request
     *
     * @return CreateTicketResponse
     */
    public function createTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTicketHeaders([]);

        return $this->createTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateTicketRequest $request
     * @param CreateTicketHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return CreateTicketResponse
     */
    public function createTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->sourceId)) {
            @$body['sourceId'] = $request->sourceId;
        }
        if (!Utils::isUnset($request->foreignId)) {
            @$body['foreignId'] = $request->foreignId;
        }
        if (!Utils::isUnset($request->foreignName)) {
            @$body['foreignName'] = $request->foreignName;
        }
        if (!Utils::isUnset($request->openInstanceId)) {
            @$body['openInstanceId'] = $request->openInstanceId;
        }
        if (!Utils::isUnset($request->productionType)) {
            @$body['productionType'] = $request->productionType;
        }
        if (!Utils::isUnset($request->templateId)) {
            @$body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->properties)) {
            @$body['properties'] = $request->properties;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateTicketResponse::fromMap($this->doROARequest('CreateTicket', 'customerService_1.0', 'HTTP', 'POST', 'AK', '/v1.0/customerService/tickets', 'json', $req, $runtime));
    }
}
