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
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateSubscribedCalendarHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateSubscribedCalendarRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateSubscribedCalendarResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\DeleteAclHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\DeleteAclResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\DeleteEventHeaders;
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
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignInListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignInListRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignInListResponse;
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
     * @param string             $userId
     * @param string             $calendarId
     * @param string             $eventId
     * @param AddAttendeeRequest $request
     * @param AddAttendeeHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return AddAttendeeResponse
     */
    public function addAttendeeWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->attendeesToAdd)) {
            $body['attendeesToAdd'] = $request->attendeesToAdd;
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
     * @param string             $userId
     * @param string             $calendarId
     * @param string             $eventId
     * @param AddAttendeeRequest $request
     *
     * @return AddAttendeeResponse
     */
    public function addAttendee($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddAttendeeHeaders([]);

        return $this->addAttendeeWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $userId
     * @param string                 $calendarId
     * @param string                 $eventId
     * @param AddMeetingRoomsRequest $request
     * @param AddMeetingRoomsHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return AddMeetingRoomsResponse
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
     * @param string                 $userId
     * @param string                 $calendarId
     * @param string                 $eventId
     * @param AddMeetingRoomsRequest $request
     *
     * @return AddMeetingRoomsResponse
     */
    public function addMeetingRooms($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddMeetingRoomsHeaders([]);

        return $this->addMeetingRoomsWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @param string         $userId
     * @param string         $calendarId
     * @param string         $eventId
     * @param CheckInHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return CheckInResponse
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
     * @param string $userId
     * @param string $calendarId
     * @param string $eventId
     *
     * @return CheckInResponse
     */
    public function checkIn($userId, $calendarId, $eventId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckInHeaders([]);

        return $this->checkInWithOptions($userId, $calendarId, $eventId, $headers, $runtime);
    }

    /**
     * @param string                      $userId
     * @param ConvertLegacyEventIdRequest $request
     * @param ConvertLegacyEventIdHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return ConvertLegacyEventIdResponse
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
     * @param string                      $userId
     * @param ConvertLegacyEventIdRequest $request
     *
     * @return ConvertLegacyEventIdResponse
     */
    public function convertLegacyEventId($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConvertLegacyEventIdHeaders([]);

        return $this->convertLegacyEventIdWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string            $userId
     * @param string            $calendarId
     * @param CreateAclsRequest $request
     * @param CreateAclsHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return CreateAclsResponse
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
     * @param string            $userId
     * @param string            $calendarId
     * @param CreateAclsRequest $request
     *
     * @return CreateAclsResponse
     */
    public function createAcls($userId, $calendarId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateAclsHeaders([]);

        return $this->createAclsWithOptions($userId, $calendarId, $request, $headers, $runtime);
    }

    /**
     * @param string             $userId
     * @param string             $calendarId
     * @param CreateEventRequest $request
     * @param CreateEventHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return CreateEventResponse
     */
    public function createEventWithOptions($userId, $calendarId, $request, $headers, $runtime)
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
     * @param string             $userId
     * @param string             $calendarId
     * @param CreateEventRequest $request
     *
     * @return CreateEventResponse
     */
    public function createEvent($userId, $calendarId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateEventHeaders([]);

        return $this->createEventWithOptions($userId, $calendarId, $request, $headers, $runtime);
    }

    /**
     * @param string                          $userId
     * @param CreateSubscribedCalendarRequest $request
     * @param CreateSubscribedCalendarHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return CreateSubscribedCalendarResponse
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
     * @param string                          $userId
     * @param CreateSubscribedCalendarRequest $request
     *
     * @return CreateSubscribedCalendarResponse
     */
    public function createSubscribedCalendar($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSubscribedCalendarHeaders([]);

        return $this->createSubscribedCalendarWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string           $userId
     * @param string           $calendarId
     * @param string           $aclId
     * @param DeleteAclHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return DeleteAclResponse
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
     * @param string $userId
     * @param string $calendarId
     * @param string $aclId
     *
     * @return DeleteAclResponse
     */
    public function deleteAcl($userId, $calendarId, $aclId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteAclHeaders([]);

        return $this->deleteAclWithOptions($userId, $calendarId, $aclId, $headers, $runtime);
    }

    /**
     * @param string             $userId
     * @param string             $calendarId
     * @param string             $eventId
     * @param DeleteEventHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return DeleteEventResponse
     */
    public function deleteEventWithOptions($userId, $calendarId, $eventId, $headers, $runtime)
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
     * @param string $userId
     * @param string $calendarId
     * @param string $eventId
     *
     * @return DeleteEventResponse
     */
    public function deleteEvent($userId, $calendarId, $eventId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteEventHeaders([]);

        return $this->deleteEventWithOptions($userId, $calendarId, $eventId, $headers, $runtime);
    }

    /**
     * @param string                          $userId
     * @param string                          $calendarId
     * @param DeleteSubscribedCalendarHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return DeleteSubscribedCalendarResponse
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
     * @param string $userId
     * @param string $calendarId
     *
     * @return DeleteSubscribedCalendarResponse
     */
    public function deleteSubscribedCalendar($userId, $calendarId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteSubscribedCalendarHeaders([]);

        return $this->deleteSubscribedCalendarWithOptions($userId, $calendarId, $headers, $runtime);
    }

    /**
     * @param string                       $userId
     * @param GenerateCaldavAccountRequest $request
     * @param GenerateCaldavAccountHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GenerateCaldavAccountResponse
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
     * @param string                       $userId
     * @param GenerateCaldavAccountRequest $request
     *
     * @return GenerateCaldavAccountResponse
     */
    public function generateCaldavAccount($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GenerateCaldavAccountHeaders([]);

        return $this->generateCaldavAccountWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string          $userId
     * @param string          $calendarId
     * @param string          $eventId
     * @param GetEventRequest $request
     * @param GetEventHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return GetEventResponse
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
     * @param string          $userId
     * @param string          $calendarId
     * @param string          $eventId
     * @param GetEventRequest $request
     *
     * @return GetEventResponse
     */
    public function getEvent($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetEventHeaders([]);

        return $this->getEventWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @param string                         $userId
     * @param GetMeetingRoomsScheduleRequest $request
     * @param GetMeetingRoomsScheduleHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return GetMeetingRoomsScheduleResponse
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
     * @param string                         $userId
     * @param GetMeetingRoomsScheduleRequest $request
     *
     * @return GetMeetingRoomsScheduleResponse
     */
    public function getMeetingRoomsSchedule($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMeetingRoomsScheduleHeaders([]);

        return $this->getMeetingRoomsScheduleWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string             $userId
     * @param GetScheduleRequest $request
     * @param GetScheduleHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetScheduleResponse
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
     * @param string             $userId
     * @param GetScheduleRequest $request
     *
     * @return GetScheduleResponse
     */
    public function getSchedule($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetScheduleHeaders([]);

        return $this->getScheduleWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string               $userId
     * @param string               $calendarId
     * @param string               $eventId
     * @param GetSignInListRequest $request
     * @param GetSignInListHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return GetSignInListResponse
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
     * @param string               $userId
     * @param string               $calendarId
     * @param string               $eventId
     * @param GetSignInListRequest $request
     *
     * @return GetSignInListResponse
     */
    public function getSignInList($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSignInListHeaders([]);

        return $this->getSignInListWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param string                $calendarId
     * @param string                $eventId
     * @param GetSignOutListRequest $request
     * @param GetSignOutListHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetSignOutListResponse
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
     * @param string                $userId
     * @param string                $calendarId
     * @param string                $eventId
     * @param GetSignOutListRequest $request
     *
     * @return GetSignOutListResponse
     */
    public function getSignOutList($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSignOutListHeaders([]);

        return $this->getSignOutListWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @param string                       $userId
     * @param string                       $calendarId
     * @param GetSubscribedCalendarHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GetSubscribedCalendarResponse
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
     * @param string $userId
     * @param string $calendarId
     *
     * @return GetSubscribedCalendarResponse
     */
    public function getSubscribedCalendar($userId, $calendarId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSubscribedCalendarHeaders([]);

        return $this->getSubscribedCalendarWithOptions($userId, $calendarId, $headers, $runtime);
    }

    /**
     * @param string          $userId
     * @param string          $calendarId
     * @param ListAclsHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return ListAclsResponse
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
     * @param string $userId
     * @param string $calendarId
     *
     * @return ListAclsResponse
     */
    public function listAcls($userId, $calendarId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAclsHeaders([]);

        return $this->listAclsWithOptions($userId, $calendarId, $headers, $runtime);
    }

    /**
     * @param string               $userId
     * @param string               $calendarId
     * @param string               $eventId
     * @param ListAttendeesRequest $request
     * @param ListAttendeesHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return ListAttendeesResponse
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
     * @param string               $userId
     * @param string               $calendarId
     * @param string               $eventId
     * @param ListAttendeesRequest $request
     *
     * @return ListAttendeesResponse
     */
    public function listAttendees($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListAttendeesHeaders([]);

        return $this->listAttendeesWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @param string               $userId
     * @param ListCalendarsHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return ListCalendarsResponse
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
     * @param string $userId
     *
     * @return ListCalendarsResponse
     */
    public function listCalendars($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListCalendarsHeaders([]);

        return $this->listCalendarsWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string            $userId
     * @param string            $calendarId
     * @param ListEventsRequest $request
     * @param ListEventsHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return ListEventsResponse
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
     * @param string            $userId
     * @param string            $calendarId
     * @param ListEventsRequest $request
     *
     * @return ListEventsResponse
     */
    public function listEvents($userId, $calendarId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListEventsHeaders([]);

        return $this->listEventsWithOptions($userId, $calendarId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $userId
     * @param string                     $calendarId
     * @param ListEventsInstancesRequest $request
     * @param ListEventsInstancesHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return ListEventsInstancesResponse
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
     * @param string                     $userId
     * @param string                     $calendarId
     * @param ListEventsInstancesRequest $request
     *
     * @return ListEventsInstancesResponse
     */
    public function listEventsInstances($userId, $calendarId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListEventsInstancesHeaders([]);

        return $this->listEventsInstancesWithOptions($userId, $calendarId, $request, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param string                $calendarId
     * @param ListEventsViewRequest $request
     * @param ListEventsViewHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return ListEventsViewResponse
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
     * @param string                $userId
     * @param string                $calendarId
     * @param ListEventsViewRequest $request
     *
     * @return ListEventsViewResponse
     */
    public function listEventsView($userId, $calendarId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListEventsViewHeaders([]);

        return $this->listEventsViewWithOptions($userId, $calendarId, $request, $headers, $runtime);
    }

    /**
     * @param string               $userId
     * @param string               $calendarId
     * @param string               $eventId
     * @param ListInstancesRequest $request
     * @param ListInstancesHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return ListInstancesResponse
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
     * @param string               $userId
     * @param string               $calendarId
     * @param string               $eventId
     * @param ListInstancesRequest $request
     *
     * @return ListInstancesResponse
     */
    public function listInstances($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListInstancesHeaders([]);

        return $this->listInstancesWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @param string            $userId
     * @param string            $calendarId
     * @param string            $eventId
     * @param PatchEventRequest $request
     * @param PatchEventHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return PatchEventResponse
     */
    public function patchEventWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime)
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
     * @param string            $userId
     * @param string            $calendarId
     * @param string            $eventId
     * @param PatchEventRequest $request
     *
     * @return PatchEventResponse
     */
    public function patchEvent($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PatchEventHeaders([]);

        return $this->patchEventWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param string                $calendarId
     * @param string                $eventId
     * @param RemoveAttendeeRequest $request
     * @param RemoveAttendeeHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return RemoveAttendeeResponse
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
     * @param string                $userId
     * @param string                $calendarId
     * @param string                $eventId
     * @param RemoveAttendeeRequest $request
     *
     * @return RemoveAttendeeResponse
     */
    public function removeAttendee($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveAttendeeHeaders([]);

        return $this->removeAttendeeWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @param string                    $userId
     * @param string                    $calendarId
     * @param string                    $eventId
     * @param RemoveMeetingRoomsRequest $request
     * @param RemoveMeetingRoomsHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return RemoveMeetingRoomsResponse
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
     * @param string                    $userId
     * @param string                    $calendarId
     * @param string                    $eventId
     * @param RemoveMeetingRoomsRequest $request
     *
     * @return RemoveMeetingRoomsResponse
     */
    public function removeMeetingRooms($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveMeetingRoomsHeaders([]);

        return $this->removeMeetingRoomsWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @param string              $userId
     * @param string              $calendarId
     * @param string              $eventId
     * @param RespondEventRequest $request
     * @param RespondEventHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return RespondEventResponse
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
     * @param string              $userId
     * @param string              $calendarId
     * @param string              $eventId
     * @param RespondEventRequest $request
     *
     * @return RespondEventResponse
     */
    public function respondEvent($userId, $calendarId, $eventId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RespondEventHeaders([]);

        return $this->respondEventWithOptions($userId, $calendarId, $eventId, $request, $headers, $runtime);
    }

    /**
     * @param string         $userId
     * @param string         $calendarId
     * @param string         $eventId
     * @param SignInHeaders  $headers
     * @param RuntimeOptions $runtime
     *
     * @return SignInResponse
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
     * @param string $userId
     * @param string $calendarId
     * @param string $eventId
     *
     * @return SignInResponse
     */
    public function signIn($userId, $calendarId, $eventId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SignInHeaders([]);

        return $this->signInWithOptions($userId, $calendarId, $eventId, $headers, $runtime);
    }

    /**
     * @param string         $userId
     * @param string         $calendarId
     * @param string         $eventId
     * @param SignOutHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return SignOutResponse
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
     * @param string $userId
     * @param string $calendarId
     * @param string $eventId
     *
     * @return SignOutResponse
     */
    public function signOut($userId, $calendarId, $eventId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SignOutHeaders([]);

        return $this->signOutWithOptions($userId, $calendarId, $eventId, $headers, $runtime);
    }

    /**
     * @param string                   $userId
     * @param string                   $calendarId
     * @param SubscribeCalendarHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return SubscribeCalendarResponse
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
     * @param string $userId
     * @param string $calendarId
     *
     * @return SubscribeCalendarResponse
     */
    public function subscribeCalendar($userId, $calendarId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SubscribeCalendarHeaders([]);

        return $this->subscribeCalendarWithOptions($userId, $calendarId, $headers, $runtime);
    }

    /**
     * @param string                     $userId
     * @param string                     $calendarId
     * @param UnsubscribeCalendarHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return UnsubscribeCalendarResponse
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
     * @param string $userId
     * @param string $calendarId
     *
     * @return UnsubscribeCalendarResponse
     */
    public function unsubscribeCalendar($userId, $calendarId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnsubscribeCalendarHeaders([]);

        return $this->unsubscribeCalendarWithOptions($userId, $calendarId, $headers, $runtime);
    }

    /**
     * @param string                           $calendarId
     * @param string                           $userId
     * @param UpdateSubscribedCalendarsRequest $request
     * @param UpdateSubscribedCalendarsHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return UpdateSubscribedCalendarsResponse
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
     * @param string                           $calendarId
     * @param string                           $userId
     * @param UpdateSubscribedCalendarsRequest $request
     *
     * @return UpdateSubscribedCalendarsResponse
     */
    public function updateSubscribedCalendars($calendarId, $userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateSubscribedCalendarsHeaders([]);

        return $this->updateSubscribedCalendarsWithOptions($calendarId, $userId, $request, $headers, $runtime);
    }
}
