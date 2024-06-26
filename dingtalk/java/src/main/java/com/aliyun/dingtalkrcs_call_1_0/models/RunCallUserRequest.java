// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrcs_call_1_0.models;

import com.aliyun.tea.*;

public class RunCallUserRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>corpidxxxxx</p>
     */
    @NameInMap("authorizeCorpId")
    public String authorizeCorpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxxxx</p>
     */
    @NameInMap("authorizeUserId")
    public String authorizeUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxxx</p>
     */
    @NameInMap("orderId")
    public String orderId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxxx</p>
     */
    @NameInMap("userId")
    public String userId;

    public static RunCallUserRequest build(java.util.Map<String, ?> map) throws Exception {
        RunCallUserRequest self = new RunCallUserRequest();
        return TeaModel.build(map, self);
    }

    public RunCallUserRequest setAuthorizeCorpId(String authorizeCorpId) {
        this.authorizeCorpId = authorizeCorpId;
        return this;
    }
    public String getAuthorizeCorpId() {
        return this.authorizeCorpId;
    }

    public RunCallUserRequest setAuthorizeUserId(String authorizeUserId) {
        this.authorizeUserId = authorizeUserId;
        return this;
    }
    public String getAuthorizeUserId() {
        return this.authorizeUserId;
    }

    public RunCallUserRequest setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

    public RunCallUserRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
