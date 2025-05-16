// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ImportGroupChatResponseBody extends TeaModel {
    @NameInMap("result")
    public ImportGroupChatResponseBodyResult result;

    @NameInMap("success")
    public String success;

    public static ImportGroupChatResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ImportGroupChatResponseBody self = new ImportGroupChatResponseBody();
        return TeaModel.build(map, self);
    }

    public ImportGroupChatResponseBody setResult(ImportGroupChatResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ImportGroupChatResponseBodyResult getResult() {
        return this.result;
    }

    public ImportGroupChatResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class ImportGroupChatResponseBodyResult extends TeaModel {
        @NameInMap("openConversationId")
        public String openConversationId;

        public static ImportGroupChatResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ImportGroupChatResponseBodyResult self = new ImportGroupChatResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ImportGroupChatResponseBodyResult setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

    }

}
