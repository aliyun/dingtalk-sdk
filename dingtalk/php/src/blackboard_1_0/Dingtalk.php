<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vblackboard_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vblackboard_1_0\Models\QueryBlackboardSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vblackboard_1_0\Models\QueryBlackboardSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vblackboard_1_0\Models\QueryBlackboardSpaceResponse;
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
     * @param QueryBlackboardSpaceRequest $request
     * @param QueryBlackboardSpaceHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return QueryBlackboardSpaceResponse
     */
    public function queryBlackboardSpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operationUserId)) {
            $query['operationUserId'] = $request->operationUserId;
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
            'action'      => 'QueryBlackboardSpace',
            'version'     => 'blackboard_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/blackboard/spaces',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryBlackboardSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryBlackboardSpaceRequest $request
     *
     * @return QueryBlackboardSpaceResponse
     */
    public function queryBlackboardSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryBlackboardSpaceHeaders([]);

        return $this->queryBlackboardSpaceWithOptions($request, $headers, $runtime);
    }
}
