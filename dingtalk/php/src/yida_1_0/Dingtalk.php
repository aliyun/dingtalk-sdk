<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
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
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetApplicationAuthorizationServicePlatformResourceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetApplicationAuthorizationServicePlatformResourceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetApplicationAuthorizationServicePlatformResourceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpAccomplishmentTasksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpAccomplishmentTasksRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpAccomplishmentTasksResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpLevelByAccountIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpLevelByAccountIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpLevelByAccountIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpTasksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpTasksRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpTasksResponse;
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
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formInstanceIdList)) {
            @$body['formInstanceIdList'] = $request->formInstanceIdList;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->needFormInstanceValue)) {
            @$body['needFormInstanceValue'] = $request->needFormInstanceValue;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BatchGetFormDataByIdListResponse::fromMap($this->doROARequest('BatchGetFormDataByIdList', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/instances/ids/query', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->asynchronousExecution)) {
            @$body['asynchronousExecution'] = $request->asynchronousExecution;
        }
        if (!Utils::isUnset($request->executeExpression)) {
            @$body['executeExpression'] = $request->executeExpression;
        }
        if (!Utils::isUnset($request->formInstanceIdList)) {
            @$body['formInstanceIdList'] = $request->formInstanceIdList;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BatchRemovalByFormInstanceIdListResponse::fromMap($this->doROARequest('BatchRemovalByFormInstanceIdList', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/instances/batchRemove', 'none', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->asynchronousExecution)) {
            @$body['asynchronousExecution'] = $request->asynchronousExecution;
        }
        if (!Utils::isUnset($request->formDataJsonList)) {
            @$body['formDataJsonList'] = $request->formDataJsonList;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->keepRunningAfterException)) {
            @$body['keepRunningAfterException'] = $request->keepRunningAfterException;
        }
        if (!Utils::isUnset($request->noExecuteExpression)) {
            @$body['noExecuteExpression'] = $request->noExecuteExpression;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BatchSaveFormDataResponse::fromMap($this->doROARequest('BatchSaveFormData', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/instances/batchSave', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->asynchronousExecution)) {
            @$body['asynchronousExecution'] = $request->asynchronousExecution;
        }
        if (!Utils::isUnset($request->formInstanceIdList)) {
            @$body['formInstanceIdList'] = $request->formInstanceIdList;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->ignoreEmpty)) {
            @$body['ignoreEmpty'] = $request->ignoreEmpty;
        }
        if (!Utils::isUnset($request->noExecuteExpression)) {
            @$body['noExecuteExpression'] = $request->noExecuteExpression;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->updateFormDataJson)) {
            @$body['updateFormDataJson'] = $request->updateFormDataJson;
        }
        if (!Utils::isUnset($request->useLatestFormSchemaVersion)) {
            @$body['useLatestFormSchemaVersion'] = $request->useLatestFormSchemaVersion;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BatchUpdateFormDataByInstanceIdResponse::fromMap($this->doROARequest('BatchUpdateFormDataByInstanceId', 'yida_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/yida/forms/instances/components', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->asynchronousExecution)) {
            @$body['asynchronousExecution'] = $request->asynchronousExecution;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->ignoreEmpty)) {
            @$body['ignoreEmpty'] = $request->ignoreEmpty;
        }
        if (!Utils::isUnset($request->noExecuteExpression)) {
            @$body['noExecuteExpression'] = $request->noExecuteExpression;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->updateFormDataJsonMap)) {
            @$body['updateFormDataJsonMap'] = $request->updateFormDataJsonMap;
        }
        if (!Utils::isUnset($request->useLatestFormSchemaVersion)) {
            @$body['useLatestFormSchemaVersion'] = $request->useLatestFormSchemaVersion;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BatchUpdateFormDataByInstanceMapResponse::fromMap($this->doROARequest('BatchUpdateFormDataByInstanceMap', 'yida_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/yida/forms/instances/datas', 'json', $req, $runtime));
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
            @$body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->accountNumber)) {
            @$body['accountNumber'] = $request->accountNumber;
        }
        if (!Utils::isUnset($request->beginTimeGMT)) {
            @$body['beginTimeGMT'] = $request->beginTimeGMT;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            @$body['callerUnionId'] = $request->callerUnionId;
        }
        if (!Utils::isUnset($request->chargeType)) {
            @$body['chargeType'] = $request->chargeType;
        }
        if (!Utils::isUnset($request->commerceType)) {
            @$body['commerceType'] = $request->commerceType;
        }
        if (!Utils::isUnset($request->commodityType)) {
            @$body['commodityType'] = $request->commodityType;
        }
        if (!Utils::isUnset($request->endTimeGMT)) {
            @$body['endTimeGMT'] = $request->endTimeGMT;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->instanceName)) {
            @$body['instanceName'] = $request->instanceName;
        }
        if (!Utils::isUnset($request->produceCode)) {
            @$body['produceCode'] = $request->produceCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BuyAuthorizationOrderResponse::fromMap($this->doROARequest('BuyAuthorizationOrder', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/appAuthorizations/order', 'json', $req, $runtime));
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
            @$body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->accountNumber)) {
            @$body['accountNumber'] = $request->accountNumber;
        }
        if (!Utils::isUnset($request->beginTimeGMT)) {
            @$body['beginTimeGMT'] = $request->beginTimeGMT;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            @$body['callerUnionId'] = $request->callerUnionId;
        }
        if (!Utils::isUnset($request->chargeType)) {
            @$body['chargeType'] = $request->chargeType;
        }
        if (!Utils::isUnset($request->commerceType)) {
            @$body['commerceType'] = $request->commerceType;
        }
        if (!Utils::isUnset($request->commodityType)) {
            @$body['commodityType'] = $request->commodityType;
        }
        if (!Utils::isUnset($request->endTimeGMT)) {
            @$body['endTimeGMT'] = $request->endTimeGMT;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->instanceName)) {
            @$body['instanceName'] = $request->instanceName;
        }
        if (!Utils::isUnset($request->produceCode)) {
            @$body['produceCode'] = $request->produceCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BuyFreshOrderResponse::fromMap($this->doROARequest('BuyFreshOrder', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/apps/freshOrders', 'json', $req, $runtime));
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
        $callerUid = OpenApiUtilClient::getEncodeParam($callerUid);
        $query     = [];
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return CheckCloudAccountStatusResponse::fromMap($this->doROARequest('CheckCloudAccountStatus', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/cloudAccountStatus/' . $callerUid . '', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            @$body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->noExecuteExpression)) {
            @$body['noExecuteExpression'] = $request->noExecuteExpression;
        }
        if (!Utils::isUnset($request->searchCondition)) {
            @$body['searchCondition'] = $request->searchCondition;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateOrUpdateFormDataResponse::fromMap($this->doROARequest('CreateOrUpdateFormData', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/instances/insertOrUpdate', 'json', $req, $runtime));
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
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formInstanceId)) {
            @$query['formInstanceId'] = $request->formInstanceId;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteFormDataResponse::fromMap($this->doROARequest('DeleteFormData', 'yida_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/yida/forms/instances', 'none', $req, $runtime));
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
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            @$query['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteInstanceResponse::fromMap($this->doROARequest('DeleteInstance', 'yida_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/yida/processes/instances', 'none', $req, $runtime));
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
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->sequence)) {
            @$query['sequence'] = $request->sequence;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteSequenceResponse::fromMap($this->doROARequest('DeleteSequence', 'yida_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/yida/forms/deleteSequence', 'none', $req, $runtime));
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
            @$body['appId'] = $request->appId;
        }
        if (!Utils::isUnset($request->customDomain)) {
            @$body['customDomain'] = $request->customDomain;
        }
        if (!Utils::isUnset($request->deployStage)) {
            @$body['deployStage'] = $request->deployStage;
        }
        if (!Utils::isUnset($request->gateWayAppKey)) {
            @$body['gateWayAppKey'] = $request->gateWayAppKey;
        }
        if (!Utils::isUnset($request->gateWayAppSecret)) {
            @$body['gateWayAppSecret'] = $request->gateWayAppSecret;
        }
        if (!Utils::isUnset($request->gateWayDomain)) {
            @$body['gateWayDomain'] = $request->gateWayDomain;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return DeployFunctionCallbackResponse::fromMap($this->doROARequest('DeployFunctionCallback', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/functionComputeConnectors/completeDeployments/notify', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->outResult)) {
            @$body['outResult'] = $request->outResult;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->taskInformationList)) {
            @$body['taskInformationList'] = $request->taskInformationList;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ExecuteBatchTaskResponse::fromMap($this->doROARequest('ExecuteBatchTask', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/tasks/batches/execute', 'json', $req, $runtime));
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
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->data)) {
            @$query['data'] = $request->data;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->serviceId)) {
            @$query['serviceId'] = $request->serviceId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ExecuteCustomApiResponse::fromMap($this->doROARequest('ExecuteCustomApi', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/apps/customApi/execute', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            @$body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->noExecuteExpressions)) {
            @$body['noExecuteExpressions'] = $request->noExecuteExpressions;
        }
        if (!Utils::isUnset($request->outResult)) {
            @$body['outResult'] = $request->outResult;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            @$body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ExecutePlatformTaskResponse::fromMap($this->doROARequest('ExecutePlatformTask', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/tasks/platformTasks/execute', 'none', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->digitalSignUrl)) {
            @$body['digitalSignUrl'] = $request->digitalSignUrl;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            @$body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->noExecuteExpressions)) {
            @$body['noExecuteExpressions'] = $request->noExecuteExpressions;
        }
        if (!Utils::isUnset($request->outResult)) {
            @$body['outResult'] = $request->outResult;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            @$body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->taskId)) {
            @$body['taskId'] = $request->taskId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ExecuteTaskResponse::fromMap($this->doROARequest('ExecuteTask', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/tasks/execute', 'none', $req, $runtime));
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
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$query['instanceId'] = $request->instanceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ExpireCommodityResponse::fromMap($this->doROARequest('ExpireCommodity', 'yida_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/yida/appAuth/commodities/expire', 'json', $req, $runtime));
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
        $callerUid = OpenApiUtilClient::getEncodeParam($callerUid);
        $query     = [];
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetActivationCodeByCallerUnionIdResponse::fromMap($this->doROARequest('GetActivationCodeByCallerUnionId', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/applications/activationCodes/' . $callerUid . '', 'json', $req, $runtime));
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
        $appType     = OpenApiUtilClient::getEncodeParam($appType);
        $processCode = OpenApiUtilClient::getEncodeParam($processCode);
        $activityId  = OpenApiUtilClient::getEncodeParam($activityId);
        $query       = [];
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetActivityButtonListResponse::fromMap($this->doROARequest('GetActivityButtonList', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/processDefinitions/buttons/' . $appType . '/' . $processCode . '/' . $activityId . '', 'json', $req, $runtime));
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
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processCode)) {
            @$query['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetActivityListResponse::fromMap($this->doROARequest('GetActivityList', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/processes/activities', 'json', $req, $runtime));
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
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$query['instanceId'] = $request->instanceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetApplicationAuthorizationServicePlatformResourceResponse::fromMap($this->doROARequest('GetApplicationAuthorizationServicePlatformResource', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/authorization/platformResources', 'json', $req, $runtime));
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
        $corpId = OpenApiUtilClient::getEncodeParam($corpId);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $query  = [];
        if (!Utils::isUnset($request->appTypes)) {
            @$query['appTypes'] = $request->appTypes;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            @$query['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            @$query['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->keyword)) {
            @$query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->processCodes)) {
            @$query['processCodes'] = $request->processCodes;
        }
        if (!Utils::isUnset($request->token)) {
            @$query['token'] = $request->token;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetCorpAccomplishmentTasksResponse::fromMap($this->doROARequest('GetCorpAccomplishmentTasks', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/tasks/completedTasks/' . $corpId . '/' . $userId . '', 'json', $req, $runtime));
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
            @$query['accountId'] = $request->accountId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetCorpLevelByAccountIdResponse::fromMap($this->doROARequest('GetCorpLevelByAccountId', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/corpLevel', 'json', $req, $runtime));
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
            @$query['appTypes'] = $request->appTypes;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            @$query['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            @$query['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->keyword)) {
            @$query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->processCodes)) {
            @$query['processCodes'] = $request->processCodes;
        }
        if (!Utils::isUnset($request->token)) {
            @$query['token'] = $request->token;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetCorpTasksResponse::fromMap($this->doROARequest('GetCorpTasks', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/corpTasks', 'json', $req, $runtime));
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
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$query['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetFieldDefByUuidResponse::fromMap($this->doROARequest('GetFieldDefByUuid', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/forms/formFields', 'json', $req, $runtime));
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
        $appType  = OpenApiUtilClient::getEncodeParam($appType);
        $formUuid = OpenApiUtilClient::getEncodeParam($formUuid);
        $query    = [];
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->version)) {
            @$query['version'] = $request->version;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetFormComponentDefinitionListResponse::fromMap($this->doROARequest('GetFormComponentDefinitionList', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/forms/definitions/' . $appType . '/' . $formUuid . '', 'json', $req, $runtime));
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
        $id    = OpenApiUtilClient::getEncodeParam($id);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetFormDataByIDResponse::fromMap($this->doROARequest('GetFormDataByID', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/forms/instances/' . $id . '', 'json', $req, $runtime));
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
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formTypes)) {
            @$query['formTypes'] = $request->formTypes;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetFormListInAppResponse::fromMap($this->doROARequest('GetFormListInApp', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/forms', 'json', $req, $runtime));
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
        $id    = OpenApiUtilClient::getEncodeParam($id);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetInstanceByIdResponse::fromMap($this->doROARequest('GetInstanceById', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/processes/instancesInfos/' . $id . '', 'json', $req, $runtime));
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
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->approvedResult)) {
            @$body['approvedResult'] = $request->approvedResult;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            @$body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            @$body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->instanceStatus)) {
            @$body['instanceStatus'] = $request->instanceStatus;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            @$body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            @$body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->originatorId)) {
            @$body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            @$body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->taskId)) {
            @$body['taskId'] = $request->taskId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetInstanceIdListResponse::fromMap($this->doROARequest('GetInstanceIdList', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/processes/instanceIds', 'json', $req, $runtime));
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
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->approvedResult)) {
            @$body['approvedResult'] = $request->approvedResult;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            @$body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            @$body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->instanceStatus)) {
            @$body['instanceStatus'] = $request->instanceStatus;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            @$body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            @$body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->orderConfigJson)) {
            @$body['orderConfigJson'] = $request->orderConfigJson;
        }
        if (!Utils::isUnset($request->originatorId)) {
            @$body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            @$body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->taskId)) {
            @$body['taskId'] = $request->taskId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetInstancesResponse::fromMap($this->doROARequest('GetInstances', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/processes/instances', 'json', $req, $runtime));
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
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processInstanceIds)) {
            @$query['processInstanceIds'] = $request->processInstanceIds;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetInstancesByIdListResponse::fromMap($this->doROARequest('GetInstancesByIdList', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/processes/instances/searchWithIds', 'json', $req, $runtime));
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
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $query  = [];
        if (!Utils::isUnset($request->appTypes)) {
            @$query['appTypes'] = $request->appTypes;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            @$query['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            @$query['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->keyword)) {
            @$query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->processCodes)) {
            @$query['processCodes'] = $request->processCodes;
        }
        if (!Utils::isUnset($request->token)) {
            @$query['token'] = $request->token;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetMeCorpSubmissionResponse::fromMap($this->doROARequest('GetMeCorpSubmission', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/tasks/myCorpSubmission/' . $userId . '', 'json', $req, $runtime));
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
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $query  = [];
        if (!Utils::isUnset($request->appTypes)) {
            @$query['appTypes'] = $request->appTypes;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            @$query['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            @$query['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->instanceCreateFromTimeGMT)) {
            @$query['instanceCreateFromTimeGMT'] = $request->instanceCreateFromTimeGMT;
        }
        if (!Utils::isUnset($request->instanceCreateToTimeGMT)) {
            @$query['instanceCreateToTimeGMT'] = $request->instanceCreateToTimeGMT;
        }
        if (!Utils::isUnset($request->keyword)) {
            @$query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->processCodes)) {
            @$query['processCodes'] = $request->processCodes;
        }
        if (!Utils::isUnset($request->token)) {
            @$query['token'] = $request->token;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetNotifyMeResponse::fromMap($this->doROARequest('GetNotifyMe', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/corpNotifications/' . $userId . '', 'json', $req, $runtime));
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
        $appType = OpenApiUtilClient::getEncodeParam($appType);
        $query   = [];
        if (!Utils::isUnset($request->fileUrl)) {
            @$query['fileUrl'] = $request->fileUrl;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->timeout)) {
            @$query['timeout'] = $request->timeout;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetOpenUrlResponse::fromMap($this->doROARequest('GetOpenUrl', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/temporaryUrls/' . $appType . '', 'json', $req, $runtime));
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
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            @$query['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetOperationRecordsResponse::fromMap($this->doROARequest('GetOperationRecords', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/processes/operationRecords', 'json', $req, $runtime));
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
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$query['instanceId'] = $request->instanceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetPlatformResourceResponse::fromMap($this->doROARequest('GetPlatformResource', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/platformResources', 'json', $req, $runtime));
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
            @$query['nameLike'] = $request->nameLike;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetPrintAppInfoResponse::fromMap($this->doROARequest('GetPrintAppInfo', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/printTemplates/printAppInfos', 'json', $req, $runtime));
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
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$query['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->version)) {
            @$query['version'] = $request->version;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetPrintDictionaryResponse::fromMap($this->doROARequest('GetPrintDictionary', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/printTemplates/printDictionaries', 'json', $req, $runtime));
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
        $processInstanceId = OpenApiUtilClient::getEncodeParam($processInstanceId);
        $query             = [];
        if (!Utils::isUnset($request->appType)) {
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->groupId)) {
            @$query['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->nameSpace_)) {
            @$query['nameSpace_'] = $request->nameSpace_;
        }
        if (!Utils::isUnset($request->orderNumber)) {
            @$query['orderNumber'] = $request->orderNumber;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->systemType)) {
            @$query['systemType'] = $request->systemType;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetProcessDefinitionResponse::fromMap($this->doROARequest('GetProcessDefinition', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/processes/definitions/' . $processInstanceId . '', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->processInstanceIdList)) {
            @$body['processInstanceIdList'] = $request->processInstanceIdList;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userCorpId)) {
            @$body['userCorpId'] = $request->userCorpId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetRunningTaskListResponse::fromMap($this->doROARequest('GetRunningTaskList', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/tasks/runningTasks/query', 'json', $req, $runtime));
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
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            @$query['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetRunningTasksResponse::fromMap($this->doROARequest('GetRunningTasks', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/processes/tasks/getRunningTasks', 'json', $req, $runtime));
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
            @$query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->namespace_)) {
            @$query['namespace_'] = $request->namespace_;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetSaleUserInfoByUserIdResponse::fromMap($this->doROARequest('GetSaleUserInfoByUserId', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/saleUserInfo', 'json', $req, $runtime));
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
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            @$query['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            @$query['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->keyword)) {
            @$query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->processCodes)) {
            @$query['processCodes'] = $request->processCodes;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetTaskCopiesResponse::fromMap($this->doROARequest('GetTaskCopies', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/tasks/taskCopies', 'json', $req, $runtime));
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
            @$query['appFilter'] = $request->appFilter;
        }
        if (!Utils::isUnset($request->appNameSearchKeyword)) {
            @$query['appNameSearchKeyword'] = $request->appNameSearchKeyword;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->token)) {
            @$query['token'] = $request->token;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListApplicationResponse::fromMap($this->doROARequest('ListApplication', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/organizations/applications', 'json', $req, $runtime));
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
        $instanceId = OpenApiUtilClient::getEncodeParam($instanceId);
        $query      = [];
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            @$query['callerUnionId'] = $request->callerUnionId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListApplicationAuthorizationServiceApplicationInformationResponse::fromMap($this->doROARequest('ListApplicationAuthorizationServiceApplicationInformation', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/authorizations/applicationInfos/' . $instanceId . '', 'json', $req, $runtime));
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
        $instanceId = OpenApiUtilClient::getEncodeParam($instanceId);
        $query      = [];
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListApplicationAuthorizationServiceConnectorInformationResponse::fromMap($this->doROARequest('ListApplicationAuthorizationServiceConnectorInformation', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/applicationAuthorizations/plugs/' . $instanceId . '', 'json', $req, $runtime));
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
        $instanceId = OpenApiUtilClient::getEncodeParam($instanceId);
        $query      = [];
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListApplicationInformationResponse::fromMap($this->doROARequest('ListApplicationInformation', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/infos/' . $instanceId . '', 'json', $req, $runtime));
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
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListCommodityResponse::fromMap($this->doROARequest('ListCommodity', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/appAuth/commodities', 'json', $req, $runtime));
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
        $instanceId = OpenApiUtilClient::getEncodeParam($instanceId);
        $query      = [];
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListConnectorInformationResponse::fromMap($this->doROARequest('ListConnectorInformation', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/plugins/infos/' . $instanceId . '', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formInstanceIdList)) {
            @$body['formInstanceIdList'] = $request->formInstanceIdList;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ListFormRemarksResponse::fromMap($this->doROARequest('ListFormRemarks', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/remarks/query', 'json', $req, $runtime));
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
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formType)) {
            @$query['formType'] = $request->formType;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListNavigationByFormTypeResponse::fromMap($this->doROARequest('ListNavigationByFormType', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/navigations', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formInstanceIdList)) {
            @$body['formInstanceIdList'] = $request->formInstanceIdList;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ListOperationLogsResponse::fromMap($this->doROARequest('ListOperationLogs', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/operationsLogs/query', 'json', $req, $runtime));
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
        $formInstanceId = OpenApiUtilClient::getEncodeParam($formInstanceId);
        $query          = [];
        if (!Utils::isUnset($request->appType)) {
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$query['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->tableFieldId)) {
            @$query['tableFieldId'] = $request->tableFieldId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListTableDataByFormInstanceIdTableIdResponse::fromMap($this->doROARequest('ListTableDataByFormInstanceIdTableId', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/forms/innerTables/' . $formInstanceId . '', 'json', $req, $runtime));
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
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return LoginCodeGenResponse::fromMap($this->doROARequest('LoginCodeGen', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/authorizations/loginCodes', 'json', $req, $runtime));
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
            @$body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->accountNumber)) {
            @$body['accountNumber'] = $request->accountNumber;
        }
        if (!Utils::isUnset($request->beginTimeGMT)) {
            @$body['beginTimeGMT'] = $request->beginTimeGMT;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$body['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->chargeType)) {
            @$body['chargeType'] = $request->chargeType;
        }
        if (!Utils::isUnset($request->commerceType)) {
            @$body['commerceType'] = $request->commerceType;
        }
        if (!Utils::isUnset($request->commodityType)) {
            @$body['commodityType'] = $request->commodityType;
        }
        if (!Utils::isUnset($request->endTimeGMT)) {
            @$body['endTimeGMT'] = $request->endTimeGMT;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->instanceName)) {
            @$body['instanceName'] = $request->instanceName;
        }
        if (!Utils::isUnset($request->produceCode)) {
            @$body['produceCode'] = $request->produceCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return NotifyAuthorizationResultResponse::fromMap($this->doROARequest('NotifyAuthorizationResult', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/apps/authorizationResults/notify', 'json', $req, $runtime));
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
            @$body['appKey'] = $request->appKey;
        }
        if (!Utils::isUnset($request->formTypeList)) {
            @$body['formTypeList'] = $request->formTypeList;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->pageIndex)) {
            @$body['pageIndex'] = $request->pageIndex;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return PageFormBaseInfosResponse::fromMap($this->doROARequest('PageFormBaseInfos', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/apps/forms/query', 'json', $req, $runtime));
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
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$query['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->hookType)) {
            @$query['hookType'] = $request->hookType;
        }
        if (!Utils::isUnset($request->hookUuid)) {
            @$query['hookUuid'] = $request->hookUuid;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$query['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->invokeAfterDateGMT)) {
            @$query['invokeAfterDateGMT'] = $request->invokeAfterDateGMT;
        }
        if (!Utils::isUnset($request->invokeBeforeDateGMT)) {
            @$query['invokeBeforeDateGMT'] = $request->invokeBeforeDateGMT;
        }
        if (!Utils::isUnset($request->invokeStatus)) {
            @$query['invokeStatus'] = $request->invokeStatus;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->requestUrl)) {
            @$query['requestUrl'] = $request->requestUrl;
        }
        if (!Utils::isUnset($request->sourceUuid)) {
            @$query['sourceUuid'] = $request->sourceUuid;
        }
        if (!Utils::isUnset($request->success)) {
            @$query['success'] = $request->success;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryServiceRecordResponse::fromMap($this->doROARequest('QueryServiceRecord', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/services/invocationRecords', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->byManager)) {
            @$body['byManager'] = $request->byManager;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->nowActionExecutorId)) {
            @$body['nowActionExecutorId'] = $request->nowActionExecutorId;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            @$body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->taskId)) {
            @$body['taskId'] = $request->taskId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RedirectTaskResponse::fromMap($this->doROARequest('RedirectTask', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/tasks/redirect', 'none', $req, $runtime));
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
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$query['instanceId'] = $request->instanceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return RefundCommodityResponse::fromMap($this->doROARequest('RefundCommodity', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/appAuth/commodities/refund', 'json', $req, $runtime));
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
            @$body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->activeCode)) {
            @$body['activeCode'] = $request->activeCode;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RegisterAccountsResponse::fromMap($this->doROARequest('RegisterAccounts', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/applicationAuthorizations/accounts/register', 'json', $req, $runtime));
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
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$query['instanceId'] = $request->instanceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ReleaseCommodityResponse::fromMap($this->doROARequest('ReleaseCommodity', 'yida_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/yida/appAuth/commodities/release', 'json', $req, $runtime));
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
        $callerUid = OpenApiUtilClient::getEncodeParam($callerUid);
        $query     = [];
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return RemoveTenantResourceResponse::fromMap($this->doROARequest('RemoveTenantResource', 'yida_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/yida/applications/tenantRelatedResources/' . $callerUid . '', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->fileSize)) {
            @$body['fileSize'] = $request->fileSize;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->namespace_)) {
            @$body['namespace_'] = $request->namespace_;
        }
        if (!Utils::isUnset($request->ossUrl)) {
            @$body['ossUrl'] = $request->ossUrl;
        }
        if (!Utils::isUnset($request->sequenceId)) {
            @$body['sequenceId'] = $request->sequenceId;
        }
        if (!Utils::isUnset($request->source)) {
            @$body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->timeZone)) {
            @$body['timeZone'] = $request->timeZone;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RenderBatchCallbackResponse::fromMap($this->doROARequest('RenderBatchCallback', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/printings/callbacks/batch', 'none', $req, $runtime));
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
            @$body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            @$body['callerUnionId'] = $request->callerUnionId;
        }
        if (!Utils::isUnset($request->endTimeGMT)) {
            @$body['endTimeGMT'] = $request->endTimeGMT;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$body['instanceId'] = $request->instanceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RenewApplicationAuthorizationServiceOrderResponse::fromMap($this->doROARequest('RenewApplicationAuthorizationServiceOrder', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/applicationAuthorizations/orders/renew', 'json', $req, $runtime));
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
            @$body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            @$body['callerUnionId'] = $request->callerUnionId;
        }
        if (!Utils::isUnset($request->endTimeGMT)) {
            @$body['endTimeGMT'] = $request->endTimeGMT;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RenewTenantOrderResponse::fromMap($this->doROARequest('RenewTenantOrder', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/apps/tenants/reorder', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            @$body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SaveFormDataResponse::fromMap($this->doROARequest('SaveFormData', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/instances', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->atUserId)) {
            @$body['atUserId'] = $request->atUserId;
        }
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->formInstanceId)) {
            @$body['formInstanceId'] = $request->formInstanceId;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->replyId)) {
            @$body['replyId'] = $request->replyId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SaveFormRemarkResponse::fromMap($this->doROARequest('SaveFormRemark', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/remarks', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->fileNameConfig)) {
            @$body['fileNameConfig'] = $request->fileNameConfig;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->formVersion)) {
            @$body['formVersion'] = $request->formVersion;
        }
        if (!Utils::isUnset($request->setting)) {
            @$body['setting'] = $request->setting;
        }
        if (!Utils::isUnset($request->templateId)) {
            @$body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->vm)) {
            @$body['vm'] = $request->vm;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SavePrintTplDetailInfoResponse::fromMap($this->doROARequest('SavePrintTplDetailInfo', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/printTemplates/printTplDetailInfos', 'json', $req, $runtime));
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
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return SearchActivationCodeResponse::fromMap($this->doROARequest('SearchActivationCode', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/activationCode/information', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            @$body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            @$body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            @$body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            @$body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->originatorId)) {
            @$body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            @$body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->targetFieldJson)) {
            @$body['targetFieldJson'] = $request->targetFieldJson;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SearchEmployeeFieldValuesResponse::fromMap($this->doROARequest('SearchEmployeeFieldValues', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/employeeFields', 'json', $req, $runtime));
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
        $appType  = OpenApiUtilClient::getEncodeParam($appType);
        $formUuid = OpenApiUtilClient::getEncodeParam($formUuid);
        $query    = [];
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        $body = [];
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            @$body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            @$body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            @$body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            @$body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->originatorId)) {
            @$body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            @$body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SearchFormDataIdListResponse::fromMap($this->doROARequest('SearchFormDataIdList', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/instances/ids/' . $appType . '/' . $formUuid . '', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            @$body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            @$body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            @$body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            @$body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->orderConfigJson)) {
            @$body['orderConfigJson'] = $request->orderConfigJson;
        }
        if (!Utils::isUnset($request->originatorId)) {
            @$body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            @$body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SearchFormDataRemovalTableDataResponse::fromMap($this->doROARequest('SearchFormDataRemovalTableData', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/instances/query', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            @$body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            @$body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            @$body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            @$body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->orderConfigJson)) {
            @$body['orderConfigJson'] = $request->orderConfigJson;
        }
        if (!Utils::isUnset($request->originatorId)) {
            @$body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchCondition)) {
            @$body['searchCondition'] = $request->searchCondition;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SearchFormDataSecondGenerationResponse::fromMap($this->doROARequest('SearchFormDataSecondGeneration', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/instances/advances/queryAll', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            @$body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            @$body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            @$body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            @$body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->orderConfigJson)) {
            @$body['orderConfigJson'] = $request->orderConfigJson;
        }
        if (!Utils::isUnset($request->originatorId)) {
            @$body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchCondition)) {
            @$body['searchCondition'] = $request->searchCondition;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SearchFormDataSecondGenerationNoTableFieldResponse::fromMap($this->doROARequest('SearchFormDataSecondGenerationNoTableField', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/instances/advances/query', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            @$body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            @$body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->currentPage)) {
            @$body['currentPage'] = $request->currentPage;
        }
        if (!Utils::isUnset($request->dynamicOrder)) {
            @$body['dynamicOrder'] = $request->dynamicOrder;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            @$body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            @$body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->originatorId)) {
            @$body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            @$body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SearchFormDatasResponse::fromMap($this->doROARequest('SearchFormDatas', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/forms/instances/search', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->departmentId)) {
            @$body['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            @$body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->formUuid)) {
            @$body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processCode)) {
            @$body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return StartInstanceResponse::fromMap($this->doROARequest('StartInstance', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/processes/instances/start', 'json', $req, $runtime));
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
            @$body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            @$body['callerUnionId'] = $request->callerUnionId;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$body['instanceId'] = $request->instanceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return TerminateCloudAuthorizationResponse::fromMap($this->doROARequest('TerminateCloudAuthorization', 'yida_1.0', 'HTTP', 'POST', 'AK', '/v1.0/yida/apps/cloudAuthorizations/terminate', 'json', $req, $runtime));
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
            @$query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            @$query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            @$query['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return TerminateInstanceResponse::fromMap($this->doROARequest('TerminateInstance', 'yida_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/yida/processes/instances/terminate', 'none', $req, $runtime));
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
            @$body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->accountNumber)) {
            @$body['accountNumber'] = $request->accountNumber;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            @$body['callerUnionId'] = $request->callerUnionId;
        }
        if (!Utils::isUnset($request->commodityType)) {
            @$body['commodityType'] = $request->commodityType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateCloudAccountInformationResponse::fromMap($this->doROARequest('UpdateCloudAccountInformation', 'yida_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/yida/apps/cloudAccountInfos', 'json', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formInstanceId)) {
            @$body['formInstanceId'] = $request->formInstanceId;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->updateFormDataJson)) {
            @$body['updateFormDataJson'] = $request->updateFormDataJson;
        }
        if (!Utils::isUnset($request->useLatestVersion)) {
            @$body['useLatestVersion'] = $request->useLatestVersion;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateFormDataResponse::fromMap($this->doROARequest('UpdateFormData', 'yida_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/yida/forms/instances', 'none', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            @$body['processInstanceId'] = $request->processInstanceId;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->updateFormDataJson)) {
            @$body['updateFormDataJson'] = $request->updateFormDataJson;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateInstanceResponse::fromMap($this->doROARequest('UpdateInstance', 'yida_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/yida/processes/instances', 'none', $req, $runtime));
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
            @$body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->errorLines)) {
            @$body['errorLines'] = $request->errorLines;
        }
        if (!Utils::isUnset($request->importSequence)) {
            @$body['importSequence'] = $request->importSequence;
        }
        if (!Utils::isUnset($request->language)) {
            @$body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->systemToken)) {
            @$body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateStatusResponse::fromMap($this->doROARequest('UpdateStatus', 'yida_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/yida/forms/status', 'none', $req, $runtime));
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
            @$body['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->accountNumber)) {
            @$body['accountNumber'] = $request->accountNumber;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            @$body['callerUnionId'] = $request->callerUnionId;
        }
        if (!Utils::isUnset($request->commodityType)) {
            @$body['commodityType'] = $request->commodityType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpgradeTenantInformationResponse::fromMap($this->doROARequest('UpgradeTenantInformation', 'yida_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/yida/apps/tenantInfos', 'json', $req, $runtime));
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
        $instanceId = OpenApiUtilClient::getEncodeParam($instanceId);
        $query      = [];
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUnionId)) {
            @$query['callerUnionId'] = $request->callerUnionId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ValidateApplicationAuthorizationOrderResponse::fromMap($this->doROARequest('ValidateApplicationAuthorizationOrder', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/applicationOrderUpdateAuthorizations/' . $instanceId . '', 'json', $req, $runtime));
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
        $callerUid = OpenApiUtilClient::getEncodeParam($callerUid);
        $query     = [];
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ValidateApplicationAuthorizationServiceOrderResponse::fromMap($this->doROARequest('ValidateApplicationAuthorizationServiceOrder', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/appsAuthorizations/freshOrderInfoReviews/' . $callerUid . '', 'json', $req, $runtime));
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
        $callerUnionid = OpenApiUtilClient::getEncodeParam($callerUnionid);
        $query         = [];
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ValidateApplicationServiceOrderUpgradeResponse::fromMap($this->doROARequest('ValidateApplicationServiceOrderUpgrade', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/applications/orderValidations/' . $callerUnionid . '', 'json', $req, $runtime));
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
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ValidateOrderBuyResponse::fromMap($this->doROARequest('ValidateOrderBuy', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/orderBuy/validate', 'json', $req, $runtime));
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
        $instanceId = OpenApiUtilClient::getEncodeParam($instanceId);
        $query      = [];
        if (!Utils::isUnset($request->accessKey)) {
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ValidateOrderUpdateResponse::fromMap($this->doROARequest('ValidateOrderUpdate', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/orders/renewalReviews/' . $instanceId . '', 'json', $req, $runtime));
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
            @$query['accessKey'] = $request->accessKey;
        }
        if (!Utils::isUnset($request->callerUid)) {
            @$query['callerUid'] = $request->callerUid;
        }
        if (!Utils::isUnset($request->instanceId)) {
            @$query['instanceId'] = $request->instanceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ValidateOrderUpgradeResponse::fromMap($this->doROARequest('ValidateOrderUpgrade', 'yida_1.0', 'HTTP', 'GET', 'AK', '/v1.0/yida/apps/orderUpgrade/validate', 'json', $req, $runtime));
    }
}
