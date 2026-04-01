<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\CreateGroupBlackboardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\CreateGroupBlackboardNewHeaders;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\CreateGroupBlackboardNewRequest;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\CreateGroupBlackboardNewResponse;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\CreateGroupBlackboardRequest;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\CreateGroupBlackboardResponse;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\DeleteGroupBlackboardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\DeleteGroupBlackboardNewHeaders;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\DeleteGroupBlackboardNewRequest;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\DeleteGroupBlackboardNewResponse;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\DeleteGroupBlackboardRequest;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\DeleteGroupBlackboardResponse;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\EditGroupBlackboardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\EditGroupBlackboardRequest;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\EditGroupBlackboardResponse;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\GetGroupBlackboardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\GetGroupBlackboardRequest;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\GetGroupBlackboardResponse;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\ListGroupBlackboardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\ListGroupBlackboardRequest;
use AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models\ListGroupBlackboardResponse;
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
     * @summary 创建群公告
     *  *
     * @param CreateGroupBlackboardRequest $request CreateGroupBlackboardRequest
     * @param CreateGroupBlackboardHeaders $headers CreateGroupBlackboardHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateGroupBlackboardResponse CreateGroupBlackboardResponse
     */
    public function createGroupBlackboardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->sendDing)) {
            $body['sendDing'] = $request->sendDing;
        }
        if (!Utils::isUnset($request->sticky)) {
            $body['sticky'] = $request->sticky;
        }
        if (!Utils::isUnset($request->uniqueId)) {
            $body['uniqueId'] = $request->uniqueId;
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
            'action' => 'CreateGroupBlackboard',
            'version' => 'groupBlackboard_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/groupBlackboard/blackboards',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateGroupBlackboardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建群公告
     *  *
     * @param CreateGroupBlackboardRequest $request CreateGroupBlackboardRequest
     *
     * @return CreateGroupBlackboardResponse CreateGroupBlackboardResponse
     */
    public function createGroupBlackboard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateGroupBlackboardHeaders([]);

        return $this->createGroupBlackboardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建群公告
     *  *
     * @param CreateGroupBlackboardNewRequest $request CreateGroupBlackboardNewRequest
     * @param CreateGroupBlackboardNewHeaders $headers CreateGroupBlackboardNewHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateGroupBlackboardNewResponse CreateGroupBlackboardNewResponse
     */
    public function createGroupBlackboardNewWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->sendDing)) {
            $body['sendDing'] = $request->sendDing;
        }
        if (!Utils::isUnset($request->sticky)) {
            $body['sticky'] = $request->sticky;
        }
        if (!Utils::isUnset($request->uniqueId)) {
            $body['uniqueId'] = $request->uniqueId;
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
            'action' => 'CreateGroupBlackboardNew',
            'version' => 'groupBlackboard_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/groupBlackboard/blackboards/create',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateGroupBlackboardNewResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建群公告
     *  *
     * @param CreateGroupBlackboardNewRequest $request CreateGroupBlackboardNewRequest
     *
     * @return CreateGroupBlackboardNewResponse CreateGroupBlackboardNewResponse
     */
    public function createGroupBlackboardNew($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateGroupBlackboardNewHeaders([]);

        return $this->createGroupBlackboardNewWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除群公告
     *  *
     * @param DeleteGroupBlackboardRequest $request DeleteGroupBlackboardRequest
     * @param DeleteGroupBlackboardHeaders $headers DeleteGroupBlackboardHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteGroupBlackboardResponse DeleteGroupBlackboardResponse
     */
    public function deleteGroupBlackboardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dataId)) {
            $body['dataId'] = $request->dataId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
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
            'action' => 'DeleteGroupBlackboard',
            'version' => 'groupBlackboard_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/groupBlackboard/blackboards/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteGroupBlackboardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除群公告
     *  *
     * @param DeleteGroupBlackboardRequest $request DeleteGroupBlackboardRequest
     *
     * @return DeleteGroupBlackboardResponse DeleteGroupBlackboardResponse
     */
    public function deleteGroupBlackboard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteGroupBlackboardHeaders([]);

        return $this->deleteGroupBlackboardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除群公告
     *  *
     * @param DeleteGroupBlackboardNewRequest $request DeleteGroupBlackboardNewRequest
     * @param DeleteGroupBlackboardNewHeaders $headers DeleteGroupBlackboardNewHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteGroupBlackboardNewResponse DeleteGroupBlackboardNewResponse
     */
    public function deleteGroupBlackboardNewWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dataId)) {
            $body['dataId'] = $request->dataId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
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
            'action' => 'DeleteGroupBlackboardNew',
            'version' => 'groupBlackboard_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/groupBlackboard/blackboards/delete',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteGroupBlackboardNewResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除群公告
     *  *
     * @param DeleteGroupBlackboardNewRequest $request DeleteGroupBlackboardNewRequest
     *
     * @return DeleteGroupBlackboardNewResponse DeleteGroupBlackboardNewResponse
     */
    public function deleteGroupBlackboardNew($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteGroupBlackboardNewHeaders([]);

        return $this->deleteGroupBlackboardNewWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑群公告
     *  *
     * @param EditGroupBlackboardRequest $request EditGroupBlackboardRequest
     * @param EditGroupBlackboardHeaders $headers EditGroupBlackboardHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return EditGroupBlackboardResponse EditGroupBlackboardResponse
     */
    public function editGroupBlackboardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->dataId)) {
            $body['dataId'] = $request->dataId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->sticky)) {
            $body['sticky'] = $request->sticky;
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
            'action' => 'EditGroupBlackboard',
            'version' => 'groupBlackboard_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/groupBlackboard/blackboards/edit',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return EditGroupBlackboardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑群公告
     *  *
     * @param EditGroupBlackboardRequest $request EditGroupBlackboardRequest
     *
     * @return EditGroupBlackboardResponse EditGroupBlackboardResponse
     */
    public function editGroupBlackboard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditGroupBlackboardHeaders([]);

        return $this->editGroupBlackboardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询群公告详情
     *  *
     * @param GetGroupBlackboardRequest $request GetGroupBlackboardRequest
     * @param GetGroupBlackboardHeaders $headers GetGroupBlackboardHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetGroupBlackboardResponse GetGroupBlackboardResponse
     */
    public function getGroupBlackboardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dataId)) {
            $body['dataId'] = $request->dataId;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
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
            'action' => 'GetGroupBlackboard',
            'version' => 'groupBlackboard_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/groupBlackboard/blackboards/get',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetGroupBlackboardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询群公告详情
     *  *
     * @param GetGroupBlackboardRequest $request GetGroupBlackboardRequest
     *
     * @return GetGroupBlackboardResponse GetGroupBlackboardResponse
     */
    public function getGroupBlackboard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetGroupBlackboardHeaders([]);

        return $this->getGroupBlackboardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询群公告列表
     *  *
     * @param ListGroupBlackboardRequest $request ListGroupBlackboardRequest
     * @param ListGroupBlackboardHeaders $headers ListGroupBlackboardHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return ListGroupBlackboardResponse ListGroupBlackboardResponse
     */
    public function listGroupBlackboardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->nextPageCursor)) {
            $body['nextPageCursor'] = $request->nextPageCursor;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
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
            'action' => 'ListGroupBlackboard',
            'version' => 'groupBlackboard_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/groupBlackboard/blackboards/list',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListGroupBlackboardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询群公告列表
     *  *
     * @param ListGroupBlackboardRequest $request ListGroupBlackboardRequest
     *
     * @return ListGroupBlackboardResponse ListGroupBlackboardResponse
     */
    public function listGroupBlackboard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListGroupBlackboardHeaders([]);

        return $this->listGroupBlackboardWithOptions($request, $headers, $runtime);
    }
}
