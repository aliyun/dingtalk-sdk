<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\AddFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\AddFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\AddFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ClearRecycleFilesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ClearRecycleFilesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ClearRecycleFilesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteRecycleFilesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteRecycleFilesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\DeleteRecycleFilesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetDownloadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetDownloadInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetFileInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetFileInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListFilesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListFilesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListFilesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListRecycleFilesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListRecycleFilesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListRecycleFilesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListSpacesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListSpacesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListSpacesResponse;
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
     * @param string         $unionId
     * @param string         $spaceId
     * @param AddFileRequest $request
     *
     * @return AddFileResponse
     */
    public function addFile($unionId, $spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddFileHeaders([]);

        return $this->addFileWithOptions($unionId, $spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string         $unionId
     * @param string         $spaceId
     * @param AddFileRequest $request
     * @param AddFileHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return AddFileResponse
     */
    public function addFileWithOptions($unionId, $spaceId, $request, $headers, $runtime)
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

        return AddFileResponse::fromMap($this->doROARequest('AddFile', 'drive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/drive/users/' . $unionId . '/spaces/' . $spaceId . '/files', 'json', $req, $runtime));
    }

    /**
     * @param string                     $unionId
     * @param RecoverRecycleFilesRequest $request
     *
     * @return RecoverRecycleFilesResponse
     */
    public function recoverRecycleFiles($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RecoverRecycleFilesHeaders([]);

        return $this->recoverRecycleFilesWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $unionId
     * @param RecoverRecycleFilesRequest $request
     * @param RecoverRecycleFilesHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return RecoverRecycleFilesResponse
     */
    public function recoverRecycleFilesWithOptions($unionId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->recycleItemIdList)) {
            @$body['recycleItemIdList'] = $request->recycleItemIdList;
        }
        if (!Utils::isUnset($request->recycleType)) {
            @$body['recycleType'] = $request->recycleType;
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

        return RecoverRecycleFilesResponse::fromMap($this->doROARequest('RecoverRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/drive/users/' . $unionId . '/recycleItems/recover', 'none', $req, $runtime));
    }

    /**
     * @param string                    $unionId
     * @param DeleteRecycleFilesRequest $request
     *
     * @return DeleteRecycleFilesResponse
     */
    public function deleteRecycleFiles($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRecycleFilesHeaders([]);

        return $this->deleteRecycleFilesWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @param string                    $unionId
     * @param DeleteRecycleFilesRequest $request
     * @param DeleteRecycleFilesHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return DeleteRecycleFilesResponse
     */
    public function deleteRecycleFilesWithOptions($unionId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->recycleItemIdList)) {
            @$body['recycleItemIdList'] = $request->recycleItemIdList;
        }
        if (!Utils::isUnset($request->recycleType)) {
            @$body['recycleType'] = $request->recycleType;
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

        return DeleteRecycleFilesResponse::fromMap($this->doROARequest('DeleteRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/drive/users/' . $unionId . '/recycleItems/delete', 'none', $req, $runtime));
    }

    /**
     * @param string $unionId
     * @param string $spaceId
     * @param string $fileId
     *
     * @return GetFileInfoResponse
     */
    public function getFileInfo($unionId, $spaceId, $fileId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFileInfoHeaders([]);

        return $this->getFileInfoWithOptions($unionId, $spaceId, $fileId, $headers, $runtime);
    }

    /**
     * @param string             $unionId
     * @param string             $spaceId
     * @param string             $fileId
     * @param GetFileInfoHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetFileInfoResponse
     */
    public function getFileInfoWithOptions($unionId, $spaceId, $fileId, $headers, $runtime)
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

        return GetFileInfoResponse::fromMap($this->doROARequest('GetFileInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/drive/users/' . $unionId . '/spaces/' . $spaceId . '/files/' . $fileId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                  $unionId
     * @param ListRecycleFilesRequest $request
     *
     * @return ListRecycleFilesResponse
     */
    public function listRecycleFiles($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListRecycleFilesHeaders([]);

        return $this->listRecycleFilesWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $unionId
     * @param ListRecycleFilesRequest $request
     * @param ListRecycleFilesHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ListRecycleFilesResponse
     */
    public function listRecycleFilesWithOptions($unionId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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

        return ListRecycleFilesResponse::fromMap($this->doROARequest('ListRecycleFiles', 'drive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/drive/users/' . $unionId . '/recycleItems', 'json', $req, $runtime));
    }

    /**
     * @param string            $unionId
     * @param string            $spaceId
     * @param string            $fileId
     * @param RenameFileRequest $request
     *
     * @return RenameFileResponse
     */
    public function renameFile($unionId, $spaceId, $fileId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RenameFileHeaders([]);

        return $this->renameFileWithOptions($unionId, $spaceId, $fileId, $request, $headers, $runtime);
    }

    /**
     * @param string            $unionId
     * @param string            $spaceId
     * @param string            $fileId
     * @param RenameFileRequest $request
     * @param RenameFileHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return RenameFileResponse
     */
    public function renameFileWithOptions($unionId, $spaceId, $fileId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->newFileName)) {
            @$body['newFileName'] = $request->newFileName;
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

        return RenameFileResponse::fromMap($this->doROARequest('RenameFile', 'drive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/drive/users/' . $unionId . '/spaces/' . $spaceId . '/files/' . $fileId . '/rename', 'json', $req, $runtime));
    }

    /**
     * @param string           $unionId
     * @param string           $spaceId
     * @param ListFilesRequest $request
     *
     * @return ListFilesResponse
     */
    public function listFiles($unionId, $spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListFilesHeaders([]);

        return $this->listFilesWithOptions($unionId, $spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string           $unionId
     * @param string           $spaceId
     * @param ListFilesRequest $request
     * @param ListFilesHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return ListFilesResponse
     */
    public function listFilesWithOptions($unionId, $spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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

        return ListFilesResponse::fromMap($this->doROARequest('ListFiles', 'drive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/drive/users/' . $unionId . '/spaces/' . $spaceId . '/files', 'json', $req, $runtime));
    }

    /**
     * @param string          $unionId
     * @param string          $spaceId
     * @param string          $fileId
     * @param MoveFileRequest $request
     *
     * @return MoveFileResponse
     */
    public function moveFile($unionId, $spaceId, $fileId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MoveFileHeaders([]);

        return $this->moveFileWithOptions($unionId, $spaceId, $fileId, $request, $headers, $runtime);
    }

    /**
     * @param string          $unionId
     * @param string          $spaceId
     * @param string          $fileId
     * @param MoveFileRequest $request
     * @param MoveFileHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return MoveFileResponse
     */
    public function moveFileWithOptions($unionId, $spaceId, $fileId, $request, $headers, $runtime)
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

        return MoveFileResponse::fromMap($this->doROARequest('MoveFile', 'drive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/drive/users/' . $unionId . '/spaces/' . $spaceId . '/files/' . $fileId . '/move', 'json', $req, $runtime));
    }

    /**
     * @param string $unionId
     * @param string $spaceId
     * @param string $fileId
     *
     * @return GetDownloadInfoResponse
     */
    public function getDownloadInfo($unionId, $spaceId, $fileId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDownloadInfoHeaders([]);

        return $this->getDownloadInfoWithOptions($unionId, $spaceId, $fileId, $headers, $runtime);
    }

    /**
     * @param string                 $unionId
     * @param string                 $spaceId
     * @param string                 $fileId
     * @param GetDownloadInfoHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetDownloadInfoResponse
     */
    public function getDownloadInfoWithOptions($unionId, $spaceId, $fileId, $headers, $runtime)
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

        return GetDownloadInfoResponse::fromMap($this->doROARequest('GetDownloadInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/drive/users/' . $unionId . '/spaces/' . $spaceId . '/files/' . $fileId . '/downloadInfos', 'json', $req, $runtime));
    }

    /**
     * @param string               $unionId
     * @param string               $spaceId
     * @param string               $parentId
     * @param GetUploadInfoRequest $request
     *
     * @return GetUploadInfoResponse
     */
    public function getUploadInfo($unionId, $spaceId, $parentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUploadInfoHeaders([]);

        return $this->getUploadInfoWithOptions($unionId, $spaceId, $parentId, $request, $headers, $runtime);
    }

    /**
     * @param string               $unionId
     * @param string               $spaceId
     * @param string               $parentId
     * @param GetUploadInfoRequest $request
     * @param GetUploadInfoHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetUploadInfoResponse
     */
    public function getUploadInfoWithOptions($unionId, $spaceId, $parentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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

        return GetUploadInfoResponse::fromMap($this->doROARequest('GetUploadInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/drive/users/' . $unionId . '/spaces/' . $spaceId . '/files/' . $parentId . '/uploadInfos', 'json', $req, $runtime));
    }

    /**
     * @param string            $unionId
     * @param ListSpacesRequest $request
     *
     * @return ListSpacesResponse
     */
    public function listSpaces($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSpacesHeaders([]);

        return $this->listSpacesWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @param string            $unionId
     * @param ListSpacesRequest $request
     * @param ListSpacesHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return ListSpacesResponse
     */
    public function listSpacesWithOptions($unionId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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

        return ListSpacesResponse::fromMap($this->doROARequest('ListSpaces', 'drive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/drive/users/' . $unionId . '/spaces', 'json', $req, $runtime));
    }

    /**
     * @param string                   $unionId
     * @param ClearRecycleFilesRequest $request
     *
     * @return ClearRecycleFilesResponse
     */
    public function clearRecycleFiles($unionId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ClearRecycleFilesHeaders([]);

        return $this->clearRecycleFilesWithOptions($unionId, $request, $headers, $runtime);
    }

    /**
     * @param string                   $unionId
     * @param ClearRecycleFilesRequest $request
     * @param ClearRecycleFilesHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return ClearRecycleFilesResponse
     */
    public function clearRecycleFilesWithOptions($unionId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->recycleType)) {
            @$body['recycleType'] = $request->recycleType;
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

        return ClearRecycleFilesResponse::fromMap($this->doROARequest('ClearRecycleFiles', 'drive_1.0', 'HTTP', 'POST', 'AK', '/v1.0/drive/users/' . $unionId . '/recycleItems/clear', 'none', $req, $runtime));
    }

    /**
     * @param string            $unionId
     * @param string            $spaceId
     * @param string            $fileId
     * @param DeleteFileRequest $request
     *
     * @return DeleteFileResponse
     */
    public function deleteFile($unionId, $spaceId, $fileId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteFileHeaders([]);

        return $this->deleteFileWithOptions($unionId, $spaceId, $fileId, $request, $headers, $runtime);
    }

    /**
     * @param string            $unionId
     * @param string            $spaceId
     * @param string            $fileId
     * @param DeleteFileRequest $request
     * @param DeleteFileHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return DeleteFileResponse
     */
    public function deleteFileWithOptions($unionId, $spaceId, $fileId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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

        return DeleteFileResponse::fromMap($this->doROARequest('DeleteFile', 'drive_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/drive/users/' . $unionId . '/spaces/' . $spaceId . '/files/' . $fileId . '', 'json', $req, $runtime));
    }
}
