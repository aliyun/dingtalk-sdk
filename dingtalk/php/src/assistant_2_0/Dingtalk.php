<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_2_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\CreateAssistantMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\CreateAssistantMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\CreateAssistantMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\CreateAssistantRunHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\CreateAssistantRunResponse;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\CreateAssistantThreadHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\CreateAssistantThreadResponse;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\DeleteAssistantMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\DeleteAssistantMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\DeleteAssistantThreadHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\DeleteAssistantThreadResponse;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\ListAssistantMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\ListAssistantMessageRequest;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\ListAssistantMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\RetrieveAssistantMessageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\RetrieveAssistantMessageResponse;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\RetrieveAssistantThreadHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models\RetrieveAssistantThreadResponse;
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
     * @summary 创建AI助理的消息体
     *  *
     * @param string                        $threadId
     * @param CreateAssistantMessageRequest $request  CreateAssistantMessageRequest
     * @param CreateAssistantMessageHeaders $headers  CreateAssistantMessageHeaders
     * @param RuntimeOptions                $runtime  runtime options for this request RuntimeOptions
     *
     * @return CreateAssistantMessageResponse CreateAssistantMessageResponse
     */
    public function createAssistantMessageWithOptions($threadId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->content)) {
            $query['content'] = $request->content;
        }
        if (!Utils::isUnset($request->role)) {
            $query['role'] = $request->role;
        }
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
            'action' => 'CreateAssistantMessage',
            'version' => 'assistant_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/assistant/threads/' . $threadId . '/messages',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateAssistantMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建AI助理的消息体
     *  *
     * @param string                        $threadId
     * @param CreateAssistantMessageRequest $request  CreateAssistantMessageRequest
     *
     * @return CreateAssistantMessageResponse CreateAssistantMessageResponse
     */
    public function createAssistantMessage($threadId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateAssistantMessageHeaders([]);

        return $this->createAssistantMessageWithOptions($threadId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建AI助理的运行任务
     *  *
     * @param string                    $threadId
     * @param CreateAssistantRunHeaders $headers  CreateAssistantRunHeaders
     * @param RuntimeOptions            $runtime  runtime options for this request RuntimeOptions
     *
     * @return CreateAssistantRunResponse CreateAssistantRunResponse
     */
    public function createAssistantRunWithOptions($threadId, $headers, $runtime)
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
            'action' => 'CreateAssistantRun',
            'version' => 'assistant_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/assistant/threads/' . $threadId . '/runs',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateAssistantRunResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建AI助理的运行任务
     *  *
     * @param string $threadId
     *
     * @return CreateAssistantRunResponse CreateAssistantRunResponse
     */
    public function createAssistantRun($threadId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateAssistantRunHeaders([]);

        return $this->createAssistantRunWithOptions($threadId, $headers, $runtime);
    }

    /**
     * @summary 创建AI助理线程实例
     *  *
     * @param CreateAssistantThreadHeaders $headers CreateAssistantThreadHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateAssistantThreadResponse CreateAssistantThreadResponse
     */
    public function createAssistantThreadWithOptions($headers, $runtime)
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
            'action' => 'CreateAssistantThread',
            'version' => 'assistant_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/assistant/threads',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateAssistantThreadResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建AI助理线程实例
     *  *
     * @return CreateAssistantThreadResponse CreateAssistantThreadResponse
     */
    public function createAssistantThread()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateAssistantThreadHeaders([]);

        return $this->createAssistantThreadWithOptions($headers, $runtime);
    }

    /**
     * @summary 删除AI助理的消息体
     *  *
     * @param string                        $threadId
     * @param string                        $messageId
     * @param DeleteAssistantMessageHeaders $headers   DeleteAssistantMessageHeaders
     * @param RuntimeOptions                $runtime   runtime options for this request RuntimeOptions
     *
     * @return DeleteAssistantMessageResponse DeleteAssistantMessageResponse
     */
    public function deleteAssistantMessageWithOptions($threadId, $messageId, $headers, $runtime)
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
            'action' => 'DeleteAssistantMessage',
            'version' => 'assistant_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/assistant/threads/' . $threadId . '/messages/' . $messageId . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteAssistantMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除AI助理的消息体
     *  *
     * @param string $threadId
     * @param string $messageId
     *
     * @return DeleteAssistantMessageResponse DeleteAssistantMessageResponse
     */
    public function deleteAssistantMessage($threadId, $messageId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteAssistantMessageHeaders([]);

        return $this->deleteAssistantMessageWithOptions($threadId, $messageId, $headers, $runtime);
    }

    /**
     * @summary 删除AI助理线程实例
     *  *
     * @param string                       $threadId
     * @param DeleteAssistantThreadHeaders $headers  DeleteAssistantThreadHeaders
     * @param RuntimeOptions               $runtime  runtime options for this request RuntimeOptions
     *
     * @return DeleteAssistantThreadResponse DeleteAssistantThreadResponse
     */
    public function deleteAssistantThreadWithOptions($threadId, $headers, $runtime)
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
            'action' => 'DeleteAssistantThread',
            'version' => 'assistant_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/assistant/threads/' . $threadId . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteAssistantThreadResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除AI助理线程实例
     *  *
     * @param string $threadId
     *
     * @return DeleteAssistantThreadResponse DeleteAssistantThreadResponse
     */
    public function deleteAssistantThread($threadId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteAssistantThreadHeaders([]);

        return $this->deleteAssistantThreadWithOptions($threadId, $headers, $runtime);
    }

    /**
     * @summary 获取AI助理消息列表
     *  *
     * @param string                      $threadId
     * @param ListAssistantMessageRequest $request  ListAssistantMessageRequest
     * @param ListAssistantMessageHeaders $headers  ListAssistantMessageHeaders
     * @param RuntimeOptions              $runtime  runtime options for this request RuntimeOptions
     *
     * @return ListAssistantMessageResponse ListAssistantMessageResponse
     */
    public function listAssistantMessageWithOptions($threadId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->limit)) {
            $query['limit'] = $request->limit;
        }
        if (!Utils::isUnset($request->runId)) {
            $query['runId'] = $request->runId;
        }
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
            'action' => 'ListAssistantMessage',
            'version' => 'assistant_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/assistant/threads/' . $threadId . '/messages',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListAssistantMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取AI助理消息列表
     *  *
     * @param string                      $threadId
     * @param ListAssistantMessageRequest $request  ListAssistantMessageRequest
     *
     * @return ListAssistantMessageResponse ListAssistantMessageResponse
     */
    public function listAssistantMessage($threadId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAssistantMessageHeaders([]);

        return $this->listAssistantMessageWithOptions($threadId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取AI助理的消息体
     *  *
     * @param string                          $threadId
     * @param string                          $messageId
     * @param RetrieveAssistantMessageHeaders $headers   RetrieveAssistantMessageHeaders
     * @param RuntimeOptions                  $runtime   runtime options for this request RuntimeOptions
     *
     * @return RetrieveAssistantMessageResponse RetrieveAssistantMessageResponse
     */
    public function retrieveAssistantMessageWithOptions($threadId, $messageId, $headers, $runtime)
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
            'action' => 'RetrieveAssistantMessage',
            'version' => 'assistant_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/assistant/threads/' . $threadId . '/messages/' . $messageId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RetrieveAssistantMessageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取AI助理的消息体
     *  *
     * @param string $threadId
     * @param string $messageId
     *
     * @return RetrieveAssistantMessageResponse RetrieveAssistantMessageResponse
     */
    public function retrieveAssistantMessage($threadId, $messageId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RetrieveAssistantMessageHeaders([]);

        return $this->retrieveAssistantMessageWithOptions($threadId, $messageId, $headers, $runtime);
    }

    /**
     * @summary 检索AI助理线程实例
     *  *
     * @param string                         $threadId
     * @param RetrieveAssistantThreadHeaders $headers  RetrieveAssistantThreadHeaders
     * @param RuntimeOptions                 $runtime  runtime options for this request RuntimeOptions
     *
     * @return RetrieveAssistantThreadResponse RetrieveAssistantThreadResponse
     */
    public function retrieveAssistantThreadWithOptions($threadId, $headers, $runtime)
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
            'action' => 'RetrieveAssistantThread',
            'version' => 'assistant_2.0',
            'protocol' => 'HTTP',
            'pathname' => '/v2.0/assistant/threads/' . $threadId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RetrieveAssistantThreadResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 检索AI助理线程实例
     *  *
     * @param string $threadId
     *
     * @return RetrieveAssistantThreadResponse RetrieveAssistantThreadResponse
     */
    public function retrieveAssistantThread($threadId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RetrieveAssistantThreadHeaders([]);

        return $this->retrieveAssistantThreadWithOptions($threadId, $headers, $runtime);
    }
}
