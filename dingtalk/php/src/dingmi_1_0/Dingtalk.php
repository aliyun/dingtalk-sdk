<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\GetDingMeBaseDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\GetDingMeBaseDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models\GetDingMeBaseDataResponse;
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
     * @param GetDingMeBaseDataRequest $request
     *
     * @return GetDingMeBaseDataResponse
     */
    public function getDingMeBaseData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDingMeBaseDataHeaders([]);

        return $this->getDingMeBaseDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetDingMeBaseDataRequest $request
     * @param GetDingMeBaseDataHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetDingMeBaseDataResponse
     */
    public function getDingMeBaseDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appKey)) {
            @$query['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->startDay)) {
            @$query['startDay'] = $request->startDay;
        }
        if (!Utils::isUnset($request->endDay)) {
            @$query['endDay'] = $request->endDay;
        }
        if (!Utils::isUnset($request->byDay)) {
            @$query['byDay'] = $request->byDay;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetDingMeBaseDataResponse::fromMap($this->doROARequest('GetDingMeBaseData', 'dingmi_1.0', 'HTTP', 'GET', 'AK', '/v1.0/dingmi/robots/data', 'json', $req, $runtime));
    }
}
