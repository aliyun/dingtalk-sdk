<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\AddRecordPermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\AddRecordPermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\AddRecordPermissionResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GenerateFlashMinutesDocumentUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GenerateFlashMinutesDocumentUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GenerateFlashMinutesDocumentUrlResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoByRoomCodeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoByRoomCodeRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoByRoomCodeResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryFlashMinutesSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryFlashMinutesSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryFlashMinutesSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesAudioHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesAudioRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesAudioResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesTextHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesTextRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesTextResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryOrgConferenceListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryOrgConferenceListRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryOrgConferenceListResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryRecordMinutesUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryRecordMinutesUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryRecordMinutesUrlResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StartMinutesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StartMinutesRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StartMinutesResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StartStreamOutHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StartStreamOutRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StartStreamOutResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StopCloudRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StopCloudRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StopCloudRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StopMinutesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StopMinutesRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\StopMinutesResponse;
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
     * @summary 增加闪记权限
     *  *
     * @param string                     $conferenceId
     * @param AddRecordPermissionRequest $request      AddRecordPermissionRequest
     * @param AddRecordPermissionHeaders $headers      AddRecordPermissionHeaders
     * @param RuntimeOptions             $runtime      runtime options for this request RuntimeOptions
     *
     * @return AddRecordPermissionResponse AddRecordPermissionResponse
     */
    public function addRecordPermissionWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->ownerUnionId)) {
            $body['ownerUnionId'] = $request->ownerUnionId;
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
            'action' => 'AddRecordPermission',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/flashMinutes/recordPermissions',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AddRecordPermissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 增加闪记权限
     *  *
     * @param string                     $conferenceId
     * @param AddRecordPermissionRequest $request      AddRecordPermissionRequest
     *
     * @return AddRecordPermissionResponse AddRecordPermissionResponse
     */
    public function addRecordPermission($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddRecordPermissionHeaders([]);

        return $this->addRecordPermissionWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 取消预约会议
     *  *
     * @param CancelScheduleConferenceRequest $request CancelScheduleConferenceRequest
     * @param CancelScheduleConferenceHeaders $headers CancelScheduleConferenceHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return CancelScheduleConferenceResponse CancelScheduleConferenceResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CancelScheduleConference',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/scheduleConferences/cancel',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CancelScheduleConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 取消预约会议
     *  *
     * @param CancelScheduleConferenceRequest $request CancelScheduleConferenceRequest
     *
     * @return CancelScheduleConferenceResponse CancelScheduleConferenceResponse
     */
    public function cancelScheduleConference($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelScheduleConferenceHeaders([]);

        return $this->cancelScheduleConferenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 关闭视频会议
     *  *
     * @param string                      $conferenceId
     * @param CloseVideoConferenceRequest $request      CloseVideoConferenceRequest
     * @param CloseVideoConferenceHeaders $headers      CloseVideoConferenceHeaders
     * @param RuntimeOptions              $runtime      runtime options for this request RuntimeOptions
     *
     * @return CloseVideoConferenceResponse CloseVideoConferenceResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'CloseVideoConference',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return CloseVideoConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 关闭视频会议
     *  *
     * @param string                      $conferenceId
     * @param CloseVideoConferenceRequest $request      CloseVideoConferenceRequest
     *
     * @return CloseVideoConferenceResponse CloseVideoConferenceResponse
     */
    public function closeVideoConference($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CloseVideoConferenceHeaders([]);

        return $this->closeVideoConferenceWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 设置联席主持人
     *  *
     * @param string         $conferenceId
     * @param CohostsRequest $request      CohostsRequest
     * @param CohostsHeaders $headers      CohostsHeaders
     * @param RuntimeOptions $runtime      runtime options for this request RuntimeOptions
     *
     * @return CohostsResponse CohostsResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'Cohosts',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/coHosts/set',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CohostsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置联席主持人
     *  *
     * @param string         $conferenceId
     * @param CohostsRequest $request      CohostsRequest
     *
     * @return CohostsResponse CohostsResponse
     */
    public function cohosts($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CohostsHeaders([]);

        return $this->cohostsWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建专属短链
     *  *
     * @param CreateCustomShortLinkRequest $request CreateCustomShortLinkRequest
     * @param CreateCustomShortLinkHeaders $headers CreateCustomShortLinkHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateCustomShortLinkResponse CreateCustomShortLinkResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateCustomShortLink',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/customShortLinks',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateCustomShortLinkResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建专属短链
     *  *
     * @param CreateCustomShortLinkRequest $request CreateCustomShortLinkRequest
     *
     * @return CreateCustomShortLinkResponse CreateCustomShortLinkResponse
     */
    public function createCustomShortLink($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateCustomShortLinkHeaders([]);

        return $this->createCustomShortLinkWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建预约会议
     *  *
     * @param CreateScheduleConferenceRequest $request CreateScheduleConferenceRequest
     * @param CreateScheduleConferenceHeaders $headers CreateScheduleConferenceHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateScheduleConferenceResponse CreateScheduleConferenceResponse
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
        if (!Utils::isUnset($request->scheduleConfSettingModel)) {
            $body['scheduleConfSettingModel'] = $request->scheduleConfSettingModel;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateScheduleConference',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/scheduleConferences',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateScheduleConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建预约会议
     *  *
     * @param CreateScheduleConferenceRequest $request CreateScheduleConferenceRequest
     *
     * @return CreateScheduleConferenceResponse CreateScheduleConferenceResponse
     */
    public function createScheduleConference($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateScheduleConferenceHeaders([]);

        return $this->createScheduleConferenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建视频会议
     *  *
     * @param CreateVideoConferenceRequest $request CreateVideoConferenceRequest
     * @param CreateVideoConferenceHeaders $headers CreateVideoConferenceHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateVideoConferenceResponse CreateVideoConferenceResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateVideoConference',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateVideoConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建视频会议
     *  *
     * @param CreateVideoConferenceRequest $request CreateVideoConferenceRequest
     *
     * @return CreateVideoConferenceResponse CreateVideoConferenceResponse
     */
    public function createVideoConference($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateVideoConferenceHeaders([]);

        return $this->createVideoConferenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设置全员看他
     *  *
     * @param string         $conferenceId
     * @param FocusRequest   $request      FocusRequest
     * @param FocusHeaders   $headers      FocusHeaders
     * @param RuntimeOptions $runtime      runtime options for this request RuntimeOptions
     *
     * @return FocusResponse FocusResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'Focus',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/focus',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return FocusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置全员看他
     *  *
     * @param string       $conferenceId
     * @param FocusRequest $request      FocusRequest
     *
     * @return FocusResponse FocusResponse
     */
    public function focus($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new FocusHeaders([]);

        return $this->focusWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 生成会议闪记文档的下载链接
     *  *
     * @param string                                 $conferenceId
     * @param GenerateFlashMinutesDocumentUrlRequest $request      GenerateFlashMinutesDocumentUrlRequest
     * @param GenerateFlashMinutesDocumentUrlHeaders $headers      GenerateFlashMinutesDocumentUrlHeaders
     * @param RuntimeOptions                         $runtime      runtime options for this request RuntimeOptions
     *
     * @return GenerateFlashMinutesDocumentUrlResponse GenerateFlashMinutesDocumentUrlResponse
     */
    public function generateFlashMinutesDocumentUrlWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizType)) {
            $query['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->expireTime)) {
            $query['expireTime'] = $request->expireTime;
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
            'action' => 'GenerateFlashMinutesDocumentUrl',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/flashMinutes/document/generate',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GenerateFlashMinutesDocumentUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 生成会议闪记文档的下载链接
     *  *
     * @param string                                 $conferenceId
     * @param GenerateFlashMinutesDocumentUrlRequest $request      GenerateFlashMinutesDocumentUrlRequest
     *
     * @return GenerateFlashMinutesDocumentUrlResponse GenerateFlashMinutesDocumentUrlResponse
     */
    public function generateFlashMinutesDocumentUrl($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GenerateFlashMinutesDocumentUrlHeaders([]);

        return $this->generateFlashMinutesDocumentUrlWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 通过conferenceId获取指定音视频会议信息
     *  *
     * @param string                           $conferenceId
     * @param GetConfDataByConferenceIdRequest $request      GetConfDataByConferenceIdRequest
     * @param GetConfDataByConferenceIdHeaders $headers      GetConfDataByConferenceIdHeaders
     * @param RuntimeOptions                   $runtime      runtime options for this request RuntimeOptions
     *
     * @return GetConfDataByConferenceIdResponse GetConfDataByConferenceIdResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetConfDataByConferenceId',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/infos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetConfDataByConferenceIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过conferenceId获取指定音视频会议信息
     *  *
     * @param string                           $conferenceId
     * @param GetConfDataByConferenceIdRequest $request      GetConfDataByConferenceIdRequest
     *
     * @return GetConfDataByConferenceIdResponse GetConfDataByConferenceIdResponse
     */
    public function getConfDataByConferenceId($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConfDataByConferenceIdHeaders([]);

        return $this->getConfDataByConferenceIdWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 通过conferenceId获取指定音视频会议成员信息
     *  *
     * @param string                   $conferenceId
     * @param GetConfDetailDataRequest $request      GetConfDetailDataRequest
     * @param GetConfDetailDataHeaders $headers      GetConfDetailDataHeaders
     * @param RuntimeOptions           $runtime      runtime options for this request RuntimeOptions
     *
     * @return GetConfDetailDataResponse GetConfDetailDataResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetConfDetailData',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/details',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetConfDetailDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过conferenceId获取指定音视频会议成员信息
     *  *
     * @param string                   $conferenceId
     * @param GetConfDetailDataRequest $request      GetConfDetailDataRequest
     *
     * @return GetConfDetailDataResponse GetConfDetailDataResponse
     */
    public function getConfDetailData($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetConfDetailDataHeaders([]);

        return $this->getConfDetailDataWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取音视频会议列表数据
     *  *
     * @param GetHistoryConfDataListRequest $request GetHistoryConfDataListRequest
     * @param GetHistoryConfDataListHeaders $headers GetHistoryConfDataListHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetHistoryConfDataListResponse GetHistoryConfDataListResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetHistoryConfDataList',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/histories/dataLists',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetHistoryConfDataListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取音视频会议列表数据
     *  *
     * @param GetHistoryConfDataListRequest $request GetHistoryConfDataListRequest
     *
     * @return GetHistoryConfDataListResponse GetHistoryConfDataListResponse
     */
    public function getHistoryConfDataList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetHistoryConfDataListHeaders([]);

        return $this->getHistoryConfDataListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 通过conferenceId和unionId获取最新会议质量数据
     *  *
     * @param string                   $conferenceId
     * @param GetUserLastMetricRequest $request      GetUserLastMetricRequest
     * @param GetUserLastMetricHeaders $headers      GetUserLastMetricHeaders
     * @param RuntimeOptions           $runtime      runtime options for this request RuntimeOptions
     *
     * @return GetUserLastMetricResponse GetUserLastMetricResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'GetUserLastMetric',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/lastMetricDatas/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetUserLastMetricResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过conferenceId和unionId获取最新会议质量数据
     *  *
     * @param string                   $conferenceId
     * @param GetUserLastMetricRequest $request      GetUserLastMetricRequest
     *
     * @return GetUserLastMetricResponse GetUserLastMetricResponse
     */
    public function getUserLastMetric($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserLastMetricHeaders([]);

        return $this->getUserLastMetricWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 通过conferenceId和unionId获取指定音视频会议人员的会议质量数据
     *  *
     * @param string                   $conferenceId
     * @param GetUserMetricDataRequest $request      GetUserMetricDataRequest
     * @param GetUserMetricDataHeaders $headers      GetUserMetricDataHeaders
     * @param RuntimeOptions           $runtime      runtime options for this request RuntimeOptions
     *
     * @return GetUserMetricDataResponse GetUserMetricDataResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetUserMetricData',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/metricDatas',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetUserMetricDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过conferenceId和unionId获取指定音视频会议人员的会议质量数据
     *  *
     * @param string                   $conferenceId
     * @param GetUserMetricDataRequest $request      GetUserMetricDataRequest
     *
     * @return GetUserMetricDataResponse GetUserMetricDataResponse
     */
    public function getUserMetricData($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserMetricDataHeaders([]);

        return $this->getUserMetricDataWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 邀请其他人员
     *  *
     * @param string             $conferenceId
     * @param InviteUsersRequest $request      InviteUsersRequest
     * @param InviteUsersHeaders $headers      InviteUsersHeaders
     * @param RuntimeOptions     $runtime      runtime options for this request RuntimeOptions
     *
     * @return InviteUsersResponse InviteUsersResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'InviteUsers',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/users/invite',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return InviteUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 邀请其他人员
     *  *
     * @param string             $conferenceId
     * @param InviteUsersRequest $request      InviteUsersRequest
     *
     * @return InviteUsersResponse InviteUsersResponse
     */
    public function inviteUsers($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InviteUsersHeaders([]);

        return $this->inviteUsersWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 会议踢出成员
     *  *
     * @param string             $conferenceId
     * @param KickMembersRequest $request      KickMembersRequest
     * @param KickMembersHeaders $headers      KickMembersHeaders
     * @param RuntimeOptions     $runtime      runtime options for this request RuntimeOptions
     *
     * @return KickMembersResponse KickMembersResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'KickMembers',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/members/kick',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return KickMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 会议踢出成员
     *  *
     * @param string             $conferenceId
     * @param KickMembersRequest $request      KickMembersRequest
     *
     * @return KickMembersResponse KickMembersResponse
     */
    public function kickMembers($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new KickMembersHeaders([]);

        return $this->kickMembersWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 锁定会议
     *  *
     * @param string                $conferenceId
     * @param LockConferenceRequest $request      LockConferenceRequest
     * @param LockConferenceHeaders $headers      LockConferenceHeaders
     * @param RuntimeOptions        $runtime      runtime options for this request RuntimeOptions
     *
     * @return LockConferenceResponse LockConferenceResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'LockConference',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/lock',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return LockConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 锁定会议
     *  *
     * @param string                $conferenceId
     * @param LockConferenceRequest $request      LockConferenceRequest
     *
     * @return LockConferenceResponse LockConferenceResponse
     */
    public function lockConference($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LockConferenceHeaders([]);

        return $this->lockConferenceWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 会议全员静音或解除静音
     *  *
     * @param string         $conferenceId
     * @param MuteAllRequest $request      MuteAllRequest
     * @param MuteAllHeaders $headers      MuteAllHeaders
     * @param RuntimeOptions $runtime      runtime options for this request RuntimeOptions
     *
     * @return MuteAllResponse MuteAllResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'MuteAll',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/allMembers/mute',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return MuteAllResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 会议全员静音或解除静音
     *  *
     * @param string         $conferenceId
     * @param MuteAllRequest $request      MuteAllRequest
     *
     * @return MuteAllResponse MuteAllResponse
     */
    public function muteAll($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MuteAllHeaders([]);

        return $this->muteAllWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 指定人员静音或取消静音
     *  *
     * @param string             $conferenceId
     * @param MuteMembersRequest $request      MuteMembersRequest
     * @param MuteMembersHeaders $headers      MuteMembersHeaders
     * @param RuntimeOptions     $runtime      runtime options for this request RuntimeOptions
     *
     * @return MuteMembersResponse MuteMembersResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'MuteMembers',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/members/mute',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return MuteMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 指定人员静音或取消静音
     *  *
     * @param string             $conferenceId
     * @param MuteMembersRequest $request      MuteMembersRequest
     *
     * @return MuteMembersResponse MuteMembersResponse
     */
    public function muteMembers($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MuteMembersHeaders([]);

        return $this->muteMembersWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询云录制文本信息
     *  *
     * @param string                      $conferenceId
     * @param QueryCloudRecordTextRequest $request      QueryCloudRecordTextRequest
     * @param QueryCloudRecordTextHeaders $headers      QueryCloudRecordTextHeaders
     * @param RuntimeOptions              $runtime      runtime options for this request RuntimeOptions
     *
     * @return QueryCloudRecordTextResponse QueryCloudRecordTextResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryCloudRecordText',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/cloudRecords/getTexts',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryCloudRecordTextResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询云录制文本信息
     *  *
     * @param string                      $conferenceId
     * @param QueryCloudRecordTextRequest $request      QueryCloudRecordTextRequest
     *
     * @return QueryCloudRecordTextResponse QueryCloudRecordTextResponse
     */
    public function queryCloudRecordText($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCloudRecordTextHeaders([]);

        return $this->queryCloudRecordTextWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询云录制视频
     *  *
     * @param string                       $conferenceId
     * @param QueryCloudRecordVideoRequest $request      QueryCloudRecordVideoRequest
     * @param QueryCloudRecordVideoHeaders $headers      QueryCloudRecordVideoHeaders
     * @param RuntimeOptions               $runtime      runtime options for this request RuntimeOptions
     *
     * @return QueryCloudRecordVideoResponse QueryCloudRecordVideoResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryCloudRecordVideo',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/cloudRecords/getVideos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryCloudRecordVideoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询云录制视频
     *  *
     * @param string                       $conferenceId
     * @param QueryCloudRecordVideoRequest $request      QueryCloudRecordVideoRequest
     *
     * @return QueryCloudRecordVideoResponse QueryCloudRecordVideoResponse
     */
    public function queryCloudRecordVideo($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCloudRecordVideoHeaders([]);

        return $this->queryCloudRecordVideoWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询云录制视频播放信息
     *  *
     * @param string                               $conferenceId
     * @param QueryCloudRecordVideoPlayInfoRequest $request      QueryCloudRecordVideoPlayInfoRequest
     * @param QueryCloudRecordVideoPlayInfoHeaders $headers      QueryCloudRecordVideoPlayInfoHeaders
     * @param RuntimeOptions                       $runtime      runtime options for this request RuntimeOptions
     *
     * @return QueryCloudRecordVideoPlayInfoResponse QueryCloudRecordVideoPlayInfoResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryCloudRecordVideoPlayInfo',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/cloudRecords/videos/getPlayInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryCloudRecordVideoPlayInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询云录制视频播放信息
     *  *
     * @param string                               $conferenceId
     * @param QueryCloudRecordVideoPlayInfoRequest $request      QueryCloudRecordVideoPlayInfoRequest
     *
     * @return QueryCloudRecordVideoPlayInfoResponse QueryCloudRecordVideoPlayInfoResponse
     */
    public function queryCloudRecordVideoPlayInfo($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCloudRecordVideoPlayInfoHeaders([]);

        return $this->queryCloudRecordVideoPlayInfoWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询视频会议信息
     *  *
     * @param string                     $conferenceId
     * @param QueryConferenceInfoHeaders $headers      QueryConferenceInfoHeaders
     * @param RuntimeOptions             $runtime      runtime options for this request RuntimeOptions
     *
     * @return QueryConferenceInfoResponse QueryConferenceInfoResponse
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
            'action' => 'QueryConferenceInfo',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryConferenceInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询视频会议信息
     *  *
     * @param string $conferenceId
     *
     * @return QueryConferenceInfoResponse QueryConferenceInfoResponse
     */
    public function queryConferenceInfo($conferenceId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryConferenceInfoHeaders([]);

        return $this->queryConferenceInfoWithOptions($conferenceId, $headers, $runtime);
    }

    /**
     * @summary 批量查询视频会议信息
     *  *
     * @param QueryConferenceInfoBatchRequest $request QueryConferenceInfoBatchRequest
     * @param QueryConferenceInfoBatchHeaders $headers QueryConferenceInfoBatchHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryConferenceInfoBatchResponse QueryConferenceInfoBatchResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'QueryConferenceInfoBatch',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return QueryConferenceInfoBatchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询视频会议信息
     *  *
     * @param QueryConferenceInfoBatchRequest $request QueryConferenceInfoBatchRequest
     *
     * @return QueryConferenceInfoBatchResponse QueryConferenceInfoBatchResponse
     */
    public function queryConferenceInfoBatch($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryConferenceInfoBatchHeaders([]);

        return $this->queryConferenceInfoBatchWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据会议号查询会议信息
     *  *
     * @param string                               $roomCode
     * @param QueryConferenceInfoByRoomCodeRequest $request  QueryConferenceInfoByRoomCodeRequest
     * @param QueryConferenceInfoByRoomCodeHeaders $headers  QueryConferenceInfoByRoomCodeHeaders
     * @param RuntimeOptions                       $runtime  runtime options for this request RuntimeOptions
     *
     * @return QueryConferenceInfoByRoomCodeResponse QueryConferenceInfoByRoomCodeResponse
     */
    public function queryConferenceInfoByRoomCodeWithOptions($roomCode, $request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryConferenceInfoByRoomCode',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/roomCodes/' . $roomCode . '/infos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryConferenceInfoByRoomCodeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据会议号查询会议信息
     *  *
     * @param string                               $roomCode
     * @param QueryConferenceInfoByRoomCodeRequest $request  QueryConferenceInfoByRoomCodeRequest
     *
     * @return QueryConferenceInfoByRoomCodeResponse QueryConferenceInfoByRoomCodeResponse
     */
    public function queryConferenceInfoByRoomCode($roomCode, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryConferenceInfoByRoomCodeHeaders([]);

        return $this->queryConferenceInfoByRoomCodeWithOptions($roomCode, $request, $headers, $runtime);
    }

    /**
     * @summary 查询视频会议成员
     *  *
     * @param string                        $conferenceId
     * @param QueryConferenceMembersRequest $request      QueryConferenceMembersRequest
     * @param QueryConferenceMembersHeaders $headers      QueryConferenceMembersHeaders
     * @param RuntimeOptions                $runtime      runtime options for this request RuntimeOptions
     *
     * @return QueryConferenceMembersResponse QueryConferenceMembersResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryConferenceMembers',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/members',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryConferenceMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询视频会议成员
     *  *
     * @param string                        $conferenceId
     * @param QueryConferenceMembersRequest $request      QueryConferenceMembersRequest
     *
     * @return QueryConferenceMembersResponse QueryConferenceMembersResponse
     */
    public function queryConferenceMembers($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryConferenceMembersHeaders([]);

        return $this->queryConferenceMembersWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询云录制摘要请求
     *  *
     * @param string                          $conferenceId
     * @param QueryFlashMinutesSummaryRequest $request      QueryFlashMinutesSummaryRequest
     * @param QueryFlashMinutesSummaryHeaders $headers      QueryFlashMinutesSummaryHeaders
     * @param RuntimeOptions                  $runtime      runtime options for this request RuntimeOptions
     *
     * @return QueryFlashMinutesSummaryResponse QueryFlashMinutesSummaryResponse
     */
    public function queryFlashMinutesSummaryWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizType)) {
            $query['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->recorderUnionId)) {
            $query['recorderUnionId'] = $request->recorderUnionId;
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
            'action' => 'QueryFlashMinutesSummary',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/flashMinutes/summaries',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryFlashMinutesSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询云录制摘要请求
     *  *
     * @param string                          $conferenceId
     * @param QueryFlashMinutesSummaryRequest $request      QueryFlashMinutesSummaryRequest
     *
     * @return QueryFlashMinutesSummaryResponse QueryFlashMinutesSummaryResponse
     */
    public function queryFlashMinutesSummary($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryFlashMinutesSummaryHeaders([]);

        return $this->queryFlashMinutesSummaryWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询会议闪记的音频信息
     *  *
     * @param string                   $conferenceId
     * @param QueryMinutesAudioRequest $request      QueryMinutesAudioRequest
     * @param QueryMinutesAudioHeaders $headers      QueryMinutesAudioHeaders
     * @param RuntimeOptions           $runtime      runtime options for this request RuntimeOptions
     *
     * @return QueryMinutesAudioResponse QueryMinutesAudioResponse
     */
    public function queryMinutesAudioWithOptions($conferenceId, $request, $headers, $runtime)
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
            'action' => 'QueryMinutesAudio',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/minutes/audioInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMinutesAudioResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询会议闪记的音频信息
     *  *
     * @param string                   $conferenceId
     * @param QueryMinutesAudioRequest $request      QueryMinutesAudioRequest
     *
     * @return QueryMinutesAudioResponse QueryMinutesAudioResponse
     */
    public function queryMinutesAudio($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMinutesAudioHeaders([]);

        return $this->queryMinutesAudioWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询会议闪记智能纪要
     *  *
     * @param string                     $conferenceId
     * @param QueryMinutesSummaryRequest $request      QueryMinutesSummaryRequest
     * @param QueryMinutesSummaryHeaders $headers      QueryMinutesSummaryHeaders
     * @param RuntimeOptions             $runtime      runtime options for this request RuntimeOptions
     *
     * @return QueryMinutesSummaryResponse QueryMinutesSummaryResponse
     */
    public function queryMinutesSummaryWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->summaryTypeList)) {
            $body['summaryTypeList'] = $request->summaryTypeList;
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
            'action' => 'QueryMinutesSummary',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/minutes/summaries/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMinutesSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询会议闪记智能纪要
     *  *
     * @param string                     $conferenceId
     * @param QueryMinutesSummaryRequest $request      QueryMinutesSummaryRequest
     *
     * @return QueryMinutesSummaryResponse QueryMinutesSummaryResponse
     */
    public function queryMinutesSummary($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMinutesSummaryHeaders([]);

        return $this->queryMinutesSummaryWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询会议闪记文本信息
     *  *
     * @param string                  $conferenceId
     * @param QueryMinutesTextRequest $request      QueryMinutesTextRequest
     * @param QueryMinutesTextHeaders $headers      QueryMinutesTextHeaders
     * @param RuntimeOptions          $runtime      runtime options for this request RuntimeOptions
     *
     * @return QueryMinutesTextResponse QueryMinutesTextResponse
     */
    public function queryMinutesTextWithOptions($conferenceId, $request, $headers, $runtime)
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
            'action' => 'QueryMinutesText',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/minutes/textInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMinutesTextResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询会议闪记文本信息
     *  *
     * @param string                  $conferenceId
     * @param QueryMinutesTextRequest $request      QueryMinutesTextRequest
     *
     * @return QueryMinutesTextResponse QueryMinutesTextResponse
     */
    public function queryMinutesText($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMinutesTextHeaders([]);

        return $this->queryMinutesTextWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询企业进行中会议列表
     *  *
     * @param QueryOrgConferenceListRequest $request QueryOrgConferenceListRequest
     * @param QueryOrgConferenceListHeaders $headers QueryOrgConferenceListHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOrgConferenceListResponse QueryOrgConferenceListResponse
     */
    public function queryOrgConferenceListWithOptions($request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryOrgConferenceList',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/orgConferences',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryOrgConferenceListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询企业进行中会议列表
     *  *
     * @param QueryOrgConferenceListRequest $request QueryOrgConferenceListRequest
     *
     * @return QueryOrgConferenceListResponse QueryOrgConferenceListResponse
     */
    public function queryOrgConferenceList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgConferenceListHeaders([]);

        return $this->queryOrgConferenceListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询闪记链接
     *  *
     * @param string                       $conferenceId
     * @param QueryRecordMinutesUrlRequest $request      QueryRecordMinutesUrlRequest
     * @param QueryRecordMinutesUrlHeaders $headers      QueryRecordMinutesUrlHeaders
     * @param RuntimeOptions               $runtime      runtime options for this request RuntimeOptions
     *
     * @return QueryRecordMinutesUrlResponse QueryRecordMinutesUrlResponse
     */
    public function queryRecordMinutesUrlWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizType)) {
            $query['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->recorderUnionId)) {
            $query['recorderUnionId'] = $request->recorderUnionId;
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
            'action' => 'QueryRecordMinutesUrl',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/flashMinutes/recordUrls',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryRecordMinutesUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询闪记链接
     *  *
     * @param string                       $conferenceId
     * @param QueryRecordMinutesUrlRequest $request      QueryRecordMinutesUrlRequest
     *
     * @return QueryRecordMinutesUrlResponse QueryRecordMinutesUrlResponse
     */
    public function queryRecordMinutesUrl($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRecordMinutesUrlHeaders([]);

        return $this->queryRecordMinutesUrlWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询预约会议设置
     *  *
     * @param QueryScheduleConfSettingsRequest $request QueryScheduleConfSettingsRequest
     * @param QueryScheduleConfSettingsHeaders $headers QueryScheduleConfSettingsHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryScheduleConfSettingsResponse QueryScheduleConfSettingsResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryScheduleConfSettings',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/scheduleConferences/settings',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryScheduleConfSettingsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询预约会议设置
     *  *
     * @param QueryScheduleConfSettingsRequest $request QueryScheduleConfSettingsRequest
     *
     * @return QueryScheduleConfSettingsResponse QueryScheduleConfSettingsResponse
     */
    public function queryScheduleConfSettings($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryScheduleConfSettingsHeaders([]);

        return $this->queryScheduleConfSettingsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询预约会议信息
     *  *
     * @param string                         $scheduleConferenceId
     * @param QueryScheduleConferenceRequest $request              QueryScheduleConferenceRequest
     * @param QueryScheduleConferenceHeaders $headers              QueryScheduleConferenceHeaders
     * @param RuntimeOptions                 $runtime              runtime options for this request RuntimeOptions
     *
     * @return QueryScheduleConferenceResponse QueryScheduleConferenceResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryScheduleConference',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/scheduleConferences/' . $scheduleConferenceId . '/infos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryScheduleConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询预约会议信息
     *  *
     * @param string                         $scheduleConferenceId
     * @param QueryScheduleConferenceRequest $request              QueryScheduleConferenceRequest
     *
     * @return QueryScheduleConferenceResponse QueryScheduleConferenceResponse
     */
    public function queryScheduleConference($scheduleConferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryScheduleConferenceHeaders([]);

        return $this->queryScheduleConferenceWithOptions($scheduleConferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息
     *  *
     * @param string                             $scheduleConferenceId
     * @param QueryScheduleConferenceInfoRequest $request              QueryScheduleConferenceInfoRequest
     * @param QueryScheduleConferenceInfoHeaders $headers              QueryScheduleConferenceInfoHeaders
     * @param RuntimeOptions                     $runtime              runtime options for this request RuntimeOptions
     *
     * @return QueryScheduleConferenceInfoResponse QueryScheduleConferenceInfoResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryScheduleConferenceInfo',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/scheduleConferences/' . $scheduleConferenceId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryScheduleConferenceInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息
     *  *
     * @param string                             $scheduleConferenceId
     * @param QueryScheduleConferenceInfoRequest $request              QueryScheduleConferenceInfoRequest
     *
     * @return QueryScheduleConferenceInfoResponse QueryScheduleConferenceInfoResponse
     */
    public function queryScheduleConferenceInfo($scheduleConferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryScheduleConferenceInfoHeaders([]);

        return $this->queryScheduleConferenceInfoWithOptions($scheduleConferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询用户进行中会议
     *  *
     * @param QueryUserOnGoingConferenceRequest $request QueryUserOnGoingConferenceRequest
     * @param QueryUserOnGoingConferenceHeaders $headers QueryUserOnGoingConferenceHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserOnGoingConferenceResponse QueryUserOnGoingConferenceResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryUserOnGoingConference',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/users/lists',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryUserOnGoingConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户进行中会议
     *  *
     * @param QueryUserOnGoingConferenceRequest $request QueryUserOnGoingConferenceRequest
     *
     * @return QueryUserOnGoingConferenceResponse QueryUserOnGoingConferenceResponse
     */
    public function queryUserOnGoingConference($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserOnGoingConferenceHeaders([]);

        return $this->queryUserOnGoingConferenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 开启云录制
     *  *
     * @param string                  $conferenceId
     * @param StartCloudRecordRequest $request      StartCloudRecordRequest
     * @param StartCloudRecordHeaders $headers      StartCloudRecordHeaders
     * @param RuntimeOptions          $runtime      runtime options for this request RuntimeOptions
     *
     * @return StartCloudRecordResponse StartCloudRecordResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'StartCloudRecord',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/cloudRecords/start',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return StartCloudRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 开启云录制
     *  *
     * @param string                  $conferenceId
     * @param StartCloudRecordRequest $request      StartCloudRecordRequest
     *
     * @return StartCloudRecordResponse StartCloudRecordResponse
     */
    public function startCloudRecord($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartCloudRecordHeaders([]);

        return $this->startCloudRecordWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 开启会议闪记
     *  *
     * @param string              $conferenceId
     * @param StartMinutesRequest $request      StartMinutesRequest
     * @param StartMinutesHeaders $headers      StartMinutesHeaders
     * @param RuntimeOptions      $runtime      runtime options for this request RuntimeOptions
     *
     * @return StartMinutesResponse StartMinutesResponse
     */
    public function startMinutesWithOptions($conferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->ownerUnionId)) {
            $body['ownerUnionId'] = $request->ownerUnionId;
        }
        if (!Utils::isUnset($request->recordAudio)) {
            $body['recordAudio'] = $request->recordAudio;
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
            'action' => 'StartMinutes',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/minutes/start',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return StartMinutesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 开启会议闪记
     *  *
     * @param string              $conferenceId
     * @param StartMinutesRequest $request      StartMinutesRequest
     *
     * @return StartMinutesResponse StartMinutesResponse
     */
    public function startMinutes($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartMinutesHeaders([]);

        return $this->startMinutesWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 会议开始直播推流
     *  *
     * @param string                $conferenceId
     * @param StartStreamOutRequest $request      StartStreamOutRequest
     * @param StartStreamOutHeaders $headers      StartStreamOutHeaders
     * @param RuntimeOptions        $runtime      runtime options for this request RuntimeOptions
     *
     * @return StartStreamOutResponse StartStreamOutResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'StartStreamOut',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/streamOuts/start',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return StartStreamOutResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 会议开始直播推流
     *  *
     * @param string                $conferenceId
     * @param StartStreamOutRequest $request      StartStreamOutRequest
     *
     * @return StartStreamOutResponse StartStreamOutResponse
     */
    public function startStreamOut($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartStreamOutHeaders([]);

        return $this->startStreamOutWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 关闭云录制
     *  *
     * @param string                 $conferenceId
     * @param StopCloudRecordRequest $request      StopCloudRecordRequest
     * @param StopCloudRecordHeaders $headers      StopCloudRecordHeaders
     * @param RuntimeOptions         $runtime      runtime options for this request RuntimeOptions
     *
     * @return StopCloudRecordResponse StopCloudRecordResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'StopCloudRecord',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/cloudRecords/stop',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return StopCloudRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 关闭云录制
     *  *
     * @param string                 $conferenceId
     * @param StopCloudRecordRequest $request      StopCloudRecordRequest
     *
     * @return StopCloudRecordResponse StopCloudRecordResponse
     */
    public function stopCloudRecord($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StopCloudRecordHeaders([]);

        return $this->stopCloudRecordWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 暂停会议闪记
     *  *
     * @param string             $conferenceId
     * @param StopMinutesRequest $request      StopMinutesRequest
     * @param StopMinutesHeaders $headers      StopMinutesHeaders
     * @param RuntimeOptions     $runtime      runtime options for this request RuntimeOptions
     *
     * @return StopMinutesResponse StopMinutesResponse
     */
    public function stopMinutesWithOptions($conferenceId, $request, $headers, $runtime)
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'StopMinutes',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/minutes/pause',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return StopMinutesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 暂停会议闪记
     *  *
     * @param string             $conferenceId
     * @param StopMinutesRequest $request      StopMinutesRequest
     *
     * @return StopMinutesResponse StopMinutesResponse
     */
    public function stopMinutes($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StopMinutesHeaders([]);

        return $this->stopMinutesWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 会议停止直播推流
     *  *
     * @param string               $conferenceId
     * @param StopStreamOutRequest $request      StopStreamOutRequest
     * @param StopStreamOutHeaders $headers      StopStreamOutHeaders
     * @param RuntimeOptions       $runtime      runtime options for this request RuntimeOptions
     *
     * @return StopStreamOutResponse StopStreamOutResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'StopStreamOut',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/streamOuts/stop',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return StopStreamOutResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 会议停止直播推流
     *  *
     * @param string               $conferenceId
     * @param StopStreamOutRequest $request      StopStreamOutRequest
     *
     * @return StopStreamOutResponse StopStreamOutResponse
     */
    public function stopStreamOut($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StopStreamOutHeaders([]);

        return $this->stopStreamOutWithOptions($conferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新预约会议设置
     *  *
     * @param UpdateScheduleConfSettingsRequest $request UpdateScheduleConfSettingsRequest
     * @param UpdateScheduleConfSettingsHeaders $headers UpdateScheduleConfSettingsHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateScheduleConfSettingsResponse UpdateScheduleConfSettingsResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateScheduleConfSettings',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/scheduleConferences/settings',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateScheduleConfSettingsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新预约会议设置
     *  *
     * @param UpdateScheduleConfSettingsRequest $request UpdateScheduleConfSettingsRequest
     *
     * @return UpdateScheduleConfSettingsResponse UpdateScheduleConfSettingsResponse
     */
    public function updateScheduleConfSettings($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateScheduleConfSettingsHeaders([]);

        return $this->updateScheduleConfSettingsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新预约会议
     *  *
     * @param UpdateScheduleConferenceRequest $request UpdateScheduleConferenceRequest
     * @param UpdateScheduleConferenceHeaders $headers UpdateScheduleConferenceHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateScheduleConferenceResponse UpdateScheduleConferenceResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateScheduleConference',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/scheduleConferences',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateScheduleConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新预约会议
     *  *
     * @param UpdateScheduleConferenceRequest $request UpdateScheduleConferenceRequest
     *
     * @return UpdateScheduleConferenceResponse UpdateScheduleConferenceResponse
     */
    public function updateScheduleConference($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateScheduleConferenceHeaders([]);

        return $this->updateScheduleConferenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新会议额外信息
     *  *
     * @param string                              $conferenceId
     * @param UpdateVideoConferenceExtInfoHeaders $headers      UpdateVideoConferenceExtInfoHeaders
     * @param RuntimeOptions                      $runtime      runtime options for this request RuntimeOptions
     *
     * @return UpdateVideoConferenceExtInfoResponse UpdateVideoConferenceExtInfoResponse
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
            'action' => 'UpdateVideoConferenceExtInfo',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '/extInfo',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return UpdateVideoConferenceExtInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新会议额外信息
     *  *
     * @param string $conferenceId
     *
     * @return UpdateVideoConferenceExtInfoResponse UpdateVideoConferenceExtInfoResponse
     */
    public function updateVideoConferenceExtInfo($conferenceId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateVideoConferenceExtInfoHeaders([]);

        return $this->updateVideoConferenceExtInfoWithOptions($conferenceId, $headers, $runtime);
    }

    /**
     * @summary 设置会议中的会议属性
     *  *
     * @param string                              $conferenceId
     * @param UpdateVideoConferenceSettingRequest $request      UpdateVideoConferenceSettingRequest
     * @param UpdateVideoConferenceSettingHeaders $headers      UpdateVideoConferenceSettingHeaders
     * @param RuntimeOptions                      $runtime      runtime options for this request RuntimeOptions
     *
     * @return UpdateVideoConferenceSettingResponse UpdateVideoConferenceSettingResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'UpdateVideoConferenceSetting',
            'version' => 'conference_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/conference/videoConferences/' . $conferenceId . '',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateVideoConferenceSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置会议中的会议属性
     *  *
     * @param string                              $conferenceId
     * @param UpdateVideoConferenceSettingRequest $request      UpdateVideoConferenceSettingRequest
     *
     * @return UpdateVideoConferenceSettingResponse UpdateVideoConferenceSettingResponse
     */
    public function updateVideoConferenceSetting($conferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateVideoConferenceSettingHeaders([]);

        return $this->updateVideoConferenceSettingWithOptions($conferenceId, $request, $headers, $runtime);
    }
}
