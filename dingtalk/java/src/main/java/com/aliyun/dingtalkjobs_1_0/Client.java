// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjobs_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkjobs_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._productId = "dingtalk";
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>创建简历</p>
     * 
     * @param request CreateResumeRequest
     * @param headers CreateResumeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateResumeResponse
     */
    public CreateResumeResponse createResumeWithOptions(CreateResumeRequest request, CreateResumeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ext)) {
            body.put("ext", request.ext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.resumeDataVO)) {
            body.put("resumeDataVO", request.resumeDataVO);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scene)) {
            body.put("scene", request.scene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.types)) {
            body.put("types", request.types);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdentify)) {
            body.put("userIdentify", request.userIdentify);
        }

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
            new TeaPair("action", "CreateResume"),
            new TeaPair("version", "jobs_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jobs/resumes"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateResumeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建简历</p>
     * 
     * @param request CreateResumeRequest
     * @return CreateResumeResponse
     */
    public CreateResumeResponse createResume(CreateResumeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateResumeHeaders headers = new CreateResumeHeaders();
        return this.createResumeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>投递简历</p>
     * 
     * @param request PostResumeRequest
     * @param headers PostResumeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PostResumeResponse
     */
    public PostResumeResponse postResumeWithOptions(PostResumeRequest request, PostResumeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.jobId)) {
            body.put("jobId", request.jobId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdentify)) {
            body.put("userIdentify", request.userIdentify);
        }

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
            new TeaPair("action", "PostResume"),
            new TeaPair("version", "jobs_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jobs/resumes/post"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PostResumeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>投递简历</p>
     * 
     * @param request PostResumeRequest
     * @return PostResumeResponse
     */
    public PostResumeResponse postResume(PostResumeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PostResumeHeaders headers = new PostResumeHeaders();
        return this.postResumeWithOptions(request, headers, runtime);
    }
}
