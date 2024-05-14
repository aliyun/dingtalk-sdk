// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassScheduleConfigShrinkRequest extends TeaModel {
    @NameInMap("classIds")
    public String classIdsShrink;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static QueryClassScheduleConfigShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryClassScheduleConfigShrinkRequest self = new QueryClassScheduleConfigShrinkRequest();
        return TeaModel.build(map, self);
    }

    public QueryClassScheduleConfigShrinkRequest setClassIdsShrink(String classIdsShrink) {
        this.classIdsShrink = classIdsShrink;
        return this;
    }
    public String getClassIdsShrink() {
        return this.classIdsShrink;
    }

    public QueryClassScheduleConfigShrinkRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
