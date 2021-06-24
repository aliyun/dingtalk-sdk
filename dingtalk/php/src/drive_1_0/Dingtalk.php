<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
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
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeletePermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeletePermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeletePermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteRecycleFilesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteRecycleFilesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteRecycleFilesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetDownloadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetDownloadInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetDownloadInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetFileInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetFileInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetFileInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ModifyPermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ModifyPermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ModifyPermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\MoveFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\MoveFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\MoveFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\RecoverRecycleFilesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\RecoverRecycleFilesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\RecoverRecycleFilesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\RenameFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\RenameFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\RenameFileResponse;
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
        if (!Utils::isUnset($request->parentId)) {
            @$body['parentId'] = $request->parentId;
        }
        if (!Utils::isUnset($request->fileType)) {
            @$body['fileType'] = $request->fileType;
        }
        if (!Utils::isUnset($request->fileName)) {
            @$body['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->mediaId)) {
            @$body['mediaId'] = $request->mediaId;
        }
        if (!Utils::isUnset($request->addConflictPolicy)) {
            @$body['addConflictPolicy'] = $request->addConflictPolicy;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return AddFileResponse::fromMap($this->doROARequest('AddFile', 'drive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/drive/spaces/' . $spaceId . '/files', 'json', $req, $runtime));
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
            @$body['recycleItemIdList'] = $request->recycleItemIdList;
        }
        if (!Utils::isUnset($request->recycleType)) {
            @$body['recycleType'] = $request->recycleType;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return RecoverRecycleFilesResponse::fromMap($this->doROARequest('RecoverRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/drive/recycleItems/recover', 'none', $req, $runtime));
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
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return AddSpaceResponse::fromMap($this->doROARequest('AddSpace', 'drive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/drive/spaces', 'json', $req, $runtime));
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
            @$body['recycleItemIdList'] = $request->recycleItemIdList;
        }
        if (!Utils::isUnset($request->recycleType)) {
            @$body['recycleType'] = $request->recycleType;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return DeleteRecycleFilesResponse::fromMap($this->doROARequest('DeleteRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/drive/recycleItems/delete', 'none', $req, $runtime));
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
        if (!Utils::isUnset($request->role)) {
            @$body['role'] = $request->role;
        }
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return AddPermissionResponse::fromMap($this->doROARequest('AddPermission', 'drive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/permissions', 'none', $req, $runtime));
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
            @$query['unionId'] = $request->unionId;
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

        return GetFileInfoResponse::fromMap($this->doROARequest('GetFileInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        if (!Utils::isUnset($request->recycleType)) {
            @$query['recycleType'] = $request->recycleType;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->orderType)) {
            @$query['orderType'] = $request->orderType;
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

        return ListRecycleFilesResponse::fromMap($this->doROARequest('ListRecycleFiles', 'drive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/drive/recycleItems', 'json', $req, $runtime));
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
            @$body['newFileName'] = $request->newFileName;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return RenameFileResponse::fromMap($this->doROARequest('RenameFile', 'drive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/rename', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        if (!Utils::isUnset($request->parentId)) {
            @$query['parentId'] = $request->parentId;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
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

        return ListFilesResponse::fromMap($this->doROARequest('ListFiles', 'drive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/drive/spaces/' . $spaceId . '/files', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->role)) {
            @$body['role'] = $request->role;
        }
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return ModifyPermissionResponse::fromMap($this->doROARequest('ModifyPermission', 'drive_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/permissions', 'none', $req, $runtime));
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
            @$query['unionId'] = $request->unionId;
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

        return ListPermissionsResponse::fromMap($this->doROARequest('ListPermissions', 'drive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/permissions', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->targetSpaceId)) {
            @$body['targetSpaceId'] = $request->targetSpaceId;
        }
        if (!Utils::isUnset($request->targetParentId)) {
            @$body['targetParentId'] = $request->targetParentId;
        }
        if (!Utils::isUnset($request->addConflictPolicy)) {
            @$body['addConflictPolicy'] = $request->addConflictPolicy;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return MoveFileResponse::fromMap($this->doROARequest('MoveFile', 'drive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/move', 'json', $req, $runtime));
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
            @$query['unionId'] = $request->unionId;
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

        return GetDownloadInfoResponse::fromMap($this->doROARequest('GetDownloadInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/downloadInfos', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        if (!Utils::isUnset($request->fileName)) {
            @$query['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->fileSize)) {
            @$query['fileSize'] = $request->fileSize;
        }
        if (!Utils::isUnset($request->md5)) {
            @$query['md5'] = $request->md5;
        }
        if (!Utils::isUnset($request->addConflictPolicy)) {
            @$query['addConflictPolicy'] = $request->addConflictPolicy;
        }
        if (!Utils::isUnset($request->mediaId)) {
            @$query['mediaId'] = $request->mediaId;
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

        return GetUploadInfoResponse::fromMap($this->doROARequest('GetUploadInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/drive/spaces/' . $spaceId . '/files/' . $parentId . '/uploadInfos', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        if (!Utils::isUnset($request->spaceType)) {
            @$query['spaceType'] = $request->spaceType;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
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

        return ListSpacesResponse::fromMap($this->doROARequest('ListSpaces', 'drive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/drive/spaces', 'json', $req, $runtime));
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
        if (!Utils::isUnset($request->role)) {
            @$body['role'] = $request->role;
        }
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return DeletePermissionResponse::fromMap($this->doROARequest('DeletePermission', 'drive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '/permissions/delete', 'none', $req, $runtime));
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
            @$query['unionId'] = $request->unionId;
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

        return DeleteSpaceResponse::fromMap($this->doROARequest('DeleteSpace', 'drive_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/drive/spaces/' . $spaceId . '', 'none', $req, $runtime));
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
            @$body['recycleType'] = $request->recycleType;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$body['unionId'] = $request->unionId;
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

        return ClearRecycleFilesResponse::fromMap($this->doROARequest('ClearRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/drive/recycleItems/clear', 'none', $req, $runtime));
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
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        if (!Utils::isUnset($request->deletePolicy)) {
            @$query['deletePolicy'] = $request->deletePolicy;
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

        return DeleteFileResponse::fromMap($this->doROARequest('DeleteFile', 'drive_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/drive/spaces/' . $spaceId . '/files/' . $fileId . '', 'json', $req, $runtime));
    }
}
