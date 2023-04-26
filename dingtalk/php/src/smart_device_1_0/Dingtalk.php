<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\AddDeviceVideoConferenceMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\AddDeviceVideoConferenceMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\AddDeviceVideoConferenceMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\CreateDeviceVideoConferenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\CreateDeviceVideoConferenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\CreateDeviceVideoConferenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\ExtractFacialFeatureHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\ExtractFacialFeatureRequest;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\ExtractFacialFeatureResponse;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\KickDeviceVideoConferenceMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\KickDeviceVideoConferenceMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\KickDeviceVideoConferenceMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\MachineManagerUpdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\MachineManagerUpdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\MachineManagerUpdateResponse;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\MachineUsersUpdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\MachineUsersUpdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\MachineUsersUpdateResponse;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\QueryDeviceVideoConferenceBookHeaders;
use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\QueryDeviceVideoConferenceBookResponse;
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
     * @param string                                 $deviceId
     * @param string                                 $conferenceId
     * @param AddDeviceVideoConferenceMembersRequest $request
     * @param AddDeviceVideoConferenceMembersHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return AddDeviceVideoConferenceMembersResponse
     */
    public function addDeviceVideoConferenceMembersWithOptions($deviceId, $conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
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
            'action'      => 'AddDeviceVideoConferenceMembers',
            'version'     => 'smartDevice_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/smartDevice/devices/' . $deviceId . '/videoConferences/' . $conferenceId . '/members',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'none',
        ]);

        return AddDeviceVideoConferenceMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                                 $deviceId
     * @param string                                 $conferenceId
     * @param AddDeviceVideoConferenceMembersRequest $request
     *
     * @return AddDeviceVideoConferenceMembersResponse
     */
    public function addDeviceVideoConferenceMembers($deviceId, $conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddDeviceVideoConferenceMembersHeaders([]);

        return $this->addDeviceVideoConferenceMembersWithOptions($deviceId, $conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string                             $deviceId
     * @param CreateDeviceVideoConferenceRequest $request
     * @param CreateDeviceVideoConferenceHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return CreateDeviceVideoConferenceResponse
     */
    public function createDeviceVideoConferenceWithOptions($deviceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
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
            'action'      => 'CreateDeviceVideoConference',
            'version'     => 'smartDevice_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/smartDevice/devices/' . $deviceId . '/videoConferences',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateDeviceVideoConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                             $deviceId
     * @param CreateDeviceVideoConferenceRequest $request
     *
     * @return CreateDeviceVideoConferenceResponse
     */
    public function createDeviceVideoConference($deviceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDeviceVideoConferenceHeaders([]);

        return $this->createDeviceVideoConferenceWithOptions($deviceId, $request, $headers, $runtime);
    }

    /**
     * @param ExtractFacialFeatureRequest $request
     * @param ExtractFacialFeatureHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return ExtractFacialFeatureResponse
     */
    public function extractFacialFeatureWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->mediaId)) {
            $body['mediaId'] = $request->mediaId;
        }
        if (!Utils::isUnset($request->userid)) {
            $body['userid'] = $request->userid;
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
            'action'      => 'ExtractFacialFeature',
            'version'     => 'smartDevice_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/smartDevice/faceRecognitions/features/extract',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ExtractFacialFeatureResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ExtractFacialFeatureRequest $request
     *
     * @return ExtractFacialFeatureResponse
     */
    public function extractFacialFeature($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExtractFacialFeatureHeaders([]);

        return $this->extractFacialFeatureWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                                  $deviceId
     * @param string                                  $conferenceId
     * @param KickDeviceVideoConferenceMembersRequest $request
     * @param KickDeviceVideoConferenceMembersHeaders $headers
     * @param RuntimeOptions                          $runtime
     *
     * @return KickDeviceVideoConferenceMembersResponse
     */
    public function kickDeviceVideoConferenceMembersWithOptions($deviceId, $conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
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
            'action'      => 'KickDeviceVideoConferenceMembers',
            'version'     => 'smartDevice_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/smartDevice/devices/' . $deviceId . '/videoConferences/' . $conferenceId . '/members/batchDelete',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'none',
        ]);

        return KickDeviceVideoConferenceMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                                  $deviceId
     * @param string                                  $conferenceId
     * @param KickDeviceVideoConferenceMembersRequest $request
     *
     * @return KickDeviceVideoConferenceMembersResponse
     */
    public function kickDeviceVideoConferenceMembers($deviceId, $conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new KickDeviceVideoConferenceMembersHeaders([]);

        return $this->kickDeviceVideoConferenceMembersWithOptions($deviceId, $conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param MachineManagerUpdateRequest $request
     * @param MachineManagerUpdateHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return MachineManagerUpdateResponse
     */
    public function machineManagerUpdateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->atmManagerRightMap)) {
            $body['atmManagerRightMap'] = $request->atmManagerRightMap;
        }
        if (!Utils::isUnset($request->deviceId)) {
            $body['deviceId'] = $request->deviceId;
        }
        if (!Utils::isUnset($request->scopeDeptIds)) {
            $body['scopeDeptIds'] = $request->scopeDeptIds;
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
            'action'      => 'MachineManagerUpdate',
            'version'     => 'smartDevice_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/smartDevice/atmachines/managers',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return MachineManagerUpdateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param MachineManagerUpdateRequest $request
     *
     * @return MachineManagerUpdateResponse
     */
    public function machineManagerUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MachineManagerUpdateHeaders([]);

        return $this->machineManagerUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param MachineUsersUpdateRequest $request
     * @param MachineUsersUpdateHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return MachineUsersUpdateResponse
     */
    public function machineUsersUpdateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->addDeptIds)) {
            $body['addDeptIds'] = $request->addDeptIds;
        }
        if (!Utils::isUnset($request->addUserIds)) {
            $body['addUserIds'] = $request->addUserIds;
        }
        if (!Utils::isUnset($request->delDeptIds)) {
            $body['delDeptIds'] = $request->delDeptIds;
        }
        if (!Utils::isUnset($request->delUserIds)) {
            $body['delUserIds'] = $request->delUserIds;
        }
        if (!Utils::isUnset($request->devIds)) {
            $body['devIds'] = $request->devIds;
        }
        if (!Utils::isUnset($request->deviceIds)) {
            $body['deviceIds'] = $request->deviceIds;
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
            'action'      => 'MachineUsersUpdate',
            'version'     => 'smartDevice_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/smartDevice/atmachines/users',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return MachineUsersUpdateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param MachineUsersUpdateRequest $request
     *
     * @return MachineUsersUpdateResponse
     */
    public function machineUsersUpdate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MachineUsersUpdateHeaders([]);

        return $this->machineUsersUpdateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                                $deviceId
     * @param string                                $bookId
     * @param QueryDeviceVideoConferenceBookHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return QueryDeviceVideoConferenceBookResponse
     */
    public function queryDeviceVideoConferenceBookWithOptions($deviceId, $bookId, $headers, $runtime)
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
            'action'      => 'QueryDeviceVideoConferenceBook',
            'version'     => 'smartDevice_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/smartDevice/devices/' . $deviceId . '/books/' . $bookId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryDeviceVideoConferenceBookResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $deviceId
     * @param string $bookId
     *
     * @return QueryDeviceVideoConferenceBookResponse
     */
    public function queryDeviceVideoConferenceBook($deviceId, $bookId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceVideoConferenceBookHeaders([]);

        return $this->queryDeviceVideoConferenceBookWithOptions($deviceId, $bookId, $headers, $runtime);
    }
}
