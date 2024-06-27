<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\CreateTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\CreateTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\CreateTicketResponse;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\ExecuteActivityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\ExecuteActivityRequest;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\ExecuteActivityResponse;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\GetUserSourceListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\GetUserSourceListRequest;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\GetUserSourceListResponse;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\PageListActionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\PageListActionRequest;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\PageListActionResponse;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\PageListRobotHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\PageListRobotRequest;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\PageListRobotResponse;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\PageListTicketHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\PageListTicketRequest;
use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\PageListTicketResponse;
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
     * @summary 创建工单
     *  *
     * @param CreateTicketRequest $request CreateTicketRequest
     * @param CreateTicketHeaders $headers CreateTicketHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTicketResponse CreateTicketResponse
     */
    public function createTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->foreignId)) {
            $body['foreignId'] = $request->foreignId;
        }
        if (!Utils::isUnset($request->foreignName)) {
            $body['foreignName'] = $request->foreignName;
        }
        if (!Utils::isUnset($request->openInstanceId)) {
            $body['openInstanceId'] = $request->openInstanceId;
        }
        if (!Utils::isUnset($request->productionType)) {
            $body['productionType'] = $request->productionType;
        }
        if (!Utils::isUnset($request->properties)) {
            $body['properties'] = $request->properties;
        }
        if (!Utils::isUnset($request->sourceId)) {
            $body['sourceId'] = $request->sourceId;
        }
        if (!Utils::isUnset($request->templateId)) {
            $body['templateId'] = $request->templateId;
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
            'action'      => 'CreateTicket',
            'version'     => 'customerService_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/customerService/tickets',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建工单
     *  *
     * @param CreateTicketRequest $request CreateTicketRequest
     *
     * @return CreateTicketResponse CreateTicketResponse
     */
    public function createTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTicketHeaders([]);

        return $this->createTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 执行工单活动
     *  *
     * @param string                 $ticketId
     * @param ExecuteActivityRequest $request  ExecuteActivityRequest
     * @param ExecuteActivityHeaders $headers  ExecuteActivityHeaders
     * @param RuntimeOptions         $runtime  runtime options for this request RuntimeOptions
     *
     * @return ExecuteActivityResponse ExecuteActivityResponse
     */
    public function executeActivityWithOptions($ticketId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->activityCode)) {
            $body['activityCode'] = $request->activityCode;
        }
        if (!Utils::isUnset($request->foreignId)) {
            $body['foreignId'] = $request->foreignId;
        }
        if (!Utils::isUnset($request->foreignName)) {
            $body['foreignName'] = $request->foreignName;
        }
        if (!Utils::isUnset($request->openInstanceId)) {
            $body['openInstanceId'] = $request->openInstanceId;
        }
        if (!Utils::isUnset($request->productionType)) {
            $body['productionType'] = $request->productionType;
        }
        if (!Utils::isUnset($request->properties)) {
            $body['properties'] = $request->properties;
        }
        if (!Utils::isUnset($request->sourceId)) {
            $body['sourceId'] = $request->sourceId;
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
            'action'      => 'ExecuteActivity',
            'version'     => 'customerService_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/customerService/tickets/' . $ticketId . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ExecuteActivityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 执行工单活动
     *  *
     * @param string                 $ticketId
     * @param ExecuteActivityRequest $request  ExecuteActivityRequest
     *
     * @return ExecuteActivityResponse ExecuteActivityResponse
     */
    public function executeActivity($ticketId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecuteActivityHeaders([]);

        return $this->executeActivityWithOptions($ticketId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取source列表
     *  *
     * @param GetUserSourceListRequest $request GetUserSourceListRequest
     * @param GetUserSourceListHeaders $headers GetUserSourceListHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserSourceListResponse GetUserSourceListResponse
     */
    public function getUserSourceListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->description)) {
            $query['description'] = $request->description;
        }
        if (!Utils::isUnset($request->openInstanceId)) {
            $query['openInstanceId'] = $request->openInstanceId;
        }
        if (!Utils::isUnset($request->orgId)) {
            $query['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->orgName)) {
            $query['orgName'] = $request->orgName;
        }
        if (!Utils::isUnset($request->productionType)) {
            $query['productionType'] = $request->productionType;
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
            'action'      => 'GetUserSourceList',
            'version'     => 'customerService_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/customerService/customers/sources',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetUserSourceListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取source列表
     *  *
     * @param GetUserSourceListRequest $request GetUserSourceListRequest
     *
     * @return GetUserSourceListResponse GetUserSourceListResponse
     */
    public function getUserSourceList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserSourceListHeaders([]);

        return $this->getUserSourceListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询动作记录
     *  *
     * @param string                $ticketId
     * @param PageListActionRequest $request  PageListActionRequest
     * @param PageListActionHeaders $headers  PageListActionHeaders
     * @param RuntimeOptions        $runtime  runtime options for this request RuntimeOptions
     *
     * @return PageListActionResponse PageListActionResponse
     */
    public function pageListActionWithOptions($ticketId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openInstanceId)) {
            $query['openInstanceId'] = $request->openInstanceId;
        }
        if (!Utils::isUnset($request->productionType)) {
            $query['productionType'] = $request->productionType;
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
            'action'      => 'PageListAction',
            'version'     => 'customerService_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/customerService/tickets/' . $ticketId . '/actions',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return PageListActionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询动作记录
     *  *
     * @param string                $ticketId
     * @param PageListActionRequest $request  PageListActionRequest
     *
     * @return PageListActionResponse PageListActionResponse
     */
    public function pageListAction($ticketId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageListActionHeaders([]);

        return $this->pageListActionWithOptions($ticketId, $request, $headers, $runtime);
    }

    /**
     * @summary 分页查询机器人信息
     *  *
     * @param PageListRobotRequest $request PageListRobotRequest
     * @param PageListRobotHeaders $headers PageListRobotHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return PageListRobotResponse PageListRobotResponse
     */
    public function pageListRobotWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openInstanceId)) {
            $query['openInstanceId'] = $request->openInstanceId;
        }
        if (!Utils::isUnset($request->productionType)) {
            $query['productionType'] = $request->productionType;
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
            'action'      => 'PageListRobot',
            'version'     => 'customerService_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/customerService/robots',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return PageListRobotResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页查询机器人信息
     *  *
     * @param PageListRobotRequest $request PageListRobotRequest
     *
     * @return PageListRobotResponse PageListRobotResponse
     */
    public function pageListRobot($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageListRobotHeaders([]);

        return $this->pageListRobotWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 分页查询工单
     *  *
     * @param PageListTicketRequest $request PageListTicketRequest
     * @param PageListTicketHeaders $headers PageListTicketHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return PageListTicketResponse PageListTicketResponse
     */
    public function pageListTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            $query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->foreignId)) {
            $query['foreignId'] = $request->foreignId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openInstanceId)) {
            $query['openInstanceId'] = $request->openInstanceId;
        }
        if (!Utils::isUnset($request->productionType)) {
            $query['productionType'] = $request->productionType;
        }
        if (!Utils::isUnset($request->sourceId)) {
            $query['sourceId'] = $request->sourceId;
        }
        if (!Utils::isUnset($request->startTime)) {
            $query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->templateId)) {
            $query['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->ticketId)) {
            $query['ticketId'] = $request->ticketId;
        }
        if (!Utils::isUnset($request->ticketStatus)) {
            $query['ticketStatus'] = $request->ticketStatus;
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
            'action'      => 'PageListTicket',
            'version'     => 'customerService_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/customerService/tickets',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return PageListTicketResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 分页查询工单
     *  *
     * @param PageListTicketRequest $request PageListTicketRequest
     *
     * @return PageListTicketResponse PageListTicketResponse
     */
    public function pageListTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageListTicketHeaders([]);

        return $this->pageListTicketWithOptions($request, $headers, $runtime);
    }
}
