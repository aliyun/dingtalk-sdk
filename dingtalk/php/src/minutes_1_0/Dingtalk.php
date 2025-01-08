<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTextHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTextRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTextResponse;
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
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 查询闪记状态
     *  *
     * @param string                    $taskUuid
     * @param QueryMinutesStatusRequest $request  QueryMinutesStatusRequest
     * @param QueryMinutesStatusHeaders $headers  QueryMinutesStatusHeaders
     * @param RuntimeOptions            $runtime  runtime options for this request RuntimeOptions
     *
     * @return QueryMinutesStatusResponse QueryMinutesStatusResponse
     */
    public function queryMinutesStatusWithOptions($taskUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'QueryMinutesStatus',
            'version'     => 'minutes_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/minutes/flashMinutes/' . $taskUuid . '/taskStatus',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryMinutesStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询闪记状态
     *  *
     * @param string                    $taskUuid
     * @param QueryMinutesStatusRequest $request  QueryMinutesStatusRequest
     *
     * @return QueryMinutesStatusResponse QueryMinutesStatusResponse
     */
    public function queryMinutesStatus($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMinutesStatusHeaders([]);

        return $this->queryMinutesStatusWithOptions($taskUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 查询闪记转写文本内容
     *  *
     * @param string                  $taskUuid
     * @param QueryMinutesTextRequest $request  QueryMinutesTextRequest
     * @param QueryMinutesTextHeaders $headers  QueryMinutesTextHeaders
     * @param RuntimeOptions          $runtime  runtime options for this request RuntimeOptions
     *
     * @return QueryMinutesTextResponse QueryMinutesTextResponse
     */
    public function queryMinutesTextWithOptions($taskUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->direction)) {
            $query['direction'] = $request->direction;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'QueryMinutesText',
            'version'     => 'minutes_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/minutes/flashMinutes/' . $taskUuid . '/textInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryMinutesTextResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询闪记转写文本内容
     *  *
     * @param string                  $taskUuid
     * @param QueryMinutesTextRequest $request  QueryMinutesTextRequest
     *
     * @return QueryMinutesTextResponse QueryMinutesTextResponse
     */
    public function queryMinutesText($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMinutesTextHeaders([]);

        return $this->queryMinutesTextWithOptions($taskUuid, $request, $headers, $runtime);
    }
}
