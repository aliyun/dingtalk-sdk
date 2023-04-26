<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh5package_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vh5package_1_0\Models\CreatePackageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh5package_1_0\Models\CreatePackageRequest;
use AlibabaCloud\SDK\Dingtalk\Vh5package_1_0\Models\CreatePackageResponse;
use AlibabaCloud\SDK\Dingtalk\Vh5package_1_0\Models\GetAccessTokenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh5package_1_0\Models\GetAccessTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Vh5package_1_0\Models\GetAccessTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Vh5package_1_0\Models\GetCreateStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh5package_1_0\Models\GetCreateStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vh5package_1_0\Models\GetCreateStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vh5package_1_0\Models\PublishPackageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh5package_1_0\Models\PublishPackageRequest;
use AlibabaCloud\SDK\Dingtalk\Vh5package_1_0\Models\PublishPackageResponse;
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
     * @param CreatePackageRequest $request
     * @param CreatePackageHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return CreatePackageResponse
     */
    public function createPackageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->agentId)) {
            $body['agentId'] = $request->agentId;
        }
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->homeUrl)) {
            $body['homeUrl'] = $request->homeUrl;
        }
        if (!Utils::isUnset($request->ossObjectKey)) {
            $body['ossObjectKey'] = $request->ossObjectKey;
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
            'action'      => 'CreatePackage',
            'version'     => 'h5package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h5package/asyncUpload',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreatePackageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreatePackageRequest $request
     *
     * @return CreatePackageResponse
     */
    public function createPackage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreatePackageHeaders([]);

        return $this->createPackageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetAccessTokenRequest $request
     * @param GetAccessTokenHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetAccessTokenResponse
     */
    public function getAccessTokenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->agentId)) {
            $query['agentId'] = $request->agentId;
        }
        if (!Utils::isUnset($request->appId)) {
            $query['appId'] = $request->appId;
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
            'action'      => 'GetAccessToken',
            'version'     => 'h5package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h5package/uploadTokens',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAccessTokenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetAccessTokenRequest $request
     *
     * @return GetAccessTokenResponse
     */
    public function getAccessToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAccessTokenHeaders([]);

        return $this->getAccessTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCreateStatusRequest $request
     * @param GetCreateStatusHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetCreateStatusResponse
     */
    public function getCreateStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->taskId)) {
            $query['taskId'] = $request->taskId;
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
            'action'      => 'GetCreateStatus',
            'version'     => 'h5package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h5package/uploadStatus',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCreateStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetCreateStatusRequest $request
     *
     * @return GetCreateStatusResponse
     */
    public function getCreateStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCreateStatusHeaders([]);

        return $this->getCreateStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PublishPackageRequest $request
     * @param PublishPackageHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return PublishPackageResponse
     */
    public function publishPackageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->agentId)) {
            $body['agentId'] = $request->agentId;
        }
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->version)) {
            $body['version'] = $request->version;
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
            'action'      => 'PublishPackage',
            'version'     => 'h5package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h5package/publish',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PublishPackageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PublishPackageRequest $request
     *
     * @return PublishPackageResponse
     */
    public function publishPackage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PublishPackageHeaders([]);

        return $this->publishPackageWithOptions($request, $headers, $runtime);
    }
}
