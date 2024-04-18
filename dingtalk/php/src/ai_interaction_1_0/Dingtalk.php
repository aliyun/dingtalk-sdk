<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\FinishHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\FinishRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\FinishResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\PrepareHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\PrepareRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\PrepareResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\ReplyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\ReplyRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\ReplyResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\SendHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\SendRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\SendResponse;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\UpdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\UpdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\UpdateResponse;
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
     * @param FinishRequest  $request
     * @param FinishHeaders  $headers
     * @param RuntimeOptions $runtime
     *
     * @return FinishResponse
     */
    public function finishWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conversationToken)) {
            $body['conversationToken'] = $request->conversationToken;
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
            'action'      => 'Finish',
            'version'     => 'aiInteraction_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/aiInteraction/finish',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return FinishResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param FinishRequest $request
     *
     * @return FinishResponse
     */
    public function finish($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FinishHeaders([]);

        return $this->finishWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PrepareRequest $request
     * @param PrepareHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return PrepareResponse
     */
    public function prepareWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->contentType)) {
            $body['contentType'] = $request->contentType;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'Prepare',
            'version'     => 'aiInteraction_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/aiInteraction/prepare',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PrepareResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PrepareRequest $request
     *
     * @return PrepareResponse
     */
    public function prepare($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PrepareHeaders([]);

        return $this->prepareWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReplyRequest   $request
     * @param ReplyHeaders   $headers
     * @param RuntimeOptions $runtime
     *
     * @return ReplyResponse
     */
    public function replyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->contentType)) {
            $body['contentType'] = $request->contentType;
        }
        if (!Utils::isUnset($request->conversationToken)) {
            $body['conversationToken'] = $request->conversationToken;
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
            'action'      => 'Reply',
            'version'     => 'aiInteraction_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/aiInteraction/reply',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ReplyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ReplyRequest $request
     *
     * @return ReplyResponse
     */
    public function reply($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReplyHeaders([]);

        return $this->replyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendRequest    $request
     * @param SendHeaders    $headers
     * @param RuntimeOptions $runtime
     *
     * @return SendResponse
     */
    public function sendWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->contentType)) {
            $body['contentType'] = $request->contentType;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'Send',
            'version'     => 'aiInteraction_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/aiInteraction/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SendRequest $request
     *
     * @return SendResponse
     */
    public function send($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendHeaders([]);

        return $this->sendWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateRequest  $request
     * @param UpdateHeaders  $headers
     * @param RuntimeOptions $runtime
     *
     * @return UpdateResponse
     */
    public function updateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->contentType)) {
            $body['contentType'] = $request->contentType;
        }
        if (!Utils::isUnset($request->conversationToken)) {
            $body['conversationToken'] = $request->conversationToken;
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
            'action'      => 'Update',
            'version'     => 'aiInteraction_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/aiInteraction/update',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateRequest $request
     *
     * @return UpdateResponse
     */
    public function update($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateHeaders([]);

        return $this->updateWithOptions($request, $headers, $runtime);
    }
}
