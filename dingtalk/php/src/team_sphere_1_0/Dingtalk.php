<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\AnalysisReportHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\AnalysisReportRequest;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\AnalysisReportResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateOrganizationTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateOrganizationTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateOrganizationTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateProjectMembersV3Headers;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateProjectMembersV3Request;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateProjectMembersV3Response;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateProjectV3Headers;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateProjectV3Request;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateProjectV3Response;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\DeleteProjectMembersV3Headers;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\DeleteProjectMembersV3Request;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\DeleteProjectMembersV3Response;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetFootprintProjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetFootprintProjectResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetFootprintTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetFootprintTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetFreeTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetFreeTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetFreeTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetProjectMembersV3Headers;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetProjectMembersV3Request;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetProjectMembersV3Response;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetProjectRolesV3Headers;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetProjectRolesV3Request;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetProjectRolesV3Response;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetTbUserIdByDingUserIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetTbUserIdByDingUserIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetTbUserIdByDingUserIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetThingOrgIdByDingOrgIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetThingOrgIdByDingOrgIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetUserJoinedProjectsV3Headers;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetUserJoinedProjectsV3Request;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetUserJoinedProjectsV3Response;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListAllTaskViewHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListAllTaskViewResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListMyShortcutViewsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListMyShortcutViewsRequest;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListMyShortcutViewsResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\QueryAllTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\QueryAllTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\QueryAllTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\QueryTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\QueryTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\QueryTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\QueryTasksV3Headers;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\QueryTasksV3Request;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\QueryTasksV3Response;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchAllTasksByTqlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchAllTasksByTqlRequest;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchAllTasksByTqlResponse;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchProjectsV3Headers;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchProjectsV3Request;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchProjectsV3Response;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\UpdateProjectMemberRoleV3Headers;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\UpdateProjectMemberRoleV3Request;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\UpdateProjectMemberRoleV3Response;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\UpdateProjectV3Headers;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\UpdateProjectV3Request;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\UpdateProjectV3Response;
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
     * @summary 查询任务概览
     *  *
     * @param string                $userId
     * @param AnalysisReportRequest $request AnalysisReportRequest
     * @param AnalysisReportHeaders $headers AnalysisReportHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return AnalysisReportResponse AnalysisReportResponse
     */
    public function analysisReportWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->reportId)) {
            $body['reportId'] = $request->reportId;
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
            'action'      => 'AnalysisReport',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/users/' . $userId . '/analyses/report',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AnalysisReportResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询任务概览
     *  *
     * @param string                $userId
     * @param AnalysisReportRequest $request AnalysisReportRequest
     *
     * @return AnalysisReportResponse AnalysisReportResponse
     */
    public function analysisReport($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AnalysisReportHeaders([]);

        return $this->analysisReportWithOptions($userId, $request, $headers, $runtime);
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
     * @summary 创建项目成员
     *  *
     * @param string                        $userId
     * @param string                        $projectId
     * @param CreateProjectMembersV3Request $request   CreateProjectMembersV3Request
     * @param CreateProjectMembersV3Headers $headers   CreateProjectMembersV3Headers
     * @param RuntimeOptions                $runtime   runtime options for this request RuntimeOptions
     *
     * @return CreateProjectMembersV3Response CreateProjectMembersV3Response
     */
    public function createProjectMembersV3WithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
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
            'action'      => 'CreateProjectMembersV3',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/users/' . $userId . '/projects/' . $projectId . '/members',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateProjectMembersV3Response::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建项目成员
     *  *
     * @param string                        $userId
     * @param string                        $projectId
     * @param CreateProjectMembersV3Request $request   CreateProjectMembersV3Request
     *
     * @return CreateProjectMembersV3Response CreateProjectMembersV3Response
     */
    public function createProjectMembersV3($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateProjectMembersV3Headers([]);

        return $this->createProjectMembersV3WithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建协作空间。
     *  *
     * @param string                 $userId
     * @param CreateProjectV3Request $request CreateProjectV3Request
     * @param CreateProjectV3Headers $headers CreateProjectV3Headers
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateProjectV3Response CreateProjectV3Response
     */
    public function createProjectV3WithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->organizationId)) {
            $query['organizationId'] = $request->organizationId;
        }
        $body = [];
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
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
            'action'      => 'CreateProjectV3',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/users/' . $userId . '/projects',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateProjectV3Response::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建协作空间。
     *  *
     * @param string                 $userId
     * @param CreateProjectV3Request $request CreateProjectV3Request
     *
     * @return CreateProjectV3Response CreateProjectV3Response
     */
    public function createProjectV3($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateProjectV3Headers([]);

        return $this->createProjectV3WithOptions($userId, $request, $headers, $runtime);
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
     * @summary 删除项目成员。
     *  *
     * @param string                        $userId
     * @param string                        $projectId
     * @param DeleteProjectMembersV3Request $request   DeleteProjectMembersV3Request
     * @param DeleteProjectMembersV3Headers $headers   DeleteProjectMembersV3Headers
     * @param RuntimeOptions                $runtime   runtime options for this request RuntimeOptions
     *
     * @return DeleteProjectMembersV3Response DeleteProjectMembersV3Response
     */
    public function deleteProjectMembersV3WithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
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
            'action'      => 'DeleteProjectMembersV3',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/users/' . $userId . '/projects/' . $projectId . '/members/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteProjectMembersV3Response::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除项目成员。
     *  *
     * @param string                        $userId
     * @param string                        $projectId
     * @param DeleteProjectMembersV3Request $request   DeleteProjectMembersV3Request
     *
     * @return DeleteProjectMembersV3Response DeleteProjectMembersV3Response
     */
    public function deleteProjectMembersV3($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteProjectMembersV3Headers([]);

        return $this->deleteProjectMembersV3WithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取最近访问的项目
     *  *
     * @param string                     $userId
     * @param GetFootprintProjectHeaders $headers GetFootprintProjectHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFootprintProjectResponse GetFootprintProjectResponse
     */
    public function getFootprintProjectWithOptions($userId, $headers, $runtime)
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
            'action'      => 'GetFootprintProject',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/users/' . $userId . '/footprints/projects',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFootprintProjectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取最近访问的项目
     *  *
     * @param string $userId
     *
     * @return GetFootprintProjectResponse GetFootprintProjectResponse
     */
    public function getFootprintProject($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFootprintProjectHeaders([]);

        return $this->getFootprintProjectWithOptions($userId, $headers, $runtime);
    }

    /**
     * @summary 获取最近访问的任务
     *  *
     * @param string                  $userId
     * @param GetFootprintTaskHeaders $headers GetFootprintTaskHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFootprintTaskResponse GetFootprintTaskResponse
     */
    public function getFootprintTaskWithOptions($userId, $headers, $runtime)
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
            'action'      => 'GetFootprintTask',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/users/' . $userId . '/footprints/tasks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFootprintTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取最近访问的任务
     *  *
     * @param string $userId
     *
     * @return GetFootprintTaskResponse GetFootprintTaskResponse
     */
    public function getFootprintTask($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFootprintTaskHeaders([]);

        return $this->getFootprintTaskWithOptions($userId, $headers, $runtime);
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
     * @summary 获取协作空间成员列表。
     *  *
     * @param string                     $userId
     * @param string                     $projectId
     * @param GetProjectMembersV3Request $request   GetProjectMembersV3Request
     * @param GetProjectMembersV3Headers $headers   GetProjectMembersV3Headers
     * @param RuntimeOptions             $runtime   runtime options for this request RuntimeOptions
     *
     * @return GetProjectMembersV3Response GetProjectMembersV3Response
     */
    public function getProjectMembersV3WithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->projectRoleId)) {
            $query['projectRoleId'] = $request->projectRoleId;
        }
        if (!Utils::isUnset($request->userIds)) {
            $query['userIds'] = $request->userIds;
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
            'action'      => 'GetProjectMembersV3',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/users/' . $userId . '/projects/' . $projectId . '/members',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetProjectMembersV3Response::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取协作空间成员列表。
     *  *
     * @param string                     $userId
     * @param string                     $projectId
     * @param GetProjectMembersV3Request $request   GetProjectMembersV3Request
     *
     * @return GetProjectMembersV3Response GetProjectMembersV3Response
     */
    public function getProjectMembersV3($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProjectMembersV3Headers([]);

        return $this->getProjectMembersV3WithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取项目角色列表。
     *  *
     * @param string                   $userId
     * @param string                   $projectId
     * @param GetProjectRolesV3Request $request   GetProjectRolesV3Request
     * @param GetProjectRolesV3Headers $headers   GetProjectRolesV3Headers
     * @param RuntimeOptions           $runtime   runtime options for this request RuntimeOptions
     *
     * @return GetProjectRolesV3Response GetProjectRolesV3Response
     */
    public function getProjectRolesV3WithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->includeHidden)) {
            $query['includeHidden'] = $request->includeHidden;
        }
        if (!Utils::isUnset($request->level)) {
            $query['level'] = $request->level;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
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
            'action'      => 'GetProjectRolesV3',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/users/' . $userId . '/projects/' . $projectId . '/roles',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetProjectRolesV3Response::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取项目角色列表。
     *  *
     * @param string                   $userId
     * @param string                   $projectId
     * @param GetProjectRolesV3Request $request   GetProjectRolesV3Request
     *
     * @return GetProjectRolesV3Response GetProjectRolesV3Response
     */
    public function getProjectRolesV3($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProjectRolesV3Headers([]);

        return $this->getProjectRolesV3WithOptions($userId, $projectId, $request, $headers, $runtime);
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
     * @summary 获取快办企业ID
     *  *
     * @param GetThingOrgIdByDingOrgIdHeaders $headers GetThingOrgIdByDingOrgIdHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetThingOrgIdByDingOrgIdResponse GetThingOrgIdByDingOrgIdResponse
     */
    public function getThingOrgIdByDingOrgIdWithOptions($headers, $runtime)
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
            'action'      => 'GetThingOrgIdByDingOrgId',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/organizations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetThingOrgIdByDingOrgIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取快办企业ID
     *  *
     * @return GetThingOrgIdByDingOrgIdResponse GetThingOrgIdByDingOrgIdResponse
     */
    public function getThingOrgIdByDingOrgId()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetThingOrgIdByDingOrgIdHeaders([]);

        return $this->getThingOrgIdByDingOrgIdWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取用户参与项目。
     *  *
     * @param string                         $userId
     * @param GetUserJoinedProjectsV3Request $request GetUserJoinedProjectsV3Request
     * @param GetUserJoinedProjectsV3Headers $headers GetUserJoinedProjectsV3Headers
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserJoinedProjectsV3Response GetUserJoinedProjectsV3Response
     */
    public function getUserJoinedProjectsV3WithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->projectIds)) {
            $query['projectIds'] = $request->projectIds;
        }
        if (!Utils::isUnset($request->projectRoleLevels)) {
            $query['projectRoleLevels'] = $request->projectRoleLevels;
        }
        if (!Utils::isUnset($request->sortBy)) {
            $query['sortBy'] = $request->sortBy;
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
            'action'      => 'GetUserJoinedProjectsV3',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/users/' . $userId . '/projects/userJoined',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserJoinedProjectsV3Response::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户参与项目。
     *  *
     * @param string                         $userId
     * @param GetUserJoinedProjectsV3Request $request GetUserJoinedProjectsV3Request
     *
     * @return GetUserJoinedProjectsV3Response GetUserJoinedProjectsV3Response
     */
    public function getUserJoinedProjectsV3($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserJoinedProjectsV3Headers([]);

        return $this->getUserJoinedProjectsV3WithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取全部任务
     *  *
     * @param string                 $userId
     * @param ListAllTaskViewHeaders $headers ListAllTaskViewHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ListAllTaskViewResponse ListAllTaskViewResponse
     */
    public function listAllTaskViewWithOptions($userId, $headers, $runtime)
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
            'action'      => 'ListAllTaskView',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/users/' . $userId . '/allTaskViews',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListAllTaskViewResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取全部任务
     *  *
     * @param string $userId
     *
     * @return ListAllTaskViewResponse ListAllTaskViewResponse
     */
    public function listAllTaskView($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAllTaskViewHeaders([]);

        return $this->listAllTaskViewWithOptions($userId, $headers, $runtime);
    }

    /**
     * @summary 查询我的捷径
     *  *
     * @param string                     $userId
     * @param ListMyShortcutViewsRequest $request ListMyShortcutViewsRequest
     * @param ListMyShortcutViewsHeaders $headers ListMyShortcutViewsHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return ListMyShortcutViewsResponse ListMyShortcutViewsResponse
     */
    public function listMyShortcutViewsWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
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
            'action'      => 'ListMyShortcutViews',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/users/' . $userId . '/shortcutViews',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListMyShortcutViewsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询我的捷径
     *  *
     * @param string                     $userId
     * @param ListMyShortcutViewsRequest $request ListMyShortcutViewsRequest
     *
     * @return ListMyShortcutViewsResponse ListMyShortcutViewsResponse
     */
    public function listMyShortcutViews($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListMyShortcutViewsHeaders([]);

        return $this->listMyShortcutViewsWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询自由任务和项目任务详情。
     *  *
     * @param string              $userId
     * @param QueryAllTaskRequest $request QueryAllTaskRequest
     * @param QueryAllTaskHeaders $headers QueryAllTaskHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAllTaskResponse QueryAllTaskResponse
     */
    public function queryAllTaskWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'action'      => 'QueryAllTask',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/users/' . $userId . '/tasks/query',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAllTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询自由任务和项目任务详情。
     *  *
     * @param string              $userId
     * @param QueryAllTaskRequest $request QueryAllTaskRequest
     *
     * @return QueryAllTaskResponse QueryAllTaskResponse
     */
    public function queryAllTask($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllTaskHeaders([]);

        return $this->queryAllTaskWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询我的任务
     *  *
     * @param string           $userId
     * @param QueryTaskRequest $request QueryTaskRequest
     * @param QueryTaskHeaders $headers QueryTaskHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryTaskResponse QueryTaskResponse
     */
    public function queryTaskWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->tql)) {
            $body['tql'] = $request->tql;
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
            'action'      => 'QueryTask',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/users/' . $userId . '/tasks/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询我的任务
     *  *
     * @param string           $userId
     * @param QueryTaskRequest $request QueryTaskRequest
     *
     * @return QueryTaskResponse QueryTaskResponse
     */
    public function queryTask($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTaskHeaders([]);

        return $this->queryTaskWithOptions($userId, $request, $headers, $runtime);
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

    /**
     * @summary 修改项目成员的角色。
     *  *
     * @param string                           $userId
     * @param string                           $projectId
     * @param UpdateProjectMemberRoleV3Request $request   UpdateProjectMemberRoleV3Request
     * @param UpdateProjectMemberRoleV3Headers $headers   UpdateProjectMemberRoleV3Headers
     * @param RuntimeOptions                   $runtime   runtime options for this request RuntimeOptions
     *
     * @return UpdateProjectMemberRoleV3Response UpdateProjectMemberRoleV3Response
     */
    public function updateProjectMemberRoleV3WithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->roleIds)) {
            $body['roleIds'] = $request->roleIds;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
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
            'action'      => 'UpdateProjectMemberRoleV3',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/users/' . $userId . '/projects/' . $projectId . '/roles/assign',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateProjectMemberRoleV3Response::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改项目成员的角色。
     *  *
     * @param string                           $userId
     * @param string                           $projectId
     * @param UpdateProjectMemberRoleV3Request $request   UpdateProjectMemberRoleV3Request
     *
     * @return UpdateProjectMemberRoleV3Response UpdateProjectMemberRoleV3Response
     */
    public function updateProjectMemberRoleV3($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateProjectMemberRoleV3Headers([]);

        return $this->updateProjectMemberRoleV3WithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新协作空间。
     *  *
     * @param string                 $userId
     * @param string                 $projectId
     * @param UpdateProjectV3Request $request   UpdateProjectV3Request
     * @param UpdateProjectV3Headers $headers   UpdateProjectV3Headers
     * @param RuntimeOptions         $runtime   runtime options for this request RuntimeOptions
     *
     * @return UpdateProjectV3Response UpdateProjectV3Response
     */
    public function updateProjectV3WithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
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
            'action'      => 'UpdateProjectV3',
            'version'     => 'teamSphere_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/teamSphere/users/' . $userId . '/projects/' . $projectId . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateProjectV3Response::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新协作空间。
     *  *
     * @param string                 $userId
     * @param string                 $projectId
     * @param UpdateProjectV3Request $request   UpdateProjectV3Request
     *
     * @return UpdateProjectV3Response UpdateProjectV3Response
     */
    public function updateProjectV3($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateProjectV3Headers([]);

        return $this->updateProjectV3WithOptions($userId, $projectId, $request, $headers, $runtime);
    }
}
