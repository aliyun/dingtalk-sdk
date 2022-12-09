<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\CreateMiniAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\CreateMiniAppPluginHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\CreateMiniAppPluginRequest;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\CreateMiniAppPluginResponse;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\CreateMiniAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\CreateMiniAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\CreateVersionAcrossBundleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\CreateVersionAcrossBundleRequest;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\CreateVersionAcrossBundleResponse;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\GetMaxVersionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\GetMaxVersionRequest;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\GetMaxVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\GetMiniAppMetaDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\GetMiniAppMetaDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\GetMiniAppMetaDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\GetSettingByMiniAppIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\GetSettingByMiniAppIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\InvokeHtmlBundleBuildHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\InvokeHtmlBundleBuildRequest;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\InvokeHtmlBundleBuildResponse;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\ListAvaiableVersionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\ListAvaiableVersionRequest;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\ListAvaiableVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\QueryHtmlBundleBuildHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\QueryHtmlBundleBuildRequest;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\QueryHtmlBundleBuildResponse;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\RollBackVersionRequest;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\RollBackVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\SetExtendSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\SetExtendSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\SetExtendSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\UpdateVersionStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\UpdateVersionStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\UpdateVersionStatusResponse;
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
     * @param CreateMiniAppRequest $request
     *
     * @return CreateMiniAppResponse
     */
    public function createMiniApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateMiniAppHeaders([]);

        return $this->createMiniAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateMiniAppRequest $request
     * @param CreateMiniAppHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return CreateMiniAppResponse
     */
    public function createMiniAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            @$body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->bizType)) {
            @$body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->bundleId)) {
            @$body['bundleId'] = $request->bundleId;
        }
        if (!Utils::isUnset($request->desc)) {
            @$body['desc'] = $request->desc;
        }
        if (!Utils::isUnset($request->icon)) {
            @$body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
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

        return CreateMiniAppResponse::fromMap($this->doROARequest('CreateMiniApp', 'miniapp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/miniapp/apps', 'json', $req, $runtime));
    }

    /**
     * @param CreateMiniAppPluginRequest $request
     *
     * @return CreateMiniAppPluginResponse
     */
    public function createMiniAppPlugin($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateMiniAppPluginHeaders([]);

        return $this->createMiniAppPluginWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateMiniAppPluginRequest $request
     * @param CreateMiniAppPluginHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return CreateMiniAppPluginResponse
     */
    public function createMiniAppPluginWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            @$body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->bizType)) {
            @$body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->bundleId)) {
            @$body['bundleId'] = $request->bundleId;
        }
        if (!Utils::isUnset($request->desc)) {
            @$body['desc'] = $request->desc;
        }
        if (!Utils::isUnset($request->icon)) {
            @$body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
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

        return CreateMiniAppPluginResponse::fromMap($this->doROARequest('CreateMiniAppPlugin', 'miniapp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/miniapp/plugins', 'json', $req, $runtime));
    }

    /**
     * @param CreateVersionAcrossBundleRequest $request
     *
     * @return CreateVersionAcrossBundleResponse
     */
    public function createVersionAcrossBundle($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateVersionAcrossBundleHeaders([]);

        return $this->createVersionAcrossBundleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateVersionAcrossBundleRequest $request
     * @param CreateVersionAcrossBundleHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return CreateVersionAcrossBundleResponse
     */
    public function createVersionAcrossBundleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bundleId)) {
            @$body['bundleId'] = $request->bundleId;
        }
        if (!Utils::isUnset($request->miniAppId)) {
            @$body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->sourceBundleId)) {
            @$body['sourceBundleId'] = $request->sourceBundleId;
        }
        if (!Utils::isUnset($request->sourceVersion)) {
            @$body['sourceVersion'] = $request->sourceVersion;
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

        return CreateVersionAcrossBundleResponse::fromMap($this->doROARequest('CreateVersionAcrossBundle', 'miniapp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/miniapp/versions/createAcrossBundle', 'json', $req, $runtime));
    }

    /**
     * @param GetMaxVersionRequest $request
     *
     * @return GetMaxVersionResponse
     */
    public function getMaxVersion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMaxVersionHeaders([]);

        return $this->getMaxVersionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetMaxVersionRequest $request
     * @param GetMaxVersionHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetMaxVersionResponse
     */
    public function getMaxVersionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bundleId)) {
            @$query['bundleId'] = $request->bundleId;
        }
        if (!Utils::isUnset($request->miniAppId)) {
            @$query['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->version)) {
            @$query['version'] = $request->version;
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

        return GetMaxVersionResponse::fromMap($this->doROARequest('GetMaxVersion', 'miniapp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/miniapp/apps/maxVersions', 'json', $req, $runtime));
    }

    /**
     * @param GetMiniAppMetaDataRequest $request
     *
     * @return GetMiniAppMetaDataResponse
     */
    public function getMiniAppMetaData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMiniAppMetaDataHeaders([]);

        return $this->getMiniAppMetaDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetMiniAppMetaDataRequest $request
     * @param GetMiniAppMetaDataHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetMiniAppMetaDataResponse
     */
    public function getMiniAppMetaDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bundleId)) {
            @$body['bundleId'] = $request->bundleId;
        }
        if (!Utils::isUnset($request->bundleIdTableGmtModified)) {
            @$body['bundleIdTableGmtModified'] = $request->bundleIdTableGmtModified;
        }
        if (!Utils::isUnset($request->fromAppName)) {
            @$body['fromAppName'] = $request->fromAppName;
        }
        if (!Utils::isUnset($request->miniAppIdTableGmtModified)) {
            @$body['miniAppIdTableGmtModified'] = $request->miniAppIdTableGmtModified;
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

        return GetMiniAppMetaDataResponse::fromMap($this->doROARequest('GetMiniAppMetaData', 'miniapp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/miniapp/apps/metadata', 'json', $req, $runtime));
    }

    /**
     * @param string $miniAppId
     *
     * @return GetSettingByMiniAppIdResponse
     */
    public function getSettingByMiniAppId($miniAppId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSettingByMiniAppIdHeaders([]);

        return $this->getSettingByMiniAppIdWithOptions($miniAppId, $headers, $runtime);
    }

    /**
     * @param string                       $miniAppId
     * @param GetSettingByMiniAppIdHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GetSettingByMiniAppIdResponse
     */
    public function getSettingByMiniAppIdWithOptions($miniAppId, $headers, $runtime)
    {
        $miniAppId   = OpenApiUtilClient::getEncodeParam($miniAppId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetSettingByMiniAppIdResponse::fromMap($this->doROARequest('GetSettingByMiniAppId', 'miniapp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/miniapp/apps/settings', 'json', $req, $runtime));
    }

    /**
     * @param InvokeHtmlBundleBuildRequest $request
     *
     * @return InvokeHtmlBundleBuildResponse
     */
    public function invokeHtmlBundleBuild($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InvokeHtmlBundleBuildHeaders([]);

        return $this->invokeHtmlBundleBuildWithOptions($request, $headers, $runtime);
    }

    /**
     * @param InvokeHtmlBundleBuildRequest $request
     * @param InvokeHtmlBundleBuildHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return InvokeHtmlBundleBuildResponse
     */
    public function invokeHtmlBundleBuildWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bundleId)) {
            @$body['bundleId'] = $request->bundleId;
        }
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

        return InvokeHtmlBundleBuildResponse::fromMap($this->doROARequest('InvokeHtmlBundleBuild', 'miniapp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/miniapp/h5Bundles/build', 'json', $req, $runtime));
    }

    /**
     * @param ListAvaiableVersionRequest $request
     *
     * @return ListAvaiableVersionResponse
     */
    public function listAvaiableVersion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAvaiableVersionHeaders([]);

        return $this->listAvaiableVersionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListAvaiableVersionRequest $request
     * @param ListAvaiableVersionHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return ListAvaiableVersionResponse
     */
    public function listAvaiableVersionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bundleId)) {
            @$body['bundleId'] = $request->bundleId;
        }
        if (!Utils::isUnset($request->miniAppId)) {
            @$body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->pageNum)) {
            @$body['pageNum'] = $request->pageNum;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->versionTypeSet)) {
            @$body['versionTypeSet'] = $request->versionTypeSet;
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

        return ListAvaiableVersionResponse::fromMap($this->doROARequest('ListAvaiableVersion', 'miniapp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/miniapp/apps/versions/query', 'json', $req, $runtime));
    }

    /**
     * @param QueryHtmlBundleBuildRequest $request
     *
     * @return QueryHtmlBundleBuildResponse
     */
    public function queryHtmlBundleBuild($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHtmlBundleBuildHeaders([]);

        return $this->queryHtmlBundleBuildWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryHtmlBundleBuildRequest $request
     * @param QueryHtmlBundleBuildHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryHtmlBundleBuildResponse
     */
    public function queryHtmlBundleBuildWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bundleId)) {
            @$query['bundleId'] = $request->bundleId;
        }
        if (!Utils::isUnset($request->miniAppId)) {
            @$query['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->version)) {
            @$query['version'] = $request->version;
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

        return QueryHtmlBundleBuildResponse::fromMap($this->doROARequest('QueryHtmlBundleBuild', 'miniapp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/miniapp/h5Bundles/buildResults', 'json', $req, $runtime));
    }

    /**
     * @param RollBackVersionRequest $request
     *
     * @return RollBackVersionResponse
     */
    public function rollBackVersion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->rollBackVersionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RollBackVersionRequest $request
     * @param string[]               $headers
     * @param RuntimeOptions         $runtime
     *
     * @return RollBackVersionResponse
     */
    public function rollBackVersionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bundleId)) {
            @$body['bundleId'] = $request->bundleId;
        }
        if (!Utils::isUnset($request->miniAppId)) {
            @$body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->rollbackVersion)) {
            @$body['rollbackVersion'] = $request->rollbackVersion;
        }
        if (!Utils::isUnset($request->targetVersion)) {
            @$body['targetVersion'] = $request->targetVersion;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RollBackVersionResponse::fromMap($this->doROARequest('RollBackVersion', 'miniapp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/miniapp/versions/rollback', 'json', $req, $runtime));
    }

    /**
     * @param SetExtendSettingRequest $request
     *
     * @return SetExtendSettingResponse
     */
    public function setExtendSetting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetExtendSettingHeaders([]);

        return $this->setExtendSettingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SetExtendSettingRequest $request
     * @param SetExtendSettingHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return SetExtendSettingResponse
     */
    public function setExtendSettingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->buildH5Bundle)) {
            @$body['buildH5Bundle'] = $request->buildH5Bundle;
        }
        if (!Utils::isUnset($request->miniAppId)) {
            @$body['miniAppId'] = $request->miniAppId;
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

        return SetExtendSettingResponse::fromMap($this->doROARequest('SetExtendSetting', 'miniapp_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/miniapp/apps/settings', 'json', $req, $runtime));
    }

    /**
     * @param UpdateVersionStatusRequest $request
     *
     * @return UpdateVersionStatusResponse
     */
    public function updateVersionStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateVersionStatusHeaders([]);

        return $this->updateVersionStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateVersionStatusRequest $request
     * @param UpdateVersionStatusHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return UpdateVersionStatusResponse
     */
    public function updateVersionStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bundleId)) {
            @$body['bundleId'] = $request->bundleId;
        }
        if (!Utils::isUnset($request->miniAppId)) {
            @$body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->version)) {
            @$body['version'] = $request->version;
        }
        if (!Utils::isUnset($request->versionType)) {
            @$body['versionType'] = $request->versionType;
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

        return UpdateVersionStatusResponse::fromMap($this->doROARequest('UpdateVersionStatus', 'miniapp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/miniapp/versions/status', 'json', $req, $runtime));
    }
}
