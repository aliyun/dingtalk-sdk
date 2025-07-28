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
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\AddUnfurlingRegisterHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\AddUnfurlingRegisterRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\AddUnfurlingRegisterResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CopyUnfurlingRegisterHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CopyUnfurlingRegisterRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CopyUnfurlingRegisterResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CountOpenMsgSceneGroupsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CountOpenMsgSceneGroupsRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CountOpenMsgSceneGroupsResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CountOrgMessageOpenSceneGroupsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CountOrgMessageOpenSceneGroupsResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CountSceneGroupsByTemplateIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CountSceneGroupsByTemplateIdResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\DebugUnfurlingRegisterHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\DebugUnfurlingRegisterRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\DebugUnfurlingRegisterResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\DeleteOrgTextEmotionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\DeleteOrgTextEmotionRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\DeleteOrgTextEmotionResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\DismissGroupConversationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\DismissGroupConversationRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\DismissGroupConversationResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\FreezeGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\FreezeGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\FreezeGroupResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSceneGroupTemplateMessageOpenStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSceneGroupTemplateMessageOpenStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSingleChatOpenConversationIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSingleChatOpenConversationIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSingleChatOpenConversationIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSuperAdminOpenSceneGroupInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSuperAdminOpenSceneGroupInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetSuperAdminOpenSceneGroupInfoResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ImportGroupChatHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ImportGroupChatRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ImportGroupChatResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ImportMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ImportMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ImportMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InstallRobotToOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InstallRobotToOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InstallRobotToOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InteractiveCardCreateInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InteractiveCardCreateInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InteractiveCardCreateInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListGroupTemplatesByOrgIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListGroupTemplatesByOrgIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListGroupTemplatesByOrgIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListOrgTextEmotionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListOrgTextEmotionResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListSceneGroupsByTemplateIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListSceneGroupsByTemplateIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListSceneGroupsByTemplateIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\LoginForVisitorHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\LoginForVisitorRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\LoginForVisitorResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OfflineUnfurlingRegisterHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OfflineUnfurlingRegisterRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OfflineUnfurlingRegisterResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupRoleAddHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupRoleAddRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupRoleAddResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupRoleQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupRoleQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupRoleQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupRoleRemoveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupRoleRemoveRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupRoleRemoveResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupRoleUpdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupRoleUpdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupRoleUpdateResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupUserRoleQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupUserRoleQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupUserRoleQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenInnerGroupTransferToDeptGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenInnerGroupTransferToDeptGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenInnerGroupTransferToDeptGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenSearchGroupListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenSearchGroupListRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenSearchGroupListResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenUserSendCardMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenUserSendCardMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenUserSendCardMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\PersonalSendCardMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\PersonalSendCardMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\PersonalSendCardMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupInfoByAppCidsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupInfoByAppCidsRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupInfoByAppCidsResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupInfoByMemberAuthHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupInfoByMemberAuthRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupInfoByMemberAuthResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupInfoByOpenCidsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupInfoByOpenCidsRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupInfoByOpenCidsResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberByAppUidsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberByAppUidsRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberByAppUidsResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberByMemberAuthHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberByMemberAuthRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberByMemberAuthResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMuteStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMuteStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMuteStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryInnerGroupMemberListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryInnerGroupMemberListRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryInnerGroupMemberListResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryInnerGroupRecentListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryInnerGroupRecentListRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryInnerGroupRecentListResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryMembersOfGroupRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryMembersOfGroupRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryMembersOfGroupRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryMessageSendResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryMessageSendResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryMessageSendResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryOpenConversationReceiveUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryOpenConversationReceiveUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryOpenConversationReceiveUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryOpenGroupBaseInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryOpenGroupBaseInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryOpenGroupBaseInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryPersonalMessageReadStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryPersonalMessageReadStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryPersonalMessageReadStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryRecentConversationsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryRecentConversationsRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryRecentConversationsResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QuerySceneGroupTemplateRobotHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QuerySceneGroupTemplateRobotRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QuerySceneGroupTemplateRobotResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QuerySingleGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QuerySingleGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QuerySingleGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUnfurlingRegisterCreatorHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUnfurlingRegisterCreatorRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUnfurlingRegisterCreatorResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUnfurlingRegisterInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUnfurlingRegisterInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUnfurlingRegisterInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUnReadMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUnReadMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUnReadMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUserViewGroupLastMessageTimeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUserViewGroupLastMessageTimeRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUserViewGroupLastMessageTimeResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ReadPersonalMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ReadPersonalMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ReadPersonalMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\RecallPersonalMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\RecallPersonalMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\RecallPersonalMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ReleaseUnfurlingRegisterHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ReleaseUnfurlingRegisterRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ReleaseUnfurlingRegisterResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendPersonalMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendPersonalMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendPersonalMessageResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SuperAdminApplyTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SuperAdminApplyTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SuperAdminApplyTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SuperAdminCloseTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SuperAdminCloseTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SuperAdminCloseTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxCloseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxCloseRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxCloseResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxOpenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxOpenRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\TopboxOpenResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateClientServiceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateClientServiceRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateClientServiceResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateSceneGroupTemplateMessageOpenStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateSceneGroupTemplateMessageOpenStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateSceneGroupTemplateMessageOpenStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateTheGroupRolesOfGroupMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateTheGroupRolesOfGroupMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateTheGroupRolesOfGroupMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateUnfurlingRegisterHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateUnfurlingRegisterRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateUnfurlingRegisterResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateUnfurlingRegisterStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateUnfurlingRegisterStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateUnfurlingRegisterStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpgradeToExternalGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpgradeToExternalGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpgradeToExternalGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpgradeToServiceGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpgradeToServiceGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpgradeToServiceGroupResponse;
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
        $gatewayClient = new Client();
        $this->_spi = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 添加企业文字表情
     *  *
     * @param AddOrgTextEmotionRequest $request AddOrgTextEmotionRequest
     * @param AddOrgTextEmotionHeaders $headers AddOrgTextEmotionHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return AddOrgTextEmotionResponse AddOrgTextEmotionResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'AddOrgTextEmotion',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/organizations/textEmotions',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddOrgTextEmotionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加企业文字表情
     *  *
     * @param AddOrgTextEmotionRequest $request AddOrgTextEmotionRequest
     *
     * @return AddOrgTextEmotionResponse AddOrgTextEmotionResponse
     */
    public function addOrgTextEmotion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddOrgTextEmotionHeaders([]);

        return $this->addOrgTextEmotionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加机器人到会话
     *  *
     * @param AddRobotToConversationRequest $request AddRobotToConversationRequest
     * @param AddRobotToConversationHeaders $headers AddRobotToConversationHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return AddRobotToConversationResponse AddRobotToConversationResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'AddRobotToConversation',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/conversations/robots',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddRobotToConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加机器人到会话
     *  *
     * @param AddRobotToConversationRequest $request AddRobotToConversationRequest
     *
     * @return AddRobotToConversationResponse AddRobotToConversationResponse
     */
    public function addRobotToConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddRobotToConversationHeaders([]);

        return $this->addRobotToConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新增链接增强注册规则
     *  *
     * @param AddUnfurlingRegisterRequest $request AddUnfurlingRegisterRequest
     * @param AddUnfurlingRegisterHeaders $headers AddUnfurlingRegisterHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return AddUnfurlingRegisterResponse AddUnfurlingRegisterResponse
     */
    public function addUnfurlingRegisterWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->apiSecret)) {
            $body['apiSecret'] = $request->apiSecret;
        }
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->callbackUrl)) {
            $body['callbackUrl'] = $request->callbackUrl;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            $body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->domain)) {
            $body['domain'] = $request->domain;
        }
        if (!Utils::isUnset($request->path)) {
            $body['path'] = $request->path;
        }
        if (!Utils::isUnset($request->ruleDesc)) {
            $body['ruleDesc'] = $request->ruleDesc;
        }
        if (!Utils::isUnset($request->ruleMatchType)) {
            $body['ruleMatchType'] = $request->ruleMatchType;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'AddUnfurlingRegister',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/unfurling/rules',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddUnfurlingRegisterResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增链接增强注册规则
     *  *
     * @param AddUnfurlingRegisterRequest $request AddUnfurlingRegisterRequest
     *
     * @return AddUnfurlingRegisterResponse AddUnfurlingRegisterResponse
     */
    public function addUnfurlingRegister($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddUnfurlingRegisterHeaders([]);

        return $this->addUnfurlingRegisterWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 自动开通钉钉客联微应用
     *  *
     * @param AutoOpenDingTalkConnectHeaders $headers AutoOpenDingTalkConnectHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return AutoOpenDingTalkConnectResponse AutoOpenDingTalkConnectResponse
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
            'action' => 'AutoOpenDingTalkConnect',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/apps/open',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AutoOpenDingTalkConnectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 自动开通钉钉客联微应用
     *  *
     * @return AutoOpenDingTalkConnectResponse AutoOpenDingTalkConnectResponse
     */
    public function autoOpenDingTalkConnect()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AutoOpenDingTalkConnectHeaders([]);

        return $this->autoOpenDingTalkConnectWithOptions($headers, $runtime);
    }

    /**
     * @summary 批量查询家校群消息详情
     *  *
     * @param BatchQueryFamilySchoolMessageRequest $request BatchQueryFamilySchoolMessageRequest
     * @param BatchQueryFamilySchoolMessageHeaders $headers BatchQueryFamilySchoolMessageHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchQueryFamilySchoolMessageResponse BatchQueryFamilySchoolMessageResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'BatchQueryFamilySchoolMessage',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/conversations/familySchools/messages/batchQuery',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchQueryFamilySchoolMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询家校群消息详情
     *  *
     * @param BatchQueryFamilySchoolMessageRequest $request BatchQueryFamilySchoolMessageRequest
     *
     * @return BatchQueryFamilySchoolMessageResponse BatchQueryFamilySchoolMessageResponse
     */
    public function batchQueryFamilySchoolMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchQueryFamilySchoolMessageHeaders([]);

        return $this->batchQueryFamilySchoolMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询群成员
     *  *
     * @param BatchQueryGroupMemberRequest $request BatchQueryGroupMemberRequest
     * @param BatchQueryGroupMemberHeaders $headers BatchQueryGroupMemberHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchQueryGroupMemberResponse BatchQueryGroupMemberResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'BatchQueryGroupMember',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/sceneGroups/members/batchQuery',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchQueryGroupMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询群成员
     *  *
     * @param BatchQueryGroupMemberRequest $request BatchQueryGroupMemberRequest
     *
     * @return BatchQueryGroupMemberResponse BatchQueryGroupMemberResponse
     */
    public function batchQueryGroupMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchQueryGroupMemberHeaders([]);

        return $this->batchQueryGroupMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 钉钉互动卡片模板构建动作
     *  *
     * @param CardTemplateBuildActionRequest $request CardTemplateBuildActionRequest
     * @param CardTemplateBuildActionHeaders $headers CardTemplateBuildActionHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CardTemplateBuildActionResponse CardTemplateBuildActionResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CardTemplateBuildAction',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interactiveCards/templates/buildAction',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CardTemplateBuildActionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 钉钉互动卡片模板构建动作
     *  *
     * @param CardTemplateBuildActionRequest $request CardTemplateBuildActionRequest
     *
     * @return CardTemplateBuildActionResponse CardTemplateBuildActionResponse
     */
    public function cardTemplateBuildAction($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CardTemplateBuildActionHeaders([]);

        return $this->cardTemplateBuildActionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更换群主
     *  *
     * @param ChangeGroupOwnerRequest $request ChangeGroupOwnerRequest
     * @param ChangeGroupOwnerHeaders $headers ChangeGroupOwnerHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return ChangeGroupOwnerResponse ChangeGroupOwnerResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ChangeGroupOwner',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/groups/owners',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ChangeGroupOwnerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更换群主
     *  *
     * @param ChangeGroupOwnerRequest $request ChangeGroupOwnerRequest
     *
     * @return ChangeGroupOwnerResponse ChangeGroupOwnerResponse
     */
    public function changeGroupOwner($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChangeGroupOwnerHeaders([]);

        return $this->changeGroupOwnerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 会话开放的ChatId转OpenConversationId
     *  *
     * @param string                            $chatId
     * @param ChatIdToOpenConversationIdHeaders $headers ChatIdToOpenConversationIdHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return ChatIdToOpenConversationIdResponse ChatIdToOpenConversationIdResponse
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
            'action' => 'ChatIdToOpenConversationId',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/chat/' . $chatId . '/convertToOpenConversationId',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ChatIdToOpenConversationIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 会话开放的ChatId转OpenConversationId
     *  *
     * @param string $chatId
     *
     * @return ChatIdToOpenConversationIdResponse ChatIdToOpenConversationIdResponse
     */
    public function chatIdToOpenConversationId($chatId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChatIdToOpenConversationIdHeaders([]);

        return $this->chatIdToOpenConversationIdWithOptions($chatId, $headers, $runtime);
    }

    /**
     * @summary 设置群管理员
     *  *
     * @param ChatSubAdminUpdateRequest $request ChatSubAdminUpdateRequest
     * @param ChatSubAdminUpdateHeaders $headers ChatSubAdminUpdateHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return ChatSubAdminUpdateResponse ChatSubAdminUpdateResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ChatSubAdminUpdate',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/subAdministrators',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ChatSubAdminUpdateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置群管理员
     *  *
     * @param ChatSubAdminUpdateRequest $request ChatSubAdminUpdateRequest
     *
     * @return ChatSubAdminUpdateResponse ChatSubAdminUpdateResponse
     */
    public function chatSubAdminUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChatSubAdminUpdateHeaders([]);

        return $this->chatSubAdminUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户是否为企业内部群成员
     *  *
     * @param CheckUserIsGroupMemberRequest $request CheckUserIsGroupMemberRequest
     * @param CheckUserIsGroupMemberHeaders $headers CheckUserIsGroupMemberHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CheckUserIsGroupMemberResponse CheckUserIsGroupMemberResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CheckUserIsGroupMember',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/innerGroups/members/check',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CheckUserIsGroupMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户是否为企业内部群成员
     *  *
     * @param CheckUserIsGroupMemberRequest $request CheckUserIsGroupMemberRequest
     *
     * @return CheckUserIsGroupMemberResponse CheckUserIsGroupMemberResponse
     */
    public function checkUserIsGroupMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckUserIsGroupMemberHeaders([]);

        return $this->checkUserIsGroupMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 链接增强规则拷贝
     *  *
     * @param CopyUnfurlingRegisterRequest $request CopyUnfurlingRegisterRequest
     * @param CopyUnfurlingRegisterHeaders $headers CopyUnfurlingRegisterHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CopyUnfurlingRegisterResponse CopyUnfurlingRegisterResponse
     */
    public function copyUnfurlingRegisterWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->id)) {
            $body['id'] = $request->id;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CopyUnfurlingRegister',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/unfurling/rules/copy',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CopyUnfurlingRegisterResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 链接增强规则拷贝
     *  *
     * @param CopyUnfurlingRegisterRequest $request CopyUnfurlingRegisterRequest
     *
     * @return CopyUnfurlingRegisterResponse CopyUnfurlingRegisterResponse
     */
    public function copyUnfurlingRegister($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CopyUnfurlingRegisterHeaders([]);

        return $this->copyUnfurlingRegisterWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询消息开放群模板下群计数
     *  *
     * @param CountOpenMsgSceneGroupsRequest $request CountOpenMsgSceneGroupsRequest
     * @param CountOpenMsgSceneGroupsHeaders $headers CountOpenMsgSceneGroupsHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CountOpenMsgSceneGroupsResponse CountOpenMsgSceneGroupsResponse
     */
    public function countOpenMsgSceneGroupsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CountOpenMsgSceneGroups',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/openMsgSceneGroups/templates/counts/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CountOpenMsgSceneGroupsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询消息开放群模板下群计数
     *  *
     * @param CountOpenMsgSceneGroupsRequest $request CountOpenMsgSceneGroupsRequest
     *
     * @return CountOpenMsgSceneGroupsResponse CountOpenMsgSceneGroupsResponse
     */
    public function countOpenMsgSceneGroups($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CountOpenMsgSceneGroupsHeaders([]);

        return $this->countOpenMsgSceneGroupsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业下消息开放场景群数量
     *  *
     * @param CountOrgMessageOpenSceneGroupsHeaders $headers CountOrgMessageOpenSceneGroupsHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return CountOrgMessageOpenSceneGroupsResponse CountOrgMessageOpenSceneGroupsResponse
     */
    public function countOrgMessageOpenSceneGroupsWithOptions($headers, $runtime)
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
            'action' => 'CountOrgMessageOpenSceneGroups',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/chats/sceneGroups/counts',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CountOrgMessageOpenSceneGroupsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业下消息开放场景群数量
     *  *
     * @return CountOrgMessageOpenSceneGroupsResponse CountOrgMessageOpenSceneGroupsResponse
     */
    public function countOrgMessageOpenSceneGroups()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CountOrgMessageOpenSceneGroupsHeaders([]);

        return $this->countOrgMessageOpenSceneGroupsWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询群模板关联的群数量
     *  *
     * @param string                              $templateId
     * @param CountSceneGroupsByTemplateIdHeaders $headers    CountSceneGroupsByTemplateIdHeaders
     * @param RuntimeOptions                      $runtime    runtime options for this request RuntimeOptions
     *
     * @return CountSceneGroupsByTemplateIdResponse CountSceneGroupsByTemplateIdResponse
     */
    public function countSceneGroupsByTemplateIdWithOptions($templateId, $headers, $runtime)
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
            'action' => 'CountSceneGroupsByTemplateId',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/chats/sceneGroups/templates/' . $templateId . '/counts',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CountSceneGroupsByTemplateIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询群模板关联的群数量
     *  *
     * @param string $templateId
     *
     * @return CountSceneGroupsByTemplateIdResponse CountSceneGroupsByTemplateIdResponse
     */
    public function countSceneGroupsByTemplateId($templateId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CountSceneGroupsByTemplateIdHeaders([]);

        return $this->countSceneGroupsByTemplateIdWithOptions($templateId, $headers, $runtime);
    }

    /**
     * @summary 创建钉外两人群
     *  *
     * @param CreateCoupleGroupConversationRequest $request CreateCoupleGroupConversationRequest
     * @param CreateCoupleGroupConversationHeaders $headers CreateCoupleGroupConversationHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateCoupleGroupConversationResponse CreateCoupleGroupConversationResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateCoupleGroupConversation',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/coupleGroups',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateCoupleGroupConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建钉外两人群
     *  *
     * @param CreateCoupleGroupConversationRequest $request CreateCoupleGroupConversationRequest
     *
     * @return CreateCoupleGroupConversationResponse CreateCoupleGroupConversationResponse
     */
    public function createCoupleGroupConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCoupleGroupConversationHeaders([]);

        return $this->createCoupleGroupConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建互通群（支持普通互通群、跨钉两人群）
     *  *
     * @param CreateGroupConversationRequest $request CreateGroupConversationRequest
     * @param CreateGroupConversationHeaders $headers CreateGroupConversationHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateGroupConversationResponse CreateGroupConversationResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateGroupConversation',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/groups',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateGroupConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建互通群（支持普通互通群、跨钉两人群）
     *  *
     * @param CreateGroupConversationRequest $request CreateGroupConversationRequest
     *
     * @return CreateGroupConversationResponse CreateGroupConversationResponse
     */
    public function createGroupConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateGroupConversationHeaders([]);

        return $this->createGroupConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建钉外账号
     *  *
     * @param CreateInterconnectionRequest $request CreateInterconnectionRequest
     * @param CreateInterconnectionHeaders $headers CreateInterconnectionHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateInterconnectionResponse CreateInterconnectionResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateInterconnection',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateInterconnectionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建钉外账号
     *  *
     * @param CreateInterconnectionRequest $request CreateInterconnectionRequest
     *
     * @return CreateInterconnectionResponse CreateInterconnectionResponse
     */
    public function createInterconnection($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateInterconnectionHeaders([]);

        return $this->createInterconnectionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建场景群会话
     *  *
     * @param CreateSceneGroupConversationRequest $request CreateSceneGroupConversationRequest
     * @param CreateSceneGroupConversationHeaders $headers CreateSceneGroupConversationHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateSceneGroupConversationResponse CreateSceneGroupConversationResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateSceneGroupConversation',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/sceneGroups',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateSceneGroupConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建场景群会话
     *  *
     * @param CreateSceneGroupConversationRequest $request CreateSceneGroupConversationRequest
     *
     * @return CreateSceneGroupConversationResponse CreateSceneGroupConversationResponse
     */
    public function createSceneGroupConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSceneGroupConversationHeaders([]);

        return $this->createSceneGroupConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建店铺群
     *  *
     * @param CreateStoreGroupConversationRequest $request CreateStoreGroupConversationRequest
     * @param CreateStoreGroupConversationHeaders $headers CreateStoreGroupConversationHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateStoreGroupConversationResponse CreateStoreGroupConversationResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateStoreGroupConversation',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/storeGroups',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateStoreGroupConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建店铺群
     *  *
     * @param CreateStoreGroupConversationRequest $request CreateStoreGroupConversationRequest
     *
     * @return CreateStoreGroupConversationResponse CreateStoreGroupConversationResponse
     */
    public function createStoreGroupConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateStoreGroupConversationHeaders([]);

        return $this->createStoreGroupConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 链接增强规则调试
     *  *
     * @param DebugUnfurlingRegisterRequest $request DebugUnfurlingRegisterRequest
     * @param DebugUnfurlingRegisterHeaders $headers DebugUnfurlingRegisterHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return DebugUnfurlingRegisterResponse DebugUnfurlingRegisterResponse
     */
    public function debugUnfurlingRegisterWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->grayGroupIdList)) {
            $body['grayGroupIdList'] = $request->grayGroupIdList;
        }
        if (!Utils::isUnset($request->grayUserIdList)) {
            $body['grayUserIdList'] = $request->grayUserIdList;
        }
        if (!Utils::isUnset($request->id)) {
            $body['id'] = $request->id;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DebugUnfurlingRegister',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/unfurling/rules/debug',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DebugUnfurlingRegisterResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 链接增强规则调试
     *  *
     * @param DebugUnfurlingRegisterRequest $request DebugUnfurlingRegisterRequest
     *
     * @return DebugUnfurlingRegisterResponse DebugUnfurlingRegisterResponse
     */
    public function debugUnfurlingRegister($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DebugUnfurlingRegisterHeaders([]);

        return $this->debugUnfurlingRegisterWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除企业文字表情
     *  *
     * @param DeleteOrgTextEmotionRequest $request DeleteOrgTextEmotionRequest
     * @param DeleteOrgTextEmotionHeaders $headers DeleteOrgTextEmotionHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteOrgTextEmotionResponse DeleteOrgTextEmotionResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DeleteOrgTextEmotion',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/organizations/textEmotions/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteOrgTextEmotionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除企业文字表情
     *  *
     * @param DeleteOrgTextEmotionRequest $request DeleteOrgTextEmotionRequest
     *
     * @return DeleteOrgTextEmotionResponse DeleteOrgTextEmotionResponse
     */
    public function deleteOrgTextEmotion($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteOrgTextEmotionHeaders([]);

        return $this->deleteOrgTextEmotionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 解散互通群
     *  *
     * @param DismissGroupConversationRequest $request DismissGroupConversationRequest
     * @param DismissGroupConversationHeaders $headers DismissGroupConversationHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return DismissGroupConversationResponse DismissGroupConversationResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DismissGroupConversation',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/groups/dismiss',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DismissGroupConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 解散互通群
     *  *
     * @param DismissGroupConversationRequest $request DismissGroupConversationRequest
     *
     * @return DismissGroupConversationResponse DismissGroupConversationResponse
     */
    public function dismissGroupConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DismissGroupConversationHeaders([]);

        return $this->dismissGroupConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 冻结群
     *  *
     * @param FreezeGroupRequest $request FreezeGroupRequest
     * @param FreezeGroupHeaders $headers FreezeGroupHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return FreezeGroupResponse FreezeGroupResponse
     */
    public function freezeGroupWithOptions($request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'FreezeGroup',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/chats/sceneGroups/freeze',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return FreezeGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 冻结群
     *  *
     * @param FreezeGroupRequest $request FreezeGroupRequest
     *
     * @return FreezeGroupResponse FreezeGroupResponse
     */
    public function freezeGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FreezeGroupHeaders([]);

        return $this->freezeGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建ToB会话地址
     *  *
     * @param GetConversationUrlRequest $request GetConversationUrlRequest
     * @param GetConversationUrlHeaders $headers GetConversationUrlHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetConversationUrlResponse GetConversationUrlResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetConversationUrl',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/conversations/urls',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetConversationUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建ToB会话地址
     *  *
     * @param GetConversationUrlRequest $request GetConversationUrlRequest
     *
     * @return GetConversationUrlResponse GetConversationUrlResponse
     */
    public function getConversationUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConversationUrlHeaders([]);

        return $this->getConversationUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户家校群消息(图片&视频Z&富文本)
     *  *
     * @param GetFamilySchoolConversationMsgRequest $request GetFamilySchoolConversationMsgRequest
     * @param GetFamilySchoolConversationMsgHeaders $headers GetFamilySchoolConversationMsgHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFamilySchoolConversationMsgResponse GetFamilySchoolConversationMsgResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetFamilySchoolConversationMsg',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/conversations/familySchools/messages/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetFamilySchoolConversationMsgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户家校群消息(图片&视频Z&富文本)
     *  *
     * @param GetFamilySchoolConversationMsgRequest $request GetFamilySchoolConversationMsgRequest
     *
     * @return GetFamilySchoolConversationMsgResponse GetFamilySchoolConversationMsgResponse
     */
    public function getFamilySchoolConversationMsg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFamilySchoolConversationMsgHeaders([]);

        return $this->getFamilySchoolConversationMsgWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户家校群
     *  *
     * @param GetFamilySchoolConversationsRequest $request GetFamilySchoolConversationsRequest
     * @param GetFamilySchoolConversationsHeaders $headers GetFamilySchoolConversationsHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFamilySchoolConversationsResponse GetFamilySchoolConversationsResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetFamilySchoolConversations',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/conversations/familySchools/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetFamilySchoolConversationsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户家校群
     *  *
     * @param GetFamilySchoolConversationsRequest $request GetFamilySchoolConversationsRequest
     *
     * @return GetFamilySchoolConversationsResponse GetFamilySchoolConversationsResponse
     */
    public function getFamilySchoolConversations($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFamilySchoolConversationsHeaders([]);

        return $this->getFamilySchoolConversationsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询企业内部群成员
     *  *
     * @param GetInnerGroupMembersRequest $request GetInnerGroupMembersRequest
     * @param GetInnerGroupMembersHeaders $headers GetInnerGroupMembersHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetInnerGroupMembersResponse GetInnerGroupMembersResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetInnerGroupMembers',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/innerGroups/members/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetInnerGroupMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询企业内部群成员
     *  *
     * @param GetInnerGroupMembersRequest $request GetInnerGroupMembersRequest
     *
     * @return GetInnerGroupMembersResponse GetInnerGroupMembersResponse
     */
    public function getInnerGroupMembers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInnerGroupMembersHeaders([]);

        return $this->getInnerGroupMembersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建客联互通会话地址
     *  *
     * @param GetInterconnectionUrlRequest $request GetInterconnectionUrlRequest
     * @param GetInterconnectionUrlHeaders $headers GetInterconnectionUrlHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetInterconnectionUrlResponse GetInterconnectionUrlResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetInterconnectionUrl',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/sessions/urls',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetInterconnectionUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建客联互通会话地址
     *  *
     * @param GetInterconnectionUrlRequest $request GetInterconnectionUrlRequest
     *
     * @return GetInterconnectionUrlResponse GetInterconnectionUrlResponse
     */
    public function getInterconnectionUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInterconnectionUrlHeaders([]);

        return $this->getInterconnectionUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询最近活跃的企业内部群列表
     *  *
     * @param GetNewestInnerGroupsRequest $request GetNewestInnerGroupsRequest
     * @param GetNewestInnerGroupsHeaders $headers GetNewestInnerGroupsHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetNewestInnerGroupsResponse GetNewestInnerGroupsResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetNewestInnerGroups',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/activities/innerGroups',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetNewestInnerGroupsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询最近活跃的企业内部群列表
     *  *
     * @param GetNewestInnerGroupsRequest $request GetNewestInnerGroupsRequest
     *
     * @return GetNewestInnerGroupsResponse GetNewestInnerGroupsResponse
     */
    public function getNewestInnerGroups($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetNewestInnerGroupsHeaders([]);

        return $this->getNewestInnerGroupsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询群简要信息
     *  *
     * @param GetSceneGroupInfoRequest $request GetSceneGroupInfoRequest
     * @param GetSceneGroupInfoHeaders $headers GetSceneGroupInfoHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSceneGroupInfoResponse GetSceneGroupInfoResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetSceneGroupInfo',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/sceneGroups/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSceneGroupInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询群简要信息
     *  *
     * @param GetSceneGroupInfoRequest $request GetSceneGroupInfoRequest
     *
     * @return GetSceneGroupInfoResponse GetSceneGroupInfoResponse
     */
    public function getSceneGroupInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSceneGroupInfoHeaders([]);

        return $this->getSceneGroupInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询群成员
     *  *
     * @param GetSceneGroupMembersRequest $request GetSceneGroupMembersRequest
     * @param GetSceneGroupMembersHeaders $headers GetSceneGroupMembersHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSceneGroupMembersResponse GetSceneGroupMembersResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetSceneGroupMembers',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/sceneGroups/members/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSceneGroupMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询群成员
     *  *
     * @param GetSceneGroupMembersRequest $request GetSceneGroupMembersRequest
     *
     * @return GetSceneGroupMembersResponse GetSceneGroupMembersResponse
     */
    public function getSceneGroupMembers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSceneGroupMembersHeaders([]);

        return $this->getSceneGroupMembersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询场景群模板消息存档能力开启状态
     *  *
     * @param string                                        $templateId
     * @param GetSceneGroupTemplateMessageOpenStatusHeaders $headers    GetSceneGroupTemplateMessageOpenStatusHeaders
     * @param RuntimeOptions                                $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetSceneGroupTemplateMessageOpenStatusResponse GetSceneGroupTemplateMessageOpenStatusResponse
     */
    public function getSceneGroupTemplateMessageOpenStatusWithOptions($templateId, $headers, $runtime)
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
            'action' => 'GetSceneGroupTemplateMessageOpenStatus',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/chats/sceneGroups/templates/' . $templateId . '/messageOpenStatuses',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSceneGroupTemplateMessageOpenStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询场景群模板消息存档能力开启状态
     *  *
     * @param string $templateId
     *
     * @return GetSceneGroupTemplateMessageOpenStatusResponse GetSceneGroupTemplateMessageOpenStatusResponse
     */
    public function getSceneGroupTemplateMessageOpenStatus($templateId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSceneGroupTemplateMessageOpenStatusHeaders([]);

        return $this->getSceneGroupTemplateMessageOpenStatusWithOptions($templateId, $headers, $runtime);
    }

    /**
     * @summary 获取单聊会话的OpenConversationId
     *  *
     * @param GetSingleChatOpenConversationIdRequest $request GetSingleChatOpenConversationIdRequest
     * @param GetSingleChatOpenConversationIdHeaders $headers GetSingleChatOpenConversationIdHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSingleChatOpenConversationIdResponse GetSingleChatOpenConversationIdResponse
     */
    public function getSingleChatOpenConversationIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userId1)) {
            $body['userId1'] = $request->userId1;
        }
        if (!Utils::isUnset($request->userId2)) {
            $body['userId2'] = $request->userId2;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetSingleChatOpenConversationId',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/privateChats/openConversationId/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSingleChatOpenConversationIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取单聊会话的OpenConversationId
     *  *
     * @param GetSingleChatOpenConversationIdRequest $request GetSingleChatOpenConversationIdRequest
     *
     * @return GetSingleChatOpenConversationIdResponse GetSingleChatOpenConversationIdResponse
     */
    public function getSingleChatOpenConversationId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSingleChatOpenConversationIdHeaders([]);

        return $this->getSingleChatOpenConversationIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询群信息（超管接口）
     *  *
     * @param GetSuperAdminOpenSceneGroupInfoRequest $request GetSuperAdminOpenSceneGroupInfoRequest
     * @param GetSuperAdminOpenSceneGroupInfoHeaders $headers GetSuperAdminOpenSceneGroupInfoHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSuperAdminOpenSceneGroupInfoResponse GetSuperAdminOpenSceneGroupInfoResponse
     */
    public function getSuperAdminOpenSceneGroupInfoWithOptions($request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetSuperAdminOpenSceneGroupInfo',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/chats/sceneGroups/groupInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSuperAdminOpenSceneGroupInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询群信息（超管接口）
     *  *
     * @param GetSuperAdminOpenSceneGroupInfoRequest $request GetSuperAdminOpenSceneGroupInfoRequest
     *
     * @return GetSuperAdminOpenSceneGroupInfoResponse GetSuperAdminOpenSceneGroupInfoResponse
     */
    public function getSuperAdminOpenSceneGroupInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSuperAdminOpenSceneGroupInfoHeaders([]);

        return $this->getSuperAdminOpenSceneGroupInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 群禁言
     *  *
     * @param GroupBanWordsRequest $request GroupBanWordsRequest
     * @param GroupBanWordsHeaders $headers GroupBanWordsHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GroupBanWordsResponse GroupBanWordsResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GroupBanWords',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/groups/words/ban',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'none',
        ]);

        return GroupBanWordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 群禁言
     *  *
     * @param GroupBanWordsRequest $request GroupBanWordsRequest
     *
     * @return GroupBanWordsResponse GroupBanWordsResponse
     */
    public function groupBanWords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupBanWordsHeaders([]);

        return $this->groupBanWordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 群容量扩容询价
     *  *
     * @param GroupCapacityInquiryRequest $request GroupCapacityInquiryRequest
     * @param GroupCapacityInquiryHeaders $headers GroupCapacityInquiryHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GroupCapacityInquiryResponse GroupCapacityInquiryResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GroupCapacityInquiry',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/groups/capacities/inquiries/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GroupCapacityInquiryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 群容量扩容询价
     *  *
     * @param GroupCapacityInquiryRequest $request GroupCapacityInquiryRequest
     *
     * @return GroupCapacityInquiryResponse GroupCapacityInquiryResponse
     */
    public function groupCapacityInquiry($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupCapacityInquiryHeaders([]);

        return $this->groupCapacityInquiryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 群容量扩容确认下单
     *  *
     * @param GroupCapacityOrderConfirmRequest $request GroupCapacityOrderConfirmRequest
     * @param GroupCapacityOrderConfirmHeaders $headers GroupCapacityOrderConfirmHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return GroupCapacityOrderConfirmResponse GroupCapacityOrderConfirmResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GroupCapacityOrderConfirm',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/groups/capacities/orders/confirm',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GroupCapacityOrderConfirmResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 群容量扩容确认下单
     *  *
     * @param GroupCapacityOrderConfirmRequest $request GroupCapacityOrderConfirmRequest
     *
     * @return GroupCapacityOrderConfirmResponse GroupCapacityOrderConfirmResponse
     */
    public function groupCapacityOrderConfirm($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupCapacityOrderConfirmHeaders([]);

        return $this->groupCapacityOrderConfirmWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 群容量请求扩容下单
     *  *
     * @param GroupCapacityOrderPlaceRequest $request GroupCapacityOrderPlaceRequest
     * @param GroupCapacityOrderPlaceHeaders $headers GroupCapacityOrderPlaceHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return GroupCapacityOrderPlaceResponse GroupCapacityOrderPlaceResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GroupCapacityOrderPlace',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/groups/capacities/orders/place',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GroupCapacityOrderPlaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 群容量请求扩容下单
     *  *
     * @param GroupCapacityOrderPlaceRequest $request GroupCapacityOrderPlaceRequest
     *
     * @return GroupCapacityOrderPlaceResponse GroupCapacityOrderPlaceResponse
     */
    public function groupCapacityOrderPlace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupCapacityOrderPlaceHeaders([]);

        return $this->groupCapacityOrderPlaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据群链接、群号等检索条件，查询群信息
     *  *
     * @param GroupManageQueryRequest $request GroupManageQueryRequest
     * @param GroupManageQueryHeaders $headers GroupManageQueryHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GroupManageQueryResponse GroupManageQueryResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GroupManageQuery',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/groups/managements/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GroupManageQueryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据群链接、群号等检索条件，查询群信息
     *  *
     * @param GroupManageQueryRequest $request GroupManageQueryRequest
     *
     * @return GroupManageQueryResponse GroupManageQueryResponse
     */
    public function groupManageQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupManageQueryHeaders([]);

        return $this->groupManageQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 群管理缩容
     *  *
     * @param GroupManageReduceRequest $request GroupManageReduceRequest
     * @param GroupManageReduceHeaders $headers GroupManageReduceHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GroupManageReduceResponse GroupManageReduceResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GroupManageReduce',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/groups/capacities/reduce',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'none',
        ]);

        return GroupManageReduceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 群管理缩容
     *  *
     * @param GroupManageReduceRequest $request GroupManageReduceRequest
     *
     * @return GroupManageReduceResponse GroupManageReduceResponse
     */
    public function groupManageReduce($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupManageReduceHeaders([]);

        return $this->groupManageReduceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 导入群聊会话
     *  *
     * @param ImportGroupChatRequest $request ImportGroupChatRequest
     * @param ImportGroupChatHeaders $headers ImportGroupChatHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ImportGroupChatResponse ImportGroupChatResponse
     */
    public function importGroupChatWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->adminIds)) {
            $body['adminIds'] = $request->adminIds;
        }
        if (!Utils::isUnset($request->createAt)) {
            $body['createAt'] = $request->createAt;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->importUuid)) {
            $body['importUuid'] = $request->importUuid;
        }
        if (!Utils::isUnset($request->owner)) {
            $body['owner'] = $request->owner;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->userList)) {
            $body['userList'] = $request->userList;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ImportGroupChat',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/groupChats/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ImportGroupChatResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 导入群聊会话
     *  *
     * @param ImportGroupChatRequest $request ImportGroupChatRequest
     *
     * @return ImportGroupChatResponse ImportGroupChatResponse
     */
    public function importGroupChat($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ImportGroupChatHeaders([]);

        return $this->importGroupChatWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 导入消息
     *  *
     * @param ImportMessageRequest $request ImportMessageRequest
     * @param ImportMessageHeaders $headers ImportMessageHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return ImportMessageResponse ImportMessageResponse
     */
    public function importMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->createTime)) {
            $body['createTime'] = $request->createTime;
        }
        if (!Utils::isUnset($request->importUuid)) {
            $body['importUuid'] = $request->importUuid;
        }
        if (!Utils::isUnset($request->msgReadStatusSetting)) {
            $body['msgReadStatusSetting'] = $request->msgReadStatusSetting;
        }
        if (!Utils::isUnset($request->msgType)) {
            $body['msgType'] = $request->msgType;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->receivers)) {
            $body['receivers'] = $request->receivers;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ImportMessage',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/messages/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ImportMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 导入消息
     *  *
     * @param ImportMessageRequest $request ImportMessageRequest
     *
     * @return ImportMessageResponse ImportMessageResponse
     */
    public function importMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ImportMessageHeaders([]);

        return $this->importMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 安装机器人到组织
     *  *
     * @param InstallRobotToOrgRequest $request InstallRobotToOrgRequest
     * @param InstallRobotToOrgHeaders $headers InstallRobotToOrgHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return InstallRobotToOrgResponse InstallRobotToOrgResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'InstallRobotToOrg',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/organizations/robots/install',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return InstallRobotToOrgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 安装机器人到组织
     *  *
     * @param InstallRobotToOrgRequest $request InstallRobotToOrgRequest
     *
     * @return InstallRobotToOrgResponse InstallRobotToOrgResponse
     */
    public function installRobotToOrg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InstallRobotToOrgHeaders([]);

        return $this->installRobotToOrgWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建可交互式实例
     *  *
     * @param InteractiveCardCreateInstanceRequest $request InteractiveCardCreateInstanceRequest
     * @param InteractiveCardCreateInstanceHeaders $headers InteractiveCardCreateInstanceHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return InteractiveCardCreateInstanceResponse InteractiveCardCreateInstanceResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'InteractiveCardCreateInstance',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interactiveCards/instances',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return InteractiveCardCreateInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建可交互式实例
     *  *
     * @param InteractiveCardCreateInstanceRequest $request InteractiveCardCreateInstanceRequest
     *
     * @return InteractiveCardCreateInstanceResponse InteractiveCardCreateInstanceResponse
     */
    public function interactiveCardCreateInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InteractiveCardCreateInstanceHeaders([]);

        return $this->interactiveCardCreateInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查组织下所有的场景群模版列表
     *  *
     * @param ListGroupTemplatesByOrgIdRequest $request ListGroupTemplatesByOrgIdRequest
     * @param ListGroupTemplatesByOrgIdHeaders $headers ListGroupTemplatesByOrgIdHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return ListGroupTemplatesByOrgIdResponse ListGroupTemplatesByOrgIdResponse
     */
    public function listGroupTemplatesByOrgIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ListGroupTemplatesByOrgId',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/chats/sceneGroups/templates/lists',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListGroupTemplatesByOrgIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查组织下所有的场景群模版列表
     *  *
     * @param ListGroupTemplatesByOrgIdRequest $request ListGroupTemplatesByOrgIdRequest
     *
     * @return ListGroupTemplatesByOrgIdResponse ListGroupTemplatesByOrgIdResponse
     */
    public function listGroupTemplatesByOrgId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListGroupTemplatesByOrgIdHeaders([]);

        return $this->listGroupTemplatesByOrgIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 拉取企业的所有文字表情，包含正常使用的、已经删除了的、安全审核不通过的文字表情
     *  *
     * @param ListOrgTextEmotionHeaders $headers ListOrgTextEmotionHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return ListOrgTextEmotionResponse ListOrgTextEmotionResponse
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
            'action' => 'ListOrgTextEmotion',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/organizations/textEmotions',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListOrgTextEmotionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 拉取企业的所有文字表情，包含正常使用的、已经删除了的、安全审核不通过的文字表情
     *  *
     * @return ListOrgTextEmotionResponse ListOrgTextEmotionResponse
     */
    public function listOrgTextEmotion()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListOrgTextEmotionHeaders([]);

        return $this->listOrgTextEmotionWithOptions($headers, $runtime);
    }

    /**
     * @summary 根据模板id查询关联的群
     *  *
     * @param string                             $templateId
     * @param ListSceneGroupsByTemplateIdRequest $request    ListSceneGroupsByTemplateIdRequest
     * @param ListSceneGroupsByTemplateIdHeaders $headers    ListSceneGroupsByTemplateIdHeaders
     * @param RuntimeOptions                     $runtime    runtime options for this request RuntimeOptions
     *
     * @return ListSceneGroupsByTemplateIdResponse ListSceneGroupsByTemplateIdResponse
     */
    public function listSceneGroupsByTemplateIdWithOptions($templateId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ListSceneGroupsByTemplateId',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/chats/sceneGroups/templates/' . $templateId . '/lists',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListSceneGroupsByTemplateIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据模板id查询关联的群
     *  *
     * @param string                             $templateId
     * @param ListSceneGroupsByTemplateIdRequest $request    ListSceneGroupsByTemplateIdRequest
     *
     * @return ListSceneGroupsByTemplateIdResponse ListSceneGroupsByTemplateIdResponse
     */
    public function listSceneGroupsByTemplateId($templateId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSceneGroupsByTemplateIdHeaders([]);

        return $this->listSceneGroupsByTemplateIdWithOptions($templateId, $request, $headers, $runtime);
    }

    /**
     * @summary 客联访客登录接口
     *  *
     * @param LoginForVisitorRequest $request LoginForVisitorRequest
     * @param LoginForVisitorHeaders $headers LoginForVisitorHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return LoginForVisitorResponse LoginForVisitorResponse
     */
    public function loginForVisitorWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appUserId)) {
            $body['appUserId'] = $request->appUserId;
        }
        if (!Utils::isUnset($request->channelCode)) {
            $body['channelCode'] = $request->channelCode;
        }
        if (!Utils::isUnset($request->customAccessToken)) {
            $body['customAccessToken'] = $request->customAccessToken;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'LoginForVisitor',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/conversations/visitorLogin',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return LoginForVisitorResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 客联访客登录接口
     *  *
     * @param LoginForVisitorRequest $request LoginForVisitorRequest
     *
     * @return LoginForVisitorResponse LoginForVisitorResponse
     */
    public function loginForVisitor($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LoginForVisitorHeaders([]);

        return $this->loginForVisitorWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 链接增强规则下线
     *  *
     * @param OfflineUnfurlingRegisterRequest $request OfflineUnfurlingRegisterRequest
     * @param OfflineUnfurlingRegisterHeaders $headers OfflineUnfurlingRegisterHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return OfflineUnfurlingRegisterResponse OfflineUnfurlingRegisterResponse
     */
    public function offlineUnfurlingRegisterWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->id)) {
            $body['id'] = $request->id;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'OfflineUnfurlingRegister',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/unfurling/rules/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return OfflineUnfurlingRegisterResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 链接增强规则下线
     *  *
     * @param OfflineUnfurlingRegisterRequest $request OfflineUnfurlingRegisterRequest
     *
     * @return OfflineUnfurlingRegisterResponse OfflineUnfurlingRegisterResponse
     */
    public function offlineUnfurlingRegister($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OfflineUnfurlingRegisterHeaders([]);

        return $this->offlineUnfurlingRegisterWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 开放场景群新增群角色
     *  *
     * @param OpenGroupRoleAddRequest $request OpenGroupRoleAddRequest
     * @param OpenGroupRoleAddHeaders $headers OpenGroupRoleAddHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return OpenGroupRoleAddResponse OpenGroupRoleAddResponse
     */
    public function openGroupRoleAddWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->roleName)) {
            $body['roleName'] = $request->roleName;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'OpenGroupRoleAdd',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/groups/roles',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return OpenGroupRoleAddResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 开放场景群新增群角色
     *  *
     * @param OpenGroupRoleAddRequest $request OpenGroupRoleAddRequest
     *
     * @return OpenGroupRoleAddResponse OpenGroupRoleAddResponse
     */
    public function openGroupRoleAdd($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OpenGroupRoleAddHeaders([]);

        return $this->openGroupRoleAddWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 开放场景群群角色查询
     *  *
     * @param OpenGroupRoleQueryRequest $request OpenGroupRoleQueryRequest
     * @param OpenGroupRoleQueryHeaders $headers OpenGroupRoleQueryHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return OpenGroupRoleQueryResponse OpenGroupRoleQueryResponse
     */
    public function openGroupRoleQueryWithOptions($request, $headers, $runtime)
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'OpenGroupRoleQuery',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/groups/roles/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return OpenGroupRoleQueryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 开放场景群群角色查询
     *  *
     * @param OpenGroupRoleQueryRequest $request OpenGroupRoleQueryRequest
     *
     * @return OpenGroupRoleQueryResponse OpenGroupRoleQueryResponse
     */
    public function openGroupRoleQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OpenGroupRoleQueryHeaders([]);

        return $this->openGroupRoleQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 开放场景群群角色移除
     *  *
     * @param OpenGroupRoleRemoveRequest $request OpenGroupRoleRemoveRequest
     * @param OpenGroupRoleRemoveHeaders $headers OpenGroupRoleRemoveHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return OpenGroupRoleRemoveResponse OpenGroupRoleRemoveResponse
     */
    public function openGroupRoleRemoveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openRoleId)) {
            $body['openRoleId'] = $request->openRoleId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'OpenGroupRoleRemove',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/groups/roles/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return OpenGroupRoleRemoveResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 开放场景群群角色移除
     *  *
     * @param OpenGroupRoleRemoveRequest $request OpenGroupRoleRemoveRequest
     *
     * @return OpenGroupRoleRemoveResponse OpenGroupRoleRemoveResponse
     */
    public function openGroupRoleRemove($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OpenGroupRoleRemoveHeaders([]);

        return $this->openGroupRoleRemoveWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 开放场景群群角色变更
     *  *
     * @param OpenGroupRoleUpdateRequest $request OpenGroupRoleUpdateRequest
     * @param OpenGroupRoleUpdateHeaders $headers OpenGroupRoleUpdateHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return OpenGroupRoleUpdateResponse OpenGroupRoleUpdateResponse
     */
    public function openGroupRoleUpdateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openRoleId)) {
            $body['openRoleId'] = $request->openRoleId;
        }
        if (!Utils::isUnset($request->roleName)) {
            $body['roleName'] = $request->roleName;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'OpenGroupRoleUpdate',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/groups/roles',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return OpenGroupRoleUpdateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 开放场景群群角色变更
     *  *
     * @param OpenGroupRoleUpdateRequest $request OpenGroupRoleUpdateRequest
     *
     * @return OpenGroupRoleUpdateResponse OpenGroupRoleUpdateResponse
     */
    public function openGroupRoleUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OpenGroupRoleUpdateHeaders([]);

        return $this->openGroupRoleUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 开放场景群群成员的群角色信息查询
     *  *
     * @param OpenGroupUserRoleQueryRequest $request OpenGroupUserRoleQueryRequest
     * @param OpenGroupUserRoleQueryHeaders $headers OpenGroupUserRoleQueryHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return OpenGroupUserRoleQueryResponse OpenGroupUserRoleQueryResponse
     */
    public function openGroupUserRoleQueryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->viewedUserId)) {
            $body['viewedUserId'] = $request->viewedUserId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'OpenGroupUserRoleQuery',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/groups/users/roles/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return OpenGroupUserRoleQueryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 开放场景群群成员的群角色信息查询
     *  *
     * @param OpenGroupUserRoleQueryRequest $request OpenGroupUserRoleQueryRequest
     *
     * @return OpenGroupUserRoleQueryResponse OpenGroupUserRoleQueryResponse
     */
    public function openGroupUserRoleQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OpenGroupUserRoleQueryHeaders([]);

        return $this->openGroupUserRoleQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 内部群转部门群
     *  *
     * @param OpenInnerGroupTransferToDeptGroupRequest $request OpenInnerGroupTransferToDeptGroupRequest
     * @param OpenInnerGroupTransferToDeptGroupHeaders $headers OpenInnerGroupTransferToDeptGroupHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return OpenInnerGroupTransferToDeptGroupResponse OpenInnerGroupTransferToDeptGroupResponse
     */
    public function openInnerGroupTransferToDeptGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'OpenInnerGroupTransferToDeptGroup',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/innerGroups/transferToDeptGroups',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return OpenInnerGroupTransferToDeptGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 内部群转部门群
     *  *
     * @param OpenInnerGroupTransferToDeptGroupRequest $request OpenInnerGroupTransferToDeptGroupRequest
     *
     * @return OpenInnerGroupTransferToDeptGroupResponse OpenInnerGroupTransferToDeptGroupResponse
     */
    public function openInnerGroupTransferToDeptGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OpenInnerGroupTransferToDeptGroupHeaders([]);

        return $this->openInnerGroupTransferToDeptGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 群搜索
     *  *
     * @param OpenSearchGroupListRequest $request OpenSearchGroupListRequest
     * @param OpenSearchGroupListHeaders $headers OpenSearchGroupListHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return OpenSearchGroupListResponse OpenSearchGroupListResponse
     */
    public function openSearchGroupListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->keyword)) {
            $body['keyword'] = $request->keyword;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'OpenSearchGroupList',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/groups/search',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return OpenSearchGroupListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 群搜索
     *  *
     * @param OpenSearchGroupListRequest $request OpenSearchGroupListRequest
     *
     * @return OpenSearchGroupListResponse OpenSearchGroupListResponse
     */
    public function openSearchGroupList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OpenSearchGroupListHeaders([]);

        return $this->openSearchGroupListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 以个人身份发送卡片消息
     *  *
     * @param OpenUserSendCardMessageRequest $request OpenUserSendCardMessageRequest
     * @param OpenUserSendCardMessageHeaders $headers OpenUserSendCardMessageHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return OpenUserSendCardMessageResponse OpenUserSendCardMessageResponse
     */
    public function openUserSendCardMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->cardContent)) {
            $body['cardContent'] = $request->cardContent;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->receiveUserId)) {
            $body['receiveUserId'] = $request->receiveUserId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'OpenUserSendCardMessage',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/cardMessages/users/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return OpenUserSendCardMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 以个人身份发送卡片消息
     *  *
     * @param OpenUserSendCardMessageRequest $request OpenUserSendCardMessageRequest
     *
     * @return OpenUserSendCardMessageResponse OpenUserSendCardMessageResponse
     */
    public function openUserSendCardMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OpenUserSendCardMessageHeaders([]);

        return $this->openUserSendCardMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 以用户身份发送卡片消息
     *  *
     * @param PersonalSendCardMessageRequest $request PersonalSendCardMessageRequest
     * @param PersonalSendCardMessageHeaders $headers PersonalSendCardMessageHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return PersonalSendCardMessageResponse PersonalSendCardMessageResponse
     */
    public function personalSendCardMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->atUserIds)) {
            $body['atUserIds'] = $request->atUserIds;
        }
        if (!Utils::isUnset($request->cardContent)) {
            $body['cardContent'] = $request->cardContent;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->receiveUserId)) {
            $body['receiveUserId'] = $request->receiveUserId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PersonalSendCardMessage',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/me/messages/cards/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PersonalSendCardMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 以用户身份发送卡片消息
     *  *
     * @param PersonalSendCardMessageRequest $request PersonalSendCardMessageRequest
     *
     * @return PersonalSendCardMessageResponse PersonalSendCardMessageResponse
     */
    public function personalSendCardMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PersonalSendCardMessageHeaders([]);

        return $this->personalSendCardMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据IM会话Cid查询群信息
     *  *
     * @param QueryGroupInfoByAppCidsRequest $request QueryGroupInfoByAppCidsRequest
     * @param QueryGroupInfoByAppCidsHeaders $headers QueryGroupInfoByAppCidsHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGroupInfoByAppCidsResponse QueryGroupInfoByAppCidsResponse
     */
    public function queryGroupInfoByAppCidsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appCids)) {
            $body['appCids'] = $request->appCids;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryGroupInfoByAppCids',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/group/groupInfoByAppCid',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryGroupInfoByAppCidsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据IM会话Cid查询群信息
     *  *
     * @param QueryGroupInfoByAppCidsRequest $request QueryGroupInfoByAppCidsRequest
     *
     * @return QueryGroupInfoByAppCidsResponse QueryGroupInfoByAppCidsResponse
     */
    public function queryGroupInfoByAppCids($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupInfoByAppCidsHeaders([]);

        return $this->queryGroupInfoByAppCidsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 成员授权场景下查询群信息
     *  *
     * @param QueryGroupInfoByMemberAuthRequest $request QueryGroupInfoByMemberAuthRequest
     * @param QueryGroupInfoByMemberAuthHeaders $headers QueryGroupInfoByMemberAuthHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGroupInfoByMemberAuthResponse QueryGroupInfoByMemberAuthResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryGroupInfoByMemberAuth',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/memberAuthorizations/groups/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryGroupInfoByMemberAuthResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 成员授权场景下查询群信息
     *  *
     * @param QueryGroupInfoByMemberAuthRequest $request QueryGroupInfoByMemberAuthRequest
     *
     * @return QueryGroupInfoByMemberAuthResponse QueryGroupInfoByMemberAuthResponse
     */
    public function queryGroupInfoByMemberAuth($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupInfoByMemberAuthHeaders([]);

        return $this->queryGroupInfoByMemberAuthWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据群Cid查询群信息
     *  *
     * @param QueryGroupInfoByOpenCidsRequest $request QueryGroupInfoByOpenCidsRequest
     * @param QueryGroupInfoByOpenCidsHeaders $headers QueryGroupInfoByOpenCidsHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGroupInfoByOpenCidsResponse QueryGroupInfoByOpenCidsResponse
     */
    public function queryGroupInfoByOpenCidsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryGroupInfoByOpenCids',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/group/groupInfoByOpenCid',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryGroupInfoByOpenCidsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据群Cid查询群信息
     *  *
     * @param QueryGroupInfoByOpenCidsRequest $request QueryGroupInfoByOpenCidsRequest
     *
     * @return QueryGroupInfoByOpenCidsResponse QueryGroupInfoByOpenCidsResponse
     */
    public function queryGroupInfoByOpenCids($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupInfoByOpenCidsHeaders([]);

        return $this->queryGroupInfoByOpenCidsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询群成员列表
     *  *
     * @param QueryGroupMemberRequest $request QueryGroupMemberRequest
     * @param QueryGroupMemberHeaders $headers QueryGroupMemberHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGroupMemberResponse QueryGroupMemberResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryGroupMember',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/conversations/members',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryGroupMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询群成员列表
     *  *
     * @param QueryGroupMemberRequest $request QueryGroupMemberRequest
     *
     * @return QueryGroupMemberResponse QueryGroupMemberResponse
     */
    public function queryGroupMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupMemberHeaders([]);

        return $this->queryGroupMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据appUid获取成员信息
     *  *
     * @param QueryGroupMemberByAppUidsRequest $request QueryGroupMemberByAppUidsRequest
     * @param QueryGroupMemberByAppUidsHeaders $headers QueryGroupMemberByAppUidsHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGroupMemberByAppUidsResponse QueryGroupMemberByAppUidsResponse
     */
    public function queryGroupMemberByAppUidsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appUids)) {
            $body['appUids'] = $request->appUids;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryGroupMemberByAppUids',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/group/groupMemberByAppUids',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryGroupMemberByAppUidsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据appUid获取成员信息
     *  *
     * @param QueryGroupMemberByAppUidsRequest $request QueryGroupMemberByAppUidsRequest
     *
     * @return QueryGroupMemberByAppUidsResponse QueryGroupMemberByAppUidsResponse
     */
    public function queryGroupMemberByAppUids($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupMemberByAppUidsHeaders([]);

        return $this->queryGroupMemberByAppUidsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 成员授权场景下查询群成员
     *  *
     * @param QueryGroupMemberByMemberAuthRequest $request QueryGroupMemberByMemberAuthRequest
     * @param QueryGroupMemberByMemberAuthHeaders $headers QueryGroupMemberByMemberAuthHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGroupMemberByMemberAuthResponse QueryGroupMemberByMemberAuthResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryGroupMemberByMemberAuth',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/memberAuthorizations/groups/members/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryGroupMemberByMemberAuthResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 成员授权场景下查询群成员
     *  *
     * @param QueryGroupMemberByMemberAuthRequest $request QueryGroupMemberByMemberAuthRequest
     *
     * @return QueryGroupMemberByMemberAuthResponse QueryGroupMemberByMemberAuthResponse
     */
    public function queryGroupMemberByMemberAuth($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupMemberByMemberAuthHeaders([]);

        return $this->queryGroupMemberByMemberAuthWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询群禁言状态
     *  *
     * @param QueryGroupMuteStatusRequest $request QueryGroupMuteStatusRequest
     * @param QueryGroupMuteStatusHeaders $headers QueryGroupMuteStatusHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGroupMuteStatusResponse QueryGroupMuteStatusResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryGroupMuteStatus',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/sceneGroups/muteSettings',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryGroupMuteStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询群禁言状态
     *  *
     * @param QueryGroupMuteStatusRequest $request QueryGroupMuteStatusRequest
     *
     * @return QueryGroupMuteStatusResponse QueryGroupMuteStatusResponse
     */
    public function queryGroupMuteStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupMuteStatusHeaders([]);

        return $this->queryGroupMuteStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 读取群成员列表
     *  *
     * @param QueryInnerGroupMemberListRequest $request QueryInnerGroupMemberListRequest
     * @param QueryInnerGroupMemberListHeaders $headers QueryInnerGroupMemberListHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryInnerGroupMemberListResponse QueryInnerGroupMemberListResponse
     */
    public function queryInnerGroupMemberListWithOptions($request, $headers, $runtime)
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryInnerGroupMemberList',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/innerGroups/memberLists/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryInnerGroupMemberListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 读取群成员列表
     *  *
     * @param QueryInnerGroupMemberListRequest $request QueryInnerGroupMemberListRequest
     *
     * @return QueryInnerGroupMemberListResponse QueryInnerGroupMemberListResponse
     */
    public function queryInnerGroupMemberList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryInnerGroupMemberListHeaders([]);

        return $this->queryInnerGroupMemberListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询最近活跃的企业内部群列表
     *  *
     * @param QueryInnerGroupRecentListRequest $request QueryInnerGroupRecentListRequest
     * @param QueryInnerGroupRecentListHeaders $headers QueryInnerGroupRecentListHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryInnerGroupRecentListResponse QueryInnerGroupRecentListResponse
     */
    public function queryInnerGroupRecentListWithOptions($request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryInnerGroupRecentList',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/innerGroups/recentLists',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryInnerGroupRecentListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询最近活跃的企业内部群列表
     *  *
     * @param QueryInnerGroupRecentListRequest $request QueryInnerGroupRecentListRequest
     *
     * @return QueryInnerGroupRecentListResponse QueryInnerGroupRecentListResponse
     */
    public function queryInnerGroupRecentList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryInnerGroupRecentListHeaders([]);

        return $this->queryInnerGroupRecentListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询群内具有指定群角色的所有群成员
     *  *
     * @param QueryMembersOfGroupRoleRequest $request QueryMembersOfGroupRoleRequest
     * @param QueryMembersOfGroupRoleHeaders $headers QueryMembersOfGroupRoleHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryMembersOfGroupRoleResponse QueryMembersOfGroupRoleResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryMembersOfGroupRole',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/sceneGroups/roles/members/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryMembersOfGroupRoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询群内具有指定群角色的所有群成员
     *  *
     * @param QueryMembersOfGroupRoleRequest $request QueryMembersOfGroupRoleRequest
     *
     * @return QueryMembersOfGroupRoleResponse QueryMembersOfGroupRoleResponse
     */
    public function queryMembersOfGroupRole($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMembersOfGroupRoleHeaders([]);

        return $this->queryMembersOfGroupRoleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据openTaskId查询消息发送结果
     *  *
     * @param QueryMessageSendResultRequest $request QueryMessageSendResultRequest
     * @param QueryMessageSendResultHeaders $headers QueryMessageSendResultHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryMessageSendResultResponse QueryMessageSendResultResponse
     */
    public function queryMessageSendResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openTaskId)) {
            $body['openTaskId'] = $request->openTaskId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryMessageSendResult',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/messages/sendResults/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMessageSendResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据openTaskId查询消息发送结果
     *  *
     * @param QueryMessageSendResultRequest $request QueryMessageSendResultRequest
     *
     * @return QueryMessageSendResultResponse QueryMessageSendResultResponse
     */
    public function queryMessageSendResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMessageSendResultHeaders([]);

        return $this->queryMessageSendResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary  根据单聊会话及发送方获取接收方用户信息
     *  *
     * @param QueryOpenConversationReceiveUserRequest $request QueryOpenConversationReceiveUserRequest
     * @param QueryOpenConversationReceiveUserHeaders $headers QueryOpenConversationReceiveUserHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOpenConversationReceiveUserResponse QueryOpenConversationReceiveUserResponse
     */
    public function queryOpenConversationReceiveUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->sendUserId)) {
            $body['sendUserId'] = $request->sendUserId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryOpenConversationReceiveUser',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/otoChat/receiveUsers/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryOpenConversationReceiveUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary  根据单聊会话及发送方获取接收方用户信息
     *  *
     * @param QueryOpenConversationReceiveUserRequest $request QueryOpenConversationReceiveUserRequest
     *
     * @return QueryOpenConversationReceiveUserResponse QueryOpenConversationReceiveUserResponse
     */
    public function queryOpenConversationReceiveUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOpenConversationReceiveUserHeaders([]);

        return $this->queryOpenConversationReceiveUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取群基础信息
     *  *
     * @param QueryOpenGroupBaseInfoRequest $request QueryOpenGroupBaseInfoRequest
     * @param QueryOpenGroupBaseInfoHeaders $headers QueryOpenGroupBaseInfoHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOpenGroupBaseInfoResponse QueryOpenGroupBaseInfoResponse
     */
    public function queryOpenGroupBaseInfoWithOptions($request, $headers, $runtime)
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryOpenGroupBaseInfo',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/groups/baseInfos/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryOpenGroupBaseInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取群基础信息
     *  *
     * @param QueryOpenGroupBaseInfoRequest $request QueryOpenGroupBaseInfoRequest
     *
     * @return QueryOpenGroupBaseInfoResponse QueryOpenGroupBaseInfoResponse
     */
    public function queryOpenGroupBaseInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOpenGroupBaseInfoHeaders([]);

        return $this->queryOpenGroupBaseInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 用户身份查询消息已读未读状态
     *  *
     * @param QueryPersonalMessageReadStatusRequest $request QueryPersonalMessageReadStatusRequest
     * @param QueryPersonalMessageReadStatusHeaders $headers QueryPersonalMessageReadStatusHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryPersonalMessageReadStatusResponse QueryPersonalMessageReadStatusResponse
     */
    public function queryPersonalMessageReadStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openMessageId)) {
            $body['openMessageId'] = $request->openMessageId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryPersonalMessageReadStatus',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/me/messages/readStatuses/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryPersonalMessageReadStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 用户身份查询消息已读未读状态
     *  *
     * @param QueryPersonalMessageReadStatusRequest $request QueryPersonalMessageReadStatusRequest
     *
     * @return QueryPersonalMessageReadStatusResponse QueryPersonalMessageReadStatusResponse
     */
    public function queryPersonalMessageReadStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPersonalMessageReadStatusHeaders([]);

        return $this->queryPersonalMessageReadStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取最近联系人及群组
     *  *
     * @param QueryRecentConversationsRequest $request QueryRecentConversationsRequest
     * @param QueryRecentConversationsHeaders $headers QueryRecentConversationsHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryRecentConversationsResponse QueryRecentConversationsResponse
     */
    public function queryRecentConversationsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->onlyHuman)) {
            $body['onlyHuman'] = $request->onlyHuman;
        }
        if (!Utils::isUnset($request->onlyInnerGroup)) {
            $body['onlyInnerGroup'] = $request->onlyInnerGroup;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryRecentConversations',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/conversations/recentLists/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryRecentConversationsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取最近联系人及群组
     *  *
     * @param QueryRecentConversationsRequest $request QueryRecentConversationsRequest
     *
     * @return QueryRecentConversationsResponse QueryRecentConversationsResponse
     */
    public function queryRecentConversations($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRecentConversationsHeaders([]);

        return $this->queryRecentConversationsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询群内群模板机器人
     *  *
     * @param QuerySceneGroupTemplateRobotRequest $request QuerySceneGroupTemplateRobotRequest
     * @param QuerySceneGroupTemplateRobotHeaders $headers QuerySceneGroupTemplateRobotHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return QuerySceneGroupTemplateRobotResponse QuerySceneGroupTemplateRobotResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QuerySceneGroupTemplateRobot',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/sceneGroups/templates/robots',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QuerySceneGroupTemplateRobotResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询群内群模板机器人
     *  *
     * @param QuerySceneGroupTemplateRobotRequest $request QuerySceneGroupTemplateRobotRequest
     *
     * @return QuerySceneGroupTemplateRobotResponse QuerySceneGroupTemplateRobotResponse
     */
    public function querySceneGroupTemplateRobot($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySceneGroupTemplateRobotHeaders([]);

        return $this->querySceneGroupTemplateRobotWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询群信息
     *  *
     * @param QuerySingleGroupRequest $request QuerySingleGroupRequest
     * @param QuerySingleGroupHeaders $headers QuerySingleGroupHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return QuerySingleGroupResponse QuerySingleGroupResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QuerySingleGroup',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/doubleGroups/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QuerySingleGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询群信息
     *  *
     * @param QuerySingleGroupRequest $request QuerySingleGroupRequest
     *
     * @return QuerySingleGroupResponse QuerySingleGroupResponse
     */
    public function querySingleGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySingleGroupHeaders([]);

        return $this->querySingleGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询未读消息数
     *  *
     * @param QueryUnReadMessageRequest $request QueryUnReadMessageRequest
     * @param QueryUnReadMessageHeaders $headers QueryUnReadMessageHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUnReadMessageResponse QueryUnReadMessageResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryUnReadMessage',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/unReadMsgs/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryUnReadMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询未读消息数
     *  *
     * @param QueryUnReadMessageRequest $request QueryUnReadMessageRequest
     *
     * @return QueryUnReadMessageResponse QueryUnReadMessageResponse
     */
    public function queryUnReadMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUnReadMessageHeaders([]);

        return $this->queryUnReadMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询链接查询链接增强注册信息创建者
     *  *
     * @param QueryUnfurlingRegisterCreatorRequest $request QueryUnfurlingRegisterCreatorRequest
     * @param QueryUnfurlingRegisterCreatorHeaders $headers QueryUnfurlingRegisterCreatorHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUnfurlingRegisterCreatorResponse QueryUnfurlingRegisterCreatorResponse
     */
    public function queryUnfurlingRegisterCreatorWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->domain)) {
            $query['domain'] = $request->domain;
        }
        if (!Utils::isUnset($request->path)) {
            $query['path'] = $request->path;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryUnfurlingRegisterCreator',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/unfurling/rules/creators',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryUnfurlingRegisterCreatorResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询链接查询链接增强注册信息创建者
     *  *
     * @param QueryUnfurlingRegisterCreatorRequest $request QueryUnfurlingRegisterCreatorRequest
     *
     * @return QueryUnfurlingRegisterCreatorResponse QueryUnfurlingRegisterCreatorResponse
     */
    public function queryUnfurlingRegisterCreator($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUnfurlingRegisterCreatorHeaders([]);

        return $this->queryUnfurlingRegisterCreatorWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询链接增强注册信息列表
     *  *
     * @param QueryUnfurlingRegisterInfoRequest $request QueryUnfurlingRegisterInfoRequest
     * @param QueryUnfurlingRegisterInfoHeaders $headers QueryUnfurlingRegisterInfoHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUnfurlingRegisterInfoResponse QueryUnfurlingRegisterInfoResponse
     */
    public function queryUnfurlingRegisterInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appId)) {
            $query['appId'] = $request->appId;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryUnfurlingRegisterInfo',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/unfurling/rules',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryUnfurlingRegisterInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询链接增强注册信息列表
     *  *
     * @param QueryUnfurlingRegisterInfoRequest $request QueryUnfurlingRegisterInfoRequest
     *
     * @return QueryUnfurlingRegisterInfoResponse QueryUnfurlingRegisterInfoResponse
     */
    public function queryUnfurlingRegisterInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUnfurlingRegisterInfoHeaders([]);

        return $this->queryUnfurlingRegisterInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询群主视角群LastMessage时间
     *  *
     * @param QueryUserViewGroupLastMessageTimeRequest $request QueryUserViewGroupLastMessageTimeRequest
     * @param QueryUserViewGroupLastMessageTimeHeaders $headers QueryUserViewGroupLastMessageTimeHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserViewGroupLastMessageTimeResponse QueryUserViewGroupLastMessageTimeResponse
     */
    public function queryUserViewGroupLastMessageTimeWithOptions($request, $headers, $runtime)
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryUserViewGroupLastMessageTime',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/chats/lastMessageTime/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryUserViewGroupLastMessageTimeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询群主视角群LastMessage时间
     *  *
     * @param QueryUserViewGroupLastMessageTimeRequest $request QueryUserViewGroupLastMessageTimeRequest
     *
     * @return QueryUserViewGroupLastMessageTimeResponse QueryUserViewGroupLastMessageTimeResponse
     */
    public function queryUserViewGroupLastMessageTime($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserViewGroupLastMessageTimeHeaders([]);

        return $this->queryUserViewGroupLastMessageTimeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 用户身份设置消息状态为已读
     *  *
     * @param ReadPersonalMessageRequest $request ReadPersonalMessageRequest
     * @param ReadPersonalMessageHeaders $headers ReadPersonalMessageHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return ReadPersonalMessageResponse ReadPersonalMessageResponse
     */
    public function readPersonalMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingOpenConversationMessageIdArray)) {
            $body['dingOpenConversationMessageIdArray'] = $request->dingOpenConversationMessageIdArray;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ReadPersonalMessage',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/me/messages/readStatuses/set',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ReadPersonalMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 用户身份设置消息状态为已读
     *  *
     * @param ReadPersonalMessageRequest $request ReadPersonalMessageRequest
     *
     * @return ReadPersonalMessageResponse ReadPersonalMessageResponse
     */
    public function readPersonalMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReadPersonalMessageHeaders([]);

        return $this->readPersonalMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 用户身份撤回消息
     *  *
     * @param RecallPersonalMessageRequest $request RecallPersonalMessageRequest
     * @param RecallPersonalMessageHeaders $headers RecallPersonalMessageHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return RecallPersonalMessageResponse RecallPersonalMessageResponse
     */
    public function recallPersonalMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openMessageId)) {
            $body['openMessageId'] = $request->openMessageId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'RecallPersonalMessage',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/me/messages/recall',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RecallPersonalMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 用户身份撤回消息
     *  *
     * @param RecallPersonalMessageRequest $request RecallPersonalMessageRequest
     *
     * @return RecallPersonalMessageResponse RecallPersonalMessageResponse
     */
    public function recallPersonalMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RecallPersonalMessageHeaders([]);

        return $this->recallPersonalMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 链接增强规则发布
     *  *
     * @param ReleaseUnfurlingRegisterRequest $request ReleaseUnfurlingRegisterRequest
     * @param ReleaseUnfurlingRegisterHeaders $headers ReleaseUnfurlingRegisterHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return ReleaseUnfurlingRegisterResponse ReleaseUnfurlingRegisterResponse
     */
    public function releaseUnfurlingRegisterWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->id)) {
            $body['id'] = $request->id;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ReleaseUnfurlingRegister',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/unfurling/rules/publish',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ReleaseUnfurlingRegisterResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 链接增强规则发布
     *  *
     * @param ReleaseUnfurlingRegisterRequest $request ReleaseUnfurlingRegisterRequest
     *
     * @return ReleaseUnfurlingRegisterResponse ReleaseUnfurlingRegisterResponse
     */
    public function releaseUnfurlingRegister($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReleaseUnfurlingRegisterHeaders([]);

        return $this->releaseUnfurlingRegisterWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 移除会话机器人
     *  *
     * @param RemoveRobotFromConversationRequest $request RemoveRobotFromConversationRequest
     * @param RemoveRobotFromConversationHeaders $headers RemoveRobotFromConversationHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return RemoveRobotFromConversationResponse RemoveRobotFromConversationResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'RemoveRobotFromConversation',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/conversations/robots/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RemoveRobotFromConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 移除会话机器人
     *  *
     * @param RemoveRobotFromConversationRequest $request RemoveRobotFromConversationRequest
     *
     * @return RemoveRobotFromConversationResponse RemoveRobotFromConversationResponse
     */
    public function removeRobotFromConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveRobotFromConversationHeaders([]);

        return $this->removeRobotFromConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据关键词搜索企业内部群
     *  *
     * @param SearchInnerGroupsRequest $request SearchInnerGroupsRequest
     * @param SearchInnerGroupsHeaders $headers SearchInnerGroupsHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchInnerGroupsResponse SearchInnerGroupsResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SearchInnerGroups',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/innerGroups/search',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SearchInnerGroupsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据关键词搜索企业内部群
     *  *
     * @param SearchInnerGroupsRequest $request SearchInnerGroupsRequest
     *
     * @return SearchInnerGroupsResponse SearchInnerGroupsResponse
     */
    public function searchInnerGroups($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchInnerGroupsHeaders([]);

        return $this->searchInnerGroupsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送可交互式动态卡片
     *  *
     * @param SendInteractiveCardRequest $request SendInteractiveCardRequest
     * @param SendInteractiveCardHeaders $headers SendInteractiveCardHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return SendInteractiveCardResponse SendInteractiveCardResponse
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
        if (!Utils::isUnset($request->digitalWorkerCode)) {
            $body['digitalWorkerCode'] = $request->digitalWorkerCode;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SendInteractiveCard',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interactiveCards/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendInteractiveCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送可交互式动态卡片
     *  *
     * @param SendInteractiveCardRequest $request SendInteractiveCardRequest
     *
     * @return SendInteractiveCardResponse SendInteractiveCardResponse
     */
    public function sendInteractiveCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendInteractiveCardHeaders([]);

        return $this->sendInteractiveCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 人与人单聊发送可交互式动态卡片
     *  *
     * @param SendOTOInteractiveCardRequest $request SendOTOInteractiveCardRequest
     * @param SendOTOInteractiveCardHeaders $headers SendOTOInteractiveCardHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return SendOTOInteractiveCardResponse SendOTOInteractiveCardResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SendOTOInteractiveCard',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/privateChat/interactiveCards/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendOTOInteractiveCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 人与人单聊发送可交互式动态卡片
     *  *
     * @param SendOTOInteractiveCardRequest $request SendOTOInteractiveCardRequest
     *
     * @return SendOTOInteractiveCardResponse SendOTOInteractiveCardResponse
     */
    public function sendOTOInteractiveCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendOTOInteractiveCardHeaders([]);

        return $this->sendOTOInteractiveCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 委托权限发消息
     *  *
     * @param SendPersonalMessageRequest $request SendPersonalMessageRequest
     * @param SendPersonalMessageHeaders $headers SendPersonalMessageHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return SendPersonalMessageResponse SendPersonalMessageResponse
     */
    public function sendPersonalMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->msgType)) {
            $body['msgType'] = $request->msgType;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->receiverUserId)) {
            $body['receiverUserId'] = $request->receiverUserId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SendPersonalMessage',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/me/messages/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendPersonalMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 委托权限发消息
     *  *
     * @param SendPersonalMessageRequest $request SendPersonalMessageRequest
     *
     * @return SendPersonalMessageResponse SendPersonalMessageResponse
     */
    public function sendPersonalMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendPersonalMessageHeaders([]);

        return $this->sendPersonalMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 机器人发送互动卡片（普通版）
     *  *
     * @param SendRobotInteractiveCardRequest $request SendRobotInteractiveCardRequest
     * @param SendRobotInteractiveCardHeaders $headers SendRobotInteractiveCardHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return SendRobotInteractiveCardResponse SendRobotInteractiveCardResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SendRobotInteractiveCard',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/v1.0/robot/interactiveCards/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendRobotInteractiveCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 机器人发送互动卡片（普通版）
     *  *
     * @param SendRobotInteractiveCardRequest $request SendRobotInteractiveCardRequest
     *
     * @return SendRobotInteractiveCardResponse SendRobotInteractiveCardResponse
     */
    public function sendRobotInteractiveCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendRobotInteractiveCardHeaders([]);

        return $this->sendRobotInteractiveCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 机器人发送消息
     *  *
     * @param SendRobotMessageRequest $request SendRobotMessageRequest
     * @param SendRobotMessageHeaders $headers SendRobotMessageHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return SendRobotMessageResponse SendRobotMessageResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SendRobotMessage',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/robotMessages/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendRobotMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 机器人发送消息
     *  *
     * @param SendRobotMessageRequest $request SendRobotMessageRequest
     *
     * @return SendRobotMessageResponse SendRobotMessageResponse
     */
    public function sendRobotMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendRobotMessageHeaders([]);

        return $this->sendRobotMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送模板响应式可交互式卡片
     *  *
     * @param SendTemplateInteractiveCardRequest $request SendTemplateInteractiveCardRequest
     * @param SendTemplateInteractiveCardHeaders $headers SendTemplateInteractiveCardHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return SendTemplateInteractiveCardResponse SendTemplateInteractiveCardResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SendTemplateInteractiveCard',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interactiveCards/templates/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendTemplateInteractiveCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送模板响应式可交互式卡片
     *  *
     * @param SendTemplateInteractiveCardRequest $request SendTemplateInteractiveCardRequest
     *
     * @return SendTemplateInteractiveCardResponse SendTemplateInteractiveCardResponse
     */
    public function sendTemplateInteractiveCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendTemplateInteractiveCardHeaders([]);

        return $this->sendTemplateInteractiveCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设置侧边栏
     *  *
     * @param SetRightPanelRequest $request SetRightPanelRequest
     * @param SetRightPanelHeaders $headers SetRightPanelHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return SetRightPanelResponse SetRightPanelResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SetRightPanel',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/rightPanels/set',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SetRightPanelResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置侧边栏
     *  *
     * @param SetRightPanelRequest $request SetRightPanelRequest
     *
     * @return SetRightPanelResponse SetRightPanelResponse
     */
    public function setRightPanel($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetRightPanelHeaders([]);

        return $this->setRightPanelWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 启用群模板(超管接口)
     *  *
     * @param SuperAdminApplyTemplateRequest $request SuperAdminApplyTemplateRequest
     * @param SuperAdminApplyTemplateHeaders $headers SuperAdminApplyTemplateHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return SuperAdminApplyTemplateResponse SuperAdminApplyTemplateResponse
     */
    public function superAdminApplyTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->ownerUserId)) {
            $body['ownerUserId'] = $request->ownerUserId;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SuperAdminApplyTemplate',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/chats/scenegroups/templates/apply',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SuperAdminApplyTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 启用群模板(超管接口)
     *  *
     * @param SuperAdminApplyTemplateRequest $request SuperAdminApplyTemplateRequest
     *
     * @return SuperAdminApplyTemplateResponse SuperAdminApplyTemplateResponse
     */
    public function superAdminApplyTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SuperAdminApplyTemplateHeaders([]);

        return $this->superAdminApplyTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 停用群模板（超管接口）
     *  *
     * @param SuperAdminCloseTemplateRequest $request SuperAdminCloseTemplateRequest
     * @param SuperAdminCloseTemplateHeaders $headers SuperAdminCloseTemplateHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return SuperAdminCloseTemplateResponse SuperAdminCloseTemplateResponse
     */
    public function superAdminCloseTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->ownerUserId)) {
            $body['ownerUserId'] = $request->ownerUserId;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SuperAdminCloseTemplate',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/chats/scenegroups/templates/close',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SuperAdminCloseTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 停用群模板（超管接口）
     *  *
     * @param SuperAdminCloseTemplateRequest $request SuperAdminCloseTemplateRequest
     *
     * @return SuperAdminCloseTemplateResponse SuperAdminCloseTemplateResponse
     */
    public function superAdminCloseTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SuperAdminCloseTemplateHeaders([]);

        return $this->superAdminCloseTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 钉钉吊顶卡片关闭
     *  *
     * @param TopboxCloseRequest $request TopboxCloseRequest
     * @param TopboxCloseHeaders $headers TopboxCloseHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return TopboxCloseResponse TopboxCloseResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'TopboxClose',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/topBoxes/close',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'none',
        ]);

        return TopboxCloseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 钉钉吊顶卡片关闭
     *  *
     * @param TopboxCloseRequest $request TopboxCloseRequest
     *
     * @return TopboxCloseResponse TopboxCloseResponse
     */
    public function topboxClose($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TopboxCloseHeaders([]);

        return $this->topboxCloseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 钉钉吊顶卡片开启
     *  *
     * @param TopboxOpenRequest $request TopboxOpenRequest
     * @param TopboxOpenHeaders $headers TopboxOpenHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return TopboxOpenResponse TopboxOpenResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'TopboxOpen',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/topBoxes/open',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'none',
        ]);

        return TopboxOpenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 钉钉吊顶卡片开启
     *  *
     * @param TopboxOpenRequest $request TopboxOpenRequest
     *
     * @return TopboxOpenResponse TopboxOpenResponse
     */
    public function topboxOpen($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TopboxOpenHeaders([]);

        return $this->topboxOpenWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新钉内用户C端展示的头像和名称（互通群、钉内两人群）
     *  *
     * @param UpdateClientServiceRequest $request UpdateClientServiceRequest
     * @param UpdateClientServiceHeaders $headers UpdateClientServiceHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateClientServiceResponse UpdateClientServiceResponse
     */
    public function updateClientServiceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->avatarUrl)) {
            $body['avatarUrl'] = $request->avatarUrl;
        }
        if (!Utils::isUnset($request->resetAvatar)) {
            $body['resetAvatar'] = $request->resetAvatar;
        }
        if (!Utils::isUnset($request->resetUserName)) {
            $body['resetUserName'] = $request->resetUserName;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
        }
        if (!Utils::isUnset($request->userName)) {
            $body['userName'] = $request->userName;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateClientService',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/clientServices/avatarAndName',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateClientServiceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新钉内用户C端展示的头像和名称（互通群、钉内两人群）
     *  *
     * @param UpdateClientServiceRequest $request UpdateClientServiceRequest
     *
     * @return UpdateClientServiceResponse UpdateClientServiceResponse
     */
    public function updateClientService($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateClientServiceHeaders([]);

        return $this->updateClientServiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改群头像
     *  *
     * @param UpdateGroupAvatarRequest $request UpdateGroupAvatarRequest
     * @param UpdateGroupAvatarHeaders $headers UpdateGroupAvatarHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateGroupAvatarResponse UpdateGroupAvatarResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateGroupAvatar',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/groups/avatars',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateGroupAvatarResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改群头像
     *  *
     * @param UpdateGroupAvatarRequest $request UpdateGroupAvatarRequest
     *
     * @return UpdateGroupAvatarResponse UpdateGroupAvatarResponse
     */
    public function updateGroupAvatar($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGroupAvatarHeaders([]);

        return $this->updateGroupAvatarWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改群名称
     *  *
     * @param UpdateGroupNameRequest $request UpdateGroupNameRequest
     * @param UpdateGroupNameHeaders $headers UpdateGroupNameHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateGroupNameResponse UpdateGroupNameResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateGroupName',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/groups/names',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateGroupNameResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改群名称
     *  *
     * @param UpdateGroupNameRequest $request UpdateGroupNameRequest
     *
     * @return UpdateGroupNameResponse UpdateGroupNameResponse
     */
    public function updateGroupName($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGroupNameHeaders([]);

        return $this->updateGroupNameWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设置场景群权限项
     *  *
     * @param UpdateGroupPermissionRequest $request UpdateGroupPermissionRequest
     * @param UpdateGroupPermissionHeaders $headers UpdateGroupPermissionHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateGroupPermissionResponse UpdateGroupPermissionResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateGroupPermission',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/sceneGroups/permissions',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateGroupPermissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置场景群权限项
     *  *
     * @param UpdateGroupPermissionRequest $request UpdateGroupPermissionRequest
     *
     * @return UpdateGroupPermissionResponse UpdateGroupPermissionResponse
     */
    public function updateGroupPermission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGroupPermissionHeaders([]);

        return $this->updateGroupPermissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新群管理员
     *  *
     * @param UpdateGroupSubAdminRequest $request UpdateGroupSubAdminRequest
     * @param UpdateGroupSubAdminHeaders $headers UpdateGroupSubAdminHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateGroupSubAdminResponse UpdateGroupSubAdminResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateGroupSubAdmin',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/sceneGroups/subAdmins',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateGroupSubAdminResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新群管理员
     *  *
     * @param UpdateGroupSubAdminRequest $request UpdateGroupSubAdminRequest
     *
     * @return UpdateGroupSubAdminResponse UpdateGroupSubAdminResponse
     */
    public function updateGroupSubAdmin($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGroupSubAdminHeaders([]);

        return $this->updateGroupSubAdminWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新可交互式动态卡片
     *  *
     * @param UpdateInteractiveCardRequest $request UpdateInteractiveCardRequest
     * @param UpdateInteractiveCardHeaders $headers UpdateInteractiveCardHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateInteractiveCardResponse UpdateInteractiveCardResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateInteractiveCard',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interactiveCards',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateInteractiveCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新可交互式动态卡片
     *  *
     * @param UpdateInteractiveCardRequest $request UpdateInteractiveCardRequest
     *
     * @return UpdateInteractiveCardResponse UpdateInteractiveCardResponse
     */
    public function updateInteractiveCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInteractiveCardHeaders([]);

        return $this->updateInteractiveCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设置群成员禁言状态
     *  *
     * @param UpdateMemberBanWordsRequest $request UpdateMemberBanWordsRequest
     * @param UpdateMemberBanWordsHeaders $headers UpdateMemberBanWordsHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateMemberBanWordsResponse UpdateMemberBanWordsResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateMemberBanWords',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/sceneGroups/muteMembers/set',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'none',
        ]);

        return UpdateMemberBanWordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置群成员禁言状态
     *  *
     * @param UpdateMemberBanWordsRequest $request UpdateMemberBanWordsRequest
     *
     * @return UpdateMemberBanWordsResponse UpdateMemberBanWordsResponse
     */
    public function updateMemberBanWords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateMemberBanWordsHeaders([]);

        return $this->updateMemberBanWordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新群成员的群昵称
     *  *
     * @param UpdateMemberGroupNickRequest $request UpdateMemberGroupNickRequest
     * @param UpdateMemberGroupNickHeaders $headers UpdateMemberGroupNickHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateMemberGroupNickResponse UpdateMemberGroupNickResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateMemberGroupNick',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/sceneGroups/members/groupNicks',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateMemberGroupNickResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新群成员的群昵称
     *  *
     * @param UpdateMemberGroupNickRequest $request UpdateMemberGroupNickRequest
     *
     * @return UpdateMemberGroupNickResponse UpdateMemberGroupNickResponse
     */
    public function updateMemberGroupNick($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateMemberGroupNickHeaders([]);

        return $this->updateMemberGroupNickWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改组织里的机器人
     *  *
     * @param UpdateRobotInOrgRequest $request UpdateRobotInOrgRequest
     * @param UpdateRobotInOrgHeaders $headers UpdateRobotInOrgHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateRobotInOrgResponse UpdateRobotInOrgResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateRobotInOrg',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/organizations/robots',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateRobotInOrgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改组织里的机器人
     *  *
     * @param UpdateRobotInOrgRequest $request UpdateRobotInOrgRequest
     *
     * @return UpdateRobotInOrgResponse UpdateRobotInOrgResponse
     */
    public function updateRobotInOrg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRobotInOrgHeaders([]);

        return $this->updateRobotInOrgWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 机器人更新可交互式卡片(个人、企业)
     *  *
     * @param UpdateRobotInteractiveCardRequest $request UpdateRobotInteractiveCardRequest
     * @param UpdateRobotInteractiveCardHeaders $headers UpdateRobotInteractiveCardHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateRobotInteractiveCardResponse UpdateRobotInteractiveCardResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateRobotInteractiveCard',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/robots/interactiveCards',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateRobotInteractiveCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 机器人更新可交互式卡片(个人、企业)
     *  *
     * @param UpdateRobotInteractiveCardRequest $request UpdateRobotInteractiveCardRequest
     *
     * @return UpdateRobotInteractiveCardResponse UpdateRobotInteractiveCardResponse
     */
    public function updateRobotInteractiveCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRobotInteractiveCardHeaders([]);

        return $this->updateRobotInteractiveCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改场景群模板消息存档能力开启状态
     *  *
     * @param UpdateSceneGroupTemplateMessageOpenStatusRequest $request UpdateSceneGroupTemplateMessageOpenStatusRequest
     * @param UpdateSceneGroupTemplateMessageOpenStatusHeaders $headers UpdateSceneGroupTemplateMessageOpenStatusHeaders
     * @param RuntimeOptions                                   $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateSceneGroupTemplateMessageOpenStatusResponse UpdateSceneGroupTemplateMessageOpenStatusResponse
     */
    public function updateSceneGroupTemplateMessageOpenStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->templateIdList)) {
            $body['templateIdList'] = $request->templateIdList;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateSceneGroupTemplateMessageOpenStatus',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/chats/sceneGroups/templates/messageOpenStatuses',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateSceneGroupTemplateMessageOpenStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改场景群模板消息存档能力开启状态
     *  *
     * @param UpdateSceneGroupTemplateMessageOpenStatusRequest $request UpdateSceneGroupTemplateMessageOpenStatusRequest
     *
     * @return UpdateSceneGroupTemplateMessageOpenStatusResponse UpdateSceneGroupTemplateMessageOpenStatusResponse
     */
    public function updateSceneGroupTemplateMessageOpenStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateSceneGroupTemplateMessageOpenStatusHeaders([]);

        return $this->updateSceneGroupTemplateMessageOpenStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设置群成员的群角色
     *  *
     * @param UpdateTheGroupRolesOfGroupMemberRequest $request UpdateTheGroupRolesOfGroupMemberRequest
     * @param UpdateTheGroupRolesOfGroupMemberHeaders $headers UpdateTheGroupRolesOfGroupMemberHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTheGroupRolesOfGroupMemberResponse UpdateTheGroupRolesOfGroupMemberResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateTheGroupRolesOfGroupMember',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/sceneGroups/members/groupRoles',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateTheGroupRolesOfGroupMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置群成员的群角色
     *  *
     * @param UpdateTheGroupRolesOfGroupMemberRequest $request UpdateTheGroupRolesOfGroupMemberRequest
     *
     * @return UpdateTheGroupRolesOfGroupMemberResponse UpdateTheGroupRolesOfGroupMemberResponse
     */
    public function updateTheGroupRolesOfGroupMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTheGroupRolesOfGroupMemberHeaders([]);

        return $this->updateTheGroupRolesOfGroupMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑链接增强注册规则
     *  *
     * @param UpdateUnfurlingRegisterRequest $request UpdateUnfurlingRegisterRequest
     * @param UpdateUnfurlingRegisterHeaders $headers UpdateUnfurlingRegisterHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateUnfurlingRegisterResponse UpdateUnfurlingRegisterResponse
     */
    public function updateUnfurlingRegisterWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->apiSecret)) {
            $body['apiSecret'] = $request->apiSecret;
        }
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->callbackUrl)) {
            $body['callbackUrl'] = $request->callbackUrl;
        }
        if (!Utils::isUnset($request->cardTemplateId)) {
            $body['cardTemplateId'] = $request->cardTemplateId;
        }
        if (!Utils::isUnset($request->domain)) {
            $body['domain'] = $request->domain;
        }
        if (!Utils::isUnset($request->id)) {
            $body['id'] = $request->id;
        }
        if (!Utils::isUnset($request->path)) {
            $body['path'] = $request->path;
        }
        if (!Utils::isUnset($request->ruleDesc)) {
            $body['ruleDesc'] = $request->ruleDesc;
        }
        if (!Utils::isUnset($request->ruleMatchType)) {
            $body['ruleMatchType'] = $request->ruleMatchType;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateUnfurlingRegister',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/unfurling/rules',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateUnfurlingRegisterResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑链接增强注册规则
     *  *
     * @param UpdateUnfurlingRegisterRequest $request UpdateUnfurlingRegisterRequest
     *
     * @return UpdateUnfurlingRegisterResponse UpdateUnfurlingRegisterResponse
     */
    public function updateUnfurlingRegister($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateUnfurlingRegisterHeaders([]);

        return $this->updateUnfurlingRegisterWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 链接增强规则状态更新
     *  *
     * @param UpdateUnfurlingRegisterStatusRequest $request UpdateUnfurlingRegisterStatusRequest
     * @param UpdateUnfurlingRegisterStatusHeaders $headers UpdateUnfurlingRegisterStatusHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateUnfurlingRegisterStatusResponse UpdateUnfurlingRegisterStatusResponse
     */
    public function updateUnfurlingRegisterStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->id)) {
            $body['id'] = $request->id;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateUnfurlingRegisterStatus',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/unfurling/rules/statuses',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateUnfurlingRegisterStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 链接增强规则状态更新
     *  *
     * @param UpdateUnfurlingRegisterStatusRequest $request UpdateUnfurlingRegisterStatusRequest
     *
     * @return UpdateUnfurlingRegisterStatusResponse UpdateUnfurlingRegisterStatusResponse
     */
    public function updateUnfurlingRegisterStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateUnfurlingRegisterStatusHeaders([]);

        return $this->updateUnfurlingRegisterStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 升级群为外部群
     *  *
     * @param UpgradeToExternalGroupRequest $request UpgradeToExternalGroupRequest
     * @param UpgradeToExternalGroupHeaders $headers UpgradeToExternalGroupHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return UpgradeToExternalGroupResponse UpgradeToExternalGroupResponse
     */
    public function upgradeToExternalGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpgradeToExternalGroup',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/chats/sceneGroups/upgradeToExternalGroup',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpgradeToExternalGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 升级群为外部群
     *  *
     * @param UpgradeToExternalGroupRequest $request UpgradeToExternalGroupRequest
     *
     * @return UpgradeToExternalGroupResponse UpgradeToExternalGroupResponse
     */
    public function upgradeToExternalGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpgradeToExternalGroupHeaders([]);

        return $this->upgradeToExternalGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 升级为B2C群
     *  *
     * @param UpgradeToServiceGroupRequest $request UpgradeToServiceGroupRequest
     * @param UpgradeToServiceGroupHeaders $headers UpgradeToServiceGroupHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return UpgradeToServiceGroupResponse UpgradeToServiceGroupResponse
     */
    public function upgradeToServiceGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpgradeToServiceGroup',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/chats/sceneGroups/upgradeToServiceGroup',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpgradeToServiceGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 升级为B2C群
     *  *
     * @param UpgradeToServiceGroupRequest $request UpgradeToServiceGroupRequest
     *
     * @return UpgradeToServiceGroupResponse UpgradeToServiceGroupResponse
     */
    public function upgradeToServiceGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpgradeToServiceGroupHeaders([]);

        return $this->upgradeToServiceGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加群成员
     *  *
     * @param AddGroupMemberRequest $request AddGroupMemberRequest
     * @param AddGroupMemberHeaders $headers AddGroupMemberHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return AddGroupMemberResponse AddGroupMemberResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'addGroupMember',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/groups/members',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddGroupMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加群成员
     *  *
     * @param AddGroupMemberRequest $request AddGroupMemberRequest
     *
     * @return AddGroupMemberResponse AddGroupMemberResponse
     */
    public function addGroupMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddGroupMemberHeaders([]);

        return $this->addGroupMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 移除群成员
     *  *
     * @param RemoveGroupMemberRequest $request RemoveGroupMemberRequest
     * @param RemoveGroupMemberHeaders $headers RemoveGroupMemberHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return RemoveGroupMemberResponse RemoveGroupMemberResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'removeGroupMember',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/groups/members/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RemoveGroupMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 移除群成员
     *  *
     * @param RemoveGroupMemberRequest $request RemoveGroupMemberRequest
     *
     * @return RemoveGroupMemberResponse RemoveGroupMemberResponse
     */
    public function removeGroupMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveGroupMemberHeaders([]);

        return $this->removeGroupMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送ToC消息
     *  *
     * @param SendDingMessageRequest $request SendDingMessageRequest
     * @param SendDingMessageHeaders $headers SendDingMessageHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return SendDingMessageResponse SendDingMessageResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'sendDingMessage',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/dingMessages/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendDingMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送ToC消息
     *  *
     * @param SendDingMessageRequest $request SendDingMessageRequest
     *
     * @return SendDingMessageResponse SendDingMessageResponse
     */
    public function sendDingMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendDingMessageHeaders([]);

        return $this->sendDingMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送ToB消息
     *  *
     * @param SendMessageRequest $request SendMessageRequest
     * @param SendMessageHeaders $headers SendMessageHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return SendMessageResponse SendMessageResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'sendMessage',
            'version' => 'im_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/im/interconnections/messages/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送ToB消息
     *  *
     * @param SendMessageRequest $request SendMessageRequest
     *
     * @return SendMessageResponse SendMessageResponse
     */
    public function sendMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendMessageHeaders([]);

        return $this->sendMessageWithOptions($request, $headers, $runtime);
    }
}
