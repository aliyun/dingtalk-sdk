<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0;

use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetDownloadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetDownloadInfoResponse;
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
     * @param string $userId
     * @param string $spaceId
     * @param string $fileId
     *
     * @return GetDownloadInfoResponse
     */
    public function getDownloadInfo($userId, $spaceId, $fileId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDownloadInfoHeaders([]);

        return $this->getDownloadInfoWithOptions($userId, $spaceId, $fileId, $headers, $runtime);
    }

    /**
     * @param string                 $userId
     * @param string                 $spaceId
     * @param string                 $fileId
     * @param GetDownloadInfoHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetDownloadInfoResponse
     */
    public function getDownloadInfoWithOptions($userId, $spaceId, $fileId, $headers, $runtime)
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

        return GetDownloadInfoResponse::fromMap($this->doROARequest('GetDownloadInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', '/v1.0/drive/users/' . $userId . '/spaces/' . $spaceId . '/files/' . $fileId . '/downloadInfo', 'json', $req, $runtime));
    }
}
