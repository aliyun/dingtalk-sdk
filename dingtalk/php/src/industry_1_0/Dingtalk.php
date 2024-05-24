<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\BatchGetTaskResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\BatchGetTaskResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\BatchGetTaskResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\BusinessMatchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\BusinessMatchRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\BusinessMatchResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\BusinessMatchResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\BusinessMatchResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\BusinessMatchResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusAddRenterMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusAddRenterMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusAddRenterMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusCreateCampusGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusCreateCampusGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusCreateCampusGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusCreateCampusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusCreateCampusRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusCreateCampusResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusCreateRenterHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusCreateRenterRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusCreateRenterResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusDeleteCampusGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusDeleteCampusGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusDeleteCampusGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusDeleteRenterHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusDeleteRenterRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusDeleteRenterResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusDelRenterMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusDelRenterMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusDelRenterMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusGetCampusGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusGetCampusGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusGetCampusGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusGetCampusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusGetCampusRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusGetCampusResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusGetRenterHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusGetRenterMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusGetRenterMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusGetRenterMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusGetRenterRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusGetRenterResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusListCampusGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusListCampusGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusListCampusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusListCampusRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusListCampusResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusListRenterHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusListRenterMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusListRenterMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusListRenterMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusListRenterResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusUpdateCampusGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusUpdateCampusGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusUpdateCampusGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusUpdateCampusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusUpdateCampusRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusUpdateCampusResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusUpdateRenterHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusUpdateRenterMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusUpdateRenterMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusUpdateRenterMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusUpdateRenterRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CampusUpdateRenterResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatFormGetDataForApiAccessHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatFormGetDataForApiAccessRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatFormGetDataForApiAccessResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoAddGeneralFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoAddGeneralFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoAddGeneralFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoDeleteGeneralFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoDeleteGeneralFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoDeleteGeneralFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoFaqAddHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoFaqAddRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoFaqAddResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoFaqDeleteHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoFaqDeleteRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoFaqDeleteResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoFaqListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoFaqListRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoFaqListResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoGetFileListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoGetFileListRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoGetFileListResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoGetFileStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoGetFileStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoGetFileStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeActiveCollegeDeptGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeActiveCollegeDeptGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeActiveCollegeDeptGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeAddCollegeDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeAddCollegeDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeAddCollegeDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeAddManagerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeAddManagerRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeAddManagerResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeAddStudentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeAddStudentRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeAddStudentResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeChangeStudentDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeChangeStudentDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeChangeStudentDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeDeleteCollegeDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeDeleteCollegeDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeDeleteCollegeDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListCollegeSubDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListCollegeSubDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListCollegeSubDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListDeptManagerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListDeptManagerRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListDeptManagerResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListStudentInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListStudentInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListStudentInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListUncheckedStudentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListUncheckedStudentRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListUncheckedStudentResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeQueryCollegeDeptGroupInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeQueryCollegeDeptGroupInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeQueryCollegeDeptGroupInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeQueryCollegeDeptInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeQueryCollegeDeptInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeQueryCollegeDeptInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeQueryStudentInfoByDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeQueryStudentInfoByDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeQueryStudentInfoByDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeQueryStudentInfoByMobileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeQueryStudentInfoByMobileRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeQueryStudentInfoByMobileResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeQueryStudentInfoByStudentIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeQueryStudentInfoByStudentIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeQueryStudentInfoByStudentIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeRemoveManagerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeRemoveManagerRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeRemoveManagerResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeRemoveStudentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeRemoveStudentRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeRemoveStudentResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeUpdateCollegeDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeUpdateCollegeDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeUpdateCollegeDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeUpdateStudentDeptInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeUpdateStudentDeptInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeUpdateStudentDeptInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeUpdateStudentInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeUpdateStudentInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeUpdateStudentInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeUpdateStudentMoblieHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeUpdateStudentMoblieRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeUpdateStudentMoblieResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactCreateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactCreateRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactCreateResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeleteHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeleteRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeleteResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptCreateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptCreateRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptCreateResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptDeleteHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptDeleteRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptDeleteResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptGroupCreateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptGroupCreateRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptGroupCreateResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptListRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptListResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptUpdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptUpdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactDeptUpdateResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpAddHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpAddRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpAddResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpDeleteHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpDeleteRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpDeleteResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpListRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactEmpListResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactListResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactUpdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactUpdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactUpdateResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreCardRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreCardRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreCardRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreContactInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreContactInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreConversationsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreConversationsRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreConversationsResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreExportCardRecordDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreExportCardRecordDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreExportCardRecordDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreExportCardRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreExportCardRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreExportCardRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreGroupInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreGroupInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreGroupInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreGroupsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreGroupsResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStorelistExportTaskRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStorelistExportTaskRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStorelistExportTaskRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DIgitalStoreMessagePushHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DIgitalStoreMessagePushRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DIgitalStoreMessagePushResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DIgitalStoreMessagePushShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreNodeInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreNodeInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreNodeInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreRightsInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreRightsInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreRolesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreRolesResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreSceneScopeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreSceneScopeRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreSceneScopeResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreStoreInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreStoreInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreStoreInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreSubNodesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreSubNodesRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreSubNodesResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUpdateAuthInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUpdateAuthInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUpdateAuthInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUserInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ExternalQueryExternalAppOrgsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ExternalQueryExternalAppOrgsRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ExternalQueryExternalAppOrgsResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ExternalQueryExternalBelongMainOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ExternalQueryExternalBelongMainOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ExternalQueryExternalBelongMainOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ExternalQueryExternalOrgsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ExternalQueryExternalOrgsRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ExternalQueryExternalOrgsResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\HospitalDataCheckHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\HospitalDataCheckRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\HospitalDataCheckResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureCommonEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureCommonEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureCommonEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureCostRecordListGetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureCostRecordListGetRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureCostRecordListGetResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureFeeListGetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureFeeListGetRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureFeeListGetResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureLabourCostHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureLabourCostRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureLabourCostResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMaterialListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMaterialListRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMaterialListResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesDispatchTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesDispatchTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesDispatchTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesMaterialHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesMaterialRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesMaterialResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesOutPlanHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesOutPlanRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesOutPlanResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesOutputHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesOutputRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesOutputResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesProcessHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesProcessRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesProcessResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesProductionPlanHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesProductionPlanRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesProductionPlanResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesSubCooperationTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesSubCooperationTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesSubCooperationTeamResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesTeamMgmtHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesTeamMgmtRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesTeamMgmtResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryMmanufactureMaterialCostGetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryMmanufactureMaterialCostGetRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryMmanufactureMaterialCostGetResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\PushDingMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\PushDingMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\PushDingMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDoctorsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDoctorsRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDoctorsResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupsInDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupsInDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupsInDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllMemberByGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryBizOptLogHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryBizOptLogRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryBizOptLogResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentExtendInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentExtendInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentExtendInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDoctorDetailsByJobNumberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDoctorDetailsByJobNumberRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDoctorDetailsByJobNumberResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryGroupInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryGroupInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalDistrictInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalDistrictInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalDistrictInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRolesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRolesResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRoleUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRoleUserInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRoleUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryJobCodeDictionaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryJobCodeDictionaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryJobStatusCodeDictionaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryJobStatusCodeDictionaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryMedicalEventsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryMedicalEventsResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserCredentialsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserCredentialsRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserCredentialsResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserExtendValuesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserExtendValuesRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserExtendValuesResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserExtInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserExtInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserProbCodeDictionaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserProbCodeDictionaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserRolesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserRolesResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SaveUserExtendValuesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SaveUserExtendValuesRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SaveUserExtendValuesResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SubmitTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SubmitTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SubmitTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplAddRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplAddRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplAddRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyAddDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyAddDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyAddDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyAddMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyAddMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyAddMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyAddPartnerAdminsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyAddPartnerAdminsRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyAddPartnerAdminsResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyAddPartnerManagersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyAddPartnerManagersRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyAddPartnerManagersResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyAddPartnerTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyAddPartnerTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyAddPartnerTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyChainDeleteDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyChainDeleteDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyChainDeleteDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyChainQueryDeptInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyChainQueryDeptInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyChainQueryDeptInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyChainUpdateDeptInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyChainUpdateDeptInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyChainUpdateDeptInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyDeleteMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyDeleteMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyDeleteMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyDeletePartnerAdminsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyDeletePartnerAdminsRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyDeletePartnerAdminsResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyDeletePartnerManagersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyDeletePartnerManagersRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyDeletePartnerManagersResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyDeletePartnerTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyDeletePartnerTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyDeletePartnerTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyDeleteRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyDeleteRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyDeleteRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyGetMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyGetMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyGetMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListDeptMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListDeptMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListDeptMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListPartnerAdminsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListPartnerAdminsRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListPartnerAdminsResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListPartnerManagersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListPartnerManagersRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListPartnerManagersResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListPartnerTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListPartnerTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListPartnerTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListSubDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListSubDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListSubDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyQueryPartnerTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyQueryPartnerTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyQueryPartnerTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyUpdateMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyUpdateMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyUpdateMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyUpdatePartnerTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyUpdatePartnerTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyUpdatePartnerTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyUpdateRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyUpdateRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyUpdateRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\UpdateUserExtendInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\UpdateUserExtendInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\UpdateUserExtendInfoResponse;
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
     * @summary 批量查询任务结果
     *  *
     * @param BatchGetTaskResultRequest $request BatchGetTaskResultRequest
     * @param BatchGetTaskResultHeaders $headers BatchGetTaskResultHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchGetTaskResultResponse BatchGetTaskResultResponse
     */
    public function batchGetTaskResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->taskIds)) {
            $body['taskIds'] = $request->taskIds;
        }
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
            'action'      => 'BatchGetTaskResult',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/ai/taskResults/batchQuery',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchGetTaskResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询任务结果
     *  *
     * @param BatchGetTaskResultRequest $request BatchGetTaskResultRequest
     *
     * @return BatchGetTaskResultResponse BatchGetTaskResultResponse
     */
    public function batchGetTaskResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchGetTaskResultHeaders([]);

        return $this->batchGetTaskResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 商机匹配
     *  *
     * @param BusinessMatchRequest $request BusinessMatchRequest
     * @param BusinessMatchHeaders $headers BusinessMatchHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return BusinessMatchResponse BusinessMatchResponse
     */
    public function businessMatchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->businessInfo)) {
            $body['businessInfo'] = $request->businessInfo;
        }
        if (!Utils::isUnset($request->corpName)) {
            $body['corpName'] = $request->corpName;
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
            'action'      => 'BusinessMatch',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/me/businesses/matching',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BusinessMatchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 商机匹配
     *  *
     * @param BusinessMatchRequest $request BusinessMatchRequest
     *
     * @return BusinessMatchResponse BusinessMatchResponse
     */
    public function businessMatch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BusinessMatchHeaders([]);

        return $this->businessMatchWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 商机匹配结果查询
     *  *
     * @param BusinessMatchResultRequest $request BusinessMatchResultRequest
     * @param BusinessMatchResultHeaders $headers BusinessMatchResultHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return BusinessMatchResultResponse BusinessMatchResultResponse
     */
    public function businessMatchResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->taskId)) {
            $query['taskId'] = $request->taskId;
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
            'action'      => 'BusinessMatchResult',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/me/businesses/matchingResults',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BusinessMatchResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 商机匹配结果查询
     *  *
     * @param BusinessMatchResultRequest $request BusinessMatchResultRequest
     *
     * @return BusinessMatchResultResponse BusinessMatchResultResponse
     */
    public function businessMatchResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BusinessMatchResultHeaders([]);

        return $this->businessMatchResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加租客下成员
     *  *
     * @param CampusAddRenterMemberRequest $request CampusAddRenterMemberRequest
     * @param CampusAddRenterMemberHeaders $headers CampusAddRenterMemberHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusAddRenterMemberResponse CampusAddRenterMemberResponse
     */
    public function campusAddRenterMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->extend)) {
            $body['extend'] = $request->extend;
        }
        if (!Utils::isUnset($request->mobile)) {
            $body['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->renterId)) {
            $body['renterId'] = $request->renterId;
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
            'action'      => 'CampusAddRenterMember',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/renters/members',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusAddRenterMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加租客下成员
     *  *
     * @param CampusAddRenterMemberRequest $request CampusAddRenterMemberRequest
     *
     * @return CampusAddRenterMemberResponse CampusAddRenterMemberResponse
     */
    public function campusAddRenterMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusAddRenterMemberHeaders([]);

        return $this->campusAddRenterMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建园区
     *  *
     * @param CampusCreateCampusRequest $request CampusCreateCampusRequest
     * @param CampusCreateCampusHeaders $headers CampusCreateCampusHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusCreateCampusResponse CampusCreateCampusResponse
     */
    public function campusCreateCampusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->address)) {
            $body['address'] = $request->address;
        }
        if (!Utils::isUnset($request->area)) {
            $body['area'] = $request->area;
        }
        if (!Utils::isUnset($request->belongProjectGroupId)) {
            $body['belongProjectGroupId'] = $request->belongProjectGroupId;
        }
        if (!Utils::isUnset($request->campusName)) {
            $body['campusName'] = $request->campusName;
        }
        if (!Utils::isUnset($request->capacity)) {
            $body['capacity'] = $request->capacity;
        }
        if (!Utils::isUnset($request->cityId)) {
            $body['cityId'] = $request->cityId;
        }
        if (!Utils::isUnset($request->country)) {
            $body['country'] = $request->country;
        }
        if (!Utils::isUnset($request->countyId)) {
            $body['countyId'] = $request->countyId;
        }
        if (!Utils::isUnset($request->creatorUnionId)) {
            $body['creatorUnionId'] = $request->creatorUnionId;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->extend)) {
            $body['extend'] = $request->extend;
        }
        if (!Utils::isUnset($request->location)) {
            $body['location'] = $request->location;
        }
        if (!Utils::isUnset($request->orderEndTime)) {
            $body['orderEndTime'] = $request->orderEndTime;
        }
        if (!Utils::isUnset($request->orderInfo)) {
            $body['orderInfo'] = $request->orderInfo;
        }
        if (!Utils::isUnset($request->orderStartTime)) {
            $body['orderStartTime'] = $request->orderStartTime;
        }
        if (!Utils::isUnset($request->provId)) {
            $body['provId'] = $request->provId;
        }
        if (!Utils::isUnset($request->telephone)) {
            $body['telephone'] = $request->telephone;
        }
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
            'action'      => 'CampusCreateCampus',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/projects',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusCreateCampusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建园区
     *  *
     * @param CampusCreateCampusRequest $request CampusCreateCampusRequest
     *
     * @return CampusCreateCampusResponse CampusCreateCampusResponse
     */
    public function campusCreateCampus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusCreateCampusHeaders([]);

        return $this->campusCreateCampusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建园区项目组
     *  *
     * @param CampusCreateCampusGroupRequest $request CampusCreateCampusGroupRequest
     * @param CampusCreateCampusGroupHeaders $headers CampusCreateCampusGroupHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusCreateCampusGroupResponse CampusCreateCampusGroupResponse
     */
    public function campusCreateCampusGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->extend)) {
            $body['extend'] = $request->extend;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
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
            'action'      => 'CampusCreateCampusGroup',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/projects/groups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusCreateCampusGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建园区项目组
     *  *
     * @param CampusCreateCampusGroupRequest $request CampusCreateCampusGroupRequest
     *
     * @return CampusCreateCampusGroupResponse CampusCreateCampusGroupResponse
     */
    public function campusCreateCampusGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusCreateCampusGroupHeaders([]);

        return $this->campusCreateCampusGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建租客
     *  *
     * @param CampusCreateRenterRequest $request CampusCreateRenterRequest
     * @param CampusCreateRenterHeaders $headers CampusCreateRenterHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusCreateRenterResponse CampusCreateRenterResponse
     */
    public function campusCreateRenterWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->creditCode)) {
            $body['creditCode'] = $request->creditCode;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->extend)) {
            $body['extend'] = $request->extend;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->state)) {
            $body['state'] = $request->state;
        }
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
            'action'      => 'CampusCreateRenter',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/renters',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusCreateRenterResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建租客
     *  *
     * @param CampusCreateRenterRequest $request CampusCreateRenterRequest
     *
     * @return CampusCreateRenterResponse CampusCreateRenterResponse
     */
    public function campusCreateRenter($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusCreateRenterHeaders([]);

        return $this->campusCreateRenterWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 移除租客人员
     *  *
     * @param CampusDelRenterMemberRequest $request CampusDelRenterMemberRequest
     * @param CampusDelRenterMemberHeaders $headers CampusDelRenterMemberHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusDelRenterMemberResponse CampusDelRenterMemberResponse
     */
    public function campusDelRenterMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->renterId)) {
            $query['renterId'] = $request->renterId;
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
            'action'      => 'CampusDelRenterMember',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/renters/members',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusDelRenterMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 移除租客人员
     *  *
     * @param CampusDelRenterMemberRequest $request CampusDelRenterMemberRequest
     *
     * @return CampusDelRenterMemberResponse CampusDelRenterMemberResponse
     */
    public function campusDelRenterMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusDelRenterMemberHeaders([]);

        return $this->campusDelRenterMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除园区项目组
     *  *
     * @param CampusDeleteCampusGroupRequest $request CampusDeleteCampusGroupRequest
     * @param CampusDeleteCampusGroupHeaders $headers CampusDeleteCampusGroupHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusDeleteCampusGroupResponse CampusDeleteCampusGroupResponse
     */
    public function campusDeleteCampusGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->campusProjectGroupId)) {
            $query['campusProjectGroupId'] = $request->campusProjectGroupId;
        }
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
            'action'      => 'CampusDeleteCampusGroup',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/projects/groups',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusDeleteCampusGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除园区项目组
     *  *
     * @param CampusDeleteCampusGroupRequest $request CampusDeleteCampusGroupRequest
     *
     * @return CampusDeleteCampusGroupResponse CampusDeleteCampusGroupResponse
     */
    public function campusDeleteCampusGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusDeleteCampusGroupHeaders([]);

        return $this->campusDeleteCampusGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除租客
     *  *
     * @param CampusDeleteRenterRequest $request CampusDeleteRenterRequest
     * @param CampusDeleteRenterHeaders $headers CampusDeleteRenterHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusDeleteRenterResponse CampusDeleteRenterResponse
     */
    public function campusDeleteRenterWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->renterId)) {
            $query['renterId'] = $request->renterId;
        }
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
            'action'      => 'CampusDeleteRenter',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/renters',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return CampusDeleteRenterResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除租客
     *  *
     * @param CampusDeleteRenterRequest $request CampusDeleteRenterRequest
     *
     * @return CampusDeleteRenterResponse CampusDeleteRenterResponse
     */
    public function campusDeleteRenter($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusDeleteRenterHeaders([]);

        return $this->campusDeleteRenterWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询园区详情
     *  *
     * @param CampusGetCampusRequest $request CampusGetCampusRequest
     * @param CampusGetCampusHeaders $headers CampusGetCampusHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusGetCampusResponse CampusGetCampusResponse
     */
    public function campusGetCampusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->campusDeptId)) {
            $query['campusDeptId'] = $request->campusDeptId;
        }
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
            'action'      => 'CampusGetCampus',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/projectInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusGetCampusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询园区详情
     *  *
     * @param CampusGetCampusRequest $request CampusGetCampusRequest
     *
     * @return CampusGetCampusResponse CampusGetCampusResponse
     */
    public function campusGetCampus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusGetCampusHeaders([]);

        return $this->campusGetCampusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询园区项目组详情
     *  *
     * @param CampusGetCampusGroupRequest $request CampusGetCampusGroupRequest
     * @param CampusGetCampusGroupHeaders $headers CampusGetCampusGroupHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusGetCampusGroupResponse CampusGetCampusGroupResponse
     */
    public function campusGetCampusGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->groupId)) {
            $query['groupId'] = $request->groupId;
        }
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
            'action'      => 'CampusGetCampusGroup',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/projects/groupInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusGetCampusGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询园区项目组详情
     *  *
     * @param CampusGetCampusGroupRequest $request CampusGetCampusGroupRequest
     *
     * @return CampusGetCampusGroupResponse CampusGetCampusGroupResponse
     */
    public function campusGetCampusGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusGetCampusGroupHeaders([]);

        return $this->campusGetCampusGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取租客详情
     *  *
     * @param CampusGetRenterRequest $request CampusGetRenterRequest
     * @param CampusGetRenterHeaders $headers CampusGetRenterHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusGetRenterResponse CampusGetRenterResponse
     */
    public function campusGetRenterWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->renterId)) {
            $query['renterId'] = $request->renterId;
        }
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
            'action'      => 'CampusGetRenter',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/renterInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusGetRenterResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取租客详情
     *  *
     * @param CampusGetRenterRequest $request CampusGetRenterRequest
     *
     * @return CampusGetRenterResponse CampusGetRenterResponse
     */
    public function campusGetRenter($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusGetRenterHeaders([]);

        return $this->campusGetRenterWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询租客指定成员信息
     *  *
     * @param CampusGetRenterMemberRequest $request CampusGetRenterMemberRequest
     * @param CampusGetRenterMemberHeaders $headers CampusGetRenterMemberHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusGetRenterMemberResponse CampusGetRenterMemberResponse
     */
    public function campusGetRenterMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->renterId)) {
            $query['renterId'] = $request->renterId;
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
            'action'      => 'CampusGetRenterMember',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/renters/memberInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusGetRenterMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询租客指定成员信息
     *  *
     * @param CampusGetRenterMemberRequest $request CampusGetRenterMemberRequest
     *
     * @return CampusGetRenterMemberResponse CampusGetRenterMemberResponse
     */
    public function campusGetRenterMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusGetRenterMemberHeaders([]);

        return $this->campusGetRenterMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询园区列表
     *  *
     * @param CampusListCampusRequest $request CampusListCampusRequest
     * @param CampusListCampusHeaders $headers CampusListCampusHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusListCampusResponse CampusListCampusResponse
     */
    public function campusListCampusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->groupDeptId)) {
            $query['groupDeptId'] = $request->groupDeptId;
        }
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
            'action'      => 'CampusListCampus',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/projects',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusListCampusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询园区列表
     *  *
     * @param CampusListCampusRequest $request CampusListCampusRequest
     *
     * @return CampusListCampusResponse CampusListCampusResponse
     */
    public function campusListCampus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusListCampusHeaders([]);

        return $this->campusListCampusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询园区项目组列表
     *  *
     * @param CampusListCampusGroupHeaders $headers CampusListCampusGroupHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusListCampusGroupResponse CampusListCampusGroupResponse
     */
    public function campusListCampusGroupWithOptions($headers, $runtime)
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
            'action'      => 'CampusListCampusGroup',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/projects/groups',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusListCampusGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询园区项目组列表
     *  *
     * @return CampusListCampusGroupResponse CampusListCampusGroupResponse
     */
    public function campusListCampusGroup()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusListCampusGroupHeaders([]);

        return $this->campusListCampusGroupWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取租客列表
     *  *
     * @param CampusListRenterHeaders $headers CampusListRenterHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusListRenterResponse CampusListRenterResponse
     */
    public function campusListRenterWithOptions($headers, $runtime)
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
            'action'      => 'CampusListRenter',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/renters',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusListRenterResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取租客列表
     *  *
     * @return CampusListRenterResponse CampusListRenterResponse
     */
    public function campusListRenter()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusListRenterHeaders([]);

        return $this->campusListRenterWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询租客下所有成员
     *  *
     * @param CampusListRenterMembersRequest $request CampusListRenterMembersRequest
     * @param CampusListRenterMembersHeaders $headers CampusListRenterMembersHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusListRenterMembersResponse CampusListRenterMembersResponse
     */
    public function campusListRenterMembersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->renterId)) {
            $query['renterId'] = $request->renterId;
        }
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
            'action'      => 'CampusListRenterMembers',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/renters/members',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusListRenterMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询租客下所有成员
     *  *
     * @param CampusListRenterMembersRequest $request CampusListRenterMembersRequest
     *
     * @return CampusListRenterMembersResponse CampusListRenterMembersResponse
     */
    public function campusListRenterMembers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusListRenterMembersHeaders([]);

        return $this->campusListRenterMembersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新园区项目
     *  *
     * @param CampusUpdateCampusRequest $request CampusUpdateCampusRequest
     * @param CampusUpdateCampusHeaders $headers CampusUpdateCampusHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusUpdateCampusResponse CampusUpdateCampusResponse
     */
    public function campusUpdateCampusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->address)) {
            $body['address'] = $request->address;
        }
        if (!Utils::isUnset($request->area)) {
            $body['area'] = $request->area;
        }
        if (!Utils::isUnset($request->belongProjectGroupId)) {
            $body['belongProjectGroupId'] = $request->belongProjectGroupId;
        }
        if (!Utils::isUnset($request->campusDeptId)) {
            $body['campusDeptId'] = $request->campusDeptId;
        }
        if (!Utils::isUnset($request->campusName)) {
            $body['campusName'] = $request->campusName;
        }
        if (!Utils::isUnset($request->capacity)) {
            $body['capacity'] = $request->capacity;
        }
        if (!Utils::isUnset($request->cityId)) {
            $body['cityId'] = $request->cityId;
        }
        if (!Utils::isUnset($request->country)) {
            $body['country'] = $request->country;
        }
        if (!Utils::isUnset($request->countyId)) {
            $body['countyId'] = $request->countyId;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->extend)) {
            $body['extend'] = $request->extend;
        }
        if (!Utils::isUnset($request->orderEndTime)) {
            $body['orderEndTime'] = $request->orderEndTime;
        }
        if (!Utils::isUnset($request->orderInfo)) {
            $body['orderInfo'] = $request->orderInfo;
        }
        if (!Utils::isUnset($request->orderStartTime)) {
            $body['orderStartTime'] = $request->orderStartTime;
        }
        if (!Utils::isUnset($request->provId)) {
            $body['provId'] = $request->provId;
        }
        if (!Utils::isUnset($request->telephone)) {
            $body['telephone'] = $request->telephone;
        }
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
            'action'      => 'CampusUpdateCampus',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/projects',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusUpdateCampusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新园区项目
     *  *
     * @param CampusUpdateCampusRequest $request CampusUpdateCampusRequest
     *
     * @return CampusUpdateCampusResponse CampusUpdateCampusResponse
     */
    public function campusUpdateCampus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusUpdateCampusHeaders([]);

        return $this->campusUpdateCampusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新园区项目组
     *  *
     * @param CampusUpdateCampusGroupRequest $request CampusUpdateCampusGroupRequest
     * @param CampusUpdateCampusGroupHeaders $headers CampusUpdateCampusGroupHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusUpdateCampusGroupResponse CampusUpdateCampusGroupResponse
     */
    public function campusUpdateCampusGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->campusProjectGroupId)) {
            $body['campusProjectGroupId'] = $request->campusProjectGroupId;
        }
        if (!Utils::isUnset($request->extend)) {
            $body['extend'] = $request->extend;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
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
            'action'      => 'CampusUpdateCampusGroup',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/projects/groups',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusUpdateCampusGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新园区项目组
     *  *
     * @param CampusUpdateCampusGroupRequest $request CampusUpdateCampusGroupRequest
     *
     * @return CampusUpdateCampusGroupResponse CampusUpdateCampusGroupResponse
     */
    public function campusUpdateCampusGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusUpdateCampusGroupHeaders([]);

        return $this->campusUpdateCampusGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新租客
     *  *
     * @param CampusUpdateRenterRequest $request CampusUpdateRenterRequest
     * @param CampusUpdateRenterHeaders $headers CampusUpdateRenterHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusUpdateRenterResponse CampusUpdateRenterResponse
     */
    public function campusUpdateRenterWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->creditCode)) {
            $body['creditCode'] = $request->creditCode;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->extend)) {
            $body['extend'] = $request->extend;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->renterId)) {
            $body['renterId'] = $request->renterId;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->state)) {
            $body['state'] = $request->state;
        }
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
            'action'      => 'CampusUpdateRenter',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/renters',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusUpdateRenterResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新租客
     *  *
     * @param CampusUpdateRenterRequest $request CampusUpdateRenterRequest
     *
     * @return CampusUpdateRenterResponse CampusUpdateRenterResponse
     */
    public function campusUpdateRenter($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusUpdateRenterHeaders([]);

        return $this->campusUpdateRenterWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新租客下成员
     *  *
     * @param CampusUpdateRenterMemberRequest $request CampusUpdateRenterMemberRequest
     * @param CampusUpdateRenterMemberHeaders $headers CampusUpdateRenterMemberHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return CampusUpdateRenterMemberResponse CampusUpdateRenterMemberResponse
     */
    public function campusUpdateRenterMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->extend)) {
            $body['extend'] = $request->extend;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->renterId)) {
            $body['renterId'] = $request->renterId;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
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
            'action'      => 'CampusUpdateRenterMember',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/campuses/renters/members',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CampusUpdateRenterMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新租客下成员
     *  *
     * @param CampusUpdateRenterMemberRequest $request CampusUpdateRenterMemberRequest
     *
     * @return CampusUpdateRenterMemberResponse CampusUpdateRenterMemberResponse
     */
    public function campusUpdateRenterMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusUpdateRenterMemberHeaders([]);

        return $this->campusUpdateRenterMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary ChatForm查询表单识别结果
     *  *
     * @param ChatFormGetDataForApiAccessRequest $request ChatFormGetDataForApiAccessRequest
     * @param ChatFormGetDataForApiAccessHeaders $headers ChatFormGetDataForApiAccessHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return ChatFormGetDataForApiAccessResponse ChatFormGetDataForApiAccessResponse
     */
    public function chatFormGetDataForApiAccessWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->dingTalkTraceId)) {
            $query['dingTalkTraceId'] = $request->dingTalkTraceId;
        }
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
            'action'      => 'ChatFormGetDataForApiAccess',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/chatform/datas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ChatFormGetDataForApiAccessResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary ChatForm查询表单识别结果
     *  *
     * @param ChatFormGetDataForApiAccessRequest $request ChatFormGetDataForApiAccessRequest
     *
     * @return ChatFormGetDataForApiAccessResponse ChatFormGetDataForApiAccessResponse
     */
    public function chatFormGetDataForApiAccess($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChatFormGetDataForApiAccessHeaders([]);

        return $this->chatFormGetDataForApiAccessWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新增普通文件
     *  *
     * @param ChatMemoAddGeneralFileRequest $request ChatMemoAddGeneralFileRequest
     * @param ChatMemoAddGeneralFileHeaders $headers ChatMemoAddGeneralFileHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return ChatMemoAddGeneralFileResponse ChatMemoAddGeneralFileResponse
     */
    public function chatMemoAddGeneralFileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->datasetId)) {
            $body['datasetId'] = $request->datasetId;
        }
        if (!Utils::isUnset($request->downloadUrl)) {
            $body['downloadUrl'] = $request->downloadUrl;
        }
        if (!Utils::isUnset($request->fileDesc)) {
            $body['fileDesc'] = $request->fileDesc;
        }
        if (!Utils::isUnset($request->fileName)) {
            $body['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->tagList)) {
            $body['tagList'] = $request->tagList;
        }
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
            'action'      => 'ChatMemoAddGeneralFile',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/chatmemo/files',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ChatMemoAddGeneralFileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增普通文件
     *  *
     * @param ChatMemoAddGeneralFileRequest $request ChatMemoAddGeneralFileRequest
     *
     * @return ChatMemoAddGeneralFileResponse ChatMemoAddGeneralFileResponse
     */
    public function chatMemoAddGeneralFile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChatMemoAddGeneralFileHeaders([]);

        return $this->chatMemoAddGeneralFileWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除普通文件
     *  *
     * @param ChatMemoDeleteGeneralFileRequest $request ChatMemoDeleteGeneralFileRequest
     * @param ChatMemoDeleteGeneralFileHeaders $headers ChatMemoDeleteGeneralFileHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return ChatMemoDeleteGeneralFileResponse ChatMemoDeleteGeneralFileResponse
     */
    public function chatMemoDeleteGeneralFileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->datasetId)) {
            $body['datasetId'] = $request->datasetId;
        }
        if (!Utils::isUnset($request->mediaId)) {
            $body['mediaId'] = $request->mediaId;
        }
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
            'action'      => 'ChatMemoDeleteGeneralFile',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/chatmemo/files/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ChatMemoDeleteGeneralFileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除普通文件
     *  *
     * @param ChatMemoDeleteGeneralFileRequest $request ChatMemoDeleteGeneralFileRequest
     *
     * @return ChatMemoDeleteGeneralFileResponse ChatMemoDeleteGeneralFileResponse
     */
    public function chatMemoDeleteGeneralFile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChatMemoDeleteGeneralFileHeaders([]);

        return $this->chatMemoDeleteGeneralFileWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新增 FAQ
     *  *
     * @param ChatMemoFaqAddRequest $request ChatMemoFaqAddRequest
     * @param ChatMemoFaqAddHeaders $headers ChatMemoFaqAddHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return ChatMemoFaqAddResponse ChatMemoFaqAddResponse
     */
    public function chatMemoFaqAddWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->answer)) {
            $body['answer'] = $request->answer;
        }
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->datasetId)) {
            $body['datasetId'] = $request->datasetId;
        }
        if (!Utils::isUnset($request->question)) {
            $body['question'] = $request->question;
        }
        if (!Utils::isUnset($request->redirection)) {
            $body['redirection'] = $request->redirection;
        }
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
            'action'      => 'ChatMemoFaqAdd',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/chatmemo/faq',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ChatMemoFaqAddResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增 FAQ
     *  *
     * @param ChatMemoFaqAddRequest $request ChatMemoFaqAddRequest
     *
     * @return ChatMemoFaqAddResponse ChatMemoFaqAddResponse
     */
    public function chatMemoFaqAdd($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChatMemoFaqAddHeaders([]);

        return $this->chatMemoFaqAddWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除指定数据集中的FAQ
     *  *
     * @param ChatMemoFaqDeleteRequest $request ChatMemoFaqDeleteRequest
     * @param ChatMemoFaqDeleteHeaders $headers ChatMemoFaqDeleteHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return ChatMemoFaqDeleteResponse ChatMemoFaqDeleteResponse
     */
    public function chatMemoFaqDeleteWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->datasetId)) {
            $body['datasetId'] = $request->datasetId;
        }
        if (!Utils::isUnset($request->mediaId)) {
            $body['mediaId'] = $request->mediaId;
        }
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
            'action'      => 'ChatMemoFaqDelete',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/chatmemo/faq/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ChatMemoFaqDeleteResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除指定数据集中的FAQ
     *  *
     * @param ChatMemoFaqDeleteRequest $request ChatMemoFaqDeleteRequest
     *
     * @return ChatMemoFaqDeleteResponse ChatMemoFaqDeleteResponse
     */
    public function chatMemoFaqDelete($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChatMemoFaqDeleteHeaders([]);

        return $this->chatMemoFaqDeleteWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询指定数据集中的FAQ列表
     *  *
     * @param ChatMemoFaqListRequest $request ChatMemoFaqListRequest
     * @param ChatMemoFaqListHeaders $headers ChatMemoFaqListHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ChatMemoFaqListResponse ChatMemoFaqListResponse
     */
    public function chatMemoFaqListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->datasetId)) {
            $query['datasetId'] = $request->datasetId;
        }
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ChatMemoFaqList',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/chatmemo/faq/lists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ChatMemoFaqListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询指定数据集中的FAQ列表
     *  *
     * @param ChatMemoFaqListRequest $request ChatMemoFaqListRequest
     *
     * @return ChatMemoFaqListResponse ChatMemoFaqListResponse
     */
    public function chatMemoFaqList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChatMemoFaqListHeaders([]);

        return $this->chatMemoFaqListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询指定数据集中的文件列表
     *  *
     * @param ChatMemoGetFileListRequest $request ChatMemoGetFileListRequest
     * @param ChatMemoGetFileListHeaders $headers ChatMemoGetFileListHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return ChatMemoGetFileListResponse ChatMemoGetFileListResponse
     */
    public function chatMemoGetFileListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->datasetId)) {
            $query['datasetId'] = $request->datasetId;
        }
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ChatMemoGetFileList',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/chatmemo/file/lists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ChatMemoGetFileListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询指定数据集中的文件列表
     *  *
     * @param ChatMemoGetFileListRequest $request ChatMemoGetFileListRequest
     *
     * @return ChatMemoGetFileListResponse ChatMemoGetFileListResponse
     */
    public function chatMemoGetFileList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChatMemoGetFileListHeaders([]);

        return $this->chatMemoGetFileListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取文件状态
     *  *
     * @param ChatMemoGetFileStatusRequest $request ChatMemoGetFileStatusRequest
     * @param ChatMemoGetFileStatusHeaders $headers ChatMemoGetFileStatusHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return ChatMemoGetFileStatusResponse ChatMemoGetFileStatusResponse
     */
    public function chatMemoGetFileStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->datasetId)) {
            $body['datasetId'] = $request->datasetId;
        }
        if (!Utils::isUnset($request->mediaId)) {
            $body['mediaId'] = $request->mediaId;
        }
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
            'action'      => 'ChatMemoGetFileStatus',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/chatmemo/files/statuses/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ChatMemoGetFileStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取文件状态
     *  *
     * @param ChatMemoGetFileStatusRequest $request ChatMemoGetFileStatusRequest
     *
     * @return ChatMemoGetFileStatusResponse ChatMemoGetFileStatusResponse
     */
    public function chatMemoGetFileStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChatMemoGetFileStatusHeaders([]);

        return $this->chatMemoGetFileStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 开启学段/学院/年级/专业\系/班级群
     *  *
     * @param CollegeActiveCollegeDeptGroupRequest $request CollegeActiveCollegeDeptGroupRequest
     * @param CollegeActiveCollegeDeptGroupHeaders $headers CollegeActiveCollegeDeptGroupHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeActiveCollegeDeptGroupResponse CollegeActiveCollegeDeptGroupResponse
     */
    public function collegeActiveCollegeDeptGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
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
            'action'      => 'CollegeActiveCollegeDeptGroup',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/depts/groups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeActiveCollegeDeptGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 开启学段/学院/年级/专业\系/班级群
     *  *
     * @param CollegeActiveCollegeDeptGroupRequest $request CollegeActiveCollegeDeptGroupRequest
     *
     * @return CollegeActiveCollegeDeptGroupResponse CollegeActiveCollegeDeptGroupResponse
     */
    public function collegeActiveCollegeDeptGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeActiveCollegeDeptGroupHeaders([]);

        return $this->collegeActiveCollegeDeptGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建学段/学院/年级/专业\系/班级
     *  *
     * @param CollegeAddCollegeDeptRequest $request CollegeAddCollegeDeptRequest
     * @param CollegeAddCollegeDeptHeaders $headers CollegeAddCollegeDeptHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeAddCollegeDeptResponse CollegeAddCollegeDeptResponse
     */
    public function collegeAddCollegeDeptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptName)) {
            $query['deptName'] = $request->deptName;
        }
        if (!Utils::isUnset($request->deptType)) {
            $query['deptType'] = $request->deptType;
        }
        if (!Utils::isUnset($request->sortFactor)) {
            $query['sortFactor'] = $request->sortFactor;
        }
        if (!Utils::isUnset($request->superId)) {
            $query['superId'] = $request->superId;
        }
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
            'action'      => 'CollegeAddCollegeDept',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/depts',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeAddCollegeDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建学段/学院/年级/专业\系/班级
     *  *
     * @param CollegeAddCollegeDeptRequest $request CollegeAddCollegeDeptRequest
     *
     * @return CollegeAddCollegeDeptResponse CollegeAddCollegeDeptResponse
     */
    public function collegeAddCollegeDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeAddCollegeDeptHeaders([]);

        return $this->collegeAddCollegeDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 往部门中添加负责人
     *  *
     * @param CollegeAddManagerRequest $request CollegeAddManagerRequest
     * @param CollegeAddManagerHeaders $headers CollegeAddManagerHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeAddManagerResponse CollegeAddManagerResponse
     */
    public function collegeAddManagerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
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
            'action'      => 'CollegeAddManager',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/members/depts/managers',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeAddManagerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 往部门中添加负责人
     *  *
     * @param CollegeAddManagerRequest $request CollegeAddManagerRequest
     *
     * @return CollegeAddManagerResponse CollegeAddManagerResponse
     */
    public function collegeAddManager($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeAddManagerHeaders([]);

        return $this->collegeAddManagerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 在班级中添加人员
     *  *
     * @param CollegeAddStudentRequest $request CollegeAddStudentRequest
     * @param CollegeAddStudentHeaders $headers CollegeAddStudentHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeAddStudentResponse CollegeAddStudentResponse
     */
    public function collegeAddStudentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->empExtension)) {
            $body['empExtension'] = $request->empExtension;
        }
        if (!Utils::isUnset($request->gender)) {
            $body['gender'] = $request->gender;
        }
        if (!Utils::isUnset($request->identifyId)) {
            $body['identifyId'] = $request->identifyId;
        }
        if (!Utils::isUnset($request->mobile)) {
            $body['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->startYear)) {
            $body['startYear'] = $request->startYear;
        }
        if (!Utils::isUnset($request->studentName)) {
            $body['studentName'] = $request->studentName;
        }
        if (!Utils::isUnset($request->studentNumber)) {
            $body['studentNumber'] = $request->studentNumber;
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
            'action'      => 'CollegeAddStudent',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/members/depts/students',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeAddStudentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 在班级中添加人员
     *  *
     * @param CollegeAddStudentRequest $request CollegeAddStudentRequest
     *
     * @return CollegeAddStudentResponse CollegeAddStudentResponse
     */
    public function collegeAddStudent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeAddStudentHeaders([]);

        return $this->collegeAddStudentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 移动学生到其他部门
     *  *
     * @param CollegeChangeStudentDeptRequest $request CollegeChangeStudentDeptRequest
     * @param CollegeChangeStudentDeptHeaders $headers CollegeChangeStudentDeptHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeChangeStudentDeptResponse CollegeChangeStudentDeptResponse
     */
    public function collegeChangeStudentDeptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->newDeptId)) {
            $query['newDeptId'] = $request->newDeptId;
        }
        if (!Utils::isUnset($request->studentId)) {
            $query['studentId'] = $request->studentId;
        }
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
            'action'      => 'CollegeChangeStudentDept',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/members/depts/students/move',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeChangeStudentDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 移动学生到其他部门
     *  *
     * @param CollegeChangeStudentDeptRequest $request CollegeChangeStudentDeptRequest
     *
     * @return CollegeChangeStudentDeptResponse CollegeChangeStudentDeptResponse
     */
    public function collegeChangeStudentDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeChangeStudentDeptHeaders([]);

        return $this->collegeChangeStudentDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除学段/学院/年级/专业\系/班级
     *  *
     * @param CollegeDeleteCollegeDeptRequest $request CollegeDeleteCollegeDeptRequest
     * @param CollegeDeleteCollegeDeptHeaders $headers CollegeDeleteCollegeDeptHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeDeleteCollegeDeptResponse CollegeDeleteCollegeDeptResponse
     */
    public function collegeDeleteCollegeDeptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
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
            'action'      => 'CollegeDeleteCollegeDept',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/depts',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeDeleteCollegeDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除学段/学院/年级/专业\系/班级
     *  *
     * @param CollegeDeleteCollegeDeptRequest $request CollegeDeleteCollegeDeptRequest
     *
     * @return CollegeDeleteCollegeDeptResponse CollegeDeleteCollegeDeptResponse
     */
    public function collegeDeleteCollegeDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeDeleteCollegeDeptHeaders([]);

        return $this->collegeDeleteCollegeDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取下级节点列表
     *  *
     * @param CollegeListCollegeSubDeptRequest $request CollegeListCollegeSubDeptRequest
     * @param CollegeListCollegeSubDeptHeaders $headers CollegeListCollegeSubDeptHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeListCollegeSubDeptResponse CollegeListCollegeSubDeptResponse
     */
    public function collegeListCollegeSubDeptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
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
            'action'      => 'CollegeListCollegeSubDept',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/subDepts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeListCollegeSubDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取下级节点列表
     *  *
     * @param CollegeListCollegeSubDeptRequest $request CollegeListCollegeSubDeptRequest
     *
     * @return CollegeListCollegeSubDeptResponse CollegeListCollegeSubDeptResponse
     */
    public function collegeListCollegeSubDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeListCollegeSubDeptHeaders([]);

        return $this->collegeListCollegeSubDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取部门下所有负责人列表
     *  *
     * @param CollegeListDeptManagerRequest $request CollegeListDeptManagerRequest
     * @param CollegeListDeptManagerHeaders $headers CollegeListDeptManagerHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeListDeptManagerResponse CollegeListDeptManagerResponse
     */
    public function collegeListDeptManagerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'CollegeListDeptManager',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/members/depts/managers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeListDeptManagerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取部门下所有负责人列表
     *  *
     * @param CollegeListDeptManagerRequest $request CollegeListDeptManagerRequest
     *
     * @return CollegeListDeptManagerResponse CollegeListDeptManagerResponse
     */
    public function collegeListDeptManager($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeListDeptManagerHeaders([]);

        return $this->collegeListDeptManagerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页获取班级下所有学生列表
     *  *
     * @param CollegeListStudentInfoRequest $request CollegeListStudentInfoRequest
     * @param CollegeListStudentInfoHeaders $headers CollegeListStudentInfoHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeListStudentInfoResponse CollegeListStudentInfoResponse
     */
    public function collegeListStudentInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->dingStudentStatus)) {
            $query['dingStudentStatus'] = $request->dingStudentStatus;
        }
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'CollegeListStudentInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/members/depts/students',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeListStudentInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页获取班级下所有学生列表
     *  *
     * @param CollegeListStudentInfoRequest $request CollegeListStudentInfoRequest
     *
     * @return CollegeListStudentInfoResponse CollegeListStudentInfoResponse
     */
    public function collegeListStudentInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeListStudentInfoHeaders([]);

        return $this->collegeListStudentInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页查询未加入组织的学生列表
     *  *
     * @param CollegeListUncheckedStudentRequest $request CollegeListUncheckedStudentRequest
     * @param CollegeListUncheckedStudentHeaders $headers CollegeListUncheckedStudentHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeListUncheckedStudentResponse CollegeListUncheckedStudentResponse
     */
    public function collegeListUncheckedStudentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'CollegeListUncheckedStudent',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/members/organizations/unjoinedStudents',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeListUncheckedStudentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页查询未加入组织的学生列表
     *  *
     * @param CollegeListUncheckedStudentRequest $request CollegeListUncheckedStudentRequest
     *
     * @return CollegeListUncheckedStudentResponse CollegeListUncheckedStudentResponse
     */
    public function collegeListUncheckedStudent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeListUncheckedStudentHeaders([]);

        return $this->collegeListUncheckedStudentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取学段/学院/年级/专业\系/班级群群信息
     *  *
     * @param CollegeQueryCollegeDeptGroupInfoRequest $request CollegeQueryCollegeDeptGroupInfoRequest
     * @param CollegeQueryCollegeDeptGroupInfoHeaders $headers CollegeQueryCollegeDeptGroupInfoHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeQueryCollegeDeptGroupInfoResponse CollegeQueryCollegeDeptGroupInfoResponse
     */
    public function collegeQueryCollegeDeptGroupInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
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
            'action'      => 'CollegeQueryCollegeDeptGroupInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/depts/groupInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeQueryCollegeDeptGroupInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取学段/学院/年级/专业\系/班级群群信息
     *  *
     * @param CollegeQueryCollegeDeptGroupInfoRequest $request CollegeQueryCollegeDeptGroupInfoRequest
     *
     * @return CollegeQueryCollegeDeptGroupInfoResponse CollegeQueryCollegeDeptGroupInfoResponse
     */
    public function collegeQueryCollegeDeptGroupInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeQueryCollegeDeptGroupInfoHeaders([]);

        return $this->collegeQueryCollegeDeptGroupInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取学段/学院/年级/专业\系/班级信息
     *  *
     * @param CollegeQueryCollegeDeptInfoRequest $request CollegeQueryCollegeDeptInfoRequest
     * @param CollegeQueryCollegeDeptInfoHeaders $headers CollegeQueryCollegeDeptInfoHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeQueryCollegeDeptInfoResponse CollegeQueryCollegeDeptInfoResponse
     */
    public function collegeQueryCollegeDeptInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
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
            'action'      => 'CollegeQueryCollegeDeptInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/deptInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeQueryCollegeDeptInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取学段/学院/年级/专业\系/班级信息
     *  *
     * @param CollegeQueryCollegeDeptInfoRequest $request CollegeQueryCollegeDeptInfoRequest
     *
     * @return CollegeQueryCollegeDeptInfoResponse CollegeQueryCollegeDeptInfoResponse
     */
    public function collegeQueryCollegeDeptInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeQueryCollegeDeptInfoHeaders([]);

        return $this->collegeQueryCollegeDeptInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取指定部门下指定学生的信息
     *  *
     * @param CollegeQueryStudentInfoByDeptRequest $request CollegeQueryStudentInfoByDeptRequest
     * @param CollegeQueryStudentInfoByDeptHeaders $headers CollegeQueryStudentInfoByDeptHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeQueryStudentInfoByDeptResponse CollegeQueryStudentInfoByDeptResponse
     */
    public function collegeQueryStudentInfoByDeptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->studentId)) {
            $query['studentId'] = $request->studentId;
        }
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
            'action'      => 'CollegeQueryStudentInfoByDept',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/members/depts/studentinfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeQueryStudentInfoByDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取指定部门下指定学生的信息
     *  *
     * @param CollegeQueryStudentInfoByDeptRequest $request CollegeQueryStudentInfoByDeptRequest
     *
     * @return CollegeQueryStudentInfoByDeptResponse CollegeQueryStudentInfoByDeptResponse
     */
    public function collegeQueryStudentInfoByDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeQueryStudentInfoByDeptHeaders([]);

        return $this->collegeQueryStudentInfoByDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据手机号查询学生信息
     *  *
     * @param CollegeQueryStudentInfoByMobileRequest $request CollegeQueryStudentInfoByMobileRequest
     * @param CollegeQueryStudentInfoByMobileHeaders $headers CollegeQueryStudentInfoByMobileHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeQueryStudentInfoByMobileResponse CollegeQueryStudentInfoByMobileResponse
     */
    public function collegeQueryStudentInfoByMobileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->mobile)) {
            $query['mobile'] = $request->mobile;
        }
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
            'action'      => 'CollegeQueryStudentInfoByMobile',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/members/students/mobiles',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeQueryStudentInfoByMobileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据手机号查询学生信息
     *  *
     * @param CollegeQueryStudentInfoByMobileRequest $request CollegeQueryStudentInfoByMobileRequest
     *
     * @return CollegeQueryStudentInfoByMobileResponse CollegeQueryStudentInfoByMobileResponse
     */
    public function collegeQueryStudentInfoByMobile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeQueryStudentInfoByMobileHeaders([]);

        return $this->collegeQueryStudentInfoByMobileWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据studentId查询学生信息
     *  *
     * @param CollegeQueryStudentInfoByStudentIdRequest $request CollegeQueryStudentInfoByStudentIdRequest
     * @param CollegeQueryStudentInfoByStudentIdHeaders $headers CollegeQueryStudentInfoByStudentIdHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeQueryStudentInfoByStudentIdResponse CollegeQueryStudentInfoByStudentIdResponse
     */
    public function collegeQueryStudentInfoByStudentIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->studentId)) {
            $query['studentId'] = $request->studentId;
        }
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
            'action'      => 'CollegeQueryStudentInfoByStudentId',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/members/students',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeQueryStudentInfoByStudentIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据studentId查询学生信息
     *  *
     * @param CollegeQueryStudentInfoByStudentIdRequest $request CollegeQueryStudentInfoByStudentIdRequest
     *
     * @return CollegeQueryStudentInfoByStudentIdResponse CollegeQueryStudentInfoByStudentIdResponse
     */
    public function collegeQueryStudentInfoByStudentId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeQueryStudentInfoByStudentIdHeaders([]);

        return $this->collegeQueryStudentInfoByStudentIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 从部门中移除负责人
     *  *
     * @param CollegeRemoveManagerRequest $request CollegeRemoveManagerRequest
     * @param CollegeRemoveManagerHeaders $headers CollegeRemoveManagerHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeRemoveManagerResponse CollegeRemoveManagerResponse
     */
    public function collegeRemoveManagerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->isForce)) {
            $query['isForce'] = $request->isForce;
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
            'action'      => 'CollegeRemoveManager',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/members/managers',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeRemoveManagerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 从部门中移除负责人
     *  *
     * @param CollegeRemoveManagerRequest $request CollegeRemoveManagerRequest
     *
     * @return CollegeRemoveManagerResponse CollegeRemoveManagerResponse
     */
    public function collegeRemoveManager($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeRemoveManagerHeaders([]);

        return $this->collegeRemoveManagerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 从部门中移除学生
     *  *
     * @param CollegeRemoveStudentRequest $request CollegeRemoveStudentRequest
     * @param CollegeRemoveStudentHeaders $headers CollegeRemoveStudentHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeRemoveStudentResponse CollegeRemoveStudentResponse
     */
    public function collegeRemoveStudentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->studentId)) {
            $query['studentId'] = $request->studentId;
        }
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
            'action'      => 'CollegeRemoveStudent',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/members/depts/students',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeRemoveStudentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 从部门中移除学生
     *  *
     * @param CollegeRemoveStudentRequest $request CollegeRemoveStudentRequest
     *
     * @return CollegeRemoveStudentResponse CollegeRemoveStudentResponse
     */
    public function collegeRemoveStudent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeRemoveStudentHeaders([]);

        return $this->collegeRemoveStudentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑学段/学院/年级/专业\系/班级
     *  *
     * @param CollegeUpdateCollegeDeptRequest $request CollegeUpdateCollegeDeptRequest
     * @param CollegeUpdateCollegeDeptHeaders $headers CollegeUpdateCollegeDeptHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeUpdateCollegeDeptResponse CollegeUpdateCollegeDeptResponse
     */
    public function collegeUpdateCollegeDeptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->deptName)) {
            $query['deptName'] = $request->deptName;
        }
        if (!Utils::isUnset($request->sortFactor)) {
            $query['sortFactor'] = $request->sortFactor;
        }
        if (!Utils::isUnset($request->superId)) {
            $query['superId'] = $request->superId;
        }
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
            'action'      => 'CollegeUpdateCollegeDept',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/depts',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeUpdateCollegeDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑学段/学院/年级/专业\系/班级
     *  *
     * @param CollegeUpdateCollegeDeptRequest $request CollegeUpdateCollegeDeptRequest
     *
     * @return CollegeUpdateCollegeDeptResponse CollegeUpdateCollegeDeptResponse
     */
    public function collegeUpdateCollegeDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeUpdateCollegeDeptHeaders([]);

        return $this->collegeUpdateCollegeDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新学生的部门相关信息
     *  *
     * @param CollegeUpdateStudentDeptInfoRequest $request CollegeUpdateStudentDeptInfoRequest
     * @param CollegeUpdateStudentDeptInfoHeaders $headers CollegeUpdateStudentDeptInfoHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeUpdateStudentDeptInfoResponse CollegeUpdateStudentDeptInfoResponse
     */
    public function collegeUpdateStudentDeptInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->studentId)) {
            $query['studentId'] = $request->studentId;
        }
        if (!Utils::isUnset($request->studentNumber)) {
            $query['studentNumber'] = $request->studentNumber;
        }
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
            'action'      => 'CollegeUpdateStudentDeptInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/members/deptInfos',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeUpdateStudentDeptInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新学生的部门相关信息
     *  *
     * @param CollegeUpdateStudentDeptInfoRequest $request CollegeUpdateStudentDeptInfoRequest
     *
     * @return CollegeUpdateStudentDeptInfoResponse CollegeUpdateStudentDeptInfoResponse
     */
    public function collegeUpdateStudentDeptInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeUpdateStudentDeptInfoHeaders([]);

        return $this->collegeUpdateStudentDeptInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新班级下学生信息
     *  *
     * @param CollegeUpdateStudentInfoRequest $request CollegeUpdateStudentInfoRequest
     * @param CollegeUpdateStudentInfoHeaders $headers CollegeUpdateStudentInfoHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeUpdateStudentInfoResponse CollegeUpdateStudentInfoResponse
     */
    public function collegeUpdateStudentInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->empExtension)) {
            $body['empExtension'] = $request->empExtension;
        }
        if (!Utils::isUnset($request->gender)) {
            $body['gender'] = $request->gender;
        }
        if (!Utils::isUnset($request->identifyId)) {
            $body['identifyId'] = $request->identifyId;
        }
        if (!Utils::isUnset($request->startYear)) {
            $body['startYear'] = $request->startYear;
        }
        if (!Utils::isUnset($request->studentId)) {
            $body['studentId'] = $request->studentId;
        }
        if (!Utils::isUnset($request->studentName)) {
            $body['studentName'] = $request->studentName;
        }
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
            'action'      => 'CollegeUpdateStudentInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/members/depts/students',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeUpdateStudentInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新班级下学生信息
     *  *
     * @param CollegeUpdateStudentInfoRequest $request CollegeUpdateStudentInfoRequest
     *
     * @return CollegeUpdateStudentInfoResponse CollegeUpdateStudentInfoResponse
     */
    public function collegeUpdateStudentInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeUpdateStudentInfoHeaders([]);

        return $this->collegeUpdateStudentInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改学生手机号
     *  *
     * @param CollegeUpdateStudentMoblieRequest $request CollegeUpdateStudentMoblieRequest
     * @param CollegeUpdateStudentMoblieHeaders $headers CollegeUpdateStudentMoblieHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return CollegeUpdateStudentMoblieResponse CollegeUpdateStudentMoblieResponse
     */
    public function collegeUpdateStudentMoblieWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->isForce)) {
            $query['isForce'] = $request->isForce;
        }
        if (!Utils::isUnset($request->newMobile)) {
            $query['newMobile'] = $request->newMobile;
        }
        if (!Utils::isUnset($request->studentId)) {
            $query['studentId'] = $request->studentId;
        }
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
            'action'      => 'CollegeUpdateStudentMoblie',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/colleges/members/students/mobiles',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CollegeUpdateStudentMoblieResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改学生手机号
     *  *
     * @param CollegeUpdateStudentMoblieRequest $request CollegeUpdateStudentMoblieRequest
     *
     * @return CollegeUpdateStudentMoblieResponse CollegeUpdateStudentMoblieResponse
     */
    public function collegeUpdateStudentMoblie($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeUpdateStudentMoblieHeaders([]);

        return $this->collegeUpdateStudentMoblieWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建自定义通讯录
     *  *
     * @param CustomizeContactCreateRequest $request CustomizeContactCreateRequest
     * @param CustomizeContactCreateHeaders $headers CustomizeContactCreateHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CustomizeContactCreateResponse CustomizeContactCreateResponse
     */
    public function customizeContactCreateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->managerIdList)) {
            $body['managerIdList'] = $request->managerIdList;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->order)) {
            $body['order'] = $request->order;
        }
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
            'action'      => 'CustomizeContactCreate',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/customizations/contacts',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CustomizeContactCreateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建自定义通讯录
     *  *
     * @param CustomizeContactCreateRequest $request CustomizeContactCreateRequest
     *
     * @return CustomizeContactCreateResponse CustomizeContactCreateResponse
     */
    public function customizeContactCreate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactCreateHeaders([]);

        return $this->customizeContactCreateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除自定义通讯录
     *  *
     * @param CustomizeContactDeleteRequest $request CustomizeContactDeleteRequest
     * @param CustomizeContactDeleteHeaders $headers CustomizeContactDeleteHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CustomizeContactDeleteResponse CustomizeContactDeleteResponse
     */
    public function customizeContactDeleteWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
        }
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
            'action'      => 'CustomizeContactDelete',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/customizations/contacts',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CustomizeContactDeleteResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除自定义通讯录
     *  *
     * @param CustomizeContactDeleteRequest $request CustomizeContactDeleteRequest
     *
     * @return CustomizeContactDeleteResponse CustomizeContactDeleteResponse
     */
    public function customizeContactDelete($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeleteHeaders([]);

        return $this->customizeContactDeleteWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建部门
     *  *
     * @param CustomizeContactDeptCreateRequest $request CustomizeContactDeptCreateRequest
     * @param CustomizeContactDeptCreateHeaders $headers CustomizeContactDeptCreateHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return CustomizeContactDeptCreateResponse CustomizeContactDeptCreateResponse
     */
    public function customizeContactDeptCreateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->code)) {
            $body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->managerIdList)) {
            $body['managerIdList'] = $request->managerIdList;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->order)) {
            $body['order'] = $request->order;
        }
        if (!Utils::isUnset($request->parentDeptId)) {
            $body['parentDeptId'] = $request->parentDeptId;
        }
        if (!Utils::isUnset($request->refId)) {
            $body['refId'] = $request->refId;
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
            'action'      => 'CustomizeContactDeptCreate',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/customizations/departments',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CustomizeContactDeptCreateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建部门
     *  *
     * @param CustomizeContactDeptCreateRequest $request CustomizeContactDeptCreateRequest
     *
     * @return CustomizeContactDeptCreateResponse CustomizeContactDeptCreateResponse
     */
    public function customizeContactDeptCreate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptCreateHeaders([]);

        return $this->customizeContactDeptCreateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除部门
     *  *
     * @param CustomizeContactDeptDeleteRequest $request CustomizeContactDeptDeleteRequest
     * @param CustomizeContactDeptDeleteHeaders $headers CustomizeContactDeptDeleteHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return CustomizeContactDeptDeleteResponse CustomizeContactDeptDeleteResponse
     */
    public function customizeContactDeptDeleteWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
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
            'action'      => 'CustomizeContactDeptDelete',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/customizations/departments',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CustomizeContactDeptDeleteResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除部门
     *  *
     * @param CustomizeContactDeptDeleteRequest $request CustomizeContactDeptDeleteRequest
     *
     * @return CustomizeContactDeptDeleteResponse CustomizeContactDeptDeleteResponse
     */
    public function customizeContactDeptDelete($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptDeleteHeaders([]);

        return $this->customizeContactDeptDeleteWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建自定义通讯录某个部门的部门群
     *  *
     * @param CustomizeContactDeptGroupCreateRequest $request CustomizeContactDeptGroupCreateRequest
     * @param CustomizeContactDeptGroupCreateHeaders $headers CustomizeContactDeptGroupCreateHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return CustomizeContactDeptGroupCreateResponse CustomizeContactDeptGroupCreateResponse
     */
    public function customizeContactDeptGroupCreateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->code)) {
            $body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
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
            'action'      => 'CustomizeContactDeptGroupCreate',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/customizations/departmentGroups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CustomizeContactDeptGroupCreateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建自定义通讯录某个部门的部门群
     *  *
     * @param CustomizeContactDeptGroupCreateRequest $request CustomizeContactDeptGroupCreateRequest
     *
     * @return CustomizeContactDeptGroupCreateResponse CustomizeContactDeptGroupCreateResponse
     */
    public function customizeContactDeptGroupCreate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptGroupCreateHeaders([]);

        return $this->customizeContactDeptGroupCreateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取部门详情
     *  *
     * @param CustomizeContactDeptInfoRequest $request CustomizeContactDeptInfoRequest
     * @param CustomizeContactDeptInfoHeaders $headers CustomizeContactDeptInfoHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return CustomizeContactDeptInfoResponse CustomizeContactDeptInfoResponse
     */
    public function customizeContactDeptInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
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
            'action'      => 'CustomizeContactDeptInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/customizations/departments',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CustomizeContactDeptInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取部门详情
     *  *
     * @param CustomizeContactDeptInfoRequest $request CustomizeContactDeptInfoRequest
     *
     * @return CustomizeContactDeptInfoResponse CustomizeContactDeptInfoResponse
     */
    public function customizeContactDeptInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptInfoHeaders([]);

        return $this->customizeContactDeptInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取子部门列表
     *  *
     * @param CustomizeContactDeptListRequest $request CustomizeContactDeptListRequest
     * @param CustomizeContactDeptListHeaders $headers CustomizeContactDeptListHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return CustomizeContactDeptListResponse CustomizeContactDeptListResponse
     */
    public function customizeContactDeptListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
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
            'action'      => 'CustomizeContactDeptList',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/customizations/subsidiaryDepartments',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CustomizeContactDeptListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取子部门列表
     *  *
     * @param CustomizeContactDeptListRequest $request CustomizeContactDeptListRequest
     *
     * @return CustomizeContactDeptListResponse CustomizeContactDeptListResponse
     */
    public function customizeContactDeptList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptListHeaders([]);

        return $this->customizeContactDeptListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新部门
     *  *
     * @param CustomizeContactDeptUpdateRequest $request CustomizeContactDeptUpdateRequest
     * @param CustomizeContactDeptUpdateHeaders $headers CustomizeContactDeptUpdateHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return CustomizeContactDeptUpdateResponse CustomizeContactDeptUpdateResponse
     */
    public function customizeContactDeptUpdateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->code)) {
            $body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->managerIdList)) {
            $body['managerIdList'] = $request->managerIdList;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->order)) {
            $body['order'] = $request->order;
        }
        if (!Utils::isUnset($request->parentDeptId)) {
            $body['parentDeptId'] = $request->parentDeptId;
        }
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
            'action'      => 'CustomizeContactDeptUpdate',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/customizations/departments',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CustomizeContactDeptUpdateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新部门
     *  *
     * @param CustomizeContactDeptUpdateRequest $request CustomizeContactDeptUpdateRequest
     *
     * @return CustomizeContactDeptUpdateResponse CustomizeContactDeptUpdateResponse
     */
    public function customizeContactDeptUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptUpdateHeaders([]);

        return $this->customizeContactDeptUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 普通部门下添加人员
     *  *
     * @param CustomizeContactEmpAddRequest $request CustomizeContactEmpAddRequest
     * @param CustomizeContactEmpAddHeaders $headers CustomizeContactEmpAddHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CustomizeContactEmpAddResponse CustomizeContactEmpAddResponse
     */
    public function customizeContactEmpAddWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->code)) {
            $body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
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
            'action'      => 'CustomizeContactEmpAdd',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/customizations/users',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CustomizeContactEmpAddResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 普通部门下添加人员
     *  *
     * @param CustomizeContactEmpAddRequest $request CustomizeContactEmpAddRequest
     *
     * @return CustomizeContactEmpAddResponse CustomizeContactEmpAddResponse
     */
    public function customizeContactEmpAdd($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactEmpAddHeaders([]);

        return $this->customizeContactEmpAddWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 普通部门下移除人员
     *  *
     * @param CustomizeContactEmpDeleteRequest $request CustomizeContactEmpDeleteRequest
     * @param CustomizeContactEmpDeleteHeaders $headers CustomizeContactEmpDeleteHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return CustomizeContactEmpDeleteResponse CustomizeContactEmpDeleteResponse
     */
    public function customizeContactEmpDeleteWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->code)) {
            $body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
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
            'action'      => 'CustomizeContactEmpDelete',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/customizations/users/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CustomizeContactEmpDeleteResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 普通部门下移除人员
     *  *
     * @param CustomizeContactEmpDeleteRequest $request CustomizeContactEmpDeleteRequest
     *
     * @return CustomizeContactEmpDeleteResponse CustomizeContactEmpDeleteResponse
     */
    public function customizeContactEmpDelete($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactEmpDeleteHeaders([]);

        return $this->customizeContactEmpDeleteWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询部门下人员
     *  *
     * @param CustomizeContactEmpListRequest $request CustomizeContactEmpListRequest
     * @param CustomizeContactEmpListHeaders $headers CustomizeContactEmpListHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CustomizeContactEmpListResponse CustomizeContactEmpListResponse
     */
    public function customizeContactEmpListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
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
            'action'      => 'CustomizeContactEmpList',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/customizations/users',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CustomizeContactEmpListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询部门下人员
     *  *
     * @param CustomizeContactEmpListRequest $request CustomizeContactEmpListRequest
     *
     * @return CustomizeContactEmpListResponse CustomizeContactEmpListResponse
     */
    public function customizeContactEmpList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactEmpListHeaders([]);

        return $this->customizeContactEmpListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取自定义通讯录列表
     *  *
     * @param CustomizeContactListHeaders $headers CustomizeContactListHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return CustomizeContactListResponse CustomizeContactListResponse
     */
    public function customizeContactListWithOptions($headers, $runtime)
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
            'action'      => 'CustomizeContactList',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/customizations/contacts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CustomizeContactListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取自定义通讯录列表
     *  *
     * @return CustomizeContactListResponse CustomizeContactListResponse
     */
    public function customizeContactList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactListHeaders([]);

        return $this->customizeContactListWithOptions($headers, $runtime);
    }

    /**
     * @summary 更新自定义通讯录
     *  *
     * @param CustomizeContactUpdateRequest $request CustomizeContactUpdateRequest
     * @param CustomizeContactUpdateHeaders $headers CustomizeContactUpdateHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CustomizeContactUpdateResponse CustomizeContactUpdateResponse
     */
    public function customizeContactUpdateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->code)) {
            $body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->managerIdList)) {
            $body['managerIdList'] = $request->managerIdList;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->order)) {
            $body['order'] = $request->order;
        }
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
            'action'      => 'CustomizeContactUpdate',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/customizations/contacts',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CustomizeContactUpdateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新自定义通讯录
     *  *
     * @param CustomizeContactUpdateRequest $request CustomizeContactUpdateRequest
     *
     * @return CustomizeContactUpdateResponse CustomizeContactUpdateResponse
     */
    public function customizeContactUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactUpdateHeaders([]);

        return $this->customizeContactUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 门店通业务消息推送
     *  *
     * @param DIgitalStoreMessagePushRequest $tmpReq  DIgitalStoreMessagePushRequest
     * @param DIgitalStoreMessagePushHeaders $headers DIgitalStoreMessagePushHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return DIgitalStoreMessagePushResponse DIgitalStoreMessagePushResponse
     */
    public function dIgitalStoreMessagePushWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new DIgitalStoreMessagePushShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->messageDataList)) {
            $request->messageDataListShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->messageDataList, 'messageDataList', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->messageDataListShrink)) {
            $query['messageDataList'] = $request->messageDataListShrink;
        }
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
            'action'      => 'DIgitalStoreMessagePush',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/messages/push',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DIgitalStoreMessagePushResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 门店通业务消息推送
     *  *
     * @param DIgitalStoreMessagePushRequest $request DIgitalStoreMessagePushRequest
     *
     * @return DIgitalStoreMessagePushResponse DIgitalStoreMessagePushResponse
     */
    public function dIgitalStoreMessagePush($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DIgitalStoreMessagePushHeaders([]);

        return $this->dIgitalStoreMessagePushWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 群运营-场景卡片发送记录列表
     *  *
     * @param DigitalStoreCardRecordRequest $request DigitalStoreCardRecordRequest
     * @param DigitalStoreCardRecordHeaders $headers DigitalStoreCardRecordHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStoreCardRecordResponse DigitalStoreCardRecordResponse
     */
    public function digitalStoreCardRecordWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->beginTime)) {
            $body['beginTime'] = $request->beginTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->ids)) {
            $body['ids'] = $request->ids;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->sceneCardName)) {
            $body['sceneCardName'] = $request->sceneCardName;
        }
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
            'action'      => 'DigitalStoreCardRecord',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/cardSendRecords/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStoreCardRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 群运营-场景卡片发送记录列表
     *  *
     * @param DigitalStoreCardRecordRequest $request DigitalStoreCardRecordRequest
     *
     * @return DigitalStoreCardRecordResponse DigitalStoreCardRecordResponse
     */
    public function digitalStoreCardRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreCardRecordHeaders([]);

        return $this->digitalStoreCardRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询组织中门店通通讯录基础信息
     *  *
     * @param DigitalStoreContactInfoHeaders $headers DigitalStoreContactInfoHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStoreContactInfoResponse DigitalStoreContactInfoResponse
     */
    public function digitalStoreContactInfoWithOptions($headers, $runtime)
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
            'action'      => 'DigitalStoreContactInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/contactInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStoreContactInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询组织中门店通通讯录基础信息
     *  *
     * @return DigitalStoreContactInfoResponse DigitalStoreContactInfoResponse
     */
    public function digitalStoreContactInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreContactInfoHeaders([]);

        return $this->digitalStoreContactInfoWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取门店通相关会话列表（区域群、门店群）
     *  *
     * @param DigitalStoreConversationsRequest $request DigitalStoreConversationsRequest
     * @param DigitalStoreConversationsHeaders $headers DigitalStoreConversationsHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStoreConversationsResponse DigitalStoreConversationsResponse
     */
    public function digitalStoreConversationsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->conversationTitle)) {
            $query['conversationTitle'] = $request->conversationTitle;
        }
        if (!Utils::isUnset($request->conversationType)) {
            $query['conversationType'] = $request->conversationType;
        }
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
            'action'      => 'DigitalStoreConversations',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/conversations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStoreConversationsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取门店通相关会话列表（区域群、门店群）
     *  *
     * @param DigitalStoreConversationsRequest $request DigitalStoreConversationsRequest
     *
     * @return DigitalStoreConversationsResponse DigitalStoreConversationsResponse
     */
    public function digitalStoreConversations($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreConversationsHeaders([]);

        return $this->digitalStoreConversationsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 群运营-数据监控-导出列表
     *  *
     * @param DigitalStoreExportCardRecordRequest $request DigitalStoreExportCardRecordRequest
     * @param DigitalStoreExportCardRecordHeaders $headers DigitalStoreExportCardRecordHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStoreExportCardRecordResponse DigitalStoreExportCardRecordResponse
     */
    public function digitalStoreExportCardRecordWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->beginTime)) {
            $body['beginTime'] = $request->beginTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->ids)) {
            $body['ids'] = $request->ids;
        }
        if (!Utils::isUnset($request->sceneCardName)) {
            $body['sceneCardName'] = $request->sceneCardName;
        }
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
            'action'      => 'DigitalStoreExportCardRecord',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/cardRecords/export',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStoreExportCardRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 群运营-数据监控-导出列表
     *  *
     * @param DigitalStoreExportCardRecordRequest $request DigitalStoreExportCardRecordRequest
     *
     * @return DigitalStoreExportCardRecordResponse DigitalStoreExportCardRecordResponse
     */
    public function digitalStoreExportCardRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreExportCardRecordHeaders([]);

        return $this->digitalStoreExportCardRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 群运营-数据监控-导出明细
     *  *
     * @param DigitalStoreExportCardRecordDetailRequest $request DigitalStoreExportCardRecordDetailRequest
     * @param DigitalStoreExportCardRecordDetailHeaders $headers DigitalStoreExportCardRecordDetailHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStoreExportCardRecordDetailResponse DigitalStoreExportCardRecordDetailResponse
     */
    public function digitalStoreExportCardRecordDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->beginTime)) {
            $body['beginTime'] = $request->beginTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->ids)) {
            $body['ids'] = $request->ids;
        }
        if (!Utils::isUnset($request->sceneCardName)) {
            $body['sceneCardName'] = $request->sceneCardName;
        }
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
            'action'      => 'DigitalStoreExportCardRecordDetail',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/cardRecordDetails/export',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStoreExportCardRecordDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 群运营-数据监控-导出明细
     *  *
     * @param DigitalStoreExportCardRecordDetailRequest $request DigitalStoreExportCardRecordDetailRequest
     *
     * @return DigitalStoreExportCardRecordDetailResponse DigitalStoreExportCardRecordDetailResponse
     */
    public function digitalStoreExportCardRecordDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreExportCardRecordDetailHeaders([]);

        return $this->digitalStoreExportCardRecordDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询门店通中的门店分组详情
     *  *
     * @param DigitalStoreGroupInfoRequest $request DigitalStoreGroupInfoRequest
     * @param DigitalStoreGroupInfoHeaders $headers DigitalStoreGroupInfoHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStoreGroupInfoResponse DigitalStoreGroupInfoResponse
     */
    public function digitalStoreGroupInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->groupId)) {
            $query['groupId'] = $request->groupId;
        }
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
            'action'      => 'DigitalStoreGroupInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/groupInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStoreGroupInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询门店通中的门店分组详情
     *  *
     * @param DigitalStoreGroupInfoRequest $request DigitalStoreGroupInfoRequest
     *
     * @return DigitalStoreGroupInfoResponse DigitalStoreGroupInfoResponse
     */
    public function digitalStoreGroupInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreGroupInfoHeaders([]);

        return $this->digitalStoreGroupInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询门店通中的分组列表
     *  *
     * @param DigitalStoreGroupsHeaders $headers DigitalStoreGroupsHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStoreGroupsResponse DigitalStoreGroupsResponse
     */
    public function digitalStoreGroupsWithOptions($headers, $runtime)
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
            'action'      => 'DigitalStoreGroups',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/groups',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStoreGroupsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询门店通中的分组列表
     *  *
     * @return DigitalStoreGroupsResponse DigitalStoreGroupsResponse
     */
    public function digitalStoreGroups()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreGroupsHeaders([]);

        return $this->digitalStoreGroupsWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询门店通讯录某个节点信息
     *  *
     * @param DigitalStoreNodeInfoRequest $request DigitalStoreNodeInfoRequest
     * @param DigitalStoreNodeInfoHeaders $headers DigitalStoreNodeInfoHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStoreNodeInfoResponse DigitalStoreNodeInfoResponse
     */
    public function digitalStoreNodeInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->nodeId)) {
            $query['nodeId'] = $request->nodeId;
        }
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
            'action'      => 'DigitalStoreNodeInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/nodeInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStoreNodeInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询门店通讯录某个节点信息
     *  *
     * @param DigitalStoreNodeInfoRequest $request DigitalStoreNodeInfoRequest
     *
     * @return DigitalStoreNodeInfoResponse DigitalStoreNodeInfoResponse
     */
    public function digitalStoreNodeInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreNodeInfoHeaders([]);

        return $this->digitalStoreNodeInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 门店通权益信息查询
     *  *
     * @param DigitalStoreRightsInfoHeaders $headers DigitalStoreRightsInfoHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStoreRightsInfoResponse DigitalStoreRightsInfoResponse
     */
    public function digitalStoreRightsInfoWithOptions($headers, $runtime)
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
            'action'      => 'DigitalStoreRightsInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/rightsInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStoreRightsInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 门店通权益信息查询
     *  *
     * @return DigitalStoreRightsInfoResponse DigitalStoreRightsInfoResponse
     */
    public function digitalStoreRightsInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreRightsInfoHeaders([]);

        return $this->digitalStoreRightsInfoWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询门店通中的角色列表
     *  *
     * @param DigitalStoreRolesHeaders $headers DigitalStoreRolesHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStoreRolesResponse DigitalStoreRolesResponse
     */
    public function digitalStoreRolesWithOptions($headers, $runtime)
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
            'action'      => 'DigitalStoreRoles',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/roles',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStoreRolesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询门店通中的角色列表
     *  *
     * @return DigitalStoreRolesResponse DigitalStoreRolesResponse
     */
    public function digitalStoreRoles()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreRolesHeaders([]);

        return $this->digitalStoreRolesWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取门店通场景群的业务范围
     *  *
     * @param DigitalStoreSceneScopeRequest $request DigitalStoreSceneScopeRequest
     * @param DigitalStoreSceneScopeHeaders $headers DigitalStoreSceneScopeHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStoreSceneScopeResponse DigitalStoreSceneScopeResponse
     */
    public function digitalStoreSceneScopeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $query['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->sceneCode)) {
            $query['sceneCode'] = $request->sceneCode;
        }
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
            'action'      => 'DigitalStoreSceneScope',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/sceneScopes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStoreSceneScopeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取门店通场景群的业务范围
     *  *
     * @param DigitalStoreSceneScopeRequest $request DigitalStoreSceneScopeRequest
     *
     * @return DigitalStoreSceneScopeResponse DigitalStoreSceneScopeResponse
     */
    public function digitalStoreSceneScope($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreSceneScopeHeaders([]);

        return $this->digitalStoreSceneScopeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询门店通中的门店详情
     *  *
     * @param DigitalStoreStoreInfoRequest $request DigitalStoreStoreInfoRequest
     * @param DigitalStoreStoreInfoHeaders $headers DigitalStoreStoreInfoHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStoreStoreInfoResponse DigitalStoreStoreInfoResponse
     */
    public function digitalStoreStoreInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->storeId)) {
            $query['storeId'] = $request->storeId;
        }
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
            'action'      => 'DigitalStoreStoreInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/storeInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStoreStoreInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询门店通中的门店详情
     *  *
     * @param DigitalStoreStoreInfoRequest $request DigitalStoreStoreInfoRequest
     *
     * @return DigitalStoreStoreInfoResponse DigitalStoreStoreInfoResponse
     */
    public function digitalStoreStoreInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreStoreInfoHeaders([]);

        return $this->digitalStoreStoreInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询门店通讯录某个节点下的子节点
     *  *
     * @param DigitalStoreSubNodesRequest $request DigitalStoreSubNodesRequest
     * @param DigitalStoreSubNodesHeaders $headers DigitalStoreSubNodesHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStoreSubNodesResponse DigitalStoreSubNodesResponse
     */
    public function digitalStoreSubNodesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->nodeId)) {
            $query['nodeId'] = $request->nodeId;
        }
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
            'action'      => 'DigitalStoreSubNodes',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/subsidiaryNodes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStoreSubNodesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询门店通讯录某个节点下的子节点
     *  *
     * @param DigitalStoreSubNodesRequest $request DigitalStoreSubNodesRequest
     *
     * @return DigitalStoreSubNodesResponse DigitalStoreSubNodesResponse
     */
    public function digitalStoreSubNodes($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreSubNodesHeaders([]);

        return $this->digitalStoreSubNodesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改人员管辖范围以及所属角色
     *  *
     * @param DigitalStoreUpdateAuthInfoRequest $request DigitalStoreUpdateAuthInfoRequest
     * @param DigitalStoreUpdateAuthInfoHeaders $headers DigitalStoreUpdateAuthInfoHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStoreUpdateAuthInfoResponse DigitalStoreUpdateAuthInfoResponse
     */
    public function digitalStoreUpdateAuthInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->updateUserList)) {
            $body['updateUserList'] = $request->updateUserList;
        }
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
            'action'      => 'DigitalStoreUpdateAuthInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/authInfos',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStoreUpdateAuthInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改人员管辖范围以及所属角色
     *  *
     * @param DigitalStoreUpdateAuthInfoRequest $request DigitalStoreUpdateAuthInfoRequest
     *
     * @return DigitalStoreUpdateAuthInfoResponse DigitalStoreUpdateAuthInfoResponse
     */
    public function digitalStoreUpdateAuthInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreUpdateAuthInfoHeaders([]);

        return $this->digitalStoreUpdateAuthInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询门店通讯录人员信息
     *  *
     * @param DigitalStoreUserInfoRequest $request DigitalStoreUserInfoRequest
     * @param DigitalStoreUserInfoHeaders $headers DigitalStoreUserInfoHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStoreUserInfoResponse DigitalStoreUserInfoResponse
     */
    public function digitalStoreUserInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
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
            'action'      => 'DigitalStoreUserInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/userInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStoreUserInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询门店通讯录人员信息
     *  *
     * @param DigitalStoreUserInfoRequest $request DigitalStoreUserInfoRequest
     *
     * @return DigitalStoreUserInfoResponse DigitalStoreUserInfoResponse
     */
    public function digitalStoreUserInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreUserInfoHeaders([]);

        return $this->digitalStoreUserInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询门店通讯录某个节点下的所有人员
     *  *
     * @param DigitalStoreUsersRequest $request DigitalStoreUsersRequest
     * @param DigitalStoreUsersHeaders $headers DigitalStoreUsersHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStoreUsersResponse DigitalStoreUsersResponse
     */
    public function digitalStoreUsersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
        }
        if (!Utils::isUnset($request->nodeId)) {
            $query['nodeId'] = $request->nodeId;
        }
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
            'action'      => 'DigitalStoreUsers',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/nodes/users',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStoreUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询门店通讯录某个节点下的所有人员
     *  *
     * @param DigitalStoreUsersRequest $request DigitalStoreUsersRequest
     *
     * @return DigitalStoreUsersResponse DigitalStoreUsersResponse
     */
    public function digitalStoreUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreUsersHeaders([]);

        return $this->digitalStoreUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 群运营-数据监控-查询导出任务的记录列表
     *  *
     * @param DigitalStorelistExportTaskRecordRequest $request DigitalStorelistExportTaskRecordRequest
     * @param DigitalStorelistExportTaskRecordHeaders $headers DigitalStorelistExportTaskRecordHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return DigitalStorelistExportTaskRecordResponse DigitalStorelistExportTaskRecordResponse
     */
    public function digitalStorelistExportTaskRecordWithOptions($request, $headers, $runtime)
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DigitalStorelistExportTaskRecord',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/digitalStores/exportTaskRecords',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DigitalStorelistExportTaskRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 群运营-数据监控-查询导出任务的记录列表
     *  *
     * @param DigitalStorelistExportTaskRecordRequest $request DigitalStorelistExportTaskRecordRequest
     *
     * @return DigitalStorelistExportTaskRecordResponse DigitalStorelistExportTaskRecordResponse
     */
    public function digitalStorelistExportTaskRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStorelistExportTaskRecordHeaders([]);

        return $this->digitalStorelistExportTaskRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询启用了当前应用的外部协作组织
     *  *
     * @param ExternalQueryExternalAppOrgsRequest $request ExternalQueryExternalAppOrgsRequest
     * @param ExternalQueryExternalAppOrgsHeaders $headers ExternalQueryExternalAppOrgsHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return ExternalQueryExternalAppOrgsResponse ExternalQueryExternalAppOrgsResponse
     */
    public function externalQueryExternalAppOrgsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->externalType)) {
            $query['externalType'] = $request->externalType;
        }
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
            'action'      => 'ExternalQueryExternalAppOrgs',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/externals/apps/organizations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ExternalQueryExternalAppOrgsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询启用了当前应用的外部协作组织
     *  *
     * @param ExternalQueryExternalAppOrgsRequest $request ExternalQueryExternalAppOrgsRequest
     *
     * @return ExternalQueryExternalAppOrgsResponse ExternalQueryExternalAppOrgsResponse
     */
    public function externalQueryExternalAppOrgs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExternalQueryExternalAppOrgsHeaders([]);

        return $this->externalQueryExternalAppOrgsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询归属的主组织
     *  *
     * @param ExternalQueryExternalBelongMainOrgRequest $request ExternalQueryExternalBelongMainOrgRequest
     * @param ExternalQueryExternalBelongMainOrgHeaders $headers ExternalQueryExternalBelongMainOrgHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return ExternalQueryExternalBelongMainOrgResponse ExternalQueryExternalBelongMainOrgResponse
     */
    public function externalQueryExternalBelongMainOrgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->externalType)) {
            $query['externalType'] = $request->externalType;
        }
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
            'action'      => 'ExternalQueryExternalBelongMainOrg',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/externals/attributions/masterOrganizations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ExternalQueryExternalBelongMainOrgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询归属的主组织
     *  *
     * @param ExternalQueryExternalBelongMainOrgRequest $request ExternalQueryExternalBelongMainOrgRequest
     *
     * @return ExternalQueryExternalBelongMainOrgResponse ExternalQueryExternalBelongMainOrgResponse
     */
    public function externalQueryExternalBelongMainOrg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExternalQueryExternalBelongMainOrgHeaders([]);

        return $this->externalQueryExternalBelongMainOrgWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询外部协作组织
     *  *
     * @param ExternalQueryExternalOrgsRequest $request ExternalQueryExternalOrgsRequest
     * @param ExternalQueryExternalOrgsHeaders $headers ExternalQueryExternalOrgsHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return ExternalQueryExternalOrgsResponse ExternalQueryExternalOrgsResponse
     */
    public function externalQueryExternalOrgsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->externalType)) {
            $query['externalType'] = $request->externalType;
        }
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
            'action'      => 'ExternalQueryExternalOrgs',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/externals/organizations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ExternalQueryExternalOrgsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询外部协作组织
     *  *
     * @param ExternalQueryExternalOrgsRequest $request ExternalQueryExternalOrgsRequest
     *
     * @return ExternalQueryExternalOrgsResponse ExternalQueryExternalOrgsResponse
     */
    public function externalQueryExternalOrgs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExternalQueryExternalOrgsHeaders([]);

        return $this->externalQueryExternalOrgsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 医疗数据对账
     *  *
     * @param HospitalDataCheckRequest $request HospitalDataCheckRequest
     * @param HospitalDataCheckHeaders $headers HospitalDataCheckHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return HospitalDataCheckResponse HospitalDataCheckResponse
     */
    public function hospitalDataCheckWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->allDeptCount)) {
            $body['allDeptCount'] = $request->allDeptCount;
        }
        if (!Utils::isUnset($request->allDeptUserCount)) {
            $body['allDeptUserCount'] = $request->allDeptUserCount;
        }
        if (!Utils::isUnset($request->allGroupCount)) {
            $body['allGroupCount'] = $request->allGroupCount;
        }
        if (!Utils::isUnset($request->allGroupUserCount)) {
            $body['allGroupUserCount'] = $request->allGroupUserCount;
        }
        if (!Utils::isUnset($request->deptCount)) {
            $body['deptCount'] = $request->deptCount;
        }
        if (!Utils::isUnset($request->deptUserCount)) {
            $body['deptUserCount'] = $request->deptUserCount;
        }
        if (!Utils::isUnset($request->groupCount)) {
            $body['groupCount'] = $request->groupCount;
        }
        if (!Utils::isUnset($request->groupUserCount)) {
            $body['groupUserCount'] = $request->groupUserCount;
        }
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
            'action'      => 'HospitalDataCheck',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/datas/check',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HospitalDataCheckResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 医疗数据对账
     *  *
     * @param HospitalDataCheckRequest $request HospitalDataCheckRequest
     *
     * @return HospitalDataCheckResponse HospitalDataCheckResponse
     */
    public function hospitalDataCheck($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HospitalDataCheckHeaders([]);

        return $this->hospitalDataCheckWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 行业化制造业事件中心
     *  *
     * @param IndustryManufactureCommonEventRequest $request IndustryManufactureCommonEventRequest
     * @param IndustryManufactureCommonEventHeaders $headers IndustryManufactureCommonEventHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return IndustryManufactureCommonEventResponse IndustryManufactureCommonEventResponse
     */
    public function industryManufactureCommonEventWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->appKey)) {
            $body['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->bizData)) {
            $body['bizData'] = $request->bizData;
        }
        if (!Utils::isUnset($request->eventType)) {
            $body['eventType'] = $request->eventType;
        }
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
            'action'      => 'IndustryManufactureCommonEvent',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/manufacturing/bases/commons/events',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IndustryManufactureCommonEventResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 行业化制造业事件中心
     *  *
     * @param IndustryManufactureCommonEventRequest $request IndustryManufactureCommonEventRequest
     *
     * @return IndustryManufactureCommonEventResponse IndustryManufactureCommonEventResponse
     */
    public function industryManufactureCommonEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureCommonEventHeaders([]);

        return $this->industryManufactureCommonEventWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 物料成本开放服务
     *  *
     * @param IndustryManufactureCostRecordListGetRequest $request IndustryManufactureCostRecordListGetRequest
     * @param IndustryManufactureCostRecordListGetHeaders $headers IndustryManufactureCostRecordListGetHeaders
     * @param RuntimeOptions                              $runtime runtime options for this request RuntimeOptions
     *
     * @return IndustryManufactureCostRecordListGetResponse IndustryManufactureCostRecordListGetResponse
     */
    public function industryManufactureCostRecordListGetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->appIds)) {
            $body['appIds'] = $request->appIds;
        }
        if (!Utils::isUnset($request->appName)) {
            $body['appName'] = $request->appName;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->cursor)) {
            $body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->isvOrgId)) {
            $body['isvOrgId'] = $request->isvOrgId;
        }
        if (!Utils::isUnset($request->materialNo)) {
            $body['materialNo'] = $request->materialNo;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            $body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->orgId)) {
            $body['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->productionTaskNo)) {
            $body['productionTaskNo'] = $request->productionTaskNo;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->suiteKey)) {
            $body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->tokenGrantType)) {
            $body['tokenGrantType'] = $request->tokenGrantType;
        }
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
            'action'      => 'IndustryManufactureCostRecordListGet',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/manufactures/materialCostRecords/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IndustryManufactureCostRecordListGetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 物料成本开放服务
     *  *
     * @param IndustryManufactureCostRecordListGetRequest $request IndustryManufactureCostRecordListGetRequest
     *
     * @return IndustryManufactureCostRecordListGetResponse IndustryManufactureCostRecordListGetResponse
     */
    public function industryManufactureCostRecordListGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureCostRecordListGetHeaders([]);

        return $this->industryManufactureCostRecordListGetWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 费用服务
     *  *
     * @param IndustryManufactureFeeListGetRequest $request IndustryManufactureFeeListGetRequest
     * @param IndustryManufactureFeeListGetHeaders $headers IndustryManufactureFeeListGetHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return IndustryManufactureFeeListGetResponse IndustryManufactureFeeListGetResponse
     */
    public function industryManufactureFeeListGetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->appIds)) {
            $body['appIds'] = $request->appIds;
        }
        if (!Utils::isUnset($request->appName)) {
            $body['appName'] = $request->appName;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->cursor)) {
            $body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->isvOrgId)) {
            $body['isvOrgId'] = $request->isvOrgId;
        }
        if (!Utils::isUnset($request->materialNo)) {
            $body['materialNo'] = $request->materialNo;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            $body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->orgId)) {
            $body['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->productionTaskNo)) {
            $body['productionTaskNo'] = $request->productionTaskNo;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->suiteKey)) {
            $body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->tokenGrantType)) {
            $body['tokenGrantType'] = $request->tokenGrantType;
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
            'action'      => 'IndustryManufactureFeeListGet',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/manufactures/fees/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IndustryManufactureFeeListGetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 费用服务
     *  *
     * @param IndustryManufactureFeeListGetRequest $request IndustryManufactureFeeListGetRequest
     *
     * @return IndustryManufactureFeeListGetResponse IndustryManufactureFeeListGetResponse
     */
    public function industryManufactureFeeListGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureFeeListGetHeaders([]);

        return $this->industryManufactureFeeListGetWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 行业化-制造业工价接口
     *  *
     * @param IndustryManufactureLabourCostRequest $request IndustryManufactureLabourCostRequest
     * @param IndustryManufactureLabourCostHeaders $headers IndustryManufactureLabourCostHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return IndustryManufactureLabourCostResponse IndustryManufactureLabourCostResponse
     */
    public function industryManufactureLabourCostWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->appIds)) {
            $body['appIds'] = $request->appIds;
        }
        if (!Utils::isUnset($request->appName)) {
            $body['appName'] = $request->appName;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->cursor)) {
            $body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->isvOrgId)) {
            $body['isvOrgId'] = $request->isvOrgId;
        }
        if (!Utils::isUnset($request->materialNo)) {
            $body['materialNo'] = $request->materialNo;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            $body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->orgId)) {
            $body['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->processNo)) {
            $body['processNo'] = $request->processNo;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->suiteKey)) {
            $body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->tokenGrantType)) {
            $body['tokenGrantType'] = $request->tokenGrantType;
        }
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
            'action'      => 'IndustryManufactureLabourCost',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/manufactures/labourCosts/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IndustryManufactureLabourCostResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 行业化-制造业工价接口
     *  *
     * @param IndustryManufactureLabourCostRequest $request IndustryManufactureLabourCostRequest
     *
     * @return IndustryManufactureLabourCostResponse IndustryManufactureLabourCostResponse
     */
    public function industryManufactureLabourCost($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureLabourCostHeaders([]);

        return $this->industryManufactureLabourCostWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询行业物料列表
     *  *
     * @param IndustryManufactureMaterialListRequest $request IndustryManufactureMaterialListRequest
     * @param IndustryManufactureMaterialListHeaders $headers IndustryManufactureMaterialListHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return IndustryManufactureMaterialListResponse IndustryManufactureMaterialListResponse
     */
    public function industryManufactureMaterialListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->appIds)) {
            $body['appIds'] = $request->appIds;
        }
        if (!Utils::isUnset($request->appName)) {
            $body['appName'] = $request->appName;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->currentPage)) {
            $body['currentPage'] = $request->currentPage;
        }
        if (!Utils::isUnset($request->cursor)) {
            $body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->isvOrgId)) {
            $body['isvOrgId'] = $request->isvOrgId;
        }
        if (!Utils::isUnset($request->materialNo)) {
            $body['materialNo'] = $request->materialNo;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            $body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->orgId)) {
            $body['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->suiteKey)) {
            $body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->tokenGrantType)) {
            $body['tokenGrantType'] = $request->tokenGrantType;
        }
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
            'action'      => 'IndustryManufactureMaterialList',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/manufactures/materials/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IndustryManufactureMaterialListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询行业物料列表
     *  *
     * @param IndustryManufactureMaterialListRequest $request IndustryManufactureMaterialListRequest
     *
     * @return IndustryManufactureMaterialListResponse IndustryManufactureMaterialListResponse
     */
    public function industryManufactureMaterialList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMaterialListHeaders([]);

        return $this->industryManufactureMaterialListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 派工任务管理
     *  *
     * @param IndustryManufactureMesDispatchTaskRequest $request IndustryManufactureMesDispatchTaskRequest
     * @param IndustryManufactureMesDispatchTaskHeaders $headers IndustryManufactureMesDispatchTaskHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return IndustryManufactureMesDispatchTaskResponse IndustryManufactureMesDispatchTaskResponse
     */
    public function industryManufactureMesDispatchTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->appKey)) {
            $body['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->baseDataName)) {
            $body['baseDataName'] = $request->baseDataName;
        }
        if (!Utils::isUnset($request->defectsAmount)) {
            $body['defectsAmount'] = $request->defectsAmount;
        }
        if (!Utils::isUnset($request->dispatchStaffName)) {
            $body['dispatchStaffName'] = $request->dispatchStaffName;
        }
        if (!Utils::isUnset($request->dispatchStaffNo)) {
            $body['dispatchStaffNo'] = $request->dispatchStaffNo;
        }
        if (!Utils::isUnset($request->fineAmount)) {
            $body['fineAmount'] = $request->fineAmount;
        }
        if (!Utils::isUnset($request->overdue)) {
            $body['overdue'] = $request->overdue;
        }
        if (!Utils::isUnset($request->planQuantity)) {
            $body['planQuantity'] = $request->planQuantity;
        }
        if (!Utils::isUnset($request->priority)) {
            $body['priority'] = $request->priority;
        }
        if (!Utils::isUnset($request->processName)) {
            $body['processName'] = $request->processName;
        }
        if (!Utils::isUnset($request->processUuid)) {
            $body['processUuid'] = $request->processUuid;
        }
        if (!Utils::isUnset($request->productCode)) {
            $body['productCode'] = $request->productCode;
        }
        if (!Utils::isUnset($request->productName)) {
            $body['productName'] = $request->productName;
        }
        if (!Utils::isUnset($request->productSpecification)) {
            $body['productSpecification'] = $request->productSpecification;
        }
        if (!Utils::isUnset($request->projectCode)) {
            $body['projectCode'] = $request->projectCode;
        }
        if (!Utils::isUnset($request->projectId)) {
            $body['projectId'] = $request->projectId;
        }
        if (!Utils::isUnset($request->projectStatus)) {
            $body['projectStatus'] = $request->projectStatus;
        }
        if (!Utils::isUnset($request->taskOperators)) {
            $body['taskOperators'] = $request->taskOperators;
        }
        if (!Utils::isUnset($request->taskPlanEndTime)) {
            $body['taskPlanEndTime'] = $request->taskPlanEndTime;
        }
        if (!Utils::isUnset($request->taskPlanStartTime)) {
            $body['taskPlanStartTime'] = $request->taskPlanStartTime;
        }
        if (!Utils::isUnset($request->taskStatus)) {
            $body['taskStatus'] = $request->taskStatus;
        }
        if (!Utils::isUnset($request->taskType)) {
            $body['taskType'] = $request->taskType;
        }
        if (!Utils::isUnset($request->teamId)) {
            $body['teamId'] = $request->teamId;
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
            'action'      => 'IndustryManufactureMesDispatchTask',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/manufacturings/dispatchTasks/manage',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IndustryManufactureMesDispatchTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 派工任务管理
     *  *
     * @param IndustryManufactureMesDispatchTaskRequest $request IndustryManufactureMesDispatchTaskRequest
     *
     * @return IndustryManufactureMesDispatchTaskResponse IndustryManufactureMesDispatchTaskResponse
     */
    public function industryManufactureMesDispatchTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesDispatchTaskHeaders([]);

        return $this->industryManufactureMesDispatchTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary MES系统物料管理
     *  *
     * @param IndustryManufactureMesMaterialRequest $request IndustryManufactureMesMaterialRequest
     * @param IndustryManufactureMesMaterialHeaders $headers IndustryManufactureMesMaterialHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return IndustryManufactureMesMaterialResponse IndustryManufactureMesMaterialResponse
     */
    public function industryManufactureMesMaterialWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->appKey)) {
            $body['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->baseDataName)) {
            $body['baseDataName'] = $request->baseDataName;
        }
        if (!Utils::isUnset($request->category)) {
            $body['category'] = $request->category;
        }
        if (!Utils::isUnset($request->extendData)) {
            $body['extendData'] = $request->extendData;
        }
        if (!Utils::isUnset($request->productCode)) {
            $body['productCode'] = $request->productCode;
        }
        if (!Utils::isUnset($request->productName)) {
            $body['productName'] = $request->productName;
        }
        if (!Utils::isUnset($request->productSpecification)) {
            $body['productSpecification'] = $request->productSpecification;
        }
        if (!Utils::isUnset($request->prop)) {
            $body['prop'] = $request->prop;
        }
        if (!Utils::isUnset($request->unit)) {
            $body['unit'] = $request->unit;
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
            'action'      => 'IndustryManufactureMesMaterial',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/manufacturings/materials/manage',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IndustryManufactureMesMaterialResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary MES系统物料管理
     *  *
     * @param IndustryManufactureMesMaterialRequest $request IndustryManufactureMesMaterialRequest
     *
     * @return IndustryManufactureMesMaterialResponse IndustryManufactureMesMaterialResponse
     */
    public function industryManufactureMesMaterial($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesMaterialHeaders([]);

        return $this->industryManufactureMesMaterialWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 生产委外工单管理
     *  *
     * @param IndustryManufactureMesOutPlanRequest $request IndustryManufactureMesOutPlanRequest
     * @param IndustryManufactureMesOutPlanHeaders $headers IndustryManufactureMesOutPlanHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return IndustryManufactureMesOutPlanResponse IndustryManufactureMesOutPlanResponse
     */
    public function industryManufactureMesOutPlanWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->approvalStatus)) {
            $body['approvalStatus'] = $request->approvalStatus;
        }
        if (!Utils::isUnset($request->approver)) {
            $body['approver'] = $request->approver;
        }
        if (!Utils::isUnset($request->baseDataName)) {
            $body['baseDataName'] = $request->baseDataName;
        }
        if (!Utils::isUnset($request->outSourceProjectCode)) {
            $body['outSourceProjectCode'] = $request->outSourceProjectCode;
        }
        if (!Utils::isUnset($request->outSourceTeamId)) {
            $body['outSourceTeamId'] = $request->outSourceTeamId;
        }
        if (!Utils::isUnset($request->price)) {
            $body['price'] = $request->price;
        }
        if (!Utils::isUnset($request->processIdentificationCode)) {
            $body['processIdentificationCode'] = $request->processIdentificationCode;
        }
        if (!Utils::isUnset($request->processUuids)) {
            $body['processUuids'] = $request->processUuids;
        }
        if (!Utils::isUnset($request->productCode)) {
            $body['productCode'] = $request->productCode;
        }
        if (!Utils::isUnset($request->productName)) {
            $body['productName'] = $request->productName;
        }
        if (!Utils::isUnset($request->productSpecification)) {
            $body['productSpecification'] = $request->productSpecification;
        }
        if (!Utils::isUnset($request->projectCode)) {
            $body['projectCode'] = $request->projectCode;
        }
        if (!Utils::isUnset($request->projectId)) {
            $body['projectId'] = $request->projectId;
        }
        if (!Utils::isUnset($request->sendPlanQuantity)) {
            $body['sendPlanQuantity'] = $request->sendPlanQuantity;
        }
        if (!Utils::isUnset($request->supplierCode)) {
            $body['supplierCode'] = $request->supplierCode;
        }
        if (!Utils::isUnset($request->supplierName)) {
            $body['supplierName'] = $request->supplierName;
        }
        if (!Utils::isUnset($request->totalWage)) {
            $body['totalWage'] = $request->totalWage;
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
            'action'      => 'IndustryManufactureMesOutPlan',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/manufacturings/outPlans/manage',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IndustryManufactureMesOutPlanResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 生产委外工单管理
     *  *
     * @param IndustryManufactureMesOutPlanRequest $request IndustryManufactureMesOutPlanRequest
     *
     * @return IndustryManufactureMesOutPlanResponse IndustryManufactureMesOutPlanResponse
     */
    public function industryManufactureMesOutPlan($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesOutPlanHeaders([]);

        return $this->industryManufactureMesOutPlanWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 生产报工管理
     *  *
     * @param IndustryManufactureMesOutputRequest $request IndustryManufactureMesOutputRequest
     * @param IndustryManufactureMesOutputHeaders $headers IndustryManufactureMesOutputHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return IndustryManufactureMesOutputResponse IndustryManufactureMesOutputResponse
     */
    public function industryManufactureMesOutputWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->appKey)) {
            $body['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->approveStatus)) {
            $body['approveStatus'] = $request->approveStatus;
        }
        if (!Utils::isUnset($request->baseDataName)) {
            $body['baseDataName'] = $request->baseDataName;
        }
        if (!Utils::isUnset($request->defectsAmount)) {
            $body['defectsAmount'] = $request->defectsAmount;
        }
        if (!Utils::isUnset($request->defectsReason)) {
            $body['defectsReason'] = $request->defectsReason;
        }
        if (!Utils::isUnset($request->fineAmount)) {
            $body['fineAmount'] = $request->fineAmount;
        }
        if (!Utils::isUnset($request->hasQualityTest)) {
            $body['hasQualityTest'] = $request->hasQualityTest;
        }
        if (!Utils::isUnset($request->overdue)) {
            $body['overdue'] = $request->overdue;
        }
        if (!Utils::isUnset($request->planQuantity)) {
            $body['planQuantity'] = $request->planQuantity;
        }
        if (!Utils::isUnset($request->priority)) {
            $body['priority'] = $request->priority;
        }
        if (!Utils::isUnset($request->processName)) {
            $body['processName'] = $request->processName;
        }
        if (!Utils::isUnset($request->processUuid)) {
            $body['processUuid'] = $request->processUuid;
        }
        if (!Utils::isUnset($request->productCode)) {
            $body['productCode'] = $request->productCode;
        }
        if (!Utils::isUnset($request->productName)) {
            $body['productName'] = $request->productName;
        }
        if (!Utils::isUnset($request->productSpecification)) {
            $body['productSpecification'] = $request->productSpecification;
        }
        if (!Utils::isUnset($request->projectCode)) {
            $body['projectCode'] = $request->projectCode;
        }
        if (!Utils::isUnset($request->projectId)) {
            $body['projectId'] = $request->projectId;
        }
        if (!Utils::isUnset($request->projectStatus)) {
            $body['projectStatus'] = $request->projectStatus;
        }
        if (!Utils::isUnset($request->qualityTestStatus)) {
            $body['qualityTestStatus'] = $request->qualityTestStatus;
        }
        if (!Utils::isUnset($request->taskPlanEndTime)) {
            $body['taskPlanEndTime'] = $request->taskPlanEndTime;
        }
        if (!Utils::isUnset($request->taskPlanStartTime)) {
            $body['taskPlanStartTime'] = $request->taskPlanStartTime;
        }
        if (!Utils::isUnset($request->taskStatus)) {
            $body['taskStatus'] = $request->taskStatus;
        }
        if (!Utils::isUnset($request->taskType)) {
            $body['taskType'] = $request->taskType;
        }
        if (!Utils::isUnset($request->taskUuid)) {
            $body['taskUuid'] = $request->taskUuid;
        }
        if (!Utils::isUnset($request->teamId)) {
            $body['teamId'] = $request->teamId;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->userName)) {
            $body['userName'] = $request->userName;
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
            'action'      => 'IndustryManufactureMesOutput',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/manufacturings/outputs/manage',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IndustryManufactureMesOutputResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 生产报工管理
     *  *
     * @param IndustryManufactureMesOutputRequest $request IndustryManufactureMesOutputRequest
     *
     * @return IndustryManufactureMesOutputResponse IndustryManufactureMesOutputResponse
     */
    public function industryManufactureMesOutput($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesOutputHeaders([]);

        return $this->industryManufactureMesOutputWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary MES系统工序管理
     *  *
     * @param IndustryManufactureMesProcessRequest $request IndustryManufactureMesProcessRequest
     * @param IndustryManufactureMesProcessHeaders $headers IndustryManufactureMesProcessHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return IndustryManufactureMesProcessResponse IndustryManufactureMesProcessResponse
     */
    public function industryManufactureMesProcessWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->appKey)) {
            $body['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->baseDataName)) {
            $body['baseDataName'] = $request->baseDataName;
        }
        if (!Utils::isUnset($request->extendData)) {
            $body['extendData'] = $request->extendData;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->needDispatch)) {
            $body['needDispatch'] = $request->needDispatch;
        }
        if (!Utils::isUnset($request->needQualityTest)) {
            $body['needQualityTest'] = $request->needQualityTest;
        }
        if (!Utils::isUnset($request->no)) {
            $body['no'] = $request->no;
        }
        if (!Utils::isUnset($request->price)) {
            $body['price'] = $request->price;
        }
        if (!Utils::isUnset($request->prop)) {
            $body['prop'] = $request->prop;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->sop)) {
            $body['sop'] = $request->sop;
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
            'action'      => 'IndustryManufactureMesProcess',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/manufacturings/processes/manage',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IndustryManufactureMesProcessResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary MES系统工序管理
     *  *
     * @param IndustryManufactureMesProcessRequest $request IndustryManufactureMesProcessRequest
     *
     * @return IndustryManufactureMesProcessResponse IndustryManufactureMesProcessResponse
     */
    public function industryManufactureMesProcess($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesProcessHeaders([]);

        return $this->industryManufactureMesProcessWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 生产工单管理
     *  *
     * @param IndustryManufactureMesProductionPlanRequest $request IndustryManufactureMesProductionPlanRequest
     * @param IndustryManufactureMesProductionPlanHeaders $headers IndustryManufactureMesProductionPlanHeaders
     * @param RuntimeOptions                              $runtime runtime options for this request RuntimeOptions
     *
     * @return IndustryManufactureMesProductionPlanResponse IndustryManufactureMesProductionPlanResponse
     */
    public function industryManufactureMesProductionPlanWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->actualEndTime)) {
            $body['actualEndTime'] = $request->actualEndTime;
        }
        if (!Utils::isUnset($request->actualStartTime)) {
            $body['actualStartTime'] = $request->actualStartTime;
        }
        if (!Utils::isUnset($request->appKey)) {
            $body['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->baseDataName)) {
            $body['baseDataName'] = $request->baseDataName;
        }
        if (!Utils::isUnset($request->bomUuid)) {
            $body['bomUuid'] = $request->bomUuid;
        }
        if (!Utils::isUnset($request->events)) {
            $body['events'] = $request->events;
        }
        if (!Utils::isUnset($request->extendData)) {
            $body['extendData'] = $request->extendData;
        }
        if (!Utils::isUnset($request->no)) {
            $body['no'] = $request->no;
        }
        if (!Utils::isUnset($request->overdue)) {
            $body['overdue'] = $request->overdue;
        }
        if (!Utils::isUnset($request->planEndTime)) {
            $body['planEndTime'] = $request->planEndTime;
        }
        if (!Utils::isUnset($request->planQuantity)) {
            $body['planQuantity'] = $request->planQuantity;
        }
        if (!Utils::isUnset($request->planStartTime)) {
            $body['planStartTime'] = $request->planStartTime;
        }
        if (!Utils::isUnset($request->processUuids)) {
            $body['processUuids'] = $request->processUuids;
        }
        if (!Utils::isUnset($request->productCode)) {
            $body['productCode'] = $request->productCode;
        }
        if (!Utils::isUnset($request->productName)) {
            $body['productName'] = $request->productName;
        }
        if (!Utils::isUnset($request->productSpecification)) {
            $body['productSpecification'] = $request->productSpecification;
        }
        if (!Utils::isUnset($request->qualifiedQuantity)) {
            $body['qualifiedQuantity'] = $request->qualifiedQuantity;
        }
        if (!Utils::isUnset($request->sellOrderNo)) {
            $body['sellOrderNo'] = $request->sellOrderNo;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->teamList)) {
            $body['teamList'] = $request->teamList;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
        }
        if (!Utils::isUnset($request->unit)) {
            $body['unit'] = $request->unit;
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
            'action'      => 'IndustryManufactureMesProductionPlan',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/manufacturings/productionPlans/manage',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IndustryManufactureMesProductionPlanResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 生产工单管理
     *  *
     * @param IndustryManufactureMesProductionPlanRequest $request IndustryManufactureMesProductionPlanRequest
     *
     * @return IndustryManufactureMesProductionPlanResponse IndustryManufactureMesProductionPlanResponse
     */
    public function industryManufactureMesProductionPlan($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesProductionPlanHeaders([]);

        return $this->industryManufactureMesProductionPlanWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 生产委外合作班组管理
     *  *
     * @param IndustryManufactureMesSubCooperationTeamRequest $request IndustryManufactureMesSubCooperationTeamRequest
     * @param IndustryManufactureMesSubCooperationTeamHeaders $headers IndustryManufactureMesSubCooperationTeamHeaders
     * @param RuntimeOptions                                  $runtime runtime options for this request RuntimeOptions
     *
     * @return IndustryManufactureMesSubCooperationTeamResponse IndustryManufactureMesSubCooperationTeamResponse
     */
    public function industryManufactureMesSubCooperationTeamWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->appKey)) {
            $body['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->baseDataName)) {
            $body['baseDataName'] = $request->baseDataName;
        }
        if (!Utils::isUnset($request->events)) {
            $body['events'] = $request->events;
        }
        if (!Utils::isUnset($request->extendData)) {
            $body['extendData'] = $request->extendData;
        }
        if (!Utils::isUnset($request->groupPlugins)) {
            $body['groupPlugins'] = $request->groupPlugins;
        }
        if (!Utils::isUnset($request->groupType)) {
            $body['groupType'] = $request->groupType;
        }
        if (!Utils::isUnset($request->leaders)) {
            $body['leaders'] = $request->leaders;
        }
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->outCorpId)) {
            $body['outCorpId'] = $request->outCorpId;
        }
        if (!Utils::isUnset($request->processIds)) {
            $body['processIds'] = $request->processIds;
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
            'action'      => 'IndustryManufactureMesSubCooperationTeam',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/manufacturings/outTeams/manage',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IndustryManufactureMesSubCooperationTeamResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 生产委外合作班组管理
     *  *
     * @param IndustryManufactureMesSubCooperationTeamRequest $request IndustryManufactureMesSubCooperationTeamRequest
     *
     * @return IndustryManufactureMesSubCooperationTeamResponse IndustryManufactureMesSubCooperationTeamResponse
     */
    public function industryManufactureMesSubCooperationTeam($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesSubCooperationTeamHeaders([]);

        return $this->industryManufactureMesSubCooperationTeamWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary MES系统班组管理
     *  *
     * @param IndustryManufactureMesTeamMgmtRequest $request IndustryManufactureMesTeamMgmtRequest
     * @param IndustryManufactureMesTeamMgmtHeaders $headers IndustryManufactureMesTeamMgmtHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return IndustryManufactureMesTeamMgmtResponse IndustryManufactureMesTeamMgmtResponse
     */
    public function industryManufactureMesTeamMgmtWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->appKey)) {
            $body['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->baseDataName)) {
            $body['baseDataName'] = $request->baseDataName;
        }
        if (!Utils::isUnset($request->events)) {
            $body['events'] = $request->events;
        }
        if (!Utils::isUnset($request->extendData)) {
            $body['extendData'] = $request->extendData;
        }
        if (!Utils::isUnset($request->groupConfig)) {
            $body['groupConfig'] = $request->groupConfig;
        }
        if (!Utils::isUnset($request->groupPlugins)) {
            $body['groupPlugins'] = $request->groupPlugins;
        }
        if (!Utils::isUnset($request->groupType)) {
            $body['groupType'] = $request->groupType;
        }
        if (!Utils::isUnset($request->id)) {
            $body['id'] = $request->id;
        }
        if (!Utils::isUnset($request->leaders)) {
            $body['leaders'] = $request->leaders;
        }
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->processIds)) {
            $body['processIds'] = $request->processIds;
        }
        if (!Utils::isUnset($request->tagKey)) {
            $body['tagKey'] = $request->tagKey;
        }
        if (!Utils::isUnset($request->tagValues)) {
            $body['tagValues'] = $request->tagValues;
        }
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
            'action'      => 'IndustryManufactureMesTeamMgmt',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/manufacturing/base/data/team',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IndustryManufactureMesTeamMgmtResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary MES系统班组管理
     *  *
     * @param IndustryManufactureMesTeamMgmtRequest $request IndustryManufactureMesTeamMgmtRequest
     *
     * @return IndustryManufactureMesTeamMgmtResponse IndustryManufactureMesTeamMgmtResponse
     */
    public function industryManufactureMesTeamMgmt($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesTeamMgmtHeaders([]);

        return $this->industryManufactureMesTeamMgmtWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 物料成本查询服务
     *  *
     * @param IndustryMmanufactureMaterialCostGetRequest $request IndustryMmanufactureMaterialCostGetRequest
     * @param IndustryMmanufactureMaterialCostGetHeaders $headers IndustryMmanufactureMaterialCostGetHeaders
     * @param RuntimeOptions                             $runtime runtime options for this request RuntimeOptions
     *
     * @return IndustryMmanufactureMaterialCostGetResponse IndustryMmanufactureMaterialCostGetResponse
     */
    public function industryMmanufactureMaterialCostGetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->appIds)) {
            $body['appIds'] = $request->appIds;
        }
        if (!Utils::isUnset($request->appName)) {
            $body['appName'] = $request->appName;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->cursor)) {
            $body['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->isvOrgId)) {
            $body['isvOrgId'] = $request->isvOrgId;
        }
        if (!Utils::isUnset($request->materialNo)) {
            $body['materialNo'] = $request->materialNo;
        }
        if (!Utils::isUnset($request->microappAgentId)) {
            $body['microappAgentId'] = $request->microappAgentId;
        }
        if (!Utils::isUnset($request->orgId)) {
            $body['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->suiteKey)) {
            $body['suiteKey'] = $request->suiteKey;
        }
        if (!Utils::isUnset($request->tokenGrantType)) {
            $body['tokenGrantType'] = $request->tokenGrantType;
        }
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
            'action'      => 'IndustryMmanufactureMaterialCostGet',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/manufactures/base/materialCosts/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return IndustryMmanufactureMaterialCostGetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 物料成本查询服务
     *  *
     * @param IndustryMmanufactureMaterialCostGetRequest $request IndustryMmanufactureMaterialCostGetRequest
     *
     * @return IndustryMmanufactureMaterialCostGetResponse IndustryMmanufactureMaterialCostGetResponse
     */
    public function industryMmanufactureMaterialCostGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryMmanufactureMaterialCostGetHeaders([]);

        return $this->industryMmanufactureMaterialCostGetWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 提供text和card两种形式工作通知消息
     *  *
     * @param PushDingMessageRequest $request PushDingMessageRequest
     * @param PushDingMessageHeaders $headers PushDingMessageHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return PushDingMessageResponse PushDingMessageResponse
     */
    public function pushDingMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->messageType)) {
            $body['messageType'] = $request->messageType;
        }
        if (!Utils::isUnset($request->messageUrl)) {
            $body['messageUrl'] = $request->messageUrl;
        }
        if (!Utils::isUnset($request->pictureUrl)) {
            $body['pictureUrl'] = $request->pictureUrl;
        }
        if (!Utils::isUnset($request->singleTitle)) {
            $body['singleTitle'] = $request->singleTitle;
        }
        if (!Utils::isUnset($request->singleUrl)) {
            $body['singleUrl'] = $request->singleUrl;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
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
            'action'      => 'PushDingMessage',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/works/notice',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PushDingMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 提供text和card两种形式工作通知消息
     *  *
     * @param PushDingMessageRequest $request PushDingMessageRequest
     *
     * @return PushDingMessageResponse PushDingMessageResponse
     */
    public function pushDingMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PushDingMessageHeaders([]);

        return $this->pushDingMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取当前组织下的所有科室
     *  *
     * @param QueryAllDepartmentRequest $request QueryAllDepartmentRequest
     * @param QueryAllDepartmentHeaders $headers QueryAllDepartmentHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAllDepartmentResponse QueryAllDepartmentResponse
     */
    public function queryAllDepartmentWithOptions($request, $headers, $runtime)
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryAllDepartment',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/departments',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAllDepartmentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取当前组织下的所有科室
     *  *
     * @param QueryAllDepartmentRequest $request QueryAllDepartmentRequest
     *
     * @return QueryAllDepartmentResponse QueryAllDepartmentResponse
     */
    public function queryAllDepartment($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllDepartmentHeaders([]);

        return $this->queryAllDepartmentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询医院下的所有医生
     *  *
     * @param QueryAllDoctorsRequest $request QueryAllDoctorsRequest
     * @param QueryAllDoctorsHeaders $headers QueryAllDoctorsHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAllDoctorsResponse QueryAllDoctorsResponse
     */
    public function queryAllDoctorsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->monthMark)) {
            $query['monthMark'] = $request->monthMark;
        }
        if (!Utils::isUnset($request->pageNum)) {
            $query['pageNum'] = $request->pageNum;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryAllDoctors',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/doctors',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAllDoctorsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询医院下的所有医生
     *  *
     * @param QueryAllDoctorsRequest $request QueryAllDoctorsRequest
     *
     * @return QueryAllDoctorsResponse QueryAllDoctorsResponse
     */
    public function queryAllDoctors($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllDoctorsHeaders([]);

        return $this->queryAllDoctorsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询所有医疗组
     *  *
     * @param QueryAllGroupRequest $request QueryAllGroupRequest
     * @param QueryAllGroupHeaders $headers QueryAllGroupHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAllGroupResponse QueryAllGroupResponse
     */
    public function queryAllGroupWithOptions($request, $headers, $runtime)
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryAllGroup',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/groups',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAllGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询所有医疗组
     *  *
     * @param QueryAllGroupRequest $request QueryAllGroupRequest
     *
     * @return QueryAllGroupResponse QueryAllGroupResponse
     */
    public function queryAllGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllGroupHeaders([]);

        return $this->queryAllGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询科室下的所有医疗组
     *  *
     * @param string                      $deptId
     * @param QueryAllGroupsInDeptRequest $request QueryAllGroupsInDeptRequest
     * @param QueryAllGroupsInDeptHeaders $headers QueryAllGroupsInDeptHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAllGroupsInDeptResponse QueryAllGroupsInDeptResponse
     */
    public function queryAllGroupsInDeptWithOptions($deptId, $request, $headers, $runtime)
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryAllGroupsInDept',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/departments/' . $deptId . '/groups',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAllGroupsInDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询科室下的所有医疗组
     *  *
     * @param string                      $deptId
     * @param QueryAllGroupsInDeptRequest $request QueryAllGroupsInDeptRequest
     *
     * @return QueryAllGroupsInDeptResponse QueryAllGroupsInDeptResponse
     */
    public function queryAllGroupsInDept($deptId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllGroupsInDeptHeaders([]);

        return $this->queryAllGroupsInDeptWithOptions($deptId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询科室下的所有人员
     *  *
     * @param string                      $deptId
     * @param QueryAllMemberByDeptRequest $request QueryAllMemberByDeptRequest
     * @param QueryAllMemberByDeptHeaders $headers QueryAllMemberByDeptHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAllMemberByDeptResponse QueryAllMemberByDeptResponse
     */
    public function queryAllMemberByDeptWithOptions($deptId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->monthMark)) {
            $query['monthMark'] = $request->monthMark;
        }
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryAllMemberByDept',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/departments/' . $deptId . '/members',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAllMemberByDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询科室下的所有人员
     *  *
     * @param string                      $deptId
     * @param QueryAllMemberByDeptRequest $request QueryAllMemberByDeptRequest
     *
     * @return QueryAllMemberByDeptResponse QueryAllMemberByDeptResponse
     */
    public function queryAllMemberByDept($deptId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllMemberByDeptHeaders([]);

        return $this->queryAllMemberByDeptWithOptions($deptId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取医疗组下面的所有成员
     *  *
     * @param string                       $groupId
     * @param QueryAllMemberByGroupRequest $request QueryAllMemberByGroupRequest
     * @param QueryAllMemberByGroupHeaders $headers QueryAllMemberByGroupHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAllMemberByGroupResponse QueryAllMemberByGroupResponse
     */
    public function queryAllMemberByGroupWithOptions($groupId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->monthMark)) {
            $query['monthMark'] = $request->monthMark;
        }
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryAllMemberByGroup',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/groups/' . $groupId . '/members',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAllMemberByGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取医疗组下面的所有成员
     *  *
     * @param string                       $groupId
     * @param QueryAllMemberByGroupRequest $request QueryAllMemberByGroupRequest
     *
     * @return QueryAllMemberByGroupResponse QueryAllMemberByGroupResponse
     */
    public function queryAllMemberByGroup($groupId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllMemberByGroupHeaders([]);

        return $this->queryAllMemberByGroupWithOptions($groupId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取当前企业医疗通讯录的业务操作日志
     *  *
     * @param QueryBizOptLogRequest $request QueryBizOptLogRequest
     * @param QueryBizOptLogHeaders $headers QueryBizOptLogHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryBizOptLogResponse QueryBizOptLogResponse
     */
    public function queryBizOptLogWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'action'      => 'QueryBizOptLog',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/bizOptLogs',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryBizOptLogResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取当前企业医疗通讯录的业务操作日志
     *  *
     * @param QueryBizOptLogRequest $request QueryBizOptLogRequest
     *
     * @return QueryBizOptLogResponse QueryBizOptLogResponse
     */
    public function queryBizOptLog($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBizOptLogHeaders([]);

        return $this->queryBizOptLogWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询科室和医疗组的扩展信息
     *  *
     * @param QueryDepartmentExtendInfoRequest $request QueryDepartmentExtendInfoRequest
     * @param QueryDepartmentExtendInfoHeaders $headers QueryDepartmentExtendInfoHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDepartmentExtendInfoResponse QueryDepartmentExtendInfoResponse
     */
    public function queryDepartmentExtendInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptCode)) {
            $query['deptCode'] = $request->deptCode;
        }
        if (!Utils::isUnset($request->propCode)) {
            $query['propCode'] = $request->propCode;
        }
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
            'action'      => 'QueryDepartmentExtendInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/departments/extensions/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryDepartmentExtendInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询科室和医疗组的扩展信息
     *  *
     * @param QueryDepartmentExtendInfoRequest $request QueryDepartmentExtendInfoRequest
     *
     * @return QueryDepartmentExtendInfoResponse QueryDepartmentExtendInfoResponse
     */
    public function queryDepartmentExtendInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDepartmentExtendInfoHeaders([]);

        return $this->queryDepartmentExtendInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询部门详情
     *  *
     * @param string                     $deptId
     * @param QueryDepartmentInfoHeaders $headers QueryDepartmentInfoHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDepartmentInfoResponse QueryDepartmentInfoResponse
     */
    public function queryDepartmentInfoWithOptions($deptId, $headers, $runtime)
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
            'action'      => 'QueryDepartmentInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/departments/' . $deptId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryDepartmentInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询部门详情
     *  *
     * @param string $deptId
     *
     * @return QueryDepartmentInfoResponse QueryDepartmentInfoResponse
     */
    public function queryDepartmentInfo($deptId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDepartmentInfoHeaders([]);

        return $this->queryDepartmentInfoWithOptions($deptId, $headers, $runtime);
    }

    /**
     * @summary 通过工号查询人员信息
     *  *
     * @param string                               $jobNumber
     * @param QueryDoctorDetailsByJobNumberRequest $request   QueryDoctorDetailsByJobNumberRequest
     * @param QueryDoctorDetailsByJobNumberHeaders $headers   QueryDoctorDetailsByJobNumberHeaders
     * @param RuntimeOptions                       $runtime   runtime options for this request RuntimeOptions
     *
     * @return QueryDoctorDetailsByJobNumberResponse QueryDoctorDetailsByJobNumberResponse
     */
    public function queryDoctorDetailsByJobNumberWithOptions($jobNumber, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->monthMark)) {
            $query['monthMark'] = $request->monthMark;
        }
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
            'action'      => 'QueryDoctorDetailsByJobNumber',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/doctors/' . $jobNumber . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryDoctorDetailsByJobNumberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过工号查询人员信息
     *  *
     * @param string                               $jobNumber
     * @param QueryDoctorDetailsByJobNumberRequest $request   QueryDoctorDetailsByJobNumberRequest
     *
     * @return QueryDoctorDetailsByJobNumberResponse QueryDoctorDetailsByJobNumberResponse
     */
    public function queryDoctorDetailsByJobNumber($jobNumber, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDoctorDetailsByJobNumberHeaders([]);

        return $this->queryDoctorDetailsByJobNumberWithOptions($jobNumber, $request, $headers, $runtime);
    }

    /**
     * @summary 获取医疗组详情
     *  *
     * @param string                $groupId
     * @param QueryGroupInfoHeaders $headers QueryGroupInfoHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGroupInfoResponse QueryGroupInfoResponse
     */
    public function queryGroupInfoWithOptions($groupId, $headers, $runtime)
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
            'action'      => 'QueryGroupInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/groups/' . $groupId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryGroupInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取医疗组详情
     *  *
     * @param string $groupId
     *
     * @return QueryGroupInfoResponse QueryGroupInfoResponse
     */
    public function queryGroupInfo($groupId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupInfoHeaders([]);

        return $this->queryGroupInfoWithOptions($groupId, $headers, $runtime);
    }

    /**
     * @summary 查询医院的院区和病区信息
     *  *
     * @param QueryHospitalDistrictInfoRequest $request QueryHospitalDistrictInfoRequest
     * @param QueryHospitalDistrictInfoHeaders $headers QueryHospitalDistrictInfoHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryHospitalDistrictInfoResponse QueryHospitalDistrictInfoResponse
     */
    public function queryHospitalDistrictInfoWithOptions($request, $headers, $runtime)
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryHospitalDistrictInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/districts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryHospitalDistrictInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询医院的院区和病区信息
     *  *
     * @param QueryHospitalDistrictInfoRequest $request QueryHospitalDistrictInfoRequest
     *
     * @return QueryHospitalDistrictInfoResponse QueryHospitalDistrictInfoResponse
     */
    public function queryHospitalDistrictInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHospitalDistrictInfoHeaders([]);

        return $this->queryHospitalDistrictInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询医院所有角色的人员
     *  *
     * @param QueryHospitalRoleUserInfoRequest $request QueryHospitalRoleUserInfoRequest
     * @param QueryHospitalRoleUserInfoHeaders $headers QueryHospitalRoleUserInfoHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryHospitalRoleUserInfoResponse QueryHospitalRoleUserInfoResponse
     */
    public function queryHospitalRoleUserInfoWithOptions($request, $headers, $runtime)
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryHospitalRoleUserInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/roles/userInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryHospitalRoleUserInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询医院所有角色的人员
     *  *
     * @param QueryHospitalRoleUserInfoRequest $request QueryHospitalRoleUserInfoRequest
     *
     * @return QueryHospitalRoleUserInfoResponse QueryHospitalRoleUserInfoResponse
     */
    public function queryHospitalRoleUserInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHospitalRoleUserInfoHeaders([]);

        return $this->queryHospitalRoleUserInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询医院的角色
     *  *
     * @param QueryHospitalRolesHeaders $headers QueryHospitalRolesHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryHospitalRolesResponse QueryHospitalRolesResponse
     */
    public function queryHospitalRolesWithOptions($headers, $runtime)
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
            'action'      => 'QueryHospitalRoles',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/roles',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryHospitalRolesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询医院的角色
     *  *
     * @return QueryHospitalRolesResponse QueryHospitalRolesResponse
     */
    public function queryHospitalRoles()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHospitalRolesHeaders([]);

        return $this->queryHospitalRolesWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询职称字典表
     *  *
     * @param QueryJobCodeDictionaryHeaders $headers QueryJobCodeDictionaryHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryJobCodeDictionaryResponse QueryJobCodeDictionaryResponse
     */
    public function queryJobCodeDictionaryWithOptions($headers, $runtime)
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
            'action'      => 'QueryJobCodeDictionary',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/jobCodes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryJobCodeDictionaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询职称字典表
     *  *
     * @return QueryJobCodeDictionaryResponse QueryJobCodeDictionaryResponse
     */
    public function queryJobCodeDictionary()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryJobCodeDictionaryHeaders([]);

        return $this->queryJobCodeDictionaryWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询工作状态字典表
     *  *
     * @param QueryJobStatusCodeDictionaryHeaders $headers QueryJobStatusCodeDictionaryHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryJobStatusCodeDictionaryResponse QueryJobStatusCodeDictionaryResponse
     */
    public function queryJobStatusCodeDictionaryWithOptions($headers, $runtime)
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
            'action'      => 'QueryJobStatusCodeDictionary',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/jobStatusCodes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryJobStatusCodeDictionaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询工作状态字典表
     *  *
     * @return QueryJobStatusCodeDictionaryResponse QueryJobStatusCodeDictionaryResponse
     */
    public function queryJobStatusCodeDictionary()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryJobStatusCodeDictionaryHeaders([]);

        return $this->queryJobStatusCodeDictionaryWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询医疗行业事件
     *  *
     * @param QueryMedicalEventsHeaders $headers QueryMedicalEventsHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryMedicalEventsResponse QueryMedicalEventsResponse
     */
    public function queryMedicalEventsWithOptions($headers, $runtime)
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
            'action'      => 'QueryMedicalEvents',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/events',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryMedicalEventsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询医疗行业事件
     *  *
     * @return QueryMedicalEventsResponse QueryMedicalEventsResponse
     */
    public function queryMedicalEvents()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMedicalEventsHeaders([]);

        return $this->queryMedicalEventsWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询用户的证书
     *  *
     * @param QueryUserCredentialsRequest $request QueryUserCredentialsRequest
     * @param QueryUserCredentialsHeaders $headers QueryUserCredentialsHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserCredentialsResponse QueryUserCredentialsResponse
     */
    public function queryUserCredentialsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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
            'action'      => 'QueryUserCredentials',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/users/credentials/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryUserCredentialsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户的证书
     *  *
     * @param QueryUserCredentialsRequest $request QueryUserCredentialsRequest
     *
     * @return QueryUserCredentialsResponse QueryUserCredentialsResponse
     */
    public function queryUserCredentials($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserCredentialsHeaders([]);

        return $this->queryUserCredentialsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询人员的扩展信息
     *  *
     * @param string                  $userId
     * @param QueryUserExtInfoHeaders $headers QueryUserExtInfoHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserExtInfoResponse QueryUserExtInfoResponse
     */
    public function queryUserExtInfoWithOptions($userId, $headers, $runtime)
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
            'action'      => 'QueryUserExtInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/users/' . $userId . '/extInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryUserExtInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询人员的扩展信息
     *  *
     * @param string $userId
     *
     * @return QueryUserExtInfoResponse QueryUserExtInfoResponse
     */
    public function queryUserExtInfo($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserExtInfoHeaders([]);

        return $this->queryUserExtInfoWithOptions($userId, $headers, $runtime);
    }

    /**
     * @summary 获取用户拓展字段
     *  *
     * @param QueryUserExtendValuesRequest $request QueryUserExtendValuesRequest
     * @param QueryUserExtendValuesHeaders $headers QueryUserExtendValuesHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserExtendValuesResponse QueryUserExtendValuesResponse
     */
    public function queryUserExtendValuesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userExtendKey)) {
            $body['userExtendKey'] = $request->userExtendKey;
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
            'action'      => 'QueryUserExtendValues',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/users/extends/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryUserExtendValuesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户拓展字段
     *  *
     * @param QueryUserExtendValuesRequest $request QueryUserExtendValuesRequest
     *
     * @return QueryUserExtendValuesResponse QueryUserExtendValuesResponse
     */
    public function queryUserExtendValues($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserExtendValuesHeaders([]);

        return $this->queryUserExtendValuesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询人员详情
     *  *
     * @param string               $userId
     * @param QueryUserInfoRequest $request QueryUserInfoRequest
     * @param QueryUserInfoHeaders $headers QueryUserInfoHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserInfoResponse QueryUserInfoResponse
     */
    public function queryUserInfoWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->monthMark)) {
            $query['monthMark'] = $request->monthMark;
        }
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
            'action'      => 'QueryUserInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/users/' . $userId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryUserInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询人员详情
     *  *
     * @param string               $userId
     * @param QueryUserInfoRequest $request QueryUserInfoRequest
     *
     * @return QueryUserInfoResponse QueryUserInfoResponse
     */
    public function queryUserInfo($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserInfoHeaders([]);

        return $this->queryUserInfoWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询人员属性字典表
     *  *
     * @param QueryUserProbCodeDictionaryHeaders $headers QueryUserProbCodeDictionaryHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserProbCodeDictionaryResponse QueryUserProbCodeDictionaryResponse
     */
    public function queryUserProbCodeDictionaryWithOptions($headers, $runtime)
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
            'action'      => 'QueryUserProbCodeDictionary',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/userProbCodes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryUserProbCodeDictionaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询人员属性字典表
     *  *
     * @return QueryUserProbCodeDictionaryResponse QueryUserProbCodeDictionaryResponse
     */
    public function queryUserProbCodeDictionary()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserProbCodeDictionaryHeaders([]);

        return $this->queryUserProbCodeDictionaryWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询人员权限
     *  *
     * @param string                $userId
     * @param QueryUserRolesHeaders $headers QueryUserRolesHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserRolesResponse QueryUserRolesResponse
     */
    public function queryUserRolesWithOptions($userId, $headers, $runtime)
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
            'action'      => 'QueryUserRoles',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/users/' . $userId . '/roles',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryUserRolesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询人员权限
     *  *
     * @param string $userId
     *
     * @return QueryUserRolesResponse QueryUserRolesResponse
     */
    public function queryUserRoles($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserRolesHeaders([]);

        return $this->queryUserRolesWithOptions($userId, $headers, $runtime);
    }

    /**
     * @summary 保存用户拓展字段
     *  *
     * @param string                      $userId
     * @param SaveUserExtendValuesRequest $request SaveUserExtendValuesRequest
     * @param SaveUserExtendValuesHeaders $headers SaveUserExtendValuesHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveUserExtendValuesResponse SaveUserExtendValuesResponse
     */
    public function saveUserExtendValuesWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userDisplayName)) {
            $query['userDisplayName'] = $request->userDisplayName;
        }
        if (!Utils::isUnset($request->userExtendKey)) {
            $query['userExtendKey'] = $request->userExtendKey;
        }
        if (!Utils::isUnset($request->userExtendValue)) {
            $query['userExtendValue'] = $request->userExtendValue;
        }
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
            'action'      => 'SaveUserExtendValues',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/users/' . $userId . '/extends',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveUserExtendValuesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 保存用户拓展字段
     *  *
     * @param string                      $userId
     * @param SaveUserExtendValuesRequest $request SaveUserExtendValuesRequest
     *
     * @return SaveUserExtendValuesResponse SaveUserExtendValuesResponse
     */
    public function saveUserExtendValues($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveUserExtendValuesHeaders([]);

        return $this->saveUserExtendValuesWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 提交ai解析任务
     *  *
     * @param SubmitTaskRequest $request SubmitTaskRequest
     * @param SubmitTaskHeaders $headers SubmitTaskHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return SubmitTaskResponse SubmitTaskResponse
     */
    public function submitTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
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
            'action'      => 'SubmitTask',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/ai/tasks/submit',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SubmitTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 提交ai解析任务
     *  *
     * @param SubmitTaskRequest $request SubmitTaskRequest
     *
     * @return SubmitTaskResponse SubmitTaskResponse
     */
    public function submitTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SubmitTaskHeaders([]);

        return $this->submitTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 增加角色或角色组
     *  *
     * @param SupplAddRoleRequest $request SupplAddRoleRequest
     * @param SupplAddRoleHeaders $headers SupplAddRoleHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplAddRoleResponse SupplAddRoleResponse
     */
    public function supplAddRoleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->parentRoleGroupId)) {
            $query['parentRoleGroupId'] = $request->parentRoleGroupId;
        }
        if (!Utils::isUnset($request->roleName)) {
            $query['roleName'] = $request->roleName;
        }
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
            'action'      => 'SupplAddRole',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/roles',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplAddRoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 增加角色或角色组
     *  *
     * @param SupplAddRoleRequest $request SupplAddRoleRequest
     *
     * @return SupplAddRoleResponse SupplAddRoleResponse
     */
    public function supplAddRole($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplAddRoleHeaders([]);

        return $this->supplAddRoleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新增供应链节点
     *  *
     * @param SupplyAddDeptRequest $request SupplyAddDeptRequest
     * @param SupplyAddDeptHeaders $headers SupplyAddDeptHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyAddDeptResponse SupplyAddDeptResponse
     */
    public function supplyAddDeptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptName)) {
            $query['deptName'] = $request->deptName;
        }
        if (!Utils::isUnset($request->partnerNumber)) {
            $query['partnerNumber'] = $request->partnerNumber;
        }
        if (!Utils::isUnset($request->superDeptId)) {
            $query['superDeptId'] = $request->superDeptId;
        }
        if (!Utils::isUnset($request->supplyDeptType)) {
            $query['supplyDeptType'] = $request->supplyDeptType;
        }
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
            'action'      => 'SupplyAddDept',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/departments',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyAddDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增供应链节点
     *  *
     * @param SupplyAddDeptRequest $request SupplyAddDeptRequest
     *
     * @return SupplyAddDeptResponse SupplyAddDeptResponse
     */
    public function supplyAddDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyAddDeptHeaders([]);

        return $this->supplyAddDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加供应商人员
     *  *
     * @param SupplyAddMemberRequest $request SupplyAddMemberRequest
     * @param SupplyAddMemberHeaders $headers SupplyAddMemberHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyAddMemberResponse SupplyAddMemberResponse
     */
    public function supplyAddMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->isPartnerManager)) {
            $query['isPartnerManager'] = $request->isPartnerManager;
        }
        if (!Utils::isUnset($request->memberMobile)) {
            $query['memberMobile'] = $request->memberMobile;
        }
        if (!Utils::isUnset($request->memberName)) {
            $query['memberName'] = $request->memberName;
        }
        if (!Utils::isUnset($request->memberTitle)) {
            $query['memberTitle'] = $request->memberTitle;
        }
        if (!Utils::isUnset($request->memberWorkNumber)) {
            $query['memberWorkNumber'] = $request->memberWorkNumber;
        }
        if (!Utils::isUnset($request->supplyDeptId)) {
            $query['supplyDeptId'] = $request->supplyDeptId;
        }
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
            'action'      => 'SupplyAddMember',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/members',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyAddMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加供应商人员
     *  *
     * @param SupplyAddMemberRequest $request SupplyAddMemberRequest
     *
     * @return SupplyAddMemberResponse SupplyAddMemberResponse
     */
    public function supplyAddMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyAddMemberHeaders([]);

        return $this->supplyAddMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加伙伴负责人
     *  *
     * @param SupplyAddPartnerAdminsRequest $request SupplyAddPartnerAdminsRequest
     * @param SupplyAddPartnerAdminsHeaders $headers SupplyAddPartnerAdminsHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyAddPartnerAdminsResponse SupplyAddPartnerAdminsResponse
     */
    public function supplyAddPartnerAdminsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
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
            'action'      => 'SupplyAddPartnerAdmins',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/partnerAdministrators',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyAddPartnerAdminsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加伙伴负责人
     *  *
     * @param SupplyAddPartnerAdminsRequest $request SupplyAddPartnerAdminsRequest
     *
     * @return SupplyAddPartnerAdminsResponse SupplyAddPartnerAdminsResponse
     */
    public function supplyAddPartnerAdmins($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyAddPartnerAdminsHeaders([]);

        return $this->supplyAddPartnerAdminsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加伙伴的对接人或对接部门
     *  *
     * @param SupplyAddPartnerManagersRequest $request SupplyAddPartnerManagersRequest
     * @param SupplyAddPartnerManagersHeaders $headers SupplyAddPartnerManagersHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyAddPartnerManagersResponse SupplyAddPartnerManagersResponse
     */
    public function supplyAddPartnerManagersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->interfaceId)) {
            $query['interfaceId'] = $request->interfaceId;
        }
        if (!Utils::isUnset($request->interfaceType)) {
            $query['interfaceType'] = $request->interfaceType;
        }
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
            'action'      => 'SupplyAddPartnerManagers',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/partnerInterfaces',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyAddPartnerManagersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加伙伴的对接人或对接部门
     *  *
     * @param SupplyAddPartnerManagersRequest $request SupplyAddPartnerManagersRequest
     *
     * @return SupplyAddPartnerManagersResponse SupplyAddPartnerManagersResponse
     */
    public function supplyAddPartnerManagers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyAddPartnerManagersHeaders([]);

        return $this->supplyAddPartnerManagersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加伙伴标签
     *  *
     * @param SupplyAddPartnerTypeRequest $request SupplyAddPartnerTypeRequest
     * @param SupplyAddPartnerTypeHeaders $headers SupplyAddPartnerTypeHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyAddPartnerTypeResponse SupplyAddPartnerTypeResponse
     */
    public function supplyAddPartnerTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->name)) {
            $query['name'] = $request->name;
        }
        if (!Utils::isUnset($request->superId)) {
            $query['superId'] = $request->superId;
        }
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
            'action'      => 'SupplyAddPartnerType',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/partnerLabels',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyAddPartnerTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加伙伴标签
     *  *
     * @param SupplyAddPartnerTypeRequest $request SupplyAddPartnerTypeRequest
     *
     * @return SupplyAddPartnerTypeResponse SupplyAddPartnerTypeResponse
     */
    public function supplyAddPartnerType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyAddPartnerTypeHeaders([]);

        return $this->supplyAddPartnerTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary  删除上下游节点
     *  *
     * @param SupplyChainDeleteDeptRequest $request SupplyChainDeleteDeptRequest
     * @param SupplyChainDeleteDeptHeaders $headers SupplyChainDeleteDeptHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyChainDeleteDeptResponse SupplyChainDeleteDeptResponse
     */
    public function supplyChainDeleteDeptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->supplyDeptId)) {
            $query['supplyDeptId'] = $request->supplyDeptId;
        }
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
            'action'      => 'SupplyChainDeleteDept',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/departments',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyChainDeleteDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary  删除上下游节点
     *  *
     * @param SupplyChainDeleteDeptRequest $request SupplyChainDeleteDeptRequest
     *
     * @return SupplyChainDeleteDeptResponse SupplyChainDeleteDeptResponse
     */
    public function supplyChainDeleteDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyChainDeleteDeptHeaders([]);

        return $this->supplyChainDeleteDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询上下游节点信息
     *  *
     * @param SupplyChainQueryDeptInfoRequest $request SupplyChainQueryDeptInfoRequest
     * @param SupplyChainQueryDeptInfoHeaders $headers SupplyChainQueryDeptInfoHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyChainQueryDeptInfoResponse SupplyChainQueryDeptInfoResponse
     */
    public function supplyChainQueryDeptInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->supplyDeptId)) {
            $query['supplyDeptId'] = $request->supplyDeptId;
        }
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
            'action'      => 'SupplyChainQueryDeptInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/departments',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyChainQueryDeptInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询上下游节点信息
     *  *
     * @param SupplyChainQueryDeptInfoRequest $request SupplyChainQueryDeptInfoRequest
     *
     * @return SupplyChainQueryDeptInfoResponse SupplyChainQueryDeptInfoResponse
     */
    public function supplyChainQueryDeptInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyChainQueryDeptInfoHeaders([]);

        return $this->supplyChainQueryDeptInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新上下游节点信息
     *  *
     * @param SupplyChainUpdateDeptInfoRequest $request SupplyChainUpdateDeptInfoRequest
     * @param SupplyChainUpdateDeptInfoHeaders $headers SupplyChainUpdateDeptInfoHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyChainUpdateDeptInfoResponse SupplyChainUpdateDeptInfoResponse
     */
    public function supplyChainUpdateDeptInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->partnerNumber)) {
            $body['partnerNumber'] = $request->partnerNumber;
        }
        if (!Utils::isUnset($request->partnerTypeList)) {
            $body['partnerTypeList'] = $request->partnerTypeList;
        }
        if (!Utils::isUnset($request->superId)) {
            $body['superId'] = $request->superId;
        }
        if (!Utils::isUnset($request->supplyDeptId)) {
            $body['supplyDeptId'] = $request->supplyDeptId;
        }
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
            'action'      => 'SupplyChainUpdateDeptInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/departments',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyChainUpdateDeptInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新上下游节点信息
     *  *
     * @param SupplyChainUpdateDeptInfoRequest $request SupplyChainUpdateDeptInfoRequest
     *
     * @return SupplyChainUpdateDeptInfoResponse SupplyChainUpdateDeptInfoResponse
     */
    public function supplyChainUpdateDeptInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyChainUpdateDeptInfoHeaders([]);

        return $this->supplyChainUpdateDeptInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除伙伴成员
     *  *
     * @param SupplyDeleteMemberRequest $request SupplyDeleteMemberRequest
     * @param SupplyDeleteMemberHeaders $headers SupplyDeleteMemberHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyDeleteMemberResponse SupplyDeleteMemberResponse
     */
    public function supplyDeleteMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->mobile)) {
            $query['mobile'] = $request->mobile;
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
            'action'      => 'SupplyDeleteMember',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/members',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyDeleteMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除伙伴成员
     *  *
     * @param SupplyDeleteMemberRequest $request SupplyDeleteMemberRequest
     *
     * @return SupplyDeleteMemberResponse SupplyDeleteMemberResponse
     */
    public function supplyDeleteMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyDeleteMemberHeaders([]);

        return $this->supplyDeleteMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除伙伴负责人
     *  *
     * @param SupplyDeletePartnerAdminsRequest $request SupplyDeletePartnerAdminsRequest
     * @param SupplyDeletePartnerAdminsHeaders $headers SupplyDeletePartnerAdminsHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyDeletePartnerAdminsResponse SupplyDeletePartnerAdminsResponse
     */
    public function supplyDeletePartnerAdminsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
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
            'action'      => 'SupplyDeletePartnerAdmins',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/partnerAdministrators',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyDeletePartnerAdminsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除伙伴负责人
     *  *
     * @param SupplyDeletePartnerAdminsRequest $request SupplyDeletePartnerAdminsRequest
     *
     * @return SupplyDeletePartnerAdminsResponse SupplyDeletePartnerAdminsResponse
     */
    public function supplyDeletePartnerAdmins($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyDeletePartnerAdminsHeaders([]);

        return $this->supplyDeletePartnerAdminsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 移除伙伴的对接人或对接部门
     *  *
     * @param SupplyDeletePartnerManagersRequest $request SupplyDeletePartnerManagersRequest
     * @param SupplyDeletePartnerManagersHeaders $headers SupplyDeletePartnerManagersHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyDeletePartnerManagersResponse SupplyDeletePartnerManagersResponse
     */
    public function supplyDeletePartnerManagersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->interfaceId)) {
            $query['interfaceId'] = $request->interfaceId;
        }
        if (!Utils::isUnset($request->interfaceType)) {
            $query['interfaceType'] = $request->interfaceType;
        }
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
            'action'      => 'SupplyDeletePartnerManagers',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/partnerInterfaces',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyDeletePartnerManagersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 移除伙伴的对接人或对接部门
     *  *
     * @param SupplyDeletePartnerManagersRequest $request SupplyDeletePartnerManagersRequest
     *
     * @return SupplyDeletePartnerManagersResponse SupplyDeletePartnerManagersResponse
     */
    public function supplyDeletePartnerManagers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyDeletePartnerManagersHeaders([]);

        return $this->supplyDeletePartnerManagersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除伙伴标签
     *  *
     * @param SupplyDeletePartnerTypeRequest $request SupplyDeletePartnerTypeRequest
     * @param SupplyDeletePartnerTypeHeaders $headers SupplyDeletePartnerTypeHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyDeletePartnerTypeResponse SupplyDeletePartnerTypeResponse
     */
    public function supplyDeletePartnerTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->labelId)) {
            $query['labelId'] = $request->labelId;
        }
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
            'action'      => 'SupplyDeletePartnerType',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/partnerLabels',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyDeletePartnerTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除伙伴标签
     *  *
     * @param SupplyDeletePartnerTypeRequest $request SupplyDeletePartnerTypeRequest
     *
     * @return SupplyDeletePartnerTypeResponse SupplyDeletePartnerTypeResponse
     */
    public function supplyDeletePartnerType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyDeletePartnerTypeHeaders([]);

        return $this->supplyDeletePartnerTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除角色或角色组
     *  *
     * @param SupplyDeleteRoleRequest $request SupplyDeleteRoleRequest
     * @param SupplyDeleteRoleHeaders $headers SupplyDeleteRoleHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyDeleteRoleResponse SupplyDeleteRoleResponse
     */
    public function supplyDeleteRoleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->isRoleGroup)) {
            $query['isRoleGroup'] = $request->isRoleGroup;
        }
        if (!Utils::isUnset($request->roleId)) {
            $query['roleId'] = $request->roleId;
        }
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
            'action'      => 'SupplyDeleteRole',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/roles',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyDeleteRoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除角色或角色组
     *  *
     * @param SupplyDeleteRoleRequest $request SupplyDeleteRoleRequest
     *
     * @return SupplyDeleteRoleResponse SupplyDeleteRoleResponse
     */
    public function supplyDeleteRole($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyDeleteRoleHeaders([]);

        return $this->supplyDeleteRoleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取供应链成员信息
     *  *
     * @param SupplyGetMemberRequest $request SupplyGetMemberRequest
     * @param SupplyGetMemberHeaders $headers SupplyGetMemberHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyGetMemberResponse SupplyGetMemberResponse
     */
    public function supplyGetMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->mobile)) {
            $query['mobile'] = $request->mobile;
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
            'action'      => 'SupplyGetMember',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/members',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyGetMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取供应链成员信息
     *  *
     * @param SupplyGetMemberRequest $request SupplyGetMemberRequest
     *
     * @return SupplyGetMemberResponse SupplyGetMemberResponse
     */
    public function supplyGetMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyGetMemberHeaders([]);

        return $this->supplyGetMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取供应链部门下成员
     *  *
     * @param SupplyListDeptMembersRequest $request SupplyListDeptMembersRequest
     * @param SupplyListDeptMembersHeaders $headers SupplyListDeptMembersHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyListDeptMembersResponse SupplyListDeptMembersResponse
     */
    public function supplyListDeptMembersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->supplyDeptId)) {
            $query['supplyDeptId'] = $request->supplyDeptId;
        }
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
            'action'      => 'SupplyListDeptMembers',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/departments/members',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyListDeptMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取供应链部门下成员
     *  *
     * @param SupplyListDeptMembersRequest $request SupplyListDeptMembersRequest
     *
     * @return SupplyListDeptMembersResponse SupplyListDeptMembersResponse
     */
    public function supplyListDeptMembers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyListDeptMembersHeaders([]);

        return $this->supplyListDeptMembersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取伙伴负责人列表
     *  *
     * @param SupplyListPartnerAdminsRequest $request SupplyListPartnerAdminsRequest
     * @param SupplyListPartnerAdminsHeaders $headers SupplyListPartnerAdminsHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyListPartnerAdminsResponse SupplyListPartnerAdminsResponse
     */
    public function supplyListPartnerAdminsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
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
            'action'      => 'SupplyListPartnerAdmins',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/partnerAdministrators',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyListPartnerAdminsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取伙伴负责人列表
     *  *
     * @param SupplyListPartnerAdminsRequest $request SupplyListPartnerAdminsRequest
     *
     * @return SupplyListPartnerAdminsResponse SupplyListPartnerAdminsResponse
     */
    public function supplyListPartnerAdmins($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyListPartnerAdminsHeaders([]);

        return $this->supplyListPartnerAdminsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取伙伴的对接人/对接部门
     *  *
     * @param SupplyListPartnerManagersRequest $request SupplyListPartnerManagersRequest
     * @param SupplyListPartnerManagersHeaders $headers SupplyListPartnerManagersHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyListPartnerManagersResponse SupplyListPartnerManagersResponse
     */
    public function supplyListPartnerManagersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
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
            'action'      => 'SupplyListPartnerManagers',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/partnerInterfaces',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyListPartnerManagersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取伙伴的对接人/对接部门
     *  *
     * @param SupplyListPartnerManagersRequest $request SupplyListPartnerManagersRequest
     *
     * @return SupplyListPartnerManagersResponse SupplyListPartnerManagersResponse
     */
    public function supplyListPartnerManagers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyListPartnerManagersHeaders([]);

        return $this->supplyListPartnerManagersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询下级伙伴标签
     *  *
     * @param SupplyListPartnerTypeRequest $request SupplyListPartnerTypeRequest
     * @param SupplyListPartnerTypeHeaders $headers SupplyListPartnerTypeHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyListPartnerTypeResponse SupplyListPartnerTypeResponse
     */
    public function supplyListPartnerTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->labelId)) {
            $query['labelId'] = $request->labelId;
        }
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
            'action'      => 'SupplyListPartnerType',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/partnerLabels/subLabels',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyListPartnerTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询下级伙伴标签
     *  *
     * @param SupplyListPartnerTypeRequest $request SupplyListPartnerTypeRequest
     *
     * @return SupplyListPartnerTypeResponse SupplyListPartnerTypeResponse
     */
    public function supplyListPartnerType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyListPartnerTypeHeaders([]);

        return $this->supplyListPartnerTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询角色组或角色
     *  *
     * @param SupplyListRoleRequest $request SupplyListRoleRequest
     * @param SupplyListRoleHeaders $headers SupplyListRoleHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyListRoleResponse SupplyListRoleResponse
     */
    public function supplyListRoleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->parentRoleId)) {
            $query['parentRoleId'] = $request->parentRoleId;
        }
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
            'action'      => 'SupplyListRole',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/roles',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyListRoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询角色组或角色
     *  *
     * @param SupplyListRoleRequest $request SupplyListRoleRequest
     *
     * @return SupplyListRoleResponse SupplyListRoleResponse
     */
    public function supplyListRole($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyListRoleHeaders([]);

        return $this->supplyListRoleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询下级节点列表
     *  *
     * @param SupplyListSubDeptRequest $request SupplyListSubDeptRequest
     * @param SupplyListSubDeptHeaders $headers SupplyListSubDeptHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyListSubDeptResponse SupplyListSubDeptResponse
     */
    public function supplyListSubDeptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->supplyDeptId)) {
            $query['supplyDeptId'] = $request->supplyDeptId;
        }
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
            'action'      => 'SupplyListSubDept',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/subDepartments',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyListSubDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询下级节点列表
     *  *
     * @param SupplyListSubDeptRequest $request SupplyListSubDeptRequest
     *
     * @return SupplyListSubDeptResponse SupplyListSubDeptResponse
     */
    public function supplyListSubDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyListSubDeptHeaders([]);

        return $this->supplyListSubDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询伙伴标签
     *  *
     * @param SupplyQueryPartnerTypeRequest $request SupplyQueryPartnerTypeRequest
     * @param SupplyQueryPartnerTypeHeaders $headers SupplyQueryPartnerTypeHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyQueryPartnerTypeResponse SupplyQueryPartnerTypeResponse
     */
    public function supplyQueryPartnerTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->labelId)) {
            $query['labelId'] = $request->labelId;
        }
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
            'action'      => 'SupplyQueryPartnerType',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/partnerLabels',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyQueryPartnerTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询伙伴标签
     *  *
     * @param SupplyQueryPartnerTypeRequest $request SupplyQueryPartnerTypeRequest
     *
     * @return SupplyQueryPartnerTypeResponse SupplyQueryPartnerTypeResponse
     */
    public function supplyQueryPartnerType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyQueryPartnerTypeHeaders([]);

        return $this->supplyQueryPartnerTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新供应商人员信息
     *  *
     * @param SupplyUpdateMemberRequest $request SupplyUpdateMemberRequest
     * @param SupplyUpdateMemberHeaders $headers SupplyUpdateMemberHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyUpdateMemberResponse SupplyUpdateMemberResponse
     */
    public function supplyUpdateMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->isCopyDept)) {
            $body['isCopyDept'] = $request->isCopyDept;
        }
        if (!Utils::isUnset($request->memberTitle)) {
            $body['memberTitle'] = $request->memberTitle;
        }
        if (!Utils::isUnset($request->memberWorkNumber)) {
            $body['memberWorkNumber'] = $request->memberWorkNumber;
        }
        if (!Utils::isUnset($request->mobile)) {
            $body['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->newDeptId)) {
            $body['newDeptId'] = $request->newDeptId;
        }
        if (!Utils::isUnset($request->oldDeptId)) {
            $body['oldDeptId'] = $request->oldDeptId;
        }
        if (!Utils::isUnset($request->roleIdList)) {
            $body['roleIdList'] = $request->roleIdList;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'SupplyUpdateMember',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/members',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyUpdateMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新供应商人员信息
     *  *
     * @param SupplyUpdateMemberRequest $request SupplyUpdateMemberRequest
     *
     * @return SupplyUpdateMemberResponse SupplyUpdateMemberResponse
     */
    public function supplyUpdateMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyUpdateMemberHeaders([]);

        return $this->supplyUpdateMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新伙伴标签
     *  *
     * @param SupplyUpdatePartnerTypeRequest $request SupplyUpdatePartnerTypeRequest
     * @param SupplyUpdatePartnerTypeHeaders $headers SupplyUpdatePartnerTypeHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyUpdatePartnerTypeResponse SupplyUpdatePartnerTypeResponse
     */
    public function supplyUpdatePartnerTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->labelId)) {
            $query['labelId'] = $request->labelId;
        }
        if (!Utils::isUnset($request->name)) {
            $query['name'] = $request->name;
        }
        if (!Utils::isUnset($request->superId)) {
            $query['superId'] = $request->superId;
        }
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
            'action'      => 'SupplyUpdatePartnerType',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/partnerLabels',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyUpdatePartnerTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新伙伴标签
     *  *
     * @param SupplyUpdatePartnerTypeRequest $request SupplyUpdatePartnerTypeRequest
     *
     * @return SupplyUpdatePartnerTypeResponse SupplyUpdatePartnerTypeResponse
     */
    public function supplyUpdatePartnerType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyUpdatePartnerTypeHeaders([]);

        return $this->supplyUpdatePartnerTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新角色或角色组
     *  *
     * @param SupplyUpdateRoleRequest $request SupplyUpdateRoleRequest
     * @param SupplyUpdateRoleHeaders $headers SupplyUpdateRoleHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return SupplyUpdateRoleResponse SupplyUpdateRoleResponse
     */
    public function supplyUpdateRoleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->isRoleGroup)) {
            $query['isRoleGroup'] = $request->isRoleGroup;
        }
        if (!Utils::isUnset($request->roleId)) {
            $query['roleId'] = $request->roleId;
        }
        if (!Utils::isUnset($request->roleName)) {
            $query['roleName'] = $request->roleName;
        }
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
            'action'      => 'SupplyUpdateRole',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/supplyChains/roles',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SupplyUpdateRoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新角色或角色组
     *  *
     * @param SupplyUpdateRoleRequest $request SupplyUpdateRoleRequest
     *
     * @return SupplyUpdateRoleResponse SupplyUpdateRoleResponse
     */
    public function supplyUpdateRole($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyUpdateRoleHeaders([]);

        return $this->supplyUpdateRoleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新医疗用户扩展信息
     *  *
     * @param string                      $userId
     * @param UpdateUserExtendInfoRequest $request UpdateUserExtendInfoRequest
     * @param UpdateUserExtendInfoHeaders $headers UpdateUserExtendInfoHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateUserExtendInfoResponse UpdateUserExtendInfoResponse
     */
    public function updateUserExtendInfoWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->comments)) {
            $body['comments'] = $request->comments;
        }
        if (!Utils::isUnset($request->jobCode)) {
            $body['jobCode'] = $request->jobCode;
        }
        if (!Utils::isUnset($request->jobStatusCode)) {
            $body['jobStatusCode'] = $request->jobStatusCode;
        }
        if (!Utils::isUnset($request->userProbCode)) {
            $body['userProbCode'] = $request->userProbCode;
        }
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
            'action'      => 'UpdateUserExtendInfo',
            'version'     => 'industry_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/industry/medicals/users/' . $userId . '/extInfos',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateUserExtendInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新医疗用户扩展信息
     *  *
     * @param string                      $userId
     * @param UpdateUserExtendInfoRequest $request UpdateUserExtendInfoRequest
     *
     * @return UpdateUserExtendInfoResponse UpdateUserExtendInfoResponse
     */
    public function updateUserExtendInfo($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateUserExtendInfoHeaders([]);

        return $this->updateUserExtendInfoWithOptions($userId, $request, $headers, $runtime);
    }
}
