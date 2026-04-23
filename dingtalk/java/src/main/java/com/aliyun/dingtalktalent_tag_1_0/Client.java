// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalktalent_tag_1_0.models.*;

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
     * <p>人才标签：添加员工自定义标签</p>
     * 
     * @param request TalentV2AddCustomTagRequest
     * @param headers TalentV2AddCustomTagHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TalentV2AddCustomTagResponse
     */
    public TalentV2AddCustomTagResponse talentV2AddCustomTagWithOptions(TalentV2AddCustomTagRequest request, TalentV2AddCustomTagHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sortOrder)) {
            body.put("sortOrder", request.sortOrder);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagCode)) {
            body.put("tagCode", request.tagCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagName)) {
            body.put("tagName", request.tagName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "TalentV2AddCustomTag"),
            new TeaPair("version", "talentTag_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/talentTag/talentTags/addCustomTag"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TalentV2AddCustomTagResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：添加员工自定义标签</p>
     * 
     * @param request TalentV2AddCustomTagRequest
     * @return TalentV2AddCustomTagResponse
     */
    public TalentV2AddCustomTagResponse talentV2AddCustomTag(TalentV2AddCustomTagRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TalentV2AddCustomTagHeaders headers = new TalentV2AddCustomTagHeaders();
        return this.talentV2AddCustomTagWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：添加员工客观标签</p>
     * 
     * @param request TalentV2AddObjectiveTagRequest
     * @param headers TalentV2AddObjectiveTagHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TalentV2AddObjectiveTagResponse
     */
    public TalentV2AddObjectiveTagResponse talentV2AddObjectiveTagWithOptions(TalentV2AddObjectiveTagRequest request, TalentV2AddObjectiveTagHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sortOrder)) {
            body.put("sortOrder", request.sortOrder);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagCode)) {
            body.put("tagCode", request.tagCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagName)) {
            body.put("tagName", request.tagName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "TalentV2AddObjectiveTag"),
            new TeaPair("version", "talentTag_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/talentTag/talentTags/addObjectiveTag"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TalentV2AddObjectiveTagResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：添加员工客观标签</p>
     * 
     * @param request TalentV2AddObjectiveTagRequest
     * @return TalentV2AddObjectiveTagResponse
     */
    public TalentV2AddObjectiveTagResponse talentV2AddObjectiveTag(TalentV2AddObjectiveTagRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TalentV2AddObjectiveTagHeaders headers = new TalentV2AddObjectiveTagHeaders();
        return this.talentV2AddObjectiveTagWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：添加企业个性标签</p>
     * 
     * @param request TalentV2AddPersonalityTagRequest
     * @param headers TalentV2AddPersonalityTagHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TalentV2AddPersonalityTagResponse
     */
    public TalentV2AddPersonalityTagResponse talentV2AddPersonalityTagWithOptions(TalentV2AddPersonalityTagRequest request, TalentV2AddPersonalityTagHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.categoryCode)) {
            body.put("categoryCode", request.categoryCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.categoryName)) {
            body.put("categoryName", request.categoryName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.categorySortOrder)) {
            body.put("categorySortOrder", request.categorySortOrder);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sortOrder)) {
            body.put("sortOrder", request.sortOrder);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagCode)) {
            body.put("tagCode", request.tagCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagName)) {
            body.put("tagName", request.tagName);
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
            new TeaPair("action", "TalentV2AddPersonalityTag"),
            new TeaPair("version", "talentTag_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/talentTag/talentTags/addPersonalityTag"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TalentV2AddPersonalityTagResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：添加企业个性标签</p>
     * 
     * @param request TalentV2AddPersonalityTagRequest
     * @return TalentV2AddPersonalityTagResponse
     */
    public TalentV2AddPersonalityTagResponse talentV2AddPersonalityTag(TalentV2AddPersonalityTagRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TalentV2AddPersonalityTagHeaders headers = new TalentV2AddPersonalityTagHeaders();
        return this.talentV2AddPersonalityTagWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：删除员工自定义标签并清除所有点赞记录</p>
     * 
     * @param request TalentV2DeleteCustomTagRequest
     * @param headers TalentV2DeleteCustomTagHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TalentV2DeleteCustomTagResponse
     */
    public TalentV2DeleteCustomTagResponse talentV2DeleteCustomTagWithOptions(TalentV2DeleteCustomTagRequest request, TalentV2DeleteCustomTagHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.tagCode)) {
            body.put("tagCode", request.tagCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "TalentV2DeleteCustomTag"),
            new TeaPair("version", "talentTag_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/talentTag/talentTags/deleteCustomTagWithClearLike"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TalentV2DeleteCustomTagResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：删除员工自定义标签并清除所有点赞记录</p>
     * 
     * @param request TalentV2DeleteCustomTagRequest
     * @return TalentV2DeleteCustomTagResponse
     */
    public TalentV2DeleteCustomTagResponse talentV2DeleteCustomTag(TalentV2DeleteCustomTagRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TalentV2DeleteCustomTagHeaders headers = new TalentV2DeleteCustomTagHeaders();
        return this.talentV2DeleteCustomTagWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：删除员工客观标签</p>
     * 
     * @param request TalentV2DeleteObjectiveTagRequest
     * @param headers TalentV2DeleteObjectiveTagHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TalentV2DeleteObjectiveTagResponse
     */
    public TalentV2DeleteObjectiveTagResponse talentV2DeleteObjectiveTagWithOptions(TalentV2DeleteObjectiveTagRequest request, TalentV2DeleteObjectiveTagHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.tagCode)) {
            body.put("tagCode", request.tagCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "TalentV2DeleteObjectiveTag"),
            new TeaPair("version", "talentTag_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/talentTag/talentTags/deleteObjectiveTag"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TalentV2DeleteObjectiveTagResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：删除员工客观标签</p>
     * 
     * @param request TalentV2DeleteObjectiveTagRequest
     * @return TalentV2DeleteObjectiveTagResponse
     */
    public TalentV2DeleteObjectiveTagResponse talentV2DeleteObjectiveTag(TalentV2DeleteObjectiveTagRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TalentV2DeleteObjectiveTagHeaders headers = new TalentV2DeleteObjectiveTagHeaders();
        return this.talentV2DeleteObjectiveTagWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：删除企业个性标签</p>
     * 
     * @param request TalentV2DeletePersonalityTagRequest
     * @param headers TalentV2DeletePersonalityTagHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TalentV2DeletePersonalityTagResponse
     */
    public TalentV2DeletePersonalityTagResponse talentV2DeletePersonalityTagWithOptions(TalentV2DeletePersonalityTagRequest request, TalentV2DeletePersonalityTagHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.tagCode)) {
            body.put("tagCode", request.tagCode);
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
            new TeaPair("action", "TalentV2DeletePersonalityTag"),
            new TeaPair("version", "talentTag_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/talentTag/talentTags/deletePersonalityTag"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TalentV2DeletePersonalityTagResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：删除企业个性标签</p>
     * 
     * @param request TalentV2DeletePersonalityTagRequest
     * @return TalentV2DeletePersonalityTagResponse
     */
    public TalentV2DeletePersonalityTagResponse talentV2DeletePersonalityTag(TalentV2DeletePersonalityTagRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TalentV2DeletePersonalityTagHeaders headers = new TalentV2DeletePersonalityTagHeaders();
        return this.talentV2DeletePersonalityTagWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：点赞/取消点赞标签</p>
     * 
     * @param request TalentV2LikeTagRequest
     * @param headers TalentV2LikeTagHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TalentV2LikeTagResponse
     */
    public TalentV2LikeTagResponse talentV2LikeTagWithOptions(TalentV2LikeTagRequest request, TalentV2LikeTagHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionType)) {
            body.put("actionType", request.actionType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagCode)) {
            body.put("tagCode", request.tagCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "TalentV2LikeTag"),
            new TeaPair("version", "talentTag_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/talentTag/talentTags/likeTag"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TalentV2LikeTagResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：点赞/取消点赞标签</p>
     * 
     * @param request TalentV2LikeTagRequest
     * @return TalentV2LikeTagResponse
     */
    public TalentV2LikeTagResponse talentV2LikeTag(TalentV2LikeTagRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TalentV2LikeTagHeaders headers = new TalentV2LikeTagHeaders();
        return this.talentV2LikeTagWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：查询员工自定义标签</p>
     * 
     * @param request TalentV2QueryCustomTagRequest
     * @param headers TalentV2QueryCustomTagHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TalentV2QueryCustomTagResponse
     */
    public TalentV2QueryCustomTagResponse talentV2QueryCustomTagWithOptions(TalentV2QueryCustomTagRequest request, TalentV2QueryCustomTagHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
            new TeaPair("action", "TalentV2QueryCustomTag"),
            new TeaPair("version", "talentTag_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/talentTag/talentTags/queryCustomTag"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TalentV2QueryCustomTagResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：查询员工自定义标签</p>
     * 
     * @param request TalentV2QueryCustomTagRequest
     * @return TalentV2QueryCustomTagResponse
     */
    public TalentV2QueryCustomTagResponse talentV2QueryCustomTag(TalentV2QueryCustomTagRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TalentV2QueryCustomTagHeaders headers = new TalentV2QueryCustomTagHeaders();
        return this.talentV2QueryCustomTagWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：查询员工客观标签</p>
     * 
     * @param request TalentV2QueryObjectiveTagRequest
     * @param headers TalentV2QueryObjectiveTagHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TalentV2QueryObjectiveTagResponse
     */
    public TalentV2QueryObjectiveTagResponse talentV2QueryObjectiveTagWithOptions(TalentV2QueryObjectiveTagRequest request, TalentV2QueryObjectiveTagHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
            new TeaPair("action", "TalentV2QueryObjectiveTag"),
            new TeaPair("version", "talentTag_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/talentTag/talentTags/queryObjectiveTag"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TalentV2QueryObjectiveTagResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：查询员工客观标签</p>
     * 
     * @param request TalentV2QueryObjectiveTagRequest
     * @return TalentV2QueryObjectiveTagResponse
     */
    public TalentV2QueryObjectiveTagResponse talentV2QueryObjectiveTag(TalentV2QueryObjectiveTagRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TalentV2QueryObjectiveTagHeaders headers = new TalentV2QueryObjectiveTagHeaders();
        return this.talentV2QueryObjectiveTagWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：查询企业个性标签</p>
     * 
     * @param headers TalentV2QueryPersonalityTagHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TalentV2QueryPersonalityTagResponse
     */
    public TalentV2QueryPersonalityTagResponse talentV2QueryPersonalityTagWithOptions(TalentV2QueryPersonalityTagHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "TalentV2QueryPersonalityTag"),
            new TeaPair("version", "talentTag_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/talentTag/talentTags/queryPersonalityTag"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TalentV2QueryPersonalityTagResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：查询企业个性标签</p>
     * @return TalentV2QueryPersonalityTagResponse
     */
    public TalentV2QueryPersonalityTagResponse talentV2QueryPersonalityTag() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TalentV2QueryPersonalityTagHeaders headers = new TalentV2QueryPersonalityTagHeaders();
        return this.talentV2QueryPersonalityTagWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：分页查询指定标签的点赞记录</p>
     * 
     * @param request TalentV2QueryTagLikeDetailListRequest
     * @param headers TalentV2QueryTagLikeDetailListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TalentV2QueryTagLikeDetailListResponse
     */
    public TalentV2QueryTagLikeDetailListResponse talentV2QueryTagLikeDetailListWithOptions(TalentV2QueryTagLikeDetailListRequest request, TalentV2QueryTagLikeDetailListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            query.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            query.put("size", request.size);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagCode)) {
            query.put("tagCode", request.tagCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
            new TeaPair("action", "TalentV2QueryTagLikeDetailList"),
            new TeaPair("version", "talentTag_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/talentTag/talentTags/queryTagLikeDetailList"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TalentV2QueryTagLikeDetailListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：分页查询指定标签的点赞记录</p>
     * 
     * @param request TalentV2QueryTagLikeDetailListRequest
     * @return TalentV2QueryTagLikeDetailListResponse
     */
    public TalentV2QueryTagLikeDetailListResponse talentV2QueryTagLikeDetailList(TalentV2QueryTagLikeDetailListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TalentV2QueryTagLikeDetailListHeaders headers = new TalentV2QueryTagLikeDetailListHeaders();
        return this.talentV2QueryTagLikeDetailListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：查询点赞标签列表</p>
     * 
     * @param request TalentV2QueryTagLikeListRequest
     * @param headers TalentV2QueryTagLikeListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TalentV2QueryTagLikeListResponse
     */
    public TalentV2QueryTagLikeListResponse talentV2QueryTagLikeListWithOptions(TalentV2QueryTagLikeListRequest request, TalentV2QueryTagLikeListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            query.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
            new TeaPair("action", "TalentV2QueryTagLikeList"),
            new TeaPair("version", "talentTag_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/talentTag/talentTags/queryTagLikeList"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TalentV2QueryTagLikeListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>人才标签：查询点赞标签列表</p>
     * 
     * @param request TalentV2QueryTagLikeListRequest
     * @return TalentV2QueryTagLikeListResponse
     */
    public TalentV2QueryTagLikeListResponse talentV2QueryTagLikeList(TalentV2QueryTagLikeListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TalentV2QueryTagLikeListHeaders headers = new TalentV2QueryTagLikeListHeaders();
        return this.talentV2QueryTagLikeListWithOptions(request, headers, runtime);
    }
}
