<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\AyunOnlienTestRequest;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\AyunOnlienTestResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchDeleteDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchDeleteDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchDeleteDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchRegisterDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchRegisterDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchRegisterDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchRegisterEventTypeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchRegisterEventTypeRequest;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchRegisterEventTypeResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchUpdateDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchUpdateDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchUpdateDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BindSystemHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BindSystemRequest;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BindSystemResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\DeviceConferenceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\DeviceConferenceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\DeviceConferenceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\DiotMamaResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\DiotMarketManagerResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\DiotMarketManagerTestResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\DiotSystemMarkTestResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\PushEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\PushEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\PushEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\QueryDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\QueryDevicePkHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\QueryDevicePkRequest;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\QueryDevicePkResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\QueryDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\QueryDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\QueryEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\QueryEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\QueryEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\RegisterDeviceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\RegisterDeviceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\RegisterDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\UpgradeDeviceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\WorkbenchTransformInfoResponse;
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
        $this->_signatureAlgorithm = 'v2';
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary openAPI录入上线前的测试2
     *  *
     * @param AyunOnlienTestRequest $request AyunOnlienTestRequest
     * @param string[]              $headers map
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return AyunOnlienTestResponse AyunOnlienTestResponse
     */
    public function ayunOnlienTestWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->reqId)) {
            $query['reqId'] = $request->reqId;
        }
        $req = new OpenApiRequest([
            'headers' => $headers,
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'AyunOnlienTest',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/ayunTest',
            'method' => 'GET',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return AyunOnlienTestResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary openAPI录入上线前的测试2
     *  *
     * @param AyunOnlienTestRequest $request AyunOnlienTestRequest
     *
     * @return AyunOnlienTestResponse AyunOnlienTestResponse
     */
    public function ayunOnlienTest($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->ayunOnlienTestWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除设备
     *  *
     * @param BatchDeleteDeviceRequest $request BatchDeleteDeviceRequest
     * @param BatchDeleteDeviceHeaders $headers BatchDeleteDeviceHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchDeleteDeviceResponse BatchDeleteDeviceResponse
     */
    public function batchDeleteDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->deviceIds)) {
            $body['deviceIds'] = $request->deviceIds;
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
            'action' => 'BatchDeleteDevice',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/devices/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchDeleteDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除设备
     *  *
     * @param BatchDeleteDeviceRequest $request BatchDeleteDeviceRequest
     *
     * @return BatchDeleteDeviceResponse BatchDeleteDeviceResponse
     */
    public function batchDeleteDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchDeleteDeviceHeaders([]);

        return $this->batchDeleteDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量注册设备
     *  *
     * @param BatchRegisterDeviceRequest $request BatchRegisterDeviceRequest
     * @param BatchRegisterDeviceHeaders $headers BatchRegisterDeviceHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchRegisterDeviceResponse BatchRegisterDeviceResponse
     */
    public function batchRegisterDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->devices)) {
            $body['devices'] = $request->devices;
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
            'action' => 'BatchRegisterDevice',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/devices/registrations/batch',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchRegisterDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量注册设备
     *  *
     * @param BatchRegisterDeviceRequest $request BatchRegisterDeviceRequest
     *
     * @return BatchRegisterDeviceResponse BatchRegisterDeviceResponse
     */
    public function batchRegisterDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchRegisterDeviceHeaders([]);

        return $this->batchRegisterDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量注册事件类型
     *  *
     * @param BatchRegisterEventTypeRequest $request BatchRegisterEventTypeRequest
     * @param BatchRegisterEventTypeHeaders $headers BatchRegisterEventTypeHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchRegisterEventTypeResponse BatchRegisterEventTypeResponse
     */
    public function batchRegisterEventTypeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->eventTypes)) {
            $body['eventTypes'] = $request->eventTypes;
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
            'action' => 'BatchRegisterEventType',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/eventTypes/registrations/batch',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchRegisterEventTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量注册事件类型
     *  *
     * @param BatchRegisterEventTypeRequest $request BatchRegisterEventTypeRequest
     *
     * @return BatchRegisterEventTypeResponse BatchRegisterEventTypeResponse
     */
    public function batchRegisterEventType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchRegisterEventTypeHeaders([]);

        return $this->batchRegisterEventTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量修改设备
     *  *
     * @param BatchUpdateDeviceRequest $request BatchUpdateDeviceRequest
     * @param BatchUpdateDeviceHeaders $headers BatchUpdateDeviceHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchUpdateDeviceResponse BatchUpdateDeviceResponse
     */
    public function batchUpdateDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->devices)) {
            $body['devices'] = $request->devices;
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
            'action' => 'BatchUpdateDevice',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/devices/batch',
            'method' => 'PUT',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BatchUpdateDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量修改设备
     *  *
     * @param BatchUpdateDeviceRequest $request BatchUpdateDeviceRequest
     *
     * @return BatchUpdateDeviceResponse BatchUpdateDeviceResponse
     */
    public function batchUpdateDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateDeviceHeaders([]);

        return $this->batchUpdateDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 系统绑定
     *  *
     * @param BindSystemRequest $request BindSystemRequest
     * @param BindSystemHeaders $headers BindSystemHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return BindSystemResponse BindSystemResponse
     */
    public function bindSystemWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->authCode)) {
            $body['authCode'] = $request->authCode;
        }
        if (!Utils::isUnset($request->clientId)) {
            $body['clientId'] = $request->clientId;
        }
        if (!Utils::isUnset($request->clientName)) {
            $body['clientName'] = $request->clientName;
        }
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->extraData)) {
            $body['extraData'] = $request->extraData;
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
            'action' => 'BindSystem',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/systems/bind',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return BindSystemResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 系统绑定
     *  *
     * @param BindSystemRequest $request BindSystemRequest
     *
     * @return BindSystemResponse BindSystemResponse
     */
    public function bindSystem($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BindSystemHeaders([]);

        return $this->bindSystemWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发起设备会议
     *  *
     * @param DeviceConferenceRequest $request DeviceConferenceRequest
     * @param DeviceConferenceHeaders $headers DeviceConferenceHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return DeviceConferenceResponse DeviceConferenceResponse
     */
    public function deviceConferenceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->confTitle)) {
            $body['confTitle'] = $request->confTitle;
        }
        if (!Utils::isUnset($request->conferenceId)) {
            $body['conferenceId'] = $request->conferenceId;
        }
        if (!Utils::isUnset($request->conferencePassword)) {
            $body['conferencePassword'] = $request->conferencePassword;
        }
        if (!Utils::isUnset($request->deviceIds)) {
            $body['deviceIds'] = $request->deviceIds;
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
            'action' => 'DeviceConference',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/deviceConferences/initiate',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DeviceConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发起设备会议
     *  *
     * @param DeviceConferenceRequest $request DeviceConferenceRequest
     *
     * @return DeviceConferenceResponse DeviceConferenceResponse
     */
    public function deviceConference($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeviceConferenceHeaders([]);

        return $this->deviceConferenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 钉钉物联Mama接口
     *  *
     * @param string[]       $headers map
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return DiotMamaResponse DiotMamaResponse
     */
    public function diotMamaWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action' => 'DiotMama',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot',
            'method' => 'GET',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DiotMamaResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 钉钉物联Mama接口
     *  *
     * @return DiotMamaResponse DiotMamaResponse
     */
    public function diotMama()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->diotMamaWithOptions($headers, $runtime);
    }

    /**
     * @summary diot官方市场处理
     *  *
     * @param string[]       $headers map
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return DiotMarketManagerTestResponse DiotMarketManagerTestResponse
     */
    public function diotMarketManagerTestWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action' => 'DiotMarketManagerTest',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/market/manager/test',
            'method' => 'PUT',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DiotMarketManagerTestResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary diot官方市场处理
     *  *
     * @return DiotMarketManagerTestResponse DiotMarketManagerTestResponse
     */
    public function diotMarketManagerTest()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->diotMarketManagerTestWithOptions($headers, $runtime);
    }

    /**
     * @summary 钉钉物联系统测试
     *  *
     * @param string[]       $headers map
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return DiotSystemMarkTestResponse DiotSystemMarkTestResponse
     */
    public function diotSystemMarkTestWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action' => 'DiotSystemMarkTest',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/sys/mark/test',
            'method' => 'GET',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DiotSystemMarkTestResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 钉钉物联系统测试
     *  *
     * @return DiotSystemMarkTestResponse DiotSystemMarkTestResponse
     */
    public function diotSystemMarkTest()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->diotSystemMarkTestWithOptions($headers, $runtime);
    }

    /**
     * @summary 钉钉物联市场管理
     *  *
     * @param string[]       $headers map
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return DiotMarketManagerResponse DiotMarketManagerResponse
     */
    public function diot_Market_ManagerWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action' => 'Diot_Market_Manager',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/market/manager',
            'method' => 'GET',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return DiotMarketManagerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 钉钉物联市场管理
     *  *
     * @return DiotMarketManagerResponse DiotMarketManagerResponse
     */
    public function diot_Market_Manager()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->diot_Market_ManagerWithOptions($headers, $runtime);
    }

    /**
     * @summary 推送事件
     *  *
     * @param PushEventRequest $request PushEventRequest
     * @param PushEventHeaders $headers PushEventHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return PushEventResponse PushEventResponse
     */
    public function pushEventWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->deviceId)) {
            $body['deviceId'] = $request->deviceId;
        }
        if (!Utils::isUnset($request->eventId)) {
            $body['eventId'] = $request->eventId;
        }
        if (!Utils::isUnset($request->eventName)) {
            $body['eventName'] = $request->eventName;
        }
        if (!Utils::isUnset($request->eventType)) {
            $body['eventType'] = $request->eventType;
        }
        if (!Utils::isUnset($request->extraData)) {
            $body['extraData'] = $request->extraData;
        }
        if (!Utils::isUnset($request->location)) {
            $body['location'] = $request->location;
        }
        if (!Utils::isUnset($request->msg)) {
            $body['msg'] = $request->msg;
        }
        if (!Utils::isUnset($request->occurrenceTime)) {
            $body['occurrenceTime'] = $request->occurrenceTime;
        }
        if (!Utils::isUnset($request->picUrls)) {
            $body['picUrls'] = $request->picUrls;
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
            'action' => 'PushEvent',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/events/push',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return PushEventResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 推送事件
     *  *
     * @param PushEventRequest $request PushEventRequest
     *
     * @return PushEventResponse PushEventResponse
     */
    public function pushEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PushEventHeaders([]);

        return $this->pushEventWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询设备
     *  *
     * @param QueryDeviceRequest $request QueryDeviceRequest
     * @param QueryDeviceHeaders $headers QueryDeviceHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDeviceResponse QueryDeviceResponse
     */
    public function queryDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
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
            'action' => 'QueryDevice',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/devices',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询设备
     *  *
     * @param QueryDeviceRequest $request QueryDeviceRequest
     *
     * @return QueryDeviceResponse QueryDeviceResponse
     */
    public function queryDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceHeaders([]);

        return $this->queryDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询硬件设备的PK值信息
     *  *
     * @param QueryDevicePkRequest $request QueryDevicePkRequest
     * @param QueryDevicePkHeaders $headers QueryDevicePkHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryDevicePkResponse QueryDevicePkResponse
     */
    public function queryDevicePkWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->deviceId)) {
            $body['deviceId'] = $request->deviceId;
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
            'action' => 'QueryDevicePk',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/devices/pkInfos/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryDevicePkResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询硬件设备的PK值信息
     *  *
     * @param QueryDevicePkRequest $request QueryDevicePkRequest
     *
     * @return QueryDevicePkResponse QueryDevicePkResponse
     */
    public function queryDevicePk($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDevicePkHeaders([]);

        return $this->queryDevicePkWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询事件
     *  *
     * @param QueryEventRequest $request QueryEventRequest
     * @param QueryEventHeaders $headers QueryEventHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryEventResponse QueryEventResponse
     */
    public function queryEventWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->deviceIdList)) {
            $body['deviceIdList'] = $request->deviceIdList;
        }
        if (!Utils::isUnset($request->endTime)) {
            $body['endTime'] = $request->endTime;
        }
        if (!Utils::isUnset($request->eventId)) {
            $body['eventId'] = $request->eventId;
        }
        if (!Utils::isUnset($request->eventStatusList)) {
            $body['eventStatusList'] = $request->eventStatusList;
        }
        if (!Utils::isUnset($request->eventTypeList)) {
            $body['eventTypeList'] = $request->eventTypeList;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->startTime)) {
            $body['startTime'] = $request->startTime;
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
            'action' => 'QueryEvent',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/events/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return QueryEventResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询事件
     *  *
     * @param QueryEventRequest $request QueryEventRequest
     *
     * @return QueryEventResponse QueryEventResponse
     */
    public function queryEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryEventHeaders([]);

        return $this->queryEventWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 注册设备
     *  *
     * @param RegisterDeviceRequest $request RegisterDeviceRequest
     * @param RegisterDeviceHeaders $headers RegisterDeviceHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return RegisterDeviceResponse RegisterDeviceResponse
     */
    public function registerDeviceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->deviceName)) {
            $body['deviceName'] = $request->deviceName;
        }
        if (!Utils::isUnset($request->deviceStatus)) {
            $body['deviceStatus'] = $request->deviceStatus;
        }
        if (!Utils::isUnset($request->deviceType)) {
            $body['deviceType'] = $request->deviceType;
        }
        if (!Utils::isUnset($request->deviceTypeName)) {
            $body['deviceTypeName'] = $request->deviceTypeName;
        }
        if (!Utils::isUnset($request->id)) {
            $body['id'] = $request->id;
        }
        if (!Utils::isUnset($request->liveUrls)) {
            $body['liveUrls'] = $request->liveUrls;
        }
        if (!Utils::isUnset($request->location)) {
            $body['location'] = $request->location;
        }
        if (!Utils::isUnset($request->nickName)) {
            $body['nickName'] = $request->nickName;
        }
        if (!Utils::isUnset($request->parentId)) {
            $body['parentId'] = $request->parentId;
        }
        if (!Utils::isUnset($request->productType)) {
            $body['productType'] = $request->productType;
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
            'action' => 'RegisterDevice',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/devices/register',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return RegisterDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 注册设备
     *  *
     * @param RegisterDeviceRequest $request RegisterDeviceRequest
     *
     * @return RegisterDeviceResponse RegisterDeviceResponse
     */
    public function registerDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RegisterDeviceHeaders([]);

        return $this->registerDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 升级设备
     *  *
     * @param string[]       $headers map
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return UpgradeDeviceResponse UpgradeDeviceResponse
     */
    public function upgradeDeviceWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action' => 'UpgradeDevice',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/upgrade/device',
            'method' => 'POST',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return UpgradeDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 升级设备
     *  *
     * @return UpgradeDeviceResponse UpgradeDeviceResponse
     */
    public function upgradeDevice()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->upgradeDeviceWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取工作台流转物联信息
     *  *
     * @param string[]       $headers map
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return WorkbenchTransformInfoResponse WorkbenchTransformInfoResponse
     */
    public function workbenchTransformInfoWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action' => 'WorkbenchTransformInfo',
            'version' => 'diot_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/diot/workbench/transform',
            'method' => 'GET',
            'authType' => 'Anonymous',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return WorkbenchTransformInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取工作台流转物联信息
     *  *
     * @return WorkbenchTransformInfoResponse WorkbenchTransformInfoResponse
     */
    public function workbenchTransformInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->workbenchTransformInfoWithOptions($headers, $runtime);
    }
}
