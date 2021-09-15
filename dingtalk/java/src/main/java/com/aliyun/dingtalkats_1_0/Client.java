// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkats_1_0.models.*;
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


    public AddFileResponse addFile(AddFileRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddFileHeaders headers = new AddFileHeaders();
        return this.addFileWithOptions(request, headers, runtime);
    }

    public AddFileResponse addFileWithOptions(AddFileRequest request, AddFileHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileName)) {
            body.put("fileName", request.fileName);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddFile", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/files", "json", req, runtime), new AddFileResponse());
    }

    public GetFlowIdByRelationEntityIdResponse getFlowIdByRelationEntityId(GetFlowIdByRelationEntityIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetFlowIdByRelationEntityIdHeaders headers = new GetFlowIdByRelationEntityIdHeaders();
        return this.getFlowIdByRelationEntityIdWithOptions(request, headers, runtime);
    }

    public GetFlowIdByRelationEntityIdResponse getFlowIdByRelationEntityIdWithOptions(GetFlowIdByRelationEntityIdRequest request, GetFlowIdByRelationEntityIdHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationEntity)) {
            query.put("relationEntity", request.relationEntity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationEntityId)) {
            query.put("relationEntityId", request.relationEntityId);
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
        return TeaModel.toModel(this.doROARequest("GetFlowIdByRelationEntityId", "ats_1.0", "HTTP", "GET", "AK", "/v1.0/ats/flows/ids", "json", req, runtime), new GetFlowIdByRelationEntityIdResponse());
    }

    public AddApplicationRegFormTemplateResponse addApplicationRegFormTemplate(AddApplicationRegFormTemplateRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddApplicationRegFormTemplateHeaders headers = new AddApplicationRegFormTemplateHeaders();
        return this.addApplicationRegFormTemplateWithOptions(request, headers, runtime);
    }

    public AddApplicationRegFormTemplateResponse addApplicationRegFormTemplateWithOptions(AddApplicationRegFormTemplateRequest request, AddApplicationRegFormTemplateHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerId)) {
            body.put("outerId", request.outerId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddApplicationRegFormTemplate", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/flows/applicationRegForms/templates", "json", req, runtime), new AddApplicationRegFormTemplateResponse());
    }

    public QueryInterviewsResponse queryInterviews(QueryInterviewsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryInterviewsHeaders headers = new QueryInterviewsHeaders();
        return this.queryInterviewsWithOptions(request, headers, runtime);
    }

    public QueryInterviewsResponse queryInterviewsWithOptions(QueryInterviewsRequest request, QueryInterviewsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            query.put("size", request.size);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.startTimeBeginMillis)) {
            body.put("startTimeBeginMillis", request.startTimeBeginMillis);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTimeEndMillis)) {
            body.put("startTimeEndMillis", request.startTimeEndMillis);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.candidateId)) {
            body.put("candidateId", request.candidateId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("QueryInterviews", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/interviews/query", "json", req, runtime), new QueryInterviewsResponse());
    }

    public GetFileUploadInfoResponse getFileUploadInfo(GetFileUploadInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetFileUploadInfoHeaders headers = new GetFileUploadInfoHeaders();
        return this.getFileUploadInfoWithOptions(request, headers, runtime);
    }

    public GetFileUploadInfoResponse getFileUploadInfoWithOptions(GetFileUploadInfoRequest request, GetFileUploadInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileName)) {
            query.put("fileName", request.fileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileSize)) {
            query.put("fileSize", request.fileSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.md5)) {
            query.put("md5", request.md5);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
        return TeaModel.toModel(this.doROARequest("GetFileUploadInfo", "ats_1.0", "HTTP", "GET", "AK", "/v1.0/ats/files/uploadInfos", "json", req, runtime), new GetFileUploadInfoResponse());
    }

    public FinishBeginnerTaskResponse finishBeginnerTask(String taskCode, FinishBeginnerTaskRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        FinishBeginnerTaskHeaders headers = new FinishBeginnerTaskHeaders();
        return this.finishBeginnerTaskWithOptions(taskCode, request, headers, runtime);
    }

    public FinishBeginnerTaskResponse finishBeginnerTaskWithOptions(String taskCode, FinishBeginnerTaskRequest request, FinishBeginnerTaskHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        taskCode = com.aliyun.openapiutil.Client.getEncodeParam(taskCode);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scope)) {
            query.put("scope", request.scope);
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
        return TeaModel.toModel(this.doROARequest("FinishBeginnerTask", "ats_1.0", "HTTP", "POST", "AK", "/v1.0/ats/beginnerTasks/" + taskCode + "/finish", "json", req, runtime), new FinishBeginnerTaskResponse());
    }

    public GetApplicationRegFormByFlowIdResponse getApplicationRegFormByFlowId(String flowId, GetApplicationRegFormByFlowIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetApplicationRegFormByFlowIdHeaders headers = new GetApplicationRegFormByFlowIdHeaders();
        return this.getApplicationRegFormByFlowIdWithOptions(flowId, request, headers, runtime);
    }

    public GetApplicationRegFormByFlowIdResponse getApplicationRegFormByFlowIdWithOptions(String flowId, GetApplicationRegFormByFlowIdRequest request, GetApplicationRegFormByFlowIdHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        flowId = com.aliyun.openapiutil.Client.getEncodeParam(flowId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
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
        return TeaModel.toModel(this.doROARequest("GetApplicationRegFormByFlowId", "ats_1.0", "HTTP", "GET", "AK", "/v1.0/ats/flows/" + flowId + "/applicationRegForms", "json", req, runtime), new GetApplicationRegFormByFlowIdResponse());
    }

    public UpdateApplicationRegFormResponse updateApplicationRegForm(String flowId, UpdateApplicationRegFormRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateApplicationRegFormHeaders headers = new UpdateApplicationRegFormHeaders();
        return this.updateApplicationRegFormWithOptions(flowId, request, headers, runtime);
    }

    public UpdateApplicationRegFormResponse updateApplicationRegFormWithOptions(String flowId, UpdateApplicationRegFormRequest request, UpdateApplicationRegFormHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        flowId = com.aliyun.openapiutil.Client.getEncodeParam(flowId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.dingPanFile))) {
            body.put("dingPanFile", request.dingPanFile);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateApplicationRegForm", "ats_1.0", "HTTP", "PUT", "AK", "/v1.0/ats/flows/" + flowId + "/applicationRegForms", "json", req, runtime), new UpdateApplicationRegFormResponse());
    }

    public GetCandidateByPhoneNumberResponse getCandidateByPhoneNumber(GetCandidateByPhoneNumberRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetCandidateByPhoneNumberHeaders headers = new GetCandidateByPhoneNumberHeaders();
        return this.getCandidateByPhoneNumberWithOptions(request, headers, runtime);
    }

    public GetCandidateByPhoneNumberResponse getCandidateByPhoneNumberWithOptions(GetCandidateByPhoneNumberRequest request, GetCandidateByPhoneNumberHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.phoneNumber)) {
            query.put("phoneNumber", request.phoneNumber);
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
        return TeaModel.toModel(this.doROARequest("GetCandidateByPhoneNumber", "ats_1.0", "HTTP", "GET", "AK", "/v1.0/ats/candidates", "json", req, runtime), new GetCandidateByPhoneNumberResponse());
    }

    public UpdateInterviewSignInInfoResponse updateInterviewSignInInfo(String interviewId, UpdateInterviewSignInInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateInterviewSignInInfoHeaders headers = new UpdateInterviewSignInInfoHeaders();
        return this.updateInterviewSignInInfoWithOptions(interviewId, request, headers, runtime);
    }

    public UpdateInterviewSignInInfoResponse updateInterviewSignInInfoWithOptions(String interviewId, UpdateInterviewSignInInfoRequest request, UpdateInterviewSignInInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        interviewId = com.aliyun.openapiutil.Client.getEncodeParam(interviewId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.signInTimeMillis)) {
            body.put("signInTimeMillis", request.signInTimeMillis);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateInterviewSignInInfo", "ats_1.0", "HTTP", "PUT", "AK", "/v1.0/ats/interviews/" + interviewId + "/signInInfos", "none", req, runtime), new UpdateInterviewSignInInfoResponse());
    }

    public GetJobAuthResponse getJobAuth(String jobId, GetJobAuthRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetJobAuthHeaders headers = new GetJobAuthHeaders();
        return this.getJobAuthWithOptions(jobId, request, headers, runtime);
    }

    public GetJobAuthResponse getJobAuthWithOptions(String jobId, GetJobAuthRequest request, GetJobAuthHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        jobId = com.aliyun.openapiutil.Client.getEncodeParam(jobId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
        return TeaModel.toModel(this.doROARequest("GetJobAuth", "ats_1.0", "HTTP", "GET", "AK", "/v1.0/ats/auths/jobs/" + jobId + "", "json", req, runtime), new GetJobAuthResponse());
    }
}
