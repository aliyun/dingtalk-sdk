<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CountTodoTasksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CountTodoTasksRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CountTodoTasksResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreatePersonalTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreatePersonalTodoTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreatePersonalTodoTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTypeConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTypeConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTypeConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\DeleteTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\DeleteTodoTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\DeleteTodoTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskBySourceIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskBySourceIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTypeConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTypeConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryOrgTodoByUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryOrgTodoByUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryOrgTodoByUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryOrgTodoTasksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryOrgTodoTasksRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryOrgTodoTasksResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryTodoTasksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryTodoTasksRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryTodoTasksResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTaskExecutorStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTaskExecutorStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTaskExecutorStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTypeConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTypeConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTypeConfigResponse;
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
     * @param string                $unionId
     * @param CountTodoTasksRequest $request
     * @param CountTodoTasksHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CountTodoTasksResponse
     */
    public function countTodoTasksWithOptions($unionId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fromDueTime)) {
            $body['fromDueTime'] = $request->fromDueTime;
        }
        if (!Utils::isUnset($request->isDone)) {
            $body['isDone'] = $request->isDone;
        }
        if (!Utils::isUnset($request->isRecycled)) {
            $body['isRecycled'] = $request->isRecycled;
        }
        if (!Utils::isUnset($request->roleTypes)) {
            $body['roleTypes'] = $request->roleTypes;
        }
        if (!Utils::isUnset($request->toDueTime)) {
            $body['toDueTime'] = $request->toDueTime;
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
            'action'      => 'CountTodoTasks',
            'version'     => 'todo_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todo/users/' . $unionId . '/tasks/count',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CountTodoTasksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                $unionId
     * @param CountTodoTasksRequest $request
     *
     * @return CountTodoTasksResponse
     */
    public function countTodoTasks($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CountTodoTasksHeaders([]);

        return $this->countTodoTasksWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @param CreatePersonalTodoTaskRequest $request
     * @param CreatePersonalTodoTaskHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CreatePersonalTodoTaskResponse
     */
    public function createPersonalTodoTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->dueTime)) {
            $body['dueTime'] = $request->dueTime;
        }
        if (!Utils::isUnset($request->executorIds)) {
            $body['executorIds'] = $request->executorIds;
        }
        if (!Utils::isUnset($request->notifyConfigs)) {
            $body['notifyConfigs'] = $request->notifyConfigs;
        }
        if (!Utils::isUnset($request->participantIds)) {
            $body['participantIds'] = $request->participantIds;
        }
        if (!Utils::isUnset($request->subject)) {
            $body['subject'] = $request->subject;
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
            'action'      => 'CreatePersonalTodoTask',
            'version'     => 'todo_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todo/users/me/personalTasks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreatePersonalTodoTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreatePersonalTodoTaskRequest $request
     *
     * @return CreatePersonalTodoTaskResponse
     */
    public function createPersonalTodoTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreatePersonalTodoTaskHeaders([]);

        return $this->createPersonalTodoTaskWithOptions($request, $headers, $runtime);
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
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->actionList)) {
            $body['actionList'] = $request->actionList;
        }
        if (!Utils::isUnset($request->bizCategoryId)) {
            $body['bizCategoryId'] = $request->bizCategoryId;
        }
        if (!Utils::isUnset($request->contentFieldList)) {
            $body['contentFieldList'] = $request->contentFieldList;
        }
        if (!Utils::isUnset($request->creatorId)) {
            $body['creatorId'] = $request->creatorId;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->detailUrl)) {
            $body['detailUrl'] = $request->detailUrl;
        }
        if (!Utils::isUnset($request->dueTime)) {
            $body['dueTime'] = $request->dueTime;
        }
        if (!Utils::isUnset($request->executorIds)) {
            $body['executorIds'] = $request->executorIds;
        }
        if (!Utils::isUnset($request->isOnlyShowExecutor)) {
            $body['isOnlyShowExecutor'] = $request->isOnlyShowExecutor;
        }
        if (!Utils::isUnset($request->notifyConfigs)) {
            $body['notifyConfigs'] = $request->notifyConfigs;
        }
        if (!Utils::isUnset($request->participantIds)) {
            $body['participantIds'] = $request->participantIds;
        }
        if (!Utils::isUnset($request->priority)) {
            $body['priority'] = $request->priority;
        }
        if (!Utils::isUnset($request->sourceId)) {
            $body['sourceId'] = $request->sourceId;
        }
        if (!Utils::isUnset($request->subject)) {
            $body['subject'] = $request->subject;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateTodoTask',
            'version'     => 'todo_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todo/users/' . $unionId . '/tasks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateTodoTaskResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->actionList)) {
            $body['actionList'] = $request->actionList;
        }
        if (!Utils::isUnset($request->cardType)) {
            $body['cardType'] = $request->cardType;
        }
        if (!Utils::isUnset($request->contentFieldList)) {
            $body['contentFieldList'] = $request->contentFieldList;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->pcDetailUrlOpenMode)) {
            $body['pcDetailUrlOpenMode'] = $request->pcDetailUrlOpenMode;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateTodoTypeConfig',
            'version'     => 'todo_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todo/users/' . $unionId . '/configs/types',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateTodoTypeConfigResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'DeleteTodoTask',
            'version'     => 'todo_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todo/users/' . $unionId . '/tasks/' . $taskId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteTodoTaskResponse::fromMap($this->execute($params, $req, $runtime));
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
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetTodoTask',
            'version'     => 'todo_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todo/users/' . $unionId . '/tasks/' . $taskId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTodoTaskResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param string                       $unionId
     * @param string                       $sourceId
     * @param GetTodoTaskBySourceIdHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GetTodoTaskBySourceIdResponse
     */
    public function getTodoTaskBySourceIdWithOptions($unionId, $sourceId, $headers, $runtime)
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
            'action'      => 'GetTodoTaskBySourceId',
            'version'     => 'todo_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todo/users/' . $unionId . '/tasks/sources/' . $sourceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTodoTaskBySourceIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $unionId
     * @param string $sourceId
     *
     * @return GetTodoTaskBySourceIdResponse
     */
    public function getTodoTaskBySourceId($unionId, $sourceId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTodoTaskBySourceIdHeaders([]);

        return $this->getTodoTaskBySourceIdWithOptions($unionId, $sourceId, $headers, $runtime);
    }

    /**
     * @param string                   $taskId
     * @param string                   $unionId
     * @param GetTodoTaskDetailHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetTodoTaskDetailResponse
     */
    public function getTodoTaskDetailWithOptions($taskId, $unionId, $headers, $runtime)
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
            'action'      => 'GetTodoTaskDetail',
            'version'     => 'todo_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todo/exclusive/users/' . $unionId . '/tasks/' . $taskId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTodoTaskDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $taskId
     * @param string $unionId
     *
     * @return GetTodoTaskDetailResponse
     */
    public function getTodoTaskDetail($taskId, $unionId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTodoTaskDetailHeaders([]);

        return $this->getTodoTaskDetailWithOptions($taskId, $unionId, $headers, $runtime);
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
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetTodoTypeConfig',
            'version'     => 'todo_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todo/users/' . $unionId . '/configs/types/' . $cardTypeId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTodoTypeConfigResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param string                    $unionId
     * @param QueryOrgTodoByUserRequest $request
     * @param QueryOrgTodoByUserHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryOrgTodoByUserResponse
     */
    public function queryOrgTodoByUserWithOptions($unionId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fromDueTime)) {
            $body['fromDueTime'] = $request->fromDueTime;
        }
        if (!Utils::isUnset($request->isDone)) {
            $body['isDone'] = $request->isDone;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->orderBy)) {
            $body['orderBy'] = $request->orderBy;
        }
        if (!Utils::isUnset($request->orderDirection)) {
            $body['orderDirection'] = $request->orderDirection;
        }
        if (!Utils::isUnset($request->roleTypes)) {
            $body['roleTypes'] = $request->roleTypes;
        }
        if (!Utils::isUnset($request->subject)) {
            $body['subject'] = $request->subject;
        }
        if (!Utils::isUnset($request->toDueTime)) {
            $body['toDueTime'] = $request->toDueTime;
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
            'action'      => 'QueryOrgTodoByUser',
            'version'     => 'todo_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todo/users/' . $unionId . '/organizations/tasks/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryOrgTodoByUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                    $unionId
     * @param QueryOrgTodoByUserRequest $request
     *
     * @return QueryOrgTodoByUserResponse
     */
    public function queryOrgTodoByUser($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgTodoByUserHeaders([]);

        return $this->queryOrgTodoByUserWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @param string                   $unionId
     * @param QueryOrgTodoTasksRequest $request
     * @param QueryOrgTodoTasksHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return QueryOrgTodoTasksResponse
     */
    public function queryOrgTodoTasksWithOptions($unionId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->isDone)) {
            $body['isDone'] = $request->isDone;
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
            'action'      => 'QueryOrgTodoTasks',
            'version'     => 'todo_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todo/users/' . $unionId . '/org/tasks/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryOrgTodoTasksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                   $unionId
     * @param QueryOrgTodoTasksRequest $request
     *
     * @return QueryOrgTodoTasksResponse
     */
    public function queryOrgTodoTasks($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgTodoTasksHeaders([]);

        return $this->queryOrgTodoTasksWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @param string                $unionId
     * @param QueryTodoTasksRequest $request
     * @param QueryTodoTasksHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryTodoTasksResponse
     */
    public function queryTodoTasksWithOptions($unionId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->category)) {
            $body['category'] = $request->category;
        }
        if (!Utils::isUnset($request->fromDueTime)) {
            $body['fromDueTime'] = $request->fromDueTime;
        }
        if (!Utils::isUnset($request->isDone)) {
            $body['isDone'] = $request->isDone;
        }
        if (!Utils::isUnset($request->isRecycled)) {
            $body['isRecycled'] = $request->isRecycled;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->orderBy)) {
            $body['orderBy'] = $request->orderBy;
        }
        if (!Utils::isUnset($request->orderDirection)) {
            $body['orderDirection'] = $request->orderDirection;
        }
        if (!Utils::isUnset($request->roleTypes)) {
            $body['roleTypes'] = $request->roleTypes;
        }
        if (!Utils::isUnset($request->toDueTime)) {
            $body['toDueTime'] = $request->toDueTime;
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
            'action'      => 'QueryTodoTasks',
            'version'     => 'todo_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todo/users/' . $unionId . '/tasks/list',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryTodoTasksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                $unionId
     * @param QueryTodoTasksRequest $request
     *
     * @return QueryTodoTasksResponse
     */
    public function queryTodoTasks($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTodoTasksHeaders([]);

        return $this->queryTodoTasksWithOptions($unionId, $request, $headers, $runtime);
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
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->done)) {
            $body['done'] = $request->done;
        }
        if (!Utils::isUnset($request->dueTime)) {
            $body['dueTime'] = $request->dueTime;
        }
        if (!Utils::isUnset($request->executorIds)) {
            $body['executorIds'] = $request->executorIds;
        }
        if (!Utils::isUnset($request->participantIds)) {
            $body['participantIds'] = $request->participantIds;
        }
        if (!Utils::isUnset($request->subject)) {
            $body['subject'] = $request->subject;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateTodoTask',
            'version'     => 'todo_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todo/users/' . $unionId . '/tasks/' . $taskId . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateTodoTaskResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param string                              $unionId
     * @param string                              $taskId
     * @param UpdateTodoTaskExecutorStatusRequest $request
     * @param UpdateTodoTaskExecutorStatusHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return UpdateTodoTaskExecutorStatusResponse
     */
    public function updateTodoTaskExecutorStatusWithOptions($unionId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->executorStatusList)) {
            $body['executorStatusList'] = $request->executorStatusList;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateTodoTaskExecutorStatus',
            'version'     => 'todo_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todo/users/' . $unionId . '/tasks/' . $taskId . '/executorStatus',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateTodoTaskExecutorStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                              $unionId
     * @param string                              $taskId
     * @param UpdateTodoTaskExecutorStatusRequest $request
     *
     * @return UpdateTodoTaskExecutorStatusResponse
     */
    public function updateTodoTaskExecutorStatus($unionId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTodoTaskExecutorStatusHeaders([]);

        return $this->updateTodoTaskExecutorStatusWithOptions($unionId, $taskId, $request, $headers, $runtime);
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
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->actionList)) {
            $body['actionList'] = $request->actionList;
        }
        if (!Utils::isUnset($request->cardType)) {
            $body['cardType'] = $request->cardType;
        }
        if (!Utils::isUnset($request->contentFieldList)) {
            $body['contentFieldList'] = $request->contentFieldList;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->pcDetailUrlOpenMode)) {
            $body['pcDetailUrlOpenMode'] = $request->pcDetailUrlOpenMode;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateTodoTypeConfig',
            'version'     => 'todo_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todo/users/' . $unionId . '/configs/types/' . $cardTypeId . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateTodoTypeConfigResponse::fromMap($this->execute($params, $req, $runtime));
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
}
