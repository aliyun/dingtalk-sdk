<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwatt_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\CheckInCrowdsByMobileRequest;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\CheckInCrowdsByMobileResponse;
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
        $this->_client             = new DarabonbaGatewayDingTalkClient();
        $this->_spi                = $this->_client;
        $this->_signatureAlgorithm = 'v2';
        $this->_endpointRule       = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param CheckInCrowdsByMobileRequest $request
     * @param string[]                     $headers
     * @param RuntimeOptions               $runtime
     *
     * @return CheckInCrowdsByMobileResponse
     */
    public function checkInCrowdsByMobileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->crowdIds)) {
            $query['crowdIds'] = $request->crowdIds;
        }
        if (!Utils::isUnset($request->mobile)) {
            $query['mobile'] = $request->mobile;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'CheckInCrowdsByMobile',
            'version'     => 'watt_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/watt/crowdIdentifications/query',
            'method'      => 'POST',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CheckInCrowdsByMobileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CheckInCrowdsByMobileRequest $request
     *
     * @return CheckInCrowdsByMobileResponse
     */
    public function checkInCrowdsByMobile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->checkInCrowdsByMobileWithOptions($request, $headers, $runtime);
    }
}
