<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\AddProjectMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\AddProjectMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\AddProjectMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\ArchiveProjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\ArchiveProjectResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\ArchiveTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\ArchiveTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateOrganizationTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateOrganizationTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateOrganizationTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreatePlanTimeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreatePlanTimeRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreatePlanTimeResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectByTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectByTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectByTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectCustomfieldStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectCustomfieldStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectCustomfieldStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskObjectLinkHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskObjectLinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskObjectLinkResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateWorkTimeApproveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateWorkTimeApproveRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateWorkTimeApproveResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateWorkTimeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateWorkTimeRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateWorkTimeResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\DeleteProjectMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\DeleteProjectMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\DeleteProjectMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\DeleteTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\DeleteTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetDeptsByOrgIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetDeptsByOrgIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetDeptsByOrgIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetEmpsByOrgIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetEmpsByOrgIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetEmpsByOrgIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetOrganizationPriorityListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetOrganizationPriorityListResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetOrganizationTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetOrganizationTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetOrganizatioTaskByIdsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetOrganizatioTaskByIdsRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetOrganizatioTaskByIdsResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetProjectGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetProjectGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetProjectGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetProjectMemebersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetProjectMemebersRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetProjectMemebersResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetProjectStatusListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetProjectStatusListResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTaskByIdsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTaskByIdsRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTaskByIdsResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbOrgIdByDingOrgIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbOrgIdByDingOrgIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbOrgIdByDingOrgIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectGrayHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectGrayRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectGrayResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectSourceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectSourceResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbUserIdByStaffIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbUserIdByStaffIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbUserIdByStaffIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetUserJoinedProjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetUserJoinedProjectRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetUserJoinedProjectResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\QueryProjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\QueryProjectRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\QueryProjectResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\QueryTaskOfProjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\QueryTaskOfProjectRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\QueryTaskOfProjectResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SeachTaskStageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SeachTaskStageRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SeachTaskStageResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchAllTasksByTqlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchAllTasksByTqlRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchAllTasksByTqlResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchOranizationCustomfieldHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchOranizationCustomfieldRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchOranizationCustomfieldResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchProjectCustomfieldHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchProjectCustomfieldRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchProjectCustomfieldResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchProjectTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchProjectTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchProjectTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchTaskFlowHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchTaskFlowRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchTaskFlowResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchTaskflowStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchTaskflowStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchTaskflowStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchTaskListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchTaskListRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchTaskListResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchUserTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchUserTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchUserTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SuspendProjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SuspendProjectResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UnSuspendProjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UnSuspendProjectResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateCustomfieldValueHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateCustomfieldValueRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateCustomfieldValueResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskContentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskContentRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskContentResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskDueDateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskDueDateRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskDueDateResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskExecutorHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskExecutorRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskExecutorResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskInvolveMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskInvolveMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskInvolveMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskNoteHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskNoteRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskNoteResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskPriorityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskPriorityRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskPriorityResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateProjectGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateProjectGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateProjectGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskContentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskContentRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskContentResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskDueDateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskDueDateRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskDueDateResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskExecutorHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskExecutorRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskExecutorResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskInvolvemembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskInvolvemembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskInvolvemembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskNoteHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskNoteRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskNoteResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskPriorityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskPriorityRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskPriorityResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskStageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskStageRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskStageResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskStartdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskStartdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskStartdateResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskTaskflowstatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskTaskflowstatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskTaskflowstatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateWorkTimeApproveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateWorkTimeApproveRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateWorkTimeApproveResponse;
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
     * @summary 增加项目成员
     *  *
     * @param string                  $userId
     * @param string                  $projectId
     * @param AddProjectMemberRequest $request   AddProjectMemberRequest
     * @param AddProjectMemberHeaders $headers   AddProjectMemberHeaders
     * @param RuntimeOptions          $runtime   runtime options for this request RuntimeOptions
     *
     * @return AddProjectMemberResponse AddProjectMemberResponse
     */
    public function addProjectMemberWithOptions($userId, $projectId, $request, $headers, $runtime)
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
            'action'      => 'AddProjectMember',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/members',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddProjectMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 增加项目成员
     *  *
     * @param string                  $userId
     * @param string                  $projectId
     * @param AddProjectMemberRequest $request   AddProjectMemberRequest
     *
     * @return AddProjectMemberResponse AddProjectMemberResponse
     */
    public function addProjectMember($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddProjectMemberHeaders([]);

        return $this->addProjectMemberWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @summary 项目放入回收站
     *  *
     * @param string                $userId
     * @param string                $projectId
     * @param ArchiveProjectHeaders $headers   ArchiveProjectHeaders
     * @param RuntimeOptions        $runtime   runtime options for this request RuntimeOptions
     *
     * @return ArchiveProjectResponse ArchiveProjectResponse
     */
    public function archiveProjectWithOptions($userId, $projectId, $headers, $runtime)
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
            'action'      => 'ArchiveProject',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/archive',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ArchiveProjectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 项目放入回收站
     *  *
     * @param string $userId
     * @param string $projectId
     *
     * @return ArchiveProjectResponse ArchiveProjectResponse
     */
    public function archiveProject($userId, $projectId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ArchiveProjectHeaders([]);

        return $this->archiveProjectWithOptions($userId, $projectId, $headers, $runtime);
    }

    /**
     * @summary 任务迁移至回收站
     *  *
     * @param string             $userId
     * @param string             $taskId
     * @param ArchiveTaskHeaders $headers ArchiveTaskHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return ArchiveTaskResponse ArchiveTaskResponse
     */
    public function archiveTaskWithOptions($userId, $taskId, $headers, $runtime)
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
            'action'      => 'ArchiveTask',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/archive',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ArchiveTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 任务迁移至回收站
     *  *
     * @param string $userId
     * @param string $taskId
     *
     * @return ArchiveTaskResponse ArchiveTaskResponse
     */
    public function archiveTask($userId, $taskId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ArchiveTaskHeaders([]);

        return $this->archiveTaskWithOptions($userId, $taskId, $headers, $runtime);
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
        if (!Utils::isUnset($request->createTime)) {
            $body['createTime'] = $request->createTime;
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
        if (!Utils::isUnset($request->priority)) {
            $body['priority'] = $request->priority;
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
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/organizations/users/' . $userId . '/tasks',
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
     * @summary 录入计划工时
     *  *
     * @param string                $userId
     * @param CreatePlanTimeRequest $request CreatePlanTimeRequest
     * @param CreatePlanTimeHeaders $headers CreatePlanTimeHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CreatePlanTimeResponse CreatePlanTimeResponse
     */
    public function createPlanTimeWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->tenantType)) {
            $query['tenantType'] = $request->tenantType;
        }
        $body = [];
        if (!Utils::isUnset($request->endDate)) {
            $body['endDate'] = $request->endDate;
        }
        if (!Utils::isUnset($request->executorId)) {
            $body['executorId'] = $request->executorId;
        }
        if (!Utils::isUnset($request->includesHolidays)) {
            $body['includesHolidays'] = $request->includesHolidays;
        }
        if (!Utils::isUnset($request->isDuration)) {
            $body['isDuration'] = $request->isDuration;
        }
        if (!Utils::isUnset($request->objectId)) {
            $body['objectId'] = $request->objectId;
        }
        if (!Utils::isUnset($request->objectType)) {
            $body['objectType'] = $request->objectType;
        }
        if (!Utils::isUnset($request->planTime)) {
            $body['planTime'] = $request->planTime;
        }
        if (!Utils::isUnset($request->startDate)) {
            $body['startDate'] = $request->startDate;
        }
        if (!Utils::isUnset($request->submitterId)) {
            $body['submitterId'] = $request->submitterId;
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
            'action'      => 'CreatePlanTime',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/planTimes',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreatePlanTimeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 录入计划工时
     *  *
     * @param string                $userId
     * @param CreatePlanTimeRequest $request CreatePlanTimeRequest
     *
     * @return CreatePlanTimeResponse CreatePlanTimeResponse
     */
    public function createPlanTime($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreatePlanTimeHeaders([]);

        return $this->createPlanTimeWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建项目
     *  *
     * @param string               $userId
     * @param CreateProjectRequest $request CreateProjectRequest
     * @param CreateProjectHeaders $headers CreateProjectHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateProjectResponse CreateProjectResponse
     */
    public function createProjectWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateProject',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projects',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateProjectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建项目
     *  *
     * @param string               $userId
     * @param CreateProjectRequest $request CreateProjectRequest
     *
     * @return CreateProjectResponse CreateProjectResponse
     */
    public function createProject($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateProjectHeaders([]);

        return $this->createProjectWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 根据项目模板创建项目
     *  *
     * @param string                         $userId
     * @param CreateProjectByTemplateRequest $request CreateProjectByTemplateRequest
     * @param CreateProjectByTemplateHeaders $headers CreateProjectByTemplateHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateProjectByTemplateResponse CreateProjectByTemplateResponse
     */
    public function createProjectByTemplateWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
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
            'action'      => 'CreateProjectByTemplate',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/templates/projects',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateProjectByTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据项目模板创建项目
     *  *
     * @param string                         $userId
     * @param CreateProjectByTemplateRequest $request CreateProjectByTemplateRequest
     *
     * @return CreateProjectByTemplateResponse CreateProjectByTemplateResponse
     */
    public function createProjectByTemplate($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateProjectByTemplateHeaders([]);

        return $this->createProjectByTemplateWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建或更新项目概览中自定义字段值
     *  *
     * @param string                                $userId
     * @param string                                $projectId
     * @param CreateProjectCustomfieldStatusRequest $request   CreateProjectCustomfieldStatusRequest
     * @param CreateProjectCustomfieldStatusHeaders $headers   CreateProjectCustomfieldStatusHeaders
     * @param RuntimeOptions                        $runtime   runtime options for this request RuntimeOptions
     *
     * @return CreateProjectCustomfieldStatusResponse CreateProjectCustomfieldStatusResponse
     */
    public function createProjectCustomfieldStatusWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->customFieldId)) {
            $body['customFieldId'] = $request->customFieldId;
        }
        if (!Utils::isUnset($request->customFieldInstanceId)) {
            $body['customFieldInstanceId'] = $request->customFieldInstanceId;
        }
        if (!Utils::isUnset($request->customFieldName)) {
            $body['customFieldName'] = $request->customFieldName;
        }
        if (!Utils::isUnset($request->value)) {
            $body['value'] = $request->value;
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
            'action'      => 'CreateProjectCustomfieldStatus',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/customfields',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateProjectCustomfieldStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建或更新项目概览中自定义字段值
     *  *
     * @param string                                $userId
     * @param string                                $projectId
     * @param CreateProjectCustomfieldStatusRequest $request   CreateProjectCustomfieldStatusRequest
     *
     * @return CreateProjectCustomfieldStatusResponse CreateProjectCustomfieldStatusResponse
     */
    public function createProjectCustomfieldStatus($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateProjectCustomfieldStatusHeaders([]);

        return $this->createProjectCustomfieldStatusWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建项目任务
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
        if (!Utils::isUnset($request->parentTaskId)) {
            $body['parentTaskId'] = $request->parentTaskId;
        }
        if (!Utils::isUnset($request->priority)) {
            $body['priority'] = $request->priority;
        }
        if (!Utils::isUnset($request->projectId)) {
            $body['projectId'] = $request->projectId;
        }
        if (!Utils::isUnset($request->scenariofieldconfigId)) {
            $body['scenariofieldconfigId'] = $request->scenariofieldconfigId;
        }
        if (!Utils::isUnset($request->stageId)) {
            $body['stageId'] = $request->stageId;
        }
        if (!Utils::isUnset($request->startDate)) {
            $body['startDate'] = $request->startDate;
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
            'action'      => 'CreateTask',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tasks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建项目任务
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
     * @summary 创建任务关联对象
     *  *
     * @param string                      $userId
     * @param string                      $taskId
     * @param CreateTaskObjectLinkRequest $request CreateTaskObjectLinkRequest
     * @param CreateTaskObjectLinkHeaders $headers CreateTaskObjectLinkHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTaskObjectLinkResponse CreateTaskObjectLinkResponse
     */
    public function createTaskObjectLinkWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->linkedData)) {
            $body['linkedData'] = $request->linkedData;
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
            'action'      => 'CreateTaskObjectLink',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/objectLinks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateTaskObjectLinkResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建任务关联对象
     *  *
     * @param string                      $userId
     * @param string                      $taskId
     * @param CreateTaskObjectLinkRequest $request CreateTaskObjectLinkRequest
     *
     * @return CreateTaskObjectLinkResponse CreateTaskObjectLinkResponse
     */
    public function createTaskObjectLink($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTaskObjectLinkHeaders([]);

        return $this->createTaskObjectLinkWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @summary 录入实际工时接口
     *  *
     * @param string                $userId
     * @param CreateWorkTimeRequest $request CreateWorkTimeRequest
     * @param CreateWorkTimeHeaders $headers CreateWorkTimeHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateWorkTimeResponse CreateWorkTimeResponse
     */
    public function createWorkTimeWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->tenantType)) {
            $query['tenantType'] = $request->tenantType;
        }
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->endDate)) {
            $body['endDate'] = $request->endDate;
        }
        if (!Utils::isUnset($request->executorId)) {
            $body['executorId'] = $request->executorId;
        }
        if (!Utils::isUnset($request->includesHolidays)) {
            $body['includesHolidays'] = $request->includesHolidays;
        }
        if (!Utils::isUnset($request->isDuration)) {
            $body['isDuration'] = $request->isDuration;
        }
        if (!Utils::isUnset($request->objectId)) {
            $body['objectId'] = $request->objectId;
        }
        if (!Utils::isUnset($request->objectType)) {
            $body['objectType'] = $request->objectType;
        }
        if (!Utils::isUnset($request->startDate)) {
            $body['startDate'] = $request->startDate;
        }
        if (!Utils::isUnset($request->submitterId)) {
            $body['submitterId'] = $request->submitterId;
        }
        if (!Utils::isUnset($request->workTime)) {
            $body['workTime'] = $request->workTime;
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
            'action'      => 'CreateWorkTime',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/workTimes',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateWorkTimeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 录入实际工时接口
     *  *
     * @param string                $userId
     * @param CreateWorkTimeRequest $request CreateWorkTimeRequest
     *
     * @return CreateWorkTimeResponse CreateWorkTimeResponse
     */
    public function createWorkTime($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateWorkTimeHeaders([]);

        return $this->createWorkTimeWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建实际工时审批对象。
     *  *
     * @param string                       $userId
     * @param CreateWorkTimeApproveRequest $request CreateWorkTimeApproveRequest
     * @param CreateWorkTimeApproveHeaders $headers CreateWorkTimeApproveHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateWorkTimeApproveResponse CreateWorkTimeApproveResponse
     */
    public function createWorkTimeApproveWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->workTimeIds)) {
            $body['workTimeIds'] = $request->workTimeIds;
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
            'action'      => 'CreateWorkTimeApprove',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/workTimes/approvals',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateWorkTimeApproveResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建实际工时审批对象。
     *  *
     * @param string                       $userId
     * @param CreateWorkTimeApproveRequest $request CreateWorkTimeApproveRequest
     *
     * @return CreateWorkTimeApproveResponse CreateWorkTimeApproveResponse
     */
    public function createWorkTimeApprove($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateWorkTimeApproveHeaders([]);

        return $this->createWorkTimeApproveWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除项目成员
     *  *
     * @param string                     $userId
     * @param string                     $projectId
     * @param DeleteProjectMemberRequest $request   DeleteProjectMemberRequest
     * @param DeleteProjectMemberHeaders $headers   DeleteProjectMemberHeaders
     * @param RuntimeOptions             $runtime   runtime options for this request RuntimeOptions
     *
     * @return DeleteProjectMemberResponse DeleteProjectMemberResponse
     */
    public function deleteProjectMemberWithOptions($userId, $projectId, $request, $headers, $runtime)
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
            'action'      => 'DeleteProjectMember',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/members/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteProjectMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除项目成员
     *  *
     * @param string                     $userId
     * @param string                     $projectId
     * @param DeleteProjectMemberRequest $request   DeleteProjectMemberRequest
     *
     * @return DeleteProjectMemberResponse DeleteProjectMemberResponse
     */
    public function deleteProjectMember($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteProjectMemberHeaders([]);

        return $this->deleteProjectMemberWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除任务
     *  *
     * @param string            $userId
     * @param string            $taskId
     * @param DeleteTaskHeaders $headers DeleteTaskHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteTaskResponse DeleteTaskResponse
     */
    public function deleteTaskWithOptions($userId, $taskId, $headers, $runtime)
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
            'action'      => 'DeleteTask',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除任务
     *  *
     * @param string $userId
     * @param string $taskId
     *
     * @return DeleteTaskResponse DeleteTaskResponse
     */
    public function deleteTask($userId, $taskId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteTaskHeaders([]);

        return $this->deleteTaskWithOptions($userId, $taskId, $headers, $runtime);
    }

    /**
     * @summary 根据企业Id获取部门
     *  *
     * @param GetDeptsByOrgIdRequest $request GetDeptsByOrgIdRequest
     * @param GetDeptsByOrgIdHeaders $headers GetDeptsByOrgIdHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDeptsByOrgIdResponse GetDeptsByOrgIdResponse
     */
    public function getDeptsByOrgIdWithOptions($request, $headers, $runtime)
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
        if (!Utils::isUnset($headers->dingAccessTokenType)) {
            $realHeaders['dingAccessTokenType'] = Utils::toJSONString($headers->dingAccessTokenType);
        }
        if (!Utils::isUnset($headers->dingOrgId)) {
            $realHeaders['dingOrgId'] = Utils::toJSONString($headers->dingOrgId);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetDeptsByOrgId',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/orgs/depts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDeptsByOrgIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据企业Id获取部门
     *  *
     * @param GetDeptsByOrgIdRequest $request GetDeptsByOrgIdRequest
     *
     * @return GetDeptsByOrgIdResponse GetDeptsByOrgIdResponse
     */
    public function getDeptsByOrgId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDeptsByOrgIdHeaders([]);

        return $this->getDeptsByOrgIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据企业Id获取企业内的员工信息
     *  *
     * @param GetEmpsByOrgIdRequest $request GetEmpsByOrgIdRequest
     * @param GetEmpsByOrgIdHeaders $headers GetEmpsByOrgIdHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetEmpsByOrgIdResponse GetEmpsByOrgIdResponse
     */
    public function getEmpsByOrgIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->needDept)) {
            $query['needDept'] = $request->needDept;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->dingAccessTokenType)) {
            $realHeaders['dingAccessTokenType'] = Utils::toJSONString($headers->dingAccessTokenType);
        }
        if (!Utils::isUnset($headers->dingIsvOrgId)) {
            $realHeaders['dingIsvOrgId'] = Utils::toJSONString($headers->dingIsvOrgId);
        }
        if (!Utils::isUnset($headers->dingOrgId)) {
            $realHeaders['dingOrgId'] = Utils::toJSONString($headers->dingOrgId);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetEmpsByOrgId',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/orgs/employees',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetEmpsByOrgIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据企业Id获取企业内的员工信息
     *  *
     * @param GetEmpsByOrgIdRequest $request GetEmpsByOrgIdRequest
     *
     * @return GetEmpsByOrgIdResponse GetEmpsByOrgIdResponse
     */
    public function getEmpsByOrgId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetEmpsByOrgIdHeaders([]);

        return $this->getEmpsByOrgIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量获取任务详情
     *  *
     * @param string                         $userId
     * @param GetOrganizatioTaskByIdsRequest $request GetOrganizatioTaskByIdsRequest
     * @param GetOrganizatioTaskByIdsHeaders $headers GetOrganizatioTaskByIdsHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOrganizatioTaskByIdsResponse GetOrganizatioTaskByIdsResponse
     */
    public function getOrganizatioTaskByIdsWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->taskIds)) {
            $query['taskIds'] = $request->taskIds;
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
            'action'      => 'GetOrganizatioTaskByIds',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/organizations/users/' . $userId . '/tasks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOrganizatioTaskByIdsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量获取任务详情
     *  *
     * @param string                         $userId
     * @param GetOrganizatioTaskByIdsRequest $request GetOrganizatioTaskByIdsRequest
     *
     * @return GetOrganizatioTaskByIdsResponse GetOrganizatioTaskByIdsResponse
     */
    public function getOrganizatioTaskByIds($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOrganizatioTaskByIdsHeaders([]);

        return $this->getOrganizatioTaskByIdsWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取企业优先级列表
     *  *
     * @param string                             $userId
     * @param GetOrganizationPriorityListHeaders $headers GetOrganizationPriorityListHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOrganizationPriorityListResponse GetOrganizationPriorityListResponse
     */
    public function getOrganizationPriorityListWithOptions($userId, $headers, $runtime)
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
            'action'      => 'GetOrganizationPriorityList',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/organizations/users/' . $userId . '/priorities',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOrganizationPriorityListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业优先级列表
     *  *
     * @param string $userId
     *
     * @return GetOrganizationPriorityListResponse GetOrganizationPriorityListResponse
     */
    public function getOrganizationPriorityList($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOrganizationPriorityListHeaders([]);

        return $this->getOrganizationPriorityListWithOptions($userId, $headers, $runtime);
    }

    /**
     * @summary 获取自由任务详情
     *  *
     * @param string                     $taskId
     * @param string                     $userId
     * @param GetOrganizationTaskHeaders $headers GetOrganizationTaskHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOrganizationTaskResponse GetOrganizationTaskResponse
     */
    public function getOrganizationTaskWithOptions($taskId, $userId, $headers, $runtime)
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
            'action'      => 'GetOrganizationTask',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/organizations/users/' . $userId . '/tasks/' . $taskId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOrganizationTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取自由任务详情
     *  *
     * @param string $taskId
     * @param string $userId
     *
     * @return GetOrganizationTaskResponse GetOrganizationTaskResponse
     */
    public function getOrganizationTask($taskId, $userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOrganizationTaskHeaders([]);

        return $this->getOrganizationTaskWithOptions($taskId, $userId, $headers, $runtime);
    }

    /**
     * @summary 查询可见的项目分组
     *  *
     * @param string                 $userId
     * @param GetProjectGroupRequest $request GetProjectGroupRequest
     * @param GetProjectGroupHeaders $headers GetProjectGroupHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetProjectGroupResponse GetProjectGroupResponse
     */
    public function getProjectGroupWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->viewerId)) {
            $query['viewerId'] = $request->viewerId;
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
            'action'      => 'GetProjectGroup',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/organizations/users/' . $userId . '/groups',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetProjectGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询可见的项目分组
     *  *
     * @param string                 $userId
     * @param GetProjectGroupRequest $request GetProjectGroupRequest
     *
     * @return GetProjectGroupResponse GetProjectGroupResponse
     */
    public function getProjectGroup($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProjectGroupHeaders([]);

        return $this->getProjectGroupWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取项目成员
     *  *
     * @param string                    $userId
     * @param string                    $projectId
     * @param GetProjectMemebersRequest $request   GetProjectMemebersRequest
     * @param GetProjectMemebersHeaders $headers   GetProjectMemebersHeaders
     * @param RuntimeOptions            $runtime   runtime options for this request RuntimeOptions
     *
     * @return GetProjectMemebersResponse GetProjectMemebersResponse
     */
    public function getProjectMemebersWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->projectRoleId)) {
            $query['projectRoleId'] = $request->projectRoleId;
        }
        if (!Utils::isUnset($request->skip)) {
            $query['skip'] = $request->skip;
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
            'action'      => 'GetProjectMemebers',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/members',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetProjectMemebersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取项目成员
     *  *
     * @param string                    $userId
     * @param string                    $projectId
     * @param GetProjectMemebersRequest $request   GetProjectMemebersRequest
     *
     * @return GetProjectMemebersResponse GetProjectMemebersResponse
     */
    public function getProjectMemebers($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProjectMemebersHeaders([]);

        return $this->getProjectMemebersWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询项目状态
     *  *
     * @param string                      $userId
     * @param string                      $projectId
     * @param GetProjectStatusListHeaders $headers   GetProjectStatusListHeaders
     * @param RuntimeOptions              $runtime   runtime options for this request RuntimeOptions
     *
     * @return GetProjectStatusListResponse GetProjectStatusListResponse
     */
    public function getProjectStatusListWithOptions($userId, $projectId, $headers, $runtime)
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
            'action'      => 'GetProjectStatusList',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/statuses',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetProjectStatusListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询项目状态
     *  *
     * @param string $userId
     * @param string $projectId
     *
     * @return GetProjectStatusListResponse GetProjectStatusListResponse
     */
    public function getProjectStatusList($userId, $projectId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProjectStatusListHeaders([]);

        return $this->getProjectStatusListWithOptions($userId, $projectId, $headers, $runtime);
    }

    /**
     * @summary 获取任务详情
     *  *
     * @param string              $userId
     * @param GetTaskByIdsRequest $request GetTaskByIdsRequest
     * @param GetTaskByIdsHeaders $headers GetTaskByIdsHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTaskByIdsResponse GetTaskByIdsResponse
     */
    public function getTaskByIdsWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->parentTaskId)) {
            $query['parentTaskId'] = $request->parentTaskId;
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
            'action'      => 'GetTaskByIds',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tasks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTaskByIdsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取任务详情
     *  *
     * @param string              $userId
     * @param GetTaskByIdsRequest $request GetTaskByIdsRequest
     *
     * @return GetTaskByIdsResponse GetTaskByIdsResponse
     */
    public function getTaskByIds($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTaskByIdsHeaders([]);

        return $this->getTaskByIdsWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取Teambition企业Id
     *  *
     * @param GetTbOrgIdByDingOrgIdRequest $request GetTbOrgIdByDingOrgIdRequest
     * @param GetTbOrgIdByDingOrgIdHeaders $headers GetTbOrgIdByDingOrgIdHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTbOrgIdByDingOrgIdResponse GetTbOrgIdByDingOrgIdResponse
     */
    public function getTbOrgIdByDingOrgIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->optUserId)) {
            $query['optUserId'] = $request->optUserId;
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
            'action'      => 'GetTbOrgIdByDingOrgId',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/teambition/organizations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTbOrgIdByDingOrgIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取Teambition企业Id
     *  *
     * @param GetTbOrgIdByDingOrgIdRequest $request GetTbOrgIdByDingOrgIdRequest
     *
     * @return GetTbOrgIdByDingOrgIdResponse GetTbOrgIdByDingOrgIdResponse
     */
    public function getTbOrgIdByDingOrgId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTbOrgIdByDingOrgIdHeaders([]);

        return $this->getTbOrgIdByDingOrgIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取项目灰度标
     *  *
     * @param GetTbProjectGrayRequest $request GetTbProjectGrayRequest
     * @param GetTbProjectGrayHeaders $headers GetTbProjectGrayHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTbProjectGrayResponse GetTbProjectGrayResponse
     */
    public function getTbProjectGrayWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->label)) {
            $body['label'] = $request->label;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->dingAccessTokenType)) {
            $realHeaders['dingAccessTokenType'] = Utils::toJSONString($headers->dingAccessTokenType);
        }
        if (!Utils::isUnset($headers->dingCorpId)) {
            $realHeaders['dingCorpId'] = Utils::toJSONString($headers->dingCorpId);
        }
        if (!Utils::isUnset($headers->dingIsvOrgId)) {
            $realHeaders['dingIsvOrgId'] = Utils::toJSONString($headers->dingIsvOrgId);
        }
        if (!Utils::isUnset($headers->dingOrgId)) {
            $realHeaders['dingOrgId'] = Utils::toJSONString($headers->dingOrgId);
        }
        if (!Utils::isUnset($headers->dingSuiteKey)) {
            $realHeaders['dingSuiteKey'] = Utils::toJSONString($headers->dingSuiteKey);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetTbProjectGray',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/projects/gray',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetTbProjectGrayResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取项目灰度标
     *  *
     * @param GetTbProjectGrayRequest $request GetTbProjectGrayRequest
     *
     * @return GetTbProjectGrayResponse GetTbProjectGrayResponse
     */
    public function getTbProjectGray($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTbProjectGrayHeaders([]);

        return $this->getTbProjectGrayWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取项目来源
     *  *
     * @param GetTbProjectSourceHeaders $headers GetTbProjectSourceHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTbProjectSourceResponse GetTbProjectSourceResponse
     */
    public function getTbProjectSourceWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->dingAccessTokenType)) {
            $realHeaders['dingAccessTokenType'] = Utils::toJSONString($headers->dingAccessTokenType);
        }
        if (!Utils::isUnset($headers->dingCorpId)) {
            $realHeaders['dingCorpId'] = Utils::toJSONString($headers->dingCorpId);
        }
        if (!Utils::isUnset($headers->dingIsvOrgId)) {
            $realHeaders['dingIsvOrgId'] = Utils::toJSONString($headers->dingIsvOrgId);
        }
        if (!Utils::isUnset($headers->dingOrgId)) {
            $realHeaders['dingOrgId'] = Utils::toJSONString($headers->dingOrgId);
        }
        if (!Utils::isUnset($headers->dingSuiteKey)) {
            $realHeaders['dingSuiteKey'] = Utils::toJSONString($headers->dingSuiteKey);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetTbProjectSource',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/projects/source',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTbProjectSourceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取项目来源
     *  *
     * @return GetTbProjectSourceResponse GetTbProjectSourceResponse
     */
    public function getTbProjectSource()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTbProjectSourceHeaders([]);

        return $this->getTbProjectSourceWithOptions($headers, $runtime);
    }

    /**
     * @summary 根据钉钉UserId获取Teambition用户Id
     *  *
     * @param GetTbUserIdByStaffIdRequest $request GetTbUserIdByStaffIdRequest
     * @param GetTbUserIdByStaffIdHeaders $headers GetTbUserIdByStaffIdHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTbUserIdByStaffIdResponse GetTbUserIdByStaffIdResponse
     */
    public function getTbUserIdByStaffIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->optUserId)) {
            $query['optUserId'] = $request->optUserId;
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
            'action'      => 'GetTbUserIdByStaffId',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/teambition/users',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTbUserIdByStaffIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据钉钉UserId获取Teambition用户Id
     *  *
     * @param GetTbUserIdByStaffIdRequest $request GetTbUserIdByStaffIdRequest
     *
     * @return GetTbUserIdByStaffIdResponse GetTbUserIdByStaffIdResponse
     */
    public function getTbUserIdByStaffId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTbUserIdByStaffIdHeaders([]);

        return $this->getTbUserIdByStaffIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取用户加入的项目
     *  *
     * @param string                      $userId
     * @param GetUserJoinedProjectRequest $request GetUserJoinedProjectRequest
     * @param GetUserJoinedProjectHeaders $headers GetUserJoinedProjectHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserJoinedProjectResponse GetUserJoinedProjectResponse
     */
    public function getUserJoinedProjectWithOptions($userId, $request, $headers, $runtime)
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
            'action'      => 'GetUserJoinedProject',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/joinProjects',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserJoinedProjectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户加入的项目
     *  *
     * @param string                      $userId
     * @param GetUserJoinedProjectRequest $request GetUserJoinedProjectRequest
     *
     * @return GetUserJoinedProjectResponse GetUserJoinedProjectResponse
     */
    public function getUserJoinedProject($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserJoinedProjectHeaders([]);

        return $this->getUserJoinedProjectWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询项目
     *  *
     * @param string              $userId
     * @param QueryProjectRequest $request QueryProjectRequest
     * @param QueryProjectHeaders $headers QueryProjectHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryProjectResponse QueryProjectResponse
     */
    public function queryProjectWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'action'      => 'QueryProject',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projects/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryProjectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询项目
     *  *
     * @param string              $userId
     * @param QueryProjectRequest $request QueryProjectRequest
     *
     * @return QueryProjectResponse QueryProjectResponse
     */
    public function queryProject($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryProjectHeaders([]);

        return $this->queryProjectWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询项目中的任务
     *  *
     * @param string                    $userId
     * @param string                    $projectId
     * @param QueryTaskOfProjectRequest $request   QueryTaskOfProjectRequest
     * @param QueryTaskOfProjectHeaders $headers   QueryTaskOfProjectHeaders
     * @param RuntimeOptions            $runtime   runtime options for this request RuntimeOptions
     *
     * @return QueryTaskOfProjectResponse QueryTaskOfProjectResponse
     */
    public function queryTaskOfProjectWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->query)) {
            $query['query'] = $request->query;
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
            'action'      => 'QueryTaskOfProject',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projectIds/' . $projectId . '/tasks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryTaskOfProjectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询项目中的任务
     *  *
     * @param string                    $userId
     * @param string                    $projectId
     * @param QueryTaskOfProjectRequest $request   QueryTaskOfProjectRequest
     *
     * @return QueryTaskOfProjectResponse QueryTaskOfProjectResponse
     */
    public function queryTaskOfProject($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTaskOfProjectHeaders([]);

        return $this->queryTaskOfProjectWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取任务列表
     *  *
     * @param string                $userId
     * @param string                $projectId
     * @param SeachTaskStageRequest $request   SeachTaskStageRequest
     * @param SeachTaskStageHeaders $headers   SeachTaskStageHeaders
     * @param RuntimeOptions        $runtime   runtime options for this request RuntimeOptions
     *
     * @return SeachTaskStageResponse SeachTaskStageResponse
     */
    public function seachTaskStageWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->query)) {
            $query['query'] = $request->query;
        }
        if (!Utils::isUnset($request->taskListId)) {
            $query['taskListId'] = $request->taskListId;
        }
        if (!Utils::isUnset($request->taskStageIds)) {
            $query['taskStageIds'] = $request->taskStageIds;
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
            'action'      => 'SeachTaskStage',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/taskStages/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SeachTaskStageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取任务列表
     *  *
     * @param string                $userId
     * @param string                $projectId
     * @param SeachTaskStageRequest $request   SeachTaskStageRequest
     *
     * @return SeachTaskStageResponse SeachTaskStageResponse
     */
    public function seachTaskStage($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SeachTaskStageHeaders([]);

        return $this->seachTaskStageWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @summary 通过TQL搜索自由任务和项目任务ID。
     *  *
     * @param string                     $userId
     * @param SearchAllTasksByTqlRequest $request SearchAllTasksByTqlRequest
     * @param SearchAllTasksByTqlHeaders $headers SearchAllTasksByTqlHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchAllTasksByTqlResponse SearchAllTasksByTqlResponse
     */
    public function searchAllTasksByTqlWithOptions($userId, $request, $headers, $runtime)
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
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tql/tasks/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchAllTasksByTqlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过TQL搜索自由任务和项目任务ID。
     *  *
     * @param string                     $userId
     * @param SearchAllTasksByTqlRequest $request SearchAllTasksByTqlRequest
     *
     * @return SearchAllTasksByTqlResponse SearchAllTasksByTqlResponse
     */
    public function searchAllTasksByTql($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchAllTasksByTqlHeaders([]);

        return $this->searchAllTasksByTqlWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询企业自定义字段
     *  *
     * @param string                              $userId
     * @param SearchOranizationCustomfieldRequest $request SearchOranizationCustomfieldRequest
     * @param SearchOranizationCustomfieldHeaders $headers SearchOranizationCustomfieldHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchOranizationCustomfieldResponse SearchOranizationCustomfieldResponse
     */
    public function searchOranizationCustomfieldWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->customFieldIds)) {
            $query['customFieldIds'] = $request->customFieldIds;
        }
        if (!Utils::isUnset($request->instanceIds)) {
            $query['instanceIds'] = $request->instanceIds;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->projectIds)) {
            $query['projectIds'] = $request->projectIds;
        }
        if (!Utils::isUnset($request->query)) {
            $query['query'] = $request->query;
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
            'action'      => 'SearchOranizationCustomfield',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/organizations/users/' . $userId . '/customfields/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchOranizationCustomfieldResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询企业自定义字段
     *  *
     * @param string                              $userId
     * @param SearchOranizationCustomfieldRequest $request SearchOranizationCustomfieldRequest
     *
     * @return SearchOranizationCustomfieldResponse SearchOranizationCustomfieldResponse
     */
    public function searchOranizationCustomfield($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchOranizationCustomfieldHeaders([]);

        return $this->searchOranizationCustomfieldWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询项目自定义字段
     *  *
     * @param string                          $userId
     * @param string                          $projectId
     * @param SearchProjectCustomfieldRequest $request   SearchProjectCustomfieldRequest
     * @param SearchProjectCustomfieldHeaders $headers   SearchProjectCustomfieldHeaders
     * @param RuntimeOptions                  $runtime   runtime options for this request RuntimeOptions
     *
     * @return SearchProjectCustomfieldResponse SearchProjectCustomfieldResponse
     */
    public function searchProjectCustomfieldWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->customFieldIds)) {
            $query['customFieldIds'] = $request->customFieldIds;
        }
        if (!Utils::isUnset($request->instanceIds)) {
            $query['instanceIds'] = $request->instanceIds;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->query)) {
            $query['query'] = $request->query;
        }
        if (!Utils::isUnset($request->scenarioFieldConfigId)) {
            $query['scenarioFieldConfigId'] = $request->scenarioFieldConfigId;
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
            'action'      => 'SearchProjectCustomfield',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/customfields/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchProjectCustomfieldResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询项目自定义字段
     *  *
     * @param string                          $userId
     * @param string                          $projectId
     * @param SearchProjectCustomfieldRequest $request   SearchProjectCustomfieldRequest
     *
     * @return SearchProjectCustomfieldResponse SearchProjectCustomfieldResponse
     */
    public function searchProjectCustomfield($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchProjectCustomfieldHeaders([]);

        return $this->searchProjectCustomfieldWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @summary 按项目模板名字搜索企业自定义模板
     *  *
     * @param string                       $userId
     * @param SearchProjectTemplateRequest $request SearchProjectTemplateRequest
     * @param SearchProjectTemplateHeaders $headers SearchProjectTemplateHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchProjectTemplateResponse SearchProjectTemplateResponse
     */
    public function searchProjectTemplateWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->keyword)) {
            $query['keyword'] = $request->keyword;
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
            'action'      => 'SearchProjectTemplate',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/organizations/users/' . $userId . '/templates',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchProjectTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 按项目模板名字搜索企业自定义模板
     *  *
     * @param string                       $userId
     * @param SearchProjectTemplateRequest $request SearchProjectTemplateRequest
     *
     * @return SearchProjectTemplateResponse SearchProjectTemplateResponse
     */
    public function searchProjectTemplate($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchProjectTemplateHeaders([]);

        return $this->searchProjectTemplateWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询任务工作流
     *  *
     * @param string                $userId
     * @param string                $projectId
     * @param SearchTaskFlowRequest $request   SearchTaskFlowRequest
     * @param SearchTaskFlowHeaders $headers   SearchTaskFlowHeaders
     * @param RuntimeOptions        $runtime   runtime options for this request RuntimeOptions
     *
     * @return SearchTaskFlowResponse SearchTaskFlowResponse
     */
    public function searchTaskFlowWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->query)) {
            $query['query'] = $request->query;
        }
        if (!Utils::isUnset($request->taskflowIds)) {
            $query['taskflowIds'] = $request->taskflowIds;
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
            'action'      => 'SearchTaskFlow',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/taskflows/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchTaskFlowResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询任务工作流
     *  *
     * @param string                $userId
     * @param string                $projectId
     * @param SearchTaskFlowRequest $request   SearchTaskFlowRequest
     *
     * @return SearchTaskFlowResponse SearchTaskFlowResponse
     */
    public function searchTaskFlow($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchTaskFlowHeaders([]);

        return $this->searchTaskFlowWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询任务分组
     *  *
     * @param string                $userId
     * @param string                $projectId
     * @param SearchTaskListRequest $request   SearchTaskListRequest
     * @param SearchTaskListHeaders $headers   SearchTaskListHeaders
     * @param RuntimeOptions        $runtime   runtime options for this request RuntimeOptions
     *
     * @return SearchTaskListResponse SearchTaskListResponse
     */
    public function searchTaskListWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->query)) {
            $query['query'] = $request->query;
        }
        if (!Utils::isUnset($request->taskListIds)) {
            $query['taskListIds'] = $request->taskListIds;
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
            'action'      => 'SearchTaskList',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/taskLists/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchTaskListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询任务分组
     *  *
     * @param string                $userId
     * @param string                $projectId
     * @param SearchTaskListRequest $request   SearchTaskListRequest
     *
     * @return SearchTaskListResponse SearchTaskListResponse
     */
    public function searchTaskList($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchTaskListHeaders([]);

        return $this->searchTaskListWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @summary 搜索任务工作流状态
     *  *
     * @param string                      $userId
     * @param string                      $projectId
     * @param SearchTaskflowStatusRequest $request   SearchTaskflowStatusRequest
     * @param SearchTaskflowStatusHeaders $headers   SearchTaskflowStatusHeaders
     * @param RuntimeOptions              $runtime   runtime options for this request RuntimeOptions
     *
     * @return SearchTaskflowStatusResponse SearchTaskflowStatusResponse
     */
    public function searchTaskflowStatusWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->query)) {
            $query['query'] = $request->query;
        }
        if (!Utils::isUnset($request->tfIds)) {
            $query['tfIds'] = $request->tfIds;
        }
        if (!Utils::isUnset($request->tfsIds)) {
            $query['tfsIds'] = $request->tfsIds;
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
            'action'      => 'SearchTaskflowStatus',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/taskflowStatuses/search',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchTaskflowStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 搜索任务工作流状态
     *  *
     * @param string                      $userId
     * @param string                      $projectId
     * @param SearchTaskflowStatusRequest $request   SearchTaskflowStatusRequest
     *
     * @return SearchTaskflowStatusResponse SearchTaskflowStatusResponse
     */
    public function searchTaskflowStatus($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchTaskflowStatusHeaders([]);

        return $this->searchTaskflowStatusWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询用户任务列表
     *  *
     * @param string                $userId
     * @param SearchUserTaskRequest $request SearchUserTaskRequest
     * @param SearchUserTaskHeaders $headers SearchUserTaskHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchUserTaskResponse SearchUserTaskResponse
     */
    public function searchUserTaskWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->roleTypes)) {
            $query['roleTypes'] = $request->roleTypes;
        }
        if (!Utils::isUnset($request->tql)) {
            $query['tql'] = $request->tql;
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
            'action'      => 'SearchUserTask',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tasks/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchUserTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户任务列表
     *  *
     * @param string                $userId
     * @param SearchUserTaskRequest $request SearchUserTaskRequest
     *
     * @return SearchUserTaskResponse SearchUserTaskResponse
     */
    public function searchUserTask($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchUserTaskHeaders([]);

        return $this->searchUserTaskWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 归档项目
     *  *
     * @param string                $projectId
     * @param string                $userId
     * @param SuspendProjectHeaders $headers   SuspendProjectHeaders
     * @param RuntimeOptions        $runtime   runtime options for this request RuntimeOptions
     *
     * @return SuspendProjectResponse SuspendProjectResponse
     */
    public function suspendProjectWithOptions($projectId, $userId, $headers, $runtime)
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
            'action'      => 'SuspendProject',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/suspend',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SuspendProjectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 归档项目
     *  *
     * @param string $projectId
     * @param string $userId
     *
     * @return SuspendProjectResponse SuspendProjectResponse
     */
    public function suspendProject($projectId, $userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SuspendProjectHeaders([]);

        return $this->suspendProjectWithOptions($projectId, $userId, $headers, $runtime);
    }

    /**
     * @summary 恢复项目归档
     *  *
     * @param string                  $projectId
     * @param string                  $userId
     * @param UnSuspendProjectHeaders $headers   UnSuspendProjectHeaders
     * @param RuntimeOptions          $runtime   runtime options for this request RuntimeOptions
     *
     * @return UnSuspendProjectResponse UnSuspendProjectResponse
     */
    public function unSuspendProjectWithOptions($projectId, $userId, $headers, $runtime)
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
            'action'      => 'UnSuspendProject',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/unsuspend',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UnSuspendProjectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 恢复项目归档
     *  *
     * @param string $projectId
     * @param string $userId
     *
     * @return UnSuspendProjectResponse UnSuspendProjectResponse
     */
    public function unSuspendProject($projectId, $userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnSuspendProjectHeaders([]);

        return $this->unSuspendProjectWithOptions($projectId, $userId, $headers, $runtime);
    }

    /**
     * @summary 更新任务自定义字段的值
     *  *
     * @param string                        $userId
     * @param string                        $taskId
     * @param UpdateCustomfieldValueRequest $request UpdateCustomfieldValueRequest
     * @param UpdateCustomfieldValueHeaders $headers UpdateCustomfieldValueHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateCustomfieldValueResponse UpdateCustomfieldValueResponse
     */
    public function updateCustomfieldValueWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->customFieldId)) {
            $body['customFieldId'] = $request->customFieldId;
        }
        if (!Utils::isUnset($request->customFieldName)) {
            $body['customFieldName'] = $request->customFieldName;
        }
        if (!Utils::isUnset($request->value)) {
            $body['value'] = $request->value;
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
            'action'      => 'UpdateCustomfieldValue',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/customFields',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateCustomfieldValueResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新任务自定义字段的值
     *  *
     * @param string                        $userId
     * @param string                        $taskId
     * @param UpdateCustomfieldValueRequest $request UpdateCustomfieldValueRequest
     *
     * @return UpdateCustomfieldValueResponse UpdateCustomfieldValueResponse
     */
    public function updateCustomfieldValue($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCustomfieldValueHeaders([]);

        return $this->updateCustomfieldValueWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @summary 更改自由任务标题
     *  *
     * @param string                               $taskId
     * @param string                               $userId
     * @param UpdateOrganizationTaskContentRequest $request UpdateOrganizationTaskContentRequest
     * @param UpdateOrganizationTaskContentHeaders $headers UpdateOrganizationTaskContentHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateOrganizationTaskContentResponse UpdateOrganizationTaskContentResponse
     */
    public function updateOrganizationTaskContentWithOptions($taskId, $userId, $request, $headers, $runtime)
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
            'action'      => 'UpdateOrganizationTaskContent',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/organizations/users/' . $userId . '/tasks/' . $taskId . '/contents',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateOrganizationTaskContentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更改自由任务标题
     *  *
     * @param string                               $taskId
     * @param string                               $userId
     * @param UpdateOrganizationTaskContentRequest $request UpdateOrganizationTaskContentRequest
     *
     * @return UpdateOrganizationTaskContentResponse UpdateOrganizationTaskContentResponse
     */
    public function updateOrganizationTaskContent($taskId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateOrganizationTaskContentHeaders([]);

        return $this->updateOrganizationTaskContentWithOptions($taskId, $userId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新自由任务截止时间
     *  *
     * @param string                               $taskId
     * @param string                               $userId
     * @param UpdateOrganizationTaskDueDateRequest $request UpdateOrganizationTaskDueDateRequest
     * @param UpdateOrganizationTaskDueDateHeaders $headers UpdateOrganizationTaskDueDateHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateOrganizationTaskDueDateResponse UpdateOrganizationTaskDueDateResponse
     */
    public function updateOrganizationTaskDueDateWithOptions($taskId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->disableActivity)) {
            $body['disableActivity'] = $request->disableActivity;
        }
        if (!Utils::isUnset($request->disableNotification)) {
            $body['disableNotification'] = $request->disableNotification;
        }
        if (!Utils::isUnset($request->dueDate)) {
            $body['dueDate'] = $request->dueDate;
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
            'action'      => 'UpdateOrganizationTaskDueDate',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/organizations/users/' . $userId . '/tasks/' . $taskId . '/dueDates',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateOrganizationTaskDueDateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新自由任务截止时间
     *  *
     * @param string                               $taskId
     * @param string                               $userId
     * @param UpdateOrganizationTaskDueDateRequest $request UpdateOrganizationTaskDueDateRequest
     *
     * @return UpdateOrganizationTaskDueDateResponse UpdateOrganizationTaskDueDateResponse
     */
    public function updateOrganizationTaskDueDate($taskId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateOrganizationTaskDueDateHeaders([]);

        return $this->updateOrganizationTaskDueDateWithOptions($taskId, $userId, $request, $headers, $runtime);
    }

    /**
     * @summary 更改自由任务执行者
     *  *
     * @param string                                $taskId
     * @param string                                $userId
     * @param UpdateOrganizationTaskExecutorRequest $request UpdateOrganizationTaskExecutorRequest
     * @param UpdateOrganizationTaskExecutorHeaders $headers UpdateOrganizationTaskExecutorHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateOrganizationTaskExecutorResponse UpdateOrganizationTaskExecutorResponse
     */
    public function updateOrganizationTaskExecutorWithOptions($taskId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->disableActivity)) {
            $body['disableActivity'] = $request->disableActivity;
        }
        if (!Utils::isUnset($request->disableNotification)) {
            $body['disableNotification'] = $request->disableNotification;
        }
        if (!Utils::isUnset($request->executorId)) {
            $body['executorId'] = $request->executorId;
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
            'action'      => 'UpdateOrganizationTaskExecutor',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/organizations/users/' . $userId . '/tasks/' . $taskId . '/executors',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateOrganizationTaskExecutorResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更改自由任务执行者
     *  *
     * @param string                                $taskId
     * @param string                                $userId
     * @param UpdateOrganizationTaskExecutorRequest $request UpdateOrganizationTaskExecutorRequest
     *
     * @return UpdateOrganizationTaskExecutorResponse UpdateOrganizationTaskExecutorResponse
     */
    public function updateOrganizationTaskExecutor($taskId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateOrganizationTaskExecutorHeaders([]);

        return $this->updateOrganizationTaskExecutorWithOptions($taskId, $userId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新自由任务参与者
     *  *
     * @param string                                      $taskId
     * @param string                                      $userId
     * @param UpdateOrganizationTaskInvolveMembersRequest $request UpdateOrganizationTaskInvolveMembersRequest
     * @param UpdateOrganizationTaskInvolveMembersHeaders $headers UpdateOrganizationTaskInvolveMembersHeaders
     * @param RuntimeOptions                              $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateOrganizationTaskInvolveMembersResponse UpdateOrganizationTaskInvolveMembersResponse
     */
    public function updateOrganizationTaskInvolveMembersWithOptions($taskId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->addInvolvers)) {
            $body['addInvolvers'] = $request->addInvolvers;
        }
        if (!Utils::isUnset($request->delInvolvers)) {
            $body['delInvolvers'] = $request->delInvolvers;
        }
        if (!Utils::isUnset($request->disableActivity)) {
            $body['disableActivity'] = $request->disableActivity;
        }
        if (!Utils::isUnset($request->disableNotification)) {
            $body['disableNotification'] = $request->disableNotification;
        }
        if (!Utils::isUnset($request->involveMembers)) {
            $body['involveMembers'] = $request->involveMembers;
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
            'action'      => 'UpdateOrganizationTaskInvolveMembers',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/organizations/users/' . $userId . '/tasks/' . $taskId . '/involveMembers',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateOrganizationTaskInvolveMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新自由任务参与者
     *  *
     * @param string                                      $taskId
     * @param string                                      $userId
     * @param UpdateOrganizationTaskInvolveMembersRequest $request UpdateOrganizationTaskInvolveMembersRequest
     *
     * @return UpdateOrganizationTaskInvolveMembersResponse UpdateOrganizationTaskInvolveMembersResponse
     */
    public function updateOrganizationTaskInvolveMembers($taskId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateOrganizationTaskInvolveMembersHeaders([]);

        return $this->updateOrganizationTaskInvolveMembersWithOptions($taskId, $userId, $request, $headers, $runtime);
    }

    /**
     * @summary 更改自由任务备注
     *  *
     * @param string                            $taskId
     * @param string                            $userId
     * @param UpdateOrganizationTaskNoteRequest $request UpdateOrganizationTaskNoteRequest
     * @param UpdateOrganizationTaskNoteHeaders $headers UpdateOrganizationTaskNoteHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateOrganizationTaskNoteResponse UpdateOrganizationTaskNoteResponse
     */
    public function updateOrganizationTaskNoteWithOptions($taskId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->disableActivity)) {
            $body['disableActivity'] = $request->disableActivity;
        }
        if (!Utils::isUnset($request->disableNotification)) {
            $body['disableNotification'] = $request->disableNotification;
        }
        if (!Utils::isUnset($request->note)) {
            $body['note'] = $request->note;
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
            'action'      => 'UpdateOrganizationTaskNote',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/organizations/users/' . $userId . '/tasks/' . $taskId . '/notes',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateOrganizationTaskNoteResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更改自由任务备注
     *  *
     * @param string                            $taskId
     * @param string                            $userId
     * @param UpdateOrganizationTaskNoteRequest $request UpdateOrganizationTaskNoteRequest
     *
     * @return UpdateOrganizationTaskNoteResponse UpdateOrganizationTaskNoteResponse
     */
    public function updateOrganizationTaskNote($taskId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateOrganizationTaskNoteHeaders([]);

        return $this->updateOrganizationTaskNoteWithOptions($taskId, $userId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新自由任务优先级
     *  *
     * @param string                                $taskId
     * @param string                                $userId
     * @param UpdateOrganizationTaskPriorityRequest $request UpdateOrganizationTaskPriorityRequest
     * @param UpdateOrganizationTaskPriorityHeaders $headers UpdateOrganizationTaskPriorityHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateOrganizationTaskPriorityResponse UpdateOrganizationTaskPriorityResponse
     */
    public function updateOrganizationTaskPriorityWithOptions($taskId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->disableActivity)) {
            $body['disableActivity'] = $request->disableActivity;
        }
        if (!Utils::isUnset($request->disableNotification)) {
            $body['disableNotification'] = $request->disableNotification;
        }
        if (!Utils::isUnset($request->priority)) {
            $body['priority'] = $request->priority;
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
            'action'      => 'UpdateOrganizationTaskPriority',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/organizations/users/' . $userId . '/tasks/' . $taskId . '/priorities',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateOrganizationTaskPriorityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新自由任务优先级
     *  *
     * @param string                                $taskId
     * @param string                                $userId
     * @param UpdateOrganizationTaskPriorityRequest $request UpdateOrganizationTaskPriorityRequest
     *
     * @return UpdateOrganizationTaskPriorityResponse UpdateOrganizationTaskPriorityResponse
     */
    public function updateOrganizationTaskPriority($taskId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateOrganizationTaskPriorityHeaders([]);

        return $this->updateOrganizationTaskPriorityWithOptions($taskId, $userId, $request, $headers, $runtime);
    }

    /**
     * @summary 更改自由任务状态
     *  *
     * @param string                              $taskId
     * @param string                              $userId
     * @param UpdateOrganizationTaskStatusRequest $request UpdateOrganizationTaskStatusRequest
     * @param UpdateOrganizationTaskStatusHeaders $headers UpdateOrganizationTaskStatusHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateOrganizationTaskStatusResponse UpdateOrganizationTaskStatusResponse
     */
    public function updateOrganizationTaskStatusWithOptions($taskId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->disableActivity)) {
            $body['disableActivity'] = $request->disableActivity;
        }
        if (!Utils::isUnset($request->disableNotification)) {
            $body['disableNotification'] = $request->disableNotification;
        }
        if (!Utils::isUnset($request->isDone)) {
            $body['isDone'] = $request->isDone;
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
            'action'      => 'UpdateOrganizationTaskStatus',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/organizations/users/' . $userId . '/tasks/' . $taskId . '/states',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateOrganizationTaskStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更改自由任务状态
     *  *
     * @param string                              $taskId
     * @param string                              $userId
     * @param UpdateOrganizationTaskStatusRequest $request UpdateOrganizationTaskStatusRequest
     *
     * @return UpdateOrganizationTaskStatusResponse UpdateOrganizationTaskStatusResponse
     */
    public function updateOrganizationTaskStatus($taskId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateOrganizationTaskStatusHeaders([]);

        return $this->updateOrganizationTaskStatusWithOptions($taskId, $userId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新项目的分组
     *  *
     * @param string                    $userId
     * @param string                    $projectId
     * @param UpdateProjectGroupRequest $request   UpdateProjectGroupRequest
     * @param UpdateProjectGroupHeaders $headers   UpdateProjectGroupHeaders
     * @param RuntimeOptions            $runtime   runtime options for this request RuntimeOptions
     *
     * @return UpdateProjectGroupResponse UpdateProjectGroupResponse
     */
    public function updateProjectGroupWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->addProjectGroupIds)) {
            $body['addProjectGroupIds'] = $request->addProjectGroupIds;
        }
        if (!Utils::isUnset($request->delProjectGroupIds)) {
            $body['delProjectGroupIds'] = $request->delProjectGroupIds;
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
            'action'      => 'UpdateProjectGroup',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/groups',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateProjectGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新项目的分组
     *  *
     * @param string                    $userId
     * @param string                    $projectId
     * @param UpdateProjectGroupRequest $request   UpdateProjectGroupRequest
     *
     * @return UpdateProjectGroupResponse UpdateProjectGroupResponse
     */
    public function updateProjectGroup($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateProjectGroupHeaders([]);

        return $this->updateProjectGroupWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新任务标题
     *  *
     * @param string                   $userId
     * @param string                   $taskId
     * @param UpdateTaskContentRequest $request UpdateTaskContentRequest
     * @param UpdateTaskContentHeaders $headers UpdateTaskContentHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTaskContentResponse UpdateTaskContentResponse
     */
    public function updateTaskContentWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
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
            'action'      => 'UpdateTaskContent',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/contents',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateTaskContentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新任务标题
     *  *
     * @param string                   $userId
     * @param string                   $taskId
     * @param UpdateTaskContentRequest $request UpdateTaskContentRequest
     *
     * @return UpdateTaskContentResponse UpdateTaskContentResponse
     */
    public function updateTaskContent($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskContentHeaders([]);

        return $this->updateTaskContentWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新任务截止时间
     *  *
     * @param string                   $userId
     * @param string                   $taskId
     * @param UpdateTaskDueDateRequest $request UpdateTaskDueDateRequest
     * @param UpdateTaskDueDateHeaders $headers UpdateTaskDueDateHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTaskDueDateResponse UpdateTaskDueDateResponse
     */
    public function updateTaskDueDateWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dueDate)) {
            $body['dueDate'] = $request->dueDate;
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
            'action'      => 'UpdateTaskDueDate',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/dueDates',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateTaskDueDateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新任务截止时间
     *  *
     * @param string                   $userId
     * @param string                   $taskId
     * @param UpdateTaskDueDateRequest $request UpdateTaskDueDateRequest
     *
     * @return UpdateTaskDueDateResponse UpdateTaskDueDateResponse
     */
    public function updateTaskDueDate($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskDueDateHeaders([]);

        return $this->updateTaskDueDateWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新任务执行者
     *  *
     * @param string                    $userId
     * @param string                    $taskId
     * @param UpdateTaskExecutorRequest $request UpdateTaskExecutorRequest
     * @param UpdateTaskExecutorHeaders $headers UpdateTaskExecutorHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTaskExecutorResponse UpdateTaskExecutorResponse
     */
    public function updateTaskExecutorWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->executorId)) {
            $body['executorId'] = $request->executorId;
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
            'action'      => 'UpdateTaskExecutor',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/executors',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateTaskExecutorResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新任务执行者
     *  *
     * @param string                    $userId
     * @param string                    $taskId
     * @param UpdateTaskExecutorRequest $request UpdateTaskExecutorRequest
     *
     * @return UpdateTaskExecutorResponse UpdateTaskExecutorResponse
     */
    public function updateTaskExecutor($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskExecutorHeaders([]);

        return $this->updateTaskExecutorWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新任务参与者
     *  *
     * @param string                          $userId
     * @param string                          $taskId
     * @param UpdateTaskInvolvemembersRequest $request UpdateTaskInvolvemembersRequest
     * @param UpdateTaskInvolvemembersHeaders $headers UpdateTaskInvolvemembersHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTaskInvolvemembersResponse UpdateTaskInvolvemembersResponse
     */
    public function updateTaskInvolvemembersWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->addInvolvers)) {
            $body['addInvolvers'] = $request->addInvolvers;
        }
        if (!Utils::isUnset($request->delInvolvers)) {
            $body['delInvolvers'] = $request->delInvolvers;
        }
        if (!Utils::isUnset($request->involveMembers)) {
            $body['involveMembers'] = $request->involveMembers;
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
            'action'      => 'UpdateTaskInvolvemembers',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/involveMembers',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateTaskInvolvemembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新任务参与者
     *  *
     * @param string                          $userId
     * @param string                          $taskId
     * @param UpdateTaskInvolvemembersRequest $request UpdateTaskInvolvemembersRequest
     *
     * @return UpdateTaskInvolvemembersResponse UpdateTaskInvolvemembersResponse
     */
    public function updateTaskInvolvemembers($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskInvolvemembersHeaders([]);

        return $this->updateTaskInvolvemembersWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新任务备注
     *  *
     * @param string                $userId
     * @param string                $taskId
     * @param UpdateTaskNoteRequest $request UpdateTaskNoteRequest
     * @param UpdateTaskNoteHeaders $headers UpdateTaskNoteHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTaskNoteResponse UpdateTaskNoteResponse
     */
    public function updateTaskNoteWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->note)) {
            $body['note'] = $request->note;
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
            'action'      => 'UpdateTaskNote',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/notes',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateTaskNoteResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新任务备注
     *  *
     * @param string                $userId
     * @param string                $taskId
     * @param UpdateTaskNoteRequest $request UpdateTaskNoteRequest
     *
     * @return UpdateTaskNoteResponse UpdateTaskNoteResponse
     */
    public function updateTaskNote($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskNoteHeaders([]);

        return $this->updateTaskNoteWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新任务优先级
     *  *
     * @param string                    $userId
     * @param string                    $taskId
     * @param UpdateTaskPriorityRequest $request UpdateTaskPriorityRequest
     * @param UpdateTaskPriorityHeaders $headers UpdateTaskPriorityHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTaskPriorityResponse UpdateTaskPriorityResponse
     */
    public function updateTaskPriorityWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->priority)) {
            $body['priority'] = $request->priority;
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
            'action'      => 'UpdateTaskPriority',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/priorities',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateTaskPriorityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新任务优先级
     *  *
     * @param string                    $userId
     * @param string                    $taskId
     * @param UpdateTaskPriorityRequest $request UpdateTaskPriorityRequest
     *
     * @return UpdateTaskPriorityResponse UpdateTaskPriorityResponse
     */
    public function updateTaskPriority($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskPriorityHeaders([]);

        return $this->updateTaskPriorityWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新任务列表
     *  *
     * @param string                 $userId
     * @param string                 $taskId
     * @param UpdateTaskStageRequest $request UpdateTaskStageRequest
     * @param UpdateTaskStageHeaders $headers UpdateTaskStageHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTaskStageResponse UpdateTaskStageResponse
     */
    public function updateTaskStageWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->taskStageId)) {
            $body['taskStageId'] = $request->taskStageId;
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
            'action'      => 'UpdateTaskStage',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/stages',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateTaskStageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新任务列表
     *  *
     * @param string                 $userId
     * @param string                 $taskId
     * @param UpdateTaskStageRequest $request UpdateTaskStageRequest
     *
     * @return UpdateTaskStageResponse UpdateTaskStageResponse
     */
    public function updateTaskStage($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskStageHeaders([]);

        return $this->updateTaskStageWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新任务开始时间
     *  *
     * @param string                     $userId
     * @param string                     $taskId
     * @param UpdateTaskStartdateRequest $request UpdateTaskStartdateRequest
     * @param UpdateTaskStartdateHeaders $headers UpdateTaskStartdateHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTaskStartdateResponse UpdateTaskStartdateResponse
     */
    public function updateTaskStartdateWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->startDate)) {
            $body['startDate'] = $request->startDate;
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
            'action'      => 'UpdateTaskStartdate',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/startDates',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateTaskStartdateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新任务开始时间
     *  *
     * @param string                     $userId
     * @param string                     $taskId
     * @param UpdateTaskStartdateRequest $request UpdateTaskStartdateRequest
     *
     * @return UpdateTaskStartdateResponse UpdateTaskStartdateResponse
     */
    public function updateTaskStartdate($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskStartdateHeaders([]);

        return $this->updateTaskStartdateWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新任务工作流状态
     *  *
     * @param string                          $userId
     * @param string                          $taskId
     * @param UpdateTaskTaskflowstatusRequest $request UpdateTaskTaskflowstatusRequest
     * @param UpdateTaskTaskflowstatusHeaders $headers UpdateTaskTaskflowstatusHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTaskTaskflowstatusResponse UpdateTaskTaskflowstatusResponse
     */
    public function updateTaskTaskflowstatusWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->taskflowStatusId)) {
            $body['taskflowStatusId'] = $request->taskflowStatusId;
        }
        if (!Utils::isUnset($request->taskflowStatusUpdateNote)) {
            $body['taskflowStatusUpdateNote'] = $request->taskflowStatusUpdateNote;
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
            'action'      => 'UpdateTaskTaskflowstatus',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/taskflowStatuses',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateTaskTaskflowstatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新任务工作流状态
     *  *
     * @param string                          $userId
     * @param string                          $taskId
     * @param UpdateTaskTaskflowstatusRequest $request UpdateTaskTaskflowstatusRequest
     *
     * @return UpdateTaskTaskflowstatusResponse UpdateTaskTaskflowstatusResponse
     */
    public function updateTaskTaskflowstatus($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskTaskflowstatusHeaders([]);

        return $this->updateTaskTaskflowstatusWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新工时审批对象
     *  *
     * @param string                       $userId
     * @param string                       $approveOpenId
     * @param UpdateWorkTimeApproveRequest $request       UpdateWorkTimeApproveRequest
     * @param UpdateWorkTimeApproveHeaders $headers       UpdateWorkTimeApproveHeaders
     * @param RuntimeOptions               $runtime       runtime options for this request RuntimeOptions
     *
     * @return UpdateWorkTimeApproveResponse UpdateWorkTimeApproveResponse
     */
    public function updateWorkTimeApproveWithOptions($userId, $approveOpenId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->finishTime)) {
            $body['finishTime'] = $request->finishTime;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->submitTime)) {
            $body['submitTime'] = $request->submitTime;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->url)) {
            $body['url'] = $request->url;
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
            'action'      => 'UpdateWorkTimeApprove',
            'version'     => 'project_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/project/users/' . $userId . '/workTimes/approvals/' . $approveOpenId . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateWorkTimeApproveResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新工时审批对象
     *  *
     * @param string                       $userId
     * @param string                       $approveOpenId
     * @param UpdateWorkTimeApproveRequest $request       UpdateWorkTimeApproveRequest
     *
     * @return UpdateWorkTimeApproveResponse UpdateWorkTimeApproveResponse
     */
    public function updateWorkTimeApprove($userId, $approveOpenId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateWorkTimeApproveHeaders([]);

        return $this->updateWorkTimeApproveWithOptions($userId, $approveOpenId, $request, $headers, $runtime);
    }
}
