// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditContactResponseBody extends TeaModel {
    // 响应时间
    @NameInMap("time")
    public String time;

    // 编辑数据的id
    @NameInMap("msgid")
    public Long msgid;

    public static EditContactResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EditContactResponseBody self = new EditContactResponseBody();
        return TeaModel.build(map, self);
    }

    public EditContactResponseBody setTime(String time) {
        this.time = time;
        return this;
    }
    public String getTime() {
        return this.time;
    }

    public EditContactResponseBody setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

}
