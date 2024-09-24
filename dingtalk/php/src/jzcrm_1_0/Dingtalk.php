<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditContactHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditContactRequest;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditContactResponse;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditCustomerPoolHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditCustomerPoolRequest;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditCustomerPoolResponse;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditCustomerResponse;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditExchangeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditExchangeRequest;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditExchangeResponse;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditGoodsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditGoodsRequest;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditGoodsResponse;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditIntostockHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditIntostockRequest;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditIntostockResponse;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditInvoiceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditInvoiceRequest;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditInvoiceResponse;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditOutstockHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditOutstockRequest;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditOutstockResponse;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditProductionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditProductionRequest;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditProductionResponse;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditPurchaseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditPurchaseRequest;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditPurchaseResponse;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditQuotationRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditQuotationRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditQuotationRecordResponse;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditSalesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditSalesRequest;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditSalesResponse;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\GetDataListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\GetDataListRequest;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\GetDataListResponse;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\GetDataViewHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\GetDataViewRequest;
use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\GetDataViewResponse;
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
     * @summary 编辑联系人数据
     *  *
     * @param EditContactRequest $request EditContactRequest
     * @param EditContactHeaders $headers EditContactHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return EditContactResponse EditContactResponse
     */
    public function editContactWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->datatype)) {
            $body['datatype'] = $request->datatype;
        }
        if (!Utils::isUnset($request->msgid)) {
            $body['msgid'] = $request->msgid;
        }
        if (!Utils::isUnset($request->stamp)) {
            $body['stamp'] = $request->stamp;
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
            'action'      => 'EditContact',
            'version'     => 'jzcrm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jzcrm/contacts',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EditContactResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑联系人数据
     *  *
     * @param EditContactRequest $request EditContactRequest
     *
     * @return EditContactResponse EditContactResponse
     */
    public function editContact($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditContactHeaders([]);

        return $this->editContactWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑客户数据
     *  *
     * @param EditCustomerRequest $request EditCustomerRequest
     * @param EditCustomerHeaders $headers EditCustomerHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return EditCustomerResponse EditCustomerResponse
     */
    public function editCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->datatype)) {
            $body['datatype'] = $request->datatype;
        }
        if (!Utils::isUnset($request->msgid)) {
            $body['msgid'] = $request->msgid;
        }
        if (!Utils::isUnset($request->stamp)) {
            $body['stamp'] = $request->stamp;
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
            'action'      => 'EditCustomer',
            'version'     => 'jzcrm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jzcrm/customers',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EditCustomerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑客户数据
     *  *
     * @param EditCustomerRequest $request EditCustomerRequest
     *
     * @return EditCustomerResponse EditCustomerResponse
     */
    public function editCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditCustomerHeaders([]);

        return $this->editCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑客户公共池数据
     *  *
     * @param EditCustomerPoolRequest $request EditCustomerPoolRequest
     * @param EditCustomerPoolHeaders $headers EditCustomerPoolHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return EditCustomerPoolResponse EditCustomerPoolResponse
     */
    public function editCustomerPoolWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->datatype)) {
            $body['datatype'] = $request->datatype;
        }
        if (!Utils::isUnset($request->msgid)) {
            $body['msgid'] = $request->msgid;
        }
        if (!Utils::isUnset($request->stamp)) {
            $body['stamp'] = $request->stamp;
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
            'action'      => 'EditCustomerPool',
            'version'     => 'jzcrm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jzcrm/customerPools',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EditCustomerPoolResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑客户公共池数据
     *  *
     * @param EditCustomerPoolRequest $request EditCustomerPoolRequest
     *
     * @return EditCustomerPoolResponse EditCustomerPoolResponse
     */
    public function editCustomerPool($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditCustomerPoolHeaders([]);

        return $this->editCustomerPoolWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑销售换货单数据
     *  *
     * @param EditExchangeRequest $request EditExchangeRequest
     * @param EditExchangeHeaders $headers EditExchangeHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return EditExchangeResponse EditExchangeResponse
     */
    public function editExchangeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->datatype)) {
            $body['datatype'] = $request->datatype;
        }
        if (!Utils::isUnset($request->msgid)) {
            $body['msgid'] = $request->msgid;
        }
        if (!Utils::isUnset($request->stamp)) {
            $body['stamp'] = $request->stamp;
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
            'action'      => 'EditExchange',
            'version'     => 'jzcrm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jzcrm/exchanges',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EditExchangeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑销售换货单数据
     *  *
     * @param EditExchangeRequest $request EditExchangeRequest
     *
     * @return EditExchangeResponse EditExchangeResponse
     */
    public function editExchange($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditExchangeHeaders([]);

        return $this->editExchangeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑产品数据
     *  *
     * @param EditGoodsRequest $request EditGoodsRequest
     * @param EditGoodsHeaders $headers EditGoodsHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return EditGoodsResponse EditGoodsResponse
     */
    public function editGoodsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->datatype)) {
            $body['datatype'] = $request->datatype;
        }
        if (!Utils::isUnset($request->msgid)) {
            $body['msgid'] = $request->msgid;
        }
        if (!Utils::isUnset($request->stamp)) {
            $body['stamp'] = $request->stamp;
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
            'action'      => 'EditGoods',
            'version'     => 'jzcrm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jzcrm/goods',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EditGoodsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑产品数据
     *  *
     * @param EditGoodsRequest $request EditGoodsRequest
     *
     * @return EditGoodsResponse EditGoodsResponse
     */
    public function editGoods($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditGoodsHeaders([]);

        return $this->editGoodsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑入库单数据
     *  *
     * @param EditIntostockRequest $request EditIntostockRequest
     * @param EditIntostockHeaders $headers EditIntostockHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return EditIntostockResponse EditIntostockResponse
     */
    public function editIntostockWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->datatype)) {
            $body['datatype'] = $request->datatype;
        }
        if (!Utils::isUnset($request->msgid)) {
            $body['msgid'] = $request->msgid;
        }
        if (!Utils::isUnset($request->stamp)) {
            $body['stamp'] = $request->stamp;
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
            'action'      => 'EditIntostock',
            'version'     => 'jzcrm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jzcrm/intostocks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EditIntostockResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑入库单数据
     *  *
     * @param EditIntostockRequest $request EditIntostockRequest
     *
     * @return EditIntostockResponse EditIntostockResponse
     */
    public function editIntostock($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditIntostockHeaders([]);

        return $this->editIntostockWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑发货单数据
     *  *
     * @param EditInvoiceRequest $request EditInvoiceRequest
     * @param EditInvoiceHeaders $headers EditInvoiceHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return EditInvoiceResponse EditInvoiceResponse
     */
    public function editInvoiceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->datatype)) {
            $body['datatype'] = $request->datatype;
        }
        if (!Utils::isUnset($request->msgid)) {
            $body['msgid'] = $request->msgid;
        }
        if (!Utils::isUnset($request->stamp)) {
            $body['stamp'] = $request->stamp;
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
            'action'      => 'EditInvoice',
            'version'     => 'jzcrm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jzcrm/invoices',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EditInvoiceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑发货单数据
     *  *
     * @param EditInvoiceRequest $request EditInvoiceRequest
     *
     * @return EditInvoiceResponse EditInvoiceResponse
     */
    public function editInvoice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditInvoiceHeaders([]);

        return $this->editInvoiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑合同订单数据
     *  *
     * @param EditOrderRequest $request EditOrderRequest
     * @param EditOrderHeaders $headers EditOrderHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return EditOrderResponse EditOrderResponse
     */
    public function editOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->datatype)) {
            $body['datatype'] = $request->datatype;
        }
        if (!Utils::isUnset($request->msgid)) {
            $body['msgid'] = $request->msgid;
        }
        if (!Utils::isUnset($request->stamp)) {
            $body['stamp'] = $request->stamp;
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
            'action'      => 'EditOrder',
            'version'     => 'jzcrm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jzcrm/orders',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EditOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑合同订单数据
     *  *
     * @param EditOrderRequest $request EditOrderRequest
     *
     * @return EditOrderResponse EditOrderResponse
     */
    public function editOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditOrderHeaders([]);

        return $this->editOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑出库单信息
     *  *
     * @param EditOutstockRequest $request EditOutstockRequest
     * @param EditOutstockHeaders $headers EditOutstockHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return EditOutstockResponse EditOutstockResponse
     */
    public function editOutstockWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->datatype)) {
            $body['datatype'] = $request->datatype;
        }
        if (!Utils::isUnset($request->msgid)) {
            $body['msgid'] = $request->msgid;
        }
        if (!Utils::isUnset($request->stamp)) {
            $body['stamp'] = $request->stamp;
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
            'action'      => 'EditOutstock',
            'version'     => 'jzcrm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jzcrm/outstocks',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EditOutstockResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑出库单信息
     *  *
     * @param EditOutstockRequest $request EditOutstockRequest
     *
     * @return EditOutstockResponse EditOutstockResponse
     */
    public function editOutstock($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditOutstockHeaders([]);

        return $this->editOutstockWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑生产单数据
     *  *
     * @param EditProductionRequest $request EditProductionRequest
     * @param EditProductionHeaders $headers EditProductionHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return EditProductionResponse EditProductionResponse
     */
    public function editProductionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->datatype)) {
            $body['datatype'] = $request->datatype;
        }
        if (!Utils::isUnset($request->msgid)) {
            $body['msgid'] = $request->msgid;
        }
        if (!Utils::isUnset($request->stamp)) {
            $body['stamp'] = $request->stamp;
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
            'action'      => 'EditProduction',
            'version'     => 'jzcrm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jzcrm/productions',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EditProductionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑生产单数据
     *  *
     * @param EditProductionRequest $request EditProductionRequest
     *
     * @return EditProductionResponse EditProductionResponse
     */
    public function editProduction($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditProductionHeaders([]);

        return $this->editProductionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑采购单数据
     *  *
     * @param EditPurchaseRequest $request EditPurchaseRequest
     * @param EditPurchaseHeaders $headers EditPurchaseHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return EditPurchaseResponse EditPurchaseResponse
     */
    public function editPurchaseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->datatype)) {
            $body['datatype'] = $request->datatype;
        }
        if (!Utils::isUnset($request->msgid)) {
            $body['msgid'] = $request->msgid;
        }
        if (!Utils::isUnset($request->stamp)) {
            $body['stamp'] = $request->stamp;
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
            'action'      => 'EditPurchase',
            'version'     => 'jzcrm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jzcrm/purchases',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EditPurchaseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑采购单数据
     *  *
     * @param EditPurchaseRequest $request EditPurchaseRequest
     *
     * @return EditPurchaseResponse EditPurchaseResponse
     */
    public function editPurchase($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditPurchaseHeaders([]);

        return $this->editPurchaseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑报价记录数据
     *  *
     * @param EditQuotationRecordRequest $request EditQuotationRecordRequest
     * @param EditQuotationRecordHeaders $headers EditQuotationRecordHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return EditQuotationRecordResponse EditQuotationRecordResponse
     */
    public function editQuotationRecordWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->datatype)) {
            $body['datatype'] = $request->datatype;
        }
        if (!Utils::isUnset($request->msgid)) {
            $body['msgid'] = $request->msgid;
        }
        if (!Utils::isUnset($request->stamp)) {
            $body['stamp'] = $request->stamp;
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
            'action'      => 'EditQuotationRecord',
            'version'     => 'jzcrm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jzcrm/quotationRecords',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EditQuotationRecordResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑报价记录数据
     *  *
     * @param EditQuotationRecordRequest $request EditQuotationRecordRequest
     *
     * @return EditQuotationRecordResponse EditQuotationRecordResponse
     */
    public function editQuotationRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditQuotationRecordHeaders([]);

        return $this->editQuotationRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 编辑销售机会数据
     *  *
     * @param EditSalesRequest $request EditSalesRequest
     * @param EditSalesHeaders $headers EditSalesHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return EditSalesResponse EditSalesResponse
     */
    public function editSalesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->data)) {
            $body['data'] = $request->data;
        }
        if (!Utils::isUnset($request->datatype)) {
            $body['datatype'] = $request->datatype;
        }
        if (!Utils::isUnset($request->msgid)) {
            $body['msgid'] = $request->msgid;
        }
        if (!Utils::isUnset($request->stamp)) {
            $body['stamp'] = $request->stamp;
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
            'action'      => 'EditSales',
            'version'     => 'jzcrm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jzcrm/sales',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return EditSalesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 编辑销售机会数据
     *  *
     * @param EditSalesRequest $request EditSalesRequest
     *
     * @return EditSalesResponse EditSalesResponse
     */
    public function editSales($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditSalesHeaders([]);

        return $this->editSalesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取数据列表
     *  *
     * @param GetDataListRequest $request GetDataListRequest
     * @param GetDataListHeaders $headers GetDataListHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDataListResponse GetDataListResponse
     */
    public function getDataListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->datatype)) {
            $query['datatype'] = $request->datatype;
        }
        if (!Utils::isUnset($request->page)) {
            $query['page'] = $request->page;
        }
        if (!Utils::isUnset($request->pagesize)) {
            $query['pagesize'] = $request->pagesize;
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
            'action'      => 'GetDataList',
            'version'     => 'jzcrm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jzcrm/data',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDataListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取数据列表
     *  *
     * @param GetDataListRequest $request GetDataListRequest
     *
     * @return GetDataListResponse GetDataListResponse
     */
    public function getDataList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDataListHeaders([]);

        return $this->getDataListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取数据详情
     *  *
     * @param GetDataViewRequest $request GetDataViewRequest
     * @param GetDataViewHeaders $headers GetDataViewHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return GetDataViewResponse GetDataViewResponse
     */
    public function getDataViewWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->datatype)) {
            $query['datatype'] = $request->datatype;
        }
        if (!Utils::isUnset($request->msgid)) {
            $query['msgid'] = $request->msgid;
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
            'action'      => 'GetDataView',
            'version'     => 'jzcrm_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jzcrm/dataView',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDataViewResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取数据详情
     *  *
     * @param GetDataViewRequest $request GetDataViewRequest
     *
     * @return GetDataViewResponse GetDataViewResponse
     */
    public function getDataView($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDataViewHeaders([]);

        return $this->getDataViewWithOptions($request, $headers, $runtime);
    }
}
