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
        $this->_client             = new DarabonbaGatewayDingTalkClient();
        $this->_spi                = $this->_client;
        $this->_signatureAlgorithm = 'v2';
        $this->_endpointRule       = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param CheckInCrowdsByMobileRequest $request
     * @param string[]                     $headers
     * @param RuntimeOptions               $runtime
     *
     * @return CheckInCrowdsByMobileResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'CheckInCrowdsByMobile',
            'version'     => 'watt_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/watt/crowdIdentifications/query',
            'method'      => 'POST',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CheckInCrowdsByMobileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CheckInCrowdsByMobileRequest $request
     *
     * @return CheckInCrowdsByMobileResponse
     */
    public function checkInCrowdsByMobile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->checkInCrowdsByMobileWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ConsumePointRequest $tmpReq
     * @param ConsumePointHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return ConsumePointResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ConsumePoint',
            'version'     => 'watt_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/watt/points/consume',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ConsumePointResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ConsumePointRequest $request
     *
     * @return ConsumePointResponse
     */
    public function consumePoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConsumePointHeaders([]);

        return $this->consumePointWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateDeliveryPlanRequest $request
     * @param CreateDeliveryPlanHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return CreateDeliveryPlanResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateDeliveryPlan',
            'version'     => 'watt_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/watt/deliveryPlans/publish',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateDeliveryPlanResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateDeliveryPlanRequest $request
     *
     * @return CreateDeliveryPlanResponse
     */
    public function createDeliveryPlan($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDeliveryPlanHeaders([]);

        return $this->createDeliveryPlanWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetPointInfoRequest $request
     * @param GetPointInfoHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetPointInfoResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetPointInfo',
            'version'     => 'watt_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/watt/points',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetPointInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetPointInfoRequest $request
     *
     * @return GetPointInfoResponse
     */
    public function getPointInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPointInfoHeaders([]);

        return $this->getPointInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RevertPointRequest $tmpReq
     * @param RevertPointHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return RevertPointResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'RevertPoint',
            'version'     => 'watt_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/watt/points/revert',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RevertPointResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RevertPointRequest $request
     *
     * @return RevertPointResponse
     */
    public function revertPoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RevertPointHeaders([]);

        return $this->revertPointWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendBannerRequest $request
     * @param SendBannerHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return SendBannerResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SendBanner',
            'version'     => 'watt_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/watt/banners/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendBannerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SendBannerRequest $request
     *
     * @return SendBannerResponse
     */
    public function sendBanner($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendBannerHeaders([]);

        return $this->sendBannerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendPopupRequest $request
     * @param SendPopupHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return SendPopupResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SendPopup',
            'version'     => 'watt_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/watt/popups/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendPopupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SendPopupRequest $request
     *
     * @return SendPopupResponse
     */
    public function sendPopup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendPopupHeaders([]);

        return $this->sendPopupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendSearchShadeRequest $request
     * @param SendSearchShadeHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return SendSearchShadeResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SendSearchShade',
            'version'     => 'watt_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/watt/searchShades/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendSearchShadeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SendSearchShadeRequest $request
     *
     * @return SendSearchShadeResponse
     */
    public function sendSearchShade($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendSearchShadeHeaders([]);

        return $this->sendSearchShadeWithOptions($request, $headers, $runtime);
    }
}
