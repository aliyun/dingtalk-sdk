<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsearch_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\BatchInsertSearchItemHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\BatchInsertSearchItemRequest;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\BatchInsertSearchItemResponse;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\CreateSearchTabHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\CreateSearchTabRequest;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\CreateSearchTabResponse;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\DeleteSearchItemHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\DeleteSearchItemResponse;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\DeleteSearchTabHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\DeleteSearchTabResponse;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\GetSearchItemHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\GetSearchItemResponse;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\GetSearchItemsByKeyWordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\GetSearchItemsByKeyWordRequest;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\GetSearchItemsByKeyWordResponse;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\GetSearchTabHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\GetSearchTabResponse;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\InsertSearchItemHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\InsertSearchItemRequest;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\InsertSearchItemResponse;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\ListSearchTabsByOrgIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\ListSearchTabsByOrgIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\UpdateSearchTabHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\UpdateSearchTabRequest;
use AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\UpdateSearchTabResponse;
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
     * @param string                       $tabId
     * @param BatchInsertSearchItemRequest $request
     *
     * @return BatchInsertSearchItemResponse
     */
    public function batchInsertSearchItem($tabId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchInsertSearchItemHeaders([]);

        return $this->batchInsertSearchItemWithOptions($tabId, $request, $headers, $runtime);
    }

    /**
     * @param string                       $tabId
     * @param BatchInsertSearchItemRequest $request
     * @param BatchInsertSearchItemHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return BatchInsertSearchItemResponse
     */
    public function batchInsertSearchItemWithOptions($tabId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $tabId = OpenApiUtilClient::getEncodeParam($tabId);
        $body  = [];
        if (!Utils::isUnset($request->searchItemModels)) {
            @$body['searchItemModels'] = $request->searchItemModels;
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

        return BatchInsertSearchItemResponse::fromMap($this->doROARequest('BatchInsertSearchItem', 'search_1.0', 'HTTP', 'POST', 'AK', '/v1.0/search/tabs/' . $tabId . '/items/batch', 'none', $req, $runtime));
    }

    /**
     * @param CreateSearchTabRequest $request
     *
     * @return CreateSearchTabResponse
     */
    public function createSearchTab($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSearchTabHeaders([]);

        return $this->createSearchTabWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateSearchTabRequest $request
     * @param CreateSearchTabHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return CreateSearchTabResponse
     */
    public function createSearchTabWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->darkIcon)) {
            @$body['darkIcon'] = $request->darkIcon;
        }
        if (!Utils::isUnset($request->icon)) {
            @$body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->priority)) {
            @$body['priority'] = $request->priority;
        }
        if (!Utils::isUnset($request->source)) {
            @$body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
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

        return CreateSearchTabResponse::fromMap($this->doROARequest('CreateSearchTab', 'search_1.0', 'HTTP', 'POST', 'AK', '/v1.0/search/tabs', 'json', $req, $runtime));
    }

    /**
     * @param string $tabId
     * @param string $itemId
     *
     * @return DeleteSearchItemResponse
     */
    public function deleteSearchItem($tabId, $itemId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSearchItemHeaders([]);

        return $this->deleteSearchItemWithOptions($tabId, $itemId, $headers, $runtime);
    }

    /**
     * @param string                  $tabId
     * @param string                  $itemId
     * @param DeleteSearchItemHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return DeleteSearchItemResponse
     */
    public function deleteSearchItemWithOptions($tabId, $itemId, $headers, $runtime)
    {
        $tabId       = OpenApiUtilClient::getEncodeParam($tabId);
        $itemId      = OpenApiUtilClient::getEncodeParam($itemId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return DeleteSearchItemResponse::fromMap($this->doROARequest('DeleteSearchItem', 'search_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/search/tabs/' . $tabId . '/items/' . $itemId . '', 'none', $req, $runtime));
    }

    /**
     * @param string $tabId
     *
     * @return DeleteSearchTabResponse
     */
    public function deleteSearchTab($tabId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSearchTabHeaders([]);

        return $this->deleteSearchTabWithOptions($tabId, $headers, $runtime);
    }

    /**
     * @param string                 $tabId
     * @param DeleteSearchTabHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return DeleteSearchTabResponse
     */
    public function deleteSearchTabWithOptions($tabId, $headers, $runtime)
    {
        $tabId       = OpenApiUtilClient::getEncodeParam($tabId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return DeleteSearchTabResponse::fromMap($this->doROARequest('DeleteSearchTab', 'search_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/search/tabs/' . $tabId . '', 'none', $req, $runtime));
    }

    /**
     * @param string $tabId
     * @param string $itemId
     *
     * @return GetSearchItemResponse
     */
    public function getSearchItem($tabId, $itemId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSearchItemHeaders([]);

        return $this->getSearchItemWithOptions($tabId, $itemId, $headers, $runtime);
    }

    /**
     * @param string               $tabId
     * @param string               $itemId
     * @param GetSearchItemHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetSearchItemResponse
     */
    public function getSearchItemWithOptions($tabId, $itemId, $headers, $runtime)
    {
        $tabId       = OpenApiUtilClient::getEncodeParam($tabId);
        $itemId      = OpenApiUtilClient::getEncodeParam($itemId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetSearchItemResponse::fromMap($this->doROARequest('GetSearchItem', 'search_1.0', 'HTTP', 'GET', 'AK', '/v1.0/search/tabs/' . $tabId . '/items/' . $itemId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                         $tabId
     * @param GetSearchItemsByKeyWordRequest $request
     *
     * @return GetSearchItemsByKeyWordResponse
     */
    public function getSearchItemsByKeyWord($tabId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSearchItemsByKeyWordHeaders([]);

        return $this->getSearchItemsByKeyWordWithOptions($tabId, $request, $headers, $runtime);
    }

    /**
     * @param string                         $tabId
     * @param GetSearchItemsByKeyWordRequest $request
     * @param GetSearchItemsByKeyWordHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return GetSearchItemsByKeyWordResponse
     */
    public function getSearchItemsByKeyWordWithOptions($tabId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $tabId = OpenApiUtilClient::getEncodeParam($tabId);
        $query = [];
        if (!Utils::isUnset($request->keyWord)) {
            @$query['keyWord'] = $request->keyWord;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
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

        return GetSearchItemsByKeyWordResponse::fromMap($this->doROARequest('GetSearchItemsByKeyWord', 'search_1.0', 'HTTP', 'GET', 'AK', '/v1.0/search/tabs/' . $tabId . '/items', 'json', $req, $runtime));
    }

    /**
     * @param string $tabId
     *
     * @return GetSearchTabResponse
     */
    public function getSearchTab($tabId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSearchTabHeaders([]);

        return $this->getSearchTabWithOptions($tabId, $headers, $runtime);
    }

    /**
     * @param string              $tabId
     * @param GetSearchTabHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetSearchTabResponse
     */
    public function getSearchTabWithOptions($tabId, $headers, $runtime)
    {
        $tabId       = OpenApiUtilClient::getEncodeParam($tabId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetSearchTabResponse::fromMap($this->doROARequest('GetSearchTab', 'search_1.0', 'HTTP', 'GET', 'AK', '/v1.0/search/tabs/' . $tabId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                  $tabId
     * @param InsertSearchItemRequest $request
     *
     * @return InsertSearchItemResponse
     */
    public function insertSearchItem($tabId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertSearchItemHeaders([]);

        return $this->insertSearchItemWithOptions($tabId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $tabId
     * @param InsertSearchItemRequest $request
     * @param InsertSearchItemHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return InsertSearchItemResponse
     */
    public function insertSearchItemWithOptions($tabId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $tabId = OpenApiUtilClient::getEncodeParam($tabId);
        $body  = [];
        if (!Utils::isUnset($request->footer)) {
            @$body['footer'] = $request->footer;
        }
        if (!Utils::isUnset($request->icon)) {
            @$body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->itemId)) {
            @$body['itemId'] = $request->itemId;
        }
        if (!Utils::isUnset($request->mobileUrl)) {
            @$body['mobileUrl'] = $request->mobileUrl;
        }
        if (!Utils::isUnset($request->pcUrl)) {
            @$body['pcUrl'] = $request->pcUrl;
        }
        if (!Utils::isUnset($request->summary)) {
            @$body['summary'] = $request->summary;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->url)) {
            @$body['url'] = $request->url;
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

        return InsertSearchItemResponse::fromMap($this->doROARequest('InsertSearchItem', 'search_1.0', 'HTTP', 'POST', 'AK', '/v1.0/search/tabs/' . $tabId . '/items', 'none', $req, $runtime));
    }

    /**
     * @return ListSearchTabsByOrgIdResponse
     */
    public function listSearchTabsByOrgId()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSearchTabsByOrgIdHeaders([]);

        return $this->listSearchTabsByOrgIdWithOptions($headers, $runtime);
    }

    /**
     * @param ListSearchTabsByOrgIdHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return ListSearchTabsByOrgIdResponse
     */
    public function listSearchTabsByOrgIdWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return ListSearchTabsByOrgIdResponse::fromMap($this->doROARequest('ListSearchTabsByOrgId', 'search_1.0', 'HTTP', 'GET', 'AK', '/v1.0/search/tabs', 'json', $req, $runtime));
    }

    /**
     * @param string                 $tabId
     * @param UpdateSearchTabRequest $request
     *
     * @return UpdateSearchTabResponse
     */
    public function updateSearchTab($tabId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateSearchTabHeaders([]);

        return $this->updateSearchTabWithOptions($tabId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $tabId
     * @param UpdateSearchTabRequest $request
     * @param UpdateSearchTabHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return UpdateSearchTabResponse
     */
    public function updateSearchTabWithOptions($tabId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $tabId = OpenApiUtilClient::getEncodeParam($tabId);
        $body  = [];
        if (!Utils::isUnset($request->darkIcon)) {
            @$body['darkIcon'] = $request->darkIcon;
        }
        if (!Utils::isUnset($request->icon)) {
            @$body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->priority)) {
            @$body['priority'] = $request->priority;
        }
        if (!Utils::isUnset($request->source)) {
            @$body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
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

        return UpdateSearchTabResponse::fromMap($this->doROARequest('UpdateSearchTab', 'search_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/search/tabs/' . $tabId . '', 'none', $req, $runtime));
    }
}
