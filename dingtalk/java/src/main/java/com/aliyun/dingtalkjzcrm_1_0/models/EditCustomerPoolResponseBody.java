// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditCustomerPoolResponseBody extends TeaModel {
    @NameInMap("msgid")
    public Long msgid;

    @NameInMap("time")
    public String time;

    public static EditCustomerPoolResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EditCustomerPoolResponseBody self = new EditCustomerPoolResponseBody();
        return TeaModel.build(map, self);
    }

    public EditCustomerPoolResponseBody setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditCustomerPoolResponseBody setTime(String time) {
        this.time = time;
        return this;
    }
    public String getTime() {
        return this.time;
    }

}
