<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\GetMediaCerficateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\GetMediaCerficateRequest;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\GetMediaCerficateResponse;
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
        if (!Utils::isUnset($request->thumbUrl)) {
            @$query['thumbUrl'] = $request->thumbUrl;
        }
        if (!Utils::isUnset($request->fileName)) {
            @$query['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->mediaId)) {
            @$query['mediaId'] = $request->mediaId;
        }
        if (!Utils::isUnset($request->mediaTitle)) {
            @$query['mediaTitle'] = $request->mediaTitle;
        }
        if (!Utils::isUnset($request->mcnId)) {
            @$query['mcnId'] = $request->mcnId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->mediaIntroduction)) {
            @$query['mediaIntroduction'] = $request->mediaIntroduction;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetMediaCerficateResponse::fromMap($this->doROARequest('GetMediaCerficate', 'content_1.0', 'HTTP', 'GET', 'AK', '/v1.0/content/media/cerficates', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->feedInfo)) {
            @$body['feedInfo'] = $request->feedInfo;
        }
        if (!Utils::isUnset($request->createUserId)) {
            @$body['createUserId'] = $request->createUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateFeedResponse::fromMap($this->doROARequest('CreateFeed', 'content_1.0', 'HTTP', 'POST', 'AK', '/v1.0/content/feeds', 'json', $req, $runtime));
    }
}
