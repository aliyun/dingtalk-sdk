<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetCrmProcCodesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetCrmProcCodesResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\StartProcessInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\StartProcessInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\StartProcessInstanceResponse;
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
}
