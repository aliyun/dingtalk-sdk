// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class DelOrgAccUserOwnnessRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2</p>
     */
    @NameInMap("ownenssType")
    public Long ownenssType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123456</p>
     */
    @NameInMap("ownnessId")
    public Long ownnessId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("userId")
    public String userId;

    public static DelOrgAccUserOwnnessRequest build(java.util.Map<String, ?> map) throws Exception {
        DelOrgAccUserOwnnessRequest self = new DelOrgAccUserOwnnessRequest();
        return TeaModel.build(map, self);
    }

    public DelOrgAccUserOwnnessRequest setOwnenssType(Long ownenssType) {
        this.ownenssType = ownenssType;
        return this;
    }
    public Long getOwnenssType() {
        return this.ownenssType;
    }

    public DelOrgAccUserOwnnessRequest setOwnnessId(Long ownnessId) {
        this.ownnessId = ownnessId;
        return this;
    }
    public Long getOwnnessId() {
        return this.ownnessId;
    }

    public DelOrgAccUserOwnnessRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
