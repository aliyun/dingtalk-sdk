<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\CreateEnterpriseTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\CreateEnterpriseTodoTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\CreateEnterpriseTodoTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\DeleteCategorySourceConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\DeleteCategorySourceConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\DeleteCategorySourceConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\DeleteTodoEETaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\DeleteTodoEETaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\DeleteTodoEETaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetCategorySourceConfigListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetCategorySourceConfigListRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetCategorySourceConfigListResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetUserTaskListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetUserTaskListRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetUserTaskListResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\RegisterCategorySourceConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\RegisterCategorySourceConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\RegisterCategorySourceConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateCategorySourceConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateCategorySourceConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateCategorySourceConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateUserTaskStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateUserTaskStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateUserTaskStatusResponse;
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
     * @summary 创建企业待办
     *  *
     * @param CreateEnterpriseTodoTaskRequest $request CreateEnterpriseTodoTaskRequest
     * @param CreateEnterpriseTodoTaskHeaders $headers CreateEnterpriseTodoTaskHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateEnterpriseTodoTaskResponse CreateEnterpriseTodoTaskResponse
     */
    public function createEnterpriseTodoTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCategoryId)) {
            $body['bizCategoryId'] = $request->bizCategoryId;
        }
        if (!Utils::isUnset($request->customFields)) {
            $body['customFields'] = $request->customFields;
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
        if (!Utils::isUnset($request->notifyConfigs)) {
            $body['notifyConfigs'] = $request->notifyConfigs;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->priority)) {
            $body['priority'] = $request->priority;
        }
        if (!Utils::isUnset($request->sourceId)) {
            $body['sourceId'] = $request->sourceId;
        }
        if (!Utils::isUnset($request->sourceTitle)) {
            $body['sourceTitle'] = $request->sourceTitle;
        }
        if (!Utils::isUnset($request->subject)) {
            $body['subject'] = $request->subject;
        }
        if (!Utils::isUnset($request->trackerIds)) {
            $body['trackerIds'] = $request->trackerIds;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
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
            'action'      => 'CreateEnterpriseTodoTask',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/users/tasks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateEnterpriseTodoTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建企业待办
     *  *
     * @param CreateEnterpriseTodoTaskRequest $request CreateEnterpriseTodoTaskRequest
     *
     * @return CreateEnterpriseTodoTaskResponse CreateEnterpriseTodoTaskResponse
     */
    public function createEnterpriseTodoTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateEnterpriseTodoTaskHeaders([]);

        return $this->createEnterpriseTodoTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除应用类目信息
     *  *
     * @param DeleteCategorySourceConfigRequest $request DeleteCategorySourceConfigRequest
     * @param DeleteCategorySourceConfigHeaders $headers DeleteCategorySourceConfigHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteCategorySourceConfigResponse DeleteCategorySourceConfigResponse
     */
    public function deleteCategorySourceConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCategoryId)) {
            $body['bizCategoryId'] = $request->bizCategoryId;
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
            'action'      => 'DeleteCategorySourceConfig',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/apps/categories/sourceConfigs/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteCategorySourceConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除应用类目信息
     *  *
     * @param DeleteCategorySourceConfigRequest $request DeleteCategorySourceConfigRequest
     *
     * @return DeleteCategorySourceConfigResponse DeleteCategorySourceConfigResponse
     */
    public function deleteCategorySourceConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteCategorySourceConfigHeaders([]);

        return $this->deleteCategorySourceConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除待办
     *  *
     * @param DeleteTodoEETaskRequest $request DeleteTodoEETaskRequest
     * @param DeleteTodoEETaskHeaders $headers DeleteTodoEETaskHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteTodoEETaskResponse DeleteTodoEETaskResponse
     */
    public function deleteTodoEETaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->taskIds)) {
            $body['taskIds'] = $request->taskIds;
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
            'action'      => 'DeleteTodoEETask',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/users/tasks/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteTodoEETaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除待办
     *  *
     * @param DeleteTodoEETaskRequest $request DeleteTodoEETaskRequest
     *
     * @return DeleteTodoEETaskResponse DeleteTodoEETaskResponse
     */
    public function deleteTodoEETask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteTodoEETaskHeaders([]);

        return $this->deleteTodoEETaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询应用注册类目信息列表
     *  *
     * @param GetCategorySourceConfigListRequest $request GetCategorySourceConfigListRequest
     * @param GetCategorySourceConfigListHeaders $headers GetCategorySourceConfigListHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCategorySourceConfigListResponse GetCategorySourceConfigListResponse
     */
    public function getCategorySourceConfigListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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
            'action'      => 'GetCategorySourceConfigList',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/apps/categories/sourceConfigs/lists/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCategorySourceConfigListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询应用注册类目信息列表
     *  *
     * @param GetCategorySourceConfigListRequest $request GetCategorySourceConfigListRequest
     *
     * @return GetCategorySourceConfigListResponse GetCategorySourceConfigListResponse
     */
    public function getCategorySourceConfigList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCategorySourceConfigListHeaders([]);

        return $this->getCategorySourceConfigListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户待办列表
     *  *
     * @param GetUserTaskListRequest $request GetUserTaskListRequest
     * @param GetUserTaskListHeaders $headers GetUserTaskListHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserTaskListResponse GetUserTaskListResponse
     */
    public function getUserTaskListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->done)) {
            $body['done'] = $request->done;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
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
            'action'      => 'GetUserTaskList',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/users/tasks/list',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserTaskListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户待办列表
     *  *
     * @param GetUserTaskListRequest $request GetUserTaskListRequest
     *
     * @return GetUserTaskListResponse GetUserTaskListResponse
     */
    public function getUserTaskList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserTaskListHeaders([]);

        return $this->getUserTaskListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 注册应用类目信息
     *  *
     * @param RegisterCategorySourceConfigRequest $request RegisterCategorySourceConfigRequest
     * @param RegisterCategorySourceConfigHeaders $headers RegisterCategorySourceConfigHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return RegisterCategorySourceConfigResponse RegisterCategorySourceConfigResponse
     */
    public function registerCategorySourceConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCategoryId)) {
            $body['bizCategoryId'] = $request->bizCategoryId;
        }
        if (!Utils::isUnset($request->bizCategoryName)) {
            $body['bizCategoryName'] = $request->bizCategoryName;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'action'      => 'RegisterCategorySourceConfig',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/apps/categories/sourceConfigs/register',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RegisterCategorySourceConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 注册应用类目信息
     *  *
     * @param RegisterCategorySourceConfigRequest $request RegisterCategorySourceConfigRequest
     *
     * @return RegisterCategorySourceConfigResponse RegisterCategorySourceConfigResponse
     */
    public function registerCategorySourceConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterCategorySourceConfigHeaders([]);

        return $this->registerCategorySourceConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改应用类目注册信息
     *  *
     * @param UpdateCategorySourceConfigRequest $request UpdateCategorySourceConfigRequest
     * @param UpdateCategorySourceConfigHeaders $headers UpdateCategorySourceConfigHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateCategorySourceConfigResponse UpdateCategorySourceConfigResponse
     */
    public function updateCategorySourceConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCategoryId)) {
            $body['bizCategoryId'] = $request->bizCategoryId;
        }
        if (!Utils::isUnset($request->bizCategoryName)) {
            $body['bizCategoryName'] = $request->bizCategoryName;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'action'      => 'UpdateCategorySourceConfig',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/apps/categories/sourceConfigs',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateCategorySourceConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改应用类目注册信息
     *  *
     * @param UpdateCategorySourceConfigRequest $request UpdateCategorySourceConfigRequest
     *
     * @return UpdateCategorySourceConfigResponse UpdateCategorySourceConfigResponse
     */
    public function updateCategorySourceConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCategorySourceConfigHeaders([]);

        return $this->updateCategorySourceConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新待办信息
     *  *
     * @param UpdateTaskRequest $request UpdateTaskRequest
     * @param UpdateTaskHeaders $headers UpdateTaskHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTaskResponse UpdateTaskResponse
     */
    public function updateTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
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
        if (!Utils::isUnset($request->subject)) {
            $body['subject'] = $request->subject;
        }
        if (!Utils::isUnset($request->taskId)) {
            $body['taskId'] = $request->taskId;
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
            'action'      => 'UpdateTask',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/users/tasks/infos',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新待办信息
     *  *
     * @param UpdateTaskRequest $request UpdateTaskRequest
     *
     * @return UpdateTaskResponse UpdateTaskResponse
     */
    public function updateTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskHeaders([]);

        return $this->updateTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新用户的待办状态
     *  *
     * @param UpdateUserTaskStatusRequest $request UpdateUserTaskStatusRequest
     * @param UpdateUserTaskStatusHeaders $headers UpdateUserTaskStatusHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateUserTaskStatusResponse UpdateUserTaskStatusResponse
     */
    public function updateUserTaskStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->userTaskStatuses)) {
            $body['userTaskStatuses'] = $request->userTaskStatuses;
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
            'action'      => 'UpdateUserTaskStatus',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/users/tasks/statuses',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateUserTaskStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新用户的待办状态
     *  *
     * @param UpdateUserTaskStatusRequest $request UpdateUserTaskStatusRequest
     *
     * @return UpdateUserTaskStatusResponse UpdateUserTaskStatusResponse
     */
    public function updateUserTaskStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateUserTaskStatusHeaders([]);

        return $this->updateUserTaskStatusWithOptions($request, $headers, $runtime);
    }
}
