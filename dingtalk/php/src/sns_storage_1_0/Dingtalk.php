<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetDentriesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetDentriesRequest;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetDentriesResponse;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetDentryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetDentryRequest;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetDentryResponse;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetDentryThumbnailsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetDentryThumbnailsRequest;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetDentryThumbnailsResponse;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetFileDownloadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetFileDownloadInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetFileDownloadInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\ListAllDentriesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\ListAllDentriesRequest;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\ListAllDentriesResponse;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\ListDentriesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\ListDentriesRequest;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\ListDentriesResponse;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\ListExpiredHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\ListExpiredRequest;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\ListExpiredResponse;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\SubscribeEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\SubscribeEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\SubscribeEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\UnsubscribeEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\UnsubscribeEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\UnsubscribeEventResponse;
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
     * @summary 三方个人应用批量获取文件或文件夹信息
     *  *
     * @param string             $spaceId
     * @param GetDentriesRequest $request GetDentriesRequest
     * @param GetDentriesHeaders $headers GetDentriesHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDentriesResponse GetDentriesResponse
     */
    public function getDentriesWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->dentryIds)) {
            $body['dentryIds'] = $request->dentryIds;
        }
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetDentries',
            'version'     => 'snsStorage_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/snsStorage/spaces/' . $spaceId . '/dentries/batchQuery',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDentriesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 三方个人应用批量获取文件或文件夹信息
     *  *
     * @param string             $spaceId
     * @param GetDentriesRequest $request GetDentriesRequest
     *
     * @return GetDentriesResponse GetDentriesResponse
     */
    public function getDentries($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDentriesHeaders([]);

        return $this->getDentriesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @summary 三方个人应用获取文件(夹)信息
     *  *
     * @param string           $spaceId
     * @param string           $dentryId
     * @param GetDentryRequest $request  GetDentryRequest
     * @param GetDentryHeaders $headers  GetDentryHeaders
     * @param RuntimeOptions   $runtime  runtime options for this request RuntimeOptions
     *
     * @return GetDentryResponse GetDentryResponse
     */
    public function getDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetDentry',
            'version'     => 'snsStorage_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/snsStorage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDentryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 三方个人应用获取文件(夹)信息
     *  *
     * @param string           $spaceId
     * @param string           $dentryId
     * @param GetDentryRequest $request  GetDentryRequest
     *
     * @return GetDentryResponse GetDentryResponse
     */
    public function getDentry($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDentryHeaders([]);

        return $this->getDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @summary 三方个人应用批量获取文件缩略图
     *  *
     * @param string                     $spaceId
     * @param GetDentryThumbnailsRequest $request GetDentryThumbnailsRequest
     * @param GetDentryThumbnailsHeaders $headers GetDentryThumbnailsHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDentryThumbnailsResponse GetDentryThumbnailsResponse
     */
    public function getDentryThumbnailsWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->dentryIds)) {
            $body['dentryIds'] = $request->dentryIds;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetDentryThumbnails',
            'version'     => 'snsStorage_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/snsStorage/spaces/' . $spaceId . '/thumbnails/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDentryThumbnailsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 三方个人应用批量获取文件缩略图
     *  *
     * @param string                     $spaceId
     * @param GetDentryThumbnailsRequest $request GetDentryThumbnailsRequest
     *
     * @return GetDentryThumbnailsResponse GetDentryThumbnailsResponse
     */
    public function getDentryThumbnails($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDentryThumbnailsHeaders([]);

        return $this->getDentryThumbnailsWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @summary 三方个人应用获取文件下载信息
     *  *
     * @param string                     $spaceId
     * @param string                     $dentryId
     * @param GetFileDownloadInfoRequest $request  GetFileDownloadInfoRequest
     * @param GetFileDownloadInfoHeaders $headers  GetFileDownloadInfoHeaders
     * @param RuntimeOptions             $runtime  runtime options for this request RuntimeOptions
     *
     * @return GetFileDownloadInfoResponse GetFileDownloadInfoResponse
     */
    public function getFileDownloadInfoWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetFileDownloadInfo',
            'version'     => 'snsStorage_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/snsStorage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/downloadInfos/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFileDownloadInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 三方个人应用获取文件下载信息
     *  *
     * @param string                     $spaceId
     * @param string                     $dentryId
     * @param GetFileDownloadInfoRequest $request  GetFileDownloadInfoRequest
     *
     * @return GetFileDownloadInfoResponse GetFileDownloadInfoResponse
     */
    public function getFileDownloadInfo($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFileDownloadInfoHeaders([]);

        return $this->getFileDownloadInfoWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @summary 三方个人应用获取IM会话存储空间信息
     *  *
     * @param GetSpaceRequest $request GetSpaceRequest
     * @param GetSpaceHeaders $headers GetSpaceHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSpaceResponse GetSpaceResponse
     */
    public function getSpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetSpace',
            'version'     => 'snsStorage_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/snsStorage/conversations/spaces/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 三方个人应用获取IM会话存储空间信息
     *  *
     * @param GetSpaceRequest $request GetSpaceRequest
     *
     * @return GetSpaceResponse GetSpaceResponse
     */
    public function getSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSpaceHeaders([]);

        return $this->getSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 三方个人应用获取全部文件或文件夹列表
     *  *
     * @param string                 $spaceId
     * @param ListAllDentriesRequest $request ListAllDentriesRequest
     * @param ListAllDentriesHeaders $headers ListAllDentriesHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ListAllDentriesResponse ListAllDentriesResponse
     */
    public function listAllDentriesWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ListAllDentries',
            'version'     => 'snsStorage_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/snsStorage/spaces/' . $spaceId . '/dentries/listAll',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListAllDentriesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 三方个人应用获取全部文件或文件夹列表
     *  *
     * @param string                 $spaceId
     * @param ListAllDentriesRequest $request ListAllDentriesRequest
     *
     * @return ListAllDentriesResponse ListAllDentriesResponse
     */
    public function listAllDentries($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAllDentriesHeaders([]);

        return $this->listAllDentriesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @summary 三方个人应用获取文件列表
     *  *
     * @param string              $spaceId
     * @param ListDentriesRequest $request ListDentriesRequest
     * @param ListDentriesHeaders $headers ListDentriesHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return ListDentriesResponse ListDentriesResponse
     */
    public function listDentriesWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->order)) {
            $query['order'] = $request->order;
        }
        if (!Utils::isUnset($request->orderBy)) {
            $query['orderBy'] = $request->orderBy;
        }
        if (!Utils::isUnset($request->parentId)) {
            $query['parentId'] = $request->parentId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        if (!Utils::isUnset($request->withThumbnail)) {
            $query['withThumbnail'] = $request->withThumbnail;
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
            'action'      => 'ListDentries',
            'version'     => 'snsStorage_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/snsStorage/spaces/' . $spaceId . '/dentries',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListDentriesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 三方个人应用获取文件列表
     *  *
     * @param string              $spaceId
     * @param ListDentriesRequest $request ListDentriesRequest
     *
     * @return ListDentriesResponse ListDentriesResponse
     */
    public function listDentries($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListDentriesHeaders([]);

        return $this->listDentriesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取会话过期文件列表
     *  *
     * @param ListExpiredRequest $request ListExpiredRequest
     * @param ListExpiredHeaders $headers ListExpiredHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return ListExpiredResponse ListExpiredResponse
     */
    public function listExpiredWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ListExpired',
            'version'     => 'snsStorage_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/snsStorage/conversations/expiredFileLists/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListExpiredResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取会话过期文件列表
     *  *
     * @param ListExpiredRequest $request ListExpiredRequest
     *
     * @return ListExpiredResponse ListExpiredResponse
     */
    public function listExpired($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListExpiredHeaders([]);

        return $this->listExpiredWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 三方个人应用订阅文件变更事件
     *  *
     * @param SubscribeEventRequest $request SubscribeEventRequest
     * @param SubscribeEventHeaders $headers SubscribeEventHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return SubscribeEventResponse SubscribeEventResponse
     */
    public function subscribeEventWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->scope)) {
            $body['scope'] = $request->scope;
        }
        if (!Utils::isUnset($request->scopeId)) {
            $body['scopeId'] = $request->scopeId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SubscribeEvent',
            'version'     => 'snsStorage_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/snsStorage/events/subscribe',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SubscribeEventResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 三方个人应用订阅文件变更事件
     *  *
     * @param SubscribeEventRequest $request SubscribeEventRequest
     *
     * @return SubscribeEventResponse SubscribeEventResponse
     */
    public function subscribeEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SubscribeEventHeaders([]);

        return $this->subscribeEventWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 三方个人应用取消订阅文件变更事件
     *  *
     * @param UnsubscribeEventRequest $request UnsubscribeEventRequest
     * @param UnsubscribeEventHeaders $headers UnsubscribeEventHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return UnsubscribeEventResponse UnsubscribeEventResponse
     */
    public function unsubscribeEventWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->scope)) {
            $body['scope'] = $request->scope;
        }
        if (!Utils::isUnset($request->scopeId)) {
            $body['scopeId'] = $request->scopeId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UnsubscribeEvent',
            'version'     => 'snsStorage_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/snsStorage/events/unsubscribe',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UnsubscribeEventResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 三方个人应用取消订阅文件变更事件
     *  *
     * @param UnsubscribeEventRequest $request UnsubscribeEventRequest
     *
     * @return UnsubscribeEventResponse UnsubscribeEventResponse
     */
    public function unsubscribeEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnsubscribeEventHeaders([]);

        return $this->unsubscribeEventWithOptions($request, $headers, $runtime);
    }
}
