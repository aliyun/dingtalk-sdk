<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\AddGroupMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\AddGroupMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\AddGroupMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\AddOrgTextEmotionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\AddOrgTextEmotionRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\AddOrgTextEmotionResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\AddRobotToConversationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\AddRobotToConversationRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\AddRobotToConversationResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\AutoOpenDingTalkConnectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\AutoOpenDingTalkConnectResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\BatchQueryFamilySchoolMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\BatchQueryFamilySchoolMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\BatchQueryFamilySchoolMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\BatchQueryGroupMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\BatchQueryGroupMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\BatchQueryGroupMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CardTemplateBuildActionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CardTemplateBuildActionRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CardTemplateBuildActionResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ChangeGroupOwnerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ChangeGroupOwnerRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ChangeGroupOwnerResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ChatIdToOpenConversationIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ChatIdToOpenConversationIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ChatSubAdminUpdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ChatSubAdminUpdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ChatSubAdminUpdateResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CheckUserIsGroupMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CheckUserIsGroupMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CheckUserIsGroupMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateCoupleGroupConversationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateCoupleGroupConversationRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateCoupleGroupConversationResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateGroupConversationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateGroupConversationRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateGroupConversationResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateInterconnectionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateInterconnectionRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateInterconnectionResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateSceneGroupConversationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateSceneGroupConversationRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateSceneGroupConversationResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateStoreGroupConversationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateStoreGroupConversationRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateStoreGroupConversationResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\DeleteOrgTextEmotionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\DeleteOrgTextEmotionRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\DeleteOrgTextEmotionResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\DismissGroupConversationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\DismissGroupConversationRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\DismissGroupConversationResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetConversationUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetConversationUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetConversationUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetFamilySchoolConversationMsgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetFamilySchoolConversationMsgRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetFamilySchoolConversationMsgResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetFamilySchoolConversationsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetFamilySchoolConversationsRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetFamilySchoolConversationsResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetInnerGroupMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetInnerGroupMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetInnerGroupMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetInterconnectionUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetInterconnectionUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetInterconnectionUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetNewestInnerGroupsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetNewestInnerGroupsRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetNewestInnerGroupsResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSceneGroupInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSceneGroupInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSceneGroupInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSceneGroupMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSceneGroupMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSceneGroupMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupBanWordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupBanWordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupBanWordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupCapacityInquiryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupCapacityInquiryRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupCapacityInquiryResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupCapacityOrderConfirmHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupCapacityOrderConfirmRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupCapacityOrderConfirmResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupCapacityOrderPlaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupCapacityOrderPlaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupCapacityOrderPlaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupManageQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupManageQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupManageQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupManageReduceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupManageReduceRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GroupManageReduceResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InstallRobotToOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InstallRobotToOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InstallRobotToOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InteractiveCardCreateInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InteractiveCardCreateInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InteractiveCardCreateInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListOrgTextEmotionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListOrgTextEmotionResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupInfoByMemberAuthHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupInfoByMemberAuthRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupInfoByMemberAuthResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberByMemberAuthHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberByMemberAuthRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberByMemberAuthResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMuteStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMuteStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMuteStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryMembersOfGroupRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryMembersOfGroupRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryMembersOfGroupRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QuerySceneGroupTemplateRobotHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QuerySceneGroupTemplateRobotRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QuerySceneGroupTemplateRobotResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QuerySingleGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QuerySingleGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QuerySingleGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUnReadMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUnReadMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUnReadMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\RemoveGroupMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\RemoveGroupMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\RemoveGroupMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\RemoveRobotFromConversationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\RemoveRobotFromConversationRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\RemoveRobotFromConversationResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SearchInnerGroupsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SearchInnerGroupsRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SearchInnerGroupsResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendDingMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendDingMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendDingMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendInteractiveCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendInteractiveCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendInteractiveCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendOTOInteractiveCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendOTOInteractiveCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendOTOInteractiveCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendRobotInteractiveCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendRobotInteractiveCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendRobotInteractiveCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendRobotMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendRobotMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendRobotMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendTemplateInteractiveCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendTemplateInteractiveCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendTemplateInteractiveCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SetRightPanelHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SetRightPanelRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SetRightPanelResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxCloseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxCloseRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxCloseResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxOpenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxOpenRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxOpenResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupAvatarHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupAvatarRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupAvatarResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupNameHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupNameRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupNameResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupPermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupPermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupPermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupSubAdminHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupSubAdminRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateGroupSubAdminResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateInteractiveCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateInteractiveCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateInteractiveCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateMemberBanWordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateMemberBanWordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateMemberBanWordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateMemberGroupNickHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateMemberGroupNickRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateMemberGroupNickResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateRobotInOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateRobotInOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateRobotInOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateRobotInteractiveCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateRobotInteractiveCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateRobotInteractiveCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateTheGroupRolesOfGroupMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateTheGroupRolesOfGroupMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateTheGroupRolesOfGroupMemberResponse;
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
     * @param AddOrgTextEmotionRequest $request
     * @param AddOrgTextEmotionHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return AddOrgTextEmotionResponse
     */
    public function addOrgTextEmotionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->backgroundMediaId)) {
            $body['backgroundMediaId'] = $request->backgroundMediaId;
        }
        if (!Utils::isUnset($request->backgroundMediaIdForPanel)) {
            $body['backgroundMediaIdForPanel'] = $request->backgroundMediaIdForPanel;
        }
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->emotionName)) {
            $body['emotionName'] = $request->emotionName;
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
            'action'      => 'AddOrgTextEmotion',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/organizations/textEmotions',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddOrgTextEmotionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddOrgTextEmotionRequest $request
     *
     * @return AddOrgTextEmotionResponse
     */
    public function addOrgTextEmotion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddOrgTextEmotionHeaders([]);

        return $this->addOrgTextEmotionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddRobotToConversationRequest $request
     * @param AddRobotToConversationHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return AddRobotToConversationResponse
     */
    public function addRobotToConversationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'AddRobotToConversation',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/conversations/robots',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddRobotToConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddRobotToConversationRequest $request
     *
     * @return AddRobotToConversationResponse
     */
    public function addRobotToConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddRobotToConversationHeaders([]);

        return $this->addRobotToConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AutoOpenDingTalkConnectHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return AutoOpenDingTalkConnectResponse
     */
    public function autoOpenDingTalkConnectWithOptions($headers, $runtime)
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
            'action'      => 'AutoOpenDingTalkConnect',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/apps/open',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AutoOpenDingTalkConnectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return AutoOpenDingTalkConnectResponse
     */
    public function autoOpenDingTalkConnect()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AutoOpenDingTalkConnectHeaders([]);

        return $this->autoOpenDingTalkConnectWithOptions($headers, $runtime);
    }

    /**
     * @param BatchQueryFamilySchoolMessageRequest $request
     * @param BatchQueryFamilySchoolMessageHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return BatchQueryFamilySchoolMessageResponse
     */
    public function batchQueryFamilySchoolMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openMessageIds)) {
            $body['openMessageIds'] = $request->openMessageIds;
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
            'action'      => 'BatchQueryFamilySchoolMessage',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/conversations/familySchools/messages/batchQuery',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchQueryFamilySchoolMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchQueryFamilySchoolMessageRequest $request
     *
     * @return BatchQueryFamilySchoolMessageResponse
     */
    public function batchQueryFamilySchoolMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchQueryFamilySchoolMessageHeaders([]);

        return $this->batchQueryFamilySchoolMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchQueryGroupMemberRequest $request
     * @param BatchQueryGroupMemberHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return BatchQueryGroupMemberResponse
     */
    public function batchQueryGroupMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coolAppCode)) {
            $body['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BatchQueryGroupMember',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/sceneGroups/members/batchQuery',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchQueryGroupMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchQueryGroupMemberRequest $request
     *
     * @return BatchQueryGroupMemberResponse
     */
    public function batchQueryGroupMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchQueryGroupMemberHeaders([]);

        return $this->batchQueryGroupMemberWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->cardTemplateJson)) {
            $body['cardTemplateJson'] = $request->cardTemplateJson;
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
            'action'      => 'CardTemplateBuildAction',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interactiveCards/templates/buildAction',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CardTemplateBuildActionResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param ChangeGroupOwnerRequest $request
     * @param ChangeGroupOwnerHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ChangeGroupOwnerResponse
     */
    public function changeGroupOwnerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupOwnerId)) {
            $body['groupOwnerId'] = $request->groupOwnerId;
        }
        if (!Utils::isUnset($request->groupOwnerType)) {
            $body['groupOwnerType'] = $request->groupOwnerType;
        }
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ChangeGroupOwner',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/groups/owners',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ChangeGroupOwnerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ChangeGroupOwnerRequest $request
     *
     * @return ChangeGroupOwnerResponse
     */
    public function changeGroupOwner($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChangeGroupOwnerHeaders([]);

        return $this->changeGroupOwnerWithOptions($request, $headers, $runtime);
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
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'ChatIdToOpenConversationId',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/chat/' . $chatId . '/convertToOpenConversationId',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ChatIdToOpenConversationIdResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param ChatSubAdminUpdateRequest $request
     * @param ChatSubAdminUpdateHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return ChatSubAdminUpdateResponse
     */
    public function chatSubAdminUpdateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->role)) {
            $body['role'] = $request->role;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
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
            'action'      => 'ChatSubAdminUpdate',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/subAdministrators',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ChatSubAdminUpdateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ChatSubAdminUpdateRequest $request
     *
     * @return ChatSubAdminUpdateResponse
     */
    public function chatSubAdminUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChatSubAdminUpdateHeaders([]);

        return $this->chatSubAdminUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CheckUserIsGroupMemberRequest $request
     * @param CheckUserIsGroupMemberHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CheckUserIsGroupMemberResponse
     */
    public function checkUserIsGroupMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
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
            'action'      => 'CheckUserIsGroupMember',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/innerGroups/members/check',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CheckUserIsGroupMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CheckUserIsGroupMemberRequest $request
     *
     * @return CheckUserIsGroupMemberResponse
     */
    public function checkUserIsGroupMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckUserIsGroupMemberHeaders([]);

        return $this->checkUserIsGroupMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateCoupleGroupConversationRequest $request
     * @param CreateCoupleGroupConversationHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return CreateCoupleGroupConversationResponse
     */
    public function createCoupleGroupConversationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appUserId)) {
            $body['appUserId'] = $request->appUserId;
        }
        if (!Utils::isUnset($request->groupAvatar)) {
            $body['groupAvatar'] = $request->groupAvatar;
        }
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->groupOwnerId)) {
            $body['groupOwnerId'] = $request->groupOwnerId;
        }
        if (!Utils::isUnset($request->groupTemplateId)) {
            $body['groupTemplateId'] = $request->groupTemplateId;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'action'      => 'CreateCoupleGroupConversation',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/coupleGroups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateCoupleGroupConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateCoupleGroupConversationRequest $request
     *
     * @return CreateCoupleGroupConversationResponse
     */
    public function createCoupleGroupConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCoupleGroupConversationHeaders([]);

        return $this->createCoupleGroupConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateGroupConversationRequest $request
     * @param CreateGroupConversationHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CreateGroupConversationResponse
     */
    public function createGroupConversationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appUserIds)) {
            $body['appUserIds'] = $request->appUserIds;
        }
        if (!Utils::isUnset($request->groupAvatar)) {
            $body['groupAvatar'] = $request->groupAvatar;
        }
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->groupOwnerId)) {
            $body['groupOwnerId'] = $request->groupOwnerId;
        }
        if (!Utils::isUnset($request->groupOwnerType)) {
            $body['groupOwnerType'] = $request->groupOwnerType;
        }
        if (!Utils::isUnset($request->groupTemplateId)) {
            $body['groupTemplateId'] = $request->groupTemplateId;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
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
            'action'      => 'CreateGroupConversation',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/groups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateGroupConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateGroupConversationRequest $request
     *
     * @return CreateGroupConversationResponse
     */
    public function createGroupConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateGroupConversationHeaders([]);

        return $this->createGroupConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateInterconnectionRequest $request
     * @param CreateInterconnectionHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return CreateInterconnectionResponse
     */
    public function createInterconnectionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->interconnections)) {
            $body['interconnections'] = $request->interconnections;
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
            'action'      => 'CreateInterconnection',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateInterconnectionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateInterconnectionRequest $request
     *
     * @return CreateInterconnectionResponse
     */
    public function createInterconnection($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateInterconnectionHeaders([]);

        return $this->createInterconnectionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateSceneGroupConversationRequest $request
     * @param CreateSceneGroupConversationHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return CreateSceneGroupConversationResponse
     */
    public function createSceneGroupConversationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->features)) {
            $body['features'] = $request->features;
        }
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->groupOwnerId)) {
            $body['groupOwnerId'] = $request->groupOwnerId;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->managementOptions)) {
            $body['managementOptions'] = $request->managementOptions;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->userIdList)) {
            $body['userIdList'] = $request->userIdList;
        }
        if (!Utils::isUnset($request->uuid)) {
            $body['uuid'] = $request->uuid;
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
            'action'      => 'CreateSceneGroupConversation',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/sceneGroups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateSceneGroupConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateSceneGroupConversationRequest $request
     *
     * @return CreateSceneGroupConversationResponse
     */
    public function createSceneGroupConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSceneGroupConversationHeaders([]);

        return $this->createSceneGroupConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateStoreGroupConversationRequest $request
     * @param CreateStoreGroupConversationHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return CreateStoreGroupConversationResponse
     */
    public function createStoreGroupConversationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appUserId)) {
            $body['appUserId'] = $request->appUserId;
        }
        if (!Utils::isUnset($request->businessUniqueKey)) {
            $body['businessUniqueKey'] = $request->businessUniqueKey;
        }
        if (!Utils::isUnset($request->groupAvatar)) {
            $body['groupAvatar'] = $request->groupAvatar;
        }
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->groupTemplateId)) {
            $body['groupTemplateId'] = $request->groupTemplateId;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
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
            'action'      => 'CreateStoreGroupConversation',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/storeGroups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateStoreGroupConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateStoreGroupConversationRequest $request
     *
     * @return CreateStoreGroupConversationResponse
     */
    public function createStoreGroupConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateStoreGroupConversationHeaders([]);

        return $this->createStoreGroupConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteOrgTextEmotionRequest $request
     * @param DeleteOrgTextEmotionHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return DeleteOrgTextEmotionResponse
     */
    public function deleteOrgTextEmotionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->emotionIds)) {
            $body['emotionIds'] = $request->emotionIds;
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
            'action'      => 'DeleteOrgTextEmotion',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/organizations/textEmotions/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteOrgTextEmotionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteOrgTextEmotionRequest $request
     *
     * @return DeleteOrgTextEmotionResponse
     */
    public function deleteOrgTextEmotion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteOrgTextEmotionHeaders([]);

        return $this->deleteOrgTextEmotionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DismissGroupConversationRequest $request
     * @param DismissGroupConversationHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return DismissGroupConversationResponse
     */
    public function dismissGroupConversationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DismissGroupConversation',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/groups/dismiss',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DismissGroupConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DismissGroupConversationRequest $request
     *
     * @return DismissGroupConversationResponse
     */
    public function dismissGroupConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DismissGroupConversationHeaders([]);

        return $this->dismissGroupConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetConversationUrlRequest $request
     * @param GetConversationUrlHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetConversationUrlResponse
     */
    public function getConversationUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appUserId)) {
            $body['appUserId'] = $request->appUserId;
        }
        if (!Utils::isUnset($request->channelCode)) {
            $body['channelCode'] = $request->channelCode;
        }
        if (!Utils::isUnset($request->deviceId)) {
            $body['deviceId'] = $request->deviceId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
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
            'action'      => 'GetConversationUrl',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/conversations/urls',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetConversationUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetConversationUrlRequest $request
     *
     * @return GetConversationUrlResponse
     */
    public function getConversationUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConversationUrlHeaders([]);

        return $this->getConversationUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetFamilySchoolConversationMsgRequest $request
     * @param GetFamilySchoolConversationMsgHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return GetFamilySchoolConversationMsgResponse
     */
    public function getFamilySchoolConversationMsgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->msgTypes)) {
            $body['msgTypes'] = $request->msgTypes;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
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
            'action'      => 'GetFamilySchoolConversationMsg',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/conversations/familySchools/messages/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFamilySchoolConversationMsgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetFamilySchoolConversationMsgRequest $request
     *
     * @return GetFamilySchoolConversationMsgResponse
     */
    public function getFamilySchoolConversationMsg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFamilySchoolConversationMsgHeaders([]);

        return $this->getFamilySchoolConversationMsgWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetFamilySchoolConversationsRequest $request
     * @param GetFamilySchoolConversationsHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return GetFamilySchoolConversationsResponse
     */
    public function getFamilySchoolConversationsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
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
            'action'      => 'GetFamilySchoolConversations',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/conversations/familySchools/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFamilySchoolConversationsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetFamilySchoolConversationsRequest $request
     *
     * @return GetFamilySchoolConversationsResponse
     */
    public function getFamilySchoolConversations($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFamilySchoolConversationsHeaders([]);

        return $this->getFamilySchoolConversationsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetInnerGroupMembersRequest $request
     * @param GetInnerGroupMembersHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetInnerGroupMembersResponse
     */
    public function getInnerGroupMembersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
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
            'action'      => 'GetInnerGroupMembers',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/innerGroups/members/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetInnerGroupMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetInnerGroupMembersRequest $request
     *
     * @return GetInnerGroupMembersResponse
     */
    public function getInnerGroupMembers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInnerGroupMembersHeaders([]);

        return $this->getInnerGroupMembersWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->appUserAvatar)) {
            $body['appUserAvatar'] = $request->appUserAvatar;
        }
        if (!Utils::isUnset($request->appUserAvatarType)) {
            $body['appUserAvatarType'] = $request->appUserAvatarType;
        }
        if (!Utils::isUnset($request->appUserId)) {
            $body['appUserId'] = $request->appUserId;
        }
        if (!Utils::isUnset($request->appUserMobileNumber)) {
            $body['appUserMobileNumber'] = $request->appUserMobileNumber;
        }
        if (!Utils::isUnset($request->appUserName)) {
            $body['appUserName'] = $request->appUserName;
        }
        if (!Utils::isUnset($request->msgPageType)) {
            $body['msgPageType'] = $request->msgPageType;
        }
        if (!Utils::isUnset($request->qrCode)) {
            $body['qrCode'] = $request->qrCode;
        }
        if (!Utils::isUnset($request->signature)) {
            $body['signature'] = $request->signature;
        }
        if (!Utils::isUnset($request->sourceCode)) {
            $body['sourceCode'] = $request->sourceCode;
        }
        if (!Utils::isUnset($request->sourceType)) {
            $body['sourceType'] = $request->sourceType;
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
            'action'      => 'GetInterconnectionUrl',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/sessions/urls',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetInterconnectionUrlResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param GetNewestInnerGroupsRequest $request
     * @param GetNewestInnerGroupsHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetNewestInnerGroupsResponse
     */
    public function getNewestInnerGroupsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'action'      => 'GetNewestInnerGroups',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/activities/innerGroups',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetNewestInnerGroupsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetNewestInnerGroupsRequest $request
     *
     * @return GetNewestInnerGroupsResponse
     */
    public function getNewestInnerGroups($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetNewestInnerGroupsHeaders([]);

        return $this->getNewestInnerGroupsWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->coolAppCode)) {
            $body['coolAppCode'] = $request->coolAppCode;
        }
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetSceneGroupInfo',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/sceneGroups/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSceneGroupInfoResponse::fromMap($this->execute($params, $req, $runtime));
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
        if (!Utils::isUnset($request->coolAppCode)) {
            $body['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->cursor)) {
            $body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->size)) {
            $body['size'] = $request->size;
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
            'action'      => 'GetSceneGroupMembers',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/sceneGroups/members/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSceneGroupMembersResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param GroupBanWordsRequest $request
     * @param GroupBanWordsHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GroupBanWordsResponse
     */
    public function groupBanWordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->banWordsMode)) {
            $body['banWordsMode'] = $request->banWordsMode;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->options)) {
            $body['options'] = $request->options;
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
            'action'      => 'GroupBanWords',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/groups/words/ban',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return GroupBanWordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GroupBanWordsRequest $request
     *
     * @return GroupBanWordsResponse
     */
    public function groupBanWords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupBanWordsHeaders([]);

        return $this->groupBanWordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GroupCapacityInquiryRequest $request
     * @param GroupCapacityInquiryHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GroupCapacityInquiryResponse
     */
    public function groupCapacityInquiryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->effectiveDuration)) {
            $body['effectiveDuration'] = $request->effectiveDuration;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->options)) {
            $body['options'] = $request->options;
        }
        if (!Utils::isUnset($request->targetCapacity)) {
            $body['targetCapacity'] = $request->targetCapacity;
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
            'action'      => 'GroupCapacityInquiry',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/groups/capacities/inquiries/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GroupCapacityInquiryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GroupCapacityInquiryRequest $request
     *
     * @return GroupCapacityInquiryResponse
     */
    public function groupCapacityInquiry($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupCapacityInquiryHeaders([]);

        return $this->groupCapacityInquiryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GroupCapacityOrderConfirmRequest $request
     * @param GroupCapacityOrderConfirmHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return GroupCapacityOrderConfirmResponse
     */
    public function groupCapacityOrderConfirmWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->orderId)) {
            $body['orderId'] = $request->orderId;
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
            'action'      => 'GroupCapacityOrderConfirm',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/groups/capacities/orders/confirm',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GroupCapacityOrderConfirmResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GroupCapacityOrderConfirmRequest $request
     *
     * @return GroupCapacityOrderConfirmResponse
     */
    public function groupCapacityOrderConfirm($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupCapacityOrderConfirmHeaders([]);

        return $this->groupCapacityOrderConfirmWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GroupCapacityOrderPlaceRequest $request
     * @param GroupCapacityOrderPlaceHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return GroupCapacityOrderPlaceResponse
     */
    public function groupCapacityOrderPlaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actualPrice)) {
            $body['actualPrice'] = $request->actualPrice;
        }
        if (!Utils::isUnset($request->currentCapacity)) {
            $body['currentCapacity'] = $request->currentCapacity;
        }
        if (!Utils::isUnset($request->currentEffectUntil)) {
            $body['currentEffectUntil'] = $request->currentEffectUntil;
        }
        if (!Utils::isUnset($request->discount)) {
            $body['discount'] = $request->discount;
        }
        if (!Utils::isUnset($request->extInfo)) {
            $body['extInfo'] = $request->extInfo;
        }
        if (!Utils::isUnset($request->markedPrice)) {
            $body['markedPrice'] = $request->markedPrice;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->targetCapacity)) {
            $body['targetCapacity'] = $request->targetCapacity;
        }
        if (!Utils::isUnset($request->targetEffectUntil)) {
            $body['targetEffectUntil'] = $request->targetEffectUntil;
        }
        if (!Utils::isUnset($request->token)) {
            $body['token'] = $request->token;
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
            'action'      => 'GroupCapacityOrderPlace',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/groups/capacities/orders/place',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GroupCapacityOrderPlaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GroupCapacityOrderPlaceRequest $request
     *
     * @return GroupCapacityOrderPlaceResponse
     */
    public function groupCapacityOrderPlace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupCapacityOrderPlaceHeaders([]);

        return $this->groupCapacityOrderPlaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GroupManageQueryRequest $request
     * @param GroupManageQueryHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GroupManageQueryResponse
     */
    public function groupManageQueryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->createdAfter)) {
            $body['createdAfter'] = $request->createdAfter;
        }
        if (!Utils::isUnset($request->groupId)) {
            $body['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->groupMemberSamples)) {
            $body['groupMemberSamples'] = $request->groupMemberSamples;
        }
        if (!Utils::isUnset($request->groupOwner)) {
            $body['groupOwner'] = $request->groupOwner;
        }
        if (!Utils::isUnset($request->groupTitleKeywords)) {
            $body['groupTitleKeywords'] = $request->groupTitleKeywords;
        }
        if (!Utils::isUnset($request->groupUrl)) {
            $body['groupUrl'] = $request->groupUrl;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->membersOver)) {
            $body['membersOver'] = $request->membersOver;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GroupManageQuery',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/groups/managements/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GroupManageQueryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GroupManageQueryRequest $request
     *
     * @return GroupManageQueryResponse
     */
    public function groupManageQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupManageQueryHeaders([]);

        return $this->groupManageQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GroupManageReduceRequest $request
     * @param GroupManageReduceHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GroupManageReduceResponse
     */
    public function groupManageReduceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->capacityLimit)) {
            $body['capacityLimit'] = $request->capacityLimit;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->options)) {
            $body['options'] = $request->options;
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
            'action'      => 'GroupManageReduce',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/groups/capacities/reduce',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return GroupManageReduceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GroupManageReduceRequest $request
     *
     * @return GroupManageReduceResponse
     */
    public function groupManageReduce($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupManageReduceHeaders([]);

        return $this->groupManageReduceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param InstallRobotToOrgRequest $request
     * @param InstallRobotToOrgHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return InstallRobotToOrgResponse
     */
    public function installRobotToOrgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->brief)) {
            $body['brief'] = $request->brief;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->outgoingToken)) {
            $body['outgoingToken'] = $request->outgoingToken;
        }
        if (!Utils::isUnset($request->outgoingUrl)) {
            $body['outgoingUrl'] = $request->outgoingUrl;
        }
        if (!Utils::isUnset($request->previewMediaId)) {
            $body['previewMediaId'] = $request->previewMediaId;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'InstallRobotToOrg',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/organizations/robots/install',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InstallRobotToOrgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param InstallRobotToOrgRequest $request
     *
     * @return InstallRobotToOrgResponse
     */
    public function installRobotToOrg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InstallRobotToOrgHeaders([]);

        return $this->installRobotToOrgWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->callbackRouteKey)) {
            $body['callbackRouteKey'] = $request->callbackRouteKey;
        }
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            $body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->chatBotId)) {
            $body['chatBotId'] = $request->chatBotId;
        }
        if (!Utils::isUnset($request->conversationType)) {
            $body['conversationType'] = $request->conversationType;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->privateData)) {
            $body['privateData'] = $request->privateData;
        }
        if (!Utils::isUnset($request->pullStrategy)) {
            $body['pullStrategy'] = $request->pullStrategy;
        }
        if (!Utils::isUnset($request->receiverUserIdList)) {
            $body['receiverUserIdList'] = $request->receiverUserIdList;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->userIdType)) {
            $body['userIdType'] = $request->userIdType;
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
            'action'      => 'InteractiveCardCreateInstance',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interactiveCards/instances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InteractiveCardCreateInstanceResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param ListOrgTextEmotionHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return ListOrgTextEmotionResponse
     */
    public function listOrgTextEmotionWithOptions($headers, $runtime)
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
            'action'      => 'ListOrgTextEmotion',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/organizations/textEmotions',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListOrgTextEmotionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return ListOrgTextEmotionResponse
     */
    public function listOrgTextEmotion()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListOrgTextEmotionHeaders([]);

        return $this->listOrgTextEmotionWithOptions($headers, $runtime);
    }

    /**
     * @param QueryGroupInfoByMemberAuthRequest $request
     * @param QueryGroupInfoByMemberAuthHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return QueryGroupInfoByMemberAuthResponse
     */
    public function queryGroupInfoByMemberAuthWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coolAppCode)) {
            $body['coolAppCode'] = $request->coolAppCode;
        }
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'QueryGroupInfoByMemberAuth',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/memberAuthorizations/groups/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryGroupInfoByMemberAuthResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryGroupInfoByMemberAuthRequest $request
     *
     * @return QueryGroupInfoByMemberAuthResponse
     */
    public function queryGroupInfoByMemberAuth($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupInfoByMemberAuthHeaders([]);

        return $this->queryGroupInfoByMemberAuthWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryGroupMemberRequest $request
     * @param QueryGroupMemberHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QueryGroupMemberResponse
     */
    public function queryGroupMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $query['openConversationId'] = $request->openConversationId;
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
            'action'      => 'QueryGroupMember',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/conversations/members',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryGroupMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryGroupMemberRequest $request
     *
     * @return QueryGroupMemberResponse
     */
    public function queryGroupMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupMemberHeaders([]);

        return $this->queryGroupMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryGroupMemberByMemberAuthRequest $request
     * @param QueryGroupMemberByMemberAuthHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryGroupMemberByMemberAuthResponse
     */
    public function queryGroupMemberByMemberAuthWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coolAppCode)) {
            $body['coolAppCode'] = $request->coolAppCode;
        }
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'QueryGroupMemberByMemberAuth',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/memberAuthorizations/groups/members/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryGroupMemberByMemberAuthResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryGroupMemberByMemberAuthRequest $request
     *
     * @return QueryGroupMemberByMemberAuthResponse
     */
    public function queryGroupMemberByMemberAuth($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupMemberByMemberAuthHeaders([]);

        return $this->queryGroupMemberByMemberAuthWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryGroupMuteStatusRequest $request
     * @param QueryGroupMuteStatusHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryGroupMuteStatusResponse
     */
    public function queryGroupMuteStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $query['openConversationId'] = $request->openConversationId;
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
            'action'      => 'QueryGroupMuteStatus',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/sceneGroups/muteSettings',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryGroupMuteStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryGroupMuteStatusRequest $request
     *
     * @return QueryGroupMuteStatusResponse
     */
    public function queryGroupMuteStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupMuteStatusHeaders([]);

        return $this->queryGroupMuteStatusWithOptions($request, $headers, $runtime);
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
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openRoleId)) {
            $body['openRoleId'] = $request->openRoleId;
        }
        if (!Utils::isUnset($request->timestamp)) {
            $body['timestamp'] = $request->timestamp;
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
            'action'      => 'QueryMembersOfGroupRole',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/sceneGroups/roles/members/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryMembersOfGroupRoleResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param QuerySceneGroupTemplateRobotRequest $request
     * @param QuerySceneGroupTemplateRobotHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QuerySceneGroupTemplateRobotResponse
     */
    public function querySceneGroupTemplateRobotWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $query['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $query['robotCode'] = $request->robotCode;
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
            'action'      => 'QuerySceneGroupTemplateRobot',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/sceneGroups/templates/robots',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QuerySceneGroupTemplateRobotResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QuerySceneGroupTemplateRobotRequest $request
     *
     * @return QuerySceneGroupTemplateRobotResponse
     */
    public function querySceneGroupTemplateRobot($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySceneGroupTemplateRobotHeaders([]);

        return $this->querySceneGroupTemplateRobotWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QuerySingleGroupRequest $request
     * @param QuerySingleGroupHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QuerySingleGroupResponse
     */
    public function querySingleGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupMembers)) {
            $body['groupMembers'] = $request->groupMembers;
        }
        if (!Utils::isUnset($request->groupTemplateId)) {
            $body['groupTemplateId'] = $request->groupTemplateId;
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
            'action'      => 'QuerySingleGroup',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/doubleGroups/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QuerySingleGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QuerySingleGroupRequest $request
     *
     * @return QuerySingleGroupResponse
     */
    public function querySingleGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySingleGroupHeaders([]);

        return $this->querySingleGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryUnReadMessageRequest $request
     * @param QueryUnReadMessageHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryUnReadMessageResponse
     */
    public function queryUnReadMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appUserId)) {
            $body['appUserId'] = $request->appUserId;
        }
        if (!Utils::isUnset($request->openConversationIds)) {
            $body['openConversationIds'] = $request->openConversationIds;
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
            'action'      => 'QueryUnReadMessage',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/unReadMsgs/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryUnReadMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryUnReadMessageRequest $request
     *
     * @return QueryUnReadMessageResponse
     */
    public function queryUnReadMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUnReadMessageHeaders([]);

        return $this->queryUnReadMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RemoveRobotFromConversationRequest $request
     * @param RemoveRobotFromConversationHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return RemoveRobotFromConversationResponse
     */
    public function removeRobotFromConversationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->chatBotUserId)) {
            $body['chatBotUserId'] = $request->chatBotUserId;
        }
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RemoveRobotFromConversation',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/conversations/robots/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RemoveRobotFromConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RemoveRobotFromConversationRequest $request
     *
     * @return RemoveRobotFromConversationResponse
     */
    public function removeRobotFromConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveRobotFromConversationHeaders([]);

        return $this->removeRobotFromConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchInnerGroupsRequest $request
     * @param SearchInnerGroupsHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return SearchInnerGroupsResponse
     */
    public function searchInnerGroupsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $body['searchKey'] = $request->searchKey;
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
            'action'      => 'SearchInnerGroups',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/innerGroups/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchInnerGroupsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SearchInnerGroupsRequest $request
     *
     * @return SearchInnerGroupsResponse
     */
    public function searchInnerGroups($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchInnerGroupsHeaders([]);

        return $this->searchInnerGroupsWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->atOpenIds)) {
            $body['atOpenIds'] = $request->atOpenIds;
        }
        if (!Utils::isUnset($request->callbackRouteKey)) {
            $body['callbackRouteKey'] = $request->callbackRouteKey;
        }
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardOptions)) {
            $body['cardOptions'] = $request->cardOptions;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            $body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->chatBotId)) {
            $body['chatBotId'] = $request->chatBotId;
        }
        if (!Utils::isUnset($request->conversationType)) {
            $body['conversationType'] = $request->conversationType;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->privateData)) {
            $body['privateData'] = $request->privateData;
        }
        if (!Utils::isUnset($request->pullStrategy)) {
            $body['pullStrategy'] = $request->pullStrategy;
        }
        if (!Utils::isUnset($request->receiverUserIdList)) {
            $body['receiverUserIdList'] = $request->receiverUserIdList;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->userIdType)) {
            $body['userIdType'] = $request->userIdType;
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
            'action'      => 'SendInteractiveCard',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interactiveCards/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendInteractiveCardResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param SendOTOInteractiveCardRequest $request
     * @param SendOTOInteractiveCardHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return SendOTOInteractiveCardResponse
     */
    public function sendOTOInteractiveCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->atOpenIds)) {
            $body['atOpenIds'] = $request->atOpenIds;
        }
        if (!Utils::isUnset($request->callbackRouteKey)) {
            $body['callbackRouteKey'] = $request->callbackRouteKey;
        }
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardOptions)) {
            $body['cardOptions'] = $request->cardOptions;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            $body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->privateData)) {
            $body['privateData'] = $request->privateData;
        }
        if (!Utils::isUnset($request->pullStrategy)) {
            $body['pullStrategy'] = $request->pullStrategy;
        }
        if (!Utils::isUnset($request->receiverUserIdList)) {
            $body['receiverUserIdList'] = $request->receiverUserIdList;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->userIdType)) {
            $body['userIdType'] = $request->userIdType;
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
            'action'      => 'SendOTOInteractiveCard',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/privateChat/interactiveCards/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendOTOInteractiveCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SendOTOInteractiveCardRequest $request
     *
     * @return SendOTOInteractiveCardResponse
     */
    public function sendOTOInteractiveCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendOTOInteractiveCardHeaders([]);

        return $this->sendOTOInteractiveCardWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->callbackUrl)) {
            $body['callbackUrl'] = $request->callbackUrl;
        }
        if (!Utils::isUnset($request->cardBizId)) {
            $body['cardBizId'] = $request->cardBizId;
        }
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            $body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->pullStrategy)) {
            $body['pullStrategy'] = $request->pullStrategy;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->sendOptions)) {
            $body['sendOptions'] = $request->sendOptions;
        }
        if (!Utils::isUnset($request->singleChatReceiver)) {
            $body['singleChatReceiver'] = $request->singleChatReceiver;
        }
        if (!Utils::isUnset($request->unionIdPrivateDataMap)) {
            $body['unionIdPrivateDataMap'] = $request->unionIdPrivateDataMap;
        }
        if (!Utils::isUnset($request->userIdPrivateDataMap)) {
            $body['userIdPrivateDataMap'] = $request->userIdPrivateDataMap;
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
            'action'      => 'SendRobotInteractiveCard',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/v1.0/robot/interactiveCards/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendRobotInteractiveCardResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param SendRobotMessageRequest $request
     * @param SendRobotMessageHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return SendRobotMessageResponse
     */
    public function sendRobotMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->atAll)) {
            $body['atAll'] = $request->atAll;
        }
        if (!Utils::isUnset($request->atAppUserId)) {
            $body['atAppUserId'] = $request->atAppUserId;
        }
        if (!Utils::isUnset($request->atDingUserId)) {
            $body['atDingUserId'] = $request->atDingUserId;
        }
        if (!Utils::isUnset($request->msgContent)) {
            $body['msgContent'] = $request->msgContent;
        }
        if (!Utils::isUnset($request->msgType)) {
            $body['msgType'] = $request->msgType;
        }
        if (!Utils::isUnset($request->openConversationIds)) {
            $body['openConversationIds'] = $request->openConversationIds;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'SendRobotMessage',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/robotMessages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendRobotMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SendRobotMessageRequest $request
     *
     * @return SendRobotMessageResponse
     */
    public function sendRobotMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendRobotMessageHeaders([]);

        return $this->sendRobotMessageWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->callbackUrl)) {
            $body['callbackUrl'] = $request->callbackUrl;
        }
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            $body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->sendOptions)) {
            $body['sendOptions'] = $request->sendOptions;
        }
        if (!Utils::isUnset($request->singleChatReceiver)) {
            $body['singleChatReceiver'] = $request->singleChatReceiver;
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
            'action'      => 'SendTemplateInteractiveCard',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interactiveCards/templates/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendTemplateInteractiveCardResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param SetRightPanelRequest $request
     * @param SetRightPanelHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return SetRightPanelResponse
     */
    public function setRightPanelWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->rightPanelClosePermitted)) {
            $body['rightPanelClosePermitted'] = $request->rightPanelClosePermitted;
        }
        if (!Utils::isUnset($request->rightPanelOpenStatus)) {
            $body['rightPanelOpenStatus'] = $request->rightPanelOpenStatus;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->webWndParams)) {
            $body['webWndParams'] = $request->webWndParams;
        }
        if (!Utils::isUnset($request->width)) {
            $body['width'] = $request->width;
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
            'action'      => 'SetRightPanel',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/rightPanels/set',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SetRightPanelResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SetRightPanelRequest $request
     *
     * @return SetRightPanelResponse
     */
    public function setRightPanel($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetRightPanelHeaders([]);

        return $this->setRightPanelWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->conversationType)) {
            $body['conversationType'] = $request->conversationType;
        }
        if (!Utils::isUnset($request->coolAppCode)) {
            $body['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->receiverUserIdList)) {
            $body['receiverUserIdList'] = $request->receiverUserIdList;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'TopboxClose',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/topBoxes/close',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return TopboxCloseResponse::fromMap($this->execute($params, $req, $runtime));
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
        if (!Utils::isUnset($request->conversationType)) {
            $body['conversationType'] = $request->conversationType;
        }
        if (!Utils::isUnset($request->coolAppCode)) {
            $body['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->expiredTime)) {
            $body['expiredTime'] = $request->expiredTime;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->platforms)) {
            $body['platforms'] = $request->platforms;
        }
        if (!Utils::isUnset($request->receiverUserIdList)) {
            $body['receiverUserIdList'] = $request->receiverUserIdList;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'TopboxOpen',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/topBoxes/open',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return TopboxOpenResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param UpdateGroupAvatarRequest $request
     * @param UpdateGroupAvatarHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return UpdateGroupAvatarResponse
     */
    public function updateGroupAvatarWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupAvatar)) {
            $body['groupAvatar'] = $request->groupAvatar;
        }
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateGroupAvatar',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/groups/avatars',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateGroupAvatarResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateGroupAvatarRequest $request
     *
     * @return UpdateGroupAvatarResponse
     */
    public function updateGroupAvatar($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGroupAvatarHeaders([]);

        return $this->updateGroupAvatarWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateGroupNameRequest $request
     * @param UpdateGroupNameHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return UpdateGroupNameResponse
     */
    public function updateGroupNameWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
        }
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateGroupName',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/groups/names',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateGroupNameResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateGroupNameRequest $request
     *
     * @return UpdateGroupNameResponse
     */
    public function updateGroupName($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGroupNameHeaders([]);

        return $this->updateGroupNameWithOptions($request, $headers, $runtime);
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
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->permissionGroup)) {
            $body['permissionGroup'] = $request->permissionGroup;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
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
            'action'      => 'UpdateGroupPermission',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/sceneGroups/permissions',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateGroupPermissionResponse::fromMap($this->execute($params, $req, $runtime));
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
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->role)) {
            $body['role'] = $request->role;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
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
            'action'      => 'UpdateGroupSubAdmin',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/sceneGroups/subAdmins',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateGroupSubAdminResponse::fromMap($this->execute($params, $req, $runtime));
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
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->cardOptions)) {
            $body['cardOptions'] = $request->cardOptions;
        }
        if (!Utils::isUnset($request->outTrackId)) {
            $body['outTrackId'] = $request->outTrackId;
        }
        if (!Utils::isUnset($request->privateData)) {
            $body['privateData'] = $request->privateData;
        }
        if (!Utils::isUnset($request->userIdType)) {
            $body['userIdType'] = $request->userIdType;
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
            'action'      => 'UpdateInteractiveCard',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interactiveCards',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateInteractiveCardResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param UpdateMemberBanWordsRequest $request
     * @param UpdateMemberBanWordsHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return UpdateMemberBanWordsResponse
     */
    public function updateMemberBanWordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->muteDuration)) {
            $body['muteDuration'] = $request->muteDuration;
        }
        if (!Utils::isUnset($request->muteStatus)) {
            $body['muteStatus'] = $request->muteStatus;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->userIdList)) {
            $body['userIdList'] = $request->userIdList;
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
            'action'      => 'UpdateMemberBanWords',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/sceneGroups/muteMembers/set',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return UpdateMemberBanWordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateMemberBanWordsRequest $request
     *
     * @return UpdateMemberBanWordsResponse
     */
    public function updateMemberBanWords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateMemberBanWordsHeaders([]);

        return $this->updateMemberBanWordsWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->groupNick)) {
            $body['groupNick'] = $request->groupNick;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
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
            'action'      => 'UpdateMemberGroupNick',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/sceneGroups/members/groupNicks',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateMemberGroupNickResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param UpdateRobotInOrgRequest $request
     * @param UpdateRobotInOrgHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return UpdateRobotInOrgResponse
     */
    public function updateRobotInOrgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->brief)) {
            $body['brief'] = $request->brief;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->outgoingToken)) {
            $body['outgoingToken'] = $request->outgoingToken;
        }
        if (!Utils::isUnset($request->outgoingUrl)) {
            $body['outgoingUrl'] = $request->outgoingUrl;
        }
        if (!Utils::isUnset($request->previewMediaId)) {
            $body['previewMediaId'] = $request->previewMediaId;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
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
            'action'      => 'UpdateRobotInOrg',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/organizations/robots',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateRobotInOrgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateRobotInOrgRequest $request
     *
     * @return UpdateRobotInOrgResponse
     */
    public function updateRobotInOrg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRobotInOrgHeaders([]);

        return $this->updateRobotInOrgWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateRobotInteractiveCardRequest $request
     * @param UpdateRobotInteractiveCardHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return UpdateRobotInteractiveCardResponse
     */
    public function updateRobotInteractiveCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->cardBizId)) {
            $body['cardBizId'] = $request->cardBizId;
        }
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->unionIdPrivateDataMap)) {
            $body['unionIdPrivateDataMap'] = $request->unionIdPrivateDataMap;
        }
        if (!Utils::isUnset($request->updateOptions)) {
            $body['updateOptions'] = $request->updateOptions;
        }
        if (!Utils::isUnset($request->userIdPrivateDataMap)) {
            $body['userIdPrivateDataMap'] = $request->userIdPrivateDataMap;
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
            'action'      => 'UpdateRobotInteractiveCard',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/robots/interactiveCards',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateRobotInteractiveCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateRobotInteractiveCardRequest $request
     *
     * @return UpdateRobotInteractiveCardResponse
     */
    public function updateRobotInteractiveCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRobotInteractiveCardHeaders([]);

        return $this->updateRobotInteractiveCardWithOptions($request, $headers, $runtime);
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
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openRoleIds)) {
            $body['openRoleIds'] = $request->openRoleIds;
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
            'action'      => 'UpdateTheGroupRolesOfGroupMember',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/sceneGroups/members/groupRoles',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateTheGroupRolesOfGroupMemberResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param AddGroupMemberRequest $request
     * @param AddGroupMemberHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return AddGroupMemberResponse
     */
    public function addGroupMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appUserIds)) {
            $body['appUserIds'] = $request->appUserIds;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
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
            'action'      => 'addGroupMember',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/groups/members',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddGroupMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddGroupMemberRequest $request
     *
     * @return AddGroupMemberResponse
     */
    public function addGroupMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddGroupMemberHeaders([]);

        return $this->addGroupMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RemoveGroupMemberRequest $request
     * @param RemoveGroupMemberHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return RemoveGroupMemberResponse
     */
    public function removeGroupMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appUserIds)) {
            $body['appUserIds'] = $request->appUserIds;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
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
            'action'      => 'removeGroupMember',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/groups/members/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RemoveGroupMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RemoveGroupMemberRequest $request
     *
     * @return RemoveGroupMemberResponse
     */
    public function removeGroupMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveGroupMemberHeaders([]);

        return $this->removeGroupMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendDingMessageRequest $request
     * @param SendDingMessageHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return SendDingMessageResponse
     */
    public function sendDingMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->code)) {
            $body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->message)) {
            $body['message'] = $request->message;
        }
        if (!Utils::isUnset($request->messageType)) {
            $body['messageType'] = $request->messageType;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->receiverId)) {
            $body['receiverId'] = $request->receiverId;
        }
        if (!Utils::isUnset($request->senderId)) {
            $body['senderId'] = $request->senderId;
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
            'action'      => 'sendDingMessage',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/dingMessages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendDingMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SendDingMessageRequest $request
     *
     * @return SendDingMessageResponse
     */
    public function sendDingMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendDingMessageHeaders([]);

        return $this->sendDingMessageWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->message)) {
            $body['message'] = $request->message;
        }
        if (!Utils::isUnset($request->messageType)) {
            $body['messageType'] = $request->messageType;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->receiverId)) {
            $body['receiverId'] = $request->receiverId;
        }
        if (!Utils::isUnset($request->senderId)) {
            $body['senderId'] = $request->senderId;
        }
        if (!Utils::isUnset($request->sourceInfos)) {
            $body['sourceInfos'] = $request->sourceInfos;
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
            'action'      => 'sendMessage',
            'version'     => 'im_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/im/interconnections/messages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendMessageResponse::fromMap($this->execute($params, $req, $runtime));
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
}
