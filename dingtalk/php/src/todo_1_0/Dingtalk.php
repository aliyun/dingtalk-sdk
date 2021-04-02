<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\DeleteTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\DeleteTodoTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\DeleteTodoTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTaskResponse;
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
     * @param string $userId
     * @param string $taskId
     *
     * @return GetTodoTaskResponse
     */
    public function getTodoTask($userId, $taskId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTodoTaskHeaders([]);

        return $this->getTodoTaskWithOptions($userId, $taskId, $headers, $runtime);
    }

    /**
     * @param string             $userId
     * @param string             $taskId
     * @param GetTodoTaskHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetTodoTaskResponse
     */
    public function getTodoTaskWithOptions($userId, $taskId, $headers, $runtime)
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

        return GetTodoTaskResponse::fromMap($this->doROARequest('GetTodoTask', 'todo_1.0', 'HTTP', 'GET', 'AK', '/v1.0/todo/users/' . $userId . '/tasks/' . $taskId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                $userId
     * @param string                $taskId
     * @param DeleteTodoTaskRequest $request
     *
     * @return DeleteTodoTaskResponse
     */
    public function deleteTodoTask($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteTodoTaskHeaders([]);

        return $this->deleteTodoTaskWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param string                $taskId
     * @param DeleteTodoTaskRequest $request
     * @param DeleteTodoTaskHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return DeleteTodoTaskResponse
     */
    public function deleteTodoTaskWithOptions($userId, $taskId, $request, $headers, $runtime)
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

        return DeleteTodoTaskResponse::fromMap($this->doROARequest('DeleteTodoTask', 'todo_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/todo/users/' . $userId . '/tasks/' . $taskId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                $userId
     * @param string                $taskId
     * @param UpdateTodoTaskRequest $request
     *
     * @return UpdateTodoTaskResponse
     */
    public function updateTodoTask($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTodoTaskHeaders([]);

        return $this->updateTodoTaskWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param string                $taskId
     * @param UpdateTodoTaskRequest $request
     * @param UpdateTodoTaskHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return UpdateTodoTaskResponse
     */
    public function updateTodoTaskWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->sucject)) {
            @$body['sucject'] = $request->sucject;
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
        if (!Utils::isUnset($request->detailUrl)) {
            @$body['detailUrl'] = $request->detailUrl;
        }
        if (!Utils::isUnset($request->recurrence)) {
            @$body['recurrence'] = $request->recurrence;
        }
        if (!Utils::isUnset($request->reminder)) {
            @$body['reminder'] = $request->reminder;
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

        return UpdateTodoTaskResponse::fromMap($this->doROARequest('UpdateTodoTask', 'todo_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/todo/users/' . $userId . '/tasks/' . $taskId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                $userId
     * @param CreateTodoTaskRequest $request
     *
     * @return CreateTodoTaskResponse
     */
    public function createTodoTask($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTodoTaskHeaders([]);

        return $this->createTodoTaskWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param CreateTodoTaskRequest $request
     * @param CreateTodoTaskHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreateTodoTaskResponse
     */
    public function createTodoTaskWithOptions($userId, $request, $headers, $runtime)
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
        if (!Utils::isUnset($request->recurrence)) {
            @$body['recurrence'] = $request->recurrence;
        }
        if (!Utils::isUnset($request->reminder)) {
            @$body['reminder'] = $request->reminder;
        }
        if (!Utils::isUnset($request->notifyConfigs)) {
            @$body['notifyConfigs'] = $request->notifyConfigs;
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

        return CreateTodoTaskResponse::fromMap($this->doROARequest('CreateTodoTask', 'todo_1.0', 'HTTP', 'POST', 'AK', '/v1.0/todo/users/' . $userId . '/tasks', 'json', $req, $runtime));
    }
}
