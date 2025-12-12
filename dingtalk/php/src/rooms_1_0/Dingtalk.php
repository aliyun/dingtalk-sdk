<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateBookingBlacklistHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateBookingBlacklistRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateBookingBlacklistResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateDeviceCustomTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateDeviceCustomTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateDeviceCustomTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomControlPanelHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomControlPanelRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomControlPanelResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteBookingBlacklistHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteBookingBlacklistRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteBookingBlacklistResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteDeviceCustomTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteDeviceCustomTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteDeviceCustomTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomControlPanelHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomControlPanelRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomControlPanelResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\DeleteMeetingRoomResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceCustomTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceCustomTemplateListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceCustomTemplateListResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceCustomTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceIpByCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceIpByCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceIpByCodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDevicePropertiesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDevicePropertiesRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDevicePropertiesResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomControlPanelListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomControlPanelListRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomControlPanelListResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomGroupListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomGroupListRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomGroupListResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomListRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomListResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\RemoveSuperUserMeetingRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\RemoveSuperUserMeetingRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\RemoveSuperUserMeetingRoomResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\SendCentralControlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\SendCentralControlRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\SendCentralControlResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\SetSuperUserMeetingRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\SetSuperUserMeetingRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\SetSuperUserMeetingRoomResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateDeviceCustomTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateDeviceCustomTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateDeviceCustomTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomGroupHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomGroupRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomGroupResponse;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomRequest;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomResponse;
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
     * @summary 创建会议室预定黑名单
     *  *
     * @param CreateBookingBlacklistRequest $request CreateBookingBlacklistRequest
     * @param CreateBookingBlacklistHeaders $headers CreateBookingBlacklistHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateBookingBlacklistResponse CreateBookingBlacklistResponse
     */
    public function createBookingBlacklistWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->blacklistUnionId)) {
            $body['blacklistUnionId'] = $request->blacklistUnionId;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->memo)) {
            $body['memo'] = $request->memo;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action' => 'CreateBookingBlacklist',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/bookings/blacklist',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateBookingBlacklistResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建会议室预定黑名单
     *  *
     * @param CreateBookingBlacklistRequest $request CreateBookingBlacklistRequest
     *
     * @return CreateBookingBlacklistResponse CreateBookingBlacklistResponse
     */
    public function createBookingBlacklist($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateBookingBlacklistHeaders([]);

        return $this->createBookingBlacklistWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建自定义屏幕模版
     *  *
     * @param CreateDeviceCustomTemplateRequest $request CreateDeviceCustomTemplateRequest
     * @param CreateDeviceCustomTemplateHeaders $headers CreateDeviceCustomTemplateHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateDeviceCustomTemplateResponse CreateDeviceCustomTemplateResponse
     */
    public function createDeviceCustomTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bgImgList)) {
            $body['bgImgList'] = $request->bgImgList;
        }
        if (!Utils::isUnset($request->bgType)) {
            $body['bgType'] = $request->bgType;
        }
        if (!Utils::isUnset($request->bgUrl)) {
            $body['bgUrl'] = $request->bgUrl;
        }
        if (!Utils::isUnset($request->customDoc)) {
            $body['customDoc'] = $request->customDoc;
        }
        if (!Utils::isUnset($request->desensitizeUserName)) {
            $body['desensitizeUserName'] = $request->desensitizeUserName;
        }
        if (!Utils::isUnset($request->deviceUnionIds)) {
            $body['deviceUnionIds'] = $request->deviceUnionIds;
        }
        if (!Utils::isUnset($request->groupIds)) {
            $body['groupIds'] = $request->groupIds;
        }
        if (!Utils::isUnset($request->hideServerCodeWhenProjecting)) {
            $body['hideServerCodeWhenProjecting'] = $request->hideServerCodeWhenProjecting;
        }
        if (!Utils::isUnset($request->instruction)) {
            $body['instruction'] = $request->instruction;
        }
        if (!Utils::isUnset($request->isPicTop)) {
            $body['isPicTop'] = $request->isPicTop;
        }
        if (!Utils::isUnset($request->logo)) {
            $body['logo'] = $request->logo;
        }
        if (!Utils::isUnset($request->orgName)) {
            $body['orgName'] = $request->orgName;
        }
        if (!Utils::isUnset($request->picturePlayInterval)) {
            $body['picturePlayInterval'] = $request->picturePlayInterval;
        }
        if (!Utils::isUnset($request->roomIds)) {
            $body['roomIds'] = $request->roomIds;
        }
        if (!Utils::isUnset($request->showCalendarCard)) {
            $body['showCalendarCard'] = $request->showCalendarCard;
        }
        if (!Utils::isUnset($request->showCalendarTitle)) {
            $body['showCalendarTitle'] = $request->showCalendarTitle;
        }
        if (!Utils::isUnset($request->showFunctionCard)) {
            $body['showFunctionCard'] = $request->showFunctionCard;
        }
        if (!Utils::isUnset($request->templateName)) {
            $body['templateName'] = $request->templateName;
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
            'action' => 'CreateDeviceCustomTemplate',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/devices/screens/templates',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateDeviceCustomTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建自定义屏幕模版
     *  *
     * @param CreateDeviceCustomTemplateRequest $request CreateDeviceCustomTemplateRequest
     *
     * @return CreateDeviceCustomTemplateResponse CreateDeviceCustomTemplateResponse
     */
    public function createDeviceCustomTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDeviceCustomTemplateHeaders([]);

        return $this->createDeviceCustomTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建智能会议室
     *  *
     * @param CreateMeetingRoomRequest $request CreateMeetingRoomRequest
     * @param CreateMeetingRoomHeaders $headers CreateMeetingRoomHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateMeetingRoomResponse CreateMeetingRoomResponse
     */
    public function createMeetingRoomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->enableCycleReservation)) {
            $body['enableCycleReservation'] = $request->enableCycleReservation;
        }
        if (!Utils::isUnset($request->groupId)) {
            $body['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->isvRoomId)) {
            $body['isvRoomId'] = $request->isvRoomId;
        }
        if (!Utils::isUnset($request->openReservation)) {
            $body['openReservation'] = $request->openReservation;
        }
        if (!Utils::isUnset($request->reservationAuthority)) {
            $body['reservationAuthority'] = $request->reservationAuthority;
        }
        if (!Utils::isUnset($request->roomCapacity)) {
            $body['roomCapacity'] = $request->roomCapacity;
        }
        if (!Utils::isUnset($request->roomDescription)) {
            $body['roomDescription'] = $request->roomDescription;
        }
        if (!Utils::isUnset($request->roomLabelIds)) {
            $body['roomLabelIds'] = $request->roomLabelIds;
        }
        if (!Utils::isUnset($request->roomLocation)) {
            $body['roomLocation'] = $request->roomLocation;
        }
        if (!Utils::isUnset($request->roomName)) {
            $body['roomName'] = $request->roomName;
        }
        if (!Utils::isUnset($request->roomPicture)) {
            $body['roomPicture'] = $request->roomPicture;
        }
        if (!Utils::isUnset($request->roomStatus)) {
            $body['roomStatus'] = $request->roomStatus;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action' => 'CreateMeetingRoom',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/meetingrooms',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateMeetingRoomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建智能会议室
     *  *
     * @param CreateMeetingRoomRequest $request CreateMeetingRoomRequest
     *
     * @return CreateMeetingRoomResponse CreateMeetingRoomResponse
     */
    public function createMeetingRoom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateMeetingRoomHeaders([]);

        return $this->createMeetingRoomWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建智能会议室IOT配置
     *  *
     * @param CreateMeetingRoomControlPanelRequest $request CreateMeetingRoomControlPanelRequest
     * @param CreateMeetingRoomControlPanelHeaders $headers CreateMeetingRoomControlPanelHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateMeetingRoomControlPanelResponse CreateMeetingRoomControlPanelResponse
     */
    public function createMeetingRoomControlPanelWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->extra)) {
            $body['extra'] = $request->extra;
        }
        if (!Utils::isUnset($request->roomConfig)) {
            $body['roomConfig'] = $request->roomConfig;
        }
        if (!Utils::isUnset($request->roomId)) {
            $body['roomId'] = $request->roomId;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action' => 'CreateMeetingRoomControlPanel',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/panels',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateMeetingRoomControlPanelResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建智能会议室IOT配置
     *  *
     * @param CreateMeetingRoomControlPanelRequest $request CreateMeetingRoomControlPanelRequest
     *
     * @return CreateMeetingRoomControlPanelResponse CreateMeetingRoomControlPanelResponse
     */
    public function createMeetingRoomControlPanel($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateMeetingRoomControlPanelHeaders([]);

        return $this->createMeetingRoomControlPanelWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建会议室分组
     *  *
     * @param CreateMeetingRoomGroupRequest $request CreateMeetingRoomGroupRequest
     * @param CreateMeetingRoomGroupHeaders $headers CreateMeetingRoomGroupHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateMeetingRoomGroupResponse CreateMeetingRoomGroupResponse
     */
    public function createMeetingRoomGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->parentGroupId)) {
            $body['parentGroupId'] = $request->parentGroupId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action' => 'CreateMeetingRoomGroup',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/groups',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateMeetingRoomGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建会议室分组
     *  *
     * @param CreateMeetingRoomGroupRequest $request CreateMeetingRoomGroupRequest
     *
     * @return CreateMeetingRoomGroupResponse CreateMeetingRoomGroupResponse
     */
    public function createMeetingRoomGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateMeetingRoomGroupHeaders([]);

        return $this->createMeetingRoomGroupWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除会议室预定黑名单
     *  *
     * @param DeleteBookingBlacklistRequest $request DeleteBookingBlacklistRequest
     * @param DeleteBookingBlacklistHeaders $headers DeleteBookingBlacklistHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteBookingBlacklistResponse DeleteBookingBlacklistResponse
     */
    public function deleteBookingBlacklistWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->blacklistUnionIds)) {
            $body['blacklistUnionIds'] = $request->blacklistUnionIds;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action' => 'DeleteBookingBlacklist',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/bookings/blacklist/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteBookingBlacklistResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除会议室预定黑名单
     *  *
     * @param DeleteBookingBlacklistRequest $request DeleteBookingBlacklistRequest
     *
     * @return DeleteBookingBlacklistResponse DeleteBookingBlacklistResponse
     */
    public function deleteBookingBlacklist($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteBookingBlacklistHeaders([]);

        return $this->deleteBookingBlacklistWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除自定义屏幕模板
     *  *
     * @param DeleteDeviceCustomTemplateRequest $request DeleteDeviceCustomTemplateRequest
     * @param DeleteDeviceCustomTemplateHeaders $headers DeleteDeviceCustomTemplateHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteDeviceCustomTemplateResponse DeleteDeviceCustomTemplateResponse
     */
    public function deleteDeviceCustomTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
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
            'action' => 'DeleteDeviceCustomTemplate',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/devices/screens/templates/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteDeviceCustomTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除自定义屏幕模板
     *  *
     * @param DeleteDeviceCustomTemplateRequest $request DeleteDeviceCustomTemplateRequest
     *
     * @return DeleteDeviceCustomTemplateResponse DeleteDeviceCustomTemplateResponse
     */
    public function deleteDeviceCustomTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteDeviceCustomTemplateHeaders([]);

        return $this->deleteDeviceCustomTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除会议室
     *  *
     * @param string                   $roomId
     * @param DeleteMeetingRoomRequest $request DeleteMeetingRoomRequest
     * @param DeleteMeetingRoomHeaders $headers DeleteMeetingRoomHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteMeetingRoomResponse DeleteMeetingRoomResponse
     */
    public function deleteMeetingRoomWithOptions($roomId, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteMeetingRoom',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/meetingRooms/' . $roomId . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteMeetingRoomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除会议室
     *  *
     * @param string                   $roomId
     * @param DeleteMeetingRoomRequest $request DeleteMeetingRoomRequest
     *
     * @return DeleteMeetingRoomResponse DeleteMeetingRoomResponse
     */
    public function deleteMeetingRoom($roomId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteMeetingRoomHeaders([]);

        return $this->deleteMeetingRoomWithOptions($roomId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除会议室配置
     *  *
     * @param DeleteMeetingRoomControlPanelRequest $request DeleteMeetingRoomControlPanelRequest
     * @param DeleteMeetingRoomControlPanelHeaders $headers DeleteMeetingRoomControlPanelHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteMeetingRoomControlPanelResponse DeleteMeetingRoomControlPanelResponse
     */
    public function deleteMeetingRoomControlPanelWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->roomIds)) {
            $body['roomIds'] = $request->roomIds;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action' => 'DeleteMeetingRoomControlPanel',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/panels/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteMeetingRoomControlPanelResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除会议室配置
     *  *
     * @param DeleteMeetingRoomControlPanelRequest $request DeleteMeetingRoomControlPanelRequest
     *
     * @return DeleteMeetingRoomControlPanelResponse DeleteMeetingRoomControlPanelResponse
     */
    public function deleteMeetingRoomControlPanel($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteMeetingRoomControlPanelHeaders([]);

        return $this->deleteMeetingRoomControlPanelWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除会议室分组
     *  *
     * @param string                        $groupId
     * @param DeleteMeetingRoomGroupRequest $request DeleteMeetingRoomGroupRequest
     * @param DeleteMeetingRoomGroupHeaders $headers DeleteMeetingRoomGroupHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteMeetingRoomGroupResponse DeleteMeetingRoomGroupResponse
     */
    public function deleteMeetingRoomGroupWithOptions($groupId, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'DeleteMeetingRoomGroup',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/groups/' . $groupId . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteMeetingRoomGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除会议室分组
     *  *
     * @param string                        $groupId
     * @param DeleteMeetingRoomGroupRequest $request DeleteMeetingRoomGroupRequest
     *
     * @return DeleteMeetingRoomGroupResponse DeleteMeetingRoomGroupResponse
     */
    public function deleteMeetingRoomGroup($groupId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteMeetingRoomGroupHeaders([]);

        return $this->deleteMeetingRoomGroupWithOptions($groupId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询自定义屏幕模板
     *  *
     * @param string                           $templateId
     * @param QueryDeviceCustomTemplateHeaders $headers    QueryDeviceCustomTemplateHeaders
     * @param RuntimeOptions                   $runtime    runtime options for this request RuntimeOptions
     *
     * @return QueryDeviceCustomTemplateResponse QueryDeviceCustomTemplateResponse
     */
    public function queryDeviceCustomTemplateWithOptions($templateId, $headers, $runtime)
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
            'action' => 'QueryDeviceCustomTemplate',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/devices/screens/templates/' . $templateId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryDeviceCustomTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询自定义屏幕模板
     *  *
     * @param string $templateId
     *
     * @return QueryDeviceCustomTemplateResponse QueryDeviceCustomTemplateResponse
     */
    public function queryDeviceCustomTemplate($templateId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceCustomTemplateHeaders([]);

        return $this->queryDeviceCustomTemplateWithOptions($templateId, $headers, $runtime);
    }

    /**
     * @summary 查询自定义屏幕模板列表
     *  *
     * @param QueryDeviceCustomTemplateListHeaders $headers QueryDeviceCustomTemplateListHeaders
     * @param RuntimeOptions                       $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDeviceCustomTemplateListResponse QueryDeviceCustomTemplateListResponse
     */
    public function queryDeviceCustomTemplateListWithOptions($headers, $runtime)
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
            'action' => 'QueryDeviceCustomTemplateList',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/devices/screens/templateLists',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryDeviceCustomTemplateListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询自定义屏幕模板列表
     *  *
     * @return QueryDeviceCustomTemplateListResponse QueryDeviceCustomTemplateListResponse
     */
    public function queryDeviceCustomTemplateList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceCustomTemplateListHeaders([]);

        return $this->queryDeviceCustomTemplateListWithOptions($headers, $runtime);
    }

    /**
     * @summary 根据设备投屏码查询设备ip
     *  *
     * @param string                     $shareCode
     * @param QueryDeviceIpByCodeRequest $request   QueryDeviceIpByCodeRequest
     * @param QueryDeviceIpByCodeHeaders $headers   QueryDeviceIpByCodeHeaders
     * @param RuntimeOptions             $runtime   runtime options for this request RuntimeOptions
     *
     * @return QueryDeviceIpByCodeResponse QueryDeviceIpByCodeResponse
     */
    public function queryDeviceIpByCodeWithOptions($shareCode, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deviceSn)) {
            $query['deviceSn'] = $request->deviceSn;
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
            'action' => 'QueryDeviceIpByCode',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/devices/shareCodes/' . $shareCode . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryDeviceIpByCodeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据设备投屏码查询设备ip
     *  *
     * @param string                     $shareCode
     * @param QueryDeviceIpByCodeRequest $request   QueryDeviceIpByCodeRequest
     *
     * @return QueryDeviceIpByCodeResponse QueryDeviceIpByCodeResponse
     */
    public function queryDeviceIpByCode($shareCode, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceIpByCodeHeaders([]);

        return $this->queryDeviceIpByCodeWithOptions($shareCode, $request, $headers, $runtime);
    }

    /**
     * @summary 查询设备属性
     *  *
     * @param QueryDevicePropertiesRequest $request QueryDevicePropertiesRequest
     * @param QueryDevicePropertiesHeaders $headers QueryDevicePropertiesHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDevicePropertiesResponse QueryDevicePropertiesResponse
     */
    public function queryDevicePropertiesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deviceId)) {
            $query['deviceId'] = $request->deviceId;
        }
        if (!Utils::isUnset($request->deviceUnionId)) {
            $query['deviceUnionId'] = $request->deviceUnionId;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            $query['operatorUnionId'] = $request->operatorUnionId;
        }
        $body = [];
        if (!Utils::isUnset($request->propertyNames)) {
            $body['propertyNames'] = $request->propertyNames;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryDeviceProperties',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/devices/properties/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryDevicePropertiesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询设备属性
     *  *
     * @param QueryDevicePropertiesRequest $request QueryDevicePropertiesRequest
     *
     * @return QueryDevicePropertiesResponse QueryDevicePropertiesResponse
     */
    public function queryDeviceProperties($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDevicePropertiesHeaders([]);

        return $this->queryDevicePropertiesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询会议室详情
     *  *
     * @param string                  $roomId
     * @param QueryMeetingRoomRequest $request QueryMeetingRoomRequest
     * @param QueryMeetingRoomHeaders $headers QueryMeetingRoomHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryMeetingRoomResponse QueryMeetingRoomResponse
     */
    public function queryMeetingRoomWithOptions($roomId, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryMeetingRoom',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/meetingRooms/' . $roomId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMeetingRoomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询会议室详情
     *  *
     * @param string                  $roomId
     * @param QueryMeetingRoomRequest $request QueryMeetingRoomRequest
     *
     * @return QueryMeetingRoomResponse QueryMeetingRoomResponse
     */
    public function queryMeetingRoom($roomId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMeetingRoomHeaders([]);

        return $this->queryMeetingRoomWithOptions($roomId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取会议室IOT配置列表
     *  *
     * @param QueryMeetingRoomControlPanelListRequest $request QueryMeetingRoomControlPanelListRequest
     * @param QueryMeetingRoomControlPanelListHeaders $headers QueryMeetingRoomControlPanelListHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryMeetingRoomControlPanelListResponse QueryMeetingRoomControlPanelListResponse
     */
    public function queryMeetingRoomControlPanelListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->roomId)) {
            $query['roomId'] = $request->roomId;
        }
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryMeetingRoomControlPanelList',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/panels/lists',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMeetingRoomControlPanelListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取会议室IOT配置列表
     *  *
     * @param QueryMeetingRoomControlPanelListRequest $request QueryMeetingRoomControlPanelListRequest
     *
     * @return QueryMeetingRoomControlPanelListResponse QueryMeetingRoomControlPanelListResponse
     */
    public function queryMeetingRoomControlPanelList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMeetingRoomControlPanelListHeaders([]);

        return $this->queryMeetingRoomControlPanelListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询设备信息
     *  *
     * @param QueryMeetingRoomDeviceRequest $request QueryMeetingRoomDeviceRequest
     * @param QueryMeetingRoomDeviceHeaders $headers QueryMeetingRoomDeviceHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryMeetingRoomDeviceResponse QueryMeetingRoomDeviceResponse
     */
    public function queryMeetingRoomDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deviceId)) {
            $query['deviceId'] = $request->deviceId;
        }
        if (!Utils::isUnset($request->deviceUnionId)) {
            $query['deviceUnionId'] = $request->deviceUnionId;
        }
        if (!Utils::isUnset($request->operatorUnionId)) {
            $query['operatorUnionId'] = $request->operatorUnionId;
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
            'action' => 'QueryMeetingRoomDevice',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/devices',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMeetingRoomDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询设备信息
     *  *
     * @param QueryMeetingRoomDeviceRequest $request QueryMeetingRoomDeviceRequest
     *
     * @return QueryMeetingRoomDeviceResponse QueryMeetingRoomDeviceResponse
     */
    public function queryMeetingRoomDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMeetingRoomDeviceHeaders([]);

        return $this->queryMeetingRoomDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询会议室分组信息
     *  *
     * @param string                       $groupId
     * @param QueryMeetingRoomGroupRequest $request QueryMeetingRoomGroupRequest
     * @param QueryMeetingRoomGroupHeaders $headers QueryMeetingRoomGroupHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryMeetingRoomGroupResponse QueryMeetingRoomGroupResponse
     */
    public function queryMeetingRoomGroupWithOptions($groupId, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryMeetingRoomGroup',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/groups/' . $groupId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMeetingRoomGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询会议室分组信息
     *  *
     * @param string                       $groupId
     * @param QueryMeetingRoomGroupRequest $request QueryMeetingRoomGroupRequest
     *
     * @return QueryMeetingRoomGroupResponse QueryMeetingRoomGroupResponse
     */
    public function queryMeetingRoomGroup($groupId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMeetingRoomGroupHeaders([]);

        return $this->queryMeetingRoomGroupWithOptions($groupId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询会议室分组列表
     *  *
     * @param QueryMeetingRoomGroupListRequest $request QueryMeetingRoomGroupListRequest
     * @param QueryMeetingRoomGroupListHeaders $headers QueryMeetingRoomGroupListHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryMeetingRoomGroupListResponse QueryMeetingRoomGroupListResponse
     */
    public function queryMeetingRoomGroupListWithOptions($request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryMeetingRoomGroupList',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/groupLists',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMeetingRoomGroupListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询会议室分组列表
     *  *
     * @param QueryMeetingRoomGroupListRequest $request QueryMeetingRoomGroupListRequest
     *
     * @return QueryMeetingRoomGroupListResponse QueryMeetingRoomGroupListResponse
     */
    public function queryMeetingRoomGroupList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMeetingRoomGroupListHeaders([]);

        return $this->queryMeetingRoomGroupListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询会议室列表
     *  *
     * @param QueryMeetingRoomListRequest $request QueryMeetingRoomListRequest
     * @param QueryMeetingRoomListHeaders $headers QueryMeetingRoomListHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryMeetingRoomListResponse QueryMeetingRoomListResponse
     */
    public function queryMeetingRoomListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryMeetingRoomList',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/meetingRoomLists',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMeetingRoomListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询会议室列表
     *  *
     * @param QueryMeetingRoomListRequest $request QueryMeetingRoomListRequest
     *
     * @return QueryMeetingRoomListResponse QueryMeetingRoomListResponse
     */
    public function queryMeetingRoomList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMeetingRoomListHeaders([]);

        return $this->queryMeetingRoomListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 取消会议室高级用户模式。
     *  *
     * @param RemoveSuperUserMeetingRoomRequest $request RemoveSuperUserMeetingRoomRequest
     * @param RemoveSuperUserMeetingRoomHeaders $headers RemoveSuperUserMeetingRoomHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return RemoveSuperUserMeetingRoomResponse RemoveSuperUserMeetingRoomResponse
     */
    public function removeSuperUserMeetingRoomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->roomId)) {
            $query['roomId'] = $request->roomId;
        }
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'RemoveSuperUserMeetingRoom',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/meetingRooms/superUsers/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RemoveSuperUserMeetingRoomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 取消会议室高级用户模式。
     *  *
     * @param RemoveSuperUserMeetingRoomRequest $request RemoveSuperUserMeetingRoomRequest
     *
     * @return RemoveSuperUserMeetingRoomResponse RemoveSuperUserMeetingRoomResponse
     */
    public function removeSuperUserMeetingRoom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveSuperUserMeetingRoomHeaders([]);

        return $this->removeSuperUserMeetingRoomWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发送Rooms中控API信令
     *  *
     * @param SendCentralControlRequest $request SendCentralControlRequest
     * @param SendCentralControlHeaders $headers SendCentralControlHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return SendCentralControlResponse SendCentralControlResponse
     */
    public function sendCentralControlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->controlBody)) {
            $body['controlBody'] = $request->controlBody;
        }
        if (!Utils::isUnset($request->roomId)) {
            $body['roomId'] = $request->roomId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action' => 'SendCentralControl',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/central/control',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SendCentralControlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发送Rooms中控API信令
     *  *
     * @param SendCentralControlRequest $request SendCentralControlRequest
     *
     * @return SendCentralControlResponse SendCentralControlResponse
     */
    public function sendCentralControl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendCentralControlHeaders([]);

        return $this->sendCentralControlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。
     *  *
     * @param SetSuperUserMeetingRoomRequest $request SetSuperUserMeetingRoomRequest
     * @param SetSuperUserMeetingRoomHeaders $headers SetSuperUserMeetingRoomHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return SetSuperUserMeetingRoomResponse SetSuperUserMeetingRoomResponse
     */
    public function setSuperUserMeetingRoomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deptIdWhiteList)) {
            $body['deptIdWhiteList'] = $request->deptIdWhiteList;
        }
        if (!Utils::isUnset($request->roomId)) {
            $body['roomId'] = $request->roomId;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
        }
        if (!Utils::isUnset($request->userIdWhiteList)) {
            $body['userIdWhiteList'] = $request->userIdWhiteList;
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
            'action' => 'SetSuperUserMeetingRoom',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/meetingRooms/superUsers/set',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SetSuperUserMeetingRoomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。
     *  *
     * @param SetSuperUserMeetingRoomRequest $request SetSuperUserMeetingRoomRequest
     *
     * @return SetSuperUserMeetingRoomResponse SetSuperUserMeetingRoomResponse
     */
    public function setSuperUserMeetingRoom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetSuperUserMeetingRoomHeaders([]);

        return $this->setSuperUserMeetingRoomWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新自定义屏幕模板
     *  *
     * @param UpdateDeviceCustomTemplateRequest $request UpdateDeviceCustomTemplateRequest
     * @param UpdateDeviceCustomTemplateHeaders $headers UpdateDeviceCustomTemplateHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateDeviceCustomTemplateResponse UpdateDeviceCustomTemplateResponse
     */
    public function updateDeviceCustomTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bgImgList)) {
            $body['bgImgList'] = $request->bgImgList;
        }
        if (!Utils::isUnset($request->bgType)) {
            $body['bgType'] = $request->bgType;
        }
        if (!Utils::isUnset($request->bgUrl)) {
            $body['bgUrl'] = $request->bgUrl;
        }
        if (!Utils::isUnset($request->customDoc)) {
            $body['customDoc'] = $request->customDoc;
        }
        if (!Utils::isUnset($request->desensitizeUserName)) {
            $body['desensitizeUserName'] = $request->desensitizeUserName;
        }
        if (!Utils::isUnset($request->deviceUnionIds)) {
            $body['deviceUnionIds'] = $request->deviceUnionIds;
        }
        if (!Utils::isUnset($request->groupIds)) {
            $body['groupIds'] = $request->groupIds;
        }
        if (!Utils::isUnset($request->hideServerCodeWhenProjecting)) {
            $body['hideServerCodeWhenProjecting'] = $request->hideServerCodeWhenProjecting;
        }
        if (!Utils::isUnset($request->instruction)) {
            $body['instruction'] = $request->instruction;
        }
        if (!Utils::isUnset($request->isPicTop)) {
            $body['isPicTop'] = $request->isPicTop;
        }
        if (!Utils::isUnset($request->logo)) {
            $body['logo'] = $request->logo;
        }
        if (!Utils::isUnset($request->orgName)) {
            $body['orgName'] = $request->orgName;
        }
        if (!Utils::isUnset($request->picturePlayInterval)) {
            $body['picturePlayInterval'] = $request->picturePlayInterval;
        }
        if (!Utils::isUnset($request->roomIds)) {
            $body['roomIds'] = $request->roomIds;
        }
        if (!Utils::isUnset($request->showCalendarCard)) {
            $body['showCalendarCard'] = $request->showCalendarCard;
        }
        if (!Utils::isUnset($request->showCalendarTitle)) {
            $body['showCalendarTitle'] = $request->showCalendarTitle;
        }
        if (!Utils::isUnset($request->showFunctionCard)) {
            $body['showFunctionCard'] = $request->showFunctionCard;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->templateName)) {
            $body['templateName'] = $request->templateName;
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
            'action' => 'UpdateDeviceCustomTemplate',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/devices/screens/templates',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateDeviceCustomTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新自定义屏幕模板
     *  *
     * @param UpdateDeviceCustomTemplateRequest $request UpdateDeviceCustomTemplateRequest
     *
     * @return UpdateDeviceCustomTemplateResponse UpdateDeviceCustomTemplateResponse
     */
    public function updateDeviceCustomTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateDeviceCustomTemplateHeaders([]);

        return $this->updateDeviceCustomTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新会议室信息
     *  *
     * @param UpdateMeetingRoomRequest $request UpdateMeetingRoomRequest
     * @param UpdateMeetingRoomHeaders $headers UpdateMeetingRoomHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateMeetingRoomResponse UpdateMeetingRoomResponse
     */
    public function updateMeetingRoomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->enableCycleReservation)) {
            $body['enableCycleReservation'] = $request->enableCycleReservation;
        }
        if (!Utils::isUnset($request->groupId)) {
            $body['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->isvRoomId)) {
            $body['isvRoomId'] = $request->isvRoomId;
        }
        if (!Utils::isUnset($request->openReservation)) {
            $body['openReservation'] = $request->openReservation;
        }
        if (!Utils::isUnset($request->reservationAuthority)) {
            $body['reservationAuthority'] = $request->reservationAuthority;
        }
        if (!Utils::isUnset($request->roomCapacity)) {
            $body['roomCapacity'] = $request->roomCapacity;
        }
        if (!Utils::isUnset($request->roomDescription)) {
            $body['roomDescription'] = $request->roomDescription;
        }
        if (!Utils::isUnset($request->roomId)) {
            $body['roomId'] = $request->roomId;
        }
        if (!Utils::isUnset($request->roomLabelIds)) {
            $body['roomLabelIds'] = $request->roomLabelIds;
        }
        if (!Utils::isUnset($request->roomLocation)) {
            $body['roomLocation'] = $request->roomLocation;
        }
        if (!Utils::isUnset($request->roomName)) {
            $body['roomName'] = $request->roomName;
        }
        if (!Utils::isUnset($request->roomPicture)) {
            $body['roomPicture'] = $request->roomPicture;
        }
        if (!Utils::isUnset($request->roomStatus)) {
            $body['roomStatus'] = $request->roomStatus;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action' => 'UpdateMeetingRoom',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/meetingRooms',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateMeetingRoomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新会议室信息
     *  *
     * @param UpdateMeetingRoomRequest $request UpdateMeetingRoomRequest
     *
     * @return UpdateMeetingRoomResponse UpdateMeetingRoomResponse
     */
    public function updateMeetingRoom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateMeetingRoomHeaders([]);

        return $this->updateMeetingRoomWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新会议室分组
     *  *
     * @param UpdateMeetingRoomGroupRequest $request UpdateMeetingRoomGroupRequest
     * @param UpdateMeetingRoomGroupHeaders $headers UpdateMeetingRoomGroupHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateMeetingRoomGroupResponse UpdateMeetingRoomGroupResponse
     */
    public function updateMeetingRoomGroupWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->groupId)) {
            $body['groupId'] = $request->groupId;
        }
        if (!Utils::isUnset($request->groupName)) {
            $body['groupName'] = $request->groupName;
        }
        if (!Utils::isUnset($request->unionId)) {
            $body['unionId'] = $request->unionId;
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
            'action' => 'UpdateMeetingRoomGroup',
            'version' => 'rooms_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/rooms/groups',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateMeetingRoomGroupResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新会议室分组
     *  *
     * @param UpdateMeetingRoomGroupRequest $request UpdateMeetingRoomGroupRequest
     *
     * @return UpdateMeetingRoomGroupResponse UpdateMeetingRoomGroupResponse
     */
    public function updateMeetingRoomGroup($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateMeetingRoomGroupHeaders([]);

        return $this->updateMeetingRoomGroupWithOptions($request, $headers, $runtime);
    }
}
