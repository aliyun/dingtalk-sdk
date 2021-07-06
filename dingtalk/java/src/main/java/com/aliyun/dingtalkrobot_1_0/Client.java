// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkrobot_1_0.models.*;
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


    public BatchSendOTOResponse batchSendOTO(BatchSendOTORequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchSendOTOHeaders headers = new BatchSendOTOHeaders();
        return this.batchSendOTOWithOptions(request, headers, runtime);
    }

    public BatchSendOTOResponse batchSendOTOWithOptions(BatchSendOTORequest request, BatchSendOTOHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgKey)) {
            body.put("msgKey", request.msgKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgParam)) {
            body.put("msgParam", request.msgParam);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("BatchSendOTO", "robot_1.0", "HTTP", "POST", "AK", "/v1.0/robot/oToMessages/batchSend", "json", req, runtime), new BatchSendOTOResponse());
    }

    public BatchOTOQueryResponse batchOTOQuery(BatchOTOQueryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchOTOQueryHeaders headers = new BatchOTOQueryHeaders();
        return this.batchOTOQueryWithOptions(request, headers, runtime);
    }

    public BatchOTOQueryResponse batchOTOQueryWithOptions(BatchOTOQueryRequest request, BatchOTOQueryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            query.put("robotCode", request.robotCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processQueryKey)) {
            query.put("processQueryKey", request.processQueryKey);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("BatchOTOQuery", "robot_1.0", "HTTP", "GET", "AK", "/v1.0/robot/oToMessages/readStatus", "json", req, runtime), new BatchOTOQueryResponse());
    }
}
