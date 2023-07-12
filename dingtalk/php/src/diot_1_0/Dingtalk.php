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
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\DiotMarketManagerResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\DiotSystemMarkTestResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\PushEventHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\PushEventRequest;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\PushEventResponse;
use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\QueryDeviceHeaders;
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
        $this->_client             = new DarabonbaGatewayDingTalkClient();
        $this->_spi                = $this->_client;
        $this->_signatureAlgorithm = 'v2';
        $this->_endpointRule       = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param AyunOnlienTestRequest $request
     * @param string[]              $headers
     * @param RuntimeOptions        $runtime
     *
     * @return AyunOnlienTestResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'AyunOnlienTest',
            'version'     => 'diot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/diot/ayunTest',
            'method'      => 'GET',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return AyunOnlienTestResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param AyunOnlienTestRequest $request
     *
     * @return AyunOnlienTestResponse
     */
    public function ayunOnlienTest($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->ayunOnlienTestWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchDeleteDeviceRequest $request
     * @param BatchDeleteDeviceHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return BatchDeleteDeviceResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BatchDeleteDevice',
            'version'     => 'diot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/diot/devices/remove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchDeleteDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchDeleteDeviceRequest $request
     *
     * @return BatchDeleteDeviceResponse
     */
    public function batchDeleteDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchDeleteDeviceHeaders([]);

        return $this->batchDeleteDeviceWithOptions($request, $headers, $runtime);
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BatchRegisterDevice',
            'version'     => 'diot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/diot/devices/registrations/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchRegisterDeviceResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param BatchRegisterEventTypeRequest $request
     * @param BatchRegisterEventTypeHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return BatchRegisterEventTypeResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BatchRegisterEventType',
            'version'     => 'diot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/diot/eventTypes/registrations/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchRegisterEventTypeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchRegisterEventTypeRequest $request
     *
     * @return BatchRegisterEventTypeResponse
     */
    public function batchRegisterEventType($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchRegisterEventTypeHeaders([]);

        return $this->batchRegisterEventTypeWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BatchUpdateDeviceRequest $request
     * @param BatchUpdateDeviceHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return BatchUpdateDeviceResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BatchUpdateDevice',
            'version'     => 'diot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/diot/devices/batch',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchUpdateDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchUpdateDeviceRequest $request
     *
     * @return BatchUpdateDeviceResponse
     */
    public function batchUpdateDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateDeviceHeaders([]);

        return $this->batchUpdateDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param BindSystemRequest $request
     * @param BindSystemHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return BindSystemResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'BindSystem',
            'version'     => 'diot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/diot/systems/bind',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BindSystemResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BindSystemRequest $request
     *
     * @return BindSystemResponse
     */
    public function bindSystem($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BindSystemHeaders([]);

        return $this->bindSystemWithOptions($request, $headers, $runtime);
    }

    /**
     * @param DeviceConferenceRequest $request
     * @param DeviceConferenceHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return DeviceConferenceResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'DeviceConference',
            'version'     => 'diot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/diot/deviceConferences/initiate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeviceConferenceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param DeviceConferenceRequest $request
     *
     * @return DeviceConferenceResponse
     */
    public function deviceConference($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeviceConferenceHeaders([]);

        return $this->deviceConferenceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string[]       $headers
     * @param RuntimeOptions $runtime
     *
     * @return DiotSystemMarkTestResponse
     */
    public function diotSystemMarkTestWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action'      => 'DiotSystemMarkTest',
            'version'     => 'diot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/diot/sys/mark/test',
            'method'      => 'GET',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DiotSystemMarkTestResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return DiotSystemMarkTestResponse
     */
    public function diotSystemMarkTest()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->diotSystemMarkTestWithOptions($headers, $runtime);
    }

    /**
     * @param string[]       $headers
     * @param RuntimeOptions $runtime
     *
     * @return DiotMarketManagerResponse
     */
    public function diot_Market_ManagerWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action'      => 'Diot_Market_Manager',
            'version'     => 'diot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/diot/market/manager',
            'method'      => 'GET',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DiotMarketManagerResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return DiotMarketManagerResponse
     */
    public function diot_Market_Manager()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->diot_Market_ManagerWithOptions($headers, $runtime);
    }

    /**
     * @param PushEventRequest $request
     * @param PushEventHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return PushEventResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'PushEvent',
            'version'     => 'diot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/diot/events/push',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PushEventResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param PushEventRequest $request
     *
     * @return PushEventResponse
     */
    public function pushEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PushEventHeaders([]);

        return $this->pushEventWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryDeviceRequest $request
     * @param QueryDeviceHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return QueryDeviceResponse
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'QueryDevice',
            'version'     => 'diot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/diot/devices',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryDeviceRequest $request
     *
     * @return QueryDeviceResponse
     */
    public function queryDevice($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDeviceHeaders([]);

        return $this->queryDeviceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryEventRequest $request
     * @param QueryEventHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return QueryEventResponse
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'QueryEvent',
            'version'     => 'diot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/diot/events/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryEventResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryEventRequest $request
     *
     * @return QueryEventResponse
     */
    public function queryEvent($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryEventHeaders([]);

        return $this->queryEventWithOptions($request, $headers, $runtime);
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'RegisterDevice',
            'version'     => 'diot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/diot/devices/register',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RegisterDeviceResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param string[]       $headers
     * @param RuntimeOptions $runtime
     *
     * @return UpgradeDeviceResponse
     */
    public function upgradeDeviceWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action'      => 'UpgradeDevice',
            'version'     => 'diot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/diot/upgrade/device',
            'method'      => 'POST',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpgradeDeviceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return UpgradeDeviceResponse
     */
    public function upgradeDevice()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->upgradeDeviceWithOptions($headers, $runtime);
    }

    /**
     * @param string[]       $headers
     * @param RuntimeOptions $runtime
     *
     * @return WorkbenchTransformInfoResponse
     */
    public function workbenchTransformInfoWithOptions($headers, $runtime)
    {
        $req = new OpenApiRequest([
            'headers' => $headers,
        ]);
        $params = new Params([
            'action'      => 'WorkbenchTransformInfo',
            'version'     => 'diot_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/diot/workbench/transform',
            'method'      => 'GET',
            'authType'    => 'Anonymous',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return WorkbenchTransformInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @return WorkbenchTransformInfoResponse
     */
    public function workbenchTransformInfo()
    {
        $runtime = new RuntimeOptions([]);
        $headers = [];

        return $this->workbenchTransformInfoWithOptions($headers, $runtime);
    }
}
