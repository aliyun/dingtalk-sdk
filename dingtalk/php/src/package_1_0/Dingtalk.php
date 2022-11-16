<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpackage_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\GetUploadTokenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\GetUploadTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\GetUploadTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HPublishPackageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HPublishPackageRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HPublishPackageResponse;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HUploadPackageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HUploadPackageRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HUploadPackageResponse;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HUploadPackageStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HUploadPackageStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HUploadPackageStatusResponse;
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
     * @param GetUploadTokenRequest $request
     *
     * @return GetUploadTokenResponse
     */
    public function getUploadToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUploadTokenHeaders([]);

        return $this->getUploadTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetUploadTokenRequest $request
     * @param GetUploadTokenHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetUploadTokenResponse
     */
    public function getUploadTokenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->miniAppId)) {
            @$query['miniAppId'] = $request->miniAppId;
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

        return GetUploadTokenResponse::fromMap($this->doROARequest('GetUploadToken', 'package_1.0', 'HTTP', 'GET', 'AK', '/v1.0/package/uploadTokens', 'json', $req, $runtime));
    }

    /**
     * @param HPublishPackageRequest $request
     *
     * @return HPublishPackageResponse
     */
    public function hPublishPackage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HPublishPackageHeaders([]);

        return $this->hPublishPackageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HPublishPackageRequest $request
     * @param HPublishPackageHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return HPublishPackageResponse
     */
    public function hPublishPackageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->miniAppId)) {
            @$body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->version)) {
            @$body['version'] = $request->version;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return HPublishPackageResponse::fromMap($this->doROARequest('HPublishPackage', 'package_1.0', 'HTTP', 'POST', 'AK', '/v1.0/package/h5/publish', 'json', $req, $runtime));
    }

    /**
     * @param HUploadPackageRequest $request
     *
     * @return HUploadPackageResponse
     */
    public function hUploadPackage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HUploadPackageHeaders([]);

        return $this->hUploadPackageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HUploadPackageRequest $request
     * @param HUploadPackageHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return HUploadPackageResponse
     */
    public function hUploadPackageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->miniAppId)) {
            @$body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->ossObjectKey)) {
            @$body['ossObjectKey'] = $request->ossObjectKey;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return HUploadPackageResponse::fromMap($this->doROARequest('HUploadPackage', 'package_1.0', 'HTTP', 'POST', 'AK', '/v1.0/package/h5/asyncUpload', 'json', $req, $runtime));
    }

    /**
     * @param HUploadPackageStatusRequest $request
     *
     * @return HUploadPackageStatusResponse
     */
    public function hUploadPackageStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HUploadPackageStatusHeaders([]);

        return $this->hUploadPackageStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HUploadPackageStatusRequest $request
     * @param HUploadPackageStatusHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return HUploadPackageStatusResponse
     */
    public function hUploadPackageStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->miniAppId)) {
            @$query['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->taskId)) {
            @$query['taskId'] = $request->taskId;
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

        return HUploadPackageStatusResponse::fromMap($this->doROARequest('HUploadPackageStatus', 'package_1.0', 'HTTP', 'GET', 'AK', '/v1.0/package/h5/uploadStatus', 'json', $req, $runtime));
    }
}
