// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditIntostockResponseBody extends TeaModel {
    // 响应时间
    @NameInMap("time")
    public String time;

    // 编辑数据的id
    @NameInMap("msgid")
    public Long msgid;

    public static EditIntostockResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EditIntostockResponseBody self = new EditIntostockResponseBody();
        return TeaModel.build(map, self);
    }

    public EditIntostockResponseBody setTime(String time) {
        this.time = time;
        return this;
    }
    public String getTime() {
        return this.time;
    }

    public EditIntostockResponseBody setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

}
