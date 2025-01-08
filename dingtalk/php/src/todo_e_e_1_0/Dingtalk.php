<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppCreateEnterpriseTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppCreateEnterpriseTodoTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppCreateEnterpriseTodoTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppDeleteTodoEETaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppDeleteTodoEETaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppDeleteTodoEETaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppGetUserTaskListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppGetUserTaskListRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppGetUserTaskListResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppUpdateTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppUpdateTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppUpdateTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppUpdateUserTaskStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppUpdateUserTaskStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppUpdateUserTaskStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\CreateEnterpriseTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\CreateEnterpriseTodoTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\CreateEnterpriseTodoTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\CreateStandardTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\CreateStandardTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\CreateStandardTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\DeleteCategorySourceConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\DeleteCategorySourceConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\DeleteCategorySourceConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\DeleteTodoEETaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\DeleteTodoEETaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\DeleteTodoEETaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetCategorySourceConfigListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetCategorySourceConfigListRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetCategorySourceConfigListResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetTemplateListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetTemplateListRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetTemplateListResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetUserTaskListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetUserTaskListRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetUserTaskListResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\QueryTaskExecutionStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\QueryTaskExecutionStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\QueryTaskExecutionStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\RegisterCategorySourceConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\RegisterCategorySourceConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\RegisterCategorySourceConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateCategorySourceConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateCategorySourceConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateCategorySourceConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateStandardTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateStandardTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\UpdateStandardTemplateResponse;
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
     * @summary 创建专属待办
     *  *
     * @param AppCreateEnterpriseTodoTaskRequest $request AppCreateEnterpriseTodoTaskRequest
     * @param AppCreateEnterpriseTodoTaskHeaders $headers AppCreateEnterpriseTodoTaskHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return AppCreateEnterpriseTodoTaskResponse AppCreateEnterpriseTodoTaskResponse
     */
    public function appCreateEnterpriseTodoTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCategoryId)) {
            $body['bizCategoryId'] = $request->bizCategoryId;
        }
        if (!Utils::isUnset($request->bizCreatedTime)) {
            $body['bizCreatedTime'] = $request->bizCreatedTime;
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
        if (!Utils::isUnset($request->toolbarTemplateKey)) {
            $body['toolbarTemplateKey'] = $request->toolbarTemplateKey;
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
            'action'      => 'AppCreateEnterpriseTodoTask',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/apps/users/tasks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AppCreateEnterpriseTodoTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建专属待办
     *  *
     * @param AppCreateEnterpriseTodoTaskRequest $request AppCreateEnterpriseTodoTaskRequest
     *
     * @return AppCreateEnterpriseTodoTaskResponse AppCreateEnterpriseTodoTaskResponse
     */
    public function appCreateEnterpriseTodoTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AppCreateEnterpriseTodoTaskHeaders([]);

        return $this->appCreateEnterpriseTodoTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除专属待办
     *  *
     * @param AppDeleteTodoEETaskRequest $request AppDeleteTodoEETaskRequest
     * @param AppDeleteTodoEETaskHeaders $headers AppDeleteTodoEETaskHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return AppDeleteTodoEETaskResponse AppDeleteTodoEETaskResponse
     */
    public function appDeleteTodoEETaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
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
            'action'      => 'AppDeleteTodoEETask',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/apps/users/tasks/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AppDeleteTodoEETaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除专属待办
     *  *
     * @param AppDeleteTodoEETaskRequest $request AppDeleteTodoEETaskRequest
     *
     * @return AppDeleteTodoEETaskResponse AppDeleteTodoEETaskResponse
     */
    public function appDeleteTodoEETask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AppDeleteTodoEETaskHeaders([]);

        return $this->appDeleteTodoEETaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户待办列表
     *  *
     * @param AppGetUserTaskListRequest $request AppGetUserTaskListRequest
     * @param AppGetUserTaskListHeaders $headers AppGetUserTaskListHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return AppGetUserTaskListResponse AppGetUserTaskListResponse
     */
    public function appGetUserTaskListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->done)) {
            $body['done'] = $request->done;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'action'      => 'AppGetUserTaskList',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/apps/users/tasks/list',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AppGetUserTaskListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户待办列表
     *  *
     * @param AppGetUserTaskListRequest $request AppGetUserTaskListRequest
     *
     * @return AppGetUserTaskListResponse AppGetUserTaskListResponse
     */
    public function appGetUserTaskList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AppGetUserTaskListHeaders([]);

        return $this->appGetUserTaskListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新专属待办信息
     *  *
     * @param AppUpdateTaskRequest $request AppUpdateTaskRequest
     * @param AppUpdateTaskHeaders $headers AppUpdateTaskHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return AppUpdateTaskResponse AppUpdateTaskResponse
     */
    public function appUpdateTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCreatedTime)) {
            $body['bizCreatedTime'] = $request->bizCreatedTime;
        }
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
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->subject)) {
            $body['subject'] = $request->subject;
        }
        if (!Utils::isUnset($request->taskId)) {
            $body['taskId'] = $request->taskId;
        }
        if (!Utils::isUnset($request->toolbarTemplateKey)) {
            $body['toolbarTemplateKey'] = $request->toolbarTemplateKey;
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
            'action'      => 'AppUpdateTask',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/apps/users/tasks/infos',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AppUpdateTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新专属待办信息
     *  *
     * @param AppUpdateTaskRequest $request AppUpdateTaskRequest
     *
     * @return AppUpdateTaskResponse AppUpdateTaskResponse
     */
    public function appUpdateTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AppUpdateTaskHeaders([]);

        return $this->appUpdateTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新用户的待办状态
     *  *
     * @param AppUpdateUserTaskStatusRequest $request AppUpdateUserTaskStatusRequest
     * @param AppUpdateUserTaskStatusHeaders $headers AppUpdateUserTaskStatusHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return AppUpdateUserTaskStatusResponse AppUpdateUserTaskStatusResponse
     */
    public function appUpdateUserTaskStatusWithOptions($request, $headers, $runtime)
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
            'action'      => 'AppUpdateUserTaskStatus',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/apps/users/tasks/statuses',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AppUpdateUserTaskStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新用户的待办状态
     *  *
     * @param AppUpdateUserTaskStatusRequest $request AppUpdateUserTaskStatusRequest
     *
     * @return AppUpdateUserTaskStatusResponse AppUpdateUserTaskStatusResponse
     */
    public function appUpdateUserTaskStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AppUpdateUserTaskStatusHeaders([]);

        return $this->appUpdateUserTaskStatusWithOptions($request, $headers, $runtime);
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
     * @summary 创建专属待办模板实例
     *  *
     * @param CreateStandardTemplateRequest $request CreateStandardTemplateRequest
     * @param CreateStandardTemplateHeaders $headers CreateStandardTemplateHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateStandardTemplateResponse CreateStandardTemplateResponse
     */
    public function createStandardTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actions)) {
            $body['actions'] = $request->actions;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->service)) {
            $body['service'] = $request->service;
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
            'action'      => 'CreateStandardTemplate',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/standards/templates',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateStandardTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建专属待办模板实例
     *  *
     * @param CreateStandardTemplateRequest $request CreateStandardTemplateRequest
     *
     * @return CreateStandardTemplateResponse CreateStandardTemplateResponse
     */
    public function createStandardTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateStandardTemplateHeaders([]);

        return $this->createStandardTemplateWithOptions($request, $headers, $runtime);
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
        $query = [];
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
     * @summary 查询创建的Template列表
     *  *
     * @param GetTemplateListRequest $request GetTemplateListRequest
     * @param GetTemplateListHeaders $headers GetTemplateListHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTemplateListResponse GetTemplateListResponse
     */
    public function getTemplateListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
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
            'action'      => 'GetTemplateList',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/templates/list',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTemplateListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询创建的Template列表
     *  *
     * @param GetTemplateListRequest $request GetTemplateListRequest
     *
     * @return GetTemplateListResponse GetTemplateListResponse
     */
    public function getTemplateList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTemplateListHeaders([]);

        return $this->getTemplateListWithOptions($request, $headers, $runtime);
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
     * @summary 查询任务所有执行人的完成状态
     *  *
     * @param QueryTaskExecutionStatusRequest $request QueryTaskExecutionStatusRequest
     * @param QueryTaskExecutionStatusHeaders $headers QueryTaskExecutionStatusHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryTaskExecutionStatusResponse QueryTaskExecutionStatusResponse
     */
    public function queryTaskExecutionStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->taskId)) {
            $query['taskId'] = $request->taskId;
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
            'action'      => 'QueryTaskExecutionStatus',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/apps/users/tasks/executionStatuses',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryTaskExecutionStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询任务所有执行人的完成状态
     *  *
     * @param QueryTaskExecutionStatusRequest $request QueryTaskExecutionStatusRequest
     *
     * @return QueryTaskExecutionStatusResponse QueryTaskExecutionStatusResponse
     */
    public function queryTaskExecutionStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTaskExecutionStatusHeaders([]);

        return $this->queryTaskExecutionStatusWithOptions($request, $headers, $runtime);
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
     * @summary 更新标准模板
     *  *
     * @param UpdateStandardTemplateRequest $request UpdateStandardTemplateRequest
     * @param UpdateStandardTemplateHeaders $headers UpdateStandardTemplateHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateStandardTemplateResponse UpdateStandardTemplateResponse
     */
    public function updateStandardTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actions)) {
            $body['actions'] = $request->actions;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->service)) {
            $body['service'] = $request->service;
        }
        if (!Utils::isUnset($request->templateKey)) {
            $body['templateKey'] = $request->templateKey;
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
            'action'      => 'UpdateStandardTemplate',
            'version'     => 'todoEE_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/todoEE/standards/templates/infos',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateStandardTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新标准模板
     *  *
     * @param UpdateStandardTemplateRequest $request UpdateStandardTemplateRequest
     *
     * @return UpdateStandardTemplateResponse UpdateStandardTemplateResponse
     */
    public function updateStandardTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateStandardTemplateHeaders([]);

        return $this->updateStandardTemplateWithOptions($request, $headers, $runtime);
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
