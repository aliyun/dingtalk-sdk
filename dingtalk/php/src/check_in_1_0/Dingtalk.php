<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcheck_in_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcheck_in_1_0\Models\GetCheckinRecordByUserHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcheck_in_1_0\Models\GetCheckinRecordByUserRequest;
use AlibabaCloud\SDK\Dingtalk\Vcheck_in_1_0\Models\GetCheckinRecordByUserResponse;
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
     * @param GetCheckinRecordByUserRequest $request
     * @param GetCheckinRecordByUserHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetCheckinRecordByUserResponse
     */
    public function getCheckinRecordByUserWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $body['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $body['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
        }
        if (!Utils::isUnset($request->userIdList)) {
            $body['userIdList'] = $request->userIdList;
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
            'action'      => 'GetCheckinRecordByUser',
            'version'     => 'checkIn_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/checkIn/records/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetCheckinRecordByUserResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetCheckinRecordByUserRequest $request
     *
     * @return GetCheckinRecordByUserResponse
     */
    public function getCheckinRecordByUser($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCheckinRecordByUserHeaders([]);

        return $this->getCheckinRecordByUserWithOptions($request, $headers, $runtime);
    }
}
