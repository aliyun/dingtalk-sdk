<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\AddAttendeeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\AddAttendeeResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\DeleteEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\DeleteEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetScheduleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetScheduleResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RemoveAttendeeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RemoveAttendeeResponse;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RespondEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RespondEventResponse;
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
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return DeleteEventResponse::fromMap($this->doROARequest('DeleteEvent', 'calendar_1.0', 'HTTP', 'DELETE', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     * @param string $calendarId
     * @param string $eventId
     *
     * @return RespondEventResponse
     */
    public function respondEvent($userId, $calendarId, $eventId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RespondEventHeaders([]);

        return $this->respondEventWithOptions($userId, $calendarId, $eventId, $headers, $runtime);
    }

    /**
     * @param string              $userId
     * @param string              $calendarId
     * @param string              $eventId
     * @param RespondEventHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return RespondEventResponse
     */
    public function respondEventWithOptions($userId, $calendarId, $eventId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return RespondEventResponse::fromMap($this->doROARequest('RespondEvent', 'calendar_1.0', 'HTTP', 'POST', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/respond', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     * @param string $calendarId
     *
     * @return ListEventsResponse
     */
    public function listEvents($userId, $calendarId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListEventsHeaders([]);

        return $this->listEventsWithOptions($userId, $calendarId, $headers, $runtime);
    }

    /**
     * @param string            $userId
     * @param string            $calendarId
     * @param ListEventsHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return ListEventsResponse
     */
    public function listEventsWithOptions($userId, $calendarId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return ListEventsResponse::fromMap($this->doROARequest('ListEvents', 'calendar_1.0', 'HTTP', 'GET', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     *
     * @return GetScheduleResponse
     */
    public function getSchedule($userId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetScheduleHeaders([]);

        return $this->getScheduleWithOptions($userId, $headers, $runtime);
    }

    /**
     * @param string             $userId
     * @param GetScheduleHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetScheduleResponse
     */
    public function getScheduleWithOptions($userId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetScheduleResponse::fromMap($this->doROARequest('GetSchedule', 'calendar_1.0', 'HTTP', 'POST', 'AK', '/v1.0/calendar/users/' . $userId . '/getSchedule', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     * @param string $calendarId
     * @param string $eventId
     *
     * @return RemoveAttendeeResponse
     */
    public function removeAttendee($userId, $calendarId, $eventId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveAttendeeHeaders([]);

        return $this->removeAttendeeWithOptions($userId, $calendarId, $eventId, $headers, $runtime);
    }

    /**
     * @param string                $userId
     * @param string                $calendarId
     * @param string                $eventId
     * @param RemoveAttendeeHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return RemoveAttendeeResponse
     */
    public function removeAttendeeWithOptions($userId, $calendarId, $eventId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return RemoveAttendeeResponse::fromMap($this->doROARequest('RemoveAttendee', 'calendar_1.0', 'HTTP', 'POST', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/attendees/batchRemove', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     * @param string $calendarId
     * @param string $eventId
     *
     * @return AddAttendeeResponse
     */
    public function addAttendee($userId, $calendarId, $eventId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddAttendeeHeaders([]);

        return $this->addAttendeeWithOptions($userId, $calendarId, $eventId, $headers, $runtime);
    }

    /**
     * @param string             $userId
     * @param string             $calendarId
     * @param string             $eventId
     * @param AddAttendeeHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return AddAttendeeResponse
     */
    public function addAttendeeWithOptions($userId, $calendarId, $eventId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return AddAttendeeResponse::fromMap($this->doROARequest('AddAttendee', 'calendar_1.0', 'HTTP', 'POST', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '/attendees', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     * @param string $calendarId
     * @param string $eventId
     *
     * @return GetEventResponse
     */
    public function getEvent($userId, $calendarId, $eventId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetEventHeaders([]);

        return $this->getEventWithOptions($userId, $calendarId, $eventId, $headers, $runtime);
    }

    /**
     * @param string          $userId
     * @param string          $calendarId
     * @param string          $eventId
     * @param GetEventHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return GetEventResponse
     */
    public function getEventWithOptions($userId, $calendarId, $eventId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetEventResponse::fromMap($this->doROARequest('GetEvent', 'calendar_1.0', 'HTTP', 'GET', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     * @param string $calendarId
     * @param string $eventId
     *
     * @return PatchEventResponse
     */
    public function patchEvent($userId, $calendarId, $eventId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PatchEventHeaders([]);

        return $this->patchEventWithOptions($userId, $calendarId, $eventId, $headers, $runtime);
    }

    /**
     * @param string            $userId
     * @param string            $calendarId
     * @param string            $eventId
     * @param PatchEventHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return PatchEventResponse
     */
    public function patchEventWithOptions($userId, $calendarId, $eventId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return PatchEventResponse::fromMap($this->doROARequest('PatchEvent', 'calendar_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events/' . $eventId . '', 'json', $req, $runtime));
    }

    /**
     * @param string $userId
     * @param string $calendarId
     *
     * @return CreateEventResponse
     */
    public function createEvent($userId, $calendarId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateEventHeaders([]);

        return $this->createEventWithOptions($userId, $calendarId, $headers, $runtime);
    }

    /**
     * @param string             $userId
     * @param string             $calendarId
     * @param CreateEventHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return CreateEventResponse
     */
    public function createEventWithOptions($userId, $calendarId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return CreateEventResponse::fromMap($this->doROARequest('CreateEvent', 'calendar_1.0', 'HTTP', 'POST', 'AK', '/v1.0/calendar/users/' . $userId . '/calendars/' . $calendarId . '/events', 'json', $req, $runtime));
    }
}
