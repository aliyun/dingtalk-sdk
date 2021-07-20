<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDigitalDistrictOrgInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDigitalDistrictOrgInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryDigitalDistrictOrgInfoResponse;
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
     * @param QueryDigitalDistrictOrgInfoRequest $request
     *
     * @return QueryDigitalDistrictOrgInfoResponse
     */
    public function queryDigitalDistrictOrgInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDigitalDistrictOrgInfoHeaders([]);

        return $this->queryDigitalDistrictOrgInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDigitalDistrictOrgInfoRequest $request
     * @param QueryDigitalDistrictOrgInfoHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return QueryDigitalDistrictOrgInfoResponse
     */
    public function queryDigitalDistrictOrgInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->kpiGroupId)) {
            @$body['kpiGroupId'] = $request->kpiGroupId;
        }
        if (!Utils::isUnset($request->statDates)) {
            @$body['statDates'] = $request->statDates;
        }
        if (!Utils::isUnset($request->orgIds)) {
            @$body['orgIds'] = $request->orgIds;
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

        return QueryDigitalDistrictOrgInfoResponse::fromMap($this->doROARequest('QueryDigitalDistrictOrgInfo', 'datacenter_1.0', 'HTTP', 'POST', 'AK', '/v1.0/datacenter/digitalCounty/orgInfos/query', 'json', $req, $runtime));
    }
}
