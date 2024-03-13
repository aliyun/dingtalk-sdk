<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\ReplyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\ReplyRequest;
use AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models\ReplyResponse;
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
}
