// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbay_max_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkbay_max_1_0.models.*;

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
     * <p>Baymax技能执行日志</p>
     * 
     * @param request QueryBaymaxSkillLogRequest
     * @param headers QueryBaymaxSkillLogHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryBaymaxSkillLogResponse
     */
    public QueryBaymaxSkillLogResponse queryBaymaxSkillLogWithOptions(QueryBaymaxSkillLogRequest request, QueryBaymaxSkillLogHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.from)) {
            query.put("from", request.from);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.skillExecuteId)) {
            query.put("skillExecuteId", request.skillExecuteId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.to)) {
            query.put("to", request.to);
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
            new TeaPair("action", "QueryBaymaxSkillLog"),
            new TeaPair("version", "bayMax_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bayMax/skills/logs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryBaymaxSkillLogResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>Baymax技能执行日志</p>
     * 
     * @param request QueryBaymaxSkillLogRequest
     * @return QueryBaymaxSkillLogResponse
     */
    public QueryBaymaxSkillLogResponse queryBaymaxSkillLog(QueryBaymaxSkillLogRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryBaymaxSkillLogHeaders headers = new QueryBaymaxSkillLogHeaders();
        return this.queryBaymaxSkillLogWithOptions(request, headers, runtime);
    }
}
