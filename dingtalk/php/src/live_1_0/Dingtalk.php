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
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\CreateLiveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\CreateLiveRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\CreateLiveResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\DeleteLiveFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\DeleteLiveFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\DeleteLiveFeedResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\DeleteLiveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\DeleteLiveRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\DeleteLiveResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\EditFeedReplayHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\EditFeedReplayRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\EditFeedReplayResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserAllLiveListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserAllLiveListRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserAllLiveListResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserCreateLiveListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserCreateLiveListRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserCreateLiveListResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserWatchLiveListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserWatchLiveListRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserWatchLiveListResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\ModifyFeedWhiteListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\ModifyFeedWhiteListRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\ModifyFeedWhiteListResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\ModifyFeedWhiteListShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryFeedWhiteListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryFeedWhiteListRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryFeedWhiteListResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveWatchDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveWatchDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveWatchDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveWatchUserListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveWatchUserListRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveWatchUserListResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QuerySubscribeStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QuerySubscribeStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QuerySubscribeStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QuerySubscribeStatusShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StartCloudFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StartCloudFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StartCloudFeedResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StopCloudFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StopCloudFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\StopCloudFeedResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\SubscribeLiveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\SubscribeLiveRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\SubscribeLiveResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\UpdateLiveFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\UpdateLiveFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\UpdateLiveFeedResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\UpdateLiveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\UpdateLiveRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\UpdateLiveResponse;
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
     * @param CreateLiveRequest $request
     *
     * @return CreateLiveResponse
     */
    public function createLive($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateLiveHeaders([]);

        return $this->createLiveWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateLiveRequest $request
     * @param CreateLiveHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return CreateLiveResponse
     */
    public function createLiveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coverUrl)) {
            @$body['coverUrl'] = $request->coverUrl;
        }
        if (!Utils::isUnset($request->introduction)) {
            @$body['introduction'] = $request->introduction;
        }
        if (!Utils::isUnset($request->preEndTime)) {
            @$body['preEndTime'] = $request->preEndTime;
        }
        if (!Utils::isUnset($request->preStartTime)) {
            @$body['preStartTime'] = $request->preStartTime;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return CreateLiveResponse::fromMap($this->doROARequest('CreateLive', 'live_1.0', 'HTTP', 'POST', 'AK', '/v1.0/live/lives', 'json', $req, $runtime));
    }

    /**
     * @param DeleteLiveRequest $request
     *
     * @return DeleteLiveResponse
     */
    public function deleteLive($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteLiveHeaders([]);

        return $this->deleteLiveWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteLiveRequest $request
     * @param DeleteLiveHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return DeleteLiveResponse
     */
    public function deleteLiveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            @$query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return DeleteLiveResponse::fromMap($this->doROARequest('DeleteLive', 'live_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/live/lives', 'json', $req, $runtime));
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
     * @param GetUserAllLiveListRequest $request
     *
     * @return GetUserAllLiveListResponse
     */
    public function getUserAllLiveList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserAllLiveListHeaders([]);

        return $this->getUserAllLiveListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetUserAllLiveListRequest $request
     * @param GetUserAllLiveListHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetUserAllLiveListResponse
     */
    public function getUserAllLiveListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->statuses)) {
            @$body['statuses'] = $request->statuses;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
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

        return GetUserAllLiveListResponse::fromMap($this->doROARequest('GetUserAllLiveList', 'live_1.0', 'HTTP', 'POST', 'AK', '/v1.0/live/users/allLiveInfos/query', 'json', $req, $runtime));
    }

    /**
     * @param GetUserCreateLiveListRequest $request
     *
     * @return GetUserCreateLiveListResponse
     */
    public function getUserCreateLiveList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserCreateLiveListHeaders([]);

        return $this->getUserCreateLiveListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetUserCreateLiveListRequest $request
     * @param GetUserCreateLiveListHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GetUserCreateLiveListResponse
     */
    public function getUserCreateLiveListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->statuses)) {
            @$body['statuses'] = $request->statuses;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
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

        return GetUserCreateLiveListResponse::fromMap($this->doROARequest('GetUserCreateLiveList', 'live_1.0', 'HTTP', 'POST', 'AK', '/v1.0/live/users/createLiveInfos/query', 'json', $req, $runtime));
    }

    /**
     * @param GetUserWatchLiveListRequest $request
     *
     * @return GetUserWatchLiveListResponse
     */
    public function getUserWatchLiveList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserWatchLiveListHeaders([]);

        return $this->getUserWatchLiveListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetUserWatchLiveListRequest $request
     * @param GetUserWatchLiveListHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetUserWatchLiveListResponse
     */
    public function getUserWatchLiveListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->filterType)) {
            @$query['filterType'] = $request->filterType;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return GetUserWatchLiveListResponse::fromMap($this->doROARequest('GetUserWatchLiveList', 'live_1.0', 'HTTP', 'GET', 'AK', '/v1.0/live/users/watchRecords', 'json', $req, $runtime));
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
     * @param QueryLiveInfoRequest $request
     *
     * @return QueryLiveInfoResponse
     */
    public function queryLiveInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryLiveInfoHeaders([]);

        return $this->queryLiveInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryLiveInfoRequest $request
     * @param QueryLiveInfoHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return QueryLiveInfoResponse
     */
    public function queryLiveInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            @$query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return QueryLiveInfoResponse::fromMap($this->doROARequest('QueryLiveInfo', 'live_1.0', 'HTTP', 'GET', 'AK', '/v1.0/live/lives', 'json', $req, $runtime));
    }

    /**
     * @param QueryLiveWatchDetailRequest $request
     *
     * @return QueryLiveWatchDetailResponse
     */
    public function queryLiveWatchDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryLiveWatchDetailHeaders([]);

        return $this->queryLiveWatchDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryLiveWatchDetailRequest $request
     * @param QueryLiveWatchDetailHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryLiveWatchDetailResponse
     */
    public function queryLiveWatchDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            @$query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return QueryLiveWatchDetailResponse::fromMap($this->doROARequest('QueryLiveWatchDetail', 'live_1.0', 'HTTP', 'GET', 'AK', '/v1.0/live/lives/watchDetails', 'json', $req, $runtime));
    }

    /**
     * @param QueryLiveWatchUserListRequest $request
     *
     * @return QueryLiveWatchUserListResponse
     */
    public function queryLiveWatchUserList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryLiveWatchUserListHeaders([]);

        return $this->queryLiveWatchUserListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryLiveWatchUserListRequest $request
     * @param QueryLiveWatchUserListHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return QueryLiveWatchUserListResponse
     */
    public function queryLiveWatchUserListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            @$query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return QueryLiveWatchUserListResponse::fromMap($this->doROARequest('QueryLiveWatchUserList', 'live_1.0', 'HTTP', 'GET', 'AK', '/v1.0/live/lives/watchUsers', 'json', $req, $runtime));
    }

    /**
     * @param QuerySubscribeStatusRequest $request
     *
     * @return QuerySubscribeStatusResponse
     */
    public function querySubscribeStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySubscribeStatusHeaders([]);

        return $this->querySubscribeStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QuerySubscribeStatusRequest $tmpReq
     * @param QuerySubscribeStatusHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QuerySubscribeStatusResponse
     */
    public function querySubscribeStatusWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new QuerySubscribeStatusShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->body)) {
            $request->bodyShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->body, 'body', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->bodyShrink)) {
            @$query['body'] = $request->bodyShrink;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return QuerySubscribeStatusResponse::fromMap($this->doROARequest('QuerySubscribeStatus', 'live_1.0', 'HTTP', 'POST', 'AK', '/v1.0/live/subscribeStatuses/query', 'json', $req, $runtime));
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
     * @param SubscribeLiveRequest $request
     *
     * @return SubscribeLiveResponse
     */
    public function subscribeLive($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SubscribeLiveHeaders([]);

        return $this->subscribeLiveWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SubscribeLiveRequest $request
     * @param SubscribeLiveHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return SubscribeLiveResponse
     */
    public function subscribeLiveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            @$query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->subscribe)) {
            @$query['subscribe'] = $request->subscribe;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return SubscribeLiveResponse::fromMap($this->doROARequest('SubscribeLive', 'live_1.0', 'HTTP', 'POST', 'AK', '/v1.0/live/lives/subscribe', 'json', $req, $runtime));
    }

    /**
     * @param UpdateLiveRequest $request
     *
     * @return UpdateLiveResponse
     */
    public function updateLive($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateLiveHeaders([]);

        return $this->updateLiveWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateLiveRequest $request
     * @param UpdateLiveHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return UpdateLiveResponse
     */
    public function updateLiveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coverUrl)) {
            @$body['coverUrl'] = $request->coverUrl;
        }
        if (!Utils::isUnset($request->introduction)) {
            @$body['introduction'] = $request->introduction;
        }
        if (!Utils::isUnset($request->liveId)) {
            @$body['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->preEndTime)) {
            @$body['preEndTime'] = $request->preEndTime;
        }
        if (!Utils::isUnset($request->preStartTime)) {
            @$body['preStartTime'] = $request->preStartTime;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return UpdateLiveResponse::fromMap($this->doROARequest('UpdateLive', 'live_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/live/lives', 'json', $req, $runtime));
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
