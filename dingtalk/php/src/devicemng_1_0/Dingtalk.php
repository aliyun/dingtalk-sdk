<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\BatchRegisterDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\BatchRegisterDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\BatchRegisterDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateChatRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateChatRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateChatRoomResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateDepartmentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateDepartmentRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateDepartmentResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\DeviceDingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\DeviceDingRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\DeviceDingResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListActivateDevicesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListActivateDevicesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\ListActivateDevicesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterAndActivateDeviceBatchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterAndActivateDeviceBatchRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterAndActivateDeviceBatchResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterAndActivateDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterAndActivateDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterAndActivateDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\SendCardHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\SendCardRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\SendCardResponse;
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
        if (!Utils::isUnset($request->encodeCid)) {
            @$body['encodeCid'] = $request->encodeCid;
        }
        if (!Utils::isUnset($request->templateId)) {
            @$body['templateId'] = $request->templateId;
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
