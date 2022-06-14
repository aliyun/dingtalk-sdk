// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class CreateDeviceChatRoomResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateDeviceChatRoomResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CreateDeviceChatRoomResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateDeviceChatRoomResponseBody self = new CreateDeviceChatRoomResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateDeviceChatRoomResponseBody setResult(CreateDeviceChatRoomResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateDeviceChatRoomResponseBodyResult getResult() {
        return this.result;
    }

    public CreateDeviceChatRoomResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CreateDeviceChatRoomResponseBodyResult extends TeaModel {
        @NameInMap("chatId")
        public String chatId;

        @NameInMap("encodedCid")
        public String encodedCid;

        @NameInMap("openConversationId")
        public String openConversationId;

        public static CreateDeviceChatRoomResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateDeviceChatRoomResponseBodyResult self = new CreateDeviceChatRoomResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateDeviceChatRoomResponseBodyResult setChatId(String chatId) {
            this.chatId = chatId;
            return this;
        }
        public String getChatId() {
            return this.chatId;
        }

        public CreateDeviceChatRoomResponseBodyResult setEncodedCid(String encodedCid) {
            this.encodedCid = encodedCid;
            return this;
        }
        public String getEncodedCid() {
            return this.encodedCid;
        }

        public CreateDeviceChatRoomResponseBodyResult setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

    }

}
