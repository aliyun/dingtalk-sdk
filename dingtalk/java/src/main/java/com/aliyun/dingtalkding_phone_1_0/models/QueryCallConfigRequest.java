// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_phone_1_0.models;

import com.aliyun.tea.*;

public class QueryCallConfigRequest extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("isvToken")
    public String isvToken;

    @NameInMap("phoneNumber")
    public String phoneNumber;

    @NameInMap("scopeType")
    public String scopeType;

    public static QueryCallConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCallConfigRequest self = new QueryCallConfigRequest();
        return TeaModel.build(map, self);
    }

    public QueryCallConfigRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryCallConfigRequest setIsvToken(String isvToken) {
        this.isvToken = isvToken;
        return this;
    }
    public String getIsvToken() {
        return this.isvToken;
    }

    public QueryCallConfigRequest setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
        return this;
    }
    public String getPhoneNumber() {
        return this.phoneNumber;
    }

    public QueryCallConfigRequest setScopeType(String scopeType) {
        this.scopeType = scopeType;
        return this;
    }
    public String getScopeType() {
        return this.scopeType;
    }

}
