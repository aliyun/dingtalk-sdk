// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcard_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public com.aliyun.gateway.spi.Client _client;
    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._client = new com.aliyun.gateway.dingtalk.Client();
        this._spi = _client;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


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

    public AppendSpaceResponse appendSpace(AppendSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AppendSpaceHeaders headers = new AppendSpaceHeaders();
        return this.appendSpaceWithOptions(request, headers, runtime);
    }

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

    public CreateAndDeliverResponse createAndDeliver(CreateAndDeliverRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateAndDeliverHeaders headers = new CreateAndDeliverHeaders();
        return this.createAndDeliverWithOptions(request, headers, runtime);
    }

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

    public CreateCardResponse createCard(CreateCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateCardHeaders headers = new CreateCardHeaders();
        return this.createCardWithOptions(request, headers, runtime);
    }

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

    public DeliverCardResponse deliverCard(DeliverCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeliverCardHeaders headers = new DeliverCardHeaders();
        return this.deliverCardWithOptions(request, headers, runtime);
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

    public RegisterCallbackResponse registerCallback(RegisterCallbackRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RegisterCallbackHeaders headers = new RegisterCallbackHeaders();
        return this.registerCallbackWithOptions(request, headers, runtime);
    }

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

    public StreamingUpdateResponse streamingUpdate(StreamingUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StreamingUpdateHeaders headers = new StreamingUpdateHeaders();
        return this.streamingUpdateWithOptions(request, headers, runtime);
    }

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

    public UpdateCardResponse updateCard(UpdateCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCardHeaders headers = new UpdateCardHeaders();
        return this.updateCardWithOptions(request, headers, runtime);
    }
}
