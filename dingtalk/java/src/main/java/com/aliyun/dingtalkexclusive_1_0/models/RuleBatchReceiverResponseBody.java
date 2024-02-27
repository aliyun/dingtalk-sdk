// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class RuleBatchReceiverResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public java.util.List<RuleBatchReceiverResponseBodyData> data;

    @NameInMap("msg")
    public String msg;

    @NameInMap("msgId")
    public String msgId;

    @NameInMap("rows")
    public java.util.List<java.util.List<RuleBatchReceiverResponseBodyRows>> rows;

    public static RuleBatchReceiverResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RuleBatchReceiverResponseBody self = new RuleBatchReceiverResponseBody();
        return TeaModel.build(map, self);
    }

    public RuleBatchReceiverResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public RuleBatchReceiverResponseBody setData(java.util.List<RuleBatchReceiverResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<RuleBatchReceiverResponseBodyData> getData() {
        return this.data;
    }

    public RuleBatchReceiverResponseBody setMsg(String msg) {
        this.msg = msg;
        return this;
    }
    public String getMsg() {
        return this.msg;
    }

    public RuleBatchReceiverResponseBody setMsgId(String msgId) {
        this.msgId = msgId;
        return this;
    }
    public String getMsgId() {
        return this.msgId;
    }

    public RuleBatchReceiverResponseBody setRows(java.util.List<java.util.List<RuleBatchReceiverResponseBodyRows>> rows) {
        this.rows = rows;
        return this;
    }
    public java.util.List<java.util.List<RuleBatchReceiverResponseBodyRows>> getRows() {
        return this.rows;
    }

    public static class RuleBatchReceiverResponseBodyData extends TeaModel {
        @NameInMap("msgId")
        public String msgId;

        @NameInMap("serialNumber")
        public String serialNumber;

        public static RuleBatchReceiverResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            RuleBatchReceiverResponseBodyData self = new RuleBatchReceiverResponseBodyData();
            return TeaModel.build(map, self);
        }

        public RuleBatchReceiverResponseBodyData setMsgId(String msgId) {
            this.msgId = msgId;
            return this;
        }
        public String getMsgId() {
            return this.msgId;
        }

        public RuleBatchReceiverResponseBodyData setSerialNumber(String serialNumber) {
            this.serialNumber = serialNumber;
            return this;
        }
        public String getSerialNumber() {
            return this.serialNumber;
        }

    }

    public static class RuleBatchReceiverResponseBodyRows extends TeaModel {
        @NameInMap("serialNumber")
        public String serialNumber;

        @NameInMap("msgId")
        public String msgId;

        public static RuleBatchReceiverResponseBodyRows build(java.util.Map<String, ?> map) throws Exception {
            RuleBatchReceiverResponseBodyRows self = new RuleBatchReceiverResponseBodyRows();
            return TeaModel.build(map, self);
        }

        public RuleBatchReceiverResponseBodyRows setSerialNumber(String serialNumber) {
            this.serialNumber = serialNumber;
            return this;
        }
        public String getSerialNumber() {
            return this.serialNumber;
        }

        public RuleBatchReceiverResponseBodyRows setMsgId(String msgId) {
            this.msgId = msgId;
            return this;
        }
        public String getMsgId() {
            return this.msgId;
        }

    }

}
