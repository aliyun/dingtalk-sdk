<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchOTOQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchOTOQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchOTOQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchSendOTOHeaders;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchSendOTORequest;
use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\BatchSendOTOResponse;
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
     * @param BatchSendOTORequest $request
     *
     * @return BatchSendOTOResponse
     */
    public function batchSendOTO($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchSendOTOHeaders([]);

        return $this->batchSendOTOWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchSendOTORequest $request
     * @param BatchSendOTOHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return BatchSendOTOResponse
     */
    public function batchSendOTOWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->robotCode)) {
            @$body['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->userIds)) {
            @$body['userIds'] = $request->userIds;
        }
        if (!Utils::isUnset($request->msgKey)) {
            @$body['msgKey'] = $request->msgKey;
        }
        if (!Utils::isUnset($request->msgParam)) {
            @$body['msgParam'] = $request->msgParam;
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

        return BatchSendOTOResponse::fromMap($this->doROARequest('BatchSendOTO', 'robot_1.0', 'HTTP', 'POST', 'AK', '/v1.0/robot/oToMessages/batchSend', 'json', $req, $runtime));
    }

    /**
     * @param BatchOTOQueryRequest $request
     *
     * @return BatchOTOQueryResponse
     */
    public function batchOTOQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchOTOQueryHeaders([]);

        return $this->batchOTOQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchOTOQueryRequest $request
     * @param BatchOTOQueryHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return BatchOTOQueryResponse
     */
    public function batchOTOQueryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->robotCode)) {
            @$query['robotCode'] = $request->robotCode;
        }
        if (!Utils::isUnset($request->processQueryKey)) {
            @$query['processQueryKey'] = $request->processQueryKey;
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

        return BatchOTOQueryResponse::fromMap($this->doROARequest('BatchOTOQuery', 'robot_1.0', 'HTTP', 'GET', 'AK', '/v1.0/robot/oToMessages/readStatus', 'json', $req, $runtime));
    }
}
