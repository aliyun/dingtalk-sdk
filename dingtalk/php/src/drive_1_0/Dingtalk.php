<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\AddCustomSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\AddCustomSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\AddCustomSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\AddFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\AddFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\AddFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\AddPermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\AddPermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\AddPermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\AddSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\AddSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\AddSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ClearRecycleFilesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ClearRecycleFilesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ClearRecycleFilesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\CopyFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\CopyFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\CopyFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteFilesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteFilesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteFilesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeletePermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeletePermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeletePermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteRecycleFilesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteRecycleFilesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteRecycleFilesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetAsyncTaskInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetAsyncTaskInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetAsyncTaskInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetDownloadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetDownloadInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetDownloadInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetFileInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetFileInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetFileInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetMySpaceInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetMySpaceInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetMySpaceInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetPreviewInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetPreviewInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetPreviewInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetPrivilegeInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetPrivilegeInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetPrivilegeInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetQuotaInfosHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetQuotaInfosRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetQuotaInfosResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GrantPrivilegeOfCustomSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GrantPrivilegeOfCustomSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GrantPrivilegeOfCustomSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\InfoSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\InfoSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\InfoSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListFilesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListFilesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListFilesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListPermissionsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListPermissionsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListPermissionsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListRecycleFilesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListRecycleFilesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListRecycleFilesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListSpacesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListSpacesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListSpacesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ManagementBuyQuotaHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ManagementBuyQuotaRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ManagementBuyQuotaResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ManagementListSpacesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ManagementListSpacesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ManagementListSpacesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ManagementModifySpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ManagementModifySpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ManagementModifySpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ModifyPermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ModifyPermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ModifyPermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\MoveFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\MoveFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\MoveFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\MoveFilesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\MoveFilesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\MoveFilesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\RecoverRecycleFilesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\RecoverRecycleFilesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\RecoverRecycleFilesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\RenameFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\RenameFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\RenameFileResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client as DarabonbaGatewayDingTalkClient;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    protected $_client;

    public function __construct($config)
    {
        parent::__construct($config);
        $this->_client       = new DarabonbaGatewayDingTalkClient();
        $this->_spi          = $this->_client;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param AddCustomSpaceRequest $request
     * @param AddCustomSpaceHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return AddCustomSpaceResponse
     */
    public function addCustomSpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->identifier)) {
            $body['identifier'] = $request->identifier;
        }
        if (!Utils::isUnset($request->permissionMode)) {
            $body['permissionMode'] = $request->permissionMode;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'AddCustomSpace',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/customSpaces',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddCustomSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddCustomSpaceRequest $request
     *
     * @return AddCustomSpaceResponse
     */
    public function addCustomSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddCustomSpaceHeaders([]);

        return $this->addCustomSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string         $spaceId
     * @param AddFileRequest $request
     * @param AddFileHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return AddFileResponse
     */
    public function addFileWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->addConflictPolicy)) {
            $body['addConflictPolicy'] = $request->addConflictPolicy;
        }
        if (!Utils::isUnset($request->fileName)) {
            $body['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->fileType)) {
            $body['fileType'] = $request->fileType;
        }
        if (!Utils::isUnset($request->mediaId)) {
            $body['mediaId'] = $request->mediaId;
        }
        if (!Utils::isUnset($request->parentId)) {
            $body['parentId'] = $request->parentId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'AddFile',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddFileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string         $spaceId
     * @param AddFileRequest $request
     *
     * @return AddFileResponse
     */
    public function addFile($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddFileHeaders([]);

        return $this->addFileWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string               $spaceId
     * @param string               $fileId
     * @param AddPermissionRequest $request
     * @param AddPermissionHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return AddPermissionResponse
     */
    public function addPermissionWithOptions($spaceId, $fileId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->role)) {
            $body['role'] = $request->role;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'AddPermission',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/permissions',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return AddPermissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string               $spaceId
     * @param string               $fileId
     * @param AddPermissionRequest $request
     *
     * @return AddPermissionResponse
     */
    public function addPermission($spaceId, $fileId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddPermissionHeaders([]);

        return $this->addPermissionWithOptions($spaceId, $fileId, $request, $headers, $runtime);
    }

    /**
     * @param AddSpaceRequest $request
     * @param AddSpaceHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return AddSpaceResponse
     */
    public function addSpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'AddSpace',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddSpaceRequest $request
     *
     * @return AddSpaceResponse
     */
    public function addSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddSpaceHeaders([]);

        return $this->addSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ClearRecycleFilesRequest $request
     * @param ClearRecycleFilesHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return ClearRecycleFilesResponse
     */
    public function clearRecycleFilesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->recycleType)) {
            $body['recycleType'] = $request->recycleType;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'ClearRecycleFiles',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/recycleItems/clear',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return ClearRecycleFilesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ClearRecycleFilesRequest $request
     *
     * @return ClearRecycleFilesResponse
     */
    public function clearRecycleFiles($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ClearRecycleFilesHeaders([]);

        return $this->clearRecycleFilesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string          $spaceId
     * @param string          $fileId
     * @param CopyFileRequest $request
     * @param CopyFileHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return CopyFileResponse
     */
    public function copyFileWithOptions($spaceId, $fileId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->addConflictPolicy)) {
            $body['addConflictPolicy'] = $request->addConflictPolicy;
        }
        if (!Utils::isUnset($request->targetParentId)) {
            $body['targetParentId'] = $request->targetParentId;
        }
        if (!Utils::isUnset($request->targetSpaceId)) {
            $body['targetSpaceId'] = $request->targetSpaceId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'CopyFile',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/copy',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CopyFileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string          $spaceId
     * @param string          $fileId
     * @param CopyFileRequest $request
     *
     * @return CopyFileResponse
     */
    public function copyFile($spaceId, $fileId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CopyFileHeaders([]);

        return $this->copyFileWithOptions($spaceId, $fileId, $request, $headers, $runtime);
    }

    /**
     * @param string            $spaceId
     * @param string            $fileId
     * @param DeleteFileRequest $request
     * @param DeleteFileHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return DeleteFileResponse
     */
    public function deleteFileWithOptions($spaceId, $fileId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deletePolicy)) {
            $query['deletePolicy'] = $request->deletePolicy;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeleteFile',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteFileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string            $spaceId
     * @param string            $fileId
     * @param DeleteFileRequest $request
     *
     * @return DeleteFileResponse
     */
    public function deleteFile($spaceId, $fileId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteFileHeaders([]);

        return $this->deleteFileWithOptions($spaceId, $fileId, $request, $headers, $runtime);
    }

    /**
     * @param string             $spaceId
     * @param DeleteFilesRequest $request
     * @param DeleteFilesHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return DeleteFilesResponse
     */
    public function deleteFilesWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deletePolicy)) {
            $body['deletePolicy'] = $request->deletePolicy;
        }
        if (!Utils::isUnset($request->fileIds)) {
            $body['fileIds'] = $request->fileIds;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'DeleteFiles',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files/batchDelete',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteFilesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string             $spaceId
     * @param DeleteFilesRequest $request
     *
     * @return DeleteFilesResponse
     */
    public function deleteFiles($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteFilesHeaders([]);

        return $this->deleteFilesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $spaceId
     * @param string                  $fileId
     * @param DeletePermissionRequest $request
     * @param DeletePermissionHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return DeletePermissionResponse
     */
    public function deletePermissionWithOptions($spaceId, $fileId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->role)) {
            $body['role'] = $request->role;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'DeletePermission',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/permissions/delete',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return DeletePermissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                  $spaceId
     * @param string                  $fileId
     * @param DeletePermissionRequest $request
     *
     * @return DeletePermissionResponse
     */
    public function deletePermission($spaceId, $fileId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeletePermissionHeaders([]);

        return $this->deletePermissionWithOptions($spaceId, $fileId, $request, $headers, $runtime);
    }

    /**
     * @param DeleteRecycleFilesRequest $request
     * @param DeleteRecycleFilesHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return DeleteRecycleFilesResponse
     */
    public function deleteRecycleFilesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->recycleItemIdList)) {
            $body['recycleItemIdList'] = $request->recycleItemIdList;
        }
        if (!Utils::isUnset($request->recycleType)) {
            $body['recycleType'] = $request->recycleType;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'DeleteRecycleFiles',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/recycleItems/delete',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return DeleteRecycleFilesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeleteRecycleFilesRequest $request
     *
     * @return DeleteRecycleFilesResponse
     */
    public function deleteRecycleFiles($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRecycleFilesHeaders([]);

        return $this->deleteRecycleFilesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string             $spaceId
     * @param DeleteSpaceRequest $request
     * @param DeleteSpaceHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return DeleteSpaceResponse
     */
    public function deleteSpaceWithOptions($spaceId, $request, $headers, $runtime)
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
            'action'      => 'DeleteSpace',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return DeleteSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string             $spaceId
     * @param DeleteSpaceRequest $request
     *
     * @return DeleteSpaceResponse
     */
    public function deleteSpace($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSpaceHeaders([]);

        return $this->deleteSpaceWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $taskId
     * @param GetAsyncTaskInfoRequest $request
     * @param GetAsyncTaskInfoHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetAsyncTaskInfoResponse
     */
    public function getAsyncTaskInfoWithOptions($taskId, $request, $headers, $runtime)
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
            'action'      => 'GetAsyncTaskInfo',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/tasks/' . $taskId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAsyncTaskInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                  $taskId
     * @param GetAsyncTaskInfoRequest $request
     *
     * @return GetAsyncTaskInfoResponse
     */
    public function getAsyncTaskInfo($taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAsyncTaskInfoHeaders([]);

        return $this->getAsyncTaskInfoWithOptions($taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $spaceId
     * @param string                 $fileId
     * @param GetDownloadInfoRequest $request
     * @param GetDownloadInfoHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetDownloadInfoResponse
     */
    public function getDownloadInfoWithOptions($spaceId, $fileId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        if (!Utils::isUnset($request->withInternalResourceUrl)) {
            $query['withInternalResourceUrl'] = $request->withInternalResourceUrl;
        }
        if (!Utils::isUnset($request->withRegion)) {
            $query['withRegion'] = $request->withRegion;
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
            'action'      => 'GetDownloadInfo',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/downloadInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDownloadInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                 $spaceId
     * @param string                 $fileId
     * @param GetDownloadInfoRequest $request
     *
     * @return GetDownloadInfoResponse
     */
    public function getDownloadInfo($spaceId, $fileId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDownloadInfoHeaders([]);

        return $this->getDownloadInfoWithOptions($spaceId, $fileId, $request, $headers, $runtime);
    }

    /**
     * @param string             $spaceId
     * @param string             $fileId
     * @param GetFileInfoRequest $request
     * @param GetFileInfoHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetFileInfoResponse
     */
    public function getFileInfoWithOptions($spaceId, $fileId, $request, $headers, $runtime)
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
            'action'      => 'GetFileInfo',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFileInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string             $spaceId
     * @param string             $fileId
     * @param GetFileInfoRequest $request
     *
     * @return GetFileInfoResponse
     */
    public function getFileInfo($spaceId, $fileId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFileInfoHeaders([]);

        return $this->getFileInfoWithOptions($spaceId, $fileId, $request, $headers, $runtime);
    }

    /**
     * @param GetMySpaceInfoRequest $request
     * @param GetMySpaceInfoHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetMySpaceInfoResponse
     */
    public function getMySpaceInfoWithOptions($request, $headers, $runtime)
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
            'action'      => 'GetMySpaceInfo',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/mySpaces',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetMySpaceInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetMySpaceInfoRequest $request
     *
     * @return GetMySpaceInfoResponse
     */
    public function getMySpaceInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMySpaceInfoHeaders([]);

        return $this->getMySpaceInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                $spaceId
     * @param string                $fileId
     * @param GetPreviewInfoRequest $request
     * @param GetPreviewInfoHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetPreviewInfoResponse
     */
    public function getPreviewInfoWithOptions($spaceId, $fileId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        if (!Utils::isUnset($request->version)) {
            $query['version'] = $request->version;
        }
        if (!Utils::isUnset($request->watermark)) {
            $query['watermark'] = $request->watermark;
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
            'action'      => 'GetPreviewInfo',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/previewInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetPreviewInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                $spaceId
     * @param string                $fileId
     * @param GetPreviewInfoRequest $request
     *
     * @return GetPreviewInfoResponse
     */
    public function getPreviewInfo($spaceId, $fileId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPreviewInfoHeaders([]);

        return $this->getPreviewInfoWithOptions($spaceId, $fileId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $spaceId
     * @param string                  $fileId
     * @param GetPrivilegeInfoRequest $request
     * @param GetPrivilegeInfoHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetPrivilegeInfoResponse
     */
    public function getPrivilegeInfoWithOptions($spaceId, $fileId, $request, $headers, $runtime)
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
            'action'      => 'GetPrivilegeInfo',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/privileges',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetPrivilegeInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                  $spaceId
     * @param string                  $fileId
     * @param GetPrivilegeInfoRequest $request
     *
     * @return GetPrivilegeInfoResponse
     */
    public function getPrivilegeInfo($spaceId, $fileId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPrivilegeInfoHeaders([]);

        return $this->getPrivilegeInfoWithOptions($spaceId, $fileId, $request, $headers, $runtime);
    }

    /**
     * @param GetQuotaInfosRequest $request
     * @param GetQuotaInfosHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetQuotaInfosResponse
     */
    public function getQuotaInfosWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->identifiers)) {
            $body['identifiers'] = $request->identifiers;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'GetQuotaInfos',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/quotaInfos/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetQuotaInfosResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetQuotaInfosRequest $request
     *
     * @return GetQuotaInfosResponse
     */
    public function getQuotaInfos($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetQuotaInfosHeaders([]);

        return $this->getQuotaInfosWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string               $spaceId
     * @param string               $parentId
     * @param GetUploadInfoRequest $request
     * @param GetUploadInfoHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetUploadInfoResponse
     */
    public function getUploadInfoWithOptions($spaceId, $parentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->addConflictPolicy)) {
            $query['addConflictPolicy'] = $request->addConflictPolicy;
        }
        if (!Utils::isUnset($request->callerRegion)) {
            $query['callerRegion'] = $request->callerRegion;
        }
        if (!Utils::isUnset($request->fileName)) {
            $query['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->fileSize)) {
            $query['fileSize'] = $request->fileSize;
        }
        if (!Utils::isUnset($request->md5)) {
            $query['md5'] = $request->md5;
        }
        if (!Utils::isUnset($request->mediaId)) {
            $query['mediaId'] = $request->mediaId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        if (!Utils::isUnset($request->withInternalEndPoint)) {
            $query['withInternalEndPoint'] = $request->withInternalEndPoint;
        }
        if (!Utils::isUnset($request->withRegion)) {
            $query['withRegion'] = $request->withRegion;
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
            'action'      => 'GetUploadInfo',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files/' . $parentId . '/uploadInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUploadInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string               $spaceId
     * @param string               $parentId
     * @param GetUploadInfoRequest $request
     *
     * @return GetUploadInfoResponse
     */
    public function getUploadInfo($spaceId, $parentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUploadInfoHeaders([]);

        return $this->getUploadInfoWithOptions($spaceId, $parentId, $request, $headers, $runtime);
    }

    /**
     * @param string                             $spaceId
     * @param GrantPrivilegeOfCustomSpaceRequest $request
     * @param GrantPrivilegeOfCustomSpaceHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return GrantPrivilegeOfCustomSpaceResponse
     */
    public function grantPrivilegeOfCustomSpaceWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->duration)) {
            $body['duration'] = $request->duration;
        }
        if (!Utils::isUnset($request->fileIds)) {
            $body['fileIds'] = $request->fileIds;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action'      => 'GrantPrivilegeOfCustomSpace',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files/customSpacePrivileges',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return GrantPrivilegeOfCustomSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                             $spaceId
     * @param GrantPrivilegeOfCustomSpaceRequest $request
     *
     * @return GrantPrivilegeOfCustomSpaceResponse
     */
    public function grantPrivilegeOfCustomSpace($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GrantPrivilegeOfCustomSpaceHeaders([]);

        return $this->grantPrivilegeOfCustomSpaceWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string           $spaceId
     * @param InfoSpaceRequest $request
     * @param InfoSpaceHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return InfoSpaceResponse
     */
    public function infoSpaceWithOptions($spaceId, $request, $headers, $runtime)
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
            'action'      => 'InfoSpace',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InfoSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string           $spaceId
     * @param InfoSpaceRequest $request
     *
     * @return InfoSpaceResponse
     */
    public function infoSpace($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InfoSpaceHeaders([]);

        return $this->infoSpaceWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string           $spaceId
     * @param ListFilesRequest $request
     * @param ListFilesHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return ListFilesResponse
     */
    public function listFilesWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->orderType)) {
            $query['orderType'] = $request->orderType;
        }
        if (!Utils::isUnset($request->parentId)) {
            $query['parentId'] = $request->parentId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        if (!Utils::isUnset($request->withIcon)) {
            $query['withIcon'] = $request->withIcon;
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
            'action'      => 'ListFiles',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListFilesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string           $spaceId
     * @param ListFilesRequest $request
     *
     * @return ListFilesResponse
     */
    public function listFiles($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListFilesHeaders([]);

        return $this->listFilesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $spaceId
     * @param string                 $fileId
     * @param ListPermissionsRequest $request
     * @param ListPermissionsHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ListPermissionsResponse
     */
    public function listPermissionsWithOptions($spaceId, $fileId, $request, $headers, $runtime)
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
            'action'      => 'ListPermissions',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/permissions',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListPermissionsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                 $spaceId
     * @param string                 $fileId
     * @param ListPermissionsRequest $request
     *
     * @return ListPermissionsResponse
     */
    public function listPermissions($spaceId, $fileId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListPermissionsHeaders([]);

        return $this->listPermissionsWithOptions($spaceId, $fileId, $request, $headers, $runtime);
    }

    /**
     * @param ListRecycleFilesRequest $request
     * @param ListRecycleFilesHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ListRecycleFilesResponse
     */
    public function listRecycleFilesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->orderType)) {
            $query['orderType'] = $request->orderType;
        }
        if (!Utils::isUnset($request->recycleType)) {
            $query['recycleType'] = $request->recycleType;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListRecycleFiles',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/recycleItems',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListRecycleFilesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListRecycleFilesRequest $request
     *
     * @return ListRecycleFilesResponse
     */
    public function listRecycleFiles($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListRecycleFilesHeaders([]);

        return $this->listRecycleFilesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListSpacesRequest $request
     * @param ListSpacesHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return ListSpacesResponse
     */
    public function listSpacesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->spaceType)) {
            $query['spaceType'] = $request->spaceType;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'ListSpaces',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListSpacesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListSpacesRequest $request
     *
     * @return ListSpacesResponse
     */
    public function listSpaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSpacesHeaders([]);

        return $this->listSpacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ManagementBuyQuotaRequest $request
     * @param ManagementBuyQuotaHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return ManagementBuyQuotaResponse
     */
    public function managementBuyQuotaWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->order)) {
            $body['order'] = $request->order;
        }
        if (!Utils::isUnset($request->token)) {
            $body['token'] = $request->token;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'ManagementBuyQuota',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/managements/quotas/buy',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return ManagementBuyQuotaResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ManagementBuyQuotaRequest $request
     *
     * @return ManagementBuyQuotaResponse
     */
    public function managementBuyQuota($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ManagementBuyQuotaHeaders([]);

        return $this->managementBuyQuotaWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ManagementListSpacesRequest $request
     * @param ManagementListSpacesHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return ManagementListSpacesResponse
     */
    public function managementListSpacesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->spaceIds)) {
            $body['spaceIds'] = $request->spaceIds;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'ManagementListSpaces',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/managements/spaces/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ManagementListSpacesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ManagementListSpacesRequest $request
     *
     * @return ManagementListSpacesResponse
     */
    public function managementListSpaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ManagementListSpacesHeaders([]);

        return $this->managementListSpacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ManagementModifySpaceRequest $request
     * @param ManagementModifySpaceHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return ManagementModifySpaceResponse
     */
    public function managementModifySpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->quota)) {
            $body['quota'] = $request->quota;
        }
        if (!Utils::isUnset($request->spaceIds)) {
            $body['spaceIds'] = $request->spaceIds;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'ManagementModifySpace',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/managements/spaces',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ManagementModifySpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ManagementModifySpaceRequest $request
     *
     * @return ManagementModifySpaceResponse
     */
    public function managementModifySpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ManagementModifySpaceHeaders([]);

        return $this->managementModifySpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                  $spaceId
     * @param string                  $fileId
     * @param ModifyPermissionRequest $request
     * @param ModifyPermissionHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ModifyPermissionResponse
     */
    public function modifyPermissionWithOptions($spaceId, $fileId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->role)) {
            $body['role'] = $request->role;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'ModifyPermission',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/permissions',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return ModifyPermissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                  $spaceId
     * @param string                  $fileId
     * @param ModifyPermissionRequest $request
     *
     * @return ModifyPermissionResponse
     */
    public function modifyPermission($spaceId, $fileId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ModifyPermissionHeaders([]);

        return $this->modifyPermissionWithOptions($spaceId, $fileId, $request, $headers, $runtime);
    }

    /**
     * @param string          $spaceId
     * @param string          $fileId
     * @param MoveFileRequest $request
     * @param MoveFileHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return MoveFileResponse
     */
    public function moveFileWithOptions($spaceId, $fileId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->addConflictPolicy)) {
            $body['addConflictPolicy'] = $request->addConflictPolicy;
        }
        if (!Utils::isUnset($request->targetParentId)) {
            $body['targetParentId'] = $request->targetParentId;
        }
        if (!Utils::isUnset($request->targetSpaceId)) {
            $body['targetSpaceId'] = $request->targetSpaceId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'MoveFile',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/move',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return MoveFileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string          $spaceId
     * @param string          $fileId
     * @param MoveFileRequest $request
     *
     * @return MoveFileResponse
     */
    public function moveFile($spaceId, $fileId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MoveFileHeaders([]);

        return $this->moveFileWithOptions($spaceId, $fileId, $request, $headers, $runtime);
    }

    /**
     * @param string           $spaceId
     * @param MoveFilesRequest $request
     * @param MoveFilesHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return MoveFilesResponse
     */
    public function moveFilesWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->addConflictPolicy)) {
            $body['addConflictPolicy'] = $request->addConflictPolicy;
        }
        if (!Utils::isUnset($request->fileIds)) {
            $body['fileIds'] = $request->fileIds;
        }
        if (!Utils::isUnset($request->targetParentId)) {
            $body['targetParentId'] = $request->targetParentId;
        }
        if (!Utils::isUnset($request->targetSpaceId)) {
            $body['targetSpaceId'] = $request->targetSpaceId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'MoveFiles',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files/batchMove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return MoveFilesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string           $spaceId
     * @param MoveFilesRequest $request
     *
     * @return MoveFilesResponse
     */
    public function moveFiles($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MoveFilesHeaders([]);

        return $this->moveFilesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param RecoverRecycleFilesRequest $request
     * @param RecoverRecycleFilesHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return RecoverRecycleFilesResponse
     */
    public function recoverRecycleFilesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->recycleItemIdList)) {
            $body['recycleItemIdList'] = $request->recycleItemIdList;
        }
        if (!Utils::isUnset($request->recycleType)) {
            $body['recycleType'] = $request->recycleType;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'RecoverRecycleFiles',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/recycleItems/recover',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return RecoverRecycleFilesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RecoverRecycleFilesRequest $request
     *
     * @return RecoverRecycleFilesResponse
     */
    public function recoverRecycleFiles($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RecoverRecycleFilesHeaders([]);

        return $this->recoverRecycleFilesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string            $spaceId
     * @param string            $fileId
     * @param RenameFileRequest $request
     * @param RenameFileHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return RenameFileResponse
     */
    public function renameFileWithOptions($spaceId, $fileId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->newFileName)) {
            $body['newFileName'] = $request->newFileName;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action'      => 'RenameFile',
            'version'     => 'drive_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/rename',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RenameFileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string            $spaceId
     * @param string            $fileId
     * @param RenameFileRequest $request
     *
     * @return RenameFileResponse
     */
    public function renameFile($spaceId, $fileId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RenameFileHeaders([]);

        return $this->renameFileWithOptions($spaceId, $fileId, $request, $headers, $runtime);
    }
}
