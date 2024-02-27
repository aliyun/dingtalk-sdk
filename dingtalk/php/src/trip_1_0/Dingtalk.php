<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\PreCheckTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\PreCheckTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\PreCheckTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\QueryTripProcessTemplatesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\QueryTripProcessTemplatesRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\QueryTripProcessTemplatesResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncBusinessSignInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncBusinessSignInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncBusinessSignInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncCostCenterEntityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncCostCenterEntityRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncCostCenterEntityResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncCostCenterHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncCostCenterRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncCostCenterResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncInvoiceEntityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncInvoiceEntityRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncInvoiceEntityResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncInvoiceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncInvoiceRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncInvoiceResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncProjectEntityHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncProjectEntityRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncProjectEntityResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncProjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncProjectRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncProjectResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncSecretKeyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncSecretKeyRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncSecretKeyResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\UpgradeTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\UpgradeTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\UpgradeTemplateResponse;
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
     * @param GetTravelProcessDetailRequest $request
     * @param GetTravelProcessDetailHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetTravelProcessDetailResponse
     */
    public function getTravelProcessDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->processCorpId)) {
            $query['processCorpId'] = $request->processCorpId;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $query['processInstanceId'] = $request->processInstanceId;
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
            'action'      => 'GetTravelProcessDetail',
            'version'     => 'trip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/trip/processes/details',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTravelProcessDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetTravelProcessDetailRequest $request
     *
     * @return GetTravelProcessDetailResponse
     */
    public function getTravelProcessDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTravelProcessDetailHeaders([]);

        return $this->getTravelProcessDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @param PreCheckTemplateRequest $request
     * @param PreCheckTemplateHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return PreCheckTemplateResponse
     */
    public function preCheckTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->customerCorpId)) {
            $body['customerCorpId'] = $request->customerCorpId;
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
            'action'      => 'PreCheckTemplate',
            'version'     => 'trip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/trip/processes/templateUpgrades/preCheck',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PreCheckTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PreCheckTemplateRequest $request
     *
     * @return PreCheckTemplateResponse
     */
    public function preCheckTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PreCheckTemplateHeaders([]);

        return $this->preCheckTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryTripProcessTemplatesRequest $request
     * @param QueryTripProcessTemplatesHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return QueryTripProcessTemplatesResponse
     */
    public function queryTripProcessTemplatesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->customerCorpId)) {
            $query['customerCorpId'] = $request->customerCorpId;
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
            'action'      => 'QueryTripProcessTemplates',
            'version'     => 'trip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/trip/processes/templatesDetails',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryTripProcessTemplatesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryTripProcessTemplatesRequest $request
     *
     * @return QueryTripProcessTemplatesResponse
     */
    public function queryTripProcessTemplates($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTripProcessTemplatesHeaders([]);

        return $this->queryTripProcessTemplatesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncBusinessSignInfoRequest $request
     * @param SyncBusinessSignInfoHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return SyncBusinessSignInfoResponse
     */
    public function syncBusinessSignInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizTypeList)) {
            $body['bizTypeList'] = $request->bizTypeList;
        }
        if (!Utils::isUnset($request->gmtOrgPay)) {
            $body['gmtOrgPay'] = $request->gmtOrgPay;
        }
        if (!Utils::isUnset($request->gmtSign)) {
            $body['gmtSign'] = $request->gmtSign;
        }
        if (!Utils::isUnset($request->orgPayStatus)) {
            $body['orgPayStatus'] = $request->orgPayStatus;
        }
        if (!Utils::isUnset($request->signStatus)) {
            $body['signStatus'] = $request->signStatus;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $body['targetCorpId'] = $request->targetCorpId;
        }
        if (!Utils::isUnset($request->tmcProductDetailList)) {
            $body['tmcProductDetailList'] = $request->tmcProductDetailList;
        }
        if (!Utils::isUnset($request->tmcProductList)) {
            $body['tmcProductList'] = $request->tmcProductList;
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
            'action'      => 'SyncBusinessSignInfo',
            'version'     => 'trip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/trip/businessSignInfos/sync',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SyncBusinessSignInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SyncBusinessSignInfoRequest $request
     *
     * @return SyncBusinessSignInfoResponse
     */
    public function syncBusinessSignInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncBusinessSignInfoHeaders([]);

        return $this->syncBusinessSignInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncCostCenterRequest $request
     * @param SyncCostCenterHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return SyncCostCenterResponse
     */
    public function syncCostCenterWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->channelCorpId)) {
            $body['channelCorpId'] = $request->channelCorpId;
        }
        if (!Utils::isUnset($request->costCenterId)) {
            $body['costCenterId'] = $request->costCenterId;
        }
        if (!Utils::isUnset($request->deleteFlag)) {
            $body['deleteFlag'] = $request->deleteFlag;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->gmtAction)) {
            $body['gmtAction'] = $request->gmtAction;
        }
        if (!Utils::isUnset($request->number)) {
            $body['number'] = $request->number;
        }
        if (!Utils::isUnset($request->scope)) {
            $body['scope'] = $request->scope;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->thirdPartId)) {
            $body['thirdPartId'] = $request->thirdPartId;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
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
            'action'      => 'SyncCostCenter',
            'version'     => 'trip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/trip/processes/costCenters/sync',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SyncCostCenterResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SyncCostCenterRequest $request
     *
     * @return SyncCostCenterResponse
     */
    public function syncCostCenter($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncCostCenterHeaders([]);

        return $this->syncCostCenterWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncCostCenterEntityRequest $request
     * @param SyncCostCenterEntityHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return SyncCostCenterEntityResponse
     */
    public function syncCostCenterEntityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->channelCorpId)) {
            $body['channelCorpId'] = $request->channelCorpId;
        }
        if (!Utils::isUnset($request->costCenterId)) {
            $body['costCenterId'] = $request->costCenterId;
        }
        if (!Utils::isUnset($request->delAll)) {
            $body['delAll'] = $request->delAll;
        }
        if (!Utils::isUnset($request->entityList)) {
            $body['entityList'] = $request->entityList;
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
            'action'      => 'SyncCostCenterEntity',
            'version'     => 'trip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/trip/processes/costCenters/applicableScopes/sync',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SyncCostCenterEntityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SyncCostCenterEntityRequest $request
     *
     * @return SyncCostCenterEntityResponse
     */
    public function syncCostCenterEntity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncCostCenterEntityHeaders([]);

        return $this->syncCostCenterEntityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncInvoiceRequest $request
     * @param SyncInvoiceHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return SyncInvoiceResponse
     */
    public function syncInvoiceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->address)) {
            $body['address'] = $request->address;
        }
        if (!Utils::isUnset($request->bankName)) {
            $body['bankName'] = $request->bankName;
        }
        if (!Utils::isUnset($request->bankNo)) {
            $body['bankNo'] = $request->bankNo;
        }
        if (!Utils::isUnset($request->channelCorpId)) {
            $body['channelCorpId'] = $request->channelCorpId;
        }
        if (!Utils::isUnset($request->deleteFlag)) {
            $body['deleteFlag'] = $request->deleteFlag;
        }
        if (!Utils::isUnset($request->gmtAction)) {
            $body['gmtAction'] = $request->gmtAction;
        }
        if (!Utils::isUnset($request->invoiceId)) {
            $body['invoiceId'] = $request->invoiceId;
        }
        if (!Utils::isUnset($request->projectIds)) {
            $body['projectIds'] = $request->projectIds;
        }
        if (!Utils::isUnset($request->scope)) {
            $body['scope'] = $request->scope;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->taxNo)) {
            $body['taxNo'] = $request->taxNo;
        }
        if (!Utils::isUnset($request->tel)) {
            $body['tel'] = $request->tel;
        }
        if (!Utils::isUnset($request->thirdPartId)) {
            $body['thirdPartId'] = $request->thirdPartId;
        }
        if (!Utils::isUnset($request->title)) {
            $body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->type)) {
            $body['type'] = $request->type;
        }
        if (!Utils::isUnset($request->unitType)) {
            $body['unitType'] = $request->unitType;
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
            'action'      => 'SyncInvoice',
            'version'     => 'trip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/trip/processes/invoiceTitles/sync',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SyncInvoiceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SyncInvoiceRequest $request
     *
     * @return SyncInvoiceResponse
     */
    public function syncInvoice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncInvoiceHeaders([]);

        return $this->syncInvoiceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncInvoiceEntityRequest $request
     * @param SyncInvoiceEntityHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return SyncInvoiceEntityResponse
     */
    public function syncInvoiceEntityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->channelCorpId)) {
            $body['channelCorpId'] = $request->channelCorpId;
        }
        if (!Utils::isUnset($request->delAll)) {
            $body['delAll'] = $request->delAll;
        }
        if (!Utils::isUnset($request->entityList)) {
            $body['entityList'] = $request->entityList;
        }
        if (!Utils::isUnset($request->invoiceId)) {
            $body['invoiceId'] = $request->invoiceId;
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
            'action'      => 'SyncInvoiceEntity',
            'version'     => 'trip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/trip/processes/invoiceTitles/applicableScopes/sync',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SyncInvoiceEntityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SyncInvoiceEntityRequest $request
     *
     * @return SyncInvoiceEntityResponse
     */
    public function syncInvoiceEntity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncInvoiceEntityHeaders([]);

        return $this->syncInvoiceEntityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncProjectRequest $request
     * @param SyncProjectHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return SyncProjectResponse
     */
    public function syncProjectWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->channelCorpId)) {
            $body['channelCorpId'] = $request->channelCorpId;
        }
        if (!Utils::isUnset($request->code)) {
            $body['code'] = $request->code;
        }
        if (!Utils::isUnset($request->costCenterId)) {
            $body['costCenterId'] = $request->costCenterId;
        }
        if (!Utils::isUnset($request->deleteFlag)) {
            $body['deleteFlag'] = $request->deleteFlag;
        }
        if (!Utils::isUnset($request->extension)) {
            $body['extension'] = $request->extension;
        }
        if (!Utils::isUnset($request->gmtAction)) {
            $body['gmtAction'] = $request->gmtAction;
        }
        if (!Utils::isUnset($request->invoiceId)) {
            $body['invoiceId'] = $request->invoiceId;
        }
        if (!Utils::isUnset($request->managerIds)) {
            $body['managerIds'] = $request->managerIds;
        }
        if (!Utils::isUnset($request->projectId)) {
            $body['projectId'] = $request->projectId;
        }
        if (!Utils::isUnset($request->projectName)) {
            $body['projectName'] = $request->projectName;
        }
        if (!Utils::isUnset($request->scope)) {
            $body['scope'] = $request->scope;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->thirdPartId)) {
            $body['thirdPartId'] = $request->thirdPartId;
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
            'action'      => 'SyncProject',
            'version'     => 'trip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/trip/processes/projects/sync',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SyncProjectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SyncProjectRequest $request
     *
     * @return SyncProjectResponse
     */
    public function syncProject($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncProjectHeaders([]);

        return $this->syncProjectWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncProjectEntityRequest $request
     * @param SyncProjectEntityHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return SyncProjectEntityResponse
     */
    public function syncProjectEntityWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->channelCorpId)) {
            $body['channelCorpId'] = $request->channelCorpId;
        }
        if (!Utils::isUnset($request->delAll)) {
            $body['delAll'] = $request->delAll;
        }
        if (!Utils::isUnset($request->entityList)) {
            $body['entityList'] = $request->entityList;
        }
        if (!Utils::isUnset($request->projectId)) {
            $body['projectId'] = $request->projectId;
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
            'action'      => 'SyncProjectEntity',
            'version'     => 'trip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/trip/processes/projects/applicableScopes/sync',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SyncProjectEntityResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SyncProjectEntityRequest $request
     *
     * @return SyncProjectEntityResponse
     */
    public function syncProjectEntity($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncProjectEntityHeaders([]);

        return $this->syncProjectEntityWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncSecretKeyRequest $request
     * @param SyncSecretKeyHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return SyncSecretKeyResponse
     */
    public function syncSecretKeyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionType)) {
            $body['actionType'] = $request->actionType;
        }
        if (!Utils::isUnset($request->secretString)) {
            $body['secretString'] = $request->secretString;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $body['targetCorpId'] = $request->targetCorpId;
        }
        if (!Utils::isUnset($request->tripAppKey)) {
            $body['tripAppKey'] = $request->tripAppKey;
        }
        if (!Utils::isUnset($request->tripAppSecurity)) {
            $body['tripAppSecurity'] = $request->tripAppSecurity;
        }
        if (!Utils::isUnset($request->tripCorpId)) {
            $body['tripCorpId'] = $request->tripCorpId;
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
            'action'      => 'SyncSecretKey',
            'version'     => 'trip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/trip/secretKeys/sync',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SyncSecretKeyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SyncSecretKeyRequest $request
     *
     * @return SyncSecretKeyResponse
     */
    public function syncSecretKey($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncSecretKeyHeaders([]);

        return $this->syncSecretKeyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncTripOrderRequest $request
     * @param SyncTripOrderHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return SyncTripOrderResponse
     */
    public function syncTripOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizExtension)) {
            $body['bizExtension'] = $request->bizExtension;
        }
        if (!Utils::isUnset($request->channelType)) {
            $body['channelType'] = $request->channelType;
        }
        if (!Utils::isUnset($request->currency)) {
            $body['currency'] = $request->currency;
        }
        if (!Utils::isUnset($request->dingUserId)) {
            $body['dingUserId'] = $request->dingUserId;
        }
        if (!Utils::isUnset($request->discountAmount)) {
            $body['discountAmount'] = $request->discountAmount;
        }
        if (!Utils::isUnset($request->endorseFlag)) {
            $body['endorseFlag'] = $request->endorseFlag;
        }
        if (!Utils::isUnset($request->event)) {
            $body['event'] = $request->event;
        }
        if (!Utils::isUnset($request->gmtOrder)) {
            $body['gmtOrder'] = $request->gmtOrder;
        }
        if (!Utils::isUnset($request->gmtPay)) {
            $body['gmtPay'] = $request->gmtPay;
        }
        if (!Utils::isUnset($request->gmtRefund)) {
            $body['gmtRefund'] = $request->gmtRefund;
        }
        if (!Utils::isUnset($request->invoiceApplyUrl)) {
            $body['invoiceApplyUrl'] = $request->invoiceApplyUrl;
        }
        if (!Utils::isUnset($request->journeyBizNo)) {
            $body['journeyBizNo'] = $request->journeyBizNo;
        }
        if (!Utils::isUnset($request->orderDetails)) {
            $body['orderDetails'] = $request->orderDetails;
        }
        if (!Utils::isUnset($request->orderNo)) {
            $body['orderNo'] = $request->orderNo;
        }
        if (!Utils::isUnset($request->orderUrl)) {
            $body['orderUrl'] = $request->orderUrl;
        }
        if (!Utils::isUnset($request->processId)) {
            $body['processId'] = $request->processId;
        }
        if (!Utils::isUnset($request->realAmount)) {
            $body['realAmount'] = $request->realAmount;
        }
        if (!Utils::isUnset($request->refundAmount)) {
            $body['refundAmount'] = $request->refundAmount;
        }
        if (!Utils::isUnset($request->relativeOrderNo)) {
            $body['relativeOrderNo'] = $request->relativeOrderNo;
        }
        if (!Utils::isUnset($request->source)) {
            $body['source'] = $request->source;
        }
        if (!Utils::isUnset($request->supplyLogo)) {
            $body['supplyLogo'] = $request->supplyLogo;
        }
        if (!Utils::isUnset($request->supplyName)) {
            $body['supplyName'] = $request->supplyName;
        }
        if (!Utils::isUnset($request->targetCorpId)) {
            $body['targetCorpId'] = $request->targetCorpId;
        }
        if (!Utils::isUnset($request->tmcCorpId)) {
            $body['tmcCorpId'] = $request->tmcCorpId;
        }
        if (!Utils::isUnset($request->totalAmount)) {
            $body['totalAmount'] = $request->totalAmount;
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
            'action'      => 'SyncTripOrder',
            'version'     => 'trip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/trip/tripOrders/sync',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SyncTripOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SyncTripOrderRequest $request
     *
     * @return SyncTripOrderResponse
     */
    public function syncTripOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncTripOrderHeaders([]);

        return $this->syncTripOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UpgradeTemplateRequest $request
     * @param UpgradeTemplateHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return UpgradeTemplateResponse
     */
    public function upgradeTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->channelCorpId)) {
            $body['channelCorpId'] = $request->channelCorpId;
        }
        if (!Utils::isUnset($request->forceUpgrade)) {
            $body['forceUpgrade'] = $request->forceUpgrade;
        }
        if (!Utils::isUnset($request->tmcCorpId)) {
            $body['tmcCorpId'] = $request->tmcCorpId;
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
            'action'      => 'UpgradeTemplate',
            'version'     => 'trip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/trip/process/templates/upgrade',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpgradeTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param UpgradeTemplateRequest $request
     *
     * @return UpgradeTemplateResponse
     */
    public function upgradeTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpgradeTemplateHeaders([]);

        return $this->upgradeTemplateWithOptions($request, $headers, $runtime);
    }
}
