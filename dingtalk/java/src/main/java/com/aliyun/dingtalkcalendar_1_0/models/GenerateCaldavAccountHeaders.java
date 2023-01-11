// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GenerateCaldavAccountHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    /**
     * <p>授权本次调用的用户id，该字段有值时认为本次调用已被授权访问该用户可以访问的所有数据</p>
     */
    @NameInMap("dingUid")
    public String dingUid;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static GenerateCaldavAccountHeaders build(java.util.Map<String, ?> map) throws Exception {
        GenerateCaldavAccountHeaders self = new GenerateCaldavAccountHeaders();
        return TeaModel.build(map, self);
    }

    public GenerateCaldavAccountHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public GenerateCaldavAccountHeaders setDingUid(String dingUid) {
        this.dingUid = dingUid;
        return this;
    }
    public String getDingUid() {
        return this.dingUid;
    }

    public GenerateCaldavAccountHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
