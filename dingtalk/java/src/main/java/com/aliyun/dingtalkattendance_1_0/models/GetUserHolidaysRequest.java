// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetUserHolidaysRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("workDateFrom")
    public Long workDateFrom;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("workDateTo")
    public Long workDateTo;

    public static GetUserHolidaysRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserHolidaysRequest self = new GetUserHolidaysRequest();
        return TeaModel.build(map, self);
    }

    public GetUserHolidaysRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

    public GetUserHolidaysRequest setWorkDateFrom(Long workDateFrom) {
        this.workDateFrom = workDateFrom;
        return this;
    }
    public Long getWorkDateFrom() {
        return this.workDateFrom;
    }

    public GetUserHolidaysRequest setWorkDateTo(Long workDateTo) {
        this.workDateTo = workDateTo;
        return this;
    }
    public Long getWorkDateTo() {
        return this.workDateTo;
    }

}
