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
}
