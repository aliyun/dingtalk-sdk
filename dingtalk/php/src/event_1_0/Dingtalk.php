<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vevent_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\GetCallBackFaileResultHeaders;
use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\GetCallBackFaileResultRequest;
use AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models\GetCallBackFaileResultResponse;
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
     * @param GetCallBackFaileResultRequest $request
     *
     * @return GetCallBackFaileResultResponse
     */
    public function getCallBackFaileResult($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetCallBackFaileResultHeaders([]);

        return $this->getCallBackFaileResultWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetCallBackFaileResultRequest $request
     * @param GetCallBackFaileResultHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetCallBackFaileResultResponse
     */
    public function getCallBackFaileResultWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->beginTime)) {
            @$query['beginTime'] = $request->beginTime;
        }
        if (!Utils::isUnset($request->endTime)) {
            @$query['endTime'] = $request->endTime;
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

        return GetCallBackFaileResultResponse::fromMap($this->doROARequest('GetCallBackFaileResult', 'event_1.0', 'HTTP', 'GET', 'AK', '/v1.0/event/callbacks/failedResults', 'json', $req, $runtime));
    }
}
