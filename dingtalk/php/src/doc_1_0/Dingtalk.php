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
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\AppendRowsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\AppendRowsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\AppendRowsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchGetWorkspaceDocsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchGetWorkspaceDocsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchGetWorkspaceDocsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchGetWorkspacesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchGetWorkspacesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchGetWorkspacesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceDocHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceDocRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceDocResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceDocMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceDocMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceDocMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentEditDocsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentEditDocsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentEditDocsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRelatedWorkspacesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRelatedWorkspacesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRelatedWorkspacesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetWorkspaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetWorkspaceNodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetWorkspaceNodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetWorkspaceNodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetWorkspaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SearchWorkspaceDocsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SearchWorkspaceDocsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SearchWorkspaceDocsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateRangeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateRangeRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateRangeResponse;
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
     * @param BatchGetWorkspaceDocsRequest $request
     *
     * @return BatchGetWorkspaceDocsResponse
     */
    public function batchGetWorkspaceDocs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchGetWorkspaceDocsHeaders([]);

        return $this->batchGetWorkspaceDocsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchGetWorkspaceDocsRequest $request
     * @param BatchGetWorkspaceDocsHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return BatchGetWorkspaceDocsResponse
     */
    public function batchGetWorkspaceDocsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->nodeIds)) {
            @$body['nodeIds'] = $request->nodeIds;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingAccessTokenType)) {
            @$body['dingAccessTokenType'] = $request->dingAccessTokenType;
        }
        if (!Utils::isUnset($request->dingUid)) {
            @$body['dingUid'] = $request->dingUid;
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

        return BatchGetWorkspaceDocsResponse::fromMap($this->doROARequest('BatchGetWorkspaceDocs', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces/docs/infos/query', 'json', $req, $runtime));
    }

    /**
     * @param string             $workbookId
     * @param string             $sheetId
     * @param DeleteSheetRequest $request
     *
     * @return DeleteSheetResponse
     */
    public function deleteSheet($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSheetHeaders([]);

        return $this->deleteSheetWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @param string             $workbookId
     * @param string             $sheetId
     * @param DeleteSheetRequest $request
     * @param DeleteSheetHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return DeleteSheetResponse
     */
    public function deleteSheetWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
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

        return DeleteSheetResponse::fromMap($this->doROARequest('DeleteSheet', 'doc_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '', 'none', $req, $runtime));
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
        $body = [];
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
        $body = [];
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->docType)) {
            @$body['docType'] = $request->docType;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->parentNodeId)) {
            @$body['parentNodeId'] = $request->parentNodeId;
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
     * @param string             $workbookId
     * @param CreateSheetRequest $request
     *
     * @return CreateSheetResponse
     */
    public function createSheet($workbookId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSheetHeaders([]);

        return $this->createSheetWithOptions($workbookId, $request, $headers, $runtime);
    }

    /**
     * @param string             $workbookId
     * @param CreateSheetRequest $request
     * @param CreateSheetHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return CreateSheetResponse
     */
    public function createSheetWithOptions($workbookId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateSheetResponse::fromMap($this->doROARequest('CreateSheet', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets', 'json', $req, $runtime));
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
        $body = [];
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

    /**
     * @param string $workspaceId
     *
     * @return GetWorkspaceResponse
     */
    public function getWorkspace($workspaceId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetWorkspaceHeaders([]);

        return $this->getWorkspaceWithOptions($workspaceId, $headers, $runtime);
    }

    /**
     * @param string              $workspaceId
     * @param GetWorkspaceHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetWorkspaceResponse
     */
    public function getWorkspaceWithOptions($workspaceId, $headers, $runtime)
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

        return GetWorkspaceResponse::fromMap($this->doROARequest('GetWorkspace', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '', 'json', $req, $runtime));
    }

    /**
     * @param SearchWorkspaceDocsRequest $request
     *
     * @return SearchWorkspaceDocsResponse
     */
    public function searchWorkspaceDocs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchWorkspaceDocsHeaders([]);

        return $this->searchWorkspaceDocsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchWorkspaceDocsRequest $request
     * @param SearchWorkspaceDocsHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return SearchWorkspaceDocsResponse
     */
    public function searchWorkspaceDocsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->workspaceId)) {
            @$query['workspaceId'] = $request->workspaceId;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->keyword)) {
            @$query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
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

        return SearchWorkspaceDocsResponse::fromMap($this->doROARequest('SearchWorkspaceDocs', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/docs', 'json', $req, $runtime));
    }

    /**
     * @param string             $workbookId
     * @param string             $sheetId
     * @param string             $rangeAddress
     * @param UpdateRangeRequest $request
     *
     * @return UpdateRangeResponse
     */
    public function updateRange($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRangeHeaders([]);

        return $this->updateRangeWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @param string             $workbookId
     * @param string             $sheetId
     * @param string             $rangeAddress
     * @param UpdateRangeRequest $request
     * @param UpdateRangeHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return UpdateRangeResponse
     */
    public function updateRangeWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->values)) {
            @$body['values'] = $request->values;
        }
        if (!Utils::isUnset($request->backgroundColors)) {
            @$body['backgroundColors'] = $request->backgroundColors;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateRangeResponse::fromMap($this->doROARequest('UpdateRange', 'doc_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '', 'none', $req, $runtime));
    }

    /**
     * @param BatchGetWorkspacesRequest $request
     *
     * @return BatchGetWorkspacesResponse
     */
    public function batchGetWorkspaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchGetWorkspacesHeaders([]);

        return $this->batchGetWorkspacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchGetWorkspacesRequest $request
     * @param BatchGetWorkspacesHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return BatchGetWorkspacesResponse
     */
    public function batchGetWorkspacesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->includeRecent)) {
            @$body['includeRecent'] = $request->includeRecent;
        }
        if (!Utils::isUnset($request->workspaceIds)) {
            @$body['workspaceIds'] = $request->workspaceIds;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
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

        return BatchGetWorkspacesResponse::fromMap($this->doROARequest('BatchGetWorkspaces', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces/infos/query', 'json', $req, $runtime));
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
        $body = [];
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
        $body = [];
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
        $body = [];
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
     * @param string          $workbookId
     * @param string          $sheetId
     * @param GetSheetRequest $request
     *
     * @return GetSheetResponse
     */
    public function getSheet($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSheetHeaders([]);

        return $this->getSheetWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @param string          $workbookId
     * @param string          $sheetId
     * @param GetSheetRequest $request
     * @param GetSheetHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return GetSheetResponse
     */
    public function getSheetWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
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

        return GetSheetResponse::fromMap($this->doROARequest('GetSheet', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '', 'json', $req, $runtime));
    }

    /**
     * @param GetRelatedWorkspacesRequest $request
     *
     * @return GetRelatedWorkspacesResponse
     */
    public function getRelatedWorkspaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRelatedWorkspacesHeaders([]);

        return $this->getRelatedWorkspacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetRelatedWorkspacesRequest $request
     * @param GetRelatedWorkspacesHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetRelatedWorkspacesResponse
     */
    public function getRelatedWorkspacesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->includeRecent)) {
            @$query['includeRecent'] = $request->includeRecent;
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

        return GetRelatedWorkspacesResponse::fromMap($this->doROARequest('GetRelatedWorkspaces', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/workspaces', 'json', $req, $runtime));
    }

    /**
     * @param GetRecentEditDocsRequest $request
     *
     * @return GetRecentEditDocsResponse
     */
    public function getRecentEditDocs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRecentEditDocsHeaders([]);

        return $this->getRecentEditDocsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetRecentEditDocsRequest $request
     * @param GetRecentEditDocsHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetRecentEditDocsResponse
     */
    public function getRecentEditDocsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
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

        return GetRecentEditDocsResponse::fromMap($this->doROARequest('GetRecentEditDocs', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/workspaces/docs/recentEditDocs', 'json', $req, $runtime));
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
        $body = [];
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

        return AddWorkspaceMembersResponse::fromMap($this->doROARequest('AddWorkspaceMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/members', 'json', $req, $runtime));
    }

    /**
     * @param string                  $workspaceId
     * @param string                  $nodeId
     * @param GetWorkspaceNodeRequest $request
     *
     * @return GetWorkspaceNodeResponse
     */
    public function getWorkspaceNode($workspaceId, $nodeId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetWorkspaceNodeHeaders([]);

        return $this->getWorkspaceNodeWithOptions($workspaceId, $nodeId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $workspaceId
     * @param string                  $nodeId
     * @param GetWorkspaceNodeRequest $request
     * @param GetWorkspaceNodeHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetWorkspaceNodeResponse
     */
    public function getWorkspaceNodeWithOptions($workspaceId, $nodeId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
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

        return GetWorkspaceNodeResponse::fromMap($this->doROARequest('GetWorkspaceNode', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/docs/' . $nodeId . '', 'json', $req, $runtime));
    }

    /**
     * @param string            $workbookId
     * @param string            $sheetId
     * @param AppendRowsRequest $request
     *
     * @return AppendRowsResponse
     */
    public function appendRows($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AppendRowsHeaders([]);

        return $this->appendRowsWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @param string            $workbookId
     * @param string            $sheetId
     * @param AppendRowsRequest $request
     * @param AppendRowsHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return AppendRowsResponse
     */
    public function appendRowsWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->values)) {
            @$body['values'] = $request->values;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AppendRowsResponse::fromMap($this->doROARequest('AppendRows', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/appendRows', 'none', $req, $runtime));
    }
}
