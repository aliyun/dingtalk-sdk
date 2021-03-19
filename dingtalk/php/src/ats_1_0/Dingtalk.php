<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetJobAuthHeaders;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetJobAuthRequest;
use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\GetJobAuthResponse;
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
     * @param string            $jobId
     * @param GetJobAuthRequest $request
     *
     * @return GetJobAuthResponse
     */
    public function getJobAuth($jobId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetJobAuthHeaders([]);

        return $this->getJobAuthWithOptions($jobId, $request, $headers, $runtime);
    }

    /**
     * @param string            $jobId
     * @param GetJobAuthRequest $request
     * @param GetJobAuthHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return GetJobAuthResponse
     */
    public function getJobAuthWithOptions($jobId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            @$query['opUserId'] = $request->opUserId;
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

        return GetJobAuthResponse::fromMap($this->doROARequest('GetJobAuth', 'ats_1.0', 'HTTP', 'GET', 'AK', '/v1.0/ats/auths/jobs/' . $jobId . '', 'json', $req, $runtime));
    }
}
