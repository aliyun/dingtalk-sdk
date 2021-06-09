// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class ParseMsgToDingTypeRequest extends TeaModel {
    // messageList
    @NameInMap("body")
    public java.util.List<ParseMsgToDingTypeRequestBody> body;

    public static ParseMsgToDingTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        ParseMsgToDingTypeRequest self = new ParseMsgToDingTypeRequest();
        return TeaModel.build(map, self);
    }

    public ParseMsgToDingTypeRequest setBody(java.util.List<ParseMsgToDingTypeRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<ParseMsgToDingTypeRequestBody> getBody() {
        return this.body;
    }

    public static class ParseMsgToDingTypeRequestBody extends TeaModel {
        @NameInMap("msgType")
        public String msgType;

        @NameInMap("content")
        public String content;

        @NameInMap("subType")
        public String subType;

        @NameInMap("extra")
        public String extra;

        public static ParseMsgToDingTypeRequestBody build(java.util.Map<String, ?> map) throws Exception {
            ParseMsgToDingTypeRequestBody self = new ParseMsgToDingTypeRequestBody();
            return TeaModel.build(map, self);
        }

        public ParseMsgToDingTypeRequestBody setMsgType(String msgType) {
            this.msgType = msgType;
            return this;
        }
        public String getMsgType() {
            return this.msgType;
        }

        public ParseMsgToDingTypeRequestBody setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public ParseMsgToDingTypeRequestBody setSubType(String subType) {
            this.subType = subType;
            return this;
        }
        public String getSubType() {
            return this.subType;
        }

        public ParseMsgToDingTypeRequestBody setExtra(String extra) {
            this.extra = extra;
            return this;
        }
        public String getExtra() {
            return this.extra;
        }

    }

}
