// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListPointRulesRequest extends TeaModel {
    /**
     * <p>是否查询全员圈积分</p>
     */
    @NameInMap("isCircle")
    public Boolean isCircle;

    public static ListPointRulesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListPointRulesRequest self = new ListPointRulesRequest();
        return TeaModel.build(map, self);
    }

    public ListPointRulesRequest setIsCircle(Boolean isCircle) {
        this.isCircle = isCircle;
        return this;
    }
    public Boolean getIsCircle() {
        return this.isCircle;
    }

}
