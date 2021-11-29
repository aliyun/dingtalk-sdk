<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\BatchRegisterDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\BatchRegisterDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\BatchRegisterDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateDepartmentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateDepartmentRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\CreateDepartmentResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\DeviceDingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\DeviceDingRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\DeviceDingResponse;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\RegisterDeviceResponse;
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
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->deviceKey)) {
            @$body['deviceKey'] = $request->deviceKey;
        }
        if (!Utils::isUnset($request->deviceName)) {
            @$body['deviceName'] = $request->deviceName;
        }
        if (!Utils::isUnset($request->departmentId)) {
            @$body['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->managers)) {
            @$body['managers'] = $request->managers;
        }
        if (!Utils::isUnset($request->collaborators)) {
            @$body['collaborators'] = $request->collaborators;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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

        return RegisterDeviceResponse::fromMap($this->doROARequest('RegisterDevice', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/devices', 'json', $req, $runtime));
    }

    /**
     * @param BatchRegisterDeviceRequest $request
     *
     * @return BatchRegisterDeviceResponse
     */
    public function batchRegisterDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchRegisterDeviceHeaders([]);

        return $this->batchRegisterDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchRegisterDeviceRequest $request
     * @param BatchRegisterDeviceHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return BatchRegisterDeviceResponse
     */
    public function batchRegisterDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceList)) {
            @$body['deviceList'] = $request->deviceList;
        }
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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

        return BatchRegisterDeviceResponse::fromMap($this->doROARequest('BatchRegisterDevice', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/devices/batch', 'json', $req, $runtime));
    }

    /**
     * @param DeviceDingRequest $request
     *
     * @return DeviceDingResponse
     */
    public function deviceDing($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeviceDingHeaders([]);

        return $this->deviceDingWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeviceDingRequest $request
     * @param DeviceDingHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return DeviceDingResponse
     */
    public function deviceDingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->paramsJson)) {
            @$body['paramsJson'] = $request->paramsJson;
        }
        if (!Utils::isUnset($request->deviceKey)) {
            @$body['deviceKey'] = $request->deviceKey;
        }
        if (!Utils::isUnset($request->receiverUserIdList)) {
            @$body['receiverUserIdList'] = $request->receiverUserIdList;
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

        return DeviceDingResponse::fromMap($this->doROARequest('DeviceDing', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/ding', 'json', $req, $runtime));
    }

    /**
     * @param CreateDepartmentRequest $request
     *
     * @return CreateDepartmentResponse
     */
    public function createDepartment($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDepartmentHeaders([]);

        return $this->createDepartmentWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateDepartmentRequest $request
     * @param CreateDepartmentHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return CreateDepartmentResponse
     */
    public function createDepartmentWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->departmentName)) {
            @$body['departmentName'] = $request->departmentName;
        }
        if (!Utils::isUnset($request->departmentType)) {
            @$body['departmentType'] = $request->departmentType;
        }
        if (!Utils::isUnset($request->systemUrl)) {
            @$body['systemUrl'] = $request->systemUrl;
        }
        if (!Utils::isUnset($request->authType)) {
            @$body['authType'] = $request->authType;
        }
        if (!Utils::isUnset($request->authInfo)) {
            @$body['authInfo'] = $request->authInfo;
        }
        if (!Utils::isUnset($request->description)) {
            @$body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->bizExt)) {
            @$body['bizExt'] = $request->bizExt;
        }
        if (!Utils::isUnset($request->userId)) {
            @$body['userId'] = $request->userId;
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

        return CreateDepartmentResponse::fromMap($this->doROARequest('CreateDepartment', 'devicemng_1.0', 'HTTP', 'POST', 'AK', '/v1.0/devicemng/departments', 'json', $req, $runtime));
    }
}
