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
     * @param WikiWordsDetailRequest $request
     *
     * @return WikiWordsDetailResponse
     */
    public function wikiWordsDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WikiWordsDetailHeaders([]);

        return $this->wikiWordsDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @param WikiWordsDetailRequest $request
     * @param WikiWordsDetailHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return WikiWordsDetailResponse
     */
    public function wikiWordsDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->wordName)) {
            @$query['wordName'] = $request->wordName;
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

        return WikiWordsDetailResponse::fromMap($this->doROARequest('WikiWordsDetail', 'wiki_1.0', 'HTTP', 'GET', 'AK', '/v1.0/wiki/words/details', 'json', $req, $runtime));
    }

    /**
     * @param WikiWordsParseRequest $request
     *
     * @return WikiWordsParseResponse
     */
    public function wikiWordsParse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new WikiWordsParseHeaders([]);

        return $this->wikiWordsParseWithOptions($request, $headers, $runtime);
    }

    /**
     * @param WikiWordsParseRequest $request
     * @param WikiWordsParseHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return WikiWordsParseResponse
     */
    public function wikiWordsParseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return WikiWordsParseResponse::fromMap($this->doROARequest('WikiWordsParse', 'wiki_1.0', 'HTTP', 'POST', 'AK', '/v1.0/wiki/words/parse', 'json', $req, $runtime));
    }
}
