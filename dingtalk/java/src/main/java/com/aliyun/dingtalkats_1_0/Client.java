// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkats_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public com.aliyun.gateway.spi.Client _client;
    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._client = new com.aliyun.gateway.dingtalk.Client();
        this._spi = _client;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * @summary 添加应聘登记表模板
     *
     * @param request AddApplicationRegFormTemplateRequest
     * @param headers AddApplicationRegFormTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddApplicationRegFormTemplateResponse
     */
    public AddApplicationRegFormTemplateResponse addApplicationRegFormTemplateWithOptions(AddApplicationRegFormTemplateRequest request, AddApplicationRegFormTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddApplicationRegFormTemplate"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/flows/applicationRegForms/templates"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddApplicationRegFormTemplateResponse());
    }

    /**
     * @summary 添加应聘登记表模板
     *
     * @param request AddApplicationRegFormTemplateRequest
     * @return AddApplicationRegFormTemplateResponse
     */
    public AddApplicationRegFormTemplateResponse addApplicationRegFormTemplate(AddApplicationRegFormTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddApplicationRegFormTemplateHeaders headers = new AddApplicationRegFormTemplateHeaders();
        return this.addApplicationRegFormTemplateWithOptions(request, headers, runtime);
    }

    /**
     * @summary 添加钉盘文件
     *
     * @param request AddFileRequest
     * @param headers AddFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddFileResponse
     */
    public AddFileResponse addFileWithOptions(AddFileRequest request, AddFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fileName)) {
            body.put("fileName", request.fileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
        }

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
            new TeaPair("action", "AddFile"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/files"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddFileResponse());
    }

    /**
     * @summary 添加钉盘文件
     *
     * @param request AddFileRequest
     * @return AddFileResponse
     */
    public AddFileResponse addFile(AddFileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddFileHeaders headers = new AddFileHeaders();
        return this.addFileWithOptions(request, headers, runtime);
    }

    /**
     * @summary 添加渠道个人账号
     *
     * @param request AddUserAccountRequest
     * @param headers AddUserAccountHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddUserAccountResponse
     */
    public AddUserAccountResponse addUserAccountWithOptions(AddUserAccountRequest request, AddUserAccountHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channelAccountName)) {
            body.put("channelAccountName", request.channelAccountName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.channelUserIdentify)) {
            body.put("channelUserIdentify", request.channelUserIdentify);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.phoneNumber)) {
            body.put("phoneNumber", request.phoneNumber);
        }

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
            new TeaPair("action", "AddUserAccount"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/channels/users/accounts"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddUserAccountResponse());
    }

    /**
     * @summary 添加渠道个人账号
     *
     * @param request AddUserAccountRequest
     * @return AddUserAccountResponse
     */
    public AddUserAccountResponse addUserAccount(AddUserAccountRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddUserAccountHeaders headers = new AddUserAccountHeaders();
        return this.addUserAccountWithOptions(request, headers, runtime);
    }

    /**
     * @summary 渠道招聘职位需求导入
     *
     * @param request CollectRecruitJobDetailRequest
     * @param headers CollectRecruitJobDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollectRecruitJobDetailResponse
     */
    public CollectRecruitJobDetailResponse collectRecruitJobDetailWithOptions(CollectRecruitJobDetailRequest request, CollectRecruitJobDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channel)) {
            body.put("channel", request.channel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jobInfo)) {
            body.put("jobInfo", request.jobInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outCorpId)) {
            body.put("outCorpId", request.outCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outCorpName)) {
            body.put("outCorpName", request.outCorpName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.recruitUserInfo)) {
            body.put("recruitUserInfo", request.recruitUserInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.updateTime)) {
            body.put("updateTime", request.updateTime);
        }

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
            new TeaPair("action", "CollectRecruitJobDetail"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/channels/jobs/import"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollectRecruitJobDetailResponse());
    }

    /**
     * @summary 渠道招聘职位需求导入
     *
     * @param request CollectRecruitJobDetailRequest
     * @return CollectRecruitJobDetailResponse
     */
    public CollectRecruitJobDetailResponse collectRecruitJobDetail(CollectRecruitJobDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollectRecruitJobDetailHeaders headers = new CollectRecruitJobDetailHeaders();
        return this.collectRecruitJobDetailWithOptions(request, headers, runtime);
    }

    /**
     * @summary 结构化简历信息回流
     *
     * @param request CollectResumeDetailRequest
     * @param headers CollectResumeDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollectResumeDetailResponse
     */
    public CollectResumeDetailResponse collectResumeDetailWithOptions(CollectResumeDetailRequest request, CollectResumeDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channelCode)) {
            body.put("channelCode", request.channelCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.channelOuterId)) {
            body.put("channelOuterId", request.channelOuterId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.channelTalentId)) {
            body.put("channelTalentId", request.channelTalentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deliverJobId)) {
            body.put("deliverJobId", request.deliverJobId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.optUserId)) {
            body.put("optUserId", request.optUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.resumeChannelUrl)) {
            body.put("resumeChannelUrl", request.resumeChannelUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.resumeData)) {
            body.put("resumeData", request.resumeData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.resumeFile)) {
            body.put("resumeFile", request.resumeFile);
        }

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
            new TeaPair("action", "CollectResumeDetail"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/resumes/details"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollectResumeDetailResponse());
    }

    /**
     * @summary 结构化简历信息回流
     *
     * @param request CollectResumeDetailRequest
     * @return CollectResumeDetailResponse
     */
    public CollectResumeDetailResponse collectResumeDetail(CollectResumeDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollectResumeDetailHeaders headers = new CollectResumeDetailHeaders();
        return this.collectResumeDetailWithOptions(request, headers, runtime);
    }

    /**
     * @summary 邮箱简历回流
     *
     * @param request CollectResumeMailRequest
     * @param headers CollectResumeMailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollectResumeMailResponse
     */
    public CollectResumeMailResponse collectResumeMailWithOptions(CollectResumeMailRequest request, CollectResumeMailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channelCode)) {
            body.put("channelCode", request.channelCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deliverJobId)) {
            body.put("deliverJobId", request.deliverJobId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fromMailAddress)) {
            body.put("fromMailAddress", request.fromMailAddress);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.historyMailImport)) {
            body.put("historyMailImport", request.historyMailImport);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mailId)) {
            body.put("mailId", request.mailId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mailTitle)) {
            body.put("mailTitle", request.mailTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.optUserId)) {
            body.put("optUserId", request.optUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiveMailAddress)) {
            body.put("receiveMailAddress", request.receiveMailAddress);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiveMailType)) {
            body.put("receiveMailType", request.receiveMailType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receivedTime)) {
            body.put("receivedTime", request.receivedTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.resumeChannelUrl)) {
            body.put("resumeChannelUrl", request.resumeChannelUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.resumeFile)) {
            body.put("resumeFile", request.resumeFile);
        }

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
            new TeaPair("action", "CollectResumeMail"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/resumes/mails"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollectResumeMailResponse());
    }

    /**
     * @summary 邮箱简历回流
     *
     * @param request CollectResumeMailRequest
     * @return CollectResumeMailResponse
     */
    public CollectResumeMailResponse collectResumeMail(CollectResumeMailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollectResumeMailHeaders headers = new CollectResumeMailHeaders();
        return this.collectResumeMailWithOptions(request, headers, runtime);
    }

    /**
     * @summary 确认权益
     *
     * @param request ConfirmRightsRequest
     * @param headers ConfirmRightsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ConfirmRightsResponse
     */
    public ConfirmRightsResponse confirmRightsWithOptions(String rightsCode, ConfirmRightsRequest request, ConfirmRightsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

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
            new TeaPair("action", "ConfirmRights"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/rights/" + rightsCode + "/confirm"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ConfirmRightsResponse());
    }

    /**
     * @summary 确认权益
     *
     * @param request ConfirmRightsRequest
     * @return ConfirmRightsResponse
     */
    public ConfirmRightsResponse confirmRights(String rightsCode, ConfirmRightsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ConfirmRightsHeaders headers = new ConfirmRightsHeaders();
        return this.confirmRightsWithOptions(rightsCode, request, headers, runtime);
    }

    /**
     * @summary 完成指定的新手任务
     *
     * @param request FinishBeginnerTaskRequest
     * @param headers FinishBeginnerTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return FinishBeginnerTaskResponse
     */
    public FinishBeginnerTaskResponse finishBeginnerTaskWithOptions(String taskCode, FinishBeginnerTaskRequest request, FinishBeginnerTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.scope)) {
            query.put("scope", request.scope);
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
            new TeaPair("action", "FinishBeginnerTask"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/beginnerTasks/" + taskCode + "/finish"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new FinishBeginnerTaskResponse());
    }

    /**
     * @summary 完成指定的新手任务
     *
     * @param request FinishBeginnerTaskRequest
     * @return FinishBeginnerTaskResponse
     */
    public FinishBeginnerTaskResponse finishBeginnerTask(String taskCode, FinishBeginnerTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        FinishBeginnerTaskHeaders headers = new FinishBeginnerTaskHeaders();
        return this.finishBeginnerTaskWithOptions(taskCode, request, headers, runtime);
    }

    /**
     * @summary 获取招聘流程关联的应聘登记表信息
     *
     * @param request GetApplicationRegFormByFlowIdRequest
     * @param headers GetApplicationRegFormByFlowIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetApplicationRegFormByFlowIdResponse
     */
    public GetApplicationRegFormByFlowIdResponse getApplicationRegFormByFlowIdWithOptions(String flowId, GetApplicationRegFormByFlowIdRequest request, GetApplicationRegFormByFlowIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

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
            new TeaPair("action", "GetApplicationRegFormByFlowId"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/flows/" + flowId + "/applicationRegForms"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetApplicationRegFormByFlowIdResponse());
    }

    /**
     * @summary 获取招聘流程关联的应聘登记表信息
     *
     * @param request GetApplicationRegFormByFlowIdRequest
     * @return GetApplicationRegFormByFlowIdResponse
     */
    public GetApplicationRegFormByFlowIdResponse getApplicationRegFormByFlowId(String flowId, GetApplicationRegFormByFlowIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetApplicationRegFormByFlowIdHeaders headers = new GetApplicationRegFormByFlowIdHeaders();
        return this.getApplicationRegFormByFlowIdWithOptions(flowId, request, headers, runtime);
    }

    /**
     * @summary 根据手机号获取候选人信息
     *
     * @param request GetCandidateByPhoneNumberRequest
     * @param headers GetCandidateByPhoneNumberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCandidateByPhoneNumberResponse
     */
    public GetCandidateByPhoneNumberResponse getCandidateByPhoneNumberWithOptions(GetCandidateByPhoneNumberRequest request, GetCandidateByPhoneNumberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetCandidateByPhoneNumber"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/candidates"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCandidateByPhoneNumberResponse());
    }

    /**
     * @summary 根据手机号获取候选人信息
     *
     * @param request GetCandidateByPhoneNumberRequest
     * @return GetCandidateByPhoneNumberResponse
     */
    public GetCandidateByPhoneNumberResponse getCandidateByPhoneNumber(GetCandidateByPhoneNumberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCandidateByPhoneNumberHeaders headers = new GetCandidateByPhoneNumberHeaders();
        return this.getCandidateByPhoneNumberWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取钉盘上传文件信息
     *
     * @param request GetFileUploadInfoRequest
     * @param headers GetFileUploadInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFileUploadInfoResponse
     */
    public GetFileUploadInfoResponse getFileUploadInfoWithOptions(GetFileUploadInfoRequest request, GetFileUploadInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetFileUploadInfo"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/files/uploadInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFileUploadInfoResponse());
    }

    /**
     * @summary 获取钉盘上传文件信息
     *
     * @param request GetFileUploadInfoRequest
     * @return GetFileUploadInfoResponse
     */
    public GetFileUploadInfoResponse getFileUploadInfo(GetFileUploadInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFileUploadInfoHeaders headers = new GetFileUploadInfoHeaders();
        return this.getFileUploadInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 根据招聘流程关联的实体标识获取招聘流程标识
     *
     * @param request GetFlowIdByRelationEntityIdRequest
     * @param headers GetFlowIdByRelationEntityIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFlowIdByRelationEntityIdResponse
     */
    public GetFlowIdByRelationEntityIdResponse getFlowIdByRelationEntityIdWithOptions(GetFlowIdByRelationEntityIdRequest request, GetFlowIdByRelationEntityIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetFlowIdByRelationEntityId"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/flows/ids"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFlowIdByRelationEntityIdResponse());
    }

    /**
     * @summary 根据招聘流程关联的实体标识获取招聘流程标识
     *
     * @param request GetFlowIdByRelationEntityIdRequest
     * @return GetFlowIdByRelationEntityIdResponse
     */
    public GetFlowIdByRelationEntityIdResponse getFlowIdByRelationEntityId(GetFlowIdByRelationEntityIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFlowIdByRelationEntityIdHeaders headers = new GetFlowIdByRelationEntityIdHeaders();
        return this.getFlowIdByRelationEntityIdWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取职位信息
     *
     * @param request GetJobAuthRequest
     * @param headers GetJobAuthHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetJobAuthResponse
     */
    public GetJobAuthResponse getJobAuthWithOptions(String jobId, GetJobAuthRequest request, GetJobAuthHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetJobAuth"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/auths/jobs/" + jobId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetJobAuthResponse());
    }

    /**
     * @summary 获取职位信息
     *
     * @param request GetJobAuthRequest
     * @return GetJobAuthResponse
     */
    public GetJobAuthResponse getJobAuth(String jobId, GetJobAuthRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetJobAuthHeaders headers = new GetJobAuthHeaders();
        return this.getJobAuthWithOptions(jobId, request, headers, runtime);
    }

    /**
     * @summary 查询候选人详情列表
     *
     * @param request QueryCandidatesRequest
     * @param headers QueryCandidatesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCandidatesResponse
     */
    public QueryCandidatesResponse queryCandidatesWithOptions(QueryCandidatesRequest request, QueryCandidatesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.statId)) {
            body.put("statId", request.statId);
        }

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
            new TeaPair("action", "QueryCandidates"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/candidates/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCandidatesResponse());
    }

    /**
     * @summary 查询候选人详情列表
     *
     * @param request QueryCandidatesRequest
     * @return QueryCandidatesResponse
     */
    public QueryCandidatesResponse queryCandidates(QueryCandidatesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCandidatesHeaders headers = new QueryCandidatesHeaders();
        return this.queryCandidatesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询面试列表
     *
     * @param request QueryInterviewsRequest
     * @param headers QueryInterviewsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryInterviewsResponse
     */
    public QueryInterviewsResponse queryInterviewsWithOptions(QueryInterviewsRequest request, QueryInterviewsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        if (!com.aliyun.teautil.Common.isUnset(request.candidateId)) {
            body.put("candidateId", request.candidateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTimeBeginMillis)) {
            body.put("startTimeBeginMillis", request.startTimeBeginMillis);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTimeEndMillis)) {
            body.put("startTimeEndMillis", request.startTimeEndMillis);
        }

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
            new TeaPair("action", "QueryInterviews"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/interviews/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryInterviewsResponse());
    }

    /**
     * @summary 查询面试列表
     *
     * @param request QueryInterviewsRequest
     * @return QueryInterviewsResponse
     */
    public QueryInterviewsResponse queryInterviews(QueryInterviewsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryInterviewsHeaders headers = new QueryInterviewsHeaders();
        return this.queryInterviewsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 反馈渠道消息状态
     *
     * @param request ReportMessageStatusRequest
     * @param headers ReportMessageStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ReportMessageStatusResponse
     */
    public ReportMessageStatusResponse reportMessageStatusWithOptions(ReportMessageStatusRequest request, ReportMessageStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channel)) {
            body.put("channel", request.channel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.errorCode)) {
            body.put("errorCode", request.errorCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.errorMsg)) {
            body.put("errorMsg", request.errorMsg);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.messageId)) {
            body.put("messageId", request.messageId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUserId)) {
            body.put("receiverUserId", request.receiverUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.senderUserId)) {
            body.put("senderUserId", request.senderUserId);
        }

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
            new TeaPair("action", "ReportMessageStatus"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/channels/messages/statuses/report"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ReportMessageStatusResponse());
    }

    /**
     * @summary 反馈渠道消息状态
     *
     * @param request ReportMessageStatusRequest
     * @return ReportMessageStatusResponse
     */
    public ReportMessageStatusResponse reportMessageStatus(ReportMessageStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReportMessageStatusHeaders headers = new ReportMessageStatusHeaders();
        return this.reportMessageStatusWithOptions(request, headers, runtime);
    }

    /**
     * @summary 同步渠道IM消息
     *
     * @param request SyncChannelMessageRequest
     * @param headers SyncChannelMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SyncChannelMessageResponse
     */
    public SyncChannelMessageResponse syncChannelMessageWithOptions(SyncChannelMessageRequest request, SyncChannelMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channel)) {
            body.put("channel", request.channel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createTime)) {
            body.put("createTime", request.createTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUserId)) {
            body.put("receiverUserId", request.receiverUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.senderUserId)) {
            body.put("senderUserId", request.senderUserId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SyncChannelMessage"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/channels/messages/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncChannelMessageResponse());
    }

    /**
     * @summary 同步渠道IM消息
     *
     * @param request SyncChannelMessageRequest
     * @return SyncChannelMessageResponse
     */
    public SyncChannelMessageResponse syncChannelMessage(SyncChannelMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncChannelMessageHeaders headers = new SyncChannelMessageHeaders();
        return this.syncChannelMessageWithOptions(request, headers, runtime);
    }

    /**
     * @summary 更新应聘登记表内容
     *
     * @param request UpdateApplicationRegFormRequest
     * @param headers UpdateApplicationRegFormHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateApplicationRegFormResponse
     */
    public UpdateApplicationRegFormResponse updateApplicationRegFormWithOptions(String flowId, UpdateApplicationRegFormRequest request, UpdateApplicationRegFormHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingPanFile)) {
            body.put("dingPanFile", request.dingPanFile);
        }

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
            new TeaPair("action", "UpdateApplicationRegForm"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/flows/" + flowId + "/applicationRegForms"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateApplicationRegFormResponse());
    }

    /**
     * @summary 更新应聘登记表内容
     *
     * @param request UpdateApplicationRegFormRequest
     * @return UpdateApplicationRegFormResponse
     */
    public UpdateApplicationRegFormResponse updateApplicationRegForm(String flowId, UpdateApplicationRegFormRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateApplicationRegFormHeaders headers = new UpdateApplicationRegFormHeaders();
        return this.updateApplicationRegFormWithOptions(flowId, request, headers, runtime);
    }

    /**
     * @summary 更新面试签到信息
     *
     * @param request UpdateInterviewSignInInfoRequest
     * @param headers UpdateInterviewSignInInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInterviewSignInInfoResponse
     */
    public UpdateInterviewSignInInfoResponse updateInterviewSignInInfoWithOptions(String interviewId, UpdateInterviewSignInInfoRequest request, UpdateInterviewSignInInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateInterviewSignInInfo"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/interviews/" + interviewId + "/signInInfos"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateInterviewSignInInfoResponse());
    }

    /**
     * @summary 更新面试签到信息
     *
     * @param request UpdateInterviewSignInInfoRequest
     * @return UpdateInterviewSignInInfoResponse
     */
    public UpdateInterviewSignInInfoResponse updateInterviewSignInInfo(String interviewId, UpdateInterviewSignInInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInterviewSignInInfoHeaders headers = new UpdateInterviewSignInInfoHeaders();
        return this.updateInterviewSignInInfoWithOptions(interviewId, request, headers, runtime);
    }

    /**
     * @summary 渠道侧职位发布状态变更回调
     *
     * @param request UpdateJobDeliverRequest
     * @param headers UpdateJobDeliverHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateJobDeliverResponse
     */
    public UpdateJobDeliverResponse updateJobDeliverWithOptions(UpdateJobDeliverRequest request, UpdateJobDeliverHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jobId)) {
            query.put("jobId", request.jobId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channelOuterId)) {
            body.put("channelOuterId", request.channelOuterId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deliverUserId)) {
            body.put("deliverUserId", request.deliverUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.errorCode)) {
            body.put("errorCode", request.errorCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.errorMsg)) {
            body.put("errorMsg", request.errorMsg);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opTime)) {
            body.put("opTime", request.opTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

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
            new TeaPair("action", "UpdateJobDeliver"),
            new TeaPair("version", "ats_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/ats/jobs/deliveryStatus"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateJobDeliverResponse());
    }

    /**
     * @summary 渠道侧职位发布状态变更回调
     *
     * @param request UpdateJobDeliverRequest
     * @return UpdateJobDeliverResponse
     */
    public UpdateJobDeliverResponse updateJobDeliver(UpdateJobDeliverRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateJobDeliverHeaders headers = new UpdateJobDeliverHeaders();
        return this.updateJobDeliverWithOptions(request, headers, runtime);
    }
}
