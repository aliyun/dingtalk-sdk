<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwms_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vwms_1_0\Models\QueryGoodsListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwms_1_0\Models\QueryGoodsListRequest;
use AlibabaCloud\SDK\Dingtalk\Vwms_1_0\Models\QueryGoodsListResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
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
            @$query['endTimeInMills'] = $request->endTimeInMills;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->startTimeInMills)) {
            @$query['startTimeInMills'] = $request->startTimeInMills;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryGoodsListResponse::fromMap($this->doROARequest('QueryGoodsList', 'wms_1.0', 'HTTP', 'GET', 'AK', '/v1.0/wms/goods', 'json', $req, $runtime));
    }
}
