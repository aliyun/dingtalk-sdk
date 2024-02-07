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
     * @param AppLoginCodeGenRequest $request
     * @param AppLoginCodeGenHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return AppLoginCodeGenResponse
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
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AppLoginCodeGen',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/authorizations/appLoginCodes',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AppLoginCodeGenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AppLoginCodeGenRequest $request
     *
     * @return AppLoginCodeGenResponse
     */
    public function appLoginCodeGen($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AppLoginCodeGenHeaders([]);

        return $this->appLoginCodeGenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchGetFormDataByIdListRequest $request
     * @param BatchGetFormDataByIdListHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return BatchGetFormDataByIdListResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BatchGetFormDataByIdList',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/instances/ids/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchGetFormDataByIdListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchGetFormDataByIdListRequest $request
     *
     * @return BatchGetFormDataByIdListResponse
     */
    public function batchGetFormDataByIdList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchGetFormDataByIdListHeaders([]);

        return $this->batchGetFormDataByIdListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchRemovalByFormInstanceIdListRequest $request
     * @param BatchRemovalByFormInstanceIdListHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return BatchRemovalByFormInstanceIdListResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BatchRemovalByFormInstanceIdList',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/instances/batchRemove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return BatchRemovalByFormInstanceIdListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchRemovalByFormInstanceIdListRequest $request
     *
     * @return BatchRemovalByFormInstanceIdListResponse
     */
    public function batchRemovalByFormInstanceIdList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchRemovalByFormInstanceIdListHeaders([]);

        return $this->batchRemovalByFormInstanceIdListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchSaveFormDataRequest $request
     * @param BatchSaveFormDataHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return BatchSaveFormDataResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BatchSaveFormData',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/instances/batchSave',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchSaveFormDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchSaveFormDataRequest $request
     *
     * @return BatchSaveFormDataResponse
     */
    public function batchSaveFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchSaveFormDataHeaders([]);

        return $this->batchSaveFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchUpdateFormDataByInstanceIdRequest $request
     * @param BatchUpdateFormDataByInstanceIdHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return BatchUpdateFormDataByInstanceIdResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BatchUpdateFormDataByInstanceId',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/instances/components',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchUpdateFormDataByInstanceIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchUpdateFormDataByInstanceIdRequest $request
     *
     * @return BatchUpdateFormDataByInstanceIdResponse
     */
    public function batchUpdateFormDataByInstanceId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateFormDataByInstanceIdHeaders([]);

        return $this->batchUpdateFormDataByInstanceIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchUpdateFormDataByInstanceMapRequest $request
     * @param BatchUpdateFormDataByInstanceMapHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return BatchUpdateFormDataByInstanceMapResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BatchUpdateFormDataByInstanceMap',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/instances/datas',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchUpdateFormDataByInstanceMapResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchUpdateFormDataByInstanceMapRequest $request
     *
     * @return BatchUpdateFormDataByInstanceMapResponse
     */
    public function batchUpdateFormDataByInstanceMap($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateFormDataByInstanceMapHeaders([]);

        return $this->batchUpdateFormDataByInstanceMapWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BuyAuthorizationOrderRequest $request
     * @param BuyAuthorizationOrderHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return BuyAuthorizationOrderResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BuyAuthorizationOrder',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/appAuthorizations/order',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return BuyAuthorizationOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BuyAuthorizationOrderRequest $request
     *
     * @return BuyAuthorizationOrderResponse
     */
    public function buyAuthorizationOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BuyAuthorizationOrderHeaders([]);

        return $this->buyAuthorizationOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BuyFreshOrderRequest $request
     * @param BuyFreshOrderHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return BuyFreshOrderResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BuyFreshOrder',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/freshOrders',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return BuyFreshOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BuyFreshOrderRequest $request
     *
     * @return BuyFreshOrderResponse
     */
    public function buyFreshOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BuyFreshOrderHeaders([]);

        return $this->buyFreshOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                         $callerUid
     * @param CheckCloudAccountStatusRequest $request
     * @param CheckCloudAccountStatusHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CheckCloudAccountStatusResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'CheckCloudAccountStatus',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/cloudAccountStatus/' . $callerUid . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return CheckCloudAccountStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                         $callerUid
     * @param CheckCloudAccountStatusRequest $request
     *
     * @return CheckCloudAccountStatusResponse
     */
    public function checkCloudAccountStatus($callerUid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckCloudAccountStatusHeaders([]);

        return $this->checkCloudAccountStatusWithOptions($callerUid, $request, $headers, $runtime);
    }

    /**
     * @param CreateOrUpdateFormDataRequest $request
     * @param CreateOrUpdateFormDataHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return CreateOrUpdateFormDataResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateOrUpdateFormData',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/instances/insertOrUpdate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateOrUpdateFormDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateOrUpdateFormDataRequest $request
     *
     * @return CreateOrUpdateFormDataResponse
     */
    public function createOrUpdateFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateOrUpdateFormDataHeaders([]);

        return $this->createOrUpdateFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteFormDataRequest $request
     * @param DeleteFormDataHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return DeleteFormDataResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeleteFormData',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/instances',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return DeleteFormDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteFormDataRequest $request
     *
     * @return DeleteFormDataResponse
     */
    public function deleteFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteFormDataHeaders([]);

        return $this->deleteFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteInstanceRequest $request
     * @param DeleteInstanceHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return DeleteInstanceResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeleteInstance',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/processes/instances',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return DeleteInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteInstanceRequest $request
     *
     * @return DeleteInstanceResponse
     */
    public function deleteInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteInstanceHeaders([]);

        return $this->deleteInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteSequenceRequest $request
     * @param DeleteSequenceHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return DeleteSequenceResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeleteSequence',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/deleteSequence',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return DeleteSequenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteSequenceRequest $request
     *
     * @return DeleteSequenceResponse
     */
    public function deleteSequence($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSequenceHeaders([]);

        return $this->deleteSequenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeployFunctionCallbackRequest $request
     * @param DeployFunctionCallbackHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return DeployFunctionCallbackResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DeployFunctionCallback',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/functionComputeConnectors/completeDeployments/notify',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeployFunctionCallbackResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeployFunctionCallbackRequest $request
     *
     * @return DeployFunctionCallbackResponse
     */
    public function deployFunctionCallback($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeployFunctionCallbackHeaders([]);

        return $this->deployFunctionCallbackWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ExecuteBatchTaskRequest $request
     * @param ExecuteBatchTaskHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ExecuteBatchTaskResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ExecuteBatchTask',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/tasks/batches/execute',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ExecuteBatchTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ExecuteBatchTaskRequest $request
     *
     * @return ExecuteBatchTaskResponse
     */
    public function executeBatchTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecuteBatchTaskHeaders([]);

        return $this->executeBatchTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ExecuteCustomApiRequest $request
     * @param ExecuteCustomApiHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ExecuteCustomApiResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ExecuteCustomApi',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/customApi/execute',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ExecuteCustomApiResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ExecuteCustomApiRequest $request
     *
     * @return ExecuteCustomApiResponse
     */
    public function executeCustomApi($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecuteCustomApiHeaders([]);

        return $this->executeCustomApiWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ExecutePlatformTaskRequest $request
     * @param ExecutePlatformTaskHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return ExecutePlatformTaskResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ExecutePlatformTask',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/tasks/platformTasks/execute',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return ExecutePlatformTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ExecutePlatformTaskRequest $request
     *
     * @return ExecutePlatformTaskResponse
     */
    public function executePlatformTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecutePlatformTaskHeaders([]);

        return $this->executePlatformTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ExecuteTaskRequest $request
     * @param ExecuteTaskHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return ExecuteTaskResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ExecuteTask',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/tasks/execute',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return ExecuteTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ExecuteTaskRequest $request
     *
     * @return ExecuteTaskResponse
     */
    public function executeTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecuteTaskHeaders([]);

        return $this->executeTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ExpireCommodityRequest $request
     * @param ExpireCommodityHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ExpireCommodityResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ExpireCommodity',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/appAuth/commodities/expire',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ExpireCommodityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ExpireCommodityRequest $request
     *
     * @return ExpireCommodityResponse
     */
    public function expireCommodity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExpireCommodityHeaders([]);

        return $this->expireCommodityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                                  $callerUid
     * @param GetActivationCodeByCallerUnionIdRequest $request
     * @param GetActivationCodeByCallerUnionIdHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return GetActivationCodeByCallerUnionIdResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetActivationCodeByCallerUnionId',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/applications/activationCodes/' . $callerUid . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return GetActivationCodeByCallerUnionIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                                  $callerUid
     * @param GetActivationCodeByCallerUnionIdRequest $request
     *
     * @return GetActivationCodeByCallerUnionIdResponse
     */
    public function getActivationCodeByCallerUnionId($callerUid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetActivationCodeByCallerUnionIdHeaders([]);

        return $this->getActivationCodeByCallerUnionIdWithOptions($callerUid, $request, $headers, $runtime);
    }

    /**
     * @param string                       $appType
     * @param string                       $processCode
     * @param string                       $activityId
     * @param GetActivityButtonListRequest $request
     * @param GetActivityButtonListHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GetActivityButtonListResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetActivityButtonList',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/processDefinitions/buttons/' . $appType . '/' . $processCode . '/' . $activityId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return GetActivityButtonListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                       $appType
     * @param string                       $processCode
     * @param string                       $activityId
     * @param GetActivityButtonListRequest $request
     *
     * @return GetActivityButtonListResponse
     */
    public function getActivityButtonList($appType, $processCode, $activityId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetActivityButtonListHeaders([]);

        return $this->getActivityButtonListWithOptions($appType, $processCode, $activityId, $request, $headers, $runtime);
    }

    /**
     * @param GetActivityListRequest $request
     * @param GetActivityListHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetActivityListResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetActivityList',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/processes/activities',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return GetActivityListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetActivityListRequest $request
     *
     * @return GetActivityListResponse
     */
    public function getActivityList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetActivityListHeaders([]);

        return $this->getActivityListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetAllAuthCubesRequest $request
     * @param GetAllAuthCubesHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetAllAuthCubesResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetAllAuthCubes',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/metadata/allAuthCubes/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAllAuthCubesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetAllAuthCubesRequest $request
     *
     * @return GetAllAuthCubesResponse
     */
    public function getAllAuthCubes($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllAuthCubesHeaders([]);

        return $this->getAllAuthCubesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetApplicationAuthorizationServicePlatformResourceRequest $request
     * @param GetApplicationAuthorizationServicePlatformResourceHeaders $headers
     * @param RuntimeOptions                                            $runtime
     *
     * @return GetApplicationAuthorizationServicePlatformResourceResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetApplicationAuthorizationServicePlatformResource',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/authorization/platformResources',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return GetApplicationAuthorizationServicePlatformResourceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetApplicationAuthorizationServicePlatformResourceRequest $request
     *
     * @return GetApplicationAuthorizationServicePlatformResourceResponse
     */
    public function getApplicationAuthorizationServicePlatformResource($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetApplicationAuthorizationServicePlatformResourceHeaders([]);

        return $this->getApplicationAuthorizationServicePlatformResourceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetAutoFlowLogDetailRequest $request
     * @param GetAutoFlowLogDetailHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetAutoFlowLogDetailResponse
     */
    public function getAutoFlowLogDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetAutoFlowLogDetail',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/logs/automations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAutoFlowLogDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetAutoFlowLogDetailRequest $request
     *
     * @return GetAutoFlowLogDetailResponse
     */
    public function getAutoFlowLogDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAutoFlowLogDetailHeaders([]);

        return $this->getAutoFlowLogDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                            $corpId
     * @param string                            $userId
     * @param GetCorpAccomplishmentTasksRequest $request
     * @param GetCorpAccomplishmentTasksHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return GetCorpAccomplishmentTasksResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetCorpAccomplishmentTasks',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/tasks/completedTasks/' . $corpId . '/' . $userId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCorpAccomplishmentTasksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                            $corpId
     * @param string                            $userId
     * @param GetCorpAccomplishmentTasksRequest $request
     *
     * @return GetCorpAccomplishmentTasksResponse
     */
    public function getCorpAccomplishmentTasks($corpId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCorpAccomplishmentTasksHeaders([]);

        return $this->getCorpAccomplishmentTasksWithOptions($corpId, $userId, $request, $headers, $runtime);
    }

    /**
     * @param GetCorpLevelByAccountIdRequest $request
     * @param GetCorpLevelByAccountIdHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return GetCorpLevelByAccountIdResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetCorpLevelByAccountId',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/corpLevel',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return GetCorpLevelByAccountIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetCorpLevelByAccountIdRequest $request
     *
     * @return GetCorpLevelByAccountIdResponse
     */
    public function getCorpLevelByAccountId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCorpLevelByAccountIdHeaders([]);

        return $this->getCorpLevelByAccountIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCorpTasksRequest $request
     * @param GetCorpTasksHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetCorpTasksResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetCorpTasks',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/corpTasks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCorpTasksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetCorpTasksRequest $request
     *
     * @return GetCorpTasksResponse
     */
    public function getCorpTasks($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCorpTasksHeaders([]);

        return $this->getCorpTasksWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetDbConfigRequest $request
     * @param GetDbConfigHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetDbConfigResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetDbConfig',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/metadata/dbConfigs',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDbConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetDbConfigRequest $request
     *
     * @return GetDbConfigResponse
     */
    public function getDbConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDbConfigHeaders([]);

        return $this->getDbConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetFieldDefByUuidRequest $request
     * @param GetFieldDefByUuidHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetFieldDefByUuidResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetFieldDefByUuid',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/formFields',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFieldDefByUuidResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetFieldDefByUuidRequest $request
     *
     * @return GetFieldDefByUuidResponse
     */
    public function getFieldDefByUuid($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFieldDefByUuidHeaders([]);

        return $this->getFieldDefByUuidWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                                $appType
     * @param string                                $formUuid
     * @param GetFormComponentDefinitionListRequest $request
     * @param GetFormComponentDefinitionListHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return GetFormComponentDefinitionListResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetFormComponentDefinitionList',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/definitions/' . $appType . '/' . $formUuid . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFormComponentDefinitionListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                                $appType
     * @param string                                $formUuid
     * @param GetFormComponentDefinitionListRequest $request
     *
     * @return GetFormComponentDefinitionListResponse
     */
    public function getFormComponentDefinitionList($appType, $formUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFormComponentDefinitionListHeaders([]);

        return $this->getFormComponentDefinitionListWithOptions($appType, $formUuid, $request, $headers, $runtime);
    }

    /**
     * @param string                 $id
     * @param GetFormDataByIDRequest $request
     * @param GetFormDataByIDHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetFormDataByIDResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetFormDataByID',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/instances/' . $id . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFormDataByIDResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                 $id
     * @param GetFormDataByIDRequest $request
     *
     * @return GetFormDataByIDResponse
     */
    public function getFormDataByID($id, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFormDataByIDHeaders([]);

        return $this->getFormDataByIDWithOptions($id, $request, $headers, $runtime);
    }

    /**
     * @param GetFormListInAppRequest $request
     * @param GetFormListInAppHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetFormListInAppResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetFormListInApp',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFormListInAppResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetFormListInAppRequest $request
     *
     * @return GetFormListInAppResponse
     */
    public function getFormListInApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFormListInAppHeaders([]);

        return $this->getFormListInAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                 $id
     * @param GetInstanceByIdRequest $request
     * @param GetInstanceByIdHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetInstanceByIdResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetInstanceById',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/processes/instancesInfos/' . $id . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetInstanceByIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                 $id
     * @param GetInstanceByIdRequest $request
     *
     * @return GetInstanceByIdResponse
     */
    public function getInstanceById($id, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInstanceByIdHeaders([]);

        return $this->getInstanceByIdWithOptions($id, $request, $headers, $runtime);
    }

    /**
     * @param GetInstanceIdListRequest $request
     * @param GetInstanceIdListHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetInstanceIdListResponse
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
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetInstanceIdList',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/processes/instanceIds',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetInstanceIdListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetInstanceIdListRequest $request
     *
     * @return GetInstanceIdListResponse
     */
    public function getInstanceIdList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInstanceIdListHeaders([]);

        return $this->getInstanceIdListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetInstancesRequest $request
     * @param GetInstancesHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetInstancesResponse
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
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetInstances',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/processes/instances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetInstancesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetInstancesRequest $request
     *
     * @return GetInstancesResponse
     */
    public function getInstances($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInstancesHeaders([]);

        return $this->getInstancesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetInstancesByIdListRequest $request
     * @param GetInstancesByIdListHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetInstancesByIdListResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetInstancesByIdList',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/processes/instances/searchWithIds',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetInstancesByIdListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetInstancesByIdListRequest $request
     *
     * @return GetInstancesByIdListResponse
     */
    public function getInstancesByIdList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInstancesByIdListHeaders([]);

        return $this->getInstancesByIdListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                     $userId
     * @param GetMeCorpSubmissionRequest $request
     * @param GetMeCorpSubmissionHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetMeCorpSubmissionResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetMeCorpSubmission',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/tasks/myCorpSubmission/' . $userId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return GetMeCorpSubmissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                     $userId
     * @param GetMeCorpSubmissionRequest $request
     *
     * @return GetMeCorpSubmissionResponse
     */
    public function getMeCorpSubmission($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMeCorpSubmissionHeaders([]);

        return $this->getMeCorpSubmissionWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string             $userId
     * @param GetNotifyMeRequest $request
     * @param GetNotifyMeHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetNotifyMeResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetNotifyMe',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/corpNotifications/' . $userId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetNotifyMeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string             $userId
     * @param GetNotifyMeRequest $request
     *
     * @return GetNotifyMeResponse
     */
    public function getNotifyMe($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetNotifyMeHeaders([]);

        return $this->getNotifyMeWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string            $appType
     * @param GetOpenUrlRequest $request
     * @param GetOpenUrlHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return GetOpenUrlResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetOpenUrl',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/temporaryUrls/' . $appType . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOpenUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string            $appType
     * @param GetOpenUrlRequest $request
     *
     * @return GetOpenUrlResponse
     */
    public function getOpenUrl($appType, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOpenUrlHeaders([]);

        return $this->getOpenUrlWithOptions($appType, $request, $headers, $runtime);
    }

    /**
     * @param GetOperationRecordsRequest $request
     * @param GetOperationRecordsHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetOperationRecordsResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetOperationRecords',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/processes/operationRecords',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOperationRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetOperationRecordsRequest $request
     *
     * @return GetOperationRecordsResponse
     */
    public function getOperationRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOperationRecordsHeaders([]);

        return $this->getOperationRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetPlatformResourceRequest $request
     * @param GetPlatformResourceHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetPlatformResourceResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetPlatformResource',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/platformResources',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return GetPlatformResourceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetPlatformResourceRequest $request
     *
     * @return GetPlatformResourceResponse
     */
    public function getPlatformResource($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPlatformResourceHeaders([]);

        return $this->getPlatformResourceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetPrintAppInfoRequest $request
     * @param GetPrintAppInfoHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetPrintAppInfoResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetPrintAppInfo',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/printTemplates/printAppInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return GetPrintAppInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetPrintAppInfoRequest $request
     *
     * @return GetPrintAppInfoResponse
     */
    public function getPrintAppInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPrintAppInfoHeaders([]);

        return $this->getPrintAppInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetPrintDictionaryRequest $request
     * @param GetPrintDictionaryHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetPrintDictionaryResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetPrintDictionary',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/printTemplates/printDictionaries',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return GetPrintDictionaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetPrintDictionaryRequest $request
     *
     * @return GetPrintDictionaryResponse
     */
    public function getPrintDictionary($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPrintDictionaryHeaders([]);

        return $this->getPrintDictionaryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                      $processInstanceId
     * @param GetProcessDefinitionRequest $request
     * @param GetProcessDefinitionHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetProcessDefinitionResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetProcessDefinition',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/processes/definitions/' . $processInstanceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetProcessDefinitionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                      $processInstanceId
     * @param GetProcessDefinitionRequest $request
     *
     * @return GetProcessDefinitionResponse
     */
    public function getProcessDefinition($processInstanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProcessDefinitionHeaders([]);

        return $this->getProcessDefinitionWithOptions($processInstanceId, $request, $headers, $runtime);
    }

    /**
     * @param GetRunningTaskListRequest $request
     * @param GetRunningTaskListHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetRunningTaskListResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetRunningTaskList',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/tasks/runningTasks/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetRunningTaskListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetRunningTaskListRequest $request
     *
     * @return GetRunningTaskListResponse
     */
    public function getRunningTaskList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRunningTaskListHeaders([]);

        return $this->getRunningTaskListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetRunningTasksRequest $request
     * @param GetRunningTasksHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetRunningTasksResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetRunningTasks',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/processes/tasks/getRunningTasks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetRunningTasksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetRunningTasksRequest $request
     *
     * @return GetRunningTasksResponse
     */
    public function getRunningTasks($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRunningTasksHeaders([]);

        return $this->getRunningTasksWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSaleUserInfoByUserIdRequest $request
     * @param GetSaleUserInfoByUserIdHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return GetSaleUserInfoByUserIdResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetSaleUserInfoByUserId',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/saleUserInfo',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return GetSaleUserInfoByUserIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetSaleUserInfoByUserIdRequest $request
     *
     * @return GetSaleUserInfoByUserIdResponse
     */
    public function getSaleUserInfoByUserId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSaleUserInfoByUserIdHeaders([]);

        return $this->getSaleUserInfoByUserIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSimpleCubeModelListRequest $request
     * @param GetSimpleCubeModelListHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetSimpleCubeModelListResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetSimpleCubeModelList',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/metadata/simpleCubeModelLists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSimpleCubeModelListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetSimpleCubeModelListRequest $request
     *
     * @return GetSimpleCubeModelListResponse
     */
    public function getSimpleCubeModelList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSimpleCubeModelListHeaders([]);

        return $this->getSimpleCubeModelListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetTaskCopiesRequest $request
     * @param GetTaskCopiesHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetTaskCopiesResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetTaskCopies',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/tasks/taskCopies',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTaskCopiesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetTaskCopiesRequest $request
     *
     * @return GetTaskCopiesResponse
     */
    public function getTaskCopies($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTaskCopiesHeaders([]);

        return $this->getTaskCopiesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListApplicationRequest $request
     * @param ListApplicationHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ListApplicationResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListApplication',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/organizations/applications',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListApplicationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListApplicationRequest $request
     *
     * @return ListApplicationResponse
     */
    public function listApplication($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListApplicationHeaders([]);

        return $this->listApplicationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                                                           $instanceId
     * @param ListApplicationAuthorizationServiceApplicationInformationRequest $request
     * @param ListApplicationAuthorizationServiceApplicationInformationHeaders $headers
     * @param RuntimeOptions                                                   $runtime
     *
     * @return ListApplicationAuthorizationServiceApplicationInformationResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListApplicationAuthorizationServiceApplicationInformation',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/authorizations/applicationInfos/' . $instanceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return ListApplicationAuthorizationServiceApplicationInformationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                                                           $instanceId
     * @param ListApplicationAuthorizationServiceApplicationInformationRequest $request
     *
     * @return ListApplicationAuthorizationServiceApplicationInformationResponse
     */
    public function listApplicationAuthorizationServiceApplicationInformation($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListApplicationAuthorizationServiceApplicationInformationHeaders([]);

        return $this->listApplicationAuthorizationServiceApplicationInformationWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @param string                                                         $instanceId
     * @param ListApplicationAuthorizationServiceConnectorInformationRequest $request
     * @param ListApplicationAuthorizationServiceConnectorInformationHeaders $headers
     * @param RuntimeOptions                                                 $runtime
     *
     * @return ListApplicationAuthorizationServiceConnectorInformationResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListApplicationAuthorizationServiceConnectorInformation',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/applicationAuthorizations/plugs/' . $instanceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return ListApplicationAuthorizationServiceConnectorInformationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                                                         $instanceId
     * @param ListApplicationAuthorizationServiceConnectorInformationRequest $request
     *
     * @return ListApplicationAuthorizationServiceConnectorInformationResponse
     */
    public function listApplicationAuthorizationServiceConnectorInformation($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListApplicationAuthorizationServiceConnectorInformationHeaders([]);

        return $this->listApplicationAuthorizationServiceConnectorInformationWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @param string                            $instanceId
     * @param ListApplicationInformationRequest $request
     * @param ListApplicationInformationHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return ListApplicationInformationResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListApplicationInformation',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/infos/' . $instanceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return ListApplicationInformationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                            $instanceId
     * @param ListApplicationInformationRequest $request
     *
     * @return ListApplicationInformationResponse
     */
    public function listApplicationInformation($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListApplicationInformationHeaders([]);

        return $this->listApplicationInformationWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @param ListCommodityRequest $request
     * @param ListCommodityHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return ListCommodityResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListCommodity',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/appAuth/commodities',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return ListCommodityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListCommodityRequest $request
     *
     * @return ListCommodityResponse
     */
    public function listCommodity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListCommodityHeaders([]);

        return $this->listCommodityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                          $instanceId
     * @param ListConnectorInformationRequest $request
     * @param ListConnectorInformationHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return ListConnectorInformationResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListConnectorInformation',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/plugins/infos/' . $instanceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return ListConnectorInformationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                          $instanceId
     * @param ListConnectorInformationRequest $request
     *
     * @return ListConnectorInformationResponse
     */
    public function listConnectorInformation($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListConnectorInformationHeaders([]);

        return $this->listConnectorInformationWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @param ListFormRemarksRequest $request
     * @param ListFormRemarksHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ListFormRemarksResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ListFormRemarks',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/remarks/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListFormRemarksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListFormRemarksRequest $request
     *
     * @return ListFormRemarksResponse
     */
    public function listFormRemarks($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListFormRemarksHeaders([]);

        return $this->listFormRemarksWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListNavigationByFormTypeRequest $request
     * @param ListNavigationByFormTypeHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return ListNavigationByFormTypeResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListNavigationByFormType',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/navigations',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return ListNavigationByFormTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListNavigationByFormTypeRequest $request
     *
     * @return ListNavigationByFormTypeResponse
     */
    public function listNavigationByFormType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListNavigationByFormTypeHeaders([]);

        return $this->listNavigationByFormTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListOperationLogsRequest $request
     * @param ListOperationLogsHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return ListOperationLogsResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ListOperationLogs',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/operationsLogs/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListOperationLogsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListOperationLogsRequest $request
     *
     * @return ListOperationLogsResponse
     */
    public function listOperationLogs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListOperationLogsHeaders([]);

        return $this->listOperationLogsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                                      $formInstanceId
     * @param ListTableDataByFormInstanceIdTableIdRequest $request
     * @param ListTableDataByFormInstanceIdTableIdHeaders $headers
     * @param RuntimeOptions                              $runtime
     *
     * @return ListTableDataByFormInstanceIdTableIdResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListTableDataByFormInstanceIdTableId',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/innerTables/' . $formInstanceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListTableDataByFormInstanceIdTableIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                                      $formInstanceId
     * @param ListTableDataByFormInstanceIdTableIdRequest $request
     *
     * @return ListTableDataByFormInstanceIdTableIdResponse
     */
    public function listTableDataByFormInstanceIdTableId($formInstanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListTableDataByFormInstanceIdTableIdHeaders([]);

        return $this->listTableDataByFormInstanceIdTableIdWithOptions($formInstanceId, $request, $headers, $runtime);
    }

    /**
     * @param LoginCodeGenRequest $request
     * @param LoginCodeGenHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return LoginCodeGenResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'LoginCodeGen',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/authorizations/loginCodes',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return LoginCodeGenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param LoginCodeGenRequest $request
     *
     * @return LoginCodeGenResponse
     */
    public function loginCodeGen($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LoginCodeGenHeaders([]);

        return $this->loginCodeGenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param NotifyAuthorizationResultRequest $request
     * @param NotifyAuthorizationResultHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return NotifyAuthorizationResultResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'NotifyAuthorizationResult',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/authorizationResults/notify',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return NotifyAuthorizationResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param NotifyAuthorizationResultRequest $request
     *
     * @return NotifyAuthorizationResultResponse
     */
    public function notifyAuthorizationResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NotifyAuthorizationResultHeaders([]);

        return $this->notifyAuthorizationResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PageAutoFlowLogRequest $request
     * @param PageAutoFlowLogHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return PageAutoFlowLogResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'PageAutoFlowLog',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/logs/automations/paginationQuery',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PageAutoFlowLogResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PageAutoFlowLogRequest $request
     *
     * @return PageAutoFlowLogResponse
     */
    public function pageAutoFlowLog($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageAutoFlowLogHeaders([]);

        return $this->pageAutoFlowLogWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PageFormBaseInfosRequest $request
     * @param PageFormBaseInfosHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return PageFormBaseInfosResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'PageFormBaseInfos',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/forms/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PageFormBaseInfosResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PageFormBaseInfosRequest $request
     *
     * @return PageFormBaseInfosResponse
     */
    public function pageFormBaseInfos($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageFormBaseInfosHeaders([]);

        return $this->pageFormBaseInfosWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryServiceRecordRequest $request
     * @param QueryServiceRecordHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryServiceRecordResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryServiceRecord',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/services/invocationRecords',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryServiceRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryServiceRecordRequest $request
     *
     * @return QueryServiceRecordResponse
     */
    public function queryServiceRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryServiceRecordHeaders([]);

        return $this->queryServiceRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RedirectTaskRequest $request
     * @param RedirectTaskHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return RedirectTaskResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RedirectTask',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/tasks/redirect',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return RedirectTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RedirectTaskRequest $request
     *
     * @return RedirectTaskResponse
     */
    public function redirectTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RedirectTaskHeaders([]);

        return $this->redirectTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RefundCommodityRequest $request
     * @param RefundCommodityHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return RefundCommodityResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'RefundCommodity',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/appAuth/commodities/refund',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return RefundCommodityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RefundCommodityRequest $request
     *
     * @return RefundCommodityResponse
     */
    public function refundCommodity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RefundCommodityHeaders([]);

        return $this->refundCommodityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RegisterAccountsRequest $request
     * @param RegisterAccountsHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return RegisterAccountsResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RegisterAccounts',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/applicationAuthorizations/accounts/register',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return RegisterAccountsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RegisterAccountsRequest $request
     *
     * @return RegisterAccountsResponse
     */
    public function registerAccounts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterAccountsHeaders([]);

        return $this->registerAccountsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReleaseCommodityRequest $request
     * @param ReleaseCommodityHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ReleaseCommodityResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ReleaseCommodity',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/appAuth/commodities/release',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return ReleaseCommodityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ReleaseCommodityRequest $request
     *
     * @return ReleaseCommodityResponse
     */
    public function releaseCommodity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReleaseCommodityHeaders([]);

        return $this->releaseCommodityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                      $callerUid
     * @param RemoveTenantResourceRequest $request
     * @param RemoveTenantResourceHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return RemoveTenantResourceResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'RemoveTenantResource',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/applications/tenantRelatedResources/' . $callerUid . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return RemoveTenantResourceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                      $callerUid
     * @param RemoveTenantResourceRequest $request
     *
     * @return RemoveTenantResourceResponse
     */
    public function removeTenantResource($callerUid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveTenantResourceHeaders([]);

        return $this->removeTenantResourceWithOptions($callerUid, $request, $headers, $runtime);
    }

    /**
     * @param RenderBatchCallbackRequest $request
     * @param RenderBatchCallbackHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return RenderBatchCallbackResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RenderBatchCallback',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/printings/callbacks/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return RenderBatchCallbackResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RenderBatchCallbackRequest $request
     *
     * @return RenderBatchCallbackResponse
     */
    public function renderBatchCallback($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RenderBatchCallbackHeaders([]);

        return $this->renderBatchCallbackWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RenewApplicationAuthorizationServiceOrderRequest $request
     * @param RenewApplicationAuthorizationServiceOrderHeaders $headers
     * @param RuntimeOptions                                   $runtime
     *
     * @return RenewApplicationAuthorizationServiceOrderResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RenewApplicationAuthorizationServiceOrder',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/applicationAuthorizations/orders/renew',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return RenewApplicationAuthorizationServiceOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RenewApplicationAuthorizationServiceOrderRequest $request
     *
     * @return RenewApplicationAuthorizationServiceOrderResponse
     */
    public function renewApplicationAuthorizationServiceOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RenewApplicationAuthorizationServiceOrderHeaders([]);

        return $this->renewApplicationAuthorizationServiceOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RenewTenantOrderRequest $request
     * @param RenewTenantOrderHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return RenewTenantOrderResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RenewTenantOrder',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/tenants/reorder',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return RenewTenantOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RenewTenantOrderRequest $request
     *
     * @return RenewTenantOrderResponse
     */
    public function renewTenantOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RenewTenantOrderHeaders([]);

        return $this->renewTenantOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SaveFormDataRequest $request
     * @param SaveFormDataHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return SaveFormDataResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SaveFormData',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/instances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveFormDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SaveFormDataRequest $request
     *
     * @return SaveFormDataResponse
     */
    public function saveFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveFormDataHeaders([]);

        return $this->saveFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SaveFormRemarkRequest $request
     * @param SaveFormRemarkHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SaveFormRemarkResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SaveFormRemark',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/remarks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveFormRemarkResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SaveFormRemarkRequest $request
     *
     * @return SaveFormRemarkResponse
     */
    public function saveFormRemark($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveFormRemarkHeaders([]);

        return $this->saveFormRemarkWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SavePrintTplDetailInfoRequest $request
     * @param SavePrintTplDetailInfoHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return SavePrintTplDetailInfoResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SavePrintTplDetailInfo',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/printTemplates/printTplDetailInfos',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return SavePrintTplDetailInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SavePrintTplDetailInfoRequest $request
     *
     * @return SavePrintTplDetailInfoResponse
     */
    public function savePrintTplDetailInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SavePrintTplDetailInfoHeaders([]);

        return $this->savePrintTplDetailInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchActivationCodeRequest $request
     * @param SearchActivationCodeHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return SearchActivationCodeResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'SearchActivationCode',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/activationCode/information',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return SearchActivationCodeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SearchActivationCodeRequest $request
     *
     * @return SearchActivationCodeResponse
     */
    public function searchActivationCode($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchActivationCodeHeaders([]);

        return $this->searchActivationCodeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchEmployeeFieldValuesRequest $request
     * @param SearchEmployeeFieldValuesHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return SearchEmployeeFieldValuesResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SearchEmployeeFieldValues',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/employeeFields',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchEmployeeFieldValuesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SearchEmployeeFieldValuesRequest $request
     *
     * @return SearchEmployeeFieldValuesResponse
     */
    public function searchEmployeeFieldValues($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchEmployeeFieldValuesHeaders([]);

        return $this->searchEmployeeFieldValuesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                      $appType
     * @param string                      $formUuid
     * @param SearchFormDataIdListRequest $request
     * @param SearchFormDataIdListHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return SearchFormDataIdListResponse
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
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SearchFormDataIdList',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/instances/ids/' . $appType . '/' . $formUuid . '',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchFormDataIdListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                      $appType
     * @param string                      $formUuid
     * @param SearchFormDataIdListRequest $request
     *
     * @return SearchFormDataIdListResponse
     */
    public function searchFormDataIdList($appType, $formUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchFormDataIdListHeaders([]);

        return $this->searchFormDataIdListWithOptions($appType, $formUuid, $request, $headers, $runtime);
    }

    /**
     * @param SearchFormDataRemovalTableDataRequest $request
     * @param SearchFormDataRemovalTableDataHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return SearchFormDataRemovalTableDataResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SearchFormDataRemovalTableData',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/instances/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchFormDataRemovalTableDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SearchFormDataRemovalTableDataRequest $request
     *
     * @return SearchFormDataRemovalTableDataResponse
     */
    public function searchFormDataRemovalTableData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchFormDataRemovalTableDataHeaders([]);

        return $this->searchFormDataRemovalTableDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchFormDataSecondGenerationRequest $request
     * @param SearchFormDataSecondGenerationHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return SearchFormDataSecondGenerationResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SearchFormDataSecondGeneration',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/instances/advances/queryAll',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchFormDataSecondGenerationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SearchFormDataSecondGenerationRequest $request
     *
     * @return SearchFormDataSecondGenerationResponse
     */
    public function searchFormDataSecondGeneration($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchFormDataSecondGenerationHeaders([]);

        return $this->searchFormDataSecondGenerationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchFormDataSecondGenerationNoTableFieldRequest $request
     * @param SearchFormDataSecondGenerationNoTableFieldHeaders $headers
     * @param RuntimeOptions                                    $runtime
     *
     * @return SearchFormDataSecondGenerationNoTableFieldResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SearchFormDataSecondGenerationNoTableField',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/instances/advances/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchFormDataSecondGenerationNoTableFieldResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SearchFormDataSecondGenerationNoTableFieldRequest $request
     *
     * @return SearchFormDataSecondGenerationNoTableFieldResponse
     */
    public function searchFormDataSecondGenerationNoTableField($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchFormDataSecondGenerationNoTableFieldHeaders([]);

        return $this->searchFormDataSecondGenerationNoTableFieldWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchFormDatasRequest $request
     * @param SearchFormDatasHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return SearchFormDatasResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SearchFormDatas',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/instances/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchFormDatasResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SearchFormDatasRequest $request
     *
     * @return SearchFormDatasResponse
     */
    public function searchFormDatas($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchFormDatasHeaders([]);

        return $this->searchFormDatasWithOptions($request, $headers, $runtime);
    }

    /**
     * @param StartInstanceRequest $request
     * @param StartInstanceHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return StartInstanceResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'StartInstance',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/processes/instances/start',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return StartInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param StartInstanceRequest $request
     *
     * @return StartInstanceResponse
     */
    public function startInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartInstanceHeaders([]);

        return $this->startInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param TerminateCloudAuthorizationRequest $request
     * @param TerminateCloudAuthorizationHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return TerminateCloudAuthorizationResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'TerminateCloudAuthorization',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/cloudAuthorizations/terminate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return TerminateCloudAuthorizationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param TerminateCloudAuthorizationRequest $request
     *
     * @return TerminateCloudAuthorizationResponse
     */
    public function terminateCloudAuthorization($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TerminateCloudAuthorizationHeaders([]);

        return $this->terminateCloudAuthorizationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param TerminateInstanceRequest $request
     * @param TerminateInstanceHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return TerminateInstanceResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'TerminateInstance',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/processes/instances/terminate',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return TerminateInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param TerminateInstanceRequest $request
     *
     * @return TerminateInstanceResponse
     */
    public function terminateInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TerminateInstanceHeaders([]);

        return $this->terminateInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateCloudAccountInformationRequest $request
     * @param UpdateCloudAccountInformationHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return UpdateCloudAccountInformationResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateCloudAccountInformation',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/cloudAccountInfos',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateCloudAccountInformationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateCloudAccountInformationRequest $request
     *
     * @return UpdateCloudAccountInformationResponse
     */
    public function updateCloudAccountInformation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCloudAccountInformationHeaders([]);

        return $this->updateCloudAccountInformationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateFormDataRequest $request
     * @param UpdateFormDataHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return UpdateFormDataResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateFormData',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/instances',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return UpdateFormDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateFormDataRequest $request
     *
     * @return UpdateFormDataResponse
     */
    public function updateFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateFormDataHeaders([]);

        return $this->updateFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateInstanceRequest $request
     * @param UpdateInstanceHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return UpdateInstanceResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateInstance',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/processes/instances',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateInstanceRequest $request
     *
     * @return UpdateInstanceResponse
     */
    public function updateInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInstanceHeaders([]);

        return $this->updateInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateStatusRequest $request
     * @param UpdateStatusHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return UpdateStatusResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateStatus',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/forms/status',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateStatusRequest $request
     *
     * @return UpdateStatusResponse
     */
    public function updateStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateStatusHeaders([]);

        return $this->updateStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpgradeTenantInformationRequest $request
     * @param UpgradeTenantInformationHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return UpgradeTenantInformationResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpgradeTenantInformation',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/tenantInfos',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpgradeTenantInformationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpgradeTenantInformationRequest $request
     *
     * @return UpgradeTenantInformationResponse
     */
    public function upgradeTenantInformation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpgradeTenantInformationHeaders([]);

        return $this->upgradeTenantInformationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                                       $instanceId
     * @param ValidateApplicationAuthorizationOrderRequest $request
     * @param ValidateApplicationAuthorizationOrderHeaders $headers
     * @param RuntimeOptions                               $runtime
     *
     * @return ValidateApplicationAuthorizationOrderResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ValidateApplicationAuthorizationOrder',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/applicationOrderUpdateAuthorizations/' . $instanceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return ValidateApplicationAuthorizationOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                                       $instanceId
     * @param ValidateApplicationAuthorizationOrderRequest $request
     *
     * @return ValidateApplicationAuthorizationOrderResponse
     */
    public function validateApplicationAuthorizationOrder($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateApplicationAuthorizationOrderHeaders([]);

        return $this->validateApplicationAuthorizationOrderWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @param string                                              $callerUid
     * @param ValidateApplicationAuthorizationServiceOrderRequest $request
     * @param ValidateApplicationAuthorizationServiceOrderHeaders $headers
     * @param RuntimeOptions                                      $runtime
     *
     * @return ValidateApplicationAuthorizationServiceOrderResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ValidateApplicationAuthorizationServiceOrder',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/appsAuthorizations/freshOrderInfoReviews/' . $callerUid . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return ValidateApplicationAuthorizationServiceOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                                              $callerUid
     * @param ValidateApplicationAuthorizationServiceOrderRequest $request
     *
     * @return ValidateApplicationAuthorizationServiceOrderResponse
     */
    public function validateApplicationAuthorizationServiceOrder($callerUid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateApplicationAuthorizationServiceOrderHeaders([]);

        return $this->validateApplicationAuthorizationServiceOrderWithOptions($callerUid, $request, $headers, $runtime);
    }

    /**
     * @param string                                        $callerUnionid
     * @param ValidateApplicationServiceOrderUpgradeRequest $request
     * @param ValidateApplicationServiceOrderUpgradeHeaders $headers
     * @param RuntimeOptions                                $runtime
     *
     * @return ValidateApplicationServiceOrderUpgradeResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ValidateApplicationServiceOrderUpgrade',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/applications/orderValidations/' . $callerUnionid . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return ValidateApplicationServiceOrderUpgradeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                                        $callerUnionid
     * @param ValidateApplicationServiceOrderUpgradeRequest $request
     *
     * @return ValidateApplicationServiceOrderUpgradeResponse
     */
    public function validateApplicationServiceOrderUpgrade($callerUnionid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateApplicationServiceOrderUpgradeHeaders([]);

        return $this->validateApplicationServiceOrderUpgradeWithOptions($callerUnionid, $request, $headers, $runtime);
    }

    /**
     * @param ValidateOrderBuyRequest $request
     * @param ValidateOrderBuyHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ValidateOrderBuyResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ValidateOrderBuy',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/orderBuy/validate',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return ValidateOrderBuyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ValidateOrderBuyRequest $request
     *
     * @return ValidateOrderBuyResponse
     */
    public function validateOrderBuy($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateOrderBuyHeaders([]);

        return $this->validateOrderBuyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                     $instanceId
     * @param ValidateOrderUpdateRequest $request
     * @param ValidateOrderUpdateHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return ValidateOrderUpdateResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ValidateOrderUpdate',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/orders/renewalReviews/' . $instanceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return ValidateOrderUpdateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                     $instanceId
     * @param ValidateOrderUpdateRequest $request
     *
     * @return ValidateOrderUpdateResponse
     */
    public function validateOrderUpdate($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateOrderUpdateHeaders([]);

        return $this->validateOrderUpdateWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @param ValidateOrderUpgradeRequest $request
     * @param ValidateOrderUpgradeHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return ValidateOrderUpgradeResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ValidateOrderUpgrade',
            'version'     => 'yida_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yida/apps/orderUpgrade/validate',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'formData',
            'bodyType'    => 'json',
        ]);

        return ValidateOrderUpgradeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ValidateOrderUpgradeRequest $request
     *
     * @return ValidateOrderUpgradeResponse
     */
    public function validateOrderUpgrade($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ValidateOrderUpgradeHeaders([]);

        return $this->validateOrderUpgradeWithOptions($request, $headers, $runtime);
    }
}
