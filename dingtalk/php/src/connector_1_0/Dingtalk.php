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
use Darabonba\GatewayDingTalk\Client;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 创建执行动作
     *  *
     * @param CreateActionRequest $request CreateActionRequest
     * @param CreateActionHeaders $headers CreateActionHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateActionResponse CreateActionResponse
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
     * @summary 创建执行动作
     *  *
     * @param CreateActionRequest $request CreateActionRequest
     *
     * @return CreateActionResponse CreateActionResponse
     */
    public function createAction($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateActionHeaders([]);

        return $this->createActionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建连接器
     *  *
     * @param CreateConnectorRequest $request CreateConnectorRequest
     * @param CreateConnectorHeaders $headers CreateConnectorHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateConnectorResponse CreateConnectorResponse
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
     * @summary 创建连接器
     *  *
     * @param CreateConnectorRequest $request CreateConnectorRequest
     *
     * @return CreateConnectorResponse CreateConnectorResponse
     */
    public function createConnector($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateConnectorHeaders([]);

        return $this->createConnectorWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建一个用于运行执行动作/集成流的可调用实例
     *  *
     * @param CreateInvocableInstanceRequest $request CreateInvocableInstanceRequest
     * @param CreateInvocableInstanceHeaders $headers CreateInvocableInstanceHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateInvocableInstanceResponse CreateInvocableInstanceResponse
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
     * @summary 创建一个用于运行执行动作/集成流的可调用实例
     *  *
     * @param CreateInvocableInstanceRequest $request CreateInvocableInstanceRequest
     *
     * @return CreateInvocableInstanceResponse CreateInvocableInstanceResponse
     */
    public function createInvocableInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateInvocableInstanceHeaders([]);

        return $this->createInvocableInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建触发器
     *  *
     * @param CreateTriggerRequest $request CreateTriggerRequest
     * @param CreateTriggerHeaders $headers CreateTriggerHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTriggerResponse CreateTriggerResponse
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
     * @summary 创建触发器
     *  *
     * @param CreateTriggerRequest $request CreateTriggerRequest
     *
     * @return CreateTriggerResponse CreateTriggerResponse
     */
    public function createTrigger($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTriggerHeaders([]);

        return $this->createTriggerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取执行动作详情
     *  *
     * @param GetActionDetailRequest $request GetActionDetailRequest
     * @param GetActionDetailHeaders $headers GetActionDetailHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetActionDetailResponse GetActionDetailResponse
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
     * @summary 获取执行动作详情
     *  *
     * @param GetActionDetailRequest $request GetActionDetailRequest
     *
     * @return GetActionDetailResponse GetActionDetailResponse
     */
    public function getActionDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetActionDetailHeaders([]);

        return $this->getActionDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 调用执行实例
     *  *
     * @param InvokeInstanceRequest $request InvokeInstanceRequest
     * @param InvokeInstanceHeaders $headers InvokeInstanceHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return InvokeInstanceResponse InvokeInstanceResponse
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
     * @summary 调用执行实例
     *  *
     * @param InvokeInstanceRequest $request InvokeInstanceRequest
     *
     * @return InvokeInstanceResponse InvokeInstanceResponse
     */
    public function invokeInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InvokeInstanceHeaders([]);

        return $this->invokeInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页拉取连接器主数据
     *  *
     * @param PullDataByPageRequest $request PullDataByPageRequest
     * @param PullDataByPageHeaders $headers PullDataByPageHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return PullDataByPageResponse PullDataByPageResponse
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
     * @summary 分页拉取连接器主数据
     *  *
     * @param PullDataByPageRequest $request PullDataByPageRequest
     *
     * @return PullDataByPageResponse PullDataByPageResponse
     */
    public function pullDataByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PullDataByPageHeaders([]);

        return $this->pullDataByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过业务主键拉取单条连接器主数据
     *  *
     * @param string              $dataModelId
     * @param PullDataByPkRequest $request     PullDataByPkRequest
     * @param PullDataByPkHeaders $headers     PullDataByPkHeaders
     * @param RuntimeOptions      $runtime     runtime options for this request RuntimeOptions
     *
     * @return PullDataByPkResponse PullDataByPkResponse
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
     * @summary 通过业务主键拉取单条连接器主数据
     *  *
     * @param string              $dataModelId
     * @param PullDataByPkRequest $request     PullDataByPkRequest
     *
     * @return PullDataByPkResponse PullDataByPkResponse
     */
    public function pullDataByPk($dataModelId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PullDataByPkHeaders([]);

        return $this->pullDataByPkWithOptions($dataModelId, $request, $headers, $runtime);
    }

    /**
     * @summary 搜索执行动作
     *  *
     * @param SearchActionsRequest $request SearchActionsRequest
     * @param SearchActionsHeaders $headers SearchActionsHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchActionsResponse SearchActionsResponse
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
     * @summary 搜索执行动作
     *  *
     * @param SearchActionsRequest $request SearchActionsRequest
     *
     * @return SearchActionsResponse SearchActionsResponse
     */
    public function searchActions($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchActionsHeaders([]);

        return $this->searchActionsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 搜索连接器
     *  *
     * @param SearchConnectorsRequest $request SearchConnectorsRequest
     * @param SearchConnectorsHeaders $headers SearchConnectorsHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchConnectorsResponse SearchConnectorsResponse
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
     * @summary 搜索连接器
     *  *
     * @param SearchConnectorsRequest $request SearchConnectorsRequest
     *
     * @return SearchConnectorsResponse SearchConnectorsResponse
     */
    public function searchConnectors($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchConnectorsHeaders([]);

        return $this->searchConnectorsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 同步连接器数据
     *  *
     * @param SyncDataRequest $request SyncDataRequest
     * @param SyncDataHeaders $headers SyncDataHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return SyncDataResponse SyncDataResponse
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
     * @summary 同步连接器数据
     *  *
     * @param SyncDataRequest $request SyncDataRequest
     *
     * @return SyncDataResponse SyncDataResponse
     */
    public function syncData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncDataHeaders([]);

        return $this->syncDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新执行动作信息
     *  *
     * @param UpdateActionRequest $request UpdateActionRequest
     * @param UpdateActionHeaders $headers UpdateActionHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateActionResponse UpdateActionResponse
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
     * @summary 更新执行动作信息
     *  *
     * @param UpdateActionRequest $request UpdateActionRequest
     *
     * @return UpdateActionResponse UpdateActionResponse
     */
    public function updateAction($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateActionHeaders([]);

        return $this->updateActionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新连接器信息
     *  *
     * @param UpdateConnectorRequest $request UpdateConnectorRequest
     * @param UpdateConnectorHeaders $headers UpdateConnectorHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateConnectorResponse UpdateConnectorResponse
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
     * @summary 更新连接器信息
     *  *
     * @param UpdateConnectorRequest $request UpdateConnectorRequest
     *
     * @return UpdateConnectorResponse UpdateConnectorResponse
     */
    public function updateConnector($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateConnectorHeaders([]);

        return $this->updateConnectorWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新触发事件信息
     *  *
     * @param UpdateTriggerRequest $request UpdateTriggerRequest
     * @param UpdateTriggerHeaders $headers UpdateTriggerHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTriggerResponse UpdateTriggerResponse
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
     * @summary 更新触发事件信息
     *  *
     * @param UpdateTriggerRequest $request UpdateTriggerRequest
     *
     * @return UpdateTriggerResponse UpdateTriggerResponse
     */
    public function updateTrigger($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTriggerHeaders([]);

        return $this->updateTriggerWithOptions($request, $headers, $runtime);
    }
}
