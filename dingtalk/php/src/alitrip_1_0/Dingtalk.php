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
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryCityCarApplyHeaders;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryCityCarApplyRequest;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryCityCarApplyResponse;
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
            @$body['cause'] = $request->cause;
        }
        if (!Utils::isUnset($request->city)) {
            @$body['city'] = $request->city;
        }
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->date)) {
            @$body['date'] = $request->date;
        }
        if (!Utils::isUnset($request->projectCode)) {
            @$body['projectCode'] = $request->projectCode;
        }
        if (!Utils::isUnset($request->projectName)) {
            @$body['projectName'] = $request->projectName;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->thirdPartApplyId)) {
            @$body['thirdPartApplyId'] = $request->thirdPartApplyId;
        }
        if (!Utils::isUnset($request->thirdPartCostCenterId)) {
            @$body['thirdPartCostCenterId'] = $request->thirdPartCostCenterId;
        }
        if (!Utils::isUnset($request->thirdPartInvoiceId)) {
            @$body['thirdPartInvoiceId'] = $request->thirdPartInvoiceId;
        }
        if (!Utils::isUnset($request->timesTotal)) {
            @$body['timesTotal'] = $request->timesTotal;
        }
        if (!Utils::isUnset($request->timesType)) {
            @$body['timesType'] = $request->timesType;
        }
        if (!Utils::isUnset($request->timesUsed)) {
            @$body['timesUsed'] = $request->timesUsed;
        }
        if (!Utils::isUnset($request->title)) {
            @$body['title'] = $request->title;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return AddCityCarApplyResponse::fromMap($this->doROARequest('AddCityCarApply', 'alitrip_1.0', 'HTTP', 'POST', 'AK', '/v1.0/alitrip/cityCarApprovals', 'json', $req, $runtime));
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
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->operateTime)) {
            @$body['operateTime'] = $request->operateTime;
        }
        if (!Utils::isUnset($request->remark)) {
            @$body['remark'] = $request->remark;
        }
        if (!Utils::isUnset($request->status)) {
            @$body['status'] = $request->status;
        }
        if (!Utils::isUnset($request->thirdPartApplyId)) {
            @$body['thirdPartApplyId'] = $request->thirdPartApplyId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return ApproveCityCarApplyResponse::fromMap($this->doROARequest('ApproveCityCarApply', 'alitrip_1.0', 'HTTP', 'PUT', 'AK', '/v1.0/alitrip/cityCarApprovals', 'json', $req, $runtime));
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
            @$query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->createdEndAt)) {
            @$query['createdEndAt'] = $request->createdEndAt;
        }
        if (!Utils::isUnset($request->createdStartAt)) {
            @$query['createdStartAt'] = $request->createdStartAt;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            @$query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            @$query['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->thirdPartApplyId)) {
            @$query['thirdPartApplyId'] = $request->thirdPartApplyId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryCityCarApplyResponse::fromMap($this->doROARequest('QueryCityCarApply', 'alitrip_1.0', 'HTTP', 'GET', 'AK', '/v1.0/alitrip/cityCarApprovals', 'json', $req, $runtime));
    }
}
