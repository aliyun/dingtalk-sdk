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
     * @param ApplyFollowerAuthInfoRequest $request
     *
     * @return ApplyFollowerAuthInfoResponse
     */
    public function applyFollowerAuthInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ApplyFollowerAuthInfoHeaders([]);

        return $this->applyFollowerAuthInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ApplyFollowerAuthInfoRequest $request
     * @param ApplyFollowerAuthInfoHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return ApplyFollowerAuthInfoResponse
     */
    public function applyFollowerAuthInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fieldScope)) {
            @$body['fieldScope'] = $request->fieldScope;
        }
        if (!Utils::isUnset($request->sessionId)) {
            @$body['sessionId'] = $request->sessionId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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

        return ApplyFollowerAuthInfoResponse::fromMap($this->doROARequest('ApplyFollowerAuthInfo', 'link_1.0', 'HTTP', 'POST', 'AK', '/v1.0/link/followers/authInfos/apply', 'json', $req, $runtime));
    }

    /**
     * @param CallbackRegiesterRequest $request
     *
     * @return CallbackRegiesterResponse
     */
    public function callbackRegiester($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CallbackRegiesterHeaders([]);

        return $this->callbackRegiesterWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CallbackRegiesterRequest $request
     * @param CallbackRegiesterHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return CallbackRegiesterResponse
     */
    public function callbackRegiesterWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->apiSecret)) {
            @$body['apiSecret'] = $request->apiSecret;
        }
        if (!Utils::isUnset($request->callbackKey)) {
            @$body['callbackKey'] = $request->callbackKey;
        }
        if (!Utils::isUnset($request->callbackUrl)) {
            @$body['callbackUrl'] = $request->callbackUrl;
        }
        if (!Utils::isUnset($request->type)) {
            @$body['type'] = $request->type;
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

        return CallbackRegiesterResponse::fromMap($this->doROARequest('CallbackRegiester', 'link_1.0', 'HTTP', 'POST', 'AK', '/v1.0/link/callbacks/regiester', 'json', $req, $runtime));
    }

    /**
     * @param CloseTopBoxInteractiveOTOMessageRequest $request
     *
     * @return CloseTopBoxInteractiveOTOMessageResponse
     */
    public function closeTopBoxInteractiveOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CloseTopBoxInteractiveOTOMessageHeaders([]);

        return $this->closeTopBoxInteractiveOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CloseTopBoxInteractiveOTOMessageRequest $request
     * @param CloseTopBoxInteractiveOTOMessageHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return CloseTopBoxInteractiveOTOMessageResponse
     */
    public function closeTopBoxInteractiveOTOMessageWithOptions($request, $headers, $runtime)
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

        return CloseTopBoxInteractiveOTOMessageResponse::fromMap($this->doROARequest('CloseTopBoxInteractiveOTOMessage', 'link_1.0', 'HTTP', 'POST', 'AK', '/v1.0/link/oToMessages/topBoxes/close', 'json', $req, $runtime));
    }

    /**
     * @param GetFollowerAuthInfoRequest $request
     *
     * @return GetFollowerAuthInfoResponse
     */
    public function getFollowerAuthInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFollowerAuthInfoHeaders([]);

        return $this->getFollowerAuthInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetFollowerAuthInfoRequest $request
     * @param GetFollowerAuthInfoHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetFollowerAuthInfoResponse
     */
    public function getFollowerAuthInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountId)) {
            @$query['accountId'] = $request->accountId;
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

        return GetFollowerAuthInfoResponse::fromMap($this->doROARequest('GetFollowerAuthInfo', 'link_1.0', 'HTTP', 'GET', 'AK', '/v1.0/link/followers/authInfos', 'json', $req, $runtime));
    }

    /**
     * @param GetFollowerInfoRequest $request
     *
     * @return GetFollowerInfoResponse
     */
    public function getFollowerInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFollowerInfoHeaders([]);

        return $this->getFollowerInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetFollowerInfoRequest $request
     * @param GetFollowerInfoHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetFollowerInfoResponse
     */
    public function getFollowerInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountId)) {
            @$query['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return GetFollowerInfoResponse::fromMap($this->doROARequest('GetFollowerInfo', 'link_1.0', 'HTTP', 'GET', 'AK', '/v1.0/link/followers/infos', 'json', $req, $runtime));
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
     * @param GetUserFollowStatusRequest $request
     *
     * @return GetUserFollowStatusResponse
     */
    public function getUserFollowStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserFollowStatusHeaders([]);

        return $this->getUserFollowStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetUserFollowStatusRequest $request
     * @param GetUserFollowStatusHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetUserFollowStatusResponse
     */
    public function getUserFollowStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountId)) {
            @$query['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return GetUserFollowStatusResponse::fromMap($this->doROARequest('GetUserFollowStatus', 'link_1.0', 'HTTP', 'GET', 'AK', '/v1.0/link/followers/statuses', 'json', $req, $runtime));
    }

    /**
     * @return ListAccountResponse
     */
    public function listAccount()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAccountHeaders([]);

        return $this->listAccountWithOptions($headers, $runtime);
    }

    /**
     * @param ListAccountHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return ListAccountResponse
     */
    public function listAccountWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return ListAccountResponse::fromMap($this->doROARequest('ListAccount', 'link_1.0', 'HTTP', 'GET', 'AK', '/v1.0/link/accounts', 'json', $req, $runtime));
    }

    /**
     * @return ListAccountInfoResponse
     */
    public function listAccountInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAccountInfoHeaders([]);

        return $this->listAccountInfoWithOptions($headers, $runtime);
    }

    /**
     * @param ListAccountInfoHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ListAccountInfoResponse
     */
    public function listAccountInfoWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return ListAccountInfoResponse::fromMap($this->doROARequest('ListAccountInfo', 'link_1.0', 'HTTP', 'GET', 'AK', '/v1.0/link/isv/accounts', 'json', $req, $runtime));
    }

    /**
     * @param ListFollowerRequest $request
     *
     * @return ListFollowerResponse
     */
    public function listFollower($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListFollowerHeaders([]);

        return $this->listFollowerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListFollowerRequest $request
     * @param ListFollowerHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return ListFollowerResponse
     */
    public function listFollowerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountId)) {
            @$query['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
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
        ]);

        return ListFollowerResponse::fromMap($this->doROARequest('ListFollower', 'link_1.0', 'HTTP', 'GET', 'AK', '/v1.0/link/followers', 'json', $req, $runtime));
    }

    /**
     * @param QueryUserFollowStatusRequest $request
     *
     * @return QueryUserFollowStatusResponse
     */
    public function queryUserFollowStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserFollowStatusHeaders([]);

        return $this->queryUserFollowStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryUserFollowStatusRequest $request
     * @param QueryUserFollowStatusHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return QueryUserFollowStatusResponse
     */
    public function queryUserFollowStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountId)) {
            @$query['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return QueryUserFollowStatusResponse::fromMap($this->doROARequest('QueryUserFollowStatus', 'link_1.0', 'HTTP', 'GET', 'AK', '/v1.0/link/isv/followers/statuses', 'json', $req, $runtime));
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
     * @param SendTopBoxInteractiveOTOMessageRequest $request
     *
     * @return SendTopBoxInteractiveOTOMessageResponse
     */
    public function sendTopBoxInteractiveOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendTopBoxInteractiveOTOMessageHeaders([]);

        return $this->sendTopBoxInteractiveOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendTopBoxInteractiveOTOMessageRequest $request
     * @param SendTopBoxInteractiveOTOMessageHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return SendTopBoxInteractiveOTOMessageResponse
     */
    public function sendTopBoxInteractiveOTOMessageWithOptions($request, $headers, $runtime)
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

        return SendTopBoxInteractiveOTOMessageResponse::fromMap($this->doROARequest('SendTopBoxInteractiveOTOMessage', 'link_1.0', 'HTTP', 'POST', 'AK', '/v1.0/link/oToMessages/topBoxes/send', 'json', $req, $runtime));
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

    /**
     * @param UpdateShortcutsRequest $request
     *
     * @return UpdateShortcutsResponse
     */
    public function updateShortcuts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateShortcutsHeaders([]);

        return $this->updateShortcutsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateShortcutsRequest $request
     * @param UpdateShortcutsHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return UpdateShortcutsResponse
     */
    public function updateShortcutsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->details)) {
            @$body['details'] = $request->details;
        }
        if (!Utils::isUnset($request->sessionId)) {
            @$body['sessionId'] = $request->sessionId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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

        return UpdateShortcutsResponse::fromMap($this->doROARequest('UpdateShortcuts', 'link_1.0', 'HTTP', 'POST', 'AK', '/v1.0/link/shortcuts', 'json', $req, $runtime));
    }
}
