// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditOrderResponseBody extends TeaModel {
    // 编辑数据的id
    @NameInMap("msgid")
    public Long msgid;

    // 响应时间
    @NameInMap("time")
    public String time;

    public static EditOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EditOrderResponseBody self = new EditOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public EditOrderResponseBody setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditOrderResponseBody setTime(String time) {
        this.time = time;
        return this;
    }
    public String getTime() {
        return this.time;
    }

}
