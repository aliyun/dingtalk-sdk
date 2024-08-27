<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\AddApproveDentryAuthHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\AddApproveDentryAuthRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\AddApproveDentryAuthResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\AddProcessInstanceCommentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\AddProcessInstanceCommentRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\AddProcessInstanceCommentResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchExecuteProcessInstancesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchExecuteProcessInstancesRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchExecuteProcessInstancesResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchTasksRedirectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchTasksRedirectRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchTasksRedirectResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchUpdateProcessInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchUpdateProcessInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchUpdateProcessInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CancelIntegratedTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CancelIntegratedTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CancelIntegratedTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CleanProcessDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CleanProcessDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CleanProcessDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CopyProcessHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CopyProcessRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CopyProcessResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CreateIntegratedTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CreateIntegratedTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CreateIntegratedTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\DeleteDirHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\DeleteDirRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\DeleteDirResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\DeleteProcessHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\DeleteProcessRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\DeleteProcessResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ExecuteProcessInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ExecuteProcessInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ExecuteProcessInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetAttachmentSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetAttachmentSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetAttachmentSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetConditionFormComponentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetConditionFormComponentRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetConditionFormComponentResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetCrmProcCodesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetCrmProcCodesResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetFieldModifiedHistoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetFieldModifiedHistoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetFieldModifiedHistoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetHandSignDownloadUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetHandSignDownloadUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetHandSignDownloadUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetManageProcessByStaffIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetManageProcessByStaffIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetManageProcessByStaffIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessCodeByNameHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessCodeByNameRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessCodeByNameResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceWithExtraHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceWithExtraRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceWithExtraResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetSchemaAndProcessconfigBatchllyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetSchemaAndProcessconfigBatchllyRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetSchemaAndProcessconfigBatchllyResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetSchemaAndProcessconfigBatchllyShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetSpaceWithDownloadAuthHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetSpaceWithDownloadAuthRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetSpaceWithDownloadAuthResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetUserTodoTaskSumHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetUserTodoTaskSumRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetUserTodoTaskSumResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GrantCspaceAuthorizationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GrantCspaceAuthorizationRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GrantCspaceAuthorizationResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GrantProcessInstanceForDownloadFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GrantProcessInstanceForDownloadFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GrantProcessInstanceForDownloadFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\InsertOrUpdateDirHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\InsertOrUpdateDirRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\InsertOrUpdateDirResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\InstallAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\InstallAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\InstallAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ListProcessInstanceIdsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ListProcessInstanceIdsRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ListProcessInstanceIdsResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ListTodoWorkRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ListTodoWorkRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ListTodoWorkRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ListUserVisibleBpmsProcessesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ListUserVisibleBpmsProcessesRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ListUserVisibleBpmsProcessesResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PagesExportInstancesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PagesExportInstancesRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PagesExportInstancesResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumBatchExecuteProcessInstancesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumBatchExecuteProcessInstancesRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumBatchExecuteProcessInstancesResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumDelDirHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumDelDirRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumDelDirResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetDoneTasksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetDoneTasksRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetDoneTasksResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetFieldModifiedHistoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetFieldModifiedHistoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetFieldModifiedHistoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetNoticedInstancesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetNoticedInstancesRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetNoticedInstancesResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetProcessInstancesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetProcessInstancesRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetProcessInstancesResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetSubmittedInstancesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetSubmittedInstancesRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetSubmittedInstancesResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetTodoTasksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetTodoTasksRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetTodoTasksResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumInsertOrUpdateDirHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumInsertOrUpdateDirRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumInsertOrUpdateDirResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumQueryTodoTasksByManagerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumQueryTodoTasksByManagerRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumQueryTodoTasksByManagerResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumRedirectTasksByManagerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumRedirectTasksByManagerRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumRedirectTasksByManagerResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumSaveIntegratedProcessHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumSaveIntegratedProcessInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumSaveIntegratedProcessInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumSaveIntegratedProcessInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumSaveIntegratedProcessRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumSaveIntegratedProcessResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumSaveIntegratedTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumSaveIntegratedTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumSaveIntegratedTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllFormInstancesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllFormInstancesRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllFormInstancesResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllProcessInstancesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllProcessInstancesRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllProcessInstancesResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryFormByBizTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryFormByBizTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryFormByBizTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryFormInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryFormInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryFormInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryIntegratedTodoTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryIntegratedTodoTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryIntegratedTodoTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryProcessByBizCategoryIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryProcessByBizCategoryIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryProcessByBizCategoryIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaAndProcessHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaAndProcessRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaAndProcessResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\RedirectWorkflowTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\RedirectWorkflowTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\RedirectWorkflowTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\SaveIntegratedInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\SaveIntegratedInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\SaveIntegratedInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\SaveProcessHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\SaveProcessRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\SaveProcessResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\StartProcessInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\StartProcessInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\StartProcessInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\TerminateProcessInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\TerminateProcessInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\TerminateProcessInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\TodoTasksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\TodoTasksRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\TodoTasksResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\UpdateIntegratedTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\UpdateIntegratedTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\UpdateIntegratedTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\UpdateProcessInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\UpdateProcessInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\UpdateProcessInstanceResponse;
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
     * @summary 授权下载审批钉盘文件
     *  *
     * @param AddApproveDentryAuthRequest $request AddApproveDentryAuthRequest
     * @param AddApproveDentryAuthHeaders $headers AddApproveDentryAuthHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return AddApproveDentryAuthResponse AddApproveDentryAuthResponse
     */
    public function addApproveDentryAuthWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fileInfos)) {
            $body['fileInfos'] = $request->fileInfos;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action'      => 'AddApproveDentryAuth',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processInstances/spaces/files/authDownload',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddApproveDentryAuthResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 授权下载审批钉盘文件
     *  *
     * @param AddApproveDentryAuthRequest $request AddApproveDentryAuthRequest
     *
     * @return AddApproveDentryAuthResponse AddApproveDentryAuthResponse
     */
    public function addApproveDentryAuth($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddApproveDentryAuthHeaders([]);

        return $this->addApproveDentryAuthWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加审批评论
     *  *
     * @param AddProcessInstanceCommentRequest $request AddProcessInstanceCommentRequest
     * @param AddProcessInstanceCommentHeaders $headers AddProcessInstanceCommentHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return AddProcessInstanceCommentResponse AddProcessInstanceCommentResponse
     */
    public function addProcessInstanceCommentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->commentUserId)) {
            $body['commentUserId'] = $request->commentUserId;
        }
        if (!Utils::isUnset($request->file)) {
            $body['file'] = $request->file;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->text)) {
            $body['text'] = $request->text;
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
            'action'      => 'AddProcessInstanceComment',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processInstances/comments',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddProcessInstanceCommentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加审批评论
     *  *
     * @param AddProcessInstanceCommentRequest $request AddProcessInstanceCommentRequest
     *
     * @return AddProcessInstanceCommentResponse AddProcessInstanceCommentResponse
     */
    public function addProcessInstanceComment($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddProcessInstanceCommentHeaders([]);

        return $this->addProcessInstanceCommentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量同意或拒绝审批任务
     *  *
     * @param BatchExecuteProcessInstancesRequest $request BatchExecuteProcessInstancesRequest
     * @param BatchExecuteProcessInstancesHeaders $headers BatchExecuteProcessInstancesHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchExecuteProcessInstancesResponse BatchExecuteProcessInstancesResponse
     */
    public function batchExecuteProcessInstancesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionerUserId)) {
            $body['actionerUserId'] = $request->actionerUserId;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->result)) {
            $body['result'] = $request->result;
        }
        if (!Utils::isUnset($request->taskInfoList)) {
            $body['taskInfoList'] = $request->taskInfoList;
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
            'action'      => 'BatchExecuteProcessInstances',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processInstances/batchExecute',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchExecuteProcessInstancesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量同意或拒绝审批任务
     *  *
     * @param BatchExecuteProcessInstancesRequest $request BatchExecuteProcessInstancesRequest
     *
     * @return BatchExecuteProcessInstancesResponse BatchExecuteProcessInstancesResponse
     */
    public function batchExecuteProcessInstances($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchExecuteProcessInstancesHeaders([]);

        return $this->batchExecuteProcessInstancesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量流程审批任务转交
     *  *
     * @param BatchTasksRedirectRequest $request BatchTasksRedirectRequest
     * @param BatchTasksRedirectHeaders $headers BatchTasksRedirectHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchTasksRedirectResponse BatchTasksRedirectResponse
     */
    public function batchTasksRedirectWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->handoverUserId)) {
            $body['handoverUserId'] = $request->handoverUserId;
        }
        if (!Utils::isUnset($request->managerUserId)) {
            $body['managerUserId'] = $request->managerUserId;
        }
        if (!Utils::isUnset($request->taskIds)) {
            $body['taskIds'] = $request->taskIds;
        }
        if (!Utils::isUnset($request->transfereeUserId)) {
            $body['transfereeUserId'] = $request->transfereeUserId;
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
            'action'      => 'BatchTasksRedirect',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/tasks/batchRedirect',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchTasksRedirectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量流程审批任务转交
     *  *
     * @param BatchTasksRedirectRequest $request BatchTasksRedirectRequest
     *
     * @return BatchTasksRedirectResponse BatchTasksRedirectResponse
     */
    public function batchTasksRedirect($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchTasksRedirectHeaders([]);

        return $this->batchTasksRedirectWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量更新实例状态
     *  *
     * @param BatchUpdateProcessInstanceRequest $request BatchUpdateProcessInstanceRequest
     * @param BatchUpdateProcessInstanceHeaders $headers BatchUpdateProcessInstanceHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchUpdateProcessInstanceResponse BatchUpdateProcessInstanceResponse
     */
    public function batchUpdateProcessInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->updateProcessInstanceRequests)) {
            $body['updateProcessInstanceRequests'] = $request->updateProcessInstanceRequests;
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
            'action'      => 'BatchUpdateProcessInstance',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processCentres/instances/batch',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchUpdateProcessInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量更新实例状态
     *  *
     * @param BatchUpdateProcessInstanceRequest $request BatchUpdateProcessInstanceRequest
     *
     * @return BatchUpdateProcessInstanceResponse BatchUpdateProcessInstanceResponse
     */
    public function batchUpdateProcessInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateProcessInstanceHeaders([]);

        return $this->batchUpdateProcessInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量取消流程中心待处理任务
     *  *
     * @param CancelIntegratedTaskRequest $request CancelIntegratedTaskRequest
     * @param CancelIntegratedTaskHeaders $headers CancelIntegratedTaskHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return CancelIntegratedTaskResponse CancelIntegratedTaskResponse
     */
    public function cancelIntegratedTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->activityId)) {
            $body['activityId'] = $request->activityId;
        }
        if (!Utils::isUnset($request->activityIds)) {
            $body['activityIds'] = $request->activityIds;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
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
            'action'      => 'CancelIntegratedTask',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processCentres/tasks/cancel',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CancelIntegratedTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量取消流程中心待处理任务
     *  *
     * @param CancelIntegratedTaskRequest $request CancelIntegratedTaskRequest
     *
     * @return CancelIntegratedTaskResponse CancelIntegratedTaskResponse
     */
    public function cancelIntegratedTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelIntegratedTaskHeaders([]);

        return $this->cancelIntegratedTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 清理审批数据
     *  *
     * @param CleanProcessDataRequest $request CleanProcessDataRequest
     * @param CleanProcessDataHeaders $headers CleanProcessDataHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return CleanProcessDataResponse CleanProcessDataResponse
     */
    public function cleanProcessDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->processCode)) {
            $body['processCode'] = $request->processCode;
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
            'action'      => 'CleanProcessData',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processes/clean',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CleanProcessDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 清理审批数据
     *  *
     * @param CleanProcessDataRequest $request CleanProcessDataRequest
     *
     * @return CleanProcessDataResponse CleanProcessDataResponse
     */
    public function cleanProcessData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CleanProcessDataHeaders([]);

        return $this->cleanProcessDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 复制审批流
     *  *
     * @param CopyProcessRequest $request CopyProcessRequest
     * @param CopyProcessHeaders $headers CopyProcessHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return CopyProcessResponse CopyProcessResponse
     */
    public function copyProcessWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->copyOptions)) {
            $body['copyOptions'] = $request->copyOptions;
        }
        if (!Utils::isUnset($request->sourceCorpId)) {
            $body['sourceCorpId'] = $request->sourceCorpId;
        }
        if (!Utils::isUnset($request->sourceProcessVOList)) {
            $body['sourceProcessVOList'] = $request->sourceProcessVOList;
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
            'action'      => 'CopyProcess',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processes/copy',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CopyProcessResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 复制审批流
     *  *
     * @param CopyProcessRequest $request CopyProcessRequest
     *
     * @return CopyProcessResponse CopyProcessResponse
     */
    public function copyProcess($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CopyProcessHeaders([]);

        return $this->copyProcessWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建流程中心待处理任务
     *  *
     * @param CreateIntegratedTaskRequest $request CreateIntegratedTaskRequest
     * @param CreateIntegratedTaskHeaders $headers CreateIntegratedTaskHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateIntegratedTaskResponse CreateIntegratedTaskResponse
     */
    public function createIntegratedTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->activityId)) {
            $body['activityId'] = $request->activityId;
        }
        if (!Utils::isUnset($request->featureConfig)) {
            $body['featureConfig'] = $request->featureConfig;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->tasks)) {
            $body['tasks'] = $request->tasks;
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
            'action'      => 'CreateIntegratedTask',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processCentres/tasks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateIntegratedTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建流程中心待处理任务
     *  *
     * @param CreateIntegratedTaskRequest $request CreateIntegratedTaskRequest
     *
     * @return CreateIntegratedTaskResponse CreateIntegratedTaskResponse
     */
    public function createIntegratedTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateIntegratedTaskHeaders([]);

        return $this->createIntegratedTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除分组
     *  *
     * @param DeleteDirRequest $request DeleteDirRequest
     * @param DeleteDirHeaders $headers DeleteDirHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteDirResponse DeleteDirResponse
     */
    public function deleteDirWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->dirId)) {
            $query['dirId'] = $request->dirId;
        }
        if (!Utils::isUnset($request->operateUserId)) {
            $query['operateUserId'] = $request->operateUserId;
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
            'action'      => 'DeleteDir',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processCentres/directories',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteDirResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除分组
     *  *
     * @param DeleteDirRequest $request DeleteDirRequest
     *
     * @return DeleteDirResponse DeleteDirResponse
     */
    public function deleteDir($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDirHeaders([]);

        return $this->deleteDirWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除模板
     *  *
     * @param DeleteProcessRequest $request DeleteProcessRequest
     * @param DeleteProcessHeaders $headers DeleteProcessHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteProcessResponse DeleteProcessResponse
     */
    public function deleteProcessWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->cleanRunningTask)) {
            $query['cleanRunningTask'] = $request->cleanRunningTask;
        }
        if (!Utils::isUnset($request->processCode)) {
            $query['processCode'] = $request->processCode;
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
            'action'      => 'DeleteProcess',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processCentres/schemas',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteProcessResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除模板
     *  *
     * @param DeleteProcessRequest $request DeleteProcessRequest
     *
     * @return DeleteProcessResponse DeleteProcessResponse
     */
    public function deleteProcess($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteProcessHeaders([]);

        return $this->deleteProcessWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 同意或拒绝审批任务
     *  *
     * @param ExecuteProcessInstanceRequest $request ExecuteProcessInstanceRequest
     * @param ExecuteProcessInstanceHeaders $headers ExecuteProcessInstanceHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return ExecuteProcessInstanceResponse ExecuteProcessInstanceResponse
     */
    public function executeProcessInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionerUserId)) {
            $body['actionerUserId'] = $request->actionerUserId;
        }
        if (!Utils::isUnset($request->file)) {
            $body['file'] = $request->file;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->result)) {
            $body['result'] = $request->result;
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
            'action'      => 'ExecuteProcessInstance',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processInstances/execute',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ExecuteProcessInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 同意或拒绝审批任务
     *  *
     * @param ExecuteProcessInstanceRequest $request ExecuteProcessInstanceRequest
     *
     * @return ExecuteProcessInstanceResponse ExecuteProcessInstanceResponse
     */
    public function executeProcessInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecuteProcessInstanceHeaders([]);

        return $this->executeProcessInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建或更新审批表单模板
     *  *
     * @param FormCreateRequest $request FormCreateRequest
     * @param FormCreateHeaders $headers FormCreateHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return FormCreateResponse FormCreateResponse
     */
    public function formCreateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->formComponents)) {
            $body['formComponents'] = $request->formComponents;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->processCode)) {
            $body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->templateConfig)) {
            $body['templateConfig'] = $request->templateConfig;
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
            'action'      => 'FormCreate',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/forms',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return FormCreateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建或更新审批表单模板
     *  *
     * @param FormCreateRequest $request FormCreateRequest
     *
     * @return FormCreateResponse FormCreateResponse
     */
    public function formCreate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FormCreateHeaders([]);

        return $this->formCreateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取审批钉盘空间信息
     *  *
     * @param GetAttachmentSpaceRequest $request GetAttachmentSpaceRequest
     * @param GetAttachmentSpaceHeaders $headers GetAttachmentSpaceHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAttachmentSpaceResponse GetAttachmentSpaceResponse
     */
    public function getAttachmentSpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->agentId)) {
            $body['agentId'] = $request->agentId;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action'      => 'GetAttachmentSpace',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processInstances/spaces/infos/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAttachmentSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取审批钉盘空间信息
     *  *
     * @param GetAttachmentSpaceRequest $request GetAttachmentSpaceRequest
     *
     * @return GetAttachmentSpaceResponse GetAttachmentSpaceResponse
     */
    public function getAttachmentSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAttachmentSpaceHeaders([]);

        return $this->getAttachmentSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询已设置为条件的表单组件
     *  *
     * @param GetConditionFormComponentRequest $request GetConditionFormComponentRequest
     * @param GetConditionFormComponentHeaders $headers GetConditionFormComponentHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return GetConditionFormComponentResponse GetConditionFormComponentResponse
     */
    public function getConditionFormComponentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->agentId)) {
            $query['agentId'] = $request->agentId;
        }
        if (!Utils::isUnset($request->processCode)) {
            $query['processCode'] = $request->processCode;
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
            'action'      => 'GetConditionFormComponent',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processes/conditions/components',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetConditionFormComponentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询已设置为条件的表单组件
     *  *
     * @param GetConditionFormComponentRequest $request GetConditionFormComponentRequest
     *
     * @return GetConditionFormComponentResponse GetConditionFormComponentResponse
     */
    public function getConditionFormComponent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConditionFormComponentHeaders([]);

        return $this->getConditionFormComponentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取CRM所有流程code
     *  *
     * @param GetCrmProcCodesHeaders $headers GetCrmProcCodesHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCrmProcCodesResponse GetCrmProcCodesResponse
     */
    public function getCrmProcCodesWithOptions($headers, $runtime)
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
            'action'      => 'GetCrmProcCodes',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/crm/processes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCrmProcCodesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取CRM所有流程code
     *  *
     * @return GetCrmProcCodesResponse GetCrmProcCodesResponse
     */
    public function getCrmProcCodes()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCrmProcCodesHeaders([]);

        return $this->getCrmProcCodesWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取表单字段修改历史
     *  *
     * @param GetFieldModifiedHistoryRequest $request GetFieldModifiedHistoryRequest
     * @param GetFieldModifiedHistoryHeaders $headers GetFieldModifiedHistoryHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFieldModifiedHistoryResponse GetFieldModifiedHistoryResponse
     */
    public function getFieldModifiedHistoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fieldId)) {
            $body['fieldId'] = $request->fieldId;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
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
            'action'      => 'GetFieldModifiedHistory',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processes/fields/modifiedRecords/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFieldModifiedHistoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取表单字段修改历史
     *  *
     * @param GetFieldModifiedHistoryRequest $request GetFieldModifiedHistoryRequest
     *
     * @return GetFieldModifiedHistoryResponse GetFieldModifiedHistoryResponse
     */
    public function getFieldModifiedHistory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFieldModifiedHistoryHeaders([]);

        return $this->getFieldModifiedHistoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取手写签名的下载链接
     *  *
     * @param GetHandSignDownloadUrlRequest $request GetHandSignDownloadUrlRequest
     * @param GetHandSignDownloadUrlHeaders $headers GetHandSignDownloadUrlHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetHandSignDownloadUrlResponse GetHandSignDownloadUrlResponse
     */
    public function getHandSignDownloadUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->handSignToken)) {
            $body['handSignToken'] = $request->handSignToken;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
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
            'action'      => 'GetHandSignDownloadUrl',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/premium/processInstances/handSigns/downloadUrls/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetHandSignDownloadUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取手写签名的下载链接
     *  *
     * @param GetHandSignDownloadUrlRequest $request GetHandSignDownloadUrlRequest
     *
     * @return GetHandSignDownloadUrlResponse GetHandSignDownloadUrlResponse
     */
    public function getHandSignDownloadUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetHandSignDownloadUrlHeaders([]);

        return $this->getHandSignDownloadUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取当前企业所有可管理的表单
     *  *
     * @param GetManageProcessByStaffIdRequest $request GetManageProcessByStaffIdRequest
     * @param GetManageProcessByStaffIdHeaders $headers GetManageProcessByStaffIdHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return GetManageProcessByStaffIdResponse GetManageProcessByStaffIdResponse
     */
    public function getManageProcessByStaffIdWithOptions($request, $headers, $runtime)
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
            'action'      => 'GetManageProcessByStaffId',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processes/managements/templates',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetManageProcessByStaffIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取当前企业所有可管理的表单
     *  *
     * @param GetManageProcessByStaffIdRequest $request GetManageProcessByStaffIdRequest
     *
     * @return GetManageProcessByStaffIdResponse GetManageProcessByStaffIdResponse
     */
    public function getManageProcessByStaffId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetManageProcessByStaffIdHeaders([]);

        return $this->getManageProcessByStaffIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取模板code
     *  *
     * @param GetProcessCodeByNameRequest $request GetProcessCodeByNameRequest
     * @param GetProcessCodeByNameHeaders $headers GetProcessCodeByNameHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetProcessCodeByNameResponse GetProcessCodeByNameResponse
     */
    public function getProcessCodeByNameWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->name)) {
            $query['name'] = $request->name;
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
            'action'      => 'GetProcessCodeByName',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processCentres/schemaNames/processCodes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetProcessCodeByNameResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取模板code
     *  *
     * @param GetProcessCodeByNameRequest $request GetProcessCodeByNameRequest
     *
     * @return GetProcessCodeByNameResponse GetProcessCodeByNameResponse
     */
    public function getProcessCodeByName($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProcessCodeByNameHeaders([]);

        return $this->getProcessCodeByNameWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取流程配置
     *  *
     * @param GetProcessConfigRequest $request GetProcessConfigRequest
     * @param GetProcessConfigHeaders $headers GetProcessConfigHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetProcessConfigResponse GetProcessConfigResponse
     */
    public function getProcessConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->procCode)) {
            $query['procCode'] = $request->procCode;
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
            'action'      => 'GetProcessConfig',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/crm/processes/configurations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetProcessConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取流程配置
     *  *
     * @param GetProcessConfigRequest $request GetProcessConfigRequest
     *
     * @return GetProcessConfigResponse GetProcessConfigResponse
     */
    public function getProcessConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProcessConfigHeaders([]);

        return $this->getProcessConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取单个审批实例详情
     *  *
     * @param GetProcessInstanceRequest $request GetProcessInstanceRequest
     * @param GetProcessInstanceHeaders $headers GetProcessInstanceHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetProcessInstanceResponse GetProcessInstanceResponse
     */
    public function getProcessInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->processInstanceId)) {
            $query['processInstanceId'] = $request->processInstanceId;
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
            'action'      => 'GetProcessInstance',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processInstances',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetProcessInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取单个审批实例详情
     *  *
     * @param GetProcessInstanceRequest $request GetProcessInstanceRequest
     *
     * @return GetProcessInstanceResponse GetProcessInstanceResponse
     */
    public function getProcessInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProcessInstanceHeaders([]);

        return $this->getProcessInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取审批单详情高级接口，可以返回审批流程中的手写签名密码消息
     *  *
     * @param GetProcessInstanceWithExtraRequest $request GetProcessInstanceWithExtraRequest
     * @param GetProcessInstanceWithExtraHeaders $headers GetProcessInstanceWithExtraHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetProcessInstanceWithExtraResponse GetProcessInstanceWithExtraResponse
     */
    public function getProcessInstanceWithExtraWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->processInstanceId)) {
            $query['processInstanceId'] = $request->processInstanceId;
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
            'action'      => 'GetProcessInstanceWithExtra',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/premium/processInstances',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetProcessInstanceWithExtraResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取审批单详情高级接口，可以返回审批流程中的手写签名密码消息
     *  *
     * @param GetProcessInstanceWithExtraRequest $request GetProcessInstanceWithExtraRequest
     *
     * @return GetProcessInstanceWithExtraResponse GetProcessInstanceWithExtraResponse
     */
    public function getProcessInstanceWithExtra($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProcessInstanceWithExtraHeaders([]);

        return $this->getProcessInstanceWithExtraWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据模版code列表批量查询模板最新表单和流程配置
     *  *
     * @param GetSchemaAndProcessconfigBatchllyRequest $tmpReq  GetSchemaAndProcessconfigBatchllyRequest
     * @param GetSchemaAndProcessconfigBatchllyHeaders $headers GetSchemaAndProcessconfigBatchllyHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSchemaAndProcessconfigBatchllyResponse GetSchemaAndProcessconfigBatchllyResponse
     */
    public function getSchemaAndProcessconfigBatchllyWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new GetSchemaAndProcessconfigBatchllyShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->processCodes)) {
            $request->processCodesShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->processCodes, 'processCodes', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->processCodesShrink)) {
            $query['processCodes'] = $request->processCodesShrink;
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
            'action'      => 'GetSchemaAndProcessconfigBatchlly',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processes/templates/batchQuery',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSchemaAndProcessconfigBatchllyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据模版code列表批量查询模板最新表单和流程配置
     *  *
     * @param GetSchemaAndProcessconfigBatchllyRequest $request GetSchemaAndProcessconfigBatchllyRequest
     *
     * @return GetSchemaAndProcessconfigBatchllyResponse GetSchemaAndProcessconfigBatchllyResponse
     */
    public function getSchemaAndProcessconfigBatchlly($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSchemaAndProcessconfigBatchllyHeaders([]);

        return $this->getSchemaAndProcessconfigBatchllyWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 授权预览审批附件
     *  *
     * @param GetSpaceWithDownloadAuthRequest $request GetSpaceWithDownloadAuthRequest
     * @param GetSpaceWithDownloadAuthHeaders $headers GetSpaceWithDownloadAuthHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSpaceWithDownloadAuthResponse GetSpaceWithDownloadAuthResponse
     */
    public function getSpaceWithDownloadAuthWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->agentId)) {
            $body['agentId'] = $request->agentId;
        }
        if (!Utils::isUnset($request->fileId)) {
            $body['fileId'] = $request->fileId;
        }
        if (!Utils::isUnset($request->fileIdList)) {
            $body['fileIdList'] = $request->fileIdList;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->withCommentAttatchment)) {
            $body['withCommentAttatchment'] = $request->withCommentAttatchment;
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
            'action'      => 'GetSpaceWithDownloadAuth',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processInstances/spaces/authPreview',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSpaceWithDownloadAuthResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 授权预览审批附件
     *  *
     * @param GetSpaceWithDownloadAuthRequest $request GetSpaceWithDownloadAuthRequest
     *
     * @return GetSpaceWithDownloadAuthResponse GetSpaceWithDownloadAuthResponse
     */
    public function getSpaceWithDownloadAuth($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSpaceWithDownloadAuthHeaders([]);

        return $this->getSpaceWithDownloadAuthWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取用户待审批数量
     *  *
     * @param GetUserTodoTaskSumRequest $request GetUserTodoTaskSumRequest
     * @param GetUserTodoTaskSumHeaders $headers GetUserTodoTaskSumHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserTodoTaskSumResponse GetUserTodoTaskSumResponse
     */
    public function getUserTodoTaskSumWithOptions($request, $headers, $runtime)
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
            'action'      => 'GetUserTodoTaskSum',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processes/todoTasks/numbers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserTodoTaskSumResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户待审批数量
     *  *
     * @param GetUserTodoTaskSumRequest $request GetUserTodoTaskSumRequest
     *
     * @return GetUserTodoTaskSumResponse GetUserTodoTaskSumResponse
     */
    public function getUserTodoTaskSum($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserTodoTaskSumHeaders([]);

        return $this->getUserTodoTaskSumWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary  授权用户钉盘空间权限
     *  *
     * @param GrantCspaceAuthorizationRequest $request GrantCspaceAuthorizationRequest
     * @param GrantCspaceAuthorizationHeaders $headers GrantCspaceAuthorizationHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return GrantCspaceAuthorizationResponse GrantCspaceAuthorizationResponse
     */
    public function grantCspaceAuthorizationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->durationSeconds)) {
            $body['durationSeconds'] = $request->durationSeconds;
        }
        if (!Utils::isUnset($request->spaceId)) {
            $body['spaceId'] = $request->spaceId;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action'      => 'GrantCspaceAuthorization',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/spaces/authorize',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return GrantCspaceAuthorizationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary  授权用户钉盘空间权限
     *  *
     * @param GrantCspaceAuthorizationRequest $request GrantCspaceAuthorizationRequest
     *
     * @return GrantCspaceAuthorizationResponse GrantCspaceAuthorizationResponse
     */
    public function grantCspaceAuthorization($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GrantCspaceAuthorizationHeaders([]);

        return $this->grantCspaceAuthorizationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 下载审批附件
     *  *
     * @param GrantProcessInstanceForDownloadFileRequest $request GrantProcessInstanceForDownloadFileRequest
     * @param GrantProcessInstanceForDownloadFileHeaders $headers GrantProcessInstanceForDownloadFileHeaders
     * @param RuntimeOptions                             $runtime runtime options for this request RuntimeOptions
     *
     * @return GrantProcessInstanceForDownloadFileResponse GrantProcessInstanceForDownloadFileResponse
     */
    public function grantProcessInstanceForDownloadFileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fileId)) {
            $body['fileId'] = $request->fileId;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->withCommentAttatchment)) {
            $body['withCommentAttatchment'] = $request->withCommentAttatchment;
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
            'action'      => 'GrantProcessInstanceForDownloadFile',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processInstances/spaces/files/urls/download',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GrantProcessInstanceForDownloadFileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 下载审批附件
     *  *
     * @param GrantProcessInstanceForDownloadFileRequest $request GrantProcessInstanceForDownloadFileRequest
     *
     * @return GrantProcessInstanceForDownloadFileResponse GrantProcessInstanceForDownloadFileResponse
     */
    public function grantProcessInstanceForDownloadFile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GrantProcessInstanceForDownloadFileHeaders([]);

        return $this->grantProcessInstanceForDownloadFileWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建或更新分组
     *  *
     * @param InsertOrUpdateDirRequest $request InsertOrUpdateDirRequest
     * @param InsertOrUpdateDirHeaders $headers InsertOrUpdateDirHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return InsertOrUpdateDirResponse InsertOrUpdateDirResponse
     */
    public function insertOrUpdateDirWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizGroup)) {
            $body['bizGroup'] = $request->bizGroup;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->name18n)) {
            $body['name18n'] = $request->name18n;
        }
        if (!Utils::isUnset($request->operateUserId)) {
            $body['operateUserId'] = $request->operateUserId;
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
            'action'      => 'InsertOrUpdateDir',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processCentres/directories',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InsertOrUpdateDirResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建或更新分组
     *  *
     * @param InsertOrUpdateDirRequest $request InsertOrUpdateDirRequest
     *
     * @return InsertOrUpdateDirResponse InsertOrUpdateDirResponse
     */
    public function insertOrUpdateDir($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertOrUpdateDirHeaders([]);

        return $this->insertOrUpdateDirWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 应用安装
     *  *
     * @param InstallAppRequest $request InstallAppRequest
     * @param InstallAppHeaders $headers InstallAppHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return InstallAppResponse InstallAppResponse
     */
    public function installAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizGroup)) {
            $body['bizGroup'] = $request->bizGroup;
        }
        if (!Utils::isUnset($request->installOption)) {
            $body['installOption'] = $request->installOption;
        }
        if (!Utils::isUnset($request->sourceDirName)) {
            $body['sourceDirName'] = $request->sourceDirName;
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
            'action'      => 'InstallApp',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processes/apps/install',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InstallAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 应用安装
     *  *
     * @param InstallAppRequest $request InstallAppRequest
     *
     * @return InstallAppResponse InstallAppResponse
     */
    public function installApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InstallAppHeaders([]);

        return $this->installAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取审批实例ID列表
     *  *
     * @param ListProcessInstanceIdsRequest $request ListProcessInstanceIdsRequest
     * @param ListProcessInstanceIdsHeaders $headers ListProcessInstanceIdsHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return ListProcessInstanceIdsResponse ListProcessInstanceIdsResponse
     */
    public function listProcessInstanceIdsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->processCode)) {
            $body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->statuses)) {
            $body['statuses'] = $request->statuses;
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
            'action'      => 'ListProcessInstanceIds',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processes/instanceIds/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListProcessInstanceIdsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取审批实例ID列表
     *  *
     * @param ListProcessInstanceIdsRequest $request ListProcessInstanceIdsRequest
     *
     * @return ListProcessInstanceIdsResponse ListProcessInstanceIdsResponse
     */
    public function listProcessInstanceIds($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListProcessInstanceIdsHeaders([]);

        return $this->listProcessInstanceIdsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户待办事项
     *  *
     * @param ListTodoWorkRecordsRequest $request ListTodoWorkRecordsRequest
     * @param ListTodoWorkRecordsHeaders $headers ListTodoWorkRecordsHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return ListTodoWorkRecordsResponse ListTodoWorkRecordsResponse
     */
    public function listTodoWorkRecordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->status)) {
            $query['status'] = $request->status;
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
            'action'      => 'ListTodoWorkRecords',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/workRecords/todoTasks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListTodoWorkRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户待办事项
     *  *
     * @param ListTodoWorkRecordsRequest $request ListTodoWorkRecordsRequest
     *
     * @return ListTodoWorkRecordsResponse ListTodoWorkRecordsResponse
     */
    public function listTodoWorkRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListTodoWorkRecordsHeaders([]);

        return $this->listTodoWorkRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取指定用户可见的审批表单列表
     *  *
     * @param ListUserVisibleBpmsProcessesRequest $request ListUserVisibleBpmsProcessesRequest
     * @param ListUserVisibleBpmsProcessesHeaders $headers ListUserVisibleBpmsProcessesHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return ListUserVisibleBpmsProcessesResponse ListUserVisibleBpmsProcessesResponse
     */
    public function listUserVisibleBpmsProcessesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
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
            'action'      => 'ListUserVisibleBpmsProcesses',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processes/userVisibilities/templates',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListUserVisibleBpmsProcessesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取指定用户可见的审批表单列表
     *  *
     * @param ListUserVisibleBpmsProcessesRequest $request ListUserVisibleBpmsProcessesRequest
     *
     * @return ListUserVisibleBpmsProcessesResponse ListUserVisibleBpmsProcessesResponse
     */
    public function listUserVisibleBpmsProcesses($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListUserVisibleBpmsProcessesHeaders([]);

        return $this->listUserVisibleBpmsProcessesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页查询实例数据
     *  *
     * @param PagesExportInstancesRequest $request PagesExportInstancesRequest
     * @param PagesExportInstancesHeaders $headers PagesExportInstancesHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return PagesExportInstancesResponse PagesExportInstancesResponse
     */
    public function pagesExportInstancesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTimeInMills)) {
            $query['endTimeInMills'] = $request->endTimeInMills;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->orderBy)) {
            $query['orderBy'] = $request->orderBy;
        }
        if (!Utils::isUnset($request->processCode)) {
            $query['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->startTimeInMills)) {
            $query['startTimeInMills'] = $request->startTimeInMills;
        }
        if (!Utils::isUnset($request->status)) {
            $query['status'] = $request->status;
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
            'action'      => 'PagesExportInstances',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/instances/datas',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PagesExportInstancesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页查询实例数据
     *  *
     * @param PagesExportInstancesRequest $request PagesExportInstancesRequest
     *
     * @return PagesExportInstancesResponse PagesExportInstancesResponse
     */
    public function pagesExportInstances($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PagesExportInstancesHeaders([]);

        return $this->pagesExportInstancesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量同意或拒绝审批任务(OA高级版专享接口)
     *  *
     * @param PremiumBatchExecuteProcessInstancesRequest $request PremiumBatchExecuteProcessInstancesRequest
     * @param PremiumBatchExecuteProcessInstancesHeaders $headers PremiumBatchExecuteProcessInstancesHeaders
     * @param RuntimeOptions                             $runtime runtime options for this request RuntimeOptions
     *
     * @return PremiumBatchExecuteProcessInstancesResponse PremiumBatchExecuteProcessInstancesResponse
     */
    public function premiumBatchExecuteProcessInstancesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionerUserId)) {
            $body['actionerUserId'] = $request->actionerUserId;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->result)) {
            $body['result'] = $request->result;
        }
        if (!Utils::isUnset($request->taskInfoList)) {
            $body['taskInfoList'] = $request->taskInfoList;
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
            'action'      => 'PremiumBatchExecuteProcessInstances',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/premium/processInstances/batchExecute',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PremiumBatchExecuteProcessInstancesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量同意或拒绝审批任务(OA高级版专享接口)
     *  *
     * @param PremiumBatchExecuteProcessInstancesRequest $request PremiumBatchExecuteProcessInstancesRequest
     *
     * @return PremiumBatchExecuteProcessInstancesResponse PremiumBatchExecuteProcessInstancesResponse
     */
    public function premiumBatchExecuteProcessInstances($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PremiumBatchExecuteProcessInstancesHeaders([]);

        return $this->premiumBatchExecuteProcessInstancesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除业务分组(高级版专享接口)
     *  *
     * @param PremiumDelDirRequest $request PremiumDelDirRequest
     * @param PremiumDelDirHeaders $headers PremiumDelDirHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return PremiumDelDirResponse PremiumDelDirResponse
     */
    public function premiumDelDirWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->dirId)) {
            $query['dirId'] = $request->dirId;
        }
        if (!Utils::isUnset($request->operateUserId)) {
            $query['operateUserId'] = $request->operateUserId;
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
            'action'      => 'PremiumDelDir',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/premium/processCentres/directories',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PremiumDelDirResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除业务分组(高级版专享接口)
     *  *
     * @param PremiumDelDirRequest $request PremiumDelDirRequest
     *
     * @return PremiumDelDirResponse PremiumDelDirResponse
     */
    public function premiumDelDir($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PremiumDelDirHeaders([]);

        return $this->premiumDelDirWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询审批中心已处理任务列表(OA高级版专享接口)
     *  *
     * @param PremiumGetDoneTasksRequest $request PremiumGetDoneTasksRequest
     * @param PremiumGetDoneTasksHeaders $headers PremiumGetDoneTasksHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return PremiumGetDoneTasksResponse PremiumGetDoneTasksResponse
     */
    public function premiumGetDoneTasksWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->dingClientId)) {
            $query['dingClientId'] = $request->dingClientId;
        }
        if (!Utils::isUnset($request->keyword)) {
            $query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action'      => 'PremiumGetDoneTasks',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/premium/processCentres/doneTasks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PremiumGetDoneTasksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询审批中心已处理任务列表(OA高级版专享接口)
     *  *
     * @param PremiumGetDoneTasksRequest $request PremiumGetDoneTasksRequest
     *
     * @return PremiumGetDoneTasksResponse PremiumGetDoneTasksResponse
     */
    public function premiumGetDoneTasks($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PremiumGetDoneTasksHeaders([]);

        return $this->premiumGetDoneTasksWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取字段修改历史(高级版专享接口)
     *  *
     * @param PremiumGetFieldModifiedHistoryRequest $request PremiumGetFieldModifiedHistoryRequest
     * @param PremiumGetFieldModifiedHistoryHeaders $headers PremiumGetFieldModifiedHistoryHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return PremiumGetFieldModifiedHistoryResponse PremiumGetFieldModifiedHistoryResponse
     */
    public function premiumGetFieldModifiedHistoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fieldId)) {
            $body['fieldId'] = $request->fieldId;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
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
            'action'      => 'PremiumGetFieldModifiedHistory',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/premium/processes/fields/modifiedRecords/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PremiumGetFieldModifiedHistoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取字段修改历史(高级版专享接口)
     *  *
     * @param PremiumGetFieldModifiedHistoryRequest $request PremiumGetFieldModifiedHistoryRequest
     *
     * @return PremiumGetFieldModifiedHistoryResponse PremiumGetFieldModifiedHistoryResponse
     */
    public function premiumGetFieldModifiedHistory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PremiumGetFieldModifiedHistoryHeaders([]);

        return $this->premiumGetFieldModifiedHistoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询审批中心我收到的实例列表(OA高级版专享接口)
     *  *
     * @param PremiumGetNoticedInstancesRequest $request PremiumGetNoticedInstancesRequest
     * @param PremiumGetNoticedInstancesHeaders $headers PremiumGetNoticedInstancesHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return PremiumGetNoticedInstancesResponse PremiumGetNoticedInstancesResponse
     */
    public function premiumGetNoticedInstancesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->dingClientId)) {
            $query['dingClientId'] = $request->dingClientId;
        }
        if (!Utils::isUnset($request->keyword)) {
            $query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action'      => 'PremiumGetNoticedInstances',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/premium/processCentres/noticedInstances',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PremiumGetNoticedInstancesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询审批中心我收到的实例列表(OA高级版专享接口)
     *  *
     * @param PremiumGetNoticedInstancesRequest $request PremiumGetNoticedInstancesRequest
     *
     * @return PremiumGetNoticedInstancesResponse PremiumGetNoticedInstancesResponse
     */
    public function premiumGetNoticedInstances($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PremiumGetNoticedInstancesHeaders([]);

        return $this->premiumGetNoticedInstancesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据processCode分页获取审批流程数据(高级版专享接口)
     *  *
     * @param PremiumGetProcessInstancesRequest $request PremiumGetProcessInstancesRequest
     * @param PremiumGetProcessInstancesHeaders $headers PremiumGetProcessInstancesHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return PremiumGetProcessInstancesResponse PremiumGetProcessInstancesResponse
     */
    public function premiumGetProcessInstancesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appUuid)) {
            $query['appUuid'] = $request->appUuid;
        }
        if (!Utils::isUnset($request->endTimeInMills)) {
            $query['endTimeInMills'] = $request->endTimeInMills;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->processCode)) {
            $query['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->startTimeInMills)) {
            $query['startTimeInMills'] = $request->startTimeInMills;
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
            'action'      => 'PremiumGetProcessInstances',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/premium/processes/pages/instances',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PremiumGetProcessInstancesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据processCode分页获取审批流程数据(高级版专享接口)
     *  *
     * @param PremiumGetProcessInstancesRequest $request PremiumGetProcessInstancesRequest
     *
     * @return PremiumGetProcessInstancesResponse PremiumGetProcessInstancesResponse
     */
    public function premiumGetProcessInstances($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PremiumGetProcessInstancesHeaders([]);

        return $this->premiumGetProcessInstancesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询审批中心已发起实例列表(OA高级版专享接口)
     *  *
     * @param PremiumGetSubmittedInstancesRequest $request PremiumGetSubmittedInstancesRequest
     * @param PremiumGetSubmittedInstancesHeaders $headers PremiumGetSubmittedInstancesHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return PremiumGetSubmittedInstancesResponse PremiumGetSubmittedInstancesResponse
     */
    public function premiumGetSubmittedInstancesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->dingClientId)) {
            $query['dingClientId'] = $request->dingClientId;
        }
        if (!Utils::isUnset($request->keyword)) {
            $query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action'      => 'PremiumGetSubmittedInstances',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/premium/processCentres/submittedInstances',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PremiumGetSubmittedInstancesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询审批中心已发起实例列表(OA高级版专享接口)
     *  *
     * @param PremiumGetSubmittedInstancesRequest $request PremiumGetSubmittedInstancesRequest
     *
     * @return PremiumGetSubmittedInstancesResponse PremiumGetSubmittedInstancesResponse
     */
    public function premiumGetSubmittedInstances($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PremiumGetSubmittedInstancesHeaders([]);

        return $this->premiumGetSubmittedInstancesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询审批中心待处理任务列表(OA高级版专享接口)
     *  *
     * @param PremiumGetTodoTasksRequest $request PremiumGetTodoTasksRequest
     * @param PremiumGetTodoTasksHeaders $headers PremiumGetTodoTasksHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return PremiumGetTodoTasksResponse PremiumGetTodoTasksResponse
     */
    public function premiumGetTodoTasksWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->createBefore)) {
            $query['createBefore'] = $request->createBefore;
        }
        if (!Utils::isUnset($request->keyword)) {
            $query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action'      => 'PremiumGetTodoTasks',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/premium/processCentres/todoTasks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PremiumGetTodoTasksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询审批中心待处理任务列表(OA高级版专享接口)
     *  *
     * @param PremiumGetTodoTasksRequest $request PremiumGetTodoTasksRequest
     *
     * @return PremiumGetTodoTasksResponse PremiumGetTodoTasksResponse
     */
    public function premiumGetTodoTasks($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PremiumGetTodoTasksHeaders([]);

        return $this->premiumGetTodoTasksWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建或更新分组(高级版专享接口)
     *  *
     * @param PremiumInsertOrUpdateDirRequest $request PremiumInsertOrUpdateDirRequest
     * @param PremiumInsertOrUpdateDirHeaders $headers PremiumInsertOrUpdateDirHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return PremiumInsertOrUpdateDirResponse PremiumInsertOrUpdateDirResponse
     */
    public function premiumInsertOrUpdateDirWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizGroup)) {
            $body['bizGroup'] = $request->bizGroup;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->name18n)) {
            $body['name18n'] = $request->name18n;
        }
        if (!Utils::isUnset($request->operateUserId)) {
            $body['operateUserId'] = $request->operateUserId;
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
            'action'      => 'PremiumInsertOrUpdateDir',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/premium/processCentres/directories',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PremiumInsertOrUpdateDirResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建或更新分组(高级版专享接口)
     *  *
     * @param PremiumInsertOrUpdateDirRequest $request PremiumInsertOrUpdateDirRequest
     *
     * @return PremiumInsertOrUpdateDirResponse PremiumInsertOrUpdateDirResponse
     */
    public function premiumInsertOrUpdateDir($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PremiumInsertOrUpdateDirHeaders([]);

        return $this->premiumInsertOrUpdateDirWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 流程转交待处理任务查询(高级版专享接口)
     *  *
     * @param PremiumQueryTodoTasksByManagerRequest $request PremiumQueryTodoTasksByManagerRequest
     * @param PremiumQueryTodoTasksByManagerHeaders $headers PremiumQueryTodoTasksByManagerHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return PremiumQueryTodoTasksByManagerResponse PremiumQueryTodoTasksByManagerResponse
     */
    public function premiumQueryTodoTasksByManagerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->actionerUserId)) {
            $query['actionerUserId'] = $request->actionerUserId;
        }
        if (!Utils::isUnset($request->managerUserId)) {
            $query['managerUserId'] = $request->managerUserId;
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
            'action'      => 'PremiumQueryTodoTasksByManager',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/premium/tasks/todoTasks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PremiumQueryTodoTasksByManagerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 流程转交待处理任务查询(高级版专享接口)
     *  *
     * @param PremiumQueryTodoTasksByManagerRequest $request PremiumQueryTodoTasksByManagerRequest
     *
     * @return PremiumQueryTodoTasksByManagerResponse PremiumQueryTodoTasksByManagerResponse
     */
    public function premiumQueryTodoTasksByManager($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PremiumQueryTodoTasksByManagerHeaders([]);

        return $this->premiumQueryTodoTasksByManagerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量流程审批任务转交(高级版专享接口)
     *  *
     * @param PremiumRedirectTasksByManagerRequest $request PremiumRedirectTasksByManagerRequest
     * @param PremiumRedirectTasksByManagerHeaders $headers PremiumRedirectTasksByManagerHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return PremiumRedirectTasksByManagerResponse PremiumRedirectTasksByManagerResponse
     */
    public function premiumRedirectTasksByManagerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->handoverUserId)) {
            $body['handoverUserId'] = $request->handoverUserId;
        }
        if (!Utils::isUnset($request->managerUserId)) {
            $body['managerUserId'] = $request->managerUserId;
        }
        if (!Utils::isUnset($request->taskIds)) {
            $body['taskIds'] = $request->taskIds;
        }
        if (!Utils::isUnset($request->transfereeUserId)) {
            $body['transfereeUserId'] = $request->transfereeUserId;
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
            'action'      => 'PremiumRedirectTasksByManager',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/premium/tasks/batchRedirect',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PremiumRedirectTasksByManagerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量流程审批任务转交(高级版专享接口)
     *  *
     * @param PremiumRedirectTasksByManagerRequest $request PremiumRedirectTasksByManagerRequest
     *
     * @return PremiumRedirectTasksByManagerResponse PremiumRedirectTasksByManagerResponse
     */
    public function premiumRedirectTasksByManager($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PremiumRedirectTasksByManagerHeaders([]);

        return $this->premiumRedirectTasksByManagerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建或更新流程中心外部集成模板(高级版专享接口)
     *  *
     * @param PremiumSaveIntegratedProcessRequest $request PremiumSaveIntegratedProcessRequest
     * @param PremiumSaveIntegratedProcessHeaders $headers PremiumSaveIntegratedProcessHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return PremiumSaveIntegratedProcessResponse PremiumSaveIntegratedProcessResponse
     */
    public function premiumSaveIntegratedProcessWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->formComponents)) {
            $body['formComponents'] = $request->formComponents;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->processCode)) {
            $body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->processFeatureConfig)) {
            $body['processFeatureConfig'] = $request->processFeatureConfig;
        }
        if (!Utils::isUnset($request->templateConfig)) {
            $body['templateConfig'] = $request->templateConfig;
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
            'action'      => 'PremiumSaveIntegratedProcess',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/premium/processCentres/schemas',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PremiumSaveIntegratedProcessResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建或更新流程中心外部集成模板(高级版专享接口)
     *  *
     * @param PremiumSaveIntegratedProcessRequest $request PremiumSaveIntegratedProcessRequest
     *
     * @return PremiumSaveIntegratedProcessResponse PremiumSaveIntegratedProcessResponse
     */
    public function premiumSaveIntegratedProcess($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PremiumSaveIntegratedProcessHeaders([]);

        return $this->premiumSaveIntegratedProcessWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建流程中心外部集成实例(高级版专享接口)
     *  *
     * @param PremiumSaveIntegratedProcessInstanceRequest $request PremiumSaveIntegratedProcessInstanceRequest
     * @param PremiumSaveIntegratedProcessInstanceHeaders $headers PremiumSaveIntegratedProcessInstanceHeaders
     * @param RuntimeOptions                              $runtime runtime options for this request RuntimeOptions
     *
     * @return PremiumSaveIntegratedProcessInstanceResponse PremiumSaveIntegratedProcessInstanceResponse
     */
    public function premiumSaveIntegratedProcessInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizData)) {
            $body['bizData'] = $request->bizData;
        }
        if (!Utils::isUnset($request->formComponentValueList)) {
            $body['formComponentValueList'] = $request->formComponentValueList;
        }
        if (!Utils::isUnset($request->notifiers)) {
            $body['notifiers'] = $request->notifiers;
        }
        if (!Utils::isUnset($request->originatorUserId)) {
            $body['originatorUserId'] = $request->originatorUserId;
        }
        if (!Utils::isUnset($request->processCode)) {
            $body['processCode'] = $request->processCode;
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
            'action'      => 'PremiumSaveIntegratedProcessInstance',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/premium/processCentres/instances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PremiumSaveIntegratedProcessInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建流程中心外部集成实例(高级版专享接口)
     *  *
     * @param PremiumSaveIntegratedProcessInstanceRequest $request PremiumSaveIntegratedProcessInstanceRequest
     *
     * @return PremiumSaveIntegratedProcessInstanceResponse PremiumSaveIntegratedProcessInstanceResponse
     */
    public function premiumSaveIntegratedProcessInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PremiumSaveIntegratedProcessInstanceHeaders([]);

        return $this->premiumSaveIntegratedProcessInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建流程中心外部集成待处理任务(高级版专享接口)
     *  *
     * @param PremiumSaveIntegratedTaskRequest $request PremiumSaveIntegratedTaskRequest
     * @param PremiumSaveIntegratedTaskHeaders $headers PremiumSaveIntegratedTaskHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return PremiumSaveIntegratedTaskResponse PremiumSaveIntegratedTaskResponse
     */
    public function premiumSaveIntegratedTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->activityId)) {
            $body['activityId'] = $request->activityId;
        }
        if (!Utils::isUnset($request->featureConfig)) {
            $body['featureConfig'] = $request->featureConfig;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->tasks)) {
            $body['tasks'] = $request->tasks;
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
            'action'      => 'PremiumSaveIntegratedTask',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/premium/processCentres/tasks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PremiumSaveIntegratedTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建流程中心外部集成待处理任务(高级版专享接口)
     *  *
     * @param PremiumSaveIntegratedTaskRequest $request PremiumSaveIntegratedTaskRequest
     *
     * @return PremiumSaveIntegratedTaskResponse PremiumSaveIntegratedTaskResponse
     */
    public function premiumSaveIntegratedTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PremiumSaveIntegratedTaskHeaders([]);

        return $this->premiumSaveIntegratedTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 审批流程预测
     *  *
     * @param ProcessForecastRequest $request ProcessForecastRequest
     * @param ProcessForecastHeaders $headers ProcessForecastHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ProcessForecastResponse ProcessForecastResponse
     */
    public function processForecastWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->formComponentValues)) {
            $body['formComponentValues'] = $request->formComponentValues;
        }
        if (!Utils::isUnset($request->processCode)) {
            $body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action'      => 'ProcessForecast',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processes/forecast',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ProcessForecastResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 审批流程预测
     *  *
     * @param ProcessForecastRequest $request ProcessForecastRequest
     *
     * @return ProcessForecastResponse ProcessForecastResponse
     */
    public function processForecast($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ProcessForecastHeaders([]);

        return $this->processForecastWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据processCode分页获取表单数据
     *  *
     * @param QueryAllFormInstancesRequest $request QueryAllFormInstancesRequest
     * @param QueryAllFormInstancesHeaders $headers QueryAllFormInstancesHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAllFormInstancesResponse QueryAllFormInstancesResponse
     */
    public function queryAllFormInstancesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appUuid)) {
            $query['appUuid'] = $request->appUuid;
        }
        if (!Utils::isUnset($request->formCode)) {
            $query['formCode'] = $request->formCode;
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
            'action'      => 'QueryAllFormInstances',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/forms/pages/instances',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAllFormInstancesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据processCode分页获取表单数据
     *  *
     * @param QueryAllFormInstancesRequest $request QueryAllFormInstancesRequest
     *
     * @return QueryAllFormInstancesResponse QueryAllFormInstancesResponse
     */
    public function queryAllFormInstances($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllFormInstancesHeaders([]);

        return $this->queryAllFormInstancesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询审批流程实例
     *  *
     * @param QueryAllProcessInstancesRequest $request QueryAllProcessInstancesRequest
     * @param QueryAllProcessInstancesHeaders $headers QueryAllProcessInstancesHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAllProcessInstancesResponse QueryAllProcessInstancesResponse
     */
    public function queryAllProcessInstancesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appUuid)) {
            $query['appUuid'] = $request->appUuid;
        }
        if (!Utils::isUnset($request->endTimeInMills)) {
            $query['endTimeInMills'] = $request->endTimeInMills;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->processCode)) {
            $query['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->startTimeInMills)) {
            $query['startTimeInMills'] = $request->startTimeInMills;
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
            'action'      => 'QueryAllProcessInstances',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processes/pages/instances',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAllProcessInstancesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询审批流程实例
     *  *
     * @param QueryAllProcessInstancesRequest $request QueryAllProcessInstancesRequest
     *
     * @return QueryAllProcessInstancesResponse QueryAllProcessInstancesResponse
     */
    public function queryAllProcessInstances($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllProcessInstancesHeaders([]);

        return $this->queryAllProcessInstancesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据业务标识查询表单描述信息
     *  *
     * @param QueryFormByBizTypeRequest $request QueryFormByBizTypeRequest
     * @param QueryFormByBizTypeHeaders $headers QueryFormByBizTypeHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryFormByBizTypeResponse QueryFormByBizTypeResponse
     */
    public function queryFormByBizTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appUuid)) {
            $body['appUuid'] = $request->appUuid;
        }
        if (!Utils::isUnset($request->bizTypes)) {
            $body['bizTypes'] = $request->bizTypes;
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
            'action'      => 'QueryFormByBizType',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/forms/forminfos/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryFormByBizTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据业务标识查询表单描述信息
     *  *
     * @param QueryFormByBizTypeRequest $request QueryFormByBizTypeRequest
     *
     * @return QueryFormByBizTypeResponse QueryFormByBizTypeResponse
     */
    public function queryFormByBizType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryFormByBizTypeHeaders([]);

        return $this->queryFormByBizTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询数据表单
     *  *
     * @param QueryFormInstanceRequest $request QueryFormInstanceRequest
     * @param QueryFormInstanceHeaders $headers QueryFormInstanceHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryFormInstanceResponse QueryFormInstanceResponse
     */
    public function queryFormInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appUuid)) {
            $query['appUuid'] = $request->appUuid;
        }
        if (!Utils::isUnset($request->formCode)) {
            $query['formCode'] = $request->formCode;
        }
        if (!Utils::isUnset($request->formInstanceId)) {
            $query['formInstanceId'] = $request->formInstanceId;
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
            'action'      => 'QueryFormInstance',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/forms/instances',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryFormInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询数据表单
     *  *
     * @param QueryFormInstanceRequest $request QueryFormInstanceRequest
     *
     * @return QueryFormInstanceResponse QueryFormInstanceResponse
     */
    public function queryFormInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryFormInstanceHeaders([]);

        return $this->queryFormInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询通过流程中心集成的OA审批任务
     *  *
     * @param QueryIntegratedTodoTaskRequest $request QueryIntegratedTodoTaskRequest
     * @param QueryIntegratedTodoTaskHeaders $headers QueryIntegratedTodoTaskHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryIntegratedTodoTaskResponse QueryIntegratedTodoTaskResponse
     */
    public function queryIntegratedTodoTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->createBefore)) {
            $query['createBefore'] = $request->createBefore;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action'      => 'QueryIntegratedTodoTask',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processCentres/todoTasks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryIntegratedTodoTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询通过流程中心集成的OA审批任务
     *  *
     * @param QueryIntegratedTodoTaskRequest $request QueryIntegratedTodoTaskRequest
     *
     * @return QueryIntegratedTodoTaskResponse QueryIntegratedTodoTaskResponse
     */
    public function queryIntegratedTodoTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryIntegratedTodoTaskHeaders([]);

        return $this->queryIntegratedTodoTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据业务标识查询模板
     *  *
     * @param QueryProcessByBizCategoryIdRequest $request QueryProcessByBizCategoryIdRequest
     * @param QueryProcessByBizCategoryIdHeaders $headers QueryProcessByBizCategoryIdHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryProcessByBizCategoryIdResponse QueryProcessByBizCategoryIdResponse
     */
    public function queryProcessByBizCategoryIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizType)) {
            $query['bizType'] = $request->bizType;
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
            'action'      => 'QueryProcessByBizCategoryId',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processes/categories/templates',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryProcessByBizCategoryIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据业务标识查询模板
     *  *
     * @param QueryProcessByBizCategoryIdRequest $request QueryProcessByBizCategoryIdRequest
     *
     * @return QueryProcessByBizCategoryIdResponse QueryProcessByBizCategoryIdResponse
     */
    public function queryProcessByBizCategoryId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryProcessByBizCategoryIdHeaders([]);

        return $this->queryProcessByBizCategoryIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 蓝凌获取schema和流程信息
     *  *
     * @param QuerySchemaAndProcessRequest $request QuerySchemaAndProcessRequest
     * @param QuerySchemaAndProcessHeaders $headers QuerySchemaAndProcessHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QuerySchemaAndProcessResponse QuerySchemaAndProcessResponse
     */
    public function querySchemaAndProcessWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appUuid)) {
            $query['appUuid'] = $request->appUuid;
        }
        if (!Utils::isUnset($request->processCode)) {
            $query['processCode'] = $request->processCode;
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
            'action'      => 'QuerySchemaAndProcess',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/forms/schemaAndProcess',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QuerySchemaAndProcessResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 蓝凌获取schema和流程信息
     *  *
     * @param QuerySchemaAndProcessRequest $request QuerySchemaAndProcessRequest
     *
     * @return QuerySchemaAndProcessResponse QuerySchemaAndProcessResponse
     */
    public function querySchemaAndProcess($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySchemaAndProcessHeaders([]);

        return $this->querySchemaAndProcessWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary  通过 processCode 获取表单 schema 信息
     *  *
     * @param QuerySchemaByProcessCodeRequest $request QuerySchemaByProcessCodeRequest
     * @param QuerySchemaByProcessCodeHeaders $headers QuerySchemaByProcessCodeHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return QuerySchemaByProcessCodeResponse QuerySchemaByProcessCodeResponse
     */
    public function querySchemaByProcessCodeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appUuid)) {
            $query['appUuid'] = $request->appUuid;
        }
        if (!Utils::isUnset($request->processCode)) {
            $query['processCode'] = $request->processCode;
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
            'action'      => 'QuerySchemaByProcessCode',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/forms/schemas/processCodes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QuerySchemaByProcessCodeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary  通过 processCode 获取表单 schema 信息
     *  *
     * @param QuerySchemaByProcessCodeRequest $request QuerySchemaByProcessCodeRequest
     *
     * @return QuerySchemaByProcessCodeResponse QuerySchemaByProcessCodeResponse
     */
    public function querySchemaByProcessCode($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySchemaByProcessCodeHeaders([]);

        return $this->querySchemaByProcessCodeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 转交OA审批任务
     *  *
     * @param RedirectWorkflowTaskRequest $request RedirectWorkflowTaskRequest
     * @param RedirectWorkflowTaskHeaders $headers RedirectWorkflowTaskHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return RedirectWorkflowTaskResponse RedirectWorkflowTaskResponse
     */
    public function redirectWorkflowTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionName)) {
            $body['actionName'] = $request->actionName;
        }
        if (!Utils::isUnset($request->file)) {
            $body['file'] = $request->file;
        }
        if (!Utils::isUnset($request->operateUserId)) {
            $body['operateUserId'] = $request->operateUserId;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->taskId)) {
            $body['taskId'] = $request->taskId;
        }
        if (!Utils::isUnset($request->toUserId)) {
            $body['toUserId'] = $request->toUserId;
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
            'action'      => 'RedirectWorkflowTask',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/tasks/redirect',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RedirectWorkflowTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 转交OA审批任务
     *  *
     * @param RedirectWorkflowTaskRequest $request RedirectWorkflowTaskRequest
     *
     * @return RedirectWorkflowTaskResponse RedirectWorkflowTaskResponse
     */
    public function redirectWorkflowTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RedirectWorkflowTaskHeaders([]);

        return $this->redirectWorkflowTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建实例
     *  *
     * @param SaveIntegratedInstanceRequest $request SaveIntegratedInstanceRequest
     * @param SaveIntegratedInstanceHeaders $headers SaveIntegratedInstanceHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveIntegratedInstanceResponse SaveIntegratedInstanceResponse
     */
    public function saveIntegratedInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizData)) {
            $body['bizData'] = $request->bizData;
        }
        if (!Utils::isUnset($request->featureConfig)) {
            $body['featureConfig'] = $request->featureConfig;
        }
        if (!Utils::isUnset($request->formComponentValueList)) {
            $body['formComponentValueList'] = $request->formComponentValueList;
        }
        if (!Utils::isUnset($request->notifiers)) {
            $body['notifiers'] = $request->notifiers;
        }
        if (!Utils::isUnset($request->originatorUserId)) {
            $body['originatorUserId'] = $request->originatorUserId;
        }
        if (!Utils::isUnset($request->processCode)) {
            $body['processCode'] = $request->processCode;
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
            'action'      => 'SaveIntegratedInstance',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processCentres/instances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveIntegratedInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建实例
     *  *
     * @param SaveIntegratedInstanceRequest $request SaveIntegratedInstanceRequest
     *
     * @return SaveIntegratedInstanceResponse SaveIntegratedInstanceResponse
     */
    public function saveIntegratedInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveIntegratedInstanceHeaders([]);

        return $this->saveIntegratedInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建或更新审批模板
     *  *
     * @param SaveProcessRequest $request SaveProcessRequest
     * @param SaveProcessHeaders $headers SaveProcessHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveProcessResponse SaveProcessResponse
     */
    public function saveProcessWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->formComponents)) {
            $body['formComponents'] = $request->formComponents;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->processCode)) {
            $body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->processFeatureConfig)) {
            $body['processFeatureConfig'] = $request->processFeatureConfig;
        }
        if (!Utils::isUnset($request->templateConfig)) {
            $body['templateConfig'] = $request->templateConfig;
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
            'action'      => 'SaveProcess',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processCentres/schemas',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveProcessResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建或更新审批模板
     *  *
     * @param SaveProcessRequest $request SaveProcessRequest
     *
     * @return SaveProcessResponse SaveProcessResponse
     */
    public function saveProcess($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveProcessHeaders([]);

        return $this->saveProcessWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建审批实例
     *  *
     * @param StartProcessInstanceRequest $request StartProcessInstanceRequest
     * @param StartProcessInstanceHeaders $headers StartProcessInstanceHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return StartProcessInstanceResponse StartProcessInstanceResponse
     */
    public function startProcessInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->approvers)) {
            $body['approvers'] = $request->approvers;
        }
        if (!Utils::isUnset($request->ccList)) {
            $body['ccList'] = $request->ccList;
        }
        if (!Utils::isUnset($request->ccPosition)) {
            $body['ccPosition'] = $request->ccPosition;
        }
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->formComponentValues)) {
            $body['formComponentValues'] = $request->formComponentValues;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            $body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->originatorUserId)) {
            $body['originatorUserId'] = $request->originatorUserId;
        }
        if (!Utils::isUnset($request->processCode)) {
            $body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->targetSelectActioners)) {
            $body['targetSelectActioners'] = $request->targetSelectActioners;
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
            'action'      => 'StartProcessInstance',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processInstances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return StartProcessInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建审批实例
     *  *
     * @param StartProcessInstanceRequest $request StartProcessInstanceRequest
     *
     * @return StartProcessInstanceResponse StartProcessInstanceResponse
     */
    public function startProcessInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartProcessInstanceHeaders([]);

        return $this->startProcessInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 撤销审批实例
     *  *
     * @param TerminateProcessInstanceRequest $request TerminateProcessInstanceRequest
     * @param TerminateProcessInstanceHeaders $headers TerminateProcessInstanceHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return TerminateProcessInstanceResponse TerminateProcessInstanceResponse
     */
    public function terminateProcessInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->isSystem)) {
            $body['isSystem'] = $request->isSystem;
        }
        if (!Utils::isUnset($request->operatingUserId)) {
            $body['operatingUserId'] = $request->operatingUserId;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
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
            'action'      => 'TerminateProcessInstance',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processInstances/terminate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return TerminateProcessInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 撤销审批实例
     *  *
     * @param TerminateProcessInstanceRequest $request TerminateProcessInstanceRequest
     *
     * @return TerminateProcessInstanceResponse TerminateProcessInstanceResponse
     */
    public function terminateProcessInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TerminateProcessInstanceHeaders([]);

        return $this->terminateProcessInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 流程转交待处理任务查询
     *  *
     * @param TodoTasksRequest $request TodoTasksRequest
     * @param TodoTasksHeaders $headers TodoTasksHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return TodoTasksResponse TodoTasksResponse
     */
    public function todoTasksWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->actionerUserId)) {
            $query['actionerUserId'] = $request->actionerUserId;
        }
        if (!Utils::isUnset($request->managerUserId)) {
            $query['managerUserId'] = $request->managerUserId;
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
            'action'      => 'TodoTasks',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/tasks/todoTasks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return TodoTasksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 流程转交待处理任务查询
     *  *
     * @param TodoTasksRequest $request TodoTasksRequest
     *
     * @return TodoTasksResponse TodoTasksResponse
     */
    public function todoTasks($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TodoTasksHeaders([]);

        return $this->todoTasksWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新流程中心任务状态
     *  *
     * @param UpdateIntegratedTaskRequest $request UpdateIntegratedTaskRequest
     * @param UpdateIntegratedTaskHeaders $headers UpdateIntegratedTaskHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateIntegratedTaskResponse UpdateIntegratedTaskResponse
     */
    public function updateIntegratedTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->tasks)) {
            $body['tasks'] = $request->tasks;
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
            'action'      => 'UpdateIntegratedTask',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processCentres/tasks',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateIntegratedTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新流程中心任务状态
     *  *
     * @param UpdateIntegratedTaskRequest $request UpdateIntegratedTaskRequest
     *
     * @return UpdateIntegratedTaskResponse UpdateIntegratedTaskResponse
     */
    public function updateIntegratedTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateIntegratedTaskHeaders([]);

        return $this->updateIntegratedTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新实例状态
     *  *
     * @param UpdateProcessInstanceRequest $request UpdateProcessInstanceRequest
     * @param UpdateProcessInstanceHeaders $headers UpdateProcessInstanceHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateProcessInstanceResponse UpdateProcessInstanceResponse
     */
    public function updateProcessInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->notifiers)) {
            $body['notifiers'] = $request->notifiers;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->result)) {
            $body['result'] = $request->result;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
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
            'action'      => 'UpdateProcessInstance',
            'version'     => 'workflow_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/workflow/processCentres/instances',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateProcessInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新实例状态
     *  *
     * @param UpdateProcessInstanceRequest $request UpdateProcessInstanceRequest
     *
     * @return UpdateProcessInstanceResponse UpdateProcessInstanceResponse
     */
    public function updateProcessInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateProcessInstanceHeaders([]);

        return $this->updateProcessInstanceWithOptions($request, $headers, $runtime);
    }
}
