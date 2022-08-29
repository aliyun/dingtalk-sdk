<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetPictureDownloadUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetPictureDownloadUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetPictureDownloadUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendInteractiveOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendInteractiveOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendInteractiveOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\UpdateInteractiveOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\UpdateInteractiveOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\UpdateInteractiveOTOMessageResponse;
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
     * @param GetPictureDownloadUrlRequest $request
     *
     * @return GetPictureDownloadUrlResponse
     */
    public function getPictureDownloadUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPictureDownloadUrlHeaders([]);

        return $this->getPictureDownloadUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetPictureDownloadUrlRequest $request
     * @param GetPictureDownloadUrlHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GetPictureDownloadUrlResponse
     */
    public function getPictureDownloadUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->downloadCode)) {
            @$query['downloadCode'] = $request->downloadCode;
        }
        if (!Utils::isUnset($request->sessionId)) {
            @$query['sessionId'] = $request->sessionId;
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

        return GetPictureDownloadUrlResponse::fromMap($this->doROARequest('GetPictureDownloadUrl', 'link_1.0', 'HTTP', 'GET', 'AK', '/v1.0/link/oToMessages/pictures/downloadUrls', 'json', $req, $runtime));
    }

    /**
     * @param SendAgentOTOMessageRequest $request
     *
     * @return SendAgentOTOMessageResponse
     */
    public function sendAgentOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendAgentOTOMessageHeaders([]);

        return $this->sendAgentOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendAgentOTOMessageRequest $request
     * @param SendAgentOTOMessageHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return SendAgentOTOMessageResponse
     */
    public function sendAgentOTOMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->detail)) {
            @$body['detail'] = $request->detail;
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

        return SendAgentOTOMessageResponse::fromMap($this->doROARequest('SendAgentOTOMessage', 'link_1.0', 'HTTP', 'POST', 'AK', '/v1.0/link/oToMessages/agentMessages', 'json', $req, $runtime));
    }

    /**
     * @param SendInteractiveOTOMessageRequest $request
     *
     * @return SendInteractiveOTOMessageResponse
     */
    public function sendInteractiveOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendInteractiveOTOMessageHeaders([]);

        return $this->sendInteractiveOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendInteractiveOTOMessageRequest $request
     * @param SendInteractiveOTOMessageHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return SendInteractiveOTOMessageResponse
     */
    public function sendInteractiveOTOMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->detail)) {
            @$body['detail'] = $request->detail;
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

        return SendInteractiveOTOMessageResponse::fromMap($this->doROARequest('SendInteractiveOTOMessage', 'link_1.0', 'HTTP', 'POST', 'AK', '/v1.0/link/oToMessages/interactiveMessages', 'json', $req, $runtime));
    }

    /**
     * @param UpdateInteractiveOTOMessageRequest $request
     *
     * @return UpdateInteractiveOTOMessageResponse
     */
    public function updateInteractiveOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInteractiveOTOMessageHeaders([]);

        return $this->updateInteractiveOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateInteractiveOTOMessageRequest $request
     * @param UpdateInteractiveOTOMessageHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return UpdateInteractiveOTOMessageResponse
     */
    public function updateInteractiveOTOMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->detail)) {
            @$body['detail'] = $request->detail;
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

        return UpdateInteractiveOTOMessageResponse::fromMap($this->doROARequest('UpdateInteractiveOTOMessage', 'link_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/link/oToMessages/interactiveMessages', 'json', $req, $runtime));
    }
}
