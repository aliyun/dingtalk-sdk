// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditQuotationRecordResponseBody extends TeaModel {
    @NameInMap("msgid")
    public Long msgid;

    @NameInMap("time")
    public String time;

    public static EditQuotationRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EditQuotationRecordResponseBody self = new EditQuotationRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public EditQuotationRecordResponseBody setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditQuotationRecordResponseBody setTime(String time) {
        this.time = time;
        return this;
    }
    public String getTime() {
        return this.time;
    }

}
