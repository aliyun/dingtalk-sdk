// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkapp_market_1_0.models.*;
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


    public UserTaskReportResponse userTaskReport(UserTaskReportRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UserTaskReportHeaders headers = new UserTaskReportHeaders();
        return this.userTaskReportWithOptions(request, headers, runtime);
    }

    public UserTaskReportResponse userTaskReportWithOptions(UserTaskReportRequest request, UserTaskReportHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskTag)) {
            body.put("taskTag", request.taskTag);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateDate)) {
            body.put("operateDate", request.operateDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userid)) {
            body.put("userid", request.userid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizNo)) {
            body.put("bizNo", request.bizNo);
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
        return TeaModel.toModel(this.doROARequest("UserTaskReport", "appMarket_1.0", "HTTP", "POST", "AK", "/v1.0/appMarket/tasks", "boolean", req, runtime), new UserTaskReportResponse());
    }
}
