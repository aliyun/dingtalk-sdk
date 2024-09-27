// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdiot_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._productId = "dingtalk";
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>openAPI录入上线前的测试2</p>
     * 
     * @param request AyunOnlienTestRequest
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return AyunOnlienTestResponse
     */
    public AyunOnlienTestResponse ayunOnlienTestWithOptions(AyunOnlienTestRequest request, java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.reqId)) {
            query.put("reqId", request.reqId);
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AyunOnlienTest"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/ayunTest"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.doROARequestWithForm(params.action, params.version, params.protocol, params.method, params.authType, params.pathname, params.bodyType, req, runtime), new AyunOnlienTestResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>openAPI录入上线前的测试2</p>
     * 
     * @param request AyunOnlienTestRequest
     * @return AyunOnlienTestResponse
     */
    public AyunOnlienTestResponse ayunOnlienTest(AyunOnlienTestRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.ayunOnlienTestWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除设备</p>
     * 
     * @param request BatchDeleteDeviceRequest
     * @param headers BatchDeleteDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchDeleteDeviceResponse
     */
    public BatchDeleteDeviceResponse batchDeleteDeviceWithOptions(BatchDeleteDeviceRequest request, BatchDeleteDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceIds)) {
            body.put("deviceIds", request.deviceIds);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchDeleteDevice"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/devices/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchDeleteDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除设备</p>
     * 
     * @param request BatchDeleteDeviceRequest
     * @return BatchDeleteDeviceResponse
     */
    public BatchDeleteDeviceResponse batchDeleteDevice(BatchDeleteDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchDeleteDeviceHeaders headers = new BatchDeleteDeviceHeaders();
        return this.batchDeleteDeviceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量注册设备</p>
     * 
     * @param request BatchRegisterDeviceRequest
     * @param headers BatchRegisterDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchRegisterDeviceResponse
     */
    public BatchRegisterDeviceResponse batchRegisterDeviceWithOptions(BatchRegisterDeviceRequest request, BatchRegisterDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.devices)) {
            body.put("devices", request.devices);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchRegisterDevice"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/devices/registrations/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchRegisterDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量注册设备</p>
     * 
     * @param request BatchRegisterDeviceRequest
     * @return BatchRegisterDeviceResponse
     */
    public BatchRegisterDeviceResponse batchRegisterDevice(BatchRegisterDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchRegisterDeviceHeaders headers = new BatchRegisterDeviceHeaders();
        return this.batchRegisterDeviceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量注册事件类型</p>
     * 
     * @param request BatchRegisterEventTypeRequest
     * @param headers BatchRegisterEventTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchRegisterEventTypeResponse
     */
    public BatchRegisterEventTypeResponse batchRegisterEventTypeWithOptions(BatchRegisterEventTypeRequest request, BatchRegisterEventTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.eventTypes)) {
            body.put("eventTypes", request.eventTypes);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchRegisterEventType"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/eventTypes/registrations/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchRegisterEventTypeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量注册事件类型</p>
     * 
     * @param request BatchRegisterEventTypeRequest
     * @return BatchRegisterEventTypeResponse
     */
    public BatchRegisterEventTypeResponse batchRegisterEventType(BatchRegisterEventTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchRegisterEventTypeHeaders headers = new BatchRegisterEventTypeHeaders();
        return this.batchRegisterEventTypeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量修改设备</p>
     * 
     * @param request BatchUpdateDeviceRequest
     * @param headers BatchUpdateDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchUpdateDeviceResponse
     */
    public BatchUpdateDeviceResponse batchUpdateDeviceWithOptions(BatchUpdateDeviceRequest request, BatchUpdateDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.devices)) {
            body.put("devices", request.devices);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchUpdateDevice"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/devices/batch"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchUpdateDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量修改设备</p>
     * 
     * @param request BatchUpdateDeviceRequest
     * @return BatchUpdateDeviceResponse
     */
    public BatchUpdateDeviceResponse batchUpdateDevice(BatchUpdateDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchUpdateDeviceHeaders headers = new BatchUpdateDeviceHeaders();
        return this.batchUpdateDeviceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>系统绑定</p>
     * 
     * @param request BindSystemRequest
     * @param headers BindSystemHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BindSystemResponse
     */
    public BindSystemResponse bindSystemWithOptions(BindSystemRequest request, BindSystemHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authCode)) {
            body.put("authCode", request.authCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.clientId)) {
            body.put("clientId", request.clientId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.clientName)) {
            body.put("clientName", request.clientName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extraData)) {
            body.put("extraData", request.extraData);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BindSystem"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/systems/bind"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BindSystemResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>系统绑定</p>
     * 
     * @param request BindSystemRequest
     * @return BindSystemResponse
     */
    public BindSystemResponse bindSystem(BindSystemRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BindSystemHeaders headers = new BindSystemHeaders();
        return this.bindSystemWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发起设备会议</p>
     * 
     * @param request DeviceConferenceRequest
     * @param headers DeviceConferenceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeviceConferenceResponse
     */
    public DeviceConferenceResponse deviceConferenceWithOptions(DeviceConferenceRequest request, DeviceConferenceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.confTitle)) {
            body.put("confTitle", request.confTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.conferenceId)) {
            body.put("conferenceId", request.conferenceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.conferencePassword)) {
            body.put("conferencePassword", request.conferencePassword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceIds)) {
            body.put("deviceIds", request.deviceIds);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeviceConference"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/deviceConferences/initiate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeviceConferenceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发起设备会议</p>
     * 
     * @param request DeviceConferenceRequest
     * @return DeviceConferenceResponse
     */
    public DeviceConferenceResponse deviceConference(DeviceConferenceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeviceConferenceHeaders headers = new DeviceConferenceHeaders();
        return this.deviceConferenceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>钉钉物联Mama接口</p>
     * 
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return DiotMamaResponse
     */
    public DiotMamaResponse diotMamaWithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DiotMama"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.doROARequestWithForm(params.action, params.version, params.protocol, params.method, params.authType, params.pathname, params.bodyType, req, runtime), new DiotMamaResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>钉钉物联Mama接口</p>
     * @return DiotMamaResponse
     */
    public DiotMamaResponse diotMama() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.diotMamaWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>diot官方市场处理</p>
     * 
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return DiotMarketManagerTestResponse
     */
    public DiotMarketManagerTestResponse diotMarketManagerTestWithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DiotMarketManagerTest"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/market/manager/test"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.doROARequestWithForm(params.action, params.version, params.protocol, params.method, params.authType, params.pathname, params.bodyType, req, runtime), new DiotMarketManagerTestResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>diot官方市场处理</p>
     * @return DiotMarketManagerTestResponse
     */
    public DiotMarketManagerTestResponse diotMarketManagerTest() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.diotMarketManagerTestWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>钉钉物联系统测试</p>
     * 
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return DiotSystemMarkTestResponse
     */
    public DiotSystemMarkTestResponse diotSystemMarkTestWithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DiotSystemMarkTest"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/sys/mark/test"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.doROARequestWithForm(params.action, params.version, params.protocol, params.method, params.authType, params.pathname, params.bodyType, req, runtime), new DiotSystemMarkTestResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>钉钉物联系统测试</p>
     * @return DiotSystemMarkTestResponse
     */
    public DiotSystemMarkTestResponse diotSystemMarkTest() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.diotSystemMarkTestWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>钉钉物联市场管理</p>
     * 
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return DiotMarketManagerResponse
     */
    public DiotMarketManagerResponse diot_Market_ManagerWithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "Diot_Market_Manager"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/market/manager"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.doROARequestWithForm(params.action, params.version, params.protocol, params.method, params.authType, params.pathname, params.bodyType, req, runtime), new DiotMarketManagerResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>钉钉物联市场管理</p>
     * @return DiotMarketManagerResponse
     */
    public DiotMarketManagerResponse diot_Market_Manager() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.diot_Market_ManagerWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>推送事件</p>
     * 
     * @param request PushEventRequest
     * @param headers PushEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PushEventResponse
     */
    public PushEventResponse pushEventWithOptions(PushEventRequest request, PushEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceId)) {
            body.put("deviceId", request.deviceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.eventId)) {
            body.put("eventId", request.eventId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.eventName)) {
            body.put("eventName", request.eventName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.eventType)) {
            body.put("eventType", request.eventType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extraData)) {
            body.put("extraData", request.extraData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.location)) {
            body.put("location", request.location);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msg)) {
            body.put("msg", request.msg);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.occurrenceTime)) {
            body.put("occurrenceTime", request.occurrenceTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.picUrls)) {
            body.put("picUrls", request.picUrls);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PushEvent"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/events/push"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PushEventResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>推送事件</p>
     * 
     * @param request PushEventRequest
     * @return PushEventResponse
     */
    public PushEventResponse pushEvent(PushEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PushEventHeaders headers = new PushEventHeaders();
        return this.pushEventWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询设备</p>
     * 
     * @param request QueryDeviceRequest
     * @param headers QueryDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDeviceResponse
     */
    public QueryDeviceResponse queryDeviceWithOptions(QueryDeviceRequest request, QueryDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryDevice"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/devices"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询设备</p>
     * 
     * @param request QueryDeviceRequest
     * @return QueryDeviceResponse
     */
    public QueryDeviceResponse queryDevice(QueryDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDeviceHeaders headers = new QueryDeviceHeaders();
        return this.queryDeviceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询硬件设备的PK值信息</p>
     * 
     * @param request QueryDevicePkRequest
     * @param headers QueryDevicePkHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDevicePkResponse
     */
    public QueryDevicePkResponse queryDevicePkWithOptions(QueryDevicePkRequest request, QueryDevicePkHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceId)) {
            body.put("deviceId", request.deviceId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryDevicePk"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/devices/pkInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDevicePkResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询硬件设备的PK值信息</p>
     * 
     * @param request QueryDevicePkRequest
     * @return QueryDevicePkResponse
     */
    public QueryDevicePkResponse queryDevicePk(QueryDevicePkRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDevicePkHeaders headers = new QueryDevicePkHeaders();
        return this.queryDevicePkWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询事件</p>
     * 
     * @param request QueryEventRequest
     * @param headers QueryEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryEventResponse
     */
    public QueryEventResponse queryEventWithOptions(QueryEventRequest request, QueryEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceIdList)) {
            body.put("deviceIdList", request.deviceIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.eventId)) {
            body.put("eventId", request.eventId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.eventStatusList)) {
            body.put("eventStatusList", request.eventStatusList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.eventTypeList)) {
            body.put("eventTypeList", request.eventTypeList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryEvent"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/events/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryEventResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询事件</p>
     * 
     * @param request QueryEventRequest
     * @return QueryEventResponse
     */
    public QueryEventResponse queryEvent(QueryEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryEventHeaders headers = new QueryEventHeaders();
        return this.queryEventWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>注册设备</p>
     * 
     * @param request RegisterDeviceRequest
     * @param headers RegisterDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RegisterDeviceResponse
     */
    public RegisterDeviceResponse registerDeviceWithOptions(RegisterDeviceRequest request, RegisterDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceName)) {
            body.put("deviceName", request.deviceName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceStatus)) {
            body.put("deviceStatus", request.deviceStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceType)) {
            body.put("deviceType", request.deviceType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceTypeName)) {
            body.put("deviceTypeName", request.deviceTypeName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            body.put("id", request.id);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.liveUrls)) {
            body.put("liveUrls", request.liveUrls);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.location)) {
            body.put("location", request.location);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nickName)) {
            body.put("nickName", request.nickName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentId)) {
            body.put("parentId", request.parentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productType)) {
            body.put("productType", request.productType);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RegisterDevice"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/devices/register"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RegisterDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>注册设备</p>
     * 
     * @param request RegisterDeviceRequest
     * @return RegisterDeviceResponse
     */
    public RegisterDeviceResponse registerDevice(RegisterDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RegisterDeviceHeaders headers = new RegisterDeviceHeaders();
        return this.registerDeviceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>升级设备</p>
     * 
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpgradeDeviceResponse
     */
    public UpgradeDeviceResponse upgradeDeviceWithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpgradeDevice"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/upgrade/device"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.doROARequestWithForm(params.action, params.version, params.protocol, params.method, params.authType, params.pathname, params.bodyType, req, runtime), new UpgradeDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>升级设备</p>
     * @return UpgradeDeviceResponse
     */
    public UpgradeDeviceResponse upgradeDevice() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.upgradeDeviceWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取工作台流转物联信息</p>
     * 
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return WorkbenchTransformInfoResponse
     */
    public WorkbenchTransformInfoResponse workbenchTransformInfoWithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "WorkbenchTransformInfo"),
            new TeaPair("version", "diot_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/diot/workbench/transform"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.doROARequestWithForm(params.action, params.version, params.protocol, params.method, params.authType, params.pathname, params.bodyType, req, runtime), new WorkbenchTransformInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取工作台流转物联信息</p>
     * @return WorkbenchTransformInfoResponse
     */
    public WorkbenchTransformInfoResponse workbenchTransformInfo() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.workbenchTransformInfoWithOptions(headers, runtime);
    }
}
