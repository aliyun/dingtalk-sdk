// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class DeleteBookingBlacklistRequest extends TeaModel {
    @NameInMap("blacklistUnionIds")
    public java.util.List<String> blacklistUnionIds;

    @NameInMap("unionId")
    public String unionId;

    public static DeleteBookingBlacklistRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteBookingBlacklistRequest self = new DeleteBookingBlacklistRequest();
        return TeaModel.build(map, self);
    }

    public DeleteBookingBlacklistRequest setBlacklistUnionIds(java.util.List<String> blacklistUnionIds) {
        this.blacklistUnionIds = blacklistUnionIds;
        return this;
    }
    public java.util.List<String> getBlacklistUnionIds() {
        return this.blacklistUnionIds;
    }

    public DeleteBookingBlacklistRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
