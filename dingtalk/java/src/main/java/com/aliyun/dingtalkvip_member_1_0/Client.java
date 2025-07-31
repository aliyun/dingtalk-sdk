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
     * <p>通过手机号直充365会员</p>
     * 
     * @param request DirectRedeemVipMemberByMobileRequest
     * @param headers DirectRedeemVipMemberByMobileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DirectRedeemVipMemberByMobileResponse
     */
    public DirectRedeemVipMemberByMobileResponse directRedeemVipMemberByMobileWithOptions(DirectRedeemVipMemberByMobileRequest request, DirectRedeemVipMemberByMobileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizRequestId)) {
            body.put("bizRequestId", request.bizRequestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.channel)) {
            body.put("channel", request.channel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingtalkId)) {
            body.put("dingtalkId", request.dingtalkId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.duration)) {
            body.put("duration", request.duration);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
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
            new TeaPair("action", "DirectRedeemVipMemberByMobile"),
            new TeaPair("version", "vipMember_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/vipMember/users/directRedeemVip"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DirectRedeemVipMemberByMobileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>通过手机号直充365会员</p>
     * 
     * @param request DirectRedeemVipMemberByMobileRequest
     * @return DirectRedeemVipMemberByMobileResponse
     */
    public DirectRedeemVipMemberByMobileResponse directRedeemVipMemberByMobile(DirectRedeemVipMemberByMobileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DirectRedeemVipMemberByMobileHeaders headers = new DirectRedeemVipMemberByMobileHeaders();
        return this.directRedeemVipMemberByMobileWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>通过虚拟订单号作废365会员权益</p>
     * 
     * @param request InvalidRedeemVipMemberByBizRequestIdRequest
     * @param headers InvalidRedeemVipMemberByBizRequestIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InvalidRedeemVipMemberByBizRequestIdResponse
     */
    public InvalidRedeemVipMemberByBizRequestIdResponse invalidRedeemVipMemberByBizRequestIdWithOptions(InvalidRedeemVipMemberByBizRequestIdRequest request, InvalidRedeemVipMemberByBizRequestIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizRequestId)) {
            body.put("bizRequestId", request.bizRequestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.channel)) {
            body.put("channel", request.channel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingtalkId)) {
            body.put("dingtalkId", request.dingtalkId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.duration)) {
            body.put("duration", request.duration);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
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
            new TeaPair("action", "InvalidRedeemVipMemberByBizRequestId"),
            new TeaPair("version", "vipMember_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/vipMember/users/invalidRedeemVip"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InvalidRedeemVipMemberByBizRequestIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>通过虚拟订单号作废365会员权益</p>
     * 
     * @param request InvalidRedeemVipMemberByBizRequestIdRequest
     * @return InvalidRedeemVipMemberByBizRequestIdResponse
     */
    public InvalidRedeemVipMemberByBizRequestIdResponse invalidRedeemVipMemberByBizRequestId(InvalidRedeemVipMemberByBizRequestIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InvalidRedeemVipMemberByBizRequestIdHeaders headers = new InvalidRedeemVipMemberByBizRequestIdHeaders();
        return this.invalidRedeemVipMemberByBizRequestIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>直充会员预校验是否满足条件</p>
     * 
     * @param request PreCheckRedeemVipMemberRequest
     * @param headers PreCheckRedeemVipMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PreCheckRedeemVipMemberResponse
     */
    public PreCheckRedeemVipMemberResponse preCheckRedeemVipMemberWithOptions(PreCheckRedeemVipMemberRequest request, PreCheckRedeemVipMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizRequestId)) {
            body.put("bizRequestId", request.bizRequestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.channel)) {
            body.put("channel", request.channel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingtalkId)) {
            body.put("dingtalkId", request.dingtalkId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.duration)) {
            body.put("duration", request.duration);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
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
            new TeaPair("action", "PreCheckRedeemVipMember"),
            new TeaPair("version", "vipMember_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/vipMember/users/preCheckRedeemVip"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PreCheckRedeemVipMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>直充会员预校验是否满足条件</p>
     * 
     * @param request PreCheckRedeemVipMemberRequest
     * @return PreCheckRedeemVipMemberResponse
     */
    public PreCheckRedeemVipMemberResponse preCheckRedeemVipMember(PreCheckRedeemVipMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PreCheckRedeemVipMemberHeaders headers = new PreCheckRedeemVipMemberHeaders();
        return this.preCheckRedeemVipMemberWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询365会员直充信息</p>
     * 
     * @param request QueryRedeemVipMemberRequest
     * @param headers QueryRedeemVipMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryRedeemVipMemberResponse
     */
    public QueryRedeemVipMemberResponse queryRedeemVipMemberWithOptions(QueryRedeemVipMemberRequest request, QueryRedeemVipMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizRequestId)) {
            body.put("bizRequestId", request.bizRequestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.channel)) {
            body.put("channel", request.channel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingtalkId)) {
            body.put("dingtalkId", request.dingtalkId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.duration)) {
            body.put("duration", request.duration);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
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
            new TeaPair("action", "QueryRedeemVipMember"),
            new TeaPair("version", "vipMember_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/vipMember/users/queryRedeemVip"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryRedeemVipMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询365会员直充信息</p>
     * 
     * @param request QueryRedeemVipMemberRequest
     * @return QueryRedeemVipMemberResponse
     */
    public QueryRedeemVipMemberResponse queryRedeemVipMember(QueryRedeemVipMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryRedeemVipMemberHeaders headers = new QueryRedeemVipMemberHeaders();
        return this.queryRedeemVipMemberWithOptions(request, headers, runtime);
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
