// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryChannelStaffInfoByMobileRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>158xxxxxxxx</p>
     */
    @NameInMap("mobile")
    public String mobile;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingxxxxxxx</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static QueryChannelStaffInfoByMobileRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryChannelStaffInfoByMobileRequest self = new QueryChannelStaffInfoByMobileRequest();
        return TeaModel.build(map, self);
    }

    public QueryChannelStaffInfoByMobileRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public QueryChannelStaffInfoByMobileRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
