// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditGoodsResponseBody extends TeaModel {
    // 编辑数据的id
    @NameInMap("msgid")
    public Long msgid;

    // 响应时间
    @NameInMap("time")
    public String time;

    public static EditGoodsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EditGoodsResponseBody self = new EditGoodsResponseBody();
        return TeaModel.build(map, self);
    }

    public EditGoodsResponseBody setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditGoodsResponseBody setTime(String time) {
        this.time = time;
        return this;
    }
    public String getTime() {
        return this.time;
    }

}
