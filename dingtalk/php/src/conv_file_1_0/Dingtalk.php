<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\SendByAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\SendByAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\SendByAppResponse;
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
     * @param SendByAppRequest $request
     *
     * @return SendByAppResponse
     */
    public function sendByApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SendByAppHeaders([]);

        return $this->sendByAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SendByAppRequest $request
     * @param SendByAppHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return SendByAppResponse
     */
    public function sendByAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->unionId)) {
            @$query['unionId'] = $request->unionId;
        }
        $body = [];
        if (!Utils::isUnset($request->dentryId)) {
            @$body['dentryId'] = $request->dentryId;
        }
        if (!Utils::isUnset($request->spaceId)) {
            @$body['spaceId'] = $request->spaceId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return SendByAppResponse::fromMap($this->doROARequest('SendByApp', 'convFile_1.0', 'HTTP', 'POST', 'AK', '/v1.0/convFile/apps/conversations/files/send', 'json', $req, $runtime));
    }
}
