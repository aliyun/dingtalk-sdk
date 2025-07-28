<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmeter_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vmeter_1_0\Models\GetResourceUseInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmeter_1_0\Models\GetResourceUseInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vmeter_1_0\Models\GetResourceUseInfoResponse;
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
     * @summary 获取开放平台当月资源用量
     *  *
     * @param GetResourceUseInfoRequest $request GetResourceUseInfoRequest
     * @param GetResourceUseInfoHeaders $headers GetResourceUseInfoHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetResourceUseInfoResponse GetResourceUseInfoResponse
     */
    public function getResourceUseInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->benefitCodeList)) {
            $body['benefitCodeList'] = $request->benefitCodeList;
        }
        if (!Utils::isUnset($request->period)) {
            $body['period'] = $request->period;
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
            'action' => 'GetResourceUseInfo',
            'version' => 'meter_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/meter/resources/useInfos/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetResourceUseInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取开放平台当月资源用量
     *  *
     * @param GetResourceUseInfoRequest $request GetResourceUseInfoRequest
     *
     * @return GetResourceUseInfoResponse GetResourceUseInfoResponse
     */
    public function getResourceUseInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetResourceUseInfoHeaders([]);

        return $this->getResourceUseInfoWithOptions($request, $headers, $runtime);
    }
}
