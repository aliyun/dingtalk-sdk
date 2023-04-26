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
            $body['courseInfo'] = $request->courseInfo;
        }
        if (!Utils::isUnset($request->createUserId)) {
            $body['createUserId'] = $request->createUserId;
        }
        if (!Utils::isUnset($request->feedInfo)) {
            $body['feedInfo'] = $request->feedInfo;
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
            'action'      => 'CreateFeed',
            'version'     => 'content_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/content/feeds',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateFeedResponse::fromMap($this->execute($params, $req, $runtime));
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
        $query = [];
        if (!Utils::isUnset($request->mcnId)) {
            $query['mcnId'] = $request->mcnId;
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
            'action'      => 'GetFeed',
            'version'     => 'content_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/content/feeds/' . $feedId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetFeedResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->mcnId)) {
            $query['mcnId'] = $request->mcnId;
        }
        if (!Utils::isUnset($request->mediaId)) {
            $query['mediaId'] = $request->mediaId;
        }
        if (!Utils::isUnset($request->mediaIntroduction)) {
            $query['mediaIntroduction'] = $request->mediaIntroduction;
        }
        if (!Utils::isUnset($request->mediaTitle)) {
            $query['mediaTitle'] = $request->mediaTitle;
        }
        if (!Utils::isUnset($request->thumbUrl)) {
            $query['thumbUrl'] = $request->thumbUrl;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
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
            'action'      => 'GetMediaCerficate',
            'version'     => 'content_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/content/media/cerficates',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetMediaCerficateResponse::fromMap($this->execute($params, $req, $runtime));
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
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => $request->body,
        ]);
        $params = new Params([
            'action'      => 'ListItemUserData',
            'version'     => 'content_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/content/feeds/items/' . $itemId . '/userStatistics/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ListItemUserDataResponse::fromMap($this->execute($params, $req, $runtime));
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
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->mcnId)) {
            $query['mcnId'] = $request->mcnId;
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
            'body'    => $request->body,
        ]);
        $params = new Params([
            'action'      => 'PageFeed',
            'version'     => 'content_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/content/feeds/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return PageFeedResponse::fromMap($this->execute($params, $req, $runtime));
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
}
