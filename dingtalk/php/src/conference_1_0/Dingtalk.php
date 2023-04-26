<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CloseVideoConferenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CloseVideoConferenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CloseVideoConferenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CohostsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CohostsRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CohostsResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateVideoConferenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateVideoConferenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateVideoConferenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\FocusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\FocusRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\FocusResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\InviteUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\InviteUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\InviteUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\KickMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\KickMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\KickMembersResponse;
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
            'reqBodyType' => 'json',
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
            'reqBodyType' => 'json',
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
            'reqBodyType' => 'json',
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
