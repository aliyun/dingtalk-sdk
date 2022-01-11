// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwms_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkwms_1_0.models.*;
import com.aliyun.teautil.*;
import com.aliyun.teautil.models.*;
import com.aliyun.teaopenapi.*;
import com.aliyun.teaopenapi.models.*;
import com.aliyun.openapiutil.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public QueryGoodsListResponse queryGoodsList(QueryGoodsListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryGoodsListHeaders headers = new QueryGoodsListHeaders();
        return this.queryGoodsListWithOptions(request, headers, runtime);
    }

    public QueryGoodsListResponse queryGoodsListWithOptions(QueryGoodsListRequest request, QueryGoodsListHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTimeInMills)) {
            query.put("endTimeInMills", request.endTimeInMills);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTimeInMills)) {
            query.put("startTimeInMills", request.startTimeInMills);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryGoodsList", "wms_1.0", "HTTP", "GET", "AK", "/v1.0/wms/goods", "json", req, runtime), new QueryGoodsListResponse());
    }
}
