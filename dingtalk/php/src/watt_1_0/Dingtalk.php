<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwatt_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\CheckInCrowdsByMobileRequest;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\CheckInCrowdsByMobileResponse;
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
            @$query['crowdIds'] = $request->crowdIds;
        }
        if (!Utils::isUnset($request->mobile)) {
            @$query['mobile'] = $request->mobile;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return CheckInCrowdsByMobileResponse::fromMap($this->doROARequest('CheckInCrowdsByMobile', 'watt_1.0', 'HTTP', 'POST', 'AK', '/v1.0/watt/crowdIdentifications/query', 'json', $req, $runtime));
    }
}
