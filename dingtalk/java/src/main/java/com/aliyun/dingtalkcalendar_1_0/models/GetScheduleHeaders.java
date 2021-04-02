// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetScheduleHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    // 授权本次调用的企业id，该字段有值时认为本次调用已被授权访问该企业下的所有数据
    @NameInMap("dingOrgId")
    public String dingOrgId;

    // 授权本次调用的用户id，该字段有值时认为本次调用已被授权访问该用户可以访问的所有数据
    @NameInMap("dingUid")
    public String dingUid;

    // 授权类型
    @NameInMap("dingAccessTokenType")
    public String dingAccessTokenType;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static GetScheduleHeaders build(java.util.Map<String, ?> map) throws Exception {
        GetScheduleHeaders self = new GetScheduleHeaders();
        return TeaModel.build(map, self);
    }

    public GetScheduleHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public GetScheduleHeaders setDingOrgId(String dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public String getDingOrgId() {
        return this.dingOrgId;
    }

    public GetScheduleHeaders setDingUid(String dingUid) {
        this.dingUid = dingUid;
        return this;
    }
    public String getDingUid() {
        return this.dingUid;
    }

    public GetScheduleHeaders setDingAccessTokenType(String dingAccessTokenType) {
        this.dingAccessTokenType = dingAccessTokenType;
        return this;
    }
    public String getDingAccessTokenType() {
        return this.dingAccessTokenType;
    }

    public GetScheduleHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
