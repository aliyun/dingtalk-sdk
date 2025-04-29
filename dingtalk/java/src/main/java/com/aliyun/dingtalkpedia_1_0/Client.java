// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkpedia_1_0.models.*;

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
     * <p>企业百科增加当前企业词条信息</p>
     * 
     * @param request PediaWordsAddRequest
     * @param headers PediaWordsAddHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PediaWordsAddResponse
     */
    public PediaWordsAddResponse pediaWordsAddWithOptions(PediaWordsAddRequest request, PediaWordsAddHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.contactList)) {
            body.put("contactList", request.contactList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.highLightWordAlias)) {
            body.put("highLightWordAlias", request.highLightWordAlias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.picList)) {
            body.put("picList", request.picList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relatedDoc)) {
            body.put("relatedDoc", request.relatedDoc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relatedLink)) {
            body.put("relatedLink", request.relatedLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.wordAlias)) {
            body.put("wordAlias", request.wordAlias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.wordName)) {
            body.put("wordName", request.wordName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.wordParaphrase)) {
            body.put("wordParaphrase", request.wordParaphrase);
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
            new TeaPair("action", "PediaWordsAdd"),
            new TeaPair("version", "pedia_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/pedia/words"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PediaWordsAddResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>企业百科增加当前企业词条信息</p>
     * 
     * @param request PediaWordsAddRequest
     * @return PediaWordsAddResponse
     */
    public PediaWordsAddResponse pediaWordsAdd(PediaWordsAddRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PediaWordsAddHeaders headers = new PediaWordsAddHeaders();
        return this.pediaWordsAddWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>企业百科针对待审核词条进行审核</p>
     * 
     * @param request PediaWordsApproveRequest
     * @param headers PediaWordsApproveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PediaWordsApproveResponse
     */
    public PediaWordsApproveResponse pediaWordsApproveWithOptions(PediaWordsApproveRequest request, PediaWordsApproveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.aliDocHighLight)) {
            body.put("aliDocHighLight", request.aliDocHighLight);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.approveReason)) {
            body.put("approveReason", request.approveReason);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.approveStatus)) {
            body.put("approveStatus", request.approveStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imHighLight)) {
            body.put("imHighLight", request.imHighLight);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.simHighLight)) {
            body.put("simHighLight", request.simHighLight);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
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
            new TeaPair("action", "PediaWordsApprove"),
            new TeaPair("version", "pedia_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/pedia/words/approve"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PediaWordsApproveResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>企业百科针对待审核词条进行审核</p>
     * 
     * @param request PediaWordsApproveRequest
     * @return PediaWordsApproveResponse
     */
    public PediaWordsApproveResponse pediaWordsApprove(PediaWordsApproveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PediaWordsApproveHeaders headers = new PediaWordsApproveHeaders();
        return this.pediaWordsApproveWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>企业百科针对uuid删除当前词条</p>
     * 
     * @param request PediaWordsDeleteRequest
     * @param headers PediaWordsDeleteHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PediaWordsDeleteResponse
     */
    public PediaWordsDeleteResponse pediaWordsDeleteWithOptions(PediaWordsDeleteRequest request, PediaWordsDeleteHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            query.put("uuid", request.uuid);
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
            new TeaPair("action", "PediaWordsDelete"),
            new TeaPair("version", "pedia_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/pedia/words"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PediaWordsDeleteResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>企业百科针对uuid删除当前词条</p>
     * 
     * @param request PediaWordsDeleteRequest
     * @return PediaWordsDeleteResponse
     */
    public PediaWordsDeleteResponse pediaWordsDelete(PediaWordsDeleteRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PediaWordsDeleteHeaders headers = new PediaWordsDeleteHeaders();
        return this.pediaWordsDeleteWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据词条主键ID查询当前词条详情</p>
     * 
     * @param request PediaWordsQueryRequest
     * @param headers PediaWordsQueryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PediaWordsQueryResponse
     */
    public PediaWordsQueryResponse pediaWordsQueryWithOptions(PediaWordsQueryRequest request, PediaWordsQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            query.put("uuid", request.uuid);
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
            new TeaPair("action", "PediaWordsQuery"),
            new TeaPair("version", "pedia_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/pedia/words/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PediaWordsQueryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据词条主键ID查询当前词条详情</p>
     * 
     * @param request PediaWordsQueryRequest
     * @return PediaWordsQueryResponse
     */
    public PediaWordsQueryResponse pediaWordsQuery(PediaWordsQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PediaWordsQueryHeaders headers = new PediaWordsQueryHeaders();
        return this.pediaWordsQueryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页获取企业词条信息</p>
     * 
     * @param request PediaWordsSearchRequest
     * @param headers PediaWordsSearchHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PediaWordsSearchResponse
     */
    public PediaWordsSearchResponse pediaWordsSearchWithOptions(PediaWordsSearchRequest request, PediaWordsSearchHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.wordName)) {
            body.put("wordName", request.wordName);
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
            new TeaPair("action", "PediaWordsSearch"),
            new TeaPair("version", "pedia_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/pedia/words/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PediaWordsSearchResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页获取企业词条信息</p>
     * 
     * @param request PediaWordsSearchRequest
     * @return PediaWordsSearchResponse
     */
    public PediaWordsSearchResponse pediaWordsSearch(PediaWordsSearchRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PediaWordsSearchHeaders headers = new PediaWordsSearchHeaders();
        return this.pediaWordsSearchWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>企业百科对当前已经生效词条进行编辑</p>
     * 
     * @param request PediaWordsUpdateRequest
     * @param headers PediaWordsUpdateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PediaWordsUpdateResponse
     */
    public PediaWordsUpdateResponse pediaWordsUpdateWithOptions(PediaWordsUpdateRequest request, PediaWordsUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appLink)) {
            body.put("appLink", request.appLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contactList)) {
            body.put("contactList", request.contactList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.highLightWordAlias)) {
            body.put("highLightWordAlias", request.highLightWordAlias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.picList)) {
            body.put("picList", request.picList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relatedDoc)) {
            body.put("relatedDoc", request.relatedDoc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relatedLink)) {
            body.put("relatedLink", request.relatedLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.wordAlias)) {
            body.put("wordAlias", request.wordAlias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.wordName)) {
            body.put("wordName", request.wordName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.wordParaphrase)) {
            body.put("wordParaphrase", request.wordParaphrase);
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
            new TeaPair("action", "PediaWordsUpdate"),
            new TeaPair("version", "pedia_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/pedia/words"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PediaWordsUpdateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>企业百科对当前已经生效词条进行编辑</p>
     * 
     * @param request PediaWordsUpdateRequest
     * @return PediaWordsUpdateResponse
     */
    public PediaWordsUpdateResponse pediaWordsUpdate(PediaWordsUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PediaWordsUpdateHeaders headers = new PediaWordsUpdateHeaders();
        return this.pediaWordsUpdateWithOptions(request, headers, runtime);
    }
}
