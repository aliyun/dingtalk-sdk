<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcool_ops_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcool_ops_1_0\Models\BatchQueryOpportunityTagHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcool_ops_1_0\Models\BatchQueryOpportunityTagRequest;
use AlibabaCloud\SDK\Dingtalk\Vcool_ops_1_0\Models\BatchQueryOpportunityTagResponse;
use AlibabaCloud\SDK\Dingtalk\Vcool_ops_1_0\Models\UpdateIsvOppStatusHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcool_ops_1_0\Models\UpdateIsvOppStatusRequest;
use AlibabaCloud\SDK\Dingtalk\Vcool_ops_1_0\Models\UpdateIsvOppStatusResponse;
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
     * @summary ISV批量查询商机标签
     *  *
     * @param BatchQueryOpportunityTagRequest $request BatchQueryOpportunityTagRequest
     * @param BatchQueryOpportunityTagHeaders $headers BatchQueryOpportunityTagHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchQueryOpportunityTagResponse BatchQueryOpportunityTagResponse
     */
    public function batchQueryOpportunityTagWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpIdList)) {
            $body['corpIdList'] = $request->corpIdList;
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
            'action'      => 'BatchQueryOpportunityTag',
            'version'     => 'coolOps_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/coolOps/isvOpportunities/opportunityTags/batchQuery',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchQueryOpportunityTagResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary ISV批量查询商机标签
     *  *
     * @param BatchQueryOpportunityTagRequest $request BatchQueryOpportunityTagRequest
     *
     * @return BatchQueryOpportunityTagResponse BatchQueryOpportunityTagResponse
     */
    public function batchQueryOpportunityTag($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchQueryOpportunityTagHeaders([]);

        return $this->batchQueryOpportunityTagWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary ISV商机状态同步
     *  *
     * @param UpdateIsvOppStatusRequest $request UpdateIsvOppStatusRequest
     * @param UpdateIsvOppStatusHeaders $headers UpdateIsvOppStatusHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateIsvOppStatusResponse UpdateIsvOppStatusResponse
     */
    public function updateIsvOppStatusWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->isvOpportunityStatusList)) {
            $body['isvOpportunityStatusList'] = $request->isvOpportunityStatusList;
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
            'action'      => 'UpdateIsvOppStatus',
            'version'     => 'coolOps_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/coolOps/isvOpportunities/statuses',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateIsvOppStatusResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary ISV商机状态同步
     *  *
     * @param UpdateIsvOppStatusRequest $request UpdateIsvOppStatusRequest
     *
     * @return UpdateIsvOppStatusResponse UpdateIsvOppStatusResponse
     */
    public function updateIsvOppStatus($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateIsvOppStatusHeaders([]);

        return $this->updateIsvOppStatusWithOptions($request, $headers, $runtime);
    }
}
