// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkindustry_1_0.models.*;
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


    public CustomizeContactCreateResponse customizeContactCreate(CustomizeContactCreateRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CustomizeContactCreateHeaders headers = new CustomizeContactCreateHeaders();
        return this.customizeContactCreateWithOptions(request, headers, runtime);
    }

    public CustomizeContactCreateResponse customizeContactCreateWithOptions(CustomizeContactCreateRequest request, CustomizeContactCreateHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CustomizeContactCreate", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime), new CustomizeContactCreateResponse());
    }

    public CustomizeContactDeleteResponse customizeContactDelete(CustomizeContactDeleteRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CustomizeContactDeleteHeaders headers = new CustomizeContactDeleteHeaders();
        return this.customizeContactDeleteWithOptions(request, headers, runtime);
    }

    public CustomizeContactDeleteResponse customizeContactDeleteWithOptions(CustomizeContactDeleteRequest request, CustomizeContactDeleteHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("CustomizeContactDelete", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime), new CustomizeContactDeleteResponse());
    }

    public CustomizeContactDeptCreateResponse customizeContactDeptCreate(CustomizeContactDeptCreateRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CustomizeContactDeptCreateHeaders headers = new CustomizeContactDeptCreateHeaders();
        return this.customizeContactDeptCreateWithOptions(request, headers, runtime);
    }

    public CustomizeContactDeptCreateResponse customizeContactDeptCreateWithOptions(CustomizeContactDeptCreateRequest request, CustomizeContactDeptCreateHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CustomizeContactDeptCreate", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime), new CustomizeContactDeptCreateResponse());
    }

    public CustomizeContactDeptDeleteResponse customizeContactDeptDelete(CustomizeContactDeptDeleteRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CustomizeContactDeptDeleteHeaders headers = new CustomizeContactDeptDeleteHeaders();
        return this.customizeContactDeptDeleteWithOptions(request, headers, runtime);
    }

    public CustomizeContactDeptDeleteResponse customizeContactDeptDeleteWithOptions(CustomizeContactDeptDeleteRequest request, CustomizeContactDeptDeleteHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("CustomizeContactDeptDelete", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime), new CustomizeContactDeptDeleteResponse());
    }

    public CustomizeContactDeptInfoResponse customizeContactDeptInfo(CustomizeContactDeptInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CustomizeContactDeptInfoHeaders headers = new CustomizeContactDeptInfoHeaders();
        return this.customizeContactDeptInfoWithOptions(request, headers, runtime);
    }

    public CustomizeContactDeptInfoResponse customizeContactDeptInfoWithOptions(CustomizeContactDeptInfoRequest request, CustomizeContactDeptInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("CustomizeContactDeptInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime), new CustomizeContactDeptInfoResponse());
    }

    public CustomizeContactDeptListResponse customizeContactDeptList(CustomizeContactDeptListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CustomizeContactDeptListHeaders headers = new CustomizeContactDeptListHeaders();
        return this.customizeContactDeptListWithOptions(request, headers, runtime);
    }

    public CustomizeContactDeptListResponse customizeContactDeptListWithOptions(CustomizeContactDeptListRequest request, CustomizeContactDeptListHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("CustomizeContactDeptList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/subsidiaryDepartments", "json", req, runtime), new CustomizeContactDeptListResponse());
    }

    public CustomizeContactDeptUpdateResponse customizeContactDeptUpdate(CustomizeContactDeptUpdateRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CustomizeContactDeptUpdateHeaders headers = new CustomizeContactDeptUpdateHeaders();
        return this.customizeContactDeptUpdateWithOptions(request, headers, runtime);
    }

    public CustomizeContactDeptUpdateResponse customizeContactDeptUpdateWithOptions(CustomizeContactDeptUpdateRequest request, CustomizeContactDeptUpdateHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CustomizeContactDeptUpdate", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime), new CustomizeContactDeptUpdateResponse());
    }

    public CustomizeContactEmpAddResponse customizeContactEmpAdd(CustomizeContactEmpAddRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CustomizeContactEmpAddHeaders headers = new CustomizeContactEmpAddHeaders();
        return this.customizeContactEmpAddWithOptions(request, headers, runtime);
    }

    public CustomizeContactEmpAddResponse customizeContactEmpAddWithOptions(CustomizeContactEmpAddRequest request, CustomizeContactEmpAddHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CustomizeContactEmpAdd", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/users", "json", req, runtime), new CustomizeContactEmpAddResponse());
    }

    public CustomizeContactEmpDeleteResponse customizeContactEmpDelete(CustomizeContactEmpDeleteRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CustomizeContactEmpDeleteHeaders headers = new CustomizeContactEmpDeleteHeaders();
        return this.customizeContactEmpDeleteWithOptions(request, headers, runtime);
    }

    public CustomizeContactEmpDeleteResponse customizeContactEmpDeleteWithOptions(CustomizeContactEmpDeleteRequest request, CustomizeContactEmpDeleteHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CustomizeContactEmpDelete", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/users/remove", "json", req, runtime), new CustomizeContactEmpDeleteResponse());
    }

    public CustomizeContactEmpListResponse customizeContactEmpList(CustomizeContactEmpListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CustomizeContactEmpListHeaders headers = new CustomizeContactEmpListHeaders();
        return this.customizeContactEmpListWithOptions(request, headers, runtime);
    }

    public CustomizeContactEmpListResponse customizeContactEmpListWithOptions(CustomizeContactEmpListRequest request, CustomizeContactEmpListHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("CustomizeContactEmpList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/users", "json", req, runtime), new CustomizeContactEmpListResponse());
    }

    public CustomizeContactListResponse customizeContactList() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CustomizeContactListHeaders headers = new CustomizeContactListHeaders();
        return this.customizeContactListWithOptions(headers, runtime);
    }

    public CustomizeContactListResponse customizeContactListWithOptions(CustomizeContactListHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("CustomizeContactList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime), new CustomizeContactListResponse());
    }

    public CustomizeContactUpdateResponse customizeContactUpdate(CustomizeContactUpdateRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CustomizeContactUpdateHeaders headers = new CustomizeContactUpdateHeaders();
        return this.customizeContactUpdateWithOptions(request, headers, runtime);
    }

    public CustomizeContactUpdateResponse customizeContactUpdateWithOptions(CustomizeContactUpdateRequest request, CustomizeContactUpdateHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CustomizeContactUpdate", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime), new CustomizeContactUpdateResponse());
    }

    public DigitalStoreContactInfoResponse digitalStoreContactInfo() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DigitalStoreContactInfoHeaders headers = new DigitalStoreContactInfoHeaders();
        return this.digitalStoreContactInfoWithOptions(headers, runtime);
    }

    public DigitalStoreContactInfoResponse digitalStoreContactInfoWithOptions(DigitalStoreContactInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("DigitalStoreContactInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/contactInfos", "json", req, runtime), new DigitalStoreContactInfoResponse());
    }

    public DigitalStoreGroupInfoResponse digitalStoreGroupInfo(DigitalStoreGroupInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DigitalStoreGroupInfoHeaders headers = new DigitalStoreGroupInfoHeaders();
        return this.digitalStoreGroupInfoWithOptions(request, headers, runtime);
    }

    public DigitalStoreGroupInfoResponse digitalStoreGroupInfoWithOptions(DigitalStoreGroupInfoRequest request, DigitalStoreGroupInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DigitalStoreGroupInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/groupInfos", "json", req, runtime), new DigitalStoreGroupInfoResponse());
    }

    public DigitalStoreGroupsResponse digitalStoreGroups() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DigitalStoreGroupsHeaders headers = new DigitalStoreGroupsHeaders();
        return this.digitalStoreGroupsWithOptions(headers, runtime);
    }

    public DigitalStoreGroupsResponse digitalStoreGroupsWithOptions(DigitalStoreGroupsHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("DigitalStoreGroups", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/groups", "json", req, runtime), new DigitalStoreGroupsResponse());
    }

    public DigitalStoreNodeInfoResponse digitalStoreNodeInfo(DigitalStoreNodeInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DigitalStoreNodeInfoHeaders headers = new DigitalStoreNodeInfoHeaders();
        return this.digitalStoreNodeInfoWithOptions(request, headers, runtime);
    }

    public DigitalStoreNodeInfoResponse digitalStoreNodeInfoWithOptions(DigitalStoreNodeInfoRequest request, DigitalStoreNodeInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DigitalStoreNodeInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/nodeInfos", "json", req, runtime), new DigitalStoreNodeInfoResponse());
    }

    public DigitalStoreRolesResponse digitalStoreRoles() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DigitalStoreRolesHeaders headers = new DigitalStoreRolesHeaders();
        return this.digitalStoreRolesWithOptions(headers, runtime);
    }

    public DigitalStoreRolesResponse digitalStoreRolesWithOptions(DigitalStoreRolesHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("DigitalStoreRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/roles", "json", req, runtime), new DigitalStoreRolesResponse());
    }

    public DigitalStoreStoreInfoResponse digitalStoreStoreInfo(DigitalStoreStoreInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DigitalStoreStoreInfoHeaders headers = new DigitalStoreStoreInfoHeaders();
        return this.digitalStoreStoreInfoWithOptions(request, headers, runtime);
    }

    public DigitalStoreStoreInfoResponse digitalStoreStoreInfoWithOptions(DigitalStoreStoreInfoRequest request, DigitalStoreStoreInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DigitalStoreStoreInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/storeInfos", "json", req, runtime), new DigitalStoreStoreInfoResponse());
    }

    public DigitalStoreSubNodesResponse digitalStoreSubNodes(DigitalStoreSubNodesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DigitalStoreSubNodesHeaders headers = new DigitalStoreSubNodesHeaders();
        return this.digitalStoreSubNodesWithOptions(request, headers, runtime);
    }

    public DigitalStoreSubNodesResponse digitalStoreSubNodesWithOptions(DigitalStoreSubNodesRequest request, DigitalStoreSubNodesHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DigitalStoreSubNodes", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/subsidiaryNodes", "json", req, runtime), new DigitalStoreSubNodesResponse());
    }

    public DigitalStoreUserInfoResponse digitalStoreUserInfo(DigitalStoreUserInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DigitalStoreUserInfoHeaders headers = new DigitalStoreUserInfoHeaders();
        return this.digitalStoreUserInfoWithOptions(request, headers, runtime);
    }

    public DigitalStoreUserInfoResponse digitalStoreUserInfoWithOptions(DigitalStoreUserInfoRequest request, DigitalStoreUserInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DigitalStoreUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/userInfos", "json", req, runtime), new DigitalStoreUserInfoResponse());
    }

    public DigitalStoreUsersResponse digitalStoreUsers(DigitalStoreUsersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DigitalStoreUsersHeaders headers = new DigitalStoreUsersHeaders();
        return this.digitalStoreUsersWithOptions(request, headers, runtime);
    }

    public DigitalStoreUsersResponse digitalStoreUsersWithOptions(DigitalStoreUsersRequest request, DigitalStoreUsersHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DigitalStoreUsers", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/nodes/users", "json", req, runtime), new DigitalStoreUsersResponse());
    }

    public IndustryManufactureCommonEventResponse industryManufactureCommonEvent(IndustryManufactureCommonEventRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        IndustryManufactureCommonEventHeaders headers = new IndustryManufactureCommonEventHeaders();
        return this.industryManufactureCommonEventWithOptions(request, headers, runtime);
    }

    public IndustryManufactureCommonEventResponse industryManufactureCommonEventWithOptions(IndustryManufactureCommonEventRequest request, IndustryManufactureCommonEventHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("IndustryManufactureCommonEvent", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturing/bases/commons/events", "json", req, runtime), new IndustryManufactureCommonEventResponse());
    }

    public IndustryManufactureCostRecordListGetResponse industryManufactureCostRecordListGet(IndustryManufactureCostRecordListGetRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        IndustryManufactureCostRecordListGetHeaders headers = new IndustryManufactureCostRecordListGetHeaders();
        return this.industryManufactureCostRecordListGetWithOptions(request, headers, runtime);
    }

    public IndustryManufactureCostRecordListGetResponse industryManufactureCostRecordListGetWithOptions(IndustryManufactureCostRecordListGetRequest request, IndustryManufactureCostRecordListGetHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("IndustryManufactureCostRecordListGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/materialCostRecords/query", "json", req, runtime), new IndustryManufactureCostRecordListGetResponse());
    }

    public IndustryManufactureFeeListGetResponse industryManufactureFeeListGet(IndustryManufactureFeeListGetRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        IndustryManufactureFeeListGetHeaders headers = new IndustryManufactureFeeListGetHeaders();
        return this.industryManufactureFeeListGetWithOptions(request, headers, runtime);
    }

    public IndustryManufactureFeeListGetResponse industryManufactureFeeListGetWithOptions(IndustryManufactureFeeListGetRequest request, IndustryManufactureFeeListGetHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("IndustryManufactureFeeListGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/fees/query", "json", req, runtime), new IndustryManufactureFeeListGetResponse());
    }

    public IndustryManufactureLabourCostResponse industryManufactureLabourCost(IndustryManufactureLabourCostRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        IndustryManufactureLabourCostHeaders headers = new IndustryManufactureLabourCostHeaders();
        return this.industryManufactureLabourCostWithOptions(request, headers, runtime);
    }

    public IndustryManufactureLabourCostResponse industryManufactureLabourCostWithOptions(IndustryManufactureLabourCostRequest request, IndustryManufactureLabourCostHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("IndustryManufactureLabourCost", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/labourCosts/query", "json", req, runtime), new IndustryManufactureLabourCostResponse());
    }

    public IndustryManufactureMaterialListResponse industryManufactureMaterialList(IndustryManufactureMaterialListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        IndustryManufactureMaterialListHeaders headers = new IndustryManufactureMaterialListHeaders();
        return this.industryManufactureMaterialListWithOptions(request, headers, runtime);
    }

    public IndustryManufactureMaterialListResponse industryManufactureMaterialListWithOptions(IndustryManufactureMaterialListRequest request, IndustryManufactureMaterialListHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("IndustryManufactureMaterialList", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/materials/query", "json", req, runtime), new IndustryManufactureMaterialListResponse());
    }

    public IndustryManufactureMesTeamMgmtResponse industryManufactureMesTeamMgmt(IndustryManufactureMesTeamMgmtRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        IndustryManufactureMesTeamMgmtHeaders headers = new IndustryManufactureMesTeamMgmtHeaders();
        return this.industryManufactureMesTeamMgmtWithOptions(request, headers, runtime);
    }

    public IndustryManufactureMesTeamMgmtResponse industryManufactureMesTeamMgmtWithOptions(IndustryManufactureMesTeamMgmtRequest request, IndustryManufactureMesTeamMgmtHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureMesTeamMgmt", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturing/base/data/team", "json", req, runtime), new IndustryManufactureMesTeamMgmtResponse());
    }

    public IndustryMmanufactureMaterialCostGetResponse industryMmanufactureMaterialCostGet(IndustryMmanufactureMaterialCostGetRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        IndustryMmanufactureMaterialCostGetHeaders headers = new IndustryMmanufactureMaterialCostGetHeaders();
        return this.industryMmanufactureMaterialCostGetWithOptions(request, headers, runtime);
    }

    public IndustryMmanufactureMaterialCostGetResponse industryMmanufactureMaterialCostGetWithOptions(IndustryMmanufactureMaterialCostGetRequest request, IndustryMmanufactureMaterialCostGetHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("IndustryMmanufactureMaterialCostGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/base/materialCosts/query", "json", req, runtime), new IndustryMmanufactureMaterialCostGetResponse());
    }

    public QueryAllDepartmentResponse queryAllDepartment(QueryAllDepartmentRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllDepartmentHeaders headers = new QueryAllDepartmentHeaders();
        return this.queryAllDepartmentWithOptions(request, headers, runtime);
    }

    public QueryAllDepartmentResponse queryAllDepartmentWithOptions(QueryAllDepartmentRequest request, QueryAllDepartmentHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryAllDepartment", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments", "json", req, runtime), new QueryAllDepartmentResponse());
    }

    public QueryAllDoctorsResponse queryAllDoctors(QueryAllDoctorsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllDoctorsHeaders headers = new QueryAllDoctorsHeaders();
        return this.queryAllDoctorsWithOptions(request, headers, runtime);
    }

    public QueryAllDoctorsResponse queryAllDoctorsWithOptions(QueryAllDoctorsRequest request, QueryAllDoctorsHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryAllDoctors", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/doctors", "json", req, runtime), new QueryAllDoctorsResponse());
    }

    public QueryAllGroupResponse queryAllGroup(QueryAllGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllGroupHeaders headers = new QueryAllGroupHeaders();
        return this.queryAllGroupWithOptions(request, headers, runtime);
    }

    public QueryAllGroupResponse queryAllGroupWithOptions(QueryAllGroupRequest request, QueryAllGroupHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryAllGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups", "json", req, runtime), new QueryAllGroupResponse());
    }

    public QueryAllGroupsInDeptResponse queryAllGroupsInDept(String deptId, QueryAllGroupsInDeptRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllGroupsInDeptHeaders headers = new QueryAllGroupsInDeptHeaders();
        return this.queryAllGroupsInDeptWithOptions(deptId, request, headers, runtime);
    }

    public QueryAllGroupsInDeptResponse queryAllGroupsInDeptWithOptions(String deptId, QueryAllGroupsInDeptRequest request, QueryAllGroupsInDeptHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryAllGroupsInDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/groups", "json", req, runtime), new QueryAllGroupsInDeptResponse());
    }

    public QueryAllMemberByDeptResponse queryAllMemberByDept(String deptId, QueryAllMemberByDeptRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllMemberByDeptHeaders headers = new QueryAllMemberByDeptHeaders();
        return this.queryAllMemberByDeptWithOptions(deptId, request, headers, runtime);
    }

    public QueryAllMemberByDeptResponse queryAllMemberByDeptWithOptions(String deptId, QueryAllMemberByDeptRequest request, QueryAllMemberByDeptHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryAllMemberByDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/members", "json", req, runtime), new QueryAllMemberByDeptResponse());
    }

    public QueryAllMemberByGroupResponse queryAllMemberByGroup(String groupId, QueryAllMemberByGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllMemberByGroupHeaders headers = new QueryAllMemberByGroupHeaders();
        return this.queryAllMemberByGroupWithOptions(groupId, request, headers, runtime);
    }

    public QueryAllMemberByGroupResponse queryAllMemberByGroupWithOptions(String groupId, QueryAllMemberByGroupRequest request, QueryAllMemberByGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        groupId = com.aliyun.openapiutil.Client.getEncodeParam(groupId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryAllMemberByGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId + "/members", "json", req, runtime), new QueryAllMemberByGroupResponse());
    }

    public QueryBizOptLogResponse queryBizOptLog(QueryBizOptLogRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryBizOptLogHeaders headers = new QueryBizOptLogHeaders();
        return this.queryBizOptLogWithOptions(request, headers, runtime);
    }

    public QueryBizOptLogResponse queryBizOptLogWithOptions(QueryBizOptLogRequest request, QueryBizOptLogHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryBizOptLog", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/bizOptLogs", "json", req, runtime), new QueryBizOptLogResponse());
    }

    public QueryDepartmentInfoResponse queryDepartmentInfo(String deptId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryDepartmentInfoHeaders headers = new QueryDepartmentInfoHeaders();
        return this.queryDepartmentInfoWithOptions(deptId, headers, runtime);
    }

    public QueryDepartmentInfoResponse queryDepartmentInfoWithOptions(String deptId, QueryDepartmentInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        deptId = com.aliyun.openapiutil.Client.getEncodeParam(deptId);
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
        return TeaModel.toModel(this.doROARequest("QueryDepartmentInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "", "json", req, runtime), new QueryDepartmentInfoResponse());
    }

    public QueryGroupInfoResponse queryGroupInfo(String groupId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryGroupInfoHeaders headers = new QueryGroupInfoHeaders();
        return this.queryGroupInfoWithOptions(groupId, headers, runtime);
    }

    public QueryGroupInfoResponse queryGroupInfoWithOptions(String groupId, QueryGroupInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        groupId = com.aliyun.openapiutil.Client.getEncodeParam(groupId);
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
        return TeaModel.toModel(this.doROARequest("QueryGroupInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId + "", "json", req, runtime), new QueryGroupInfoResponse());
    }

    public QueryHospitalDistrictInfoResponse queryHospitalDistrictInfo(QueryHospitalDistrictInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryHospitalDistrictInfoHeaders headers = new QueryHospitalDistrictInfoHeaders();
        return this.queryHospitalDistrictInfoWithOptions(request, headers, runtime);
    }

    public QueryHospitalDistrictInfoResponse queryHospitalDistrictInfoWithOptions(QueryHospitalDistrictInfoRequest request, QueryHospitalDistrictInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryHospitalDistrictInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/districts", "json", req, runtime), new QueryHospitalDistrictInfoResponse());
    }

    public QueryHospitalRoleUserInfoResponse queryHospitalRoleUserInfo(QueryHospitalRoleUserInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryHospitalRoleUserInfoHeaders headers = new QueryHospitalRoleUserInfoHeaders();
        return this.queryHospitalRoleUserInfoWithOptions(request, headers, runtime);
    }

    public QueryHospitalRoleUserInfoResponse queryHospitalRoleUserInfoWithOptions(QueryHospitalRoleUserInfoRequest request, QueryHospitalRoleUserInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryHospitalRoleUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/roles/userInfos", "json", req, runtime), new QueryHospitalRoleUserInfoResponse());
    }

    public QueryHospitalRolesResponse queryHospitalRoles() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryHospitalRolesHeaders headers = new QueryHospitalRolesHeaders();
        return this.queryHospitalRolesWithOptions(headers, runtime);
    }

    public QueryHospitalRolesResponse queryHospitalRolesWithOptions(QueryHospitalRolesHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryHospitalRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/roles", "json", req, runtime), new QueryHospitalRolesResponse());
    }

    public QueryJobCodeDictionaryResponse queryJobCodeDictionary() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryJobCodeDictionaryHeaders headers = new QueryJobCodeDictionaryHeaders();
        return this.queryJobCodeDictionaryWithOptions(headers, runtime);
    }

    public QueryJobCodeDictionaryResponse queryJobCodeDictionaryWithOptions(QueryJobCodeDictionaryHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryJobCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/jobCodes", "json", req, runtime), new QueryJobCodeDictionaryResponse());
    }

    public QueryJobStatusCodeDictionaryResponse queryJobStatusCodeDictionary() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryJobStatusCodeDictionaryHeaders headers = new QueryJobStatusCodeDictionaryHeaders();
        return this.queryJobStatusCodeDictionaryWithOptions(headers, runtime);
    }

    public QueryJobStatusCodeDictionaryResponse queryJobStatusCodeDictionaryWithOptions(QueryJobStatusCodeDictionaryHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryJobStatusCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/jobStatusCodes", "json", req, runtime), new QueryJobStatusCodeDictionaryResponse());
    }

    public QueryMedicalEventsResponse queryMedicalEvents() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryMedicalEventsHeaders headers = new QueryMedicalEventsHeaders();
        return this.queryMedicalEventsWithOptions(headers, runtime);
    }

    public QueryMedicalEventsResponse queryMedicalEventsWithOptions(QueryMedicalEventsHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryMedicalEvents", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/events", "json", req, runtime), new QueryMedicalEventsResponse());
    }

    public QueryUserCredentialsResponse queryUserCredentials(QueryUserCredentialsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryUserCredentialsHeaders headers = new QueryUserCredentialsHeaders();
        return this.queryUserCredentialsWithOptions(request, headers, runtime);
    }

    public QueryUserCredentialsResponse queryUserCredentialsWithOptions(QueryUserCredentialsRequest request, QueryUserCredentialsHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryUserCredentials", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/credentials/query", "json", req, runtime), new QueryUserCredentialsResponse());
    }

    public QueryUserExtInfoResponse queryUserExtInfo(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryUserExtInfoHeaders headers = new QueryUserExtInfoHeaders();
        return this.queryUserExtInfoWithOptions(userId, headers, runtime);
    }

    public QueryUserExtInfoResponse queryUserExtInfoWithOptions(String userId, QueryUserExtInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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
        return TeaModel.toModel(this.doROARequest("QueryUserExtInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "json", req, runtime), new QueryUserExtInfoResponse());
    }

    public QueryUserExtendValuesResponse queryUserExtendValues(QueryUserExtendValuesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryUserExtendValuesHeaders headers = new QueryUserExtendValuesHeaders();
        return this.queryUserExtendValuesWithOptions(request, headers, runtime);
    }

    public QueryUserExtendValuesResponse queryUserExtendValuesWithOptions(QueryUserExtendValuesRequest request, QueryUserExtendValuesHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("QueryUserExtendValues", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/extends/query", "json", req, runtime), new QueryUserExtendValuesResponse());
    }

    public QueryUserInfoResponse queryUserInfo(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryUserInfoHeaders headers = new QueryUserInfoHeaders();
        return this.queryUserInfoWithOptions(userId, headers, runtime);
    }

    public QueryUserInfoResponse queryUserInfoWithOptions(String userId, QueryUserInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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
        return TeaModel.toModel(this.doROARequest("QueryUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "", "json", req, runtime), new QueryUserInfoResponse());
    }

    public QueryUserProbCodeDictionaryResponse queryUserProbCodeDictionary() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryUserProbCodeDictionaryHeaders headers = new QueryUserProbCodeDictionaryHeaders();
        return this.queryUserProbCodeDictionaryWithOptions(headers, runtime);
    }

    public QueryUserProbCodeDictionaryResponse queryUserProbCodeDictionaryWithOptions(QueryUserProbCodeDictionaryHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryUserProbCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/userProbCodes", "json", req, runtime), new QueryUserProbCodeDictionaryResponse());
    }

    public QueryUserRolesResponse queryUserRoles(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryUserRolesHeaders headers = new QueryUserRolesHeaders();
        return this.queryUserRolesWithOptions(userId, headers, runtime);
    }

    public QueryUserRolesResponse queryUserRolesWithOptions(String userId, QueryUserRolesHeaders headers, RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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
        return TeaModel.toModel(this.doROARequest("QueryUserRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/roles", "json", req, runtime), new QueryUserRolesResponse());
    }

    public SaveUserExtendValuesResponse saveUserExtendValues(String userId, SaveUserExtendValuesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SaveUserExtendValuesHeaders headers = new SaveUserExtendValuesHeaders();
        return this.saveUserExtendValuesWithOptions(userId, request, headers, runtime);
    }

    public SaveUserExtendValuesResponse saveUserExtendValuesWithOptions(String userId, SaveUserExtendValuesRequest request, SaveUserExtendValuesHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("SaveUserExtendValues", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/" + userId + "/extends", "json", req, runtime), new SaveUserExtendValuesResponse());
    }

    public UpdateUserExtendInfoResponse updateUserExtendInfo(String userId, UpdateUserExtendInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateUserExtendInfoHeaders headers = new UpdateUserExtendInfoHeaders();
        return this.updateUserExtendInfoWithOptions(userId, request, headers, runtime);
    }

    public UpdateUserExtendInfoResponse updateUserExtendInfoWithOptions(String userId, UpdateUserExtendInfoRequest request, UpdateUserExtendInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateUserExtendInfo", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "none", req, runtime), new UpdateUserExtendInfoResponse());
    }
}
