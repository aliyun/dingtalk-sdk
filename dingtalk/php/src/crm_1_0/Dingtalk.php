<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryAllCustomerResponse;
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
     * @param QueryAllCustomerRequest $request
     *
     * @return QueryAllCustomerResponse
     */
    public function queryAllCustomer($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAllCustomerHeaders([]);

        return $this->queryAllCustomerWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryAllCustomerRequest $request
     * @param QueryAllCustomerHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return QueryAllCustomerResponse
     */
    public function queryAllCustomerWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingIsvOrgId)) {
            @$body['dingIsvOrgId'] = $request->dingIsvOrgId;
        }
        if (!Utils::isUnset($request->dingOrgId)) {
            @$body['dingOrgId'] = $request->dingOrgId;
        }
        if (!Utils::isUnset($request->dingTokenGrantType)) {
            @$body['dingTokenGrantType'] = $request->dingTokenGrantType;
        }
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->dingSuiteKey)) {
            @$body['dingSuiteKey'] = $request->dingSuiteKey;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            @$body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->objectType)) {
            @$body['objectType'] = $request->objectType;
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

        return QueryAllCustomerResponse::fromMap($this->doROARequest('QueryAllCustomer', 'crm_1.0', 'HTTP', 'POST', 'AK', '/v1.0/crm/customerInstances', 'json', $req, $runtime));
    }
}
