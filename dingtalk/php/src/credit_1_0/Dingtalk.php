<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcredit_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcredit_1_0\Models\QueryScoreHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcredit_1_0\Models\QueryScoreRequest;
use AlibabaCloud\SDK\Dingtalk\Vcredit_1_0\Models\QueryScoreResponse;
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
     * @summary 查询用户金融评分数据
     *  *
     * @param QueryScoreRequest $request QueryScoreRequest
     * @param QueryScoreHeaders $headers QueryScoreHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryScoreResponse QueryScoreResponse
     */
    public function queryScoreWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->encryption)) {
            $query['encryption'] = $request->encryption;
        }
        if (!Utils::isUnset($request->fullName)) {
            $query['fullName'] = $request->fullName;
        }
        if (!Utils::isUnset($request->idCardCode)) {
            $query['idCardCode'] = $request->idCardCode;
        }
        if (!Utils::isUnset($request->mobile)) {
            $query['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->orgName)) {
            $query['orgName'] = $request->orgName;
        }
        if (!Utils::isUnset($request->uniScCode)) {
            $query['uniScCode'] = $request->uniScCode;
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
            'action'      => 'QueryScore',
            'version'     => 'credit_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/credit/scores',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryScoreResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户金融评分数据
     *  *
     * @param QueryScoreRequest $request QueryScoreRequest
     *
     * @return QueryScoreResponse QueryScoreResponse
     */
    public function queryScore($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryScoreHeaders([]);

        return $this->queryScoreWithOptions($request, $headers, $runtime);
    }
}
