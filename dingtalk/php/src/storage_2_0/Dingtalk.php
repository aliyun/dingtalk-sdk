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
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListPermissionsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListPermissionsRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListPermissionsResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchDentriesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchDentriesRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchDentriesResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchWorkspacesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchWorkspacesRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchWorkspacesResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SetPermissionInheritanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SetPermissionInheritanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SetPermissionInheritanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\UpdatePermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\UpdatePermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\UpdatePermissionResponse;
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
     * @param string               $dentryUuid
     * @param AddPermissionRequest $request
     * @param AddPermissionHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return AddPermissionResponse
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
     * @param string               $dentryUuid
     * @param AddPermissionRequest $request
     *
     * @return AddPermissionResponse
     */
    public function addPermission($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddPermissionHeaders([]);

        return $this->addPermissionWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @param string            $parentDentryUuid
     * @param CommitFileRequest $request
     * @param CommitFileHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return CommitFileResponse
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
     * @param string            $parentDentryUuid
     * @param CommitFileRequest $request
     *
     * @return CommitFileResponse
     */
    public function commitFile($parentDentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CommitFileHeaders([]);

        return $this->commitFileWithOptions($parentDentryUuid, $request, $headers, $runtime);
    }

    /**
     * @param string                  $dentryUuid
     * @param DeletePermissionRequest $request
     * @param DeletePermissionHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return DeletePermissionResponse
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
     * @param string                  $dentryUuid
     * @param DeletePermissionRequest $request
     *
     * @return DeletePermissionResponse
     */
    public function deletePermission($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeletePermissionHeaders([]);

        return $this->deletePermissionWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @param string                   $parentDentryUuid
     * @param GetFileUploadInfoRequest $request
     * @param GetFileUploadInfoHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetFileUploadInfoResponse
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
     * @param string                   $parentDentryUuid
     * @param GetFileUploadInfoRequest $request
     *
     * @return GetFileUploadInfoResponse
     */
    public function getFileUploadInfo($parentDentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFileUploadInfoHeaders([]);

        return $this->getFileUploadInfoWithOptions($parentDentryUuid, $request, $headers, $runtime);
    }

    /**
     * @param string                          $dentryUuid
     * @param GetPermissionInheritanceRequest $request
     * @param GetPermissionInheritanceHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return GetPermissionInheritanceResponse
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
     * @param string                          $dentryUuid
     * @param GetPermissionInheritanceRequest $request
     *
     * @return GetPermissionInheritanceResponse
     */
    public function getPermissionInheritance($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPermissionInheritanceHeaders([]);

        return $this->getPermissionInheritanceWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @param string                 $dentryUuid
     * @param ListPermissionsRequest $request
     * @param ListPermissionsHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ListPermissionsResponse
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
     * @param string                 $dentryUuid
     * @param ListPermissionsRequest $request
     *
     * @return ListPermissionsResponse
     */
    public function listPermissions($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListPermissionsHeaders([]);

        return $this->listPermissionsWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @param SearchDentriesRequest $request
     * @param SearchDentriesHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SearchDentriesResponse
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
     * @param SearchDentriesRequest $request
     *
     * @return SearchDentriesResponse
     */
    public function searchDentries($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchDentriesHeaders([]);

        return $this->searchDentriesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SearchWorkspacesRequest $request
     * @param SearchWorkspacesHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return SearchWorkspacesResponse
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
     * @param SearchWorkspacesRequest $request
     *
     * @return SearchWorkspacesResponse
     */
    public function searchWorkspaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchWorkspacesHeaders([]);

        return $this->searchWorkspacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                          $dentryUuid
     * @param SetPermissionInheritanceRequest $request
     * @param SetPermissionInheritanceHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return SetPermissionInheritanceResponse
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
     * @param string                          $dentryUuid
     * @param SetPermissionInheritanceRequest $request
     *
     * @return SetPermissionInheritanceResponse
     */
    public function setPermissionInheritance($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetPermissionInheritanceHeaders([]);

        return $this->setPermissionInheritanceWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @param string                  $dentryUuid
     * @param UpdatePermissionRequest $request
     * @param UpdatePermissionHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return UpdatePermissionResponse
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
     * @param string                  $dentryUuid
     * @param UpdatePermissionRequest $request
     *
     * @return UpdatePermissionResponse
     */
    public function updatePermission($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdatePermissionHeaders([]);

        return $this->updatePermissionWithOptions($dentryUuid, $request, $headers, $runtime);
    }
}
