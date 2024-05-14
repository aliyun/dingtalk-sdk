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
     * @summary 为指定的数据源批量添加数据项
     *  *
     * @param string                       $tabId
     * @param BatchInsertSearchItemRequest $request BatchInsertSearchItemRequest
     * @param BatchInsertSearchItemHeaders $headers BatchInsertSearchItemHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchInsertSearchItemResponse BatchInsertSearchItemResponse
     */
    public function batchInsertSearchItemWithOptions($tabId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->searchItemModels)) {
            $body['searchItemModels'] = $request->searchItemModels;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BatchInsertSearchItem',
            'version'     => 'search_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/search/tabs/' . $tabId . '/items/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return BatchInsertSearchItemResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 为指定的数据源批量添加数据项
     *  *
     * @param string                       $tabId
     * @param BatchInsertSearchItemRequest $request BatchInsertSearchItemRequest
     *
     * @return BatchInsertSearchItemResponse BatchInsertSearchItemResponse
     */
    public function batchInsertSearchItem($tabId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchInsertSearchItemHeaders([]);

        return $this->batchInsertSearchItemWithOptions($tabId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建搜索数据源
     *  *
     * @param CreateSearchTabRequest $request CreateSearchTabRequest
     * @param CreateSearchTabHeaders $headers CreateSearchTabHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateSearchTabResponse CreateSearchTabResponse
     */
    public function createSearchTabWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->darkIcon)) {
            $body['darkIcon'] = $request->darkIcon;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->priority)) {
            $body['priority'] = $request->priority;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateSearchTab',
            'version'     => 'search_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/search/tabs',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateSearchTabResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建搜索数据源
     *  *
     * @param CreateSearchTabRequest $request CreateSearchTabRequest
     *
     * @return CreateSearchTabResponse CreateSearchTabResponse
     */
    public function createSearchTab($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSearchTabHeaders([]);

        return $this->createSearchTabWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 从指定的数据源中删除一条数据项
     *  *
     * @param string                  $tabId
     * @param string                  $itemId
     * @param DeleteSearchItemHeaders $headers DeleteSearchItemHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteSearchItemResponse DeleteSearchItemResponse
     */
    public function deleteSearchItemWithOptions($tabId, $itemId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'DeleteSearchItem',
            'version'     => 'search_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/search/tabs/' . $tabId . '/items/' . $itemId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeleteSearchItemResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 从指定的数据源中删除一条数据项
     *  *
     * @param string $tabId
     * @param string $itemId
     *
     * @return DeleteSearchItemResponse DeleteSearchItemResponse
     */
    public function deleteSearchItem($tabId, $itemId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSearchItemHeaders([]);

        return $this->deleteSearchItemWithOptions($tabId, $itemId, $headers, $runtime);
    }

    /**
     * @summary 删除搜索数据源
     *  *
     * @param string                 $tabId
     * @param DeleteSearchTabHeaders $headers DeleteSearchTabHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteSearchTabResponse DeleteSearchTabResponse
     */
    public function deleteSearchTabWithOptions($tabId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'DeleteSearchTab',
            'version'     => 'search_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/search/tabs/' . $tabId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeleteSearchTabResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除搜索数据源
     *  *
     * @param string $tabId
     *
     * @return DeleteSearchTabResponse DeleteSearchTabResponse
     */
    public function deleteSearchTab($tabId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSearchTabHeaders([]);

        return $this->deleteSearchTabWithOptions($tabId, $headers, $runtime);
    }

    /**
     * @summary 获取指定数据源中的一条数据项
     *  *
     * @param string               $tabId
     * @param string               $itemId
     * @param GetSearchItemHeaders $headers GetSearchItemHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSearchItemResponse GetSearchItemResponse
     */
    public function getSearchItemWithOptions($tabId, $itemId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetSearchItem',
            'version'     => 'search_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/search/tabs/' . $tabId . '/items/' . $itemId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSearchItemResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取指定数据源中的一条数据项
     *  *
     * @param string $tabId
     * @param string $itemId
     *
     * @return GetSearchItemResponse GetSearchItemResponse
     */
    public function getSearchItem($tabId, $itemId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSearchItemHeaders([]);

        return $this->getSearchItemWithOptions($tabId, $itemId, $headers, $runtime);
    }

    /**
     * @summary 根据搜索关键词获取相关数据项
     *  *
     * @param string                         $tabId
     * @param GetSearchItemsByKeyWordRequest $request GetSearchItemsByKeyWordRequest
     * @param GetSearchItemsByKeyWordHeaders $headers GetSearchItemsByKeyWordHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSearchItemsByKeyWordResponse GetSearchItemsByKeyWordResponse
     */
    public function getSearchItemsByKeyWordWithOptions($tabId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->keyWord)) {
            $query['keyWord'] = $request->keyWord;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
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
            'action'      => 'GetSearchItemsByKeyWord',
            'version'     => 'search_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/search/tabs/' . $tabId . '/items',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSearchItemsByKeyWordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据搜索关键词获取相关数据项
     *  *
     * @param string                         $tabId
     * @param GetSearchItemsByKeyWordRequest $request GetSearchItemsByKeyWordRequest
     *
     * @return GetSearchItemsByKeyWordResponse GetSearchItemsByKeyWordResponse
     */
    public function getSearchItemsByKeyWord($tabId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSearchItemsByKeyWordHeaders([]);

        return $this->getSearchItemsByKeyWordWithOptions($tabId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取搜索数据源
     *  *
     * @param string              $tabId
     * @param GetSearchTabHeaders $headers GetSearchTabHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSearchTabResponse GetSearchTabResponse
     */
    public function getSearchTabWithOptions($tabId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetSearchTab',
            'version'     => 'search_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/search/tabs/' . $tabId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSearchTabResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取搜索数据源
     *  *
     * @param string $tabId
     *
     * @return GetSearchTabResponse GetSearchTabResponse
     */
    public function getSearchTab($tabId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSearchTabHeaders([]);

        return $this->getSearchTabWithOptions($tabId, $headers, $runtime);
    }

    /**
     * @summary 为指定的数据源添加一条数据项
     *  *
     * @param string                  $tabId
     * @param InsertSearchItemRequest $request InsertSearchItemRequest
     * @param InsertSearchItemHeaders $headers InsertSearchItemHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return InsertSearchItemResponse InsertSearchItemResponse
     */
    public function insertSearchItemWithOptions($tabId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->footer)) {
            $body['footer'] = $request->footer;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->itemId)) {
            $body['itemId'] = $request->itemId;
        }
        if (!Utils::isUnset($request->mobileUrl)) {
            $body['mobileUrl'] = $request->mobileUrl;
        }
        if (!Utils::isUnset($request->pcUrl)) {
            $body['pcUrl'] = $request->pcUrl;
        }
        if (!Utils::isUnset($request->summary)) {
            $body['summary'] = $request->summary;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->url)) {
            $body['url'] = $request->url;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'InsertSearchItem',
            'version'     => 'search_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/search/tabs/' . $tabId . '/items',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return InsertSearchItemResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 为指定的数据源添加一条数据项
     *  *
     * @param string                  $tabId
     * @param InsertSearchItemRequest $request InsertSearchItemRequest
     *
     * @return InsertSearchItemResponse InsertSearchItemResponse
     */
    public function insertSearchItem($tabId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertSearchItemHeaders([]);

        return $this->insertSearchItemWithOptions($tabId, $request, $headers, $runtime);
    }

    /**
     * @summary 列出企业所有的搜索数据源
     *  *
     * @param ListSearchTabsByOrgIdHeaders $headers ListSearchTabsByOrgIdHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return ListSearchTabsByOrgIdResponse ListSearchTabsByOrgIdResponse
     */
    public function listSearchTabsByOrgIdWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'ListSearchTabsByOrgId',
            'version'     => 'search_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/search/tabs',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListSearchTabsByOrgIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 列出企业所有的搜索数据源
     *  *
     * @return ListSearchTabsByOrgIdResponse ListSearchTabsByOrgIdResponse
     */
    public function listSearchTabsByOrgId()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSearchTabsByOrgIdHeaders([]);

        return $this->listSearchTabsByOrgIdWithOptions($headers, $runtime);
    }

    /**
     * @summary 更新搜索数据源
     *  *
     * @param string                 $tabId
     * @param UpdateSearchTabRequest $request UpdateSearchTabRequest
     * @param UpdateSearchTabHeaders $headers UpdateSearchTabHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateSearchTabResponse UpdateSearchTabResponse
     */
    public function updateSearchTabWithOptions($tabId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->darkIcon)) {
            $body['darkIcon'] = $request->darkIcon;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->priority)) {
            $body['priority'] = $request->priority;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateSearchTab',
            'version'     => 'search_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/search/tabs/' . $tabId . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return UpdateSearchTabResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新搜索数据源
     *  *
     * @param string                 $tabId
     * @param UpdateSearchTabRequest $request UpdateSearchTabRequest
     *
     * @return UpdateSearchTabResponse UpdateSearchTabResponse
     */
    public function updateSearchTab($tabId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateSearchTabHeaders([]);

        return $this->updateSearchTabWithOptions($tabId, $request, $headers, $runtime);
    }
}
