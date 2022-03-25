<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\AddAttendeeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\AddAttendeeRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\AddAttendeeResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\DeleteAclHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\DeleteAclResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\DeleteEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\DeleteEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GenerateCaldavAccountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GenerateCaldavAccountRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GenerateCaldavAccountResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetScheduleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetScheduleRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetScheduleResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignInListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignInListRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignInListResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RemoveAttendeeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RemoveAttendeeRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RemoveAttendeeResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RespondEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RespondEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RespondEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\SignInHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\SignInResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\SubscribeCalendarHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\SubscribeCalendarResponse;
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
        $userId     = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId = OpenApiUtilClient::getEncodeParam($calendarId);
        $eventId    = OpenApiUtilClient::getEncodeParam($eventId);
        $body       = [];
        if (!Utils::isUnset($request->attendeesToAdd)) {
            @$body['attendeesToAdd'] = $request->attendeesToAdd;
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

        return AddAttendeeResponse::fromMap($this->doROARequest('AddAttendee', 'calendar_1.0', 'HTTP', 'POST', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/attendees', 'none', $req, $runtime));
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
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId  = OpenApiUtilClient::getEncodeParam($calendarId);
        $eventId     = OpenApiUtilClient::getEncodeParam($eventId);
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

        return CheckInResponse::fromMap($this->doROARequest('CheckIn', 'calendar_1.0', 'HTTP', 'POST', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/checkIn', 'json', $req, $runtime));
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
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->legacyEventIds)) {
            @$body['legacyEventIds'] = $request->legacyEventIds;
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

        return ConvertLegacyEventIdResponse::fromMap($this->doROARequest('ConvertLegacyEventId', 'calendar_1.0', 'HTTP', 'POST', 'AK', '/v1.0/calendar/users/' . $userId . '/legacyEventIds/convert', 'json', $req, $runtime));
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
        $userId     = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId = OpenApiUtilClient::getEncodeParam($calendarId);
        $body       = [];
        if (!Utils::isUnset($request->privilege)) {
            @$body['privilege'] = $request->privilege;
        }
        if (!Utils::isUnset($request->scope)) {
            @$body['scope'] = $request->scope;
        }
        if (!Utils::isUnset($request->sendMsg)) {
            @$body['sendMsg'] = $request->sendMsg;
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

        return CreateAclsResponse::fromMap($this->doROARequest('CreateAcls', 'calendar_1.0', 'HTTP', 'POST', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/acls', 'json', $req, $runtime));
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
        $userId     = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId = OpenApiUtilClient::getEncodeParam($calendarId);
        $body       = [];
        if (!Utils::isUnset($request->attendees)) {
            @$body['attendees'] = $request->attendees;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->end)) {
            @$body['end'] = $request->end;
        }
        if (!Utils::isUnset($request->extra)) {
            @$body['extra'] = $request->extra;
        }
        if (!Utils::isUnset($request->isAllDay)) {
            @$body['isAllDay'] = $request->isAllDay;
        }
        if (!Utils::isUnset($request->location)) {
            @$body['location'] = $request->location;
        }
        if (!Utils::isUnset($request->onlineMeetingInfo)) {
            @$body['onlineMeetingInfo'] = $request->onlineMeetingInfo;
        }
        if (!Utils::isUnset($request->recurrence)) {
            @$body['recurrence'] = $request->recurrence;
        }
        if (!Utils::isUnset($request->reminders)) {
            @$body['reminders'] = $request->reminders;
        }
        if (!Utils::isUnset($request->start)) {
            @$body['start'] = $request->start;
        }
        if (!Utils::isUnset($request->summary)) {
            @$body['summary'] = $request->summary;
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

        return CreateEventResponse::fromMap($this->doROARequest('CreateEvent', 'calendar_1.0', 'HTTP', 'POST', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events', 'json', $req, $runtime));
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
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId  = OpenApiUtilClient::getEncodeParam($calendarId);
        $aclId       = OpenApiUtilClient::getEncodeParam($aclId);
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

        return DeleteAclResponse::fromMap($this->doROARequest('DeleteAcl', 'calendar_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/acls/' . $aclId . '', 'none', $req, $runtime));
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
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId  = OpenApiUtilClient::getEncodeParam($calendarId);
        $eventId     = OpenApiUtilClient::getEncodeParam($eventId);
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

        return DeleteEventResponse::fromMap($this->doROARequest('DeleteEvent', 'calendar_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '', 'none', $req, $runtime));
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
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->device)) {
            @$body['device'] = $request->device;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->dingUid)) {
            @$realHeaders['dingUid'] = Utils::toJSONString($headers->dingUid);
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GenerateCaldavAccountResponse::fromMap($this->doROARequest('GenerateCaldavAccount', 'calendar_1.0', 'HTTP', 'POST', 'AK', '/v1.0/calendar/users/' . $userId . '/caldavAccounts', 'json', $req, $runtime));
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
        $userId     = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId = OpenApiUtilClient::getEncodeParam($calendarId);
        $eventId    = OpenApiUtilClient::getEncodeParam($eventId);
        $query      = [];
        if (!Utils::isUnset($request->maxAttendees)) {
            @$query['maxAttendees'] = $request->maxAttendees;
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

        return GetEventResponse::fromMap($this->doROARequest('GetEvent', 'calendar_1.0', 'HTTP', 'GET', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '', 'json', $req, $runtime));
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
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $body   = [];
        if (!Utils::isUnset($request->endTime)) {
            @$body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$body['startTime'] = $request->startTime;
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

        return GetScheduleResponse::fromMap($this->doROARequest('GetSchedule', 'calendar_1.0', 'HTTP', 'POST', 'AK', '/v1.0/calendar/users/' . $userId . '/querySchedule', 'json', $req, $runtime));
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
        $userId     = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId = OpenApiUtilClient::getEncodeParam($calendarId);
        $eventId    = OpenApiUtilClient::getEncodeParam($eventId);
        $query      = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->type)) {
            @$query['type'] = $request->type;
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

        return GetSignInListResponse::fromMap($this->doROARequest('GetSignInList', 'calendar_1.0', 'HTTP', 'GET', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/signin', 'json', $req, $runtime));
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
     * @param string          $userId
     * @param string          $calendarId
     * @param ListAclsHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return ListAclsResponse
     */
    public function listAclsWithOptions($userId, $calendarId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId  = OpenApiUtilClient::getEncodeParam($calendarId);
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

        return ListAclsResponse::fromMap($this->doROARequest('ListAcls', 'calendar_1.0', 'HTTP', 'GET', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/acls', 'json', $req, $runtime));
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
        $userId     = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId = OpenApiUtilClient::getEncodeParam($calendarId);
        $eventId    = OpenApiUtilClient::getEncodeParam($eventId);
        $query      = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
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

        return ListAttendeesResponse::fromMap($this->doROARequest('ListAttendees', 'calendar_1.0', 'HTTP', 'GET', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/attendees', 'json', $req, $runtime));
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
     * @param string               $userId
     * @param ListCalendarsHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return ListCalendarsResponse
     */
    public function listCalendarsWithOptions($userId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
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

        return ListCalendarsResponse::fromMap($this->doROARequest('ListCalendars', 'calendar_1.0', 'HTTP', 'GET', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars', 'json', $req, $runtime));
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
        $userId     = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId = OpenApiUtilClient::getEncodeParam($calendarId);
        $query      = [];
        if (!Utils::isUnset($request->maxAttendees)) {
            @$query['maxAttendees'] = $request->maxAttendees;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->showDeleted)) {
            @$query['showDeleted'] = $request->showDeleted;
        }
        if (!Utils::isUnset($request->syncToken)) {
            @$query['syncToken'] = $request->syncToken;
        }
        if (!Utils::isUnset($request->timeMax)) {
            @$query['timeMax'] = $request->timeMax;
        }
        if (!Utils::isUnset($request->timeMin)) {
            @$query['timeMin'] = $request->timeMin;
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

        return ListEventsResponse::fromMap($this->doROARequest('ListEvents', 'calendar_1.0', 'HTTP', 'GET', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events', 'json', $req, $runtime));
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
        $userId     = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId = OpenApiUtilClient::getEncodeParam($calendarId);
        $query      = [];
        if (!Utils::isUnset($request->maxAttendees)) {
            @$query['maxAttendees'] = $request->maxAttendees;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->seriesMasterId)) {
            @$query['seriesMasterId'] = $request->seriesMasterId;
        }
        if (!Utils::isUnset($request->startRecurrenceId)) {
            @$query['startRecurrenceId'] = $request->startRecurrenceId;
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

        return ListEventsInstancesResponse::fromMap($this->doROARequest('ListEventsInstances', 'calendar_1.0', 'HTTP', 'GET', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/instances', 'json', $req, $runtime));
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
        $userId     = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId = OpenApiUtilClient::getEncodeParam($calendarId);
        $query      = [];
        if (!Utils::isUnset($request->maxAttendees)) {
            @$query['maxAttendees'] = $request->maxAttendees;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->timeMax)) {
            @$query['timeMax'] = $request->timeMax;
        }
        if (!Utils::isUnset($request->timeMin)) {
            @$query['timeMin'] = $request->timeMin;
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

        return ListEventsViewResponse::fromMap($this->doROARequest('ListEventsView', 'calendar_1.0', 'HTTP', 'GET', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/eventsview', 'json', $req, $runtime));
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
        $userId     = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId = OpenApiUtilClient::getEncodeParam($calendarId);
        $eventId    = OpenApiUtilClient::getEncodeParam($eventId);
        $body       = [];
        if (!Utils::isUnset($request->attendees)) {
            @$body['attendees'] = $request->attendees;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->end)) {
            @$body['end'] = $request->end;
        }
        if (!Utils::isUnset($request->extra)) {
            @$body['extra'] = $request->extra;
        }
        if (!Utils::isUnset($request->id)) {
            @$body['id'] = $request->id;
        }
        if (!Utils::isUnset($request->isAllDay)) {
            @$body['isAllDay'] = $request->isAllDay;
        }
        if (!Utils::isUnset($request->location)) {
            @$body['location'] = $request->location;
        }
        if (!Utils::isUnset($request->recurrence)) {
            @$body['recurrence'] = $request->recurrence;
        }
        if (!Utils::isUnset($request->reminders)) {
            @$body['reminders'] = $request->reminders;
        }
        if (!Utils::isUnset($request->start)) {
            @$body['start'] = $request->start;
        }
        if (!Utils::isUnset($request->summary)) {
            @$body['summary'] = $request->summary;
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

        return PatchEventResponse::fromMap($this->doROARequest('PatchEvent', 'calendar_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '', 'json', $req, $runtime));
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
        $userId     = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId = OpenApiUtilClient::getEncodeParam($calendarId);
        $eventId    = OpenApiUtilClient::getEncodeParam($eventId);
        $body       = [];
        if (!Utils::isUnset($request->attendeesToRemove)) {
            @$body['attendeesToRemove'] = $request->attendeesToRemove;
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

        return RemoveAttendeeResponse::fromMap($this->doROARequest('RemoveAttendee', 'calendar_1.0', 'HTTP', 'POST', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/attendees/batchRemove', 'none', $req, $runtime));
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
        $userId     = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId = OpenApiUtilClient::getEncodeParam($calendarId);
        $eventId    = OpenApiUtilClient::getEncodeParam($eventId);
        $body       = [];
        if (!Utils::isUnset($request->responseStatus)) {
            @$body['responseStatus'] = $request->responseStatus;
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

        return RespondEventResponse::fromMap($this->doROARequest('RespondEvent', 'calendar_1.0', 'HTTP', 'POST', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/respond', 'none', $req, $runtime));
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
     * @param SignInHeaders  $headers
     * @param RuntimeOptions $runtime
     *
     * @return SignInResponse
     */
    public function signInWithOptions($userId, $calendarId, $eventId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId  = OpenApiUtilClient::getEncodeParam($calendarId);
        $eventId     = OpenApiUtilClient::getEncodeParam($eventId);
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

        return SignInResponse::fromMap($this->doROARequest('SignIn', 'calendar_1.0', 'HTTP', 'POST', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/signin', 'json', $req, $runtime));
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
     * @param string                   $userId
     * @param string                   $calendarId
     * @param SubscribeCalendarHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return SubscribeCalendarResponse
     */
    public function subscribeCalendarWithOptions($userId, $calendarId, $headers, $runtime)
    {
        $userId      = OpenApiUtilClient::getEncodeParam($userId);
        $calendarId  = OpenApiUtilClient::getEncodeParam($calendarId);
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

        return SubscribeCalendarResponse::fromMap($this->doROARequest('SubscribeCalendar', 'calendar_1.0', 'HTTP', 'POST', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/subscribe', 'none', $req, $runtime));
    }
}
