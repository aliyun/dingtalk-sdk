<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_1_0\Models\CustomeRpcCallRequest;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_1_0\Models\CustomeRpcCallResponse;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_1_0\Models\CustomeRpcCallShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_1_0\Models\ProjectSetupResponse;
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
        $this->_signatureAlgorithm = 'v2';
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 大客户ltcPRC接口调用
     *  *
     * @param CustomeRpcCallRequest $tmpReq  CustomeRpcCallRequest
     * @param string[]              $headers map
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CustomeRpcCallResponse CustomeRpcCallResponse
     */
    public function customeRpcCallWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new CustomeRpcCallShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->params)) {
            $request->paramsShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->params, 'params', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->methodName)) {
            $query['methodName'] = $request->methodName;
        }
        if (!Utils::isUnset($request->paramsShrink)) {
            $query['params'] = $request->paramsShrink;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'CustomeRpcCall',
            'version' => 'customer_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/customer/rpcCall',
            'method' => 'POST',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CustomeRpcCallResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 大客户ltcPRC接口调用
     *  *
     * @param CustomeRpcCallRequest $request CustomeRpcCallRequest
     *
     * @return CustomeRpcCallResponse CustomeRpcCallResponse
     */
    public function customeRpcCall($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->customeRpcCallWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 直签立项审批
     *  *
     * @param string[]       $headers map
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return ProjectSetupResponse ProjectSetupResponse
     */
    public function projectSetupWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action' => 'ProjectSetup',
            'version' => 'customer_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/customer/project/setup',
            'method' => 'POST',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ProjectSetupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 直签立项审批
     *  *
     * @return ProjectSetupResponse ProjectSetupResponse
     */
    public function projectSetup()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->projectSetupWithOptions($headers, $runtime);
    }
}
