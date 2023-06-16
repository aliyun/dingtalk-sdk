<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vding_phone_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vding_phone_1_0\Models\AddCallConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vding_phone_1_0\Models\AddCallConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vding_phone_1_0\Models\AddCallConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vding_phone_1_0\Models\DelCallConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vding_phone_1_0\Models\DelCallConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vding_phone_1_0\Models\DelCallConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vding_phone_1_0\Models\QueryCallConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vding_phone_1_0\Models\QueryCallConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vding_phone_1_0\Models\QueryCallConfigResponse;
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
     * @param AddCallConfigRequest $request
     * @param AddCallConfigHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return AddCallConfigResponse
     */
    public function addCallConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvToken)) {
            $query['isvToken'] = $request->isvToken;
        }
        if (!Utils::isUnset($request->phoneNumber)) {
            $query['phoneNumber'] = $request->phoneNumber;
        }
        if (!Utils::isUnset($request->scopeType)) {
            $query['scopeType'] = $request->scopeType;
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
            'action'      => 'AddCallConfig',
            'version'     => 'dingPhone_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dingPhone/callConfigs',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddCallConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddCallConfigRequest $request
     *
     * @return AddCallConfigResponse
     */
    public function addCallConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddCallConfigHeaders([]);

        return $this->addCallConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DelCallConfigRequest $request
     * @param DelCallConfigHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return DelCallConfigResponse
     */
    public function delCallConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvToken)) {
            $query['isvToken'] = $request->isvToken;
        }
        if (!Utils::isUnset($request->phoneNumber)) {
            $query['phoneNumber'] = $request->phoneNumber;
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
            'action'      => 'DelCallConfig',
            'version'     => 'dingPhone_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dingPhone/callConfigs',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DelCallConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DelCallConfigRequest $request
     *
     * @return DelCallConfigResponse
     */
    public function delCallConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DelCallConfigHeaders([]);

        return $this->delCallConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCallConfigRequest $request
     * @param QueryCallConfigHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return QueryCallConfigResponse
     */
    public function queryCallConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvToken)) {
            $query['isvToken'] = $request->isvToken;
        }
        if (!Utils::isUnset($request->phoneNumber)) {
            $query['phoneNumber'] = $request->phoneNumber;
        }
        if (!Utils::isUnset($request->scopeType)) {
            $query['scopeType'] = $request->scopeType;
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
            'action'      => 'QueryCallConfig',
            'version'     => 'dingPhone_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/dingPhone/callConfigs',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCallConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryCallConfigRequest $request
     *
     * @return QueryCallConfigResponse
     */
    public function queryCallConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCallConfigHeaders([]);

        return $this->queryCallConfigWithOptions($request, $headers, $runtime);
    }
}
