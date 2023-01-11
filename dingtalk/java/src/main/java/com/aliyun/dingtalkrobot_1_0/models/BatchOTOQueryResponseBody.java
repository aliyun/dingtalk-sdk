// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchOTOQueryResponseBody extends TeaModel {
    /**
     * <p>消息已读情况</p>
     */
    @NameInMap("messageReadInfoList")
    public java.util.List<BatchOTOQueryResponseBodyMessageReadInfoList> messageReadInfoList;

    /**
     * <p>消息发送状态</p>
     */
    @NameInMap("sendStatus")
    public String sendStatus;

    public static BatchOTOQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchOTOQueryResponseBody self = new BatchOTOQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchOTOQueryResponseBody setMessageReadInfoList(java.util.List<BatchOTOQueryResponseBodyMessageReadInfoList> messageReadInfoList) {
        this.messageReadInfoList = messageReadInfoList;
        return this;
    }
    public java.util.List<BatchOTOQueryResponseBodyMessageReadInfoList> getMessageReadInfoList() {
        return this.messageReadInfoList;
    }

    public BatchOTOQueryResponseBody setSendStatus(String sendStatus) {
        this.sendStatus = sendStatus;
        return this;
    }
    public String getSendStatus() {
        return this.sendStatus;
    }

    public static class BatchOTOQueryResponseBodyMessageReadInfoList extends TeaModel {
        /**
         * <p>姓名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>已读状态</p>
         */
        @NameInMap("readStatus")
        public String readStatus;

        /**
         * <p>已读时间</p>
         */
        @NameInMap("readTimestamp")
        public Long readTimestamp;

        /**
         * <p>工号</p>
         */
        @NameInMap("userId")
        public String userId;

        public static BatchOTOQueryResponseBodyMessageReadInfoList build(java.util.Map<String, ?> map) throws Exception {
            BatchOTOQueryResponseBodyMessageReadInfoList self = new BatchOTOQueryResponseBodyMessageReadInfoList();
            return TeaModel.build(map, self);
        }

        public BatchOTOQueryResponseBodyMessageReadInfoList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchOTOQueryResponseBodyMessageReadInfoList setReadStatus(String readStatus) {
            this.readStatus = readStatus;
            return this;
        }
        public String getReadStatus() {
            return this.readStatus;
        }

        public BatchOTOQueryResponseBodyMessageReadInfoList setReadTimestamp(Long readTimestamp) {
            this.readTimestamp = readTimestamp;
            return this;
        }
        public Long getReadTimestamp() {
            return this.readTimestamp;
        }

        public BatchOTOQueryResponseBodyMessageReadInfoList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
