<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpackage_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\CloseHPackageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\CloseHPackageRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\CloseHPackageResponse;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\GetUploadTokenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\GetUploadTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\GetUploadTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HPackageListGetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HPackageListGetRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HPackageListGetResponse;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HPublishPackageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HPublishPackageRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HPublishPackageResponse;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HUploadPackageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HUploadPackageRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HUploadPackageResponse;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HUploadPackageStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HUploadPackageStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\HUploadPackageStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\OpenMicroAppPackageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\OpenMicroAppPackageRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\OpenMicroAppPackageResponse;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayDeployHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayDeployRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayDeployResponse;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayExitHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayExitRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayExitResponse;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayOrgGetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayOrgGetRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayOrgGetResponse;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayOrgSetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayOrgSetRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayOrgSetResponse;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayPercentGetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayPercentGetRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayPercentGetResponse;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayPercentSetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayPercentSetRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayPercentSetResponse;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayUserIdGetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayUserIdGetRequest;
use AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models\ReleaseGrayUserIdGetResponse;
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
     * @param CloseHPackageRequest $request
     * @param CloseHPackageHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return CloseHPackageResponse
     */
    public function closeHPackageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->miniAppId)) {
            $body['miniAppId'] = $request->miniAppId;
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
            'action'      => 'CloseHPackage',
            'version'     => 'package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/package/h5/microApps/close',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CloseHPackageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CloseHPackageRequest $request
     *
     * @return CloseHPackageResponse
     */
    public function closeHPackage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CloseHPackageHeaders([]);

        return $this->closeHPackageWithOptions($request, $headers, $runtime);
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
            $query['miniAppId'] = $request->miniAppId;
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
            'action'      => 'GetUploadToken',
            'version'     => 'package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/package/uploadTokens',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUploadTokenResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param HPackageListGetRequest $request
     * @param HPackageListGetHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return HPackageListGetResponse
     */
    public function hPackageListGetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->miniAppId)) {
            $query['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action'      => 'HPackageListGet',
            'version'     => 'package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/package/h5/versions',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HPackageListGetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HPackageListGetRequest $request
     *
     * @return HPackageListGetResponse
     */
    public function hPackageListGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HPackageListGetHeaders([]);

        return $this->hPackageListGetWithOptions($request, $headers, $runtime);
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
            $body['miniAppId'] = $request->miniAppId;
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
            'action'      => 'HPublishPackage',
            'version'     => 'package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/package/h5/publish',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HPublishPackageResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['miniAppId'] = $request->miniAppId;
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
            'action'      => 'HUploadPackage',
            'version'     => 'package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/package/h5/asyncUpload',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HUploadPackageResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['miniAppId'] = $request->miniAppId;
        }
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
            'action'      => 'HUploadPackageStatus',
            'version'     => 'package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/package/h5/uploadStatus',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HUploadPackageStatusResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param OpenMicroAppPackageRequest $request
     * @param OpenMicroAppPackageHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return OpenMicroAppPackageResponse
     */
    public function openMicroAppPackageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->agentId)) {
            $body['agentId'] = $request->agentId;
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
            'action'      => 'OpenMicroAppPackage',
            'version'     => 'package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/package/h5/microApps/open',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return OpenMicroAppPackageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param OpenMicroAppPackageRequest $request
     *
     * @return OpenMicroAppPackageResponse
     */
    public function openMicroAppPackage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OpenMicroAppPackageHeaders([]);

        return $this->openMicroAppPackageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReleaseGrayDeployRequest $request
     * @param ReleaseGrayDeployHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return ReleaseGrayDeployResponse
     */
    public function releaseGrayDeployWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->miniAppId)) {
            $body['miniAppId'] = $request->miniAppId;
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
            'action'      => 'ReleaseGrayDeploy',
            'version'     => 'package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/package/greys/deploy',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ReleaseGrayDeployResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ReleaseGrayDeployRequest $request
     *
     * @return ReleaseGrayDeployResponse
     */
    public function releaseGrayDeploy($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReleaseGrayDeployHeaders([]);

        return $this->releaseGrayDeployWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReleaseGrayExitRequest $request
     * @param ReleaseGrayExitHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ReleaseGrayExitResponse
     */
    public function releaseGrayExitWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->miniAppId)) {
            $body['miniAppId'] = $request->miniAppId;
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
            'action'      => 'ReleaseGrayExit',
            'version'     => 'package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/package/greys/exit',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ReleaseGrayExitResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ReleaseGrayExitRequest $request
     *
     * @return ReleaseGrayExitResponse
     */
    public function releaseGrayExit($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReleaseGrayExitHeaders([]);

        return $this->releaseGrayExitWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReleaseGrayOrgGetRequest $request
     * @param ReleaseGrayOrgGetHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return ReleaseGrayOrgGetResponse
     */
    public function releaseGrayOrgGetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->miniAppId)) {
            $query['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->version)) {
            $query['version'] = $request->version;
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
            'action'      => 'ReleaseGrayOrgGet',
            'version'     => 'package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/package/greys/organizations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ReleaseGrayOrgGetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ReleaseGrayOrgGetRequest $request
     *
     * @return ReleaseGrayOrgGetResponse
     */
    public function releaseGrayOrgGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReleaseGrayOrgGetHeaders([]);

        return $this->releaseGrayOrgGetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReleaseGrayOrgSetRequest $request
     * @param ReleaseGrayOrgSetHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return ReleaseGrayOrgSetResponse
     */
    public function releaseGrayOrgSetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->miniAppId)) {
            $body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->value)) {
            $body['value'] = $request->value;
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
            'action'      => 'ReleaseGrayOrgSet',
            'version'     => 'package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/package/greys/organizations/release',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ReleaseGrayOrgSetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ReleaseGrayOrgSetRequest $request
     *
     * @return ReleaseGrayOrgSetResponse
     */
    public function releaseGrayOrgSet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReleaseGrayOrgSetHeaders([]);

        return $this->releaseGrayOrgSetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReleaseGrayPercentGetRequest $request
     * @param ReleaseGrayPercentGetHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return ReleaseGrayPercentGetResponse
     */
    public function releaseGrayPercentGetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->miniAppId)) {
            $query['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->version)) {
            $query['version'] = $request->version;
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
            'action'      => 'ReleaseGrayPercentGet',
            'version'     => 'package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/package/greys/users/percents',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ReleaseGrayPercentGetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ReleaseGrayPercentGetRequest $request
     *
     * @return ReleaseGrayPercentGetResponse
     */
    public function releaseGrayPercentGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReleaseGrayPercentGetHeaders([]);

        return $this->releaseGrayPercentGetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReleaseGrayPercentSetRequest $request
     * @param ReleaseGrayPercentSetHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return ReleaseGrayPercentSetResponse
     */
    public function releaseGrayPercentSetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->miniAppId)) {
            $body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->value)) {
            $body['value'] = $request->value;
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
            'action'      => 'ReleaseGrayPercentSet',
            'version'     => 'package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/package/greys/users/percents/release',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ReleaseGrayPercentSetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ReleaseGrayPercentSetRequest $request
     *
     * @return ReleaseGrayPercentSetResponse
     */
    public function releaseGrayPercentSet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReleaseGrayPercentSetHeaders([]);

        return $this->releaseGrayPercentSetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReleaseGrayUserIdGetRequest $request
     * @param ReleaseGrayUserIdGetHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return ReleaseGrayUserIdGetResponse
     */
    public function releaseGrayUserIdGetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->miniAppId)) {
            $query['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->version)) {
            $query['version'] = $request->version;
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
            'action'      => 'ReleaseGrayUserIdGet',
            'version'     => 'package_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/package/greys/users',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ReleaseGrayUserIdGetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ReleaseGrayUserIdGetRequest $request
     *
     * @return ReleaseGrayUserIdGetResponse
     */
    public function releaseGrayUserIdGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReleaseGrayUserIdGetHeaders([]);

        return $this->releaseGrayUserIdGetWithOptions($request, $headers, $runtime);
    }
}
