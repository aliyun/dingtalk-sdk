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
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateTriggerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateTriggerRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\CreateTriggerResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPkHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPkRequest;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\PullDataByPkResponse;
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
            @$body['actionInfo'] = $request->actionInfo;
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

        return CreateActionResponse::fromMap($this->doROARequest('CreateAction', 'connector_1.0', 'HTTP', 'POST', 'AK', '/v1.0/connector/actions', 'json', $req, $runtime));
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
            @$body['connectorInfo'] = $request->connectorInfo;
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

        return CreateConnectorResponse::fromMap($this->doROARequest('CreateConnector', 'connector_1.0', 'HTTP', 'POST', 'AK', '/v1.0/connector/connectors', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->triggerInfo)) {
            @$body['triggerInfo'] = $request->triggerInfo;
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

        return CreateTriggerResponse::fromMap($this->doROARequest('CreateTrigger', 'connector_1.0', 'HTTP', 'POST', 'AK', '/v1.0/connector/triggers', 'json', $req, $runtime));
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
            @$query['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->dataModelId)) {
            @$query['dataModelId'] = $request->dataModelId;
        }
        if (!Utils::isUnset($request->datetimeFilterField)) {
            @$query['datetimeFilterField'] = $request->datetimeFilterField;
        }
        if (!Utils::isUnset($request->maxDatetime)) {
            @$query['maxDatetime'] = $request->maxDatetime;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->minDatetime)) {
            @$query['minDatetime'] = $request->minDatetime;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
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

        return PullDataByPageResponse::fromMap($this->doROARequest('PullDataByPage', 'connector_1.0', 'HTTP', 'GET', 'AK', '/v1.0/connector/data', 'json', $req, $runtime));
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
        $dataModelId = OpenApiUtilClient::getEncodeParam($dataModelId);
        $query       = [];
        if (!Utils::isUnset($request->appId)) {
            @$query['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->primaryKey)) {
            @$query['primaryKey'] = $request->primaryKey;
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

        return PullDataByPkResponse::fromMap($this->doROARequest('PullDataByPk', 'connector_1.0', 'HTTP', 'GET', 'AK', '/v1.0/connector/data/' . $dataModelId . '', 'json', $req, $runtime));
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
            @$body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->triggerDataList)) {
            @$body['triggerDataList'] = $request->triggerDataList;
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

        return SyncDataResponse::fromMap($this->doROARequest('SyncData', 'connector_1.0', 'HTTP', 'POST', 'AK', '/v1.0/connector/triggers/data/sync', 'json', $req, $runtime));
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
            @$body['actionInfo'] = $request->actionInfo;
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

        return UpdateActionResponse::fromMap($this->doROARequest('UpdateAction', 'connector_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/connector/actions', 'json', $req, $runtime));
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
            @$body['connectorInfo'] = $request->connectorInfo;
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

        return UpdateConnectorResponse::fromMap($this->doROARequest('UpdateConnector', 'connector_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/connector/connectors', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->triggerInfo)) {
            @$body['triggerInfo'] = $request->triggerInfo;
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

        return UpdateTriggerResponse::fromMap($this->doROARequest('UpdateTrigger', 'connector_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/connector/triggers', 'json', $req, $runtime));
    }
}
