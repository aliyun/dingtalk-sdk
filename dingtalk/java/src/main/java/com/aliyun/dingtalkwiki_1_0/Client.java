// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkwiki_1_0.models.*;

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
     * <p>根据词条名称获取该词条释义</p>
     * 
     * @param request WikiWordsDetailRequest
     * @param headers WikiWordsDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return WikiWordsDetailResponse
     */
    public WikiWordsDetailResponse wikiWordsDetailWithOptions(WikiWordsDetailRequest request, WikiWordsDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.wordName)) {
            query.put("wordName", request.wordName);
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
            new TeaPair("action", "WikiWordsDetail"),
            new TeaPair("version", "wiki_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/wiki/words/details"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new WikiWordsDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据词条名称获取该词条释义</p>
     * 
     * @param request WikiWordsDetailRequest
     * @return WikiWordsDetailResponse
     */
    public WikiWordsDetailResponse wikiWordsDetail(WikiWordsDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        WikiWordsDetailHeaders headers = new WikiWordsDetailHeaders();
        return this.wikiWordsDetailWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>外部传递过来的消息根据百科词库分词</p>
     * 
     * @param request WikiWordsParseRequest
     * @param headers WikiWordsParseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return WikiWordsParseResponse
     */
    public WikiWordsParseResponse wikiWordsParseWithOptions(WikiWordsParseRequest request, WikiWordsParseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
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
            new TeaPair("action", "WikiWordsParse"),
            new TeaPair("version", "wiki_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/wiki/words/parse"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new WikiWordsParseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>外部传递过来的消息根据百科词库分词</p>
     * 
     * @param request WikiWordsParseRequest
     * @return WikiWordsParseResponse
     */
    public WikiWordsParseResponse wikiWordsParse(WikiWordsParseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        WikiWordsParseHeaders headers = new WikiWordsParseHeaders();
        return this.wikiWordsParseWithOptions(request, headers, runtime);
    }
}
