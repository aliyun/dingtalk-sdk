<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrcs_call_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vrcs_call_1_0\Models\RunCallUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrcs_call_1_0\Models\RunCallUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vrcs_call_1_0\Models\RunCallUserResponse;
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
        $this->_client       = new DarabonbaGatewayDingTalkClient();
        $this->_spi          = $this->_client;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
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
}
