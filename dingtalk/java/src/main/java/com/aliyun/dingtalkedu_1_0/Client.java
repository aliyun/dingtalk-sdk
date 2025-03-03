// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkedu_1_0.models.*;

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
     * <p>视讯paas机具激活</p>
     * 
     * @param request ActivateDeviceRequest
     * @param headers ActivateDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ActivateDeviceResponse
     */
    public ActivateDeviceResponse activateDeviceWithOptions(ActivateDeviceRequest request, ActivateDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.licenseKey)) {
            body.put("licenseKey", request.licenseKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.model)) {
            body.put("model", request.model);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
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
            new TeaPair("action", "ActivateDevice"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/vpaas/devices/activate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ActivateDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>视讯paas机具激活</p>
     * 
     * @param request ActivateDeviceRequest
     * @return ActivateDeviceResponse
     */
    public ActivateDeviceResponse activateDevice(ActivateDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ActivateDeviceHeaders headers = new ActivateDeviceHeaders();
        return this.activateDeviceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>高校校友会批量创建部门</p>
     * 
     * @param request AddCollegeAlumniDeptsRequest
     * @param headers AddCollegeAlumniDeptsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddCollegeAlumniDeptsResponse
     */
    public AddCollegeAlumniDeptsResponse addCollegeAlumniDeptsWithOptions(AddCollegeAlumniDeptsRequest request, AddCollegeAlumniDeptsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.depts)) {
            body.put("depts", request.depts);
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
            new TeaPair("action", "AddCollegeAlumniDepts"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeAlumni/depts/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddCollegeAlumniDeptsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>高校校友会批量创建部门</p>
     * 
     * @param request AddCollegeAlumniDeptsRequest
     * @return AddCollegeAlumniDeptsResponse
     */
    public AddCollegeAlumniDeptsResponse addCollegeAlumniDepts(AddCollegeAlumniDeptsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddCollegeAlumniDeptsHeaders headers = new AddCollegeAlumniDeptsHeaders();
        return this.addCollegeAlumniDeptsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>高校校友会新增校友信息</p>
     * 
     * @param request AddCollegeAlumniUserInfoRequest
     * @param headers AddCollegeAlumniUserInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddCollegeAlumniUserInfoResponse
     */
    public AddCollegeAlumniUserInfoResponse addCollegeAlumniUserInfoWithOptions(AddCollegeAlumniUserInfoRequest request, AddCollegeAlumniUserInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.address)) {
            body.put("address", request.address);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptIds)) {
            body.put("deptIds", request.deptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.email)) {
            body.put("email", request.email);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.intake)) {
            body.put("intake", request.intake);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outtake)) {
            body.put("outtake", request.outtake);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentNumber)) {
            body.put("studentNumber", request.studentNumber);
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
            new TeaPair("action", "AddCollegeAlumniUserInfo"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeAlumni/userInfos"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddCollegeAlumniUserInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>高校校友会新增校友信息</p>
     * 
     * @param request AddCollegeAlumniUserInfoRequest
     * @return AddCollegeAlumniUserInfoResponse
     */
    public AddCollegeAlumniUserInfoResponse addCollegeAlumniUserInfo(AddCollegeAlumniUserInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddCollegeAlumniUserInfoHeaders headers = new AddCollegeAlumniUserInfoHeaders();
        return this.addCollegeAlumniUserInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建高校账号用户</p>
     * 
     * @param request AddCollegeContactExclusiveRequest
     * @param headers AddCollegeContactExclusiveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddCollegeContactExclusiveResponse
     */
    public AddCollegeContactExclusiveResponse addCollegeContactExclusiveWithOptions(AddCollegeContactExclusiveRequest request, AddCollegeContactExclusiveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.avatarMediaId)) {
            body.put("avatarMediaId", request.avatarMediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptIdList)) {
            body.put("deptIdList", request.deptIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptOrderList)) {
            body.put("deptOrderList", request.deptOrderList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptPositionSet)) {
            body.put("deptPositionSet", request.deptPositionSet);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptTitleList)) {
            body.put("deptTitleList", request.deptTitleList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.email)) {
            body.put("email", request.email);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.empType)) {
            body.put("empType", request.empType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.exclusiveAccount)) {
            body.put("exclusiveAccount", request.exclusiveAccount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.exclusiveAccountType)) {
            body.put("exclusiveAccountType", request.exclusiveAccountType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hiredDate)) {
            body.put("hiredDate", request.hiredDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.initPassword)) {
            body.put("initPassword", request.initPassword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jobNumber)) {
            body.put("jobNumber", request.jobNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.loginIdType)) {
            body.put("loginIdType", request.loginIdType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mainDeptId)) {
            body.put("mainDeptId", request.mainDeptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerUserid)) {
            body.put("managerUserid", request.managerUserid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nickname)) {
            body.put("nickname", request.nickname);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgEmail)) {
            body.put("orgEmail", request.orgEmail);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgEmailType)) {
            body.put("orgEmailType", request.orgEmailType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendActiveSms)) {
            body.put("sendActiveSms", request.sendActiveSms);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.seniorMode)) {
            body.put("seniorMode", request.seniorMode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.telephone)) {
            body.put("telephone", request.telephone);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userid)) {
            body.put("userid", request.userid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.workPlace)) {
            body.put("workPlace", request.workPlace);
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
            new TeaPair("action", "AddCollegeContactExclusive"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/exclusiveAccounts/users"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddCollegeContactExclusiveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建高校账号用户</p>
     * 
     * @param request AddCollegeContactExclusiveRequest
     * @return AddCollegeContactExclusiveResponse
     */
    public AddCollegeContactExclusiveResponse addCollegeContactExclusive(AddCollegeContactExclusiveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddCollegeContactExclusiveHeaders headers = new AddCollegeContactExclusiveHeaders();
        return this.addCollegeContactExclusiveWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建个人账号用户</p>
     * 
     * @param request AddCollegeContactUserRequest
     * @param headers AddCollegeContactUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddCollegeContactUserResponse
     */
    public AddCollegeContactUserResponse addCollegeContactUserWithOptions(AddCollegeContactUserRequest request, AddCollegeContactUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptIdList)) {
            body.put("deptIdList", request.deptIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptOrderList)) {
            body.put("deptOrderList", request.deptOrderList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptPositionSet)) {
            body.put("deptPositionSet", request.deptPositionSet);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptTitleList)) {
            body.put("deptTitleList", request.deptTitleList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.email)) {
            body.put("email", request.email);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.empType)) {
            body.put("empType", request.empType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hideMobile)) {
            body.put("hideMobile", request.hideMobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hiredDate)) {
            body.put("hiredDate", request.hiredDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jobNumber)) {
            body.put("jobNumber", request.jobNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.loginEmail)) {
            body.put("loginEmail", request.loginEmail);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mainDeptId)) {
            body.put("mainDeptId", request.mainDeptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerUserid)) {
            body.put("managerUserid", request.managerUserid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgEmail)) {
            body.put("orgEmail", request.orgEmail);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgEmailType)) {
            body.put("orgEmailType", request.orgEmailType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendActiveSms)) {
            body.put("sendActiveSms", request.sendActiveSms);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.seniorMode)) {
            body.put("seniorMode", request.seniorMode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.telephone)) {
            body.put("telephone", request.telephone);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userid)) {
            body.put("userid", request.userid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.workPlace)) {
            body.put("workPlace", request.workPlace);
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
            new TeaPair("action", "AddCollegeContactUser"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/personalAccounts/users"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddCollegeContactUserResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建个人账号用户</p>
     * 
     * @param request AddCollegeContactUserRequest
     * @return AddCollegeContactUserResponse
     */
    public AddCollegeContactUserResponse addCollegeContactUser(AddCollegeContactUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddCollegeContactUserHeaders headers = new AddCollegeContactUserHeaders();
        return this.addCollegeContactUserWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>增加赛事记录</p>
     * 
     * @param request AddCompetitionRecordRequest
     * @param headers AddCompetitionRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddCompetitionRecordResponse
     */
    public AddCompetitionRecordResponse addCompetitionRecordWithOptions(AddCompetitionRecordRequest request, AddCompetitionRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.competitionCode)) {
            body.put("competitionCode", request.competitionCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupTemplateCode)) {
            body.put("groupTemplateCode", request.groupTemplateCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.joinGroup)) {
            body.put("joinGroup", request.joinGroup);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.participantName)) {
            body.put("participantName", request.participantName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "AddCompetitionRecord"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/competitions/records"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddCompetitionRecordResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>增加赛事记录</p>
     * 
     * @param request AddCompetitionRecordRequest
     * @return AddCompetitionRecordResponse
     */
    public AddCompetitionRecordResponse addCompetitionRecord(AddCompetitionRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddCompetitionRecordHeaders headers = new AddCompetitionRecordHeaders();
        return this.addCompetitionRecordWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加设备</p>
     * 
     * @param request AddDeviceRequest
     * @param headers AddDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddDeviceResponse
     */
    public AddDeviceResponse addDeviceWithOptions(AddDeviceRequest request, AddDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.merchantId)) {
            body.put("merchantId", request.merchantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.model)) {
            body.put("model", request.model);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scene)) {
            body.put("scene", request.scene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
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
            new TeaPair("action", "AddDevice"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/devices"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加设备</p>
     * 
     * @param request AddDeviceRequest
     * @return AddDeviceResponse
     */
    public AddDeviceResponse addDevice(AddDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddDeviceHeaders headers = new AddDeviceHeaders();
        return this.addDeviceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加评价表现数据</p>
     * 
     * @param request AddEvaluatePerformanceRequest
     * @param headers AddEvaluatePerformanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddEvaluatePerformanceResponse
     */
    public AddEvaluatePerformanceResponse addEvaluatePerformanceWithOptions(AddEvaluatePerformanceRequest request, AddEvaluatePerformanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.evaluationData)) {
            body.put("evaluationData", request.evaluationData);
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
            new TeaPair("action", "AddEvaluatePerformance"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/evaluations"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddEvaluatePerformanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加评价表现数据</p>
     * 
     * @param request AddEvaluatePerformanceRequest
     * @return AddEvaluatePerformanceResponse
     */
    public AddEvaluatePerformanceResponse addEvaluatePerformance(AddEvaluatePerformanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddEvaluatePerformanceHeaders headers = new AddEvaluatePerformanceHeaders();
        return this.addEvaluatePerformanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加学校配置</p>
     * 
     * @param request AddSchoolConfigRequest
     * @param headers AddSchoolConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddSchoolConfigResponse
     */
    public AddSchoolConfigResponse addSchoolConfigWithOptions(AddSchoolConfigRequest request, AddSchoolConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorName)) {
            body.put("operatorName", request.operatorName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.temperatureUpLimit)) {
            body.put("temperatureUpLimit", request.temperatureUpLimit);
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
            new TeaPair("action", "AddSchoolConfig"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/schools/configurations"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddSchoolConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加学校配置</p>
     * 
     * @param request AddSchoolConfigRequest
     * @return AddSchoolConfigResponse
     */
    public AddSchoolConfigResponse addSchoolConfig(AddSchoolConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddSchoolConfigHeaders headers = new AddSchoolConfigHeaders();
        return this.addSchoolConfigWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改课程</p>
     * 
     * @param request AdjustCourseRequest
     * @param headers AdjustCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AdjustCourseResponse
     */
    public AdjustCourseResponse adjustCourseWithOptions(AdjustCourseRequest request, AdjustCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attributes)) {
            body.put("attributes", request.attributes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.className)) {
            body.put("className", request.className);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classRoomId)) {
            body.put("classRoomId", request.classRoomId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classRoomName)) {
            body.put("classRoomName", request.classRoomName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classType)) {
            body.put("classType", request.classType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseCode)) {
            body.put("courseCode", request.courseCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseDate)) {
            body.put("courseDate", request.courseDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseName)) {
            body.put("courseName", request.courseName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseWeek)) {
            body.put("courseWeek", request.courseWeek);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCourseId)) {
            body.put("isvCourseId", request.isvCourseId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memo)) {
            body.put("memo", request.memo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schoolYear)) {
            body.put("schoolYear", request.schoolYear);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.semester)) {
            body.put("semester", request.semester);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teachWeek)) {
            body.put("teachWeek", request.teachWeek);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeslotName)) {
            body.put("timeslotName", request.timeslotName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeslotNum)) {
            body.put("timeslotNum", request.timeslotNum);
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
            new TeaPair("action", "AdjustCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/courses/adjust"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AdjustCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改课程</p>
     * 
     * @param request AdjustCourseRequest
     * @return AdjustCourseResponse
     */
    public AdjustCourseResponse adjustCourse(AdjustCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AdjustCourseHeaders headers = new AdjustCourseHeaders();
        return this.adjustCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改教育套件</p>
     * 
     * @param request AdjustKitRequest
     * @param headers AdjustKitHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AdjustKitResponse
     */
    public AdjustKitResponse adjustKitWithOptions(AdjustKitRequest request, AdjustKitHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attributes)) {
            body.put("attributes", request.attributes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvProductScene)) {
            body.put("isvProductScene", request.isvProductScene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openEndTime)) {
            body.put("openEndTime", request.openEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openStartTime)) {
            body.put("openStartTime", request.openStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openUserId)) {
            body.put("openUserId", request.openUserId);
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
            new TeaPair("action", "AdjustKit"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/records/adjust"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AdjustKitResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改教育套件</p>
     * 
     * @param request AdjustKitRequest
     * @return AdjustKitResponse
     */
    public AdjustKitResponse adjustKit(AdjustKitRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AdjustKitHeaders headers = new AdjustKitHeaders();
        return this.adjustKitWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>进行分班</p>
     * 
     * @param request AssignClassRequest
     * @param headers AssignClassHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AssignClassResponse
     */
    public AssignClassResponse assignClassWithOptions(AssignClassRequest request, AssignClassHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            body.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isFinish)) {
            body.put("isFinish", request.isFinish);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            body.put("studentId", request.studentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            body.put("taskId", request.taskId);
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
            new TeaPair("action", "AssignClass"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/newGrades/tasks/students/classes/assign"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AssignClassResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>进行分班</p>
     * 
     * @param request AssignClassRequest
     * @return AssignClassResponse
     */
    public AssignClassResponse assignClass(AssignClassRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AssignClassHeaders headers = new AssignClassHeaders();
        return this.assignClassWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量创建打卡</p>
     * 
     * @param request BatchCreateRequest
     * @param headers BatchCreateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchCreateResponse
     */
    public BatchCreateResponse batchCreateWithOptions(BatchCreateRequest request, BatchCreateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cardBizCode)) {
            body.put("cardBizCode", request.cardBizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.identifier)) {
            body.put("identifier", request.identifier);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jsVersion)) {
            body.put("jsVersion", request.jsVersion);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceType)) {
            body.put("sourceType", request.sourceType);
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
            new TeaPair("action", "BatchCreate"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/cards"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchCreateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量创建打卡</p>
     * 
     * @param request BatchCreateRequest
     * @return BatchCreateResponse
     */
    public BatchCreateResponse batchCreate(BatchCreateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchCreateHeaders headers = new BatchCreateHeaders();
        return this.batchCreateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量创建课程</p>
     * 
     * @param request BatchCreateCourseRequest
     * @param headers BatchCreateCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchCreateCourseResponse
     */
    public BatchCreateCourseResponse batchCreateCourseWithOptions(BatchCreateCourseRequest request, BatchCreateCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            body.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.className)) {
            body.put("className", request.className);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classType)) {
            body.put("classType", request.classType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseDetailItemList)) {
            body.put("courseDetailItemList", request.courseDetailItemList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schoolYear)) {
            body.put("schoolYear", request.schoolYear);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.semester)) {
            body.put("semester", request.semester);
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
            new TeaPair("action", "BatchCreateCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/courses/batchCreate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchCreateCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量创建课程</p>
     * 
     * @param request BatchCreateCourseRequest
     * @return BatchCreateCourseResponse
     */
    public BatchCreateCourseResponse batchCreateCourse(BatchCreateCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchCreateCourseHeaders headers = new BatchCreateCourseHeaders();
        return this.batchCreateCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量创建学生班级</p>
     * 
     * @param request BatchCreateStudentClassRequest
     * @param headers BatchCreateStudentClassHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchCreateStudentClassResponse
     */
    public BatchCreateStudentClassResponse batchCreateStudentClassWithOptions(BatchCreateStudentClassRequest request, BatchCreateStudentClassHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            body.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.className)) {
            body.put("className", request.className);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classType)) {
            body.put("classType", request.classType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentList)) {
            body.put("studentList", request.studentList);
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
            new TeaPair("action", "BatchCreateStudentClass"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/students/classes/batchCreate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchCreateStudentClassResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量创建学生班级</p>
     * 
     * @param request BatchCreateStudentClassRequest
     * @return BatchCreateStudentClassResponse
     */
    public BatchCreateStudentClassResponse batchCreateStudentClass(BatchCreateStudentClassRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchCreateStudentClassHeaders headers = new BatchCreateStudentClassHeaders();
        return this.batchCreateStudentClassWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量创建老师课程</p>
     * 
     * @param request BatchCreateTeacherCourseRequest
     * @param headers BatchCreateTeacherCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchCreateTeacherCourseResponse
     */
    public BatchCreateTeacherCourseResponse batchCreateTeacherCourseWithOptions(BatchCreateTeacherCourseRequest request, BatchCreateTeacherCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherCourseDetailItemList)) {
            body.put("teacherCourseDetailItemList", request.teacherCourseDetailItemList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherName)) {
            body.put("teacherName", request.teacherName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherUserId)) {
            body.put("teacherUserId", request.teacherUserId);
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
            new TeaPair("action", "BatchCreateTeacherCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/teachers/courses/batchCreate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchCreateTeacherCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量创建老师课程</p>
     * 
     * @param request BatchCreateTeacherCourseRequest
     * @return BatchCreateTeacherCourseResponse
     */
    public BatchCreateTeacherCourseResponse batchCreateTeacherCourse(BatchCreateTeacherCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchCreateTeacherCourseHeaders headers = new BatchCreateTeacherCourseHeaders();
        return this.batchCreateTeacherCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量失效课程</p>
     * 
     * @param request BatchInvalidCourseRequest
     * @param headers BatchInvalidCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchInvalidCourseResponse
     */
    public BatchInvalidCourseResponse batchInvalidCourseWithOptions(BatchInvalidCourseRequest request, BatchInvalidCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            body.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCourseId)) {
            body.put("isvCourseId", request.isvCourseId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCourseIds)) {
            body.put("isvCourseIds", request.isvCourseIds);
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
            new TeaPair("action", "BatchInvalidCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/courses/batchInvalid"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchInvalidCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量失效课程</p>
     * 
     * @param request BatchInvalidCourseRequest
     * @return BatchInvalidCourseResponse
     */
    public BatchInvalidCourseResponse batchInvalidCourse(BatchInvalidCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchInvalidCourseHeaders headers = new BatchInvalidCourseHeaders();
        return this.batchInvalidCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>跨组织-批量创建作业</p>
     * 
     * @param request BatchOrgCreateHWRequest
     * @param headers BatchOrgCreateHWHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchOrgCreateHWResponse
     */
    public BatchOrgCreateHWResponse batchOrgCreateHWWithOptions(BatchOrgCreateHWRequest request, BatchOrgCreateHWHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attributes)) {
            body.put("attributes", request.attributes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseName)) {
            body.put("courseName", request.courseName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hwContent)) {
            body.put("hwContent", request.hwContent);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hwDeadline)) {
            body.put("hwDeadline", request.hwDeadline);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hwDeadlineOpen)) {
            body.put("hwDeadlineOpen", request.hwDeadlineOpen);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hwMedia)) {
            body.put("hwMedia", request.hwMedia);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hwPhoto)) {
            body.put("hwPhoto", request.hwPhoto);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hwTitle)) {
            body.put("hwTitle", request.hwTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hwType)) {
            body.put("hwType", request.hwType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hwVideo)) {
            body.put("hwVideo", request.hwVideo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.identifier)) {
            body.put("identifier", request.identifier);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openSelectItemList)) {
            body.put("openSelectItemList", request.openSelectItemList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scheduledRelease)) {
            body.put("scheduledRelease", request.scheduledRelease);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scheduledTime)) {
            body.put("scheduledTime", request.scheduledTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetRole)) {
            body.put("targetRole", request.targetRole);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherName)) {
            body.put("teacherName", request.teacherName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherUserId)) {
            body.put("teacherUserId", request.teacherUserId);
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
            new TeaPair("action", "BatchOrgCreateHW"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/homeworks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchOrgCreateHWResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>跨组织-批量创建作业</p>
     * 
     * @param request BatchOrgCreateHWRequest
     * @return BatchOrgCreateHWResponse
     */
    public BatchOrgCreateHWResponse batchOrgCreateHW(BatchOrgCreateHWRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchOrgCreateHWHeaders headers = new BatchOrgCreateHWHeaders();
        return this.batchOrgCreateHWWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>套件-取消套件任务</p>
     * 
     * @param request CancelKitTaskRequest
     * @param headers CancelKitTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CancelKitTaskResponse
     */
    public CancelKitTaskResponse cancelKitTaskWithOptions(CancelKitTaskRequest request, CancelKitTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.identifier)) {
            body.put("identifier", request.identifier);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
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
            new TeaPair("action", "CancelKitTask"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/tasks/cancel"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CancelKitTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>套件-取消套件任务</p>
     * 
     * @param request CancelKitTaskRequest
     * @return CancelKitTaskResponse
     */
    public CancelKitTaskResponse cancelKitTask(CancelKitTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CancelKitTaskHeaders headers = new CancelKitTaskHeaders();
        return this.cancelKitTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>撤销订单</p>
     * 
     * @param request CancelOrderRequest
     * @param headers CancelOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CancelOrderResponse
     */
    public CancelOrderResponse cancelOrderWithOptions(CancelOrderRequest request, CancelOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.faceId)) {
            body.put("faceId", request.faceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            body.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signature)) {
            body.put("signature", request.signature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timestamp)) {
            body.put("timestamp", request.timestamp);
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
            new TeaPair("action", "CancelOrder"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/orders/cancel"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CancelOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>撤销订单</p>
     * 
     * @param request CancelOrderRequest
     * @return CancelOrderResponse
     */
    public CancelOrderResponse cancelOrder(CancelOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CancelOrderHeaders headers = new CancelOrderHeaders();
        return this.cancelOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>个人应用撤销订单</p>
     * 
     * @param request CancelSnsOrderRequest
     * @param headers CancelSnsOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CancelSnsOrderResponse
     */
    public CancelSnsOrderResponse cancelSnsOrderWithOptions(CancelSnsOrderRequest request, CancelSnsOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.alipayAppId)) {
            body.put("alipayAppId", request.alipayAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.merchantId)) {
            body.put("merchantId", request.merchantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            body.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signature)) {
            body.put("signature", request.signature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timestamp)) {
            body.put("timestamp", request.timestamp);
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
            new TeaPair("action", "CancelSnsOrder"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/snsUserOrders/cancel"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CancelSnsOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>个人应用撤销订单</p>
     * 
     * @param request CancelSnsOrderRequest
     * @return CancelSnsOrderResponse
     */
    public CancelSnsOrderResponse cancelSnsOrder(CancelSnsOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CancelSnsOrderHeaders headers = new CancelSnsOrderHeaders();
        return this.cancelSnsOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>取消订单</p>
     * 
     * @param request CancelUserOrderRequest
     * @param headers CancelUserOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CancelUserOrderResponse
     */
    public CancelUserOrderResponse cancelUserOrderWithOptions(CancelUserOrderRequest request, CancelUserOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.alipayAppId)) {
            body.put("alipayAppId", request.alipayAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.merchantId)) {
            body.put("merchantId", request.merchantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            body.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signature)) {
            body.put("signature", request.signature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timestamp)) {
            body.put("timestamp", request.timestamp);
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
            new TeaPair("action", "CancelUserOrder"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/userOrders/cancel"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CancelUserOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>取消订单</p>
     * 
     * @param request CancelUserOrderRequest
     * @return CancelUserOrderResponse
     */
    public CancelUserOrderResponse cancelUserOrder(CancelUserOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CancelUserOrderHeaders headers = new CancelUserOrderHeaders();
        return this.cancelUserOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询打卡任务</p>
     * 
     * @param request CardBatchQueryCardsRequest
     * @param headers CardBatchQueryCardsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CardBatchQueryCardsResponse
     */
    public CardBatchQueryCardsResponse cardBatchQueryCardsWithOptions(CardBatchQueryCardsRequest request, CardBatchQueryCardsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cardBizCode)) {
            body.put("cardBizCode", request.cardBizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardIds)) {
            body.put("cardIds", request.cardIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceType)) {
            body.put("sourceType", request.sourceType);
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
            new TeaPair("action", "CardBatchQueryCards"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/cards/tasks/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CardBatchQueryCardsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询打卡任务</p>
     * 
     * @param request CardBatchQueryCardsRequest
     * @return CardBatchQueryCardsResponse
     */
    public CardBatchQueryCardsResponse cardBatchQueryCards(CardBatchQueryCardsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CardBatchQueryCardsHeaders headers = new CardBatchQueryCardsHeaders();
        return this.cardBatchQueryCardsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除打卡</p>
     * 
     * @param request CardDeleteCardRequest
     * @param headers CardDeleteCardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CardDeleteCardResponse
     */
    public CardDeleteCardResponse cardDeleteCardWithOptions(CardDeleteCardRequest request, CardDeleteCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cardBizCode)) {
            query.put("cardBizCode", request.cardBizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardBizId)) {
            query.put("cardBizId", request.cardBizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardId)) {
            query.put("cardId", request.cardId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceType)) {
            query.put("sourceType", request.sourceType);
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
            new TeaPair("action", "CardDeleteCard"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/cards"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CardDeleteCardResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除打卡</p>
     * 
     * @param request CardDeleteCardRequest
     * @return CardDeleteCardResponse
     */
    public CardDeleteCardResponse cardDeleteCard(CardDeleteCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CardDeleteCardHeaders headers = new CardDeleteCardHeaders();
        return this.cardDeleteCardWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>打卡-结束打卡</p>
     * 
     * @param request CardEndCardRequest
     * @param headers CardEndCardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CardEndCardResponse
     */
    public CardEndCardResponse cardEndCardWithOptions(CardEndCardRequest request, CardEndCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cardBizCode)) {
            body.put("cardBizCode", request.cardBizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardBizId)) {
            body.put("cardBizId", request.cardBizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardId)) {
            body.put("cardId", request.cardId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceType)) {
            body.put("sourceType", request.sourceType);
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
            new TeaPair("action", "CardEndCard"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/cards/finish"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CardEndCardResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>打卡-结束打卡</p>
     * 
     * @param request CardEndCardRequest
     * @return CardEndCardResponse
     */
    public CardEndCardResponse cardEndCard(CardEndCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CardEndCardHeaders headers = new CardEndCardHeaders();
        return this.cardEndCardWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询打卡任务</p>
     * 
     * @param request CardGetCardRequest
     * @param headers CardGetCardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CardGetCardResponse
     */
    public CardGetCardResponse cardGetCardWithOptions(CardGetCardRequest request, CardGetCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cardId)) {
            query.put("cardId", request.cardId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceType)) {
            query.put("sourceType", request.sourceType);
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
            new TeaPair("action", "CardGetCard"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/cards/tasks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CardGetCardResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询打卡任务</p>
     * 
     * @param request CardGetCardRequest
     * @return CardGetCardResponse
     */
    public CardGetCardResponse cardGetCard(CardGetCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CardGetCardHeaders headers = new CardGetCardHeaders();
        return this.cardGetCardWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取打卡任务完成进度</p>
     * 
     * @param request CardGetCardFinishProgressRequest
     * @param headers CardGetCardFinishProgressHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CardGetCardFinishProgressResponse
     */
    public CardGetCardFinishProgressResponse cardGetCardFinishProgressWithOptions(CardGetCardFinishProgressRequest request, CardGetCardFinishProgressHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cardBizCode)) {
            query.put("cardBizCode", request.cardBizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardBizId)) {
            query.put("cardBizId", request.cardBizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardId)) {
            query.put("cardId", request.cardId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceType)) {
            query.put("sourceType", request.sourceType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            query.put("studentId", request.studentId);
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
            new TeaPair("action", "CardGetCardFinishProgress"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/cards/completionProgress"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CardGetCardFinishProgressResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取打卡任务完成进度</p>
     * 
     * @param request CardGetCardFinishProgressRequest
     * @return CardGetCardFinishProgressResponse
     */
    public CardGetCardFinishProgressResponse cardGetCardFinishProgress(CardGetCardFinishProgressRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CardGetCardFinishProgressHeaders headers = new CardGetCardFinishProgressHeaders();
        return this.cardGetCardFinishProgressWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询打卡Feed流</p>
     * 
     * @param request CardQueryCardFeedsRequest
     * @param headers CardQueryCardFeedsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CardQueryCardFeedsResponse
     */
    public CardQueryCardFeedsResponse cardQueryCardFeedsWithOptions(CardQueryCardFeedsRequest request, CardQueryCardFeedsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            query.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardBizCode)) {
            query.put("cardBizCode", request.cardBizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardBizId)) {
            query.put("cardBizId", request.cardBizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardId)) {
            query.put("cardId", request.cardId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.count)) {
            query.put("count", request.count);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            query.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.feedType)) {
            query.put("feedType", request.feedType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.needFinishProcess)) {
            query.put("needFinishProcess", request.needFinishProcess);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceType)) {
            query.put("sourceType", request.sourceType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            query.put("studentId", request.studentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subBizId)) {
            query.put("subBizId", request.subBizId);
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
            new TeaPair("action", "CardQueryCardFeeds"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/cards/feeds"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CardQueryCardFeedsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询打卡Feed流</p>
     * 
     * @param request CardQueryCardFeedsRequest
     * @return CardQueryCardFeedsResponse
     */
    public CardQueryCardFeedsResponse cardQueryCardFeeds(CardQueryCardFeedsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CardQueryCardFeedsHeaders headers = new CardQueryCardFeedsHeaders();
        return this.cardQueryCardFeedsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>支付校验</p>
     * 
     * @param request CheckRestrictionRequest
     * @param headers CheckRestrictionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CheckRestrictionResponse
     */
    public CheckRestrictionResponse checkRestrictionWithOptions(CheckRestrictionRequest request, CheckRestrictionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actualAmount)) {
            body.put("actualAmount", request.actualAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.faceId)) {
            body.put("faceId", request.faceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scene)) {
            body.put("scene", request.scene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
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
            new TeaPair("action", "CheckRestriction"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/restrictions/check"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CheckRestrictionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>支付校验</p>
     * 
     * @param request CheckRestrictionRequest
     * @return CheckRestrictionResponse
     */
    public CheckRestrictionResponse checkRestriction(CheckRestrictionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CheckRestrictionHeaders headers = new CheckRestrictionHeaders();
        return this.checkRestrictionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>清空评价表现未读数量</p>
     * 
     * @param request ClearEvaluatePerformanceCountRequest
     * @param headers ClearEvaluatePerformanceCountHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ClearEvaluatePerformanceCountResponse
     */
    public ClearEvaluatePerformanceCountResponse clearEvaluatePerformanceCountWithOptions(ClearEvaluatePerformanceCountRequest request, ClearEvaluatePerformanceCountHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.studentIdList)) {
            body.put("studentIdList", request.studentIdList);
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
            new TeaPair("action", "ClearEvaluatePerformanceCount"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/evaluations/unreadCounts/clear"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ClearEvaluatePerformanceCountResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>清空评价表现未读数量</p>
     * 
     * @param request ClearEvaluatePerformanceCountRequest
     * @return ClearEvaluatePerformanceCountResponse
     */
    public ClearEvaluatePerformanceCountResponse clearEvaluatePerformanceCount(ClearEvaluatePerformanceCountRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ClearEvaluatePerformanceCountHeaders headers = new ClearEvaluatePerformanceCountHeaders();
        return this.clearEvaluatePerformanceCountWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>积分兑换</p>
     * 
     * @param request ConsumePointRequest
     * @param headers ConsumePointHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ConsumePointResponse
     */
    public ConsumePointResponse consumePointWithOptions(ConsumePointRequest request, ConsumePointHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.amount)) {
            body.put("amount", request.amount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productCode)) {
            body.put("productCode", request.productCode);
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
            new TeaPair("action", "ConsumePoint"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/poins/consume"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ConsumePointResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>积分兑换</p>
     * 
     * @param request ConsumePointRequest
     * @return ConsumePointResponse
     */
    public ConsumePointResponse consumePoint(ConsumePointRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ConsumePointHeaders headers = new ConsumePointHeaders();
        return this.consumePointWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>全校排课结束通知</p>
     * 
     * @param request CourseSchedulingComplimentNoticeRequest
     * @param headers CourseSchedulingComplimentNoticeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CourseSchedulingComplimentNoticeResponse
     */
    public CourseSchedulingComplimentNoticeResponse courseSchedulingComplimentNoticeWithOptions(CourseSchedulingComplimentNoticeRequest request, CourseSchedulingComplimentNoticeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
            new TeaPair("action", "CourseSchedulingComplimentNotice"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/schedules/finishNotify"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CourseSchedulingComplimentNoticeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>全校排课结束通知</p>
     * 
     * @param request CourseSchedulingComplimentNoticeRequest
     * @return CourseSchedulingComplimentNoticeResponse
     */
    public CourseSchedulingComplimentNoticeResponse courseSchedulingComplimentNotice(CourseSchedulingComplimentNoticeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CourseSchedulingComplimentNoticeHeaders headers = new CourseSchedulingComplimentNoticeHeaders();
        return this.courseSchedulingComplimentNoticeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建App支付订单</p>
     * 
     * @param request CreateAppOrderRequest
     * @param headers CreateAppOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateAppOrderResponse
     */
    public CreateAppOrderResponse createAppOrderWithOptions(CreateAppOrderRequest request, CreateAppOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actualAmount)) {
            body.put("actualAmount", request.actualAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.alipayAppId)) {
            body.put("alipayAppId", request.alipayAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.detailList)) {
            body.put("detailList", request.detailList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.labelAmount)) {
            body.put("labelAmount", request.labelAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.merchantId)) {
            body.put("merchantId", request.merchantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.merchantOrderNo)) {
            body.put("merchantOrderNo", request.merchantOrderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerUserId)) {
            body.put("outerUserId", request.outerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signature)) {
            body.put("signature", request.signature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subject)) {
            body.put("subject", request.subject);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timestamp)) {
            body.put("timestamp", request.timestamp);
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
            new TeaPair("action", "CreateAppOrder"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/appOrders"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateAppOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建App支付订单</p>
     * 
     * @param request CreateAppOrderRequest
     * @return CreateAppOrderResponse
     */
    public CreateAppOrderResponse createAppOrder(CreateAppOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateAppOrderHeaders headers = new CreateAppOrderHeaders();
        return this.createAppOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建高校通讯录组织单元</p>
     * 
     * @param request CreateCollegeContactDeptRequest
     * @param headers CreateCollegeContactDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateCollegeContactDeptResponse
     */
    public CreateCollegeContactDeptResponse createCollegeContactDeptWithOptions(CreateCollegeContactDeptRequest request, CreateCollegeContactDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.autoApproveApply)) {
            body.put("autoApproveApply", request.autoApproveApply);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.brief)) {
            body.put("brief", request.brief);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createDeptGroup)) {
            body.put("createDeptGroup", request.createDeptGroup);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptCode)) {
            body.put("deptCode", request.deptCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptPermits)) {
            body.put("deptPermits", request.deptPermits);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptType)) {
            body.put("deptType", request.deptType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.empApplyJoinDept)) {
            body.put("empApplyJoinDept", request.empApplyJoinDept);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hideDept)) {
            body.put("hideDept", request.hideDept);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hideSceneConfig)) {
            body.put("hideSceneConfig", request.hideSceneConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            body.put("order", request.order);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerDept)) {
            body.put("outerDept", request.outerDept);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerDeptOnlySelf)) {
            body.put("outerDeptOnlySelf", request.outerDeptOnlySelf);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerPermitDepts)) {
            body.put("outerPermitDepts", request.outerPermitDepts);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerPermitUsers)) {
            body.put("outerPermitUsers", request.outerPermitUsers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerSceneConfig)) {
            body.put("outerSceneConfig", request.outerSceneConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentId)) {
            body.put("parentId", request.parentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceIdentifier)) {
            body.put("sourceIdentifier", request.sourceIdentifier);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.struId)) {
            body.put("struId", request.struId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.telephone)) {
            body.put("telephone", request.telephone);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userPermits)) {
            body.put("userPermits", request.userPermits);
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
            new TeaPair("action", "CreateCollegeContactDept"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/depts"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateCollegeContactDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建高校通讯录组织单元</p>
     * 
     * @param request CreateCollegeContactDeptRequest
     * @return CreateCollegeContactDeptResponse
     */
    public CreateCollegeContactDeptResponse createCollegeContactDept(CreateCollegeContactDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateCollegeContactDeptHeaders headers = new CreateCollegeContactDeptHeaders();
        return this.createCollegeContactDeptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建高校通讯录场景架构</p>
     * 
     * @param request CreateCollegeContactSceneStruRequest
     * @param headers CreateCollegeContactSceneStruHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateCollegeContactSceneStruResponse
     */
    public CreateCollegeContactSceneStruResponse createCollegeContactSceneStruWithOptions(CreateCollegeContactSceneStruRequest request, CreateCollegeContactSceneStruHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.hasStruFixedDept)) {
            body.put("hasStruFixedDept", request.hasStruFixedDept);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            body.put("order", request.order);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceIdentifier)) {
            body.put("sourceIdentifier", request.sourceIdentifier);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.struBrief)) {
            body.put("struBrief", request.struBrief);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.struName)) {
            body.put("struName", request.struName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.struType)) {
            body.put("struType", request.struType);
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
            new TeaPair("action", "CreateCollegeContactSceneStru"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/depts/structures/scenes"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateCollegeContactSceneStruResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建高校通讯录场景架构</p>
     * 
     * @param request CreateCollegeContactSceneStruRequest
     * @return CreateCollegeContactSceneStruResponse
     */
    public CreateCollegeContactSceneStruResponse createCollegeContactSceneStru(CreateCollegeContactSceneStruRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateCollegeContactSceneStruHeaders headers = new CreateCollegeContactSceneStruHeaders();
        return this.createCollegeContactSceneStruWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建课程</p>
     * 
     * @param request CreateCourseRequest
     * @param headers CreateCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateCourseResponse
     */
    public CreateCourseResponse createCourseWithOptions(CreateCourseRequest request, CreateCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attributes)) {
            body.put("attributes", request.attributes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            body.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.className)) {
            body.put("className", request.className);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classRoomId)) {
            body.put("classRoomId", request.classRoomId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classRoomName)) {
            body.put("classRoomName", request.classRoomName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classType)) {
            body.put("classType", request.classType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseCode)) {
            body.put("courseCode", request.courseCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseDate)) {
            body.put("courseDate", request.courseDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseName)) {
            body.put("courseName", request.courseName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseWeek)) {
            body.put("courseWeek", request.courseWeek);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCourseId)) {
            body.put("isvCourseId", request.isvCourseId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memo)) {
            body.put("memo", request.memo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schoolYear)) {
            body.put("schoolYear", request.schoolYear);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.semester)) {
            body.put("semester", request.semester);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teachWeek)) {
            body.put("teachWeek", request.teachWeek);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherList)) {
            body.put("teacherList", request.teacherList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeslotName)) {
            body.put("timeslotName", request.timeslotName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeslotNum)) {
            body.put("timeslotNum", request.timeslotNum);
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
            new TeaPair("action", "CreateCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/courses"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建课程</p>
     * 
     * @param request CreateCourseRequest
     * @return CreateCourseResponse
     */
    public CreateCourseResponse createCourse(CreateCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateCourseHeaders headers = new CreateCourseHeaders();
        return this.createCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建自定义部门下班级</p>
     * 
     * @param request CreateCustomClassRequest
     * @param headers CreateCustomClassHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateCustomClassResponse
     */
    public CreateCustomClassResponse createCustomClassWithOptions(CreateCustomClassRequest request, CreateCustomClassHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.customClass)) {
            body.put("customClass", request.customClass);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.superId)) {
            body.put("superId", request.superId);
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
            new TeaPair("action", "CreateCustomClass"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/customClasses"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateCustomClassResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建自定义部门下班级</p>
     * 
     * @param request CreateCustomClassRequest
     * @return CreateCustomClassResponse
     */
    public CreateCustomClassResponse createCustomClass(CreateCustomClassRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateCustomClassHeaders headers = new CreateCustomClassHeaders();
        return this.createCustomClassWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建自定义校区或部门</p>
     * 
     * @param request CreateCustomDeptRequest
     * @param headers CreateCustomDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateCustomDeptResponse
     */
    public CreateCustomDeptResponse createCustomDeptWithOptions(CreateCustomDeptRequest request, CreateCustomDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.customDept)) {
            body.put("customDept", request.customDept);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.superId)) {
            body.put("superId", request.superId);
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
            new TeaPair("action", "CreateCustomDept"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/customDepts"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateCustomDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建自定义校区或部门</p>
     * 
     * @param request CreateCustomDeptRequest
     * @return CreateCustomDeptResponse
     */
    public CreateCustomDeptResponse createCustomDept(CreateCustomDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateCustomDeptHeaders headers = new CreateCustomDeptHeaders();
        return this.createCustomDeptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>教学资源库创建space</p>
     * 
     * @param request CreateEduAssetSpaceRequest
     * @param headers CreateEduAssetSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateEduAssetSpaceResponse
     */
    public CreateEduAssetSpaceResponse createEduAssetSpaceWithOptions(CreateEduAssetSpaceRequest request, CreateEduAssetSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceDesc)) {
            body.put("spaceDesc", request.spaceDesc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceIcon)) {
            body.put("spaceIcon", request.spaceIcon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceName)) {
            body.put("spaceName", request.spaceName);
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
            new TeaPair("action", "CreateEduAssetSpace"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/assets/spaces"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateEduAssetSpaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>教学资源库创建space</p>
     * 
     * @param request CreateEduAssetSpaceRequest
     * @return CreateEduAssetSpaceResponse
     */
    public CreateEduAssetSpaceResponse createEduAssetSpace(CreateEduAssetSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateEduAssetSpaceHeaders headers = new CreateEduAssetSpaceHeaders();
        return this.createEduAssetSpaceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建设备履约记录，亲情通话、考勤数据同步</p>
     * 
     * @param request CreateFulfilRecordRequest
     * @param headers CreateFulfilRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateFulfilRecordResponse
     */
    public CreateFulfilRecordResponse createFulfilRecordWithOptions(CreateFulfilRecordRequest request, CreateFulfilRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizTime)) {
            body.put("bizTime", request.bizTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extInfo)) {
            body.put("extInfo", request.extInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.faceId)) {
            body.put("faceId", request.faceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scene)) {
            body.put("scene", request.scene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
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
            new TeaPair("action", "CreateFulfilRecord"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/fulfilRecords"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateFulfilRecordResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建设备履约记录，亲情通话、考勤数据同步</p>
     * 
     * @param request CreateFulfilRecordRequest
     * @return CreateFulfilRecordResponse
     */
    public CreateFulfilRecordResponse createFulfilRecord(CreateFulfilRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateFulfilRecordHeaders headers = new CreateFulfilRecordHeaders();
        return this.createFulfilRecordWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询某个组织下面的设备列表</p>
     * 
     * @param request CreateInviteUrlRequest
     * @param headers CreateInviteUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateInviteUrlResponse
     */
    public CreateInviteUrlResponse createInviteUrlWithOptions(CreateInviteUrlRequest request, CreateInviteUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authCode)) {
            body.put("authCode", request.authCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetOperator)) {
            body.put("targetOperator", request.targetOperator);
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
            new TeaPair("action", "CreateInviteUrl"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/remoteClasses/orgRelations/inviteUrls"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateInviteUrlResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询某个组织下面的设备列表</p>
     * 
     * @param request CreateInviteUrlRequest
     * @return CreateInviteUrlResponse
     */
    public CreateInviteUrlResponse createInviteUrl(CreateInviteUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateInviteUrlHeaders headers = new CreateInviteUrlHeaders();
        return this.createInviteUrlWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建商品</p>
     * 
     * @param request CreateItemRequest
     * @param headers CreateItemHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateItemResponse
     */
    public CreateItemResponse createItemWithOptions(CreateItemRequest request, CreateItemHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.effectType)) {
            body.put("effectType", request.effectType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.merchantId)) {
            body.put("merchantId", request.merchantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.optUser)) {
            body.put("optUser", request.optUser);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodType)) {
            body.put("periodType", request.periodType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.price)) {
            body.put("price", request.price);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scene)) {
            body.put("scene", request.scene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
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
            new TeaPair("action", "CreateItem"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/items"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateItemResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建商品</p>
     * 
     * @param request CreateItemRequest
     * @return CreateItemResponse
     */
    public CreateItemResponse createItem(CreateItemRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateItemHeaders headers = new CreateItemHeaders();
        return this.createItemWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>套件-创建定时任务</p>
     * 
     * @param request CreateKitTaskRequest
     * @param headers CreateKitTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateKitTaskResponse
     */
    public CreateKitTaskResponse createKitTaskWithOptions(CreateKitTaskRequest request, CreateKitTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionTime)) {
            body.put("actionTime", request.actionTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizData)) {
            body.put("bizData", request.bizData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.identifier)) {
            body.put("identifier", request.identifier);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memo)) {
            body.put("memo", request.memo);
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
            new TeaPair("action", "CreateKitTask"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/timerTasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateKitTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>套件-创建定时任务</p>
     * 
     * @param request CreateKitTaskRequest
     * @return CreateKitTaskResponse
     */
    public CreateKitTaskResponse createKitTask(CreateKitTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateKitTaskHeaders headers = new CreateKitTaskHeaders();
        return this.createKitTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建订单信息</p>
     * 
     * @param request CreateOrderRequest
     * @param headers CreateOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateOrderResponse
     */
    public CreateOrderResponse createOrderWithOptions(CreateOrderRequest request, CreateOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actualAmount)) {
            body.put("actualAmount", request.actualAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createTime)) {
            body.put("createTime", request.createTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.detailList)) {
            body.put("detailList", request.detailList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.faceId)) {
            body.put("faceId", request.faceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ftoken)) {
            body.put("ftoken", request.ftoken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signature)) {
            body.put("signature", request.signature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.terminalParams)) {
            body.put("terminalParams", request.terminalParams);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timestamp)) {
            body.put("timestamp", request.timestamp);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.totalAmount)) {
            body.put("totalAmount", request.totalAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.version)) {
            body.put("version", request.version);
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
            new TeaPair("action", "CreateOrder"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/orders"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建订单信息</p>
     * 
     * @param request CreateOrderRequest
     * @return CreateOrderResponse
     */
    public CreateOrderResponse createOrder(CreateOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateOrderHeaders headers = new CreateOrderHeaders();
        return this.createOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建开单流水</p>
     * 
     * @param request CreateOrderFlowRequest
     * @param headers CreateOrderFlowHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateOrderFlowResponse
     */
    public CreateOrderFlowResponse createOrderFlowWithOptions(CreateOrderFlowRequest request, CreateOrderFlowHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actualAmount)) {
            body.put("actualAmount", request.actualAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.alipayUid)) {
            body.put("alipayUid", request.alipayUid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createTime)) {
            body.put("createTime", request.createTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.detailList)) {
            body.put("detailList", request.detailList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.faceId)) {
            body.put("faceId", request.faceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.guardianUserId)) {
            body.put("guardianUserId", request.guardianUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.merchantId)) {
            body.put("merchantId", request.merchantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            body.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signature)) {
            body.put("signature", request.signature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timestamp)) {
            body.put("timestamp", request.timestamp);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.totalAmount)) {
            body.put("totalAmount", request.totalAmount);
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
            new TeaPair("action", "CreateOrderFlow"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/orders/flows"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateOrderFlowResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建开单流水</p>
     * 
     * @param request CreateOrderFlowRequest
     * @return CreateOrderFlowResponse
     */
    public CreateOrderFlowResponse createOrderFlow(CreateOrderFlowRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateOrderFlowHeaders headers = new CreateOrderFlowHeaders();
        return this.createOrderFlowWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加物理教室信息</p>
     * 
     * @param request CreatePhysicalClassroomRequest
     * @param headers CreatePhysicalClassroomHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreatePhysicalClassroomResponse
     */
    public CreatePhysicalClassroomResponse createPhysicalClassroomWithOptions(CreatePhysicalClassroomRequest request, CreatePhysicalClassroomHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classroomBuilding)) {
            body.put("classroomBuilding", request.classroomBuilding);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomCampus)) {
            body.put("classroomCampus", request.classroomCampus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomFloor)) {
            body.put("classroomFloor", request.classroomFloor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomName)) {
            body.put("classroomName", request.classroomName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomNumber)) {
            body.put("classroomNumber", request.classroomNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.directBroadcast)) {
            body.put("directBroadcast", request.directBroadcast);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
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
            new TeaPair("action", "CreatePhysicalClassroom"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/physicalClassrooms"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreatePhysicalClassroomResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加物理教室信息</p>
     * 
     * @param request CreatePhysicalClassroomRequest
     * @return CreatePhysicalClassroomResponse
     */
    public CreatePhysicalClassroomResponse createPhysicalClassroom(CreatePhysicalClassroomRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreatePhysicalClassroomHeaders headers = new CreatePhysicalClassroomHeaders();
        return this.createPhysicalClassroomWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建退款流水</p>
     * 
     * @param request CreateRefundFlowRequest
     * @param headers CreateRefundFlowHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateRefundFlowResponse
     */
    public CreateRefundFlowResponse createRefundFlowWithOptions(CreateRefundFlowRequest request, CreateRefundFlowHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.faceId)) {
            body.put("faceId", request.faceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorName)) {
            body.put("operatorName", request.operatorName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            body.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signature)) {
            body.put("signature", request.signature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timestamp)) {
            body.put("timestamp", request.timestamp);
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
            new TeaPair("action", "CreateRefundFlow"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/refunds/flows"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateRefundFlowResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建退款流水</p>
     * 
     * @param request CreateRefundFlowRequest
     * @return CreateRefundFlowResponse
     */
    public CreateRefundFlowResponse createRefundFlow(CreateRefundFlowRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateRefundFlowHeaders headers = new CreateRefundFlowHeaders();
        return this.createRefundFlowWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建预约类型的专递课堂</p>
     * 
     * @param request CreateRemoteClassCourseRequest
     * @param headers CreateRemoteClassCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateRemoteClassCourseResponse
     */
    public CreateRemoteClassCourseResponse createRemoteClassCourseWithOptions(CreateRemoteClassCourseRequest request, CreateRemoteClassCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attendParticipants)) {
            body.put("attendParticipants", request.attendParticipants);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authCode)) {
            body.put("authCode", request.authCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseName)) {
            body.put("courseName", request.courseName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teachingParticipant)) {
            body.put("teachingParticipant", request.teachingParticipant);
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
            new TeaPair("action", "CreateRemoteClassCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/remoteClasses/courses"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateRemoteClassCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建预约类型的专递课堂</p>
     * 
     * @param request CreateRemoteClassCourseRequest
     * @return CreateRemoteClassCourseResponse
     */
    public CreateRemoteClassCourseResponse createRemoteClassCourse(CreateRemoteClassCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateRemoteClassCourseHeaders headers = new CreateRemoteClassCourseHeaders();
        return this.createRemoteClassCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>按学期创建课表模板</p>
     * 
     * @param request CreateSectionConfigRequest
     * @param headers CreateSectionConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateSectionConfigResponse
     */
    public CreateSectionConfigResponse createSectionConfigWithOptions(CreateSectionConfigRequest request, CreateSectionConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sectionConfigs)) {
            body.put("sectionConfigs", request.sectionConfigs);
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
            new TeaPair("action", "CreateSectionConfig"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/universities/sectionConfigs"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateSectionConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>按学期创建课表模板</p>
     * 
     * @param request CreateSectionConfigRequest
     * @return CreateSectionConfigResponse
     */
    public CreateSectionConfigResponse createSectionConfig(CreateSectionConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateSectionConfigHeaders headers = new CreateSectionConfigHeaders();
        return this.createSectionConfigWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>个人应用创建APP订单</p>
     * 
     * @param request CreateSnsAppOrderRequest
     * @param headers CreateSnsAppOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateSnsAppOrderResponse
     */
    public CreateSnsAppOrderResponse createSnsAppOrderWithOptions(CreateSnsAppOrderRequest request, CreateSnsAppOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actualAmount)) {
            body.put("actualAmount", request.actualAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.alipayAppId)) {
            body.put("alipayAppId", request.alipayAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.detailList)) {
            body.put("detailList", request.detailList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.labelAmount)) {
            body.put("labelAmount", request.labelAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.merchantId)) {
            body.put("merchantId", request.merchantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.merchantOrderNo)) {
            body.put("merchantOrderNo", request.merchantOrderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signature)) {
            body.put("signature", request.signature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subject)) {
            body.put("subject", request.subject);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timestamp)) {
            body.put("timestamp", request.timestamp);
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
            new TeaPair("action", "CreateSnsAppOrder"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/snsAppOrders"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateSnsAppOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>个人应用创建APP订单</p>
     * 
     * @param request CreateSnsAppOrderRequest
     * @return CreateSnsAppOrderResponse
     */
    public CreateSnsAppOrderResponse createSnsAppOrder(CreateSnsAppOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateSnsAppOrderHeaders headers = new CreateSnsAppOrderHeaders();
        return this.createSnsAppOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建ststoken</p>
     * 
     * @param request CreateStsTokenRequest
     * @param headers CreateStsTokenHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateStsTokenResponse
     */
    public CreateStsTokenResponse createStsTokenWithOptions(CreateStsTokenRequest request, CreateStsTokenHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceSn)) {
            body.put("deviceSn", request.deviceSn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stsType)) {
            body.put("stsType", request.stsType);
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
            new TeaPair("action", "CreateStsToken"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/vpaas/ststoken"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateStsTokenResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建ststoken</p>
     * 
     * @param request CreateStsTokenRequest
     * @return CreateStsTokenResponse
     */
    public CreateStsTokenResponse createStsToken(CreateStsTokenRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateStsTokenHeaders headers = new CreateStsTokenHeaders();
        return this.createStsTokenWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建学生班级</p>
     * 
     * @param request CreateStudentClassRequest
     * @param headers CreateStudentClassHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateStudentClassResponse
     */
    public CreateStudentClassResponse createStudentClassWithOptions(CreateStudentClassRequest request, CreateStudentClassHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attributes)) {
            body.put("attributes", request.attributes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            body.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.className)) {
            body.put("className", request.className);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classType)) {
            body.put("classType", request.classType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentName)) {
            body.put("studentName", request.studentName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentUserId)) {
            body.put("studentUserId", request.studentUserId);
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
            new TeaPair("action", "CreateStudentClass"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/students/classes"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateStudentClassResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建学生班级</p>
     * 
     * @param request CreateStudentClassRequest
     * @return CreateStudentClassResponse
     */
    public CreateStudentClassResponse createStudentClass(CreateStudentClassRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateStudentClassHeaders headers = new CreateStudentClassHeaders();
        return this.createStudentClassWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建老师课程</p>
     * 
     * @param request CreateTeacherCourseRequest
     * @param headers CreateTeacherCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTeacherCourseResponse
     */
    public CreateTeacherCourseResponse createTeacherCourseWithOptions(CreateTeacherCourseRequest request, CreateTeacherCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attributes)) {
            body.put("attributes", request.attributes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCourseId)) {
            body.put("isvCourseId", request.isvCourseId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherName)) {
            body.put("teacherName", request.teacherName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherUserId)) {
            body.put("teacherUserId", request.teacherUserId);
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
            new TeaPair("action", "CreateTeacherCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/teachers/courses"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTeacherCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建老师课程</p>
     * 
     * @param request CreateTeacherCourseRequest
     * @return CreateTeacherCourseResponse
     */
    public CreateTeacherCourseResponse createTeacherCourse(CreateTeacherCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTeacherCourseHeaders headers = new CreateTeacherCourseHeaders();
        return this.createTeacherCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>套件-创建定时卡片</p>
     * 
     * @param request CreateTimerCardRequest
     * @param headers CreateTimerCardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTimerCardResponse
     */
    public CreateTimerCardResponse createTimerCardWithOptions(CreateTimerCardRequest request, CreateTimerCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionTime)) {
            body.put("actionTime", request.actionTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizData)) {
            body.put("bizData", request.bizData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.identifier)) {
            body.put("identifier", request.identifier);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memo)) {
            body.put("memo", request.memo);
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
            new TeaPair("action", "CreateTimerCard"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/timerCards"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTimerCardResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>套件-创建定时卡片</p>
     * 
     * @param request CreateTimerCardRequest
     * @return CreateTimerCardResponse
     */
    public CreateTimerCardResponse createTimerCard(CreateTimerCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTimerCardHeaders headers = new CreateTimerCardHeaders();
        return this.createTimerCardWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建授权token</p>
     * 
     * @param request CreateTokenRequest
     * @param headers CreateTokenHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTokenResponse
     */
    public CreateTokenResponse createTokenWithOptions(CreateTokenRequest request, CreateTokenHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
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
            new TeaPair("action", "CreateToken"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/tokens"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTokenResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建授权token</p>
     * 
     * @param request CreateTokenRequest
     * @return CreateTokenResponse
     */
    public CreateTokenResponse createToken(CreateTokenRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTokenHeaders headers = new CreateTokenHeaders();
        return this.createTokenWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建调代课记录</p>
     * 
     * @param request CreateTransferRecordRequest
     * @param headers CreateTransferRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTransferRecordResponse
     */
    public CreateTransferRecordResponse createTransferRecordWithOptions(CreateTransferRecordRequest request, CreateTransferRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attributes)) {
            body.put("attributes", request.attributes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            body.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.className)) {
            body.put("className", request.className);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvRecordId)) {
            body.put("isvRecordId", request.isvRecordId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.srcCourseCode)) {
            body.put("srcCourseCode", request.srcCourseCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.srcCourseDate)) {
            body.put("srcCourseDate", request.srcCourseDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.srcCourseName)) {
            body.put("srcCourseName", request.srcCourseName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.srcIsvCourseId)) {
            body.put("srcIsvCourseId", request.srcIsvCourseId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.srcTimeslotName)) {
            body.put("srcTimeslotName", request.srcTimeslotName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.srcTimeslotNum)) {
            body.put("srcTimeslotNum", request.srcTimeslotNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tarCourseCode)) {
            body.put("tarCourseCode", request.tarCourseCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tarCourseDate)) {
            body.put("tarCourseDate", request.tarCourseDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tarCourseName)) {
            body.put("tarCourseName", request.tarCourseName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tarIsvCourseId)) {
            body.put("tarIsvCourseId", request.tarIsvCourseId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tarTimeslotName)) {
            body.put("tarTimeslotName", request.tarTimeslotName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tarTimeslotNum)) {
            body.put("tarTimeslotNum", request.tarTimeslotNum);
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
            new TeaPair("action", "CreateTransferRecord"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/transferRecords"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTransferRecordResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建调代课记录</p>
     * 
     * @param request CreateTransferRecordRequest
     * @return CreateTransferRecordResponse
     */
    public CreateTransferRecordResponse createTransferRecord(CreateTransferRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTransferRecordHeaders headers = new CreateTransferRecordHeaders();
        return this.createTransferRecordWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>大学创建课程组</p>
     * 
     * @param request CreateUniversityCourseGroupRequest
     * @param headers CreateUniversityCourseGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateUniversityCourseGroupResponse
     */
    public CreateUniversityCourseGroupResponse createUniversityCourseGroupWithOptions(CreateUniversityCourseGroupRequest request, CreateUniversityCourseGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupIntroduce)) {
            body.put("courseGroupIntroduce", request.courseGroupIntroduce);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupName)) {
            body.put("courseGroupName", request.courseGroupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courserGroupItemModels)) {
            body.put("courserGroupItemModels", request.courserGroupItemModels);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCourseGroupCode)) {
            body.put("isvCourseGroupCode", request.isvCourseGroupCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodCode)) {
            body.put("periodCode", request.periodCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schoolYear)) {
            body.put("schoolYear", request.schoolYear);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.semester)) {
            body.put("semester", request.semester);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subjectName)) {
            body.put("subjectName", request.subjectName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherInfos)) {
            body.put("teacherInfos", request.teacherInfos);
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
            new TeaPair("action", "CreateUniversityCourseGroup"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/universities/courseGroups"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateUniversityCourseGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>大学创建课程组</p>
     * 
     * @param request CreateUniversityCourseGroupRequest
     * @return CreateUniversityCourseGroupResponse
     */
    public CreateUniversityCourseGroupResponse createUniversityCourseGroup(CreateUniversityCourseGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateUniversityCourseGroupHeaders headers = new CreateUniversityCourseGroupHeaders();
        return this.createUniversityCourseGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>大学增加学生</p>
     * 
     * @param request CreateUniversityStudentRequest
     * @param headers CreateUniversityStudentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateUniversityStudentResponse
     */
    public CreateUniversityStudentResponse createUniversityStudentWithOptions(CreateUniversityStudentRequest request, CreateUniversityStudentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            body.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gender)) {
            body.put("gender", request.gender);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.identityNumber)) {
            body.put("identityNumber", request.identityNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentNumber)) {
            body.put("studentNumber", request.studentNumber);
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
            new TeaPair("action", "CreateUniversityStudent"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/universities/students"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateUniversityStudentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>大学增加学生</p>
     * 
     * @param request CreateUniversityStudentRequest
     * @return CreateUniversityStudentResponse
     */
    public CreateUniversityStudentResponse createUniversityStudent(CreateUniversityStudentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateUniversityStudentHeaders headers = new CreateUniversityStudentHeaders();
        return this.createUniversityStudentWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>大学添加老师</p>
     * 
     * @param request CreateUniversityTeacherRequest
     * @param headers CreateUniversityTeacherHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateUniversityTeacherResponse
     */
    public CreateUniversityTeacherResponse createUniversityTeacherWithOptions(CreateUniversityTeacherRequest request, CreateUniversityTeacherHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            body.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.role)) {
            body.put("role", request.role);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherUserId)) {
            body.put("teacherUserId", request.teacherUserId);
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
            new TeaPair("action", "CreateUniversityTeacher"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/universities/teachers"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateUniversityTeacherResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>大学添加老师</p>
     * 
     * @param request CreateUniversityTeacherRequest
     * @return CreateUniversityTeacherResponse
     */
    public CreateUniversityTeacherResponse createUniversityTeacher(CreateUniversityTeacherRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateUniversityTeacherHeaders headers = new CreateUniversityTeacherHeaders();
        return this.createUniversityTeacherWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>视讯paas机具取消激活</p>
     * 
     * @param request DeactivateDeviceRequest
     * @param headers DeactivateDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeactivateDeviceResponse
     */
    public DeactivateDeviceResponse deactivateDeviceWithOptions(DeactivateDeviceRequest request, DeactivateDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.model)) {
            body.put("model", request.model);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
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
            new TeaPair("action", "DeactivateDevice"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/vpaas/devices/deactivate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeactivateDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>视讯paas机具取消激活</p>
     * 
     * @param request DeactivateDeviceRequest
     * @return DeactivateDeviceResponse
     */
    public DeactivateDeviceResponse deactivateDevice(DeactivateDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeactivateDeviceHeaders headers = new DeactivateDeviceHeaders();
        return this.deactivateDeviceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>扣减教育积分</p>
     * 
     * @param request DeductPointRequest
     * @param headers DeductPointHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeductPointResponse
     */
    public DeductPointResponse deductPointWithOptions(DeductPointRequest request, DeductPointHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deductDesc)) {
            body.put("deductDesc", request.deductDesc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deductDetailUrl)) {
            body.put("deductDetailUrl", request.deductDetailUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deductNum)) {
            body.put("deductNum", request.deductNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pointType)) {
            body.put("pointType", request.pointType);
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
            new TeaPair("action", "DeductPoint"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/points/deduct"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeductPointResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>扣减教育积分</p>
     * 
     * @param request DeductPointRequest
     * @return DeductPointResponse
     */
    public DeductPointResponse deductPoint(DeductPointRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeductPointHeaders headers = new DeductPointHeaders();
        return this.deductPointWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>高校校友会删除当前部门</p>
     * 
     * @param request DeleteCollegeAlumniDeptRequest
     * @param headers DeleteCollegeAlumniDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteCollegeAlumniDeptResponse
     */
    public DeleteCollegeAlumniDeptResponse deleteCollegeAlumniDeptWithOptions(DeleteCollegeAlumniDeptRequest request, DeleteCollegeAlumniDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
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
            new TeaPair("action", "DeleteCollegeAlumniDept"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeAlumni/depts"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteCollegeAlumniDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>高校校友会删除当前部门</p>
     * 
     * @param request DeleteCollegeAlumniDeptRequest
     * @return DeleteCollegeAlumniDeptResponse
     */
    public DeleteCollegeAlumniDeptResponse deleteCollegeAlumniDept(DeleteCollegeAlumniDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteCollegeAlumniDeptHeaders headers = new DeleteCollegeAlumniDeptHeaders();
        return this.deleteCollegeAlumniDeptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>高校校友会删除校友信息</p>
     * 
     * @param request DeleteCollegeAlumniUserInfoRequest
     * @param headers DeleteCollegeAlumniUserInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteCollegeAlumniUserInfoResponse
     */
    public DeleteCollegeAlumniUserInfoResponse deleteCollegeAlumniUserInfoWithOptions(DeleteCollegeAlumniUserInfoRequest request, DeleteCollegeAlumniUserInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
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
            new TeaPair("action", "DeleteCollegeAlumniUserInfo"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeAlumni/userInfos/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteCollegeAlumniUserInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>高校校友会删除校友信息</p>
     * 
     * @param request DeleteCollegeAlumniUserInfoRequest
     * @return DeleteCollegeAlumniUserInfoResponse
     */
    public DeleteCollegeAlumniUserInfoResponse deleteCollegeAlumniUserInfo(DeleteCollegeAlumniUserInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteCollegeAlumniUserInfoHeaders headers = new DeleteCollegeAlumniUserInfoHeaders();
        return this.deleteCollegeAlumniUserInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除高校通讯录场景架构</p>
     * 
     * @param request DeleteCollegeContactSceneStruRequest
     * @param headers DeleteCollegeContactSceneStruHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteCollegeContactSceneStruResponse
     */
    public DeleteCollegeContactSceneStruResponse deleteCollegeContactSceneStruWithOptions(DeleteCollegeContactSceneStruRequest request, DeleteCollegeContactSceneStruHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.struId)) {
            body.put("struId", request.struId);
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
            new TeaPair("action", "DeleteCollegeContactSceneStru"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/depts/structures/scenes/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteCollegeContactSceneStruResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除高校通讯录场景架构</p>
     * 
     * @param request DeleteCollegeContactSceneStruRequest
     * @return DeleteCollegeContactSceneStruResponse
     */
    public DeleteCollegeContactSceneStruResponse deleteCollegeContactSceneStru(DeleteCollegeContactSceneStruRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteCollegeContactSceneStruHeaders headers = new DeleteCollegeContactSceneStruHeaders();
        return this.deleteCollegeContactSceneStruWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除家校部门</p>
     * 
     * @param request DeleteDeptRequest
     * @param headers DeleteDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteDeptResponse
     */
    public DeleteDeptResponse deleteDeptWithOptions(String deptId, DeleteDeptRequest request, DeleteDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
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
            new TeaPair("action", "DeleteDept"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/depts/" + deptId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除家校部门</p>
     * 
     * @param request DeleteDeptRequest
     * @return DeleteDeptResponse
     */
    public DeleteDeptResponse deleteDept(String deptId, DeleteDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteDeptHeaders headers = new DeleteDeptHeaders();
        return this.deleteDeptWithOptions(deptId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>视讯paas机具删除</p>
     * 
     * @param request DeleteDeviceRequest
     * @param headers DeleteDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteDeviceResponse
     */
    public DeleteDeviceResponse deleteDeviceWithOptions(DeleteDeviceRequest request, DeleteDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            query.put("sn", request.sn);
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
            new TeaPair("action", "DeleteDevice"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/vpaas/devices"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>视讯paas机具删除</p>
     * 
     * @param request DeleteDeviceRequest
     * @return DeleteDeviceResponse
     */
    public DeleteDeviceResponse deleteDevice(DeleteDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteDeviceHeaders headers = new DeleteDeviceHeaders();
        return this.deleteDeviceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除设备上面的组织</p>
     * 
     * @param request DeleteDeviceOrgRequest
     * @param headers DeleteDeviceOrgHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteDeviceOrgResponse
     */
    public DeleteDeviceOrgResponse deleteDeviceOrgWithOptions(DeleteDeviceOrgRequest request, DeleteDeviceOrgHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authCode)) {
            query.put("authCode", request.authCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceCode)) {
            query.put("deviceCode", request.deviceCode);
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
            new TeaPair("action", "DeleteDeviceOrg"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/remoteClasses/deviceOrgs"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteDeviceOrgResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除设备上面的组织</p>
     * 
     * @param request DeleteDeviceOrgRequest
     * @return DeleteDeviceOrgResponse
     */
    public DeleteDeviceOrgResponse deleteDeviceOrg(DeleteDeviceOrgRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteDeviceOrgHeaders headers = new DeleteDeviceOrgHeaders();
        return this.deleteDeviceOrgWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除评价表现数据</p>
     * 
     * @param request DeleteEvaluatePerformanceRequest
     * @param headers DeleteEvaluatePerformanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteEvaluatePerformanceResponse
     */
    public DeleteEvaluatePerformanceResponse deleteEvaluatePerformanceWithOptions(DeleteEvaluatePerformanceRequest request, DeleteEvaluatePerformanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.evaluationIdList)) {
            body.put("evaluationIdList", request.evaluationIdList);
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
            new TeaPair("action", "DeleteEvaluatePerformance"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/evaluations/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteEvaluatePerformanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除评价表现数据</p>
     * 
     * @param request DeleteEvaluatePerformanceRequest
     * @return DeleteEvaluatePerformanceResponse
     */
    public DeleteEvaluatePerformanceResponse deleteEvaluatePerformance(DeleteEvaluatePerformanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteEvaluatePerformanceHeaders headers = new DeleteEvaluatePerformanceHeaders();
        return this.deleteEvaluatePerformanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除家长</p>
     * 
     * @param request DeleteGuardianRequest
     * @param headers DeleteGuardianHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteGuardianResponse
     */
    public DeleteGuardianResponse deleteGuardianWithOptions(String classId, String userId, DeleteGuardianRequest request, DeleteGuardianHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stuId)) {
            query.put("stuId", request.stuId);
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
            new TeaPair("action", "DeleteGuardian"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/classes/" + classId + "/guardians/" + userId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteGuardianResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除家长</p>
     * 
     * @param request DeleteGuardianRequest
     * @return DeleteGuardianResponse
     */
    public DeleteGuardianResponse deleteGuardian(String classId, String userId, DeleteGuardianRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteGuardianHeaders headers = new DeleteGuardianHeaders();
        return this.deleteGuardianWithOptions(classId, userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除组织的关联关系</p>
     * 
     * @param request DeleteOrgRelationRequest
     * @param headers DeleteOrgRelationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteOrgRelationResponse
     */
    public DeleteOrgRelationResponse deleteOrgRelationWithOptions(DeleteOrgRelationRequest request, DeleteOrgRelationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authCode)) {
            query.put("authCode", request.authCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            query.put("targetCorpId", request.targetCorpId);
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
            new TeaPair("action", "DeleteOrgRelation"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/remoteClasses/orgRelations"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteOrgRelationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除组织的关联关系</p>
     * 
     * @param request DeleteOrgRelationRequest
     * @return DeleteOrgRelationResponse
     */
    public DeleteOrgRelationResponse deleteOrgRelation(DeleteOrgRelationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteOrgRelationHeaders headers = new DeleteOrgRelationHeaders();
        return this.deleteOrgRelationWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除物理教室信息</p>
     * 
     * @param request DeletePhysicalClassroomRequest
     * @param headers DeletePhysicalClassroomHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeletePhysicalClassroomResponse
     */
    public DeletePhysicalClassroomResponse deletePhysicalClassroomWithOptions(DeletePhysicalClassroomRequest request, DeletePhysicalClassroomHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classroomId)) {
            query.put("classroomId", request.classroomId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
            new TeaPair("action", "DeletePhysicalClassroom"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/physicalClassrooms"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeletePhysicalClassroomResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除物理教室信息</p>
     * 
     * @param request DeletePhysicalClassroomRequest
     * @return DeletePhysicalClassroomResponse
     */
    public DeletePhysicalClassroomResponse deletePhysicalClassroom(DeletePhysicalClassroomRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeletePhysicalClassroomHeaders headers = new DeletePhysicalClassroomHeaders();
        return this.deletePhysicalClassroomWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除专递课堂课程</p>
     * 
     * @param request DeleteRemoteClassCourseRequest
     * @param headers DeleteRemoteClassCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteRemoteClassCourseResponse
     */
    public DeleteRemoteClassCourseResponse deleteRemoteClassCourseWithOptions(String courseCode, DeleteRemoteClassCourseRequest request, DeleteRemoteClassCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authCode)) {
            query.put("authCode", request.authCode);
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
            new TeaPair("action", "DeleteRemoteClassCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/remoteClasses/courses/" + courseCode + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteRemoteClassCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除专递课堂课程</p>
     * 
     * @param request DeleteRemoteClassCourseRequest
     * @return DeleteRemoteClassCourseResponse
     */
    public DeleteRemoteClassCourseResponse deleteRemoteClassCourse(String courseCode, DeleteRemoteClassCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteRemoteClassCourseHeaders headers = new DeleteRemoteClassCourseHeaders();
        return this.deleteRemoteClassCourseWithOptions(courseCode, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除成绩单</p>
     * 
     * @param request DeleteSchoolReportRequest
     * @param headers DeleteSchoolReportHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteSchoolReportResponse
     */
    public DeleteSchoolReportResponse deleteSchoolReportWithOptions(DeleteSchoolReportRequest request, DeleteSchoolReportHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schoolReportId)) {
            body.put("schoolReportId", request.schoolReportId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherId)) {
            body.put("teacherId", request.teacherId);
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
            new TeaPair("action", "DeleteSchoolReport"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/schools/reports/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteSchoolReportResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除成绩单</p>
     * 
     * @param request DeleteSchoolReportRequest
     * @return DeleteSchoolReportResponse
     */
    public DeleteSchoolReportResponse deleteSchoolReport(DeleteSchoolReportRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteSchoolReportHeaders headers = new DeleteSchoolReportHeaders();
        return this.deleteSchoolReportWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除学生</p>
     * 
     * @param request DeleteStudentRequest
     * @param headers DeleteStudentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteStudentResponse
     */
    public DeleteStudentResponse deleteStudentWithOptions(String classId, String userId, DeleteStudentRequest request, DeleteStudentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
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
            new TeaPair("action", "DeleteStudent"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/classes/" + classId + "/students/" + userId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteStudentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除学生</p>
     * 
     * @param request DeleteStudentRequest
     * @return DeleteStudentResponse
     */
    public DeleteStudentResponse deleteStudent(String classId, String userId, DeleteStudentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteStudentHeaders headers = new DeleteStudentHeaders();
        return this.deleteStudentWithOptions(classId, userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除老师</p>
     * 
     * @param request DeleteTeacherRequest
     * @param headers DeleteTeacherHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteTeacherResponse
     */
    public DeleteTeacherResponse deleteTeacherWithOptions(String classId, String userId, DeleteTeacherRequest request, DeleteTeacherHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.adviser)) {
            query.put("adviser", request.adviser);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
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
            new TeaPair("action", "DeleteTeacher"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/classes/" + classId + "/teachers/" + userId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteTeacherResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除老师</p>
     * 
     * @param request DeleteTeacherRequest
     * @return DeleteTeacherResponse
     */
    public DeleteTeacherResponse deleteTeacher(String classId, String userId, DeleteTeacherRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteTeacherHeaders headers = new DeleteTeacherHeaders();
        return this.deleteTeacherWithOptions(classId, userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除大学课程组</p>
     * 
     * @param request DeleteUniversityCourseGroupRequest
     * @param headers DeleteUniversityCourseGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteUniversityCourseGroupResponse
     */
    public DeleteUniversityCourseGroupResponse deleteUniversityCourseGroupWithOptions(DeleteUniversityCourseGroupRequest request, DeleteUniversityCourseGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupCode)) {
            query.put("courseGroupCode", request.courseGroupCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
            new TeaPair("action", "DeleteUniversityCourseGroup"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/universities/courseGroups"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteUniversityCourseGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除大学课程组</p>
     * 
     * @param request DeleteUniversityCourseGroupRequest
     * @return DeleteUniversityCourseGroupResponse
     */
    public DeleteUniversityCourseGroupResponse deleteUniversityCourseGroup(DeleteUniversityCourseGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteUniversityCourseGroupHeaders headers = new DeleteUniversityCourseGroupHeaders();
        return this.deleteUniversityCourseGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除大学学生</p>
     * 
     * @param request DeleteUniversityStudentRequest
     * @param headers DeleteUniversityStudentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteUniversityStudentResponse
     */
    public DeleteUniversityStudentResponse deleteUniversityStudentWithOptions(DeleteUniversityStudentRequest request, DeleteUniversityStudentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            query.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentUserId)) {
            query.put("studentUserId", request.studentUserId);
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
            new TeaPair("action", "DeleteUniversityStudent"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/universities/students"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteUniversityStudentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除大学学生</p>
     * 
     * @param request DeleteUniversityStudentRequest
     * @return DeleteUniversityStudentResponse
     */
    public DeleteUniversityStudentResponse deleteUniversityStudent(DeleteUniversityStudentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteUniversityStudentHeaders headers = new DeleteUniversityStudentHeaders();
        return this.deleteUniversityStudentWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除大学教师</p>
     * 
     * @param request DeleteUniversityTeacherRequest
     * @param headers DeleteUniversityTeacherHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteUniversityTeacherResponse
     */
    public DeleteUniversityTeacherResponse deleteUniversityTeacherWithOptions(DeleteUniversityTeacherRequest request, DeleteUniversityTeacherHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            query.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.role)) {
            query.put("role", request.role);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherUserId)) {
            query.put("teacherUserId", request.teacherUserId);
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
            new TeaPair("action", "DeleteUniversityTeacher"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/universities/teachers"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteUniversityTeacherResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除大学教师</p>
     * 
     * @param request DeleteUniversityTeacherRequest
     * @return DeleteUniversityTeacherResponse
     */
    public DeleteUniversityTeacherResponse deleteUniversityTeacher(DeleteUniversityTeacherRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteUniversityTeacherHeaders headers = new DeleteUniversityTeacherHeaders();
        return this.deleteUniversityTeacherWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>设备心跳上报</p>
     * 
     * @param request DeviceHeartbeatRequest
     * @param headers DeviceHeartbeatHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeviceHeartbeatResponse
     */
    public DeviceHeartbeatResponse deviceHeartbeatWithOptions(DeviceHeartbeatRequest request, DeviceHeartbeatHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            query.put("sn", request.sn);
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
            new TeaPair("action", "DeviceHeartbeat"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/heartbeats/report"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeviceHeartbeatResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>设备心跳上报</p>
     * 
     * @param request DeviceHeartbeatRequest
     * @return DeviceHeartbeatResponse
     */
    public DeviceHeartbeatResponse deviceHeartbeat(DeviceHeartbeatRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeviceHeartbeatHeaders headers = new DeviceHeartbeatHeaders();
        return this.deviceHeartbeatWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>停用高校通讯录场景架构</p>
     * 
     * @param request DisableCollegeContactSceneStruRequest
     * @param headers DisableCollegeContactSceneStruHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DisableCollegeContactSceneStruResponse
     */
    public DisableCollegeContactSceneStruResponse disableCollegeContactSceneStruWithOptions(DisableCollegeContactSceneStruRequest request, DisableCollegeContactSceneStruHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.struId)) {
            body.put("struId", request.struId);
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
            new TeaPair("action", "DisableCollegeContactSceneStru"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/depts/structures/scenes/disable"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DisableCollegeContactSceneStruResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>停用高校通讯录场景架构</p>
     * 
     * @param request DisableCollegeContactSceneStruRequest
     * @return DisableCollegeContactSceneStruResponse
     */
    public DisableCollegeContactSceneStruResponse disableCollegeContactSceneStru(DisableCollegeContactSceneStruRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DisableCollegeContactSceneStruHeaders headers = new DisableCollegeContactSceneStruHeaders();
        return this.disableCollegeContactSceneStruWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>教育三方aigc结果回调</p>
     * 
     * @param request EduAIGCCallbackRequest
     * @param headers EduAIGCCallbackHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EduAIGCCallbackResponse
     */
    public EduAIGCCallbackResponse eduAIGCCallbackWithOptions(EduAIGCCallbackRequest request, EduAIGCCallbackHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channelCode)) {
            body.put("channelCode", request.channelCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.commitTime)) {
            body.put("commitTime", request.commitTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.completeTime)) {
            body.put("completeTime", request.completeTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contentSize)) {
            body.put("contentSize", request.contentSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contentType)) {
            body.put("contentType", request.contentType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.prompt)) {
            body.put("prompt", request.prompt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
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
            new TeaPair("action", "EduAIGCCallback"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/aigc/callback"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EduAIGCCallbackResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>教育三方aigc结果回调</p>
     * 
     * @param request EduAIGCCallbackRequest
     * @return EduAIGCCallbackResponse
     */
    public EduAIGCCallbackResponse eduAIGCCallback(EduAIGCCallbackRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EduAIGCCallbackHeaders headers = new EduAIGCCallbackHeaders();
        return this.eduAIGCCallbackWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>教育侧用户的所有角色</p>
     * 
     * @param request EduFindUserRolesByUserIdRequest
     * @param headers EduFindUserRolesByUserIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EduFindUserRolesByUserIdResponse
     */
    public EduFindUserRolesByUserIdResponse eduFindUserRolesByUserIdWithOptions(EduFindUserRolesByUserIdRequest request, EduFindUserRolesByUserIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            query.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hasOrgRole)) {
            query.put("hasOrgRole", request.hasOrgRole);
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
            new TeaPair("action", "EduFindUserRolesByUserId"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/users/allRoles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EduFindUserRolesByUserIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>教育侧用户的所有角色</p>
     * 
     * @param request EduFindUserRolesByUserIdRequest
     * @return EduFindUserRolesByUserIdResponse
     */
    public EduFindUserRolesByUserIdResponse eduFindUserRolesByUserId(EduFindUserRolesByUserIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EduFindUserRolesByUserIdHeaders headers = new EduFindUserRolesByUserIdHeaders();
        return this.eduFindUserRolesByUserIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户文件存储空间信息</p>
     * 
     * @param request EduGetFileSpaceRequest
     * @param headers EduGetFileSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EduGetFileSpaceResponse
     */
    public EduGetFileSpaceResponse eduGetFileSpaceWithOptions(EduGetFileSpaceRequest request, EduGetFileSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channelCode)) {
            body.put("channelCode", request.channelCode);
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
            new TeaPair("action", "EduGetFileSpace"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/files/spaces/infos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EduGetFileSpaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户文件存储空间信息</p>
     * 
     * @param request EduGetFileSpaceRequest
     * @return EduGetFileSpaceResponse
     */
    public EduGetFileSpaceResponse eduGetFileSpace(EduGetFileSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EduGetFileSpaceHeaders headers = new EduGetFileSpaceHeaders();
        return this.eduGetFileSpaceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>教育侧获取用户所有关系详情列表</p>
     * 
     * @param request EduListUserByFromUserIdsRequest
     * @param headers EduListUserByFromUserIdsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EduListUserByFromUserIdsResponse
     */
    public EduListUserByFromUserIdsResponse eduListUserByFromUserIdsWithOptions(EduListUserByFromUserIdsRequest request, EduListUserByFromUserIdsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            query.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.guardianUserId)) {
            query.put("guardianUserId", request.guardianUserId);
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
            new TeaPair("action", "EduListUserByFromUserIds"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/users/allRelations/lists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EduListUserByFromUserIdsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>教育侧获取用户所有关系详情列表</p>
     * 
     * @param request EduListUserByFromUserIdsRequest
     * @return EduListUserByFromUserIdsResponse
     */
    public EduListUserByFromUserIdsResponse eduListUserByFromUserIds(EduListUserByFromUserIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EduListUserByFromUserIdsHeaders headers = new EduListUserByFromUserIdsHeaders();
        return this.eduListUserByFromUserIdsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询教师列表</p>
     * 
     * @param request EduTeacherListRequest
     * @param headers EduTeacherListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EduTeacherListResponse
     */
    public EduTeacherListResponse eduTeacherListWithOptions(EduTeacherListRequest request, EduTeacherListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "EduTeacherList"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/teachers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EduTeacherListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询教师列表</p>
     * 
     * @param request EduTeacherListRequest
     * @return EduTeacherListResponse
     */
    public EduTeacherListResponse eduTeacherList(EduTeacherListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EduTeacherListHeaders headers = new EduTeacherListHeaders();
        return this.eduTeacherListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>启用高校通讯录场景架构</p>
     * 
     * @param request EnableCollegeContactSceneStruRequest
     * @param headers EnableCollegeContactSceneStruHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EnableCollegeContactSceneStruResponse
     */
    public EnableCollegeContactSceneStruResponse enableCollegeContactSceneStruWithOptions(EnableCollegeContactSceneStruRequest request, EnableCollegeContactSceneStruHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.struId)) {
            body.put("struId", request.struId);
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
            new TeaPair("action", "EnableCollegeContactSceneStru"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/depts/structures/scenes/enable"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EnableCollegeContactSceneStruResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>启用高校通讯录场景架构</p>
     * 
     * @param request EnableCollegeContactSceneStruRequest
     * @return EnableCollegeContactSceneStruResponse
     */
    public EnableCollegeContactSceneStruResponse enableCollegeContactSceneStru(EnableCollegeContactSceneStruRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EnableCollegeContactSceneStruHeaders headers = new EnableCollegeContactSceneStruHeaders();
        return this.enableCollegeContactSceneStruWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>关闭课程</p>
     * 
     * @param request EndCourseRequest
     * @param headers EndCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EndCourseResponse
     */
    public EndCourseResponse endCourseWithOptions(EndCourseRequest request, EndCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courseCode)) {
            body.put("courseCode", request.courseCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.livePlayInfoList)) {
            body.put("livePlayInfoList", request.livePlayInfoList);
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
            new TeaPair("action", "EndCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/universities/courses/end"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EndCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>关闭课程</p>
     * 
     * @param request EndCourseRequest
     * @return EndCourseResponse
     */
    public EndCourseResponse endCourse(EndCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EndCourseHeaders headers = new EndCourseHeaders();
        return this.endCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取绑定孩子信息</p>
     * 
     * @param request GetBindChildInfoRequest
     * @param headers GetBindChildInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetBindChildInfoResponse
     */
    public GetBindChildInfoResponse getBindChildInfoWithOptions(GetBindChildInfoRequest request, GetBindChildInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.schoolCorpId)) {
            query.put("schoolCorpId", request.schoolCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentUserId)) {
            query.put("studentUserId", request.studentUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "GetBindChildInfo"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/families/childs/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetBindChildInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取绑定孩子信息</p>
     * 
     * @param request GetBindChildInfoRequest
     * @return GetBindChildInfoResponse
     */
    public GetBindChildInfoResponse getBindChildInfo(GetBindChildInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetBindChildInfoHeaders headers = new GetBindChildInfoHeaders();
        return this.getBindChildInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户的孩子列表</p>
     * 
     * @param headers GetChildrenHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetChildrenResponse
     */
    public GetChildrenResponse getChildrenWithOptions(GetChildrenHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetChildren"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/children/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetChildrenResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户的孩子列表</p>
     * @return GetChildrenResponse
     */
    public GetChildrenResponse getChildren() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetChildrenHeaders headers = new GetChildrenHeaders();
        return this.getChildrenWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>高校校友会获取当前部门的所有子部门</p>
     * 
     * @param request GetCollegeAlumniDeptsRequest
     * @param headers GetCollegeAlumniDeptsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCollegeAlumniDeptsResponse
     */
    public GetCollegeAlumniDeptsResponse getCollegeAlumniDeptsWithOptions(GetCollegeAlumniDeptsRequest request, GetCollegeAlumniDeptsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
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
            new TeaPair("action", "GetCollegeAlumniDepts"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeAlumni/subDepts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCollegeAlumniDeptsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>高校校友会获取当前部门的所有子部门</p>
     * 
     * @param request GetCollegeAlumniDeptsRequest
     * @return GetCollegeAlumniDeptsResponse
     */
    public GetCollegeAlumniDeptsResponse getCollegeAlumniDepts(GetCollegeAlumniDeptsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCollegeAlumniDeptsHeaders headers = new GetCollegeAlumniDeptsHeaders();
        return this.getCollegeAlumniDeptsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>高校校友会查询校友信息</p>
     * 
     * @param request GetCollegeAlumniUserInfoRequest
     * @param headers GetCollegeAlumniUserInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCollegeAlumniUserInfoResponse
     */
    public GetCollegeAlumniUserInfoResponse getCollegeAlumniUserInfoWithOptions(GetCollegeAlumniUserInfoRequest request, GetCollegeAlumniUserInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
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
            new TeaPair("action", "GetCollegeAlumniUserInfo"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeAlumni/userInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCollegeAlumniUserInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>高校校友会查询校友信息</p>
     * 
     * @param request GetCollegeAlumniUserInfoRequest
     * @return GetCollegeAlumniUserInfoResponse
     */
    public GetCollegeAlumniUserInfoResponse getCollegeAlumniUserInfo(GetCollegeAlumniUserInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCollegeAlumniUserInfoHeaders headers = new GetCollegeAlumniUserInfoHeaders();
        return this.getCollegeAlumniUserInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取高校通讯录组织单元详情</p>
     * 
     * @param request GetCollegeContactDeptDetailRequest
     * @param headers GetCollegeContactDeptDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCollegeContactDeptDetailResponse
     */
    public GetCollegeContactDeptDetailResponse getCollegeContactDeptDetailWithOptions(GetCollegeContactDeptDetailRequest request, GetCollegeContactDeptDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
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
            new TeaPair("action", "GetCollegeContactDeptDetail"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/depts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCollegeContactDeptDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取高校通讯录组织单元详情</p>
     * 
     * @param request GetCollegeContactDeptDetailRequest
     * @return GetCollegeContactDeptDetailResponse
     */
    public GetCollegeContactDeptDetailResponse getCollegeContactDeptDetail(GetCollegeContactDeptDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCollegeContactDeptDetailHeaders headers = new GetCollegeContactDeptDetailHeaders();
        return this.getCollegeContactDeptDetailWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取行政组织架构信息</p>
     * 
     * @param request GetCollegeContactStandardStruDeptDetailRequest
     * @param headers GetCollegeContactStandardStruDeptDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCollegeContactStandardStruDeptDetailResponse
     */
    public GetCollegeContactStandardStruDeptDetailResponse getCollegeContactStandardStruDeptDetailWithOptions(GetCollegeContactStandardStruDeptDetailRequest request, GetCollegeContactStandardStruDeptDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
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
            new TeaPair("action", "GetCollegeContactStandardStruDeptDetail"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/depts/structures/standards"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCollegeContactStandardStruDeptDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取行政组织架构信息</p>
     * 
     * @param request GetCollegeContactStandardStruDeptDetailRequest
     * @return GetCollegeContactStandardStruDeptDetailResponse
     */
    public GetCollegeContactStandardStruDeptDetailResponse getCollegeContactStandardStruDeptDetail(GetCollegeContactStandardStruDeptDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCollegeContactStandardStruDeptDetailHeaders headers = new GetCollegeContactStandardStruDeptDetailHeaders();
        return this.getCollegeContactStandardStruDeptDetailWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取默认孩子信息</p>
     * 
     * @param headers GetDefaultChildHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDefaultChildResponse
     */
    public GetDefaultChildResponse getDefaultChildWithOptions(GetDefaultChildHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetDefaultChild"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/defaultChildren"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDefaultChildResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取默认孩子信息</p>
     * @return GetDefaultChildResponse
     */
    public GetDefaultChildResponse getDefaultChild() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDefaultChildHeaders headers = new GetDefaultChildHeaders();
        return this.getDefaultChildWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>阿里云盘教师节活动获取用户身份</p>
     * 
     * @param request GetEduUserIdentityRequest
     * @param headers GetEduUserIdentityHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetEduUserIdentityResponse
     */
    public GetEduUserIdentityResponse getEduUserIdentityWithOptions(GetEduUserIdentityRequest request, GetEduUserIdentityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "GetEduUserIdentity"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/apollos/activities/userIdentities"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetEduUserIdentityResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>阿里云盘教师节活动获取用户身份</p>
     * 
     * @param request GetEduUserIdentityRequest
     * @return GetEduUserIdentityResponse
     */
    public GetEduUserIdentityResponse getEduUserIdentity(GetEduUserIdentityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetEduUserIdentityHeaders headers = new GetEduUserIdentityHeaders();
        return this.getEduUserIdentityWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取文件下载信息</p>
     * 
     * @param request GetFileDownloadInfoRequest
     * @param headers GetFileDownloadInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFileDownloadInfoResponse
     */
    public GetFileDownloadInfoResponse getFileDownloadInfoWithOptions(GetFileDownloadInfoRequest request, GetFileDownloadInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fileIdList)) {
            body.put("fileIdList", request.fileIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceId)) {
            body.put("spaceId", request.spaceId);
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
            new TeaPair("action", "GetFileDownloadInfo"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/files/downloadInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFileDownloadInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取文件下载信息</p>
     * 
     * @param request GetFileDownloadInfoRequest
     * @return GetFileDownloadInfoResponse
     */
    public GetFileDownloadInfoResponse getFileDownloadInfo(GetFileDownloadInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFileDownloadInfoHeaders headers = new GetFileDownloadInfoHeaders();
        return this.getFileDownloadInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询文件和图片ID信息</p>
     * 
     * @param request GetFileDownloadInfoByPackageIdRequest
     * @param headers GetFileDownloadInfoByPackageIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFileDownloadInfoByPackageIdResponse
     */
    public GetFileDownloadInfoByPackageIdResponse getFileDownloadInfoByPackageIdWithOptions(GetFileDownloadInfoByPackageIdRequest request, GetFileDownloadInfoByPackageIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.packageId)) {
            body.put("packageId", request.packageId);
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
            new TeaPair("action", "GetFileDownloadInfoByPackageId"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/fileAndImages/ids/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFileDownloadInfoByPackageIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询文件和图片ID信息</p>
     * 
     * @param request GetFileDownloadInfoByPackageIdRequest
     * @return GetFileDownloadInfoByPackageIdResponse
     */
    public GetFileDownloadInfoByPackageIdResponse getFileDownloadInfoByPackageId(GetFileDownloadInfoByPackageIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFileDownloadInfoByPackageIdHeaders headers = new GetFileDownloadInfoByPackageIdHeaders();
        return this.getFileDownloadInfoByPackageIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取图片下载信息</p>
     * 
     * @param request GetImageTempDownloadUrlRequest
     * @param headers GetImageTempDownloadUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetImageTempDownloadUrlResponse
     */
    public GetImageTempDownloadUrlResponse getImageTempDownloadUrlWithOptions(GetImageTempDownloadUrlRequest request, GetImageTempDownloadUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceType)) {
            body.put("sourceType", request.sourceType);
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
            new TeaPair("action", "GetImageTempDownloadUrl"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/images/tempDownloadUrls/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetImageTempDownloadUrlResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取图片下载信息</p>
     * 
     * @param request GetImageTempDownloadUrlRequest
     * @return GetImageTempDownloadUrlResponse
     */
    public GetImageTempDownloadUrlResponse getImageTempDownloadUrl(GetImageTempDownloadUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetImageTempDownloadUrlHeaders headers = new GetImageTempDownloadUrlHeaders();
        return this.getImageTempDownloadUrlWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取公开课的课程详情</p>
     * 
     * @param headers GetOpenCourseDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOpenCourseDetailResponse
     */
    public GetOpenCourseDetailResponse getOpenCourseDetailWithOptions(String courseId, GetOpenCourseDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetOpenCourseDetail"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/openCourse/" + courseId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOpenCourseDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取公开课的课程详情</p>
     * @return GetOpenCourseDetailResponse
     */
    public GetOpenCourseDetailResponse getOpenCourseDetail(String courseId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOpenCourseDetailHeaders headers = new GetOpenCourseDetailHeaders();
        return this.getOpenCourseDetailWithOptions(courseId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取通过审核的课程列表</p>
     * 
     * @param request GetOpenCoursesRequest
     * @param headers GetOpenCoursesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOpenCoursesResponse
     */
    public GetOpenCoursesResponse getOpenCoursesWithOptions(GetOpenCoursesRequest request, GetOpenCoursesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetOpenCourses"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/openCourses"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOpenCoursesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取通过审核的课程列表</p>
     * 
     * @param request GetOpenCoursesRequest
     * @return GetOpenCoursesResponse
     */
    public GetOpenCoursesResponse getOpenCourses(GetOpenCoursesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOpenCoursesHeaders headers = new GetOpenCoursesHeaders();
        return this.getOpenCoursesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询教育积分流水记录</p>
     * 
     * @param tmpReq GetPointActionRecordRequest
     * @param headers GetPointActionRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPointActionRecordResponse
     */
    public GetPointActionRecordResponse getPointActionRecordWithOptions(GetPointActionRecordRequest tmpReq, GetPointActionRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        GetPointActionRecordShrinkRequest request = new GetPointActionRecordShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.body)) {
            request.bodyShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.body, "body", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bodyShrink)) {
            query.put("body", request.bodyShrink);
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
            new TeaPair("action", "GetPointActionRecord"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/points/actionRecords"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPointActionRecordResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询教育积分流水记录</p>
     * 
     * @param request GetPointActionRecordRequest
     * @return GetPointActionRecordResponse
     */
    public GetPointActionRecordResponse getPointActionRecord(GetPointActionRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPointActionRecordHeaders headers = new GetPointActionRecordHeaders();
        return this.getPointActionRecordWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询教育积分信息</p>
     * 
     * @param request GetPointInfoRequest
     * @param headers GetPointInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPointInfoResponse
     */
    public GetPointInfoResponse getPointInfoWithOptions(GetPointInfoRequest request, GetPointInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pointType)) {
            query.put("pointType", request.pointType);
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
            new TeaPair("action", "GetPointInfo"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/points/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPointInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询教育积分信息</p>
     * 
     * @param request GetPointInfoRequest
     * @return GetPointInfoResponse
     */
    public GetPointInfoResponse getPointInfo(GetPointInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPointInfoHeaders headers = new GetPointInfoHeaders();
        return this.getPointInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询专递课堂课程详情</p>
     * 
     * @param request GetRemoteClassCourseRequest
     * @param headers GetRemoteClassCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetRemoteClassCourseResponse
     */
    public GetRemoteClassCourseResponse getRemoteClassCourseWithOptions(String courseCode, GetRemoteClassCourseRequest request, GetRemoteClassCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
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
            new TeaPair("action", "GetRemoteClassCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/remoteClasses/courses/" + courseCode + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetRemoteClassCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询专递课堂课程详情</p>
     * 
     * @param request GetRemoteClassCourseRequest
     * @return GetRemoteClassCourseResponse
     */
    public GetRemoteClassCourseResponse getRemoteClassCourse(String courseCode, GetRemoteClassCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRemoteClassCourseHeaders headers = new GetRemoteClassCourseHeaders();
        return this.getRemoteClassCourseWithOptions(courseCode, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取共享角色成员</p>
     * 
     * @param headers GetShareRoleMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetShareRoleMembersResponse
     */
    public GetShareRoleMembersResponse getShareRoleMembersWithOptions(String shareRoleCode, GetShareRoleMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetShareRoleMembers"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/shareRoles/" + shareRoleCode + "/members"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetShareRoleMembersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取共享角色成员</p>
     * @return GetShareRoleMembersResponse
     */
    public GetShareRoleMembersResponse getShareRoleMembers(String shareRoleCode) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetShareRoleMembersHeaders headers = new GetShareRoleMembersHeaders();
        return this.getShareRoleMembersWithOptions(shareRoleCode, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取教育局的共享角色列表</p>
     * 
     * @param headers GetShareRolesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetShareRolesResponse
     */
    public GetShareRolesResponse getShareRolesWithOptions(GetShareRolesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetShareRoles"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/shareRoles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetShareRolesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取教育局的共享角色列表</p>
     * @return GetShareRolesResponse
     */
    public GetShareRolesResponse getShareRoles() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetShareRolesHeaders headers = new GetShareRolesHeaders();
        return this.getShareRolesWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询入学任务列表</p>
     * 
     * @param request GetTaskListRequest
     * @param headers GetTaskListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTaskListResponse
     */
    public GetTaskListResponse getTaskListWithOptions(GetTaskListRequest request, GetTaskListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskYear)) {
            query.put("taskYear", request.taskYear);
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
            new TeaPair("action", "GetTaskList"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/newGrades/tasks/lists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTaskListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询入学任务列表</p>
     * 
     * @param request GetTaskListRequest
     * @return GetTaskListResponse
     */
    public GetTaskListResponse getTaskList(GetTaskListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTaskListHeaders headers = new GetTaskListHeaders();
        return this.getTaskListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取入学任务下的学生列表</p>
     * 
     * @param request GetTaskStudentListRequest
     * @param headers GetTaskStudentListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTaskStudentListResponse
     */
    public GetTaskStudentListResponse getTaskStudentListWithOptions(GetTaskStudentListRequest request, GetTaskStudentListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            query.put("taskId", request.taskId);
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
            new TeaPair("action", "GetTaskStudentList"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/newGrades/tasks/students/lists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTaskStudentListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取入学任务下的学生列表</p>
     * 
     * @param request GetTaskStudentListRequest
     * @return GetTaskStudentListResponse
     */
    public GetTaskStudentListResponse getTaskStudentList(GetTaskStudentListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTaskStudentListHeaders headers = new GetTaskStudentListHeaders();
        return this.getTaskStudentListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>初始化班级课程表</p>
     * 
     * @param request InitCoursesOfClassRequest
     * @param headers InitCoursesOfClassHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InitCoursesOfClassResponse
     */
    public InitCoursesOfClassResponse initCoursesOfClassWithOptions(String classId, InitCoursesOfClassRequest request, InitCoursesOfClassHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courses)) {
            body.put("courses", request.courses);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sectionConfig)) {
            body.put("sectionConfig", request.sectionConfig);
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
            new TeaPair("action", "InitCoursesOfClass"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/classes/" + classId + "/courses/init"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InitCoursesOfClassResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>初始化班级课程表</p>
     * 
     * @param request InitCoursesOfClassRequest
     * @return InitCoursesOfClassResponse
     */
    public InitCoursesOfClassResponse initCoursesOfClass(String classId, InitCoursesOfClassRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InitCoursesOfClassHeaders headers = new InitCoursesOfClassHeaders();
        return this.initCoursesOfClassWithOptions(classId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>设备启动注册</p>
     * 
     * @param request InitDeviceRequest
     * @param headers InitDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InitDeviceResponse
     */
    public InitDeviceResponse initDeviceWithOptions(InitDeviceRequest request, InitDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.encryptPubKey)) {
            body.put("encryptPubKey", request.encryptPubKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signature)) {
            body.put("signature", request.signature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timestamp)) {
            body.put("timestamp", request.timestamp);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.version)) {
            body.put("version", request.version);
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
            new TeaPair("action", "InitDevice"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/devices/init"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InitDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>设备启动注册</p>
     * 
     * @param request InitDeviceRequest
     * @return InitDeviceResponse
     */
    public InitDeviceResponse initDevice(InitDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InitDeviceHeaders headers = new InitDeviceHeaders();
        return this.initDeviceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>视讯paas机具初始化</p>
     * 
     * @param request InitVPaasDeviceRequest
     * @param headers InitVPaasDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InitVPaasDeviceResponse
     */
    public InitVPaasDeviceResponse initVPaasDeviceWithOptions(InitVPaasDeviceRequest request, InitVPaasDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timestamp)) {
            body.put("timestamp", request.timestamp);
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
            new TeaPair("action", "InitVPaasDevice"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/vpaas/devices/init"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InitVPaasDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>视讯paas机具初始化</p>
     * 
     * @param request InitVPaasDeviceRequest
     * @return InitVPaasDeviceResponse
     */
    public InitVPaasDeviceResponse initVPaasDevice(InitVPaasDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InitVPaasDeviceHeaders headers = new InitVPaasDeviceHeaders();
        return this.initVPaasDeviceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>插入学校维度节次设置</p>
     * 
     * @param request InsertSectionConfigRequest
     * @param headers InsertSectionConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InsertSectionConfigResponse
     */
    public InsertSectionConfigResponse insertSectionConfigWithOptions(InsertSectionConfigRequest request, InsertSectionConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.end)) {
            body.put("end", request.end);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scheduleName)) {
            body.put("scheduleName", request.scheduleName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sectionModels)) {
            body.put("sectionModels", request.sectionModels);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.start)) {
            body.put("start", request.start);
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
            new TeaPair("action", "InsertSectionConfig"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/schedules/configs"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InsertSectionConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>插入学校维度节次设置</p>
     * 
     * @param request InsertSectionConfigRequest
     * @return InsertSectionConfigResponse
     */
    public InsertSectionConfigResponse insertSectionConfig(InsertSectionConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InsertSectionConfigHeaders headers = new InsertSectionConfigHeaders();
        return this.insertSectionConfigWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>失效课程</p>
     * 
     * @param request InvalidCourseRequest
     * @param headers InvalidCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InvalidCourseResponse
     */
    public InvalidCourseResponse invalidCourseWithOptions(InvalidCourseRequest request, InvalidCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            body.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCourseId)) {
            body.put("isvCourseId", request.isvCourseId);
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
            new TeaPair("action", "InvalidCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/courses/invalid"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InvalidCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>失效课程</p>
     * 
     * @param request InvalidCourseRequest
     * @return InvalidCourseResponse
     */
    public InvalidCourseResponse invalidCourse(InvalidCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InvalidCourseHeaders headers = new InvalidCourseHeaders();
        return this.invalidCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>失效教育套件</p>
     * 
     * @param request InvalidKitRequest
     * @param headers InvalidKitHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InvalidKitResponse
     */
    public InvalidKitResponse invalidKitWithOptions(InvalidKitRequest request, InvalidKitHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvProductScene)) {
            body.put("isvProductScene", request.isvProductScene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openUserId)) {
            body.put("openUserId", request.openUserId);
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
            new TeaPair("action", "InvalidKit"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/records/invalid"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InvalidKitResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>失效教育套件</p>
     * 
     * @param request InvalidKitRequest
     * @return InvalidKitResponse
     */
    public InvalidKitResponse invalidKit(InvalidKitRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InvalidKitHeaders headers = new InvalidKitHeaders();
        return this.invalidKitWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除学生班级</p>
     * 
     * @param request InvalidStudentClassRequest
     * @param headers InvalidStudentClassHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InvalidStudentClassResponse
     */
    public InvalidStudentClassResponse invalidStudentClassWithOptions(InvalidStudentClassRequest request, InvalidStudentClassHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            body.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classType)) {
            body.put("classType", request.classType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentUserIds)) {
            body.put("studentUserIds", request.studentUserIds);
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
            new TeaPair("action", "InvalidStudentClass"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/students/classes/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InvalidStudentClassResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除学生班级</p>
     * 
     * @param request InvalidStudentClassRequest
     * @return InvalidStudentClassResponse
     */
    public InvalidStudentClassResponse invalidStudentClass(InvalidStudentClassRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InvalidStudentClassHeaders headers = new InvalidStudentClassHeaders();
        return this.invalidStudentClassWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除老师课程</p>
     * 
     * @param request InvalidTeacherCourseRequest
     * @param headers InvalidTeacherCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InvalidTeacherCourseResponse
     */
    public InvalidTeacherCourseResponse invalidTeacherCourseWithOptions(InvalidTeacherCourseRequest request, InvalidTeacherCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.needDeleteCourseIdList)) {
            body.put("needDeleteCourseIdList", request.needDeleteCourseIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherUserId)) {
            body.put("teacherUserId", request.teacherUserId);
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
            new TeaPair("action", "InvalidTeacherCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/teachers/courses/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InvalidTeacherCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除老师课程</p>
     * 
     * @param request InvalidTeacherCourseRequest
     * @return InvalidTeacherCourseResponse
     */
    public InvalidTeacherCourseResponse invalidTeacherCourse(InvalidTeacherCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InvalidTeacherCourseHeaders headers = new InvalidTeacherCourseHeaders();
        return this.invalidTeacherCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查看用户是否是认证校的语文老师</p>
     * 
     * @param request IsYuwenCertifiedTeacherRequest
     * @param headers IsYuwenCertifiedTeacherHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IsYuwenCertifiedTeacherResponse
     */
    public IsYuwenCertifiedTeacherResponse isYuwenCertifiedTeacherWithOptions(IsYuwenCertifiedTeacherRequest request, IsYuwenCertifiedTeacherHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
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
            new TeaPair("action", "IsYuwenCertifiedTeacher"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/paas/certifiedTeachers/chineseTeachers/check"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IsYuwenCertifiedTeacherResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查看用户是否是认证校的语文老师</p>
     * 
     * @param request IsYuwenCertifiedTeacherRequest
     * @return IsYuwenCertifiedTeacherResponse
     */
    public IsYuwenCertifiedTeacherResponse isYuwenCertifiedTeacher(IsYuwenCertifiedTeacherRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IsYuwenCertifiedTeacherHeaders headers = new IsYuwenCertifiedTeacherHeaders();
        return this.isYuwenCertifiedTeacherWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>第三方数据写入</p>
     * 
     * @param request IsvDataWriteRequest
     * @param headers IsvDataWriteHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IsvDataWriteResponse
     */
    public IsvDataWriteResponse isvDataWriteWithOptions(IsvDataWriteRequest request, IsvDataWriteHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.objectCode)) {
            body.put("objectCode", request.objectCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rowValueList)) {
            body.put("rowValueList", request.rowValueList);
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
            new TeaPair("action", "IsvDataWrite"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/datas/write"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IsvDataWriteResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>第三方数据写入</p>
     * 
     * @param request IsvDataWriteRequest
     * @return IsvDataWriteResponse
     */
    public IsvDataWriteResponse isvDataWrite(IsvDataWriteRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IsvDataWriteHeaders headers = new IsvDataWriteHeaders();
        return this.isvDataWriteWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>Isv查询元数据信息</p>
     * 
     * @param request IsvMetadataQueryRequest
     * @param headers IsvMetadataQueryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IsvMetadataQueryResponse
     */
    public IsvMetadataQueryResponse isvMetadataQueryWithOptions(IsvMetadataQueryRequest request, IsvMetadataQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.objectCode)) {
            query.put("objectCode", request.objectCode);
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
            new TeaPair("action", "IsvMetadataQuery"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/datas/metadatas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IsvMetadataQueryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>Isv查询元数据信息</p>
     * 
     * @param request IsvMetadataQueryRequest
     * @return IsvMetadataQueryResponse
     */
    public IsvMetadataQueryResponse isvMetadataQuery(IsvMetadataQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IsvMetadataQueryHeaders headers = new IsvMetadataQueryHeaders();
        return this.isvMetadataQueryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取高校组织单元类型</p>
     * 
     * @param request ListCollegeContactDeptTypeConfigRequest
     * @param headers ListCollegeContactDeptTypeConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListCollegeContactDeptTypeConfigResponse
     */
    public ListCollegeContactDeptTypeConfigResponse listCollegeContactDeptTypeConfigWithOptions(ListCollegeContactDeptTypeConfigRequest request, ListCollegeContactDeptTypeConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
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
            new TeaPair("action", "ListCollegeContactDeptTypeConfig"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/configs/deptTypes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListCollegeContactDeptTypeConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取高校组织单元类型</p>
     * 
     * @param request ListCollegeContactDeptTypeConfigRequest
     * @return ListCollegeContactDeptTypeConfigResponse
     */
    public ListCollegeContactDeptTypeConfigResponse listCollegeContactDeptTypeConfig(ListCollegeContactDeptTypeConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListCollegeContactDeptTypeConfigHeaders headers = new ListCollegeContactDeptTypeConfigHeaders();
        return this.listCollegeContactDeptTypeConfigWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取高校通讯录场景架构列表</p>
     * 
     * @param request ListCollegeContactSceneStrusRequest
     * @param headers ListCollegeContactSceneStrusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListCollegeContactSceneStrusResponse
     */
    public ListCollegeContactSceneStrusResponse listCollegeContactSceneStrusWithOptions(ListCollegeContactSceneStrusRequest request, ListCollegeContactSceneStrusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
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
            new TeaPair("action", "ListCollegeContactSceneStrus"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/depts/structures/scenes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListCollegeContactSceneStrusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取高校通讯录场景架构列表</p>
     * 
     * @param request ListCollegeContactSceneStrusRequest
     * @return ListCollegeContactSceneStrusResponse
     */
    public ListCollegeContactSceneStrusResponse listCollegeContactSceneStrus(ListCollegeContactSceneStrusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListCollegeContactSceneStrusHeaders headers = new ListCollegeContactSceneStrusHeaders();
        return this.listCollegeContactSceneStrusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取高校通讯录子组织单元列表</p>
     * 
     * @param request ListCollegeContactSubDeptsRequest
     * @param headers ListCollegeContactSubDeptsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListCollegeContactSubDeptsResponse
     */
    public ListCollegeContactSubDeptsResponse listCollegeContactSubDeptsWithOptions(ListCollegeContactSubDeptsRequest request, ListCollegeContactSubDeptsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
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
            new TeaPair("action", "ListCollegeContactSubDepts"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/subDepts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListCollegeContactSubDeptsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取高校通讯录子组织单元列表</p>
     * 
     * @param request ListCollegeContactSubDeptsRequest
     * @return ListCollegeContactSubDeptsResponse
     */
    public ListCollegeContactSubDeptsResponse listCollegeContactSubDepts(ListCollegeContactSubDeptsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListCollegeContactSubDeptsHeaders headers = new ListCollegeContactSubDeptsHeaders();
        return this.listCollegeContactSubDeptsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询订单</p>
     * 
     * @param request ListOrderRequest
     * @param headers ListOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListOrderResponse
     */
    public ListOrderResponse listOrderWithOptions(ListOrderRequest request, ListOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.createTimeEnd)) {
            body.put("createTimeEnd", request.createTimeEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createTimeStart)) {
            body.put("createTimeStart", request.createTimeStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.merchantId)) {
            body.put("merchantId", request.merchantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            body.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scene)) {
            body.put("scene", request.scene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tradeNo)) {
            body.put("tradeNo", request.tradeNo);
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
            new TeaPair("action", "ListOrder"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/orders/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询订单</p>
     * 
     * @param request ListOrderRequest
     * @return ListOrderResponse
     */
    public ListOrderResponse listOrder(ListOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListOrderHeaders headers = new ListOrderHeaders();
        return this.listOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>学生调班，如果学生在本班有对应的家长，则家长也会跟同学生进行调整班级。</p>
     * 
     * @param request MoveStudentRequest
     * @param headers MoveStudentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MoveStudentResponse
     */
    public MoveStudentResponse moveStudentWithOptions(MoveStudentRequest request, MoveStudentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.originClassId)) {
            body.put("originClassId", request.originClassId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetClassId)) {
            body.put("targetClassId", request.targetClassId);
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
            new TeaPair("action", "MoveStudent"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/students/move"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MoveStudentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>学生调班，如果学生在本班有对应的家长，则家长也会跟同学生进行调整班级。</p>
     * 
     * @param request MoveStudentRequest
     * @return MoveStudentResponse
     */
    public MoveStudentResponse moveStudent(MoveStudentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MoveStudentHeaders headers = new MoveStudentHeaders();
        return this.moveStudentWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>开通教育套件</p>
     * 
     * @param request OpenKitRequest
     * @param headers OpenKitHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OpenKitResponse
     */
    public OpenKitResponse openKitWithOptions(OpenKitRequest request, OpenKitHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attributes)) {
            body.put("attributes", request.attributes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvProductScene)) {
            body.put("isvProductScene", request.isvProductScene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openEndTime)) {
            body.put("openEndTime", request.openEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openStartTime)) {
            body.put("openStartTime", request.openStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openUserId)) {
            body.put("openUserId", request.openUserId);
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
            new TeaPair("action", "OpenKit"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/records/open"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OpenKitResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>开通教育套件</p>
     * 
     * @param request OpenKitRequest
     * @return OpenKitResponse
     */
    public OpenKitResponse openKit(OpenKitRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OpenKitHeaders headers = new OpenKitHeaders();
        return this.openKitWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询订单信息</p>
     * 
     * @param request OrderInfoRequest
     * @param headers OrderInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OrderInfoResponse
     */
    public OrderInfoResponse orderInfoWithOptions(OrderInfoRequest request, OrderInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            query.put("orderNo", request.orderNo);
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
            new TeaPair("action", "OrderInfo"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/dingLifes/orders"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OrderInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询订单信息</p>
     * 
     * @param request OrderInfoRequest
     * @return OrderInfoResponse
     */
    public OrderInfoResponse orderInfo(OrderInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OrderInfoHeaders headers = new OrderInfoHeaders();
        return this.orderInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询班级课表</p>
     * 
     * @param request PageQueryClassCourseRequest
     * @param headers PageQueryClassCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PageQueryClassCourseResponse
     */
    public PageQueryClassCourseResponse pageQueryClassCourseWithOptions(PageQueryClassCourseRequest request, PageQueryClassCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            body.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endCourseDate)) {
            body.put("endCourseDate", request.endCourseDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startCourseDate)) {
            body.put("startCourseDate", request.startCourseDate);
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
            new TeaPair("action", "PageQueryClassCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/classes/courses/batchQuery"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PageQueryClassCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询班级课表</p>
     * 
     * @param request PageQueryClassCourseRequest
     * @return PageQueryClassCourseResponse
     */
    public PageQueryClassCourseResponse pageQueryClassCourse(PageQueryClassCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PageQueryClassCourseHeaders headers = new PageQueryClassCourseHeaders();
        return this.pageQueryClassCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询设备列表</p>
     * 
     * @param request PageQueryDevicesRequest
     * @param headers PageQueryDevicesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PageQueryDevicesResponse
     */
    public PageQueryDevicesResponse pageQueryDevicesWithOptions(PageQueryDevicesRequest request, PageQueryDevicesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            query.put("type", request.type);
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
            new TeaPair("action", "PageQueryDevices"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/vpaas/devices"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PageQueryDevicesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询设备列表</p>
     * 
     * @param request PageQueryDevicesRequest
     * @return PageQueryDevicesResponse
     */
    public PageQueryDevicesResponse pageQueryDevices(PageQueryDevicesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PageQueryDevicesHeaders headers = new PageQueryDevicesHeaders();
        return this.pageQueryDevicesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询套件开通记录</p>
     * 
     * @param request PageQueryKitOpenRecordRequest
     * @param headers PageQueryKitOpenRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PageQueryKitOpenRecordResponse
     */
    public PageQueryKitOpenRecordResponse pageQueryKitOpenRecordWithOptions(PageQueryKitOpenRecordRequest request, PageQueryKitOpenRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvProductScene)) {
            body.put("isvProductScene", request.isvProductScene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
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
            new TeaPair("action", "PageQueryKitOpenRecord"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/records/batchQuery"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PageQueryKitOpenRecordResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询套件开通记录</p>
     * 
     * @param request PageQueryKitOpenRecordRequest
     * @return PageQueryKitOpenRecordResponse
     */
    public PageQueryKitOpenRecordResponse pageQueryKitOpenRecord(PageQueryKitOpenRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PageQueryKitOpenRecordHeaders headers = new PageQueryKitOpenRecordHeaders();
        return this.pageQueryKitOpenRecordWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>支付订单</p>
     * 
     * @param request PayOrderRequest
     * @param headers PayOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PayOrderResponse
     */
    public PayOrderResponse payOrderWithOptions(PayOrderRequest request, PayOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.faceId)) {
            body.put("faceId", request.faceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            body.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signature)) {
            body.put("signature", request.signature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timestamp)) {
            body.put("timestamp", request.timestamp);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.version)) {
            body.put("version", request.version);
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
            new TeaPair("action", "PayOrder"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/orders/pay"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PayOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>支付订单</p>
     * 
     * @param request PayOrderRequest
     * @return PayOrderResponse
     */
    public PayOrderResponse payOrder(PayOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PayOrderHeaders headers = new PayOrderHeaders();
        return this.payOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>轮询课程状态，确认教师是否已同意开课</p>
     * 
     * @param request PollingConfirmStatusRequest
     * @param headers PollingConfirmStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PollingConfirmStatusResponse
     */
    public PollingConfirmStatusResponse pollingConfirmStatusWithOptions(PollingConfirmStatusRequest request, PollingConfirmStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courseCode)) {
            query.put("courseCode", request.courseCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            query.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            query.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
            new TeaPair("action", "PollingConfirmStatus"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/universities/courses/pollingConfirmStatus"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PollingConfirmStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>轮询课程状态，确认教师是否已同意开课</p>
     * 
     * @param request PollingConfirmStatusRequest
     * @return PollingConfirmStatusResponse
     */
    public PollingConfirmStatusResponse pollingConfirmStatus(PollingConfirmStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PollingConfirmStatusHeaders headers = new PollingConfirmStatusHeaders();
        return this.pollingConfirmStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>视讯paas机具预拨号</p>
     * 
     * @param request PreDialRequest
     * @param headers PreDialHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PreDialResponse
     */
    public PreDialResponse preDialWithOptions(PreDialRequest request, PreDialHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.callerUserId)) {
            body.put("callerUserId", request.callerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUserId)) {
            body.put("receiverUserId", request.receiverUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
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
            new TeaPair("action", "PreDial"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/vpaas/devices/preDial"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PreDialResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>视讯paas机具预拨号</p>
     * 
     * @param request PreDialRequest
     * @return PreDialResponse
     */
    public PreDialResponse preDial(PreDialRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PreDialHeaders headers = new PreDialHeaders();
        return this.preDialWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发放教育积分</p>
     * 
     * @param request ProvidePointRequest
     * @param headers ProvidePointHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ProvidePointResponse
     */
    public ProvidePointResponse providePointWithOptions(ProvidePointRequest request, ProvidePointHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionCode)) {
            body.put("actionCode", request.actionCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pointType)) {
            body.put("pointType", request.pointType);
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
            new TeaPair("action", "ProvidePoint"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/points/provide"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ProvidePointResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发放教育积分</p>
     * 
     * @param request ProvidePointRequest
     * @return ProvidePointResponse
     */
    public ProvidePointResponse providePoint(ProvidePointRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ProvidePointHeaders headers = new ProvidePointHeaders();
        return this.providePointWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发布成绩单</p>
     * 
     * @param request PublishSchoolReportRequest
     * @param headers PublishSchoolReportHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PublishSchoolReportResponse
     */
    public PublishSchoolReportResponse publishSchoolReportWithOptions(PublishSchoolReportRequest request, PublishSchoolReportHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classDetailItems)) {
            body.put("classDetailItems", request.classDetailItems);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.examClass)) {
            body.put("examClass", request.examClass);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.examTitle)) {
            body.put("examTitle", request.examTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.identifier)) {
            body.put("identifier", request.identifier);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.publishScope)) {
            body.put("publishScope", request.publishScope);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scoreType)) {
            body.put("scoreType", request.scoreType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.share)) {
            body.put("share", request.share);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.showRank)) {
            body.put("showRank", request.showRank);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.showStatisticsScore)) {
            body.put("showStatisticsScore", request.showStatisticsScore);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subScoreType)) {
            body.put("subScoreType", request.subScoreType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subjectList)) {
            body.put("subjectList", request.subjectList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subjects)) {
            body.put("subjects", request.subjects);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherId)) {
            body.put("teacherId", request.teacherId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherName)) {
            body.put("teacherName", request.teacherName);
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
            new TeaPair("action", "PublishSchoolReport"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/schools/reports/publish"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PublishSchoolReportResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发布成绩单</p>
     * 
     * @param request PublishSchoolReportRequest
     * @return PublishSchoolReportResponse
     */
    public PublishSchoolReportResponse publishSchoolReport(PublishSchoolReportRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PublishSchoolReportHeaders headers = new PublishSchoolReportHeaders();
        return this.publishSchoolReportWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询全量学科实例列表</p>
     * 
     * @param tmpReq QueryAllSubjectsFromClassScheduleRequest
     * @param headers QueryAllSubjectsFromClassScheduleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAllSubjectsFromClassScheduleResponse
     */
    public QueryAllSubjectsFromClassScheduleResponse queryAllSubjectsFromClassScheduleWithOptions(QueryAllSubjectsFromClassScheduleRequest tmpReq, QueryAllSubjectsFromClassScheduleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        QueryAllSubjectsFromClassScheduleShrinkRequest request = new QueryAllSubjectsFromClassScheduleShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.classIds)) {
            request.classIdsShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.classIds, "classIds", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classIdsShrink)) {
            query.put("classIds", request.classIdsShrink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodCode)) {
            query.put("periodCode", request.periodCode);
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
            new TeaPair("action", "QueryAllSubjectsFromClassSchedule"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/subjects/instances"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAllSubjectsFromClassScheduleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询全量学科实例列表</p>
     * 
     * @param request QueryAllSubjectsFromClassScheduleRequest
     * @return QueryAllSubjectsFromClassScheduleResponse
     */
    public QueryAllSubjectsFromClassScheduleResponse queryAllSubjectsFromClassSchedule(QueryAllSubjectsFromClassScheduleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllSubjectsFromClassScheduleHeaders headers = new QueryAllSubjectsFromClassScheduleHeaders();
        return this.queryAllSubjectsFromClassScheduleWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询课程表</p>
     * 
     * @param request QueryClassScheduleRequest
     * @param headers QueryClassScheduleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryClassScheduleResponse
     */
    public QueryClassScheduleResponse queryClassScheduleWithOptions(QueryClassScheduleRequest request, QueryClassScheduleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subscriberType)) {
            query.put("subscriberType", request.subscriberType);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sectionIndexList)) {
            body.put("sectionIndexList", request.sectionIndexList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subscriberIds)) {
            body.put("subscriberIds", request.subscriberIds);
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
            new TeaPair("action", "QueryClassSchedule"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/classes/schedules/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryClassScheduleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询课程表</p>
     * 
     * @param request QueryClassScheduleRequest
     * @return QueryClassScheduleResponse
     */
    public QueryClassScheduleResponse queryClassSchedule(QueryClassScheduleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryClassScheduleHeaders headers = new QueryClassScheduleHeaders();
        return this.queryClassScheduleWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>按照学校和时间区间筛选课程</p>
     * 
     * @param request QueryClassScheduleByTimeSchoolRequest
     * @param headers QueryClassScheduleByTimeSchoolHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryClassScheduleByTimeSchoolResponse
     */
    public QueryClassScheduleByTimeSchoolResponse queryClassScheduleByTimeSchoolWithOptions(QueryClassScheduleByTimeSchoolRequest request, QueryClassScheduleByTimeSchoolHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
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
            new TeaPair("action", "QueryClassScheduleByTimeSchool"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/schools/classes/courses "),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryClassScheduleByTimeSchoolResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>按照学校和时间区间筛选课程</p>
     * 
     * @param request QueryClassScheduleByTimeSchoolRequest
     * @return QueryClassScheduleByTimeSchoolResponse
     */
    public QueryClassScheduleByTimeSchoolResponse queryClassScheduleByTimeSchool(QueryClassScheduleByTimeSchoolRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryClassScheduleByTimeSchoolHeaders headers = new QueryClassScheduleByTimeSchoolHeaders();
        return this.queryClassScheduleByTimeSchoolWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取课程表设置</p>
     * 
     * @param tmpReq QueryClassScheduleConfigRequest
     * @param headers QueryClassScheduleConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryClassScheduleConfigResponse
     */
    public QueryClassScheduleConfigResponse queryClassScheduleConfigWithOptions(QueryClassScheduleConfigRequest tmpReq, QueryClassScheduleConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        QueryClassScheduleConfigShrinkRequest request = new QueryClassScheduleConfigShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.classIds)) {
            request.classIdsShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.classIds, "classIds", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classIdsShrink)) {
            query.put("classIds", request.classIdsShrink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
            new TeaPair("action", "QueryClassScheduleConfig"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/schedules/configs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryClassScheduleConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取课程表设置</p>
     * 
     * @param request QueryClassScheduleConfigRequest
     * @return QueryClassScheduleConfigResponse
     */
    public QueryClassScheduleConfigResponse queryClassScheduleConfig(QueryClassScheduleConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryClassScheduleConfigHeaders headers = new QueryClassScheduleConfigHeaders();
        return this.queryClassScheduleConfigWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户详情(包含高校账号)</p>
     * 
     * @param request QueryCollegeContactUserDetailRequest
     * @param headers QueryCollegeContactUserDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCollegeContactUserDetailResponse
     */
    public QueryCollegeContactUserDetailResponse queryCollegeContactUserDetailWithOptions(QueryCollegeContactUserDetailRequest request, QueryCollegeContactUserDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.jobNumber)) {
            query.put("jobNumber", request.jobNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userid)) {
            query.put("userid", request.userid);
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
            new TeaPair("action", "QueryCollegeContactUserDetail"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/users"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCollegeContactUserDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户详情(包含高校账号)</p>
     * 
     * @param request QueryCollegeContactUserDetailRequest
     * @return QueryCollegeContactUserDetailResponse
     */
    public QueryCollegeContactUserDetailResponse queryCollegeContactUserDetail(QueryCollegeContactUserDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCollegeContactUserDetailHeaders headers = new QueryCollegeContactUserDetailHeaders();
        return this.queryCollegeContactUserDetailWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询单台视讯PAAS设备</p>
     * 
     * @param request QueryDeviceRequest
     * @param headers QueryDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDeviceResponse
     */
    public QueryDeviceResponse queryDeviceWithOptions(QueryDeviceRequest request, QueryDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            query.put("sn", request.sn);
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
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/vpass/devices/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询单台视讯PAAS设备</p>
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
     * <p>查询某个组织下面的设备列表</p>
     * 
     * @param request QueryDeviceListByCorpIdRequest
     * @param headers QueryDeviceListByCorpIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDeviceListByCorpIdResponse
     */
    public QueryDeviceListByCorpIdResponse queryDeviceListByCorpIdWithOptions(QueryDeviceListByCorpIdRequest request, QueryDeviceListByCorpIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
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
            new TeaPair("action", "QueryDeviceListByCorpId"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/remoteClasses/devices"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDeviceListByCorpIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询某个组织下面的设备列表</p>
     * 
     * @param request QueryDeviceListByCorpIdRequest
     * @return QueryDeviceListByCorpIdResponse
     */
    public QueryDeviceListByCorpIdResponse queryDeviceListByCorpId(QueryDeviceListByCorpIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDeviceListByCorpIdHeaders headers = new QueryDeviceListByCorpIdHeaders();
        return this.queryDeviceListByCorpIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>教学资源库查询space列表</p>
     * 
     * @param request QueryEduAssetSpacesRequest
     * @param headers QueryEduAssetSpacesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryEduAssetSpacesResponse
     */
    public QueryEduAssetSpacesResponse queryEduAssetSpacesWithOptions(QueryEduAssetSpacesRequest request, QueryEduAssetSpacesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
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
            new TeaPair("action", "QueryEduAssetSpaces"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/assets/spaces"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryEduAssetSpacesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>教学资源库查询space列表</p>
     * 
     * @param request QueryEduAssetSpacesRequest
     * @return QueryEduAssetSpacesResponse
     */
    public QueryEduAssetSpacesResponse queryEduAssetSpaces(QueryEduAssetSpacesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryEduAssetSpacesHeaders headers = new QueryEduAssetSpacesHeaders();
        return this.queryEduAssetSpacesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据设备SN信息查询学校人脸库</p>
     * 
     * @param request QueryGroupIdRequest
     * @param headers QueryGroupIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryGroupIdResponse
     */
    public QueryGroupIdResponse queryGroupIdWithOptions(QueryGroupIdRequest request, QueryGroupIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            query.put("sn", request.sn);
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
            new TeaPair("action", "QueryGroupId"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/faces/groups"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryGroupIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据设备SN信息查询学校人脸库</p>
     * 
     * @param request QueryGroupIdRequest
     * @return QueryGroupIdResponse
     */
    public QueryGroupIdResponse queryGroupId(QueryGroupIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryGroupIdHeaders headers = new QueryGroupIdHeaders();
        return this.queryGroupIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询套件开通记录</p>
     * 
     * @param request QueryKitOpenRecordRequest
     * @param headers QueryKitOpenRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryKitOpenRecordResponse
     */
    public QueryKitOpenRecordResponse queryKitOpenRecordWithOptions(QueryKitOpenRecordRequest request, QueryKitOpenRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvProductScene)) {
            body.put("isvProductScene", request.isvProductScene);
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
            new TeaPair("action", "QueryKitOpenRecord"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/records/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryKitOpenRecordResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询套件开通记录</p>
     * 
     * @param request QueryKitOpenRecordRequest
     * @return QueryKitOpenRecordResponse
     */
    public QueryKitOpenRecordResponse queryKitOpenRecord(QueryKitOpenRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryKitOpenRecordHeaders headers = new QueryKitOpenRecordHeaders();
        return this.queryKitOpenRecordWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询订单信息</p>
     * 
     * @param request QueryOrderRequest
     * @param headers QueryOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryOrderResponse
     */
    public QueryOrderResponse queryOrderWithOptions(QueryOrderRequest request, QueryOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.alipayAppId)) {
            query.put("alipayAppId", request.alipayAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.merchantId)) {
            query.put("merchantId", request.merchantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            query.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signature)) {
            query.put("signature", request.signature);
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
            new TeaPair("action", "QueryOrder"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/orders"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询订单信息</p>
     * 
     * @param request QueryOrderRequest
     * @return QueryOrderResponse
     */
    public QueryOrderResponse queryOrder(QueryOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOrderHeaders headers = new QueryOrderHeaders();
        return this.queryOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询某个组织下面关联的组织列表</p>
     * 
     * @param request QueryOrgRelationListRequest
     * @param headers QueryOrgRelationListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryOrgRelationListResponse
     */
    public QueryOrgRelationListResponse queryOrgRelationListWithOptions(QueryOrgRelationListRequest request, QueryOrgRelationListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
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
            new TeaPair("action", "QueryOrgRelationList"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/remoteClasses/orgRelations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryOrgRelationListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询某个组织下面关联的组织列表</p>
     * 
     * @param request QueryOrgRelationListRequest
     * @return QueryOrgRelationListResponse
     */
    public QueryOrgRelationListResponse queryOrgRelationList(QueryOrgRelationListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOrgRelationListHeaders headers = new QueryOrgRelationListHeaders();
        return this.queryOrgRelationListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取组织秘钥</p>
     * 
     * @param request QueryOrgSecretKeyRequest
     * @param headers QueryOrgSecretKeyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryOrgSecretKeyResponse
     */
    public QueryOrgSecretKeyResponse queryOrgSecretKeyWithOptions(QueryOrgSecretKeyRequest request, QueryOrgSecretKeyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            query.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
            new TeaPair("action", "QueryOrgSecretKey"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/universities/secretKeys"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryOrgSecretKeyResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取组织秘钥</p>
     * 
     * @param request QueryOrgSecretKeyRequest
     * @return QueryOrgSecretKeyResponse
     */
    public QueryOrgSecretKeyResponse queryOrgSecretKey(QueryOrgSecretKeyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOrgSecretKeyHeaders headers = new QueryOrgSecretKeyHeaders();
        return this.queryOrgSecretKeyWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询教育组织类型</p>
     * 
     * @param headers QueryOrgTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryOrgTypeResponse
     */
    public QueryOrgTypeResponse queryOrgTypeWithOptions(QueryOrgTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryOrgType"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/orgTypes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryOrgTypeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询教育组织类型</p>
     * @return QueryOrgTypeResponse
     */
    public QueryOrgTypeResponse queryOrgType() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOrgTypeHeaders headers = new QueryOrgTypeHeaders();
        return this.queryOrgTypeWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询支付结果</p>
     * 
     * @param request QueryPayResultRequest
     * @param headers QueryPayResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryPayResultResponse
     */
    public QueryPayResultResponse queryPayResultWithOptions(QueryPayResultRequest request, QueryPayResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.faceId)) {
            body.put("faceId", request.faceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            body.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signature)) {
            body.put("signature", request.signature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timestamp)) {
            body.put("timestamp", request.timestamp);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.version)) {
            body.put("version", request.version);
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
            new TeaPair("action", "QueryPayResult"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/payResults/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryPayResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询支付结果</p>
     * 
     * @param request QueryPayResultRequest
     * @return QueryPayResultResponse
     */
    public QueryPayResultResponse queryPayResult(QueryPayResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPayResultHeaders headers = new QueryPayResultHeaders();
        return this.queryPayResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询物理教室信息</p>
     * 
     * @param request QueryPhysicalClassroomRequest
     * @param headers QueryPhysicalClassroomHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryPhysicalClassroomResponse
     */
    public QueryPhysicalClassroomResponse queryPhysicalClassroomWithOptions(QueryPhysicalClassroomRequest request, QueryPhysicalClassroomHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classroomId)) {
            query.put("classroomId", request.classroomId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
            new TeaPair("action", "QueryPhysicalClassroom"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/physicalClassrooms"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryPhysicalClassroomResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询物理教室信息</p>
     * 
     * @param request QueryPhysicalClassroomRequest
     * @return QueryPhysicalClassroomResponse
     */
    public QueryPhysicalClassroomResponse queryPhysicalClassroom(QueryPhysicalClassroomRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPhysicalClassroomHeaders headers = new QueryPhysicalClassroomHeaders();
        return this.queryPhysicalClassroomWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户订购服务状态</p>
     * 
     * @param request QueryPurchaseInfoRequest
     * @param headers QueryPurchaseInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryPurchaseInfoResponse
     */
    public QueryPurchaseInfoResponse queryPurchaseInfoWithOptions(QueryPurchaseInfoRequest request, QueryPurchaseInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.merchantId)) {
            query.put("merchantId", request.merchantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scene)) {
            query.put("scene", request.scene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            query.put("sn", request.sn);
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
            new TeaPair("action", "QueryPurchaseInfo"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/users/purchases"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryPurchaseInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户订购服务状态</p>
     * 
     * @param request QueryPurchaseInfoRequest
     * @return QueryPurchaseInfoResponse
     */
    public QueryPurchaseInfoResponse queryPurchaseInfo(QueryPurchaseInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPurchaseInfoHeaders headers = new QueryPurchaseInfoHeaders();
        return this.queryPurchaseInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询课程列表</p>
     * 
     * @param request QueryRemoteClassCourseRequest
     * @param headers QueryRemoteClassCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryRemoteClassCourseResponse
     */
    public QueryRemoteClassCourseResponse queryRemoteClassCourseWithOptions(QueryRemoteClassCourseRequest request, QueryRemoteClassCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
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
            new TeaPair("action", "QueryRemoteClassCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/remoteClasses/courses"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryRemoteClassCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询课程列表</p>
     * 
     * @param request QueryRemoteClassCourseRequest
     * @return QueryRemoteClassCourseResponse
     */
    public QueryRemoteClassCourseResponse queryRemoteClassCourse(QueryRemoteClassCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryRemoteClassCourseHeaders headers = new QueryRemoteClassCourseHeaders();
        return this.queryRemoteClassCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分批查询学校人脸id</p>
     * 
     * @param request QuerySchoolUserFaceRequest
     * @param headers QuerySchoolUserFaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QuerySchoolUserFaceResponse
     */
    public QuerySchoolUserFaceResponse querySchoolUserFaceWithOptions(QuerySchoolUserFaceRequest request, QuerySchoolUserFaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            query.put("sn", request.sn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            query.put("type", request.type);
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
            new TeaPair("action", "QuerySchoolUserFace"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/schools/faces"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QuerySchoolUserFaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分批查询学校人脸id</p>
     * 
     * @param request QuerySchoolUserFaceRequest
     * @return QuerySchoolUserFaceResponse
     */
    public QuerySchoolUserFaceResponse querySchoolUserFace(QuerySchoolUserFaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySchoolUserFaceHeaders headers = new QuerySchoolUserFaceHeaders();
        return this.querySchoolUserFaceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>个人应用查询订单信息</p>
     * 
     * @param request QuerySnsOrderRequest
     * @param headers QuerySnsOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QuerySnsOrderResponse
     */
    public QuerySnsOrderResponse querySnsOrderWithOptions(QuerySnsOrderRequest request, QuerySnsOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.alipayAppId)) {
            query.put("alipayAppId", request.alipayAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.merchantId)) {
            query.put("merchantId", request.merchantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            query.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signature)) {
            query.put("signature", request.signature);
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
            new TeaPair("action", "QuerySnsOrder"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/snsOrders"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QuerySnsOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>个人应用查询订单信息</p>
     * 
     * @param request QuerySnsOrderRequest
     * @return QuerySnsOrderResponse
     */
    public QuerySnsOrderResponse querySnsOrder(QuerySnsOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySnsOrderHeaders headers = new QuerySnsOrderHeaders();
        return this.querySnsOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获得课程表详细信息</p>
     * 
     * @param request QueryStatisticsDataRequest
     * @param headers QueryStatisticsDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryStatisticsDataResponse
     */
    public QueryStatisticsDataResponse queryStatisticsDataWithOptions(QueryStatisticsDataRequest request, QueryStatisticsDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sectionIndexList)) {
            body.put("sectionIndexList", request.sectionIndexList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherUserIds)) {
            body.put("teacherUserIds", request.teacherUserIds);
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
            new TeaPair("action", "QueryStatisticsData"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/classes/schedules/statisticData/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryStatisticsDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获得课程表详细信息</p>
     * 
     * @param request QueryStatisticsDataRequest
     * @return QueryStatisticsDataResponse
     */
    public QueryStatisticsDataResponse queryStatisticsData(QueryStatisticsDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryStatisticsDataHeaders headers = new QueryStatisticsDataHeaders();
        return this.queryStatisticsDataWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询学生班级</p>
     * 
     * @param request QueryStudentClassRequest
     * @param headers QueryStudentClassHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryStudentClassResponse
     */
    public QueryStudentClassResponse queryStudentClassWithOptions(QueryStudentClassRequest request, QueryStudentClassHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            body.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classType)) {
            body.put("classType", request.classType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentUserIds)) {
            body.put("studentUserIds", request.studentUserIds);
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
            new TeaPair("action", "QueryStudentClass"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/students/classes/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryStudentClassResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询学生班级</p>
     * 
     * @param request QueryStudentClassRequest
     * @return QueryStudentClassResponse
     */
    public QueryStudentClassResponse queryStudentClass(QueryStudentClassRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryStudentClassHeaders headers = new QueryStudentClassHeaders();
        return this.queryStudentClassWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询教授某学科老师列表</p>
     * 
     * @param request QuerySubjectTeachersRequest
     * @param headers QuerySubjectTeachersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QuerySubjectTeachersResponse
     */
    public QuerySubjectTeachersResponse querySubjectTeachersWithOptions(QuerySubjectTeachersRequest request, QuerySubjectTeachersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classIds)) {
            query.put("classIds", request.classIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subjectCode)) {
            query.put("subjectCode", request.subjectCode);
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
            new TeaPair("action", "QuerySubjectTeachers"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/subjects/teachers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QuerySubjectTeachersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询教授某学科老师列表</p>
     * 
     * @param request QuerySubjectTeachersRequest
     * @return QuerySubjectTeachersResponse
     */
    public QuerySubjectTeachersResponse querySubjectTeachers(QuerySubjectTeachersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySubjectTeachersHeaders headers = new QuerySubjectTeachersHeaders();
        return this.querySubjectTeachersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询老师教授学科列表</p>
     * 
     * @param request QueryTeachSubjectsRequest
     * @param headers QueryTeachSubjectsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryTeachSubjectsResponse
     */
    public QueryTeachSubjectsResponse queryTeachSubjectsWithOptions(QueryTeachSubjectsRequest request, QueryTeachSubjectsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classIds)) {
            query.put("classIds", request.classIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
            new TeaPair("action", "QueryTeachSubjects"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/teachers/subjects"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryTeachSubjectsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询老师教授学科列表</p>
     * 
     * @param request QueryTeachSubjectsRequest
     * @return QueryTeachSubjectsResponse
     */
    public QueryTeachSubjectsResponse queryTeachSubjects(QueryTeachSubjectsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryTeachSubjectsHeaders headers = new QueryTeachSubjectsHeaders();
        return this.queryTeachSubjectsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询老师课程</p>
     * 
     * @param request QueryTeacherCourseRequest
     * @param headers QueryTeacherCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryTeacherCourseResponse
     */
    public QueryTeacherCourseResponse queryTeacherCourseWithOptions(QueryTeacherCourseRequest request, QueryTeacherCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCourseIdList)) {
            body.put("isvCourseIdList", request.isvCourseIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherUserId)) {
            body.put("teacherUserId", request.teacherUserId);
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
            new TeaPair("action", "QueryTeacherCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/teachers/courses/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryTeacherCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询老师课程</p>
     * 
     * @param request QueryTeacherCourseRequest
     * @return QueryTeacherCourseResponse
     */
    public QueryTeacherCourseResponse queryTeacherCourse(QueryTeacherCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryTeacherCourseHeaders headers = new QueryTeacherCourseHeaders();
        return this.queryTeacherCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询调代课记录</p>
     * 
     * @param request QueryTransferCourseRequest
     * @param headers QueryTransferCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryTransferCourseResponse
     */
    public QueryTransferCourseResponse queryTransferCourseWithOptions(QueryTransferCourseRequest request, QueryTransferCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvRecordId)) {
            body.put("isvRecordId", request.isvRecordId);
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
            new TeaPair("action", "QueryTransferCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/transferRecords/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryTransferCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询调代课记录</p>
     * 
     * @param request QueryTransferCourseRequest
     * @return QueryTransferCourseResponse
     */
    public QueryTransferCourseResponse queryTransferCourse(QueryTransferCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryTransferCourseHeaders headers = new QueryTransferCourseHeaders();
        return this.queryTransferCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询大学课程组</p>
     * 
     * @param request QueryUniversityCourseGroupRequest
     * @param headers QueryUniversityCourseGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUniversityCourseGroupResponse
     */
    public QueryUniversityCourseGroupResponse queryUniversityCourseGroupWithOptions(QueryUniversityCourseGroupRequest request, QueryUniversityCourseGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupCode)) {
            query.put("courseGroupCode", request.courseGroupCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
            new TeaPair("action", "QueryUniversityCourseGroup"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/universities/courseGroups"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUniversityCourseGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询大学课程组</p>
     * 
     * @param request QueryUniversityCourseGroupRequest
     * @return QueryUniversityCourseGroupResponse
     */
    public QueryUniversityCourseGroupResponse queryUniversityCourseGroup(QueryUniversityCourseGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUniversityCourseGroupHeaders headers = new QueryUniversityCourseGroupHeaders();
        return this.queryUniversityCourseGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据人脸id查询用户信息</p>
     * 
     * @param request QueryUserFaceRequest
     * @param headers QueryUserFaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserFaceResponse
     */
    public QueryUserFaceResponse queryUserFaceWithOptions(QueryUserFaceRequest request, QueryUserFaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.faceId)) {
            query.put("faceId", request.faceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            query.put("sn", request.sn);
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
            new TeaPair("action", "QueryUserFace"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/users/faces"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserFaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据人脸id查询用户信息</p>
     * 
     * @param request QueryUserFaceRequest
     * @return QueryUserFaceResponse
     */
    public QueryUserFaceResponse queryUserFace(QueryUserFaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserFaceHeaders headers = new QueryUserFaceHeaders();
        return this.queryUserFaceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户支付信息</p>
     * 
     * @param request QueryUserPayInfoRequest
     * @param headers QueryUserPayInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserPayInfoResponse
     */
    public QueryUserPayInfoResponse queryUserPayInfoWithOptions(QueryUserPayInfoRequest request, QueryUserPayInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.faceId)) {
            query.put("faceId", request.faceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            query.put("sn", request.sn);
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
            new TeaPair("action", "QueryUserPayInfo"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/orders/payInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserPayInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户支付信息</p>
     * 
     * @param request QueryUserPayInfoRequest
     * @return QueryUserPayInfoResponse
     */
    public QueryUserPayInfoResponse queryUserPayInfo(QueryUserPayInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserPayInfoHeaders headers = new QueryUserPayInfoHeaders();
        return this.queryUserPayInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>移除设备</p>
     * 
     * @param request RemoveDeviceRequest
     * @param headers RemoveDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RemoveDeviceResponse
     */
    public RemoveDeviceResponse removeDeviceWithOptions(RemoveDeviceRequest request, RemoveDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.merchantId)) {
            query.put("merchantId", request.merchantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            query.put("sn", request.sn);
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
            new TeaPair("action", "RemoveDevice"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/devices"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RemoveDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>移除设备</p>
     * 
     * @param request RemoveDeviceRequest
     * @return RemoveDeviceResponse
     */
    public RemoveDeviceResponse removeDevice(RemoveDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveDeviceHeaders headers = new RemoveDeviceHeaders();
        return this.removeDeviceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>设备日志上报接口</p>
     * 
     * @param request ReportDeviceLogRequest
     * @param headers ReportDeviceLogHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ReportDeviceLogResponse
     */
    public ReportDeviceLogResponse reportDeviceLogWithOptions(ReportDeviceLogRequest request, ReportDeviceLogHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            query.put("mediaId", request.mediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            query.put("sn", request.sn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            query.put("type", request.type);
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
            new TeaPair("action", "ReportDeviceLog"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/deviceLogs/report"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ReportDeviceLogResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>设备日志上报接口</p>
     * 
     * @param request ReportDeviceLogRequest
     * @return ReportDeviceLogResponse
     */
    public ReportDeviceLogResponse reportDeviceLog(ReportDeviceLogRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReportDeviceLogHeaders headers = new ReportDeviceLogHeaders();
        return this.reportDeviceLogWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>上传设备使用日志</p>
     * 
     * @param request ReportDeviceUseLogRequest
     * @param headers ReportDeviceUseLogHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ReportDeviceUseLogResponse
     */
    public ReportDeviceUseLogResponse reportDeviceUseLogWithOptions(ReportDeviceUseLogRequest request, ReportDeviceUseLogHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            body.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
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
            new TeaPair("action", "ReportDeviceUseLog"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/deviceUseLogs/report"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ReportDeviceUseLogResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>上传设备使用日志</p>
     * 
     * @param request ReportDeviceUseLogRequest
     * @return ReportDeviceUseLogResponse
     */
    public ReportDeviceUseLogResponse reportDeviceUseLog(ReportDeviceUseLogRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReportDeviceUseLogHeaders headers = new ReportDeviceUseLogHeaders();
        return this.reportDeviceUseLogWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>回滚教育积分扣减</p>
     * 
     * @param request RollbackDeductPointRequest
     * @param headers RollbackDeductPointHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RollbackDeductPointResponse
     */
    public RollbackDeductPointResponse rollbackDeductPointWithOptions(RollbackDeductPointRequest request, RollbackDeductPointHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pointType)) {
            body.put("pointType", request.pointType);
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
            new TeaPair("action", "RollbackDeductPoint"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/deductPoints/rollback"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RollbackDeductPointResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>回滚教育积分扣减</p>
     * 
     * @param request RollbackDeductPointRequest
     * @return RollbackDeductPointResponse
     */
    public RollbackDeductPointResponse rollbackDeductPoint(RollbackDeductPointRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RollbackDeductPointHeaders headers = new RollbackDeductPointHeaders();
        return this.rollbackDeductPointWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>保存班级学情数据</p>
     * 
     * @param request SaveClassLearningDataRequest
     * @param headers SaveClassLearningDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveClassLearningDataResponse
     */
    public SaveClassLearningDataResponse saveClassLearningDataWithOptions(SaveClassLearningDataRequest request, SaveClassLearningDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.assignNum)) {
            body.put("assignNum", request.assignNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.assignStudentUserIds)) {
            body.put("assignStudentUserIds", request.assignStudentUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileSuffix)) {
            body.put("fileSuffix", request.fileSuffix);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.generatedTime)) {
            body.put("generatedTime", request.generatedTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.questionNum)) {
            body.put("questionNum", request.questionNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.questionPictureNum)) {
            body.put("questionPictureNum", request.questionPictureNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.standardAnswerPictureNum)) {
            body.put("standardAnswerPictureNum", request.standardAnswerPictureNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subjectCode)) {
            body.put("subjectCode", request.subjectCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teacherUserId)) {
            body.put("teacherUserId", request.teacherUserId);
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
            new TeaPair("action", "SaveClassLearningData"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/classes/learnings/datas/save"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveClassLearningDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>保存班级学情数据</p>
     * 
     * @param request SaveClassLearningDataRequest
     * @return SaveClassLearningDataResponse
     */
    public SaveClassLearningDataResponse saveClassLearningData(SaveClassLearningDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveClassLearningDataHeaders headers = new SaveClassLearningDataHeaders();
        return this.saveClassLearningDataWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>保存学生学情数据</p>
     * 
     * @param request SaveStudentLearningDataRequest
     * @param headers SaveStudentLearningDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveStudentLearningDataResponse
     */
    public SaveStudentLearningDataResponse saveStudentLearningDataWithOptions(SaveStudentLearningDataRequest request, SaveStudentLearningDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.assignNum)) {
            body.put("assignNum", request.assignNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.correctNum)) {
            body.put("correctNum", request.correctNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileSuffix)) {
            body.put("fileSuffix", request.fileSuffix);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.generatedTime)) {
            body.put("generatedTime", request.generatedTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.questionNum)) {
            body.put("questionNum", request.questionNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentUserId)) {
            body.put("studentUserId", request.studentUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subjectCode)) {
            body.put("subjectCode", request.subjectCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.submitNum)) {
            body.put("submitNum", request.submitNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.wrongQuestions)) {
            body.put("wrongQuestions", request.wrongQuestions);
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
            new TeaPair("action", "SaveStudentLearningData"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/students/learnings/datas/save"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveStudentLearningDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>保存学生学情数据</p>
     * 
     * @param request SaveStudentLearningDataRequest
     * @return SaveStudentLearningDataResponse
     */
    public SaveStudentLearningDataResponse saveStudentLearningData(SaveStudentLearningDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveStudentLearningDataHeaders headers = new SaveStudentLearningDataHeaders();
        return this.saveStudentLearningDataWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>成绩单详情已读状态设置</p>
     * 
     * @param request SchoolReportDetailReadedRequest
     * @param headers SchoolReportDetailReadedHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SchoolReportDetailReadedResponse
     */
    public SchoolReportDetailReadedResponse schoolReportDetailReadedWithOptions(SchoolReportDetailReadedRequest request, SchoolReportDetailReadedHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schoolReportId)) {
            body.put("schoolReportId", request.schoolReportId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentIds)) {
            body.put("studentIds", request.studentIds);
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
            new TeaPair("action", "SchoolReportDetailReaded"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/schools/reportDetails/readStatuses/set"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SchoolReportDetailReadedResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>成绩单详情已读状态设置</p>
     * 
     * @param request SchoolReportDetailReadedRequest
     * @return SchoolReportDetailReadedResponse
     */
    public SchoolReportDetailReadedResponse schoolReportDetailReaded(SchoolReportDetailReadedRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SchoolReportDetailReadedHeaders headers = new SchoolReportDetailReadedHeaders();
        return this.schoolReportDetailReadedWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>按关键字搜索老师</p>
     * 
     * @param request SearchTeachersRequest
     * @param headers SearchTeachersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchTeachersResponse
     */
    public SearchTeachersResponse searchTeachersWithOptions(SearchTeachersRequest request, SearchTeachersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.nameKeyword)) {
            query.put("nameKeyword", request.nameKeyword);
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
            new TeaPair("action", "SearchTeachers"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/teachers/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchTeachersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>按关键字搜索老师</p>
     * 
     * @param request SearchTeachersRequest
     * @return SearchTeachersResponse
     */
    public SearchTeachersResponse searchTeachers(SearchTeachersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchTeachersHeaders headers = new SearchTeachersHeaders();
        return this.searchTeachersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>套件-发送AI卡片</p>
     * 
     * @param request SendAiCardRequest
     * @param headers SendAiCardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendAiCardResponse
     */
    public SendAiCardResponse sendAiCardWithOptions(SendAiCardRequest request, SendAiCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionType)) {
            body.put("actionType", request.actionType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizData)) {
            body.put("bizData", request.bizData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardChannel)) {
            body.put("cardChannel", request.cardChannel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.identifier)) {
            body.put("identifier", request.identifier);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
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
            new TeaPair("action", "SendAiCard"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/aiCards/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendAiCardResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>套件-发送AI卡片</p>
     * 
     * @param request SendAiCardRequest
     * @return SendAiCardResponse
     */
    public SendAiCardResponse sendAiCard(SendAiCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendAiCardHeaders headers = new SendAiCardHeaders();
        return this.sendAiCardWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>收藏文件消息发送</p>
     * 
     * @param request SendFileMessageRequest
     * @param headers SendFileMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendFileMessageResponse
     */
    public SendFileMessageResponse sendFileMessageWithOptions(SendFileMessageRequest request, SendFileMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileName)) {
            body.put("fileName", request.fileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileSize)) {
            body.put("fileSize", request.fileSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileUrl)) {
            body.put("fileUrl", request.fileUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendType)) {
            body.put("sendType", request.sendType);
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
            new TeaPair("action", "SendFileMessage"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/contents/files/messages/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendFileMessageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>收藏文件消息发送</p>
     * 
     * @param request SendFileMessageRequest
     * @return SendFileMessageResponse
     */
    public SendFileMessageResponse sendFileMessage(SendFileMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendFileMessageHeaders headers = new SendFileMessageHeaders();
        return this.sendFileMessageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>亲情通话发消息</p>
     * 
     * @param request SendMessageRequest
     * @param headers SendMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendMessageResponse
     */
    public SendMessageResponse sendMessageWithOptions(SendMessageRequest request, SendMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fromUserId)) {
            body.put("fromUserId", request.fromUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sn)) {
            body.put("sn", request.sn);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toUserIdList)) {
            body.put("toUserIdList", request.toUserIdList);
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
            new TeaPair("action", "SendMessage"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/messages/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendMessageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>亲情通话发消息</p>
     * 
     * @param request SendMessageRequest
     * @return SendMessageResponse
     */
    public SendMessageResponse sendMessage(SendMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendMessageHeaders headers = new SendMessageHeaders();
        return this.sendMessageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发送打印订单提醒消息</p>
     * 
     * @param request SendPrintOrderNoticeMsgRequest
     * @param headers SendPrintOrderNoticeMsgHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendPrintOrderNoticeMsgResponse
     */
    public SendPrintOrderNoticeMsgResponse sendPrintOrderNoticeMsgWithOptions(SendPrintOrderNoticeMsgRequest request, SendPrintOrderNoticeMsgHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.createOrderTime)) {
            body.put("createOrderTime", request.createOrderTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deliveryCompanyName)) {
            body.put("deliveryCompanyName", request.deliveryCompanyName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deliveryNumber)) {
            body.put("deliveryNumber", request.deliveryNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deliveryTime)) {
            body.put("deliveryTime", request.deliveryTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.paymentTime)) {
            body.put("paymentTime", request.paymentTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.price)) {
            body.put("price", request.price);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sceneCode)) {
            body.put("sceneCode", request.sceneCode);
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
            new TeaPair("action", "SendPrintOrderNoticeMsg"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/files/printOrders/noticeMessages/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendPrintOrderNoticeMsgResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发送打印订单提醒消息</p>
     * 
     * @param request SendPrintOrderNoticeMsgRequest
     * @return SendPrintOrderNoticeMsgResponse
     */
    public SendPrintOrderNoticeMsgResponse sendPrintOrderNoticeMsg(SendPrintOrderNoticeMsgRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendPrintOrderNoticeMsgHeaders headers = new SendPrintOrderNoticeMsgHeaders();
        return this.sendPrintOrderNoticeMsgWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>开始课程</p>
     * 
     * @param request StartCourseRequest
     * @param headers StartCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return StartCourseResponse
     */
    public StartCourseResponse startCourseWithOptions(StartCourseRequest request, StartCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courseCode)) {
            body.put("courseCode", request.courseCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.livePlayInfoList)) {
            body.put("livePlayInfoList", request.livePlayInfoList);
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
            new TeaPair("action", "StartCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/universities/courses/start"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new StartCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>开始课程</p>
     * 
     * @param request StartCourseRequest
     * @return StartCourseResponse
     */
    public StartCourseResponse startCourse(StartCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StartCourseHeaders headers = new StartCourseHeaders();
        return this.startCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>预开课，发送开课提醒</p>
     * 
     * @param request StartCoursePrepareRequest
     * @param headers StartCoursePrepareHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return StartCoursePrepareResponse
     */
    public StartCoursePrepareResponse startCoursePrepareWithOptions(StartCoursePrepareRequest request, StartCoursePrepareHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courseDate)) {
            body.put("courseDate", request.courseDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupCode)) {
            body.put("courseGroupCode", request.courseGroupCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceId)) {
            body.put("deviceId", request.deviceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.liveCoverImage)) {
            body.put("liveCoverImage", request.liveCoverImage);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sectionIndex)) {
            body.put("sectionIndex", request.sectionIndex);
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
            new TeaPair("action", "StartCoursePrepare"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/universities/courses/prepare"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new StartCoursePrepareResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>预开课，发送开课提醒</p>
     * 
     * @param request StartCoursePrepareRequest
     * @return StartCoursePrepareResponse
     */
    public StartCoursePrepareResponse startCoursePrepare(StartCoursePrepareRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StartCoursePrepareHeaders headers = new StartCoursePrepareHeaders();
        return this.startCoursePrepareWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>订阅大学课程组</p>
     * 
     * @param request SubscribeUniversityCourseGroupRequest
     * @param headers SubscribeUniversityCourseGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SubscribeUniversityCourseGroupResponse
     */
    public SubscribeUniversityCourseGroupResponse subscribeUniversityCourseGroupWithOptions(SubscribeUniversityCourseGroupRequest request, SubscribeUniversityCourseGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupCode)) {
            body.put("courseGroupCode", request.courseGroupCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentUserIds)) {
            body.put("studentUserIds", request.studentUserIds);
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
            new TeaPair("action", "SubscribeUniversityCourseGroup"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/universities/courseGroups/subscribe"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SubscribeUniversityCourseGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>订阅大学课程组</p>
     * 
     * @param request SubscribeUniversityCourseGroupRequest
     * @return SubscribeUniversityCourseGroupResponse
     */
    public SubscribeUniversityCourseGroupResponse subscribeUniversityCourseGroup(SubscribeUniversityCourseGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SubscribeUniversityCourseGroupHeaders headers = new SubscribeUniversityCourseGroupHeaders();
        return this.subscribeUniversityCourseGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>取消订阅大学课程组</p>
     * 
     * @param request UnsubscribeUniversityCourseGroupRequest
     * @param headers UnsubscribeUniversityCourseGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UnsubscribeUniversityCourseGroupResponse
     */
    public UnsubscribeUniversityCourseGroupResponse unsubscribeUniversityCourseGroupWithOptions(UnsubscribeUniversityCourseGroupRequest request, UnsubscribeUniversityCourseGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupCode)) {
            body.put("courseGroupCode", request.courseGroupCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentUserIds)) {
            body.put("studentUserIds", request.studentUserIds);
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
            new TeaPair("action", "UnsubscribeUniversityCourseGroup"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/universities/courseGroups/unsubscribe"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UnsubscribeUniversityCourseGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>取消订阅大学课程组</p>
     * 
     * @param request UnsubscribeUniversityCourseGroupRequest
     * @return UnsubscribeUniversityCourseGroupResponse
     */
    public UnsubscribeUniversityCourseGroupResponse unsubscribeUniversityCourseGroup(UnsubscribeUniversityCourseGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UnsubscribeUniversityCourseGroupHeaders headers = new UnsubscribeUniversityCourseGroupHeaders();
        return this.unsubscribeUniversityCourseGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>高校校友会更新校友信息</p>
     * 
     * @param request UpdateCollegeAlumniUserInfoRequest
     * @param headers UpdateCollegeAlumniUserInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateCollegeAlumniUserInfoResponse
     */
    public UpdateCollegeAlumniUserInfoResponse updateCollegeAlumniUserInfoWithOptions(UpdateCollegeAlumniUserInfoRequest request, UpdateCollegeAlumniUserInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.address)) {
            body.put("address", request.address);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptIds)) {
            body.put("deptIds", request.deptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.email)) {
            body.put("email", request.email);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.intake)) {
            body.put("intake", request.intake);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outtake)) {
            body.put("outtake", request.outtake);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentNumber)) {
            body.put("studentNumber", request.studentNumber);
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
            new TeaPair("action", "UpdateCollegeAlumniUserInfo"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeAlumni/userInfos"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateCollegeAlumniUserInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>高校校友会更新校友信息</p>
     * 
     * @param request UpdateCollegeAlumniUserInfoRequest
     * @return UpdateCollegeAlumniUserInfoResponse
     */
    public UpdateCollegeAlumniUserInfoResponse updateCollegeAlumniUserInfo(UpdateCollegeAlumniUserInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCollegeAlumniUserInfoHeaders headers = new UpdateCollegeAlumniUserInfoHeaders();
        return this.updateCollegeAlumniUserInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新高校通讯录组织单元</p>
     * 
     * @param request UpdateCollegeContactDeptRequest
     * @param headers UpdateCollegeContactDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateCollegeContactDeptResponse
     */
    public UpdateCollegeContactDeptResponse updateCollegeContactDeptWithOptions(UpdateCollegeContactDeptRequest request, UpdateCollegeContactDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.autoAddUser)) {
            body.put("autoAddUser", request.autoAddUser);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.autoApproveApply)) {
            body.put("autoApproveApply", request.autoApproveApply);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.brief)) {
            body.put("brief", request.brief);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createDeptGroup)) {
            body.put("createDeptGroup", request.createDeptGroup);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptCode)) {
            body.put("deptCode", request.deptCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptManagerUseridList)) {
            body.put("deptManagerUseridList", request.deptManagerUseridList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptPermits)) {
            body.put("deptPermits", request.deptPermits);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptType)) {
            body.put("deptType", request.deptType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.empApplyJoinDept)) {
            body.put("empApplyJoinDept", request.empApplyJoinDept);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.forceUpdateFields)) {
            body.put("forceUpdateFields", request.forceUpdateFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupContainHiddenDept)) {
            body.put("groupContainHiddenDept", request.groupContainHiddenDept);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupContainOuterDept)) {
            body.put("groupContainOuterDept", request.groupContainOuterDept);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupContainSubDept)) {
            body.put("groupContainSubDept", request.groupContainSubDept);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hideDept)) {
            body.put("hideDept", request.hideDept);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hideSceneConfig)) {
            body.put("hideSceneConfig", request.hideSceneConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            body.put("order", request.order);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgDeptOwner)) {
            body.put("orgDeptOwner", request.orgDeptOwner);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerDept)) {
            body.put("outerDept", request.outerDept);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerDeptOnlySelf)) {
            body.put("outerDeptOnlySelf", request.outerDeptOnlySelf);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerPermitDepts)) {
            body.put("outerPermitDepts", request.outerPermitDepts);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerPermitUsers)) {
            body.put("outerPermitUsers", request.outerPermitUsers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerSceneConfig)) {
            body.put("outerSceneConfig", request.outerSceneConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentId)) {
            body.put("parentId", request.parentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceIdentifier)) {
            body.put("sourceIdentifier", request.sourceIdentifier);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.telephone)) {
            body.put("telephone", request.telephone);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userPermits)) {
            body.put("userPermits", request.userPermits);
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
            new TeaPair("action", "UpdateCollegeContactDept"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/depts"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateCollegeContactDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新高校通讯录组织单元</p>
     * 
     * @param request UpdateCollegeContactDeptRequest
     * @return UpdateCollegeContactDeptResponse
     */
    public UpdateCollegeContactDeptResponse updateCollegeContactDept(UpdateCollegeContactDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCollegeContactDeptHeaders headers = new UpdateCollegeContactDeptHeaders();
        return this.updateCollegeContactDeptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新高校账号用户</p>
     * 
     * @param request UpdateCollegeContactExclusiveRequest
     * @param headers UpdateCollegeContactExclusiveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateCollegeContactExclusiveResponse
     */
    public UpdateCollegeContactExclusiveResponse updateCollegeContactExclusiveWithOptions(UpdateCollegeContactExclusiveRequest request, UpdateCollegeContactExclusiveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.avatarMediaId)) {
            body.put("avatarMediaId", request.avatarMediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptIdList)) {
            body.put("deptIdList", request.deptIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptOrderList)) {
            body.put("deptOrderList", request.deptOrderList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptPositionSet)) {
            body.put("deptPositionSet", request.deptPositionSet);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptTitleList)) {
            body.put("deptTitleList", request.deptTitleList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.email)) {
            body.put("email", request.email);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.empType)) {
            body.put("empType", request.empType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.forceUpdateFields)) {
            body.put("forceUpdateFields", request.forceUpdateFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hideMobile)) {
            body.put("hideMobile", request.hideMobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hiredDate)) {
            body.put("hiredDate", request.hiredDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jobNumber)) {
            body.put("jobNumber", request.jobNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.loginIdType)) {
            body.put("loginIdType", request.loginIdType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mainDeptId)) {
            body.put("mainDeptId", request.mainDeptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerUserid)) {
            body.put("managerUserid", request.managerUserid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nickname)) {
            body.put("nickname", request.nickname);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgEmail)) {
            body.put("orgEmail", request.orgEmail);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgEmailType)) {
            body.put("orgEmailType", request.orgEmailType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.seniorMode)) {
            body.put("seniorMode", request.seniorMode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.telephone)) {
            body.put("telephone", request.telephone);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userid)) {
            body.put("userid", request.userid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.workPlace)) {
            body.put("workPlace", request.workPlace);
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
            new TeaPair("action", "UpdateCollegeContactExclusive"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/exclusiveAccounts/users"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateCollegeContactExclusiveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新高校账号用户</p>
     * 
     * @param request UpdateCollegeContactExclusiveRequest
     * @return UpdateCollegeContactExclusiveResponse
     */
    public UpdateCollegeContactExclusiveResponse updateCollegeContactExclusive(UpdateCollegeContactExclusiveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCollegeContactExclusiveHeaders headers = new UpdateCollegeContactExclusiveHeaders();
        return this.updateCollegeContactExclusiveWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新高校通讯录场景架构</p>
     * 
     * @param request UpdateCollegeContactSceneStruRequest
     * @param headers UpdateCollegeContactSceneStruHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateCollegeContactSceneStruResponse
     */
    public UpdateCollegeContactSceneStruResponse updateCollegeContactSceneStruWithOptions(UpdateCollegeContactSceneStruRequest request, UpdateCollegeContactSceneStruHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            body.put("order", request.order);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceIdentifier)) {
            body.put("sourceIdentifier", request.sourceIdentifier);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.struBrief)) {
            body.put("struBrief", request.struBrief);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.struId)) {
            body.put("struId", request.struId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.struName)) {
            body.put("struName", request.struName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.struType)) {
            body.put("struType", request.struType);
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
            new TeaPair("action", "UpdateCollegeContactSceneStru"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/depts/structures/scenes"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateCollegeContactSceneStruResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新高校通讯录场景架构</p>
     * 
     * @param request UpdateCollegeContactSceneStruRequest
     * @return UpdateCollegeContactSceneStruResponse
     */
    public UpdateCollegeContactSceneStruResponse updateCollegeContactSceneStru(UpdateCollegeContactSceneStruRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCollegeContactSceneStruHeaders headers = new UpdateCollegeContactSceneStruHeaders();
        return this.updateCollegeContactSceneStruWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新个人账号用户</p>
     * 
     * @param request UpdateCollegeContactUserRequest
     * @param headers UpdateCollegeContactUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateCollegeContactUserResponse
     */
    public UpdateCollegeContactUserResponse updateCollegeContactUserWithOptions(UpdateCollegeContactUserRequest request, UpdateCollegeContactUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptIdList)) {
            body.put("deptIdList", request.deptIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptOrderList)) {
            body.put("deptOrderList", request.deptOrderList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptPositionSet)) {
            body.put("deptPositionSet", request.deptPositionSet);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptTitleList)) {
            body.put("deptTitleList", request.deptTitleList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.email)) {
            body.put("email", request.email);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.empType)) {
            body.put("empType", request.empType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.forceUpdateFields)) {
            body.put("forceUpdateFields", request.forceUpdateFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hideMobile)) {
            body.put("hideMobile", request.hideMobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hiredDate)) {
            body.put("hiredDate", request.hiredDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jobNumber)) {
            body.put("jobNumber", request.jobNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            body.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mainDeptId)) {
            body.put("mainDeptId", request.mainDeptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerUserid)) {
            body.put("managerUserid", request.managerUserid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgEmail)) {
            body.put("orgEmail", request.orgEmail);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.seniorMode)) {
            body.put("seniorMode", request.seniorMode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.telephone)) {
            body.put("telephone", request.telephone);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userid)) {
            body.put("userid", request.userid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.workPlace)) {
            body.put("workPlace", request.workPlace);
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
            new TeaPair("action", "UpdateCollegeContactUser"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/personalAccounts/users"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateCollegeContactUserResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新个人账号用户</p>
     * 
     * @param request UpdateCollegeContactUserRequest
     * @return UpdateCollegeContactUserResponse
     */
    public UpdateCollegeContactUserResponse updateCollegeContactUser(UpdateCollegeContactUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCollegeContactUserHeaders headers = new UpdateCollegeContactUserHeaders();
        return this.updateCollegeContactUserWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改用户成员类型</p>
     * 
     * @param request UpdateCollegeUserEmpTypeRequest
     * @param headers UpdateCollegeUserEmpTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateCollegeUserEmpTypeResponse
     */
    public UpdateCollegeUserEmpTypeResponse updateCollegeUserEmpTypeWithOptions(UpdateCollegeUserEmpTypeRequest request, UpdateCollegeUserEmpTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.empType)) {
            body.put("empType", request.empType);
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
            new TeaPair("action", "UpdateCollegeUserEmpType"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/collegeContact/empTypes/change"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateCollegeUserEmpTypeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改用户成员类型</p>
     * 
     * @param request UpdateCollegeUserEmpTypeRequest
     * @return UpdateCollegeUserEmpTypeResponse
     */
    public UpdateCollegeUserEmpTypeResponse updateCollegeUserEmpType(UpdateCollegeUserEmpTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCollegeUserEmpTypeHeaders headers = new UpdateCollegeUserEmpTypeHeaders();
        return this.updateCollegeUserEmpTypeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新班级课程表（调代课等微调场景）</p>
     * 
     * @param request UpdateCoursesOfClassRequest
     * @param headers UpdateCoursesOfClassHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateCoursesOfClassResponse
     */
    public UpdateCoursesOfClassResponse updateCoursesOfClassWithOptions(String classId, UpdateCoursesOfClassRequest request, UpdateCoursesOfClassHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courses)) {
            body.put("courses", request.courses);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sectionConfig)) {
            body.put("sectionConfig", request.sectionConfig);
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
            new TeaPair("action", "UpdateCoursesOfClass"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/classes/" + classId + "/courses/schedules"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateCoursesOfClassResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新班级课程表（调代课等微调场景）</p>
     * 
     * @param request UpdateCoursesOfClassRequest
     * @return UpdateCoursesOfClassResponse
     */
    public UpdateCoursesOfClassResponse updateCoursesOfClass(String classId, UpdateCoursesOfClassRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCoursesOfClassHeaders headers = new UpdateCoursesOfClassHeaders();
        return this.updateCoursesOfClassWithOptions(classId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新评价表现未读数量</p>
     * 
     * @param request UpdateEvaluatePerformanceCountRequest
     * @param headers UpdateEvaluatePerformanceCountHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateEvaluatePerformanceCountResponse
     */
    public UpdateEvaluatePerformanceCountResponse updateEvaluatePerformanceCountWithOptions(UpdateEvaluatePerformanceCountRequest request, UpdateEvaluatePerformanceCountHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.teacherId)) {
            body.put("teacherId", request.teacherId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unreadData)) {
            body.put("unreadData", request.unreadData);
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
            new TeaPair("action", "UpdateEvaluatePerformanceCount"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/evaluations/unreadCounts"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateEvaluatePerformanceCountResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新评价表现未读数量</p>
     * 
     * @param request UpdateEvaluatePerformanceCountRequest
     * @return UpdateEvaluatePerformanceCountResponse
     */
    public UpdateEvaluatePerformanceCountResponse updateEvaluatePerformanceCount(UpdateEvaluatePerformanceCountRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateEvaluatePerformanceCountHeaders headers = new UpdateEvaluatePerformanceCountHeaders();
        return this.updateEvaluatePerformanceCountWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加物理教室信息</p>
     * 
     * @param request UpdatePhysicalClassroomRequest
     * @param headers UpdatePhysicalClassroomHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdatePhysicalClassroomResponse
     */
    public UpdatePhysicalClassroomResponse updatePhysicalClassroomWithOptions(UpdatePhysicalClassroomRequest request, UpdatePhysicalClassroomHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classroomBuilding)) {
            body.put("classroomBuilding", request.classroomBuilding);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomCampus)) {
            body.put("classroomCampus", request.classroomCampus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomFloor)) {
            body.put("classroomFloor", request.classroomFloor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomId)) {
            body.put("classroomId", request.classroomId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomName)) {
            body.put("classroomName", request.classroomName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.classroomNumber)) {
            body.put("classroomNumber", request.classroomNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.directBroadcast)) {
            body.put("directBroadcast", request.directBroadcast);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
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
            new TeaPair("action", "UpdatePhysicalClassroom"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/physicalClassrooms"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdatePhysicalClassroomResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加物理教室信息</p>
     * 
     * @param request UpdatePhysicalClassroomRequest
     * @return UpdatePhysicalClassroomResponse
     */
    public UpdatePhysicalClassroomResponse updatePhysicalClassroom(UpdatePhysicalClassroomRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdatePhysicalClassroomHeaders headers = new UpdatePhysicalClassroomHeaders();
        return this.updatePhysicalClassroomWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新专递课堂课程</p>
     * 
     * @param request UpdateRemoteClassCourseRequest
     * @param headers UpdateRemoteClassCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateRemoteClassCourseResponse
     */
    public UpdateRemoteClassCourseResponse updateRemoteClassCourseWithOptions(UpdateRemoteClassCourseRequest request, UpdateRemoteClassCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attendParticipants)) {
            body.put("attendParticipants", request.attendParticipants);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authCode)) {
            body.put("authCode", request.authCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseCode)) {
            body.put("courseCode", request.courseCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseName)) {
            body.put("courseName", request.courseName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teachingParticipant)) {
            body.put("teachingParticipant", request.teachingParticipant);
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
            new TeaPair("action", "UpdateRemoteClassCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/remoteClasses/courses"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateRemoteClassCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新专递课堂课程</p>
     * 
     * @param request UpdateRemoteClassCourseRequest
     * @return UpdateRemoteClassCourseResponse
     */
    public UpdateRemoteClassCourseResponse updateRemoteClassCourse(UpdateRemoteClassCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateRemoteClassCourseHeaders headers = new UpdateRemoteClassCourseHeaders();
        return this.updateRemoteClassCourseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新设备名称</p>
     * 
     * @param request UpdateRemoteClassDeviceRequest
     * @param headers UpdateRemoteClassDeviceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateRemoteClassDeviceResponse
     */
    public UpdateRemoteClassDeviceResponse updateRemoteClassDeviceWithOptions(UpdateRemoteClassDeviceRequest request, UpdateRemoteClassDeviceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authCode)) {
            query.put("authCode", request.authCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceCode)) {
            query.put("deviceCode", request.deviceCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceName)) {
            query.put("deviceName", request.deviceName);
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
            new TeaPair("action", "UpdateRemoteClassDevice"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/remoteClasses/deviceNames"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateRemoteClassDeviceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新设备名称</p>
     * 
     * @param request UpdateRemoteClassDeviceRequest
     * @return UpdateRemoteClassDeviceResponse
     */
    public UpdateRemoteClassDeviceResponse updateRemoteClassDevice(UpdateRemoteClassDeviceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateRemoteClassDeviceHeaders headers = new UpdateRemoteClassDeviceHeaders();
        return this.updateRemoteClassDeviceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新大学课程组</p>
     * 
     * @param request UpdateUniversityCourseGroupRequest
     * @param headers UpdateUniversityCourseGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateUniversityCourseGroupResponse
     */
    public UpdateUniversityCourseGroupResponse updateUniversityCourseGroupWithOptions(UpdateUniversityCourseGroupRequest request, UpdateUniversityCourseGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupCode)) {
            body.put("courseGroupCode", request.courseGroupCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupIntroduce)) {
            body.put("courseGroupIntroduce", request.courseGroupIntroduce);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courseGroupName)) {
            body.put("courseGroupName", request.courseGroupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.courserGroupItemModels)) {
            body.put("courserGroupItemModels", request.courserGroupItemModels);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
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
            new TeaPair("action", "UpdateUniversityCourseGroup"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/universities/courseGroups"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateUniversityCourseGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新大学课程组</p>
     * 
     * @param request UpdateUniversityCourseGroupRequest
     * @return UpdateUniversityCourseGroupResponse
     */
    public UpdateUniversityCourseGroupResponse updateUniversityCourseGroup(UpdateUniversityCourseGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateUniversityCourseGroupHeaders headers = new UpdateUniversityCourseGroupHeaders();
        return this.updateUniversityCourseGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>上传学情图片回调</p>
     * 
     * @param request UploadLearningDataCallbackRequest
     * @param headers UploadLearningDataCallbackHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UploadLearningDataCallbackResponse
     */
    public UploadLearningDataCallbackResponse uploadLearningDataCallbackWithOptions(UploadLearningDataCallbackRequest request, UploadLearningDataCallbackHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.generatedTime)) {
            body.put("generatedTime", request.generatedTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentUserId)) {
            body.put("studentUserId", request.studentUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subjectCode)) {
            body.put("subjectCode", request.subjectCode);
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
            new TeaPair("action", "UploadLearningDataCallback"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/uploadLearnings/datas/callback"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UploadLearningDataCallbackResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>上传学情图片回调</p>
     * 
     * @param request UploadLearningDataCallbackRequest
     * @return UploadLearningDataCallbackResponse
     */
    public UploadLearningDataCallbackResponse uploadLearningDataCallback(UploadLearningDataCallbackRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UploadLearningDataCallbackHeaders headers = new UploadLearningDataCallbackHeaders();
        return this.uploadLearningDataCallbackWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>视讯PAAS接口代理</p>
     * 
     * @param request VPaasProxyRequest
     * @param headers VPaasProxyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return VPaasProxyResponse
     */
    public VPaasProxyResponse vPaasProxyWithOptions(VPaasProxyRequest request, VPaasProxyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionCode)) {
            body.put("actionCode", request.actionCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.params)) {
            body.put("params", request.params);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.publicKey)) {
            body.put("publicKey", request.publicKey);
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
            new TeaPair("action", "VPaasProxy"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/vpaas/proxy"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new VPaasProxyResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>视讯PAAS接口代理</p>
     * 
     * @param request VPaasProxyRequest
     * @return VPaasProxyResponse
     */
    public VPaasProxyResponse vPaasProxy(VPaasProxyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        VPaasProxyHeaders headers = new VPaasProxyHeaders();
        return this.vPaasProxyWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>校验开学季任务是否完成</p>
     * 
     * @param request ValidateNewGradeManagerRequest
     * @param headers ValidateNewGradeManagerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ValidateNewGradeManagerResponse
     */
    public ValidateNewGradeManagerResponse validateNewGradeManagerWithOptions(ValidateNewGradeManagerRequest request, ValidateNewGradeManagerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "ValidateNewGradeManager"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/newGrades/tasks/validate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ValidateNewGradeManagerResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>校验开学季任务是否完成</p>
     * 
     * @param request ValidateNewGradeManagerRequest
     * @return ValidateNewGradeManagerResponse
     */
    public ValidateNewGradeManagerResponse validateNewGradeManager(ValidateNewGradeManagerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ValidateNewGradeManagerHeaders headers = new ValidateNewGradeManagerHeaders();
        return this.validateNewGradeManagerWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>校验用户的教育角色</p>
     * 
     * @param request ValidateUserRoleRequest
     * @param headers ValidateUserRoleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ValidateUserRoleResponse
     */
    public ValidateUserRoleResponse validateUserRoleWithOptions(ValidateUserRoleRequest request, ValidateUserRoleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.timeThreshold)) {
            body.put("timeThreshold", request.timeThreshold);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "ValidateUserRole"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/users/roles/validate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ValidateUserRoleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>校验用户的教育角色</p>
     * 
     * @param request ValidateUserRoleRequest
     * @return ValidateUserRoleResponse
     */
    public ValidateUserRoleResponse validateUserRole(ValidateUserRoleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ValidateUserRoleHeaders headers = new ValidateUserRoleHeaders();
        return this.validateUserRoleWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询班级课程</p>
     * 
     * @param request QueryClassCourseRequest
     * @param headers QueryClassCourseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryClassCourseResponse
     */
    public QueryClassCourseResponse queryClassCourseWithOptions(QueryClassCourseRequest request, QueryClassCourseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.classId)) {
            body.put("classId", request.classId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCode)) {
            body.put("isvCode", request.isvCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvCourseId)) {
            body.put("isvCourseId", request.isvCourseId);
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
            new TeaPair("action", "queryClassCourse"),
            new TeaPair("version", "edu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/edu/kits/classes/courses/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryClassCourseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询班级课程</p>
     * 
     * @param request QueryClassCourseRequest
     * @return QueryClassCourseResponse
     */
    public QueryClassCourseResponse queryClassCourse(QueryClassCourseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryClassCourseHeaders headers = new QueryClassCourseHeaders();
        return this.queryClassCourseWithOptions(request, headers, runtime);
    }
}
