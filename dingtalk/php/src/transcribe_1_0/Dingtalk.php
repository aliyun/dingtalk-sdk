<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models\GetTranscribeBriefHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models\GetTranscribeBriefResponse;
use AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models\RemovePermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models\RemovePermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models\RemovePermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models\UpdatePermissionForUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models\UpdatePermissionForUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models\UpdatePermissionForUsersResponse;
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
     * @param string                    $taskUuid
     * @param GetTranscribeBriefHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetTranscribeBriefResponse
     */
    public function getTranscribeBriefWithOptions($taskUuid, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetTranscribeBrief',
            'version'     => 'transcribe_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/transcribe/tasks/' . $taskUuid . '/briefInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTranscribeBriefResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $taskUuid
     *
     * @return GetTranscribeBriefResponse
     */
    public function getTranscribeBrief($taskUuid)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTranscribeBriefHeaders([]);

        return $this->getTranscribeBriefWithOptions($taskUuid, $headers, $runtime);
    }

    /**
     * @param string                  $taskUuid
     * @param RemovePermissionRequest $request
     * @param RemovePermissionHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return RemovePermissionResponse
     */
    public function removePermissionWithOptions($taskUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->taskCreator)) {
            $body['taskCreator'] = $request->taskCreator;
        }
        if (!Utils::isUnset($request->taskId)) {
            $body['taskId'] = $request->taskId;
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
            'action'      => 'RemovePermission',
            'version'     => 'transcribe_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/transcribe/tasks/' . $taskUuid . '/permissions/remove',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RemovePermissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                  $taskUuid
     * @param RemovePermissionRequest $request
     *
     * @return RemovePermissionResponse
     */
    public function removePermission($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemovePermissionHeaders([]);

        return $this->removePermissionWithOptions($taskUuid, $request, $headers, $runtime);
    }

    /**
     * @param string                          $taskUuid
     * @param UpdatePermissionForUsersRequest $request
     * @param UpdatePermissionForUsersHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return UpdatePermissionForUsersResponse
     */
    public function updatePermissionForUsersWithOptions($taskUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorUid)) {
            $query['operatorUid'] = $request->operatorUid;
        }
        $body = [];
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->taskCreator)) {
            $body['taskCreator'] = $request->taskCreator;
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
            'action'      => 'UpdatePermissionForUsers',
            'version'     => 'transcribe_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/transcribe/tasks/' . $taskUuid . '/permissions',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdatePermissionForUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                          $taskUuid
     * @param UpdatePermissionForUsersRequest $request
     *
     * @return UpdatePermissionForUsersResponse
     */
    public function updatePermissionForUsers($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdatePermissionForUsersHeaders([]);

        return $this->updatePermissionForUsersWithOptions($taskUuid, $request, $headers, $runtime);
    }
}
