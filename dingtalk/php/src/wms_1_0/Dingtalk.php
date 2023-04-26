<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwms_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vwms_1_0\Models\QueryGoodsListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwms_1_0\Models\QueryGoodsListRequest;
use AlibabaCloud\SDK\Dingtalk\Vwms_1_0\Models\QueryGoodsListResponse;
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
        $this->_client       = new DarabonbaGatewayDingTalkClient();
        $this->_spi          = $this->_client;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param QueryGoodsListRequest $request
     * @param QueryGoodsListHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryGoodsListResponse
     */
    public function queryGoodsListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTimeInMills)) {
            $query['endTimeInMills'] = $request->endTimeInMills;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->startTimeInMills)) {
            $query['startTimeInMills'] = $request->startTimeInMills;
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
            'action'      => 'QueryGoodsList',
            'version'     => 'wms_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/wms/goods',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryGoodsListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryGoodsListRequest $request
     *
     * @return QueryGoodsListResponse
     */
    public function queryGoodsList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGoodsListHeaders([]);

        return $this->queryGoodsListWithOptions($request, $headers, $runtime);
    }
}
