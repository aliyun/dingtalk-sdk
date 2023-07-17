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
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddRelationMetaFieldHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddRelationMetaFieldRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\AddRelationMetaFieldResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddContactsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddContactsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddContactsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddFollowRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddFollowRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddFollowRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddRelationDatasHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddRelationDatasRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddRelationDatasResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetAllCustomerRecyclesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetAllCustomerRecyclesRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetAllCustomerRecyclesResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListCrmPersonalCustomersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListCrmPersonalCustomersRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListCrmPersonalCustomersResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListGroupSetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListGroupSetRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListGroupSetResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllTracksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllTracksRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllTracksResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmGroupChatsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmGroupChatsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmGroupChatsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmPersonalCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmPersonalCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCrmPersonalCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryGlobalInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryGlobalInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryGlobalInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryOfficialAccountUserBasicInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryOfficialAccountUserBasicInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryOfficialAccountUserBasicInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryRelationDatasByTargetIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryRelationDatasByTargetIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryRelationDatasByTargetIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\RecallOfficialAccountOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\RecallOfficialAccountOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\RecallOfficialAccountOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountSNSMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountSNSMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountSNSMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateCrmPersonalCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateCrmPersonalCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateCrmPersonalCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateGroupSetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateGroupSetRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateGroupSetResponse;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateRelationMetaFieldHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateRelationMetaFieldRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateRelationMetaFieldResponse;
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
     * @param AbandonCustomerRequest $request
     * @param AbandonCustomerHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return AbandonCustomerResponse
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
     * @param AbandonCustomerRequest $request
     *
     * @return AbandonCustomerResponse
     */
    public function abandonCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AbandonCustomerHeaders([]);

        return $this->abandonCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddCrmPersonalCustomerRequest $request
     * @param AddCrmPersonalCustomerHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return AddCrmPersonalCustomerResponse
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
     * @param AddCrmPersonalCustomerRequest $request
     *
     * @return AddCrmPersonalCustomerResponse
     */
    public function addCrmPersonalCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddCrmPersonalCustomerHeaders([]);

        return $this->addCrmPersonalCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddCustomerTrackRequest $request
     * @param AddCustomerTrackHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return AddCustomerTrackResponse
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
     * @param AddCustomerTrackRequest $request
     *
     * @return AddCustomerTrackResponse
     */
    public function addCustomerTrack($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddCustomerTrackHeaders([]);

        return $this->addCustomerTrackWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddLeadsRequest $request
     * @param AddLeadsHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return AddLeadsResponse
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
     * @param AddLeadsRequest $request
     *
     * @return AddLeadsResponse
     */
    public function addLeads($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddLeadsHeaders([]);

        return $this->addLeadsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddRelationMetaFieldRequest $request
     * @param AddRelationMetaFieldHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return AddRelationMetaFieldResponse
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
     * @param AddRelationMetaFieldRequest $request
     *
     * @return AddRelationMetaFieldResponse
     */
    public function addRelationMetaField($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddRelationMetaFieldHeaders([]);

        return $this->addRelationMetaFieldWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchAddContactsRequest $request
     * @param BatchAddContactsHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return BatchAddContactsResponse
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
     * @param BatchAddContactsRequest $request
     *
     * @return BatchAddContactsResponse
     */
    public function batchAddContacts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchAddContactsHeaders([]);

        return $this->batchAddContactsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchAddFollowRecordsRequest $request
     * @param BatchAddFollowRecordsHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return BatchAddFollowRecordsResponse
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
     * @param BatchAddFollowRecordsRequest $request
     *
     * @return BatchAddFollowRecordsResponse
     */
    public function batchAddFollowRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchAddFollowRecordsHeaders([]);

        return $this->batchAddFollowRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchAddRelationDatasRequest $request
     * @param BatchAddRelationDatasHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return BatchAddRelationDatasResponse
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
     * @param BatchAddRelationDatasRequest $request
     *
     * @return BatchAddRelationDatasResponse
     */
    public function batchAddRelationDatas($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchAddRelationDatasHeaders([]);

        return $this->batchAddRelationDatasWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchRemoveFollowRecordsRequest $request
     * @param BatchRemoveFollowRecordsHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return BatchRemoveFollowRecordsResponse
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
     * @param BatchRemoveFollowRecordsRequest $request
     *
     * @return BatchRemoveFollowRecordsResponse
     */
    public function batchRemoveFollowRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchRemoveFollowRecordsHeaders([]);

        return $this->batchRemoveFollowRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchSendOfficialAccountOTOMessageRequest $request
     * @param BatchSendOfficialAccountOTOMessageHeaders $headers
     * @param RuntimeOptions                            $runtime
     *
     * @return BatchSendOfficialAccountOTOMessageResponse
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
     * @param BatchSendOfficialAccountOTOMessageRequest $request
     *
     * @return BatchSendOfficialAccountOTOMessageResponse
     */
    public function batchSendOfficialAccountOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchSendOfficialAccountOTOMessageHeaders([]);

        return $this->batchSendOfficialAccountOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchUpdateContactsRequest $request
     * @param BatchUpdateContactsHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return BatchUpdateContactsResponse
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
     * @param BatchUpdateContactsRequest $request
     *
     * @return BatchUpdateContactsResponse
     */
    public function batchUpdateContacts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateContactsHeaders([]);

        return $this->batchUpdateContactsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchUpdateFollowRecordsRequest $request
     * @param BatchUpdateFollowRecordsHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return BatchUpdateFollowRecordsResponse
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
     * @param BatchUpdateFollowRecordsRequest $request
     *
     * @return BatchUpdateFollowRecordsResponse
     */
    public function batchUpdateFollowRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateFollowRecordsHeaders([]);

        return $this->batchUpdateFollowRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchUpdateRelationDatasRequest $request
     * @param BatchUpdateRelationDatasHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return BatchUpdateRelationDatasResponse
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
     * @param BatchUpdateRelationDatasRequest $request
     *
     * @return BatchUpdateRelationDatasResponse
     */
    public function batchUpdateRelationDatas($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateRelationDatasHeaders([]);

        return $this->batchUpdateRelationDatasWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateCustomerRequest $request
     * @param CreateCustomerHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreateCustomerResponse
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
     * @param CreateCustomerRequest $request
     *
     * @return CreateCustomerResponse
     */
    public function createCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCustomerHeaders([]);

        return $this->createCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateGroupRequest $request
     * @param CreateGroupHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return CreateGroupResponse
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
     * @param CreateGroupRequest $request
     *
     * @return CreateGroupResponse
     */
    public function createGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateGroupHeaders([]);

        return $this->createGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateGroupSetRequest $request
     * @param CreateGroupSetHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreateGroupSetResponse
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
     * @param CreateGroupSetRequest $request
     *
     * @return CreateGroupSetResponse
     */
    public function createGroupSet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateGroupSetHeaders([]);

        return $this->createGroupSetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateRelationMetaRequest $request
     * @param CreateRelationMetaHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return CreateRelationMetaResponse
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
     * @param CreateRelationMetaRequest $request
     *
     * @return CreateRelationMetaResponse
     */
    public function createRelationMeta($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateRelationMetaHeaders([]);

        return $this->createRelationMetaWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                           $instanceId
     * @param DeleteCrmCustomObjectDataRequest $request
     * @param DeleteCrmCustomObjectDataHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return DeleteCrmCustomObjectDataResponse
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
     * @param string                           $instanceId
     * @param DeleteCrmCustomObjectDataRequest $request
     *
     * @return DeleteCrmCustomObjectDataResponse
     */
    public function deleteCrmCustomObjectData($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteCrmCustomObjectDataHeaders([]);

        return $this->deleteCrmCustomObjectDataWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @param string                       $instanceId
     * @param DeleteCrmFormInstanceRequest $request
     * @param DeleteCrmFormInstanceHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return DeleteCrmFormInstanceResponse
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
     * @param string                       $instanceId
     * @param DeleteCrmFormInstanceRequest $request
     *
     * @return DeleteCrmFormInstanceResponse
     */
    public function deleteCrmFormInstance($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteCrmFormInstanceHeaders([]);

        return $this->deleteCrmFormInstanceWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @param string                           $dataId
     * @param DeleteCrmPersonalCustomerRequest $request
     * @param DeleteCrmPersonalCustomerHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return DeleteCrmPersonalCustomerResponse
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
     * @param string                           $dataId
     * @param DeleteCrmPersonalCustomerRequest $request
     *
     * @return DeleteCrmPersonalCustomerResponse
     */
    public function deleteCrmPersonalCustomer($dataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteCrmPersonalCustomerHeaders([]);

        return $this->deleteCrmPersonalCustomerWithOptions($dataId, $request, $headers, $runtime);
    }

    /**
     * @param DeleteLeadsRequest $request
     * @param DeleteLeadsHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return DeleteLeadsResponse
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
     * @param DeleteLeadsRequest $request
     *
     * @return DeleteLeadsResponse
     */
    public function deleteLeads($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteLeadsHeaders([]);

        return $this->deleteLeadsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteRelationMetaFieldRequest $request
     * @param DeleteRelationMetaFieldHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return DeleteRelationMetaFieldResponse
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
     * @param DeleteRelationMetaFieldRequest $request
     *
     * @return DeleteRelationMetaFieldResponse
     */
    public function deleteRelationMetaField($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRelationMetaFieldHeaders([]);

        return $this->deleteRelationMetaFieldWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DescribeCrmPersonalCustomerObjectMetaRequest $request
     * @param DescribeCrmPersonalCustomerObjectMetaHeaders $headers
     * @param RuntimeOptions                               $runtime
     *
     * @return DescribeCrmPersonalCustomerObjectMetaResponse
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
     * @param DescribeCrmPersonalCustomerObjectMetaRequest $request
     *
     * @return DescribeCrmPersonalCustomerObjectMetaResponse
     */
    public function describeCrmPersonalCustomerObjectMeta($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DescribeCrmPersonalCustomerObjectMetaHeaders([]);

        return $this->describeCrmPersonalCustomerObjectMetaWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DescribeRelationMetaRequest $request
     * @param DescribeRelationMetaHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return DescribeRelationMetaResponse
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
     * @param DescribeRelationMetaRequest $request
     *
     * @return DescribeRelationMetaResponse
     */
    public function describeRelationMeta($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DescribeRelationMetaHeaders([]);

        return $this->describeRelationMetaWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetAllCustomerRecyclesRequest $request
     * @param GetAllCustomerRecyclesHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetAllCustomerRecyclesResponse
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
     * @param GetAllCustomerRecyclesRequest $request
     *
     * @return GetAllCustomerRecyclesResponse
     */
    public function getAllCustomerRecycles($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllCustomerRecyclesHeaders([]);

        return $this->getAllCustomerRecyclesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                 $openConversationId
     * @param GetCrmGroupChatHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetCrmGroupChatResponse
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
     * @param string $openConversationId
     *
     * @return GetCrmGroupChatResponse
     */
    public function getCrmGroupChat($openConversationId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCrmGroupChatHeaders([]);

        return $this->getCrmGroupChatWithOptions($openConversationId, $headers, $runtime);
    }

    /**
     * @param GetCrmGroupChatMultiRequest $request
     * @param GetCrmGroupChatMultiHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetCrmGroupChatMultiResponse
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
     * @param GetCrmGroupChatMultiRequest $request
     *
     * @return GetCrmGroupChatMultiResponse
     */
    public function getCrmGroupChatMulti($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCrmGroupChatMultiHeaders([]);

        return $this->getCrmGroupChatMultiWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCrmGroupChatSingleRequest $request
     * @param GetCrmGroupChatSingleHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GetCrmGroupChatSingleResponse
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
     * @param GetCrmGroupChatSingleRequest $request
     *
     * @return GetCrmGroupChatSingleResponse
     */
    public function getCrmGroupChatSingle($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCrmGroupChatSingleHeaders([]);

        return $this->getCrmGroupChatSingleWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCrmRolePermissionRequest $request
     * @param GetCrmRolePermissionHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetCrmRolePermissionResponse
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
     * @param GetCrmRolePermissionRequest $request
     *
     * @return GetCrmRolePermissionResponse
     */
    public function getCrmRolePermission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCrmRolePermissionHeaders([]);

        return $this->getCrmRolePermissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCustomerTracksByRelationIdRequest $request
     * @param GetCustomerTracksByRelationIdHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return GetCustomerTracksByRelationIdResponse
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
     * @param GetCustomerTracksByRelationIdRequest $request
     *
     * @return GetCustomerTracksByRelationIdResponse
     */
    public function getCustomerTracksByRelationId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCustomerTracksByRelationIdHeaders([]);

        return $this->getCustomerTracksByRelationIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetGroupSetRequest $request
     * @param GetGroupSetHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetGroupSetResponse
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
     * @param GetGroupSetRequest $request
     *
     * @return GetGroupSetResponse
     */
    public function getGroupSet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetGroupSetHeaders([]);

        return $this->getGroupSetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                               $userId
     * @param GetOfficialAccountContactInfoHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return GetOfficialAccountContactInfoResponse
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
     * @param string $userId
     *
     * @return GetOfficialAccountContactInfoResponse
     */
    public function getOfficialAccountContactInfo($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOfficialAccountContactInfoHeaders([]);

        return $this->getOfficialAccountContactInfoWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param GetOfficialAccountContactsRequest $request
     * @param GetOfficialAccountContactsHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return GetOfficialAccountContactsResponse
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
     * @param GetOfficialAccountContactsRequest $request
     *
     * @return GetOfficialAccountContactsResponse
     */
    public function getOfficialAccountContacts($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOfficialAccountContactsHeaders([]);

        return $this->getOfficialAccountContactsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetOfficialAccountOTOMessageResultRequest $request
     * @param GetOfficialAccountOTOMessageResultHeaders $headers
     * @param RuntimeOptions                            $runtime
     *
     * @return GetOfficialAccountOTOMessageResultResponse
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
     * @param GetOfficialAccountOTOMessageResultRequest $request
     *
     * @return GetOfficialAccountOTOMessageResultResponse
     */
    public function getOfficialAccountOTOMessageResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOfficialAccountOTOMessageResultHeaders([]);

        return $this->getOfficialAccountOTOMessageResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetRelationUkSettingRequest $request
     * @param GetRelationUkSettingHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetRelationUkSettingResponse
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
     * @param GetRelationUkSettingRequest $request
     *
     * @return GetRelationUkSettingResponse
     */
    public function getRelationUkSetting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRelationUkSettingHeaders([]);

        return $this->getRelationUkSettingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param JoinGroupSetRequest $request
     * @param JoinGroupSetHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return JoinGroupSetResponse
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
     * @param JoinGroupSetRequest $request
     *
     * @return JoinGroupSetResponse
     */
    public function joinGroupSet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new JoinGroupSetHeaders([]);

        return $this->joinGroupSetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListCrmPersonalCustomersRequest $request
     * @param ListCrmPersonalCustomersHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return ListCrmPersonalCustomersResponse
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
     * @param ListCrmPersonalCustomersRequest $request
     *
     * @return ListCrmPersonalCustomersResponse
     */
    public function listCrmPersonalCustomers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListCrmPersonalCustomersHeaders([]);

        return $this->listCrmPersonalCustomersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListGroupSetRequest $request
     * @param ListGroupSetHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return ListGroupSetResponse
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
     * @param ListGroupSetRequest $request
     *
     * @return ListGroupSetResponse
     */
    public function listGroupSet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListGroupSetHeaders([]);

        return $this->listGroupSetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllCustomerRequest $request
     * @param QueryAllCustomerHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QueryAllCustomerResponse
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
     * @param QueryAllCustomerRequest $request
     *
     * @return QueryAllCustomerResponse
     */
    public function queryAllCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllCustomerHeaders([]);

        return $this->queryAllCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllTracksRequest $request
     * @param QueryAllTracksHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryAllTracksResponse
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
     * @param QueryAllTracksRequest $request
     *
     * @return QueryAllTracksResponse
     */
    public function queryAllTracks($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllTracksHeaders([]);

        return $this->queryAllTracksWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCrmGroupChatsRequest $request
     * @param QueryCrmGroupChatsHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryCrmGroupChatsResponse
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
     * @param QueryCrmGroupChatsRequest $request
     *
     * @return QueryCrmGroupChatsResponse
     */
    public function queryCrmGroupChats($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCrmGroupChatsHeaders([]);

        return $this->queryCrmGroupChatsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCrmPersonalCustomerRequest $request
     * @param QueryCrmPersonalCustomerHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return QueryCrmPersonalCustomerResponse
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
     * @param QueryCrmPersonalCustomerRequest $request
     *
     * @return QueryCrmPersonalCustomerResponse
     */
    public function queryCrmPersonalCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCrmPersonalCustomerHeaders([]);

        return $this->queryCrmPersonalCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryGlobalInfoRequest $request
     * @param QueryGlobalInfoHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return QueryGlobalInfoResponse
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
     * @param QueryGlobalInfoRequest $request
     *
     * @return QueryGlobalInfoResponse
     */
    public function queryGlobalInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGlobalInfoHeaders([]);

        return $this->queryGlobalInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryOfficialAccountUserBasicInfoRequest $request
     * @param QueryOfficialAccountUserBasicInfoHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return QueryOfficialAccountUserBasicInfoResponse
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
     * @param QueryOfficialAccountUserBasicInfoRequest $request
     *
     * @return QueryOfficialAccountUserBasicInfoResponse
     */
    public function queryOfficialAccountUserBasicInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOfficialAccountUserBasicInfoHeaders([]);

        return $this->queryOfficialAccountUserBasicInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                              $targetId
     * @param QueryRelationDatasByTargetIdRequest $request
     * @param QueryRelationDatasByTargetIdHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryRelationDatasByTargetIdResponse
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
     * @param string                              $targetId
     * @param QueryRelationDatasByTargetIdRequest $request
     *
     * @return QueryRelationDatasByTargetIdResponse
     */
    public function queryRelationDatasByTargetId($targetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRelationDatasByTargetIdHeaders([]);

        return $this->queryRelationDatasByTargetIdWithOptions($targetId, $request, $headers, $runtime);
    }

    /**
     * @param RecallOfficialAccountOTOMessageRequest $request
     * @param RecallOfficialAccountOTOMessageHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return RecallOfficialAccountOTOMessageResponse
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
     * @param RecallOfficialAccountOTOMessageRequest $request
     *
     * @return RecallOfficialAccountOTOMessageResponse
     */
    public function recallOfficialAccountOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RecallOfficialAccountOTOMessageHeaders([]);

        return $this->recallOfficialAccountOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendOfficialAccountOTOMessageRequest $request
     * @param SendOfficialAccountOTOMessageHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return SendOfficialAccountOTOMessageResponse
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
     * @param SendOfficialAccountOTOMessageRequest $request
     *
     * @return SendOfficialAccountOTOMessageResponse
     */
    public function sendOfficialAccountOTOMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendOfficialAccountOTOMessageHeaders([]);

        return $this->sendOfficialAccountOTOMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendOfficialAccountSNSMessageRequest $request
     * @param SendOfficialAccountSNSMessageHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return SendOfficialAccountSNSMessageResponse
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
     * @param SendOfficialAccountSNSMessageRequest $request
     *
     * @return SendOfficialAccountSNSMessageResponse
     */
    public function sendOfficialAccountSNSMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendOfficialAccountSNSMessageHeaders([]);

        return $this->sendOfficialAccountSNSMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ServiceWindowMessageBatchPushRequest $request
     * @param ServiceWindowMessageBatchPushHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return ServiceWindowMessageBatchPushResponse
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
     * @param ServiceWindowMessageBatchPushRequest $request
     *
     * @return ServiceWindowMessageBatchPushResponse
     */
    public function serviceWindowMessageBatchPush($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ServiceWindowMessageBatchPushHeaders([]);

        return $this->serviceWindowMessageBatchPushWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateCrmPersonalCustomerRequest $request
     * @param UpdateCrmPersonalCustomerHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return UpdateCrmPersonalCustomerResponse
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
     * @param UpdateCrmPersonalCustomerRequest $request
     *
     * @return UpdateCrmPersonalCustomerResponse
     */
    public function updateCrmPersonalCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCrmPersonalCustomerHeaders([]);

        return $this->updateCrmPersonalCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateGroupSetRequest $request
     * @param UpdateGroupSetHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return UpdateGroupSetResponse
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
     * @param UpdateGroupSetRequest $request
     *
     * @return UpdateGroupSetResponse
     */
    public function updateGroupSet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGroupSetHeaders([]);

        return $this->updateGroupSetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateRelationMetaFieldRequest $request
     * @param UpdateRelationMetaFieldHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return UpdateRelationMetaFieldResponse
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
     * @param UpdateRelationMetaFieldRequest $request
     *
     * @return UpdateRelationMetaFieldResponse
     */
    public function updateRelationMetaField($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRelationMetaFieldHeaders([]);

        return $this->updateRelationMetaFieldWithOptions($request, $headers, $runtime);
    }
}
