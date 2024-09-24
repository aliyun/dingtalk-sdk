<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\RegisterCategorySourceConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\RegisterCategorySourceConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\RegisterCategorySourceConfigResponse;
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
     * @summary 注册应用类目信息
     *  *
     * @param RegisterCategorySourceConfigRequest $request RegisterCategorySourceConfigRequest
     * @param RegisterCategorySourceConfigHeaders $headers RegisterCategorySourceConfigHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return RegisterCategorySourceConfigResponse RegisterCategorySourceConfigResponse
     */
    public function registerCategorySourceConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCategoryId)) {
            $body['bizCategoryId'] = $request->bizCategoryId;
        }
        if (!Utils::isUnset($request->bizCategoryName)) {
            $body['bizCategoryName'] = $request->bizCategoryName;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RegisterCategorySourceConfig',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/apps/categories/sourceConfigs/register',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RegisterCategorySourceConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 注册应用类目信息
     *  *
     * @param RegisterCategorySourceConfigRequest $request RegisterCategorySourceConfigRequest
     *
     * @return RegisterCategorySourceConfigResponse RegisterCategorySourceConfigResponse
     */
    public function registerCategorySourceConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterCategorySourceConfigHeaders([]);

        return $this->registerCategorySourceConfigWithOptions($request, $headers, $runtime);
    }
}
