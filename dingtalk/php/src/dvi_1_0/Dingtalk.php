<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\BatchQueryUserDeviceStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\BatchQueryUserDeviceStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\BatchQueryUserDeviceStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ControlRecordingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ControlRecordingRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ControlRecordingResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\CreateAsrTranscriptionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\CreateAsrTranscriptionRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\CreateAsrTranscriptionResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\CreateRecordingScheduleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\CreateRecordingScheduleRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\CreateRecordingScheduleResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\CreateTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\CreateTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\CreateTeamResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\DeleteRecordingScheduleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\DeleteRecordingScheduleResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetAsrTranscriptionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetAsrTranscriptionRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetAsrTranscriptionResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetAudioFileDownloadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetAudioFileDownloadInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetAudioFileDownloadInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetAudioFileInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetAudioFileInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetAudioFileInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetCustomerInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetCustomerInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetCustomerInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetCustomerInsightHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetCustomerInsightRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetCustomerInsightResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetRecordingScheduleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetRecordingScheduleResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceChapterSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceChapterSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceChapterSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceChatSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceChatSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceChatSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceQualityInspectionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceQualityInspectionRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceQualityInspectionResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceRecordTranscriptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceRecordTranscriptRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceRecordTranscriptResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetSolutionConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetSolutionConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetTeamMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetTeamMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetTeamResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetTranscriptSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetTranscriptSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetTranscriptSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListDeviceRecordingDurationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListDeviceRecordingDurationRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListDeviceRecordingDurationResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListServiceRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListServiceRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListServiceRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListServiceTodoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListServiceTodoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListServiceTodoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListTeamResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ManageTeamMemberHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ManageTeamMemberRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ManageTeamMemberResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryAsrTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryAsrTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryAsrTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryAudioFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryAudioFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryAudioFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryDeviceDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryDeviceDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryDeviceDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryDeviceStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryDeviceStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryDeviceStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryFileInfoByMinutesIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryFileInfoByMinutesIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryFileInfoByMinutesIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryStaffStatisticDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryStaffStatisticDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryStaffStatisticDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryUserDeviceLocationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryUserDeviceLocationRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryUserDeviceLocationResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitAgentTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitAgentTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitAgentTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitAsrTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitAsrTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitAsrTaskResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitCustomerSplitDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitCustomerSplitDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitCustomerSplitDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitCustomerSplitDataShrinkRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\UpdateDeviceBindingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\UpdateDeviceBindingRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\UpdateDeviceBindingResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\UpdateRecordingScheduleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\UpdateRecordingScheduleRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\UpdateRecordingScheduleResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\UpdateTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\UpdateTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\UpdateTeamResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\VideoCustomerSplitHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\VideoCustomerSplitRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\VideoCustomerSplitResponse;
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
     * @summary 按 userId 列表批量查询用户绑定设备的状态
     *  *
     * @param BatchQueryUserDeviceStatusRequest $request BatchQueryUserDeviceStatusRequest
     * @param BatchQueryUserDeviceStatusHeaders $headers BatchQueryUserDeviceStatusHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchQueryUserDeviceStatusResponse BatchQueryUserDeviceStatusResponse
     */
    public function batchQueryUserDeviceStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userIdList)) {
            $body['userIdList'] = $request->userIdList;
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
            'action' => 'BatchQueryUserDeviceStatus',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/device/batchQueryUserDeviceStatus',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchQueryUserDeviceStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 按 userId 列表批量查询用户绑定设备的状态
     *  *
     * @param BatchQueryUserDeviceStatusRequest $request BatchQueryUserDeviceStatusRequest
     *
     * @return BatchQueryUserDeviceStatusResponse BatchQueryUserDeviceStatusResponse
     */
    public function batchQueryUserDeviceStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchQueryUserDeviceStatusHeaders([]);

        return $this->batchQueryUserDeviceStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设备录音启停控制
     *  *
     * @param ControlRecordingRequest $request ControlRecordingRequest
     * @param ControlRecordingHeaders $headers ControlRecordingHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return ControlRecordingResponse ControlRecordingResponse
     */
    public function controlRecordingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->agree)) {
            $body['agree'] = $request->agree;
        }
        if (!Utils::isUnset($request->outBizData)) {
            $body['outBizData'] = $request->outBizData;
        }
        if (!Utils::isUnset($request->teamCode)) {
            $body['teamCode'] = $request->teamCode;
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
            'action' => 'ControlRecording',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/devices/recording/control',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ControlRecordingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设备录音启停控制
     *  *
     * @param ControlRecordingRequest $request ControlRecordingRequest
     *
     * @return ControlRecordingResponse ControlRecordingResponse
     */
    public function controlRecording($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ControlRecordingHeaders([]);

        return $this->controlRecordingWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建ASR离线转写任务
     *  *
     * @param CreateAsrTranscriptionRequest $request CreateAsrTranscriptionRequest
     * @param CreateAsrTranscriptionHeaders $headers CreateAsrTranscriptionHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateAsrTranscriptionResponse CreateAsrTranscriptionResponse
     */
    public function createAsrTranscriptionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizKey)) {
            $body['bizKey'] = $request->bizKey;
        }
        if (!Utils::isUnset($request->phrases)) {
            $body['phrases'] = $request->phrases;
        }
        if (!Utils::isUnset($request->url)) {
            $body['url'] = $request->url;
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
            'action' => 'CreateAsrTranscription',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/asr/transcriptions',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateAsrTranscriptionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建ASR离线转写任务
     *  *
     * @param CreateAsrTranscriptionRequest $request CreateAsrTranscriptionRequest
     *
     * @return CreateAsrTranscriptionResponse CreateAsrTranscriptionResponse
     */
    public function createAsrTranscription($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateAsrTranscriptionHeaders([]);

        return $this->createAsrTranscriptionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建录制计划
     *  *
     * @param CreateRecordingScheduleRequest $request CreateRecordingScheduleRequest
     * @param CreateRecordingScheduleHeaders $headers CreateRecordingScheduleHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateRecordingScheduleResponse CreateRecordingScheduleResponse
     */
    public function createRecordingScheduleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->schedules)) {
            $body['schedules'] = $request->schedules;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
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
            'action' => 'CreateRecordingSchedule',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/devices/recording/schedules',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateRecordingScheduleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建录制计划
     *  *
     * @param CreateRecordingScheduleRequest $request CreateRecordingScheduleRequest
     *
     * @return CreateRecordingScheduleResponse CreateRecordingScheduleResponse
     */
    public function createRecordingSchedule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateRecordingScheduleHeaders([]);

        return $this->createRecordingScheduleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建团队
     *  *
     * @param CreateTeamRequest $request CreateTeamRequest
     * @param CreateTeamHeaders $headers CreateTeamHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTeamResponse CreateTeamResponse
     */
    public function createTeamWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->adminUserIds)) {
            $body['adminUserIds'] = $request->adminUserIds;
        }
        if (!Utils::isUnset($request->deptIds)) {
            $body['deptIds'] = $request->deptIds;
        }
        if (!Utils::isUnset($request->dialectCode)) {
            $body['dialectCode'] = $request->dialectCode;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->sceneCodes)) {
            $body['sceneCodes'] = $request->sceneCodes;
        }
        if (!Utils::isUnset($request->solutionCode)) {
            $body['solutionCode'] = $request->solutionCode;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateTeam',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/teams',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateTeamResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建团队
     *  *
     * @param CreateTeamRequest $request CreateTeamRequest
     *
     * @return CreateTeamResponse CreateTeamResponse
     */
    public function createTeam($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTeamHeaders([]);

        return $this->createTeamWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除录制计划
     *  *
     * @param string                         $taskId
     * @param DeleteRecordingScheduleHeaders $headers DeleteRecordingScheduleHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteRecordingScheduleResponse DeleteRecordingScheduleResponse
     */
    public function deleteRecordingScheduleWithOptions($taskId, $headers, $runtime)
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
            'action' => 'DeleteRecordingSchedule',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/devices/recording/schedules/' . $taskId . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteRecordingScheduleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除录制计划
     *  *
     * @param string $taskId
     *
     * @return DeleteRecordingScheduleResponse DeleteRecordingScheduleResponse
     */
    public function deleteRecordingSchedule($taskId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteRecordingScheduleHeaders([]);

        return $this->deleteRecordingScheduleWithOptions($taskId, $headers, $runtime);
    }

    /**
     * @summary 查询ASR转写结果
     *  *
     * @param GetAsrTranscriptionRequest $request GetAsrTranscriptionRequest
     * @param GetAsrTranscriptionHeaders $headers GetAsrTranscriptionHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAsrTranscriptionResponse GetAsrTranscriptionResponse
     */
    public function getAsrTranscriptionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->taskId)) {
            $query['taskId'] = $request->taskId;
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
            'action' => 'GetAsrTranscription',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/asr/transcriptions',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetAsrTranscriptionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询ASR转写结果
     *  *
     * @param GetAsrTranscriptionRequest $request GetAsrTranscriptionRequest
     *
     * @return GetAsrTranscriptionResponse GetAsrTranscriptionResponse
     */
    public function getAsrTranscription($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAsrTranscriptionHeaders([]);

        return $this->getAsrTranscriptionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取音频文件下载地址
     *  *
     * @param GetAudioFileDownloadInfoRequest $request GetAudioFileDownloadInfoRequest
     * @param GetAudioFileDownloadInfoHeaders $headers GetAudioFileDownloadInfoHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAudioFileDownloadInfoResponse GetAudioFileDownloadInfoResponse
     */
    public function getAudioFileDownloadInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceType)) {
            $body['deviceType'] = $request->deviceType;
        }
        if (!Utils::isUnset($request->fileId)) {
            $body['fileId'] = $request->fileId;
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
            'action' => 'GetAudioFileDownloadInfo',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/device/audio/download',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetAudioFileDownloadInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取音频文件下载地址
     *  *
     * @param GetAudioFileDownloadInfoRequest $request GetAudioFileDownloadInfoRequest
     *
     * @return GetAudioFileDownloadInfoResponse GetAudioFileDownloadInfoResponse
     */
    public function getAudioFileDownloadInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAudioFileDownloadInfoHeaders([]);

        return $this->getAudioFileDownloadInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取音频文件信息
     *  *
     * @param GetAudioFileInfoRequest $request GetAudioFileInfoRequest
     * @param GetAudioFileInfoHeaders $headers GetAudioFileInfoHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAudioFileInfoResponse GetAudioFileInfoResponse
     */
    public function getAudioFileInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceType)) {
            $body['deviceType'] = $request->deviceType;
        }
        if (!Utils::isUnset($request->fileId)) {
            $body['fileId'] = $request->fileId;
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
            'action' => 'GetAudioFileInfo',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/device/audio/get',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetAudioFileInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取音频文件信息
     *  *
     * @param GetAudioFileInfoRequest $request GetAudioFileInfoRequest
     *
     * @return GetAudioFileInfoResponse GetAudioFileInfoResponse
     */
    public function getAudioFileInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAudioFileInfoHeaders([]);

        return $this->getAudioFileInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询客户数据
     *  *
     * @param GetCustomerInfoRequest $request GetCustomerInfoRequest
     * @param GetCustomerInfoHeaders $headers GetCustomerInfoHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCustomerInfoResponse GetCustomerInfoResponse
     */
    public function getCustomerInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->customerId)) {
            $query['customerId'] = $request->customerId;
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
            'action' => 'GetCustomerInfo',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/customer',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetCustomerInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询客户数据
     *  *
     * @param GetCustomerInfoRequest $request GetCustomerInfoRequest
     *
     * @return GetCustomerInfoResponse GetCustomerInfoResponse
     */
    public function getCustomerInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCustomerInfoHeaders([]);

        return $this->getCustomerInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取客户洞察信息
     *  *
     * @param GetCustomerInsightRequest $request GetCustomerInsightRequest
     * @param GetCustomerInsightHeaders $headers GetCustomerInsightHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCustomerInsightResponse GetCustomerInsightResponse
     */
    public function getCustomerInsightWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->customerId)) {
            $query['customerId'] = $request->customerId;
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
            'action' => 'GetCustomerInsight',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/customers/insights',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetCustomerInsightResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取客户洞察信息
     *  *
     * @param GetCustomerInsightRequest $request GetCustomerInsightRequest
     *
     * @return GetCustomerInsightResponse GetCustomerInsightResponse
     */
    public function getCustomerInsight($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCustomerInsightHeaders([]);

        return $this->getCustomerInsightWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取录制计划
     *  *
     * @param string                      $taskId
     * @param GetRecordingScheduleHeaders $headers GetRecordingScheduleHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetRecordingScheduleResponse GetRecordingScheduleResponse
     */
    public function getRecordingScheduleWithOptions($taskId, $headers, $runtime)
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
            'action' => 'GetRecordingSchedule',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/devices/recording/schedules/' . $taskId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetRecordingScheduleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取录制计划
     *  *
     * @param string $taskId
     *
     * @return GetRecordingScheduleResponse GetRecordingScheduleResponse
     */
    public function getRecordingSchedule($taskId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRecordingScheduleHeaders([]);

        return $this->getRecordingScheduleWithOptions($taskId, $headers, $runtime);
    }

    /**
     * @summary 获取服务章节摘要
     *  *
     * @param GetServiceChapterSummaryRequest $request GetServiceChapterSummaryRequest
     * @param GetServiceChapterSummaryHeaders $headers GetServiceChapterSummaryHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetServiceChapterSummaryResponse GetServiceChapterSummaryResponse
     */
    public function getServiceChapterSummaryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->recordId)) {
            $query['recordId'] = $request->recordId;
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
            'action' => 'GetServiceChapterSummary',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/service/chapters/summary',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetServiceChapterSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取服务章节摘要
     *  *
     * @param GetServiceChapterSummaryRequest $request GetServiceChapterSummaryRequest
     *
     * @return GetServiceChapterSummaryResponse GetServiceChapterSummaryResponse
     */
    public function getServiceChapterSummary($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetServiceChapterSummaryHeaders([]);

        return $this->getServiceChapterSummaryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取服务会话总结
     *  *
     * @param GetServiceChatSummaryRequest $request GetServiceChatSummaryRequest
     * @param GetServiceChatSummaryHeaders $headers GetServiceChatSummaryHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetServiceChatSummaryResponse GetServiceChatSummaryResponse
     */
    public function getServiceChatSummaryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->recordId)) {
            $query['recordId'] = $request->recordId;
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
            'action' => 'GetServiceChatSummary',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/service/chats/summary',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetServiceChatSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取服务会话总结
     *  *
     * @param GetServiceChatSummaryRequest $request GetServiceChatSummaryRequest
     *
     * @return GetServiceChatSummaryResponse GetServiceChatSummaryResponse
     */
    public function getServiceChatSummary($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetServiceChatSummaryHeaders([]);

        return $this->getServiceChatSummaryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询服务质检信息
     *  *
     * @param GetServiceQualityInspectionRequest $request GetServiceQualityInspectionRequest
     * @param GetServiceQualityInspectionHeaders $headers GetServiceQualityInspectionHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetServiceQualityInspectionResponse GetServiceQualityInspectionResponse
     */
    public function getServiceQualityInspectionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->recordId)) {
            $query['recordId'] = $request->recordId;
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
            'action' => 'GetServiceQualityInspection',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/service/quality-inspections',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetServiceQualityInspectionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询服务质检信息
     *  *
     * @param GetServiceQualityInspectionRequest $request GetServiceQualityInspectionRequest
     *
     * @return GetServiceQualityInspectionResponse GetServiceQualityInspectionResponse
     */
    public function getServiceQualityInspection($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetServiceQualityInspectionHeaders([]);

        return $this->getServiceQualityInspectionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取单条服务记录
     *  *
     * @param GetServiceRecordRequest $request GetServiceRecordRequest
     * @param GetServiceRecordHeaders $headers GetServiceRecordHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetServiceRecordResponse GetServiceRecordResponse
     */
    public function getServiceRecordWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->id)) {
            $query['id'] = $request->id;
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
            'action' => 'GetServiceRecord',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/service-record',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetServiceRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取单条服务记录
     *  *
     * @param GetServiceRecordRequest $request GetServiceRecordRequest
     *
     * @return GetServiceRecordResponse GetServiceRecordResponse
     */
    public function getServiceRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetServiceRecordHeaders([]);

        return $this->getServiceRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取服务记录音频转写信息
     *  *
     * @param GetServiceRecordTranscriptRequest $request GetServiceRecordTranscriptRequest
     * @param GetServiceRecordTranscriptHeaders $headers GetServiceRecordTranscriptHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetServiceRecordTranscriptResponse GetServiceRecordTranscriptResponse
     */
    public function getServiceRecordTranscriptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->id)) {
            $query['id'] = $request->id;
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
            'action' => 'GetServiceRecordTranscript',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/service/transcript',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetServiceRecordTranscriptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取服务记录音频转写信息
     *  *
     * @param GetServiceRecordTranscriptRequest $request GetServiceRecordTranscriptRequest
     *
     * @return GetServiceRecordTranscriptResponse GetServiceRecordTranscriptResponse
     */
    public function getServiceRecordTranscript($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetServiceRecordTranscriptHeaders([]);

        return $this->getServiceRecordTranscriptWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取分析方案配置
     *  *
     * @param GetSolutionConfigHeaders $headers GetSolutionConfigHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSolutionConfigResponse GetSolutionConfigResponse
     */
    public function getSolutionConfigWithOptions($headers, $runtime)
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
            'action' => 'GetSolutionConfig',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/solutions/configurations',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetSolutionConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取分析方案配置
     *  *
     * @return GetSolutionConfigResponse GetSolutionConfigResponse
     */
    public function getSolutionConfig()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSolutionConfigHeaders([]);

        return $this->getSolutionConfigWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取团队信息
     *  *
     * @param string         $teamCode
     * @param GetTeamHeaders $headers  GetTeamHeaders
     * @param RuntimeOptions $runtime  runtime options for this request RuntimeOptions
     *
     * @return GetTeamResponse GetTeamResponse
     */
    public function getTeamWithOptions($teamCode, $headers, $runtime)
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
            'action' => 'GetTeam',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/teams/' . $teamCode . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetTeamResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取团队信息
     *  *
     * @param string $teamCode
     *
     * @return GetTeamResponse GetTeamResponse
     */
    public function getTeam($teamCode)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTeamHeaders([]);

        return $this->getTeamWithOptions($teamCode, $headers, $runtime);
    }

    /**
     * @summary 查询团队成员
     *  *
     * @param string               $teamCode
     * @param GetTeamMemberHeaders $headers  GetTeamMemberHeaders
     * @param RuntimeOptions       $runtime  runtime options for this request RuntimeOptions
     *
     * @return GetTeamMemberResponse GetTeamMemberResponse
     */
    public function getTeamMemberWithOptions($teamCode, $headers, $runtime)
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
            'action' => 'GetTeamMember',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/teams/' . $teamCode . '/members',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetTeamMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询团队成员
     *  *
     * @param string $teamCode
     *
     * @return GetTeamMemberResponse GetTeamMemberResponse
     */
    public function getTeamMember($teamCode)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTeamMemberHeaders([]);

        return $this->getTeamMemberWithOptions($teamCode, $headers, $runtime);
    }

    /**
     * @summary 获取文件转写的概要信息
     *  *
     * @param GetTranscriptSummaryRequest $request GetTranscriptSummaryRequest
     * @param GetTranscriptSummaryHeaders $headers GetTranscriptSummaryHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTranscriptSummaryResponse GetTranscriptSummaryResponse
     */
    public function getTranscriptSummaryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->deviceType)) {
            $query['deviceType'] = $request->deviceType;
        }
        if (!Utils::isUnset($request->fileId)) {
            $query['fileId'] = $request->fileId;
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
            'action' => 'GetTranscriptSummary',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/transcripts/summary',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetTranscriptSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取文件转写的概要信息
     *  *
     * @param GetTranscriptSummaryRequest $request GetTranscriptSummaryRequest
     *
     * @return GetTranscriptSummaryResponse GetTranscriptSummaryResponse
     */
    public function getTranscriptSummary($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTranscriptSummaryHeaders([]);

        return $this->getTranscriptSummaryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询客户列表
     *  *
     * @param ListCustomerRequest $request ListCustomerRequest
     * @param ListCustomerHeaders $headers ListCustomerHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return ListCustomerResponse ListCustomerResponse
     */
    public function listCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->ownerUserId)) {
            $query['ownerUserId'] = $request->ownerUserId;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->teamCode)) {
            $query['teamCode'] = $request->teamCode;
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
            'action' => 'ListCustomer',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/customers',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListCustomerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询客户列表
     *  *
     * @param ListCustomerRequest $request ListCustomerRequest
     *
     * @return ListCustomerResponse ListCustomerResponse
     */
    public function listCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListCustomerHeaders([]);

        return $this->listCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页查询设备列表
     *  *
     * @param ListDeviceRequest $request ListDeviceRequest
     * @param ListDeviceHeaders $headers ListDeviceHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return ListDeviceResponse ListDeviceResponse
     */
    public function listDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->sn)) {
            $query['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->teamCode)) {
            $query['teamCode'] = $request->teamCode;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ListDevice',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/devices',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页查询设备列表
     *  *
     * @param ListDeviceRequest $request ListDeviceRequest
     *
     * @return ListDeviceResponse ListDeviceResponse
     */
    public function listDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListDeviceHeaders([]);

        return $this->listDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页查询设备录音时长
     *  *
     * @param ListDeviceRecordingDurationRequest $request ListDeviceRecordingDurationRequest
     * @param ListDeviceRecordingDurationHeaders $headers ListDeviceRecordingDurationHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return ListDeviceRecordingDurationResponse ListDeviceRecordingDurationResponse
     */
    public function listDeviceRecordingDurationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->sn)) {
            $query['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->teamCode)) {
            $query['teamCode'] = $request->teamCode;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ListDeviceRecordingDuration',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/devices/recording-durations',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListDeviceRecordingDurationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页查询设备录音时长
     *  *
     * @param ListDeviceRecordingDurationRequest $request ListDeviceRecordingDurationRequest
     *
     * @return ListDeviceRecordingDurationResponse ListDeviceRecordingDurationResponse
     */
    public function listDeviceRecordingDuration($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListDeviceRecordingDurationHeaders([]);

        return $this->listDeviceRecordingDurationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页查询服务记录
     *  *
     * @param ListServiceRecordRequest $request ListServiceRecordRequest
     * @param ListServiceRecordHeaders $headers ListServiceRecordHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return ListServiceRecordResponse ListServiceRecordResponse
     */
    public function listServiceRecordWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->customerId)) {
            $query['customerId'] = $request->customerId;
        }
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
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
        if (!Utils::isUnset($request->teamCode)) {
            $query['teamCode'] = $request->teamCode;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ListServiceRecord',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/service-records',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListServiceRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页查询服务记录
     *  *
     * @param ListServiceRecordRequest $request ListServiceRecordRequest
     *
     * @return ListServiceRecordResponse ListServiceRecordResponse
     */
    public function listServiceRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListServiceRecordHeaders([]);

        return $this->listServiceRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询服务记录待办列表
     *  *
     * @param ListServiceTodoRequest $request ListServiceTodoRequest
     * @param ListServiceTodoHeaders $headers ListServiceTodoHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ListServiceTodoResponse ListServiceTodoResponse
     */
    public function listServiceTodoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->recordId)) {
            $query['recordId'] = $request->recordId;
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
            'action' => 'ListServiceTodo',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/service-todos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListServiceTodoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询服务记录待办列表
     *  *
     * @param ListServiceTodoRequest $request ListServiceTodoRequest
     *
     * @return ListServiceTodoResponse ListServiceTodoResponse
     */
    public function listServiceTodo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListServiceTodoHeaders([]);

        return $this->listServiceTodoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询团队列表
     *  *
     * @param ListTeamRequest $request ListTeamRequest
     * @param ListTeamHeaders $headers ListTeamHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return ListTeamResponse ListTeamResponse
     */
    public function listTeamWithOptions($request, $headers, $runtime)
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
            'action' => 'ListTeam',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/teams',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ListTeamResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询团队列表
     *  *
     * @param ListTeamRequest $request ListTeamRequest
     *
     * @return ListTeamResponse ListTeamResponse
     */
    public function listTeam($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListTeamHeaders([]);

        return $this->listTeamWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 团队成员管理
     *  *
     * @param ManageTeamMemberRequest $request ManageTeamMemberRequest
     * @param ManageTeamMemberHeaders $headers ManageTeamMemberHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return ManageTeamMemberResponse ManageTeamMemberResponse
     */
    public function manageTeamMemberWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->addMembers)) {
            $body['addMembers'] = $request->addMembers;
        }
        if (!Utils::isUnset($request->removeMembers)) {
            $body['removeMembers'] = $request->removeMembers;
        }
        if (!Utils::isUnset($request->teamCode)) {
            $body['teamCode'] = $request->teamCode;
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
            'action' => 'ManageTeamMember',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/teams/members',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ManageTeamMemberResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 团队成员管理
     *  *
     * @param ManageTeamMemberRequest $request ManageTeamMemberRequest
     *
     * @return ManageTeamMemberResponse ManageTeamMemberResponse
     */
    public function manageTeamMember($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ManageTeamMemberHeaders([]);

        return $this->manageTeamMemberWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询asr结果
     *  *
     * @param QueryAsrTaskRequest $request QueryAsrTaskRequest
     * @param QueryAsrTaskHeaders $headers QueryAsrTaskHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAsrTaskResponse QueryAsrTaskResponse
     */
    public function queryAsrTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->taskId)) {
            $query['taskId'] = $request->taskId;
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
            'action' => 'QueryAsrTask',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/asr/query',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryAsrTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询asr结果
     *  *
     * @param QueryAsrTaskRequest $request QueryAsrTaskRequest
     *
     * @return QueryAsrTaskResponse QueryAsrTaskResponse
     */
    public function queryAsrTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAsrTaskHeaders([]);

        return $this->queryAsrTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页查询指定设备的音频文件列表
     *  *
     * @param QueryAudioFileRequest $request QueryAudioFileRequest
     * @param QueryAudioFileHeaders $headers QueryAudioFileHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAudioFileResponse QueryAudioFileResponse
     */
    public function queryAudioFileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceType)) {
            $body['deviceType'] = $request->deviceType;
        }
        if (!Utils::isUnset($request->endTimestamp)) {
            $body['endTimestamp'] = $request->endTimestamp;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->startTimestamp)) {
            $body['startTimestamp'] = $request->startTimestamp;
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
            'action' => 'QueryAudioFile',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/device/audio/list',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryAudioFileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页查询指定设备的音频文件列表
     *  *
     * @param QueryAudioFileRequest $request QueryAudioFileRequest
     *
     * @return QueryAudioFileResponse QueryAudioFileResponse
     */
    public function queryAudioFile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAudioFileHeaders([]);

        return $this->queryAudioFileWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取设备列表
     *  *
     * @param QueryDeviceDetailRequest $request QueryDeviceDetailRequest
     * @param QueryDeviceDetailHeaders $headers QueryDeviceDetailHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDeviceDetailResponse QueryDeviceDetailResponse
     */
    public function queryDeviceDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceType)) {
            $body['deviceType'] = $request->deviceType;
        }
        if (!Utils::isUnset($request->snList)) {
            $body['snList'] = $request->snList;
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
            'action' => 'QueryDeviceDetail',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/device/list',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryDeviceDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取设备列表
     *  *
     * @param QueryDeviceDetailRequest $request QueryDeviceDetailRequest
     *
     * @return QueryDeviceDetailResponse QueryDeviceDetailResponse
     */
    public function queryDeviceDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceDetailHeaders([]);

        return $this->queryDeviceDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询设备属性
     *  *
     * @param QueryDeviceStatusRequest $request QueryDeviceStatusRequest
     * @param QueryDeviceStatusHeaders $headers QueryDeviceStatusHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDeviceStatusResponse QueryDeviceStatusResponse
     */
    public function queryDeviceStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceType)) {
            $body['deviceType'] = $request->deviceType;
        }
        if (!Utils::isUnset($request->snList)) {
            $body['snList'] = $request->snList;
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
            'action' => 'QueryDeviceStatus',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/device/status',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryDeviceStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询设备属性
     *  *
     * @param QueryDeviceStatusRequest $request QueryDeviceStatusRequest
     *
     * @return QueryDeviceStatusResponse QueryDeviceStatusResponse
     */
    public function queryDeviceStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceStatusHeaders([]);

        return $this->queryDeviceStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据听记ID获取A1音频文件信息
     *  *
     * @param QueryFileInfoByMinutesIdRequest $request QueryFileInfoByMinutesIdRequest
     * @param QueryFileInfoByMinutesIdHeaders $headers QueryFileInfoByMinutesIdHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryFileInfoByMinutesIdResponse QueryFileInfoByMinutesIdResponse
     */
    public function queryFileInfoByMinutesIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->minutesId)) {
            $query['minutesId'] = $request->minutesId;
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
            'action' => 'QueryFileInfoByMinutesId',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/audios/minutes',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryFileInfoByMinutesIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据听记ID获取A1音频文件信息
     *  *
     * @param QueryFileInfoByMinutesIdRequest $request QueryFileInfoByMinutesIdRequest
     *
     * @return QueryFileInfoByMinutesIdResponse QueryFileInfoByMinutesIdResponse
     */
    public function queryFileInfoByMinutesId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryFileInfoByMinutesIdHeaders([]);

        return $this->queryFileInfoByMinutesIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页查询员工统计数据
     *  *
     * @param QueryStaffStatisticDataRequest $request QueryStaffStatisticDataRequest
     * @param QueryStaffStatisticDataHeaders $headers QueryStaffStatisticDataHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryStaffStatisticDataResponse QueryStaffStatisticDataResponse
     */
    public function queryStaffStatisticDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->day)) {
            $query['day'] = $request->day;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->teamCode)) {
            $query['teamCode'] = $request->teamCode;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryStaffStatisticData',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/data/staff',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryStaffStatisticDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页查询员工统计数据
     *  *
     * @param QueryStaffStatisticDataRequest $request QueryStaffStatisticDataRequest
     *
     * @return QueryStaffStatisticDataResponse QueryStaffStatisticDataResponse
     */
    public function queryStaffStatisticData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryStaffStatisticDataHeaders([]);

        return $this->queryStaffStatisticDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据员工 userId 查询其当前绑定设备在指定时间范围内的位置（轨迹）信息
     *  *
     * @param QueryUserDeviceLocationRequest $request QueryUserDeviceLocationRequest
     * @param QueryUserDeviceLocationHeaders $headers QueryUserDeviceLocationHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserDeviceLocationResponse QueryUserDeviceLocationResponse
     */
    public function queryUserDeviceLocationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->sn)) {
            $query['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'QueryUserDeviceLocation',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/device/queryUserDeviceLocation',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryUserDeviceLocationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据员工 userId 查询其当前绑定设备在指定时间范围内的位置（轨迹）信息
     *  *
     * @param QueryUserDeviceLocationRequest $request QueryUserDeviceLocationRequest
     *
     * @return QueryUserDeviceLocationResponse QueryUserDeviceLocationResponse
     */
    public function queryUserDeviceLocation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserDeviceLocationHeaders([]);

        return $this->queryUserDeviceLocationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 提交agent异步任务
     *  *
     * @param SubmitAgentTaskRequest $request SubmitAgentTaskRequest
     * @param SubmitAgentTaskHeaders $headers SubmitAgentTaskHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return SubmitAgentTaskResponse SubmitAgentTaskResponse
     */
    public function submitAgentTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->agentCode)) {
            $query['agentCode'] = $request->agentCode;
        }
        if (!Utils::isUnset($request->bizIdentify)) {
            $query['bizIdentify'] = $request->bizIdentify;
        }
        if (!Utils::isUnset($request->input)) {
            $query['input'] = $request->input;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'SubmitAgentTask',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/agenttask/submit',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SubmitAgentTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 提交agent异步任务
     *  *
     * @param SubmitAgentTaskRequest $request SubmitAgentTaskRequest
     *
     * @return SubmitAgentTaskResponse SubmitAgentTaskResponse
     */
    public function submitAgentTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SubmitAgentTaskHeaders([]);

        return $this->submitAgentTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary asr离线任务
     *  *
     * @param SubmitAsrTaskRequest $request SubmitAsrTaskRequest
     * @param SubmitAsrTaskHeaders $headers SubmitAsrTaskHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return SubmitAsrTaskResponse SubmitAsrTaskResponse
     */
    public function submitAsrTaskWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizKey)) {
            $body['bizKey'] = $request->bizKey;
        }
        if (!Utils::isUnset($request->dentryId)) {
            $body['dentryId'] = $request->dentryId;
        }
        if (!Utils::isUnset($request->phrases)) {
            $body['phrases'] = $request->phrases;
        }
        if (!Utils::isUnset($request->sourceLanguage)) {
            $body['sourceLanguage'] = $request->sourceLanguage;
        }
        if (!Utils::isUnset($request->spaceId)) {
            $body['spaceId'] = $request->spaceId;
        }
        if (!Utils::isUnset($request->transcription)) {
            $body['transcription'] = $request->transcription;
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
            'action' => 'SubmitAsrTask',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/asr/create',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SubmitAsrTaskResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary asr离线任务
     *  *
     * @param SubmitAsrTaskRequest $request SubmitAsrTaskRequest
     *
     * @return SubmitAsrTaskResponse SubmitAsrTaskResponse
     */
    public function submitAsrTask($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SubmitAsrTaskHeaders([]);

        return $this->submitAsrTaskWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 提交切客数据
     *  *
     * @param SubmitCustomerSplitDataRequest $tmpReq  SubmitCustomerSplitDataRequest
     * @param SubmitCustomerSplitDataHeaders $headers SubmitCustomerSplitDataHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return SubmitCustomerSplitDataResponse SubmitCustomerSplitDataResponse
     */
    public function submitCustomerSplitDataWithOptions($tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new SubmitCustomerSplitDataShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->splitParams)) {
            $request->splitParamsShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->splitParams, 'splitParams', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->splitParamsShrink)) {
            $query['splitParams'] = $request->splitParamsShrink;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'SubmitCustomerSplitData',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/customersplit/submit',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SubmitCustomerSplitDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 提交切客数据
     *  *
     * @param SubmitCustomerSplitDataRequest $request SubmitCustomerSplitDataRequest
     *
     * @return SubmitCustomerSplitDataResponse SubmitCustomerSplitDataResponse
     */
    public function submitCustomerSplitData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SubmitCustomerSplitDataHeaders([]);

        return $this->submitCustomerSplitDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新设备绑定关系
     *  *
     * @param UpdateDeviceBindingRequest $request UpdateDeviceBindingRequest
     * @param UpdateDeviceBindingHeaders $headers UpdateDeviceBindingHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateDeviceBindingResponse UpdateDeviceBindingResponse
     */
    public function updateDeviceBindingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->action)) {
            $body['action'] = $request->action;
        }
        if (!Utils::isUnset($request->sn)) {
            $body['sn'] = $request->sn;
        }
        if (!Utils::isUnset($request->teamCode)) {
            $body['teamCode'] = $request->teamCode;
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
            'action' => 'UpdateDeviceBinding',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/devices/binding/update',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateDeviceBindingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新设备绑定关系
     *  *
     * @param UpdateDeviceBindingRequest $request UpdateDeviceBindingRequest
     *
     * @return UpdateDeviceBindingResponse UpdateDeviceBindingResponse
     */
    public function updateDeviceBinding($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateDeviceBindingHeaders([]);

        return $this->updateDeviceBindingWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新录制计划
     *  *
     * @param UpdateRecordingScheduleRequest $request UpdateRecordingScheduleRequest
     * @param UpdateRecordingScheduleHeaders $headers UpdateRecordingScheduleHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateRecordingScheduleResponse UpdateRecordingScheduleResponse
     */
    public function updateRecordingScheduleWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->taskId)) {
            $body['taskId'] = $request->taskId;
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
            'action' => 'UpdateRecordingSchedule',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/devices/recording/schedules',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateRecordingScheduleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新录制计划
     *  *
     * @param UpdateRecordingScheduleRequest $request UpdateRecordingScheduleRequest
     *
     * @return UpdateRecordingScheduleResponse UpdateRecordingScheduleResponse
     */
    public function updateRecordingSchedule($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateRecordingScheduleHeaders([]);

        return $this->updateRecordingScheduleWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改团队
     *  *
     * @param UpdateTeamRequest $request UpdateTeamRequest
     * @param UpdateTeamHeaders $headers UpdateTeamHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTeamResponse UpdateTeamResponse
     */
    public function updateTeamWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dialectCode)) {
            $body['dialectCode'] = $request->dialectCode;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->sceneCodes)) {
            $body['sceneCodes'] = $request->sceneCodes;
        }
        if (!Utils::isUnset($request->teamCode)) {
            $body['teamCode'] = $request->teamCode;
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
            'action' => 'UpdateTeam',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/teams',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateTeamResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改团队
     *  *
     * @param UpdateTeamRequest $request UpdateTeamRequest
     *
     * @return UpdateTeamResponse UpdateTeamResponse
     */
    public function updateTeam($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTeamHeaders([]);

        return $this->updateTeamWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary asr离线任务
     *  *
     * @param VideoCustomerSplitRequest $request VideoCustomerSplitRequest
     * @param VideoCustomerSplitHeaders $headers VideoCustomerSplitHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return VideoCustomerSplitResponse VideoCustomerSplitResponse
     */
    public function videoCustomerSplitWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->customer)) {
            $body['customer'] = $request->customer;
        }
        if (!Utils::isUnset($request->segmentId)) {
            $body['segmentId'] = $request->segmentId;
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
            'action' => 'VideoCustomerSplit',
            'version' => 'dvi_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/dvi/service/audiosplit',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return VideoCustomerSplitResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary asr离线任务
     *  *
     * @param VideoCustomerSplitRequest $request VideoCustomerSplitRequest
     *
     * @return VideoCustomerSplitResponse VideoCustomerSplitResponse
     */
    public function videoCustomerSplit($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new VideoCustomerSplitHeaders([]);

        return $this->videoCustomerSplitWithOptions($request, $headers, $runtime);
    }
}
