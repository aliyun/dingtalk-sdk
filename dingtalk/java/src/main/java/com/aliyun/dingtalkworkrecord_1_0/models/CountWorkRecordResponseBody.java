// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkrecord_1_0.models;

import com.aliyun.tea.*;

public class CountWorkRecordResponseBody extends TeaModel {
    @NameInMap("undoCount")
    public Long undoCount;

    public static CountWorkRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CountWorkRecordResponseBody self = new CountWorkRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public CountWorkRecordResponseBody setUndoCount(Long undoCount) {
        this.undoCount = undoCount;
        return this;
    }
    public Long getUndoCount() {
        return this.undoCount;
    }

}
