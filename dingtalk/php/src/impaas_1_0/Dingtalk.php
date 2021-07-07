<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\AddProfileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\AddProfileRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\AddProfileResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetConversationIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetConversationIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetConversationIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetMediaUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetMediaUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetMediaUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\ReadMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\ReadMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\ReadMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\RecallMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\RecallMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\RecallMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\SendMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\SendMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\SendMessageResponse;
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
     * @param GetConversationIdRequest $request
     *
     * @return GetConversationIdResponse
     */
    public function getConversationId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConversationIdHeaders([]);

        return $this->getConversationIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetConversationIdRequest $request
     * @param GetConversationIdHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetConversationIdResponse
     */
    public function getConversationIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->appUid)) {
            @$body['appUid'] = $request->appUid;
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

        return GetConversationIdResponse::fromMap($this->doROARequest('GetConversationId', 'impaas_1.0', 'HTTP', 'POST', 'AK', '/v1.0/impaas/interconnections/conversations', 'json', $req, $runtime));
    }

    /**
     * @param RecallMessageRequest $request
     *
     * @return RecallMessageResponse
     */
    public function recallMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RecallMessageHeaders([]);

        return $this->recallMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RecallMessageRequest $request
     * @param RecallMessageHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return RecallMessageResponse
     */
    public function recallMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operatorUid)) {
            @$body['operatorUid'] = $request->operatorUid;
        }
        if (!Utils::isUnset($request->messageId)) {
            @$body['messageId'] = $request->messageId;
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

        return RecallMessageResponse::fromMap($this->doROARequest('RecallMessage', 'impaas_1.0', 'HTTP', 'POST', 'AK', '/v1.0/impaas/interconnections/messages/recall', 'none', $req, $runtime));
    }

    /**
     * @param GetMediaUrlRequest $request
     *
     * @return GetMediaUrlResponse
     */
    public function getMediaUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMediaUrlHeaders([]);

        return $this->getMediaUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetMediaUrlRequest $request
     * @param GetMediaUrlHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetMediaUrlResponse
     */
    public function getMediaUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->mediaId)) {
            @$body['mediaId'] = $request->mediaId;
        }
        if (!Utils::isUnset($request->urlExpireTime)) {
            @$body['urlExpireTime'] = $request->urlExpireTime;
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

        return GetMediaUrlResponse::fromMap($this->doROARequest('GetMediaUrl', 'impaas_1.0', 'HTTP', 'POST', 'AK', '/v1.0/impaas/interconnections/medium/urls', 'json', $req, $runtime));
    }

    /**
     * @param ReadMessageRequest $request
     *
     * @return ReadMessageResponse
     */
    public function readMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReadMessageHeaders([]);

        return $this->readMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReadMessageRequest $request
     * @param ReadMessageHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return ReadMessageResponse
     */
    public function readMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operatorUid)) {
            @$body['operatorUid'] = $request->operatorUid;
        }
        if (!Utils::isUnset($request->messageId)) {
            @$body['messageId'] = $request->messageId;
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

        return ReadMessageResponse::fromMap($this->doROARequest('ReadMessage', 'impaas_1.0', 'HTTP', 'POST', 'AK', '/v1.0/impaas/interconnections/messages/read', 'none', $req, $runtime));
    }

    /**
     * @param AddProfileRequest $request
     *
     * @return AddProfileResponse
     */
    public function addProfile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddProfileHeaders([]);

        return $this->addProfileWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddProfileRequest $request
     * @param AddProfileHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return AddProfileResponse
     */
    public function addProfileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->nick)) {
            @$body['nick'] = $request->nick;
        }
        if (!Utils::isUnset($request->avatarMediaId)) {
            @$body['avatarMediaId'] = $request->avatarMediaId;
        }
        if (!Utils::isUnset($request->appUid)) {
            @$body['appUid'] = $request->appUid;
        }
        if (!Utils::isUnset($request->mobileNumber)) {
            @$body['mobileNumber'] = $request->mobileNumber;
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

        return AddProfileResponse::fromMap($this->doROARequest('AddProfile', 'impaas_1.0', 'HTTP', 'POST', 'AK', '/v1.0/impaas/interconnections/users/profiles', 'none', $req, $runtime));
    }

    /**
     * @param SendMessageRequest $request
     *
     * @return SendMessageResponse
     */
    public function sendMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendMessageHeaders([]);

        return $this->sendMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendMessageRequest $request
     * @param SendMessageHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return SendMessageResponse
     */
    public function sendMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->senderUid)) {
            @$body['senderUid'] = $request->senderUid;
        }
        if (!Utils::isUnset($request->receiverUid)) {
            @$body['receiverUid'] = $request->receiverUid;
        }
        if (!Utils::isUnset($request->conversationId)) {
            @$body['conversationId'] = $request->conversationId;
        }
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->uuid)) {
            @$body['uuid'] = $request->uuid;
        }
        if (!Utils::isUnset($request->createTime)) {
            @$body['createTime'] = $request->createTime;
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

        return SendMessageResponse::fromMap($this->doROARequest('SendMessage', 'impaas_1.0', 'HTTP', 'POST', 'AK', '/v1.0/impaas/interconnections/messages/send', 'json', $req, $runtime));
    }
}
