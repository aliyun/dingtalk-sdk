<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\GetFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\GetFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\GetFeedResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\GetMediaCerficateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\GetMediaCerficateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\GetMediaCerficateResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\ListItemUserDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\ListItemUserDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\ListItemUserDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\PageFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\PageFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\PageFeedResponse;
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
     * @param CreateFeedRequest $request
     *
     * @return CreateFeedResponse
     */
    public function createFeed($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateFeedHeaders([]);

        return $this->createFeedWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateFeedRequest $request
     * @param CreateFeedHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return CreateFeedResponse
     */
    public function createFeedWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->courseInfo)) {
            @$body['courseInfo'] = $request->courseInfo;
        }
        if (!Utils::isUnset($request->createUserId)) {
            @$body['createUserId'] = $request->createUserId;
        }
        if (!Utils::isUnset($request->feedInfo)) {
            @$body['feedInfo'] = $request->feedInfo;
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

        return CreateFeedResponse::fromMap($this->doROARequest('CreateFeed', 'content_1.0', 'HTTP', 'POST', 'AK', '/v1.0/content/feeds', 'json', $req, $runtime));
    }

    /**
     * @param string         $feedId
     * @param GetFeedRequest $request
     *
     * @return GetFeedResponse
     */
    public function getFeed($feedId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFeedHeaders([]);

        return $this->getFeedWithOptions($feedId, $request, $headers, $runtime);
    }

    /**
     * @param string         $feedId
     * @param GetFeedRequest $request
     * @param GetFeedHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return GetFeedResponse
     */
    public function getFeedWithOptions($feedId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $feedId = OpenApiUtilClient::getEncodeParam($feedId);
        $query  = [];
        if (!Utils::isUnset($request->mcnId)) {
            @$query['mcnId'] = $request->mcnId;
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

        return GetFeedResponse::fromMap($this->doROARequest('GetFeed', 'content_1.0', 'HTTP', 'GET', 'AK', '/v1.0/content/feeds/' . $feedId . '', 'json', $req, $runtime));
    }

    /**
     * @param GetMediaCerficateRequest $request
     *
     * @return GetMediaCerficateResponse
     */
    public function getMediaCerficate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMediaCerficateHeaders([]);

        return $this->getMediaCerficateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetMediaCerficateRequest $request
     * @param GetMediaCerficateHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetMediaCerficateResponse
     */
    public function getMediaCerficateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->fileName)) {
            @$query['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->mcnId)) {
            @$query['mcnId'] = $request->mcnId;
        }
        if (!Utils::isUnset($request->mediaId)) {
            @$query['mediaId'] = $request->mediaId;
        }
        if (!Utils::isUnset($request->mediaIntroduction)) {
            @$query['mediaIntroduction'] = $request->mediaIntroduction;
        }
        if (!Utils::isUnset($request->mediaTitle)) {
            @$query['mediaTitle'] = $request->mediaTitle;
        }
        if (!Utils::isUnset($request->thumbUrl)) {
            @$query['thumbUrl'] = $request->thumbUrl;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
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

        return GetMediaCerficateResponse::fromMap($this->doROARequest('GetMediaCerficate', 'content_1.0', 'HTTP', 'GET', 'AK', '/v1.0/content/media/cerficates', 'json', $req, $runtime));
    }

    /**
     * @param string                  $itemId
     * @param ListItemUserDataRequest $request
     *
     * @return ListItemUserDataResponse
     */
    public function listItemUserData($itemId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListItemUserDataHeaders([]);

        return $this->listItemUserDataWithOptions($itemId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $itemId
     * @param ListItemUserDataRequest $request
     * @param ListItemUserDataHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ListItemUserDataResponse
     */
    public function listItemUserDataWithOptions($itemId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
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
            'body'    => $request->body,
        ]);

        return ListItemUserDataResponse::fromMap($this->doROARequest('ListItemUserData', 'content_1.0', 'HTTP', 'POST', 'AK', '/v1.0/content/feeds/items/' . $itemId . '/userStatistics/query', 'json', $req, $runtime));
    }

    /**
     * @param PageFeedRequest $request
     *
     * @return PageFeedResponse
     */
    public function pageFeed($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageFeedHeaders([]);

        return $this->pageFeedWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PageFeedRequest $request
     * @param PageFeedHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return PageFeedResponse
     */
    public function pageFeedWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->mcnId)) {
            @$query['mcnId'] = $request->mcnId;
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
            'body'    => $request->body,
        ]);

        return PageFeedResponse::fromMap($this->doROARequest('PageFeed', 'content_1.0', 'HTTP', 'POST', 'AK', '/v1.0/content/feeds/query', 'json', $req, $runtime));
    }
}
