<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\CreateAppGoodsServiceConversationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\CreateAppGoodsServiceConversationRequest;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\CreateAppGoodsServiceConversationResponse;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\GetCoolAppAccessStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\GetCoolAppAccessStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\GetCoolAppAccessStatusResponse;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\GetPersonalExperienceInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\GetPersonalExperienceInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\GetPersonalExperienceInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\QueryMarketOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\QueryMarketOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\UserTaskReportHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\UserTaskReportRequest;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\UserTaskReportResponse;
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
     * @param CreateAppGoodsServiceConversationRequest $request
     *
     * @return CreateAppGoodsServiceConversationResponse
     */
    public function createAppGoodsServiceConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateAppGoodsServiceConversationHeaders([]);

        return $this->createAppGoodsServiceConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateAppGoodsServiceConversationRequest $request
     * @param CreateAppGoodsServiceConversationHeaders $headers
     * @param RuntimeOptions                           $runtime
     *
     * @return CreateAppGoodsServiceConversationResponse
     */
    public function createAppGoodsServiceConversationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->isvUserId)) {
            @$body['isvUserId'] = $request->isvUserId;
        }
        if (!Utils::isUnset($request->orderId)) {
            @$body['orderId'] = $request->orderId;
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

        return CreateAppGoodsServiceConversationResponse::fromMap($this->doROARequest('CreateAppGoodsServiceConversation', 'appMarket_1.0', 'HTTP', 'POST', 'AK', '/v1.0/appMarket/orders/serviceGroups', 'json', $req, $runtime));
    }

    /**
     * @param GetCoolAppAccessStatusRequest $request
     *
     * @return GetCoolAppAccessStatusResponse
     */
    public function getCoolAppAccessStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCoolAppAccessStatusHeaders([]);

        return $this->getCoolAppAccessStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCoolAppAccessStatusRequest $request
     * @param GetCoolAppAccessStatusHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetCoolAppAccessStatusResponse
     */
    public function getCoolAppAccessStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->authCode)) {
            @$body['authCode'] = $request->authCode;
        }
        if (!Utils::isUnset($request->coolAppCode)) {
            @$body['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->encFieldBizCode)) {
            @$body['encFieldBizCode'] = $request->encFieldBizCode;
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

        return GetCoolAppAccessStatusResponse::fromMap($this->doROARequest('GetCoolAppAccessStatus', 'appMarket_1.0', 'HTTP', 'POST', 'AK', '/v1.0/appMarket/coolApps/accessions/statuses/query', 'json', $req, $runtime));
    }

    /**
     * @param GetPersonalExperienceInfoRequest $request
     *
     * @return GetPersonalExperienceInfoResponse
     */
    public function getPersonalExperienceInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPersonalExperienceInfoHeaders([]);

        return $this->getPersonalExperienceInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetPersonalExperienceInfoRequest $request
     * @param GetPersonalExperienceInfoHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return GetPersonalExperienceInfoResponse
     */
    public function getPersonalExperienceInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
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

        return GetPersonalExperienceInfoResponse::fromMap($this->doROARequest('GetPersonalExperienceInfo', 'appMarket_1.0', 'HTTP', 'GET', 'AK', '/v1.0/appMarket/personalExperiences', 'json', $req, $runtime));
    }

    /**
     * @param string $orderId
     *
     * @return QueryMarketOrderResponse
     */
    public function queryMarketOrder($orderId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMarketOrderHeaders([]);

        return $this->queryMarketOrderWithOptions($orderId, $headers, $runtime);
    }

    /**
     * @param string                  $orderId
     * @param QueryMarketOrderHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QueryMarketOrderResponse
     */
    public function queryMarketOrderWithOptions($orderId, $headers, $runtime)
    {
        $orderId     = OpenApiUtilClient::getEncodeParam($orderId);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return QueryMarketOrderResponse::fromMap($this->doROARequest('QueryMarketOrder', 'appMarket_1.0', 'HTTP', 'GET', 'AK', '/v1.0/appMarket/orders/' . $orderId . '', 'json', $req, $runtime));
    }

    /**
     * @param UserTaskReportRequest $request
     *
     * @return UserTaskReportResponse
     */
    public function userTaskReport($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UserTaskReportHeaders([]);

        return $this->userTaskReportWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UserTaskReportRequest $request
     * @param UserTaskReportHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return UserTaskReportResponse
     */
    public function userTaskReportWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizNo)) {
            @$body['bizNo'] = $request->bizNo;
        }
        if (!Utils::isUnset($request->operateDate)) {
            @$body['operateDate'] = $request->operateDate;
        }
        if (!Utils::isUnset($request->taskTag)) {
            @$body['taskTag'] = $request->taskTag;
        }
        if (!Utils::isUnset($request->userid)) {
            @$body['userid'] = $request->userid;
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

        return UserTaskReportResponse::fromMap($this->doROARequest('UserTaskReport', 'appMarket_1.0', 'HTTP', 'POST', 'AK', '/v1.0/appMarket/tasks', 'boolean', $req, $runtime));
    }
}
