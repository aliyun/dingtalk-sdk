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
use Darabonba\GatewayDingTalk\Client;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $gatewayClient = new Client();
        $this->_spi = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 批量注册设备
     *  *
     * @param BatchRegisterDeviceRequest $request BatchRegisterDeviceRequest
     * @param BatchRegisterDeviceHeaders $headers BatchRegisterDeviceHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchRegisterDeviceResponse BatchRegisterDeviceResponse
     */
    public function batchRegisterDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceList)) {
            $body['deviceList'] = $request->deviceList;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'BatchRegisterDevice',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/devices/batch',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return BatchRegisterDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量注册设备
     *  *
     * @param BatchRegisterDeviceRequest $request BatchRegisterDeviceRequest
     *
     * @return BatchRegisterDeviceResponse BatchRegisterDeviceResponse
     */
    public function batchRegisterDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchRegisterDeviceHeaders([]);

        return $this->batchRegisterDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 想设备上钉连接器推送设备事件
     *  *
     * @param ConnectorEventPushRequest $request ConnectorEventPushRequest
     * @param ConnectorEventPushHeaders $headers ConnectorEventPushHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return ConnectorEventPushResponse ConnectorEventPushResponse
     */
    public function connectorEventPushWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceTypeUuid)) {
            $body['deviceTypeUuid'] = $request->deviceTypeUuid;
        }
        if (!Utils::isUnset($request->eventName)) {
            $body['eventName'] = $request->eventName;
        }
        if (!Utils::isUnset($request->input)) {
            $body['input'] = $request->input;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ConnectorEventPush',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/connectors/events/push',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ConnectorEventPushResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 想设备上钉连接器推送设备事件
     *  *
     * @param ConnectorEventPushRequest $request ConnectorEventPushRequest
     *
     * @return ConnectorEventPushResponse ConnectorEventPushResponse
     */
    public function connectorEventPush($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConnectorEventPushHeaders([]);

        return $this->connectorEventPushWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建设备群
     *  *
     * @param CreateChatRoomRequest $request CreateChatRoomRequest
     * @param CreateChatRoomHeaders $headers CreateChatRoomHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateChatRoomResponse CreateChatRoomResponse
     */
    public function createChatRoomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->chatGroupName)) {
            $body['chatGroupName'] = $request->chatGroupName;
        }
        if (!Utils::isUnset($request->deviceCodes)) {
            $body['deviceCodes'] = $request->deviceCodes;
        }
        if (!Utils::isUnset($request->deviceTypeId)) {
            $body['deviceTypeId'] = $request->deviceTypeId;
        }
        if (!Utils::isUnset($request->ownerUserId)) {
            $body['ownerUserId'] = $request->ownerUserId;
        }
        if (!Utils::isUnset($request->roleList)) {
            $body['roleList'] = $request->roleList;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateChatRoom',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/chatRoom',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateChatRoomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建设备群
     *  *
     * @param CreateChatRoomRequest $request CreateChatRoomRequest
     *
     * @return CreateChatRoomResponse CreateChatRoomResponse
     */
    public function createChatRoom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateChatRoomHeaders([]);

        return $this->createChatRoomWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建部门
     *  *
     * @param CreateDepartmentRequest $request CreateDepartmentRequest
     * @param CreateDepartmentHeaders $headers CreateDepartmentHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateDepartmentResponse CreateDepartmentResponse
     */
    public function createDepartmentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->authInfo)) {
            $body['authInfo'] = $request->authInfo;
        }
        if (!Utils::isUnset($request->authType)) {
            $body['authType'] = $request->authType;
        }
        if (!Utils::isUnset($request->bizExt)) {
            $body['bizExt'] = $request->bizExt;
        }
        if (!Utils::isUnset($request->departmentName)) {
            $body['departmentName'] = $request->departmentName;
        }
        if (!Utils::isUnset($request->departmentType)) {
            $body['departmentType'] = $request->departmentType;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->systemUrl)) {
            $body['systemUrl'] = $request->systemUrl;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateDepartment',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/departments',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CreateDepartmentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建部门
     *  *
     * @param CreateDepartmentRequest $request CreateDepartmentRequest
     *
     * @return CreateDepartmentResponse CreateDepartmentResponse
     */
    public function createDepartment($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDepartmentHeaders([]);

        return $this->createDepartmentWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建设备场景群
     *  *
     * @param CreateDeviceChatRoomRequest $request CreateDeviceChatRoomRequest
     * @param CreateDeviceChatRoomHeaders $headers CreateDeviceChatRoomHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateDeviceChatRoomResponse CreateDeviceChatRoomResponse
     */
    public function createDeviceChatRoomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->chatType)) {
            $body['chatType'] = $request->chatType;
        }
        if (!Utils::isUnset($request->deviceCodes)) {
            $body['deviceCodes'] = $request->deviceCodes;
        }
        if (!Utils::isUnset($request->deviceUuids)) {
            $body['deviceUuids'] = $request->deviceUuids;
        }
        if (!Utils::isUnset($request->ownerUserId)) {
            $body['ownerUserId'] = $request->ownerUserId;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateDeviceChatRoom',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/chatRooms/groups',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateDeviceChatRoomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建设备场景群
     *  *
     * @param CreateDeviceChatRoomRequest $request CreateDeviceChatRoomRequest
     *
     * @return CreateDeviceChatRoomResponse CreateDeviceChatRoomResponse
     */
    public function createDeviceChatRoom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDeviceChatRoomHeaders([]);

        return $this->createDeviceChatRoomWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设备账号向目标用户发送ding消息
     *  *
     * @param DeviceDingRequest $request DeviceDingRequest
     * @param DeviceDingHeaders $headers DeviceDingHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return DeviceDingResponse DeviceDingResponse
     */
    public function deviceDingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceKey)) {
            $body['deviceKey'] = $request->deviceKey;
        }
        if (!Utils::isUnset($request->paramsJson)) {
            $body['paramsJson'] = $request->paramsJson;
        }
        if (!Utils::isUnset($request->receiverUserIdList)) {
            $body['receiverUserIdList'] = $request->receiverUserIdList;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DeviceDing',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/ding',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return DeviceDingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设备账号向目标用户发送ding消息
     *  *
     * @param DeviceDingRequest $request DeviceDingRequest
     *
     * @return DeviceDingResponse DeviceDingResponse
     */
    public function deviceDing($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeviceDingHeaders([]);

        return $this->deviceDingWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 解散设备群
     *  *
     * @param DissolveGroupRequest $request DissolveGroupRequest
     * @param DissolveGroupHeaders $headers DissolveGroupHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return DissolveGroupResponse DissolveGroupResponse
     */
    public function dissolveGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'DissolveGroup',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/chatRooms/groups/dissolve',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DissolveGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 解散设备群
     *  *
     * @param DissolveGroupRequest $request DissolveGroupRequest
     *
     * @return DissolveGroupResponse DissolveGroupResponse
     */
    public function dissolveGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DissolveGroupHeaders([]);

        return $this->dissolveGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑设备管理员
     *  *
     * @param EditDeviceAdminRequest $request EditDeviceAdminRequest
     * @param EditDeviceAdminHeaders $headers EditDeviceAdminHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return EditDeviceAdminResponse EditDeviceAdminResponse
     */
    public function editDeviceAdminWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceCode)) {
            $body['deviceCode'] = $request->deviceCode;
        }
        if (!Utils::isUnset($request->roleUuid)) {
            $body['roleUuid'] = $request->roleUuid;
        }
        if (!Utils::isUnset($request->userIds)) {
            $body['userIds'] = $request->userIds;
        }
        if (!Utils::isUnset($request->uuid)) {
            $body['uuid'] = $request->uuid;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'EditDeviceAdmin',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/devices/administrators/edit',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return EditDeviceAdminResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑设备管理员
     *  *
     * @param EditDeviceAdminRequest $request EditDeviceAdminRequest
     *
     * @return EditDeviceAdminResponse EditDeviceAdminResponse
     */
    public function editDeviceAdmin($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditDeviceAdminHeaders([]);

        return $this->editDeviceAdminWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取设备群信息
     *  *
     * @param GetDeviceGroupInfoRequest $request GetDeviceGroupInfoRequest
     * @param GetDeviceGroupInfoHeaders $headers GetDeviceGroupInfoHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDeviceGroupInfoResponse GetDeviceGroupInfoResponse
     */
    public function getDeviceGroupInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetDeviceGroupInfo',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/chatRooms/groupInfos/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetDeviceGroupInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取设备群信息
     *  *
     * @param GetDeviceGroupInfoRequest $request GetDeviceGroupInfoRequest
     *
     * @return GetDeviceGroupInfoResponse GetDeviceGroupInfoResponse
     */
    public function getDeviceGroupInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDeviceGroupInfoHeaders([]);

        return $this->getDeviceGroupInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取设备全员群标识
     *  *
     * @param GetWholeDeviceGroupHeaders $headers GetWholeDeviceGroupHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetWholeDeviceGroupResponse GetWholeDeviceGroupResponse
     */
    public function getWholeDeviceGroupWithOptions($headers, $runtime)
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
            'action' => 'GetWholeDeviceGroup',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/chatRooms/wholeGroupId',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetWholeDeviceGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取设备全员群标识
     *  *
     * @return GetWholeDeviceGroupResponse GetWholeDeviceGroupResponse
     */
    public function getWholeDeviceGroup()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetWholeDeviceGroupHeaders([]);

        return $this->getWholeDeviceGroupWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询激活的设备信息
     *  *
     * @param ListActivateDevicesRequest $request ListActivateDevicesRequest
     * @param ListActivateDevicesHeaders $headers ListActivateDevicesHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return ListActivateDevicesResponse ListActivateDevicesResponse
     */
    public function listActivateDevicesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deviceCategory)) {
            $query['deviceCategory'] = $request->deviceCategory;
        }
        if (!Utils::isUnset($request->deviceCode)) {
            $query['deviceCode'] = $request->deviceCode;
        }
        if (!Utils::isUnset($request->deviceTypeId)) {
            $query['deviceTypeId'] = $request->deviceTypeId;
        }
        if (!Utils::isUnset($request->groupId)) {
            $query['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ListActivateDevices',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/devices/activations/infos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListActivateDevicesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询激活的设备信息
     *  *
     * @param ListActivateDevicesRequest $request ListActivateDevicesRequest
     *
     * @return ListActivateDevicesResponse ListActivateDevicesResponse
     */
    public function listActivateDevices($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListActivateDevicesHeaders([]);

        return $this->listActivateDevicesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取巡检、保养记录
     *  *
     * @param ListInspectInfoRequest $request ListInspectInfoRequest
     * @param ListInspectInfoHeaders $headers ListInspectInfoHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ListInspectInfoResponse ListInspectInfoResponse
     */
    public function listInspectInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceUuid)) {
            $body['deviceUuid'] = $request->deviceUuid;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ListInspectInfo',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/devices/inspectInfos/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListInspectInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取巡检、保养记录
     *  *
     * @param ListInspectInfoRequest $request ListInspectInfoRequest
     *
     * @return ListInspectInfoResponse ListInspectInfoResponse
     */
    public function listInspectInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListInspectInfoHeaders([]);

        return $this->listInspectInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取报修信息
     *  *
     * @param ListMaintainInfoRequest $request ListMaintainInfoRequest
     * @param ListMaintainInfoHeaders $headers ListMaintainInfoHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return ListMaintainInfoResponse ListMaintainInfoResponse
     */
    public function listMaintainInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceUuid)) {
            $body['deviceUuid'] = $request->deviceUuid;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'ListMaintainInfo',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/devices/maintainInfos/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListMaintainInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取报修信息
     *  *
     * @param ListMaintainInfoRequest $request ListMaintainInfoRequest
     *
     * @return ListMaintainInfoResponse ListMaintainInfoResponse
     */
    public function listMaintainInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListMaintainInfoHeaders([]);

        return $this->listMaintainInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 拉设备进群
     *  *
     * @param PullDeviceToGroupRequest $request PullDeviceToGroupRequest
     * @param PullDeviceToGroupHeaders $headers PullDeviceToGroupHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return PullDeviceToGroupResponse PullDeviceToGroupResponse
     */
    public function pullDeviceToGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceCodes)) {
            $body['deviceCodes'] = $request->deviceCodes;
        }
        if (!Utils::isUnset($request->deviceUuids)) {
            $body['deviceUuids'] = $request->deviceUuids;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PullDeviceToGroup',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/chatRooms/devices',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PullDeviceToGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 拉设备进群
     *  *
     * @param PullDeviceToGroupRequest $request PullDeviceToGroupRequest
     *
     * @return PullDeviceToGroupResponse PullDeviceToGroupResponse
     */
    public function pullDeviceToGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PullDeviceToGroupHeaders([]);

        return $this->pullDeviceToGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 拉设用户进群
     *  *
     * @param PullUserToGroupRequest $request PullUserToGroupRequest
     * @param PullUserToGroupHeaders $headers PullUserToGroupHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return PullUserToGroupResponse PullUserToGroupResponse
     */
    public function pullUserToGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'PullUserToGroup',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/chatRooms/users',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PullUserToGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 拉设用户进群
     *  *
     * @param PullUserToGroupRequest $request PullUserToGroupRequest
     *
     * @return PullUserToGroupResponse PullUserToGroupResponse
     */
    public function pullUserToGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PullUserToGroupHeaders([]);

        return $this->pullUserToGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 注册与激活设备
     *  *
     * @param RegisterAndActivateDeviceRequest $request RegisterAndActivateDeviceRequest
     * @param RegisterAndActivateDeviceHeaders $headers RegisterAndActivateDeviceHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return RegisterAndActivateDeviceResponse RegisterAndActivateDeviceResponse
     */
    public function registerAndActivateDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceCallbackUrl)) {
            $body['deviceCallbackUrl'] = $request->deviceCallbackUrl;
        }
        if (!Utils::isUnset($request->deviceCategory)) {
            $body['deviceCategory'] = $request->deviceCategory;
        }
        if (!Utils::isUnset($request->deviceCode)) {
            $body['deviceCode'] = $request->deviceCode;
        }
        if (!Utils::isUnset($request->deviceDetailUrl)) {
            $body['deviceDetailUrl'] = $request->deviceDetailUrl;
        }
        if (!Utils::isUnset($request->deviceName)) {
            $body['deviceName'] = $request->deviceName;
        }
        if (!Utils::isUnset($request->introduction)) {
            $body['introduction'] = $request->introduction;
        }
        if (!Utils::isUnset($request->roleUuid)) {
            $body['roleUuid'] = $request->roleUuid;
        }
        if (!Utils::isUnset($request->typeUuid)) {
            $body['typeUuid'] = $request->typeUuid;
        }
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'RegisterAndActivateDevice',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/devices/registerAndActivate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RegisterAndActivateDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 注册与激活设备
     *  *
     * @param RegisterAndActivateDeviceRequest $request RegisterAndActivateDeviceRequest
     *
     * @return RegisterAndActivateDeviceResponse RegisterAndActivateDeviceResponse
     */
    public function registerAndActivateDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterAndActivateDeviceHeaders([]);

        return $this->registerAndActivateDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量注册与激活设备
     *  *
     * @param RegisterAndActivateDeviceBatchRequest $request RegisterAndActivateDeviceBatchRequest
     * @param RegisterAndActivateDeviceBatchHeaders $headers RegisterAndActivateDeviceBatchHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return RegisterAndActivateDeviceBatchResponse RegisterAndActivateDeviceBatchResponse
     */
    public function registerAndActivateDeviceBatchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->registerAndActivateVOS)) {
            $body['registerAndActivateVOS'] = $request->registerAndActivateVOS;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'RegisterAndActivateDeviceBatch',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/devices/registrationActivations/batch',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RegisterAndActivateDeviceBatchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量注册与激活设备
     *  *
     * @param RegisterAndActivateDeviceBatchRequest $request RegisterAndActivateDeviceBatchRequest
     *
     * @return RegisterAndActivateDeviceBatchResponse RegisterAndActivateDeviceBatchResponse
     */
    public function registerAndActivateDeviceBatch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterAndActivateDeviceBatchHeaders([]);

        return $this->registerAndActivateDeviceBatchWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 注册设备并为其创建机器人
     *  *
     * @param RegisterDeviceRequest $request RegisterDeviceRequest
     * @param RegisterDeviceHeaders $headers RegisterDeviceHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return RegisterDeviceResponse RegisterDeviceResponse
     */
    public function registerDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->collaborators)) {
            $body['collaborators'] = $request->collaborators;
        }
        if (!Utils::isUnset($request->departmentId)) {
            $body['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->deviceKey)) {
            $body['deviceKey'] = $request->deviceKey;
        }
        if (!Utils::isUnset($request->deviceName)) {
            $body['deviceName'] = $request->deviceName;
        }
        if (!Utils::isUnset($request->managers)) {
            $body['managers'] = $request->managers;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'RegisterDevice',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/devices',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return RegisterDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 注册设备并为其创建机器人
     *  *
     * @param RegisterDeviceRequest $request RegisterDeviceRequest
     *
     * @return RegisterDeviceResponse RegisterDeviceResponse
     */
    public function registerDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterDeviceHeaders([]);

        return $this->registerDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 移设备出群
     *  *
     * @param RemoveDeviceFromGroupRequest $request RemoveDeviceFromGroupRequest
     * @param RemoveDeviceFromGroupHeaders $headers RemoveDeviceFromGroupHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return RemoveDeviceFromGroupResponse RemoveDeviceFromGroupResponse
     */
    public function removeDeviceFromGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceCodes)) {
            $body['deviceCodes'] = $request->deviceCodes;
        }
        if (!Utils::isUnset($request->deviceUuids)) {
            $body['deviceUuids'] = $request->deviceUuids;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'RemoveDeviceFromGroup',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/chatRooms/devices/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RemoveDeviceFromGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 移设备出群
     *  *
     * @param RemoveDeviceFromGroupRequest $request RemoveDeviceFromGroupRequest
     *
     * @return RemoveDeviceFromGroupResponse RemoveDeviceFromGroupResponse
     */
    public function removeDeviceFromGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveDeviceFromGroupHeaders([]);

        return $this->removeDeviceFromGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 移用户出设备群
     *  *
     * @param RemoveUserFromGroupRequest $request RemoveUserFromGroupRequest
     * @param RemoveUserFromGroupHeaders $headers RemoveUserFromGroupHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return RemoveUserFromGroupResponse RemoveUserFromGroupResponse
     */
    public function removeUserFromGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'RemoveUserFromGroup',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/chatRooms/users/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RemoveUserFromGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 移用户出设备群
     *  *
     * @param RemoveUserFromGroupRequest $request RemoveUserFromGroupRequest
     *
     * @return RemoveUserFromGroupResponse RemoveUserFromGroupResponse
     */
    public function removeUserFromGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveUserFromGroupHeaders([]);

        return $this->removeUserFromGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送卡片
     *  *
     * @param SendCardRequest $request SendCardRequest
     * @param SendCardHeaders $headers SendCardHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return SendCardResponse SendCardResponse
     */
    public function sendCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->deviceCode)) {
            $body['deviceCode'] = $request->deviceCode;
        }
        if (!Utils::isUnset($request->deviceUuid)) {
            $body['deviceUuid'] = $request->deviceUuid;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->partVisible)) {
            $body['partVisible'] = $request->partVisible;
        }
        if (!Utils::isUnset($request->receivers)) {
            $body['receivers'] = $request->receivers;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->topbox)) {
            $body['topbox'] = $request->topbox;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SendCard',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/cards/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送卡片
     *  *
     * @param SendCardRequest $request SendCardRequest
     *
     * @return SendCardResponse SendCardResponse
     */
    public function sendCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendCardHeaders([]);

        return $this->sendCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送普通消息
     *  *
     * @param SendMsgRequest $request SendMsgRequest
     * @param SendMsgHeaders $headers SendMsgHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return SendMsgResponse SendMsgResponse
     */
    public function sendMsgWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->deviceCode)) {
            $body['deviceCode'] = $request->deviceCode;
        }
        if (!Utils::isUnset($request->deviceUuid)) {
            $body['deviceUuid'] = $request->deviceUuid;
        }
        if (!Utils::isUnset($request->openConversationId)) {
            $body['openConversationId'] = $request->openConversationId;
        }
        if (!Utils::isUnset($request->userList)) {
            $body['userList'] = $request->userList;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SendMsg',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/messages/send',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendMsgResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送普通消息
     *  *
     * @param SendMsgRequest $request SendMsgRequest
     *
     * @return SendMsgResponse SendMsgResponse
     */
    public function sendMsg($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendMsgHeaders([]);

        return $this->sendMsgWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 卸载设备
     *  *
     * @param UninstallDeviceRobotRequest $request UninstallDeviceRobotRequest
     * @param UninstallDeviceRobotHeaders $headers UninstallDeviceRobotHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return UninstallDeviceRobotResponse UninstallDeviceRobotResponse
     */
    public function uninstallDeviceRobotWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceCode)) {
            $body['deviceCode'] = $request->deviceCode;
        }
        if (!Utils::isUnset($request->uuid)) {
            $body['uuid'] = $request->uuid;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UninstallDeviceRobot',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/devices/uninstall',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UninstallDeviceRobotResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 卸载设备
     *  *
     * @param UninstallDeviceRobotRequest $request UninstallDeviceRobotRequest
     *
     * @return UninstallDeviceRobotResponse UninstallDeviceRobotResponse
     */
    public function uninstallDeviceRobot($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UninstallDeviceRobotHeaders([]);

        return $this->uninstallDeviceRobotWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新卡片
     *  *
     * @param UpdateCardRequest $request UpdateCardRequest
     * @param UpdateCardHeaders $headers UpdateCardHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateCardResponse UpdateCardResponse
     */
    public function updateCardWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->cardData)) {
            $body['cardData'] = $request->cardData;
        }
        if (!Utils::isUnset($request->tips)) {
            $body['tips'] = $request->tips;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateCard',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/customers/cards',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateCardResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新卡片
     *  *
     * @param UpdateCardRequest $request UpdateCardRequest
     *
     * @return UpdateCardResponse UpdateCardResponse
     */
    public function updateCard($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateCardHeaders([]);

        return $this->updateCardWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设备事件上报
     *  *
     * @param UploadEventRequest $request UploadEventRequest
     * @param UploadEventHeaders $headers UploadEventHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return UploadEventResponse UploadEventResponse
     */
    public function uploadEventWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->coverUrl)) {
            $body['coverUrl'] = $request->coverUrl;
        }
        if (!Utils::isUnset($request->deviceCode)) {
            $body['deviceCode'] = $request->deviceCode;
        }
        if (!Utils::isUnset($request->deviceUuid)) {
            $body['deviceUuid'] = $request->deviceUuid;
        }
        if (!Utils::isUnset($request->eventTime)) {
            $body['eventTime'] = $request->eventTime;
        }
        if (!Utils::isUnset($request->eventType)) {
            $body['eventType'] = $request->eventType;
        }
        if (!Utils::isUnset($request->level)) {
            $body['level'] = $request->level;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UploadEvent',
            'version' => 'devicemng_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/devicemng/suppliers/events/upload',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UploadEventResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设备事件上报
     *  *
     * @param UploadEventRequest $request UploadEventRequest
     *
     * @return UploadEventResponse UploadEventResponse
     */
    public function uploadEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UploadEventHeaders([]);

        return $this->uploadEventWithOptions($request, $headers, $runtime);
    }
}
