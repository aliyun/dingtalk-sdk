<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models\UpdatePermissionForUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models\UpdatePermissionForUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models\UpdatePermissionForUsersResponse;
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
     * @param string                          $taskId
     * @param UpdatePermissionForUsersRequest $request
     *
     * @return UpdatePermissionForUsersResponse
     */
    public function updatePermissionForUsers($taskId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdatePermissionForUsersHeaders([]);

        return $this->updatePermissionForUsersWithOptions($taskId, $request, $headers, $runtime);
    }

    /**
     * @param string                          $taskId
     * @param UpdatePermissionForUsersRequest $request
     * @param UpdatePermissionForUsersHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return UpdatePermissionForUsersResponse
     */
    public function updatePermissionForUsersWithOptions($taskId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $taskId = OpenApiUtilClient::getEncodeParam($taskId);
        $query  = [];
        if (!Utils::isUnset($request->operatorUid)) {
            @$query['operatorUid'] = $request->operatorUid;
        }
        $body = [];
        if (!Utils::isUnset($request->bizType)) {
            @$body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->members)) {
            @$body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->taskCreator)) {
            @$body['taskCreator'] = $request->taskCreator;
        }
        if (!Utils::isUnset($request->uuid)) {
            @$body['uuid'] = $request->uuid;
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

        return UpdatePermissionForUsersResponse::fromMap($this->doROARequest('UpdatePermissionForUsers', 'transcribe_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/transcribe/tasks/' . $taskId . '/permissions', 'json', $req, $runtime));
    }
}
