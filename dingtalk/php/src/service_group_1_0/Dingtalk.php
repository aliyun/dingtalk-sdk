<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddContactMemberToGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddContactMemberToGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddContactMemberToGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddKnowledgeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddKnowledgeRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddKnowledgeResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddLibraryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddLibraryRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddLibraryResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddMemberToServiceGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddMemberToServiceGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddMemberToServiceGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenCategoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenCategoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenCategoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenKnowledgeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenKnowledgeRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenKnowledgeResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenLibraryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenLibraryRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenLibraryResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddTicketMemoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddTicketMemoRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddTicketMemoResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AssignTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AssignTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AssignTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchBindingGroupBizIdsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchBindingGroupBizIdsRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchBindingGroupBizIdsResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchGetGroupSetConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchGetGroupSetConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchGetGroupSetConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchQueryCustomerSendTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchQueryCustomerSendTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchQueryCustomerSendTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchQueryGroupMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchQueryGroupMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchQueryGroupMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchQuerySendMessageTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchQuerySendMessageTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchQuerySendMessageTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BoundTemplateToTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BoundTemplateToTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BoundTemplateToTeamResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CancelTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CancelTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CancelTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CategoryStatisticsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CategoryStatisticsRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CategoryStatisticsResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CloseConversationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CloseConversationRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CloseConversationResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CloseHumanSessionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CloseHumanSessionRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CloseHumanSessionResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ConversationCreatedNotifyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ConversationCreatedNotifyRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ConversationCreatedNotifyResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ConversationTransferBeginNotifyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ConversationTransferBeginNotifyRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ConversationTransferBeginNotifyResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ConversationTransferCompleteNotifyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ConversationTransferCompleteNotifyRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ConversationTransferCompleteNotifyResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupConversationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupConversationRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupConversationResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupSetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupSetRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupSetResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTeamResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CustomerSendMsgTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CustomerSendMsgTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CustomerSendMsgTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\DeleteGroupMembersFromGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\DeleteGroupMembersFromGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\DeleteGroupMembersFromGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\DeleteInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\DeleteInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\DeleteInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\DeleteKnowledgeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\DeleteKnowledgeRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\DeleteKnowledgeResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\EmotionStatisticsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\EmotionStatisticsRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\EmotionStatisticsResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\FinishTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\FinishTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\FinishTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetAuthTokenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetAuthTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetAuthTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetInstancesByIdsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetInstancesByIdsRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetInstancesByIdsResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetNegativeWordCloudHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetNegativeWordCloudRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetNegativeWordCloudResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetOssTempUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetOssTempUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetOssTempUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetStoragePolicyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetStoragePolicyRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetStoragePolicyResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetWordCloudHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetWordCloudRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetWordCloudResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GroupStatisticsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GroupStatisticsRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GroupStatisticsResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\IntentionCategoryStatisticsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\IntentionCategoryStatisticsRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\IntentionCategoryStatisticsResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\IntentionStatisticsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\IntentionStatisticsRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\IntentionStatisticsResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListTicketOperateRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListTicketOperateRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListTicketOperateRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListUserTeamsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListUserTeamsResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryActiveUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryActiveUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryActiveUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryCrmGroupContactHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryCrmGroupContactRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryCrmGroupContactResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryCustomerCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryCustomerCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryCustomerCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryCustomerTaskUserDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryCustomerTaskUserDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryCustomerTaskUserDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupSetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupSetRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupSetResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryInstancesByMultiConditionsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryInstancesByMultiConditionsRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryInstancesByMultiConditionsResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QuerySendMsgTaskStatisticsDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QuerySendMsgTaskStatisticsDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QuerySendMsgTaskStatisticsDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QuerySendMsgTaskStatisticsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QuerySendMsgTaskStatisticsRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QuerySendMsgTaskStatisticsResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryServiceGroupMessageReadStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryServiceGroupMessageReadStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryServiceGroupMessageReadStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueueNotifyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueueNotifyRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueueNotifyResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\RemoveContactFromOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\RemoveContactFromOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\RemoveContactFromOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ReportCustomerDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ReportCustomerDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ReportCustomerDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ReportCustomerStatisticsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ReportCustomerStatisticsRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ReportCustomerStatisticsResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ResubmitTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ResubmitTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ResubmitTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\RetractTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\RetractTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\RetractTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\RobotMessageRecallHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\RobotMessageRecallRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\RobotMessageRecallResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SaveFormInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SaveFormInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SaveFormInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SearchGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SearchGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SearchGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskSupportInviteJoinOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskSupportInviteJoinOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskSupportInviteJoinOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendServiceGroupMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendServiceGroupMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendServiceGroupMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SetRobotConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SetRobotConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SetRobotConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TakeTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TakeTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TakeTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TopicStatisticsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TopicStatisticsRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TopicStatisticsResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TransferTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TransferTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TransferTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateGroupSetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateGroupSetRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateGroupSetResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateGroupTagHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateGroupTagRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateGroupTagResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpgradeCloudGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpgradeCloudGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpgradeCloudGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpgradeNormalGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpgradeNormalGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpgradeNormalGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UrgeTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UrgeTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UrgeTicketResponse;
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
     * @summary 添加联系人到群里
     *  *
     * @param AddContactMemberToGroupRequest $request AddContactMemberToGroupRequest
     * @param AddContactMemberToGroupHeaders $headers AddContactMemberToGroupHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return AddContactMemberToGroupResponse AddContactMemberToGroupResponse
     */
    public function addContactMemberToGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fissionType)) {
            $body['fissionType'] = $request->fissionType;
        }
        if (!Utils::isUnset($request->memberUnionId)) {
            $body['memberUnionId'] = $request->memberUnionId;
        }
        if (!Utils::isUnset($request->memberUserId)) {
            $body['memberUserId'] = $request->memberUserId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'AddContactMemberToGroup',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/groups/contacts',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddContactMemberToGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加联系人到群里
     *  *
     * @param AddContactMemberToGroupRequest $request AddContactMemberToGroupRequest
     *
     * @return AddContactMemberToGroupResponse AddContactMemberToGroupResponse
     */
    public function addContactMemberToGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddContactMemberToGroupHeaders([]);

        return $this->addContactMemberToGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加知识点
     *  *
     * @param AddKnowledgeRequest $request AddKnowledgeRequest
     * @param AddKnowledgeHeaders $headers AddKnowledgeHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return AddKnowledgeResponse AddKnowledgeResponse
     */
    public function addKnowledgeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attachmentList)) {
            $body['attachmentList'] = $request->attachmentList;
        }
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->effectTimeend)) {
            $body['effectTimeend'] = $request->effectTimeend;
        }
        if (!Utils::isUnset($request->effectTimestart)) {
            $body['effectTimestart'] = $request->effectTimestart;
        }
        if (!Utils::isUnset($request->extTitle)) {
            $body['extTitle'] = $request->extTitle;
        }
        if (!Utils::isUnset($request->keyword)) {
            $body['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->libraryKey)) {
            $body['libraryKey'] = $request->libraryKey;
        }
        if (!Utils::isUnset($request->linkUrl)) {
            $body['linkUrl'] = $request->linkUrl;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->questionIds)) {
            $body['questionIds'] = $request->questionIds;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->sourcePrimaryKey)) {
            $body['sourcePrimaryKey'] = $request->sourcePrimaryKey;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
        }
        if (!Utils::isUnset($request->version)) {
            $body['version'] = $request->version;
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
            'action' => 'AddKnowledge',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/knowledges',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddKnowledgeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加知识点
     *  *
     * @param AddKnowledgeRequest $request AddKnowledgeRequest
     *
     * @return AddKnowledgeResponse AddKnowledgeResponse
     */
    public function addKnowledge($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddKnowledgeHeaders([]);

        return $this->addKnowledgeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加服务群知识库
     *  *
     * @param AddLibraryRequest $request AddLibraryRequest
     * @param AddLibraryHeaders $headers AddLibraryHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return AddLibraryResponse AddLibraryResponse
     */
    public function addLibraryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->openTeamIds)) {
            $body['openTeamIds'] = $request->openTeamIds;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->sourcePrimaryKey)) {
            $body['sourcePrimaryKey'] = $request->sourcePrimaryKey;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
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
            'action' => 'AddLibrary',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/librarys',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return AddLibraryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加服务群知识库
     *  *
     * @param AddLibraryRequest $request AddLibraryRequest
     *
     * @return AddLibraryResponse AddLibraryResponse
     */
    public function addLibrary($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddLibraryHeaders([]);

        return $this->addLibraryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加服务群群成员
     *  *
     * @param AddMemberToServiceGroupRequest $request AddMemberToServiceGroupRequest
     * @param AddMemberToServiceGroupHeaders $headers AddMemberToServiceGroupHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return AddMemberToServiceGroupResponse AddMemberToServiceGroupResponse
     */
    public function addMemberToServiceGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'AddMemberToServiceGroup',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/groups/members',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddMemberToServiceGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加服务群群成员
     *  *
     * @param AddMemberToServiceGroupRequest $request AddMemberToServiceGroupRequest
     *
     * @return AddMemberToServiceGroupResponse AddMemberToServiceGroupResponse
     */
    public function addMemberToServiceGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddMemberToServiceGroupHeaders([]);

        return $this->addMemberToServiceGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary OpenApi添加知识点类目
     *  *
     * @param AddOpenCategoryRequest $request AddOpenCategoryRequest
     * @param AddOpenCategoryHeaders $headers AddOpenCategoryHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return AddOpenCategoryResponse AddOpenCategoryResponse
     */
    public function addOpenCategoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->libraryId)) {
            $body['libraryId'] = $request->libraryId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->parentId)) {
            $body['parentId'] = $request->parentId;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action' => 'AddOpenCategory',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/openCategories',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddOpenCategoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary OpenApi添加知识点类目
     *  *
     * @param AddOpenCategoryRequest $request AddOpenCategoryRequest
     *
     * @return AddOpenCategoryResponse AddOpenCategoryResponse
     */
    public function addOpenCategory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddOpenCategoryHeaders([]);

        return $this->addOpenCategoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary OpenApi添加知识入库
     *  *
     * @param AddOpenKnowledgeRequest $request AddOpenKnowledgeRequest
     * @param AddOpenKnowledgeHeaders $headers AddOpenKnowledgeHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return AddOpenKnowledgeResponse AddOpenKnowledgeResponse
     */
    public function addOpenKnowledgeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attachments)) {
            $body['attachments'] = $request->attachments;
        }
        if (!Utils::isUnset($request->categoryId)) {
            $body['categoryId'] = $request->categoryId;
        }
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->effectTimeend)) {
            $body['effectTimeend'] = $request->effectTimeend;
        }
        if (!Utils::isUnset($request->effectTimestart)) {
            $body['effectTimestart'] = $request->effectTimestart;
        }
        if (!Utils::isUnset($request->extTitle)) {
            $body['extTitle'] = $request->extTitle;
        }
        if (!Utils::isUnset($request->keyword)) {
            $body['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->libraryId)) {
            $body['libraryId'] = $request->libraryId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->tags)) {
            $body['tags'] = $request->tags;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action' => 'AddOpenKnowledge',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/openKnowledges',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddOpenKnowledgeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary OpenApi添加知识入库
     *  *
     * @param AddOpenKnowledgeRequest $request AddOpenKnowledgeRequest
     *
     * @return AddOpenKnowledgeResponse AddOpenKnowledgeResponse
     */
    public function addOpenKnowledge($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddOpenKnowledgeHeaders([]);

        return $this->addOpenKnowledgeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 智能服务群知识库创建
     *  *
     * @param AddOpenLibraryRequest $request AddOpenLibraryRequest
     * @param AddOpenLibraryHeaders $headers AddOpenLibraryHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return AddOpenLibraryResponse AddOpenLibraryResponse
     */
    public function addOpenLibraryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action' => 'AddOpenLibrary',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/openLibraries',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddOpenLibraryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 智能服务群知识库创建
     *  *
     * @param AddOpenLibraryRequest $request AddOpenLibraryRequest
     *
     * @return AddOpenLibraryResponse AddOpenLibraryResponse
     */
    public function addOpenLibrary($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddOpenLibraryHeaders([]);

        return $this->addOpenLibraryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加工单备注
     *  *
     * @param AddTicketMemoRequest $request AddTicketMemoRequest
     * @param AddTicketMemoHeaders $headers AddTicketMemoHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return AddTicketMemoResponse AddTicketMemoResponse
     */
    public function addTicketMemoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            $body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->processorUnionId)) {
            $body['processorUnionId'] = $request->processorUnionId;
        }
        if (!Utils::isUnset($request->ticketMemo)) {
            $body['ticketMemo'] = $request->ticketMemo;
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
            'action' => 'AddTicketMemo',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tickets/memos',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return AddTicketMemoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加工单备注
     *  *
     * @param AddTicketMemoRequest $request AddTicketMemoRequest
     *
     * @return AddTicketMemoResponse AddTicketMemoResponse
     */
    public function addTicketMemo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddTicketMemoHeaders([]);

        return $this->addTicketMemoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 工单指派
     *  *
     * @param AssignTicketRequest $request AssignTicketRequest
     * @param AssignTicketHeaders $headers AssignTicketHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return AssignTicketResponse AssignTicketResponse
     */
    public function assignTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->notify)) {
            $body['notify'] = $request->notify;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            $body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            $body['operatorUnionId'] = $request->operatorUnionId;
        }
        if (!Utils::isUnset($request->processorUnionIds)) {
            $body['processorUnionIds'] = $request->processorUnionIds;
        }
        if (!Utils::isUnset($request->ticketMemo)) {
            $body['ticketMemo'] = $request->ticketMemo;
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
            'action' => 'AssignTicket',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tickets/assign',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return AssignTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 工单指派
     *  *
     * @param AssignTicketRequest $request AssignTicketRequest
     *
     * @return AssignTicketResponse AssignTicketResponse
     */
    public function assignTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AssignTicketHeaders([]);

        return $this->assignTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量绑定服务群业务ID
     *  *
     * @param BatchBindingGroupBizIdsRequest $request BatchBindingGroupBizIdsRequest
     * @param BatchBindingGroupBizIdsHeaders $headers BatchBindingGroupBizIdsHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchBindingGroupBizIdsResponse BatchBindingGroupBizIdsResponse
     */
    public function batchBindingGroupBizIdsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bindingGroupBizIds)) {
            $body['bindingGroupBizIds'] = $request->bindingGroupBizIds;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'BatchBindingGroupBizIds',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/groups/bind',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchBindingGroupBizIdsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量绑定服务群业务ID
     *  *
     * @param BatchBindingGroupBizIdsRequest $request BatchBindingGroupBizIdsRequest
     *
     * @return BatchBindingGroupBizIdsResponse BatchBindingGroupBizIdsResponse
     */
    public function batchBindingGroupBizIds($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchBindingGroupBizIdsHeaders([]);

        return $this->batchBindingGroupBizIdsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询群组配置
     *  *
     * @param BatchGetGroupSetConfigRequest $request BatchGetGroupSetConfigRequest
     * @param BatchGetGroupSetConfigHeaders $headers BatchGetGroupSetConfigHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchGetGroupSetConfigResponse BatchGetGroupSetConfigResponse
     */
    public function batchGetGroupSetConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->configKeys)) {
            $body['configKeys'] = $request->configKeys;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            $body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'BatchGetGroupSetConfig',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/groupSetConfigs/batchQuery',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return BatchGetGroupSetConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询群组配置
     *  *
     * @param BatchGetGroupSetConfigRequest $request BatchGetGroupSetConfigRequest
     *
     * @return BatchGetGroupSetConfigResponse BatchGetGroupSetConfigResponse
     */
    public function batchGetGroupSetConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchGetGroupSetConfigHeaders([]);

        return $this->batchGetGroupSetConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询客户群发任务
     *  *
     * @param BatchQueryCustomerSendTaskRequest $request BatchQueryCustomerSendTaskRequest
     * @param BatchQueryCustomerSendTaskHeaders $headers BatchQueryCustomerSendTaskHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchQueryCustomerSendTaskResponse BatchQueryCustomerSendTaskResponse
     */
    public function batchQueryCustomerSendTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->gmtCreateEnd)) {
            $body['gmtCreateEnd'] = $request->gmtCreateEnd;
        }
        if (!Utils::isUnset($request->gmtCreateStart)) {
            $body['gmtCreateStart'] = $request->gmtCreateStart;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->needRichStatistics)) {
            $body['needRichStatistics'] = $request->needRichStatistics;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openBatchTaskIds)) {
            $body['openBatchTaskIds'] = $request->openBatchTaskIds;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->taskName)) {
            $body['taskName'] = $request->taskName;
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
            'action' => 'BatchQueryCustomerSendTask',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/customers/tasks/batchQuery',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchQueryCustomerSendTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询客户群发任务
     *  *
     * @param BatchQueryCustomerSendTaskRequest $request BatchQueryCustomerSendTaskRequest
     *
     * @return BatchQueryCustomerSendTaskResponse BatchQueryCustomerSendTaskResponse
     */
    public function batchQueryCustomerSendTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchQueryCustomerSendTaskHeaders([]);

        return $this->batchQueryCustomerSendTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询群成员
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
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/groups/members/batchQuery',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchQueryGroupMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询群成员
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
     * @summary 群发任务批量查询
     *  *
     * @param BatchQuerySendMessageTaskRequest $request BatchQuerySendMessageTaskRequest
     * @param BatchQuerySendMessageTaskHeaders $headers BatchQuerySendMessageTaskHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchQuerySendMessageTaskResponse BatchQuerySendMessageTaskResponse
     */
    public function batchQuerySendMessageTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->getReadCount)) {
            $body['getReadCount'] = $request->getReadCount;
        }
        if (!Utils::isUnset($request->gmtCreateEnd)) {
            $body['gmtCreateEnd'] = $request->gmtCreateEnd;
        }
        if (!Utils::isUnset($request->gmtCreateStart)) {
            $body['gmtCreateStart'] = $request->gmtCreateStart;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            $body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->taskName)) {
            $body['taskName'] = $request->taskName;
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
            'action' => 'BatchQuerySendMessageTask',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tasks/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchQuerySendMessageTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 群发任务批量查询
     *  *
     * @param BatchQuerySendMessageTaskRequest $request BatchQuerySendMessageTaskRequest
     *
     * @return BatchQuerySendMessageTaskResponse BatchQuerySendMessageTaskResponse
     */
    public function batchQuerySendMessageTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchQuerySendMessageTaskHeaders([]);

        return $this->batchQuerySendMessageTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 绑定服务群模板到团队
     *  *
     * @param BoundTemplateToTeamRequest $request BoundTemplateToTeamRequest
     * @param BoundTemplateToTeamHeaders $headers BoundTemplateToTeamHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return BoundTemplateToTeamResponse BoundTemplateToTeamResponse
     */
    public function boundTemplateToTeamWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->robotConfig)) {
            $body['robotConfig'] = $request->robotConfig;
        }
        if (!Utils::isUnset($request->templateDesc)) {
            $body['templateDesc'] = $request->templateDesc;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->templateName)) {
            $body['templateName'] = $request->templateName;
        }
        if (!Utils::isUnset($request->templateType)) {
            $body['templateType'] = $request->templateType;
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
            'action' => 'BoundTemplateToTeam',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/teams/templates/bound',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return BoundTemplateToTeamResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 绑定服务群模板到团队
     *  *
     * @param BoundTemplateToTeamRequest $request BoundTemplateToTeamRequest
     *
     * @return BoundTemplateToTeamResponse BoundTemplateToTeamResponse
     */
    public function boundTemplateToTeam($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BoundTemplateToTeamHeaders([]);

        return $this->boundTemplateToTeamWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 撤销工单
     *  *
     * @param CancelTicketRequest $request CancelTicketRequest
     * @param CancelTicketHeaders $headers CancelTicketHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return CancelTicketResponse CancelTicketResponse
     */
    public function cancelTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->notify)) {
            $body['notify'] = $request->notify;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            $body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            $body['operatorUnionId'] = $request->operatorUnionId;
        }
        if (!Utils::isUnset($request->ticketMemo)) {
            $body['ticketMemo'] = $request->ticketMemo;
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
            'action' => 'CancelTicket',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tickets/cancel',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CancelTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 撤销工单
     *  *
     * @param CancelTicketRequest $request CancelTicketRequest
     *
     * @return CancelTicketResponse CancelTicketResponse
     */
    public function cancelTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelTicketHeaders([]);

        return $this->cancelTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 心声总览自定义分类统计
     *  *
     * @param CategoryStatisticsRequest $request CategoryStatisticsRequest
     * @param CategoryStatisticsHeaders $headers CategoryStatisticsHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return CategoryStatisticsResponse CategoryStatisticsResponse
     */
    public function categoryStatisticsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxDt)) {
            $query['maxDt'] = $request->maxDt;
        }
        if (!Utils::isUnset($request->minDt)) {
            $query['minDt'] = $request->minDt;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $query['openTeamId'] = $request->openTeamId;
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
            'action' => 'CategoryStatistics',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/voices/dashboards/categories/statistics',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CategoryStatisticsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 心声总览自定义分类统计
     *  *
     * @param CategoryStatisticsRequest $request CategoryStatisticsRequest
     *
     * @return CategoryStatisticsResponse CategoryStatisticsResponse
     */
    public function categoryStatistics($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CategoryStatisticsHeaders([]);

        return $this->categoryStatisticsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 关闭会话回调
     *  *
     * @param CloseConversationRequest $request CloseConversationRequest
     * @param CloseConversationHeaders $headers CloseConversationHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CloseConversationResponse CloseConversationResponse
     */
    public function closeConversationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conversationId)) {
            $body['conversationId'] = $request->conversationId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->serverTips)) {
            $body['serverTips'] = $request->serverTips;
        }
        if (!Utils::isUnset($request->serviceToken)) {
            $body['serviceToken'] = $request->serviceToken;
        }
        if (!Utils::isUnset($request->targetChannel)) {
            $body['targetChannel'] = $request->targetChannel;
        }
        if (!Utils::isUnset($request->visitorToken)) {
            $body['visitorToken'] = $request->visitorToken;
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
            'action' => 'CloseConversation',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/conversions',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CloseConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 关闭会话回调
     *  *
     * @param CloseConversationRequest $request CloseConversationRequest
     *
     * @return CloseConversationResponse CloseConversationResponse
     */
    public function closeConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CloseConversationHeaders([]);

        return $this->closeConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 关闭人工会话
     *  *
     * @param CloseHumanSessionRequest $request CloseHumanSessionRequest
     * @param CloseHumanSessionHeaders $headers CloseHumanSessionHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CloseHumanSessionResponse CloseHumanSessionResponse
     */
    public function closeHumanSessionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'CloseHumanSession',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/humanSessions/close',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CloseHumanSessionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 关闭人工会话
     *  *
     * @param CloseHumanSessionRequest $request CloseHumanSessionRequest
     *
     * @return CloseHumanSessionResponse CloseHumanSessionResponse
     */
    public function closeHumanSession($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CloseHumanSessionHeaders([]);

        return $this->closeHumanSessionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 客服分配成功通知回调
     *  *
     * @param ConversationCreatedNotifyRequest $request ConversationCreatedNotifyRequest
     * @param ConversationCreatedNotifyHeaders $headers ConversationCreatedNotifyHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return ConversationCreatedNotifyResponse ConversationCreatedNotifyResponse
     */
    public function conversationCreatedNotifyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->alipayUserId)) {
            $body['alipayUserId'] = $request->alipayUserId;
        }
        if (!Utils::isUnset($request->conversationId)) {
            $body['conversationId'] = $request->conversationId;
        }
        if (!Utils::isUnset($request->nickName)) {
            $body['nickName'] = $request->nickName;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->serverName)) {
            $body['serverName'] = $request->serverName;
        }
        if (!Utils::isUnset($request->serverTips)) {
            $body['serverTips'] = $request->serverTips;
        }
        if (!Utils::isUnset($request->serviceToken)) {
            $body['serviceToken'] = $request->serviceToken;
        }
        if (!Utils::isUnset($request->timeoutRemindTips)) {
            $body['timeoutRemindTips'] = $request->timeoutRemindTips;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->visitorToken)) {
            $body['visitorToken'] = $request->visitorToken;
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
            'action' => 'ConversationCreatedNotify',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/customers',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ConversationCreatedNotifyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 客服分配成功通知回调
     *  *
     * @param ConversationCreatedNotifyRequest $request ConversationCreatedNotifyRequest
     *
     * @return ConversationCreatedNotifyResponse ConversationCreatedNotifyResponse
     */
    public function conversationCreatedNotify($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConversationCreatedNotifyHeaders([]);

        return $this->conversationCreatedNotifyWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 会话转接开始通知回调
     *  *
     * @param ConversationTransferBeginNotifyRequest $request ConversationTransferBeginNotifyRequest
     * @param ConversationTransferBeginNotifyHeaders $headers ConversationTransferBeginNotifyHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return ConversationTransferBeginNotifyResponse ConversationTransferBeginNotifyResponse
     */
    public function conversationTransferBeginNotifyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conversationId)) {
            $body['conversationId'] = $request->conversationId;
        }
        if (!Utils::isUnset($request->memo)) {
            $body['memo'] = $request->memo;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->serviceToken)) {
            $body['serviceToken'] = $request->serviceToken;
        }
        if (!Utils::isUnset($request->sourceSkillGroupId)) {
            $body['sourceSkillGroupId'] = $request->sourceSkillGroupId;
        }
        if (!Utils::isUnset($request->targetSkillGroupId)) {
            $body['targetSkillGroupId'] = $request->targetSkillGroupId;
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
            'action' => 'ConversationTransferBeginNotify',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/transfers',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ConversationTransferBeginNotifyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 会话转接开始通知回调
     *  *
     * @param ConversationTransferBeginNotifyRequest $request ConversationTransferBeginNotifyRequest
     *
     * @return ConversationTransferBeginNotifyResponse ConversationTransferBeginNotifyResponse
     */
    public function conversationTransferBeginNotify($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConversationTransferBeginNotifyHeaders([]);

        return $this->conversationTransferBeginNotifyWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 会话转接完成通知回调
     *  *
     * @param ConversationTransferCompleteNotifyRequest $request ConversationTransferCompleteNotifyRequest
     * @param ConversationTransferCompleteNotifyHeaders $headers ConversationTransferCompleteNotifyHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return ConversationTransferCompleteNotifyResponse ConversationTransferCompleteNotifyResponse
     */
    public function conversationTransferCompleteNotifyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->alipayUserId)) {
            $body['alipayUserId'] = $request->alipayUserId;
        }
        if (!Utils::isUnset($request->conversationId)) {
            $body['conversationId'] = $request->conversationId;
        }
        if (!Utils::isUnset($request->nickName)) {
            $body['nickName'] = $request->nickName;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->serviceToken)) {
            $body['serviceToken'] = $request->serviceToken;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->visitorToken)) {
            $body['visitorToken'] = $request->visitorToken;
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
            'action' => 'ConversationTransferCompleteNotify',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/completes',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ConversationTransferCompleteNotifyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 会话转接完成通知回调
     *  *
     * @param ConversationTransferCompleteNotifyRequest $request ConversationTransferCompleteNotifyRequest
     *
     * @return ConversationTransferCompleteNotifyResponse ConversationTransferCompleteNotifyResponse
     */
    public function conversationTransferCompleteNotify($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConversationTransferCompleteNotifyHeaders([]);

        return $this->conversationTransferCompleteNotifyWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建服务群
     *  *
     * @param CreateGroupRequest $request CreateGroupRequest
     * @param CreateGroupHeaders $headers CreateGroupHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateGroupResponse CreateGroupResponse
     */
    public function createGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupBizId)) {
            $body['groupBizId'] = $request->groupBizId;
        }
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->groupTagNames)) {
            $body['groupTagNames'] = $request->groupTagNames;
        }
        if (!Utils::isUnset($request->memberStaffIds)) {
            $body['memberStaffIds'] = $request->memberStaffIds;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            $body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->ownerStaffId)) {
            $body['ownerStaffId'] = $request->ownerStaffId;
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
            'action' => 'CreateGroup',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/groups',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建服务群
     *  *
     * @param CreateGroupRequest $request CreateGroupRequest
     *
     * @return CreateGroupResponse CreateGroupResponse
     */
    public function createGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateGroupHeaders([]);

        return $this->createGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建主动会话接口
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
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->dingGroupId)) {
            $body['dingGroupId'] = $request->dingGroupId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            $body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            $body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingUserId)) {
            $body['dingUserId'] = $request->dingUserId;
        }
        if (!Utils::isUnset($request->dingUserName)) {
            $body['dingUserName'] = $request->dingUserName;
        }
        if (!Utils::isUnset($request->extValues)) {
            $body['extValues'] = $request->extValues;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->serverGroupId)) {
            $body['serverGroupId'] = $request->serverGroupId;
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
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/create/conversations',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateGroupConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建主动会话接口
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
     * @summary 创建服务群群分组
     *  *
     * @param CreateGroupSetRequest $request CreateGroupSetRequest
     * @param CreateGroupSetHeaders $headers CreateGroupSetHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateGroupSetResponse CreateGroupSetResponse
     */
    public function createGroupSetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupSetName)) {
            $body['groupSetName'] = $request->groupSetName;
        }
        if (!Utils::isUnset($request->groupTemplateId)) {
            $body['groupTemplateId'] = $request->groupTemplateId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'CreateGroupSet',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/groupSets',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CreateGroupSetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建服务群群分组
     *  *
     * @param CreateGroupSetRequest $request CreateGroupSetRequest
     *
     * @return CreateGroupSetResponse CreateGroupSetResponse
     */
    public function createGroupSet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateGroupSetHeaders([]);

        return $this->createGroupSetWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务群新增表单实例
     *  *
     * @param CreateInstanceRequest $request CreateInstanceRequest
     * @param CreateInstanceHeaders $headers CreateInstanceHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateInstanceResponse CreateInstanceResponse
     */
    public function createInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->channel)) {
            $body['channel'] = $request->channel;
        }
        if (!Utils::isUnset($request->externalBizId)) {
            $body['externalBizId'] = $request->externalBizId;
        }
        if (!Utils::isUnset($request->formCode)) {
            $body['formCode'] = $request->formCode;
        }
        if (!Utils::isUnset($request->formDataList)) {
            $body['formDataList'] = $request->formDataList;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            $body['operatorUnionId'] = $request->operatorUnionId;
        }
        if (!Utils::isUnset($request->ownerUnionId)) {
            $body['ownerUnionId'] = $request->ownerUnionId;
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
            'action' => 'CreateInstance',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/customForms/instances',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务群新增表单实例
     *  *
     * @param CreateInstanceRequest $request CreateInstanceRequest
     *
     * @return CreateInstanceResponse CreateInstanceResponse
     */
    public function createInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateInstanceHeaders([]);

        return $this->createInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建服务群团队
     *  *
     * @param CreateTeamRequest $request CreateTeamRequest
     * @param CreateTeamHeaders $headers CreateTeamHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTeamResponse CreateTeamResponse
     */
    public function createTeamWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->creatorDingUnionId)) {
            $body['creatorDingUnionId'] = $request->creatorDingUnionId;
        }
        if (!Utils::isUnset($request->teamName)) {
            $body['teamName'] = $request->teamName;
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
            'action' => 'CreateTeam',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/teams',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CreateTeamResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建服务群团队
     *  *
     * @param CreateTeamRequest $request CreateTeamRequest
     *
     * @return CreateTeamResponse CreateTeamResponse
     */
    public function createTeam($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTeamHeaders([]);

        return $this->createTeamWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建工单
     *  *
     * @param CreateTicketRequest $request CreateTicketRequest
     * @param CreateTicketHeaders $headers CreateTicketHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTicketResponse CreateTicketResponse
     */
    public function createTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->creatorUnionId)) {
            $body['creatorUnionId'] = $request->creatorUnionId;
        }
        if (!Utils::isUnset($request->customFields)) {
            $body['customFields'] = $request->customFields;
        }
        if (!Utils::isUnset($request->notify)) {
            $body['notify'] = $request->notify;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openTemplateBizId)) {
            $body['openTemplateBizId'] = $request->openTemplateBizId;
        }
        if (!Utils::isUnset($request->processorUnionIds)) {
            $body['processorUnionIds'] = $request->processorUnionIds;
        }
        if (!Utils::isUnset($request->scene)) {
            $body['scene'] = $request->scene;
        }
        if (!Utils::isUnset($request->sceneContext)) {
            $body['sceneContext'] = $request->sceneContext;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
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
            'action' => 'CreateTicket',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tickets',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CreateTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建工单
     *  *
     * @param CreateTicketRequest $request CreateTicketRequest
     *
     * @return CreateTicketResponse CreateTicketResponse
     */
    public function createTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTicketHeaders([]);

        return $this->createTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 客户群发任务
     *  *
     * @param CustomerSendMsgTaskRequest $request CustomerSendMsgTaskRequest
     * @param CustomerSendMsgTaskHeaders $headers CustomerSendMsgTaskHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return CustomerSendMsgTaskResponse CustomerSendMsgTaskResponse
     */
    public function customerSendMsgTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->messageContent)) {
            $body['messageContent'] = $request->messageContent;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->queryCustomer)) {
            $body['queryCustomer'] = $request->queryCustomer;
        }
        if (!Utils::isUnset($request->sendConfig)) {
            $body['sendConfig'] = $request->sendConfig;
        }
        if (!Utils::isUnset($request->taskName)) {
            $body['taskName'] = $request->taskName;
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
            'action' => 'CustomerSendMsgTask',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/customers/tasks/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CustomerSendMsgTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 客户群发任务
     *  *
     * @param CustomerSendMsgTaskRequest $request CustomerSendMsgTaskRequest
     *
     * @return CustomerSendMsgTaskResponse CustomerSendMsgTaskResponse
     */
    public function customerSendMsgTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomerSendMsgTaskHeaders([]);

        return $this->customerSendMsgTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 从群或者群组剔除成员
     *  *
     * @param DeleteGroupMembersFromGroupRequest $request DeleteGroupMembersFromGroupRequest
     * @param DeleteGroupMembersFromGroupHeaders $headers DeleteGroupMembersFromGroupHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteGroupMembersFromGroupResponse DeleteGroupMembersFromGroupResponse
     */
    public function deleteGroupMembersFromGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deleteGroupType)) {
            $body['deleteGroupType'] = $request->deleteGroupType;
        }
        if (!Utils::isUnset($request->memberUnionId)) {
            $body['memberUnionId'] = $request->memberUnionId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            $body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'DeleteGroupMembersFromGroup',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/groups/members/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteGroupMembersFromGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 从群或者群组剔除成员
     *  *
     * @param DeleteGroupMembersFromGroupRequest $request DeleteGroupMembersFromGroupRequest
     *
     * @return DeleteGroupMembersFromGroupResponse DeleteGroupMembersFromGroupResponse
     */
    public function deleteGroupMembersFromGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteGroupMembersFromGroupHeaders([]);

        return $this->deleteGroupMembersFromGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务群删除表单实例
     *  *
     * @param DeleteInstanceRequest $request DeleteInstanceRequest
     * @param DeleteInstanceHeaders $headers DeleteInstanceHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteInstanceResponse DeleteInstanceResponse
     */
    public function deleteInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->formCode)) {
            $body['formCode'] = $request->formCode;
        }
        if (!Utils::isUnset($request->openDataInstanceId)) {
            $body['openDataInstanceId'] = $request->openDataInstanceId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            $body['operatorUnionId'] = $request->operatorUnionId;
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
            'action' => 'DeleteInstance',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/customForms/instances/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务群删除表单实例
     *  *
     * @param DeleteInstanceRequest $request DeleteInstanceRequest
     *
     * @return DeleteInstanceResponse DeleteInstanceResponse
     */
    public function deleteInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteInstanceHeaders([]);

        return $this->deleteInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务群删除知识点
     *  *
     * @param DeleteKnowledgeRequest $request DeleteKnowledgeRequest
     * @param DeleteKnowledgeHeaders $headers DeleteKnowledgeHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteKnowledgeResponse DeleteKnowledgeResponse
     */
    public function deleteKnowledgeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->libraryKey)) {
            $body['libraryKey'] = $request->libraryKey;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->sourcePrimaryKey)) {
            $body['sourcePrimaryKey'] = $request->sourcePrimaryKey;
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
            'action' => 'DeleteKnowledge',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/knowledges/batchDelete',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return DeleteKnowledgeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务群删除知识点
     *  *
     * @param DeleteKnowledgeRequest $request DeleteKnowledgeRequest
     *
     * @return DeleteKnowledgeResponse DeleteKnowledgeResponse
     */
    public function deleteKnowledge($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteKnowledgeHeaders([]);

        return $this->deleteKnowledgeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 客户心声负面情绪统计
     *  *
     * @param EmotionStatisticsRequest $request EmotionStatisticsRequest
     * @param EmotionStatisticsHeaders $headers EmotionStatisticsHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return EmotionStatisticsResponse EmotionStatisticsResponse
     */
    public function emotionStatisticsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxDt)) {
            $query['maxDt'] = $request->maxDt;
        }
        if (!Utils::isUnset($request->maxEmotion)) {
            $query['maxEmotion'] = $request->maxEmotion;
        }
        if (!Utils::isUnset($request->minDt)) {
            $query['minDt'] = $request->minDt;
        }
        if (!Utils::isUnset($request->minEmotion)) {
            $query['minEmotion'] = $request->minEmotion;
        }
        if (!Utils::isUnset($request->openConversationIds)) {
            $query['openConversationIds'] = $request->openConversationIds;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            $query['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $query['openTeamId'] = $request->openTeamId;
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
            'action' => 'EmotionStatistics',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/voices/emotions/statistics',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return EmotionStatisticsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 客户心声负面情绪统计
     *  *
     * @param EmotionStatisticsRequest $request EmotionStatisticsRequest
     *
     * @return EmotionStatisticsResponse EmotionStatisticsResponse
     */
    public function emotionStatistics($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EmotionStatisticsHeaders([]);

        return $this->emotionStatisticsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 结单
     *  *
     * @param FinishTicketRequest $request FinishTicketRequest
     * @param FinishTicketHeaders $headers FinishTicketHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return FinishTicketResponse FinishTicketResponse
     */
    public function finishTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->notify)) {
            $body['notify'] = $request->notify;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            $body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->processorUnionId)) {
            $body['processorUnionId'] = $request->processorUnionId;
        }
        if (!Utils::isUnset($request->ticketMemo)) {
            $body['ticketMemo'] = $request->ticketMemo;
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
            'action' => 'FinishTicket',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tickets/finish',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return FinishTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 结单
     *  *
     * @param FinishTicketRequest $request FinishTicketRequest
     *
     * @return FinishTicketResponse FinishTicketResponse
     */
    public function finishTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FinishTicketHeaders([]);

        return $this->finishTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取签权Token
     *  *
     * @param GetAuthTokenRequest $request GetAuthTokenRequest
     * @param GetAuthTokenHeaders $headers GetAuthTokenHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAuthTokenResponse GetAuthTokenResponse
     */
    public function getAuthTokenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->channel)) {
            $body['channel'] = $request->channel;
        }
        if (!Utils::isUnset($request->effectiveTime)) {
            $body['effectiveTime'] = $request->effectiveTime;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->serverId)) {
            $body['serverId'] = $request->serverId;
        }
        if (!Utils::isUnset($request->serverName)) {
            $body['serverName'] = $request->serverName;
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
            'action' => 'GetAuthToken',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/get/tokens',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetAuthTokenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取签权Token
     *  *
     * @param GetAuthTokenRequest $request GetAuthTokenRequest
     *
     * @return GetAuthTokenResponse GetAuthTokenResponse
     */
    public function getAuthToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAuthTokenHeaders([]);

        return $this->getAuthTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务群通过实例ID集合批量查询表单实例数据
     *  *
     * @param GetInstancesByIdsRequest $request GetInstancesByIdsRequest
     * @param GetInstancesByIdsHeaders $headers GetInstancesByIdsHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetInstancesByIdsResponse GetInstancesByIdsResponse
     */
    public function getInstancesByIdsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->formCode)) {
            $body['formCode'] = $request->formCode;
        }
        if (!Utils::isUnset($request->openDataInstanceIdList)) {
            $body['openDataInstanceIdList'] = $request->openDataInstanceIdList;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'GetInstancesByIds',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/customForms/instances/batchQuery',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetInstancesByIdsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务群通过实例ID集合批量查询表单实例数据
     *  *
     * @param GetInstancesByIdsRequest $request GetInstancesByIdsRequest
     *
     * @return GetInstancesByIdsResponse GetInstancesByIdsResponse
     */
    public function getInstancesByIds($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInstancesByIdsHeaders([]);

        return $this->getInstancesByIdsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取负面心声词云
     *  *
     * @param GetNegativeWordCloudRequest $request GetNegativeWordCloudRequest
     * @param GetNegativeWordCloudHeaders $headers GetNegativeWordCloudHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetNegativeWordCloudResponse GetNegativeWordCloudResponse
     */
    public function getNegativeWordCloudWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openTeamId)) {
            $query['openTeamId'] = $request->openTeamId;
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
            'action' => 'GetNegativeWordCloud',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/voices/negatives/wordClouds',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetNegativeWordCloudResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取负面心声词云
     *  *
     * @param GetNegativeWordCloudRequest $request GetNegativeWordCloudRequest
     *
     * @return GetNegativeWordCloudResponse GetNegativeWordCloudResponse
     */
    public function getNegativeWordCloud($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetNegativeWordCloudHeaders([]);

        return $this->getNegativeWordCloudWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取临时访问链接
     *  *
     * @param GetOssTempUrlRequest $request GetOssTempUrlRequest
     * @param GetOssTempUrlHeaders $headers GetOssTempUrlHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOssTempUrlResponse GetOssTempUrlResponse
     */
    public function getOssTempUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->fetchMode)) {
            $query['fetchMode'] = $request->fetchMode;
        }
        if (!Utils::isUnset($request->fileName)) {
            $query['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->key)) {
            $query['key'] = $request->key;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $query['openTeamId'] = $request->openTeamId;
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
            'action' => 'GetOssTempUrl',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/ossServices/tempUrls',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetOssTempUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取临时访问链接
     *  *
     * @param GetOssTempUrlRequest $request GetOssTempUrlRequest
     *
     * @return GetOssTempUrlResponse GetOssTempUrlResponse
     */
    public function getOssTempUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOssTempUrlHeaders([]);

        return $this->getOssTempUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取表单上传凭证
     *  *
     * @param GetStoragePolicyRequest $request GetStoragePolicyRequest
     * @param GetStoragePolicyHeaders $headers GetStoragePolicyHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetStoragePolicyResponse GetStoragePolicyResponse
     */
    public function getStoragePolicyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->fileName)) {
            $body['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->fileSize)) {
            $body['fileSize'] = $request->fileSize;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'GetStoragePolicy',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/ossServices/policies',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetStoragePolicyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取表单上传凭证
     *  *
     * @param GetStoragePolicyRequest $request GetStoragePolicyRequest
     *
     * @return GetStoragePolicyResponse GetStoragePolicyResponse
     */
    public function getStoragePolicy($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetStoragePolicyHeaders([]);

        return $this->getStoragePolicyWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询工单详情
     *  *
     * @param GetTicketRequest $request GetTicketRequest
     * @param GetTicketHeaders $headers GetTicketHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTicketResponse GetTicketResponse
     */
    public function getTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openTeamId)) {
            $query['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            $query['openTicketId'] = $request->openTicketId;
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
            'action' => 'GetTicket',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tickets',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询工单详情
     *  *
     * @param GetTicketRequest $request GetTicketRequest
     *
     * @return GetTicketResponse GetTicketResponse
     */
    public function getTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTicketHeaders([]);

        return $this->getTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取心声词云
     *  *
     * @param GetWordCloudRequest $request GetWordCloudRequest
     * @param GetWordCloudHeaders $headers GetWordCloudHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetWordCloudResponse GetWordCloudResponse
     */
    public function getWordCloudWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openTeamId)) {
            $query['openTeamId'] = $request->openTeamId;
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
            'action' => 'GetWordCloud',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/voices/wordClouds',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetWordCloudResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取心声词云
     *  *
     * @param GetWordCloudRequest $request GetWordCloudRequest
     *
     * @return GetWordCloudResponse GetWordCloudResponse
     */
    public function getWordCloud($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetWordCloudHeaders([]);

        return $this->getWordCloudWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 心声总览群统计
     *  *
     * @param GroupStatisticsRequest $request GroupStatisticsRequest
     * @param GroupStatisticsHeaders $headers GroupStatisticsHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GroupStatisticsResponse GroupStatisticsResponse
     */
    public function groupStatisticsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxDt)) {
            $query['maxDt'] = $request->maxDt;
        }
        if (!Utils::isUnset($request->minDt)) {
            $query['minDt'] = $request->minDt;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $query['openTeamId'] = $request->openTeamId;
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
            'action' => 'GroupStatistics',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/voices/dashboards/groups/statistics',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GroupStatisticsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 心声总览群统计
     *  *
     * @param GroupStatisticsRequest $request GroupStatisticsRequest
     *
     * @return GroupStatisticsResponse GroupStatisticsResponse
     */
    public function groupStatistics($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GroupStatisticsHeaders([]);

        return $this->groupStatisticsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 心声总览意图&自定义分类统计
     *  *
     * @param IntentionCategoryStatisticsRequest $request IntentionCategoryStatisticsRequest
     * @param IntentionCategoryStatisticsHeaders $headers IntentionCategoryStatisticsHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return IntentionCategoryStatisticsResponse IntentionCategoryStatisticsResponse
     */
    public function intentionCategoryStatisticsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxDt)) {
            $query['maxDt'] = $request->maxDt;
        }
        if (!Utils::isUnset($request->minDt)) {
            $query['minDt'] = $request->minDt;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $query['openTeamId'] = $request->openTeamId;
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
            'action' => 'IntentionCategoryStatistics',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/voices/dashboards/intentionCategories/statistics',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return IntentionCategoryStatisticsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 心声总览意图&自定义分类统计
     *  *
     * @param IntentionCategoryStatisticsRequest $request IntentionCategoryStatisticsRequest
     *
     * @return IntentionCategoryStatisticsResponse IntentionCategoryStatisticsResponse
     */
    public function intentionCategoryStatistics($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IntentionCategoryStatisticsHeaders([]);

        return $this->intentionCategoryStatisticsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 心声总览意图统计
     *  *
     * @param IntentionStatisticsRequest $request IntentionStatisticsRequest
     * @param IntentionStatisticsHeaders $headers IntentionStatisticsHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return IntentionStatisticsResponse IntentionStatisticsResponse
     */
    public function intentionStatisticsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxDt)) {
            $query['maxDt'] = $request->maxDt;
        }
        if (!Utils::isUnset($request->minDt)) {
            $query['minDt'] = $request->minDt;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $query['openTeamId'] = $request->openTeamId;
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
            'action' => 'IntentionStatistics',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/voices/dashboards/intentions/statistics',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return IntentionStatisticsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 心声总览意图统计
     *  *
     * @param IntentionStatisticsRequest $request IntentionStatisticsRequest
     *
     * @return IntentionStatisticsResponse IntentionStatisticsResponse
     */
    public function intentionStatistics($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IntentionStatisticsHeaders([]);

        return $this->intentionStatisticsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询工单操作记录
     *  *
     * @param ListTicketOperateRecordRequest $request ListTicketOperateRecordRequest
     * @param ListTicketOperateRecordHeaders $headers ListTicketOperateRecordHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return ListTicketOperateRecordResponse ListTicketOperateRecordResponse
     */
    public function listTicketOperateRecordWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openTeamId)) {
            $query['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            $query['openTicketId'] = $request->openTicketId;
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
            'action' => 'ListTicketOperateRecord',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tickets/operateRecords',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return ListTicketOperateRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询工单操作记录
     *  *
     * @param ListTicketOperateRecordRequest $request ListTicketOperateRecordRequest
     *
     * @return ListTicketOperateRecordResponse ListTicketOperateRecordResponse
     */
    public function listTicketOperateRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListTicketOperateRecordHeaders([]);

        return $this->listTicketOperateRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户所在团队
     *  *
     * @param string               $userId
     * @param ListUserTeamsHeaders $headers ListUserTeamsHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return ListUserTeamsResponse ListUserTeamsResponse
     */
    public function listUserTeamsWithOptions($userId, $headers, $runtime)
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
            'action' => 'ListUserTeams',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/users/' . $userId . '/teams',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return ListUserTeamsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户所在团队
     *  *
     * @param string $userId
     *
     * @return ListUserTeamsResponse ListUserTeamsResponse
     */
    public function listUserTeams($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListUserTeamsHeaders([]);

        return $this->listUserTeamsWithOptions($userId, $headers, $runtime);
    }

    /**
     * @summary 查询服务群活跃成员
     *  *
     * @param QueryActiveUsersRequest $request QueryActiveUsersRequest
     * @param QueryActiveUsersHeaders $headers QueryActiveUsersHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryActiveUsersResponse QueryActiveUsersResponse
     */
    public function queryActiveUsersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $query['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $query['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->topN)) {
            $query['topN'] = $request->topN;
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
            'action' => 'QueryActiveUsers',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/groups/queryActiveUsers',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryActiveUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询服务群活跃成员
     *  *
     * @param QueryActiveUsersRequest $request QueryActiveUsersRequest
     *
     * @return QueryActiveUsersResponse QueryActiveUsersResponse
     */
    public function queryActiveUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryActiveUsersHeaders([]);

        return $this->queryActiveUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 群联系人画像检索
     *  *
     * @param QueryCrmGroupContactRequest $request QueryCrmGroupContactRequest
     * @param QueryCrmGroupContactHeaders $headers QueryCrmGroupContactHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCrmGroupContactResponse QueryCrmGroupContactResponse
     */
    public function queryCrmGroupContactWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->minResult)) {
            $body['minResult'] = $request->minResult;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->searchFields)) {
            $body['searchFields'] = $request->searchFields;
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
            'action' => 'QueryCrmGroupContact',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/groups/contacts/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryCrmGroupContactResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 群联系人画像检索
     *  *
     * @param QueryCrmGroupContactRequest $request QueryCrmGroupContactRequest
     *
     * @return QueryCrmGroupContactResponse QueryCrmGroupContactResponse
     */
    public function queryCrmGroupContact($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCrmGroupContactHeaders([]);

        return $this->queryCrmGroupContactWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询客户信息
     *  *
     * @param QueryCustomerCardRequest $request QueryCustomerCardRequest
     * @param QueryCustomerCardHeaders $headers QueryCustomerCardHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCustomerCardResponse QueryCustomerCardResponse
     */
    public function queryCustomerCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->jsonParams)) {
            $body['jsonParams'] = $request->jsonParams;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'QueryCustomerCard',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/userDetials',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryCustomerCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询客户信息
     *  *
     * @param QueryCustomerCardRequest $request QueryCustomerCardRequest
     *
     * @return QueryCustomerCardResponse QueryCustomerCardResponse
     */
    public function queryCustomerCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCustomerCardHeaders([]);

        return $this->queryCustomerCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询客户群发任务客户触达详情
     *  *
     * @param QueryCustomerTaskUserDetailRequest $request QueryCustomerTaskUserDetailRequest
     * @param QueryCustomerTaskUserDetailHeaders $headers QueryCustomerTaskUserDetailHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCustomerTaskUserDetailResponse QueryCustomerTaskUserDetailResponse
     */
    public function queryCustomerTaskUserDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openBatchTaskId)) {
            $body['openBatchTaskId'] = $request->openBatchTaskId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->receiverUnionIds)) {
            $body['receiverUnionIds'] = $request->receiverUnionIds;
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
            'action' => 'QueryCustomerTaskUserDetail',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/customers/tasks/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryCustomerTaskUserDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询客户群发任务客户触达详情
     *  *
     * @param QueryCustomerTaskUserDetailRequest $request QueryCustomerTaskUserDetailRequest
     *
     * @return QueryCustomerTaskUserDetailResponse QueryCustomerTaskUserDetailResponse
     */
    public function queryCustomerTaskUserDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCustomerTaskUserDetailHeaders([]);

        return $this->queryCustomerTaskUserDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询单个服务群信息
     *  *
     * @param QueryGroupRequest $request QueryGroupRequest
     * @param QueryGroupHeaders $headers QueryGroupHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGroupResponse QueryGroupResponse
     */
    public function queryGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'QueryGroup',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/groups/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询单个服务群信息
     *  *
     * @param QueryGroupRequest $request QueryGroupRequest
     *
     * @return QueryGroupResponse QueryGroupResponse
     */
    public function queryGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupHeaders([]);

        return $this->queryGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询指定群成员
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
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $body['targetCorpId'] = $request->targetCorpId;
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
            'action' => 'QueryGroupMember',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/groups/members/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryGroupMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询指定群成员
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
     * @summary 查询服务群群组信息
     *  *
     * @param QueryGroupSetRequest $request QueryGroupSetRequest
     * @param QueryGroupSetHeaders $headers QueryGroupSetHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGroupSetResponse QueryGroupSetResponse
     */
    public function queryGroupSetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openTeamId)) {
            $query['openTeamId'] = $request->openTeamId;
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
            'action' => 'QueryGroupSet',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/groupSets',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryGroupSetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询服务群群组信息
     *  *
     * @param QueryGroupSetRequest $request QueryGroupSetRequest
     *
     * @return QueryGroupSetResponse QueryGroupSetResponse
     */
    public function queryGroupSet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupSetHeaders([]);

        return $this->queryGroupSetWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务群通过多添件进行组合检索表单数据实例集合
     *  *
     * @param QueryInstancesByMultiConditionsRequest $request QueryInstancesByMultiConditionsRequest
     * @param QueryInstancesByMultiConditionsHeaders $headers QueryInstancesByMultiConditionsHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryInstancesByMultiConditionsResponse QueryInstancesByMultiConditionsResponse
     */
    public function queryInstancesByMultiConditionsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->formCode)) {
            $body['formCode'] = $request->formCode;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->searchFields)) {
            $body['searchFields'] = $request->searchFields;
        }
        if (!Utils::isUnset($request->sortFields)) {
            $body['sortFields'] = $request->sortFields;
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
            'action' => 'QueryInstancesByMultiConditions',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/customForms/instances/multiConditions/batchQuery',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryInstancesByMultiConditionsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务群通过多添件进行组合检索表单数据实例集合
     *  *
     * @param QueryInstancesByMultiConditionsRequest $request QueryInstancesByMultiConditionsRequest
     *
     * @return QueryInstancesByMultiConditionsResponse QueryInstancesByMultiConditionsResponse
     */
    public function queryInstancesByMultiConditions($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryInstancesByMultiConditionsHeaders([]);

        return $this->queryInstancesByMultiConditionsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 群发任务统计查询
     *  *
     * @param QuerySendMsgTaskStatisticsRequest $request QuerySendMsgTaskStatisticsRequest
     * @param QuerySendMsgTaskStatisticsHeaders $headers QuerySendMsgTaskStatisticsHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return QuerySendMsgTaskStatisticsResponse QuerySendMsgTaskStatisticsResponse
     */
    public function querySendMsgTaskStatisticsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openBatchTaskId)) {
            $body['openBatchTaskId'] = $request->openBatchTaskId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'QuerySendMsgTaskStatistics',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tasks/statistics/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QuerySendMsgTaskStatisticsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 群发任务统计查询
     *  *
     * @param QuerySendMsgTaskStatisticsRequest $request QuerySendMsgTaskStatisticsRequest
     *
     * @return QuerySendMsgTaskStatisticsResponse QuerySendMsgTaskStatisticsResponse
     */
    public function querySendMsgTaskStatistics($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySendMsgTaskStatisticsHeaders([]);

        return $this->querySendMsgTaskStatisticsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 群发任务群维度的统计数据
     *  *
     * @param QuerySendMsgTaskStatisticsDetailRequest $request QuerySendMsgTaskStatisticsDetailRequest
     * @param QuerySendMsgTaskStatisticsDetailHeaders $headers QuerySendMsgTaskStatisticsDetailHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return QuerySendMsgTaskStatisticsDetailResponse QuerySendMsgTaskStatisticsDetailResponse
     */
    public function querySendMsgTaskStatisticsDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openBatchTaskId)) {
            $body['openBatchTaskId'] = $request->openBatchTaskId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'QuerySendMsgTaskStatisticsDetail',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tasks/statistics/details/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QuerySendMsgTaskStatisticsDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 群发任务群维度的统计数据
     *  *
     * @param QuerySendMsgTaskStatisticsDetailRequest $request QuerySendMsgTaskStatisticsDetailRequest
     *
     * @return QuerySendMsgTaskStatisticsDetailResponse QuerySendMsgTaskStatisticsDetailResponse
     */
    public function querySendMsgTaskStatisticsDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySendMsgTaskStatisticsDetailHeaders([]);

        return $this->querySendMsgTaskStatisticsDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查消息的已读/未读列表
     *  *
     * @param QueryServiceGroupMessageReadStatusRequest $request QueryServiceGroupMessageReadStatusRequest
     * @param QueryServiceGroupMessageReadStatusHeaders $headers QueryServiceGroupMessageReadStatusHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryServiceGroupMessageReadStatusResponse QueryServiceGroupMessageReadStatusResponse
     */
    public function queryServiceGroupMessageReadStatusWithOptions($request, $headers, $runtime)
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
        if (!Utils::isUnset($request->openMsgTaskId)) {
            $body['openMsgTaskId'] = $request->openMsgTaskId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'QueryServiceGroupMessageReadStatus',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/messages/readStatus/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryServiceGroupMessageReadStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查消息的已读/未读列表
     *  *
     * @param QueryServiceGroupMessageReadStatusRequest $request QueryServiceGroupMessageReadStatusRequest
     *
     * @return QueryServiceGroupMessageReadStatusResponse QueryServiceGroupMessageReadStatusResponse
     */
    public function queryServiceGroupMessageReadStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryServiceGroupMessageReadStatusHeaders([]);

        return $this->queryServiceGroupMessageReadStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 外部DT工作台排队通知回调
     *  *
     * @param QueueNotifyRequest $request QueueNotifyRequest
     * @param QueueNotifyHeaders $headers QueueNotifyHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return QueueNotifyResponse QueueNotifyResponse
     */
    public function queueNotifyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->estimateWaitMin)) {
            $body['estimateWaitMin'] = $request->estimateWaitMin;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->queuePlace)) {
            $body['queuePlace'] = $request->queuePlace;
        }
        if (!Utils::isUnset($request->serviceToken)) {
            $body['serviceToken'] = $request->serviceToken;
        }
        if (!Utils::isUnset($request->targetChannel)) {
            $body['targetChannel'] = $request->targetChannel;
        }
        if (!Utils::isUnset($request->tips)) {
            $body['tips'] = $request->tips;
        }
        if (!Utils::isUnset($request->visitorToken)) {
            $body['visitorToken'] = $request->visitorToken;
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
            'action' => 'QueueNotify',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/dts',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueueNotifyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 外部DT工作台排队通知回调
     *  *
     * @param QueueNotifyRequest $request QueueNotifyRequest
     *
     * @return QueueNotifyResponse QueueNotifyResponse
     */
    public function queueNotify($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueueNotifyHeaders([]);

        return $this->queueNotifyWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 组织剔除联系人
     *  *
     * @param RemoveContactFromOrgRequest $request RemoveContactFromOrgRequest
     * @param RemoveContactFromOrgHeaders $headers RemoveContactFromOrgHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return RemoveContactFromOrgResponse RemoveContactFromOrgResponse
     */
    public function removeContactFromOrgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->contactUnionId)) {
            $body['contactUnionId'] = $request->contactUnionId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'RemoveContactFromOrg',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/organizations/contacts/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RemoveContactFromOrgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 组织剔除联系人
     *  *
     * @param RemoveContactFromOrgRequest $request RemoveContactFromOrgRequest
     *
     * @return RemoveContactFromOrgResponse RemoveContactFromOrgResponse
     */
    public function removeContactFromOrg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveContactFromOrgHeaders([]);

        return $this->removeContactFromOrgWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 指定群的客户活跃明细查询
     *  *
     * @param ReportCustomerDetailRequest $request ReportCustomerDetailRequest
     * @param ReportCustomerDetailHeaders $headers ReportCustomerDetailHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return ReportCustomerDetailResponse ReportCustomerDetailResponse
     */
    public function reportCustomerDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->hasLogin)) {
            $body['hasLogin'] = $request->hasLogin;
        }
        if (!Utils::isUnset($request->hasOpenConv)) {
            $body['hasOpenConv'] = $request->hasOpenConv;
        }
        if (!Utils::isUnset($request->maxDt)) {
            $body['maxDt'] = $request->maxDt;
        }
        if (!Utils::isUnset($request->minDt)) {
            $body['minDt'] = $request->minDt;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
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
            'action' => 'ReportCustomerDetail',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/customers/activities/details/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ReportCustomerDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 指定群的客户活跃明细查询
     *  *
     * @param ReportCustomerDetailRequest $request ReportCustomerDetailRequest
     *
     * @return ReportCustomerDetailResponse ReportCustomerDetailResponse
     */
    public function reportCustomerDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReportCustomerDetailHeaders([]);

        return $this->reportCustomerDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 客户活跃明细指标查询
     *  *
     * @param ReportCustomerStatisticsRequest $request ReportCustomerStatisticsRequest
     * @param ReportCustomerStatisticsHeaders $headers ReportCustomerStatisticsHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return ReportCustomerStatisticsResponse ReportCustomerStatisticsResponse
     */
    public function reportCustomerStatisticsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupOwnerUserIds)) {
            $body['groupOwnerUserIds'] = $request->groupOwnerUserIds;
        }
        if (!Utils::isUnset($request->groupTags)) {
            $body['groupTags'] = $request->groupTags;
        }
        if (!Utils::isUnset($request->maxDt)) {
            $body['maxDt'] = $request->maxDt;
        }
        if (!Utils::isUnset($request->minDt)) {
            $body['minDt'] = $request->minDt;
        }
        if (!Utils::isUnset($request->openConversationIds)) {
            $body['openConversationIds'] = $request->openConversationIds;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            $body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
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
            'action' => 'ReportCustomerStatistics',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/customers/activities/statistics/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ReportCustomerStatisticsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 客户活跃明细指标查询
     *  *
     * @param ReportCustomerStatisticsRequest $request ReportCustomerStatisticsRequest
     *
     * @return ReportCustomerStatisticsResponse ReportCustomerStatisticsResponse
     */
    public function reportCustomerStatistics($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReportCustomerStatisticsHeaders([]);

        return $this->reportCustomerStatisticsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 重新提交工单
     *  *
     * @param ResubmitTicketRequest $request ResubmitTicketRequest
     * @param ResubmitTicketHeaders $headers ResubmitTicketHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return ResubmitTicketResponse ResubmitTicketResponse
     */
    public function resubmitTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->creatorUnionId)) {
            $body['creatorUnionId'] = $request->creatorUnionId;
        }
        if (!Utils::isUnset($request->customFields)) {
            $body['customFields'] = $request->customFields;
        }
        if (!Utils::isUnset($request->notify)) {
            $body['notify'] = $request->notify;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openTemplateBizId)) {
            $body['openTemplateBizId'] = $request->openTemplateBizId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            $body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->processorUnionIds)) {
            $body['processorUnionIds'] = $request->processorUnionIds;
        }
        if (!Utils::isUnset($request->scene)) {
            $body['scene'] = $request->scene;
        }
        if (!Utils::isUnset($request->sceneContext)) {
            $body['sceneContext'] = $request->sceneContext;
        }
        if (!Utils::isUnset($request->ticketMemo)) {
            $body['ticketMemo'] = $request->ticketMemo;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
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
            'action' => 'ResubmitTicket',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tickets/resubmit',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return ResubmitTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 重新提交工单
     *  *
     * @param ResubmitTicketRequest $request ResubmitTicketRequest
     *
     * @return ResubmitTicketResponse ResubmitTicketResponse
     */
    public function resubmitTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ResubmitTicketHeaders([]);

        return $this->resubmitTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 撤回工单
     *  *
     * @param RetractTicketRequest $request RetractTicketRequest
     * @param RetractTicketHeaders $headers RetractTicketHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return RetractTicketResponse RetractTicketResponse
     */
    public function retractTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->notify)) {
            $body['notify'] = $request->notify;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            $body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            $body['operatorUnionId'] = $request->operatorUnionId;
        }
        if (!Utils::isUnset($request->ticketMemo)) {
            $body['ticketMemo'] = $request->ticketMemo;
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
            'action' => 'RetractTicket',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tickets/retract',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return RetractTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 撤回工单
     *  *
     * @param RetractTicketRequest $request RetractTicketRequest
     *
     * @return RetractTicketResponse RetractTicketResponse
     */
    public function retractTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RetractTicketHeaders([]);

        return $this->retractTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 指定群的机器人消息撤回
     *  *
     * @param RobotMessageRecallRequest $request RobotMessageRecallRequest
     * @param RobotMessageRecallHeaders $headers RobotMessageRecallHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return RobotMessageRecallResponse RobotMessageRecallResponse
     */
    public function robotMessageRecallWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openMsgId)) {
            $body['openMsgId'] = $request->openMsgId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'RobotMessageRecall',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/robots/messages/recall',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RobotMessageRecallResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 指定群的机器人消息撤回
     *  *
     * @param RobotMessageRecallRequest $request RobotMessageRecallRequest
     *
     * @return RobotMessageRecallResponse RobotMessageRecallResponse
     */
    public function robotMessageRecall($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RobotMessageRecallHeaders([]);

        return $this->robotMessageRecallWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务群新增表单实例
     *  *
     * @param SaveFormInstanceRequest $request SaveFormInstanceRequest
     * @param SaveFormInstanceHeaders $headers SaveFormInstanceHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveFormInstanceResponse SaveFormInstanceResponse
     */
    public function saveFormInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->formDataList)) {
            $body['formDataList'] = $request->formDataList;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            $body['operatorUnionId'] = $request->operatorUnionId;
        }
        if (!Utils::isUnset($request->ownerUnionId)) {
            $body['ownerUnionId'] = $request->ownerUnionId;
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
            'action' => 'SaveFormInstance',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/forms/instances',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SaveFormInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务群新增表单实例
     *  *
     * @param SaveFormInstanceRequest $request SaveFormInstanceRequest
     *
     * @return SaveFormInstanceResponse SaveFormInstanceResponse
     */
    public function saveFormInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveFormInstanceHeaders([]);

        return $this->saveFormInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 搜索服务群
     *  *
     * @param SearchGroupRequest $request SearchGroupRequest
     * @param SearchGroupHeaders $headers SearchGroupHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchGroupResponse SearchGroupResponse
     */
    public function searchGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
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
        if (!Utils::isUnset($request->openGroupSetId)) {
            $body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->searchType)) {
            $body['searchType'] = $request->searchType;
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
            'action' => 'SearchGroup',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/groups/search',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return SearchGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 搜索服务群
     *  *
     * @param SearchGroupRequest $request SearchGroupRequest
     *
     * @return SearchGroupResponse SearchGroupResponse
     */
    public function searchGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchGroupHeaders([]);

        return $this->searchGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务群发任务
     *  *
     * @param SendMsgByTaskRequest $request SendMsgByTaskRequest
     * @param SendMsgByTaskHeaders $headers SendMsgByTaskHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return SendMsgByTaskResponse SendMsgByTaskResponse
     */
    public function sendMsgByTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->messageContent)) {
            $body['messageContent'] = $request->messageContent;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->queryGroup)) {
            $body['queryGroup'] = $request->queryGroup;
        }
        if (!Utils::isUnset($request->sendConfig)) {
            $body['sendConfig'] = $request->sendConfig;
        }
        if (!Utils::isUnset($request->taskName)) {
            $body['taskName'] = $request->taskName;
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
            'action' => 'SendMsgByTask',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/messages/tasks/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendMsgByTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务群发任务
     *  *
     * @param SendMsgByTaskRequest $request SendMsgByTaskRequest
     *
     * @return SendMsgByTaskResponse SendMsgByTaskResponse
     */
    public function sendMsgByTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendMsgByTaskHeaders([]);

        return $this->sendMsgByTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 增强版客户群发
     *  *
     * @param SendMsgByTaskSupportInviteJoinOrgRequest $request SendMsgByTaskSupportInviteJoinOrgRequest
     * @param SendMsgByTaskSupportInviteJoinOrgHeaders $headers SendMsgByTaskSupportInviteJoinOrgHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return SendMsgByTaskSupportInviteJoinOrgResponse SendMsgByTaskSupportInviteJoinOrgResponse
     */
    public function sendMsgByTaskSupportInviteJoinOrgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->messageContent)) {
            $body['messageContent'] = $request->messageContent;
        }
        if (!Utils::isUnset($request->mobilePhones)) {
            $body['mobilePhones'] = $request->mobilePhones;
        }
        if (!Utils::isUnset($request->needUrlTrack)) {
            $body['needUrlTrack'] = $request->needUrlTrack;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->sendChannel)) {
            $body['sendChannel'] = $request->sendChannel;
        }
        if (!Utils::isUnset($request->taskName)) {
            $body['taskName'] = $request->taskName;
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
            'action' => 'SendMsgByTaskSupportInviteJoinOrg',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/customers/tasks/groupSend',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendMsgByTaskSupportInviteJoinOrgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 增强版客户群发
     *  *
     * @param SendMsgByTaskSupportInviteJoinOrgRequest $request SendMsgByTaskSupportInviteJoinOrgRequest
     *
     * @return SendMsgByTaskSupportInviteJoinOrgResponse SendMsgByTaskSupportInviteJoinOrgResponse
     */
    public function sendMsgByTaskSupportInviteJoinOrg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendMsgByTaskSupportInviteJoinOrgHeaders([]);

        return $this->sendMsgByTaskSupportInviteJoinOrgWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务群发消息
     *  *
     * @param SendServiceGroupMessageRequest $request SendServiceGroupMessageRequest
     * @param SendServiceGroupMessageHeaders $headers SendServiceGroupMessageHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return SendServiceGroupMessageResponse SendServiceGroupMessageResponse
     */
    public function sendServiceGroupMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->atDingtalkIds)) {
            $body['atDingtalkIds'] = $request->atDingtalkIds;
        }
        if (!Utils::isUnset($request->atMobiles)) {
            $body['atMobiles'] = $request->atMobiles;
        }
        if (!Utils::isUnset($request->atUnionIds)) {
            $body['atUnionIds'] = $request->atUnionIds;
        }
        if (!Utils::isUnset($request->btnOrientation)) {
            $body['btnOrientation'] = $request->btnOrientation;
        }
        if (!Utils::isUnset($request->btns)) {
            $body['btns'] = $request->btns;
        }
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->hasContentLinks)) {
            $body['hasContentLinks'] = $request->hasContentLinks;
        }
        if (!Utils::isUnset($request->isAtAll)) {
            $body['isAtAll'] = $request->isAtAll;
        }
        if (!Utils::isUnset($request->messageType)) {
            $body['messageType'] = $request->messageType;
        }
        if (!Utils::isUnset($request->receiverDingtalkIds)) {
            $body['receiverDingtalkIds'] = $request->receiverDingtalkIds;
        }
        if (!Utils::isUnset($request->receiverMobiles)) {
            $body['receiverMobiles'] = $request->receiverMobiles;
        }
        if (!Utils::isUnset($request->receiverUnionIds)) {
            $body['receiverUnionIds'] = $request->receiverUnionIds;
        }
        if (!Utils::isUnset($request->targetOpenConversationId)) {
            $body['targetOpenConversationId'] = $request->targetOpenConversationId;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
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
            'action' => 'SendServiceGroupMessage',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/messages/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendServiceGroupMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务群发消息
     *  *
     * @param SendServiceGroupMessageRequest $request SendServiceGroupMessageRequest
     *
     * @return SendServiceGroupMessageResponse SendServiceGroupMessageResponse
     */
    public function sendServiceGroupMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendServiceGroupMessageHeaders([]);

        return $this->sendServiceGroupMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 执行阿里内部用户群组机器人服务开关
     *  *
     * @param SetRobotConfigRequest $request SetRobotConfigRequest
     * @param SetRobotConfigHeaders $headers SetRobotConfigHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return SetRobotConfigResponse SetRobotConfigResponse
     */
    public function setRobotConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            $body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            $body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            $body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            $body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            $body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'SetRobotConfig',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/groups/configs/set',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SetRobotConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 执行阿里内部用户群组机器人服务开关
     *  *
     * @param SetRobotConfigRequest $request SetRobotConfigRequest
     *
     * @return SetRobotConfigResponse SetRobotConfigResponse
     */
    public function setRobotConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetRobotConfigHeaders([]);

        return $this->setRobotConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 申领工单
     *  *
     * @param TakeTicketRequest $request TakeTicketRequest
     * @param TakeTicketHeaders $headers TakeTicketHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return TakeTicketResponse TakeTicketResponse
     */
    public function takeTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            $body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->takerUnionId)) {
            $body['takerUnionId'] = $request->takerUnionId;
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
            'action' => 'TakeTicket',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tickets/apply',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return TakeTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 申领工单
     *  *
     * @param TakeTicketRequest $request TakeTicketRequest
     *
     * @return TakeTicketResponse TakeTicketResponse
     */
    public function takeTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TakeTicketHeaders([]);

        return $this->takeTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 客户心声热门话题统计
     *  *
     * @param TopicStatisticsRequest $request TopicStatisticsRequest
     * @param TopicStatisticsHeaders $headers TopicStatisticsHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return TopicStatisticsResponse TopicStatisticsResponse
     */
    public function topicStatisticsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxDt)) {
            $query['maxDt'] = $request->maxDt;
        }
        if (!Utils::isUnset($request->minDt)) {
            $query['minDt'] = $request->minDt;
        }
        if (!Utils::isUnset($request->openConversationIds)) {
            $query['openConversationIds'] = $request->openConversationIds;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $query['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->searchContent)) {
            $query['searchContent'] = $request->searchContent;
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
            'action' => 'TopicStatistics',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/voices/topics/statistics',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TopicStatisticsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 客户心声热门话题统计
     *  *
     * @param TopicStatisticsRequest $request TopicStatisticsRequest
     *
     * @return TopicStatisticsResponse TopicStatisticsResponse
     */
    public function topicStatistics($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TopicStatisticsHeaders([]);

        return $this->topicStatisticsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 转交工单
     *  *
     * @param TransferTicketRequest $request TransferTicketRequest
     * @param TransferTicketHeaders $headers TransferTicketHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return TransferTicketResponse TransferTicketResponse
     */
    public function transferTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->notify)) {
            $body['notify'] = $request->notify;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            $body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->processorUnionId)) {
            $body['processorUnionId'] = $request->processorUnionId;
        }
        if (!Utils::isUnset($request->processorUnionIds)) {
            $body['processorUnionIds'] = $request->processorUnionIds;
        }
        if (!Utils::isUnset($request->ticketMemo)) {
            $body['ticketMemo'] = $request->ticketMemo;
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
            'action' => 'TransferTicket',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tickets/transfer',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return TransferTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 转交工单
     *  *
     * @param TransferTicketRequest $request TransferTicketRequest
     *
     * @return TransferTicketResponse TransferTicketResponse
     */
    public function transferTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TransferTicketHeaders([]);

        return $this->transferTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 变更群的群组配置信息
     *  *
     * @param UpdateGroupSetRequest $request UpdateGroupSetRequest
     * @param UpdateGroupSetHeaders $headers UpdateGroupSetHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateGroupSetResponse UpdateGroupSetResponse
     */
    public function updateGroupSetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            $body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'UpdateGroupSet',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/groups/configurations',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateGroupSetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 变更群的群组配置信息
     *  *
     * @param UpdateGroupSetRequest $request UpdateGroupSetRequest
     *
     * @return UpdateGroupSetResponse UpdateGroupSetResponse
     */
    public function updateGroupSet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGroupSetHeaders([]);

        return $this->updateGroupSetWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新服务群标签
     *  *
     * @param UpdateGroupTagRequest $request UpdateGroupTagRequest
     * @param UpdateGroupTagHeaders $headers UpdateGroupTagHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateGroupTagResponse UpdateGroupTagResponse
     */
    public function updateGroupTagWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationIds)) {
            $body['openConversationIds'] = $request->openConversationIds;
        }
        if (!Utils::isUnset($request->tagNames)) {
            $body['tagNames'] = $request->tagNames;
        }
        if (!Utils::isUnset($request->updateType)) {
            $body['updateType'] = $request->updateType;
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
            'action' => 'UpdateGroupTag',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tags',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateGroupTagResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新服务群标签
     *  *
     * @param UpdateGroupTagRequest $request UpdateGroupTagRequest
     *
     * @return UpdateGroupTagResponse UpdateGroupTagResponse
     */
    public function updateGroupTag($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGroupTagHeaders([]);

        return $this->updateGroupTagWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务群更新表单实例
     *  *
     * @param UpdateInstanceRequest $request UpdateInstanceRequest
     * @param UpdateInstanceHeaders $headers UpdateInstanceHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateInstanceResponse UpdateInstanceResponse
     */
    public function updateInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->externalBizId)) {
            $body['externalBizId'] = $request->externalBizId;
        }
        if (!Utils::isUnset($request->formCode)) {
            $body['formCode'] = $request->formCode;
        }
        if (!Utils::isUnset($request->formDataList)) {
            $body['formDataList'] = $request->formDataList;
        }
        if (!Utils::isUnset($request->openDataInstanceId)) {
            $body['openDataInstanceId'] = $request->openDataInstanceId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            $body['operatorUnionId'] = $request->operatorUnionId;
        }
        if (!Utils::isUnset($request->ownerUnionId)) {
            $body['ownerUnionId'] = $request->ownerUnionId;
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
            'action' => 'UpdateInstance',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/customForms/instances',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务群更新表单实例
     *  *
     * @param UpdateInstanceRequest $request UpdateInstanceRequest
     *
     * @return UpdateInstanceResponse UpdateInstanceResponse
     */
    public function updateInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInstanceHeaders([]);

        return $this->updateInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新工单自定义字段
     *  *
     * @param UpdateTicketRequest $request UpdateTicketRequest
     * @param UpdateTicketHeaders $headers UpdateTicketHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTicketResponse UpdateTicketResponse
     */
    public function updateTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->customFields)) {
            $body['customFields'] = $request->customFields;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            $body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->processorUnionId)) {
            $body['processorUnionId'] = $request->processorUnionId;
        }
        if (!Utils::isUnset($request->ticketMemo)) {
            $body['ticketMemo'] = $request->ticketMemo;
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
            'action' => 'UpdateTicket',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tickets',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新工单自定义字段
     *  *
     * @param UpdateTicketRequest $request UpdateTicketRequest
     *
     * @return UpdateTicketResponse UpdateTicketResponse
     */
    public function updateTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTicketHeaders([]);

        return $this->updateTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 将智能云客服下的旧版服务群升级为钉钉智能服务群
     *  *
     * @param UpgradeCloudGroupRequest $request UpgradeCloudGroupRequest
     * @param UpgradeCloudGroupHeaders $headers UpgradeCloudGroupHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return UpgradeCloudGroupResponse UpgradeCloudGroupResponse
     */
    public function upgradeCloudGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->ccsInstanceId)) {
            $body['ccsInstanceId'] = $request->ccsInstanceId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            $body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'UpgradeCloudGroup',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/cloudGroups/upgrade',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpgradeCloudGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 将智能云客服下的旧版服务群升级为钉钉智能服务群
     *  *
     * @param UpgradeCloudGroupRequest $request UpgradeCloudGroupRequest
     *
     * @return UpgradeCloudGroupResponse UpgradeCloudGroupResponse
     */
    public function upgradeCloudGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpgradeCloudGroupHeaders([]);

        return $this->upgradeCloudGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 将常规钉群升级为钉钉智能服务群
     *  *
     * @param UpgradeNormalGroupRequest $request UpgradeNormalGroupRequest
     * @param UpgradeNormalGroupHeaders $headers UpgradeNormalGroupHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return UpgradeNormalGroupResponse UpgradeNormalGroupResponse
     */
    public function upgradeNormalGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            $body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
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
            'action' => 'UpgradeNormalGroup',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/normalGroups/upgrade',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpgradeNormalGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 将常规钉群升级为钉钉智能服务群
     *  *
     * @param UpgradeNormalGroupRequest $request UpgradeNormalGroupRequest
     *
     * @return UpgradeNormalGroupResponse UpgradeNormalGroupResponse
     */
    public function upgradeNormalGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpgradeNormalGroupHeaders([]);

        return $this->upgradeNormalGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 工单催办
     *  *
     * @param UrgeTicketRequest $request UrgeTicketRequest
     * @param UrgeTicketHeaders $headers UrgeTicketHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return UrgeTicketResponse UrgeTicketResponse
     */
    public function urgeTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openTeamId)) {
            $body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            $body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            $body['operatorUnionId'] = $request->operatorUnionId;
        }
        if (!Utils::isUnset($request->ticketMemo)) {
            $body['ticketMemo'] = $request->ticketMemo;
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
            'action' => 'UrgeTicket',
            'version' => 'serviceGroup_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/serviceGroup/tickets/urge',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UrgeTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 工单催办
     *  *
     * @param UrgeTicketRequest $request UrgeTicketRequest
     *
     * @return UrgeTicketResponse UrgeTicketResponse
     */
    public function urgeTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UrgeTicketHeaders([]);

        return $this->urgeTicketWithOptions($request, $headers, $runtime);
    }
}
