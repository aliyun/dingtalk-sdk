// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceRecordLocationShrinkRequest extends TeaModel {
    @NameInMap("locationAmountLimit")
    public Long locationAmountLimit;

    @NameInMap("recordIdList")
    public String recordIdListShrink;

    public static QueryServiceRecordLocationShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryServiceRecordLocationShrinkRequest self = new QueryServiceRecordLocationShrinkRequest();
        return TeaModel.build(map, self);
    }

    public QueryServiceRecordLocationShrinkRequest setLocationAmountLimit(Long locationAmountLimit) {
        this.locationAmountLimit = locationAmountLimit;
        return this;
    }
    public Long getLocationAmountLimit() {
        return this.locationAmountLimit;
    }

    public QueryServiceRecordLocationShrinkRequest setRecordIdListShrink(String recordIdListShrink) {
        this.recordIdListShrink = recordIdListShrink;
        return this;
    }
    public String getRecordIdListShrink() {
        return this.recordIdListShrink;
    }

}
