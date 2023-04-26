<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryAppActiveUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryAppActiveUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryAppActiveUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryCollectingTraceTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryCollectingTraceTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryCollectingTraceTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryPageTraceDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryPageTraceDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models\QueryPageTraceDataResponse;
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
     * @param QueryAppActiveUsersRequest $request
     * @param QueryAppActiveUsersHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryAppActiveUsersResponse
     */
    public function queryAppActiveUsersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->needPositionInfo)) {
            $query['needPositionInfo'] = $request->needPositionInfo;
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
            'action'      => 'QueryAppActiveUsers',
            'version'     => 'trajectory_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/trajectory/activeUsers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryAppActiveUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryAppActiveUsersRequest $request
     *
     * @return QueryAppActiveUsersResponse
     */
    public function queryAppActiveUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAppActiveUsersHeaders([]);

        return $this->queryAppActiveUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCollectingTraceTaskRequest $request
     * @param QueryCollectingTraceTaskHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return QueryCollectingTraceTaskResponse
     */
    public function queryCollectingTraceTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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
            'action'      => 'QueryCollectingTraceTask',
            'version'     => 'trajectory_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/trajectory/currentTasks/queryByUserIds',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryCollectingTraceTaskResponse::fromMap($this->execute($params, $req, $runtime));
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
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->staffId)) {
            $query['staffId'] = $request->staffId;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->traceId)) {
            $query['traceId'] = $request->traceId;
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
            'action'      => 'QueryPageTraceData',
            'version'     => 'trajectory_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/trajectory/data',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryPageTraceDataResponse::fromMap($this->execute($params, $req, $runtime));
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
}
