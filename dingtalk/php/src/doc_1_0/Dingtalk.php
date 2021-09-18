<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\AddWorkspaceDocMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\AddWorkspaceDocMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\AddWorkspaceDocMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\AddWorkspaceMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\AddWorkspaceMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\AddWorkspaceMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceDocHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceDocRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceDocResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceDocMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceDocMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceDocMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateWorkspaceDocMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateWorkspaceDocMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateWorkspaceDocMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateWorkspaceMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateWorkspaceMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateWorkspaceMembersResponse;
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
     * @param string                        $workspaceId
     * @param DeleteWorkspaceMembersRequest $request
     *
     * @return DeleteWorkspaceMembersResponse
     */
    public function deleteWorkspaceMembers($workspaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteWorkspaceMembersHeaders([]);

        return $this->deleteWorkspaceMembersWithOptions($workspaceId, $request, $headers, $runtime);
    }

    /**
     * @param string                        $workspaceId
     * @param DeleteWorkspaceMembersRequest $request
     * @param DeleteWorkspaceMembersHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return DeleteWorkspaceMembersResponse
     */
    public function deleteWorkspaceMembersWithOptions($workspaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workspaceId = OpenApiUtilClient::getEncodeParam($workspaceId);
        $body        = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
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

        return DeleteWorkspaceMembersResponse::fromMap($this->doROARequest('DeleteWorkspaceMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/members/remove', 'none', $req, $runtime));
    }

    /**
     * @param string                        $workspaceId
     * @param string                        $nodeId
     * @param AddWorkspaceDocMembersRequest $request
     *
     * @return AddWorkspaceDocMembersResponse
     */
    public function addWorkspaceDocMembers($workspaceId, $nodeId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddWorkspaceDocMembersHeaders([]);

        return $this->addWorkspaceDocMembersWithOptions($workspaceId, $nodeId, $request, $headers, $runtime);
    }

    /**
     * @param string                        $workspaceId
     * @param string                        $nodeId
     * @param AddWorkspaceDocMembersRequest $request
     * @param AddWorkspaceDocMembersHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return AddWorkspaceDocMembersResponse
     */
    public function addWorkspaceDocMembersWithOptions($workspaceId, $nodeId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workspaceId = OpenApiUtilClient::getEncodeParam($workspaceId);
        $nodeId      = OpenApiUtilClient::getEncodeParam($nodeId);
        $body        = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
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

        return AddWorkspaceDocMembersResponse::fromMap($this->doROARequest('AddWorkspaceDocMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/docs/' . $nodeId . '/members', 'none', $req, $runtime));
    }

    /**
     * @param string                        $workspaceId
     * @param UpdateWorkspaceMembersRequest $request
     *
     * @return UpdateWorkspaceMembersResponse
     */
    public function updateWorkspaceMembers($workspaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateWorkspaceMembersHeaders([]);

        return $this->updateWorkspaceMembersWithOptions($workspaceId, $request, $headers, $runtime);
    }

    /**
     * @param string                        $workspaceId
     * @param UpdateWorkspaceMembersRequest $request
     * @param UpdateWorkspaceMembersHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return UpdateWorkspaceMembersResponse
     */
    public function updateWorkspaceMembersWithOptions($workspaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workspaceId = OpenApiUtilClient::getEncodeParam($workspaceId);
        $body        = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
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

        return UpdateWorkspaceMembersResponse::fromMap($this->doROARequest('UpdateWorkspaceMembers', 'doc_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/members', 'none', $req, $runtime));
    }

    /**
     * @param string                           $workspaceId
     * @param string                           $nodeId
     * @param UpdateWorkspaceDocMembersRequest $request
     *
     * @return UpdateWorkspaceDocMembersResponse
     */
    public function updateWorkspaceDocMembers($workspaceId, $nodeId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateWorkspaceDocMembersHeaders([]);

        return $this->updateWorkspaceDocMembersWithOptions($workspaceId, $nodeId, $request, $headers, $runtime);
    }

    /**
     * @param string                           $workspaceId
     * @param string                           $nodeId
     * @param UpdateWorkspaceDocMembersRequest $request
     * @param UpdateWorkspaceDocMembersHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return UpdateWorkspaceDocMembersResponse
     */
    public function updateWorkspaceDocMembersWithOptions($workspaceId, $nodeId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workspaceId = OpenApiUtilClient::getEncodeParam($workspaceId);
        $nodeId      = OpenApiUtilClient::getEncodeParam($nodeId);
        $body        = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
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

        return UpdateWorkspaceDocMembersResponse::fromMap($this->doROARequest('UpdateWorkspaceDocMembers', 'doc_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/docs/' . $nodeId . '/members', 'none', $req, $runtime));
    }

    /**
     * @param string                    $workspaceId
     * @param CreateWorkspaceDocRequest $request
     *
     * @return CreateWorkspaceDocResponse
     */
    public function createWorkspaceDoc($workspaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateWorkspaceDocHeaders([]);

        return $this->createWorkspaceDocWithOptions($workspaceId, $request, $headers, $runtime);
    }

    /**
     * @param string                    $workspaceId
     * @param CreateWorkspaceDocRequest $request
     * @param CreateWorkspaceDocHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return CreateWorkspaceDocResponse
     */
    public function createWorkspaceDocWithOptions($workspaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workspaceId = OpenApiUtilClient::getEncodeParam($workspaceId);
        $body        = [];
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->docType)) {
            @$body['docType'] = $request->docType;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
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

        return CreateWorkspaceDocResponse::fromMap($this->doROARequest('CreateWorkspaceDoc', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/docs', 'json', $req, $runtime));
    }

    /**
     * @param string                     $workspaceId
     * @param AddWorkspaceMembersRequest $request
     *
     * @return AddWorkspaceMembersResponse
     */
    public function addWorkspaceMembers($workspaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddWorkspaceMembersHeaders([]);

        return $this->addWorkspaceMembersWithOptions($workspaceId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $workspaceId
     * @param AddWorkspaceMembersRequest $request
     * @param AddWorkspaceMembersHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return AddWorkspaceMembersResponse
     */
    public function addWorkspaceMembersWithOptions($workspaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workspaceId = OpenApiUtilClient::getEncodeParam($workspaceId);
        $body        = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
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

        return AddWorkspaceMembersResponse::fromMap($this->doROARequest('AddWorkspaceMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/members', 'none', $req, $runtime));
    }

    /**
     * @param CreateWorkspaceRequest $request
     *
     * @return CreateWorkspaceResponse
     */
    public function createWorkspace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateWorkspaceHeaders([]);

        return $this->createWorkspaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateWorkspaceRequest $request
     * @param CreateWorkspaceHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return CreateWorkspaceResponse
     */
    public function createWorkspaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingUid)) {
            @$body['dingUid'] = $request->dingUid;
        }
        if (!Utils::isUnset($request->dingAccessTokenType)) {
            @$body['dingAccessTokenType'] = $request->dingAccessTokenType;
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

        return CreateWorkspaceResponse::fromMap($this->doROARequest('CreateWorkspace', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces', 'json', $req, $runtime));
    }

    /**
     * @param string                           $workspaceId
     * @param string                           $nodeId
     * @param DeleteWorkspaceDocMembersRequest $request
     *
     * @return DeleteWorkspaceDocMembersResponse
     */
    public function deleteWorkspaceDocMembers($workspaceId, $nodeId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteWorkspaceDocMembersHeaders([]);

        return $this->deleteWorkspaceDocMembersWithOptions($workspaceId, $nodeId, $request, $headers, $runtime);
    }

    /**
     * @param string                           $workspaceId
     * @param string                           $nodeId
     * @param DeleteWorkspaceDocMembersRequest $request
     * @param DeleteWorkspaceDocMembersHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return DeleteWorkspaceDocMembersResponse
     */
    public function deleteWorkspaceDocMembersWithOptions($workspaceId, $nodeId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workspaceId = OpenApiUtilClient::getEncodeParam($workspaceId);
        $nodeId      = OpenApiUtilClient::getEncodeParam($nodeId);
        $body        = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
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

        return DeleteWorkspaceDocMembersResponse::fromMap($this->doROARequest('DeleteWorkspaceDocMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/docs/' . $nodeId . '/members/remove', 'none', $req, $runtime));
    }
}
