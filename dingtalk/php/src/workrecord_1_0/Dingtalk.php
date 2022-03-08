<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkrecord_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vworkrecord_1_0\Models\CountWorkRecordHeaders;
use AlibabaCloud\SDK\Dingtalk\Vworkrecord_1_0\Models\CountWorkRecordRequest;
use AlibabaCloud\SDK\Dingtalk\Vworkrecord_1_0\Models\CountWorkRecordResponse;
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
     * @param CountWorkRecordRequest $request
     *
     * @return CountWorkRecordResponse
     */
    public function countWorkRecord($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CountWorkRecordHeaders([]);

        return $this->countWorkRecordWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CountWorkRecordRequest $request
     * @param CountWorkRecordHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return CountWorkRecordResponse
     */
    public function countWorkRecordWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->userId)) {
            @$query['userId'] = $request->userId;
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

        return CountWorkRecordResponse::fromMap($this->doROARequest('CountWorkRecord', 'workrecord_1.0', 'HTTP', 'GET', 'AK', '/v1.0/workrecord/counts', 'json', $req, $runtime));
    }
}
