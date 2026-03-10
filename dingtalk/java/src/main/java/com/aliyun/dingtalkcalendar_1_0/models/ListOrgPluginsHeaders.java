// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListOrgPluginsHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("dingAccessTokenType")
    public String dingAccessTokenType;

    @NameInMap("dingClientId")
    public String dingClientId;

    @NameInMap("dingIsvOrgId")
    public String dingIsvOrgId;

    @NameInMap("dingOpenAppOrgId")
    public String dingOpenAppOrgId;

    @NameInMap("dingOrgId")
    public String dingOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static ListOrgPluginsHeaders build(java.util.Map<String, ?> map) throws Exception {
        ListOrgPluginsHeaders self = new ListOrgPluginsHeaders();
        return TeaModel.build(map, self);
    }

    public ListOrgPluginsHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public ListOrgPluginsHeaders setDingAccessTokenType(String dingAccessTokenType) {
        this.dingAccessTokenType = dingAccessTokenType;
        return this;
    }
    public String getDingAccessTokenType() {
        return this.dingAccessTokenType;
    }

    public ListOrgPluginsHeaders setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

    public ListOrgPluginsHeaders setDingIsvOrgId(String dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public String getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public ListOrgPluginsHeaders setDingOpenAppOrgId(String dingOpenAppOrgId) {
        this.dingOpenAppOrgId = dingOpenAppOrgId;
        return this;
    }
    public String getDingOpenAppOrgId() {
        return this.dingOpenAppOrgId;
    }

    public ListOrgPluginsHeaders setDingOrgId(String dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public String getDingOrgId() {
        return this.dingOrgId;
    }

    public ListOrgPluginsHeaders setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public ListOrgPluginsHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
