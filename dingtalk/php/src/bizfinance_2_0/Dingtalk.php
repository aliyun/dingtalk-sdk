<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\BatchDeleteReceiptHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\BatchDeleteReceiptRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\BatchDeleteReceiptResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetCategoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetCategoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetCategoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetFinanceAccountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetFinanceAccountRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetFinanceAccountResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetProjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetProjectRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetProjectResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetSupplierHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetSupplierRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\GetSupplierResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\LinkCommonInvokeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\LinkCommonInvokeRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\LinkCommonInvokeResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryCategoryByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryCategoryByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryCategoryByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryCustomerByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryCustomerByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryCustomerByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryEnterpriseAccountByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryEnterpriseAccountByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryEnterpriseAccountByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryInstancePaymentOrderDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryInstancePaymentOrderDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryInstancePaymentOrderDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryProjectByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryProjectByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryProjectByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QuerySupplierByPageHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QuerySupplierByPageRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QuerySupplierByPageResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\SignEnterpriseAccountHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\SignEnterpriseAccountRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\SignEnterpriseAccountResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\SyncReceiptRecallHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\SyncReceiptRecallRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\SyncReceiptRecallResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\UpdateInstanceOrderInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\UpdateInstanceOrderInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\UpdateInstanceOrderInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\UpdateInstanceOrderInfoShrinkRequest;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client as DarabonbaGatewayDingTalkClient;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    protected $_client;

    public function __construct($config)
    {
        parent::__construct($config);
        $this->_client       = new DarabonbaGatewayDingTalkClient();
        $this->_spi          = $this->_client;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param BatchDeleteReceiptRequest $request
     * @param BatchDeleteReceiptHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return BatchDeleteReceiptResponse
     */
    public function batchDeleteReceiptWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->instanceIdList)) {
            $body['instanceIdList'] = $request->instanceIdList;
        }
        if (!Utils::isUnset($request->operator)) {
            $body['operator'] = $request->operator;
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
            'action'      => 'BatchDeleteReceipt',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/instances/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchDeleteReceiptResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchDeleteReceiptRequest $request
     *
     * @return BatchDeleteReceiptResponse
     */
    public function batchDeleteReceipt($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchDeleteReceiptHeaders([]);

        return $this->batchDeleteReceiptWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCategoryRequest $request
     * @param GetCategoryHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetCategoryResponse
     */
    public function getCategoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
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
            'action'      => 'GetCategory',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/categories',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCategoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetCategoryRequest $request
     *
     * @return GetCategoryResponse
     */
    public function getCategory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCategoryHeaders([]);

        return $this->getCategoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetFinanceAccountRequest $request
     * @param GetFinanceAccountHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return GetFinanceAccountResponse
     */
    public function getFinanceAccountWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->accountCode)) {
            $query['accountCode'] = $request->accountCode;
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
            'action'      => 'GetFinanceAccount',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/financeAccounts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFinanceAccountResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetFinanceAccountRequest $request
     *
     * @return GetFinanceAccountResponse
     */
    public function getFinanceAccount($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFinanceAccountHeaders([]);

        return $this->getFinanceAccountWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetProjectRequest $request
     * @param GetProjectHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return GetProjectResponse
     */
    public function getProjectWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
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
            'action'      => 'GetProject',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/projects',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetProjectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetProjectRequest $request
     *
     * @return GetProjectResponse
     */
    public function getProject($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetProjectHeaders([]);

        return $this->getProjectWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetSupplierRequest $request
     * @param GetSupplierHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetSupplierResponse
     */
    public function getSupplierWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->code)) {
            $query['code'] = $request->code;
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
            'action'      => 'GetSupplier',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/suppliers/details',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSupplierResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetSupplierRequest $request
     *
     * @return GetSupplierResponse
     */
    public function getSupplier($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSupplierHeaders([]);

        return $this->getSupplierWithOptions($request, $headers, $runtime);
    }

    /**
     * @param LinkCommonInvokeRequest $request
     * @param LinkCommonInvokeHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return LinkCommonInvokeResponse
     */
    public function linkCommonInvokeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizType)) {
            $body['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->invokeId)) {
            $body['invokeId'] = $request->invokeId;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
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
            'action'      => 'LinkCommonInvoke',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/link/bizTypes/invoke',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return LinkCommonInvokeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param LinkCommonInvokeRequest $request
     *
     * @return LinkCommonInvokeResponse
     */
    public function linkCommonInvoke($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LinkCommonInvokeHeaders([]);

        return $this->linkCommonInvokeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCategoryByPageRequest $request
     * @param QueryCategoryByPageHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryCategoryByPageResponse
     */
    public function queryCategoryByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->type)) {
            $query['type'] = $request->type;
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
            'action'      => 'QueryCategoryByPage',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/categories/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCategoryByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryCategoryByPageRequest $request
     *
     * @return QueryCategoryByPageResponse
     */
    public function queryCategoryByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCategoryByPageHeaders([]);

        return $this->queryCategoryByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCustomerByPageRequest $request
     * @param QueryCustomerByPageHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QueryCustomerByPageResponse
     */
    public function queryCustomerByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action'      => 'QueryCustomerByPage',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/customers/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryCustomerByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryCustomerByPageRequest $request
     *
     * @return QueryCustomerByPageResponse
     */
    public function queryCustomerByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCustomerByPageHeaders([]);

        return $this->queryCustomerByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryEnterpriseAccountByPageRequest $request
     * @param QueryEnterpriseAccountByPageHeaders $headers
     * @param RuntimeOptions                      $runtime
     *
     * @return QueryEnterpriseAccountByPageResponse
     */
    public function queryEnterpriseAccountByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action'      => 'QueryEnterpriseAccountByPage',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/financeAccounts/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryEnterpriseAccountByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryEnterpriseAccountByPageRequest $request
     *
     * @return QueryEnterpriseAccountByPageResponse
     */
    public function queryEnterpriseAccountByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryEnterpriseAccountByPageHeaders([]);

        return $this->queryEnterpriseAccountByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                                 $instanceId
     * @param QueryInstancePaymentOrderDetailRequest $request
     * @param QueryInstancePaymentOrderDetailHeaders $headers
     * @param RuntimeOptions                         $runtime
     *
     * @return QueryInstancePaymentOrderDetailResponse
     */
    public function queryInstancePaymentOrderDetailWithOptions($instanceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->orderNo)) {
            $query['orderNo'] = $request->orderNo;
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
            'action'      => 'QueryInstancePaymentOrderDetail',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/instances/' . $instanceId . '/paymentOrders/details',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryInstancePaymentOrderDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                                 $instanceId
     * @param QueryInstancePaymentOrderDetailRequest $request
     *
     * @return QueryInstancePaymentOrderDetailResponse
     */
    public function queryInstancePaymentOrderDetail($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryInstancePaymentOrderDetailHeaders([]);

        return $this->queryInstancePaymentOrderDetailWithOptions($instanceId, $request, $headers, $runtime);
    }

    /**
     * @param QueryProjectByPageRequest $request
     * @param QueryProjectByPageHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return QueryProjectByPageResponse
     */
    public function queryProjectByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action'      => 'QueryProjectByPage',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/projects/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryProjectByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryProjectByPageRequest $request
     *
     * @return QueryProjectByPageResponse
     */
    public function queryProjectByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryProjectByPageHeaders([]);

        return $this->queryProjectByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QuerySupplierByPageRequest $request
     * @param QuerySupplierByPageHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return QuerySupplierByPageResponse
     */
    public function querySupplierByPageWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action'      => 'QuerySupplierByPage',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/suppliers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QuerySupplierByPageResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QuerySupplierByPageRequest $request
     *
     * @return QuerySupplierByPageResponse
     */
    public function querySupplierByPage($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySupplierByPageHeaders([]);

        return $this->querySupplierByPageWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SignEnterpriseAccountRequest $request
     * @param SignEnterpriseAccountHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return SignEnterpriseAccountResponse
     */
    public function signEnterpriseAccountWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bankCardNo)) {
            $query['bankCardNo'] = $request->bankCardNo;
        }
        if (!Utils::isUnset($request->bankOpenId)) {
            $query['bankOpenId'] = $request->bankOpenId;
        }
        if (!Utils::isUnset($request->operator)) {
            $query['operator'] = $request->operator;
        }
        if (!Utils::isUnset($request->signOperateType)) {
            $query['signOperateType'] = $request->signOperateType;
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
            'action'      => 'SignEnterpriseAccount',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/enterpriseAccounts/sign',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SignEnterpriseAccountResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SignEnterpriseAccountRequest $request
     *
     * @return SignEnterpriseAccountResponse
     */
    public function signEnterpriseAccount($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SignEnterpriseAccountHeaders([]);

        return $this->signEnterpriseAccountWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncReceiptRecallRequest $request
     * @param SyncReceiptRecallHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return SyncReceiptRecallResponse
     */
    public function syncReceiptRecallWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->fileDownloadUrl)) {
            $query['fileDownloadUrl'] = $request->fileDownloadUrl;
        }
        if (!Utils::isUnset($request->fileName)) {
            $query['fileName'] = $request->fileName;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $query['orderNo'] = $request->orderNo;
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
            'action'      => 'SyncReceiptRecall',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/receipts/syncRecall',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SyncReceiptRecallResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SyncReceiptRecallRequest $request
     *
     * @return SyncReceiptRecallResponse
     */
    public function syncReceiptRecall($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncReceiptRecallHeaders([]);

        return $this->syncReceiptRecallWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                         $instanceId
     * @param UpdateInstanceOrderInfoRequest $tmpReq
     * @param UpdateInstanceOrderInfoHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return UpdateInstanceOrderInfoResponse
     */
    public function updateInstanceOrderInfoWithOptions($instanceId, $tmpReq, $headers, $runtime)
    {
        Utils::validateModel($tmpReq);
        $request = new UpdateInstanceOrderInfoShrinkRequest([]);
        OpenApiUtilClient::convert($tmpReq, $request);
        if (!Utils::isUnset($tmpReq->payerBank)) {
            $request->payerBankShrink = OpenApiUtilClient::arrayToStringWithSpecifiedStyle($tmpReq->payerBank, 'payerBank', 'json');
        }
        $query = [];
        if (!Utils::isUnset($request->failReason)) {
            $query['failReason'] = $request->failReason;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $query['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->outOrderNo)) {
            $query['outOrderNo'] = $request->outOrderNo;
        }
        if (!Utils::isUnset($request->payerBankShrink)) {
            $query['payerBank'] = $request->payerBankShrink;
        }
        if (!Utils::isUnset($request->status)) {
            $query['status'] = $request->status;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'UpdateInstanceOrderInfo',
            'version'     => 'bizfinance_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/bizfinance/instances/' . $instanceId . '/paymentOrders/states',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateInstanceOrderInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                         $instanceId
     * @param UpdateInstanceOrderInfoRequest $request
     *
     * @return UpdateInstanceOrderInfoResponse
     */
    public function updateInstanceOrderInfo($instanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateInstanceOrderInfoHeaders([]);

        return $this->updateInstanceOrderInfoWithOptions($instanceId, $request, $headers, $runtime);
    }
}
