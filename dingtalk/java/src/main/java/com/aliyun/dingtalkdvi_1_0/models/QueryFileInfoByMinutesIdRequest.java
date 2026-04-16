// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryFileInfoByMinutesIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("minutesId")
    public String minutesId;

    public static QueryFileInfoByMinutesIdRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryFileInfoByMinutesIdRequest self = new QueryFileInfoByMinutesIdRequest();
        return TeaModel.build(map, self);
    }

    public QueryFileInfoByMinutesIdRequest setMinutesId(String minutesId) {
        this.minutesId = minutesId;
        return this;
    }
    public String getMinutesId() {
        return this.minutesId;
    }

}
