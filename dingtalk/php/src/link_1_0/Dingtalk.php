<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\ApplyFollowerAuthInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\ApplyFollowerAuthInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\ApplyFollowerAuthInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\CallbackRegiesterHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\CallbackRegiesterRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\CallbackRegiesterResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\CloseTopBoxInteractiveOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\CloseTopBoxInteractiveOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\CloseTopBoxInteractiveOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetFollowerAuthInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetFollowerAuthInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetFollowerAuthInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetFollowerInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetFollowerInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetFollowerInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetPictureDownloadUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetPictureDownloadUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetPictureDownloadUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetUserFollowStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetUserFollowStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetUserFollowStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\ListAccountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\ListAccountInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\ListAccountInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\ListAccountResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\ListFollowerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\ListFollowerRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\ListFollowerResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\QueryUserFollowStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\QueryUserFollowStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\QueryUserFollowStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendInteractiveOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendInteractiveOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendInteractiveOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendTopBoxInteractiveOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendTopBoxInteractiveOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendTopBoxInteractiveOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\UpdateInteractiveOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\UpdateInteractiveOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\UpdateInteractiveOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\UpdateShortcutsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\UpdateShortcutsRequest;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\UpdateShortcutsResponse;
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
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 发送用户授权信息申请
     *  *
     * @param ApplyFollowerAuthInfoRequest $request ApplyFollowerAuthInfoRequest
     * @param ApplyFollowerAuthInfoHeaders $headers ApplyFollowerAuthInfoHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return ApplyFollowerAuthInfoResponse ApplyFollowerAuthInfoResponse
     */
    public function applyFollowerAuthInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appAuthKey)) {
            $body['appAuthKey'] = $request->appAuthKey;
        }
        if (!Utils::isUnset($request->fieldScope)) {
            $body['fieldScope'] = $request->fieldScope;
        }
        if (!Utils::isUnset($request->sessionId)) {
            $body['sessionId'] = $request->sessionId;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action'      => 'ApplyFollowerAuthInfo',
            'version'     => 'link_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/link/followers/authInfos/apply',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ApplyFollowerAuthInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送用户授权信息申请
     *  *
     * @param ApplyFollowerAuthInfoRequest $request ApplyFollowerAuthInfoRequest
     *
     * @return ApplyFollowerAuthInfoResponse ApplyFollowerAuthInfoResponse
     */
    public function applyFollowerAuthInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ApplyFollowerAuthInfoHeaders([]);

        return $this->applyFollowerAuthInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 注册服务窗消息回调服务
     *  *
     * @param CallbackRegiesterRequest $request CallbackRegiesterRequest
     * @param CallbackRegiesterHeaders $headers CallbackRegiesterHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CallbackRegiesterResponse CallbackRegiesterResponse
     */
    public function callbackRegiesterWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->apiSecret)) {
            $body['apiSecret'] = $request->apiSecret;
        }
        if (!Utils::isUnset($request->callbackKey)) {
            $body['callbackKey'] = $request->callbackKey;
        }
        if (!Utils::isUnset($request->callbackUrl)) {
            $body['callbackUrl'] = $request->callbackUrl;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
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
            'action'      => 'CallbackRegiester',
            'version'     => 'link_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/link/callbacks/regiester',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CallbackRegiesterResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 注册服务窗消息回调服务
     *  *
     * @param CallbackRegiesterRequest $request CallbackRegiesterRequest
     *
     * @return CallbackRegiesterResponse CallbackRegiesterResponse
     */
    public function callbackRegiester($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CallbackRegiesterHeaders([]);

        return $this->callbackRegiesterWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务窗吊顶卡片关闭接口
     *  *
     * @param CloseTopBoxInteractiveOTOMessageRequest $request CloseTopBoxInteractiveOTOMessageRequest
     * @param CloseTopBoxInteractiveOTOMessageHeaders $headers CloseTopBoxInteractiveOTOMessageHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return CloseTopBoxInteractiveOTOMessageResponse CloseTopBoxInteractiveOTOMessageResponse
     */
    public function closeTopBoxInteractiveOTOMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->detail)) {
            $body['detail'] = $request->detail;
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
            'action'      => 'CloseTopBoxInteractiveOTOMessage',
            'version'     => 'link_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/link/oToMessages/topBoxes/close',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CloseTopBoxInteractiveOTOMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务窗吊顶卡片关闭接口
     *  *
     * @param CloseTopBoxInteractiveOTOMessageRequest $request CloseTopBoxInteractiveOTOMessageRequest
     *
     * @return CloseTopBoxInteractiveOTOMessageResponse CloseTopBoxInteractiveOTOMessageResponse
     */
    public function closeTopBoxInteractiveOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CloseTopBoxInteractiveOTOMessageHeaders([]);

        return $this->closeTopBoxInteractiveOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取用户授权信息
     *  *
     * @param GetFollowerAuthInfoRequest $request GetFollowerAuthInfoRequest
     * @param GetFollowerAuthInfoHeaders $headers GetFollowerAuthInfoHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFollowerAuthInfoResponse GetFollowerAuthInfoResponse
     */
    public function getFollowerAuthInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountId)) {
            $query['accountId'] = $request->accountId;
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
            'action'      => 'GetFollowerAuthInfo',
            'version'     => 'link_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/link/followers/authInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFollowerAuthInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户授权信息
     *  *
     * @param GetFollowerAuthInfoRequest $request GetFollowerAuthInfoRequest
     *
     * @return GetFollowerAuthInfoResponse GetFollowerAuthInfoResponse
     */
    public function getFollowerAuthInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFollowerAuthInfoHeaders([]);

        return $this->getFollowerAuthInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取服务窗关注人信息
     *  *
     * @param GetFollowerInfoRequest $request GetFollowerInfoRequest
     * @param GetFollowerInfoHeaders $headers GetFollowerInfoHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFollowerInfoResponse GetFollowerInfoResponse
     */
    public function getFollowerInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountId)) {
            $query['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'GetFollowerInfo',
            'version'     => 'link_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/link/followers/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFollowerInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取服务窗关注人信息
     *  *
     * @param GetFollowerInfoRequest $request GetFollowerInfoRequest
     *
     * @return GetFollowerInfoResponse GetFollowerInfoResponse
     */
    public function getFollowerInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFollowerInfoHeaders([]);

        return $this->getFollowerInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务窗图片消息下载地址获取接口
     *  *
     * @param GetPictureDownloadUrlRequest $request GetPictureDownloadUrlRequest
     * @param GetPictureDownloadUrlHeaders $headers GetPictureDownloadUrlHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPictureDownloadUrlResponse GetPictureDownloadUrlResponse
     */
    public function getPictureDownloadUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->downloadCode)) {
            $query['downloadCode'] = $request->downloadCode;
        }
        if (!Utils::isUnset($request->sessionId)) {
            $query['sessionId'] = $request->sessionId;
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
            'action'      => 'GetPictureDownloadUrl',
            'version'     => 'link_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/link/oToMessages/pictures/downloadUrls',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetPictureDownloadUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务窗图片消息下载地址获取接口
     *  *
     * @param GetPictureDownloadUrlRequest $request GetPictureDownloadUrlRequest
     *
     * @return GetPictureDownloadUrlResponse GetPictureDownloadUrlResponse
     */
    public function getPictureDownloadUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPictureDownloadUrlHeaders([]);

        return $this->getPictureDownloadUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取用户关注状态
     *  *
     * @param GetUserFollowStatusRequest $request GetUserFollowStatusRequest
     * @param GetUserFollowStatusHeaders $headers GetUserFollowStatusHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserFollowStatusResponse GetUserFollowStatusResponse
     */
    public function getUserFollowStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountId)) {
            $query['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'GetUserFollowStatus',
            'version'     => 'link_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/link/followers/statuses',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserFollowStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户关注状态
     *  *
     * @param GetUserFollowStatusRequest $request GetUserFollowStatusRequest
     *
     * @return GetUserFollowStatusResponse GetUserFollowStatusResponse
     */
    public function getUserFollowStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserFollowStatusHeaders([]);

        return $this->getUserFollowStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业下服务窗帐号列表
     *  *
     * @param ListAccountHeaders $headers ListAccountHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return ListAccountResponse ListAccountResponse
     */
    public function listAccountWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'ListAccount',
            'version'     => 'link_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/link/accounts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListAccountResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业下服务窗帐号列表
     *  *
     * @return ListAccountResponse ListAccountResponse
     */
    public function listAccount()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAccountHeaders([]);

        return $this->listAccountWithOptions($headers, $runtime);
    }

    /**
     * @summary 第三方企业应用查询服务窗帐号列表
     *  *
     * @param ListAccountInfoHeaders $headers ListAccountInfoHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ListAccountInfoResponse ListAccountInfoResponse
     */
    public function listAccountInfoWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'ListAccountInfo',
            'version'     => 'link_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/link/isv/accounts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListAccountInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 第三方企业应用查询服务窗帐号列表
     *  *
     * @return ListAccountInfoResponse ListAccountInfoResponse
     */
    public function listAccountInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAccountInfoHeaders([]);

        return $this->listAccountInfoWithOptions($headers, $runtime);
    }

    /**
     * @summary 批量获取服务窗关注人列表
     *  *
     * @param ListFollowerRequest $request ListFollowerRequest
     * @param ListFollowerHeaders $headers ListFollowerHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return ListFollowerResponse ListFollowerResponse
     */
    public function listFollowerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountId)) {
            $query['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
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
        ]);
        $params = new Params([
            'action'      => 'ListFollower',
            'version'     => 'link_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/link/followers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListFollowerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量获取服务窗关注人列表
     *  *
     * @param ListFollowerRequest $request ListFollowerRequest
     *
     * @return ListFollowerResponse ListFollowerResponse
     */
    public function listFollower($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListFollowerHeaders([]);

        return $this->listFollowerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 第三方企业应用查询用户是否关注服务窗
     *  *
     * @param QueryUserFollowStatusRequest $request QueryUserFollowStatusRequest
     * @param QueryUserFollowStatusHeaders $headers QueryUserFollowStatusHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserFollowStatusResponse QueryUserFollowStatusResponse
     */
    public function queryUserFollowStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountId)) {
            $query['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action'      => 'QueryUserFollowStatus',
            'version'     => 'link_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/link/isv/followers/statuses',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryUserFollowStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 第三方企业应用查询用户是否关注服务窗
     *  *
     * @param QueryUserFollowStatusRequest $request QueryUserFollowStatusRequest
     *
     * @return QueryUserFollowStatusResponse QueryUserFollowStatusResponse
     */
    public function queryUserFollowStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserFollowStatusHeaders([]);

        return $this->queryUserFollowStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送服务窗客服消息
     *  *
     * @param SendAgentOTOMessageRequest $request SendAgentOTOMessageRequest
     * @param SendAgentOTOMessageHeaders $headers SendAgentOTOMessageHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return SendAgentOTOMessageResponse SendAgentOTOMessageResponse
     */
    public function sendAgentOTOMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->detail)) {
            $body['detail'] = $request->detail;
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
            'action'      => 'SendAgentOTOMessage',
            'version'     => 'link_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/link/oToMessages/agentMessages',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendAgentOTOMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送服务窗客服消息
     *  *
     * @param SendAgentOTOMessageRequest $request SendAgentOTOMessageRequest
     *
     * @return SendAgentOTOMessageResponse SendAgentOTOMessageResponse
     */
    public function sendAgentOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendAgentOTOMessageHeaders([]);

        return $this->sendAgentOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务窗互动卡片单发接口
     *  *
     * @param SendInteractiveOTOMessageRequest $request SendInteractiveOTOMessageRequest
     * @param SendInteractiveOTOMessageHeaders $headers SendInteractiveOTOMessageHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return SendInteractiveOTOMessageResponse SendInteractiveOTOMessageResponse
     */
    public function sendInteractiveOTOMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->detail)) {
            $body['detail'] = $request->detail;
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
            'action'      => 'SendInteractiveOTOMessage',
            'version'     => 'link_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/link/oToMessages/interactiveMessages',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendInteractiveOTOMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务窗互动卡片单发接口
     *  *
     * @param SendInteractiveOTOMessageRequest $request SendInteractiveOTOMessageRequest
     *
     * @return SendInteractiveOTOMessageResponse SendInteractiveOTOMessageResponse
     */
    public function sendInteractiveOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendInteractiveOTOMessageHeaders([]);

        return $this->sendInteractiveOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务窗吊顶卡片发送接口
     *  *
     * @param SendTopBoxInteractiveOTOMessageRequest $request SendTopBoxInteractiveOTOMessageRequest
     * @param SendTopBoxInteractiveOTOMessageHeaders $headers SendTopBoxInteractiveOTOMessageHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return SendTopBoxInteractiveOTOMessageResponse SendTopBoxInteractiveOTOMessageResponse
     */
    public function sendTopBoxInteractiveOTOMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->detail)) {
            $body['detail'] = $request->detail;
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
            'action'      => 'SendTopBoxInteractiveOTOMessage',
            'version'     => 'link_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/link/oToMessages/topBoxes/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendTopBoxInteractiveOTOMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务窗吊顶卡片发送接口
     *  *
     * @param SendTopBoxInteractiveOTOMessageRequest $request SendTopBoxInteractiveOTOMessageRequest
     *
     * @return SendTopBoxInteractiveOTOMessageResponse SendTopBoxInteractiveOTOMessageResponse
     */
    public function sendTopBoxInteractiveOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendTopBoxInteractiveOTOMessageHeaders([]);

        return $this->sendTopBoxInteractiveOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务窗互动卡片修改接口
     *  *
     * @param UpdateInteractiveOTOMessageRequest $request UpdateInteractiveOTOMessageRequest
     * @param UpdateInteractiveOTOMessageHeaders $headers UpdateInteractiveOTOMessageHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateInteractiveOTOMessageResponse UpdateInteractiveOTOMessageResponse
     */
    public function updateInteractiveOTOMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->detail)) {
            $body['detail'] = $request->detail;
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
            'action'      => 'UpdateInteractiveOTOMessage',
            'version'     => 'link_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/link/oToMessages/interactiveMessages',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateInteractiveOTOMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务窗互动卡片修改接口
     *  *
     * @param UpdateInteractiveOTOMessageRequest $request UpdateInteractiveOTOMessageRequest
     *
     * @return UpdateInteractiveOTOMessageResponse UpdateInteractiveOTOMessageResponse
     */
    public function updateInteractiveOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInteractiveOTOMessageHeaders([]);

        return $this->updateInteractiveOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务窗会话窗口快捷栏配置接口
     *  *
     * @param UpdateShortcutsRequest $request UpdateShortcutsRequest
     * @param UpdateShortcutsHeaders $headers UpdateShortcutsHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateShortcutsResponse UpdateShortcutsResponse
     */
    public function updateShortcutsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->details)) {
            $body['details'] = $request->details;
        }
        if (!Utils::isUnset($request->sessionId)) {
            $body['sessionId'] = $request->sessionId;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action'      => 'UpdateShortcuts',
            'version'     => 'link_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/link/shortcuts',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateShortcutsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务窗会话窗口快捷栏配置接口
     *  *
     * @param UpdateShortcutsRequest $request UpdateShortcutsRequest
     *
     * @return UpdateShortcutsResponse UpdateShortcutsResponse
     */
    public function updateShortcuts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateShortcutsHeaders([]);

        return $this->updateShortcutsWithOptions($request, $headers, $runtime);
    }
}
