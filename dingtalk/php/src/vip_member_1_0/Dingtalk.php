<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\DirectRedeemVipMemberByMobileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\DirectRedeemVipMemberByMobileRequest;
use AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\DirectRedeemVipMemberByMobileResponse;
use AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\InvalidRedeemVipMemberByBizRequestIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\InvalidRedeemVipMemberByBizRequestIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\InvalidRedeemVipMemberByBizRequestIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\PreCheckRedeemVipMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\PreCheckRedeemVipMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\PreCheckRedeemVipMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\QueryRedeemVipMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\QueryRedeemVipMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\QueryRedeemVipMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\QueryVipMemberInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\QueryVipMemberInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\QueryVipMemberInfoResponse;
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
     * @summary 通过手机号直充365会员
     *  *
     * @param DirectRedeemVipMemberByMobileRequest $request DirectRedeemVipMemberByMobileRequest
     * @param DirectRedeemVipMemberByMobileHeaders $headers DirectRedeemVipMemberByMobileHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return DirectRedeemVipMemberByMobileResponse DirectRedeemVipMemberByMobileResponse
     */
    public function directRedeemVipMemberByMobileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizRequestId)) {
            $body['bizRequestId'] = $request->bizRequestId;
        }
        if (!Utils::isUnset($request->channel)) {
            $body['channel'] = $request->channel;
        }
        if (!Utils::isUnset($request->dingtalkId)) {
            $body['dingtalkId'] = $request->dingtalkId;
        }
        if (!Utils::isUnset($request->duration)) {
            $body['duration'] = $request->duration;
        }
        if (!Utils::isUnset($request->mobile)) {
            $body['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->uuid)) {
            $body['uuid'] = $request->uuid;
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
            'action' => 'DirectRedeemVipMemberByMobile',
            'version' => 'vipMember_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/vipMember/users/directRedeemVip',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DirectRedeemVipMemberByMobileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过手机号直充365会员
     *  *
     * @param DirectRedeemVipMemberByMobileRequest $request DirectRedeemVipMemberByMobileRequest
     *
     * @return DirectRedeemVipMemberByMobileResponse DirectRedeemVipMemberByMobileResponse
     */
    public function directRedeemVipMemberByMobile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DirectRedeemVipMemberByMobileHeaders([]);

        return $this->directRedeemVipMemberByMobileWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过虚拟订单号作废365会员权益
     *  *
     * @param InvalidRedeemVipMemberByBizRequestIdRequest $request InvalidRedeemVipMemberByBizRequestIdRequest
     * @param InvalidRedeemVipMemberByBizRequestIdHeaders $headers InvalidRedeemVipMemberByBizRequestIdHeaders
     * @param RuntimeOptions                              $runtime runtime options for this request RuntimeOptions
     *
     * @return InvalidRedeemVipMemberByBizRequestIdResponse InvalidRedeemVipMemberByBizRequestIdResponse
     */
    public function invalidRedeemVipMemberByBizRequestIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizRequestId)) {
            $body['bizRequestId'] = $request->bizRequestId;
        }
        if (!Utils::isUnset($request->channel)) {
            $body['channel'] = $request->channel;
        }
        if (!Utils::isUnset($request->dingtalkId)) {
            $body['dingtalkId'] = $request->dingtalkId;
        }
        if (!Utils::isUnset($request->duration)) {
            $body['duration'] = $request->duration;
        }
        if (!Utils::isUnset($request->mobile)) {
            $body['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->uuid)) {
            $body['uuid'] = $request->uuid;
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
            'action' => 'InvalidRedeemVipMemberByBizRequestId',
            'version' => 'vipMember_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/vipMember/users/invalidRedeemVip',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return InvalidRedeemVipMemberByBizRequestIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过虚拟订单号作废365会员权益
     *  *
     * @param InvalidRedeemVipMemberByBizRequestIdRequest $request InvalidRedeemVipMemberByBizRequestIdRequest
     *
     * @return InvalidRedeemVipMemberByBizRequestIdResponse InvalidRedeemVipMemberByBizRequestIdResponse
     */
    public function invalidRedeemVipMemberByBizRequestId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InvalidRedeemVipMemberByBizRequestIdHeaders([]);

        return $this->invalidRedeemVipMemberByBizRequestIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 直充会员预校验是否满足条件
     *  *
     * @param PreCheckRedeemVipMemberRequest $request PreCheckRedeemVipMemberRequest
     * @param PreCheckRedeemVipMemberHeaders $headers PreCheckRedeemVipMemberHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return PreCheckRedeemVipMemberResponse PreCheckRedeemVipMemberResponse
     */
    public function preCheckRedeemVipMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizRequestId)) {
            $body['bizRequestId'] = $request->bizRequestId;
        }
        if (!Utils::isUnset($request->channel)) {
            $body['channel'] = $request->channel;
        }
        if (!Utils::isUnset($request->dingtalkId)) {
            $body['dingtalkId'] = $request->dingtalkId;
        }
        if (!Utils::isUnset($request->duration)) {
            $body['duration'] = $request->duration;
        }
        if (!Utils::isUnset($request->mobile)) {
            $body['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->uuid)) {
            $body['uuid'] = $request->uuid;
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
            'action' => 'PreCheckRedeemVipMember',
            'version' => 'vipMember_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/vipMember/users/preCheckRedeemVip',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PreCheckRedeemVipMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 直充会员预校验是否满足条件
     *  *
     * @param PreCheckRedeemVipMemberRequest $request PreCheckRedeemVipMemberRequest
     *
     * @return PreCheckRedeemVipMemberResponse PreCheckRedeemVipMemberResponse
     */
    public function preCheckRedeemVipMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PreCheckRedeemVipMemberHeaders([]);

        return $this->preCheckRedeemVipMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询365会员直充信息
     *  *
     * @param QueryRedeemVipMemberRequest $request QueryRedeemVipMemberRequest
     * @param QueryRedeemVipMemberHeaders $headers QueryRedeemVipMemberHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryRedeemVipMemberResponse QueryRedeemVipMemberResponse
     */
    public function queryRedeemVipMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizRequestId)) {
            $body['bizRequestId'] = $request->bizRequestId;
        }
        if (!Utils::isUnset($request->channel)) {
            $body['channel'] = $request->channel;
        }
        if (!Utils::isUnset($request->dingtalkId)) {
            $body['dingtalkId'] = $request->dingtalkId;
        }
        if (!Utils::isUnset($request->duration)) {
            $body['duration'] = $request->duration;
        }
        if (!Utils::isUnset($request->mobile)) {
            $body['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->uuid)) {
            $body['uuid'] = $request->uuid;
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
            'action' => 'QueryRedeemVipMember',
            'version' => 'vipMember_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/vipMember/users/queryRedeemVip',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryRedeemVipMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询365会员直充信息
     *  *
     * @param QueryRedeemVipMemberRequest $request QueryRedeemVipMemberRequest
     *
     * @return QueryRedeemVipMemberResponse QueryRedeemVipMemberResponse
     */
    public function queryRedeemVipMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRedeemVipMemberHeaders([]);

        return $this->queryRedeemVipMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询365会员信息
     *  *
     * @param QueryVipMemberInfoRequest $request QueryVipMemberInfoRequest
     * @param QueryVipMemberInfoHeaders $headers QueryVipMemberInfoHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryVipMemberInfoResponse QueryVipMemberInfoResponse
     */
    public function queryVipMemberInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->channelCode)) {
            $body['channelCode'] = $request->channelCode;
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
            'action' => 'QueryVipMemberInfo',
            'version' => 'vipMember_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/vipMember/users/memberInfos/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryVipMemberInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询365会员信息
     *  *
     * @param QueryVipMemberInfoRequest $request QueryVipMemberInfoRequest
     *
     * @return QueryVipMemberInfoResponse QueryVipMemberInfoResponse
     */
    public function queryVipMemberInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryVipMemberInfoHeaders([]);

        return $this->queryVipMemberInfoWithOptions($request, $headers, $runtime);
    }
}
