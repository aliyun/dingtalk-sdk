<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\AddLiveInteractionPluginHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\AddLiveInteractionPluginRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\AddLiveInteractionPluginResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\AddLiveNoticeWidgetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\AddLiveNoticeWidgetRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\AddLiveNoticeWidgetResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\DelLiveInteractionPluginHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\DelLiveInteractionPluginRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\DelLiveInteractionPluginResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\DelLiveNoticeWidgetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\DelLiveNoticeWidgetRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\DelLiveNoticeWidgetResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\EditFeedReplayHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\EditFeedReplayRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\EditFeedReplayResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetGroupLiveListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetGroupLiveListRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetGroupLiveListResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetGroupLiveListShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetLiveReplayUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetLiveReplayUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetLiveReplayUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetOrgLiveListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetOrgLiveListRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetOrgLiveListResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetOrgLiveListShrinkRequest;
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
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveInteractionPluginHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveInteractionPluginRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveInteractionPluginResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\SendLiveInteractionPluginEffectsMsgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\SendLiveInteractionPluginEffectsMsgRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\SendLiveInteractionPluginEffectsMsgResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\SendLivePluginUserActionMsgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\SendLivePluginUserActionMsgRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\SendLivePluginUserActionMsgResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\SendLivePluginUserActionMsgShrinkRequest;
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
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\UpdateLiveInteractionPluginHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\UpdateLiveInteractionPluginRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\UpdateLiveInteractionPluginResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\UpdateLiveRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\UpdateLiveResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 增加直播间互动插件
     *  *
     * @param AddLiveInteractionPluginRequest $request AddLiveInteractionPluginRequest
     * @param AddLiveInteractionPluginHeaders $headers AddLiveInteractionPluginHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return AddLiveInteractionPluginResponse AddLiveInteractionPluginResponse
     */
    public function addLiveInteractionPluginWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            $query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->anchorJumpUrl)) {
            $body['anchorJumpUrl'] = $request->anchorJumpUrl;
        }
        if (!Utils::isUnset($request->pluginIconUrl)) {
            $body['pluginIconUrl'] = $request->pluginIconUrl;
        }
        if (!Utils::isUnset($request->pluginName)) {
            $body['pluginName'] = $request->pluginName;
        }
        if (!Utils::isUnset($request->pluginNameEn)) {
            $body['pluginNameEn'] = $request->pluginNameEn;
        }
        if (!Utils::isUnset($request->viewerJumpUrl)) {
            $body['viewerJumpUrl'] = $request->viewerJumpUrl;
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
            'action'      => 'AddLiveInteractionPlugin',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/interactionPlugins',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddLiveInteractionPluginResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 增加直播间互动插件
     *  *
     * @param AddLiveInteractionPluginRequest $request AddLiveInteractionPluginRequest
     *
     * @return AddLiveInteractionPluginResponse AddLiveInteractionPluginResponse
     */
    public function addLiveInteractionPlugin($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddLiveInteractionPluginHeaders([]);

        return $this->addLiveInteractionPluginWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 增加直播间的公告槽位信息
     *  *
     * @param AddLiveNoticeWidgetRequest $request AddLiveNoticeWidgetRequest
     * @param AddLiveNoticeWidgetHeaders $headers AddLiveNoticeWidgetHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return AddLiveNoticeWidgetResponse AddLiveNoticeWidgetResponse
     */
    public function addLiveNoticeWidgetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->iconUrl)) {
            $query['iconUrl'] = $request->iconUrl;
        }
        if (!Utils::isUnset($request->jumpUrl)) {
            $query['jumpUrl'] = $request->jumpUrl;
        }
        if (!Utils::isUnset($request->liveId)) {
            $query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->noticeText)) {
            $query['noticeText'] = $request->noticeText;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'AddLiveNoticeWidget',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/noticeWidgets',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddLiveNoticeWidgetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 增加直播间的公告槽位信息
     *  *
     * @param AddLiveNoticeWidgetRequest $request AddLiveNoticeWidgetRequest
     *
     * @return AddLiveNoticeWidgetResponse AddLiveNoticeWidgetResponse
     */
    public function addLiveNoticeWidget($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddLiveNoticeWidgetHeaders([]);

        return $this->addLiveNoticeWidgetWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加云导播联播群列表
     *  *
     * @param string                 $feedId
     * @param AddShareCidListRequest $request AddShareCidListRequest
     * @param AddShareCidListHeaders $headers AddShareCidListHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return AddShareCidListResponse AddShareCidListResponse
     */
    public function addShareCidListWithOptions($feedId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupIdType)) {
            $body['groupIdType'] = $request->groupIdType;
        }
        if (!Utils::isUnset($request->groupIds)) {
            $body['groupIds'] = $request->groupIds;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action'      => 'AddShareCidList',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/cloudFeeds/' . $feedId . '/share',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return AddShareCidListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加云导播联播群列表
     *  *
     * @param string                 $feedId
     * @param AddShareCidListRequest $request AddShareCidListRequest
     *
     * @return AddShareCidListResponse AddShareCidListResponse
     */
    public function addShareCidList($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddShareCidListHeaders([]);

        return $this->addShareCidListWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建云导播课程
     *  *
     * @param CreateCloudFeedRequest $request CreateCloudFeedRequest
     * @param CreateCloudFeedHeaders $headers CreateCloudFeedHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateCloudFeedResponse CreateCloudFeedResponse
     */
    public function createCloudFeedWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coverUrl)) {
            $body['coverUrl'] = $request->coverUrl;
        }
        if (!Utils::isUnset($request->intro)) {
            $body['intro'] = $request->intro;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->videoUrl)) {
            $body['videoUrl'] = $request->videoUrl;
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
            'action'      => 'CreateCloudFeed',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/cloudFeeds',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateCloudFeedResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建云导播课程
     *  *
     * @param CreateCloudFeedRequest $request CreateCloudFeedRequest
     *
     * @return CreateCloudFeedResponse CreateCloudFeedResponse
     */
    public function createCloudFeed($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCloudFeedHeaders([]);

        return $this->createCloudFeedWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建直播
     *  *
     * @param CreateLiveRequest $request CreateLiveRequest
     * @param CreateLiveHeaders $headers CreateLiveHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateLiveResponse CreateLiveResponse
     */
    public function createLiveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coverUrl)) {
            $body['coverUrl'] = $request->coverUrl;
        }
        if (!Utils::isUnset($request->introduction)) {
            $body['introduction'] = $request->introduction;
        }
        if (!Utils::isUnset($request->preEndTime)) {
            $body['preEndTime'] = $request->preEndTime;
        }
        if (!Utils::isUnset($request->preStartTime)) {
            $body['preStartTime'] = $request->preStartTime;
        }
        if (!Utils::isUnset($request->publicType)) {
            $body['publicType'] = $request->publicType;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'CreateLive',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/lives',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateLiveResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建直播
     *  *
     * @param CreateLiveRequest $request CreateLiveRequest
     *
     * @return CreateLiveResponse CreateLiveResponse
     */
    public function createLive($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateLiveHeaders([]);

        return $this->createLiveWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除直播间内某一互动插件
     *  *
     * @param DelLiveInteractionPluginRequest $request DelLiveInteractionPluginRequest
     * @param DelLiveInteractionPluginHeaders $headers DelLiveInteractionPluginHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return DelLiveInteractionPluginResponse DelLiveInteractionPluginResponse
     */
    public function delLiveInteractionPluginWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            $query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->pluginId)) {
            $query['pluginId'] = $request->pluginId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'DelLiveInteractionPlugin',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/interactionPlugins',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DelLiveInteractionPluginResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除直播间内某一互动插件
     *  *
     * @param DelLiveInteractionPluginRequest $request DelLiveInteractionPluginRequest
     *
     * @return DelLiveInteractionPluginResponse DelLiveInteractionPluginResponse
     */
    public function delLiveInteractionPlugin($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DelLiveInteractionPluginHeaders([]);

        return $this->delLiveInteractionPluginWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除直播间的公告槽位信息
     *  *
     * @param DelLiveNoticeWidgetRequest $request DelLiveNoticeWidgetRequest
     * @param DelLiveNoticeWidgetHeaders $headers DelLiveNoticeWidgetHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return DelLiveNoticeWidgetResponse DelLiveNoticeWidgetResponse
     */
    public function delLiveNoticeWidgetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            $query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'DelLiveNoticeWidget',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/noticeWidgets',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DelLiveNoticeWidgetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除直播间的公告槽位信息
     *  *
     * @param DelLiveNoticeWidgetRequest $request DelLiveNoticeWidgetRequest
     *
     * @return DelLiveNoticeWidgetResponse DelLiveNoticeWidgetResponse
     */
    public function delLiveNoticeWidget($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DelLiveNoticeWidgetHeaders([]);

        return $this->delLiveNoticeWidgetWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除直播
     *  *
     * @param DeleteLiveRequest $request DeleteLiveRequest
     * @param DeleteLiveHeaders $headers DeleteLiveHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteLiveResponse DeleteLiveResponse
     */
    public function deleteLiveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            $query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'DeleteLive',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/lives',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteLiveResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除直播
     *  *
     * @param DeleteLiveRequest $request DeleteLiveRequest
     *
     * @return DeleteLiveResponse DeleteLiveResponse
     */
    public function deleteLive($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteLiveHeaders([]);

        return $this->deleteLiveWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除直播培训课程
     *  *
     * @param string                $feedId
     * @param DeleteLiveFeedRequest $request DeleteLiveFeedRequest
     * @param DeleteLiveFeedHeaders $headers DeleteLiveFeedHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteLiveFeedResponse DeleteLiveFeedResponse
     */
    public function deleteLiveFeedWithOptions($feedId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'action'      => 'DeleteLiveFeed',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/openFeeds/' . $feedId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeleteLiveFeedResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除直播培训课程
     *  *
     * @param string                $feedId
     * @param DeleteLiveFeedRequest $request DeleteLiveFeedRequest
     *
     * @return DeleteLiveFeedResponse DeleteLiveFeedResponse
     */
    public function deleteLiveFeed($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteLiveFeedHeaders([]);

        return $this->deleteLiveFeedWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @summary 剪辑直播课程的回放
     *  *
     * @param string                $feedId
     * @param EditFeedReplayRequest $request EditFeedReplayRequest
     * @param EditFeedReplayHeaders $headers EditFeedReplayHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return EditFeedReplayResponse EditFeedReplayResponse
     */
    public function editFeedReplayWithOptions($feedId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->editEndTime)) {
            $body['editEndTime'] = $request->editEndTime;
        }
        if (!Utils::isUnset($request->editStartTime)) {
            $body['editStartTime'] = $request->editStartTime;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action'      => 'EditFeedReplay',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/openFeeds/' . $feedId . '/cutReplay',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return EditFeedReplayResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 剪辑直播课程的回放
     *  *
     * @param string                $feedId
     * @param EditFeedReplayRequest $request EditFeedReplayRequest
     *
     * @return EditFeedReplayResponse EditFeedReplayResponse
     */
    public function editFeedReplay($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditFeedReplayHeaders([]);

        return $this->editFeedReplayWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取群内的直播列表
     *  *
     * @param GetGroupLiveListRequest $tmpReq  GetGroupLiveListRequest
     * @param GetGroupLiveListHeaders $headers GetGroupLiveListHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetGroupLiveListResponse GetGroupLiveListResponse
     */
    public function getGroupLiveListWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new GetGroupLiveListShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->requestBody)) {
            $request->requestBodyShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->requestBody, 'requestBody', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->requestBodyShrink)) {
            $query['requestBody'] = $request->requestBodyShrink;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'GetGroupLiveList',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/groupLives',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetGroupLiveListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取群内的直播列表
     *  *
     * @param GetGroupLiveListRequest $request GetGroupLiveListRequest
     *
     * @return GetGroupLiveListResponse GetGroupLiveListResponse
     */
    public function getGroupLiveList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetGroupLiveListHeaders([]);

        return $this->getGroupLiveListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取直播的可下载回放地址
     *  *
     * @param GetLiveReplayUrlRequest $request GetLiveReplayUrlRequest
     * @param GetLiveReplayUrlHeaders $headers GetLiveReplayUrlHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetLiveReplayUrlResponse GetLiveReplayUrlResponse
     */
    public function getLiveReplayUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            $query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'GetLiveReplayUrl',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/lives/replayUrls',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetLiveReplayUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取直播的可下载回放地址
     *  *
     * @param GetLiveReplayUrlRequest $request GetLiveReplayUrlRequest
     *
     * @return GetLiveReplayUrlResponse GetLiveReplayUrlResponse
     */
    public function getLiveReplayUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetLiveReplayUrlHeaders([]);

        return $this->getLiveReplayUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取某组织内的直播列表
     *  *
     * @param GetOrgLiveListRequest $tmpReq  GetOrgLiveListRequest
     * @param GetOrgLiveListHeaders $headers GetOrgLiveListHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOrgLiveListResponse GetOrgLiveListResponse
     */
    public function getOrgLiveListWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new GetOrgLiveListShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->requestBody)) {
            $request->requestBodyShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->requestBody, 'requestBody', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->requestBodyShrink)) {
            $query['requestBody'] = $request->requestBodyShrink;
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
            'action'      => 'GetOrgLiveList',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/organizations/liveLists/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOrgLiveListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取某组织内的直播列表
     *  *
     * @param GetOrgLiveListRequest $request GetOrgLiveListRequest
     *
     * @return GetOrgLiveListResponse GetOrgLiveListResponse
     */
    public function getOrgLiveList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOrgLiveListHeaders([]);

        return $this->getOrgLiveListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据状态拉我相关的直播
     *  *
     * @param GetUserAllLiveListRequest $request GetUserAllLiveListRequest
     * @param GetUserAllLiveListHeaders $headers GetUserAllLiveListHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserAllLiveListResponse GetUserAllLiveListResponse
     */
    public function getUserAllLiveListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->statuses)) {
            $body['statuses'] = $request->statuses;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
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
            'action'      => 'GetUserAllLiveList',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/users/allLiveInfos/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserAllLiveListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据状态拉我相关的直播
     *  *
     * @param GetUserAllLiveListRequest $request GetUserAllLiveListRequest
     *
     * @return GetUserAllLiveListResponse GetUserAllLiveListResponse
     */
    public function getUserAllLiveList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserAllLiveListHeaders([]);

        return $this->getUserAllLiveListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据状态获取用户创建的直播
     *  *
     * @param GetUserCreateLiveListRequest $request GetUserCreateLiveListRequest
     * @param GetUserCreateLiveListHeaders $headers GetUserCreateLiveListHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserCreateLiveListResponse GetUserCreateLiveListResponse
     */
    public function getUserCreateLiveListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->statuses)) {
            $body['statuses'] = $request->statuses;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
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
            'action'      => 'GetUserCreateLiveList',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/users/createLiveInfos/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserCreateLiveListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据状态获取用户创建的直播
     *  *
     * @param GetUserCreateLiveListRequest $request GetUserCreateLiveListRequest
     *
     * @return GetUserCreateLiveListResponse GetUserCreateLiveListResponse
     */
    public function getUserCreateLiveList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserCreateLiveListHeaders([]);

        return $this->getUserCreateLiveListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取用户观看直播记录
     *  *
     * @param GetUserWatchLiveListRequest $request GetUserWatchLiveListRequest
     * @param GetUserWatchLiveListHeaders $headers GetUserWatchLiveListHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserWatchLiveListResponse GetUserWatchLiveListResponse
     */
    public function getUserWatchLiveListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->filterType)) {
            $query['filterType'] = $request->filterType;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'GetUserWatchLiveList',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/users/watchRecords',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserWatchLiveListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户观看直播记录
     *  *
     * @param GetUserWatchLiveListRequest $request GetUserWatchLiveListRequest
     *
     * @return GetUserWatchLiveListResponse GetUserWatchLiveListResponse
     */
    public function getUserWatchLiveList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserWatchLiveListHeaders([]);

        return $this->getUserWatchLiveListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改直播课程可见白名单
     *  *
     * @param string                     $feedId
     * @param ModifyFeedWhiteListRequest $tmpReq  ModifyFeedWhiteListRequest
     * @param ModifyFeedWhiteListHeaders $headers ModifyFeedWhiteListHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return ModifyFeedWhiteListResponse ModifyFeedWhiteListResponse
     */
    public function modifyFeedWhiteListWithOptions($feedId, $tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new ModifyFeedWhiteListShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->modifyUserList)) {
            $request->modifyUserListShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->modifyUserList, 'modifyUserList', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->action)) {
            $query['action'] = $request->action;
        }
        if (!Utils::isUnset($request->modifyUserListShrink)) {
            $query['modifyUserList'] = $request->modifyUserListShrink;
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
            'action'      => 'ModifyFeedWhiteList',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/openFeeds/' . $feedId . '/whiteList',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ModifyFeedWhiteListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改直播课程可见白名单
     *  *
     * @param string                     $feedId
     * @param ModifyFeedWhiteListRequest $request ModifyFeedWhiteListRequest
     *
     * @return ModifyFeedWhiteListResponse ModifyFeedWhiteListResponse
     */
    public function modifyFeedWhiteList($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ModifyFeedWhiteListHeaders([]);

        return $this->modifyFeedWhiteListWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询直播课程的观看白名单
     *  *
     * @param string                    $feedId
     * @param QueryFeedWhiteListRequest $request QueryFeedWhiteListRequest
     * @param QueryFeedWhiteListHeaders $headers QueryFeedWhiteListHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryFeedWhiteListResponse QueryFeedWhiteListResponse
     */
    public function queryFeedWhiteListWithOptions($feedId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'action'      => 'QueryFeedWhiteList',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/openFeeds/' . $feedId . '/whiteList',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryFeedWhiteListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询直播课程的观看白名单
     *  *
     * @param string                    $feedId
     * @param QueryFeedWhiteListRequest $request QueryFeedWhiteListRequest
     *
     * @return QueryFeedWhiteListResponse QueryFeedWhiteListResponse
     */
    public function queryFeedWhiteList($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryFeedWhiteListHeaders([]);

        return $this->queryFeedWhiteListWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询直播详情
     *  *
     * @param QueryLiveInfoRequest $request QueryLiveInfoRequest
     * @param QueryLiveInfoHeaders $headers QueryLiveInfoHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryLiveInfoResponse QueryLiveInfoResponse
     */
    public function queryLiveInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            $query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'QueryLiveInfo',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/lives',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryLiveInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询直播详情
     *  *
     * @param QueryLiveInfoRequest $request QueryLiveInfoRequest
     *
     * @return QueryLiveInfoResponse QueryLiveInfoResponse
     */
    public function queryLiveInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryLiveInfoHeaders([]);

        return $this->queryLiveInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询直播间内某一互动插件的信息
     *  *
     * @param QueryLiveInteractionPluginRequest $request QueryLiveInteractionPluginRequest
     * @param QueryLiveInteractionPluginHeaders $headers QueryLiveInteractionPluginHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryLiveInteractionPluginResponse QueryLiveInteractionPluginResponse
     */
    public function queryLiveInteractionPluginWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            $query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->pluginId)) {
            $query['pluginId'] = $request->pluginId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'QueryLiveInteractionPlugin',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/interactionPlugins',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryLiveInteractionPluginResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询直播间内某一互动插件的信息
     *  *
     * @param QueryLiveInteractionPluginRequest $request QueryLiveInteractionPluginRequest
     *
     * @return QueryLiveInteractionPluginResponse QueryLiveInteractionPluginResponse
     */
    public function queryLiveInteractionPlugin($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryLiveInteractionPluginHeaders([]);

        return $this->queryLiveInteractionPluginWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取直播的观看数据
     *  *
     * @param QueryLiveWatchDetailRequest $request QueryLiveWatchDetailRequest
     * @param QueryLiveWatchDetailHeaders $headers QueryLiveWatchDetailHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryLiveWatchDetailResponse QueryLiveWatchDetailResponse
     */
    public function queryLiveWatchDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            $query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'QueryLiveWatchDetail',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/lives/watchDetails',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryLiveWatchDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取直播的观看数据
     *  *
     * @param QueryLiveWatchDetailRequest $request QueryLiveWatchDetailRequest
     *
     * @return QueryLiveWatchDetailResponse QueryLiveWatchDetailResponse
     */
    public function queryLiveWatchDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryLiveWatchDetailHeaders([]);

        return $this->queryLiveWatchDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取直播观看用户列表
     *  *
     * @param QueryLiveWatchUserListRequest $request QueryLiveWatchUserListRequest
     * @param QueryLiveWatchUserListHeaders $headers QueryLiveWatchUserListHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryLiveWatchUserListResponse QueryLiveWatchUserListResponse
     */
    public function queryLiveWatchUserListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            $query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'QueryLiveWatchUserList',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/lives/watchUsers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryLiveWatchUserListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取直播观看用户列表
     *  *
     * @param QueryLiveWatchUserListRequest $request QueryLiveWatchUserListRequest
     *
     * @return QueryLiveWatchUserListResponse QueryLiveWatchUserListResponse
     */
    public function queryLiveWatchUserList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryLiveWatchUserListHeaders([]);

        return $this->queryLiveWatchUserListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询直播是否订阅
     *  *
     * @param QuerySubscribeStatusRequest $tmpReq  QuerySubscribeStatusRequest
     * @param QuerySubscribeStatusHeaders $headers QuerySubscribeStatusHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QuerySubscribeStatusResponse QuerySubscribeStatusResponse
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
            $query['body'] = $request->bodyShrink;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'QuerySubscribeStatus',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/subscribeStatuses/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QuerySubscribeStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询直播是否订阅
     *  *
     * @param QuerySubscribeStatusRequest $request QuerySubscribeStatusRequest
     *
     * @return QuerySubscribeStatusResponse QuerySubscribeStatusResponse
     */
    public function querySubscribeStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySubscribeStatusHeaders([]);

        return $this->querySubscribeStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 用户推送互动插件特效消息到直播间
     *  *
     * @param SendLiveInteractionPluginEffectsMsgRequest $request SendLiveInteractionPluginEffectsMsgRequest
     * @param SendLiveInteractionPluginEffectsMsgHeaders $headers SendLiveInteractionPluginEffectsMsgHeaders
     * @param RuntimeOptions                             $runtime runtime options for this request RuntimeOptions
     *
     * @return SendLiveInteractionPluginEffectsMsgResponse SendLiveInteractionPluginEffectsMsgResponse
     */
    public function sendLiveInteractionPluginEffectsMsgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            $query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->pluginId)) {
            $query['pluginId'] = $request->pluginId;
        }
        $body = [];
        if (!Utils::isUnset($request->count)) {
            $body['count'] = $request->count;
        }
        if (!Utils::isUnset($request->lottieFileUrl)) {
            $body['lottieFileUrl'] = $request->lottieFileUrl;
        }
        if (!Utils::isUnset($request->msgIconUrl)) {
            $body['msgIconUrl'] = $request->msgIconUrl;
        }
        if (!Utils::isUnset($request->msgText)) {
            $body['msgText'] = $request->msgText;
        }
        if (!Utils::isUnset($request->pluginSubId)) {
            $body['pluginSubId'] = $request->pluginSubId;
        }
        if (!Utils::isUnset($request->senderUnionId)) {
            $body['senderUnionId'] = $request->senderUnionId;
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
            'action'      => 'SendLiveInteractionPluginEffectsMsg',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/interactionPlugins/effectMessages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendLiveInteractionPluginEffectsMsgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 用户推送互动插件特效消息到直播间
     *  *
     * @param SendLiveInteractionPluginEffectsMsgRequest $request SendLiveInteractionPluginEffectsMsgRequest
     *
     * @return SendLiveInteractionPluginEffectsMsgResponse SendLiveInteractionPluginEffectsMsgResponse
     */
    public function sendLiveInteractionPluginEffectsMsg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendLiveInteractionPluginEffectsMsgHeaders([]);

        return $this->sendLiveInteractionPluginEffectsMsgWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 用户对互动插件进行操作广播到直播间
     *  *
     * @param SendLivePluginUserActionMsgRequest $tmpReq  SendLivePluginUserActionMsgRequest
     * @param SendLivePluginUserActionMsgHeaders $headers SendLivePluginUserActionMsgHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return SendLivePluginUserActionMsgResponse SendLivePluginUserActionMsgResponse
     */
    public function sendLivePluginUserActionMsgWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new SendLivePluginUserActionMsgShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->pluginEffectsMessage)) {
            $request->pluginEffectsMessageShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->pluginEffectsMessage, 'pluginEffectsMessage', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            $query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->pluginEffectsMessageShrink)) {
            $query['pluginEffectsMessage'] = $request->pluginEffectsMessageShrink;
        }
        if (!Utils::isUnset($request->pluginId)) {
            $query['pluginId'] = $request->pluginId;
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
            'action'      => 'SendLivePluginUserActionMsg',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/interactionPlugins/actionMessages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendLivePluginUserActionMsgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 用户对互动插件进行操作广播到直播间
     *  *
     * @param SendLivePluginUserActionMsgRequest $request SendLivePluginUserActionMsgRequest
     *
     * @return SendLivePluginUserActionMsgResponse SendLivePluginUserActionMsgResponse
     */
    public function sendLivePluginUserActionMsg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendLivePluginUserActionMsgHeaders([]);

        return $this->sendLivePluginUserActionMsgWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 开始一场云导播
     *  *
     * @param string                $feedId
     * @param StartCloudFeedRequest $request StartCloudFeedRequest
     * @param StartCloudFeedHeaders $headers StartCloudFeedHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return StartCloudFeedResponse StartCloudFeedResponse
     */
    public function startCloudFeedWithOptions($feedId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action'      => 'StartCloudFeed',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/cloudFeeds/' . $feedId . '/start',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return StartCloudFeedResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 开始一场云导播
     *  *
     * @param string                $feedId
     * @param StartCloudFeedRequest $request StartCloudFeedRequest
     *
     * @return StartCloudFeedResponse StartCloudFeedResponse
     */
    public function startCloudFeed($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartCloudFeedHeaders([]);

        return $this->startCloudFeedWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @summary 结束一场云导播
     *  *
     * @param string               $feedId
     * @param StopCloudFeedRequest $request StopCloudFeedRequest
     * @param StopCloudFeedHeaders $headers StopCloudFeedHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return StopCloudFeedResponse StopCloudFeedResponse
     */
    public function stopCloudFeedWithOptions($feedId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action'      => 'StopCloudFeed',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/cloudFeeds/' . $feedId . '/stop',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return StopCloudFeedResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 结束一场云导播
     *  *
     * @param string               $feedId
     * @param StopCloudFeedRequest $request StopCloudFeedRequest
     *
     * @return StopCloudFeedResponse StopCloudFeedResponse
     */
    public function stopCloudFeed($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StopCloudFeedHeaders([]);

        return $this->stopCloudFeedWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @summary 预约直播
     *  *
     * @param SubscribeLiveRequest $request SubscribeLiveRequest
     * @param SubscribeLiveHeaders $headers SubscribeLiveHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return SubscribeLiveResponse SubscribeLiveResponse
     */
    public function subscribeLiveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            $query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->subscribe)) {
            $query['subscribe'] = $request->subscribe;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'SubscribeLive',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/lives/subscribe',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SubscribeLiveResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 预约直播
     *  *
     * @param SubscribeLiveRequest $request SubscribeLiveRequest
     *
     * @return SubscribeLiveResponse SubscribeLiveResponse
     */
    public function subscribeLive($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SubscribeLiveHeaders([]);

        return $this->subscribeLiveWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改直播
     *  *
     * @param UpdateLiveRequest $request UpdateLiveRequest
     * @param UpdateLiveHeaders $headers UpdateLiveHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateLiveResponse UpdateLiveResponse
     */
    public function updateLiveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coverUrl)) {
            $body['coverUrl'] = $request->coverUrl;
        }
        if (!Utils::isUnset($request->introduction)) {
            $body['introduction'] = $request->introduction;
        }
        if (!Utils::isUnset($request->liveId)) {
            $body['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->preEndTime)) {
            $body['preEndTime'] = $request->preEndTime;
        }
        if (!Utils::isUnset($request->preStartTime)) {
            $body['preStartTime'] = $request->preStartTime;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'UpdateLive',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/lives',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateLiveResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改直播
     *  *
     * @param UpdateLiveRequest $request UpdateLiveRequest
     *
     * @return UpdateLiveResponse UpdateLiveResponse
     */
    public function updateLive($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateLiveHeaders([]);

        return $this->updateLiveWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改培训课程信息
     *  *
     * @param string                $feedId
     * @param UpdateLiveFeedRequest $request UpdateLiveFeedRequest
     * @param UpdateLiveFeedHeaders $headers UpdateLiveFeedHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateLiveFeedResponse UpdateLiveFeedResponse
     */
    public function updateLiveFeedWithOptions($feedId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->coverUrl)) {
            $query['coverUrl'] = $request->coverUrl;
        }
        if (!Utils::isUnset($request->introduction)) {
            $query['introduction'] = $request->introduction;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->title)) {
            $query['title'] = $request->title;
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
            'action'      => 'UpdateLiveFeed',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/openFeeds/' . $feedId . '',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateLiveFeedResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改培训课程信息
     *  *
     * @param string                $feedId
     * @param UpdateLiveFeedRequest $request UpdateLiveFeedRequest
     *
     * @return UpdateLiveFeedResponse UpdateLiveFeedResponse
     */
    public function updateLiveFeed($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateLiveFeedHeaders([]);

        return $this->updateLiveFeedWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @summary 修改直播间内某一互动插件的信息
     *  *
     * @param UpdateLiveInteractionPluginRequest $request UpdateLiveInteractionPluginRequest
     * @param UpdateLiveInteractionPluginHeaders $headers UpdateLiveInteractionPluginHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateLiveInteractionPluginResponse UpdateLiveInteractionPluginResponse
     */
    public function updateLiveInteractionPluginWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->liveId)) {
            $query['liveId'] = $request->liveId;
        }
        if (!Utils::isUnset($request->pluginId)) {
            $query['pluginId'] = $request->pluginId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->anchorJumpUrl)) {
            $body['anchorJumpUrl'] = $request->anchorJumpUrl;
        }
        if (!Utils::isUnset($request->pluginIconUrl)) {
            $body['pluginIconUrl'] = $request->pluginIconUrl;
        }
        if (!Utils::isUnset($request->pluginName)) {
            $body['pluginName'] = $request->pluginName;
        }
        if (!Utils::isUnset($request->pluginNameEn)) {
            $body['pluginNameEn'] = $request->pluginNameEn;
        }
        if (!Utils::isUnset($request->viewerJumpUrl)) {
            $body['viewerJumpUrl'] = $request->viewerJumpUrl;
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
            'action'      => 'UpdateLiveInteractionPlugin',
            'version'     => 'live_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/live/interactionPlugins',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateLiveInteractionPluginResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改直播间内某一互动插件的信息
     *  *
     * @param UpdateLiveInteractionPluginRequest $request UpdateLiveInteractionPluginRequest
     *
     * @return UpdateLiveInteractionPluginResponse UpdateLiveInteractionPluginResponse
     */
    public function updateLiveInteractionPlugin($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateLiveInteractionPluginHeaders([]);

        return $this->updateLiveInteractionPluginWithOptions($request, $headers, $runtime);
    }
}
