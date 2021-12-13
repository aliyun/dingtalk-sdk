// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class DecodePayCodeRequest extends TeaModel {
    // payCode
    @NameInMap("payCode")
    public String payCode;

    // requestId
    @NameInMap("requestId")
    public String requestId;

    // ISV组织ID
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    // 组织ID
    @NameInMap("dingOrgId")
    public Long dingOrgId;

    public static DecodePayCodeRequest build(java.util.Map<String, ?> map) throws Exception {
        DecodePayCodeRequest self = new DecodePayCodeRequest();
        return TeaModel.build(map, self);
    }

    public DecodePayCodeRequest setPayCode(String payCode) {
        this.payCode = payCode;
        return this;
    }
    public String getPayCode() {
        return this.payCode;
    }

    public DecodePayCodeRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public DecodePayCodeRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public DecodePayCodeRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

}
