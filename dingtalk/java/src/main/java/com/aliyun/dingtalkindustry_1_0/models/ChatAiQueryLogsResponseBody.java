// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAiQueryLogsResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<ChatAiQueryLogsResponseBodyData> data;

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

    public static ChatAiQueryLogsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatAiQueryLogsResponseBody self = new ChatAiQueryLogsResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatAiQueryLogsResponseBody setData(java.util.List<ChatAiQueryLogsResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<ChatAiQueryLogsResponseBodyData> getData() {
        return this.data;
    }

    public ChatAiQueryLogsResponseBody setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ChatAiQueryLogsResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ChatAiQueryLogsResponseBody setTotal(Integer total) {
        this.total = total;
        return this;
    }
    public Integer getTotal() {
        return this.total;
    }

    public ChatAiQueryLogsResponseBody setTotalPage(Integer totalPage) {
        this.totalPage = totalPage;
        return this;
    }
    public Integer getTotalPage() {
        return this.totalPage;
    }

    public static class ChatAiQueryLogsResponseBodyData extends TeaModel {
        @NameInMap("appName")
        public String appName;

        @NameInMap("extendInfo")
        public String extendInfo;

        @NameInMap("feedbackState")
        public Integer feedbackState;

        @NameInMap("feedbackStateDesc")
        public String feedbackStateDesc;

        @NameInMap("question")
        public String question;

        @NameInMap("questionTime")
        public Long questionTime;

        @NameInMap("response")
        public String response;

        @NameInMap("runtime")
        public Long runtime;

        @NameInMap("scene")
        public String scene;

        @NameInMap("sessionType")
        public String sessionType;

        @NameInMap("userId")
        public String userId;

        @NameInMap("userName")
        public String userName;

        public static ChatAiQueryLogsResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            ChatAiQueryLogsResponseBodyData self = new ChatAiQueryLogsResponseBodyData();
            return TeaModel.build(map, self);
        }

        public ChatAiQueryLogsResponseBodyData setAppName(String appName) {
            this.appName = appName;
            return this;
        }
        public String getAppName() {
            return this.appName;
        }

        public ChatAiQueryLogsResponseBodyData setExtendInfo(String extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public String getExtendInfo() {
            return this.extendInfo;
        }

        public ChatAiQueryLogsResponseBodyData setFeedbackState(Integer feedbackState) {
            this.feedbackState = feedbackState;
            return this;
        }
        public Integer getFeedbackState() {
            return this.feedbackState;
        }

        public ChatAiQueryLogsResponseBodyData setFeedbackStateDesc(String feedbackStateDesc) {
            this.feedbackStateDesc = feedbackStateDesc;
            return this;
        }
        public String getFeedbackStateDesc() {
            return this.feedbackStateDesc;
        }

        public ChatAiQueryLogsResponseBodyData setQuestion(String question) {
            this.question = question;
            return this;
        }
        public String getQuestion() {
            return this.question;
        }

        public ChatAiQueryLogsResponseBodyData setQuestionTime(Long questionTime) {
            this.questionTime = questionTime;
            return this;
        }
        public Long getQuestionTime() {
            return this.questionTime;
        }

        public ChatAiQueryLogsResponseBodyData setResponse(String response) {
            this.response = response;
            return this;
        }
        public String getResponse() {
            return this.response;
        }

        public ChatAiQueryLogsResponseBodyData setRuntime(Long runtime) {
            this.runtime = runtime;
            return this;
        }
        public Long getRuntime() {
            return this.runtime;
        }

        public ChatAiQueryLogsResponseBodyData setScene(String scene) {
            this.scene = scene;
            return this;
        }
        public String getScene() {
            return this.scene;
        }

        public ChatAiQueryLogsResponseBodyData setSessionType(String sessionType) {
            this.sessionType = sessionType;
            return this;
        }
        public String getSessionType() {
            return this.sessionType;
        }

        public ChatAiQueryLogsResponseBodyData setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public ChatAiQueryLogsResponseBodyData setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
