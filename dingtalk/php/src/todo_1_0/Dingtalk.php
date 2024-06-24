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
     * @summary 查询用户待办计数
     *  *
     * @param string                $unionId
     * @param CountTodoTasksRequest $request CountTodoTasksRequest
     * @param CountTodoTasksHeaders $headers CountTodoTasksHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CountTodoTasksResponse CountTodoTasksResponse
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
     * @summary 查询用户待办计数
     *  *
     * @param string                $unionId
     * @param CountTodoTasksRequest $request CountTodoTasksRequest
     *
     * @return CountTodoTasksResponse CountTodoTasksResponse
     */
    public function countTodoTasks($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CountTodoTasksHeaders([]);

        return $this->countTodoTasksWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @summary 以用户个人身份创建个人待办
     *  *
     * @param CreatePersonalTodoTaskRequest $request CreatePersonalTodoTaskRequest
     * @param CreatePersonalTodoTaskHeaders $headers CreatePersonalTodoTaskHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CreatePersonalTodoTaskResponse CreatePersonalTodoTaskResponse
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
        if (!Utils::isUnset($request->reminderTimeStamp)) {
            $body['reminderTimeStamp'] = $request->reminderTimeStamp;
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
     * @summary 以用户个人身份创建个人待办
     *  *
     * @param CreatePersonalTodoTaskRequest $request CreatePersonalTodoTaskRequest
     *
     * @return CreatePersonalTodoTaskResponse CreatePersonalTodoTaskResponse
     */
    public function createPersonalTodoTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreatePersonalTodoTaskHeaders([]);

        return $this->createPersonalTodoTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建待办
     *  *
     * @param string                $unionId
     * @param CreateTodoTaskRequest $request CreateTodoTaskRequest
     * @param CreateTodoTaskHeaders $headers CreateTodoTaskHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTodoTaskResponse CreateTodoTaskResponse
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
     * @summary 创建待办
     *  *
     * @param string                $unionId
     * @param CreateTodoTaskRequest $request CreateTodoTaskRequest
     *
     * @return CreateTodoTaskResponse CreateTodoTaskResponse
     */
    public function createTodoTask($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTodoTaskHeaders([]);

        return $this->createTodoTaskWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建待办卡片类型配置
     *  *
     * @param string                      $unionId
     * @param CreateTodoTypeConfigRequest $request CreateTodoTypeConfigRequest
     * @param CreateTodoTypeConfigHeaders $headers CreateTodoTypeConfigHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTodoTypeConfigResponse CreateTodoTypeConfigResponse
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
     * @summary 创建待办卡片类型配置
     *  *
     * @param string                      $unionId
     * @param CreateTodoTypeConfigRequest $request CreateTodoTypeConfigRequest
     *
     * @return CreateTodoTypeConfigResponse CreateTodoTypeConfigResponse
     */
    public function createTodoTypeConfig($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTodoTypeConfigHeaders([]);

        return $this->createTodoTypeConfigWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除待办
     *  *
     * @param string                $unionId
     * @param string                $taskId
     * @param DeleteTodoTaskRequest $request DeleteTodoTaskRequest
     * @param DeleteTodoTaskHeaders $headers DeleteTodoTaskHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteTodoTaskResponse DeleteTodoTaskResponse
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
     * @summary 删除待办
     *  *
     * @param string                $unionId
     * @param string                $taskId
     * @param DeleteTodoTaskRequest $request DeleteTodoTaskRequest
     *
     * @return DeleteTodoTaskResponse DeleteTodoTaskResponse
     */
    public function deleteTodoTask($unionId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteTodoTaskHeaders([]);

        return $this->deleteTodoTaskWithOptions($unionId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询待办
     *  *
     * @param string             $unionId
     * @param string             $taskId
     * @param GetTodoTaskHeaders $headers GetTodoTaskHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTodoTaskResponse GetTodoTaskResponse
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
     * @summary 查询待办
     *  *
     * @param string $unionId
     * @param string $taskId
     *
     * @return GetTodoTaskResponse GetTodoTaskResponse
     */
    public function getTodoTask($unionId, $taskId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTodoTaskHeaders([]);

        return $this->getTodoTaskWithOptions($unionId, $taskId, $headers, $runtime);
    }

    /**
     * @summary 根据sourceId查询待办详情
     *  *
     * @param string                       $unionId
     * @param string                       $sourceId
     * @param GetTodoTaskBySourceIdHeaders $headers  GetTodoTaskBySourceIdHeaders
     * @param RuntimeOptions               $runtime  runtime options for this request RuntimeOptions
     *
     * @return GetTodoTaskBySourceIdResponse GetTodoTaskBySourceIdResponse
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
     * @summary 根据sourceId查询待办详情
     *  *
     * @param string $unionId
     * @param string $sourceId
     *
     * @return GetTodoTaskBySourceIdResponse GetTodoTaskBySourceIdResponse
     */
    public function getTodoTaskBySourceId($unionId, $sourceId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTodoTaskBySourceIdHeaders([]);

        return $this->getTodoTaskBySourceIdWithOptions($unionId, $sourceId, $headers, $runtime);
    }

    /**
     * @summary 专属钉根据待办ID查询待办详情
     *  *
     * @param string                   $taskId
     * @param string                   $unionId
     * @param GetTodoTaskDetailHeaders $headers GetTodoTaskDetailHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTodoTaskDetailResponse GetTodoTaskDetailResponse
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
     * @summary 专属钉根据待办ID查询待办详情
     *  *
     * @param string $taskId
     * @param string $unionId
     *
     * @return GetTodoTaskDetailResponse GetTodoTaskDetailResponse
     */
    public function getTodoTaskDetail($taskId, $unionId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTodoTaskDetailHeaders([]);

        return $this->getTodoTaskDetailWithOptions($taskId, $unionId, $headers, $runtime);
    }

    /**
     * @summary 根据id获取待办卡片类型配置
     *  *
     * @param string                   $unionId
     * @param string                   $cardTypeId
     * @param GetTodoTypeConfigHeaders $headers    GetTodoTypeConfigHeaders
     * @param RuntimeOptions           $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetTodoTypeConfigResponse GetTodoTypeConfigResponse
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
     * @summary 根据id获取待办卡片类型配置
     *  *
     * @param string $unionId
     * @param string $cardTypeId
     *
     * @return GetTodoTypeConfigResponse GetTodoTypeConfigResponse
     */
    public function getTodoTypeConfig($unionId, $cardTypeId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTodoTypeConfigHeaders([]);

        return $this->getTodoTypeConfigWithOptions($unionId, $cardTypeId, $headers, $runtime);
    }

    /**
     * @summary 查询用户企业类型待办列表，支持查询当前企业的一方应用、三方应用、自建应用产生的工作待办数据
     *  *
     * @param string                    $unionId
     * @param QueryOrgTodoByUserRequest $request QueryOrgTodoByUserRequest
     * @param QueryOrgTodoByUserHeaders $headers QueryOrgTodoByUserHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOrgTodoByUserResponse QueryOrgTodoByUserResponse
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
     * @summary 查询用户企业类型待办列表，支持查询当前企业的一方应用、三方应用、自建应用产生的工作待办数据
     *  *
     * @param string                    $unionId
     * @param QueryOrgTodoByUserRequest $request QueryOrgTodoByUserRequest
     *
     * @return QueryOrgTodoByUserResponse QueryOrgTodoByUserResponse
     */
    public function queryOrgTodoByUser($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgTodoByUserHeaders([]);

        return $this->queryOrgTodoByUserWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询企业下用户待办列表
     *  *
     * @param string                   $unionId
     * @param QueryOrgTodoTasksRequest $request QueryOrgTodoTasksRequest
     * @param QueryOrgTodoTasksHeaders $headers QueryOrgTodoTasksHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOrgTodoTasksResponse QueryOrgTodoTasksResponse
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
     * @summary 查询企业下用户待办列表
     *  *
     * @param string                   $unionId
     * @param QueryOrgTodoTasksRequest $request QueryOrgTodoTasksRequest
     *
     * @return QueryOrgTodoTasksResponse QueryOrgTodoTasksResponse
     */
    public function queryOrgTodoTasks($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgTodoTasksHeaders([]);

        return $this->queryOrgTodoTasksWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询用户待办列表
     *  *
     * @param string                $unionId
     * @param QueryTodoTasksRequest $request QueryTodoTasksRequest
     * @param QueryTodoTasksHeaders $headers QueryTodoTasksHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryTodoTasksResponse QueryTodoTasksResponse
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
     * @summary 查询用户待办列表
     *  *
     * @param string                $unionId
     * @param QueryTodoTasksRequest $request QueryTodoTasksRequest
     *
     * @return QueryTodoTasksResponse QueryTodoTasksResponse
     */
    public function queryTodoTasks($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTodoTasksHeaders([]);

        return $this->queryTodoTasksWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新待办
     *  *
     * @param string                $unionId
     * @param string                $taskId
     * @param UpdateTodoTaskRequest $request UpdateTodoTaskRequest
     * @param UpdateTodoTaskHeaders $headers UpdateTodoTaskHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTodoTaskResponse UpdateTodoTaskResponse
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
     * @summary 更新待办
     *  *
     * @param string                $unionId
     * @param string                $taskId
     * @param UpdateTodoTaskRequest $request UpdateTodoTaskRequest
     *
     * @return UpdateTodoTaskResponse UpdateTodoTaskResponse
     */
    public function updateTodoTask($unionId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTodoTaskHeaders([]);

        return $this->updateTodoTaskWithOptions($unionId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新待办执行者状态
     *  *
     * @param string                              $unionId
     * @param string                              $taskId
     * @param UpdateTodoTaskExecutorStatusRequest $request UpdateTodoTaskExecutorStatusRequest
     * @param UpdateTodoTaskExecutorStatusHeaders $headers UpdateTodoTaskExecutorStatusHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTodoTaskExecutorStatusResponse UpdateTodoTaskExecutorStatusResponse
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
     * @summary 更新待办执行者状态
     *  *
     * @param string                              $unionId
     * @param string                              $taskId
     * @param UpdateTodoTaskExecutorStatusRequest $request UpdateTodoTaskExecutorStatusRequest
     *
     * @return UpdateTodoTaskExecutorStatusResponse UpdateTodoTaskExecutorStatusResponse
     */
    public function updateTodoTaskExecutorStatus($unionId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTodoTaskExecutorStatusHeaders([]);

        return $this->updateTodoTaskExecutorStatusWithOptions($unionId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新待办卡片类型配置
     *  *
     * @param string                      $unionId
     * @param string                      $cardTypeId
     * @param UpdateTodoTypeConfigRequest $request    UpdateTodoTypeConfigRequest
     * @param UpdateTodoTypeConfigHeaders $headers    UpdateTodoTypeConfigHeaders
     * @param RuntimeOptions              $runtime    runtime options for this request RuntimeOptions
     *
     * @return UpdateTodoTypeConfigResponse UpdateTodoTypeConfigResponse
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
     * @summary 更新待办卡片类型配置
     *  *
     * @param string                      $unionId
     * @param string                      $cardTypeId
     * @param UpdateTodoTypeConfigRequest $request    UpdateTodoTypeConfigRequest
     *
     * @return UpdateTodoTypeConfigResponse UpdateTodoTypeConfigResponse
     */
    public function updateTodoTypeConfig($unionId, $cardTypeId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTodoTypeConfigHeaders([]);

        return $this->updateTodoTypeConfigWithOptions($unionId, $cardTypeId, $request, $headers, $runtime);
    }
}
