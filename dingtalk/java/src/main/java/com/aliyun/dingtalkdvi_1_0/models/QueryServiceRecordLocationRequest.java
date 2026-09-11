// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceRecordLocationRequest extends TeaModel {
    @NameInMap("locationAmountLimit")
    public Long locationAmountLimit;

    @NameInMap("recordIdList")
    public java.util.List<String> recordIdList;

    public static QueryServiceRecordLocationRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryServiceRecordLocationRequest self = new QueryServiceRecordLocationRequest();
        return TeaModel.build(map, self);
    }

    public QueryServiceRecordLocationRequest setLocationAmountLimit(Long locationAmountLimit) {
        this.locationAmountLimit = locationAmountLimit;
        return this;
    }
    public Long getLocationAmountLimit() {
        return this.locationAmountLimit;
    }

    public QueryServiceRecordLocationRequest setRecordIdList(java.util.List<String> recordIdList) {
        this.recordIdList = recordIdList;
        return this;
    }
    public java.util.List<String> getRecordIdList() {
        return this.recordIdList;
    }

}
