<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTypeConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTypeConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTypeConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\DeleteTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\DeleteTodoTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\DeleteTodoTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTypeConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTypeConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTypeConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTypeConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTypeConfigResponse;
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
     * @param string $unionId
     * @param string $cardTypeId
     *
     * @return GetTodoTypeConfigResponse
     */
    public function getTodoTypeConfig($unionId, $cardTypeId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTodoTypeConfigHeaders([]);

        return $this->getTodoTypeConfigWithOptions($unionId, $cardTypeId, $headers, $runtime);
    }

    /**
     * @param string                   $unionId
     * @param string                   $cardTypeId
     * @param GetTodoTypeConfigHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetTodoTypeConfigResponse
     */
    public function getTodoTypeConfigWithOptions($unionId, $cardTypeId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetTodoTypeConfigResponse::fromMap($this->doROARequest('GetTodoTypeConfig', 'todo_1.0', 'HTTP', 'GET', 'AK', '/v1.0/todo/users/' . $unionId . '/configs/types/' . $cardTypeId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                      $unionId
     * @param string                      $cardTypeId
     * @param UpdateTodoTypeConfigRequest $request
     *
     * @return UpdateTodoTypeConfigResponse
     */
    public function updateTodoTypeConfig($unionId, $cardTypeId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTodoTypeConfigHeaders([]);

        return $this->updateTodoTypeConfigWithOptions($unionId, $cardTypeId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $unionId
     * @param string                      $cardTypeId
     * @param UpdateTodoTypeConfigRequest $request
     * @param UpdateTodoTypeConfigHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return UpdateTodoTypeConfigResponse
     */
    public function updateTodoTypeConfigWithOptions($unionId, $cardTypeId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->cardType)) {
            @$body['cardType'] = $request->cardType;
        }
        if (!Utils::isUnset($request->icon)) {
            @$body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->pcDetailUrlOpenMode)) {
            @$body['pcDetailUrlOpenMode'] = $request->pcDetailUrlOpenMode;
        }
        if (!Utils::isUnset($request->contentFieldList)) {
            @$body['contentFieldList'] = $request->contentFieldList;
        }
        if (!Utils::isUnset($request->actionList)) {
            @$body['actionList'] = $request->actionList;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateTodoTypeConfigResponse::fromMap($this->doROARequest('UpdateTodoTypeConfig', 'todo_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/todo/users/' . $unionId . '/configs/types/' . $cardTypeId . '', 'json', $req, $runtime));
    }

    /**
     * @param string $unionId
     * @param string $taskId
     *
     * @return GetTodoTaskResponse
     */
    public function getTodoTask($unionId, $taskId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTodoTaskHeaders([]);

        return $this->getTodoTaskWithOptions($unionId, $taskId, $headers, $runtime);
    }

    /**
     * @param string             $unionId
     * @param string             $taskId
     * @param GetTodoTaskHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetTodoTaskResponse
     */
    public function getTodoTaskWithOptions($unionId, $taskId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetTodoTaskResponse::fromMap($this->doROARequest('GetTodoTask', 'todo_1.0', 'HTTP', 'GET', 'AK', '/v1.0/todo/users/' . $unionId . '/tasks/' . $taskId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                $unionId
     * @param string                $taskId
     * @param DeleteTodoTaskRequest $request
     *
     * @return DeleteTodoTaskResponse
     */
    public function deleteTodoTask($unionId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteTodoTaskHeaders([]);

        return $this->deleteTodoTaskWithOptions($unionId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                $unionId
     * @param string                $taskId
     * @param DeleteTodoTaskRequest $request
     * @param DeleteTodoTaskHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return DeleteTodoTaskResponse
     */
    public function deleteTodoTaskWithOptions($unionId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
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

        return DeleteTodoTaskResponse::fromMap($this->doROARequest('DeleteTodoTask', 'todo_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/todo/users/' . $unionId . '/tasks/' . $taskId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                      $unionId
     * @param CreateTodoTypeConfigRequest $request
     *
     * @return CreateTodoTypeConfigResponse
     */
    public function createTodoTypeConfig($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTodoTypeConfigHeaders([]);

        return $this->createTodoTypeConfigWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $unionId
     * @param CreateTodoTypeConfigRequest $request
     * @param CreateTodoTypeConfigHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return CreateTodoTypeConfigResponse
     */
    public function createTodoTypeConfigWithOptions($unionId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->cardType)) {
            @$body['cardType'] = $request->cardType;
        }
        if (!Utils::isUnset($request->icon)) {
            @$body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->pcDetailUrlOpenMode)) {
            @$body['pcDetailUrlOpenMode'] = $request->pcDetailUrlOpenMode;
        }
        if (!Utils::isUnset($request->contentFieldList)) {
            @$body['contentFieldList'] = $request->contentFieldList;
        }
        if (!Utils::isUnset($request->actionList)) {
            @$body['actionList'] = $request->actionList;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateTodoTypeConfigResponse::fromMap($this->doROARequest('CreateTodoTypeConfig', 'todo_1.0', 'HTTP', 'POST', 'AK', '/v1.0/todo/users/' . $unionId . '/configs/types', 'json', $req, $runtime));
    }

    /**
     * @param string                $unionId
     * @param string                $taskId
     * @param UpdateTodoTaskRequest $request
     *
     * @return UpdateTodoTaskResponse
     */
    public function updateTodoTask($unionId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTodoTaskHeaders([]);

        return $this->updateTodoTaskWithOptions($unionId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                $unionId
     * @param string                $taskId
     * @param UpdateTodoTaskRequest $request
     * @param UpdateTodoTaskHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return UpdateTodoTaskResponse
     */
    public function updateTodoTaskWithOptions($unionId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->subject)) {
            @$body['subject'] = $request->subject;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->dueTime)) {
            @$body['dueTime'] = $request->dueTime;
        }
        if (!Utils::isUnset($request->done)) {
            @$body['done'] = $request->done;
        }
        if (!Utils::isUnset($request->executorIds)) {
            @$body['executorIds'] = $request->executorIds;
        }
        if (!Utils::isUnset($request->participantIds)) {
            @$body['participantIds'] = $request->participantIds;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateTodoTaskResponse::fromMap($this->doROARequest('UpdateTodoTask', 'todo_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/todo/users/' . $unionId . '/tasks/' . $taskId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                $unionId
     * @param CreateTodoTaskRequest $request
     *
     * @return CreateTodoTaskResponse
     */
    public function createTodoTask($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTodoTaskHeaders([]);

        return $this->createTodoTaskWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @param string                $unionId
     * @param CreateTodoTaskRequest $request
     * @param CreateTodoTaskHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreateTodoTaskResponse
     */
    public function createTodoTaskWithOptions($unionId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->sourceId)) {
            @$body['sourceId'] = $request->sourceId;
        }
        if (!Utils::isUnset($request->subject)) {
            @$body['subject'] = $request->subject;
        }
        if (!Utils::isUnset($request->creatorId)) {
            @$body['creatorId'] = $request->creatorId;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->dueTime)) {
            @$body['dueTime'] = $request->dueTime;
        }
        if (!Utils::isUnset($request->executorIds)) {
            @$body['executorIds'] = $request->executorIds;
        }
        if (!Utils::isUnset($request->participantIds)) {
            @$body['participantIds'] = $request->participantIds;
        }
        if (!Utils::isUnset($request->detailUrl)) {
            @$body['detailUrl'] = $request->detailUrl;
        }
        if (!Utils::isUnset($request->cardTypeId)) {
            @$body['cardTypeId'] = $request->cardTypeId;
        }
        if (!Utils::isUnset($request->contentFieldList)) {
            @$body['contentFieldList'] = $request->contentFieldList;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateTodoTaskResponse::fromMap($this->doROARequest('CreateTodoTask', 'todo_1.0', 'HTTP', 'POST', 'AK', '/v1.0/todo/users/' . $unionId . '/tasks', 'json', $req, $runtime));
    }
}
