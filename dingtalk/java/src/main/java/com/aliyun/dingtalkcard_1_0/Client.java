// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcard_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>新增或更新卡片的场域信息</p>
     * 
     * @param request AppendSpaceRequest
     * @param headers AppendSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AppendSpaceResponse
     */
    public AppendSpaceResponse appendSpaceWithOptions(AppendSpaceRequest request, AppendSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coFeedOpenSpaceModel)) {
            body.put("coFeedOpenSpaceModel", request.coFeedOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imGroupOpenSpaceModel)) {
            body.put("imGroupOpenSpaceModel", request.imGroupOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imRobotOpenSpaceModel)) {
            body.put("imRobotOpenSpaceModel", request.imRobotOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.topOpenSpaceModel)) {
            body.put("topOpenSpaceModel", request.topOpenSpaceModel);
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
            new TeaPair("action", "AppendSpace"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/instances/spaces"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AppendSpaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增或更新卡片的场域信息</p>
     * 
     * @param request AppendSpaceRequest
     * @return AppendSpaceResponse
     */
    public AppendSpaceResponse appendSpace(AppendSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AppendSpaceHeaders headers = new AppendSpaceHeaders();
        return this.appendSpaceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>新增或更新卡片的场域信息</p>
     * 
     * @param request AppendSpaceWithDelegateRequest
     * @param headers AppendSpaceWithDelegateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AppendSpaceWithDelegateResponse
     */
    public AppendSpaceWithDelegateResponse appendSpaceWithDelegateWithOptions(AppendSpaceWithDelegateRequest request, AppendSpaceWithDelegateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coFeedOpenSpaceModel)) {
            body.put("coFeedOpenSpaceModel", request.coFeedOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imGroupOpenSpaceModel)) {
            body.put("imGroupOpenSpaceModel", request.imGroupOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imRobotOpenSpaceModel)) {
            body.put("imRobotOpenSpaceModel", request.imRobotOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.topOpenSpaceModel)) {
            body.put("topOpenSpaceModel", request.topOpenSpaceModel);
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
            new TeaPair("action", "AppendSpaceWithDelegate"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/me/instances/spaces"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AppendSpaceWithDelegateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增或更新卡片的场域信息</p>
     * 
     * @param request AppendSpaceWithDelegateRequest
     * @return AppendSpaceWithDelegateResponse
     */
    public AppendSpaceWithDelegateResponse appendSpaceWithDelegate(AppendSpaceWithDelegateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AppendSpaceWithDelegateHeaders headers = new AppendSpaceWithDelegateHeaders();
        return this.appendSpaceWithDelegateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>复制模板</p>
     * 
     * @param request CopyTemplateRequest
     * @param headers CopyTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CopyTemplateResponse
     */
    public CopyTemplateResponse copyTemplateWithOptions(CopyTemplateRequest request, CopyTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
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
            new TeaPair("action", "CopyTemplate"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/templates/copy"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CopyTemplateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>复制模板</p>
     * 
     * @param request CopyTemplateRequest
     * @return CopyTemplateResponse
     */
    public CopyTemplateResponse copyTemplate(CopyTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CopyTemplateHeaders headers = new CopyTemplateHeaders();
        return this.copyTemplateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建并投放卡片</p>
     * 
     * @param request CreateAndDeliverRequest
     * @param headers CreateAndDeliverHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateAndDeliverResponse
     */
    public CreateAndDeliverResponse createAndDeliverWithOptions(CreateAndDeliverRequest request, CreateAndDeliverHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.callbackRouteKey)) {
            body.put("callbackRouteKey", request.callbackRouteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callbackType)) {
            body.put("callbackType", request.callbackType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardData)) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardTemplateId)) {
            body.put("cardTemplateId", request.cardTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.coFeedOpenDeliverModel)) {
            body.put("coFeedOpenDeliverModel", request.coFeedOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.coFeedOpenSpaceModel)) {
            body.put("coFeedOpenSpaceModel", request.coFeedOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.docOpenDeliverModel)) {
            body.put("docOpenDeliverModel", request.docOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imGroupOpenDeliverModel)) {
            body.put("imGroupOpenDeliverModel", request.imGroupOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imGroupOpenSpaceModel)) {
            body.put("imGroupOpenSpaceModel", request.imGroupOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imRobotOpenDeliverModel)) {
            body.put("imRobotOpenDeliverModel", request.imRobotOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imRobotOpenSpaceModel)) {
            body.put("imRobotOpenSpaceModel", request.imRobotOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imSingleOpenDeliverModel)) {
            body.put("imSingleOpenDeliverModel", request.imSingleOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imSingleOpenSpaceModel)) {
            body.put("imSingleOpenSpaceModel", request.imSingleOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openDynamicDataConfig)) {
            body.put("openDynamicDataConfig", request.openDynamicDataConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openSpaceId)) {
            body.put("openSpaceId", request.openSpaceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.privateData)) {
            body.put("privateData", request.privateData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.topOpenDeliverModel)) {
            body.put("topOpenDeliverModel", request.topOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.topOpenSpaceModel)) {
            body.put("topOpenSpaceModel", request.topOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdType)) {
            body.put("userIdType", request.userIdType);
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
            new TeaPair("action", "CreateAndDeliver"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/instances/createAndDeliver"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateAndDeliverResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建并投放卡片</p>
     * 
     * @param request CreateAndDeliverRequest
     * @return CreateAndDeliverResponse
     */
    public CreateAndDeliverResponse createAndDeliver(CreateAndDeliverRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateAndDeliverHeaders headers = new CreateAndDeliverHeaders();
        return this.createAndDeliverWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建并投放卡片</p>
     * 
     * @param request CreateAndDeliverWithDelegateRequest
     * @param headers CreateAndDeliverWithDelegateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateAndDeliverWithDelegateResponse
     */
    public CreateAndDeliverWithDelegateResponse createAndDeliverWithDelegateWithOptions(CreateAndDeliverWithDelegateRequest request, CreateAndDeliverWithDelegateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.callbackRouteKey)) {
            body.put("callbackRouteKey", request.callbackRouteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callbackType)) {
            body.put("callbackType", request.callbackType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardData)) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardTemplateId)) {
            body.put("cardTemplateId", request.cardTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.coFeedOpenDeliverModel)) {
            body.put("coFeedOpenDeliverModel", request.coFeedOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.coFeedOpenSpaceModel)) {
            body.put("coFeedOpenSpaceModel", request.coFeedOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.docOpenDeliverModel)) {
            body.put("docOpenDeliverModel", request.docOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imGroupOpenDeliverModel)) {
            body.put("imGroupOpenDeliverModel", request.imGroupOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imGroupOpenSpaceModel)) {
            body.put("imGroupOpenSpaceModel", request.imGroupOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imRobotOpenDeliverModel)) {
            body.put("imRobotOpenDeliverModel", request.imRobotOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imRobotOpenSpaceModel)) {
            body.put("imRobotOpenSpaceModel", request.imRobotOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imSingleOpenDeliverModel)) {
            body.put("imSingleOpenDeliverModel", request.imSingleOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imSingleOpenSpaceModel)) {
            body.put("imSingleOpenSpaceModel", request.imSingleOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openDynamicDataConfig)) {
            body.put("openDynamicDataConfig", request.openDynamicDataConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openSpaceId)) {
            body.put("openSpaceId", request.openSpaceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.privateData)) {
            body.put("privateData", request.privateData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.topOpenDeliverModel)) {
            body.put("topOpenDeliverModel", request.topOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.topOpenSpaceModel)) {
            body.put("topOpenSpaceModel", request.topOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdType)) {
            body.put("userIdType", request.userIdType);
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
            new TeaPair("action", "CreateAndDeliverWithDelegate"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/me/instances/createAndDeliver"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateAndDeliverWithDelegateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建并投放卡片</p>
     * 
     * @param request CreateAndDeliverWithDelegateRequest
     * @return CreateAndDeliverWithDelegateResponse
     */
    public CreateAndDeliverWithDelegateResponse createAndDeliverWithDelegate(CreateAndDeliverWithDelegateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateAndDeliverWithDelegateHeaders headers = new CreateAndDeliverWithDelegateHeaders();
        return this.createAndDeliverWithDelegateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建卡片</p>
     * 
     * @param request CreateCardRequest
     * @param headers CreateCardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateCardResponse
     */
    public CreateCardResponse createCardWithOptions(CreateCardRequest request, CreateCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.callbackRouteKey)) {
            body.put("callbackRouteKey", request.callbackRouteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callbackType)) {
            body.put("callbackType", request.callbackType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardData)) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardTemplateId)) {
            body.put("cardTemplateId", request.cardTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.coFeedOpenSpaceModel)) {
            body.put("coFeedOpenSpaceModel", request.coFeedOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imGroupOpenSpaceModel)) {
            body.put("imGroupOpenSpaceModel", request.imGroupOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imRobotOpenSpaceModel)) {
            body.put("imRobotOpenSpaceModel", request.imRobotOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imSingleOpenSpaceModel)) {
            body.put("imSingleOpenSpaceModel", request.imSingleOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openDynamicDataConfig)) {
            body.put("openDynamicDataConfig", request.openDynamicDataConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.privateData)) {
            body.put("privateData", request.privateData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.topOpenSpaceModel)) {
            body.put("topOpenSpaceModel", request.topOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdType)) {
            body.put("userIdType", request.userIdType);
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
            new TeaPair("action", "CreateCard"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/instances"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateCardResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建卡片</p>
     * 
     * @param request CreateCardRequest
     * @return CreateCardResponse
     */
    public CreateCardResponse createCard(CreateCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateCardHeaders headers = new CreateCardHeaders();
        return this.createCardWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建卡片</p>
     * 
     * @param request CreateCardWithDelegateRequest
     * @param headers CreateCardWithDelegateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateCardWithDelegateResponse
     */
    public CreateCardWithDelegateResponse createCardWithDelegateWithOptions(CreateCardWithDelegateRequest request, CreateCardWithDelegateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.callbackRouteKey)) {
            body.put("callbackRouteKey", request.callbackRouteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callbackType)) {
            body.put("callbackType", request.callbackType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardData)) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardTemplateId)) {
            body.put("cardTemplateId", request.cardTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.coFeedOpenSpaceModel)) {
            body.put("coFeedOpenSpaceModel", request.coFeedOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imGroupOpenSpaceModel)) {
            body.put("imGroupOpenSpaceModel", request.imGroupOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imRobotOpenSpaceModel)) {
            body.put("imRobotOpenSpaceModel", request.imRobotOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imSingleOpenSpaceModel)) {
            body.put("imSingleOpenSpaceModel", request.imSingleOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openDynamicDataConfig)) {
            body.put("openDynamicDataConfig", request.openDynamicDataConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.privateData)) {
            body.put("privateData", request.privateData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.topOpenSpaceModel)) {
            body.put("topOpenSpaceModel", request.topOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdType)) {
            body.put("userIdType", request.userIdType);
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
            new TeaPair("action", "CreateCardWithDelegate"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/me/instances"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateCardWithDelegateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建卡片</p>
     * 
     * @param request CreateCardWithDelegateRequest
     * @return CreateCardWithDelegateResponse
     */
    public CreateCardWithDelegateResponse createCardWithDelegate(CreateCardWithDelegateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateCardWithDelegateHeaders headers = new CreateCardWithDelegateHeaders();
        return this.createCardWithDelegateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建模板</p>
     * 
     * @param request CreateTemplateRequest
     * @param headers CreateTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTemplateResponse
     */
    public CreateTemplateResponse createTemplateWithOptions(CreateTemplateRequest request, CreateTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.creatorId)) {
            body.put("creatorId", request.creatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extendType)) {
            body.put("extendType", request.extendType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
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
            new TeaPair("action", "CreateTemplate"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/templates"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTemplateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建模板</p>
     * 
     * @param request CreateTemplateRequest
     * @return CreateTemplateResponse
     */
    public CreateTemplateResponse createTemplate(CreateTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTemplateHeaders headers = new CreateTemplateHeaders();
        return this.createTemplateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除模板</p>
     * 
     * @param request DeleteTemplateRequest
     * @param headers DeleteTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteTemplateResponse
     */
    public DeleteTemplateResponse deleteTemplateWithOptions(DeleteTemplateRequest request, DeleteTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
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
            new TeaPair("action", "DeleteTemplate"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/templates/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteTemplateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除模板</p>
     * 
     * @param request DeleteTemplateRequest
     * @return DeleteTemplateResponse
     */
    public DeleteTemplateResponse deleteTemplate(DeleteTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteTemplateHeaders headers = new DeleteTemplateHeaders();
        return this.deleteTemplateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>投放卡片</p>
     * 
     * @param request DeliverCardRequest
     * @param headers DeliverCardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeliverCardResponse
     */
    public DeliverCardResponse deliverCardWithOptions(DeliverCardRequest request, DeliverCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coFeedOpenDeliverModel)) {
            body.put("coFeedOpenDeliverModel", request.coFeedOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.docOpenDeliverModel)) {
            body.put("docOpenDeliverModel", request.docOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imGroupOpenDeliverModel)) {
            body.put("imGroupOpenDeliverModel", request.imGroupOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imRobotOpenDeliverModel)) {
            body.put("imRobotOpenDeliverModel", request.imRobotOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imSingleOpenDeliverModel)) {
            body.put("imSingleOpenDeliverModel", request.imSingleOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openSpaceId)) {
            body.put("openSpaceId", request.openSpaceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.topOpenDeliverModel)) {
            body.put("topOpenDeliverModel", request.topOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdType)) {
            body.put("userIdType", request.userIdType);
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
            new TeaPair("action", "DeliverCard"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/instances/deliver"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeliverCardResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>投放卡片</p>
     * 
     * @param request DeliverCardRequest
     * @return DeliverCardResponse
     */
    public DeliverCardResponse deliverCard(DeliverCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeliverCardHeaders headers = new DeliverCardHeaders();
        return this.deliverCardWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>投放卡片</p>
     * 
     * @param request DeliverCardWithDelegateRequest
     * @param headers DeliverCardWithDelegateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeliverCardWithDelegateResponse
     */
    public DeliverCardWithDelegateResponse deliverCardWithDelegateWithOptions(DeliverCardWithDelegateRequest request, DeliverCardWithDelegateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coFeedOpenDeliverModel)) {
            body.put("coFeedOpenDeliverModel", request.coFeedOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.docOpenDeliverModel)) {
            body.put("docOpenDeliverModel", request.docOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imGroupOpenDeliverModel)) {
            body.put("imGroupOpenDeliverModel", request.imGroupOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imRobotOpenDeliverModel)) {
            body.put("imRobotOpenDeliverModel", request.imRobotOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imSingleOpenDeliverModel)) {
            body.put("imSingleOpenDeliverModel", request.imSingleOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openSpaceId)) {
            body.put("openSpaceId", request.openSpaceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.topOpenDeliverModel)) {
            body.put("topOpenDeliverModel", request.topOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdType)) {
            body.put("userIdType", request.userIdType);
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
            new TeaPair("action", "DeliverCardWithDelegate"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/me/instances/deliver"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeliverCardWithDelegateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>投放卡片</p>
     * 
     * @param request DeliverCardWithDelegateRequest
     * @return DeliverCardWithDelegateResponse
     */
    public DeliverCardWithDelegateResponse deliverCardWithDelegate(DeliverCardWithDelegateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeliverCardWithDelegateHeaders headers = new DeliverCardWithDelegateHeaders();
        return this.deliverCardWithDelegateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取模板信息</p>
     * 
     * @param request GetTemplateRequest
     * @param headers GetTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTemplateResponse
     */
    public GetTemplateResponse getTemplateWithOptions(GetTemplateRequest request, GetTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            query.put("templateId", request.templateId);
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
            new TeaPair("action", "GetTemplate"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/templates"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTemplateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取模板信息</p>
     * 
     * @param request GetTemplateRequest
     * @return GetTemplateResponse
     */
    public GetTemplateResponse getTemplate(GetTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTemplateHeaders headers = new GetTemplateHeaders();
        return this.getTemplateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发布模板</p>
     * 
     * @param request PublishTemplateRequest
     * @param headers PublishTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PublishTemplateResponse
     */
    public PublishTemplateResponse publishTemplateWithOptions(PublishTemplateRequest request, PublishTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateSource)) {
            body.put("templateSource", request.templateSource);
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
            new TeaPair("action", "PublishTemplate"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/templates/publish"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PublishTemplateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发布模板</p>
     * 
     * @param request PublishTemplateRequest
     * @return PublishTemplateResponse
     */
    public PublishTemplateResponse publishTemplate(PublishTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PublishTemplateHeaders headers = new PublishTemplateHeaders();
        return this.publishTemplateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>注册卡片回调地址</p>
     * 
     * @param request RegisterCallbackRequest
     * @param headers RegisterCallbackHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RegisterCallbackResponse
     */
    public RegisterCallbackResponse registerCallbackWithOptions(RegisterCallbackRequest request, RegisterCallbackHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.apiSecret)) {
            body.put("apiSecret", request.apiSecret);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callbackRouteKey)) {
            body.put("callbackRouteKey", request.callbackRouteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callbackUrl)) {
            body.put("callbackUrl", request.callbackUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.forceUpdate)) {
            body.put("forceUpdate", request.forceUpdate);
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
            new TeaPair("action", "RegisterCallback"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/callbacks/register"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RegisterCallbackResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>注册卡片回调地址</p>
     * 
     * @param request RegisterCallbackRequest
     * @return RegisterCallbackResponse
     */
    public RegisterCallbackResponse registerCallback(RegisterCallbackRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RegisterCallbackHeaders headers = new RegisterCallbackHeaders();
        return this.registerCallbackWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>注册卡片回调地址</p>
     * 
     * @param request RegisterCallbackWithDelegateRequest
     * @param headers RegisterCallbackWithDelegateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RegisterCallbackWithDelegateResponse
     */
    public RegisterCallbackWithDelegateResponse registerCallbackWithDelegateWithOptions(RegisterCallbackWithDelegateRequest request, RegisterCallbackWithDelegateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.apiSecret)) {
            body.put("apiSecret", request.apiSecret);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callbackRouteKey)) {
            body.put("callbackRouteKey", request.callbackRouteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callbackUrl)) {
            body.put("callbackUrl", request.callbackUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.forceUpdate)) {
            body.put("forceUpdate", request.forceUpdate);
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
            new TeaPair("action", "RegisterCallbackWithDelegate"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/me/callbacks/register"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RegisterCallbackWithDelegateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>注册卡片回调地址</p>
     * 
     * @param request RegisterCallbackWithDelegateRequest
     * @return RegisterCallbackWithDelegateResponse
     */
    public RegisterCallbackWithDelegateResponse registerCallbackWithDelegate(RegisterCallbackWithDelegateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RegisterCallbackWithDelegateHeaders headers = new RegisterCallbackWithDelegateHeaders();
        return this.registerCallbackWithDelegateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>保存模板</p>
     * 
     * @param request SaveTemplateRequest
     * @param headers SaveTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveTemplateResponse
     */
    public SaveTemplateResponse saveTemplateWithOptions(SaveTemplateRequest request, SaveTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateSource)) {
            body.put("templateSource", request.templateSource);
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
            new TeaPair("action", "SaveTemplate"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/templates/save"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveTemplateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>保存模板</p>
     * 
     * @param request SaveTemplateRequest
     * @return SaveTemplateResponse
     */
    public SaveTemplateResponse saveTemplate(SaveTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveTemplateHeaders headers = new SaveTemplateHeaders();
        return this.saveTemplateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>AI互动卡片流式更新</p>
     * 
     * @param request StreamingUpdateRequest
     * @param headers StreamingUpdateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return StreamingUpdateResponse
     */
    public StreamingUpdateResponse streamingUpdateWithOptions(StreamingUpdateRequest request, StreamingUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.guid)) {
            body.put("guid", request.guid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isError)) {
            body.put("isError", request.isError);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isFinalize)) {
            body.put("isFinalize", request.isFinalize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isFull)) {
            body.put("isFull", request.isFull);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.key)) {
            body.put("key", request.key);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
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
            new TeaPair("action", "StreamingUpdate"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/streaming"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new StreamingUpdateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>AI互动卡片流式更新</p>
     * 
     * @param request StreamingUpdateRequest
     * @return StreamingUpdateResponse
     */
    public StreamingUpdateResponse streamingUpdate(StreamingUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StreamingUpdateHeaders headers = new StreamingUpdateHeaders();
        return this.streamingUpdateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新卡片</p>
     * 
     * @param request UpdateCardRequest
     * @param headers UpdateCardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateCardResponse
     */
    public UpdateCardResponse updateCardWithOptions(UpdateCardRequest request, UpdateCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cardData)) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardUpdateOptions)) {
            body.put("cardUpdateOptions", request.cardUpdateOptions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.privateData)) {
            body.put("privateData", request.privateData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdType)) {
            body.put("userIdType", request.userIdType);
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
            new TeaPair("action", "UpdateCard"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/instances"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateCardResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新卡片</p>
     * 
     * @param request UpdateCardRequest
     * @return UpdateCardResponse
     */
    public UpdateCardResponse updateCard(UpdateCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCardHeaders headers = new UpdateCardHeaders();
        return this.updateCardWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新卡片</p>
     * 
     * @param request UpdateCardWithDelegateRequest
     * @param headers UpdateCardWithDelegateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateCardWithDelegateResponse
     */
    public UpdateCardWithDelegateResponse updateCardWithDelegateWithOptions(UpdateCardWithDelegateRequest request, UpdateCardWithDelegateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cardData)) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardUpdateOptions)) {
            body.put("cardUpdateOptions", request.cardUpdateOptions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.privateData)) {
            body.put("privateData", request.privateData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdType)) {
            body.put("userIdType", request.userIdType);
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
            new TeaPair("action", "UpdateCardWithDelegate"),
            new TeaPair("version", "card_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/card/me/instances"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateCardWithDelegateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新卡片</p>
     * 
     * @param request UpdateCardWithDelegateRequest
     * @return UpdateCardWithDelegateResponse
     */
    public UpdateCardWithDelegateResponse updateCardWithDelegate(UpdateCardWithDelegateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCardWithDelegateHeaders headers = new UpdateCardWithDelegateHeaders();
        return this.updateCardWithDelegateWithOptions(request, headers, runtime);
    }
}
