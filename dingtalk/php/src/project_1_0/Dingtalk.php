<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateOrganizationTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateOrganizationTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateOrganizationTaskResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectGrayHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectGrayRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectGrayResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectSourceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectSourceResponse;
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
}
