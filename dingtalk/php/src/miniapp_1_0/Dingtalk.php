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
        $this->_client             = new DarabonbaGatewayDingTalkClient();
        $this->_spi                = $this->_client;
        $this->_signatureAlgorithm = 'v2';
        $this->_endpointRule       = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
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
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->bundleId)) {
            $body['bundleId'] = $request->bundleId;
        }
        if (!Utils::isUnset($request->desc)) {
            $body['desc'] = $request->desc;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
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
            'action'      => 'CreateMiniApp',
            'version'     => 'miniapp_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/miniapp/apps',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateMiniAppResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->bundleId)) {
            $body['bundleId'] = $request->bundleId;
        }
        if (!Utils::isUnset($request->desc)) {
            $body['desc'] = $request->desc;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
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
            'action'      => 'CreateMiniAppPlugin',
            'version'     => 'miniapp_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/miniapp/plugins',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateMiniAppPluginResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['bundleId'] = $request->bundleId;
        }
        if (!Utils::isUnset($request->miniAppId)) {
            $body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->sourceBundleId)) {
            $body['sourceBundleId'] = $request->sourceBundleId;
        }
        if (!Utils::isUnset($request->sourceVersion)) {
            $body['sourceVersion'] = $request->sourceVersion;
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
            'action'      => 'CreateVersionAcrossBundle',
            'version'     => 'miniapp_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/miniapp/versions/createAcrossBundle',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateVersionAcrossBundleResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['bundleId'] = $request->bundleId;
        }
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
            'action'      => 'GetMaxVersion',
            'version'     => 'miniapp_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/miniapp/apps/maxVersions',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetMaxVersionResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['bundleId'] = $request->bundleId;
        }
        if (!Utils::isUnset($request->bundleIdTableGmtModified)) {
            $body['bundleIdTableGmtModified'] = $request->bundleIdTableGmtModified;
        }
        if (!Utils::isUnset($request->fromAppName)) {
            $body['fromAppName'] = $request->fromAppName;
        }
        if (!Utils::isUnset($request->miniAppIdTableGmtModified)) {
            $body['miniAppIdTableGmtModified'] = $request->miniAppIdTableGmtModified;
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
            'action'      => 'GetMiniAppMetaData',
            'version'     => 'miniapp_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/miniapp/apps/metadata',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetMiniAppMetaDataResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param string                       $miniAppId
     * @param GetSettingByMiniAppIdHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GetSettingByMiniAppIdResponse
     */
    public function getSettingByMiniAppIdWithOptions($miniAppId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetSettingByMiniAppId',
            'version'     => 'miniapp_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/miniapp/apps/settings',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSettingByMiniAppIdResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['bundleId'] = $request->bundleId;
        }
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
            'action'      => 'InvokeHtmlBundleBuild',
            'version'     => 'miniapp_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/miniapp/h5Bundles/build',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InvokeHtmlBundleBuildResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['bundleId'] = $request->bundleId;
        }
        if (!Utils::isUnset($request->miniAppId)) {
            $body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->pageNum)) {
            $body['pageNum'] = $request->pageNum;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->versionTypeSet)) {
            $body['versionTypeSet'] = $request->versionTypeSet;
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
            'action'      => 'ListAvaiableVersion',
            'version'     => 'miniapp_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/miniapp/apps/versions/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListAvaiableVersionResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['bundleId'] = $request->bundleId;
        }
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
            'action'      => 'QueryHtmlBundleBuild',
            'version'     => 'miniapp_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/miniapp/h5Bundles/buildResults',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryHtmlBundleBuildResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['bundleId'] = $request->bundleId;
        }
        if (!Utils::isUnset($request->miniAppId)) {
            $body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->rollbackVersion)) {
            $body['rollbackVersion'] = $request->rollbackVersion;
        }
        if (!Utils::isUnset($request->targetVersion)) {
            $body['targetVersion'] = $request->targetVersion;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RollBackVersion',
            'version'     => 'miniapp_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/miniapp/versions/rollback',
            'method'      => 'POST',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RollBackVersionResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['buildH5Bundle'] = $request->buildH5Bundle;
        }
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
            'action'      => 'SetExtendSetting',
            'version'     => 'miniapp_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/miniapp/apps/settings',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SetExtendSettingResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['bundleId'] = $request->bundleId;
        }
        if (!Utils::isUnset($request->miniAppId)) {
            $body['miniAppId'] = $request->miniAppId;
        }
        if (!Utils::isUnset($request->version)) {
            $body['version'] = $request->version;
        }
        if (!Utils::isUnset($request->versionType)) {
            $body['versionType'] = $request->versionType;
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
            'action'      => 'UpdateVersionStatus',
            'version'     => 'miniapp_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/miniapp/versions/status',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateVersionStatusResponse::fromMap($this->execute($params, $req, $runtime));
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
}
