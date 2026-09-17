// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryAttachmentRequest extends TeaModel {
    @NameInMap("attachmentType")
    public String attachmentType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("businessId")
    public String businessId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryAttachmentRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAttachmentRequest self = new QueryAttachmentRequest();
        return TeaModel.build(map, self);
    }

    public QueryAttachmentRequest setAttachmentType(String attachmentType) {
        this.attachmentType = attachmentType;
        return this;
    }
    public String getAttachmentType() {
        return this.attachmentType;
    }

    public QueryAttachmentRequest setBusinessId(String businessId) {
        this.businessId = businessId;
        return this;
    }
    public String getBusinessId() {
        return this.businessId;
    }

    public QueryAttachmentRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
