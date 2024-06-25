// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_phone_1_0.models;

import com.aliyun.tea.*;

public class AddCallConfigRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding3f583b067f2q450c12d</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>token12345</p>
     */
    @NameInMap("isvToken")
    public String isvToken;

    /**
     * <strong>example:</strong>
     * <p>057112345678</p>
     */
    @NameInMap("phoneNumber")
    public String phoneNumber;

    /**
     * <strong>example:</strong>
     * <p>call</p>
     */
    @NameInMap("scopeType")
    public String scopeType;

    public static AddCallConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        AddCallConfigRequest self = new AddCallConfigRequest();
        return TeaModel.build(map, self);
    }

    public AddCallConfigRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public AddCallConfigRequest setIsvToken(String isvToken) {
        this.isvToken = isvToken;
        return this;
    }
    public String getIsvToken() {
        return this.isvToken;
    }

    public AddCallConfigRequest setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
        return this;
    }
    public String getPhoneNumber() {
        return this.phoneNumber;
    }

    public AddCallConfigRequest setScopeType(String scopeType) {
        this.scopeType = scopeType;
        return this;
    }
    public String getScopeType() {
        return this.scopeType;
    }

}
