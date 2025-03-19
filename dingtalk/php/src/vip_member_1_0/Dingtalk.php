<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
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
