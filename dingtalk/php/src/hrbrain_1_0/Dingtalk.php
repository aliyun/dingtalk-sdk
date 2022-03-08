<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\SyncDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\SyncDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\SyncDataResponse;
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
     * @param SyncDataRequest $request
     *
     * @return SyncDataResponse
     */
    public function syncData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncDataHeaders([]);

        return $this->syncDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncDataRequest $request
     * @param SyncDataHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return SyncDataResponse
     */
    public function syncDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            @$body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->dataId)) {
            @$body['dataId'] = $request->dataId;
        }
        if (!Utils::isUnset($request->etlTime)) {
            @$body['etlTime'] = $request->etlTime;
        }
        if (!Utils::isUnset($request->projectId)) {
            @$body['projectId'] = $request->projectId;
        }
        if (!Utils::isUnset($request->schemaId)) {
            @$body['schemaId'] = $request->schemaId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SyncDataResponse::fromMap($this->doROARequest('SyncData', 'hrbrain_1.0', 'HTTP', 'POST', 'AK', '/v1.0/hrbrain/datas', 'json', $req, $runtime));
    }
}
