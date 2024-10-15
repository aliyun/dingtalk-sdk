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
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\UploadFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\UploadFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\UploadFileResponse;
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
     * @summary 添加群成员
     *  *
     * @param AddGroupMembersRequest $request AddGroupMembersRequest
     * @param AddGroupMembersHeaders $headers AddGroupMembersHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return AddGroupMembersResponse AddGroupMembersResponse
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
     * @summary 添加群成员
     *  *
     * @param AddGroupMembersRequest $request AddGroupMembersRequest
     *
     * @return AddGroupMembersResponse AddGroupMembersResponse
     */
    public function addGroupMembers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddGroupMembersHeaders([]);

        return $this->addGroupMembersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 外部用户导入profile
     *  *
     * @param AddProfileRequest $request AddProfileRequest
     * @param AddProfileHeaders $headers AddProfileHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return AddProfileResponse AddProfileResponse
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
     * @summary 外部用户导入profile
     *  *
     * @param AddProfileRequest $request AddProfileRequest
     *
     * @return AddProfileResponse AddProfileResponse
     */
    public function addProfile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddProfileHeaders([]);

        return $this->addProfileWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 消息批量接口
     *  *
     * @param BatchSendRequest $request BatchSendRequest
     * @param BatchSendHeaders $headers BatchSendHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchSendResponse BatchSendResponse
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
     * @summary 消息批量接口
     *  *
     * @param BatchSendRequest $request BatchSendRequest
     *
     * @return BatchSendResponse BatchSendResponse
     */
    public function batchSend($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchSendHeaders([]);

        return $this->batchSendWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建群
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
     * @summary 创建群
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
     * @summary 创建托管账号为群主的群
     *  *
     * @param CreateTrustGroupRequest $request CreateTrustGroupRequest
     * @param CreateTrustGroupHeaders $headers CreateTrustGroupHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTrustGroupResponse CreateTrustGroupResponse
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
     * @summary 创建托管账号为群主的群
     *  *
     * @param CreateTrustGroupRequest $request CreateTrustGroupRequest
     *
     * @return CreateTrustGroupResponse CreateTrustGroupResponse
     */
    public function createTrustGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTrustGroupHeaders([]);

        return $this->createTrustGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 解散群
     *  *
     * @param DismissGroupRequest $request DismissGroupRequest
     * @param DismissGroupHeaders $headers DismissGroupHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return DismissGroupResponse DismissGroupResponse
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
     * @summary 解散群
     *  *
     * @param DismissGroupRequest $request DismissGroupRequest
     *
     * @return DismissGroupResponse DismissGroupResponse
     */
    public function dismissGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DismissGroupHeaders([]);

        return $this->dismissGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 生成单聊会话Id
     *  *
     * @param GetConversationIdRequest $request GetConversationIdRequest
     * @param GetConversationIdHeaders $headers GetConversationIdHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetConversationIdResponse GetConversationIdResponse
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
     * @summary 生成单聊会话Id
     *  *
     * @param GetConversationIdRequest $request GetConversationIdRequest
     *
     * @return GetConversationIdResponse GetConversationIdResponse
     */
    public function getConversationId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConversationIdHeaders([]);

        return $this->getConversationIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 多媒体文件下载
     *  *
     * @param GetMediaUrlRequest $request GetMediaUrlRequest
     * @param GetMediaUrlHeaders $headers GetMediaUrlHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetMediaUrlResponse GetMediaUrlResponse
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
     * @summary 多媒体文件下载
     *  *
     * @param GetMediaUrlRequest $request GetMediaUrlRequest
     *
     * @return GetMediaUrlResponse GetMediaUrlResponse
     */
    public function getMediaUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMediaUrlHeaders([]);

        return $this->getMediaUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 多媒体文件批量下载
     *  *
     * @param GetMediaUrlsRequest $request GetMediaUrlsRequest
     * @param GetMediaUrlsHeaders $headers GetMediaUrlsHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetMediaUrlsResponse GetMediaUrlsResponse
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
     * @summary 多媒体文件批量下载
     *  *
     * @param GetMediaUrlsRequest $request GetMediaUrlsRequest
     *
     * @return GetMediaUrlsResponse GetMediaUrlsResponse
     */
    public function getMediaUrls($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMediaUrlsHeaders([]);

        return $this->getMediaUrlsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取钉盘文件下载信息
     *  *
     * @param GetSpaceFileUrlRequest $request GetSpaceFileUrlRequest
     * @param GetSpaceFileUrlHeaders $headers GetSpaceFileUrlHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSpaceFileUrlResponse GetSpaceFileUrlResponse
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
     * @summary 获取钉盘文件下载信息
     *  *
     * @param GetSpaceFileUrlRequest $request GetSpaceFileUrlRequest
     *
     * @return GetSpaceFileUrlResponse GetSpaceFileUrlResponse
     */
    public function getSpaceFileUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSpaceFileUrlHeaders([]);

        return $this->getSpaceFileUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取企业员工类型的群成员
     *  *
     * @param ListGroupStaffMembersRequest $request ListGroupStaffMembersRequest
     * @param ListGroupStaffMembersHeaders $headers ListGroupStaffMembersHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return ListGroupStaffMembersResponse ListGroupStaffMembersResponse
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
     * @summary 获取企业员工类型的群成员
     *  *
     * @param ListGroupStaffMembersRequest $request ListGroupStaffMembersRequest
     *
     * @return ListGroupStaffMembersResponse ListGroupStaffMembersResponse
     */
    public function listGroupStaffMembers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListGroupStaffMembersHeaders([]);

        return $this->listGroupStaffMembersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询batchSend结果
     *  *
     * @param QueryBatchSendResultRequest $request QueryBatchSendResultRequest
     * @param QueryBatchSendResultHeaders $headers QueryBatchSendResultHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryBatchSendResultResponse QueryBatchSendResultResponse
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
     * @summary 查询batchSend结果
     *  *
     * @param QueryBatchSendResultRequest $request QueryBatchSendResultRequest
     *
     * @return QueryBatchSendResultResponse QueryBatchSendResultResponse
     */
    public function queryBatchSendResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBatchSendResultHeaders([]);

        return $this->queryBatchSendResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 消息已读
     *  *
     * @param ReadMessageRequest $request ReadMessageRequest
     * @param ReadMessageHeaders $headers ReadMessageHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return ReadMessageResponse ReadMessageResponse
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
     * @summary 消息已读
     *  *
     * @param ReadMessageRequest $request ReadMessageRequest
     *
     * @return ReadMessageResponse ReadMessageResponse
     */
    public function readMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ReadMessageHeaders([]);

        return $this->readMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 消息撤回
     *  *
     * @param RecallMessageRequest $request RecallMessageRequest
     * @param RecallMessageHeaders $headers RecallMessageHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return RecallMessageResponse RecallMessageResponse
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
     * @summary 消息撤回
     *  *
     * @param RecallMessageRequest $request RecallMessageRequest
     *
     * @return RecallMessageResponse RecallMessageResponse
     */
    public function recallMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RecallMessageHeaders([]);

        return $this->recallMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 移除群成员
     *  *
     * @param RemoveGroupMembersRequest $request RemoveGroupMembersRequest
     * @param RemoveGroupMembersHeaders $headers RemoveGroupMembersHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return RemoveGroupMembersResponse RemoveGroupMembersResponse
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
     * @summary 移除群成员
     *  *
     * @param RemoveGroupMembersRequest $request RemoveGroupMembersRequest
     *
     * @return RemoveGroupMembersResponse RemoveGroupMembersResponse
     */
    public function removeGroupMembers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveGroupMembersHeaders([]);

        return $this->removeGroupMembersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 消息发送
     *  *
     * @param SendMessageRequest $request SendMessageRequest
     * @param SendMessageHeaders $headers SendMessageHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return SendMessageResponse SendMessageResponse
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
     * @summary 消息发送
     *  *
     * @param SendMessageRequest $request SendMessageRequest
     *
     * @return SendMessageResponse SendMessageResponse
     */
    public function sendMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendMessageHeaders([]);

        return $this->sendMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过群模板机器人发送消息
     *  *
     * @param SendRobotMessageRequest $request SendRobotMessageRequest
     * @param SendRobotMessageHeaders $headers SendRobotMessageHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return SendRobotMessageResponse SendRobotMessageResponse
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
     * @summary 通过群模板机器人发送消息
     *  *
     * @param SendRobotMessageRequest $request SendRobotMessageRequest
     *
     * @return SendRobotMessageResponse SendRobotMessageResponse
     */
    public function sendRobotMessage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendRobotMessageHeaders([]);

        return $this->sendRobotMessageWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改群名称
     *  *
     * @param UpdateGroupNameRequest $request UpdateGroupNameRequest
     * @param UpdateGroupNameHeaders $headers UpdateGroupNameHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateGroupNameResponse UpdateGroupNameResponse
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
     * @summary 修改群名称
     *  *
     * @param UpdateGroupNameRequest $request UpdateGroupNameRequest
     *
     * @return UpdateGroupNameResponse UpdateGroupNameResponse
     */
    public function updateGroupName($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGroupNameHeaders([]);

        return $this->updateGroupNameWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 转让群主
     *  *
     * @param UpdateGroupOwnerRequest $request UpdateGroupOwnerRequest
     * @param UpdateGroupOwnerHeaders $headers UpdateGroupOwnerHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateGroupOwnerResponse UpdateGroupOwnerResponse
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
     * @summary 转让群主
     *  *
     * @param UpdateGroupOwnerRequest $request UpdateGroupOwnerRequest
     *
     * @return UpdateGroupOwnerResponse UpdateGroupOwnerResponse
     */
    public function updateGroupOwner($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateGroupOwnerHeaders([]);

        return $this->updateGroupOwnerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 互联互通上传文件
     *  *
     * @param UploadFileRequest $request UploadFileRequest
     * @param UploadFileHeaders $headers UploadFileHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return UploadFileResponse UploadFileResponse
     */
    public function uploadFileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->fileName)) {
            $body['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->fileType)) {
            $body['fileType'] = $request->fileType;
        }
        if (!Utils::isUnset($request->fileUrl)) {
            $body['fileUrl'] = $request->fileUrl;
        }
        if (!Utils::isUnset($request->senderUid)) {
            $body['senderUid'] = $request->senderUid;
        }
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
            'action'      => 'UploadFile',
            'version'     => 'impaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/impaas/interconnections/files/upload',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UploadFileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 互联互通上传文件
     *  *
     * @param UploadFileRequest $request UploadFileRequest
     *
     * @return UploadFileResponse UploadFileResponse
     */
    public function uploadFile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UploadFileHeaders([]);

        return $this->uploadFileWithOptions($request, $headers, $runtime);
    }
}
