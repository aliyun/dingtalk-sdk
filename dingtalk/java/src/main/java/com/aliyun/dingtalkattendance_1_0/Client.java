// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkattendance_1_0.models.*;
import com.aliyun.teautil.*;
import com.aliyun.teautil.models.*;
import com.aliyun.teaopenapi.*;
import com.aliyun.teaopenapi.models.*;
import com.aliyun.openapiutil.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public AttendanceBleDevicesAddResponse attendanceBleDevicesAdd(AttendanceBleDevicesAddRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AttendanceBleDevicesAddHeaders headers = new AttendanceBleDevicesAddHeaders();
        return this.attendanceBleDevicesAddWithOptions(request, headers, runtime);
    }

    public AttendanceBleDevicesAddResponse attendanceBleDevicesAddWithOptions(AttendanceBleDevicesAddRequest request, AttendanceBleDevicesAddHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AttendanceBleDevicesAdd", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/group/bledevices", "json", req, runtime), new AttendanceBleDevicesAddResponse());
    }

    public AttendanceBleDevicesQueryResponse attendanceBleDevicesQuery(AttendanceBleDevicesQueryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AttendanceBleDevicesQueryHeaders headers = new AttendanceBleDevicesQueryHeaders();
        return this.attendanceBleDevicesQueryWithOptions(request, headers, runtime);
    }

    public AttendanceBleDevicesQueryResponse attendanceBleDevicesQueryWithOptions(AttendanceBleDevicesQueryRequest request, AttendanceBleDevicesQueryHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequestWithForm("AttendanceBleDevicesQuery", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/group/bledevices/query", "json", req, runtime), new AttendanceBleDevicesQueryResponse());
    }

    public AttendanceBleDevicesRemoveResponse attendanceBleDevicesRemove(AttendanceBleDevicesRemoveRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AttendanceBleDevicesRemoveHeaders headers = new AttendanceBleDevicesRemoveHeaders();
        return this.attendanceBleDevicesRemoveWithOptions(request, headers, runtime);
    }

    public AttendanceBleDevicesRemoveResponse attendanceBleDevicesRemoveWithOptions(AttendanceBleDevicesRemoveRequest request, AttendanceBleDevicesRemoveHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AttendanceBleDevicesRemove", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/group/bledevices/remove", "json", req, runtime), new AttendanceBleDevicesRemoveResponse());
    }

    public CheckClosingAccountResponse checkClosingAccount(CheckClosingAccountRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CheckClosingAccountHeaders headers = new CheckClosingAccountHeaders();
        return this.checkClosingAccountWithOptions(request, headers, runtime);
    }

    public CheckClosingAccountResponse checkClosingAccountWithOptions(CheckClosingAccountRequest request, CheckClosingAccountHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CheckClosingAccount", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/closingAccounts/status/query", "json", req, runtime), new CheckClosingAccountResponse());
    }

    public CheckWritePermissionResponse checkWritePermission(CheckWritePermissionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CheckWritePermissionHeaders headers = new CheckWritePermissionHeaders();
        return this.checkWritePermissionWithOptions(request, headers, runtime);
    }

    public CheckWritePermissionResponse checkWritePermissionWithOptions(CheckWritePermissionRequest request, CheckWritePermissionHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CheckWritePermission", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/writePermissions/query", "json", req, runtime), new CheckWritePermissionResponse());
    }

    public CreateApproveResponse createApprove(CreateApproveRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateApproveHeaders headers = new CreateApproveHeaders();
        return this.createApproveWithOptions(request, headers, runtime);
    }

    public CreateApproveResponse createApproveWithOptions(CreateApproveRequest request, CreateApproveHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.approveId)) {
            body.put("approveId", request.approveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserid)) {
            body.put("opUserid", request.opUserid);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.punchParam))) {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateApprove", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/approves", "json", req, runtime), new CreateApproveResponse());
    }

    public DingTalkSecurityCheckResponse dingTalkSecurityCheck(DingTalkSecurityCheckRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DingTalkSecurityCheckHeaders headers = new DingTalkSecurityCheckHeaders();
        return this.dingTalkSecurityCheckWithOptions(request, headers, runtime);
    }

    public DingTalkSecurityCheckResponse dingTalkSecurityCheckWithOptions(DingTalkSecurityCheckRequest request, DingTalkSecurityCheckHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("DingTalkSecurityCheck", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/securities/check", "json", req, runtime), new DingTalkSecurityCheckResponse());
    }

    public GetClosingAccountsResponse getClosingAccounts(GetClosingAccountsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetClosingAccountsHeaders headers = new GetClosingAccountsHeaders();
        return this.getClosingAccountsWithOptions(request, headers, runtime);
    }

    public GetClosingAccountsResponse getClosingAccountsWithOptions(GetClosingAccountsRequest request, GetClosingAccountsHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetClosingAccounts", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/closingAccounts/rules/query", "json", req, runtime), new GetClosingAccountsResponse());
    }

    public GetMachineResponse getMachine(String devId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetMachineHeaders headers = new GetMachineHeaders();
        return this.getMachineWithOptions(devId, headers, runtime);
    }

    public GetMachineResponse getMachineWithOptions(String devId, GetMachineHeaders headers, RuntimeOptions runtime) throws Exception {
        devId = com.aliyun.openapiutil.Client.getEncodeParam(devId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetMachine", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/machines/" + devId + "", "json", req, runtime), new GetMachineResponse());
    }

    public GetMachineUserResponse getMachineUser(String devId, GetMachineUserRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetMachineUserHeaders headers = new GetMachineUserHeaders();
        return this.getMachineUserWithOptions(devId, request, headers, runtime);
    }

    public GetMachineUserResponse getMachineUserWithOptions(String devId, GetMachineUserRequest request, GetMachineUserHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        devId = com.aliyun.openapiutil.Client.getEncodeParam(devId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetMachineUser", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/machines/getUser/" + devId + "", "json", req, runtime), new GetMachineUserResponse());
    }

    public GetOvertimeSettingResponse getOvertimeSetting(GetOvertimeSettingRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetOvertimeSettingHeaders headers = new GetOvertimeSettingHeaders();
        return this.getOvertimeSettingWithOptions(request, headers, runtime);
    }

    public GetOvertimeSettingResponse getOvertimeSettingWithOptions(GetOvertimeSettingRequest request, GetOvertimeSettingHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetOvertimeSetting", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/overtimeSettings/query", "json", req, runtime), new GetOvertimeSettingResponse());
    }

    public GetUserHolidaysResponse getUserHolidays(GetUserHolidaysRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUserHolidaysHeaders headers = new GetUserHolidaysHeaders();
        return this.getUserHolidaysWithOptions(request, headers, runtime);
    }

    public GetUserHolidaysResponse getUserHolidaysWithOptions(GetUserHolidaysRequest request, GetUserHolidaysHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetUserHolidays", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/holidays", "json", req, runtime), new GetUserHolidaysResponse());
    }

    public SyncScheduleInfoResponse syncScheduleInfo(SyncScheduleInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SyncScheduleInfoHeaders headers = new SyncScheduleInfoHeaders();
        return this.syncScheduleInfoWithOptions(request, headers, runtime);
    }

    public SyncScheduleInfoResponse syncScheduleInfoWithOptions(SyncScheduleInfoRequest request, SyncScheduleInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("SyncScheduleInfo", "attendance_1.0", "HTTP", "PUT", "AK", "/v1.0/attendance/schedules/additionalInfo", "none", req, runtime), new SyncScheduleInfoResponse());
    }
}
