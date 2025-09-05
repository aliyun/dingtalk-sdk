<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ActivateDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ActivateDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ActivateDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeAlumniDeptsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeAlumniDeptsRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeAlumniDeptsResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeAlumniUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeAlumniUserInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeAlumniUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeContactExclusiveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeContactExclusiveRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeContactExclusiveResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeContactUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeContactUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeContactUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCompetitionRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCompetitionRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCompetitionRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddEvaluatePerformanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddEvaluatePerformanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddEvaluatePerformanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddSchoolConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddSchoolConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddSchoolConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddTraceEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddTraceEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddTraceEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AdjustCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AdjustCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AdjustCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AdjustKitHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AdjustKitRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AdjustKitResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AssignClassHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AssignClassRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AssignClassResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateStudentClassHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateStudentClassRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateStudentClassResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateTeacherCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateTeacherCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateTeacherCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchInvalidCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchInvalidCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchInvalidCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchOrgCreateHWHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchOrgCreateHWRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchOrgCreateHWResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelKitTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelKitTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelKitTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelSnsOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelSnsOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelSnsOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelUserOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelUserOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CancelUserOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardBatchQueryCardsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardBatchQueryCardsRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardBatchQueryCardsResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardDeleteCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardDeleteCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardDeleteCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardEndCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardEndCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardEndCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardGetCardFinishProgressHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardGetCardFinishProgressRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardGetCardFinishProgressResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardGetCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardGetCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardGetCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardQueryCardFeedsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardQueryCardFeedsRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardQueryCardFeedsResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CheckRestrictionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CheckRestrictionRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CheckRestrictionResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ClearEvaluatePerformanceCountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ClearEvaluatePerformanceCountRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ClearEvaluatePerformanceCountResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ConsumePointHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ConsumePointRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ConsumePointResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CourseSchedulingComplimentNoticeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CourseSchedulingComplimentNoticeRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CourseSchedulingComplimentNoticeResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateAppOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateAppOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateAppOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCollegeContactDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCollegeContactDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCollegeContactDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCollegeContactSceneStruHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCollegeContactSceneStruRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCollegeContactSceneStruResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCourseResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateInviteUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateInviteUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateInviteUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateItemHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateItemRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateItemResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateKitTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateKitTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateKitTaskResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSnsAppOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSnsAppOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSnsAppOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateStsTokenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateStsTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateStsTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateStudentClassHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateStudentClassRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateStudentClassResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateTeacherCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateTeacherCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateTeacherCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateTimerCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateTimerCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateTimerCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateTokenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateTransferRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateTransferRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateTransferRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityStudentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityStudentRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityStudentResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityTeacherHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityTeacherRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityTeacherResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateWrongQuestionsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateWrongQuestionsRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateWrongQuestionsResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeactivateDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeactivateDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeactivateDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeductPointHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeductPointRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeductPointResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteCollegeAlumniDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteCollegeAlumniDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteCollegeAlumniDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteCollegeAlumniUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteCollegeAlumniUserInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteCollegeAlumniUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteCollegeContactSceneStruHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteCollegeContactSceneStruRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteCollegeContactSceneStruResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeviceOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeviceOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeviceOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteEvaluatePerformanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteEvaluatePerformanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteEvaluatePerformanceResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteSchoolReportHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteSchoolReportRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DeleteSchoolReportResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DisableCollegeContactSceneStruHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DisableCollegeContactSceneStruRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\DisableCollegeContactSceneStruResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduAIGCCallbackHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduAIGCCallbackRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduAIGCCallbackResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduAIModelCompleteHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduAIModelCompleteRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduAIModelCompleteResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduFindUserRolesByUserIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduFindUserRolesByUserIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduFindUserRolesByUserIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduGetFileSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduGetFileSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduGetFileSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduListUserByFromUserIdsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduListUserByFromUserIdsRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduListUserByFromUserIdsResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduTeacherListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduTeacherListRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduTeacherListResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EnableCollegeContactSceneStruHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EnableCollegeContactSceneStruRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EnableCollegeContactSceneStruResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EndCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EndCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EndCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EventTrackHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EventTrackRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EventTrackResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GenerateTaskIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GenerateTaskIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GenerateTaskIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetBindChildInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetBindChildInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetBindChildInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetChildrenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetChildrenResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeAlumniDeptsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeAlumniDeptsRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeAlumniDeptsResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeAlumniUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeAlumniUserInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeAlumniUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeContactDeptDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeContactDeptDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeContactDeptDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeContactStandardStruDeptDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeContactStandardStruDeptDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetCollegeContactStandardStruDeptDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetDefaultChildHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetDefaultChildResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetEduUserIdentityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetEduUserIdentityRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetEduUserIdentityResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetFileDownloadInfoByPackageIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetFileDownloadInfoByPackageIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetFileDownloadInfoByPackageIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetFileDownloadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetFileDownloadInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetFileDownloadInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetImageTempDownloadUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetImageTempDownloadUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetImageTempDownloadUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCourseDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCourseDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCoursesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCoursesRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCoursesResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetPointActionRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetPointActionRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetPointActionRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetPointActionRecordShrinkRequest;
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
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InvalidCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InvalidCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InvalidCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InvalidKitHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InvalidKitRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InvalidKitResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InvalidStudentClassHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InvalidStudentClassRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InvalidStudentClassResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InvalidTeacherCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InvalidTeacherCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InvalidTeacherCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\IsvDataWriteHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\IsvDataWriteRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\IsvDataWriteResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\IsvMetadataQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\IsvMetadataQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\IsvMetadataQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\IsYuwenCertifiedTeacherHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\IsYuwenCertifiedTeacherRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\IsYuwenCertifiedTeacherResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListCollegeContactDeptTypeConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListCollegeContactDeptTypeConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListCollegeContactDeptTypeConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListCollegeContactSceneStrusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListCollegeContactSceneStrusRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListCollegeContactSceneStrusResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListCollegeContactSubDeptsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListCollegeContactSubDeptsRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListCollegeContactSubDeptsResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\MoveStudentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\MoveStudentRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\MoveStudentResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\OpenKitHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\OpenKitRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\OpenKitResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\OrderInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\OrderInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\OrderInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PageQueryClassCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PageQueryClassCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PageQueryClassCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PageQueryDevicesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PageQueryDevicesRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PageQueryDevicesResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PageQueryKitOpenRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PageQueryKitOpenRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PageQueryKitOpenRecordResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PublishSchoolReportHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PublishSchoolReportRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PublishSchoolReportResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PushClassGroupCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PushClassGroupCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PushClassGroupCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryAllSubjectsFromClassScheduleShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassCourseResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryCollegeContactUserDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryCollegeContactUserDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryCollegeContactUserDetailResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryKitOpenRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryKitOpenRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryKitOpenRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryModelResultByTaskIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryModelResultByTaskIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryModelResultByTaskIdResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySchoolUserFaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySchoolUserFaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySchoolUserFaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySnsOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySnsOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySnsOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryStatisticsDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryStatisticsDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryStatisticsDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryStudentClassHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryStudentClassRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryStudentClassResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySubjectTeachersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySubjectTeachersRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySubjectTeachersResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTeacherCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTeacherCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTeacherCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTeachSubjectsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTeachSubjectsRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTeachSubjectsResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTransferCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTransferCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTransferCourseResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SaveClassLearningDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SaveClassLearningDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SaveClassLearningDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SaveStudentLearningDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SaveStudentLearningDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SaveStudentLearningDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SchoolReportDetailReadedHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SchoolReportDetailReadedRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SchoolReportDetailReadedResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SearchTeachersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SearchTeachersRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SearchTeachersResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendAiCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendAiCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendAiCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendCollegeAiAssistantMsgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendCollegeAiAssistantMsgRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendCollegeAiAssistantMsgResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendFileMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendFileMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendFileMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendPrintOrderNoticeMsgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendPrintOrderNoticeMsgRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SendPrintOrderNoticeMsgResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\StartCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\StartCoursePrepareHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\StartCoursePrepareRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\StartCoursePrepareResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\StartCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\StartCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SubmitAiSportDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SubmitAiSportDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SubmitAiSportDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SubscribeUniversityCourseGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SubscribeUniversityCourseGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SubscribeUniversityCourseGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UnsubscribeUniversityCourseGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UnsubscribeUniversityCourseGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UnsubscribeUniversityCourseGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateClassGroupCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateClassGroupCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateClassGroupCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateClassHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateClassRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateClassResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeAlumniUserInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeAlumniUserInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeAlumniUserInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeContactDeptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeContactDeptRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeContactDeptResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeContactExclusiveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeContactExclusiveRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeContactExclusiveResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeContactSceneStruHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeContactSceneStruRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeContactSceneStruResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeContactUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeContactUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeContactUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeUserEmpTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeUserEmpTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCollegeUserEmpTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateEvaluatePerformanceCountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateEvaluatePerformanceCountRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateEvaluatePerformanceCountResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateGuardianHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateGuardianRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateGuardianResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdatePhysicalClassroomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdatePhysicalClassroomRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdatePhysicalClassroomResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateRemoteClassCourseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateRemoteClassCourseRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateRemoteClassCourseResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateRemoteClassDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateRemoteClassDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateRemoteClassDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateStudentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateStudentRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateStudentResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateUniversityCourseGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateUniversityCourseGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateUniversityCourseGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UploadLearningDataCallbackHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UploadLearningDataCallbackRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UploadLearningDataCallbackResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ValidateNewGradeManagerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ValidateNewGradeManagerRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ValidateNewGradeManagerResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ValidateUserRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ValidateUserRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ValidateUserRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\VerifyEduOrgCertificationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\VerifyEduOrgCertificationRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\VerifyEduOrgCertificationResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\VerifyEduUserCertificationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\VerifyEduUserCertificationRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\VerifyEduUserCertificationResponse;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\VPaasProxyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\VPaasProxyRequest;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\VPaasProxyResponse;
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
     * @summary 视讯paas机具激活
     *  *
     * @param ActivateDeviceRequest $request ActivateDeviceRequest
     * @param ActivateDeviceHeaders $headers ActivateDeviceHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return ActivateDeviceResponse ActivateDeviceResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ActivateDevice',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/vpaas/devices/activate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ActivateDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 视讯paas机具激活
     *  *
     * @param ActivateDeviceRequest $request ActivateDeviceRequest
     *
     * @return ActivateDeviceResponse ActivateDeviceResponse
     */
    public function activateDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ActivateDeviceHeaders([]);

        return $this->activateDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 高校校友会批量创建部门
     *  *
     * @param AddCollegeAlumniDeptsRequest $request AddCollegeAlumniDeptsRequest
     * @param AddCollegeAlumniDeptsHeaders $headers AddCollegeAlumniDeptsHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return AddCollegeAlumniDeptsResponse AddCollegeAlumniDeptsResponse
     */
    public function addCollegeAlumniDeptsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->depts)) {
            $body['depts'] = $request->depts;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
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
            'action' => 'AddCollegeAlumniDepts',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeAlumni/depts/batch',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddCollegeAlumniDeptsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 高校校友会批量创建部门
     *  *
     * @param AddCollegeAlumniDeptsRequest $request AddCollegeAlumniDeptsRequest
     *
     * @return AddCollegeAlumniDeptsResponse AddCollegeAlumniDeptsResponse
     */
    public function addCollegeAlumniDepts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddCollegeAlumniDeptsHeaders([]);

        return $this->addCollegeAlumniDeptsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 高校校友会新增校友信息
     *  *
     * @param AddCollegeAlumniUserInfoRequest $request AddCollegeAlumniUserInfoRequest
     * @param AddCollegeAlumniUserInfoHeaders $headers AddCollegeAlumniUserInfoHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return AddCollegeAlumniUserInfoResponse AddCollegeAlumniUserInfoResponse
     */
    public function addCollegeAlumniUserInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->address)) {
            $body['address'] = $request->address;
        }
        if (!Utils::isUnset($request->deptIds)) {
            $body['deptIds'] = $request->deptIds;
        }
        if (!Utils::isUnset($request->email)) {
            $body['email'] = $request->email;
        }
        if (!Utils::isUnset($request->intake)) {
            $body['intake'] = $request->intake;
        }
        if (!Utils::isUnset($request->mobile)) {
            $body['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->outtake)) {
            $body['outtake'] = $request->outtake;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'AddCollegeAlumniUserInfo',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeAlumni/userInfos',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddCollegeAlumniUserInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 高校校友会新增校友信息
     *  *
     * @param AddCollegeAlumniUserInfoRequest $request AddCollegeAlumniUserInfoRequest
     *
     * @return AddCollegeAlumniUserInfoResponse AddCollegeAlumniUserInfoResponse
     */
    public function addCollegeAlumniUserInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddCollegeAlumniUserInfoHeaders([]);

        return $this->addCollegeAlumniUserInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建高校账号用户
     *  *
     * @param AddCollegeContactExclusiveRequest $request AddCollegeContactExclusiveRequest
     * @param AddCollegeContactExclusiveHeaders $headers AddCollegeContactExclusiveHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return AddCollegeContactExclusiveResponse AddCollegeContactExclusiveResponse
     */
    public function addCollegeContactExclusiveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->avatarMediaId)) {
            $body['avatarMediaId'] = $request->avatarMediaId;
        }
        if (!Utils::isUnset($request->deptIdList)) {
            $body['deptIdList'] = $request->deptIdList;
        }
        if (!Utils::isUnset($request->deptOrderList)) {
            $body['deptOrderList'] = $request->deptOrderList;
        }
        if (!Utils::isUnset($request->deptPositionSet)) {
            $body['deptPositionSet'] = $request->deptPositionSet;
        }
        if (!Utils::isUnset($request->deptTitleList)) {
            $body['deptTitleList'] = $request->deptTitleList;
        }
        if (!Utils::isUnset($request->email)) {
            $body['email'] = $request->email;
        }
        if (!Utils::isUnset($request->empType)) {
            $body['empType'] = $request->empType;
        }
        if (!Utils::isUnset($request->exclusiveAccount)) {
            $body['exclusiveAccount'] = $request->exclusiveAccount;
        }
        if (!Utils::isUnset($request->exclusiveAccountType)) {
            $body['exclusiveAccountType'] = $request->exclusiveAccountType;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->hiredDate)) {
            $body['hiredDate'] = $request->hiredDate;
        }
        if (!Utils::isUnset($request->initPassword)) {
            $body['initPassword'] = $request->initPassword;
        }
        if (!Utils::isUnset($request->jobNumber)) {
            $body['jobNumber'] = $request->jobNumber;
        }
        if (!Utils::isUnset($request->loginIdType)) {
            $body['loginIdType'] = $request->loginIdType;
        }
        if (!Utils::isUnset($request->mainDeptId)) {
            $body['mainDeptId'] = $request->mainDeptId;
        }
        if (!Utils::isUnset($request->managerUserid)) {
            $body['managerUserid'] = $request->managerUserid;
        }
        if (!Utils::isUnset($request->mobile)) {
            $body['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->nickname)) {
            $body['nickname'] = $request->nickname;
        }
        if (!Utils::isUnset($request->orgEmail)) {
            $body['orgEmail'] = $request->orgEmail;
        }
        if (!Utils::isUnset($request->orgEmailType)) {
            $body['orgEmailType'] = $request->orgEmailType;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->sendActiveSms)) {
            $body['sendActiveSms'] = $request->sendActiveSms;
        }
        if (!Utils::isUnset($request->seniorMode)) {
            $body['seniorMode'] = $request->seniorMode;
        }
        if (!Utils::isUnset($request->telephone)) {
            $body['telephone'] = $request->telephone;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->userid)) {
            $body['userid'] = $request->userid;
        }
        if (!Utils::isUnset($request->workPlace)) {
            $body['workPlace'] = $request->workPlace;
        }
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
            'action' => 'AddCollegeContactExclusive',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/exclusiveAccounts/users',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddCollegeContactExclusiveResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建高校账号用户
     *  *
     * @param AddCollegeContactExclusiveRequest $request AddCollegeContactExclusiveRequest
     *
     * @return AddCollegeContactExclusiveResponse AddCollegeContactExclusiveResponse
     */
    public function addCollegeContactExclusive($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddCollegeContactExclusiveHeaders([]);

        return $this->addCollegeContactExclusiveWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建个人账号用户
     *  *
     * @param AddCollegeContactUserRequest $request AddCollegeContactUserRequest
     * @param AddCollegeContactUserHeaders $headers AddCollegeContactUserHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return AddCollegeContactUserResponse AddCollegeContactUserResponse
     */
    public function addCollegeContactUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptIdList)) {
            $body['deptIdList'] = $request->deptIdList;
        }
        if (!Utils::isUnset($request->deptOrderList)) {
            $body['deptOrderList'] = $request->deptOrderList;
        }
        if (!Utils::isUnset($request->deptPositionSet)) {
            $body['deptPositionSet'] = $request->deptPositionSet;
        }
        if (!Utils::isUnset($request->deptTitleList)) {
            $body['deptTitleList'] = $request->deptTitleList;
        }
        if (!Utils::isUnset($request->email)) {
            $body['email'] = $request->email;
        }
        if (!Utils::isUnset($request->empType)) {
            $body['empType'] = $request->empType;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->hideMobile)) {
            $body['hideMobile'] = $request->hideMobile;
        }
        if (!Utils::isUnset($request->hiredDate)) {
            $body['hiredDate'] = $request->hiredDate;
        }
        if (!Utils::isUnset($request->jobNumber)) {
            $body['jobNumber'] = $request->jobNumber;
        }
        if (!Utils::isUnset($request->loginEmail)) {
            $body['loginEmail'] = $request->loginEmail;
        }
        if (!Utils::isUnset($request->mainDeptId)) {
            $body['mainDeptId'] = $request->mainDeptId;
        }
        if (!Utils::isUnset($request->managerUserid)) {
            $body['managerUserid'] = $request->managerUserid;
        }
        if (!Utils::isUnset($request->mobile)) {
            $body['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->orgEmail)) {
            $body['orgEmail'] = $request->orgEmail;
        }
        if (!Utils::isUnset($request->orgEmailType)) {
            $body['orgEmailType'] = $request->orgEmailType;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->sendActiveSms)) {
            $body['sendActiveSms'] = $request->sendActiveSms;
        }
        if (!Utils::isUnset($request->seniorMode)) {
            $body['seniorMode'] = $request->seniorMode;
        }
        if (!Utils::isUnset($request->telephone)) {
            $body['telephone'] = $request->telephone;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->userid)) {
            $body['userid'] = $request->userid;
        }
        if (!Utils::isUnset($request->workPlace)) {
            $body['workPlace'] = $request->workPlace;
        }
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
            'action' => 'AddCollegeContactUser',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/personalAccounts/users',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddCollegeContactUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建个人账号用户
     *  *
     * @param AddCollegeContactUserRequest $request AddCollegeContactUserRequest
     *
     * @return AddCollegeContactUserResponse AddCollegeContactUserResponse
     */
    public function addCollegeContactUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddCollegeContactUserHeaders([]);

        return $this->addCollegeContactUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 增加赛事记录
     *  *
     * @param AddCompetitionRecordRequest $request AddCompetitionRecordRequest
     * @param AddCompetitionRecordHeaders $headers AddCompetitionRecordHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return AddCompetitionRecordResponse AddCompetitionRecordResponse
     */
    public function addCompetitionRecordWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->competitionCode)) {
            $body['competitionCode'] = $request->competitionCode;
        }
        if (!Utils::isUnset($request->groupTemplateCode)) {
            $body['groupTemplateCode'] = $request->groupTemplateCode;
        }
        if (!Utils::isUnset($request->joinGroup)) {
            $body['joinGroup'] = $request->joinGroup;
        }
        if (!Utils::isUnset($request->participantName)) {
            $body['participantName'] = $request->participantName;
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
            'action' => 'AddCompetitionRecord',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/competitions/records',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddCompetitionRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 增加赛事记录
     *  *
     * @param AddCompetitionRecordRequest $request AddCompetitionRecordRequest
     *
     * @return AddCompetitionRecordResponse AddCompetitionRecordResponse
     */
    public function addCompetitionRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddCompetitionRecordHeaders([]);

        return $this->addCompetitionRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加设备
     *  *
     * @param AddDeviceRequest $request AddDeviceRequest
     * @param AddDeviceHeaders $headers AddDeviceHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return AddDeviceResponse AddDeviceResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'AddDevice',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/devices',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加设备
     *  *
     * @param AddDeviceRequest $request AddDeviceRequest
     *
     * @return AddDeviceResponse AddDeviceResponse
     */
    public function addDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddDeviceHeaders([]);

        return $this->addDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加评价表现数据
     *  *
     * @param AddEvaluatePerformanceRequest $request AddEvaluatePerformanceRequest
     * @param AddEvaluatePerformanceHeaders $headers AddEvaluatePerformanceHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return AddEvaluatePerformanceResponse AddEvaluatePerformanceResponse
     */
    public function addEvaluatePerformanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->evaluationData)) {
            $body['evaluationData'] = $request->evaluationData;
        }
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
            'action' => 'AddEvaluatePerformance',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/evaluations',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddEvaluatePerformanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加评价表现数据
     *  *
     * @param AddEvaluatePerformanceRequest $request AddEvaluatePerformanceRequest
     *
     * @return AddEvaluatePerformanceResponse AddEvaluatePerformanceResponse
     */
    public function addEvaluatePerformance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddEvaluatePerformanceHeaders([]);

        return $this->addEvaluatePerformanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加学校配置
     *  *
     * @param AddSchoolConfigRequest $request AddSchoolConfigRequest
     * @param AddSchoolConfigHeaders $headers AddSchoolConfigHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return AddSchoolConfigResponse AddSchoolConfigResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'AddSchoolConfig',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/schools/configurations',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddSchoolConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加学校配置
     *  *
     * @param AddSchoolConfigRequest $request AddSchoolConfigRequest
     *
     * @return AddSchoolConfigResponse AddSchoolConfigResponse
     */
    public function addSchoolConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddSchoolConfigHeaders([]);

        return $this->addSchoolConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新增用户事件跟踪日志
     *  *
     * @param AddTraceEventRequest $request AddTraceEventRequest
     * @param AddTraceEventHeaders $headers AddTraceEventHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return AddTraceEventResponse AddTraceEventResponse
     */
    public function addTraceEventWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionKey)) {
            $body['actionKey'] = $request->actionKey;
        }
        if (!Utils::isUnset($request->actionTime)) {
            $body['actionTime'] = $request->actionTime;
        }
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->bizReq)) {
            $body['bizReq'] = $request->bizReq;
        }
        if (!Utils::isUnset($request->bizResp)) {
            $body['bizResp'] = $request->bizResp;
        }
        if (!Utils::isUnset($request->deviceId)) {
            $body['deviceId'] = $request->deviceId;
        }
        if (!Utils::isUnset($request->eventId)) {
            $body['eventId'] = $request->eventId;
        }
        if (!Utils::isUnset($request->eventType)) {
            $body['eventType'] = $request->eventType;
        }
        if (!Utils::isUnset($request->eventUnit)) {
            $body['eventUnit'] = $request->eventUnit;
        }
        if (!Utils::isUnset($request->eventValue)) {
            $body['eventValue'] = $request->eventValue;
        }
        if (!Utils::isUnset($request->extend)) {
            $body['extend'] = $request->extend;
        }
        if (!Utils::isUnset($request->platform)) {
            $body['platform'] = $request->platform;
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
            'action' => 'AddTraceEvent',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/sns/users/events/traceLogs',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddTraceEventResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增用户事件跟踪日志
     *  *
     * @param AddTraceEventRequest $request AddTraceEventRequest
     *
     * @return AddTraceEventResponse AddTraceEventResponse
     */
    public function addTraceEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddTraceEventHeaders([]);

        return $this->addTraceEventWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改课程
     *  *
     * @param AdjustCourseRequest $request AdjustCourseRequest
     * @param AdjustCourseHeaders $headers AdjustCourseHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return AdjustCourseResponse AdjustCourseResponse
     */
    public function adjustCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attributes)) {
            $body['attributes'] = $request->attributes;
        }
        if (!Utils::isUnset($request->className)) {
            $body['className'] = $request->className;
        }
        if (!Utils::isUnset($request->classRoomId)) {
            $body['classRoomId'] = $request->classRoomId;
        }
        if (!Utils::isUnset($request->classRoomName)) {
            $body['classRoomName'] = $request->classRoomName;
        }
        if (!Utils::isUnset($request->classType)) {
            $body['classType'] = $request->classType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->courseCode)) {
            $body['courseCode'] = $request->courseCode;
        }
        if (!Utils::isUnset($request->courseDate)) {
            $body['courseDate'] = $request->courseDate;
        }
        if (!Utils::isUnset($request->courseName)) {
            $body['courseName'] = $request->courseName;
        }
        if (!Utils::isUnset($request->courseWeek)) {
            $body['courseWeek'] = $request->courseWeek;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->isvCourseId)) {
            $body['isvCourseId'] = $request->isvCourseId;
        }
        if (!Utils::isUnset($request->memo)) {
            $body['memo'] = $request->memo;
        }
        if (!Utils::isUnset($request->schoolYear)) {
            $body['schoolYear'] = $request->schoolYear;
        }
        if (!Utils::isUnset($request->semester)) {
            $body['semester'] = $request->semester;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->teachWeek)) {
            $body['teachWeek'] = $request->teachWeek;
        }
        if (!Utils::isUnset($request->timeslotName)) {
            $body['timeslotName'] = $request->timeslotName;
        }
        if (!Utils::isUnset($request->timeslotNum)) {
            $body['timeslotNum'] = $request->timeslotNum;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'AdjustCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/courses/adjust',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AdjustCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改课程
     *  *
     * @param AdjustCourseRequest $request AdjustCourseRequest
     *
     * @return AdjustCourseResponse AdjustCourseResponse
     */
    public function adjustCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AdjustCourseHeaders([]);

        return $this->adjustCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改教育套件
     *  *
     * @param AdjustKitRequest $request AdjustKitRequest
     * @param AdjustKitHeaders $headers AdjustKitHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return AdjustKitResponse AdjustKitResponse
     */
    public function adjustKitWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attributes)) {
            $body['attributes'] = $request->attributes;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->isvProductScene)) {
            $body['isvProductScene'] = $request->isvProductScene;
        }
        if (!Utils::isUnset($request->openEndTime)) {
            $body['openEndTime'] = $request->openEndTime;
        }
        if (!Utils::isUnset($request->openStartTime)) {
            $body['openStartTime'] = $request->openStartTime;
        }
        if (!Utils::isUnset($request->openUserId)) {
            $body['openUserId'] = $request->openUserId;
        }
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
            'action' => 'AdjustKit',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/records/adjust',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AdjustKitResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改教育套件
     *  *
     * @param AdjustKitRequest $request AdjustKitRequest
     *
     * @return AdjustKitResponse AdjustKitResponse
     */
    public function adjustKit($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AdjustKitHeaders([]);

        return $this->adjustKitWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 进行分班
     *  *
     * @param AssignClassRequest $request AssignClassRequest
     * @param AssignClassHeaders $headers AssignClassHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return AssignClassResponse AssignClassResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'AssignClass',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/newGrades/tasks/students/classes/assign',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AssignClassResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 进行分班
     *  *
     * @param AssignClassRequest $request AssignClassRequest
     *
     * @return AssignClassResponse AssignClassResponse
     */
    public function assignClass($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AssignClassHeaders([]);

        return $this->assignClassWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量创建打卡
     *  *
     * @param BatchCreateRequest $request BatchCreateRequest
     * @param BatchCreateHeaders $headers BatchCreateHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchCreateResponse BatchCreateResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'BatchCreate',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/cards',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return BatchCreateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量创建打卡
     *  *
     * @param BatchCreateRequest $request BatchCreateRequest
     *
     * @return BatchCreateResponse BatchCreateResponse
     */
    public function batchCreate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchCreateHeaders([]);

        return $this->batchCreateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量创建课程
     *  *
     * @param BatchCreateCourseRequest $request BatchCreateCourseRequest
     * @param BatchCreateCourseHeaders $headers BatchCreateCourseHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchCreateCourseResponse BatchCreateCourseResponse
     */
    public function batchCreateCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->className)) {
            $body['className'] = $request->className;
        }
        if (!Utils::isUnset($request->classType)) {
            $body['classType'] = $request->classType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->courseDetailItemList)) {
            $body['courseDetailItemList'] = $request->courseDetailItemList;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->schoolYear)) {
            $body['schoolYear'] = $request->schoolYear;
        }
        if (!Utils::isUnset($request->semester)) {
            $body['semester'] = $request->semester;
        }
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
            'action' => 'BatchCreateCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/courses/batchCreate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchCreateCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量创建课程
     *  *
     * @param BatchCreateCourseRequest $request BatchCreateCourseRequest
     *
     * @return BatchCreateCourseResponse BatchCreateCourseResponse
     */
    public function batchCreateCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchCreateCourseHeaders([]);

        return $this->batchCreateCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量创建学生班级
     *  *
     * @param BatchCreateStudentClassRequest $request BatchCreateStudentClassRequest
     * @param BatchCreateStudentClassHeaders $headers BatchCreateStudentClassHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchCreateStudentClassResponse BatchCreateStudentClassResponse
     */
    public function batchCreateStudentClassWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->className)) {
            $body['className'] = $request->className;
        }
        if (!Utils::isUnset($request->classType)) {
            $body['classType'] = $request->classType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->studentList)) {
            $body['studentList'] = $request->studentList;
        }
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
            'action' => 'BatchCreateStudentClass',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/students/classes/batchCreate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchCreateStudentClassResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量创建学生班级
     *  *
     * @param BatchCreateStudentClassRequest $request BatchCreateStudentClassRequest
     *
     * @return BatchCreateStudentClassResponse BatchCreateStudentClassResponse
     */
    public function batchCreateStudentClass($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchCreateStudentClassHeaders([]);

        return $this->batchCreateStudentClassWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量创建老师课程
     *  *
     * @param BatchCreateTeacherCourseRequest $request BatchCreateTeacherCourseRequest
     * @param BatchCreateTeacherCourseHeaders $headers BatchCreateTeacherCourseHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchCreateTeacherCourseResponse BatchCreateTeacherCourseResponse
     */
    public function batchCreateTeacherCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->teacherCourseDetailItemList)) {
            $body['teacherCourseDetailItemList'] = $request->teacherCourseDetailItemList;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'BatchCreateTeacherCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/teachers/courses/batchCreate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchCreateTeacherCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量创建老师课程
     *  *
     * @param BatchCreateTeacherCourseRequest $request BatchCreateTeacherCourseRequest
     *
     * @return BatchCreateTeacherCourseResponse BatchCreateTeacherCourseResponse
     */
    public function batchCreateTeacherCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchCreateTeacherCourseHeaders([]);

        return $this->batchCreateTeacherCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量失效课程
     *  *
     * @param BatchInvalidCourseRequest $request BatchInvalidCourseRequest
     * @param BatchInvalidCourseHeaders $headers BatchInvalidCourseHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchInvalidCourseResponse BatchInvalidCourseResponse
     */
    public function batchInvalidCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->isvCourseId)) {
            $body['isvCourseId'] = $request->isvCourseId;
        }
        if (!Utils::isUnset($request->isvCourseIds)) {
            $body['isvCourseIds'] = $request->isvCourseIds;
        }
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
            'action' => 'BatchInvalidCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/courses/batchInvalid',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchInvalidCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量失效课程
     *  *
     * @param BatchInvalidCourseRequest $request BatchInvalidCourseRequest
     *
     * @return BatchInvalidCourseResponse BatchInvalidCourseResponse
     */
    public function batchInvalidCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchInvalidCourseHeaders([]);

        return $this->batchInvalidCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 跨组织-批量创建作业
     *  *
     * @param BatchOrgCreateHWRequest $request BatchOrgCreateHWRequest
     * @param BatchOrgCreateHWHeaders $headers BatchOrgCreateHWHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchOrgCreateHWResponse BatchOrgCreateHWResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'BatchOrgCreateHW',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/homeworks',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return BatchOrgCreateHWResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 跨组织-批量创建作业
     *  *
     * @param BatchOrgCreateHWRequest $request BatchOrgCreateHWRequest
     *
     * @return BatchOrgCreateHWResponse BatchOrgCreateHWResponse
     */
    public function batchOrgCreateHW($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchOrgCreateHWHeaders([]);

        return $this->batchOrgCreateHWWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 套件-取消套件任务
     *  *
     * @param CancelKitTaskRequest $request CancelKitTaskRequest
     * @param CancelKitTaskHeaders $headers CancelKitTaskHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return CancelKitTaskResponse CancelKitTaskResponse
     */
    public function cancelKitTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->identifier)) {
            $body['identifier'] = $request->identifier;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
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
            'action' => 'CancelKitTask',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/tasks/cancel',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CancelKitTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 套件-取消套件任务
     *  *
     * @param CancelKitTaskRequest $request CancelKitTaskRequest
     *
     * @return CancelKitTaskResponse CancelKitTaskResponse
     */
    public function cancelKitTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelKitTaskHeaders([]);

        return $this->cancelKitTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 撤销订单
     *  *
     * @param CancelOrderRequest $request CancelOrderRequest
     * @param CancelOrderHeaders $headers CancelOrderHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return CancelOrderResponse CancelOrderResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CancelOrder',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/orders/cancel',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CancelOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 撤销订单
     *  *
     * @param CancelOrderRequest $request CancelOrderRequest
     *
     * @return CancelOrderResponse CancelOrderResponse
     */
    public function cancelOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelOrderHeaders([]);

        return $this->cancelOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 个人应用撤销订单
     *  *
     * @param CancelSnsOrderRequest $request CancelSnsOrderRequest
     * @param CancelSnsOrderHeaders $headers CancelSnsOrderHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CancelSnsOrderResponse CancelSnsOrderResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CancelSnsOrder',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/snsUserOrders/cancel',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CancelSnsOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 个人应用撤销订单
     *  *
     * @param CancelSnsOrderRequest $request CancelSnsOrderRequest
     *
     * @return CancelSnsOrderResponse CancelSnsOrderResponse
     */
    public function cancelSnsOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelSnsOrderHeaders([]);

        return $this->cancelSnsOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 取消订单
     *  *
     * @param CancelUserOrderRequest $request CancelUserOrderRequest
     * @param CancelUserOrderHeaders $headers CancelUserOrderHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return CancelUserOrderResponse CancelUserOrderResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CancelUserOrder',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/userOrders/cancel',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CancelUserOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 取消订单
     *  *
     * @param CancelUserOrderRequest $request CancelUserOrderRequest
     *
     * @return CancelUserOrderResponse CancelUserOrderResponse
     */
    public function cancelUserOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelUserOrderHeaders([]);

        return $this->cancelUserOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询打卡任务
     *  *
     * @param CardBatchQueryCardsRequest $request CardBatchQueryCardsRequest
     * @param CardBatchQueryCardsHeaders $headers CardBatchQueryCardsHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return CardBatchQueryCardsResponse CardBatchQueryCardsResponse
     */
    public function cardBatchQueryCardsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->cardBizCode)) {
            $body['cardBizCode'] = $request->cardBizCode;
        }
        if (!Utils::isUnset($request->cardIds)) {
            $body['cardIds'] = $request->cardIds;
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
            'action' => 'CardBatchQueryCards',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/cards/tasks/batch',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CardBatchQueryCardsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询打卡任务
     *  *
     * @param CardBatchQueryCardsRequest $request CardBatchQueryCardsRequest
     *
     * @return CardBatchQueryCardsResponse CardBatchQueryCardsResponse
     */
    public function cardBatchQueryCards($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CardBatchQueryCardsHeaders([]);

        return $this->cardBatchQueryCardsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除打卡
     *  *
     * @param CardDeleteCardRequest $request CardDeleteCardRequest
     * @param CardDeleteCardHeaders $headers CardDeleteCardHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CardDeleteCardResponse CardDeleteCardResponse
     */
    public function cardDeleteCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->cardBizCode)) {
            $query['cardBizCode'] = $request->cardBizCode;
        }
        if (!Utils::isUnset($request->cardBizId)) {
            $query['cardBizId'] = $request->cardBizId;
        }
        if (!Utils::isUnset($request->cardId)) {
            $query['cardId'] = $request->cardId;
        }
        if (!Utils::isUnset($request->sourceType)) {
            $query['sourceType'] = $request->sourceType;
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
            'action' => 'CardDeleteCard',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/cards',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CardDeleteCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除打卡
     *  *
     * @param CardDeleteCardRequest $request CardDeleteCardRequest
     *
     * @return CardDeleteCardResponse CardDeleteCardResponse
     */
    public function cardDeleteCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CardDeleteCardHeaders([]);

        return $this->cardDeleteCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 打卡-结束打卡
     *  *
     * @param CardEndCardRequest $request CardEndCardRequest
     * @param CardEndCardHeaders $headers CardEndCardHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return CardEndCardResponse CardEndCardResponse
     */
    public function cardEndCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->cardBizCode)) {
            $body['cardBizCode'] = $request->cardBizCode;
        }
        if (!Utils::isUnset($request->cardBizId)) {
            $body['cardBizId'] = $request->cardBizId;
        }
        if (!Utils::isUnset($request->cardId)) {
            $body['cardId'] = $request->cardId;
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
            'action' => 'CardEndCard',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/cards/finish',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CardEndCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 打卡-结束打卡
     *  *
     * @param CardEndCardRequest $request CardEndCardRequest
     *
     * @return CardEndCardResponse CardEndCardResponse
     */
    public function cardEndCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CardEndCardHeaders([]);

        return $this->cardEndCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询打卡任务
     *  *
     * @param CardGetCardRequest $request CardGetCardRequest
     * @param CardGetCardHeaders $headers CardGetCardHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return CardGetCardResponse CardGetCardResponse
     */
    public function cardGetCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->cardId)) {
            $query['cardId'] = $request->cardId;
        }
        if (!Utils::isUnset($request->sourceType)) {
            $query['sourceType'] = $request->sourceType;
        }
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
            'action' => 'CardGetCard',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/cards/tasks',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CardGetCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询打卡任务
     *  *
     * @param CardGetCardRequest $request CardGetCardRequest
     *
     * @return CardGetCardResponse CardGetCardResponse
     */
    public function cardGetCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CardGetCardHeaders([]);

        return $this->cardGetCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取打卡任务完成进度
     *  *
     * @param CardGetCardFinishProgressRequest $request CardGetCardFinishProgressRequest
     * @param CardGetCardFinishProgressHeaders $headers CardGetCardFinishProgressHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return CardGetCardFinishProgressResponse CardGetCardFinishProgressResponse
     */
    public function cardGetCardFinishProgressWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->cardBizCode)) {
            $query['cardBizCode'] = $request->cardBizCode;
        }
        if (!Utils::isUnset($request->cardBizId)) {
            $query['cardBizId'] = $request->cardBizId;
        }
        if (!Utils::isUnset($request->cardId)) {
            $query['cardId'] = $request->cardId;
        }
        if (!Utils::isUnset($request->sourceType)) {
            $query['sourceType'] = $request->sourceType;
        }
        if (!Utils::isUnset($request->studentId)) {
            $query['studentId'] = $request->studentId;
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
            'action' => 'CardGetCardFinishProgress',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/cards/completionProgress',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CardGetCardFinishProgressResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取打卡任务完成进度
     *  *
     * @param CardGetCardFinishProgressRequest $request CardGetCardFinishProgressRequest
     *
     * @return CardGetCardFinishProgressResponse CardGetCardFinishProgressResponse
     */
    public function cardGetCardFinishProgress($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CardGetCardFinishProgressHeaders([]);

        return $this->cardGetCardFinishProgressWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询打卡Feed流
     *  *
     * @param CardQueryCardFeedsRequest $request CardQueryCardFeedsRequest
     * @param CardQueryCardFeedsHeaders $headers CardQueryCardFeedsHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return CardQueryCardFeedsResponse CardQueryCardFeedsResponse
     */
    public function cardQueryCardFeedsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizType)) {
            $query['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->cardBizCode)) {
            $query['cardBizCode'] = $request->cardBizCode;
        }
        if (!Utils::isUnset($request->cardBizId)) {
            $query['cardBizId'] = $request->cardBizId;
        }
        if (!Utils::isUnset($request->cardId)) {
            $query['cardId'] = $request->cardId;
        }
        if (!Utils::isUnset($request->count)) {
            $query['count'] = $request->count;
        }
        if (!Utils::isUnset($request->cursor)) {
            $query['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->feedType)) {
            $query['feedType'] = $request->feedType;
        }
        if (!Utils::isUnset($request->needFinishProcess)) {
            $query['needFinishProcess'] = $request->needFinishProcess;
        }
        if (!Utils::isUnset($request->sourceType)) {
            $query['sourceType'] = $request->sourceType;
        }
        if (!Utils::isUnset($request->studentId)) {
            $query['studentId'] = $request->studentId;
        }
        if (!Utils::isUnset($request->subBizId)) {
            $query['subBizId'] = $request->subBizId;
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
            'action' => 'CardQueryCardFeeds',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/cards/feeds',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CardQueryCardFeedsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询打卡Feed流
     *  *
     * @param CardQueryCardFeedsRequest $request CardQueryCardFeedsRequest
     *
     * @return CardQueryCardFeedsResponse CardQueryCardFeedsResponse
     */
    public function cardQueryCardFeeds($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CardQueryCardFeedsHeaders([]);

        return $this->cardQueryCardFeedsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 支付校验
     *  *
     * @param CheckRestrictionRequest $request CheckRestrictionRequest
     * @param CheckRestrictionHeaders $headers CheckRestrictionHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return CheckRestrictionResponse CheckRestrictionResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CheckRestriction',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/restrictions/check',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CheckRestrictionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 支付校验
     *  *
     * @param CheckRestrictionRequest $request CheckRestrictionRequest
     *
     * @return CheckRestrictionResponse CheckRestrictionResponse
     */
    public function checkRestriction($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckRestrictionHeaders([]);

        return $this->checkRestrictionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 清空评价表现未读数量
     *  *
     * @param ClearEvaluatePerformanceCountRequest $request ClearEvaluatePerformanceCountRequest
     * @param ClearEvaluatePerformanceCountHeaders $headers ClearEvaluatePerformanceCountHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return ClearEvaluatePerformanceCountResponse ClearEvaluatePerformanceCountResponse
     */
    public function clearEvaluatePerformanceCountWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->studentIdList)) {
            $body['studentIdList'] = $request->studentIdList;
        }
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
            'action' => 'ClearEvaluatePerformanceCount',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/evaluations/unreadCounts/clear',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ClearEvaluatePerformanceCountResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 清空评价表现未读数量
     *  *
     * @param ClearEvaluatePerformanceCountRequest $request ClearEvaluatePerformanceCountRequest
     *
     * @return ClearEvaluatePerformanceCountResponse ClearEvaluatePerformanceCountResponse
     */
    public function clearEvaluatePerformanceCount($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ClearEvaluatePerformanceCountHeaders([]);

        return $this->clearEvaluatePerformanceCountWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 积分兑换
     *  *
     * @param ConsumePointRequest $request ConsumePointRequest
     * @param ConsumePointHeaders $headers ConsumePointHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return ConsumePointResponse ConsumePointResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ConsumePoint',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/poins/consume',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ConsumePointResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 积分兑换
     *  *
     * @param ConsumePointRequest $request ConsumePointRequest
     *
     * @return ConsumePointResponse ConsumePointResponse
     */
    public function consumePoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConsumePointHeaders([]);

        return $this->consumePointWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 全校排课结束通知
     *  *
     * @param CourseSchedulingComplimentNoticeRequest $request CourseSchedulingComplimentNoticeRequest
     * @param CourseSchedulingComplimentNoticeHeaders $headers CourseSchedulingComplimentNoticeHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return CourseSchedulingComplimentNoticeResponse CourseSchedulingComplimentNoticeResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'CourseSchedulingComplimentNotice',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/schedules/finishNotify',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CourseSchedulingComplimentNoticeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 全校排课结束通知
     *  *
     * @param CourseSchedulingComplimentNoticeRequest $request CourseSchedulingComplimentNoticeRequest
     *
     * @return CourseSchedulingComplimentNoticeResponse CourseSchedulingComplimentNoticeResponse
     */
    public function courseSchedulingComplimentNotice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CourseSchedulingComplimentNoticeHeaders([]);

        return $this->courseSchedulingComplimentNoticeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 错题本-添加错题
     *  *
     * @param CreateRequest  $request CreateRequest
     * @param CreateHeaders  $headers CreateHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateResponse CreateResponse
     */
    public function createWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->answerContent)) {
            $body['answerContent'] = $request->answerContent;
        }
        if (!Utils::isUnset($request->difficultyLevel)) {
            $body['difficultyLevel'] = $request->difficultyLevel;
        }
        if (!Utils::isUnset($request->explainAudio)) {
            $body['explainAudio'] = $request->explainAudio;
        }
        if (!Utils::isUnset($request->explainContent)) {
            $body['explainContent'] = $request->explainContent;
        }
        if (!Utils::isUnset($request->generateTime)) {
            $body['generateTime'] = $request->generateTime;
        }
        if (!Utils::isUnset($request->knowledgePointList)) {
            $body['knowledgePointList'] = $request->knowledgePointList;
        }
        if (!Utils::isUnset($request->ownerCode)) {
            $body['ownerCode'] = $request->ownerCode;
        }
        if (!Utils::isUnset($request->ownerType)) {
            $body['ownerType'] = $request->ownerType;
        }
        if (!Utils::isUnset($request->proficiencyLevel)) {
            $body['proficiencyLevel'] = $request->proficiencyLevel;
        }
        if (!Utils::isUnset($request->questionAudio)) {
            $body['questionAudio'] = $request->questionAudio;
        }
        if (!Utils::isUnset($request->questionContent)) {
            $body['questionContent'] = $request->questionContent;
        }
        if (!Utils::isUnset($request->questionExtension)) {
            $body['questionExtension'] = $request->questionExtension;
        }
        if (!Utils::isUnset($request->questionPicUrl)) {
            $body['questionPicUrl'] = $request->questionPicUrl;
        }
        if (!Utils::isUnset($request->questionType)) {
            $body['questionType'] = $request->questionType;
        }
        if (!Utils::isUnset($request->sourceCode)) {
            $body['sourceCode'] = $request->sourceCode;
        }
        if (!Utils::isUnset($request->studentUserId)) {
            $body['studentUserId'] = $request->studentUserId;
        }
        if (!Utils::isUnset($request->subject)) {
            $body['subject'] = $request->subject;
        }
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
            'action' => 'Create',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/wrongQuestions',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 错题本-添加错题
     *  *
     * @param CreateRequest $request CreateRequest
     *
     * @return CreateResponse CreateResponse
     */
    public function create($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateHeaders([]);

        return $this->createWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建App支付订单
     *  *
     * @param CreateAppOrderRequest $request CreateAppOrderRequest
     * @param CreateAppOrderHeaders $headers CreateAppOrderHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateAppOrderResponse CreateAppOrderResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateAppOrder',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/appOrders',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateAppOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建App支付订单
     *  *
     * @param CreateAppOrderRequest $request CreateAppOrderRequest
     *
     * @return CreateAppOrderResponse CreateAppOrderResponse
     */
    public function createAppOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateAppOrderHeaders([]);

        return $this->createAppOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建高校通讯录组织单元
     *  *
     * @param CreateCollegeContactDeptRequest $request CreateCollegeContactDeptRequest
     * @param CreateCollegeContactDeptHeaders $headers CreateCollegeContactDeptHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateCollegeContactDeptResponse CreateCollegeContactDeptResponse
     */
    public function createCollegeContactDeptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->autoApproveApply)) {
            $body['autoApproveApply'] = $request->autoApproveApply;
        }
        if (!Utils::isUnset($request->brief)) {
            $body['brief'] = $request->brief;
        }
        if (!Utils::isUnset($request->code)) {
            $body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->createDeptGroup)) {
            $body['createDeptGroup'] = $request->createDeptGroup;
        }
        if (!Utils::isUnset($request->deptCode)) {
            $body['deptCode'] = $request->deptCode;
        }
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->deptPermits)) {
            $body['deptPermits'] = $request->deptPermits;
        }
        if (!Utils::isUnset($request->deptType)) {
            $body['deptType'] = $request->deptType;
        }
        if (!Utils::isUnset($request->empApplyJoinDept)) {
            $body['empApplyJoinDept'] = $request->empApplyJoinDept;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->hideDept)) {
            $body['hideDept'] = $request->hideDept;
        }
        if (!Utils::isUnset($request->hideSceneConfig)) {
            $body['hideSceneConfig'] = $request->hideSceneConfig;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->order)) {
            $body['order'] = $request->order;
        }
        if (!Utils::isUnset($request->outerDept)) {
            $body['outerDept'] = $request->outerDept;
        }
        if (!Utils::isUnset($request->outerDeptOnlySelf)) {
            $body['outerDeptOnlySelf'] = $request->outerDeptOnlySelf;
        }
        if (!Utils::isUnset($request->outerPermitDepts)) {
            $body['outerPermitDepts'] = $request->outerPermitDepts;
        }
        if (!Utils::isUnset($request->outerPermitUsers)) {
            $body['outerPermitUsers'] = $request->outerPermitUsers;
        }
        if (!Utils::isUnset($request->outerSceneConfig)) {
            $body['outerSceneConfig'] = $request->outerSceneConfig;
        }
        if (!Utils::isUnset($request->parentId)) {
            $body['parentId'] = $request->parentId;
        }
        if (!Utils::isUnset($request->sourceIdentifier)) {
            $body['sourceIdentifier'] = $request->sourceIdentifier;
        }
        if (!Utils::isUnset($request->struId)) {
            $body['struId'] = $request->struId;
        }
        if (!Utils::isUnset($request->telephone)) {
            $body['telephone'] = $request->telephone;
        }
        if (!Utils::isUnset($request->userPermits)) {
            $body['userPermits'] = $request->userPermits;
        }
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
            'action' => 'CreateCollegeContactDept',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/depts',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateCollegeContactDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建高校通讯录组织单元
     *  *
     * @param CreateCollegeContactDeptRequest $request CreateCollegeContactDeptRequest
     *
     * @return CreateCollegeContactDeptResponse CreateCollegeContactDeptResponse
     */
    public function createCollegeContactDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCollegeContactDeptHeaders([]);

        return $this->createCollegeContactDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建高校通讯录场景架构
     *  *
     * @param CreateCollegeContactSceneStruRequest $request CreateCollegeContactSceneStruRequest
     * @param CreateCollegeContactSceneStruHeaders $headers CreateCollegeContactSceneStruHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateCollegeContactSceneStruResponse CreateCollegeContactSceneStruResponse
     */
    public function createCollegeContactSceneStruWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->hasStruFixedDept)) {
            $body['hasStruFixedDept'] = $request->hasStruFixedDept;
        }
        if (!Utils::isUnset($request->order)) {
            $body['order'] = $request->order;
        }
        if (!Utils::isUnset($request->sourceIdentifier)) {
            $body['sourceIdentifier'] = $request->sourceIdentifier;
        }
        if (!Utils::isUnset($request->struBrief)) {
            $body['struBrief'] = $request->struBrief;
        }
        if (!Utils::isUnset($request->struName)) {
            $body['struName'] = $request->struName;
        }
        if (!Utils::isUnset($request->struType)) {
            $body['struType'] = $request->struType;
        }
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
            'action' => 'CreateCollegeContactSceneStru',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/depts/structures/scenes',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateCollegeContactSceneStruResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建高校通讯录场景架构
     *  *
     * @param CreateCollegeContactSceneStruRequest $request CreateCollegeContactSceneStruRequest
     *
     * @return CreateCollegeContactSceneStruResponse CreateCollegeContactSceneStruResponse
     */
    public function createCollegeContactSceneStru($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCollegeContactSceneStruHeaders([]);

        return $this->createCollegeContactSceneStruWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建课程
     *  *
     * @param CreateCourseRequest $request CreateCourseRequest
     * @param CreateCourseHeaders $headers CreateCourseHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateCourseResponse CreateCourseResponse
     */
    public function createCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attributes)) {
            $body['attributes'] = $request->attributes;
        }
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->className)) {
            $body['className'] = $request->className;
        }
        if (!Utils::isUnset($request->classRoomId)) {
            $body['classRoomId'] = $request->classRoomId;
        }
        if (!Utils::isUnset($request->classRoomName)) {
            $body['classRoomName'] = $request->classRoomName;
        }
        if (!Utils::isUnset($request->classType)) {
            $body['classType'] = $request->classType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->courseCode)) {
            $body['courseCode'] = $request->courseCode;
        }
        if (!Utils::isUnset($request->courseDate)) {
            $body['courseDate'] = $request->courseDate;
        }
        if (!Utils::isUnset($request->courseName)) {
            $body['courseName'] = $request->courseName;
        }
        if (!Utils::isUnset($request->courseWeek)) {
            $body['courseWeek'] = $request->courseWeek;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->isvCourseId)) {
            $body['isvCourseId'] = $request->isvCourseId;
        }
        if (!Utils::isUnset($request->memo)) {
            $body['memo'] = $request->memo;
        }
        if (!Utils::isUnset($request->schoolYear)) {
            $body['schoolYear'] = $request->schoolYear;
        }
        if (!Utils::isUnset($request->semester)) {
            $body['semester'] = $request->semester;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->teachWeek)) {
            $body['teachWeek'] = $request->teachWeek;
        }
        if (!Utils::isUnset($request->teacherList)) {
            $body['teacherList'] = $request->teacherList;
        }
        if (!Utils::isUnset($request->timeslotName)) {
            $body['timeslotName'] = $request->timeslotName;
        }
        if (!Utils::isUnset($request->timeslotNum)) {
            $body['timeslotNum'] = $request->timeslotNum;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/courses',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建课程
     *  *
     * @param CreateCourseRequest $request CreateCourseRequest
     *
     * @return CreateCourseResponse CreateCourseResponse
     */
    public function createCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCourseHeaders([]);

        return $this->createCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建自定义部门下班级
     *  *
     * @param CreateCustomClassRequest $request CreateCustomClassRequest
     * @param CreateCustomClassHeaders $headers CreateCustomClassHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateCustomClassResponse CreateCustomClassResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateCustomClass',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/customClasses',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CreateCustomClassResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建自定义部门下班级
     *  *
     * @param CreateCustomClassRequest $request CreateCustomClassRequest
     *
     * @return CreateCustomClassResponse CreateCustomClassResponse
     */
    public function createCustomClass($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCustomClassHeaders([]);

        return $this->createCustomClassWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建自定义校区或部门
     *  *
     * @param CreateCustomDeptRequest $request CreateCustomDeptRequest
     * @param CreateCustomDeptHeaders $headers CreateCustomDeptHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateCustomDeptResponse CreateCustomDeptResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateCustomDept',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/customDepts',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CreateCustomDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建自定义校区或部门
     *  *
     * @param CreateCustomDeptRequest $request CreateCustomDeptRequest
     *
     * @return CreateCustomDeptResponse CreateCustomDeptResponse
     */
    public function createCustomDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCustomDeptHeaders([]);

        return $this->createCustomDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 教学资源库创建space
     *  *
     * @param CreateEduAssetSpaceRequest $request CreateEduAssetSpaceRequest
     * @param CreateEduAssetSpaceHeaders $headers CreateEduAssetSpaceHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateEduAssetSpaceResponse CreateEduAssetSpaceResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateEduAssetSpace',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/assets/spaces',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CreateEduAssetSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 教学资源库创建space
     *  *
     * @param CreateEduAssetSpaceRequest $request CreateEduAssetSpaceRequest
     *
     * @return CreateEduAssetSpaceResponse CreateEduAssetSpaceResponse
     */
    public function createEduAssetSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateEduAssetSpaceHeaders([]);

        return $this->createEduAssetSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建设备履约记录，亲情通话、考勤数据同步
     *  *
     * @param CreateFulfilRecordRequest $request CreateFulfilRecordRequest
     * @param CreateFulfilRecordHeaders $headers CreateFulfilRecordHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateFulfilRecordResponse CreateFulfilRecordResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateFulfilRecord',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/fulfilRecords',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateFulfilRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建设备履约记录，亲情通话、考勤数据同步
     *  *
     * @param CreateFulfilRecordRequest $request CreateFulfilRecordRequest
     *
     * @return CreateFulfilRecordResponse CreateFulfilRecordResponse
     */
    public function createFulfilRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateFulfilRecordHeaders([]);

        return $this->createFulfilRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询某个组织下面的设备列表
     *  *
     * @param CreateInviteUrlRequest $request CreateInviteUrlRequest
     * @param CreateInviteUrlHeaders $headers CreateInviteUrlHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateInviteUrlResponse CreateInviteUrlResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateInviteUrl',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/remoteClasses/orgRelations/inviteUrls',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CreateInviteUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询某个组织下面的设备列表
     *  *
     * @param CreateInviteUrlRequest $request CreateInviteUrlRequest
     *
     * @return CreateInviteUrlResponse CreateInviteUrlResponse
     */
    public function createInviteUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateInviteUrlHeaders([]);

        return $this->createInviteUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建商品
     *  *
     * @param CreateItemRequest $request CreateItemRequest
     * @param CreateItemHeaders $headers CreateItemHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateItemResponse CreateItemResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateItem',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/items',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateItemResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建商品
     *  *
     * @param CreateItemRequest $request CreateItemRequest
     *
     * @return CreateItemResponse CreateItemResponse
     */
    public function createItem($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateItemHeaders([]);

        return $this->createItemWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 套件-创建定时任务
     *  *
     * @param CreateKitTaskRequest $request CreateKitTaskRequest
     * @param CreateKitTaskHeaders $headers CreateKitTaskHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateKitTaskResponse CreateKitTaskResponse
     */
    public function createKitTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionTime)) {
            $body['actionTime'] = $request->actionTime;
        }
        if (!Utils::isUnset($request->bizData)) {
            $body['bizData'] = $request->bizData;
        }
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->identifier)) {
            $body['identifier'] = $request->identifier;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->memo)) {
            $body['memo'] = $request->memo;
        }
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
            'action' => 'CreateKitTask',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/timerTasks',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateKitTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 套件-创建定时任务
     *  *
     * @param CreateKitTaskRequest $request CreateKitTaskRequest
     *
     * @return CreateKitTaskResponse CreateKitTaskResponse
     */
    public function createKitTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateKitTaskHeaders([]);

        return $this->createKitTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建订单信息
     *  *
     * @param CreateOrderRequest $request CreateOrderRequest
     * @param CreateOrderHeaders $headers CreateOrderHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateOrderResponse CreateOrderResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateOrder',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/orders',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建订单信息
     *  *
     * @param CreateOrderRequest $request CreateOrderRequest
     *
     * @return CreateOrderResponse CreateOrderResponse
     */
    public function createOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateOrderHeaders([]);

        return $this->createOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建开单流水
     *  *
     * @param CreateOrderFlowRequest $request CreateOrderFlowRequest
     * @param CreateOrderFlowHeaders $headers CreateOrderFlowHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateOrderFlowResponse CreateOrderFlowResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateOrderFlow',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/orders/flows',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateOrderFlowResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建开单流水
     *  *
     * @param CreateOrderFlowRequest $request CreateOrderFlowRequest
     *
     * @return CreateOrderFlowResponse CreateOrderFlowResponse
     */
    public function createOrderFlow($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateOrderFlowHeaders([]);

        return $this->createOrderFlowWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加物理教室信息
     *  *
     * @param CreatePhysicalClassroomRequest $request CreatePhysicalClassroomRequest
     * @param CreatePhysicalClassroomHeaders $headers CreatePhysicalClassroomHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CreatePhysicalClassroomResponse CreatePhysicalClassroomResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreatePhysicalClassroom',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/physicalClassrooms',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CreatePhysicalClassroomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加物理教室信息
     *  *
     * @param CreatePhysicalClassroomRequest $request CreatePhysicalClassroomRequest
     *
     * @return CreatePhysicalClassroomResponse CreatePhysicalClassroomResponse
     */
    public function createPhysicalClassroom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreatePhysicalClassroomHeaders([]);

        return $this->createPhysicalClassroomWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建退款流水
     *  *
     * @param CreateRefundFlowRequest $request CreateRefundFlowRequest
     * @param CreateRefundFlowHeaders $headers CreateRefundFlowHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateRefundFlowResponse CreateRefundFlowResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateRefundFlow',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/refunds/flows',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateRefundFlowResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建退款流水
     *  *
     * @param CreateRefundFlowRequest $request CreateRefundFlowRequest
     *
     * @return CreateRefundFlowResponse CreateRefundFlowResponse
     */
    public function createRefundFlow($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateRefundFlowHeaders([]);

        return $this->createRefundFlowWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建预约类型的专递课堂
     *  *
     * @param CreateRemoteClassCourseRequest $request CreateRemoteClassCourseRequest
     * @param CreateRemoteClassCourseHeaders $headers CreateRemoteClassCourseHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateRemoteClassCourseResponse CreateRemoteClassCourseResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateRemoteClassCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/remoteClasses/courses',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CreateRemoteClassCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建预约类型的专递课堂
     *  *
     * @param CreateRemoteClassCourseRequest $request CreateRemoteClassCourseRequest
     *
     * @return CreateRemoteClassCourseResponse CreateRemoteClassCourseResponse
     */
    public function createRemoteClassCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateRemoteClassCourseHeaders([]);

        return $this->createRemoteClassCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 按学期创建课表模板
     *  *
     * @param CreateSectionConfigRequest $request CreateSectionConfigRequest
     * @param CreateSectionConfigHeaders $headers CreateSectionConfigHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateSectionConfigResponse CreateSectionConfigResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateSectionConfig',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/universities/sectionConfigs',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CreateSectionConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 按学期创建课表模板
     *  *
     * @param CreateSectionConfigRequest $request CreateSectionConfigRequest
     *
     * @return CreateSectionConfigResponse CreateSectionConfigResponse
     */
    public function createSectionConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSectionConfigHeaders([]);

        return $this->createSectionConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 个人应用创建APP订单
     *  *
     * @param CreateSnsAppOrderRequest $request CreateSnsAppOrderRequest
     * @param CreateSnsAppOrderHeaders $headers CreateSnsAppOrderHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateSnsAppOrderResponse CreateSnsAppOrderResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateSnsAppOrder',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/snsAppOrders',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateSnsAppOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 个人应用创建APP订单
     *  *
     * @param CreateSnsAppOrderRequest $request CreateSnsAppOrderRequest
     *
     * @return CreateSnsAppOrderResponse CreateSnsAppOrderResponse
     */
    public function createSnsAppOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSnsAppOrderHeaders([]);

        return $this->createSnsAppOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建ststoken
     *  *
     * @param CreateStsTokenRequest $request CreateStsTokenRequest
     * @param CreateStsTokenHeaders $headers CreateStsTokenHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateStsTokenResponse CreateStsTokenResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateStsToken',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/vpaas/ststoken',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateStsTokenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建ststoken
     *  *
     * @param CreateStsTokenRequest $request CreateStsTokenRequest
     *
     * @return CreateStsTokenResponse CreateStsTokenResponse
     */
    public function createStsToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateStsTokenHeaders([]);

        return $this->createStsTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建学生班级
     *  *
     * @param CreateStudentClassRequest $request CreateStudentClassRequest
     * @param CreateStudentClassHeaders $headers CreateStudentClassHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateStudentClassResponse CreateStudentClassResponse
     */
    public function createStudentClassWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attributes)) {
            $body['attributes'] = $request->attributes;
        }
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->className)) {
            $body['className'] = $request->className;
        }
        if (!Utils::isUnset($request->classType)) {
            $body['classType'] = $request->classType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->studentName)) {
            $body['studentName'] = $request->studentName;
        }
        if (!Utils::isUnset($request->studentUserId)) {
            $body['studentUserId'] = $request->studentUserId;
        }
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
            'action' => 'CreateStudentClass',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/students/classes',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateStudentClassResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建学生班级
     *  *
     * @param CreateStudentClassRequest $request CreateStudentClassRequest
     *
     * @return CreateStudentClassResponse CreateStudentClassResponse
     */
    public function createStudentClass($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateStudentClassHeaders([]);

        return $this->createStudentClassWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建老师课程
     *  *
     * @param CreateTeacherCourseRequest $request CreateTeacherCourseRequest
     * @param CreateTeacherCourseHeaders $headers CreateTeacherCourseHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTeacherCourseResponse CreateTeacherCourseResponse
     */
    public function createTeacherCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attributes)) {
            $body['attributes'] = $request->attributes;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->isvCourseId)) {
            $body['isvCourseId'] = $request->isvCourseId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateTeacherCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/teachers/courses',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateTeacherCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建老师课程
     *  *
     * @param CreateTeacherCourseRequest $request CreateTeacherCourseRequest
     *
     * @return CreateTeacherCourseResponse CreateTeacherCourseResponse
     */
    public function createTeacherCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTeacherCourseHeaders([]);

        return $this->createTeacherCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 套件-创建定时卡片
     *  *
     * @param CreateTimerCardRequest $request CreateTimerCardRequest
     * @param CreateTimerCardHeaders $headers CreateTimerCardHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTimerCardResponse CreateTimerCardResponse
     */
    public function createTimerCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionTime)) {
            $body['actionTime'] = $request->actionTime;
        }
        if (!Utils::isUnset($request->bizData)) {
            $body['bizData'] = $request->bizData;
        }
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->identifier)) {
            $body['identifier'] = $request->identifier;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->memo)) {
            $body['memo'] = $request->memo;
        }
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
            'action' => 'CreateTimerCard',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/timerCards',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateTimerCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 套件-创建定时卡片
     *  *
     * @param CreateTimerCardRequest $request CreateTimerCardRequest
     *
     * @return CreateTimerCardResponse CreateTimerCardResponse
     */
    public function createTimerCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTimerCardHeaders([]);

        return $this->createTimerCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建授权token
     *  *
     * @param CreateTokenRequest $request CreateTokenRequest
     * @param CreateTokenHeaders $headers CreateTokenHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTokenResponse CreateTokenResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateToken',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/tokens',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateTokenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建授权token
     *  *
     * @param CreateTokenRequest $request CreateTokenRequest
     *
     * @return CreateTokenResponse CreateTokenResponse
     */
    public function createToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTokenHeaders([]);

        return $this->createTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建调代课记录
     *  *
     * @param CreateTransferRecordRequest $request CreateTransferRecordRequest
     * @param CreateTransferRecordHeaders $headers CreateTransferRecordHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTransferRecordResponse CreateTransferRecordResponse
     */
    public function createTransferRecordWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attributes)) {
            $body['attributes'] = $request->attributes;
        }
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->className)) {
            $body['className'] = $request->className;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->isvRecordId)) {
            $body['isvRecordId'] = $request->isvRecordId;
        }
        if (!Utils::isUnset($request->srcCourseCode)) {
            $body['srcCourseCode'] = $request->srcCourseCode;
        }
        if (!Utils::isUnset($request->srcCourseDate)) {
            $body['srcCourseDate'] = $request->srcCourseDate;
        }
        if (!Utils::isUnset($request->srcCourseName)) {
            $body['srcCourseName'] = $request->srcCourseName;
        }
        if (!Utils::isUnset($request->srcIsvCourseId)) {
            $body['srcIsvCourseId'] = $request->srcIsvCourseId;
        }
        if (!Utils::isUnset($request->srcTimeslotName)) {
            $body['srcTimeslotName'] = $request->srcTimeslotName;
        }
        if (!Utils::isUnset($request->srcTimeslotNum)) {
            $body['srcTimeslotNum'] = $request->srcTimeslotNum;
        }
        if (!Utils::isUnset($request->tarCourseCode)) {
            $body['tarCourseCode'] = $request->tarCourseCode;
        }
        if (!Utils::isUnset($request->tarCourseDate)) {
            $body['tarCourseDate'] = $request->tarCourseDate;
        }
        if (!Utils::isUnset($request->tarCourseName)) {
            $body['tarCourseName'] = $request->tarCourseName;
        }
        if (!Utils::isUnset($request->tarIsvCourseId)) {
            $body['tarIsvCourseId'] = $request->tarIsvCourseId;
        }
        if (!Utils::isUnset($request->tarTimeslotName)) {
            $body['tarTimeslotName'] = $request->tarTimeslotName;
        }
        if (!Utils::isUnset($request->tarTimeslotNum)) {
            $body['tarTimeslotNum'] = $request->tarTimeslotNum;
        }
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
            'action' => 'CreateTransferRecord',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/transferRecords',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateTransferRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建调代课记录
     *  *
     * @param CreateTransferRecordRequest $request CreateTransferRecordRequest
     *
     * @return CreateTransferRecordResponse CreateTransferRecordResponse
     */
    public function createTransferRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTransferRecordHeaders([]);

        return $this->createTransferRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 大学创建课程组
     *  *
     * @param CreateUniversityCourseGroupRequest $request CreateUniversityCourseGroupRequest
     * @param CreateUniversityCourseGroupHeaders $headers CreateUniversityCourseGroupHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateUniversityCourseGroupResponse CreateUniversityCourseGroupResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateUniversityCourseGroup',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/universities/courseGroups',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CreateUniversityCourseGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 大学创建课程组
     *  *
     * @param CreateUniversityCourseGroupRequest $request CreateUniversityCourseGroupRequest
     *
     * @return CreateUniversityCourseGroupResponse CreateUniversityCourseGroupResponse
     */
    public function createUniversityCourseGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateUniversityCourseGroupHeaders([]);

        return $this->createUniversityCourseGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 大学增加学生
     *  *
     * @param CreateUniversityStudentRequest $request CreateUniversityStudentRequest
     * @param CreateUniversityStudentHeaders $headers CreateUniversityStudentHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateUniversityStudentResponse CreateUniversityStudentResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateUniversityStudent',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/universities/students',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateUniversityStudentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 大学增加学生
     *  *
     * @param CreateUniversityStudentRequest $request CreateUniversityStudentRequest
     *
     * @return CreateUniversityStudentResponse CreateUniversityStudentResponse
     */
    public function createUniversityStudent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateUniversityStudentHeaders([]);

        return $this->createUniversityStudentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 大学添加老师
     *  *
     * @param CreateUniversityTeacherRequest $request CreateUniversityTeacherRequest
     * @param CreateUniversityTeacherHeaders $headers CreateUniversityTeacherHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateUniversityTeacherResponse CreateUniversityTeacherResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateUniversityTeacher',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/universities/teachers',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateUniversityTeacherResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 大学添加老师
     *  *
     * @param CreateUniversityTeacherRequest $request CreateUniversityTeacherRequest
     *
     * @return CreateUniversityTeacherResponse CreateUniversityTeacherResponse
     */
    public function createUniversityTeacher($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateUniversityTeacherHeaders([]);

        return $this->createUniversityTeacherWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 错题本-添加错题
     *  *
     * @param CreateWrongQuestionsRequest $request CreateWrongQuestionsRequest
     * @param CreateWrongQuestionsHeaders $headers CreateWrongQuestionsHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateWrongQuestionsResponse CreateWrongQuestionsResponse
     */
    public function createWrongQuestionsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->answerContent)) {
            $body['answerContent'] = $request->answerContent;
        }
        if (!Utils::isUnset($request->difficultyLevel)) {
            $body['difficultyLevel'] = $request->difficultyLevel;
        }
        if (!Utils::isUnset($request->explainAudio)) {
            $body['explainAudio'] = $request->explainAudio;
        }
        if (!Utils::isUnset($request->explainContent)) {
            $body['explainContent'] = $request->explainContent;
        }
        if (!Utils::isUnset($request->generateTime)) {
            $body['generateTime'] = $request->generateTime;
        }
        if (!Utils::isUnset($request->knowledgePointList)) {
            $body['knowledgePointList'] = $request->knowledgePointList;
        }
        if (!Utils::isUnset($request->ownerCode)) {
            $body['ownerCode'] = $request->ownerCode;
        }
        if (!Utils::isUnset($request->ownerType)) {
            $body['ownerType'] = $request->ownerType;
        }
        if (!Utils::isUnset($request->proficiencyLevel)) {
            $body['proficiencyLevel'] = $request->proficiencyLevel;
        }
        if (!Utils::isUnset($request->questionAudio)) {
            $body['questionAudio'] = $request->questionAudio;
        }
        if (!Utils::isUnset($request->questionContent)) {
            $body['questionContent'] = $request->questionContent;
        }
        if (!Utils::isUnset($request->questionExtension)) {
            $body['questionExtension'] = $request->questionExtension;
        }
        if (!Utils::isUnset($request->questionPicUrl)) {
            $body['questionPicUrl'] = $request->questionPicUrl;
        }
        if (!Utils::isUnset($request->questionType)) {
            $body['questionType'] = $request->questionType;
        }
        if (!Utils::isUnset($request->sourceCode)) {
            $body['sourceCode'] = $request->sourceCode;
        }
        if (!Utils::isUnset($request->studentUserId)) {
            $body['studentUserId'] = $request->studentUserId;
        }
        if (!Utils::isUnset($request->subject)) {
            $body['subject'] = $request->subject;
        }
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
            'action' => 'CreateWrongQuestions',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/corp/wrongQuestions',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateWrongQuestionsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 错题本-添加错题
     *  *
     * @param CreateWrongQuestionsRequest $request CreateWrongQuestionsRequest
     *
     * @return CreateWrongQuestionsResponse CreateWrongQuestionsResponse
     */
    public function createWrongQuestions($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateWrongQuestionsHeaders([]);

        return $this->createWrongQuestionsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 视讯paas机具取消激活
     *  *
     * @param DeactivateDeviceRequest $request DeactivateDeviceRequest
     * @param DeactivateDeviceHeaders $headers DeactivateDeviceHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return DeactivateDeviceResponse DeactivateDeviceResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DeactivateDevice',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/vpaas/devices/deactivate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeactivateDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 视讯paas机具取消激活
     *  *
     * @param DeactivateDeviceRequest $request DeactivateDeviceRequest
     *
     * @return DeactivateDeviceResponse DeactivateDeviceResponse
     */
    public function deactivateDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeactivateDeviceHeaders([]);

        return $this->deactivateDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 扣减教育积分
     *  *
     * @param DeductPointRequest $request DeductPointRequest
     * @param DeductPointHeaders $headers DeductPointHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return DeductPointResponse DeductPointResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DeductPoint',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/points/deduct',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeductPointResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 扣减教育积分
     *  *
     * @param DeductPointRequest $request DeductPointRequest
     *
     * @return DeductPointResponse DeductPointResponse
     */
    public function deductPoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeductPointHeaders([]);

        return $this->deductPointWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 高校校友会删除当前部门
     *  *
     * @param DeleteCollegeAlumniDeptRequest $request DeleteCollegeAlumniDeptRequest
     * @param DeleteCollegeAlumniDeptHeaders $headers DeleteCollegeAlumniDeptHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteCollegeAlumniDeptResponse DeleteCollegeAlumniDeptResponse
     */
    public function deleteCollegeAlumniDeptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteCollegeAlumniDept',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeAlumni/depts',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteCollegeAlumniDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 高校校友会删除当前部门
     *  *
     * @param DeleteCollegeAlumniDeptRequest $request DeleteCollegeAlumniDeptRequest
     *
     * @return DeleteCollegeAlumniDeptResponse DeleteCollegeAlumniDeptResponse
     */
    public function deleteCollegeAlumniDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteCollegeAlumniDeptHeaders([]);

        return $this->deleteCollegeAlumniDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 高校校友会删除校友信息
     *  *
     * @param DeleteCollegeAlumniUserInfoRequest $request DeleteCollegeAlumniUserInfoRequest
     * @param DeleteCollegeAlumniUserInfoHeaders $headers DeleteCollegeAlumniUserInfoHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteCollegeAlumniUserInfoResponse DeleteCollegeAlumniUserInfoResponse
     */
    public function deleteCollegeAlumniUserInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
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
            'action' => 'DeleteCollegeAlumniUserInfo',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeAlumni/userInfos/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteCollegeAlumniUserInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 高校校友会删除校友信息
     *  *
     * @param DeleteCollegeAlumniUserInfoRequest $request DeleteCollegeAlumniUserInfoRequest
     *
     * @return DeleteCollegeAlumniUserInfoResponse DeleteCollegeAlumniUserInfoResponse
     */
    public function deleteCollegeAlumniUserInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteCollegeAlumniUserInfoHeaders([]);

        return $this->deleteCollegeAlumniUserInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除高校通讯录场景架构
     *  *
     * @param DeleteCollegeContactSceneStruRequest $request DeleteCollegeContactSceneStruRequest
     * @param DeleteCollegeContactSceneStruHeaders $headers DeleteCollegeContactSceneStruHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteCollegeContactSceneStruResponse DeleteCollegeContactSceneStruResponse
     */
    public function deleteCollegeContactSceneStruWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->struId)) {
            $body['struId'] = $request->struId;
        }
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
            'action' => 'DeleteCollegeContactSceneStru',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/depts/structures/scenes/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteCollegeContactSceneStruResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除高校通讯录场景架构
     *  *
     * @param DeleteCollegeContactSceneStruRequest $request DeleteCollegeContactSceneStruRequest
     *
     * @return DeleteCollegeContactSceneStruResponse DeleteCollegeContactSceneStruResponse
     */
    public function deleteCollegeContactSceneStru($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteCollegeContactSceneStruHeaders([]);

        return $this->deleteCollegeContactSceneStruWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除家校部门
     *  *
     * @param string            $deptId
     * @param DeleteDeptRequest $request DeleteDeptRequest
     * @param DeleteDeptHeaders $headers DeleteDeptHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteDeptResponse DeleteDeptResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteDept',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/depts/' . $deptId . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return DeleteDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除家校部门
     *  *
     * @param string            $deptId
     * @param DeleteDeptRequest $request DeleteDeptRequest
     *
     * @return DeleteDeptResponse DeleteDeptResponse
     */
    public function deleteDept($deptId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDeptHeaders([]);

        return $this->deleteDeptWithOptions($deptId, $request, $headers, $runtime);
    }

    /**
     * @summary 视讯paas机具删除
     *  *
     * @param DeleteDeviceRequest $request DeleteDeviceRequest
     * @param DeleteDeviceHeaders $headers DeleteDeviceHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteDeviceResponse DeleteDeviceResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteDevice',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/vpaas/devices',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 视讯paas机具删除
     *  *
     * @param DeleteDeviceRequest $request DeleteDeviceRequest
     *
     * @return DeleteDeviceResponse DeleteDeviceResponse
     */
    public function deleteDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDeviceHeaders([]);

        return $this->deleteDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除设备上面的组织
     *  *
     * @param DeleteDeviceOrgRequest $request DeleteDeviceOrgRequest
     * @param DeleteDeviceOrgHeaders $headers DeleteDeviceOrgHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteDeviceOrgResponse DeleteDeviceOrgResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteDeviceOrg',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/remoteClasses/deviceOrgs',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return DeleteDeviceOrgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除设备上面的组织
     *  *
     * @param DeleteDeviceOrgRequest $request DeleteDeviceOrgRequest
     *
     * @return DeleteDeviceOrgResponse DeleteDeviceOrgResponse
     */
    public function deleteDeviceOrg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDeviceOrgHeaders([]);

        return $this->deleteDeviceOrgWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除评价表现数据
     *  *
     * @param DeleteEvaluatePerformanceRequest $request DeleteEvaluatePerformanceRequest
     * @param DeleteEvaluatePerformanceHeaders $headers DeleteEvaluatePerformanceHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteEvaluatePerformanceResponse DeleteEvaluatePerformanceResponse
     */
    public function deleteEvaluatePerformanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->evaluationIdList)) {
            $body['evaluationIdList'] = $request->evaluationIdList;
        }
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
            'action' => 'DeleteEvaluatePerformance',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/evaluations/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteEvaluatePerformanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除评价表现数据
     *  *
     * @param DeleteEvaluatePerformanceRequest $request DeleteEvaluatePerformanceRequest
     *
     * @return DeleteEvaluatePerformanceResponse DeleteEvaluatePerformanceResponse
     */
    public function deleteEvaluatePerformance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteEvaluatePerformanceHeaders([]);

        return $this->deleteEvaluatePerformanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除家长
     *  *
     * @param string                $classId
     * @param string                $userId
     * @param DeleteGuardianRequest $request DeleteGuardianRequest
     * @param DeleteGuardianHeaders $headers DeleteGuardianHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteGuardianResponse DeleteGuardianResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteGuardian',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/classes/' . $classId . '/guardians/' . $userId . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return DeleteGuardianResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除家长
     *  *
     * @param string                $classId
     * @param string                $userId
     * @param DeleteGuardianRequest $request DeleteGuardianRequest
     *
     * @return DeleteGuardianResponse DeleteGuardianResponse
     */
    public function deleteGuardian($classId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteGuardianHeaders([]);

        return $this->deleteGuardianWithOptions($classId, $userId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除组织的关联关系
     *  *
     * @param DeleteOrgRelationRequest $request DeleteOrgRelationRequest
     * @param DeleteOrgRelationHeaders $headers DeleteOrgRelationHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteOrgRelationResponse DeleteOrgRelationResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteOrgRelation',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/remoteClasses/orgRelations',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return DeleteOrgRelationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除组织的关联关系
     *  *
     * @param DeleteOrgRelationRequest $request DeleteOrgRelationRequest
     *
     * @return DeleteOrgRelationResponse DeleteOrgRelationResponse
     */
    public function deleteOrgRelation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteOrgRelationHeaders([]);

        return $this->deleteOrgRelationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除物理教室信息
     *  *
     * @param DeletePhysicalClassroomRequest $request DeletePhysicalClassroomRequest
     * @param DeletePhysicalClassroomHeaders $headers DeletePhysicalClassroomHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return DeletePhysicalClassroomResponse DeletePhysicalClassroomResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeletePhysicalClassroom',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/physicalClassrooms',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return DeletePhysicalClassroomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除物理教室信息
     *  *
     * @param DeletePhysicalClassroomRequest $request DeletePhysicalClassroomRequest
     *
     * @return DeletePhysicalClassroomResponse DeletePhysicalClassroomResponse
     */
    public function deletePhysicalClassroom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeletePhysicalClassroomHeaders([]);

        return $this->deletePhysicalClassroomWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除专递课堂课程
     *  *
     * @param string                         $courseCode
     * @param DeleteRemoteClassCourseRequest $request    DeleteRemoteClassCourseRequest
     * @param DeleteRemoteClassCourseHeaders $headers    DeleteRemoteClassCourseHeaders
     * @param RuntimeOptions                 $runtime    runtime options for this request RuntimeOptions
     *
     * @return DeleteRemoteClassCourseResponse DeleteRemoteClassCourseResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteRemoteClassCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/remoteClasses/courses/' . $courseCode . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return DeleteRemoteClassCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除专递课堂课程
     *  *
     * @param string                         $courseCode
     * @param DeleteRemoteClassCourseRequest $request    DeleteRemoteClassCourseRequest
     *
     * @return DeleteRemoteClassCourseResponse DeleteRemoteClassCourseResponse
     */
    public function deleteRemoteClassCourse($courseCode, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRemoteClassCourseHeaders([]);

        return $this->deleteRemoteClassCourseWithOptions($courseCode, $request, $headers, $runtime);
    }

    /**
     * @summary 删除成绩单
     *  *
     * @param DeleteSchoolReportRequest $request DeleteSchoolReportRequest
     * @param DeleteSchoolReportHeaders $headers DeleteSchoolReportHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteSchoolReportResponse DeleteSchoolReportResponse
     */
    public function deleteSchoolReportWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->schoolReportId)) {
            $body['schoolReportId'] = $request->schoolReportId;
        }
        if (!Utils::isUnset($request->teacherId)) {
            $body['teacherId'] = $request->teacherId;
        }
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
            'action' => 'DeleteSchoolReport',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/schools/reports/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteSchoolReportResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除成绩单
     *  *
     * @param DeleteSchoolReportRequest $request DeleteSchoolReportRequest
     *
     * @return DeleteSchoolReportResponse DeleteSchoolReportResponse
     */
    public function deleteSchoolReport($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSchoolReportHeaders([]);

        return $this->deleteSchoolReportWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除学生
     *  *
     * @param string               $classId
     * @param string               $userId
     * @param DeleteStudentRequest $request DeleteStudentRequest
     * @param DeleteStudentHeaders $headers DeleteStudentHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteStudentResponse DeleteStudentResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteStudent',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/classes/' . $classId . '/students/' . $userId . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return DeleteStudentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除学生
     *  *
     * @param string               $classId
     * @param string               $userId
     * @param DeleteStudentRequest $request DeleteStudentRequest
     *
     * @return DeleteStudentResponse DeleteStudentResponse
     */
    public function deleteStudent($classId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteStudentHeaders([]);

        return $this->deleteStudentWithOptions($classId, $userId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除老师
     *  *
     * @param string               $classId
     * @param string               $userId
     * @param DeleteTeacherRequest $request DeleteTeacherRequest
     * @param DeleteTeacherHeaders $headers DeleteTeacherHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteTeacherResponse DeleteTeacherResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteTeacher',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/classes/' . $classId . '/teachers/' . $userId . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return DeleteTeacherResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除老师
     *  *
     * @param string               $classId
     * @param string               $userId
     * @param DeleteTeacherRequest $request DeleteTeacherRequest
     *
     * @return DeleteTeacherResponse DeleteTeacherResponse
     */
    public function deleteTeacher($classId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteTeacherHeaders([]);

        return $this->deleteTeacherWithOptions($classId, $userId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除大学课程组
     *  *
     * @param DeleteUniversityCourseGroupRequest $request DeleteUniversityCourseGroupRequest
     * @param DeleteUniversityCourseGroupHeaders $headers DeleteUniversityCourseGroupHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteUniversityCourseGroupResponse DeleteUniversityCourseGroupResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteUniversityCourseGroup',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/universities/courseGroups',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return DeleteUniversityCourseGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除大学课程组
     *  *
     * @param DeleteUniversityCourseGroupRequest $request DeleteUniversityCourseGroupRequest
     *
     * @return DeleteUniversityCourseGroupResponse DeleteUniversityCourseGroupResponse
     */
    public function deleteUniversityCourseGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteUniversityCourseGroupHeaders([]);

        return $this->deleteUniversityCourseGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除大学学生
     *  *
     * @param DeleteUniversityStudentRequest $request DeleteUniversityStudentRequest
     * @param DeleteUniversityStudentHeaders $headers DeleteUniversityStudentHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteUniversityStudentResponse DeleteUniversityStudentResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteUniversityStudent',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/universities/students',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteUniversityStudentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除大学学生
     *  *
     * @param DeleteUniversityStudentRequest $request DeleteUniversityStudentRequest
     *
     * @return DeleteUniversityStudentResponse DeleteUniversityStudentResponse
     */
    public function deleteUniversityStudent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteUniversityStudentHeaders([]);

        return $this->deleteUniversityStudentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除大学教师
     *  *
     * @param DeleteUniversityTeacherRequest $request DeleteUniversityTeacherRequest
     * @param DeleteUniversityTeacherHeaders $headers DeleteUniversityTeacherHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteUniversityTeacherResponse DeleteUniversityTeacherResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteUniversityTeacher',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/universities/teachers',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteUniversityTeacherResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除大学教师
     *  *
     * @param DeleteUniversityTeacherRequest $request DeleteUniversityTeacherRequest
     *
     * @return DeleteUniversityTeacherResponse DeleteUniversityTeacherResponse
     */
    public function deleteUniversityTeacher($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteUniversityTeacherHeaders([]);

        return $this->deleteUniversityTeacherWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设备心跳上报
     *  *
     * @param DeviceHeartbeatRequest $request DeviceHeartbeatRequest
     * @param DeviceHeartbeatHeaders $headers DeviceHeartbeatHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return DeviceHeartbeatResponse DeviceHeartbeatResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeviceHeartbeat',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/heartbeats/report',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeviceHeartbeatResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设备心跳上报
     *  *
     * @param DeviceHeartbeatRequest $request DeviceHeartbeatRequest
     *
     * @return DeviceHeartbeatResponse DeviceHeartbeatResponse
     */
    public function deviceHeartbeat($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeviceHeartbeatHeaders([]);

        return $this->deviceHeartbeatWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 停用高校通讯录场景架构
     *  *
     * @param DisableCollegeContactSceneStruRequest $request DisableCollegeContactSceneStruRequest
     * @param DisableCollegeContactSceneStruHeaders $headers DisableCollegeContactSceneStruHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return DisableCollegeContactSceneStruResponse DisableCollegeContactSceneStruResponse
     */
    public function disableCollegeContactSceneStruWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->struId)) {
            $body['struId'] = $request->struId;
        }
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
            'action' => 'DisableCollegeContactSceneStru',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/depts/structures/scenes/disable',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DisableCollegeContactSceneStruResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 停用高校通讯录场景架构
     *  *
     * @param DisableCollegeContactSceneStruRequest $request DisableCollegeContactSceneStruRequest
     *
     * @return DisableCollegeContactSceneStruResponse DisableCollegeContactSceneStruResponse
     */
    public function disableCollegeContactSceneStru($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DisableCollegeContactSceneStruHeaders([]);

        return $this->disableCollegeContactSceneStruWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 教育三方aigc结果回调
     *  *
     * @param EduAIGCCallbackRequest $request EduAIGCCallbackRequest
     * @param EduAIGCCallbackHeaders $headers EduAIGCCallbackHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return EduAIGCCallbackResponse EduAIGCCallbackResponse
     */
    public function eduAIGCCallbackWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->channelCode)) {
            $body['channelCode'] = $request->channelCode;
        }
        if (!Utils::isUnset($request->commitTime)) {
            $body['commitTime'] = $request->commitTime;
        }
        if (!Utils::isUnset($request->completeTime)) {
            $body['completeTime'] = $request->completeTime;
        }
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->contentSize)) {
            $body['contentSize'] = $request->contentSize;
        }
        if (!Utils::isUnset($request->contentType)) {
            $body['contentType'] = $request->contentType;
        }
        if (!Utils::isUnset($request->ext)) {
            $body['ext'] = $request->ext;
        }
        if (!Utils::isUnset($request->prompt)) {
            $body['prompt'] = $request->prompt;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
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
            'action' => 'EduAIGCCallback',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/aigc/callback',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return EduAIGCCallbackResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 教育三方aigc结果回调
     *  *
     * @param EduAIGCCallbackRequest $request EduAIGCCallbackRequest
     *
     * @return EduAIGCCallbackResponse EduAIGCCallbackResponse
     */
    public function eduAIGCCallback($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EduAIGCCallbackHeaders([]);

        return $this->eduAIGCCallbackWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 教育大模型开放接口
     *  *
     * @param EduAIModelCompleteRequest $request EduAIModelCompleteRequest
     * @param EduAIModelCompleteHeaders $headers EduAIModelCompleteHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return EduAIModelCompleteResponse EduAIModelCompleteResponse
     */
    public function eduAIModelCompleteWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->maxTokens)) {
            $body['maxTokens'] = $request->maxTokens;
        }
        if (!Utils::isUnset($request->model)) {
            $body['model'] = $request->model;
        }
        if (!Utils::isUnset($request->prompt)) {
            $body['prompt'] = $request->prompt;
        }
        if (!Utils::isUnset($request->scene)) {
            $body['scene'] = $request->scene;
        }
        if (!Utils::isUnset($request->temperature)) {
            $body['temperature'] = $request->temperature;
        }
        if (!Utils::isUnset($request->topP)) {
            $body['top_p'] = $request->topP;
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
            'action' => 'EduAIModelComplete',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/ai/models/complete',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return EduAIModelCompleteResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 教育大模型开放接口
     *  *
     * @param EduAIModelCompleteRequest $request EduAIModelCompleteRequest
     *
     * @return EduAIModelCompleteResponse EduAIModelCompleteResponse
     */
    public function eduAIModelComplete($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EduAIModelCompleteHeaders([]);

        return $this->eduAIModelCompleteWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 教育侧用户的所有角色
     *  *
     * @param EduFindUserRolesByUserIdRequest $request EduFindUserRolesByUserIdRequest
     * @param EduFindUserRolesByUserIdHeaders $headers EduFindUserRolesByUserIdHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return EduFindUserRolesByUserIdResponse EduFindUserRolesByUserIdResponse
     */
    public function eduFindUserRolesByUserIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->classId)) {
            $query['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->hasOrgRole)) {
            $query['hasOrgRole'] = $request->hasOrgRole;
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
            'action' => 'EduFindUserRolesByUserId',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/users/allRoles',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return EduFindUserRolesByUserIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 教育侧用户的所有角色
     *  *
     * @param EduFindUserRolesByUserIdRequest $request EduFindUserRolesByUserIdRequest
     *
     * @return EduFindUserRolesByUserIdResponse EduFindUserRolesByUserIdResponse
     */
    public function eduFindUserRolesByUserId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EduFindUserRolesByUserIdHeaders([]);

        return $this->eduFindUserRolesByUserIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取用户文件存储空间信息
     *  *
     * @param EduGetFileSpaceRequest $request EduGetFileSpaceRequest
     * @param EduGetFileSpaceHeaders $headers EduGetFileSpaceHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return EduGetFileSpaceResponse EduGetFileSpaceResponse
     */
    public function eduGetFileSpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->channelCode)) {
            $body['channelCode'] = $request->channelCode;
        }
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
            'action' => 'EduGetFileSpace',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/files/spaces/infos/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return EduGetFileSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户文件存储空间信息
     *  *
     * @param EduGetFileSpaceRequest $request EduGetFileSpaceRequest
     *
     * @return EduGetFileSpaceResponse EduGetFileSpaceResponse
     */
    public function eduGetFileSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EduGetFileSpaceHeaders([]);

        return $this->eduGetFileSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 教育侧获取用户所有关系详情列表
     *  *
     * @param EduListUserByFromUserIdsRequest $request EduListUserByFromUserIdsRequest
     * @param EduListUserByFromUserIdsHeaders $headers EduListUserByFromUserIdsHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return EduListUserByFromUserIdsResponse EduListUserByFromUserIdsResponse
     */
    public function eduListUserByFromUserIdsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->classId)) {
            $query['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->guardianUserId)) {
            $query['guardianUserId'] = $request->guardianUserId;
        }
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
            'action' => 'EduListUserByFromUserIds',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/users/allRelations/lists',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return EduListUserByFromUserIdsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 教育侧获取用户所有关系详情列表
     *  *
     * @param EduListUserByFromUserIdsRequest $request EduListUserByFromUserIdsRequest
     *
     * @return EduListUserByFromUserIdsResponse EduListUserByFromUserIdsResponse
     */
    public function eduListUserByFromUserIds($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EduListUserByFromUserIdsHeaders([]);

        return $this->eduListUserByFromUserIdsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询教师列表
     *  *
     * @param EduTeacherListRequest $request EduTeacherListRequest
     * @param EduTeacherListHeaders $headers EduTeacherListHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return EduTeacherListResponse EduTeacherListResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'EduTeacherList',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/teachers',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return EduTeacherListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询教师列表
     *  *
     * @param EduTeacherListRequest $request EduTeacherListRequest
     *
     * @return EduTeacherListResponse EduTeacherListResponse
     */
    public function eduTeacherList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EduTeacherListHeaders([]);

        return $this->eduTeacherListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 启用高校通讯录场景架构
     *  *
     * @param EnableCollegeContactSceneStruRequest $request EnableCollegeContactSceneStruRequest
     * @param EnableCollegeContactSceneStruHeaders $headers EnableCollegeContactSceneStruHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return EnableCollegeContactSceneStruResponse EnableCollegeContactSceneStruResponse
     */
    public function enableCollegeContactSceneStruWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->struId)) {
            $body['struId'] = $request->struId;
        }
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
            'action' => 'EnableCollegeContactSceneStru',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/depts/structures/scenes/enable',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return EnableCollegeContactSceneStruResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 启用高校通讯录场景架构
     *  *
     * @param EnableCollegeContactSceneStruRequest $request EnableCollegeContactSceneStruRequest
     *
     * @return EnableCollegeContactSceneStruResponse EnableCollegeContactSceneStruResponse
     */
    public function enableCollegeContactSceneStru($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EnableCollegeContactSceneStruHeaders([]);

        return $this->enableCollegeContactSceneStruWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 关闭课程
     *  *
     * @param EndCourseRequest $request EndCourseRequest
     * @param EndCourseHeaders $headers EndCourseHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return EndCourseResponse EndCourseResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'EndCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/universities/courses/end',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return EndCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 关闭课程
     *  *
     * @param EndCourseRequest $request EndCourseRequest
     *
     * @return EndCourseResponse EndCourseResponse
     */
    public function endCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EndCourseHeaders([]);

        return $this->endCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新增用户事件跟踪日志
     *  *
     * @param EventTrackRequest $request EventTrackRequest
     * @param EventTrackHeaders $headers EventTrackHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return EventTrackResponse EventTrackResponse
     */
    public function eventTrackWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionKey)) {
            $body['actionKey'] = $request->actionKey;
        }
        if (!Utils::isUnset($request->actionTime)) {
            $body['actionTime'] = $request->actionTime;
        }
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->bizReq)) {
            $body['bizReq'] = $request->bizReq;
        }
        if (!Utils::isUnset($request->bizResp)) {
            $body['bizResp'] = $request->bizResp;
        }
        if (!Utils::isUnset($request->deviceId)) {
            $body['deviceId'] = $request->deviceId;
        }
        if (!Utils::isUnset($request->eventId)) {
            $body['eventId'] = $request->eventId;
        }
        if (!Utils::isUnset($request->eventType)) {
            $body['eventType'] = $request->eventType;
        }
        if (!Utils::isUnset($request->eventUnit)) {
            $body['eventUnit'] = $request->eventUnit;
        }
        if (!Utils::isUnset($request->eventValue)) {
            $body['eventValue'] = $request->eventValue;
        }
        if (!Utils::isUnset($request->extend)) {
            $body['extend'] = $request->extend;
        }
        if (!Utils::isUnset($request->platform)) {
            $body['platform'] = $request->platform;
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
            'action' => 'EventTrack',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/users/events/traceLogs',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return EventTrackResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增用户事件跟踪日志
     *  *
     * @param EventTrackRequest $request EventTrackRequest
     *
     * @return EventTrackResponse EventTrackResponse
     */
    public function eventTrack($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EventTrackHeaders([]);

        return $this->eventTrackWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取调用大模型的taskId
     *  *
     * @param GenerateTaskIdRequest $request GenerateTaskIdRequest
     * @param GenerateTaskIdHeaders $headers GenerateTaskIdHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return GenerateTaskIdResponse GenerateTaskIdResponse
     */
    public function generateTaskIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->maxTokens)) {
            $body['maxTokens'] = $request->maxTokens;
        }
        if (!Utils::isUnset($request->model)) {
            $body['model'] = $request->model;
        }
        if (!Utils::isUnset($request->prompt)) {
            $body['prompt'] = $request->prompt;
        }
        if (!Utils::isUnset($request->scene)) {
            $body['scene'] = $request->scene;
        }
        if (!Utils::isUnset($request->temperature)) {
            $body['temperature'] = $request->temperature;
        }
        if (!Utils::isUnset($request->topP)) {
            $body['top_p'] = $request->topP;
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
            'action' => 'GenerateTaskId',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/ai/models/taskId/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GenerateTaskIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取调用大模型的taskId
     *  *
     * @param GenerateTaskIdRequest $request GenerateTaskIdRequest
     *
     * @return GenerateTaskIdResponse GenerateTaskIdResponse
     */
    public function generateTaskId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GenerateTaskIdHeaders([]);

        return $this->generateTaskIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取绑定孩子信息
     *  *
     * @param GetBindChildInfoRequest $request GetBindChildInfoRequest
     * @param GetBindChildInfoHeaders $headers GetBindChildInfoHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetBindChildInfoResponse GetBindChildInfoResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetBindChildInfo',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/families/childs/infos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetBindChildInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取绑定孩子信息
     *  *
     * @param GetBindChildInfoRequest $request GetBindChildInfoRequest
     *
     * @return GetBindChildInfoResponse GetBindChildInfoResponse
     */
    public function getBindChildInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetBindChildInfoHeaders([]);

        return $this->getBindChildInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户的孩子列表
     *  *
     * @param GetChildrenHeaders $headers GetChildrenHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetChildrenResponse GetChildrenResponse
     */
    public function getChildrenWithOptions($headers, $runtime)
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
            'action' => 'GetChildren',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/children/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetChildrenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户的孩子列表
     *  *
     * @return GetChildrenResponse GetChildrenResponse
     */
    public function getChildren()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetChildrenHeaders([]);

        return $this->getChildrenWithOptions($headers, $runtime);
    }

    /**
     * @summary 高校校友会获取当前部门的所有子部门
     *  *
     * @param GetCollegeAlumniDeptsRequest $request GetCollegeAlumniDeptsRequest
     * @param GetCollegeAlumniDeptsHeaders $headers GetCollegeAlumniDeptsHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCollegeAlumniDeptsResponse GetCollegeAlumniDeptsResponse
     */
    public function getCollegeAlumniDeptsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetCollegeAlumniDepts',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeAlumni/subDepts',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetCollegeAlumniDeptsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 高校校友会获取当前部门的所有子部门
     *  *
     * @param GetCollegeAlumniDeptsRequest $request GetCollegeAlumniDeptsRequest
     *
     * @return GetCollegeAlumniDeptsResponse GetCollegeAlumniDeptsResponse
     */
    public function getCollegeAlumniDepts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCollegeAlumniDeptsHeaders([]);

        return $this->getCollegeAlumniDeptsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 高校校友会查询校友信息
     *  *
     * @param GetCollegeAlumniUserInfoRequest $request GetCollegeAlumniUserInfoRequest
     * @param GetCollegeAlumniUserInfoHeaders $headers GetCollegeAlumniUserInfoHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCollegeAlumniUserInfoResponse GetCollegeAlumniUserInfoResponse
     */
    public function getCollegeAlumniUserInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operator)) {
            $query['operator'] = $request->operator;
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
            'action' => 'GetCollegeAlumniUserInfo',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeAlumni/userInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetCollegeAlumniUserInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 高校校友会查询校友信息
     *  *
     * @param GetCollegeAlumniUserInfoRequest $request GetCollegeAlumniUserInfoRequest
     *
     * @return GetCollegeAlumniUserInfoResponse GetCollegeAlumniUserInfoResponse
     */
    public function getCollegeAlumniUserInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCollegeAlumniUserInfoHeaders([]);

        return $this->getCollegeAlumniUserInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取高校通讯录组织单元详情
     *  *
     * @param GetCollegeContactDeptDetailRequest $request GetCollegeContactDeptDetailRequest
     * @param GetCollegeContactDeptDetailHeaders $headers GetCollegeContactDeptDetailHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCollegeContactDeptDetailResponse GetCollegeContactDeptDetailResponse
     */
    public function getCollegeContactDeptDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
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
            'action' => 'GetCollegeContactDeptDetail',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/depts',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetCollegeContactDeptDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取高校通讯录组织单元详情
     *  *
     * @param GetCollegeContactDeptDetailRequest $request GetCollegeContactDeptDetailRequest
     *
     * @return GetCollegeContactDeptDetailResponse GetCollegeContactDeptDetailResponse
     */
    public function getCollegeContactDeptDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCollegeContactDeptDetailHeaders([]);

        return $this->getCollegeContactDeptDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取行政组织架构信息
     *  *
     * @param GetCollegeContactStandardStruDeptDetailRequest $request GetCollegeContactStandardStruDeptDetailRequest
     * @param GetCollegeContactStandardStruDeptDetailHeaders $headers GetCollegeContactStandardStruDeptDetailHeaders
     * @param RuntimeOptions                                 $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCollegeContactStandardStruDeptDetailResponse GetCollegeContactStandardStruDeptDetailResponse
     */
    public function getCollegeContactStandardStruDeptDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
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
            'action' => 'GetCollegeContactStandardStruDeptDetail',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/depts/structures/standards',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetCollegeContactStandardStruDeptDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取行政组织架构信息
     *  *
     * @param GetCollegeContactStandardStruDeptDetailRequest $request GetCollegeContactStandardStruDeptDetailRequest
     *
     * @return GetCollegeContactStandardStruDeptDetailResponse GetCollegeContactStandardStruDeptDetailResponse
     */
    public function getCollegeContactStandardStruDeptDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCollegeContactStandardStruDeptDetailHeaders([]);

        return $this->getCollegeContactStandardStruDeptDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取默认孩子信息
     *  *
     * @param GetDefaultChildHeaders $headers GetDefaultChildHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDefaultChildResponse GetDefaultChildResponse
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
            'action' => 'GetDefaultChild',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/defaultChildren',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetDefaultChildResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取默认孩子信息
     *  *
     * @return GetDefaultChildResponse GetDefaultChildResponse
     */
    public function getDefaultChild()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDefaultChildHeaders([]);

        return $this->getDefaultChildWithOptions($headers, $runtime);
    }

    /**
     * @summary 阿里云盘教师节活动获取用户身份
     *  *
     * @param GetEduUserIdentityRequest $request GetEduUserIdentityRequest
     * @param GetEduUserIdentityHeaders $headers GetEduUserIdentityHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetEduUserIdentityResponse GetEduUserIdentityResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetEduUserIdentity',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/apollos/activities/userIdentities',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetEduUserIdentityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 阿里云盘教师节活动获取用户身份
     *  *
     * @param GetEduUserIdentityRequest $request GetEduUserIdentityRequest
     *
     * @return GetEduUserIdentityResponse GetEduUserIdentityResponse
     */
    public function getEduUserIdentity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetEduUserIdentityHeaders([]);

        return $this->getEduUserIdentityWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取文件下载信息
     *  *
     * @param GetFileDownloadInfoRequest $request GetFileDownloadInfoRequest
     * @param GetFileDownloadInfoHeaders $headers GetFileDownloadInfoHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFileDownloadInfoResponse GetFileDownloadInfoResponse
     */
    public function getFileDownloadInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fileIdList)) {
            $body['fileIdList'] = $request->fileIdList;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetFileDownloadInfo',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/files/downloadInfos/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetFileDownloadInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取文件下载信息
     *  *
     * @param GetFileDownloadInfoRequest $request GetFileDownloadInfoRequest
     *
     * @return GetFileDownloadInfoResponse GetFileDownloadInfoResponse
     */
    public function getFileDownloadInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFileDownloadInfoHeaders([]);

        return $this->getFileDownloadInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询文件和图片ID信息
     *  *
     * @param GetFileDownloadInfoByPackageIdRequest $request GetFileDownloadInfoByPackageIdRequest
     * @param GetFileDownloadInfoByPackageIdHeaders $headers GetFileDownloadInfoByPackageIdHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFileDownloadInfoByPackageIdResponse GetFileDownloadInfoByPackageIdResponse
     */
    public function getFileDownloadInfoByPackageIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->packageId)) {
            $body['packageId'] = $request->packageId;
        }
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
            'action' => 'GetFileDownloadInfoByPackageId',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/fileAndImages/ids/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetFileDownloadInfoByPackageIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询文件和图片ID信息
     *  *
     * @param GetFileDownloadInfoByPackageIdRequest $request GetFileDownloadInfoByPackageIdRequest
     *
     * @return GetFileDownloadInfoByPackageIdResponse GetFileDownloadInfoByPackageIdResponse
     */
    public function getFileDownloadInfoByPackageId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFileDownloadInfoByPackageIdHeaders([]);

        return $this->getFileDownloadInfoByPackageIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取图片下载信息
     *  *
     * @param GetImageTempDownloadUrlRequest $request GetImageTempDownloadUrlRequest
     * @param GetImageTempDownloadUrlHeaders $headers GetImageTempDownloadUrlHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return GetImageTempDownloadUrlResponse GetImageTempDownloadUrlResponse
     */
    public function getImageTempDownloadUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->mediaId)) {
            $body['mediaId'] = $request->mediaId;
        }
        if (!Utils::isUnset($request->sourceType)) {
            $body['sourceType'] = $request->sourceType;
        }
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
            'action' => 'GetImageTempDownloadUrl',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/images/tempDownloadUrls/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetImageTempDownloadUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取图片下载信息
     *  *
     * @param GetImageTempDownloadUrlRequest $request GetImageTempDownloadUrlRequest
     *
     * @return GetImageTempDownloadUrlResponse GetImageTempDownloadUrlResponse
     */
    public function getImageTempDownloadUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetImageTempDownloadUrlHeaders([]);

        return $this->getImageTempDownloadUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取公开课的课程详情
     *  *
     * @param string                     $courseId
     * @param GetOpenCourseDetailHeaders $headers  GetOpenCourseDetailHeaders
     * @param RuntimeOptions             $runtime  runtime options for this request RuntimeOptions
     *
     * @return GetOpenCourseDetailResponse GetOpenCourseDetailResponse
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
            'action' => 'GetOpenCourseDetail',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/openCourse/' . $courseId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetOpenCourseDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取公开课的课程详情
     *  *
     * @param string $courseId
     *
     * @return GetOpenCourseDetailResponse GetOpenCourseDetailResponse
     */
    public function getOpenCourseDetail($courseId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOpenCourseDetailHeaders([]);

        return $this->getOpenCourseDetailWithOptions($courseId, $headers, $runtime);
    }

    /**
     * @summary 获取通过审核的课程列表
     *  *
     * @param GetOpenCoursesRequest $request GetOpenCoursesRequest
     * @param GetOpenCoursesHeaders $headers GetOpenCoursesHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOpenCoursesResponse GetOpenCoursesResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetOpenCourses',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/openCourses',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetOpenCoursesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取通过审核的课程列表
     *  *
     * @param GetOpenCoursesRequest $request GetOpenCoursesRequest
     *
     * @return GetOpenCoursesResponse GetOpenCoursesResponse
     */
    public function getOpenCourses($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOpenCoursesHeaders([]);

        return $this->getOpenCoursesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询教育积分流水记录
     *  *
     * @param GetPointActionRecordRequest $tmpReq  GetPointActionRecordRequest
     * @param GetPointActionRecordHeaders $headers GetPointActionRecordHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPointActionRecordResponse GetPointActionRecordResponse
     */
    public function getPointActionRecordWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new GetPointActionRecordShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->body)) {
            $request->bodyShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->body, 'body', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->bodyShrink)) {
            $query['body'] = $request->bodyShrink;
        }
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
            'action' => 'GetPointActionRecord',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/points/actionRecords',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetPointActionRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询教育积分流水记录
     *  *
     * @param GetPointActionRecordRequest $request GetPointActionRecordRequest
     *
     * @return GetPointActionRecordResponse GetPointActionRecordResponse
     */
    public function getPointActionRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPointActionRecordHeaders([]);

        return $this->getPointActionRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询教育积分信息
     *  *
     * @param GetPointInfoRequest $request GetPointInfoRequest
     * @param GetPointInfoHeaders $headers GetPointInfoHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPointInfoResponse GetPointInfoResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetPointInfo',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/points/infos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetPointInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询教育积分信息
     *  *
     * @param GetPointInfoRequest $request GetPointInfoRequest
     *
     * @return GetPointInfoResponse GetPointInfoResponse
     */
    public function getPointInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPointInfoHeaders([]);

        return $this->getPointInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询专递课堂课程详情
     *  *
     * @param string                      $courseCode
     * @param GetRemoteClassCourseRequest $request    GetRemoteClassCourseRequest
     * @param GetRemoteClassCourseHeaders $headers    GetRemoteClassCourseHeaders
     * @param RuntimeOptions              $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetRemoteClassCourseResponse GetRemoteClassCourseResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetRemoteClassCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/remoteClasses/courses/' . $courseCode . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return GetRemoteClassCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询专递课堂课程详情
     *  *
     * @param string                      $courseCode
     * @param GetRemoteClassCourseRequest $request    GetRemoteClassCourseRequest
     *
     * @return GetRemoteClassCourseResponse GetRemoteClassCourseResponse
     */
    public function getRemoteClassCourse($courseCode, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRemoteClassCourseHeaders([]);

        return $this->getRemoteClassCourseWithOptions($courseCode, $request, $headers, $runtime);
    }

    /**
     * @summary 获取共享角色成员
     *  *
     * @param string                     $shareRoleCode
     * @param GetShareRoleMembersHeaders $headers       GetShareRoleMembersHeaders
     * @param RuntimeOptions             $runtime       runtime options for this request RuntimeOptions
     *
     * @return GetShareRoleMembersResponse GetShareRoleMembersResponse
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
            'action' => 'GetShareRoleMembers',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/shareRoles/' . $shareRoleCode . '/members',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetShareRoleMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取共享角色成员
     *  *
     * @param string $shareRoleCode
     *
     * @return GetShareRoleMembersResponse GetShareRoleMembersResponse
     */
    public function getShareRoleMembers($shareRoleCode)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetShareRoleMembersHeaders([]);

        return $this->getShareRoleMembersWithOptions($shareRoleCode, $headers, $runtime);
    }

    /**
     * @summary 获取教育局的共享角色列表
     *  *
     * @param GetShareRolesHeaders $headers GetShareRolesHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetShareRolesResponse GetShareRolesResponse
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
            'action' => 'GetShareRoles',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/shareRoles',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetShareRolesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取教育局的共享角色列表
     *  *
     * @return GetShareRolesResponse GetShareRolesResponse
     */
    public function getShareRoles()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetShareRolesHeaders([]);

        return $this->getShareRolesWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询入学任务列表
     *  *
     * @param GetTaskListRequest $request GetTaskListRequest
     * @param GetTaskListHeaders $headers GetTaskListHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTaskListResponse GetTaskListResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetTaskList',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/newGrades/tasks/lists',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetTaskListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询入学任务列表
     *  *
     * @param GetTaskListRequest $request GetTaskListRequest
     *
     * @return GetTaskListResponse GetTaskListResponse
     */
    public function getTaskList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTaskListHeaders([]);

        return $this->getTaskListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取入学任务下的学生列表
     *  *
     * @param GetTaskStudentListRequest $request GetTaskStudentListRequest
     * @param GetTaskStudentListHeaders $headers GetTaskStudentListHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTaskStudentListResponse GetTaskStudentListResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetTaskStudentList',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/newGrades/tasks/students/lists',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetTaskStudentListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取入学任务下的学生列表
     *  *
     * @param GetTaskStudentListRequest $request GetTaskStudentListRequest
     *
     * @return GetTaskStudentListResponse GetTaskStudentListResponse
     */
    public function getTaskStudentList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTaskStudentListHeaders([]);

        return $this->getTaskStudentListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 初始化班级课程表
     *  *
     * @param string                    $classId
     * @param InitCoursesOfClassRequest $request InitCoursesOfClassRequest
     * @param InitCoursesOfClassHeaders $headers InitCoursesOfClassHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return InitCoursesOfClassResponse InitCoursesOfClassResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'InitCoursesOfClass',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/classes/' . $classId . '/courses/init',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return InitCoursesOfClassResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 初始化班级课程表
     *  *
     * @param string                    $classId
     * @param InitCoursesOfClassRequest $request InitCoursesOfClassRequest
     *
     * @return InitCoursesOfClassResponse InitCoursesOfClassResponse
     */
    public function initCoursesOfClass($classId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InitCoursesOfClassHeaders([]);

        return $this->initCoursesOfClassWithOptions($classId, $request, $headers, $runtime);
    }

    /**
     * @summary 设备启动注册
     *  *
     * @param InitDeviceRequest $request InitDeviceRequest
     * @param InitDeviceHeaders $headers InitDeviceHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return InitDeviceResponse InitDeviceResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'InitDevice',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/devices/init',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return InitDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设备启动注册
     *  *
     * @param InitDeviceRequest $request InitDeviceRequest
     *
     * @return InitDeviceResponse InitDeviceResponse
     */
    public function initDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InitDeviceHeaders([]);

        return $this->initDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 视讯paas机具初始化
     *  *
     * @param InitVPaasDeviceRequest $request InitVPaasDeviceRequest
     * @param InitVPaasDeviceHeaders $headers InitVPaasDeviceHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return InitVPaasDeviceResponse InitVPaasDeviceResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'InitVPaasDevice',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/vpaas/devices/init',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return InitVPaasDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 视讯paas机具初始化
     *  *
     * @param InitVPaasDeviceRequest $request InitVPaasDeviceRequest
     *
     * @return InitVPaasDeviceResponse InitVPaasDeviceResponse
     */
    public function initVPaasDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InitVPaasDeviceHeaders([]);

        return $this->initVPaasDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 插入学校维度节次设置
     *  *
     * @param InsertSectionConfigRequest $request InsertSectionConfigRequest
     * @param InsertSectionConfigHeaders $headers InsertSectionConfigHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return InsertSectionConfigResponse InsertSectionConfigResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'InsertSectionConfig',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/schedules/configs',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return InsertSectionConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 插入学校维度节次设置
     *  *
     * @param InsertSectionConfigRequest $request InsertSectionConfigRequest
     *
     * @return InsertSectionConfigResponse InsertSectionConfigResponse
     */
    public function insertSectionConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertSectionConfigHeaders([]);

        return $this->insertSectionConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 失效课程
     *  *
     * @param InvalidCourseRequest $request InvalidCourseRequest
     * @param InvalidCourseHeaders $headers InvalidCourseHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return InvalidCourseResponse InvalidCourseResponse
     */
    public function invalidCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->isvCourseId)) {
            $body['isvCourseId'] = $request->isvCourseId;
        }
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
            'action' => 'InvalidCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/courses/invalid',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return InvalidCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 失效课程
     *  *
     * @param InvalidCourseRequest $request InvalidCourseRequest
     *
     * @return InvalidCourseResponse InvalidCourseResponse
     */
    public function invalidCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InvalidCourseHeaders([]);

        return $this->invalidCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 失效教育套件
     *  *
     * @param InvalidKitRequest $request InvalidKitRequest
     * @param InvalidKitHeaders $headers InvalidKitHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return InvalidKitResponse InvalidKitResponse
     */
    public function invalidKitWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->isvProductScene)) {
            $body['isvProductScene'] = $request->isvProductScene;
        }
        if (!Utils::isUnset($request->openUserId)) {
            $body['openUserId'] = $request->openUserId;
        }
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
            'action' => 'InvalidKit',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/records/invalid',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return InvalidKitResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 失效教育套件
     *  *
     * @param InvalidKitRequest $request InvalidKitRequest
     *
     * @return InvalidKitResponse InvalidKitResponse
     */
    public function invalidKit($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InvalidKitHeaders([]);

        return $this->invalidKitWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除学生班级
     *  *
     * @param InvalidStudentClassRequest $request InvalidStudentClassRequest
     * @param InvalidStudentClassHeaders $headers InvalidStudentClassHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return InvalidStudentClassResponse InvalidStudentClassResponse
     */
    public function invalidStudentClassWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->classType)) {
            $body['classType'] = $request->classType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'InvalidStudentClass',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/students/classes/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return InvalidStudentClassResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除学生班级
     *  *
     * @param InvalidStudentClassRequest $request InvalidStudentClassRequest
     *
     * @return InvalidStudentClassResponse InvalidStudentClassResponse
     */
    public function invalidStudentClass($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InvalidStudentClassHeaders([]);

        return $this->invalidStudentClassWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除老师课程
     *  *
     * @param InvalidTeacherCourseRequest $request InvalidTeacherCourseRequest
     * @param InvalidTeacherCourseHeaders $headers InvalidTeacherCourseHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return InvalidTeacherCourseResponse InvalidTeacherCourseResponse
     */
    public function invalidTeacherCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->needDeleteCourseIdList)) {
            $body['needDeleteCourseIdList'] = $request->needDeleteCourseIdList;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'InvalidTeacherCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/teachers/courses/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return InvalidTeacherCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除老师课程
     *  *
     * @param InvalidTeacherCourseRequest $request InvalidTeacherCourseRequest
     *
     * @return InvalidTeacherCourseResponse InvalidTeacherCourseResponse
     */
    public function invalidTeacherCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InvalidTeacherCourseHeaders([]);

        return $this->invalidTeacherCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查看用户是否是认证校的语文老师
     *  *
     * @param IsYuwenCertifiedTeacherRequest $request IsYuwenCertifiedTeacherRequest
     * @param IsYuwenCertifiedTeacherHeaders $headers IsYuwenCertifiedTeacherHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return IsYuwenCertifiedTeacherResponse IsYuwenCertifiedTeacherResponse
     */
    public function isYuwenCertifiedTeacherWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
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
            'action' => 'IsYuwenCertifiedTeacher',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/paas/certifiedTeachers/chineseTeachers/check',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return IsYuwenCertifiedTeacherResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查看用户是否是认证校的语文老师
     *  *
     * @param IsYuwenCertifiedTeacherRequest $request IsYuwenCertifiedTeacherRequest
     *
     * @return IsYuwenCertifiedTeacherResponse IsYuwenCertifiedTeacherResponse
     */
    public function isYuwenCertifiedTeacher($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IsYuwenCertifiedTeacherHeaders([]);

        return $this->isYuwenCertifiedTeacherWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 第三方数据写入
     *  *
     * @param IsvDataWriteRequest $request IsvDataWriteRequest
     * @param IsvDataWriteHeaders $headers IsvDataWriteHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return IsvDataWriteResponse IsvDataWriteResponse
     */
    public function isvDataWriteWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->objectCode)) {
            $body['objectCode'] = $request->objectCode;
        }
        if (!Utils::isUnset($request->rowValueList)) {
            $body['rowValueList'] = $request->rowValueList;
        }
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
            'action' => 'IsvDataWrite',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/datas/write',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return IsvDataWriteResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 第三方数据写入
     *  *
     * @param IsvDataWriteRequest $request IsvDataWriteRequest
     *
     * @return IsvDataWriteResponse IsvDataWriteResponse
     */
    public function isvDataWrite($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IsvDataWriteHeaders([]);

        return $this->isvDataWriteWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary Isv查询元数据信息
     *  *
     * @param IsvMetadataQueryRequest $request IsvMetadataQueryRequest
     * @param IsvMetadataQueryHeaders $headers IsvMetadataQueryHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return IsvMetadataQueryResponse IsvMetadataQueryResponse
     */
    public function isvMetadataQueryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->objectCode)) {
            $query['objectCode'] = $request->objectCode;
        }
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
            'action' => 'IsvMetadataQuery',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/datas/metadatas',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return IsvMetadataQueryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary Isv查询元数据信息
     *  *
     * @param IsvMetadataQueryRequest $request IsvMetadataQueryRequest
     *
     * @return IsvMetadataQueryResponse IsvMetadataQueryResponse
     */
    public function isvMetadataQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new IsvMetadataQueryHeaders([]);

        return $this->isvMetadataQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取高校组织单元类型
     *  *
     * @param ListCollegeContactDeptTypeConfigRequest $request ListCollegeContactDeptTypeConfigRequest
     * @param ListCollegeContactDeptTypeConfigHeaders $headers ListCollegeContactDeptTypeConfigHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return ListCollegeContactDeptTypeConfigResponse ListCollegeContactDeptTypeConfigResponse
     */
    public function listCollegeContactDeptTypeConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
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
            'action' => 'ListCollegeContactDeptTypeConfig',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/configs/deptTypes',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListCollegeContactDeptTypeConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取高校组织单元类型
     *  *
     * @param ListCollegeContactDeptTypeConfigRequest $request ListCollegeContactDeptTypeConfigRequest
     *
     * @return ListCollegeContactDeptTypeConfigResponse ListCollegeContactDeptTypeConfigResponse
     */
    public function listCollegeContactDeptTypeConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListCollegeContactDeptTypeConfigHeaders([]);

        return $this->listCollegeContactDeptTypeConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取高校通讯录场景架构列表
     *  *
     * @param ListCollegeContactSceneStrusRequest $request ListCollegeContactSceneStrusRequest
     * @param ListCollegeContactSceneStrusHeaders $headers ListCollegeContactSceneStrusHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return ListCollegeContactSceneStrusResponse ListCollegeContactSceneStrusResponse
     */
    public function listCollegeContactSceneStrusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
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
            'action' => 'ListCollegeContactSceneStrus',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/depts/structures/scenes',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListCollegeContactSceneStrusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取高校通讯录场景架构列表
     *  *
     * @param ListCollegeContactSceneStrusRequest $request ListCollegeContactSceneStrusRequest
     *
     * @return ListCollegeContactSceneStrusResponse ListCollegeContactSceneStrusResponse
     */
    public function listCollegeContactSceneStrus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListCollegeContactSceneStrusHeaders([]);

        return $this->listCollegeContactSceneStrusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取高校通讯录子组织单元列表
     *  *
     * @param ListCollegeContactSubDeptsRequest $request ListCollegeContactSubDeptsRequest
     * @param ListCollegeContactSubDeptsHeaders $headers ListCollegeContactSubDeptsHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return ListCollegeContactSubDeptsResponse ListCollegeContactSubDeptsResponse
     */
    public function listCollegeContactSubDeptsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
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
            'action' => 'ListCollegeContactSubDepts',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/subDepts',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListCollegeContactSubDeptsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取高校通讯录子组织单元列表
     *  *
     * @param ListCollegeContactSubDeptsRequest $request ListCollegeContactSubDeptsRequest
     *
     * @return ListCollegeContactSubDeptsResponse ListCollegeContactSubDeptsResponse
     */
    public function listCollegeContactSubDepts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListCollegeContactSubDeptsHeaders([]);

        return $this->listCollegeContactSubDeptsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询订单
     *  *
     * @param ListOrderRequest $request ListOrderRequest
     * @param ListOrderHeaders $headers ListOrderHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return ListOrderResponse ListOrderResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ListOrder',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/orders/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询订单
     *  *
     * @param ListOrderRequest $request ListOrderRequest
     *
     * @return ListOrderResponse ListOrderResponse
     */
    public function listOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListOrderHeaders([]);

        return $this->listOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 学生调班，如果学生在本班有对应的家长，则家长也会跟同学生进行调整班级。
     *  *
     * @param MoveStudentRequest $request MoveStudentRequest
     * @param MoveStudentHeaders $headers MoveStudentHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return MoveStudentResponse MoveStudentResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'MoveStudent',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/students/move',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return MoveStudentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 学生调班，如果学生在本班有对应的家长，则家长也会跟同学生进行调整班级。
     *  *
     * @param MoveStudentRequest $request MoveStudentRequest
     *
     * @return MoveStudentResponse MoveStudentResponse
     */
    public function moveStudent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MoveStudentHeaders([]);

        return $this->moveStudentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 开通教育套件
     *  *
     * @param OpenKitRequest $request OpenKitRequest
     * @param OpenKitHeaders $headers OpenKitHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return OpenKitResponse OpenKitResponse
     */
    public function openKitWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attributes)) {
            $body['attributes'] = $request->attributes;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->isvProductScene)) {
            $body['isvProductScene'] = $request->isvProductScene;
        }
        if (!Utils::isUnset($request->openEndTime)) {
            $body['openEndTime'] = $request->openEndTime;
        }
        if (!Utils::isUnset($request->openStartTime)) {
            $body['openStartTime'] = $request->openStartTime;
        }
        if (!Utils::isUnset($request->openUserId)) {
            $body['openUserId'] = $request->openUserId;
        }
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
            'action' => 'OpenKit',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/records/open',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return OpenKitResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 开通教育套件
     *  *
     * @param OpenKitRequest $request OpenKitRequest
     *
     * @return OpenKitResponse OpenKitResponse
     */
    public function openKit($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OpenKitHeaders([]);

        return $this->openKitWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询订单信息
     *  *
     * @param OrderInfoRequest $request OrderInfoRequest
     * @param OrderInfoHeaders $headers OrderInfoHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return OrderInfoResponse OrderInfoResponse
     */
    public function orderInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->orderNo)) {
            $query['orderNo'] = $request->orderNo;
        }
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
            'action' => 'OrderInfo',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/dingLifes/orders',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return OrderInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询订单信息
     *  *
     * @param OrderInfoRequest $request OrderInfoRequest
     *
     * @return OrderInfoResponse OrderInfoResponse
     */
    public function orderInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OrderInfoHeaders([]);

        return $this->orderInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询班级课表
     *  *
     * @param PageQueryClassCourseRequest $request PageQueryClassCourseRequest
     * @param PageQueryClassCourseHeaders $headers PageQueryClassCourseHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return PageQueryClassCourseResponse PageQueryClassCourseResponse
     */
    public function pageQueryClassCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->endCourseDate)) {
            $body['endCourseDate'] = $request->endCourseDate;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startCourseDate)) {
            $body['startCourseDate'] = $request->startCourseDate;
        }
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
            'action' => 'PageQueryClassCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/classes/courses/batchQuery',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PageQueryClassCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询班级课表
     *  *
     * @param PageQueryClassCourseRequest $request PageQueryClassCourseRequest
     *
     * @return PageQueryClassCourseResponse PageQueryClassCourseResponse
     */
    public function pageQueryClassCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageQueryClassCourseHeaders([]);

        return $this->pageQueryClassCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页查询设备列表
     *  *
     * @param PageQueryDevicesRequest $request PageQueryDevicesRequest
     * @param PageQueryDevicesHeaders $headers PageQueryDevicesHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return PageQueryDevicesResponse PageQueryDevicesResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'PageQueryDevices',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/vpaas/devices',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PageQueryDevicesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页查询设备列表
     *  *
     * @param PageQueryDevicesRequest $request PageQueryDevicesRequest
     *
     * @return PageQueryDevicesResponse PageQueryDevicesResponse
     */
    public function pageQueryDevices($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageQueryDevicesHeaders([]);

        return $this->pageQueryDevicesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询套件开通记录
     *  *
     * @param PageQueryKitOpenRecordRequest $request PageQueryKitOpenRecordRequest
     * @param PageQueryKitOpenRecordHeaders $headers PageQueryKitOpenRecordHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return PageQueryKitOpenRecordResponse PageQueryKitOpenRecordResponse
     */
    public function pageQueryKitOpenRecordWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->isvProductScene)) {
            $body['isvProductScene'] = $request->isvProductScene;
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
            'action' => 'PageQueryKitOpenRecord',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/records/batchQuery',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PageQueryKitOpenRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询套件开通记录
     *  *
     * @param PageQueryKitOpenRecordRequest $request PageQueryKitOpenRecordRequest
     *
     * @return PageQueryKitOpenRecordResponse PageQueryKitOpenRecordResponse
     */
    public function pageQueryKitOpenRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageQueryKitOpenRecordHeaders([]);

        return $this->pageQueryKitOpenRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 支付订单
     *  *
     * @param PayOrderRequest $request PayOrderRequest
     * @param PayOrderHeaders $headers PayOrderHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return PayOrderResponse PayOrderResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PayOrder',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/orders/pay',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PayOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 支付订单
     *  *
     * @param PayOrderRequest $request PayOrderRequest
     *
     * @return PayOrderResponse PayOrderResponse
     */
    public function payOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PayOrderHeaders([]);

        return $this->payOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 轮询课程状态，确认教师是否已同意开课
     *  *
     * @param PollingConfirmStatusRequest $request PollingConfirmStatusRequest
     * @param PollingConfirmStatusHeaders $headers PollingConfirmStatusHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return PollingConfirmStatusResponse PollingConfirmStatusResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'PollingConfirmStatus',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/universities/courses/pollingConfirmStatus',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PollingConfirmStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 轮询课程状态，确认教师是否已同意开课
     *  *
     * @param PollingConfirmStatusRequest $request PollingConfirmStatusRequest
     *
     * @return PollingConfirmStatusResponse PollingConfirmStatusResponse
     */
    public function pollingConfirmStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PollingConfirmStatusHeaders([]);

        return $this->pollingConfirmStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 视讯paas机具预拨号
     *  *
     * @param PreDialRequest $request PreDialRequest
     * @param PreDialHeaders $headers PreDialHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return PreDialResponse PreDialResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PreDial',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/vpaas/devices/preDial',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PreDialResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 视讯paas机具预拨号
     *  *
     * @param PreDialRequest $request PreDialRequest
     *
     * @return PreDialResponse PreDialResponse
     */
    public function preDial($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PreDialHeaders([]);

        return $this->preDialWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发放教育积分
     *  *
     * @param ProvidePointRequest $request ProvidePointRequest
     * @param ProvidePointHeaders $headers ProvidePointHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return ProvidePointResponse ProvidePointResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ProvidePoint',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/points/provide',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ProvidePointResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发放教育积分
     *  *
     * @param ProvidePointRequest $request ProvidePointRequest
     *
     * @return ProvidePointResponse ProvidePointResponse
     */
    public function providePoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ProvidePointHeaders([]);

        return $this->providePointWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发布成绩单
     *  *
     * @param PublishSchoolReportRequest $request PublishSchoolReportRequest
     * @param PublishSchoolReportHeaders $headers PublishSchoolReportHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return PublishSchoolReportResponse PublishSchoolReportResponse
     */
    public function publishSchoolReportWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->classDetailItems)) {
            $body['classDetailItems'] = $request->classDetailItems;
        }
        if (!Utils::isUnset($request->examClass)) {
            $body['examClass'] = $request->examClass;
        }
        if (!Utils::isUnset($request->examTitle)) {
            $body['examTitle'] = $request->examTitle;
        }
        if (!Utils::isUnset($request->identifier)) {
            $body['identifier'] = $request->identifier;
        }
        if (!Utils::isUnset($request->publishScope)) {
            $body['publishScope'] = $request->publishScope;
        }
        if (!Utils::isUnset($request->scoreType)) {
            $body['scoreType'] = $request->scoreType;
        }
        if (!Utils::isUnset($request->share)) {
            $body['share'] = $request->share;
        }
        if (!Utils::isUnset($request->showRank)) {
            $body['showRank'] = $request->showRank;
        }
        if (!Utils::isUnset($request->showStatisticsScore)) {
            $body['showStatisticsScore'] = $request->showStatisticsScore;
        }
        if (!Utils::isUnset($request->subScoreType)) {
            $body['subScoreType'] = $request->subScoreType;
        }
        if (!Utils::isUnset($request->subjectList)) {
            $body['subjectList'] = $request->subjectList;
        }
        if (!Utils::isUnset($request->subjects)) {
            $body['subjects'] = $request->subjects;
        }
        if (!Utils::isUnset($request->teacherId)) {
            $body['teacherId'] = $request->teacherId;
        }
        if (!Utils::isUnset($request->teacherName)) {
            $body['teacherName'] = $request->teacherName;
        }
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
            'action' => 'PublishSchoolReport',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/schools/reports/publish',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PublishSchoolReportResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发布成绩单
     *  *
     * @param PublishSchoolReportRequest $request PublishSchoolReportRequest
     *
     * @return PublishSchoolReportResponse PublishSchoolReportResponse
     */
    public function publishSchoolReport($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PublishSchoolReportHeaders([]);

        return $this->publishSchoolReportWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 推送班级群卡片消息
     *  *
     * @param PushClassGroupCardRequest $request PushClassGroupCardRequest
     * @param PushClassGroupCardHeaders $headers PushClassGroupCardHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return PushClassGroupCardResponse PushClassGroupCardResponse
     */
    public function pushClassGroupCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->groupTypeList)) {
            $body['groupTypeList'] = $request->groupTypeList;
        }
        if (!Utils::isUnset($request->privateCardData)) {
            $body['privateCardData'] = $request->privateCardData;
        }
        if (!Utils::isUnset($request->publicCardData)) {
            $body['publicCardData'] = $request->publicCardData;
        }
        if (!Utils::isUnset($request->senderUserId)) {
            $body['senderUserId'] = $request->senderUserId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PushClassGroupCard',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/classes/groups/cards/messages/push',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PushClassGroupCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 推送班级群卡片消息
     *  *
     * @param PushClassGroupCardRequest $request PushClassGroupCardRequest
     *
     * @return PushClassGroupCardResponse PushClassGroupCardResponse
     */
    public function pushClassGroupCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PushClassGroupCardHeaders([]);

        return $this->pushClassGroupCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 错题本-查询错题本
     *  *
     * @param QueryHeaders   $headers QueryHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryResponse QueryResponse
     */
    public function queryWithOptions($headers, $runtime)
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
            'action' => 'Query',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/wrongQuestions/codes',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 错题本-查询错题本
     *  *
     * @return QueryResponse QueryResponse
     */
    public function query()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHeaders([]);

        return $this->queryWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询全量学科实例列表
     *  *
     * @param QueryAllSubjectsFromClassScheduleRequest $tmpReq  QueryAllSubjectsFromClassScheduleRequest
     * @param QueryAllSubjectsFromClassScheduleHeaders $headers QueryAllSubjectsFromClassScheduleHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAllSubjectsFromClassScheduleResponse QueryAllSubjectsFromClassScheduleResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryAllSubjectsFromClassSchedule',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/subjects/instances',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryAllSubjectsFromClassScheduleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询全量学科实例列表
     *  *
     * @param QueryAllSubjectsFromClassScheduleRequest $request QueryAllSubjectsFromClassScheduleRequest
     *
     * @return QueryAllSubjectsFromClassScheduleResponse QueryAllSubjectsFromClassScheduleResponse
     */
    public function queryAllSubjectsFromClassSchedule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllSubjectsFromClassScheduleHeaders([]);

        return $this->queryAllSubjectsFromClassScheduleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询课程表
     *  *
     * @param QueryClassScheduleRequest $request QueryClassScheduleRequest
     * @param QueryClassScheduleHeaders $headers QueryClassScheduleHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryClassScheduleResponse QueryClassScheduleResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryClassSchedule',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/classes/schedules/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryClassScheduleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询课程表
     *  *
     * @param QueryClassScheduleRequest $request QueryClassScheduleRequest
     *
     * @return QueryClassScheduleResponse QueryClassScheduleResponse
     */
    public function queryClassSchedule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryClassScheduleHeaders([]);

        return $this->queryClassScheduleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 按照学校和时间区间筛选课程
     *  *
     * @param QueryClassScheduleByTimeSchoolRequest $request QueryClassScheduleByTimeSchoolRequest
     * @param QueryClassScheduleByTimeSchoolHeaders $headers QueryClassScheduleByTimeSchoolHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryClassScheduleByTimeSchoolResponse QueryClassScheduleByTimeSchoolResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryClassScheduleByTimeSchool',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/schools/classes/courses ',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryClassScheduleByTimeSchoolResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 按照学校和时间区间筛选课程
     *  *
     * @param QueryClassScheduleByTimeSchoolRequest $request QueryClassScheduleByTimeSchoolRequest
     *
     * @return QueryClassScheduleByTimeSchoolResponse QueryClassScheduleByTimeSchoolResponse
     */
    public function queryClassScheduleByTimeSchool($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryClassScheduleByTimeSchoolHeaders([]);

        return $this->queryClassScheduleByTimeSchoolWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取课程表设置
     *  *
     * @param QueryClassScheduleConfigRequest $tmpReq  QueryClassScheduleConfigRequest
     * @param QueryClassScheduleConfigHeaders $headers QueryClassScheduleConfigHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryClassScheduleConfigResponse QueryClassScheduleConfigResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryClassScheduleConfig',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/schedules/configs',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryClassScheduleConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取课程表设置
     *  *
     * @param QueryClassScheduleConfigRequest $request QueryClassScheduleConfigRequest
     *
     * @return QueryClassScheduleConfigResponse QueryClassScheduleConfigResponse
     */
    public function queryClassScheduleConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryClassScheduleConfigHeaders([]);

        return $this->queryClassScheduleConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取用户详情(包含高校账号)
     *  *
     * @param QueryCollegeContactUserDetailRequest $request QueryCollegeContactUserDetailRequest
     * @param QueryCollegeContactUserDetailHeaders $headers QueryCollegeContactUserDetailHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCollegeContactUserDetailResponse QueryCollegeContactUserDetailResponse
     */
    public function queryCollegeContactUserDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->jobNumber)) {
            $query['jobNumber'] = $request->jobNumber;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->userid)) {
            $query['userid'] = $request->userid;
        }
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
            'action' => 'QueryCollegeContactUserDetail',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/users',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryCollegeContactUserDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户详情(包含高校账号)
     *  *
     * @param QueryCollegeContactUserDetailRequest $request QueryCollegeContactUserDetailRequest
     *
     * @return QueryCollegeContactUserDetailResponse QueryCollegeContactUserDetailResponse
     */
    public function queryCollegeContactUserDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCollegeContactUserDetailHeaders([]);

        return $this->queryCollegeContactUserDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询单台视讯PAAS设备
     *  *
     * @param QueryDeviceRequest $request QueryDeviceRequest
     * @param QueryDeviceHeaders $headers QueryDeviceHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDeviceResponse QueryDeviceResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryDevice',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/vpass/devices/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询单台视讯PAAS设备
     *  *
     * @param QueryDeviceRequest $request QueryDeviceRequest
     *
     * @return QueryDeviceResponse QueryDeviceResponse
     */
    public function queryDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceHeaders([]);

        return $this->queryDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询某个组织下面的设备列表
     *  *
     * @param QueryDeviceListByCorpIdRequest $request QueryDeviceListByCorpIdRequest
     * @param QueryDeviceListByCorpIdHeaders $headers QueryDeviceListByCorpIdHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDeviceListByCorpIdResponse QueryDeviceListByCorpIdResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryDeviceListByCorpId',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/remoteClasses/devices',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryDeviceListByCorpIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询某个组织下面的设备列表
     *  *
     * @param QueryDeviceListByCorpIdRequest $request QueryDeviceListByCorpIdRequest
     *
     * @return QueryDeviceListByCorpIdResponse QueryDeviceListByCorpIdResponse
     */
    public function queryDeviceListByCorpId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceListByCorpIdHeaders([]);

        return $this->queryDeviceListByCorpIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 教学资源库查询space列表
     *  *
     * @param QueryEduAssetSpacesRequest $request QueryEduAssetSpacesRequest
     * @param QueryEduAssetSpacesHeaders $headers QueryEduAssetSpacesHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryEduAssetSpacesResponse QueryEduAssetSpacesResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryEduAssetSpaces',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/assets/spaces',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryEduAssetSpacesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 教学资源库查询space列表
     *  *
     * @param QueryEduAssetSpacesRequest $request QueryEduAssetSpacesRequest
     *
     * @return QueryEduAssetSpacesResponse QueryEduAssetSpacesResponse
     */
    public function queryEduAssetSpaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryEduAssetSpacesHeaders([]);

        return $this->queryEduAssetSpacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据设备SN信息查询学校人脸库
     *  *
     * @param QueryGroupIdRequest $request QueryGroupIdRequest
     * @param QueryGroupIdHeaders $headers QueryGroupIdHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGroupIdResponse QueryGroupIdResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryGroupId',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/faces/groups',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryGroupIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据设备SN信息查询学校人脸库
     *  *
     * @param QueryGroupIdRequest $request QueryGroupIdRequest
     *
     * @return QueryGroupIdResponse QueryGroupIdResponse
     */
    public function queryGroupId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupIdHeaders([]);

        return $this->queryGroupIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询套件开通记录
     *  *
     * @param QueryKitOpenRecordRequest $request QueryKitOpenRecordRequest
     * @param QueryKitOpenRecordHeaders $headers QueryKitOpenRecordHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryKitOpenRecordResponse QueryKitOpenRecordResponse
     */
    public function queryKitOpenRecordWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->isvProductScene)) {
            $body['isvProductScene'] = $request->isvProductScene;
        }
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
            'action' => 'QueryKitOpenRecord',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/records/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryKitOpenRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询套件开通记录
     *  *
     * @param QueryKitOpenRecordRequest $request QueryKitOpenRecordRequest
     *
     * @return QueryKitOpenRecordResponse QueryKitOpenRecordResponse
     */
    public function queryKitOpenRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryKitOpenRecordHeaders([]);

        return $this->queryKitOpenRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取大模型的返回值
     *  *
     * @param QueryModelResultByTaskIdRequest $request QueryModelResultByTaskIdRequest
     * @param QueryModelResultByTaskIdHeaders $headers QueryModelResultByTaskIdHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryModelResultByTaskIdResponse QueryModelResultByTaskIdResponse
     */
    public function queryModelResultByTaskIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryModelResultByTaskId',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/ai/models/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryModelResultByTaskIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取大模型的返回值
     *  *
     * @param QueryModelResultByTaskIdRequest $request QueryModelResultByTaskIdRequest
     *
     * @return QueryModelResultByTaskIdResponse QueryModelResultByTaskIdResponse
     */
    public function queryModelResultByTaskId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryModelResultByTaskIdHeaders([]);

        return $this->queryModelResultByTaskIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询订单信息
     *  *
     * @param QueryOrderRequest $request QueryOrderRequest
     * @param QueryOrderHeaders $headers QueryOrderHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOrderResponse QueryOrderResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryOrder',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/orders',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询订单信息
     *  *
     * @param QueryOrderRequest $request QueryOrderRequest
     *
     * @return QueryOrderResponse QueryOrderResponse
     */
    public function queryOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrderHeaders([]);

        return $this->queryOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询某个组织下面关联的组织列表
     *  *
     * @param QueryOrgRelationListRequest $request QueryOrgRelationListRequest
     * @param QueryOrgRelationListHeaders $headers QueryOrgRelationListHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOrgRelationListResponse QueryOrgRelationListResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryOrgRelationList',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/remoteClasses/orgRelations',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryOrgRelationListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询某个组织下面关联的组织列表
     *  *
     * @param QueryOrgRelationListRequest $request QueryOrgRelationListRequest
     *
     * @return QueryOrgRelationListResponse QueryOrgRelationListResponse
     */
    public function queryOrgRelationList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgRelationListHeaders([]);

        return $this->queryOrgRelationListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取组织秘钥
     *  *
     * @param QueryOrgSecretKeyRequest $request QueryOrgSecretKeyRequest
     * @param QueryOrgSecretKeyHeaders $headers QueryOrgSecretKeyHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOrgSecretKeyResponse QueryOrgSecretKeyResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryOrgSecretKey',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/universities/secretKeys',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryOrgSecretKeyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取组织秘钥
     *  *
     * @param QueryOrgSecretKeyRequest $request QueryOrgSecretKeyRequest
     *
     * @return QueryOrgSecretKeyResponse QueryOrgSecretKeyResponse
     */
    public function queryOrgSecretKey($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgSecretKeyHeaders([]);

        return $this->queryOrgSecretKeyWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询教育组织类型
     *  *
     * @param QueryOrgTypeHeaders $headers QueryOrgTypeHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOrgTypeResponse QueryOrgTypeResponse
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
            'action' => 'QueryOrgType',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/orgTypes',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryOrgTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询教育组织类型
     *  *
     * @return QueryOrgTypeResponse QueryOrgTypeResponse
     */
    public function queryOrgType()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgTypeHeaders([]);

        return $this->queryOrgTypeWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询支付结果
     *  *
     * @param QueryPayResultRequest $request QueryPayResultRequest
     * @param QueryPayResultHeaders $headers QueryPayResultHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryPayResultResponse QueryPayResultResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryPayResult',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/payResults/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryPayResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询支付结果
     *  *
     * @param QueryPayResultRequest $request QueryPayResultRequest
     *
     * @return QueryPayResultResponse QueryPayResultResponse
     */
    public function queryPayResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPayResultHeaders([]);

        return $this->queryPayResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询物理教室信息
     *  *
     * @param QueryPhysicalClassroomRequest $request QueryPhysicalClassroomRequest
     * @param QueryPhysicalClassroomHeaders $headers QueryPhysicalClassroomHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryPhysicalClassroomResponse QueryPhysicalClassroomResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryPhysicalClassroom',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/physicalClassrooms',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryPhysicalClassroomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询物理教室信息
     *  *
     * @param QueryPhysicalClassroomRequest $request QueryPhysicalClassroomRequest
     *
     * @return QueryPhysicalClassroomResponse QueryPhysicalClassroomResponse
     */
    public function queryPhysicalClassroom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPhysicalClassroomHeaders([]);

        return $this->queryPhysicalClassroomWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户订购服务状态
     *  *
     * @param QueryPurchaseInfoRequest $request QueryPurchaseInfoRequest
     * @param QueryPurchaseInfoHeaders $headers QueryPurchaseInfoHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryPurchaseInfoResponse QueryPurchaseInfoResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryPurchaseInfo',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/users/purchases',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryPurchaseInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户订购服务状态
     *  *
     * @param QueryPurchaseInfoRequest $request QueryPurchaseInfoRequest
     *
     * @return QueryPurchaseInfoResponse QueryPurchaseInfoResponse
     */
    public function queryPurchaseInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryPurchaseInfoHeaders([]);

        return $this->queryPurchaseInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询课程列表
     *  *
     * @param QueryRemoteClassCourseRequest $request QueryRemoteClassCourseRequest
     * @param QueryRemoteClassCourseHeaders $headers QueryRemoteClassCourseHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryRemoteClassCourseResponse QueryRemoteClassCourseResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryRemoteClassCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/remoteClasses/courses',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryRemoteClassCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询课程列表
     *  *
     * @param QueryRemoteClassCourseRequest $request QueryRemoteClassCourseRequest
     *
     * @return QueryRemoteClassCourseResponse QueryRemoteClassCourseResponse
     */
    public function queryRemoteClassCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRemoteClassCourseHeaders([]);

        return $this->queryRemoteClassCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分批查询学校人脸id
     *  *
     * @param QuerySchoolUserFaceRequest $request QuerySchoolUserFaceRequest
     * @param QuerySchoolUserFaceHeaders $headers QuerySchoolUserFaceHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return QuerySchoolUserFaceResponse QuerySchoolUserFaceResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QuerySchoolUserFace',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/schools/faces',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QuerySchoolUserFaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分批查询学校人脸id
     *  *
     * @param QuerySchoolUserFaceRequest $request QuerySchoolUserFaceRequest
     *
     * @return QuerySchoolUserFaceResponse QuerySchoolUserFaceResponse
     */
    public function querySchoolUserFace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySchoolUserFaceHeaders([]);

        return $this->querySchoolUserFaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 个人应用查询订单信息
     *  *
     * @param QuerySnsOrderRequest $request QuerySnsOrderRequest
     * @param QuerySnsOrderHeaders $headers QuerySnsOrderHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return QuerySnsOrderResponse QuerySnsOrderResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QuerySnsOrder',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/snsOrders',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QuerySnsOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 个人应用查询订单信息
     *  *
     * @param QuerySnsOrderRequest $request QuerySnsOrderRequest
     *
     * @return QuerySnsOrderResponse QuerySnsOrderResponse
     */
    public function querySnsOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySnsOrderHeaders([]);

        return $this->querySnsOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获得课程表详细信息
     *  *
     * @param QueryStatisticsDataRequest $request QueryStatisticsDataRequest
     * @param QueryStatisticsDataHeaders $headers QueryStatisticsDataHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryStatisticsDataResponse QueryStatisticsDataResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryStatisticsData',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/classes/schedules/statisticData/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryStatisticsDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获得课程表详细信息
     *  *
     * @param QueryStatisticsDataRequest $request QueryStatisticsDataRequest
     *
     * @return QueryStatisticsDataResponse QueryStatisticsDataResponse
     */
    public function queryStatisticsData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryStatisticsDataHeaders([]);

        return $this->queryStatisticsDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询学生班级
     *  *
     * @param QueryStudentClassRequest $request QueryStudentClassRequest
     * @param QueryStudentClassHeaders $headers QueryStudentClassHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryStudentClassResponse QueryStudentClassResponse
     */
    public function queryStudentClassWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->classType)) {
            $body['classType'] = $request->classType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryStudentClass',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/students/classes/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryStudentClassResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询学生班级
     *  *
     * @param QueryStudentClassRequest $request QueryStudentClassRequest
     *
     * @return QueryStudentClassResponse QueryStudentClassResponse
     */
    public function queryStudentClass($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryStudentClassHeaders([]);

        return $this->queryStudentClassWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询教授某学科老师列表
     *  *
     * @param QuerySubjectTeachersRequest $request QuerySubjectTeachersRequest
     * @param QuerySubjectTeachersHeaders $headers QuerySubjectTeachersHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QuerySubjectTeachersResponse QuerySubjectTeachersResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QuerySubjectTeachers',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/subjects/teachers',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QuerySubjectTeachersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询教授某学科老师列表
     *  *
     * @param QuerySubjectTeachersRequest $request QuerySubjectTeachersRequest
     *
     * @return QuerySubjectTeachersResponse QuerySubjectTeachersResponse
     */
    public function querySubjectTeachers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySubjectTeachersHeaders([]);

        return $this->querySubjectTeachersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询老师教授学科列表
     *  *
     * @param QueryTeachSubjectsRequest $request QueryTeachSubjectsRequest
     * @param QueryTeachSubjectsHeaders $headers QueryTeachSubjectsHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryTeachSubjectsResponse QueryTeachSubjectsResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryTeachSubjects',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/teachers/subjects',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryTeachSubjectsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询老师教授学科列表
     *  *
     * @param QueryTeachSubjectsRequest $request QueryTeachSubjectsRequest
     *
     * @return QueryTeachSubjectsResponse QueryTeachSubjectsResponse
     */
    public function queryTeachSubjects($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTeachSubjectsHeaders([]);

        return $this->queryTeachSubjectsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询老师课程
     *  *
     * @param QueryTeacherCourseRequest $request QueryTeacherCourseRequest
     * @param QueryTeacherCourseHeaders $headers QueryTeacherCourseHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryTeacherCourseResponse QueryTeacherCourseResponse
     */
    public function queryTeacherCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->isvCourseIdList)) {
            $body['isvCourseIdList'] = $request->isvCourseIdList;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryTeacherCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/teachers/courses/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryTeacherCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询老师课程
     *  *
     * @param QueryTeacherCourseRequest $request QueryTeacherCourseRequest
     *
     * @return QueryTeacherCourseResponse QueryTeacherCourseResponse
     */
    public function queryTeacherCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTeacherCourseHeaders([]);

        return $this->queryTeacherCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询调代课记录
     *  *
     * @param QueryTransferCourseRequest $request QueryTransferCourseRequest
     * @param QueryTransferCourseHeaders $headers QueryTransferCourseHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryTransferCourseResponse QueryTransferCourseResponse
     */
    public function queryTransferCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->isvRecordId)) {
            $body['isvRecordId'] = $request->isvRecordId;
        }
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
            'action' => 'QueryTransferCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/transferRecords/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryTransferCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询调代课记录
     *  *
     * @param QueryTransferCourseRequest $request QueryTransferCourseRequest
     *
     * @return QueryTransferCourseResponse QueryTransferCourseResponse
     */
    public function queryTransferCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTransferCourseHeaders([]);

        return $this->queryTransferCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询大学课程组
     *  *
     * @param QueryUniversityCourseGroupRequest $request QueryUniversityCourseGroupRequest
     * @param QueryUniversityCourseGroupHeaders $headers QueryUniversityCourseGroupHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUniversityCourseGroupResponse QueryUniversityCourseGroupResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryUniversityCourseGroup',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/universities/courseGroups',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryUniversityCourseGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询大学课程组
     *  *
     * @param QueryUniversityCourseGroupRequest $request QueryUniversityCourseGroupRequest
     *
     * @return QueryUniversityCourseGroupResponse QueryUniversityCourseGroupResponse
     */
    public function queryUniversityCourseGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUniversityCourseGroupHeaders([]);

        return $this->queryUniversityCourseGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据人脸id查询用户信息
     *  *
     * @param QueryUserFaceRequest $request QueryUserFaceRequest
     * @param QueryUserFaceHeaders $headers QueryUserFaceHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserFaceResponse QueryUserFaceResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryUserFace',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/users/faces',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryUserFaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据人脸id查询用户信息
     *  *
     * @param QueryUserFaceRequest $request QueryUserFaceRequest
     *
     * @return QueryUserFaceResponse QueryUserFaceResponse
     */
    public function queryUserFace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserFaceHeaders([]);

        return $this->queryUserFaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户支付信息
     *  *
     * @param QueryUserPayInfoRequest $request QueryUserPayInfoRequest
     * @param QueryUserPayInfoHeaders $headers QueryUserPayInfoHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserPayInfoResponse QueryUserPayInfoResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryUserPayInfo',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/orders/payInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryUserPayInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户支付信息
     *  *
     * @param QueryUserPayInfoRequest $request QueryUserPayInfoRequest
     *
     * @return QueryUserPayInfoResponse QueryUserPayInfoResponse
     */
    public function queryUserPayInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserPayInfoHeaders([]);

        return $this->queryUserPayInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 移除设备
     *  *
     * @param RemoveDeviceRequest $request RemoveDeviceRequest
     * @param RemoveDeviceHeaders $headers RemoveDeviceHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return RemoveDeviceResponse RemoveDeviceResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'RemoveDevice',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/devices',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RemoveDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 移除设备
     *  *
     * @param RemoveDeviceRequest $request RemoveDeviceRequest
     *
     * @return RemoveDeviceResponse RemoveDeviceResponse
     */
    public function removeDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveDeviceHeaders([]);

        return $this->removeDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设备日志上报接口
     *  *
     * @param ReportDeviceLogRequest $request ReportDeviceLogRequest
     * @param ReportDeviceLogHeaders $headers ReportDeviceLogHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ReportDeviceLogResponse ReportDeviceLogResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ReportDeviceLog',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/deviceLogs/report',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ReportDeviceLogResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设备日志上报接口
     *  *
     * @param ReportDeviceLogRequest $request ReportDeviceLogRequest
     *
     * @return ReportDeviceLogResponse ReportDeviceLogResponse
     */
    public function reportDeviceLog($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReportDeviceLogHeaders([]);

        return $this->reportDeviceLogWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 上传设备使用日志
     *  *
     * @param ReportDeviceUseLogRequest $request ReportDeviceUseLogRequest
     * @param ReportDeviceUseLogHeaders $headers ReportDeviceUseLogHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return ReportDeviceUseLogResponse ReportDeviceUseLogResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ReportDeviceUseLog',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/deviceUseLogs/report',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ReportDeviceUseLogResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 上传设备使用日志
     *  *
     * @param ReportDeviceUseLogRequest $request ReportDeviceUseLogRequest
     *
     * @return ReportDeviceUseLogResponse ReportDeviceUseLogResponse
     */
    public function reportDeviceUseLog($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReportDeviceUseLogHeaders([]);

        return $this->reportDeviceUseLogWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 回滚教育积分扣减
     *  *
     * @param RollbackDeductPointRequest $request RollbackDeductPointRequest
     * @param RollbackDeductPointHeaders $headers RollbackDeductPointHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return RollbackDeductPointResponse RollbackDeductPointResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'RollbackDeductPoint',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/deductPoints/rollback',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RollbackDeductPointResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 回滚教育积分扣减
     *  *
     * @param RollbackDeductPointRequest $request RollbackDeductPointRequest
     *
     * @return RollbackDeductPointResponse RollbackDeductPointResponse
     */
    public function rollbackDeductPoint($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RollbackDeductPointHeaders([]);

        return $this->rollbackDeductPointWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 保存班级学情数据
     *  *
     * @param SaveClassLearningDataRequest $request SaveClassLearningDataRequest
     * @param SaveClassLearningDataHeaders $headers SaveClassLearningDataHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveClassLearningDataResponse SaveClassLearningDataResponse
     */
    public function saveClassLearningDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->assignNum)) {
            $body['assignNum'] = $request->assignNum;
        }
        if (!Utils::isUnset($request->assignStudentUserIds)) {
            $body['assignStudentUserIds'] = $request->assignStudentUserIds;
        }
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->fileSuffix)) {
            $body['fileSuffix'] = $request->fileSuffix;
        }
        if (!Utils::isUnset($request->generatedTime)) {
            $body['generatedTime'] = $request->generatedTime;
        }
        if (!Utils::isUnset($request->questionNum)) {
            $body['questionNum'] = $request->questionNum;
        }
        if (!Utils::isUnset($request->questionPictureNum)) {
            $body['questionPictureNum'] = $request->questionPictureNum;
        }
        if (!Utils::isUnset($request->standardAnswerPictureNum)) {
            $body['standardAnswerPictureNum'] = $request->standardAnswerPictureNum;
        }
        if (!Utils::isUnset($request->subjectCode)) {
            $body['subjectCode'] = $request->subjectCode;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SaveClassLearningData',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/classes/learnings/datas/save',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SaveClassLearningDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 保存班级学情数据
     *  *
     * @param SaveClassLearningDataRequest $request SaveClassLearningDataRequest
     *
     * @return SaveClassLearningDataResponse SaveClassLearningDataResponse
     */
    public function saveClassLearningData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveClassLearningDataHeaders([]);

        return $this->saveClassLearningDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 保存学生学情数据
     *  *
     * @param SaveStudentLearningDataRequest $request SaveStudentLearningDataRequest
     * @param SaveStudentLearningDataHeaders $headers SaveStudentLearningDataHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveStudentLearningDataResponse SaveStudentLearningDataResponse
     */
    public function saveStudentLearningDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->assignNum)) {
            $body['assignNum'] = $request->assignNum;
        }
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->correctNum)) {
            $body['correctNum'] = $request->correctNum;
        }
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->fileSuffix)) {
            $body['fileSuffix'] = $request->fileSuffix;
        }
        if (!Utils::isUnset($request->generatedTime)) {
            $body['generatedTime'] = $request->generatedTime;
        }
        if (!Utils::isUnset($request->questionNum)) {
            $body['questionNum'] = $request->questionNum;
        }
        if (!Utils::isUnset($request->studentUserId)) {
            $body['studentUserId'] = $request->studentUserId;
        }
        if (!Utils::isUnset($request->subjectCode)) {
            $body['subjectCode'] = $request->subjectCode;
        }
        if (!Utils::isUnset($request->submitNum)) {
            $body['submitNum'] = $request->submitNum;
        }
        if (!Utils::isUnset($request->wrongQuestions)) {
            $body['wrongQuestions'] = $request->wrongQuestions;
        }
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
            'action' => 'SaveStudentLearningData',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/students/learnings/datas/save',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SaveStudentLearningDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 保存学生学情数据
     *  *
     * @param SaveStudentLearningDataRequest $request SaveStudentLearningDataRequest
     *
     * @return SaveStudentLearningDataResponse SaveStudentLearningDataResponse
     */
    public function saveStudentLearningData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveStudentLearningDataHeaders([]);

        return $this->saveStudentLearningDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 成绩单详情已读状态设置
     *  *
     * @param SchoolReportDetailReadedRequest $request SchoolReportDetailReadedRequest
     * @param SchoolReportDetailReadedHeaders $headers SchoolReportDetailReadedHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return SchoolReportDetailReadedResponse SchoolReportDetailReadedResponse
     */
    public function schoolReportDetailReadedWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->schoolReportId)) {
            $body['schoolReportId'] = $request->schoolReportId;
        }
        if (!Utils::isUnset($request->studentIds)) {
            $body['studentIds'] = $request->studentIds;
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
            'action' => 'SchoolReportDetailReaded',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/schools/reportDetails/readStatuses/set',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SchoolReportDetailReadedResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 成绩单详情已读状态设置
     *  *
     * @param SchoolReportDetailReadedRequest $request SchoolReportDetailReadedRequest
     *
     * @return SchoolReportDetailReadedResponse SchoolReportDetailReadedResponse
     */
    public function schoolReportDetailReaded($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SchoolReportDetailReadedHeaders([]);

        return $this->schoolReportDetailReadedWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 按关键字搜索老师
     *  *
     * @param SearchTeachersRequest $request SearchTeachersRequest
     * @param SearchTeachersHeaders $headers SearchTeachersHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchTeachersResponse SearchTeachersResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'SearchTeachers',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/teachers/search',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return SearchTeachersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 按关键字搜索老师
     *  *
     * @param SearchTeachersRequest $request SearchTeachersRequest
     *
     * @return SearchTeachersResponse SearchTeachersResponse
     */
    public function searchTeachers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchTeachersHeaders([]);

        return $this->searchTeachersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 套件-发送AI卡片
     *  *
     * @param SendAiCardRequest $request SendAiCardRequest
     * @param SendAiCardHeaders $headers SendAiCardHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return SendAiCardResponse SendAiCardResponse
     */
    public function sendAiCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionType)) {
            $body['actionType'] = $request->actionType;
        }
        if (!Utils::isUnset($request->bizData)) {
            $body['bizData'] = $request->bizData;
        }
        if (!Utils::isUnset($request->cardChannel)) {
            $body['cardChannel'] = $request->cardChannel;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->identifier)) {
            $body['identifier'] = $request->identifier;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
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
            'action' => 'SendAiCard',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/aiCards/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendAiCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 套件-发送AI卡片
     *  *
     * @param SendAiCardRequest $request SendAiCardRequest
     *
     * @return SendAiCardResponse SendAiCardResponse
     */
    public function sendAiCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendAiCardHeaders([]);

        return $this->sendAiCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 高校AI助理主动发送消息
     *  *
     * @param SendCollegeAiAssistantMsgRequest $request SendCollegeAiAssistantMsgRequest
     * @param SendCollegeAiAssistantMsgHeaders $headers SendCollegeAiAssistantMsgHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return SendCollegeAiAssistantMsgResponse SendCollegeAiAssistantMsgResponse
     */
    public function sendCollegeAiAssistantMsgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->contentType)) {
            $body['contentType'] = $request->contentType;
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
            'action' => 'SendCollegeAiAssistantMsg',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/colleges/aiAssistants/messages/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendCollegeAiAssistantMsgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 高校AI助理主动发送消息
     *  *
     * @param SendCollegeAiAssistantMsgRequest $request SendCollegeAiAssistantMsgRequest
     *
     * @return SendCollegeAiAssistantMsgResponse SendCollegeAiAssistantMsgResponse
     */
    public function sendCollegeAiAssistantMsg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendCollegeAiAssistantMsgHeaders([]);

        return $this->sendCollegeAiAssistantMsgWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 收藏文件消息发送
     *  *
     * @param SendFileMessageRequest $request SendFileMessageRequest
     * @param SendFileMessageHeaders $headers SendFileMessageHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return SendFileMessageResponse SendFileMessageResponse
     */
    public function sendFileMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->fileName)) {
            $body['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->fileSize)) {
            $body['fileSize'] = $request->fileSize;
        }
        if (!Utils::isUnset($request->fileUrl)) {
            $body['fileUrl'] = $request->fileUrl;
        }
        if (!Utils::isUnset($request->sendType)) {
            $body['sendType'] = $request->sendType;
        }
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
            'action' => 'SendFileMessage',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/contents/files/messages/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendFileMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 收藏文件消息发送
     *  *
     * @param SendFileMessageRequest $request SendFileMessageRequest
     *
     * @return SendFileMessageResponse SendFileMessageResponse
     */
    public function sendFileMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendFileMessageHeaders([]);

        return $this->sendFileMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亲情通话发消息
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SendMessage',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/messages/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 亲情通话发消息
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

    /**
     * @summary 发送打印订单提醒消息
     *  *
     * @param SendPrintOrderNoticeMsgRequest $request SendPrintOrderNoticeMsgRequest
     * @param SendPrintOrderNoticeMsgHeaders $headers SendPrintOrderNoticeMsgHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return SendPrintOrderNoticeMsgResponse SendPrintOrderNoticeMsgResponse
     */
    public function sendPrintOrderNoticeMsgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->createOrderTime)) {
            $body['createOrderTime'] = $request->createOrderTime;
        }
        if (!Utils::isUnset($request->deliveryCompanyName)) {
            $body['deliveryCompanyName'] = $request->deliveryCompanyName;
        }
        if (!Utils::isUnset($request->deliveryNumber)) {
            $body['deliveryNumber'] = $request->deliveryNumber;
        }
        if (!Utils::isUnset($request->deliveryTime)) {
            $body['deliveryTime'] = $request->deliveryTime;
        }
        if (!Utils::isUnset($request->paymentTime)) {
            $body['paymentTime'] = $request->paymentTime;
        }
        if (!Utils::isUnset($request->price)) {
            $body['price'] = $request->price;
        }
        if (!Utils::isUnset($request->sceneCode)) {
            $body['sceneCode'] = $request->sceneCode;
        }
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
            'action' => 'SendPrintOrderNoticeMsg',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/files/printOrders/noticeMessages/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendPrintOrderNoticeMsgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送打印订单提醒消息
     *  *
     * @param SendPrintOrderNoticeMsgRequest $request SendPrintOrderNoticeMsgRequest
     *
     * @return SendPrintOrderNoticeMsgResponse SendPrintOrderNoticeMsgResponse
     */
    public function sendPrintOrderNoticeMsg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendPrintOrderNoticeMsgHeaders([]);

        return $this->sendPrintOrderNoticeMsgWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 开始课程
     *  *
     * @param StartCourseRequest $request StartCourseRequest
     * @param StartCourseHeaders $headers StartCourseHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return StartCourseResponse StartCourseResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'StartCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/universities/courses/start',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return StartCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 开始课程
     *  *
     * @param StartCourseRequest $request StartCourseRequest
     *
     * @return StartCourseResponse StartCourseResponse
     */
    public function startCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartCourseHeaders([]);

        return $this->startCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 预开课，发送开课提醒
     *  *
     * @param StartCoursePrepareRequest $request StartCoursePrepareRequest
     * @param StartCoursePrepareHeaders $headers StartCoursePrepareHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return StartCoursePrepareResponse StartCoursePrepareResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'StartCoursePrepare',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/universities/courses/prepare',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return StartCoursePrepareResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 预开课，发送开课提醒
     *  *
     * @param StartCoursePrepareRequest $request StartCoursePrepareRequest
     *
     * @return StartCoursePrepareResponse StartCoursePrepareResponse
     */
    public function startCoursePrepare($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartCoursePrepareHeaders([]);

        return $this->startCoursePrepareWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary AI体育-上报数据
     *  *
     * @param SubmitAiSportDataRequest $request SubmitAiSportDataRequest
     * @param SubmitAiSportDataHeaders $headers SubmitAiSportDataHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return SubmitAiSportDataResponse SubmitAiSportDataResponse
     */
    public function submitAiSportDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->dataType)) {
            $body['dataType'] = $request->dataType;
        }
        if (!Utils::isUnset($request->operateType)) {
            $body['operateType'] = $request->operateType;
        }
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
            'action' => 'SubmitAiSportData',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/aiSports/data/submit',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SubmitAiSportDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary AI体育-上报数据
     *  *
     * @param SubmitAiSportDataRequest $request SubmitAiSportDataRequest
     *
     * @return SubmitAiSportDataResponse SubmitAiSportDataResponse
     */
    public function submitAiSportData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SubmitAiSportDataHeaders([]);

        return $this->submitAiSportDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 订阅大学课程组
     *  *
     * @param SubscribeUniversityCourseGroupRequest $request SubscribeUniversityCourseGroupRequest
     * @param SubscribeUniversityCourseGroupHeaders $headers SubscribeUniversityCourseGroupHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return SubscribeUniversityCourseGroupResponse SubscribeUniversityCourseGroupResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SubscribeUniversityCourseGroup',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/universities/courseGroups/subscribe',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return SubscribeUniversityCourseGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 订阅大学课程组
     *  *
     * @param SubscribeUniversityCourseGroupRequest $request SubscribeUniversityCourseGroupRequest
     *
     * @return SubscribeUniversityCourseGroupResponse SubscribeUniversityCourseGroupResponse
     */
    public function subscribeUniversityCourseGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SubscribeUniversityCourseGroupHeaders([]);

        return $this->subscribeUniversityCourseGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 取消订阅大学课程组
     *  *
     * @param UnsubscribeUniversityCourseGroupRequest $request UnsubscribeUniversityCourseGroupRequest
     * @param UnsubscribeUniversityCourseGroupHeaders $headers UnsubscribeUniversityCourseGroupHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return UnsubscribeUniversityCourseGroupResponse UnsubscribeUniversityCourseGroupResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UnsubscribeUniversityCourseGroup',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/universities/courseGroups/unsubscribe',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UnsubscribeUniversityCourseGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 取消订阅大学课程组
     *  *
     * @param UnsubscribeUniversityCourseGroupRequest $request UnsubscribeUniversityCourseGroupRequest
     *
     * @return UnsubscribeUniversityCourseGroupResponse UnsubscribeUniversityCourseGroupResponse
     */
    public function unsubscribeUniversityCourseGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnsubscribeUniversityCourseGroupHeaders([]);

        return $this->unsubscribeUniversityCourseGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改班级信息
     *  *
     * @param UpdateClassRequest $request UpdateClassRequest
     * @param UpdateClassHeaders $headers UpdateClassHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateClassResponse UpdateClassResponse
     */
    public function updateClassWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->gradeLevel)) {
            $body['gradeLevel'] = $request->gradeLevel;
        }
        if (!Utils::isUnset($request->openClass)) {
            $body['openClass'] = $request->openClass;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateClass',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/classes/infos',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateClassResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改班级信息
     *  *
     * @param UpdateClassRequest $request UpdateClassRequest
     *
     * @return UpdateClassResponse UpdateClassResponse
     */
    public function updateClass($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateClassHeaders([]);

        return $this->updateClassWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新班级群卡片消息
     *  *
     * @param UpdateClassGroupCardRequest $request UpdateClassGroupCardRequest
     * @param UpdateClassGroupCardHeaders $headers UpdateClassGroupCardHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateClassGroupCardResponse UpdateClassGroupCardResponse
     */
    public function updateClassGroupCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCardId)) {
            $body['bizCardId'] = $request->bizCardId;
        }
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->groupTypeList)) {
            $body['groupTypeList'] = $request->groupTypeList;
        }
        if (!Utils::isUnset($request->isFinalUpdate)) {
            $body['isFinalUpdate'] = $request->isFinalUpdate;
        }
        if (!Utils::isUnset($request->privateCardData)) {
            $body['privateCardData'] = $request->privateCardData;
        }
        if (!Utils::isUnset($request->publicCardData)) {
            $body['publicCardData'] = $request->publicCardData;
        }
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
            'action' => 'UpdateClassGroupCard',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/classes/groups/cards/messages',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateClassGroupCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新班级群卡片消息
     *  *
     * @param UpdateClassGroupCardRequest $request UpdateClassGroupCardRequest
     *
     * @return UpdateClassGroupCardResponse UpdateClassGroupCardResponse
     */
    public function updateClassGroupCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateClassGroupCardHeaders([]);

        return $this->updateClassGroupCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 高校校友会更新校友信息
     *  *
     * @param UpdateCollegeAlumniUserInfoRequest $request UpdateCollegeAlumniUserInfoRequest
     * @param UpdateCollegeAlumniUserInfoHeaders $headers UpdateCollegeAlumniUserInfoHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateCollegeAlumniUserInfoResponse UpdateCollegeAlumniUserInfoResponse
     */
    public function updateCollegeAlumniUserInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->address)) {
            $body['address'] = $request->address;
        }
        if (!Utils::isUnset($request->deptIds)) {
            $body['deptIds'] = $request->deptIds;
        }
        if (!Utils::isUnset($request->email)) {
            $body['email'] = $request->email;
        }
        if (!Utils::isUnset($request->intake)) {
            $body['intake'] = $request->intake;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->outtake)) {
            $body['outtake'] = $request->outtake;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateCollegeAlumniUserInfo',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeAlumni/userInfos',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateCollegeAlumniUserInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 高校校友会更新校友信息
     *  *
     * @param UpdateCollegeAlumniUserInfoRequest $request UpdateCollegeAlumniUserInfoRequest
     *
     * @return UpdateCollegeAlumniUserInfoResponse UpdateCollegeAlumniUserInfoResponse
     */
    public function updateCollegeAlumniUserInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCollegeAlumniUserInfoHeaders([]);

        return $this->updateCollegeAlumniUserInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新高校通讯录组织单元
     *  *
     * @param UpdateCollegeContactDeptRequest $request UpdateCollegeContactDeptRequest
     * @param UpdateCollegeContactDeptHeaders $headers UpdateCollegeContactDeptHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateCollegeContactDeptResponse UpdateCollegeContactDeptResponse
     */
    public function updateCollegeContactDeptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->autoAddUser)) {
            $body['autoAddUser'] = $request->autoAddUser;
        }
        if (!Utils::isUnset($request->autoApproveApply)) {
            $body['autoApproveApply'] = $request->autoApproveApply;
        }
        if (!Utils::isUnset($request->brief)) {
            $body['brief'] = $request->brief;
        }
        if (!Utils::isUnset($request->code)) {
            $body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->createDeptGroup)) {
            $body['createDeptGroup'] = $request->createDeptGroup;
        }
        if (!Utils::isUnset($request->deptCode)) {
            $body['deptCode'] = $request->deptCode;
        }
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->deptManagerUseridList)) {
            $body['deptManagerUseridList'] = $request->deptManagerUseridList;
        }
        if (!Utils::isUnset($request->deptPermits)) {
            $body['deptPermits'] = $request->deptPermits;
        }
        if (!Utils::isUnset($request->deptType)) {
            $body['deptType'] = $request->deptType;
        }
        if (!Utils::isUnset($request->empApplyJoinDept)) {
            $body['empApplyJoinDept'] = $request->empApplyJoinDept;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->forceUpdateFields)) {
            $body['forceUpdateFields'] = $request->forceUpdateFields;
        }
        if (!Utils::isUnset($request->groupContainHiddenDept)) {
            $body['groupContainHiddenDept'] = $request->groupContainHiddenDept;
        }
        if (!Utils::isUnset($request->groupContainOuterDept)) {
            $body['groupContainOuterDept'] = $request->groupContainOuterDept;
        }
        if (!Utils::isUnset($request->groupContainSubDept)) {
            $body['groupContainSubDept'] = $request->groupContainSubDept;
        }
        if (!Utils::isUnset($request->hideDept)) {
            $body['hideDept'] = $request->hideDept;
        }
        if (!Utils::isUnset($request->hideSceneConfig)) {
            $body['hideSceneConfig'] = $request->hideSceneConfig;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->order)) {
            $body['order'] = $request->order;
        }
        if (!Utils::isUnset($request->orgDeptOwner)) {
            $body['orgDeptOwner'] = $request->orgDeptOwner;
        }
        if (!Utils::isUnset($request->outerDept)) {
            $body['outerDept'] = $request->outerDept;
        }
        if (!Utils::isUnset($request->outerDeptOnlySelf)) {
            $body['outerDeptOnlySelf'] = $request->outerDeptOnlySelf;
        }
        if (!Utils::isUnset($request->outerPermitDepts)) {
            $body['outerPermitDepts'] = $request->outerPermitDepts;
        }
        if (!Utils::isUnset($request->outerPermitUsers)) {
            $body['outerPermitUsers'] = $request->outerPermitUsers;
        }
        if (!Utils::isUnset($request->outerSceneConfig)) {
            $body['outerSceneConfig'] = $request->outerSceneConfig;
        }
        if (!Utils::isUnset($request->parentId)) {
            $body['parentId'] = $request->parentId;
        }
        if (!Utils::isUnset($request->sourceIdentifier)) {
            $body['sourceIdentifier'] = $request->sourceIdentifier;
        }
        if (!Utils::isUnset($request->telephone)) {
            $body['telephone'] = $request->telephone;
        }
        if (!Utils::isUnset($request->userPermits)) {
            $body['userPermits'] = $request->userPermits;
        }
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
            'action' => 'UpdateCollegeContactDept',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/depts',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateCollegeContactDeptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新高校通讯录组织单元
     *  *
     * @param UpdateCollegeContactDeptRequest $request UpdateCollegeContactDeptRequest
     *
     * @return UpdateCollegeContactDeptResponse UpdateCollegeContactDeptResponse
     */
    public function updateCollegeContactDept($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCollegeContactDeptHeaders([]);

        return $this->updateCollegeContactDeptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新高校账号用户
     *  *
     * @param UpdateCollegeContactExclusiveRequest $request UpdateCollegeContactExclusiveRequest
     * @param UpdateCollegeContactExclusiveHeaders $headers UpdateCollegeContactExclusiveHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateCollegeContactExclusiveResponse UpdateCollegeContactExclusiveResponse
     */
    public function updateCollegeContactExclusiveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->avatarMediaId)) {
            $body['avatarMediaId'] = $request->avatarMediaId;
        }
        if (!Utils::isUnset($request->deptIdList)) {
            $body['deptIdList'] = $request->deptIdList;
        }
        if (!Utils::isUnset($request->deptOrderList)) {
            $body['deptOrderList'] = $request->deptOrderList;
        }
        if (!Utils::isUnset($request->deptPositionSet)) {
            $body['deptPositionSet'] = $request->deptPositionSet;
        }
        if (!Utils::isUnset($request->deptTitleList)) {
            $body['deptTitleList'] = $request->deptTitleList;
        }
        if (!Utils::isUnset($request->email)) {
            $body['email'] = $request->email;
        }
        if (!Utils::isUnset($request->empType)) {
            $body['empType'] = $request->empType;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->forceUpdateFields)) {
            $body['forceUpdateFields'] = $request->forceUpdateFields;
        }
        if (!Utils::isUnset($request->hideMobile)) {
            $body['hideMobile'] = $request->hideMobile;
        }
        if (!Utils::isUnset($request->hiredDate)) {
            $body['hiredDate'] = $request->hiredDate;
        }
        if (!Utils::isUnset($request->jobNumber)) {
            $body['jobNumber'] = $request->jobNumber;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->loginIdType)) {
            $body['loginIdType'] = $request->loginIdType;
        }
        if (!Utils::isUnset($request->mainDeptId)) {
            $body['mainDeptId'] = $request->mainDeptId;
        }
        if (!Utils::isUnset($request->managerUserid)) {
            $body['managerUserid'] = $request->managerUserid;
        }
        if (!Utils::isUnset($request->mobile)) {
            $body['mobile'] = $request->mobile;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->nickname)) {
            $body['nickname'] = $request->nickname;
        }
        if (!Utils::isUnset($request->orgEmail)) {
            $body['orgEmail'] = $request->orgEmail;
        }
        if (!Utils::isUnset($request->orgEmailType)) {
            $body['orgEmailType'] = $request->orgEmailType;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->seniorMode)) {
            $body['seniorMode'] = $request->seniorMode;
        }
        if (!Utils::isUnset($request->telephone)) {
            $body['telephone'] = $request->telephone;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->userid)) {
            $body['userid'] = $request->userid;
        }
        if (!Utils::isUnset($request->workPlace)) {
            $body['workPlace'] = $request->workPlace;
        }
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
            'action' => 'UpdateCollegeContactExclusive',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/exclusiveAccounts/users',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateCollegeContactExclusiveResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新高校账号用户
     *  *
     * @param UpdateCollegeContactExclusiveRequest $request UpdateCollegeContactExclusiveRequest
     *
     * @return UpdateCollegeContactExclusiveResponse UpdateCollegeContactExclusiveResponse
     */
    public function updateCollegeContactExclusive($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCollegeContactExclusiveHeaders([]);

        return $this->updateCollegeContactExclusiveWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新高校通讯录场景架构
     *  *
     * @param UpdateCollegeContactSceneStruRequest $request UpdateCollegeContactSceneStruRequest
     * @param UpdateCollegeContactSceneStruHeaders $headers UpdateCollegeContactSceneStruHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateCollegeContactSceneStruResponse UpdateCollegeContactSceneStruResponse
     */
    public function updateCollegeContactSceneStruWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->order)) {
            $body['order'] = $request->order;
        }
        if (!Utils::isUnset($request->sourceIdentifier)) {
            $body['sourceIdentifier'] = $request->sourceIdentifier;
        }
        if (!Utils::isUnset($request->struBrief)) {
            $body['struBrief'] = $request->struBrief;
        }
        if (!Utils::isUnset($request->struId)) {
            $body['struId'] = $request->struId;
        }
        if (!Utils::isUnset($request->struName)) {
            $body['struName'] = $request->struName;
        }
        if (!Utils::isUnset($request->struType)) {
            $body['struType'] = $request->struType;
        }
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
            'action' => 'UpdateCollegeContactSceneStru',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/depts/structures/scenes',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateCollegeContactSceneStruResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新高校通讯录场景架构
     *  *
     * @param UpdateCollegeContactSceneStruRequest $request UpdateCollegeContactSceneStruRequest
     *
     * @return UpdateCollegeContactSceneStruResponse UpdateCollegeContactSceneStruResponse
     */
    public function updateCollegeContactSceneStru($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCollegeContactSceneStruHeaders([]);

        return $this->updateCollegeContactSceneStruWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新个人账号用户
     *  *
     * @param UpdateCollegeContactUserRequest $request UpdateCollegeContactUserRequest
     * @param UpdateCollegeContactUserHeaders $headers UpdateCollegeContactUserHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateCollegeContactUserResponse UpdateCollegeContactUserResponse
     */
    public function updateCollegeContactUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptIdList)) {
            $body['deptIdList'] = $request->deptIdList;
        }
        if (!Utils::isUnset($request->deptOrderList)) {
            $body['deptOrderList'] = $request->deptOrderList;
        }
        if (!Utils::isUnset($request->deptPositionSet)) {
            $body['deptPositionSet'] = $request->deptPositionSet;
        }
        if (!Utils::isUnset($request->deptTitleList)) {
            $body['deptTitleList'] = $request->deptTitleList;
        }
        if (!Utils::isUnset($request->email)) {
            $body['email'] = $request->email;
        }
        if (!Utils::isUnset($request->empType)) {
            $body['empType'] = $request->empType;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->forceUpdateFields)) {
            $body['forceUpdateFields'] = $request->forceUpdateFields;
        }
        if (!Utils::isUnset($request->hideMobile)) {
            $body['hideMobile'] = $request->hideMobile;
        }
        if (!Utils::isUnset($request->hiredDate)) {
            $body['hiredDate'] = $request->hiredDate;
        }
        if (!Utils::isUnset($request->jobNumber)) {
            $body['jobNumber'] = $request->jobNumber;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->mainDeptId)) {
            $body['mainDeptId'] = $request->mainDeptId;
        }
        if (!Utils::isUnset($request->managerUserid)) {
            $body['managerUserid'] = $request->managerUserid;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->orgEmail)) {
            $body['orgEmail'] = $request->orgEmail;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->seniorMode)) {
            $body['seniorMode'] = $request->seniorMode;
        }
        if (!Utils::isUnset($request->telephone)) {
            $body['telephone'] = $request->telephone;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->userid)) {
            $body['userid'] = $request->userid;
        }
        if (!Utils::isUnset($request->workPlace)) {
            $body['workPlace'] = $request->workPlace;
        }
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
            'action' => 'UpdateCollegeContactUser',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/personalAccounts/users',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateCollegeContactUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新个人账号用户
     *  *
     * @param UpdateCollegeContactUserRequest $request UpdateCollegeContactUserRequest
     *
     * @return UpdateCollegeContactUserResponse UpdateCollegeContactUserResponse
     */
    public function updateCollegeContactUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCollegeContactUserHeaders([]);

        return $this->updateCollegeContactUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改用户成员类型
     *  *
     * @param UpdateCollegeUserEmpTypeRequest $request UpdateCollegeUserEmpTypeRequest
     * @param UpdateCollegeUserEmpTypeHeaders $headers UpdateCollegeUserEmpTypeHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateCollegeUserEmpTypeResponse UpdateCollegeUserEmpTypeResponse
     */
    public function updateCollegeUserEmpTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->empType)) {
            $body['empType'] = $request->empType;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateCollegeUserEmpType',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/collegeContact/empTypes/change',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateCollegeUserEmpTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改用户成员类型
     *  *
     * @param UpdateCollegeUserEmpTypeRequest $request UpdateCollegeUserEmpTypeRequest
     *
     * @return UpdateCollegeUserEmpTypeResponse UpdateCollegeUserEmpTypeResponse
     */
    public function updateCollegeUserEmpType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCollegeUserEmpTypeHeaders([]);

        return $this->updateCollegeUserEmpTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新班级课程表（调代课等微调场景）
     *  *
     * @param string                      $classId
     * @param UpdateCoursesOfClassRequest $request UpdateCoursesOfClassRequest
     * @param UpdateCoursesOfClassHeaders $headers UpdateCoursesOfClassHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateCoursesOfClassResponse UpdateCoursesOfClassResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateCoursesOfClass',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/classes/' . $classId . '/courses/schedules',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateCoursesOfClassResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新班级课程表（调代课等微调场景）
     *  *
     * @param string                      $classId
     * @param UpdateCoursesOfClassRequest $request UpdateCoursesOfClassRequest
     *
     * @return UpdateCoursesOfClassResponse UpdateCoursesOfClassResponse
     */
    public function updateCoursesOfClass($classId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCoursesOfClassHeaders([]);

        return $this->updateCoursesOfClassWithOptions($classId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新评价表现未读数量
     *  *
     * @param UpdateEvaluatePerformanceCountRequest $request UpdateEvaluatePerformanceCountRequest
     * @param UpdateEvaluatePerformanceCountHeaders $headers UpdateEvaluatePerformanceCountHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateEvaluatePerformanceCountResponse UpdateEvaluatePerformanceCountResponse
     */
    public function updateEvaluatePerformanceCountWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->teacherId)) {
            $body['teacherId'] = $request->teacherId;
        }
        if (!Utils::isUnset($request->unreadData)) {
            $body['unreadData'] = $request->unreadData;
        }
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
            'action' => 'UpdateEvaluatePerformanceCount',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/evaluations/unreadCounts',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateEvaluatePerformanceCountResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新评价表现未读数量
     *  *
     * @param UpdateEvaluatePerformanceCountRequest $request UpdateEvaluatePerformanceCountRequest
     *
     * @return UpdateEvaluatePerformanceCountResponse UpdateEvaluatePerformanceCountResponse
     */
    public function updateEvaluatePerformanceCount($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateEvaluatePerformanceCountHeaders([]);

        return $this->updateEvaluatePerformanceCountWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新家长信息
     *  *
     * @param UpdateGuardianRequest $request UpdateGuardianRequest
     * @param UpdateGuardianHeaders $headers UpdateGuardianHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateGuardianResponse UpdateGuardianResponse
     */
    public function updateGuardianWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->relation)) {
            $body['relation'] = $request->relation;
        }
        if (!Utils::isUnset($request->stuId)) {
            $body['stuId'] = $request->stuId;
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
            'action' => 'UpdateGuardian',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/guardians/infos',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateGuardianResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新家长信息
     *  *
     * @param UpdateGuardianRequest $request UpdateGuardianRequest
     *
     * @return UpdateGuardianResponse UpdateGuardianResponse
     */
    public function updateGuardian($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGuardianHeaders([]);

        return $this->updateGuardianWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加物理教室信息
     *  *
     * @param UpdatePhysicalClassroomRequest $request UpdatePhysicalClassroomRequest
     * @param UpdatePhysicalClassroomHeaders $headers UpdatePhysicalClassroomHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdatePhysicalClassroomResponse UpdatePhysicalClassroomResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdatePhysicalClassroom',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/physicalClassrooms',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdatePhysicalClassroomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加物理教室信息
     *  *
     * @param UpdatePhysicalClassroomRequest $request UpdatePhysicalClassroomRequest
     *
     * @return UpdatePhysicalClassroomResponse UpdatePhysicalClassroomResponse
     */
    public function updatePhysicalClassroom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdatePhysicalClassroomHeaders([]);

        return $this->updatePhysicalClassroomWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新专递课堂课程
     *  *
     * @param UpdateRemoteClassCourseRequest $request UpdateRemoteClassCourseRequest
     * @param UpdateRemoteClassCourseHeaders $headers UpdateRemoteClassCourseHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateRemoteClassCourseResponse UpdateRemoteClassCourseResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateRemoteClassCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/remoteClasses/courses',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateRemoteClassCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新专递课堂课程
     *  *
     * @param UpdateRemoteClassCourseRequest $request UpdateRemoteClassCourseRequest
     *
     * @return UpdateRemoteClassCourseResponse UpdateRemoteClassCourseResponse
     */
    public function updateRemoteClassCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRemoteClassCourseHeaders([]);

        return $this->updateRemoteClassCourseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新设备名称
     *  *
     * @param UpdateRemoteClassDeviceRequest $request UpdateRemoteClassDeviceRequest
     * @param UpdateRemoteClassDeviceHeaders $headers UpdateRemoteClassDeviceHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateRemoteClassDeviceResponse UpdateRemoteClassDeviceResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'UpdateRemoteClassDevice',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/remoteClasses/deviceNames',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateRemoteClassDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新设备名称
     *  *
     * @param UpdateRemoteClassDeviceRequest $request UpdateRemoteClassDeviceRequest
     *
     * @return UpdateRemoteClassDeviceResponse UpdateRemoteClassDeviceResponse
     */
    public function updateRemoteClassDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRemoteClassDeviceHeaders([]);

        return $this->updateRemoteClassDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改学生信息
     *  *
     * @param UpdateStudentRequest $request UpdateStudentRequest
     * @param UpdateStudentHeaders $headers UpdateStudentHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateStudentResponse UpdateStudentResponse
     */
    public function updateStudentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->studentNo)) {
            $body['studentNo'] = $request->studentNo;
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
            'action' => 'UpdateStudent',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/students/infos',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateStudentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改学生信息
     *  *
     * @param UpdateStudentRequest $request UpdateStudentRequest
     *
     * @return UpdateStudentResponse UpdateStudentResponse
     */
    public function updateStudent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateStudentHeaders([]);

        return $this->updateStudentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新大学课程组
     *  *
     * @param UpdateUniversityCourseGroupRequest $request UpdateUniversityCourseGroupRequest
     * @param UpdateUniversityCourseGroupHeaders $headers UpdateUniversityCourseGroupHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateUniversityCourseGroupResponse UpdateUniversityCourseGroupResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateUniversityCourseGroup',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/universities/courseGroups',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateUniversityCourseGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新大学课程组
     *  *
     * @param UpdateUniversityCourseGroupRequest $request UpdateUniversityCourseGroupRequest
     *
     * @return UpdateUniversityCourseGroupResponse UpdateUniversityCourseGroupResponse
     */
    public function updateUniversityCourseGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateUniversityCourseGroupHeaders([]);

        return $this->updateUniversityCourseGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 上传学情图片回调
     *  *
     * @param UploadLearningDataCallbackRequest $request UploadLearningDataCallbackRequest
     * @param UploadLearningDataCallbackHeaders $headers UploadLearningDataCallbackHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return UploadLearningDataCallbackResponse UploadLearningDataCallbackResponse
     */
    public function uploadLearningDataCallbackWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->deptId)) {
            $body['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->generatedTime)) {
            $body['generatedTime'] = $request->generatedTime;
        }
        if (!Utils::isUnset($request->studentUserId)) {
            $body['studentUserId'] = $request->studentUserId;
        }
        if (!Utils::isUnset($request->subjectCode)) {
            $body['subjectCode'] = $request->subjectCode;
        }
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
            'action' => 'UploadLearningDataCallback',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/uploadLearnings/datas/callback',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UploadLearningDataCallbackResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 上传学情图片回调
     *  *
     * @param UploadLearningDataCallbackRequest $request UploadLearningDataCallbackRequest
     *
     * @return UploadLearningDataCallbackResponse UploadLearningDataCallbackResponse
     */
    public function uploadLearningDataCallback($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UploadLearningDataCallbackHeaders([]);

        return $this->uploadLearningDataCallbackWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 视讯PAAS接口代理
     *  *
     * @param VPaasProxyRequest $request VPaasProxyRequest
     * @param VPaasProxyHeaders $headers VPaasProxyHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return VPaasProxyResponse VPaasProxyResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'VPaasProxy',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/vpaas/proxy',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return VPaasProxyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 视讯PAAS接口代理
     *  *
     * @param VPaasProxyRequest $request VPaasProxyRequest
     *
     * @return VPaasProxyResponse VPaasProxyResponse
     */
    public function vPaasProxy($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new VPaasProxyHeaders([]);

        return $this->vPaasProxyWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 校验开学季任务是否完成
     *  *
     * @param ValidateNewGradeManagerRequest $request ValidateNewGradeManagerRequest
     * @param ValidateNewGradeManagerHeaders $headers ValidateNewGradeManagerHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return ValidateNewGradeManagerResponse ValidateNewGradeManagerResponse
     */
    public function validateNewGradeManagerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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
            'action' => 'ValidateNewGradeManager',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/newGrades/tasks/validate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ValidateNewGradeManagerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 校验开学季任务是否完成
     *  *
     * @param ValidateNewGradeManagerRequest $request ValidateNewGradeManagerRequest
     *
     * @return ValidateNewGradeManagerResponse ValidateNewGradeManagerResponse
     */
    public function validateNewGradeManager($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateNewGradeManagerHeaders([]);

        return $this->validateNewGradeManagerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 校验用户的教育角色
     *  *
     * @param ValidateUserRoleRequest $request ValidateUserRoleRequest
     * @param ValidateUserRoleHeaders $headers ValidateUserRoleHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return ValidateUserRoleResponse ValidateUserRoleResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ValidateUserRole',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/users/roles/validate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ValidateUserRoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 校验用户的教育角色
     *  *
     * @param ValidateUserRoleRequest $request ValidateUserRoleRequest
     *
     * @return ValidateUserRoleResponse ValidateUserRoleResponse
     */
    public function validateUserRole($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateUserRoleHeaders([]);

        return $this->validateUserRoleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 校验教育组织
     *  *
     * @param VerifyEduOrgCertificationRequest $request VerifyEduOrgCertificationRequest
     * @param VerifyEduOrgCertificationHeaders $headers VerifyEduOrgCertificationHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return VerifyEduOrgCertificationResponse VerifyEduOrgCertificationResponse
     */
    public function verifyEduOrgCertificationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
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
            'action' => 'VerifyEduOrgCertification',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/orgs/certifications/verify',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return VerifyEduOrgCertificationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 校验教育组织
     *  *
     * @param VerifyEduOrgCertificationRequest $request VerifyEduOrgCertificationRequest
     *
     * @return VerifyEduOrgCertificationResponse VerifyEduOrgCertificationResponse
     */
    public function verifyEduOrgCertification($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new VerifyEduOrgCertificationHeaders([]);

        return $this->verifyEduOrgCertificationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 校验教育用户特殊身份权限
     *  *
     * @param VerifyEduUserCertificationRequest $request VerifyEduUserCertificationRequest
     * @param VerifyEduUserCertificationHeaders $headers VerifyEduUserCertificationHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return VerifyEduUserCertificationResponse VerifyEduUserCertificationResponse
     */
    public function verifyEduUserCertificationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $body['targetCorpId'] = $request->targetCorpId;
        }
        if (!Utils::isUnset($request->targetUserId)) {
            $body['targetUserId'] = $request->targetUserId;
        }
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
            'action' => 'VerifyEduUserCertification',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/users/certifications/verify',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return VerifyEduUserCertificationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 校验教育用户特殊身份权限
     *  *
     * @param VerifyEduUserCertificationRequest $request VerifyEduUserCertificationRequest
     *
     * @return VerifyEduUserCertificationResponse VerifyEduUserCertificationResponse
     */
    public function verifyEduUserCertification($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new VerifyEduUserCertificationHeaders([]);

        return $this->verifyEduUserCertificationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询班级课程
     *  *
     * @param QueryClassCourseRequest $request QueryClassCourseRequest
     * @param QueryClassCourseHeaders $headers QueryClassCourseHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryClassCourseResponse QueryClassCourseResponse
     */
    public function queryClassCourseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->classId)) {
            $body['classId'] = $request->classId;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->isvCode)) {
            $body['isvCode'] = $request->isvCode;
        }
        if (!Utils::isUnset($request->isvCourseId)) {
            $body['isvCourseId'] = $request->isvCourseId;
        }
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
            'action' => 'queryClassCourse',
            'version' => 'edu_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/edu/kits/classes/courses/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryClassCourseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询班级课程
     *  *
     * @param QueryClassCourseRequest $request QueryClassCourseRequest
     *
     * @return QueryClassCourseResponse QueryClassCourseResponse
     */
    public function queryClassCourse($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryClassCourseHeaders([]);

        return $this->queryClassCourseWithOptions($request, $headers, $runtime);
    }
}
