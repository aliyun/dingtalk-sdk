<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\GetSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\GetSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\GetSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\SendByAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\SendByAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\SendByAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\SendHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\SendLinkHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\SendLinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\SendLinkResponse;
use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\SendRequest;
use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\SendResponse;
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
     * @summary 获取IM会话存储空间信息
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
            'version'     => 'convFile_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/convFile/conversations/spaces/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取IM会话存储空间信息
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
     * @summary 发送文件到指定会话
     *  *
     * @param SendRequest    $request SendRequest
     * @param SendHeaders    $headers SendHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return SendResponse SendResponse
     */
    public function sendWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->dentryId)) {
            $body['dentryId'] = $request->dentryId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->spaceId)) {
            $body['spaceId'] = $request->spaceId;
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
            'action'      => 'Send',
            'version'     => 'convFile_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/convFile/conversations/files/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送文件到指定会话
     *  *
     * @param SendRequest $request SendRequest
     *
     * @return SendResponse SendResponse
     */
    public function send($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendHeaders([]);

        return $this->sendWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 以应用身份发送文件给自己
     *  *
     * @param SendByAppRequest $request SendByAppRequest
     * @param SendByAppHeaders $headers SendByAppHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return SendByAppResponse SendByAppResponse
     */
    public function sendByAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->dentryId)) {
            $body['dentryId'] = $request->dentryId;
        }
        if (!Utils::isUnset($request->spaceId)) {
            $body['spaceId'] = $request->spaceId;
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
            'action'      => 'SendByApp',
            'version'     => 'convFile_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/convFile/apps/conversations/files/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendByAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 以应用身份发送文件给自己
     *  *
     * @param SendByAppRequest $request SendByAppRequest
     *
     * @return SendByAppResponse SendByAppResponse
     */
    public function sendByApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendByAppHeaders([]);

        return $this->sendByAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送文件链接到指定会话
     *  *
     * @param SendLinkRequest $request SendLinkRequest
     * @param SendLinkHeaders $headers SendLinkHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return SendLinkResponse SendLinkResponse
     */
    public function sendLinkWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->dentryId)) {
            $body['dentryId'] = $request->dentryId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->spaceId)) {
            $body['spaceId'] = $request->spaceId;
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
            'action'      => 'SendLink',
            'version'     => 'convFile_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/convFile/conversations/files/links/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendLinkResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送文件链接到指定会话
     *  *
     * @param SendLinkRequest $request SendLinkRequest
     *
     * @return SendLinkResponse SendLinkResponse
     */
    public function sendLink($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendLinkHeaders([]);

        return $this->sendLinkWithOptions($request, $headers, $runtime);
    }
}
