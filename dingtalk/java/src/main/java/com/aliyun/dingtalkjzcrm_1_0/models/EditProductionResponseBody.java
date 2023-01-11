// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditProductionResponseBody extends TeaModel {
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

    public static EditProductionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EditProductionResponseBody self = new EditProductionResponseBody();
        return TeaModel.build(map, self);
    }

    public EditProductionResponseBody setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditProductionResponseBody setTime(String time) {
        this.time = time;
        return this;
    }
    public String getTime() {
        return this.time;
    }

}
