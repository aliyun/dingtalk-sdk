<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vaiot_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\CheckDeviceUpdateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\CheckDeviceUpdateRequest;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\CheckDeviceUpdateResponse;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\ConfirmFirmwareUpgradeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\ConfirmFirmwareUpgradeRequest;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\ConfirmFirmwareUpgradeResponse;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\GetDeviceDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\GetDeviceDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\GetDevicePropertiesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\GetDevicePropertiesRequest;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\GetDevicePropertiesResponse;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\GetServiceInvocationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\GetServiceInvocationResponse;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\InvokeDeviceServiceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\InvokeDeviceServiceRequest;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\InvokeDeviceServiceResponse;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\SetDevicePropertiesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\SetDevicePropertiesRequest;
use AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\SetDevicePropertiesResponse;
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
        $gatewayClient = new Client();
        $this->_spi = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 检查指定设备的固件升级
     *  *
     * @param string                   $productKey
     * @param string                   $deviceName
     * @param CheckDeviceUpdateRequest $request    CheckDeviceUpdateRequest
     * @param CheckDeviceUpdateHeaders $headers    CheckDeviceUpdateHeaders
     * @param RuntimeOptions           $runtime    runtime options for this request RuntimeOptions
     *
     * @return CheckDeviceUpdateResponse CheckDeviceUpdateResponse
     */
    public function checkDeviceUpdateWithOptions($productKey, $deviceName, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'CheckDeviceUpdate',
            'version' => 'aiot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/aiot/products/' . $productKey . '/devices/' . $deviceName . '/firmware/checkUpdate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return CheckDeviceUpdateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 检查指定设备的固件升级
     *  *
     * @param string                   $productKey
     * @param string                   $deviceName
     * @param CheckDeviceUpdateRequest $request    CheckDeviceUpdateRequest
     *
     * @return CheckDeviceUpdateResponse CheckDeviceUpdateResponse
     */
    public function checkDeviceUpdate($productKey, $deviceName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CheckDeviceUpdateHeaders([]);

        return $this->checkDeviceUpdateWithOptions($productKey, $deviceName, $request, $headers, $runtime);
    }

    /**
     * @summary 确认执行设备固件升级
     *  *
     * @param string                        $productKey
     * @param string                        $deviceName
     * @param ConfirmFirmwareUpgradeRequest $request    ConfirmFirmwareUpgradeRequest
     * @param ConfirmFirmwareUpgradeHeaders $headers    ConfirmFirmwareUpgradeHeaders
     * @param RuntimeOptions                $runtime    runtime options for this request RuntimeOptions
     *
     * @return ConfirmFirmwareUpgradeResponse ConfirmFirmwareUpgradeResponse
     */
    public function confirmFirmwareUpgradeWithOptions($productKey, $deviceName, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->moduleName)) {
            $query['moduleName'] = $request->moduleName;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'ConfirmFirmwareUpgrade',
            'version' => 'aiot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/aiot/products/' . $productKey . '/devices/' . $deviceName . '/firmware/confirmUpgrade',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return ConfirmFirmwareUpgradeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 确认执行设备固件升级
     *  *
     * @param string                        $productKey
     * @param string                        $deviceName
     * @param ConfirmFirmwareUpgradeRequest $request    ConfirmFirmwareUpgradeRequest
     *
     * @return ConfirmFirmwareUpgradeResponse ConfirmFirmwareUpgradeResponse
     */
    public function confirmFirmwareUpgrade($productKey, $deviceName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ConfirmFirmwareUpgradeHeaders([]);

        return $this->confirmFirmwareUpgradeWithOptions($productKey, $deviceName, $request, $headers, $runtime);
    }

    /**
     * @summary 查询指定设备的详情
     *  *
     * @param string                 $productKey
     * @param string                 $deviceName
     * @param GetDeviceDetailHeaders $headers    GetDeviceDetailHeaders
     * @param RuntimeOptions         $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetDeviceDetailResponse GetDeviceDetailResponse
     */
    public function getDeviceDetailWithOptions($productKey, $deviceName, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action' => 'GetDeviceDetail',
            'version' => 'aiot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/aiot/products/' . $productKey . '/devices/' . $deviceName . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetDeviceDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询指定设备的详情
     *  *
     * @param string $productKey
     * @param string $deviceName
     *
     * @return GetDeviceDetailResponse GetDeviceDetailResponse
     */
    public function getDeviceDetail($productKey, $deviceName)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDeviceDetailHeaders([]);

        return $this->getDeviceDetailWithOptions($productKey, $deviceName, $headers, $runtime);
    }

    /**
     * @summary 读取指定设备的属性快照
     *  *
     * @param string                     $productKey
     * @param string                     $deviceName
     * @param GetDevicePropertiesRequest $request    GetDevicePropertiesRequest
     * @param GetDevicePropertiesHeaders $headers    GetDevicePropertiesHeaders
     * @param RuntimeOptions             $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetDevicePropertiesResponse GetDevicePropertiesResponse
     */
    public function getDevicePropertiesWithOptions($productKey, $deviceName, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body' => $request->body,
        ]);
        $params = new Params([
            'action' => 'GetDeviceProperties',
            'version' => 'aiot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/aiot/products/' . $productKey . '/devices/' . $deviceName . '/properties/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetDevicePropertiesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 读取指定设备的属性快照
     *  *
     * @param string                     $productKey
     * @param string                     $deviceName
     * @param GetDevicePropertiesRequest $request    GetDevicePropertiesRequest
     *
     * @return GetDevicePropertiesResponse GetDevicePropertiesResponse
     */
    public function getDeviceProperties($productKey, $deviceName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDevicePropertiesHeaders([]);

        return $this->getDevicePropertiesWithOptions($productKey, $deviceName, $request, $headers, $runtime);
    }

    /**
     * @summary 查询设备服务调用结果
     *  *
     * @param string                      $invocationId
     * @param GetServiceInvocationHeaders $headers      GetServiceInvocationHeaders
     * @param RuntimeOptions              $runtime      runtime options for this request RuntimeOptions
     *
     * @return GetServiceInvocationResponse GetServiceInvocationResponse
     */
    public function getServiceInvocationWithOptions($invocationId, $headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action' => 'GetServiceInvocation',
            'version' => 'aiot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/aiot/serviceInvocations/' . $invocationId . '',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return GetServiceInvocationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询设备服务调用结果
     *  *
     * @param string $invocationId
     *
     * @return GetServiceInvocationResponse GetServiceInvocationResponse
     */
    public function getServiceInvocation($invocationId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetServiceInvocationHeaders([]);

        return $this->getServiceInvocationWithOptions($invocationId, $headers, $runtime);
    }

    /**
     * @summary 调用指定设备的物模型服务
     *  *
     * @param string                     $productKey
     * @param string                     $deviceName
     * @param string                     $serviceIdentifier
     * @param InvokeDeviceServiceRequest $request           InvokeDeviceServiceRequest
     * @param InvokeDeviceServiceHeaders $headers           InvokeDeviceServiceHeaders
     * @param RuntimeOptions             $runtime           runtime options for this request RuntimeOptions
     *
     * @return InvokeDeviceServiceResponse InvokeDeviceServiceResponse
     */
    public function invokeDeviceServiceWithOptions($productKey, $deviceName, $serviceIdentifier, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->args)) {
            $body['args'] = $request->args;
        }
        if (!Utils::isUnset($request->timeoutSeconds)) {
            $body['timeoutSeconds'] = $request->timeoutSeconds;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'InvokeDeviceService',
            'version' => 'aiot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/aiot/products/' . $productKey . '/devices/' . $deviceName . '/services/' . $serviceIdentifier . '/invoke',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return InvokeDeviceServiceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 调用指定设备的物模型服务
     *  *
     * @param string                     $productKey
     * @param string                     $deviceName
     * @param string                     $serviceIdentifier
     * @param InvokeDeviceServiceRequest $request           InvokeDeviceServiceRequest
     *
     * @return InvokeDeviceServiceResponse InvokeDeviceServiceResponse
     */
    public function invokeDeviceService($productKey, $deviceName, $serviceIdentifier, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new InvokeDeviceServiceHeaders([]);

        return $this->invokeDeviceServiceWithOptions($productKey, $deviceName, $serviceIdentifier, $request, $headers, $runtime);
    }

    /**
     * @summary 设置指定设备的属性
     *  *
     * @param string                     $productKey
     * @param string                     $deviceName
     * @param SetDevicePropertiesRequest $request    SetDevicePropertiesRequest
     * @param SetDevicePropertiesHeaders $headers    SetDevicePropertiesHeaders
     * @param RuntimeOptions             $runtime    runtime options for this request RuntimeOptions
     *
     * @return SetDevicePropertiesResponse SetDevicePropertiesResponse
     */
    public function setDevicePropertiesWithOptions($productKey, $deviceName, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->body)) {
            $body['body'] = $request->body;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SetDeviceProperties',
            'version' => 'aiot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/aiot/products/' . $productKey . '/devices/' . $deviceName . '/properties',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return SetDevicePropertiesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 设置指定设备的属性
     *  *
     * @param string                     $productKey
     * @param string                     $deviceName
     * @param SetDevicePropertiesRequest $request    SetDevicePropertiesRequest
     *
     * @return SetDevicePropertiesResponse SetDevicePropertiesResponse
     */
    public function setDeviceProperties($productKey, $deviceName, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SetDevicePropertiesHeaders([]);

        return $this->setDevicePropertiesWithOptions($productKey, $deviceName, $request, $headers, $runtime);
    }
}
