<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\CommitFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\CommitFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\CommitFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\GetFileUploadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\GetFileUploadInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\GetFileUploadInfoResponse;
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
        $parentDentryUuid = OpenApiUtilClient::getEncodeParam($parentDentryUuid);
        $query            = [];
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

        return CommitFileResponse::fromMap($this->doROARequest('CommitFile', 'storage_2.0', 'HTTP', 'POST', 'AK', '/v2.0/storage/spaces/files/' . $parentDentryUuid . '/commit', 'json', $req, $runtime));
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
        $parentDentryUuid = OpenApiUtilClient::getEncodeParam($parentDentryUuid);
        $query            = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
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

        return GetFileUploadInfoResponse::fromMap($this->doROARequest('GetFileUploadInfo', 'storage_2.0', 'HTTP', 'POST', 'AK', '/v2.0/storage/spaces/files/' . $parentDentryUuid . '/uploadInfos/query', 'json', $req, $runtime));
    }
}
