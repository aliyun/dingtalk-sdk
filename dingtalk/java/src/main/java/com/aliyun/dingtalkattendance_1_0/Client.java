// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkattendance_1_0.models.*;

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
     * <p>添加假期规则</p>
     * 
     * @param request AddLeaveTypeRequest
     * @param headers AddLeaveTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddLeaveTypeResponse
     */
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

        if (!com.aliyun.teautil.Common.isUnset(request.freedomLeave)) {
            body.put("freedomLeave", request.freedomLeave);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hoursInPerDay)) {
            body.put("hoursInPerDay", request.hoursInPerDay);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaveCertificate)) {
            body.put("leaveCertificate", request.leaveCertificate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaveHourCeil)) {
            body.put("leaveHourCeil", request.leaveHourCeil);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaveName)) {
            body.put("leaveName", request.leaveName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaveTimeCeil)) {
            body.put("leaveTimeCeil", request.leaveTimeCeil);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaveTimeCeilMinUnit)) {
            body.put("leaveTimeCeilMinUnit", request.leaveTimeCeilMinUnit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaveViewUnit)) {
            body.put("leaveViewUnit", request.leaveViewUnit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxLeaveTime)) {
            body.put("maxLeaveTime", request.maxLeaveTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.minLeaveHour)) {
            body.put("minLeaveHour", request.minLeaveHour);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.naturalDayLeave)) {
            body.put("naturalDayLeave", request.naturalDayLeave);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.paidLeave)) {
            body.put("paidLeave", request.paidLeave);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.submitTimeRule)) {
            body.put("submitTimeRule", request.submitTimeRule);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.visibilityRules)) {
            body.put("visibilityRules", request.visibilityRules);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.whenCanLeave)) {
            body.put("whenCanLeave", request.whenCanLeave);
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

    /**
     * <b>summary</b> : 
     * <p>添加假期规则</p>
     * 
     * @param request AddLeaveTypeRequest
     * @return AddLeaveTypeResponse
     */
    public AddLeaveTypeResponse addLeaveType(AddLeaveTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddLeaveTypeHeaders headers = new AddLeaveTypeHeaders();
        return this.addLeaveTypeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量给考勤组添加蓝牙设备</p>
     * 
     * @param request AttendanceBleDevicesAddRequest
     * @param headers AttendanceBleDevicesAddHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AttendanceBleDevicesAddResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>批量给考勤组添加蓝牙设备</p>
     * 
     * @param request AttendanceBleDevicesAddRequest
     * @return AttendanceBleDevicesAddResponse
     */
    public AttendanceBleDevicesAddResponse attendanceBleDevicesAdd(AttendanceBleDevicesAddRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AttendanceBleDevicesAddHeaders headers = new AttendanceBleDevicesAddHeaders();
        return this.attendanceBleDevicesAddWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询蓝牙设备</p>
     * 
     * @param request AttendanceBleDevicesQueryRequest
     * @param headers AttendanceBleDevicesQueryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AttendanceBleDevicesQueryResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>批量查询蓝牙设备</p>
     * 
     * @param request AttendanceBleDevicesQueryRequest
     * @return AttendanceBleDevicesQueryResponse
     */
    public AttendanceBleDevicesQueryResponse attendanceBleDevicesQuery(AttendanceBleDevicesQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AttendanceBleDevicesQueryHeaders headers = new AttendanceBleDevicesQueryHeaders();
        return this.attendanceBleDevicesQueryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量删除考勤组的蓝牙设备</p>
     * 
     * @param request AttendanceBleDevicesRemoveRequest
     * @param headers AttendanceBleDevicesRemoveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AttendanceBleDevicesRemoveResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>批量删除考勤组的蓝牙设备</p>
     * 
     * @param request AttendanceBleDevicesRemoveRequest
     * @return AttendanceBleDevicesRemoveResponse
     */
    public AttendanceBleDevicesRemoveResponse attendanceBleDevicesRemove(AttendanceBleDevicesRemoveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AttendanceBleDevicesRemoveHeaders headers = new AttendanceBleDevicesRemoveHeaders();
        return this.attendanceBleDevicesRemoveWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量修改考勤结果</p>
     * 
     * @param request BatchBossCheckRequest
     * @param headers BatchBossCheckHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchBossCheckResponse
     */
    public BatchBossCheckResponse batchBossCheckWithOptions(BatchBossCheckRequest request, BatchBossCheckHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.models)) {
            body.put("models", request.models);
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
            new TeaPair("action", "BatchBossCheck"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/results/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchBossCheckResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量修改考勤结果</p>
     * 
     * @param request BatchBossCheckRequest
     * @return BatchBossCheckResponse
     */
    public BatchBossCheckResponse batchBossCheck(BatchBossCheckRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchBossCheckHeaders headers = new BatchBossCheckHeaders();
        return this.batchBossCheckWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>预计算时长</p>
     * 
     * @param request CalculateDurationRequest
     * @param headers CalculateDurationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CalculateDurationResponse
     */
    public CalculateDurationResponse calculateDurationWithOptions(CalculateDurationRequest request, CalculateDurationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.calculateModel)) {
            body.put("calculateModel", request.calculateModel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.durationUnit)) {
            body.put("durationUnit", request.durationUnit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fromTime)) {
            body.put("fromTime", request.fromTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaveCode)) {
            body.put("leaveCode", request.leaveCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toTime)) {
            body.put("toTime", request.toTime);
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
            new TeaPair("action", "CalculateDuration"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/approvals/durations/calculate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CalculateDurationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>预计算时长</p>
     * 
     * @param request CalculateDurationRequest
     * @return CalculateDurationResponse
     */
    public CalculateDurationResponse calculateDuration(CalculateDurationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CalculateDurationHeaders headers = new CalculateDurationHeaders();
        return this.calculateDurationWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>针对某些员工某段时间内封账状态的查询</p>
     * 
     * @param request CheckClosingAccountRequest
     * @param headers CheckClosingAccountHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CheckClosingAccountResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>针对某些员工某段时间内封账状态的查询</p>
     * 
     * @param request CheckClosingAccountRequest
     * @return CheckClosingAccountResponse
     */
    public CheckClosingAccountResponse checkClosingAccount(CheckClosingAccountRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CheckClosingAccountHeaders headers = new CheckClosingAccountHeaders();
        return this.checkClosingAccountWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>考勤资源的写权限查询</p>
     * 
     * @param request CheckWritePermissionRequest
     * @param headers CheckWritePermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CheckWritePermissionResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>考勤资源的写权限查询</p>
     * 
     * @param request CheckWritePermissionRequest
     * @return CheckWritePermissionResponse
     */
    public CheckWritePermissionResponse checkWritePermission(CheckWritePermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CheckWritePermissionHeaders headers = new CheckWritePermissionHeaders();
        return this.checkWritePermissionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建考勤打卡审批单</p>
     * 
     * @param request CreateApproveRequest
     * @param headers CreateApproveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateApproveResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>创建考勤打卡审批单</p>
     * 
     * @param request CreateApproveRequest
     * @return CreateApproveResponse
     */
    public CreateApproveResponse createApprove(CreateApproveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateApproveHeaders headers = new CreateApproveHeaders();
        return this.createApproveWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>撤销请假</p>
     * 
     * @param request DeleteLeaveRequestRequest
     * @param headers DeleteLeaveRequestHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteLeaveRequestResponse
     */
    public DeleteLeaveRequestResponse deleteLeaveRequestWithOptions(String unionId, DeleteLeaveRequestRequest request, DeleteLeaveRequestHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.outerId)) {
            body.put("outerId", request.outerId);
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
            new TeaPair("action", "DeleteLeaveRequest"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/users/" + unionId + "/vacations/records/revoke"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteLeaveRequestResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>撤销请假</p>
     * 
     * @param request DeleteLeaveRequestRequest
     * @return DeleteLeaveRequestResponse
     */
    public DeleteLeaveRequestResponse deleteLeaveRequest(String unionId, DeleteLeaveRequestRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteLeaveRequestHeaders headers = new DeleteLeaveRequestHeaders();
        return this.deleteLeaveRequestWithOptions(unionId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除水印模板</p>
     * 
     * @param request DeleteWaterMarkTemplateRequest
     * @param headers DeleteWaterMarkTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteWaterMarkTemplateResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>删除水印模板</p>
     * 
     * @param request DeleteWaterMarkTemplateRequest
     * @return DeleteWaterMarkTemplateResponse
     */
    public DeleteWaterMarkTemplateResponse deleteWaterMarkTemplate(DeleteWaterMarkTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteWaterMarkTemplateHeaders headers = new DeleteWaterMarkTemplateHeaders();
        return this.deleteWaterMarkTemplateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>钉钉安全检查</p>
     * 
     * @param request DingTalkSecurityCheckRequest
     * @param headers DingTalkSecurityCheckHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DingTalkSecurityCheckResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>钉钉安全检查</p>
     * 
     * @param request DingTalkSecurityCheckRequest
     * @return DingTalkSecurityCheckResponse
     */
    public DingTalkSecurityCheckResponse dingTalkSecurityCheck(DingTalkSecurityCheckRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DingTalkSecurityCheckHeaders headers = new DingTalkSecurityCheckHeaders();
        return this.dingTalkSecurityCheckWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询管理员管理范围下的userid</p>
     * 
     * @param request GetATManageScopeRequest
     * @param headers GetATManageScopeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetATManageScopeResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>查询管理员管理范围下的userid</p>
     * 
     * @param request GetATManageScopeRequest
     * @return GetATManageScopeResponse
     */
    public GetATManageScopeResponse getATManageScope(GetATManageScopeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetATManageScopeHeaders headers = new GetATManageScopeHeaders();
        return this.getATManageScopeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取补卡规则列表</p>
     * 
     * @param request GetAdjustmentsRequest
     * @param headers GetAdjustmentsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAdjustmentsResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>获取补卡规则列表</p>
     * 
     * @param request GetAdjustmentsRequest
     * @return GetAdjustmentsResponse
     */
    public GetAdjustmentsResponse getAdjustments(GetAdjustmentsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAdjustmentsHeaders headers = new GetAdjustmentsHeaders();
        return this.getAdjustmentsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取水印打卡模板</p>
     * 
     * @param request GetCheckInSchemaTemplateRequest
     * @param headers GetCheckInSchemaTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCheckInSchemaTemplateResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>获取水印打卡模板</p>
     * 
     * @param request GetCheckInSchemaTemplateRequest
     * @return GetCheckInSchemaTemplateResponse
     */
    public GetCheckInSchemaTemplateResponse getCheckInSchemaTemplate(GetCheckInSchemaTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCheckInSchemaTemplateHeaders headers = new GetCheckInSchemaTemplateHeaders();
        return this.getCheckInSchemaTemplateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>调用本接口，获取用户签到记录。</p>
     * 
     * @param request GetCheckinRecordByUserRequest
     * @param headers GetCheckinRecordByUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCheckinRecordByUserResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>调用本接口，获取用户签到记录。</p>
     * 
     * @param request GetCheckinRecordByUserRequest
     * @return GetCheckinRecordByUserResponse
     */
    public GetCheckinRecordByUserResponse getCheckinRecordByUser(GetCheckinRecordByUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCheckinRecordByUserHeaders headers = new GetCheckinRecordByUserHeaders();
        return this.getCheckinRecordByUserWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>班次查询（包含已删除班次）</p>
     * 
     * @param headers GetClassWithDeletedHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetClassWithDeletedResponse
     */
    public GetClassWithDeletedResponse getClassWithDeletedWithOptions(String classId, GetClassWithDeletedHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetClassWithDeleted"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/classWithDeleted/" + classId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetClassWithDeletedResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>班次查询（包含已删除班次）</p>
     * @return GetClassWithDeletedResponse
     */
    public GetClassWithDeletedResponse getClassWithDeleted(String classId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetClassWithDeletedHeaders headers = new GetClassWithDeletedHeaders();
        return this.getClassWithDeletedWithOptions(classId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询指定用户的封账规则</p>
     * 
     * @param request GetClosingAccountsRequest
     * @param headers GetClosingAccountsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetClosingAccountsResponse
     */
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
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetClosingAccountsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询指定用户的封账规则</p>
     * 
     * @param request GetClosingAccountsRequest
     * @return GetClosingAccountsResponse
     */
    public GetClosingAccountsResponse getClosingAccounts(GetClosingAccountsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetClosingAccountsHeaders headers = new GetClosingAccountsHeaders();
        return this.getClosingAccountsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取多个用户的智能考勤报表的列值</p>
     * 
     * @param request GetColumnvalsRequest
     * @param headers GetColumnvalsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetColumnvalsResponse
     */
    public GetColumnvalsResponse getColumnvalsWithOptions(GetColumnvalsRequest request, GetColumnvalsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.columnIdList)) {
            body.put("columnIdList", request.columnIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fromDate)) {
            body.put("fromDate", request.fromDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toDate)) {
            body.put("toDate", request.toDate);
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
            new TeaPair("action", "GetColumnvals"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/columnValues/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetColumnvalsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取多个用户的智能考勤报表的列值</p>
     * 
     * @param request GetColumnvalsRequest
     * @return GetColumnvalsResponse
     */
    public GetColumnvalsResponse getColumnvals(GetColumnvalsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetColumnvalsHeaders headers = new GetColumnvalsHeaders();
        return this.getColumnvalsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询员工假期余额变更记录</p>
     * 
     * @param request GetLeaveRecordsRequest
     * @param headers GetLeaveRecordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetLeaveRecordsResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>批量查询员工假期余额变更记录</p>
     * 
     * @param request GetLeaveRecordsRequest
     * @return GetLeaveRecordsResponse
     */
    public GetLeaveRecordsResponse getLeaveRecords(GetLeaveRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetLeaveRecordsHeaders headers = new GetLeaveRecordsHeaders();
        return this.getLeaveRecordsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询假期规则列表</p>
     * 
     * @param request GetLeaveTypeRequest
     * @param headers GetLeaveTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetLeaveTypeResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>查询假期规则列表</p>
     * 
     * @param request GetLeaveTypeRequest
     * @return GetLeaveTypeResponse
     */
    public GetLeaveTypeResponse getLeaveType(GetLeaveTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetLeaveTypeHeaders headers = new GetLeaveTypeHeaders();
        return this.getLeaveTypeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据设备id获取考勤机信息</p>
     * 
     * @param headers GetMachineHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMachineResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>根据设备id获取考勤机信息</p>
     * @return GetMachineResponse
     */
    public GetMachineResponse getMachine(String devId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMachineHeaders headers = new GetMachineHeaders();
        return this.getMachineWithOptions(devId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据设备id获取员工信息</p>
     * 
     * @param request GetMachineUserRequest
     * @param headers GetMachineUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMachineUserResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>根据设备id获取员工信息</p>
     * 
     * @param request GetMachineUserRequest
     * @return GetMachineUserResponse
     */
    public GetMachineUserResponse getMachineUser(String devId, GetMachineUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMachineUserHeaders headers = new GetMachineUserHeaders();
        return this.getMachineUserWithOptions(devId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>假期透支信息查询</p>
     * 
     * @param request GetOverdraftInfoRequest
     * @param headers GetOverdraftInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOverdraftInfoResponse
     */
    public GetOverdraftInfoResponse getOverdraftInfoWithOptions(GetOverdraftInfoRequest request, GetOverdraftInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.leaveCode)) {
            body.put("leaveCode", request.leaveCode);
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
            new TeaPair("action", "GetOverdraftInfo"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/vacations/overdraft/get"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOverdraftInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>假期透支信息查询</p>
     * 
     * @param request GetOverdraftInfoRequest
     * @return GetOverdraftInfoResponse
     */
    public GetOverdraftInfoResponse getOverdraftInfo(GetOverdraftInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOverdraftInfoHeaders headers = new GetOverdraftInfoHeaders();
        return this.getOverdraftInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量获取加班规则设置</p>
     * 
     * @param request GetOvertimeSettingRequest
     * @param headers GetOvertimeSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOvertimeSettingResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>批量获取加班规则设置</p>
     * 
     * @param request GetOvertimeSettingRequest
     * @return GetOvertimeSettingResponse
     */
    public GetOvertimeSettingResponse getOvertimeSetting(GetOvertimeSettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOvertimeSettingHeaders headers = new GetOvertimeSettingHeaders();
        return this.getOvertimeSettingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>班次详情</p>
     * 
     * @param request GetShiftRequest
     * @param headers GetShiftHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetShiftResponse
     */
    public GetShiftResponse getShiftWithOptions(GetShiftRequest request, GetShiftHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.shiftId)) {
            query.put("shiftId", request.shiftId);
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
            new TeaPair("action", "GetShift"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/shifts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetShiftResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>班次详情</p>
     * 
     * @param request GetShiftRequest
     * @return GetShiftResponse
     */
    public GetShiftResponse getShift(GetShiftRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetShiftHeaders headers = new GetShiftHeaders();
        return this.getShiftWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取考勤组列表详情</p>
     * 
     * @param request GetSimpleGroupsRequest
     * @param headers GetSimpleGroupsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSimpleGroupsResponse
     */
    public GetSimpleGroupsResponse getSimpleGroupsWithOptions(GetSimpleGroupsRequest request, GetSimpleGroupsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetSimpleGroups"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/groupDetails"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSimpleGroupsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取考勤组列表详情</p>
     * 
     * @param request GetSimpleGroupsRequest
     * @return GetSimpleGroupsResponse
     */
    public GetSimpleGroupsResponse getSimpleGroups(GetSimpleGroupsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSimpleGroupsHeaders headers = new GetSimpleGroupsHeaders();
        return this.getSimpleGroupsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>加班规则列表</p>
     * 
     * @param request GetSimpleOvertimeSettingRequest
     * @param headers GetSimpleOvertimeSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSimpleOvertimeSettingResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>加班规则列表</p>
     * 
     * @param request GetSimpleOvertimeSettingRequest
     * @return GetSimpleOvertimeSettingResponse
     */
    public GetSimpleOvertimeSettingResponse getSimpleOvertimeSetting(GetSimpleOvertimeSettingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSimpleOvertimeSettingHeaders headers = new GetSimpleOvertimeSettingHeaders();
        return this.getSimpleOvertimeSettingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询员工某段时间的假期</p>
     * 
     * @param request GetUserHolidaysRequest
     * @param headers GetUserHolidaysHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserHolidaysResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>查询员工某段时间的假期</p>
     * 
     * @param request GetUserHolidaysRequest
     * @return GetUserHolidaysResponse
     */
    public GetUserHolidaysResponse getUserHolidays(GetUserHolidaysRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserHolidaysHeaders headers = new GetUserHolidaysHeaders();
        return this.getUserHolidaysWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建考勤组</p>
     * 
     * @param request GroupAddRequest
     * @param headers GroupAddHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GroupAddResponse
     */
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

        if (!com.aliyun.teautil.Common.isUnset(request.onlyMachineCheck)) {
            body.put("onlyMachineCheck", request.onlyMachineCheck);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openCameraCheck)) {
            body.put("openCameraCheck", request.openCameraCheck);
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

    /**
     * <b>summary</b> : 
     * <p>创建考勤组</p>
     * 
     * @param request GroupAddRequest
     * @return GroupAddResponse
     */
    public GroupAddResponse groupAdd(GroupAddRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GroupAddHeaders headers = new GroupAddHeaders();
        return this.groupAddWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改考勤组</p>
     * 
     * @param request GroupUpdateRequest
     * @param headers GroupUpdateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GroupUpdateResponse
     */
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

        if (!com.aliyun.teautil.Common.isUnset(request.enableOutsideCameraCheck)) {
            body.put("enableOutsideCameraCheck", request.enableOutsideCameraCheck);
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

        if (!com.aliyun.teautil.Common.isUnset(request.freecheckDayStartMinOffset)) {
            body.put("freecheckDayStartMinOffset", request.freecheckDayStartMinOffset);
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

        if (!com.aliyun.teautil.Common.isUnset(request.onlyMachineCheck)) {
            body.put("onlyMachineCheck", request.onlyMachineCheck);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openCameraCheck)) {
            body.put("openCameraCheck", request.openCameraCheck);
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

    /**
     * <b>summary</b> : 
     * <p>修改考勤组</p>
     * 
     * @param request GroupUpdateRequest
     * @return GroupUpdateResponse
     */
    public GroupUpdateResponse groupUpdate(GroupUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GroupUpdateHeaders headers = new GroupUpdateHeaders();
        return this.groupUpdateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>生态系统假期初始化查询余额接口</p>
     * 
     * @param request InitAndGetLeaveALlocationQuotasRequest
     * @param headers InitAndGetLeaveALlocationQuotasHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InitAndGetLeaveALlocationQuotasResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>生态系统假期初始化查询余额接口</p>
     * 
     * @param request InitAndGetLeaveALlocationQuotasRequest
     * @return InitAndGetLeaveALlocationQuotasResponse
     */
    public InitAndGetLeaveALlocationQuotasResponse initAndGetLeaveALlocationQuotas(InitAndGetLeaveALlocationQuotasRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InitAndGetLeaveALlocationQuotasHeaders headers = new InitAndGetLeaveALlocationQuotasHeaders();
        return this.initAndGetLeaveALlocationQuotasWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户某段时间内同步到考勤的审批单信息</p>
     * 
     * @param request ListApproveByUsersRequest
     * @param headers ListApproveByUsersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListApproveByUsersResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>获取用户某段时间内同步到考勤的审批单信息</p>
     * 
     * @param request ListApproveByUsersRequest
     * @return ListApproveByUsersResponse
     */
    public ListApproveByUsersResponse listApproveByUsers(ListApproveByUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListApproveByUsersHeaders headers = new ListApproveByUsersHeaders();
        return this.listApproveByUsersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改水印模板</p>
     * 
     * @param request ModifyWaterMarkTemplateRequest
     * @param headers ModifyWaterMarkTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ModifyWaterMarkTemplateResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>修改水印模板</p>
     * 
     * @param request ModifyWaterMarkTemplateRequest
     * @return ModifyWaterMarkTemplateResponse
     */
    public ModifyWaterMarkTemplateResponse modifyWaterMarkTemplate(ModifyWaterMarkTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ModifyWaterMarkTemplateHeaders headers = new ModifyWaterMarkTemplateHeaders();
        return this.modifyWaterMarkTemplateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建考勤打卡审批单</p>
     * 
     * @param request ProcessApproveCreateRequest
     * @param headers ProcessApproveCreateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ProcessApproveCreateResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>创建考勤打卡审批单</p>
     * 
     * @param request ProcessApproveCreateRequest
     * @return ProcessApproveCreateResponse
     */
    public ProcessApproveCreateResponse processApproveCreate(ProcessApproveCreateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ProcessApproveCreateHeaders headers = new ProcessApproveCreateHeaders();
        return this.processApproveCreateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>通知审批通过</p>
     * 
     * @param request ProcessApproveFinishRequest
     * @param headers ProcessApproveFinishHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ProcessApproveFinishResponse
     */
    public ProcessApproveFinishResponse processApproveFinishWithOptions(ProcessApproveFinishRequest request, ProcessApproveFinishHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.approveId)) {
            body.put("approveId", request.approveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jumpUrl)) {
            body.put("jumpUrl", request.jumpUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.overTimeToMore)) {
            body.put("overTimeToMore", request.overTimeToMore);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.overtimeDuration)) {
            body.put("overtimeDuration", request.overtimeDuration);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subType)) {
            body.put("subType", request.subType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagName)) {
            body.put("tagName", request.tagName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.topCalculateApproveDurationParam)) {
            body.put("topCalculateApproveDurationParam", request.topCalculateApproveDurationParam);
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
            new TeaPair("action", "ProcessApproveFinish"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/approvals/finish"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ProcessApproveFinishResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>通知审批通过</p>
     * 
     * @param request ProcessApproveFinishRequest
     * @return ProcessApproveFinishResponse
     */
    public ProcessApproveFinishResponse processApproveFinish(ProcessApproveFinishRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ProcessApproveFinishHeaders headers = new ProcessApproveFinishHeaders();
        return this.processApproveFinishWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>扣减员工假期余额</p>
     * 
     * @param request ReduceQuotaWithLeaveRecordRequest
     * @param headers ReduceQuotaWithLeaveRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ReduceQuotaWithLeaveRecordResponse
     */
    public ReduceQuotaWithLeaveRecordResponse reduceQuotaWithLeaveRecordWithOptions(String unionId, ReduceQuotaWithLeaveRecordRequest request, ReduceQuotaWithLeaveRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaveCode)) {
            body.put("leaveCode", request.leaveCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerId)) {
            body.put("outerId", request.outerId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.quotaNum)) {
            body.put("quotaNum", request.quotaNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reason)) {
            body.put("reason", request.reason);
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
            new TeaPair("action", "ReduceQuotaWithLeaveRecord"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/users/" + unionId + "/vacations/records/modify"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ReduceQuotaWithLeaveRecordResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>扣减员工假期余额</p>
     * 
     * @param request ReduceQuotaWithLeaveRecordRequest
     * @return ReduceQuotaWithLeaveRecordResponse
     */
    public ReduceQuotaWithLeaveRecordResponse reduceQuotaWithLeaveRecord(String unionId, ReduceQuotaWithLeaveRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReduceQuotaWithLeaveRecordHeaders headers = new ReduceQuotaWithLeaveRecordHeaders();
        return this.reduceQuotaWithLeaveRecordWithOptions(unionId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改假期规则来源</p>
     * 
     * @param request RetainLeaveTypesRequest
     * @param headers RetainLeaveTypesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RetainLeaveTypesResponse
     */
    public RetainLeaveTypesResponse retainLeaveTypesWithOptions(RetainLeaveTypesRequest request, RetainLeaveTypesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.leaveCodes)) {
            body.put("leaveCodes", request.leaveCodes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
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
            new TeaPair("action", "RetainLeaveTypes"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/vacations/types/change"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RetainLeaveTypesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改假期规则来源</p>
     * 
     * @param request RetainLeaveTypesRequest
     * @return RetainLeaveTypesResponse
     */
    public RetainLeaveTypesResponse retainLeaveTypes(RetainLeaveTypesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RetainLeaveTypesHeaders headers = new RetainLeaveTypesHeaders();
        return this.retainLeaveTypesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>提供给高级假期的试用订单回退</p>
     * 
     * @param request ReverseTrialAdvancedLeaveRequest
     * @param headers ReverseTrialAdvancedLeaveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ReverseTrialAdvancedLeaveResponse
     */
    public ReverseTrialAdvancedLeaveResponse reverseTrialAdvancedLeaveWithOptions(ReverseTrialAdvancedLeaveRequest request, ReverseTrialAdvancedLeaveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.servCode)) {
            query.put("servCode", request.servCode);
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
            new TeaPair("action", "ReverseTrialAdvancedLeave"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/leaves/reverse"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ReverseTrialAdvancedLeaveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>提供给高级假期的试用订单回退</p>
     * 
     * @param request ReverseTrialAdvancedLeaveRequest
     * @return ReverseTrialAdvancedLeaveResponse
     */
    public ReverseTrialAdvancedLeaveResponse reverseTrialAdvancedLeave(ReverseTrialAdvancedLeaveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReverseTrialAdvancedLeaveHeaders headers = new ReverseTrialAdvancedLeaveHeaders();
        return this.reverseTrialAdvancedLeaveWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>薪酬三方数据写入</p>
     * 
     * @param request SalaryThirdDataIntegrationRequest
     * @param headers SalaryThirdDataIntegrationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SalaryThirdDataIntegrationResponse
     */
    public SalaryThirdDataIntegrationResponse salaryThirdDataIntegrationWithOptions(SalaryThirdDataIntegrationRequest request, SalaryThirdDataIntegrationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.items)) {
            body.put("items", request.items);
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
            new TeaPair("action", "SalaryThirdDataIntegration"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/salaries/tripartiteDatas/write"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SalaryThirdDataIntegrationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>薪酬三方数据写入</p>
     * 
     * @param request SalaryThirdDataIntegrationRequest
     * @return SalaryThirdDataIntegrationResponse
     */
    public SalaryThirdDataIntegrationResponse salaryThirdDataIntegration(SalaryThirdDataIntegrationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SalaryThirdDataIntegrationHeaders headers = new SalaryThirdDataIntegrationHeaders();
        return this.salaryThirdDataIntegrationWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>新增水印签到模板</p>
     * 
     * @param request SaveCustomWaterMarkTemplateRequest
     * @param headers SaveCustomWaterMarkTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveCustomWaterMarkTemplateResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>新增水印签到模板</p>
     * 
     * @param request SaveCustomWaterMarkTemplateRequest
     * @return SaveCustomWaterMarkTemplateResponse
     */
    public SaveCustomWaterMarkTemplateResponse saveCustomWaterMarkTemplate(SaveCustomWaterMarkTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveCustomWaterMarkTemplateHeaders headers = new SaveCustomWaterMarkTemplateHeaders();
        return this.saveCustomWaterMarkTemplateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建班次</p>
     * 
     * @param request ShiftAddRequest
     * @param headers ShiftAddHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ShiftAddResponse
     */
    public ShiftAddResponse shiftAddWithOptions(ShiftAddRequest request, ShiftAddHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.owner)) {
            body.put("owner", request.owner);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sections)) {
            body.put("sections", request.sections);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serviceId)) {
            body.put("serviceId", request.serviceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.setting)) {
            body.put("setting", request.setting);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.shiftId)) {
            body.put("shiftId", request.shiftId);
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
            new TeaPair("action", "ShiftAdd"),
            new TeaPair("version", "attendance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/attendance/shifts"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ShiftAddResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建班次</p>
     * 
     * @param request ShiftAddRequest
     * @return ShiftAddResponse
     */
    public ShiftAddResponse shiftAdd(ShiftAddRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ShiftAddHeaders headers = new ShiftAddHeaders();
        return this.shiftAddWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>用于考勤排班附加信息，例如打卡位置，打卡wifi等</p>
     * 
     * @param request SyncScheduleInfoRequest
     * @param headers SyncScheduleInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SyncScheduleInfoResponse
     */
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

    /**
     * <b>summary</b> : 
     * <p>用于考勤排班附加信息，例如打卡位置，打卡wifi等</p>
     * 
     * @param request SyncScheduleInfoRequest
     * @return SyncScheduleInfoResponse
     */
    public SyncScheduleInfoResponse syncScheduleInfo(SyncScheduleInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncScheduleInfoHeaders headers = new SyncScheduleInfoHeaders();
        return this.syncScheduleInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新假期规则</p>
     * 
     * @param request UpdateLeaveTypeRequest
     * @param headers UpdateLeaveTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateLeaveTypeResponse
     */
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

        if (!com.aliyun.teautil.Common.isUnset(request.freedomLeave)) {
            body.put("freedomLeave", request.freedomLeave);
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

    /**
     * <b>summary</b> : 
     * <p>更新假期规则</p>
     * 
     * @param request UpdateLeaveTypeRequest
     * @return UpdateLeaveTypeResponse
     */
    public UpdateLeaveTypeResponse updateLeaveType(UpdateLeaveTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateLeaveTypeHeaders headers = new UpdateLeaveTypeHeaders();
        return this.updateLeaveTypeWithOptions(request, headers, runtime);
    }
}
