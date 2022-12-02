// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkindustry_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public CampusAddRenterMemberResponse campusAddRenterMember(CampusAddRenterMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusAddRenterMemberHeaders headers = new CampusAddRenterMemberHeaders();
        return this.campusAddRenterMemberWithOptions(request, headers, runtime);
    }

    public CampusAddRenterMemberResponse campusAddRenterMemberWithOptions(CampusAddRenterMemberRequest request, CampusAddRenterMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.renterId)) {
            body.put("renterId", request.renterId);
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
        return TeaModel.toModel(this.doROARequest("CampusAddRenterMember", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/campuses/renters/members", "json", req, runtime), new CampusAddRenterMemberResponse());
    }

    public CampusCreateCampusResponse campusCreateCampus(CampusCreateCampusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusCreateCampusHeaders headers = new CampusCreateCampusHeaders();
        return this.campusCreateCampusWithOptions(request, headers, runtime);
    }

    public CampusCreateCampusResponse campusCreateCampusWithOptions(CampusCreateCampusRequest request, CampusCreateCampusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.address)) {
            body.put("address", request.address);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.area)) {
            body.put("area", request.area);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.belongProjectGroupId)) {
            body.put("belongProjectGroupId", request.belongProjectGroupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.campusName)) {
            body.put("campusName", request.campusName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.capacity)) {
            body.put("capacity", request.capacity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cityId)) {
            body.put("cityId", request.cityId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.country)) {
            body.put("country", request.country);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.countyId)) {
            body.put("countyId", request.countyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.creatorUnionId)) {
            body.put("creatorUnionId", request.creatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.location)) {
            body.put("location", request.location);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderEndTime)) {
            body.put("orderEndTime", request.orderEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderInfo)) {
            body.put("orderInfo", request.orderInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderStartTime)) {
            body.put("orderStartTime", request.orderStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.provId)) {
            body.put("provId", request.provId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.telephone)) {
            body.put("telephone", request.telephone);
        }

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
        return TeaModel.toModel(this.doROARequest("CampusCreateCampus", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/campuses/projects", "json", req, runtime), new CampusCreateCampusResponse());
    }

    public CampusCreateCampusGroupResponse campusCreateCampusGroup(CampusCreateCampusGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusCreateCampusGroupHeaders headers = new CampusCreateCampusGroupHeaders();
        return this.campusCreateCampusGroupWithOptions(request, headers, runtime);
    }

    public CampusCreateCampusGroupResponse campusCreateCampusGroupWithOptions(CampusCreateCampusGroupRequest request, CampusCreateCampusGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

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
        return TeaModel.toModel(this.doROARequest("CampusCreateCampusGroup", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/campuses/projects/groups", "json", req, runtime), new CampusCreateCampusGroupResponse());
    }

    public CampusCreateRenterResponse campusCreateRenter(CampusCreateRenterRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusCreateRenterHeaders headers = new CampusCreateRenterHeaders();
        return this.campusCreateRenterWithOptions(request, headers, runtime);
    }

    public CampusCreateRenterResponse campusCreateRenterWithOptions(CampusCreateRenterRequest request, CampusCreateRenterHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creditCode)) {
            body.put("creditCode", request.creditCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.state)) {
            body.put("state", request.state);
        }

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
        return TeaModel.toModel(this.doROARequest("CampusCreateRenter", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/campuses/renters", "json", req, runtime), new CampusCreateRenterResponse());
    }

    public CampusDelRenterMemberResponse campusDelRenterMember(CampusDelRenterMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusDelRenterMemberHeaders headers = new CampusDelRenterMemberHeaders();
        return this.campusDelRenterMemberWithOptions(request, headers, runtime);
    }

    public CampusDelRenterMemberResponse campusDelRenterMemberWithOptions(CampusDelRenterMemberRequest request, CampusDelRenterMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.renterId)) {
            query.put("renterId", request.renterId);
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
        return TeaModel.toModel(this.doROARequest("CampusDelRenterMember", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/campuses/renters/members", "json", req, runtime), new CampusDelRenterMemberResponse());
    }

    public CampusDeleteCampusGroupResponse campusDeleteCampusGroup(CampusDeleteCampusGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusDeleteCampusGroupHeaders headers = new CampusDeleteCampusGroupHeaders();
        return this.campusDeleteCampusGroupWithOptions(request, headers, runtime);
    }

    public CampusDeleteCampusGroupResponse campusDeleteCampusGroupWithOptions(CampusDeleteCampusGroupRequest request, CampusDeleteCampusGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.campusProjectGroupId)) {
            query.put("campusProjectGroupId", request.campusProjectGroupId);
        }

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
        return TeaModel.toModel(this.doROARequest("CampusDeleteCampusGroup", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/campuses/projects/groups", "json", req, runtime), new CampusDeleteCampusGroupResponse());
    }

    public CampusDeleteRenterResponse campusDeleteRenter(CampusDeleteRenterRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusDeleteRenterHeaders headers = new CampusDeleteRenterHeaders();
        return this.campusDeleteRenterWithOptions(request, headers, runtime);
    }

    public CampusDeleteRenterResponse campusDeleteRenterWithOptions(CampusDeleteRenterRequest request, CampusDeleteRenterHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.renterId)) {
            query.put("renterId", request.renterId);
        }

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
        return TeaModel.toModel(this.doROARequest("CampusDeleteRenter", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/campuses/renters", "none", req, runtime), new CampusDeleteRenterResponse());
    }

    public CampusGetCampusResponse campusGetCampus(CampusGetCampusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusGetCampusHeaders headers = new CampusGetCampusHeaders();
        return this.campusGetCampusWithOptions(request, headers, runtime);
    }

    public CampusGetCampusResponse campusGetCampusWithOptions(CampusGetCampusRequest request, CampusGetCampusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.campusDeptId)) {
            query.put("campusDeptId", request.campusDeptId);
        }

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
        return TeaModel.toModel(this.doROARequest("CampusGetCampus", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/projectInfos", "json", req, runtime), new CampusGetCampusResponse());
    }

    public CampusGetCampusGroupResponse campusGetCampusGroup(CampusGetCampusGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusGetCampusGroupHeaders headers = new CampusGetCampusGroupHeaders();
        return this.campusGetCampusGroupWithOptions(request, headers, runtime);
    }

    public CampusGetCampusGroupResponse campusGetCampusGroupWithOptions(CampusGetCampusGroupRequest request, CampusGetCampusGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupId)) {
            query.put("groupId", request.groupId);
        }

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
        return TeaModel.toModel(this.doROARequest("CampusGetCampusGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/projects/groupInfos", "json", req, runtime), new CampusGetCampusGroupResponse());
    }

    public CampusGetRenterResponse campusGetRenter(CampusGetRenterRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusGetRenterHeaders headers = new CampusGetRenterHeaders();
        return this.campusGetRenterWithOptions(request, headers, runtime);
    }

    public CampusGetRenterResponse campusGetRenterWithOptions(CampusGetRenterRequest request, CampusGetRenterHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.renterId)) {
            query.put("renterId", request.renterId);
        }

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
        return TeaModel.toModel(this.doROARequest("CampusGetRenter", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/renterInfos", "json", req, runtime), new CampusGetRenterResponse());
    }

    public CampusGetRenterMemberResponse campusGetRenterMember(CampusGetRenterMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusGetRenterMemberHeaders headers = new CampusGetRenterMemberHeaders();
        return this.campusGetRenterMemberWithOptions(request, headers, runtime);
    }

    public CampusGetRenterMemberResponse campusGetRenterMemberWithOptions(CampusGetRenterMemberRequest request, CampusGetRenterMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.renterId)) {
            query.put("renterId", request.renterId);
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
        return TeaModel.toModel(this.doROARequest("CampusGetRenterMember", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/renters/memberInfos", "json", req, runtime), new CampusGetRenterMemberResponse());
    }

    public CampusListCampusResponse campusListCampus(CampusListCampusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusListCampusHeaders headers = new CampusListCampusHeaders();
        return this.campusListCampusWithOptions(request, headers, runtime);
    }

    public CampusListCampusResponse campusListCampusWithOptions(CampusListCampusRequest request, CampusListCampusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupDeptId)) {
            query.put("groupDeptId", request.groupDeptId);
        }

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
        return TeaModel.toModel(this.doROARequest("CampusListCampus", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/projects", "json", req, runtime), new CampusListCampusResponse());
    }

    public CampusListCampusGroupResponse campusListCampusGroup() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusListCampusGroupHeaders headers = new CampusListCampusGroupHeaders();
        return this.campusListCampusGroupWithOptions(headers, runtime);
    }

    public CampusListCampusGroupResponse campusListCampusGroupWithOptions(CampusListCampusGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("CampusListCampusGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/projects/groups", "json", req, runtime), new CampusListCampusGroupResponse());
    }

    public CampusListRenterResponse campusListRenter() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusListRenterHeaders headers = new CampusListRenterHeaders();
        return this.campusListRenterWithOptions(headers, runtime);
    }

    public CampusListRenterResponse campusListRenterWithOptions(CampusListRenterHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("CampusListRenter", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/renters", "json", req, runtime), new CampusListRenterResponse());
    }

    public CampusListRenterMembersResponse campusListRenterMembers(CampusListRenterMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusListRenterMembersHeaders headers = new CampusListRenterMembersHeaders();
        return this.campusListRenterMembersWithOptions(request, headers, runtime);
    }

    public CampusListRenterMembersResponse campusListRenterMembersWithOptions(CampusListRenterMembersRequest request, CampusListRenterMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.renterId)) {
            query.put("renterId", request.renterId);
        }

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
        return TeaModel.toModel(this.doROARequest("CampusListRenterMembers", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/renters/members", "json", req, runtime), new CampusListRenterMembersResponse());
    }

    public CampusUpdateCampusResponse campusUpdateCampus(CampusUpdateCampusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusUpdateCampusHeaders headers = new CampusUpdateCampusHeaders();
        return this.campusUpdateCampusWithOptions(request, headers, runtime);
    }

    public CampusUpdateCampusResponse campusUpdateCampusWithOptions(CampusUpdateCampusRequest request, CampusUpdateCampusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.address)) {
            body.put("address", request.address);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.area)) {
            body.put("area", request.area);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.belongProjectGroupId)) {
            body.put("belongProjectGroupId", request.belongProjectGroupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.campusDeptId)) {
            body.put("campusDeptId", request.campusDeptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.campusName)) {
            body.put("campusName", request.campusName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.capacity)) {
            body.put("capacity", request.capacity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cityId)) {
            body.put("cityId", request.cityId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.country)) {
            body.put("country", request.country);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.countyId)) {
            body.put("countyId", request.countyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderEndTime)) {
            body.put("orderEndTime", request.orderEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderInfo)) {
            body.put("orderInfo", request.orderInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderStartTime)) {
            body.put("orderStartTime", request.orderStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.provId)) {
            body.put("provId", request.provId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.telephone)) {
            body.put("telephone", request.telephone);
        }

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
        return TeaModel.toModel(this.doROARequest("CampusUpdateCampus", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/campuses/projects", "json", req, runtime), new CampusUpdateCampusResponse());
    }

    public CampusUpdateCampusGroupResponse campusUpdateCampusGroup(CampusUpdateCampusGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusUpdateCampusGroupHeaders headers = new CampusUpdateCampusGroupHeaders();
        return this.campusUpdateCampusGroupWithOptions(request, headers, runtime);
    }

    public CampusUpdateCampusGroupResponse campusUpdateCampusGroupWithOptions(CampusUpdateCampusGroupRequest request, CampusUpdateCampusGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.campusProjectGroupId)) {
            body.put("campusProjectGroupId", request.campusProjectGroupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

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
        return TeaModel.toModel(this.doROARequest("CampusUpdateCampusGroup", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/campuses/projects/groups", "json", req, runtime), new CampusUpdateCampusGroupResponse());
    }

    public CampusUpdateRenterResponse campusUpdateRenter(CampusUpdateRenterRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusUpdateRenterHeaders headers = new CampusUpdateRenterHeaders();
        return this.campusUpdateRenterWithOptions(request, headers, runtime);
    }

    public CampusUpdateRenterResponse campusUpdateRenterWithOptions(CampusUpdateRenterRequest request, CampusUpdateRenterHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creditCode)) {
            body.put("creditCode", request.creditCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.renterId)) {
            body.put("renterId", request.renterId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.state)) {
            body.put("state", request.state);
        }

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
        return TeaModel.toModel(this.doROARequest("CampusUpdateRenter", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/campuses/renters", "json", req, runtime), new CampusUpdateRenterResponse());
    }

    public CampusUpdateRenterMemberResponse campusUpdateRenterMember(CampusUpdateRenterMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusUpdateRenterMemberHeaders headers = new CampusUpdateRenterMemberHeaders();
        return this.campusUpdateRenterMemberWithOptions(request, headers, runtime);
    }

    public CampusUpdateRenterMemberResponse campusUpdateRenterMemberWithOptions(CampusUpdateRenterMemberRequest request, CampusUpdateRenterMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.renterId)) {
            body.put("renterId", request.renterId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
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
        return TeaModel.toModel(this.doROARequest("CampusUpdateRenterMember", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/campuses/renters/members", "json", req, runtime), new CampusUpdateRenterMemberResponse());
    }

    public CollegeActiveCollegeDeptGroupResponse collegeActiveCollegeDeptGroup(CollegeActiveCollegeDeptGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeActiveCollegeDeptGroupHeaders headers = new CollegeActiveCollegeDeptGroupHeaders();
        return this.collegeActiveCollegeDeptGroupWithOptions(request, headers, runtime);
    }

    public CollegeActiveCollegeDeptGroupResponse collegeActiveCollegeDeptGroupWithOptions(CollegeActiveCollegeDeptGroupRequest request, CollegeActiveCollegeDeptGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

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
        return TeaModel.toModel(this.doROARequest("CollegeActiveCollegeDeptGroup", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/colleges/depts/groups", "json", req, runtime), new CollegeActiveCollegeDeptGroupResponse());
    }

    public CollegeAddCollegeDeptResponse collegeAddCollegeDept(CollegeAddCollegeDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeAddCollegeDeptHeaders headers = new CollegeAddCollegeDeptHeaders();
        return this.collegeAddCollegeDeptWithOptions(request, headers, runtime);
    }

    public CollegeAddCollegeDeptResponse collegeAddCollegeDeptWithOptions(CollegeAddCollegeDeptRequest request, CollegeAddCollegeDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptName)) {
            query.put("deptName", request.deptName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptType)) {
            query.put("deptType", request.deptType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sortFactor)) {
            query.put("sortFactor", request.sortFactor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.superId)) {
            query.put("superId", request.superId);
        }

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
        return TeaModel.toModel(this.doROARequest("CollegeAddCollegeDept", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/colleges/depts", "json", req, runtime), new CollegeAddCollegeDeptResponse());
    }

    public CollegeAddManagerResponse collegeAddManager(CollegeAddManagerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeAddManagerHeaders headers = new CollegeAddManagerHeaders();
        return this.collegeAddManagerWithOptions(request, headers, runtime);
    }

    public CollegeAddManagerResponse collegeAddManagerWithOptions(CollegeAddManagerRequest request, CollegeAddManagerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
        return TeaModel.toModel(this.doROARequest("CollegeAddManager", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/colleges/members/depts/managers", "json", req, runtime), new CollegeAddManagerResponse());
    }

    public CollegeAddStudentResponse collegeAddStudent(CollegeAddStudentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeAddStudentHeaders headers = new CollegeAddStudentHeaders();
        return this.collegeAddStudentWithOptions(request, headers, runtime);
    }

    public CollegeAddStudentResponse collegeAddStudentWithOptions(CollegeAddStudentRequest request, CollegeAddStudentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.empExtension)) {
            body.put("empExtension", request.empExtension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gender)) {
            body.put("gender", request.gender);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.identifyId)) {
            body.put("identifyId", request.identifyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startYear)) {
            body.put("startYear", request.startYear);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentName)) {
            body.put("studentName", request.studentName);
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
        return TeaModel.toModel(this.doROARequest("CollegeAddStudent", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/colleges/members/depts/students", "json", req, runtime), new CollegeAddStudentResponse());
    }

    public CollegeChangeStudentDeptResponse collegeChangeStudentDept(CollegeChangeStudentDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeChangeStudentDeptHeaders headers = new CollegeChangeStudentDeptHeaders();
        return this.collegeChangeStudentDeptWithOptions(request, headers, runtime);
    }

    public CollegeChangeStudentDeptResponse collegeChangeStudentDeptWithOptions(CollegeChangeStudentDeptRequest request, CollegeChangeStudentDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.newDeptId)) {
            query.put("newDeptId", request.newDeptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            query.put("studentId", request.studentId);
        }

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
        return TeaModel.toModel(this.doROARequest("CollegeChangeStudentDept", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/colleges/members/depts/students/move", "json", req, runtime), new CollegeChangeStudentDeptResponse());
    }

    public CollegeDeleteCollegeDeptResponse collegeDeleteCollegeDept(CollegeDeleteCollegeDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeDeleteCollegeDeptHeaders headers = new CollegeDeleteCollegeDeptHeaders();
        return this.collegeDeleteCollegeDeptWithOptions(request, headers, runtime);
    }

    public CollegeDeleteCollegeDeptResponse collegeDeleteCollegeDeptWithOptions(CollegeDeleteCollegeDeptRequest request, CollegeDeleteCollegeDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

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
        return TeaModel.toModel(this.doROARequest("CollegeDeleteCollegeDept", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/colleges/depts", "json", req, runtime), new CollegeDeleteCollegeDeptResponse());
    }

    public CollegeListCollegeSubDeptResponse collegeListCollegeSubDept(CollegeListCollegeSubDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeListCollegeSubDeptHeaders headers = new CollegeListCollegeSubDeptHeaders();
        return this.collegeListCollegeSubDeptWithOptions(request, headers, runtime);
    }

    public CollegeListCollegeSubDeptResponse collegeListCollegeSubDeptWithOptions(CollegeListCollegeSubDeptRequest request, CollegeListCollegeSubDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

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
        return TeaModel.toModel(this.doROARequest("CollegeListCollegeSubDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/colleges/subDepts", "json", req, runtime), new CollegeListCollegeSubDeptResponse());
    }

    public CollegeListDeptManagerResponse collegeListDeptManager(CollegeListDeptManagerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeListDeptManagerHeaders headers = new CollegeListDeptManagerHeaders();
        return this.collegeListDeptManagerWithOptions(request, headers, runtime);
    }

    public CollegeListDeptManagerResponse collegeListDeptManagerWithOptions(CollegeListDeptManagerRequest request, CollegeListDeptManagerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
        return TeaModel.toModel(this.doROARequest("CollegeListDeptManager", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/colleges/members/depts/managers", "json", req, runtime), new CollegeListDeptManagerResponse());
    }

    public CollegeListStudentInfoResponse collegeListStudentInfo(CollegeListStudentInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeListStudentInfoHeaders headers = new CollegeListStudentInfoHeaders();
        return this.collegeListStudentInfoWithOptions(request, headers, runtime);
    }

    public CollegeListStudentInfoResponse collegeListStudentInfoWithOptions(CollegeListStudentInfoRequest request, CollegeListStudentInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingStudentStatus)) {
            query.put("dingStudentStatus", request.dingStudentStatus);
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
        return TeaModel.toModel(this.doROARequest("CollegeListStudentInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/colleges/members/depts/students", "json", req, runtime), new CollegeListStudentInfoResponse());
    }

    public CollegeListUncheckedStudentResponse collegeListUncheckedStudent(CollegeListUncheckedStudentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeListUncheckedStudentHeaders headers = new CollegeListUncheckedStudentHeaders();
        return this.collegeListUncheckedStudentWithOptions(request, headers, runtime);
    }

    public CollegeListUncheckedStudentResponse collegeListUncheckedStudentWithOptions(CollegeListUncheckedStudentRequest request, CollegeListUncheckedStudentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
        return TeaModel.toModel(this.doROARequest("CollegeListUncheckedStudent", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/colleges/members/organizations/unjoinedStudents", "json", req, runtime), new CollegeListUncheckedStudentResponse());
    }

    public CollegeQueryCollegeDeptGroupInfoResponse collegeQueryCollegeDeptGroupInfo(CollegeQueryCollegeDeptGroupInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeQueryCollegeDeptGroupInfoHeaders headers = new CollegeQueryCollegeDeptGroupInfoHeaders();
        return this.collegeQueryCollegeDeptGroupInfoWithOptions(request, headers, runtime);
    }

    public CollegeQueryCollegeDeptGroupInfoResponse collegeQueryCollegeDeptGroupInfoWithOptions(CollegeQueryCollegeDeptGroupInfoRequest request, CollegeQueryCollegeDeptGroupInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

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
        return TeaModel.toModel(this.doROARequest("CollegeQueryCollegeDeptGroupInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/colleges/depts/groupInfos", "json", req, runtime), new CollegeQueryCollegeDeptGroupInfoResponse());
    }

    public CollegeQueryCollegeDeptInfoResponse collegeQueryCollegeDeptInfo(CollegeQueryCollegeDeptInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeQueryCollegeDeptInfoHeaders headers = new CollegeQueryCollegeDeptInfoHeaders();
        return this.collegeQueryCollegeDeptInfoWithOptions(request, headers, runtime);
    }

    public CollegeQueryCollegeDeptInfoResponse collegeQueryCollegeDeptInfoWithOptions(CollegeQueryCollegeDeptInfoRequest request, CollegeQueryCollegeDeptInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

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
        return TeaModel.toModel(this.doROARequest("CollegeQueryCollegeDeptInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/colleges/deptInfos", "json", req, runtime), new CollegeQueryCollegeDeptInfoResponse());
    }

    public CollegeQueryStudentInfoByDeptResponse collegeQueryStudentInfoByDept(CollegeQueryStudentInfoByDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeQueryStudentInfoByDeptHeaders headers = new CollegeQueryStudentInfoByDeptHeaders();
        return this.collegeQueryStudentInfoByDeptWithOptions(request, headers, runtime);
    }

    public CollegeQueryStudentInfoByDeptResponse collegeQueryStudentInfoByDeptWithOptions(CollegeQueryStudentInfoByDeptRequest request, CollegeQueryStudentInfoByDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            query.put("studentId", request.studentId);
        }

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
        return TeaModel.toModel(this.doROARequest("CollegeQueryStudentInfoByDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/colleges/members/depts/studentinfos", "json", req, runtime), new CollegeQueryStudentInfoByDeptResponse());
    }

    public CollegeQueryStudentInfoByMobileResponse collegeQueryStudentInfoByMobile(CollegeQueryStudentInfoByMobileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeQueryStudentInfoByMobileHeaders headers = new CollegeQueryStudentInfoByMobileHeaders();
        return this.collegeQueryStudentInfoByMobileWithOptions(request, headers, runtime);
    }

    public CollegeQueryStudentInfoByMobileResponse collegeQueryStudentInfoByMobileWithOptions(CollegeQueryStudentInfoByMobileRequest request, CollegeQueryStudentInfoByMobileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            query.put("mobile", request.mobile);
        }

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
        return TeaModel.toModel(this.doROARequest("CollegeQueryStudentInfoByMobile", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/colleges/members/students/mobiles", "json", req, runtime), new CollegeQueryStudentInfoByMobileResponse());
    }

    public CollegeQueryStudentInfoByStudentIdResponse collegeQueryStudentInfoByStudentId(CollegeQueryStudentInfoByStudentIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeQueryStudentInfoByStudentIdHeaders headers = new CollegeQueryStudentInfoByStudentIdHeaders();
        return this.collegeQueryStudentInfoByStudentIdWithOptions(request, headers, runtime);
    }

    public CollegeQueryStudentInfoByStudentIdResponse collegeQueryStudentInfoByStudentIdWithOptions(CollegeQueryStudentInfoByStudentIdRequest request, CollegeQueryStudentInfoByStudentIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            query.put("studentId", request.studentId);
        }

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
        return TeaModel.toModel(this.doROARequest("CollegeQueryStudentInfoByStudentId", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/colleges/members/students", "json", req, runtime), new CollegeQueryStudentInfoByStudentIdResponse());
    }

    public CollegeRemoveManagerResponse collegeRemoveManager(CollegeRemoveManagerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeRemoveManagerHeaders headers = new CollegeRemoveManagerHeaders();
        return this.collegeRemoveManagerWithOptions(request, headers, runtime);
    }

    public CollegeRemoveManagerResponse collegeRemoveManagerWithOptions(CollegeRemoveManagerRequest request, CollegeRemoveManagerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isForce)) {
            query.put("isForce", request.isForce);
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
        return TeaModel.toModel(this.doROARequest("CollegeRemoveManager", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/colleges/members/managers", "json", req, runtime), new CollegeRemoveManagerResponse());
    }

    public CollegeRemoveStudentResponse collegeRemoveStudent(CollegeRemoveStudentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeRemoveStudentHeaders headers = new CollegeRemoveStudentHeaders();
        return this.collegeRemoveStudentWithOptions(request, headers, runtime);
    }

    public CollegeRemoveStudentResponse collegeRemoveStudentWithOptions(CollegeRemoveStudentRequest request, CollegeRemoveStudentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            query.put("studentId", request.studentId);
        }

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
        return TeaModel.toModel(this.doROARequest("CollegeRemoveStudent", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/colleges/members/depts/students", "json", req, runtime), new CollegeRemoveStudentResponse());
    }

    public CollegeUpdateCollegeDeptResponse collegeUpdateCollegeDept(CollegeUpdateCollegeDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeUpdateCollegeDeptHeaders headers = new CollegeUpdateCollegeDeptHeaders();
        return this.collegeUpdateCollegeDeptWithOptions(request, headers, runtime);
    }

    public CollegeUpdateCollegeDeptResponse collegeUpdateCollegeDeptWithOptions(CollegeUpdateCollegeDeptRequest request, CollegeUpdateCollegeDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptName)) {
            query.put("deptName", request.deptName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sortFactor)) {
            query.put("sortFactor", request.sortFactor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.superId)) {
            query.put("superId", request.superId);
        }

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
        return TeaModel.toModel(this.doROARequest("CollegeUpdateCollegeDept", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/colleges/depts", "json", req, runtime), new CollegeUpdateCollegeDeptResponse());
    }

    public CollegeUpdateStudentDeptInfoResponse collegeUpdateStudentDeptInfo(CollegeUpdateStudentDeptInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeUpdateStudentDeptInfoHeaders headers = new CollegeUpdateStudentDeptInfoHeaders();
        return this.collegeUpdateStudentDeptInfoWithOptions(request, headers, runtime);
    }

    public CollegeUpdateStudentDeptInfoResponse collegeUpdateStudentDeptInfoWithOptions(CollegeUpdateStudentDeptInfoRequest request, CollegeUpdateStudentDeptInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            query.put("studentId", request.studentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentNumber)) {
            query.put("studentNumber", request.studentNumber);
        }

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
        return TeaModel.toModel(this.doROARequest("CollegeUpdateStudentDeptInfo", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/colleges/members/deptInfos", "json", req, runtime), new CollegeUpdateStudentDeptInfoResponse());
    }

    public CollegeUpdateStudentInfoResponse collegeUpdateStudentInfo(CollegeUpdateStudentInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeUpdateStudentInfoHeaders headers = new CollegeUpdateStudentInfoHeaders();
        return this.collegeUpdateStudentInfoWithOptions(request, headers, runtime);
    }

    public CollegeUpdateStudentInfoResponse collegeUpdateStudentInfoWithOptions(CollegeUpdateStudentInfoRequest request, CollegeUpdateStudentInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.empExtension)) {
            body.put("empExtension", request.empExtension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gender)) {
            body.put("gender", request.gender);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.identifyId)) {
            body.put("identifyId", request.identifyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startYear)) {
            body.put("startYear", request.startYear);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            body.put("studentId", request.studentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentName)) {
            body.put("studentName", request.studentName);
        }

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
        return TeaModel.toModel(this.doROARequest("CollegeUpdateStudentInfo", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/colleges/members/depts/students", "json", req, runtime), new CollegeUpdateStudentInfoResponse());
    }

    public CollegeUpdateStudentMoblieResponse collegeUpdateStudentMoblie(CollegeUpdateStudentMoblieRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeUpdateStudentMoblieHeaders headers = new CollegeUpdateStudentMoblieHeaders();
        return this.collegeUpdateStudentMoblieWithOptions(request, headers, runtime);
    }

    public CollegeUpdateStudentMoblieResponse collegeUpdateStudentMoblieWithOptions(CollegeUpdateStudentMoblieRequest request, CollegeUpdateStudentMoblieHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isForce)) {
            query.put("isForce", request.isForce);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.newMobile)) {
            query.put("newMobile", request.newMobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            query.put("studentId", request.studentId);
        }

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
        return TeaModel.toModel(this.doROARequest("CollegeUpdateStudentMoblie", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/colleges/members/students/mobiles", "json", req, runtime), new CollegeUpdateStudentMoblieResponse());
    }

    public CustomizeContactCreateResponse customizeContactCreate(CustomizeContactCreateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactCreateHeaders headers = new CustomizeContactCreateHeaders();
        return this.customizeContactCreateWithOptions(request, headers, runtime);
    }

    public CustomizeContactCreateResponse customizeContactCreateWithOptions(CustomizeContactCreateRequest request, CustomizeContactCreateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.managerIdList)) {
            body.put("managerIdList", request.managerIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            body.put("order", request.order);
        }

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
        return TeaModel.toModel(this.doROARequest("CustomizeContactCreate", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime), new CustomizeContactCreateResponse());
    }

    public CustomizeContactDeleteResponse customizeContactDelete(CustomizeContactDeleteRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactDeleteHeaders headers = new CustomizeContactDeleteHeaders();
        return this.customizeContactDeleteWithOptions(request, headers, runtime);
    }

    public CustomizeContactDeleteResponse customizeContactDeleteWithOptions(CustomizeContactDeleteRequest request, CustomizeContactDeleteHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

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
        return TeaModel.toModel(this.doROARequest("CustomizeContactDelete", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime), new CustomizeContactDeleteResponse());
    }

    public CustomizeContactDeptCreateResponse customizeContactDeptCreate(CustomizeContactDeptCreateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactDeptCreateHeaders headers = new CustomizeContactDeptCreateHeaders();
        return this.customizeContactDeptCreateWithOptions(request, headers, runtime);
    }

    public CustomizeContactDeptCreateResponse customizeContactDeptCreateWithOptions(CustomizeContactDeptCreateRequest request, CustomizeContactDeptCreateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerIdList)) {
            body.put("managerIdList", request.managerIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            body.put("order", request.order);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentDeptId)) {
            body.put("parentDeptId", request.parentDeptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.refId)) {
            body.put("refId", request.refId);
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
        return TeaModel.toModel(this.doROARequest("CustomizeContactDeptCreate", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime), new CustomizeContactDeptCreateResponse());
    }

    public CustomizeContactDeptDeleteResponse customizeContactDeptDelete(CustomizeContactDeptDeleteRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactDeptDeleteHeaders headers = new CustomizeContactDeptDeleteHeaders();
        return this.customizeContactDeptDeleteWithOptions(request, headers, runtime);
    }

    public CustomizeContactDeptDeleteResponse customizeContactDeptDeleteWithOptions(CustomizeContactDeptDeleteRequest request, CustomizeContactDeptDeleteHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

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
        return TeaModel.toModel(this.doROARequest("CustomizeContactDeptDelete", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime), new CustomizeContactDeptDeleteResponse());
    }

    public CustomizeContactDeptGroupCreateResponse customizeContactDeptGroupCreate(CustomizeContactDeptGroupCreateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactDeptGroupCreateHeaders headers = new CustomizeContactDeptGroupCreateHeaders();
        return this.customizeContactDeptGroupCreateWithOptions(request, headers, runtime);
    }

    public CustomizeContactDeptGroupCreateResponse customizeContactDeptGroupCreateWithOptions(CustomizeContactDeptGroupCreateRequest request, CustomizeContactDeptGroupCreateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

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
        return TeaModel.toModel(this.doROARequest("CustomizeContactDeptGroupCreate", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/departmentGroups", "json", req, runtime), new CustomizeContactDeptGroupCreateResponse());
    }

    public CustomizeContactDeptInfoResponse customizeContactDeptInfo(CustomizeContactDeptInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactDeptInfoHeaders headers = new CustomizeContactDeptInfoHeaders();
        return this.customizeContactDeptInfoWithOptions(request, headers, runtime);
    }

    public CustomizeContactDeptInfoResponse customizeContactDeptInfoWithOptions(CustomizeContactDeptInfoRequest request, CustomizeContactDeptInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

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
        return TeaModel.toModel(this.doROARequest("CustomizeContactDeptInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime), new CustomizeContactDeptInfoResponse());
    }

    public CustomizeContactDeptListResponse customizeContactDeptList(CustomizeContactDeptListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactDeptListHeaders headers = new CustomizeContactDeptListHeaders();
        return this.customizeContactDeptListWithOptions(request, headers, runtime);
    }

    public CustomizeContactDeptListResponse customizeContactDeptListWithOptions(CustomizeContactDeptListRequest request, CustomizeContactDeptListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

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
        return TeaModel.toModel(this.doROARequest("CustomizeContactDeptList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/subsidiaryDepartments", "json", req, runtime), new CustomizeContactDeptListResponse());
    }

    public CustomizeContactDeptUpdateResponse customizeContactDeptUpdate(CustomizeContactDeptUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactDeptUpdateHeaders headers = new CustomizeContactDeptUpdateHeaders();
        return this.customizeContactDeptUpdateWithOptions(request, headers, runtime);
    }

    public CustomizeContactDeptUpdateResponse customizeContactDeptUpdateWithOptions(CustomizeContactDeptUpdateRequest request, CustomizeContactDeptUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerIdList)) {
            body.put("managerIdList", request.managerIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            body.put("order", request.order);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentDeptId)) {
            body.put("parentDeptId", request.parentDeptId);
        }

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
        return TeaModel.toModel(this.doROARequest("CustomizeContactDeptUpdate", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime), new CustomizeContactDeptUpdateResponse());
    }

    public CustomizeContactEmpAddResponse customizeContactEmpAdd(CustomizeContactEmpAddRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactEmpAddHeaders headers = new CustomizeContactEmpAddHeaders();
        return this.customizeContactEmpAddWithOptions(request, headers, runtime);
    }

    public CustomizeContactEmpAddResponse customizeContactEmpAddWithOptions(CustomizeContactEmpAddRequest request, CustomizeContactEmpAddHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
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
        return TeaModel.toModel(this.doROARequest("CustomizeContactEmpAdd", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/users", "json", req, runtime), new CustomizeContactEmpAddResponse());
    }

    public CustomizeContactEmpDeleteResponse customizeContactEmpDelete(CustomizeContactEmpDeleteRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactEmpDeleteHeaders headers = new CustomizeContactEmpDeleteHeaders();
        return this.customizeContactEmpDeleteWithOptions(request, headers, runtime);
    }

    public CustomizeContactEmpDeleteResponse customizeContactEmpDeleteWithOptions(CustomizeContactEmpDeleteRequest request, CustomizeContactEmpDeleteHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
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
        return TeaModel.toModel(this.doROARequest("CustomizeContactEmpDelete", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/users/remove", "json", req, runtime), new CustomizeContactEmpDeleteResponse());
    }

    public CustomizeContactEmpListResponse customizeContactEmpList(CustomizeContactEmpListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactEmpListHeaders headers = new CustomizeContactEmpListHeaders();
        return this.customizeContactEmpListWithOptions(request, headers, runtime);
    }

    public CustomizeContactEmpListResponse customizeContactEmpListWithOptions(CustomizeContactEmpListRequest request, CustomizeContactEmpListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

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
        return TeaModel.toModel(this.doROARequest("CustomizeContactEmpList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/users", "json", req, runtime), new CustomizeContactEmpListResponse());
    }

    public CustomizeContactListResponse customizeContactList() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactListHeaders headers = new CustomizeContactListHeaders();
        return this.customizeContactListWithOptions(headers, runtime);
    }

    public CustomizeContactListResponse customizeContactListWithOptions(CustomizeContactListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("CustomizeContactList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime), new CustomizeContactListResponse());
    }

    public CustomizeContactUpdateResponse customizeContactUpdate(CustomizeContactUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactUpdateHeaders headers = new CustomizeContactUpdateHeaders();
        return this.customizeContactUpdateWithOptions(request, headers, runtime);
    }

    public CustomizeContactUpdateResponse customizeContactUpdateWithOptions(CustomizeContactUpdateRequest request, CustomizeContactUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerIdList)) {
            body.put("managerIdList", request.managerIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            body.put("order", request.order);
        }

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
        return TeaModel.toModel(this.doROARequest("CustomizeContactUpdate", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime), new CustomizeContactUpdateResponse());
    }

    public DigitalStoreContactInfoResponse digitalStoreContactInfo() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreContactInfoHeaders headers = new DigitalStoreContactInfoHeaders();
        return this.digitalStoreContactInfoWithOptions(headers, runtime);
    }

    public DigitalStoreContactInfoResponse digitalStoreContactInfoWithOptions(DigitalStoreContactInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("DigitalStoreContactInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/contactInfos", "json", req, runtime), new DigitalStoreContactInfoResponse());
    }

    public DigitalStoreGroupInfoResponse digitalStoreGroupInfo(DigitalStoreGroupInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreGroupInfoHeaders headers = new DigitalStoreGroupInfoHeaders();
        return this.digitalStoreGroupInfoWithOptions(request, headers, runtime);
    }

    public DigitalStoreGroupInfoResponse digitalStoreGroupInfoWithOptions(DigitalStoreGroupInfoRequest request, DigitalStoreGroupInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupId)) {
            query.put("groupId", request.groupId);
        }

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
        return TeaModel.toModel(this.doROARequest("DigitalStoreGroupInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/groupInfos", "json", req, runtime), new DigitalStoreGroupInfoResponse());
    }

    public DigitalStoreGroupsResponse digitalStoreGroups() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreGroupsHeaders headers = new DigitalStoreGroupsHeaders();
        return this.digitalStoreGroupsWithOptions(headers, runtime);
    }

    public DigitalStoreGroupsResponse digitalStoreGroupsWithOptions(DigitalStoreGroupsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("DigitalStoreGroups", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/groups", "json", req, runtime), new DigitalStoreGroupsResponse());
    }

    public DigitalStoreNodeInfoResponse digitalStoreNodeInfo(DigitalStoreNodeInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreNodeInfoHeaders headers = new DigitalStoreNodeInfoHeaders();
        return this.digitalStoreNodeInfoWithOptions(request, headers, runtime);
    }

    public DigitalStoreNodeInfoResponse digitalStoreNodeInfoWithOptions(DigitalStoreNodeInfoRequest request, DigitalStoreNodeInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nodeId)) {
            query.put("nodeId", request.nodeId);
        }

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
        return TeaModel.toModel(this.doROARequest("DigitalStoreNodeInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/nodeInfos", "json", req, runtime), new DigitalStoreNodeInfoResponse());
    }

    public DigitalStoreRightsInfoResponse digitalStoreRightsInfo() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreRightsInfoHeaders headers = new DigitalStoreRightsInfoHeaders();
        return this.digitalStoreRightsInfoWithOptions(headers, runtime);
    }

    public DigitalStoreRightsInfoResponse digitalStoreRightsInfoWithOptions(DigitalStoreRightsInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("DigitalStoreRightsInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/rightsInfos", "json", req, runtime), new DigitalStoreRightsInfoResponse());
    }

    public DigitalStoreRolesResponse digitalStoreRoles() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreRolesHeaders headers = new DigitalStoreRolesHeaders();
        return this.digitalStoreRolesWithOptions(headers, runtime);
    }

    public DigitalStoreRolesResponse digitalStoreRolesWithOptions(DigitalStoreRolesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("DigitalStoreRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/roles", "json", req, runtime), new DigitalStoreRolesResponse());
    }

    public DigitalStoreStoreInfoResponse digitalStoreStoreInfo(DigitalStoreStoreInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreStoreInfoHeaders headers = new DigitalStoreStoreInfoHeaders();
        return this.digitalStoreStoreInfoWithOptions(request, headers, runtime);
    }

    public DigitalStoreStoreInfoResponse digitalStoreStoreInfoWithOptions(DigitalStoreStoreInfoRequest request, DigitalStoreStoreInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.storeId)) {
            query.put("storeId", request.storeId);
        }

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
        return TeaModel.toModel(this.doROARequest("DigitalStoreStoreInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/storeInfos", "json", req, runtime), new DigitalStoreStoreInfoResponse());
    }

    public DigitalStoreSubNodesResponse digitalStoreSubNodes(DigitalStoreSubNodesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreSubNodesHeaders headers = new DigitalStoreSubNodesHeaders();
        return this.digitalStoreSubNodesWithOptions(request, headers, runtime);
    }

    public DigitalStoreSubNodesResponse digitalStoreSubNodesWithOptions(DigitalStoreSubNodesRequest request, DigitalStoreSubNodesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nodeId)) {
            query.put("nodeId", request.nodeId);
        }

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
        return TeaModel.toModel(this.doROARequest("DigitalStoreSubNodes", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/subsidiaryNodes", "json", req, runtime), new DigitalStoreSubNodesResponse());
    }

    public DigitalStoreUserInfoResponse digitalStoreUserInfo(DigitalStoreUserInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreUserInfoHeaders headers = new DigitalStoreUserInfoHeaders();
        return this.digitalStoreUserInfoWithOptions(request, headers, runtime);
    }

    public DigitalStoreUserInfoResponse digitalStoreUserInfoWithOptions(DigitalStoreUserInfoRequest request, DigitalStoreUserInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
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
        return TeaModel.toModel(this.doROARequest("DigitalStoreUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/userInfos", "json", req, runtime), new DigitalStoreUserInfoResponse());
    }

    public DigitalStoreUsersResponse digitalStoreUsers(DigitalStoreUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreUsersHeaders headers = new DigitalStoreUsersHeaders();
        return this.digitalStoreUsersWithOptions(request, headers, runtime);
    }

    public DigitalStoreUsersResponse digitalStoreUsersWithOptions(DigitalStoreUsersRequest request, DigitalStoreUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nodeId)) {
            query.put("nodeId", request.nodeId);
        }

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
        return TeaModel.toModel(this.doROARequest("DigitalStoreUsers", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/nodes/users", "json", req, runtime), new DigitalStoreUsersResponse());
    }

    public ExternalQueryExternalAppOrgsResponse externalQueryExternalAppOrgs(ExternalQueryExternalAppOrgsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExternalQueryExternalAppOrgsHeaders headers = new ExternalQueryExternalAppOrgsHeaders();
        return this.externalQueryExternalAppOrgsWithOptions(request, headers, runtime);
    }

    public ExternalQueryExternalAppOrgsResponse externalQueryExternalAppOrgsWithOptions(ExternalQueryExternalAppOrgsRequest request, ExternalQueryExternalAppOrgsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.externalType)) {
            query.put("externalType", request.externalType);
        }

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
        return TeaModel.toModel(this.doROARequest("ExternalQueryExternalAppOrgs", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/externals/apps/organizations", "json", req, runtime), new ExternalQueryExternalAppOrgsResponse());
    }

    public ExternalQueryExternalBelongMainOrgResponse externalQueryExternalBelongMainOrg(ExternalQueryExternalBelongMainOrgRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExternalQueryExternalBelongMainOrgHeaders headers = new ExternalQueryExternalBelongMainOrgHeaders();
        return this.externalQueryExternalBelongMainOrgWithOptions(request, headers, runtime);
    }

    public ExternalQueryExternalBelongMainOrgResponse externalQueryExternalBelongMainOrgWithOptions(ExternalQueryExternalBelongMainOrgRequest request, ExternalQueryExternalBelongMainOrgHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.externalType)) {
            query.put("externalType", request.externalType);
        }

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
        return TeaModel.toModel(this.doROARequest("ExternalQueryExternalBelongMainOrg", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/externals/attributions/masterOrganizations", "json", req, runtime), new ExternalQueryExternalBelongMainOrgResponse());
    }

    public ExternalQueryExternalOrgsResponse externalQueryExternalOrgs(ExternalQueryExternalOrgsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExternalQueryExternalOrgsHeaders headers = new ExternalQueryExternalOrgsHeaders();
        return this.externalQueryExternalOrgsWithOptions(request, headers, runtime);
    }

    public ExternalQueryExternalOrgsResponse externalQueryExternalOrgsWithOptions(ExternalQueryExternalOrgsRequest request, ExternalQueryExternalOrgsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.externalType)) {
            query.put("externalType", request.externalType);
        }

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
        return TeaModel.toModel(this.doROARequest("ExternalQueryExternalOrgs", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/externals/organizations", "json", req, runtime), new ExternalQueryExternalOrgsResponse());
    }

    public HospitalDataCheckResponse hospitalDataCheck(HospitalDataCheckRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HospitalDataCheckHeaders headers = new HospitalDataCheckHeaders();
        return this.hospitalDataCheckWithOptions(request, headers, runtime);
    }

    public HospitalDataCheckResponse hospitalDataCheckWithOptions(HospitalDataCheckRequest request, HospitalDataCheckHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.allDeptCount)) {
            body.put("allDeptCount", request.allDeptCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.allDeptUserCount)) {
            body.put("allDeptUserCount", request.allDeptUserCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.allGroupCount)) {
            body.put("allGroupCount", request.allGroupCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.allGroupUserCount)) {
            body.put("allGroupUserCount", request.allGroupUserCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptCount)) {
            body.put("deptCount", request.deptCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptUserCount)) {
            body.put("deptUserCount", request.deptUserCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupCount)) {
            body.put("groupCount", request.groupCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupUserCount)) {
            body.put("groupUserCount", request.groupUserCount);
        }

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
        return TeaModel.toModel(this.doROARequest("HospitalDataCheck", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/datas/check", "json", req, runtime), new HospitalDataCheckResponse());
    }

    public IndustryManufactureCommonEventResponse industryManufactureCommonEvent(IndustryManufactureCommonEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureCommonEventHeaders headers = new IndustryManufactureCommonEventHeaders();
        return this.industryManufactureCommonEventWithOptions(request, headers, runtime);
    }

    public IndustryManufactureCommonEventResponse industryManufactureCommonEventWithOptions(IndustryManufactureCommonEventRequest request, IndustryManufactureCommonEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizData)) {
            body.put("bizData", request.bizData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.eventType)) {
            body.put("eventType", request.eventType);
        }

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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureCommonEvent", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturing/bases/commons/events", "json", req, runtime), new IndustryManufactureCommonEventResponse());
    }

    public IndustryManufactureCostRecordListGetResponse industryManufactureCostRecordListGet(IndustryManufactureCostRecordListGetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureCostRecordListGetHeaders headers = new IndustryManufactureCostRecordListGetHeaders();
        return this.industryManufactureCostRecordListGetWithOptions(request, headers, runtime);
    }

    public IndustryManufactureCostRecordListGetResponse industryManufactureCostRecordListGetWithOptions(IndustryManufactureCostRecordListGetRequest request, IndustryManufactureCostRecordListGetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIds)) {
            body.put("appIds", request.appIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            body.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvOrgId)) {
            body.put("isvOrgId", request.isvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.materialNo)) {
            body.put("materialNo", request.materialNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            body.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgId)) {
            body.put("orgId", request.orgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productionTaskNo)) {
            body.put("productionTaskNo", request.productionTaskNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tokenGrantType)) {
            body.put("tokenGrantType", request.tokenGrantType);
        }

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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureCostRecordListGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/materialCostRecords/query", "json", req, runtime), new IndustryManufactureCostRecordListGetResponse());
    }

    public IndustryManufactureFeeListGetResponse industryManufactureFeeListGet(IndustryManufactureFeeListGetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureFeeListGetHeaders headers = new IndustryManufactureFeeListGetHeaders();
        return this.industryManufactureFeeListGetWithOptions(request, headers, runtime);
    }

    public IndustryManufactureFeeListGetResponse industryManufactureFeeListGetWithOptions(IndustryManufactureFeeListGetRequest request, IndustryManufactureFeeListGetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIds)) {
            body.put("appIds", request.appIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            body.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvOrgId)) {
            body.put("isvOrgId", request.isvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.materialNo)) {
            body.put("materialNo", request.materialNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgId)) {
            body.put("orgId", request.orgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productionTaskNo)) {
            body.put("productionTaskNo", request.productionTaskNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tokenGrantType)) {
            body.put("tokenGrantType", request.tokenGrantType);
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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureFeeListGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/fees/query", "json", req, runtime), new IndustryManufactureFeeListGetResponse());
    }

    public IndustryManufactureLabourCostResponse industryManufactureLabourCost(IndustryManufactureLabourCostRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureLabourCostHeaders headers = new IndustryManufactureLabourCostHeaders();
        return this.industryManufactureLabourCostWithOptions(request, headers, runtime);
    }

    public IndustryManufactureLabourCostResponse industryManufactureLabourCostWithOptions(IndustryManufactureLabourCostRequest request, IndustryManufactureLabourCostHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIds)) {
            body.put("appIds", request.appIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            body.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvOrgId)) {
            body.put("isvOrgId", request.isvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.materialNo)) {
            body.put("materialNo", request.materialNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgId)) {
            body.put("orgId", request.orgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processNo)) {
            body.put("processNo", request.processNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tokenGrantType)) {
            body.put("tokenGrantType", request.tokenGrantType);
        }

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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureLabourCost", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/labourCosts/query", "json", req, runtime), new IndustryManufactureLabourCostResponse());
    }

    public IndustryManufactureMaterialListResponse industryManufactureMaterialList(IndustryManufactureMaterialListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMaterialListHeaders headers = new IndustryManufactureMaterialListHeaders();
        return this.industryManufactureMaterialListWithOptions(request, headers, runtime);
    }

    public IndustryManufactureMaterialListResponse industryManufactureMaterialListWithOptions(IndustryManufactureMaterialListRequest request, IndustryManufactureMaterialListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIds)) {
            body.put("appIds", request.appIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.currentPage)) {
            body.put("currentPage", request.currentPage);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            body.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvOrgId)) {
            body.put("isvOrgId", request.isvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.materialNo)) {
            body.put("materialNo", request.materialNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgId)) {
            body.put("orgId", request.orgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tokenGrantType)) {
            body.put("tokenGrantType", request.tokenGrantType);
        }

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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureMaterialList", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/materials/query", "json", req, runtime), new IndustryManufactureMaterialListResponse());
    }

    public IndustryManufactureMesDispatchTaskResponse industryManufactureMesDispatchTask(IndustryManufactureMesDispatchTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMesDispatchTaskHeaders headers = new IndustryManufactureMesDispatchTaskHeaders();
        return this.industryManufactureMesDispatchTaskWithOptions(request, headers, runtime);
    }

    public IndustryManufactureMesDispatchTaskResponse industryManufactureMesDispatchTaskWithOptions(IndustryManufactureMesDispatchTaskRequest request, IndustryManufactureMesDispatchTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.baseDataName)) {
            body.put("baseDataName", request.baseDataName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.defectsAmount)) {
            body.put("defectsAmount", request.defectsAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dispatchStaffName)) {
            body.put("dispatchStaffName", request.dispatchStaffName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dispatchStaffNo)) {
            body.put("dispatchStaffNo", request.dispatchStaffNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fineAmount)) {
            body.put("fineAmount", request.fineAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.overdue)) {
            body.put("overdue", request.overdue);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.planQuantity)) {
            body.put("planQuantity", request.planQuantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.priority)) {
            body.put("priority", request.priority);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processName)) {
            body.put("processName", request.processName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processUuid)) {
            body.put("processUuid", request.processUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productCode)) {
            body.put("productCode", request.productCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productName)) {
            body.put("productName", request.productName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productSpecification)) {
            body.put("productSpecification", request.productSpecification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectCode)) {
            body.put("projectCode", request.projectCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectId)) {
            body.put("projectId", request.projectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectStatus)) {
            body.put("projectStatus", request.projectStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskOperators)) {
            body.put("taskOperators", request.taskOperators);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskPlanEndTime)) {
            body.put("taskPlanEndTime", request.taskPlanEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskPlanStartTime)) {
            body.put("taskPlanStartTime", request.taskPlanStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskStatus)) {
            body.put("taskStatus", request.taskStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskType)) {
            body.put("taskType", request.taskType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teamId)) {
            body.put("teamId", request.teamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
        }

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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureMesDispatchTask", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturings/dispatchTasks/manage", "json", req, runtime), new IndustryManufactureMesDispatchTaskResponse());
    }

    public IndustryManufactureMesMaterialResponse industryManufactureMesMaterial(IndustryManufactureMesMaterialRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMesMaterialHeaders headers = new IndustryManufactureMesMaterialHeaders();
        return this.industryManufactureMesMaterialWithOptions(request, headers, runtime);
    }

    public IndustryManufactureMesMaterialResponse industryManufactureMesMaterialWithOptions(IndustryManufactureMesMaterialRequest request, IndustryManufactureMesMaterialHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.baseDataName)) {
            body.put("baseDataName", request.baseDataName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.category)) {
            body.put("category", request.category);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extendData)) {
            body.put("extendData", request.extendData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productCode)) {
            body.put("productCode", request.productCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productName)) {
            body.put("productName", request.productName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productSpecification)) {
            body.put("productSpecification", request.productSpecification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.prop)) {
            body.put("prop", request.prop);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unit)) {
            body.put("unit", request.unit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
        }

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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureMesMaterial", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturings/materials/manage", "json", req, runtime), new IndustryManufactureMesMaterialResponse());
    }

    public IndustryManufactureMesOutPlanResponse industryManufactureMesOutPlan(IndustryManufactureMesOutPlanRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMesOutPlanHeaders headers = new IndustryManufactureMesOutPlanHeaders();
        return this.industryManufactureMesOutPlanWithOptions(request, headers, runtime);
    }

    public IndustryManufactureMesOutPlanResponse industryManufactureMesOutPlanWithOptions(IndustryManufactureMesOutPlanRequest request, IndustryManufactureMesOutPlanHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.approvalStatus)) {
            body.put("approvalStatus", request.approvalStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.approver)) {
            body.put("approver", request.approver);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.baseDataName)) {
            body.put("baseDataName", request.baseDataName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outSourceProjectCode)) {
            body.put("outSourceProjectCode", request.outSourceProjectCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outSourceTeamId)) {
            body.put("outSourceTeamId", request.outSourceTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.price)) {
            body.put("price", request.price);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processIdentificationCode)) {
            body.put("processIdentificationCode", request.processIdentificationCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processUuids)) {
            body.put("processUuids", request.processUuids);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productCode)) {
            body.put("productCode", request.productCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productName)) {
            body.put("productName", request.productName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productSpecification)) {
            body.put("productSpecification", request.productSpecification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectCode)) {
            body.put("projectCode", request.projectCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectId)) {
            body.put("projectId", request.projectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendPlanQuantity)) {
            body.put("sendPlanQuantity", request.sendPlanQuantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.supplierCode)) {
            body.put("supplierCode", request.supplierCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.supplierName)) {
            body.put("supplierName", request.supplierName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.totalWage)) {
            body.put("totalWage", request.totalWage);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
        }

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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureMesOutPlan", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturings/outPlans/manage", "json", req, runtime), new IndustryManufactureMesOutPlanResponse());
    }

    public IndustryManufactureMesOutputResponse industryManufactureMesOutput(IndustryManufactureMesOutputRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMesOutputHeaders headers = new IndustryManufactureMesOutputHeaders();
        return this.industryManufactureMesOutputWithOptions(request, headers, runtime);
    }

    public IndustryManufactureMesOutputResponse industryManufactureMesOutputWithOptions(IndustryManufactureMesOutputRequest request, IndustryManufactureMesOutputHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.approveStatus)) {
            body.put("approveStatus", request.approveStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.baseDataName)) {
            body.put("baseDataName", request.baseDataName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.defectsAmount)) {
            body.put("defectsAmount", request.defectsAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.defectsReason)) {
            body.put("defectsReason", request.defectsReason);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fineAmount)) {
            body.put("fineAmount", request.fineAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hasQualityTest)) {
            body.put("hasQualityTest", request.hasQualityTest);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.overdue)) {
            body.put("overdue", request.overdue);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.planQuantity)) {
            body.put("planQuantity", request.planQuantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.priority)) {
            body.put("priority", request.priority);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processName)) {
            body.put("processName", request.processName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processUuid)) {
            body.put("processUuid", request.processUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productCode)) {
            body.put("productCode", request.productCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productName)) {
            body.put("productName", request.productName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productSpecification)) {
            body.put("productSpecification", request.productSpecification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectCode)) {
            body.put("projectCode", request.projectCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectId)) {
            body.put("projectId", request.projectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectStatus)) {
            body.put("projectStatus", request.projectStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.qualityTestStatus)) {
            body.put("qualityTestStatus", request.qualityTestStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskPlanEndTime)) {
            body.put("taskPlanEndTime", request.taskPlanEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskPlanStartTime)) {
            body.put("taskPlanStartTime", request.taskPlanStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskStatus)) {
            body.put("taskStatus", request.taskStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskType)) {
            body.put("taskType", request.taskType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskUuid)) {
            body.put("taskUuid", request.taskUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teamId)) {
            body.put("teamId", request.teamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userName)) {
            body.put("userName", request.userName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
        }

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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureMesOutput", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturings/outputs/manage", "json", req, runtime), new IndustryManufactureMesOutputResponse());
    }

    public IndustryManufactureMesProcessResponse industryManufactureMesProcess(IndustryManufactureMesProcessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMesProcessHeaders headers = new IndustryManufactureMesProcessHeaders();
        return this.industryManufactureMesProcessWithOptions(request, headers, runtime);
    }

    public IndustryManufactureMesProcessResponse industryManufactureMesProcessWithOptions(IndustryManufactureMesProcessRequest request, IndustryManufactureMesProcessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.baseDataName)) {
            body.put("baseDataName", request.baseDataName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extendData)) {
            body.put("extendData", request.extendData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.needDispatch)) {
            body.put("needDispatch", request.needDispatch);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.needQualityTest)) {
            body.put("needQualityTest", request.needQualityTest);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.no)) {
            body.put("no", request.no);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.price)) {
            body.put("price", request.price);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.prop)) {
            body.put("prop", request.prop);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sop)) {
            body.put("sop", request.sop);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
        }

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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureMesProcess", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturings/processes/manage", "json", req, runtime), new IndustryManufactureMesProcessResponse());
    }

    public IndustryManufactureMesProductionPlanResponse industryManufactureMesProductionPlan(IndustryManufactureMesProductionPlanRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMesProductionPlanHeaders headers = new IndustryManufactureMesProductionPlanHeaders();
        return this.industryManufactureMesProductionPlanWithOptions(request, headers, runtime);
    }

    public IndustryManufactureMesProductionPlanResponse industryManufactureMesProductionPlanWithOptions(IndustryManufactureMesProductionPlanRequest request, IndustryManufactureMesProductionPlanHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.actualEndTime)) {
            body.put("actualEndTime", request.actualEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.actualStartTime)) {
            body.put("actualStartTime", request.actualStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.baseDataName)) {
            body.put("baseDataName", request.baseDataName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bomUuid)) {
            body.put("bomUuid", request.bomUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.events)) {
            body.put("events", request.events);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extendData)) {
            body.put("extendData", request.extendData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.no)) {
            body.put("no", request.no);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.overdue)) {
            body.put("overdue", request.overdue);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.planEndTime)) {
            body.put("planEndTime", request.planEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.planQuantity)) {
            body.put("planQuantity", request.planQuantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.planStartTime)) {
            body.put("planStartTime", request.planStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processUuids)) {
            body.put("processUuids", request.processUuids);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productCode)) {
            body.put("productCode", request.productCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productName)) {
            body.put("productName", request.productName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productSpecification)) {
            body.put("productSpecification", request.productSpecification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.qualifiedQuantity)) {
            body.put("qualifiedQuantity", request.qualifiedQuantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sellOrderNo)) {
            body.put("sellOrderNo", request.sellOrderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teamList)) {
            body.put("teamList", request.teamList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unit)) {
            body.put("unit", request.unit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
        }

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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureMesProductionPlan", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturings/productionPlans/manage", "json", req, runtime), new IndustryManufactureMesProductionPlanResponse());
    }

    public IndustryManufactureMesSubCooperationTeamResponse industryManufactureMesSubCooperationTeam(IndustryManufactureMesSubCooperationTeamRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMesSubCooperationTeamHeaders headers = new IndustryManufactureMesSubCooperationTeamHeaders();
        return this.industryManufactureMesSubCooperationTeamWithOptions(request, headers, runtime);
    }

    public IndustryManufactureMesSubCooperationTeamResponse industryManufactureMesSubCooperationTeamWithOptions(IndustryManufactureMesSubCooperationTeamRequest request, IndustryManufactureMesSubCooperationTeamHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.baseDataName)) {
            body.put("baseDataName", request.baseDataName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.events)) {
            body.put("events", request.events);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extendData)) {
            body.put("extendData", request.extendData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupPlugins)) {
            body.put("groupPlugins", request.groupPlugins);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupType)) {
            body.put("groupType", request.groupType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaders)) {
            body.put("leaders", request.leaders);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outCorpId)) {
            body.put("outCorpId", request.outCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processIds)) {
            body.put("processIds", request.processIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
        }

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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureMesSubCooperationTeam", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturings/outTeams/manage", "json", req, runtime), new IndustryManufactureMesSubCooperationTeamResponse());
    }

    public IndustryManufactureMesTeamMgmtResponse industryManufactureMesTeamMgmt(IndustryManufactureMesTeamMgmtRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMesTeamMgmtHeaders headers = new IndustryManufactureMesTeamMgmtHeaders();
        return this.industryManufactureMesTeamMgmtWithOptions(request, headers, runtime);
    }

    public IndustryManufactureMesTeamMgmtResponse industryManufactureMesTeamMgmtWithOptions(IndustryManufactureMesTeamMgmtRequest request, IndustryManufactureMesTeamMgmtHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.baseDataName)) {
            body.put("baseDataName", request.baseDataName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.events)) {
            body.put("events", request.events);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extendData)) {
            body.put("extendData", request.extendData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupConfig)) {
            body.put("groupConfig", request.groupConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupPlugins)) {
            body.put("groupPlugins", request.groupPlugins);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupType)) {
            body.put("groupType", request.groupType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            body.put("id", request.id);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaders)) {
            body.put("leaders", request.leaders);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processIds)) {
            body.put("processIds", request.processIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagKey)) {
            body.put("tagKey", request.tagKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagValues)) {
            body.put("tagValues", request.tagValues);
        }

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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureMesTeamMgmt", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturing/base/data/team", "json", req, runtime), new IndustryManufactureMesTeamMgmtResponse());
    }

    public IndustryMmanufactureMaterialCostGetResponse industryMmanufactureMaterialCostGet(IndustryMmanufactureMaterialCostGetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryMmanufactureMaterialCostGetHeaders headers = new IndustryMmanufactureMaterialCostGetHeaders();
        return this.industryMmanufactureMaterialCostGetWithOptions(request, headers, runtime);
    }

    public IndustryMmanufactureMaterialCostGetResponse industryMmanufactureMaterialCostGetWithOptions(IndustryMmanufactureMaterialCostGetRequest request, IndustryMmanufactureMaterialCostGetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIds)) {
            body.put("appIds", request.appIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            body.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvOrgId)) {
            body.put("isvOrgId", request.isvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.materialNo)) {
            body.put("materialNo", request.materialNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgId)) {
            body.put("orgId", request.orgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tokenGrantType)) {
            body.put("tokenGrantType", request.tokenGrantType);
        }

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
        return TeaModel.toModel(this.doROARequest("IndustryMmanufactureMaterialCostGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/base/materialCosts/query", "json", req, runtime), new IndustryMmanufactureMaterialCostGetResponse());
    }

    public PushDingMessageResponse pushDingMessage(PushDingMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PushDingMessageHeaders headers = new PushDingMessageHeaders();
        return this.pushDingMessageWithOptions(request, headers, runtime);
    }

    public PushDingMessageResponse pushDingMessageWithOptions(PushDingMessageRequest request, PushDingMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.messageType)) {
            body.put("messageType", request.messageType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.messageUrl)) {
            body.put("messageUrl", request.messageUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pictureUrl)) {
            body.put("pictureUrl", request.pictureUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.singleTitle)) {
            body.put("singleTitle", request.singleTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.singleUrl)) {
            body.put("singleUrl", request.singleUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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
        return TeaModel.toModel(this.doROARequest("PushDingMessage", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/works/notice", "json", req, runtime), new PushDingMessageResponse());
    }

    public QueryAllDepartmentResponse queryAllDepartment(QueryAllDepartmentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllDepartmentHeaders headers = new QueryAllDepartmentHeaders();
        return this.queryAllDepartmentWithOptions(request, headers, runtime);
    }

    public QueryAllDepartmentResponse queryAllDepartmentWithOptions(QueryAllDepartmentRequest request, QueryAllDepartmentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryAllDepartment", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments", "json", req, runtime), new QueryAllDepartmentResponse());
    }

    public QueryAllDoctorsResponse queryAllDoctors(QueryAllDoctorsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllDoctorsHeaders headers = new QueryAllDoctorsHeaders();
        return this.queryAllDoctorsWithOptions(request, headers, runtime);
    }

    public QueryAllDoctorsResponse queryAllDoctorsWithOptions(QueryAllDoctorsRequest request, QueryAllDoctorsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.monthMark)) {
            query.put("monthMark", request.monthMark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNum)) {
            query.put("pageNum", request.pageNum);
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
        return TeaModel.toModel(this.doROARequest("QueryAllDoctors", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/doctors", "json", req, runtime), new QueryAllDoctorsResponse());
    }

    public QueryAllGroupResponse queryAllGroup(QueryAllGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllGroupHeaders headers = new QueryAllGroupHeaders();
        return this.queryAllGroupWithOptions(request, headers, runtime);
    }

    public QueryAllGroupResponse queryAllGroupWithOptions(QueryAllGroupRequest request, QueryAllGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryAllGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups", "json", req, runtime), new QueryAllGroupResponse());
    }

    public QueryAllGroupsInDeptResponse queryAllGroupsInDept(String deptId, QueryAllGroupsInDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllGroupsInDeptHeaders headers = new QueryAllGroupsInDeptHeaders();
        return this.queryAllGroupsInDeptWithOptions(deptId, request, headers, runtime);
    }

    public QueryAllGroupsInDeptResponse queryAllGroupsInDeptWithOptions(String deptId, QueryAllGroupsInDeptRequest request, QueryAllGroupsInDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        deptId = com.aliyun.openapiutil.Client.getEncodeParam(deptId);
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
        return TeaModel.toModel(this.doROARequest("QueryAllGroupsInDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/groups", "json", req, runtime), new QueryAllGroupsInDeptResponse());
    }

    public QueryAllMemberByDeptResponse queryAllMemberByDept(String deptId, QueryAllMemberByDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllMemberByDeptHeaders headers = new QueryAllMemberByDeptHeaders();
        return this.queryAllMemberByDeptWithOptions(deptId, request, headers, runtime);
    }

    public QueryAllMemberByDeptResponse queryAllMemberByDeptWithOptions(String deptId, QueryAllMemberByDeptRequest request, QueryAllMemberByDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        deptId = com.aliyun.openapiutil.Client.getEncodeParam(deptId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.monthMark)) {
            query.put("monthMark", request.monthMark);
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
        return TeaModel.toModel(this.doROARequest("QueryAllMemberByDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/members", "json", req, runtime), new QueryAllMemberByDeptResponse());
    }

    public QueryAllMemberByGroupResponse queryAllMemberByGroup(String groupId, QueryAllMemberByGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllMemberByGroupHeaders headers = new QueryAllMemberByGroupHeaders();
        return this.queryAllMemberByGroupWithOptions(groupId, request, headers, runtime);
    }

    public QueryAllMemberByGroupResponse queryAllMemberByGroupWithOptions(String groupId, QueryAllMemberByGroupRequest request, QueryAllMemberByGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        groupId = com.aliyun.openapiutil.Client.getEncodeParam(groupId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.monthMark)) {
            query.put("monthMark", request.monthMark);
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
        return TeaModel.toModel(this.doROARequest("QueryAllMemberByGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId + "/members", "json", req, runtime), new QueryAllMemberByGroupResponse());
    }

    public QueryBizOptLogResponse queryBizOptLog(QueryBizOptLogRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryBizOptLogHeaders headers = new QueryBizOptLogHeaders();
        return this.queryBizOptLogWithOptions(request, headers, runtime);
    }

    public QueryBizOptLogResponse queryBizOptLogWithOptions(QueryBizOptLogRequest request, QueryBizOptLogHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryBizOptLog", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/bizOptLogs", "json", req, runtime), new QueryBizOptLogResponse());
    }

    public QueryDepartmentExtendInfoResponse queryDepartmentExtendInfo(QueryDepartmentExtendInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDepartmentExtendInfoHeaders headers = new QueryDepartmentExtendInfoHeaders();
        return this.queryDepartmentExtendInfoWithOptions(request, headers, runtime);
    }

    public QueryDepartmentExtendInfoResponse queryDepartmentExtendInfoWithOptions(QueryDepartmentExtendInfoRequest request, QueryDepartmentExtendInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptCode)) {
            query.put("deptCode", request.deptCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.propCode)) {
            query.put("propCode", request.propCode);
        }

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
        return TeaModel.toModel(this.doROARequest("QueryDepartmentExtendInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/extensions/infos", "json", req, runtime), new QueryDepartmentExtendInfoResponse());
    }

    public QueryDepartmentInfoResponse queryDepartmentInfo(String deptId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDepartmentInfoHeaders headers = new QueryDepartmentInfoHeaders();
        return this.queryDepartmentInfoWithOptions(deptId, headers, runtime);
    }

    public QueryDepartmentInfoResponse queryDepartmentInfoWithOptions(String deptId, QueryDepartmentInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        deptId = com.aliyun.openapiutil.Client.getEncodeParam(deptId);
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
        return TeaModel.toModel(this.doROARequest("QueryDepartmentInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "", "json", req, runtime), new QueryDepartmentInfoResponse());
    }

    public QueryDoctorDetailsByJobNumberResponse queryDoctorDetailsByJobNumber(String jobNumber, QueryDoctorDetailsByJobNumberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDoctorDetailsByJobNumberHeaders headers = new QueryDoctorDetailsByJobNumberHeaders();
        return this.queryDoctorDetailsByJobNumberWithOptions(jobNumber, request, headers, runtime);
    }

    public QueryDoctorDetailsByJobNumberResponse queryDoctorDetailsByJobNumberWithOptions(String jobNumber, QueryDoctorDetailsByJobNumberRequest request, QueryDoctorDetailsByJobNumberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        jobNumber = com.aliyun.openapiutil.Client.getEncodeParam(jobNumber);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.monthMark)) {
            query.put("monthMark", request.monthMark);
        }

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
        return TeaModel.toModel(this.doROARequest("QueryDoctorDetailsByJobNumber", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/doctors/" + jobNumber + "", "json", req, runtime), new QueryDoctorDetailsByJobNumberResponse());
    }

    public QueryGroupInfoResponse queryGroupInfo(String groupId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryGroupInfoHeaders headers = new QueryGroupInfoHeaders();
        return this.queryGroupInfoWithOptions(groupId, headers, runtime);
    }

    public QueryGroupInfoResponse queryGroupInfoWithOptions(String groupId, QueryGroupInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        groupId = com.aliyun.openapiutil.Client.getEncodeParam(groupId);
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
        return TeaModel.toModel(this.doROARequest("QueryGroupInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId + "", "json", req, runtime), new QueryGroupInfoResponse());
    }

    public QueryHospitalDistrictInfoResponse queryHospitalDistrictInfo(QueryHospitalDistrictInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryHospitalDistrictInfoHeaders headers = new QueryHospitalDistrictInfoHeaders();
        return this.queryHospitalDistrictInfoWithOptions(request, headers, runtime);
    }

    public QueryHospitalDistrictInfoResponse queryHospitalDistrictInfoWithOptions(QueryHospitalDistrictInfoRequest request, QueryHospitalDistrictInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryHospitalDistrictInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/districts", "json", req, runtime), new QueryHospitalDistrictInfoResponse());
    }

    public QueryHospitalRoleUserInfoResponse queryHospitalRoleUserInfo(QueryHospitalRoleUserInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryHospitalRoleUserInfoHeaders headers = new QueryHospitalRoleUserInfoHeaders();
        return this.queryHospitalRoleUserInfoWithOptions(request, headers, runtime);
    }

    public QueryHospitalRoleUserInfoResponse queryHospitalRoleUserInfoWithOptions(QueryHospitalRoleUserInfoRequest request, QueryHospitalRoleUserInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryHospitalRoleUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/roles/userInfos", "json", req, runtime), new QueryHospitalRoleUserInfoResponse());
    }

    public QueryHospitalRolesResponse queryHospitalRoles() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryHospitalRolesHeaders headers = new QueryHospitalRolesHeaders();
        return this.queryHospitalRolesWithOptions(headers, runtime);
    }

    public QueryHospitalRolesResponse queryHospitalRolesWithOptions(QueryHospitalRolesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryHospitalRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/roles", "json", req, runtime), new QueryHospitalRolesResponse());
    }

    public QueryJobCodeDictionaryResponse queryJobCodeDictionary() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryJobCodeDictionaryHeaders headers = new QueryJobCodeDictionaryHeaders();
        return this.queryJobCodeDictionaryWithOptions(headers, runtime);
    }

    public QueryJobCodeDictionaryResponse queryJobCodeDictionaryWithOptions(QueryJobCodeDictionaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryJobCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/jobCodes", "json", req, runtime), new QueryJobCodeDictionaryResponse());
    }

    public QueryJobStatusCodeDictionaryResponse queryJobStatusCodeDictionary() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryJobStatusCodeDictionaryHeaders headers = new QueryJobStatusCodeDictionaryHeaders();
        return this.queryJobStatusCodeDictionaryWithOptions(headers, runtime);
    }

    public QueryJobStatusCodeDictionaryResponse queryJobStatusCodeDictionaryWithOptions(QueryJobStatusCodeDictionaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryJobStatusCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/jobStatusCodes", "json", req, runtime), new QueryJobStatusCodeDictionaryResponse());
    }

    public QueryMedicalEventsResponse queryMedicalEvents() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMedicalEventsHeaders headers = new QueryMedicalEventsHeaders();
        return this.queryMedicalEventsWithOptions(headers, runtime);
    }

    public QueryMedicalEventsResponse queryMedicalEventsWithOptions(QueryMedicalEventsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryMedicalEvents", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/events", "json", req, runtime), new QueryMedicalEventsResponse());
    }

    public QueryUserCredentialsResponse queryUserCredentials(QueryUserCredentialsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserCredentialsHeaders headers = new QueryUserCredentialsHeaders();
        return this.queryUserCredentialsWithOptions(request, headers, runtime);
    }

    public QueryUserCredentialsResponse queryUserCredentialsWithOptions(QueryUserCredentialsRequest request, QueryUserCredentialsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryUserCredentials", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/credentials/query", "json", req, runtime), new QueryUserCredentialsResponse());
    }

    public QueryUserExtInfoResponse queryUserExtInfo(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserExtInfoHeaders headers = new QueryUserExtInfoHeaders();
        return this.queryUserExtInfoWithOptions(userId, headers, runtime);
    }

    public QueryUserExtInfoResponse queryUserExtInfoWithOptions(String userId, QueryUserExtInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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
        return TeaModel.toModel(this.doROARequest("QueryUserExtInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "json", req, runtime), new QueryUserExtInfoResponse());
    }

    public QueryUserExtendValuesResponse queryUserExtendValues(QueryUserExtendValuesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserExtendValuesHeaders headers = new QueryUserExtendValuesHeaders();
        return this.queryUserExtendValuesWithOptions(request, headers, runtime);
    }

    public QueryUserExtendValuesResponse queryUserExtendValuesWithOptions(QueryUserExtendValuesRequest request, QueryUserExtendValuesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userExtendKey)) {
            body.put("userExtendKey", request.userExtendKey);
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
        return TeaModel.toModel(this.doROARequest("QueryUserExtendValues", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/extends/query", "json", req, runtime), new QueryUserExtendValuesResponse());
    }

    public QueryUserInfoResponse queryUserInfo(String userId, QueryUserInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserInfoHeaders headers = new QueryUserInfoHeaders();
        return this.queryUserInfoWithOptions(userId, request, headers, runtime);
    }

    public QueryUserInfoResponse queryUserInfoWithOptions(String userId, QueryUserInfoRequest request, QueryUserInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.monthMark)) {
            query.put("monthMark", request.monthMark);
        }

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
        return TeaModel.toModel(this.doROARequest("QueryUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "", "json", req, runtime), new QueryUserInfoResponse());
    }

    public QueryUserProbCodeDictionaryResponse queryUserProbCodeDictionary() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserProbCodeDictionaryHeaders headers = new QueryUserProbCodeDictionaryHeaders();
        return this.queryUserProbCodeDictionaryWithOptions(headers, runtime);
    }

    public QueryUserProbCodeDictionaryResponse queryUserProbCodeDictionaryWithOptions(QueryUserProbCodeDictionaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryUserProbCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/userProbCodes", "json", req, runtime), new QueryUserProbCodeDictionaryResponse());
    }

    public QueryUserRolesResponse queryUserRoles(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserRolesHeaders headers = new QueryUserRolesHeaders();
        return this.queryUserRolesWithOptions(userId, headers, runtime);
    }

    public QueryUserRolesResponse queryUserRolesWithOptions(String userId, QueryUserRolesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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
        return TeaModel.toModel(this.doROARequest("QueryUserRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/roles", "json", req, runtime), new QueryUserRolesResponse());
    }

    public SaveUserExtendValuesResponse saveUserExtendValues(String userId, SaveUserExtendValuesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveUserExtendValuesHeaders headers = new SaveUserExtendValuesHeaders();
        return this.saveUserExtendValuesWithOptions(userId, request, headers, runtime);
    }

    public SaveUserExtendValuesResponse saveUserExtendValuesWithOptions(String userId, SaveUserExtendValuesRequest request, SaveUserExtendValuesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userDisplayName)) {
            query.put("userDisplayName", request.userDisplayName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userExtendKey)) {
            query.put("userExtendKey", request.userExtendKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userExtendValue)) {
            query.put("userExtendValue", request.userExtendValue);
        }

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
        return TeaModel.toModel(this.doROARequest("SaveUserExtendValues", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/" + userId + "/extends", "json", req, runtime), new SaveUserExtendValuesResponse());
    }

    public UpdateUserExtendInfoResponse updateUserExtendInfo(String userId, UpdateUserExtendInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateUserExtendInfoHeaders headers = new UpdateUserExtendInfoHeaders();
        return this.updateUserExtendInfoWithOptions(userId, request, headers, runtime);
    }

    public UpdateUserExtendInfoResponse updateUserExtendInfoWithOptions(String userId, UpdateUserExtendInfoRequest request, UpdateUserExtendInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.comments)) {
            body.put("comments", request.comments);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jobCode)) {
            body.put("jobCode", request.jobCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jobStatusCode)) {
            body.put("jobStatusCode", request.jobStatusCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userProbCode)) {
            body.put("userProbCode", request.userProbCode);
        }

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
        return TeaModel.toModel(this.doROARequest("UpdateUserExtendInfo", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "none", req, runtime), new UpdateUserExtendInfoResponse());
    }
}
