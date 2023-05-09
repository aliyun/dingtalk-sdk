<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetAbnormalOperationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetAbnormalOperationRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetAbnormalOperationResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetAdministrativeLicensingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetAdministrativeLicensingRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetAdministrativeLicensingResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetAdministrativePenaltiesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetAdministrativePenaltiesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetAdministrativePenaltiesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetBasicInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetBasicInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetBasicInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetBiddingInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetBiddingInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetBiddingInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetBranchInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetBranchInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetBranchInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetChangeRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetChangeRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetChangeRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetDomainInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetDomainInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetDomainInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetDoubleRandomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetDoubleRandomRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetDoubleRandomResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetEnvironmentalPenaltiesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetEnvironmentalPenaltiesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetEnvironmentalPenaltiesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetHolderInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetHolderInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetHolderInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetIntellectualPropertyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetIntellectualPropertyRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetIntellectualPropertyResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetInvestmentAbroadHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetInvestmentAbroadRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetInvestmentAbroadResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetJobInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetJobInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetJobInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetPatentInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetPatentInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetPatentInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetPrincipalEmployeeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetPrincipalEmployeeRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetPrincipalEmployeeResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetQeneralTaxpayerInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetQeneralTaxpayerInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetQeneralTaxpayerInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetQualificationCertHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetQualificationCertRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetQualificationCertResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetSeriousViolationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetSeriousViolationRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetSeriousViolationResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetSoftwareCopyrightHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetSoftwareCopyrightRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetSoftwareCopyrightResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetTrademarkInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetTrademarkInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetTrademarkInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetWorkCopyrightHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetWorkCopyrightRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetWorkCopyrightResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\PostCorpAuthInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\PostCorpAuthInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryActiveUserStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryActiveUserStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryActiveUserStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryAnhmdStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryAnhmdStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryAnhmdStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryApprovalStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryApprovalStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryApprovalStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryAttendanceStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryAttendanceStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryAttendanceStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryBlackboardStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryBlackboardStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryBlackboardStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCalendarStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCalendarStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCalendarStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCheckinStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCheckinStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCheckinStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCircleStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCircleStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCircleStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCompanyBasicInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCompanyBasicInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryCompanyBasicInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDigitalDistrictOrgInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDigitalDistrictOrgInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDigitalDistrictOrgInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDingReciveStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDingReciveStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDingReciveStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDingSendStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDingSendStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDingSendStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDocumentStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDocumentStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDocumentStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDriveStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDriveStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDriveStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryEmployeeTypeStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryEmployeeTypeStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryEmployeeTypeStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGeneralDataServiceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGeneralDataServiceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGeneralDataServiceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGroupLiveStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGroupLiveStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGroupLiveStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGroupMessageStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGroupMessageStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGroupMessageStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryHealthStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryHealthStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryHealthStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryMailStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryMailStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryMailStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialDatasetFieldsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialDatasetFieldsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialDatasetFieldsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialDatasetListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialDatasetListRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialDatasetListResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialFormDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialFormDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialFormDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOnlineUserStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOnlineUserStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOnlineUserStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryRedEnvelopeReciveStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryRedEnvelopeReciveStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryRedEnvelopeReciveStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryRedEnvelopeSendStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryRedEnvelopeSendStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryRedEnvelopeSendStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryReportStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryReportStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryReportStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QuerySingleMessageStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QuerySingleMessageStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QuerySingleMessageStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTelMeetingStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTelMeetingStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTelMeetingStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTodoStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTodoStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTodoStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryVedioMeetingStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryVedioMeetingStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryVedioMeetingStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydActiveDayStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydActiveDayStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydActiveDayStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydActiveMonthStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydActiveMonthStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydActiveMonthStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydActiveWeekStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydActiveWeekStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydActiveWeekStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydAppDayStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydAppDayStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydAppDayStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydAppMonthStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydAppMonthStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydAppMonthStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydAppStdStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydAppStdStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydAppStdStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydAppWeekStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydAppWeekStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydAppWeekStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydCalendarDayStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydCalendarDayStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydCalendarDayStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydCalendarMonthStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydCalendarMonthStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydCalendarMonthStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydCalendarWeekStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydCalendarWeekStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydCalendarWeekStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydDingMsgDayStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydDingMsgDayStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydDingMsgDayStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydDingMsgMonthStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydDingMsgMonthStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydDingMsgMonthStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydDingMsgWeekStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydDingMsgWeekStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydDingMsgWeekStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydGroupMsgDayStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydGroupMsgDayStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydGroupMsgDayStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydGroupMsgMonthStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydGroupMsgMonthStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydGroupMsgMonthStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydGroupMsgWeekStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydGroupMsgWeekStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydGroupMsgWeekStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydLogDayStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydLogDayStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydLogDayStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydLogMonthStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydLogMonthStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydLogMonthStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydLogWeekStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydLogWeekStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydLogWeekStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydMeetingDayStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydMeetingDayStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydMeetingDayStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydMeetingMonthStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydMeetingMonthStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydMeetingMonthStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydMeetingWeekStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydMeetingWeekStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydMeetingWeekStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydNoticeDayStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydNoticeDayStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydNoticeDayStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydNoticeMonthStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydNoticeMonthStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydNoticeMonthStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydNoticeWeekStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydNoticeWeekStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydNoticeWeekStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydSingleMsgDayStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydSingleMsgDayStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydSingleMsgDayStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydSingleMsgMonthStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydSingleMsgMonthStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydSingleMsgMonthStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydSingleMsgWeekStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydSingleMsgWeekStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydSingleMsgWeekStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydToatlMsgDayStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydToatlMsgDayStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydToatlMsgDayStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydToatlMsgMonthStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydToatlMsgMonthStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydToatlMsgMonthStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydToatlMsgWeekStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydToatlMsgWeekStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydToatlMsgWeekStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTodoDayStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTodoDayStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTodoDayStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTodoMonthStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTodoMonthStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTodoMonthStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTodoWeekStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTodoWeekStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTodoWeekStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTotalDayStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTotalDayStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTotalDayStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTotalMonthStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTotalMonthStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTotalMonthStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTotalStdStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTotalStdStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTotalStdStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTotalWeekStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTotalWeekStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTotalWeekStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\SearchCompanyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\SearchCompanyRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\SearchCompanyResponse;
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
     * @param GetAbnormalOperationRequest $request
     * @param GetAbnormalOperationHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetAbnormalOperationResponse
     */
    public function getAbnormalOperationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetAbnormalOperation',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/abnormalOperations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAbnormalOperationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetAbnormalOperationRequest $request
     *
     * @return GetAbnormalOperationResponse
     */
    public function getAbnormalOperation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAbnormalOperationHeaders([]);

        return $this->getAbnormalOperationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetAdministrativeLicensingRequest $request
     * @param GetAdministrativeLicensingHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return GetAdministrativeLicensingResponse
     */
    public function getAdministrativeLicensingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetAdministrativeLicensing',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/administrativeLicenses',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAdministrativeLicensingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetAdministrativeLicensingRequest $request
     *
     * @return GetAdministrativeLicensingResponse
     */
    public function getAdministrativeLicensing($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAdministrativeLicensingHeaders([]);

        return $this->getAdministrativeLicensingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetAdministrativePenaltiesRequest $request
     * @param GetAdministrativePenaltiesHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return GetAdministrativePenaltiesResponse
     */
    public function getAdministrativePenaltiesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetAdministrativePenalties',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/administrativePenalties',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAdministrativePenaltiesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetAdministrativePenaltiesRequest $request
     *
     * @return GetAdministrativePenaltiesResponse
     */
    public function getAdministrativePenalties($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAdministrativePenaltiesHeaders([]);

        return $this->getAdministrativePenaltiesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetBasicInfoRequest $request
     * @param GetBasicInfoHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetBasicInfoResponse
     */
    public function getBasicInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetBasicInfo',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/businessBasicInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetBasicInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetBasicInfoRequest $request
     *
     * @return GetBasicInfoResponse
     */
    public function getBasicInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetBasicInfoHeaders([]);

        return $this->getBasicInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetBiddingInfoRequest $request
     * @param GetBiddingInfoHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetBiddingInfoResponse
     */
    public function getBiddingInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetBiddingInfo',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/biddingInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetBiddingInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetBiddingInfoRequest $request
     *
     * @return GetBiddingInfoResponse
     */
    public function getBiddingInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetBiddingInfoHeaders([]);

        return $this->getBiddingInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetBranchInfoRequest $request
     * @param GetBranchInfoHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetBranchInfoResponse
     */
    public function getBranchInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetBranchInfo',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/branchInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetBranchInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetBranchInfoRequest $request
     *
     * @return GetBranchInfoResponse
     */
    public function getBranchInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetBranchInfoHeaders([]);

        return $this->getBranchInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetChangeRecordRequest $request
     * @param GetChangeRecordHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetChangeRecordResponse
     */
    public function getChangeRecordWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetChangeRecord',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/changeRecords',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetChangeRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetChangeRecordRequest $request
     *
     * @return GetChangeRecordResponse
     */
    public function getChangeRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetChangeRecordHeaders([]);

        return $this->getChangeRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetDomainInfoRequest $request
     * @param GetDomainInfoHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetDomainInfoResponse
     */
    public function getDomainInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetDomainInfo',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/domainInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDomainInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetDomainInfoRequest $request
     *
     * @return GetDomainInfoResponse
     */
    public function getDomainInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDomainInfoHeaders([]);

        return $this->getDomainInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetDoubleRandomRequest $request
     * @param GetDoubleRandomHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetDoubleRandomResponse
     */
    public function getDoubleRandomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetDoubleRandom',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/doubleRandomness',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDoubleRandomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetDoubleRandomRequest $request
     *
     * @return GetDoubleRandomResponse
     */
    public function getDoubleRandom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDoubleRandomHeaders([]);

        return $this->getDoubleRandomWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetEnvironmentalPenaltiesRequest $request
     * @param GetEnvironmentalPenaltiesHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return GetEnvironmentalPenaltiesResponse
     */
    public function getEnvironmentalPenaltiesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetEnvironmentalPenalties',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/environmentalPenalties',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetEnvironmentalPenaltiesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetEnvironmentalPenaltiesRequest $request
     *
     * @return GetEnvironmentalPenaltiesResponse
     */
    public function getEnvironmentalPenalties($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetEnvironmentalPenaltiesHeaders([]);

        return $this->getEnvironmentalPenaltiesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetHolderInfoRequest $request
     * @param GetHolderInfoHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetHolderInfoResponse
     */
    public function getHolderInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetHolderInfo',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/shareholderInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetHolderInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetHolderInfoRequest $request
     *
     * @return GetHolderInfoResponse
     */
    public function getHolderInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetHolderInfoHeaders([]);

        return $this->getHolderInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetIntellectualPropertyRequest $request
     * @param GetIntellectualPropertyHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return GetIntellectualPropertyResponse
     */
    public function getIntellectualPropertyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetIntellectualProperty',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/intellectualProperties',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetIntellectualPropertyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetIntellectualPropertyRequest $request
     *
     * @return GetIntellectualPropertyResponse
     */
    public function getIntellectualProperty($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetIntellectualPropertyHeaders([]);

        return $this->getIntellectualPropertyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetInvestmentAbroadRequest $request
     * @param GetInvestmentAbroadHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetInvestmentAbroadResponse
     */
    public function getInvestmentAbroadWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetInvestmentAbroad',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/abroadInvestments',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetInvestmentAbroadResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetInvestmentAbroadRequest $request
     *
     * @return GetInvestmentAbroadResponse
     */
    public function getInvestmentAbroad($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInvestmentAbroadHeaders([]);

        return $this->getInvestmentAbroadWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetJobInfoRequest $request
     * @param GetJobInfoHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return GetJobInfoResponse
     */
    public function getJobInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetJobInfo',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/jobInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetJobInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetJobInfoRequest $request
     *
     * @return GetJobInfoResponse
     */
    public function getJobInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetJobInfoHeaders([]);

        return $this->getJobInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetPatentInfoRequest $request
     * @param GetPatentInfoHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetPatentInfoResponse
     */
    public function getPatentInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetPatentInfo',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/patentInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetPatentInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetPatentInfoRequest $request
     *
     * @return GetPatentInfoResponse
     */
    public function getPatentInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPatentInfoHeaders([]);

        return $this->getPatentInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetPrincipalEmployeeRequest $request
     * @param GetPrincipalEmployeeHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetPrincipalEmployeeResponse
     */
    public function getPrincipalEmployeeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetPrincipalEmployee',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/principalEmployees',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetPrincipalEmployeeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetPrincipalEmployeeRequest $request
     *
     * @return GetPrincipalEmployeeResponse
     */
    public function getPrincipalEmployee($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPrincipalEmployeeHeaders([]);

        return $this->getPrincipalEmployeeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetQeneralTaxpayerInfoRequest $request
     * @param GetQeneralTaxpayerInfoHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetQeneralTaxpayerInfoResponse
     */
    public function getQeneralTaxpayerInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetQeneralTaxpayerInfo',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/generalTaxpayerInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetQeneralTaxpayerInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetQeneralTaxpayerInfoRequest $request
     *
     * @return GetQeneralTaxpayerInfoResponse
     */
    public function getQeneralTaxpayerInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetQeneralTaxpayerInfoHeaders([]);

        return $this->getQeneralTaxpayerInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetQualificationCertRequest $request
     * @param GetQualificationCertHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetQualificationCertResponse
     */
    public function getQualificationCertWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetQualificationCert',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/qualificationCerts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetQualificationCertResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetQualificationCertRequest $request
     *
     * @return GetQualificationCertResponse
     */
    public function getQualificationCert($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetQualificationCertHeaders([]);

        return $this->getQualificationCertWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSeriousViolationRequest $request
     * @param GetSeriousViolationHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetSeriousViolationResponse
     */
    public function getSeriousViolationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetSeriousViolation',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/seriousViolations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSeriousViolationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetSeriousViolationRequest $request
     *
     * @return GetSeriousViolationResponse
     */
    public function getSeriousViolation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSeriousViolationHeaders([]);

        return $this->getSeriousViolationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSoftwareCopyrightRequest $request
     * @param GetSoftwareCopyrightHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetSoftwareCopyrightResponse
     */
    public function getSoftwareCopyrightWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetSoftwareCopyright',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/softwareCopyrights',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSoftwareCopyrightResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetSoftwareCopyrightRequest $request
     *
     * @return GetSoftwareCopyrightResponse
     */
    public function getSoftwareCopyright($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSoftwareCopyrightHeaders([]);

        return $this->getSoftwareCopyrightWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetTrademarkInfoRequest $request
     * @param GetTrademarkInfoHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetTrademarkInfoResponse
     */
    public function getTrademarkInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetTrademarkInfo',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/trademarkInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTrademarkInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetTrademarkInfoRequest $request
     *
     * @return GetTrademarkInfoResponse
     */
    public function getTrademarkInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTrademarkInfoHeaders([]);

        return $this->getTrademarkInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetWorkCopyrightRequest $request
     * @param GetWorkCopyrightHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetWorkCopyrightResponse
     */
    public function getWorkCopyrightWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'GetWorkCopyright',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/workCopyrights',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetWorkCopyrightResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetWorkCopyrightRequest $request
     *
     * @return GetWorkCopyrightResponse
     */
    public function getWorkCopyright($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetWorkCopyrightHeaders([]);

        return $this->getWorkCopyrightWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PostCorpAuthInfoHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return PostCorpAuthInfoResponse
     */
    public function postCorpAuthInfoWithOptions($headers, $runtime)
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
            'action'      => 'PostCorpAuthInfo',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/corporations/authorize',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PostCorpAuthInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return PostCorpAuthInfoResponse
     */
    public function postCorpAuthInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PostCorpAuthInfoHeaders([]);

        return $this->postCorpAuthInfoWithOptions($headers, $runtime);
    }

    /**
     * @param QueryActiveUserStatisticalDataRequest $request
     * @param QueryActiveUserStatisticalDataHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryActiveUserStatisticalDataResponse
     */
    public function queryActiveUserStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryActiveUserStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/activeUserData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryActiveUserStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryActiveUserStatisticalDataRequest $request
     *
     * @return QueryActiveUserStatisticalDataResponse
     */
    public function queryActiveUserStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryActiveUserStatisticalDataHeaders([]);

        return $this->queryActiveUserStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAnhmdStatisticalDataRequest $request
     * @param QueryAnhmdStatisticalDataHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryAnhmdStatisticalDataResponse
     */
    public function queryAnhmdStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryAnhmdStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/statisticDatas/anHmd',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAnhmdStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryAnhmdStatisticalDataRequest $request
     *
     * @return QueryAnhmdStatisticalDataResponse
     */
    public function queryAnhmdStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAnhmdStatisticalDataHeaders([]);

        return $this->queryAnhmdStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryApprovalStatisticalDataRequest $request
     * @param QueryApprovalStatisticalDataHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryApprovalStatisticalDataResponse
     */
    public function queryApprovalStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryApprovalStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/approvalData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryApprovalStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryApprovalStatisticalDataRequest $request
     *
     * @return QueryApprovalStatisticalDataResponse
     */
    public function queryApprovalStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryApprovalStatisticalDataHeaders([]);

        return $this->queryApprovalStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAttendanceStatisticalDataRequest $request
     * @param QueryAttendanceStatisticalDataHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryAttendanceStatisticalDataResponse
     */
    public function queryAttendanceStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryAttendanceStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/attendanceData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryAttendanceStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryAttendanceStatisticalDataRequest $request
     *
     * @return QueryAttendanceStatisticalDataResponse
     */
    public function queryAttendanceStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAttendanceStatisticalDataHeaders([]);

        return $this->queryAttendanceStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryBlackboardStatisticalDataRequest $request
     * @param QueryBlackboardStatisticalDataHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryBlackboardStatisticalDataResponse
     */
    public function queryBlackboardStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryBlackboardStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/blackboardData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryBlackboardStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryBlackboardStatisticalDataRequest $request
     *
     * @return QueryBlackboardStatisticalDataResponse
     */
    public function queryBlackboardStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBlackboardStatisticalDataHeaders([]);

        return $this->queryBlackboardStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCalendarStatisticalDataRequest $request
     * @param QueryCalendarStatisticalDataHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryCalendarStatisticalDataResponse
     */
    public function queryCalendarStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryCalendarStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/calendarData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryCalendarStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryCalendarStatisticalDataRequest $request
     *
     * @return QueryCalendarStatisticalDataResponse
     */
    public function queryCalendarStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCalendarStatisticalDataHeaders([]);

        return $this->queryCalendarStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCheckinStatisticalDataRequest $request
     * @param QueryCheckinStatisticalDataHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return QueryCheckinStatisticalDataResponse
     */
    public function queryCheckinStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryCheckinStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/checkinData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryCheckinStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryCheckinStatisticalDataRequest $request
     *
     * @return QueryCheckinStatisticalDataResponse
     */
    public function queryCheckinStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCheckinStatisticalDataHeaders([]);

        return $this->queryCheckinStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCircleStatisticalDataRequest $request
     * @param QueryCircleStatisticalDataHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return QueryCircleStatisticalDataResponse
     */
    public function queryCircleStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryCircleStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/circleData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryCircleStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryCircleStatisticalDataRequest $request
     *
     * @return QueryCircleStatisticalDataResponse
     */
    public function queryCircleStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCircleStatisticalDataHeaders([]);

        return $this->queryCircleStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCompanyBasicInfoRequest $request
     * @param QueryCompanyBasicInfoHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return QueryCompanyBasicInfoResponse
     */
    public function queryCompanyBasicInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->keyword)) {
            $query['keyword'] = $request->keyword;
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
            'action'      => 'QueryCompanyBasicInfo',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/companies/basicInfo',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryCompanyBasicInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryCompanyBasicInfoRequest $request
     *
     * @return QueryCompanyBasicInfoResponse
     */
    public function queryCompanyBasicInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCompanyBasicInfoHeaders([]);

        return $this->queryCompanyBasicInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDigitalDistrictOrgInfoRequest $request
     * @param QueryDigitalDistrictOrgInfoHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return QueryDigitalDistrictOrgInfoResponse
     */
    public function queryDigitalDistrictOrgInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpIds)) {
            $body['corpIds'] = $request->corpIds;
        }
        if (!Utils::isUnset($request->statDates)) {
            $body['statDates'] = $request->statDates;
        }
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
            'action'      => 'QueryDigitalDistrictOrgInfo',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/digitalCounty/orgInfos/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryDigitalDistrictOrgInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryDigitalDistrictOrgInfoRequest $request
     *
     * @return QueryDigitalDistrictOrgInfoResponse
     */
    public function queryDigitalDistrictOrgInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDigitalDistrictOrgInfoHeaders([]);

        return $this->queryDigitalDistrictOrgInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDingReciveStatisticalDataRequest $request
     * @param QueryDingReciveStatisticalDataHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryDingReciveStatisticalDataResponse
     */
    public function queryDingReciveStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryDingReciveStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/dingReciveData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryDingReciveStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryDingReciveStatisticalDataRequest $request
     *
     * @return QueryDingReciveStatisticalDataResponse
     */
    public function queryDingReciveStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDingReciveStatisticalDataHeaders([]);

        return $this->queryDingReciveStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDingSendStatisticalDataRequest $request
     * @param QueryDingSendStatisticalDataHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryDingSendStatisticalDataResponse
     */
    public function queryDingSendStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryDingSendStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/dingSendData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryDingSendStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryDingSendStatisticalDataRequest $request
     *
     * @return QueryDingSendStatisticalDataResponse
     */
    public function queryDingSendStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDingSendStatisticalDataHeaders([]);

        return $this->queryDingSendStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDocumentStatisticalDataRequest $request
     * @param QueryDocumentStatisticalDataHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryDocumentStatisticalDataResponse
     */
    public function queryDocumentStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryDocumentStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/documentData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryDocumentStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryDocumentStatisticalDataRequest $request
     *
     * @return QueryDocumentStatisticalDataResponse
     */
    public function queryDocumentStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDocumentStatisticalDataHeaders([]);

        return $this->queryDocumentStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDriveStatisticalDataRequest $request
     * @param QueryDriveStatisticalDataHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryDriveStatisticalDataResponse
     */
    public function queryDriveStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryDriveStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/driveData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryDriveStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryDriveStatisticalDataRequest $request
     *
     * @return QueryDriveStatisticalDataResponse
     */
    public function queryDriveStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDriveStatisticalDataHeaders([]);

        return $this->queryDriveStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryEmployeeTypeStatisticalDataRequest $request
     * @param QueryEmployeeTypeStatisticalDataHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return QueryEmployeeTypeStatisticalDataResponse
     */
    public function queryEmployeeTypeStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryEmployeeTypeStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/employeeTypeData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryEmployeeTypeStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryEmployeeTypeStatisticalDataRequest $request
     *
     * @return QueryEmployeeTypeStatisticalDataResponse
     */
    public function queryEmployeeTypeStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryEmployeeTypeStatisticalDataHeaders([]);

        return $this->queryEmployeeTypeStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryGeneralDataServiceRequest $request
     * @param QueryGeneralDataServiceHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return QueryGeneralDataServiceResponse
     */
    public function queryGeneralDataServiceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deptId)) {
            $query['deptId'] = $request->deptId;
        }
        if (!Utils::isUnset($request->endDate)) {
            $query['endDate'] = $request->endDate;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->serviceId)) {
            $query['serviceId'] = $request->serviceId;
        }
        if (!Utils::isUnset($request->startDate)) {
            $query['startDate'] = $request->startDate;
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
            'action'      => 'QueryGeneralDataService',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/generalDataServices',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryGeneralDataServiceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryGeneralDataServiceRequest $request
     *
     * @return QueryGeneralDataServiceResponse
     */
    public function queryGeneralDataService($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGeneralDataServiceHeaders([]);

        return $this->queryGeneralDataServiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryGroupLiveStatisticalDataRequest $request
     * @param QueryGroupLiveStatisticalDataHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return QueryGroupLiveStatisticalDataResponse
     */
    public function queryGroupLiveStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryGroupLiveStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/groupLiveData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryGroupLiveStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryGroupLiveStatisticalDataRequest $request
     *
     * @return QueryGroupLiveStatisticalDataResponse
     */
    public function queryGroupLiveStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupLiveStatisticalDataHeaders([]);

        return $this->queryGroupLiveStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryGroupMessageStatisticalDataRequest $request
     * @param QueryGroupMessageStatisticalDataHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return QueryGroupMessageStatisticalDataResponse
     */
    public function queryGroupMessageStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryGroupMessageStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/groupMessageData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryGroupMessageStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryGroupMessageStatisticalDataRequest $request
     *
     * @return QueryGroupMessageStatisticalDataResponse
     */
    public function queryGroupMessageStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupMessageStatisticalDataHeaders([]);

        return $this->queryGroupMessageStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryHealthStatisticalDataRequest $request
     * @param QueryHealthStatisticalDataHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return QueryHealthStatisticalDataResponse
     */
    public function queryHealthStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryHealthStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/healtheUserData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryHealthStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryHealthStatisticalDataRequest $request
     *
     * @return QueryHealthStatisticalDataResponse
     */
    public function queryHealthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHealthStatisticalDataHeaders([]);

        return $this->queryHealthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryMailStatisticalDataRequest $request
     * @param QueryMailStatisticalDataHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return QueryMailStatisticalDataResponse
     */
    public function queryMailStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryMailStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/mailData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryMailStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryMailStatisticalDataRequest $request
     *
     * @return QueryMailStatisticalDataResponse
     */
    public function queryMailStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMailStatisticalDataHeaders([]);

        return $this->queryMailStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryOfficialDataRequest $request
     * @param QueryOfficialDataHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return QueryOfficialDataResponse
     */
    public function queryOfficialDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->param)) {
            $query['param'] = $request->param;
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
            'action'      => 'QueryOfficialData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/datas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryOfficialDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryOfficialDataRequest $request
     *
     * @return QueryOfficialDataResponse
     */
    public function queryOfficialData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOfficialDataHeaders([]);

        return $this->queryOfficialDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryOfficialDatasetFieldsRequest $request
     * @param QueryOfficialDatasetFieldsHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return QueryOfficialDatasetFieldsResponse
     */
    public function queryOfficialDatasetFieldsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->dsId)) {
            $query['dsId'] = $request->dsId;
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
            'action'      => 'QueryOfficialDatasetFields',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/datasetFields',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryOfficialDatasetFieldsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryOfficialDatasetFieldsRequest $request
     *
     * @return QueryOfficialDatasetFieldsResponse
     */
    public function queryOfficialDatasetFields($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOfficialDatasetFieldsHeaders([]);

        return $this->queryOfficialDatasetFieldsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryOfficialDatasetListRequest $request
     * @param QueryOfficialDatasetListHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return QueryOfficialDatasetListResponse
     */
    public function queryOfficialDatasetListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->keyword)) {
            $query['keyword'] = $request->keyword;
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
            'action'      => 'QueryOfficialDatasetList',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/datasetLists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryOfficialDatasetListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryOfficialDatasetListRequest $request
     *
     * @return QueryOfficialDatasetListResponse
     */
    public function queryOfficialDatasetList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOfficialDatasetListHeaders([]);

        return $this->queryOfficialDatasetListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryOfficialFormDataRequest $request
     * @param QueryOfficialFormDataHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return QueryOfficialFormDataResponse
     */
    public function queryOfficialFormDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->param)) {
            $body['param'] = $request->param;
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
            'action'      => 'QueryOfficialFormData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/datas/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryOfficialFormDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryOfficialFormDataRequest $request
     *
     * @return QueryOfficialFormDataResponse
     */
    public function queryOfficialFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOfficialFormDataHeaders([]);

        return $this->queryOfficialFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryOnlineUserStatisticalDataRequest $request
     * @param QueryOnlineUserStatisticalDataHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryOnlineUserStatisticalDataResponse
     */
    public function queryOnlineUserStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryOnlineUserStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/onlineUserData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryOnlineUserStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryOnlineUserStatisticalDataRequest $request
     *
     * @return QueryOnlineUserStatisticalDataResponse
     */
    public function queryOnlineUserStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOnlineUserStatisticalDataHeaders([]);

        return $this->queryOnlineUserStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryRedEnvelopeReciveStatisticalDataRequest $request
     * @param QueryRedEnvelopeReciveStatisticalDataHeaders $headers
     * @param RuntimeOptions                               $runtime
     *
     * @return QueryRedEnvelopeReciveStatisticalDataResponse
     */
    public function queryRedEnvelopeReciveStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryRedEnvelopeReciveStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/redEnvelopeReciveData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryRedEnvelopeReciveStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryRedEnvelopeReciveStatisticalDataRequest $request
     *
     * @return QueryRedEnvelopeReciveStatisticalDataResponse
     */
    public function queryRedEnvelopeReciveStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRedEnvelopeReciveStatisticalDataHeaders([]);

        return $this->queryRedEnvelopeReciveStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryRedEnvelopeSendStatisticalDataRequest $request
     * @param QueryRedEnvelopeSendStatisticalDataHeaders $headers
     * @param RuntimeOptions                             $runtime
     *
     * @return QueryRedEnvelopeSendStatisticalDataResponse
     */
    public function queryRedEnvelopeSendStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryRedEnvelopeSendStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/redEnvelopeSendData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryRedEnvelopeSendStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryRedEnvelopeSendStatisticalDataRequest $request
     *
     * @return QueryRedEnvelopeSendStatisticalDataResponse
     */
    public function queryRedEnvelopeSendStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRedEnvelopeSendStatisticalDataHeaders([]);

        return $this->queryRedEnvelopeSendStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryReportStatisticalDataRequest $request
     * @param QueryReportStatisticalDataHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return QueryReportStatisticalDataResponse
     */
    public function queryReportStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryReportStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/reportData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryReportStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryReportStatisticalDataRequest $request
     *
     * @return QueryReportStatisticalDataResponse
     */
    public function queryReportStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryReportStatisticalDataHeaders([]);

        return $this->queryReportStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QuerySingleMessageStatisticalDataRequest $request
     * @param QuerySingleMessageStatisticalDataHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return QuerySingleMessageStatisticalDataResponse
     */
    public function querySingleMessageStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QuerySingleMessageStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/singleMessagerData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QuerySingleMessageStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QuerySingleMessageStatisticalDataRequest $request
     *
     * @return QuerySingleMessageStatisticalDataResponse
     */
    public function querySingleMessageStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySingleMessageStatisticalDataHeaders([]);

        return $this->querySingleMessageStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryTelMeetingStatisticalDataRequest $request
     * @param QueryTelMeetingStatisticalDataHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryTelMeetingStatisticalDataResponse
     */
    public function queryTelMeetingStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryTelMeetingStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/telMeetingData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryTelMeetingStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryTelMeetingStatisticalDataRequest $request
     *
     * @return QueryTelMeetingStatisticalDataResponse
     */
    public function queryTelMeetingStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTelMeetingStatisticalDataHeaders([]);

        return $this->queryTelMeetingStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryTodoStatisticalDataRequest $request
     * @param QueryTodoStatisticalDataHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return QueryTodoStatisticalDataResponse
     */
    public function queryTodoStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryTodoStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/todoUserData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryTodoStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryTodoStatisticalDataRequest $request
     *
     * @return QueryTodoStatisticalDataResponse
     */
    public function queryTodoStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTodoStatisticalDataHeaders([]);

        return $this->queryTodoStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryVedioMeetingStatisticalDataRequest $request
     * @param QueryVedioMeetingStatisticalDataHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return QueryVedioMeetingStatisticalDataResponse
     */
    public function queryVedioMeetingStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryVedioMeetingStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/vedioMeetingData',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryVedioMeetingStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryVedioMeetingStatisticalDataRequest $request
     *
     * @return QueryVedioMeetingStatisticalDataResponse
     */
    public function queryVedioMeetingStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryVedioMeetingStatisticalDataHeaders([]);

        return $this->queryVedioMeetingStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydActiveDayStatisticalDataRequest $request
     * @param QueryYydActiveDayStatisticalDataHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return QueryYydActiveDayStatisticalDataResponse
     */
    public function queryYydActiveDayStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydActiveDayStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydActiveDayDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydActiveDayStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydActiveDayStatisticalDataRequest $request
     *
     * @return QueryYydActiveDayStatisticalDataResponse
     */
    public function queryYydActiveDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydActiveDayStatisticalDataHeaders([]);

        return $this->queryYydActiveDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydActiveMonthStatisticalDataRequest $request
     * @param QueryYydActiveMonthStatisticalDataHeaders $headers
     * @param RuntimeOptions                            $runtime
     *
     * @return QueryYydActiveMonthStatisticalDataResponse
     */
    public function queryYydActiveMonthStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydActiveMonthStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydActiveMonthDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydActiveMonthStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydActiveMonthStatisticalDataRequest $request
     *
     * @return QueryYydActiveMonthStatisticalDataResponse
     */
    public function queryYydActiveMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydActiveMonthStatisticalDataHeaders([]);

        return $this->queryYydActiveMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydActiveWeekStatisticalDataRequest $request
     * @param QueryYydActiveWeekStatisticalDataHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return QueryYydActiveWeekStatisticalDataResponse
     */
    public function queryYydActiveWeekStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydActiveWeekStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydActiveWeekDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydActiveWeekStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydActiveWeekStatisticalDataRequest $request
     *
     * @return QueryYydActiveWeekStatisticalDataResponse
     */
    public function queryYydActiveWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydActiveWeekStatisticalDataHeaders([]);

        return $this->queryYydActiveWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydAppDayStatisticalDataRequest $request
     * @param QueryYydAppDayStatisticalDataHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return QueryYydAppDayStatisticalDataResponse
     */
    public function queryYydAppDayStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydAppDayStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydAppDayDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydAppDayStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydAppDayStatisticalDataRequest $request
     *
     * @return QueryYydAppDayStatisticalDataResponse
     */
    public function queryYydAppDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydAppDayStatisticalDataHeaders([]);

        return $this->queryYydAppDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydAppMonthStatisticalDataRequest $request
     * @param QueryYydAppMonthStatisticalDataHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return QueryYydAppMonthStatisticalDataResponse
     */
    public function queryYydAppMonthStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydAppMonthStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydAppMonthDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydAppMonthStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydAppMonthStatisticalDataRequest $request
     *
     * @return QueryYydAppMonthStatisticalDataResponse
     */
    public function queryYydAppMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydAppMonthStatisticalDataHeaders([]);

        return $this->queryYydAppMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydAppStdStatisticalDataRequest $request
     * @param QueryYydAppStdStatisticalDataHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return QueryYydAppStdStatisticalDataResponse
     */
    public function queryYydAppStdStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydAppStdStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydAppStdDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydAppStdStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydAppStdStatisticalDataRequest $request
     *
     * @return QueryYydAppStdStatisticalDataResponse
     */
    public function queryYydAppStdStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydAppStdStatisticalDataHeaders([]);

        return $this->queryYydAppStdStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydAppWeekStatisticalDataRequest $request
     * @param QueryYydAppWeekStatisticalDataHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryYydAppWeekStatisticalDataResponse
     */
    public function queryYydAppWeekStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydAppWeekStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydAppWeekDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydAppWeekStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydAppWeekStatisticalDataRequest $request
     *
     * @return QueryYydAppWeekStatisticalDataResponse
     */
    public function queryYydAppWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydAppWeekStatisticalDataHeaders([]);

        return $this->queryYydAppWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydCalendarDayStatisticalDataRequest $request
     * @param QueryYydCalendarDayStatisticalDataHeaders $headers
     * @param RuntimeOptions                            $runtime
     *
     * @return QueryYydCalendarDayStatisticalDataResponse
     */
    public function queryYydCalendarDayStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydCalendarDayStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydCalendarDayDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydCalendarDayStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydCalendarDayStatisticalDataRequest $request
     *
     * @return QueryYydCalendarDayStatisticalDataResponse
     */
    public function queryYydCalendarDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydCalendarDayStatisticalDataHeaders([]);

        return $this->queryYydCalendarDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydCalendarMonthStatisticalDataRequest $request
     * @param QueryYydCalendarMonthStatisticalDataHeaders $headers
     * @param RuntimeOptions                              $runtime
     *
     * @return QueryYydCalendarMonthStatisticalDataResponse
     */
    public function queryYydCalendarMonthStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydCalendarMonthStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydCalendarMonthDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydCalendarMonthStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydCalendarMonthStatisticalDataRequest $request
     *
     * @return QueryYydCalendarMonthStatisticalDataResponse
     */
    public function queryYydCalendarMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydCalendarMonthStatisticalDataHeaders([]);

        return $this->queryYydCalendarMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydCalendarWeekStatisticalDataRequest $request
     * @param QueryYydCalendarWeekStatisticalDataHeaders $headers
     * @param RuntimeOptions                             $runtime
     *
     * @return QueryYydCalendarWeekStatisticalDataResponse
     */
    public function queryYydCalendarWeekStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydCalendarWeekStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydCalendarWeekDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydCalendarWeekStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydCalendarWeekStatisticalDataRequest $request
     *
     * @return QueryYydCalendarWeekStatisticalDataResponse
     */
    public function queryYydCalendarWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydCalendarWeekStatisticalDataHeaders([]);

        return $this->queryYydCalendarWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydDingMsgDayStatisticalDataRequest $request
     * @param QueryYydDingMsgDayStatisticalDataHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return QueryYydDingMsgDayStatisticalDataResponse
     */
    public function queryYydDingMsgDayStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydDingMsgDayStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydDingMsgDayDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydDingMsgDayStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydDingMsgDayStatisticalDataRequest $request
     *
     * @return QueryYydDingMsgDayStatisticalDataResponse
     */
    public function queryYydDingMsgDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydDingMsgDayStatisticalDataHeaders([]);

        return $this->queryYydDingMsgDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydDingMsgMonthStatisticalDataRequest $request
     * @param QueryYydDingMsgMonthStatisticalDataHeaders $headers
     * @param RuntimeOptions                             $runtime
     *
     * @return QueryYydDingMsgMonthStatisticalDataResponse
     */
    public function queryYydDingMsgMonthStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydDingMsgMonthStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydDingMsgMonthDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydDingMsgMonthStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydDingMsgMonthStatisticalDataRequest $request
     *
     * @return QueryYydDingMsgMonthStatisticalDataResponse
     */
    public function queryYydDingMsgMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydDingMsgMonthStatisticalDataHeaders([]);

        return $this->queryYydDingMsgMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydDingMsgWeekStatisticalDataRequest $request
     * @param QueryYydDingMsgWeekStatisticalDataHeaders $headers
     * @param RuntimeOptions                            $runtime
     *
     * @return QueryYydDingMsgWeekStatisticalDataResponse
     */
    public function queryYydDingMsgWeekStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydDingMsgWeekStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydDingMsgWeekDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydDingMsgWeekStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydDingMsgWeekStatisticalDataRequest $request
     *
     * @return QueryYydDingMsgWeekStatisticalDataResponse
     */
    public function queryYydDingMsgWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydDingMsgWeekStatisticalDataHeaders([]);

        return $this->queryYydDingMsgWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydGroupMsgDayStatisticalDataRequest $request
     * @param QueryYydGroupMsgDayStatisticalDataHeaders $headers
     * @param RuntimeOptions                            $runtime
     *
     * @return QueryYydGroupMsgDayStatisticalDataResponse
     */
    public function queryYydGroupMsgDayStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydGroupMsgDayStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydGroupMsgDayDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydGroupMsgDayStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydGroupMsgDayStatisticalDataRequest $request
     *
     * @return QueryYydGroupMsgDayStatisticalDataResponse
     */
    public function queryYydGroupMsgDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydGroupMsgDayStatisticalDataHeaders([]);

        return $this->queryYydGroupMsgDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydGroupMsgMonthStatisticalDataRequest $request
     * @param QueryYydGroupMsgMonthStatisticalDataHeaders $headers
     * @param RuntimeOptions                              $runtime
     *
     * @return QueryYydGroupMsgMonthStatisticalDataResponse
     */
    public function queryYydGroupMsgMonthStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydGroupMsgMonthStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydGroupMsgMonthDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydGroupMsgMonthStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydGroupMsgMonthStatisticalDataRequest $request
     *
     * @return QueryYydGroupMsgMonthStatisticalDataResponse
     */
    public function queryYydGroupMsgMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydGroupMsgMonthStatisticalDataHeaders([]);

        return $this->queryYydGroupMsgMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydGroupMsgWeekStatisticalDataRequest $request
     * @param QueryYydGroupMsgWeekStatisticalDataHeaders $headers
     * @param RuntimeOptions                             $runtime
     *
     * @return QueryYydGroupMsgWeekStatisticalDataResponse
     */
    public function queryYydGroupMsgWeekStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydGroupMsgWeekStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydGroupMsgWeekDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydGroupMsgWeekStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydGroupMsgWeekStatisticalDataRequest $request
     *
     * @return QueryYydGroupMsgWeekStatisticalDataResponse
     */
    public function queryYydGroupMsgWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydGroupMsgWeekStatisticalDataHeaders([]);

        return $this->queryYydGroupMsgWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydLogDayStatisticalDataRequest $request
     * @param QueryYydLogDayStatisticalDataHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return QueryYydLogDayStatisticalDataResponse
     */
    public function queryYydLogDayStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydLogDayStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydLogDayDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydLogDayStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydLogDayStatisticalDataRequest $request
     *
     * @return QueryYydLogDayStatisticalDataResponse
     */
    public function queryYydLogDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydLogDayStatisticalDataHeaders([]);

        return $this->queryYydLogDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydLogMonthStatisticalDataRequest $request
     * @param QueryYydLogMonthStatisticalDataHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return QueryYydLogMonthStatisticalDataResponse
     */
    public function queryYydLogMonthStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydLogMonthStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydLogMonthDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydLogMonthStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydLogMonthStatisticalDataRequest $request
     *
     * @return QueryYydLogMonthStatisticalDataResponse
     */
    public function queryYydLogMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydLogMonthStatisticalDataHeaders([]);

        return $this->queryYydLogMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydLogWeekStatisticalDataRequest $request
     * @param QueryYydLogWeekStatisticalDataHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryYydLogWeekStatisticalDataResponse
     */
    public function queryYydLogWeekStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydLogWeekStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydLogWeekDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydLogWeekStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydLogWeekStatisticalDataRequest $request
     *
     * @return QueryYydLogWeekStatisticalDataResponse
     */
    public function queryYydLogWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydLogWeekStatisticalDataHeaders([]);

        return $this->queryYydLogWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydMeetingDayStatisticalDataRequest $request
     * @param QueryYydMeetingDayStatisticalDataHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return QueryYydMeetingDayStatisticalDataResponse
     */
    public function queryYydMeetingDayStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydMeetingDayStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydMeetingDayDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydMeetingDayStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydMeetingDayStatisticalDataRequest $request
     *
     * @return QueryYydMeetingDayStatisticalDataResponse
     */
    public function queryYydMeetingDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydMeetingDayStatisticalDataHeaders([]);

        return $this->queryYydMeetingDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydMeetingMonthStatisticalDataRequest $request
     * @param QueryYydMeetingMonthStatisticalDataHeaders $headers
     * @param RuntimeOptions                             $runtime
     *
     * @return QueryYydMeetingMonthStatisticalDataResponse
     */
    public function queryYydMeetingMonthStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydMeetingMonthStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydMeetingMonthDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydMeetingMonthStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydMeetingMonthStatisticalDataRequest $request
     *
     * @return QueryYydMeetingMonthStatisticalDataResponse
     */
    public function queryYydMeetingMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydMeetingMonthStatisticalDataHeaders([]);

        return $this->queryYydMeetingMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydMeetingWeekStatisticalDataRequest $request
     * @param QueryYydMeetingWeekStatisticalDataHeaders $headers
     * @param RuntimeOptions                            $runtime
     *
     * @return QueryYydMeetingWeekStatisticalDataResponse
     */
    public function queryYydMeetingWeekStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydMeetingWeekStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydMeetingWeekDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydMeetingWeekStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydMeetingWeekStatisticalDataRequest $request
     *
     * @return QueryYydMeetingWeekStatisticalDataResponse
     */
    public function queryYydMeetingWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydMeetingWeekStatisticalDataHeaders([]);

        return $this->queryYydMeetingWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydNoticeDayStatisticalDataRequest $request
     * @param QueryYydNoticeDayStatisticalDataHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return QueryYydNoticeDayStatisticalDataResponse
     */
    public function queryYydNoticeDayStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydNoticeDayStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydNoticeDayDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydNoticeDayStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydNoticeDayStatisticalDataRequest $request
     *
     * @return QueryYydNoticeDayStatisticalDataResponse
     */
    public function queryYydNoticeDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydNoticeDayStatisticalDataHeaders([]);

        return $this->queryYydNoticeDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydNoticeMonthStatisticalDataRequest $request
     * @param QueryYydNoticeMonthStatisticalDataHeaders $headers
     * @param RuntimeOptions                            $runtime
     *
     * @return QueryYydNoticeMonthStatisticalDataResponse
     */
    public function queryYydNoticeMonthStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydNoticeMonthStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydNoticeMonthDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydNoticeMonthStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydNoticeMonthStatisticalDataRequest $request
     *
     * @return QueryYydNoticeMonthStatisticalDataResponse
     */
    public function queryYydNoticeMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydNoticeMonthStatisticalDataHeaders([]);

        return $this->queryYydNoticeMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydNoticeWeekStatisticalDataRequest $request
     * @param QueryYydNoticeWeekStatisticalDataHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return QueryYydNoticeWeekStatisticalDataResponse
     */
    public function queryYydNoticeWeekStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydNoticeWeekStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydNoticeWeekDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydNoticeWeekStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydNoticeWeekStatisticalDataRequest $request
     *
     * @return QueryYydNoticeWeekStatisticalDataResponse
     */
    public function queryYydNoticeWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydNoticeWeekStatisticalDataHeaders([]);

        return $this->queryYydNoticeWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydSingleMsgDayStatisticalDataRequest $request
     * @param QueryYydSingleMsgDayStatisticalDataHeaders $headers
     * @param RuntimeOptions                             $runtime
     *
     * @return QueryYydSingleMsgDayStatisticalDataResponse
     */
    public function queryYydSingleMsgDayStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydSingleMsgDayStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydSingleMsgDayDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydSingleMsgDayStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydSingleMsgDayStatisticalDataRequest $request
     *
     * @return QueryYydSingleMsgDayStatisticalDataResponse
     */
    public function queryYydSingleMsgDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydSingleMsgDayStatisticalDataHeaders([]);

        return $this->queryYydSingleMsgDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydSingleMsgMonthStatisticalDataRequest $request
     * @param QueryYydSingleMsgMonthStatisticalDataHeaders $headers
     * @param RuntimeOptions                               $runtime
     *
     * @return QueryYydSingleMsgMonthStatisticalDataResponse
     */
    public function queryYydSingleMsgMonthStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydSingleMsgMonthStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydSingleMsgMonthDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydSingleMsgMonthStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydSingleMsgMonthStatisticalDataRequest $request
     *
     * @return QueryYydSingleMsgMonthStatisticalDataResponse
     */
    public function queryYydSingleMsgMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydSingleMsgMonthStatisticalDataHeaders([]);

        return $this->queryYydSingleMsgMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydSingleMsgWeekStatisticalDataRequest $request
     * @param QueryYydSingleMsgWeekStatisticalDataHeaders $headers
     * @param RuntimeOptions                              $runtime
     *
     * @return QueryYydSingleMsgWeekStatisticalDataResponse
     */
    public function queryYydSingleMsgWeekStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydSingleMsgWeekStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydSingleMsgWeekDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydSingleMsgWeekStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydSingleMsgWeekStatisticalDataRequest $request
     *
     * @return QueryYydSingleMsgWeekStatisticalDataResponse
     */
    public function queryYydSingleMsgWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydSingleMsgWeekStatisticalDataHeaders([]);

        return $this->queryYydSingleMsgWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydToatlMsgDayStatisticalDataRequest $request
     * @param QueryYydToatlMsgDayStatisticalDataHeaders $headers
     * @param RuntimeOptions                            $runtime
     *
     * @return QueryYydToatlMsgDayStatisticalDataResponse
     */
    public function queryYydToatlMsgDayStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydToatlMsgDayStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydToatlMsgDayDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydToatlMsgDayStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydToatlMsgDayStatisticalDataRequest $request
     *
     * @return QueryYydToatlMsgDayStatisticalDataResponse
     */
    public function queryYydToatlMsgDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydToatlMsgDayStatisticalDataHeaders([]);

        return $this->queryYydToatlMsgDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydToatlMsgMonthStatisticalDataRequest $request
     * @param QueryYydToatlMsgMonthStatisticalDataHeaders $headers
     * @param RuntimeOptions                              $runtime
     *
     * @return QueryYydToatlMsgMonthStatisticalDataResponse
     */
    public function queryYydToatlMsgMonthStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydToatlMsgMonthStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydToatlMsgMonthDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydToatlMsgMonthStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydToatlMsgMonthStatisticalDataRequest $request
     *
     * @return QueryYydToatlMsgMonthStatisticalDataResponse
     */
    public function queryYydToatlMsgMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydToatlMsgMonthStatisticalDataHeaders([]);

        return $this->queryYydToatlMsgMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydToatlMsgWeekStatisticalDataRequest $request
     * @param QueryYydToatlMsgWeekStatisticalDataHeaders $headers
     * @param RuntimeOptions                             $runtime
     *
     * @return QueryYydToatlMsgWeekStatisticalDataResponse
     */
    public function queryYydToatlMsgWeekStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydToatlMsgWeekStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydToatlMsgWeekDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydToatlMsgWeekStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydToatlMsgWeekStatisticalDataRequest $request
     *
     * @return QueryYydToatlMsgWeekStatisticalDataResponse
     */
    public function queryYydToatlMsgWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydToatlMsgWeekStatisticalDataHeaders([]);

        return $this->queryYydToatlMsgWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydTodoDayStatisticalDataRequest $request
     * @param QueryYydTodoDayStatisticalDataHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryYydTodoDayStatisticalDataResponse
     */
    public function queryYydTodoDayStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydTodoDayStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydTodoDayDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydTodoDayStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydTodoDayStatisticalDataRequest $request
     *
     * @return QueryYydTodoDayStatisticalDataResponse
     */
    public function queryYydTodoDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydTodoDayStatisticalDataHeaders([]);

        return $this->queryYydTodoDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydTodoMonthStatisticalDataRequest $request
     * @param QueryYydTodoMonthStatisticalDataHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return QueryYydTodoMonthStatisticalDataResponse
     */
    public function queryYydTodoMonthStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydTodoMonthStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydTodoMonthDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydTodoMonthStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydTodoMonthStatisticalDataRequest $request
     *
     * @return QueryYydTodoMonthStatisticalDataResponse
     */
    public function queryYydTodoMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydTodoMonthStatisticalDataHeaders([]);

        return $this->queryYydTodoMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydTodoWeekStatisticalDataRequest $request
     * @param QueryYydTodoWeekStatisticalDataHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return QueryYydTodoWeekStatisticalDataResponse
     */
    public function queryYydTodoWeekStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydTodoWeekStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydTodoWeekDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydTodoWeekStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydTodoWeekStatisticalDataRequest $request
     *
     * @return QueryYydTodoWeekStatisticalDataResponse
     */
    public function queryYydTodoWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydTodoWeekStatisticalDataHeaders([]);

        return $this->queryYydTodoWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydTotalDayStatisticalDataRequest $request
     * @param QueryYydTotalDayStatisticalDataHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return QueryYydTotalDayStatisticalDataResponse
     */
    public function queryYydTotalDayStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydTotalDayStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydTotalDayDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydTotalDayStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydTotalDayStatisticalDataRequest $request
     *
     * @return QueryYydTotalDayStatisticalDataResponse
     */
    public function queryYydTotalDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydTotalDayStatisticalDataHeaders([]);

        return $this->queryYydTotalDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydTotalMonthStatisticalDataRequest $request
     * @param QueryYydTotalMonthStatisticalDataHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return QueryYydTotalMonthStatisticalDataResponse
     */
    public function queryYydTotalMonthStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydTotalMonthStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydTotalMonthDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydTotalMonthStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydTotalMonthStatisticalDataRequest $request
     *
     * @return QueryYydTotalMonthStatisticalDataResponse
     */
    public function queryYydTotalMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydTotalMonthStatisticalDataHeaders([]);

        return $this->queryYydTotalMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydTotalStdStatisticalDataRequest $request
     * @param QueryYydTotalStdStatisticalDataHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return QueryYydTotalStdStatisticalDataResponse
     */
    public function queryYydTotalStdStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydTotalStdStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydTotalStdDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydTotalStdStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydTotalStdStatisticalDataRequest $request
     *
     * @return QueryYydTotalStdStatisticalDataResponse
     */
    public function queryYydTotalStdStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydTotalStdStatisticalDataHeaders([]);

        return $this->queryYydTotalStdStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryYydTotalWeekStatisticalDataRequest $request
     * @param QueryYydTotalWeekStatisticalDataHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return QueryYydTotalWeekStatisticalDataResponse
     */
    public function queryYydTotalWeekStatisticalDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->statDate)) {
            $query['statDate'] = $request->statDate;
        }
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
            'action'      => 'QueryYydTotalWeekStatisticalData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/yydTotalWeekDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryYydTotalWeekStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryYydTotalWeekStatisticalDataRequest $request
     *
     * @return QueryYydTotalWeekStatisticalDataResponse
     */
    public function queryYydTotalWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydTotalWeekStatisticalDataHeaders([]);

        return $this->queryYydTotalWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchCompanyRequest $request
     * @param SearchCompanyHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return SearchCompanyResponse
     */
    public function searchCompanyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchKey)) {
            $query['searchKey'] = $request->searchKey;
        }
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
            'action'      => 'SearchCompany',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/keywords/companies',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchCompanyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SearchCompanyRequest $request
     *
     * @return SearchCompanyResponse
     */
    public function searchCompany($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchCompanyHeaders([]);

        return $this->searchCompanyWithOptions($request, $headers, $runtime);
    }
}
