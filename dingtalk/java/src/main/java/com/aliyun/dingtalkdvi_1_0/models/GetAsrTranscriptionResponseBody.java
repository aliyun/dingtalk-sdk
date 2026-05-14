// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetAsrTranscriptionResponseBody extends TeaModel {
    @NameInMap("result")
    public GetAsrTranscriptionResponseBodyResult result;

    public static GetAsrTranscriptionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAsrTranscriptionResponseBody self = new GetAsrTranscriptionResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAsrTranscriptionResponseBody setResult(GetAsrTranscriptionResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetAsrTranscriptionResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetAsrTranscriptionResponseBodyResultResultInfoParagraphList extends TeaModel {
        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("paragraph")
        public String paragraph;

        @NameInMap("speakerId")
        public String speakerId;

        @NameInMap("startTime")
        public Long startTime;

        public static GetAsrTranscriptionResponseBodyResultResultInfoParagraphList build(java.util.Map<String, ?> map) throws Exception {
            GetAsrTranscriptionResponseBodyResultResultInfoParagraphList self = new GetAsrTranscriptionResponseBodyResultResultInfoParagraphList();
            return TeaModel.build(map, self);
        }

        public GetAsrTranscriptionResponseBodyResultResultInfoParagraphList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetAsrTranscriptionResponseBodyResultResultInfoParagraphList setParagraph(String paragraph) {
            this.paragraph = paragraph;
            return this;
        }
        public String getParagraph() {
            return this.paragraph;
        }

        public GetAsrTranscriptionResponseBodyResultResultInfoParagraphList setSpeakerId(String speakerId) {
            this.speakerId = speakerId;
            return this;
        }
        public String getSpeakerId() {
            return this.speakerId;
        }

        public GetAsrTranscriptionResponseBodyResultResultInfoParagraphList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

    }

    public static class GetAsrTranscriptionResponseBodyResultResultInfo extends TeaModel {
        @NameInMap("paragraphList")
        public java.util.List<GetAsrTranscriptionResponseBodyResultResultInfoParagraphList> paragraphList;

        public static GetAsrTranscriptionResponseBodyResultResultInfo build(java.util.Map<String, ?> map) throws Exception {
            GetAsrTranscriptionResponseBodyResultResultInfo self = new GetAsrTranscriptionResponseBodyResultResultInfo();
            return TeaModel.build(map, self);
        }

        public GetAsrTranscriptionResponseBodyResultResultInfo setParagraphList(java.util.List<GetAsrTranscriptionResponseBodyResultResultInfoParagraphList> paragraphList) {
            this.paragraphList = paragraphList;
            return this;
        }
        public java.util.List<GetAsrTranscriptionResponseBodyResultResultInfoParagraphList> getParagraphList() {
            return this.paragraphList;
        }

    }

    public static class GetAsrTranscriptionResponseBodyResult extends TeaModel {
        @NameInMap("bizKey")
        public String bizKey;

        @NameInMap("nextToken")
        public String nextToken;

        @NameInMap("resultInfo")
        public GetAsrTranscriptionResponseBodyResultResultInfo resultInfo;

        @NameInMap("taskId")
        public String taskId;

        @NameInMap("taskStatus")
        public String taskStatus;

        public static GetAsrTranscriptionResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetAsrTranscriptionResponseBodyResult self = new GetAsrTranscriptionResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetAsrTranscriptionResponseBodyResult setBizKey(String bizKey) {
            this.bizKey = bizKey;
            return this;
        }
        public String getBizKey() {
            return this.bizKey;
        }

        public GetAsrTranscriptionResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public GetAsrTranscriptionResponseBodyResult setResultInfo(GetAsrTranscriptionResponseBodyResultResultInfo resultInfo) {
            this.resultInfo = resultInfo;
            return this;
        }
        public GetAsrTranscriptionResponseBodyResultResultInfo getResultInfo() {
            return this.resultInfo;
        }

        public GetAsrTranscriptionResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public GetAsrTranscriptionResponseBodyResult setTaskStatus(String taskStatus) {
            this.taskStatus = taskStatus;
            return this;
        }
        public String getTaskStatus() {
            return this.taskStatus;
        }

    }

}
