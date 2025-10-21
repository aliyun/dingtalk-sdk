<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\AppLoginCodeGenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\AppLoginCodeGenRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\AppLoginCodeGenResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchGetFormDataByIdListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchGetFormDataByIdListRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchGetFormDataByIdListResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchRemovalByFormInstanceIdListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchRemovalByFormInstanceIdListRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchRemovalByFormInstanceIdListResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchSaveFormDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchSaveFormDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchSaveFormDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchUpdateFormDataByInstanceIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchUpdateFormDataByInstanceIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchUpdateFormDataByInstanceIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchUpdateFormDataByInstanceMapHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchUpdateFormDataByInstanceMapRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchUpdateFormDataByInstanceMapResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BuyAuthorizationOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BuyAuthorizationOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BuyAuthorizationOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BuyFreshOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BuyFreshOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BuyFreshOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\CheckCloudAccountStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\CheckCloudAccountStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\CheckCloudAccountStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\CreateOrUpdateFormDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\CreateOrUpdateFormDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\CreateOrUpdateFormDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteFormDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteFormDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteFormDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteSequenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteSequenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeleteSequenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeployFunctionCallbackHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeployFunctionCallbackRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\DeployFunctionCallbackResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecuteBatchTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecuteBatchTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecuteBatchTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecuteCustomApiHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecuteCustomApiRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecuteCustomApiResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecutePlatformTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecutePlatformTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecutePlatformTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecuteTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecuteTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExecuteTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExpireCommodityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExpireCommodityRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ExpireCommodityResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetActivationCodeByCallerUnionIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetActivationCodeByCallerUnionIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetActivationCodeByCallerUnionIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetActivityButtonListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetActivityButtonListRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetActivityButtonListResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetActivityListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetActivityListRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetActivityListResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetAllAuthCubesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetAllAuthCubesRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetAllAuthCubesResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetApplicationAuthorizationServicePlatformResourceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetApplicationAuthorizationServicePlatformResourceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetApplicationAuthorizationServicePlatformResourceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetAutoFlowLogDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetAutoFlowLogDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetAutoFlowLogDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpAccomplishmentTasksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpAccomplishmentTasksRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpAccomplishmentTasksResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpLevelByAccountIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpLevelByAccountIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpLevelByAccountIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpTasksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpTasksRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpTasksResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetDbConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetDbConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetDbConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFieldDefByUuidHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFieldDefByUuidRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFieldDefByUuidResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormComponentDefinitionListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormComponentDefinitionListRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormComponentDefinitionListResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormDataByIDHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormDataByIDRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormDataByIDResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormListInAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormListInAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetFormListInAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstanceByIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstanceByIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstanceByIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstanceIdListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstanceIdListRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstanceIdListResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesByIdListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesByIdListRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesByIdListResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetMeCorpSubmissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetMeCorpSubmissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetMeCorpSubmissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetNotifyMeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetNotifyMeRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetNotifyMeResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetOpenUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetOpenUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetOpenUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetOperationRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetOperationRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetOperationRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetPlatformResourceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetPlatformResourceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetPlatformResourceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetPrintAppInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetPrintAppInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetPrintAppInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetPrintDictionaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetPrintDictionaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetPrintDictionaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDefinitionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDefinitionRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDefinitionResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignByCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignByCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignByCodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetRunningTaskListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetRunningTaskListRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetRunningTaskListResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetRunningTasksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetRunningTasksRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetRunningTasksResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetSaleUserInfoByUserIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetSaleUserInfoByUserIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetSaleUserInfoByUserIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetSimpleCubeModelListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetSimpleCubeModelListRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetSimpleCubeModelListResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetTaskCopiesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetTaskCopiesRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetTaskCopiesResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationAuthorizationServiceApplicationInformationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationAuthorizationServiceApplicationInformationRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationAuthorizationServiceApplicationInformationResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationAuthorizationServiceConnectorInformationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationAuthorizationServiceConnectorInformationRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationAuthorizationServiceConnectorInformationResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationInformationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationInformationRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationInformationResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListCommodityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListCommodityRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListCommodityResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListConnectorInformationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListConnectorInformationRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListConnectorInformationResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListFormRemarksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListFormRemarksRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListFormRemarksResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListNavigationByFormTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListNavigationByFormTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListNavigationByFormTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListOperationLogsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListOperationLogsRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListOperationLogsResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListTableDataByFormInstanceIdTableIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListTableDataByFormInstanceIdTableIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListTableDataByFormInstanceIdTableIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\LoginCodeGenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\LoginCodeGenRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\LoginCodeGenResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\NotifyAuthorizationResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\NotifyAuthorizationResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\NotifyAuthorizationResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\PageAutoFlowLogHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\PageAutoFlowLogRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\PageAutoFlowLogResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\PageFormBaseInfosHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\PageFormBaseInfosRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\PageFormBaseInfosResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\PreviewPublishedProcessHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\PreviewPublishedProcessRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\PreviewPublishedProcessResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\QueryServiceRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\QueryServiceRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\QueryServiceRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RedirectTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RedirectTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RedirectTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RefundCommodityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RefundCommodityRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RefundCommodityResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RegisterAccountsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RegisterAccountsRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RegisterAccountsResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ReleaseCommodityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ReleaseCommodityRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ReleaseCommodityResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RemoveTenantResourceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RemoveTenantResourceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RemoveTenantResourceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RenderBatchCallbackHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RenderBatchCallbackRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RenderBatchCallbackResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RenewApplicationAuthorizationServiceOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RenewApplicationAuthorizationServiceOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RenewApplicationAuthorizationServiceOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RenewTenantOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RenewTenantOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\RenewTenantOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SaveFormDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SaveFormDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SaveFormDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SaveFormRemarkHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SaveFormRemarkRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SaveFormRemarkResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SavePrintTplDetailInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SavePrintTplDetailInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SavePrintTplDetailInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchActivationCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchActivationCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchActivationCodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchEmployeeFieldValuesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchEmployeeFieldValuesRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchEmployeeFieldValuesResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataIdListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataIdListRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataIdListResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataRemovalTableDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataRemovalTableDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataRemovalTableDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataSecondGenerationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataSecondGenerationNoTableFieldHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataSecondGenerationNoTableFieldRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataSecondGenerationNoTableFieldResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataSecondGenerationRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataSecondGenerationResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\StartInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\StartInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\StartInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\TerminateCloudAuthorizationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\TerminateCloudAuthorizationRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\TerminateCloudAuthorizationResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\TerminateInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\TerminateInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\TerminateInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateCloudAccountInformationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateCloudAccountInformationRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateCloudAccountInformationResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateFormDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateFormDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateFormDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpdateStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpgradeTenantInformationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpgradeTenantInformationRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\UpgradeTenantInformationResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateApplicationAuthorizationOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateApplicationAuthorizationOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateApplicationAuthorizationOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateApplicationAuthorizationServiceOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateApplicationAuthorizationServiceOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateApplicationAuthorizationServiceOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateApplicationServiceOrderUpgradeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateApplicationServiceOrderUpgradeRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateApplicationServiceOrderUpgradeResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateOrderBuyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateOrderBuyRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateOrderBuyResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateOrderUpdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateOrderUpdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateOrderUpdateResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateOrderUpgradeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateOrderUpgradeRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ValidateOrderUpgradeResponse;
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
     * @summary 生成登录态传递用的code
     *  *
     * @param AppLoginCodeGenRequest $request AppLoginCodeGenRequest
     * @param AppLoginCodeGenHeaders $headers AppLoginCodeGenHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return AppLoginCodeGenResponse AppLoginCodeGenResponse
     */
    public function appLoginCodeGenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->fullUrl)) {
            $query['fullUrl'] = $request->fullUrl;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $body = [];
        if (!Utils::isUnset($request->appKey)) {
            $body['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->signTimestampStr)) {
            $body['signTimestampStr'] = $request->signTimestampStr;
        }
        if (!Utils::isUnset($request->signature)) {
            $body['signature'] = $request->signature;
        }
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
            'action' => 'AppLoginCodeGen',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/authorizations/appLoginCodes',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AppLoginCodeGenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 生成登录态传递用的code
     *  *
     * @param AppLoginCodeGenRequest $request AppLoginCodeGenRequest
     *
     * @return AppLoginCodeGenResponse AppLoginCodeGenResponse
     */
    public function appLoginCodeGen($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AppLoginCodeGenHeaders([]);

        return $this->appLoginCodeGenWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量获取指定表单实例ID列表对应的表单实例数据
     *  *
     * @param BatchGetFormDataByIdListRequest $request BatchGetFormDataByIdListRequest
     * @param BatchGetFormDataByIdListHeaders $headers BatchGetFormDataByIdListHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchGetFormDataByIdListResponse BatchGetFormDataByIdListResponse
     */
    public function batchGetFormDataByIdListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formInstanceIdList)) {
            $body['formInstanceIdList'] = $request->formInstanceIdList;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->needFormInstanceValue)) {
            $body['needFormInstanceValue'] = $request->needFormInstanceValue;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'BatchGetFormDataByIdList',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/instances/ids/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchGetFormDataByIdListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量获取指定表单实例ID列表对应的表单实例数据
     *  *
     * @param BatchGetFormDataByIdListRequest $request BatchGetFormDataByIdListRequest
     *
     * @return BatchGetFormDataByIdListResponse BatchGetFormDataByIdListResponse
     */
    public function batchGetFormDataByIdList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchGetFormDataByIdListHeaders([]);

        return $this->batchGetFormDataByIdListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量删除指定的表单实例
     *  *
     * @param BatchRemovalByFormInstanceIdListRequest $request BatchRemovalByFormInstanceIdListRequest
     * @param BatchRemovalByFormInstanceIdListHeaders $headers BatchRemovalByFormInstanceIdListHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchRemovalByFormInstanceIdListResponse BatchRemovalByFormInstanceIdListResponse
     */
    public function batchRemovalByFormInstanceIdListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->asynchronousExecution)) {
            $body['asynchronousExecution'] = $request->asynchronousExecution;
        }
        if (!Utils::isUnset($request->executeExpression)) {
            $body['executeExpression'] = $request->executeExpression;
        }
        if (!Utils::isUnset($request->formInstanceIdList)) {
            $body['formInstanceIdList'] = $request->formInstanceIdList;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'BatchRemovalByFormInstanceIdList',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/instances/batchRemove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'none',
        ]);

        return BatchRemovalByFormInstanceIdListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量删除指定的表单实例
     *  *
     * @param BatchRemovalByFormInstanceIdListRequest $request BatchRemovalByFormInstanceIdListRequest
     *
     * @return BatchRemovalByFormInstanceIdListResponse BatchRemovalByFormInstanceIdListResponse
     */
    public function batchRemovalByFormInstanceIdList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchRemovalByFormInstanceIdListHeaders([]);

        return $this->batchRemovalByFormInstanceIdListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量保存表单实例数据
     *  *
     * @param BatchSaveFormDataRequest $request BatchSaveFormDataRequest
     * @param BatchSaveFormDataHeaders $headers BatchSaveFormDataHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchSaveFormDataResponse BatchSaveFormDataResponse
     */
    public function batchSaveFormDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->asynchronousExecution)) {
            $body['asynchronousExecution'] = $request->asynchronousExecution;
        }
        if (!Utils::isUnset($request->formDataJsonList)) {
            $body['formDataJsonList'] = $request->formDataJsonList;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->keepRunningAfterException)) {
            $body['keepRunningAfterException'] = $request->keepRunningAfterException;
        }
        if (!Utils::isUnset($request->noExecuteExpression)) {
            $body['noExecuteExpression'] = $request->noExecuteExpression;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'BatchSaveFormData',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/instances/batchSave',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchSaveFormDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量保存表单实例数据
     *  *
     * @param BatchSaveFormDataRequest $request BatchSaveFormDataRequest
     *
     * @return BatchSaveFormDataResponse BatchSaveFormDataResponse
     */
    public function batchSaveFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchSaveFormDataHeaders([]);

        return $this->batchSaveFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 将多条表单实例的指定表单组件更新成指定值
     *  *
     * @param BatchUpdateFormDataByInstanceIdRequest $request BatchUpdateFormDataByInstanceIdRequest
     * @param BatchUpdateFormDataByInstanceIdHeaders $headers BatchUpdateFormDataByInstanceIdHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchUpdateFormDataByInstanceIdResponse BatchUpdateFormDataByInstanceIdResponse
     */
    public function batchUpdateFormDataByInstanceIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->asynchronousExecution)) {
            $body['asynchronousExecution'] = $request->asynchronousExecution;
        }
        if (!Utils::isUnset($request->formInstanceIdList)) {
            $body['formInstanceIdList'] = $request->formInstanceIdList;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->ignoreEmpty)) {
            $body['ignoreEmpty'] = $request->ignoreEmpty;
        }
        if (!Utils::isUnset($request->noExecuteExpression)) {
            $body['noExecuteExpression'] = $request->noExecuteExpression;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->updateFormDataJson)) {
            $body['updateFormDataJson'] = $request->updateFormDataJson;
        }
        if (!Utils::isUnset($request->useLatestFormSchemaVersion)) {
            $body['useLatestFormSchemaVersion'] = $request->useLatestFormSchemaVersion;
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
            'action' => 'BatchUpdateFormDataByInstanceId',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/instances/components',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchUpdateFormDataByInstanceIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 将多条表单实例的指定表单组件更新成指定值
     *  *
     * @param BatchUpdateFormDataByInstanceIdRequest $request BatchUpdateFormDataByInstanceIdRequest
     *
     * @return BatchUpdateFormDataByInstanceIdResponse BatchUpdateFormDataByInstanceIdResponse
     */
    public function batchUpdateFormDataByInstanceId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateFormDataByInstanceIdHeaders([]);

        return $this->batchUpdateFormDataByInstanceIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过表单实例数据批量更新表单实例
     *  *
     * @param BatchUpdateFormDataByInstanceMapRequest $request BatchUpdateFormDataByInstanceMapRequest
     * @param BatchUpdateFormDataByInstanceMapHeaders $headers BatchUpdateFormDataByInstanceMapHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchUpdateFormDataByInstanceMapResponse BatchUpdateFormDataByInstanceMapResponse
     */
    public function batchUpdateFormDataByInstanceMapWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->asynchronousExecution)) {
            $body['asynchronousExecution'] = $request->asynchronousExecution;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->ignoreEmpty)) {
            $body['ignoreEmpty'] = $request->ignoreEmpty;
        }
        if (!Utils::isUnset($request->noExecuteExpression)) {
            $body['noExecuteExpression'] = $request->noExecuteExpression;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->updateFormDataJsonMap)) {
            $body['updateFormDataJsonMap'] = $request->updateFormDataJsonMap;
        }
        if (!Utils::isUnset($request->useLatestFormSchemaVersion)) {
            $body['useLatestFormSchemaVersion'] = $request->useLatestFormSchemaVersion;
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
            'action' => 'BatchUpdateFormDataByInstanceMap',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/instances/datas',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchUpdateFormDataByInstanceMapResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过表单实例数据批量更新表单实例
     *  *
     * @param BatchUpdateFormDataByInstanceMapRequest $request BatchUpdateFormDataByInstanceMapRequest
     *
     * @return BatchUpdateFormDataByInstanceMapResponse BatchUpdateFormDataByInstanceMapResponse
     */
    public function batchUpdateFormDataByInstanceMap($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateFormDataByInstanceMapHeaders([]);

        return $this->batchUpdateFormDataByInstanceMapWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 多渠道新购(通过应用授权服务)
     *  *
     * @param BuyAuthorizationOrderRequest $request BuyAuthorizationOrderRequest
     * @param BuyAuthorizationOrderHeaders $headers BuyAuthorizationOrderHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return BuyAuthorizationOrderResponse BuyAuthorizationOrderResponse
     */
    public function buyAuthorizationOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accessKey)) {
            $body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->accountNumber)) {
            $body['accountNumber'] = $request->accountNumber;
        }
        if (!Utils::isUnset($request->beginTimeGMT)) {
            $body['beginTimeGMT'] = $request->beginTimeGMT;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            $body['callerUnionId'] = $request->callerUnionId;
        }
        if (!Utils::isUnset($request->chargeType)) {
            $body['chargeType'] = $request->chargeType;
        }
        if (!Utils::isUnset($request->commerceType)) {
            $body['commerceType'] = $request->commerceType;
        }
        if (!Utils::isUnset($request->commodityType)) {
            $body['commodityType'] = $request->commodityType;
        }
        if (!Utils::isUnset($request->endTimeGMT)) {
            $body['endTimeGMT'] = $request->endTimeGMT;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->instanceName)) {
            $body['instanceName'] = $request->instanceName;
        }
        if (!Utils::isUnset($request->produceCode)) {
            $body['produceCode'] = $request->produceCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'BuyAuthorizationOrder',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/appAuthorizations/order',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return BuyAuthorizationOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道新购(通过应用授权服务)
     *  *
     * @param BuyAuthorizationOrderRequest $request BuyAuthorizationOrderRequest
     *
     * @return BuyAuthorizationOrderResponse BuyAuthorizationOrderResponse
     */
    public function buyAuthorizationOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BuyAuthorizationOrderHeaders([]);

        return $this->buyAuthorizationOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新购宜搭产品
     *  *
     * @param BuyFreshOrderRequest $request BuyFreshOrderRequest
     * @param BuyFreshOrderHeaders $headers BuyFreshOrderHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return BuyFreshOrderResponse BuyFreshOrderResponse
     */
    public function buyFreshOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accessKey)) {
            $body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->accountNumber)) {
            $body['accountNumber'] = $request->accountNumber;
        }
        if (!Utils::isUnset($request->beginTimeGMT)) {
            $body['beginTimeGMT'] = $request->beginTimeGMT;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            $body['callerUnionId'] = $request->callerUnionId;
        }
        if (!Utils::isUnset($request->chargeType)) {
            $body['chargeType'] = $request->chargeType;
        }
        if (!Utils::isUnset($request->commerceType)) {
            $body['commerceType'] = $request->commerceType;
        }
        if (!Utils::isUnset($request->commodityType)) {
            $body['commodityType'] = $request->commodityType;
        }
        if (!Utils::isUnset($request->endTimeGMT)) {
            $body['endTimeGMT'] = $request->endTimeGMT;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->instanceName)) {
            $body['instanceName'] = $request->instanceName;
        }
        if (!Utils::isUnset($request->produceCode)) {
            $body['produceCode'] = $request->produceCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'BuyFreshOrder',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/freshOrders',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return BuyFreshOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新购宜搭产品
     *  *
     * @param BuyFreshOrderRequest $request BuyFreshOrderRequest
     *
     * @return BuyFreshOrderResponse BuyFreshOrderResponse
     */
    public function buyFreshOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BuyFreshOrderHeaders([]);

        return $this->buyFreshOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据阿里云账号验证激活结果
     *  *
     * @param string                         $callerUid
     * @param CheckCloudAccountStatusRequest $request   CheckCloudAccountStatusRequest
     * @param CheckCloudAccountStatusHeaders $headers   CheckCloudAccountStatusHeaders
     * @param RuntimeOptions                 $runtime   runtime options for this request RuntimeOptions
     *
     * @return CheckCloudAccountStatusResponse CheckCloudAccountStatusResponse
     */
    public function checkCloudAccountStatusWithOptions($callerUid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
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
            'action' => 'CheckCloudAccountStatus',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/cloudAccountStatus/' . $callerUid . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return CheckCloudAccountStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据阿里云账号验证激活结果
     *  *
     * @param string                         $callerUid
     * @param CheckCloudAccountStatusRequest $request   CheckCloudAccountStatusRequest
     *
     * @return CheckCloudAccountStatusResponse CheckCloudAccountStatusResponse
     */
    public function checkCloudAccountStatus($callerUid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckCloudAccountStatusHeaders([]);

        return $this->checkCloudAccountStatusWithOptions($callerUid, $request, $headers, $runtime);
    }

    /**
     * @summary 新增或更新表单实例
     *  *
     * @param CreateOrUpdateFormDataRequest $request CreateOrUpdateFormDataRequest
     * @param CreateOrUpdateFormDataHeaders $headers CreateOrUpdateFormDataHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateOrUpdateFormDataResponse CreateOrUpdateFormDataResponse
     */
    public function createOrUpdateFormDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            $body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->noExecuteExpression)) {
            $body['noExecuteExpression'] = $request->noExecuteExpression;
        }
        if (!Utils::isUnset($request->searchCondition)) {
            $body['searchCondition'] = $request->searchCondition;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'CreateOrUpdateFormData',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/instances/insertOrUpdate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateOrUpdateFormDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增或更新表单实例
     *  *
     * @param CreateOrUpdateFormDataRequest $request CreateOrUpdateFormDataRequest
     *
     * @return CreateOrUpdateFormDataResponse CreateOrUpdateFormDataResponse
     */
    public function createOrUpdateFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateOrUpdateFormDataHeaders([]);

        return $this->createOrUpdateFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除表单实例
     *  *
     * @param DeleteFormDataRequest $request DeleteFormDataRequest
     * @param DeleteFormDataHeaders $headers DeleteFormDataHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteFormDataResponse DeleteFormDataResponse
     */
    public function deleteFormDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formInstanceId)) {
            $query['formInstanceId'] = $request->formInstanceId;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'DeleteFormData',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/instances',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'none',
        ]);

        return DeleteFormDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除表单实例
     *  *
     * @param DeleteFormDataRequest $request DeleteFormDataRequest
     *
     * @return DeleteFormDataResponse DeleteFormDataResponse
     */
    public function deleteFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteFormDataHeaders([]);

        return $this->deleteFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除流程实例
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
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $query['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'DeleteInstance',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/processes/instances',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'none',
        ]);

        return DeleteInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除流程实例
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
     * @summary deleteSequence
     *  *
     * @param DeleteSequenceRequest $request DeleteSequenceRequest
     * @param DeleteSequenceHeaders $headers DeleteSequenceHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteSequenceResponse DeleteSequenceResponse
     */
    public function deleteSequenceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->sequence)) {
            $query['sequence'] = $request->sequence;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'DeleteSequence',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/deleteSequence',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return DeleteSequenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary deleteSequence
     *  *
     * @param DeleteSequenceRequest $request DeleteSequenceRequest
     *
     * @return DeleteSequenceResponse DeleteSequenceResponse
     */
    public function deleteSequence($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSequenceHeaders([]);

        return $this->deleteSequenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 云开发平台函数计算部署完成回调宜搭
     *  *
     * @param DeployFunctionCallbackRequest $request DeployFunctionCallbackRequest
     * @param DeployFunctionCallbackHeaders $headers DeployFunctionCallbackHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return DeployFunctionCallbackResponse DeployFunctionCallbackResponse
     */
    public function deployFunctionCallbackWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appId)) {
            $body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->customDomain)) {
            $body['customDomain'] = $request->customDomain;
        }
        if (!Utils::isUnset($request->deployStage)) {
            $body['deployStage'] = $request->deployStage;
        }
        if (!Utils::isUnset($request->gateWayAppKey)) {
            $body['gateWayAppKey'] = $request->gateWayAppKey;
        }
        if (!Utils::isUnset($request->gateWayAppSecret)) {
            $body['gateWayAppSecret'] = $request->gateWayAppSecret;
        }
        if (!Utils::isUnset($request->gateWayDomain)) {
            $body['gateWayDomain'] = $request->gateWayDomain;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DeployFunctionCallback',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/functionComputeConnectors/completeDeployments/notify',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeployFunctionCallbackResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 云开发平台函数计算部署完成回调宜搭
     *  *
     * @param DeployFunctionCallbackRequest $request DeployFunctionCallbackRequest
     *
     * @return DeployFunctionCallbackResponse DeployFunctionCallbackResponse
     */
    public function deployFunctionCallback($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeployFunctionCallbackHeaders([]);

        return $this->deployFunctionCallbackWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量审批
     *  *
     * @param ExecuteBatchTaskRequest $request ExecuteBatchTaskRequest
     * @param ExecuteBatchTaskHeaders $headers ExecuteBatchTaskHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return ExecuteBatchTaskResponse ExecuteBatchTaskResponse
     */
    public function executeBatchTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->outResult)) {
            $body['outResult'] = $request->outResult;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->taskInformationList)) {
            $body['taskInformationList'] = $request->taskInformationList;
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
            'action' => 'ExecuteBatchTask',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/tasks/batches/execute',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ExecuteBatchTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量审批
     *  *
     * @param ExecuteBatchTaskRequest $request ExecuteBatchTaskRequest
     *
     * @return ExecuteBatchTaskResponse ExecuteBatchTaskResponse
     */
    public function executeBatchTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecuteBatchTaskHeaders([]);

        return $this->executeBatchTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 执行用户自定义的API接口
     *  *
     * @param ExecuteCustomApiRequest $request ExecuteCustomApiRequest
     * @param ExecuteCustomApiHeaders $headers ExecuteCustomApiHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return ExecuteCustomApiResponse ExecuteCustomApiResponse
     */
    public function executeCustomApiWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->data)) {
            $query['data'] = $request->data;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->serviceId)) {
            $query['serviceId'] = $request->serviceId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'ExecuteCustomApi',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/customApi/execute',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return ExecuteCustomApiResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 执行用户自定义的API接口
     *  *
     * @param ExecuteCustomApiRequest $request ExecuteCustomApiRequest
     *
     * @return ExecuteCustomApiResponse ExecuteCustomApiResponse
     */
    public function executeCustomApi($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecuteCustomApiHeaders([]);

        return $this->executeCustomApiWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 执行宜搭平台的审批任务
     *  *
     * @param ExecutePlatformTaskRequest $request ExecutePlatformTaskRequest
     * @param ExecutePlatformTaskHeaders $headers ExecutePlatformTaskHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return ExecutePlatformTaskResponse ExecutePlatformTaskResponse
     */
    public function executePlatformTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            $body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->noExecuteExpressions)) {
            $body['noExecuteExpressions'] = $request->noExecuteExpressions;
        }
        if (!Utils::isUnset($request->outResult)) {
            $body['outResult'] = $request->outResult;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'ExecutePlatformTask',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/tasks/platformTasks/execute',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'none',
        ]);

        return ExecutePlatformTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 执行宜搭平台的审批任务
     *  *
     * @param ExecutePlatformTaskRequest $request ExecutePlatformTaskRequest
     *
     * @return ExecutePlatformTaskResponse ExecutePlatformTaskResponse
     */
    public function executePlatformTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecutePlatformTaskHeaders([]);

        return $this->executePlatformTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 执行审批任务
     *  *
     * @param ExecuteTaskRequest $request ExecuteTaskRequest
     * @param ExecuteTaskHeaders $headers ExecuteTaskHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return ExecuteTaskResponse ExecuteTaskResponse
     */
    public function executeTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->digitalSignUrl)) {
            $body['digitalSignUrl'] = $request->digitalSignUrl;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            $body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->noExecuteExpressions)) {
            $body['noExecuteExpressions'] = $request->noExecuteExpressions;
        }
        if (!Utils::isUnset($request->outResult)) {
            $body['outResult'] = $request->outResult;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->taskId)) {
            $body['taskId'] = $request->taskId;
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
            'action' => 'ExecuteTask',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/tasks/execute',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'none',
        ]);

        return ExecuteTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 执行审批任务
     *  *
     * @param ExecuteTaskRequest $request ExecuteTaskRequest
     *
     * @return ExecuteTaskResponse ExecuteTaskResponse
     */
    public function executeTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecuteTaskHeaders([]);

        return $this->executeTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 多渠道到期
     *  *
     * @param ExpireCommodityRequest $request ExpireCommodityRequest
     * @param ExpireCommodityHeaders $headers ExpireCommodityHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ExpireCommodityResponse ExpireCommodityResponse
     */
    public function expireCommodityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            $query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $query['instanceId'] = $request->instanceId;
        }
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
            'action' => 'ExpireCommodity',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/appAuth/commodities/expire',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return ExpireCommodityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道到期
     *  *
     * @param ExpireCommodityRequest $request ExpireCommodityRequest
     *
     * @return ExpireCommodityResponse ExpireCommodityResponse
     */
    public function expireCommodity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExpireCommodityHeaders([]);

        return $this->expireCommodityWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据阿里云账号获取激活码
     *  *
     * @param string                                  $callerUid
     * @param GetActivationCodeByCallerUnionIdRequest $request   GetActivationCodeByCallerUnionIdRequest
     * @param GetActivationCodeByCallerUnionIdHeaders $headers   GetActivationCodeByCallerUnionIdHeaders
     * @param RuntimeOptions                          $runtime   runtime options for this request RuntimeOptions
     *
     * @return GetActivationCodeByCallerUnionIdResponse GetActivationCodeByCallerUnionIdResponse
     */
    public function getActivationCodeByCallerUnionIdWithOptions($callerUid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
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
            'action' => 'GetActivationCodeByCallerUnionId',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/applications/activationCodes/' . $callerUid . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return GetActivationCodeByCallerUnionIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据阿里云账号获取激活码
     *  *
     * @param string                                  $callerUid
     * @param GetActivationCodeByCallerUnionIdRequest $request   GetActivationCodeByCallerUnionIdRequest
     *
     * @return GetActivationCodeByCallerUnionIdResponse GetActivationCodeByCallerUnionIdResponse
     */
    public function getActivationCodeByCallerUnionId($callerUid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetActivationCodeByCallerUnionIdHeaders([]);

        return $this->getActivationCodeByCallerUnionIdWithOptions($callerUid, $request, $headers, $runtime);
    }

    /**
     * @summary 获取流程实例可操作功能列表
     *  *
     * @param string                       $appType
     * @param string                       $processCode
     * @param string                       $activityId
     * @param GetActivityButtonListRequest $request     GetActivityButtonListRequest
     * @param GetActivityButtonListHeaders $headers     GetActivityButtonListHeaders
     * @param RuntimeOptions               $runtime     runtime options for this request RuntimeOptions
     *
     * @return GetActivityButtonListResponse GetActivityButtonListResponse
     */
    public function getActivityButtonListWithOptions($appType, $processCode, $activityId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'GetActivityButtonList',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/processDefinitions/buttons/' . $appType . '/' . $processCode . '/' . $activityId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return GetActivityButtonListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取流程实例可操作功能列表
     *  *
     * @param string                       $appType
     * @param string                       $processCode
     * @param string                       $activityId
     * @param GetActivityButtonListRequest $request     GetActivityButtonListRequest
     *
     * @return GetActivityButtonListResponse GetActivityButtonListResponse
     */
    public function getActivityButtonList($appType, $processCode, $activityId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetActivityButtonListHeaders([]);

        return $this->getActivityButtonListWithOptions($appType, $processCode, $activityId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取流程设计的节点信息
     *  *
     * @param GetActivityListRequest $request GetActivityListRequest
     * @param GetActivityListHeaders $headers GetActivityListHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetActivityListResponse GetActivityListResponse
     */
    public function getActivityListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processCode)) {
            $query['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'GetActivityList',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/processes/activities',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return GetActivityListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取流程设计的节点信息
     *  *
     * @param GetActivityListRequest $request GetActivityListRequest
     *
     * @return GetActivityListResponse GetActivityListResponse
     */
    public function getActivityList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetActivityListHeaders([]);

        return $this->getActivityListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询表单的接口，支持分页、表单名称模糊查询
     *  *
     * @param GetAllAuthCubesRequest $request GetAllAuthCubesRequest
     * @param GetAllAuthCubesHeaders $headers GetAllAuthCubesHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAllAuthCubesResponse GetAllAuthCubesResponse
     */
    public function getAllAuthCubesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->keywords)) {
            $body['keywords'] = $request->keywords;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'GetAllAuthCubes',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/metadata/allAuthCubes/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetAllAuthCubesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询表单的接口，支持分页、表单名称模糊查询
     *  *
     * @param GetAllAuthCubesRequest $request GetAllAuthCubesRequest
     *
     * @return GetAllAuthCubesResponse GetAllAuthCubesResponse
     */
    public function getAllAuthCubes($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllAuthCubesHeaders([]);

        return $this->getAllAuthCubesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 多渠道平台概览接口
     *  *
     * @param GetApplicationAuthorizationServicePlatformResourceRequest $request GetApplicationAuthorizationServicePlatformResourceRequest
     * @param GetApplicationAuthorizationServicePlatformResourceHeaders $headers GetApplicationAuthorizationServicePlatformResourceHeaders
     * @param RuntimeOptions                                            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetApplicationAuthorizationServicePlatformResourceResponse GetApplicationAuthorizationServicePlatformResourceResponse
     */
    public function getApplicationAuthorizationServicePlatformResourceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            $query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $query['instanceId'] = $request->instanceId;
        }
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
            'action' => 'GetApplicationAuthorizationServicePlatformResource',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/authorization/platformResources',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return GetApplicationAuthorizationServicePlatformResourceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道平台概览接口
     *  *
     * @param GetApplicationAuthorizationServicePlatformResourceRequest $request GetApplicationAuthorizationServicePlatformResourceRequest
     *
     * @return GetApplicationAuthorizationServicePlatformResourceResponse GetApplicationAuthorizationServicePlatformResourceResponse
     */
    public function getApplicationAuthorizationServicePlatformResource($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetApplicationAuthorizationServicePlatformResourceHeaders([]);

        return $this->getApplicationAuthorizationServicePlatformResourceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取自动化流日志详情
     *  *
     * @param GetAutoFlowLogDetailRequest $request GetAutoFlowLogDetailRequest
     * @param GetAutoFlowLogDetailHeaders $headers GetAutoFlowLogDetailHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAutoFlowLogDetailResponse GetAutoFlowLogDetailResponse
     */
    public function getAutoFlowLogDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->env)) {
            $query['env'] = $request->env;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->procInstanceId)) {
            $query['procInstanceId'] = $request->procInstanceId;
        }
        if (!Utils::isUnset($request->token)) {
            $query['token'] = $request->token;
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
            'action' => 'GetAutoFlowLogDetail',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/logs/automations',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetAutoFlowLogDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取自动化流日志详情
     *  *
     * @param GetAutoFlowLogDetailRequest $request GetAutoFlowLogDetailRequest
     *
     * @return GetAutoFlowLogDetailResponse GetAutoFlowLogDetailResponse
     */
    public function getAutoFlowLogDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAutoFlowLogDetailHeaders([]);

        return $this->getAutoFlowLogDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询已完成任务列表
     *  *
     * @param string                            $corpId
     * @param string                            $userId
     * @param GetCorpAccomplishmentTasksRequest $request GetCorpAccomplishmentTasksRequest
     * @param GetCorpAccomplishmentTasksHeaders $headers GetCorpAccomplishmentTasksHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCorpAccomplishmentTasksResponse GetCorpAccomplishmentTasksResponse
     */
    public function getCorpAccomplishmentTasksWithOptions($corpId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appTypes)) {
            $query['appTypes'] = $request->appTypes;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $query['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $query['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->env)) {
            $query['env'] = $request->env;
        }
        if (!Utils::isUnset($request->keyword)) {
            $query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->processCodes)) {
            $query['processCodes'] = $request->processCodes;
        }
        if (!Utils::isUnset($request->token)) {
            $query['token'] = $request->token;
        }
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
            'action' => 'GetCorpAccomplishmentTasks',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/tasks/completedTasks/' . $corpId . '/' . $userId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetCorpAccomplishmentTasksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询已完成任务列表
     *  *
     * @param string                            $corpId
     * @param string                            $userId
     * @param GetCorpAccomplishmentTasksRequest $request GetCorpAccomplishmentTasksRequest
     *
     * @return GetCorpAccomplishmentTasksResponse GetCorpAccomplishmentTasksResponse
     */
    public function getCorpAccomplishmentTasks($corpId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCorpAccomplishmentTasksHeaders([]);

        return $this->getCorpAccomplishmentTasksWithOptions($corpId, $userId, $request, $headers, $runtime);
    }

    /**
     * @summary 根据accountId获取企业等级
     *  *
     * @param GetCorpLevelByAccountIdRequest $request GetCorpLevelByAccountIdRequest
     * @param GetCorpLevelByAccountIdHeaders $headers GetCorpLevelByAccountIdHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCorpLevelByAccountIdResponse GetCorpLevelByAccountIdResponse
     */
    public function getCorpLevelByAccountIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountId)) {
            $query['accountId'] = $request->accountId;
        }
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
            'action' => 'GetCorpLevelByAccountId',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/corpLevel',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return GetCorpLevelByAccountIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据accountId获取企业等级
     *  *
     * @param GetCorpLevelByAccountIdRequest $request GetCorpLevelByAccountIdRequest
     *
     * @return GetCorpLevelByAccountIdResponse GetCorpLevelByAccountIdResponse
     */
    public function getCorpLevelByAccountId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCorpLevelByAccountIdHeaders([]);

        return $this->getCorpLevelByAccountIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询待办任务列表
     *  *
     * @param GetCorpTasksRequest $request GetCorpTasksRequest
     * @param GetCorpTasksHeaders $headers GetCorpTasksHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCorpTasksResponse GetCorpTasksResponse
     */
    public function getCorpTasksWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appTypes)) {
            $query['appTypes'] = $request->appTypes;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $query['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $query['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->env)) {
            $query['env'] = $request->env;
        }
        if (!Utils::isUnset($request->keyword)) {
            $query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->processCodes)) {
            $query['processCodes'] = $request->processCodes;
        }
        if (!Utils::isUnset($request->token)) {
            $query['token'] = $request->token;
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
            'action' => 'GetCorpTasks',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/corpTasks',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetCorpTasksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询待办任务列表
     *  *
     * @param GetCorpTasksRequest $request GetCorpTasksRequest
     *
     * @return GetCorpTasksResponse GetCorpTasksResponse
     */
    public function getCorpTasks($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCorpTasksHeaders([]);

        return $this->getCorpTasksWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取数据库连接串信息
     *  *
     * @param GetDbConfigRequest $request GetDbConfigRequest
     * @param GetDbConfigHeaders $headers GetDbConfigHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDbConfigResponse GetDbConfigResponse
     */
    public function getDbConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'GetDbConfig',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/metadata/dbConfigs',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetDbConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取数据库连接串信息
     *  *
     * @param GetDbConfigRequest $request GetDbConfigRequest
     *
     * @return GetDbConfigResponse GetDbConfigResponse
     */
    public function getDbConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDbConfigHeaders([]);

        return $this->getDbConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据表单ID获取字段信息
     *  *
     * @param GetFieldDefByUuidRequest $request GetFieldDefByUuidRequest
     * @param GetFieldDefByUuidHeaders $headers GetFieldDefByUuidHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFieldDefByUuidResponse GetFieldDefByUuidResponse
     */
    public function getFieldDefByUuidWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $query['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'GetFieldDefByUuid',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/formFields',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetFieldDefByUuidResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据表单ID获取字段信息
     *  *
     * @param GetFieldDefByUuidRequest $request GetFieldDefByUuidRequest
     *
     * @return GetFieldDefByUuidResponse GetFieldDefByUuidResponse
     */
    public function getFieldDefByUuid($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFieldDefByUuidHeaders([]);

        return $this->getFieldDefByUuidWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取表单定义
     *  *
     * @param string                                $appType
     * @param string                                $formUuid
     * @param GetFormComponentDefinitionListRequest $request  GetFormComponentDefinitionListRequest
     * @param GetFormComponentDefinitionListHeaders $headers  GetFormComponentDefinitionListHeaders
     * @param RuntimeOptions                        $runtime  runtime options for this request RuntimeOptions
     *
     * @return GetFormComponentDefinitionListResponse GetFormComponentDefinitionListResponse
     */
    public function getFormComponentDefinitionListWithOptions($appType, $formUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->version)) {
            $query['version'] = $request->version;
        }
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
            'action' => 'GetFormComponentDefinitionList',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/definitions/' . $appType . '/' . $formUuid . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetFormComponentDefinitionListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取表单定义
     *  *
     * @param string                                $appType
     * @param string                                $formUuid
     * @param GetFormComponentDefinitionListRequest $request  GetFormComponentDefinitionListRequest
     *
     * @return GetFormComponentDefinitionListResponse GetFormComponentDefinitionListResponse
     */
    public function getFormComponentDefinitionList($appType, $formUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFormComponentDefinitionListHeaders([]);

        return $this->getFormComponentDefinitionListWithOptions($appType, $formUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 根据表单 ID 查询实例详情
     *  *
     * @param string                 $id
     * @param GetFormDataByIDRequest $request GetFormDataByIDRequest
     * @param GetFormDataByIDHeaders $headers GetFormDataByIDHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFormDataByIDResponse GetFormDataByIDResponse
     */
    public function getFormDataByIDWithOptions($id, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'GetFormDataByID',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/instances/' . $id . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetFormDataByIDResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据表单 ID 查询实例详情
     *  *
     * @param string                 $id
     * @param GetFormDataByIDRequest $request GetFormDataByIDRequest
     *
     * @return GetFormDataByIDResponse GetFormDataByIDResponse
     */
    public function getFormDataByID($id, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFormDataByIDHeaders([]);

        return $this->getFormDataByIDWithOptions($id, $request, $headers, $runtime);
    }

    /**
     * @summary 获取应用内表单列表信息
     *  *
     * @param GetFormListInAppRequest $request GetFormListInAppRequest
     * @param GetFormListInAppHeaders $headers GetFormListInAppHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFormListInAppResponse GetFormListInAppResponse
     */
    public function getFormListInAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formTypes)) {
            $query['formTypes'] = $request->formTypes;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'GetFormListInApp',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetFormListInAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取应用内表单列表信息
     *  *
     * @param GetFormListInAppRequest $request GetFormListInAppRequest
     *
     * @return GetFormListInAppResponse GetFormListInAppResponse
     */
    public function getFormListInApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFormListInAppHeaders([]);

        return $this->getFormListInAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据实例 ID 获取流程实例详情
     *  *
     * @param string                 $id
     * @param GetInstanceByIdRequest $request GetInstanceByIdRequest
     * @param GetInstanceByIdHeaders $headers GetInstanceByIdHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetInstanceByIdResponse GetInstanceByIdResponse
     */
    public function getInstanceByIdWithOptions($id, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'GetInstanceById',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/processes/instancesInfos/' . $id . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetInstanceByIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据实例 ID 获取流程实例详情
     *  *
     * @param string                 $id
     * @param GetInstanceByIdRequest $request GetInstanceByIdRequest
     *
     * @return GetInstanceByIdResponse GetInstanceByIdResponse
     */
    public function getInstanceById($id, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInstanceByIdHeaders([]);

        return $this->getInstanceByIdWithOptions($id, $request, $headers, $runtime);
    }

    /**
     * @summary 根据条件搜索流程实例 ID
     *  *
     * @param GetInstanceIdListRequest $request GetInstanceIdListRequest
     * @param GetInstanceIdListHeaders $headers GetInstanceIdListHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetInstanceIdListResponse GetInstanceIdListResponse
     */
    public function getInstanceIdListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->approvedResult)) {
            $body['approvedResult'] = $request->approvedResult;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->instanceStatus)) {
            $body['instanceStatus'] = $request->instanceStatus;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            $body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            $body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->originatorId)) {
            $body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            $body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->taskId)) {
            $body['taskId'] = $request->taskId;
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetInstanceIdList',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/processes/instanceIds',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetInstanceIdListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据条件搜索流程实例 ID
     *  *
     * @param GetInstanceIdListRequest $request GetInstanceIdListRequest
     *
     * @return GetInstanceIdListResponse GetInstanceIdListResponse
     */
    public function getInstanceIdList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInstanceIdListHeaders([]);

        return $this->getInstanceIdListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据搜索条件获取流程表单实例详情
     *  *
     * @param GetInstancesRequest $request GetInstancesRequest
     * @param GetInstancesHeaders $headers GetInstancesHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetInstancesResponse GetInstancesResponse
     */
    public function getInstancesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->approvedResult)) {
            $body['approvedResult'] = $request->approvedResult;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->instanceStatus)) {
            $body['instanceStatus'] = $request->instanceStatus;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            $body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            $body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->orderConfigJson)) {
            $body['orderConfigJson'] = $request->orderConfigJson;
        }
        if (!Utils::isUnset($request->originatorId)) {
            $body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            $body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->taskId)) {
            $body['taskId'] = $request->taskId;
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetInstances',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/processes/instances',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetInstancesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据搜索条件获取流程表单实例详情
     *  *
     * @param GetInstancesRequest $request GetInstancesRequest
     *
     * @return GetInstancesResponse GetInstancesResponse
     */
    public function getInstances($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInstancesHeaders([]);

        return $this->getInstancesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据实例 ID 列表批量获取流程实例详情
     *  *
     * @param GetInstancesByIdListRequest $request GetInstancesByIdListRequest
     * @param GetInstancesByIdListHeaders $headers GetInstancesByIdListHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetInstancesByIdListResponse GetInstancesByIdListResponse
     */
    public function getInstancesByIdListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processInstanceIds)) {
            $query['processInstanceIds'] = $request->processInstanceIds;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'GetInstancesByIdList',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/processes/instances/searchWithIds',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetInstancesByIdListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据实例 ID 列表批量获取流程实例详情
     *  *
     * @param GetInstancesByIdListRequest $request GetInstancesByIdListRequest
     *
     * @return GetInstancesByIdListResponse GetInstancesByIdListResponse
     */
    public function getInstancesByIdList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInstancesByIdListHeaders([]);

        return $this->getInstancesByIdListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询已提交任务列表
     *  *
     * @param string                     $userId
     * @param GetMeCorpSubmissionRequest $request GetMeCorpSubmissionRequest
     * @param GetMeCorpSubmissionHeaders $headers GetMeCorpSubmissionHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetMeCorpSubmissionResponse GetMeCorpSubmissionResponse
     */
    public function getMeCorpSubmissionWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appTypes)) {
            $query['appTypes'] = $request->appTypes;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $query['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $query['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->env)) {
            $query['env'] = $request->env;
        }
        if (!Utils::isUnset($request->keyword)) {
            $query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->processCodes)) {
            $query['processCodes'] = $request->processCodes;
        }
        if (!Utils::isUnset($request->token)) {
            $query['token'] = $request->token;
        }
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
            'action' => 'GetMeCorpSubmission',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/tasks/myCorpSubmission/' . $userId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetMeCorpSubmissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询已提交任务列表
     *  *
     * @param string                     $userId
     * @param GetMeCorpSubmissionRequest $request GetMeCorpSubmissionRequest
     *
     * @return GetMeCorpSubmissionResponse GetMeCorpSubmissionResponse
     */
    public function getMeCorpSubmission($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMeCorpSubmissionHeaders([]);

        return $this->getMeCorpSubmissionWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询抄送我的任务列表（企业维度）
     *  *
     * @param string             $userId
     * @param GetNotifyMeRequest $request GetNotifyMeRequest
     * @param GetNotifyMeHeaders $headers GetNotifyMeHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetNotifyMeResponse GetNotifyMeResponse
     */
    public function getNotifyMeWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appTypes)) {
            $query['appTypes'] = $request->appTypes;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $query['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $query['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->env)) {
            $query['env'] = $request->env;
        }
        if (!Utils::isUnset($request->instanceCreateFromTimeGMT)) {
            $query['instanceCreateFromTimeGMT'] = $request->instanceCreateFromTimeGMT;
        }
        if (!Utils::isUnset($request->instanceCreateToTimeGMT)) {
            $query['instanceCreateToTimeGMT'] = $request->instanceCreateToTimeGMT;
        }
        if (!Utils::isUnset($request->keyword)) {
            $query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->processCodes)) {
            $query['processCodes'] = $request->processCodes;
        }
        if (!Utils::isUnset($request->token)) {
            $query['token'] = $request->token;
        }
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
            'action' => 'GetNotifyMe',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/corpNotifications/' . $userId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetNotifyMeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询抄送我的任务列表（企业维度）
     *  *
     * @param string             $userId
     * @param GetNotifyMeRequest $request GetNotifyMeRequest
     *
     * @return GetNotifyMeResponse GetNotifyMeResponse
     */
    public function getNotifyMe($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetNotifyMeHeaders([]);

        return $this->getNotifyMeWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 附件地址转临时免登地址
     *  *
     * @param string            $appType
     * @param GetOpenUrlRequest $request GetOpenUrlRequest
     * @param GetOpenUrlHeaders $headers GetOpenUrlHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOpenUrlResponse GetOpenUrlResponse
     */
    public function getOpenUrlWithOptions($appType, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->fileUrl)) {
            $query['fileUrl'] = $request->fileUrl;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->timeout)) {
            $query['timeout'] = $request->timeout;
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
            'action' => 'GetOpenUrl',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/temporaryUrls/' . $appType . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetOpenUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 附件地址转临时免登地址
     *  *
     * @param string            $appType
     * @param GetOpenUrlRequest $request GetOpenUrlRequest
     *
     * @return GetOpenUrlResponse GetOpenUrlResponse
     */
    public function getOpenUrl($appType, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOpenUrlHeaders([]);

        return $this->getOpenUrlWithOptions($appType, $request, $headers, $runtime);
    }

    /**
     * @summary 获取审批记录
     *  *
     * @param GetOperationRecordsRequest $request GetOperationRecordsRequest
     * @param GetOperationRecordsHeaders $headers GetOperationRecordsHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOperationRecordsResponse GetOperationRecordsResponse
     */
    public function getOperationRecordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $query['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'GetOperationRecords',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/processes/operationRecords',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetOperationRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取审批记录
     *  *
     * @param GetOperationRecordsRequest $request GetOperationRecordsRequest
     *
     * @return GetOperationRecordsResponse GetOperationRecordsResponse
     */
    public function getOperationRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOperationRecordsHeaders([]);

        return $this->getOperationRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 多渠道平台概览接口
     *  *
     * @param GetPlatformResourceRequest $request GetPlatformResourceRequest
     * @param GetPlatformResourceHeaders $headers GetPlatformResourceHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPlatformResourceResponse GetPlatformResourceResponse
     */
    public function getPlatformResourceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            $query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $query['instanceId'] = $request->instanceId;
        }
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
            'action' => 'GetPlatformResource',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/platformResources',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return GetPlatformResourceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道平台概览接口
     *  *
     * @param GetPlatformResourceRequest $request GetPlatformResourceRequest
     *
     * @return GetPlatformResourceResponse GetPlatformResourceResponse
     */
    public function getPlatformResource($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPlatformResourceHeaders([]);

        return $this->getPlatformResourceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户开通打印模板的应用信息
     *  *
     * @param GetPrintAppInfoRequest $request GetPrintAppInfoRequest
     * @param GetPrintAppInfoHeaders $headers GetPrintAppInfoHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPrintAppInfoResponse GetPrintAppInfoResponse
     */
    public function getPrintAppInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->nameLike)) {
            $query['nameLike'] = $request->nameLike;
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
            'action' => 'GetPrintAppInfo',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/printTemplates/printAppInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return GetPrintAppInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户开通打印模板的应用信息
     *  *
     * @param GetPrintAppInfoRequest $request GetPrintAppInfoRequest
     *
     * @return GetPrintAppInfoResponse GetPrintAppInfoResponse
     */
    public function getPrintAppInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPrintAppInfoHeaders([]);

        return $this->getPrintAppInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取打印所需的表单与流程节点
     *  *
     * @param GetPrintDictionaryRequest $request GetPrintDictionaryRequest
     * @param GetPrintDictionaryHeaders $headers GetPrintDictionaryHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPrintDictionaryResponse GetPrintDictionaryResponse
     */
    public function getPrintDictionaryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $query['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->version)) {
            $query['version'] = $request->version;
        }
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
            'action' => 'GetPrintDictionary',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/printTemplates/printDictionaries',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return GetPrintDictionaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取打印所需的表单与流程节点
     *  *
     * @param GetPrintDictionaryRequest $request GetPrintDictionaryRequest
     *
     * @return GetPrintDictionaryResponse GetPrintDictionaryResponse
     */
    public function getPrintDictionary($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPrintDictionaryHeaders([]);

        return $this->getPrintDictionaryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取流程定义
     *  *
     * @param string                      $processInstanceId
     * @param GetProcessDefinitionRequest $request           GetProcessDefinitionRequest
     * @param GetProcessDefinitionHeaders $headers           GetProcessDefinitionHeaders
     * @param RuntimeOptions              $runtime           runtime options for this request RuntimeOptions
     *
     * @return GetProcessDefinitionResponse GetProcessDefinitionResponse
     */
    public function getProcessDefinitionWithOptions($processInstanceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->groupId)) {
            $query['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->nameSpace_)) {
            $query['nameSpace'] = $request->nameSpace_;
        }
        if (!Utils::isUnset($request->orderNumber)) {
            $query['orderNumber'] = $request->orderNumber;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->systemType)) {
            $query['systemType'] = $request->systemType;
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
            'action' => 'GetProcessDefinition',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/processes/definitions/' . $processInstanceId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetProcessDefinitionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取流程定义
     *  *
     * @param string                      $processInstanceId
     * @param GetProcessDefinitionRequest $request           GetProcessDefinitionRequest
     *
     * @return GetProcessDefinitionResponse GetProcessDefinitionResponse
     */
    public function getProcessDefinition($processInstanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProcessDefinitionHeaders([]);

        return $this->getProcessDefinitionWithOptions($processInstanceId, $request, $headers, $runtime);
    }

    /**
     * @summary 根据流程ID获取流程设计结构
     *  *
     * @param string                  $processId
     * @param GetProcessDesignRequest $request   GetProcessDesignRequest
     * @param GetProcessDesignHeaders $headers   GetProcessDesignHeaders
     * @param RuntimeOptions          $runtime   runtime options for this request RuntimeOptions
     *
     * @return GetProcessDesignResponse GetProcessDesignResponse
     */
    public function getProcessDesignWithOptions($processId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'GetProcessDesign',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/processes/' . $processId . 'definitions/designs',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetProcessDesignResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据流程ID获取流程设计结构
     *  *
     * @param string                  $processId
     * @param GetProcessDesignRequest $request   GetProcessDesignRequest
     *
     * @return GetProcessDesignResponse GetProcessDesignResponse
     */
    public function getProcessDesign($processId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProcessDesignHeaders([]);

        return $this->getProcessDesignWithOptions($processId, $request, $headers, $runtime);
    }

    /**
     * @summary 根据流程ID获取流程设计结构
     *  *
     * @param GetProcessDesignByCodeRequest $request GetProcessDesignByCodeRequest
     * @param GetProcessDesignByCodeHeaders $headers GetProcessDesignByCodeHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetProcessDesignByCodeResponse GetProcessDesignByCodeResponse
     */
    public function getProcessDesignByCodeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->processCode)) {
            $query['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->processId)) {
            $query['processId'] = $request->processId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'GetProcessDesignByCode',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/processes/designStructures',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetProcessDesignByCodeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据流程ID获取流程设计结构
     *  *
     * @param GetProcessDesignByCodeRequest $request GetProcessDesignByCodeRequest
     *
     * @return GetProcessDesignByCodeResponse GetProcessDesignByCodeResponse
     */
    public function getProcessDesignByCode($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProcessDesignByCodeHeaders([]);

        return $this->getProcessDesignByCodeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过实例id批量获取待办任务
     *  *
     * @param GetRunningTaskListRequest $request GetRunningTaskListRequest
     * @param GetRunningTaskListHeaders $headers GetRunningTaskListHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetRunningTaskListResponse GetRunningTaskListResponse
     */
    public function getRunningTaskListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->processInstanceIdList)) {
            $body['processInstanceIdList'] = $request->processInstanceIdList;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userCorpId)) {
            $body['userCorpId'] = $request->userCorpId;
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
            'action' => 'GetRunningTaskList',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/tasks/runningTasks/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetRunningTaskListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过实例id批量获取待办任务
     *  *
     * @param GetRunningTaskListRequest $request GetRunningTaskListRequest
     *
     * @return GetRunningTaskListResponse GetRunningTaskListResponse
     */
    public function getRunningTaskList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRunningTaskListHeaders([]);

        return $this->getRunningTaskListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询流程运行任务（vpc）
     *  *
     * @param GetRunningTasksRequest $request GetRunningTasksRequest
     * @param GetRunningTasksHeaders $headers GetRunningTasksHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetRunningTasksResponse GetRunningTasksResponse
     */
    public function getRunningTasksWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $query['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'GetRunningTasks',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/processes/tasks/getRunningTasks',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetRunningTasksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询流程运行任务（vpc）
     *  *
     * @param GetRunningTasksRequest $request GetRunningTasksRequest
     *
     * @return GetRunningTasksResponse GetRunningTasksResponse
     */
    public function getRunningTasks($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRunningTasksHeaders([]);

        return $this->getRunningTasksWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据用户employeeCode获取所在企业信息(包含售卖版本)
     *  *
     * @param GetSaleUserInfoByUserIdRequest $request GetSaleUserInfoByUserIdRequest
     * @param GetSaleUserInfoByUserIdHeaders $headers GetSaleUserInfoByUserIdHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSaleUserInfoByUserIdResponse GetSaleUserInfoByUserIdResponse
     */
    public function getSaleUserInfoByUserIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->namespace_)) {
            $query['namespace'] = $request->namespace_;
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
            'action' => 'GetSaleUserInfoByUserId',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/saleUserInfo',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return GetSaleUserInfoByUserIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据用户employeeCode获取所在企业信息(包含售卖版本)
     *  *
     * @param GetSaleUserInfoByUserIdRequest $request GetSaleUserInfoByUserIdRequest
     *
     * @return GetSaleUserInfoByUserIdResponse GetSaleUserInfoByUserIdResponse
     */
    public function getSaleUserInfoByUserId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSaleUserInfoByUserIdHeaders([]);

        return $this->getSaleUserInfoByUserIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 表单的元数据(字段)查询接口
     *  *
     * @param GetSimpleCubeModelListRequest $request GetSimpleCubeModelListRequest
     * @param GetSimpleCubeModelListHeaders $headers GetSimpleCubeModelListHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSimpleCubeModelListResponse GetSimpleCubeModelListResponse
     */
    public function getSimpleCubeModelListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->cubeCode)) {
            $query['cubeCode'] = $request->cubeCode;
        }
        if (!Utils::isUnset($request->cubeTenantId)) {
            $query['cubeTenantId'] = $request->cubeTenantId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'GetSimpleCubeModelList',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/metadata/simpleCubeModelLists',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSimpleCubeModelListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 表单的元数据(字段)查询接口
     *  *
     * @param GetSimpleCubeModelListRequest $request GetSimpleCubeModelListRequest
     *
     * @return GetSimpleCubeModelListResponse GetSimpleCubeModelListResponse
     */
    public function getSimpleCubeModelList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSimpleCubeModelListHeaders([]);

        return $this->getSimpleCubeModelListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询抄送我的任务列表（应用维度）
     *  *
     * @param GetTaskCopiesRequest $request GetTaskCopiesRequest
     * @param GetTaskCopiesHeaders $headers GetTaskCopiesHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTaskCopiesResponse GetTaskCopiesResponse
     */
    public function getTaskCopiesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $query['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $query['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->keyword)) {
            $query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->processCodes)) {
            $query['processCodes'] = $request->processCodes;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'GetTaskCopies',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/tasks/taskCopies',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetTaskCopiesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询抄送我的任务列表（应用维度）
     *  *
     * @param GetTaskCopiesRequest $request GetTaskCopiesRequest
     *
     * @return GetTaskCopiesResponse GetTaskCopiesResponse
     */
    public function getTaskCopies($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTaskCopiesHeaders([]);

        return $this->getTaskCopiesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取组织下的宜搭应用列表
     *  *
     * @param ListApplicationRequest $request ListApplicationRequest
     * @param ListApplicationHeaders $headers ListApplicationHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ListApplicationResponse ListApplicationResponse
     */
    public function listApplicationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appFilter)) {
            $query['appFilter'] = $request->appFilter;
        }
        if (!Utils::isUnset($request->appNameSearchKeyword)) {
            $query['appNameSearchKeyword'] = $request->appNameSearchKeyword;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->env)) {
            $query['env'] = $request->env;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->token)) {
            $query['token'] = $request->token;
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
            'action' => 'ListApplication',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/organizations/applications',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListApplicationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取组织下的宜搭应用列表
     *  *
     * @param ListApplicationRequest $request ListApplicationRequest
     *
     * @return ListApplicationResponse ListApplicationResponse
     */
    public function listApplication($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListApplicationHeaders([]);

        return $this->listApplicationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 多渠道应用概览
     *  *
     * @param string                                                           $instanceId
     * @param ListApplicationAuthorizationServiceApplicationInformationRequest $request    ListApplicationAuthorizationServiceApplicationInformationRequest
     * @param ListApplicationAuthorizationServiceApplicationInformationHeaders $headers    ListApplicationAuthorizationServiceApplicationInformationHeaders
     * @param RuntimeOptions                                                   $runtime    runtime options for this request RuntimeOptions
     *
     * @return ListApplicationAuthorizationServiceApplicationInformationResponse ListApplicationAuthorizationServiceApplicationInformationResponse
     */
    public function listApplicationAuthorizationServiceApplicationInformationWithOptions($instanceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            $query['callerUnionId'] = $request->callerUnionId;
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
            'action' => 'ListApplicationAuthorizationServiceApplicationInformation',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/authorizations/applicationInfos/' . $instanceId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return ListApplicationAuthorizationServiceApplicationInformationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道应用概览
     *  *
     * @param string                                                           $instanceId
     * @param ListApplicationAuthorizationServiceApplicationInformationRequest $request    ListApplicationAuthorizationServiceApplicationInformationRequest
     *
     * @return ListApplicationAuthorizationServiceApplicationInformationResponse ListApplicationAuthorizationServiceApplicationInformationResponse
     */
    public function listApplicationAuthorizationServiceApplicationInformation($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListApplicationAuthorizationServiceApplicationInformationHeaders([]);

        return $this->listApplicationAuthorizationServiceApplicationInformationWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @summary 多渠道插件概览
     *  *
     * @param string                                                         $instanceId
     * @param ListApplicationAuthorizationServiceConnectorInformationRequest $request    ListApplicationAuthorizationServiceConnectorInformationRequest
     * @param ListApplicationAuthorizationServiceConnectorInformationHeaders $headers    ListApplicationAuthorizationServiceConnectorInformationHeaders
     * @param RuntimeOptions                                                 $runtime    runtime options for this request RuntimeOptions
     *
     * @return ListApplicationAuthorizationServiceConnectorInformationResponse ListApplicationAuthorizationServiceConnectorInformationResponse
     */
    public function listApplicationAuthorizationServiceConnectorInformationWithOptions($instanceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            $query['callerUid'] = $request->callerUid;
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
            'action' => 'ListApplicationAuthorizationServiceConnectorInformation',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/applicationAuthorizations/plugs/' . $instanceId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return ListApplicationAuthorizationServiceConnectorInformationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道插件概览
     *  *
     * @param string                                                         $instanceId
     * @param ListApplicationAuthorizationServiceConnectorInformationRequest $request    ListApplicationAuthorizationServiceConnectorInformationRequest
     *
     * @return ListApplicationAuthorizationServiceConnectorInformationResponse ListApplicationAuthorizationServiceConnectorInformationResponse
     */
    public function listApplicationAuthorizationServiceConnectorInformation($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListApplicationAuthorizationServiceConnectorInformationHeaders([]);

        return $this->listApplicationAuthorizationServiceConnectorInformationWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @summary 多渠道应用概览
     *  *
     * @param string                            $instanceId
     * @param ListApplicationInformationRequest $request    ListApplicationInformationRequest
     * @param ListApplicationInformationHeaders $headers    ListApplicationInformationHeaders
     * @param RuntimeOptions                    $runtime    runtime options for this request RuntimeOptions
     *
     * @return ListApplicationInformationResponse ListApplicationInformationResponse
     */
    public function listApplicationInformationWithOptions($instanceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            $query['callerUid'] = $request->callerUid;
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
            'action' => 'ListApplicationInformation',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/infos/' . $instanceId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return ListApplicationInformationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道应用概览
     *  *
     * @param string                            $instanceId
     * @param ListApplicationInformationRequest $request    ListApplicationInformationRequest
     *
     * @return ListApplicationInformationResponse ListApplicationInformationResponse
     */
    public function listApplicationInformation($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListApplicationInformationHeaders([]);

        return $this->listApplicationInformationWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @summary 多渠道列出商品列表
     *  *
     * @param ListCommodityRequest $request ListCommodityRequest
     * @param ListCommodityHeaders $headers ListCommodityHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return ListCommodityResponse ListCommodityResponse
     */
    public function listCommodityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            $query['callerUid'] = $request->callerUid;
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
            'action' => 'ListCommodity',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/appAuth/commodities',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return ListCommodityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道列出商品列表
     *  *
     * @param ListCommodityRequest $request ListCommodityRequest
     *
     * @return ListCommodityResponse ListCommodityResponse
     */
    public function listCommodity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListCommodityHeaders([]);

        return $this->listCommodityWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 多渠道插件概览
     *  *
     * @param string                          $instanceId
     * @param ListConnectorInformationRequest $request    ListConnectorInformationRequest
     * @param ListConnectorInformationHeaders $headers    ListConnectorInformationHeaders
     * @param RuntimeOptions                  $runtime    runtime options for this request RuntimeOptions
     *
     * @return ListConnectorInformationResponse ListConnectorInformationResponse
     */
    public function listConnectorInformationWithOptions($instanceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            $query['callerUid'] = $request->callerUid;
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
            'action' => 'ListConnectorInformation',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/plugins/infos/' . $instanceId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return ListConnectorInformationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道插件概览
     *  *
     * @param string                          $instanceId
     * @param ListConnectorInformationRequest $request    ListConnectorInformationRequest
     *
     * @return ListConnectorInformationResponse ListConnectorInformationResponse
     */
    public function listConnectorInformation($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListConnectorInformationHeaders([]);

        return $this->listConnectorInformationWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询表单实例评论列表
     *  *
     * @param ListFormRemarksRequest $request ListFormRemarksRequest
     * @param ListFormRemarksHeaders $headers ListFormRemarksHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ListFormRemarksResponse ListFormRemarksResponse
     */
    public function listFormRemarksWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formInstanceIdList)) {
            $body['formInstanceIdList'] = $request->formInstanceIdList;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'ListFormRemarks',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/remarks/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListFormRemarksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询表单实例评论列表
     *  *
     * @param ListFormRemarksRequest $request ListFormRemarksRequest
     *
     * @return ListFormRemarksResponse ListFormRemarksResponse
     */
    public function listFormRemarks($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListFormRemarksHeaders([]);

        return $this->listFormRemarksWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取应用下的页面列表
     *  *
     * @param ListNavigationByFormTypeRequest $request ListNavigationByFormTypeRequest
     * @param ListNavigationByFormTypeHeaders $headers ListNavigationByFormTypeHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return ListNavigationByFormTypeResponse ListNavigationByFormTypeResponse
     */
    public function listNavigationByFormTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formType)) {
            $query['formType'] = $request->formType;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'ListNavigationByFormType',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/navigations',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return ListNavigationByFormTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取应用下的页面列表
     *  *
     * @param ListNavigationByFormTypeRequest $request ListNavigationByFormTypeRequest
     *
     * @return ListNavigationByFormTypeResponse ListNavigationByFormTypeResponse
     */
    public function listNavigationByFormType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListNavigationByFormTypeHeaders([]);

        return $this->listNavigationByFormTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询表单的变更记录
     *  *
     * @param ListOperationLogsRequest $request ListOperationLogsRequest
     * @param ListOperationLogsHeaders $headers ListOperationLogsHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return ListOperationLogsResponse ListOperationLogsResponse
     */
    public function listOperationLogsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formInstanceIdList)) {
            $body['formInstanceIdList'] = $request->formInstanceIdList;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'ListOperationLogs',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/operationsLogs/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListOperationLogsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询表单的变更记录
     *  *
     * @param ListOperationLogsRequest $request ListOperationLogsRequest
     *
     * @return ListOperationLogsResponse ListOperationLogsResponse
     */
    public function listOperationLogs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListOperationLogsHeaders([]);

        return $this->listOperationLogsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取子表单数据
     *  *
     * @param string                                      $formInstanceId
     * @param ListTableDataByFormInstanceIdTableIdRequest $request        ListTableDataByFormInstanceIdTableIdRequest
     * @param ListTableDataByFormInstanceIdTableIdHeaders $headers        ListTableDataByFormInstanceIdTableIdHeaders
     * @param RuntimeOptions                              $runtime        runtime options for this request RuntimeOptions
     *
     * @return ListTableDataByFormInstanceIdTableIdResponse ListTableDataByFormInstanceIdTableIdResponse
     */
    public function listTableDataByFormInstanceIdTableIdWithOptions($formInstanceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $query['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->needRowId)) {
            $query['needRowId'] = $request->needRowId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->tableFieldId)) {
            $query['tableFieldId'] = $request->tableFieldId;
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
            'action' => 'ListTableDataByFormInstanceIdTableId',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/innerTables/' . $formInstanceId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListTableDataByFormInstanceIdTableIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取子表单数据
     *  *
     * @param string                                      $formInstanceId
     * @param ListTableDataByFormInstanceIdTableIdRequest $request        ListTableDataByFormInstanceIdTableIdRequest
     *
     * @return ListTableDataByFormInstanceIdTableIdResponse ListTableDataByFormInstanceIdTableIdResponse
     */
    public function listTableDataByFormInstanceIdTableId($formInstanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListTableDataByFormInstanceIdTableIdHeaders([]);

        return $this->listTableDataByFormInstanceIdTableIdWithOptions($formInstanceId, $request, $headers, $runtime);
    }

    /**
     * @summary 生成宜搭登录态穿透用的code
     *  *
     * @param LoginCodeGenRequest $request LoginCodeGenRequest
     * @param LoginCodeGenHeaders $headers LoginCodeGenHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return LoginCodeGenResponse LoginCodeGenResponse
     */
    public function loginCodeGenWithOptions($request, $headers, $runtime)
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
            'action' => 'LoginCodeGen',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/authorizations/loginCodes',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return LoginCodeGenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 生成宜搭登录态穿透用的code
     *  *
     * @param LoginCodeGenRequest $request LoginCodeGenRequest
     *
     * @return LoginCodeGenResponse LoginCodeGenResponse
     */
    public function loginCodeGen($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LoginCodeGenHeaders([]);

        return $this->loginCodeGenWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通知宜搭授权(购买)结果
     *  *
     * @param NotifyAuthorizationResultRequest $request NotifyAuthorizationResultRequest
     * @param NotifyAuthorizationResultHeaders $headers NotifyAuthorizationResultHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return NotifyAuthorizationResultResponse NotifyAuthorizationResultResponse
     */
    public function notifyAuthorizationResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accessKey)) {
            $body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->accountNumber)) {
            $body['accountNumber'] = $request->accountNumber;
        }
        if (!Utils::isUnset($request->beginTimeGMT)) {
            $body['beginTimeGMT'] = $request->beginTimeGMT;
        }
        if (!Utils::isUnset($request->callerUid)) {
            $body['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->chargeType)) {
            $body['chargeType'] = $request->chargeType;
        }
        if (!Utils::isUnset($request->commerceType)) {
            $body['commerceType'] = $request->commerceType;
        }
        if (!Utils::isUnset($request->commodityType)) {
            $body['commodityType'] = $request->commodityType;
        }
        if (!Utils::isUnset($request->endTimeGMT)) {
            $body['endTimeGMT'] = $request->endTimeGMT;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->instanceName)) {
            $body['instanceName'] = $request->instanceName;
        }
        if (!Utils::isUnset($request->produceCode)) {
            $body['produceCode'] = $request->produceCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'NotifyAuthorizationResult',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/authorizationResults/notify',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return NotifyAuthorizationResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通知宜搭授权(购买)结果
     *  *
     * @param NotifyAuthorizationResultRequest $request NotifyAuthorizationResultRequest
     *
     * @return NotifyAuthorizationResultResponse NotifyAuthorizationResultResponse
     */
    public function notifyAuthorizationResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NotifyAuthorizationResultHeaders([]);

        return $this->notifyAuthorizationResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页查询宜搭流程自动化运行记录
     *  *
     * @param PageAutoFlowLogRequest $request PageAutoFlowLogRequest
     * @param PageAutoFlowLogHeaders $headers PageAutoFlowLogHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return PageAutoFlowLogResponse PageAutoFlowLogResponse
     */
    public function pageAutoFlowLogWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->endTimeGMT)) {
            $body['endTimeGMT'] = $request->endTimeGMT;
        }
        if (!Utils::isUnset($request->env)) {
            $body['env'] = $request->env;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->processCode)) {
            $body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->startTimeGMT)) {
            $body['startTimeGMT'] = $request->startTimeGMT;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->token)) {
            $body['token'] = $request->token;
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
            'action' => 'PageAutoFlowLog',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/logs/automations/paginationQuery',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PageAutoFlowLogResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页查询宜搭流程自动化运行记录
     *  *
     * @param PageAutoFlowLogRequest $request PageAutoFlowLogRequest
     *
     * @return PageAutoFlowLogResponse PageAutoFlowLogResponse
     */
    public function pageAutoFlowLog($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageAutoFlowLogHeaders([]);

        return $this->pageAutoFlowLogWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页获取应用下表单列表
     *  *
     * @param PageFormBaseInfosRequest $request PageFormBaseInfosRequest
     * @param PageFormBaseInfosHeaders $headers PageFormBaseInfosHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return PageFormBaseInfosResponse PageFormBaseInfosResponse
     */
    public function pageFormBaseInfosWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appKey)) {
            $body['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->formTypeList)) {
            $body['formTypeList'] = $request->formTypeList;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->pageIndex)) {
            $body['pageIndex'] = $request->pageIndex;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'PageFormBaseInfos',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/forms/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PageFormBaseInfosResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页获取应用下表单列表
     *  *
     * @param PageFormBaseInfosRequest $request PageFormBaseInfosRequest
     *
     * @return PageFormBaseInfosResponse PageFormBaseInfosResponse
     */
    public function pageFormBaseInfos($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageFormBaseInfosHeaders([]);

        return $this->pageFormBaseInfosWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 预览审批流程
     *  *
     * @param PreviewPublishedProcessRequest $request PreviewPublishedProcessRequest
     * @param PreviewPublishedProcessHeaders $headers PreviewPublishedProcessHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return PreviewPublishedProcessResponse PreviewPublishedProcessResponse
     */
    public function previewPublishedProcessWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->departmentId)) {
            $body['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            $body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processCode)) {
            $body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'PreviewPublishedProcess',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/processes/preview',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PreviewPublishedProcessResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 预览审批流程
     *  *
     * @param PreviewPublishedProcessRequest $request PreviewPublishedProcessRequest
     *
     * @return PreviewPublishedProcessResponse PreviewPublishedProcessResponse
     */
    public function previewPublishedProcess($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PreviewPublishedProcessHeaders([]);

        return $this->previewPublishedProcessWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询服务调用记录
     *  *
     * @param QueryServiceRecordRequest $request QueryServiceRecordRequest
     * @param QueryServiceRecordHeaders $headers QueryServiceRecordHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryServiceRecordResponse QueryServiceRecordResponse
     */
    public function queryServiceRecordWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $query['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->hookType)) {
            $query['hookType'] = $request->hookType;
        }
        if (!Utils::isUnset($request->hookUuid)) {
            $query['hookUuid'] = $request->hookUuid;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $query['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->invokeAfterDateGMT)) {
            $query['invokeAfterDateGMT'] = $request->invokeAfterDateGMT;
        }
        if (!Utils::isUnset($request->invokeBeforeDateGMT)) {
            $query['invokeBeforeDateGMT'] = $request->invokeBeforeDateGMT;
        }
        if (!Utils::isUnset($request->invokeStatus)) {
            $query['invokeStatus'] = $request->invokeStatus;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->requestUrl)) {
            $query['requestUrl'] = $request->requestUrl;
        }
        if (!Utils::isUnset($request->sourceUuid)) {
            $query['sourceUuid'] = $request->sourceUuid;
        }
        if (!Utils::isUnset($request->success)) {
            $query['success'] = $request->success;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'QueryServiceRecord',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/services/invocationRecords',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryServiceRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询服务调用记录
     *  *
     * @param QueryServiceRecordRequest $request QueryServiceRecordRequest
     *
     * @return QueryServiceRecordResponse QueryServiceRecordResponse
     */
    public function queryServiceRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryServiceRecordHeaders([]);

        return $this->queryServiceRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 执行转交任务
     *  *
     * @param RedirectTaskRequest $request RedirectTaskRequest
     * @param RedirectTaskHeaders $headers RedirectTaskHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return RedirectTaskResponse RedirectTaskResponse
     */
    public function redirectTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->byManager)) {
            $body['byManager'] = $request->byManager;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->nowActionExecutorId)) {
            $body['nowActionExecutorId'] = $request->nowActionExecutorId;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->taskId)) {
            $body['taskId'] = $request->taskId;
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
            'action' => 'RedirectTask',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/tasks/redirect',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'none',
        ]);

        return RedirectTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 执行转交任务
     *  *
     * @param RedirectTaskRequest $request RedirectTaskRequest
     *
     * @return RedirectTaskResponse RedirectTaskResponse
     */
    public function redirectTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RedirectTaskHeaders([]);

        return $this->redirectTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 多渠道退款
     *  *
     * @param RefundCommodityRequest $request RefundCommodityRequest
     * @param RefundCommodityHeaders $headers RefundCommodityHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return RefundCommodityResponse RefundCommodityResponse
     */
    public function refundCommodityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            $query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $query['instanceId'] = $request->instanceId;
        }
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
            'action' => 'RefundCommodity',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/appAuth/commodities/refund',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return RefundCommodityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道退款
     *  *
     * @param RefundCommodityRequest $request RefundCommodityRequest
     *
     * @return RefundCommodityResponse RefundCommodityResponse
     */
    public function refundCommodity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RefundCommodityHeaders([]);

        return $this->refundCommodityWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 多渠道注册
     *  *
     * @param RegisterAccountsRequest $request RegisterAccountsRequest
     * @param RegisterAccountsHeaders $headers RegisterAccountsHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return RegisterAccountsResponse RegisterAccountsResponse
     */
    public function registerAccountsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accessKey)) {
            $body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->activeCode)) {
            $body['activeCode'] = $request->activeCode;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'RegisterAccounts',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/applicationAuthorizations/accounts/register',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return RegisterAccountsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道注册
     *  *
     * @param RegisterAccountsRequest $request RegisterAccountsRequest
     *
     * @return RegisterAccountsResponse RegisterAccountsResponse
     */
    public function registerAccounts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterAccountsHeaders([]);

        return $this->registerAccountsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 多渠道释放
     *  *
     * @param ReleaseCommodityRequest $request ReleaseCommodityRequest
     * @param ReleaseCommodityHeaders $headers ReleaseCommodityHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return ReleaseCommodityResponse ReleaseCommodityResponse
     */
    public function releaseCommodityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            $query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $query['instanceId'] = $request->instanceId;
        }
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
            'action' => 'ReleaseCommodity',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/appAuth/commodities/release',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return ReleaseCommodityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道释放
     *  *
     * @param ReleaseCommodityRequest $request ReleaseCommodityRequest
     *
     * @return ReleaseCommodityResponse ReleaseCommodityResponse
     */
    public function releaseCommodity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReleaseCommodityHeaders([]);

        return $this->releaseCommodityWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 租户到期30天后, 删除租户关联的资源
     *  *
     * @param string                      $callerUid
     * @param RemoveTenantResourceRequest $request   RemoveTenantResourceRequest
     * @param RemoveTenantResourceHeaders $headers   RemoveTenantResourceHeaders
     * @param RuntimeOptions              $runtime   runtime options for this request RuntimeOptions
     *
     * @return RemoveTenantResourceResponse RemoveTenantResourceResponse
     */
    public function removeTenantResourceWithOptions($callerUid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
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
            'action' => 'RemoveTenantResource',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/applications/tenantRelatedResources/' . $callerUid . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return RemoveTenantResourceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 租户到期30天后, 删除租户关联的资源
     *  *
     * @param string                      $callerUid
     * @param RemoveTenantResourceRequest $request   RemoveTenantResourceRequest
     *
     * @return RemoveTenantResourceResponse RemoveTenantResourceResponse
     */
    public function removeTenantResource($callerUid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveTenantResourceHeaders([]);

        return $this->removeTenantResourceWithOptions($callerUid, $request, $headers, $runtime);
    }

    /**
     * @summary 宜搭vpc批量打印回调
     *  *
     * @param RenderBatchCallbackRequest $request RenderBatchCallbackRequest
     * @param RenderBatchCallbackHeaders $headers RenderBatchCallbackHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return RenderBatchCallbackResponse RenderBatchCallbackResponse
     */
    public function renderBatchCallbackWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->fileSize)) {
            $body['fileSize'] = $request->fileSize;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->namespace_)) {
            $body['namespace'] = $request->namespace_;
        }
        if (!Utils::isUnset($request->ossUrl)) {
            $body['ossUrl'] = $request->ossUrl;
        }
        if (!Utils::isUnset($request->sequenceId)) {
            $body['sequenceId'] = $request->sequenceId;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->timeZone)) {
            $body['timeZone'] = $request->timeZone;
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
            'action' => 'RenderBatchCallback',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/printings/callbacks/batch',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return RenderBatchCallbackResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 宜搭vpc批量打印回调
     *  *
     * @param RenderBatchCallbackRequest $request RenderBatchCallbackRequest
     *
     * @return RenderBatchCallbackResponse RenderBatchCallbackResponse
     */
    public function renderBatchCallback($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RenderBatchCallbackHeaders([]);

        return $this->renderBatchCallbackWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 多渠道续费
     *  *
     * @param RenewApplicationAuthorizationServiceOrderRequest $request RenewApplicationAuthorizationServiceOrderRequest
     * @param RenewApplicationAuthorizationServiceOrderHeaders $headers RenewApplicationAuthorizationServiceOrderHeaders
     * @param RuntimeOptions                                   $runtime runtime options for this request RuntimeOptions
     *
     * @return RenewApplicationAuthorizationServiceOrderResponse RenewApplicationAuthorizationServiceOrderResponse
     */
    public function renewApplicationAuthorizationServiceOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accessKey)) {
            $body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            $body['callerUnionId'] = $request->callerUnionId;
        }
        if (!Utils::isUnset($request->endTimeGMT)) {
            $body['endTimeGMT'] = $request->endTimeGMT;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $body['instanceId'] = $request->instanceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'RenewApplicationAuthorizationServiceOrder',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/applicationAuthorizations/orders/renew',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return RenewApplicationAuthorizationServiceOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道续费
     *  *
     * @param RenewApplicationAuthorizationServiceOrderRequest $request RenewApplicationAuthorizationServiceOrderRequest
     *
     * @return RenewApplicationAuthorizationServiceOrderResponse RenewApplicationAuthorizationServiceOrderResponse
     */
    public function renewApplicationAuthorizationServiceOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RenewApplicationAuthorizationServiceOrderHeaders([]);

        return $this->renewApplicationAuthorizationServiceOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 续费租户
     *  *
     * @param RenewTenantOrderRequest $request RenewTenantOrderRequest
     * @param RenewTenantOrderHeaders $headers RenewTenantOrderHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return RenewTenantOrderResponse RenewTenantOrderResponse
     */
    public function renewTenantOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accessKey)) {
            $body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            $body['callerUnionId'] = $request->callerUnionId;
        }
        if (!Utils::isUnset($request->endTimeGMT)) {
            $body['endTimeGMT'] = $request->endTimeGMT;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'RenewTenantOrder',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/tenants/reorder',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return RenewTenantOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 续费租户
     *  *
     * @param RenewTenantOrderRequest $request RenewTenantOrderRequest
     *
     * @return RenewTenantOrderResponse RenewTenantOrderResponse
     */
    public function renewTenantOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RenewTenantOrderHeaders([]);

        return $this->renewTenantOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新增表单实例
     *  *
     * @param SaveFormDataRequest $request SaveFormDataRequest
     * @param SaveFormDataHeaders $headers SaveFormDataHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveFormDataResponse SaveFormDataResponse
     */
    public function saveFormDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            $body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'SaveFormData',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/instances',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SaveFormDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增表单实例
     *  *
     * @param SaveFormDataRequest $request SaveFormDataRequest
     *
     * @return SaveFormDataResponse SaveFormDataResponse
     */
    public function saveFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveFormDataHeaders([]);

        return $this->saveFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 提交表单/流程实例下的评论
     *  *
     * @param SaveFormRemarkRequest $request SaveFormRemarkRequest
     * @param SaveFormRemarkHeaders $headers SaveFormRemarkHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveFormRemarkResponse SaveFormRemarkResponse
     */
    public function saveFormRemarkWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->atUserId)) {
            $body['atUserId'] = $request->atUserId;
        }
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->formInstanceId)) {
            $body['formInstanceId'] = $request->formInstanceId;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->replyId)) {
            $body['replyId'] = $request->replyId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'SaveFormRemark',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/remarks',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SaveFormRemarkResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 提交表单/流程实例下的评论
     *  *
     * @param SaveFormRemarkRequest $request SaveFormRemarkRequest
     *
     * @return SaveFormRemarkResponse SaveFormRemarkResponse
     */
    public function saveFormRemark($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveFormRemarkHeaders([]);

        return $this->saveFormRemarkWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 保存用户设计的模板结构
     *  *
     * @param SavePrintTplDetailInfoRequest $request SavePrintTplDetailInfoRequest
     * @param SavePrintTplDetailInfoHeaders $headers SavePrintTplDetailInfoHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return SavePrintTplDetailInfoResponse SavePrintTplDetailInfoResponse
     */
    public function savePrintTplDetailInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->fileNameConfig)) {
            $body['fileNameConfig'] = $request->fileNameConfig;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->formVersion)) {
            $body['formVersion'] = $request->formVersion;
        }
        if (!Utils::isUnset($request->setting)) {
            $body['setting'] = $request->setting;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->vm)) {
            $body['vm'] = $request->vm;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SavePrintTplDetailInfo',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/printTemplates/printTplDetailInfos',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return SavePrintTplDetailInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 保存用户设计的模板结构
     *  *
     * @param SavePrintTplDetailInfoRequest $request SavePrintTplDetailInfoRequest
     *
     * @return SavePrintTplDetailInfoResponse SavePrintTplDetailInfoResponse
     */
    public function savePrintTplDetailInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SavePrintTplDetailInfoHeaders([]);

        return $this->savePrintTplDetailInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取阿里云账号购买宜搭的账号信息
     *  *
     * @param SearchActivationCodeRequest $request SearchActivationCodeRequest
     * @param SearchActivationCodeHeaders $headers SearchActivationCodeHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchActivationCodeResponse SearchActivationCodeResponse
     */
    public function searchActivationCodeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            $query['callerUid'] = $request->callerUid;
        }
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
            'action' => 'SearchActivationCode',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/activationCode/information',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return SearchActivationCodeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取阿里云账号购买宜搭的账号信息
     *  *
     * @param SearchActivationCodeRequest $request SearchActivationCodeRequest
     *
     * @return SearchActivationCodeResponse SearchActivationCodeResponse
     */
    public function searchActivationCode($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchActivationCodeHeaders([]);

        return $this->searchActivationCodeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 搜索表单中指定人员组件的值
     *  *
     * @param SearchEmployeeFieldValuesRequest $request SearchEmployeeFieldValuesRequest
     * @param SearchEmployeeFieldValuesHeaders $headers SearchEmployeeFieldValuesHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchEmployeeFieldValuesResponse SearchEmployeeFieldValuesResponse
     */
    public function searchEmployeeFieldValuesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            $body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            $body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->originatorId)) {
            $body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            $body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->targetFieldJson)) {
            $body['targetFieldJson'] = $request->targetFieldJson;
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
            'action' => 'SearchEmployeeFieldValues',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/employeeFields',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SearchEmployeeFieldValuesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 搜索表单中指定人员组件的值
     *  *
     * @param SearchEmployeeFieldValuesRequest $request SearchEmployeeFieldValuesRequest
     *
     * @return SearchEmployeeFieldValuesResponse SearchEmployeeFieldValuesResponse
     */
    public function searchEmployeeFieldValues($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchEmployeeFieldValuesHeaders([]);

        return $this->searchEmployeeFieldValuesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据条件搜索表单实例 ID 列表
     *  *
     * @param string                      $appType
     * @param string                      $formUuid
     * @param SearchFormDataIdListRequest $request  SearchFormDataIdListRequest
     * @param SearchFormDataIdListHeaders $headers  SearchFormDataIdListHeaders
     * @param RuntimeOptions              $runtime  runtime options for this request RuntimeOptions
     *
     * @return SearchFormDataIdListResponse SearchFormDataIdListResponse
     */
    public function searchFormDataIdListWithOptions($appType, $formUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        $body = [];
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            $body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            $body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->originatorId)) {
            $body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            $body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SearchFormDataIdList',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/instances/ids/' . $appType . '/' . $formUuid . '',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SearchFormDataIdListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据条件搜索表单实例 ID 列表
     *  *
     * @param string                      $appType
     * @param string                      $formUuid
     * @param SearchFormDataIdListRequest $request  SearchFormDataIdListRequest
     *
     * @return SearchFormDataIdListResponse SearchFormDataIdListResponse
     */
    public function searchFormDataIdList($appType, $formUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchFormDataIdListHeaders([]);

        return $this->searchFormDataIdListWithOptions($appType, $formUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 查询表单实例数据(不返回表单的子表单组件数据)
     *  *
     * @param SearchFormDataRemovalTableDataRequest $request SearchFormDataRemovalTableDataRequest
     * @param SearchFormDataRemovalTableDataHeaders $headers SearchFormDataRemovalTableDataHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchFormDataRemovalTableDataResponse SearchFormDataRemovalTableDataResponse
     */
    public function searchFormDataRemovalTableDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            $body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            $body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->orderConfigJson)) {
            $body['orderConfigJson'] = $request->orderConfigJson;
        }
        if (!Utils::isUnset($request->originatorId)) {
            $body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            $body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'SearchFormDataRemovalTableData',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/instances/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SearchFormDataRemovalTableDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询表单实例数据(不返回表单的子表单组件数据)
     *  *
     * @param SearchFormDataRemovalTableDataRequest $request SearchFormDataRemovalTableDataRequest
     *
     * @return SearchFormDataRemovalTableDataResponse SearchFormDataRemovalTableDataResponse
     */
    public function searchFormDataRemovalTableData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchFormDataRemovalTableDataHeaders([]);

        return $this->searchFormDataRemovalTableDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过高级检索条件查询表单实例
     *  *
     * @param SearchFormDataSecondGenerationRequest $request SearchFormDataSecondGenerationRequest
     * @param SearchFormDataSecondGenerationHeaders $headers SearchFormDataSecondGenerationHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchFormDataSecondGenerationResponse SearchFormDataSecondGenerationResponse
     */
    public function searchFormDataSecondGenerationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            $body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            $body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->orderConfigJson)) {
            $body['orderConfigJson'] = $request->orderConfigJson;
        }
        if (!Utils::isUnset($request->originatorId)) {
            $body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchCondition)) {
            $body['searchCondition'] = $request->searchCondition;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'SearchFormDataSecondGeneration',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/instances/advances/queryAll',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SearchFormDataSecondGenerationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过高级检索条件查询表单实例
     *  *
     * @param SearchFormDataSecondGenerationRequest $request SearchFormDataSecondGenerationRequest
     *
     * @return SearchFormDataSecondGenerationResponse SearchFormDataSecondGenerationResponse
     */
    public function searchFormDataSecondGeneration($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchFormDataSecondGenerationHeaders([]);

        return $this->searchFormDataSecondGenerationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过高级查询条件查询表单实例数据(不返回子表单组件数据)
     *  *
     * @param SearchFormDataSecondGenerationNoTableFieldRequest $request SearchFormDataSecondGenerationNoTableFieldRequest
     * @param SearchFormDataSecondGenerationNoTableFieldHeaders $headers SearchFormDataSecondGenerationNoTableFieldHeaders
     * @param RuntimeOptions                                    $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchFormDataSecondGenerationNoTableFieldResponse SearchFormDataSecondGenerationNoTableFieldResponse
     */
    public function searchFormDataSecondGenerationNoTableFieldWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            $body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            $body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->orderConfigJson)) {
            $body['orderConfigJson'] = $request->orderConfigJson;
        }
        if (!Utils::isUnset($request->originatorId)) {
            $body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchCondition)) {
            $body['searchCondition'] = $request->searchCondition;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'SearchFormDataSecondGenerationNoTableField',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/instances/advances/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SearchFormDataSecondGenerationNoTableFieldResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过高级查询条件查询表单实例数据(不返回子表单组件数据)
     *  *
     * @param SearchFormDataSecondGenerationNoTableFieldRequest $request SearchFormDataSecondGenerationNoTableFieldRequest
     *
     * @return SearchFormDataSecondGenerationNoTableFieldResponse SearchFormDataSecondGenerationNoTableFieldResponse
     */
    public function searchFormDataSecondGenerationNoTableField($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchFormDataSecondGenerationNoTableFieldHeaders([]);

        return $this->searchFormDataSecondGenerationNoTableFieldWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据条件搜索表单实例详情列表,对应原searchFormDatas
     *  *
     * @param SearchFormDatasRequest $request SearchFormDatasRequest
     * @param SearchFormDatasHeaders $headers SearchFormDatasHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchFormDatasResponse SearchFormDatasResponse
     */
    public function searchFormDatasWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->currentPage)) {
            $body['currentPage'] = $request->currentPage;
        }
        if (!Utils::isUnset($request->dynamicOrder)) {
            $body['dynamicOrder'] = $request->dynamicOrder;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->logicOperator)) {
            $body['logicOperator'] = $request->logicOperator;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            $body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            $body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->originatorId)) {
            $body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            $body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'SearchFormDatas',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/instances/search',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SearchFormDatasResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据条件搜索表单实例详情列表,对应原searchFormDatas
     *  *
     * @param SearchFormDatasRequest $request SearchFormDatasRequest
     *
     * @return SearchFormDatasResponse SearchFormDatasResponse
     */
    public function searchFormDatas($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchFormDatasHeaders([]);

        return $this->searchFormDatasWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发起新的流程实例
     *  *
     * @param StartInstanceRequest $request StartInstanceRequest
     * @param StartInstanceHeaders $headers StartInstanceHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return StartInstanceResponse StartInstanceResponse
     */
    public function startInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->departmentId)) {
            $body['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            $body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processCode)) {
            $body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->processData)) {
            $body['processData'] = $request->processData;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'StartInstance',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/processes/instances/start',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return StartInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发起新的流程实例
     *  *
     * @param StartInstanceRequest $request StartInstanceRequest
     *
     * @return StartInstanceResponse StartInstanceResponse
     */
    public function startInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartInstanceHeaders([]);

        return $this->startInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 阿里云合同到期终止
     *  *
     * @param TerminateCloudAuthorizationRequest $request TerminateCloudAuthorizationRequest
     * @param TerminateCloudAuthorizationHeaders $headers TerminateCloudAuthorizationHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return TerminateCloudAuthorizationResponse TerminateCloudAuthorizationResponse
     */
    public function terminateCloudAuthorizationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accessKey)) {
            $body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            $body['callerUnionId'] = $request->callerUnionId;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $body['instanceId'] = $request->instanceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'TerminateCloudAuthorization',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/cloudAuthorizations/terminate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return TerminateCloudAuthorizationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 阿里云合同到期终止
     *  *
     * @param TerminateCloudAuthorizationRequest $request TerminateCloudAuthorizationRequest
     *
     * @return TerminateCloudAuthorizationResponse TerminateCloudAuthorizationResponse
     */
    public function terminateCloudAuthorization($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TerminateCloudAuthorizationHeaders([]);

        return $this->terminateCloudAuthorizationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 终止流程实例
     *  *
     * @param TerminateInstanceRequest $request TerminateInstanceRequest
     * @param TerminateInstanceHeaders $headers TerminateInstanceHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return TerminateInstanceResponse TerminateInstanceResponse
     */
    public function terminateInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $query['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
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
            'action' => 'TerminateInstance',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/processes/instances/terminate',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'none',
        ]);

        return TerminateInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 终止流程实例
     *  *
     * @param TerminateInstanceRequest $request TerminateInstanceRequest
     *
     * @return TerminateInstanceResponse TerminateInstanceResponse
     */
    public function terminateInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TerminateInstanceHeaders([]);

        return $this->terminateInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 变配阿里云账号对应的租户信息
     *  *
     * @param UpdateCloudAccountInformationRequest $request UpdateCloudAccountInformationRequest
     * @param UpdateCloudAccountInformationHeaders $headers UpdateCloudAccountInformationHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateCloudAccountInformationResponse UpdateCloudAccountInformationResponse
     */
    public function updateCloudAccountInformationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accessKey)) {
            $body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->accountNumber)) {
            $body['accountNumber'] = $request->accountNumber;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            $body['callerUnionId'] = $request->callerUnionId;
        }
        if (!Utils::isUnset($request->commodityType)) {
            $body['commodityType'] = $request->commodityType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateCloudAccountInformation',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/cloudAccountInfos',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateCloudAccountInformationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 变配阿里云账号对应的租户信息
     *  *
     * @param UpdateCloudAccountInformationRequest $request UpdateCloudAccountInformationRequest
     *
     * @return UpdateCloudAccountInformationResponse UpdateCloudAccountInformationResponse
     */
    public function updateCloudAccountInformation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCloudAccountInformationHeaders([]);

        return $this->updateCloudAccountInformationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新表单实例
     *  *
     * @param UpdateFormDataRequest $request UpdateFormDataRequest
     * @param UpdateFormDataHeaders $headers UpdateFormDataHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateFormDataResponse UpdateFormDataResponse
     */
    public function updateFormDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formInstanceId)) {
            $body['formInstanceId'] = $request->formInstanceId;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->updateFormDataJson)) {
            $body['updateFormDataJson'] = $request->updateFormDataJson;
        }
        if (!Utils::isUnset($request->useLatestVersion)) {
            $body['useLatestVersion'] = $request->useLatestVersion;
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
            'action' => 'UpdateFormData',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/instances',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'none',
        ]);

        return UpdateFormDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新表单实例
     *  *
     * @param UpdateFormDataRequest $request UpdateFormDataRequest
     *
     * @return UpdateFormDataResponse UpdateFormDataResponse
     */
    public function updateFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateFormDataHeaders([]);

        return $this->updateFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新流程实例
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
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->updateFormDataJson)) {
            $body['updateFormDataJson'] = $request->updateFormDataJson;
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
            'action' => 'UpdateInstance',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/processes/instances',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新流程实例
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
     * @summary 未知
     *  *
     * @param UpdateStatusRequest $request UpdateStatusRequest
     * @param UpdateStatusHeaders $headers UpdateStatusHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateStatusResponse UpdateStatusResponse
     */
    public function updateStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->errorLines)) {
            $body['errorLines'] = $request->errorLines;
        }
        if (!Utils::isUnset($request->importSequence)) {
            $body['importSequence'] = $request->importSequence;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
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
            'action' => 'UpdateStatus',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/forms/status',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 未知
     *  *
     * @param UpdateStatusRequest $request UpdateStatusRequest
     *
     * @return UpdateStatusResponse UpdateStatusResponse
     */
    public function updateStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateStatusHeaders([]);

        return $this->updateStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 变配阿里云账号对应的租户信息
     *  *
     * @param UpgradeTenantInformationRequest $request UpgradeTenantInformationRequest
     * @param UpgradeTenantInformationHeaders $headers UpgradeTenantInformationHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return UpgradeTenantInformationResponse UpgradeTenantInformationResponse
     */
    public function upgradeTenantInformationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accessKey)) {
            $body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->accountNumber)) {
            $body['accountNumber'] = $request->accountNumber;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            $body['callerUnionId'] = $request->callerUnionId;
        }
        if (!Utils::isUnset($request->commodityType)) {
            $body['commodityType'] = $request->commodityType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpgradeTenantInformation',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/tenantInfos',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpgradeTenantInformationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 变配阿里云账号对应的租户信息
     *  *
     * @param UpgradeTenantInformationRequest $request UpgradeTenantInformationRequest
     *
     * @return UpgradeTenantInformationResponse UpgradeTenantInformationResponse
     */
    public function upgradeTenantInformation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpgradeTenantInformationHeaders([]);

        return $this->upgradeTenantInformationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 多渠道续费前校验
     *  *
     * @param string                                       $instanceId
     * @param ValidateApplicationAuthorizationOrderRequest $request    ValidateApplicationAuthorizationOrderRequest
     * @param ValidateApplicationAuthorizationOrderHeaders $headers    ValidateApplicationAuthorizationOrderHeaders
     * @param RuntimeOptions                               $runtime    runtime options for this request RuntimeOptions
     *
     * @return ValidateApplicationAuthorizationOrderResponse ValidateApplicationAuthorizationOrderResponse
     */
    public function validateApplicationAuthorizationOrderWithOptions($instanceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            $query['callerUnionId'] = $request->callerUnionId;
        }
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
            'action' => 'ValidateApplicationAuthorizationOrder',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/applicationOrderUpdateAuthorizations/' . $instanceId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return ValidateApplicationAuthorizationOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道续费前校验
     *  *
     * @param string                                       $instanceId
     * @param ValidateApplicationAuthorizationOrderRequest $request    ValidateApplicationAuthorizationOrderRequest
     *
     * @return ValidateApplicationAuthorizationOrderResponse ValidateApplicationAuthorizationOrderResponse
     */
    public function validateApplicationAuthorizationOrder($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateApplicationAuthorizationOrderHeaders([]);

        return $this->validateApplicationAuthorizationOrderWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @summary 多渠道新购校验
     *  *
     * @param string                                              $callerUid
     * @param ValidateApplicationAuthorizationServiceOrderRequest $request   ValidateApplicationAuthorizationServiceOrderRequest
     * @param ValidateApplicationAuthorizationServiceOrderHeaders $headers   ValidateApplicationAuthorizationServiceOrderHeaders
     * @param RuntimeOptions                                      $runtime   runtime options for this request RuntimeOptions
     *
     * @return ValidateApplicationAuthorizationServiceOrderResponse ValidateApplicationAuthorizationServiceOrderResponse
     */
    public function validateApplicationAuthorizationServiceOrderWithOptions($callerUid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
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
            'action' => 'ValidateApplicationAuthorizationServiceOrder',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/appsAuthorizations/freshOrderInfoReviews/' . $callerUid . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return ValidateApplicationAuthorizationServiceOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道新购校验
     *  *
     * @param string                                              $callerUid
     * @param ValidateApplicationAuthorizationServiceOrderRequest $request   ValidateApplicationAuthorizationServiceOrderRequest
     *
     * @return ValidateApplicationAuthorizationServiceOrderResponse ValidateApplicationAuthorizationServiceOrderResponse
     */
    public function validateApplicationAuthorizationServiceOrder($callerUid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateApplicationAuthorizationServiceOrderHeaders([]);

        return $this->validateApplicationAuthorizationServiceOrderWithOptions($callerUid, $request, $headers, $runtime);
    }

    /**
     * @summary 校验变配
     *  *
     * @param string                                        $callerUnionid
     * @param ValidateApplicationServiceOrderUpgradeRequest $request       ValidateApplicationServiceOrderUpgradeRequest
     * @param ValidateApplicationServiceOrderUpgradeHeaders $headers       ValidateApplicationServiceOrderUpgradeHeaders
     * @param RuntimeOptions                                $runtime       runtime options for this request RuntimeOptions
     *
     * @return ValidateApplicationServiceOrderUpgradeResponse ValidateApplicationServiceOrderUpgradeResponse
     */
    public function validateApplicationServiceOrderUpgradeWithOptions($callerUnionid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
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
            'action' => 'ValidateApplicationServiceOrderUpgrade',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/applications/orderValidations/' . $callerUnionid . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return ValidateApplicationServiceOrderUpgradeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 校验变配
     *  *
     * @param string                                        $callerUnionid
     * @param ValidateApplicationServiceOrderUpgradeRequest $request       ValidateApplicationServiceOrderUpgradeRequest
     *
     * @return ValidateApplicationServiceOrderUpgradeResponse ValidateApplicationServiceOrderUpgradeResponse
     */
    public function validateApplicationServiceOrderUpgrade($callerUnionid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateApplicationServiceOrderUpgradeHeaders([]);

        return $this->validateApplicationServiceOrderUpgradeWithOptions($callerUnionid, $request, $headers, $runtime);
    }

    /**
     * @summary 多渠道新购校验
     *  *
     * @param ValidateOrderBuyRequest $request ValidateOrderBuyRequest
     * @param ValidateOrderBuyHeaders $headers ValidateOrderBuyHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return ValidateOrderBuyResponse ValidateOrderBuyResponse
     */
    public function validateOrderBuyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            $query['callerUid'] = $request->callerUid;
        }
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
            'action' => 'ValidateOrderBuy',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/orderBuy/validate',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return ValidateOrderBuyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道新购校验
     *  *
     * @param ValidateOrderBuyRequest $request ValidateOrderBuyRequest
     *
     * @return ValidateOrderBuyResponse ValidateOrderBuyResponse
     */
    public function validateOrderBuy($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateOrderBuyHeaders([]);

        return $this->validateOrderBuyWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 多渠道续费前校验
     *  *
     * @param string                     $instanceId
     * @param ValidateOrderUpdateRequest $request    ValidateOrderUpdateRequest
     * @param ValidateOrderUpdateHeaders $headers    ValidateOrderUpdateHeaders
     * @param RuntimeOptions             $runtime    runtime options for this request RuntimeOptions
     *
     * @return ValidateOrderUpdateResponse ValidateOrderUpdateResponse
     */
    public function validateOrderUpdateWithOptions($instanceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            $query['callerUid'] = $request->callerUid;
        }
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
            'action' => 'ValidateOrderUpdate',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/orders/renewalReviews/' . $instanceId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return ValidateOrderUpdateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道续费前校验
     *  *
     * @param string                     $instanceId
     * @param ValidateOrderUpdateRequest $request    ValidateOrderUpdateRequest
     *
     * @return ValidateOrderUpdateResponse ValidateOrderUpdateResponse
     */
    public function validateOrderUpdate($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateOrderUpdateHeaders([]);

        return $this->validateOrderUpdateWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @summary 多渠道升配前校验
     *  *
     * @param ValidateOrderUpgradeRequest $request ValidateOrderUpgradeRequest
     * @param ValidateOrderUpgradeHeaders $headers ValidateOrderUpgradeHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return ValidateOrderUpgradeResponse ValidateOrderUpgradeResponse
     */
    public function validateOrderUpgradeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accessKey)) {
            $query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            $query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $query['instanceId'] = $request->instanceId;
        }
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
            'action' => 'ValidateOrderUpgrade',
            'version' => 'yida_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/yida/apps/orderUpgrade/validate',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType' => 'json',
        ]);

        return ValidateOrderUpgradeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 多渠道升配前校验
     *  *
     * @param ValidateOrderUpgradeRequest $request ValidateOrderUpgradeRequest
     *
     * @return ValidateOrderUpgradeResponse ValidateOrderUpgradeResponse
     */
    public function validateOrderUpgrade($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateOrderUpgradeHeaders([]);

        return $this->validateOrderUpgradeWithOptions($request, $headers, $runtime);
    }
}
