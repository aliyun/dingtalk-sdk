// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassScheduleConfigRequest extends TeaModel {
    // 课程id列表
    @NameInMap("classIds")
    public java.util.List<Long> classIds;

    // 操作者的UserID
    @NameInMap("opUserId")
    public String opUserId;

    public static QueryClassScheduleConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryClassScheduleConfigRequest self = new QueryClassScheduleConfigRequest();
        return TeaModel.build(map, self);
    }

    public QueryClassScheduleConfigRequest setClassIds(java.util.List<Long> classIds) {
        this.classIds = classIds;
        return this;
    }
    public java.util.List<Long> getClassIds() {
        return this.classIds;
    }

    public QueryClassScheduleConfigRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
