<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddKnowledgeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddKnowledgeRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddKnowledgeResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddLibraryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddLibraryRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddLibraryResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddTicketMemoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddTicketMemoRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddTicketMemoResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AssignTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AssignTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AssignTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchGetGroupSetConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchGetGroupSetConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchGetGroupSetConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CloseHumanSessionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CloseHumanSessionRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CloseHumanSessionResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\DeleteKnowledgeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\DeleteKnowledgeRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\DeleteKnowledgeResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\FinishTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\FinishTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\FinishTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetOssTempUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetOssTempUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetOssTempUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetStoragePolicyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetStoragePolicyRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetStoragePolicyResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListTicketOperateRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListTicketOperateRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListTicketOperateRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListUserTeamsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListUserTeamsResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryServiceGroupMessageReadStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryServiceGroupMessageReadStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryServiceGroupMessageReadStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SearchGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SearchGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SearchGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendServiceGroupMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendServiceGroupMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendServiceGroupMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TakeTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TakeTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TakeTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TransferTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TransferTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TransferTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UrgeTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UrgeTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UrgeTicketResponse;
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
     * @param DeleteKnowledgeRequest $request
     *
     * @return DeleteKnowledgeResponse
     */
    public function deleteKnowledge($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteKnowledgeHeaders([]);

        return $this->deleteKnowledgeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeleteKnowledgeRequest $request
     * @param DeleteKnowledgeHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return DeleteKnowledgeResponse
     */
    public function deleteKnowledgeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->libraryKey)) {
            @$body['libraryKey'] = $request->libraryKey;
        }
        if (!Utils::isUnset($request->source)) {
            @$body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->sourcePrimaryKey)) {
            @$body['sourcePrimaryKey'] = $request->sourcePrimaryKey;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return DeleteKnowledgeResponse::fromMap($this->doROARequest('DeleteKnowledge', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/knowledges/batchDelete', 'json', $req, $runtime));
    }

    /**
     * @param CreateTicketRequest $request
     *
     * @return CreateTicketResponse
     */
    public function createTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTicketHeaders([]);

        return $this->createTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateTicketRequest $request
     * @param CreateTicketHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return CreateTicketResponse
     */
    public function createTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->creatorUnionId)) {
            @$body['creatorUnionId'] = $request->creatorUnionId;
        }
        if (!Utils::isUnset($request->processorUnionIds)) {
            @$body['processorUnionIds'] = $request->processorUnionIds;
        }
        if (!Utils::isUnset($request->scene)) {
            @$body['scene'] = $request->scene;
        }
        if (!Utils::isUnset($request->sceneContext)) {
            @$body['sceneContext'] = $request->sceneContext;
        }
        if (!Utils::isUnset($request->openTemplateBizId)) {
            @$body['openTemplateBizId'] = $request->openTemplateBizId;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->customFields)) {
            @$body['customFields'] = $request->customFields;
        }
        if (!Utils::isUnset($request->notify)) {
            @$body['notify'] = $request->notify;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateTicketResponse::fromMap($this->doROARequest('CreateTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/tickets', 'json', $req, $runtime));
    }

    /**
     * @param AssignTicketRequest $request
     *
     * @return AssignTicketResponse
     */
    public function assignTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AssignTicketHeaders([]);

        return $this->assignTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AssignTicketRequest $request
     * @param AssignTicketHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return AssignTicketResponse
     */
    public function assignTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            @$body['operatorUnionId'] = $request->operatorUnionId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            @$body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->processorUnionIds)) {
            @$body['processorUnionIds'] = $request->processorUnionIds;
        }
        if (!Utils::isUnset($request->ticketMemo)) {
            @$body['ticketMemo'] = $request->ticketMemo;
        }
        if (!Utils::isUnset($request->notify)) {
            @$body['notify'] = $request->notify;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AssignTicketResponse::fromMap($this->doROARequest('AssignTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/tickets/assign', 'none', $req, $runtime));
    }

    /**
     * @param FinishTicketRequest $request
     *
     * @return FinishTicketResponse
     */
    public function finishTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FinishTicketHeaders([]);

        return $this->finishTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @param FinishTicketRequest $request
     * @param FinishTicketHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return FinishTicketResponse
     */
    public function finishTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->processorUnionId)) {
            @$body['processorUnionId'] = $request->processorUnionId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            @$body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->ticketMemo)) {
            @$body['ticketMemo'] = $request->ticketMemo;
        }
        if (!Utils::isUnset($request->notify)) {
            @$body['notify'] = $request->notify;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return FinishTicketResponse::fromMap($this->doROARequest('FinishTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/tickets/finish', 'none', $req, $runtime));
    }

    /**
     * @param SearchGroupRequest $request
     *
     * @return SearchGroupResponse
     */
    public function searchGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchGroupHeaders([]);

        return $this->searchGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchGroupRequest $request
     * @param SearchGroupHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return SearchGroupResponse
     */
    public function searchGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->groupName)) {
            @$body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            @$body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$body['maxResults'] = $request->maxResults;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SearchGroupResponse::fromMap($this->doROARequest('SearchGroup', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/groups/search', 'json', $req, $runtime));
    }

    /**
     * @param UpdateTicketRequest $request
     *
     * @return UpdateTicketResponse
     */
    public function updateTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTicketHeaders([]);

        return $this->updateTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateTicketRequest $request
     * @param UpdateTicketHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return UpdateTicketResponse
     */
    public function updateTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->processorUnionId)) {
            @$body['processorUnionId'] = $request->processorUnionId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            @$body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->customFields)) {
            @$body['customFields'] = $request->customFields;
        }
        if (!Utils::isUnset($request->ticketMemo)) {
            @$body['ticketMemo'] = $request->ticketMemo;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateTicketResponse::fromMap($this->doROARequest('UpdateTicket', 'serviceGroup_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/serviceGroup/tickets', 'none', $req, $runtime));
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
        if (!Utils::isUnset($request->groupBizId)) {
            @$body['groupBizId'] = $request->groupBizId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            @$body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->groupName)) {
            @$body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->ownerStaffId)) {
            @$body['ownerStaffId'] = $request->ownerStaffId;
        }
        if (!Utils::isUnset($request->memberStaffIds)) {
            @$body['memberStaffIds'] = $request->memberStaffIds;
        }
        if (!Utils::isUnset($request->groupTagNames)) {
            @$body['groupTagNames'] = $request->groupTagNames;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateGroupResponse::fromMap($this->doROARequest('CreateGroup', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/groups', 'json', $req, $runtime));
    }

    /**
     * @param TransferTicketRequest $request
     *
     * @return TransferTicketResponse
     */
    public function transferTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TransferTicketHeaders([]);

        return $this->transferTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @param TransferTicketRequest $request
     * @param TransferTicketHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return TransferTicketResponse
     */
    public function transferTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->processorUnionId)) {
            @$body['processorUnionId'] = $request->processorUnionId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            @$body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->processorUnionIds)) {
            @$body['processorUnionIds'] = $request->processorUnionIds;
        }
        if (!Utils::isUnset($request->ticketMemo)) {
            @$body['ticketMemo'] = $request->ticketMemo;
        }
        if (!Utils::isUnset($request->notify)) {
            @$body['notify'] = $request->notify;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return TransferTicketResponse::fromMap($this->doROARequest('TransferTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/tickets/transfer', 'none', $req, $runtime));
    }

    /**
     * @param AddKnowledgeRequest $request
     *
     * @return AddKnowledgeResponse
     */
    public function addKnowledge($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddKnowledgeHeaders([]);

        return $this->addKnowledgeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddKnowledgeRequest $request
     * @param AddKnowledgeHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return AddKnowledgeResponse
     */
    public function addKnowledgeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->libraryKey)) {
            @$body['libraryKey'] = $request->libraryKey;
        }
        if (!Utils::isUnset($request->source)) {
            @$body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->sourcePrimaryKey)) {
            @$body['sourcePrimaryKey'] = $request->sourcePrimaryKey;
        }
        if (!Utils::isUnset($request->type)) {
            @$body['type'] = $request->type;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->linkUrl)) {
            @$body['linkUrl'] = $request->linkUrl;
        }
        if (!Utils::isUnset($request->version)) {
            @$body['version'] = $request->version;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AddKnowledgeResponse::fromMap($this->doROARequest('AddKnowledge', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/knowledges', 'json', $req, $runtime));
    }

    /**
     * @param BatchGetGroupSetConfigRequest $request
     *
     * @return BatchGetGroupSetConfigResponse
     */
    public function batchGetGroupSetConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchGetGroupSetConfigHeaders([]);

        return $this->batchGetGroupSetConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchGetGroupSetConfigRequest $request
     * @param BatchGetGroupSetConfigHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return BatchGetGroupSetConfigResponse
     */
    public function batchGetGroupSetConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            @$body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->configKeys)) {
            @$body['configKeys'] = $request->configKeys;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BatchGetGroupSetConfigResponse::fromMap($this->doROARequest('BatchGetGroupSetConfig', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/groupSetConfigs/batchQuery', 'json', $req, $runtime));
    }

    /**
     * @param ListTicketOperateRecordRequest $request
     *
     * @return ListTicketOperateRecordResponse
     */
    public function listTicketOperateRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListTicketOperateRecordHeaders([]);

        return $this->listTicketOperateRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListTicketOperateRecordRequest $request
     * @param ListTicketOperateRecordHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return ListTicketOperateRecordResponse
     */
    public function listTicketOperateRecordWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openTeamId)) {
            @$query['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            @$query['openTicketId'] = $request->openTicketId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListTicketOperateRecordResponse::fromMap($this->doROARequest('ListTicketOperateRecord', 'serviceGroup_1.0', 'HTTP', 'GET', 'AK', '/v1.0/serviceGroup/tickets/operateRecords', 'json', $req, $runtime));
    }

    /**
     * @param QueryServiceGroupMessageReadStatusRequest $request
     *
     * @return QueryServiceGroupMessageReadStatusResponse
     */
    public function queryServiceGroupMessageReadStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryServiceGroupMessageReadStatusHeaders([]);

        return $this->queryServiceGroupMessageReadStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryServiceGroupMessageReadStatusRequest $request
     * @param QueryServiceGroupMessageReadStatusHeaders $headers
     * @param RuntimeOptions                            $runtime
     *
     * @return QueryServiceGroupMessageReadStatusResponse
     */
    public function queryServiceGroupMessageReadStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openMsgTaskId)) {
            @$body['openMsgTaskId'] = $request->openMsgTaskId;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$body['maxResults'] = $request->maxResults;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return QueryServiceGroupMessageReadStatusResponse::fromMap($this->doROARequest('QueryServiceGroupMessageReadStatus', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/messages/readStatus/query', 'json', $req, $runtime));
    }

    /**
     * @param AddLibraryRequest $request
     *
     * @return AddLibraryResponse
     */
    public function addLibrary($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddLibraryHeaders([]);

        return $this->addLibraryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddLibraryRequest $request
     * @param AddLibraryHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return AddLibraryResponse
     */
    public function addLibraryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->openTeamIds)) {
            @$body['openTeamIds'] = $request->openTeamIds;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->type)) {
            @$body['type'] = $request->type;
        }
        if (!Utils::isUnset($request->source)) {
            @$body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->sourcePrimaryKey)) {
            @$body['sourcePrimaryKey'] = $request->sourcePrimaryKey;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AddLibraryResponse::fromMap($this->doROARequest('AddLibrary', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/librarys', 'json', $req, $runtime));
    }

    /**
     * @param QueryGroupRequest $request
     *
     * @return QueryGroupResponse
     */
    public function queryGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupHeaders([]);

        return $this->queryGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryGroupRequest $request
     * @param QueryGroupHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return QueryGroupResponse
     */
    public function queryGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->bizId)) {
            @$body['bizId'] = $request->bizId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return QueryGroupResponse::fromMap($this->doROARequest('QueryGroup', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/groups/query', 'json', $req, $runtime));
    }

    /**
     * @param CloseHumanSessionRequest $request
     *
     * @return CloseHumanSessionResponse
     */
    public function closeHumanSession($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CloseHumanSessionHeaders([]);

        return $this->closeHumanSessionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CloseHumanSessionRequest $request
     * @param CloseHumanSessionHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return CloseHumanSessionResponse
     */
    public function closeHumanSessionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->visitorUnionId)) {
            @$body['visitorUnionId'] = $request->visitorUnionId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CloseHumanSessionResponse::fromMap($this->doROARequest('CloseHumanSession', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/humanSessions/close', 'json', $req, $runtime));
    }

    /**
     * @param UrgeTicketRequest $request
     *
     * @return UrgeTicketResponse
     */
    public function urgeTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UrgeTicketHeaders([]);

        return $this->urgeTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UrgeTicketRequest $request
     * @param UrgeTicketHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return UrgeTicketResponse
     */
    public function urgeTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            @$body['operatorUnionId'] = $request->operatorUnionId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            @$body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->ticketMemo)) {
            @$body['ticketMemo'] = $request->ticketMemo;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UrgeTicketResponse::fromMap($this->doROARequest('UrgeTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/tickets/urge', 'none', $req, $runtime));
    }

    /**
     * @param GetTicketRequest $request
     *
     * @return GetTicketResponse
     */
    public function getTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTicketHeaders([]);

        return $this->getTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetTicketRequest $request
     * @param GetTicketHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return GetTicketResponse
     */
    public function getTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openTeamId)) {
            @$query['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            @$query['openTicketId'] = $request->openTicketId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetTicketResponse::fromMap($this->doROARequest('GetTicket', 'serviceGroup_1.0', 'HTTP', 'GET', 'AK', '/v1.0/serviceGroup/tickets', 'json', $req, $runtime));
    }

    /**
     * @param GetOssTempUrlRequest $request
     *
     * @return GetOssTempUrlResponse
     */
    public function getOssTempUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOssTempUrlHeaders([]);

        return $this->getOssTempUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetOssTempUrlRequest $request
     * @param GetOssTempUrlHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetOssTempUrlResponse
     */
    public function getOssTempUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openTeamId)) {
            @$query['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->key)) {
            @$query['key'] = $request->key;
        }
        if (!Utils::isUnset($request->fileName)) {
            @$query['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->fetchMode)) {
            @$query['fetchMode'] = $request->fetchMode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetOssTempUrlResponse::fromMap($this->doROARequest('GetOssTempUrl', 'serviceGroup_1.0', 'HTTP', 'GET', 'AK', '/v1.0/serviceGroup/ossServices/tempUrls', 'json', $req, $runtime));
    }

    /**
     * @param TakeTicketRequest $request
     *
     * @return TakeTicketResponse
     */
    public function takeTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TakeTicketHeaders([]);

        return $this->takeTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @param TakeTicketRequest $request
     * @param TakeTicketHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return TakeTicketResponse
     */
    public function takeTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->takerUnionId)) {
            @$body['takerUnionId'] = $request->takerUnionId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            @$body['openTicketId'] = $request->openTicketId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return TakeTicketResponse::fromMap($this->doROARequest('TakeTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/tickets/apply', 'none', $req, $runtime));
    }

    /**
     * @param SendServiceGroupMessageRequest $request
     *
     * @return SendServiceGroupMessageResponse
     */
    public function sendServiceGroupMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendServiceGroupMessageHeaders([]);

        return $this->sendServiceGroupMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendServiceGroupMessageRequest $request
     * @param SendServiceGroupMessageHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return SendServiceGroupMessageResponse
     */
    public function sendServiceGroupMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->targetOpenConversationId)) {
            @$body['targetOpenConversationId'] = $request->targetOpenConversationId;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->isAtAll)) {
            @$body['isAtAll'] = $request->isAtAll;
        }
        if (!Utils::isUnset($request->atMobiles)) {
            @$body['atMobiles'] = $request->atMobiles;
        }
        if (!Utils::isUnset($request->atDingtalkIds)) {
            @$body['atDingtalkIds'] = $request->atDingtalkIds;
        }
        if (!Utils::isUnset($request->atUnionIds)) {
            @$body['atUnionIds'] = $request->atUnionIds;
        }
        if (!Utils::isUnset($request->receiverMobiles)) {
            @$body['receiverMobiles'] = $request->receiverMobiles;
        }
        if (!Utils::isUnset($request->receiverDingtalkIds)) {
            @$body['receiverDingtalkIds'] = $request->receiverDingtalkIds;
        }
        if (!Utils::isUnset($request->receiverUnionIds)) {
            @$body['receiverUnionIds'] = $request->receiverUnionIds;
        }
        if (!Utils::isUnset($request->messageType)) {
            @$body['messageType'] = $request->messageType;
        }
        if (!Utils::isUnset($request->btnOrientation)) {
            @$body['btnOrientation'] = $request->btnOrientation;
        }
        if (!Utils::isUnset($request->btns)) {
            @$body['btns'] = $request->btns;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SendServiceGroupMessageResponse::fromMap($this->doROARequest('SendServiceGroupMessage', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/messages/send', 'json', $req, $runtime));
    }

    /**
     * @param GetStoragePolicyRequest $request
     *
     * @return GetStoragePolicyResponse
     */
    public function getStoragePolicy($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetStoragePolicyHeaders([]);

        return $this->getStoragePolicyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetStoragePolicyRequest $request
     * @param GetStoragePolicyHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetStoragePolicyResponse
     */
    public function getStoragePolicyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->bizType)) {
            @$body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->fileSize)) {
            @$body['fileSize'] = $request->fileSize;
        }
        if (!Utils::isUnset($request->fileName)) {
            @$body['fileName'] = $request->fileName;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetStoragePolicyResponse::fromMap($this->doROARequest('GetStoragePolicy', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/ossServices/policies', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return ListUserTeamsResponse
     */
    public function listUserTeams($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListUserTeamsHeaders([]);

        return $this->listUserTeamsWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string               $userId
     * @param ListUserTeamsHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return ListUserTeamsResponse
     */
    public function listUserTeamsWithOptions($userId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return ListUserTeamsResponse::fromMap($this->doROARequest('ListUserTeams', 'serviceGroup_1.0', 'HTTP', 'GET', 'AK', '/v1.0/serviceGroup/users/' . $userId . '/teams', 'json', $req, $runtime));
    }

    /**
     * @param AddTicketMemoRequest $request
     *
     * @return AddTicketMemoResponse
     */
    public function addTicketMemo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddTicketMemoHeaders([]);

        return $this->addTicketMemoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddTicketMemoRequest $request
     * @param AddTicketMemoHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return AddTicketMemoResponse
     */
    public function addTicketMemoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->processorUnionId)) {
            @$body['processorUnionId'] = $request->processorUnionId;
        }
        if (!Utils::isUnset($request->openTicketId)) {
            @$body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->ticketMemo)) {
            @$body['ticketMemo'] = $request->ticketMemo;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AddTicketMemoResponse::fromMap($this->doROARequest('AddTicketMemo', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/tickets/memos', 'none', $req, $runtime));
    }
}
