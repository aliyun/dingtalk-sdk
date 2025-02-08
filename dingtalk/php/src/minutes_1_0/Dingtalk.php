<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchGetMinutesDetailsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchGetMinutesDetailsRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchGetMinutesDetailsResponse;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\DeleteMinutesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\DeleteMinutesRequest;
use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\DeleteMinutesResponse;
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
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
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
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BatchGetMinutesDetails',
            'version'     => 'minutes_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/minutes/flashMinutes/details/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'DeleteMinutes',
            'version'     => 'minutes_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/minutes/flashMinutes/tasks/' . $taskUuid . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryMinutesPlayInfo',
            'version'     => 'minutes_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/minutes/flashMinutes/tasks/' . $taskUuid . '/playInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryMinutesShareList',
            'version'     => 'minutes_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/minutes/flashMinutes/shareLists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryMinutesStatus',
            'version'     => 'minutes_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/minutes/flashMinutes/' . $taskUuid . '/taskStatus',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryMinutesText',
            'version'     => 'minutes_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/minutes/flashMinutes/' . $taskUuid . '/textInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryUploadVideoPlayInfo',
            'version'     => 'minutes_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/minutes/flashMinutes/uploadVideos/' . $videoId . '/playInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'UpdateMinutesTitle',
            'version'     => 'minutes_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/minutes/flashMinutes/tasks/' . $taskUuid . '/titles',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
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
