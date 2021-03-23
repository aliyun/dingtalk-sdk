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
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\DeleteKnowledgeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\DeleteKnowledgeRequest;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\DeleteKnowledgeResponse;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListUserTeamsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListUserTeamsResponse;
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
}
