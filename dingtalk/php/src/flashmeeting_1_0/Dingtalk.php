<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\CreateFlashMeetingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\CreateFlashMeetingRequest;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\CreateFlashMeetingResponse;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetShanhuiByCalendarHeaders;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetShanhuiByCalendarRequest;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetShanhuiByCalendarResponse;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetShanhuiByShanhuiKeyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetShanhuiByShanhuiKeyResponse;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetTaskFromShanhuiDocHeaders;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetTaskFromShanhuiDocRequest;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetTaskFromShanhuiDocResponse;
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
     * @param CreateFlashMeetingRequest $request
     * @param CreateFlashMeetingHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return CreateFlashMeetingResponse
     */
    public function createFlashMeetingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->creator)) {
            $body['creator'] = $request->creator;
        }
        if (!Utils::isUnset($request->eventId)) {
            $body['eventId'] = $request->eventId;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
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
            'action'      => 'CreateFlashMeeting',
            'version'     => 'flashmeeting_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/flashmeeting/meetings',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateFlashMeetingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateFlashMeetingRequest $request
     *
     * @return CreateFlashMeetingResponse
     */
    public function createFlashMeeting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateFlashMeetingHeaders([]);

        return $this->createFlashMeetingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetShanhuiByCalendarRequest $request
     * @param GetShanhuiByCalendarHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetShanhuiByCalendarResponse
     */
    public function getShanhuiByCalendarWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->eventId)) {
            $query['eventId'] = $request->eventId;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
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
            'action'      => 'GetShanhuiByCalendar',
            'version'     => 'flashmeeting_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/flashmeeting/calendars/meeting',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetShanhuiByCalendarResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetShanhuiByCalendarRequest $request
     *
     * @return GetShanhuiByCalendarResponse
     */
    public function getShanhuiByCalendar($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetShanhuiByCalendarHeaders([]);

        return $this->getShanhuiByCalendarWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                        $flashmeetingKey
     * @param GetShanhuiByShanhuiKeyHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetShanhuiByShanhuiKeyResponse
     */
    public function getShanhuiByShanhuiKeyWithOptions($flashmeetingKey, $headers, $runtime)
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
            'action'      => 'GetShanhuiByShanhuiKey',
            'version'     => 'flashmeeting_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/flashmeeting/meetings/keys/' . $flashmeetingKey . '/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetShanhuiByShanhuiKeyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $flashmeetingKey
     *
     * @return GetShanhuiByShanhuiKeyResponse
     */
    public function getShanhuiByShanhuiKey($flashmeetingKey)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetShanhuiByShanhuiKeyHeaders([]);

        return $this->getShanhuiByShanhuiKeyWithOptions($flashmeetingKey, $headers, $runtime);
    }

    /**
     * @param GetTaskFromShanhuiDocRequest $request
     * @param GetTaskFromShanhuiDocHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return GetTaskFromShanhuiDocResponse
     */
    public function getTaskFromShanhuiDocWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->docKey)) {
            $query['docKey'] = $request->docKey;
        }
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetTaskFromShanhuiDoc',
            'version'     => 'flashmeeting_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/flashmeeting/meetings/tasks',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTaskFromShanhuiDocResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetTaskFromShanhuiDocRequest $request
     *
     * @return GetTaskFromShanhuiDocResponse
     */
    public function getTaskFromShanhuiDoc($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTaskFromShanhuiDocHeaders([]);

        return $this->getTaskFromShanhuiDocWithOptions($request, $headers, $runtime);
    }
}
