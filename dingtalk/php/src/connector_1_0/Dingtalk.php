<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateActionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateActionRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateActionResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateConnectorHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateConnectorRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateConnectorResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateInvocableInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateInvocableInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateInvocableInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateTriggerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateTriggerRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateTriggerResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\GetActionDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\GetActionDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\GetActionDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\InvokeInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\InvokeInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\InvokeInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPkHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPkRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPkResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SearchActionsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SearchActionsRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SearchActionsResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SearchConnectorsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SearchConnectorsRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SearchConnectorsResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SyncDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SyncDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\SyncDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateActionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateActionRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateActionResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateConnectorHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateConnectorRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateConnectorResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateTriggerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateTriggerRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\UpdateTriggerResponse;
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
     * @param CreateActionRequest $request
     * @param CreateActionHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return CreateActionResponse
     */
    public function createActionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionInfo)) {
            $body['actionInfo'] = $request->actionInfo;
        }
        if (!Utils::isUnset($request->integratorFlag)) {
            $body['integratorFlag'] = $request->integratorFlag;
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
            'action'      => 'CreateAction',
            'version'     => 'connector_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/connector/actions',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateActionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateActionRequest $request
     *
     * @return CreateActionResponse
     */
    public function createAction($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateActionHeaders([]);

        return $this->createActionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateConnectorRequest $request
     * @param CreateConnectorHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return CreateConnectorResponse
     */
    public function createConnectorWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->connectorInfo)) {
            $body['connectorInfo'] = $request->connectorInfo;
        }
        if (!Utils::isUnset($request->integratorFlag)) {
            $body['integratorFlag'] = $request->integratorFlag;
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
            'action'      => 'CreateConnector',
            'version'     => 'connector_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/connector/connectors',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateConnectorResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateConnectorRequest $request
     *
     * @return CreateConnectorResponse
     */
    public function createConnector($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateConnectorHeaders([]);

        return $this->createConnectorWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateInvocableInstanceRequest $request
     * @param CreateInvocableInstanceHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CreateInvocableInstanceResponse
     */
    public function createInvocableInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->connectAssetUri)) {
            $body['connectAssetUri'] = $request->connectAssetUri;
        }
        if (!Utils::isUnset($request->instanceKey)) {
            $body['instanceKey'] = $request->instanceKey;
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
            'action'      => 'CreateInvocableInstance',
            'version'     => 'connector_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/connector/instances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateInvocableInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateInvocableInstanceRequest $request
     *
     * @return CreateInvocableInstanceResponse
     */
    public function createInvocableInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateInvocableInstanceHeaders([]);

        return $this->createInvocableInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateTriggerRequest $request
     * @param CreateTriggerHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return CreateTriggerResponse
     */
    public function createTriggerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->integratorFlag)) {
            $body['integratorFlag'] = $request->integratorFlag;
        }
        if (!Utils::isUnset($request->triggerInfo)) {
            $body['triggerInfo'] = $request->triggerInfo;
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
            'action'      => 'CreateTrigger',
            'version'     => 'connector_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/connector/triggers',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateTriggerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateTriggerRequest $request
     *
     * @return CreateTriggerResponse
     */
    public function createTrigger($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTriggerHeaders([]);

        return $this->createTriggerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetActionDetailRequest $request
     * @param GetActionDetailHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetActionDetailResponse
     */
    public function getActionDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->connectAssetUri)) {
            $body['connectAssetUri'] = $request->connectAssetUri;
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
            'action'      => 'GetActionDetail',
            'version'     => 'connector_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/connector/assets/actions/details/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetActionDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetActionDetailRequest $request
     *
     * @return GetActionDetailResponse
     */
    public function getActionDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetActionDetailHeaders([]);

        return $this->getActionDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @param InvokeInstanceRequest $request
     * @param InvokeInstanceHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return InvokeInstanceResponse
     */
    public function invokeInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->connectAssetUri)) {
            $body['connectAssetUri'] = $request->connectAssetUri;
        }
        if (!Utils::isUnset($request->inputJsonString)) {
            $body['inputJsonString'] = $request->inputJsonString;
        }
        if (!Utils::isUnset($request->instanceKey)) {
            $body['instanceKey'] = $request->instanceKey;
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
            'action'      => 'InvokeInstance',
            'version'     => 'connector_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/connector/instances/invoke',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InvokeInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param InvokeInstanceRequest $request
     *
     * @return InvokeInstanceResponse
     */
    public function invokeInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InvokeInstanceHeaders([]);

        return $this->invokeInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PullDataByPageRequest $request
     * @param PullDataByPageHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return PullDataByPageResponse
     */
    public function pullDataByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appId)) {
            $query['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->dataModelId)) {
            $query['dataModelId'] = $request->dataModelId;
        }
        if (!Utils::isUnset($request->datetimeFilterField)) {
            $query['datetimeFilterField'] = $request->datetimeFilterField;
        }
        if (!Utils::isUnset($request->maxDatetime)) {
            $query['maxDatetime'] = $request->maxDatetime;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->minDatetime)) {
            $query['minDatetime'] = $request->minDatetime;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
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
            'action'      => 'PullDataByPage',
            'version'     => 'connector_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/connector/data',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PullDataByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PullDataByPageRequest $request
     *
     * @return PullDataByPageResponse
     */
    public function pullDataByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PullDataByPageHeaders([]);

        return $this->pullDataByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string              $dataModelId
     * @param PullDataByPkRequest $request
     * @param PullDataByPkHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return PullDataByPkResponse
     */
    public function pullDataByPkWithOptions($dataModelId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appId)) {
            $query['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->primaryKey)) {
            $query['primaryKey'] = $request->primaryKey;
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
            'action'      => 'PullDataByPk',
            'version'     => 'connector_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/connector/data/' . $dataModelId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PullDataByPkResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string              $dataModelId
     * @param PullDataByPkRequest $request
     *
     * @return PullDataByPkResponse
     */
    public function pullDataByPk($dataModelId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PullDataByPkHeaders([]);

        return $this->pullDataByPkWithOptions($dataModelId, $request, $headers, $runtime);
    }

    /**
     * @param SearchActionsRequest $request
     * @param SearchActionsHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return SearchActionsResponse
     */
    public function searchActionsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->connectorId)) {
            $body['connectorId'] = $request->connectorId;
        }
        if (!Utils::isUnset($request->connectorProviderCorpId)) {
            $body['connectorProviderCorpId'] = $request->connectorProviderCorpId;
        }
        if (!Utils::isUnset($request->integrationTypes)) {
            $body['integrationTypes'] = $request->integrationTypes;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
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
            'action'      => 'SearchActions',
            'version'     => 'connector_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/connector/assets/actions/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchActionsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SearchActionsRequest $request
     *
     * @return SearchActionsResponse
     */
    public function searchActions($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchActionsHeaders([]);

        return $this->searchActionsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchConnectorsRequest $request
     * @param SearchConnectorsHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return SearchConnectorsResponse
     */
    public function searchConnectorsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->type)) {
            $query['type'] = $request->type;
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
            'action'      => 'SearchConnectors',
            'version'     => 'connector_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/connector/assets/connectors',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchConnectorsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SearchConnectorsRequest $request
     *
     * @return SearchConnectorsResponse
     */
    public function searchConnectors($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchConnectorsHeaders([]);

        return $this->searchConnectorsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncDataRequest $request
     * @param SyncDataHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return SyncDataResponse
     */
    public function syncDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->triggerDataList)) {
            $body['triggerDataList'] = $request->triggerDataList;
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
            'action'      => 'SyncData',
            'version'     => 'connector_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/connector/triggers/data/sync',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SyncDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SyncDataRequest $request
     *
     * @return SyncDataResponse
     */
    public function syncData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncDataHeaders([]);

        return $this->syncDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateActionRequest $request
     * @param UpdateActionHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return UpdateActionResponse
     */
    public function updateActionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionInfo)) {
            $body['actionInfo'] = $request->actionInfo;
        }
        if (!Utils::isUnset($request->integratorFlag)) {
            $body['integratorFlag'] = $request->integratorFlag;
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
            'action'      => 'UpdateAction',
            'version'     => 'connector_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/connector/actions',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateActionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateActionRequest $request
     *
     * @return UpdateActionResponse
     */
    public function updateAction($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateActionHeaders([]);

        return $this->updateActionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateConnectorRequest $request
     * @param UpdateConnectorHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return UpdateConnectorResponse
     */
    public function updateConnectorWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->connectorInfo)) {
            $body['connectorInfo'] = $request->connectorInfo;
        }
        if (!Utils::isUnset($request->integratorFlag)) {
            $body['integratorFlag'] = $request->integratorFlag;
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
            'action'      => 'UpdateConnector',
            'version'     => 'connector_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/connector/connectors',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateConnectorResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateConnectorRequest $request
     *
     * @return UpdateConnectorResponse
     */
    public function updateConnector($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateConnectorHeaders([]);

        return $this->updateConnectorWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateTriggerRequest $request
     * @param UpdateTriggerHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return UpdateTriggerResponse
     */
    public function updateTriggerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->integratorFlag)) {
            $body['integratorFlag'] = $request->integratorFlag;
        }
        if (!Utils::isUnset($request->triggerInfo)) {
            $body['triggerInfo'] = $request->triggerInfo;
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
            'action'      => 'UpdateTrigger',
            'version'     => 'connector_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/connector/triggers',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateTriggerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateTriggerRequest $request
     *
     * @return UpdateTriggerResponse
     */
    public function updateTrigger($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTriggerHeaders([]);

        return $this->updateTriggerWithOptions($request, $headers, $runtime);
    }
}
