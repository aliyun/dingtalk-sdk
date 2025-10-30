<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vding_one_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\DeliverOneFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\DeliverOneFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\DeliverOneFeedResponse;
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
}
