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
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenCategoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenCategoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenCategoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenKnowledgeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenKnowledgeRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenKnowledgeResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenLibraryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenLibraryRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenLibraryResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddTicketMemoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddTicketMemoRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddTicketMemoResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AssignTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AssignTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AssignTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchGetGroupSetConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchGetGroupSetConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchGetGroupSetConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BoundTemplateToTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BoundTemplateToTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BoundTemplateToTeamResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CancelTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CancelTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CancelTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CloseHumanSessionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CloseHumanSessionRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CloseHumanSessionResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupSetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupSetRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateGroupSetResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTeamResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryActiveUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryActiveUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryActiveUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupSetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupSetRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryGroupSetResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryServiceGroupMessageReadStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryServiceGroupMessageReadStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryServiceGroupMessageReadStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ResubmitTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ResubmitTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ResubmitTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\RetractTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\RetractTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\RetractTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SearchGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SearchGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SearchGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendServiceGroupMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendServiceGroupMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendServiceGroupMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SetRobotConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SetRobotConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SetRobotConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TakeTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TakeTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TakeTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TransferTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TransferTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TransferTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateGroupTagHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateGroupTagRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateGroupTagResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpdateTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpgradeCloudGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpgradeCloudGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpgradeCloudGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpgradeNormalGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpgradeNormalGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\UpgradeNormalGroupResponse;
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
     * @param SendMsgByTaskRequest $request
     *
     * @return SendMsgByTaskResponse
     */
    public function sendMsgByTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendMsgByTaskHeaders([]);

        return $this->sendMsgByTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendMsgByTaskRequest $request
     * @param SendMsgByTaskHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return SendMsgByTaskResponse
     */
    public function sendMsgByTaskWithOptions($request, $headers, $runtime)
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
        if (!Utils::isUnset($request->taskName)) {
            @$body['taskName'] = $request->taskName;
        }
        if (!Utils::isUnset($request->messageContent)) {
            @$body['messageContent'] = $request->messageContent;
        }
        if (!Utils::isUnset($request->queryGroup)) {
            @$body['queryGroup'] = $request->queryGroup;
        }
        if (!Utils::isUnset($request->sendConfig)) {
            @$body['sendConfig'] = $request->sendConfig;
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

        return SendMsgByTaskResponse::fromMap($this->doROARequest('SendMsgByTask', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/messages/tasks/send', 'json', $req, $runtime));
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
     * @param UpgradeNormalGroupRequest $request
     *
     * @return UpgradeNormalGroupResponse
     */
    public function upgradeNormalGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpgradeNormalGroupHeaders([]);

        return $this->upgradeNormalGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpgradeNormalGroupRequest $request
     * @param UpgradeNormalGroupHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return UpgradeNormalGroupResponse
     */
    public function upgradeNormalGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openGroupSetId)) {
            @$body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->templateId)) {
            @$body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
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
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
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

        return UpgradeNormalGroupResponse::fromMap($this->doROARequest('UpgradeNormalGroup', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/normalGroups/upgrade', 'none', $req, $runtime));
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
        if (!Utils::isUnset($request->extTitle)) {
            @$body['extTitle'] = $request->extTitle;
        }
        if (!Utils::isUnset($request->keyword)) {
            @$body['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->attachmentList)) {
            @$body['attachmentList'] = $request->attachmentList;
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
     * @param RetractTicketRequest $request
     *
     * @return RetractTicketResponse
     */
    public function retractTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RetractTicketHeaders([]);

        return $this->retractTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RetractTicketRequest $request
     * @param RetractTicketHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return RetractTicketResponse
     */
    public function retractTicketWithOptions($request, $headers, $runtime)
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
        if (!Utils::isUnset($request->openTicketId)) {
            @$body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            @$body['operatorUnionId'] = $request->operatorUnionId;
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

        return RetractTicketResponse::fromMap($this->doROARequest('RetractTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/tickets/retract', 'none', $req, $runtime));
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
     * @param SetRobotConfigRequest $request
     *
     * @return SetRobotConfigResponse
     */
    public function setRobotConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetRobotConfigHeaders([]);

        return $this->setRobotConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SetRobotConfigRequest $request
     * @param SetRobotConfigHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SetRobotConfigResponse
     */
    public function setRobotConfigWithOptions($request, $headers, $runtime)
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
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            @$body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
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

        return SetRobotConfigResponse::fromMap($this->doROARequest('SetRobotConfig', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/groups/configs/set', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->hasContentLinks)) {
            @$body['hasContentLinks'] = $request->hasContentLinks;
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
     * @param UpgradeCloudGroupRequest $request
     *
     * @return UpgradeCloudGroupResponse
     */
    public function upgradeCloudGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpgradeCloudGroupHeaders([]);

        return $this->upgradeCloudGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpgradeCloudGroupRequest $request
     * @param UpgradeCloudGroupHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return UpgradeCloudGroupResponse
     */
    public function upgradeCloudGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->templateId)) {
            @$body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->openGroupSetId)) {
            @$body['openGroupSetId'] = $request->openGroupSetId;
        }
        if (!Utils::isUnset($request->ccsInstanceId)) {
            @$body['ccsInstanceId'] = $request->ccsInstanceId;
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
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
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

        return UpgradeCloudGroupResponse::fromMap($this->doROARequest('UpgradeCloudGroup', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/cloudGroups/upgrade', 'none', $req, $runtime));
    }

    /**
     * @param ResubmitTicketRequest $request
     *
     * @return ResubmitTicketResponse
     */
    public function resubmitTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ResubmitTicketHeaders([]);

        return $this->resubmitTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ResubmitTicketRequest $request
     * @param ResubmitTicketHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return ResubmitTicketResponse
     */
    public function resubmitTicketWithOptions($request, $headers, $runtime)
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
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->openTemplateBizId)) {
            @$body['openTemplateBizId'] = $request->openTemplateBizId;
        }
        if (!Utils::isUnset($request->customFields)) {
            @$body['customFields'] = $request->customFields;
        }
        if (!Utils::isUnset($request->notify)) {
            @$body['notify'] = $request->notify;
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

        return ResubmitTicketResponse::fromMap($this->doROARequest('ResubmitTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/tickets/resubmit', 'none', $req, $runtime));
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

    /**
     * @param QueryGroupSetRequest $request
     *
     * @return QueryGroupSetResponse
     */
    public function queryGroupSet($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryGroupSetHeaders([]);

        return $this->queryGroupSetWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryGroupSetRequest $request
     * @param QueryGroupSetHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return QueryGroupSetResponse
     */
    public function queryGroupSetWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openTeamId)) {
            @$query['openTeamId'] = $request->openTeamId;
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

        return QueryGroupSetResponse::fromMap($this->doROARequest('QueryGroupSet', 'serviceGroup_1.0', 'HTTP', 'GET', 'AK', '/v1.0/serviceGroup/groupSets', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->searchType)) {
            @$body['searchType'] = $request->searchType;
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
     * @param AddOpenLibraryRequest $request
     *
     * @return AddOpenLibraryResponse
     */
    public function addOpenLibrary($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddOpenLibraryHeaders([]);

        return $this->addOpenLibraryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddOpenLibraryRequest $request
     * @param AddOpenLibraryHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return AddOpenLibraryResponse
     */
    public function addOpenLibraryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->userName)) {
            @$body['userName'] = $request->userName;
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

        return AddOpenLibraryResponse::fromMap($this->doROARequest('AddOpenLibrary', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/openLibraries', 'json', $req, $runtime));
    }

    /**
     * @param QueryActiveUsersRequest $request
     *
     * @return QueryActiveUsersResponse
     */
    public function queryActiveUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryActiveUsersHeaders([]);

        return $this->queryActiveUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryActiveUsersRequest $request
     * @param QueryActiveUsersHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QueryActiveUsersResponse
     */
    public function queryActiveUsersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->openTeamId)) {
            @$query['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$query['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->topN)) {
            @$query['topN'] = $request->topN;
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

        return QueryActiveUsersResponse::fromMap($this->doROARequest('QueryActiveUsers', 'serviceGroup_1.0', 'HTTP', 'GET', 'AK', '/v1.0/serviceGroup/groups/queryActiveUsers', 'json', $req, $runtime));
    }

    /**
     * @param AddOpenCategoryRequest $request
     *
     * @return AddOpenCategoryResponse
     */
    public function addOpenCategory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddOpenCategoryHeaders([]);

        return $this->addOpenCategoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddOpenCategoryRequest $request
     * @param AddOpenCategoryHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return AddOpenCategoryResponse
     */
    public function addOpenCategoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->userName)) {
            @$body['userName'] = $request->userName;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->parentId)) {
            @$body['parentId'] = $request->parentId;
        }
        if (!Utils::isUnset($request->libraryId)) {
            @$body['libraryId'] = $request->libraryId;
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

        return AddOpenCategoryResponse::fromMap($this->doROARequest('AddOpenCategory', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/openCategories', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->groupSetName)) {
            @$body['groupSetName'] = $request->groupSetName;
        }
        if (!Utils::isUnset($request->groupTemplateId)) {
            @$body['groupTemplateId'] = $request->groupTemplateId;
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

        return CreateGroupSetResponse::fromMap($this->doROARequest('CreateGroupSet', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/groupSets', 'json', $req, $runtime));
    }

    /**
     * @param BoundTemplateToTeamRequest $request
     *
     * @return BoundTemplateToTeamResponse
     */
    public function boundTemplateToTeam($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BoundTemplateToTeamHeaders([]);

        return $this->boundTemplateToTeamWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BoundTemplateToTeamRequest $request
     * @param BoundTemplateToTeamHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return BoundTemplateToTeamResponse
     */
    public function boundTemplateToTeamWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->templateId)) {
            @$body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->templateName)) {
            @$body['templateName'] = $request->templateName;
        }
        if (!Utils::isUnset($request->templateType)) {
            @$body['templateType'] = $request->templateType;
        }
        if (!Utils::isUnset($request->templateDesc)) {
            @$body['templateDesc'] = $request->templateDesc;
        }
        if (!Utils::isUnset($request->robotConfig)) {
            @$body['robotConfig'] = $request->robotConfig;
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

        return BoundTemplateToTeamResponse::fromMap($this->doROARequest('BoundTemplateToTeam', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/teams/templates/bound', 'json', $req, $runtime));
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
     * @param CancelTicketRequest $request
     *
     * @return CancelTicketResponse
     */
    public function cancelTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelTicketHeaders([]);

        return $this->cancelTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CancelTicketRequest $request
     * @param CancelTicketHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return CancelTicketResponse
     */
    public function cancelTicketWithOptions($request, $headers, $runtime)
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
        if (!Utils::isUnset($request->openTicketId)) {
            @$body['openTicketId'] = $request->openTicketId;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            @$body['operatorUnionId'] = $request->operatorUnionId;
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

        return CancelTicketResponse::fromMap($this->doROARequest('CancelTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/tickets/cancel', 'none', $req, $runtime));
    }

    /**
     * @param UpdateGroupTagRequest $request
     *
     * @return UpdateGroupTagResponse
     */
    public function updateGroupTag($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGroupTagHeaders([]);

        return $this->updateGroupTagWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateGroupTagRequest $request
     * @param UpdateGroupTagHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return UpdateGroupTagResponse
     */
    public function updateGroupTagWithOptions($request, $headers, $runtime)
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
        if (!Utils::isUnset($request->openConversationIds)) {
            @$body['openConversationIds'] = $request->openConversationIds;
        }
        if (!Utils::isUnset($request->tagNames)) {
            @$body['tagNames'] = $request->tagNames;
        }
        if (!Utils::isUnset($request->updateType)) {
            @$body['updateType'] = $request->updateType;
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

        return UpdateGroupTagResponse::fromMap($this->doROARequest('UpdateGroupTag', 'serviceGroup_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/serviceGroup/tags', 'none', $req, $runtime));
    }

    /**
     * @param AddOpenKnowledgeRequest $request
     *
     * @return AddOpenKnowledgeResponse
     */
    public function addOpenKnowledge($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddOpenKnowledgeHeaders([]);

        return $this->addOpenKnowledgeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddOpenKnowledgeRequest $request
     * @param AddOpenKnowledgeHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return AddOpenKnowledgeResponse
     */
    public function addOpenKnowledgeWithOptions($request, $headers, $runtime)
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
        if (!Utils::isUnset($request->openTeamId)) {
            @$body['openTeamId'] = $request->openTeamId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->userName)) {
            @$body['userName'] = $request->userName;
        }
        if (!Utils::isUnset($request->attachments)) {
            @$body['attachments'] = $request->attachments;
        }
        if (!Utils::isUnset($request->libraryId)) {
            @$body['libraryId'] = $request->libraryId;
        }
        if (!Utils::isUnset($request->source)) {
            @$body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->type)) {
            @$body['type'] = $request->type;
        }
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->extTitle)) {
            @$body['extTitle'] = $request->extTitle;
        }
        if (!Utils::isUnset($request->keyword)) {
            @$body['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->tags)) {
            @$body['tags'] = $request->tags;
        }
        if (!Utils::isUnset($request->effectTimestart)) {
            @$body['effectTimestart'] = $request->effectTimestart;
        }
        if (!Utils::isUnset($request->effectTimeend)) {
            @$body['effectTimeend'] = $request->effectTimeend;
        }
        if (!Utils::isUnset($request->categoryId)) {
            @$body['categoryId'] = $request->categoryId;
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

        return AddOpenKnowledgeResponse::fromMap($this->doROARequest('AddOpenKnowledge', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/openKnowledges', 'json', $req, $runtime));
    }

    /**
     * @param CreateTeamRequest $request
     *
     * @return CreateTeamResponse
     */
    public function createTeam($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTeamHeaders([]);

        return $this->createTeamWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateTeamRequest $request
     * @param CreateTeamHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return CreateTeamResponse
     */
    public function createTeamWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->creatorDingUnionId)) {
            @$body['creatorDingUnionId'] = $request->creatorDingUnionId;
        }
        if (!Utils::isUnset($request->teamName)) {
            @$body['teamName'] = $request->teamName;
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

        return CreateTeamResponse::fromMap($this->doROARequest('CreateTeam', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', '/v1.0/serviceGroup/teams', 'json', $req, $runtime));
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
}
