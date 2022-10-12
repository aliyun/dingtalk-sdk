// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcard_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public AppendSpaceResponse appendSpace(AppendSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AppendSpaceHeaders headers = new AppendSpaceHeaders();
        return this.appendSpaceWithOptions(request, headers, runtime);
    }

    public AppendSpaceResponse appendSpaceWithOptions(AppendSpaceRequest request, AppendSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.coFeedOpenSpaceModel))) {
            body.put("coFeedOpenSpaceModel", request.coFeedOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.imGroupOpenSpaceModel))) {
            body.put("imGroupOpenSpaceModel", request.imGroupOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.imSingleOpenSpaceModel))) {
            body.put("imSingleOpenSpaceModel", request.imSingleOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.topOpenSpaceModel))) {
            body.put("topOpenSpaceModel", request.topOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.workBenchOpenSpaceModel))) {
            body.put("workBenchOpenSpaceModel", request.workBenchOpenSpaceModel);
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
        return TeaModel.toModel(this.doROARequest("AppendSpace", "card_1.0", "HTTP", "PUT", "AK", "/v1.0/card/instances/spaces", "json", req, runtime), new AppendSpaceResponse());
    }

    public CreateAndDeliverResponse createAndDeliver(CreateAndDeliverRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateAndDeliverHeaders headers = new CreateAndDeliverHeaders();
        return this.createAndDeliverWithOptions(request, headers, runtime);
    }

    public CreateAndDeliverResponse createAndDeliverWithOptions(CreateAndDeliverRequest request, CreateAndDeliverHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.callbackRouteKey)) {
            body.put("callbackRouteKey", request.callbackRouteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.cardData))) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardTemplateId)) {
            body.put("cardTemplateId", request.cardTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.coFeedOpenDeliverModel))) {
            body.put("coFeedOpenDeliverModel", request.coFeedOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.coFeedOpenSpaceModel))) {
            body.put("coFeedOpenSpaceModel", request.coFeedOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.imGroupOpenDeliverModel))) {
            body.put("imGroupOpenDeliverModel", request.imGroupOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.imGroupOpenSpaceModel))) {
            body.put("imGroupOpenSpaceModel", request.imGroupOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.imSingleOpenDeliverModel))) {
            body.put("imSingleOpenDeliverModel", request.imSingleOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.imSingleOpenSpaceModel))) {
            body.put("imSingleOpenSpaceModel", request.imSingleOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.openDynamicDataConfig))) {
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

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.topOpenDeliverModel))) {
            body.put("topOpenDeliverModel", request.topOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.topOpenSpaceModel))) {
            body.put("topOpenSpaceModel", request.topOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.workBenchOpenDeliverModel))) {
            body.put("workBenchOpenDeliverModel", request.workBenchOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.workBenchOpenSpaceModel))) {
            body.put("workBenchOpenSpaceModel", request.workBenchOpenSpaceModel);
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
        return TeaModel.toModel(this.doROARequest("CreateAndDeliver", "card_1.0", "HTTP", "POST", "AK", "/v1.0/card/instances/createAndDeliver", "json", req, runtime), new CreateAndDeliverResponse());
    }

    public CreateCardResponse createCard(CreateCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateCardHeaders headers = new CreateCardHeaders();
        return this.createCardWithOptions(request, headers, runtime);
    }

    public CreateCardResponse createCardWithOptions(CreateCardRequest request, CreateCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.callbackRouteKey)) {
            body.put("callbackRouteKey", request.callbackRouteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.cardData))) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardTemplateId)) {
            body.put("cardTemplateId", request.cardTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.coFeedOpenSpaceModel))) {
            body.put("coFeedOpenSpaceModel", request.coFeedOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.imGroupOpenSpaceModel))) {
            body.put("imGroupOpenSpaceModel", request.imGroupOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.imSingleOpenSpaceModel))) {
            body.put("imSingleOpenSpaceModel", request.imSingleOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.openDynamicDataConfig))) {
            body.put("openDynamicDataConfig", request.openDynamicDataConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.privateData)) {
            body.put("privateData", request.privateData);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.topOpenSpaceModel))) {
            body.put("topOpenSpaceModel", request.topOpenSpaceModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.workBenchOpenSpaceModel))) {
            body.put("workBenchOpenSpaceModel", request.workBenchOpenSpaceModel);
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
        return TeaModel.toModel(this.doROARequest("CreateCard", "card_1.0", "HTTP", "POST", "AK", "/v1.0/card/instances", "json", req, runtime), new CreateCardResponse());
    }

    public DeliverCardResponse deliverCard(DeliverCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeliverCardHeaders headers = new DeliverCardHeaders();
        return this.deliverCardWithOptions(request, headers, runtime);
    }

    public DeliverCardResponse deliverCardWithOptions(DeliverCardRequest request, DeliverCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.coFeedOpenDeliverModel))) {
            body.put("coFeedOpenDeliverModel", request.coFeedOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.imGroupOpenDeliverModel))) {
            body.put("imGroupOpenDeliverModel", request.imGroupOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.imSingleOpenDeliverModel))) {
            body.put("imSingleOpenDeliverModel", request.imSingleOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openSpaceId)) {
            body.put("openSpaceId", request.openSpaceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.topOpenDeliverModel))) {
            body.put("topOpenDeliverModel", request.topOpenDeliverModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.workBenchOpenDeliverModel))) {
            body.put("workBenchOpenDeliverModel", request.workBenchOpenDeliverModel);
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
        return TeaModel.toModel(this.doROARequest("DeliverCard", "card_1.0", "HTTP", "POST", "AK", "/v1.0/card/instances/deliver", "json", req, runtime), new DeliverCardResponse());
    }

    public RegisterCallbackResponse registerCallback(RegisterCallbackRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RegisterCallbackHeaders headers = new RegisterCallbackHeaders();
        return this.registerCallbackWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("RegisterCallback", "card_1.0", "HTTP", "POST", "AK", "/v1.0/card/callbacks/register", "json", req, runtime), new RegisterCallbackResponse());
    }

    public UpdateCardResponse updateCard(UpdateCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCardHeaders headers = new UpdateCardHeaders();
        return this.updateCardWithOptions(request, headers, runtime);
    }

    public UpdateCardResponse updateCardWithOptions(UpdateCardRequest request, UpdateCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.cardData))) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.cardUpdateOptions))) {
            body.put("cardUpdateOptions", request.cardUpdateOptions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.privateData)) {
            body.put("privateData", request.privateData);
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
        return TeaModel.toModel(this.doROARequest("UpdateCard", "card_1.0", "HTTP", "PUT", "AK", "/v1.0/card/instances", "json", req, runtime), new UpdateCardResponse());
    }
}
