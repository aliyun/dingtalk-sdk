<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AbandonCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AbandonCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AbandonCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddCrmPersonalCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddCrmPersonalCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddCrmPersonalCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddCustomerTrackHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddCustomerTrackRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddCustomerTrackResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddLeadsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddLeadsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddLeadsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddMetaModelFieldHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddMetaModelFieldRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddMetaModelFieldResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddRelationMetaFieldHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddRelationMetaFieldRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddRelationMetaFieldResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AppendCustomerDataAuthHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AppendCustomerDataAuthRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AppendCustomerDataAuthResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddContactsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddContactsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddContactsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddFollowRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddFollowRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddFollowRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddRelationDatasHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddRelationDatasRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddRelationDatasResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchCreateClueDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchCreateClueDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchCreateClueDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchRemoveFollowRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchRemoveFollowRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchRemoveFollowRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchSendOfficialAccountOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchSendOfficialAccountOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchSendOfficialAccountOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchUpdateContactsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchUpdateContactsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchUpdateContactsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchUpdateFollowRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchUpdateFollowRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchUpdateFollowRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchUpdateRelationDatasHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchUpdateRelationDatasRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchUpdateRelationDatasResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ConsumeBenefitInventoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ConsumeBenefitInventoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ConsumeBenefitInventoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateGroupSetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateGroupSetRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateGroupSetResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateRelationMetaHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateRelationMetaRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateRelationMetaResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmCustomObjectDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmCustomObjectDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmCustomObjectDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmFormInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmFormInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmFormInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmPersonalCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmPersonalCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteCrmPersonalCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteLeadsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteLeadsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteLeadsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteRelationMetaFieldHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteRelationMetaFieldRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DeleteRelationMetaFieldResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeCrmPersonalCustomerObjectMetaHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeCrmPersonalCustomerObjectMetaRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeCrmPersonalCustomerObjectMetaResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeMetaModelHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeMetaModelRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeMetaModelResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\FindTargetRelatedFollowRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\FindTargetRelatedFollowRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\FindTargetRelatedFollowRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetAllCustomerRecyclesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetAllCustomerRecyclesRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetAllCustomerRecyclesResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetContactsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetContactsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetContactsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmGroupChatHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmGroupChatMultiHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmGroupChatMultiRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmGroupChatMultiResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmGroupChatResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmGroupChatSingleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmGroupChatSingleRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmGroupChatSingleResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCustomerTracksByRelationIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCustomerTracksByRelationIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCustomerTracksByRelationIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetGroupSetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetGroupSetRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetGroupSetResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetInAppPurchaseGoodsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetInAppPurchaseGoodsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetInAppPurchaseGoodsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetNavigationCatalogHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetNavigationCatalogRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetNavigationCatalogResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetObjectDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetObjectDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetObjectDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountOTOMessageResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountOTOMessageResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountOTOMessageResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetRelationUkSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetRelationUkSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetRelationUkSettingResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\JoinGroupSetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\JoinGroupSetRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\JoinGroupSetResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListAvailableBenefitHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListAvailableBenefitRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListAvailableBenefitResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListBenefitLicenseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListBenefitLicenseRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListBenefitLicenseResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListClueTagHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListClueTagResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListCrmPersonalCustomersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListCrmPersonalCustomersRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListCrmPersonalCustomersResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListGroupSetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListGroupSetRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListGroupSetResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\OverrideUpdateCustomerDataAuthHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\OverrideUpdateCustomerDataAuthRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\OverrideUpdateCustomerDataAuthResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllTracksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllTracksRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllTracksResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAppManagerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAppManagerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAppManagerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryBenefitInventoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryBenefitInventoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryBenefitInventoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryClueFollowStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryClueFollowStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryClueFollowStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmGroupChatsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmGroupChatsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmGroupChatsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmPersonalCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmPersonalCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmPersonalCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCustomerBizTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCustomerBizTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCustomerBizTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryGlobalInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryGlobalInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryGlobalInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryHasAppPermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryHasAppPermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryHasAppPermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryOfficialAccountUserBasicInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryOfficialAccountUserBasicInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryOfficialAccountUserBasicInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryRelationDatasByTargetIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryRelationDatasByTargetIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryRelationDatasByTargetIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\RecallOfficialAccountOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\RecallOfficialAccountOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\RecallOfficialAccountOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SaveBenefitLicenseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SaveBenefitLicenseRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SaveBenefitLicenseResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountSNSMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountSNSMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountSNSMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\TwoPhaseCommitInventoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\TwoPhaseCommitInventoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\TwoPhaseCommitInventoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateCrmPersonalCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateCrmPersonalCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateCrmPersonalCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateCustomerBizTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateCustomerBizTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateCustomerBizTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateGroupSetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateGroupSetRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateGroupSetResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateMenuDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateMenuDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateMenuDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateMetaModelFieldHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateMetaModelFieldRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateMetaModelFieldResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateRelationMetaFieldHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateRelationMetaFieldRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateRelationMetaFieldResponse;
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
     * @summary 从私海放弃客户（退回公海）
     *  *
     * @param AbandonCustomerRequest $request AbandonCustomerRequest
     * @param AbandonCustomerHeaders $headers AbandonCustomerHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return AbandonCustomerResponse AbandonCustomerResponse
     */
    public function abandonCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->customTrackDesc)) {
            $body['customTrackDesc'] = $request->customTrackDesc;
        }
        if (!Utils::isUnset($request->instanceIdList)) {
            $body['instanceIdList'] = $request->instanceIdList;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->optType)) {
            $body['optType'] = $request->optType;
        }
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
            'action'      => 'AbandonCustomer',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/customers/abandon',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AbandonCustomerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 从私海放弃客户（退回公海）
     *  *
     * @param AbandonCustomerRequest $request AbandonCustomerRequest
     *
     * @return AbandonCustomerResponse AbandonCustomerResponse
     */
    public function abandonCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AbandonCustomerHeaders([]);

        return $this->abandonCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加crm个人客户（或企业客户）
     *  *
     * @param AddCrmPersonalCustomerRequest $request AddCrmPersonalCustomerRequest
     * @param AddCrmPersonalCustomerHeaders $headers AddCrmPersonalCustomerHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return AddCrmPersonalCustomerResponse AddCrmPersonalCustomerResponse
     */
    public function addCrmPersonalCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->creatorNick)) {
            $body['creatorNick'] = $request->creatorNick;
        }
        if (!Utils::isUnset($request->creatorUserId)) {
            $body['creatorUserId'] = $request->creatorUserId;
        }
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->extendData)) {
            $body['extendData'] = $request->extendData;
        }
        if (!Utils::isUnset($request->permission)) {
            $body['permission'] = $request->permission;
        }
        if (!Utils::isUnset($request->relationType)) {
            $body['relationType'] = $request->relationType;
        }
        if (!Utils::isUnset($request->skipDuplicateCheck)) {
            $body['skipDuplicateCheck'] = $request->skipDuplicateCheck;
        }
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
            'action'      => 'AddCrmPersonalCustomer',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/personalCustomers',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddCrmPersonalCustomerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加crm个人客户（或企业客户）
     *  *
     * @param AddCrmPersonalCustomerRequest $request AddCrmPersonalCustomerRequest
     *
     * @return AddCrmPersonalCustomerResponse AddCrmPersonalCustomerResponse
     */
    public function addCrmPersonalCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddCrmPersonalCustomerHeaders([]);

        return $this->addCrmPersonalCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新增动态
     *  *
     * @param AddCustomerTrackRequest $request AddCustomerTrackRequest
     * @param AddCustomerTrackHeaders $headers AddCustomerTrackHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return AddCustomerTrackResponse AddCustomerTrackResponse
     */
    public function addCustomerTrackWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->customerId)) {
            $body['customerId'] = $request->customerId;
        }
        if (!Utils::isUnset($request->extraBizInfo)) {
            $body['extraBizInfo'] = $request->extraBizInfo;
        }
        if (!Utils::isUnset($request->idempotentKey)) {
            $body['idempotentKey'] = $request->idempotentKey;
        }
        if (!Utils::isUnset($request->maskedContent)) {
            $body['maskedContent'] = $request->maskedContent;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->relationType)) {
            $body['relationType'] = $request->relationType;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
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
            'action'      => 'AddCustomerTrack',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/customerTracks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddCustomerTrackResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增动态
     *  *
     * @param AddCustomerTrackRequest $request AddCustomerTrackRequest
     *
     * @return AddCustomerTrackResponse AddCustomerTrackResponse
     */
    public function addCustomerTrack($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddCustomerTrackHeaders([]);

        return $this->addCustomerTrackWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 添加线索
     *  *
     * @param AddLeadsRequest $request AddLeadsRequest
     * @param AddLeadsHeaders $headers AddLeadsHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return AddLeadsResponse AddLeadsResponse
     */
    public function addLeadsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->assignTimestamp)) {
            $body['assignTimestamp'] = $request->assignTimestamp;
        }
        if (!Utils::isUnset($request->assignUserId)) {
            $body['assignUserId'] = $request->assignUserId;
        }
        if (!Utils::isUnset($request->assignedUserId)) {
            $body['assignedUserId'] = $request->assignedUserId;
        }
        if (!Utils::isUnset($request->leads)) {
            $body['leads'] = $request->leads;
        }
        if (!Utils::isUnset($request->outTaskId)) {
            $body['outTaskId'] = $request->outTaskId;
        }
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
            'action'      => 'AddLeads',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/leads',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddLeadsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加线索
     *  *
     * @param AddLeadsRequest $request AddLeadsRequest
     *
     * @return AddLeadsResponse AddLeadsResponse
     */
    public function addLeads($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddLeadsHeaders([]);

        return $this->addLeadsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 模型表结构增加字段
     *  *
     * @param AddMetaModelFieldRequest $request AddMetaModelFieldRequest
     * @param AddMetaModelFieldHeaders $headers AddMetaModelFieldHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return AddMetaModelFieldResponse AddMetaModelFieldResponse
     */
    public function addMetaModelFieldWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->fieldDTOList)) {
            $body['fieldDTOList'] = $request->fieldDTOList;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->tenant)) {
            $body['tenant'] = $request->tenant;
        }
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
            'action'      => 'AddMetaModelField',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/metas/models/fields',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddMetaModelFieldResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 模型表结构增加字段
     *  *
     * @param AddMetaModelFieldRequest $request AddMetaModelFieldRequest
     *
     * @return AddMetaModelFieldResponse AddMetaModelFieldResponse
     */
    public function addMetaModelField($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddMetaModelFieldHeaders([]);

        return $this->addMetaModelFieldWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 关系模型表结构增加字段
     *  *
     * @param AddRelationMetaFieldRequest $request AddRelationMetaFieldRequest
     * @param AddRelationMetaFieldHeaders $headers AddRelationMetaFieldHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return AddRelationMetaFieldResponse AddRelationMetaFieldResponse
     */
    public function addRelationMetaFieldWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fieldDTOList)) {
            $body['fieldDTOList'] = $request->fieldDTOList;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->relationType)) {
            $body['relationType'] = $request->relationType;
        }
        if (!Utils::isUnset($request->tenant)) {
            $body['tenant'] = $request->tenant;
        }
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
            'action'      => 'AddRelationMetaField',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/relations/metas/fields',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddRelationMetaFieldResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 关系模型表结构增加字段
     *  *
     * @param AddRelationMetaFieldRequest $request AddRelationMetaFieldRequest
     *
     * @return AddRelationMetaFieldResponse AddRelationMetaFieldResponse
     */
    public function addRelationMetaField($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddRelationMetaFieldHeaders([]);

        return $this->addRelationMetaFieldWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 追加客户数据权限
     *  *
     * @param AppendCustomerDataAuthRequest $request AppendCustomerDataAuthRequest
     * @param AppendCustomerDataAuthHeaders $headers AppendCustomerDataAuthHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return AppendCustomerDataAuthResponse AppendCustomerDataAuthResponse
     */
    public function appendCustomerDataAuthWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->customerIds)) {
            $body['customerIds'] = $request->customerIds;
        }
        if (!Utils::isUnset($request->dataAuthUserIds)) {
            $body['dataAuthUserIds'] = $request->dataAuthUserIds;
        }
        if (!Utils::isUnset($request->formCode)) {
            $body['formCode'] = $request->formCode;
        }
        if (!Utils::isUnset($request->operateUserId)) {
            $body['operateUserId'] = $request->operateUserId;
        }
        if (!Utils::isUnset($request->relationType)) {
            $body['relationType'] = $request->relationType;
        }
        if (!Utils::isUnset($request->roleType)) {
            $body['roleType'] = $request->roleType;
        }
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
            'action'      => 'AppendCustomerDataAuth',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/customers/dataAuth/append',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AppendCustomerDataAuthResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 追加客户数据权限
     *  *
     * @param AppendCustomerDataAuthRequest $request AppendCustomerDataAuthRequest
     *
     * @return AppendCustomerDataAuthResponse AppendCustomerDataAuthResponse
     */
    public function appendCustomerDataAuth($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AppendCustomerDataAuthHeaders([]);

        return $this->appendCustomerDataAuthWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量新增联系人
     *  *
     * @param BatchAddContactsRequest $request BatchAddContactsRequest
     * @param BatchAddContactsHeaders $headers BatchAddContactsHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchAddContactsResponse BatchAddContactsResponse
     */
    public function batchAddContactsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->relationList)) {
            $body['relationList'] = $request->relationList;
        }
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
            'action'      => 'BatchAddContacts',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/contacts/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchAddContactsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量新增联系人
     *  *
     * @param BatchAddContactsRequest $request BatchAddContactsRequest
     *
     * @return BatchAddContactsResponse BatchAddContactsResponse
     */
    public function batchAddContacts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchAddContactsHeaders([]);

        return $this->batchAddContactsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量新增跟进记录
     *  *
     * @param BatchAddFollowRecordsRequest $request BatchAddFollowRecordsRequest
     * @param BatchAddFollowRecordsHeaders $headers BatchAddFollowRecordsHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchAddFollowRecordsResponse BatchAddFollowRecordsResponse
     */
    public function batchAddFollowRecordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->instanceList)) {
            $body['instanceList'] = $request->instanceList;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
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
            'action'      => 'BatchAddFollowRecords',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/followRecords/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchAddFollowRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量新增跟进记录
     *  *
     * @param BatchAddFollowRecordsRequest $request BatchAddFollowRecordsRequest
     *
     * @return BatchAddFollowRecordsResponse BatchAddFollowRecordsResponse
     */
    public function batchAddFollowRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchAddFollowRecordsHeaders([]);

        return $this->batchAddFollowRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量新增关系数据
     *  *
     * @param BatchAddRelationDatasRequest $request BatchAddRelationDatasRequest
     * @param BatchAddRelationDatasHeaders $headers BatchAddRelationDatasHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchAddRelationDatasResponse BatchAddRelationDatasResponse
     */
    public function batchAddRelationDatasWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->relationList)) {
            $body['relationList'] = $request->relationList;
        }
        if (!Utils::isUnset($request->relationType)) {
            $body['relationType'] = $request->relationType;
        }
        if (!Utils::isUnset($request->skipDuplicateCheck)) {
            $body['skipDuplicateCheck'] = $request->skipDuplicateCheck;
        }
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
            'action'      => 'BatchAddRelationDatas',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/relationDatas/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchAddRelationDatasResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量新增关系数据
     *  *
     * @param BatchAddRelationDatasRequest $request BatchAddRelationDatasRequest
     *
     * @return BatchAddRelationDatasResponse BatchAddRelationDatasResponse
     */
    public function batchAddRelationDatas($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchAddRelationDatasHeaders([]);

        return $this->batchAddRelationDatasWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量创建线索数据
     *  *
     * @param BatchCreateClueDataRequest $request BatchCreateClueDataRequest
     * @param BatchCreateClueDataHeaders $headers BatchCreateClueDataHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchCreateClueDataResponse BatchCreateClueDataResponse
     */
    public function batchCreateClueDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dataList)) {
            $body['dataList'] = $request->dataList;
        }
        if (!Utils::isUnset($request->privateSeas)) {
            $body['privateSeas'] = $request->privateSeas;
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
            'action'      => 'BatchCreateClueData',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/clues/datas/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchCreateClueDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量创建线索数据
     *  *
     * @param BatchCreateClueDataRequest $request BatchCreateClueDataRequest
     *
     * @return BatchCreateClueDataResponse BatchCreateClueDataResponse
     */
    public function batchCreateClueData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchCreateClueDataHeaders([]);

        return $this->batchCreateClueDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量删除跟进记录
     *  *
     * @param BatchRemoveFollowRecordsRequest $request BatchRemoveFollowRecordsRequest
     * @param BatchRemoveFollowRecordsHeaders $headers BatchRemoveFollowRecordsHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchRemoveFollowRecordsResponse BatchRemoveFollowRecordsResponse
     */
    public function batchRemoveFollowRecordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->instanceIds)) {
            $body['instanceIds'] = $request->instanceIds;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
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
            'action'      => 'BatchRemoveFollowRecords',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/followRecords/batchRemove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchRemoveFollowRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量删除跟进记录
     *  *
     * @param BatchRemoveFollowRecordsRequest $request BatchRemoveFollowRecordsRequest
     *
     * @return BatchRemoveFollowRecordsResponse BatchRemoveFollowRecordsResponse
     */
    public function batchRemoveFollowRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchRemoveFollowRecordsHeaders([]);

        return $this->batchRemoveFollowRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务窗消息群发
     *  *
     * @param BatchSendOfficialAccountOTOMessageRequest $request BatchSendOfficialAccountOTOMessageRequest
     * @param BatchSendOfficialAccountOTOMessageHeaders $headers BatchSendOfficialAccountOTOMessageHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchSendOfficialAccountOTOMessageResponse BatchSendOfficialAccountOTOMessageResponse
     */
    public function batchSendOfficialAccountOTOMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accountId)) {
            $body['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->detail)) {
            $body['detail'] = $request->detail;
        }
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
            'action'      => 'BatchSendOfficialAccountOTOMessage',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/officialAccounts/oToMessages/batchSend',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchSendOfficialAccountOTOMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务窗消息群发
     *  *
     * @param BatchSendOfficialAccountOTOMessageRequest $request BatchSendOfficialAccountOTOMessageRequest
     *
     * @return BatchSendOfficialAccountOTOMessageResponse BatchSendOfficialAccountOTOMessageResponse
     */
    public function batchSendOfficialAccountOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchSendOfficialAccountOTOMessageHeaders([]);

        return $this->batchSendOfficialAccountOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量修改联系人
     *  *
     * @param BatchUpdateContactsRequest $request BatchUpdateContactsRequest
     * @param BatchUpdateContactsHeaders $headers BatchUpdateContactsHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchUpdateContactsResponse BatchUpdateContactsResponse
     */
    public function batchUpdateContactsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->relationList)) {
            $body['relationList'] = $request->relationList;
        }
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
            'action'      => 'BatchUpdateContacts',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/contacts/batch',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchUpdateContactsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量修改联系人
     *  *
     * @param BatchUpdateContactsRequest $request BatchUpdateContactsRequest
     *
     * @return BatchUpdateContactsResponse BatchUpdateContactsResponse
     */
    public function batchUpdateContacts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateContactsHeaders([]);

        return $this->batchUpdateContactsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量修改跟进记录
     *  *
     * @param BatchUpdateFollowRecordsRequest $request BatchUpdateFollowRecordsRequest
     * @param BatchUpdateFollowRecordsHeaders $headers BatchUpdateFollowRecordsHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchUpdateFollowRecordsResponse BatchUpdateFollowRecordsResponse
     */
    public function batchUpdateFollowRecordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->instanceList)) {
            $body['instanceList'] = $request->instanceList;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
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
            'action'      => 'BatchUpdateFollowRecords',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/followRecords/batch',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchUpdateFollowRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量修改跟进记录
     *  *
     * @param BatchUpdateFollowRecordsRequest $request BatchUpdateFollowRecordsRequest
     *
     * @return BatchUpdateFollowRecordsResponse BatchUpdateFollowRecordsResponse
     */
    public function batchUpdateFollowRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateFollowRecordsHeaders([]);

        return $this->batchUpdateFollowRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量修改关系数据
     *  *
     * @param BatchUpdateRelationDatasRequest $request BatchUpdateRelationDatasRequest
     * @param BatchUpdateRelationDatasHeaders $headers BatchUpdateRelationDatasHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchUpdateRelationDatasResponse BatchUpdateRelationDatasResponse
     */
    public function batchUpdateRelationDatasWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->relationList)) {
            $body['relationList'] = $request->relationList;
        }
        if (!Utils::isUnset($request->relationType)) {
            $body['relationType'] = $request->relationType;
        }
        if (!Utils::isUnset($request->skipDuplicateCheck)) {
            $body['skipDuplicateCheck'] = $request->skipDuplicateCheck;
        }
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
            'action'      => 'BatchUpdateRelationDatas',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/relationDatas/batch',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchUpdateRelationDatasResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量修改关系数据
     *  *
     * @param BatchUpdateRelationDatasRequest $request BatchUpdateRelationDatasRequest
     *
     * @return BatchUpdateRelationDatasResponse BatchUpdateRelationDatasResponse
     */
    public function batchUpdateRelationDatas($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateRelationDatasHeaders([]);

        return $this->batchUpdateRelationDatasWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 核销权益库存
     *  *
     * @param ConsumeBenefitInventoryRequest $request ConsumeBenefitInventoryRequest
     * @param ConsumeBenefitInventoryHeaders $headers ConsumeBenefitInventoryHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return ConsumeBenefitInventoryResponse ConsumeBenefitInventoryResponse
     */
    public function consumeBenefitInventoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->benefitCode)) {
            $body['benefitCode'] = $request->benefitCode;
        }
        if (!Utils::isUnset($request->bizRequestId)) {
            $body['bizRequestId'] = $request->bizRequestId;
        }
        if (!Utils::isUnset($request->consumeQuota)) {
            $body['consumeQuota'] = $request->consumeQuota;
        }
        if (!Utils::isUnset($request->optUserId)) {
            $body['optUserId'] = $request->optUserId;
        }
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
            'action'      => 'ConsumeBenefitInventory',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/benefitInventories/consume',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ConsumeBenefitInventoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 核销权益库存
     *  *
     * @param ConsumeBenefitInventoryRequest $request ConsumeBenefitInventoryRequest
     *
     * @return ConsumeBenefitInventoryResponse ConsumeBenefitInventoryResponse
     */
    public function consumeBenefitInventory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConsumeBenefitInventoryHeaders([]);

        return $this->consumeBenefitInventoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary CRM客户通讯录数据写入接口，支持客户&联系人数据合并写入
     *  *
     * @param CreateCustomerRequest $request CreateCustomerRequest
     * @param CreateCustomerHeaders $headers CreateCustomerHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateCustomerResponse CreateCustomerResponse
     */
    public function createCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->contacts)) {
            $body['contacts'] = $request->contacts;
        }
        if (!Utils::isUnset($request->creatorUserId)) {
            $body['creatorUserId'] = $request->creatorUserId;
        }
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->extendData)) {
            $body['extendData'] = $request->extendData;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->objectType)) {
            $body['objectType'] = $request->objectType;
        }
        if (!Utils::isUnset($request->permission)) {
            $body['permission'] = $request->permission;
        }
        if (!Utils::isUnset($request->saveOption)) {
            $body['saveOption'] = $request->saveOption;
        }
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
            'action'      => 'CreateCustomer',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/customers',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateCustomerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary CRM客户通讯录数据写入接口，支持客户&联系人数据合并写入
     *  *
     * @param CreateCustomerRequest $request CreateCustomerRequest
     *
     * @return CreateCustomerResponse CreateCustomerResponse
     */
    public function createCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCustomerHeaders([]);

        return $this->createCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建客户群
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
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->memberUserIds)) {
            $body['memberUserIds'] = $request->memberUserIds;
        }
        if (!Utils::isUnset($request->ownerUserId)) {
            $body['ownerUserId'] = $request->ownerUserId;
        }
        if (!Utils::isUnset($request->relationType)) {
            $body['relationType'] = $request->relationType;
        }
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
            'action'      => 'CreateGroup',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/groups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建客户群
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
     * @summary 创建群组
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
        if (!Utils::isUnset($request->creatorUserId)) {
            $body['creatorUserId'] = $request->creatorUserId;
        }
        if (!Utils::isUnset($request->managerUserIds)) {
            $body['managerUserIds'] = $request->managerUserIds;
        }
        if (!Utils::isUnset($request->memberQuota)) {
            $body['memberQuota'] = $request->memberQuota;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->notice)) {
            $body['notice'] = $request->notice;
        }
        if (!Utils::isUnset($request->noticeToped)) {
            $body['noticeToped'] = $request->noticeToped;
        }
        if (!Utils::isUnset($request->ownerUserId)) {
            $body['ownerUserId'] = $request->ownerUserId;
        }
        if (!Utils::isUnset($request->relationType)) {
            $body['relationType'] = $request->relationType;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->welcome)) {
            $body['welcome'] = $request->welcome;
        }
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
            'action'      => 'CreateGroupSet',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/groupSets',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateGroupSetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建群组
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
     * @summary 创建关系模型表结构
     *  *
     * @param CreateRelationMetaRequest $request CreateRelationMetaRequest
     * @param CreateRelationMetaHeaders $headers CreateRelationMetaHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateRelationMetaResponse CreateRelationMetaResponse
     */
    public function createRelationMetaWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->relationMetaDTO)) {
            $body['relationMetaDTO'] = $request->relationMetaDTO;
        }
        if (!Utils::isUnset($request->tenant)) {
            $body['tenant'] = $request->tenant;
        }
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
            'action'      => 'CreateRelationMeta',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/relations/metas/create',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateRelationMetaResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建关系模型表结构
     *  *
     * @param CreateRelationMetaRequest $request CreateRelationMetaRequest
     *
     * @return CreateRelationMetaResponse CreateRelationMetaResponse
     */
    public function createRelationMeta($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateRelationMetaHeaders([]);

        return $this->createRelationMetaWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除CRM自定义对象数据
     *  *
     * @param string                           $instanceId
     * @param DeleteCrmCustomObjectDataRequest $request    DeleteCrmCustomObjectDataRequest
     * @param DeleteCrmCustomObjectDataHeaders $headers    DeleteCrmCustomObjectDataHeaders
     * @param RuntimeOptions                   $runtime    runtime options for this request RuntimeOptions
     *
     * @return DeleteCrmCustomObjectDataResponse DeleteCrmCustomObjectDataResponse
     */
    public function deleteCrmCustomObjectDataWithOptions($instanceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->formCode)) {
            $query['formCode'] = $request->formCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeleteCrmCustomObjectData',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/customObjectDatas/instances/' . $instanceId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteCrmCustomObjectDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除CRM自定义对象数据
     *  *
     * @param string                           $instanceId
     * @param DeleteCrmCustomObjectDataRequest $request    DeleteCrmCustomObjectDataRequest
     *
     * @return DeleteCrmCustomObjectDataResponse DeleteCrmCustomObjectDataResponse
     */
    public function deleteCrmCustomObjectData($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteCrmCustomObjectDataHeaders([]);

        return $this->deleteCrmCustomObjectDataWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @summary crm自定义表单数据删除接口
     *  *
     * @param string                       $instanceId
     * @param DeleteCrmFormInstanceRequest $request    DeleteCrmFormInstanceRequest
     * @param DeleteCrmFormInstanceHeaders $headers    DeleteCrmFormInstanceHeaders
     * @param RuntimeOptions               $runtime    runtime options for this request RuntimeOptions
     *
     * @return DeleteCrmFormInstanceResponse DeleteCrmFormInstanceResponse
     */
    public function deleteCrmFormInstanceWithOptions($instanceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->currentOperatorUserId)) {
            $query['currentOperatorUserId'] = $request->currentOperatorUserId;
        }
        if (!Utils::isUnset($request->name)) {
            $query['name'] = $request->name;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeleteCrmFormInstance',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/formInstances/' . $instanceId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteCrmFormInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary crm自定义表单数据删除接口
     *  *
     * @param string                       $instanceId
     * @param DeleteCrmFormInstanceRequest $request    DeleteCrmFormInstanceRequest
     *
     * @return DeleteCrmFormInstanceResponse DeleteCrmFormInstanceResponse
     */
    public function deleteCrmFormInstance($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteCrmFormInstanceHeaders([]);

        return $this->deleteCrmFormInstanceWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除crm个人客户（或企业客户）
     *  *
     * @param string                           $dataId
     * @param DeleteCrmPersonalCustomerRequest $request DeleteCrmPersonalCustomerRequest
     * @param DeleteCrmPersonalCustomerHeaders $headers DeleteCrmPersonalCustomerHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteCrmPersonalCustomerResponse DeleteCrmPersonalCustomerResponse
     */
    public function deleteCrmPersonalCustomerWithOptions($dataId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->currentOperatorUserId)) {
            $query['currentOperatorUserId'] = $request->currentOperatorUserId;
        }
        if (!Utils::isUnset($request->relationType)) {
            $query['relationType'] = $request->relationType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeleteCrmPersonalCustomer',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/personalCustomers/' . $dataId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteCrmPersonalCustomerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除crm个人客户（或企业客户）
     *  *
     * @param string                           $dataId
     * @param DeleteCrmPersonalCustomerRequest $request DeleteCrmPersonalCustomerRequest
     *
     * @return DeleteCrmPersonalCustomerResponse DeleteCrmPersonalCustomerResponse
     */
    public function deleteCrmPersonalCustomer($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteCrmPersonalCustomerHeaders([]);

        return $this->deleteCrmPersonalCustomerWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除线索
     *  *
     * @param DeleteLeadsRequest $request DeleteLeadsRequest
     * @param DeleteLeadsHeaders $headers DeleteLeadsHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteLeadsResponse DeleteLeadsResponse
     */
    public function deleteLeadsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->outLeadsIds)) {
            $body['outLeadsIds'] = $request->outLeadsIds;
        }
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
            'action'      => 'DeleteLeads',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/leads/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteLeadsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除线索
     *  *
     * @param DeleteLeadsRequest $request DeleteLeadsRequest
     *
     * @return DeleteLeadsResponse DeleteLeadsResponse
     */
    public function deleteLeads($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteLeadsHeaders([]);

        return $this->deleteLeadsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 关系模型表结构删除字段
     *  *
     * @param DeleteRelationMetaFieldRequest $request DeleteRelationMetaFieldRequest
     * @param DeleteRelationMetaFieldHeaders $headers DeleteRelationMetaFieldHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteRelationMetaFieldResponse DeleteRelationMetaFieldResponse
     */
    public function deleteRelationMetaFieldWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fieldIdList)) {
            $body['fieldIdList'] = $request->fieldIdList;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->relationType)) {
            $body['relationType'] = $request->relationType;
        }
        if (!Utils::isUnset($request->tenant)) {
            $body['tenant'] = $request->tenant;
        }
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
            'action'      => 'DeleteRelationMetaField',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/relations/metas/fields/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteRelationMetaFieldResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 关系模型表结构删除字段
     *  *
     * @param DeleteRelationMetaFieldRequest $request DeleteRelationMetaFieldRequest
     *
     * @return DeleteRelationMetaFieldResponse DeleteRelationMetaFieldResponse
     */
    public function deleteRelationMetaField($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRelationMetaFieldHeaders([]);

        return $this->deleteRelationMetaFieldWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取CRM客户对象的元数据描述
     *  *
     * @param DescribeCrmPersonalCustomerObjectMetaRequest $request DescribeCrmPersonalCustomerObjectMetaRequest
     * @param DescribeCrmPersonalCustomerObjectMetaHeaders $headers DescribeCrmPersonalCustomerObjectMetaHeaders
     * @param RuntimeOptions                               $runtime runtime options for this request RuntimeOptions
     *
     * @return DescribeCrmPersonalCustomerObjectMetaResponse DescribeCrmPersonalCustomerObjectMetaResponse
     */
    public function describeCrmPersonalCustomerObjectMetaWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->relationType)) {
            $query['relationType'] = $request->relationType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DescribeCrmPersonalCustomerObjectMeta',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/personalCustomers/objectMeta',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DescribeCrmPersonalCustomerObjectMetaResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取CRM客户对象的元数据描述
     *  *
     * @param DescribeCrmPersonalCustomerObjectMetaRequest $request DescribeCrmPersonalCustomerObjectMetaRequest
     *
     * @return DescribeCrmPersonalCustomerObjectMetaResponse DescribeCrmPersonalCustomerObjectMetaResponse
     */
    public function describeCrmPersonalCustomerObjectMeta($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DescribeCrmPersonalCustomerObjectMetaHeaders([]);

        return $this->describeCrmPersonalCustomerObjectMetaWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询模型表结构
     *  *
     * @param DescribeMetaModelRequest $request DescribeMetaModelRequest
     * @param DescribeMetaModelHeaders $headers DescribeMetaModelHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return DescribeMetaModelResponse DescribeMetaModelResponse
     */
    public function describeMetaModelWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizTypes)) {
            $body['bizTypes'] = $request->bizTypes;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->tenant)) {
            $body['tenant'] = $request->tenant;
        }
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
            'action'      => 'DescribeMetaModel',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/metas/models/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DescribeMetaModelResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询模型表结构
     *  *
     * @param DescribeMetaModelRequest $request DescribeMetaModelRequest
     *
     * @return DescribeMetaModelResponse DescribeMetaModelResponse
     */
    public function describeMetaModel($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DescribeMetaModelHeaders([]);

        return $this->describeMetaModelWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询关系模型表结构
     *  *
     * @param DescribeRelationMetaRequest $request DescribeRelationMetaRequest
     * @param DescribeRelationMetaHeaders $headers DescribeRelationMetaHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return DescribeRelationMetaResponse DescribeRelationMetaResponse
     */
    public function describeRelationMetaWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->relationTypes)) {
            $body['relationTypes'] = $request->relationTypes;
        }
        if (!Utils::isUnset($request->tenant)) {
            $body['tenant'] = $request->tenant;
        }
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
            'action'      => 'DescribeRelationMeta',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/relations/metas/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DescribeRelationMetaResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询关系模型表结构
     *  *
     * @param DescribeRelationMetaRequest $request DescribeRelationMetaRequest
     *
     * @return DescribeRelationMetaResponse DescribeRelationMetaResponse
     */
    public function describeRelationMeta($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DescribeRelationMetaHeaders([]);

        return $this->describeRelationMetaWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页获取关联对象的跟进记录列表
     *  *
     * @param FindTargetRelatedFollowRecordsRequest $request FindTargetRelatedFollowRecordsRequest
     * @param FindTargetRelatedFollowRecordsHeaders $headers FindTargetRelatedFollowRecordsHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return FindTargetRelatedFollowRecordsResponse FindTargetRelatedFollowRecordsResponse
     */
    public function findTargetRelatedFollowRecordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->followTargetDataId)) {
            $body['followTargetDataId'] = $request->followTargetDataId;
        }
        if (!Utils::isUnset($request->followTargetType)) {
            $body['followTargetType'] = $request->followTargetType;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
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
            'action'      => 'FindTargetRelatedFollowRecords',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/targetFollowRecords/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return FindTargetRelatedFollowRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页获取关联对象的跟进记录列表
     *  *
     * @param FindTargetRelatedFollowRecordsRequest $request FindTargetRelatedFollowRecordsRequest
     *
     * @return FindTargetRelatedFollowRecordsResponse FindTargetRelatedFollowRecordsResponse
     */
    public function findTargetRelatedFollowRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FindTargetRelatedFollowRecordsHeaders([]);

        return $this->findTargetRelatedFollowRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页获取所有客户的掉保时间数据
     *  *
     * @param GetAllCustomerRecyclesRequest $request GetAllCustomerRecyclesRequest
     * @param GetAllCustomerRecyclesHeaders $headers GetAllCustomerRecyclesHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAllCustomerRecyclesResponse GetAllCustomerRecyclesResponse
     */
    public function getAllCustomerRecyclesWithOptions($request, $headers, $runtime)
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
            'action'      => 'GetAllCustomerRecycles',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/customerRecycles',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAllCustomerRecyclesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页获取所有客户的掉保时间数据
     *  *
     * @param GetAllCustomerRecyclesRequest $request GetAllCustomerRecyclesRequest
     *
     * @return GetAllCustomerRecyclesResponse GetAllCustomerRecyclesResponse
     */
    public function getAllCustomerRecycles($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllCustomerRecyclesHeaders([]);

        return $this->getAllCustomerRecyclesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据指定条件查询联系人数据
     *  *
     * @param GetContactsRequest $request GetContactsRequest
     * @param GetContactsHeaders $headers GetContactsHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetContactsResponse GetContactsResponse
     */
    public function getContactsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->currentOperatorUserId)) {
            $body['currentOperatorUserId'] = $request->currentOperatorUserId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->objectType)) {
            $body['objectType'] = $request->objectType;
        }
        if (!Utils::isUnset($request->providerCorpId)) {
            $body['providerCorpId'] = $request->providerCorpId;
        }
        if (!Utils::isUnset($request->queryDsl)) {
            $body['queryDsl'] = $request->queryDsl;
        }
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
            'action'      => 'GetContacts',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/customObjects/contacts/datas/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetContactsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据指定条件查询联系人数据
     *  *
     * @param GetContactsRequest $request GetContactsRequest
     *
     * @return GetContactsResponse GetContactsResponse
     */
    public function getContacts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetContactsHeaders([]);

        return $this->getContactsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取单个客户群
     *  *
     * @param string                 $openConversationId
     * @param GetCrmGroupChatHeaders $headers            GetCrmGroupChatHeaders
     * @param RuntimeOptions         $runtime            runtime options for this request RuntimeOptions
     *
     * @return GetCrmGroupChatResponse GetCrmGroupChatResponse
     */
    public function getCrmGroupChatWithOptions($openConversationId, $headers, $runtime)
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
            'action'      => 'GetCrmGroupChat',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/crmGroupChats/' . $openConversationId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCrmGroupChatResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取单个客户群
     *  *
     * @param string $openConversationId
     *
     * @return GetCrmGroupChatResponse GetCrmGroupChatResponse
     */
    public function getCrmGroupChat($openConversationId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCrmGroupChatHeaders([]);

        return $this->getCrmGroupChatWithOptions($openConversationId, $headers, $runtime);
    }

    /**
     * @summary 批量获取多个客户群
     *  *
     * @param GetCrmGroupChatMultiRequest $request GetCrmGroupChatMultiRequest
     * @param GetCrmGroupChatMultiHeaders $headers GetCrmGroupChatMultiHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCrmGroupChatMultiResponse GetCrmGroupChatMultiResponse
     */
    public function getCrmGroupChatMultiWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationIds)) {
            $body['openConversationIds'] = $request->openConversationIds;
        }
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
            'action'      => 'GetCrmGroupChatMulti',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/crmGroupChats/batchQuery',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCrmGroupChatMultiResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量获取多个客户群
     *  *
     * @param GetCrmGroupChatMultiRequest $request GetCrmGroupChatMultiRequest
     *
     * @return GetCrmGroupChatMultiResponse GetCrmGroupChatMultiResponse
     */
    public function getCrmGroupChatMulti($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCrmGroupChatMultiHeaders([]);

        return $this->getCrmGroupChatMultiWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取单个客户群
     *  *
     * @param GetCrmGroupChatSingleRequest $request GetCrmGroupChatSingleRequest
     * @param GetCrmGroupChatSingleHeaders $headers GetCrmGroupChatSingleHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCrmGroupChatSingleResponse GetCrmGroupChatSingleResponse
     */
    public function getCrmGroupChatSingleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $query['openConversationId'] = $request->openConversationId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetCrmGroupChatSingle',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/crmGroupChats/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCrmGroupChatSingleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取单个客户群
     *  *
     * @param GetCrmGroupChatSingleRequest $request GetCrmGroupChatSingleRequest
     *
     * @return GetCrmGroupChatSingleResponse GetCrmGroupChatSingleResponse
     */
    public function getCrmGroupChatSingle($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCrmGroupChatSingleHeaders([]);

        return $this->getCrmGroupChatSingleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取CRM表单权限配置
     *  *
     * @param GetCrmRolePermissionRequest $request GetCrmRolePermissionRequest
     * @param GetCrmRolePermissionHeaders $headers GetCrmRolePermissionHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCrmRolePermissionResponse GetCrmRolePermissionResponse
     */
    public function getCrmRolePermissionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizType)) {
            $query['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->resourceId)) {
            $query['resourceId'] = $request->resourceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetCrmRolePermission',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/permissions',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCrmRolePermissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取CRM表单权限配置
     *  *
     * @param GetCrmRolePermissionRequest $request GetCrmRolePermissionRequest
     *
     * @return GetCrmRolePermissionResponse GetCrmRolePermissionResponse
     */
    public function getCrmRolePermission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCrmRolePermissionHeaders([]);

        return $this->getCrmRolePermissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页获取某个客户的客户动态
     *  *
     * @param GetCustomerTracksByRelationIdRequest $request GetCustomerTracksByRelationIdRequest
     * @param GetCustomerTracksByRelationIdHeaders $headers GetCustomerTracksByRelationIdHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCustomerTracksByRelationIdResponse GetCustomerTracksByRelationIdResponse
     */
    public function getCustomerTracksByRelationIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->relationId)) {
            $query['relationId'] = $request->relationId;
        }
        if (!Utils::isUnset($request->typeGroup)) {
            $query['typeGroup'] = $request->typeGroup;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetCustomerTracksByRelationId',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/customerTracks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCustomerTracksByRelationIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页获取某个客户的客户动态
     *  *
     * @param GetCustomerTracksByRelationIdRequest $request GetCustomerTracksByRelationIdRequest
     *
     * @return GetCustomerTracksByRelationIdResponse GetCustomerTracksByRelationIdResponse
     */
    public function getCustomerTracksByRelationId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCustomerTracksByRelationIdHeaders([]);

        return $this->getCustomerTracksByRelationIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询群组
     *  *
     * @param GetGroupSetRequest $request GetGroupSetRequest
     * @param GetGroupSetHeaders $headers GetGroupSetHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetGroupSetResponse GetGroupSetResponse
     */
    public function getGroupSetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openGroupSetId)) {
            $query['openGroupSetId'] = $request->openGroupSetId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetGroupSet',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/groupSets',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetGroupSetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询群组
     *  *
     * @param GetGroupSetRequest $request GetGroupSetRequest
     *
     * @return GetGroupSetResponse GetGroupSetResponse
     */
    public function getGroupSet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetGroupSetHeaders([]);

        return $this->getGroupSetWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取内购商品信息
     *  *
     * @param GetInAppPurchaseGoodsRequest $request GetInAppPurchaseGoodsRequest
     * @param GetInAppPurchaseGoodsHeaders $headers GetInAppPurchaseGoodsHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetInAppPurchaseGoodsResponse GetInAppPurchaseGoodsResponse
     */
    public function getInAppPurchaseGoodsWithOptions($request, $headers, $runtime)
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
            'action'      => 'GetInAppPurchaseGoods',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/inAppPurchaseGoods/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetInAppPurchaseGoodsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取内购商品信息
     *  *
     * @param GetInAppPurchaseGoodsRequest $request GetInAppPurchaseGoodsRequest
     *
     * @return GetInAppPurchaseGoodsResponse GetInAppPurchaseGoodsResponse
     */
    public function getInAppPurchaseGoods($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInAppPurchaseGoodsHeaders([]);

        return $this->getInAppPurchaseGoodsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取自定义导航挂靠节点结构
     *  *
     * @param GetNavigationCatalogRequest $request GetNavigationCatalogRequest
     * @param GetNavigationCatalogHeaders $headers GetNavigationCatalogHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetNavigationCatalogResponse GetNavigationCatalogResponse
     */
    public function getNavigationCatalogWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizTraceId)) {
            $query['bizTraceId'] = $request->bizTraceId;
        }
        if (!Utils::isUnset($request->module)) {
            $query['module'] = $request->module;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $query['operatorUserId'] = $request->operatorUserId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetNavigationCatalog',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/navigations/catalogs',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetNavigationCatalogResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取自定义导航挂靠节点结构
     *  *
     * @param GetNavigationCatalogRequest $request GetNavigationCatalogRequest
     *
     * @return GetNavigationCatalogResponse GetNavigationCatalogResponse
     */
    public function getNavigationCatalog($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetNavigationCatalogHeaders([]);

        return $this->getNavigationCatalogWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据指定条件查询自定义对象数据
     *  *
     * @param GetObjectDataRequest $request GetObjectDataRequest
     * @param GetObjectDataHeaders $headers GetObjectDataHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetObjectDataResponse GetObjectDataResponse
     */
    public function getObjectDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->currentOperatorUserId)) {
            $body['currentOperatorUserId'] = $request->currentOperatorUserId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->queryDsl)) {
            $body['queryDsl'] = $request->queryDsl;
        }
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
            'action'      => 'GetObjectData',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/customObjects/datas/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetObjectDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据指定条件查询自定义对象数据
     *  *
     * @param GetObjectDataRequest $request GetObjectDataRequest
     *
     * @return GetObjectDataResponse GetObjectDataResponse
     */
    public function getObjectData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetObjectDataHeaders([]);

        return $this->getObjectDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取关注服务窗的联系人信息，包括手机号、主企业等字段，调用前先进行用户授权
     *  *
     * @param string                               $userId
     * @param GetOfficialAccountContactInfoHeaders $headers GetOfficialAccountContactInfoHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOfficialAccountContactInfoResponse GetOfficialAccountContactInfoResponse
     */
    public function getOfficialAccountContactInfoWithOptions($userId, $headers, $runtime)
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
            'action'      => 'GetOfficialAccountContactInfo',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/officialAccounts/contacts/' . $userId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOfficialAccountContactInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取关注服务窗的联系人信息，包括手机号、主企业等字段，调用前先进行用户授权
     *  *
     * @param string $userId
     *
     * @return GetOfficialAccountContactInfoResponse GetOfficialAccountContactInfoResponse
     */
    public function getOfficialAccountContactInfo($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOfficialAccountContactInfoHeaders([]);

        return $this->getOfficialAccountContactInfoWithOptions($userId, $headers, $runtime);
    }

    /**
     * @summary 分页获取服务窗联系人信息
     *  *
     * @param GetOfficialAccountContactsRequest $request GetOfficialAccountContactsRequest
     * @param GetOfficialAccountContactsHeaders $headers GetOfficialAccountContactsHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOfficialAccountContactsResponse GetOfficialAccountContactsResponse
     */
    public function getOfficialAccountContactsWithOptions($request, $headers, $runtime)
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
            'action'      => 'GetOfficialAccountContacts',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/officialAccounts/contacts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOfficialAccountContactsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页获取服务窗联系人信息
     *  *
     * @param GetOfficialAccountContactsRequest $request GetOfficialAccountContactsRequest
     *
     * @return GetOfficialAccountContactsResponse GetOfficialAccountContactsResponse
     */
    public function getOfficialAccountContacts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOfficialAccountContactsHeaders([]);

        return $this->getOfficialAccountContactsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取服务窗消息发送的结果
     *  *
     * @param GetOfficialAccountOTOMessageResultRequest $request GetOfficialAccountOTOMessageResultRequest
     * @param GetOfficialAccountOTOMessageResultHeaders $headers GetOfficialAccountOTOMessageResultHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOfficialAccountOTOMessageResultResponse GetOfficialAccountOTOMessageResultResponse
     */
    public function getOfficialAccountOTOMessageResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountId)) {
            $query['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->openPushId)) {
            $query['openPushId'] = $request->openPushId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetOfficialAccountOTOMessageResult',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/officialAccounts/oToMessages/sendResults',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOfficialAccountOTOMessageResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取服务窗消息发送的结果
     *  *
     * @param GetOfficialAccountOTOMessageResultRequest $request GetOfficialAccountOTOMessageResultRequest
     *
     * @return GetOfficialAccountOTOMessageResultResponse GetOfficialAccountOTOMessageResultResponse
     */
    public function getOfficialAccountOTOMessageResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOfficialAccountOTOMessageResultHeaders([]);

        return $this->getOfficialAccountOTOMessageResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取关系数据查重规则
     *  *
     * @param GetRelationUkSettingRequest $request GetRelationUkSettingRequest
     * @param GetRelationUkSettingHeaders $headers GetRelationUkSettingHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetRelationUkSettingResponse GetRelationUkSettingResponse
     */
    public function getRelationUkSettingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->relationType)) {
            $query['relationType'] = $request->relationType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetRelationUkSetting',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/relationUkSettings',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetRelationUkSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取关系数据查重规则
     *  *
     * @param GetRelationUkSettingRequest $request GetRelationUkSettingRequest
     *
     * @return GetRelationUkSettingResponse GetRelationUkSettingResponse
     */
    public function getRelationUkSetting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRelationUkSettingHeaders([]);

        return $this->getRelationUkSettingWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 加入群组
     *  *
     * @param JoinGroupSetRequest $request JoinGroupSetRequest
     * @param JoinGroupSetHeaders $headers JoinGroupSetHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return JoinGroupSetResponse JoinGroupSetResponse
     */
    public function joinGroupSetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizDataList)) {
            $body['bizDataList'] = $request->bizDataList;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            $body['openGroupSetId'] = $request->openGroupSetId;
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
            'action'      => 'JoinGroupSet',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/groupSets/join',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return JoinGroupSetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 加入群组
     *  *
     * @param JoinGroupSetRequest $request JoinGroupSetRequest
     *
     * @return JoinGroupSetResponse JoinGroupSetResponse
     */
    public function joinGroupSet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new JoinGroupSetHeaders([]);

        return $this->joinGroupSetWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary  批量查询可用权益
     *  *
     * @param ListAvailableBenefitRequest $request ListAvailableBenefitRequest
     * @param ListAvailableBenefitHeaders $headers ListAvailableBenefitHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return ListAvailableBenefitResponse ListAvailableBenefitResponse
     */
    public function listAvailableBenefitWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->benefitCodeList)) {
            $body['benefitCodeList'] = $request->benefitCodeList;
        }
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
            'action'      => 'ListAvailableBenefit',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/benefits/lists/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListAvailableBenefitResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary  批量查询可用权益
     *  *
     * @param ListAvailableBenefitRequest $request ListAvailableBenefitRequest
     *
     * @return ListAvailableBenefitResponse ListAvailableBenefitResponse
     */
    public function listAvailableBenefit($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAvailableBenefitHeaders([]);

        return $this->listAvailableBenefitWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询license
     *  *
     * @param ListBenefitLicenseRequest $request ListBenefitLicenseRequest
     * @param ListBenefitLicenseHeaders $headers ListBenefitLicenseHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return ListBenefitLicenseResponse ListBenefitLicenseResponse
     */
    public function listBenefitLicenseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->domains)) {
            $body['domains'] = $request->domains;
        }
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
            'action'      => 'ListBenefitLicense',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/benefitLicenses/lists/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListBenefitLicenseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询license
     *  *
     * @param ListBenefitLicenseRequest $request ListBenefitLicenseRequest
     *
     * @return ListBenefitLicenseResponse ListBenefitLicenseResponse
     */
    public function listBenefitLicense($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListBenefitLicenseHeaders([]);

        return $this->listBenefitLicenseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取线索标签列表
     *  *
     * @param ListClueTagHeaders $headers ListClueTagHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return ListClueTagResponse ListClueTagResponse
     */
    public function listClueTagWithOptions($headers, $runtime)
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
            'action'      => 'ListClueTag',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/clues/tags',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListClueTagResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取线索标签列表
     *  *
     * @return ListClueTagResponse ListClueTagResponse
     */
    public function listClueTag()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListClueTagHeaders([]);

        return $this->listClueTagWithOptions($headers, $runtime);
    }

    /**
     * @summary 批量获取crm个人客户
     *  *
     * @param ListCrmPersonalCustomersRequest $request ListCrmPersonalCustomersRequest
     * @param ListCrmPersonalCustomersHeaders $headers ListCrmPersonalCustomersHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return ListCrmPersonalCustomersResponse ListCrmPersonalCustomersResponse
     */
    public function listCrmPersonalCustomersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->currentOperatorUserId)) {
            $query['currentOperatorUserId'] = $request->currentOperatorUserId;
        }
        if (!Utils::isUnset($request->relationType)) {
            $query['relationType'] = $request->relationType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => $request->body,
        ]);
        $params = new Params([
            'action'      => 'ListCrmPersonalCustomers',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/personalCustomers/batchQuery',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListCrmPersonalCustomersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量获取crm个人客户
     *  *
     * @param ListCrmPersonalCustomersRequest $request ListCrmPersonalCustomersRequest
     *
     * @return ListCrmPersonalCustomersResponse ListCrmPersonalCustomersResponse
     */
    public function listCrmPersonalCustomers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListCrmPersonalCustomersHeaders([]);

        return $this->listCrmPersonalCustomersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询群组列表
     *  *
     * @param ListGroupSetRequest $request ListGroupSetRequest
     * @param ListGroupSetHeaders $headers ListGroupSetHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return ListGroupSetResponse ListGroupSetResponse
     */
    public function listGroupSetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->queryDsl)) {
            $query['queryDsl'] = $request->queryDsl;
        }
        if (!Utils::isUnset($request->relationType)) {
            $query['relationType'] = $request->relationType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListGroupSet',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/groupSets/lists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListGroupSetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询群组列表
     *  *
     * @param ListGroupSetRequest $request ListGroupSetRequest
     *
     * @return ListGroupSetResponse ListGroupSetResponse
     */
    public function listGroupSet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListGroupSetHeaders([]);

        return $this->listGroupSetWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 覆盖更新客户数据权限
     *  *
     * @param OverrideUpdateCustomerDataAuthRequest $request OverrideUpdateCustomerDataAuthRequest
     * @param OverrideUpdateCustomerDataAuthHeaders $headers OverrideUpdateCustomerDataAuthHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return OverrideUpdateCustomerDataAuthResponse OverrideUpdateCustomerDataAuthResponse
     */
    public function overrideUpdateCustomerDataAuthWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->customerIds)) {
            $body['customerIds'] = $request->customerIds;
        }
        if (!Utils::isUnset($request->dataAuthUserIds)) {
            $body['dataAuthUserIds'] = $request->dataAuthUserIds;
        }
        if (!Utils::isUnset($request->formCode)) {
            $body['formCode'] = $request->formCode;
        }
        if (!Utils::isUnset($request->operateUserId)) {
            $body['operateUserId'] = $request->operateUserId;
        }
        if (!Utils::isUnset($request->relationType)) {
            $body['relationType'] = $request->relationType;
        }
        if (!Utils::isUnset($request->roleType)) {
            $body['roleType'] = $request->roleType;
        }
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
            'action'      => 'OverrideUpdateCustomerDataAuth',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/customers/dataAuth/overrideUpdate',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return OverrideUpdateCustomerDataAuthResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 覆盖更新客户数据权限
     *  *
     * @param OverrideUpdateCustomerDataAuthRequest $request OverrideUpdateCustomerDataAuthRequest
     *
     * @return OverrideUpdateCustomerDataAuthResponse OverrideUpdateCustomerDataAuthResponse
     */
    public function overrideUpdateCustomerDataAuth($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OverrideUpdateCustomerDataAuthHeaders([]);

        return $this->overrideUpdateCustomerDataAuthWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页获取全量客户数据，根据不同的类型可以获取私海个人客户、企业客户，以及公海个人客户、企业客户，最多一次可获取100条数据
     *  *
     * @param QueryAllCustomerRequest $request QueryAllCustomerRequest
     * @param QueryAllCustomerHeaders $headers QueryAllCustomerHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAllCustomerResponse QueryAllCustomerResponse
     */
    public function queryAllCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->objectType)) {
            $body['objectType'] = $request->objectType;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
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
            'action'      => 'QueryAllCustomer',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/customerInstances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAllCustomerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页获取全量客户数据，根据不同的类型可以获取私海个人客户、企业客户，以及公海个人客户、企业客户，最多一次可获取100条数据
     *  *
     * @param QueryAllCustomerRequest $request QueryAllCustomerRequest
     *
     * @return QueryAllCustomerResponse QueryAllCustomerResponse
     */
    public function queryAllCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllCustomerHeaders([]);

        return $this->queryAllCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询企业客户动态
     *  *
     * @param QueryAllTracksRequest $request QueryAllTracksRequest
     * @param QueryAllTracksHeaders $headers QueryAllTracksHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAllTracksResponse QueryAllTracksResponse
     */
    public function queryAllTracksWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->order)) {
            $query['order'] = $request->order;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryAllTracks',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/customers/tracks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAllTracksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询企业客户动态
     *  *
     * @param QueryAllTracksRequest $request QueryAllTracksRequest
     *
     * @return QueryAllTracksResponse QueryAllTracksResponse
     */
    public function queryAllTracks($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllTracksHeaders([]);

        return $this->queryAllTracksWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询客户管理应用管理员
     *  *
     * @param QueryAppManagerRequest $request QueryAppManagerRequest
     * @param QueryAppManagerHeaders $headers QueryAppManagerHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAppManagerResponse QueryAppManagerResponse
     */
    public function queryAppManagerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
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
            'action'      => 'QueryAppManager',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/apps/managers/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAppManagerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询客户管理应用管理员
     *  *
     * @param QueryAppManagerRequest $request QueryAppManagerRequest
     *
     * @return QueryAppManagerResponse QueryAppManagerResponse
     */
    public function queryAppManager($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAppManagerHeaders([]);

        return $this->queryAppManagerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询权益库存
     *  *
     * @param QueryBenefitInventoryRequest $request QueryBenefitInventoryRequest
     * @param QueryBenefitInventoryHeaders $headers QueryBenefitInventoryHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryBenefitInventoryResponse QueryBenefitInventoryResponse
     */
    public function queryBenefitInventoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->benefitCode)) {
            $body['benefitCode'] = $request->benefitCode;
        }
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
            'action'      => 'QueryBenefitInventory',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/benefitInventories/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryBenefitInventoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询权益库存
     *  *
     * @param QueryBenefitInventoryRequest $request QueryBenefitInventoryRequest
     *
     * @return QueryBenefitInventoryResponse QueryBenefitInventoryResponse
     */
    public function queryBenefitInventory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBenefitInventoryHeaders([]);

        return $this->queryBenefitInventoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询线索跟进状态
     *  *
     * @param QueryClueFollowStatusRequest $request QueryClueFollowStatusRequest
     * @param QueryClueFollowStatusHeaders $headers QueryClueFollowStatusHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryClueFollowStatusResponse QueryClueFollowStatusResponse
     */
    public function queryClueFollowStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->clueId)) {
            $query['clueId'] = $request->clueId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryClueFollowStatus',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/clues/followStatuses',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryClueFollowStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询线索跟进状态
     *  *
     * @param QueryClueFollowStatusRequest $request QueryClueFollowStatusRequest
     *
     * @return QueryClueFollowStatusResponse QueryClueFollowStatusResponse
     */
    public function queryClueFollowStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryClueFollowStatusHeaders([]);

        return $this->queryClueFollowStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询客户群
     *  *
     * @param QueryCrmGroupChatsRequest $request QueryCrmGroupChatsRequest
     * @param QueryCrmGroupChatsHeaders $headers QueryCrmGroupChatsHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCrmGroupChatsResponse QueryCrmGroupChatsResponse
     */
    public function queryCrmGroupChatsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->queryDsl)) {
            $query['queryDsl'] = $request->queryDsl;
        }
        if (!Utils::isUnset($request->relationType)) {
            $query['relationType'] = $request->relationType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryCrmGroupChats',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/crmGroupChats',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCrmGroupChatsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询客户群
     *  *
     * @param QueryCrmGroupChatsRequest $request QueryCrmGroupChatsRequest
     *
     * @return QueryCrmGroupChatsResponse QueryCrmGroupChatsResponse
     */
    public function queryCrmGroupChats($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCrmGroupChatsHeaders([]);

        return $this->queryCrmGroupChatsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据指定查询条件批量获取客户数据
     *  *
     * @param QueryCrmPersonalCustomerRequest $request QueryCrmPersonalCustomerRequest
     * @param QueryCrmPersonalCustomerHeaders $headers QueryCrmPersonalCustomerHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCrmPersonalCustomerResponse QueryCrmPersonalCustomerResponse
     */
    public function queryCrmPersonalCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->currentOperatorUserId)) {
            $query['currentOperatorUserId'] = $request->currentOperatorUserId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->queryDsl)) {
            $query['queryDsl'] = $request->queryDsl;
        }
        if (!Utils::isUnset($request->relationType)) {
            $query['relationType'] = $request->relationType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryCrmPersonalCustomer',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/personalCustomers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCrmPersonalCustomerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据指定查询条件批量获取客户数据
     *  *
     * @param QueryCrmPersonalCustomerRequest $request QueryCrmPersonalCustomerRequest
     *
     * @return QueryCrmPersonalCustomerResponse QueryCrmPersonalCustomerResponse
     */
    public function queryCrmPersonalCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCrmPersonalCustomerHeaders([]);

        return $this->queryCrmPersonalCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询客户模板启用类型
     *  *
     * @param QueryCustomerBizTypeRequest $request QueryCustomerBizTypeRequest
     * @param QueryCustomerBizTypeHeaders $headers QueryCustomerBizTypeHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCustomerBizTypeResponse QueryCustomerBizTypeResponse
     */
    public function queryCustomerBizTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
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
            'action'      => 'QueryCustomerBizType',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/orgSettings/templates/customerBizTypes/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCustomerBizTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询客户模板启用类型
     *  *
     * @param QueryCustomerBizTypeRequest $request QueryCustomerBizTypeRequest
     *
     * @return QueryCustomerBizTypeResponse QueryCustomerBizTypeResponse
     */
    public function queryCustomerBizType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCustomerBizTypeHeaders([]);

        return $this->queryCustomerBizTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 营销服融合三方全局信息
     *  *
     * @param QueryGlobalInfoRequest $request QueryGlobalInfoRequest
     * @param QueryGlobalInfoHeaders $headers QueryGlobalInfoHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryGlobalInfoResponse QueryGlobalInfoResponse
     */
    public function queryGlobalInfoWithOptions($request, $headers, $runtime)
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
            'action'      => 'QueryGlobalInfo',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/globalInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryGlobalInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 营销服融合三方全局信息
     *  *
     * @param QueryGlobalInfoRequest $request QueryGlobalInfoRequest
     *
     * @return QueryGlobalInfoResponse QueryGlobalInfoResponse
     */
    public function queryGlobalInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGlobalInfoHeaders([]);

        return $this->queryGlobalInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户是否有应用管理员权限
     *  *
     * @param QueryHasAppPermissionRequest $request QueryHasAppPermissionRequest
     * @param QueryHasAppPermissionHeaders $headers QueryHasAppPermissionHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryHasAppPermissionResponse QueryHasAppPermissionResponse
     */
    public function queryHasAppPermissionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
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
            'action'      => 'QueryHasAppPermission',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/apps/adminPermissions/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryHasAppPermissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户是否有应用管理员权限
     *  *
     * @param QueryHasAppPermissionRequest $request QueryHasAppPermissionRequest
     *
     * @return QueryHasAppPermissionResponse QueryHasAppPermissionResponse
     */
    public function queryHasAppPermission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryHasAppPermissionHeaders([]);

        return $this->queryHasAppPermissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询服务窗用户基础信息
     *  *
     * @param QueryOfficialAccountUserBasicInfoRequest $request QueryOfficialAccountUserBasicInfoRequest
     * @param QueryOfficialAccountUserBasicInfoHeaders $headers QueryOfficialAccountUserBasicInfoHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOfficialAccountUserBasicInfoResponse QueryOfficialAccountUserBasicInfoResponse
     */
    public function queryOfficialAccountUserBasicInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bindingToken)) {
            $query['bindingToken'] = $request->bindingToken;
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
            'action'      => 'QueryOfficialAccountUserBasicInfo',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/officialAccounts/basics/users',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryOfficialAccountUserBasicInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询服务窗用户基础信息
     *  *
     * @param QueryOfficialAccountUserBasicInfoRequest $request QueryOfficialAccountUserBasicInfoRequest
     *
     * @return QueryOfficialAccountUserBasicInfoResponse QueryOfficialAccountUserBasicInfoResponse
     */
    public function queryOfficialAccountUserBasicInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOfficialAccountUserBasicInfoHeaders([]);

        return $this->queryOfficialAccountUserBasicInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据targetId查询关系数据
     *  *
     * @param string                              $targetId
     * @param QueryRelationDatasByTargetIdRequest $request  QueryRelationDatasByTargetIdRequest
     * @param QueryRelationDatasByTargetIdHeaders $headers  QueryRelationDatasByTargetIdHeaders
     * @param RuntimeOptions                      $runtime  runtime options for this request RuntimeOptions
     *
     * @return QueryRelationDatasByTargetIdResponse QueryRelationDatasByTargetIdResponse
     */
    public function queryRelationDatasByTargetIdWithOptions($targetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->relationType)) {
            $query['relationType'] = $request->relationType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryRelationDatasByTargetId',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/relations/datas/targets/' . $targetId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryRelationDatasByTargetIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据targetId查询关系数据
     *  *
     * @param string                              $targetId
     * @param QueryRelationDatasByTargetIdRequest $request  QueryRelationDatasByTargetIdRequest
     *
     * @return QueryRelationDatasByTargetIdResponse QueryRelationDatasByTargetIdResponse
     */
    public function queryRelationDatasByTargetId($targetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRelationDatasByTargetIdHeaders([]);

        return $this->queryRelationDatasByTargetIdWithOptions($targetId, $request, $headers, $runtime);
    }

    /**
     * @summary 服务窗消息撤回
     *  *
     * @param RecallOfficialAccountOTOMessageRequest $request RecallOfficialAccountOTOMessageRequest
     * @param RecallOfficialAccountOTOMessageHeaders $headers RecallOfficialAccountOTOMessageHeaders
     * @param RuntimeOptions                         $runtime runtime options for this request RuntimeOptions
     *
     * @return RecallOfficialAccountOTOMessageResponse RecallOfficialAccountOTOMessageResponse
     */
    public function recallOfficialAccountOTOMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accountId)) {
            $body['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->openPushId)) {
            $body['openPushId'] = $request->openPushId;
        }
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
            'action'      => 'RecallOfficialAccountOTOMessage',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/officialAccounts/oToMessages/recall',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RecallOfficialAccountOTOMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务窗消息撤回
     *  *
     * @param RecallOfficialAccountOTOMessageRequest $request RecallOfficialAccountOTOMessageRequest
     *
     * @return RecallOfficialAccountOTOMessageResponse RecallOfficialAccountOTOMessageResponse
     */
    public function recallOfficialAccountOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RecallOfficialAccountOTOMessageHeaders([]);

        return $this->recallOfficialAccountOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 保存license
     *  *
     * @param SaveBenefitLicenseRequest $request SaveBenefitLicenseRequest
     * @param SaveBenefitLicenseHeaders $headers SaveBenefitLicenseHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveBenefitLicenseResponse SaveBenefitLicenseResponse
     */
    public function saveBenefitLicenseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->domain)) {
            $body['domain'] = $request->domain;
        }
        if (!Utils::isUnset($request->licenses)) {
            $body['licenses'] = $request->licenses;
        }
        if (!Utils::isUnset($request->saveUserId)) {
            $body['saveUserId'] = $request->saveUserId;
        }
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
            'action'      => 'SaveBenefitLicense',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/benefitLicenses/save',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveBenefitLicenseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 保存license
     *  *
     * @param SaveBenefitLicenseRequest $request SaveBenefitLicenseRequest
     *
     * @return SaveBenefitLicenseResponse SaveBenefitLicenseResponse
     */
    public function saveBenefitLicense($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveBenefitLicenseHeaders([]);

        return $this->saveBenefitLicenseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务窗单发接口，指定消息接收人发送
     *  *
     * @param SendOfficialAccountOTOMessageRequest $request SendOfficialAccountOTOMessageRequest
     * @param SendOfficialAccountOTOMessageHeaders $headers SendOfficialAccountOTOMessageHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return SendOfficialAccountOTOMessageResponse SendOfficialAccountOTOMessageResponse
     */
    public function sendOfficialAccountOTOMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->accountId)) {
            $body['accountId'] = $request->accountId;
        }
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->detail)) {
            $body['detail'] = $request->detail;
        }
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
            'action'      => 'SendOfficialAccountOTOMessage',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/officialAccounts/oToMessages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendOfficialAccountOTOMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务窗单发接口，指定消息接收人发送
     *  *
     * @param SendOfficialAccountOTOMessageRequest $request SendOfficialAccountOTOMessageRequest
     *
     * @return SendOfficialAccountOTOMessageResponse SendOfficialAccountOTOMessageResponse
     */
    public function sendOfficialAccountOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendOfficialAccountOTOMessageHeaders([]);

        return $this->sendOfficialAccountOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 个人应用发送服务窗消息
     *  *
     * @param SendOfficialAccountSNSMessageRequest $request SendOfficialAccountSNSMessageRequest
     * @param SendOfficialAccountSNSMessageHeaders $headers SendOfficialAccountSNSMessageHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return SendOfficialAccountSNSMessageResponse SendOfficialAccountSNSMessageResponse
     */
    public function sendOfficialAccountSNSMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bindingToken)) {
            $body['bindingToken'] = $request->bindingToken;
        }
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->detail)) {
            $body['detail'] = $request->detail;
        }
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
            'action'      => 'SendOfficialAccountSNSMessage',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/officialAccounts/snsMessages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendOfficialAccountSNSMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 个人应用发送服务窗消息
     *  *
     * @param SendOfficialAccountSNSMessageRequest $request SendOfficialAccountSNSMessageRequest
     *
     * @return SendOfficialAccountSNSMessageResponse SendOfficialAccountSNSMessageResponse
     */
    public function sendOfficialAccountSNSMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendOfficialAccountSNSMessageHeaders([]);

        return $this->sendOfficialAccountSNSMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 服务窗消息群发
     *  *
     * @param ServiceWindowMessageBatchPushRequest $request ServiceWindowMessageBatchPushRequest
     * @param ServiceWindowMessageBatchPushHeaders $headers ServiceWindowMessageBatchPushHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return ServiceWindowMessageBatchPushResponse ServiceWindowMessageBatchPushResponse
     */
    public function serviceWindowMessageBatchPushWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->detail)) {
            $body['detail'] = $request->detail;
        }
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
            'action'      => 'ServiceWindowMessageBatchPush',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/messages/batchSend',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ServiceWindowMessageBatchPushResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 服务窗消息群发
     *  *
     * @param ServiceWindowMessageBatchPushRequest $request ServiceWindowMessageBatchPushRequest
     *
     * @return ServiceWindowMessageBatchPushResponse ServiceWindowMessageBatchPushResponse
     */
    public function serviceWindowMessageBatchPush($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ServiceWindowMessageBatchPushHeaders([]);

        return $this->serviceWindowMessageBatchPushWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 二阶段提交权益库存结果
     *  *
     * @param TwoPhaseCommitInventoryRequest $request TwoPhaseCommitInventoryRequest
     * @param TwoPhaseCommitInventoryHeaders $headers TwoPhaseCommitInventoryHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return TwoPhaseCommitInventoryResponse TwoPhaseCommitInventoryResponse
     */
    public function twoPhaseCommitInventoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->benefitCode)) {
            $body['benefitCode'] = $request->benefitCode;
        }
        if (!Utils::isUnset($request->bizRequestId)) {
            $body['bizRequestId'] = $request->bizRequestId;
        }
        if (!Utils::isUnset($request->executeResult)) {
            $body['executeResult'] = $request->executeResult;
        }
        if (!Utils::isUnset($request->quota)) {
            $body['quota'] = $request->quota;
        }
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
            'action'      => 'TwoPhaseCommitInventory',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/benefitInventories/twoPhases/commit',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return TwoPhaseCommitInventoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 二阶段提交权益库存结果
     *  *
     * @param TwoPhaseCommitInventoryRequest $request TwoPhaseCommitInventoryRequest
     *
     * @return TwoPhaseCommitInventoryResponse TwoPhaseCommitInventoryResponse
     */
    public function twoPhaseCommitInventory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TwoPhaseCommitInventoryHeaders([]);

        return $this->twoPhaseCommitInventoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新crm个人客户（或企业客户）
     *  *
     * @param UpdateCrmPersonalCustomerRequest $request UpdateCrmPersonalCustomerRequest
     * @param UpdateCrmPersonalCustomerHeaders $headers UpdateCrmPersonalCustomerHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateCrmPersonalCustomerResponse UpdateCrmPersonalCustomerResponse
     */
    public function updateCrmPersonalCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->extendData)) {
            $body['extendData'] = $request->extendData;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->modifierNick)) {
            $body['modifierNick'] = $request->modifierNick;
        }
        if (!Utils::isUnset($request->modifierUserId)) {
            $body['modifierUserId'] = $request->modifierUserId;
        }
        if (!Utils::isUnset($request->permission)) {
            $body['permission'] = $request->permission;
        }
        if (!Utils::isUnset($request->relationType)) {
            $body['relationType'] = $request->relationType;
        }
        if (!Utils::isUnset($request->skipDuplicateCheck)) {
            $body['skipDuplicateCheck'] = $request->skipDuplicateCheck;
        }
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
            'action'      => 'UpdateCrmPersonalCustomer',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/personalCustomers',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateCrmPersonalCustomerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新crm个人客户（或企业客户）
     *  *
     * @param UpdateCrmPersonalCustomerRequest $request UpdateCrmPersonalCustomerRequest
     *
     * @return UpdateCrmPersonalCustomerResponse UpdateCrmPersonalCustomerResponse
     */
    public function updateCrmPersonalCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCrmPersonalCustomerHeaders([]);

        return $this->updateCrmPersonalCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新客户模板类型
     *  *
     * @param UpdateCustomerBizTypeRequest $request UpdateCustomerBizTypeRequest
     * @param UpdateCustomerBizTypeHeaders $headers UpdateCustomerBizTypeHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateCustomerBizTypeResponse UpdateCustomerBizTypeResponse
     */
    public function updateCustomerBizTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->customerBizType)) {
            $body['customerBizType'] = $request->customerBizType;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
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
            'action'      => 'UpdateCustomerBizType',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/orgSettings/templates/customerBizTypes',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateCustomerBizTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新客户模板类型
     *  *
     * @param UpdateCustomerBizTypeRequest $request UpdateCustomerBizTypeRequest
     *
     * @return UpdateCustomerBizTypeResponse UpdateCustomerBizTypeResponse
     */
    public function updateCustomerBizType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCustomerBizTypeHeaders([]);

        return $this->updateCustomerBizTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新群组
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
        if (!Utils::isUnset($request->managerUserIds)) {
            $body['managerUserIds'] = $request->managerUserIds;
        }
        if (!Utils::isUnset($request->memberQuota)) {
            $body['memberQuota'] = $request->memberQuota;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->notice)) {
            $body['notice'] = $request->notice;
        }
        if (!Utils::isUnset($request->noticeToped)) {
            $body['noticeToped'] = $request->noticeToped;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            $body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->ownerUserId)) {
            $body['ownerUserId'] = $request->ownerUserId;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->welcome)) {
            $body['welcome'] = $request->welcome;
        }
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
            'action'      => 'UpdateGroupSet',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/groupSets/set',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'boolean',
        ]);

        return UpdateGroupSetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新群组
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
     * @summary 增量同步导航数据
     *  *
     * @param UpdateMenuDataRequest $request UpdateMenuDataRequest
     * @param UpdateMenuDataHeaders $headers UpdateMenuDataHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateMenuDataResponse UpdateMenuDataResponse
     */
    public function updateMenuDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attr)) {
            $body['attr'] = $request->attr;
        }
        if (!Utils::isUnset($request->bizTraceId)) {
            $body['bizTraceId'] = $request->bizTraceId;
        }
        if (!Utils::isUnset($request->module)) {
            $body['module'] = $request->module;
        }
        if (!Utils::isUnset($request->navData)) {
            $body['navData'] = $request->navData;
        }
        if (!Utils::isUnset($request->operateType)) {
            $body['operateType'] = $request->operateType;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
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
            'action'      => 'UpdateMenuData',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/navigations/menus/sync',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateMenuDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 增量同步导航数据
     *  *
     * @param UpdateMenuDataRequest $request UpdateMenuDataRequest
     *
     * @return UpdateMenuDataResponse UpdateMenuDataResponse
     */
    public function updateMenuData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateMenuDataHeaders([]);

        return $this->updateMenuDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 模型表结构更新字段
     *  *
     * @param UpdateMetaModelFieldRequest $request UpdateMetaModelFieldRequest
     * @param UpdateMetaModelFieldHeaders $headers UpdateMetaModelFieldHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateMetaModelFieldResponse UpdateMetaModelFieldResponse
     */
    public function updateMetaModelFieldWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->fieldDTOList)) {
            $body['fieldDTOList'] = $request->fieldDTOList;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->tenant)) {
            $body['tenant'] = $request->tenant;
        }
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
            'action'      => 'UpdateMetaModelField',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/metas/models/fields',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateMetaModelFieldResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 模型表结构更新字段
     *  *
     * @param UpdateMetaModelFieldRequest $request UpdateMetaModelFieldRequest
     *
     * @return UpdateMetaModelFieldResponse UpdateMetaModelFieldResponse
     */
    public function updateMetaModelField($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateMetaModelFieldHeaders([]);

        return $this->updateMetaModelFieldWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 关系模型表结构更新字段
     *  *
     * @param UpdateRelationMetaFieldRequest $request UpdateRelationMetaFieldRequest
     * @param UpdateRelationMetaFieldHeaders $headers UpdateRelationMetaFieldHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateRelationMetaFieldResponse UpdateRelationMetaFieldResponse
     */
    public function updateRelationMetaFieldWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fieldDTOList)) {
            $body['fieldDTOList'] = $request->fieldDTOList;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->relationType)) {
            $body['relationType'] = $request->relationType;
        }
        if (!Utils::isUnset($request->tenant)) {
            $body['tenant'] = $request->tenant;
        }
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
            'action'      => 'UpdateRelationMetaField',
            'version'     => 'crm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/crm/relations/metas/fields',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateRelationMetaFieldResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 关系模型表结构更新字段
     *  *
     * @param UpdateRelationMetaFieldRequest $request UpdateRelationMetaFieldRequest
     *
     * @return UpdateRelationMetaFieldResponse UpdateRelationMetaFieldResponse
     */
    public function updateRelationMetaField($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRelationMetaFieldHeaders([]);

        return $this->updateRelationMetaFieldWithOptions($request, $headers, $runtime);
    }
}
