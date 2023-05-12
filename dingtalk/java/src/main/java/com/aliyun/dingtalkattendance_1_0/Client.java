// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkattendance_1_0.models.*;

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


    public AddLeaveTypeResponse addLeaveTypeWithOptions(AddLeaveTypeRequest request, AddLeaveTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extras)) {
            body.put("extras", request.extras);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hoursInPerDay)) {
            body.put("hoursInPerDay", request.hoursInPerDay);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaveCertificate)) {
            body.put("leaveCertificate", request.leaveCertificate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaveName)) {
            body.put("leaveName", request.leaveName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaveViewUnit)) {
            body.put("leaveViewUnit", request.leaveViewUnit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.naturalDayLeave)) {
            body.put("naturalDayLeave", request.naturalDayLeave);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.submitTimeRule)) {
            body.put("submitTimeRule", request.submitTimeRule);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.visibilityRules)) {
            body.put("visibilityRules", request.visibilityRules);
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
            new TeaPair("action", "AddLeaveType"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/leaves/types"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddLeaveTypeResponse());
    }

    public AddLeaveTypeResponse addLeaveType(AddLeaveTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddLeaveTypeHeaders headers = new AddLeaveTypeHeaders();
        return this.addLeaveTypeWithOptions(request, headers, runtime);
    }

    public AttendanceBleDevicesAddResponse attendanceBleDevicesAddWithOptions(AttendanceBleDevicesAddRequest request, AttendanceBleDevicesAddHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceIdList)) {
            body.put("deviceIdList", request.deviceIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupKey)) {
            body.put("groupKey", request.groupKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
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
            new TeaPair("action", "AttendanceBleDevicesAdd"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/group/bledevices"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AttendanceBleDevicesAddResponse());
    }

    public AttendanceBleDevicesAddResponse attendanceBleDevicesAdd(AttendanceBleDevicesAddRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AttendanceBleDevicesAddHeaders headers = new AttendanceBleDevicesAddHeaders();
        return this.attendanceBleDevicesAddWithOptions(request, headers, runtime);
    }

    public AttendanceBleDevicesQueryResponse attendanceBleDevicesQueryWithOptions(AttendanceBleDevicesQueryRequest request, AttendanceBleDevicesQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupKey)) {
            body.put("groupKey", request.groupKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
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
            new TeaPair("action", "AttendanceBleDevicesQuery"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/group/bledevices/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AttendanceBleDevicesQueryResponse());
    }

    public AttendanceBleDevicesQueryResponse attendanceBleDevicesQuery(AttendanceBleDevicesQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AttendanceBleDevicesQueryHeaders headers = new AttendanceBleDevicesQueryHeaders();
        return this.attendanceBleDevicesQueryWithOptions(request, headers, runtime);
    }

    public AttendanceBleDevicesRemoveResponse attendanceBleDevicesRemoveWithOptions(AttendanceBleDevicesRemoveRequest request, AttendanceBleDevicesRemoveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceIdList)) {
            body.put("deviceIdList", request.deviceIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupKey)) {
            body.put("groupKey", request.groupKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
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
            new TeaPair("action", "AttendanceBleDevicesRemove"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/group/bledevices/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AttendanceBleDevicesRemoveResponse());
    }

    public AttendanceBleDevicesRemoveResponse attendanceBleDevicesRemove(AttendanceBleDevicesRemoveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AttendanceBleDevicesRemoveHeaders headers = new AttendanceBleDevicesRemoveHeaders();
        return this.attendanceBleDevicesRemoveWithOptions(request, headers, runtime);
    }

    public CheckClosingAccountResponse checkClosingAccountWithOptions(CheckClosingAccountRequest request, CheckClosingAccountHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userTimeRange)) {
            body.put("userTimeRange", request.userTimeRange);
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
            new TeaPair("action", "CheckClosingAccount"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/closingAccounts/status/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CheckClosingAccountResponse());
    }

    public CheckClosingAccountResponse checkClosingAccount(CheckClosingAccountRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CheckClosingAccountHeaders headers = new CheckClosingAccountHeaders();
        return this.checkClosingAccountWithOptions(request, headers, runtime);
    }

    public CheckWritePermissionResponse checkWritePermissionWithOptions(CheckWritePermissionRequest request, CheckWritePermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.category)) {
            body.put("category", request.category);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.entityIds)) {
            body.put("entityIds", request.entityIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.resourceKey)) {
            body.put("resourceKey", request.resourceKey);
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
            new TeaPair("action", "CheckWritePermission"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/writePermissions/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CheckWritePermissionResponse());
    }

    public CheckWritePermissionResponse checkWritePermission(CheckWritePermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CheckWritePermissionHeaders headers = new CheckWritePermissionHeaders();
        return this.checkWritePermissionWithOptions(request, headers, runtime);
    }

    public CreateApproveResponse createApproveWithOptions(CreateApproveRequest request, CreateApproveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.approveId)) {
            body.put("approveId", request.approveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserid)) {
            body.put("opUserid", request.opUserid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.punchParam)) {
            body.put("punchParam", request.punchParam);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subType)) {
            body.put("subType", request.subType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagName)) {
            body.put("tagName", request.tagName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userid)) {
            body.put("userid", request.userid);
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
            new TeaPair("action", "CreateApprove"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/approves"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateApproveResponse());
    }

    public CreateApproveResponse createApprove(CreateApproveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateApproveHeaders headers = new CreateApproveHeaders();
        return this.createApproveWithOptions(request, headers, runtime);
    }

    public DeleteWaterMarkTemplateResponse deleteWaterMarkTemplateWithOptions(DeleteWaterMarkTemplateRequest request, DeleteWaterMarkTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.formCode)) {
            query.put("formCode", request.formCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formContent)) {
            query.put("formContent", request.formContent);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            query.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemTemplate)) {
            query.put("systemTemplate", request.systemTemplate);
        }

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
            new TeaPair("action", "DeleteWaterMarkTemplate"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/watermarks/templates"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteWaterMarkTemplateResponse());
    }

    public DeleteWaterMarkTemplateResponse deleteWaterMarkTemplate(DeleteWaterMarkTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteWaterMarkTemplateHeaders headers = new DeleteWaterMarkTemplateHeaders();
        return this.deleteWaterMarkTemplateWithOptions(request, headers, runtime);
    }

    public DingTalkSecurityCheckResponse dingTalkSecurityCheckWithOptions(DingTalkSecurityCheckRequest request, DingTalkSecurityCheckHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.clientVer)) {
            body.put("clientVer", request.clientVer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.platform)) {
            body.put("platform", request.platform);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.platformVer)) {
            body.put("platformVer", request.platformVer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sec)) {
            body.put("sec", request.sec);
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
            new TeaPair("action", "DingTalkSecurityCheck"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/securities/check"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DingTalkSecurityCheckResponse());
    }

    public DingTalkSecurityCheckResponse dingTalkSecurityCheck(DingTalkSecurityCheckRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DingTalkSecurityCheckHeaders headers = new DingTalkSecurityCheckHeaders();
        return this.dingTalkSecurityCheckWithOptions(request, headers, runtime);
    }

    public GetATManageScopeResponse getATManageScopeWithOptions(GetATManageScopeRequest request, GetATManageScopeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

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
            new TeaPair("action", "GetATManageScope"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/manageScopes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetATManageScopeResponse());
    }

    public GetATManageScopeResponse getATManageScope(GetATManageScopeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetATManageScopeHeaders headers = new GetATManageScopeHeaders();
        return this.getATManageScopeWithOptions(request, headers, runtime);
    }

    public GetAdjustmentsResponse getAdjustmentsWithOptions(GetAdjustmentsRequest request, GetAdjustmentsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "GetAdjustments"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/adjustments"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAdjustmentsResponse());
    }

    public GetAdjustmentsResponse getAdjustments(GetAdjustmentsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAdjustmentsHeaders headers = new GetAdjustmentsHeaders();
        return this.getAdjustmentsWithOptions(request, headers, runtime);
    }

    public GetCheckInSchemaTemplateResponse getCheckInSchemaTemplateWithOptions(GetCheckInSchemaTemplateRequest request, GetCheckInSchemaTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            query.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sceneCode)) {
            query.put("sceneCode", request.sceneCode);
        }

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
            new TeaPair("action", "GetCheckInSchemaTemplate"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/watermarks/templates"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCheckInSchemaTemplateResponse());
    }

    public GetCheckInSchemaTemplateResponse getCheckInSchemaTemplate(GetCheckInSchemaTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCheckInSchemaTemplateHeaders headers = new GetCheckInSchemaTemplateHeaders();
        return this.getCheckInSchemaTemplateWithOptions(request, headers, runtime);
    }

    public GetCheckinRecordByUserResponse getCheckinRecordByUserWithOptions(GetCheckinRecordByUserRequest request, GetCheckinRecordByUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdList)) {
            body.put("userIdList", request.userIdList);
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
            new TeaPair("action", "GetCheckinRecordByUser"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/checkin/records/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCheckinRecordByUserResponse());
    }

    public GetCheckinRecordByUserResponse getCheckinRecordByUser(GetCheckinRecordByUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCheckinRecordByUserHeaders headers = new GetCheckinRecordByUserHeaders();
        return this.getCheckinRecordByUserWithOptions(request, headers, runtime);
    }

    public GetClosingAccountsResponse getClosingAccountsWithOptions(GetClosingAccountsRequest request, GetClosingAccountsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
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
            new TeaPair("action", "GetClosingAccounts"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/closingAccounts/rules/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetClosingAccountsResponse());
    }

    public GetClosingAccountsResponse getClosingAccounts(GetClosingAccountsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetClosingAccountsHeaders headers = new GetClosingAccountsHeaders();
        return this.getClosingAccountsWithOptions(request, headers, runtime);
    }

    public GetLeaveRecordsResponse getLeaveRecordsWithOptions(GetLeaveRecordsRequest request, GetLeaveRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.leaveCode)) {
            body.put("leaveCode", request.leaveCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
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
            new TeaPair("action", "GetLeaveRecords"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/vacations/records/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetLeaveRecordsResponse());
    }

    public GetLeaveRecordsResponse getLeaveRecords(GetLeaveRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetLeaveRecordsHeaders headers = new GetLeaveRecordsHeaders();
        return this.getLeaveRecordsWithOptions(request, headers, runtime);
    }

    public GetLeaveTypeResponse getLeaveTypeWithOptions(GetLeaveTypeRequest request, GetLeaveTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.vacationSource)) {
            query.put("vacationSource", request.vacationSource);
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
            new TeaPair("action", "GetLeaveType"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/leaves/types"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetLeaveTypeResponse());
    }

    public GetLeaveTypeResponse getLeaveType(GetLeaveTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetLeaveTypeHeaders headers = new GetLeaveTypeHeaders();
        return this.getLeaveTypeWithOptions(request, headers, runtime);
    }

    public GetMachineResponse getMachineWithOptions(String devId, GetMachineHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetMachine"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/machines/" + devId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMachineResponse());
    }

    public GetMachineResponse getMachine(String devId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMachineHeaders headers = new GetMachineHeaders();
        return this.getMachineWithOptions(devId, headers, runtime);
    }

    public GetMachineUserResponse getMachineUserWithOptions(String devId, GetMachineUserRequest request, GetMachineUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetMachineUser"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/machines/getUser/" + devId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMachineUserResponse());
    }

    public GetMachineUserResponse getMachineUser(String devId, GetMachineUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMachineUserHeaders headers = new GetMachineUserHeaders();
        return this.getMachineUserWithOptions(devId, request, headers, runtime);
    }

    public GetOvertimeSettingResponse getOvertimeSettingWithOptions(GetOvertimeSettingRequest request, GetOvertimeSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.overtimeSettingIds)) {
            body.put("overtimeSettingIds", request.overtimeSettingIds);
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
            new TeaPair("action", "GetOvertimeSetting"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/overtimeSettings/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOvertimeSettingResponse());
    }

    public GetOvertimeSettingResponse getOvertimeSetting(GetOvertimeSettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOvertimeSettingHeaders headers = new GetOvertimeSettingHeaders();
        return this.getOvertimeSettingWithOptions(request, headers, runtime);
    }

    public GetSimpleOvertimeSettingResponse getSimpleOvertimeSettingWithOptions(GetSimpleOvertimeSettingRequest request, GetSimpleOvertimeSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "GetSimpleOvertimeSetting"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/overtimeSettings"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSimpleOvertimeSettingResponse());
    }

    public GetSimpleOvertimeSettingResponse getSimpleOvertimeSetting(GetSimpleOvertimeSettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSimpleOvertimeSettingHeaders headers = new GetSimpleOvertimeSettingHeaders();
        return this.getSimpleOvertimeSettingWithOptions(request, headers, runtime);
    }

    public GetUserHolidaysResponse getUserHolidaysWithOptions(GetUserHolidaysRequest request, GetUserHolidaysHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.workDateFrom)) {
            body.put("workDateFrom", request.workDateFrom);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.workDateTo)) {
            body.put("workDateTo", request.workDateTo);
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
            new TeaPair("action", "GetUserHolidays"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/holidays"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserHolidaysResponse());
    }

    public GetUserHolidaysResponse getUserHolidays(GetUserHolidaysRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserHolidaysHeaders headers = new GetUserHolidaysHeaders();
        return this.getUserHolidaysWithOptions(request, headers, runtime);
    }

    public GroupAddResponse groupAddWithOptions(GroupAddRequest request, GroupAddHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.adjustmentSettingId)) {
            body.put("adjustmentSettingId", request.adjustmentSettingId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bleDeviceList)) {
            body.put("bleDeviceList", request.bleDeviceList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.checkNeedHealthyCode)) {
            body.put("checkNeedHealthyCode", request.checkNeedHealthyCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.defaultClassId)) {
            body.put("defaultClassId", request.defaultClassId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.disableCheckWhenRest)) {
            body.put("disableCheckWhenRest", request.disableCheckWhenRest);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.disableCheckWithoutSchedule)) {
            body.put("disableCheckWithoutSchedule", request.disableCheckWithoutSchedule);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableCameraCheck)) {
            body.put("enableCameraCheck", request.enableCameraCheck);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableEmpSelectClass)) {
            body.put("enableEmpSelectClass", request.enableEmpSelectClass);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableFaceCheck)) {
            body.put("enableFaceCheck", request.enableFaceCheck);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableFaceStrictMode)) {
            body.put("enableFaceStrictMode", request.enableFaceStrictMode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableNextDay)) {
            body.put("enableNextDay", request.enableNextDay);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableOutSideUpdateNormalCheck)) {
            body.put("enableOutSideUpdateNormalCheck", request.enableOutSideUpdateNormalCheck);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableOutsideApply)) {
            body.put("enableOutsideApply", request.enableOutsideApply);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableOutsideCameraCheck)) {
            body.put("enableOutsideCameraCheck", request.enableOutsideCameraCheck);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableOutsideCheck)) {
            body.put("enableOutsideCheck", request.enableOutsideCheck);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableOutsideRemark)) {
            body.put("enableOutsideRemark", request.enableOutsideRemark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enablePositionBle)) {
            body.put("enablePositionBle", request.enablePositionBle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableTrimDistance)) {
            body.put("enableTrimDistance", request.enableTrimDistance);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.forbidHideOutSideAddress)) {
            body.put("forbidHideOutSideAddress", request.forbidHideOutSideAddress);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.freeCheckSetting)) {
            body.put("freeCheckSetting", request.freeCheckSetting);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.freeCheckTypeId)) {
            body.put("freeCheckTypeId", request.freeCheckTypeId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.freecheckDayStartMinOffset)) {
            body.put("freecheckDayStartMinOffset", request.freecheckDayStartMinOffset);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.freecheckWorkDays)) {
            body.put("freecheckWorkDays", request.freecheckWorkDays);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupId)) {
            body.put("groupId", request.groupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupName)) {
            body.put("groupName", request.groupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerList)) {
            body.put("managerList", request.managerList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifyMember)) {
            body.put("modifyMember", request.modifyMember);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.offset)) {
            body.put("offset", request.offset);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openFaceCheck)) {
            body.put("openFaceCheck", request.openFaceCheck);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outsideCheckApproveModeId)) {
            body.put("outsideCheckApproveModeId", request.outsideCheckApproveModeId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.overtimeSettingId)) {
            body.put("overtimeSettingId", request.overtimeSettingId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.owner)) {
            body.put("owner", request.owner);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.positions)) {
            body.put("positions", request.positions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.resourcePermissionMap)) {
            body.put("resourcePermissionMap", request.resourcePermissionMap);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.shiftVOList)) {
            body.put("shiftVOList", request.shiftVOList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.skipHolidays)) {
            body.put("skipHolidays", request.skipHolidays);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.specialDays)) {
            body.put("specialDays", request.specialDays);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.trimDistance)) {
            body.put("trimDistance", request.trimDistance);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.wifis)) {
            body.put("wifis", request.wifis);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.workdayClassList)) {
            body.put("workdayClassList", request.workdayClassList);
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
            new TeaPair("action", "GroupAdd"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/groups"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GroupAddResponse());
    }

    public GroupAddResponse groupAdd(GroupAddRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GroupAddHeaders headers = new GroupAddHeaders();
        return this.groupAddWithOptions(request, headers, runtime);
    }

    public GroupUpdateResponse groupUpdateWithOptions(GroupUpdateRequest request, GroupUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.adjustmentSettingId)) {
            body.put("adjustmentSettingId", request.adjustmentSettingId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.disableCheckWhenRest)) {
            body.put("disableCheckWhenRest", request.disableCheckWhenRest);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.disableCheckWithoutSchedule)) {
            body.put("disableCheckWithoutSchedule", request.disableCheckWithoutSchedule);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableCameraCheck)) {
            body.put("enableCameraCheck", request.enableCameraCheck);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableEmpSelectClass)) {
            body.put("enableEmpSelectClass", request.enableEmpSelectClass);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableFaceCheck)) {
            body.put("enableFaceCheck", request.enableFaceCheck);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableFaceStrictMode)) {
            body.put("enableFaceStrictMode", request.enableFaceStrictMode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableOutSideUpdateNormalCheck)) {
            body.put("enableOutSideUpdateNormalCheck", request.enableOutSideUpdateNormalCheck);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableOutsideApply)) {
            body.put("enableOutsideApply", request.enableOutsideApply);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableOutsideCheck)) {
            body.put("enableOutsideCheck", request.enableOutsideCheck);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableOutsideRemark)) {
            body.put("enableOutsideRemark", request.enableOutsideRemark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.enableTrimDistance)) {
            body.put("enableTrimDistance", request.enableTrimDistance);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.forbidHideOutSideAddress)) {
            body.put("forbidHideOutSideAddress", request.forbidHideOutSideAddress);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.freeCheckSetting)) {
            body.put("freeCheckSetting", request.freeCheckSetting);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.freeCheckTypeId)) {
            body.put("freeCheckTypeId", request.freeCheckTypeId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupId)) {
            body.put("groupId", request.groupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupName)) {
            body.put("groupName", request.groupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerList)) {
            body.put("managerList", request.managerList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.offset)) {
            body.put("offset", request.offset);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openFaceCheck)) {
            body.put("openFaceCheck", request.openFaceCheck);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outsideCheckApproveModeId)) {
            body.put("outsideCheckApproveModeId", request.outsideCheckApproveModeId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.overtimeSettingId)) {
            body.put("overtimeSettingId", request.overtimeSettingId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.owner)) {
            body.put("owner", request.owner);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.positions)) {
            body.put("positions", request.positions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.resourcePermissionMap)) {
            body.put("resourcePermissionMap", request.resourcePermissionMap);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.shiftVOList)) {
            body.put("shiftVOList", request.shiftVOList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.skipHolidays)) {
            body.put("skipHolidays", request.skipHolidays);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.trimDistance)) {
            body.put("trimDistance", request.trimDistance);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.workdayClassList)) {
            body.put("workdayClassList", request.workdayClassList);
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
            new TeaPair("action", "GroupUpdate"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/groups"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GroupUpdateResponse());
    }

    public GroupUpdateResponse groupUpdate(GroupUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GroupUpdateHeaders headers = new GroupUpdateHeaders();
        return this.groupUpdateWithOptions(request, headers, runtime);
    }

    public InitAndGetLeaveALlocationQuotasResponse initAndGetLeaveALlocationQuotasWithOptions(InitAndGetLeaveALlocationQuotasRequest request, InitAndGetLeaveALlocationQuotasHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.leaveCode)) {
            query.put("leaveCode", request.leaveCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

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
            new TeaPair("action", "InitAndGetLeaveALlocationQuotas"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/leaves/initializations/balances"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InitAndGetLeaveALlocationQuotasResponse());
    }

    public InitAndGetLeaveALlocationQuotasResponse initAndGetLeaveALlocationQuotas(InitAndGetLeaveALlocationQuotasRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InitAndGetLeaveALlocationQuotasHeaders headers = new InitAndGetLeaveALlocationQuotasHeaders();
        return this.initAndGetLeaveALlocationQuotasWithOptions(request, headers, runtime);
    }

    public ListApproveByUsersResponse listApproveByUsersWithOptions(ListApproveByUsersRequest request, ListApproveByUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizTypes)) {
            body.put("bizTypes", request.bizTypes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fromDateTime)) {
            body.put("fromDateTime", request.fromDateTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toDateTime)) {
            body.put("toDateTime", request.toDateTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
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
            new TeaPair("action", "ListApproveByUsers"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/approvals/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListApproveByUsersResponse());
    }

    public ListApproveByUsersResponse listApproveByUsers(ListApproveByUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListApproveByUsersHeaders headers = new ListApproveByUsersHeaders();
        return this.listApproveByUsersWithOptions(request, headers, runtime);
    }

    public ModifyWaterMarkTemplateResponse modifyWaterMarkTemplateWithOptions(ModifyWaterMarkTemplateRequest request, ModifyWaterMarkTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            query.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.formCode)) {
            body.put("formCode", request.formCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.layoutDesignId)) {
            body.put("layoutDesignId", request.layoutDesignId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaContent)) {
            body.put("schemaContent", request.schemaContent);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.waterMarkId)) {
            body.put("waterMarkId", request.waterMarkId);
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
            new TeaPair("action", "ModifyWaterMarkTemplate"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/watermarks/templates"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ModifyWaterMarkTemplateResponse());
    }

    public ModifyWaterMarkTemplateResponse modifyWaterMarkTemplate(ModifyWaterMarkTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ModifyWaterMarkTemplateHeaders headers = new ModifyWaterMarkTemplateHeaders();
        return this.modifyWaterMarkTemplateWithOptions(request, headers, runtime);
    }

    public ProcessApproveCreateResponse processApproveCreateWithOptions(ProcessApproveCreateRequest request, ProcessApproveCreateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.approveId)) {
            body.put("approveId", request.approveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.punchParam)) {
            body.put("punchParam", request.punchParam);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subType)) {
            body.put("subType", request.subType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagName)) {
            body.put("tagName", request.tagName);
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
            new TeaPair("action", "ProcessApproveCreate"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/workflows/checkInForms"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ProcessApproveCreateResponse());
    }

    public ProcessApproveCreateResponse processApproveCreate(ProcessApproveCreateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ProcessApproveCreateHeaders headers = new ProcessApproveCreateHeaders();
        return this.processApproveCreateWithOptions(request, headers, runtime);
    }

    public SaveCustomWaterMarkTemplateResponse saveCustomWaterMarkTemplateWithOptions(SaveCustomWaterMarkTemplateRequest request, SaveCustomWaterMarkTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            query.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.layoutDesignId)) {
            body.put("layoutDesignId", request.layoutDesignId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sceneCode)) {
            body.put("sceneCode", request.sceneCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaContent)) {
            body.put("schemaContent", request.schemaContent);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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
            new TeaPair("action", "SaveCustomWaterMarkTemplate"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/watermarks/templates"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveCustomWaterMarkTemplateResponse());
    }

    public SaveCustomWaterMarkTemplateResponse saveCustomWaterMarkTemplate(SaveCustomWaterMarkTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveCustomWaterMarkTemplateHeaders headers = new SaveCustomWaterMarkTemplateHeaders();
        return this.saveCustomWaterMarkTemplateWithOptions(request, headers, runtime);
    }

    public SyncScheduleInfoResponse syncScheduleInfoWithOptions(SyncScheduleInfoRequest request, SyncScheduleInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scheduleInfos)) {
            body.put("scheduleInfos", request.scheduleInfos);
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
            new TeaPair("action", "SyncScheduleInfo"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/schedules/additionalInfo"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncScheduleInfoResponse());
    }

    public SyncScheduleInfoResponse syncScheduleInfo(SyncScheduleInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncScheduleInfoHeaders headers = new SyncScheduleInfoHeaders();
        return this.syncScheduleInfoWithOptions(request, headers, runtime);
    }

    public UpdateLeaveTypeResponse updateLeaveTypeWithOptions(UpdateLeaveTypeRequest request, UpdateLeaveTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extras)) {
            body.put("extras", request.extras);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hoursInPerDay)) {
            body.put("hoursInPerDay", request.hoursInPerDay);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaveCertificate)) {
            body.put("leaveCertificate", request.leaveCertificate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaveCode)) {
            body.put("leaveCode", request.leaveCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaveName)) {
            body.put("leaveName", request.leaveName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaveViewUnit)) {
            body.put("leaveViewUnit", request.leaveViewUnit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.naturalDayLeave)) {
            body.put("naturalDayLeave", request.naturalDayLeave);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.submitTimeRule)) {
            body.put("submitTimeRule", request.submitTimeRule);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.visibilityRules)) {
            body.put("visibilityRules", request.visibilityRules);
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
            new TeaPair("action", "UpdateLeaveType"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/leaves/types"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateLeaveTypeResponse());
    }

    public UpdateLeaveTypeResponse updateLeaveType(UpdateLeaveTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateLeaveTypeHeaders headers = new UpdateLeaveTypeHeaders();
        return this.updateLeaveTypeWithOptions(request, headers, runtime);
    }
}
