<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\CloseDataDeliverHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\CloseDataDeliverRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\CloseDataDeliverResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\CreateDataDeliverHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\CreateDataDeliverRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\CreateDataDeliverResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\CreateScreenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\CreateScreenRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\CreateScreenResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetDataDeliverHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetDataDeliverRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetDataDeliverResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetDomainInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetDomainInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetDomainInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetDoubleRandomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetDoubleRandomRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetDoubleRandomResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetEnvironmentalPenaltiesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetEnvironmentalPenaltiesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetEnvironmentalPenaltiesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetEventDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetEventDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\GetEventDataResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\ListDataDeliversHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\ListDataDeliversRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\ListDataDeliversResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\OperateChartConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\OperateChartConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\OperateChartConfigResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryChartDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryChartDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryChartDataResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDpaasDataPackageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDpaasDataPackageResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDriveStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDriveStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDriveStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryEmployeeTypeStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryEmployeeTypeStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryEmployeeTypeStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGeneralDataServiceBatchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGeneralDataServiceBatchRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGeneralDataServiceBatchResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGeneralDataServiceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGeneralDataServiceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGeneralDataServiceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGeneralDataUpdateDateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGeneralDataUpdateDateRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryGeneralDataUpdateDateResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialFormDataDirectHoloHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialFormDataDirectHoloRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryOfficialFormDataDirectHoloResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryScreenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryScreenRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryScreenResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryScreenTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryScreenTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryScreenTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QuerySingleMessageStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QuerySingleMessageStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QuerySingleMessageStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTelMeetingStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTelMeetingStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTelMeetingStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTodoStatisticalDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTodoStatisticalDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTodoStatisticalDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTotalDataCountServiceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTotalDataCountServiceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryTotalDataCountServiceResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\SyncDataScreenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\SyncDataScreenRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\SyncDataScreenResponse;
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
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 关闭数据投递任务
     *  *
     * @param CloseDataDeliverRequest $request CloseDataDeliverRequest
     * @param CloseDataDeliverHeaders $headers CloseDataDeliverHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return CloseDataDeliverResponse CloseDataDeliverResponse
     */
    public function closeDataDeliverWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deliverId)) {
            $query['deliverId'] = $request->deliverId;
        }
        if (!Utils::isUnset($request->dispatchingItemType)) {
            $query['dispatchingItemType'] = $request->dispatchingItemType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'CloseDataDeliver',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/dataDeliverServices/close',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CloseDataDeliverResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 关闭数据投递任务
     *  *
     * @param CloseDataDeliverRequest $request CloseDataDeliverRequest
     *
     * @return CloseDataDeliverResponse CloseDataDeliverResponse
     */
    public function closeDataDeliver($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CloseDataDeliverHeaders([]);

        return $this->closeDataDeliverWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建数据投递
     *  *
     * @param CreateDataDeliverRequest $request CreateDataDeliverRequest
     * @param CreateDataDeliverHeaders $headers CreateDataDeliverHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateDataDeliverResponse CreateDataDeliverResponse
     */
    public function createDataDeliverWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizcode)) {
            $query['bizcode'] = $request->bizcode;
        }
        if (!Utils::isUnset($request->dispatchingCycle)) {
            $query['dispatchingCycle'] = $request->dispatchingCycle;
        }
        if (!Utils::isUnset($request->dispatchingItemType)) {
            $query['dispatchingItemType'] = $request->dispatchingItemType;
        }
        if (!Utils::isUnset($request->dispatchingStartDate)) {
            $query['dispatchingStartDate'] = $request->dispatchingStartDate;
        }
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
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateDataDeliver',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/dataDeliveries',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateDataDeliverResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建数据投递
     *  *
     * @param CreateDataDeliverRequest $request CreateDataDeliverRequest
     *
     * @return CreateDataDeliverResponse CreateDataDeliverResponse
     */
    public function createDataDeliver($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDataDeliverHeaders([]);

        return $this->createDataDeliverWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新增数据大屏
     *  *
     * @param CreateScreenRequest $request CreateScreenRequest
     * @param CreateScreenHeaders $headers CreateScreenHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateScreenResponse CreateScreenResponse
     */
    public function createScreenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->templateId)) {
            $query['templateId'] = $request->templateId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'CreateScreen',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/screens',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateScreenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增数据大屏
     *  *
     * @param CreateScreenRequest $request CreateScreenRequest
     *
     * @return CreateScreenResponse CreateScreenResponse
     */
    public function createScreen($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateScreenHeaders([]);

        return $this->createScreenWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 工商-经营异常
     *  *
     * @param GetAbnormalOperationRequest $request GetAbnormalOperationRequest
     * @param GetAbnormalOperationHeaders $headers GetAbnormalOperationHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAbnormalOperationResponse GetAbnormalOperationResponse
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
     * @summary 工商-经营异常
     *  *
     * @param GetAbnormalOperationRequest $request GetAbnormalOperationRequest
     *
     * @return GetAbnormalOperationResponse GetAbnormalOperationResponse
     */
    public function getAbnormalOperation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAbnormalOperationHeaders([]);

        return $this->getAbnormalOperationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取工商-行政许可
     *  *
     * @param GetAdministrativeLicensingRequest $request GetAdministrativeLicensingRequest
     * @param GetAdministrativeLicensingHeaders $headers GetAdministrativeLicensingHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAdministrativeLicensingResponse GetAdministrativeLicensingResponse
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
     * @summary 获取工商-行政许可
     *  *
     * @param GetAdministrativeLicensingRequest $request GetAdministrativeLicensingRequest
     *
     * @return GetAdministrativeLicensingResponse GetAdministrativeLicensingResponse
     */
    public function getAdministrativeLicensing($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAdministrativeLicensingHeaders([]);

        return $this->getAdministrativeLicensingWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 负面-行政处罚
     *  *
     * @param GetAdministrativePenaltiesRequest $request GetAdministrativePenaltiesRequest
     * @param GetAdministrativePenaltiesHeaders $headers GetAdministrativePenaltiesHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAdministrativePenaltiesResponse GetAdministrativePenaltiesResponse
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
     * @summary 负面-行政处罚
     *  *
     * @param GetAdministrativePenaltiesRequest $request GetAdministrativePenaltiesRequest
     *
     * @return GetAdministrativePenaltiesResponse GetAdministrativePenaltiesResponse
     */
    public function getAdministrativePenalties($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAdministrativePenaltiesHeaders([]);

        return $this->getAdministrativePenaltiesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 工商-基础信息
     *  *
     * @param GetBasicInfoRequest $request GetBasicInfoRequest
     * @param GetBasicInfoHeaders $headers GetBasicInfoHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetBasicInfoResponse GetBasicInfoResponse
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
     * @summary 工商-基础信息
     *  *
     * @param GetBasicInfoRequest $request GetBasicInfoRequest
     *
     * @return GetBasicInfoResponse GetBasicInfoResponse
     */
    public function getBasicInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetBasicInfoHeaders([]);

        return $this->getBasicInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取经营-招投标信息
     *  *
     * @param GetBiddingInfoRequest $request GetBiddingInfoRequest
     * @param GetBiddingInfoHeaders $headers GetBiddingInfoHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetBiddingInfoResponse GetBiddingInfoResponse
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
     * @summary 获取经营-招投标信息
     *  *
     * @param GetBiddingInfoRequest $request GetBiddingInfoRequest
     *
     * @return GetBiddingInfoResponse GetBiddingInfoResponse
     */
    public function getBiddingInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetBiddingInfoHeaders([]);

        return $this->getBiddingInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取工商-分支机构
     *  *
     * @param GetBranchInfoRequest $request GetBranchInfoRequest
     * @param GetBranchInfoHeaders $headers GetBranchInfoHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetBranchInfoResponse GetBranchInfoResponse
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
     * @summary 获取工商-分支机构
     *  *
     * @param GetBranchInfoRequest $request GetBranchInfoRequest
     *
     * @return GetBranchInfoResponse GetBranchInfoResponse
     */
    public function getBranchInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetBranchInfoHeaders([]);

        return $this->getBranchInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取工商-变更记录
     *  *
     * @param GetChangeRecordRequest $request GetChangeRecordRequest
     * @param GetChangeRecordHeaders $headers GetChangeRecordHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetChangeRecordResponse GetChangeRecordResponse
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
     * @summary 获取工商-变更记录
     *  *
     * @param GetChangeRecordRequest $request GetChangeRecordRequest
     *
     * @return GetChangeRecordResponse GetChangeRecordResponse
     */
    public function getChangeRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetChangeRecordHeaders([]);

        return $this->getChangeRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取投递任务信息
     *  *
     * @param GetDataDeliverRequest $request GetDataDeliverRequest
     * @param GetDataDeliverHeaders $headers GetDataDeliverHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDataDeliverResponse GetDataDeliverResponse
     */
    public function getDataDeliverWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deliverId)) {
            $query['deliverId'] = $request->deliverId;
        }
        if (!Utils::isUnset($request->dispatchingItemType)) {
            $query['dispatchingItemType'] = $request->dispatchingItemType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetDataDeliver',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/dataDeliverServices/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDataDeliverResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取投递任务信息
     *  *
     * @param GetDataDeliverRequest $request GetDataDeliverRequest
     *
     * @return GetDataDeliverResponse GetDataDeliverResponse
     */
    public function getDataDeliver($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDataDeliverHeaders([]);

        return $this->getDataDeliverWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取知识产权-域名信息
     *  *
     * @param GetDomainInfoRequest $request GetDomainInfoRequest
     * @param GetDomainInfoHeaders $headers GetDomainInfoHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDomainInfoResponse GetDomainInfoResponse
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
     * @summary 获取知识产权-域名信息
     *  *
     * @param GetDomainInfoRequest $request GetDomainInfoRequest
     *
     * @return GetDomainInfoResponse GetDomainInfoResponse
     */
    public function getDomainInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDomainInfoHeaders([]);

        return $this->getDomainInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取工商-双随机抽查结果
     *  *
     * @param GetDoubleRandomRequest $request GetDoubleRandomRequest
     * @param GetDoubleRandomHeaders $headers GetDoubleRandomHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDoubleRandomResponse GetDoubleRandomResponse
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
     * @summary 获取工商-双随机抽查结果
     *  *
     * @param GetDoubleRandomRequest $request GetDoubleRandomRequest
     *
     * @return GetDoubleRandomResponse GetDoubleRandomResponse
     */
    public function getDoubleRandom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDoubleRandomHeaders([]);

        return $this->getDoubleRandomWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 负面-环保处罚
     *  *
     * @param GetEnvironmentalPenaltiesRequest $request GetEnvironmentalPenaltiesRequest
     * @param GetEnvironmentalPenaltiesHeaders $headers GetEnvironmentalPenaltiesHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return GetEnvironmentalPenaltiesResponse GetEnvironmentalPenaltiesResponse
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
     * @summary 负面-环保处罚
     *  *
     * @param GetEnvironmentalPenaltiesRequest $request GetEnvironmentalPenaltiesRequest
     *
     * @return GetEnvironmentalPenaltiesResponse GetEnvironmentalPenaltiesResponse
     */
    public function getEnvironmentalPenalties($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetEnvironmentalPenaltiesHeaders([]);

        return $this->getEnvironmentalPenaltiesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取事件订阅的数据
     *  *
     * @param GetEventDataRequest $request GetEventDataRequest
     * @param GetEventDataHeaders $headers GetEventDataHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetEventDataResponse GetEventDataResponse
     */
    public function getEventDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->eventUid)) {
            $body['eventUid'] = $request->eventUid;
        }
        if (!Utils::isUnset($request->subId)) {
            $body['subId'] = $request->subId;
        }
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
            'action'      => 'GetEventData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/eventDatas/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetEventDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取事件订阅的数据
     *  *
     * @param GetEventDataRequest $request GetEventDataRequest
     *
     * @return GetEventDataResponse GetEventDataResponse
     */
    public function getEventData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetEventDataHeaders([]);

        return $this->getEventDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 工商-股东信息
     *  *
     * @param GetHolderInfoRequest $request GetHolderInfoRequest
     * @param GetHolderInfoHeaders $headers GetHolderInfoHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetHolderInfoResponse GetHolderInfoResponse
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
     * @summary 工商-股东信息
     *  *
     * @param GetHolderInfoRequest $request GetHolderInfoRequest
     *
     * @return GetHolderInfoResponse GetHolderInfoResponse
     */
    public function getHolderInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetHolderInfoHeaders([]);

        return $this->getHolderInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取工商-知识产权出质
     *  *
     * @param GetIntellectualPropertyRequest $request GetIntellectualPropertyRequest
     * @param GetIntellectualPropertyHeaders $headers GetIntellectualPropertyHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return GetIntellectualPropertyResponse GetIntellectualPropertyResponse
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
     * @summary 获取工商-知识产权出质
     *  *
     * @param GetIntellectualPropertyRequest $request GetIntellectualPropertyRequest
     *
     * @return GetIntellectualPropertyResponse GetIntellectualPropertyResponse
     */
    public function getIntellectualProperty($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetIntellectualPropertyHeaders([]);

        return $this->getIntellectualPropertyWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取工商-对外投资
     *  *
     * @param GetInvestmentAbroadRequest $request GetInvestmentAbroadRequest
     * @param GetInvestmentAbroadHeaders $headers GetInvestmentAbroadHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetInvestmentAbroadResponse GetInvestmentAbroadResponse
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
     * @summary 获取工商-对外投资
     *  *
     * @param GetInvestmentAbroadRequest $request GetInvestmentAbroadRequest
     *
     * @return GetInvestmentAbroadResponse GetInvestmentAbroadResponse
     */
    public function getInvestmentAbroad($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInvestmentAbroadHeaders([]);

        return $this->getInvestmentAbroadWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取经营-招聘信息
     *  *
     * @param GetJobInfoRequest $request GetJobInfoRequest
     * @param GetJobInfoHeaders $headers GetJobInfoHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetJobInfoResponse GetJobInfoResponse
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
     * @summary 获取经营-招聘信息
     *  *
     * @param GetJobInfoRequest $request GetJobInfoRequest
     *
     * @return GetJobInfoResponse GetJobInfoResponse
     */
    public function getJobInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetJobInfoHeaders([]);

        return $this->getJobInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取知识产权-专利信息
     *  *
     * @param GetPatentInfoRequest $request GetPatentInfoRequest
     * @param GetPatentInfoHeaders $headers GetPatentInfoHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPatentInfoResponse GetPatentInfoResponse
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
     * @summary 获取知识产权-专利信息
     *  *
     * @param GetPatentInfoRequest $request GetPatentInfoRequest
     *
     * @return GetPatentInfoResponse GetPatentInfoResponse
     */
    public function getPatentInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPatentInfoHeaders([]);

        return $this->getPatentInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取工商-主要人员
     *  *
     * @param GetPrincipalEmployeeRequest $request GetPrincipalEmployeeRequest
     * @param GetPrincipalEmployeeHeaders $headers GetPrincipalEmployeeHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPrincipalEmployeeResponse GetPrincipalEmployeeResponse
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
     * @summary 获取工商-主要人员
     *  *
     * @param GetPrincipalEmployeeRequest $request GetPrincipalEmployeeRequest
     *
     * @return GetPrincipalEmployeeResponse GetPrincipalEmployeeResponse
     */
    public function getPrincipalEmployee($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPrincipalEmployeeHeaders([]);

        return $this->getPrincipalEmployeeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 经营-一般纳税人
     *  *
     * @param GetQeneralTaxpayerInfoRequest $request GetQeneralTaxpayerInfoRequest
     * @param GetQeneralTaxpayerInfoHeaders $headers GetQeneralTaxpayerInfoHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetQeneralTaxpayerInfoResponse GetQeneralTaxpayerInfoResponse
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
     * @summary 经营-一般纳税人
     *  *
     * @param GetQeneralTaxpayerInfoRequest $request GetQeneralTaxpayerInfoRequest
     *
     * @return GetQeneralTaxpayerInfoResponse GetQeneralTaxpayerInfoResponse
     */
    public function getQeneralTaxpayerInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetQeneralTaxpayerInfoHeaders([]);

        return $this->getQeneralTaxpayerInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取知识产权-资质证书
     *  *
     * @param GetQualificationCertRequest $request GetQualificationCertRequest
     * @param GetQualificationCertHeaders $headers GetQualificationCertHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetQualificationCertResponse GetQualificationCertResponse
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
     * @summary 获取知识产权-资质证书
     *  *
     * @param GetQualificationCertRequest $request GetQualificationCertRequest
     *
     * @return GetQualificationCertResponse GetQualificationCertResponse
     */
    public function getQualificationCert($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetQualificationCertHeaders([]);

        return $this->getQualificationCertWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 负面-严重违法
     *  *
     * @param GetSeriousViolationRequest $request GetSeriousViolationRequest
     * @param GetSeriousViolationHeaders $headers GetSeriousViolationHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSeriousViolationResponse GetSeriousViolationResponse
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
     * @summary 负面-严重违法
     *  *
     * @param GetSeriousViolationRequest $request GetSeriousViolationRequest
     *
     * @return GetSeriousViolationResponse GetSeriousViolationResponse
     */
    public function getSeriousViolation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSeriousViolationHeaders([]);

        return $this->getSeriousViolationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取知识产权-软件著作权
     *  *
     * @param GetSoftwareCopyrightRequest $request GetSoftwareCopyrightRequest
     * @param GetSoftwareCopyrightHeaders $headers GetSoftwareCopyrightHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSoftwareCopyrightResponse GetSoftwareCopyrightResponse
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
     * @summary 获取知识产权-软件著作权
     *  *
     * @param GetSoftwareCopyrightRequest $request GetSoftwareCopyrightRequest
     *
     * @return GetSoftwareCopyrightResponse GetSoftwareCopyrightResponse
     */
    public function getSoftwareCopyright($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSoftwareCopyrightHeaders([]);

        return $this->getSoftwareCopyrightWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取知识产权-商标信息
     *  *
     * @param GetTrademarkInfoRequest $request GetTrademarkInfoRequest
     * @param GetTrademarkInfoHeaders $headers GetTrademarkInfoHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTrademarkInfoResponse GetTrademarkInfoResponse
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
     * @summary 获取知识产权-商标信息
     *  *
     * @param GetTrademarkInfoRequest $request GetTrademarkInfoRequest
     *
     * @return GetTrademarkInfoResponse GetTrademarkInfoResponse
     */
    public function getTrademarkInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTrademarkInfoHeaders([]);

        return $this->getTrademarkInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取知识产权-作品著作权
     *  *
     * @param GetWorkCopyrightRequest $request GetWorkCopyrightRequest
     * @param GetWorkCopyrightHeaders $headers GetWorkCopyrightHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetWorkCopyrightResponse GetWorkCopyrightResponse
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
     * @summary 获取知识产权-作品著作权
     *  *
     * @param GetWorkCopyrightRequest $request GetWorkCopyrightRequest
     *
     * @return GetWorkCopyrightResponse GetWorkCopyrightResponse
     */
    public function getWorkCopyright($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetWorkCopyrightHeaders([]);

        return $this->getWorkCopyrightWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 数据投递列表
     *  *
     * @param ListDataDeliversRequest $request ListDataDeliversRequest
     * @param ListDataDeliversHeaders $headers ListDataDeliversHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return ListDataDeliversResponse ListDataDeliversResponse
     */
    public function listDataDeliversWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->dispatchingItemType)) {
            $query['dispatchingItemType'] = $request->dispatchingItemType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListDataDelivers',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/dataDeliverServices/lists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListDataDeliversResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 数据投递列表
     *  *
     * @param ListDataDeliversRequest $request ListDataDeliversRequest
     *
     * @return ListDataDeliversResponse ListDataDeliversResponse
     */
    public function listDataDelivers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListDataDeliversHeaders([]);

        return $this->listDataDeliversWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 操作表格配置
     *  *
     * @param OperateChartConfigRequest $request OperateChartConfigRequest
     * @param OperateChartConfigHeaders $headers OperateChartConfigHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return OperateChartConfigResponse OperateChartConfigResponse
     */
    public function operateChartConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->apiKey)) {
            $body['apiKey'] = $request->apiKey;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->param)) {
            $body['param'] = $request->param;
        }
        if (!Utils::isUnset($request->ticket)) {
            $body['ticket'] = $request->ticket;
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
            'action'      => 'OperateChartConfig',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/chartConfigs/operate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return OperateChartConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 操作表格配置
     *  *
     * @param OperateChartConfigRequest $request OperateChartConfigRequest
     *
     * @return OperateChartConfigResponse OperateChartConfigResponse
     */
    public function operateChartConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OperateChartConfigHeaders([]);

        return $this->operateChartConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 企业授权信息
     *  *
     * @param PostCorpAuthInfoHeaders $headers PostCorpAuthInfoHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return PostCorpAuthInfoResponse PostCorpAuthInfoResponse
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
     * @summary 企业授权信息
     *  *
     * @return PostCorpAuthInfoResponse PostCorpAuthInfoResponse
     */
    public function postCorpAuthInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PostCorpAuthInfoHeaders([]);

        return $this->postCorpAuthInfoWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取企业用户激活状态统计数据
     *  *
     * @param QueryActiveUserStatisticalDataRequest $request QueryActiveUserStatisticalDataRequest
     * @param QueryActiveUserStatisticalDataHeaders $headers QueryActiveUserStatisticalDataHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryActiveUserStatisticalDataResponse QueryActiveUserStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryActiveUserStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业用户激活状态统计数据
     *  *
     * @param QueryActiveUserStatisticalDataRequest $request QueryActiveUserStatisticalDataRequest
     *
     * @return QueryActiveUserStatisticalDataResponse QueryActiveUserStatisticalDataResponse
     */
    public function queryActiveUserStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryActiveUserStatisticalDataHeaders([]);

        return $this->queryActiveUserStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取安恒密盾统计数据
     *  *
     * @param QueryAnhmdStatisticalDataRequest $request QueryAnhmdStatisticalDataRequest
     * @param QueryAnhmdStatisticalDataHeaders $headers QueryAnhmdStatisticalDataHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAnhmdStatisticalDataResponse QueryAnhmdStatisticalDataResponse
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
     * @summary 获取安恒密盾统计数据
     *  *
     * @param QueryAnhmdStatisticalDataRequest $request QueryAnhmdStatisticalDataRequest
     *
     * @return QueryAnhmdStatisticalDataResponse QueryAnhmdStatisticalDataResponse
     */
    public function queryAnhmdStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAnhmdStatisticalDataHeaders([]);

        return $this->queryAnhmdStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业审批统计数据
     *  *
     * @param QueryApprovalStatisticalDataRequest $request QueryApprovalStatisticalDataRequest
     * @param QueryApprovalStatisticalDataHeaders $headers QueryApprovalStatisticalDataHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryApprovalStatisticalDataResponse QueryApprovalStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryApprovalStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业审批统计数据
     *  *
     * @param QueryApprovalStatisticalDataRequest $request QueryApprovalStatisticalDataRequest
     *
     * @return QueryApprovalStatisticalDataResponse QueryApprovalStatisticalDataResponse
     */
    public function queryApprovalStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryApprovalStatisticalDataHeaders([]);

        return $this->queryApprovalStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业考勤统计数据
     *  *
     * @param QueryAttendanceStatisticalDataRequest $request QueryAttendanceStatisticalDataRequest
     * @param QueryAttendanceStatisticalDataHeaders $headers QueryAttendanceStatisticalDataHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAttendanceStatisticalDataResponse QueryAttendanceStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAttendanceStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业考勤统计数据
     *  *
     * @param QueryAttendanceStatisticalDataRequest $request QueryAttendanceStatisticalDataRequest
     *
     * @return QueryAttendanceStatisticalDataResponse QueryAttendanceStatisticalDataResponse
     */
    public function queryAttendanceStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAttendanceStatisticalDataHeaders([]);

        return $this->queryAttendanceStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业公告统计数据
     *  *
     * @param QueryBlackboardStatisticalDataRequest $request QueryBlackboardStatisticalDataRequest
     * @param QueryBlackboardStatisticalDataHeaders $headers QueryBlackboardStatisticalDataHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryBlackboardStatisticalDataResponse QueryBlackboardStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryBlackboardStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业公告统计数据
     *  *
     * @param QueryBlackboardStatisticalDataRequest $request QueryBlackboardStatisticalDataRequest
     *
     * @return QueryBlackboardStatisticalDataResponse QueryBlackboardStatisticalDataResponse
     */
    public function queryBlackboardStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBlackboardStatisticalDataHeaders([]);

        return $this->queryBlackboardStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业日程统计数据
     *  *
     * @param QueryCalendarStatisticalDataRequest $request QueryCalendarStatisticalDataRequest
     * @param QueryCalendarStatisticalDataHeaders $headers QueryCalendarStatisticalDataHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCalendarStatisticalDataResponse QueryCalendarStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCalendarStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业日程统计数据
     *  *
     * @param QueryCalendarStatisticalDataRequest $request QueryCalendarStatisticalDataRequest
     *
     * @return QueryCalendarStatisticalDataResponse QueryCalendarStatisticalDataResponse
     */
    public function queryCalendarStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCalendarStatisticalDataHeaders([]);

        return $this->queryCalendarStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取图表数据
     *  *
     * @param QueryChartDataRequest $request QueryChartDataRequest
     * @param QueryChartDataHeaders $headers QueryChartDataHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryChartDataResponse QueryChartDataResponse
     */
    public function queryChartDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->code)) {
            $body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->ticket)) {
            $body['ticket'] = $request->ticket;
        }
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
            'action'      => 'QueryChartData',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/chartDatas/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryChartDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取图表数据
     *  *
     * @param QueryChartDataRequest $request QueryChartDataRequest
     *
     * @return QueryChartDataResponse QueryChartDataResponse
     */
    public function queryChartData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryChartDataHeaders([]);

        return $this->queryChartDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业签到统计数据
     *  *
     * @param QueryCheckinStatisticalDataRequest $request QueryCheckinStatisticalDataRequest
     * @param QueryCheckinStatisticalDataHeaders $headers QueryCheckinStatisticalDataHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCheckinStatisticalDataResponse QueryCheckinStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCheckinStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业签到统计数据
     *  *
     * @param QueryCheckinStatisticalDataRequest $request QueryCheckinStatisticalDataRequest
     *
     * @return QueryCheckinStatisticalDataResponse QueryCheckinStatisticalDataResponse
     */
    public function queryCheckinStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCheckinStatisticalDataHeaders([]);

        return $this->queryCheckinStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业全员圈统计数据
     *  *
     * @param QueryCircleStatisticalDataRequest $request QueryCircleStatisticalDataRequest
     * @param QueryCircleStatisticalDataHeaders $headers QueryCircleStatisticalDataHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCircleStatisticalDataResponse QueryCircleStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCircleStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业全员圈统计数据
     *  *
     * @param QueryCircleStatisticalDataRequest $request QueryCircleStatisticalDataRequest
     *
     * @return QueryCircleStatisticalDataResponse QueryCircleStatisticalDataResponse
     */
    public function queryCircleStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCircleStatisticalDataHeaders([]);

        return $this->queryCircleStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。
     *  *
     * @param QueryCompanyBasicInfoRequest $request QueryCompanyBasicInfoRequest
     * @param QueryCompanyBasicInfoHeaders $headers QueryCompanyBasicInfoHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCompanyBasicInfoResponse QueryCompanyBasicInfoResponse
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
     * @summary 通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。
     *  *
     * @param QueryCompanyBasicInfoRequest $request QueryCompanyBasicInfoRequest
     *
     * @return QueryCompanyBasicInfoResponse QueryCompanyBasicInfoResponse
     */
    public function queryCompanyBasicInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCompanyBasicInfoHeaders([]);

        return $this->queryCompanyBasicInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取数字区县组织信息
     *  *
     * @param QueryDigitalDistrictOrgInfoRequest $request QueryDigitalDistrictOrgInfoRequest
     * @param QueryDigitalDistrictOrgInfoHeaders $headers QueryDigitalDistrictOrgInfoHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDigitalDistrictOrgInfoResponse QueryDigitalDistrictOrgInfoResponse
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
     * @summary 获取数字区县组织信息
     *  *
     * @param QueryDigitalDistrictOrgInfoRequest $request QueryDigitalDistrictOrgInfoRequest
     *
     * @return QueryDigitalDistrictOrgInfoResponse QueryDigitalDistrictOrgInfoResponse
     */
    public function queryDigitalDistrictOrgInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDigitalDistrictOrgInfoHeaders([]);

        return $this->queryDigitalDistrictOrgInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业DING接收及评论统计数据
     *  *
     * @param QueryDingReciveStatisticalDataRequest $request QueryDingReciveStatisticalDataRequest
     * @param QueryDingReciveStatisticalDataHeaders $headers QueryDingReciveStatisticalDataHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDingReciveStatisticalDataResponse QueryDingReciveStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryDingReciveStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业DING接收及评论统计数据
     *  *
     * @param QueryDingReciveStatisticalDataRequest $request QueryDingReciveStatisticalDataRequest
     *
     * @return QueryDingReciveStatisticalDataResponse QueryDingReciveStatisticalDataResponse
     */
    public function queryDingReciveStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDingReciveStatisticalDataHeaders([]);

        return $this->queryDingReciveStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业DING发送统计数据
     *  *
     * @param QueryDingSendStatisticalDataRequest $request QueryDingSendStatisticalDataRequest
     * @param QueryDingSendStatisticalDataHeaders $headers QueryDingSendStatisticalDataHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDingSendStatisticalDataResponse QueryDingSendStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryDingSendStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业DING发送统计数据
     *  *
     * @param QueryDingSendStatisticalDataRequest $request QueryDingSendStatisticalDataRequest
     *
     * @return QueryDingSendStatisticalDataResponse QueryDingSendStatisticalDataResponse
     */
    public function queryDingSendStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDingSendStatisticalDataHeaders([]);

        return $this->queryDingSendStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业文档统计数据
     *  *
     * @param QueryDocumentStatisticalDataRequest $request QueryDocumentStatisticalDataRequest
     * @param QueryDocumentStatisticalDataHeaders $headers QueryDocumentStatisticalDataHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDocumentStatisticalDataResponse QueryDocumentStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryDocumentStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业文档统计数据
     *  *
     * @param QueryDocumentStatisticalDataRequest $request QueryDocumentStatisticalDataRequest
     *
     * @return QueryDocumentStatisticalDataResponse QueryDocumentStatisticalDataResponse
     */
    public function queryDocumentStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDocumentStatisticalDataHeaders([]);

        return $this->queryDocumentStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询数据资产平台增购包购买信息
     *  *
     * @param QueryDpaasDataPackageHeaders $headers QueryDpaasDataPackageHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDpaasDataPackageResponse QueryDpaasDataPackageResponse
     */
    public function queryDpaasDataPackageWithOptions($headers, $runtime)
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
            'action'      => 'QueryDpaasDataPackage',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/dpaas/dataPackages/purchaseInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryDpaasDataPackageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询数据资产平台增购包购买信息
     *  *
     * @return QueryDpaasDataPackageResponse QueryDpaasDataPackageResponse
     */
    public function queryDpaasDataPackage()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDpaasDataPackageHeaders([]);

        return $this->queryDpaasDataPackageWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取企业钉盘统计数据
     *  *
     * @param QueryDriveStatisticalDataRequest $request QueryDriveStatisticalDataRequest
     * @param QueryDriveStatisticalDataHeaders $headers QueryDriveStatisticalDataHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDriveStatisticalDataResponse QueryDriveStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryDriveStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业钉盘统计数据
     *  *
     * @param QueryDriveStatisticalDataRequest $request QueryDriveStatisticalDataRequest
     *
     * @return QueryDriveStatisticalDataResponse QueryDriveStatisticalDataResponse
     */
    public function queryDriveStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDriveStatisticalDataHeaders([]);

        return $this->queryDriveStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业员工类型统计数据
     *  *
     * @param QueryEmployeeTypeStatisticalDataRequest $request QueryEmployeeTypeStatisticalDataRequest
     * @param QueryEmployeeTypeStatisticalDataHeaders $headers QueryEmployeeTypeStatisticalDataHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryEmployeeTypeStatisticalDataResponse QueryEmployeeTypeStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryEmployeeTypeStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业员工类型统计数据
     *  *
     * @param QueryEmployeeTypeStatisticalDataRequest $request QueryEmployeeTypeStatisticalDataRequest
     *
     * @return QueryEmployeeTypeStatisticalDataResponse QueryEmployeeTypeStatisticalDataResponse
     */
    public function queryEmployeeTypeStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryEmployeeTypeStatisticalDataHeaders([]);

        return $this->queryEmployeeTypeStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 数据资产平台数据服务接口
     *  *
     * @param QueryGeneralDataServiceRequest $request QueryGeneralDataServiceRequest
     * @param QueryGeneralDataServiceHeaders $headers QueryGeneralDataServiceHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGeneralDataServiceResponse QueryGeneralDataServiceResponse
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
        if (!Utils::isUnset($request->returnTotal)) {
            $query['returnTotal'] = $request->returnTotal;
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
     * @summary 数据资产平台数据服务接口
     *  *
     * @param QueryGeneralDataServiceRequest $request QueryGeneralDataServiceRequest
     *
     * @return QueryGeneralDataServiceResponse QueryGeneralDataServiceResponse
     */
    public function queryGeneralDataService($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGeneralDataServiceHeaders([]);

        return $this->queryGeneralDataServiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 数据资产平台数据服务接口(支持部门、员工维度批量拉取)
     *  *
     * @param QueryGeneralDataServiceBatchRequest $request QueryGeneralDataServiceBatchRequest
     * @param QueryGeneralDataServiceBatchHeaders $headers QueryGeneralDataServiceBatchHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGeneralDataServiceBatchResponse QueryGeneralDataServiceBatchResponse
     */
    public function queryGeneralDataServiceBatchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptIds)) {
            $body['deptIds'] = $request->deptIds;
        }
        if (!Utils::isUnset($request->endDate)) {
            $body['endDate'] = $request->endDate;
        }
        if (!Utils::isUnset($request->filters)) {
            $body['filters'] = $request->filters;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->returnTotal)) {
            $body['returnTotal'] = $request->returnTotal;
        }
        if (!Utils::isUnset($request->serviceId)) {
            $body['serviceId'] = $request->serviceId;
        }
        if (!Utils::isUnset($request->startDate)) {
            $body['startDate'] = $request->startDate;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action'      => 'QueryGeneralDataServiceBatch',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/dataServices/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryGeneralDataServiceBatchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 数据资产平台数据服务接口(支持部门、员工维度批量拉取)
     *  *
     * @param QueryGeneralDataServiceBatchRequest $request QueryGeneralDataServiceBatchRequest
     *
     * @return QueryGeneralDataServiceBatchResponse QueryGeneralDataServiceBatchResponse
     */
    public function queryGeneralDataServiceBatch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGeneralDataServiceBatchHeaders([]);

        return $this->queryGeneralDataServiceBatchWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 数据资产平台数据服务接口(查询数据更新日期)
     *  *
     * @param QueryGeneralDataUpdateDateRequest $request QueryGeneralDataUpdateDateRequest
     * @param QueryGeneralDataUpdateDateHeaders $headers QueryGeneralDataUpdateDateHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGeneralDataUpdateDateResponse QueryGeneralDataUpdateDateResponse
     */
    public function queryGeneralDataUpdateDateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->serviceId)) {
            $query['serviceId'] = $request->serviceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryGeneralDataUpdateDate',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/dataUpdateDates',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryGeneralDataUpdateDateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 数据资产平台数据服务接口(查询数据更新日期)
     *  *
     * @param QueryGeneralDataUpdateDateRequest $request QueryGeneralDataUpdateDateRequest
     *
     * @return QueryGeneralDataUpdateDateResponse QueryGeneralDataUpdateDateResponse
     */
    public function queryGeneralDataUpdateDate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGeneralDataUpdateDateHeaders([]);

        return $this->queryGeneralDataUpdateDateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业群直播统计数据
     *  *
     * @param QueryGroupLiveStatisticalDataRequest $request QueryGroupLiveStatisticalDataRequest
     * @param QueryGroupLiveStatisticalDataHeaders $headers QueryGroupLiveStatisticalDataHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGroupLiveStatisticalDataResponse QueryGroupLiveStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryGroupLiveStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业群直播统计数据
     *  *
     * @param QueryGroupLiveStatisticalDataRequest $request QueryGroupLiveStatisticalDataRequest
     *
     * @return QueryGroupLiveStatisticalDataResponse QueryGroupLiveStatisticalDataResponse
     */
    public function queryGroupLiveStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupLiveStatisticalDataHeaders([]);

        return $this->queryGroupLiveStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业群聊统计数据
     *  *
     * @param QueryGroupMessageStatisticalDataRequest $request QueryGroupMessageStatisticalDataRequest
     * @param QueryGroupMessageStatisticalDataHeaders $headers QueryGroupMessageStatisticalDataHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGroupMessageStatisticalDataResponse QueryGroupMessageStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryGroupMessageStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业群聊统计数据
     *  *
     * @param QueryGroupMessageStatisticalDataRequest $request QueryGroupMessageStatisticalDataRequest
     *
     * @return QueryGroupMessageStatisticalDataResponse QueryGroupMessageStatisticalDataResponse
     */
    public function queryGroupMessageStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupMessageStatisticalDataHeaders([]);

        return $this->queryGroupMessageStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业钉钉运动统计数据
     *  *
     * @param QueryHealthStatisticalDataRequest $request QueryHealthStatisticalDataRequest
     * @param QueryHealthStatisticalDataHeaders $headers QueryHealthStatisticalDataHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryHealthStatisticalDataResponse QueryHealthStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryHealthStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业钉钉运动统计数据
     *  *
     * @param QueryHealthStatisticalDataRequest $request QueryHealthStatisticalDataRequest
     *
     * @return QueryHealthStatisticalDataResponse QueryHealthStatisticalDataResponse
     */
    public function queryHealthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHealthStatisticalDataHeaders([]);

        return $this->queryHealthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业邮箱统计数据
     *  *
     * @param QueryMailStatisticalDataRequest $request QueryMailStatisticalDataRequest
     * @param QueryMailStatisticalDataHeaders $headers QueryMailStatisticalDataHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryMailStatisticalDataResponse QueryMailStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryMailStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业邮箱统计数据
     *  *
     * @param QueryMailStatisticalDataRequest $request QueryMailStatisticalDataRequest
     *
     * @return QueryMailStatisticalDataResponse QueryMailStatisticalDataResponse
     */
    public function queryMailStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMailStatisticalDataHeaders([]);

        return $this->queryMailStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取官方数据集数据
     *  *
     * @param QueryOfficialDataRequest $request QueryOfficialDataRequest
     * @param QueryOfficialDataHeaders $headers QueryOfficialDataHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOfficialDataResponse QueryOfficialDataResponse
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
     * @summary 获取官方数据集数据
     *  *
     * @param QueryOfficialDataRequest $request QueryOfficialDataRequest
     *
     * @return QueryOfficialDataResponse QueryOfficialDataResponse
     */
    public function queryOfficialData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOfficialDataHeaders([]);

        return $this->queryOfficialDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary ISV获取官方数据集字段信息
     *  *
     * @param QueryOfficialDatasetFieldsRequest $request QueryOfficialDatasetFieldsRequest
     * @param QueryOfficialDatasetFieldsHeaders $headers QueryOfficialDatasetFieldsHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOfficialDatasetFieldsResponse QueryOfficialDatasetFieldsResponse
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
     * @summary ISV获取官方数据集字段信息
     *  *
     * @param QueryOfficialDatasetFieldsRequest $request QueryOfficialDatasetFieldsRequest
     *
     * @return QueryOfficialDatasetFieldsResponse QueryOfficialDatasetFieldsResponse
     */
    public function queryOfficialDatasetFields($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOfficialDatasetFieldsHeaders([]);

        return $this->queryOfficialDatasetFieldsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary ISV获取官方数据集列表
     *  *
     * @param QueryOfficialDatasetListRequest $request QueryOfficialDatasetListRequest
     * @param QueryOfficialDatasetListHeaders $headers QueryOfficialDatasetListHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOfficialDatasetListResponse QueryOfficialDatasetListResponse
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
     * @summary ISV获取官方数据集列表
     *  *
     * @param QueryOfficialDatasetListRequest $request QueryOfficialDatasetListRequest
     *
     * @return QueryOfficialDatasetListResponse QueryOfficialDatasetListResponse
     */
    public function queryOfficialDatasetList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOfficialDatasetListHeaders([]);

        return $this->queryOfficialDatasetListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取官方数据集数据
     *  *
     * @param QueryOfficialFormDataRequest $request QueryOfficialFormDataRequest
     * @param QueryOfficialFormDataHeaders $headers QueryOfficialFormDataHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOfficialFormDataResponse QueryOfficialFormDataResponse
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
     * @summary 获取官方数据集数据
     *  *
     * @param QueryOfficialFormDataRequest $request QueryOfficialFormDataRequest
     *
     * @return QueryOfficialFormDataResponse QueryOfficialFormDataResponse
     */
    public function queryOfficialFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOfficialFormDataHeaders([]);

        return $this->queryOfficialFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取HOLO中官方OA表单数据集数据
     *  *
     * @param QueryOfficialFormDataDirectHoloRequest $request QueryOfficialFormDataDirectHoloRequest
     * @param QueryOfficialFormDataDirectHoloHeaders $headers QueryOfficialFormDataDirectHoloHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOfficialFormDataDirectHoloResponse QueryOfficialFormDataDirectHoloResponse
     */
    public function queryOfficialFormDataDirectHoloWithOptions($request, $headers, $runtime)
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
            'action'      => 'QueryOfficialFormDataDirectHolo',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/oaDatas/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryOfficialFormDataDirectHoloResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取HOLO中官方OA表单数据集数据
     *  *
     * @param QueryOfficialFormDataDirectHoloRequest $request QueryOfficialFormDataDirectHoloRequest
     *
     * @return QueryOfficialFormDataDirectHoloResponse QueryOfficialFormDataDirectHoloResponse
     */
    public function queryOfficialFormDataDirectHolo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOfficialFormDataDirectHoloHeaders([]);

        return $this->queryOfficialFormDataDirectHoloWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业用户在线统计数据
     *  *
     * @param QueryOnlineUserStatisticalDataRequest $request QueryOnlineUserStatisticalDataRequest
     * @param QueryOnlineUserStatisticalDataHeaders $headers QueryOnlineUserStatisticalDataHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOnlineUserStatisticalDataResponse QueryOnlineUserStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryOnlineUserStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业用户在线统计数据
     *  *
     * @param QueryOnlineUserStatisticalDataRequest $request QueryOnlineUserStatisticalDataRequest
     *
     * @return QueryOnlineUserStatisticalDataResponse QueryOnlineUserStatisticalDataResponse
     */
    public function queryOnlineUserStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOnlineUserStatisticalDataHeaders([]);

        return $this->queryOnlineUserStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业接收红包统计数据
     *  *
     * @param QueryRedEnvelopeReciveStatisticalDataRequest $request QueryRedEnvelopeReciveStatisticalDataRequest
     * @param QueryRedEnvelopeReciveStatisticalDataHeaders $headers QueryRedEnvelopeReciveStatisticalDataHeaders
     * @param RuntimeOptions                               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryRedEnvelopeReciveStatisticalDataResponse QueryRedEnvelopeReciveStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryRedEnvelopeReciveStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业接收红包统计数据
     *  *
     * @param QueryRedEnvelopeReciveStatisticalDataRequest $request QueryRedEnvelopeReciveStatisticalDataRequest
     *
     * @return QueryRedEnvelopeReciveStatisticalDataResponse QueryRedEnvelopeReciveStatisticalDataResponse
     */
    public function queryRedEnvelopeReciveStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRedEnvelopeReciveStatisticalDataHeaders([]);

        return $this->queryRedEnvelopeReciveStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业发送红包统计数据
     *  *
     * @param QueryRedEnvelopeSendStatisticalDataRequest $request QueryRedEnvelopeSendStatisticalDataRequest
     * @param QueryRedEnvelopeSendStatisticalDataHeaders $headers QueryRedEnvelopeSendStatisticalDataHeaders
     * @param RuntimeOptions                             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryRedEnvelopeSendStatisticalDataResponse QueryRedEnvelopeSendStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryRedEnvelopeSendStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业发送红包统计数据
     *  *
     * @param QueryRedEnvelopeSendStatisticalDataRequest $request QueryRedEnvelopeSendStatisticalDataRequest
     *
     * @return QueryRedEnvelopeSendStatisticalDataResponse QueryRedEnvelopeSendStatisticalDataResponse
     */
    public function queryRedEnvelopeSendStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRedEnvelopeSendStatisticalDataHeaders([]);

        return $this->queryRedEnvelopeSendStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业日志统计数据
     *  *
     * @param QueryReportStatisticalDataRequest $request QueryReportStatisticalDataRequest
     * @param QueryReportStatisticalDataHeaders $headers QueryReportStatisticalDataHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryReportStatisticalDataResponse QueryReportStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryReportStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业日志统计数据
     *  *
     * @param QueryReportStatisticalDataRequest $request QueryReportStatisticalDataRequest
     *
     * @return QueryReportStatisticalDataResponse QueryReportStatisticalDataResponse
     */
    public function queryReportStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryReportStatisticalDataHeaders([]);

        return $this->queryReportStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询数据大屏
     *  *
     * @param QueryScreenRequest $request QueryScreenRequest
     * @param QueryScreenHeaders $headers QueryScreenHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryScreenResponse QueryScreenResponse
     */
    public function queryScreenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryScreen',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/screens',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryScreenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询数据大屏
     *  *
     * @param QueryScreenRequest $request QueryScreenRequest
     *
     * @return QueryScreenResponse QueryScreenResponse
     */
    public function queryScreen($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryScreenHeaders([]);

        return $this->queryScreenWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询数据大屏模版
     *  *
     * @param QueryScreenTemplateRequest $request QueryScreenTemplateRequest
     * @param QueryScreenTemplateHeaders $headers QueryScreenTemplateHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryScreenTemplateResponse QueryScreenTemplateResponse
     */
    public function queryScreenTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->sample)) {
            $query['sample'] = $request->sample;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryScreenTemplate',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/screenTemplates',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryScreenTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询数据大屏模版
     *  *
     * @param QueryScreenTemplateRequest $request QueryScreenTemplateRequest
     *
     * @return QueryScreenTemplateResponse QueryScreenTemplateResponse
     */
    public function queryScreenTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryScreenTemplateHeaders([]);

        return $this->queryScreenTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业单聊统计数据
     *  *
     * @param QuerySingleMessageStatisticalDataRequest $request QuerySingleMessageStatisticalDataRequest
     * @param QuerySingleMessageStatisticalDataHeaders $headers QuerySingleMessageStatisticalDataHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return QuerySingleMessageStatisticalDataResponse QuerySingleMessageStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QuerySingleMessageStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业单聊统计数据
     *  *
     * @param QuerySingleMessageStatisticalDataRequest $request QuerySingleMessageStatisticalDataRequest
     *
     * @return QuerySingleMessageStatisticalDataResponse QuerySingleMessageStatisticalDataResponse
     */
    public function querySingleMessageStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySingleMessageStatisticalDataHeaders([]);

        return $this->querySingleMessageStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业电话会议统计数据
     *  *
     * @param QueryTelMeetingStatisticalDataRequest $request QueryTelMeetingStatisticalDataRequest
     * @param QueryTelMeetingStatisticalDataHeaders $headers QueryTelMeetingStatisticalDataHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryTelMeetingStatisticalDataResponse QueryTelMeetingStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryTelMeetingStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业电话会议统计数据
     *  *
     * @param QueryTelMeetingStatisticalDataRequest $request QueryTelMeetingStatisticalDataRequest
     *
     * @return QueryTelMeetingStatisticalDataResponse QueryTelMeetingStatisticalDataResponse
     */
    public function queryTelMeetingStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTelMeetingStatisticalDataHeaders([]);

        return $this->queryTelMeetingStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业待办统计数据
     *  *
     * @param QueryTodoStatisticalDataRequest $request QueryTodoStatisticalDataRequest
     * @param QueryTodoStatisticalDataHeaders $headers QueryTodoStatisticalDataHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryTodoStatisticalDataResponse QueryTodoStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryTodoStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业待办统计数据
     *  *
     * @param QueryTodoStatisticalDataRequest $request QueryTodoStatisticalDataRequest
     *
     * @return QueryTodoStatisticalDataResponse QueryTodoStatisticalDataResponse
     */
    public function queryTodoStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTodoStatisticalDataHeaders([]);

        return $this->queryTodoStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 数据资产平台查询数据记录数
     *  *
     * @param QueryTotalDataCountServiceRequest $request QueryTotalDataCountServiceRequest
     * @param QueryTotalDataCountServiceHeaders $headers QueryTotalDataCountServiceHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryTotalDataCountServiceResponse QueryTotalDataCountServiceResponse
     */
    public function queryTotalDataCountServiceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptIds)) {
            $body['deptIds'] = $request->deptIds;
        }
        if (!Utils::isUnset($request->endDate)) {
            $body['endDate'] = $request->endDate;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->serviceId)) {
            $body['serviceId'] = $request->serviceId;
        }
        if (!Utils::isUnset($request->startDate)) {
            $body['startDate'] = $request->startDate;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action'      => 'QueryTotalDataCountService',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/datas/totalCounts/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryTotalDataCountServiceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 数据资产平台查询数据记录数
     *  *
     * @param QueryTotalDataCountServiceRequest $request QueryTotalDataCountServiceRequest
     *
     * @return QueryTotalDataCountServiceResponse QueryTotalDataCountServiceResponse
     */
    public function queryTotalDataCountService($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTotalDataCountServiceHeaders([]);

        return $this->queryTotalDataCountServiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业视频会议统计数据
     *  *
     * @param QueryVedioMeetingStatisticalDataRequest $request QueryVedioMeetingStatisticalDataRequest
     * @param QueryVedioMeetingStatisticalDataHeaders $headers QueryVedioMeetingStatisticalDataHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryVedioMeetingStatisticalDataResponse QueryVedioMeetingStatisticalDataResponse
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
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryVedioMeetingStatisticalDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取企业视频会议统计数据
     *  *
     * @param QueryVedioMeetingStatisticalDataRequest $request QueryVedioMeetingStatisticalDataRequest
     *
     * @return QueryVedioMeetingStatisticalDataResponse QueryVedioMeetingStatisticalDataResponse
     */
    public function queryVedioMeetingStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryVedioMeetingStatisticalDataHeaders([]);

        return $this->queryVedioMeetingStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉参谋活跃分析（按日统计）指标接口
     *  *
     * @param QueryYydActiveDayStatisticalDataRequest $request QueryYydActiveDayStatisticalDataRequest
     * @param QueryYydActiveDayStatisticalDataHeaders $headers QueryYydActiveDayStatisticalDataHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydActiveDayStatisticalDataResponse QueryYydActiveDayStatisticalDataResponse
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
     * @summary 亚运钉参谋活跃分析（按日统计）指标接口
     *  *
     * @param QueryYydActiveDayStatisticalDataRequest $request QueryYydActiveDayStatisticalDataRequest
     *
     * @return QueryYydActiveDayStatisticalDataResponse QueryYydActiveDayStatisticalDataResponse
     */
    public function queryYydActiveDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydActiveDayStatisticalDataHeaders([]);

        return $this->queryYydActiveDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉参谋活跃分析（按月统计）指标接口
     *  *
     * @param QueryYydActiveMonthStatisticalDataRequest $request QueryYydActiveMonthStatisticalDataRequest
     * @param QueryYydActiveMonthStatisticalDataHeaders $headers QueryYydActiveMonthStatisticalDataHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydActiveMonthStatisticalDataResponse QueryYydActiveMonthStatisticalDataResponse
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
     * @summary 亚运钉参谋活跃分析（按月统计）指标接口
     *  *
     * @param QueryYydActiveMonthStatisticalDataRequest $request QueryYydActiveMonthStatisticalDataRequest
     *
     * @return QueryYydActiveMonthStatisticalDataResponse QueryYydActiveMonthStatisticalDataResponse
     */
    public function queryYydActiveMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydActiveMonthStatisticalDataHeaders([]);

        return $this->queryYydActiveMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉参谋活跃分析（按周统计）指标接口
     *  *
     * @param QueryYydActiveWeekStatisticalDataRequest $request QueryYydActiveWeekStatisticalDataRequest
     * @param QueryYydActiveWeekStatisticalDataHeaders $headers QueryYydActiveWeekStatisticalDataHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydActiveWeekStatisticalDataResponse QueryYydActiveWeekStatisticalDataResponse
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
     * @summary 亚运钉参谋活跃分析（按周统计）指标接口
     *  *
     * @param QueryYydActiveWeekStatisticalDataRequest $request QueryYydActiveWeekStatisticalDataRequest
     *
     * @return QueryYydActiveWeekStatisticalDataResponse QueryYydActiveWeekStatisticalDataResponse
     */
    public function queryYydActiveWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydActiveWeekStatisticalDataHeaders([]);

        return $this->queryYydActiveWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋应用概况（按日统计）指标接口
     *  *
     * @param QueryYydAppDayStatisticalDataRequest $request QueryYydAppDayStatisticalDataRequest
     * @param QueryYydAppDayStatisticalDataHeaders $headers QueryYydAppDayStatisticalDataHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydAppDayStatisticalDataResponse QueryYydAppDayStatisticalDataResponse
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
     * @summary 亚运钉数字参谋应用概况（按日统计）指标接口
     *  *
     * @param QueryYydAppDayStatisticalDataRequest $request QueryYydAppDayStatisticalDataRequest
     *
     * @return QueryYydAppDayStatisticalDataResponse QueryYydAppDayStatisticalDataResponse
     */
    public function queryYydAppDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydAppDayStatisticalDataHeaders([]);

        return $this->queryYydAppDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋应用概况（按月统计）指标接口
     *  *
     * @param QueryYydAppMonthStatisticalDataRequest $request QueryYydAppMonthStatisticalDataRequest
     * @param QueryYydAppMonthStatisticalDataHeaders $headers QueryYydAppMonthStatisticalDataHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydAppMonthStatisticalDataResponse QueryYydAppMonthStatisticalDataResponse
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
     * @summary 亚运钉数字参谋应用概况（按月统计）指标接口
     *  *
     * @param QueryYydAppMonthStatisticalDataRequest $request QueryYydAppMonthStatisticalDataRequest
     *
     * @return QueryYydAppMonthStatisticalDataResponse QueryYydAppMonthStatisticalDataResponse
     */
    public function queryYydAppMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydAppMonthStatisticalDataHeaders([]);

        return $this->queryYydAppMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋应用概况（累计）指标接口
     *  *
     * @param QueryYydAppStdStatisticalDataRequest $request QueryYydAppStdStatisticalDataRequest
     * @param QueryYydAppStdStatisticalDataHeaders $headers QueryYydAppStdStatisticalDataHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydAppStdStatisticalDataResponse QueryYydAppStdStatisticalDataResponse
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
     * @summary 亚运钉数字参谋应用概况（累计）指标接口
     *  *
     * @param QueryYydAppStdStatisticalDataRequest $request QueryYydAppStdStatisticalDataRequest
     *
     * @return QueryYydAppStdStatisticalDataResponse QueryYydAppStdStatisticalDataResponse
     */
    public function queryYydAppStdStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydAppStdStatisticalDataHeaders([]);

        return $this->queryYydAppStdStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋应用概况（按周统计）指标接口
     *  *
     * @param QueryYydAppWeekStatisticalDataRequest $request QueryYydAppWeekStatisticalDataRequest
     * @param QueryYydAppWeekStatisticalDataHeaders $headers QueryYydAppWeekStatisticalDataHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydAppWeekStatisticalDataResponse QueryYydAppWeekStatisticalDataResponse
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
     * @summary 亚运钉数字参谋应用概况（按周统计）指标接口
     *  *
     * @param QueryYydAppWeekStatisticalDataRequest $request QueryYydAppWeekStatisticalDataRequest
     *
     * @return QueryYydAppWeekStatisticalDataResponse QueryYydAppWeekStatisticalDataResponse
     */
    public function queryYydAppWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydAppWeekStatisticalDataHeaders([]);

        return $this->queryYydAppWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋会议日程分析（按日统计）指标接口
     *  *
     * @param QueryYydCalendarDayStatisticalDataRequest $request QueryYydCalendarDayStatisticalDataRequest
     * @param QueryYydCalendarDayStatisticalDataHeaders $headers QueryYydCalendarDayStatisticalDataHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydCalendarDayStatisticalDataResponse QueryYydCalendarDayStatisticalDataResponse
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
     * @summary 亚运钉数字参谋会议日程分析（按日统计）指标接口
     *  *
     * @param QueryYydCalendarDayStatisticalDataRequest $request QueryYydCalendarDayStatisticalDataRequest
     *
     * @return QueryYydCalendarDayStatisticalDataResponse QueryYydCalendarDayStatisticalDataResponse
     */
    public function queryYydCalendarDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydCalendarDayStatisticalDataHeaders([]);

        return $this->queryYydCalendarDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋会议日程分析（按月统计）指标接口
     *  *
     * @param QueryYydCalendarMonthStatisticalDataRequest $request QueryYydCalendarMonthStatisticalDataRequest
     * @param QueryYydCalendarMonthStatisticalDataHeaders $headers QueryYydCalendarMonthStatisticalDataHeaders
     * @param RuntimeOptions                              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydCalendarMonthStatisticalDataResponse QueryYydCalendarMonthStatisticalDataResponse
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
     * @summary 亚运钉数字参谋会议日程分析（按月统计）指标接口
     *  *
     * @param QueryYydCalendarMonthStatisticalDataRequest $request QueryYydCalendarMonthStatisticalDataRequest
     *
     * @return QueryYydCalendarMonthStatisticalDataResponse QueryYydCalendarMonthStatisticalDataResponse
     */
    public function queryYydCalendarMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydCalendarMonthStatisticalDataHeaders([]);

        return $this->queryYydCalendarMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋会议日程分析（按周统计）指标接口
     *  *
     * @param QueryYydCalendarWeekStatisticalDataRequest $request QueryYydCalendarWeekStatisticalDataRequest
     * @param QueryYydCalendarWeekStatisticalDataHeaders $headers QueryYydCalendarWeekStatisticalDataHeaders
     * @param RuntimeOptions                             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydCalendarWeekStatisticalDataResponse QueryYydCalendarWeekStatisticalDataResponse
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
     * @summary 亚运钉数字参谋会议日程分析（按周统计）指标接口
     *  *
     * @param QueryYydCalendarWeekStatisticalDataRequest $request QueryYydCalendarWeekStatisticalDataRequest
     *
     * @return QueryYydCalendarWeekStatisticalDataResponse QueryYydCalendarWeekStatisticalDataResponse
     */
    public function queryYydCalendarWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydCalendarWeekStatisticalDataHeaders([]);

        return $this->queryYydCalendarWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋钉消息分析（按日统计）指标接口
     *  *
     * @param QueryYydDingMsgDayStatisticalDataRequest $request QueryYydDingMsgDayStatisticalDataRequest
     * @param QueryYydDingMsgDayStatisticalDataHeaders $headers QueryYydDingMsgDayStatisticalDataHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydDingMsgDayStatisticalDataResponse QueryYydDingMsgDayStatisticalDataResponse
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
     * @summary 亚运钉数字参谋钉消息分析（按日统计）指标接口
     *  *
     * @param QueryYydDingMsgDayStatisticalDataRequest $request QueryYydDingMsgDayStatisticalDataRequest
     *
     * @return QueryYydDingMsgDayStatisticalDataResponse QueryYydDingMsgDayStatisticalDataResponse
     */
    public function queryYydDingMsgDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydDingMsgDayStatisticalDataHeaders([]);

        return $this->queryYydDingMsgDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋钉消息分析（按月统计）指标接口
     *  *
     * @param QueryYydDingMsgMonthStatisticalDataRequest $request QueryYydDingMsgMonthStatisticalDataRequest
     * @param QueryYydDingMsgMonthStatisticalDataHeaders $headers QueryYydDingMsgMonthStatisticalDataHeaders
     * @param RuntimeOptions                             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydDingMsgMonthStatisticalDataResponse QueryYydDingMsgMonthStatisticalDataResponse
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
     * @summary 亚运钉数字参谋钉消息分析（按月统计）指标接口
     *  *
     * @param QueryYydDingMsgMonthStatisticalDataRequest $request QueryYydDingMsgMonthStatisticalDataRequest
     *
     * @return QueryYydDingMsgMonthStatisticalDataResponse QueryYydDingMsgMonthStatisticalDataResponse
     */
    public function queryYydDingMsgMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydDingMsgMonthStatisticalDataHeaders([]);

        return $this->queryYydDingMsgMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋钉消息分析（按周统计）指标接口
     *  *
     * @param QueryYydDingMsgWeekStatisticalDataRequest $request QueryYydDingMsgWeekStatisticalDataRequest
     * @param QueryYydDingMsgWeekStatisticalDataHeaders $headers QueryYydDingMsgWeekStatisticalDataHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydDingMsgWeekStatisticalDataResponse QueryYydDingMsgWeekStatisticalDataResponse
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
     * @summary 亚运钉数字参谋钉消息分析（按周统计）指标接口
     *  *
     * @param QueryYydDingMsgWeekStatisticalDataRequest $request QueryYydDingMsgWeekStatisticalDataRequest
     *
     * @return QueryYydDingMsgWeekStatisticalDataResponse QueryYydDingMsgWeekStatisticalDataResponse
     */
    public function queryYydDingMsgWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydDingMsgWeekStatisticalDataHeaders([]);

        return $this->queryYydDingMsgWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋群聊分析（按日统计）指标接口
     *  *
     * @param QueryYydGroupMsgDayStatisticalDataRequest $request QueryYydGroupMsgDayStatisticalDataRequest
     * @param QueryYydGroupMsgDayStatisticalDataHeaders $headers QueryYydGroupMsgDayStatisticalDataHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydGroupMsgDayStatisticalDataResponse QueryYydGroupMsgDayStatisticalDataResponse
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
     * @summary 亚运钉数字参谋群聊分析（按日统计）指标接口
     *  *
     * @param QueryYydGroupMsgDayStatisticalDataRequest $request QueryYydGroupMsgDayStatisticalDataRequest
     *
     * @return QueryYydGroupMsgDayStatisticalDataResponse QueryYydGroupMsgDayStatisticalDataResponse
     */
    public function queryYydGroupMsgDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydGroupMsgDayStatisticalDataHeaders([]);

        return $this->queryYydGroupMsgDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋群聊分析（按月统计）指标接口
     *  *
     * @param QueryYydGroupMsgMonthStatisticalDataRequest $request QueryYydGroupMsgMonthStatisticalDataRequest
     * @param QueryYydGroupMsgMonthStatisticalDataHeaders $headers QueryYydGroupMsgMonthStatisticalDataHeaders
     * @param RuntimeOptions                              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydGroupMsgMonthStatisticalDataResponse QueryYydGroupMsgMonthStatisticalDataResponse
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
     * @summary 亚运钉数字参谋群聊分析（按月统计）指标接口
     *  *
     * @param QueryYydGroupMsgMonthStatisticalDataRequest $request QueryYydGroupMsgMonthStatisticalDataRequest
     *
     * @return QueryYydGroupMsgMonthStatisticalDataResponse QueryYydGroupMsgMonthStatisticalDataResponse
     */
    public function queryYydGroupMsgMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydGroupMsgMonthStatisticalDataHeaders([]);

        return $this->queryYydGroupMsgMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋群聊分析（按周统计）指标接口
     *  *
     * @param QueryYydGroupMsgWeekStatisticalDataRequest $request QueryYydGroupMsgWeekStatisticalDataRequest
     * @param QueryYydGroupMsgWeekStatisticalDataHeaders $headers QueryYydGroupMsgWeekStatisticalDataHeaders
     * @param RuntimeOptions                             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydGroupMsgWeekStatisticalDataResponse QueryYydGroupMsgWeekStatisticalDataResponse
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
     * @summary 亚运钉数字参谋群聊分析（按周统计）指标接口
     *  *
     * @param QueryYydGroupMsgWeekStatisticalDataRequest $request QueryYydGroupMsgWeekStatisticalDataRequest
     *
     * @return QueryYydGroupMsgWeekStatisticalDataResponse QueryYydGroupMsgWeekStatisticalDataResponse
     */
    public function queryYydGroupMsgWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydGroupMsgWeekStatisticalDataHeaders([]);

        return $this->queryYydGroupMsgWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋日志分析（按日统计）指标接口
     *  *
     * @param QueryYydLogDayStatisticalDataRequest $request QueryYydLogDayStatisticalDataRequest
     * @param QueryYydLogDayStatisticalDataHeaders $headers QueryYydLogDayStatisticalDataHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydLogDayStatisticalDataResponse QueryYydLogDayStatisticalDataResponse
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
     * @summary 亚运钉数字参谋日志分析（按日统计）指标接口
     *  *
     * @param QueryYydLogDayStatisticalDataRequest $request QueryYydLogDayStatisticalDataRequest
     *
     * @return QueryYydLogDayStatisticalDataResponse QueryYydLogDayStatisticalDataResponse
     */
    public function queryYydLogDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydLogDayStatisticalDataHeaders([]);

        return $this->queryYydLogDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋日志分析（按月统计）指标接口
     *  *
     * @param QueryYydLogMonthStatisticalDataRequest $request QueryYydLogMonthStatisticalDataRequest
     * @param QueryYydLogMonthStatisticalDataHeaders $headers QueryYydLogMonthStatisticalDataHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydLogMonthStatisticalDataResponse QueryYydLogMonthStatisticalDataResponse
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
     * @summary 亚运钉数字参谋日志分析（按月统计）指标接口
     *  *
     * @param QueryYydLogMonthStatisticalDataRequest $request QueryYydLogMonthStatisticalDataRequest
     *
     * @return QueryYydLogMonthStatisticalDataResponse QueryYydLogMonthStatisticalDataResponse
     */
    public function queryYydLogMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydLogMonthStatisticalDataHeaders([]);

        return $this->queryYydLogMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋日志分析（按周统计）指标接口
     *  *
     * @param QueryYydLogWeekStatisticalDataRequest $request QueryYydLogWeekStatisticalDataRequest
     * @param QueryYydLogWeekStatisticalDataHeaders $headers QueryYydLogWeekStatisticalDataHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydLogWeekStatisticalDataResponse QueryYydLogWeekStatisticalDataResponse
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
     * @summary 亚运钉数字参谋日志分析（按周统计）指标接口
     *  *
     * @param QueryYydLogWeekStatisticalDataRequest $request QueryYydLogWeekStatisticalDataRequest
     *
     * @return QueryYydLogWeekStatisticalDataResponse QueryYydLogWeekStatisticalDataResponse
     */
    public function queryYydLogWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydLogWeekStatisticalDataHeaders([]);

        return $this->queryYydLogWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋钉会议分析（按日统计）指标接口
     *  *
     * @param QueryYydMeetingDayStatisticalDataRequest $request QueryYydMeetingDayStatisticalDataRequest
     * @param QueryYydMeetingDayStatisticalDataHeaders $headers QueryYydMeetingDayStatisticalDataHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydMeetingDayStatisticalDataResponse QueryYydMeetingDayStatisticalDataResponse
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
     * @summary 亚运钉数字参谋钉会议分析（按日统计）指标接口
     *  *
     * @param QueryYydMeetingDayStatisticalDataRequest $request QueryYydMeetingDayStatisticalDataRequest
     *
     * @return QueryYydMeetingDayStatisticalDataResponse QueryYydMeetingDayStatisticalDataResponse
     */
    public function queryYydMeetingDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydMeetingDayStatisticalDataHeaders([]);

        return $this->queryYydMeetingDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋钉会议分析（按月统计）指标接口
     *  *
     * @param QueryYydMeetingMonthStatisticalDataRequest $request QueryYydMeetingMonthStatisticalDataRequest
     * @param QueryYydMeetingMonthStatisticalDataHeaders $headers QueryYydMeetingMonthStatisticalDataHeaders
     * @param RuntimeOptions                             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydMeetingMonthStatisticalDataResponse QueryYydMeetingMonthStatisticalDataResponse
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
     * @summary 亚运钉数字参谋钉会议分析（按月统计）指标接口
     *  *
     * @param QueryYydMeetingMonthStatisticalDataRequest $request QueryYydMeetingMonthStatisticalDataRequest
     *
     * @return QueryYydMeetingMonthStatisticalDataResponse QueryYydMeetingMonthStatisticalDataResponse
     */
    public function queryYydMeetingMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydMeetingMonthStatisticalDataHeaders([]);

        return $this->queryYydMeetingMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋钉会议分析（按周统计）指标接口
     *  *
     * @param QueryYydMeetingWeekStatisticalDataRequest $request QueryYydMeetingWeekStatisticalDataRequest
     * @param QueryYydMeetingWeekStatisticalDataHeaders $headers QueryYydMeetingWeekStatisticalDataHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydMeetingWeekStatisticalDataResponse QueryYydMeetingWeekStatisticalDataResponse
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
     * @summary 亚运钉数字参谋钉会议分析（按周统计）指标接口
     *  *
     * @param QueryYydMeetingWeekStatisticalDataRequest $request QueryYydMeetingWeekStatisticalDataRequest
     *
     * @return QueryYydMeetingWeekStatisticalDataResponse QueryYydMeetingWeekStatisticalDataResponse
     */
    public function queryYydMeetingWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydMeetingWeekStatisticalDataHeaders([]);

        return $this->queryYydMeetingWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋通知分析（按日统计）指标接口
     *  *
     * @param QueryYydNoticeDayStatisticalDataRequest $request QueryYydNoticeDayStatisticalDataRequest
     * @param QueryYydNoticeDayStatisticalDataHeaders $headers QueryYydNoticeDayStatisticalDataHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydNoticeDayStatisticalDataResponse QueryYydNoticeDayStatisticalDataResponse
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
     * @summary 亚运钉数字参谋通知分析（按日统计）指标接口
     *  *
     * @param QueryYydNoticeDayStatisticalDataRequest $request QueryYydNoticeDayStatisticalDataRequest
     *
     * @return QueryYydNoticeDayStatisticalDataResponse QueryYydNoticeDayStatisticalDataResponse
     */
    public function queryYydNoticeDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydNoticeDayStatisticalDataHeaders([]);

        return $this->queryYydNoticeDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋通知分析（按月统计）指标接口
     *  *
     * @param QueryYydNoticeMonthStatisticalDataRequest $request QueryYydNoticeMonthStatisticalDataRequest
     * @param QueryYydNoticeMonthStatisticalDataHeaders $headers QueryYydNoticeMonthStatisticalDataHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydNoticeMonthStatisticalDataResponse QueryYydNoticeMonthStatisticalDataResponse
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
     * @summary 亚运钉数字参谋通知分析（按月统计）指标接口
     *  *
     * @param QueryYydNoticeMonthStatisticalDataRequest $request QueryYydNoticeMonthStatisticalDataRequest
     *
     * @return QueryYydNoticeMonthStatisticalDataResponse QueryYydNoticeMonthStatisticalDataResponse
     */
    public function queryYydNoticeMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydNoticeMonthStatisticalDataHeaders([]);

        return $this->queryYydNoticeMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋通知分析（按周统计）指标接口
     *  *
     * @param QueryYydNoticeWeekStatisticalDataRequest $request QueryYydNoticeWeekStatisticalDataRequest
     * @param QueryYydNoticeWeekStatisticalDataHeaders $headers QueryYydNoticeWeekStatisticalDataHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydNoticeWeekStatisticalDataResponse QueryYydNoticeWeekStatisticalDataResponse
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
     * @summary 亚运钉数字参谋通知分析（按周统计）指标接口
     *  *
     * @param QueryYydNoticeWeekStatisticalDataRequest $request QueryYydNoticeWeekStatisticalDataRequest
     *
     * @return QueryYydNoticeWeekStatisticalDataResponse QueryYydNoticeWeekStatisticalDataResponse
     */
    public function queryYydNoticeWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydNoticeWeekStatisticalDataHeaders([]);

        return $this->queryYydNoticeWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋单聊分析（按日统计）指标接口
     *  *
     * @param QueryYydSingleMsgDayStatisticalDataRequest $request QueryYydSingleMsgDayStatisticalDataRequest
     * @param QueryYydSingleMsgDayStatisticalDataHeaders $headers QueryYydSingleMsgDayStatisticalDataHeaders
     * @param RuntimeOptions                             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydSingleMsgDayStatisticalDataResponse QueryYydSingleMsgDayStatisticalDataResponse
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
     * @summary 亚运钉数字参谋单聊分析（按日统计）指标接口
     *  *
     * @param QueryYydSingleMsgDayStatisticalDataRequest $request QueryYydSingleMsgDayStatisticalDataRequest
     *
     * @return QueryYydSingleMsgDayStatisticalDataResponse QueryYydSingleMsgDayStatisticalDataResponse
     */
    public function queryYydSingleMsgDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydSingleMsgDayStatisticalDataHeaders([]);

        return $this->queryYydSingleMsgDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋单聊分析（按月统计）指标接口
     *  *
     * @param QueryYydSingleMsgMonthStatisticalDataRequest $request QueryYydSingleMsgMonthStatisticalDataRequest
     * @param QueryYydSingleMsgMonthStatisticalDataHeaders $headers QueryYydSingleMsgMonthStatisticalDataHeaders
     * @param RuntimeOptions                               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydSingleMsgMonthStatisticalDataResponse QueryYydSingleMsgMonthStatisticalDataResponse
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
     * @summary 亚运钉数字参谋单聊分析（按月统计）指标接口
     *  *
     * @param QueryYydSingleMsgMonthStatisticalDataRequest $request QueryYydSingleMsgMonthStatisticalDataRequest
     *
     * @return QueryYydSingleMsgMonthStatisticalDataResponse QueryYydSingleMsgMonthStatisticalDataResponse
     */
    public function queryYydSingleMsgMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydSingleMsgMonthStatisticalDataHeaders([]);

        return $this->queryYydSingleMsgMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋单聊分析（按周统计）指标接口
     *  *
     * @param QueryYydSingleMsgWeekStatisticalDataRequest $request QueryYydSingleMsgWeekStatisticalDataRequest
     * @param QueryYydSingleMsgWeekStatisticalDataHeaders $headers QueryYydSingleMsgWeekStatisticalDataHeaders
     * @param RuntimeOptions                              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydSingleMsgWeekStatisticalDataResponse QueryYydSingleMsgWeekStatisticalDataResponse
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
     * @summary 亚运钉数字参谋单聊分析（按周统计）指标接口
     *  *
     * @param QueryYydSingleMsgWeekStatisticalDataRequest $request QueryYydSingleMsgWeekStatisticalDataRequest
     *
     * @return QueryYydSingleMsgWeekStatisticalDataResponse QueryYydSingleMsgWeekStatisticalDataResponse
     */
    public function queryYydSingleMsgWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydSingleMsgWeekStatisticalDataHeaders([]);

        return $this->queryYydSingleMsgWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋消息概览（按日统计）指标接口
     *  *
     * @param QueryYydToatlMsgDayStatisticalDataRequest $request QueryYydToatlMsgDayStatisticalDataRequest
     * @param QueryYydToatlMsgDayStatisticalDataHeaders $headers QueryYydToatlMsgDayStatisticalDataHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydToatlMsgDayStatisticalDataResponse QueryYydToatlMsgDayStatisticalDataResponse
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
     * @summary 亚运钉数字参谋消息概览（按日统计）指标接口
     *  *
     * @param QueryYydToatlMsgDayStatisticalDataRequest $request QueryYydToatlMsgDayStatisticalDataRequest
     *
     * @return QueryYydToatlMsgDayStatisticalDataResponse QueryYydToatlMsgDayStatisticalDataResponse
     */
    public function queryYydToatlMsgDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydToatlMsgDayStatisticalDataHeaders([]);

        return $this->queryYydToatlMsgDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋消息概览（按月统计）指标接口
     *  *
     * @param QueryYydToatlMsgMonthStatisticalDataRequest $request QueryYydToatlMsgMonthStatisticalDataRequest
     * @param QueryYydToatlMsgMonthStatisticalDataHeaders $headers QueryYydToatlMsgMonthStatisticalDataHeaders
     * @param RuntimeOptions                              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydToatlMsgMonthStatisticalDataResponse QueryYydToatlMsgMonthStatisticalDataResponse
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
     * @summary 亚运钉数字参谋消息概览（按月统计）指标接口
     *  *
     * @param QueryYydToatlMsgMonthStatisticalDataRequest $request QueryYydToatlMsgMonthStatisticalDataRequest
     *
     * @return QueryYydToatlMsgMonthStatisticalDataResponse QueryYydToatlMsgMonthStatisticalDataResponse
     */
    public function queryYydToatlMsgMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydToatlMsgMonthStatisticalDataHeaders([]);

        return $this->queryYydToatlMsgMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋消息概览（按周统计）指标接口
     *  *
     * @param QueryYydToatlMsgWeekStatisticalDataRequest $request QueryYydToatlMsgWeekStatisticalDataRequest
     * @param QueryYydToatlMsgWeekStatisticalDataHeaders $headers QueryYydToatlMsgWeekStatisticalDataHeaders
     * @param RuntimeOptions                             $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydToatlMsgWeekStatisticalDataResponse QueryYydToatlMsgWeekStatisticalDataResponse
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
     * @summary 亚运钉数字参谋消息概览（按周统计）指标接口
     *  *
     * @param QueryYydToatlMsgWeekStatisticalDataRequest $request QueryYydToatlMsgWeekStatisticalDataRequest
     *
     * @return QueryYydToatlMsgWeekStatisticalDataResponse QueryYydToatlMsgWeekStatisticalDataResponse
     */
    public function queryYydToatlMsgWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydToatlMsgWeekStatisticalDataHeaders([]);

        return $this->queryYydToatlMsgWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋待办分析（按日统计）指标接口
     *  *
     * @param QueryYydTodoDayStatisticalDataRequest $request QueryYydTodoDayStatisticalDataRequest
     * @param QueryYydTodoDayStatisticalDataHeaders $headers QueryYydTodoDayStatisticalDataHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydTodoDayStatisticalDataResponse QueryYydTodoDayStatisticalDataResponse
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
     * @summary 亚运钉数字参谋待办分析（按日统计）指标接口
     *  *
     * @param QueryYydTodoDayStatisticalDataRequest $request QueryYydTodoDayStatisticalDataRequest
     *
     * @return QueryYydTodoDayStatisticalDataResponse QueryYydTodoDayStatisticalDataResponse
     */
    public function queryYydTodoDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydTodoDayStatisticalDataHeaders([]);

        return $this->queryYydTodoDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋待办分析（按月统计）指标接口
     *  *
     * @param QueryYydTodoMonthStatisticalDataRequest $request QueryYydTodoMonthStatisticalDataRequest
     * @param QueryYydTodoMonthStatisticalDataHeaders $headers QueryYydTodoMonthStatisticalDataHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydTodoMonthStatisticalDataResponse QueryYydTodoMonthStatisticalDataResponse
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
     * @summary 亚运钉数字参谋待办分析（按月统计）指标接口
     *  *
     * @param QueryYydTodoMonthStatisticalDataRequest $request QueryYydTodoMonthStatisticalDataRequest
     *
     * @return QueryYydTodoMonthStatisticalDataResponse QueryYydTodoMonthStatisticalDataResponse
     */
    public function queryYydTodoMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydTodoMonthStatisticalDataHeaders([]);

        return $this->queryYydTodoMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉数字参谋待办分析（按周统计）指标接口
     *  *
     * @param QueryYydTodoWeekStatisticalDataRequest $request QueryYydTodoWeekStatisticalDataRequest
     * @param QueryYydTodoWeekStatisticalDataHeaders $headers QueryYydTodoWeekStatisticalDataHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydTodoWeekStatisticalDataResponse QueryYydTodoWeekStatisticalDataResponse
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
     * @summary 亚运钉数字参谋待办分析（按周统计）指标接口
     *  *
     * @param QueryYydTodoWeekStatisticalDataRequest $request QueryYydTodoWeekStatisticalDataRequest
     *
     * @return QueryYydTodoWeekStatisticalDataResponse QueryYydTodoWeekStatisticalDataResponse
     */
    public function queryYydTodoWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydTodoWeekStatisticalDataHeaders([]);

        return $this->queryYydTodoWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉参谋全局概览（按日统计）指标接口
     *  *
     * @param QueryYydTotalDayStatisticalDataRequest $request QueryYydTotalDayStatisticalDataRequest
     * @param QueryYydTotalDayStatisticalDataHeaders $headers QueryYydTotalDayStatisticalDataHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydTotalDayStatisticalDataResponse QueryYydTotalDayStatisticalDataResponse
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
     * @summary 亚运钉参谋全局概览（按日统计）指标接口
     *  *
     * @param QueryYydTotalDayStatisticalDataRequest $request QueryYydTotalDayStatisticalDataRequest
     *
     * @return QueryYydTotalDayStatisticalDataResponse QueryYydTotalDayStatisticalDataResponse
     */
    public function queryYydTotalDayStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydTotalDayStatisticalDataHeaders([]);

        return $this->queryYydTotalDayStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉参谋全局概览（按月统计）指标接口
     *  *
     * @param QueryYydTotalMonthStatisticalDataRequest $request QueryYydTotalMonthStatisticalDataRequest
     * @param QueryYydTotalMonthStatisticalDataHeaders $headers QueryYydTotalMonthStatisticalDataHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydTotalMonthStatisticalDataResponse QueryYydTotalMonthStatisticalDataResponse
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
     * @summary 亚运钉参谋全局概览（按月统计）指标接口
     *  *
     * @param QueryYydTotalMonthStatisticalDataRequest $request QueryYydTotalMonthStatisticalDataRequest
     *
     * @return QueryYydTotalMonthStatisticalDataResponse QueryYydTotalMonthStatisticalDataResponse
     */
    public function queryYydTotalMonthStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydTotalMonthStatisticalDataHeaders([]);

        return $this->queryYydTotalMonthStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉参谋全局概览（累计）指标接口
     *  *
     * @param QueryYydTotalStdStatisticalDataRequest $request QueryYydTotalStdStatisticalDataRequest
     * @param QueryYydTotalStdStatisticalDataHeaders $headers QueryYydTotalStdStatisticalDataHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydTotalStdStatisticalDataResponse QueryYydTotalStdStatisticalDataResponse
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
     * @summary 亚运钉参谋全局概览（累计）指标接口
     *  *
     * @param QueryYydTotalStdStatisticalDataRequest $request QueryYydTotalStdStatisticalDataRequest
     *
     * @return QueryYydTotalStdStatisticalDataResponse QueryYydTotalStdStatisticalDataResponse
     */
    public function queryYydTotalStdStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydTotalStdStatisticalDataHeaders([]);

        return $this->queryYydTotalStdStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 亚运钉参谋全局概览（按周统计）指标接口
     *  *
     * @param QueryYydTotalWeekStatisticalDataRequest $request QueryYydTotalWeekStatisticalDataRequest
     * @param QueryYydTotalWeekStatisticalDataHeaders $headers QueryYydTotalWeekStatisticalDataHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryYydTotalWeekStatisticalDataResponse QueryYydTotalWeekStatisticalDataResponse
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
     * @summary 亚运钉参谋全局概览（按周统计）指标接口
     *  *
     * @param QueryYydTotalWeekStatisticalDataRequest $request QueryYydTotalWeekStatisticalDataRequest
     *
     * @return QueryYydTotalWeekStatisticalDataResponse QueryYydTotalWeekStatisticalDataResponse
     */
    public function queryYydTotalWeekStatisticalData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryYydTotalWeekStatisticalDataHeaders([]);

        return $this->queryYydTotalWeekStatisticalDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过关键词搜索企业
     *  *
     * @param SearchCompanyRequest $request SearchCompanyRequest
     * @param SearchCompanyHeaders $headers SearchCompanyHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchCompanyResponse SearchCompanyResponse
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
     * @summary 通过关键词搜索企业
     *  *
     * @param SearchCompanyRequest $request SearchCompanyRequest
     *
     * @return SearchCompanyResponse SearchCompanyResponse
     */
    public function searchCompany($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchCompanyHeaders([]);

        return $this->searchCompanyWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 同步数据大屏
     *  *
     * @param SyncDataScreenRequest $request SyncDataScreenRequest
     * @param SyncDataScreenHeaders $headers SyncDataScreenHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return SyncDataScreenResponse SyncDataScreenResponse
     */
    public function syncDataScreenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->screenId)) {
            $body['screenId'] = $request->screenId;
        }
        if (!Utils::isUnset($request->ticket)) {
            $body['ticket'] = $request->ticket;
        }
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
            'action'      => 'SyncDataScreen',
            'version'     => 'datacenter_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/datacenter/dataScreens/sync',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SyncDataScreenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 同步数据大屏
     *  *
     * @param SyncDataScreenRequest $request SyncDataScreenRequest
     *
     * @return SyncDataScreenResponse SyncDataScreenResponse
     */
    public function syncDataScreen($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncDataScreenHeaders([]);

        return $this->syncDataScreenWithOptions($request, $headers, $runtime);
    }
}
