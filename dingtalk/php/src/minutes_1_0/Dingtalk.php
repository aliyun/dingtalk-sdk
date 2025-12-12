<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchGetMinutesDetailsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchGetMinutesDetailsRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchGetMinutesDetailsResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\CreateMinutesByUploadFileHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\CreateMinutesByUploadFileRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\CreateMinutesByUploadFileResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\DeleteMinutesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\DeleteMinutesRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\DeleteMinutesResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\ExportMinutesTaskResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\ExportMinutesTaskResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\ExportMinutesTaskResultResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryScheduleConfMinutesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryScheduleConfMinutesRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryScheduleConfMinutesResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryUploadVideoPlayInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryUploadVideoPlayInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryUploadVideoPlayInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdateMinutesTitleHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdateMinutesTitleRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdateMinutesTitleResponse;
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
}
