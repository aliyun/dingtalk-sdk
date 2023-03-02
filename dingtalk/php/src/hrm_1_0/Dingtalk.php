<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AddHrmPreentryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AddHrmPreentryRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AddHrmPreentryResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\ECertQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\ECertQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\ECertQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmProcessRegularHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmProcessRegularRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmProcessRegularResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmProcessTransferHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmProcessTransferRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmProcessTransferResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmProcessUpdateTerminationInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmProcessUpdateTerminationInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmProcessUpdateTerminationInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataSaveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataSaveRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataSaveResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataTenantQueyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataTenantQueyRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataTenantQueyResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryCustomEntryProcessesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryCustomEntryProcessesRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryCustomEntryProcessesResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryDismissionStaffIdListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryDismissionStaffIdListRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryDismissionStaffIdListResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryHrmEmployeeDismissionInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryHrmEmployeeDismissionInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryHrmEmployeeDismissionInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryHrmEmployeeDismissionInfoShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryJobRanksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryJobRanksRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryJobRanksResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryJobsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryJobsRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryJobsResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryPositionsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryPositionsRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryPositionsResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\RosterMetaAvailableFieldListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\RosterMetaAvailableFieldListRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\RosterMetaAvailableFieldListResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\RosterMetaFieldOptionsUpdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\RosterMetaFieldOptionsUpdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\RosterMetaFieldOptionsUpdateResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\SolutionTaskInitHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\SolutionTaskInitRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\SolutionTaskInitResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\SolutionTaskSaveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\SolutionTaskSaveRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\SolutionTaskSaveResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\SyncTaskTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\SyncTaskTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\SyncTaskTemplateResponse;
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
     * @param AddHrmPreentryRequest $request
     *
     * @return AddHrmPreentryResponse
     */
    public function addHrmPreentry($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddHrmPreentryHeaders([]);

        return $this->addHrmPreentryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddHrmPreentryRequest $request
     * @param AddHrmPreentryHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return AddHrmPreentryResponse
     */
    public function addHrmPreentryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->agentId)) {
            @$body['agentId'] = $request->agentId;
        }
        if (!Utils::isUnset($request->groups)) {
            @$body['groups'] = $request->groups;
        }
        if (!Utils::isUnset($request->mobile)) {
            @$body['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->preEntryTime)) {
            @$body['preEntryTime'] = $request->preEntryTime;
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

        return AddHrmPreentryResponse::fromMap($this->doROARequest('AddHrmPreentry', 'hrm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/hrm/preentries', 'json', $req, $runtime));
    }

    /**
     * @param ECertQueryRequest $request
     *
     * @return ECertQueryResponse
     */
    public function eCertQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ECertQueryHeaders([]);

        return $this->eCertQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ECertQueryRequest $request
     * @param ECertQueryHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return ECertQueryResponse
     */
    public function eCertQueryWithOptions($request, $headers, $runtime)
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
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ECertQueryResponse::fromMap($this->doROARequest('ECertQuery', 'hrm_1.0', 'HTTP', 'GET', 'AK', '/v1.0/hrm/eCerts', 'json', $req, $runtime));
    }

    /**
     * @param HrmProcessRegularRequest $request
     *
     * @return HrmProcessRegularResponse
     */
    public function hrmProcessRegular($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrmProcessRegularHeaders([]);

        return $this->hrmProcessRegularWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrmProcessRegularRequest $request
     * @param HrmProcessRegularHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return HrmProcessRegularResponse
     */
    public function hrmProcessRegularWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operationId)) {
            @$body['operationId'] = $request->operationId;
        }
        if (!Utils::isUnset($request->regularDate)) {
            @$body['regularDate'] = $request->regularDate;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
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

        return HrmProcessRegularResponse::fromMap($this->doROARequest('HrmProcessRegular', 'hrm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/hrm/processes/regulars/become', 'json', $req, $runtime));
    }

    /**
     * @param HrmProcessTransferRequest $request
     *
     * @return HrmProcessTransferResponse
     */
    public function hrmProcessTransfer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrmProcessTransferHeaders([]);

        return $this->hrmProcessTransferWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrmProcessTransferRequest $request
     * @param HrmProcessTransferHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return HrmProcessTransferResponse
     */
    public function hrmProcessTransferWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptIdsAfterTransfer)) {
            @$body['deptIdsAfterTransfer'] = $request->deptIdsAfterTransfer;
        }
        if (!Utils::isUnset($request->jobIdAfterTransfer)) {
            @$body['jobIdAfterTransfer'] = $request->jobIdAfterTransfer;
        }
        if (!Utils::isUnset($request->mainDeptIdAfterTransfer)) {
            @$body['mainDeptIdAfterTransfer'] = $request->mainDeptIdAfterTransfer;
        }
        if (!Utils::isUnset($request->operateUserId)) {
            @$body['operateUserId'] = $request->operateUserId;
        }
        if (!Utils::isUnset($request->positionIdAfterTransfer)) {
            @$body['positionIdAfterTransfer'] = $request->positionIdAfterTransfer;
        }
        if (!Utils::isUnset($request->positionLevelAfterTransfer)) {
            @$body['positionLevelAfterTransfer'] = $request->positionLevelAfterTransfer;
        }
        if (!Utils::isUnset($request->positionNameAfterTransfer)) {
            @$body['positionNameAfterTransfer'] = $request->positionNameAfterTransfer;
        }
        if (!Utils::isUnset($request->rankIdAfterTransfer)) {
            @$body['rankIdAfterTransfer'] = $request->rankIdAfterTransfer;
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

        return HrmProcessTransferResponse::fromMap($this->doROARequest('HrmProcessTransfer', 'hrm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/hrm/processes/transfer', 'json', $req, $runtime));
    }

    /**
     * @param HrmProcessUpdateTerminationInfoRequest $request
     *
     * @return HrmProcessUpdateTerminationInfoResponse
     */
    public function hrmProcessUpdateTerminationInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrmProcessUpdateTerminationInfoHeaders([]);

        return $this->hrmProcessUpdateTerminationInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrmProcessUpdateTerminationInfoRequest $request
     * @param HrmProcessUpdateTerminationInfoHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return HrmProcessUpdateTerminationInfoResponse
     */
    public function hrmProcessUpdateTerminationInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dismissionMemo)) {
            @$body['dismissionMemo'] = $request->dismissionMemo;
        }
        if (!Utils::isUnset($request->lastWorkDate)) {
            @$body['lastWorkDate'] = $request->lastWorkDate;
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

        return HrmProcessUpdateTerminationInfoResponse::fromMap($this->doROARequest('HrmProcessUpdateTerminationInfo', 'hrm_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/hrm/processes/employees/terminations', 'json', $req, $runtime));
    }

    /**
     * @param MasterDataQueryRequest $request
     *
     * @return MasterDataQueryResponse
     */
    public function masterDataQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MasterDataQueryHeaders([]);

        return $this->masterDataQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param MasterDataQueryRequest $request
     * @param MasterDataQueryHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return MasterDataQueryResponse
     */
    public function masterDataQueryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizUK)) {
            @$body['bizUK'] = $request->bizUK;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->optUserId)) {
            @$body['optUserId'] = $request->optUserId;
        }
        if (!Utils::isUnset($request->queryParams)) {
            @$body['queryParams'] = $request->queryParams;
        }
        if (!Utils::isUnset($request->relationIds)) {
            @$body['relationIds'] = $request->relationIds;
        }
        if (!Utils::isUnset($request->scopeCode)) {
            @$body['scopeCode'] = $request->scopeCode;
        }
        if (!Utils::isUnset($request->tenantId)) {
            @$body['tenantId'] = $request->tenantId;
        }
        if (!Utils::isUnset($request->viewEntityCode)) {
            @$body['viewEntityCode'] = $request->viewEntityCode;
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

        return MasterDataQueryResponse::fromMap($this->doROARequest('MasterDataQuery', 'hrm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/hrm/masters/datas/query', 'json', $req, $runtime));
    }

    /**
     * @param MasterDataSaveRequest $request
     *
     * @return MasterDataSaveResponse
     */
    public function masterDataSave($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MasterDataSaveHeaders([]);

        return $this->masterDataSaveWithOptions($request, $headers, $runtime);
    }

    /**
     * @param MasterDataSaveRequest $request
     * @param MasterDataSaveHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return MasterDataSaveResponse
     */
    public function masterDataSaveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->tenantId)) {
            @$query['tenantId'] = $request->tenantId;
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
            'body'    => Utils::toArray($request->body),
        ]);

        return MasterDataSaveResponse::fromMap($this->doROARequest('MasterDataSave', 'hrm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/hrm/masters/datas/save', 'json', $req, $runtime));
    }

    /**
     * @param MasterDataTenantQueyRequest $request
     *
     * @return MasterDataTenantQueyResponse
     */
    public function masterDataTenantQuey($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MasterDataTenantQueyHeaders([]);

        return $this->masterDataTenantQueyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param MasterDataTenantQueyRequest $request
     * @param MasterDataTenantQueyHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return MasterDataTenantQueyResponse
     */
    public function masterDataTenantQueyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->entityCode)) {
            @$query['entityCode'] = $request->entityCode;
        }
        if (!Utils::isUnset($request->scopeCode)) {
            @$query['scopeCode'] = $request->scopeCode;
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

        return MasterDataTenantQueyResponse::fromMap($this->doROARequest('MasterDataTenantQuey', 'hrm_1.0', 'HTTP', 'GET', 'AK', '/v1.0/hrm/masters/tenants', 'json', $req, $runtime));
    }

    /**
     * @param QueryCustomEntryProcessesRequest $request
     *
     * @return QueryCustomEntryProcessesResponse
     */
    public function queryCustomEntryProcesses($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCustomEntryProcessesHeaders([]);

        return $this->queryCustomEntryProcessesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCustomEntryProcessesRequest $request
     * @param QueryCustomEntryProcessesHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryCustomEntryProcessesResponse
     */
    public function queryCustomEntryProcessesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operateUserId)) {
            @$query['operateUserId'] = $request->operateUserId;
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

        return QueryCustomEntryProcessesResponse::fromMap($this->doROARequest('QueryCustomEntryProcesses', 'hrm_1.0', 'HTTP', 'GET', 'AK', '/v1.0/hrm/customEntryProcesses', 'json', $req, $runtime));
    }

    /**
     * @param QueryDismissionStaffIdListRequest $request
     *
     * @return QueryDismissionStaffIdListResponse
     */
    public function queryDismissionStaffIdList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDismissionStaffIdListHeaders([]);

        return $this->queryDismissionStaffIdListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDismissionStaffIdListRequest $request
     * @param QueryDismissionStaffIdListHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return QueryDismissionStaffIdListResponse
     */
    public function queryDismissionStaffIdListWithOptions($request, $headers, $runtime)
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
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryDismissionStaffIdListResponse::fromMap($this->doROARequest('QueryDismissionStaffIdList', 'hrm_1.0', 'HTTP', 'GET', 'AK', '/v1.0/hrm/employees/dismissions', 'json', $req, $runtime));
    }

    /**
     * @param QueryHrmEmployeeDismissionInfoRequest $request
     *
     * @return QueryHrmEmployeeDismissionInfoResponse
     */
    public function queryHrmEmployeeDismissionInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHrmEmployeeDismissionInfoHeaders([]);

        return $this->queryHrmEmployeeDismissionInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryHrmEmployeeDismissionInfoRequest $tmpReq
     * @param QueryHrmEmployeeDismissionInfoHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryHrmEmployeeDismissionInfoResponse
     */
    public function queryHrmEmployeeDismissionInfoWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new QueryHrmEmployeeDismissionInfoShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->userIdList)) {
            $request->userIdListShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->userIdList, 'userIdList', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->userIdListShrink)) {
            @$query['userIdList'] = $request->userIdListShrink;
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

        return QueryHrmEmployeeDismissionInfoResponse::fromMap($this->doROARequest('QueryHrmEmployeeDismissionInfo', 'hrm_1.0', 'HTTP', 'GET', 'AK', '/v1.0/hrm/employees/dimissionInfos', 'json', $req, $runtime));
    }

    /**
     * @param QueryJobRanksRequest $request
     *
     * @return QueryJobRanksResponse
     */
    public function queryJobRanks($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryJobRanksHeaders([]);

        return $this->queryJobRanksWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryJobRanksRequest $request
     * @param QueryJobRanksHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return QueryJobRanksResponse
     */
    public function queryJobRanksWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->rankCategoryId)) {
            @$query['rankCategoryId'] = $request->rankCategoryId;
        }
        if (!Utils::isUnset($request->rankCode)) {
            @$query['rankCode'] = $request->rankCode;
        }
        if (!Utils::isUnset($request->rankName)) {
            @$query['rankName'] = $request->rankName;
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

        return QueryJobRanksResponse::fromMap($this->doROARequest('QueryJobRanks', 'hrm_1.0', 'HTTP', 'GET', 'AK', '/v1.0/hrm/jobRanks', 'json', $req, $runtime));
    }

    /**
     * @param QueryJobsRequest $request
     *
     * @return QueryJobsResponse
     */
    public function queryJobs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryJobsHeaders([]);

        return $this->queryJobsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryJobsRequest $request
     * @param QueryJobsHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return QueryJobsResponse
     */
    public function queryJobsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->jobName)) {
            @$query['jobName'] = $request->jobName;
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

        return QueryJobsResponse::fromMap($this->doROARequest('QueryJobs', 'hrm_1.0', 'HTTP', 'GET', 'AK', '/v1.0/hrm/jobs', 'json', $req, $runtime));
    }

    /**
     * @param QueryPositionsRequest $request
     *
     * @return QueryPositionsResponse
     */
    public function queryPositions($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPositionsHeaders([]);

        return $this->queryPositionsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryPositionsRequest $request
     * @param QueryPositionsHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryPositionsResponse
     */
    public function queryPositionsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        $body = [];
        if (!Utils::isUnset($request->deptId)) {
            @$body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->inCategoryIds)) {
            @$body['inCategoryIds'] = $request->inCategoryIds;
        }
        if (!Utils::isUnset($request->inPositionIds)) {
            @$body['inPositionIds'] = $request->inPositionIds;
        }
        if (!Utils::isUnset($request->positionName)) {
            @$body['positionName'] = $request->positionName;
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

        return QueryPositionsResponse::fromMap($this->doROARequest('QueryPositions', 'hrm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/hrm/positions/query', 'json', $req, $runtime));
    }

    /**
     * @param RosterMetaAvailableFieldListRequest $request
     *
     * @return RosterMetaAvailableFieldListResponse
     */
    public function rosterMetaAvailableFieldList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RosterMetaAvailableFieldListHeaders([]);

        return $this->rosterMetaAvailableFieldListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RosterMetaAvailableFieldListRequest $request
     * @param RosterMetaAvailableFieldListHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return RosterMetaAvailableFieldListResponse
     */
    public function rosterMetaAvailableFieldListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appAgentId)) {
            @$query['appAgentId'] = $request->appAgentId;
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

        return RosterMetaAvailableFieldListResponse::fromMap($this->doROARequest('RosterMetaAvailableFieldList', 'hrm_1.0', 'HTTP', 'GET', 'AK', '/v1.0/hrm/rosters/meta/authorities/fields', 'json', $req, $runtime));
    }

    /**
     * @param RosterMetaFieldOptionsUpdateRequest $request
     *
     * @return RosterMetaFieldOptionsUpdateResponse
     */
    public function rosterMetaFieldOptionsUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RosterMetaFieldOptionsUpdateHeaders([]);

        return $this->rosterMetaFieldOptionsUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RosterMetaFieldOptionsUpdateRequest $request
     * @param RosterMetaFieldOptionsUpdateHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return RosterMetaFieldOptionsUpdateResponse
     */
    public function rosterMetaFieldOptionsUpdateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appAgentId)) {
            @$query['appAgentId'] = $request->appAgentId;
        }
        $body = [];
        if (!Utils::isUnset($request->fieldCode)) {
            @$body['fieldCode'] = $request->fieldCode;
        }
        if (!Utils::isUnset($request->groupId)) {
            @$body['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->labels)) {
            @$body['labels'] = $request->labels;
        }
        if (!Utils::isUnset($request->modifyType)) {
            @$body['modifyType'] = $request->modifyType;
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

        return RosterMetaFieldOptionsUpdateResponse::fromMap($this->doROARequest('RosterMetaFieldOptionsUpdate', 'hrm_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/hrm/rosters/meta/fields/options', 'json', $req, $runtime));
    }

    /**
     * @param SolutionTaskInitRequest $request
     *
     * @return SolutionTaskInitResponse
     */
    public function solutionTaskInit($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SolutionTaskInitHeaders([]);

        return $this->solutionTaskInitWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SolutionTaskInitRequest $request
     * @param SolutionTaskInitHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return SolutionTaskInitResponse
     */
    public function solutionTaskInitWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->solutionType)) {
            @$query['solutionType'] = $request->solutionType;
        }
        $body = [];
        if (!Utils::isUnset($request->category)) {
            @$body['category'] = $request->category;
        }
        if (!Utils::isUnset($request->claimTime)) {
            @$body['claimTime'] = $request->claimTime;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->finishTime)) {
            @$body['finishTime'] = $request->finishTime;
        }
        if (!Utils::isUnset($request->outerId)) {
            @$body['outerId'] = $request->outerId;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
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
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SolutionTaskInitResponse::fromMap($this->doROARequest('SolutionTaskInit', 'hrm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/hrm/solutions/tasks/init', 'json', $req, $runtime));
    }

    /**
     * @param SolutionTaskSaveRequest $request
     *
     * @return SolutionTaskSaveResponse
     */
    public function solutionTaskSave($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SolutionTaskSaveHeaders([]);

        return $this->solutionTaskSaveWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SolutionTaskSaveRequest $request
     * @param SolutionTaskSaveHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return SolutionTaskSaveResponse
     */
    public function solutionTaskSaveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->solutionType)) {
            @$query['solutionType'] = $request->solutionType;
        }
        $body = [];
        if (!Utils::isUnset($request->claimTime)) {
            @$body['claimTime'] = $request->claimTime;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->finishTime)) {
            @$body['finishTime'] = $request->finishTime;
        }
        if (!Utils::isUnset($request->outerId)) {
            @$body['outerId'] = $request->outerId;
        }
        if (!Utils::isUnset($request->solutionInstanceId)) {
            @$body['solutionInstanceId'] = $request->solutionInstanceId;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->taskType)) {
            @$body['taskType'] = $request->taskType;
        }
        if (!Utils::isUnset($request->templateOuterId)) {
            @$body['templateOuterId'] = $request->templateOuterId;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
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
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SolutionTaskSaveResponse::fromMap($this->doROARequest('SolutionTaskSave', 'hrm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/hrm/solutions/tasks/save', 'json', $req, $runtime));
    }

    /**
     * @param SyncTaskTemplateRequest $request
     *
     * @return SyncTaskTemplateResponse
     */
    public function syncTaskTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncTaskTemplateHeaders([]);

        return $this->syncTaskTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncTaskTemplateRequest $request
     * @param SyncTaskTemplateHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return SyncTaskTemplateResponse
     */
    public function syncTaskTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->solutionType)) {
            @$query['solutionType'] = $request->solutionType;
        }
        $body = [];
        if (!Utils::isUnset($request->delete)) {
            @$body['delete'] = $request->delete;
        }
        if (!Utils::isUnset($request->des)) {
            @$body['des'] = $request->des;
        }
        if (!Utils::isUnset($request->ext)) {
            @$body['ext'] = $request->ext;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->optUserId)) {
            @$body['optUserId'] = $request->optUserId;
        }
        if (!Utils::isUnset($request->outerId)) {
            @$body['outerId'] = $request->outerId;
        }
        if (!Utils::isUnset($request->taskScopeVO)) {
            @$body['taskScopeVO'] = $request->taskScopeVO;
        }
        if (!Utils::isUnset($request->taskType)) {
            @$body['taskType'] = $request->taskType;
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

        return SyncTaskTemplateResponse::fromMap($this->doROARequest('SyncTaskTemplate', 'hrm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/hrm/solutions/tasks/templates/sync', 'json', $req, $runtime));
    }
}
