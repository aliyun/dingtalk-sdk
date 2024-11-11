// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvip_member_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkvip_member_1_0.models.*;

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
     * <p>查询365会员信息</p>
     * 
     * @param request QueryVipMemberInfoRequest
     * @param headers QueryVipMemberInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryVipMemberInfoResponse
     */
    public QueryVipMemberInfoResponse queryVipMemberInfoWithOptions(QueryVipMemberInfoRequest request, QueryVipMemberInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channelCode)) {
            body.put("channelCode", request.channelCode);
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
            new TeaPair("action", "QueryVipMemberInfo"),
            new TeaPair("version", "vipMember_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/vipMember/users/memberInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryVipMemberInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询365会员信息</p>
     * 
     * @param request QueryVipMemberInfoRequest
     * @return QueryVipMemberInfoResponse
     */
    public QueryVipMemberInfoResponse queryVipMemberInfo(QueryVipMemberInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryVipMemberInfoHeaders headers = new QueryVipMemberInfoHeaders();
        return this.queryVipMemberInfoWithOptions(request, headers, runtime);
    }
}
