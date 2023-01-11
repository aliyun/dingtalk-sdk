// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditContactResponseBody extends TeaModel {
    /**
     * <p>编辑数据的id</p>
     */
    @NameInMap("msgid")
    public Long msgid;

    /**
     * <p>响应时间</p>
     */
    @NameInMap("time")
    public String time;

    public static EditContactResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EditContactResponseBody self = new EditContactResponseBody();
        return TeaModel.build(map, self);
    }

    public EditContactResponseBody setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditContactResponseBody setTime(String time) {
        this.time = time;
        return this;
    }
    public String getTime() {
        return this.time;
    }

}
