// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcarbon_1_0.models.*;

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
     * @summary 获取用户的减碳明细
     *
     * @param request GetPersonalCarbonInfoRequest
     * @param headers GetPersonalCarbonInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPersonalCarbonInfoResponse
     */
    public GetPersonalCarbonInfoResponse getPersonalCarbonInfoWithOptions(GetPersonalCarbonInfoRequest request, GetPersonalCarbonInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionType)) {
            query.put("actionType", request.actionType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "GetPersonalCarbonInfo"),
            new TeaPair("version", "carbon_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/carbon/personals/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPersonalCarbonInfoResponse());
    }

    /**
     * @summary 获取用户的减碳明细
     *
     * @param request GetPersonalCarbonInfoRequest
     * @return GetPersonalCarbonInfoResponse
     */
    public GetPersonalCarbonInfoResponse getPersonalCarbonInfo(GetPersonalCarbonInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPersonalCarbonInfoHeaders headers = new GetPersonalCarbonInfoHeaders();
        return this.getPersonalCarbonInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 写入阿里巴巴每日组织明细碳能量数据
     *
     * @param request WriteAlibabaOrgCarbonRequest
     * @param headers WriteAlibabaOrgCarbonHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return WriteAlibabaOrgCarbonResponse
     */
    public WriteAlibabaOrgCarbonResponse writeAlibabaOrgCarbonWithOptions(WriteAlibabaOrgCarbonRequest request, WriteAlibabaOrgCarbonHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.orgDetailsList)) {
            body.put("orgDetailsList", request.orgDetailsList);
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
            new TeaPair("action", "WriteAlibabaOrgCarbon"),
            new TeaPair("version", "carbon_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/carbon/alibabaOrgDetails/write"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new WriteAlibabaOrgCarbonResponse());
    }

    /**
     * @summary 写入阿里巴巴每日组织明细碳能量数据
     *
     * @param request WriteAlibabaOrgCarbonRequest
     * @return WriteAlibabaOrgCarbonResponse
     */
    public WriteAlibabaOrgCarbonResponse writeAlibabaOrgCarbon(WriteAlibabaOrgCarbonRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        WriteAlibabaOrgCarbonHeaders headers = new WriteAlibabaOrgCarbonHeaders();
        return this.writeAlibabaOrgCarbonWithOptions(request, headers, runtime);
    }

    /**
     * @summary 写入阿里巴巴每日用户碳能量数据
     *
     * @param request WriteAlibabaUserCarbonRequest
     * @param headers WriteAlibabaUserCarbonHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return WriteAlibabaUserCarbonResponse
     */
    public WriteAlibabaUserCarbonResponse writeAlibabaUserCarbonWithOptions(WriteAlibabaUserCarbonRequest request, WriteAlibabaUserCarbonHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userDetailsList)) {
            body.put("userDetailsList", request.userDetailsList);
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
            new TeaPair("action", "WriteAlibabaUserCarbon"),
            new TeaPair("version", "carbon_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/carbon/alibabaUserDetails/write"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new WriteAlibabaUserCarbonResponse());
    }

    /**
     * @summary 写入阿里巴巴每日用户碳能量数据
     *
     * @param request WriteAlibabaUserCarbonRequest
     * @return WriteAlibabaUserCarbonResponse
     */
    public WriteAlibabaUserCarbonResponse writeAlibabaUserCarbon(WriteAlibabaUserCarbonRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        WriteAlibabaUserCarbonHeaders headers = new WriteAlibabaUserCarbonHeaders();
        return this.writeAlibabaUserCarbonWithOptions(request, headers, runtime);
    }

    /**
     * @summary ISV记录数据传输当前状态
     *
     * @param request WriteIsvStateRequest
     * @param headers WriteIsvStateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return WriteIsvStateResponse
     */
    public WriteIsvStateResponse writeIsvStateWithOptions(WriteIsvStateRequest request, WriteIsvStateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isvName)) {
            query.put("isvName", request.isvName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.statDate)) {
            query.put("statDate", request.statDate);
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
            new TeaPair("action", "WriteIsvState"),
            new TeaPair("version", "carbon_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/carbon/datas/states/write"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new WriteIsvStateResponse());
    }

    /**
     * @summary ISV记录数据传输当前状态
     *
     * @param request WriteIsvStateRequest
     * @return WriteIsvStateResponse
     */
    public WriteIsvStateResponse writeIsvState(WriteIsvStateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        WriteIsvStateHeaders headers = new WriteIsvStateHeaders();
        return this.writeIsvStateWithOptions(request, headers, runtime);
    }

    /**
     * @summary 写入isv每日组织明细碳能量数据
     *
     * @param request WriteOrgCarbonRequest
     * @param headers WriteOrgCarbonHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return WriteOrgCarbonResponse
     */
    public WriteOrgCarbonResponse writeOrgCarbonWithOptions(WriteOrgCarbonRequest request, WriteOrgCarbonHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.orgDetailsList)) {
            body.put("orgDetailsList", request.orgDetailsList);
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
            new TeaPair("action", "WriteOrgCarbon"),
            new TeaPair("version", "carbon_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/carbon/orgDetails/write"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new WriteOrgCarbonResponse());
    }

    /**
     * @summary 写入isv每日组织明细碳能量数据
     *
     * @param request WriteOrgCarbonRequest
     * @return WriteOrgCarbonResponse
     */
    public WriteOrgCarbonResponse writeOrgCarbon(WriteOrgCarbonRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        WriteOrgCarbonHeaders headers = new WriteOrgCarbonHeaders();
        return this.writeOrgCarbonWithOptions(request, headers, runtime);
    }

    /**
     * @summary 写入isv每日用户明细碳能量数据
     *
     * @param request WriteUserCarbonRequest
     * @param headers WriteUserCarbonHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return WriteUserCarbonResponse
     */
    public WriteUserCarbonResponse writeUserCarbonWithOptions(WriteUserCarbonRequest request, WriteUserCarbonHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userDetailsList)) {
            body.put("userDetailsList", request.userDetailsList);
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
            new TeaPair("action", "WriteUserCarbon"),
            new TeaPair("version", "carbon_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/carbon/userDetails/write"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new WriteUserCarbonResponse());
    }

    /**
     * @summary 写入isv每日用户明细碳能量数据
     *
     * @param request WriteUserCarbonRequest
     * @return WriteUserCarbonResponse
     */
    public WriteUserCarbonResponse writeUserCarbon(WriteUserCarbonRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        WriteUserCarbonHeaders headers = new WriteUserCarbonHeaders();
        return this.writeUserCarbonWithOptions(request, headers, runtime);
    }

    /**
     * @summary 写入isv能耗每日用户明细碳能量数据
     *
     * @param request WriteUserCarbonEnergyRequest
     * @param headers WriteUserCarbonEnergyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return WriteUserCarbonEnergyResponse
     */
    public WriteUserCarbonEnergyResponse writeUserCarbonEnergyWithOptions(WriteUserCarbonEnergyRequest request, WriteUserCarbonEnergyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userDetailsList)) {
            body.put("userDetailsList", request.userDetailsList);
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
            new TeaPair("action", "WriteUserCarbonEnergy"),
            new TeaPair("version", "carbon_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/carbon/userDetails/energies/write"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new WriteUserCarbonEnergyResponse());
    }

    /**
     * @summary 写入isv能耗每日用户明细碳能量数据
     *
     * @param request WriteUserCarbonEnergyRequest
     * @return WriteUserCarbonEnergyResponse
     */
    public WriteUserCarbonEnergyResponse writeUserCarbonEnergy(WriteUserCarbonEnergyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        WriteUserCarbonEnergyHeaders headers = new WriteUserCarbonEnergyHeaders();
        return this.writeUserCarbonEnergyWithOptions(request, headers, runtime);
    }
}
