<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetAudioFileDownloadInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetAudioFileDownloadInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetAudioFileDownloadInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetAudioFileInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetAudioFileInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetAudioFileInfoResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitAsrTaskHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitAsrTaskRequest;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitAsrTaskResponse;
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
}
