<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voccupationauth_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Voccupationauth_1_0\Models\CheckUserTaskStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Voccupationauth_1_0\Models\CheckUserTaskStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Voccupationauth_1_0\Models\CheckUserTaskStatusResponse;
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
     * @param CheckUserTaskStatusRequest $request
     *
     * @return CheckUserTaskStatusResponse
     */
    public function checkUserTaskStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckUserTaskStatusHeaders([]);

        return $this->checkUserTaskStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CheckUserTaskStatusRequest $request
     * @param CheckUserTaskStatusHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return CheckUserTaskStatusResponse
     */
    public function checkUserTaskStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->provinceCode)) {
            @$body['provinceCode'] = $request->provinceCode;
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

        return CheckUserTaskStatusResponse::fromMap($this->doROARequest('CheckUserTaskStatus', 'occupationauth_1.0', 'HTTP', 'POST', 'AK', '/v1.0/occupationauth/auths/userTasks', 'json', $req, $runtime));
    }
}
