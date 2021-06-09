// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class ParseMsgToDingTypeResponseBody extends TeaModel {
    // result
    @NameInMap("result")
    public java.util.List<ParseMsgToDingTypeResponseBodyResult> result;

    public static ParseMsgToDingTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ParseMsgToDingTypeResponseBody self = new ParseMsgToDingTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public ParseMsgToDingTypeResponseBody setResult(java.util.List<ParseMsgToDingTypeResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ParseMsgToDingTypeResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ParseMsgToDingTypeResponseBodyResult extends TeaModel {
        // subType
        @NameInMap("subType")
        public String subType;

        // extra
        @NameInMap("extra")
        public String extra;

        // content
        @NameInMap("content")
        public String content;

        // msgType
        @NameInMap("msgType")
        public String msgType;

        public static ParseMsgToDingTypeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ParseMsgToDingTypeResponseBodyResult self = new ParseMsgToDingTypeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ParseMsgToDingTypeResponseBodyResult setSubType(String subType) {
            this.subType = subType;
            return this;
        }
        public String getSubType() {
            return this.subType;
        }

        public ParseMsgToDingTypeResponseBodyResult setExtra(String extra) {
            this.extra = extra;
            return this;
        }
        public String getExtra() {
            return this.extra;
        }

        public ParseMsgToDingTypeResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public ParseMsgToDingTypeResponseBodyResult setMsgType(String msgType) {
            this.msgType = msgType;
            return this;
        }
        public String getMsgType() {
            return this.msgType;
        }

    }

}
