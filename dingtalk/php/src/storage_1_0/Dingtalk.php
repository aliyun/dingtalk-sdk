<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddFolderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddFolderRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddFolderResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddPermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddPermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddPermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ClearRecycleBinHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ClearRecycleBinRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ClearRecycleBinResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CommitFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CommitFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CommitFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CopyDentriesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CopyDentriesRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CopyDentriesResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CopyDentryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CopyDentryRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CopyDentryResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeleteDentriesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeleteDentriesRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeleteDentriesResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeleteDentryAppPropertiesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeleteDentryAppPropertiesRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeleteDentryAppPropertiesResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeleteDentryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeleteDentryRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeleteDentryResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeletePermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeletePermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeletePermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeleteRecycleItemHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeleteRecycleItemRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeleteRecycleItemResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeleteRecycleItemsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeleteRecycleItemsRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DeleteRecycleItemsResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetCurrentAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetCurrentAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetCurrentAppResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetDentriesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetDentriesRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetDentriesResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetDentryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetDentryOpenInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetDentryOpenInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetDentryOpenInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetDentryRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetDentryResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetDentryThumbnailsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetDentryThumbnailsRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetDentryThumbnailsResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetFileDownloadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetFileDownloadInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetFileDownloadInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetFileUploadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetFileUploadInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetFileUploadInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetMultipartFileUploadInfosHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetMultipartFileUploadInfosRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetMultipartFileUploadInfosResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetOrgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetOrgRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetOrgResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetRecycleBinHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetRecycleBinRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetRecycleBinResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetRecycleItemHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetRecycleItemRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetRecycleItemResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\InitMultipartFileUploadHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\InitMultipartFileUploadRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\InitMultipartFileUploadResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListAllDentriesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListAllDentriesRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListAllDentriesResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListDentriesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListDentriesRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListDentriesResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListDentryVersionsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListDentryVersionsRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListDentryVersionsResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListPermissionsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListPermissionsRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListPermissionsResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListRecycleItemsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListRecycleItemsRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListRecycleItemsResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\MoveDentriesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\MoveDentriesRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\MoveDentriesResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\MoveDentryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\MoveDentryRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\MoveDentryResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RegisterOpenInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RegisterOpenInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RegisterOpenInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RenameDentryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RenameDentryRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RenameDentryResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RestoreRecycleItemHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RestoreRecycleItemRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RestoreRecycleItemResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RestoreRecycleItemsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RestoreRecycleItemsRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RestoreRecycleItemsResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RevertDentryVersionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RevertDentryVersionRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RevertDentryVersionResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\SubscribeEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\SubscribeEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\SubscribeEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\UnsubscribeEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\UnsubscribeEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\UnsubscribeEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\UpdateDentryAppPropertiesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\UpdateDentryAppPropertiesRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\UpdateDentryAppPropertiesResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\UpdatePermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\UpdatePermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\UpdatePermissionResponse;
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
     * @param string           $spaceId
     * @param string           $parentId
     * @param AddFolderRequest $request
     *
     * @return AddFolderResponse
     */
    public function addFolder($spaceId, $parentId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddFolderHeaders([]);

        return $this->addFolderWithOptions($spaceId, $parentId, $request, $headers, $runtime);
    }

    /**
     * @param string           $spaceId
     * @param string           $parentId
     * @param AddFolderRequest $request
     * @param AddFolderHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return AddFolderResponse
     */
    public function addFolderWithOptions($spaceId, $parentId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $parentId = OpenApiUtilClient::getEncodeParam($parentId);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
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

        return AddFolderResponse::fromMap($this->doROARequest('AddFolder', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $parentId . '/folders', 'json', $req, $runtime));
    }

    /**
     * @param string               $spaceId
     * @param string               $dentryId
     * @param AddPermissionRequest $request
     *
     * @return AddPermissionResponse
     */
    public function addPermission($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddPermissionHeaders([]);

        return $this->addPermissionWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string               $spaceId
     * @param string               $dentryId
     * @param AddPermissionRequest $request
     * @param AddPermissionHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return AddPermissionResponse
     */
    public function addPermissionWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->roleId)) {
            @$body['roleId'] = $request->roleId;
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

        return AddPermissionResponse::fromMap($this->doROARequest('AddPermission', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/permissions', 'json', $req, $runtime));
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
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
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

        return AddSpaceResponse::fromMap($this->doROARequest('AddSpace', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces', 'json', $req, $runtime));
    }

    /**
     * @param string                 $recycleBinId
     * @param ClearRecycleBinRequest $request
     *
     * @return ClearRecycleBinResponse
     */
    public function clearRecycleBin($recycleBinId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ClearRecycleBinHeaders([]);

        return $this->clearRecycleBinWithOptions($recycleBinId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $recycleBinId
     * @param ClearRecycleBinRequest $request
     * @param ClearRecycleBinHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ClearRecycleBinResponse
     */
    public function clearRecycleBinWithOptions($recycleBinId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $recycleBinId = OpenApiUtilClient::getEncodeParam($recycleBinId);
        $query        = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return ClearRecycleBinResponse::fromMap($this->doROARequest('ClearRecycleBin', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/recycleBins/' . $recycleBinId . '/clear', 'json', $req, $runtime));
    }

    /**
     * @param string            $spaceId
     * @param CommitFileRequest $request
     *
     * @return CommitFileResponse
     */
    public function commitFile($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CommitFileHeaders([]);

        return $this->commitFileWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string            $spaceId
     * @param CommitFileRequest $request
     * @param CommitFileHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return CommitFileResponse
     */
    public function commitFileWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->parentId)) {
            @$body['parentId'] = $request->parentId;
        }
        if (!Utils::isUnset($request->uploadKey)) {
            @$body['uploadKey'] = $request->uploadKey;
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

        return CommitFileResponse::fromMap($this->doROARequest('CommitFile', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/files/commit', 'json', $req, $runtime));
    }

    /**
     * @param string              $spaceId
     * @param CopyDentriesRequest $request
     *
     * @return CopyDentriesResponse
     */
    public function copyDentries($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CopyDentriesHeaders([]);

        return $this->copyDentriesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string              $spaceId
     * @param CopyDentriesRequest $request
     * @param CopyDentriesHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return CopyDentriesResponse
     */
    public function copyDentriesWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->dentryIds)) {
            @$body['dentryIds'] = $request->dentryIds;
        }
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->targetFolderId)) {
            @$body['targetFolderId'] = $request->targetFolderId;
        }
        if (!Utils::isUnset($request->targetSpaceId)) {
            @$body['targetSpaceId'] = $request->targetSpaceId;
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

        return CopyDentriesResponse::fromMap($this->doROARequest('CopyDentries', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/batchCopy', 'json', $req, $runtime));
    }

    /**
     * @param string            $spaceId
     * @param string            $dentryId
     * @param CopyDentryRequest $request
     *
     * @return CopyDentryResponse
     */
    public function copyDentry($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CopyDentryHeaders([]);

        return $this->copyDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string            $spaceId
     * @param string            $dentryId
     * @param CopyDentryRequest $request
     * @param CopyDentryHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return CopyDentryResponse
     */
    public function copyDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->targetFolderId)) {
            @$body['targetFolderId'] = $request->targetFolderId;
        }
        if (!Utils::isUnset($request->targetSpaceId)) {
            @$body['targetSpaceId'] = $request->targetSpaceId;
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

        return CopyDentryResponse::fromMap($this->doROARequest('CopyDentry', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/copy', 'json', $req, $runtime));
    }

    /**
     * @param string                $spaceId
     * @param DeleteDentriesRequest $request
     *
     * @return DeleteDentriesResponse
     */
    public function deleteDentries($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDentriesHeaders([]);

        return $this->deleteDentriesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string                $spaceId
     * @param DeleteDentriesRequest $request
     * @param DeleteDentriesHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return DeleteDentriesResponse
     */
    public function deleteDentriesWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->dentryIds)) {
            @$body['dentryIds'] = $request->dentryIds;
        }
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
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

        return DeleteDentriesResponse::fromMap($this->doROARequest('DeleteDentries', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/batchRemove', 'json', $req, $runtime));
    }

    /**
     * @param string              $spaceId
     * @param string              $dentryId
     * @param DeleteDentryRequest $request
     *
     * @return DeleteDentryResponse
     */
    public function deleteDentry($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDentryHeaders([]);

        return $this->deleteDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string              $spaceId
     * @param string              $dentryId
     * @param DeleteDentryRequest $request
     * @param DeleteDentryHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return DeleteDentryResponse
     */
    public function deleteDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->toRecycleBin)) {
            @$query['toRecycleBin'] = $request->toRecycleBin;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return DeleteDentryResponse::fromMap($this->doROARequest('DeleteDentry', 'storage_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $dentryId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                           $spaceId
     * @param string                           $dentryId
     * @param DeleteDentryAppPropertiesRequest $request
     *
     * @return DeleteDentryAppPropertiesResponse
     */
    public function deleteDentryAppProperties($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDentryAppPropertiesHeaders([]);

        return $this->deleteDentryAppPropertiesWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string                           $spaceId
     * @param string                           $dentryId
     * @param DeleteDentryAppPropertiesRequest $request
     * @param DeleteDentryAppPropertiesHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return DeleteDentryAppPropertiesResponse
     */
    public function deleteDentryAppPropertiesWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->propertyNames)) {
            @$body['propertyNames'] = $request->propertyNames;
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

        return DeleteDentryAppPropertiesResponse::fromMap($this->doROARequest('DeleteDentryAppProperties', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/appProperties/remove', 'json', $req, $runtime));
    }

    /**
     * @param string                  $spaceId
     * @param string                  $dentryId
     * @param DeletePermissionRequest $request
     *
     * @return DeletePermissionResponse
     */
    public function deletePermission($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeletePermissionHeaders([]);

        return $this->deletePermissionWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $spaceId
     * @param string                  $dentryId
     * @param DeletePermissionRequest $request
     * @param DeletePermissionHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return DeletePermissionResponse
     */
    public function deletePermissionWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->roleId)) {
            @$body['roleId'] = $request->roleId;
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

        return DeletePermissionResponse::fromMap($this->doROARequest('DeletePermission', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/permissions/remove', 'json', $req, $runtime));
    }

    /**
     * @param string                   $recycleBinId
     * @param string                   $recycleItemId
     * @param DeleteRecycleItemRequest $request
     *
     * @return DeleteRecycleItemResponse
     */
    public function deleteRecycleItem($recycleBinId, $recycleItemId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRecycleItemHeaders([]);

        return $this->deleteRecycleItemWithOptions($recycleBinId, $recycleItemId, $request, $headers, $runtime);
    }

    /**
     * @param string                   $recycleBinId
     * @param string                   $recycleItemId
     * @param DeleteRecycleItemRequest $request
     * @param DeleteRecycleItemHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return DeleteRecycleItemResponse
     */
    public function deleteRecycleItemWithOptions($recycleBinId, $recycleItemId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $recycleBinId  = OpenApiUtilClient::getEncodeParam($recycleBinId);
        $recycleItemId = OpenApiUtilClient::getEncodeParam($recycleItemId);
        $query         = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return DeleteRecycleItemResponse::fromMap($this->doROARequest('DeleteRecycleItem', 'storage_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/storage/recycleBins/' . $recycleBinId . '/recycleItems/' . $recycleItemId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                    $recycleBinId
     * @param DeleteRecycleItemsRequest $request
     *
     * @return DeleteRecycleItemsResponse
     */
    public function deleteRecycleItems($recycleBinId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRecycleItemsHeaders([]);

        return $this->deleteRecycleItemsWithOptions($recycleBinId, $request, $headers, $runtime);
    }

    /**
     * @param string                    $recycleBinId
     * @param DeleteRecycleItemsRequest $request
     * @param DeleteRecycleItemsHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return DeleteRecycleItemsResponse
     */
    public function deleteRecycleItemsWithOptions($recycleBinId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $recycleBinId = OpenApiUtilClient::getEncodeParam($recycleBinId);
        $query        = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->recycleItemIds)) {
            @$body['recycleItemIds'] = $request->recycleItemIds;
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

        return DeleteRecycleItemsResponse::fromMap($this->doROARequest('DeleteRecycleItems', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/recycleBins/' . $recycleBinId . '/recycleItems/batchRemove', 'json', $req, $runtime));
    }

    /**
     * @param GetCurrentAppRequest $request
     *
     * @return GetCurrentAppResponse
     */
    public function getCurrentApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCurrentAppHeaders([]);

        return $this->getCurrentAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCurrentAppRequest $request
     * @param GetCurrentAppHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetCurrentAppResponse
     */
    public function getCurrentAppWithOptions($request, $headers, $runtime)
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
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetCurrentAppResponse::fromMap($this->doROARequest('GetCurrentApp', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/currentApps/query', 'json', $req, $runtime));
    }

    /**
     * @param string             $spaceId
     * @param GetDentriesRequest $request
     *
     * @return GetDentriesResponse
     */
    public function getDentries($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDentriesHeaders([]);

        return $this->getDentriesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string             $spaceId
     * @param GetDentriesRequest $request
     * @param GetDentriesHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetDentriesResponse
     */
    public function getDentriesWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->dentryIds)) {
            @$body['dentryIds'] = $request->dentryIds;
        }
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
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

        return GetDentriesResponse::fromMap($this->doROARequest('GetDentries', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/query', 'json', $req, $runtime));
    }

    /**
     * @param string           $spaceId
     * @param string           $dentryId
     * @param GetDentryRequest $request
     *
     * @return GetDentryResponse
     */
    public function getDentry($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDentryHeaders([]);

        return $this->getDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string           $spaceId
     * @param string           $dentryId
     * @param GetDentryRequest $request
     * @param GetDentryHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return GetDentryResponse
     */
    public function getDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
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

        return GetDentryResponse::fromMap($this->doROARequest('GetDentry', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/query', 'json', $req, $runtime));
    }

    /**
     * @param string                   $spaceId
     * @param string                   $dentryId
     * @param GetDentryOpenInfoRequest $request
     *
     * @return GetDentryOpenInfoResponse
     */
    public function getDentryOpenInfo($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDentryOpenInfoHeaders([]);

        return $this->getDentryOpenInfoWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string                   $spaceId
     * @param string                   $dentryId
     * @param GetDentryOpenInfoRequest $request
     * @param GetDentryOpenInfoHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetDentryOpenInfoResponse
     */
    public function getDentryOpenInfoWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
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

        return GetDentryOpenInfoResponse::fromMap($this->doROARequest('GetDentryOpenInfo', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/openInfos/query', 'json', $req, $runtime));
    }

    /**
     * @param string                     $spaceId
     * @param GetDentryThumbnailsRequest $request
     *
     * @return GetDentryThumbnailsResponse
     */
    public function getDentryThumbnails($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDentryThumbnailsHeaders([]);

        return $this->getDentryThumbnailsWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $spaceId
     * @param GetDentryThumbnailsRequest $request
     * @param GetDentryThumbnailsHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetDentryThumbnailsResponse
     */
    public function getDentryThumbnailsWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->dentryIds)) {
            @$body['dentryIds'] = $request->dentryIds;
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

        return GetDentryThumbnailsResponse::fromMap($this->doROARequest('GetDentryThumbnails', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/thumbnails/query', 'json', $req, $runtime));
    }

    /**
     * @param string                     $spaceId
     * @param string                     $dentryId
     * @param GetFileDownloadInfoRequest $request
     *
     * @return GetFileDownloadInfoResponse
     */
    public function getFileDownloadInfo($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFileDownloadInfoHeaders([]);

        return $this->getFileDownloadInfoWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $spaceId
     * @param string                     $dentryId
     * @param GetFileDownloadInfoRequest $request
     * @param GetFileDownloadInfoHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetFileDownloadInfoResponse
     */
    public function getFileDownloadInfoWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
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

        return GetFileDownloadInfoResponse::fromMap($this->doROARequest('GetFileDownloadInfo', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/downloadInfos/query', 'json', $req, $runtime));
    }

    /**
     * @param string                   $spaceId
     * @param GetFileUploadInfoRequest $request
     *
     * @return GetFileUploadInfoResponse
     */
    public function getFileUploadInfo($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFileUploadInfoHeaders([]);

        return $this->getFileUploadInfoWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string                   $spaceId
     * @param GetFileUploadInfoRequest $request
     * @param GetFileUploadInfoHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetFileUploadInfoResponse
     */
    public function getFileUploadInfoWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->multipart)) {
            @$body['multipart'] = $request->multipart;
        }
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->protocol)) {
            @$body['protocol'] = $request->protocol;
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

        return GetFileUploadInfoResponse::fromMap($this->doROARequest('GetFileUploadInfo', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/files/uploadInfos/query', 'json', $req, $runtime));
    }

    /**
     * @param GetMultipartFileUploadInfosRequest $request
     *
     * @return GetMultipartFileUploadInfosResponse
     */
    public function getMultipartFileUploadInfos($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMultipartFileUploadInfosHeaders([]);

        return $this->getMultipartFileUploadInfosWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetMultipartFileUploadInfosRequest $request
     * @param GetMultipartFileUploadInfosHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return GetMultipartFileUploadInfosResponse
     */
    public function getMultipartFileUploadInfosWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->partNumbers)) {
            @$body['partNumbers'] = $request->partNumbers;
        }
        if (!Utils::isUnset($request->uploadKey)) {
            @$body['uploadKey'] = $request->uploadKey;
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

        return GetMultipartFileUploadInfosResponse::fromMap($this->doROARequest('GetMultipartFileUploadInfos', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/files/multiPartUploadInfos/query', 'json', $req, $runtime));
    }

    /**
     * @param string        $corpId
     * @param GetOrgRequest $request
     *
     * @return GetOrgResponse
     */
    public function getOrg($corpId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOrgHeaders([]);

        return $this->getOrgWithOptions($corpId, $request, $headers, $runtime);
    }

    /**
     * @param string         $corpId
     * @param GetOrgRequest  $request
     * @param GetOrgHeaders  $headers
     * @param RuntimeOptions $runtime
     *
     * @return GetOrgResponse
     */
    public function getOrgWithOptions($corpId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $corpId = OpenApiUtilClient::getEncodeParam($corpId);
        $query  = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return GetOrgResponse::fromMap($this->doROARequest('GetOrg', 'storage_1.0', 'HTTP', 'GET', 'AK', '/v1.0/storage/orgs/' . $corpId . '', 'json', $req, $runtime));
    }

    /**
     * @param GetRecycleBinRequest $request
     *
     * @return GetRecycleBinResponse
     */
    public function getRecycleBin($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRecycleBinHeaders([]);

        return $this->getRecycleBinWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetRecycleBinRequest $request
     * @param GetRecycleBinHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetRecycleBinResponse
     */
    public function getRecycleBinWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->recycleBinScope)) {
            @$query['recycleBinScope'] = $request->recycleBinScope;
        }
        if (!Utils::isUnset($request->scopeId)) {
            @$query['scopeId'] = $request->scopeId;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return GetRecycleBinResponse::fromMap($this->doROARequest('GetRecycleBin', 'storage_1.0', 'HTTP', 'GET', 'AK', '/v1.0/storage/recycleBins', 'json', $req, $runtime));
    }

    /**
     * @param string                $recycleBinId
     * @param string                $recycleItemId
     * @param GetRecycleItemRequest $request
     *
     * @return GetRecycleItemResponse
     */
    public function getRecycleItem($recycleBinId, $recycleItemId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRecycleItemHeaders([]);

        return $this->getRecycleItemWithOptions($recycleBinId, $recycleItemId, $request, $headers, $runtime);
    }

    /**
     * @param string                $recycleBinId
     * @param string                $recycleItemId
     * @param GetRecycleItemRequest $request
     * @param GetRecycleItemHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetRecycleItemResponse
     */
    public function getRecycleItemWithOptions($recycleBinId, $recycleItemId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $recycleBinId  = OpenApiUtilClient::getEncodeParam($recycleBinId);
        $recycleItemId = OpenApiUtilClient::getEncodeParam($recycleItemId);
        $query         = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return GetRecycleItemResponse::fromMap($this->doROARequest('GetRecycleItem', 'storage_1.0', 'HTTP', 'GET', 'AK', '/v1.0/storage/recycleBins/' . $recycleBinId . '/recycleItems/' . $recycleItemId . '', 'json', $req, $runtime));
    }

    /**
     * @param string          $spaceId
     * @param GetSpaceRequest $request
     *
     * @return GetSpaceResponse
     */
    public function getSpace($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSpaceHeaders([]);

        return $this->getSpaceWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string          $spaceId
     * @param GetSpaceRequest $request
     * @param GetSpaceHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return GetSpaceResponse
     */
    public function getSpaceWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return GetSpaceResponse::fromMap($this->doROARequest('GetSpace', 'storage_1.0', 'HTTP', 'GET', 'AK', '/v1.0/storage/spaces/' . $spaceId . '', 'json', $req, $runtime));
    }

    /**
     * @param string         $taskId
     * @param GetTaskRequest $request
     *
     * @return GetTaskResponse
     */
    public function getTask($taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTaskHeaders([]);

        return $this->getTaskWithOptions($taskId, $request, $headers, $runtime);
    }

    /**
     * @param string         $taskId
     * @param GetTaskRequest $request
     * @param GetTaskHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return GetTaskResponse
     */
    public function getTaskWithOptions($taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $query  = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return GetTaskResponse::fromMap($this->doROARequest('GetTask', 'storage_1.0', 'HTTP', 'GET', 'AK', '/v1.0/storage/tasks/' . $taskId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                         $spaceId
     * @param InitMultipartFileUploadRequest $request
     *
     * @return InitMultipartFileUploadResponse
     */
    public function initMultipartFileUpload($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InitMultipartFileUploadHeaders([]);

        return $this->initMultipartFileUploadWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string                         $spaceId
     * @param InitMultipartFileUploadRequest $request
     * @param InitMultipartFileUploadHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return InitMultipartFileUploadResponse
     */
    public function initMultipartFileUploadWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
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

        return InitMultipartFileUploadResponse::fromMap($this->doROARequest('InitMultipartFileUpload', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/files/multiPartUploadInfos/init', 'json', $req, $runtime));
    }

    /**
     * @param string                 $spaceId
     * @param ListAllDentriesRequest $request
     *
     * @return ListAllDentriesResponse
     */
    public function listAllDentries($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAllDentriesHeaders([]);

        return $this->listAllDentriesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $spaceId
     * @param ListAllDentriesRequest $request
     * @param ListAllDentriesHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ListAllDentriesResponse
     */
    public function listAllDentriesWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
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

        return ListAllDentriesResponse::fromMap($this->doROARequest('ListAllDentries', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/listAll', 'json', $req, $runtime));
    }

    /**
     * @param string              $spaceId
     * @param ListDentriesRequest $request
     *
     * @return ListDentriesResponse
     */
    public function listDentries($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListDentriesHeaders([]);

        return $this->listDentriesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string              $spaceId
     * @param ListDentriesRequest $request
     * @param ListDentriesHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return ListDentriesResponse
     */
    public function listDentriesWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->order)) {
            @$query['order'] = $request->order;
        }
        if (!Utils::isUnset($request->orderBy)) {
            @$query['orderBy'] = $request->orderBy;
        }
        if (!Utils::isUnset($request->parentId)) {
            @$query['parentId'] = $request->parentId;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        if (!Utils::isUnset($request->withThumbnail)) {
            @$query['withThumbnail'] = $request->withThumbnail;
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

        return ListDentriesResponse::fromMap($this->doROARequest('ListDentries', 'storage_1.0', 'HTTP', 'GET', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries', 'json', $req, $runtime));
    }

    /**
     * @param string                    $spaceId
     * @param string                    $dentryId
     * @param ListDentryVersionsRequest $request
     *
     * @return ListDentryVersionsResponse
     */
    public function listDentryVersions($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListDentryVersionsHeaders([]);

        return $this->listDentryVersionsWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string                    $spaceId
     * @param string                    $dentryId
     * @param ListDentryVersionsRequest $request
     * @param ListDentryVersionsHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return ListDentryVersionsResponse
     */
    public function listDentryVersionsWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return ListDentryVersionsResponse::fromMap($this->doROARequest('ListDentryVersions', 'storage_1.0', 'HTTP', 'GET', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/versions', 'json', $req, $runtime));
    }

    /**
     * @param string                 $spaceId
     * @param string                 $dentryId
     * @param ListPermissionsRequest $request
     *
     * @return ListPermissionsResponse
     */
    public function listPermissions($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListPermissionsHeaders([]);

        return $this->listPermissionsWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $spaceId
     * @param string                 $dentryId
     * @param ListPermissionsRequest $request
     * @param ListPermissionsHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ListPermissionsResponse
     */
    public function listPermissionsWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
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

        return ListPermissionsResponse::fromMap($this->doROARequest('ListPermissions', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/permissions/query', 'json', $req, $runtime));
    }

    /**
     * @param string                  $recycleBinId
     * @param ListRecycleItemsRequest $request
     *
     * @return ListRecycleItemsResponse
     */
    public function listRecycleItems($recycleBinId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListRecycleItemsHeaders([]);

        return $this->listRecycleItemsWithOptions($recycleBinId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $recycleBinId
     * @param ListRecycleItemsRequest $request
     * @param ListRecycleItemsHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ListRecycleItemsResponse
     */
    public function listRecycleItemsWithOptions($recycleBinId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $recycleBinId = OpenApiUtilClient::getEncodeParam($recycleBinId);
        $query        = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return ListRecycleItemsResponse::fromMap($this->doROARequest('ListRecycleItems', 'storage_1.0', 'HTTP', 'GET', 'AK', '/v1.0/storage/recycleBins/' . $recycleBinId . '/recycleItems', 'json', $req, $runtime));
    }

    /**
     * @param string              $spaceId
     * @param MoveDentriesRequest $request
     *
     * @return MoveDentriesResponse
     */
    public function moveDentries($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MoveDentriesHeaders([]);

        return $this->moveDentriesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string              $spaceId
     * @param MoveDentriesRequest $request
     * @param MoveDentriesHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return MoveDentriesResponse
     */
    public function moveDentriesWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->dentryIds)) {
            @$body['dentryIds'] = $request->dentryIds;
        }
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->targetFolderId)) {
            @$body['targetFolderId'] = $request->targetFolderId;
        }
        if (!Utils::isUnset($request->targetSpaceId)) {
            @$body['targetSpaceId'] = $request->targetSpaceId;
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

        return MoveDentriesResponse::fromMap($this->doROARequest('MoveDentries', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/batchMove', 'json', $req, $runtime));
    }

    /**
     * @param string            $spaceId
     * @param string            $dentryId
     * @param MoveDentryRequest $request
     *
     * @return MoveDentryResponse
     */
    public function moveDentry($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MoveDentryHeaders([]);

        return $this->moveDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string            $spaceId
     * @param string            $dentryId
     * @param MoveDentryRequest $request
     * @param MoveDentryHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return MoveDentryResponse
     */
    public function moveDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->targetFolderId)) {
            @$body['targetFolderId'] = $request->targetFolderId;
        }
        if (!Utils::isUnset($request->targetSpaceId)) {
            @$body['targetSpaceId'] = $request->targetSpaceId;
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

        return MoveDentryResponse::fromMap($this->doROARequest('MoveDentry', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/move', 'json', $req, $runtime));
    }

    /**
     * @param string                  $spaceId
     * @param string                  $dentryId
     * @param RegisterOpenInfoRequest $request
     *
     * @return RegisterOpenInfoResponse
     */
    public function registerOpenInfo($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterOpenInfoHeaders([]);

        return $this->registerOpenInfoWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $spaceId
     * @param string                  $dentryId
     * @param RegisterOpenInfoRequest $request
     * @param RegisterOpenInfoHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return RegisterOpenInfoResponse
     */
    public function registerOpenInfoWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->openInfos)) {
            @$body['openInfos'] = $request->openInfos;
        }
        if (!Utils::isUnset($request->provider)) {
            @$body['provider'] = $request->provider;
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

        return RegisterOpenInfoResponse::fromMap($this->doROARequest('RegisterOpenInfo', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/openInfos/register', 'json', $req, $runtime));
    }

    /**
     * @param string              $spaceId
     * @param string              $dentryId
     * @param RenameDentryRequest $request
     *
     * @return RenameDentryResponse
     */
    public function renameDentry($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RenameDentryHeaders([]);

        return $this->renameDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string              $spaceId
     * @param string              $dentryId
     * @param RenameDentryRequest $request
     * @param RenameDentryHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return RenameDentryResponse
     */
    public function renameDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->newName)) {
            @$body['newName'] = $request->newName;
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

        return RenameDentryResponse::fromMap($this->doROARequest('RenameDentry', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/rename', 'json', $req, $runtime));
    }

    /**
     * @param string                    $recycleBinId
     * @param string                    $recycleItemId
     * @param RestoreRecycleItemRequest $request
     *
     * @return RestoreRecycleItemResponse
     */
    public function restoreRecycleItem($recycleBinId, $recycleItemId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RestoreRecycleItemHeaders([]);

        return $this->restoreRecycleItemWithOptions($recycleBinId, $recycleItemId, $request, $headers, $runtime);
    }

    /**
     * @param string                    $recycleBinId
     * @param string                    $recycleItemId
     * @param RestoreRecycleItemRequest $request
     * @param RestoreRecycleItemHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return RestoreRecycleItemResponse
     */
    public function restoreRecycleItemWithOptions($recycleBinId, $recycleItemId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $recycleBinId  = OpenApiUtilClient::getEncodeParam($recycleBinId);
        $recycleItemId = OpenApiUtilClient::getEncodeParam($recycleItemId);
        $query         = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
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

        return RestoreRecycleItemResponse::fromMap($this->doROARequest('RestoreRecycleItem', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/recycleBins/' . $recycleBinId . '/recycleItems/' . $recycleItemId . '/restore', 'json', $req, $runtime));
    }

    /**
     * @param string                     $recycleBinId
     * @param RestoreRecycleItemsRequest $request
     *
     * @return RestoreRecycleItemsResponse
     */
    public function restoreRecycleItems($recycleBinId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RestoreRecycleItemsHeaders([]);

        return $this->restoreRecycleItemsWithOptions($recycleBinId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $recycleBinId
     * @param RestoreRecycleItemsRequest $request
     * @param RestoreRecycleItemsHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return RestoreRecycleItemsResponse
     */
    public function restoreRecycleItemsWithOptions($recycleBinId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $recycleBinId = OpenApiUtilClient::getEncodeParam($recycleBinId);
        $query        = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->recycleItemIds)) {
            @$body['recycleItemIds'] = $request->recycleItemIds;
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

        return RestoreRecycleItemsResponse::fromMap($this->doROARequest('RestoreRecycleItems', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/recycleBins/' . $recycleBinId . '/recycleItems/batchRestore', 'json', $req, $runtime));
    }

    /**
     * @param string                     $spaceId
     * @param string                     $dentryId
     * @param string                     $version
     * @param RevertDentryVersionRequest $request
     *
     * @return RevertDentryVersionResponse
     */
    public function revertDentryVersion($spaceId, $dentryId, $version, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RevertDentryVersionHeaders([]);

        return $this->revertDentryVersionWithOptions($spaceId, $dentryId, $version, $request, $headers, $runtime);
    }

    /**
     * @param string                     $spaceId
     * @param string                     $dentryId
     * @param string                     $version
     * @param RevertDentryVersionRequest $request
     * @param RevertDentryVersionHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return RevertDentryVersionResponse
     */
    public function revertDentryVersionWithOptions($spaceId, $dentryId, $version, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $version  = OpenApiUtilClient::getEncodeParam($version);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
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

        return RevertDentryVersionResponse::fromMap($this->doROARequest('RevertDentryVersion', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/versions/' . $version . '/revert', 'json', $req, $runtime));
    }

    /**
     * @param SubscribeEventRequest $request
     *
     * @return SubscribeEventResponse
     */
    public function subscribeEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SubscribeEventHeaders([]);

        return $this->subscribeEventWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SubscribeEventRequest $request
     * @param SubscribeEventHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SubscribeEventResponse
     */
    public function subscribeEventWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->scope)) {
            @$body['scope'] = $request->scope;
        }
        if (!Utils::isUnset($request->scopeId)) {
            @$body['scopeId'] = $request->scopeId;
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

        return SubscribeEventResponse::fromMap($this->doROARequest('SubscribeEvent', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/events/subscribe', 'json', $req, $runtime));
    }

    /**
     * @param UnsubscribeEventRequest $request
     *
     * @return UnsubscribeEventResponse
     */
    public function unsubscribeEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnsubscribeEventHeaders([]);

        return $this->unsubscribeEventWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UnsubscribeEventRequest $request
     * @param UnsubscribeEventHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return UnsubscribeEventResponse
     */
    public function unsubscribeEventWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->scope)) {
            @$body['scope'] = $request->scope;
        }
        if (!Utils::isUnset($request->scopeId)) {
            @$body['scopeId'] = $request->scopeId;
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

        return UnsubscribeEventResponse::fromMap($this->doROARequest('UnsubscribeEvent', 'storage_1.0', 'HTTP', 'POST', 'AK', '/v1.0/storage/events/unsubscribe', 'json', $req, $runtime));
    }

    /**
     * @param string                           $spaceId
     * @param string                           $dentryId
     * @param UpdateDentryAppPropertiesRequest $request
     *
     * @return UpdateDentryAppPropertiesResponse
     */
    public function updateDentryAppProperties($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateDentryAppPropertiesHeaders([]);

        return $this->updateDentryAppPropertiesWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string                           $spaceId
     * @param string                           $dentryId
     * @param UpdateDentryAppPropertiesRequest $request
     * @param UpdateDentryAppPropertiesHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return UpdateDentryAppPropertiesResponse
     */
    public function updateDentryAppPropertiesWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->appProperties)) {
            @$body['appProperties'] = $request->appProperties;
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

        return UpdateDentryAppPropertiesResponse::fromMap($this->doROARequest('UpdateDentryAppProperties', 'storage_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/appProperties', 'json', $req, $runtime));
    }

    /**
     * @param string                  $spaceId
     * @param string                  $dentryId
     * @param UpdatePermissionRequest $request
     *
     * @return UpdatePermissionResponse
     */
    public function updatePermission($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdatePermissionHeaders([]);

        return $this->updatePermissionWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string                  $spaceId
     * @param string                  $dentryId
     * @param UpdatePermissionRequest $request
     * @param UpdatePermissionHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return UpdatePermissionResponse
     */
    public function updatePermissionWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->option)) {
            @$body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->roleId)) {
            @$body['roleId'] = $request->roleId;
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

        return UpdatePermissionResponse::fromMap($this->doROARequest('UpdatePermission', 'storage_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/storage/spaces/' . $spaceId . '/dentries/' . $dentryId . '/permissions', 'json', $req, $runtime));
    }
}
