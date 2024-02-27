// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SpecialRuleBatchReceiverResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public java.util.List<SpecialRuleBatchReceiverResponseBodyData> data;

    @NameInMap("msg")
    public String msg;

    @NameInMap("msgId")
    public String msgId;

    @NameInMap("rows")
    public java.util.List<java.util.List<SpecialRuleBatchReceiverResponseBodyRows>> rows;

    public static SpecialRuleBatchReceiverResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SpecialRuleBatchReceiverResponseBody self = new SpecialRuleBatchReceiverResponseBody();
        return TeaModel.build(map, self);
    }

    public SpecialRuleBatchReceiverResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public SpecialRuleBatchReceiverResponseBody setData(java.util.List<SpecialRuleBatchReceiverResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<SpecialRuleBatchReceiverResponseBodyData> getData() {
        return this.data;
    }

    public SpecialRuleBatchReceiverResponseBody setMsg(String msg) {
        this.msg = msg;
        return this;
    }
    public String getMsg() {
        return this.msg;
    }

    public SpecialRuleBatchReceiverResponseBody setMsgId(String msgId) {
        this.msgId = msgId;
        return this;
    }
    public String getMsgId() {
        return this.msgId;
    }

    public SpecialRuleBatchReceiverResponseBody setRows(java.util.List<java.util.List<SpecialRuleBatchReceiverResponseBodyRows>> rows) {
        this.rows = rows;
        return this;
    }
    public java.util.List<java.util.List<SpecialRuleBatchReceiverResponseBodyRows>> getRows() {
        return this.rows;
    }

    public static class SpecialRuleBatchReceiverResponseBodyData extends TeaModel {
        @NameInMap("msgId")
        public String msgId;

        @NameInMap("serialNumber")
        public String serialNumber;

        public static SpecialRuleBatchReceiverResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            SpecialRuleBatchReceiverResponseBodyData self = new SpecialRuleBatchReceiverResponseBodyData();
            return TeaModel.build(map, self);
        }

        public SpecialRuleBatchReceiverResponseBodyData setMsgId(String msgId) {
            this.msgId = msgId;
            return this;
        }
        public String getMsgId() {
            return this.msgId;
        }

        public SpecialRuleBatchReceiverResponseBodyData setSerialNumber(String serialNumber) {
            this.serialNumber = serialNumber;
            return this;
        }
        public String getSerialNumber() {
            return this.serialNumber;
        }

    }

    public static class SpecialRuleBatchReceiverResponseBodyRows extends TeaModel {
        @NameInMap("serialNumber")
        public String serialNumber;

        @NameInMap("msgId")
        public String msgId;

        public static SpecialRuleBatchReceiverResponseBodyRows build(java.util.Map<String, ?> map) throws Exception {
            SpecialRuleBatchReceiverResponseBodyRows self = new SpecialRuleBatchReceiverResponseBodyRows();
            return TeaModel.build(map, self);
        }

        public SpecialRuleBatchReceiverResponseBodyRows setSerialNumber(String serialNumber) {
            this.serialNumber = serialNumber;
            return this;
        }
        public String getSerialNumber() {
            return this.serialNumber;
        }

        public SpecialRuleBatchReceiverResponseBodyRows setMsgId(String msgId) {
            this.msgId = msgId;
            return this;
        }
        public String getMsgId() {
            return this.msgId;
        }

    }

}
