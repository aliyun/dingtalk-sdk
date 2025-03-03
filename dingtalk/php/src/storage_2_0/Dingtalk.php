<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\AddPermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\AddPermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\AddPermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\CommitFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\CommitFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\CommitFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\DeletePermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\DeletePermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\DeletePermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\GetFileUploadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\GetFileUploadInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\GetFileUploadInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\GetPermissionInheritanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\GetPermissionInheritanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\GetPermissionInheritanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\GetPermissionShareScopeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\GetPermissionShareScopeRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\GetPermissionShareScopeResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListOperationLogsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListOperationLogsRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListOperationLogsResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListPermissionsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListPermissionsRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListPermissionsResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ManagerGetDefaultHandOverUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ManagerGetDefaultHandOverUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ManagerGetDefaultHandOverUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ManagerSetDefaultHandOverUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ManagerSetDefaultHandOverUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ManagerSetDefaultHandOverUserResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchDentriesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchDentriesRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchDentriesResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchPublishDentriesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchPublishDentriesRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchPublishDentriesResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchWorkspacesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchWorkspacesRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchWorkspacesResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SetPermissionInheritanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SetPermissionInheritanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SetPermissionInheritanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SetPermissionShareScopeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SetPermissionShareScopeRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SetPermissionShareScopeResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\UpdatePermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\UpdatePermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\UpdatePermissionResponse;
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
     * @summary 添加权限
     *  *
     * @param string               $dentryUuid
     * @param AddPermissionRequest $request    AddPermissionRequest
     * @param AddPermissionHeaders $headers    AddPermissionHeaders
     * @param RuntimeOptions       $runtime    runtime options for this request RuntimeOptions
     *
     * @return AddPermissionResponse AddPermissionResponse
     */
    public function addPermissionWithOptions($dentryUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
        }
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
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AddPermission',
            'version'     => 'storage_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/storage/spaces/dentries/' . $dentryUuid . '/permissions',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddPermissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加权限
     *  *
     * @param string               $dentryUuid
     * @param AddPermissionRequest $request    AddPermissionRequest
     *
     * @return AddPermissionResponse AddPermissionResponse
     */
    public function addPermission($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddPermissionHeaders([]);

        return $this->addPermissionWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 提交文件
     *  *
     * @param string            $parentDentryUuid
     * @param CommitFileRequest $request          CommitFileRequest
     * @param CommitFileHeaders $headers          CommitFileHeaders
     * @param RuntimeOptions    $runtime          runtime options for this request RuntimeOptions
     *
     * @return CommitFileResponse CommitFileResponse
     */
    public function commitFileWithOptions($parentDentryUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->uploadKey)) {
            $body['uploadKey'] = $request->uploadKey;
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
            'action'      => 'CommitFile',
            'version'     => 'storage_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/storage/spaces/files/' . $parentDentryUuid . '/commit',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CommitFileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 提交文件
     *  *
     * @param string            $parentDentryUuid
     * @param CommitFileRequest $request          CommitFileRequest
     *
     * @return CommitFileResponse CommitFileResponse
     */
    public function commitFile($parentDentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CommitFileHeaders([]);

        return $this->commitFileWithOptions($parentDentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 删除权限
     *  *
     * @param string                  $dentryUuid
     * @param DeletePermissionRequest $request    DeletePermissionRequest
     * @param DeletePermissionHeaders $headers    DeletePermissionHeaders
     * @param RuntimeOptions          $runtime    runtime options for this request RuntimeOptions
     *
     * @return DeletePermissionResponse DeletePermissionResponse
     */
    public function deletePermissionWithOptions($dentryUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
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
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DeletePermission',
            'version'     => 'storage_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/storage/spaces/dentries/' . $dentryUuid . '/permissions/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeletePermissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除权限
     *  *
     * @param string                  $dentryUuid
     * @param DeletePermissionRequest $request    DeletePermissionRequest
     *
     * @return DeletePermissionResponse DeletePermissionResponse
     */
    public function deletePermission($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeletePermissionHeaders([]);

        return $this->deletePermissionWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 获取文件上传信息
     *  *
     * @param string                   $parentDentryUuid
     * @param GetFileUploadInfoRequest $request          GetFileUploadInfoRequest
     * @param GetFileUploadInfoHeaders $headers          GetFileUploadInfoHeaders
     * @param RuntimeOptions           $runtime          runtime options for this request RuntimeOptions
     *
     * @return GetFileUploadInfoResponse GetFileUploadInfoResponse
     */
    public function getFileUploadInfoWithOptions($parentDentryUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->protocol)) {
            $body['protocol'] = $request->protocol;
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
            'action'      => 'GetFileUploadInfo',
            'version'     => 'storage_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/storage/spaces/files/' . $parentDentryUuid . '/uploadInfos/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFileUploadInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取文件上传信息
     *  *
     * @param string                   $parentDentryUuid
     * @param GetFileUploadInfoRequest $request          GetFileUploadInfoRequest
     *
     * @return GetFileUploadInfoResponse GetFileUploadInfoResponse
     */
    public function getFileUploadInfo($parentDentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFileUploadInfoHeaders([]);

        return $this->getFileUploadInfoWithOptions($parentDentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 获取权限继承模式
     *  *
     * @param string                          $dentryUuid
     * @param GetPermissionInheritanceRequest $request    GetPermissionInheritanceRequest
     * @param GetPermissionInheritanceHeaders $headers    GetPermissionInheritanceHeaders
     * @param RuntimeOptions                  $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetPermissionInheritanceResponse GetPermissionInheritanceResponse
     */
    public function getPermissionInheritanceWithOptions($dentryUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetPermissionInheritance',
            'version'     => 'storage_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/storage/spaces/dentries/' . $dentryUuid . '/permissions/inheritances',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetPermissionInheritanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取权限继承模式
     *  *
     * @param string                          $dentryUuid
     * @param GetPermissionInheritanceRequest $request    GetPermissionInheritanceRequest
     *
     * @return GetPermissionInheritanceResponse GetPermissionInheritanceResponse
     */
    public function getPermissionInheritance($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPermissionInheritanceHeaders([]);

        return $this->getPermissionInheritanceWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 获取分享范围
     *  *
     * @param string                         $dentryUuid
     * @param GetPermissionShareScopeRequest $request    GetPermissionShareScopeRequest
     * @param GetPermissionShareScopeHeaders $headers    GetPermissionShareScopeHeaders
     * @param RuntimeOptions                 $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetPermissionShareScopeResponse GetPermissionShareScopeResponse
     */
    public function getPermissionShareScopeWithOptions($dentryUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetPermissionShareScope',
            'version'     => 'storage_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/storage/spaces/dentries/' . $dentryUuid . '/permissions/scopes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetPermissionShareScopeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取分享范围
     *  *
     * @param string                         $dentryUuid
     * @param GetPermissionShareScopeRequest $request    GetPermissionShareScopeRequest
     *
     * @return GetPermissionShareScopeResponse GetPermissionShareScopeResponse
     */
    public function getPermissionShareScope($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPermissionShareScopeHeaders([]);

        return $this->getPermissionShareScopeWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 查询操作日志
     *  *
     * @param ListOperationLogsRequest $request ListOperationLogsRequest
     * @param ListOperationLogsHeaders $headers ListOperationLogsHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return ListOperationLogsResponse ListOperationLogsResponse
     */
    public function listOperationLogsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
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
            'action'      => 'ListOperationLogs',
            'version'     => 'storage_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/storage/managements/operationLogs/list',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListOperationLogsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询操作日志
     *  *
     * @param ListOperationLogsRequest $request ListOperationLogsRequest
     *
     * @return ListOperationLogsResponse ListOperationLogsResponse
     */
    public function listOperationLogs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListOperationLogsHeaders([]);

        return $this->listOperationLogsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取权限列表
     *  *
     * @param string                 $dentryUuid
     * @param ListPermissionsRequest $request    ListPermissionsRequest
     * @param ListPermissionsHeaders $headers    ListPermissionsHeaders
     * @param RuntimeOptions         $runtime    runtime options for this request RuntimeOptions
     *
     * @return ListPermissionsResponse ListPermissionsResponse
     */
    public function listPermissionsWithOptions($dentryUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
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
            'action'      => 'ListPermissions',
            'version'     => 'storage_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/storage/spaces/dentries/' . $dentryUuid . '/permissions/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListPermissionsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取权限列表
     *  *
     * @param string                 $dentryUuid
     * @param ListPermissionsRequest $request    ListPermissionsRequest
     *
     * @return ListPermissionsResponse ListPermissionsResponse
     */
    public function listPermissions($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListPermissionsHeaders([]);

        return $this->listPermissionsWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 查询员工离职时空间默认转交人(管理员)
     *  *
     * @param ManagerGetDefaultHandOverUserRequest $request ManagerGetDefaultHandOverUserRequest
     * @param ManagerGetDefaultHandOverUserHeaders $headers ManagerGetDefaultHandOverUserHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return ManagerGetDefaultHandOverUserResponse ManagerGetDefaultHandOverUserResponse
     */
    public function managerGetDefaultHandOverUserWithOptions($request, $headers, $runtime)
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
            'action'      => 'ManagerGetDefaultHandOverUser',
            'version'     => 'storage_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/storage/managementSettings/defaultHandOverUsers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ManagerGetDefaultHandOverUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询员工离职时空间默认转交人(管理员)
     *  *
     * @param ManagerGetDefaultHandOverUserRequest $request ManagerGetDefaultHandOverUserRequest
     *
     * @return ManagerGetDefaultHandOverUserResponse ManagerGetDefaultHandOverUserResponse
     */
    public function managerGetDefaultHandOverUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ManagerGetDefaultHandOverUserHeaders([]);

        return $this->managerGetDefaultHandOverUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设置员工离职时空间默认转交人(管理员)
     *  *
     * @param ManagerSetDefaultHandOverUserRequest $request ManagerSetDefaultHandOverUserRequest
     * @param ManagerSetDefaultHandOverUserHeaders $headers ManagerSetDefaultHandOverUserHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return ManagerSetDefaultHandOverUserResponse ManagerSetDefaultHandOverUserResponse
     */
    public function managerSetDefaultHandOverUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->defaultHandoverUserId)) {
            $body['defaultHandoverUserId'] = $request->defaultHandoverUserId;
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
            'action'      => 'ManagerSetDefaultHandOverUser',
            'version'     => 'storage_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/storage/managementSettings/defaultHandOverUsers/set',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ManagerSetDefaultHandOverUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置员工离职时空间默认转交人(管理员)
     *  *
     * @param ManagerSetDefaultHandOverUserRequest $request ManagerSetDefaultHandOverUserRequest
     *
     * @return ManagerSetDefaultHandOverUserResponse ManagerSetDefaultHandOverUserResponse
     */
    public function managerSetDefaultHandOverUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ManagerSetDefaultHandOverUserHeaders([]);

        return $this->managerSetDefaultHandOverUserWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 搜索文件
     *  *
     * @param SearchDentriesRequest $request SearchDentriesRequest
     * @param SearchDentriesHeaders $headers SearchDentriesHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchDentriesResponse SearchDentriesResponse
     */
    public function searchDentriesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->keyword)) {
            $body['keyword'] = $request->keyword;
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
            'action'      => 'SearchDentries',
            'version'     => 'storage_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/storage/dentries/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchDentriesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 搜索文件
     *  *
     * @param SearchDentriesRequest $request SearchDentriesRequest
     *
     * @return SearchDentriesResponse SearchDentriesResponse
     */
    public function searchDentries($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchDentriesHeaders([]);

        return $this->searchDentriesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 搜索公开发布文件
     *  *
     * @param SearchPublishDentriesRequest $request SearchPublishDentriesRequest
     * @param SearchPublishDentriesHeaders $headers SearchPublishDentriesHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchPublishDentriesResponse SearchPublishDentriesResponse
     */
    public function searchPublishDentriesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->keyword)) {
            $body['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->workspaceId)) {
            $body['workspaceId'] = $request->workspaceId;
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
            'action'      => 'SearchPublishDentries',
            'version'     => 'storage_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/storage/publishDentries/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchPublishDentriesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 搜索公开发布文件
     *  *
     * @param SearchPublishDentriesRequest $request SearchPublishDentriesRequest
     *
     * @return SearchPublishDentriesResponse SearchPublishDentriesResponse
     */
    public function searchPublishDentries($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchPublishDentriesHeaders([]);

        return $this->searchPublishDentriesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 搜索知识库
     *  *
     * @param SearchWorkspacesRequest $request SearchWorkspacesRequest
     * @param SearchWorkspacesHeaders $headers SearchWorkspacesHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchWorkspacesResponse SearchWorkspacesResponse
     */
    public function searchWorkspacesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->keyword)) {
            $body['keyword'] = $request->keyword;
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
            'action'      => 'SearchWorkspaces',
            'version'     => 'storage_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/storage/workspaces/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchWorkspacesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 搜索知识库
     *  *
     * @param SearchWorkspacesRequest $request SearchWorkspacesRequest
     *
     * @return SearchWorkspacesResponse SearchWorkspacesResponse
     */
    public function searchWorkspaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchWorkspacesHeaders([]);

        return $this->searchWorkspacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设置权限继承模式
     *  *
     * @param string                          $dentryUuid
     * @param SetPermissionInheritanceRequest $request    SetPermissionInheritanceRequest
     * @param SetPermissionInheritanceHeaders $headers    SetPermissionInheritanceHeaders
     * @param RuntimeOptions                  $runtime    runtime options for this request RuntimeOptions
     *
     * @return SetPermissionInheritanceResponse SetPermissionInheritanceResponse
     */
    public function setPermissionInheritanceWithOptions($dentryUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->inheritance)) {
            $body['inheritance'] = $request->inheritance;
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
            'action'      => 'SetPermissionInheritance',
            'version'     => 'storage_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/storage/spaces/dentries/' . $dentryUuid . '/permissions/inheritances',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SetPermissionInheritanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置权限继承模式
     *  *
     * @param string                          $dentryUuid
     * @param SetPermissionInheritanceRequest $request    SetPermissionInheritanceRequest
     *
     * @return SetPermissionInheritanceResponse SetPermissionInheritanceResponse
     */
    public function setPermissionInheritance($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetPermissionInheritanceHeaders([]);

        return $this->setPermissionInheritanceWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 设置分享范围
     *  *
     * @param string                         $dentryUuid
     * @param SetPermissionShareScopeRequest $request    SetPermissionShareScopeRequest
     * @param SetPermissionShareScopeHeaders $headers    SetPermissionShareScopeHeaders
     * @param RuntimeOptions                 $runtime    runtime options for this request RuntimeOptions
     *
     * @return SetPermissionShareScopeResponse SetPermissionShareScopeResponse
     */
    public function setPermissionShareScopeWithOptions($dentryUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->scope)) {
            $body['scope'] = $request->scope;
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
            'action'      => 'SetPermissionShareScope',
            'version'     => 'storage_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/storage/spaces/dentries/' . $dentryUuid . '/permissions/scopes',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SetPermissionShareScopeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置分享范围
     *  *
     * @param string                         $dentryUuid
     * @param SetPermissionShareScopeRequest $request    SetPermissionShareScopeRequest
     *
     * @return SetPermissionShareScopeResponse SetPermissionShareScopeResponse
     */
    public function setPermissionShareScope($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetPermissionShareScopeHeaders([]);

        return $this->setPermissionShareScopeWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 修改权限
     *  *
     * @param string                  $dentryUuid
     * @param UpdatePermissionRequest $request    UpdatePermissionRequest
     * @param UpdatePermissionHeaders $headers    UpdatePermissionHeaders
     * @param RuntimeOptions          $runtime    runtime options for this request RuntimeOptions
     *
     * @return UpdatePermissionResponse UpdatePermissionResponse
     */
    public function updatePermissionWithOptions($dentryUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
        }
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
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdatePermission',
            'version'     => 'storage_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/storage/spaces/dentries/' . $dentryUuid . '/permissions',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdatePermissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改权限
     *  *
     * @param string                  $dentryUuid
     * @param UpdatePermissionRequest $request    UpdatePermissionRequest
     *
     * @return UpdatePermissionResponse UpdatePermissionResponse
     */
    public function updatePermission($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdatePermissionHeaders([]);

        return $this->updatePermissionWithOptions($dentryUuid, $request, $headers, $runtime);
    }
}
