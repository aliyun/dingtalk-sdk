<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\BatchRegisterDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\BatchRegisterDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\BatchRegisterDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ConnectorEventPushHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ConnectorEventPushRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ConnectorEventPushResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateChatRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateChatRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateChatRoomResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateDepartmentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateDepartmentRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateDepartmentResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateDeviceChatRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateDeviceChatRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateDeviceChatRoomResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\DeviceDingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\DeviceDingRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\DeviceDingResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\DissolveGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\DissolveGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\DissolveGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\EditDeviceAdminHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\EditDeviceAdminRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\EditDeviceAdminResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\GetDeviceGroupInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\GetDeviceGroupInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\GetDeviceGroupInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\GetWholeDeviceGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\GetWholeDeviceGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListActivateDevicesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListActivateDevicesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListActivateDevicesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListInspectInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListInspectInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListInspectInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListMaintainInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListMaintainInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListMaintainInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\PullDeviceToGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\PullDeviceToGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\PullDeviceToGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\PullUserToGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\PullUserToGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\PullUserToGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterAndActivateDeviceBatchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterAndActivateDeviceBatchRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterAndActivateDeviceBatchResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterAndActivateDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterAndActivateDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterAndActivateDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RemoveDeviceFromGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RemoveDeviceFromGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RemoveDeviceFromGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RemoveUserFromGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RemoveUserFromGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RemoveUserFromGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\SendCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\SendCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\SendCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\SendMsgHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\SendMsgRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\SendMsgResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\UninstallDeviceRobotHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\UninstallDeviceRobotRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\UninstallDeviceRobotResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\UpdateCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\UpdateCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\UpdateCardResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\UploadEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\UploadEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\UploadEventResponse;
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
     * @param BatchRegisterDeviceRequest $request
     *
     * @return BatchRegisterDeviceResponse
     */
    public function batchRegisterDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchRegisterDeviceHeaders([]);

        return $this->batchRegisterDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchRegisterDeviceRequest $request
     * @param BatchRegisterDeviceHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return BatchRegisterDeviceResponse
     */
    public function batchRegisterDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceList)) {
            @$body['deviceList'] = $request->deviceList;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return BatchRegisterDeviceResponse::fromMap($this->doROARequest('BatchRegisterDevice', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/devices/batch', 'json', $req, $runtime));
    }

    /**
     * @param ConnectorEventPushRequest $request
     *
     * @return ConnectorEventPushResponse
     */
    public function connectorEventPush($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConnectorEventPushHeaders([]);

        return $this->connectorEventPushWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ConnectorEventPushRequest $request
     * @param ConnectorEventPushHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return ConnectorEventPushResponse
     */
    public function connectorEventPushWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceTypeUuid)) {
            @$body['deviceTypeUuid'] = $request->deviceTypeUuid;
        }
        if (!Utils::isUnset($request->eventName)) {
            @$body['eventName'] = $request->eventName;
        }
        if (!Utils::isUnset($request->input)) {
            @$body['input'] = $request->input;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ConnectorEventPushResponse::fromMap($this->doROARequest('ConnectorEventPush', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/connectors/events/push', 'json', $req, $runtime));
    }

    /**
     * @param CreateChatRoomRequest $request
     *
     * @return CreateChatRoomResponse
     */
    public function createChatRoom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateChatRoomHeaders([]);

        return $this->createChatRoomWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateChatRoomRequest $request
     * @param CreateChatRoomHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreateChatRoomResponse
     */
    public function createChatRoomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->chatGroupName)) {
            @$body['chatGroupName'] = $request->chatGroupName;
        }
        if (!Utils::isUnset($request->deviceCodes)) {
            @$body['deviceCodes'] = $request->deviceCodes;
        }
        if (!Utils::isUnset($request->deviceTypeId)) {
            @$body['deviceTypeId'] = $request->deviceTypeId;
        }
        if (!Utils::isUnset($request->ownerUserId)) {
            @$body['ownerUserId'] = $request->ownerUserId;
        }
        if (!Utils::isUnset($request->roleList)) {
            @$body['roleList'] = $request->roleList;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateChatRoomResponse::fromMap($this->doROARequest('CreateChatRoom', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/customers/chatRoom', 'json', $req, $runtime));
    }

    /**
     * @param CreateDepartmentRequest $request
     *
     * @return CreateDepartmentResponse
     */
    public function createDepartment($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDepartmentHeaders([]);

        return $this->createDepartmentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateDepartmentRequest $request
     * @param CreateDepartmentHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return CreateDepartmentResponse
     */
    public function createDepartmentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->authInfo)) {
            @$body['authInfo'] = $request->authInfo;
        }
        if (!Utils::isUnset($request->authType)) {
            @$body['authType'] = $request->authType;
        }
        if (!Utils::isUnset($request->bizExt)) {
            @$body['bizExt'] = $request->bizExt;
        }
        if (!Utils::isUnset($request->departmentName)) {
            @$body['departmentName'] = $request->departmentName;
        }
        if (!Utils::isUnset($request->departmentType)) {
            @$body['departmentType'] = $request->departmentType;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->systemUrl)) {
            @$body['systemUrl'] = $request->systemUrl;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateDepartmentResponse::fromMap($this->doROARequest('CreateDepartment', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/departments', 'json', $req, $runtime));
    }

    /**
     * @param CreateDeviceChatRoomRequest $request
     *
     * @return CreateDeviceChatRoomResponse
     */
    public function createDeviceChatRoom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDeviceChatRoomHeaders([]);

        return $this->createDeviceChatRoomWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateDeviceChatRoomRequest $request
     * @param CreateDeviceChatRoomHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return CreateDeviceChatRoomResponse
     */
    public function createDeviceChatRoomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->chatType)) {
            @$body['chatType'] = $request->chatType;
        }
        if (!Utils::isUnset($request->deviceCodes)) {
            @$body['deviceCodes'] = $request->deviceCodes;
        }
        if (!Utils::isUnset($request->deviceUuids)) {
            @$body['deviceUuids'] = $request->deviceUuids;
        }
        if (!Utils::isUnset($request->ownerUserId)) {
            @$body['ownerUserId'] = $request->ownerUserId;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateDeviceChatRoomResponse::fromMap($this->doROARequest('CreateDeviceChatRoom', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/customers/chatRooms/groups', 'json', $req, $runtime));
    }

    /**
     * @param DeviceDingRequest $request
     *
     * @return DeviceDingResponse
     */
    public function deviceDing($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeviceDingHeaders([]);

        return $this->deviceDingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeviceDingRequest $request
     * @param DeviceDingHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return DeviceDingResponse
     */
    public function deviceDingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceKey)) {
            @$body['deviceKey'] = $request->deviceKey;
        }
        if (!Utils::isUnset($request->paramsJson)) {
            @$body['paramsJson'] = $request->paramsJson;
        }
        if (!Utils::isUnset($request->receiverUserIdList)) {
            @$body['receiverUserIdList'] = $request->receiverUserIdList;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return DeviceDingResponse::fromMap($this->doROARequest('DeviceDing', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/ding', 'json', $req, $runtime));
    }

    /**
     * @param DissolveGroupRequest $request
     *
     * @return DissolveGroupResponse
     */
    public function dissolveGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DissolveGroupHeaders([]);

        return $this->dissolveGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DissolveGroupRequest $request
     * @param DissolveGroupHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return DissolveGroupResponse
     */
    public function dissolveGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return DissolveGroupResponse::fromMap($this->doROARequest('DissolveGroup', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/customers/chatRooms/groups/dissolve', 'json', $req, $runtime));
    }

    /**
     * @param EditDeviceAdminRequest $request
     *
     * @return EditDeviceAdminResponse
     */
    public function editDeviceAdmin($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditDeviceAdminHeaders([]);

        return $this->editDeviceAdminWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EditDeviceAdminRequest $request
     * @param EditDeviceAdminHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return EditDeviceAdminResponse
     */
    public function editDeviceAdminWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceCode)) {
            @$body['deviceCode'] = $request->deviceCode;
        }
        if (!Utils::isUnset($request->roleUuid)) {
            @$body['roleUuid'] = $request->roleUuid;
        }
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return EditDeviceAdminResponse::fromMap($this->doROARequest('EditDeviceAdmin', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/customers/devices/administrators/edit', 'json', $req, $runtime));
    }

    /**
     * @param GetDeviceGroupInfoRequest $request
     *
     * @return GetDeviceGroupInfoResponse
     */
    public function getDeviceGroupInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDeviceGroupInfoHeaders([]);

        return $this->getDeviceGroupInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetDeviceGroupInfoRequest $request
     * @param GetDeviceGroupInfoHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetDeviceGroupInfoResponse
     */
    public function getDeviceGroupInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetDeviceGroupInfoResponse::fromMap($this->doROARequest('GetDeviceGroupInfo', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/customers/chatRooms/groupInfos/query', 'json', $req, $runtime));
    }

    /**
     * @return GetWholeDeviceGroupResponse
     */
    public function getWholeDeviceGroup()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetWholeDeviceGroupHeaders([]);

        return $this->getWholeDeviceGroupWithOptions($headers, $runtime);
    }

    /**
     * @param GetWholeDeviceGroupHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetWholeDeviceGroupResponse
     */
    public function getWholeDeviceGroupWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetWholeDeviceGroupResponse::fromMap($this->doROARequest('GetWholeDeviceGroup', 'devicemng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/devicemng/customers/chatRooms/wholeGroupId', 'json', $req, $runtime));
    }

    /**
     * @param ListActivateDevicesRequest $request
     *
     * @return ListActivateDevicesResponse
     */
    public function listActivateDevices($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListActivateDevicesHeaders([]);

        return $this->listActivateDevicesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListActivateDevicesRequest $request
     * @param ListActivateDevicesHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return ListActivateDevicesResponse
     */
    public function listActivateDevicesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deviceCategory)) {
            @$query['deviceCategory'] = $request->deviceCategory;
        }
        if (!Utils::isUnset($request->deviceCode)) {
            @$query['deviceCode'] = $request->deviceCode;
        }
        if (!Utils::isUnset($request->deviceTypeId)) {
            @$query['deviceTypeId'] = $request->deviceTypeId;
        }
        if (!Utils::isUnset($request->groupId)) {
            @$query['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
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

        return ListActivateDevicesResponse::fromMap($this->doROARequest('ListActivateDevices', 'devicemng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/devicemng/customers/devices/activations/infos', 'json', $req, $runtime));
    }

    /**
     * @param ListInspectInfoRequest $request
     *
     * @return ListInspectInfoResponse
     */
    public function listInspectInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListInspectInfoHeaders([]);

        return $this->listInspectInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListInspectInfoRequest $request
     * @param ListInspectInfoHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ListInspectInfoResponse
     */
    public function listInspectInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceUuid)) {
            @$body['deviceUuid'] = $request->deviceUuid;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->type)) {
            @$body['type'] = $request->type;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ListInspectInfoResponse::fromMap($this->doROARequest('ListInspectInfo', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/customers/devices/inspectInfos/query', 'json', $req, $runtime));
    }

    /**
     * @param ListMaintainInfoRequest $request
     *
     * @return ListMaintainInfoResponse
     */
    public function listMaintainInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListMaintainInfoHeaders([]);

        return $this->listMaintainInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListMaintainInfoRequest $request
     * @param ListMaintainInfoHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ListMaintainInfoResponse
     */
    public function listMaintainInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceUuid)) {
            @$body['deviceUuid'] = $request->deviceUuid;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$body['pageSize'] = $request->pageSize;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ListMaintainInfoResponse::fromMap($this->doROARequest('ListMaintainInfo', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/customers/devices/maintainInfos/query', 'json', $req, $runtime));
    }

    /**
     * @param PullDeviceToGroupRequest $request
     *
     * @return PullDeviceToGroupResponse
     */
    public function pullDeviceToGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PullDeviceToGroupHeaders([]);

        return $this->pullDeviceToGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PullDeviceToGroupRequest $request
     * @param PullDeviceToGroupHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return PullDeviceToGroupResponse
     */
    public function pullDeviceToGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceCodes)) {
            @$body['deviceCodes'] = $request->deviceCodes;
        }
        if (!Utils::isUnset($request->deviceUuids)) {
            @$body['deviceUuids'] = $request->deviceUuids;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->operator)) {
            @$body['operator'] = $request->operator;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return PullDeviceToGroupResponse::fromMap($this->doROARequest('PullDeviceToGroup', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/customers/chatRooms/devices', 'json', $req, $runtime));
    }

    /**
     * @param PullUserToGroupRequest $request
     *
     * @return PullUserToGroupResponse
     */
    public function pullUserToGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PullUserToGroupHeaders([]);

        return $this->pullUserToGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PullUserToGroupRequest $request
     * @param PullUserToGroupHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return PullUserToGroupResponse
     */
    public function pullUserToGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return PullUserToGroupResponse::fromMap($this->doROARequest('PullUserToGroup', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/customers/chatRooms/users', 'json', $req, $runtime));
    }

    /**
     * @param RegisterAndActivateDeviceRequest $request
     *
     * @return RegisterAndActivateDeviceResponse
     */
    public function registerAndActivateDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterAndActivateDeviceHeaders([]);

        return $this->registerAndActivateDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RegisterAndActivateDeviceRequest $request
     * @param RegisterAndActivateDeviceHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return RegisterAndActivateDeviceResponse
     */
    public function registerAndActivateDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceCallbackUrl)) {
            @$body['deviceCallbackUrl'] = $request->deviceCallbackUrl;
        }
        if (!Utils::isUnset($request->deviceCategory)) {
            @$body['deviceCategory'] = $request->deviceCategory;
        }
        if (!Utils::isUnset($request->deviceCode)) {
            @$body['deviceCode'] = $request->deviceCode;
        }
        if (!Utils::isUnset($request->deviceDetailUrl)) {
            @$body['deviceDetailUrl'] = $request->deviceDetailUrl;
        }
        if (!Utils::isUnset($request->deviceName)) {
            @$body['deviceName'] = $request->deviceName;
        }
        if (!Utils::isUnset($request->introduction)) {
            @$body['introduction'] = $request->introduction;
        }
        if (!Utils::isUnset($request->roleUuid)) {
            @$body['roleUuid'] = $request->roleUuid;
        }
        if (!Utils::isUnset($request->typeUuid)) {
            @$body['typeUuid'] = $request->typeUuid;
        }
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RegisterAndActivateDeviceResponse::fromMap($this->doROARequest('RegisterAndActivateDevice', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/customers/devices/registerAndActivate', 'json', $req, $runtime));
    }

    /**
     * @param RegisterAndActivateDeviceBatchRequest $request
     *
     * @return RegisterAndActivateDeviceBatchResponse
     */
    public function registerAndActivateDeviceBatch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterAndActivateDeviceBatchHeaders([]);

        return $this->registerAndActivateDeviceBatchWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RegisterAndActivateDeviceBatchRequest $request
     * @param RegisterAndActivateDeviceBatchHeaders $headers
     * @param RuntimeOptions                        $runtime
     *
     * @return RegisterAndActivateDeviceBatchResponse
     */
    public function registerAndActivateDeviceBatchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->registerAndActivateVOS)) {
            @$body['registerAndActivateVOS'] = $request->registerAndActivateVOS;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RegisterAndActivateDeviceBatchResponse::fromMap($this->doROARequest('RegisterAndActivateDeviceBatch', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/customers/devices/registrationActivations/batch', 'json', $req, $runtime));
    }

    /**
     * @param RegisterDeviceRequest $request
     *
     * @return RegisterDeviceResponse
     */
    public function registerDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterDeviceHeaders([]);

        return $this->registerDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RegisterDeviceRequest $request
     * @param RegisterDeviceHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return RegisterDeviceResponse
     */
    public function registerDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->collaborators)) {
            @$body['collaborators'] = $request->collaborators;
        }
        if (!Utils::isUnset($request->departmentId)) {
            @$body['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->deviceKey)) {
            @$body['deviceKey'] = $request->deviceKey;
        }
        if (!Utils::isUnset($request->deviceName)) {
            @$body['deviceName'] = $request->deviceName;
        }
        if (!Utils::isUnset($request->managers)) {
            @$body['managers'] = $request->managers;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RegisterDeviceResponse::fromMap($this->doROARequest('RegisterDevice', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/devices', 'json', $req, $runtime));
    }

    /**
     * @param RemoveDeviceFromGroupRequest $request
     *
     * @return RemoveDeviceFromGroupResponse
     */
    public function removeDeviceFromGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveDeviceFromGroupHeaders([]);

        return $this->removeDeviceFromGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RemoveDeviceFromGroupRequest $request
     * @param RemoveDeviceFromGroupHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return RemoveDeviceFromGroupResponse
     */
    public function removeDeviceFromGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceCodes)) {
            @$body['deviceCodes'] = $request->deviceCodes;
        }
        if (!Utils::isUnset($request->deviceUuids)) {
            @$body['deviceUuids'] = $request->deviceUuids;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->operator)) {
            @$body['operator'] = $request->operator;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RemoveDeviceFromGroupResponse::fromMap($this->doROARequest('RemoveDeviceFromGroup', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/customers/chatRooms/devices/remove', 'json', $req, $runtime));
    }

    /**
     * @param RemoveUserFromGroupRequest $request
     *
     * @return RemoveUserFromGroupResponse
     */
    public function removeUserFromGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveUserFromGroupHeaders([]);

        return $this->removeUserFromGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RemoveUserFromGroupRequest $request
     * @param RemoveUserFromGroupHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return RemoveUserFromGroupResponse
     */
    public function removeUserFromGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return RemoveUserFromGroupResponse::fromMap($this->doROARequest('RemoveUserFromGroup', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/customers/chatRooms/users/remove', 'json', $req, $runtime));
    }

    /**
     * @param SendCardRequest $request
     *
     * @return SendCardResponse
     */
    public function sendCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendCardHeaders([]);

        return $this->sendCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendCardRequest $request
     * @param SendCardHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return SendCardResponse
     */
    public function sendCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            @$body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->cardData)) {
            @$body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->deviceCode)) {
            @$body['deviceCode'] = $request->deviceCode;
        }
        if (!Utils::isUnset($request->deviceUuid)) {
            @$body['deviceUuid'] = $request->deviceUuid;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->partVisible)) {
            @$body['partVisible'] = $request->partVisible;
        }
        if (!Utils::isUnset($request->receivers)) {
            @$body['receivers'] = $request->receivers;
        }
        if (!Utils::isUnset($request->templateId)) {
            @$body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->topbox)) {
            @$body['topbox'] = $request->topbox;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SendCardResponse::fromMap($this->doROARequest('SendCard', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/customers/cards/send', 'json', $req, $runtime));
    }

    /**
     * @param SendMsgRequest $request
     *
     * @return SendMsgResponse
     */
    public function sendMsg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendMsgHeaders([]);

        return $this->sendMsgWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendMsgRequest $request
     * @param SendMsgHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return SendMsgResponse
     */
    public function sendMsgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->deviceCode)) {
            @$body['deviceCode'] = $request->deviceCode;
        }
        if (!Utils::isUnset($request->deviceUuid)) {
            @$body['deviceUuid'] = $request->deviceUuid;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            @$body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->userList)) {
            @$body['userList'] = $request->userList;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SendMsgResponse::fromMap($this->doROARequest('SendMsg', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/customers/messages/send', 'json', $req, $runtime));
    }

    /**
     * @param UninstallDeviceRobotRequest $request
     *
     * @return UninstallDeviceRobotResponse
     */
    public function uninstallDeviceRobot($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UninstallDeviceRobotHeaders([]);

        return $this->uninstallDeviceRobotWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UninstallDeviceRobotRequest $request
     * @param UninstallDeviceRobotHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return UninstallDeviceRobotResponse
     */
    public function uninstallDeviceRobotWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceCode)) {
            @$body['deviceCode'] = $request->deviceCode;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UninstallDeviceRobotResponse::fromMap($this->doROARequest('UninstallDeviceRobot', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/customers/devices/uninstall', 'json', $req, $runtime));
    }

    /**
     * @param UpdateCardRequest $request
     *
     * @return UpdateCardResponse
     */
    public function updateCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCardHeaders([]);

        return $this->updateCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateCardRequest $request
     * @param UpdateCardHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return UpdateCardResponse
     */
    public function updateCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            @$body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->cardData)) {
            @$body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->tips)) {
            @$body['tips'] = $request->tips;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UpdateCardResponse::fromMap($this->doROARequest('UpdateCard', 'devicemng_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/devicemng/customers/cards', 'json', $req, $runtime));
    }

    /**
     * @param UploadEventRequest $request
     *
     * @return UploadEventResponse
     */
    public function uploadEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UploadEventHeaders([]);

        return $this->uploadEventWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UploadEventRequest $request
     * @param UploadEventHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return UploadEventResponse
     */
    public function uploadEventWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->coverUrl)) {
            @$body['coverUrl'] = $request->coverUrl;
        }
        if (!Utils::isUnset($request->deviceCode)) {
            @$body['deviceCode'] = $request->deviceCode;
        }
        if (!Utils::isUnset($request->deviceUuid)) {
            @$body['deviceUuid'] = $request->deviceUuid;
        }
        if (!Utils::isUnset($request->eventTime)) {
            @$body['eventTime'] = $request->eventTime;
        }
        if (!Utils::isUnset($request->eventType)) {
            @$body['eventType'] = $request->eventType;
        }
        if (!Utils::isUnset($request->level)) {
            @$body['level'] = $request->level;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return UploadEventResponse::fromMap($this->doROARequest('UploadEvent', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/suppliers/events/upload', 'json', $req, $runtime));
    }
}
