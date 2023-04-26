<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\AddGroupMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\AddGroupMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\AddGroupMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\AddProfileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\AddProfileRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\AddProfileResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\BatchSendHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\BatchSendRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\BatchSendResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\CreateGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\CreateGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\CreateGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\CreateTrustGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\CreateTrustGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\CreateTrustGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\DismissGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\DismissGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\DismissGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetConversationIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetConversationIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetConversationIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetMediaUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetMediaUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetMediaUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetMediaUrlsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetMediaUrlsRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetMediaUrlsResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetSpaceFileUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetSpaceFileUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\GetSpaceFileUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\ListGroupStaffMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\ListGroupStaffMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\ListGroupStaffMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\QueryBatchSendResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\QueryBatchSendResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\QueryBatchSendResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\ReadMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\ReadMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\ReadMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\RecallMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\RecallMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\RecallMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\RemoveGroupMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\RemoveGroupMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\RemoveGroupMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\SendMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\SendMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\SendMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\SendRobotMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\SendRobotMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\SendRobotMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\UpdateGroupNameHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\UpdateGroupNameRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\UpdateGroupNameResponse;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\UpdateGroupOwnerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\UpdateGroupOwnerRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\UpdateGroupOwnerResponse;
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
     * @param AddGroupMembersRequest $request
     * @param AddGroupMembersHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return AddGroupMembersResponse
     */
    public function addGroupMembersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conversationId)) {
            $body['conversationId'] = $request->conversationId;
        }
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->operatorUid)) {
            $body['operatorUid'] = $request->operatorUid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->operationSource)) {
            $realHeaders['operationSource'] = Utils::toJSONString($headers->operationSource);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AddGroupMembers',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/groups/members/batchAdd',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return AddGroupMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddGroupMembersRequest $request
     *
     * @return AddGroupMembersResponse
     */
    public function addGroupMembers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddGroupMembersHeaders([]);

        return $this->addGroupMembersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param AddProfileRequest $request
     * @param AddProfileHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return AddProfileResponse
     */
    public function addProfileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appUid)) {
            $body['appUid'] = $request->appUid;
        }
        if (!Utils::isUnset($request->avatarMediaId)) {
            $body['avatarMediaId'] = $request->avatarMediaId;
        }
        if (!Utils::isUnset($request->mobileNumber)) {
            $body['mobileNumber'] = $request->mobileNumber;
        }
        if (!Utils::isUnset($request->nick)) {
            $body['nick'] = $request->nick;
        }
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
            'action'      => 'AddProfile',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/users/profiles',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return AddProfileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddProfileRequest $request
     *
     * @return AddProfileResponse
     */
    public function addProfile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddProfileHeaders([]);

        return $this->addProfileWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchSendRequest $request
     * @param BatchSendHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return BatchSendResponse
     */
    public function batchSendWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appUids)) {
            $body['appUids'] = $request->appUids;
        }
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->conversationIds)) {
            $body['conversationIds'] = $request->conversationIds;
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
            'action'      => 'BatchSend',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/messages/batchSend',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchSendResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchSendRequest $request
     *
     * @return BatchSendResponse
     */
    public function batchSend($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchSendHeaders([]);

        return $this->batchSendWithOptions($request, $headers, $runtime);
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
        if (!Utils::isUnset($request->channel)) {
            $body['channel'] = $request->channel;
        }
        if (!Utils::isUnset($request->creatorUid)) {
            $body['creatorUid'] = $request->creatorUid;
        }
        if (!Utils::isUnset($request->iconMediaId)) {
            $body['iconMediaId'] = $request->iconMediaId;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->properties)) {
            $body['properties'] = $request->properties;
        }
        if (!Utils::isUnset($request->uuid)) {
            $body['uuid'] = $request->uuid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->operationSource)) {
            $realHeaders['operationSource'] = Utils::toJSONString($headers->operationSource);
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
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/groups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
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
     * @param CreateTrustGroupRequest $request
     * @param CreateTrustGroupHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return CreateTrustGroupResponse
     */
    public function createTrustGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->channel)) {
            $body['channel'] = $request->channel;
        }
        if (!Utils::isUnset($request->iconMediaId)) {
            $body['iconMediaId'] = $request->iconMediaId;
        }
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->properties)) {
            $body['properties'] = $request->properties;
        }
        if (!Utils::isUnset($request->systemMsg)) {
            $body['systemMsg'] = $request->systemMsg;
        }
        if (!Utils::isUnset($request->uuid)) {
            $body['uuid'] = $request->uuid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->operationSource)) {
            $realHeaders['operationSource'] = Utils::toJSONString($headers->operationSource);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateTrustGroup',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/groups/trusts',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateTrustGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateTrustGroupRequest $request
     *
     * @return CreateTrustGroupResponse
     */
    public function createTrustGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTrustGroupHeaders([]);

        return $this->createTrustGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DismissGroupRequest $request
     * @param DismissGroupHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return DismissGroupResponse
     */
    public function dismissGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conversationId)) {
            $body['conversationId'] = $request->conversationId;
        }
        if (!Utils::isUnset($request->operatorUid)) {
            $body['operatorUid'] = $request->operatorUid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->operationSource)) {
            $realHeaders['operationSource'] = Utils::toJSONString($headers->operationSource);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DismissGroup',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/groups/dismiss',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return DismissGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DismissGroupRequest $request
     *
     * @return DismissGroupResponse
     */
    public function dismissGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DismissGroupHeaders([]);

        return $this->dismissGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetConversationIdRequest $request
     * @param GetConversationIdHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetConversationIdResponse
     */
    public function getConversationIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appUid)) {
            $body['appUid'] = $request->appUid;
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
            'action'      => 'GetConversationId',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/conversations',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetConversationIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetConversationIdRequest $request
     *
     * @return GetConversationIdResponse
     */
    public function getConversationId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConversationIdHeaders([]);

        return $this->getConversationIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetMediaUrlRequest $request
     * @param GetMediaUrlHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetMediaUrlResponse
     */
    public function getMediaUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->mediaId)) {
            $body['mediaId'] = $request->mediaId;
        }
        if (!Utils::isUnset($request->urlExpireTime)) {
            $body['urlExpireTime'] = $request->urlExpireTime;
        }
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
            'action'      => 'GetMediaUrl',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/medium/urls',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetMediaUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetMediaUrlRequest $request
     *
     * @return GetMediaUrlResponse
     */
    public function getMediaUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMediaUrlHeaders([]);

        return $this->getMediaUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetMediaUrlsRequest $request
     * @param GetMediaUrlsHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetMediaUrlsResponse
     */
    public function getMediaUrlsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->mediaIds)) {
            $body['mediaIds'] = $request->mediaIds;
        }
        if (!Utils::isUnset($request->urlExpireTime)) {
            $body['urlExpireTime'] = $request->urlExpireTime;
        }
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
            'action'      => 'GetMediaUrls',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/mediaUrls/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetMediaUrlsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetMediaUrlsRequest $request
     *
     * @return GetMediaUrlsResponse
     */
    public function getMediaUrls($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMediaUrlsHeaders([]);

        return $this->getMediaUrlsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSpaceFileUrlRequest $request
     * @param GetSpaceFileUrlHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetSpaceFileUrlResponse
     */
    public function getSpaceFileUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->fileId)) {
            $query['fileId'] = $request->fileId;
        }
        if (!Utils::isUnset($request->senderUid)) {
            $query['senderUid'] = $request->senderUid;
        }
        if (!Utils::isUnset($request->spaceId)) {
            $query['spaceId'] = $request->spaceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetSpaceFileUrl',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/spaces/files/urls',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSpaceFileUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetSpaceFileUrlRequest $request
     *
     * @return GetSpaceFileUrlResponse
     */
    public function getSpaceFileUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSpaceFileUrlHeaders([]);

        return $this->getSpaceFileUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListGroupStaffMembersRequest $request
     * @param ListGroupStaffMembersHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return ListGroupStaffMembersResponse
     */
    public function listGroupStaffMembersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conversationId)) {
            $body['conversationId'] = $request->conversationId;
        }
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
            'action'      => 'ListGroupStaffMembers',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/groups/staffMemers/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListGroupStaffMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListGroupStaffMembersRequest $request
     *
     * @return ListGroupStaffMembersResponse
     */
    public function listGroupStaffMembers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListGroupStaffMembersHeaders([]);

        return $this->listGroupStaffMembersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryBatchSendResultRequest $request
     * @param QueryBatchSendResultHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryBatchSendResultResponse
     */
    public function queryBatchSendResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->senderUserId)) {
            $query['senderUserId'] = $request->senderUserId;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryBatchSendResult',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/messages/batchSendResults',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryBatchSendResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryBatchSendResultRequest $request
     *
     * @return QueryBatchSendResultResponse
     */
    public function queryBatchSendResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBatchSendResultHeaders([]);

        return $this->queryBatchSendResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ReadMessageRequest $request
     * @param ReadMessageHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return ReadMessageResponse
     */
    public function readMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->messageId)) {
            $body['messageId'] = $request->messageId;
        }
        if (!Utils::isUnset($request->operatorUid)) {
            $body['operatorUid'] = $request->operatorUid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->operationSource)) {
            $realHeaders['operationSource'] = Utils::toJSONString($headers->operationSource);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ReadMessage',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/messages/read',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return ReadMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ReadMessageRequest $request
     *
     * @return ReadMessageResponse
     */
    public function readMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReadMessageHeaders([]);

        return $this->readMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RecallMessageRequest $request
     * @param RecallMessageHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return RecallMessageResponse
     */
    public function recallMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->messageId)) {
            $body['messageId'] = $request->messageId;
        }
        if (!Utils::isUnset($request->operatorUid)) {
            $body['operatorUid'] = $request->operatorUid;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->operationSource)) {
            $realHeaders['operationSource'] = Utils::toJSONString($headers->operationSource);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RecallMessage',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/messages/recall',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return RecallMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RecallMessageRequest $request
     *
     * @return RecallMessageResponse
     */
    public function recallMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RecallMessageHeaders([]);

        return $this->recallMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RemoveGroupMembersRequest $request
     * @param RemoveGroupMembersHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return RemoveGroupMembersResponse
     */
    public function removeGroupMembersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conversationId)) {
            $body['conversationId'] = $request->conversationId;
        }
        if (!Utils::isUnset($request->memberUids)) {
            $body['memberUids'] = $request->memberUids;
        }
        if (!Utils::isUnset($request->operatorUid)) {
            $body['operatorUid'] = $request->operatorUid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->operationSource)) {
            $realHeaders['operationSource'] = Utils::toJSONString($headers->operationSource);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RemoveGroupMembers',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/groups/members/batchRemove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return RemoveGroupMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RemoveGroupMembersRequest $request
     *
     * @return RemoveGroupMembersResponse
     */
    public function removeGroupMembers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveGroupMembersHeaders([]);

        return $this->removeGroupMembersWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendMessageRequest $request
     * @param SendMessageHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return SendMessageResponse
     */
    public function sendMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->conversationId)) {
            $body['conversationId'] = $request->conversationId;
        }
        if (!Utils::isUnset($request->createTime)) {
            $body['createTime'] = $request->createTime;
        }
        if (!Utils::isUnset($request->receiverUid)) {
            $body['receiverUid'] = $request->receiverUid;
        }
        if (!Utils::isUnset($request->senderUid)) {
            $body['senderUid'] = $request->senderUid;
        }
        if (!Utils::isUnset($request->uuid)) {
            $body['uuid'] = $request->uuid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->operationSource)) {
            $realHeaders['operationSource'] = Utils::toJSONString($headers->operationSource);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SendMessage',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/messages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SendMessageRequest $request
     *
     * @return SendMessageResponse
     */
    public function sendMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendMessageHeaders([]);

        return $this->sendMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendRobotMessageRequest $request
     * @param SendRobotMessageHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return SendRobotMessageResponse
     */
    public function sendRobotMessageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->atAll)) {
            $body['atAll'] = $request->atAll;
        }
        if (!Utils::isUnset($request->atAppUids)) {
            $body['atAppUids'] = $request->atAppUids;
        }
        if (!Utils::isUnset($request->atMobiles)) {
            $body['atMobiles'] = $request->atMobiles;
        }
        if (!Utils::isUnset($request->atUnionIds)) {
            $body['atUnionIds'] = $request->atUnionIds;
        }
        if (!Utils::isUnset($request->atUsers)) {
            $body['atUsers'] = $request->atUsers;
        }
        if (!Utils::isUnset($request->channel)) {
            $body['channel'] = $request->channel;
        }
        if (!Utils::isUnset($request->msgMediaIdParamMap)) {
            $body['msgMediaIdParamMap'] = $request->msgMediaIdParamMap;
        }
        if (!Utils::isUnset($request->msgParamMap)) {
            $body['msgParamMap'] = $request->msgParamMap;
        }
        if (!Utils::isUnset($request->msgTemplateId)) {
            $body['msgTemplateId'] = $request->msgTemplateId;
        }
        if (!Utils::isUnset($request->receiverAppUids)) {
            $body['receiverAppUids'] = $request->receiverAppUids;
        }
        if (!Utils::isUnset($request->receiverMobiles)) {
            $body['receiverMobiles'] = $request->receiverMobiles;
        }
        if (!Utils::isUnset($request->receiverUnionIds)) {
            $body['receiverUnionIds'] = $request->receiverUnionIds;
        }
        if (!Utils::isUnset($request->receiverUserIds)) {
            $body['receiverUserIds'] = $request->receiverUserIds;
        }
        if (!Utils::isUnset($request->robotCode)) {
            $body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->targetOpenConversationId)) {
            $body['targetOpenConversationId'] = $request->targetOpenConversationId;
        }
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
            'action'      => 'SendRobotMessage',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/robots/messages/send',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SendRobotMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SendRobotMessageRequest $request
     *
     * @return SendRobotMessageResponse
     */
    public function sendRobotMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendRobotMessageHeaders([]);

        return $this->sendRobotMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateGroupNameRequest $request
     * @param UpdateGroupNameHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return UpdateGroupNameResponse
     */
    public function updateGroupNameWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conversationId)) {
            $body['conversationId'] = $request->conversationId;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->operatorUid)) {
            $body['operatorUid'] = $request->operatorUid;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->operationSource)) {
            $realHeaders['operationSource'] = Utils::toJSONString($headers->operationSource);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateGroupName',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/groups/names',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateGroupNameResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateGroupNameRequest $request
     *
     * @return UpdateGroupNameResponse
     */
    public function updateGroupName($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGroupNameHeaders([]);

        return $this->updateGroupNameWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateGroupOwnerRequest $request
     * @param UpdateGroupOwnerHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return UpdateGroupOwnerResponse
     */
    public function updateGroupOwnerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conversationId)) {
            $body['conversationId'] = $request->conversationId;
        }
        if (!Utils::isUnset($request->operatorUid)) {
            $body['operatorUid'] = $request->operatorUid;
        }
        if (!Utils::isUnset($request->ownerUid)) {
            $body['ownerUid'] = $request->ownerUid;
        }
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
            'action'      => 'UpdateGroupOwner',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/groups/owners',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateGroupOwnerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateGroupOwnerRequest $request
     *
     * @return UpdateGroupOwnerResponse
     */
    public function updateGroupOwner($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGroupOwnerHeaders([]);

        return $this->updateGroupOwnerWithOptions($request, $headers, $runtime);
    }
}
