// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcredit_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcredit_1_0.models.*;

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
     * <p>查询用户金融评分数据</p>
     * 
     * @param request QueryScoreRequest
     * @param headers QueryScoreHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryScoreResponse
     */
    public QueryScoreResponse queryScoreWithOptions(QueryScoreRequest request, QueryScoreHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.encryption)) {
            query.put("encryption", request.encryption);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fullName)) {
            query.put("fullName", request.fullName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.idCardCode)) {
            query.put("idCardCode", request.idCardCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            query.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgName)) {
            query.put("orgName", request.orgName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uniScCode)) {
            query.put("uniScCode", request.uniScCode);
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
            new TeaPair("action", "QueryScore"),
            new TeaPair("version", "credit_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/credit/scores"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryScoreResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户金融评分数据</p>
     * 
     * @param request QueryScoreRequest
     * @return QueryScoreResponse
     */
    public QueryScoreResponse queryScore(QueryScoreRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryScoreHeaders headers = new QueryScoreHeaders();
        return this.queryScoreWithOptions(request, headers, runtime);
    }
}
