<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetEmployeeInfoByWorkNoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetEmployeeInfoByWorkNoRequest;
use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetEmployeeInfoByWorkNoResponse;
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
     * @param GetEmployeeInfoByWorkNoRequest $request
     *
     * @return GetEmployeeInfoByWorkNoResponse
     */
    public function getEmployeeInfoByWorkNo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetEmployeeInfoByWorkNoHeaders([]);

        return $this->getEmployeeInfoByWorkNoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetEmployeeInfoByWorkNoRequest $request
     * @param GetEmployeeInfoByWorkNoHeaders $headers
     * @param RuntimeOptions                 $runtime
     *
     * @return GetEmployeeInfoByWorkNoResponse
     */
    public function getEmployeeInfoByWorkNoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->workNo)) {
            @$query['workNo'] = $request->workNo;
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

        return GetEmployeeInfoByWorkNoResponse::fromMap($this->doROARequest('GetEmployeeInfoByWorkNo', 'chengfeng_1.0', 'HTTP', 'GET', 'AK', '/v1.0/chengfeng/workNumbers/employees', 'json', $req, $runtime));
    }
}
