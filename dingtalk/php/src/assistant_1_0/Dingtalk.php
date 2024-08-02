<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\AddDomainWordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\AddDomainWordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\AddDomainWordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeleteDomainWordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeleteDomainWordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeleteDomainWordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeleteKnowledgeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeleteKnowledgeRequest;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeleteKnowledgeResponse;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\GetAskDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\GetAskDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\GetAskDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\GetDomainWordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\GetDomainWordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\GetDomainWordsResponse;
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
     * @summary 助理添加专业词汇
     *  *
     * @param AddDomainWordsRequest $request AddDomainWordsRequest
     * @param AddDomainWordsHeaders $headers AddDomainWordsHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return AddDomainWordsResponse AddDomainWordsResponse
     */
    public function addDomainWordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->assistantId)) {
            $body['assistantId'] = $request->assistantId;
        }
        if (!Utils::isUnset($request->domainWords)) {
            $body['domainWords'] = $request->domainWords;
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
            'action'      => 'AddDomainWords',
            'version'     => 'assistant_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/assistant/domainWords',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddDomainWordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 助理添加专业词汇
     *  *
     * @param AddDomainWordsRequest $request AddDomainWordsRequest
     *
     * @return AddDomainWordsResponse AddDomainWordsResponse
     */
    public function addDomainWords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddDomainWordsHeaders([]);

        return $this->addDomainWordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 助理删除专业词汇
     *  *
     * @param DeleteDomainWordsRequest $request DeleteDomainWordsRequest
     * @param DeleteDomainWordsHeaders $headers DeleteDomainWordsHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteDomainWordsResponse DeleteDomainWordsResponse
     */
    public function deleteDomainWordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->assistantId)) {
            $body['assistantId'] = $request->assistantId;
        }
        if (!Utils::isUnset($request->domainWords)) {
            $body['domainWords'] = $request->domainWords;
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
            'action'      => 'DeleteDomainWords',
            'version'     => 'assistant_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/assistant/domainWords/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteDomainWordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 助理删除专业词汇
     *  *
     * @param DeleteDomainWordsRequest $request DeleteDomainWordsRequest
     *
     * @return DeleteDomainWordsResponse DeleteDomainWordsResponse
     */
    public function deleteDomainWords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDomainWordsHeaders([]);

        return $this->deleteDomainWordsWithOptions($request, $headers, $runtime);
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
     * @summary 获取助理问答明细
     *  *
     * @param GetAskDetailRequest $request GetAskDetailRequest
     * @param GetAskDetailHeaders $headers GetAskDetailHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAskDetailResponse GetAskDetailResponse
     */
    public function getAskDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->assistantId)) {
            $query['assistantId'] = $request->assistantId;
        }
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->offset)) {
            $query['offset'] = $request->offset;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
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
            'action'      => 'GetAskDetail',
            'version'     => 'assistant_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/assistant/askDetails',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAskDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取助理问答明细
     *  *
     * @param GetAskDetailRequest $request GetAskDetailRequest
     *
     * @return GetAskDetailResponse GetAskDetailResponse
     */
    public function getAskDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAskDetailHeaders([]);

        return $this->getAskDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取助理专业词汇
     *  *
     * @param GetDomainWordsRequest $request GetDomainWordsRequest
     * @param GetDomainWordsHeaders $headers GetDomainWordsHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDomainWordsResponse GetDomainWordsResponse
     */
    public function getDomainWordsWithOptions($request, $headers, $runtime)
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
            'action'      => 'GetDomainWords',
            'version'     => 'assistant_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/assistant/domainWords',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDomainWordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取助理专业词汇
     *  *
     * @param GetDomainWordsRequest $request GetDomainWordsRequest
     *
     * @return GetDomainWordsResponse GetDomainWordsResponse
     */
    public function getDomainWords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDomainWordsHeaders([]);

        return $this->getDomainWordsWithOptions($request, $headers, $runtime);
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
