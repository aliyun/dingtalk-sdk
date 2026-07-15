<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\AddRoleMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\AddRoleMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\AddRoleMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ChangeSwitchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ChangeSwitchRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ChangeSwitchResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\CopyWorkflowHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\CopyWorkflowRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\CopyWorkflowResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\CreateFieldHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\CreateFieldRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\CreateFieldResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\CreateRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\CreateRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\CreateRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\CreateSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\CreateSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\CreateSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteFieldHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteFieldRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteFieldResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteWorkflowHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteWorkflowRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DeleteWorkflowResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DisableWorkflowHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DisableWorkflowRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\DisableWorkflowResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\EnableWorkflowHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\EnableWorkflowRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\EnableWorkflowResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ExecuteImportHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ExecuteImportRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ExecuteImportResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetAllFieldsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetAllFieldsRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetAllFieldsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetAllSheetsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetAllSheetsRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetAllSheetsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetImportEncryptPublicKeyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetImportEncryptPublicKeyRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetImportEncryptPublicKeyResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetSwitchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetSwitchRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetSwitchResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetUserDocRolesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetUserDocRolesRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\GetUserDocRolesResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\InsertRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\InsertRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\InsertRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ListRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ListRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ListRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ListWorkflowsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ListWorkflowsRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ListWorkflowsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\MarkExternalAuthControlledSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\MarkExternalAuthControlledSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\MarkExternalAuthControlledSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\PrepareImportUploadHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\PrepareImportUploadRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\PrepareImportUploadResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\PrepareSetRichTextHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\PrepareSetRichTextRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\PrepareSetRichTextResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryChangedRecordIdsByClientTokenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryChangedRecordIdsByClientTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryChangedRecordIdsByClientTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryDocAllRolesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryDocAllRolesRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryDocAllRolesResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryExternalAuthControlledSheetsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryExternalAuthControlledSheetsRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryExternalAuthControlledSheetsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryImportStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryImportStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryImportStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\RebuildRoleMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\RebuildRoleMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\RebuildRoleMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\TruncateSheetRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\TruncateSheetRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\TruncateSheetRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\UnmarkExternalAuthControlledSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\UnmarkExternalAuthControlledSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\UnmarkExternalAuthControlledSheetResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\UpdateFieldHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\UpdateFieldRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\UpdateFieldResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\UpdateRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\UpdateRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\UpdateRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\UpdateRoleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\UpdateRoleRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\UpdateRoleResponse;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\UpdateSheetHeaders;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\UpdateSheetRequest;
use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\UpdateSheetResponse;
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
     * @summary 添加角色成员
     *  *
     * @param string               $baseId
     * @param AddRoleMemberRequest $request AddRoleMemberRequest
     * @param AddRoleMemberHeaders $headers AddRoleMemberHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return AddRoleMemberResponse AddRoleMemberResponse
     */
    public function addRoleMemberWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->roleMemberList)) {
            $body['roleMemberList'] = $request->roleMemberList;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'AddRoleMember',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/auth/role/member/' . $baseId . '',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddRoleMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加角色成员
     *  *
     * @param string               $baseId
     * @param AddRoleMemberRequest $request AddRoleMemberRequest
     *
     * @return AddRoleMemberResponse AddRoleMemberResponse
     */
    public function addRoleMember($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddRoleMemberHeaders([]);

        return $this->addRoleMemberWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 修改高级权限设置开关
     *  *
     * @param string              $baseId
     * @param ChangeSwitchRequest $request ChangeSwitchRequest
     * @param ChangeSwitchHeaders $headers ChangeSwitchHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return ChangeSwitchResponse ChangeSwitchResponse
     */
    public function changeSwitchWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ChangeSwitch',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/auth/' . $baseId . '',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ChangeSwitchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改高级权限设置开关
     *  *
     * @param string              $baseId
     * @param ChangeSwitchRequest $request ChangeSwitchRequest
     *
     * @return ChangeSwitchResponse ChangeSwitchResponse
     */
    public function changeSwitch($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ChangeSwitchHeaders([]);

        return $this->changeSwitchWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 复制工作流
     *  *
     * @param string              $baseId
     * @param CopyWorkflowRequest $request CopyWorkflowRequest
     * @param CopyWorkflowHeaders $headers CopyWorkflowHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return CopyWorkflowResponse CopyWorkflowResponse
     */
    public function copyWorkflowWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->flowId)) {
            $body['flowId'] = $request->flowId;
        }
        if (!Utils::isUnset($request->flowVersionId)) {
            $body['flowVersionId'] = $request->flowVersionId;
        }
        if (!Utils::isUnset($request->isSystem)) {
            $body['isSystem'] = $request->isSystem;
        }
        if (!Utils::isUnset($request->sourceBaseId)) {
            $body['sourceBaseId'] = $request->sourceBaseId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CopyWorkflow',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/workflows/copy',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CopyWorkflowResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 复制工作流
     *  *
     * @param string              $baseId
     * @param CopyWorkflowRequest $request CopyWorkflowRequest
     *
     * @return CopyWorkflowResponse CopyWorkflowResponse
     */
    public function copyWorkflow($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CopyWorkflowHeaders([]);

        return $this->copyWorkflowWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 新增数据表字段
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param CreateFieldRequest $request       CreateFieldRequest
     * @param CreateFieldHeaders $headers       CreateFieldHeaders
     * @param RuntimeOptions     $runtime       runtime options for this request RuntimeOptions
     *
     * @return CreateFieldResponse CreateFieldResponse
     */
    public function createFieldWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
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
        if (!Utils::isUnset($request->property)) {
            $body['property'] = $request->property;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateField',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/fields',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateFieldResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增数据表字段
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param CreateFieldRequest $request       CreateFieldRequest
     *
     * @return CreateFieldResponse CreateFieldResponse
     */
    public function createField($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateFieldHeaders([]);

        return $this->createFieldWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 创建角色
     *  *
     * @param string            $baseId
     * @param CreateRoleRequest $request CreateRoleRequest
     * @param CreateRoleHeaders $headers CreateRoleHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateRoleResponse CreateRoleResponse
     */
    public function createRoleWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->flowType)) {
            $body['flowType'] = $request->flowType;
        }
        if (!Utils::isUnset($request->id)) {
            $body['id'] = $request->id;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->roleType)) {
            $body['roleType'] = $request->roleType;
        }
        if (!Utils::isUnset($request->subRoles)) {
            $body['subRoles'] = $request->subRoles;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateRole',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/auth/role/' . $baseId . '',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateRoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建角色
     *  *
     * @param string            $baseId
     * @param CreateRoleRequest $request CreateRoleRequest
     *
     * @return CreateRoleResponse CreateRoleResponse
     */
    public function createRole($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateRoleHeaders([]);

        return $this->createRoleWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建数据表
     *  *
     * @param string             $baseId
     * @param CreateSheetRequest $request CreateSheetRequest
     * @param CreateSheetHeaders $headers CreateSheetHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateSheetResponse CreateSheetResponse
     */
    public function createSheetWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->fields)) {
            $body['fields'] = $request->fields;
        }
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateSheet',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建数据表
     *  *
     * @param string             $baseId
     * @param CreateSheetRequest $request CreateSheetRequest
     *
     * @return CreateSheetResponse CreateSheetResponse
     */
    public function createSheet($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSheetHeaders([]);

        return $this->createSheetWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除数据表字段
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param string             $fieldIdOrName
     * @param DeleteFieldRequest $request       DeleteFieldRequest
     * @param DeleteFieldHeaders $headers       DeleteFieldHeaders
     * @param RuntimeOptions     $runtime       runtime options for this request RuntimeOptions
     *
     * @return DeleteFieldResponse DeleteFieldResponse
     */
    public function deleteFieldWithOptions($baseId, $sheetIdOrName, $fieldIdOrName, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteField',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/fields/' . $fieldIdOrName . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteFieldResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除数据表字段
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param string             $fieldIdOrName
     * @param DeleteFieldRequest $request       DeleteFieldRequest
     *
     * @return DeleteFieldResponse DeleteFieldResponse
     */
    public function deleteField($baseId, $sheetIdOrName, $fieldIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteFieldHeaders([]);

        return $this->deleteFieldWithOptions($baseId, $sheetIdOrName, $fieldIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 删除数据表多行记录
     *  *
     * @param string               $baseId
     * @param string               $sheetIdOrName
     * @param DeleteRecordsRequest $request       DeleteRecordsRequest
     * @param DeleteRecordsHeaders $headers       DeleteRecordsHeaders
     * @param RuntimeOptions       $runtime       runtime options for this request RuntimeOptions
     *
     * @return DeleteRecordsResponse DeleteRecordsResponse
     */
    public function deleteRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->recordIds)) {
            $body['recordIds'] = $request->recordIds;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DeleteRecords',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/records/delete',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除数据表多行记录
     *  *
     * @param string               $baseId
     * @param string               $sheetIdOrName
     * @param DeleteRecordsRequest $request       DeleteRecordsRequest
     *
     * @return DeleteRecordsResponse DeleteRecordsResponse
     */
    public function deleteRecords($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRecordsHeaders([]);

        return $this->deleteRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 删除角色
     *  *
     * @param string            $baseId
     * @param DeleteRoleRequest $request DeleteRoleRequest
     * @param DeleteRoleHeaders $headers DeleteRoleHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteRoleResponse DeleteRoleResponse
     */
    public function deleteRoleWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->roleId)) {
            $body['roleId'] = $request->roleId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DeleteRole',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/auth/role/' . $baseId . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteRoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除角色
     *  *
     * @param string            $baseId
     * @param DeleteRoleRequest $request DeleteRoleRequest
     *
     * @return DeleteRoleResponse DeleteRoleResponse
     */
    public function deleteRole($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRoleHeaders([]);

        return $this->deleteRoleWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除数据表
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param DeleteSheetRequest $request       DeleteSheetRequest
     * @param DeleteSheetHeaders $headers       DeleteSheetHeaders
     * @param RuntimeOptions     $runtime       runtime options for this request RuntimeOptions
     *
     * @return DeleteSheetResponse DeleteSheetResponse
     */
    public function deleteSheetWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteSheet',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除数据表
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param DeleteSheetRequest $request       DeleteSheetRequest
     *
     * @return DeleteSheetResponse DeleteSheetResponse
     */
    public function deleteSheet($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSheetHeaders([]);

        return $this->deleteSheetWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 删除工作流
     *  *
     * @param string                $baseId
     * @param string                $flowId
     * @param DeleteWorkflowRequest $request DeleteWorkflowRequest
     * @param DeleteWorkflowHeaders $headers DeleteWorkflowHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteWorkflowResponse DeleteWorkflowResponse
     */
    public function deleteWorkflowWithOptions($baseId, $flowId, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteWorkflow',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/workflows/' . $flowId . '/delete',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteWorkflowResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除工作流
     *  *
     * @param string                $baseId
     * @param string                $flowId
     * @param DeleteWorkflowRequest $request DeleteWorkflowRequest
     *
     * @return DeleteWorkflowResponse DeleteWorkflowResponse
     */
    public function deleteWorkflow($baseId, $flowId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteWorkflowHeaders([]);

        return $this->deleteWorkflowWithOptions($baseId, $flowId, $request, $headers, $runtime);
    }

    /**
     * @summary 关闭工作流
     *  *
     * @param string                 $baseId
     * @param string                 $flowId
     * @param DisableWorkflowRequest $request DisableWorkflowRequest
     * @param DisableWorkflowHeaders $headers DisableWorkflowHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return DisableWorkflowResponse DisableWorkflowResponse
     */
    public function disableWorkflowWithOptions($baseId, $flowId, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DisableWorkflow',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/workflows/' . $flowId . '/disable',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DisableWorkflowResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 关闭工作流
     *  *
     * @param string                 $baseId
     * @param string                 $flowId
     * @param DisableWorkflowRequest $request DisableWorkflowRequest
     *
     * @return DisableWorkflowResponse DisableWorkflowResponse
     */
    public function disableWorkflow($baseId, $flowId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DisableWorkflowHeaders([]);

        return $this->disableWorkflowWithOptions($baseId, $flowId, $request, $headers, $runtime);
    }

    /**
     * @summary 启动单个工作流
     *  *
     * @param string                $baseId
     * @param string                $flowId
     * @param EnableWorkflowRequest $request EnableWorkflowRequest
     * @param EnableWorkflowHeaders $headers EnableWorkflowHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return EnableWorkflowResponse EnableWorkflowResponse
     */
    public function enableWorkflowWithOptions($baseId, $flowId, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'EnableWorkflow',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/workflows/' . $flowId . '/enable',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return EnableWorkflowResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 启动单个工作流
     *  *
     * @param string                $baseId
     * @param string                $flowId
     * @param EnableWorkflowRequest $request EnableWorkflowRequest
     *
     * @return EnableWorkflowResponse EnableWorkflowResponse
     */
    public function enableWorkflow($baseId, $flowId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EnableWorkflowHeaders([]);

        return $this->enableWorkflowWithOptions($baseId, $flowId, $request, $headers, $runtime);
    }

    /**
     * @summary 触发加密导入
     *  *
     * @param string               $baseId
     * @param ExecuteImportRequest $request ExecuteImportRequest
     * @param ExecuteImportHeaders $headers ExecuteImportHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return ExecuteImportResponse ExecuteImportResponse
     */
    public function executeImportWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->appendConfig)) {
            $body['appendConfig'] = $request->appendConfig;
        }
        if (!Utils::isUnset($request->encryption)) {
            $body['encryption'] = $request->encryption;
        }
        if (!Utils::isUnset($request->importId)) {
            $body['importId'] = $request->importId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ExecuteImport',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/import/execute',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ExecuteImportResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 触发加密导入
     *  *
     * @param string               $baseId
     * @param ExecuteImportRequest $request ExecuteImportRequest
     *
     * @return ExecuteImportResponse ExecuteImportResponse
     */
    public function executeImport($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecuteImportHeaders([]);

        return $this->executeImportWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取所有字段
     *  *
     * @param string              $baseId
     * @param string              $sheetIdOrName
     * @param GetAllFieldsRequest $request       GetAllFieldsRequest
     * @param GetAllFieldsHeaders $headers       GetAllFieldsHeaders
     * @param RuntimeOptions      $runtime       runtime options for this request RuntimeOptions
     *
     * @return GetAllFieldsResponse GetAllFieldsResponse
     */
    public function getAllFieldsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetAllFields',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/fields',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetAllFieldsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取所有字段
     *  *
     * @param string              $baseId
     * @param string              $sheetIdOrName
     * @param GetAllFieldsRequest $request       GetAllFieldsRequest
     *
     * @return GetAllFieldsResponse GetAllFieldsResponse
     */
    public function getAllFields($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllFieldsHeaders([]);

        return $this->getAllFieldsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 获取所有数据表
     *  *
     * @param string              $baseId
     * @param GetAllSheetsRequest $request GetAllSheetsRequest
     * @param GetAllSheetsHeaders $headers GetAllSheetsHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAllSheetsResponse GetAllSheetsResponse
     */
    public function getAllSheetsWithOptions($baseId, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetAllSheets',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetAllSheetsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取所有数据表
     *  *
     * @param string              $baseId
     * @param GetAllSheetsRequest $request GetAllSheetsRequest
     *
     * @return GetAllSheetsResponse GetAllSheetsResponse
     */
    public function getAllSheets($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAllSheetsHeaders([]);

        return $this->getAllSheetsWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取加密导入 RSA 公钥
     *  *
     * @param GetImportEncryptPublicKeyRequest $request GetImportEncryptPublicKeyRequest
     * @param GetImportEncryptPublicKeyHeaders $headers GetImportEncryptPublicKeyHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return GetImportEncryptPublicKeyResponse GetImportEncryptPublicKeyResponse
     */
    public function getImportEncryptPublicKeyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->keyVersion)) {
            $query['keyVersion'] = $request->keyVersion;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetImportEncryptPublicKey',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/import/encryptPublicKey',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetImportEncryptPublicKeyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取加密导入 RSA 公钥
     *  *
     * @param GetImportEncryptPublicKeyRequest $request GetImportEncryptPublicKeyRequest
     *
     * @return GetImportEncryptPublicKeyResponse GetImportEncryptPublicKeyResponse
     */
    public function getImportEncryptPublicKey($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetImportEncryptPublicKeyHeaders([]);

        return $this->getImportEncryptPublicKeyWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取记录
     *  *
     * @param string           $baseId
     * @param string           $sheetIdOrName
     * @param string           $recordId
     * @param GetRecordRequest $request       GetRecordRequest
     * @param GetRecordHeaders $headers       GetRecordHeaders
     * @param RuntimeOptions   $runtime       runtime options for this request RuntimeOptions
     *
     * @return GetRecordResponse GetRecordResponse
     */
    public function getRecordWithOptions($baseId, $sheetIdOrName, $recordId, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetRecord',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/records/' . $recordId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取记录
     *  *
     * @param string           $baseId
     * @param string           $sheetIdOrName
     * @param string           $recordId
     * @param GetRecordRequest $request       GetRecordRequest
     *
     * @return GetRecordResponse GetRecordResponse
     */
    public function getRecord($baseId, $sheetIdOrName, $recordId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRecordHeaders([]);

        return $this->getRecordWithOptions($baseId, $sheetIdOrName, $recordId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取多行记录
     *  *
     * @param string            $baseId
     * @param string            $sheetIdOrName
     * @param GetRecordsRequest $request       GetRecordsRequest
     * @param GetRecordsHeaders $headers       GetRecordsHeaders
     * @param RuntimeOptions    $runtime       runtime options for this request RuntimeOptions
     *
     * @return GetRecordsResponse GetRecordsResponse
     */
    public function getRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetRecords',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/records',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取多行记录
     *  *
     * @param string            $baseId
     * @param string            $sheetIdOrName
     * @param GetRecordsRequest $request       GetRecordsRequest
     *
     * @return GetRecordsResponse GetRecordsResponse
     */
    public function getRecords($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRecordsHeaders([]);

        return $this->getRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 获取数据表
     *  *
     * @param string          $baseId
     * @param string          $sheetIdOrName
     * @param GetSheetRequest $request       GetSheetRequest
     * @param GetSheetHeaders $headers       GetSheetHeaders
     * @param RuntimeOptions  $runtime       runtime options for this request RuntimeOptions
     *
     * @return GetSheetResponse GetSheetResponse
     */
    public function getSheetWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetSheet',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取数据表
     *  *
     * @param string          $baseId
     * @param string          $sheetIdOrName
     * @param GetSheetRequest $request       GetSheetRequest
     *
     * @return GetSheetResponse GetSheetResponse
     */
    public function getSheet($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSheetHeaders([]);

        return $this->getSheetWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 获取高级权限设置开关
     *  *
     * @param string           $baseId
     * @param GetSwitchRequest $request GetSwitchRequest
     * @param GetSwitchHeaders $headers GetSwitchHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSwitchResponse GetSwitchResponse
     */
    public function getSwitchWithOptions($baseId, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetSwitch',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/auth/' . $baseId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSwitchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取高级权限设置开关
     *  *
     * @param string           $baseId
     * @param GetSwitchRequest $request GetSwitchRequest
     *
     * @return GetSwitchResponse GetSwitchResponse
     */
    public function getSwitch($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSwitchHeaders([]);

        return $this->getSwitchWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取指定用户的高级权限角色配置列表
     *  *
     * @param string                 $baseId
     * @param GetUserDocRolesRequest $request GetUserDocRolesRequest
     * @param GetUserDocRolesHeaders $headers GetUserDocRolesHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserDocRolesResponse GetUserDocRolesResponse
     */
    public function getUserDocRolesWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
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
            'action' => 'GetUserDocRoles',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/auth/role/' . $baseId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetUserDocRolesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取指定用户的高级权限角色配置列表
     *  *
     * @param string                 $baseId
     * @param GetUserDocRolesRequest $request GetUserDocRolesRequest
     *
     * @return GetUserDocRolesResponse GetUserDocRolesResponse
     */
    public function getUserDocRoles($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserDocRolesHeaders([]);

        return $this->getUserDocRolesWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 新增记录
     *  *
     * @param string               $baseId
     * @param string               $sheetIdOrName
     * @param InsertRecordsRequest $request       InsertRecordsRequest
     * @param InsertRecordsHeaders $headers       InsertRecordsHeaders
     * @param RuntimeOptions       $runtime       runtime options for this request RuntimeOptions
     *
     * @return InsertRecordsResponse InsertRecordsResponse
     */
    public function insertRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->clientToken)) {
            $query['clientToken'] = $request->clientToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->records)) {
            $body['records'] = $request->records;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'InsertRecords',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/records',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return InsertRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增记录
     *  *
     * @param string               $baseId
     * @param string               $sheetIdOrName
     * @param InsertRecordsRequest $request       InsertRecordsRequest
     *
     * @return InsertRecordsResponse InsertRecordsResponse
     */
    public function insertRecords($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InsertRecordsHeaders([]);

        return $this->insertRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 列出多行记录
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param ListRecordsRequest $request       ListRecordsRequest
     * @param ListRecordsHeaders $headers       ListRecordsHeaders
     * @param RuntimeOptions     $runtime       runtime options for this request RuntimeOptions
     *
     * @return ListRecordsResponse ListRecordsResponse
     */
    public function listRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->calcFields)) {
            $body['calcFields'] = $request->calcFields;
        }
        if (!Utils::isUnset($request->fieldIdOrNames)) {
            $body['fieldIdOrNames'] = $request->fieldIdOrNames;
        }
        if (!Utils::isUnset($request->filter)) {
            $body['filter'] = $request->filter;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ListRecords',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/records/list',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 列出多行记录
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param ListRecordsRequest $request       ListRecordsRequest
     *
     * @return ListRecordsResponse ListRecordsResponse
     */
    public function listRecords($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListRecordsHeaders([]);

        return $this->listRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 查询自动化工作流列表
     *  *
     * @param string               $baseId
     * @param ListWorkflowsRequest $request ListWorkflowsRequest
     * @param ListWorkflowsHeaders $headers ListWorkflowsHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return ListWorkflowsResponse ListWorkflowsResponse
     */
    public function listWorkflowsWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->limit)) {
            $body['limit'] = $request->limit;
        }
        if (!Utils::isUnset($request->offset)) {
            $body['offset'] = $request->offset;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ListWorkflows',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/workflows',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListWorkflowsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询自动化工作流列表
     *  *
     * @param string               $baseId
     * @param ListWorkflowsRequest $request ListWorkflowsRequest
     *
     * @return ListWorkflowsResponse ListWorkflowsResponse
     */
    public function listWorkflows($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListWorkflowsHeaders([]);

        return $this->listWorkflowsWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 标记外部权限受控 Sheet
     *  *
     * @param string                                 $baseId
     * @param string                                 $sheetIdOrName
     * @param MarkExternalAuthControlledSheetRequest $request       MarkExternalAuthControlledSheetRequest
     * @param MarkExternalAuthControlledSheetHeaders $headers       MarkExternalAuthControlledSheetHeaders
     * @param RuntimeOptions                         $runtime       runtime options for this request RuntimeOptions
     *
     * @return MarkExternalAuthControlledSheetResponse MarkExternalAuthControlledSheetResponse
     */
    public function markExternalAuthControlledSheetWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->clientToken)) {
            $query['clientToken'] = $request->clientToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->externalAuthType)) {
            $body['externalAuthType'] = $request->externalAuthType;
        }
        if (!Utils::isUnset($request->externalConfig)) {
            $body['externalConfig'] = $request->externalConfig;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'MarkExternalAuthControlledSheet',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/externalAuth/mark',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return MarkExternalAuthControlledSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 标记外部权限受控 Sheet
     *  *
     * @param string                                 $baseId
     * @param string                                 $sheetIdOrName
     * @param MarkExternalAuthControlledSheetRequest $request       MarkExternalAuthControlledSheetRequest
     *
     * @return MarkExternalAuthControlledSheetResponse MarkExternalAuthControlledSheetResponse
     */
    public function markExternalAuthControlledSheet($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MarkExternalAuthControlledSheetHeaders([]);

        return $this->markExternalAuthControlledSheetWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 申请加密导入上传链接
     *  *
     * @param string                     $baseId
     * @param PrepareImportUploadRequest $request PrepareImportUploadRequest
     * @param PrepareImportUploadHeaders $headers PrepareImportUploadHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return PrepareImportUploadResponse PrepareImportUploadResponse
     */
    public function prepareImportUploadWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->fileExtension)) {
            $body['fileExtension'] = $request->fileExtension;
        }
        if (!Utils::isUnset($request->fileName)) {
            $body['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->fileSize)) {
            $body['fileSize'] = $request->fileSize;
        }
        if (!Utils::isUnset($request->tableNames)) {
            $body['tableNames'] = $request->tableNames;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PrepareImportUpload',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/import/uploadUrl',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PrepareImportUploadResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 申请加密导入上传链接
     *  *
     * @param string                     $baseId
     * @param PrepareImportUploadRequest $request PrepareImportUploadRequest
     *
     * @return PrepareImportUploadResponse PrepareImportUploadResponse
     */
    public function prepareImportUpload($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PrepareImportUploadHeaders([]);

        return $this->prepareImportUploadWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 富文本值预处理
     *  *
     * @param string                    $baseId
     * @param PrepareSetRichTextRequest $request PrepareSetRichTextRequest
     * @param PrepareSetRichTextHeaders $headers PrepareSetRichTextHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return PrepareSetRichTextResponse PrepareSetRichTextResponse
     */
    public function prepareSetRichTextWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->markdown)) {
            $body['markdown'] = $request->markdown;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PrepareSetRichText',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/prepareSetRichText',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PrepareSetRichTextResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 富文本值预处理
     *  *
     * @param string                    $baseId
     * @param PrepareSetRichTextRequest $request PrepareSetRichTextRequest
     *
     * @return PrepareSetRichTextResponse PrepareSetRichTextResponse
     */
    public function prepareSetRichText($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PrepareSetRichTextHeaders([]);

        return $this->prepareSetRichTextWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 根据 clientToken 查询变更记录 ID
     *  *
     * @param string                                    $baseId
     * @param QueryChangedRecordIdsByClientTokenRequest $request QueryChangedRecordIdsByClientTokenRequest
     * @param QueryChangedRecordIdsByClientTokenHeaders $headers QueryChangedRecordIdsByClientTokenHeaders
     * @param RuntimeOptions                            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryChangedRecordIdsByClientTokenResponse QueryChangedRecordIdsByClientTokenResponse
     */
    public function queryChangedRecordIdsByClientTokenWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->clientToken)) {
            $body['clientToken'] = $request->clientToken;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryChangedRecordIdsByClientToken',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/changedRecordIds/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryChangedRecordIdsByClientTokenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据 clientToken 查询变更记录 ID
     *  *
     * @param string                                    $baseId
     * @param QueryChangedRecordIdsByClientTokenRequest $request QueryChangedRecordIdsByClientTokenRequest
     *
     * @return QueryChangedRecordIdsByClientTokenResponse QueryChangedRecordIdsByClientTokenResponse
     */
    public function queryChangedRecordIdsByClientToken($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryChangedRecordIdsByClientTokenHeaders([]);

        return $this->queryChangedRecordIdsByClientTokenWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询文档所有角色和角色成员
     *  *
     * @param string                  $baseId
     * @param QueryDocAllRolesRequest $request QueryDocAllRolesRequest
     * @param QueryDocAllRolesHeaders $headers QueryDocAllRolesHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDocAllRolesResponse QueryDocAllRolesResponse
     */
    public function queryDocAllRolesWithOptions($baseId, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryDocAllRoles',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/auth/role/member/' . $baseId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryDocAllRolesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询文档所有角色和角色成员
     *  *
     * @param string                  $baseId
     * @param QueryDocAllRolesRequest $request QueryDocAllRolesRequest
     *
     * @return QueryDocAllRolesResponse QueryDocAllRolesResponse
     */
    public function queryDocAllRoles($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDocAllRolesHeaders([]);

        return $this->queryDocAllRolesWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询外部权限受控 Sheet 列表
     *  *
     * @param string                                   $baseId
     * @param QueryExternalAuthControlledSheetsRequest $request QueryExternalAuthControlledSheetsRequest
     * @param QueryExternalAuthControlledSheetsHeaders $headers QueryExternalAuthControlledSheetsHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryExternalAuthControlledSheetsResponse QueryExternalAuthControlledSheetsResponse
     */
    public function queryExternalAuthControlledSheetsWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->externalAuthType)) {
            $query['externalAuthType'] = $request->externalAuthType;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action' => 'QueryExternalAuthControlledSheets',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/externalAuth/sheets',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryExternalAuthControlledSheetsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询外部权限受控 Sheet 列表
     *  *
     * @param string                                   $baseId
     * @param QueryExternalAuthControlledSheetsRequest $request QueryExternalAuthControlledSheetsRequest
     *
     * @return QueryExternalAuthControlledSheetsResponse QueryExternalAuthControlledSheetsResponse
     */
    public function queryExternalAuthControlledSheets($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryExternalAuthControlledSheetsHeaders([]);

        return $this->queryExternalAuthControlledSheetsWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询导入会话状态
     *  *
     * @param string                   $baseId
     * @param QueryImportStatusRequest $request QueryImportStatusRequest
     * @param QueryImportStatusHeaders $headers QueryImportStatusHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryImportStatusResponse QueryImportStatusResponse
     */
    public function queryImportStatusWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->importId)) {
            $query['importId'] = $request->importId;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryImportStatus',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/import/status',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryImportStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询导入会话状态
     *  *
     * @param string                   $baseId
     * @param QueryImportStatusRequest $request QueryImportStatusRequest
     *
     * @return QueryImportStatusResponse QueryImportStatusResponse
     */
    public function queryImportStatus($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryImportStatusHeaders([]);

        return $this->queryImportStatusWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 重建角色成员
     *  *
     * @param string                    $baseId
     * @param RebuildRoleMembersRequest $request RebuildRoleMembersRequest
     * @param RebuildRoleMembersHeaders $headers RebuildRoleMembersHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return RebuildRoleMembersResponse RebuildRoleMembersResponse
     */
    public function rebuildRoleMembersWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->defaultRoleDTO)) {
            $body['defaultRoleDTO'] = $request->defaultRoleDTO;
        }
        if (!Utils::isUnset($request->toRoleMemberDTOMap)) {
            $body['toRoleMemberDTOMap'] = $request->toRoleMemberDTOMap;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'RebuildRoleMembers',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/auth/role/member/' . $baseId . '',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RebuildRoleMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 重建角色成员
     *  *
     * @param string                    $baseId
     * @param RebuildRoleMembersRequest $request RebuildRoleMembersRequest
     *
     * @return RebuildRoleMembersResponse RebuildRoleMembersResponse
     */
    public function rebuildRoleMembers($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RebuildRoleMembersHeaders([]);

        return $this->rebuildRoleMembersWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 清空表格记录
     *  *
     * @param string                      $baseId
     * @param string                      $sheetIdOrName
     * @param TruncateSheetRecordsRequest $request       TruncateSheetRecordsRequest
     * @param TruncateSheetRecordsHeaders $headers       TruncateSheetRecordsHeaders
     * @param RuntimeOptions              $runtime       runtime options for this request RuntimeOptions
     *
     * @return TruncateSheetRecordsResponse TruncateSheetRecordsResponse
     */
    public function truncateSheetRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'TruncateSheetRecords',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/records/truncate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TruncateSheetRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 清空表格记录
     *  *
     * @param string                      $baseId
     * @param string                      $sheetIdOrName
     * @param TruncateSheetRecordsRequest $request       TruncateSheetRecordsRequest
     *
     * @return TruncateSheetRecordsResponse TruncateSheetRecordsResponse
     */
    public function truncateSheetRecords($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TruncateSheetRecordsHeaders([]);

        return $this->truncateSheetRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 取消标记外部权限受控 Sheet
     *  *
     * @param string                                   $baseId
     * @param string                                   $sheetIdOrName
     * @param UnmarkExternalAuthControlledSheetRequest $request       UnmarkExternalAuthControlledSheetRequest
     * @param UnmarkExternalAuthControlledSheetHeaders $headers       UnmarkExternalAuthControlledSheetHeaders
     * @param RuntimeOptions                           $runtime       runtime options for this request RuntimeOptions
     *
     * @return UnmarkExternalAuthControlledSheetResponse UnmarkExternalAuthControlledSheetResponse
     */
    public function unmarkExternalAuthControlledSheetWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->clientToken)) {
            $query['clientToken'] = $request->clientToken;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'UnmarkExternalAuthControlledSheet',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/externalAuth/mark',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UnmarkExternalAuthControlledSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 取消标记外部权限受控 Sheet
     *  *
     * @param string                                   $baseId
     * @param string                                   $sheetIdOrName
     * @param UnmarkExternalAuthControlledSheetRequest $request       UnmarkExternalAuthControlledSheetRequest
     *
     * @return UnmarkExternalAuthControlledSheetResponse UnmarkExternalAuthControlledSheetResponse
     */
    public function unmarkExternalAuthControlledSheet($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnmarkExternalAuthControlledSheetHeaders([]);

        return $this->unmarkExternalAuthControlledSheetWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 更新数据表字段
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param string             $fieldIdOrName
     * @param UpdateFieldRequest $request       UpdateFieldRequest
     * @param UpdateFieldHeaders $headers       UpdateFieldHeaders
     * @param RuntimeOptions     $runtime       runtime options for this request RuntimeOptions
     *
     * @return UpdateFieldResponse UpdateFieldResponse
     */
    public function updateFieldWithOptions($baseId, $sheetIdOrName, $fieldIdOrName, $request, $headers, $runtime)
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
        if (!Utils::isUnset($request->property)) {
            $body['property'] = $request->property;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateField',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/fields/' . $fieldIdOrName . '',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateFieldResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新数据表字段
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param string             $fieldIdOrName
     * @param UpdateFieldRequest $request       UpdateFieldRequest
     *
     * @return UpdateFieldResponse UpdateFieldResponse
     */
    public function updateField($baseId, $sheetIdOrName, $fieldIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateFieldHeaders([]);

        return $this->updateFieldWithOptions($baseId, $sheetIdOrName, $fieldIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 更新数据表多行记录
     *  *
     * @param string               $baseId
     * @param string               $sheetIdOrName
     * @param UpdateRecordsRequest $request       UpdateRecordsRequest
     * @param UpdateRecordsHeaders $headers       UpdateRecordsHeaders
     * @param RuntimeOptions       $runtime       runtime options for this request RuntimeOptions
     *
     * @return UpdateRecordsResponse UpdateRecordsResponse
     */
    public function updateRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->records)) {
            $body['records'] = $request->records;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateRecords',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '/records',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新数据表多行记录
     *  *
     * @param string               $baseId
     * @param string               $sheetIdOrName
     * @param UpdateRecordsRequest $request       UpdateRecordsRequest
     *
     * @return UpdateRecordsResponse UpdateRecordsResponse
     */
    public function updateRecords($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRecordsHeaders([]);

        return $this->updateRecordsWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }

    /**
     * @summary 更新角色
     *  *
     * @param string            $baseId
     * @param UpdateRoleRequest $request UpdateRoleRequest
     * @param UpdateRoleHeaders $headers UpdateRoleHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateRoleResponse UpdateRoleResponse
     */
    public function updateRoleWithOptions($baseId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->flowType)) {
            $body['flowType'] = $request->flowType;
        }
        if (!Utils::isUnset($request->id)) {
            $body['id'] = $request->id;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->roleType)) {
            $body['roleType'] = $request->roleType;
        }
        if (!Utils::isUnset($request->subRoles)) {
            $body['subRoles'] = $request->subRoles;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateRole',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/auth/role/' . $baseId . '',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateRoleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新角色
     *  *
     * @param string            $baseId
     * @param UpdateRoleRequest $request UpdateRoleRequest
     *
     * @return UpdateRoleResponse UpdateRoleResponse
     */
    public function updateRole($baseId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRoleHeaders([]);

        return $this->updateRoleWithOptions($baseId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新数据表
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param UpdateSheetRequest $request       UpdateSheetRequest
     * @param UpdateSheetHeaders $headers       UpdateSheetHeaders
     * @param RuntimeOptions     $runtime       runtime options for this request RuntimeOptions
     *
     * @return UpdateSheetResponse UpdateSheetResponse
     */
    public function updateSheetWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateSheet',
            'version' => 'notable_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/notable/bases/' . $baseId . '/sheets/' . $sheetIdOrName . '',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateSheetResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新数据表
     *  *
     * @param string             $baseId
     * @param string             $sheetIdOrName
     * @param UpdateSheetRequest $request       UpdateSheetRequest
     *
     * @return UpdateSheetResponse UpdateSheetResponse
     */
    public function updateSheet($baseId, $sheetIdOrName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateSheetHeaders([]);

        return $this->updateSheetWithOptions($baseId, $sheetIdOrName, $request, $headers, $runtime);
    }
}
