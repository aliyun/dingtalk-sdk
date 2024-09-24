<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrcs_call_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vrcs_call_1_0\Models\RunCallUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrcs_call_1_0\Models\RunCallUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vrcs_call_1_0\Models\RunCallUserResponse;
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
        $this->_productId    = 'dingtalk';
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 主叫方发起免费电话给授权企业人员，关联订单id
     *  *
     * @param RunCallUserRequest $request RunCallUserRequest
     * @param RunCallUserHeaders $headers RunCallUserHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return RunCallUserResponse RunCallUserResponse
     */
    public function runCallUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->authorizeCorpId)) {
            $query['authorizeCorpId'] = $request->authorizeCorpId;
        }
        if (!Utils::isUnset($request->authorizeUserId)) {
            $query['authorizeUserId'] = $request->authorizeUserId;
        }
        if (!Utils::isUnset($request->orderId)) {
            $query['orderId'] = $request->orderId;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'RunCallUser',
            'version'     => 'rcsCall_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/rcsCall/users/call',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RunCallUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 主叫方发起免费电话给授权企业人员，关联订单id
     *  *
     * @param RunCallUserRequest $request RunCallUserRequest
     *
     * @return RunCallUserResponse RunCallUserResponse
     */
    public function runCallUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RunCallUserHeaders([]);

        return $this->runCallUserWithOptions($request, $headers, $runtime);
    }
}
