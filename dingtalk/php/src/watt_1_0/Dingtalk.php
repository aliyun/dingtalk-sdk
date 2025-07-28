<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwatt_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\CheckInCrowdsByMobileRequest;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\CheckInCrowdsByMobileResponse;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\ConsumePointHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\ConsumePointRequest;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\ConsumePointResponse;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\ConsumePointShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\CreateDeliveryPlanHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\CreateDeliveryPlanRequest;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\CreateDeliveryPlanResponse;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\GetPointInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\GetPointInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\GetPointInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\RevertPointHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\RevertPointRequest;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\RevertPointResponse;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\RevertPointShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\SendBannerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\SendBannerRequest;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\SendBannerResponse;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\SendPopupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\SendPopupRequest;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\SendPopupResponse;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\SendSearchShadeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\SendSearchShadeRequest;
use AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\SendSearchShadeResponse;
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
        $this->_signatureAlgorithm = 'v2';
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 根据加密后的用户手机号检查该用户是否在某人群中
     *  *
     * @param CheckInCrowdsByMobileRequest $request CheckInCrowdsByMobileRequest
     * @param string[]                     $headers map
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CheckInCrowdsByMobileResponse CheckInCrowdsByMobileResponse
     */
    public function checkInCrowdsByMobileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->crowdIds)) {
            $query['crowdIds'] = $request->crowdIds;
        }
        if (!Utils::isUnset($request->mobile)) {
            $query['mobile'] = $request->mobile;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'CheckInCrowdsByMobile',
            'version' => 'watt_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/watt/crowdIdentifications/query',
            'method' => 'POST',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CheckInCrowdsByMobileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据加密后的用户手机号检查该用户是否在某人群中
     *  *
     * @param CheckInCrowdsByMobileRequest $request CheckInCrowdsByMobileRequest
     *
     * @return CheckInCrowdsByMobileResponse CheckInCrowdsByMobileResponse
     */
    public function checkInCrowdsByMobile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->checkInCrowdsByMobileWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 消耗用户积分
     *  *
     * @param ConsumePointRequest $tmpReq  ConsumePointRequest
     * @param ConsumePointHeaders $headers ConsumePointHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return ConsumePointResponse ConsumePointResponse
     */
    public function consumePointWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new ConsumePointShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->body)) {
            $request->bodyShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->body, 'body', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->bodyShrink)) {
            $query['body'] = $request->bodyShrink;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ConsumePoint',
            'version' => 'watt_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/watt/points/consume',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ConsumePointResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 消耗用户积分
     *  *
     * @param ConsumePointRequest $request ConsumePointRequest
     *
     * @return ConsumePointResponse ConsumePointResponse
     */
    public function consumePoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConsumePointHeaders([]);

        return $this->consumePointWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发布钉钉投放任务（搜索穹顶、搜索发现、搜索关键字）
     *  *
     * @param CreateDeliveryPlanRequest $request CreateDeliveryPlanRequest
     * @param CreateDeliveryPlanHeaders $headers CreateDeliveryPlanHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateDeliveryPlanResponse CreateDeliveryPlanResponse
     */
    public function createDeliveryPlanWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->resId)) {
            $body['resId'] = $request->resId;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->userIdList)) {
            $body['userIdList'] = $request->userIdList;
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
            'action' => 'CreateDeliveryPlan',
            'version' => 'watt_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/watt/deliveryPlans/publish',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateDeliveryPlanResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发布钉钉投放任务（搜索穹顶、搜索发现、搜索关键字）
     *  *
     * @param CreateDeliveryPlanRequest $request CreateDeliveryPlanRequest
     *
     * @return CreateDeliveryPlanResponse CreateDeliveryPlanResponse
     */
    public function createDeliveryPlan($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDeliveryPlanHeaders([]);

        return $this->createDeliveryPlanWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户积分
     *  *
     * @param GetPointInfoRequest $request GetPointInfoRequest
     * @param GetPointInfoHeaders $headers GetPointInfoHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPointInfoResponse GetPointInfoResponse
     */
    public function getPointInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pointPoolCode)) {
            $query['pointPoolCode'] = $request->pointPoolCode;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetPointInfo',
            'version' => 'watt_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/watt/points',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetPointInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户积分
     *  *
     * @param GetPointInfoRequest $request GetPointInfoRequest
     *
     * @return GetPointInfoResponse GetPointInfoResponse
     */
    public function getPointInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPointInfoHeaders([]);

        return $this->getPointInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 撤销用户单笔积分消耗
     *  *
     * @param RevertPointRequest $tmpReq  RevertPointRequest
     * @param RevertPointHeaders $headers RevertPointHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return RevertPointResponse RevertPointResponse
     */
    public function revertPointWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new RevertPointShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->body)) {
            $request->bodyShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->body, 'body', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->bodyShrink)) {
            $query['body'] = $request->bodyShrink;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'RevertPoint',
            'version' => 'watt_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/watt/points/revert',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RevertPointResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 撤销用户单笔积分消耗
     *  *
     * @param RevertPointRequest $request RevertPointRequest
     *
     * @return RevertPointResponse RevertPointResponse
     */
    public function revertPoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RevertPointHeaders([]);

        return $this->revertPointWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送钉钉统一引导Banner
     *  *
     * @param SendBannerRequest $request SendBannerRequest
     * @param SendBannerHeaders $headers SendBannerHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return SendBannerResponse SendBannerResponse
     */
    public function sendBannerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SendBanner',
            'version' => 'watt_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/watt/banners/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendBannerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送钉钉统一引导Banner
     *  *
     * @param SendBannerRequest $request SendBannerRequest
     *
     * @return SendBannerResponse SendBannerResponse
     */
    public function sendBanner($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendBannerHeaders([]);

        return $this->sendBannerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送钉钉首页弹窗
     *  *
     * @param SendPopupRequest $request SendPopupRequest
     * @param SendPopupHeaders $headers SendPopupHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return SendPopupResponse SendPopupResponse
     */
    public function sendPopupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SendPopup',
            'version' => 'watt_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/watt/popups/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendPopupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送钉钉首页弹窗
     *  *
     * @param SendPopupRequest $request SendPopupRequest
     *
     * @return SendPopupResponse SendPopupResponse
     */
    public function sendPopup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendPopupHeaders([]);

        return $this->sendPopupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送钉钉搜索底纹
     *  *
     * @param SendSearchShadeRequest $request SendSearchShadeRequest
     * @param SendSearchShadeHeaders $headers SendSearchShadeHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return SendSearchShadeResponse SendSearchShadeResponse
     */
    public function sendSearchShadeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SendSearchShade',
            'version' => 'watt_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/watt/searchShades/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendSearchShadeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送钉钉搜索底纹
     *  *
     * @param SendSearchShadeRequest $request SendSearchShadeRequest
     *
     * @return SendSearchShadeResponse SendSearchShadeResponse
     */
    public function sendSearchShade($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendSearchShadeHeaders([]);

        return $this->sendSearchShadeWithOptions($request, $headers, $runtime);
    }
}
