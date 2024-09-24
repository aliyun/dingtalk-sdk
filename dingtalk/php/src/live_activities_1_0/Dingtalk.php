<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_activities_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vlive_activities_1_0\Models\PushLiveActivityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_activities_1_0\Models\PushLiveActivityRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_activities_1_0\Models\PushLiveActivityResponse;
use AlibabaCloud\SDK\Dingtalk\Vlive_activities_1_0\Models\SendLiveActivityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlive_activities_1_0\Models\SendLiveActivityRequest;
use AlibabaCloud\SDK\Dingtalk\Vlive_activities_1_0\Models\SendLiveActivityResponse;
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
        $this->_productId    = 'dingtalk';
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 实时活动发送接口
     *  *
     * @param PushLiveActivityRequest $request PushLiveActivityRequest
     * @param PushLiveActivityHeaders $headers PushLiveActivityHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return PushLiveActivityResponse PushLiveActivityResponse
     */
    public function pushLiveActivityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->activityEventData)) {
            $body['activityEventData'] = $request->activityEventData;
        }
        if (!Utils::isUnset($request->activityEventOption)) {
            $body['activityEventOption'] = $request->activityEventOption;
        }
        if (!Utils::isUnset($request->activityId)) {
            $body['activityId'] = $request->activityId;
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
            'action'      => 'PushLiveActivity',
            'version'     => 'liveActivities_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/liveActivities/push',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PushLiveActivityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 实时活动发送接口
     *  *
     * @param PushLiveActivityRequest $request PushLiveActivityRequest
     *
     * @return PushLiveActivityResponse PushLiveActivityResponse
     */
    public function pushLiveActivity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PushLiveActivityHeaders([]);

        return $this->pushLiveActivityWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送实时活动
     *  *
     * @param SendLiveActivityRequest $request SendLiveActivityRequest
     * @param SendLiveActivityHeaders $headers SendLiveActivityHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return SendLiveActivityResponse SendLiveActivityResponse
     */
    public function sendLiveActivityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->activityEventData)) {
            $body['activityEventData'] = $request->activityEventData;
        }
        if (!Utils::isUnset($request->activityEventOption)) {
            $body['activityEventOption'] = $request->activityEventOption;
        }
        if (!Utils::isUnset($request->activityId)) {
            $body['activityId'] = $request->activityId;
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
            'action'      => 'SendLiveActivity',
            'version'     => 'liveActivities_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/liveActivities/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendLiveActivityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送实时活动
     *  *
     * @param SendLiveActivityRequest $request SendLiveActivityRequest
     *
     * @return SendLiveActivityResponse SendLiveActivityResponse
     */
    public function sendLiveActivity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendLiveActivityHeaders([]);

        return $this->sendLiveActivityWithOptions($request, $headers, $runtime);
    }
}
