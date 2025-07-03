// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalksalary_1_0.models.*;

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
     * <p>小微薪酬获取薪资记录</p>
     * 
     * @param request GetSalaryCalculationRequest
     * @param headers GetSalaryCalculationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSalaryCalculationResponse
     */
    public GetSalaryCalculationResponse getSalaryCalculationWithOptions(GetSalaryCalculationRequest request, GetSalaryCalculationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.date)) {
            query.put("date", request.date);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.salaryGroupId)) {
            query.put("salaryGroupId", request.salaryGroupId);
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
            new TeaPair("action", "GetSalaryCalculation"),
            new TeaPair("version", "salary_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/salary/calculation"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSalaryCalculationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>小微薪酬获取薪资记录</p>
     * 
     * @param request GetSalaryCalculationRequest
     * @return GetSalaryCalculationResponse
     */
    public GetSalaryCalculationResponse getSalaryCalculation(GetSalaryCalculationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSalaryCalculationHeaders headers = new GetSalaryCalculationHeaders();
        return this.getSalaryCalculationWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>小微薪酬获取薪资组</p>
     * 
     * @param headers GetSalaryGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSalaryGroupResponse
     */
    public GetSalaryGroupResponse getSalaryGroupWithOptions(GetSalaryGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetSalaryGroup"),
            new TeaPair("version", "salary_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/salary/group"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSalaryGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>小微薪酬获取薪资组</p>
     * @return GetSalaryGroupResponse
     */
    public GetSalaryGroupResponse getSalaryGroup() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSalaryGroupHeaders headers = new GetSalaryGroupHeaders();
        return this.getSalaryGroupWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>小微薪酬获取薪资项目</p>
     * 
     * @param request GetSalaryItemRequest
     * @param headers GetSalaryItemHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSalaryItemResponse
     */
    public GetSalaryItemResponse getSalaryItemWithOptions(GetSalaryItemRequest request, GetSalaryItemHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.salaryItemGroupId)) {
            query.put("salaryItemGroupId", request.salaryItemGroupId);
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
            new TeaPair("action", "GetSalaryItem"),
            new TeaPair("version", "salary_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/salary/item"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSalaryItemResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>小微薪酬获取薪资项目</p>
     * 
     * @param request GetSalaryItemRequest
     * @return GetSalaryItemResponse
     */
    public GetSalaryItemResponse getSalaryItem(GetSalaryItemRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSalaryItemHeaders headers = new GetSalaryItemHeaders();
        return this.getSalaryItemWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>小微薪酬获取薪资项目大类</p>
     * 
     * @param headers GetSalaryItemGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSalaryItemGroupResponse
     */
    public GetSalaryItemGroupResponse getSalaryItemGroupWithOptions(GetSalaryItemGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetSalaryItemGroup"),
            new TeaPair("version", "salary_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/salary/itemGroup"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSalaryItemGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>小微薪酬获取薪资项目大类</p>
     * @return GetSalaryItemGroupResponse
     */
    public GetSalaryItemGroupResponse getSalaryItemGroup() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSalaryItemGroupHeaders headers = new GetSalaryItemGroupHeaders();
        return this.getSalaryItemGroupWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>小微薪酬获取薪资记录数据</p>
     * 
     * @param request ListSalaryCalculationRequest
     * @param headers ListSalaryCalculationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListSalaryCalculationResponse
     */
    public ListSalaryCalculationResponse listSalaryCalculationWithOptions(ListSalaryCalculationRequest request, ListSalaryCalculationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.date)) {
            body.put("date", request.date);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageIndex)) {
            body.put("pageIndex", request.pageIndex);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.salaryGroupId)) {
            body.put("salaryGroupId", request.salaryGroupId);
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
            new TeaPair("action", "ListSalaryCalculation"),
            new TeaPair("version", "salary_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/salary/calculation"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListSalaryCalculationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>小微薪酬获取薪资记录数据</p>
     * 
     * @param request ListSalaryCalculationRequest
     * @return ListSalaryCalculationResponse
     */
    public ListSalaryCalculationResponse listSalaryCalculation(ListSalaryCalculationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListSalaryCalculationHeaders headers = new ListSalaryCalculationHeaders();
        return this.listSalaryCalculationWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>小微薪酬获取薪资记录写入</p>
     * 
     * @param request WriteSalaryCalculationRequest
     * @param headers WriteSalaryCalculationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return WriteSalaryCalculationResponse
     */
    public WriteSalaryCalculationResponse writeSalaryCalculationWithOptions(WriteSalaryCalculationRequest request, WriteSalaryCalculationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.date)) {
            body.put("date", request.date);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.items)) {
            body.put("items", request.items);
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
            new TeaPair("action", "WriteSalaryCalculation"),
            new TeaPair("version", "salary_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/salary/calculation/write"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new WriteSalaryCalculationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>小微薪酬获取薪资记录写入</p>
     * 
     * @param request WriteSalaryCalculationRequest
     * @return WriteSalaryCalculationResponse
     */
    public WriteSalaryCalculationResponse writeSalaryCalculation(WriteSalaryCalculationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        WriteSalaryCalculationHeaders headers = new WriteSalaryCalculationHeaders();
        return this.writeSalaryCalculationWithOptions(request, headers, runtime);
    }
}
