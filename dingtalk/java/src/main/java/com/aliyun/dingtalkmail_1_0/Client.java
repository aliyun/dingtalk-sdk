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
     * <p>创建邮件文件夹</p>
     * 
     * @param request CreateMailFolderRequest
     * @param headers CreateMailFolderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateMailFolderResponse
     */
    public CreateMailFolderResponse createMailFolderWithOptions(String email, CreateMailFolderRequest request, CreateMailFolderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.displayName)) {
            body.put("displayName", request.displayName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extensions)) {
            body.put("extensions", request.extensions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.folerId)) {
            body.put("folerId", request.folerId);
        }

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
            new TeaPair("action", "CreateMailFolder"),
            new TeaPair("version", "mail_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/mail/users/" + email + "/mailFolders"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateMailFolderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建邮件文件夹</p>
     * 
     * @param request CreateMailFolderRequest
     * @return CreateMailFolderResponse
     */
    public CreateMailFolderResponse createMailFolder(String email, CreateMailFolderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateMailFolderHeaders headers = new CreateMailFolderHeaders();
        return this.createMailFolderWithOptions(email, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建草稿</p>
     * 
     * @param request CreateMessageRequest
     * @param headers CreateMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateMessageResponse
     */
    public CreateMessageResponse createMessageWithOptions(String email, CreateMessageRequest request, CreateMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.message)) {
            body.put("message", request.message);
        }

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
            new TeaPair("action", "CreateMessage"),
            new TeaPair("version", "mail_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/mail/users/" + email + "/messages"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateMessageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建草稿</p>
     * 
     * @param request CreateMessageRequest
     * @return CreateMessageResponse
     */
    public CreateMessageResponse createMessage(String email, CreateMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateMessageHeaders headers = new CreateMessageHeaders();
        return this.createMessageWithOptions(email, request, headers, runtime);
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
     * <p>删除文件夹</p>
     * 
     * @param headers DeleteMailFolderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteMailFolderResponse
     */
    public DeleteMailFolderResponse deleteMailFolderWithOptions(String email, String id, DeleteMailFolderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteMailFolder"),
            new TeaPair("version", "mail_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/mail/users/" + email + "/mailFolders/" + id + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteMailFolderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除文件夹</p>
     * @return DeleteMailFolderResponse
     */
    public DeleteMailFolderResponse deleteMailFolder(String email, String id) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteMailFolderHeaders headers = new DeleteMailFolderHeaders();
        return this.deleteMailFolderWithOptions(email, id, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量删除邮件</p>
     * 
     * @param request DeleteMessagesRequest
     * @param headers DeleteMessagesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteMessagesResponse
     */
    public DeleteMessagesResponse deleteMessagesWithOptions(String email, DeleteMessagesRequest request, DeleteMessagesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deleteType)) {
            body.put("deleteType", request.deleteType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ids)) {
            body.put("ids", request.ids);
        }

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
            new TeaPair("action", "DeleteMessages"),
            new TeaPair("version", "mail_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/mail/users/" + email + "/messages/batchDelete"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteMessagesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量删除邮件</p>
     * 
     * @param request DeleteMessagesRequest
     * @return DeleteMessagesResponse
     */
    public DeleteMessagesResponse deleteMessages(String email, DeleteMessagesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteMessagesHeaders headers = new DeleteMessagesHeaders();
        return this.deleteMessagesWithOptions(email, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取邮件</p>
     * 
     * @param request GetMessageRequest
     * @param headers GetMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMessageResponse
     */
    public GetMessageResponse getMessageWithOptions(String email, String id, GetMessageRequest request, GetMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.selectFields)) {
            query.put("selectFields", request.selectFields);
        }

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
            new TeaPair("action", "GetMessage"),
            new TeaPair("version", "mail_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/mail/users/" + email + "/messages/" + id + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMessageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取邮件</p>
     * 
     * @param request GetMessageRequest
     * @return GetMessageResponse
     */
    public GetMessageResponse getMessage(String email, String id, GetMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMessageHeaders headers = new GetMessageHeaders();
        return this.getMessageWithOptions(email, id, request, headers, runtime);
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
            new TeaPair("pathname", "/v1.0/mail/users/" + email + "/mailFolders"),
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

    /**
     * <b>summary</b> : 
     * <p>获取邮件列表</p>
     * 
     * @param request ListMessagesRequest
     * @param headers ListMessagesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListMessagesResponse
     */
    public ListMessagesResponse listMessagesWithOptions(String email, String folderId, ListMessagesRequest request, ListMessagesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.selectFields)) {
            query.put("selectFields", request.selectFields);
        }

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
            new TeaPair("action", "ListMessages"),
            new TeaPair("version", "mail_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/mail/users/" + email + "/mailFolders/" + folderId + "/messages"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListMessagesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取邮件列表</p>
     * 
     * @param request ListMessagesRequest
     * @return ListMessagesResponse
     */
    public ListMessagesResponse listMessages(String email, String folderId, ListMessagesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListMessagesHeaders headers = new ListMessagesHeaders();
        return this.listMessagesWithOptions(email, folderId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>移动文件夹</p>
     * 
     * @param request MoveMailFolderRequest
     * @param headers MoveMailFolderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MoveMailFolderResponse
     */
    public MoveMailFolderResponse moveMailFolderWithOptions(String email, String id, MoveMailFolderRequest request, MoveMailFolderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.destinationFolderId)) {
            body.put("destinationFolderId", request.destinationFolderId);
        }

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
            new TeaPair("action", "MoveMailFolder"),
            new TeaPair("version", "mail_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/mail/users/" + email + "/mailFolders/" + id + "/move"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MoveMailFolderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>移动文件夹</p>
     * 
     * @param request MoveMailFolderRequest
     * @return MoveMailFolderResponse
     */
    public MoveMailFolderResponse moveMailFolder(String email, String id, MoveMailFolderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MoveMailFolderHeaders headers = new MoveMailFolderHeaders();
        return this.moveMailFolderWithOptions(email, id, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发送邮件</p>
     * 
     * @param request SendMessageRequest
     * @param headers SendMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendMessageResponse
     */
    public SendMessageResponse sendMessageWithOptions(String email, String id, SendMessageRequest request, SendMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.saveToSentItems)) {
            body.put("saveToSentItems", request.saveToSentItems);
        }

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
            new TeaPair("version", "mail_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/mail/users/" + email + "/messages/" + id + "/send"),
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
     * <p>发送邮件</p>
     * 
     * @param request SendMessageRequest
     * @return SendMessageResponse
     */
    public SendMessageResponse sendMessage(String email, String id, SendMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendMessageHeaders headers = new SendMessageHeaders();
        return this.sendMessageWithOptions(email, id, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改文件夹信息</p>
     * 
     * @param request UpdateMailFolderRequest
     * @param headers UpdateMailFolderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateMailFolderResponse
     */
    public UpdateMailFolderResponse updateMailFolderWithOptions(String email, String id, UpdateMailFolderRequest request, UpdateMailFolderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.displayName)) {
            body.put("displayName", request.displayName);
        }

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
            new TeaPair("action", "UpdateMailFolder"),
            new TeaPair("version", "mail_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/mail/users/" + email + "/mailFolders/" + id + "/update"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateMailFolderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改文件夹信息</p>
     * 
     * @param request UpdateMailFolderRequest
     * @return UpdateMailFolderResponse
     */
    public UpdateMailFolderResponse updateMailFolder(String email, String id, UpdateMailFolderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateMailFolderHeaders headers = new UpdateMailFolderHeaders();
        return this.updateMailFolderWithOptions(email, id, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改草稿</p>
     * 
     * @param request UpdateMessageRequest
     * @param headers UpdateMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateMessageResponse
     */
    public UpdateMessageResponse updateMessageWithOptions(String email, String id, UpdateMessageRequest request, UpdateMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.message)) {
            body.put("message", request.message);
        }

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
            new TeaPair("action", "UpdateMessage"),
            new TeaPair("version", "mail_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/mail/users/" + email + "/messages/" + id + "/update"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateMessageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改草稿</p>
     * 
     * @param request UpdateMessageRequest
     * @return UpdateMessageResponse
     */
    public UpdateMessageResponse updateMessage(String email, String id, UpdateMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateMessageHeaders headers = new UpdateMessageHeaders();
        return this.updateMessageWithOptions(email, id, request, headers, runtime);
    }
}
