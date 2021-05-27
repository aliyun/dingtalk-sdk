<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AddAppToWorkBenchGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AddAppToWorkBenchGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AddAppToWorkBenchGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\CreateInnerAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\CreateInnerAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\CreateInnerAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\DeleteInnerAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\DeleteInnerAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\DeleteInnerAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetInnerAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetInnerAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\GetInnerAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListInnerAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListInnerAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListInnerAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\UpdateInnerAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\UpdateInnerAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\UpdateInnerAppResponse;
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
     * @param string                        $agentId
     * @param AddAppToWorkBenchGroupRequest $request
     *
     * @return AddAppToWorkBenchGroupResponse
     */
    public function addAppToWorkBenchGroup($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddAppToWorkBenchGroupHeaders([]);

        return $this->addAppToWorkBenchGroupWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @param string                        $agentId
     * @param AddAppToWorkBenchGroupRequest $request
     * @param AddAppToWorkBenchGroupHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return AddAppToWorkBenchGroupResponse
     */
    public function addAppToWorkBenchGroupWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->opUnionId)) {
            @$body['opUnionId'] = $request->opUnionId;
        }
        if (!Utils::isUnset($request->ecologicalCorpId)) {
            @$body['ecologicalCorpId'] = $request->ecologicalCorpId;
        }
        if (!Utils::isUnset($request->componentId)) {
            @$body['componentId'] = $request->componentId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AddAppToWorkBenchGroupResponse::fromMap($this->doROARequest('AddAppToWorkBenchGroup', 'microApp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/microApp/apps/' . $agentId . '/addToWorkBenchGroup', 'json', $req, $runtime));
    }

    /**
     * @param CreateInnerAppRequest $request
     *
     * @return CreateInnerAppResponse
     */
    public function createInnerApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateInnerAppHeaders([]);

        return $this->createInnerAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateInnerAppRequest $request
     * @param CreateInnerAppHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreateInnerAppResponse
     */
    public function createInnerAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->opUnionId)) {
            @$body['opUnionId'] = $request->opUnionId;
        }
        if (!Utils::isUnset($request->ecologicalCorpId)) {
            @$body['ecologicalCorpId'] = $request->ecologicalCorpId;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->desc)) {
            @$body['desc'] = $request->desc;
        }
        if (!Utils::isUnset($request->icon)) {
            @$body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->homepageLink)) {
            @$body['homepageLink'] = $request->homepageLink;
        }
        if (!Utils::isUnset($request->pcHomepageLink)) {
            @$body['pcHomepageLink'] = $request->pcHomepageLink;
        }
        if (!Utils::isUnset($request->ompLink)) {
            @$body['ompLink'] = $request->ompLink;
        }
        if (!Utils::isUnset($request->ipWhiteList)) {
            @$body['ipWhiteList'] = $request->ipWhiteList;
        }
        if (!Utils::isUnset($request->scopeType)) {
            @$body['scopeType'] = $request->scopeType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateInnerAppResponse::fromMap($this->doROARequest('CreateInnerApp', 'microApp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/microApp/apps', 'json', $req, $runtime));
    }

    /**
     * @param string                $agentId
     * @param UpdateInnerAppRequest $request
     *
     * @return UpdateInnerAppResponse
     */
    public function updateInnerApp($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInnerAppHeaders([]);

        return $this->updateInnerAppWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @param string                $agentId
     * @param UpdateInnerAppRequest $request
     * @param UpdateInnerAppHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return UpdateInnerAppResponse
     */
    public function updateInnerAppWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->opUnionId)) {
            @$body['opUnionId'] = $request->opUnionId;
        }
        if (!Utils::isUnset($request->ecologicalCorpId)) {
            @$body['ecologicalCorpId'] = $request->ecologicalCorpId;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->desc)) {
            @$body['desc'] = $request->desc;
        }
        if (!Utils::isUnset($request->icon)) {
            @$body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->homepageLink)) {
            @$body['homepageLink'] = $request->homepageLink;
        }
        if (!Utils::isUnset($request->pcHomepageLink)) {
            @$body['pcHomepageLink'] = $request->pcHomepageLink;
        }
        if (!Utils::isUnset($request->ompLink)) {
            @$body['ompLink'] = $request->ompLink;
        }
        if (!Utils::isUnset($request->ipWhiteList)) {
            @$body['ipWhiteList'] = $request->ipWhiteList;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateInnerAppResponse::fromMap($this->doROARequest('UpdateInnerApp', 'microApp_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/microApp/apps/' . $agentId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                $agentId
     * @param DeleteInnerAppRequest $request
     *
     * @return DeleteInnerAppResponse
     */
    public function deleteInnerApp($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteInnerAppHeaders([]);

        return $this->deleteInnerAppWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @param string                $agentId
     * @param DeleteInnerAppRequest $request
     * @param DeleteInnerAppHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return DeleteInnerAppResponse
     */
    public function deleteInnerAppWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUnionId)) {
            @$query['opUnionId'] = $request->opUnionId;
        }
        if (!Utils::isUnset($request->ecologicalCorpId)) {
            @$query['ecologicalCorpId'] = $request->ecologicalCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteInnerAppResponse::fromMap($this->doROARequest('DeleteInnerApp', 'microApp_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/microApp/apps/' . $agentId . '', 'json', $req, $runtime));
    }

    /**
     * @param string             $agentId
     * @param GetInnerAppRequest $request
     *
     * @return GetInnerAppResponse
     */
    public function getInnerApp($agentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInnerAppHeaders([]);

        return $this->getInnerAppWithOptions($agentId, $request, $headers, $runtime);
    }

    /**
     * @param string             $agentId
     * @param GetInnerAppRequest $request
     * @param GetInnerAppHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetInnerAppResponse
     */
    public function getInnerAppWithOptions($agentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUnionId)) {
            @$query['opUnionId'] = $request->opUnionId;
        }
        if (!Utils::isUnset($request->ecologicalCorpId)) {
            @$query['ecologicalCorpId'] = $request->ecologicalCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetInnerAppResponse::fromMap($this->doROARequest('GetInnerApp', 'microApp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/microApp/apps/' . $agentId . '', 'json', $req, $runtime));
    }

    /**
     * @param ListInnerAppRequest $request
     *
     * @return ListInnerAppResponse
     */
    public function listInnerApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListInnerAppHeaders([]);

        return $this->listInnerAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListInnerAppRequest $request
     * @param ListInnerAppHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return ListInnerAppResponse
     */
    public function listInnerAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->ecologicalCorpId)) {
            @$query['ecologicalCorpId'] = $request->ecologicalCorpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListInnerAppResponse::fromMap($this->doROARequest('ListInnerApp', 'microApp_1.0', 'HTTP', 'GET', 'AK', '/v1.0/microApp/apps', 'json', $req, $runtime));
    }
}
