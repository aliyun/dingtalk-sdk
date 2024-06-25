// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoFaqListResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<ChatMemoFaqListResponseBodyData> data;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>200</p>
     */
    @NameInMap("total")
    public Integer total;

    /**
     * <strong>example:</strong>
     * <p>50</p>
     */
    @NameInMap("totalPage")
    public Integer totalPage;

    public static ChatMemoFaqListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoFaqListResponseBody self = new ChatMemoFaqListResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatMemoFaqListResponseBody setData(java.util.List<ChatMemoFaqListResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<ChatMemoFaqListResponseBodyData> getData() {
        return this.data;
    }

    public ChatMemoFaqListResponseBody setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ChatMemoFaqListResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ChatMemoFaqListResponseBody setTotal(Integer total) {
        this.total = total;
        return this;
    }
    public Integer getTotal() {
        return this.total;
    }

    public ChatMemoFaqListResponseBody setTotalPage(Integer totalPage) {
        this.totalPage = totalPage;
        return this;
    }
    public Integer getTotalPage() {
        return this.totalPage;
    }

    public static class ChatMemoFaqListResponseBodyData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>办公室电话是：13223333233</p>
         */
        @NameInMap("answer")
        public String answer;

        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("bizId")
        public String bizId;

        /**
         * <strong>example:</strong>
         * <p>yyyyyy-aaaaaa-bbbbb-cccccccccc.docx</p>
         */
        @NameInMap("mediaId")
        public String mediaId;

        /**
         * <strong>example:</strong>
         * <p>办公室电话是多少</p>
         */
        @NameInMap("question")
        public String question;

        /**
         * <strong>example:</strong>
         * <p><a href="http://www.dingtalk.com/">http://www.dingtalk.com/</a></p>
         */
        @NameInMap("redirection")
        public String redirection;

        public static ChatMemoFaqListResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            ChatMemoFaqListResponseBodyData self = new ChatMemoFaqListResponseBodyData();
            return TeaModel.build(map, self);
        }

        public ChatMemoFaqListResponseBodyData setAnswer(String answer) {
            this.answer = answer;
            return this;
        }
        public String getAnswer() {
            return this.answer;
        }

        public ChatMemoFaqListResponseBodyData setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public ChatMemoFaqListResponseBodyData setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

        public ChatMemoFaqListResponseBodyData setQuestion(String question) {
            this.question = question;
            return this;
        }
        public String getQuestion() {
            return this.question;
        }

        public ChatMemoFaqListResponseBodyData setRedirection(String redirection) {
            this.redirection = redirection;
            return this;
        }
        public String getRedirection() {
            return this.redirection;
        }

    }

}
