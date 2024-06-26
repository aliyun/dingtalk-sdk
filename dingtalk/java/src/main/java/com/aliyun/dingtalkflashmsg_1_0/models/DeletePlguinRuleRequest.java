// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class DeletePlguinRuleRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizIdList")
    public java.util.List<String> bizIdList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0847493113802787</p>
     */
    @NameInMap("userId")
    public String userId;

    public static DeletePlguinRuleRequest build(java.util.Map<String, ?> map) throws Exception {
        DeletePlguinRuleRequest self = new DeletePlguinRuleRequest();
        return TeaModel.build(map, self);
    }

    public DeletePlguinRuleRequest setBizIdList(java.util.List<String> bizIdList) {
        this.bizIdList = bizIdList;
        return this;
    }
    public java.util.List<String> getBizIdList() {
        return this.bizIdList;
    }

    public DeletePlguinRuleRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
