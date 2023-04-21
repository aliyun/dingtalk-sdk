// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkpedia_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public PediaWordsAddResponse pediaWordsAdd(PediaWordsAddRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PediaWordsAddHeaders headers = new PediaWordsAddHeaders();
        return this.pediaWordsAddWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("PediaWordsAdd", "pedia_1.0", "HTTP", "POST", "AK", "/v1.0/pedia/words", "json", req, runtime), new PediaWordsAddResponse());
    }

    public PediaWordsApproveResponse pediaWordsApprove(PediaWordsApproveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PediaWordsApproveHeaders headers = new PediaWordsApproveHeaders();
        return this.pediaWordsApproveWithOptions(request, headers, runtime);
    }

    public PediaWordsApproveResponse pediaWordsApproveWithOptions(PediaWordsApproveRequest request, PediaWordsApproveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
        return TeaModel.toModel(this.doROARequest("PediaWordsApprove", "pedia_1.0", "HTTP", "POST", "AK", "/v1.0/pedia/words/approve", "json", req, runtime), new PediaWordsApproveResponse());
    }

    public PediaWordsDeleteResponse pediaWordsDelete(PediaWordsDeleteRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PediaWordsDeleteHeaders headers = new PediaWordsDeleteHeaders();
        return this.pediaWordsDeleteWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("PediaWordsDelete", "pedia_1.0", "HTTP", "DELETE", "AK", "/v1.0/pedia/words", "json", req, runtime), new PediaWordsDeleteResponse());
    }

    public PediaWordsQueryResponse pediaWordsQuery(PediaWordsQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PediaWordsQueryHeaders headers = new PediaWordsQueryHeaders();
        return this.pediaWordsQueryWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("PediaWordsQuery", "pedia_1.0", "HTTP", "POST", "AK", "/v1.0/pedia/words/query", "json", req, runtime), new PediaWordsQueryResponse());
    }

    public PediaWordsSearchResponse pediaWordsSearch(PediaWordsSearchRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PediaWordsSearchHeaders headers = new PediaWordsSearchHeaders();
        return this.pediaWordsSearchWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("PediaWordsSearch", "pedia_1.0", "HTTP", "POST", "AK", "/v1.0/pedia/words/search", "json", req, runtime), new PediaWordsSearchResponse());
    }

    public PediaWordsUpdateResponse pediaWordsUpdate(PediaWordsUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PediaWordsUpdateHeaders headers = new PediaWordsUpdateHeaders();
        return this.pediaWordsUpdateWithOptions(request, headers, runtime);
    }

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
        return TeaModel.toModel(this.doROARequest("PediaWordsUpdate", "pedia_1.0", "HTTP", "PUT", "AK", "/v1.0/pedia/words", "json", req, runtime), new PediaWordsUpdateResponse());
    }
}
