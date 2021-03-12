<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\AddShareCidListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\AddShareCidListRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\AddShareCidListResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\CreateCloudFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\CreateCloudFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\CreateCloudFeedResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StartCloudFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StartCloudFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StartCloudFeedResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StopCloudFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StopCloudFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StopCloudFeedResponse;
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
     * @param string                $feedId
     * @param StartCloudFeedRequest $request
     *
     * @return StartCloudFeedResponse
     */
    public function startCloudFeed($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartCloudFeedHeaders([]);

        return $this->startCloudFeedWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @param string                $feedId
     * @param StartCloudFeedRequest $request
     * @param StartCloudFeedHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return StartCloudFeedResponse
     */
    public function startCloudFeedWithOptions($feedId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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

        return StartCloudFeedResponse::fromMap($this->doROARequest('StartCloudFeed', 'live_1.0', 'HTTP', 'POST', 'AK', '/v1.0/live/cloudFeeds/' . $feedId . '/start', 'json', $req, $runtime));
    }

    /**
     * @param string               $feedId
     * @param StopCloudFeedRequest $request
     *
     * @return StopCloudFeedResponse
     */
    public function stopCloudFeed($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StopCloudFeedHeaders([]);

        return $this->stopCloudFeedWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @param string               $feedId
     * @param StopCloudFeedRequest $request
     * @param StopCloudFeedHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return StopCloudFeedResponse
     */
    public function stopCloudFeedWithOptions($feedId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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

        return StopCloudFeedResponse::fromMap($this->doROARequest('StopCloudFeed', 'live_1.0', 'HTTP', 'POST', 'AK', '/v1.0/live/cloudFeeds/' . $feedId . '/stop', 'json', $req, $runtime));
    }

    /**
     * @param CreateCloudFeedRequest $request
     *
     * @return CreateCloudFeedResponse
     */
    public function createCloudFeed($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCloudFeedHeaders([]);

        return $this->createCloudFeedWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateCloudFeedRequest $request
     * @param CreateCloudFeedHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return CreateCloudFeedResponse
     */
    public function createCloudFeedWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->intro)) {
            @$body['intro'] = $request->intro;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->coverUrl)) {
            @$body['coverUrl'] = $request->coverUrl;
        }
        if (!Utils::isUnset($request->videoUrl)) {
            @$body['videoUrl'] = $request->videoUrl;
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

        return CreateCloudFeedResponse::fromMap($this->doROARequest('CreateCloudFeed', 'live_1.0', 'HTTP', 'POST', 'AK', '/v1.0/live/cloudFeeds', 'json', $req, $runtime));
    }

    /**
     * @param string                 $feedId
     * @param AddShareCidListRequest $request
     *
     * @return AddShareCidListResponse
     */
    public function addShareCidList($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddShareCidListHeaders([]);

        return $this->addShareCidListWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $feedId
     * @param AddShareCidListRequest $request
     * @param AddShareCidListHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return AddShareCidListResponse
     */
    public function addShareCidListWithOptions($feedId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->groupIds)) {
            @$body['groupIds'] = $request->groupIds;
        }
        if (!Utils::isUnset($request->groupIdType)) {
            @$body['groupIdType'] = $request->groupIdType;
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

        return AddShareCidListResponse::fromMap($this->doROARequest('AddShareCidList', 'live_1.0', 'HTTP', 'POST', 'AK', '/v1.0/live/cloudFeeds/' . $feedId . '/share', 'json', $req, $runtime));
    }
}
