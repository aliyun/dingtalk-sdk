<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
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
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreContactInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreContactInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreConversationsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreConversationsRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreConversationsResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreGroupInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreGroupInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreGroupInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreGroupsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreGroupsResponse;
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
     * @param CampusAddRenterMemberRequest $request
     * @param CampusAddRenterMemberHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return CampusAddRenterMemberResponse
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
     * @param CampusAddRenterMemberRequest $request
     *
     * @return CampusAddRenterMemberResponse
     */
    public function campusAddRenterMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusAddRenterMemberHeaders([]);

        return $this->campusAddRenterMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CampusCreateCampusRequest $request
     * @param CampusCreateCampusHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return CampusCreateCampusResponse
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
     * @param CampusCreateCampusRequest $request
     *
     * @return CampusCreateCampusResponse
     */
    public function campusCreateCampus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusCreateCampusHeaders([]);

        return $this->campusCreateCampusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CampusCreateCampusGroupRequest $request
     * @param CampusCreateCampusGroupHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CampusCreateCampusGroupResponse
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
     * @param CampusCreateCampusGroupRequest $request
     *
     * @return CampusCreateCampusGroupResponse
     */
    public function campusCreateCampusGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusCreateCampusGroupHeaders([]);

        return $this->campusCreateCampusGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CampusCreateRenterRequest $request
     * @param CampusCreateRenterHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return CampusCreateRenterResponse
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
     * @param CampusCreateRenterRequest $request
     *
     * @return CampusCreateRenterResponse
     */
    public function campusCreateRenter($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusCreateRenterHeaders([]);

        return $this->campusCreateRenterWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CampusDelRenterMemberRequest $request
     * @param CampusDelRenterMemberHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return CampusDelRenterMemberResponse
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
     * @param CampusDelRenterMemberRequest $request
     *
     * @return CampusDelRenterMemberResponse
     */
    public function campusDelRenterMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusDelRenterMemberHeaders([]);

        return $this->campusDelRenterMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CampusDeleteCampusGroupRequest $request
     * @param CampusDeleteCampusGroupHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CampusDeleteCampusGroupResponse
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
     * @param CampusDeleteCampusGroupRequest $request
     *
     * @return CampusDeleteCampusGroupResponse
     */
    public function campusDeleteCampusGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusDeleteCampusGroupHeaders([]);

        return $this->campusDeleteCampusGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CampusDeleteRenterRequest $request
     * @param CampusDeleteRenterHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return CampusDeleteRenterResponse
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
     * @param CampusDeleteRenterRequest $request
     *
     * @return CampusDeleteRenterResponse
     */
    public function campusDeleteRenter($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusDeleteRenterHeaders([]);

        return $this->campusDeleteRenterWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CampusGetCampusRequest $request
     * @param CampusGetCampusHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return CampusGetCampusResponse
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
     * @param CampusGetCampusRequest $request
     *
     * @return CampusGetCampusResponse
     */
    public function campusGetCampus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusGetCampusHeaders([]);

        return $this->campusGetCampusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CampusGetCampusGroupRequest $request
     * @param CampusGetCampusGroupHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return CampusGetCampusGroupResponse
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
     * @param CampusGetCampusGroupRequest $request
     *
     * @return CampusGetCampusGroupResponse
     */
    public function campusGetCampusGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusGetCampusGroupHeaders([]);

        return $this->campusGetCampusGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CampusGetRenterRequest $request
     * @param CampusGetRenterHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return CampusGetRenterResponse
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
     * @param CampusGetRenterRequest $request
     *
     * @return CampusGetRenterResponse
     */
    public function campusGetRenter($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusGetRenterHeaders([]);

        return $this->campusGetRenterWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CampusGetRenterMemberRequest $request
     * @param CampusGetRenterMemberHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return CampusGetRenterMemberResponse
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
     * @param CampusGetRenterMemberRequest $request
     *
     * @return CampusGetRenterMemberResponse
     */
    public function campusGetRenterMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusGetRenterMemberHeaders([]);

        return $this->campusGetRenterMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CampusListCampusRequest $request
     * @param CampusListCampusHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return CampusListCampusResponse
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
     * @param CampusListCampusRequest $request
     *
     * @return CampusListCampusResponse
     */
    public function campusListCampus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusListCampusHeaders([]);

        return $this->campusListCampusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CampusListCampusGroupHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return CampusListCampusGroupResponse
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
     * @return CampusListCampusGroupResponse
     */
    public function campusListCampusGroup()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusListCampusGroupHeaders([]);

        return $this->campusListCampusGroupWithOptions($headers, $runtime);
    }

    /**
     * @param CampusListRenterHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return CampusListRenterResponse
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
     * @return CampusListRenterResponse
     */
    public function campusListRenter()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusListRenterHeaders([]);

        return $this->campusListRenterWithOptions($headers, $runtime);
    }

    /**
     * @param CampusListRenterMembersRequest $request
     * @param CampusListRenterMembersHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CampusListRenterMembersResponse
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
     * @param CampusListRenterMembersRequest $request
     *
     * @return CampusListRenterMembersResponse
     */
    public function campusListRenterMembers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusListRenterMembersHeaders([]);

        return $this->campusListRenterMembersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CampusUpdateCampusRequest $request
     * @param CampusUpdateCampusHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return CampusUpdateCampusResponse
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
     * @param CampusUpdateCampusRequest $request
     *
     * @return CampusUpdateCampusResponse
     */
    public function campusUpdateCampus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusUpdateCampusHeaders([]);

        return $this->campusUpdateCampusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CampusUpdateCampusGroupRequest $request
     * @param CampusUpdateCampusGroupHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CampusUpdateCampusGroupResponse
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
     * @param CampusUpdateCampusGroupRequest $request
     *
     * @return CampusUpdateCampusGroupResponse
     */
    public function campusUpdateCampusGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusUpdateCampusGroupHeaders([]);

        return $this->campusUpdateCampusGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CampusUpdateRenterRequest $request
     * @param CampusUpdateRenterHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return CampusUpdateRenterResponse
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
     * @param CampusUpdateRenterRequest $request
     *
     * @return CampusUpdateRenterResponse
     */
    public function campusUpdateRenter($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusUpdateRenterHeaders([]);

        return $this->campusUpdateRenterWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CampusUpdateRenterMemberRequest $request
     * @param CampusUpdateRenterMemberHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return CampusUpdateRenterMemberResponse
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
     * @param CampusUpdateRenterMemberRequest $request
     *
     * @return CampusUpdateRenterMemberResponse
     */
    public function campusUpdateRenterMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CampusUpdateRenterMemberHeaders([]);

        return $this->campusUpdateRenterMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeActiveCollegeDeptGroupRequest $request
     * @param CollegeActiveCollegeDeptGroupHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return CollegeActiveCollegeDeptGroupResponse
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
     * @param CollegeActiveCollegeDeptGroupRequest $request
     *
     * @return CollegeActiveCollegeDeptGroupResponse
     */
    public function collegeActiveCollegeDeptGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeActiveCollegeDeptGroupHeaders([]);

        return $this->collegeActiveCollegeDeptGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeAddCollegeDeptRequest $request
     * @param CollegeAddCollegeDeptHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return CollegeAddCollegeDeptResponse
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
     * @param CollegeAddCollegeDeptRequest $request
     *
     * @return CollegeAddCollegeDeptResponse
     */
    public function collegeAddCollegeDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeAddCollegeDeptHeaders([]);

        return $this->collegeAddCollegeDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeAddManagerRequest $request
     * @param CollegeAddManagerHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return CollegeAddManagerResponse
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
     * @param CollegeAddManagerRequest $request
     *
     * @return CollegeAddManagerResponse
     */
    public function collegeAddManager($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeAddManagerHeaders([]);

        return $this->collegeAddManagerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeAddStudentRequest $request
     * @param CollegeAddStudentHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return CollegeAddStudentResponse
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
     * @param CollegeAddStudentRequest $request
     *
     * @return CollegeAddStudentResponse
     */
    public function collegeAddStudent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeAddStudentHeaders([]);

        return $this->collegeAddStudentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeChangeStudentDeptRequest $request
     * @param CollegeChangeStudentDeptHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return CollegeChangeStudentDeptResponse
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
     * @param CollegeChangeStudentDeptRequest $request
     *
     * @return CollegeChangeStudentDeptResponse
     */
    public function collegeChangeStudentDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeChangeStudentDeptHeaders([]);

        return $this->collegeChangeStudentDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeDeleteCollegeDeptRequest $request
     * @param CollegeDeleteCollegeDeptHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return CollegeDeleteCollegeDeptResponse
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
     * @param CollegeDeleteCollegeDeptRequest $request
     *
     * @return CollegeDeleteCollegeDeptResponse
     */
    public function collegeDeleteCollegeDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeDeleteCollegeDeptHeaders([]);

        return $this->collegeDeleteCollegeDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeListCollegeSubDeptRequest $request
     * @param CollegeListCollegeSubDeptHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return CollegeListCollegeSubDeptResponse
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
     * @param CollegeListCollegeSubDeptRequest $request
     *
     * @return CollegeListCollegeSubDeptResponse
     */
    public function collegeListCollegeSubDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeListCollegeSubDeptHeaders([]);

        return $this->collegeListCollegeSubDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeListDeptManagerRequest $request
     * @param CollegeListDeptManagerHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CollegeListDeptManagerResponse
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
     * @param CollegeListDeptManagerRequest $request
     *
     * @return CollegeListDeptManagerResponse
     */
    public function collegeListDeptManager($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeListDeptManagerHeaders([]);

        return $this->collegeListDeptManagerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeListStudentInfoRequest $request
     * @param CollegeListStudentInfoHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CollegeListStudentInfoResponse
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
     * @param CollegeListStudentInfoRequest $request
     *
     * @return CollegeListStudentInfoResponse
     */
    public function collegeListStudentInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeListStudentInfoHeaders([]);

        return $this->collegeListStudentInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeListUncheckedStudentRequest $request
     * @param CollegeListUncheckedStudentHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return CollegeListUncheckedStudentResponse
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
     * @param CollegeListUncheckedStudentRequest $request
     *
     * @return CollegeListUncheckedStudentResponse
     */
    public function collegeListUncheckedStudent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeListUncheckedStudentHeaders([]);

        return $this->collegeListUncheckedStudentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeQueryCollegeDeptGroupInfoRequest $request
     * @param CollegeQueryCollegeDeptGroupInfoHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return CollegeQueryCollegeDeptGroupInfoResponse
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
     * @param CollegeQueryCollegeDeptGroupInfoRequest $request
     *
     * @return CollegeQueryCollegeDeptGroupInfoResponse
     */
    public function collegeQueryCollegeDeptGroupInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeQueryCollegeDeptGroupInfoHeaders([]);

        return $this->collegeQueryCollegeDeptGroupInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeQueryCollegeDeptInfoRequest $request
     * @param CollegeQueryCollegeDeptInfoHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return CollegeQueryCollegeDeptInfoResponse
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
     * @param CollegeQueryCollegeDeptInfoRequest $request
     *
     * @return CollegeQueryCollegeDeptInfoResponse
     */
    public function collegeQueryCollegeDeptInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeQueryCollegeDeptInfoHeaders([]);

        return $this->collegeQueryCollegeDeptInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeQueryStudentInfoByDeptRequest $request
     * @param CollegeQueryStudentInfoByDeptHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return CollegeQueryStudentInfoByDeptResponse
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
     * @param CollegeQueryStudentInfoByDeptRequest $request
     *
     * @return CollegeQueryStudentInfoByDeptResponse
     */
    public function collegeQueryStudentInfoByDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeQueryStudentInfoByDeptHeaders([]);

        return $this->collegeQueryStudentInfoByDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeQueryStudentInfoByMobileRequest $request
     * @param CollegeQueryStudentInfoByMobileHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return CollegeQueryStudentInfoByMobileResponse
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
     * @param CollegeQueryStudentInfoByMobileRequest $request
     *
     * @return CollegeQueryStudentInfoByMobileResponse
     */
    public function collegeQueryStudentInfoByMobile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeQueryStudentInfoByMobileHeaders([]);

        return $this->collegeQueryStudentInfoByMobileWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeQueryStudentInfoByStudentIdRequest $request
     * @param CollegeQueryStudentInfoByStudentIdHeaders $headers
     * @param RuntimeOptions                            $runtime
     *
     * @return CollegeQueryStudentInfoByStudentIdResponse
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
     * @param CollegeQueryStudentInfoByStudentIdRequest $request
     *
     * @return CollegeQueryStudentInfoByStudentIdResponse
     */
    public function collegeQueryStudentInfoByStudentId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeQueryStudentInfoByStudentIdHeaders([]);

        return $this->collegeQueryStudentInfoByStudentIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeRemoveManagerRequest $request
     * @param CollegeRemoveManagerHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return CollegeRemoveManagerResponse
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
     * @param CollegeRemoveManagerRequest $request
     *
     * @return CollegeRemoveManagerResponse
     */
    public function collegeRemoveManager($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeRemoveManagerHeaders([]);

        return $this->collegeRemoveManagerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeRemoveStudentRequest $request
     * @param CollegeRemoveStudentHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return CollegeRemoveStudentResponse
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
     * @param CollegeRemoveStudentRequest $request
     *
     * @return CollegeRemoveStudentResponse
     */
    public function collegeRemoveStudent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeRemoveStudentHeaders([]);

        return $this->collegeRemoveStudentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeUpdateCollegeDeptRequest $request
     * @param CollegeUpdateCollegeDeptHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return CollegeUpdateCollegeDeptResponse
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
     * @param CollegeUpdateCollegeDeptRequest $request
     *
     * @return CollegeUpdateCollegeDeptResponse
     */
    public function collegeUpdateCollegeDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeUpdateCollegeDeptHeaders([]);

        return $this->collegeUpdateCollegeDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeUpdateStudentDeptInfoRequest $request
     * @param CollegeUpdateStudentDeptInfoHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return CollegeUpdateStudentDeptInfoResponse
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
     * @param CollegeUpdateStudentDeptInfoRequest $request
     *
     * @return CollegeUpdateStudentDeptInfoResponse
     */
    public function collegeUpdateStudentDeptInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeUpdateStudentDeptInfoHeaders([]);

        return $this->collegeUpdateStudentDeptInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeUpdateStudentInfoRequest $request
     * @param CollegeUpdateStudentInfoHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return CollegeUpdateStudentInfoResponse
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
     * @param CollegeUpdateStudentInfoRequest $request
     *
     * @return CollegeUpdateStudentInfoResponse
     */
    public function collegeUpdateStudentInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeUpdateStudentInfoHeaders([]);

        return $this->collegeUpdateStudentInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CollegeUpdateStudentMoblieRequest $request
     * @param CollegeUpdateStudentMoblieHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return CollegeUpdateStudentMoblieResponse
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
     * @param CollegeUpdateStudentMoblieRequest $request
     *
     * @return CollegeUpdateStudentMoblieResponse
     */
    public function collegeUpdateStudentMoblie($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CollegeUpdateStudentMoblieHeaders([]);

        return $this->collegeUpdateStudentMoblieWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactCreateRequest $request
     * @param CustomizeContactCreateHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CustomizeContactCreateResponse
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
     * @param CustomizeContactCreateRequest $request
     *
     * @return CustomizeContactCreateResponse
     */
    public function customizeContactCreate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactCreateHeaders([]);

        return $this->customizeContactCreateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactDeleteRequest $request
     * @param CustomizeContactDeleteHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CustomizeContactDeleteResponse
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
     * @param CustomizeContactDeleteRequest $request
     *
     * @return CustomizeContactDeleteResponse
     */
    public function customizeContactDelete($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeleteHeaders([]);

        return $this->customizeContactDeleteWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactDeptCreateRequest $request
     * @param CustomizeContactDeptCreateHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return CustomizeContactDeptCreateResponse
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
     * @param CustomizeContactDeptCreateRequest $request
     *
     * @return CustomizeContactDeptCreateResponse
     */
    public function customizeContactDeptCreate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptCreateHeaders([]);

        return $this->customizeContactDeptCreateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactDeptDeleteRequest $request
     * @param CustomizeContactDeptDeleteHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return CustomizeContactDeptDeleteResponse
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
     * @param CustomizeContactDeptDeleteRequest $request
     *
     * @return CustomizeContactDeptDeleteResponse
     */
    public function customizeContactDeptDelete($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptDeleteHeaders([]);

        return $this->customizeContactDeptDeleteWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactDeptGroupCreateRequest $request
     * @param CustomizeContactDeptGroupCreateHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return CustomizeContactDeptGroupCreateResponse
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
     * @param CustomizeContactDeptGroupCreateRequest $request
     *
     * @return CustomizeContactDeptGroupCreateResponse
     */
    public function customizeContactDeptGroupCreate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptGroupCreateHeaders([]);

        return $this->customizeContactDeptGroupCreateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactDeptInfoRequest $request
     * @param CustomizeContactDeptInfoHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return CustomizeContactDeptInfoResponse
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
     * @param CustomizeContactDeptInfoRequest $request
     *
     * @return CustomizeContactDeptInfoResponse
     */
    public function customizeContactDeptInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptInfoHeaders([]);

        return $this->customizeContactDeptInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactDeptListRequest $request
     * @param CustomizeContactDeptListHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return CustomizeContactDeptListResponse
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
     * @param CustomizeContactDeptListRequest $request
     *
     * @return CustomizeContactDeptListResponse
     */
    public function customizeContactDeptList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptListHeaders([]);

        return $this->customizeContactDeptListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactDeptUpdateRequest $request
     * @param CustomizeContactDeptUpdateHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return CustomizeContactDeptUpdateResponse
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
     * @param CustomizeContactDeptUpdateRequest $request
     *
     * @return CustomizeContactDeptUpdateResponse
     */
    public function customizeContactDeptUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactDeptUpdateHeaders([]);

        return $this->customizeContactDeptUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactEmpAddRequest $request
     * @param CustomizeContactEmpAddHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CustomizeContactEmpAddResponse
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
     * @param CustomizeContactEmpAddRequest $request
     *
     * @return CustomizeContactEmpAddResponse
     */
    public function customizeContactEmpAdd($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactEmpAddHeaders([]);

        return $this->customizeContactEmpAddWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactEmpDeleteRequest $request
     * @param CustomizeContactEmpDeleteHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return CustomizeContactEmpDeleteResponse
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
     * @param CustomizeContactEmpDeleteRequest $request
     *
     * @return CustomizeContactEmpDeleteResponse
     */
    public function customizeContactEmpDelete($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactEmpDeleteHeaders([]);

        return $this->customizeContactEmpDeleteWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactEmpListRequest $request
     * @param CustomizeContactEmpListHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CustomizeContactEmpListResponse
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
     * @param CustomizeContactEmpListRequest $request
     *
     * @return CustomizeContactEmpListResponse
     */
    public function customizeContactEmpList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactEmpListHeaders([]);

        return $this->customizeContactEmpListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CustomizeContactListHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return CustomizeContactListResponse
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
     * @return CustomizeContactListResponse
     */
    public function customizeContactList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactListHeaders([]);

        return $this->customizeContactListWithOptions($headers, $runtime);
    }

    /**
     * @param CustomizeContactUpdateRequest $request
     * @param CustomizeContactUpdateHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CustomizeContactUpdateResponse
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
     * @param CustomizeContactUpdateRequest $request
     *
     * @return CustomizeContactUpdateResponse
     */
    public function customizeContactUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CustomizeContactUpdateHeaders([]);

        return $this->customizeContactUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DIgitalStoreMessagePushRequest $tmpReq
     * @param DIgitalStoreMessagePushHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return DIgitalStoreMessagePushResponse
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
     * @param DIgitalStoreMessagePushRequest $request
     *
     * @return DIgitalStoreMessagePushResponse
     */
    public function dIgitalStoreMessagePush($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DIgitalStoreMessagePushHeaders([]);

        return $this->dIgitalStoreMessagePushWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DigitalStoreContactInfoHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return DigitalStoreContactInfoResponse
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
     * @return DigitalStoreContactInfoResponse
     */
    public function digitalStoreContactInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreContactInfoHeaders([]);

        return $this->digitalStoreContactInfoWithOptions($headers, $runtime);
    }

    /**
     * @param DigitalStoreConversationsRequest $request
     * @param DigitalStoreConversationsHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return DigitalStoreConversationsResponse
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
     * @param DigitalStoreConversationsRequest $request
     *
     * @return DigitalStoreConversationsResponse
     */
    public function digitalStoreConversations($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreConversationsHeaders([]);

        return $this->digitalStoreConversationsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DigitalStoreGroupInfoRequest $request
     * @param DigitalStoreGroupInfoHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return DigitalStoreGroupInfoResponse
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
     * @param DigitalStoreGroupInfoRequest $request
     *
     * @return DigitalStoreGroupInfoResponse
     */
    public function digitalStoreGroupInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreGroupInfoHeaders([]);

        return $this->digitalStoreGroupInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DigitalStoreGroupsHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return DigitalStoreGroupsResponse
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
     * @return DigitalStoreGroupsResponse
     */
    public function digitalStoreGroups()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreGroupsHeaders([]);

        return $this->digitalStoreGroupsWithOptions($headers, $runtime);
    }

    /**
     * @param DigitalStoreNodeInfoRequest $request
     * @param DigitalStoreNodeInfoHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return DigitalStoreNodeInfoResponse
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
     * @param DigitalStoreNodeInfoRequest $request
     *
     * @return DigitalStoreNodeInfoResponse
     */
    public function digitalStoreNodeInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreNodeInfoHeaders([]);

        return $this->digitalStoreNodeInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DigitalStoreRightsInfoHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return DigitalStoreRightsInfoResponse
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
     * @return DigitalStoreRightsInfoResponse
     */
    public function digitalStoreRightsInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreRightsInfoHeaders([]);

        return $this->digitalStoreRightsInfoWithOptions($headers, $runtime);
    }

    /**
     * @param DigitalStoreRolesHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return DigitalStoreRolesResponse
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
     * @return DigitalStoreRolesResponse
     */
    public function digitalStoreRoles()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreRolesHeaders([]);

        return $this->digitalStoreRolesWithOptions($headers, $runtime);
    }

    /**
     * @param DigitalStoreSceneScopeRequest $request
     * @param DigitalStoreSceneScopeHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return DigitalStoreSceneScopeResponse
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
     * @param DigitalStoreSceneScopeRequest $request
     *
     * @return DigitalStoreSceneScopeResponse
     */
    public function digitalStoreSceneScope($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreSceneScopeHeaders([]);

        return $this->digitalStoreSceneScopeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DigitalStoreStoreInfoRequest $request
     * @param DigitalStoreStoreInfoHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return DigitalStoreStoreInfoResponse
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
     * @param DigitalStoreStoreInfoRequest $request
     *
     * @return DigitalStoreStoreInfoResponse
     */
    public function digitalStoreStoreInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreStoreInfoHeaders([]);

        return $this->digitalStoreStoreInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DigitalStoreSubNodesRequest $request
     * @param DigitalStoreSubNodesHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return DigitalStoreSubNodesResponse
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
     * @param DigitalStoreSubNodesRequest $request
     *
     * @return DigitalStoreSubNodesResponse
     */
    public function digitalStoreSubNodes($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreSubNodesHeaders([]);

        return $this->digitalStoreSubNodesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DigitalStoreUpdateAuthInfoRequest $request
     * @param DigitalStoreUpdateAuthInfoHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return DigitalStoreUpdateAuthInfoResponse
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
     * @param DigitalStoreUpdateAuthInfoRequest $request
     *
     * @return DigitalStoreUpdateAuthInfoResponse
     */
    public function digitalStoreUpdateAuthInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreUpdateAuthInfoHeaders([]);

        return $this->digitalStoreUpdateAuthInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DigitalStoreUserInfoRequest $request
     * @param DigitalStoreUserInfoHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return DigitalStoreUserInfoResponse
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
     * @param DigitalStoreUserInfoRequest $request
     *
     * @return DigitalStoreUserInfoResponse
     */
    public function digitalStoreUserInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreUserInfoHeaders([]);

        return $this->digitalStoreUserInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DigitalStoreUsersRequest $request
     * @param DigitalStoreUsersHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return DigitalStoreUsersResponse
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
     * @param DigitalStoreUsersRequest $request
     *
     * @return DigitalStoreUsersResponse
     */
    public function digitalStoreUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DigitalStoreUsersHeaders([]);

        return $this->digitalStoreUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ExternalQueryExternalAppOrgsRequest $request
     * @param ExternalQueryExternalAppOrgsHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return ExternalQueryExternalAppOrgsResponse
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
     * @param ExternalQueryExternalAppOrgsRequest $request
     *
     * @return ExternalQueryExternalAppOrgsResponse
     */
    public function externalQueryExternalAppOrgs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExternalQueryExternalAppOrgsHeaders([]);

        return $this->externalQueryExternalAppOrgsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ExternalQueryExternalBelongMainOrgRequest $request
     * @param ExternalQueryExternalBelongMainOrgHeaders $headers
     * @param RuntimeOptions                            $runtime
     *
     * @return ExternalQueryExternalBelongMainOrgResponse
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
     * @param ExternalQueryExternalBelongMainOrgRequest $request
     *
     * @return ExternalQueryExternalBelongMainOrgResponse
     */
    public function externalQueryExternalBelongMainOrg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExternalQueryExternalBelongMainOrgHeaders([]);

        return $this->externalQueryExternalBelongMainOrgWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ExternalQueryExternalOrgsRequest $request
     * @param ExternalQueryExternalOrgsHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return ExternalQueryExternalOrgsResponse
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
     * @param ExternalQueryExternalOrgsRequest $request
     *
     * @return ExternalQueryExternalOrgsResponse
     */
    public function externalQueryExternalOrgs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExternalQueryExternalOrgsHeaders([]);

        return $this->externalQueryExternalOrgsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HospitalDataCheckRequest $request
     * @param HospitalDataCheckHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return HospitalDataCheckResponse
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
     * @param HospitalDataCheckRequest $request
     *
     * @return HospitalDataCheckResponse
     */
    public function hospitalDataCheck($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HospitalDataCheckHeaders([]);

        return $this->hospitalDataCheckWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureCommonEventRequest $request
     * @param IndustryManufactureCommonEventHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return IndustryManufactureCommonEventResponse
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
     * @param IndustryManufactureCommonEventRequest $request
     *
     * @return IndustryManufactureCommonEventResponse
     */
    public function industryManufactureCommonEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureCommonEventHeaders([]);

        return $this->industryManufactureCommonEventWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureCostRecordListGetRequest $request
     * @param IndustryManufactureCostRecordListGetHeaders $headers
     * @param RuntimeOptions                              $runtime
     *
     * @return IndustryManufactureCostRecordListGetResponse
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
     * @param IndustryManufactureCostRecordListGetRequest $request
     *
     * @return IndustryManufactureCostRecordListGetResponse
     */
    public function industryManufactureCostRecordListGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureCostRecordListGetHeaders([]);

        return $this->industryManufactureCostRecordListGetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureFeeListGetRequest $request
     * @param IndustryManufactureFeeListGetHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return IndustryManufactureFeeListGetResponse
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
     * @param IndustryManufactureFeeListGetRequest $request
     *
     * @return IndustryManufactureFeeListGetResponse
     */
    public function industryManufactureFeeListGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureFeeListGetHeaders([]);

        return $this->industryManufactureFeeListGetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureLabourCostRequest $request
     * @param IndustryManufactureLabourCostHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return IndustryManufactureLabourCostResponse
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
     * @param IndustryManufactureLabourCostRequest $request
     *
     * @return IndustryManufactureLabourCostResponse
     */
    public function industryManufactureLabourCost($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureLabourCostHeaders([]);

        return $this->industryManufactureLabourCostWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureMaterialListRequest $request
     * @param IndustryManufactureMaterialListHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return IndustryManufactureMaterialListResponse
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
     * @param IndustryManufactureMaterialListRequest $request
     *
     * @return IndustryManufactureMaterialListResponse
     */
    public function industryManufactureMaterialList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMaterialListHeaders([]);

        return $this->industryManufactureMaterialListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureMesDispatchTaskRequest $request
     * @param IndustryManufactureMesDispatchTaskHeaders $headers
     * @param RuntimeOptions                            $runtime
     *
     * @return IndustryManufactureMesDispatchTaskResponse
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
     * @param IndustryManufactureMesDispatchTaskRequest $request
     *
     * @return IndustryManufactureMesDispatchTaskResponse
     */
    public function industryManufactureMesDispatchTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesDispatchTaskHeaders([]);

        return $this->industryManufactureMesDispatchTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureMesMaterialRequest $request
     * @param IndustryManufactureMesMaterialHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return IndustryManufactureMesMaterialResponse
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
     * @param IndustryManufactureMesMaterialRequest $request
     *
     * @return IndustryManufactureMesMaterialResponse
     */
    public function industryManufactureMesMaterial($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesMaterialHeaders([]);

        return $this->industryManufactureMesMaterialWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureMesOutPlanRequest $request
     * @param IndustryManufactureMesOutPlanHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return IndustryManufactureMesOutPlanResponse
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
     * @param IndustryManufactureMesOutPlanRequest $request
     *
     * @return IndustryManufactureMesOutPlanResponse
     */
    public function industryManufactureMesOutPlan($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesOutPlanHeaders([]);

        return $this->industryManufactureMesOutPlanWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureMesOutputRequest $request
     * @param IndustryManufactureMesOutputHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return IndustryManufactureMesOutputResponse
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
     * @param IndustryManufactureMesOutputRequest $request
     *
     * @return IndustryManufactureMesOutputResponse
     */
    public function industryManufactureMesOutput($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesOutputHeaders([]);

        return $this->industryManufactureMesOutputWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureMesProcessRequest $request
     * @param IndustryManufactureMesProcessHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return IndustryManufactureMesProcessResponse
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
     * @param IndustryManufactureMesProcessRequest $request
     *
     * @return IndustryManufactureMesProcessResponse
     */
    public function industryManufactureMesProcess($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesProcessHeaders([]);

        return $this->industryManufactureMesProcessWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureMesProductionPlanRequest $request
     * @param IndustryManufactureMesProductionPlanHeaders $headers
     * @param RuntimeOptions                              $runtime
     *
     * @return IndustryManufactureMesProductionPlanResponse
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
     * @param IndustryManufactureMesProductionPlanRequest $request
     *
     * @return IndustryManufactureMesProductionPlanResponse
     */
    public function industryManufactureMesProductionPlan($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesProductionPlanHeaders([]);

        return $this->industryManufactureMesProductionPlanWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureMesSubCooperationTeamRequest $request
     * @param IndustryManufactureMesSubCooperationTeamHeaders $headers
     * @param RuntimeOptions                                  $runtime
     *
     * @return IndustryManufactureMesSubCooperationTeamResponse
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
     * @param IndustryManufactureMesSubCooperationTeamRequest $request
     *
     * @return IndustryManufactureMesSubCooperationTeamResponse
     */
    public function industryManufactureMesSubCooperationTeam($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesSubCooperationTeamHeaders([]);

        return $this->industryManufactureMesSubCooperationTeamWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryManufactureMesTeamMgmtRequest $request
     * @param IndustryManufactureMesTeamMgmtHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return IndustryManufactureMesTeamMgmtResponse
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
     * @param IndustryManufactureMesTeamMgmtRequest $request
     *
     * @return IndustryManufactureMesTeamMgmtResponse
     */
    public function industryManufactureMesTeamMgmt($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryManufactureMesTeamMgmtHeaders([]);

        return $this->industryManufactureMesTeamMgmtWithOptions($request, $headers, $runtime);
    }

    /**
     * @param IndustryMmanufactureMaterialCostGetRequest $request
     * @param IndustryMmanufactureMaterialCostGetHeaders $headers
     * @param RuntimeOptions                             $runtime
     *
     * @return IndustryMmanufactureMaterialCostGetResponse
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
     * @param IndustryMmanufactureMaterialCostGetRequest $request
     *
     * @return IndustryMmanufactureMaterialCostGetResponse
     */
    public function industryMmanufactureMaterialCostGet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IndustryMmanufactureMaterialCostGetHeaders([]);

        return $this->industryMmanufactureMaterialCostGetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PushDingMessageRequest $request
     * @param PushDingMessageHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return PushDingMessageResponse
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
     * @param PushDingMessageRequest $request
     *
     * @return PushDingMessageResponse
     */
    public function pushDingMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PushDingMessageHeaders([]);

        return $this->pushDingMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllDepartmentRequest $request
     * @param QueryAllDepartmentHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryAllDepartmentResponse
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
     * @param QueryAllDepartmentRequest $request
     *
     * @return QueryAllDepartmentResponse
     */
    public function queryAllDepartment($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllDepartmentHeaders([]);

        return $this->queryAllDepartmentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllDoctorsRequest $request
     * @param QueryAllDoctorsHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return QueryAllDoctorsResponse
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
     * @param QueryAllDoctorsRequest $request
     *
     * @return QueryAllDoctorsResponse
     */
    public function queryAllDoctors($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllDoctorsHeaders([]);

        return $this->queryAllDoctorsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllGroupRequest $request
     * @param QueryAllGroupHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return QueryAllGroupResponse
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
     * @param QueryAllGroupRequest $request
     *
     * @return QueryAllGroupResponse
     */
    public function queryAllGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllGroupHeaders([]);

        return $this->queryAllGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                      $deptId
     * @param QueryAllGroupsInDeptRequest $request
     * @param QueryAllGroupsInDeptHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryAllGroupsInDeptResponse
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
     * @param string                      $deptId
     * @param QueryAllGroupsInDeptRequest $request
     *
     * @return QueryAllGroupsInDeptResponse
     */
    public function queryAllGroupsInDept($deptId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllGroupsInDeptHeaders([]);

        return $this->queryAllGroupsInDeptWithOptions($deptId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $deptId
     * @param QueryAllMemberByDeptRequest $request
     * @param QueryAllMemberByDeptHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryAllMemberByDeptResponse
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
     * @param string                      $deptId
     * @param QueryAllMemberByDeptRequest $request
     *
     * @return QueryAllMemberByDeptResponse
     */
    public function queryAllMemberByDept($deptId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllMemberByDeptHeaders([]);

        return $this->queryAllMemberByDeptWithOptions($deptId, $request, $headers, $runtime);
    }

    /**
     * @param string                       $groupId
     * @param QueryAllMemberByGroupRequest $request
     * @param QueryAllMemberByGroupHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return QueryAllMemberByGroupResponse
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
     * @param string                       $groupId
     * @param QueryAllMemberByGroupRequest $request
     *
     * @return QueryAllMemberByGroupResponse
     */
    public function queryAllMemberByGroup($groupId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllMemberByGroupHeaders([]);

        return $this->queryAllMemberByGroupWithOptions($groupId, $request, $headers, $runtime);
    }

    /**
     * @param QueryBizOptLogRequest $request
     * @param QueryBizOptLogHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryBizOptLogResponse
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
     * @param QueryBizOptLogRequest $request
     *
     * @return QueryBizOptLogResponse
     */
    public function queryBizOptLog($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBizOptLogHeaders([]);

        return $this->queryBizOptLogWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDepartmentExtendInfoRequest $request
     * @param QueryDepartmentExtendInfoHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryDepartmentExtendInfoResponse
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
     * @param QueryDepartmentExtendInfoRequest $request
     *
     * @return QueryDepartmentExtendInfoResponse
     */
    public function queryDepartmentExtendInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDepartmentExtendInfoHeaders([]);

        return $this->queryDepartmentExtendInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                     $deptId
     * @param QueryDepartmentInfoHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryDepartmentInfoResponse
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
     * @param string $deptId
     *
     * @return QueryDepartmentInfoResponse
     */
    public function queryDepartmentInfo($deptId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDepartmentInfoHeaders([]);

        return $this->queryDepartmentInfoWithOptions($deptId, $headers, $runtime);
    }

    /**
     * @param string                               $jobNumber
     * @param QueryDoctorDetailsByJobNumberRequest $request
     * @param QueryDoctorDetailsByJobNumberHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return QueryDoctorDetailsByJobNumberResponse
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
     * @param string                               $jobNumber
     * @param QueryDoctorDetailsByJobNumberRequest $request
     *
     * @return QueryDoctorDetailsByJobNumberResponse
     */
    public function queryDoctorDetailsByJobNumber($jobNumber, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDoctorDetailsByJobNumberHeaders([]);

        return $this->queryDoctorDetailsByJobNumberWithOptions($jobNumber, $request, $headers, $runtime);
    }

    /**
     * @param string                $groupId
     * @param QueryGroupInfoHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryGroupInfoResponse
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
     * @param string $groupId
     *
     * @return QueryGroupInfoResponse
     */
    public function queryGroupInfo($groupId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupInfoHeaders([]);

        return $this->queryGroupInfoWithOptions($groupId, $headers, $runtime);
    }

    /**
     * @param QueryHospitalDistrictInfoRequest $request
     * @param QueryHospitalDistrictInfoHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryHospitalDistrictInfoResponse
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
     * @param QueryHospitalDistrictInfoRequest $request
     *
     * @return QueryHospitalDistrictInfoResponse
     */
    public function queryHospitalDistrictInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHospitalDistrictInfoHeaders([]);

        return $this->queryHospitalDistrictInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryHospitalRoleUserInfoRequest $request
     * @param QueryHospitalRoleUserInfoHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryHospitalRoleUserInfoResponse
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
     * @param QueryHospitalRoleUserInfoRequest $request
     *
     * @return QueryHospitalRoleUserInfoResponse
     */
    public function queryHospitalRoleUserInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHospitalRoleUserInfoHeaders([]);

        return $this->queryHospitalRoleUserInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryHospitalRolesHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryHospitalRolesResponse
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
     * @return QueryHospitalRolesResponse
     */
    public function queryHospitalRoles()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHospitalRolesHeaders([]);

        return $this->queryHospitalRolesWithOptions($headers, $runtime);
    }

    /**
     * @param QueryJobCodeDictionaryHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return QueryJobCodeDictionaryResponse
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
     * @return QueryJobCodeDictionaryResponse
     */
    public function queryJobCodeDictionary()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryJobCodeDictionaryHeaders([]);

        return $this->queryJobCodeDictionaryWithOptions($headers, $runtime);
    }

    /**
     * @param QueryJobStatusCodeDictionaryHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryJobStatusCodeDictionaryResponse
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
     * @return QueryJobStatusCodeDictionaryResponse
     */
    public function queryJobStatusCodeDictionary()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryJobStatusCodeDictionaryHeaders([]);

        return $this->queryJobStatusCodeDictionaryWithOptions($headers, $runtime);
    }

    /**
     * @param QueryMedicalEventsHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryMedicalEventsResponse
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
     * @return QueryMedicalEventsResponse
     */
    public function queryMedicalEvents()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMedicalEventsHeaders([]);

        return $this->queryMedicalEventsWithOptions($headers, $runtime);
    }

    /**
     * @param QueryUserCredentialsRequest $request
     * @param QueryUserCredentialsHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryUserCredentialsResponse
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
     * @param QueryUserCredentialsRequest $request
     *
     * @return QueryUserCredentialsResponse
     */
    public function queryUserCredentials($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserCredentialsHeaders([]);

        return $this->queryUserCredentialsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                  $userId
     * @param QueryUserExtInfoHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QueryUserExtInfoResponse
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
     * @param string $userId
     *
     * @return QueryUserExtInfoResponse
     */
    public function queryUserExtInfo($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserExtInfoHeaders([]);

        return $this->queryUserExtInfoWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param QueryUserExtendValuesRequest $request
     * @param QueryUserExtendValuesHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return QueryUserExtendValuesResponse
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
     * @param QueryUserExtendValuesRequest $request
     *
     * @return QueryUserExtendValuesResponse
     */
    public function queryUserExtendValues($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserExtendValuesHeaders([]);

        return $this->queryUserExtendValuesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string               $userId
     * @param QueryUserInfoRequest $request
     * @param QueryUserInfoHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return QueryUserInfoResponse
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
     * @param string               $userId
     * @param QueryUserInfoRequest $request
     *
     * @return QueryUserInfoResponse
     */
    public function queryUserInfo($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserInfoHeaders([]);

        return $this->queryUserInfoWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param QueryUserProbCodeDictionaryHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return QueryUserProbCodeDictionaryResponse
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
     * @return QueryUserProbCodeDictionaryResponse
     */
    public function queryUserProbCodeDictionary()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserProbCodeDictionaryHeaders([]);

        return $this->queryUserProbCodeDictionaryWithOptions($headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param QueryUserRolesHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryUserRolesResponse
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
     * @param string $userId
     *
     * @return QueryUserRolesResponse
     */
    public function queryUserRoles($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserRolesHeaders([]);

        return $this->queryUserRolesWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string                      $userId
     * @param SaveUserExtendValuesRequest $request
     * @param SaveUserExtendValuesHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return SaveUserExtendValuesResponse
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
     * @param string                      $userId
     * @param SaveUserExtendValuesRequest $request
     *
     * @return SaveUserExtendValuesResponse
     */
    public function saveUserExtendValues($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveUserExtendValuesHeaders([]);

        return $this->saveUserExtendValuesWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param SupplAddRoleRequest $request
     * @param SupplAddRoleHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return SupplAddRoleResponse
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
     * @param SupplAddRoleRequest $request
     *
     * @return SupplAddRoleResponse
     */
    public function supplAddRole($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplAddRoleHeaders([]);

        return $this->supplAddRoleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyAddDeptRequest $request
     * @param SupplyAddDeptHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return SupplyAddDeptResponse
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
     * @param SupplyAddDeptRequest $request
     *
     * @return SupplyAddDeptResponse
     */
    public function supplyAddDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyAddDeptHeaders([]);

        return $this->supplyAddDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyAddMemberRequest $request
     * @param SupplyAddMemberHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return SupplyAddMemberResponse
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
     * @param SupplyAddMemberRequest $request
     *
     * @return SupplyAddMemberResponse
     */
    public function supplyAddMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyAddMemberHeaders([]);

        return $this->supplyAddMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyAddPartnerAdminsRequest $request
     * @param SupplyAddPartnerAdminsHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return SupplyAddPartnerAdminsResponse
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
     * @param SupplyAddPartnerAdminsRequest $request
     *
     * @return SupplyAddPartnerAdminsResponse
     */
    public function supplyAddPartnerAdmins($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyAddPartnerAdminsHeaders([]);

        return $this->supplyAddPartnerAdminsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyAddPartnerManagersRequest $request
     * @param SupplyAddPartnerManagersHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return SupplyAddPartnerManagersResponse
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
     * @param SupplyAddPartnerManagersRequest $request
     *
     * @return SupplyAddPartnerManagersResponse
     */
    public function supplyAddPartnerManagers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyAddPartnerManagersHeaders([]);

        return $this->supplyAddPartnerManagersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyAddPartnerTypeRequest $request
     * @param SupplyAddPartnerTypeHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return SupplyAddPartnerTypeResponse
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
     * @param SupplyAddPartnerTypeRequest $request
     *
     * @return SupplyAddPartnerTypeResponse
     */
    public function supplyAddPartnerType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyAddPartnerTypeHeaders([]);

        return $this->supplyAddPartnerTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyChainDeleteDeptRequest $request
     * @param SupplyChainDeleteDeptHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return SupplyChainDeleteDeptResponse
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
     * @param SupplyChainDeleteDeptRequest $request
     *
     * @return SupplyChainDeleteDeptResponse
     */
    public function supplyChainDeleteDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyChainDeleteDeptHeaders([]);

        return $this->supplyChainDeleteDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyChainQueryDeptInfoRequest $request
     * @param SupplyChainQueryDeptInfoHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return SupplyChainQueryDeptInfoResponse
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
     * @param SupplyChainQueryDeptInfoRequest $request
     *
     * @return SupplyChainQueryDeptInfoResponse
     */
    public function supplyChainQueryDeptInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyChainQueryDeptInfoHeaders([]);

        return $this->supplyChainQueryDeptInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyChainUpdateDeptInfoRequest $request
     * @param SupplyChainUpdateDeptInfoHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return SupplyChainUpdateDeptInfoResponse
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
     * @param SupplyChainUpdateDeptInfoRequest $request
     *
     * @return SupplyChainUpdateDeptInfoResponse
     */
    public function supplyChainUpdateDeptInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyChainUpdateDeptInfoHeaders([]);

        return $this->supplyChainUpdateDeptInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyDeleteMemberRequest $request
     * @param SupplyDeleteMemberHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return SupplyDeleteMemberResponse
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
     * @param SupplyDeleteMemberRequest $request
     *
     * @return SupplyDeleteMemberResponse
     */
    public function supplyDeleteMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyDeleteMemberHeaders([]);

        return $this->supplyDeleteMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyDeletePartnerAdminsRequest $request
     * @param SupplyDeletePartnerAdminsHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return SupplyDeletePartnerAdminsResponse
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
     * @param SupplyDeletePartnerAdminsRequest $request
     *
     * @return SupplyDeletePartnerAdminsResponse
     */
    public function supplyDeletePartnerAdmins($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyDeletePartnerAdminsHeaders([]);

        return $this->supplyDeletePartnerAdminsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyDeletePartnerManagersRequest $request
     * @param SupplyDeletePartnerManagersHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return SupplyDeletePartnerManagersResponse
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
     * @param SupplyDeletePartnerManagersRequest $request
     *
     * @return SupplyDeletePartnerManagersResponse
     */
    public function supplyDeletePartnerManagers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyDeletePartnerManagersHeaders([]);

        return $this->supplyDeletePartnerManagersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyDeletePartnerTypeRequest $request
     * @param SupplyDeletePartnerTypeHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return SupplyDeletePartnerTypeResponse
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
     * @param SupplyDeletePartnerTypeRequest $request
     *
     * @return SupplyDeletePartnerTypeResponse
     */
    public function supplyDeletePartnerType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyDeletePartnerTypeHeaders([]);

        return $this->supplyDeletePartnerTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyDeleteRoleRequest $request
     * @param SupplyDeleteRoleHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return SupplyDeleteRoleResponse
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
     * @param SupplyDeleteRoleRequest $request
     *
     * @return SupplyDeleteRoleResponse
     */
    public function supplyDeleteRole($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyDeleteRoleHeaders([]);

        return $this->supplyDeleteRoleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyGetMemberRequest $request
     * @param SupplyGetMemberHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return SupplyGetMemberResponse
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
     * @param SupplyGetMemberRequest $request
     *
     * @return SupplyGetMemberResponse
     */
    public function supplyGetMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyGetMemberHeaders([]);

        return $this->supplyGetMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyListDeptMembersRequest $request
     * @param SupplyListDeptMembersHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return SupplyListDeptMembersResponse
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
     * @param SupplyListDeptMembersRequest $request
     *
     * @return SupplyListDeptMembersResponse
     */
    public function supplyListDeptMembers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyListDeptMembersHeaders([]);

        return $this->supplyListDeptMembersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyListPartnerAdminsRequest $request
     * @param SupplyListPartnerAdminsHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return SupplyListPartnerAdminsResponse
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
     * @param SupplyListPartnerAdminsRequest $request
     *
     * @return SupplyListPartnerAdminsResponse
     */
    public function supplyListPartnerAdmins($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyListPartnerAdminsHeaders([]);

        return $this->supplyListPartnerAdminsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyListPartnerManagersRequest $request
     * @param SupplyListPartnerManagersHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return SupplyListPartnerManagersResponse
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
     * @param SupplyListPartnerManagersRequest $request
     *
     * @return SupplyListPartnerManagersResponse
     */
    public function supplyListPartnerManagers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyListPartnerManagersHeaders([]);

        return $this->supplyListPartnerManagersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyListPartnerTypeRequest $request
     * @param SupplyListPartnerTypeHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return SupplyListPartnerTypeResponse
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
     * @param SupplyListPartnerTypeRequest $request
     *
     * @return SupplyListPartnerTypeResponse
     */
    public function supplyListPartnerType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyListPartnerTypeHeaders([]);

        return $this->supplyListPartnerTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyListRoleRequest $request
     * @param SupplyListRoleHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SupplyListRoleResponse
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
     * @param SupplyListRoleRequest $request
     *
     * @return SupplyListRoleResponse
     */
    public function supplyListRole($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyListRoleHeaders([]);

        return $this->supplyListRoleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyListSubDeptRequest $request
     * @param SupplyListSubDeptHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return SupplyListSubDeptResponse
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
     * @param SupplyListSubDeptRequest $request
     *
     * @return SupplyListSubDeptResponse
     */
    public function supplyListSubDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyListSubDeptHeaders([]);

        return $this->supplyListSubDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyQueryPartnerTypeRequest $request
     * @param SupplyQueryPartnerTypeHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return SupplyQueryPartnerTypeResponse
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
     * @param SupplyQueryPartnerTypeRequest $request
     *
     * @return SupplyQueryPartnerTypeResponse
     */
    public function supplyQueryPartnerType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyQueryPartnerTypeHeaders([]);

        return $this->supplyQueryPartnerTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyUpdateMemberRequest $request
     * @param SupplyUpdateMemberHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return SupplyUpdateMemberResponse
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
     * @param SupplyUpdateMemberRequest $request
     *
     * @return SupplyUpdateMemberResponse
     */
    public function supplyUpdateMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyUpdateMemberHeaders([]);

        return $this->supplyUpdateMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyUpdatePartnerTypeRequest $request
     * @param SupplyUpdatePartnerTypeHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return SupplyUpdatePartnerTypeResponse
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
     * @param SupplyUpdatePartnerTypeRequest $request
     *
     * @return SupplyUpdatePartnerTypeResponse
     */
    public function supplyUpdatePartnerType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyUpdatePartnerTypeHeaders([]);

        return $this->supplyUpdatePartnerTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SupplyUpdateRoleRequest $request
     * @param SupplyUpdateRoleHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return SupplyUpdateRoleResponse
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
     * @param SupplyUpdateRoleRequest $request
     *
     * @return SupplyUpdateRoleResponse
     */
    public function supplyUpdateRole($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SupplyUpdateRoleHeaders([]);

        return $this->supplyUpdateRoleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                      $userId
     * @param UpdateUserExtendInfoRequest $request
     * @param UpdateUserExtendInfoHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return UpdateUserExtendInfoResponse
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
     * @param string                      $userId
     * @param UpdateUserExtendInfoRequest $request
     *
     * @return UpdateUserExtendInfoResponse
     */
    public function updateUserExtendInfo($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateUserExtendInfoHeaders([]);

        return $this->updateUserExtendInfoWithOptions($userId, $request, $headers, $runtime);
    }
}
