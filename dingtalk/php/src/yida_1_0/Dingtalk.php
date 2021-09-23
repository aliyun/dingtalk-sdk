<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteFormDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteFormDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteFormDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteSequenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteSequenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteSequenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecuteCustomApiHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecuteCustomApiRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecuteCustomApiResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecutePlatformTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecutePlatformTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecutePlatformTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecuteTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecuteTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecuteTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExpireCommodityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExpireCommodityRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExpireCommodityResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetActivityListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetActivityListRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetActivityListResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetApplicationAuthorizationServicePlatformResourceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetApplicationAuthorizationServicePlatformResourceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetApplicationAuthorizationServicePlatformResourceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpLevelByAccountIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpLevelByAccountIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpLevelByAccountIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormDataByIDHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormDataByIDRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormDataByIDResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetOperationRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetOperationRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetOperationRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetPlatformResourceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetPlatformResourceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetPlatformResourceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetRunningTasksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetRunningTasksRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetRunningTasksResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetSaleUserInfoByUserIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetSaleUserInfoByUserIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetSaleUserInfoByUserIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListCommodityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListCommodityRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListCommodityResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListNavigationByFormTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListNavigationByFormTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListNavigationByFormTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\LoginCodeGenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\LoginCodeGenRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\LoginCodeGenResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RefundCommodityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RefundCommodityRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RefundCommodityResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ReleaseCommodityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ReleaseCommodityRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ReleaseCommodityResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SaveFormDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SaveFormDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SaveFormDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SaveFormRemarkHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SaveFormRemarkRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SaveFormRemarkResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchActivationCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchActivationCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchActivationCodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchEmployeeFieldValuesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchEmployeeFieldValuesRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchEmployeeFieldValuesResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\StartInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\StartInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\StartInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\TerminateInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\TerminateInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\TerminateInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateFormDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateFormDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateFormDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateOrderBuyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateOrderBuyRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateOrderBuyResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateOrderUpgradeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateOrderUpgradeRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateOrderUpgradeResponse;
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
     * @param ValidateOrderUpgradeRequest $request
     *
     * @return ValidateOrderUpgradeResponse
     */
    public function validateOrderUpgrade($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateOrderUpgradeHeaders([]);

        return $this->validateOrderUpgradeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ValidateOrderUpgradeRequest $request
     * @param ValidateOrderUpgradeHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return ValidateOrderUpgradeResponse
     */
    public function validateOrderUpgradeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->instanceId)) {
            @$query['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ValidateOrderUpgradeResponse::fromMap($this->doROARequest('ValidateOrderUpgrade', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/orderUpgrade/validate', 'json', $req, $runtime));
    }

    /**
     * @param GetCorpLevelByAccountIdRequest $request
     *
     * @return GetCorpLevelByAccountIdResponse
     */
    public function getCorpLevelByAccountId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCorpLevelByAccountIdHeaders([]);

        return $this->getCorpLevelByAccountIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCorpLevelByAccountIdRequest $request
     * @param GetCorpLevelByAccountIdHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return GetCorpLevelByAccountIdResponse
     */
    public function getCorpLevelByAccountIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountId)) {
            @$query['accountId'] = $request->accountId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetCorpLevelByAccountIdResponse::fromMap($this->doROARequest('GetCorpLevelByAccountId', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/corpLevel', 'json', $req, $runtime));
    }

    /**
     * @param UpdateStatusRequest $request
     *
     * @return UpdateStatusResponse
     */
    public function updateStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateStatusHeaders([]);

        return $this->updateStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateStatusRequest $request
     * @param UpdateStatusHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return UpdateStatusResponse
     */
    public function updateStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->importSequence)) {
            @$body['importSequence'] = $request->importSequence;
        }
        if (!Utils::isUnset($request->errorLines)) {
            @$body['errorLines'] = $request->errorLines;
        }
        if (!Utils::isUnset($request->appType)) {
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateStatusResponse::fromMap($this->doROARequest('UpdateStatus', 'yida_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/yida/forms/status', 'none', $req, $runtime));
    }

    /**
     * @param ExecutePlatformTaskRequest $request
     *
     * @return ExecutePlatformTaskResponse
     */
    public function executePlatformTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecutePlatformTaskHeaders([]);

        return $this->executePlatformTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ExecutePlatformTaskRequest $request
     * @param ExecutePlatformTaskHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return ExecutePlatformTaskResponse
     */
    public function executePlatformTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->outResult)) {
            @$body['outResult'] = $request->outResult;
        }
        if (!Utils::isUnset($request->noExecuteExpressions)) {
            @$body['noExecuteExpressions'] = $request->noExecuteExpressions;
        }
        if (!Utils::isUnset($request->appType)) {
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            @$body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            @$body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ExecutePlatformTaskResponse::fromMap($this->doROARequest('ExecutePlatformTask', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/tasks/platformTasks/execute', 'none', $req, $runtime));
    }

    /**
     * @param SaveFormRemarkRequest $request
     *
     * @return SaveFormRemarkResponse
     */
    public function saveFormRemark($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveFormRemarkHeaders([]);

        return $this->saveFormRemarkWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SaveFormRemarkRequest $request
     * @param SaveFormRemarkHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SaveFormRemarkResponse
     */
    public function saveFormRemarkWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->replyId)) {
            @$body['replyId'] = $request->replyId;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->formInstanceId)) {
            @$body['formInstanceId'] = $request->formInstanceId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->atUserId)) {
            @$body['atUserId'] = $request->atUserId;
        }
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SaveFormRemarkResponse::fromMap($this->doROARequest('SaveFormRemark', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/remarks', 'json', $req, $runtime));
    }

    /**
     * @param SearchFormDatasRequest $request
     *
     * @return SearchFormDatasResponse
     */
    public function searchFormDatas($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchFormDatasHeaders([]);

        return $this->searchFormDatasWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchFormDatasRequest $request
     * @param SearchFormDatasHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return SearchFormDatasResponse
     */
    public function searchFormDatasWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            @$body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->currentPage)) {
            @$body['currentPage'] = $request->currentPage;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->originatorId)) {
            @$body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            @$body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            @$body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            @$body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            @$body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->dynamicOrder)) {
            @$body['dynamicOrder'] = $request->dynamicOrder;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SearchFormDatasResponse::fromMap($this->doROARequest('SearchFormDatas', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/instances/search', 'json', $req, $runtime));
    }

    /**
     * @param SearchActivationCodeRequest $request
     *
     * @return SearchActivationCodeResponse
     */
    public function searchActivationCode($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchActivationCodeHeaders([]);

        return $this->searchActivationCodeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchActivationCodeRequest $request
     * @param SearchActivationCodeHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return SearchActivationCodeResponse
     */
    public function searchActivationCodeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return SearchActivationCodeResponse::fromMap($this->doROARequest('SearchActivationCode', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/activationCode/information', 'json', $req, $runtime));
    }

    /**
     * @param SearchEmployeeFieldValuesRequest $request
     *
     * @return SearchEmployeeFieldValuesResponse
     */
    public function searchEmployeeFieldValues($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchEmployeeFieldValuesHeaders([]);

        return $this->searchEmployeeFieldValuesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchEmployeeFieldValuesRequest $request
     * @param SearchEmployeeFieldValuesHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return SearchEmployeeFieldValuesResponse
     */
    public function searchEmployeeFieldValuesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->targetFieldJson)) {
            @$body['targetFieldJson'] = $request->targetFieldJson;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->appType)) {
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            @$body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            @$body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            @$body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->originatorId)) {
            @$body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            @$body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            @$body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SearchEmployeeFieldValuesResponse::fromMap($this->doROARequest('SearchEmployeeFieldValues', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/employeeFields', 'json', $req, $runtime));
    }

    /**
     * @param UpdateFormDataRequest $request
     *
     * @return UpdateFormDataResponse
     */
    public function updateFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateFormDataHeaders([]);

        return $this->updateFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateFormDataRequest $request
     * @param UpdateFormDataHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return UpdateFormDataResponse
     */
    public function updateFormDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->formInstanceId)) {
            @$body['formInstanceId'] = $request->formInstanceId;
        }
        if (!Utils::isUnset($request->useLatestVersion)) {
            @$body['useLatestVersion'] = $request->useLatestVersion;
        }
        if (!Utils::isUnset($request->updateFormDataJson)) {
            @$body['updateFormDataJson'] = $request->updateFormDataJson;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateFormDataResponse::fromMap($this->doROARequest('UpdateFormData', 'yida_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/yida/forms/instances', 'none', $req, $runtime));
    }

    /**
     * @param GetOperationRecordsRequest $request
     *
     * @return GetOperationRecordsResponse
     */
    public function getOperationRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOperationRecordsHeaders([]);

        return $this->getOperationRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetOperationRecordsRequest $request
     * @param GetOperationRecordsHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetOperationRecordsResponse
     */
    public function getOperationRecordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            @$query['processInstanceId'] = $request->processInstanceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetOperationRecordsResponse::fromMap($this->doROARequest('GetOperationRecords', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/processes/operationRecords', 'json', $req, $runtime));
    }

    /**
     * @param GetPlatformResourceRequest $request
     *
     * @return GetPlatformResourceResponse
     */
    public function getPlatformResource($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPlatformResourceHeaders([]);

        return $this->getPlatformResourceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetPlatformResourceRequest $request
     * @param GetPlatformResourceHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetPlatformResourceResponse
     */
    public function getPlatformResourceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->instanceId)) {
            @$query['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetPlatformResourceResponse::fromMap($this->doROARequest('GetPlatformResource', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/platformResources', 'json', $req, $runtime));
    }

    /**
     * @param GetRunningTasksRequest $request
     *
     * @return GetRunningTasksResponse
     */
    public function getRunningTasks($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRunningTasksHeaders([]);

        return $this->getRunningTasksWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetRunningTasksRequest $request
     * @param GetRunningTasksHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetRunningTasksResponse
     */
    public function getRunningTasksWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->processInstanceId)) {
            @$query['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->appType)) {
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetRunningTasksResponse::fromMap($this->doROARequest('GetRunningTasks', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/processes/tasks/getRunningTasks', 'json', $req, $runtime));
    }

    /**
     * @param ListNavigationByFormTypeRequest $request
     *
     * @return ListNavigationByFormTypeResponse
     */
    public function listNavigationByFormType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListNavigationByFormTypeHeaders([]);

        return $this->listNavigationByFormTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListNavigationByFormTypeRequest $request
     * @param ListNavigationByFormTypeHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return ListNavigationByFormTypeResponse
     */
    public function listNavigationByFormTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->formType)) {
            @$query['formType'] = $request->formType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListNavigationByFormTypeResponse::fromMap($this->doROARequest('ListNavigationByFormType', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/navigations', 'json', $req, $runtime));
    }

    /**
     * @param TerminateInstanceRequest $request
     *
     * @return TerminateInstanceResponse
     */
    public function terminateInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TerminateInstanceHeaders([]);

        return $this->terminateInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param TerminateInstanceRequest $request
     * @param TerminateInstanceHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return TerminateInstanceResponse
     */
    public function terminateInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            @$query['processInstanceId'] = $request->processInstanceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return TerminateInstanceResponse::fromMap($this->doROARequest('TerminateInstance', 'yida_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/yida/processes/instances/terminate', 'none', $req, $runtime));
    }

    /**
     * @param ExpireCommodityRequest $request
     *
     * @return ExpireCommodityResponse
     */
    public function expireCommodity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExpireCommodityHeaders([]);

        return $this->expireCommodityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ExpireCommodityRequest $request
     * @param ExpireCommodityHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ExpireCommodityResponse
     */
    public function expireCommodityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->instanceId)) {
            @$query['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ExpireCommodityResponse::fromMap($this->doROARequest('ExpireCommodity', 'yida_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/yida/appAuth/commodities/expire', 'json', $req, $runtime));
    }

    /**
     * @param ValidateOrderBuyRequest $request
     *
     * @return ValidateOrderBuyResponse
     */
    public function validateOrderBuy($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateOrderBuyHeaders([]);

        return $this->validateOrderBuyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ValidateOrderBuyRequest $request
     * @param ValidateOrderBuyHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ValidateOrderBuyResponse
     */
    public function validateOrderBuyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ValidateOrderBuyResponse::fromMap($this->doROARequest('ValidateOrderBuy', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/orderBuy/validate', 'json', $req, $runtime));
    }

    /**
     * @param SaveFormDataRequest $request
     *
     * @return SaveFormDataResponse
     */
    public function saveFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveFormDataHeaders([]);

        return $this->saveFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SaveFormDataRequest $request
     * @param SaveFormDataHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return SaveFormDataResponse
     */
    public function saveFormDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            @$body['formDataJson'] = $request->formDataJson;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SaveFormDataResponse::fromMap($this->doROARequest('SaveFormData', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/instances', 'json', $req, $runtime));
    }

    /**
     * @param DeleteFormDataRequest $request
     *
     * @return DeleteFormDataResponse
     */
    public function deleteFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteFormDataHeaders([]);

        return $this->deleteFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteFormDataRequest $request
     * @param DeleteFormDataHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return DeleteFormDataResponse
     */
    public function deleteFormDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->formInstanceId)) {
            @$query['formInstanceId'] = $request->formInstanceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteFormDataResponse::fromMap($this->doROARequest('DeleteFormData', 'yida_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/yida/forms/instances', 'none', $req, $runtime));
    }

    /**
     * @param UpdateInstanceRequest $request
     *
     * @return UpdateInstanceResponse
     */
    public function updateInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInstanceHeaders([]);

        return $this->updateInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateInstanceRequest $request
     * @param UpdateInstanceHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return UpdateInstanceResponse
     */
    public function updateInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->processInstanceId)) {
            @$body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->appType)) {
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->updateFormDataJson)) {
            @$body['updateFormDataJson'] = $request->updateFormDataJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateInstanceResponse::fromMap($this->doROARequest('UpdateInstance', 'yida_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/yida/processes/instances', 'none', $req, $runtime));
    }

    /**
     * @param ListCommodityRequest $request
     *
     * @return ListCommodityResponse
     */
    public function listCommodity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListCommodityHeaders([]);

        return $this->listCommodityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListCommodityRequest $request
     * @param ListCommodityHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return ListCommodityResponse
     */
    public function listCommodityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->currentPage)) {
            @$query['currentPage'] = $request->currentPage;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListCommodityResponse::fromMap($this->doROARequest('ListCommodity', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/appAuth/commodities', 'json', $req, $runtime));
    }

    /**
     * @param GetApplicationAuthorizationServicePlatformResourceRequest $request
     *
     * @return GetApplicationAuthorizationServicePlatformResourceResponse
     */
    public function getApplicationAuthorizationServicePlatformResource($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetApplicationAuthorizationServicePlatformResourceHeaders([]);

        return $this->getApplicationAuthorizationServicePlatformResourceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetApplicationAuthorizationServicePlatformResourceRequest $request
     * @param GetApplicationAuthorizationServicePlatformResourceHeaders $headers
     * @param RuntimeOptions                                            $runtime
     *
     * @return GetApplicationAuthorizationServicePlatformResourceResponse
     */
    public function getApplicationAuthorizationServicePlatformResourceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->instanceId)) {
            @$query['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetApplicationAuthorizationServicePlatformResourceResponse::fromMap($this->doROARequest('GetApplicationAuthorizationServicePlatformResource', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/authorization/platformResources', 'json', $req, $runtime));
    }

    /**
     * @param GetActivityListRequest $request
     *
     * @return GetActivityListResponse
     */
    public function getActivityList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetActivityListHeaders([]);

        return $this->getActivityListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetActivityListRequest $request
     * @param GetActivityListHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetActivityListResponse
     */
    public function getActivityListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->processCode)) {
            @$query['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->appType)) {
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetActivityListResponse::fromMap($this->doROARequest('GetActivityList', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/processes/activities', 'json', $req, $runtime));
    }

    /**
     * @param string                 $id
     * @param GetFormDataByIDRequest $request
     *
     * @return GetFormDataByIDResponse
     */
    public function getFormDataByID($id, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFormDataByIDHeaders([]);

        return $this->getFormDataByIDWithOptions($id, $request, $headers, $runtime);
    }

    /**
     * @param string                 $id
     * @param GetFormDataByIDRequest $request
     * @param GetFormDataByIDHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetFormDataByIDResponse
     */
    public function getFormDataByIDWithOptions($id, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $id    = OpenApiUtilClient::getEncodeParam($id);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetFormDataByIDResponse::fromMap($this->doROARequest('GetFormDataByID', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/forms/instances/' . $id . '', 'json', $req, $runtime));
    }

    /**
     * @param ExecuteCustomApiRequest $request
     *
     * @return ExecuteCustomApiResponse
     */
    public function executeCustomApi($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecuteCustomApiHeaders([]);

        return $this->executeCustomApiWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ExecuteCustomApiRequest $request
     * @param ExecuteCustomApiHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ExecuteCustomApiResponse
     */
    public function executeCustomApiWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->data)) {
            @$query['data'] = $request->data;
        }
        if (!Utils::isUnset($request->appType)) {
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->serviceId)) {
            @$query['serviceId'] = $request->serviceId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ExecuteCustomApiResponse::fromMap($this->doROARequest('ExecuteCustomApi', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/apps/customApi/execute', 'json', $req, $runtime));
    }

    /**
     * @param RefundCommodityRequest $request
     *
     * @return RefundCommodityResponse
     */
    public function refundCommodity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RefundCommodityHeaders([]);

        return $this->refundCommodityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RefundCommodityRequest $request
     * @param RefundCommodityHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return RefundCommodityResponse
     */
    public function refundCommodityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->instanceId)) {
            @$query['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return RefundCommodityResponse::fromMap($this->doROARequest('RefundCommodity', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/appAuth/commodities/refund', 'json', $req, $runtime));
    }

    /**
     * @param DeleteSequenceRequest $request
     *
     * @return DeleteSequenceResponse
     */
    public function deleteSequence($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSequenceHeaders([]);

        return $this->deleteSequenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteSequenceRequest $request
     * @param DeleteSequenceHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return DeleteSequenceResponse
     */
    public function deleteSequenceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->sequence)) {
            @$query['sequence'] = $request->sequence;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->appType)) {
            @$query['appType'] = $request->appType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteSequenceResponse::fromMap($this->doROARequest('DeleteSequence', 'yida_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/yida/forms/deleteSequence', 'none', $req, $runtime));
    }

    /**
     * @param ReleaseCommodityRequest $request
     *
     * @return ReleaseCommodityResponse
     */
    public function releaseCommodity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReleaseCommodityHeaders([]);

        return $this->releaseCommodityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReleaseCommodityRequest $request
     * @param ReleaseCommodityHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ReleaseCommodityResponse
     */
    public function releaseCommodityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->instanceId)) {
            @$query['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ReleaseCommodityResponse::fromMap($this->doROARequest('ReleaseCommodity', 'yida_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/yida/appAuth/commodities/release', 'json', $req, $runtime));
    }

    /**
     * @param LoginCodeGenRequest $request
     *
     * @return LoginCodeGenResponse
     */
    public function loginCodeGen($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LoginCodeGenHeaders([]);

        return $this->loginCodeGenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param LoginCodeGenRequest $request
     * @param LoginCodeGenHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return LoginCodeGenResponse
     */
    public function loginCodeGenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return LoginCodeGenResponse::fromMap($this->doROARequest('LoginCodeGen', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/authorizations/loginCodes', 'json', $req, $runtime));
    }

    /**
     * @param GetSaleUserInfoByUserIdRequest $request
     *
     * @return GetSaleUserInfoByUserIdResponse
     */
    public function getSaleUserInfoByUserId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSaleUserInfoByUserIdHeaders([]);

        return $this->getSaleUserInfoByUserIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSaleUserInfoByUserIdRequest $request
     * @param GetSaleUserInfoByUserIdHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return GetSaleUserInfoByUserIdResponse
     */
    public function getSaleUserInfoByUserIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            @$query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->namespace_)) {
            @$query['namespace_'] = $request->namespace_;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetSaleUserInfoByUserIdResponse::fromMap($this->doROARequest('GetSaleUserInfoByUserId', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/saleUserInfo', 'json', $req, $runtime));
    }

    /**
     * @param ExecuteTaskRequest $request
     *
     * @return ExecuteTaskResponse
     */
    public function executeTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecuteTaskHeaders([]);

        return $this->executeTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ExecuteTaskRequest $request
     * @param ExecuteTaskHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return ExecuteTaskResponse
     */
    public function executeTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->outResult)) {
            @$body['outResult'] = $request->outResult;
        }
        if (!Utils::isUnset($request->noExecuteExpressions)) {
            @$body['noExecuteExpressions'] = $request->noExecuteExpressions;
        }
        if (!Utils::isUnset($request->appType)) {
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            @$body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            @$body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->taskId)) {
            @$body['taskId'] = $request->taskId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ExecuteTaskResponse::fromMap($this->doROARequest('ExecuteTask', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/tasks/execute', 'none', $req, $runtime));
    }

    /**
     * @param StartInstanceRequest $request
     *
     * @return StartInstanceResponse
     */
    public function startInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartInstanceHeaders([]);

        return $this->startInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param StartInstanceRequest $request
     * @param StartInstanceHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return StartInstanceResponse
     */
    public function startInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            @$body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->processCode)) {
            @$body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->departmentId)) {
            @$body['departmentId'] = $request->departmentId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return StartInstanceResponse::fromMap($this->doROARequest('StartInstance', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/processes/instances/start', 'json', $req, $runtime));
    }

    /**
     * @param DeleteInstanceRequest $request
     *
     * @return DeleteInstanceResponse
     */
    public function deleteInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteInstanceHeaders([]);

        return $this->deleteInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteInstanceRequest $request
     * @param DeleteInstanceHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return DeleteInstanceResponse
     */
    public function deleteInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            @$query['processInstanceId'] = $request->processInstanceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteInstanceResponse::fromMap($this->doROARequest('DeleteInstance', 'yida_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/yida/processes/instances', 'none', $req, $runtime));
    }
}
