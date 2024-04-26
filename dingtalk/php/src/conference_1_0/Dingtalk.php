<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CancelScheduleConferenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CancelScheduleConferenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CancelScheduleConferenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CloseVideoConferenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CloseVideoConferenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CloseVideoConferenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CohostsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CohostsRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CohostsResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateCustomShortLinkHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateCustomShortLinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateCustomShortLinkResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateScheduleConferenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateScheduleConferenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateScheduleConferenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateVideoConferenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateVideoConferenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateVideoConferenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\FocusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\FocusRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\FocusResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetConfDataByConferenceIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetConfDataByConferenceIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetConfDataByConferenceIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetConfDetailDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetConfDetailDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetConfDetailDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetHistoryConfDataListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetHistoryConfDataListRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetHistoryConfDataListResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetUserLastMetricHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetUserLastMetricRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetUserLastMetricResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetUserMetricDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetUserMetricDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetUserMetricDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\InviteUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\InviteUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\InviteUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\KickMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\KickMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\KickMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\LockConferenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\LockConferenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\LockConferenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\MuteAllHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\MuteAllRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\MuteAllResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\MuteMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\MuteMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\MuteMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordTextHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordTextRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordTextResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordVideoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordVideoPlayInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordVideoPlayInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordVideoPlayInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordVideoRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordVideoResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoBatchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoBatchRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoBatchResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryScheduleConferenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryScheduleConferenceInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryScheduleConferenceInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryScheduleConferenceInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryScheduleConferenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryScheduleConferenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryScheduleConfSettingsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryScheduleConfSettingsRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryScheduleConfSettingsResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryUserOnGoingConferenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryUserOnGoingConferenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryUserOnGoingConferenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StartCloudRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StartCloudRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StartCloudRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StartStreamOutHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StartStreamOutRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StartStreamOutResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StopCloudRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StopCloudRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StopCloudRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StopStreamOutHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StopStreamOutRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StopStreamOutResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateScheduleConferenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateScheduleConferenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateScheduleConferenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateScheduleConfSettingsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateScheduleConfSettingsRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateScheduleConfSettingsResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateVideoConferenceExtInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateVideoConferenceExtInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateVideoConferenceSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateVideoConferenceSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateVideoConferenceSettingResponse;
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
     * @param CancelScheduleConferenceRequest $request
     * @param CancelScheduleConferenceHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return CancelScheduleConferenceResponse
     */
    public function cancelScheduleConferenceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->creatorUnionId)) {
            $body['creatorUnionId'] = $request->creatorUnionId;
        }
        if (!Utils::isUnset($request->scheduleConferenceId)) {
            $body['scheduleConferenceId'] = $request->scheduleConferenceId;
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
            'action'      => 'CancelScheduleConference',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/scheduleConferences/cancel',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CancelScheduleConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CancelScheduleConferenceRequest $request
     *
     * @return CancelScheduleConferenceResponse
     */
    public function cancelScheduleConference($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelScheduleConferenceHeaders([]);

        return $this->cancelScheduleConferenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                      $conferenceId
     * @param CloseVideoConferenceRequest $request
     * @param CloseVideoConferenceHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return CloseVideoConferenceResponse
     */
    public function closeVideoConferenceWithOptions($conferenceId, $request, $headers, $runtime)
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'CloseVideoConference',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CloseVideoConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                      $conferenceId
     * @param CloseVideoConferenceRequest $request
     *
     * @return CloseVideoConferenceResponse
     */
    public function closeVideoConference($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CloseVideoConferenceHeaders([]);

        return $this->closeVideoConferenceWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string         $conferenceId
     * @param CohostsRequest $request
     * @param CohostsHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return CohostsResponse
     */
    public function cohostsWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'Cohosts',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/coHosts/set',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CohostsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string         $conferenceId
     * @param CohostsRequest $request
     *
     * @return CohostsResponse
     */
    public function cohosts($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CohostsHeaders([]);

        return $this->cohostsWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param CreateCustomShortLinkRequest $request
     * @param CreateCustomShortLinkHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return CreateCustomShortLinkResponse
     */
    public function createCustomShortLinkWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->coolAppCode)) {
            $body['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->creatorUnionId)) {
            $body['creatorUnionId'] = $request->creatorUnionId;
        }
        if (!Utils::isUnset($request->extensionAppBizData)) {
            $body['extensionAppBizData'] = $request->extensionAppBizData;
        }
        if (!Utils::isUnset($request->scheduleConferenceId)) {
            $body['scheduleConferenceId'] = $request->scheduleConferenceId;
        }
        if (!Utils::isUnset($request->useExtensionApp)) {
            $body['useExtensionApp'] = $request->useExtensionApp;
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
            'action'      => 'CreateCustomShortLink',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/customShortLinks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateCustomShortLinkResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateCustomShortLinkRequest $request
     *
     * @return CreateCustomShortLinkResponse
     */
    public function createCustomShortLink($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCustomShortLinkHeaders([]);

        return $this->createCustomShortLinkWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateScheduleConferenceRequest $request
     * @param CreateScheduleConferenceHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return CreateScheduleConferenceResponse
     */
    public function createScheduleConferenceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->creatorUnionId)) {
            $body['creatorUnionId'] = $request->creatorUnionId;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
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
            'action'      => 'CreateScheduleConference',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/scheduleConferences',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateScheduleConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateScheduleConferenceRequest $request
     *
     * @return CreateScheduleConferenceResponse
     */
    public function createScheduleConference($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateScheduleConferenceHeaders([]);

        return $this->createScheduleConferenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateVideoConferenceRequest $request
     * @param CreateVideoConferenceHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return CreateVideoConferenceResponse
     */
    public function createVideoConferenceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->confTitle)) {
            $body['confTitle'] = $request->confTitle;
        }
        if (!Utils::isUnset($request->inviteCaller)) {
            $body['inviteCaller'] = $request->inviteCaller;
        }
        if (!Utils::isUnset($request->inviteUserIds)) {
            $body['inviteUserIds'] = $request->inviteUserIds;
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
            'action'      => 'CreateVideoConference',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateVideoConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateVideoConferenceRequest $request
     *
     * @return CreateVideoConferenceResponse
     */
    public function createVideoConference($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateVideoConferenceHeaders([]);

        return $this->createVideoConferenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string         $conferenceId
     * @param FocusRequest   $request
     * @param FocusHeaders   $headers
     * @param RuntimeOptions $runtime
     *
     * @return FocusResponse
     */
    public function focusWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'Focus',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/focus',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return FocusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string       $conferenceId
     * @param FocusRequest $request
     *
     * @return FocusResponse
     */
    public function focus($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FocusHeaders([]);

        return $this->focusWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string                           $conferenceId
     * @param GetConfDataByConferenceIdRequest $request
     * @param GetConfDataByConferenceIdHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return GetConfDataByConferenceIdResponse
     */
    public function getConfDataByConferenceIdWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->realData)) {
            $query['realData'] = $request->realData;
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
            'action'      => 'GetConfDataByConferenceId',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetConfDataByConferenceIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                           $conferenceId
     * @param GetConfDataByConferenceIdRequest $request
     *
     * @return GetConfDataByConferenceIdResponse
     */
    public function getConfDataByConferenceId($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConfDataByConferenceIdHeaders([]);

        return $this->getConfDataByConferenceIdWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string                   $conferenceId
     * @param GetConfDetailDataRequest $request
     * @param GetConfDetailDataHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetConfDetailDataResponse
     */
    public function getConfDetailDataWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->nick)) {
            $query['nick'] = $request->nick;
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
            'action'      => 'GetConfDetailData',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/details',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetConfDetailDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                   $conferenceId
     * @param GetConfDetailDataRequest $request
     *
     * @return GetConfDetailDataResponse
     */
    public function getConfDetailData($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConfDetailDataHeaders([]);

        return $this->getConfDetailDataWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param GetHistoryConfDataListRequest $request
     * @param GetHistoryConfDataListHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetHistoryConfDataListResponse
     */
    public function getHistoryConfDataListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->creatorNike)) {
            $query['creatorNike'] = $request->creatorNike;
        }
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->freeType)) {
            $query['freeType'] = $request->freeType;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->realData)) {
            $query['realData'] = $request->realData;
        }
        if (!Utils::isUnset($request->scene)) {
            $query['scene'] = $request->scene;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->title)) {
            $query['title'] = $request->title;
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
            'action'      => 'GetHistoryConfDataList',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/histories/dataLists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetHistoryConfDataListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetHistoryConfDataListRequest $request
     *
     * @return GetHistoryConfDataListResponse
     */
    public function getHistoryConfDataList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetHistoryConfDataListHeaders([]);

        return $this->getHistoryConfDataListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                   $conferenceId
     * @param GetUserLastMetricRequest $request
     * @param GetUserLastMetricHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetUserLastMetricResponse
     */
    public function getUserLastMetricWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->unionIdList)) {
            $body['unionIdList'] = $request->unionIdList;
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
            'action'      => 'GetUserLastMetric',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/lastMetricDatas/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserLastMetricResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                   $conferenceId
     * @param GetUserLastMetricRequest $request
     *
     * @return GetUserLastMetricResponse
     */
    public function getUserLastMetric($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserLastMetricHeaders([]);

        return $this->getUserLastMetricWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string                   $conferenceId
     * @param GetUserMetricDataRequest $request
     * @param GetUserMetricDataHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetUserMetricDataResponse
     */
    public function getUserMetricDataWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->beginTime)) {
            $query['beginTime'] = $request->beginTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
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
            'action'      => 'GetUserMetricData',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/metricDatas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserMetricDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                   $conferenceId
     * @param GetUserMetricDataRequest $request
     *
     * @return GetUserMetricDataResponse
     */
    public function getUserMetricData($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserMetricDataHeaders([]);

        return $this->getUserMetricDataWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string             $conferenceId
     * @param InviteUsersRequest $request
     * @param InviteUsersHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return InviteUsersResponse
     */
    public function inviteUsersWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->inviteeList)) {
            $body['inviteeList'] = $request->inviteeList;
        }
        if (!Utils::isUnset($request->phoneInviteeList)) {
            $body['phoneInviteeList'] = $request->phoneInviteeList;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'InviteUsers',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/users/invite',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return InviteUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string             $conferenceId
     * @param InviteUsersRequest $request
     *
     * @return InviteUsersResponse
     */
    public function inviteUsers($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InviteUsersHeaders([]);

        return $this->inviteUsersWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string             $conferenceId
     * @param KickMembersRequest $request
     * @param KickMembersHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return KickMembersResponse
     */
    public function kickMembersWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->forbiddenRejoin)) {
            $body['forbiddenRejoin'] = $request->forbiddenRejoin;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'KickMembers',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/members/kick',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return KickMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string             $conferenceId
     * @param KickMembersRequest $request
     *
     * @return KickMembersResponse
     */
    public function kickMembers($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new KickMembersHeaders([]);

        return $this->kickMembersWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string                $conferenceId
     * @param LockConferenceRequest $request
     * @param LockConferenceHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return LockConferenceResponse
     */
    public function lockConferenceWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
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
            'action'      => 'LockConference',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/lock',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return LockConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                $conferenceId
     * @param LockConferenceRequest $request
     *
     * @return LockConferenceResponse
     */
    public function lockConference($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LockConferenceHeaders([]);

        return $this->lockConferenceWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string         $conferenceId
     * @param MuteAllRequest $request
     * @param MuteAllHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return MuteAllResponse
     */
    public function muteAllWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->forceMute)) {
            $body['forceMute'] = $request->forceMute;
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
            'action'      => 'MuteAll',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/allMembers/mute',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return MuteAllResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string         $conferenceId
     * @param MuteAllRequest $request
     *
     * @return MuteAllResponse
     */
    public function muteAll($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MuteAllHeaders([]);

        return $this->muteAllWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string             $conferenceId
     * @param MuteMembersRequest $request
     * @param MuteMembersHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return MuteMembersResponse
     */
    public function muteMembersWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'MuteMembers',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/members/mute',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return MuteMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string             $conferenceId
     * @param MuteMembersRequest $request
     *
     * @return MuteMembersResponse
     */
    public function muteMembers($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MuteMembersHeaders([]);

        return $this->muteMembersWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string                      $conferenceId
     * @param QueryCloudRecordTextRequest $request
     * @param QueryCloudRecordTextHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryCloudRecordTextResponse
     */
    public function queryCloudRecordTextWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->direction)) {
            $query['direction'] = $request->direction;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
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
            'action'      => 'QueryCloudRecordText',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/cloudRecords/getTexts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCloudRecordTextResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                      $conferenceId
     * @param QueryCloudRecordTextRequest $request
     *
     * @return QueryCloudRecordTextResponse
     */
    public function queryCloudRecordText($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCloudRecordTextHeaders([]);

        return $this->queryCloudRecordTextWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string                       $conferenceId
     * @param QueryCloudRecordVideoRequest $request
     * @param QueryCloudRecordVideoHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return QueryCloudRecordVideoResponse
     */
    public function queryCloudRecordVideoWithOptions($conferenceId, $request, $headers, $runtime)
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryCloudRecordVideo',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/cloudRecords/getVideos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCloudRecordVideoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                       $conferenceId
     * @param QueryCloudRecordVideoRequest $request
     *
     * @return QueryCloudRecordVideoResponse
     */
    public function queryCloudRecordVideo($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCloudRecordVideoHeaders([]);

        return $this->queryCloudRecordVideoWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string                               $conferenceId
     * @param QueryCloudRecordVideoPlayInfoRequest $request
     * @param QueryCloudRecordVideoPlayInfoHeaders $headers
     * @param RuntimeOptions                       $runtime
     *
     * @return QueryCloudRecordVideoPlayInfoResponse
     */
    public function queryCloudRecordVideoPlayInfoWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->mediaId)) {
            $query['mediaId'] = $request->mediaId;
        }
        if (!Utils::isUnset($request->regionId)) {
            $query['regionId'] = $request->regionId;
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
            'action'      => 'QueryCloudRecordVideoPlayInfo',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/cloudRecords/videos/getPlayInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCloudRecordVideoPlayInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                               $conferenceId
     * @param QueryCloudRecordVideoPlayInfoRequest $request
     *
     * @return QueryCloudRecordVideoPlayInfoResponse
     */
    public function queryCloudRecordVideoPlayInfo($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCloudRecordVideoPlayInfoHeaders([]);

        return $this->queryCloudRecordVideoPlayInfoWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $conferenceId
     * @param QueryConferenceInfoHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryConferenceInfoResponse
     */
    public function queryConferenceInfoWithOptions($conferenceId, $headers, $runtime)
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
            'action'      => 'QueryConferenceInfo',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryConferenceInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $conferenceId
     *
     * @return QueryConferenceInfoResponse
     */
    public function queryConferenceInfo($conferenceId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryConferenceInfoHeaders([]);

        return $this->queryConferenceInfoWithOptions($conferenceId, $headers, $runtime);
    }

    /**
     * @param QueryConferenceInfoBatchRequest $request
     * @param QueryConferenceInfoBatchHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return QueryConferenceInfoBatchResponse
     */
    public function queryConferenceInfoBatchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->conferenceIdList)) {
            $body['conferenceIdList'] = $request->conferenceIdList;
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
            'action'      => 'QueryConferenceInfoBatch',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryConferenceInfoBatchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryConferenceInfoBatchRequest $request
     *
     * @return QueryConferenceInfoBatchResponse
     */
    public function queryConferenceInfoBatch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryConferenceInfoBatchHeaders([]);

        return $this->queryConferenceInfoBatchWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                        $conferenceId
     * @param QueryConferenceMembersRequest $request
     * @param QueryConferenceMembersHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return QueryConferenceMembersResponse
     */
    public function queryConferenceMembersWithOptions($conferenceId, $request, $headers, $runtime)
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
            'action'      => 'QueryConferenceMembers',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/members',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryConferenceMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                        $conferenceId
     * @param QueryConferenceMembersRequest $request
     *
     * @return QueryConferenceMembersResponse
     */
    public function queryConferenceMembers($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryConferenceMembersHeaders([]);

        return $this->queryConferenceMembersWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param QueryScheduleConfSettingsRequest $request
     * @param QueryScheduleConfSettingsHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryScheduleConfSettingsResponse
     */
    public function queryScheduleConfSettingsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->scheduleConferenceId)) {
            $query['scheduleConferenceId'] = $request->scheduleConferenceId;
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
            'action'      => 'QueryScheduleConfSettings',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/scheduleConferences/settings',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryScheduleConfSettingsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryScheduleConfSettingsRequest $request
     *
     * @return QueryScheduleConfSettingsResponse
     */
    public function queryScheduleConfSettings($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryScheduleConfSettingsHeaders([]);

        return $this->queryScheduleConfSettingsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                         $scheduleConferenceId
     * @param QueryScheduleConferenceRequest $request
     * @param QueryScheduleConferenceHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return QueryScheduleConferenceResponse
     */
    public function queryScheduleConferenceWithOptions($scheduleConferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->requestUnionId)) {
            $query['requestUnionId'] = $request->requestUnionId;
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
            'action'      => 'QueryScheduleConference',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/scheduleConferences/' . $scheduleConferenceId . '/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryScheduleConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                         $scheduleConferenceId
     * @param QueryScheduleConferenceRequest $request
     *
     * @return QueryScheduleConferenceResponse
     */
    public function queryScheduleConference($scheduleConferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryScheduleConferenceHeaders([]);

        return $this->queryScheduleConferenceWithOptions($scheduleConferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string                             $scheduleConferenceId
     * @param QueryScheduleConferenceInfoRequest $request
     * @param QueryScheduleConferenceInfoHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return QueryScheduleConferenceInfoResponse
     */
    public function queryScheduleConferenceInfoWithOptions($scheduleConferenceId, $request, $headers, $runtime)
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
            'action'      => 'QueryScheduleConferenceInfo',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/scheduleConferences/' . $scheduleConferenceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryScheduleConferenceInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                             $scheduleConferenceId
     * @param QueryScheduleConferenceInfoRequest $request
     *
     * @return QueryScheduleConferenceInfoResponse
     */
    public function queryScheduleConferenceInfo($scheduleConferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryScheduleConferenceInfoHeaders([]);

        return $this->queryScheduleConferenceInfoWithOptions($scheduleConferenceId, $request, $headers, $runtime);
    }

    /**
     * @param QueryUserOnGoingConferenceRequest $request
     * @param QueryUserOnGoingConferenceHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return QueryUserOnGoingConferenceResponse
     */
    public function queryUserOnGoingConferenceWithOptions($request, $headers, $runtime)
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryUserOnGoingConference',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/users/lists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryUserOnGoingConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryUserOnGoingConferenceRequest $request
     *
     * @return QueryUserOnGoingConferenceResponse
     */
    public function queryUserOnGoingConference($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserOnGoingConferenceHeaders([]);

        return $this->queryUserOnGoingConferenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                  $conferenceId
     * @param StartCloudRecordRequest $request
     * @param StartCloudRecordHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return StartCloudRecordResponse
     */
    public function startCloudRecordWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->mode)) {
            $body['mode'] = $request->mode;
        }
        if (!Utils::isUnset($request->smallWindowPosition)) {
            $body['smallWindowPosition'] = $request->smallWindowPosition;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'StartCloudRecord',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/cloudRecords/start',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return StartCloudRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                  $conferenceId
     * @param StartCloudRecordRequest $request
     *
     * @return StartCloudRecordResponse
     */
    public function startCloudRecord($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartCloudRecordHeaders([]);

        return $this->startCloudRecordWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string                $conferenceId
     * @param StartStreamOutRequest $request
     * @param StartStreamOutHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return StartStreamOutResponse
     */
    public function startStreamOutWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->mode)) {
            $body['mode'] = $request->mode;
        }
        if (!Utils::isUnset($request->needHostJoin)) {
            $body['needHostJoin'] = $request->needHostJoin;
        }
        if (!Utils::isUnset($request->smallWindowPosition)) {
            $body['smallWindowPosition'] = $request->smallWindowPosition;
        }
        if (!Utils::isUnset($request->streamName)) {
            $body['streamName'] = $request->streamName;
        }
        if (!Utils::isUnset($request->streamUrlList)) {
            $body['streamUrlList'] = $request->streamUrlList;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'StartStreamOut',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/streamOuts/start',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return StartStreamOutResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                $conferenceId
     * @param StartStreamOutRequest $request
     *
     * @return StartStreamOutResponse
     */
    public function startStreamOut($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartStreamOutHeaders([]);

        return $this->startStreamOutWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $conferenceId
     * @param StopCloudRecordRequest $request
     * @param StopCloudRecordHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return StopCloudRecordResponse
     */
    public function stopCloudRecordWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'StopCloudRecord',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/cloudRecords/stop',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return StopCloudRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                 $conferenceId
     * @param StopCloudRecordRequest $request
     *
     * @return StopCloudRecordResponse
     */
    public function stopCloudRecord($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StopCloudRecordHeaders([]);

        return $this->stopCloudRecordWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param string               $conferenceId
     * @param StopStreamOutRequest $request
     * @param StopStreamOutHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return StopStreamOutResponse
     */
    public function stopStreamOutWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->stopAllStream)) {
            $body['stopAllStream'] = $request->stopAllStream;
        }
        if (!Utils::isUnset($request->streamId)) {
            $body['streamId'] = $request->streamId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'StopStreamOut',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/streamOuts/stop',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return StopStreamOutResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string               $conferenceId
     * @param StopStreamOutRequest $request
     *
     * @return StopStreamOutResponse
     */
    public function stopStreamOut($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StopStreamOutHeaders([]);

        return $this->stopStreamOutWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @param UpdateScheduleConfSettingsRequest $request
     * @param UpdateScheduleConfSettingsHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return UpdateScheduleConfSettingsResponse
     */
    public function updateScheduleConfSettingsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->creatorUnionId)) {
            $body['creatorUnionId'] = $request->creatorUnionId;
        }
        if (!Utils::isUnset($request->scheduleConfSettingModel)) {
            $body['scheduleConfSettingModel'] = $request->scheduleConfSettingModel;
        }
        if (!Utils::isUnset($request->scheduleConferenceId)) {
            $body['scheduleConferenceId'] = $request->scheduleConferenceId;
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
            'action'      => 'UpdateScheduleConfSettings',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/scheduleConferences/settings',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateScheduleConfSettingsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateScheduleConfSettingsRequest $request
     *
     * @return UpdateScheduleConfSettingsResponse
     */
    public function updateScheduleConfSettings($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateScheduleConfSettingsHeaders([]);

        return $this->updateScheduleConfSettingsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpdateScheduleConferenceRequest $request
     * @param UpdateScheduleConferenceHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return UpdateScheduleConferenceResponse
     */
    public function updateScheduleConferenceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->creatorUnionId)) {
            $body['creatorUnionId'] = $request->creatorUnionId;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->scheduleConferenceId)) {
            $body['scheduleConferenceId'] = $request->scheduleConferenceId;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
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
            'action'      => 'UpdateScheduleConference',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/scheduleConferences',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateScheduleConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpdateScheduleConferenceRequest $request
     *
     * @return UpdateScheduleConferenceResponse
     */
    public function updateScheduleConference($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateScheduleConferenceHeaders([]);

        return $this->updateScheduleConferenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                              $conferenceId
     * @param UpdateVideoConferenceExtInfoHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return UpdateVideoConferenceExtInfoResponse
     */
    public function updateVideoConferenceExtInfoWithOptions($conferenceId, $headers, $runtime)
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
            'action'      => 'UpdateVideoConferenceExtInfo',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '/extInfo',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return UpdateVideoConferenceExtInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $conferenceId
     *
     * @return UpdateVideoConferenceExtInfoResponse
     */
    public function updateVideoConferenceExtInfo($conferenceId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateVideoConferenceExtInfoHeaders([]);

        return $this->updateVideoConferenceExtInfoWithOptions($conferenceId, $headers, $runtime);
    }

    /**
     * @param string                              $conferenceId
     * @param UpdateVideoConferenceSettingRequest $request
     * @param UpdateVideoConferenceSettingHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return UpdateVideoConferenceSettingResponse
     */
    public function updateVideoConferenceSettingWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->allowUnmuteSelf)) {
            $body['allowUnmuteSelf'] = $request->allowUnmuteSelf;
        }
        if (!Utils::isUnset($request->autoTransferHost)) {
            $body['autoTransferHost'] = $request->autoTransferHost;
        }
        if (!Utils::isUnset($request->forbiddenShareScreen)) {
            $body['forbiddenShareScreen'] = $request->forbiddenShareScreen;
        }
        if (!Utils::isUnset($request->lockConference)) {
            $body['lockConference'] = $request->lockConference;
        }
        if (!Utils::isUnset($request->muteAll)) {
            $body['muteAll'] = $request->muteAll;
        }
        if (!Utils::isUnset($request->onlyInternalEmployeesJoin)) {
            $body['onlyInternalEmployeesJoin'] = $request->onlyInternalEmployeesJoin;
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
            'action'      => 'UpdateVideoConferenceSetting',
            'version'     => 'conference_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/conference/videoConferences/' . $conferenceId . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateVideoConferenceSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                              $conferenceId
     * @param UpdateVideoConferenceSettingRequest $request
     *
     * @return UpdateVideoConferenceSettingResponse
     */
    public function updateVideoConferenceSetting($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateVideoConferenceSettingHeaders([]);

        return $this->updateVideoConferenceSettingWithOptions($conferenceId, $request, $headers, $runtime);
    }
}
