// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditExchangeResponseBody extends TeaModel {
    // 响应时间
    @NameInMap("time")
    public String time;

    // 编辑数据的id
    @NameInMap("msgid")
    public Long msgid;

    public static EditExchangeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EditExchangeResponseBody self = new EditExchangeResponseBody();
        return TeaModel.build(map, self);
    }

    public EditExchangeResponseBody setTime(String time) {
        this.time = time;
        return this;
    }
    public String getTime() {
        return this.time;
    }

    public EditExchangeResponseBody setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

}
