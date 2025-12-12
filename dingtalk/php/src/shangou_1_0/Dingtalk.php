<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vshangou_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vshangou_1_0\Models\AddCateringCommentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vshangou_1_0\Models\AddCateringCommentRequest;
use AlibabaCloud\SDK\Dingtalk\Vshangou_1_0\Models\AddCateringCommentResponse;
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
     * @summary 新增餐饮评价数据
     *  *
     * @param AddCateringCommentRequest $request AddCateringCommentRequest
     * @param AddCateringCommentHeaders $headers AddCateringCommentHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return AddCateringCommentResponse AddCateringCommentResponse
     */
    public function addCateringCommentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->commentId)) {
            $body['commentId'] = $request->commentId;
        }
        if (!Utils::isUnset($request->orderId)) {
            $body['orderId'] = $request->orderId;
        }
        if (!Utils::isUnset($request->rateContent)) {
            $body['rateContent'] = $request->rateContent;
        }
        if (!Utils::isUnset($request->ratedAt)) {
            $body['ratedAt'] = $request->ratedAt;
        }
        if (!Utils::isUnset($request->rating)) {
            $body['rating'] = $request->rating;
        }
        if (!Utils::isUnset($request->shopId)) {
            $body['shopId'] = $request->shopId;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
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
            'action' => 'AddCateringComment',
            'version' => 'shangou_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/shangou/comment/create',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddCateringCommentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增餐饮评价数据
     *  *
     * @param AddCateringCommentRequest $request AddCateringCommentRequest
     *
     * @return AddCateringCommentResponse AddCateringCommentResponse
     */
    public function addCateringComment($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddCateringCommentHeaders([]);

        return $this->addCateringCommentWithOptions($request, $headers, $runtime);
    }
}
