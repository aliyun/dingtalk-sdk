// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkhrm_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public com.aliyun.gateway.spi.Client _client;
    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._client = new com.aliyun.gateway.dingtalk.Client();
        this._spi = _client;
        this._signatureAlgorithm = "v2";
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public AddHrmPreentryResponse addHrmPreentryWithOptions(AddHrmPreentryRequest request, AddHrmPreentryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            body.put("agentId", request.agentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groups)) {
            body.put("groups", request.groups);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.needSendPreEntryMsg)) {
            body.put("needSendPreEntryMsg", request.needSendPreEntryMsg);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.preEntryTime)) {
            body.put("preEntryTime", request.preEntryTime);
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
            new TeaPair("action", "AddHrmPreentry"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/preentries"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddHrmPreentryResponse());
    }

    public AddHrmPreentryResponse addHrmPreentry(AddHrmPreentryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddHrmPreentryHeaders headers = new AddHrmPreentryHeaders();
        return this.addHrmPreentryWithOptions(request, headers, runtime);
    }

    public DeviceMarketManagerResponse deviceMarketManagerWithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeviceMarketManager"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/device/market/manager"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeviceMarketManagerResponse());
    }

    public DeviceMarketManagerResponse deviceMarketManager() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.deviceMarketManagerWithOptions(headers, runtime);
    }

    public DeviceMarketOrderManagerResponse deviceMarketOrderManagerWithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeviceMarketOrderManager"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/device/market/order/manager"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeviceMarketOrderManagerResponse());
    }

    public DeviceMarketOrderManagerResponse deviceMarketOrderManager() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.deviceMarketOrderManagerWithOptions(headers, runtime);
    }

    public ECertQueryResponse eCertQueryWithOptions(ECertQueryRequest request, ECertQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
            new TeaPair("action", "ECertQuery"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/eCerts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ECertQueryResponse());
    }

    public ECertQueryResponse eCertQuery(ECertQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ECertQueryHeaders headers = new ECertQueryHeaders();
        return this.eCertQueryWithOptions(request, headers, runtime);
    }

    public EmployeeAttachmentUpdateResponse employeeAttachmentUpdateWithOptions(EmployeeAttachmentUpdateRequest request, EmployeeAttachmentUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appAgentId)) {
            query.put("appAgentId", request.appAgentId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fieldCode)) {
            body.put("fieldCode", request.fieldCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileSuffix)) {
            body.put("fileSuffix", request.fileSuffix);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "EmployeeAttachmentUpdate"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/employees/attachments"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EmployeeAttachmentUpdateResponse());
    }

    public EmployeeAttachmentUpdateResponse employeeAttachmentUpdate(EmployeeAttachmentUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EmployeeAttachmentUpdateHeaders headers = new EmployeeAttachmentUpdateHeaders();
        return this.employeeAttachmentUpdateWithOptions(request, headers, runtime);
    }

    public EsignRollbackResponse esignRollbackWithOptions(EsignRollbackRequest request, EsignRollbackHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.optUserId)) {
            query.put("optUserId", request.optUserId);
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
            new TeaPair("action", "EsignRollback"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/contracts/esign/rollback"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EsignRollbackResponse());
    }

    public EsignRollbackResponse esignRollback(EsignRollbackRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EsignRollbackHeaders headers = new EsignRollbackHeaders();
        return this.esignRollbackWithOptions(request, headers, runtime);
    }

    public HrmMailSendResponse hrmMailSendWithOptions(HrmMailSendRequest request, HrmMailSendHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mail)) {
            body.put("mail", request.mail);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
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
            new TeaPair("action", "HrmMailSend"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/mails/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmMailSendResponse());
    }

    public HrmMailSendResponse hrmMailSend(HrmMailSendRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmMailSendHeaders headers = new HrmMailSendHeaders();
        return this.hrmMailSendWithOptions(request, headers, runtime);
    }

    public HrmMokaEventResponse hrmMokaEventWithOptions(HrmMokaEventRequest request, HrmMokaEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
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
            new TeaPair("action", "HrmMokaEvent"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/moka/events/forward"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmMokaEventResponse());
    }

    public HrmMokaEventResponse hrmMokaEvent(HrmMokaEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmMokaEventHeaders headers = new HrmMokaEventHeaders();
        return this.hrmMokaEventWithOptions(request, headers, runtime);
    }

    public HrmMokaOapiResponse hrmMokaOapiWithOptions(HrmMokaOapiRequest request, HrmMokaOapiHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.apiCode)) {
            body.put("apiCode", request.apiCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.params)) {
            body.put("params", request.params);
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
            new TeaPair("action", "HrmMokaOapi"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/moka/forward"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmMokaOapiResponse());
    }

    public HrmMokaOapiResponse hrmMokaOapi(HrmMokaOapiRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmMokaOapiHeaders headers = new HrmMokaOapiHeaders();
        return this.hrmMokaOapiWithOptions(request, headers, runtime);
    }

    public HrmProcessRegularResponse hrmProcessRegularWithOptions(HrmProcessRegularRequest request, HrmProcessRegularHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operationId)) {
            body.put("operationId", request.operationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.regularDate)) {
            body.put("regularDate", request.regularDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
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
            new TeaPair("action", "HrmProcessRegular"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/processes/regulars/become"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmProcessRegularResponse());
    }

    public HrmProcessRegularResponse hrmProcessRegular(HrmProcessRegularRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmProcessRegularHeaders headers = new HrmProcessRegularHeaders();
        return this.hrmProcessRegularWithOptions(request, headers, runtime);
    }

    public HrmProcessTransferResponse hrmProcessTransferWithOptions(HrmProcessTransferRequest request, HrmProcessTransferHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptIdsAfterTransfer)) {
            body.put("deptIdsAfterTransfer", request.deptIdsAfterTransfer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jobIdAfterTransfer)) {
            body.put("jobIdAfterTransfer", request.jobIdAfterTransfer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mainDeptIdAfterTransfer)) {
            body.put("mainDeptIdAfterTransfer", request.mainDeptIdAfterTransfer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateUserId)) {
            body.put("operateUserId", request.operateUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.positionIdAfterTransfer)) {
            body.put("positionIdAfterTransfer", request.positionIdAfterTransfer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.positionLevelAfterTransfer)) {
            body.put("positionLevelAfterTransfer", request.positionLevelAfterTransfer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.positionNameAfterTransfer)) {
            body.put("positionNameAfterTransfer", request.positionNameAfterTransfer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rankIdAfterTransfer)) {
            body.put("rankIdAfterTransfer", request.rankIdAfterTransfer);
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
            new TeaPair("action", "HrmProcessTransfer"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/processes/transfer"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmProcessTransferResponse());
    }

    public HrmProcessTransferResponse hrmProcessTransfer(HrmProcessTransferRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmProcessTransferHeaders headers = new HrmProcessTransferHeaders();
        return this.hrmProcessTransferWithOptions(request, headers, runtime);
    }

    public HrmProcessUpdateTerminationInfoResponse hrmProcessUpdateTerminationInfoWithOptions(HrmProcessUpdateTerminationInfoRequest request, HrmProcessUpdateTerminationInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dismissionMemo)) {
            body.put("dismissionMemo", request.dismissionMemo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.lastWorkDate)) {
            body.put("lastWorkDate", request.lastWorkDate);
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
            new TeaPair("action", "HrmProcessUpdateTerminationInfo"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/processes/employees/terminations"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmProcessUpdateTerminationInfoResponse());
    }

    public HrmProcessUpdateTerminationInfoResponse hrmProcessUpdateTerminationInfo(HrmProcessUpdateTerminationInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmProcessUpdateTerminationInfoHeaders headers = new HrmProcessUpdateTerminationInfoHeaders();
        return this.hrmProcessUpdateTerminationInfoWithOptions(request, headers, runtime);
    }

    public HrmPtsServiceResponse hrmPtsServiceWithOptions(HrmPtsServiceRequest request, HrmPtsServiceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.env)) {
            body.put("env", request.env);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.method)) {
            body.put("method", request.method);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.params)) {
            body.put("params", request.params);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.path)) {
            body.put("path", request.path);
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
            new TeaPair("action", "HrmPtsService"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/pts/request"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HrmPtsServiceResponse());
    }

    public HrmPtsServiceResponse hrmPtsService(HrmPtsServiceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HrmPtsServiceHeaders headers = new HrmPtsServiceHeaders();
        return this.hrmPtsServiceWithOptions(request, headers, runtime);
    }

    public MasterDataDeleteResponse masterDataDeleteWithOptions(MasterDataDeleteRequest request, MasterDataDeleteHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.tenantId)) {
            query.put("tenantId", request.tenantId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.teautil.Common.toArray(request.body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "MasterDataDelete"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/masters/datas/batchRemove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MasterDataDeleteResponse());
    }

    public MasterDataDeleteResponse masterDataDelete(MasterDataDeleteRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MasterDataDeleteHeaders headers = new MasterDataDeleteHeaders();
        return this.masterDataDeleteWithOptions(request, headers, runtime);
    }

    public MasterDataQueryResponse masterDataQueryWithOptions(MasterDataQueryRequest request, MasterDataQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizUK)) {
            body.put("bizUK", request.bizUK);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.optUserId)) {
            body.put("optUserId", request.optUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queryParams)) {
            body.put("queryParams", request.queryParams);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationIds)) {
            body.put("relationIds", request.relationIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeCode)) {
            body.put("scopeCode", request.scopeCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tenantId)) {
            body.put("tenantId", request.tenantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.viewEntityCode)) {
            body.put("viewEntityCode", request.viewEntityCode);
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
            new TeaPair("action", "MasterDataQuery"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/masters/datas/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MasterDataQueryResponse());
    }

    public MasterDataQueryResponse masterDataQuery(MasterDataQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MasterDataQueryHeaders headers = new MasterDataQueryHeaders();
        return this.masterDataQueryWithOptions(request, headers, runtime);
    }

    public MasterDataSaveResponse masterDataSaveWithOptions(MasterDataSaveRequest request, MasterDataSaveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.tenantId)) {
            query.put("tenantId", request.tenantId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.teautil.Common.toArray(request.body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "MasterDataSave"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/masters/datas/save"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MasterDataSaveResponse());
    }

    public MasterDataSaveResponse masterDataSave(MasterDataSaveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MasterDataSaveHeaders headers = new MasterDataSaveHeaders();
        return this.masterDataSaveWithOptions(request, headers, runtime);
    }

    public MasterDataTenantQueyResponse masterDataTenantQueyWithOptions(MasterDataTenantQueyRequest request, MasterDataTenantQueyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.entityCode)) {
            query.put("entityCode", request.entityCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeCode)) {
            query.put("scopeCode", request.scopeCode);
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
            new TeaPair("action", "MasterDataTenantQuey"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/masters/tenants"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MasterDataTenantQueyResponse());
    }

    public MasterDataTenantQueyResponse masterDataTenantQuey(MasterDataTenantQueyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MasterDataTenantQueyHeaders headers = new MasterDataTenantQueyHeaders();
        return this.masterDataTenantQueyWithOptions(request, headers, runtime);
    }

    public MasterDatasQueryResponse masterDatasQueryWithOptions(MasterDatasQueryRequest request, MasterDatasQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizUK)) {
            body.put("bizUK", request.bizUK);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queryParams)) {
            body.put("queryParams", request.queryParams);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationIds)) {
            body.put("relationIds", request.relationIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeCode)) {
            body.put("scopeCode", request.scopeCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tenantId)) {
            body.put("tenantId", request.tenantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.viewEntityCode)) {
            body.put("viewEntityCode", request.viewEntityCode);
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
            new TeaPair("action", "MasterDatasQuery"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/masterDatas/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MasterDatasQueryResponse());
    }

    public MasterDatasQueryResponse masterDatasQuery(MasterDatasQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MasterDatasQueryHeaders headers = new MasterDatasQueryHeaders();
        return this.masterDatasQueryWithOptions(request, headers, runtime);
    }

    public QueryCustomEntryProcessesResponse queryCustomEntryProcessesWithOptions(QueryCustomEntryProcessesRequest request, QueryCustomEntryProcessesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateUserId)) {
            query.put("operateUserId", request.operateUserId);
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
            new TeaPair("action", "QueryCustomEntryProcesses"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/customEntryProcesses"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCustomEntryProcessesResponse());
    }

    public QueryCustomEntryProcessesResponse queryCustomEntryProcesses(QueryCustomEntryProcessesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCustomEntryProcessesHeaders headers = new QueryCustomEntryProcessesHeaders();
        return this.queryCustomEntryProcessesWithOptions(request, headers, runtime);
    }

    public QueryDismissionStaffIdListResponse queryDismissionStaffIdListWithOptions(QueryDismissionStaffIdListRequest request, QueryDismissionStaffIdListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
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
            new TeaPair("action", "QueryDismissionStaffIdList"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/employees/dismissions"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDismissionStaffIdListResponse());
    }

    public QueryDismissionStaffIdListResponse queryDismissionStaffIdList(QueryDismissionStaffIdListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDismissionStaffIdListHeaders headers = new QueryDismissionStaffIdListHeaders();
        return this.queryDismissionStaffIdListWithOptions(request, headers, runtime);
    }

    public QueryHrmEmployeeDismissionInfoResponse queryHrmEmployeeDismissionInfoWithOptions(QueryHrmEmployeeDismissionInfoRequest tmpReq, QueryHrmEmployeeDismissionInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        QueryHrmEmployeeDismissionInfoShrinkRequest request = new QueryHrmEmployeeDismissionInfoShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.userIdList)) {
            request.userIdListShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.userIdList, "userIdList", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userIdListShrink)) {
            query.put("userIdList", request.userIdListShrink);
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
            new TeaPair("action", "QueryHrmEmployeeDismissionInfo"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/employees/dimissionInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryHrmEmployeeDismissionInfoResponse());
    }

    public QueryHrmEmployeeDismissionInfoResponse queryHrmEmployeeDismissionInfo(QueryHrmEmployeeDismissionInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryHrmEmployeeDismissionInfoHeaders headers = new QueryHrmEmployeeDismissionInfoHeaders();
        return this.queryHrmEmployeeDismissionInfoWithOptions(request, headers, runtime);
    }

    public QueryJobRanksResponse queryJobRanksWithOptions(QueryJobRanksRequest request, QueryJobRanksHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rankCategoryId)) {
            query.put("rankCategoryId", request.rankCategoryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rankCode)) {
            query.put("rankCode", request.rankCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rankName)) {
            query.put("rankName", request.rankName);
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
            new TeaPair("action", "QueryJobRanks"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/jobRanks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryJobRanksResponse());
    }

    public QueryJobRanksResponse queryJobRanks(QueryJobRanksRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryJobRanksHeaders headers = new QueryJobRanksHeaders();
        return this.queryJobRanksWithOptions(request, headers, runtime);
    }

    public QueryJobsResponse queryJobsWithOptions(QueryJobsRequest request, QueryJobsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.jobName)) {
            query.put("jobName", request.jobName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
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
            new TeaPair("action", "QueryJobs"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/jobs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryJobsResponse());
    }

    public QueryJobsResponse queryJobs(QueryJobsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryJobsHeaders headers = new QueryJobsHeaders();
        return this.queryJobsWithOptions(request, headers, runtime);
    }

    public QueryPositionsResponse queryPositionsWithOptions(QueryPositionsRequest request, QueryPositionsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.inCategoryIds)) {
            body.put("inCategoryIds", request.inCategoryIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.inPositionIds)) {
            body.put("inPositionIds", request.inPositionIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.positionName)) {
            body.put("positionName", request.positionName);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryPositions"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/positions/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryPositionsResponse());
    }

    public QueryPositionsResponse queryPositions(QueryPositionsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPositionsHeaders headers = new QueryPositionsHeaders();
        return this.queryPositionsWithOptions(request, headers, runtime);
    }

    public RosterMetaAvailableFieldListResponse rosterMetaAvailableFieldListWithOptions(RosterMetaAvailableFieldListRequest request, RosterMetaAvailableFieldListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appAgentId)) {
            query.put("appAgentId", request.appAgentId);
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
            new TeaPair("action", "RosterMetaAvailableFieldList"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/rosters/meta/authorities/fields"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RosterMetaAvailableFieldListResponse());
    }

    public RosterMetaAvailableFieldListResponse rosterMetaAvailableFieldList(RosterMetaAvailableFieldListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RosterMetaAvailableFieldListHeaders headers = new RosterMetaAvailableFieldListHeaders();
        return this.rosterMetaAvailableFieldListWithOptions(request, headers, runtime);
    }

    public RosterMetaFieldOptionsUpdateResponse rosterMetaFieldOptionsUpdateWithOptions(RosterMetaFieldOptionsUpdateRequest request, RosterMetaFieldOptionsUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appAgentId)) {
            query.put("appAgentId", request.appAgentId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fieldCode)) {
            body.put("fieldCode", request.fieldCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupId)) {
            body.put("groupId", request.groupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.labels)) {
            body.put("labels", request.labels);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifyType)) {
            body.put("modifyType", request.modifyType);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RosterMetaFieldOptionsUpdate"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/rosters/meta/fields/options"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RosterMetaFieldOptionsUpdateResponse());
    }

    public RosterMetaFieldOptionsUpdateResponse rosterMetaFieldOptionsUpdate(RosterMetaFieldOptionsUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RosterMetaFieldOptionsUpdateHeaders headers = new RosterMetaFieldOptionsUpdateHeaders();
        return this.rosterMetaFieldOptionsUpdateWithOptions(request, headers, runtime);
    }

    public SendIsvCardMessageResponse sendIsvCardMessageWithOptions(SendIsvCardMessageRequest request, SendIsvCardMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            query.put("agentId", request.agentId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.messageType)) {
            body.put("messageType", request.messageType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUserIds)) {
            body.put("receiverUserIds", request.receiverUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sceneType)) {
            body.put("sceneType", request.sceneType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scope)) {
            body.put("scope", request.scope);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.senderUserId)) {
            body.put("senderUserId", request.senderUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.valueMap)) {
            body.put("valueMap", request.valueMap);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SendIsvCardMessage"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/cardMessages/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendIsvCardMessageResponse());
    }

    public SendIsvCardMessageResponse sendIsvCardMessage(SendIsvCardMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendIsvCardMessageHeaders headers = new SendIsvCardMessageHeaders();
        return this.sendIsvCardMessageWithOptions(request, headers, runtime);
    }

    public SolutionTaskInitResponse solutionTaskInitWithOptions(SolutionTaskInitRequest request, SolutionTaskInitHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.solutionType)) {
            query.put("solutionType", request.solutionType);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.category)) {
            body.put("category", request.category);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.claimTime)) {
            body.put("claimTime", request.claimTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.finishTime)) {
            body.put("finishTime", request.finishTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerId)) {
            body.put("outerId", request.outerId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SolutionTaskInit"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/solutions/tasks/init"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SolutionTaskInitResponse());
    }

    public SolutionTaskInitResponse solutionTaskInit(SolutionTaskInitRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SolutionTaskInitHeaders headers = new SolutionTaskInitHeaders();
        return this.solutionTaskInitWithOptions(request, headers, runtime);
    }

    public SolutionTaskSaveResponse solutionTaskSaveWithOptions(SolutionTaskSaveRequest request, SolutionTaskSaveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.solutionType)) {
            query.put("solutionType", request.solutionType);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.claimTime)) {
            body.put("claimTime", request.claimTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.finishTime)) {
            body.put("finishTime", request.finishTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerId)) {
            body.put("outerId", request.outerId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.solutionInstanceId)) {
            body.put("solutionInstanceId", request.solutionInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskType)) {
            body.put("taskType", request.taskType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateOuterId)) {
            body.put("templateOuterId", request.templateOuterId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SolutionTaskSave"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/solutions/tasks/save"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SolutionTaskSaveResponse());
    }

    public SolutionTaskSaveResponse solutionTaskSave(SolutionTaskSaveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SolutionTaskSaveHeaders headers = new SolutionTaskSaveHeaders();
        return this.solutionTaskSaveWithOptions(request, headers, runtime);
    }

    public SyncTaskTemplateResponse syncTaskTemplateWithOptions(SyncTaskTemplateRequest request, SyncTaskTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.solutionType)) {
            query.put("solutionType", request.solutionType);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.delete)) {
            body.put("delete", request.delete);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.des)) {
            body.put("des", request.des);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.optUserId)) {
            body.put("optUserId", request.optUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerId)) {
            body.put("outerId", request.outerId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskScopeVO)) {
            body.put("taskScopeVO", request.taskScopeVO);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskType)) {
            body.put("taskType", request.taskType);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SyncTaskTemplate"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/solutions/tasks/templates/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncTaskTemplateResponse());
    }

    public SyncTaskTemplateResponse syncTaskTemplate(SyncTaskTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncTaskTemplateHeaders headers = new SyncTaskTemplateHeaders();
        return this.syncTaskTemplateWithOptions(request, headers, runtime);
    }

    public UpdateIsvCardMessageResponse updateIsvCardMessageWithOptions(UpdateIsvCardMessageRequest request, UpdateIsvCardMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            query.put("agentId", request.agentId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.messageType)) {
            body.put("messageType", request.messageType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sceneType)) {
            body.put("sceneType", request.sceneType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scope)) {
            body.put("scope", request.scope);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.valueMap)) {
            body.put("valueMap", request.valueMap);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateIsvCardMessage"),
            new TeaPair("version", "hrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/hrm/cardMessages"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateIsvCardMessageResponse());
    }

    public UpdateIsvCardMessageResponse updateIsvCardMessage(UpdateIsvCardMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateIsvCardMessageHeaders headers = new UpdateIsvCardMessageHeaders();
        return this.updateIsvCardMessageWithOptions(request, headers, runtime);
    }
}
