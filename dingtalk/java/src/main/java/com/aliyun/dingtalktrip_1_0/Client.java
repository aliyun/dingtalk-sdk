// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalktrip_1_0.models.*;

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


    public GetTravelProcessDetailResponse getTravelProcessDetailWithOptions(GetTravelProcessDetailRequest request, GetTravelProcessDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.processCorpId)) {
            query.put("processCorpId", request.processCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            query.put("processInstanceId", request.processInstanceId);
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
            new TeaPair("action", "GetTravelProcessDetail"),
            new TeaPair("version", "trip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trip/processes/details"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTravelProcessDetailResponse());
    }

    public GetTravelProcessDetailResponse getTravelProcessDetail(GetTravelProcessDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTravelProcessDetailHeaders headers = new GetTravelProcessDetailHeaders();
        return this.getTravelProcessDetailWithOptions(request, headers, runtime);
    }

    public PreCheckTemplateResponse preCheckTemplateWithOptions(PreCheckTemplateRequest request, PreCheckTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.customerCorpId)) {
            body.put("customerCorpId", request.customerCorpId);
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
            new TeaPair("action", "PreCheckTemplate"),
            new TeaPair("version", "trip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trip/processes/templateUpgrades/preCheck"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PreCheckTemplateResponse());
    }

    public PreCheckTemplateResponse preCheckTemplate(PreCheckTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PreCheckTemplateHeaders headers = new PreCheckTemplateHeaders();
        return this.preCheckTemplateWithOptions(request, headers, runtime);
    }

    public QueryTripProcessTemplatesResponse queryTripProcessTemplatesWithOptions(QueryTripProcessTemplatesRequest request, QueryTripProcessTemplatesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.customerCorpId)) {
            query.put("customerCorpId", request.customerCorpId);
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
            new TeaPair("action", "QueryTripProcessTemplates"),
            new TeaPair("version", "trip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trip/processes/templatesDetails"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryTripProcessTemplatesResponse());
    }

    public QueryTripProcessTemplatesResponse queryTripProcessTemplates(QueryTripProcessTemplatesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryTripProcessTemplatesHeaders headers = new QueryTripProcessTemplatesHeaders();
        return this.queryTripProcessTemplatesWithOptions(request, headers, runtime);
    }

    public SyncBusinessSignInfoResponse syncBusinessSignInfoWithOptions(SyncBusinessSignInfoRequest request, SyncBusinessSignInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizTypeList)) {
            body.put("bizTypeList", request.bizTypeList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtOrgPay)) {
            body.put("gmtOrgPay", request.gmtOrgPay);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtSign)) {
            body.put("gmtSign", request.gmtSign);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgPayStatus)) {
            body.put("orgPayStatus", request.orgPayStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signStatus)) {
            body.put("signStatus", request.signStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tmcProductDetailList)) {
            body.put("tmcProductDetailList", request.tmcProductDetailList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tmcProductList)) {
            body.put("tmcProductList", request.tmcProductList);
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
            new TeaPair("action", "SyncBusinessSignInfo"),
            new TeaPair("version", "trip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trip/businessSignInfos/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncBusinessSignInfoResponse());
    }

    public SyncBusinessSignInfoResponse syncBusinessSignInfo(SyncBusinessSignInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncBusinessSignInfoHeaders headers = new SyncBusinessSignInfoHeaders();
        return this.syncBusinessSignInfoWithOptions(request, headers, runtime);
    }

    public SyncCostCenterResponse syncCostCenterWithOptions(SyncCostCenterRequest request, SyncCostCenterHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channelCorpId)) {
            body.put("channelCorpId", request.channelCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.costCenterId)) {
            body.put("costCenterId", request.costCenterId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deleteFlag)) {
            body.put("deleteFlag", request.deleteFlag);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtAction)) {
            body.put("gmtAction", request.gmtAction);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.number)) {
            body.put("number", request.number);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scope)) {
            body.put("scope", request.scope);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thirdPartId)) {
            body.put("thirdPartId", request.thirdPartId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "SyncCostCenter"),
            new TeaPair("version", "trip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trip/processes/costCenters/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncCostCenterResponse());
    }

    public SyncCostCenterResponse syncCostCenter(SyncCostCenterRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncCostCenterHeaders headers = new SyncCostCenterHeaders();
        return this.syncCostCenterWithOptions(request, headers, runtime);
    }

    public SyncCostCenterEntityResponse syncCostCenterEntityWithOptions(SyncCostCenterEntityRequest request, SyncCostCenterEntityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channelCorpId)) {
            body.put("channelCorpId", request.channelCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.costCenterId)) {
            body.put("costCenterId", request.costCenterId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.delAll)) {
            body.put("delAll", request.delAll);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.entityList)) {
            body.put("entityList", request.entityList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "SyncCostCenterEntity"),
            new TeaPair("version", "trip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trip/processes/costCenters/applicableScopes/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncCostCenterEntityResponse());
    }

    public SyncCostCenterEntityResponse syncCostCenterEntity(SyncCostCenterEntityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncCostCenterEntityHeaders headers = new SyncCostCenterEntityHeaders();
        return this.syncCostCenterEntityWithOptions(request, headers, runtime);
    }

    public SyncInvoiceResponse syncInvoiceWithOptions(SyncInvoiceRequest request, SyncInvoiceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.address)) {
            body.put("address", request.address);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bankName)) {
            body.put("bankName", request.bankName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bankNo)) {
            body.put("bankNo", request.bankNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.channelCorpId)) {
            body.put("channelCorpId", request.channelCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deleteFlag)) {
            body.put("deleteFlag", request.deleteFlag);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtAction)) {
            body.put("gmtAction", request.gmtAction);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceId)) {
            body.put("invoiceId", request.invoiceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectIds)) {
            body.put("projectIds", request.projectIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scope)) {
            body.put("scope", request.scope);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taxNo)) {
            body.put("taxNo", request.taxNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tel)) {
            body.put("tel", request.tel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thirdPartId)) {
            body.put("thirdPartId", request.thirdPartId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unitType)) {
            body.put("unitType", request.unitType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "SyncInvoice"),
            new TeaPair("version", "trip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trip/processes/invoiceTitles/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncInvoiceResponse());
    }

    public SyncInvoiceResponse syncInvoice(SyncInvoiceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncInvoiceHeaders headers = new SyncInvoiceHeaders();
        return this.syncInvoiceWithOptions(request, headers, runtime);
    }

    public SyncInvoiceEntityResponse syncInvoiceEntityWithOptions(SyncInvoiceEntityRequest request, SyncInvoiceEntityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channelCorpId)) {
            body.put("channelCorpId", request.channelCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.delAll)) {
            body.put("delAll", request.delAll);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.entityList)) {
            body.put("entityList", request.entityList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceId)) {
            body.put("invoiceId", request.invoiceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "SyncInvoiceEntity"),
            new TeaPair("version", "trip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trip/processes/invoiceTitles/applicableScopes/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncInvoiceEntityResponse());
    }

    public SyncInvoiceEntityResponse syncInvoiceEntity(SyncInvoiceEntityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncInvoiceEntityHeaders headers = new SyncInvoiceEntityHeaders();
        return this.syncInvoiceEntityWithOptions(request, headers, runtime);
    }

    public SyncProjectResponse syncProjectWithOptions(SyncProjectRequest request, SyncProjectHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channelCorpId)) {
            body.put("channelCorpId", request.channelCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.costCenterId)) {
            body.put("costCenterId", request.costCenterId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deleteFlag)) {
            body.put("deleteFlag", request.deleteFlag);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtAction)) {
            body.put("gmtAction", request.gmtAction);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceId)) {
            body.put("invoiceId", request.invoiceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerIds)) {
            body.put("managerIds", request.managerIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectId)) {
            body.put("projectId", request.projectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectName)) {
            body.put("projectName", request.projectName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scope)) {
            body.put("scope", request.scope);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thirdPartId)) {
            body.put("thirdPartId", request.thirdPartId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "SyncProject"),
            new TeaPair("version", "trip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trip/processes/projects/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncProjectResponse());
    }

    public SyncProjectResponse syncProject(SyncProjectRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncProjectHeaders headers = new SyncProjectHeaders();
        return this.syncProjectWithOptions(request, headers, runtime);
    }

    public SyncProjectEntityResponse syncProjectEntityWithOptions(SyncProjectEntityRequest request, SyncProjectEntityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channelCorpId)) {
            body.put("channelCorpId", request.channelCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.delAll)) {
            body.put("delAll", request.delAll);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.entityList)) {
            body.put("entityList", request.entityList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectId)) {
            body.put("projectId", request.projectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "SyncProjectEntity"),
            new TeaPair("version", "trip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trip/processes/projects/applicableScopes/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncProjectEntityResponse());
    }

    public SyncProjectEntityResponse syncProjectEntity(SyncProjectEntityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncProjectEntityHeaders headers = new SyncProjectEntityHeaders();
        return this.syncProjectEntityWithOptions(request, headers, runtime);
    }

    public SyncSecretKeyResponse syncSecretKeyWithOptions(SyncSecretKeyRequest request, SyncSecretKeyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionType)) {
            body.put("actionType", request.actionType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.secretString)) {
            body.put("secretString", request.secretString);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tripAppKey)) {
            body.put("tripAppKey", request.tripAppKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tripAppSecurity)) {
            body.put("tripAppSecurity", request.tripAppSecurity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tripCorpId)) {
            body.put("tripCorpId", request.tripCorpId);
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
            new TeaPair("action", "SyncSecretKey"),
            new TeaPair("version", "trip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trip/secretKeys/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncSecretKeyResponse());
    }

    public SyncSecretKeyResponse syncSecretKey(SyncSecretKeyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncSecretKeyHeaders headers = new SyncSecretKeyHeaders();
        return this.syncSecretKeyWithOptions(request, headers, runtime);
    }

    public SyncTripOrderResponse syncTripOrderWithOptions(SyncTripOrderRequest request, SyncTripOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizExtension)) {
            body.put("bizExtension", request.bizExtension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.channelType)) {
            body.put("channelType", request.channelType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.currency)) {
            body.put("currency", request.currency);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingUserId)) {
            body.put("dingUserId", request.dingUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.discountAmount)) {
            body.put("discountAmount", request.discountAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endorseFlag)) {
            body.put("endorseFlag", request.endorseFlag);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.event)) {
            body.put("event", request.event);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtOrder)) {
            body.put("gmtOrder", request.gmtOrder);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtPay)) {
            body.put("gmtPay", request.gmtPay);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtRefund)) {
            body.put("gmtRefund", request.gmtRefund);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceApplyUrl)) {
            body.put("invoiceApplyUrl", request.invoiceApplyUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.journeyBizNo)) {
            body.put("journeyBizNo", request.journeyBizNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderDetails)) {
            body.put("orderDetails", request.orderDetails);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            body.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderUrl)) {
            body.put("orderUrl", request.orderUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processId)) {
            body.put("processId", request.processId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.realAmount)) {
            body.put("realAmount", request.realAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.refundAmount)) {
            body.put("refundAmount", request.refundAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relativeOrderNo)) {
            body.put("relativeOrderNo", request.relativeOrderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.supplyLogo)) {
            body.put("supplyLogo", request.supplyLogo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.supplyName)) {
            body.put("supplyName", request.supplyName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tmcCorpId)) {
            body.put("tmcCorpId", request.tmcCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.totalAmount)) {
            body.put("totalAmount", request.totalAmount);
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
            new TeaPair("action", "SyncTripOrder"),
            new TeaPair("version", "trip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trip/tripOrders/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncTripOrderResponse());
    }

    public SyncTripOrderResponse syncTripOrder(SyncTripOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncTripOrderHeaders headers = new SyncTripOrderHeaders();
        return this.syncTripOrderWithOptions(request, headers, runtime);
    }

    public SyncTripProductConfigResponse syncTripProductConfigWithOptions(SyncTripProductConfigRequest request, SyncTripProductConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tripProductConfigList)) {
            body.put("tripProductConfigList", request.tripProductConfigList);
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
            new TeaPair("action", "SyncTripProductConfig"),
            new TeaPair("version", "trip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trip/productConfigs/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncTripProductConfigResponse());
    }

    public SyncTripProductConfigResponse syncTripProductConfig(SyncTripProductConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncTripProductConfigHeaders headers = new SyncTripProductConfigHeaders();
        return this.syncTripProductConfigWithOptions(request, headers, runtime);
    }

    public UpgradeTemplateResponse upgradeTemplateWithOptions(UpgradeTemplateRequest request, UpgradeTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channelCorpId)) {
            body.put("channelCorpId", request.channelCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.forceUpgrade)) {
            body.put("forceUpgrade", request.forceUpgrade);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tmcCorpId)) {
            body.put("tmcCorpId", request.tmcCorpId);
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
            new TeaPair("action", "UpgradeTemplate"),
            new TeaPair("version", "trip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trip/process/templates/upgrade"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpgradeTemplateResponse());
    }

    public UpgradeTemplateResponse upgradeTemplate(UpgradeTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpgradeTemplateHeaders headers = new UpgradeTemplateHeaders();
        return this.upgradeTemplateWithOptions(request, headers, runtime);
    }
}
