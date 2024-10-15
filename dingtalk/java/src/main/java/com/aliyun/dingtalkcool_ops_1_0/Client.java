// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_ops_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcool_ops_1_0.models.*;

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
     * <p>ISV批量查询商机标签</p>
     * 
     * @param request BatchQueryOpportunityTagRequest
     * @param headers BatchQueryOpportunityTagHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchQueryOpportunityTagResponse
     */
    public BatchQueryOpportunityTagResponse batchQueryOpportunityTagWithOptions(BatchQueryOpportunityTagRequest request, BatchQueryOpportunityTagHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpIdList)) {
            body.put("corpIdList", request.corpIdList);
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
            new TeaPair("action", "BatchQueryOpportunityTag"),
            new TeaPair("version", "coolOps_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/coolOps/isvOpportunities/opportunityTags/batchQuery"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchQueryOpportunityTagResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>ISV批量查询商机标签</p>
     * 
     * @param request BatchQueryOpportunityTagRequest
     * @return BatchQueryOpportunityTagResponse
     */
    public BatchQueryOpportunityTagResponse batchQueryOpportunityTag(BatchQueryOpportunityTagRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchQueryOpportunityTagHeaders headers = new BatchQueryOpportunityTagHeaders();
        return this.batchQueryOpportunityTagWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>ISV商机状态同步</p>
     * 
     * @param request UpdateIsvOppStatusRequest
     * @param headers UpdateIsvOppStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateIsvOppStatusResponse
     */
    public UpdateIsvOppStatusResponse updateIsvOppStatusWithOptions(UpdateIsvOppStatusRequest request, UpdateIsvOppStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isvOpportunityStatusList)) {
            body.put("isvOpportunityStatusList", request.isvOpportunityStatusList);
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
            new TeaPair("action", "UpdateIsvOppStatus"),
            new TeaPair("version", "coolOps_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/coolOps/isvOpportunities/statuses"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateIsvOppStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>ISV商机状态同步</p>
     * 
     * @param request UpdateIsvOppStatusRequest
     * @return UpdateIsvOppStatusResponse
     */
    public UpdateIsvOppStatusResponse updateIsvOppStatus(UpdateIsvOppStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateIsvOppStatusHeaders headers = new UpdateIsvOppStatusHeaders();
        return this.updateIsvOppStatusWithOptions(request, headers, runtime);
    }
}
