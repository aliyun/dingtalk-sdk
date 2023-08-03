<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ActivateDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ActivateDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ActivateDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddSchoolConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddSchoolConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddSchoolConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AssignClassHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AssignClassRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AssignClassResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchOrgCreateHWHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchOrgCreateHWRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchOrgCreateHWResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelSnsOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelSnsOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelSnsOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelUserOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelUserOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelUserOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CheckRestrictionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CheckRestrictionRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CheckRestrictionResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ConsumePointHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ConsumePointRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ConsumePointResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CourseSchedulingComplimentNoticeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CourseSchedulingComplimentNoticeRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CourseSchedulingComplimentNoticeResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateAppOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateAppOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateAppOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomClassHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomClassRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomClassResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateEduAssetSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateEduAssetSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateEduAssetSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateFulfilRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateFulfilRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateFulfilRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateInviteUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateInviteUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateInviteUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateItemHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateItemRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateItemResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateOrderFlowHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateOrderFlowRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateOrderFlowResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreatePhysicalClassroomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreatePhysicalClassroomRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreatePhysicalClassroomResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateRefundFlowHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateRefundFlowRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateRefundFlowResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateRemoteClassCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateRemoteClassCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateRemoteClassCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSnsAppOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSnsAppOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSnsAppOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateStsTokenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateStsTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateStsTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateTokenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityStudentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityStudentRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityStudentResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityTeacherHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityTeacherRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityTeacherResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeactivateDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeactivateDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeactivateDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeductPointHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeductPointRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeductPointResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeviceOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeviceOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeviceOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteGuardianHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteGuardianRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteGuardianResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteOrgRelationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteOrgRelationRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteOrgRelationResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeletePhysicalClassroomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeletePhysicalClassroomRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeletePhysicalClassroomResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteRemoteClassCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteRemoteClassCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteRemoteClassCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteStudentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteStudentRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteStudentResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteTeacherHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteTeacherRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteTeacherResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteUniversityCourseGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteUniversityCourseGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteUniversityCourseGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteUniversityStudentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteUniversityStudentRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteUniversityStudentResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteUniversityTeacherHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteUniversityTeacherRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteUniversityTeacherResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeviceHeartbeatHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeviceHeartbeatRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeviceHeartbeatResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduTeacherListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduTeacherListRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduTeacherListResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EndCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EndCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EndCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetBindChildInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetBindChildInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetBindChildInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetDefaultChildHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetDefaultChildResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetEduUserIdentityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetEduUserIdentityRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetEduUserIdentityResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCourseDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCourseDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCoursesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCoursesRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCoursesResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetPointActionRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetPointActionRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetPointActionRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetPointInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetPointInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetPointInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetRemoteClassCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetRemoteClassCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetRemoteClassCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetShareRoleMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetShareRoleMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetShareRolesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetShareRolesResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetTaskListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetTaskListRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetTaskListResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetTaskStudentListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetTaskStudentListRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetTaskStudentListResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitCoursesOfClassHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitCoursesOfClassRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitCoursesOfClassResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitVPaasDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitVPaasDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitVPaasDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InsertSectionConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InsertSectionConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InsertSectionConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\MoveStudentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\MoveStudentRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\MoveStudentResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PageQueryDevicesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PageQueryDevicesRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PageQueryDevicesResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PayOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PayOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PayOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PollingConfirmStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PollingConfirmStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PollingConfirmStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PreDialHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PreDialRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PreDialResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ProvidePointHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ProvidePointRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ProvidePointResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleByTimeSchoolHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleByTimeSchoolRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleByTimeSchoolResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleConfigShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryDeviceListByCorpIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryDeviceListByCorpIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryDeviceListByCorpIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryEduAssetSpacesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryEduAssetSpacesRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryEduAssetSpacesResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryGroupIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryGroupIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryGroupIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgRelationListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgRelationListRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgRelationListResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgSecretKeyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgSecretKeyRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgSecretKeyResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryPayResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryPayResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryPayResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryPhysicalClassroomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryPhysicalClassroomRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryPhysicalClassroomResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryPurchaseInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryPurchaseInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryPurchaseInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryRemoteClassCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryRemoteClassCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryRemoteClassCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySchoolUserFaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySchoolUserFaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySchoolUserFaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySnsOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySnsOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySnsOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryStatisticsDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryStatisticsDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryStatisticsDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySubjectTeachersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySubjectTeachersRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySubjectTeachersResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTeachSubjectsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTeachSubjectsRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTeachSubjectsResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryUniversityCourseGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryUniversityCourseGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryUniversityCourseGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryUserFaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryUserFaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryUserFaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryUserPayInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryUserPayInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryUserPayInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\RemoveDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\RemoveDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\RemoveDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ReportDeviceLogHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ReportDeviceLogRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ReportDeviceLogResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ReportDeviceUseLogHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ReportDeviceUseLogRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ReportDeviceUseLogResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\RollbackDeductPointHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\RollbackDeductPointRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\RollbackDeductPointResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SearchTeachersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SearchTeachersRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SearchTeachersResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\StartCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\StartCoursePrepareHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\StartCoursePrepareRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\StartCoursePrepareResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\StartCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\StartCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SubscribeUniversityCourseGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SubscribeUniversityCourseGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SubscribeUniversityCourseGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UnsubscribeUniversityCourseGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UnsubscribeUniversityCourseGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UnsubscribeUniversityCourseGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdatePhysicalClassroomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdatePhysicalClassroomRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdatePhysicalClassroomResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateRemoteClassCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateRemoteClassCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateRemoteClassCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateRemoteClassDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateRemoteClassDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateRemoteClassDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateUniversityCourseGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateUniversityCourseGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateUniversityCourseGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ValidateUserRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ValidateUserRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ValidateUserRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\VPaasProxyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\VPaasProxyRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\VPaasProxyResponse;
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
     * @param ActivateDeviceRequest $request
     * @param ActivateDeviceHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return ActivateDeviceResponse
     */
    public function activateDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->licenseKey)) {
            $body['licenseKey'] = $request->licenseKey;
        }
        if (!Utils::isUnset($request->model)) {
            $body['model'] = $request->model;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
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
            'action'      => 'ActivateDevice',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/vpaas/devices/activate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ActivateDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ActivateDeviceRequest $request
     *
     * @return ActivateDeviceResponse
     */
    public function activateDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ActivateDeviceHeaders([]);

        return $this->activateDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddDeviceRequest $request
     * @param AddDeviceHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return AddDeviceResponse
     */
    public function addDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->merchantId)) {
            $body['merchantId'] = $request->merchantId;
        }
        if (!Utils::isUnset($request->model)) {
            $body['model'] = $request->model;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->scene)) {
            $body['scene'] = $request->scene;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
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
            'action'      => 'AddDevice',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/devices',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddDeviceRequest $request
     *
     * @return AddDeviceResponse
     */
    public function addDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddDeviceHeaders([]);

        return $this->addDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddSchoolConfigRequest $request
     * @param AddSchoolConfigHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return AddSchoolConfigResponse
     */
    public function addSchoolConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->operatorName)) {
            $body['operatorName'] = $request->operatorName;
        }
        if (!Utils::isUnset($request->temperatureUpLimit)) {
            $body['temperatureUpLimit'] = $request->temperatureUpLimit;
        }
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
            'action'      => 'AddSchoolConfig',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/schools/configurations',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddSchoolConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddSchoolConfigRequest $request
     *
     * @return AddSchoolConfigResponse
     */
    public function addSchoolConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddSchoolConfigHeaders([]);

        return $this->addSchoolConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AssignClassRequest $request
     * @param AssignClassHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return AssignClassResponse
     */
    public function assignClassWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->isFinish)) {
            $body['isFinish'] = $request->isFinish;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->studentId)) {
            $body['studentId'] = $request->studentId;
        }
        if (!Utils::isUnset($request->taskId)) {
            $body['taskId'] = $request->taskId;
        }
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
            'action'      => 'AssignClass',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/newGrades/tasks/students/classes/assign',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AssignClassResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AssignClassRequest $request
     *
     * @return AssignClassResponse
     */
    public function assignClass($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AssignClassHeaders([]);

        return $this->assignClassWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchCreateRequest $request
     * @param BatchCreateHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return BatchCreateResponse
     */
    public function batchCreateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->cardBizCode)) {
            $body['cardBizCode'] = $request->cardBizCode;
        }
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->identifier)) {
            $body['identifier'] = $request->identifier;
        }
        if (!Utils::isUnset($request->jsVersion)) {
            $body['jsVersion'] = $request->jsVersion;
        }
        if (!Utils::isUnset($request->sourceType)) {
            $body['sourceType'] = $request->sourceType;
        }
        if (!Utils::isUnset($request->userid)) {
            $body['userid'] = $request->userid;
        }
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
            'action'      => 'BatchCreate',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/cards',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return BatchCreateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchCreateRequest $request
     *
     * @return BatchCreateResponse
     */
    public function batchCreate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchCreateHeaders([]);

        return $this->batchCreateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchOrgCreateHWRequest $request
     * @param BatchOrgCreateHWHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return BatchOrgCreateHWResponse
     */
    public function batchOrgCreateHWWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attributes)) {
            $body['attributes'] = $request->attributes;
        }
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->courseName)) {
            $body['courseName'] = $request->courseName;
        }
        if (!Utils::isUnset($request->hwContent)) {
            $body['hwContent'] = $request->hwContent;
        }
        if (!Utils::isUnset($request->hwDeadline)) {
            $body['hwDeadline'] = $request->hwDeadline;
        }
        if (!Utils::isUnset($request->hwDeadlineOpen)) {
            $body['hwDeadlineOpen'] = $request->hwDeadlineOpen;
        }
        if (!Utils::isUnset($request->hwMedia)) {
            $body['hwMedia'] = $request->hwMedia;
        }
        if (!Utils::isUnset($request->hwPhoto)) {
            $body['hwPhoto'] = $request->hwPhoto;
        }
        if (!Utils::isUnset($request->hwTitle)) {
            $body['hwTitle'] = $request->hwTitle;
        }
        if (!Utils::isUnset($request->hwType)) {
            $body['hwType'] = $request->hwType;
        }
        if (!Utils::isUnset($request->hwVideo)) {
            $body['hwVideo'] = $request->hwVideo;
        }
        if (!Utils::isUnset($request->identifier)) {
            $body['identifier'] = $request->identifier;
        }
        if (!Utils::isUnset($request->openSelectItemList)) {
            $body['openSelectItemList'] = $request->openSelectItemList;
        }
        if (!Utils::isUnset($request->scheduledRelease)) {
            $body['scheduledRelease'] = $request->scheduledRelease;
        }
        if (!Utils::isUnset($request->scheduledTime)) {
            $body['scheduledTime'] = $request->scheduledTime;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->targetRole)) {
            $body['targetRole'] = $request->targetRole;
        }
        if (!Utils::isUnset($request->teacherName)) {
            $body['teacherName'] = $request->teacherName;
        }
        if (!Utils::isUnset($request->teacherUserId)) {
            $body['teacherUserId'] = $request->teacherUserId;
        }
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
            'action'      => 'BatchOrgCreateHW',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/homeworks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return BatchOrgCreateHWResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchOrgCreateHWRequest $request
     *
     * @return BatchOrgCreateHWResponse
     */
    public function batchOrgCreateHW($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchOrgCreateHWHeaders([]);

        return $this->batchOrgCreateHWWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CancelOrderRequest $request
     * @param CancelOrderHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return CancelOrderResponse
     */
    public function cancelOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->faceId)) {
            $body['faceId'] = $request->faceId;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->signature)) {
            $body['signature'] = $request->signature;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->timestamp)) {
            $body['timestamp'] = $request->timestamp;
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
            'action'      => 'CancelOrder',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/orders/cancel',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CancelOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CancelOrderRequest $request
     *
     * @return CancelOrderResponse
     */
    public function cancelOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelOrderHeaders([]);

        return $this->cancelOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CancelSnsOrderRequest $request
     * @param CancelSnsOrderHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CancelSnsOrderResponse
     */
    public function cancelSnsOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->alipayAppId)) {
            $body['alipayAppId'] = $request->alipayAppId;
        }
        if (!Utils::isUnset($request->merchantId)) {
            $body['merchantId'] = $request->merchantId;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->signature)) {
            $body['signature'] = $request->signature;
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
            'action'      => 'CancelSnsOrder',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/snsUserOrders/cancel',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CancelSnsOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CancelSnsOrderRequest $request
     *
     * @return CancelSnsOrderResponse
     */
    public function cancelSnsOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelSnsOrderHeaders([]);

        return $this->cancelSnsOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CancelUserOrderRequest $request
     * @param CancelUserOrderHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return CancelUserOrderResponse
     */
    public function cancelUserOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->alipayAppId)) {
            $body['alipayAppId'] = $request->alipayAppId;
        }
        if (!Utils::isUnset($request->merchantId)) {
            $body['merchantId'] = $request->merchantId;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->signature)) {
            $body['signature'] = $request->signature;
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
            'action'      => 'CancelUserOrder',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/userOrders/cancel',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CancelUserOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CancelUserOrderRequest $request
     *
     * @return CancelUserOrderResponse
     */
    public function cancelUserOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelUserOrderHeaders([]);

        return $this->cancelUserOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CheckRestrictionRequest $request
     * @param CheckRestrictionHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return CheckRestrictionResponse
     */
    public function checkRestrictionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actualAmount)) {
            $body['actualAmount'] = $request->actualAmount;
        }
        if (!Utils::isUnset($request->faceId)) {
            $body['faceId'] = $request->faceId;
        }
        if (!Utils::isUnset($request->scene)) {
            $body['scene'] = $request->scene;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
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
            'action'      => 'CheckRestriction',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/restrictions/check',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CheckRestrictionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CheckRestrictionRequest $request
     *
     * @return CheckRestrictionResponse
     */
    public function checkRestriction($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckRestrictionHeaders([]);

        return $this->checkRestrictionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ConsumePointRequest $request
     * @param ConsumePointHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return ConsumePointResponse
     */
    public function consumePointWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->amount)) {
            $body['amount'] = $request->amount;
        }
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->productCode)) {
            $body['productCode'] = $request->productCode;
        }
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
            'action'      => 'ConsumePoint',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/poins/consume',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ConsumePointResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ConsumePointRequest $request
     *
     * @return ConsumePointResponse
     */
    public function consumePoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConsumePointHeaders([]);

        return $this->consumePointWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CourseSchedulingComplimentNoticeRequest $request
     * @param CourseSchedulingComplimentNoticeHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return CourseSchedulingComplimentNoticeResponse
     */
    public function courseSchedulingComplimentNoticeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
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
            'action'      => 'CourseSchedulingComplimentNotice',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/schedules/finishNotify',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CourseSchedulingComplimentNoticeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CourseSchedulingComplimentNoticeRequest $request
     *
     * @return CourseSchedulingComplimentNoticeResponse
     */
    public function courseSchedulingComplimentNotice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CourseSchedulingComplimentNoticeHeaders([]);

        return $this->courseSchedulingComplimentNoticeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateAppOrderRequest $request
     * @param CreateAppOrderHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreateAppOrderResponse
     */
    public function createAppOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actualAmount)) {
            $body['actualAmount'] = $request->actualAmount;
        }
        if (!Utils::isUnset($request->alipayAppId)) {
            $body['alipayAppId'] = $request->alipayAppId;
        }
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->detailList)) {
            $body['detailList'] = $request->detailList;
        }
        if (!Utils::isUnset($request->labelAmount)) {
            $body['labelAmount'] = $request->labelAmount;
        }
        if (!Utils::isUnset($request->merchantId)) {
            $body['merchantId'] = $request->merchantId;
        }
        if (!Utils::isUnset($request->merchantOrderNo)) {
            $body['merchantOrderNo'] = $request->merchantOrderNo;
        }
        if (!Utils::isUnset($request->outerUserId)) {
            $body['outerUserId'] = $request->outerUserId;
        }
        if (!Utils::isUnset($request->signature)) {
            $body['signature'] = $request->signature;
        }
        if (!Utils::isUnset($request->subject)) {
            $body['subject'] = $request->subject;
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
            'action'      => 'CreateAppOrder',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/appOrders',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateAppOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateAppOrderRequest $request
     *
     * @return CreateAppOrderResponse
     */
    public function createAppOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateAppOrderHeaders([]);

        return $this->createAppOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateCustomClassRequest $request
     * @param CreateCustomClassHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return CreateCustomClassResponse
     */
    public function createCustomClassWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->customClass)) {
            $body['customClass'] = $request->customClass;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->superId)) {
            $body['superId'] = $request->superId;
        }
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
            'action'      => 'CreateCustomClass',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/customClasses',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateCustomClassResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateCustomClassRequest $request
     *
     * @return CreateCustomClassResponse
     */
    public function createCustomClass($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCustomClassHeaders([]);

        return $this->createCustomClassWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateCustomDeptRequest $request
     * @param CreateCustomDeptHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return CreateCustomDeptResponse
     */
    public function createCustomDeptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->customDept)) {
            $body['customDept'] = $request->customDept;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->superId)) {
            $body['superId'] = $request->superId;
        }
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
            'action'      => 'CreateCustomDept',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/customDepts',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateCustomDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateCustomDeptRequest $request
     *
     * @return CreateCustomDeptResponse
     */
    public function createCustomDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCustomDeptHeaders([]);

        return $this->createCustomDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateEduAssetSpaceRequest $request
     * @param CreateEduAssetSpaceHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return CreateEduAssetSpaceResponse
     */
    public function createEduAssetSpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->spaceDesc)) {
            $body['spaceDesc'] = $request->spaceDesc;
        }
        if (!Utils::isUnset($request->spaceIcon)) {
            $body['spaceIcon'] = $request->spaceIcon;
        }
        if (!Utils::isUnset($request->spaceName)) {
            $body['spaceName'] = $request->spaceName;
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
            'action'      => 'CreateEduAssetSpace',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/assets/spaces',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateEduAssetSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateEduAssetSpaceRequest $request
     *
     * @return CreateEduAssetSpaceResponse
     */
    public function createEduAssetSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateEduAssetSpaceHeaders([]);

        return $this->createEduAssetSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateFulfilRecordRequest $request
     * @param CreateFulfilRecordHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return CreateFulfilRecordResponse
     */
    public function createFulfilRecordWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizTime)) {
            $body['bizTime'] = $request->bizTime;
        }
        if (!Utils::isUnset($request->extInfo)) {
            $body['extInfo'] = $request->extInfo;
        }
        if (!Utils::isUnset($request->faceId)) {
            $body['faceId'] = $request->faceId;
        }
        if (!Utils::isUnset($request->scene)) {
            $body['scene'] = $request->scene;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
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
            'action'      => 'CreateFulfilRecord',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/fulfilRecords',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateFulfilRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateFulfilRecordRequest $request
     *
     * @return CreateFulfilRecordResponse
     */
    public function createFulfilRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateFulfilRecordHeaders([]);

        return $this->createFulfilRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateInviteUrlRequest $request
     * @param CreateInviteUrlHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return CreateInviteUrlResponse
     */
    public function createInviteUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->authCode)) {
            $body['authCode'] = $request->authCode;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $body['targetCorpId'] = $request->targetCorpId;
        }
        if (!Utils::isUnset($request->targetOperator)) {
            $body['targetOperator'] = $request->targetOperator;
        }
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
            'action'      => 'CreateInviteUrl',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/remoteClasses/orgRelations/inviteUrls',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateInviteUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateInviteUrlRequest $request
     *
     * @return CreateInviteUrlResponse
     */
    public function createInviteUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateInviteUrlHeaders([]);

        return $this->createInviteUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateItemRequest $request
     * @param CreateItemHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return CreateItemResponse
     */
    public function createItemWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->effectType)) {
            $body['effectType'] = $request->effectType;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->merchantId)) {
            $body['merchantId'] = $request->merchantId;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->optUser)) {
            $body['optUser'] = $request->optUser;
        }
        if (!Utils::isUnset($request->periodType)) {
            $body['periodType'] = $request->periodType;
        }
        if (!Utils::isUnset($request->price)) {
            $body['price'] = $request->price;
        }
        if (!Utils::isUnset($request->scene)) {
            $body['scene'] = $request->scene;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
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
            'action'      => 'CreateItem',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/items',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateItemResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateItemRequest $request
     *
     * @return CreateItemResponse
     */
    public function createItem($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateItemHeaders([]);

        return $this->createItemWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateOrderRequest $request
     * @param CreateOrderHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return CreateOrderResponse
     */
    public function createOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actualAmount)) {
            $body['actualAmount'] = $request->actualAmount;
        }
        if (!Utils::isUnset($request->createTime)) {
            $body['createTime'] = $request->createTime;
        }
        if (!Utils::isUnset($request->detailList)) {
            $body['detailList'] = $request->detailList;
        }
        if (!Utils::isUnset($request->faceId)) {
            $body['faceId'] = $request->faceId;
        }
        if (!Utils::isUnset($request->ftoken)) {
            $body['ftoken'] = $request->ftoken;
        }
        if (!Utils::isUnset($request->signature)) {
            $body['signature'] = $request->signature;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->terminalParams)) {
            $body['terminalParams'] = $request->terminalParams;
        }
        if (!Utils::isUnset($request->timestamp)) {
            $body['timestamp'] = $request->timestamp;
        }
        if (!Utils::isUnset($request->totalAmount)) {
            $body['totalAmount'] = $request->totalAmount;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateOrder',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/orders',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateOrderRequest $request
     *
     * @return CreateOrderResponse
     */
    public function createOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateOrderHeaders([]);

        return $this->createOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateOrderFlowRequest $request
     * @param CreateOrderFlowHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return CreateOrderFlowResponse
     */
    public function createOrderFlowWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actualAmount)) {
            $body['actualAmount'] = $request->actualAmount;
        }
        if (!Utils::isUnset($request->alipayUid)) {
            $body['alipayUid'] = $request->alipayUid;
        }
        if (!Utils::isUnset($request->createTime)) {
            $body['createTime'] = $request->createTime;
        }
        if (!Utils::isUnset($request->detailList)) {
            $body['detailList'] = $request->detailList;
        }
        if (!Utils::isUnset($request->faceId)) {
            $body['faceId'] = $request->faceId;
        }
        if (!Utils::isUnset($request->guardianUserId)) {
            $body['guardianUserId'] = $request->guardianUserId;
        }
        if (!Utils::isUnset($request->merchantId)) {
            $body['merchantId'] = $request->merchantId;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->signature)) {
            $body['signature'] = $request->signature;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->timestamp)) {
            $body['timestamp'] = $request->timestamp;
        }
        if (!Utils::isUnset($request->totalAmount)) {
            $body['totalAmount'] = $request->totalAmount;
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
            'action'      => 'CreateOrderFlow',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/orders/flows',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateOrderFlowResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateOrderFlowRequest $request
     *
     * @return CreateOrderFlowResponse
     */
    public function createOrderFlow($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateOrderFlowHeaders([]);

        return $this->createOrderFlowWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreatePhysicalClassroomRequest $request
     * @param CreatePhysicalClassroomHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CreatePhysicalClassroomResponse
     */
    public function createPhysicalClassroomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->classroomBuilding)) {
            $body['classroomBuilding'] = $request->classroomBuilding;
        }
        if (!Utils::isUnset($request->classroomCampus)) {
            $body['classroomCampus'] = $request->classroomCampus;
        }
        if (!Utils::isUnset($request->classroomFloor)) {
            $body['classroomFloor'] = $request->classroomFloor;
        }
        if (!Utils::isUnset($request->classroomName)) {
            $body['classroomName'] = $request->classroomName;
        }
        if (!Utils::isUnset($request->classroomNumber)) {
            $body['classroomNumber'] = $request->classroomNumber;
        }
        if (!Utils::isUnset($request->directBroadcast)) {
            $body['directBroadcast'] = $request->directBroadcast;
        }
        if (!Utils::isUnset($request->ext)) {
            $body['ext'] = $request->ext;
        }
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
            'action'      => 'CreatePhysicalClassroom',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/physicalClassrooms',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreatePhysicalClassroomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreatePhysicalClassroomRequest $request
     *
     * @return CreatePhysicalClassroomResponse
     */
    public function createPhysicalClassroom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreatePhysicalClassroomHeaders([]);

        return $this->createPhysicalClassroomWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateRefundFlowRequest $request
     * @param CreateRefundFlowHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return CreateRefundFlowResponse
     */
    public function createRefundFlowWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->faceId)) {
            $body['faceId'] = $request->faceId;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->operatorName)) {
            $body['operatorName'] = $request->operatorName;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->signature)) {
            $body['signature'] = $request->signature;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->timestamp)) {
            $body['timestamp'] = $request->timestamp;
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
            'action'      => 'CreateRefundFlow',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/refunds/flows',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateRefundFlowResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateRefundFlowRequest $request
     *
     * @return CreateRefundFlowResponse
     */
    public function createRefundFlow($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateRefundFlowHeaders([]);

        return $this->createRefundFlowWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateRemoteClassCourseRequest $request
     * @param CreateRemoteClassCourseHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CreateRemoteClassCourseResponse
     */
    public function createRemoteClassCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attendParticipants)) {
            $body['attendParticipants'] = $request->attendParticipants;
        }
        if (!Utils::isUnset($request->authCode)) {
            $body['authCode'] = $request->authCode;
        }
        if (!Utils::isUnset($request->courseName)) {
            $body['courseName'] = $request->courseName;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->teachingParticipant)) {
            $body['teachingParticipant'] = $request->teachingParticipant;
        }
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
            'action'      => 'CreateRemoteClassCourse',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/remoteClasses/courses',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateRemoteClassCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateRemoteClassCourseRequest $request
     *
     * @return CreateRemoteClassCourseResponse
     */
    public function createRemoteClassCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateRemoteClassCourseHeaders([]);

        return $this->createRemoteClassCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateSectionConfigRequest $request
     * @param CreateSectionConfigHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return CreateSectionConfigResponse
     */
    public function createSectionConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->ext)) {
            $body['ext'] = $request->ext;
        }
        if (!Utils::isUnset($request->sectionConfigs)) {
            $body['sectionConfigs'] = $request->sectionConfigs;
        }
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
            'action'      => 'CreateSectionConfig',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/universities/sectionConfigs',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateSectionConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateSectionConfigRequest $request
     *
     * @return CreateSectionConfigResponse
     */
    public function createSectionConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSectionConfigHeaders([]);

        return $this->createSectionConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateSnsAppOrderRequest $request
     * @param CreateSnsAppOrderHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return CreateSnsAppOrderResponse
     */
    public function createSnsAppOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actualAmount)) {
            $body['actualAmount'] = $request->actualAmount;
        }
        if (!Utils::isUnset($request->alipayAppId)) {
            $body['alipayAppId'] = $request->alipayAppId;
        }
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->detailList)) {
            $body['detailList'] = $request->detailList;
        }
        if (!Utils::isUnset($request->labelAmount)) {
            $body['labelAmount'] = $request->labelAmount;
        }
        if (!Utils::isUnset($request->merchantId)) {
            $body['merchantId'] = $request->merchantId;
        }
        if (!Utils::isUnset($request->merchantOrderNo)) {
            $body['merchantOrderNo'] = $request->merchantOrderNo;
        }
        if (!Utils::isUnset($request->signature)) {
            $body['signature'] = $request->signature;
        }
        if (!Utils::isUnset($request->subject)) {
            $body['subject'] = $request->subject;
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
            'action'      => 'CreateSnsAppOrder',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/snsAppOrders',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateSnsAppOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateSnsAppOrderRequest $request
     *
     * @return CreateSnsAppOrderResponse
     */
    public function createSnsAppOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSnsAppOrderHeaders([]);

        return $this->createSnsAppOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateStsTokenRequest $request
     * @param CreateStsTokenHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreateStsTokenResponse
     */
    public function createStsTokenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceSn)) {
            $body['deviceSn'] = $request->deviceSn;
        }
        if (!Utils::isUnset($request->stsType)) {
            $body['stsType'] = $request->stsType;
        }
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
            'action'      => 'CreateStsToken',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/vpaas/ststoken',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateStsTokenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateStsTokenRequest $request
     *
     * @return CreateStsTokenResponse
     */
    public function createStsToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateStsTokenHeaders([]);

        return $this->createStsTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateTokenRequest $request
     * @param CreateTokenHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return CreateTokenResponse
     */
    public function createTokenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
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
            'action'      => 'CreateToken',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/tokens',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateTokenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateTokenRequest $request
     *
     * @return CreateTokenResponse
     */
    public function createToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTokenHeaders([]);

        return $this->createTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateUniversityCourseGroupRequest $request
     * @param CreateUniversityCourseGroupHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return CreateUniversityCourseGroupResponse
     */
    public function createUniversityCourseGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->courseGroupIntroduce)) {
            $body['courseGroupIntroduce'] = $request->courseGroupIntroduce;
        }
        if (!Utils::isUnset($request->courseGroupName)) {
            $body['courseGroupName'] = $request->courseGroupName;
        }
        if (!Utils::isUnset($request->courserGroupItemModels)) {
            $body['courserGroupItemModels'] = $request->courserGroupItemModels;
        }
        if (!Utils::isUnset($request->ext)) {
            $body['ext'] = $request->ext;
        }
        if (!Utils::isUnset($request->isvCourseGroupCode)) {
            $body['isvCourseGroupCode'] = $request->isvCourseGroupCode;
        }
        if (!Utils::isUnset($request->periodCode)) {
            $body['periodCode'] = $request->periodCode;
        }
        if (!Utils::isUnset($request->schoolYear)) {
            $body['schoolYear'] = $request->schoolYear;
        }
        if (!Utils::isUnset($request->semester)) {
            $body['semester'] = $request->semester;
        }
        if (!Utils::isUnset($request->subjectName)) {
            $body['subjectName'] = $request->subjectName;
        }
        if (!Utils::isUnset($request->teacherInfos)) {
            $body['teacherInfos'] = $request->teacherInfos;
        }
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
            'action'      => 'CreateUniversityCourseGroup',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/universities/courseGroups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateUniversityCourseGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateUniversityCourseGroupRequest $request
     *
     * @return CreateUniversityCourseGroupResponse
     */
    public function createUniversityCourseGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateUniversityCourseGroupHeaders([]);

        return $this->createUniversityCourseGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateUniversityStudentRequest $request
     * @param CreateUniversityStudentHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CreateUniversityStudentResponse
     */
    public function createUniversityStudentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->gender)) {
            $body['gender'] = $request->gender;
        }
        if (!Utils::isUnset($request->identityNumber)) {
            $body['identityNumber'] = $request->identityNumber;
        }
        if (!Utils::isUnset($request->mobile)) {
            $body['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->studentNumber)) {
            $body['studentNumber'] = $request->studentNumber;
        }
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
            'action'      => 'CreateUniversityStudent',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/universities/students',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateUniversityStudentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateUniversityStudentRequest $request
     *
     * @return CreateUniversityStudentResponse
     */
    public function createUniversityStudent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateUniversityStudentHeaders([]);

        return $this->createUniversityStudentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateUniversityTeacherRequest $request
     * @param CreateUniversityTeacherHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CreateUniversityTeacherResponse
     */
    public function createUniversityTeacherWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->role)) {
            $body['role'] = $request->role;
        }
        if (!Utils::isUnset($request->teacherUserId)) {
            $body['teacherUserId'] = $request->teacherUserId;
        }
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
            'action'      => 'CreateUniversityTeacher',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/universities/teachers',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateUniversityTeacherResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateUniversityTeacherRequest $request
     *
     * @return CreateUniversityTeacherResponse
     */
    public function createUniversityTeacher($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateUniversityTeacherHeaders([]);

        return $this->createUniversityTeacherWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeactivateDeviceRequest $request
     * @param DeactivateDeviceHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return DeactivateDeviceResponse
     */
    public function deactivateDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->model)) {
            $body['model'] = $request->model;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
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
            'action'      => 'DeactivateDevice',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/vpaas/devices/deactivate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeactivateDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeactivateDeviceRequest $request
     *
     * @return DeactivateDeviceResponse
     */
    public function deactivateDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeactivateDeviceHeaders([]);

        return $this->deactivateDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeductPointRequest $request
     * @param DeductPointHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return DeductPointResponse
     */
    public function deductPointWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->deductDesc)) {
            $body['deductDesc'] = $request->deductDesc;
        }
        if (!Utils::isUnset($request->deductDetailUrl)) {
            $body['deductDetailUrl'] = $request->deductDetailUrl;
        }
        if (!Utils::isUnset($request->deductNum)) {
            $body['deductNum'] = $request->deductNum;
        }
        if (!Utils::isUnset($request->pointType)) {
            $body['pointType'] = $request->pointType;
        }
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
            'action'      => 'DeductPoint',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/points/deduct',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeductPointResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeductPointRequest $request
     *
     * @return DeductPointResponse
     */
    public function deductPoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeductPointHeaders([]);

        return $this->deductPointWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string            $deptId
     * @param DeleteDeptRequest $request
     * @param DeleteDeptHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return DeleteDeptResponse
     */
    public function deleteDeptWithOptions($deptId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operator)) {
            $query['operator'] = $request->operator;
        }
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
            'action'      => 'DeleteDept',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/depts/' . $deptId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeleteDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string            $deptId
     * @param DeleteDeptRequest $request
     *
     * @return DeleteDeptResponse
     */
    public function deleteDept($deptId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDeptHeaders([]);

        return $this->deleteDeptWithOptions($deptId, $request, $headers, $runtime);
    }

    /**
     * @param DeleteDeviceRequest $request
     * @param DeleteDeviceHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return DeleteDeviceResponse
     */
    public function deleteDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->sn)) {
            $query['sn'] = $request->sn;
        }
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
            'action'      => 'DeleteDevice',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/vpaas/devices',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteDeviceRequest $request
     *
     * @return DeleteDeviceResponse
     */
    public function deleteDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDeviceHeaders([]);

        return $this->deleteDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteDeviceOrgRequest $request
     * @param DeleteDeviceOrgHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return DeleteDeviceOrgResponse
     */
    public function deleteDeviceOrgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->authCode)) {
            $query['authCode'] = $request->authCode;
        }
        if (!Utils::isUnset($request->deviceCode)) {
            $query['deviceCode'] = $request->deviceCode;
        }
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
            'action'      => 'DeleteDeviceOrg',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/remoteClasses/deviceOrgs',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeleteDeviceOrgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteDeviceOrgRequest $request
     *
     * @return DeleteDeviceOrgResponse
     */
    public function deleteDeviceOrg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDeviceOrgHeaders([]);

        return $this->deleteDeviceOrgWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                $classId
     * @param string                $userId
     * @param DeleteGuardianRequest $request
     * @param DeleteGuardianHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return DeleteGuardianResponse
     */
    public function deleteGuardianWithOptions($classId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operator)) {
            $query['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->stuId)) {
            $query['stuId'] = $request->stuId;
        }
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
            'action'      => 'DeleteGuardian',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/classes/' . $classId . '/guardians/' . $userId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeleteGuardianResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                $classId
     * @param string                $userId
     * @param DeleteGuardianRequest $request
     *
     * @return DeleteGuardianResponse
     */
    public function deleteGuardian($classId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteGuardianHeaders([]);

        return $this->deleteGuardianWithOptions($classId, $userId, $request, $headers, $runtime);
    }

    /**
     * @param DeleteOrgRelationRequest $request
     * @param DeleteOrgRelationHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return DeleteOrgRelationResponse
     */
    public function deleteOrgRelationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->authCode)) {
            $query['authCode'] = $request->authCode;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $query['targetCorpId'] = $request->targetCorpId;
        }
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
            'action'      => 'DeleteOrgRelation',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/remoteClasses/orgRelations',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeleteOrgRelationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteOrgRelationRequest $request
     *
     * @return DeleteOrgRelationResponse
     */
    public function deleteOrgRelation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteOrgRelationHeaders([]);

        return $this->deleteOrgRelationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeletePhysicalClassroomRequest $request
     * @param DeletePhysicalClassroomHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return DeletePhysicalClassroomResponse
     */
    public function deletePhysicalClassroomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->classroomId)) {
            $query['classroomId'] = $request->classroomId;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
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
            'action'      => 'DeletePhysicalClassroom',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/physicalClassrooms',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeletePhysicalClassroomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeletePhysicalClassroomRequest $request
     *
     * @return DeletePhysicalClassroomResponse
     */
    public function deletePhysicalClassroom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeletePhysicalClassroomHeaders([]);

        return $this->deletePhysicalClassroomWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                         $courseCode
     * @param DeleteRemoteClassCourseRequest $request
     * @param DeleteRemoteClassCourseHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return DeleteRemoteClassCourseResponse
     */
    public function deleteRemoteClassCourseWithOptions($courseCode, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->authCode)) {
            $query['authCode'] = $request->authCode;
        }
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
            'action'      => 'DeleteRemoteClassCourse',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/remoteClasses/courses/' . $courseCode . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeleteRemoteClassCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                         $courseCode
     * @param DeleteRemoteClassCourseRequest $request
     *
     * @return DeleteRemoteClassCourseResponse
     */
    public function deleteRemoteClassCourse($courseCode, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRemoteClassCourseHeaders([]);

        return $this->deleteRemoteClassCourseWithOptions($courseCode, $request, $headers, $runtime);
    }

    /**
     * @param string               $classId
     * @param string               $userId
     * @param DeleteStudentRequest $request
     * @param DeleteStudentHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return DeleteStudentResponse
     */
    public function deleteStudentWithOptions($classId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operator)) {
            $query['operator'] = $request->operator;
        }
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
            'action'      => 'DeleteStudent',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/classes/' . $classId . '/students/' . $userId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeleteStudentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string               $classId
     * @param string               $userId
     * @param DeleteStudentRequest $request
     *
     * @return DeleteStudentResponse
     */
    public function deleteStudent($classId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteStudentHeaders([]);

        return $this->deleteStudentWithOptions($classId, $userId, $request, $headers, $runtime);
    }

    /**
     * @param string               $classId
     * @param string               $userId
     * @param DeleteTeacherRequest $request
     * @param DeleteTeacherHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return DeleteTeacherResponse
     */
    public function deleteTeacherWithOptions($classId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->adviser)) {
            $query['adviser'] = $request->adviser;
        }
        if (!Utils::isUnset($request->operator)) {
            $query['operator'] = $request->operator;
        }
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
            'action'      => 'DeleteTeacher',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/classes/' . $classId . '/teachers/' . $userId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeleteTeacherResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string               $classId
     * @param string               $userId
     * @param DeleteTeacherRequest $request
     *
     * @return DeleteTeacherResponse
     */
    public function deleteTeacher($classId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteTeacherHeaders([]);

        return $this->deleteTeacherWithOptions($classId, $userId, $request, $headers, $runtime);
    }

    /**
     * @param DeleteUniversityCourseGroupRequest $request
     * @param DeleteUniversityCourseGroupHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return DeleteUniversityCourseGroupResponse
     */
    public function deleteUniversityCourseGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->courseGroupCode)) {
            $query['courseGroupCode'] = $request->courseGroupCode;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
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
            'action'      => 'DeleteUniversityCourseGroup',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/universities/courseGroups',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DeleteUniversityCourseGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteUniversityCourseGroupRequest $request
     *
     * @return DeleteUniversityCourseGroupResponse
     */
    public function deleteUniversityCourseGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteUniversityCourseGroupHeaders([]);

        return $this->deleteUniversityCourseGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteUniversityStudentRequest $request
     * @param DeleteUniversityStudentHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return DeleteUniversityStudentResponse
     */
    public function deleteUniversityStudentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->classId)) {
            $query['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->studentUserId)) {
            $query['studentUserId'] = $request->studentUserId;
        }
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
            'action'      => 'DeleteUniversityStudent',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/universities/students',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteUniversityStudentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteUniversityStudentRequest $request
     *
     * @return DeleteUniversityStudentResponse
     */
    public function deleteUniversityStudent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteUniversityStudentHeaders([]);

        return $this->deleteUniversityStudentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteUniversityTeacherRequest $request
     * @param DeleteUniversityTeacherHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return DeleteUniversityTeacherResponse
     */
    public function deleteUniversityTeacherWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->classId)) {
            $query['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->role)) {
            $query['role'] = $request->role;
        }
        if (!Utils::isUnset($request->teacherUserId)) {
            $query['teacherUserId'] = $request->teacherUserId;
        }
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
            'action'      => 'DeleteUniversityTeacher',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/universities/teachers',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteUniversityTeacherResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteUniversityTeacherRequest $request
     *
     * @return DeleteUniversityTeacherResponse
     */
    public function deleteUniversityTeacher($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteUniversityTeacherHeaders([]);

        return $this->deleteUniversityTeacherWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeviceHeartbeatRequest $request
     * @param DeviceHeartbeatHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return DeviceHeartbeatResponse
     */
    public function deviceHeartbeatWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->sn)) {
            $query['sn'] = $request->sn;
        }
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
            'action'      => 'DeviceHeartbeat',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/heartbeats/report',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeviceHeartbeatResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeviceHeartbeatRequest $request
     *
     * @return DeviceHeartbeatResponse
     */
    public function deviceHeartbeat($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeviceHeartbeatHeaders([]);

        return $this->deviceHeartbeatWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EduTeacherListRequest $request
     * @param EduTeacherListHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return EduTeacherListResponse
     */
    public function eduTeacherListWithOptions($request, $headers, $runtime)
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
            'action'      => 'EduTeacherList',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/teachers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EduTeacherListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param EduTeacherListRequest $request
     *
     * @return EduTeacherListResponse
     */
    public function eduTeacherList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EduTeacherListHeaders([]);

        return $this->eduTeacherListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EndCourseRequest $request
     * @param EndCourseHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return EndCourseResponse
     */
    public function endCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->courseCode)) {
            $body['courseCode'] = $request->courseCode;
        }
        if (!Utils::isUnset($request->ext)) {
            $body['ext'] = $request->ext;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->livePlayInfoList)) {
            $body['livePlayInfoList'] = $request->livePlayInfoList;
        }
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
            'action'      => 'EndCourse',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/universities/courses/end',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EndCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param EndCourseRequest $request
     *
     * @return EndCourseResponse
     */
    public function endCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EndCourseHeaders([]);

        return $this->endCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetBindChildInfoRequest $request
     * @param GetBindChildInfoHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetBindChildInfoResponse
     */
    public function getBindChildInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->schoolCorpId)) {
            $query['schoolCorpId'] = $request->schoolCorpId;
        }
        if (!Utils::isUnset($request->studentUserId)) {
            $query['studentUserId'] = $request->studentUserId;
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
            'action'      => 'GetBindChildInfo',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/families/childs/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetBindChildInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetBindChildInfoRequest $request
     *
     * @return GetBindChildInfoResponse
     */
    public function getBindChildInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetBindChildInfoHeaders([]);

        return $this->getBindChildInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetDefaultChildHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetDefaultChildResponse
     */
    public function getDefaultChildWithOptions($headers, $runtime)
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
            'action'      => 'GetDefaultChild',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/defaultChildren',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetDefaultChildResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return GetDefaultChildResponse
     */
    public function getDefaultChild()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDefaultChildHeaders([]);

        return $this->getDefaultChildWithOptions($headers, $runtime);
    }

    /**
     * @param GetEduUserIdentityRequest $request
     * @param GetEduUserIdentityHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetEduUserIdentityResponse
     */
    public function getEduUserIdentityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'action'      => 'GetEduUserIdentity',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/apollos/activities/userIdentities',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetEduUserIdentityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetEduUserIdentityRequest $request
     *
     * @return GetEduUserIdentityResponse
     */
    public function getEduUserIdentity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetEduUserIdentityHeaders([]);

        return $this->getEduUserIdentityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                     $courseId
     * @param GetOpenCourseDetailHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetOpenCourseDetailResponse
     */
    public function getOpenCourseDetailWithOptions($courseId, $headers, $runtime)
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
            'action'      => 'GetOpenCourseDetail',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/openCourse/' . $courseId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOpenCourseDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $courseId
     *
     * @return GetOpenCourseDetailResponse
     */
    public function getOpenCourseDetail($courseId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOpenCourseDetailHeaders([]);

        return $this->getOpenCourseDetailWithOptions($courseId, $headers, $runtime);
    }

    /**
     * @param GetOpenCoursesRequest $request
     * @param GetOpenCoursesHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetOpenCoursesResponse
     */
    public function getOpenCoursesWithOptions($request, $headers, $runtime)
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
            'action'      => 'GetOpenCourses',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/openCourses',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOpenCoursesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetOpenCoursesRequest $request
     *
     * @return GetOpenCoursesResponse
     */
    public function getOpenCourses($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOpenCoursesHeaders([]);

        return $this->getOpenCoursesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetPointActionRecordRequest $request
     * @param GetPointActionRecordHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetPointActionRecordResponse
     */
    public function getPointActionRecordWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizId)) {
            $query['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->pointType)) {
            $query['pointType'] = $request->pointType;
        }
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
            'action'      => 'GetPointActionRecord',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/points/actionRecords',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetPointActionRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetPointActionRecordRequest $request
     *
     * @return GetPointActionRecordResponse
     */
    public function getPointActionRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPointActionRecordHeaders([]);

        return $this->getPointActionRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetPointInfoRequest $request
     * @param GetPointInfoHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetPointInfoResponse
     */
    public function getPointInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pointType)) {
            $query['pointType'] = $request->pointType;
        }
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
            'action'      => 'GetPointInfo',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/points/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetPointInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetPointInfoRequest $request
     *
     * @return GetPointInfoResponse
     */
    public function getPointInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPointInfoHeaders([]);

        return $this->getPointInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                      $courseCode
     * @param GetRemoteClassCourseRequest $request
     * @param GetRemoteClassCourseHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetRemoteClassCourseResponse
     */
    public function getRemoteClassCourseWithOptions($courseCode, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operator)) {
            $query['operator'] = $request->operator;
        }
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
            'action'      => 'GetRemoteClassCourse',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/remoteClasses/courses/' . $courseCode . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetRemoteClassCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                      $courseCode
     * @param GetRemoteClassCourseRequest $request
     *
     * @return GetRemoteClassCourseResponse
     */
    public function getRemoteClassCourse($courseCode, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRemoteClassCourseHeaders([]);

        return $this->getRemoteClassCourseWithOptions($courseCode, $request, $headers, $runtime);
    }

    /**
     * @param string                     $shareRoleCode
     * @param GetShareRoleMembersHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetShareRoleMembersResponse
     */
    public function getShareRoleMembersWithOptions($shareRoleCode, $headers, $runtime)
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
            'action'      => 'GetShareRoleMembers',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/shareRoles/' . $shareRoleCode . '/members',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetShareRoleMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $shareRoleCode
     *
     * @return GetShareRoleMembersResponse
     */
    public function getShareRoleMembers($shareRoleCode)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetShareRoleMembersHeaders([]);

        return $this->getShareRoleMembersWithOptions($shareRoleCode, $headers, $runtime);
    }

    /**
     * @param GetShareRolesHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetShareRolesResponse
     */
    public function getShareRolesWithOptions($headers, $runtime)
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
            'action'      => 'GetShareRoles',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/shareRoles',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetShareRolesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return GetShareRolesResponse
     */
    public function getShareRoles()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetShareRolesHeaders([]);

        return $this->getShareRolesWithOptions($headers, $runtime);
    }

    /**
     * @param GetTaskListRequest $request
     * @param GetTaskListHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetTaskListResponse
     */
    public function getTaskListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operator)) {
            $query['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->taskYear)) {
            $query['taskYear'] = $request->taskYear;
        }
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
            'action'      => 'GetTaskList',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/newGrades/tasks/lists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTaskListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetTaskListRequest $request
     *
     * @return GetTaskListResponse
     */
    public function getTaskList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTaskListHeaders([]);

        return $this->getTaskListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetTaskStudentListRequest $request
     * @param GetTaskStudentListHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetTaskStudentListResponse
     */
    public function getTaskStudentListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operator)) {
            $query['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->taskId)) {
            $query['taskId'] = $request->taskId;
        }
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
            'action'      => 'GetTaskStudentList',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/newGrades/tasks/students/lists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTaskStudentListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetTaskStudentListRequest $request
     *
     * @return GetTaskStudentListResponse
     */
    public function getTaskStudentList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTaskStudentListHeaders([]);

        return $this->getTaskStudentListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                    $classId
     * @param InitCoursesOfClassRequest $request
     * @param InitCoursesOfClassHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return InitCoursesOfClassResponse
     */
    public function initCoursesOfClassWithOptions($classId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->courses)) {
            $body['courses'] = $request->courses;
        }
        if (!Utils::isUnset($request->sectionConfig)) {
            $body['sectionConfig'] = $request->sectionConfig;
        }
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
            'action'      => 'InitCoursesOfClass',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/classes/' . $classId . '/courses/init',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return InitCoursesOfClassResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                    $classId
     * @param InitCoursesOfClassRequest $request
     *
     * @return InitCoursesOfClassResponse
     */
    public function initCoursesOfClass($classId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InitCoursesOfClassHeaders([]);

        return $this->initCoursesOfClassWithOptions($classId, $request, $headers, $runtime);
    }

    /**
     * @param InitDeviceRequest $request
     * @param InitDeviceHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return InitDeviceResponse
     */
    public function initDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->encryptPubKey)) {
            $body['encryptPubKey'] = $request->encryptPubKey;
        }
        if (!Utils::isUnset($request->signature)) {
            $body['signature'] = $request->signature;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->timestamp)) {
            $body['timestamp'] = $request->timestamp;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'InitDevice',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/devices/init',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InitDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param InitDeviceRequest $request
     *
     * @return InitDeviceResponse
     */
    public function initDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InitDeviceHeaders([]);

        return $this->initDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param InitVPaasDeviceRequest $request
     * @param InitVPaasDeviceHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return InitVPaasDeviceResponse
     */
    public function initVPaasDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->timestamp)) {
            $body['timestamp'] = $request->timestamp;
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
            'action'      => 'InitVPaasDevice',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/vpaas/devices/init',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InitVPaasDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param InitVPaasDeviceRequest $request
     *
     * @return InitVPaasDeviceResponse
     */
    public function initVPaasDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InitVPaasDeviceHeaders([]);

        return $this->initVPaasDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param InsertSectionConfigRequest $request
     * @param InsertSectionConfigHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return InsertSectionConfigResponse
     */
    public function insertSectionConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->end)) {
            $body['end'] = $request->end;
        }
        if (!Utils::isUnset($request->scheduleName)) {
            $body['scheduleName'] = $request->scheduleName;
        }
        if (!Utils::isUnset($request->sectionModels)) {
            $body['sectionModels'] = $request->sectionModels;
        }
        if (!Utils::isUnset($request->start)) {
            $body['start'] = $request->start;
        }
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
            'action'      => 'InsertSectionConfig',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/schedules/configs',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return InsertSectionConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param InsertSectionConfigRequest $request
     *
     * @return InsertSectionConfigResponse
     */
    public function insertSectionConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertSectionConfigHeaders([]);

        return $this->insertSectionConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListOrderRequest $request
     * @param ListOrderHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return ListOrderResponse
     */
    public function listOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->createTimeEnd)) {
            $body['createTimeEnd'] = $request->createTimeEnd;
        }
        if (!Utils::isUnset($request->createTimeStart)) {
            $body['createTimeStart'] = $request->createTimeStart;
        }
        if (!Utils::isUnset($request->merchantId)) {
            $body['merchantId'] = $request->merchantId;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->scene)) {
            $body['scene'] = $request->scene;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->tradeNo)) {
            $body['tradeNo'] = $request->tradeNo;
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
            'action'      => 'ListOrder',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/orders/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListOrderRequest $request
     *
     * @return ListOrderResponse
     */
    public function listOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListOrderHeaders([]);

        return $this->listOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param MoveStudentRequest $request
     * @param MoveStudentHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return MoveStudentResponse
     */
    public function moveStudentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->originClassId)) {
            $body['originClassId'] = $request->originClassId;
        }
        if (!Utils::isUnset($request->targetClassId)) {
            $body['targetClassId'] = $request->targetClassId;
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
            'action'      => 'MoveStudent',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/students/move',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return MoveStudentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param MoveStudentRequest $request
     *
     * @return MoveStudentResponse
     */
    public function moveStudent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MoveStudentHeaders([]);

        return $this->moveStudentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PageQueryDevicesRequest $request
     * @param PageQueryDevicesHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return PageQueryDevicesResponse
     */
    public function pageQueryDevicesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->type)) {
            $query['type'] = $request->type;
        }
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
            'action'      => 'PageQueryDevices',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/vpaas/devices',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PageQueryDevicesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PageQueryDevicesRequest $request
     *
     * @return PageQueryDevicesResponse
     */
    public function pageQueryDevices($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageQueryDevicesHeaders([]);

        return $this->pageQueryDevicesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PayOrderRequest $request
     * @param PayOrderHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return PayOrderResponse
     */
    public function payOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->faceId)) {
            $body['faceId'] = $request->faceId;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->signature)) {
            $body['signature'] = $request->signature;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->timestamp)) {
            $body['timestamp'] = $request->timestamp;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'PayOrder',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/orders/pay',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PayOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PayOrderRequest $request
     *
     * @return PayOrderResponse
     */
    public function payOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PayOrderHeaders([]);

        return $this->payOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PollingConfirmStatusRequest $request
     * @param PollingConfirmStatusHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return PollingConfirmStatusResponse
     */
    public function pollingConfirmStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->courseCode)) {
            $query['courseCode'] = $request->courseCode;
        }
        if (!Utils::isUnset($request->ext)) {
            $query['ext'] = $request->ext;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $query['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
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
            'action'      => 'PollingConfirmStatus',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/universities/courses/pollingConfirmStatus',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PollingConfirmStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PollingConfirmStatusRequest $request
     *
     * @return PollingConfirmStatusResponse
     */
    public function pollingConfirmStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PollingConfirmStatusHeaders([]);

        return $this->pollingConfirmStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PreDialRequest $request
     * @param PreDialHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return PreDialResponse
     */
    public function preDialWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->callerUserId)) {
            $body['callerUserId'] = $request->callerUserId;
        }
        if (!Utils::isUnset($request->receiverUserId)) {
            $body['receiverUserId'] = $request->receiverUserId;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
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
            'action'      => 'PreDial',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/vpaas/devices/preDial',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PreDialResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PreDialRequest $request
     *
     * @return PreDialResponse
     */
    public function preDial($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PreDialHeaders([]);

        return $this->preDialWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ProvidePointRequest $request
     * @param ProvidePointHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return ProvidePointResponse
     */
    public function providePointWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionCode)) {
            $body['actionCode'] = $request->actionCode;
        }
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->pointType)) {
            $body['pointType'] = $request->pointType;
        }
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
            'action'      => 'ProvidePoint',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/points/provide',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ProvidePointResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ProvidePointRequest $request
     *
     * @return ProvidePointResponse
     */
    public function providePoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ProvidePointHeaders([]);

        return $this->providePointWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllSubjectsFromClassScheduleRequest $tmpReq
     * @param QueryAllSubjectsFromClassScheduleHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return QueryAllSubjectsFromClassScheduleResponse
     */
    public function queryAllSubjectsFromClassScheduleWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new QueryAllSubjectsFromClassScheduleShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->classIds)) {
            $request->classIdsShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->classIds, 'classIds', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->classIdsShrink)) {
            $query['classIds'] = $request->classIdsShrink;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->periodCode)) {
            $query['periodCode'] = $request->periodCode;
        }
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
            'action'      => 'QueryAllSubjectsFromClassSchedule',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/subjects/instances',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryAllSubjectsFromClassScheduleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryAllSubjectsFromClassScheduleRequest $request
     *
     * @return QueryAllSubjectsFromClassScheduleResponse
     */
    public function queryAllSubjectsFromClassSchedule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllSubjectsFromClassScheduleHeaders([]);

        return $this->queryAllSubjectsFromClassScheduleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryClassScheduleRequest $request
     * @param QueryClassScheduleHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryClassScheduleResponse
     */
    public function queryClassScheduleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->subscriberType)) {
            $query['subscriberType'] = $request->subscriberType;
        }
        $body = [];
        if (!Utils::isUnset($request->sectionIndexList)) {
            $body['sectionIndexList'] = $request->sectionIndexList;
        }
        if (!Utils::isUnset($request->subscriberIds)) {
            $body['subscriberIds'] = $request->subscriberIds;
        }
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
            'action'      => 'QueryClassSchedule',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/classes/schedules/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryClassScheduleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryClassScheduleRequest $request
     *
     * @return QueryClassScheduleResponse
     */
    public function queryClassSchedule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryClassScheduleHeaders([]);

        return $this->queryClassScheduleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryClassScheduleByTimeSchoolRequest $request
     * @param QueryClassScheduleByTimeSchoolHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryClassScheduleByTimeSchoolResponse
     */
    public function queryClassScheduleByTimeSchoolWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
        }
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
            'action'      => 'QueryClassScheduleByTimeSchool',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/schools/classes/courses ',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryClassScheduleByTimeSchoolResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryClassScheduleByTimeSchoolRequest $request
     *
     * @return QueryClassScheduleByTimeSchoolResponse
     */
    public function queryClassScheduleByTimeSchool($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryClassScheduleByTimeSchoolHeaders([]);

        return $this->queryClassScheduleByTimeSchoolWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryClassScheduleConfigRequest $tmpReq
     * @param QueryClassScheduleConfigHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return QueryClassScheduleConfigResponse
     */
    public function queryClassScheduleConfigWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new QueryClassScheduleConfigShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->classIds)) {
            $request->classIdsShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->classIds, 'classIds', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->classIdsShrink)) {
            $query['classIds'] = $request->classIdsShrink;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
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
            'action'      => 'QueryClassScheduleConfig',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/schedules/configs',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryClassScheduleConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryClassScheduleConfigRequest $request
     *
     * @return QueryClassScheduleConfigResponse
     */
    public function queryClassScheduleConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryClassScheduleConfigHeaders([]);

        return $this->queryClassScheduleConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDeviceRequest $request
     * @param QueryDeviceHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return QueryDeviceResponse
     */
    public function queryDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->sn)) {
            $query['sn'] = $request->sn;
        }
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
            'action'      => 'QueryDevice',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/vpass/devices/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryDeviceRequest $request
     *
     * @return QueryDeviceResponse
     */
    public function queryDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceHeaders([]);

        return $this->queryDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDeviceListByCorpIdRequest $request
     * @param QueryDeviceListByCorpIdHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return QueryDeviceListByCorpIdResponse
     */
    public function queryDeviceListByCorpIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operator)) {
            $query['operator'] = $request->operator;
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
            'action'      => 'QueryDeviceListByCorpId',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/remoteClasses/devices',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryDeviceListByCorpIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryDeviceListByCorpIdRequest $request
     *
     * @return QueryDeviceListByCorpIdResponse
     */
    public function queryDeviceListByCorpId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceListByCorpIdHeaders([]);

        return $this->queryDeviceListByCorpIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryEduAssetSpacesRequest $request
     * @param QueryEduAssetSpacesHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryEduAssetSpacesResponse
     */
    public function queryEduAssetSpacesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizCode)) {
            $query['bizCode'] = $request->bizCode;
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
            'action'      => 'QueryEduAssetSpaces',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/assets/spaces',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryEduAssetSpacesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryEduAssetSpacesRequest $request
     *
     * @return QueryEduAssetSpacesResponse
     */
    public function queryEduAssetSpaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryEduAssetSpacesHeaders([]);

        return $this->queryEduAssetSpacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryGroupIdRequest $request
     * @param QueryGroupIdHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return QueryGroupIdResponse
     */
    public function queryGroupIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->sn)) {
            $query['sn'] = $request->sn;
        }
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
            'action'      => 'QueryGroupId',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/faces/groups',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryGroupIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryGroupIdRequest $request
     *
     * @return QueryGroupIdResponse
     */
    public function queryGroupId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupIdHeaders([]);

        return $this->queryGroupIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryOrderRequest $request
     * @param QueryOrderHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return QueryOrderResponse
     */
    public function queryOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->alipayAppId)) {
            $query['alipayAppId'] = $request->alipayAppId;
        }
        if (!Utils::isUnset($request->merchantId)) {
            $query['merchantId'] = $request->merchantId;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $query['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->signature)) {
            $query['signature'] = $request->signature;
        }
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
            'action'      => 'QueryOrder',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/orders',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryOrderRequest $request
     *
     * @return QueryOrderResponse
     */
    public function queryOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrderHeaders([]);

        return $this->queryOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryOrgRelationListRequest $request
     * @param QueryOrgRelationListHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryOrgRelationListResponse
     */
    public function queryOrgRelationListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operator)) {
            $query['operator'] = $request->operator;
        }
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
            'action'      => 'QueryOrgRelationList',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/remoteClasses/orgRelations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryOrgRelationListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryOrgRelationListRequest $request
     *
     * @return QueryOrgRelationListResponse
     */
    public function queryOrgRelationList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgRelationListHeaders([]);

        return $this->queryOrgRelationListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryOrgSecretKeyRequest $request
     * @param QueryOrgSecretKeyHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return QueryOrgSecretKeyResponse
     */
    public function queryOrgSecretKeyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->isvCode)) {
            $query['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
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
            'action'      => 'QueryOrgSecretKey',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/universities/secretKeys',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryOrgSecretKeyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryOrgSecretKeyRequest $request
     *
     * @return QueryOrgSecretKeyResponse
     */
    public function queryOrgSecretKey($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgSecretKeyHeaders([]);

        return $this->queryOrgSecretKeyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryOrgTypeHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return QueryOrgTypeResponse
     */
    public function queryOrgTypeWithOptions($headers, $runtime)
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
            'action'      => 'QueryOrgType',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/orgTypes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryOrgTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return QueryOrgTypeResponse
     */
    public function queryOrgType()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgTypeHeaders([]);

        return $this->queryOrgTypeWithOptions($headers, $runtime);
    }

    /**
     * @param QueryPayResultRequest $request
     * @param QueryPayResultHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryPayResultResponse
     */
    public function queryPayResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->faceId)) {
            $body['faceId'] = $request->faceId;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->signature)) {
            $body['signature'] = $request->signature;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->timestamp)) {
            $body['timestamp'] = $request->timestamp;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'QueryPayResult',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/payResults/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryPayResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryPayResultRequest $request
     *
     * @return QueryPayResultResponse
     */
    public function queryPayResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPayResultHeaders([]);

        return $this->queryPayResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryPhysicalClassroomRequest $request
     * @param QueryPhysicalClassroomHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return QueryPhysicalClassroomResponse
     */
    public function queryPhysicalClassroomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->classroomId)) {
            $query['classroomId'] = $request->classroomId;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
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
            'action'      => 'QueryPhysicalClassroom',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/physicalClassrooms',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryPhysicalClassroomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryPhysicalClassroomRequest $request
     *
     * @return QueryPhysicalClassroomResponse
     */
    public function queryPhysicalClassroom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPhysicalClassroomHeaders([]);

        return $this->queryPhysicalClassroomWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryPurchaseInfoRequest $request
     * @param QueryPurchaseInfoHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return QueryPurchaseInfoResponse
     */
    public function queryPurchaseInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->merchantId)) {
            $query['merchantId'] = $request->merchantId;
        }
        if (!Utils::isUnset($request->scene)) {
            $query['scene'] = $request->scene;
        }
        if (!Utils::isUnset($request->sn)) {
            $query['sn'] = $request->sn;
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
            'action'      => 'QueryPurchaseInfo',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/users/purchases',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryPurchaseInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryPurchaseInfoRequest $request
     *
     * @return QueryPurchaseInfoResponse
     */
    public function queryPurchaseInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPurchaseInfoHeaders([]);

        return $this->queryPurchaseInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryRemoteClassCourseRequest $request
     * @param QueryRemoteClassCourseHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return QueryRemoteClassCourseResponse
     */
    public function queryRemoteClassCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->operator)) {
            $query['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
        }
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
            'action'      => 'QueryRemoteClassCourse',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/remoteClasses/courses',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryRemoteClassCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryRemoteClassCourseRequest $request
     *
     * @return QueryRemoteClassCourseResponse
     */
    public function queryRemoteClassCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRemoteClassCourseHeaders([]);

        return $this->queryRemoteClassCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QuerySchoolUserFaceRequest $request
     * @param QuerySchoolUserFaceHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QuerySchoolUserFaceResponse
     */
    public function querySchoolUserFaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->sn)) {
            $query['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->type)) {
            $query['type'] = $request->type;
        }
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
            'action'      => 'QuerySchoolUserFace',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/schools/faces',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QuerySchoolUserFaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QuerySchoolUserFaceRequest $request
     *
     * @return QuerySchoolUserFaceResponse
     */
    public function querySchoolUserFace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySchoolUserFaceHeaders([]);

        return $this->querySchoolUserFaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QuerySnsOrderRequest $request
     * @param QuerySnsOrderHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return QuerySnsOrderResponse
     */
    public function querySnsOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->alipayAppId)) {
            $query['alipayAppId'] = $request->alipayAppId;
        }
        if (!Utils::isUnset($request->merchantId)) {
            $query['merchantId'] = $request->merchantId;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $query['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->signature)) {
            $query['signature'] = $request->signature;
        }
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
            'action'      => 'QuerySnsOrder',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/snsOrders',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QuerySnsOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QuerySnsOrderRequest $request
     *
     * @return QuerySnsOrderResponse
     */
    public function querySnsOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySnsOrderHeaders([]);

        return $this->querySnsOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryStatisticsDataRequest $request
     * @param QueryStatisticsDataHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryStatisticsDataResponse
     */
    public function queryStatisticsDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
        }
        $body = [];
        if (!Utils::isUnset($request->sectionIndexList)) {
            $body['sectionIndexList'] = $request->sectionIndexList;
        }
        if (!Utils::isUnset($request->teacherUserIds)) {
            $body['teacherUserIds'] = $request->teacherUserIds;
        }
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
            'action'      => 'QueryStatisticsData',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/classes/schedules/statisticData/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryStatisticsDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryStatisticsDataRequest $request
     *
     * @return QueryStatisticsDataResponse
     */
    public function queryStatisticsData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryStatisticsDataHeaders([]);

        return $this->queryStatisticsDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QuerySubjectTeachersRequest $request
     * @param QuerySubjectTeachersHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QuerySubjectTeachersResponse
     */
    public function querySubjectTeachersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->classIds)) {
            $query['classIds'] = $request->classIds;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->subjectCode)) {
            $query['subjectCode'] = $request->subjectCode;
        }
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
            'action'      => 'QuerySubjectTeachers',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/subjects/teachers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QuerySubjectTeachersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QuerySubjectTeachersRequest $request
     *
     * @return QuerySubjectTeachersResponse
     */
    public function querySubjectTeachers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySubjectTeachersHeaders([]);

        return $this->querySubjectTeachersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryTeachSubjectsRequest $request
     * @param QueryTeachSubjectsHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryTeachSubjectsResponse
     */
    public function queryTeachSubjectsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->classIds)) {
            $query['classIds'] = $request->classIds;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
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
            'action'      => 'QueryTeachSubjects',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/teachers/subjects',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryTeachSubjectsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryTeachSubjectsRequest $request
     *
     * @return QueryTeachSubjectsResponse
     */
    public function queryTeachSubjects($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTeachSubjectsHeaders([]);

        return $this->queryTeachSubjectsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryUniversityCourseGroupRequest $request
     * @param QueryUniversityCourseGroupHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return QueryUniversityCourseGroupResponse
     */
    public function queryUniversityCourseGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->courseGroupCode)) {
            $query['courseGroupCode'] = $request->courseGroupCode;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
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
            'action'      => 'QueryUniversityCourseGroup',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/universities/courseGroups',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryUniversityCourseGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryUniversityCourseGroupRequest $request
     *
     * @return QueryUniversityCourseGroupResponse
     */
    public function queryUniversityCourseGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUniversityCourseGroupHeaders([]);

        return $this->queryUniversityCourseGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryUserFaceRequest $request
     * @param QueryUserFaceHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return QueryUserFaceResponse
     */
    public function queryUserFaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->faceId)) {
            $query['faceId'] = $request->faceId;
        }
        if (!Utils::isUnset($request->sn)) {
            $query['sn'] = $request->sn;
        }
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
            'action'      => 'QueryUserFace',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/users/faces',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryUserFaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryUserFaceRequest $request
     *
     * @return QueryUserFaceResponse
     */
    public function queryUserFace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserFaceHeaders([]);

        return $this->queryUserFaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryUserPayInfoRequest $request
     * @param QueryUserPayInfoHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QueryUserPayInfoResponse
     */
    public function queryUserPayInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->faceId)) {
            $query['faceId'] = $request->faceId;
        }
        if (!Utils::isUnset($request->sn)) {
            $query['sn'] = $request->sn;
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
            'action'      => 'QueryUserPayInfo',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/orders/payInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryUserPayInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryUserPayInfoRequest $request
     *
     * @return QueryUserPayInfoResponse
     */
    public function queryUserPayInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserPayInfoHeaders([]);

        return $this->queryUserPayInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RemoveDeviceRequest $request
     * @param RemoveDeviceHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return RemoveDeviceResponse
     */
    public function removeDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->merchantId)) {
            $query['merchantId'] = $request->merchantId;
        }
        if (!Utils::isUnset($request->sn)) {
            $query['sn'] = $request->sn;
        }
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
            'action'      => 'RemoveDevice',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/devices',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RemoveDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RemoveDeviceRequest $request
     *
     * @return RemoveDeviceResponse
     */
    public function removeDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveDeviceHeaders([]);

        return $this->removeDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReportDeviceLogRequest $request
     * @param ReportDeviceLogHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ReportDeviceLogResponse
     */
    public function reportDeviceLogWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->mediaId)) {
            $query['mediaId'] = $request->mediaId;
        }
        if (!Utils::isUnset($request->sn)) {
            $query['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->type)) {
            $query['type'] = $request->type;
        }
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
            'action'      => 'ReportDeviceLog',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/deviceLogs/report',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ReportDeviceLogResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ReportDeviceLogRequest $request
     *
     * @return ReportDeviceLogResponse
     */
    public function reportDeviceLog($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReportDeviceLogHeaders([]);

        return $this->reportDeviceLogWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReportDeviceUseLogRequest $request
     * @param ReportDeviceUseLogHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return ReportDeviceUseLogResponse
     */
    public function reportDeviceUseLogWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
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
            'action'      => 'ReportDeviceUseLog',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/deviceUseLogs/report',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ReportDeviceUseLogResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ReportDeviceUseLogRequest $request
     *
     * @return ReportDeviceUseLogResponse
     */
    public function reportDeviceUseLog($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReportDeviceUseLogHeaders([]);

        return $this->reportDeviceUseLogWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RollbackDeductPointRequest $request
     * @param RollbackDeductPointHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return RollbackDeductPointResponse
     */
    public function rollbackDeductPointWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->pointType)) {
            $body['pointType'] = $request->pointType;
        }
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
            'action'      => 'RollbackDeductPoint',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/deductPoints/rollback',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RollbackDeductPointResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RollbackDeductPointRequest $request
     *
     * @return RollbackDeductPointResponse
     */
    public function rollbackDeductPoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RollbackDeductPointHeaders([]);

        return $this->rollbackDeductPointWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchTeachersRequest $request
     * @param SearchTeachersHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SearchTeachersResponse
     */
    public function searchTeachersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->nameKeyword)) {
            $query['nameKeyword'] = $request->nameKeyword;
        }
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
            'action'      => 'SearchTeachers',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/teachers/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return SearchTeachersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SearchTeachersRequest $request
     *
     * @return SearchTeachersResponse
     */
    public function searchTeachers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchTeachersHeaders([]);

        return $this->searchTeachersWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->fromUserId)) {
            $body['fromUserId'] = $request->fromUserId;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->toUserIdList)) {
            $body['toUserIdList'] = $request->toUserIdList;
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
            'action'      => 'SendMessage',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/messages/send',
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

    /**
     * @param StartCourseRequest $request
     * @param StartCourseHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return StartCourseResponse
     */
    public function startCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->courseCode)) {
            $body['courseCode'] = $request->courseCode;
        }
        if (!Utils::isUnset($request->ext)) {
            $body['ext'] = $request->ext;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->livePlayInfoList)) {
            $body['livePlayInfoList'] = $request->livePlayInfoList;
        }
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
            'action'      => 'StartCourse',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/universities/courses/start',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return StartCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param StartCourseRequest $request
     *
     * @return StartCourseResponse
     */
    public function startCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartCourseHeaders([]);

        return $this->startCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @param StartCoursePrepareRequest $request
     * @param StartCoursePrepareHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return StartCoursePrepareResponse
     */
    public function startCoursePrepareWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->courseDate)) {
            $body['courseDate'] = $request->courseDate;
        }
        if (!Utils::isUnset($request->courseGroupCode)) {
            $body['courseGroupCode'] = $request->courseGroupCode;
        }
        if (!Utils::isUnset($request->deviceId)) {
            $body['deviceId'] = $request->deviceId;
        }
        if (!Utils::isUnset($request->ext)) {
            $body['ext'] = $request->ext;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->liveCoverImage)) {
            $body['liveCoverImage'] = $request->liveCoverImage;
        }
        if (!Utils::isUnset($request->sectionIndex)) {
            $body['sectionIndex'] = $request->sectionIndex;
        }
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
            'action'      => 'StartCoursePrepare',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/universities/courses/prepare',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return StartCoursePrepareResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param StartCoursePrepareRequest $request
     *
     * @return StartCoursePrepareResponse
     */
    public function startCoursePrepare($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartCoursePrepareHeaders([]);

        return $this->startCoursePrepareWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SubscribeUniversityCourseGroupRequest $request
     * @param SubscribeUniversityCourseGroupHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return SubscribeUniversityCourseGroupResponse
     */
    public function subscribeUniversityCourseGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->courseGroupCode)) {
            $body['courseGroupCode'] = $request->courseGroupCode;
        }
        if (!Utils::isUnset($request->studentUserIds)) {
            $body['studentUserIds'] = $request->studentUserIds;
        }
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
            'action'      => 'SubscribeUniversityCourseGroup',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/universities/courseGroups/subscribe',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return SubscribeUniversityCourseGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SubscribeUniversityCourseGroupRequest $request
     *
     * @return SubscribeUniversityCourseGroupResponse
     */
    public function subscribeUniversityCourseGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SubscribeUniversityCourseGroupHeaders([]);

        return $this->subscribeUniversityCourseGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UnsubscribeUniversityCourseGroupRequest $request
     * @param UnsubscribeUniversityCourseGroupHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return UnsubscribeUniversityCourseGroupResponse
     */
    public function unsubscribeUniversityCourseGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->courseGroupCode)) {
            $body['courseGroupCode'] = $request->courseGroupCode;
        }
        if (!Utils::isUnset($request->studentUserIds)) {
            $body['studentUserIds'] = $request->studentUserIds;
        }
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
            'action'      => 'UnsubscribeUniversityCourseGroup',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/universities/courseGroups/unsubscribe',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UnsubscribeUniversityCourseGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UnsubscribeUniversityCourseGroupRequest $request
     *
     * @return UnsubscribeUniversityCourseGroupResponse
     */
    public function unsubscribeUniversityCourseGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnsubscribeUniversityCourseGroupHeaders([]);

        return $this->unsubscribeUniversityCourseGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                      $classId
     * @param UpdateCoursesOfClassRequest $request
     * @param UpdateCoursesOfClassHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return UpdateCoursesOfClassResponse
     */
    public function updateCoursesOfClassWithOptions($classId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->courses)) {
            $body['courses'] = $request->courses;
        }
        if (!Utils::isUnset($request->sectionConfig)) {
            $body['sectionConfig'] = $request->sectionConfig;
        }
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
            'action'      => 'UpdateCoursesOfClass',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/classes/' . $classId . '/courses/schedules',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateCoursesOfClassResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                      $classId
     * @param UpdateCoursesOfClassRequest $request
     *
     * @return UpdateCoursesOfClassResponse
     */
    public function updateCoursesOfClass($classId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCoursesOfClassHeaders([]);

        return $this->updateCoursesOfClassWithOptions($classId, $request, $headers, $runtime);
    }

    /**
     * @param UpdatePhysicalClassroomRequest $request
     * @param UpdatePhysicalClassroomHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return UpdatePhysicalClassroomResponse
     */
    public function updatePhysicalClassroomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->classroomBuilding)) {
            $body['classroomBuilding'] = $request->classroomBuilding;
        }
        if (!Utils::isUnset($request->classroomCampus)) {
            $body['classroomCampus'] = $request->classroomCampus;
        }
        if (!Utils::isUnset($request->classroomFloor)) {
            $body['classroomFloor'] = $request->classroomFloor;
        }
        if (!Utils::isUnset($request->classroomId)) {
            $body['classroomId'] = $request->classroomId;
        }
        if (!Utils::isUnset($request->classroomName)) {
            $body['classroomName'] = $request->classroomName;
        }
        if (!Utils::isUnset($request->classroomNumber)) {
            $body['classroomNumber'] = $request->classroomNumber;
        }
        if (!Utils::isUnset($request->directBroadcast)) {
            $body['directBroadcast'] = $request->directBroadcast;
        }
        if (!Utils::isUnset($request->ext)) {
            $body['ext'] = $request->ext;
        }
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
            'action'      => 'UpdatePhysicalClassroom',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/physicalClassrooms',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdatePhysicalClassroomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdatePhysicalClassroomRequest $request
     *
     * @return UpdatePhysicalClassroomResponse
     */
    public function updatePhysicalClassroom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdatePhysicalClassroomHeaders([]);

        return $this->updatePhysicalClassroomWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateRemoteClassCourseRequest $request
     * @param UpdateRemoteClassCourseHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return UpdateRemoteClassCourseResponse
     */
    public function updateRemoteClassCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attendParticipants)) {
            $body['attendParticipants'] = $request->attendParticipants;
        }
        if (!Utils::isUnset($request->authCode)) {
            $body['authCode'] = $request->authCode;
        }
        if (!Utils::isUnset($request->courseCode)) {
            $body['courseCode'] = $request->courseCode;
        }
        if (!Utils::isUnset($request->courseName)) {
            $body['courseName'] = $request->courseName;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->teachingParticipant)) {
            $body['teachingParticipant'] = $request->teachingParticipant;
        }
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
            'action'      => 'UpdateRemoteClassCourse',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/remoteClasses/courses',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateRemoteClassCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateRemoteClassCourseRequest $request
     *
     * @return UpdateRemoteClassCourseResponse
     */
    public function updateRemoteClassCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRemoteClassCourseHeaders([]);

        return $this->updateRemoteClassCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateRemoteClassDeviceRequest $request
     * @param UpdateRemoteClassDeviceHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return UpdateRemoteClassDeviceResponse
     */
    public function updateRemoteClassDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->authCode)) {
            $query['authCode'] = $request->authCode;
        }
        if (!Utils::isUnset($request->deviceCode)) {
            $query['deviceCode'] = $request->deviceCode;
        }
        if (!Utils::isUnset($request->deviceName)) {
            $query['deviceName'] = $request->deviceName;
        }
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
            'action'      => 'UpdateRemoteClassDevice',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/remoteClasses/deviceNames',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateRemoteClassDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateRemoteClassDeviceRequest $request
     *
     * @return UpdateRemoteClassDeviceResponse
     */
    public function updateRemoteClassDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRemoteClassDeviceHeaders([]);

        return $this->updateRemoteClassDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateUniversityCourseGroupRequest $request
     * @param UpdateUniversityCourseGroupHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return UpdateUniversityCourseGroupResponse
     */
    public function updateUniversityCourseGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->opUserId)) {
            $query['opUserId'] = $request->opUserId;
        }
        $body = [];
        if (!Utils::isUnset($request->courseGroupCode)) {
            $body['courseGroupCode'] = $request->courseGroupCode;
        }
        if (!Utils::isUnset($request->courseGroupIntroduce)) {
            $body['courseGroupIntroduce'] = $request->courseGroupIntroduce;
        }
        if (!Utils::isUnset($request->courseGroupName)) {
            $body['courseGroupName'] = $request->courseGroupName;
        }
        if (!Utils::isUnset($request->courserGroupItemModels)) {
            $body['courserGroupItemModels'] = $request->courserGroupItemModels;
        }
        if (!Utils::isUnset($request->ext)) {
            $body['ext'] = $request->ext;
        }
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
            'action'      => 'UpdateUniversityCourseGroup',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/universities/courseGroups',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateUniversityCourseGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateUniversityCourseGroupRequest $request
     *
     * @return UpdateUniversityCourseGroupResponse
     */
    public function updateUniversityCourseGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateUniversityCourseGroupHeaders([]);

        return $this->updateUniversityCourseGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param VPaasProxyRequest $request
     * @param VPaasProxyHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return VPaasProxyResponse
     */
    public function vPaasProxyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionCode)) {
            $body['actionCode'] = $request->actionCode;
        }
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
        }
        if (!Utils::isUnset($request->publicKey)) {
            $body['publicKey'] = $request->publicKey;
        }
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
            'action'      => 'VPaasProxy',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/vpaas/proxy',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return VPaasProxyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param VPaasProxyRequest $request
     *
     * @return VPaasProxyResponse
     */
    public function vPaasProxy($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new VPaasProxyHeaders([]);

        return $this->vPaasProxyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ValidateUserRoleRequest $request
     * @param ValidateUserRoleHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ValidateUserRoleResponse
     */
    public function validateUserRoleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->timeThreshold)) {
            $body['timeThreshold'] = $request->timeThreshold;
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
            'action'      => 'ValidateUserRole',
            'version'     => 'edu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/edu/users/roles/validate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ValidateUserRoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ValidateUserRoleRequest $request
     *
     * @return ValidateUserRoleResponse
     */
    public function validateUserRole($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateUserRoleHeaders([]);

        return $this->validateUserRoleWithOptions($request, $headers, $runtime);
    }
}
