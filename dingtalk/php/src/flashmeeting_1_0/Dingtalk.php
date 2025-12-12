<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\CopyLinkToWorkspaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\CopyLinkToWorkspaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\CopyLinkToWorkspaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\CreateFlashMeetingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\CreateFlashMeetingRequest;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\CreateFlashMeetingResponse;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\ExportShanhuiToDocHeaders;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\ExportShanhuiToDocRequest;
use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\ExportShanhuiToDocResponse;
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
     * @summary 将闪会添加链接到知识库
     *  *
     * @param CopyLinkToWorkspaceRequest $request CopyLinkToWorkspaceRequest
     * @param CopyLinkToWorkspaceHeaders $headers CopyLinkToWorkspaceHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return CopyLinkToWorkspaceResponse CopyLinkToWorkspaceResponse
     */
    public function copyLinkToWorkspaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->parentNodeKey)) {
            $body['parentNodeKey'] = $request->parentNodeKey;
        }
        if (!Utils::isUnset($request->shanhuiKey)) {
            $body['shanhuiKey'] = $request->shanhuiKey;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->workspaceKey)) {
            $body['workspaceKey'] = $request->workspaceKey;
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
            'action' => 'CopyLinkToWorkspace',
            'version' => 'flashmeeting_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/flashmeeting/meetings/copyLinkToWorkspace',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CopyLinkToWorkspaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 将闪会添加链接到知识库
     *  *
     * @param CopyLinkToWorkspaceRequest $request CopyLinkToWorkspaceRequest
     *
     * @return CopyLinkToWorkspaceResponse CopyLinkToWorkspaceResponse
     */
    public function copyLinkToWorkspace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CopyLinkToWorkspaceHeaders([]);

        return $this->copyLinkToWorkspaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建钉闪会并绑定日程
     *  *
     * @param CreateFlashMeetingRequest $request CreateFlashMeetingRequest
     * @param CreateFlashMeetingHeaders $headers CreateFlashMeetingHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateFlashMeetingResponse CreateFlashMeetingResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'CreateFlashMeeting',
            'version' => 'flashmeeting_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/flashmeeting/meetings',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CreateFlashMeetingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建钉闪会并绑定日程
     *  *
     * @param CreateFlashMeetingRequest $request CreateFlashMeetingRequest
     *
     * @return CreateFlashMeetingResponse CreateFlashMeetingResponse
     */
    public function createFlashMeeting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateFlashMeetingHeaders([]);

        return $this->createFlashMeetingWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 将闪会导出到文档
     *  *
     * @param ExportShanhuiToDocRequest $request ExportShanhuiToDocRequest
     * @param ExportShanhuiToDocHeaders $headers ExportShanhuiToDocHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return ExportShanhuiToDocResponse ExportShanhuiToDocResponse
     */
    public function exportShanhuiToDocWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->contentEnums)) {
            $body['contentEnums'] = $request->contentEnums;
        }
        if (!Utils::isUnset($request->parentNodeKey)) {
            $body['parentNodeKey'] = $request->parentNodeKey;
        }
        if (!Utils::isUnset($request->shanhuiKey)) {
            $body['shanhuiKey'] = $request->shanhuiKey;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->workspaceKey)) {
            $body['workspaceKey'] = $request->workspaceKey;
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
            'action' => 'ExportShanhuiToDoc',
            'version' => 'flashmeeting_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/flashmeeting/meetings/export',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ExportShanhuiToDocResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 将闪会导出到文档
     *  *
     * @param ExportShanhuiToDocRequest $request ExportShanhuiToDocRequest
     *
     * @return ExportShanhuiToDocResponse ExportShanhuiToDocResponse
     */
    public function exportShanhuiToDoc($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExportShanhuiToDocHeaders([]);

        return $this->exportShanhuiToDocWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据日程获取闪会的信息
     *  *
     * @param GetShanhuiByCalendarRequest $request GetShanhuiByCalendarRequest
     * @param GetShanhuiByCalendarHeaders $headers GetShanhuiByCalendarHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return GetShanhuiByCalendarResponse GetShanhuiByCalendarResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetShanhuiByCalendar',
            'version' => 'flashmeeting_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/flashmeeting/calendars/meeting',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetShanhuiByCalendarResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据日程获取闪会的信息
     *  *
     * @param GetShanhuiByCalendarRequest $request GetShanhuiByCalendarRequest
     *
     * @return GetShanhuiByCalendarResponse GetShanhuiByCalendarResponse
     */
    public function getShanhuiByCalendar($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetShanhuiByCalendarHeaders([]);

        return $this->getShanhuiByCalendarWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等
     *  *
     * @param string                        $flashmeetingKey
     * @param GetShanhuiByShanhuiKeyHeaders $headers         GetShanhuiByShanhuiKeyHeaders
     * @param RuntimeOptions                $runtime         runtime options for this request RuntimeOptions
     *
     * @return GetShanhuiByShanhuiKeyResponse GetShanhuiByShanhuiKeyResponse
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
            'action' => 'GetShanhuiByShanhuiKey',
            'version' => 'flashmeeting_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/flashmeeting/meetings/keys/' . $flashmeetingKey . '/infos',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetShanhuiByShanhuiKeyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据闪会key来闪会的信息，包含关联的日程、会议时间、议题等
     *  *
     * @param string $flashmeetingKey
     *
     * @return GetShanhuiByShanhuiKeyResponse GetShanhuiByShanhuiKeyResponse
     */
    public function getShanhuiByShanhuiKey($flashmeetingKey)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetShanhuiByShanhuiKeyHeaders([]);

        return $this->getShanhuiByShanhuiKeyWithOptions($flashmeetingKey, $headers, $runtime);
    }

    /**
     * @summary 根据闪会文档id获取待办任务
     *  *
     * @param GetTaskFromShanhuiDocRequest $request GetTaskFromShanhuiDocRequest
     * @param GetTaskFromShanhuiDocHeaders $headers GetTaskFromShanhuiDocHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTaskFromShanhuiDocResponse GetTaskFromShanhuiDocResponse
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'GetTaskFromShanhuiDoc',
            'version' => 'flashmeeting_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/flashmeeting/meetings/tasks',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetTaskFromShanhuiDocResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据闪会文档id获取待办任务
     *  *
     * @param GetTaskFromShanhuiDocRequest $request GetTaskFromShanhuiDocRequest
     *
     * @return GetTaskFromShanhuiDocResponse GetTaskFromShanhuiDocResponse
     */
    public function getTaskFromShanhuiDoc($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTaskFromShanhuiDocHeaders([]);

        return $this->getTaskFromShanhuiDocWithOptions($request, $headers, $runtime);
    }
}
