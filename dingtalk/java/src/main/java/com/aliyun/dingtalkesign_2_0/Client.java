// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkesign_2_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public ApprovalListResponse approvalList(String taskId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ApprovalListHeaders headers = new ApprovalListHeaders();
        return this.approvalListWithOptions(taskId, headers, runtime);
    }

    public ApprovalListResponse approvalListWithOptions(String taskId, ApprovalListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        taskId = com.aliyun.openapiutil.Client.getEncodeParam(taskId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("ApprovalList", "esign_2.0", "HTTP", "GET", "AK", "/v2.0/esign/approvals/" + taskId + "", "json", req, runtime), new ApprovalListResponse());
    }

    public CancelCorpAuthResponse cancelCorpAuth(CancelCorpAuthRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CancelCorpAuthHeaders headers = new CancelCorpAuthHeaders();
        return this.cancelCorpAuthWithOptions(request, headers, runtime);
    }

    public CancelCorpAuthResponse cancelCorpAuthWithOptions(CancelCorpAuthRequest request, CancelCorpAuthHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("CancelCorpAuth", "esign_2.0", "HTTP", "POST", "AK", "/v2.0/esign/auths/cancel", "json", req, runtime), new CancelCorpAuthResponse());
    }

    public ChannelOrdersResponse channelOrders(ChannelOrdersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChannelOrdersHeaders headers = new ChannelOrdersHeaders();
        return this.channelOrdersWithOptions(request, headers, runtime);
    }

    public ChannelOrdersResponse channelOrdersWithOptions(ChannelOrdersRequest request, ChannelOrdersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.itemCode)) {
            body.put("itemCode", request.itemCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.itemName)) {
            body.put("itemName", request.itemName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderCreateTime)) {
            body.put("orderCreateTime", request.orderCreateTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            body.put("orderId", request.orderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payFee)) {
            body.put("payFee", request.payFee);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.quantity)) {
            body.put("quantity", request.quantity);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("ChannelOrders", "esign_2.0", "HTTP", "POST", "AK", "/v2.0/esign/orders/channel", "json", req, runtime), new ChannelOrdersResponse());
    }

    public CorpRealnameResponse corpRealname(CorpRealnameRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CorpRealnameHeaders headers = new CorpRealnameHeaders();
        return this.corpRealnameWithOptions(request, headers, runtime);
    }

    public CorpRealnameResponse corpRealnameWithOptions(CorpRealnameRequest request, CorpRealnameHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.redirectUrl)) {
            body.put("redirectUrl", request.redirectUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CorpRealname", "esign_2.0", "HTTP", "POST", "AK", "/v2.0/esign/corps/realnames", "json", req, runtime), new CorpRealnameResponse());
    }

    public CreateDevelopersResponse createDevelopers(CreateDevelopersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateDevelopersHeaders headers = new CreateDevelopersHeaders();
        return this.createDevelopersWithOptions(request, headers, runtime);
    }

    public CreateDevelopersResponse createDevelopersWithOptions(CreateDevelopersRequest request, CreateDevelopersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.noticeUrl)) {
            body.put("noticeUrl", request.noticeUrl);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateDevelopers", "esign_2.0", "HTTP", "POST", "AK", "/v2.0/esign/developers", "json", req, runtime), new CreateDevelopersResponse());
    }

    public CreateProcessResponse createProcess(CreateProcessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateProcessHeaders headers = new CreateProcessHeaders();
        return this.createProcessWithOptions(request, headers, runtime);
    }

    public CreateProcessResponse createProcessWithOptions(CreateProcessRequest request, CreateProcessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ccs)) {
            body.put("ccs", request.ccs);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.files)) {
            body.put("files", request.files);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.initiatorUserId)) {
            body.put("initiatorUserId", request.initiatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.participants)) {
            body.put("participants", request.participants);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.redirectUrl)) {
            body.put("redirectUrl", request.redirectUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signEndTime)) {
            body.put("signEndTime", request.signEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.sourceInfo))) {
            body.put("sourceInfo", request.sourceInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskName)) {
            body.put("taskName", request.taskName);
        }

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
        return TeaModel.toModel(this.doROARequest("CreateProcess", "esign_2.0", "HTTP", "POST", "AK", "/v2.0/esign/process/startAtOnce", "json", req, runtime), new CreateProcessResponse());
    }

    public GetAttachsApprovalResponse getAttachsApproval(String instanceId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAttachsApprovalHeaders headers = new GetAttachsApprovalHeaders();
        return this.getAttachsApprovalWithOptions(instanceId, headers, runtime);
    }

    public GetAttachsApprovalResponse getAttachsApprovalWithOptions(String instanceId, GetAttachsApprovalHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        instanceId = com.aliyun.openapiutil.Client.getEncodeParam(instanceId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.tsignOpenAppId)) {
            realHeaders.put("tsignOpenAppId", com.aliyun.teautil.Common.toJSONString(headers.tsignOpenAppId));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetAttachsApproval", "esign_2.0", "HTTP", "GET", "AK", "/v2.0/esign/dingInstances/" + instanceId + "/attachments", "json", req, runtime), new GetAttachsApprovalResponse());
    }

    public GetAuthUrlResponse getAuthUrl(GetAuthUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAuthUrlHeaders headers = new GetAuthUrlHeaders();
        return this.getAuthUrlWithOptions(request, headers, runtime);
    }

    public GetAuthUrlResponse getAuthUrlWithOptions(GetAuthUrlRequest request, GetAuthUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.redirectUrl)) {
            body.put("redirectUrl", request.redirectUrl);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetAuthUrl", "esign_2.0", "HTTP", "POST", "AK", "/v2.0/esign/auths/urls", "json", req, runtime), new GetAuthUrlResponse());
    }

    public GetContractMarginResponse getContractMargin() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetContractMarginHeaders headers = new GetContractMarginHeaders();
        return this.getContractMarginWithOptions(headers, runtime);
    }

    public GetContractMarginResponse getContractMarginWithOptions(GetContractMarginHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetContractMargin", "esign_2.0", "HTTP", "GET", "AK", "/v2.0/esign/margins", "json", req, runtime), new GetContractMarginResponse());
    }

    public GetCorpConsoleResponse getCorpConsole() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCorpConsoleHeaders headers = new GetCorpConsoleHeaders();
        return this.getCorpConsoleWithOptions(headers, runtime);
    }

    public GetCorpConsoleResponse getCorpConsoleWithOptions(GetCorpConsoleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetCorpConsole", "esign_2.0", "HTTP", "GET", "AK", "/v2.0/esign/corps/consoles", "json", req, runtime), new GetCorpConsoleResponse());
    }

    public GetCorpInfoResponse getCorpInfo() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCorpInfoHeaders headers = new GetCorpInfoHeaders();
        return this.getCorpInfoWithOptions(headers, runtime);
    }

    public GetCorpInfoResponse getCorpInfoWithOptions(GetCorpInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetCorpInfo", "esign_2.0", "HTTP", "GET", "AK", "/v2.0/esign/corps/infos", "json", req, runtime), new GetCorpInfoResponse());
    }

    public GetExecuteUrlResponse getExecuteUrl(GetExecuteUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetExecuteUrlHeaders headers = new GetExecuteUrlHeaders();
        return this.getExecuteUrlWithOptions(request, headers, runtime);
    }

    public GetExecuteUrlResponse getExecuteUrlWithOptions(GetExecuteUrlRequest request, GetExecuteUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.account)) {
            body.put("account", request.account);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signContainer)) {
            body.put("signContainer", request.signContainer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            body.put("taskId", request.taskId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetExecuteUrl", "esign_2.0", "HTTP", "POST", "AK", "/v2.0/esign/process/executeUrls", "json", req, runtime), new GetExecuteUrlResponse());
    }

    public GetFileInfoResponse getFileInfo(String fileId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFileInfoHeaders headers = new GetFileInfoHeaders();
        return this.getFileInfoWithOptions(fileId, headers, runtime);
    }

    public GetFileInfoResponse getFileInfoWithOptions(String fileId, GetFileInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        fileId = com.aliyun.openapiutil.Client.getEncodeParam(fileId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetFileInfo", "esign_2.0", "HTTP", "GET", "AK", "/v2.0/esign/files/" + fileId + "", "json", req, runtime), new GetFileInfoResponse());
    }

    public GetFileUploadUrlResponse getFileUploadUrl(GetFileUploadUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFileUploadUrlHeaders headers = new GetFileUploadUrlHeaders();
        return this.getFileUploadUrlWithOptions(request, headers, runtime);
    }

    public GetFileUploadUrlResponse getFileUploadUrlWithOptions(GetFileUploadUrlRequest request, GetFileUploadUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.contentMd5)) {
            body.put("contentMd5", request.contentMd5);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contentType)) {
            body.put("contentType", request.contentType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.convert2Pdf)) {
            body.put("convert2Pdf", request.convert2Pdf);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileName)) {
            body.put("fileName", request.fileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileSize)) {
            body.put("fileSize", request.fileSize);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetFileUploadUrl", "esign_2.0", "HTTP", "POST", "AK", "/v2.0/esign/files/uploadUrls", "json", req, runtime), new GetFileUploadUrlResponse());
    }

    public GetFlowDetailResponse getFlowDetail(String taskId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFlowDetailHeaders headers = new GetFlowDetailHeaders();
        return this.getFlowDetailWithOptions(taskId, headers, runtime);
    }

    public GetFlowDetailResponse getFlowDetailWithOptions(String taskId, GetFlowDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        taskId = com.aliyun.openapiutil.Client.getEncodeParam(taskId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetFlowDetail", "esign_2.0", "HTTP", "GET", "AK", "/v2.0/esign/flowTasks/" + taskId + "", "json", req, runtime), new GetFlowDetailResponse());
    }

    public GetFlowDocsResponse getFlowDocs(String taskId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFlowDocsHeaders headers = new GetFlowDocsHeaders();
        return this.getFlowDocsWithOptions(taskId, headers, runtime);
    }

    public GetFlowDocsResponse getFlowDocsWithOptions(String taskId, GetFlowDocsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        taskId = com.aliyun.openapiutil.Client.getEncodeParam(taskId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetFlowDocs", "esign_2.0", "HTTP", "GET", "AK", "/v2.0/esign/flowTasks/" + taskId + "/docs", "json", req, runtime), new GetFlowDocsResponse());
    }

    public GetIsvStatusResponse getIsvStatus() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetIsvStatusHeaders headers = new GetIsvStatusHeaders();
        return this.getIsvStatusWithOptions(headers, runtime);
    }

    public GetIsvStatusResponse getIsvStatusWithOptions(GetIsvStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetIsvStatus", "esign_2.0", "HTTP", "GET", "AK", "/v2.0/esign/corps/appStatus", "json", req, runtime), new GetIsvStatusResponse());
    }

    public GetSignDetailResponse getSignDetail(String taskId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSignDetailHeaders headers = new GetSignDetailHeaders();
        return this.getSignDetailWithOptions(taskId, headers, runtime);
    }

    public GetSignDetailResponse getSignDetailWithOptions(String taskId, GetSignDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        taskId = com.aliyun.openapiutil.Client.getEncodeParam(taskId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetSignDetail", "esign_2.0", "HTTP", "GET", "AK", "/v2.0/esign/signTasks/" + taskId + "", "json", req, runtime), new GetSignDetailResponse());
    }

    public GetUserInfoResponse getUserInfo(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserInfoHeaders headers = new GetUserInfoHeaders();
        return this.getUserInfoWithOptions(userId, headers, runtime);
    }

    public GetUserInfoResponse getUserInfoWithOptions(String userId, GetUserInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetUserInfo", "esign_2.0", "HTTP", "GET", "AK", "/v2.0/esign/users/" + userId + "", "json", req, runtime), new GetUserInfoResponse());
    }

    public ProcessStartResponse processStart(ProcessStartRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ProcessStartHeaders headers = new ProcessStartHeaders();
        return this.processStartWithOptions(request, headers, runtime);
    }

    public ProcessStartResponse processStartWithOptions(ProcessStartRequest request, ProcessStartHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.autoStart)) {
            body.put("autoStart", request.autoStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ccs)) {
            body.put("ccs", request.ccs);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.files)) {
            body.put("files", request.files);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.initiatorUserId)) {
            body.put("initiatorUserId", request.initiatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.participants)) {
            body.put("participants", request.participants);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.redirectUrl)) {
            body.put("redirectUrl", request.redirectUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.sourceInfo))) {
            body.put("sourceInfo", request.sourceInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskName)) {
            body.put("taskName", request.taskName);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("ProcessStart", "esign_2.0", "HTTP", "POST", "AK", "/v2.0/esign/processes/startUrls", "json", req, runtime), new ProcessStartResponse());
    }

    public ResaleOrderResponse resaleOrder(ResaleOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ResaleOrderHeaders headers = new ResaleOrderHeaders();
        return this.resaleOrderWithOptions(request, headers, runtime);
    }

    public ResaleOrderResponse resaleOrderWithOptions(ResaleOrderRequest request, ResaleOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.orderCreateTime)) {
            body.put("orderCreateTime", request.orderCreateTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            body.put("orderId", request.orderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.quantity)) {
            body.put("quantity", request.quantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serviceStartTime)) {
            body.put("serviceStartTime", request.serviceStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serviceStopTime)) {
            body.put("serviceStopTime", request.serviceStopTime);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("ResaleOrder", "esign_2.0", "HTTP", "POST", "AK", "/v2.0/esign/orders/resale", "json", req, runtime), new ResaleOrderResponse());
    }

    public UsersRealnameResponse usersRealname(UsersRealnameRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UsersRealnameHeaders headers = new UsersRealnameHeaders();
        return this.usersRealnameWithOptions(request, headers, runtime);
    }

    public UsersRealnameResponse usersRealnameWithOptions(UsersRealnameRequest request, UsersRealnameHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.redirectUrl)) {
            body.put("redirectUrl", request.redirectUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.serviceGroup)) {
            realHeaders.put("serviceGroup", com.aliyun.teautil.Common.toJSONString(headers.serviceGroup));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UsersRealname", "esign_2.0", "HTTP", "POST", "AK", "/v2.0/esign/users/realnames", "json", req, runtime), new UsersRealnameResponse());
    }
}
