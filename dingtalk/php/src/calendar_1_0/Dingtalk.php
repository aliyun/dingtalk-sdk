<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\AddAttendeeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\AddAttendeeRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\AddAttendeeResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\AddMeetingRoomsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\AddMeetingRoomsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\AddMeetingRoomsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CheckInHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CheckInResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ConvertLegacyEventIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ConvertLegacyEventIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ConvertLegacyEventIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateAclsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateAclsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateAclsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventByMeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventByMeRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventByMeResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateSubscribedCalendarHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateSubscribedCalendarRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateSubscribedCalendarResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\DeleteAclHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\DeleteAclResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\DeleteEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\DeleteEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\DeleteEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\DeleteSubscribedCalendarHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\DeleteSubscribedCalendarResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GenerateCaldavAccountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GenerateCaldavAccountRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GenerateCaldavAccountResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetMeetingRoomsScheduleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetMeetingRoomsScheduleRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetMeetingRoomsScheduleResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetScheduleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetScheduleRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetScheduleResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignInLinkHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignInLinkResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignInListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignInListRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignInListResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignOutLinkHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignOutLinkResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignOutListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignOutListRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignOutListResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSubscribedCalendarHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSubscribedCalendarResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListAclsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListAclsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListAttendeesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListAttendeesRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListAttendeesResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListCalendarsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListCalendarsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsInstancesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsInstancesRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsInstancesResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsViewHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsViewRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsViewResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListInstancesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListInstancesRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListInstancesResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\MeetingRoomRespondHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\MeetingRoomRespondRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\MeetingRoomRespondResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RemoveAttendeeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RemoveAttendeeRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RemoveAttendeeResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RemoveMeetingRoomsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RemoveMeetingRoomsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RemoveMeetingRoomsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RespondEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RespondEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RespondEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\SignInHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\SignInResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\SignOutHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\SignOutResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\SubscribeCalendarHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\SubscribeCalendarResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\TransferEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\TransferEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\TransferEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\UnsubscribeCalendarHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\UnsubscribeCalendarResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\UpdateSubscribedCalendarsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\UpdateSubscribedCalendarsRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\UpdateSubscribedCalendarsResponse;
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
     * @summary 新增日程参与人
     *  *
     * @param string             $userId
     * @param string             $calendarId
     * @param string             $eventId
     * @param AddAttendeeRequest $request    AddAttendeeRequest
     * @param AddAttendeeHeaders $headers    AddAttendeeHeaders
     * @param RuntimeOptions     $runtime    runtime options for this request RuntimeOptions
     *
     * @return AddAttendeeResponse AddAttendeeResponse
     */
    public function addAttendeeWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attendeesToAdd)) {
            $body['attendeesToAdd'] = $request->attendeesToAdd;
        }
        if (!Utils::isUnset($request->chatNotification)) {
            $body['chatNotification'] = $request->chatNotification;
        }
        if (!Utils::isUnset($request->pushNotification)) {
            $body['pushNotification'] = $request->pushNotification;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xClientToken)) {
            $realHeaders['x-client-token'] = Utils::toJSONString($headers->xClientToken);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AddAttendee',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/attendees',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return AddAttendeeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增日程参与人
     *  *
     * @param string             $userId
     * @param string             $calendarId
     * @param string             $eventId
     * @param AddAttendeeRequest $request    AddAttendeeRequest
     *
     * @return AddAttendeeResponse AddAttendeeResponse
     */
    public function addAttendee($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddAttendeeHeaders([]);

        return $this->addAttendeeWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @summary 添加会议室
     *  *
     * @param string                 $userId
     * @param string                 $calendarId
     * @param string                 $eventId
     * @param AddMeetingRoomsRequest $request    AddMeetingRoomsRequest
     * @param AddMeetingRoomsHeaders $headers    AddMeetingRoomsHeaders
     * @param RuntimeOptions         $runtime    runtime options for this request RuntimeOptions
     *
     * @return AddMeetingRoomsResponse AddMeetingRoomsResponse
     */
    public function addMeetingRoomsWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->meetingRoomsToAdd)) {
            $body['meetingRoomsToAdd'] = $request->meetingRoomsToAdd;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xClientToken)) {
            $realHeaders['x-client-token'] = Utils::toJSONString($headers->xClientToken);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'AddMeetingRooms',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/meetingRooms',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AddMeetingRoomsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 添加会议室
     *  *
     * @param string                 $userId
     * @param string                 $calendarId
     * @param string                 $eventId
     * @param AddMeetingRoomsRequest $request    AddMeetingRoomsRequest
     *
     * @return AddMeetingRoomsResponse AddMeetingRoomsResponse
     */
    public function addMeetingRooms($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddMeetingRoomsHeaders([]);

        return $this->addMeetingRoomsWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @summary 签到
     *  *
     * @param string         $userId
     * @param string         $calendarId
     * @param string         $eventId
     * @param CheckInHeaders $headers    CheckInHeaders
     * @param RuntimeOptions $runtime    runtime options for this request RuntimeOptions
     *
     * @return CheckInResponse CheckInResponse
     */
    public function checkInWithOptions($userId, $calendarId, $eventId, $headers, $runtime)
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
            'action'      => 'CheckIn',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/checkIn',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CheckInResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 签到
     *  *
     * @param string $userId
     * @param string $calendarId
     * @param string $eventId
     *
     * @return CheckInResponse CheckInResponse
     */
    public function checkIn($userId, $calendarId, $eventId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckInHeaders([]);

        return $this->checkInWithOptions($userId, $calendarId, $eventId, $headers, $runtime);
    }

    /**
     * @summary 转换老版本的eventId
     *  *
     * @param string                      $userId
     * @param ConvertLegacyEventIdRequest $request ConvertLegacyEventIdRequest
     * @param ConvertLegacyEventIdHeaders $headers ConvertLegacyEventIdHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return ConvertLegacyEventIdResponse ConvertLegacyEventIdResponse
     */
    public function convertLegacyEventIdWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->legacyEventIds)) {
            $body['legacyEventIds'] = $request->legacyEventIds;
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
            'action'      => 'ConvertLegacyEventId',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/legacyEventIds/convert',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ConvertLegacyEventIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 转换老版本的eventId
     *  *
     * @param string                      $userId
     * @param ConvertLegacyEventIdRequest $request ConvertLegacyEventIdRequest
     *
     * @return ConvertLegacyEventIdResponse ConvertLegacyEventIdResponse
     */
    public function convertLegacyEventId($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConvertLegacyEventIdHeaders([]);

        return $this->convertLegacyEventIdWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建访问控制
     *  *
     * @param string            $userId
     * @param string            $calendarId
     * @param CreateAclsRequest $request    CreateAclsRequest
     * @param CreateAclsHeaders $headers    CreateAclsHeaders
     * @param RuntimeOptions    $runtime    runtime options for this request RuntimeOptions
     *
     * @return CreateAclsResponse CreateAclsResponse
     */
    public function createAclsWithOptions($userId, $calendarId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->privilege)) {
            $body['privilege'] = $request->privilege;
        }
        if (!Utils::isUnset($request->scope)) {
            $body['scope'] = $request->scope;
        }
        if (!Utils::isUnset($request->sendMsg)) {
            $body['sendMsg'] = $request->sendMsg;
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
            'action'      => 'CreateAcls',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/acls',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateAclsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建访问控制
     *  *
     * @param string            $userId
     * @param string            $calendarId
     * @param CreateAclsRequest $request    CreateAclsRequest
     *
     * @return CreateAclsResponse CreateAclsResponse
     */
    public function createAcls($userId, $calendarId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateAclsHeaders([]);

        return $this->createAclsWithOptions($userId, $calendarId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建日程
     *  *
     * @param string             $userId
     * @param string             $calendarId
     * @param CreateEventRequest $request    CreateEventRequest
     * @param CreateEventHeaders $headers    CreateEventHeaders
     * @param RuntimeOptions     $runtime    runtime options for this request RuntimeOptions
     *
     * @return CreateEventResponse CreateEventResponse
     */
    public function createEventWithOptions($userId, $calendarId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attendees)) {
            $body['attendees'] = $request->attendees;
        }
        if (!Utils::isUnset($request->cardInstances)) {
            $body['cardInstances'] = $request->cardInstances;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->end)) {
            $body['end'] = $request->end;
        }
        if (!Utils::isUnset($request->extra)) {
            $body['extra'] = $request->extra;
        }
        if (!Utils::isUnset($request->isAllDay)) {
            $body['isAllDay'] = $request->isAllDay;
        }
        if (!Utils::isUnset($request->location)) {
            $body['location'] = $request->location;
        }
        if (!Utils::isUnset($request->onlineMeetingInfo)) {
            $body['onlineMeetingInfo'] = $request->onlineMeetingInfo;
        }
        if (!Utils::isUnset($request->recurrence)) {
            $body['recurrence'] = $request->recurrence;
        }
        if (!Utils::isUnset($request->reminders)) {
            $body['reminders'] = $request->reminders;
        }
        if (!Utils::isUnset($request->richTextDescription)) {
            $body['richTextDescription'] = $request->richTextDescription;
        }
        if (!Utils::isUnset($request->start)) {
            $body['start'] = $request->start;
        }
        if (!Utils::isUnset($request->summary)) {
            $body['summary'] = $request->summary;
        }
        if (!Utils::isUnset($request->uiConfigs)) {
            $body['uiConfigs'] = $request->uiConfigs;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xClientToken)) {
            $realHeaders['x-client-token'] = Utils::toJSONString($headers->xClientToken);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateEvent',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateEventResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建日程
     *  *
     * @param string             $userId
     * @param string             $calendarId
     * @param CreateEventRequest $request    CreateEventRequest
     *
     * @return CreateEventResponse CreateEventResponse
     */
    public function createEvent($userId, $calendarId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateEventHeaders([]);

        return $this->createEventWithOptions($userId, $calendarId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建日程(me接口)
     *  *
     * @param string                 $calendarId
     * @param CreateEventByMeRequest $request    CreateEventByMeRequest
     * @param CreateEventByMeHeaders $headers    CreateEventByMeHeaders
     * @param RuntimeOptions         $runtime    runtime options for this request RuntimeOptions
     *
     * @return CreateEventByMeResponse CreateEventByMeResponse
     */
    public function createEventByMeWithOptions($calendarId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attendees)) {
            $body['attendees'] = $request->attendees;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->end)) {
            $body['end'] = $request->end;
        }
        if (!Utils::isUnset($request->extra)) {
            $body['extra'] = $request->extra;
        }
        if (!Utils::isUnset($request->isAllDay)) {
            $body['isAllDay'] = $request->isAllDay;
        }
        if (!Utils::isUnset($request->location)) {
            $body['location'] = $request->location;
        }
        if (!Utils::isUnset($request->onlineMeetingInfo)) {
            $body['onlineMeetingInfo'] = $request->onlineMeetingInfo;
        }
        if (!Utils::isUnset($request->recurrence)) {
            $body['recurrence'] = $request->recurrence;
        }
        if (!Utils::isUnset($request->reminders)) {
            $body['reminders'] = $request->reminders;
        }
        if (!Utils::isUnset($request->richTextDescription)) {
            $body['richTextDescription'] = $request->richTextDescription;
        }
        if (!Utils::isUnset($request->start)) {
            $body['start'] = $request->start;
        }
        if (!Utils::isUnset($request->summary)) {
            $body['summary'] = $request->summary;
        }
        if (!Utils::isUnset($request->uiConfigs)) {
            $body['uiConfigs'] = $request->uiConfigs;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xClientToken)) {
            $realHeaders['x-client-token'] = Utils::toJSONString($headers->xClientToken);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateEventByMe',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/me/calendars/' . $calendarId . '/events',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateEventByMeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建日程(me接口)
     *  *
     * @param string                 $calendarId
     * @param CreateEventByMeRequest $request    CreateEventByMeRequest
     *
     * @return CreateEventByMeResponse CreateEventByMeResponse
     */
    public function createEventByMe($calendarId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateEventByMeHeaders([]);

        return $this->createEventByMeWithOptions($calendarId, $request, $headers, $runtime);
    }

    /**
     * @summary 快速创建订阅日历
     *  *
     * @param string                          $userId
     * @param CreateSubscribedCalendarRequest $request CreateSubscribedCalendarRequest
     * @param CreateSubscribedCalendarHeaders $headers CreateSubscribedCalendarHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateSubscribedCalendarResponse CreateSubscribedCalendarResponse
     */
    public function createSubscribedCalendarWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->managers)) {
            $body['managers'] = $request->managers;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->subscribeScope)) {
            $body['subscribeScope'] = $request->subscribeScope;
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
            'action'      => 'CreateSubscribedCalendar',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/subscribedCalendars',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateSubscribedCalendarResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 快速创建订阅日历
     *  *
     * @param string                          $userId
     * @param CreateSubscribedCalendarRequest $request CreateSubscribedCalendarRequest
     *
     * @return CreateSubscribedCalendarResponse CreateSubscribedCalendarResponse
     */
    public function createSubscribedCalendar($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSubscribedCalendarHeaders([]);

        return $this->createSubscribedCalendarWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除访问控制
     *  *
     * @param string           $userId
     * @param string           $calendarId
     * @param string           $aclId
     * @param DeleteAclHeaders $headers    DeleteAclHeaders
     * @param RuntimeOptions   $runtime    runtime options for this request RuntimeOptions
     *
     * @return DeleteAclResponse DeleteAclResponse
     */
    public function deleteAclWithOptions($userId, $calendarId, $aclId, $headers, $runtime)
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
            'action'      => 'DeleteAcl',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/acls/' . $aclId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return DeleteAclResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除访问控制
     *  *
     * @param string $userId
     * @param string $calendarId
     * @param string $aclId
     *
     * @return DeleteAclResponse DeleteAclResponse
     */
    public function deleteAcl($userId, $calendarId, $aclId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteAclHeaders([]);

        return $this->deleteAclWithOptions($userId, $calendarId, $aclId, $headers, $runtime);
    }

    /**
     * @summary 删除指定日程
     *  *
     * @param string             $userId
     * @param string             $calendarId
     * @param string             $eventId
     * @param DeleteEventRequest $request    DeleteEventRequest
     * @param DeleteEventHeaders $headers    DeleteEventHeaders
     * @param RuntimeOptions     $runtime    runtime options for this request RuntimeOptions
     *
     * @return DeleteEventResponse DeleteEventResponse
     */
    public function deleteEventWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pushNotification)) {
            $query['pushNotification'] = $request->pushNotification;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xClientToken)) {
            $realHeaders['x-client-token'] = Utils::toJSONString($headers->xClientToken);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeleteEvent',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return DeleteEventResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除指定日程
     *  *
     * @param string             $userId
     * @param string             $calendarId
     * @param string             $eventId
     * @param DeleteEventRequest $request    DeleteEventRequest
     *
     * @return DeleteEventResponse DeleteEventResponse
     */
    public function deleteEvent($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteEventHeaders([]);

        return $this->deleteEventWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除指定订阅日历
     *  *
     * @param string                          $userId
     * @param string                          $calendarId
     * @param DeleteSubscribedCalendarHeaders $headers    DeleteSubscribedCalendarHeaders
     * @param RuntimeOptions                  $runtime    runtime options for this request RuntimeOptions
     *
     * @return DeleteSubscribedCalendarResponse DeleteSubscribedCalendarResponse
     */
    public function deleteSubscribedCalendarWithOptions($userId, $calendarId, $headers, $runtime)
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
            'action'      => 'DeleteSubscribedCalendar',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/subscribedCalendars/' . $calendarId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteSubscribedCalendarResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除指定订阅日历
     *  *
     * @param string $userId
     * @param string $calendarId
     *
     * @return DeleteSubscribedCalendarResponse DeleteSubscribedCalendarResponse
     */
    public function deleteSubscribedCalendar($userId, $calendarId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSubscribedCalendarHeaders([]);

        return $this->deleteSubscribedCalendarWithOptions($userId, $calendarId, $headers, $runtime);
    }

    /**
     * @summary 生成caldav账户
     *  *
     * @param string                       $userId
     * @param GenerateCaldavAccountRequest $request GenerateCaldavAccountRequest
     * @param GenerateCaldavAccountHeaders $headers GenerateCaldavAccountHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GenerateCaldavAccountResponse GenerateCaldavAccountResponse
     */
    public function generateCaldavAccountWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->device)) {
            $body['device'] = $request->device;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->dingUid)) {
            $realHeaders['dingUid'] = Utils::toJSONString($headers->dingUid);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GenerateCaldavAccount',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/caldavAccounts',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GenerateCaldavAccountResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 生成caldav账户
     *  *
     * @param string                       $userId
     * @param GenerateCaldavAccountRequest $request GenerateCaldavAccountRequest
     *
     * @return GenerateCaldavAccountResponse GenerateCaldavAccountResponse
     */
    public function generateCaldavAccount($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GenerateCaldavAccountHeaders([]);

        return $this->generateCaldavAccountWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询日程列表
     *  *
     * @param string          $userId
     * @param string          $calendarId
     * @param string          $eventId
     * @param GetEventRequest $request    GetEventRequest
     * @param GetEventHeaders $headers    GetEventHeaders
     * @param RuntimeOptions  $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetEventResponse GetEventResponse
     */
    public function getEventWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxAttendees)) {
            $query['maxAttendees'] = $request->maxAttendees;
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
            'action'      => 'GetEvent',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetEventResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询日程列表
     *  *
     * @param string          $userId
     * @param string          $calendarId
     * @param string          $eventId
     * @param GetEventRequest $request    GetEventRequest
     *
     * @return GetEventResponse GetEventResponse
     */
    public function getEvent($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetEventHeaders([]);

        return $this->getEventWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询会议室忙闲
     *  *
     * @param string                         $userId
     * @param GetMeetingRoomsScheduleRequest $request GetMeetingRoomsScheduleRequest
     * @param GetMeetingRoomsScheduleHeaders $headers GetMeetingRoomsScheduleHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return GetMeetingRoomsScheduleResponse GetMeetingRoomsScheduleResponse
     */
    public function getMeetingRoomsScheduleWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->roomIds)) {
            $body['roomIds'] = $request->roomIds;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
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
            'action'      => 'GetMeetingRoomsSchedule',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/meetingRooms/schedules/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetMeetingRoomsScheduleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询会议室忙闲
     *  *
     * @param string                         $userId
     * @param GetMeetingRoomsScheduleRequest $request GetMeetingRoomsScheduleRequest
     *
     * @return GetMeetingRoomsScheduleResponse GetMeetingRoomsScheduleResponse
     */
    public function getMeetingRoomsSchedule($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMeetingRoomsScheduleHeaders([]);

        return $this->getMeetingRoomsScheduleWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询闲忙
     *  *
     * @param string             $userId
     * @param GetScheduleRequest $request GetScheduleRequest
     * @param GetScheduleHeaders $headers GetScheduleHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetScheduleResponse GetScheduleResponse
     */
    public function getScheduleWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetSchedule',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/querySchedule',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetScheduleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询闲忙
     *  *
     * @param string             $userId
     * @param GetScheduleRequest $request GetScheduleRequest
     *
     * @return GetScheduleResponse GetScheduleResponse
     */
    public function getSchedule($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetScheduleHeaders([]);

        return $this->getScheduleWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取签到链接
     *  *
     * @param string               $calendarId
     * @param string               $userId
     * @param string               $eventId
     * @param GetSignInLinkHeaders $headers    GetSignInLinkHeaders
     * @param RuntimeOptions       $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetSignInLinkResponse GetSignInLinkResponse
     */
    public function getSignInLinkWithOptions($calendarId, $userId, $eventId, $headers, $runtime)
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
            'action'      => 'GetSignInLink',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/signInLinks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSignInLinkResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取签到链接
     *  *
     * @param string $calendarId
     * @param string $userId
     * @param string $eventId
     *
     * @return GetSignInLinkResponse GetSignInLinkResponse
     */
    public function getSignInLink($calendarId, $userId, $eventId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSignInLinkHeaders([]);

        return $this->getSignInLinkWithOptions($calendarId, $userId, $eventId, $headers, $runtime);
    }

    /**
     * @summary 获取签到信息详情
     *  *
     * @param string               $userId
     * @param string               $calendarId
     * @param string               $eventId
     * @param GetSignInListRequest $request    GetSignInListRequest
     * @param GetSignInListHeaders $headers    GetSignInListHeaders
     * @param RuntimeOptions       $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetSignInListResponse GetSignInListResponse
     */
    public function getSignInListWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->type)) {
            $query['type'] = $request->type;
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
            'action'      => 'GetSignInList',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/signin',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSignInListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取签到信息详情
     *  *
     * @param string               $userId
     * @param string               $calendarId
     * @param string               $eventId
     * @param GetSignInListRequest $request    GetSignInListRequest
     *
     * @return GetSignInListResponse GetSignInListResponse
     */
    public function getSignInList($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSignInListHeaders([]);

        return $this->getSignInListWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取签退链接
     *  *
     * @param string                $calendarId
     * @param string                $userId
     * @param string                $eventId
     * @param GetSignOutLinkHeaders $headers    GetSignOutLinkHeaders
     * @param RuntimeOptions        $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetSignOutLinkResponse GetSignOutLinkResponse
     */
    public function getSignOutLinkWithOptions($calendarId, $userId, $eventId, $headers, $runtime)
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
            'action'      => 'GetSignOutLink',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/signOutLinks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSignOutLinkResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取签退链接
     *  *
     * @param string $calendarId
     * @param string $userId
     * @param string $eventId
     *
     * @return GetSignOutLinkResponse GetSignOutLinkResponse
     */
    public function getSignOutLink($calendarId, $userId, $eventId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSignOutLinkHeaders([]);

        return $this->getSignOutLinkWithOptions($calendarId, $userId, $eventId, $headers, $runtime);
    }

    /**
     * @summary 获取签退信息详情
     *  *
     * @param string                $userId
     * @param string                $calendarId
     * @param string                $eventId
     * @param GetSignOutListRequest $request    GetSignOutListRequest
     * @param GetSignOutListHeaders $headers    GetSignOutListHeaders
     * @param RuntimeOptions        $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetSignOutListResponse GetSignOutListResponse
     */
    public function getSignOutListWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->type)) {
            $query['type'] = $request->type;
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
            'action'      => 'GetSignOutList',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/signOut',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSignOutListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取签退信息详情
     *  *
     * @param string                $userId
     * @param string                $calendarId
     * @param string                $eventId
     * @param GetSignOutListRequest $request    GetSignOutListRequest
     *
     * @return GetSignOutListResponse GetSignOutListResponse
     */
    public function getSignOutList($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSignOutListHeaders([]);

        return $this->getSignOutListWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取指定订阅日历详情
     *  *
     * @param string                       $userId
     * @param string                       $calendarId
     * @param GetSubscribedCalendarHeaders $headers    GetSubscribedCalendarHeaders
     * @param RuntimeOptions               $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetSubscribedCalendarResponse GetSubscribedCalendarResponse
     */
    public function getSubscribedCalendarWithOptions($userId, $calendarId, $headers, $runtime)
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
            'action'      => 'GetSubscribedCalendar',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/subscribedCalendars/' . $calendarId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSubscribedCalendarResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取指定订阅日历详情
     *  *
     * @param string $userId
     * @param string $calendarId
     *
     * @return GetSubscribedCalendarResponse GetSubscribedCalendarResponse
     */
    public function getSubscribedCalendar($userId, $calendarId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSubscribedCalendarHeaders([]);

        return $this->getSubscribedCalendarWithOptions($userId, $calendarId, $headers, $runtime);
    }

    /**
     * @summary 获取访问控制列表
     *  *
     * @param string          $userId
     * @param string          $calendarId
     * @param ListAclsHeaders $headers    ListAclsHeaders
     * @param RuntimeOptions  $runtime    runtime options for this request RuntimeOptions
     *
     * @return ListAclsResponse ListAclsResponse
     */
    public function listAclsWithOptions($userId, $calendarId, $headers, $runtime)
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
            'action'      => 'ListAcls',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/acls',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListAclsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取访问控制列表
     *  *
     * @param string $userId
     * @param string $calendarId
     *
     * @return ListAclsResponse ListAclsResponse
     */
    public function listAcls($userId, $calendarId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAclsHeaders([]);

        return $this->listAclsWithOptions($userId, $calendarId, $headers, $runtime);
    }

    /**
     * @summary 分页获取参与人列表
     *  *
     * @param string               $userId
     * @param string               $calendarId
     * @param string               $eventId
     * @param ListAttendeesRequest $request    ListAttendeesRequest
     * @param ListAttendeesHeaders $headers    ListAttendeesHeaders
     * @param RuntimeOptions       $runtime    runtime options for this request RuntimeOptions
     *
     * @return ListAttendeesResponse ListAttendeesResponse
     */
    public function listAttendeesWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
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
            'action'      => 'ListAttendees',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/attendees',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListAttendeesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页获取参与人列表
     *  *
     * @param string               $userId
     * @param string               $calendarId
     * @param string               $eventId
     * @param ListAttendeesRequest $request    ListAttendeesRequest
     *
     * @return ListAttendeesResponse ListAttendeesResponse
     */
    public function listAttendees($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAttendeesHeaders([]);

        return $this->listAttendeesWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @summary 日历本查询
     *  *
     * @param string               $userId
     * @param ListCalendarsHeaders $headers ListCalendarsHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return ListCalendarsResponse ListCalendarsResponse
     */
    public function listCalendarsWithOptions($userId, $headers, $runtime)
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
            'action'      => 'ListCalendars',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListCalendarsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 日历本查询
     *  *
     * @param string $userId
     *
     * @return ListCalendarsResponse ListCalendarsResponse
     */
    public function listCalendars($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListCalendarsHeaders([]);

        return $this->listCalendarsWithOptions($userId, $headers, $runtime);
    }

    /**
     * @summary 查询日程列表
     *  *
     * @param string            $userId
     * @param string            $calendarId
     * @param ListEventsRequest $request    ListEventsRequest
     * @param ListEventsHeaders $headers    ListEventsHeaders
     * @param RuntimeOptions    $runtime    runtime options for this request RuntimeOptions
     *
     * @return ListEventsResponse ListEventsResponse
     */
    public function listEventsWithOptions($userId, $calendarId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxAttendees)) {
            $query['maxAttendees'] = $request->maxAttendees;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->seriesMasterId)) {
            $query['seriesMasterId'] = $request->seriesMasterId;
        }
        if (!Utils::isUnset($request->showDeleted)) {
            $query['showDeleted'] = $request->showDeleted;
        }
        if (!Utils::isUnset($request->syncToken)) {
            $query['syncToken'] = $request->syncToken;
        }
        if (!Utils::isUnset($request->timeMax)) {
            $query['timeMax'] = $request->timeMax;
        }
        if (!Utils::isUnset($request->timeMin)) {
            $query['timeMin'] = $request->timeMin;
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
            'action'      => 'ListEvents',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListEventsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询日程列表
     *  *
     * @param string            $userId
     * @param string            $calendarId
     * @param ListEventsRequest $request    ListEventsRequest
     *
     * @return ListEventsResponse ListEventsResponse
     */
    public function listEvents($userId, $calendarId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListEventsHeaders([]);

        return $this->listEventsWithOptions($userId, $calendarId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询同一个循环日程序列下已生成的实例
     *  *
     * @param string                     $userId
     * @param string                     $calendarId
     * @param ListEventsInstancesRequest $request    ListEventsInstancesRequest
     * @param ListEventsInstancesHeaders $headers    ListEventsInstancesHeaders
     * @param RuntimeOptions             $runtime    runtime options for this request RuntimeOptions
     *
     * @return ListEventsInstancesResponse ListEventsInstancesResponse
     */
    public function listEventsInstancesWithOptions($userId, $calendarId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxAttendees)) {
            $query['maxAttendees'] = $request->maxAttendees;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->seriesMasterId)) {
            $query['seriesMasterId'] = $request->seriesMasterId;
        }
        if (!Utils::isUnset($request->startRecurrenceId)) {
            $query['startRecurrenceId'] = $request->startRecurrenceId;
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
            'action'      => 'ListEventsInstances',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/instances',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListEventsInstancesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询同一个循环日程序列下已生成的实例
     *  *
     * @param string                     $userId
     * @param string                     $calendarId
     * @param ListEventsInstancesRequest $request    ListEventsInstancesRequest
     *
     * @return ListEventsInstancesResponse ListEventsInstancesResponse
     */
    public function listEventsInstances($userId, $calendarId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListEventsInstancesHeaders([]);

        return $this->listEventsInstancesWithOptions($userId, $calendarId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询日程视图列表以查看闲忙，展开循环日程
     *  *
     * @param string                $userId
     * @param string                $calendarId
     * @param ListEventsViewRequest $request    ListEventsViewRequest
     * @param ListEventsViewHeaders $headers    ListEventsViewHeaders
     * @param RuntimeOptions        $runtime    runtime options for this request RuntimeOptions
     *
     * @return ListEventsViewResponse ListEventsViewResponse
     */
    public function listEventsViewWithOptions($userId, $calendarId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxAttendees)) {
            $query['maxAttendees'] = $request->maxAttendees;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->timeMax)) {
            $query['timeMax'] = $request->timeMax;
        }
        if (!Utils::isUnset($request->timeMin)) {
            $query['timeMin'] = $request->timeMin;
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
            'action'      => 'ListEventsView',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/eventsview',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListEventsViewResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询日程视图列表以查看闲忙，展开循环日程
     *  *
     * @param string                $userId
     * @param string                $calendarId
     * @param ListEventsViewRequest $request    ListEventsViewRequest
     *
     * @return ListEventsViewResponse ListEventsViewResponse
     */
    public function listEventsView($userId, $calendarId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListEventsViewHeaders([]);

        return $this->listEventsViewWithOptions($userId, $calendarId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询循环日程实例列表
     *  *
     * @param string               $userId
     * @param string               $calendarId
     * @param string               $eventId
     * @param ListInstancesRequest $request    ListInstancesRequest
     * @param ListInstancesHeaders $headers    ListInstancesHeaders
     * @param RuntimeOptions       $runtime    runtime options for this request RuntimeOptions
     *
     * @return ListInstancesResponse ListInstancesResponse
     */
    public function listInstancesWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxAttendees)) {
            $query['maxAttendees'] = $request->maxAttendees;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->timeMax)) {
            $query['timeMax'] = $request->timeMax;
        }
        if (!Utils::isUnset($request->timeMin)) {
            $query['timeMin'] = $request->timeMin;
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
            'action'      => 'ListInstances',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/instances',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListInstancesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询循环日程实例列表
     *  *
     * @param string               $userId
     * @param string               $calendarId
     * @param string               $eventId
     * @param ListInstancesRequest $request    ListInstancesRequest
     *
     * @return ListInstancesResponse ListInstancesResponse
     */
    public function listInstances($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListInstancesHeaders([]);

        return $this->listInstancesWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @summary 设置会议室在日程中的响应状态
     *  *
     * @param string                    $calendarId
     * @param string                    $userId
     * @param string                    $eventId
     * @param string                    $roomId
     * @param MeetingRoomRespondRequest $request    MeetingRoomRespondRequest
     * @param MeetingRoomRespondHeaders $headers    MeetingRoomRespondHeaders
     * @param RuntimeOptions            $runtime    runtime options for this request RuntimeOptions
     *
     * @return MeetingRoomRespondResponse MeetingRoomRespondResponse
     */
    public function meetingRoomRespondWithOptions($calendarId, $userId, $eventId, $roomId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->responseStatus)) {
            $body['responseStatus'] = $request->responseStatus;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->userAgent)) {
            $realHeaders['userAgent'] = Utils::toJSONString($headers->userAgent);
        }
        if (!Utils::isUnset($headers->xClientToken)) {
            $realHeaders['x-client-token'] = Utils::toJSONString($headers->xClientToken);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'MeetingRoomRespond',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/meetingRooms/' . $roomId . '/respond',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return MeetingRoomRespondResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置会议室在日程中的响应状态
     *  *
     * @param string                    $calendarId
     * @param string                    $userId
     * @param string                    $eventId
     * @param string                    $roomId
     * @param MeetingRoomRespondRequest $request    MeetingRoomRespondRequest
     *
     * @return MeetingRoomRespondResponse MeetingRoomRespondResponse
     */
    public function meetingRoomRespond($calendarId, $userId, $eventId, $roomId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MeetingRoomRespondHeaders([]);

        return $this->meetingRoomRespondWithOptions($calendarId, $userId, $eventId, $roomId, $request, $headers, $runtime);
    }

    /**
     * @summary 修改日程
     *  *
     * @param string            $userId
     * @param string            $calendarId
     * @param string            $eventId
     * @param PatchEventRequest $request    PatchEventRequest
     * @param PatchEventHeaders $headers    PatchEventHeaders
     * @param RuntimeOptions    $runtime    runtime options for this request RuntimeOptions
     *
     * @return PatchEventResponse PatchEventResponse
     */
    public function patchEventWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attendees)) {
            $body['attendees'] = $request->attendees;
        }
        if (!Utils::isUnset($request->cardInstances)) {
            $body['cardInstances'] = $request->cardInstances;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->end)) {
            $body['end'] = $request->end;
        }
        if (!Utils::isUnset($request->extra)) {
            $body['extra'] = $request->extra;
        }
        if (!Utils::isUnset($request->id)) {
            $body['id'] = $request->id;
        }
        if (!Utils::isUnset($request->isAllDay)) {
            $body['isAllDay'] = $request->isAllDay;
        }
        if (!Utils::isUnset($request->location)) {
            $body['location'] = $request->location;
        }
        if (!Utils::isUnset($request->onlineMeetingInfo)) {
            $body['onlineMeetingInfo'] = $request->onlineMeetingInfo;
        }
        if (!Utils::isUnset($request->recurrence)) {
            $body['recurrence'] = $request->recurrence;
        }
        if (!Utils::isUnset($request->reminders)) {
            $body['reminders'] = $request->reminders;
        }
        if (!Utils::isUnset($request->richTextDescription)) {
            $body['richTextDescription'] = $request->richTextDescription;
        }
        if (!Utils::isUnset($request->start)) {
            $body['start'] = $request->start;
        }
        if (!Utils::isUnset($request->summary)) {
            $body['summary'] = $request->summary;
        }
        if (!Utils::isUnset($request->uiConfigs)) {
            $body['uiConfigs'] = $request->uiConfigs;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xClientToken)) {
            $realHeaders['x-client-token'] = Utils::toJSONString($headers->xClientToken);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'PatchEvent',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PatchEventResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改日程
     *  *
     * @param string            $userId
     * @param string            $calendarId
     * @param string            $eventId
     * @param PatchEventRequest $request    PatchEventRequest
     *
     * @return PatchEventResponse PatchEventResponse
     */
    public function patchEvent($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PatchEventHeaders([]);

        return $this->patchEventWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除日程参与人
     *  *
     * @param string                $userId
     * @param string                $calendarId
     * @param string                $eventId
     * @param RemoveAttendeeRequest $request    RemoveAttendeeRequest
     * @param RemoveAttendeeHeaders $headers    RemoveAttendeeHeaders
     * @param RuntimeOptions        $runtime    runtime options for this request RuntimeOptions
     *
     * @return RemoveAttendeeResponse RemoveAttendeeResponse
     */
    public function removeAttendeeWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attendeesToRemove)) {
            $body['attendeesToRemove'] = $request->attendeesToRemove;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xClientToken)) {
            $realHeaders['x-client-token'] = Utils::toJSONString($headers->xClientToken);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RemoveAttendee',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/attendees/batchRemove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return RemoveAttendeeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除日程参与人
     *  *
     * @param string                $userId
     * @param string                $calendarId
     * @param string                $eventId
     * @param RemoveAttendeeRequest $request    RemoveAttendeeRequest
     *
     * @return RemoveAttendeeResponse RemoveAttendeeResponse
     */
    public function removeAttendee($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveAttendeeHeaders([]);

        return $this->removeAttendeeWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @summary 删除会议室
     *  *
     * @param string                    $userId
     * @param string                    $calendarId
     * @param string                    $eventId
     * @param RemoveMeetingRoomsRequest $request    RemoveMeetingRoomsRequest
     * @param RemoveMeetingRoomsHeaders $headers    RemoveMeetingRoomsHeaders
     * @param RuntimeOptions            $runtime    runtime options for this request RuntimeOptions
     *
     * @return RemoveMeetingRoomsResponse RemoveMeetingRoomsResponse
     */
    public function removeMeetingRoomsWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->meetingRoomsToRemove)) {
            $body['meetingRoomsToRemove'] = $request->meetingRoomsToRemove;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xClientToken)) {
            $realHeaders['x-client-token'] = Utils::toJSONString($headers->xClientToken);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RemoveMeetingRooms',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/meetingRooms/batchRemove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RemoveMeetingRoomsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除会议室
     *  *
     * @param string                    $userId
     * @param string                    $calendarId
     * @param string                    $eventId
     * @param RemoveMeetingRoomsRequest $request    RemoveMeetingRoomsRequest
     *
     * @return RemoveMeetingRoomsResponse RemoveMeetingRoomsResponse
     */
    public function removeMeetingRooms($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveMeetingRoomsHeaders([]);

        return $this->removeMeetingRoomsWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @summary 回复日程邀请
     *  *
     * @param string              $userId
     * @param string              $calendarId
     * @param string              $eventId
     * @param RespondEventRequest $request    RespondEventRequest
     * @param RespondEventHeaders $headers    RespondEventHeaders
     * @param RuntimeOptions      $runtime    runtime options for this request RuntimeOptions
     *
     * @return RespondEventResponse RespondEventResponse
     */
    public function respondEventWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->responseStatus)) {
            $body['responseStatus'] = $request->responseStatus;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xClientToken)) {
            $realHeaders['x-client-token'] = Utils::toJSONString($headers->xClientToken);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RespondEvent',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/respond',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return RespondEventResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 回复日程邀请
     *  *
     * @param string              $userId
     * @param string              $calendarId
     * @param string              $eventId
     * @param RespondEventRequest $request    RespondEventRequest
     *
     * @return RespondEventResponse RespondEventResponse
     */
    public function respondEvent($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RespondEventHeaders([]);

        return $this->respondEventWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @summary 签到
     *  *
     * @param string         $userId
     * @param string         $calendarId
     * @param string         $eventId
     * @param SignInHeaders  $headers    SignInHeaders
     * @param RuntimeOptions $runtime    runtime options for this request RuntimeOptions
     *
     * @return SignInResponse SignInResponse
     */
    public function signInWithOptions($userId, $calendarId, $eventId, $headers, $runtime)
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
            'action'      => 'SignIn',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/signin',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SignInResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 签到
     *  *
     * @param string $userId
     * @param string $calendarId
     * @param string $eventId
     *
     * @return SignInResponse SignInResponse
     */
    public function signIn($userId, $calendarId, $eventId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SignInHeaders([]);

        return $this->signInWithOptions($userId, $calendarId, $eventId, $headers, $runtime);
    }

    /**
     * @summary 签退
     *  *
     * @param string         $userId
     * @param string         $calendarId
     * @param string         $eventId
     * @param SignOutHeaders $headers    SignOutHeaders
     * @param RuntimeOptions $runtime    runtime options for this request RuntimeOptions
     *
     * @return SignOutResponse SignOutResponse
     */
    public function signOutWithOptions($userId, $calendarId, $eventId, $headers, $runtime)
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
            'action'      => 'SignOut',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/signOut',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SignOutResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 签退
     *  *
     * @param string $userId
     * @param string $calendarId
     * @param string $eventId
     *
     * @return SignOutResponse SignOutResponse
     */
    public function signOut($userId, $calendarId, $eventId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SignOutHeaders([]);

        return $this->signOutWithOptions($userId, $calendarId, $eventId, $headers, $runtime);
    }

    /**
     * @summary 订阅公共日历
     *  *
     * @param string                   $userId
     * @param string                   $calendarId
     * @param SubscribeCalendarHeaders $headers    SubscribeCalendarHeaders
     * @param RuntimeOptions           $runtime    runtime options for this request RuntimeOptions
     *
     * @return SubscribeCalendarResponse SubscribeCalendarResponse
     */
    public function subscribeCalendarWithOptions($userId, $calendarId, $headers, $runtime)
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
            'action'      => 'SubscribeCalendar',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/subscribe',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return SubscribeCalendarResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 订阅公共日历
     *  *
     * @param string $userId
     * @param string $calendarId
     *
     * @return SubscribeCalendarResponse SubscribeCalendarResponse
     */
    public function subscribeCalendar($userId, $calendarId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SubscribeCalendarHeaders([]);

        return $this->subscribeCalendarWithOptions($userId, $calendarId, $headers, $runtime);
    }

    /**
     * @summary 日程转让
     *  *
     * @param string               $calendarId
     * @param string               $userId
     * @param string               $eventId
     * @param TransferEventRequest $request    TransferEventRequest
     * @param TransferEventHeaders $headers    TransferEventHeaders
     * @param RuntimeOptions       $runtime    runtime options for this request RuntimeOptions
     *
     * @return TransferEventResponse TransferEventResponse
     */
    public function transferEventWithOptions($calendarId, $userId, $eventId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->isExitCalendar)) {
            $body['isExitCalendar'] = $request->isExitCalendar;
        }
        if (!Utils::isUnset($request->needNotifyViaO2O)) {
            $body['needNotifyViaO2O'] = $request->needNotifyViaO2O;
        }
        if (!Utils::isUnset($request->newOrganizerId)) {
            $body['newOrganizerId'] = $request->newOrganizerId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xClientToken)) {
            $realHeaders['x-client-token'] = Utils::toJSONString($headers->xClientToken);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'TransferEvent',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/transfer',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return TransferEventResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 日程转让
     *  *
     * @param string               $calendarId
     * @param string               $userId
     * @param string               $eventId
     * @param TransferEventRequest $request    TransferEventRequest
     *
     * @return TransferEventResponse TransferEventResponse
     */
    public function transferEvent($calendarId, $userId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TransferEventHeaders([]);

        return $this->transferEventWithOptions($calendarId, $userId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @summary 取消订阅公共日历
     *  *
     * @param string                     $userId
     * @param string                     $calendarId
     * @param UnsubscribeCalendarHeaders $headers    UnsubscribeCalendarHeaders
     * @param RuntimeOptions             $runtime    runtime options for this request RuntimeOptions
     *
     * @return UnsubscribeCalendarResponse UnsubscribeCalendarResponse
     */
    public function unsubscribeCalendarWithOptions($userId, $calendarId, $headers, $runtime)
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
            'action'      => 'UnsubscribeCalendar',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/unsubscribe',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UnsubscribeCalendarResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 取消订阅公共日历
     *  *
     * @param string $userId
     * @param string $calendarId
     *
     * @return UnsubscribeCalendarResponse UnsubscribeCalendarResponse
     */
    public function unsubscribeCalendar($userId, $calendarId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnsubscribeCalendarHeaders([]);

        return $this->unsubscribeCalendarWithOptions($userId, $calendarId, $headers, $runtime);
    }

    /**
     * @summary 更新指定订阅日历
     *  *
     * @param string                           $calendarId
     * @param string                           $userId
     * @param UpdateSubscribedCalendarsRequest $request    UpdateSubscribedCalendarsRequest
     * @param UpdateSubscribedCalendarsHeaders $headers    UpdateSubscribedCalendarsHeaders
     * @param RuntimeOptions                   $runtime    runtime options for this request RuntimeOptions
     *
     * @return UpdateSubscribedCalendarsResponse UpdateSubscribedCalendarsResponse
     */
    public function updateSubscribedCalendarsWithOptions($calendarId, $userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->managers)) {
            $body['managers'] = $request->managers;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->subscribeScope)) {
            $body['subscribeScope'] = $request->subscribeScope;
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
            'action'      => 'UpdateSubscribedCalendars',
            'version'     => 'calendar_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/calendar/users/' . $userId . '/subscribedCalendars/' . $calendarId . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateSubscribedCalendarsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新指定订阅日历
     *  *
     * @param string                           $calendarId
     * @param string                           $userId
     * @param UpdateSubscribedCalendarsRequest $request    UpdateSubscribedCalendarsRequest
     *
     * @return UpdateSubscribedCalendarsResponse UpdateSubscribedCalendarsResponse
     */
    public function updateSubscribedCalendars($calendarId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateSubscribedCalendarsHeaders([]);

        return $this->updateSubscribedCalendarsWithOptions($calendarId, $userId, $request, $headers, $runtime);
    }
}
