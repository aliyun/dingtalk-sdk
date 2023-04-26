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
use Darabonba\GatewayDingTalk\Client as DarabonbaGatewayDingTalkClient;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    protected $_client;

    public function __construct($config)
    {
        parent::__construct($config);
        $this->_client       = new DarabonbaGatewayDingTalkClient();
        $this->_spi          = $this->_client;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
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
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetAllJobLevel',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/jobLevels',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAllJobLevelResponse::fromMap($this->execute($params, $req, $runtime));
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
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetAllJobPosition',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/jobPositions',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAllJobPositionResponse::fromMap($this->execute($params, $req, $runtime));
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
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetAllJobPost',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/jobPosts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAllJobPostResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['deptId'] = $request->deptId;
        }
        $body = [];
        if (!Utils::isUnset($request->periodIds)) {
            $body['periodIds'] = $request->periodIds;
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
            'action'      => 'GetAnalyzeData',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/okr/analyses/datas/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAnalyzeDataResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['deptCode'] = $request->deptCode;
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
            'action'      => 'GetChildOrgList',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/organizations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetChildOrgListResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['workNo'] = $request->workNo;
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
            'action'      => 'GetEmployeeInfoByWorkNo',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/workNumbers/employees',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetEmployeeInfoByWorkNoResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param string                             $workNumbers
     * @param GetEmploymentRecordByWorkNoHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return GetEmploymentRecordByWorkNoResponse
     */
    public function getEmploymentRecordByWorkNoWithOptions($workNumbers, $headers, $runtime)
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
            'action'      => 'GetEmploymentRecordByWorkNo',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/users/workNumber/' . $workNumbers . 'employmentRecords',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetEmploymentRecordByWorkNoResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['jobPositionCode'] = $request->jobPositionCode;
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
            'action'      => 'GetJobPosition',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/jobPositions/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetJobPositionResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['jobPostCode'] = $request->jobPostCode;
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
            'action'      => 'GetJobPost',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/jobPosts/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetJobPostResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['deptCode'] = $request->deptCode;
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
            'action'      => 'GetOrgInfo',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/organizations/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOrgInfoResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['workNumbers'] = $request->workNumbers;
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
            'action'      => 'GetStaffInfoByWorkNo',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/users',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetStaffInfoByWorkNoResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['deptCode'] = $request->deptCode;
        }
        if (!Utils::isUnset($request->name)) {
            $query['name'] = $request->name;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->workNo)) {
            $query['workNo'] = $request->workNo;
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
            'action'      => 'GetStaffPageQuery',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/users/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetStaffPageQueryResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['okrUserId'] = $request->okrUserId;
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
            'action'      => 'GetUser',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/okr/users',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserResponse::fromMap($this->execute($params, $req, $runtime));
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
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'ListAnalyzePeriods',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/okr/analyses/periods',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListAnalyzePeriodsResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['objectiveIds'] = $request->objectiveIds;
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
            'action'      => 'ListObjectiveByIds',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/okr/objectives/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListObjectiveByIdsResponse::fromMap($this->execute($params, $req, $runtime));
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
            'action'      => 'ListObjectiveByUser',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/okr/users/objectives',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListObjectiveByUserResponse::fromMap($this->execute($params, $req, $runtime));
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
            $body['progressIds'] = $request->progressIds;
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
            'action'      => 'ListProgressByIds',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/okr/objectives/progresses/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListProgressByIdsResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['objectiveId'] = $request->objectiveId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action'      => 'PageListObjectiveProgress',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/okr/objectives/progresses/records',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PageListObjectiveProgressResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['objectiveId'] = $request->objectiveId;
        }
        if (!Utils::isUnset($request->targetUserId)) {
            $query['targetUserId'] = $request->targetUserId;
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
            'action'      => 'TransferUserObjective',
            'version'     => 'chengfeng_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/chengfeng/okr/objectives/transfer',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return TransferUserObjectiveResponse::fromMap($this->execute($params, $req, $runtime));
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
}
