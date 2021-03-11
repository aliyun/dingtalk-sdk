// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkesign_1_0.models.*;
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


    public CorpInfoResponse corpInfo() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CorpInfoHeaders headers = new CorpInfoHeaders();
        return this.corpInfoWithOptions(headers, runtime);
    }

    public CorpInfoResponse corpInfoWithOptions(CorpInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("CorpInfo", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/corps/info", "json", req, runtime), new CorpInfoResponse());
    }

    public CreateDeveloperResponse createDeveloper(CreateDeveloperRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateDeveloperHeaders headers = new CreateDeveloperHeaders();
        return this.createDeveloperWithOptions(request, headers, runtime);
    }

    public CreateDeveloperResponse createDeveloperWithOptions(CreateDeveloperRequest request, CreateDeveloperHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.redirectUrl)) {
            body.put("redirectUrl", request.redirectUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvAccessToken)) {
            body.put("dingIsvAccessToken", request.dingIsvAccessToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateDeveloper", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/developers/create", "json", req, runtime), new CreateDeveloperResponse());
    }

    public GetUserRealnameUrlResponse getUserRealnameUrl(GetUserRealnameUrlRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUserRealnameUrlHeaders headers = new GetUserRealnameUrlHeaders();
        return this.getUserRealnameUrlWithOptions(request, headers, runtime);
    }

    public GetUserRealnameUrlResponse getUserRealnameUrlWithOptions(GetUserRealnameUrlRequest request, GetUserRealnameUrlHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.redirectUrl)) {
            body.put("redirectUrl", request.redirectUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvAccessToken)) {
            body.put("dingIsvAccessToken", request.dingIsvAccessToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetUserRealnameUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/users/realname", "json", req, runtime), new GetUserRealnameUrlResponse());
    }

    public GetCorpRealnameUrlResponse getCorpRealnameUrl(GetCorpRealnameUrlRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetCorpRealnameUrlHeaders headers = new GetCorpRealnameUrlHeaders();
        return this.getCorpRealnameUrlWithOptions(request, headers, runtime);
    }

    public GetCorpRealnameUrlResponse getCorpRealnameUrlWithOptions(GetCorpRealnameUrlRequest request, GetCorpRealnameUrlHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvAccessToken)) {
            body.put("dingIsvAccessToken", request.dingIsvAccessToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetCorpRealnameUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/corps/realname", "json", req, runtime), new GetCorpRealnameUrlResponse());
    }

    public GetFileResponse getFile(String fileId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetFileHeaders headers = new GetFileHeaders();
        return this.getFileWithOptions(fileId, headers, runtime);
    }

    public GetFileResponse getFileWithOptions(String fileId, GetFileHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetFile", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/files/" + fileId + "", "json", req, runtime), new GetFileResponse());
    }

    public AuthUrlResponse authUrl(AuthUrlRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AuthUrlHeaders headers = new AuthUrlHeaders();
        return this.authUrlWithOptions(request, headers, runtime);
    }

    public AuthUrlResponse authUrlWithOptions(AuthUrlRequest request, AuthUrlHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.redirectUrl)) {
            body.put("redirectUrl", request.redirectUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvAccessToken)) {
            body.put("dingIsvAccessToken", request.dingIsvAccessToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AuthUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/auths/url", "json", req, runtime), new AuthUrlResponse());
    }

    public CancelCorpAuthResponse cancelCorpAuth() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CancelCorpAuthHeaders headers = new CancelCorpAuthHeaders();
        return this.cancelCorpAuthWithOptions(headers, runtime);
    }

    public CancelCorpAuthResponse cancelCorpAuthWithOptions(CancelCorpAuthHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("CancelCorpAuth", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/corps/auth/cancel", "json", req, runtime), new CancelCorpAuthResponse());
    }

    public GetSignNoticeUrlResponse getSignNoticeUrl(GetSignNoticeUrlRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetSignNoticeUrlHeaders headers = new GetSignNoticeUrlHeaders();
        return this.getSignNoticeUrlWithOptions(request, headers, runtime);
    }

    public GetSignNoticeUrlResponse getSignNoticeUrlWithOptions(GetSignNoticeUrlRequest request, GetSignNoticeUrlHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            body.put("taskId", request.taskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvAccessToken)) {
            body.put("dingIsvAccessToken", request.dingIsvAccessToken);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetSignNoticeUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/signs/notice/url", "json", req, runtime), new GetSignNoticeUrlResponse());
    }

    public GetUploadUrlResponse getUploadUrl(GetUploadUrlRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUploadUrlHeaders headers = new GetUploadUrlHeaders();
        return this.getUploadUrlWithOptions(request, headers, runtime);
    }

    public GetUploadUrlResponse getUploadUrlWithOptions(GetUploadUrlRequest request, GetUploadUrlHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvAccessToken)) {
            body.put("dingIsvAccessToken", request.dingIsvAccessToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contentType)) {
            body.put("contentType", request.contentType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contentMd5)) {
            body.put("contentMd5", request.contentMd5);
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

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetUploadUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/files/getUploadUrl", "json", req, runtime), new GetUploadUrlResponse());
    }

    public ListSealApprovalResponse listSealApproval(ListSealApprovalRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListSealApprovalHeaders headers = new ListSealApprovalHeaders();
        return this.listSealApprovalWithOptions(request, headers, runtime);
    }

    public ListSealApprovalResponse listSealApprovalWithOptions(ListSealApprovalRequest request, ListSealApprovalHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            query.put("taskId", request.taskId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListSealApproval", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/seals/approval/list", "json", req, runtime), new ListSealApprovalResponse());
    }

    public ContractMarginResponse contractMargin() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ContractMarginHeaders headers = new ContractMarginHeaders();
        return this.contractMarginWithOptions(headers, runtime);
    }

    public ContractMarginResponse contractMarginWithOptions(ContractMarginHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("ContractMargin", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/contracts/margin", "json", req, runtime), new ContractMarginResponse());
    }

    public GetFlowDetailResponse getFlowDetail(GetFlowDetailRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetFlowDetailHeaders headers = new GetFlowDetailHeaders();
        return this.getFlowDetailWithOptions(request, headers, runtime);
    }

    public GetFlowDetailResponse getFlowDetailWithOptions(GetFlowDetailRequest request, GetFlowDetailHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            query.put("taskId", request.taskId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetFlowDetail", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/flows/detail", "json", req, runtime), new GetFlowDetailResponse());
    }

    public GetProcessStartUrlResponse getProcessStartUrl(GetProcessStartUrlRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetProcessStartUrlHeaders headers = new GetProcessStartUrlHeaders();
        return this.getProcessStartUrlWithOptions(request, headers, runtime);
    }

    public GetProcessStartUrlResponse getProcessStartUrlWithOptions(GetProcessStartUrlRequest request, GetProcessStartUrlHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.files)) {
            body.put("files", request.files);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
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

        if (!com.aliyun.teautil.Common.isUnset(request.ccs)) {
            body.put("ccs", request.ccs);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvAccessToken)) {
            body.put("dingIsvAccessToken", request.dingIsvAccessToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetProcessStartUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/process/start", "json", req, runtime), new GetProcessStartUrlResponse());
    }

    public CorpConsoleResponse corpConsole() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CorpConsoleHeaders headers = new CorpConsoleHeaders();
        return this.corpConsoleWithOptions(headers, runtime);
    }

    public CorpConsoleResponse corpConsoleWithOptions(CorpConsoleHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("CorpConsole", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/corps/console", "json", req, runtime), new CorpConsoleResponse());
    }

    public ListFlowDocsResponse listFlowDocs(ListFlowDocsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListFlowDocsHeaders headers = new ListFlowDocsHeaders();
        return this.listFlowDocsWithOptions(request, headers, runtime);
    }

    public ListFlowDocsResponse listFlowDocsWithOptions(ListFlowDocsRequest request, ListFlowDocsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            query.put("taskId", request.taskId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListFlowDocs", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/flows/docs", "json", req, runtime), new ListFlowDocsResponse());
    }

    public GetUserInfoResponse getUserInfo(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUserInfoHeaders headers = new GetUserInfoHeaders();
        return this.getUserInfoWithOptions(userId, headers, runtime);
    }

    public GetUserInfoResponse getUserInfoWithOptions(String userId, GetUserInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetUserInfo", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/users/" + userId + "", "json", req, runtime), new GetUserInfoResponse());
    }

    public GetCropStatusResponse getCropStatus() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetCropStatusHeaders headers = new GetCropStatusHeaders();
        return this.getCropStatusWithOptions(headers, runtime);
    }

    public GetCropStatusResponse getCropStatusWithOptions(GetCropStatusHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetCropStatus", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/corps/statuses", "json", req, runtime), new GetCropStatusResponse());
    }

    public ChannelOrderResponse channelOrder(ChannelOrderRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ChannelOrderHeaders headers = new ChannelOrderHeaders();
        return this.channelOrderWithOptions(request, headers, runtime);
    }

    public ChannelOrderResponse channelOrderWithOptions(ChannelOrderRequest request, ChannelOrderHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

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

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvAccessToken)) {
            body.put("dingIsvAccessToken", request.dingIsvAccessToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("ChannelOrder", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/orders/channel", "json", req, runtime), new ChannelOrderResponse());
    }

    public OrderResaleResponse orderResale(OrderResaleRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        OrderResaleHeaders headers = new OrderResaleHeaders();
        return this.orderResaleWithOptions(request, headers, runtime);
    }

    public OrderResaleResponse orderResaleWithOptions(OrderResaleRequest request, OrderResaleHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serviceStartTime)) {
            body.put("serviceStartTime", request.serviceStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serviceStopTime)) {
            body.put("serviceStopTime", request.serviceStopTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderCreateTime)) {
            body.put("orderCreateTime", request.orderCreateTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            body.put("orderId", request.orderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.quantity)) {
            body.put("quantity", request.quantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvAccessToken)) {
            body.put("dingIsvAccessToken", request.dingIsvAccessToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("OrderResale", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/orders/resale", "json", req, runtime), new OrderResaleResponse());
    }

    public GetFlowSignDetailResponse getFlowSignDetail(GetFlowSignDetailRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetFlowSignDetailHeaders headers = new GetFlowSignDetailHeaders();
        return this.getFlowSignDetailWithOptions(request, headers, runtime);
    }

    public GetFlowSignDetailResponse getFlowSignDetailWithOptions(GetFlowSignDetailRequest request, GetFlowSignDetailHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            query.put("taskId", request.taskId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetFlowSignDetail", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/flows/sign/detail", "json", req, runtime), new GetFlowSignDetailResponse());
    }
}
