<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateOrganizationTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateOrganizationTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateOrganizationTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetFreeTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetFreeTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetFreeTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetTbUserIdByDingUserIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetTbUserIdByDingUserIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetTbUserIdByDingUserIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\QueryTasksV3Headers;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\QueryTasksV3Request;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\QueryTasksV3Response;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchAllTasksByTqlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchAllTasksByTqlRequest;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchAllTasksByTqlResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchProjectsV3Headers;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchProjectsV3Request;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchProjectsV3Response;
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
        $this->_productId    = 'dingtalk';
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 创建自由任务
     *  *
     * @param string                        $userId
     * @param CreateOrganizationTaskRequest $request CreateOrganizationTaskRequest
     * @param CreateOrganizationTaskHeaders $headers CreateOrganizationTaskHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateOrganizationTaskResponse CreateOrganizationTaskResponse
     */
    public function createOrganizationTaskWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->disableActivity)) {
            $body['disableActivity'] = $request->disableActivity;
        }
        if (!Utils::isUnset($request->disableNotification)) {
            $body['disableNotification'] = $request->disableNotification;
        }
        if (!Utils::isUnset($request->dueDate)) {
            $body['dueDate'] = $request->dueDate;
        }
        if (!Utils::isUnset($request->executorId)) {
            $body['executorId'] = $request->executorId;
        }
        if (!Utils::isUnset($request->involveMembers)) {
            $body['involveMembers'] = $request->involveMembers;
        }
        if (!Utils::isUnset($request->note)) {
            $body['note'] = $request->note;
        }
        if (!Utils::isUnset($request->visible)) {
            $body['visible'] = $request->visible;
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
            'action'      => 'CreateOrganizationTask',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/organizations/users/' . $userId . '/tasks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateOrganizationTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建自由任务
     *  *
     * @param string                        $userId
     * @param CreateOrganizationTaskRequest $request CreateOrganizationTaskRequest
     *
     * @return CreateOrganizationTaskResponse CreateOrganizationTaskResponse
     */
    public function createOrganizationTask($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateOrganizationTaskHeaders([]);

        return $this->createOrganizationTaskWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建协作空间任务
     *  *
     * @param string            $userId
     * @param CreateTaskRequest $request CreateTaskRequest
     * @param CreateTaskHeaders $headers CreateTaskHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTaskResponse CreateTaskResponse
     */
    public function createTaskWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->customfields)) {
            $body['customfields'] = $request->customfields;
        }
        if (!Utils::isUnset($request->dueDate)) {
            $body['dueDate'] = $request->dueDate;
        }
        if (!Utils::isUnset($request->executorId)) {
            $body['executorId'] = $request->executorId;
        }
        if (!Utils::isUnset($request->note)) {
            $body['note'] = $request->note;
        }
        if (!Utils::isUnset($request->projectId)) {
            $body['projectId'] = $request->projectId;
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
            'action'      => 'CreateTask',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/users/' . $userId . '/tasks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建协作空间任务
     *  *
     * @param string            $userId
     * @param CreateTaskRequest $request CreateTaskRequest
     *
     * @return CreateTaskResponse CreateTaskResponse
     */
    public function createTask($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTaskHeaders([]);

        return $this->createTaskWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询轻任务详情。
     *  *
     * @param string             $taskId
     * @param GetFreeTaskRequest $request GetFreeTaskRequest
     * @param GetFreeTaskHeaders $headers GetFreeTaskHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFreeTaskResponse GetFreeTaskResponse
     */
    public function getFreeTaskWithOptions($taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
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
            'action'      => 'GetFreeTask',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/organizations/tasks/' . $taskId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFreeTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询轻任务详情。
     *  *
     * @param string             $taskId
     * @param GetFreeTaskRequest $request GetFreeTaskRequest
     *
     * @return GetFreeTaskResponse GetFreeTaskResponse
     */
    public function getFreeTask($taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFreeTaskHeaders([]);

        return $this->getFreeTaskWithOptions($taskId, $request, $headers, $runtime);
    }

    /**
     * @summary 钉钉 userId 查询 24位长 userId。
     *  *
     * @param GetTbUserIdByDingUserIdRequest $request GetTbUserIdByDingUserIdRequest
     * @param GetTbUserIdByDingUserIdHeaders $headers GetTbUserIdByDingUserIdHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTbUserIdByDingUserIdResponse GetTbUserIdByDingUserIdResponse
     */
    public function getTbUserIdByDingUserIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->dingUserIds)) {
            $query['dingUserIds'] = $request->dingUserIds;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
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
            'action'      => 'GetTbUserIdByDingUserId',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/idmaps/userIds',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTbUserIdByDingUserIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 钉钉 userId 查询 24位长 userId。
     *  *
     * @param GetTbUserIdByDingUserIdRequest $request GetTbUserIdByDingUserIdRequest
     *
     * @return GetTbUserIdByDingUserIdResponse GetTbUserIdByDingUserIdResponse
     */
    public function getTbUserIdByDingUserId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTbUserIdByDingUserIdHeaders([]);

        return $this->getTbUserIdByDingUserIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询协作空间任务详情。
     *  *
     * @param string              $userId
     * @param QueryTasksV3Request $request QueryTasksV3Request
     * @param QueryTasksV3Headers $headers QueryTasksV3Headers
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryTasksV3Response QueryTasksV3Response
     */
    public function queryTasksV3WithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->parentTaskId)) {
            $query['parentTaskId'] = $request->parentTaskId;
        }
        if (!Utils::isUnset($request->shortIds)) {
            $query['shortIds'] = $request->shortIds;
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
            'action'      => 'QueryTasksV3',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/user/' . $userId . '/tasks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryTasksV3Response::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询协作空间任务详情。
     *  *
     * @param string              $userId
     * @param QueryTasksV3Request $request QueryTasksV3Request
     *
     * @return QueryTasksV3Response QueryTasksV3Response
     */
    public function queryTasksV3($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTasksV3Headers([]);

        return $this->queryTasksV3WithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 通过TQL搜索自由任务和协作空间任务ID。
     *  *
     * @param SearchAllTasksByTqlRequest $request SearchAllTasksByTqlRequest
     * @param SearchAllTasksByTqlHeaders $headers SearchAllTasksByTqlHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchAllTasksByTqlResponse SearchAllTasksByTqlResponse
     */
    public function searchAllTasksByTqlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->tql)) {
            $query['tql'] = $request->tql;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
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
            'action'      => 'SearchAllTasksByTql',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/taskIds',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchAllTasksByTqlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过TQL搜索自由任务和协作空间任务ID。
     *  *
     * @param SearchAllTasksByTqlRequest $request SearchAllTasksByTqlRequest
     *
     * @return SearchAllTasksByTqlResponse SearchAllTasksByTqlResponse
     */
    public function searchAllTasksByTql($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchAllTasksByTqlHeaders([]);

        return $this->searchAllTasksByTqlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询协作空间。
     *  *
     * @param SearchProjectsV3Request $request SearchProjectsV3Request
     * @param SearchProjectsV3Headers $headers SearchProjectsV3Headers
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchProjectsV3Response SearchProjectsV3Response
     */
    public function searchProjectsV3WithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->includeTemplate)) {
            $query['includeTemplate'] = $request->includeTemplate;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->name)) {
            $query['name'] = $request->name;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->projectIds)) {
            $query['projectIds'] = $request->projectIds;
        }
        if (!Utils::isUnset($request->sourceId)) {
            $query['sourceId'] = $request->sourceId;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
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
            'action'      => 'SearchProjectsV3',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/projects',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchProjectsV3Response::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询协作空间。
     *  *
     * @param SearchProjectsV3Request $request SearchProjectsV3Request
     *
     * @return SearchProjectsV3Response SearchProjectsV3Response
     */
    public function searchProjectsV3($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchProjectsV3Headers([]);

        return $this->searchProjectsV3WithOptions($request, $headers, $runtime);
    }
}
