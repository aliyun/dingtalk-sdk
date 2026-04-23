<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\AdminSearchMinutesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\AdminSearchMinutesRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\AdminSearchMinutesResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchGetMinutesDetailsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchGetMinutesDetailsRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchGetMinutesDetailsResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchGetVoicePrintIdentifyConfigHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchGetVoicePrintIdentifyConfigRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchGetVoicePrintIdentifyConfigResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchToggleVoicePrintSwitchStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchToggleVoicePrintSwitchStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchToggleVoicePrintSwitchStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\CreateMinutesByUploadFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\CreateMinutesByUploadFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\CreateMinutesByUploadFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\CreateSmartDeviceAiSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\CreateSmartDeviceAiSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\CreateSmartDeviceAiSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\DeleteMinutesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\DeleteMinutesRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\DeleteMinutesResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\ExportMinutesTaskResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\ExportMinutesTaskResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\ExportMinutesTaskResultResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\GenerateSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\GenerateSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\GenerateSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\OpenQueryMinutesSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\OpenQueryMinutesSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\OpenQueryMinutesSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryBizMinutesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryBizMinutesRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryBizMinutesResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryCreateMinutesListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryCreateMinutesListRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryCreateMinutesListResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesBasicInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesBasicInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesBasicInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesChaptersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesChaptersRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesChaptersResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesKeywordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesKeywordRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesKeywordResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesPlayInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesPlayInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesPlayInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesShareListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesShareListRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesShareListResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTextHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTextRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTextResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTodoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTodoRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTodoResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryOrgDiyTemplatesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryOrgDiyTemplatesRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryOrgDiyTemplatesResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryScheduleConfMinutesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryScheduleConfMinutesRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryScheduleConfMinutesResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSummaryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSummaryRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSummaryResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySummaryWithTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySummaryWithTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySummaryWithTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryUploadVideoPlayInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryUploadVideoPlayInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryUploadVideoPlayInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryUserAvailableDiyTemplatesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryUserAvailableDiyTemplatesRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryUserAvailableDiyTemplatesResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryUserMinutesPermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryUserMinutesPermissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\RegenerateChaptersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\RegenerateChaptersRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\RegenerateChaptersResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\SetDetailPageCustomTabHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\SetDetailPageCustomTabRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\SetDetailPageCustomTabResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\SetInProgressCustomTabsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\SetInProgressCustomTabsRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\SetInProgressCustomTabsResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\SetMinutesTodosVisibleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\SetMinutesTodosVisibleRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\SetMinutesTodosVisibleResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdateMinutesTitleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdateMinutesTitleRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdateMinutesTitleResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdatePermissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdatePermissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdatePermissionResponse;
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
     * @summary 搜索企业内听记
     *  *
     * @param AdminSearchMinutesRequest $request AdminSearchMinutesRequest
     * @param AdminSearchMinutesHeaders $headers AdminSearchMinutesHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return AdminSearchMinutesResponse AdminSearchMinutesResponse
     */
    public function adminSearchMinutesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->creatorUnionIds)) {
            $body['creatorUnionIds'] = $request->creatorUnionIds;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->query)) {
            $body['query'] = $request->query;
        }
        if (!Utils::isUnset($request->searchType)) {
            $body['searchType'] = $request->searchType;
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'AdminSearchMinutes',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/adminSearch',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AdminSearchMinutesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 搜索企业内听记
     *  *
     * @param AdminSearchMinutesRequest $request AdminSearchMinutesRequest
     *
     * @return AdminSearchMinutesResponse AdminSearchMinutesResponse
     */
    public function adminSearchMinutes($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AdminSearchMinutesHeaders([]);

        return $this->adminSearchMinutesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量获取闪记详情
     *  *
     * @param BatchGetMinutesDetailsRequest $request BatchGetMinutesDetailsRequest
     * @param BatchGetMinutesDetailsHeaders $headers BatchGetMinutesDetailsHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchGetMinutesDetailsResponse BatchGetMinutesDetailsResponse
     */
    public function batchGetMinutesDetailsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->taskUuids)) {
            $body['taskUuids'] = $request->taskUuids;
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
            'action' => 'BatchGetMinutesDetails',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/details/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchGetMinutesDetailsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量获取闪记详情
     *  *
     * @param BatchGetMinutesDetailsRequest $request BatchGetMinutesDetailsRequest
     *
     * @return BatchGetMinutesDetailsResponse BatchGetMinutesDetailsResponse
     */
    public function batchGetMinutesDetails($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchGetMinutesDetailsHeaders([]);

        return $this->batchGetMinutesDetailsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询声纹配置信息
     *  *
     * @param BatchGetVoicePrintIdentifyConfigRequest $request BatchGetVoicePrintIdentifyConfigRequest
     * @param BatchGetVoicePrintIdentifyConfigHeaders $headers BatchGetVoicePrintIdentifyConfigHeaders
     * @param RuntimeOptions                          $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchGetVoicePrintIdentifyConfigResponse BatchGetVoicePrintIdentifyConfigResponse
     */
    public function batchGetVoicePrintIdentifyConfigWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->items)) {
            $body['items'] = $request->items;
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
            'action' => 'BatchGetVoicePrintIdentifyConfig',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/voicePrint/configs/batchGet',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchGetVoicePrintIdentifyConfigResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询声纹配置信息
     *  *
     * @param BatchGetVoicePrintIdentifyConfigRequest $request BatchGetVoicePrintIdentifyConfigRequest
     *
     * @return BatchGetVoicePrintIdentifyConfigResponse BatchGetVoicePrintIdentifyConfigResponse
     */
    public function batchGetVoicePrintIdentifyConfig($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchGetVoicePrintIdentifyConfigHeaders([]);

        return $this->batchGetVoicePrintIdentifyConfigWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量设置声纹开关状态
     *  *
     * @param BatchToggleVoicePrintSwitchStatusRequest $request BatchToggleVoicePrintSwitchStatusRequest
     * @param BatchToggleVoicePrintSwitchStatusHeaders $headers BatchToggleVoicePrintSwitchStatusHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchToggleVoicePrintSwitchStatusResponse BatchToggleVoicePrintSwitchStatusResponse
     */
    public function batchToggleVoicePrintSwitchStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->items)) {
            $body['items'] = $request->items;
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
            'action' => 'BatchToggleVoicePrintSwitchStatus',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/voicePrint/switches/batchToggle',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchToggleVoicePrintSwitchStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量设置声纹开关状态
     *  *
     * @param BatchToggleVoicePrintSwitchStatusRequest $request BatchToggleVoicePrintSwitchStatusRequest
     *
     * @return BatchToggleVoicePrintSwitchStatusResponse BatchToggleVoicePrintSwitchStatusResponse
     */
    public function batchToggleVoicePrintSwitchStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchToggleVoicePrintSwitchStatusHeaders([]);

        return $this->batchToggleVoicePrintSwitchStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 从上传的媒体文件创建闪记
     *  *
     * @param CreateMinutesByUploadFileRequest $request CreateMinutesByUploadFileRequest
     * @param CreateMinutesByUploadFileHeaders $headers CreateMinutesByUploadFileHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateMinutesByUploadFileResponse CreateMinutesByUploadFileResponse
     */
    public function createMinutesByUploadFileWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->bizId)) {
            $body['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->creatorId)) {
            $body['creatorId'] = $request->creatorId;
        }
        if (!Utils::isUnset($request->customPrompt)) {
            $body['customPrompt'] = $request->customPrompt;
        }
        if (!Utils::isUnset($request->enablePushCard)) {
            $body['enablePushCard'] = $request->enablePushCard;
        }
        if (!Utils::isUnset($request->hiddenMinutes)) {
            $body['hiddenMinutes'] = $request->hiddenMinutes;
        }
        if (!Utils::isUnset($request->mediaFileUrl)) {
            $body['mediaFileUrl'] = $request->mediaFileUrl;
        }
        if (!Utils::isUnset($request->mediaType)) {
            $body['mediaType'] = $request->mediaType;
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
            'query' => OpenApiUtilClient::query($query),
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateMinutesByUploadFile',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/createMinutesByUploadFile',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateMinutesByUploadFileResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 从上传的媒体文件创建闪记
     *  *
     * @param CreateMinutesByUploadFileRequest $request CreateMinutesByUploadFileRequest
     *
     * @return CreateMinutesByUploadFileResponse CreateMinutesByUploadFileResponse
     */
    public function createMinutesByUploadFile($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateMinutesByUploadFileHeaders([]);

        return $this->createMinutesByUploadFileWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建DingTalkA1小助理分析
     *  *
     * @param CreateSmartDeviceAiSummaryRequest $request CreateSmartDeviceAiSummaryRequest
     * @param CreateSmartDeviceAiSummaryHeaders $headers CreateSmartDeviceAiSummaryHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateSmartDeviceAiSummaryResponse CreateSmartDeviceAiSummaryResponse
     */
    public function createSmartDeviceAiSummaryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->agentId)) {
            $body['agentId'] = $request->agentId;
        }
        if (!Utils::isUnset($request->instanceId)) {
            $body['instanceId'] = $request->instanceId;
        }
        if (!Utils::isUnset($request->isvContext)) {
            $body['isvContext'] = $request->isvContext;
        }
        if (!Utils::isUnset($request->openFileId)) {
            $body['openFileId'] = $request->openFileId;
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
            'action' => 'CreateSmartDeviceAiSummary',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/smartdevice/aisummary/create',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateSmartDeviceAiSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建DingTalkA1小助理分析
     *  *
     * @param CreateSmartDeviceAiSummaryRequest $request CreateSmartDeviceAiSummaryRequest
     *
     * @return CreateSmartDeviceAiSummaryResponse CreateSmartDeviceAiSummaryResponse
     */
    public function createSmartDeviceAiSummary($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSmartDeviceAiSummaryHeaders([]);

        return $this->createSmartDeviceAiSummaryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除闪记
     *  *
     * @param string               $taskUuid
     * @param DeleteMinutesRequest $request  DeleteMinutesRequest
     * @param DeleteMinutesHeaders $headers  DeleteMinutesHeaders
     * @param RuntimeOptions       $runtime  runtime options for this request RuntimeOptions
     *
     * @return DeleteMinutesResponse DeleteMinutesResponse
     */
    public function deleteMinutesWithOptions($taskUuid, $request, $headers, $runtime)
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
            'action' => 'DeleteMinutes',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/tasks/' . $taskUuid . '',
            'method' => 'DELETE',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeleteMinutesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除闪记
     *  *
     * @param string               $taskUuid
     * @param DeleteMinutesRequest $request  DeleteMinutesRequest
     *
     * @return DeleteMinutesResponse DeleteMinutesResponse
     */
    public function deleteMinutes($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteMinutesHeaders([]);

        return $this->deleteMinutesWithOptions($taskUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 导出闪记任务结果
     *  *
     * @param ExportMinutesTaskResultRequest $request ExportMinutesTaskResultRequest
     * @param ExportMinutesTaskResultHeaders $headers ExportMinutesTaskResultHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return ExportMinutesTaskResultResponse ExportMinutesTaskResultResponse
     */
    public function exportMinutesTaskResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->expireTime)) {
            $body['expireTime'] = $request->expireTime;
        }
        if (!Utils::isUnset($request->summaryExportSetting)) {
            $body['summaryExportSetting'] = $request->summaryExportSetting;
        }
        if (!Utils::isUnset($request->taskType)) {
            $body['taskType'] = $request->taskType;
        }
        if (!Utils::isUnset($request->taskUuid)) {
            $body['taskUuid'] = $request->taskUuid;
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
            'action' => 'ExportMinutesTaskResult',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/minutesTask/export',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ExportMinutesTaskResultResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 导出闪记任务结果
     *  *
     * @param ExportMinutesTaskResultRequest $request ExportMinutesTaskResultRequest
     *
     * @return ExportMinutesTaskResultResponse ExportMinutesTaskResultResponse
     */
    public function exportMinutesTaskResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExportMinutesTaskResultHeaders([]);

        return $this->exportMinutesTaskResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 生成摘要
     *  *
     * @param string                 $taskUuid
     * @param GenerateSummaryRequest $request  GenerateSummaryRequest
     * @param GenerateSummaryHeaders $headers  GenerateSummaryHeaders
     * @param RuntimeOptions         $runtime  runtime options for this request RuntimeOptions
     *
     * @return GenerateSummaryResponse GenerateSummaryResponse
     */
    public function generateSummaryWithOptions($taskUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->diyTemplateVersion)) {
            $body['diyTemplateVersion'] = $request->diyTemplateVersion;
        }
        if (!Utils::isUnset($request->summaryTemplateId)) {
            $body['summaryTemplateId'] = $request->summaryTemplateId;
        }
        if (!Utils::isUnset($request->summaryTemplateType)) {
            $body['summaryTemplateType'] = $request->summaryTemplateType;
        }
        if (!Utils::isUnset($request->userContext)) {
            $body['userContext'] = $request->userContext;
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
            'action' => 'GenerateSummary',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/tasks/' . $taskUuid . '/summary',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GenerateSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 生成摘要
     *  *
     * @param string                 $taskUuid
     * @param GenerateSummaryRequest $request  GenerateSummaryRequest
     *
     * @return GenerateSummaryResponse GenerateSummaryResponse
     */
    public function generateSummary($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GenerateSummaryHeaders([]);

        return $this->generateSummaryWithOptions($taskUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 查询闪记摘要
     *  *
     * @param OpenQueryMinutesSummaryRequest $request OpenQueryMinutesSummaryRequest
     * @param OpenQueryMinutesSummaryHeaders $headers OpenQueryMinutesSummaryHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return OpenQueryMinutesSummaryResponse OpenQueryMinutesSummaryResponse
     */
    public function openQueryMinutesSummaryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->taskUuid)) {
            $query['taskUuid'] = $request->taskUuid;
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
            'action' => 'OpenQueryMinutesSummary',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/queryMinutesSummary',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return OpenQueryMinutesSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询闪记摘要
     *  *
     * @param OpenQueryMinutesSummaryRequest $request OpenQueryMinutesSummaryRequest
     *
     * @return OpenQueryMinutesSummaryResponse OpenQueryMinutesSummaryResponse
     */
    public function openQueryMinutesSummary($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new OpenQueryMinutesSummaryHeaders([]);

        return $this->openQueryMinutesSummaryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询闪会、文档等来源的闪记列表
     *  *
     * @param QueryBizMinutesRequest $request QueryBizMinutesRequest
     * @param QueryBizMinutesHeaders $headers QueryBizMinutesHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryBizMinutesResponse QueryBizMinutesResponse
     */
    public function queryBizMinutesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizId)) {
            $query['bizId'] = $request->bizId;
        }
        if (!Utils::isUnset($request->bizType)) {
            $query['bizType'] = $request->bizType;
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
            'action' => 'QueryBizMinutes',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/queryBizMinutes',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryBizMinutesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询闪会、文档等来源的闪记列表
     *  *
     * @param QueryBizMinutesRequest $request QueryBizMinutesRequest
     *
     * @return QueryBizMinutesResponse QueryBizMinutesResponse
     */
    public function queryBizMinutes($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBizMinutesHeaders([]);

        return $this->queryBizMinutesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询自己创建的闪记列表
     *  *
     * @param QueryCreateMinutesListRequest $request QueryCreateMinutesListRequest
     * @param QueryCreateMinutesListHeaders $headers QueryCreateMinutesListHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryCreateMinutesListResponse QueryCreateMinutesListResponse
     */
    public function queryCreateMinutesListWithOptions($request, $headers, $runtime)
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
            'action' => 'QueryCreateMinutesList',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/createLists',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryCreateMinutesListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询自己创建的闪记列表
     *  *
     * @param QueryCreateMinutesListRequest $request QueryCreateMinutesListRequest
     *
     * @return QueryCreateMinutesListResponse QueryCreateMinutesListResponse
     */
    public function queryCreateMinutesList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCreateMinutesListHeaders([]);

        return $this->queryCreateMinutesListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询闪记基本信息
     *  *
     * @param QueryMinutesBasicInfoRequest $request QueryMinutesBasicInfoRequest
     * @param QueryMinutesBasicInfoHeaders $headers QueryMinutesBasicInfoHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryMinutesBasicInfoResponse QueryMinutesBasicInfoResponse
     */
    public function queryMinutesBasicInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->taskUuid)) {
            $query['taskUuid'] = $request->taskUuid;
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
            'action' => 'QueryMinutesBasicInfo',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/queryMinutesBasicInfo',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMinutesBasicInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询闪记基本信息
     *  *
     * @param QueryMinutesBasicInfoRequest $request QueryMinutesBasicInfoRequest
     *
     * @return QueryMinutesBasicInfoResponse QueryMinutesBasicInfoResponse
     */
    public function queryMinutesBasicInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMinutesBasicInfoHeaders([]);

        return $this->queryMinutesBasicInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询听记智能章节列表
     *  *
     * @param string                      $taskUuid
     * @param QueryMinutesChaptersRequest $request  QueryMinutesChaptersRequest
     * @param QueryMinutesChaptersHeaders $headers  QueryMinutesChaptersHeaders
     * @param RuntimeOptions              $runtime  runtime options for this request RuntimeOptions
     *
     * @return QueryMinutesChaptersResponse QueryMinutesChaptersResponse
     */
    public function queryMinutesChaptersWithOptions($taskUuid, $request, $headers, $runtime)
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
            'action' => 'QueryMinutesChapters',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/' . $taskUuid . '/chapters',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMinutesChaptersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询听记智能章节列表
     *  *
     * @param string                      $taskUuid
     * @param QueryMinutesChaptersRequest $request  QueryMinutesChaptersRequest
     *
     * @return QueryMinutesChaptersResponse QueryMinutesChaptersResponse
     */
    public function queryMinutesChapters($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMinutesChaptersHeaders([]);

        return $this->queryMinutesChaptersWithOptions($taskUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 查询闪记关键字
     *  *
     * @param string                     $taskUuid
     * @param QueryMinutesKeywordRequest $request  QueryMinutesKeywordRequest
     * @param QueryMinutesKeywordHeaders $headers  QueryMinutesKeywordHeaders
     * @param RuntimeOptions             $runtime  runtime options for this request RuntimeOptions
     *
     * @return QueryMinutesKeywordResponse QueryMinutesKeywordResponse
     */
    public function queryMinutesKeywordWithOptions($taskUuid, $request, $headers, $runtime)
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
            'action' => 'QueryMinutesKeyword',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/' . $taskUuid . '/keywords',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMinutesKeywordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询闪记关键字
     *  *
     * @param string                     $taskUuid
     * @param QueryMinutesKeywordRequest $request  QueryMinutesKeywordRequest
     *
     * @return QueryMinutesKeywordResponse QueryMinutesKeywordResponse
     */
    public function queryMinutesKeyword($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMinutesKeywordHeaders([]);

        return $this->queryMinutesKeywordWithOptions($taskUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 查询闪记媒体播放信息
     *  *
     * @param string                      $taskUuid
     * @param QueryMinutesPlayInfoRequest $request  QueryMinutesPlayInfoRequest
     * @param QueryMinutesPlayInfoHeaders $headers  QueryMinutesPlayInfoHeaders
     * @param RuntimeOptions              $runtime  runtime options for this request RuntimeOptions
     *
     * @return QueryMinutesPlayInfoResponse QueryMinutesPlayInfoResponse
     */
    public function queryMinutesPlayInfoWithOptions($taskUuid, $request, $headers, $runtime)
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
            'action' => 'QueryMinutesPlayInfo',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/tasks/' . $taskUuid . '/playInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMinutesPlayInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询闪记媒体播放信息
     *  *
     * @param string                      $taskUuid
     * @param QueryMinutesPlayInfoRequest $request  QueryMinutesPlayInfoRequest
     *
     * @return QueryMinutesPlayInfoResponse QueryMinutesPlayInfoResponse
     */
    public function queryMinutesPlayInfo($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMinutesPlayInfoHeaders([]);

        return $this->queryMinutesPlayInfoWithOptions($taskUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 获取与我共享闪记列表
     *  *
     * @param QueryMinutesShareListRequest $request QueryMinutesShareListRequest
     * @param QueryMinutesShareListHeaders $headers QueryMinutesShareListHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryMinutesShareListResponse QueryMinutesShareListResponse
     */
    public function queryMinutesShareListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->scene)) {
            $query['scene'] = $request->scene;
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
            'action' => 'QueryMinutesShareList',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/shareLists',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMinutesShareListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取与我共享闪记列表
     *  *
     * @param QueryMinutesShareListRequest $request QueryMinutesShareListRequest
     *
     * @return QueryMinutesShareListResponse QueryMinutesShareListResponse
     */
    public function queryMinutesShareList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMinutesShareListHeaders([]);

        return $this->queryMinutesShareListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询闪记状态
     *  *
     * @param string                    $taskUuid
     * @param QueryMinutesStatusRequest $request  QueryMinutesStatusRequest
     * @param QueryMinutesStatusHeaders $headers  QueryMinutesStatusHeaders
     * @param RuntimeOptions            $runtime  runtime options for this request RuntimeOptions
     *
     * @return QueryMinutesStatusResponse QueryMinutesStatusResponse
     */
    public function queryMinutesStatusWithOptions($taskUuid, $request, $headers, $runtime)
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
            'action' => 'QueryMinutesStatus',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/' . $taskUuid . '/taskStatus',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMinutesStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询闪记状态
     *  *
     * @param string                    $taskUuid
     * @param QueryMinutesStatusRequest $request  QueryMinutesStatusRequest
     *
     * @return QueryMinutesStatusResponse QueryMinutesStatusResponse
     */
    public function queryMinutesStatus($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMinutesStatusHeaders([]);

        return $this->queryMinutesStatusWithOptions($taskUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 查询闪记转写文本内容
     *  *
     * @param string                  $taskUuid
     * @param QueryMinutesTextRequest $request  QueryMinutesTextRequest
     * @param QueryMinutesTextHeaders $headers  QueryMinutesTextHeaders
     * @param RuntimeOptions          $runtime  runtime options for this request RuntimeOptions
     *
     * @return QueryMinutesTextResponse QueryMinutesTextResponse
     */
    public function queryMinutesTextWithOptions($taskUuid, $request, $headers, $runtime)
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
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/' . $taskUuid . '/textInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMinutesTextResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询闪记转写文本内容
     *  *
     * @param string                  $taskUuid
     * @param QueryMinutesTextRequest $request  QueryMinutesTextRequest
     *
     * @return QueryMinutesTextResponse QueryMinutesTextResponse
     */
    public function queryMinutesText($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMinutesTextHeaders([]);

        return $this->queryMinutesTextWithOptions($taskUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 查询闪记待办
     *  *
     * @param string                  $taskUuid
     * @param QueryMinutesTodoRequest $request  QueryMinutesTodoRequest
     * @param QueryMinutesTodoHeaders $headers  QueryMinutesTodoHeaders
     * @param RuntimeOptions          $runtime  runtime options for this request RuntimeOptions
     *
     * @return QueryMinutesTodoResponse QueryMinutesTodoResponse
     */
    public function queryMinutesTodoWithOptions($taskUuid, $request, $headers, $runtime)
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
            'action' => 'QueryMinutesTodo',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/' . $taskUuid . '/todos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryMinutesTodoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询闪记待办
     *  *
     * @param string                  $taskUuid
     * @param QueryMinutesTodoRequest $request  QueryMinutesTodoRequest
     *
     * @return QueryMinutesTodoResponse QueryMinutesTodoResponse
     */
    public function queryMinutesTodo($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMinutesTodoHeaders([]);

        return $this->queryMinutesTodoWithOptions($taskUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 查询企业所有自定义纪要模板列表
     *  *
     * @param QueryOrgDiyTemplatesRequest $request QueryOrgDiyTemplatesRequest
     * @param QueryOrgDiyTemplatesHeaders $headers QueryOrgDiyTemplatesHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryOrgDiyTemplatesResponse QueryOrgDiyTemplatesResponse
     */
    public function queryOrgDiyTemplatesWithOptions($request, $headers, $runtime)
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
            'action' => 'QueryOrgDiyTemplates',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/diyTemplates/orgDeclared',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryOrgDiyTemplatesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询企业所有自定义纪要模板列表
     *  *
     * @param QueryOrgDiyTemplatesRequest $request QueryOrgDiyTemplatesRequest
     *
     * @return QueryOrgDiyTemplatesResponse QueryOrgDiyTemplatesResponse
     */
    public function queryOrgDiyTemplates($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgDiyTemplatesHeaders([]);

        return $this->queryOrgDiyTemplatesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询预约会议闪记列表
     *  *
     * @param string                          $scheduleConferenceId
     * @param QueryScheduleConfMinutesRequest $request              QueryScheduleConfMinutesRequest
     * @param QueryScheduleConfMinutesHeaders $headers              QueryScheduleConfMinutesHeaders
     * @param RuntimeOptions                  $runtime              runtime options for this request RuntimeOptions
     *
     * @return QueryScheduleConfMinutesResponse QueryScheduleConfMinutesResponse
     */
    public function queryScheduleConfMinutesWithOptions($scheduleConferenceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->eventId)) {
            $query['eventId'] = $request->eventId;
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
            'action' => 'QueryScheduleConfMinutes',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/scheduleConference/' . $scheduleConferenceId . '/minutes',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryScheduleConfMinutesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询预约会议闪记列表
     *  *
     * @param string                          $scheduleConferenceId
     * @param QueryScheduleConfMinutesRequest $request              QueryScheduleConfMinutesRequest
     *
     * @return QueryScheduleConfMinutesResponse QueryScheduleConfMinutesResponse
     */
    public function queryScheduleConfMinutes($scheduleConferenceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryScheduleConfMinutesHeaders([]);

        return $this->queryScheduleConfMinutesWithOptions($scheduleConferenceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询DingTalkA1小助理分析
     *  *
     * @param QuerySmartDeviceAiSummaryRequest $request QuerySmartDeviceAiSummaryRequest
     * @param QuerySmartDeviceAiSummaryHeaders $headers QuerySmartDeviceAiSummaryHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return QuerySmartDeviceAiSummaryResponse QuerySmartDeviceAiSummaryResponse
     */
    public function querySmartDeviceAiSummaryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->agentId)) {
            $body['agentId'] = $request->agentId;
        }
        if (!Utils::isUnset($request->openFileId)) {
            $body['openFileId'] = $request->openFileId;
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
            'action' => 'QuerySmartDeviceAiSummary',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/smartdevice/aisummary',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QuerySmartDeviceAiSummaryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询DingTalkA1小助理分析
     *  *
     * @param QuerySmartDeviceAiSummaryRequest $request QuerySmartDeviceAiSummaryRequest
     *
     * @return QuerySmartDeviceAiSummaryResponse QuerySmartDeviceAiSummaryResponse
     */
    public function querySmartDeviceAiSummary($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySmartDeviceAiSummaryHeaders([]);

        return $this->querySmartDeviceAiSummaryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据模板id查询摘要
     *  *
     * @param string                          $taskUuid
     * @param QuerySummaryWithTemplateRequest $request  QuerySummaryWithTemplateRequest
     * @param QuerySummaryWithTemplateHeaders $headers  QuerySummaryWithTemplateHeaders
     * @param RuntimeOptions                  $runtime  runtime options for this request RuntimeOptions
     *
     * @return QuerySummaryWithTemplateResponse QuerySummaryWithTemplateResponse
     */
    public function querySummaryWithTemplateWithOptions($taskUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->diyTemplateVersion)) {
            $query['diyTemplateVersion'] = $request->diyTemplateVersion;
        }
        if (!Utils::isUnset($request->summaryTemplateId)) {
            $query['summaryTemplateId'] = $request->summaryTemplateId;
        }
        if (!Utils::isUnset($request->summaryTemplateType)) {
            $query['summaryTemplateType'] = $request->summaryTemplateType;
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
            'action' => 'QuerySummaryWithTemplate',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/tasks/' . $taskUuid . '/summary/template',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QuerySummaryWithTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据模板id查询摘要
     *  *
     * @param string                          $taskUuid
     * @param QuerySummaryWithTemplateRequest $request  QuerySummaryWithTemplateRequest
     *
     * @return QuerySummaryWithTemplateResponse QuerySummaryWithTemplateResponse
     */
    public function querySummaryWithTemplate($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySummaryWithTemplateHeaders([]);

        return $this->querySummaryWithTemplateWithOptions($taskUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 查询上传视频播放信息
     *  *
     * @param string                          $videoId
     * @param QueryUploadVideoPlayInfoRequest $request QueryUploadVideoPlayInfoRequest
     * @param QueryUploadVideoPlayInfoHeaders $headers QueryUploadVideoPlayInfoHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUploadVideoPlayInfoResponse QueryUploadVideoPlayInfoResponse
     */
    public function queryUploadVideoPlayInfoWithOptions($videoId, $request, $headers, $runtime)
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
            'action' => 'QueryUploadVideoPlayInfo',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/uploadVideos/' . $videoId . '/playInfos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryUploadVideoPlayInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询上传视频播放信息
     *  *
     * @param string                          $videoId
     * @param QueryUploadVideoPlayInfoRequest $request QueryUploadVideoPlayInfoRequest
     *
     * @return QueryUploadVideoPlayInfoResponse QueryUploadVideoPlayInfoResponse
     */
    public function queryUploadVideoPlayInfo($videoId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUploadVideoPlayInfoHeaders([]);

        return $this->queryUploadVideoPlayInfoWithOptions($videoId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询用户可见的企业自定义纪要模版列表
     *  *
     * @param QueryUserAvailableDiyTemplatesRequest $request QueryUserAvailableDiyTemplatesRequest
     * @param QueryUserAvailableDiyTemplatesHeaders $headers QueryUserAvailableDiyTemplatesHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryUserAvailableDiyTemplatesResponse QueryUserAvailableDiyTemplatesResponse
     */
    public function queryUserAvailableDiyTemplatesWithOptions($request, $headers, $runtime)
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
            'action' => 'QueryUserAvailableDiyTemplates',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/diyTemplates/userAvailable',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryUserAvailableDiyTemplatesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询用户可见的企业自定义纪要模版列表
     *  *
     * @param QueryUserAvailableDiyTemplatesRequest $request QueryUserAvailableDiyTemplatesRequest
     *
     * @return QueryUserAvailableDiyTemplatesResponse QueryUserAvailableDiyTemplatesResponse
     */
    public function queryUserAvailableDiyTemplates($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserAvailableDiyTemplatesHeaders([]);

        return $this->queryUserAvailableDiyTemplatesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询指定用户对某篇听记的权限
     *  *
     * @param string                            $taskUuid
     * @param string                            $unionId
     * @param QueryUserMinutesPermissionHeaders $headers  QueryUserMinutesPermissionHeaders
     * @param RuntimeOptions                    $runtime  runtime options for this request RuntimeOptions
     *
     * @return QueryUserMinutesPermissionResponse QueryUserMinutesPermissionResponse
     */
    public function queryUserMinutesPermissionWithOptions($taskUuid, $unionId, $headers, $runtime)
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
            'action' => 'QueryUserMinutesPermission',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/tasks/' . $taskUuid . '/permissions/' . $unionId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryUserMinutesPermissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询指定用户对某篇听记的权限
     *  *
     * @param string $taskUuid
     * @param string $unionId
     *
     * @return QueryUserMinutesPermissionResponse QueryUserMinutesPermissionResponse
     */
    public function queryUserMinutesPermission($taskUuid, $unionId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserMinutesPermissionHeaders([]);

        return $this->queryUserMinutesPermissionWithOptions($taskUuid, $unionId, $headers, $runtime);
    }

    /**
     * @summary 重新生成听记智能章节
     *  *
     * @param RegenerateChaptersRequest $request RegenerateChaptersRequest
     * @param RegenerateChaptersHeaders $headers RegenerateChaptersHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return RegenerateChaptersResponse RegenerateChaptersResponse
     */
    public function regenerateChaptersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->taskUuid)) {
            $query['taskUuid'] = $request->taskUuid;
        }
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->customPrompt)) {
            $body['customPrompt'] = $request->customPrompt;
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
            'action' => 'RegenerateChapters',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/chapters/regenerate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RegenerateChaptersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 重新生成听记智能章节
     *  *
     * @param RegenerateChaptersRequest $request RegenerateChaptersRequest
     *
     * @return RegenerateChaptersResponse RegenerateChaptersResponse
     */
    public function regenerateChapters($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegenerateChaptersHeaders([]);

        return $this->regenerateChaptersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 自定义听记详情页tab
     *  *
     * @param string                        $taskUuid
     * @param SetDetailPageCustomTabRequest $request  SetDetailPageCustomTabRequest
     * @param SetDetailPageCustomTabHeaders $headers  SetDetailPageCustomTabHeaders
     * @param RuntimeOptions                $runtime  runtime options for this request RuntimeOptions
     *
     * @return SetDetailPageCustomTabResponse SetDetailPageCustomTabResponse
     */
    public function setDetailPageCustomTabWithOptions($taskUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->customTabList)) {
            $body['customTabList'] = $request->customTabList;
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
            'action' => 'SetDetailPageCustomTab',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/tasks/' . $taskUuid . '/customTabs',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SetDetailPageCustomTabResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 自定义听记详情页tab
     *  *
     * @param string                        $taskUuid
     * @param SetDetailPageCustomTabRequest $request  SetDetailPageCustomTabRequest
     *
     * @return SetDetailPageCustomTabResponse SetDetailPageCustomTabResponse
     */
    public function setDetailPageCustomTab($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetDetailPageCustomTabHeaders([]);

        return $this->setDetailPageCustomTabWithOptions($taskUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 配置应用在听记录制页的自定义Tab
     *  *
     * @param SetInProgressCustomTabsRequest $request SetInProgressCustomTabsRequest
     * @param SetInProgressCustomTabsHeaders $headers SetInProgressCustomTabsHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return SetInProgressCustomTabsResponse SetInProgressCustomTabsResponse
     */
    public function setInProgressCustomTabsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->customTabList)) {
            $body['customTabList'] = $request->customTabList;
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
            'action' => 'SetInProgressCustomTabs',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/apps/settings/inProgressTabs',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SetInProgressCustomTabsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 配置应用在听记录制页的自定义Tab
     *  *
     * @param SetInProgressCustomTabsRequest $request SetInProgressCustomTabsRequest
     *
     * @return SetInProgressCustomTabsResponse SetInProgressCustomTabsResponse
     */
    public function setInProgressCustomTabs($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetInProgressCustomTabsHeaders([]);

        return $this->setInProgressCustomTabsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 设置AI纪要待办模块可见性
     *  *
     * @param string                        $taskUuid
     * @param SetMinutesTodosVisibleRequest $request  SetMinutesTodosVisibleRequest
     * @param SetMinutesTodosVisibleHeaders $headers  SetMinutesTodosVisibleHeaders
     * @param RuntimeOptions                $runtime  runtime options for this request RuntimeOptions
     *
     * @return SetMinutesTodosVisibleResponse SetMinutesTodosVisibleResponse
     */
    public function setMinutesTodosVisibleWithOptions($taskUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->todosVisible)) {
            $body['todosVisible'] = $request->todosVisible;
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
            'action' => 'SetMinutesTodosVisible',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/tasks/' . $taskUuid . '/todosVisible',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SetMinutesTodosVisibleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置AI纪要待办模块可见性
     *  *
     * @param string                        $taskUuid
     * @param SetMinutesTodosVisibleRequest $request  SetMinutesTodosVisibleRequest
     *
     * @return SetMinutesTodosVisibleResponse SetMinutesTodosVisibleResponse
     */
    public function setMinutesTodosVisible($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetMinutesTodosVisibleHeaders([]);

        return $this->setMinutesTodosVisibleWithOptions($taskUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 更新闪记标题
     *  *
     * @param string                    $taskUuid
     * @param UpdateMinutesTitleRequest $request  UpdateMinutesTitleRequest
     * @param UpdateMinutesTitleHeaders $headers  UpdateMinutesTitleHeaders
     * @param RuntimeOptions            $runtime  runtime options for this request RuntimeOptions
     *
     * @return UpdateMinutesTitleResponse UpdateMinutesTitleResponse
     */
    public function updateMinutesTitleWithOptions($taskUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->title)) {
            $query['title'] = $request->title;
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
            'action' => 'UpdateMinutesTitle',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/flashMinutes/tasks/' . $taskUuid . '/titles',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdateMinutesTitleResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新闪记标题
     *  *
     * @param string                    $taskUuid
     * @param UpdateMinutesTitleRequest $request  UpdateMinutesTitleRequest
     *
     * @return UpdateMinutesTitleResponse UpdateMinutesTitleResponse
     */
    public function updateMinutesTitle($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateMinutesTitleHeaders([]);

        return $this->updateMinutesTitleWithOptions($taskUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 更新闪记权限
     *  *
     * @param string                  $taskUuid
     * @param UpdatePermissionRequest $request  UpdatePermissionRequest
     * @param UpdatePermissionHeaders $headers  UpdatePermissionHeaders
     * @param RuntimeOptions          $runtime  runtime options for this request RuntimeOptions
     *
     * @return UpdatePermissionResponse UpdatePermissionResponse
     */
    public function updatePermissionWithOptions($taskUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            $query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->memberInfoList)) {
            $body['memberInfoList'] = $request->memberInfoList;
        }
        if (!Utils::isUnset($request->opType)) {
            $body['opType'] = $request->opType;
        }
        if (!Utils::isUnset($request->roleCode)) {
            $body['roleCode'] = $request->roleCode;
        }
        if (!Utils::isUnset($request->roleSubResourceIds)) {
            $body['roleSubResourceIds'] = $request->roleSubResourceIds;
        }
        if (!Utils::isUnset($request->shareScope)) {
            $body['shareScope'] = $request->shareScope;
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
            'action' => 'UpdatePermission',
            'version' => 'minutes_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/minutes/' . $taskUuid . '/permission',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpdatePermissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新闪记权限
     *  *
     * @param string                  $taskUuid
     * @param UpdatePermissionRequest $request  UpdatePermissionRequest
     *
     * @return UpdatePermissionResponse UpdatePermissionResponse
     */
    public function updatePermission($taskUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdatePermissionHeaders([]);

        return $this->updatePermissionWithOptions($taskUuid, $request, $headers, $runtime);
    }
}
