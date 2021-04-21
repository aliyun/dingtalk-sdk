<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryCollectingTraceTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryCollectingTraceTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryCollectingTraceTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryCollectingTraceTaskShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryPageTraceDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryPageTraceDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryPageTraceDataResponse;
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
     * @param QueryCollectingTraceTaskRequest $request
     *
     * @return QueryCollectingTraceTaskResponse
     */
    public function queryCollectingTraceTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCollectingTraceTaskHeaders([]);

        return $this->queryCollectingTraceTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCollectingTraceTaskRequest $tmpReq
     * @param QueryCollectingTraceTaskHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return QueryCollectingTraceTaskResponse
     */
    public function queryCollectingTraceTaskWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new QueryCollectingTraceTaskShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->staffIds)) {
            $request->staffIdsShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->staffIds, 'staffIds', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->staffIdsShrink)) {
            @$query['staffIds'] = $request->staffIdsShrink;
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

        return QueryCollectingTraceTaskResponse::fromMap($this->doROARequest('QueryCollectingTraceTask', 'trajectory_1.0', 'HTTP', 'GET', 'AK', '/v1.0/trajectory/currentTasks', 'json', $req, $runtime));
    }

    /**
     * @param QueryPageTraceDataRequest $request
     *
     * @return QueryPageTraceDataResponse
     */
    public function queryPageTraceData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPageTraceDataHeaders([]);

        return $this->queryPageTraceDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryPageTraceDataRequest $request
     * @param QueryPageTraceDataHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryPageTraceDataResponse
     */
    public function queryPageTraceDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->traceId)) {
            @$query['traceId'] = $request->traceId;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->staffId)) {
            @$query['staffId'] = $request->staffId;
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

        return QueryPageTraceDataResponse::fromMap($this->doROARequest('QueryPageTraceData', 'trajectory_1.0', 'HTTP', 'GET', 'AK', '/v1.0/trajectory/data', 'json', $req, $runtime));
    }
}
