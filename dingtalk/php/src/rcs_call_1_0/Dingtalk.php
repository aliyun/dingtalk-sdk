<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrcs_call_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vrcs_call_1_0\Models\RunCallUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrcs_call_1_0\Models\RunCallUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vrcs_call_1_0\Models\RunCallUserResponse;
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
     * @param RunCallUserRequest $request
     *
     * @return RunCallUserResponse
     */
    public function runCallUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RunCallUserHeaders([]);

        return $this->runCallUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RunCallUserRequest $request
     * @param RunCallUserHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return RunCallUserResponse
     */
    public function runCallUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->authorizeCorpId)) {
            @$query['authorizeCorpId'] = $request->authorizeCorpId;
        }
        if (!Utils::isUnset($request->authorizeUserId)) {
            @$query['authorizeUserId'] = $request->authorizeUserId;
        }
        if (!Utils::isUnset($request->orderId)) {
            @$query['orderId'] = $request->orderId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return RunCallUserResponse::fromMap($this->doROARequest('RunCallUser', 'rcsCall_1.0', 'HTTP', 'POST', 'AK', '/v1.0/rcsCall/users/call', 'json', $req, $runtime));
    }
}
