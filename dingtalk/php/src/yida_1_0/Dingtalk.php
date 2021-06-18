<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\LoginCodeGenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\LoginCodeGenRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\LoginCodeGenResponse;
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
     * @param LoginCodeGenRequest $request
     *
     * @return LoginCodeGenResponse
     */
    public function loginCodeGen($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LoginCodeGenHeaders([]);

        return $this->loginCodeGenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param LoginCodeGenRequest $request
     * @param LoginCodeGenHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return LoginCodeGenResponse
     */
    public function loginCodeGenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
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

        return LoginCodeGenResponse::fromMap($this->doROARequest('LoginCodeGen', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/authorizations/loginCodes', 'json', $req, $runtime));
    }
}
