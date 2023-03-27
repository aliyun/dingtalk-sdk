<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetAllJobLevelHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetAllJobLevelResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetAllJobPositionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetAllJobPositionResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetAllJobPostHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetAllJobPostResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetAnalyzeDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetAnalyzeDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetAnalyzeDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetChildOrgListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetChildOrgListRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetChildOrgListResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetEmployeeInfoByWorkNoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetEmployeeInfoByWorkNoRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetEmployeeInfoByWorkNoResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetEmploymentRecordByWorkNoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetEmploymentRecordByWorkNoResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetJobPositionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetJobPositionRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetJobPositionResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetJobPostHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetJobPostRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetJobPostResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetOrgInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetOrgInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetOrgInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetStaffInfoByWorkNoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetStaffInfoByWorkNoRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetStaffInfoByWorkNoResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetStaffPageQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetStaffPageQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetStaffPageQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\ListAnalyzePeriodsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\ListAnalyzePeriodsResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\ListObjectiveByIdsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\ListObjectiveByIdsRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\ListObjectiveByIdsResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\ListObjectiveByUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\ListObjectiveByUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\ListObjectiveByUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\ListProgressByIdsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\ListProgressByIdsRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\ListProgressByIdsResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\PageListObjectiveProgressHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\PageListObjectiveProgressRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\PageListObjectiveProgressResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\TransferUserObjectiveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\TransferUserObjectiveRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\TransferUserObjectiveResponse;
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
     * @return GetAllJobLevelResponse
     */
    public function getAllJobLevel()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllJobLevelHeaders([]);

        return $this->getAllJobLevelWithOptions($headers, $runtime);
    }

    /**
     * @param GetAllJobLevelHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetAllJobLevelResponse
     */
    public function getAllJobLevelWithOptions($headers, $runtime)
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

        return GetAllJobLevelResponse::fromMap($this->doROARequest('GetAllJobLevel', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/chengfeng/jobLevels', 'json', $req, $runtime));
    }

    /**
     * @return GetAllJobPositionResponse
     */
    public function getAllJobPosition()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllJobPositionHeaders([]);

        return $this->getAllJobPositionWithOptions($headers, $runtime);
    }

    /**
     * @param GetAllJobPositionHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetAllJobPositionResponse
     */
    public function getAllJobPositionWithOptions($headers, $runtime)
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

        return GetAllJobPositionResponse::fromMap($this->doROARequest('GetAllJobPosition', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/chengfeng/jobPositions', 'json', $req, $runtime));
    }

    /**
     * @return GetAllJobPostResponse
     */
    public function getAllJobPost()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllJobPostHeaders([]);

        return $this->getAllJobPostWithOptions($headers, $runtime);
    }

    /**
     * @param GetAllJobPostHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetAllJobPostResponse
     */
    public function getAllJobPostWithOptions($headers, $runtime)
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

        return GetAllJobPostResponse::fromMap($this->doROARequest('GetAllJobPost', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/chengfeng/jobPosts', 'json', $req, $runtime));
    }

    /**
     * @param GetAnalyzeDataRequest $request
     *
     * @return GetAnalyzeDataResponse
     */
    public function getAnalyzeData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAnalyzeDataHeaders([]);

        return $this->getAnalyzeDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetAnalyzeDataRequest $request
     * @param GetAnalyzeDataHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetAnalyzeDataResponse
     */
    public function getAnalyzeDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            @$query['deptId'] = $request->deptId;
        }
        $body = [];
        if (!Utils::isUnset($request->periodIds)) {
            @$body['periodIds'] = $request->periodIds;
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

        return GetAnalyzeDataResponse::fromMap($this->doROARequest('GetAnalyzeData', 'chengfeng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/chengfeng/okr/analyses/datas/query', 'json', $req, $runtime));
    }

    /**
     * @param GetChildOrgListRequest $request
     *
     * @return GetChildOrgListResponse
     */
    public function getChildOrgList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetChildOrgListHeaders([]);

        return $this->getChildOrgListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetChildOrgListRequest $request
     * @param GetChildOrgListHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetChildOrgListResponse
     */
    public function getChildOrgListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptCode)) {
            @$query['deptCode'] = $request->deptCode;
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

        return GetChildOrgListResponse::fromMap($this->doROARequest('GetChildOrgList', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/chengfeng/organizations', 'json', $req, $runtime));
    }

    /**
     * @param GetEmployeeInfoByWorkNoRequest $request
     *
     * @return GetEmployeeInfoByWorkNoResponse
     */
    public function getEmployeeInfoByWorkNo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetEmployeeInfoByWorkNoHeaders([]);

        return $this->getEmployeeInfoByWorkNoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetEmployeeInfoByWorkNoRequest $request
     * @param GetEmployeeInfoByWorkNoHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return GetEmployeeInfoByWorkNoResponse
     */
    public function getEmployeeInfoByWorkNoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->workNo)) {
            @$query['workNo'] = $request->workNo;
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

        return GetEmployeeInfoByWorkNoResponse::fromMap($this->doROARequest('GetEmployeeInfoByWorkNo', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/chengfeng/workNumbers/employees', 'json', $req, $runtime));
    }

    /**
     * @param string $workNumbers
     *
     * @return GetEmploymentRecordByWorkNoResponse
     */
    public function getEmploymentRecordByWorkNo($workNumbers)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetEmploymentRecordByWorkNoHeaders([]);

        return $this->getEmploymentRecordByWorkNoWithOptions($workNumbers, $headers, $runtime);
    }

    /**
     * @param string                             $workNumbers
     * @param GetEmploymentRecordByWorkNoHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return GetEmploymentRecordByWorkNoResponse
     */
    public function getEmploymentRecordByWorkNoWithOptions($workNumbers, $headers, $runtime)
    {
        $workNumbers = OpenApiUtilClient::getEncodeParam($workNumbers);
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

        return GetEmploymentRecordByWorkNoResponse::fromMap($this->doROARequest('GetEmploymentRecordByWorkNo', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/chengfeng/users/workNumber/' . $workNumbers . 'employmentRecords', 'json', $req, $runtime));
    }

    /**
     * @param GetJobPositionRequest $request
     *
     * @return GetJobPositionResponse
     */
    public function getJobPosition($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetJobPositionHeaders([]);

        return $this->getJobPositionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetJobPositionRequest $request
     * @param GetJobPositionHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetJobPositionResponse
     */
    public function getJobPositionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->jobPositionCode)) {
            @$query['jobPositionCode'] = $request->jobPositionCode;
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

        return GetJobPositionResponse::fromMap($this->doROARequest('GetJobPosition', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/chengfeng/jobPositions/infos', 'json', $req, $runtime));
    }

    /**
     * @param GetJobPostRequest $request
     *
     * @return GetJobPostResponse
     */
    public function getJobPost($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetJobPostHeaders([]);

        return $this->getJobPostWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetJobPostRequest $request
     * @param GetJobPostHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return GetJobPostResponse
     */
    public function getJobPostWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->jobPostCode)) {
            @$query['jobPostCode'] = $request->jobPostCode;
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

        return GetJobPostResponse::fromMap($this->doROARequest('GetJobPost', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/chengfeng/jobPosts/infos', 'json', $req, $runtime));
    }

    /**
     * @param GetOrgInfoRequest $request
     *
     * @return GetOrgInfoResponse
     */
    public function getOrgInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOrgInfoHeaders([]);

        return $this->getOrgInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetOrgInfoRequest $request
     * @param GetOrgInfoHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return GetOrgInfoResponse
     */
    public function getOrgInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptCode)) {
            @$query['deptCode'] = $request->deptCode;
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

        return GetOrgInfoResponse::fromMap($this->doROARequest('GetOrgInfo', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/chengfeng/organizations/infos', 'json', $req, $runtime));
    }

    /**
     * @param GetStaffInfoByWorkNoRequest $request
     *
     * @return GetStaffInfoByWorkNoResponse
     */
    public function getStaffInfoByWorkNo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetStaffInfoByWorkNoHeaders([]);

        return $this->getStaffInfoByWorkNoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetStaffInfoByWorkNoRequest $request
     * @param GetStaffInfoByWorkNoHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetStaffInfoByWorkNoResponse
     */
    public function getStaffInfoByWorkNoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->workNumbers)) {
            @$query['workNumbers'] = $request->workNumbers;
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

        return GetStaffInfoByWorkNoResponse::fromMap($this->doROARequest('GetStaffInfoByWorkNo', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/chengfeng/users', 'json', $req, $runtime));
    }

    /**
     * @param GetStaffPageQueryRequest $request
     *
     * @return GetStaffPageQueryResponse
     */
    public function getStaffPageQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetStaffPageQueryHeaders([]);

        return $this->getStaffPageQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetStaffPageQueryRequest $request
     * @param GetStaffPageQueryHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetStaffPageQueryResponse
     */
    public function getStaffPageQueryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptCode)) {
            @$query['deptCode'] = $request->deptCode;
        }
        if (!Utils::isUnset($request->name)) {
            @$query['name'] = $request->name;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->workNo)) {
            @$query['workNo'] = $request->workNo;
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

        return GetStaffPageQueryResponse::fromMap($this->doROARequest('GetStaffPageQuery', 'chengfeng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/chengfeng/users/query', 'json', $req, $runtime));
    }

    /**
     * @param GetUserRequest $request
     *
     * @return GetUserResponse
     */
    public function getUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserHeaders([]);

        return $this->getUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetUserRequest $request
     * @param GetUserHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return GetUserResponse
     */
    public function getUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->okrUserId)) {
            @$query['okrUserId'] = $request->okrUserId;
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

        return GetUserResponse::fromMap($this->doROARequest('GetUser', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/chengfeng/okr/users', 'json', $req, $runtime));
    }

    /**
     * @return ListAnalyzePeriodsResponse
     */
    public function listAnalyzePeriods()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAnalyzePeriodsHeaders([]);

        return $this->listAnalyzePeriodsWithOptions($headers, $runtime);
    }

    /**
     * @param ListAnalyzePeriodsHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return ListAnalyzePeriodsResponse
     */
    public function listAnalyzePeriodsWithOptions($headers, $runtime)
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

        return ListAnalyzePeriodsResponse::fromMap($this->doROARequest('ListAnalyzePeriods', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/chengfeng/okr/analyses/periods', 'json', $req, $runtime));
    }

    /**
     * @param ListObjectiveByIdsRequest $request
     *
     * @return ListObjectiveByIdsResponse
     */
    public function listObjectiveByIds($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListObjectiveByIdsHeaders([]);

        return $this->listObjectiveByIdsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListObjectiveByIdsRequest $request
     * @param ListObjectiveByIdsHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return ListObjectiveByIdsResponse
     */
    public function listObjectiveByIdsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->objectiveIds)) {
            @$body['objectiveIds'] = $request->objectiveIds;
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

        return ListObjectiveByIdsResponse::fromMap($this->doROARequest('ListObjectiveByIds', 'chengfeng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/chengfeng/okr/objectives/query', 'json', $req, $runtime));
    }

    /**
     * @param ListObjectiveByUserRequest $request
     *
     * @return ListObjectiveByUserResponse
     */
    public function listObjectiveByUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListObjectiveByUserHeaders([]);

        return $this->listObjectiveByUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListObjectiveByUserRequest $request
     * @param ListObjectiveByUserHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return ListObjectiveByUserResponse
     */
    public function listObjectiveByUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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

        return ListObjectiveByUserResponse::fromMap($this->doROARequest('ListObjectiveByUser', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/chengfeng/okr/users/objectives', 'json', $req, $runtime));
    }

    /**
     * @param ListProgressByIdsRequest $request
     *
     * @return ListProgressByIdsResponse
     */
    public function listProgressByIds($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListProgressByIdsHeaders([]);

        return $this->listProgressByIdsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListProgressByIdsRequest $request
     * @param ListProgressByIdsHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return ListProgressByIdsResponse
     */
    public function listProgressByIdsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->progressIds)) {
            @$body['progressIds'] = $request->progressIds;
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

        return ListProgressByIdsResponse::fromMap($this->doROARequest('ListProgressByIds', 'chengfeng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/chengfeng/okr/objectives/progresses/query', 'json', $req, $runtime));
    }

    /**
     * @param PageListObjectiveProgressRequest $request
     *
     * @return PageListObjectiveProgressResponse
     */
    public function pageListObjectiveProgress($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageListObjectiveProgressHeaders([]);

        return $this->pageListObjectiveProgressWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PageListObjectiveProgressRequest $request
     * @param PageListObjectiveProgressHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return PageListObjectiveProgressResponse
     */
    public function pageListObjectiveProgressWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->objectiveId)) {
            @$query['objectiveId'] = $request->objectiveId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
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

        return PageListObjectiveProgressResponse::fromMap($this->doROARequest('PageListObjectiveProgress', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/chengfeng/okr/objectives/progresses/records', 'json', $req, $runtime));
    }

    /**
     * @param TransferUserObjectiveRequest $request
     *
     * @return TransferUserObjectiveResponse
     */
    public function transferUserObjective($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TransferUserObjectiveHeaders([]);

        return $this->transferUserObjectiveWithOptions($request, $headers, $runtime);
    }

    /**
     * @param TransferUserObjectiveRequest $request
     * @param TransferUserObjectiveHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return TransferUserObjectiveResponse
     */
    public function transferUserObjectiveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->objectiveId)) {
            @$query['objectiveId'] = $request->objectiveId;
        }
        if (!Utils::isUnset($request->targetUserId)) {
            @$query['targetUserId'] = $request->targetUserId;
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

        return TransferUserObjectiveResponse::fromMap($this->doROARequest('TransferUserObjective', 'chengfeng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/chengfeng/okr/objectives/transfer', 'json', $req, $runtime));
    }
}
