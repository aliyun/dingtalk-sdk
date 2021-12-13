<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\RegisterDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\RegisterDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\RegisterDeviceResponse;
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
     * @param RegisterDeviceRequest $request
     *
     * @return RegisterDeviceResponse
     */
    public function registerDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterDeviceHeaders([]);

        return $this->registerDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param RegisterDeviceRequest $request
     * @param RegisterDeviceHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return RegisterDeviceResponse
     */
    public function registerDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            @$body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->id)) {
            @$body['id'] = $request->id;
        }
        if (!Utils::isUnset($request->deviceName)) {
            @$body['deviceName'] = $request->deviceName;
        }
        if (!Utils::isUnset($request->nickName)) {
            @$body['nickName'] = $request->nickName;
        }
        if (!Utils::isUnset($request->location)) {
            @$body['location'] = $request->location;
        }
        if (!Utils::isUnset($request->deviceStatus)) {
            @$body['deviceStatus'] = $request->deviceStatus;
        }
        if (!Utils::isUnset($request->deviceType)) {
            @$body['deviceType'] = $request->deviceType;
        }
        if (!Utils::isUnset($request->deviceTypeName)) {
            @$body['deviceTypeName'] = $request->deviceTypeName;
        }
        if (!Utils::isUnset($request->parentId)) {
            @$body['parentId'] = $request->parentId;
        }
        if (!Utils::isUnset($request->productType)) {
            @$body['productType'] = $request->productType;
        }
        if (!Utils::isUnset($request->liveUrl)) {
            @$body['liveUrl'] = $request->liveUrl;
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

        return RegisterDeviceResponse::fromMap($this->doROARequest('RegisterDevice', 'diot_1.0', 'HTTP', 'POST', 'AK', '/v1.0/diot/devices/register', 'json', $req, $runtime));
    }
}
