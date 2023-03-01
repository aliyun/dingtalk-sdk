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
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BindCoolAppToSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BindCoolAppToSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BindCoolAppToSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\ClearDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\ClearDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\ClearDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\ClearHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\ClearRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\ClearResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateConditionalFormattingRuleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateConditionalFormattingRuleRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateConditionalFormattingRuleResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateDeveloperMetadataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateDeveloperMetadataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateDeveloperMetadataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateRangeProtectionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateRangeProtectionRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateRangeProtectionResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceDocHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceDocRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceDocResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateWorkspaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteColumnsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteColumnsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteColumnsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteDropdownListsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteDropdownListsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteDropdownListsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteRangeProtectionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteRangeProtectionRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteRangeProtectionResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteRowsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteRowsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteRowsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceDocHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceDocMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceDocMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceDocMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceDocRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceDocResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DeleteWorkspaceMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetAllSheetsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetAllSheetsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetAllSheetsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetDeveloperMetadataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetDeveloperMetadataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetDeveloperMetadataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRangeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRangeRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRangeResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentEditDocsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentEditDocsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentEditDocsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentOpenDocsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentOpenDocsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentOpenDocsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRelatedWorkspacesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRelatedWorkspacesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRelatedWorkspacesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetTemplateByIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetTemplateByIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetTemplateByIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetWorkspaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetWorkspaceNodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetWorkspaceNodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetWorkspaceNodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetWorkspaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertColumnsBeforeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertColumnsBeforeRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertColumnsBeforeResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertDropdownListsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertDropdownListsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertDropdownListsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertRowsBeforeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertRowsBeforeRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertRowsBeforeResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\ListTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\ListTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\ListTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\MergeRangeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\MergeRangeRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\MergeRangeResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\RangeFindNextHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\RangeFindNextRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\RangeFindNextResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SearchWorkspaceDocsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SearchWorkspaceDocsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SearchWorkspaceDocsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetColumnsVisibilityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetColumnsVisibilityRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetColumnsVisibilityResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetRowsVisibilityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetRowsVisibilityRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetRowsVisibilityResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SheetAutofitRowsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SheetAutofitRowsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SheetAutofitRowsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SheetFindAllHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SheetFindAllRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SheetFindAllResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UnbindCoolAppToSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UnbindCoolAppToSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UnbindCoolAppToSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateRangeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateRangeRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateRangeResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateSheetResponse;
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
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AddWorkspaceDocMembersResponse::fromMap($this->doROARequest('AddWorkspaceDocMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/docs/' . $nodeId . '/members', 'none', $req, $runtime));
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
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AddWorkspaceMembersResponse::fromMap($this->doROARequest('AddWorkspaceMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/members', 'json', $req, $runtime));
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
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId    = OpenApiUtilClient::getEncodeParam($sheetId);
        $query      = [];
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
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AppendRowsResponse::fromMap($this->doROARequest('AppendRows', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/appendRows', 'none', $req, $runtime));
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
        if (!Utils::isUnset($request->nodeIds)) {
            @$body['nodeIds'] = $request->nodeIds;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BatchGetWorkspaceDocsResponse::fromMap($this->doROARequest('BatchGetWorkspaceDocs', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces/docs/infos/query', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->includeRecent)) {
            @$body['includeRecent'] = $request->includeRecent;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->workspaceIds)) {
            @$body['workspaceIds'] = $request->workspaceIds;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BatchGetWorkspacesResponse::fromMap($this->doROARequest('BatchGetWorkspaces', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces/infos/query', 'json', $req, $runtime));
    }

    /**
     * @param string                    $workbookId
     * @param BindCoolAppToSheetRequest $request
     *
     * @return BindCoolAppToSheetResponse
     */
    public function bindCoolAppToSheet($workbookId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BindCoolAppToSheetHeaders([]);

        return $this->bindCoolAppToSheetWithOptions($workbookId, $request, $headers, $runtime);
    }

    /**
     * @param string                    $workbookId
     * @param BindCoolAppToSheetRequest $request
     * @param BindCoolAppToSheetHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return BindCoolAppToSheetResponse
     */
    public function bindCoolAppToSheetWithOptions($workbookId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $query      = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->coolAppCode)) {
            @$body['coolAppCode'] = $request->coolAppCode;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BindCoolAppToSheetResponse::fromMap($this->doROARequest('BindCoolAppToSheet', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/coolApps', 'json', $req, $runtime));
    }

    /**
     * @param string       $workbookId
     * @param string       $sheetId
     * @param string       $rangeAddress
     * @param ClearRequest $request
     *
     * @return ClearResponse
     */
    public function clear($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ClearHeaders([]);

        return $this->clearWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @param string         $workbookId
     * @param string         $sheetId
     * @param string         $rangeAddress
     * @param ClearRequest   $request
     * @param ClearHeaders   $headers
     * @param RuntimeOptions $runtime
     *
     * @return ClearResponse
     */
    public function clearWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId   = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId      = OpenApiUtilClient::getEncodeParam($sheetId);
        $rangeAddress = OpenApiUtilClient::getEncodeParam($rangeAddress);
        $query        = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ClearResponse::fromMap($this->doROARequest('Clear', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '/clear', 'json', $req, $runtime));
    }

    /**
     * @param string           $workbookId
     * @param string           $sheetId
     * @param string           $rangeAddress
     * @param ClearDataRequest $request
     *
     * @return ClearDataResponse
     */
    public function clearData($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ClearDataHeaders([]);

        return $this->clearDataWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @param string           $workbookId
     * @param string           $sheetId
     * @param string           $rangeAddress
     * @param ClearDataRequest $request
     * @param ClearDataHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return ClearDataResponse
     */
    public function clearDataWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId   = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId      = OpenApiUtilClient::getEncodeParam($sheetId);
        $rangeAddress = OpenApiUtilClient::getEncodeParam($rangeAddress);
        $query        = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ClearDataResponse::fromMap($this->doROARequest('ClearData', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '/clearData', 'json', $req, $runtime));
    }

    /**
     * @param string                                 $workbookId
     * @param string                                 $sheetId
     * @param CreateConditionalFormattingRuleRequest $request
     *
     * @return CreateConditionalFormattingRuleResponse
     */
    public function createConditionalFormattingRule($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateConditionalFormattingRuleHeaders([]);

        return $this->createConditionalFormattingRuleWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @param string                                 $workbookId
     * @param string                                 $sheetId
     * @param CreateConditionalFormattingRuleRequest $request
     * @param CreateConditionalFormattingRuleHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return CreateConditionalFormattingRuleResponse
     */
    public function createConditionalFormattingRuleWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId    = OpenApiUtilClient::getEncodeParam($sheetId);
        $query      = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->cellStyle)) {
            @$body['cellStyle'] = $request->cellStyle;
        }
        if (!Utils::isUnset($request->duplicateCondition)) {
            @$body['duplicateCondition'] = $request->duplicateCondition;
        }
        if (!Utils::isUnset($request->ranges)) {
            @$body['ranges'] = $request->ranges;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateConditionalFormattingRuleResponse::fromMap($this->doROARequest('CreateConditionalFormattingRule', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/conditionalFormattingRules', 'json', $req, $runtime));
    }

    /**
     * @param string                         $workbookId
     * @param CreateDeveloperMetadataRequest $request
     *
     * @return CreateDeveloperMetadataResponse
     */
    public function createDeveloperMetadata($workbookId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDeveloperMetadataHeaders([]);

        return $this->createDeveloperMetadataWithOptions($workbookId, $request, $headers, $runtime);
    }

    /**
     * @param string                         $workbookId
     * @param CreateDeveloperMetadataRequest $request
     * @param CreateDeveloperMetadataHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return CreateDeveloperMetadataResponse
     */
    public function createDeveloperMetadataWithOptions($workbookId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $query      = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->associatedColumn)) {
            @$body['associatedColumn'] = $request->associatedColumn;
        }
        if (!Utils::isUnset($request->associatedRow)) {
            @$body['associatedRow'] = $request->associatedRow;
        }
        if (!Utils::isUnset($request->value)) {
            @$body['value'] = $request->value;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateDeveloperMetadataResponse::fromMap($this->doROARequest('CreateDeveloperMetadata', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/developerMetadatas', 'json', $req, $runtime));
    }

    /**
     * @param string                       $workbookId
     * @param string                       $sheetId
     * @param string                       $rangeAddress
     * @param CreateRangeProtectionRequest $request
     *
     * @return CreateRangeProtectionResponse
     */
    public function createRangeProtection($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateRangeProtectionHeaders([]);

        return $this->createRangeProtectionWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @param string                       $workbookId
     * @param string                       $sheetId
     * @param string                       $rangeAddress
     * @param CreateRangeProtectionRequest $request
     * @param CreateRangeProtectionHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return CreateRangeProtectionResponse
     */
    public function createRangeProtectionWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId   = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId      = OpenApiUtilClient::getEncodeParam($sheetId);
        $rangeAddress = OpenApiUtilClient::getEncodeParam($rangeAddress);
        $query        = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->editableSetting)) {
            @$body['editableSetting'] = $request->editableSetting;
        }
        if (!Utils::isUnset($request->otherUserPermission)) {
            @$body['otherUserPermission'] = $request->otherUserPermission;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateRangeProtectionResponse::fromMap($this->doROARequest('CreateRangeProtection', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '/protections', 'json', $req, $runtime));
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
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $query      = [];
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
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
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
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateWorkspaceResponse::fromMap($this->doROARequest('CreateWorkspace', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->docType)) {
            @$body['docType'] = $request->docType;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->parentNodeId)) {
            @$body['parentNodeId'] = $request->parentNodeId;
        }
        if (!Utils::isUnset($request->templateId)) {
            @$body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->templateType)) {
            @$body['templateType'] = $request->templateType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateWorkspaceDocResponse::fromMap($this->doROARequest('CreateWorkspaceDoc', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/docs', 'json', $req, $runtime));
    }

    /**
     * @param string               $workbookId
     * @param string               $sheetId
     * @param DeleteColumnsRequest $request
     *
     * @return DeleteColumnsResponse
     */
    public function deleteColumns($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteColumnsHeaders([]);

        return $this->deleteColumnsWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @param string               $workbookId
     * @param string               $sheetId
     * @param DeleteColumnsRequest $request
     * @param DeleteColumnsHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return DeleteColumnsResponse
     */
    public function deleteColumnsWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId    = OpenApiUtilClient::getEncodeParam($sheetId);
        $query      = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->column)) {
            @$body['column'] = $request->column;
        }
        if (!Utils::isUnset($request->columnCount)) {
            @$body['columnCount'] = $request->columnCount;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return DeleteColumnsResponse::fromMap($this->doROARequest('DeleteColumns', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/deleteColumns', 'json', $req, $runtime));
    }

    /**
     * @param string                     $workbookId
     * @param string                     $sheetId
     * @param string                     $rangeAddress
     * @param DeleteDropdownListsRequest $request
     *
     * @return DeleteDropdownListsResponse
     */
    public function deleteDropdownLists($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDropdownListsHeaders([]);

        return $this->deleteDropdownListsWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @param string                     $workbookId
     * @param string                     $sheetId
     * @param string                     $rangeAddress
     * @param DeleteDropdownListsRequest $request
     * @param DeleteDropdownListsHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return DeleteDropdownListsResponse
     */
    public function deleteDropdownListsWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId   = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId      = OpenApiUtilClient::getEncodeParam($sheetId);
        $rangeAddress = OpenApiUtilClient::getEncodeParam($rangeAddress);
        $query        = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteDropdownListsResponse::fromMap($this->doROARequest('DeleteDropdownLists', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '/deleteDropdownLists', 'json', $req, $runtime));
    }

    /**
     * @param string                       $workbookId
     * @param string                       $sheetId
     * @param string                       $rangeAddress
     * @param string                       $protectionId
     * @param DeleteRangeProtectionRequest $request
     *
     * @return DeleteRangeProtectionResponse
     */
    public function deleteRangeProtection($workbookId, $sheetId, $rangeAddress, $protectionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRangeProtectionHeaders([]);

        return $this->deleteRangeProtectionWithOptions($workbookId, $sheetId, $rangeAddress, $protectionId, $request, $headers, $runtime);
    }

    /**
     * @param string                       $workbookId
     * @param string                       $sheetId
     * @param string                       $rangeAddress
     * @param string                       $protectionId
     * @param DeleteRangeProtectionRequest $request
     * @param DeleteRangeProtectionHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return DeleteRangeProtectionResponse
     */
    public function deleteRangeProtectionWithOptions($workbookId, $sheetId, $rangeAddress, $protectionId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId   = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId      = OpenApiUtilClient::getEncodeParam($sheetId);
        $rangeAddress = OpenApiUtilClient::getEncodeParam($rangeAddress);
        $protectionId = OpenApiUtilClient::getEncodeParam($protectionId);
        $query        = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteRangeProtectionResponse::fromMap($this->doROARequest('DeleteRangeProtection', 'doc_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '/protections/' . $protectionId . '', 'json', $req, $runtime));
    }

    /**
     * @param string            $workbookId
     * @param string            $sheetId
     * @param DeleteRowsRequest $request
     *
     * @return DeleteRowsResponse
     */
    public function deleteRows($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRowsHeaders([]);

        return $this->deleteRowsWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @param string            $workbookId
     * @param string            $sheetId
     * @param DeleteRowsRequest $request
     * @param DeleteRowsHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return DeleteRowsResponse
     */
    public function deleteRowsWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId    = OpenApiUtilClient::getEncodeParam($sheetId);
        $query      = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->row)) {
            @$body['row'] = $request->row;
        }
        if (!Utils::isUnset($request->rowCount)) {
            @$body['rowCount'] = $request->rowCount;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return DeleteRowsResponse::fromMap($this->doROARequest('DeleteRows', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/deleteRows', 'json', $req, $runtime));
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
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId    = OpenApiUtilClient::getEncodeParam($sheetId);
        $query      = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteSheetResponse::fromMap($this->doROARequest('DeleteSheet', 'doc_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                    $workspaceId
     * @param string                    $nodeId
     * @param DeleteWorkspaceDocRequest $request
     *
     * @return DeleteWorkspaceDocResponse
     */
    public function deleteWorkspaceDoc($workspaceId, $nodeId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteWorkspaceDocHeaders([]);

        return $this->deleteWorkspaceDocWithOptions($workspaceId, $nodeId, $request, $headers, $runtime);
    }

    /**
     * @param string                    $workspaceId
     * @param string                    $nodeId
     * @param DeleteWorkspaceDocRequest $request
     * @param DeleteWorkspaceDocHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return DeleteWorkspaceDocResponse
     */
    public function deleteWorkspaceDocWithOptions($workspaceId, $nodeId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workspaceId = OpenApiUtilClient::getEncodeParam($workspaceId);
        $nodeId      = OpenApiUtilClient::getEncodeParam($nodeId);
        $query       = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return DeleteWorkspaceDocResponse::fromMap($this->doROARequest('DeleteWorkspaceDoc', 'doc_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/docs/' . $nodeId . '', 'none', $req, $runtime));
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
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return DeleteWorkspaceDocMembersResponse::fromMap($this->doROARequest('DeleteWorkspaceDocMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/docs/' . $nodeId . '/members/remove', 'none', $req, $runtime));
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
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return DeleteWorkspaceMembersResponse::fromMap($this->doROARequest('DeleteWorkspaceMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/members/remove', 'none', $req, $runtime));
    }

    /**
     * @param string              $workbookId
     * @param GetAllSheetsRequest $request
     *
     * @return GetAllSheetsResponse
     */
    public function getAllSheets($workbookId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllSheetsHeaders([]);

        return $this->getAllSheetsWithOptions($workbookId, $request, $headers, $runtime);
    }

    /**
     * @param string              $workbookId
     * @param GetAllSheetsRequest $request
     * @param GetAllSheetsHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return GetAllSheetsResponse
     */
    public function getAllSheetsWithOptions($workbookId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $query      = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetAllSheetsResponse::fromMap($this->doROARequest('GetAllSheets', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets', 'json', $req, $runtime));
    }

    /**
     * @param string                      $workbookId
     * @param string                      $developerMetadataId
     * @param GetDeveloperMetadataRequest $request
     *
     * @return GetDeveloperMetadataResponse
     */
    public function getDeveloperMetadata($workbookId, $developerMetadataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDeveloperMetadataHeaders([]);

        return $this->getDeveloperMetadataWithOptions($workbookId, $developerMetadataId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $workbookId
     * @param string                      $developerMetadataId
     * @param GetDeveloperMetadataRequest $request
     * @param GetDeveloperMetadataHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetDeveloperMetadataResponse
     */
    public function getDeveloperMetadataWithOptions($workbookId, $developerMetadataId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId          = OpenApiUtilClient::getEncodeParam($workbookId);
        $developerMetadataId = OpenApiUtilClient::getEncodeParam($developerMetadataId);
        $query               = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetDeveloperMetadataResponse::fromMap($this->doROARequest('GetDeveloperMetadata', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/developerMetadatas/' . $developerMetadataId . '', 'json', $req, $runtime));
    }

    /**
     * @param string          $workbookId
     * @param string          $sheetId
     * @param string          $rangeAddress
     * @param GetRangeRequest $request
     *
     * @return GetRangeResponse
     */
    public function getRange($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRangeHeaders([]);

        return $this->getRangeWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @param string          $workbookId
     * @param string          $sheetId
     * @param string          $rangeAddress
     * @param GetRangeRequest $request
     * @param GetRangeHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return GetRangeResponse
     */
    public function getRangeWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId   = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId      = OpenApiUtilClient::getEncodeParam($sheetId);
        $rangeAddress = OpenApiUtilClient::getEncodeParam($rangeAddress);
        $query        = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->select)) {
            @$query['select'] = $request->select;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetRangeResponse::fromMap($this->doROARequest('GetRange', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetRecentEditDocsResponse::fromMap($this->doROARequest('GetRecentEditDocs', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/workspaces/docs/recentEditDocs', 'json', $req, $runtime));
    }

    /**
     * @param GetRecentOpenDocsRequest $request
     *
     * @return GetRecentOpenDocsResponse
     */
    public function getRecentOpenDocs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRecentOpenDocsHeaders([]);

        return $this->getRecentOpenDocsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetRecentOpenDocsRequest $request
     * @param GetRecentOpenDocsHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetRecentOpenDocsResponse
     */
    public function getRecentOpenDocsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetRecentOpenDocsResponse::fromMap($this->doROARequest('GetRecentOpenDocs', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/workspaces/docs/recentOpenDocs', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->includeRecent)) {
            @$query['includeRecent'] = $request->includeRecent;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetRelatedWorkspacesResponse::fromMap($this->doROARequest('GetRelatedWorkspaces', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/workspaces', 'json', $req, $runtime));
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
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId    = OpenApiUtilClient::getEncodeParam($sheetId);
        $query      = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetSheetResponse::fromMap($this->doROARequest('GetSheet', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                 $templateId
     * @param GetTemplateByIdRequest $request
     *
     * @return GetTemplateByIdResponse
     */
    public function getTemplateById($templateId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTemplateByIdHeaders([]);

        return $this->getTemplateByIdWithOptions($templateId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $templateId
     * @param GetTemplateByIdRequest $request
     * @param GetTemplateByIdHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetTemplateByIdResponse
     */
    public function getTemplateByIdWithOptions($templateId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $templateId = OpenApiUtilClient::getEncodeParam($templateId);
        $query      = [];
        if (!Utils::isUnset($request->belong)) {
            @$query['belong'] = $request->belong;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetTemplateByIdResponse::fromMap($this->doROARequest('GetTemplateById', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/templates/' . $templateId . '', 'json', $req, $runtime));
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
        $workspaceId = OpenApiUtilClient::getEncodeParam($workspaceId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetWorkspaceResponse::fromMap($this->doROARequest('GetWorkspace', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '', 'json', $req, $runtime));
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
        $workspaceId = OpenApiUtilClient::getEncodeParam($workspaceId);
        $nodeId      = OpenApiUtilClient::getEncodeParam($nodeId);
        $query       = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetWorkspaceNodeResponse::fromMap($this->doROARequest('GetWorkspaceNode', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/docs/' . $nodeId . '', 'json', $req, $runtime));
    }

    /**
     * @param string              $documentId
     * @param InsertBlocksRequest $request
     *
     * @return InsertBlocksResponse
     */
    public function insertBlocks($documentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertBlocksHeaders([]);

        return $this->insertBlocksWithOptions($documentId, $request, $headers, $runtime);
    }

    /**
     * @param string              $documentId
     * @param InsertBlocksRequest $request
     * @param InsertBlocksHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return InsertBlocksResponse
     */
    public function insertBlocksWithOptions($documentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $documentId = OpenApiUtilClient::getEncodeParam($documentId);
        $body       = [];
        if (!Utils::isUnset($request->blocks)) {
            @$body['blocks'] = $request->blocks;
        }
        if (!Utils::isUnset($request->location)) {
            @$body['location'] = $request->location;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return InsertBlocksResponse::fromMap($this->doROARequest('InsertBlocks', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/documents/' . $documentId . '/blocks', 'none', $req, $runtime));
    }

    /**
     * @param string                     $workbookId
     * @param string                     $sheetId
     * @param InsertColumnsBeforeRequest $request
     *
     * @return InsertColumnsBeforeResponse
     */
    public function insertColumnsBefore($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertColumnsBeforeHeaders([]);

        return $this->insertColumnsBeforeWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $workbookId
     * @param string                     $sheetId
     * @param InsertColumnsBeforeRequest $request
     * @param InsertColumnsBeforeHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return InsertColumnsBeforeResponse
     */
    public function insertColumnsBeforeWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId    = OpenApiUtilClient::getEncodeParam($sheetId);
        $query      = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->column)) {
            @$body['column'] = $request->column;
        }
        if (!Utils::isUnset($request->columnCount)) {
            @$body['columnCount'] = $request->columnCount;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return InsertColumnsBeforeResponse::fromMap($this->doROARequest('InsertColumnsBefore', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/insertColumnsBefore', 'json', $req, $runtime));
    }

    /**
     * @param string                     $workbookId
     * @param string                     $sheetId
     * @param string                     $rangeAddress
     * @param InsertDropdownListsRequest $request
     *
     * @return InsertDropdownListsResponse
     */
    public function insertDropdownLists($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertDropdownListsHeaders([]);

        return $this->insertDropdownListsWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @param string                     $workbookId
     * @param string                     $sheetId
     * @param string                     $rangeAddress
     * @param InsertDropdownListsRequest $request
     * @param InsertDropdownListsHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return InsertDropdownListsResponse
     */
    public function insertDropdownListsWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId   = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId      = OpenApiUtilClient::getEncodeParam($sheetId);
        $rangeAddress = OpenApiUtilClient::getEncodeParam($rangeAddress);
        $query        = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->options)) {
            @$body['options'] = $request->options;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return InsertDropdownListsResponse::fromMap($this->doROARequest('InsertDropdownLists', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '/insertDropdownLists', 'json', $req, $runtime));
    }

    /**
     * @param string                  $workbookId
     * @param string                  $sheetId
     * @param InsertRowsBeforeRequest $request
     *
     * @return InsertRowsBeforeResponse
     */
    public function insertRowsBefore($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertRowsBeforeHeaders([]);

        return $this->insertRowsBeforeWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $workbookId
     * @param string                  $sheetId
     * @param InsertRowsBeforeRequest $request
     * @param InsertRowsBeforeHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return InsertRowsBeforeResponse
     */
    public function insertRowsBeforeWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId    = OpenApiUtilClient::getEncodeParam($sheetId);
        $query      = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->row)) {
            @$body['row'] = $request->row;
        }
        if (!Utils::isUnset($request->rowCount)) {
            @$body['rowCount'] = $request->rowCount;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return InsertRowsBeforeResponse::fromMap($this->doROARequest('InsertRowsBefore', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/insertRowsBefore', 'json', $req, $runtime));
    }

    /**
     * @param ListTemplateRequest $request
     *
     * @return ListTemplateResponse
     */
    public function listTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListTemplateHeaders([]);

        return $this->listTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListTemplateRequest $request
     * @param ListTemplateHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return ListTemplateResponse
     */
    public function listTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->templateType)) {
            @$query['templateType'] = $request->templateType;
        }
        if (!Utils::isUnset($request->workspaceId)) {
            @$query['workspaceId'] = $request->workspaceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListTemplateResponse::fromMap($this->doROARequest('ListTemplate', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/templates', 'json', $req, $runtime));
    }

    /**
     * @param string            $workbookId
     * @param string            $sheetId
     * @param string            $rangeAddress
     * @param MergeRangeRequest $request
     *
     * @return MergeRangeResponse
     */
    public function mergeRange($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MergeRangeHeaders([]);

        return $this->mergeRangeWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @param string            $workbookId
     * @param string            $sheetId
     * @param string            $rangeAddress
     * @param MergeRangeRequest $request
     * @param MergeRangeHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return MergeRangeResponse
     */
    public function mergeRangeWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId   = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId      = OpenApiUtilClient::getEncodeParam($sheetId);
        $rangeAddress = OpenApiUtilClient::getEncodeParam($rangeAddress);
        $query        = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return MergeRangeResponse::fromMap($this->doROARequest('MergeRange', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '/merge', 'json', $req, $runtime));
    }

    /**
     * @param string               $workbookId
     * @param string               $sheetId
     * @param string               $rangeAddress
     * @param RangeFindNextRequest $request
     *
     * @return RangeFindNextResponse
     */
    public function rangeFindNext($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RangeFindNextHeaders([]);

        return $this->rangeFindNextWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @param string               $workbookId
     * @param string               $sheetId
     * @param string               $rangeAddress
     * @param RangeFindNextRequest $request
     * @param RangeFindNextHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return RangeFindNextResponse
     */
    public function rangeFindNextWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId   = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId      = OpenApiUtilClient::getEncodeParam($sheetId);
        $rangeAddress = OpenApiUtilClient::getEncodeParam($rangeAddress);
        $query        = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->findOptions)) {
            @$body['findOptions'] = $request->findOptions;
        }
        if (!Utils::isUnset($request->text)) {
            @$body['text'] = $request->text;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RangeFindNextResponse::fromMap($this->doROARequest('RangeFindNext', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '/findNext', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->keyword)) {
            @$query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->workspaceId)) {
            @$query['workspaceId'] = $request->workspaceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return SearchWorkspaceDocsResponse::fromMap($this->doROARequest('SearchWorkspaceDocs', 'doc_1.0', 'HTTP', 'GET', 'AK', '/v1.0/doc/docs', 'json', $req, $runtime));
    }

    /**
     * @param string                      $workbookId
     * @param string                      $sheetId
     * @param SetColumnsVisibilityRequest $request
     *
     * @return SetColumnsVisibilityResponse
     */
    public function setColumnsVisibility($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetColumnsVisibilityHeaders([]);

        return $this->setColumnsVisibilityWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $workbookId
     * @param string                      $sheetId
     * @param SetColumnsVisibilityRequest $request
     * @param SetColumnsVisibilityHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return SetColumnsVisibilityResponse
     */
    public function setColumnsVisibilityWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId    = OpenApiUtilClient::getEncodeParam($sheetId);
        $query      = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->column)) {
            @$body['column'] = $request->column;
        }
        if (!Utils::isUnset($request->columnCount)) {
            @$body['columnCount'] = $request->columnCount;
        }
        if (!Utils::isUnset($request->visibility)) {
            @$body['visibility'] = $request->visibility;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SetColumnsVisibilityResponse::fromMap($this->doROARequest('SetColumnsVisibility', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/setColumnsVisibility', 'json', $req, $runtime));
    }

    /**
     * @param string                   $workbookId
     * @param string                   $sheetId
     * @param SetRowsVisibilityRequest $request
     *
     * @return SetRowsVisibilityResponse
     */
    public function setRowsVisibility($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetRowsVisibilityHeaders([]);

        return $this->setRowsVisibilityWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @param string                   $workbookId
     * @param string                   $sheetId
     * @param SetRowsVisibilityRequest $request
     * @param SetRowsVisibilityHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return SetRowsVisibilityResponse
     */
    public function setRowsVisibilityWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId    = OpenApiUtilClient::getEncodeParam($sheetId);
        $query      = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->row)) {
            @$body['row'] = $request->row;
        }
        if (!Utils::isUnset($request->rowCount)) {
            @$body['rowCount'] = $request->rowCount;
        }
        if (!Utils::isUnset($request->visibility)) {
            @$body['visibility'] = $request->visibility;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SetRowsVisibilityResponse::fromMap($this->doROARequest('SetRowsVisibility', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/setRowsVisibility', 'json', $req, $runtime));
    }

    /**
     * @param string                  $workbookId
     * @param string                  $sheetId
     * @param SheetAutofitRowsRequest $request
     *
     * @return SheetAutofitRowsResponse
     */
    public function sheetAutofitRows($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SheetAutofitRowsHeaders([]);

        return $this->sheetAutofitRowsWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $workbookId
     * @param string                  $sheetId
     * @param SheetAutofitRowsRequest $request
     * @param SheetAutofitRowsHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return SheetAutofitRowsResponse
     */
    public function sheetAutofitRowsWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId    = OpenApiUtilClient::getEncodeParam($sheetId);
        $query      = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->fontWidth)) {
            @$body['fontWidth'] = $request->fontWidth;
        }
        if (!Utils::isUnset($request->row)) {
            @$body['row'] = $request->row;
        }
        if (!Utils::isUnset($request->rowCount)) {
            @$body['rowCount'] = $request->rowCount;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SheetAutofitRowsResponse::fromMap($this->doROARequest('SheetAutofitRows', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/autofitRows', 'json', $req, $runtime));
    }

    /**
     * @param string              $workbookId
     * @param string              $sheetId
     * @param SheetFindAllRequest $request
     *
     * @return SheetFindAllResponse
     */
    public function sheetFindAll($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SheetFindAllHeaders([]);

        return $this->sheetFindAllWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @param string              $workbookId
     * @param string              $sheetId
     * @param SheetFindAllRequest $request
     * @param SheetFindAllHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return SheetFindAllResponse
     */
    public function sheetFindAllWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId    = OpenApiUtilClient::getEncodeParam($sheetId);
        $query      = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->select)) {
            @$query['select'] = $request->select;
        }
        $body = [];
        if (!Utils::isUnset($request->findOptions)) {
            @$body['findOptions'] = $request->findOptions;
        }
        if (!Utils::isUnset($request->text)) {
            @$body['text'] = $request->text;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SheetFindAllResponse::fromMap($this->doROARequest('SheetFindAll', 'doc_1.0', 'HTTP', 'POST', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/findAll', 'json', $req, $runtime));
    }

    /**
     * @param string                      $workbookId
     * @param UnbindCoolAppToSheetRequest $request
     *
     * @return UnbindCoolAppToSheetResponse
     */
    public function unbindCoolAppToSheet($workbookId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnbindCoolAppToSheetHeaders([]);

        return $this->unbindCoolAppToSheetWithOptions($workbookId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $workbookId
     * @param UnbindCoolAppToSheetRequest $request
     * @param UnbindCoolAppToSheetHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return UnbindCoolAppToSheetResponse
     */
    public function unbindCoolAppToSheetWithOptions($workbookId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $query      = [];
        if (!Utils::isUnset($request->coolAppCode)) {
            @$query['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return UnbindCoolAppToSheetResponse::fromMap($this->doROARequest('UnbindCoolAppToSheet', 'doc_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/coolApps', 'json', $req, $runtime));
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
        $workbookId   = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId      = OpenApiUtilClient::getEncodeParam($sheetId);
        $rangeAddress = OpenApiUtilClient::getEncodeParam($rangeAddress);
        $query        = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->backgroundColors)) {
            @$body['backgroundColors'] = $request->backgroundColors;
        }
        if (!Utils::isUnset($request->hyperlinks)) {
            @$body['hyperlinks'] = $request->hyperlinks;
        }
        if (!Utils::isUnset($request->numberFormat)) {
            @$body['numberFormat'] = $request->numberFormat;
        }
        if (!Utils::isUnset($request->values)) {
            @$body['values'] = $request->values;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateRangeResponse::fromMap($this->doROARequest('UpdateRange', 'doc_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '', 'json', $req, $runtime));
    }

    /**
     * @param string             $workbookId
     * @param string             $sheetId
     * @param UpdateSheetRequest $request
     *
     * @return UpdateSheetResponse
     */
    public function updateSheet($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateSheetHeaders([]);

        return $this->updateSheetWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @param string             $workbookId
     * @param string             $sheetId
     * @param UpdateSheetRequest $request
     * @param UpdateSheetHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return UpdateSheetResponse
     */
    public function updateSheetWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $workbookId = OpenApiUtilClient::getEncodeParam($workbookId);
        $sheetId    = OpenApiUtilClient::getEncodeParam($sheetId);
        $query      = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->visibility)) {
            @$body['visibility'] = $request->visibility;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateSheetResponse::fromMap($this->doROARequest('UpdateSheet', 'doc_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '', 'none', $req, $runtime));
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
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateWorkspaceDocMembersResponse::fromMap($this->doROARequest('UpdateWorkspaceDocMembers', 'doc_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/docs/' . $nodeId . '/members', 'none', $req, $runtime));
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
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateWorkspaceMembersResponse::fromMap($this->doROARequest('UpdateWorkspaceMembers', 'doc_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/doc/workspaces/' . $workspaceId . '/members', 'none', $req, $runtime));
    }
}
