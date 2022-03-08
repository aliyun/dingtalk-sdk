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
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\DeleteLiveFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\DeleteLiveFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\DeleteLiveFeedResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\EditFeedReplayHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\EditFeedReplayRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\EditFeedReplayResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\ModifyFeedWhiteListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\ModifyFeedWhiteListRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\ModifyFeedWhiteListResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\ModifyFeedWhiteListShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryFeedWhiteListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryFeedWhiteListRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryFeedWhiteListResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StartCloudFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StartCloudFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StartCloudFeedResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StopCloudFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StopCloudFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StopCloudFeedResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\UpdateLiveFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\UpdateLiveFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\UpdateLiveFeedResponse;
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
        $feedId = OpenApiUtilClient::getEncodeParam($feedId);
        $body   = [];
        if (!Utils::isUnset($request->groupIdType)) {
            @$body['groupIdType'] = $request->groupIdType;
        }
        if (!Utils::isUnset($request->groupIds)) {
            @$body['groupIds'] = $request->groupIds;
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

        return AddShareCidListResponse::fromMap($this->doROARequest('AddShareCidList', 'live_1.0', 'HTTP', 'POST', 'AK', '/v1.0/live/cloudFeeds/' . $feedId . '/share', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->coverUrl)) {
            @$body['coverUrl'] = $request->coverUrl;
        }
        if (!Utils::isUnset($request->intro)) {
            @$body['intro'] = $request->intro;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->videoUrl)) {
            @$body['videoUrl'] = $request->videoUrl;
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

        return CreateCloudFeedResponse::fromMap($this->doROARequest('CreateCloudFeed', 'live_1.0', 'HTTP', 'POST', 'AK', '/v1.0/live/cloudFeeds', 'json', $req, $runtime));
    }

    /**
     * @param string                $feedId
     * @param DeleteLiveFeedRequest $request
     *
     * @return DeleteLiveFeedResponse
     */
    public function deleteLiveFeed($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteLiveFeedHeaders([]);

        return $this->deleteLiveFeedWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @param string                $feedId
     * @param DeleteLiveFeedRequest $request
     * @param DeleteLiveFeedHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return DeleteLiveFeedResponse
     */
    public function deleteLiveFeedWithOptions($feedId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $feedId = OpenApiUtilClient::getEncodeParam($feedId);
        $query  = [];
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

        return DeleteLiveFeedResponse::fromMap($this->doROARequest('DeleteLiveFeed', 'live_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/live/openFeeds/' . $feedId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                $feedId
     * @param EditFeedReplayRequest $request
     *
     * @return EditFeedReplayResponse
     */
    public function editFeedReplay($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditFeedReplayHeaders([]);

        return $this->editFeedReplayWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @param string                $feedId
     * @param EditFeedReplayRequest $request
     * @param EditFeedReplayHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return EditFeedReplayResponse
     */
    public function editFeedReplayWithOptions($feedId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $feedId = OpenApiUtilClient::getEncodeParam($feedId);
        $body   = [];
        if (!Utils::isUnset($request->editEndTime)) {
            @$body['editEndTime'] = $request->editEndTime;
        }
        if (!Utils::isUnset($request->editStartTime)) {
            @$body['editStartTime'] = $request->editStartTime;
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

        return EditFeedReplayResponse::fromMap($this->doROARequest('EditFeedReplay', 'live_1.0', 'HTTP', 'POST', 'AK', '/v1.0/live/openFeeds/' . $feedId . '/cutReplay', 'json', $req, $runtime));
    }

    /**
     * @param string                     $feedId
     * @param ModifyFeedWhiteListRequest $request
     *
     * @return ModifyFeedWhiteListResponse
     */
    public function modifyFeedWhiteList($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ModifyFeedWhiteListHeaders([]);

        return $this->modifyFeedWhiteListWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $feedId
     * @param ModifyFeedWhiteListRequest $tmpReq
     * @param ModifyFeedWhiteListHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return ModifyFeedWhiteListResponse
     */
    public function modifyFeedWhiteListWithOptions($feedId, $tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $feedId  = OpenApiUtilClient::getEncodeParam($feedId);
        $request = new ModifyFeedWhiteListShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->modifyUserList)) {
            $request->modifyUserListShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->modifyUserList, 'modifyUserList', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->action)) {
            @$query['action'] = $request->action;
        }
        if (!Utils::isUnset($request->modifyUserListShrink)) {
            @$query['modifyUserList'] = $request->modifyUserListShrink;
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

        return ModifyFeedWhiteListResponse::fromMap($this->doROARequest('ModifyFeedWhiteList', 'live_1.0', 'HTTP', 'POST', 'AK', '/v1.0/live/openFeeds/' . $feedId . '/whiteList', 'json', $req, $runtime));
    }

    /**
     * @param string                    $feedId
     * @param QueryFeedWhiteListRequest $request
     *
     * @return QueryFeedWhiteListResponse
     */
    public function queryFeedWhiteList($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryFeedWhiteListHeaders([]);

        return $this->queryFeedWhiteListWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @param string                    $feedId
     * @param QueryFeedWhiteListRequest $request
     * @param QueryFeedWhiteListHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryFeedWhiteListResponse
     */
    public function queryFeedWhiteListWithOptions($feedId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $feedId = OpenApiUtilClient::getEncodeParam($feedId);
        $query  = [];
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

        return QueryFeedWhiteListResponse::fromMap($this->doROARequest('QueryFeedWhiteList', 'live_1.0', 'HTTP', 'GET', 'AK', '/v1.0/live/openFeeds/' . $feedId . '/whiteList', 'json', $req, $runtime));
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
        $feedId = OpenApiUtilClient::getEncodeParam($feedId);
        $body   = [];
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
        $feedId = OpenApiUtilClient::getEncodeParam($feedId);
        $body   = [];
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

        return StopCloudFeedResponse::fromMap($this->doROARequest('StopCloudFeed', 'live_1.0', 'HTTP', 'POST', 'AK', '/v1.0/live/cloudFeeds/' . $feedId . '/stop', 'json', $req, $runtime));
    }

    /**
     * @param string                $feedId
     * @param UpdateLiveFeedRequest $request
     *
     * @return UpdateLiveFeedResponse
     */
    public function updateLiveFeed($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateLiveFeedHeaders([]);

        return $this->updateLiveFeedWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @param string                $feedId
     * @param UpdateLiveFeedRequest $request
     * @param UpdateLiveFeedHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return UpdateLiveFeedResponse
     */
    public function updateLiveFeedWithOptions($feedId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $feedId = OpenApiUtilClient::getEncodeParam($feedId);
        $query  = [];
        if (!Utils::isUnset($request->coverUrl)) {
            @$query['coverUrl'] = $request->coverUrl;
        }
        if (!Utils::isUnset($request->introduction)) {
            @$query['introduction'] = $request->introduction;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->title)) {
            @$query['title'] = $request->title;
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

        return UpdateLiveFeedResponse::fromMap($this->doROARequest('UpdateLiveFeed', 'live_1.0', 'HTTP', 'POST', 'AK', '/v1.0/live/openFeeds/' . $feedId . '', 'json', $req, $runtime));
    }
}
