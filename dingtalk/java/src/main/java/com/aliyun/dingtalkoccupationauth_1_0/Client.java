// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoccupationauth_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkoccupationauth_1_0.models.*;

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
     * @summary 检查用户任务状态
     *
     * @param request CheckUserTaskStatusRequest
     * @param headers CheckUserTaskStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CheckUserTaskStatusResponse
     */
    public CheckUserTaskStatusResponse checkUserTaskStatusWithOptions(CheckUserTaskStatusRequest request, CheckUserTaskStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.provinceCode)) {
            body.put("provinceCode", request.provinceCode);
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
            new TeaPair("action", "CheckUserTaskStatus"),
            new TeaPair("version", "occupationauth_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/occupationauth/auths/userTasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CheckUserTaskStatusResponse());
    }

    /**
     * @summary 检查用户任务状态
     *
     * @param request CheckUserTaskStatusRequest
     * @return CheckUserTaskStatusResponse
     */
    public CheckUserTaskStatusResponse checkUserTaskStatus(CheckUserTaskStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CheckUserTaskStatusHeaders headers = new CheckUserTaskStatusHeaders();
        return this.checkUserTaskStatusWithOptions(request, headers, runtime);
    }

    /**
     * @summary 检查用户任务状态
     *
     * @param request CheckUserTasksStatusRequest
     * @param headers CheckUserTasksStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CheckUserTasksStatusResponse
     */
    public CheckUserTasksStatusResponse checkUserTasksStatusWithOptions(CheckUserTasksStatusRequest request, CheckUserTasksStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.provinceCode)) {
            query.put("provinceCode", request.provinceCode);
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
            new TeaPair("action", "CheckUserTasksStatus"),
            new TeaPair("version", "occupationauth_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/occupationauth/userTasks/check"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CheckUserTasksStatusResponse());
    }

    /**
     * @summary 检查用户任务状态
     *
     * @param request CheckUserTasksStatusRequest
     * @return CheckUserTasksStatusResponse
     */
    public CheckUserTasksStatusResponse checkUserTasksStatus(CheckUserTasksStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CheckUserTasksStatusHeaders headers = new CheckUserTasksStatusHeaders();
        return this.checkUserTasksStatusWithOptions(request, headers, runtime);
    }
}
