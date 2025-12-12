<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vding_one_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\DeleteFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\DeleteFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\DeleteFeedResponse;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\DeliverOneFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\DeliverOneFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\DeliverOneFeedResponse;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\PushFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\PushFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\PushFeedResponse;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\UpdateFeedContentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\UpdateFeedContentRequest;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\UpdateFeedContentResponse;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\UpdateFeedExpireTimeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\UpdateFeedExpireTimeRequest;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\UpdateFeedExpireTimeResponse;
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
        $gatewayClient = new Client();
        $this->_spi = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 删除Feed
     *  *
     * @param DeleteFeedRequest $request DeleteFeedRequest
     * @param DeleteFeedHeaders $headers DeleteFeedHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteFeedResponse DeleteFeedResponse
     */
    public function deleteFeedWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->feedId)) {
            $body['feedId'] = $request->feedId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DeleteFeed',
            'version' => 'dingOne_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dingOne/frame/feeds/deleteFeed',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteFeedResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除Feed
     *  *
     * @param DeleteFeedRequest $request DeleteFeedRequest
     *
     * @return DeleteFeedResponse DeleteFeedResponse
     */
    public function deleteFeed($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteFeedHeaders([]);

        return $this->deleteFeedWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 投放钉钉one中feed流资讯内容
     *  *
     * @param DeliverOneFeedRequest $request DeliverOneFeedRequest
     * @param DeliverOneFeedHeaders $headers DeliverOneFeedHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return DeliverOneFeedResponse DeliverOneFeedResponse
     */
    public function deliverOneFeedWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->coverMediaId)) {
            $body['coverMediaId'] = $request->coverMediaId;
        }
        if (!Utils::isUnset($request->expireTime)) {
            $body['expireTime'] = $request->expireTime;
        }
        if (!Utils::isUnset($request->summary)) {
            $body['summary'] = $request->summary;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
        }
        if (!Utils::isUnset($request->videoMediaId)) {
            $body['videoMediaId'] = $request->videoMediaId;
        }
        if (!Utils::isUnset($request->videoTags)) {
            $body['videoTags'] = $request->videoTags;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DeliverOneFeed',
            'version' => 'dingOne_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dingOne/feed/deliver',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeliverOneFeedResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 投放钉钉one中feed流资讯内容
     *  *
     * @param DeliverOneFeedRequest $request DeliverOneFeedRequest
     *
     * @return DeliverOneFeedResponse DeliverOneFeedResponse
     */
    public function deliverOneFeed($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeliverOneFeedHeaders([]);

        return $this->deliverOneFeedWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary Feed推送
     *  *
     * @param PushFeedRequest $request PushFeedRequest
     * @param PushFeedHeaders $headers PushFeedHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return PushFeedResponse PushFeedResponse
     */
    public function pushFeedWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->expireTime)) {
            $body['expireTime'] = $request->expireTime;
        }
        if (!Utils::isUnset($request->feedFeature)) {
            $body['feedFeature'] = $request->feedFeature;
        }
        if (!Utils::isUnset($request->idempotentKey)) {
            $body['idempotentKey'] = $request->idempotentKey;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PushFeed',
            'version' => 'dingOne_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dingOne/frame/feeds/pushFeed',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PushFeedResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary Feed推送
     *  *
     * @param PushFeedRequest $request PushFeedRequest
     *
     * @return PushFeedResponse PushFeedResponse
     */
    public function pushFeed($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PushFeedHeaders([]);

        return $this->pushFeedWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新feed内容
     *  *
     * @param UpdateFeedContentRequest $request UpdateFeedContentRequest
     * @param UpdateFeedContentHeaders $headers UpdateFeedContentHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateFeedContentResponse UpdateFeedContentResponse
     */
    public function updateFeedContentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->feedId)) {
            $body['feedId'] = $request->feedId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateFeedContent',
            'version' => 'dingOne_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dingOne/frame/feeds/updateFeedContent',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateFeedContentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新feed内容
     *  *
     * @param UpdateFeedContentRequest $request UpdateFeedContentRequest
     *
     * @return UpdateFeedContentResponse UpdateFeedContentResponse
     */
    public function updateFeedContent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateFeedContentHeaders([]);

        return $this->updateFeedContentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新feed过期时间
     *  *
     * @param UpdateFeedExpireTimeRequest $request UpdateFeedExpireTimeRequest
     * @param UpdateFeedExpireTimeHeaders $headers UpdateFeedExpireTimeHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateFeedExpireTimeResponse UpdateFeedExpireTimeResponse
     */
    public function updateFeedExpireTimeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->expireTime)) {
            $body['expireTime'] = $request->expireTime;
        }
        if (!Utils::isUnset($request->feedId)) {
            $body['feedId'] = $request->feedId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateFeedExpireTime',
            'version' => 'dingOne_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dingOne/frame/feeds/updateFeedExpireTime',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateFeedExpireTimeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新feed过期时间
     *  *
     * @param UpdateFeedExpireTimeRequest $request UpdateFeedExpireTimeRequest
     *
     * @return UpdateFeedExpireTimeResponse UpdateFeedExpireTimeResponse
     */
    public function updateFeedExpireTime($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateFeedExpireTimeHeaders([]);

        return $this->updateFeedExpireTimeWithOptions($request, $headers, $runtime);
    }
}
