<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CardTemplateBuildActionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CardTemplateBuildActionRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CardTemplateBuildActionResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ChatIdToOpenConversationIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ChatIdToOpenConversationIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetInterconnectionUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetInterconnectionUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetInterconnectionUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSceneGroupInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSceneGroupInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSceneGroupInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSceneGroupMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSceneGroupMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSceneGroupMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InteractiveCardCreateInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InteractiveCardCreateInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InteractiveCardCreateInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryMembersOfGroupRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryMembersOfGroupRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryMembersOfGroupRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendInteractiveCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendInteractiveCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendInteractiveCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendRobotInteractiveCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendRobotInteractiveCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendRobotInteractiveCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendTemplateInteractiveCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendTemplateInteractiveCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendTemplateInteractiveCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxCloseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxCloseRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxCloseResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxOpenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxOpenRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxOpenResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupPermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupPermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupPermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupSubAdminHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupSubAdminRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupSubAdminResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateInteractiveCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateInteractiveCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateInteractiveCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateMemberGroupNickHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateMemberGroupNickRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateMemberGroupNickResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateTheGroupRolesOfGroupMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateTheGroupRolesOfGroupMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateTheGroupRolesOfGroupMemberResponse;
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
     * @param TopboxCloseRequest $request
     *
     * @return TopboxCloseResponse
     */
    public function topboxClose($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TopboxCloseHeaders([]);

        return $this->topboxCloseWithOptions($request, $headers, $runtime);
    }

    /**
     * @param TopboxCloseRequest $request
     * @param TopboxCloseHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return TopboxCloseResponse
     */
    public function topboxCloseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            @$body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->coolAppCode)) {
            @$body['coolAppCode'] = $request->coolAppCode;
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

        return TopboxCloseResponse::fromMap($this->doROARequest('TopboxClose', 'im_1.0', 'HTTP', 'POST', 'AK', '/v1.0/im/topBoxes/close', 'none', $req, $runtime));
    }

    /**
     * @param UpdateInteractiveCardRequest $request
     *
     * @return UpdateInteractiveCardResponse
     */
    public function updateInteractiveCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInteractiveCardHeaders([]);

        return $this->updateInteractiveCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateInteractiveCardRequest $request
     * @param UpdateInteractiveCardHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return UpdateInteractiveCardResponse
     */
    public function updateInteractiveCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->outTrackId)) {
            @$body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->cardData)) {
            @$body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->privateData)) {
            @$body['privateData'] = $request->privateData;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->userIdType)) {
            @$body['userIdType'] = $request->userIdType;
        }
        if (!Utils::isUnset($request->cardOptions)) {
            @$body['cardOptions'] = $request->cardOptions;
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

        return UpdateInteractiveCardResponse::fromMap($this->doROARequest('UpdateInteractiveCard', 'im_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/im/interactiveCards', 'json', $req, $runtime));
    }

    /**
     * @param string $chatId
     *
     * @return ChatIdToOpenConversationIdResponse
     */
    public function chatIdToOpenConversationId($chatId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChatIdToOpenConversationIdHeaders([]);

        return $this->chatIdToOpenConversationIdWithOptions($chatId, $headers, $runtime);
    }

    /**
     * @param string                            $chatId
     * @param ChatIdToOpenConversationIdHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return ChatIdToOpenConversationIdResponse
     */
    public function chatIdToOpenConversationIdWithOptions($chatId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return ChatIdToOpenConversationIdResponse::fromMap($this->doROARequest('ChatIdToOpenConversationId', 'im_1.0', 'HTTP', 'POST', 'AK', '/v1.0/im/chat/' . $chatId . '/convertToOpenConversationId', 'json', $req, $runtime));
    }

    /**
     * @param UpdateGroupSubAdminRequest $request
     *
     * @return UpdateGroupSubAdminResponse
     */
    public function updateGroupSubAdmin($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGroupSubAdminHeaders([]);

        return $this->updateGroupSubAdminWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateGroupSubAdminRequest $request
     * @param UpdateGroupSubAdminHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return UpdateGroupSubAdminResponse
     */
    public function updateGroupSubAdminWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->dingClientId)) {
            @$body['dingClientId'] = $request->dingClientId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
        }
        if (!Utils::isUnset($request->role)) {
            @$body['role'] = $request->role;
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

        return UpdateGroupSubAdminResponse::fromMap($this->doROARequest('UpdateGroupSubAdmin', 'im_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/im/sceneGroups/subAdmins', 'json', $req, $runtime));
    }

    /**
     * @param QueryMembersOfGroupRoleRequest $request
     *
     * @return QueryMembersOfGroupRoleResponse
     */
    public function queryMembersOfGroupRole($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMembersOfGroupRoleHeaders([]);

        return $this->queryMembersOfGroupRoleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryMembersOfGroupRoleRequest $request
     * @param QueryMembersOfGroupRoleHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return QueryMembersOfGroupRoleResponse
     */
    public function queryMembersOfGroupRoleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openRoleId)) {
            @$body['openRoleId'] = $request->openRoleId;
        }
        if (!Utils::isUnset($request->timestamp)) {
            @$body['timestamp'] = $request->timestamp;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
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

        return QueryMembersOfGroupRoleResponse::fromMap($this->doROARequest('QueryMembersOfGroupRole', 'im_1.0', 'HTTP', 'POST', 'AK', '/v1.0/im/sceneGroups/roles/members/query', 'json', $req, $runtime));
    }

    /**
     * @param UpdateMemberGroupNickRequest $request
     *
     * @return UpdateMemberGroupNickResponse
     */
    public function updateMemberGroupNick($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateMemberGroupNickHeaders([]);

        return $this->updateMemberGroupNickWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateMemberGroupNickRequest $request
     * @param UpdateMemberGroupNickHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return UpdateMemberGroupNickResponse
     */
    public function updateMemberGroupNickWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->dingClientId)) {
            @$body['dingClientId'] = $request->dingClientId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->groupNick)) {
            @$body['groupNick'] = $request->groupNick;
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

        return UpdateMemberGroupNickResponse::fromMap($this->doROARequest('UpdateMemberGroupNick', 'im_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/im/sceneGroups/members/groupNicks', 'json', $req, $runtime));
    }

    /**
     * @param GetInterconnectionUrlRequest $request
     *
     * @return GetInterconnectionUrlResponse
     */
    public function getInterconnectionUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInterconnectionUrlHeaders([]);

        return $this->getInterconnectionUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetInterconnectionUrlRequest $request
     * @param GetInterconnectionUrlHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GetInterconnectionUrlResponse
     */
    public function getInterconnectionUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appUserId)) {
            @$body['appUserId'] = $request->appUserId;
        }
        if (!Utils::isUnset($request->appUserName)) {
            @$body['appUserName'] = $request->appUserName;
        }
        if (!Utils::isUnset($request->appUserAvatar)) {
            @$body['appUserAvatar'] = $request->appUserAvatar;
        }
        if (!Utils::isUnset($request->appUserAvatarType)) {
            @$body['appUserAvatarType'] = $request->appUserAvatarType;
        }
        if (!Utils::isUnset($request->appUserMobileNumber)) {
            @$body['appUserMobileNumber'] = $request->appUserMobileNumber;
        }
        if (!Utils::isUnset($request->qrCode)) {
            @$body['qrCode'] = $request->qrCode;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->msgPageType)) {
            @$body['msgPageType'] = $request->msgPageType;
        }
        if (!Utils::isUnset($request->sourceType)) {
            @$body['sourceType'] = $request->sourceType;
        }
        if (!Utils::isUnset($request->sourceCode)) {
            @$body['sourceCode'] = $request->sourceCode;
        }
        if (!Utils::isUnset($request->signature)) {
            @$body['signature'] = $request->signature;
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

        return GetInterconnectionUrlResponse::fromMap($this->doROARequest('GetInterconnectionUrl', 'im_1.0', 'HTTP', 'POST', 'AK', '/v1.0/im/interconnections/sessions/urls', 'json', $req, $runtime));
    }

    /**
     * @param SendTemplateInteractiveCardRequest $request
     *
     * @return SendTemplateInteractiveCardResponse
     */
    public function sendTemplateInteractiveCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendTemplateInteractiveCardHeaders([]);

        return $this->sendTemplateInteractiveCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendTemplateInteractiveCardRequest $request
     * @param SendTemplateInteractiveCardHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return SendTemplateInteractiveCardResponse
     */
    public function sendTemplateInteractiveCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            @$body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->singleChatReceiver)) {
            @$body['singleChatReceiver'] = $request->singleChatReceiver;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            @$body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->robotCode)) {
            @$body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->callbackUrl)) {
            @$body['callbackUrl'] = $request->callbackUrl;
        }
        if (!Utils::isUnset($request->cardData)) {
            @$body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->sendOptions)) {
            @$body['sendOptions'] = $request->sendOptions;
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

        return SendTemplateInteractiveCardResponse::fromMap($this->doROARequest('SendTemplateInteractiveCard', 'im_1.0', 'HTTP', 'POST', 'AK', '/v1.0/im/interactiveCards/templates/send', 'json', $req, $runtime));
    }

    /**
     * @param UpdateGroupPermissionRequest $request
     *
     * @return UpdateGroupPermissionResponse
     */
    public function updateGroupPermission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGroupPermissionHeaders([]);

        return $this->updateGroupPermissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateGroupPermissionRequest $request
     * @param UpdateGroupPermissionHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return UpdateGroupPermissionResponse
     */
    public function updateGroupPermissionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->permissionGroup)) {
            @$body['permissionGroup'] = $request->permissionGroup;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
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

        return UpdateGroupPermissionResponse::fromMap($this->doROARequest('UpdateGroupPermission', 'im_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/im/sceneGroups/permissions', 'json', $req, $runtime));
    }

    /**
     * @param SendInteractiveCardRequest $request
     *
     * @return SendInteractiveCardResponse
     */
    public function sendInteractiveCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendInteractiveCardHeaders([]);

        return $this->sendInteractiveCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendInteractiveCardRequest $request
     * @param SendInteractiveCardHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return SendInteractiveCardResponse
     */
    public function sendInteractiveCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            @$body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->receiverUserIdList)) {
            @$body['receiverUserIdList'] = $request->receiverUserIdList;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            @$body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->robotCode)) {
            @$body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->conversationType)) {
            @$body['conversationType'] = $request->conversationType;
        }
        if (!Utils::isUnset($request->callbackRouteKey)) {
            @$body['callbackRouteKey'] = $request->callbackRouteKey;
        }
        if (!Utils::isUnset($request->cardData)) {
            @$body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->privateData)) {
            @$body['privateData'] = $request->privateData;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->chatBotId)) {
            @$body['chatBotId'] = $request->chatBotId;
        }
        if (!Utils::isUnset($request->userIdType)) {
            @$body['userIdType'] = $request->userIdType;
        }
        if (!Utils::isUnset($request->atOpenIds)) {
            @$body['atOpenIds'] = $request->atOpenIds;
        }
        if (!Utils::isUnset($request->cardOptions)) {
            @$body['cardOptions'] = $request->cardOptions;
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

        return SendInteractiveCardResponse::fromMap($this->doROARequest('SendInteractiveCard', 'im_1.0', 'HTTP', 'POST', 'AK', '/v1.0/im/interactiveCards/send', 'json', $req, $runtime));
    }

    /**
     * @param GetSceneGroupInfoRequest $request
     *
     * @return GetSceneGroupInfoResponse
     */
    public function getSceneGroupInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSceneGroupInfoHeaders([]);

        return $this->getSceneGroupInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSceneGroupInfoRequest $request
     * @param GetSceneGroupInfoHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetSceneGroupInfoResponse
     */
    public function getSceneGroupInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->coolAppCode)) {
            @$body['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingClientId)) {
            @$body['dingClientId'] = $request->dingClientId;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
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

        return GetSceneGroupInfoResponse::fromMap($this->doROARequest('GetSceneGroupInfo', 'im_1.0', 'HTTP', 'POST', 'AK', '/v1.0/im/sceneGroups/query', 'json', $req, $runtime));
    }

    /**
     * @param InteractiveCardCreateInstanceRequest $request
     *
     * @return InteractiveCardCreateInstanceResponse
     */
    public function interactiveCardCreateInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InteractiveCardCreateInstanceHeaders([]);

        return $this->interactiveCardCreateInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param InteractiveCardCreateInstanceRequest $request
     * @param InteractiveCardCreateInstanceHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return InteractiveCardCreateInstanceResponse
     */
    public function interactiveCardCreateInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            @$body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->receiverUserIdList)) {
            @$body['receiverUserIdList'] = $request->receiverUserIdList;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            @$body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->robotCode)) {
            @$body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->conversationType)) {
            @$body['conversationType'] = $request->conversationType;
        }
        if (!Utils::isUnset($request->callbackRouteKey)) {
            @$body['callbackRouteKey'] = $request->callbackRouteKey;
        }
        if (!Utils::isUnset($request->cardData)) {
            @$body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->privateData)) {
            @$body['privateData'] = $request->privateData;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->chatBotId)) {
            @$body['chatBotId'] = $request->chatBotId;
        }
        if (!Utils::isUnset($request->userIdType)) {
            @$body['userIdType'] = $request->userIdType;
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

        return InteractiveCardCreateInstanceResponse::fromMap($this->doROARequest('InteractiveCardCreateInstance', 'im_1.0', 'HTTP', 'POST', 'AK', '/v1.0/im/interactiveCards/instances', 'json', $req, $runtime));
    }

    /**
     * @param TopboxOpenRequest $request
     *
     * @return TopboxOpenResponse
     */
    public function topboxOpen($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TopboxOpenHeaders([]);

        return $this->topboxOpenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param TopboxOpenRequest $request
     * @param TopboxOpenHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return TopboxOpenResponse
     */
    public function topboxOpenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            @$body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->expiredTime)) {
            @$body['expiredTime'] = $request->expiredTime;
        }
        if (!Utils::isUnset($request->platforms)) {
            @$body['platforms'] = $request->platforms;
        }
        if (!Utils::isUnset($request->coolAppCode)) {
            @$body['coolAppCode'] = $request->coolAppCode;
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

        return TopboxOpenResponse::fromMap($this->doROARequest('TopboxOpen', 'im_1.0', 'HTTP', 'POST', 'AK', '/v1.0/im/topBoxes/open', 'none', $req, $runtime));
    }

    /**
     * @param GetSceneGroupMembersRequest $request
     *
     * @return GetSceneGroupMembersResponse
     */
    public function getSceneGroupMembers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSceneGroupMembersHeaders([]);

        return $this->getSceneGroupMembersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSceneGroupMembersRequest $request
     * @param GetSceneGroupMembersHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetSceneGroupMembersResponse
     */
    public function getSceneGroupMembersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->coolAppCode)) {
            @$body['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->size)) {
            @$body['size'] = $request->size;
        }
        if (!Utils::isUnset($request->cursor)) {
            @$body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingClientId)) {
            @$body['dingClientId'] = $request->dingClientId;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
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

        return GetSceneGroupMembersResponse::fromMap($this->doROARequest('GetSceneGroupMembers', 'im_1.0', 'HTTP', 'POST', 'AK', '/v1.0/im/sceneGroups/members/query', 'json', $req, $runtime));
    }

    /**
     * @param UpdateTheGroupRolesOfGroupMemberRequest $request
     *
     * @return UpdateTheGroupRolesOfGroupMemberResponse
     */
    public function updateTheGroupRolesOfGroupMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTheGroupRolesOfGroupMemberHeaders([]);

        return $this->updateTheGroupRolesOfGroupMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateTheGroupRolesOfGroupMemberRequest $request
     * @param UpdateTheGroupRolesOfGroupMemberHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return UpdateTheGroupRolesOfGroupMemberResponse
     */
    public function updateTheGroupRolesOfGroupMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->openRoleIds)) {
            @$body['openRoleIds'] = $request->openRoleIds;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
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

        return UpdateTheGroupRolesOfGroupMemberResponse::fromMap($this->doROARequest('UpdateTheGroupRolesOfGroupMember', 'im_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/im/sceneGroups/members/groupRoles', 'json', $req, $runtime));
    }

    /**
     * @param CardTemplateBuildActionRequest $request
     *
     * @return CardTemplateBuildActionResponse
     */
    public function cardTemplateBuildAction($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CardTemplateBuildActionHeaders([]);

        return $this->cardTemplateBuildActionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CardTemplateBuildActionRequest $request
     * @param CardTemplateBuildActionHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CardTemplateBuildActionResponse
     */
    public function cardTemplateBuildActionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->action)) {
            @$body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->cardTemplateJson)) {
            @$body['cardTemplateJson'] = $request->cardTemplateJson;
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

        return CardTemplateBuildActionResponse::fromMap($this->doROARequest('CardTemplateBuildAction', 'im_1.0', 'HTTP', 'POST', 'AK', '/v1.0/im/interactiveCards/templates/buildAction', 'json', $req, $runtime));
    }

    /**
     * @param SendRobotInteractiveCardRequest $request
     *
     * @return SendRobotInteractiveCardResponse
     */
    public function sendRobotInteractiveCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendRobotInteractiveCardHeaders([]);

        return $this->sendRobotInteractiveCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendRobotInteractiveCardRequest $request
     * @param SendRobotInteractiveCardHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return SendRobotInteractiveCardResponse
     */
    public function sendRobotInteractiveCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->requestId)) {
            @$body['RequestId'] = $request->requestId;
        }
        if (!Utils::isUnset($request->dingAccessTokenType)) {
            @$body['dingAccessTokenType'] = $request->dingAccessTokenType;
        }
        if (!Utils::isUnset($request->dingClientId)) {
            @$body['dingClientId'] = $request->dingClientId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOpenAppId)) {
            @$body['dingOpenAppId'] = $request->dingOpenAppId;
        }
        if (!Utils::isUnset($request->dingUid)) {
            @$body['dingUid'] = $request->dingUid;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            @$body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->singleChatReceiver)) {
            @$body['singleChatReceiver'] = $request->singleChatReceiver;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->cardBizId)) {
            @$body['cardBizId'] = $request->cardBizId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->robotCode)) {
            @$body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->cardData)) {
            @$body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->dingOauthAppId)) {
            @$body['dingOauthAppId'] = $request->dingOauthAppId;
        }
        if (!Utils::isUnset($request->sendOptions)) {
            @$body['sendOptions'] = $request->sendOptions;
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

        return SendRobotInteractiveCardResponse::fromMap($this->doROARequest('SendRobotInteractiveCard', 'im_1.0', 'HTTP', 'POST', 'AK', '/v1.0/im/v1.0/robot/interactiveCards/send', 'json', $req, $runtime));
    }
}
