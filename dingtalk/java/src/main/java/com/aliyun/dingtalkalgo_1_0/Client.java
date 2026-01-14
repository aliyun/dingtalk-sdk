// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalgo_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkalgo_1_0.models.*;

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
     * <p>自然语言处理之关键词识别</p>
     * 
     * @param request NlpWordDistinguishRequest
     * @param headers NlpWordDistinguishHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return NlpWordDistinguishResponse
     */
    public NlpWordDistinguishResponse nlpWordDistinguishWithOptions(NlpWordDistinguishRequest request, NlpWordDistinguishHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attachExtractDecisionInfo)) {
            body.put("attachExtractDecisionInfo", request.attachExtractDecisionInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvAppId)) {
            body.put("isvAppId", request.isvAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.text)) {
            body.put("text", request.text);
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
            new TeaPair("action", "NlpWordDistinguish"),
            new TeaPair("version", "algo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/algo/okrs/keywords/extract"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new NlpWordDistinguishResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>自然语言处理之关键词识别</p>
     * 
     * @param request NlpWordDistinguishRequest
     * @return NlpWordDistinguishResponse
     */
    public NlpWordDistinguishResponse nlpWordDistinguish(NlpWordDistinguishRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        NlpWordDistinguishHeaders headers = new NlpWordDistinguishHeaders();
        return this.nlpWordDistinguishWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>Okr内容推荐</p>
     * 
     * @param request OkrOpenRecommendRequest
     * @param headers OkrOpenRecommendHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OkrOpenRecommendResponse
     */
    public OkrOpenRecommendResponse okrOpenRecommendWithOptions(OkrOpenRecommendRequest request, OkrOpenRecommendHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.candidateOkrItems)) {
            body.put("candidateOkrItems", request.candidateOkrItems);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptIds)) {
            body.put("deptIds", request.deptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvAppId)) {
            body.put("isvAppId", request.isvAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.words)) {
            body.put("words", request.words);
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
            new TeaPair("action", "OkrOpenRecommend"),
            new TeaPair("version", "algo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/algo/okrs/recommend"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OkrOpenRecommendResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>Okr内容推荐</p>
     * 
     * @param request OkrOpenRecommendRequest
     * @return OkrOpenRecommendResponse
     */
    public OkrOpenRecommendResponse okrOpenRecommend(OkrOpenRecommendRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OkrOpenRecommendHeaders headers = new OkrOpenRecommendHeaders();
        return this.okrOpenRecommendWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>魏桥铝原料预测任务查询</p>
     * 
     * @param request WeiqiaoAluminumQueryRequest
     * @param headers WeiqiaoAluminumQueryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return WeiqiaoAluminumQueryResponse
     */
    public WeiqiaoAluminumQueryResponse weiqiaoAluminumQueryWithOptions(WeiqiaoAluminumQueryRequest request, WeiqiaoAluminumQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            body.put("task_id", request.taskId);
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
            new TeaPair("action", "WeiqiaoAluminumQuery"),
            new TeaPair("version", "algo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/algo/industry/weiqiao/aluminum/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new WeiqiaoAluminumQueryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>魏桥铝原料预测任务查询</p>
     * 
     * @param request WeiqiaoAluminumQueryRequest
     * @return WeiqiaoAluminumQueryResponse
     */
    public WeiqiaoAluminumQueryResponse weiqiaoAluminumQuery(WeiqiaoAluminumQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        WeiqiaoAluminumQueryHeaders headers = new WeiqiaoAluminumQueryHeaders();
        return this.weiqiaoAluminumQueryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>魏桥铝原料预测任务提交</p>
     * 
     * @param request WeiqiaoAluminumSubmitRequest
     * @param headers WeiqiaoAluminumSubmitHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return WeiqiaoAluminumSubmitResponse
     */
    public WeiqiaoAluminumSubmitResponse weiqiaoAluminumSubmitWithOptions(WeiqiaoAluminumSubmitRequest request, WeiqiaoAluminumSubmitHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.currentFurnace)) {
            body.put("current_furnace", request.currentFurnace);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dilutionConfig)) {
            body.put("dilution_config", request.dilutionConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.historyFurnace)) {
            body.put("history_furnace", request.historyFurnace);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rawMaterials)) {
            body.put("raw_materials", request.rawMaterials);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.target)) {
            body.put("target", request.target);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetRanges)) {
            body.put("target_ranges", request.targetRanges);
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
            new TeaPair("action", "WeiqiaoAluminumSubmit"),
            new TeaPair("version", "algo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/algo/industry/weiqiao/aluminum/submit"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new WeiqiaoAluminumSubmitResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>魏桥铝原料预测任务提交</p>
     * 
     * @param request WeiqiaoAluminumSubmitRequest
     * @return WeiqiaoAluminumSubmitResponse
     */
    public WeiqiaoAluminumSubmitResponse weiqiaoAluminumSubmit(WeiqiaoAluminumSubmitRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        WeiqiaoAluminumSubmitHeaders headers = new WeiqiaoAluminumSubmitHeaders();
        return this.weiqiaoAluminumSubmitWithOptions(request, headers, runtime);
    }
}
