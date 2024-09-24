<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vreport_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\CreateTemplatesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\CreateTemplatesRequest;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\CreateTemplatesResponse;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\GetSendAndReceiveReportListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\GetSendAndReceiveReportListRequest;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\GetSendAndReceiveReportListResponse;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\GetSubmitStatisticsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\GetSubmitStatisticsRequest;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\GetSubmitStatisticsResponse;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\QueryRemindResultsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\QueryRemindResultsRequest;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\QueryRemindResultsResponse;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\QueryReportDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\QueryReportDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\QueryReportDetailResponse;
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
        $this->_productId    = 'dingtalk';
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 创建模板
     *  *
     * @param CreateTemplatesRequest $request CreateTemplatesRequest
     * @param CreateTemplatesHeaders $headers CreateTemplatesHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTemplatesResponse CreateTemplatesResponse
     */
    public function createTemplatesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->allowAddReceivers)) {
            $body['allowAddReceivers'] = $request->allowAddReceivers;
        }
        if (!Utils::isUnset($request->allowEdit)) {
            $body['allowEdit'] = $request->allowEdit;
        }
        if (!Utils::isUnset($request->allowGetLocation)) {
            $body['allowGetLocation'] = $request->allowGetLocation;
        }
        if (!Utils::isUnset($request->authDeptIds)) {
            $body['authDeptIds'] = $request->authDeptIds;
        }
        if (!Utils::isUnset($request->authUserIds)) {
            $body['authUserIds'] = $request->authUserIds;
        }
        if (!Utils::isUnset($request->creator)) {
            $body['creator'] = $request->creator;
        }
        if (!Utils::isUnset($request->defaultReceivedCids)) {
            $body['defaultReceivedCids'] = $request->defaultReceivedCids;
        }
        if (!Utils::isUnset($request->defaultReceivedMasterLevels)) {
            $body['defaultReceivedMasterLevels'] = $request->defaultReceivedMasterLevels;
        }
        if (!Utils::isUnset($request->defaultReceivers)) {
            $body['defaultReceivers'] = $request->defaultReceivers;
        }
        if (!Utils::isUnset($request->fields)) {
            $body['fields'] = $request->fields;
        }
        if (!Utils::isUnset($request->logo)) {
            $body['logo'] = $request->logo;
        }
        if (!Utils::isUnset($request->maxWordCount)) {
            $body['maxWordCount'] = $request->maxWordCount;
        }
        if (!Utils::isUnset($request->minWordCount)) {
            $body['minWordCount'] = $request->minWordCount;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->templateManagers)) {
            $body['templateManagers'] = $request->templateManagers;
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
            'action'      => 'CreateTemplates',
            'version'     => 'report_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/report/templates',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateTemplatesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建模板
     *  *
     * @param CreateTemplatesRequest $request CreateTemplatesRequest
     *
     * @return CreateTemplatesResponse CreateTemplatesResponse
     */
    public function createTemplates($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTemplatesHeaders([]);

        return $this->createTemplatesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询员工提交和收到的日志列表
     *  *
     * @param GetSendAndReceiveReportListRequest $request GetSendAndReceiveReportListRequest
     * @param GetSendAndReceiveReportListHeaders $headers GetSendAndReceiveReportListHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSendAndReceiveReportListResponse GetSendAndReceiveReportListResponse
     */
    public function getSendAndReceiveReportListWithOptions($request, $headers, $runtime)
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
        if (!Utils::isUnset($request->operationUserId)) {
            $query['operationUserId'] = $request->operationUserId;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
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
            'action'      => 'GetSendAndReceiveReportList',
            'version'     => 'report_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/report/users/sendAndReceiveLists',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSendAndReceiveReportListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询员工提交和收到的日志列表
     *  *
     * @param GetSendAndReceiveReportListRequest $request GetSendAndReceiveReportListRequest
     *
     * @return GetSendAndReceiveReportListResponse GetSendAndReceiveReportListResponse
     */
    public function getSendAndReceiveReportList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSendAndReceiveReportListHeaders([]);

        return $this->getSendAndReceiveReportListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取指定周期的提交统计结果
     *  *
     * @param GetSubmitStatisticsRequest $request GetSubmitStatisticsRequest
     * @param GetSubmitStatisticsHeaders $headers GetSubmitStatisticsHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSubmitStatisticsResponse GetSubmitStatisticsResponse
     */
    public function getSubmitStatisticsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->operationUserId)) {
            $query['operationUserId'] = $request->operationUserId;
        }
        if (!Utils::isUnset($request->remindId)) {
            $query['remindId'] = $request->remindId;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->templateId)) {
            $query['templateId'] = $request->templateId;
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
            'action'      => 'GetSubmitStatistics',
            'version'     => 'report_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/report/submitStatisticalResults',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSubmitStatisticsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取指定周期的提交统计结果
     *  *
     * @param GetSubmitStatisticsRequest $request GetSubmitStatisticsRequest
     *
     * @return GetSubmitStatisticsResponse GetSubmitStatisticsResponse
     */
    public function getSubmitStatistics($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSubmitStatisticsHeaders([]);

        return $this->getSubmitStatisticsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取创建的统计规则信息
     *  *
     * @param QueryRemindResultsRequest $request QueryRemindResultsRequest
     * @param QueryRemindResultsHeaders $headers QueryRemindResultsHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryRemindResultsResponse QueryRemindResultsResponse
     */
    public function queryRemindResultsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operationUserId)) {
            $query['operationUserId'] = $request->operationUserId;
        }
        if (!Utils::isUnset($request->templateId)) {
            $query['templateId'] = $request->templateId;
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
            'action'      => 'QueryRemindResults',
            'version'     => 'report_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/report/statisticalRules/results',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryRemindResultsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取创建的统计规则信息
     *  *
     * @param QueryRemindResultsRequest $request QueryRemindResultsRequest
     *
     * @return QueryRemindResultsResponse QueryRemindResultsResponse
     */
    public function queryRemindResults($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRemindResultsHeaders([]);

        return $this->queryRemindResultsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取日志详情
     *  *
     * @param QueryReportDetailRequest $request QueryReportDetailRequest
     * @param QueryReportDetailHeaders $headers QueryReportDetailHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryReportDetailResponse QueryReportDetailResponse
     */
    public function queryReportDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->reportId)) {
            $query['reportId'] = $request->reportId;
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
            'action'      => 'QueryReportDetail',
            'version'     => 'report_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/report/details',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryReportDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取日志详情
     *  *
     * @param QueryReportDetailRequest $request QueryReportDetailRequest
     *
     * @return QueryReportDetailResponse QueryReportDetailResponse
     */
    public function queryReportDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryReportDetailHeaders([]);

        return $this->queryReportDetailWithOptions($request, $headers, $runtime);
    }
}
