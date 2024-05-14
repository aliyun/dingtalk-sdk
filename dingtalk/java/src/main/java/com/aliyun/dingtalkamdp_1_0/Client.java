// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkamdp_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkamdp_1_0.models.*;

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
     * @summary 人员数据推送
     *
     * @param request AmdpEmployeeDataPushRequest
     * @param headers AmdpEmployeeDataPushHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AmdpEmployeeDataPushResponse
     */
    public AmdpEmployeeDataPushResponse amdpEmployeeDataPushWithOptions(AmdpEmployeeDataPushRequest request, AmdpEmployeeDataPushHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.param)) {
            body.put("param", request.param);
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
            new TeaPair("action", "AmdpEmployeeDataPush"),
            new TeaPair("version", "amdp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/amdp/employees/datas/push"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AmdpEmployeeDataPushResponse());
    }

    /**
     * @summary 人员数据推送
     *
     * @param request AmdpEmployeeDataPushRequest
     * @return AmdpEmployeeDataPushResponse
     */
    public AmdpEmployeeDataPushResponse amdpEmployeeDataPush(AmdpEmployeeDataPushRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AmdpEmployeeDataPushHeaders headers = new AmdpEmployeeDataPushHeaders();
        return this.amdpEmployeeDataPushWithOptions(request, headers, runtime);
    }

    /**
     * @summary 任职数据推送
     *
     * @param request AmdpJobPositionDataPushRequest
     * @param headers AmdpJobPositionDataPushHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AmdpJobPositionDataPushResponse
     */
    public AmdpJobPositionDataPushResponse amdpJobPositionDataPushWithOptions(AmdpJobPositionDataPushRequest request, AmdpJobPositionDataPushHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.param)) {
            body.put("param", request.param);
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
            new TeaPair("action", "AmdpJobPositionDataPush"),
            new TeaPair("version", "amdp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/amdp/empJobs/datas/push"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AmdpJobPositionDataPushResponse());
    }

    /**
     * @summary 任职数据推送
     *
     * @param request AmdpJobPositionDataPushRequest
     * @return AmdpJobPositionDataPushResponse
     */
    public AmdpJobPositionDataPushResponse amdpJobPositionDataPush(AmdpJobPositionDataPushRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AmdpJobPositionDataPushHeaders headers = new AmdpJobPositionDataPushHeaders();
        return this.amdpJobPositionDataPushWithOptions(request, headers, runtime);
    }

    /**
     * @summary 组织部门数据推送
     *
     * @param request AmdpOrganizationDataPushRequest
     * @param headers AmdpOrganizationDataPushHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AmdpOrganizationDataPushResponse
     */
    public AmdpOrganizationDataPushResponse amdpOrganizationDataPushWithOptions(AmdpOrganizationDataPushRequest request, AmdpOrganizationDataPushHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.param)) {
            body.put("param", request.param);
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
            new TeaPair("action", "AmdpOrganizationDataPush"),
            new TeaPair("version", "amdp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/amdp/organizations/departments/datas/push"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AmdpOrganizationDataPushResponse());
    }

    /**
     * @summary 组织部门数据推送
     *
     * @param request AmdpOrganizationDataPushRequest
     * @return AmdpOrganizationDataPushResponse
     */
    public AmdpOrganizationDataPushResponse amdpOrganizationDataPush(AmdpOrganizationDataPushRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AmdpOrganizationDataPushHeaders headers = new AmdpOrganizationDataPushHeaders();
        return this.amdpOrganizationDataPushWithOptions(request, headers, runtime);
    }
}
