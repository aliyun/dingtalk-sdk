<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeleteKnowledgeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeleteKnowledgeRequest;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeleteKnowledgeResponse;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\GetKnowledgeListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\GetKnowledgeListRequest;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\GetKnowledgeListResponse;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\InstallAssistantHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\InstallAssistantRequest;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\InstallAssistantResponse;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\LearnKnowledgeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\LearnKnowledgeRequest;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\LearnKnowledgeResponse;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\RelearnKnowledgeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\RelearnKnowledgeRequest;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\RelearnKnowledgeResponse;
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
     * @summary 删除助理知识
     *  *
     * @param DeleteKnowledgeRequest $request DeleteKnowledgeRequest
     * @param DeleteKnowledgeHeaders $headers DeleteKnowledgeHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteKnowledgeResponse DeleteKnowledgeResponse
     */
    public function deleteKnowledgeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->assistantId)) {
            $query['assistantId'] = $request->assistantId;
        }
        if (!Utils::isUnset($request->studyId)) {
            $query['studyId'] = $request->studyId;
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
            'action'      => 'DeleteKnowledge',
            'version'     => 'assistant_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/assistant/knowledges/items',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteKnowledgeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除助理知识
     *  *
     * @param DeleteKnowledgeRequest $request DeleteKnowledgeRequest
     *
     * @return DeleteKnowledgeResponse DeleteKnowledgeResponse
     */
    public function deleteKnowledge($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteKnowledgeHeaders([]);

        return $this->deleteKnowledgeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取助理知识列表
     *  *
     * @param GetKnowledgeListRequest $request GetKnowledgeListRequest
     * @param GetKnowledgeListHeaders $headers GetKnowledgeListHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetKnowledgeListResponse GetKnowledgeListResponse
     */
    public function getKnowledgeListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->assistantId)) {
            $query['assistantId'] = $request->assistantId;
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
            'action'      => 'GetKnowledgeList',
            'version'     => 'assistant_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/assistant/knowledges/items',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetKnowledgeListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取助理知识列表
     *  *
     * @param GetKnowledgeListRequest $request GetKnowledgeListRequest
     *
     * @return GetKnowledgeListResponse GetKnowledgeListResponse
     */
    public function getKnowledgeList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetKnowledgeListHeaders([]);

        return $this->getKnowledgeListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 安装助理
     *  *
     * @param InstallAssistantRequest $request InstallAssistantRequest
     * @param InstallAssistantHeaders $headers InstallAssistantHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return InstallAssistantResponse InstallAssistantResponse
     */
    public function installAssistantWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->assistantId)) {
            $body['assistantId'] = $request->assistantId;
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
            'action'      => 'InstallAssistant',
            'version'     => 'assistant_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/assistant/install',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InstallAssistantResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 安装助理
     *  *
     * @param InstallAssistantRequest $request InstallAssistantRequest
     *
     * @return InstallAssistantResponse InstallAssistantResponse
     */
    public function installAssistant($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InstallAssistantHeaders([]);

        return $this->installAssistantWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 助理学习知识
     *  *
     * @param LearnKnowledgeRequest $request LearnKnowledgeRequest
     * @param LearnKnowledgeHeaders $headers LearnKnowledgeHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return LearnKnowledgeResponse LearnKnowledgeResponse
     */
    public function learnKnowledgeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->assistantId)) {
            $body['assistantId'] = $request->assistantId;
        }
        if (!Utils::isUnset($request->docUrl)) {
            $body['docUrl'] = $request->docUrl;
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
            'action'      => 'LearnKnowledge',
            'version'     => 'assistant_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/assistant/knowledges/items',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return LearnKnowledgeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 助理学习知识
     *  *
     * @param LearnKnowledgeRequest $request LearnKnowledgeRequest
     *
     * @return LearnKnowledgeResponse LearnKnowledgeResponse
     */
    public function learnKnowledge($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LearnKnowledgeHeaders([]);

        return $this->learnKnowledgeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 助理学习增量知识
     *  *
     * @param RelearnKnowledgeRequest $request RelearnKnowledgeRequest
     * @param RelearnKnowledgeHeaders $headers RelearnKnowledgeHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return RelearnKnowledgeResponse RelearnKnowledgeResponse
     */
    public function relearnKnowledgeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->assistantId)) {
            $body['assistantId'] = $request->assistantId;
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
            'action'      => 'RelearnKnowledge',
            'version'     => 'assistant_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/assistant/knowledges/incrLearning',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RelearnKnowledgeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 助理学习增量知识
     *  *
     * @param RelearnKnowledgeRequest $request RelearnKnowledgeRequest
     *
     * @return RelearnKnowledgeResponse RelearnKnowledgeResponse
     */
    public function relearnKnowledge($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RelearnKnowledgeHeaders([]);

        return $this->relearnKnowledgeWithOptions($request, $headers, $runtime);
    }
}
