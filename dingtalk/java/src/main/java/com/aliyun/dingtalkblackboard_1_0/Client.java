// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkblackboard_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkblackboard_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public QueryBlackboardSpaceResponse queryBlackboardSpace(QueryBlackboardSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryBlackboardSpaceHeaders headers = new QueryBlackboardSpaceHeaders();
        return this.queryBlackboardSpaceWithOptions(request, headers, runtime);
    }

    public QueryBlackboardSpaceResponse queryBlackboardSpaceWithOptions(QueryBlackboardSpaceRequest request, QueryBlackboardSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operationUserId)) {
            query.put("operationUserId", request.operationUserId);
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
        return TeaModel.toModel(this.doROARequest("QueryBlackboardSpace", "blackboard_1.0", "HTTP", "GET", "AK", "/v1.0/blackboard/spaces", "json", req, runtime), new QueryBlackboardSpaceResponse());
    }
}
