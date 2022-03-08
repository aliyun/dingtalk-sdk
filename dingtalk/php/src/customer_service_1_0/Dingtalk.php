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
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param CreateTicketRequest $request
     *
     * @return CreateTicketResponse
     */
    public function createTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTicketHeaders([]);

        return $this->createTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateTicketRequest $request
     * @param CreateTicketHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return CreateTicketResponse
     */
    public function createTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->foreignId)) {
            @$body['foreignId'] = $request->foreignId;
        }
        if (!Utils::isUnset($request->foreignName)) {
            @$body['foreignName'] = $request->foreignName;
        }
        if (!Utils::isUnset($request->openInstanceId)) {
            @$body['openInstanceId'] = $request->openInstanceId;
        }
        if (!Utils::isUnset($request->productionType)) {
            @$body['productionType'] = $request->productionType;
        }
        if (!Utils::isUnset($request->properties)) {
            @$body['properties'] = $request->properties;
        }
        if (!Utils::isUnset($request->sourceId)) {
            @$body['sourceId'] = $request->sourceId;
        }
        if (!Utils::isUnset($request->templateId)) {
            @$body['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateTicketResponse::fromMap($this->doROARequest('CreateTicket', 'customerService_1.0', 'HTTP', 'POST', 'AK', '/v1.0/customerService/tickets', 'json', $req, $runtime));
    }

    /**
     * @param string                 $ticketId
     * @param ExecuteActivityRequest $request
     *
     * @return ExecuteActivityResponse
     */
    public function executeActivity($ticketId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ExecuteActivityHeaders([]);

        return $this->executeActivityWithOptions($ticketId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $ticketId
     * @param ExecuteActivityRequest $request
     * @param ExecuteActivityHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ExecuteActivityResponse
     */
    public function executeActivityWithOptions($ticketId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $ticketId = OpenApiUtilClient::getEncodeParam($ticketId);
        $body     = [];
        if (!Utils::isUnset($request->activityCode)) {
            @$body['activityCode'] = $request->activityCode;
        }
        if (!Utils::isUnset($request->foreignId)) {
            @$body['foreignId'] = $request->foreignId;
        }
        if (!Utils::isUnset($request->foreignName)) {
            @$body['foreignName'] = $request->foreignName;
        }
        if (!Utils::isUnset($request->openInstanceId)) {
            @$body['openInstanceId'] = $request->openInstanceId;
        }
        if (!Utils::isUnset($request->productionType)) {
            @$body['productionType'] = $request->productionType;
        }
        if (!Utils::isUnset($request->properties)) {
            @$body['properties'] = $request->properties;
        }
        if (!Utils::isUnset($request->sourceId)) {
            @$body['sourceId'] = $request->sourceId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ExecuteActivityResponse::fromMap($this->doROARequest('ExecuteActivity', 'customerService_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/customerService/tickets/' . $ticketId . '', 'json', $req, $runtime));
    }

    /**
     * @param GetUserSourceListRequest $request
     *
     * @return GetUserSourceListResponse
     */
    public function getUserSourceList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserSourceListHeaders([]);

        return $this->getUserSourceListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetUserSourceListRequest $request
     * @param GetUserSourceListHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetUserSourceListResponse
     */
    public function getUserSourceListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            @$query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->description)) {
            @$query['description'] = $request->description;
        }
        if (!Utils::isUnset($request->openInstanceId)) {
            @$query['openInstanceId'] = $request->openInstanceId;
        }
        if (!Utils::isUnset($request->orgId)) {
            @$query['orgId'] = $request->orgId;
        }
        if (!Utils::isUnset($request->orgName)) {
            @$query['orgName'] = $request->orgName;
        }
        if (!Utils::isUnset($request->productionType)) {
            @$query['productionType'] = $request->productionType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetUserSourceListResponse::fromMap($this->doROARequest('GetUserSourceList', 'customerService_1.0', 'HTTP', 'GET', 'AK', '/v1.0/customerService/customers/sources', 'json', $req, $runtime));
    }

    /**
     * @param string                $ticketId
     * @param PageListActionRequest $request
     *
     * @return PageListActionResponse
     */
    public function pageListAction($ticketId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageListActionHeaders([]);

        return $this->pageListActionWithOptions($ticketId, $request, $headers, $runtime);
    }

    /**
     * @param string                $ticketId
     * @param PageListActionRequest $request
     * @param PageListActionHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return PageListActionResponse
     */
    public function pageListActionWithOptions($ticketId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $ticketId = OpenApiUtilClient::getEncodeParam($ticketId);
        $query    = [];
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openInstanceId)) {
            @$query['openInstanceId'] = $request->openInstanceId;
        }
        if (!Utils::isUnset($request->productionType)) {
            @$query['productionType'] = $request->productionType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return PageListActionResponse::fromMap($this->doROARequest('PageListAction', 'customerService_1.0', 'HTTP', 'GET', 'AK', '/v1.0/customerService/tickets/' . $ticketId . '/actions', 'json', $req, $runtime));
    }

    /**
     * @param PageListRobotRequest $request
     *
     * @return PageListRobotResponse
     */
    public function pageListRobot($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageListRobotHeaders([]);

        return $this->pageListRobotWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PageListRobotRequest $request
     * @param PageListRobotHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return PageListRobotResponse
     */
    public function pageListRobotWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            @$query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openInstanceId)) {
            @$query['openInstanceId'] = $request->openInstanceId;
        }
        if (!Utils::isUnset($request->productionType)) {
            @$query['productionType'] = $request->productionType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return PageListRobotResponse::fromMap($this->doROARequest('PageListRobot', 'customerService_1.0', 'HTTP', 'GET', 'AK', '/v1.0/customerService/robots', 'json', $req, $runtime));
    }

    /**
     * @param PageListTicketRequest $request
     *
     * @return PageListTicketResponse
     */
    public function pageListTicket($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PageListTicketHeaders([]);

        return $this->pageListTicketWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PageListTicketRequest $request
     * @param PageListTicketHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return PageListTicketResponse
     */
    public function pageListTicketWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->endTime)) {
            @$query['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->foreignId)) {
            @$query['foreignId'] = $request->foreignId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->openInstanceId)) {
            @$query['openInstanceId'] = $request->openInstanceId;
        }
        if (!Utils::isUnset($request->productionType)) {
            @$query['productionType'] = $request->productionType;
        }
        if (!Utils::isUnset($request->sourceId)) {
            @$query['sourceId'] = $request->sourceId;
        }
        if (!Utils::isUnset($request->startTime)) {
            @$query['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->templateId)) {
            @$query['templateId'] = $request->templateId;
        }
        if (!Utils::isUnset($request->ticketId)) {
            @$query['ticketId'] = $request->ticketId;
        }
        if (!Utils::isUnset($request->ticketStatus)) {
            @$query['ticketStatus'] = $request->ticketStatus;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return PageListTicketResponse::fromMap($this->doROARequest('PageListTicket', 'customerService_1.0', 'HTTP', 'GET', 'AK', '/v1.0/customerService/tickets', 'json', $req, $runtime));
    }
}
