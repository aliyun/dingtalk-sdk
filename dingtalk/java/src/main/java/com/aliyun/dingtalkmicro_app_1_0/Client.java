// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkmicro_app_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._signatureAlgorithm = "v2";
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>给指定成员添加角色</p>
     * 
     * @param request AddAppRolesToMemberRequest
     * @param headers AddAppRolesToMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddAppRolesToMemberResponse
     */
    public AddAppRolesToMemberResponse addAppRolesToMemberWithOptions(String agentId, AddAppRolesToMemberRequest request, AddAppRolesToMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.memberId)) {
            body.put("memberId", request.memberId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberType)) {
            body.put("memberType", request.memberType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleList)) {
            body.put("roleList", request.roleList);
        }

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
            new TeaPair("action", "AddAppRolesToMember"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + "/members/roles"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddAppRolesToMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>给指定成员添加角色</p>
     * 
     * @param request AddAppRolesToMemberRequest
     * @return AddAppRolesToMemberResponse
     */
    public AddAppRolesToMemberResponse addAppRolesToMember(String agentId, AddAppRolesToMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddAppRolesToMemberHeaders headers = new AddAppRolesToMemberHeaders();
        return this.addAppRolesToMemberWithOptions(agentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加应用到工作台分组</p>
     * 
     * @param request AddAppToWorkBenchGroupRequest
     * @param headers AddAppToWorkBenchGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddAppToWorkBenchGroupResponse
     */
    public AddAppToWorkBenchGroupResponse addAppToWorkBenchGroupWithOptions(String agentId, AddAppToWorkBenchGroupRequest request, AddAppToWorkBenchGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.componentId)) {
            body.put("componentId", request.componentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ecologicalCorpId)) {
            body.put("ecologicalCorpId", request.ecologicalCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUnionId)) {
            body.put("opUnionId", request.opUnionId);
        }

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
            new TeaPair("action", "AddAppToWorkBenchGroup"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + "/addToWorkBenchGroup"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddAppToWorkBenchGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加应用到工作台分组</p>
     * 
     * @param request AddAppToWorkBenchGroupRequest
     * @return AddAppToWorkBenchGroupResponse
     */
    public AddAppToWorkBenchGroupResponse addAppToWorkBenchGroup(String agentId, AddAppToWorkBenchGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddAppToWorkBenchGroupHeaders headers = new AddAppToWorkBenchGroupHeaders();
        return this.addAppToWorkBenchGroupWithOptions(agentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>给指定角色添加人员</p>
     * 
     * @param request AddMemberToAppRoleRequest
     * @param headers AddMemberToAppRoleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddMemberToAppRoleResponse
     */
    public AddMemberToAppRoleResponse addMemberToAppRoleWithOptions(String agentId, String roleId, AddMemberToAppRoleRequest request, AddMemberToAppRoleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptIdList)) {
            body.put("deptIdList", request.deptIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeVersion)) {
            body.put("scopeVersion", request.scopeVersion);
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
            new TeaPair("action", "AddMemberToAppRole"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/members"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddMemberToAppRoleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>给指定角色添加人员</p>
     * 
     * @param request AddMemberToAppRoleRequest
     * @return AddMemberToAppRoleResponse
     */
    public AddMemberToAppRoleResponse addMemberToAppRole(String agentId, String roleId, AddMemberToAppRoleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddMemberToAppRoleHeaders headers = new AddMemberToAppRoleHeaders();
        return this.addMemberToAppRoleWithOptions(agentId, roleId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>AnheiP</p>
     * 
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return AnheiPResponse
     */
    public AnheiPResponse anheiPWithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AnheiP"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/anheiP"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AnheiPResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>AnheiP</p>
     * @return AnheiPResponse
     */
    public AnheiPResponse anheiP() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.anheiPWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>AnheiTest888</p>
     * 
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return AnheiTest888Response
     */
    public AnheiTest888Response anheiTest888WithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AnheiTest888"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/anheiTest888"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AnheiTest888Response());
    }

    /**
     * <b>summary</b> : 
     * <p>AnheiTest888</p>
     * @return AnheiTest888Response
     */
    public AnheiTest888Response anheiTest888() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.anheiTest888WithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>AnheiTestB</p>
     * 
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return AnheiTestBResponse
     */
    public AnheiTestBResponse anheiTestBWithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AnheiTestB"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/anheiTestB"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AnheiTestBResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>AnheiTestB</p>
     * @return AnheiTestBResponse
     */
    public AnheiTestBResponse anheiTestB() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.anheiTestBWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>暗黑测试</p>
     * 
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return AnheiTestNineResponse
     */
    public AnheiTestNineResponse anheiTestNineWithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AnheiTestNine"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/anheiTestNine"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AnheiTestNineResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>暗黑测试</p>
     * @return AnheiTestNineResponse
     */
    public AnheiTestNineResponse anheiTestNine() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.anheiTestNineWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>应用状态管理测试</p>
     * 
     * @param request AppStatusManagerTestRequest
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return AppStatusManagerTestResponse
     */
    public AppStatusManagerTestResponse appStatusManagerTestWithOptions(AppStatusManagerTestRequest request, java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.requestId)) {
            query.put("requestId", request.requestId);
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AppStatusManagerTest"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/manager/test"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AppStatusManagerTestResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>应用状态管理测试</p>
     * 
     * @param request AppStatusManagerTestRequest
     * @return AppStatusManagerTestResponse
     */
    public AppStatusManagerTestResponse appStatusManagerTest(AppStatusManagerTestRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.appStatusManagerTestWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>能力开放中心录入测试数据</p>
     * 
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return AyunTestResponse
     */
    public AyunTestResponse ayunTestWithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AyunTest"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/ayun/test"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AyunTestResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>能力开放中心录入测试数据</p>
     * @return AyunTestResponse
     */
    public AyunTestResponse ayunTest() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.ayunTestWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>openAPI录入上线后的测试</p>
     * 
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return AyunTestOnlineResponse
     */
    public AyunTestOnlineResponse ayunTestOnlineWithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AyunTestOnline"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/ayunTest"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AyunTestOnlineResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>openAPI录入上线后的测试</p>
     * @return AyunTestOnlineResponse
     */
    public AyunTestOnlineResponse ayunTestOnline() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.ayunTestOnlineWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建Apaas应用</p>
     * 
     * @param request CreateApaasAppRequest
     * @param headers CreateApaasAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateApaasAppResponse
     */
    public CreateApaasAppResponse createApaasAppWithOptions(CreateApaasAppRequest request, CreateApaasAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appDesc)) {
            body.put("appDesc", request.appDesc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIcon)) {
            body.put("appIcon", request.appIcon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizAppId)) {
            body.put("bizAppId", request.bizAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.homepageEditLink)) {
            body.put("homepageEditLink", request.homepageEditLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.homepageLink)) {
            body.put("homepageLink", request.homepageLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isShortCut)) {
            body.put("isShortCut", request.isShortCut);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ompLink)) {
            body.put("ompLink", request.ompLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pcHomepageEditLink)) {
            body.put("pcHomepageEditLink", request.pcHomepageEditLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pcHomepageLink)) {
            body.put("pcHomepageLink", request.pcHomepageLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateKey)) {
            body.put("templateKey", request.templateKey);
        }

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
            new TeaPair("action", "CreateApaasApp"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apaasApps"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateApaasAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建Apaas应用</p>
     * 
     * @param request CreateApaasAppRequest
     * @return CreateApaasAppResponse
     */
    public CreateApaasAppResponse createApaasApp(CreateApaasAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateApaasAppHeaders headers = new CreateApaasAppHeaders();
        return this.createApaasAppWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建企业内部应用</p>
     * 
     * @param request CreateInnerAppRequest
     * @param headers CreateInnerAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateInnerAppResponse
     */
    public CreateInnerAppResponse createInnerAppWithOptions(CreateInnerAppRequest request, CreateInnerAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.desc)) {
            body.put("desc", request.desc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.developType)) {
            body.put("developType", request.developType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.homepageLink)) {
            body.put("homepageLink", request.homepageLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ipWhiteList)) {
            body.put("ipWhiteList", request.ipWhiteList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ompLink)) {
            body.put("ompLink", request.ompLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUnionId)) {
            body.put("opUnionId", request.opUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pcHomepageLink)) {
            body.put("pcHomepageLink", request.pcHomepageLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeType)) {
            body.put("scopeType", request.scopeType);
        }

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
            new TeaPair("action", "CreateInnerApp"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateInnerAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建企业内部应用</p>
     * 
     * @param request CreateInnerAppRequest
     * @return CreateInnerAppResponse
     */
    public CreateInnerAppResponse createInnerApp(CreateInnerAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateInnerAppHeaders headers = new CreateInnerAppHeaders();
        return this.createInnerAppWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除应用角色</p>
     * 
     * @param request DeleteAppRoleRequest
     * @param headers DeleteAppRoleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteAppRoleResponse
     */
    public DeleteAppRoleResponse deleteAppRoleWithOptions(String agentId, String roleId, DeleteAppRoleRequest request, DeleteAppRoleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteAppRole"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteAppRoleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除应用角色</p>
     * 
     * @param request DeleteAppRoleRequest
     * @return DeleteAppRoleResponse
     */
    public DeleteAppRoleResponse deleteAppRole(String agentId, String roleId, DeleteAppRoleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteAppRoleHeaders headers = new DeleteAppRoleHeaders();
        return this.deleteAppRoleWithOptions(agentId, roleId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除企业内部应用</p>
     * 
     * @param request DeleteInnerAppRequest
     * @param headers DeleteInnerAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteInnerAppResponse
     */
    public DeleteInnerAppResponse deleteInnerAppWithOptions(String agentId, DeleteInnerAppRequest request, DeleteInnerAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUnionId)) {
            query.put("opUnionId", request.opUnionId);
        }

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
            new TeaPair("action", "DeleteInnerApp"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteInnerAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除企业内部应用</p>
     * 
     * @param request DeleteInnerAppRequest
     * @return DeleteInnerAppResponse
     */
    public DeleteInnerAppResponse deleteInnerApp(String agentId, DeleteInnerAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteInnerAppHeaders headers = new DeleteInnerAppHeaders();
        return this.deleteInnerAppWithOptions(agentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询Apaas应用</p>
     * 
     * @param headers GetApaasAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetApaasAppResponse
     */
    public GetApaasAppResponse getApaasAppWithOptions(String bizAppId, GetApaasAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetApaasApp"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apaasApps/" + bizAppId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetApaasAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询Apaas应用</p>
     * @return GetApaasAppResponse
     */
    public GetApaasAppResponse getApaasApp(String bizAppId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetApaasAppHeaders headers = new GetApaasAppHeaders();
        return this.getApaasAppWithOptions(bizAppId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取应用资源用量信息</p>
     * 
     * @param request GetAppResourceUseInfoRequest
     * @param headers GetAppResourceUseInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAppResourceUseInfoResponse
     */
    public GetAppResourceUseInfoResponse getAppResourceUseInfoWithOptions(GetAppResourceUseInfoRequest request, GetAppResourceUseInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.benefitCode)) {
            query.put("benefitCode", request.benefitCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodType)) {
            query.put("periodType", request.periodType);
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
            new TeaPair("action", "GetAppResourceUseInfo"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/resources/useInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "array")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAppResourceUseInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取应用资源用量信息</p>
     * 
     * @param request GetAppResourceUseInfoRequest
     * @return GetAppResourceUseInfoResponse
     */
    public GetAppResourceUseInfoResponse getAppResourceUseInfo(GetAppResourceUseInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAppResourceUseInfoHeaders headers = new GetAppResourceUseInfoHeaders();
        return this.getAppResourceUseInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询指定角色的角色范围</p>
     * 
     * @param headers GetAppRoleScopeByRoleIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAppRoleScopeByRoleIdResponse
     */
    public GetAppRoleScopeByRoleIdResponse getAppRoleScopeByRoleIdWithOptions(String agentId, String roleId, GetAppRoleScopeByRoleIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetAppRoleScopeByRoleId"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/scopes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAppRoleScopeByRoleIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询指定角色的角色范围</p>
     * @return GetAppRoleScopeByRoleIdResponse
     */
    public GetAppRoleScopeByRoleIdResponse getAppRoleScopeByRoleId(String agentId, String roleId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAppRoleScopeByRoleIdHeaders headers = new GetAppRoleScopeByRoleIdHeaders();
        return this.getAppRoleScopeByRoleIdWithOptions(agentId, roleId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业内部H5应用</p>
     * 
     * @param request GetInnerAppRequest
     * @param headers GetInnerAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetInnerAppResponse
     */
    public GetInnerAppResponse getInnerAppWithOptions(String agentId, GetInnerAppRequest request, GetInnerAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ecologicalCorpId)) {
            query.put("ecologicalCorpId", request.ecologicalCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUnionId)) {
            query.put("opUnionId", request.opUnionId);
        }

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
            new TeaPair("action", "GetInnerApp"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetInnerAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业内部H5应用</p>
     * 
     * @param request GetInnerAppRequest
     * @return GetInnerAppResponse
     */
    public GetInnerAppResponse getInnerApp(String agentId, GetInnerAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetInnerAppHeaders headers = new GetInnerAppHeaders();
        return this.getInnerAppWithOptions(agentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取应用可见范围</p>
     * 
     * @param headers GetMicroAppScopeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMicroAppScopeResponse
     */
    public GetMicroAppScopeResponse getMicroAppScopeWithOptions(String agentId, GetMicroAppScopeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetMicroAppScope"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + "/scopes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMicroAppScopeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取应用可见范围</p>
     * @return GetMicroAppScopeResponse
     */
    public GetMicroAppScopeResponse getMicroAppScope(String agentId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMicroAppScopeHeaders headers = new GetMicroAppScopeHeaders();
        return this.getMicroAppScopeWithOptions(agentId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户对应用的管理权限</p>
     * 
     * @param headers GetMicroAppUserAccessHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMicroAppUserAccessResponse
     */
    public GetMicroAppUserAccessResponse getMicroAppUserAccessWithOptions(String agentId, String userId, GetMicroAppUserAccessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetMicroAppUserAccess"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + "/users/" + userId + "/adminAccess"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMicroAppUserAccessResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户对应用的管理权限</p>
     * @return GetMicroAppUserAccessResponse
     */
    public GetMicroAppUserAccessResponse getMicroAppUserAccess(String agentId, String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMicroAppUserAccessHeaders headers = new GetMicroAppUserAccessHeaders();
        return this.getMicroAppUserAccessWithOptions(agentId, userId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>用户是否拥有开发者权限</p>
     * 
     * @param headers GetUserAppDevAccessHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserAppDevAccessResponse
     */
    public GetUserAppDevAccessResponse getUserAppDevAccessWithOptions(String userId, GetUserAppDevAccessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetUserAppDevAccess"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/users/" + userId + "/devAccesses"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserAppDevAccessResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>用户是否拥有开发者权限</p>
     * @return GetUserAppDevAccessResponse
     */
    public GetUserAppDevAccessResponse getUserAppDevAccess(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserAppDevAccessHeaders headers = new GetUserAppDevAccessHeaders();
        return this.getUserAppDevAccessWithOptions(userId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>判断人员是否在应用的可见范围内</p>
     * 
     * @param request IsOrgMicroAppVisibleByUserIdRequest
     * @param headers IsOrgMicroAppVisibleByUserIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IsOrgMicroAppVisibleByUserIdResponse
     */
    public IsOrgMicroAppVisibleByUserIdResponse isOrgMicroAppVisibleByUserIdWithOptions(IsOrgMicroAppVisibleByUserIdRequest request, IsOrgMicroAppVisibleByUserIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            body.put("id", request.id);
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
            new TeaPair("action", "IsOrgMicroAppVisibleByUserId"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/visibleScopes/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IsOrgMicroAppVisibleByUserIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>判断人员是否在应用的可见范围内</p>
     * 
     * @param request IsOrgMicroAppVisibleByUserIdRequest
     * @return IsOrgMicroAppVisibleByUserIdResponse
     */
    public IsOrgMicroAppVisibleByUserIdResponse isOrgMicroAppVisibleByUserId(IsOrgMicroAppVisibleByUserIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IsOrgMicroAppVisibleByUserIdHeaders headers = new IsOrgMicroAppVisibleByUserIdHeaders();
        return this.isOrgMicroAppVisibleByUserIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业所有应用列表</p>
     * 
     * @param headers ListAllAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListAllAppResponse
     */
    public ListAllAppResponse listAllAppWithOptions(ListAllAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListAllApp"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/allApps"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListAllAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业所有应用列表</p>
     * @return ListAllAppResponse
     */
    public ListAllAppResponse listAllApp() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAllAppHeaders headers = new ListAllAppHeaders();
        return this.listAllAppWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业所有内部应用列表</p>
     * 
     * @param headers ListAllInnerAppsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListAllInnerAppsResponse
     */
    public ListAllInnerAppsResponse listAllInnerAppsWithOptions(ListAllInnerAppsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListAllInnerApps"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/allInnerApps"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListAllInnerAppsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业所有内部应用列表</p>
     * @return ListAllInnerAppsResponse
     */
    public ListAllInnerAppsResponse listAllInnerApps() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAllInnerAppsHeaders headers = new ListAllInnerAppsHeaders();
        return this.listAllInnerAppsWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业应用的角色完整信息</p>
     * 
     * @param request ListAppRoleScopesRequest
     * @param headers ListAppRoleScopesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListAppRoleScopesResponse
     */
    public ListAppRoleScopesResponse listAppRoleScopesWithOptions(String agentId, ListAppRoleScopesRequest request, ListAppRoleScopesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            query.put("size", request.size);
        }

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
            new TeaPair("action", "ListAppRoleScopes"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + "/roles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListAppRoleScopesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业应用的角色完整信息</p>
     * 
     * @param request ListAppRoleScopesRequest
     * @return ListAppRoleScopesResponse
     */
    public ListAppRoleScopesResponse listAppRoleScopes(String agentId, ListAppRoleScopesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAppRoleScopesHeaders headers = new ListAppRoleScopesHeaders();
        return this.listAppRoleScopesWithOptions(agentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>列出企业内部H5应用</p>
     * 
     * @param request ListInnerAppRequest
     * @param headers ListInnerAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListInnerAppResponse
     */
    public ListInnerAppResponse listInnerAppWithOptions(ListInnerAppRequest request, ListInnerAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ecologicalCorpId)) {
            query.put("ecologicalCorpId", request.ecologicalCorpId);
        }

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
            new TeaPair("action", "ListInnerApp"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListInnerAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>列出企业内部H5应用</p>
     * 
     * @param request ListInnerAppRequest
     * @return ListInnerAppResponse
     */
    public ListInnerAppResponse listInnerApp(ListInnerAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListInnerAppHeaders headers = new ListInnerAppHeaders();
        return this.listInnerAppWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业内部小程序的版本列表</p>
     * 
     * @param headers ListInnerAppVersionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListInnerAppVersionResponse
     */
    public ListInnerAppVersionResponse listInnerAppVersionWithOptions(String agentId, ListInnerAppVersionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListInnerAppVersion"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/innerMiniApps/" + agentId + "/versions"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListInnerAppVersionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业内部小程序的版本列表</p>
     * @return ListInnerAppVersionResponse
     */
    public ListInnerAppVersionResponse listInnerAppVersion(String agentId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListInnerAppVersionHeaders headers = new ListInnerAppVersionHeaders();
        return this.listInnerAppVersionWithOptions(agentId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户在应用中的角色信息列表</p>
     * 
     * @param headers ListRoleInfoByUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListRoleInfoByUserResponse
     */
    public ListRoleInfoByUserResponse listRoleInfoByUserWithOptions(String agentId, String userId, ListRoleInfoByUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListRoleInfoByUser"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + "/users/" + userId + "/roles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListRoleInfoByUserResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户在应用中的角色信息列表</p>
     * @return ListRoleInfoByUserResponse
     */
    public ListRoleInfoByUserResponse listRoleInfoByUser(String agentId, String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListRoleInfoByUserHeaders headers = new ListRoleInfoByUserHeaders();
        return this.listRoleInfoByUserWithOptions(agentId, userId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>列出用户可见的企业应用</p>
     * 
     * @param headers ListUserVilebleAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListUserVilebleAppResponse
     */
    public ListUserVilebleAppResponse listUserVilebleAppWithOptions(String userId, ListUserVilebleAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListUserVilebleApp"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/users/" + userId + "/apps"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListUserVilebleAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>列出用户可见的企业应用</p>
     * @return ListUserVilebleAppResponse
     */
    public ListUserVilebleAppResponse listUserVilebleApp(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListUserVilebleAppHeaders headers = new ListUserVilebleAppHeaders();
        return this.listUserVilebleAppWithOptions(userId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业内部小程序历史版本列表</p>
     * 
     * @param request PageInnerAppHistoryVersionRequest
     * @param headers PageInnerAppHistoryVersionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PageInnerAppHistoryVersionResponse
     */
    public PageInnerAppHistoryVersionResponse pageInnerAppHistoryVersionWithOptions(String agentId, PageInnerAppHistoryVersionRequest request, PageInnerAppHistoryVersionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "PageInnerAppHistoryVersion"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/innerMiniApps/" + agentId + "/historyVersions"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PageInnerAppHistoryVersionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业内部小程序历史版本列表</p>
     * 
     * @param request PageInnerAppHistoryVersionRequest
     * @return PageInnerAppHistoryVersionResponse
     */
    public PageInnerAppHistoryVersionResponse pageInnerAppHistoryVersion(String agentId, PageInnerAppHistoryVersionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PageInnerAppHistoryVersionHeaders headers = new PageInnerAppHistoryVersionHeaders();
        return this.pageInnerAppHistoryVersionWithOptions(agentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发布企业内部小程序版本</p>
     * 
     * @param request PublishInnerAppVersionRequest
     * @param headers PublishInnerAppVersionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PublishInnerAppVersionResponse
     */
    public PublishInnerAppVersionResponse publishInnerAppVersionWithOptions(String agentId, PublishInnerAppVersionRequest request, PublishInnerAppVersionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appVersionId)) {
            body.put("appVersionId", request.appVersionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.miniAppOnPc)) {
            body.put("miniAppOnPc", request.miniAppOnPc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUnionId)) {
            body.put("opUnionId", request.opUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.publishType)) {
            body.put("publishType", request.publishType);
        }

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
            new TeaPair("action", "PublishInnerAppVersion"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/innerMiniApps/" + agentId + "/versions/publish"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PublishInnerAppVersionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发布企业内部小程序版本</p>
     * 
     * @param request PublishInnerAppVersionRequest
     * @return PublishInnerAppVersionResponse
     */
    public PublishInnerAppVersionResponse publishInnerAppVersion(String agentId, PublishInnerAppVersionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PublishInnerAppVersionHeaders headers = new PublishInnerAppVersionHeaders();
        return this.publishInnerAppVersionWithOptions(agentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>重设角色范围</p>
     * 
     * @param request RebuildRoleScopeForAppRoleRequest
     * @param headers RebuildRoleScopeForAppRoleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RebuildRoleScopeForAppRoleResponse
     */
    public RebuildRoleScopeForAppRoleResponse rebuildRoleScopeForAppRoleWithOptions(String agentId, String roleId, RebuildRoleScopeForAppRoleRequest request, RebuildRoleScopeForAppRoleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptIdList)) {
            body.put("deptIdList", request.deptIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeType)) {
            body.put("scopeType", request.scopeType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeVersion)) {
            body.put("scopeVersion", request.scopeVersion);
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
            new TeaPair("action", "RebuildRoleScopeForAppRole"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/scopes/rebuild"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RebuildRoleScopeForAppRoleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>重设角色范围</p>
     * 
     * @param request RebuildRoleScopeForAppRoleRequest
     * @return RebuildRoleScopeForAppRoleResponse
     */
    public RebuildRoleScopeForAppRoleResponse rebuildRoleScopeForAppRole(String agentId, String roleId, RebuildRoleScopeForAppRoleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RebuildRoleScopeForAppRoleHeaders headers = new RebuildRoleScopeForAppRoleHeaders();
        return this.rebuildRoleScopeForAppRoleWithOptions(agentId, roleId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>注册自定义应用角色</p>
     * 
     * @param request RegisterCustomAppRoleRequest
     * @param headers RegisterCustomAppRoleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RegisterCustomAppRoleResponse
     */
    public RegisterCustomAppRoleResponse registerCustomAppRoleWithOptions(String agentId, RegisterCustomAppRoleRequest request, RegisterCustomAppRoleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.canManageRole)) {
            body.put("canManageRole", request.canManageRole);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleName)) {
            body.put("roleName", request.roleName);
        }

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
            new TeaPair("action", "RegisterCustomAppRole"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + "/roles"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RegisterCustomAppRoleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>注册自定义应用角色</p>
     * 
     * @param request RegisterCustomAppRoleRequest
     * @return RegisterCustomAppRoleResponse
     */
    public RegisterCustomAppRoleResponse registerCustomAppRole(String agentId, RegisterCustomAppRoleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RegisterCustomAppRoleHeaders headers = new RegisterCustomAppRoleHeaders();
        return this.registerCustomAppRoleWithOptions(agentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除apaas应用</p>
     * 
     * @param request RemoveApaasAppRequest
     * @param headers RemoveApaasAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RemoveApaasAppResponse
     */
    public RemoveApaasAppResponse removeApaasAppWithOptions(RemoveApaasAppRequest request, RemoveApaasAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizAppId)) {
            body.put("bizAppId", request.bizAppId);
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
            new TeaPair("action", "RemoveApaasApp"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apaasApps/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RemoveApaasAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除apaas应用</p>
     * 
     * @param request RemoveApaasAppRequest
     * @return RemoveApaasAppResponse
     */
    public RemoveApaasAppResponse removeApaasApp(RemoveApaasAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveApaasAppHeaders headers = new RemoveApaasAppHeaders();
        return this.removeApaasAppWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除指定角色下的成员</p>
     * 
     * @param request RemoveMemberForAppRoleRequest
     * @param headers RemoveMemberForAppRoleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RemoveMemberForAppRoleResponse
     */
    public RemoveMemberForAppRoleResponse removeMemberForAppRoleWithOptions(String agentId, String roleId, RemoveMemberForAppRoleRequest request, RemoveMemberForAppRoleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptIdList)) {
            body.put("deptIdList", request.deptIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeVersion)) {
            body.put("scopeVersion", request.scopeVersion);
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
            new TeaPair("action", "RemoveMemberForAppRole"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/members/batchRemove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RemoveMemberForAppRoleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除指定角色下的成员</p>
     * 
     * @param request RemoveMemberForAppRoleRequest
     * @return RemoveMemberForAppRoleResponse
     */
    public RemoveMemberForAppRoleResponse removeMemberForAppRole(String agentId, String roleId, RemoveMemberForAppRoleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveMemberForAppRoleHeaders headers = new RemoveMemberForAppRoleHeaders();
        return this.removeMemberForAppRoleWithOptions(agentId, roleId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>回滚企业内部小程序版本</p>
     * 
     * @param request RollbackInnerAppVersionRequest
     * @param headers RollbackInnerAppVersionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RollbackInnerAppVersionResponse
     */
    public RollbackInnerAppVersionResponse rollbackInnerAppVersionWithOptions(String agentId, RollbackInnerAppVersionRequest request, RollbackInnerAppVersionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appVersionId)) {
            body.put("appVersionId", request.appVersionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUnionId)) {
            body.put("opUnionId", request.opUnionId);
        }

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
            new TeaPair("action", "RollbackInnerAppVersion"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/innerMiniApps/" + agentId + "/versions/rollback"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RollbackInnerAppVersionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>回滚企业内部小程序版本</p>
     * 
     * @param request RollbackInnerAppVersionRequest
     * @return RollbackInnerAppVersionResponse
     */
    public RollbackInnerAppVersionResponse rollbackInnerAppVersion(String agentId, RollbackInnerAppVersionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RollbackInnerAppVersionHeaders headers = new RollbackInnerAppVersionHeaders();
        return this.rollbackInnerAppVersionWithOptions(agentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>设置应用可见范围</p>
     * 
     * @param request SetMicroAppScopeRequest
     * @param headers SetMicroAppScopeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetMicroAppScopeResponse
     */
    public SetMicroAppScopeResponse setMicroAppScopeWithOptions(String agentId, SetMicroAppScopeRequest request, SetMicroAppScopeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.addDeptIds)) {
            body.put("addDeptIds", request.addDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.addRoleIds)) {
            body.put("addRoleIds", request.addRoleIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.addUserIds)) {
            body.put("addUserIds", request.addUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.delDeptIds)) {
            body.put("delDeptIds", request.delDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.delRoleIds)) {
            body.put("delRoleIds", request.delRoleIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.delUserIds)) {
            body.put("delUserIds", request.delUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.onlyAdminVisible)) {
            body.put("onlyAdminVisible", request.onlyAdminVisible);
        }

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
            new TeaPair("action", "SetMicroAppScope"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + "/scopes"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetMicroAppScopeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>设置应用可见范围</p>
     * 
     * @param request SetMicroAppScopeRequest
     * @return SetMicroAppScopeResponse
     */
    public SetMicroAppScopeResponse setMicroAppScope(String agentId, SetMicroAppScopeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetMicroAppScopeHeaders headers = new SetMicroAppScopeHeaders();
        return this.setMicroAppScopeWithOptions(agentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新apaas应用</p>
     * 
     * @param request UpdateApaasAppRequest
     * @param headers UpdateApaasAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateApaasAppResponse
     */
    public UpdateApaasAppResponse updateApaasAppWithOptions(UpdateApaasAppRequest request, UpdateApaasAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appIcon)) {
            body.put("appIcon", request.appIcon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appStatus)) {
            body.put("appStatus", request.appStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizAppId)) {
            body.put("bizAppId", request.bizAppId);
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
            new TeaPair("action", "UpdateApaasApp"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apaasApps"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateApaasAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新apaas应用</p>
     * 
     * @param request UpdateApaasAppRequest
     * @return UpdateApaasAppResponse
     */
    public UpdateApaasAppResponse updateApaasApp(UpdateApaasAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateApaasAppHeaders headers = new UpdateApaasAppHeaders();
        return this.updateApaasAppWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新应用角色信息</p>
     * 
     * @param request UpdateAppRoleInfoRequest
     * @param headers UpdateAppRoleInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateAppRoleInfoResponse
     */
    public UpdateAppRoleInfoResponse updateAppRoleInfoWithOptions(String agentId, String roleId, UpdateAppRoleInfoRequest request, UpdateAppRoleInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.canManageRole)) {
            body.put("canManageRole", request.canManageRole);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.newRoleName)) {
            body.put("newRoleName", request.newRoleName);
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
            new TeaPair("action", "UpdateAppRoleInfo"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateAppRoleInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新应用角色信息</p>
     * 
     * @param request UpdateAppRoleInfoRequest
     * @return UpdateAppRoleInfoResponse
     */
    public UpdateAppRoleInfoResponse updateAppRoleInfo(String agentId, String roleId, UpdateAppRoleInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateAppRoleInfoHeaders headers = new UpdateAppRoleInfoHeaders();
        return this.updateAppRoleInfoWithOptions(agentId, roleId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新企业内部应用</p>
     * 
     * @param request UpdateInnerAppRequest
     * @param headers UpdateInnerAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInnerAppResponse
     */
    public UpdateInnerAppResponse updateInnerAppWithOptions(String agentId, UpdateInnerAppRequest request, UpdateInnerAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.desc)) {
            body.put("desc", request.desc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.homepageLink)) {
            body.put("homepageLink", request.homepageLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ipWhiteList)) {
            body.put("ipWhiteList", request.ipWhiteList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ompLink)) {
            body.put("ompLink", request.ompLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUnionId)) {
            body.put("opUnionId", request.opUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pcHomepageLink)) {
            body.put("pcHomepageLink", request.pcHomepageLink);
        }

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
            new TeaPair("action", "UpdateInnerApp"),
            new TeaPair("version", "microApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/microApp/apps/" + agentId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateInnerAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新企业内部应用</p>
     * 
     * @param request UpdateInnerAppRequest
     * @return UpdateInnerAppResponse
     */
    public UpdateInnerAppResponse updateInnerApp(String agentId, UpdateInnerAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInnerAppHeaders headers = new UpdateInnerAppHeaders();
        return this.updateInnerAppWithOptions(agentId, request, headers, runtime);
    }
}
