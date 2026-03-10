// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class GetShanhuiAttachmentsRequest extends TeaModel {
    @NameInMap("shanhuiKey")
    public String shanhuiKey;

    @NameInMap("userId")
    public String userId;

    public static GetShanhuiAttachmentsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetShanhuiAttachmentsRequest self = new GetShanhuiAttachmentsRequest();
        return TeaModel.build(map, self);
    }

    public GetShanhuiAttachmentsRequest setShanhuiKey(String shanhuiKey) {
        this.shanhuiKey = shanhuiKey;
        return this;
    }
    public String getShanhuiKey() {
        return this.shanhuiKey;
    }

    public GetShanhuiAttachmentsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
