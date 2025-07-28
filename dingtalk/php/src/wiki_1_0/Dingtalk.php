<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vwiki_1_0\Models\WikiWordsDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_1_0\Models\WikiWordsDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_1_0\Models\WikiWordsDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vwiki_1_0\Models\WikiWordsParseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vwiki_1_0\Models\WikiWordsParseRequest;
use AlibabaCloud\SDK\Dingtalk\Vwiki_1_0\Models\WikiWordsParseResponse;
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
     * @summary 根据词条名称获取该词条释义
     *  *
     * @param WikiWordsDetailRequest $request WikiWordsDetailRequest
     * @param WikiWordsDetailHeaders $headers WikiWordsDetailHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return WikiWordsDetailResponse WikiWordsDetailResponse
     */
    public function wikiWordsDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->wordName)) {
            $query['wordName'] = $request->wordName;
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
            'action' => 'WikiWordsDetail',
            'version' => 'wiki_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/wiki/words/details',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return WikiWordsDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据词条名称获取该词条释义
     *  *
     * @param WikiWordsDetailRequest $request WikiWordsDetailRequest
     *
     * @return WikiWordsDetailResponse WikiWordsDetailResponse
     */
    public function wikiWordsDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WikiWordsDetailHeaders([]);

        return $this->wikiWordsDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 外部传递过来的消息根据百科词库分词
     *  *
     * @param WikiWordsParseRequest $request WikiWordsParseRequest
     * @param WikiWordsParseHeaders $headers WikiWordsParseHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return WikiWordsParseResponse WikiWordsParseResponse
     */
    public function wikiWordsParseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
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
            'action' => 'WikiWordsParse',
            'version' => 'wiki_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/wiki/words/parse',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return WikiWordsParseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 外部传递过来的消息根据百科词库分词
     *  *
     * @param WikiWordsParseRequest $request WikiWordsParseRequest
     *
     * @return WikiWordsParseResponse WikiWordsParseResponse
     */
    public function wikiWordsParse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WikiWordsParseHeaders([]);

        return $this->wikiWordsParseWithOptions($request, $headers, $runtime);
    }
}
