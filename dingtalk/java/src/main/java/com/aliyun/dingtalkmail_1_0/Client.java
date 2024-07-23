// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkmail_1_0.models.*;

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
     * <p>创建企业邮箱用户</p>
     * 
     * @param request CreateUserRequest
     * @param headers CreateUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateUserResponse
     */
    public CreateUserResponse createUserWithOptions(CreateUserRequest request, CreateUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.email)) {
            body.put("email", request.email);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.employeeType)) {
            body.put("employeeType", request.employeeType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.password)) {
            body.put("password", request.password);
        }

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
            new TeaPair("action", "CreateUser"),
            new TeaPair("version", "mail_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/mail/users"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateUserResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建企业邮箱用户</p>
     * 
     * @param request CreateUserRequest
     * @return CreateUserResponse
     */
    public CreateUserResponse createUser(CreateUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateUserHeaders headers = new CreateUserHeaders();
        return this.createUserWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取指定文件夹的子文件夹列表</p>
     * 
     * @param request ListMailFoldersRequest
     * @param headers ListMailFoldersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListMailFoldersResponse
     */
    public ListMailFoldersResponse listMailFoldersWithOptions(String email, ListMailFoldersRequest request, ListMailFoldersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.folderId)) {
            query.put("folderId", request.folderId);
        }

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
            new TeaPair("action", "ListMailFolders"),
            new TeaPair("version", "mail_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/mail/users/emails/" + email + "/mailFolders"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListMailFoldersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取指定文件夹的子文件夹列表</p>
     * 
     * @param request ListMailFoldersRequest
     * @return ListMailFoldersResponse
     */
    public ListMailFoldersResponse listMailFolders(String email, ListMailFoldersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListMailFoldersHeaders headers = new ListMailFoldersHeaders();
        return this.listMailFoldersWithOptions(email, request, headers, runtime);
    }
}
