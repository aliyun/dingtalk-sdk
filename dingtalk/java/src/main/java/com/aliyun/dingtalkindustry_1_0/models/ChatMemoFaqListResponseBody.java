// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoFaqListResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<ChatMemoFaqListResponseBodyData> data;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("total")
    public Integer total;

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
        @NameInMap("answer")
        public String answer;

        @NameInMap("bizId")
        public String bizId;

        @NameInMap("mediaId")
        public String mediaId;

        @NameInMap("question")
        public String question;

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
