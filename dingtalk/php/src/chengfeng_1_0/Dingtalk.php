<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetAnalyzeDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetAnalyzeDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetAnalyzeDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetEmployeeInfoByWorkNoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetEmployeeInfoByWorkNoRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetEmployeeInfoByWorkNoResponse;
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
