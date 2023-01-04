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
     * @param string             $spaceId
     * @param GetDentriesRequest $request
     *
     * @return GetDentriesResponse
     */
    public function getDentries($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDentriesHeaders([]);

        return $this->getDentriesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string             $spaceId
     * @param GetDentriesRequest $request
     * @param GetDentriesHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetDentriesResponse
     */
    public function getDentriesWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->dentryIds)) {
            @$body['dentryIds'] = $request->dentryIds;
        }
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetDentriesResponse::fromMap($this->doROARequest('GetDentries', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/snsStorage/spaces/' . $spaceId . '/dentries/batchQuery', 'json', $req, $runtime));
    }

    /**
     * @param string           $spaceId
     * @param string           $dentryId
     * @param GetDentryRequest $request
     *
     * @return GetDentryResponse
     */
    public function getDentry($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDentryHeaders([]);

        return $this->getDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string           $spaceId
     * @param string           $dentryId
     * @param GetDentryRequest $request
     * @param GetDentryHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return GetDentryResponse
     */
    public function getDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetDentryResponse::fromMap($this->doROARequest('GetDentry', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/snsStorage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/query', 'json', $req, $runtime));
    }

    /**
     * @param string                     $spaceId
     * @param GetDentryThumbnailsRequest $request
     *
     * @return GetDentryThumbnailsResponse
     */
    public function getDentryThumbnails($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDentryThumbnailsHeaders([]);

        return $this->getDentryThumbnailsWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $spaceId
     * @param GetDentryThumbnailsRequest $request
     * @param GetDentryThumbnailsHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetDentryThumbnailsResponse
     */
    public function getDentryThumbnailsWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->dentryIds)) {
            @$body['dentryIds'] = $request->dentryIds;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetDentryThumbnailsResponse::fromMap($this->doROARequest('GetDentryThumbnails', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/snsStorage/spaces/' . $spaceId . '/thumbnails/query', 'json', $req, $runtime));
    }

    /**
     * @param string                     $spaceId
     * @param string                     $dentryId
     * @param GetFileDownloadInfoRequest $request
     *
     * @return GetFileDownloadInfoResponse
     */
    public function getFileDownloadInfo($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFileDownloadInfoHeaders([]);

        return $this->getFileDownloadInfoWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $spaceId
     * @param string                     $dentryId
     * @param GetFileDownloadInfoRequest $request
     * @param GetFileDownloadInfoHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetFileDownloadInfoResponse
     */
    public function getFileDownloadInfoWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetFileDownloadInfoResponse::fromMap($this->doROARequest('GetFileDownloadInfo', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/snsStorage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/downloadInfos/query', 'json', $req, $runtime));
    }

    /**
     * @param GetSpaceRequest $request
     *
     * @return GetSpaceResponse
     */
    public function getSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSpaceHeaders([]);

        return $this->getSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSpaceRequest $request
     * @param GetSpaceHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return GetSpaceResponse
     */
    public function getSpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetSpaceResponse::fromMap($this->doROARequest('GetSpace', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/snsStorage/conversations/spaces/query', 'json', $req, $runtime));
    }

    /**
     * @param string                 $spaceId
     * @param ListAllDentriesRequest $request
     *
     * @return ListAllDentriesResponse
     */
    public function listAllDentries($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAllDentriesHeaders([]);

        return $this->listAllDentriesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $spaceId
     * @param ListAllDentriesRequest $request
     * @param ListAllDentriesHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ListAllDentriesResponse
     */
    public function listAllDentriesWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ListAllDentriesResponse::fromMap($this->doROARequest('ListAllDentries', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/snsStorage/spaces/' . $spaceId . '/dentries/listAll', 'json', $req, $runtime));
    }

    /**
     * @param string              $spaceId
     * @param ListDentriesRequest $request
     *
     * @return ListDentriesResponse
     */
    public function listDentries($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListDentriesHeaders([]);

        return $this->listDentriesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string              $spaceId
     * @param ListDentriesRequest $request
     * @param ListDentriesHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return ListDentriesResponse
     */
    public function listDentriesWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->order)) {
            @$query['order'] = $request->order;
        }
        if (!Utils::isUnset($request->orderBy)) {
            @$query['orderBy'] = $request->orderBy;
        }
        if (!Utils::isUnset($request->parentId)) {
            @$query['parentId'] = $request->parentId;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        if (!Utils::isUnset($request->withThumbnail)) {
            @$query['withThumbnail'] = $request->withThumbnail;
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

        return ListDentriesResponse::fromMap($this->doROARequest('ListDentries', 'snsStorage_1.0', 'HTTP', 'GET', 'AK', '/v1.0/snsStorage/spaces/' . $spaceId . '/dentries', 'json', $req, $runtime));
    }

    /**
     * @param ListExpiredRequest $request
     *
     * @return ListExpiredResponse
     */
    public function listExpired($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListExpiredHeaders([]);

        return $this->listExpiredWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListExpiredRequest $request
     * @param ListExpiredHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return ListExpiredResponse
     */
    public function listExpiredWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ListExpiredResponse::fromMap($this->doROARequest('ListExpired', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/snsStorage/conversations/expiredFileLists/query', 'json', $req, $runtime));
    }

    /**
     * @param SubscribeEventRequest $request
     *
     * @return SubscribeEventResponse
     */
    public function subscribeEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SubscribeEventHeaders([]);

        return $this->subscribeEventWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SubscribeEventRequest $request
     * @param SubscribeEventHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SubscribeEventResponse
     */
    public function subscribeEventWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->scope)) {
            @$body['scope'] = $request->scope;
        }
        if (!Utils::isUnset($request->scopeId)) {
            @$body['scopeId'] = $request->scopeId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SubscribeEventResponse::fromMap($this->doROARequest('SubscribeEvent', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/snsStorage/events/subscribe', 'json', $req, $runtime));
    }

    /**
     * @param UnsubscribeEventRequest $request
     *
     * @return UnsubscribeEventResponse
     */
    public function unsubscribeEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnsubscribeEventHeaders([]);

        return $this->unsubscribeEventWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UnsubscribeEventRequest $request
     * @param UnsubscribeEventHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return UnsubscribeEventResponse
     */
    public function unsubscribeEventWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->scope)) {
            @$body['scope'] = $request->scope;
        }
        if (!Utils::isUnset($request->scopeId)) {
            @$body['scopeId'] = $request->scopeId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UnsubscribeEventResponse::fromMap($this->doROARequest('UnsubscribeEvent', 'snsStorage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/snsStorage/events/unsubscribe', 'json', $req, $runtime));
    }
}
