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
     * @param EditContactRequest $request
     * @param EditContactHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return EditContactResponse
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
     * @param EditContactRequest $request
     *
     * @return EditContactResponse
     */
    public function editContact($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditContactHeaders([]);

        return $this->editContactWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EditCustomerRequest $request
     * @param EditCustomerHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return EditCustomerResponse
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
     * @param EditCustomerRequest $request
     *
     * @return EditCustomerResponse
     */
    public function editCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditCustomerHeaders([]);

        return $this->editCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EditCustomerPoolRequest $request
     * @param EditCustomerPoolHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return EditCustomerPoolResponse
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
     * @param EditCustomerPoolRequest $request
     *
     * @return EditCustomerPoolResponse
     */
    public function editCustomerPool($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditCustomerPoolHeaders([]);

        return $this->editCustomerPoolWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EditExchangeRequest $request
     * @param EditExchangeHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return EditExchangeResponse
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
     * @param EditExchangeRequest $request
     *
     * @return EditExchangeResponse
     */
    public function editExchange($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditExchangeHeaders([]);

        return $this->editExchangeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EditGoodsRequest $request
     * @param EditGoodsHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return EditGoodsResponse
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
     * @param EditGoodsRequest $request
     *
     * @return EditGoodsResponse
     */
    public function editGoods($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditGoodsHeaders([]);

        return $this->editGoodsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EditIntostockRequest $request
     * @param EditIntostockHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return EditIntostockResponse
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
     * @param EditIntostockRequest $request
     *
     * @return EditIntostockResponse
     */
    public function editIntostock($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditIntostockHeaders([]);

        return $this->editIntostockWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EditInvoiceRequest $request
     * @param EditInvoiceHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return EditInvoiceResponse
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
     * @param EditInvoiceRequest $request
     *
     * @return EditInvoiceResponse
     */
    public function editInvoice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditInvoiceHeaders([]);

        return $this->editInvoiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EditOrderRequest $request
     * @param EditOrderHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return EditOrderResponse
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
     * @param EditOrderRequest $request
     *
     * @return EditOrderResponse
     */
    public function editOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditOrderHeaders([]);

        return $this->editOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EditOutstockRequest $request
     * @param EditOutstockHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return EditOutstockResponse
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
     * @param EditOutstockRequest $request
     *
     * @return EditOutstockResponse
     */
    public function editOutstock($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditOutstockHeaders([]);

        return $this->editOutstockWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EditProductionRequest $request
     * @param EditProductionHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return EditProductionResponse
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
     * @param EditProductionRequest $request
     *
     * @return EditProductionResponse
     */
    public function editProduction($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditProductionHeaders([]);

        return $this->editProductionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EditPurchaseRequest $request
     * @param EditPurchaseHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return EditPurchaseResponse
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
     * @param EditPurchaseRequest $request
     *
     * @return EditPurchaseResponse
     */
    public function editPurchase($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditPurchaseHeaders([]);

        return $this->editPurchaseWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EditQuotationRecordRequest $request
     * @param EditQuotationRecordHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return EditQuotationRecordResponse
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
     * @param EditQuotationRecordRequest $request
     *
     * @return EditQuotationRecordResponse
     */
    public function editQuotationRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditQuotationRecordHeaders([]);

        return $this->editQuotationRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @param EditSalesRequest $request
     * @param EditSalesHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return EditSalesResponse
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
     * @param EditSalesRequest $request
     *
     * @return EditSalesResponse
     */
    public function editSales($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new EditSalesHeaders([]);

        return $this->editSalesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetDataListRequest $request
     * @param GetDataListHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetDataListResponse
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
     * @param GetDataListRequest $request
     *
     * @return GetDataListResponse
     */
    public function getDataList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDataListHeaders([]);

        return $this->getDataListWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetDataViewRequest $request
     * @param GetDataViewHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetDataViewResponse
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
     * @param GetDataViewRequest $request
     *
     * @return GetDataViewResponse
     */
    public function getDataView($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDataViewHeaders([]);

        return $this->getDataViewWithOptions($request, $headers, $runtime);
    }
}
