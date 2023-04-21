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
     * @param string                  $userId
     * @param string                  $projectId
     * @param AddProjectMemberRequest $request
     *
     * @return AddProjectMemberResponse
     */
    public function addProjectMember($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddProjectMemberHeaders([]);

        return $this->addProjectMemberWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $userId
     * @param string                  $projectId
     * @param AddProjectMemberRequest $request
     * @param AddProjectMemberHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return AddProjectMemberResponse
     */
    public function addProjectMemberWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId    = OpenApiUtilClient::getEncodeParam($userId);
        $projectId = OpenApiUtilClient::getEncodeParam($projectId);
        $body      = [];
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
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

        return AddProjectMemberResponse::fromMap($this->doROARequest('AddProjectMember', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/members', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     * @param string $projectId
     *
     * @return ArchiveProjectResponse
     */
    public function archiveProject($userId, $projectId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ArchiveProjectHeaders([]);

        return $this->archiveProjectWithOptions($userId, $projectId, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param string                $projectId
     * @param ArchiveProjectHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return ArchiveProjectResponse
     */
    public function archiveProjectWithOptions($userId, $projectId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $projectId   = OpenApiUtilClient::getEncodeParam($projectId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return ArchiveProjectResponse::fromMap($this->doROARequest('ArchiveProject', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/archive', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     * @param string $taskId
     *
     * @return ArchiveTaskResponse
     */
    public function archiveTask($userId, $taskId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ArchiveTaskHeaders([]);

        return $this->archiveTaskWithOptions($userId, $taskId, $headers, $runtime);
    }

    /**
     * @param string             $userId
     * @param string             $taskId
     * @param ArchiveTaskHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return ArchiveTaskResponse
     */
    public function archiveTaskWithOptions($userId, $taskId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $taskId      = OpenApiUtilClient::getEncodeParam($taskId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return ArchiveTaskResponse::fromMap($this->doROARequest('ArchiveTask', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/archive', 'json', $req, $runtime));
    }

    /**
     * @param string                        $userId
     * @param CreateOrganizationTaskRequest $request
     *
     * @return CreateOrganizationTaskResponse
     */
    public function createOrganizationTask($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateOrganizationTaskHeaders([]);

        return $this->createOrganizationTaskWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                        $userId
     * @param CreateOrganizationTaskRequest $request
     * @param CreateOrganizationTaskHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CreateOrganizationTaskResponse
     */
    public function createOrganizationTaskWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->createTime)) {
            @$body['createTime'] = $request->createTime;
        }
        if (!Utils::isUnset($request->disableActivity)) {
            @$body['disableActivity'] = $request->disableActivity;
        }
        if (!Utils::isUnset($request->disableNotification)) {
            @$body['disableNotification'] = $request->disableNotification;
        }
        if (!Utils::isUnset($request->dueDate)) {
            @$body['dueDate'] = $request->dueDate;
        }
        if (!Utils::isUnset($request->executorId)) {
            @$body['executorId'] = $request->executorId;
        }
        if (!Utils::isUnset($request->involveMembers)) {
            @$body['involveMembers'] = $request->involveMembers;
        }
        if (!Utils::isUnset($request->note)) {
            @$body['note'] = $request->note;
        }
        if (!Utils::isUnset($request->priority)) {
            @$body['priority'] = $request->priority;
        }
        if (!Utils::isUnset($request->visible)) {
            @$body['visible'] = $request->visible;
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

        return CreateOrganizationTaskResponse::fromMap($this->doROARequest('CreateOrganizationTask', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/organizations/users/' . $userId . '/tasks', 'json', $req, $runtime));
    }

    /**
     * @param string                $userId
     * @param CreatePlanTimeRequest $request
     *
     * @return CreatePlanTimeResponse
     */
    public function createPlanTime($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreatePlanTimeHeaders([]);

        return $this->createPlanTimeWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param CreatePlanTimeRequest $request
     * @param CreatePlanTimeHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreatePlanTimeResponse
     */
    public function createPlanTimeWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $query  = [];
        if (!Utils::isUnset($request->tenantType)) {
            @$query['tenantType'] = $request->tenantType;
        }
        $body = [];
        if (!Utils::isUnset($request->endDate)) {
            @$body['endDate'] = $request->endDate;
        }
        if (!Utils::isUnset($request->executorId)) {
            @$body['executorId'] = $request->executorId;
        }
        if (!Utils::isUnset($request->includesHolidays)) {
            @$body['includesHolidays'] = $request->includesHolidays;
        }
        if (!Utils::isUnset($request->isDuration)) {
            @$body['isDuration'] = $request->isDuration;
        }
        if (!Utils::isUnset($request->objectId)) {
            @$body['objectId'] = $request->objectId;
        }
        if (!Utils::isUnset($request->objectType)) {
            @$body['objectType'] = $request->objectType;
        }
        if (!Utils::isUnset($request->planTime)) {
            @$body['planTime'] = $request->planTime;
        }
        if (!Utils::isUnset($request->startDate)) {
            @$body['startDate'] = $request->startDate;
        }
        if (!Utils::isUnset($request->submitterId)) {
            @$body['submitterId'] = $request->submitterId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreatePlanTimeResponse::fromMap($this->doROARequest('CreatePlanTime', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/planTimes', 'json', $req, $runtime));
    }

    /**
     * @param string               $userId
     * @param CreateProjectRequest $request
     *
     * @return CreateProjectResponse
     */
    public function createProject($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateProjectHeaders([]);

        return $this->createProjectWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string               $userId
     * @param CreateProjectRequest $request
     * @param CreateProjectHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return CreateProjectResponse
     */
    public function createProjectWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
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

        return CreateProjectResponse::fromMap($this->doROARequest('CreateProject', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/projects', 'json', $req, $runtime));
    }

    /**
     * @param string                         $userId
     * @param CreateProjectByTemplateRequest $request
     *
     * @return CreateProjectByTemplateResponse
     */
    public function createProjectByTemplate($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateProjectByTemplateHeaders([]);

        return $this->createProjectByTemplateWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                         $userId
     * @param CreateProjectByTemplateRequest $request
     * @param CreateProjectByTemplateHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CreateProjectByTemplateResponse
     */
    public function createProjectByTemplateWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->templateId)) {
            @$body['templateId'] = $request->templateId;
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

        return CreateProjectByTemplateResponse::fromMap($this->doROARequest('CreateProjectByTemplate', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/templates/projects', 'json', $req, $runtime));
    }

    /**
     * @param string                                $userId
     * @param string                                $projectId
     * @param CreateProjectCustomfieldStatusRequest $request
     *
     * @return CreateProjectCustomfieldStatusResponse
     */
    public function createProjectCustomfieldStatus($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateProjectCustomfieldStatusHeaders([]);

        return $this->createProjectCustomfieldStatusWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @param string                                $userId
     * @param string                                $projectId
     * @param CreateProjectCustomfieldStatusRequest $request
     * @param CreateProjectCustomfieldStatusHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return CreateProjectCustomfieldStatusResponse
     */
    public function createProjectCustomfieldStatusWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId    = OpenApiUtilClient::getEncodeParam($userId);
        $projectId = OpenApiUtilClient::getEncodeParam($projectId);
        $body      = [];
        if (!Utils::isUnset($request->customfieldId)) {
            @$body['customfieldId'] = $request->customfieldId;
        }
        if (!Utils::isUnset($request->customfieldInstanceId)) {
            @$body['customfieldInstanceId'] = $request->customfieldInstanceId;
        }
        if (!Utils::isUnset($request->customfieldName)) {
            @$body['customfieldName'] = $request->customfieldName;
        }
        if (!Utils::isUnset($request->value)) {
            @$body['value'] = $request->value;
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

        return CreateProjectCustomfieldStatusResponse::fromMap($this->doROARequest('CreateProjectCustomfieldStatus', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/customfields', 'json', $req, $runtime));
    }

    /**
     * @param string            $userId
     * @param CreateTaskRequest $request
     *
     * @return CreateTaskResponse
     */
    public function createTask($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTaskHeaders([]);

        return $this->createTaskWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string            $userId
     * @param CreateTaskRequest $request
     * @param CreateTaskHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return CreateTaskResponse
     */
    public function createTaskWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->customfields)) {
            @$body['customfields'] = $request->customfields;
        }
        if (!Utils::isUnset($request->dueDate)) {
            @$body['dueDate'] = $request->dueDate;
        }
        if (!Utils::isUnset($request->executorId)) {
            @$body['executorId'] = $request->executorId;
        }
        if (!Utils::isUnset($request->note)) {
            @$body['note'] = $request->note;
        }
        if (!Utils::isUnset($request->parentTaskId)) {
            @$body['parentTaskId'] = $request->parentTaskId;
        }
        if (!Utils::isUnset($request->priority)) {
            @$body['priority'] = $request->priority;
        }
        if (!Utils::isUnset($request->projectId)) {
            @$body['projectId'] = $request->projectId;
        }
        if (!Utils::isUnset($request->scenariofieldconfigId)) {
            @$body['scenariofieldconfigId'] = $request->scenariofieldconfigId;
        }
        if (!Utils::isUnset($request->stageId)) {
            @$body['stageId'] = $request->stageId;
        }
        if (!Utils::isUnset($request->startDate)) {
            @$body['startDate'] = $request->startDate;
        }
        if (!Utils::isUnset($request->visible)) {
            @$body['visible'] = $request->visible;
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

        return CreateTaskResponse::fromMap($this->doROARequest('CreateTask', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/tasks', 'json', $req, $runtime));
    }

    /**
     * @param string                      $userId
     * @param string                      $taskId
     * @param CreateTaskObjectLinkRequest $request
     *
     * @return CreateTaskObjectLinkResponse
     */
    public function createTaskObjectLink($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTaskObjectLinkHeaders([]);

        return $this->createTaskObjectLinkWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $userId
     * @param string                      $taskId
     * @param CreateTaskObjectLinkRequest $request
     * @param CreateTaskObjectLinkHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return CreateTaskObjectLinkResponse
     */
    public function createTaskObjectLinkWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $body   = [];
        if (!Utils::isUnset($request->linkedData)) {
            @$body['linkedData'] = $request->linkedData;
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

        return CreateTaskObjectLinkResponse::fromMap($this->doROARequest('CreateTaskObjectLink', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/objectLinks', 'json', $req, $runtime));
    }

    /**
     * @param string                $userId
     * @param CreateWorkTimeRequest $request
     *
     * @return CreateWorkTimeResponse
     */
    public function createWorkTime($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateWorkTimeHeaders([]);

        return $this->createWorkTimeWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param CreateWorkTimeRequest $request
     * @param CreateWorkTimeHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreateWorkTimeResponse
     */
    public function createWorkTimeWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $query  = [];
        if (!Utils::isUnset($request->tenantType)) {
            @$query['tenantType'] = $request->tenantType;
        }
        $body = [];
        if (!Utils::isUnset($request->endDate)) {
            @$body['endDate'] = $request->endDate;
        }
        if (!Utils::isUnset($request->executorId)) {
            @$body['executorId'] = $request->executorId;
        }
        if (!Utils::isUnset($request->includesHolidays)) {
            @$body['includesHolidays'] = $request->includesHolidays;
        }
        if (!Utils::isUnset($request->isDuration)) {
            @$body['isDuration'] = $request->isDuration;
        }
        if (!Utils::isUnset($request->objectId)) {
            @$body['objectId'] = $request->objectId;
        }
        if (!Utils::isUnset($request->objectType)) {
            @$body['objectType'] = $request->objectType;
        }
        if (!Utils::isUnset($request->startDate)) {
            @$body['startDate'] = $request->startDate;
        }
        if (!Utils::isUnset($request->submitterId)) {
            @$body['submitterId'] = $request->submitterId;
        }
        if (!Utils::isUnset($request->workTime)) {
            @$body['workTime'] = $request->workTime;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateWorkTimeResponse::fromMap($this->doROARequest('CreateWorkTime', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/workTimes', 'json', $req, $runtime));
    }

    /**
     * @param string                     $userId
     * @param string                     $projectId
     * @param DeleteProjectMemberRequest $request
     *
     * @return DeleteProjectMemberResponse
     */
    public function deleteProjectMember($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteProjectMemberHeaders([]);

        return $this->deleteProjectMemberWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $userId
     * @param string                     $projectId
     * @param DeleteProjectMemberRequest $request
     * @param DeleteProjectMemberHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return DeleteProjectMemberResponse
     */
    public function deleteProjectMemberWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId    = OpenApiUtilClient::getEncodeParam($userId);
        $projectId = OpenApiUtilClient::getEncodeParam($projectId);
        $body      = [];
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
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

        return DeleteProjectMemberResponse::fromMap($this->doROARequest('DeleteProjectMember', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/members/remove', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     * @param string $taskId
     *
     * @return DeleteTaskResponse
     */
    public function deleteTask($userId, $taskId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteTaskHeaders([]);

        return $this->deleteTaskWithOptions($userId, $taskId, $headers, $runtime);
    }

    /**
     * @param string            $userId
     * @param string            $taskId
     * @param DeleteTaskHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return DeleteTaskResponse
     */
    public function deleteTaskWithOptions($userId, $taskId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $taskId      = OpenApiUtilClient::getEncodeParam($taskId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return DeleteTaskResponse::fromMap($this->doROARequest('DeleteTask', 'project_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '', 'json', $req, $runtime));
    }

    /**
     * @param GetDeptsByOrgIdRequest $request
     *
     * @return GetDeptsByOrgIdResponse
     */
    public function getDeptsByOrgId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDeptsByOrgIdHeaders([]);

        return $this->getDeptsByOrgIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetDeptsByOrgIdRequest $request
     * @param GetDeptsByOrgIdHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetDeptsByOrgIdResponse
     */
    public function getDeptsByOrgIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->dingAccessTokenType)) {
            @$realHeaders['dingAccessTokenType'] = Utils::toJSONString($headers->dingAccessTokenType);
        }
        if (!Utils::isUnset($headers->dingOrgId)) {
            @$realHeaders['dingOrgId'] = Utils::toJSONString($headers->dingOrgId);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetDeptsByOrgIdResponse::fromMap($this->doROARequest('GetDeptsByOrgId', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/orgs/depts', 'json', $req, $runtime));
    }

    /**
     * @param GetEmpsByOrgIdRequest $request
     *
     * @return GetEmpsByOrgIdResponse
     */
    public function getEmpsByOrgId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetEmpsByOrgIdHeaders([]);

        return $this->getEmpsByOrgIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetEmpsByOrgIdRequest $request
     * @param GetEmpsByOrgIdHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetEmpsByOrgIdResponse
     */
    public function getEmpsByOrgIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->needDept)) {
            @$query['needDept'] = $request->needDept;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->dingAccessTokenType)) {
            @$realHeaders['dingAccessTokenType'] = Utils::toJSONString($headers->dingAccessTokenType);
        }
        if (!Utils::isUnset($headers->dingOrgId)) {
            @$realHeaders['dingOrgId'] = Utils::toJSONString($headers->dingOrgId);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetEmpsByOrgIdResponse::fromMap($this->doROARequest('GetEmpsByOrgId', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/orgs/employees', 'json', $req, $runtime));
    }

    /**
     * @param string                         $userId
     * @param GetOrganizatioTaskByIdsRequest $request
     *
     * @return GetOrganizatioTaskByIdsResponse
     */
    public function getOrganizatioTaskByIds($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOrganizatioTaskByIdsHeaders([]);

        return $this->getOrganizatioTaskByIdsWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                         $userId
     * @param GetOrganizatioTaskByIdsRequest $request
     * @param GetOrganizatioTaskByIdsHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return GetOrganizatioTaskByIdsResponse
     */
    public function getOrganizatioTaskByIdsWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $query  = [];
        if (!Utils::isUnset($request->taskIds)) {
            @$query['taskIds'] = $request->taskIds;
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

        return GetOrganizatioTaskByIdsResponse::fromMap($this->doROARequest('GetOrganizatioTaskByIds', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/organizations/users/' . $userId . '/tasks', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return GetOrganizationPriorityListResponse
     */
    public function getOrganizationPriorityList($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOrganizationPriorityListHeaders([]);

        return $this->getOrganizationPriorityListWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string                             $userId
     * @param GetOrganizationPriorityListHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return GetOrganizationPriorityListResponse
     */
    public function getOrganizationPriorityListWithOptions($userId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetOrganizationPriorityListResponse::fromMap($this->doROARequest('GetOrganizationPriorityList', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/organizations/users/' . $userId . '/priorities', 'json', $req, $runtime));
    }

    /**
     * @param string $taskId
     * @param string $userId
     *
     * @return GetOrganizationTaskResponse
     */
    public function getOrganizationTask($taskId, $userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOrganizationTaskHeaders([]);

        return $this->getOrganizationTaskWithOptions($taskId, $userId, $headers, $runtime);
    }

    /**
     * @param string                     $taskId
     * @param string                     $userId
     * @param GetOrganizationTaskHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetOrganizationTaskResponse
     */
    public function getOrganizationTaskWithOptions($taskId, $userId, $headers, $runtime)
    {
        $taskId      = OpenApiUtilClient::getEncodeParam($taskId);
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetOrganizationTaskResponse::fromMap($this->doROARequest('GetOrganizationTask', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/organizations/users/' . $userId . '/tasks/' . $taskId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                 $userId
     * @param GetProjectGroupRequest $request
     *
     * @return GetProjectGroupResponse
     */
    public function getProjectGroup($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProjectGroupHeaders([]);

        return $this->getProjectGroupWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $userId
     * @param GetProjectGroupRequest $request
     * @param GetProjectGroupHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetProjectGroupResponse
     */
    public function getProjectGroupWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $query  = [];
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->viewerId)) {
            @$query['viewerId'] = $request->viewerId;
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

        return GetProjectGroupResponse::fromMap($this->doROARequest('GetProjectGroup', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/organizations/users/' . $userId . '/groups', 'json', $req, $runtime));
    }

    /**
     * @param string                    $userId
     * @param string                    $projectId
     * @param GetProjectMemebersRequest $request
     *
     * @return GetProjectMemebersResponse
     */
    public function getProjectMemebers($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProjectMemebersHeaders([]);

        return $this->getProjectMemebersWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @param string                    $userId
     * @param string                    $projectId
     * @param GetProjectMemebersRequest $request
     * @param GetProjectMemebersHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetProjectMemebersResponse
     */
    public function getProjectMemebersWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId    = OpenApiUtilClient::getEncodeParam($userId);
        $projectId = OpenApiUtilClient::getEncodeParam($projectId);
        $query     = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->projectRoleId)) {
            @$query['projectRoleId'] = $request->projectRoleId;
        }
        if (!Utils::isUnset($request->skip)) {
            @$query['skip'] = $request->skip;
        }
        if (!Utils::isUnset($request->userIds)) {
            @$query['userIds'] = $request->userIds;
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

        return GetProjectMemebersResponse::fromMap($this->doROARequest('GetProjectMemebers', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/members', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     * @param string $projectId
     *
     * @return GetProjectStatusListResponse
     */
    public function getProjectStatusList($userId, $projectId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProjectStatusListHeaders([]);

        return $this->getProjectStatusListWithOptions($userId, $projectId, $headers, $runtime);
    }

    /**
     * @param string                      $userId
     * @param string                      $projectId
     * @param GetProjectStatusListHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetProjectStatusListResponse
     */
    public function getProjectStatusListWithOptions($userId, $projectId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $projectId   = OpenApiUtilClient::getEncodeParam($projectId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetProjectStatusListResponse::fromMap($this->doROARequest('GetProjectStatusList', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/statuses', 'json', $req, $runtime));
    }

    /**
     * @param string              $userId
     * @param GetTaskByIdsRequest $request
     *
     * @return GetTaskByIdsResponse
     */
    public function getTaskByIds($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTaskByIdsHeaders([]);

        return $this->getTaskByIdsWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string              $userId
     * @param GetTaskByIdsRequest $request
     * @param GetTaskByIdsHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetTaskByIdsResponse
     */
    public function getTaskByIdsWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $query  = [];
        if (!Utils::isUnset($request->parentTaskId)) {
            @$query['parentTaskId'] = $request->parentTaskId;
        }
        if (!Utils::isUnset($request->taskId)) {
            @$query['taskId'] = $request->taskId;
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

        return GetTaskByIdsResponse::fromMap($this->doROARequest('GetTaskByIds', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/users/' . $userId . '/tasks', 'json', $req, $runtime));
    }

    /**
     * @param GetTbOrgIdByDingOrgIdRequest $request
     *
     * @return GetTbOrgIdByDingOrgIdResponse
     */
    public function getTbOrgIdByDingOrgId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTbOrgIdByDingOrgIdHeaders([]);

        return $this->getTbOrgIdByDingOrgIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetTbOrgIdByDingOrgIdRequest $request
     * @param GetTbOrgIdByDingOrgIdHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GetTbOrgIdByDingOrgIdResponse
     */
    public function getTbOrgIdByDingOrgIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->optUserId)) {
            @$query['optUserId'] = $request->optUserId;
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

        return GetTbOrgIdByDingOrgIdResponse::fromMap($this->doROARequest('GetTbOrgIdByDingOrgId', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/teambition/organizations', 'json', $req, $runtime));
    }

    /**
     * @param GetTbProjectGrayRequest $request
     *
     * @return GetTbProjectGrayResponse
     */
    public function getTbProjectGray($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTbProjectGrayHeaders([]);

        return $this->getTbProjectGrayWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetTbProjectGrayRequest $request
     * @param GetTbProjectGrayHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetTbProjectGrayResponse
     */
    public function getTbProjectGrayWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->label)) {
            @$body['label'] = $request->label;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->dingAccessTokenType)) {
            @$realHeaders['dingAccessTokenType'] = Utils::toJSONString($headers->dingAccessTokenType);
        }
        if (!Utils::isUnset($headers->dingCorpId)) {
            @$realHeaders['dingCorpId'] = Utils::toJSONString($headers->dingCorpId);
        }
        if (!Utils::isUnset($headers->dingIsvOrgId)) {
            @$realHeaders['dingIsvOrgId'] = Utils::toJSONString($headers->dingIsvOrgId);
        }
        if (!Utils::isUnset($headers->dingOrgId)) {
            @$realHeaders['dingOrgId'] = Utils::toJSONString($headers->dingOrgId);
        }
        if (!Utils::isUnset($headers->dingSuiteKey)) {
            @$realHeaders['dingSuiteKey'] = Utils::toJSONString($headers->dingSuiteKey);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetTbProjectGrayResponse::fromMap($this->doROARequest('GetTbProjectGray', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/projects/gray', 'json', $req, $runtime));
    }

    /**
     * @return GetTbProjectSourceResponse
     */
    public function getTbProjectSource()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTbProjectSourceHeaders([]);

        return $this->getTbProjectSourceWithOptions($headers, $runtime);
    }

    /**
     * @param GetTbProjectSourceHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetTbProjectSourceResponse
     */
    public function getTbProjectSourceWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->dingAccessTokenType)) {
            @$realHeaders['dingAccessTokenType'] = Utils::toJSONString($headers->dingAccessTokenType);
        }
        if (!Utils::isUnset($headers->dingCorpId)) {
            @$realHeaders['dingCorpId'] = Utils::toJSONString($headers->dingCorpId);
        }
        if (!Utils::isUnset($headers->dingIsvOrgId)) {
            @$realHeaders['dingIsvOrgId'] = Utils::toJSONString($headers->dingIsvOrgId);
        }
        if (!Utils::isUnset($headers->dingOrgId)) {
            @$realHeaders['dingOrgId'] = Utils::toJSONString($headers->dingOrgId);
        }
        if (!Utils::isUnset($headers->dingSuiteKey)) {
            @$realHeaders['dingSuiteKey'] = Utils::toJSONString($headers->dingSuiteKey);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetTbProjectSourceResponse::fromMap($this->doROARequest('GetTbProjectSource', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/projects/source', 'json', $req, $runtime));
    }

    /**
     * @param GetTbUserIdByStaffIdRequest $request
     *
     * @return GetTbUserIdByStaffIdResponse
     */
    public function getTbUserIdByStaffId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTbUserIdByStaffIdHeaders([]);

        return $this->getTbUserIdByStaffIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetTbUserIdByStaffIdRequest $request
     * @param GetTbUserIdByStaffIdHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetTbUserIdByStaffIdResponse
     */
    public function getTbUserIdByStaffIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->optUserId)) {
            @$query['optUserId'] = $request->optUserId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
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

        return GetTbUserIdByStaffIdResponse::fromMap($this->doROARequest('GetTbUserIdByStaffId', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/teambition/users', 'json', $req, $runtime));
    }

    /**
     * @param string                      $userId
     * @param GetUserJoinedProjectRequest $request
     *
     * @return GetUserJoinedProjectResponse
     */
    public function getUserJoinedProject($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserJoinedProjectHeaders([]);

        return $this->getUserJoinedProjectWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $userId
     * @param GetUserJoinedProjectRequest $request
     * @param GetUserJoinedProjectHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetUserJoinedProjectResponse
     */
    public function getUserJoinedProjectWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $query  = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
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

        return GetUserJoinedProjectResponse::fromMap($this->doROARequest('GetUserJoinedProject', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/users/' . $userId . '/joinProjects', 'json', $req, $runtime));
    }

    /**
     * @param string              $userId
     * @param QueryProjectRequest $request
     *
     * @return QueryProjectResponse
     */
    public function queryProject($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryProjectHeaders([]);

        return $this->queryProjectWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string              $userId
     * @param QueryProjectRequest $request
     * @param QueryProjectHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return QueryProjectResponse
     */
    public function queryProjectWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $query  = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->name)) {
            @$query['name'] = $request->name;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->projectIds)) {
            @$query['projectIds'] = $request->projectIds;
        }
        if (!Utils::isUnset($request->sourceId)) {
            @$query['sourceId'] = $request->sourceId;
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

        return QueryProjectResponse::fromMap($this->doROARequest('QueryProject', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/projects/query', 'json', $req, $runtime));
    }

    /**
     * @param string                    $userId
     * @param string                    $projectId
     * @param QueryTaskOfProjectRequest $request
     *
     * @return QueryTaskOfProjectResponse
     */
    public function queryTaskOfProject($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTaskOfProjectHeaders([]);

        return $this->queryTaskOfProjectWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @param string                    $userId
     * @param string                    $projectId
     * @param QueryTaskOfProjectRequest $request
     * @param QueryTaskOfProjectHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryTaskOfProjectResponse
     */
    public function queryTaskOfProjectWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId    = OpenApiUtilClient::getEncodeParam($userId);
        $projectId = OpenApiUtilClient::getEncodeParam($projectId);
        $query     = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->query)) {
            @$query['query'] = $request->query;
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

        return QueryTaskOfProjectResponse::fromMap($this->doROARequest('QueryTaskOfProject', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/users/' . $userId . '/projectIds/' . $projectId . '/tasks', 'json', $req, $runtime));
    }

    /**
     * @param string                $userId
     * @param string                $projectId
     * @param SeachTaskStageRequest $request
     *
     * @return SeachTaskStageResponse
     */
    public function seachTaskStage($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SeachTaskStageHeaders([]);

        return $this->seachTaskStageWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param string                $projectId
     * @param SeachTaskStageRequest $request
     * @param SeachTaskStageHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SeachTaskStageResponse
     */
    public function seachTaskStageWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId    = OpenApiUtilClient::getEncodeParam($userId);
        $projectId = OpenApiUtilClient::getEncodeParam($projectId);
        $query     = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->query)) {
            @$query['query'] = $request->query;
        }
        if (!Utils::isUnset($request->stageIds)) {
            @$query['stageIds'] = $request->stageIds;
        }
        if (!Utils::isUnset($request->taskListId)) {
            @$query['taskListId'] = $request->taskListId;
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

        return SeachTaskStageResponse::fromMap($this->doROARequest('SeachTaskStage', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/taskStages/search', 'json', $req, $runtime));
    }

    /**
     * @param string                              $userId
     * @param SearchOranizationCustomfieldRequest $request
     *
     * @return SearchOranizationCustomfieldResponse
     */
    public function searchOranizationCustomfield($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchOranizationCustomfieldHeaders([]);

        return $this->searchOranizationCustomfieldWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                              $userId
     * @param SearchOranizationCustomfieldRequest $request
     * @param SearchOranizationCustomfieldHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return SearchOranizationCustomfieldResponse
     */
    public function searchOranizationCustomfieldWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $query  = [];
        if (!Utils::isUnset($request->customfieldIds)) {
            @$query['customfieldIds'] = $request->customfieldIds;
        }
        if (!Utils::isUnset($request->instanceIds)) {
            @$query['instanceIds'] = $request->instanceIds;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->projectIds)) {
            @$query['projectIds'] = $request->projectIds;
        }
        if (!Utils::isUnset($request->query)) {
            @$query['query'] = $request->query;
        }
        if (!Utils::isUnset($request->scope)) {
            @$query['scope'] = $request->scope;
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

        return SearchOranizationCustomfieldResponse::fromMap($this->doROARequest('SearchOranizationCustomfield', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/organizations/users/' . $userId . '/customfields/search', 'json', $req, $runtime));
    }

    /**
     * @param string                          $userId
     * @param string                          $projectId
     * @param SearchProjectCustomfieldRequest $request
     *
     * @return SearchProjectCustomfieldResponse
     */
    public function searchProjectCustomfield($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchProjectCustomfieldHeaders([]);

        return $this->searchProjectCustomfieldWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @param string                          $userId
     * @param string                          $projectId
     * @param SearchProjectCustomfieldRequest $request
     * @param SearchProjectCustomfieldHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return SearchProjectCustomfieldResponse
     */
    public function searchProjectCustomfieldWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId    = OpenApiUtilClient::getEncodeParam($userId);
        $projectId = OpenApiUtilClient::getEncodeParam($projectId);
        $query     = [];
        if (!Utils::isUnset($request->customfieldIds)) {
            @$query['customfieldIds'] = $request->customfieldIds;
        }
        if (!Utils::isUnset($request->instanceIds)) {
            @$query['instanceIds'] = $request->instanceIds;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->query)) {
            @$query['query'] = $request->query;
        }
        if (!Utils::isUnset($request->scenariofieldconfigId)) {
            @$query['scenariofieldconfigId'] = $request->scenariofieldconfigId;
        }
        if (!Utils::isUnset($request->scope)) {
            @$query['scope'] = $request->scope;
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

        return SearchProjectCustomfieldResponse::fromMap($this->doROARequest('SearchProjectCustomfield', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/customfields/search', 'json', $req, $runtime));
    }

    /**
     * @param string                       $userId
     * @param SearchProjectTemplateRequest $request
     *
     * @return SearchProjectTemplateResponse
     */
    public function searchProjectTemplate($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchProjectTemplateHeaders([]);

        return $this->searchProjectTemplateWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                       $userId
     * @param SearchProjectTemplateRequest $request
     * @param SearchProjectTemplateHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return SearchProjectTemplateResponse
     */
    public function searchProjectTemplateWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $query  = [];
        if (!Utils::isUnset($request->keyword)) {
            @$query['keyword'] = $request->keyword;
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

        return SearchProjectTemplateResponse::fromMap($this->doROARequest('SearchProjectTemplate', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/organizations/users/' . $userId . '/templates', 'json', $req, $runtime));
    }

    /**
     * @param string                $userId
     * @param string                $projectId
     * @param SearchTaskFlowRequest $request
     *
     * @return SearchTaskFlowResponse
     */
    public function searchTaskFlow($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchTaskFlowHeaders([]);

        return $this->searchTaskFlowWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param string                $projectId
     * @param SearchTaskFlowRequest $request
     * @param SearchTaskFlowHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SearchTaskFlowResponse
     */
    public function searchTaskFlowWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId    = OpenApiUtilClient::getEncodeParam($userId);
        $projectId = OpenApiUtilClient::getEncodeParam($projectId);
        $query     = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->query)) {
            @$query['query'] = $request->query;
        }
        if (!Utils::isUnset($request->taskflowIds)) {
            @$query['taskflowIds'] = $request->taskflowIds;
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

        return SearchTaskFlowResponse::fromMap($this->doROARequest('SearchTaskFlow', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/taskflows/search', 'json', $req, $runtime));
    }

    /**
     * @param string                $userId
     * @param string                $projectId
     * @param SearchTaskListRequest $request
     *
     * @return SearchTaskListResponse
     */
    public function searchTaskList($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchTaskListHeaders([]);

        return $this->searchTaskListWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param string                $projectId
     * @param SearchTaskListRequest $request
     * @param SearchTaskListHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SearchTaskListResponse
     */
    public function searchTaskListWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId    = OpenApiUtilClient::getEncodeParam($userId);
        $projectId = OpenApiUtilClient::getEncodeParam($projectId);
        $query     = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->query)) {
            @$query['query'] = $request->query;
        }
        if (!Utils::isUnset($request->taskListIds)) {
            @$query['taskListIds'] = $request->taskListIds;
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

        return SearchTaskListResponse::fromMap($this->doROARequest('SearchTaskList', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/taskLists/search', 'json', $req, $runtime));
    }

    /**
     * @param string                      $userId
     * @param string                      $projectId
     * @param SearchTaskflowStatusRequest $request
     *
     * @return SearchTaskflowStatusResponse
     */
    public function searchTaskflowStatus($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchTaskflowStatusHeaders([]);

        return $this->searchTaskflowStatusWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $userId
     * @param string                      $projectId
     * @param SearchTaskflowStatusRequest $request
     * @param SearchTaskflowStatusHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return SearchTaskflowStatusResponse
     */
    public function searchTaskflowStatusWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId    = OpenApiUtilClient::getEncodeParam($userId);
        $projectId = OpenApiUtilClient::getEncodeParam($projectId);
        $query     = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->query)) {
            @$query['query'] = $request->query;
        }
        if (!Utils::isUnset($request->tfIds)) {
            @$query['tfIds'] = $request->tfIds;
        }
        if (!Utils::isUnset($request->tfsIds)) {
            @$query['tfsIds'] = $request->tfsIds;
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

        return SearchTaskflowStatusResponse::fromMap($this->doROARequest('SearchTaskflowStatus', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/taskflowStatuses/search', 'json', $req, $runtime));
    }

    /**
     * @param string                $userId
     * @param SearchUserTaskRequest $request
     *
     * @return SearchUserTaskResponse
     */
    public function searchUserTask($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchUserTaskHeaders([]);

        return $this->searchUserTaskWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param SearchUserTaskRequest $request
     * @param SearchUserTaskHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SearchUserTaskResponse
     */
    public function searchUserTaskWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $query  = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->tql)) {
            @$query['tql'] = $request->tql;
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

        return SearchUserTaskResponse::fromMap($this->doROARequest('SearchUserTask', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/tasks/search', 'json', $req, $runtime));
    }

    /**
     * @param string $projectId
     * @param string $userId
     *
     * @return SuspendProjectResponse
     */
    public function suspendProject($projectId, $userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SuspendProjectHeaders([]);

        return $this->suspendProjectWithOptions($projectId, $userId, $headers, $runtime);
    }

    /**
     * @param string                $projectId
     * @param string                $userId
     * @param SuspendProjectHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SuspendProjectResponse
     */
    public function suspendProjectWithOptions($projectId, $userId, $headers, $runtime)
    {
        $projectId   = OpenApiUtilClient::getEncodeParam($projectId);
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return SuspendProjectResponse::fromMap($this->doROARequest('SuspendProject', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/suspend', 'json', $req, $runtime));
    }

    /**
     * @param string $projectId
     * @param string $userId
     *
     * @return UnSuspendProjectResponse
     */
    public function unSuspendProject($projectId, $userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnSuspendProjectHeaders([]);

        return $this->unSuspendProjectWithOptions($projectId, $userId, $headers, $runtime);
    }

    /**
     * @param string                  $projectId
     * @param string                  $userId
     * @param UnSuspendProjectHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return UnSuspendProjectResponse
     */
    public function unSuspendProjectWithOptions($projectId, $userId, $headers, $runtime)
    {
        $projectId   = OpenApiUtilClient::getEncodeParam($projectId);
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return UnSuspendProjectResponse::fromMap($this->doROARequest('UnSuspendProject', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/unsuspend', 'json', $req, $runtime));
    }

    /**
     * @param string                        $userId
     * @param string                        $taskId
     * @param UpdateCustomfieldValueRequest $request
     *
     * @return UpdateCustomfieldValueResponse
     */
    public function updateCustomfieldValue($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCustomfieldValueHeaders([]);

        return $this->updateCustomfieldValueWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                        $userId
     * @param string                        $taskId
     * @param UpdateCustomfieldValueRequest $request
     * @param UpdateCustomfieldValueHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return UpdateCustomfieldValueResponse
     */
    public function updateCustomfieldValueWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $body   = [];
        if (!Utils::isUnset($request->customfieldId)) {
            @$body['customfieldId'] = $request->customfieldId;
        }
        if (!Utils::isUnset($request->customfieldName)) {
            @$body['customfieldName'] = $request->customfieldName;
        }
        if (!Utils::isUnset($request->value)) {
            @$body['value'] = $request->value;
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

        return UpdateCustomfieldValueResponse::fromMap($this->doROARequest('UpdateCustomfieldValue', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/customFields', 'json', $req, $runtime));
    }

    /**
     * @param string                               $taskId
     * @param string                               $userId
     * @param UpdateOrganizationTaskContentRequest $request
     *
     * @return UpdateOrganizationTaskContentResponse
     */
    public function updateOrganizationTaskContent($taskId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateOrganizationTaskContentHeaders([]);

        return $this->updateOrganizationTaskContentWithOptions($taskId, $userId, $request, $headers, $runtime);
    }

    /**
     * @param string                               $taskId
     * @param string                               $userId
     * @param UpdateOrganizationTaskContentRequest $request
     * @param UpdateOrganizationTaskContentHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return UpdateOrganizationTaskContentResponse
     */
    public function updateOrganizationTaskContentWithOptions($taskId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->disableActivity)) {
            @$body['disableActivity'] = $request->disableActivity;
        }
        if (!Utils::isUnset($request->disableNotification)) {
            @$body['disableNotification'] = $request->disableNotification;
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

        return UpdateOrganizationTaskContentResponse::fromMap($this->doROARequest('UpdateOrganizationTaskContent', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/organizations/users/' . $userId . '/tasks/' . $taskId . '/contents', 'json', $req, $runtime));
    }

    /**
     * @param string                               $taskId
     * @param string                               $userId
     * @param UpdateOrganizationTaskDueDateRequest $request
     *
     * @return UpdateOrganizationTaskDueDateResponse
     */
    public function updateOrganizationTaskDueDate($taskId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateOrganizationTaskDueDateHeaders([]);

        return $this->updateOrganizationTaskDueDateWithOptions($taskId, $userId, $request, $headers, $runtime);
    }

    /**
     * @param string                               $taskId
     * @param string                               $userId
     * @param UpdateOrganizationTaskDueDateRequest $request
     * @param UpdateOrganizationTaskDueDateHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return UpdateOrganizationTaskDueDateResponse
     */
    public function updateOrganizationTaskDueDateWithOptions($taskId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->disableActivity)) {
            @$body['disableActivity'] = $request->disableActivity;
        }
        if (!Utils::isUnset($request->disableNotification)) {
            @$body['disableNotification'] = $request->disableNotification;
        }
        if (!Utils::isUnset($request->dueDate)) {
            @$body['dueDate'] = $request->dueDate;
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

        return UpdateOrganizationTaskDueDateResponse::fromMap($this->doROARequest('UpdateOrganizationTaskDueDate', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/organizations/users/' . $userId . '/tasks/' . $taskId . '/dueDates', 'json', $req, $runtime));
    }

    /**
     * @param string                                $taskId
     * @param string                                $userId
     * @param UpdateOrganizationTaskExecutorRequest $request
     *
     * @return UpdateOrganizationTaskExecutorResponse
     */
    public function updateOrganizationTaskExecutor($taskId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateOrganizationTaskExecutorHeaders([]);

        return $this->updateOrganizationTaskExecutorWithOptions($taskId, $userId, $request, $headers, $runtime);
    }

    /**
     * @param string                                $taskId
     * @param string                                $userId
     * @param UpdateOrganizationTaskExecutorRequest $request
     * @param UpdateOrganizationTaskExecutorHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return UpdateOrganizationTaskExecutorResponse
     */
    public function updateOrganizationTaskExecutorWithOptions($taskId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->disableActivity)) {
            @$body['disableActivity'] = $request->disableActivity;
        }
        if (!Utils::isUnset($request->disableNotification)) {
            @$body['disableNotification'] = $request->disableNotification;
        }
        if (!Utils::isUnset($request->executorId)) {
            @$body['executorId'] = $request->executorId;
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

        return UpdateOrganizationTaskExecutorResponse::fromMap($this->doROARequest('UpdateOrganizationTaskExecutor', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/organizations/users/' . $userId . '/tasks/' . $taskId . '/executors', 'json', $req, $runtime));
    }

    /**
     * @param string                                      $taskId
     * @param string                                      $userId
     * @param UpdateOrganizationTaskInvolveMembersRequest $request
     *
     * @return UpdateOrganizationTaskInvolveMembersResponse
     */
    public function updateOrganizationTaskInvolveMembers($taskId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateOrganizationTaskInvolveMembersHeaders([]);

        return $this->updateOrganizationTaskInvolveMembersWithOptions($taskId, $userId, $request, $headers, $runtime);
    }

    /**
     * @param string                                      $taskId
     * @param string                                      $userId
     * @param UpdateOrganizationTaskInvolveMembersRequest $request
     * @param UpdateOrganizationTaskInvolveMembersHeaders $headers
     * @param RuntimeOptions                              $runtime
     *
     * @return UpdateOrganizationTaskInvolveMembersResponse
     */
    public function updateOrganizationTaskInvolveMembersWithOptions($taskId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->addInvolvers)) {
            @$body['addInvolvers'] = $request->addInvolvers;
        }
        if (!Utils::isUnset($request->delInvolvers)) {
            @$body['delInvolvers'] = $request->delInvolvers;
        }
        if (!Utils::isUnset($request->disableActivity)) {
            @$body['disableActivity'] = $request->disableActivity;
        }
        if (!Utils::isUnset($request->disableNotification)) {
            @$body['disableNotification'] = $request->disableNotification;
        }
        if (!Utils::isUnset($request->involveMembers)) {
            @$body['involveMembers'] = $request->involveMembers;
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

        return UpdateOrganizationTaskInvolveMembersResponse::fromMap($this->doROARequest('UpdateOrganizationTaskInvolveMembers', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/organizations/users/' . $userId . '/tasks/' . $taskId . '/involveMembers', 'json', $req, $runtime));
    }

    /**
     * @param string                            $taskId
     * @param string                            $userId
     * @param UpdateOrganizationTaskNoteRequest $request
     *
     * @return UpdateOrganizationTaskNoteResponse
     */
    public function updateOrganizationTaskNote($taskId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateOrganizationTaskNoteHeaders([]);

        return $this->updateOrganizationTaskNoteWithOptions($taskId, $userId, $request, $headers, $runtime);
    }

    /**
     * @param string                            $taskId
     * @param string                            $userId
     * @param UpdateOrganizationTaskNoteRequest $request
     * @param UpdateOrganizationTaskNoteHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return UpdateOrganizationTaskNoteResponse
     */
    public function updateOrganizationTaskNoteWithOptions($taskId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->disableActivity)) {
            @$body['disableActivity'] = $request->disableActivity;
        }
        if (!Utils::isUnset($request->disableNotification)) {
            @$body['disableNotification'] = $request->disableNotification;
        }
        if (!Utils::isUnset($request->note)) {
            @$body['note'] = $request->note;
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

        return UpdateOrganizationTaskNoteResponse::fromMap($this->doROARequest('UpdateOrganizationTaskNote', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/organizations/users/' . $userId . '/tasks/' . $taskId . '/notes', 'json', $req, $runtime));
    }

    /**
     * @param string                                $taskId
     * @param string                                $userId
     * @param UpdateOrganizationTaskPriorityRequest $request
     *
     * @return UpdateOrganizationTaskPriorityResponse
     */
    public function updateOrganizationTaskPriority($taskId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateOrganizationTaskPriorityHeaders([]);

        return $this->updateOrganizationTaskPriorityWithOptions($taskId, $userId, $request, $headers, $runtime);
    }

    /**
     * @param string                                $taskId
     * @param string                                $userId
     * @param UpdateOrganizationTaskPriorityRequest $request
     * @param UpdateOrganizationTaskPriorityHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return UpdateOrganizationTaskPriorityResponse
     */
    public function updateOrganizationTaskPriorityWithOptions($taskId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->disableActivity)) {
            @$body['disableActivity'] = $request->disableActivity;
        }
        if (!Utils::isUnset($request->disableNotification)) {
            @$body['disableNotification'] = $request->disableNotification;
        }
        if (!Utils::isUnset($request->priority)) {
            @$body['priority'] = $request->priority;
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

        return UpdateOrganizationTaskPriorityResponse::fromMap($this->doROARequest('UpdateOrganizationTaskPriority', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/organizations/users/' . $userId . '/tasks/' . $taskId . '/priorities', 'json', $req, $runtime));
    }

    /**
     * @param string                              $taskId
     * @param string                              $userId
     * @param UpdateOrganizationTaskStatusRequest $request
     *
     * @return UpdateOrganizationTaskStatusResponse
     */
    public function updateOrganizationTaskStatus($taskId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateOrganizationTaskStatusHeaders([]);

        return $this->updateOrganizationTaskStatusWithOptions($taskId, $userId, $request, $headers, $runtime);
    }

    /**
     * @param string                              $taskId
     * @param string                              $userId
     * @param UpdateOrganizationTaskStatusRequest $request
     * @param UpdateOrganizationTaskStatusHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return UpdateOrganizationTaskStatusResponse
     */
    public function updateOrganizationTaskStatusWithOptions($taskId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->disableActivity)) {
            @$body['disableActivity'] = $request->disableActivity;
        }
        if (!Utils::isUnset($request->disableNotification)) {
            @$body['disableNotification'] = $request->disableNotification;
        }
        if (!Utils::isUnset($request->isDone)) {
            @$body['isDone'] = $request->isDone;
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

        return UpdateOrganizationTaskStatusResponse::fromMap($this->doROARequest('UpdateOrganizationTaskStatus', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/organizations/users/' . $userId . '/tasks/' . $taskId . '/states', 'json', $req, $runtime));
    }

    /**
     * @param string                    $userId
     * @param string                    $projectId
     * @param UpdateProjectGroupRequest $request
     *
     * @return UpdateProjectGroupResponse
     */
    public function updateProjectGroup($userId, $projectId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateProjectGroupHeaders([]);

        return $this->updateProjectGroupWithOptions($userId, $projectId, $request, $headers, $runtime);
    }

    /**
     * @param string                    $userId
     * @param string                    $projectId
     * @param UpdateProjectGroupRequest $request
     * @param UpdateProjectGroupHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return UpdateProjectGroupResponse
     */
    public function updateProjectGroupWithOptions($userId, $projectId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId    = OpenApiUtilClient::getEncodeParam($userId);
        $projectId = OpenApiUtilClient::getEncodeParam($projectId);
        $body      = [];
        if (!Utils::isUnset($request->addProjectGroupIds)) {
            @$body['addProjectGroupIds'] = $request->addProjectGroupIds;
        }
        if (!Utils::isUnset($request->delProjectGroupIds)) {
            @$body['delProjectGroupIds'] = $request->delProjectGroupIds;
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

        return UpdateProjectGroupResponse::fromMap($this->doROARequest('UpdateProjectGroup', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/users/' . $userId . '/projects/' . $projectId . '/groups', 'json', $req, $runtime));
    }

    /**
     * @param string                   $userId
     * @param string                   $taskId
     * @param UpdateTaskContentRequest $request
     *
     * @return UpdateTaskContentResponse
     */
    public function updateTaskContent($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskContentHeaders([]);

        return $this->updateTaskContentWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                   $userId
     * @param string                   $taskId
     * @param UpdateTaskContentRequest $request
     * @param UpdateTaskContentHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return UpdateTaskContentResponse
     */
    public function updateTaskContentWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $body   = [];
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
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

        return UpdateTaskContentResponse::fromMap($this->doROARequest('UpdateTaskContent', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/contents', 'json', $req, $runtime));
    }

    /**
     * @param string                   $userId
     * @param string                   $taskId
     * @param UpdateTaskDueDateRequest $request
     *
     * @return UpdateTaskDueDateResponse
     */
    public function updateTaskDueDate($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskDueDateHeaders([]);

        return $this->updateTaskDueDateWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                   $userId
     * @param string                   $taskId
     * @param UpdateTaskDueDateRequest $request
     * @param UpdateTaskDueDateHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return UpdateTaskDueDateResponse
     */
    public function updateTaskDueDateWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $body   = [];
        if (!Utils::isUnset($request->dueDate)) {
            @$body['dueDate'] = $request->dueDate;
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

        return UpdateTaskDueDateResponse::fromMap($this->doROARequest('UpdateTaskDueDate', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/dueDates', 'json', $req, $runtime));
    }

    /**
     * @param string                    $userId
     * @param string                    $taskId
     * @param UpdateTaskExecutorRequest $request
     *
     * @return UpdateTaskExecutorResponse
     */
    public function updateTaskExecutor($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskExecutorHeaders([]);

        return $this->updateTaskExecutorWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                    $userId
     * @param string                    $taskId
     * @param UpdateTaskExecutorRequest $request
     * @param UpdateTaskExecutorHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return UpdateTaskExecutorResponse
     */
    public function updateTaskExecutorWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $body   = [];
        if (!Utils::isUnset($request->executorId)) {
            @$body['executorId'] = $request->executorId;
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

        return UpdateTaskExecutorResponse::fromMap($this->doROARequest('UpdateTaskExecutor', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/executors', 'json', $req, $runtime));
    }

    /**
     * @param string                          $userId
     * @param string                          $taskId
     * @param UpdateTaskInvolvemembersRequest $request
     *
     * @return UpdateTaskInvolvemembersResponse
     */
    public function updateTaskInvolvemembers($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskInvolvemembersHeaders([]);

        return $this->updateTaskInvolvemembersWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                          $userId
     * @param string                          $taskId
     * @param UpdateTaskInvolvemembersRequest $request
     * @param UpdateTaskInvolvemembersHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return UpdateTaskInvolvemembersResponse
     */
    public function updateTaskInvolvemembersWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $body   = [];
        if (!Utils::isUnset($request->addInvolvers)) {
            @$body['addInvolvers'] = $request->addInvolvers;
        }
        if (!Utils::isUnset($request->delInvolvers)) {
            @$body['delInvolvers'] = $request->delInvolvers;
        }
        if (!Utils::isUnset($request->involveMembers)) {
            @$body['involveMembers'] = $request->involveMembers;
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

        return UpdateTaskInvolvemembersResponse::fromMap($this->doROARequest('UpdateTaskInvolvemembers', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/involveMembers', 'json', $req, $runtime));
    }

    /**
     * @param string                $userId
     * @param string                $taskId
     * @param UpdateTaskNoteRequest $request
     *
     * @return UpdateTaskNoteResponse
     */
    public function updateTaskNote($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskNoteHeaders([]);

        return $this->updateTaskNoteWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param string                $taskId
     * @param UpdateTaskNoteRequest $request
     * @param UpdateTaskNoteHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return UpdateTaskNoteResponse
     */
    public function updateTaskNoteWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $body   = [];
        if (!Utils::isUnset($request->note)) {
            @$body['note'] = $request->note;
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

        return UpdateTaskNoteResponse::fromMap($this->doROARequest('UpdateTaskNote', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/notes', 'json', $req, $runtime));
    }

    /**
     * @param string                    $userId
     * @param string                    $taskId
     * @param UpdateTaskPriorityRequest $request
     *
     * @return UpdateTaskPriorityResponse
     */
    public function updateTaskPriority($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskPriorityHeaders([]);

        return $this->updateTaskPriorityWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                    $userId
     * @param string                    $taskId
     * @param UpdateTaskPriorityRequest $request
     * @param UpdateTaskPriorityHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return UpdateTaskPriorityResponse
     */
    public function updateTaskPriorityWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $body   = [];
        if (!Utils::isUnset($request->priority)) {
            @$body['priority'] = $request->priority;
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

        return UpdateTaskPriorityResponse::fromMap($this->doROARequest('UpdateTaskPriority', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/priorities', 'json', $req, $runtime));
    }

    /**
     * @param string                 $userId
     * @param string                 $taskId
     * @param UpdateTaskStageRequest $request
     *
     * @return UpdateTaskStageResponse
     */
    public function updateTaskStage($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskStageHeaders([]);

        return $this->updateTaskStageWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $userId
     * @param string                 $taskId
     * @param UpdateTaskStageRequest $request
     * @param UpdateTaskStageHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return UpdateTaskStageResponse
     */
    public function updateTaskStageWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $body   = [];
        if (!Utils::isUnset($request->stageId)) {
            @$body['stageId'] = $request->stageId;
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

        return UpdateTaskStageResponse::fromMap($this->doROARequest('UpdateTaskStage', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/stages', 'json', $req, $runtime));
    }

    /**
     * @param string                     $userId
     * @param string                     $taskId
     * @param UpdateTaskStartdateRequest $request
     *
     * @return UpdateTaskStartdateResponse
     */
    public function updateTaskStartdate($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskStartdateHeaders([]);

        return $this->updateTaskStartdateWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $userId
     * @param string                     $taskId
     * @param UpdateTaskStartdateRequest $request
     * @param UpdateTaskStartdateHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return UpdateTaskStartdateResponse
     */
    public function updateTaskStartdateWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $body   = [];
        if (!Utils::isUnset($request->startDate)) {
            @$body['startDate'] = $request->startDate;
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

        return UpdateTaskStartdateResponse::fromMap($this->doROARequest('UpdateTaskStartdate', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/startDates', 'json', $req, $runtime));
    }

    /**
     * @param string                          $userId
     * @param string                          $taskId
     * @param UpdateTaskTaskflowstatusRequest $request
     *
     * @return UpdateTaskTaskflowstatusResponse
     */
    public function updateTaskTaskflowstatus($userId, $taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTaskTaskflowstatusHeaders([]);

        return $this->updateTaskTaskflowstatusWithOptions($userId, $taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                          $userId
     * @param string                          $taskId
     * @param UpdateTaskTaskflowstatusRequest $request
     * @param UpdateTaskTaskflowstatusHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return UpdateTaskTaskflowstatusResponse
     */
    public function updateTaskTaskflowstatusWithOptions($userId, $taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $body   = [];
        if (!Utils::isUnset($request->taskflowStatusId)) {
            @$body['taskflowStatusId'] = $request->taskflowStatusId;
        }
        if (!Utils::isUnset($request->tfsUpdateNote)) {
            @$body['tfsUpdateNote'] = $request->tfsUpdateNote;
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

        return UpdateTaskTaskflowstatusResponse::fromMap($this->doROARequest('UpdateTaskTaskflowstatus', 'project_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/project/users/' . $userId . '/tasks/' . $taskId . '/taskflowStatuses', 'json', $req, $runtime));
    }
}
