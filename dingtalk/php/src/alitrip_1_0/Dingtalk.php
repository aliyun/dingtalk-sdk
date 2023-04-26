<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\AddCityCarApplyHeaders;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\AddCityCarApplyRequest;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\AddCityCarApplyResponse;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\ApproveCityCarApplyHeaders;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\ApproveCityCarApplyRequest;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\ApproveCityCarApplyResponse;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementBtripTrainHeaders;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementBtripTrainRequest;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementBtripTrainResponse;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementCarHeaders;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementCarRequest;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementCarResponse;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementFlightHeaders;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementFlightRequest;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementFlightResponse;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementHotelHeaders;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementHotelRequest;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementHotelResponse;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetFlightExceedApplyHeaders;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetFlightExceedApplyRequest;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetFlightExceedApplyResponse;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetHotelExceedApplyHeaders;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetHotelExceedApplyRequest;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetHotelExceedApplyResponse;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetTrainExceedApplyHeaders;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetTrainExceedApplyRequest;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetTrainExceedApplyResponse;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryCityCarApplyHeaders;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryCityCarApplyRequest;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryCityCarApplyResponse;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryUnionOrderHeaders;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryUnionOrderRequest;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryUnionOrderResponse;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\SyncExceedApplyHeaders;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\SyncExceedApplyRequest;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\SyncExceedApplyResponse;
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
     * @param AddCityCarApplyRequest $request
     * @param AddCityCarApplyHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return AddCityCarApplyResponse
     */
    public function addCityCarApplyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->cause)) {
            $body['cause'] = $request->cause;
        }
        if (!Utils::isUnset($request->city)) {
            $body['city'] = $request->city;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->date)) {
            $body['date'] = $request->date;
        }
        if (!Utils::isUnset($request->finishedDate)) {
            $body['finishedDate'] = $request->finishedDate;
        }
        if (!Utils::isUnset($request->projectCode)) {
            $body['projectCode'] = $request->projectCode;
        }
        if (!Utils::isUnset($request->projectName)) {
            $body['projectName'] = $request->projectName;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->thirdPartApplyId)) {
            $body['thirdPartApplyId'] = $request->thirdPartApplyId;
        }
        if (!Utils::isUnset($request->thirdPartCostCenterId)) {
            $body['thirdPartCostCenterId'] = $request->thirdPartCostCenterId;
        }
        if (!Utils::isUnset($request->thirdPartInvoiceId)) {
            $body['thirdPartInvoiceId'] = $request->thirdPartInvoiceId;
        }
        if (!Utils::isUnset($request->timesTotal)) {
            $body['timesTotal'] = $request->timesTotal;
        }
        if (!Utils::isUnset($request->timesType)) {
            $body['timesType'] = $request->timesType;
        }
        if (!Utils::isUnset($request->timesUsed)) {
            $body['timesUsed'] = $request->timesUsed;
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
            'action'      => 'AddCityCarApply',
            'version'     => 'alitrip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/alitrip/cityCarApprovals',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return AddCityCarApplyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AddCityCarApplyRequest $request
     *
     * @return AddCityCarApplyResponse
     */
    public function addCityCarApply($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new AddCityCarApplyHeaders([]);

        return $this->addCityCarApplyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ApproveCityCarApplyRequest $request
     * @param ApproveCityCarApplyHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return ApproveCityCarApplyResponse
     */
    public function approveCityCarApplyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->operateTime)) {
            $body['operateTime'] = $request->operateTime;
        }
        if (!Utils::isUnset($request->remark)) {
            $body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->status)) {
            $body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->thirdPartApplyId)) {
            $body['thirdPartApplyId'] = $request->thirdPartApplyId;
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
            'action'      => 'ApproveCityCarApply',
            'version'     => 'alitrip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/alitrip/cityCarApprovals',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return ApproveCityCarApplyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ApproveCityCarApplyRequest $request
     *
     * @return ApproveCityCarApplyResponse
     */
    public function approveCityCarApply($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ApproveCityCarApplyHeaders([]);

        return $this->approveCityCarApplyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BillSettementBtripTrainRequest $request
     * @param BillSettementBtripTrainHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return BillSettementBtripTrainResponse
     */
    public function billSettementBtripTrainWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->category)) {
            $query['category'] = $request->category;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->periodEnd)) {
            $query['periodEnd'] = $request->periodEnd;
        }
        if (!Utils::isUnset($request->periodStart)) {
            $query['periodStart'] = $request->periodStart;
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
            'action'      => 'BillSettementBtripTrain',
            'version'     => 'alitrip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/alitrip/billSettlements/btripTrains',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BillSettementBtripTrainResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BillSettementBtripTrainRequest $request
     *
     * @return BillSettementBtripTrainResponse
     */
    public function billSettementBtripTrain($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BillSettementBtripTrainHeaders([]);

        return $this->billSettementBtripTrainWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BillSettementCarRequest $request
     * @param BillSettementCarHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return BillSettementCarResponse
     */
    public function billSettementCarWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->category)) {
            $query['category'] = $request->category;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->periodEnd)) {
            $query['periodEnd'] = $request->periodEnd;
        }
        if (!Utils::isUnset($request->periodStart)) {
            $query['periodStart'] = $request->periodStart;
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
            'action'      => 'BillSettementCar',
            'version'     => 'alitrip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/alitrip/billSettlements/cars',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BillSettementCarResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BillSettementCarRequest $request
     *
     * @return BillSettementCarResponse
     */
    public function billSettementCar($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BillSettementCarHeaders([]);

        return $this->billSettementCarWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BillSettementFlightRequest $request
     * @param BillSettementFlightHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return BillSettementFlightResponse
     */
    public function billSettementFlightWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->category)) {
            $query['category'] = $request->category;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->periodEnd)) {
            $query['periodEnd'] = $request->periodEnd;
        }
        if (!Utils::isUnset($request->periodStart)) {
            $query['periodStart'] = $request->periodStart;
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
            'action'      => 'BillSettementFlight',
            'version'     => 'alitrip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/alitrip/billSettlements/flights',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BillSettementFlightResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BillSettementFlightRequest $request
     *
     * @return BillSettementFlightResponse
     */
    public function billSettementFlight($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BillSettementFlightHeaders([]);

        return $this->billSettementFlightWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BillSettementHotelRequest $request
     * @param BillSettementHotelHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return BillSettementHotelResponse
     */
    public function billSettementHotelWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->category)) {
            $query['category'] = $request->category;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->periodEnd)) {
            $query['periodEnd'] = $request->periodEnd;
        }
        if (!Utils::isUnset($request->periodStart)) {
            $query['periodStart'] = $request->periodStart;
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
            'action'      => 'BillSettementHotel',
            'version'     => 'alitrip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/alitrip/billSettlements/hotels',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BillSettementHotelResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BillSettementHotelRequest $request
     *
     * @return BillSettementHotelResponse
     */
    public function billSettementHotel($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BillSettementHotelHeaders([]);

        return $this->billSettementHotelWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetFlightExceedApplyRequest $request
     * @param GetFlightExceedApplyHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetFlightExceedApplyResponse
     */
    public function getFlightExceedApplyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->applyId)) {
            $query['applyId'] = $request->applyId;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'action'      => 'GetFlightExceedApply',
            'version'     => 'alitrip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/alitrip/exceedapply/getFlight',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetFlightExceedApplyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetFlightExceedApplyRequest $request
     *
     * @return GetFlightExceedApplyResponse
     */
    public function getFlightExceedApply($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFlightExceedApplyHeaders([]);

        return $this->getFlightExceedApplyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetHotelExceedApplyRequest $request
     * @param GetHotelExceedApplyHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetHotelExceedApplyResponse
     */
    public function getHotelExceedApplyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->applyId)) {
            $query['applyId'] = $request->applyId;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'action'      => 'GetHotelExceedApply',
            'version'     => 'alitrip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/alitrip/exceedapply/getHotel',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetHotelExceedApplyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetHotelExceedApplyRequest $request
     *
     * @return GetHotelExceedApplyResponse
     */
    public function getHotelExceedApply($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetHotelExceedApplyHeaders([]);

        return $this->getHotelExceedApplyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetTrainExceedApplyRequest $request
     * @param GetTrainExceedApplyHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetTrainExceedApplyResponse
     */
    public function getTrainExceedApplyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->applyId)) {
            $query['applyId'] = $request->applyId;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'action'      => 'GetTrainExceedApply',
            'version'     => 'alitrip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/alitrip/exceedapply/getTrain',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return GetTrainExceedApplyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetTrainExceedApplyRequest $request
     *
     * @return GetTrainExceedApplyResponse
     */
    public function getTrainExceedApply($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTrainExceedApplyHeaders([]);

        return $this->getTrainExceedApplyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryCityCarApplyRequest $request
     * @param QueryCityCarApplyHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return QueryCityCarApplyResponse
     */
    public function queryCityCarApplyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->createdEndAt)) {
            $query['createdEndAt'] = $request->createdEndAt;
        }
        if (!Utils::isUnset($request->createdStartAt)) {
            $query['createdStartAt'] = $request->createdStartAt;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->thirdPartApplyId)) {
            $query['thirdPartApplyId'] = $request->thirdPartApplyId;
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
            'action'      => 'QueryCityCarApply',
            'version'     => 'alitrip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/alitrip/cityCarApprovals',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryCityCarApplyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryCityCarApplyRequest $request
     *
     * @return QueryCityCarApplyResponse
     */
    public function queryCityCarApply($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryCityCarApplyHeaders([]);

        return $this->queryCityCarApplyWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryUnionOrderRequest $request
     * @param QueryUnionOrderHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return QueryUnionOrderResponse
     */
    public function queryUnionOrderWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->thirdPartApplyId)) {
            $query['thirdPartApplyId'] = $request->thirdPartApplyId;
        }
        if (!Utils::isUnset($request->unionNo)) {
            $query['unionNo'] = $request->unionNo;
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
            'action'      => 'QueryUnionOrder',
            'version'     => 'alitrip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/alitrip/unionOrders',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return QueryUnionOrderResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryUnionOrderRequest $request
     *
     * @return QueryUnionOrderResponse
     */
    public function queryUnionOrder($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUnionOrderHeaders([]);

        return $this->queryUnionOrderWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncExceedApplyRequest $request
     * @param SyncExceedApplyHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return SyncExceedApplyResponse
     */
    public function syncExceedApplyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->applyId)) {
            $query['applyId'] = $request->applyId;
        }
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->remark)) {
            $query['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->status)) {
            $query['status'] = $request->status;
        }
        if (!Utils::isUnset($request->thirdpartyFlowId)) {
            $query['thirdpartyFlowId'] = $request->thirdpartyFlowId;
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
            'action'      => 'SyncExceedApply',
            'version'     => 'alitrip_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/alitrip/exceedapply/sync',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return SyncExceedApplyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SyncExceedApplyRequest $request
     *
     * @return SyncExceedApplyResponse
     */
    public function syncExceedApply($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncExceedApplyHeaders([]);

        return $this->syncExceedApplyWithOptions($request, $headers, $runtime);
    }
}
