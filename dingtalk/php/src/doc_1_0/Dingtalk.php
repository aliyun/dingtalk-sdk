<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\AddCommentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\AddCommentRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\AddCommentResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocAppendParagraphHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocAppendParagraphRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocAppendParagraphResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocAppendTextHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocAppendTextRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocAppendTextResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocBlocksQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocBlocksQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocBlocksQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocDeleteBlockHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocDeleteBlockRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocDeleteBlockResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocExportSnapshotHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocExportSnapshotRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocExportSnapshotResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocInsertBlocksHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocInsertBlocksRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocInsertBlocksResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocSlotsModifyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocSlotsModifyRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocSlotsModifyResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocSlotsQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocSlotsQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocSlotsQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocUpdateContentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocUpdateContentRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocUpdateContentResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetAllSheetsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetAllSheetsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetAllSheetsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetDeveloperMetadataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetDeveloperMetadataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetDeveloperMetadataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetImportDocumentMarkHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetImportDocumentMarkRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetImportDocumentMarkResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetResourceUploadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetResourceUploadInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetResourceUploadInfoResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InitDocumentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InitDocumentRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InitDocumentResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetColumnWidthHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetColumnWidthRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetColumnWidthResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetRowHeightHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetRowHeightRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetRowHeightResponse;
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
     * @summary 添加评论
     *  *
     * @param string            $docId
     * @param AddCommentRequest $request AddCommentRequest
     * @param AddCommentHeaders $headers AddCommentHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return AddCommentResponse AddCommentResponse
     */
    public function addCommentWithOptions($docId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->commentContent)) {
            $body['commentContent'] = $request->commentContent;
        }
        if (!Utils::isUnset($request->commentType)) {
            $body['commentType'] = $request->commentType;
        }
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AddComment',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/docs/' . $docId . '/comments',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddCommentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加评论
     *  *
     * @param string            $docId
     * @param AddCommentRequest $request AddCommentRequest
     *
     * @return AddCommentResponse AddCommentResponse
     */
    public function addComment($docId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddCommentHeaders([]);

        return $this->addCommentWithOptions($docId, $request, $headers, $runtime);
    }

    /**
     * @summary 添加知识库文档成员
     *  *
     * @param string                        $workspaceId
     * @param string                        $nodeId
     * @param AddWorkspaceDocMembersRequest $request     AddWorkspaceDocMembersRequest
     * @param AddWorkspaceDocMembersHeaders $headers     AddWorkspaceDocMembersHeaders
     * @param RuntimeOptions                $runtime     runtime options for this request RuntimeOptions
     *
     * @return AddWorkspaceDocMembersResponse AddWorkspaceDocMembersResponse
     */
    public function addWorkspaceDocMembersWithOptions($workspaceId, $nodeId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'action'      => 'AddWorkspaceDocMembers',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workspaces/' . $workspaceId . '/docs/' . $nodeId . '/members',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return AddWorkspaceDocMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加知识库文档成员
     *  *
     * @param string                        $workspaceId
     * @param string                        $nodeId
     * @param AddWorkspaceDocMembersRequest $request     AddWorkspaceDocMembersRequest
     *
     * @return AddWorkspaceDocMembersResponse AddWorkspaceDocMembersResponse
     */
    public function addWorkspaceDocMembers($workspaceId, $nodeId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddWorkspaceDocMembersHeaders([]);

        return $this->addWorkspaceDocMembersWithOptions($workspaceId, $nodeId, $request, $headers, $runtime);
    }

    /**
     * @summary 添加知识库成员
     *  *
     * @param string                     $workspaceId
     * @param AddWorkspaceMembersRequest $request     AddWorkspaceMembersRequest
     * @param AddWorkspaceMembersHeaders $headers     AddWorkspaceMembersHeaders
     * @param RuntimeOptions             $runtime     runtime options for this request RuntimeOptions
     *
     * @return AddWorkspaceMembersResponse AddWorkspaceMembersResponse
     */
    public function addWorkspaceMembersWithOptions($workspaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'action'      => 'AddWorkspaceMembers',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workspaces/' . $workspaceId . '/members',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddWorkspaceMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加知识库成员
     *  *
     * @param string                     $workspaceId
     * @param AddWorkspaceMembersRequest $request     AddWorkspaceMembersRequest
     *
     * @return AddWorkspaceMembersResponse AddWorkspaceMembersResponse
     */
    public function addWorkspaceMembers($workspaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddWorkspaceMembersHeaders([]);

        return $this->addWorkspaceMembersWithOptions($workspaceId, $request, $headers, $runtime);
    }

    /**
     * @summary 追加行
     *  *
     * @param string            $workbookId
     * @param string            $sheetId
     * @param AppendRowsRequest $request    AppendRowsRequest
     * @param AppendRowsHeaders $headers    AppendRowsHeaders
     * @param RuntimeOptions    $runtime    runtime options for this request RuntimeOptions
     *
     * @return AppendRowsResponse AppendRowsResponse
     */
    public function appendRowsWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->values)) {
            $body['values'] = $request->values;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AppendRows',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/appendRows',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return AppendRowsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 追加行
     *  *
     * @param string            $workbookId
     * @param string            $sheetId
     * @param AppendRowsRequest $request    AppendRowsRequest
     *
     * @return AppendRowsResponse AppendRowsResponse
     */
    public function appendRows($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AppendRowsHeaders([]);

        return $this->appendRowsWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @summary 批量执行表格操作
     *  *
     * @param string         $workbookId
     * @param BatchRequest   $request    BatchRequest
     * @param BatchHeaders   $headers    BatchHeaders
     * @param RuntimeOptions $runtime    runtime options for this request RuntimeOptions
     *
     * @return BatchResponse BatchResponse
     */
    public function batchWithOptions($workbookId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->requests)) {
            $body['requests'] = $request->requests;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'Batch',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量执行表格操作
     *  *
     * @param string       $workbookId
     * @param BatchRequest $request    BatchRequest
     *
     * @return BatchResponse BatchResponse
     */
    public function batch($workbookId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchHeaders([]);

        return $this->batchWithOptions($workbookId, $request, $headers, $runtime);
    }

    /**
     * @summary 批量查询知识库文档
     *  *
     * @param BatchGetWorkspaceDocsRequest $request BatchGetWorkspaceDocsRequest
     * @param BatchGetWorkspaceDocsHeaders $headers BatchGetWorkspaceDocsHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchGetWorkspaceDocsResponse BatchGetWorkspaceDocsResponse
     */
    public function batchGetWorkspaceDocsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->nodeIds)) {
            $body['nodeIds'] = $request->nodeIds;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'action'      => 'BatchGetWorkspaceDocs',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workspaces/docs/infos/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchGetWorkspaceDocsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询知识库文档
     *  *
     * @param BatchGetWorkspaceDocsRequest $request BatchGetWorkspaceDocsRequest
     *
     * @return BatchGetWorkspaceDocsResponse BatchGetWorkspaceDocsResponse
     */
    public function batchGetWorkspaceDocs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchGetWorkspaceDocsHeaders([]);

        return $this->batchGetWorkspaceDocsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 知识库批量查询
     *  *
     * @param BatchGetWorkspacesRequest $request BatchGetWorkspacesRequest
     * @param BatchGetWorkspacesHeaders $headers BatchGetWorkspacesHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchGetWorkspacesResponse BatchGetWorkspacesResponse
     */
    public function batchGetWorkspacesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->includeRecent)) {
            $body['includeRecent'] = $request->includeRecent;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->workspaceIds)) {
            $body['workspaceIds'] = $request->workspaceIds;
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
            'action'      => 'BatchGetWorkspaces',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workspaces/infos/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchGetWorkspacesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 知识库批量查询
     *  *
     * @param BatchGetWorkspacesRequest $request BatchGetWorkspacesRequest
     *
     * @return BatchGetWorkspacesResponse BatchGetWorkspacesResponse
     */
    public function batchGetWorkspaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchGetWorkspacesHeaders([]);

        return $this->batchGetWorkspacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 关联文档酷应用到表格
     *  *
     * @param string                    $workbookId
     * @param BindCoolAppToSheetRequest $request    BindCoolAppToSheetRequest
     * @param BindCoolAppToSheetHeaders $headers    BindCoolAppToSheetHeaders
     * @param RuntimeOptions            $runtime    runtime options for this request RuntimeOptions
     *
     * @return BindCoolAppToSheetResponse BindCoolAppToSheetResponse
     */
    public function bindCoolAppToSheetWithOptions($workbookId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->coolAppCode)) {
            $body['coolAppCode'] = $request->coolAppCode;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BindCoolAppToSheet',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/coolApps',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BindCoolAppToSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 关联文档酷应用到表格
     *  *
     * @param string                    $workbookId
     * @param BindCoolAppToSheetRequest $request    BindCoolAppToSheetRequest
     *
     * @return BindCoolAppToSheetResponse BindCoolAppToSheetResponse
     */
    public function bindCoolAppToSheet($workbookId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BindCoolAppToSheetHeaders([]);

        return $this->bindCoolAppToSheetWithOptions($workbookId, $request, $headers, $runtime);
    }

    /**
     * @summary 清除单元格区域内所有内容
     *  *
     * @param string         $workbookId
     * @param string         $sheetId
     * @param string         $rangeAddress
     * @param ClearRequest   $request      ClearRequest
     * @param ClearHeaders   $headers      ClearHeaders
     * @param RuntimeOptions $runtime      runtime options for this request RuntimeOptions
     *
     * @return ClearResponse ClearResponse
     */
    public function clearWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'Clear',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '/clear',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ClearResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 清除单元格区域内所有内容
     *  *
     * @param string       $workbookId
     * @param string       $sheetId
     * @param string       $rangeAddress
     * @param ClearRequest $request      ClearRequest
     *
     * @return ClearResponse ClearResponse
     */
    public function clear($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ClearHeaders([]);

        return $this->clearWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @summary 清除单元格区域内数据
     *  *
     * @param string           $workbookId
     * @param string           $sheetId
     * @param string           $rangeAddress
     * @param ClearDataRequest $request      ClearDataRequest
     * @param ClearDataHeaders $headers      ClearDataHeaders
     * @param RuntimeOptions   $runtime      runtime options for this request RuntimeOptions
     *
     * @return ClearDataResponse ClearDataResponse
     */
    public function clearDataWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'ClearData',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '/clearData',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ClearDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 清除单元格区域内数据
     *  *
     * @param string           $workbookId
     * @param string           $sheetId
     * @param string           $rangeAddress
     * @param ClearDataRequest $request      ClearDataRequest
     *
     * @return ClearDataResponse ClearDataResponse
     */
    public function clearData($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ClearDataHeaders([]);

        return $this->clearDataWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @summary 创建条件格式
     *  *
     * @param string                                 $workbookId
     * @param string                                 $sheetId
     * @param CreateConditionalFormattingRuleRequest $request    CreateConditionalFormattingRuleRequest
     * @param CreateConditionalFormattingRuleHeaders $headers    CreateConditionalFormattingRuleHeaders
     * @param RuntimeOptions                         $runtime    runtime options for this request RuntimeOptions
     *
     * @return CreateConditionalFormattingRuleResponse CreateConditionalFormattingRuleResponse
     */
    public function createConditionalFormattingRuleWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->cellStyle)) {
            $body['cellStyle'] = $request->cellStyle;
        }
        if (!Utils::isUnset($request->duplicateCondition)) {
            $body['duplicateCondition'] = $request->duplicateCondition;
        }
        if (!Utils::isUnset($request->ranges)) {
            $body['ranges'] = $request->ranges;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateConditionalFormattingRule',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/conditionalFormattingRules',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateConditionalFormattingRuleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建条件格式
     *  *
     * @param string                                 $workbookId
     * @param string                                 $sheetId
     * @param CreateConditionalFormattingRuleRequest $request    CreateConditionalFormattingRuleRequest
     *
     * @return CreateConditionalFormattingRuleResponse CreateConditionalFormattingRuleResponse
     */
    public function createConditionalFormattingRule($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateConditionalFormattingRuleHeaders([]);

        return $this->createConditionalFormattingRuleWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建开发者元数据
     *  *
     * @param string                         $workbookId
     * @param CreateDeveloperMetadataRequest $request    CreateDeveloperMetadataRequest
     * @param CreateDeveloperMetadataHeaders $headers    CreateDeveloperMetadataHeaders
     * @param RuntimeOptions                 $runtime    runtime options for this request RuntimeOptions
     *
     * @return CreateDeveloperMetadataResponse CreateDeveloperMetadataResponse
     */
    public function createDeveloperMetadataWithOptions($workbookId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->associatedColumn)) {
            $body['associatedColumn'] = $request->associatedColumn;
        }
        if (!Utils::isUnset($request->associatedRow)) {
            $body['associatedRow'] = $request->associatedRow;
        }
        if (!Utils::isUnset($request->value)) {
            $body['value'] = $request->value;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateDeveloperMetadata',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/developerMetadatas',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateDeveloperMetadataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建开发者元数据
     *  *
     * @param string                         $workbookId
     * @param CreateDeveloperMetadataRequest $request    CreateDeveloperMetadataRequest
     *
     * @return CreateDeveloperMetadataResponse CreateDeveloperMetadataResponse
     */
    public function createDeveloperMetadata($workbookId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDeveloperMetadataHeaders([]);

        return $this->createDeveloperMetadataWithOptions($workbookId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建单元格锁定
     *  *
     * @param string                       $workbookId
     * @param string                       $sheetId
     * @param string                       $rangeAddress
     * @param CreateRangeProtectionRequest $request      CreateRangeProtectionRequest
     * @param CreateRangeProtectionHeaders $headers      CreateRangeProtectionHeaders
     * @param RuntimeOptions               $runtime      runtime options for this request RuntimeOptions
     *
     * @return CreateRangeProtectionResponse CreateRangeProtectionResponse
     */
    public function createRangeProtectionWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->editableSetting)) {
            $body['editableSetting'] = $request->editableSetting;
        }
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->otherUserPermission)) {
            $body['otherUserPermission'] = $request->otherUserPermission;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateRangeProtection',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '/protections',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateRangeProtectionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建单元格锁定
     *  *
     * @param string                       $workbookId
     * @param string                       $sheetId
     * @param string                       $rangeAddress
     * @param CreateRangeProtectionRequest $request      CreateRangeProtectionRequest
     *
     * @return CreateRangeProtectionResponse CreateRangeProtectionResponse
     */
    public function createRangeProtection($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateRangeProtectionHeaders([]);

        return $this->createRangeProtectionWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @summary 创建工作表
     *  *
     * @param string             $workbookId
     * @param CreateSheetRequest $request    CreateSheetRequest
     * @param CreateSheetHeaders $headers    CreateSheetHeaders
     * @param RuntimeOptions     $runtime    runtime options for this request RuntimeOptions
     *
     * @return CreateSheetResponse CreateSheetResponse
     */
    public function createSheetWithOptions($workbookId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateSheet',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建工作表
     *  *
     * @param string             $workbookId
     * @param CreateSheetRequest $request    CreateSheetRequest
     *
     * @return CreateSheetResponse CreateSheetResponse
     */
    public function createSheet($workbookId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSheetHeaders([]);

        return $this->createSheetWithOptions($workbookId, $request, $headers, $runtime);
    }

    /**
     * @summary 新建知识库
     *  *
     * @param CreateWorkspaceRequest $request CreateWorkspaceRequest
     * @param CreateWorkspaceHeaders $headers CreateWorkspaceHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateWorkspaceResponse CreateWorkspaceResponse
     */
    public function createWorkspaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'action'      => 'CreateWorkspace',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workspaces',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateWorkspaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新建知识库
     *  *
     * @param CreateWorkspaceRequest $request CreateWorkspaceRequest
     *
     * @return CreateWorkspaceResponse CreateWorkspaceResponse
     */
    public function createWorkspace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateWorkspaceHeaders([]);

        return $this->createWorkspaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建知识库文档
     *  *
     * @param string                    $workspaceId
     * @param CreateWorkspaceDocRequest $request     CreateWorkspaceDocRequest
     * @param CreateWorkspaceDocHeaders $headers     CreateWorkspaceDocHeaders
     * @param RuntimeOptions            $runtime     runtime options for this request RuntimeOptions
     *
     * @return CreateWorkspaceDocResponse CreateWorkspaceDocResponse
     */
    public function createWorkspaceDocWithOptions($workspaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->docType)) {
            $body['docType'] = $request->docType;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->parentNodeId)) {
            $body['parentNodeId'] = $request->parentNodeId;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->templateType)) {
            $body['templateType'] = $request->templateType;
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
            'action'      => 'CreateWorkspaceDoc',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workspaces/' . $workspaceId . '/docs',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateWorkspaceDocResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建知识库文档
     *  *
     * @param string                    $workspaceId
     * @param CreateWorkspaceDocRequest $request     CreateWorkspaceDocRequest
     *
     * @return CreateWorkspaceDocResponse CreateWorkspaceDocResponse
     */
    public function createWorkspaceDoc($workspaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateWorkspaceDocHeaders([]);

        return $this->createWorkspaceDocWithOptions($workspaceId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除列
     *  *
     * @param string               $workbookId
     * @param string               $sheetId
     * @param DeleteColumnsRequest $request    DeleteColumnsRequest
     * @param DeleteColumnsHeaders $headers    DeleteColumnsHeaders
     * @param RuntimeOptions       $runtime    runtime options for this request RuntimeOptions
     *
     * @return DeleteColumnsResponse DeleteColumnsResponse
     */
    public function deleteColumnsWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->column)) {
            $body['column'] = $request->column;
        }
        if (!Utils::isUnset($request->columnCount)) {
            $body['columnCount'] = $request->columnCount;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DeleteColumns',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/deleteColumns',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteColumnsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除列
     *  *
     * @param string               $workbookId
     * @param string               $sheetId
     * @param DeleteColumnsRequest $request    DeleteColumnsRequest
     *
     * @return DeleteColumnsResponse DeleteColumnsResponse
     */
    public function deleteColumns($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteColumnsHeaders([]);

        return $this->deleteColumnsWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除下拉列表
     *  *
     * @param string                     $workbookId
     * @param string                     $sheetId
     * @param string                     $rangeAddress
     * @param DeleteDropdownListsRequest $request      DeleteDropdownListsRequest
     * @param DeleteDropdownListsHeaders $headers      DeleteDropdownListsHeaders
     * @param RuntimeOptions             $runtime      runtime options for this request RuntimeOptions
     *
     * @return DeleteDropdownListsResponse DeleteDropdownListsResponse
     */
    public function deleteDropdownListsWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'DeleteDropdownLists',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '/deleteDropdownLists',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteDropdownListsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除下拉列表
     *  *
     * @param string                     $workbookId
     * @param string                     $sheetId
     * @param string                     $rangeAddress
     * @param DeleteDropdownListsRequest $request      DeleteDropdownListsRequest
     *
     * @return DeleteDropdownListsResponse DeleteDropdownListsResponse
     */
    public function deleteDropdownLists($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDropdownListsHeaders([]);

        return $this->deleteDropdownListsWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @summary 删除单元格锁定
     *  *
     * @param string                       $workbookId
     * @param string                       $sheetId
     * @param string                       $rangeAddress
     * @param string                       $protectionId
     * @param DeleteRangeProtectionRequest $request      DeleteRangeProtectionRequest
     * @param DeleteRangeProtectionHeaders $headers      DeleteRangeProtectionHeaders
     * @param RuntimeOptions               $runtime      runtime options for this request RuntimeOptions
     *
     * @return DeleteRangeProtectionResponse DeleteRangeProtectionResponse
     */
    public function deleteRangeProtectionWithOptions($workbookId, $sheetId, $rangeAddress, $protectionId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'DeleteRangeProtection',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '/protections/' . $protectionId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteRangeProtectionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除单元格锁定
     *  *
     * @param string                       $workbookId
     * @param string                       $sheetId
     * @param string                       $rangeAddress
     * @param string                       $protectionId
     * @param DeleteRangeProtectionRequest $request      DeleteRangeProtectionRequest
     *
     * @return DeleteRangeProtectionResponse DeleteRangeProtectionResponse
     */
    public function deleteRangeProtection($workbookId, $sheetId, $rangeAddress, $protectionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRangeProtectionHeaders([]);

        return $this->deleteRangeProtectionWithOptions($workbookId, $sheetId, $rangeAddress, $protectionId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除行
     *  *
     * @param string            $workbookId
     * @param string            $sheetId
     * @param DeleteRowsRequest $request    DeleteRowsRequest
     * @param DeleteRowsHeaders $headers    DeleteRowsHeaders
     * @param RuntimeOptions    $runtime    runtime options for this request RuntimeOptions
     *
     * @return DeleteRowsResponse DeleteRowsResponse
     */
    public function deleteRowsWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->row)) {
            $body['row'] = $request->row;
        }
        if (!Utils::isUnset($request->rowCount)) {
            $body['rowCount'] = $request->rowCount;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DeleteRows',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/deleteRows',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteRowsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除行
     *  *
     * @param string            $workbookId
     * @param string            $sheetId
     * @param DeleteRowsRequest $request    DeleteRowsRequest
     *
     * @return DeleteRowsResponse DeleteRowsResponse
     */
    public function deleteRows($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRowsHeaders([]);

        return $this->deleteRowsWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除工作表
     *  *
     * @param string             $workbookId
     * @param string             $sheetId
     * @param DeleteSheetRequest $request    DeleteSheetRequest
     * @param DeleteSheetHeaders $headers    DeleteSheetHeaders
     * @param RuntimeOptions     $runtime    runtime options for this request RuntimeOptions
     *
     * @return DeleteSheetResponse DeleteSheetResponse
     */
    public function deleteSheetWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'DeleteSheet',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除工作表
     *  *
     * @param string             $workbookId
     * @param string             $sheetId
     * @param DeleteSheetRequest $request    DeleteSheetRequest
     *
     * @return DeleteSheetResponse DeleteSheetResponse
     */
    public function deleteSheet($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSheetHeaders([]);

        return $this->deleteSheetWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除知识库文档
     *  *
     * @param string                    $workspaceId
     * @param string                    $nodeId
     * @param DeleteWorkspaceDocRequest $request     DeleteWorkspaceDocRequest
     * @param DeleteWorkspaceDocHeaders $headers     DeleteWorkspaceDocHeaders
     * @param RuntimeOptions            $runtime     runtime options for this request RuntimeOptions
     *
     * @return DeleteWorkspaceDocResponse DeleteWorkspaceDocResponse
     */
    public function deleteWorkspaceDocWithOptions($workspaceId, $nodeId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'DeleteWorkspaceDoc',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workspaces/' . $workspaceId . '/docs/' . $nodeId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return DeleteWorkspaceDocResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除知识库文档
     *  *
     * @param string                    $workspaceId
     * @param string                    $nodeId
     * @param DeleteWorkspaceDocRequest $request     DeleteWorkspaceDocRequest
     *
     * @return DeleteWorkspaceDocResponse DeleteWorkspaceDocResponse
     */
    public function deleteWorkspaceDoc($workspaceId, $nodeId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteWorkspaceDocHeaders([]);

        return $this->deleteWorkspaceDocWithOptions($workspaceId, $nodeId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除知识库文档成员
     *  *
     * @param string                           $workspaceId
     * @param string                           $nodeId
     * @param DeleteWorkspaceDocMembersRequest $request     DeleteWorkspaceDocMembersRequest
     * @param DeleteWorkspaceDocMembersHeaders $headers     DeleteWorkspaceDocMembersHeaders
     * @param RuntimeOptions                   $runtime     runtime options for this request RuntimeOptions
     *
     * @return DeleteWorkspaceDocMembersResponse DeleteWorkspaceDocMembersResponse
     */
    public function deleteWorkspaceDocMembersWithOptions($workspaceId, $nodeId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'action'      => 'DeleteWorkspaceDocMembers',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workspaces/' . $workspaceId . '/docs/' . $nodeId . '/members/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return DeleteWorkspaceDocMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除知识库文档成员
     *  *
     * @param string                           $workspaceId
     * @param string                           $nodeId
     * @param DeleteWorkspaceDocMembersRequest $request     DeleteWorkspaceDocMembersRequest
     *
     * @return DeleteWorkspaceDocMembersResponse DeleteWorkspaceDocMembersResponse
     */
    public function deleteWorkspaceDocMembers($workspaceId, $nodeId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteWorkspaceDocMembersHeaders([]);

        return $this->deleteWorkspaceDocMembersWithOptions($workspaceId, $nodeId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除知识库成员
     *  *
     * @param string                        $workspaceId
     * @param DeleteWorkspaceMembersRequest $request     DeleteWorkspaceMembersRequest
     * @param DeleteWorkspaceMembersHeaders $headers     DeleteWorkspaceMembersHeaders
     * @param RuntimeOptions                $runtime     runtime options for this request RuntimeOptions
     *
     * @return DeleteWorkspaceMembersResponse DeleteWorkspaceMembersResponse
     */
    public function deleteWorkspaceMembersWithOptions($workspaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'action'      => 'DeleteWorkspaceMembers',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workspaces/' . $workspaceId . '/members/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return DeleteWorkspaceMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除知识库成员
     *  *
     * @param string                        $workspaceId
     * @param DeleteWorkspaceMembersRequest $request     DeleteWorkspaceMembersRequest
     *
     * @return DeleteWorkspaceMembersResponse DeleteWorkspaceMembersResponse
     */
    public function deleteWorkspaceMembers($workspaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteWorkspaceMembersHeaders([]);

        return $this->deleteWorkspaceMembersWithOptions($workspaceId, $request, $headers, $runtime);
    }

    /**
     * @summary 追加指定段落元素
     *  *
     * @param string                    $docKey
     * @param string                    $blockId
     * @param DocAppendParagraphRequest $request DocAppendParagraphRequest
     * @param DocAppendParagraphHeaders $headers DocAppendParagraphHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return DocAppendParagraphResponse DocAppendParagraphResponse
     */
    public function docAppendParagraphWithOptions($docKey, $blockId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->elementType)) {
            $body['elementType'] = $request->elementType;
        }
        if (!Utils::isUnset($request->properties)) {
            $body['properties'] = $request->properties;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DocAppendParagraph',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/suites/documents/' . $docKey . '/blocks/' . $blockId . '/paragraph/appendElement',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DocAppendParagraphResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 追加指定段落元素
     *  *
     * @param string                    $docKey
     * @param string                    $blockId
     * @param DocAppendParagraphRequest $request DocAppendParagraphRequest
     *
     * @return DocAppendParagraphResponse DocAppendParagraphResponse
     */
    public function docAppendParagraph($docKey, $blockId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DocAppendParagraphHeaders([]);

        return $this->docAppendParagraphWithOptions($docKey, $blockId, $request, $headers, $runtime);
    }

    /**
     * @summary 在段落后追加文本
     *  *
     * @param string               $docKey
     * @param string               $blockId
     * @param DocAppendTextRequest $request DocAppendTextRequest
     * @param DocAppendTextHeaders $headers DocAppendTextHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return DocAppendTextResponse DocAppendTextResponse
     */
    public function docAppendTextWithOptions($docKey, $blockId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->text)) {
            $body['text'] = $request->text;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DocAppendText',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/suites/documents/' . $docKey . '/blocks/' . $blockId . '/paragraph/appendText',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DocAppendTextResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 在段落后追加文本
     *  *
     * @param string               $docKey
     * @param string               $blockId
     * @param DocAppendTextRequest $request DocAppendTextRequest
     *
     * @return DocAppendTextResponse DocAppendTextResponse
     */
    public function docAppendText($docKey, $blockId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DocAppendTextHeaders([]);

        return $this->docAppendTextWithOptions($docKey, $blockId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询指定Block元素
     *  *
     * @param string                $docKey
     * @param DocBlocksQueryRequest $request DocBlocksQueryRequest
     * @param DocBlocksQueryHeaders $headers DocBlocksQueryHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return DocBlocksQueryResponse DocBlocksQueryResponse
     */
    public function docBlocksQueryWithOptions($docKey, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->blockType)) {
            $query['blockType'] = $request->blockType;
        }
        if (!Utils::isUnset($request->endIndex)) {
            $query['endIndex'] = $request->endIndex;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->startIndex)) {
            $query['startIndex'] = $request->startIndex;
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
            'action'      => 'DocBlocksQuery',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/suites/documents/' . $docKey . '/blocks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DocBlocksQueryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询指定Block元素
     *  *
     * @param string                $docKey
     * @param DocBlocksQueryRequest $request DocBlocksQueryRequest
     *
     * @return DocBlocksQueryResponse DocBlocksQueryResponse
     */
    public function docBlocksQuery($docKey, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DocBlocksQueryHeaders([]);

        return $this->docBlocksQueryWithOptions($docKey, $request, $headers, $runtime);
    }

    /**
     * @summary 删除指定位置的 Block
     *  *
     * @param string                $docKey
     * @param string                $blockId
     * @param DocDeleteBlockRequest $request DocDeleteBlockRequest
     * @param DocDeleteBlockHeaders $headers DocDeleteBlockHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return DocDeleteBlockResponse DocDeleteBlockResponse
     */
    public function docDeleteBlockWithOptions($docKey, $blockId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'DocDeleteBlock',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/suites/documents/' . $docKey . '/blocks/' . $blockId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DocDeleteBlockResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除指定位置的 Block
     *  *
     * @param string                $docKey
     * @param string                $blockId
     * @param DocDeleteBlockRequest $request DocDeleteBlockRequest
     *
     * @return DocDeleteBlockResponse DocDeleteBlockResponse
     */
    public function docDeleteBlock($docKey, $blockId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DocDeleteBlockHeaders([]);

        return $this->docDeleteBlockWithOptions($docKey, $blockId, $request, $headers, $runtime);
    }

    /**
     * @summary 根据传入的文档ID将文档导出为截图
     *  *
     * @param string                   $documentId
     * @param DocExportSnapshotRequest $request    DocExportSnapshotRequest
     * @param DocExportSnapshotHeaders $headers    DocExportSnapshotHeaders
     * @param RuntimeOptions           $runtime    runtime options for this request RuntimeOptions
     *
     * @return DocExportSnapshotResponse DocExportSnapshotResponse
     */
    public function docExportSnapshotWithOptions($documentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'DocExportSnapshot',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/suites/documents/' . $documentId . '/export/snapshot',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DocExportSnapshotResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据传入的文档ID将文档导出为截图
     *  *
     * @param string                   $documentId
     * @param DocExportSnapshotRequest $request    DocExportSnapshotRequest
     *
     * @return DocExportSnapshotResponse DocExportSnapshotResponse
     */
    public function docExportSnapshot($documentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DocExportSnapshotHeaders([]);

        return $this->docExportSnapshotWithOptions($documentId, $request, $headers, $runtime);
    }

    /**
     * @summary 插入指定Block元素
     *  *
     * @param string                 $docKey
     * @param DocInsertBlocksRequest $request DocInsertBlocksRequest
     * @param DocInsertBlocksHeaders $headers DocInsertBlocksHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return DocInsertBlocksResponse DocInsertBlocksResponse
     */
    public function docInsertBlocksWithOptions($docKey, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->blockId)) {
            $body['blockId'] = $request->blockId;
        }
        if (!Utils::isUnset($request->element)) {
            $body['element'] = $request->element;
        }
        if (!Utils::isUnset($request->index)) {
            $body['index'] = $request->index;
        }
        if (!Utils::isUnset($request->where)) {
            $body['where'] = $request->where;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DocInsertBlocks',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/suites/documents/' . $docKey . '/blocks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DocInsertBlocksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 插入指定Block元素
     *  *
     * @param string                 $docKey
     * @param DocInsertBlocksRequest $request DocInsertBlocksRequest
     *
     * @return DocInsertBlocksResponse DocInsertBlocksResponse
     */
    public function docInsertBlocks($docKey, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DocInsertBlocksHeaders([]);

        return $this->docInsertBlocksWithOptions($docKey, $request, $headers, $runtime);
    }

    /**
     * @summary 根据传入参数更新文档插槽
     *  *
     * @param string                $documentId
     * @param DocSlotsModifyRequest $request    DocSlotsModifyRequest
     * @param DocSlotsModifyHeaders $headers    DocSlotsModifyHeaders
     * @param RuntimeOptions        $runtime    runtime options for this request RuntimeOptions
     *
     * @return DocSlotsModifyResponse DocSlotsModifyResponse
     */
    public function docSlotsModifyWithOptions($documentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->request)) {
            $body['request'] = $request->request;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DocSlotsModify',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/suites/documents/' . $documentId . '/slots',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DocSlotsModifyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据传入参数更新文档插槽
     *  *
     * @param string                $documentId
     * @param DocSlotsModifyRequest $request    DocSlotsModifyRequest
     *
     * @return DocSlotsModifyResponse DocSlotsModifyResponse
     */
    public function docSlotsModify($documentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DocSlotsModifyHeaders([]);

        return $this->docSlotsModifyWithOptions($documentId, $request, $headers, $runtime);
    }

    /**
     * @summary 根据传入参数查询文档中所有的插槽
     *  *
     * @param string               $documentId
     * @param DocSlotsQueryRequest $request    DocSlotsQueryRequest
     * @param DocSlotsQueryHeaders $headers    DocSlotsQueryHeaders
     * @param RuntimeOptions       $runtime    runtime options for this request RuntimeOptions
     *
     * @return DocSlotsQueryResponse DocSlotsQueryResponse
     */
    public function docSlotsQueryWithOptions($documentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'DocSlotsQuery',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/suites/documents/' . $documentId . '/slots',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DocSlotsQueryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据传入参数查询文档中所有的插槽
     *  *
     * @param string               $documentId
     * @param DocSlotsQueryRequest $request    DocSlotsQueryRequest
     *
     * @return DocSlotsQueryResponse DocSlotsQueryResponse
     */
    public function docSlotsQuery($documentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DocSlotsQueryHeaders([]);

        return $this->docSlotsQueryWithOptions($documentId, $request, $headers, $runtime);
    }

    /**
     * @summary 覆写全文
     *  *
     * @param string                  $docKey
     * @param DocUpdateContentRequest $request DocUpdateContentRequest
     * @param DocUpdateContentHeaders $headers DocUpdateContentHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return DocUpdateContentResponse DocUpdateContentResponse
     */
    public function docUpdateContentWithOptions($docKey, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->dataType)) {
            $body['dataType'] = $request->dataType;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DocUpdateContent',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/suites/documents/' . $docKey . '/overwriteContent',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DocUpdateContentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 覆写全文
     *  *
     * @param string                  $docKey
     * @param DocUpdateContentRequest $request DocUpdateContentRequest
     *
     * @return DocUpdateContentResponse DocUpdateContentResponse
     */
    public function docUpdateContent($docKey, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DocUpdateContentHeaders([]);

        return $this->docUpdateContentWithOptions($docKey, $request, $headers, $runtime);
    }

    /**
     * @summary 获取所有工作表
     *  *
     * @param string              $workbookId
     * @param GetAllSheetsRequest $request    GetAllSheetsRequest
     * @param GetAllSheetsHeaders $headers    GetAllSheetsHeaders
     * @param RuntimeOptions      $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetAllSheetsResponse GetAllSheetsResponse
     */
    public function getAllSheetsWithOptions($workbookId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetAllSheets',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAllSheetsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取所有工作表
     *  *
     * @param string              $workbookId
     * @param GetAllSheetsRequest $request    GetAllSheetsRequest
     *
     * @return GetAllSheetsResponse GetAllSheetsResponse
     */
    public function getAllSheets($workbookId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllSheetsHeaders([]);

        return $this->getAllSheetsWithOptions($workbookId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取开发者元数据
     *  *
     * @param string                      $workbookId
     * @param string                      $developerMetadataId
     * @param GetDeveloperMetadataRequest $request             GetDeveloperMetadataRequest
     * @param GetDeveloperMetadataHeaders $headers             GetDeveloperMetadataHeaders
     * @param RuntimeOptions              $runtime             runtime options for this request RuntimeOptions
     *
     * @return GetDeveloperMetadataResponse GetDeveloperMetadataResponse
     */
    public function getDeveloperMetadataWithOptions($workbookId, $developerMetadataId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetDeveloperMetadata',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/developerMetadatas/' . $developerMetadataId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDeveloperMetadataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取开发者元数据
     *  *
     * @param string                      $workbookId
     * @param string                      $developerMetadataId
     * @param GetDeveloperMetadataRequest $request             GetDeveloperMetadataRequest
     *
     * @return GetDeveloperMetadataResponse GetDeveloperMetadataResponse
     */
    public function getDeveloperMetadata($workbookId, $developerMetadataId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDeveloperMetadataHeaders([]);

        return $this->getDeveloperMetadataWithOptions($workbookId, $developerMetadataId, $request, $headers, $runtime);
    }

    /**
     * @summary 文档标签信息查询
     *  *
     * @param string                       $docId
     * @param GetImportDocumentMarkRequest $request GetImportDocumentMarkRequest
     * @param GetImportDocumentMarkHeaders $headers GetImportDocumentMarkHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetImportDocumentMarkResponse GetImportDocumentMarkResponse
     */
    public function getImportDocumentMarkWithOptions($docId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetImportDocumentMark',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/docs/' . $docId . '/marks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetImportDocumentMarkResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 文档标签信息查询
     *  *
     * @param string                       $docId
     * @param GetImportDocumentMarkRequest $request GetImportDocumentMarkRequest
     *
     * @return GetImportDocumentMarkResponse GetImportDocumentMarkResponse
     */
    public function getImportDocumentMark($docId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetImportDocumentMarkHeaders([]);

        return $this->getImportDocumentMarkWithOptions($docId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取单元格区域
     *  *
     * @param string          $workbookId
     * @param string          $sheetId
     * @param string          $rangeAddress
     * @param GetRangeRequest $request      GetRangeRequest
     * @param GetRangeHeaders $headers      GetRangeHeaders
     * @param RuntimeOptions  $runtime      runtime options for this request RuntimeOptions
     *
     * @return GetRangeResponse GetRangeResponse
     */
    public function getRangeWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->select)) {
            $query['select'] = $request->select;
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
            'action'      => 'GetRange',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetRangeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取单元格区域
     *  *
     * @param string          $workbookId
     * @param string          $sheetId
     * @param string          $rangeAddress
     * @param GetRangeRequest $request      GetRangeRequest
     *
     * @return GetRangeResponse GetRangeResponse
     */
    public function getRange($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRangeHeaders([]);

        return $this->getRangeWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @summary 获取最近编辑文档
     *  *
     * @param GetRecentEditDocsRequest $request GetRecentEditDocsRequest
     * @param GetRecentEditDocsHeaders $headers GetRecentEditDocsHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetRecentEditDocsResponse GetRecentEditDocsResponse
     */
    public function getRecentEditDocsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetRecentEditDocs',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workspaces/docs/recentEditDocs',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetRecentEditDocsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取最近编辑文档
     *  *
     * @param GetRecentEditDocsRequest $request GetRecentEditDocsRequest
     *
     * @return GetRecentEditDocsResponse GetRecentEditDocsResponse
     */
    public function getRecentEditDocs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRecentEditDocsHeaders([]);

        return $this->getRecentEditDocsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取最近打开文档
     *  *
     * @param GetRecentOpenDocsRequest $request GetRecentOpenDocsRequest
     * @param GetRecentOpenDocsHeaders $headers GetRecentOpenDocsHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetRecentOpenDocsResponse GetRecentOpenDocsResponse
     */
    public function getRecentOpenDocsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetRecentOpenDocs',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workspaces/docs/recentOpenDocs',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetRecentOpenDocsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取最近打开文档
     *  *
     * @param GetRecentOpenDocsRequest $request GetRecentOpenDocsRequest
     *
     * @return GetRecentOpenDocsResponse GetRecentOpenDocsResponse
     */
    public function getRecentOpenDocs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRecentOpenDocsHeaders([]);

        return $this->getRecentOpenDocsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户有权限的知识库
     *  *
     * @param GetRelatedWorkspacesRequest $request GetRelatedWorkspacesRequest
     * @param GetRelatedWorkspacesHeaders $headers GetRelatedWorkspacesHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetRelatedWorkspacesResponse GetRelatedWorkspacesResponse
     */
    public function getRelatedWorkspacesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->includeRecent)) {
            $query['includeRecent'] = $request->includeRecent;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetRelatedWorkspaces',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workspaces',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetRelatedWorkspacesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户有权限的知识库
     *  *
     * @param GetRelatedWorkspacesRequest $request GetRelatedWorkspacesRequest
     *
     * @return GetRelatedWorkspacesResponse GetRelatedWorkspacesResponse
     */
    public function getRelatedWorkspaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRelatedWorkspacesHeaders([]);

        return $this->getRelatedWorkspacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取上传信息
     *  *
     * @param string                       $docId
     * @param GetResourceUploadInfoRequest $request GetResourceUploadInfoRequest
     * @param GetResourceUploadInfoHeaders $headers GetResourceUploadInfoHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetResourceUploadInfoResponse GetResourceUploadInfoResponse
     */
    public function getResourceUploadInfoWithOptions($docId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->mediaType)) {
            $body['mediaType'] = $request->mediaType;
        }
        if (!Utils::isUnset($request->resourceName)) {
            $body['resourceName'] = $request->resourceName;
        }
        if (!Utils::isUnset($request->size)) {
            $body['size'] = $request->size;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetResourceUploadInfo',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/docs/resources/' . $docId . '/uploadInfos/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetResourceUploadInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取上传信息
     *  *
     * @param string                       $docId
     * @param GetResourceUploadInfoRequest $request GetResourceUploadInfoRequest
     *
     * @return GetResourceUploadInfoResponse GetResourceUploadInfoResponse
     */
    public function getResourceUploadInfo($docId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetResourceUploadInfoHeaders([]);

        return $this->getResourceUploadInfoWithOptions($docId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取工作表
     *  *
     * @param string          $workbookId
     * @param string          $sheetId
     * @param GetSheetRequest $request    GetSheetRequest
     * @param GetSheetHeaders $headers    GetSheetHeaders
     * @param RuntimeOptions  $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetSheetResponse GetSheetResponse
     */
    public function getSheetWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetSheet',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取工作表
     *  *
     * @param string          $workbookId
     * @param string          $sheetId
     * @param GetSheetRequest $request    GetSheetRequest
     *
     * @return GetSheetResponse GetSheetResponse
     */
    public function getSheet($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSheetHeaders([]);

        return $this->getSheetWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询文档模版
     *  *
     * @param string                 $templateId
     * @param GetTemplateByIdRequest $request    GetTemplateByIdRequest
     * @param GetTemplateByIdHeaders $headers    GetTemplateByIdHeaders
     * @param RuntimeOptions         $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetTemplateByIdResponse GetTemplateByIdResponse
     */
    public function getTemplateByIdWithOptions($templateId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->belong)) {
            $query['belong'] = $request->belong;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetTemplateById',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/templates/' . $templateId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTemplateByIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询文档模版
     *  *
     * @param string                 $templateId
     * @param GetTemplateByIdRequest $request    GetTemplateByIdRequest
     *
     * @return GetTemplateByIdResponse GetTemplateByIdResponse
     */
    public function getTemplateById($templateId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTemplateByIdHeaders([]);

        return $this->getTemplateByIdWithOptions($templateId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询知识库信息
     *  *
     * @param string              $workspaceId
     * @param GetWorkspaceHeaders $headers     GetWorkspaceHeaders
     * @param RuntimeOptions      $runtime     runtime options for this request RuntimeOptions
     *
     * @return GetWorkspaceResponse GetWorkspaceResponse
     */
    public function getWorkspaceWithOptions($workspaceId, $headers, $runtime)
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
            'action'      => 'GetWorkspace',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workspaces/' . $workspaceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetWorkspaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询知识库信息
     *  *
     * @param string $workspaceId
     *
     * @return GetWorkspaceResponse GetWorkspaceResponse
     */
    public function getWorkspace($workspaceId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetWorkspaceHeaders([]);

        return $this->getWorkspaceWithOptions($workspaceId, $headers, $runtime);
    }

    /**
     * @summary 查询知识库文档
     *  *
     * @param string                  $workspaceId
     * @param string                  $nodeId
     * @param GetWorkspaceNodeRequest $request     GetWorkspaceNodeRequest
     * @param GetWorkspaceNodeHeaders $headers     GetWorkspaceNodeHeaders
     * @param RuntimeOptions          $runtime     runtime options for this request RuntimeOptions
     *
     * @return GetWorkspaceNodeResponse GetWorkspaceNodeResponse
     */
    public function getWorkspaceNodeWithOptions($workspaceId, $nodeId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetWorkspaceNode',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workspaces/' . $workspaceId . '/docs/' . $nodeId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetWorkspaceNodeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询知识库文档
     *  *
     * @param string                  $workspaceId
     * @param string                  $nodeId
     * @param GetWorkspaceNodeRequest $request     GetWorkspaceNodeRequest
     *
     * @return GetWorkspaceNodeResponse GetWorkspaceNodeResponse
     */
    public function getWorkspaceNode($workspaceId, $nodeId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetWorkspaceNodeHeaders([]);

        return $this->getWorkspaceNodeWithOptions($workspaceId, $nodeId, $request, $headers, $runtime);
    }

    /**
     * @summary 文档初始化
     *  *
     * @param string              $docId
     * @param InitDocumentRequest $request InitDocumentRequest
     * @param InitDocumentHeaders $headers InitDocumentHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return InitDocumentResponse InitDocumentResponse
     */
    public function initDocumentWithOptions($docId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->attachmentsKey)) {
            $body['attachmentsKey'] = $request->attachmentsKey;
        }
        if (!Utils::isUnset($request->attachmentsMap)) {
            $body['attachmentsMap'] = $request->attachmentsMap;
        }
        if (!Utils::isUnset($request->importType)) {
            $body['importType'] = $request->importType;
        }
        if (!Utils::isUnset($request->linksKey)) {
            $body['linksKey'] = $request->linksKey;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'InitDocument',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/docs/' . $docId . '/init',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InitDocumentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 文档初始化
     *  *
     * @param string              $docId
     * @param InitDocumentRequest $request InitDocumentRequest
     *
     * @return InitDocumentResponse InitDocumentResponse
     */
    public function initDocument($docId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InitDocumentHeaders([]);

        return $this->initDocumentWithOptions($docId, $request, $headers, $runtime);
    }

    /**
     * @summary 向文档内插入块级元素
     *  *
     * @param string              $documentId
     * @param InsertBlocksRequest $request    InsertBlocksRequest
     * @param InsertBlocksHeaders $headers    InsertBlocksHeaders
     * @param RuntimeOptions      $runtime    runtime options for this request RuntimeOptions
     *
     * @return InsertBlocksResponse InsertBlocksResponse
     */
    public function insertBlocksWithOptions($documentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->blocks)) {
            $body['blocks'] = $request->blocks;
        }
        if (!Utils::isUnset($request->location)) {
            $body['location'] = $request->location;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'action'      => 'InsertBlocks',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/documents/' . $documentId . '/blocks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return InsertBlocksResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 向文档内插入块级元素
     *  *
     * @param string              $documentId
     * @param InsertBlocksRequest $request    InsertBlocksRequest
     *
     * @return InsertBlocksResponse InsertBlocksResponse
     */
    public function insertBlocks($documentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertBlocksHeaders([]);

        return $this->insertBlocksWithOptions($documentId, $request, $headers, $runtime);
    }

    /**
     * @summary 指定列左侧插入若干列
     *  *
     * @param string                     $workbookId
     * @param string                     $sheetId
     * @param InsertColumnsBeforeRequest $request    InsertColumnsBeforeRequest
     * @param InsertColumnsBeforeHeaders $headers    InsertColumnsBeforeHeaders
     * @param RuntimeOptions             $runtime    runtime options for this request RuntimeOptions
     *
     * @return InsertColumnsBeforeResponse InsertColumnsBeforeResponse
     */
    public function insertColumnsBeforeWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->column)) {
            $body['column'] = $request->column;
        }
        if (!Utils::isUnset($request->columnCount)) {
            $body['columnCount'] = $request->columnCount;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'InsertColumnsBefore',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/insertColumnsBefore',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InsertColumnsBeforeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 指定列左侧插入若干列
     *  *
     * @param string                     $workbookId
     * @param string                     $sheetId
     * @param InsertColumnsBeforeRequest $request    InsertColumnsBeforeRequest
     *
     * @return InsertColumnsBeforeResponse InsertColumnsBeforeResponse
     */
    public function insertColumnsBefore($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertColumnsBeforeHeaders([]);

        return $this->insertColumnsBeforeWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @summary 插入下拉列表
     *  *
     * @param string                     $workbookId
     * @param string                     $sheetId
     * @param string                     $rangeAddress
     * @param InsertDropdownListsRequest $request      InsertDropdownListsRequest
     * @param InsertDropdownListsHeaders $headers      InsertDropdownListsHeaders
     * @param RuntimeOptions             $runtime      runtime options for this request RuntimeOptions
     *
     * @return InsertDropdownListsResponse InsertDropdownListsResponse
     */
    public function insertDropdownListsWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->options)) {
            $body['options'] = $request->options;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'InsertDropdownLists',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '/insertDropdownLists',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InsertDropdownListsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 插入下拉列表
     *  *
     * @param string                     $workbookId
     * @param string                     $sheetId
     * @param string                     $rangeAddress
     * @param InsertDropdownListsRequest $request      InsertDropdownListsRequest
     *
     * @return InsertDropdownListsResponse InsertDropdownListsResponse
     */
    public function insertDropdownLists($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertDropdownListsHeaders([]);

        return $this->insertDropdownListsWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @summary 指定行上方插入若干行
     *  *
     * @param string                  $workbookId
     * @param string                  $sheetId
     * @param InsertRowsBeforeRequest $request    InsertRowsBeforeRequest
     * @param InsertRowsBeforeHeaders $headers    InsertRowsBeforeHeaders
     * @param RuntimeOptions          $runtime    runtime options for this request RuntimeOptions
     *
     * @return InsertRowsBeforeResponse InsertRowsBeforeResponse
     */
    public function insertRowsBeforeWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->row)) {
            $body['row'] = $request->row;
        }
        if (!Utils::isUnset($request->rowCount)) {
            $body['rowCount'] = $request->rowCount;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'InsertRowsBefore',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/insertRowsBefore',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InsertRowsBeforeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 指定行上方插入若干行
     *  *
     * @param string                  $workbookId
     * @param string                  $sheetId
     * @param InsertRowsBeforeRequest $request    InsertRowsBeforeRequest
     *
     * @return InsertRowsBeforeResponse InsertRowsBeforeResponse
     */
    public function insertRowsBefore($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertRowsBeforeHeaders([]);

        return $this->insertRowsBeforeWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询文档模版
     *  *
     * @param ListTemplateRequest $request ListTemplateRequest
     * @param ListTemplateHeaders $headers ListTemplateHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return ListTemplateResponse ListTemplateResponse
     */
    public function listTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->templateType)) {
            $query['templateType'] = $request->templateType;
        }
        if (!Utils::isUnset($request->workspaceId)) {
            $query['workspaceId'] = $request->workspaceId;
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
            'action'      => 'ListTemplate',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/templates',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询文档模版
     *  *
     * @param ListTemplateRequest $request ListTemplateRequest
     *
     * @return ListTemplateResponse ListTemplateResponse
     */
    public function listTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListTemplateHeaders([]);

        return $this->listTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 合并单元格
     *  *
     * @param string            $workbookId
     * @param string            $sheetId
     * @param string            $rangeAddress
     * @param MergeRangeRequest $request      MergeRangeRequest
     * @param MergeRangeHeaders $headers      MergeRangeHeaders
     * @param RuntimeOptions    $runtime      runtime options for this request RuntimeOptions
     *
     * @return MergeRangeResponse MergeRangeResponse
     */
    public function mergeRangeWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'MergeRange',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '/merge',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return MergeRangeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 合并单元格
     *  *
     * @param string            $workbookId
     * @param string            $sheetId
     * @param string            $rangeAddress
     * @param MergeRangeRequest $request      MergeRangeRequest
     *
     * @return MergeRangeResponse MergeRangeResponse
     */
    public function mergeRange($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MergeRangeHeaders([]);

        return $this->mergeRangeWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @summary 查找下一个符合条件的单元格
     *  *
     * @param string               $workbookId
     * @param string               $sheetId
     * @param string               $rangeAddress
     * @param RangeFindNextRequest $request      RangeFindNextRequest
     * @param RangeFindNextHeaders $headers      RangeFindNextHeaders
     * @param RuntimeOptions       $runtime      runtime options for this request RuntimeOptions
     *
     * @return RangeFindNextResponse RangeFindNextResponse
     */
    public function rangeFindNextWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->findOptions)) {
            $body['findOptions'] = $request->findOptions;
        }
        if (!Utils::isUnset($request->text)) {
            $body['text'] = $request->text;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RangeFindNext',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '/findNext',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RangeFindNextResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查找下一个符合条件的单元格
     *  *
     * @param string               $workbookId
     * @param string               $sheetId
     * @param string               $rangeAddress
     * @param RangeFindNextRequest $request      RangeFindNextRequest
     *
     * @return RangeFindNextResponse RangeFindNextResponse
     */
    public function rangeFindNext($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RangeFindNextHeaders([]);

        return $this->rangeFindNextWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @summary 搜索用户有权限的知识库文档
     *  *
     * @param SearchWorkspaceDocsRequest $request SearchWorkspaceDocsRequest
     * @param SearchWorkspaceDocsHeaders $headers SearchWorkspaceDocsHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchWorkspaceDocsResponse SearchWorkspaceDocsResponse
     */
    public function searchWorkspaceDocsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->keyword)) {
            $query['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->workspaceId)) {
            $query['workspaceId'] = $request->workspaceId;
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
            'action'      => 'SearchWorkspaceDocs',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/docs',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchWorkspaceDocsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 搜索用户有权限的知识库文档
     *  *
     * @param SearchWorkspaceDocsRequest $request SearchWorkspaceDocsRequest
     *
     * @return SearchWorkspaceDocsResponse SearchWorkspaceDocsResponse
     */
    public function searchWorkspaceDocs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchWorkspaceDocsHeaders([]);

        return $this->searchWorkspaceDocsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设置列宽
     *  *
     * @param string                $workbookId
     * @param string                $sheetId
     * @param SetColumnWidthRequest $request    SetColumnWidthRequest
     * @param SetColumnWidthHeaders $headers    SetColumnWidthHeaders
     * @param RuntimeOptions        $runtime    runtime options for this request RuntimeOptions
     *
     * @return SetColumnWidthResponse SetColumnWidthResponse
     */
    public function setColumnWidthWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->column)) {
            $body['column'] = $request->column;
        }
        if (!Utils::isUnset($request->width)) {
            $body['width'] = $request->width;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SetColumnWidth',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/setColumnWidth',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SetColumnWidthResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置列宽
     *  *
     * @param string                $workbookId
     * @param string                $sheetId
     * @param SetColumnWidthRequest $request    SetColumnWidthRequest
     *
     * @return SetColumnWidthResponse SetColumnWidthResponse
     */
    public function setColumnWidth($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetColumnWidthHeaders([]);

        return $this->setColumnWidthWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @summary 设置列隐藏或显示
     *  *
     * @param string                      $workbookId
     * @param string                      $sheetId
     * @param SetColumnsVisibilityRequest $request    SetColumnsVisibilityRequest
     * @param SetColumnsVisibilityHeaders $headers    SetColumnsVisibilityHeaders
     * @param RuntimeOptions              $runtime    runtime options for this request RuntimeOptions
     *
     * @return SetColumnsVisibilityResponse SetColumnsVisibilityResponse
     */
    public function setColumnsVisibilityWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->column)) {
            $body['column'] = $request->column;
        }
        if (!Utils::isUnset($request->columnCount)) {
            $body['columnCount'] = $request->columnCount;
        }
        if (!Utils::isUnset($request->visibility)) {
            $body['visibility'] = $request->visibility;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SetColumnsVisibility',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/setColumnsVisibility',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SetColumnsVisibilityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置列隐藏或显示
     *  *
     * @param string                      $workbookId
     * @param string                      $sheetId
     * @param SetColumnsVisibilityRequest $request    SetColumnsVisibilityRequest
     *
     * @return SetColumnsVisibilityResponse SetColumnsVisibilityResponse
     */
    public function setColumnsVisibility($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetColumnsVisibilityHeaders([]);

        return $this->setColumnsVisibilityWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @summary 设置行高
     *  *
     * @param string              $workbookId
     * @param string              $sheetId
     * @param SetRowHeightRequest $request    SetRowHeightRequest
     * @param SetRowHeightHeaders $headers    SetRowHeightHeaders
     * @param RuntimeOptions      $runtime    runtime options for this request RuntimeOptions
     *
     * @return SetRowHeightResponse SetRowHeightResponse
     */
    public function setRowHeightWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->height)) {
            $body['height'] = $request->height;
        }
        if (!Utils::isUnset($request->row)) {
            $body['row'] = $request->row;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SetRowHeight',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/setRowHeight',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SetRowHeightResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置行高
     *  *
     * @param string              $workbookId
     * @param string              $sheetId
     * @param SetRowHeightRequest $request    SetRowHeightRequest
     *
     * @return SetRowHeightResponse SetRowHeightResponse
     */
    public function setRowHeight($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetRowHeightHeaders([]);

        return $this->setRowHeightWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @summary 设置行隐藏或显示
     *  *
     * @param string                   $workbookId
     * @param string                   $sheetId
     * @param SetRowsVisibilityRequest $request    SetRowsVisibilityRequest
     * @param SetRowsVisibilityHeaders $headers    SetRowsVisibilityHeaders
     * @param RuntimeOptions           $runtime    runtime options for this request RuntimeOptions
     *
     * @return SetRowsVisibilityResponse SetRowsVisibilityResponse
     */
    public function setRowsVisibilityWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->row)) {
            $body['row'] = $request->row;
        }
        if (!Utils::isUnset($request->rowCount)) {
            $body['rowCount'] = $request->rowCount;
        }
        if (!Utils::isUnset($request->visibility)) {
            $body['visibility'] = $request->visibility;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SetRowsVisibility',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/setRowsVisibility',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SetRowsVisibilityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置行隐藏或显示
     *  *
     * @param string                   $workbookId
     * @param string                   $sheetId
     * @param SetRowsVisibilityRequest $request    SetRowsVisibilityRequest
     *
     * @return SetRowsVisibilityResponse SetRowsVisibilityResponse
     */
    public function setRowsVisibility($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetRowsVisibilityHeaders([]);

        return $this->setRowsVisibilityWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @summary SheetAutofitRows
     *  *
     * @param string                  $workbookId
     * @param string                  $sheetId
     * @param SheetAutofitRowsRequest $request    SheetAutofitRowsRequest
     * @param SheetAutofitRowsHeaders $headers    SheetAutofitRowsHeaders
     * @param RuntimeOptions          $runtime    runtime options for this request RuntimeOptions
     *
     * @return SheetAutofitRowsResponse SheetAutofitRowsResponse
     */
    public function sheetAutofitRowsWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->fontWidth)) {
            $body['fontWidth'] = $request->fontWidth;
        }
        if (!Utils::isUnset($request->row)) {
            $body['row'] = $request->row;
        }
        if (!Utils::isUnset($request->rowCount)) {
            $body['rowCount'] = $request->rowCount;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SheetAutofitRows',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/autofitRows',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SheetAutofitRowsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary SheetAutofitRows
     *  *
     * @param string                  $workbookId
     * @param string                  $sheetId
     * @param SheetAutofitRowsRequest $request    SheetAutofitRowsRequest
     *
     * @return SheetAutofitRowsResponse SheetAutofitRowsResponse
     */
    public function sheetAutofitRows($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SheetAutofitRowsHeaders([]);

        return $this->sheetAutofitRowsWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @summary 工作表上查找所有符合条件的单元格
     *  *
     * @param string              $workbookId
     * @param string              $sheetId
     * @param SheetFindAllRequest $request    SheetFindAllRequest
     * @param SheetFindAllHeaders $headers    SheetFindAllHeaders
     * @param RuntimeOptions      $runtime    runtime options for this request RuntimeOptions
     *
     * @return SheetFindAllResponse SheetFindAllResponse
     */
    public function sheetFindAllWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->select)) {
            $query['select'] = $request->select;
        }
        $body = [];
        if (!Utils::isUnset($request->findOptions)) {
            $body['findOptions'] = $request->findOptions;
        }
        if (!Utils::isUnset($request->text)) {
            $body['text'] = $request->text;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SheetFindAll',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/findAll',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SheetFindAllResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 工作表上查找所有符合条件的单元格
     *  *
     * @param string              $workbookId
     * @param string              $sheetId
     * @param SheetFindAllRequest $request    SheetFindAllRequest
     *
     * @return SheetFindAllResponse SheetFindAllResponse
     */
    public function sheetFindAll($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SheetFindAllHeaders([]);

        return $this->sheetFindAllWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @summary 取消文档酷应用和表格的关联
     *  *
     * @param string                      $workbookId
     * @param UnbindCoolAppToSheetRequest $request    UnbindCoolAppToSheetRequest
     * @param UnbindCoolAppToSheetHeaders $headers    UnbindCoolAppToSheetHeaders
     * @param RuntimeOptions              $runtime    runtime options for this request RuntimeOptions
     *
     * @return UnbindCoolAppToSheetResponse UnbindCoolAppToSheetResponse
     */
    public function unbindCoolAppToSheetWithOptions($workbookId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->coolAppCode)) {
            $query['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'UnbindCoolAppToSheet',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/coolApps',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UnbindCoolAppToSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 取消文档酷应用和表格的关联
     *  *
     * @param string                      $workbookId
     * @param UnbindCoolAppToSheetRequest $request    UnbindCoolAppToSheetRequest
     *
     * @return UnbindCoolAppToSheetResponse UnbindCoolAppToSheetResponse
     */
    public function unbindCoolAppToSheet($workbookId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnbindCoolAppToSheetHeaders([]);

        return $this->unbindCoolAppToSheetWithOptions($workbookId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新单元格区域
     *  *
     * @param string             $workbookId
     * @param string             $sheetId
     * @param string             $rangeAddress
     * @param UpdateRangeRequest $request      UpdateRangeRequest
     * @param UpdateRangeHeaders $headers      UpdateRangeHeaders
     * @param RuntimeOptions     $runtime      runtime options for this request RuntimeOptions
     *
     * @return UpdateRangeResponse UpdateRangeResponse
     */
    public function updateRangeWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->backgroundColors)) {
            $body['backgroundColors'] = $request->backgroundColors;
        }
        if (!Utils::isUnset($request->fontSizes)) {
            $body['fontSizes'] = $request->fontSizes;
        }
        if (!Utils::isUnset($request->fontWeights)) {
            $body['fontWeights'] = $request->fontWeights;
        }
        if (!Utils::isUnset($request->horizontalAlignments)) {
            $body['horizontalAlignments'] = $request->horizontalAlignments;
        }
        if (!Utils::isUnset($request->hyperlinks)) {
            $body['hyperlinks'] = $request->hyperlinks;
        }
        if (!Utils::isUnset($request->numberFormat)) {
            $body['numberFormat'] = $request->numberFormat;
        }
        if (!Utils::isUnset($request->values)) {
            $body['values'] = $request->values;
        }
        if (!Utils::isUnset($request->verticalAlignments)) {
            $body['verticalAlignments'] = $request->verticalAlignments;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateRange',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '/ranges/' . $rangeAddress . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateRangeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新单元格区域
     *  *
     * @param string             $workbookId
     * @param string             $sheetId
     * @param string             $rangeAddress
     * @param UpdateRangeRequest $request      UpdateRangeRequest
     *
     * @return UpdateRangeResponse UpdateRangeResponse
     */
    public function updateRange($workbookId, $sheetId, $rangeAddress, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRangeHeaders([]);

        return $this->updateRangeWithOptions($workbookId, $sheetId, $rangeAddress, $request, $headers, $runtime);
    }

    /**
     * @summary 更新工作表
     *  *
     * @param string             $workbookId
     * @param string             $sheetId
     * @param UpdateSheetRequest $request    UpdateSheetRequest
     * @param UpdateSheetHeaders $headers    UpdateSheetHeaders
     * @param RuntimeOptions     $runtime    runtime options for this request RuntimeOptions
     *
     * @return UpdateSheetResponse UpdateSheetResponse
     */
    public function updateSheetWithOptions($workbookId, $sheetId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->visibility)) {
            $body['visibility'] = $request->visibility;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateSheet',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workbooks/' . $workbookId . '/sheets/' . $sheetId . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return UpdateSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新工作表
     *  *
     * @param string             $workbookId
     * @param string             $sheetId
     * @param UpdateSheetRequest $request    UpdateSheetRequest
     *
     * @return UpdateSheetResponse UpdateSheetResponse
     */
    public function updateSheet($workbookId, $sheetId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateSheetHeaders([]);

        return $this->updateSheetWithOptions($workbookId, $sheetId, $request, $headers, $runtime);
    }

    /**
     * @summary 修改知识库文档成员
     *  *
     * @param string                           $workspaceId
     * @param string                           $nodeId
     * @param UpdateWorkspaceDocMembersRequest $request     UpdateWorkspaceDocMembersRequest
     * @param UpdateWorkspaceDocMembersHeaders $headers     UpdateWorkspaceDocMembersHeaders
     * @param RuntimeOptions                   $runtime     runtime options for this request RuntimeOptions
     *
     * @return UpdateWorkspaceDocMembersResponse UpdateWorkspaceDocMembersResponse
     */
    public function updateWorkspaceDocMembersWithOptions($workspaceId, $nodeId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'action'      => 'UpdateWorkspaceDocMembers',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workspaces/' . $workspaceId . '/docs/' . $nodeId . '/members',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return UpdateWorkspaceDocMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改知识库文档成员
     *  *
     * @param string                           $workspaceId
     * @param string                           $nodeId
     * @param UpdateWorkspaceDocMembersRequest $request     UpdateWorkspaceDocMembersRequest
     *
     * @return UpdateWorkspaceDocMembersResponse UpdateWorkspaceDocMembersResponse
     */
    public function updateWorkspaceDocMembers($workspaceId, $nodeId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateWorkspaceDocMembersHeaders([]);

        return $this->updateWorkspaceDocMembersWithOptions($workspaceId, $nodeId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新知识库成员
     *  *
     * @param string                        $workspaceId
     * @param UpdateWorkspaceMembersRequest $request     UpdateWorkspaceMembersRequest
     * @param UpdateWorkspaceMembersHeaders $headers     UpdateWorkspaceMembersHeaders
     * @param RuntimeOptions                $runtime     runtime options for this request RuntimeOptions
     *
     * @return UpdateWorkspaceMembersResponse UpdateWorkspaceMembersResponse
     */
    public function updateWorkspaceMembersWithOptions($workspaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'action'      => 'UpdateWorkspaceMembers',
            'version'     => 'doc_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/doc/workspaces/' . $workspaceId . '/members',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return UpdateWorkspaceMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新知识库成员
     *  *
     * @param string                        $workspaceId
     * @param UpdateWorkspaceMembersRequest $request     UpdateWorkspaceMembersRequest
     *
     * @return UpdateWorkspaceMembersResponse UpdateWorkspaceMembersResponse
     */
    public function updateWorkspaceMembers($workspaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateWorkspaceMembersHeaders([]);

        return $this->updateWorkspaceMembersWithOptions($workspaceId, $request, $headers, $runtime);
    }
}
