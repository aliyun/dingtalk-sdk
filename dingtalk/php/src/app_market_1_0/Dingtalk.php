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
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\GetInAppSkuUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\GetInAppSkuUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\GetInAppSkuUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\GetPersonalExperienceInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\GetPersonalExperienceInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\GetPersonalExperienceInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\NotifyOnCrmDataChangeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\NotifyOnCrmDataChangeRequest;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\NotifyOnCrmDataChangeResponse;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\QueryMarketOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\QueryMarketOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\UserTaskReportHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\UserTaskReportRequest;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\UserTaskReportResponse;
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
     * @summary 创建应用商品服务群
     *  *
     * @param CreateAppGoodsServiceConversationRequest $request CreateAppGoodsServiceConversationRequest
     * @param CreateAppGoodsServiceConversationHeaders $headers CreateAppGoodsServiceConversationHeaders
     * @param RuntimeOptions                           $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateAppGoodsServiceConversationResponse CreateAppGoodsServiceConversationResponse
     */
    public function createAppGoodsServiceConversationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->isvUserId)) {
            $body['isvUserId'] = $request->isvUserId;
        }
        if (!Utils::isUnset($request->orderId)) {
            $body['orderId'] = $request->orderId;
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
            'action'      => 'CreateAppGoodsServiceConversation',
            'version'     => 'appMarket_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/appMarket/orders/serviceGroups',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return CreateAppGoodsServiceConversationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建应用商品服务群
     *  *
     * @param CreateAppGoodsServiceConversationRequest $request CreateAppGoodsServiceConversationRequest
     *
     * @return CreateAppGoodsServiceConversationResponse CreateAppGoodsServiceConversationResponse
     */
    public function createAppGoodsServiceConversation($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateAppGoodsServiceConversationHeaders([]);

        return $this->createAppGoodsServiceConversationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取酷应用访问状态
     *  *
     * @param GetCoolAppAccessStatusRequest $request GetCoolAppAccessStatusRequest
     * @param GetCoolAppAccessStatusHeaders $headers GetCoolAppAccessStatusHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetCoolAppAccessStatusResponse GetCoolAppAccessStatusResponse
     */
    public function getCoolAppAccessStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->authCode)) {
            $body['authCode'] = $request->authCode;
        }
        if (!Utils::isUnset($request->coolAppCode)) {
            $body['coolAppCode'] = $request->coolAppCode;
        }
        if (!Utils::isUnset($request->encFieldBizCode)) {
            $body['encFieldBizCode'] = $request->encFieldBizCode;
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
            'action'      => 'GetCoolAppAccessStatus',
            'version'     => 'appMarket_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/appMarket/coolApps/accessions/statuses/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCoolAppAccessStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取酷应用访问状态
     *  *
     * @param GetCoolAppAccessStatusRequest $request GetCoolAppAccessStatusRequest
     *
     * @return GetCoolAppAccessStatusResponse GetCoolAppAccessStatusResponse
     */
    public function getCoolAppAccessStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCoolAppAccessStatusHeaders([]);

        return $this->getCoolAppAccessStatusWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取内购商品SKU页面地址
     *  *
     * @param GetInAppSkuUrlRequest $request GetInAppSkuUrlRequest
     * @param GetInAppSkuUrlHeaders $headers GetInAppSkuUrlHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return GetInAppSkuUrlResponse GetInAppSkuUrlResponse
     */
    public function getInAppSkuUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->callbackPage)) {
            $body['callbackPage'] = $request->callbackPage;
        }
        if (!Utils::isUnset($request->extendParam)) {
            $body['extendParam'] = $request->extendParam;
        }
        if (!Utils::isUnset($request->goodsCode)) {
            $body['goodsCode'] = $request->goodsCode;
        }
        if (!Utils::isUnset($request->itemCode)) {
            $body['itemCode'] = $request->itemCode;
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
            'action'      => 'GetInAppSkuUrl',
            'version'     => 'appMarket_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/appMarket/internals/skuPages/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetInAppSkuUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取内购商品SKU页面地址
     *  *
     * @param GetInAppSkuUrlRequest $request GetInAppSkuUrlRequest
     *
     * @return GetInAppSkuUrlResponse GetInAppSkuUrlResponse
     */
    public function getInAppSkuUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInAppSkuUrlHeaders([]);

        return $this->getInAppSkuUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取个人体验相关信息
     *  *
     * @param GetPersonalExperienceInfoRequest $request GetPersonalExperienceInfoRequest
     * @param GetPersonalExperienceInfoHeaders $headers GetPersonalExperienceInfoHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return GetPersonalExperienceInfoResponse GetPersonalExperienceInfoResponse
     */
    public function getPersonalExperienceInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetPersonalExperienceInfo',
            'version'     => 'appMarket_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/appMarket/personalExperiences',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetPersonalExperienceInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取个人体验相关信息
     *  *
     * @param GetPersonalExperienceInfoRequest $request GetPersonalExperienceInfoRequest
     *
     * @return GetPersonalExperienceInfoResponse GetPersonalExperienceInfoResponse
     */
    public function getPersonalExperienceInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetPersonalExperienceInfoHeaders([]);

        return $this->getPersonalExperienceInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 销售助理CRM数据变更回调通知
     *  *
     * @param NotifyOnCrmDataChangeRequest $request NotifyOnCrmDataChangeRequest
     * @param NotifyOnCrmDataChangeHeaders $headers NotifyOnCrmDataChangeHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return NotifyOnCrmDataChangeResponse NotifyOnCrmDataChangeResponse
     */
    public function notifyOnCrmDataChangeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dataId)) {
            $body['dataId'] = $request->dataId;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->operate)) {
            $body['operate'] = $request->operate;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
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
            'action'      => 'NotifyOnCrmDataChange',
            'version'     => 'appMarket_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/appMarket/saleAssistants/crmDataChanges/notify',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return NotifyOnCrmDataChangeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 销售助理CRM数据变更回调通知
     *  *
     * @param NotifyOnCrmDataChangeRequest $request NotifyOnCrmDataChangeRequest
     *
     * @return NotifyOnCrmDataChangeResponse NotifyOnCrmDataChangeResponse
     */
    public function notifyOnCrmDataChange($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new NotifyOnCrmDataChangeHeaders([]);

        return $this->notifyOnCrmDataChangeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 应用市场订单查询
     *  *
     * @param string                  $orderId
     * @param QueryMarketOrderHeaders $headers QueryMarketOrderHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryMarketOrderResponse QueryMarketOrderResponse
     */
    public function queryMarketOrderWithOptions($orderId, $headers, $runtime)
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
            'action'      => 'QueryMarketOrder',
            'version'     => 'appMarket_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/appMarket/orders/' . $orderId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryMarketOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 应用市场订单查询
     *  *
     * @param string $orderId
     *
     * @return QueryMarketOrderResponse QueryMarketOrderResponse
     */
    public function queryMarketOrder($orderId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMarketOrderHeaders([]);

        return $this->queryMarketOrderWithOptions($orderId, $headers, $runtime);
    }

    /**
     * @summary app内用户操作任务同步
     *  *
     * @param UserTaskReportRequest $request UserTaskReportRequest
     * @param UserTaskReportHeaders $headers UserTaskReportHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return UserTaskReportResponse UserTaskReportResponse
     */
    public function userTaskReportWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizNo)) {
            $body['bizNo'] = $request->bizNo;
        }
        if (!Utils::isUnset($request->operateDate)) {
            $body['operateDate'] = $request->operateDate;
        }
        if (!Utils::isUnset($request->taskTag)) {
            $body['taskTag'] = $request->taskTag;
        }
        if (!Utils::isUnset($request->userid)) {
            $body['userid'] = $request->userid;
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
            'action'      => 'UserTaskReport',
            'version'     => 'appMarket_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/appMarket/tasks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'boolean',
        ]);

        return UserTaskReportResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary app内用户操作任务同步
     *  *
     * @param UserTaskReportRequest $request UserTaskReportRequest
     *
     * @return UserTaskReportResponse UserTaskReportResponse
     */
    public function userTaskReport($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UserTaskReportHeaders([]);

        return $this->userTaskReportWithOptions($request, $headers, $runtime);
    }
}
