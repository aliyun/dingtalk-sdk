<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchUpdateProcessInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchUpdateProcessInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchUpdateProcessInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CancelIntegratedTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CancelIntegratedTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CancelIntegratedTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CopyProcessHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CopyProcessRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CopyProcessResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CreateIntegratedTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CreateIntegratedTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CreateIntegratedTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\DeleteProcessHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\DeleteProcessRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\DeleteProcessResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetCrmProcCodesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetCrmProcCodesResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessCodeByNameHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessCodeByNameRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessCodeByNameResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GrantCspaceAuthorizationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GrantCspaceAuthorizationRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GrantCspaceAuthorizationResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\UpdateIntegratedTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\UpdateIntegratedTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\UpdateIntegratedTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\UpdateProcessInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\UpdateProcessInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\UpdateProcessInstanceResponse;
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
     * @param BatchUpdateProcessInstanceRequest $request
     *
     * @return BatchUpdateProcessInstanceResponse
     */
    public function batchUpdateProcessInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateProcessInstanceHeaders([]);

        return $this->batchUpdateProcessInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchUpdateProcessInstanceRequest $request
     * @param BatchUpdateProcessInstanceHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return BatchUpdateProcessInstanceResponse
     */
    public function batchUpdateProcessInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->updateProcessInstanceRequests)) {
            @$body['updateProcessInstanceRequests'] = $request->updateProcessInstanceRequests;
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

        return BatchUpdateProcessInstanceResponse::fromMap($this->doROARequest('BatchUpdateProcessInstance', 'workflow_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/workflow/processCentres/instances/batch', 'json', $req, $runtime));
    }

    /**
     * @param CancelIntegratedTaskRequest $request
     *
     * @return CancelIntegratedTaskResponse
     */
    public function cancelIntegratedTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelIntegratedTaskHeaders([]);

        return $this->cancelIntegratedTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CancelIntegratedTaskRequest $request
     * @param CancelIntegratedTaskHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return CancelIntegratedTaskResponse
     */
    public function cancelIntegratedTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->activityId)) {
            @$body['activityId'] = $request->activityId;
        }
        if (!Utils::isUnset($request->activityIds)) {
            @$body['activityIds'] = $request->activityIds;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            @$body['processInstanceId'] = $request->processInstanceId;
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

        return CancelIntegratedTaskResponse::fromMap($this->doROARequest('CancelIntegratedTask', 'workflow_1.0', 'HTTP', 'POST', 'AK', '/v1.0/workflow/processCentres/tasks/cancel', 'json', $req, $runtime));
    }

    /**
     * @param CopyProcessRequest $request
     *
     * @return CopyProcessResponse
     */
    public function copyProcess($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CopyProcessHeaders([]);

        return $this->copyProcessWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CopyProcessRequest $request
     * @param CopyProcessHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return CopyProcessResponse
     */
    public function copyProcessWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->copyOptions)) {
            @$body['copyOptions'] = $request->copyOptions;
        }
        if (!Utils::isUnset($request->sourceCorpId)) {
            @$body['sourceCorpId'] = $request->sourceCorpId;
        }
        if (!Utils::isUnset($request->sourceProcessVOList)) {
            @$body['sourceProcessVOList'] = $request->sourceProcessVOList;
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

        return CopyProcessResponse::fromMap($this->doROARequest('CopyProcess', 'workflow_1.0', 'HTTP', 'POST', 'AK', '/v1.0/workflow/processes/copy', 'json', $req, $runtime));
    }

    /**
     * @param CreateIntegratedTaskRequest $request
     *
     * @return CreateIntegratedTaskResponse
     */
    public function createIntegratedTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateIntegratedTaskHeaders([]);

        return $this->createIntegratedTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateIntegratedTaskRequest $request
     * @param CreateIntegratedTaskHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return CreateIntegratedTaskResponse
     */
    public function createIntegratedTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->activityId)) {
            @$body['activityId'] = $request->activityId;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            @$body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->tasks)) {
            @$body['tasks'] = $request->tasks;
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

        return CreateIntegratedTaskResponse::fromMap($this->doROARequest('CreateIntegratedTask', 'workflow_1.0', 'HTTP', 'POST', 'AK', '/v1.0/workflow/processCentres/tasks', 'json', $req, $runtime));
    }

    /**
     * @param DeleteProcessRequest $request
     *
     * @return DeleteProcessResponse
     */
    public function deleteProcess($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteProcessHeaders([]);

        return $this->deleteProcessWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteProcessRequest $request
     * @param DeleteProcessHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return DeleteProcessResponse
     */
    public function deleteProcessWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->cleanRunningTask)) {
            @$query['cleanRunningTask'] = $request->cleanRunningTask;
        }
        if (!Utils::isUnset($request->processCode)) {
            @$query['processCode'] = $request->processCode;
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

        return DeleteProcessResponse::fromMap($this->doROARequest('DeleteProcess', 'workflow_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/workflow/processCentres/schemas', 'json', $req, $runtime));
    }

    /**
     * @param FormCreateRequest $request
     *
     * @return FormCreateResponse
     */
    public function formCreate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FormCreateHeaders([]);

        return $this->formCreateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param FormCreateRequest $request
     * @param FormCreateHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return FormCreateResponse
     */
    public function formCreateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->formComponents)) {
            @$body['formComponents'] = $request->formComponents;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->processCode)) {
            @$body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->templateConfig)) {
            @$body['templateConfig'] = $request->templateConfig;
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

        return FormCreateResponse::fromMap($this->doROARequest('FormCreate', 'workflow_1.0', 'HTTP', 'POST', 'AK', '/v1.0/workflow/forms', 'json', $req, $runtime));
    }

    /**
     * @return GetCrmProcCodesResponse
     */
    public function getCrmProcCodes()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCrmProcCodesHeaders([]);

        return $this->getCrmProcCodesWithOptions($headers, $runtime);
    }

    /**
     * @param GetCrmProcCodesHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetCrmProcCodesResponse
     */
    public function getCrmProcCodesWithOptions($headers, $runtime)
    {
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

        return GetCrmProcCodesResponse::fromMap($this->doROARequest('GetCrmProcCodes', 'workflow_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workflow/crm/processes', 'json', $req, $runtime));
    }

    /**
     * @param GetProcessCodeByNameRequest $request
     *
     * @return GetProcessCodeByNameResponse
     */
    public function getProcessCodeByName($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProcessCodeByNameHeaders([]);

        return $this->getProcessCodeByNameWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetProcessCodeByNameRequest $request
     * @param GetProcessCodeByNameHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetProcessCodeByNameResponse
     */
    public function getProcessCodeByNameWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->name)) {
            @$query['name'] = $request->name;
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

        return GetProcessCodeByNameResponse::fromMap($this->doROARequest('GetProcessCodeByName', 'workflow_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workflow/processCentres/schemaNames/processCodes', 'json', $req, $runtime));
    }

    /**
     * @param GetProcessConfigRequest $request
     *
     * @return GetProcessConfigResponse
     */
    public function getProcessConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProcessConfigHeaders([]);

        return $this->getProcessConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetProcessConfigRequest $request
     * @param GetProcessConfigHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetProcessConfigResponse
     */
    public function getProcessConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->procCode)) {
            @$query['procCode'] = $request->procCode;
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

        return GetProcessConfigResponse::fromMap($this->doROARequest('GetProcessConfig', 'workflow_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workflow/crm/processes/configurations', 'json', $req, $runtime));
    }

    /**
     * @param GrantCspaceAuthorizationRequest $request
     *
     * @return GrantCspaceAuthorizationResponse
     */
    public function grantCspaceAuthorization($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GrantCspaceAuthorizationHeaders([]);

        return $this->grantCspaceAuthorizationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GrantCspaceAuthorizationRequest $request
     * @param GrantCspaceAuthorizationHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return GrantCspaceAuthorizationResponse
     */
    public function grantCspaceAuthorizationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->durationSeconds)) {
            @$body['durationSeconds'] = $request->durationSeconds;
        }
        if (!Utils::isUnset($request->spaceId)) {
            @$body['spaceId'] = $request->spaceId;
        }
        if (!Utils::isUnset($request->type)) {
            @$body['type'] = $request->type;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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

        return GrantCspaceAuthorizationResponse::fromMap($this->doROARequest('GrantCspaceAuthorization', 'workflow_1.0', 'HTTP', 'POST', 'AK', '/v1.0/workflow/spaces/authorize', 'none', $req, $runtime));
    }

    /**
     * @param ProcessForecastRequest $request
     *
     * @return ProcessForecastResponse
     */
    public function processForecast($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ProcessForecastHeaders([]);

        return $this->processForecastWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ProcessForecastRequest $request
     * @param ProcessForecastHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ProcessForecastResponse
     */
    public function processForecastWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptId)) {
            @$body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->formComponentValues)) {
            @$body['formComponentValues'] = $request->formComponentValues;
        }
        if (!Utils::isUnset($request->processCode)) {
            @$body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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

        return ProcessForecastResponse::fromMap($this->doROARequest('ProcessForecast', 'workflow_1.0', 'HTTP', 'POST', 'AK', '/v1.0/workflow/processes/forecast', 'json', $req, $runtime));
    }

    /**
     * @param QueryAllFormInstancesRequest $request
     *
     * @return QueryAllFormInstancesResponse
     */
    public function queryAllFormInstances($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllFormInstancesHeaders([]);

        return $this->queryAllFormInstancesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllFormInstancesRequest $request
     * @param QueryAllFormInstancesHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return QueryAllFormInstancesResponse
     */
    public function queryAllFormInstancesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appUuid)) {
            @$query['appUuid'] = $request->appUuid;
        }
        if (!Utils::isUnset($request->formCode)) {
            @$query['formCode'] = $request->formCode;
        }
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

        return QueryAllFormInstancesResponse::fromMap($this->doROARequest('QueryAllFormInstances', 'workflow_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workflow/forms/pages/instances', 'json', $req, $runtime));
    }

    /**
     * @param QueryAllProcessInstancesRequest $request
     *
     * @return QueryAllProcessInstancesResponse
     */
    public function queryAllProcessInstances($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllProcessInstancesHeaders([]);

        return $this->queryAllProcessInstancesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllProcessInstancesRequest $request
     * @param QueryAllProcessInstancesHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return QueryAllProcessInstancesResponse
     */
    public function queryAllProcessInstancesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appUuid)) {
            @$query['appUuid'] = $request->appUuid;
        }
        if (!Utils::isUnset($request->endTimeInMills)) {
            @$query['endTimeInMills'] = $request->endTimeInMills;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->processCode)) {
            @$query['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->startTimeInMills)) {
            @$query['startTimeInMills'] = $request->startTimeInMills;
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

        return QueryAllProcessInstancesResponse::fromMap($this->doROARequest('QueryAllProcessInstances', 'workflow_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workflow/processes/pages/instances', 'json', $req, $runtime));
    }

    /**
     * @param QueryFormByBizTypeRequest $request
     *
     * @return QueryFormByBizTypeResponse
     */
    public function queryFormByBizType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryFormByBizTypeHeaders([]);

        return $this->queryFormByBizTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryFormByBizTypeRequest $request
     * @param QueryFormByBizTypeHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryFormByBizTypeResponse
     */
    public function queryFormByBizTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appUuid)) {
            @$body['appUuid'] = $request->appUuid;
        }
        if (!Utils::isUnset($request->bizTypes)) {
            @$body['bizTypes'] = $request->bizTypes;
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

        return QueryFormByBizTypeResponse::fromMap($this->doROARequest('QueryFormByBizType', 'workflow_1.0', 'HTTP', 'POST', 'AK', '/v1.0/workflow/forms/forminfos/query', 'json', $req, $runtime));
    }

    /**
     * @param QueryFormInstanceRequest $request
     *
     * @return QueryFormInstanceResponse
     */
    public function queryFormInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryFormInstanceHeaders([]);

        return $this->queryFormInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryFormInstanceRequest $request
     * @param QueryFormInstanceHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return QueryFormInstanceResponse
     */
    public function queryFormInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appUuid)) {
            @$query['appUuid'] = $request->appUuid;
        }
        if (!Utils::isUnset($request->formCode)) {
            @$query['formCode'] = $request->formCode;
        }
        if (!Utils::isUnset($request->formInstanceId)) {
            @$query['formInstanceId'] = $request->formInstanceId;
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

        return QueryFormInstanceResponse::fromMap($this->doROARequest('QueryFormInstance', 'workflow_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workflow/forms/instances', 'json', $req, $runtime));
    }

    /**
     * @param QueryIntegratedTodoTaskRequest $request
     *
     * @return QueryIntegratedTodoTaskResponse
     */
    public function queryIntegratedTodoTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryIntegratedTodoTaskHeaders([]);

        return $this->queryIntegratedTodoTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryIntegratedTodoTaskRequest $request
     * @param QueryIntegratedTodoTaskHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return QueryIntegratedTodoTaskResponse
     */
    public function queryIntegratedTodoTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->createBefore)) {
            @$query['createBefore'] = $request->createBefore;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
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

        return QueryIntegratedTodoTaskResponse::fromMap($this->doROARequest('QueryIntegratedTodoTask', 'workflow_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workflow/processCentres/todoTasks', 'json', $req, $runtime));
    }

    /**
     * @param QueryProcessByBizCategoryIdRequest $request
     *
     * @return QueryProcessByBizCategoryIdResponse
     */
    public function queryProcessByBizCategoryId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryProcessByBizCategoryIdHeaders([]);

        return $this->queryProcessByBizCategoryIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryProcessByBizCategoryIdRequest $request
     * @param QueryProcessByBizCategoryIdHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return QueryProcessByBizCategoryIdResponse
     */
    public function queryProcessByBizCategoryIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizType)) {
            @$query['bizType'] = $request->bizType;
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

        return QueryProcessByBizCategoryIdResponse::fromMap($this->doROARequest('QueryProcessByBizCategoryId', 'workflow_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workflow/processes/categories/templates', 'json', $req, $runtime));
    }

    /**
     * @param QuerySchemaByProcessCodeRequest $request
     *
     * @return QuerySchemaByProcessCodeResponse
     */
    public function querySchemaByProcessCode($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySchemaByProcessCodeHeaders([]);

        return $this->querySchemaByProcessCodeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QuerySchemaByProcessCodeRequest $request
     * @param QuerySchemaByProcessCodeHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return QuerySchemaByProcessCodeResponse
     */
    public function querySchemaByProcessCodeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appUuid)) {
            @$query['appUuid'] = $request->appUuid;
        }
        if (!Utils::isUnset($request->processCode)) {
            @$query['processCode'] = $request->processCode;
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

        return QuerySchemaByProcessCodeResponse::fromMap($this->doROARequest('QuerySchemaByProcessCode', 'workflow_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workflow/forms/schemas/processCodes', 'json', $req, $runtime));
    }

    /**
     * @param RedirectWorkflowTaskRequest $request
     *
     * @return RedirectWorkflowTaskResponse
     */
    public function redirectWorkflowTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RedirectWorkflowTaskHeaders([]);

        return $this->redirectWorkflowTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RedirectWorkflowTaskRequest $request
     * @param RedirectWorkflowTaskHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return RedirectWorkflowTaskResponse
     */
    public function redirectWorkflowTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionName)) {
            @$body['actionName'] = $request->actionName;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->taskId)) {
            @$body['taskId'] = $request->taskId;
        }
        if (!Utils::isUnset($request->toUserId)) {
            @$body['toUserId'] = $request->toUserId;
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

        return RedirectWorkflowTaskResponse::fromMap($this->doROARequest('RedirectWorkflowTask', 'workflow_1.0', 'HTTP', 'POST', 'AK', '/v1.0/workflow/tasks/redirect', 'json', $req, $runtime));
    }

    /**
     * @param SaveIntegratedInstanceRequest $request
     *
     * @return SaveIntegratedInstanceResponse
     */
    public function saveIntegratedInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveIntegratedInstanceHeaders([]);

        return $this->saveIntegratedInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SaveIntegratedInstanceRequest $request
     * @param SaveIntegratedInstanceHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return SaveIntegratedInstanceResponse
     */
    public function saveIntegratedInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->formComponentValueList)) {
            @$body['formComponentValueList'] = $request->formComponentValueList;
        }
        if (!Utils::isUnset($request->notifiers)) {
            @$body['notifiers'] = $request->notifiers;
        }
        if (!Utils::isUnset($request->originatorUserId)) {
            @$body['originatorUserId'] = $request->originatorUserId;
        }
        if (!Utils::isUnset($request->processCode)) {
            @$body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->url)) {
            @$body['url'] = $request->url;
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

        return SaveIntegratedInstanceResponse::fromMap($this->doROARequest('SaveIntegratedInstance', 'workflow_1.0', 'HTTP', 'POST', 'AK', '/v1.0/workflow/processCentres/instances', 'json', $req, $runtime));
    }

    /**
     * @param SaveProcessRequest $request
     *
     * @return SaveProcessResponse
     */
    public function saveProcess($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveProcessHeaders([]);

        return $this->saveProcessWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SaveProcessRequest $request
     * @param SaveProcessHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return SaveProcessResponse
     */
    public function saveProcessWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->formComponents)) {
            @$body['formComponents'] = $request->formComponents;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->processCode)) {
            @$body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->processFeatureConfig)) {
            @$body['processFeatureConfig'] = $request->processFeatureConfig;
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

        return SaveProcessResponse::fromMap($this->doROARequest('SaveProcess', 'workflow_1.0', 'HTTP', 'POST', 'AK', '/v1.0/workflow/processCentres/schemas', 'json', $req, $runtime));
    }

    /**
     * @param StartProcessInstanceRequest $request
     *
     * @return StartProcessInstanceResponse
     */
    public function startProcessInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartProcessInstanceHeaders([]);

        return $this->startProcessInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param StartProcessInstanceRequest $request
     * @param StartProcessInstanceHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return StartProcessInstanceResponse
     */
    public function startProcessInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->approvers)) {
            @$body['approvers'] = $request->approvers;
        }
        if (!Utils::isUnset($request->ccList)) {
            @$body['ccList'] = $request->ccList;
        }
        if (!Utils::isUnset($request->ccPosition)) {
            @$body['ccPosition'] = $request->ccPosition;
        }
        if (!Utils::isUnset($request->deptId)) {
            @$body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->formComponentValues)) {
            @$body['formComponentValues'] = $request->formComponentValues;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            @$body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->originatorUserId)) {
            @$body['originatorUserId'] = $request->originatorUserId;
        }
        if (!Utils::isUnset($request->processCode)) {
            @$body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->targetSelectActioners)) {
            @$body['targetSelectActioners'] = $request->targetSelectActioners;
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

        return StartProcessInstanceResponse::fromMap($this->doROARequest('StartProcessInstance', 'workflow_1.0', 'HTTP', 'POST', 'AK', '/v1.0/workflow/processInstances', 'json', $req, $runtime));
    }

    /**
     * @param UpdateIntegratedTaskRequest $request
     *
     * @return UpdateIntegratedTaskResponse
     */
    public function updateIntegratedTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateIntegratedTaskHeaders([]);

        return $this->updateIntegratedTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateIntegratedTaskRequest $request
     * @param UpdateIntegratedTaskHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return UpdateIntegratedTaskResponse
     */
    public function updateIntegratedTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->processInstanceId)) {
            @$body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->tasks)) {
            @$body['tasks'] = $request->tasks;
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

        return UpdateIntegratedTaskResponse::fromMap($this->doROARequest('UpdateIntegratedTask', 'workflow_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/workflow/processCentres/tasks', 'json', $req, $runtime));
    }

    /**
     * @param UpdateProcessInstanceRequest $request
     *
     * @return UpdateProcessInstanceResponse
     */
    public function updateProcessInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateProcessInstanceHeaders([]);

        return $this->updateProcessInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateProcessInstanceRequest $request
     * @param UpdateProcessInstanceHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return UpdateProcessInstanceResponse
     */
    public function updateProcessInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->processInstanceId)) {
            @$body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->result)) {
            @$body['result'] = $request->result;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
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

        return UpdateProcessInstanceResponse::fromMap($this->doROARequest('UpdateProcessInstance', 'workflow_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/workflow/processCentres/instances', 'json', $req, $runtime));
    }
}
